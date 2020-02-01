using System;
using XingAPINet;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pg = new Program();
            pg.Main();
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
                XQt1101 query = new XQt1101();
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
                        outBlock.Dump(Console.Out, DumpOutputType.FormattedKeyValue);
                    }
                    else
                    {
                        Console.WriteLine($"Invalid: {outBlock.InvalidReason}");
                    }
                }

                // 실시간 데이터를 조회
                while (true)
                {
                    
                }
            }
        }
    }
}
