using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XingAPINet;

namespace t0167
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
            SqliteExtension.UseSqlite("test.sqlite");

            LoginInfo user = GetUserInfo(useDemoServer);

            using (XingClient xing = new XingClient(useDemoServer))
            {
                if (xing.ConnectWithLogin(user) == false)
                {
                    Console.WriteLine(xing.ErrorMessage);
                    return;
                }

                if (loadFromDB == true)
                {
                    XQt0167OutBlock outBlock = XQt0167.ReadFromDB();
                    outBlock?.Dump(Console.Out, DumpOutputType.FormattedKeyValue);
                }
                else if (useDemoServer)
                {
                    XQt0167OutBlock outBlock = XQt0167.Get();
                    Console.WriteLine(XQt0167OutBlock.F.dt + " == " + outBlock.dt);
                    Console.WriteLine(XQt0167OutBlock.F.time + " == " + outBlock.time);

                    outBlock.WriteToDB(replace: true);
                }
                else
                {
                    using (XQt0167 query = new XQt0167())
                    {
                        query.SetFieldData(XQt0167InBlock.BlockName, XQt0167InBlock.F.id, 0, "");
                        if (query.Request() < 0)
                        {
                            Console.WriteLine("Failed to send request");
                        }

                        XQt0167OutBlock outBlock = query.GetBlock();
                        if (outBlock.IsValidData == true)
                        {
                            outBlock.Dump(Console.Out, DumpOutputType.FormattedKeyValue);
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
