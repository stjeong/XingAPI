using System;
using System.IO;
using XingAPINet;

namespace ConsoleApp1
{
    class Program
    {
        static bool _exitProcess = false;

        static void Main(string[] args)
        {
            if (args.Length == 4)
            {
                string id = args[0];
                string pw = args[1];
                string certPass = args[2];
                string filePath = args[3];

                LoginInfo.EncryptToFile(id, pw, certPass, filePath);
                return;
            }

            Console.CancelKeyPress += Console_CancelKeyPress;
            Program pg = new Program();
            pg.Main();
        }

        private static void Console_CancelKeyPress(object sender, ConsoleCancelEventArgs e)
        {
            e.Cancel = true;
            _exitProcess = true;
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

                Console.WriteLine($"# of account: {xing.NumberOfAccount}");

                foreach (string account in xing.GetAccounts())
                {
                    Console.WriteLine("\t" + account);
                }

                string shcode = "078020";

                // 현재가 조회한 후,
                using (XQt1101 query = new XQt1101())
                {
                    XQt1101InBlock inBlock = new XQt1101InBlock();
                    inBlock.shcode = shcode;

                    if (query.SetBlock(inBlock) == false)
                    {
                        Console.WriteLine("Failed to verify data: " + XQt1101InBlock.BlockName);
                        return;
                    }

                    if (query.Request() < 0)
                    {
                        Console.WriteLine("Failed to send request");
                    }

                    XQt1101OutBlock outBlock = query.GetBlock();
                    if (outBlock.IsValidData == true)
                    {
                        outBlock.Dump(Console.Out, DumpOutputType.FormattedKeyValue);
                    }
                    else
                    {
                        Console.WriteLine($"Invalid: {outBlock.InvalidReason}");
                    }
                }

                // 실시간 데이터를 조회
                using (XRS3_ real = new XRS3_())
                {
                    //XRS3_InBlock inBlock = new XRS3_InBlock { shcode = shcode };
                    //if (real.SetFields(inBlock) == false)
                    //{
                    //    Console.WriteLine("Failed to verify data: " + inBlock.BlockName);
                    //    return;
                    //}

                    real.SetFieldData(XRS3_InBlock.BlockName, XRS3_InBlock.F.shcode, shcode);
                    real.Advise();

                    while (_exitProcess == false)
                    {
                        if (real.WaitForData(1000) == false)
                        {
                            Console.Write(".");
                            continue;
                        }

                        XRS3_OutBlock outBlock = real.GetBlock();
                        if (outBlock.IsValidData == true)
                        {
                            // outBlock.Dump(Console.Out, DumpOutputType.KeyValue);
                            Console.WriteLine(outBlock.price);
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
