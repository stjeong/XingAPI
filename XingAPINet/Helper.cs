using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Cryptography;
using System.Text;

namespace XingAPINet
{
    public enum DumpOutputType
    {
        FormattedKeyValue,
        KeyValue,
    }

    public partial class LoginInfo
    {
        public string Id;
        public string Password;
        public string CertPassword;

        private LoginInfo() { }

        public static LoginInfo CreateInfo(bool useDemoServer)
        {
            string fileName = (useDemoServer == true) ? "ebest.demo.txt" : "ebest.hts.txt";
            string filePath = $@"d:\settings\{fileName}";

            string[] lines = File.ReadAllLines(filePath);
            LoginInfo user = new LoginInfo();

            byte[] entropy = EntropyFrom(lines[0]);
            user.Id = DecryptText(entropy, lines[1]);
            user.Password = DecryptText(entropy, lines[2]);

            if (useDemoServer == false)
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
            byte[] plainText = null;

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
    public partial class XAQueryFieldAttribute : Attribute
    {
        string _fieldDesc;
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
        public static long ParseLong(this string text, string fieldName)
        {
            if (string.IsNullOrEmpty(text) == true)
            {
                throw new InvalidDataFormatException(fieldName, text);
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
                throw new InvalidDataFormatException(fieldName, text);
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
                        fieldText.AppendLine($"\t{key} == {dict[key].FieldFormattedValue}");
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
            }
        }
    }

    [Serializable]
    public class InvalidDataFormatException : System.Exception, ISerializable
    {
        public readonly string DataFieldName;
        public readonly string DataValue;

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
