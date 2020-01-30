using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XA_DataSetLib;

namespace XingAPINet
{
    public class XingQuery : IDisposable
    {
        XAQueryClass _xaQuery;
        bool _disposed;

        public XingQuery(string resFileCode)
        {
            _xaQuery = new XAQueryClass();
            _xaQuery.ResFileName = $"{resFileCode}.res";
            _xaQuery.ReceiveData += ReceiveData;
        }

        protected virtual void ReceiveData(string szTrCode)
        {
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
