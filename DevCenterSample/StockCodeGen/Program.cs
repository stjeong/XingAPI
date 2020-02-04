using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using XingAPINet;

namespace StockCodeGen
{
    class Program
    {
        static void Main(string[] _)
        {
            Program pg = new Program();
            pg.Main(true);
        }

        void Main(bool useDemoServer)
        {
            LoginInfo user = GetUserInfo(useDemoServer);
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("namespace XingAPINet");
            sb.AppendLine("{");

            using (XingClient xing = new XingClient(useDemoServer))
            {
                if (xing.ConnectWithLogin(user) == false)
                {
                    Console.WriteLine(xing.ErrorMessage);
                    return;
                }

                string tab = "\t";

                sb.AppendLine($"{tab}public partial class Stock");
                sb.AppendLine($"{tab}{{");
                string tmcodes = GetTmCode(tab + "\t");
                sb.AppendLine(tmcodes);
                sb.AppendLine($"{tab}}}");
            }

            sb.AppendLine("}");

            File.WriteAllText("Stock.cs", sb.ToString(), Encoding.UTF8);
        }

        private string GetTmCode(string tab)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{tab}public partial class TMCODE");
            sb.AppendLine($"{tab}{{");

            var items = XQt8425.Get();
            foreach (var item in items)
            {
                sb.AppendLine($"{tab}\tpublic const string {ToVariableName(item.tmname)} = \"{item.tmcode}\";");
            }

            sb.AppendLine($"{tab}}}");

            return sb.ToString();
        }

        private string ToVariableName(string tmname)
        {
            string result = tmname.Replace(" ", "");
            result = result.Replace("(", "");
            result = result.Replace(")", "");
            result = result.Replace("/", "");
            result = result.Replace("&", "");
            result = result.Replace("＆", "");
            result = result.Replace(",", "");
            result = result.Replace("-", "");

            result = AddIfStartWithDigit(result);

            return result;
        }

        private string AddIfStartWithDigit(string result)
        {
            if (int.TryParse(result[0].ToString(), out int _) == true)
            {
                return "_" + result;
            }

            return result;
        }

        private LoginInfo GetUserInfo(bool useDemoServer)
        {
            string fileName = (useDemoServer == true) ? "ebest.demo.txt" : "ebest.hts.txt";
            string filePath = $@"d:\settings\{fileName}";

            return LoginInfo.FromEncryptedFile(filePath);
        }
    }
}
