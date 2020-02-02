using System;
using XingAPINet;

namespace ConsoleApp1
{
    class Program
    {
        static bool _exitProcess = false;

        static void Main(string[] args)
        {
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
            bool useDemoServer = false;
            LoginInfo user = LoginInfo.CreateInfo(useDemoServer);

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

                // 현재가 조회한 후,
                using (XQt1101 query = new XQt1101())
                {
                    XQt1101InBlock inBlock = new XQt1101InBlock();
                    inBlock.shcode = "078020";

                    if (query.SetFields(inBlock) == false)
                    {
                        Console.WriteLine("Failed to verify data: " + inBlock.BlockName);
                        return;
                    }

                    if (query.Request() < 0)
                    {
                        Console.WriteLine("Failed to send request");
                    }

                    XQt1101OutBlock outBlock = query.GetBlock();
                    if (outBlock.IsValidData == true)
                    {
                        outBlock.Dump(Console.Out, DumpOutputType.KeyValue);
                    }
                    else
                    {
                        Console.WriteLine($"Invalid: {outBlock.InvalidReason}");
                    }
                }

                // 실시간 데이터를 조회
                using (XRS3_ real = new XRS3_())
                {
                    XRS3_InBlock inBlock = new XRS3_InBlock { shcode = "078020" };
                    if (real.SetFields(inBlock) == false)
                    {
                        Console.WriteLine("Failed to verify data: " + inBlock.BlockName);
                        return;
                    }

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
                            outBlock.Dump(Console.Out, DumpOutputType.KeyValue);
                        }
                        else
                        {
                            Console.WriteLine($"Invalid: {outBlock.InvalidReason}");
                        }
                    }
                }
            }
        }
    }
}
