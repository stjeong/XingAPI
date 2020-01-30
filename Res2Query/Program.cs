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
                resFolder = Path.Combine(currentFolder, "..", "..", "..", "ConsoleApp1", "bin", "Debug", "Res");
            }

            string targetFolder = Path.Combine(currentFolder, "ResCS");

            StringBuilder sb = new StringBuilder();

            string[] usingList = new string[]
            {
                "System",
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
            List<string> blockNameList = new List<string>();
            bool inputBlockStarted = false;

            foreach (string line2 in File.ReadAllLines(file, Encoding.GetEncoding("ks_c_5601-1987")))
            {
                string item = line2.Trim();

                if (item.StartsWith(".Func,") == true)
                {
                    classPerTypeName = ToTypeName(item, tab, out typeName);

                    if (typeList.Contains(typeName) == true)
                    {
                        return "";
                    }

                    typeList.Add(typeName);
                    continue;
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

                if (item.EndsWith("input;") == true)
                {
                    inputBlockStarted = true;
                }

                if (item.EndsWith("output;") == true)
                {
                    inputBlockStarted = false;
                }

                if (item == "begin")
                {
                    continue;
                }

                if (item == "end")
                {
                    string block = BlockToText(tab, inputBlockStarted, blockText, blockNameList);
                    sbClass.AppendLine(block);
                    blockText.Clear();
                    continue;
                }

                blockText.Add(item);
            }

            sbClass.AppendLine($"{tab}public class XQ{typeName} : XingQuery");
            sbClass.AppendLine($"{tab}{{");

            sbClass.AppendLine(classPerTypeName);

            sbClass.AppendLine();

            StringBuilder sbBlock = new StringBuilder();
            foreach (string blockTypeName in blockNameList)
            {
                sbBlock.AppendLine($"{tab}\tpublic int Request(XQ{blockTypeName} block, bool bNext = false)");
                sbBlock.AppendLine($"{tab}\t{{");
                {
                    sbBlock.AppendLine($"{tab}\t\tif (block.VerifyData() == false)");
                    sbBlock.AppendLine($"{tab}\t\t{{");
                    sbBlock.AppendLine($"{tab}\t\t\tthrow new ApplicationException(\"Failed to verify: \" + block.BlockName);");
                    sbBlock.AppendLine($"{tab}\t\t}}");
                    sbBlock.AppendLine();
                    sbBlock.AppendLine($"{tab}\t\treturn Request(bNext);");
                }
                sbBlock.AppendLine($"{tab}\t}}");
                sbBlock.AppendLine();
            }

            sbClass.AppendLine(sbBlock.ToString());
            sbClass.AppendLine($"{tab}}}");

            return sbClass.ToString();
        }

        private static string BlockToText(string tab, bool inputBlockStarted, List<string> blockText, List<string> blockNameList)
        {
            StringBuilder sb = new StringBuilder();

            {
                string[] items = blockText[0].Trim(' ', ';').Split(',');

                string typeName = items[0];
                string typeDesc = items[1];
                string typeCode = items[2];

                sb.AppendLine($"{tab}public class XQ{typeName}");
                sb.AppendLine($"{tab}{{");

                {
                    sb.AppendLine($"{tab}\treadonly string _blockName = \"{typeName}\";");
                    sb.AppendLine($"{tab}\treadonly string _blockDesc = \"{typeDesc}\";");
                    sb.AppendLine($"{tab}\treadonly string _blockType = \"{typeCode}\";");
                    sb.AppendLine();
                    sb.AppendLine($"{tab}\tpublic string BlockName => _blockName;");
                    sb.AppendLine($"{tab}\tpublic string BlockDesc => _blockDesc;");
                    sb.AppendLine($"{tab}\tpublic string BlockType => _blockType;");
                }

                blockNameList.Add(typeName);
            }

            sb.AppendLine();

            foreach (string item in blockText.Skip(1))
            {
                string [] items = item.Split(',', ';');

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
                    sb.AppendLine($"{tab}\tpublic {GetFieldType(fieldType, formatOrLen)} {name2};");
                }
            }

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
                        sb.AppendLine($"{tab}\t\tif ({name2}.ToString().Length > {formatOrLen}) return false;");
                        break;

                    case "string":
                        sb.AppendLine($"{tab}\t\tif ({name2}.Length > {formatOrLen}) return false;");
                        break;
                }

            }
            sb.AppendLine();
            sb.AppendLine($"{tab}\t\treturn true;");
            sb.AppendLine($"{tab}\t}}");

            sb.AppendLine($"{tab}}}");

            return sb.ToString();
        }

        public static string GetFieldType(string typeName, decimal Length)
        {
            switch (typeName)
            {
                case "char":
                    if (Length == 1)
                    {
                        return typeName;
                    }

                    return "string";
            }

            return typeName;
        }

        private static string ToTypeName(string line, string tab, out string typeName)
        {
            string[] items = line.Trim(' ', ';').Split(',');

            string typeDesc = items[1];
            typeName = items[2];
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
                        typeService = keyValue[1];
                        break;

                    case "headtype":
                        headType = keyValue[1];
                        break;

                    case "CREATOR":
                        creator = keyValue[1];
                        break;

                    case "CREDATE":
                        credate = keyValue[1];
                        break;
                }
            }

            StringBuilder sb = new StringBuilder();

            {
                sb.AppendLine($"{tab}\treadonly string _typeName = \"{typeName}\";");
                sb.AppendLine($"{tab}\treadonly string _typeDesc = \"{typeDesc}\";");
                sb.AppendLine($"{tab}\treadonly string _service = \"{typeService}\";");
                sb.AppendLine($"{tab}\treadonly string _headType = \"{headType}\";");
                sb.AppendLine($"{tab}\treadonly string _creator = \"{creator}\";");
                sb.AppendLine($"{tab}\treadonly string _createdDate = \"{credate}\";");
                sb.AppendLine($"{tab}\treadonly bool _attr = {hasAttr.ToString().ToLower()};");
                sb.AppendLine($"{tab}\treadonly bool _block = {hasBlock.ToString().ToLower()};");
                sb.AppendLine($"{tab}\treadonly bool _encrypt = {hasEncrypt.ToString().ToLower()};");
                sb.AppendLine($"{tab}\treadonly bool _signature = {hasSignature.ToString().ToLower()};");

                sb.AppendLine();

                sb.AppendLine($"{tab}\tpublic string TypeName => _typeName;");
                sb.AppendLine($"{tab}\tpublic string TypeDesc => _typeDesc;");
                sb.AppendLine($"{tab}\tpublic string Service => _service;");
                sb.AppendLine($"{tab}\tpublic string HeadType => _headType;");
                sb.AppendLine($"{tab}\tpublic string Creator => _creator;");
                sb.AppendLine($"{tab}\tpublic string CreatedDate => _createdDate;");
                sb.AppendLine($"{tab}\tpublic bool Attr => _attr;");
                sb.AppendLine($"{tab}\tpublic bool Block => _block;");
                sb.AppendLine($"{tab}\tpublic bool Encrypt => _encrypt;");
                sb.AppendLine($"{tab}\tpublic bool Signature => _signature;");

                sb.AppendLine();

                sb.AppendLine($"{tab}\tpublic XQ{typeName}() : base(\"{typeName}\") {{ }}");

            }

            return sb.ToString();
        }
    }
}
