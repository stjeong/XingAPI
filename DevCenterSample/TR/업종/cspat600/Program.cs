using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XingAPINet;

namespace CSPAT600 // 현물 정상주문
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

                string inptpwd = null;
                if (useDemoServer == true)
                {
                    inptpwd = "0000";
                }

                string shcode = Stock.SHCODE.KOSPI.현대건설;
                string isuNo = xing.GetExpCode(shcode);
                long currentPrice = xing.GetCurrentPrice(shcode);

                if (useDemoServer)
                {
                    using (XQCSPAT00600 query = new XQCSPAT00600())
                    {
                        XQCSPAT00600InBlock1 input = new XQCSPAT00600InBlock1();
                        input.AcntNo = tradeAccount;
                        input.InptPwd = inptpwd;
                        input.IsuNo = isuNo;
                        input.OrdQty = 1;

                        // input.OrdPrc = currentPrice - (currentPrice * 0.10); // 10% 낮은 가격으로 매수 주문
                        input.OrdPrc = currentPrice; // 현재가로 매수 주문

                        input.BnsTpCode = XQCSPAT00600.BnsTpCode.매수;

                        // input.OrdprcPtnCode = XQCSPAT00600.OrdprcPtnCode.시장가; // 테스트를 위해 OrdPrc에 상관 없이 시장가로.
                        input.OrdprcPtnCode = XQCSPAT00600.OrdprcPtnCode.지정가;

                        input.MgntrnCode = XQCSPAT00600.MgntrnCode.보통;
                        input.LoanDt = null;
                        input.OrdCndiTpCode = XQCSPAT00600.OrdCndiTpCode.없음;

                        Console.WriteLine("[매수 주문]");
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

                        Console.WriteLine($"===========> 매수 주문 번호: {block2.OrdNo}");
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
