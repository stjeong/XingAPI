using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XingAPINet;

namespace t1537
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
                    var multiBlock = XQt1537.Get(Stock.TMCODE.테마파크);

                    if (multiBlock.OutBlock.IsValidData == false)
                    {
                        return;
                    }

                    multiBlock.OutBlock.Dump(Console.Out, DumpOutputType.Inline80Cols);
                    
                    foreach (var item in multiBlock.OutBlock1)
                    {
                        item.Dump(Console.Out, DumpOutputType.Inline);
                    }
                }
                else
                {
                    using (var query = new XQt1537())
                    {
                        query.SetFieldData(XQt1537InBlock.BlockName, XQt1537InBlock.F.tmcode, 0, Stock.TMCODE.테마파크);

                        if (query.Request() < 0)
                        {
                            Console.WriteLine("Failed to send request");
                        }

                        XQt1537OutBlock1[] outBlocks = query.GetBlock1s();
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
