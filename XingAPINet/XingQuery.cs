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
        readonly EventWaitHandle _ewh_RecvSync = new EventWaitHandle(false, EventResetMode.ManualReset);

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

        DateTime _lastQueryTime = DateTime.MinValue;

        // default: 1 query per 500ms
        long _queryPerTimeInMillis = 500;
        public long QueryPerTime { get => _queryPerTimeInMillis; set => _queryPerTimeInMillis = value; }

        bool _nextCall = false;

        /// <summary>
        /// 연속 조회 시 true로 설정, 만약 기본 값 null을 설정하면 XQ[tNNNN] 객체 생성 후 최초 호출인 경우 false, 이후로는 true를 자동으로 지정
        /// </summary>
        /// <param name="bNext">true == 연속 조회, false == 단일 조회</param>
        /// <returns></returns>
        public int Request(bool? bNext = null)
        {
            _ewh_RecvSync.Reset();
            _queryResult = null;

            if (bNext != null)
            {
                _nextCall = bNext.Value;
            }

            TimeSpan diff = DateTime.Now - _lastQueryTime;
            long gapTime = _queryPerTimeInMillis - (long)diff.TotalMilliseconds;
            if (gapTime > 0)
            {
                Thread.Sleep(Math.Min((int)_queryPerTimeInMillis, (int)gapTime));
            }

            _lastQueryTime = DateTime.Now;
            int result = _xaQuery.Request(_nextCall);
            _nextCall = true;

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
