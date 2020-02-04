using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XingAPINet;

namespace t1514
{
    class Program
    {
        static void Main(string[] _)
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

                using (XQt1514 query = new XQt1514())
                {
                    var inBlock = new XQt1514InBlock
                    {
                        upcode = "301",
                        cnt = pageSize,
                        gubun2 = '1',
                    };

                    query.SetFields(inBlock);

                    bool nextPage = false;

                    while (totalSize > 0)
                    {
                        if (query.Request(nextPage) < 0)
                        {
                            Console.WriteLine("Failed to send request");
                        }

                        var outBlock = query.GetBlock();
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
