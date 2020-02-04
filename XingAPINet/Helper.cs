using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Cryptography;
using System.Text;

namespace XingAPINet
{
    public partial class Stock
    {
        public static class SHCODE
        {
            public const string 이베스트 = "078020";
            public const string 현대건설 = "000720";
            public const string 현대로템 = "064350";
        }
    }

    public enum DumpOutputType
    {
        FormattedKeyValue,
        KeyValue,
        Inline,
        Inline80Cols,
    }

    public partial class LoginInfo
    {
        public string Id;
        public string Password;
        public string CertPassword;

        public static void EncryptToFile(string id, string pw, string certPass, string filePath)
        {
            StringBuilder output = new StringBuilder();

            byte[] entropy = Encoding.UTF8.GetBytes(Guid.NewGuid().ToString());
            string text = entropy.AsText();

            output.AppendLine(text);
            output.AppendLine(EncryptText(id, entropy, true));
            output.AppendLine(EncryptText(pw, entropy, true));

            if (string.IsNullOrEmpty(certPass) == false)
            {
                output.AppendLine(EncryptText(certPass, entropy, true));
            }

            File.WriteAllText(filePath, output.ToString());            
        }

        static string EncryptText(string text, byte [] entropy, bool useCurrentUser)
        {
            byte[] originalText = Encoding.Unicode.GetBytes(text);

            // then use Protect() to encrypt your data 
            byte[] encryptedText = ProtectedData.Protect(originalText, entropy,
                (useCurrentUser == true) ? DataProtectionScope.CurrentUser : DataProtectionScope.LocalMachine);

            return Convert.ToBase64String(encryptedText);
        }

        private LoginInfo() { }

        public static LoginInfo FromPlainText(string id, string password, string certPassword)
        {
            LoginInfo user = new LoginInfo();

            user.Id = id;
            user.Password = password;
            user.CertPassword = certPassword;

            return user;
        }

        public static LoginInfo FromEncryptedFile(string filePath)
        {
            LoginInfo user = new LoginInfo();

            string[] lines = File.ReadAllLines(filePath);
            
            byte[] entropy = EntropyFrom(lines[0]);
            user.Id = DecryptText(entropy, lines[1]);
            user.Password = DecryptText(entropy, lines[2]);

            if (lines.Length >= 4)
            {
                user.CertPassword = DecryptText(entropy, lines[3]);
            }

            return user;
        }

        private static string DecryptText(byte[] entropy, string text)
        {
            if (string.IsNullOrEmpty(text) == true)
            {
                return "";
            }

            byte[] encryptedText = Convert.FromBase64String(text);
            byte[] plainText;

            try
            {
                plainText = ProtectedData.Unprotect(encryptedText, entropy, DataProtectionScope.CurrentUser);
            }
            catch
            {
                return "";
            }

            return Encoding.Unicode.GetString(plainText);
        }

        private static byte[] EntropyFrom(string text)
        {
            List<byte> entropy = new List<byte>();

            string[] bytes = text.Split(',');
            foreach (string item in bytes)
            {
                string coded = item.Trim().Substring(2);
                if (string.IsNullOrEmpty(coded) == true)
                {
                    continue;
                }

                if (byte.TryParse(coded, System.Globalization.NumberStyles.HexNumber, null, out byte result) == true)
                {
                    entropy.Add(result);
                }
            }

            return entropy.ToArray();
        }

    }

    [AttributeUsage(AttributeTargets.Field, Inherited = false)]
    public sealed partial class XAQueryFieldAttribute : Attribute
    {
        readonly string _fieldDesc;
        public string FieldDesc => _fieldDesc;

        public XAQueryFieldAttribute(string fieldDesc)
        {
            _fieldDesc = fieldDesc;
        }
    }

    public partial class XAQueryFieldInfo
    {
        readonly string _fieldDesc;
        public string FieldDesc => _fieldDesc;

        readonly decimal _lengthOrFormat;
        public decimal LengthOrFormat => _lengthOrFormat;

        readonly string _fieldType;
        public string FieldType => _fieldType;

        readonly string _fieldValue;
        public string FieldValue => _fieldValue;

        readonly string _fieldFormattedValue;
        public string FieldFormattedValue => _fieldFormattedValue;

        public XAQueryFieldInfo(string fieldType, object fieldValue, string fieldFormattedValue, string fieldDesc, decimal lengthOrFormat)
        {
            _fieldType = fieldType;
            _fieldValue = fieldValue.ToString();
            _fieldFormattedValue = fieldFormattedValue;
            _fieldDesc = fieldDesc;
            _lengthOrFormat = lengthOrFormat;
        }
    }

    public partial class XAQueryResult
    {
        readonly bool _isSystemError;
        public bool IsSystemError => _isSystemError;

        readonly string _code;
        public string Code => _code;

        readonly string _message;
        public string Message => _message;

