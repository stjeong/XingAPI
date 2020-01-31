using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace XingAPINet
{
    internal partial class LoginInfo
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
}
