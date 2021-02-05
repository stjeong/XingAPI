using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XingAPINet;

namespace t1102
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
                    // 반복 쿼리는 반드시 이런 식으로! (XingAPI COM 개체에 메모리 누수 버그 예상)
                    // XQt 개체를 생성 후 쿼리만 재실행
                    using (var query = new XQt1102())
                    {
                        query.SetFieldData(XQt1102InBlock.BlockName, XQt1102InBlock.F.shcode, 0, Stock.SHCODE.KOSPI.현대건설);

                        while (true)
                        {
                            if (query.Request() < 0)
                            {
                                Console.WriteLine("Failed to send request");
                            }

                            XQt1102OutBlock item = query.GetBlock();
                            if (item.IsValidData == true)
                            {
                                item.Dump(Console.Out, DumpOutputType.Inline);
                            }

                            Thread.Sleep(200);
                        }
                    }
                }
                else
                {
                    using (var query = new XQt1102())
                    {
                        query.SetFieldData(XQt1102InBlock.BlockName, XQt1102InBlock.F.shcode, 0, Stock.SHCODE.KOSPI.현대건설);

                        if (query.Request() < 0)
                        {
                            Console.WriteLine("Failed to send request");
                        }

                        XQt1102OutBlock item = query.GetBlock();
                        if (item.IsValidData == true)
                        {
                            item.Dump(Console.Out, DumpOutputType.Inline);
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
