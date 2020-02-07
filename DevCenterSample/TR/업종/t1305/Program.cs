using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XingAPINet;

namespace t1305
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
                    var multiBlock = XQt1305.Get(Stock.SHCODE.KOSPI.SK하이닉스, 
                        dwmcode: XQt1305.DWMCode.일,
                        cnt: 10);

                    if (multiBlock.OutBlock.IsValidData == false)
                    {
                        return;
                    }

                    multiBlock.OutBlock.Dump(Console.Out, DumpOutputType.Inline80Cols);

                    Console.WriteLine($"# of items: {multiBlock.OutBlock1.Length}");
                    foreach (var item in multiBlock.OutBlock1)
                    {
                        item.Dump(Console.Out, DumpOutputType.Inline80Cols);
                    }
                }
                else
                {
                    using (var query = new XQt1305())
                    {
                        XQt1305InBlock inBlock = new XQt1305InBlock()
                        {
                            shcode = Stock.SHCODE.KOSPI.SK하이닉스,
                            dwmcode = XQt1305.DWMCode.일,
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

                        XQt1305OutBlock1[] outBlocks = query.GetBlock1s();
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
