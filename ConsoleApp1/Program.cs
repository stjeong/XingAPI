using System;
using System.Runtime.InteropServices;
using WindowsFormsApp1;
using XingAPINet;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (XingClient xing = new XingClient(true))
            {
                xing.Login += xing_Login;
                xing.Start();

                Console.WriteLine("Press any key to exit...");
                Console.ReadLine();
            }
        }

        private static void xing_Login(object sender, LoginEventArgs e)
        {
            Console.WriteLine("Use queries:");

            using (XQt1101 query = new XQt1101())
            {
                XQt1101InBlock inBlock = new XQt1101InBlock();
                inBlock.shcode = "078020";

                if (inBlock.VerifyData() == false)
                {
                    throw new ApplicationException("Failed to verify: " + inBlock.BlockName);
                }

                // query.SetData(inBlock);
            }
        }
    }
}
