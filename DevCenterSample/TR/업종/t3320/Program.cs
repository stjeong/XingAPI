using System;
using System.Collections.Generic;
using XingAPINet;

namespace t3320
{
    // C# XingAPI - 주식 종목에 따른 PBR, PER, ROE, ROA 구하는 방법(t3320, t8430 예제)
    // ; https://www.sysnet.pe.kr/2/0/13034

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

                SHCodeInfo[] stocks = GetStockList();
                foreach (var item in GetStockInfo(stocks))
                {
                    Console.WriteLine($"{item.Name}: PER == {item.per}, PBR == {item.pbr}");
                }
            }
        }

        private IEnumerable<StockInfo> GetStockInfo(SHCodeInfo[] stocks)
        {
            using (XQt3320 query = new XQt3320())
            {
                // QueryPerTime에는 밀리 초 단위로 지정
                query.QueryPerTime = 3 * 1000; // 3초마다 한 번씩 전송

                foreach (var item in stocks)
                {
                    query.SetFieldData(XQt3320InBlock.BlockName, XQt3320InBlock.F.gicode, 0, item.SHCode);
                    int resultCode = query.Request();
                    if (resultCode < 0)
                    {
                        Console.WriteLine($"[{resultCode}] XQt3320: request failed at {item.Name}");
                        break;
                    }

                    XQt3320OutBlock1 outBlock = query.GetBlock1();
                    if (outBlock.IsValidData == false)
                    {
                        Console.WriteLine($"XQt3320: invalid block at {item.Name}");
                        break;
                    }

                    yield return new StockInfo(item.Name, outBlock);
                }
            }
        }

        private SHCodeInfo[] GetStockList()
        {
            List<SHCodeInfo> list = new List<SHCodeInfo>();

            foreach (var block in XQt8430.Get(XQt8430Gubun.전체))
            {
                if (block.etfgubun != '0') // ETF/ETN 유형은 제거
                {
                    continue;
                }

                if (block.shcode[5] != '0') // 보통주만 허용
                {
                    continue;
                }

                SHCodeInfo code = new SHCodeInfo(block);
                list.Add(code);
            }

            return list.ToArray();
        }

        private LoginInfo GetUserInfo(bool useDemoServer)
        {
            string fileName = (useDemoServer == true) ? "ebest.demo.txt" : "ebest.hts.txt";
            string filePath = $@"d:\settings\{fileName}";

            return LoginInfo.FromEncryptedFile(filePath);
        }
    }
}
