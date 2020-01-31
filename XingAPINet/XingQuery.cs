using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using XA_DataSetLib;

namespace XingAPINet
{
    public partial class XingQuery : IDisposable
    {
        protected XAQueryClass _xaQuery;
        bool _disposed;
        EventWaitHandle _ewh_RecvSync = new EventWaitHandle(false, EventResetMode.ManualReset);

        public XingQuery(string resFileCode)
        {
            _xaQuery = new XAQueryClass();
            _xaQuery.ResFileName = $".\\Res\\{resFileCode}.res";
            _xaQuery.ReceiveData += ReceiveData;
        }

        public int Request(bool bNext = false)
        {
            _ewh_RecvSync.Reset();

            int result = _xaQuery.Request(bNext);

            if (result >= 0)
            {
                _ewh_RecvSync.WaitOne(1000);
            }

            return result;
        }

        protected virtual void ReceiveData(string szTrCode)
        {
            Console.WriteLine("Query_RecvData");
            _ewh_RecvSync.Set();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed == false)
            {
                if (disposing == true)
                {
                    if (_xaQuery != null)
                    {
                        Marshal.ReleaseComObject(_xaQuery);
                        _xaQuery = null;
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
    }
}
