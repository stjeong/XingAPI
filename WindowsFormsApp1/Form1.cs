using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using XA_SessionLib;
using XingAPINet;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        XingClient _xingClient;
        XRS3_ _realS3;

        protected override void OnClosed(EventArgs e)
        {
            if (_realS3 != null)
            {
                _realS3.Dispose();
            }

            if (_xingClient != null)
            {
                _xingClient.Dispose();
            }

            base.OnClosed(e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            Type sessionType = Type.GetTypeFromProgID("XA_Session.XASession");
            object objSession = Activator.CreateInstance(sessionType);
            IXASession xingSession = objSession as IXASession;
            */

            bool useDemoServer = false;
            LoginInfo user = GetUserInfo(useDemoServer);

            _xingClient = new XingClient(useDemoServer);
            _xingClient.ConnectWithLogin(user);

            Console.WriteLine($"# of account: {_xingClient.NumberOfAccount}");

            foreach (string account in _xingClient.GetAccounts())
            {
                Console.WriteLine("\t" + account);
            }

            using (XQt1101 query = new XQt1101())
            {
                XQt1101InBlock inBlock = new XQt1101InBlock();
                inBlock.shcode = "078020";

                if (query.SetFields(inBlock) == false)
                {
                    Console.WriteLine("Failed to verify data: " + inBlock.BlockName);
                    return;
                }

                Console.WriteLine("GetFields: " + inBlock.BlockName);

                int queryResult = query.Request();
                if (queryResult < 0)
                {
                    Console.WriteLine("Failed to send request");
                }

                XQt1101OutBlock outBlock = query.GetBlock();
                OutputPrice(outBlock.shcode, outBlock.price);
            }

            {
                _realS3 = new XRS3_();
                _realS3.DataArrived += _realS3_DataArrived;

                XRS3_InBlock inBlock = new XRS3_InBlock { shcode = "078020" };
                if (_realS3.SetFields(inBlock) == false)
                {
                    Console.WriteLine("Failed to verify data: " + inBlock.BlockName);
                    return;
                }

                _realS3.Advise();
            }
        }

        private void _realS3_DataArrived(object sender, RealDataArgs e)
        {
            XRS3_OutBlock outBlock = _realS3.GetBlock();
            if (outBlock.IsValidData == true)
            {
                OutputPrice(outBlock.shcode, outBlock.price);
            }
            else
            {
                Console.WriteLine($"Invalid: {outBlock.InvalidReason}");
            }
        }

        private void OutputPrice(string shcode, long price)
        {
            txtDateTime.Text = DateTime.Now.ToString();
            txtShCode.Text = shcode;
            txtPrice.Text = price.ToString();
        }

        private LoginInfo GetUserInfo(bool useDemoServer)
        {
            string fileName = (useDemoServer == true) ? "ebest.demo.txt" : "ebest.hts.txt";
            string filePath = $@"d:\settings\{fileName}";

            return LoginInfo.FromEncryptedFile(filePath);
        }
    }
}