        public XAQueryResult(bool isSystemError, string messageCode, string message)
        {
            _isSystemError = isSystemError;
            _code = messageCode;
            _message = message;
        }
    }

    public static class ExtensionMethods
    {
        public static string AsText(this byte [] buffer)
        {
            StringBuilder sb = new StringBuilder();

            foreach (byte item in buffer)
            {
                sb.Append("0x" + item.ToString("x") + ",");
            }

            return sb.ToString().TrimEnd(',');
        }

        public static int ParseInt(this string text, string fieldName)
        {
            if (string.IsNullOrEmpty(text) == true)
            {
                return 0;
                // throw new InvalidDataFormatException(fieldName, text);
            }

            if (int.TryParse(text, out int parsedResult) == true)
            {
                return parsedResult;
            }

            throw new InvalidDataFormatException(fieldName, text);
        }

        public static long ParseLong(this string text, string fieldName)
        {
            if (string.IsNullOrEmpty(text) == true)
            {
                return 0;
                // throw new InvalidDataFormatException(fieldName, text);
            }

            if (long.TryParse(text, out long parsedResult) == true)
            {
                return parsedResult;
            }

            throw new InvalidDataFormatException(fieldName, text);
        }

        public static float ParseFloat(this string text, string fieldName)
        {
            if (string.IsNullOrEmpty(text) == true)
            {
                return 0.0f;
                // throw new InvalidDataFormatException(fieldName, text);
            }

            if (float.TryParse(text, out float parsedResult) == true)
            {
                return parsedResult;
            }

            throw new InvalidDataFormatException(fieldName, text);
        }

        public static double ParseDouble(this string text, string fieldName)
        {
            if (string.IsNullOrEmpty(text) == true)
            {
                throw new InvalidDataFormatException(fieldName, text);
            }

            if (double.TryParse(text, out double parsedResult) == true)
            {
                return parsedResult;
            }

            throw new InvalidDataFormatException(fieldName, text);
        }

        public static void Dump(this TextWriter writer, string blockName, Dictionary<string, XAQueryFieldInfo> dict, DumpOutputType outputType)
        {
            StringBuilder sbDump = new StringBuilder();
            StringBuilder fieldText = new StringBuilder();
            int totalSize = 0;

            switch (outputType)
            {
                case DumpOutputType.FormattedKeyValue:
                    foreach (string key in dict.Keys)
                    {
                        fieldText.AppendLine($"\t{key} == {dict[key].FieldFormattedValue} // {dict[key].FieldDesc}");
                        totalSize += (int)Math.Truncate(dict[key].LengthOrFormat);
                    }

                    sbDump.AppendLine($"[{blockName}: sizeof() == {totalSize}]");
                    writer.WriteLine(sbDump.ToString() + fieldText.ToString());
                    break;

                case DumpOutputType.KeyValue:
                    foreach (string key in dict.Keys)
                    {
                        fieldText.AppendLine($"\t{key} == {dict[key].FieldValue}");
                        totalSize += (int)Math.Truncate(dict[key].LengthOrFormat);
                    }

                    sbDump.AppendLine($"[{blockName}: sizeof() == {totalSize}]");
                    writer.WriteLine(sbDump.ToString() + fieldText.ToString());
                    break;

                case DumpOutputType.Inline:
                    foreach (string key in dict.Keys)
                    {
                        fieldText.Append($"{key} = {dict[key].FieldValue}, ");
                    }

                    writer.WriteLine(fieldText.ToString().TrimEnd(','));
                    break;

                case DumpOutputType.Inline80Cols:
                    foreach (string key in dict.Keys)
                    {
                        fieldText.Append($"{key} = {dict[key].FieldValue}, ");
                    }

                    string line = fieldText.ToString().TrimEnd(',');;
                    writer.WriteLine(line.Substring(0, Math.Min(line.Length, 80)) + ((line.Length > 80) ? "..." : ""));
                    break;
            }
        }
    }

    [Serializable]
    public class InvalidDataFormatException : System.Exception, ISerializable
    {
        public readonly string DataFieldName;
        public readonly string DataValue;

        public InvalidDataFormatException() : this("") { }

        public InvalidDataFormatException(string message) : this("", "", message) { }

        public InvalidDataFormatException(string dataFieldName, string invalidValue) : this(dataFieldName, invalidValue, "")
        {
        }

        public InvalidDataFormatException(string dataFieldName, string invalidValue, string message) : base(message)
        {
            DataFieldName = dataFieldName;
            DataValue = invalidValue;
        }

        public InvalidDataFormatException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected InvalidDataFormatException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        [SecurityCritical]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
        }
    }

    public class RealDataArgs : EventArgs
    {
        readonly string _trCode;
        public string TrCode => _trCode;

        public RealDataArgs(string trCode)
        {
            _trCode = trCode;
        }
    }
}
