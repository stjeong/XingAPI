using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XingAPINet;

namespace t1514
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

                int pageSize = 10;
                int totalSize = 30;

                if (loadFromDB == true)
                {
                    var multiBlock = XQt1514.ReadFromDB();

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
                else if (useDemoServer)
                {
                    var multiBlock = XQt1514.Get("301", gubun2: XQt1514.Gubun2.일, cnt: totalSize);

                    if (multiBlock.OutBlock.IsValidData == false)
                    {
                        return;
                    }

                    multiBlock.OutBlock.Dump(Console.Out, DumpOutputType.Inline80Cols);
                    multiBlock.OutBlock.WriteToDB(replace: true);

                    Console.WriteLine($"# of items: {multiBlock.OutBlock1.Length}");
                    foreach (var item in multiBlock.OutBlock1)
                    {
                        item.Dump(Console.Out, DumpOutputType.Inline80Cols);
                    }

                    multiBlock.OutBlock1.WriteToDB(replace: true);
                }
                else
                {
                    using (XQt1514 query = new XQt1514())
                    {
                        var inBlock = new XQt1514InBlock
                        {
                            upcode = "301",
                            cnt = pageSize,
                            gubun2 = XQt1514.Gubun2.월,
                        };

                        while (totalSize > 0)
                        {
                            query.SetBlock(inBlock);

                            if (query.Request() < 0)
                            {
                                Console.WriteLine("Failed to send request");
                                break;
                            }

                            var outBlock = query.GetBlock();
                            if (outBlock.IsValidData == true)
                            {
                                outBlock.Dump(Console.Out, DumpOutputType.Inline);
                            }
                            else
                            {
                                Console.WriteLine($"Invalid: {outBlock.InvalidReason}");
                                break;
                            }

                            foreach (var item in query.GetBlock1s())
                            {
                                item.Dump(Console.Out, DumpOutputType.Inline80Cols);
                                totalSize--;
                            }

                            inBlock.CopyValueFromBlock(outBlock);
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
