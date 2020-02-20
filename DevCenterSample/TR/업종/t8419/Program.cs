using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XingAPINet;

namespace t8419
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
                    var multiBlock = XQt8419.ReadFromDB();

                    if (multiBlock.OutBlock.IsValidData == false)
                    {
                        return;
                    }

                    Console.WriteLine($"[{XQt8419OutBlock1.BlockName}]");
                    foreach (var item in multiBlock.OutBlock1)
                    {
                        item.Dump(Console.Out, DumpOutputType.Inline80Cols);
                    }
                }
                else if (useDemoServer)
                {
                    var multiBlock = XQt8419.Get("001", '2', 0, "20190101", "201905030", null, 'N');

                    if (multiBlock.OutBlock?.IsValidData != true)
                    {
                        return;
                    }

                    multiBlock.OutBlock.WriteToDB(replace: true);

                    Console.WriteLine($"[{XQt8419OutBlock1.BlockName}]");
                    foreach (var item in multiBlock.OutBlock1)
                    {
                        item.Dump(Console.Out, DumpOutputType.Inline80Cols);
                    }

                    multiBlock.OutBlock1.WriteToDB(replace: true);
                }
                else
                {
                    using (XQt8419 query = new XQt8419())
                    {
                        var inBlock = new XQt8419InBlock
                        {
                            shcode = "001",
                            gubun = '2',
                            sdate = "20170101",
                            edate = "20180424",
                            /* qrycnt = pageSize, // not work */
                            comp_yn = 'N',
                        };

                        query.SetBlock(inBlock);

                        if (query.Request() < 0)
                        {
                            Console.WriteLine("Failed to send request");
                        }

                        var outBlock = query.GetBlock();
                        if (outBlock.IsValidData == true)
                        {
                            Console.WriteLine($"[{outBlock.GetBlockName()}]");
                            outBlock.Dump(Console.Out, DumpOutputType.Inline80Cols);
                        }
                        else
                        {
                            Console.WriteLine($"Invalid: {outBlock.InvalidReason}");
                        }

                        Console.WriteLine($"[{XQt8419OutBlock1.BlockName}]");
                        foreach (var item in query.GetBlock1s())
                        {
                            item.Dump(Console.Out, DumpOutputType.Inline80Cols);
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
