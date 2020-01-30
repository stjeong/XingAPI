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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        XASessionClass _xingSession;

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            Type sessionType = Type.GetTypeFromProgID("XA_Session.XASession");
            object objSession = Activator.CreateInstance(sessionType);
            IXASession xingSession = objSession as IXASession;
            */

            XASessionClass xingSession = new XASessionClass();
            bool useDemoServer = true;

            string serverAddress = (useDemoServer == true) ? "demo.etrade.co.kr" : "hts.etrade.co.kr";
            bool bConnect = _xingSession.ConnectServer(serverAddress, 20001);

            if (bConnect == true)
            {
                _xingSession = xingSession;

                _xingSession.Disconnect += XingSession_Disconnect;
                _xingSession._IXASessionEvents_Event_Login += _xingSession__IXASessionEvents_Event_Login;
                _xingSession._IXASessionEvents_Event_Logout += _xingSession__IXASessionEvents_Event_Logout;
            }
            else
            {
                MessageBox.Show("Failed to connect");
                return;
            }

            LoginInfo user = LoginInfo.CreateInfo(useDemoServer);

            bool result = _xingSession.Login(user.Id, user.Password, user.CertPassword, 0, true);
            if (result == true)
            {
                MessageBox.Show("Logged-in");
                _xingSession.Logout();
            }
            else
            {
                MessageBox.Show("Failed to login");
            }

            // xingSession.DisconnectServer();
        }

        private void _xingSession__IXASessionEvents_Event_Logout()
        {
            Console.WriteLine("_xingSession__IXASessionEvents_Event_Logout");
        }

        private void _xingSession__IXASessionEvents_Event_Login(string szCode, string szMsg)
        {
            MessageBox.Show(szMsg);
            Console.WriteLine("_xingSession__IXASessionEvents_Event_Login");
        }

        private void XingSession_Disconnect()
        {
            Console.WriteLine("Disconnected");
        }
    }
}
