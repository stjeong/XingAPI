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

        protected override void OnClosed(EventArgs e)
        {
            _xingClient.Dispose();

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

            LoginInfo user = LoginInfo.CreateInfo(useDemoServer);

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

                MessageBox.Show(queryResult.ToString());

                // XQt1101OutBlock outBlock = XQt1101OutBlock.GetFields(query);
            }
        }

    }
}
