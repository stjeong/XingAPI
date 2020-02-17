using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XingAPINet;

namespace t1532
{
    class Program
    {
        static void Main(string[] args)
        {
            bool useDemoServer = true;
            bool loadFromDB = false;

            Program pg = new Program();

            if (args.Length == 1)
            {
                if (args[0] == "hts")
                {
                    useDemoServer = false;
                }
                else if (args[0] == "db")
                {
                    loadFromDB = true;
                }
            }

            pg.Main(useDemoServer, loadFromDB);
        }

        void Main(bool useDemoServer, bool loadFromDB)
        {
            SqliteExtension.UseSqlite("test.sqlite");

            LoginInfo user = GetUserInfo(useDemoServer);

            using (XingClient xing = new XingClient(useDemoServer))
            {
                if (xing.ConnectWithLogin(user) == false)
                {
                    Console.WriteLine(xing.ErrorMessage);
                    return;
                }

                if (loadFromDB == true)
                {
                    var items = XQt1532.ReadFromDB();
                    foreach (var item in items)
                    {
                        item.Dump(Console.Out, DumpOutputType.Inline);
                    }
                }
                else if (useDemoServer)
                {
                    var items = XQt1532.Get(Stock.SHCODE.KOSPI.현대건설);
                    foreach (var item in items)
                    {
                        item.Dump(Console.Out, DumpOutputType.Inline);
                    }

                    items.WriteToDB(replace: true);
                }
                else
                {
                    using (var query = new XQt1532())
                    {
                        query.SetFieldData(XQt1532InBlock.BlockName, XQt1532InBlock.F.shcode, 0, Stock.SHCODE.KOSPI.현대건설);

                        if (query.Request() < 0)
                        {
                            Console.WriteLine("Failed to send request");
                        }

                        XQt1532OutBlock[] outBlocks = query.GetBlocks();
                        foreach (var item in outBlocks)
                        {
                            if (item.IsValidData == true)
                            {
                                item.Dump(Console.Out, DumpOutputType.Inline);
                            }
                        }
                    }
                }
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
