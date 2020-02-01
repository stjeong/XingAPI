using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XA_DataSetLib;

namespace XingAPINet
{
    public partial class XingReal : IDisposable
    {
        protected XARealClass _xaReal;
        bool _disposed;

        public XingReal(string resFileCode)
        {
            _xaReal = new XARealClass();
            _xaReal.ResFileName = $".\\Res\\{resFileCode}.res";
            _xaReal.ReceiveRealData += _xaReal_ReceiveRealData;
        }

        private void _xaReal_ReceiveRealData(string szTrCode)
        {
        }



        protected virtual void Dispose(bool disposing)
        {
            if (_disposed == false)
            {
                if (disposing == true)
                {
                    if (_xaReal != null)
                    {
                        Marshal.ReleaseComObject(_xaReal);
                        _xaReal = null;
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
