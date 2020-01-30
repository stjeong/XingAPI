using CustomMessageLoop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XA_SessionLib;

namespace XingAPINet
{
    public class XingClient : IDisposable
    {
        MessageLoop _ml;

        XASessionClass _xingSession;
        bool _useDemoServer = true;
        bool _loggedIn = false;

        public XingClient(bool useDemoServer)
        {
            _useDemoServer = useDemoServer;
        }

        public event EventHandler<LoginEventArgs> Login;

        public void Start()
        {
            _ml = new MessageLoop();
            _ml.Loaded += _ml_Loaded;
            _ml.Closed += _ml_Closed;

            _ml.Run();
        }

        bool _disposed;

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed == false)
            {
                if (disposing == true)
                {
                    if (_ml != null)
                    {
                        _ml.Dispose();
                        _ml = null;
                    }
                }

                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void _ml_Closed(object sender, EventArgs e)
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

        private void _ml_Loaded(object sender, EventArgs e)
        {
            _xingSession = new XASessionClass();
            _xingSession.Disconnect += XingSession_Disconnect;
            _xingSession._IXASessionEvents_Event_Login += _xingSession_Login;
            _xingSession._IXASessionEvents_Event_Logout += _xingSession_Logout;

            string serverAddress = (_useDemoServer == true) ? "demo.etrade.co.kr" : "hts.etrade.co.kr";
            bool bConnect = _xingSession.ConnectServer(serverAddress, 20001);

            if (bConnect == true)
            {
                LoginTo();
            }
            else
            {
                Console.WriteLine($"Failed to connect: {ErrorMessage}");
            }
        }

        string ErrorMessage
        {
            get
            {
                int errorCode = _xingSession.GetLastError();
                return _xingSession.GetErrorMessage(errorCode);
            }
        }

        void LoginTo()
        {
            LoginInfo user = LoginInfo.CreateInfo(_useDemoServer);

            bool result = _xingSession.Login(user.Id, user.Password, user.CertPassword, 0, false);
            if (result == false)
            {
                Console.WriteLine($"Failed to call Login API: {ErrorMessage}");
            }

            Console.WriteLine("# of accounts: " + _xingSession.GetAccountListCount());

            for (int i = 0; i < _xingSession.GetAccountListCount(); i++)
            {
                Console.WriteLine(_xingSession.GetAccountList(i));
            }
        }

        private void _xingSession_Logout()
        {
            _loggedIn = false;
            Console.WriteLine("_xingSession_Logout");
        }

        private void _xingSession_Login(string szCode, string szMsg)
        {
            if (szCode == ErrorCode.SUCCESS)
            {
                _loggedIn = true;
                Login?.Invoke(null, new LoginEventArgs(szCode, szMsg));
            }
            else
            {
                Console.WriteLine($"Failed to Login: {szCode}, {szMsg}");
            }
        }

        private void XingSession_Disconnect()
        {
            Console.WriteLine("Disconnected");
        }
    }

    public class LoginEventArgs : EventArgs
    {
        string _szCode;
        public string SzCode => _szCode;

        string _szMsg;
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
