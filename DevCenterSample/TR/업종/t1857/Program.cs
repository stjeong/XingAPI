using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XingAPINet;

namespace t1857
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
            LoginInfo user = GetUserInfo(useDemoServer);

            using (XingClient xing = new XingClient(useDemoServer))
            {
                if (xing.ConnectWithLogin(user) == false)
                {
                    Console.WriteLine(xing.ErrorMessage);
                    return;
                }

                List<StockInfo> list = new List<StockInfo>(GetACFSearchResult(@"d:\temp\4factor.ACF"));

                using (XQt3320 query = new XQt3320())
                {
                    query.QueryPerTime = 3 * 1000;

                    foreach (var item in list)
                    {
                        query.SetFieldData(XQt3320InBlock.BlockName, XQt3320InBlock.F.gicode, 0, item.shcode);
                        int resultCode = query.Request();
                        if (resultCode < 0)
                        {
                            Console.WriteLine($"[{resultCode}] XQt3320: request failed at {item.hname}");
                            break;
                        }

                        XQt3320OutBlock1 outBlock = query.GetBlock1();
                        if (outBlock.IsValidData == false)
                        {
                            Console.WriteLine($"XQt3320: invalid block at {item.hname}");
                            break;
                        }

                        item.CPS = outBlock.cps;
                        item.SPS = outBlock.sps;
                        item.PBR = outBlock.pbr;
                        item.PER = outBlock.per;

                        Console.WriteLine(item);
                    }
                }
            }
        }

        private IEnumerable<StockInfo> GetACFSearchResult(string acfFilePath)
        {
            using (XQt1857 xQT = new XQt1857())
            {
                XQt1857InBlock inBlock = new XQt1857InBlock
                {
                    sRealFlag = '0',
                    sSearchFlag = 'F',
                    query_index = acfFilePath,
                };

                xQT.SetBlock(inBlock);

                if (xQT.Request(null, true) < 0) // Request의 2번째 인자에 true를 주면 내부적으로 XAQueryClass.RequestService를 호출
                {
                    yield break;
                }

                var block = xQT.GetBlock();
                if (block.IsValidData == false)
                {
                    yield break;
                }

                foreach (var item in xQT.GetBlock1s())
                {
                    yield return new StockInfo(item);
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
