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
            Program pg = new Program();
            pg.Main();
        }

        void Main()
        {
            bool useDemoServer = true;
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

                using (XQt1475 query = new XQt1475())
                {
                    XQt1475InBlock inBlock = new XQt1475InBlock
                    {
                        shcode = "078020",
                        datacnt = pageSize,
                    };

                    query.SetFields(inBlock);

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
                            item.Dump(Console.Out, DumpOutputType.Inline);
                            totalSize--;
                        }

                        inBlock.CopyValueFromBlock(outBlock);
                        query.SetFields(inBlock);

                        nextPage = true;
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
