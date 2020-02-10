using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XingAPINet;

namespace WriteToSqlite
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

            SqliteExtension.UseSqlite("test.sqlite");

            using (XingClient xing = new XingClient(useDemoServer))
            {
                if (xing.ConnectWithLogin(user) == false)
                {
                    Console.WriteLine(xing.ErrorMessage);
                    return;
                }
                
                WriteTmCode();
                WriteSHCode();
            }
        }
        private void WriteSHCode()
        {
            XQt8430.Get().WriteToDB();
            // XQt8430.LoadFrom(XQt8430Gubun.코스닥);
        }

        private void WriteTmCode()
        {
            XQt8425.Get().WriteToDB();
        }

        private LoginInfo GetUserInfo(bool useDemoServer)
        {
            string fileName = (useDemoServer == true) ? "ebest.demo.txt" : "ebest.hts.txt";
            string filePath = $@"d:\settings\{fileName}";

            return LoginInfo.FromEncryptedFile(filePath);
        }
    }
}
