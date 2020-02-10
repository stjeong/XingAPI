using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XingAPINet;

namespace WriteToSqlite
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pg = new Program();
            pg.Main(true);
        }

        void Main(bool useDemoServer)
        {
            LoginInfo user = GetUserInfo(useDemoServer);

            DBExtension.UseSqlite("test.sqlite");

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
            int totalCode = 0;

            {
                XQt8430.Get(XQt8430Gubun.코스닥).WriteToDB();
                // XQt8430.LoadFrom(XQt8430Gubun.코스닥);
            }

            {
                var items = XQt8430.GetKOSPI(true);
                Dictionary<string, int> names = new Dictionary<string, int>();

                foreach (var item in items)
                {
                    totalCode++;
                }
            }
        }

        private void WriteTmCode()
        {
            var items = XQt8425.Get();
            Dictionary<string, int> names = new Dictionary<string, int>();

            foreach (var item in items)
            {
            }
        }

        private LoginInfo GetUserInfo(bool useDemoServer)
        {
            string fileName = (useDemoServer == true) ? "ebest.demo.txt" : "ebest.hts.txt";
            string filePath = $@"d:\settings\{fileName}";

            return LoginInfo.FromEncryptedFile(filePath);
        }
    }
}
