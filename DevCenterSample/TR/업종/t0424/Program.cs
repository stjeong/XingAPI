using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XingAPINet;

namespace t0424
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
                    foreach (string account in xing.GetAccounts())
                    {
                        Console.WriteLine($"[Account = {account}]");
                        var multiBlock = XQt0424.ReadFromDB();

                        multiBlock.OutBlock?.Dump(Console.Out, DumpOutputType.FormattedKeyValue);

                        Console.WriteLine($"# of items: {multiBlock.OutBlock1?.Length}");
                        foreach (var item in multiBlock.OutBlock1 ?? Enumerable.Empty<XQt0424OutBlock1>())
                        {
                            item.Dump(Console.Out, DumpOutputType.FormattedKeyValue);
                        }
                    }
                }
                else if (useDemoServer)
                {
                    foreach (string account in xing.GetAccounts())
                    {
                        Console.WriteLine($"[Account = {account}]");
                        var multiBlock = XQt0424.Get(account);

                        multiBlock.OutBlock?.Dump(Console.Out, DumpOutputType.FormattedKeyValue);
                        multiBlock.OutBlock?.WriteToDB(replace: true);

                        Console.WriteLine($"# of items: {multiBlock.OutBlock1.Length}");
                        foreach (var item in multiBlock.OutBlock1)
                        {
                            item.Dump(Console.Out, DumpOutputType.FormattedKeyValue);
                        }

                        multiBlock.OutBlock1.WriteToDB(replace: true);
                    }
                }
                else
                {
                    using (var query = new XQt0424())
                    {
                        foreach (string account in xing.GetAccounts())
                        {
                            Console.WriteLine($"[Account = {account}]");
                            XQt0424InBlock inBlock = new XQt0424InBlock()
                            {
                                accno = account,
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

                            XQt0424OutBlock outBlock = query.GetBlock();
                            {
                                outBlock?.Dump(Console.Out, DumpOutputType.FormattedKeyValue);
                            }

                            XQt0424OutBlock1[] outBlocks = query.GetBlock1s();
                            foreach (var item in outBlocks)
                            {
                                item.Dump(Console.Out, DumpOutputType.FormattedKeyValue);
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
