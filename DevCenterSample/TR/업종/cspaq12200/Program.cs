using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XingAPINet;

namespace cspaq12200 // 현물계좌 예수금/주문가능금액/총평가 조회(API)
{
    class Program
    {
        static void Main(string[] args)
        {
            bool useDemoServer = true;

            Program pg = new Program();

            if (args.Length == 1)
            {
                if (args[0] == "hts")
                {
                    useDemoServer = false;
                }
            }

            pg.Main(useDemoServer);
        }

        void Main(bool useDemoServer)
        {
            SqliteExtension.UseSqlite("test.sqlite");
            if (useDemoServer == false)
            {
                Console.WriteLine("이 코드는 데모 서버로만 매수 주문을 하는 예제입니다.");
                return;
            }

            LoginInfo user = GetUserInfo(useDemoServer);

            using (XingClient xing = new XingClient(useDemoServer))
            {
                if (xing.ConnectWithLogin(user) == false)
                {
                    Console.WriteLine(xing.ErrorMessage);
                    return;
                }

                string tradeAccount = xing.GetFirstAccount();
                if (string.IsNullOrEmpty(tradeAccount) == true)
                {
                    Console.WriteLine("추정순자산(sunamt) 또는 예수금(sunamt1)을 가진 계정이 없습니다.");
                    return;
                }

                if (useDemoServer)
                {
                    using (XQCSPAQ12200 query = new XQCSPAQ12200())
                    {
                        XQCSPAQ12200InBlock1 input = new XQCSPAQ12200InBlock1();
                        input.AcntNo = tradeAccount;
                      //  input.BalCreTp = 

                        input.Dump(Console.Out);
                        query.SetBlock(input);

                        if (query.Request() < 0)
                        {
                            Console.WriteLine("Failed to send request: ");
                            Console.WriteLine(query.QueryResult);
                            return;
                        }

                        var block1 = query.GetBlock1();
                        block1.Dump(Console.Out);

                        var block2 = query.GetBlock2();
                        block2.Dump(Console.Out, DumpOutputType.Inline);
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
