using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XingAPINet;

namespace t1310
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
                    var multiBlock = XQt1310.ReadFromDB(Stock.SHCODE.KOSPI.현대건설);

                    Console.WriteLine($"# of items: {multiBlock.OutBlock1.Length}");
                    foreach (var item in multiBlock.OutBlock1)
                    {
                        item.Dump(Console.Out, DumpOutputType.Inline80Cols);
                    }
                }
                else if (useDemoServer)
                {
                    var multiBlock = XQt1310.Get(shcode: Stock.SHCODE.KOSPI.현대건설,
                         daygb: XQt1310.DayGB.당일,
                         timegb: XQt1310.TimeGB.틱);

                    if (multiBlock.OutBlock.IsValidData == false)
                    {
                        return;
                    }

                    multiBlock.OutBlock.Dump(Console.Out, DumpOutputType.Inline80Cols);
                    multiBlock.OutBlock.WriteToDB(replace: true);

                    Console.WriteLine($"# of items: {multiBlock.OutBlock1.Length}");
                    foreach (var item in multiBlock.OutBlock1)
                    {
                        item.Dump(Console.Out, DumpOutputType.Inline);
                    }

                    multiBlock.OutBlock1.WriteToDB(replace: true);
                }
                else
                {
                    using (XQt1310 query = new XQt1310())
                    {
                        var inBlock = new XQt1310InBlock
                        {
                            shcode = Stock.SHCODE.KOSPI.현대건설,
                            daygb = XQt1310.DayGB.당일,
                            timegb = XQt1310.TimeGB.틱,
                        };

                        bool createFirst = true;
                        while (true)
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

                            var blocks = query.GetBlock1s();

                            foreach (var item in blocks)
                            {
                                item.Dump(Console.Out, DumpOutputType.Inline80Cols);
                            }

                            blocks.WriteToDB(createFirst, inBlock.shcode);
                            createFirst = false;

                            inBlock.CopyValueFromBlock(outBlock);
                            if (string.IsNullOrEmpty(outBlock.cts_time) == true)
                            {
                                break;
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
