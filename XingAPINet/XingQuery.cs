using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using XA_DataSetLib;

namespace XingAPINet
{
    public partial class XingQuery : IDisposable
    {
        protected XAQueryClass _xaQuery;
        bool _disposed;
        EventWaitHandle _ewh_RecvSync = new EventWaitHandle(false, EventResetMode.ManualReset);

        XAQueryResult _queryResult;
        public XAQueryResult QueryResult => _queryResult;
        public string ReceiveMessage => $"Code = {_queryResult.Code}, Message = {_queryResult.Message}";

        public XingQuery(string resFileCode)
        {
            _xaQuery = new XAQueryClass();
            _xaQuery.ResFileName = $".\\Res\\{resFileCode}.res";
            _xaQuery.ReceiveData += _xaQuery_ReceiveData;
            _xaQuery.ReceiveMessage += _xaQuery_ReceiveMessage;
        }

        public int GetBlockCount(string blockName)
        {
            return _xaQuery.GetBlockCount(blockName);
        }

        public int Request(bool bNext = false)
        {
            _ewh_RecvSync.Reset();
            _queryResult = null;

            int result = _xaQuery.Request(bNext);

            if (result >= 0)
            {
                while (true)
                {
                    Application.DoEvents();
                    if (_ewh_RecvSync.WaitOne(16) == true)
                    {
                        break;
                    }
                }
            }

            return result;
        }

        public void SetFieldData(string blockName, string fieldName, int index, string value)
        {
            _xaQuery.SetFieldData(blockName, fieldName, index, value);
        }

        public string GetFieldData(string blockName, string fieldName, int index)
        {
            return _xaQuery.GetFieldData(blockName, fieldName, index);
        }

        protected virtual void _xaQuery_ReceiveData(string szTrCode)
        {
            _ewh_RecvSync.Set();
        }

        private void _xaQuery_ReceiveMessage(bool bIsSystemError, string nMessageCode, string szMessage)
        {
            _queryResult = new XAQueryResult(bIsSystemError, nMessageCode, szMessage);
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
