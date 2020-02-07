using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XingAPINet;

namespace t1475
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

                int pageSize = 10;
                int totalSize = 30;

                if (useDemoServer)
                {
                    var multiBlock = XQt1475.Get(Stock.SHCODE.KOSDAQ.이베스트투자증권, datacnt: totalSize);

                    if (multiBlock.OutBlock.IsValidData == false)
                    {
                        return;
                    }

                    multiBlock.OutBlock.Dump(Console.Out, DumpOutputType.Inline80Cols);

                    foreach (var item in multiBlock.OutBlock1)
                    {
                        item.Dump(Console.Out, DumpOutputType.Inline80Cols);
                    }
                }
                else
                {
                    using (XQt1475 query = new XQt1475())
                    {
                        XQt1475InBlock inBlock = new XQt1475InBlock
                        {
                            shcode = Stock.SHCODE.KOSDAQ.이베스트투자증권,
                            datacnt = pageSize,
                        };

                        query.SetBlock(inBlock);

                        bool nextPage = false;

                        while (totalSize > 0)
                        {
                            if (query.Request(nextPage) < 0)
                            {
                                Console.WriteLine("Failed to send request");
                            }

                            XQt1475OutBlock outBlock = query.GetBlock();
                            if (outBlock.IsValidData == true)
                            {
                                outBlock.Dump(Console.Out, DumpOutputType.Inline);
                            }
                            else
                            {
                                Console.WriteLine($"Invalid: {outBlock.InvalidReason}");
                            }

                            foreach (var item in query.GetBlock1s())
                            {
                                item.Dump(Console.Out, DumpOutputType.Inline80Cols);
                                totalSize--;
                            }

                            inBlock.CopyValueFromBlock(outBlock);
                            query.SetBlock(inBlock);

                            nextPage = true;
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
