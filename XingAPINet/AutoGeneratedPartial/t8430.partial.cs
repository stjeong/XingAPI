using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XingAPINet
{
    public enum XQt8430Gubun : ushort
    {
        전체 = '0',
        코스피 = '1',
        코스닥 = '2',
    }

    partial class XQt8430
    {
        public static SHCodeInfo[] GetKOSPI(bool exclude_ETN_ETF = true)
        {
            List<SHCodeInfo> list = new List<SHCodeInfo>();

            foreach (var item in Get(XQt8430Gubun.코스피))
            {
                SHCodeInfo code = new SHCodeInfo(item);

                if (code.IsETN == true || code.IsETF == true)
                {
                    continue;
                }

                list.Add(code);
            }

            return list.ToArray();
        }

        public static SHCodeInfo[] GetKOSDAQ(bool exclude_ETN_ETF = true)
        {
            List<SHCodeInfo> list = new List<SHCodeInfo>();

            foreach (var item in Get(XQt8430Gubun.코스닥))
            {
                SHCodeInfo code = new SHCodeInfo(item);

                if (code.IsETN == true || code.IsETF == true)
                {
                    continue;
                }

                list.Add(code);
            }

            return list.ToArray();
        }

        public static XQt8430OutBlock [] Get(XQt8430Gubun gubun)
        {
            return Get((char)gubun);
        }
    }

    public partial class SHCodeInfo : XQt8430OutBlock
    {
        public string Name => this.hname;
        public string SHCode => this.shcode;
        public string ExpCode => this.expcode;
        public bool IsETF => this.gubun == '1';
        public bool IsETN => this.gubun == '2';

        public SHCodeInfo(XQt8430OutBlock block)
        {
            block.CopyTo(this);
        }

        public override string ToString()
        {
            return $"[{SHCode}] {Name}, IsETF/ETN={IsETF || IsETN}";
        }
    }
}
