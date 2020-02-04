using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using XA_SessionLib;

namespace XingAPINet
{
    public partial class XingClient : IDisposable
    {
        XASessionClass _xingSession;
        readonly bool _useDemoServer = true;
        bool _loggedIn = false;

        readonly EventWaitHandle _ewh_LoginSync = new EventWaitHandle(false, EventResetMode.ManualReset);

        public int NumberOfAccount
        {
            get
            {
                if (_loggedIn == false)
                {
                    return 0;
                }

                return _xingSession.GetAccountListCount();
            }
        }

        public string[] GetAccounts()
        {
            List<string> list = new List<string>();

            for (int i = 0; i < _xingSession.GetAccountListCount(); i++)
            {
                list.Add(_xingSession.GetAccountList(i));
            }

            return list.ToArray();
        }

        public string GetAccountName(string account)
        {
            return _xingSession.GetAccountName(account);
        }

        public XingClient(bool useDemoServer)
        {
            _useDemoServer = useDemoServer;
        }

        public event EventHandler<LoginEventArgs> Login;

        bool _disposed;

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed == false)
            {
                if (disposing == true)
                {
                    CleanResources();
                }

                _disposed = true;
            }
        }

        private void CleanResources()
        {
            if (_xingSession == null)
            {
                return;
            }

            if (_loggedIn == true)
            {
                _xingSession.Logout();
            }

            if (_xingSession.IsConnected() == true)
            {
                _xingSession.DisconnectServer();
            }

            if (_xingSession != null)
            {
                Marshal.ReleaseComObject(_xingSession);
                _xingSession = null;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public bool ConnectWithLogin(LoginInfo user)
        {
            _xingSession = new XASessionClass();
            _xingSession._IXASessionEvents_Event_Login += _xingSession_Login;

#pragma warning disable CS0618
            _xingSession.Disconnect += XingSession_Disconnect;
            _xingSession._IXASessionEvents_Event_Logout += _xingSession_Logout;
#pragma warning restore CS0618

            string serverAddress = (_useDemoServer == true) ? "demo.etrade.co.kr" : "hts.etrade.co.kr";
            bool bConnect = _xingSession.ConnectServer(serverAddress, 20001);

            if (bConnect == true)
            {
                return LoginTo(user);
            }

            return false;
        }

        public string ErrorMessage
        {
            get
            {
                int errorCode = _xingSession.GetLastError();
                return _xingSession.GetErrorMessage(errorCode);
            }
        }

        bool LoginTo(LoginInfo user)
        {
            _ewh_LoginSync.Reset();

            bool result = _xingSession.Login(user.Id, user.Password, user.CertPassword, 0, false);
            if (result == false)
            {
                return false;
            }

            while (true)
            {
                Application.DoEvents();
                if (_ewh_LoginSync.WaitOne(16) == true)
                {
                    break;
                }
            }

            return _loggedIn;
        }

        [Obsolete("Maybe not used anymore")]
        private void _xingSession_Logout()
        {
            _loggedIn = false;
            Console.WriteLine("[Logout] event occurred");
        }

        private void _xingSession_Login(string szCode, string szMsg)
        {
            try
            {
                if (szCode == ErrorCode.SUCCESS)
                {
                    _loggedIn = true;
                    Login?.Invoke(this, new LoginEventArgs(szCode, szMsg));
                }
                else
                {
                    Console.WriteLine($"Failed to Login: {szCode}, {szMsg}");
                }
            }
            finally
            {
                _ewh_LoginSync.Set();
            }
        }

        [Obsolete("Maybe not used anymore")]
        private void XingSession_Disconnect()
        {
            Console.WriteLine("[Disconnect] event occurred");
        }
    }

    public class LoginEventArgs : EventArgs
    {
        readonly string _szCode;
        public string SzCode => _szCode;

        readonly string _szMsg;
        public string SzMsg => _szMsg;

        public LoginEventArgs(string szCode, string szMsg)
        {
            _szCode = szCode;
            _szMsg = szMsg;
        }
    }

    public static class ErrorCode
    {
        public const string SUCCESS = "0000";
        public const string NO_CONSENT_XING_API = "09003";
    }
}
