using System;
using System.Collections.Generic;
using XingAPINet;

namespace t3341
{
    // C# XingAPI - 주식 종목에 따른 PBR, PER, ROE 구하는 방법(t3341 예제)
    // ; https://www.sysnet.pe.kr/2/0/13045

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

            LoginInfo user = GetUserInfo(useDemoServer);

            using (XingClient xing = new XingClient(useDemoServer))
            {
                if (xing.ConnectWithLogin(user) == false)
                {
                    Console.WriteLine(xing.ErrorMessage);
                    return;
                }

                foreach (FinancialInfo item in GetFNGInfo())
                {
                    Console.WriteLine($"[{item.rank}] {item.hname}({item.shcode}): PER == {item.per}, PBR == {item.pbr}");
                }
            }
        }

        private IEnumerable<FinancialInfo> GetFNGInfo()
        {
            List<FinancialInfo> list = new List<FinancialInfo>();

            using (XQt3341 query = new XQt3341())
            {
                query.QueryPerTime = 3 * 1000; // 3초마다 한 번씩 전송

                XQt3341InBlock inBlock = new XQt3341InBlock
                {
                    gubun = '0', // 0: 전체, 1: 코스피, 2: 코스닥
                    gubun1 = 'a', // 1: 매출액증가율
                                  // 2: 영업이익증가율
                                  // 3: 세전계속이익증가율
                                  // 4: 부채비율
                                  // 5: 유보율
                                  // 6: EPS
                                  // 7: BPS
                                  // 8: ROE
                                  // 9: PER 오름차순
                                  // a: PBR 오름차순
                                  // b: PEG 오름차순
                    gubun2 = '1', // 1: 고정
                };

                long oldIdx = 0;

                while (true)
                {
                    query.SetBlock(inBlock);
                    int resultCode = query.Request();
                    if (resultCode < 0)
                    {
                        Console.WriteLine($"[{resultCode}] {XQt3341._typeName}: request failed");
                        break;
                    }

                    var outBlock = query.GetBlock();
                    if (outBlock.IsValidData == false)
                    {
                        Console.WriteLine($"{XQt3341._typeName}: invalid block");
                        break;
                    }

                    foreach (var item in query.GetBlock1s())
                    {
                        yield return new FinancialInfo(item);
                    }

                    inBlock.CopyValueFromBlock(outBlock);

                    if (inBlock.idx == oldIdx)
                    {
                        break;
                    }

                    oldIdx = inBlock.idx;
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
