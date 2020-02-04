using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XingAPINet;

namespace t1511
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
                    var outBlock = XQt1511.Get("002");
                    outBlock?.Dump(Console.Out, DumpOutputType.FormattedKeyValue);
                }
                else
                {
                    using (XQt1511 query = new XQt1511())
                    {
                        query.SetFieldData(XQt1511InBlock.BlockName, XQt1511InBlock.F.upcode, 0, "001");
                        if (query.Request() < 0)
                        {
                            Console.WriteLine("Failed to send request");
                        }

                        XQt1511OutBlock outBlock = query.GetBlock();
                        if (outBlock.IsValidData == true)
                        {
                            outBlock.Dump(Console.Out, DumpOutputType.FormattedKeyValue);
                        }
                        else
                        {
                            Console.WriteLine($"Invalid: {outBlock.InvalidReason}");
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
