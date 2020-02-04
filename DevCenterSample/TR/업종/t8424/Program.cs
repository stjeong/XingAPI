using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XingAPINet;

namespace t8424
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
                    var items = XQt8424.Get('2');
                    foreach (var item in items)
                    {
                        item.Dump(Console.Out, DumpOutputType.Inline);
                    }
                }
                else
                {
                    using (XQt8424 query = new XQt8424())
                    {
                        query.SetFieldData(XQt8424InBlock.BlockName, XQt8424InBlock.F.gubun1, 0, "");
                        if (query.Request() < 0)
                        {
                            Console.WriteLine("Failed to send request");
                        }

                        XQt8424OutBlock[] outBlocks = query.GetBlocks();
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
