using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XingAPINet;

namespace t1302
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
                    var items = XQt1302.Get(Stock.SHCODE.KOSPI.SK하이닉스,
                        gubun: XQt1302.Gubun._60분,
                        cnt: 10);

                    Console.WriteLine($"# of items: {items.Length}");
                    foreach (var item in items)
                    {
                        item.Dump(Console.Out, DumpOutputType.Inline80Cols);
                    }
                }
                else
                {
                    using (var query = new XQt1302())
                    {
                        XQt1302InBlock inBlock = new XQt1302InBlock()
                        {
                            shcode = Stock.SHCODE.KOSPI.SK하이닉스,
                            gubun = XQt1302.Gubun._60분,
                            cnt = 10,
                        };

                        if (query.SetBlock(inBlock) == false)
                        {
                            Console.WriteLine($"Failed to set block");
                            return;
                        }

                        if (query.Request() < 0)
                        {
                            Console.WriteLine("Failed to send request");
                            return;
                        }

                        XQt1302OutBlock1[] outBlocks = query.GetBlock1s();
                        foreach (var item in outBlocks)
                        {
                            if (item.IsValidData == true)
                            {
                                item.Dump(Console.Out, DumpOutputType.Inline80Cols);
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
