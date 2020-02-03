using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Res2Query
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentFolder = Path.GetDirectoryName(typeof(Program).Assembly.Location);
            string resFolder;

            if (args.Length >= 1)
            {
                resFolder = args[0];
            }
            else
            {
                resFolder = Path.Combine(currentFolder, "..", "..", "..", "Lib", "Res");
            }

            string targetFolder = Path.Combine(currentFolder, "ResCS");

            StringBuilder sb = new StringBuilder();

            string[] usingList = new string[]
            {
                "System",
                "System.IO",
                "System.Collections.Generic",
                "System.Linq",
                "System.Runtime.InteropServices",
                "System.Text",
                "XingAPINet",
            };

            foreach (string usingName in usingList)
            {
                sb.AppendLine($"using {usingName};");
            }

            sb.AppendLine();
            sb.AppendLine("namespace XingAPINet");
            sb.AppendLine("{");

            HashSet<string> typeList = new HashSet<string>();

            foreach (string file in Directory.EnumerateFiles(resFolder, "*.res"))
            {
                string text = ResToCSharpCode(file, typeList);
                sb.AppendLine(text);
            }

            sb.AppendLine(TypeNameListToResourceCode(typeList));

            sb.AppendLine("}");

            File.WriteAllText("XingQueries.cs", sb.ToString(), Encoding.UTF8);
        }

        private static string TypeNameListToResourceCode(HashSet<string> typeList)
        {
            string tab = "\t";

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{tab}public static class ResourceCodes");
            sb.AppendLine($"{tab}{{");

            foreach (string typeName in typeList)
            {
                if (string.IsNullOrEmpty(typeName) == false)
                {
                    sb.AppendLine($"{tab}{tab}public const string {typeName} = \"{typeName}\";");
                }
            }

            sb.AppendLine($"{tab}}}");

            return sb.ToString();
        }

        private static string ResToCSharpCode(string file, HashSet<string> typeList)
        {
            string tab = "\t";
            string typeName = null;
            string classPerTypeName = null;

            bool dataMapStarted = false;

            StringBuilder sbClass = new StringBuilder();

            List<string> blockText = new List<string>();
            Dictionary<string, BlockInfo> blockFieldSetList = new Dictionary<string, BlockInfo>();
            bool blockStarted = false;
            bool isRealType = false;

            foreach (string line2 in File.ReadAllLines(file, Encoding.GetEncoding("ks_c_5601-1987")))
            {
                string item = line2.Trim();

                if (item.StartsWith(".Func,") == true)
                {
                    classPerTypeName = ToQueryTypeName(item, tab, out typeName);

                    if (typeList.Contains(typeName) == true)
                    {
                        return "";
                    }

                    typeList.Add(typeName);
                    continue;
                }

                if (item.StartsWith(".Feed,") == true)
                {
                    classPerTypeName = ToRealTypeName(item, tab, out typeName);

                    if (typeList.Contains(typeName) == true)
                    {
                        return "";
                    }

                    isRealType = true;
                }

                if (item.StartsWith("BEGIN_DATA_MAP") == true)
                {
                    dataMapStarted = true;
                    continue;
                }

                if (dataMapStarted == false)
                {
                    continue;
                }

                if (item == "begin")
                {
                    blockStarted = true;
                    continue;
                }

                if (blockStarted == true && item == "end")
                {
                    string block = BlockToText(tab, isRealType, typeName, blockText, blockFieldSetList);
                    sbClass.AppendLine(block);
                    blockText.Clear();
                    blockStarted = false;
                    continue;
                }

                blockText.Add(item);
            }

            string classPrefix = (isRealType == true) ? "XR" : "XQ";

            sbClass.AppendLine($"{tab}public partial class {classPrefix}{typeName} : " + ((isRealType == true) ? "XingReal" : "XingQuery"));
            sbClass.AppendLine($"{tab}{{");

            sbClass.AppendLine(classPerTypeName);

            sbClass.AppendLine();

            StringBuilder sbBlock = new StringBuilder();

            foreach (string blockTypeName in blockFieldSetList.Keys)
            {
                if (blockFieldSetList[blockTypeName].BlockType == BlockType.input)
                {
                    sbBlock.AppendLine($"{tab}\tpublic bool SetFields({classPrefix}{blockTypeName} block)");
                    sbBlock.AppendLine($"{tab}\t{{");
                    {
                        sbBlock.AppendLine($"{tab}\t\tif (block.VerifyData() == false)");
                        sbBlock.AppendLine($"{tab}\t\t{{");
                        sbBlock.AppendLine($"{tab}\t\t\treturn false; // throw new ApplicationException(\"Failed to verify: \" + block.BlockName);");
                        sbBlock.AppendLine($"{tab}\t\t}}");
                        sbBlock.AppendLine();

                        sbBlock.AppendLine(blockFieldSetList[blockTypeName].SetFieldData);

                    }
                    sbBlock.AppendLine($"{tab}\t\treturn true;");
                    sbBlock.AppendLine($"{tab}\t}}");
                    sbBlock.AppendLine();
                }
                else if (blockFieldSetList[blockTypeName].BlockType == BlockType.output)
                {
                    sbBlock.AppendLine($"{tab}\tpublic {classPrefix}{blockTypeName} Get{GetBlockIndex(typeName, blockTypeName)}()");
                    sbBlock.AppendLine($"{tab}\t{{");
                    {
                        sbBlock.AppendLine($"{tab}\t\t{classPrefix}{blockTypeName} instance = {classPrefix}{blockTypeName}.FromQuery(this);");
                        sbBlock.AppendLine($"{tab}\t\treturn instance;");
                        sbBlock.AppendLine();
                    }
                    sbBlock.AppendLine($"{tab}\t}}");
                    sbBlock.AppendLine();
                }
            }

            sbClass.AppendLine(sbBlock.ToString());
            sbClass.AppendLine($"{tab}}}");

            return sbClass.ToString();
        }

        public static string GetBlockIndex(string typeName, string blockTypeName)
        {
            return blockTypeName.Substring(typeName.Length + "Out".Length);
        }
        
        private static string BlockToText(string tab, bool isRealType, string queryTypeName, List<string> blockText,
            Dictionary<string, BlockInfo> blockFieldSetList)
        {
            StringBuilder sb = new StringBuilder();
            string typeName;
            string typeCode;

            string classPrefix = (isRealType == true) ? "XR" : "XQ";

            {
                string[] items = blockText[0].Trim(' ', ';').Split(',');

                typeName = (isRealType == true) ? queryTypeName + items[0] : items[0];
                string typeDesc = items[1];
                typeCode = items[2];

                sb.AppendLine($"{tab}public partial class {classPrefix}{typeName} : XingBlock");
                sb.AppendLine($"{tab}{{");

                {
                    AddField(sb, tab + "\t", "string", "_blockName", items[0]);
                    AddField(sb, tab + "\t", "string", "_blockDesc", typeDesc);
                    AddField(sb, tab + "\t", "string", "_blockType", typeCode);

                    AddGetProperty(sb, tab + "\t", "override string", "GetBlockName()", "_blockName", items[0]);
                    AddGetProperty(sb, tab + "\t", "static string", "BlockName", "_blockName", items[0]);
                    AddGetProperty(sb, tab + "\t", "string", "BlockDesc", "_blockDesc", typeDesc);
                    AddGetProperty(sb, tab + "\t", "string", "BlockType", "_blockType", typeCode);
                }

                if (blockFieldSetList.ContainsKey(typeName) == true)
                {
                    throw new ApplicationException("Duplicated: " + typeName);
                }
            }

            sb.AppendLine();

            StringBuilder setFields = new StringBuilder();
            StringBuilder getFields = new StringBuilder();
            int fieldIndex = 0;

            string baseClassInstance = (isRealType == true) ? "_xaReal" : "_xaQuery";

            foreach (string item in blockText.Skip(1))
            {
                string[] items = item.Split(',', ';');

                string fieldDesc = items[0].Trim();
                // string name1 = items[1].Trim();
                string name2 = items[2].Trim();

                //if (name1 != name2)
                //{
                //    t1102OutBlock - 외국계매도평단가,ftradmdvag,ftradmdavg,long,8;
                //    throw new ApplicationException($"NOT EXPECTED: {name1} != {name2}");
                //}

                string fieldType = items[3].Trim();
                decimal formatOrLen = decimal.Parse(items[4].Trim());

                {
                    AddXmlHelp(sb, tab + "\t", fieldDesc);
                    sb.AppendLine($"{tab}\t[XAQueryFieldAttribute(\"{fieldDesc}\")]");
                    sb.AppendLine($"{tab}\tpublic {GetFieldType(fieldType, formatOrLen)} {name2};");
                }

                if (isRealType == true)
                {
                    setFields.AppendLine($"{tab}\t\t{baseClassInstance}.SetFieldData(block.GetBlockName(), \"{name2}\", block.{name2}{SetFieldToStringExp(fieldType, formatOrLen)}); // {fieldType} {formatOrLen}");
                    getFields.AppendLine($"{tab}\t\t\tblock.{name2} = query.GetFieldData(block.GetBlockName(), \"{name2}\"){GetFieldToStringExp(fieldType, name2, formatOrLen)}; // {fieldType} {formatOrLen}");
                }
                else
                {
                    setFields.AppendLine($"{tab}\t\t{baseClassInstance}.SetFieldData(block.GetBlockName(), \"{name2}\", {fieldIndex}, block.{name2}{SetFieldToStringExp(fieldType, formatOrLen)}); // {fieldType} {formatOrLen}");
                    getFields.AppendLine($"{tab}\t\t\tblock.{name2} = query.GetFieldData(block.GetBlockName(), \"{name2}\", {fieldIndex}){GetFieldToStringExp(fieldType, name2, formatOrLen)}; // {fieldType} {formatOrLen}");
                }
            }

            blockFieldSetList[typeName] = new BlockInfo(typeCode, setFields.ToString());

            // public Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
            {
                sb.AppendLine();

                sb.AppendLine($"{tab}\tpublic override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()");
                sb.AppendLine($"{tab}\t{{");
                sb.AppendLine($"{tab}\t\tDictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();");
                foreach (string item in blockText.Skip(1))
                {
                    string[] items = item.Split(',', ';');

                    string fieldDesc = items[0].Trim();
                    string name2 = items[2].Trim();
                    string fieldType = items[3].Trim();
                    decimal formatOrLen = decimal.Parse(items[4].Trim());

                    sb.AppendLine($"{tab}\t\tdict[\"{name2}\"] = new XAQueryFieldInfo(\"{fieldType}\", {name2}, {name2}{SetFieldToStringExp(fieldType, formatOrLen)}, \"{fieldDesc}\", (decimal){formatOrLen});");
                }

                sb.AppendLine();
                sb.AppendLine($"{tab}\t\treturn dict;");
                sb.AppendLine($"{tab}\t}}");
            }

            // public bool FromQuery
            if (blockFieldSetList[typeName].BlockType == BlockType.output)
            {
                sb.AppendLine();

                sb.AppendLine($"{tab}\tpublic static {classPrefix}{typeName} FromQuery({classPrefix}{queryTypeName} query)");
                sb.AppendLine($"{tab}\t{{");

                sb.AppendLine($"{tab}\t\t{classPrefix}{typeName} block = new {classPrefix}{typeName}();");
                sb.AppendLine($"{tab}\t\tblock.IsValidData = true;");
                sb.AppendLine($"{tab}\t\tblock.InvalidReason = \"\";");

                if (isRealType == false)
                {
                    sb.AppendLine($"{tab}\t\tif (query.QueryResult != null && query.QueryResult.IsSystemError == true)");
                    sb.AppendLine($"{tab}\t\t{{");
                    sb.AppendLine($"{tab}\t\t\tblock.IsValidData = false;");
                    sb.AppendLine($"{tab}\t\t\tblock.InvalidReason = query.ReceiveMessage;");
                    sb.AppendLine($"{tab}\t\t\treturn block;");
                    sb.AppendLine($"{tab}\t\t}}");
                }

                sb.AppendLine($"{tab}\t\ttry");
                sb.AppendLine($"{tab}\t\t{{");

                sb.AppendLine(getFields.ToString());

                sb.AppendLine($"{tab}\t\t}} catch (InvalidDataFormatException e) {{");
                sb.AppendLine($"{tab}\t\t\tblock.IsValidData = false;");

                sb.AppendLine($"{tab}\t\t\tblock.InvalidReason = $\"FieldName == {{e.DataFieldName}}, FieldData == \\\"{{e.DataValue}}\\\"\";");

                sb.AppendLine($"{tab}\t\t}}");
                sb.AppendLine($"{tab}\t\treturn block;");
                sb.AppendLine();
                sb.AppendLine($"{tab}\t}}");
            }

            // public bool VerifyData
            {
                sb.AppendLine();

                sb.AppendLine($"{tab}\tpublic bool VerifyData()");
                sb.AppendLine($"{tab}\t{{");
                foreach (string item in blockText.Skip(1))
                {
                    string[] items = item.Split(',', ';');

                    string name2 = items[2].Trim();
                    string fieldType = items[3].Trim();
                    decimal formatOrLen = decimal.Parse(items[4].Trim());

                    switch (GetFieldType(fieldType, formatOrLen))
                    {
                        case "long":
                            sb.AppendLine($"{tab}\t\tif ({name2}.ToString().Length > {formatOrLen}) return false; // {fieldType} {formatOrLen}");
                            break;

                        case "string":
                            sb.AppendLine($"{tab}\t\tif ({name2}.Length > {formatOrLen}) return false; // {fieldType} {formatOrLen}");
                            break;

                        default:
                            sb.AppendLine($"{tab}\t\t// {name2} {fieldType} {formatOrLen}");
                            break;
                    }
                }

                sb.AppendLine();
                sb.AppendLine($"{tab}\t\treturn true;");
                sb.AppendLine($"{tab}\t}}");
            }

            sb.AppendLine($"{tab}}}");

            return sb.ToString();
        }

        public static string GetFieldToStringExp(string typeName, string fieldName, decimal length)
        {
            switch (typeName)
            {
                case "char":
                    if (length == 1)
                    {
                        return $".First()";
                    }
                    break;

                case "long":
                    return $".ParseLong(\"{fieldName}\")";

                case "float":
                    return $".ParseFloat(\"{fieldName}\")";

                case "double":
                    return $".ParseDouble(\"{fieldName}\")";
            }

            return "";
        }

        public static string SetFieldToStringExp(string typeName, decimal length)
        {
            switch (typeName)
            {
                case "char":
                    if (length == 1)
                    {
                        return ".ToString()";
                    }

                    return "";

                case "long":
                    return $".ToString(\"d{length}\")";

                case "float":
                case "double":
                    return $".ToString(\"{ToDoubleFormatSpecifier(length.ToString())}\")";
            }

            return "";
        }

        private static string ToDoubleFormatSpecifier(string text)
        {
            string[] digits = text.Split('.');
            if (digits.Length > 2)
            {
                throw new ApplicationException("Invalid float/double format specifier");
            }

            int integral = Int32.Parse(digits[0]);
            int fraction = 0;

            if (digits.Length == 1)
            {
                return new string('0', integral);
            }
            else
            {
                fraction = Int32.Parse(digits[1]);
                return new string('0', integral) + "." + new string('0', fraction);
            }
        }

        public static string GetFieldType(string typeName, decimal length)
        {
            switch (typeName)
            {
                case "char":
                    if (length == 1)
                    {
                        return typeName;
                    }

                    return "string";
            }

            return typeName;
        }

        static string ToRealTypeName(string line, string tab, out string typeName)
        {
            string[] items = line.Trim(' ', ';').Split(',');

            string typeDesc = items[1].Trim();
            typeName = items[2].Trim();
            int key = 0;
            int group = 0;
            bool hasAttr = false;

            foreach (string item in items)
            {
                string[] keyValue = item.Split('=');
                switch (keyValue[0])
                {
                    case "attr":
                        hasAttr = true;
                        break;

                    case "key":
                        key = int.Parse(keyValue[1]);
                        break;

                    case "group":
                        group = int.Parse(keyValue[1]);
                        break;
                }
            }

            StringBuilder sb = new StringBuilder();

            {
                AddField(sb, tab + "\t", "string", "_typeName", typeName);
                AddField(sb, tab + "\t", "bool", "_attr", hasAttr);
                AddField(sb, tab + "\t", "int", "_key", key);
                AddField(sb, tab + "\t", "int", "_group", group);

                sb.AppendLine();

                AddGetProperty(sb, tab + "\t", "string", "TypeName", "_typeName", typeName);
                AddGetProperty(sb, tab + "\t", "bool", "Attr", "_attr", hasAttr);
                AddGetProperty(sb, tab + "\t", "int", "Key", "_key", key);
                AddGetProperty(sb, tab + "\t", "int", "Group", "_group", group);

                sb.AppendLine();

                sb.AppendLine($"{tab}\tpublic XR{typeName}() : base(\"{typeName}\") {{ }}");

            }

            return sb.ToString();
        }

        private static string ToQueryTypeName(string line, string tab, out string typeName)
        {
            string[] items = line.Trim(' ', ';').Split(',');

            string typeDesc = items[1].Trim();
            typeName = items[2].Trim();
            bool hasAttr = false;
            bool hasBlock = false;
            bool hasEncrypt = false;
            bool hasSignature = false;
            string typeService = "";
            string headType = "";
            string creator = "";
            string credate = "";

            foreach (string item in items)
            {
                string[] keyValue = item.Split('=');
                switch (keyValue[0])
                {
                    case "attr":
                        hasAttr = true;
                        break;

                    case "block":
                        hasBlock = true;
                        break;

                    case "ENCRYPT":
                        hasEncrypt = true;
                        break;

                    case "SIGNATURE":
                        hasSignature = true;
                        break;

                    case "SERVICE":
                        typeService = keyValue[1].Trim();
                        break;

                    case "headtype":
                        headType = keyValue[1].Trim();
                        break;

                    case "CREATOR":
                        creator = keyValue[1].Trim();
                        break;

                    case "CREDATE":
                        credate = keyValue[1].Trim();
                        break;
                }
            }

            StringBuilder sb = new StringBuilder();

            {
                AddField(sb, tab + "\t", "string", "_typeName", typeName);
                AddField(sb, tab + "\t", "string", "_typeDesc", typeDesc);
                AddField(sb, tab + "\t", "string", "_service", typeService);
                AddField(sb, tab + "\t", "string", "_headType", headType);
                AddField(sb, tab + "\t", "string", "_creator", creator);
                AddField(sb, tab + "\t", "string", "_createdDate", credate);
                AddField(sb, tab + "\t", "bool", "_attr", hasAttr);
                AddField(sb, tab + "\t", "bool", "_block", hasBlock);
                AddField(sb, tab + "\t", "bool", "_encrypt", hasEncrypt);
                AddField(sb, tab + "\t", "bool", "_signature", hasSignature);

                sb.AppendLine();

                AddGetProperty(sb, tab, "string", "TypeName", "_typeName", typeName);
                AddGetProperty(sb, tab, "string", "TypeDesc", "_typeDesc", typeDesc);
                AddGetProperty(sb, tab, "string", "Service", "_service", typeService);
                AddGetProperty(sb, tab, "string", "HeadType", "_headType", headType);
                AddGetProperty(sb, tab, "string", "Creator", "_creator", creator);
                AddGetProperty(sb, tab, "string", "CreatedDate", "_createdDate", credate);

                AddGetProperty(sb, tab, "bool", "Attr", "_attr", hasAttr);
                AddGetProperty(sb, tab, "bool", "Block", "_block", hasBlock);
                AddGetProperty(sb, tab, "bool", "Encrypt", "_encrypt", hasEncrypt);
                AddGetProperty(sb, tab, "bool", "Signature", "_signature", hasSignature);

                sb.AppendLine();

                sb.AppendLine($"{tab}\tpublic XQ{typeName}() : base(\"{typeName}\") {{ }}");
            }

            return sb.ToString();
        }

        private static void AddField(StringBuilder sb, string tab, string fieldType, string fieldName, int value)
        {
            AddField(sb, tab, fieldType, fieldName, value.ToString());
        }

        private static void AddField(StringBuilder sb, string tab, string fieldType, string fieldName, bool value)
        {
            AddField(sb, tab, fieldType, fieldName, value.ToString().ToLower());
        }

        private static void AddField(StringBuilder sb, string tab, string fieldType, string fieldName, string value)
        {
            AddXmlHelp(sb, tab, value);

            string valueText = value;
            switch (fieldType)
            {
                case "string":
                    valueText = $"\"{value}\"";
                    break;
            }

            sb.AppendLine($"{tab}static readonly {fieldType} {fieldName} = {valueText};");
        }

        private static void AddGetProperty(StringBuilder sb, string tab, string propType, string propName, string fieldName, int fieldValue)
        {
            AddGetProperty(sb, tab, propType, propName, fieldName, fieldValue.ToString());
        }

        private static void AddGetProperty(StringBuilder sb, string tab, string propType, string propName, string fieldName, bool fieldValue)
        {
            AddGetProperty(sb, tab, propType, propName, fieldName, fieldValue.ToString().ToLower());
        }

        private static void AddGetProperty(StringBuilder sb, string tab, string propType, string propName, string fieldName, string fieldValue)
        {
            AddXmlHelp(sb, tab, fieldValue);
            sb.AppendLine($"{tab}public {propType} {propName} => {fieldName};");
        }

        public static void AddXmlHelp(StringBuilder sb, string tab, bool value)
        {
            AddXmlHelp(sb, tab, value.ToString().ToLower());
        }

        public static void AddXmlHelp(StringBuilder sb, string tab, string value)
        {
            sb.AppendLine($"{tab}/// <summary>");
            sb.AppendLine($"{tab}/// {value}");
            sb.AppendLine($"{tab}/// </summary>");
        }
    }
}
