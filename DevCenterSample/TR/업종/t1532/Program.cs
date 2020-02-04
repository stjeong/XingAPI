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
            Program pg = new Program();

            if (args.Length == 1 && args[0] == "hts")
            {
                useDemoServer = false;
            }

            pg.Main(useDemoServer);
        }

        void Main(bool useDemoServer)
        {
            LoginInfo user = GetUserInfo(useDemoServer);

            using (XingClient xing = new XingClient(useDemoServer))
            {
                if (xing.ConnectWithLogin(user) == false)
                {
                    Console.WriteLine(xing.ErrorMessage);
                    return;
                }

                if (useDemoServer)
                {
                    var items = XQt1532.Get(Stock.SHCODE.KOSPI.현대건설);
                    foreach (var item in items)
                    {
                        item.Dump(Console.Out, DumpOutputType.Inline);
                    }
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
