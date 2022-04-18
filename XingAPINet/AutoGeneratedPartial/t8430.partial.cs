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
        public static SHCodeInfo[] GetKOSPI(bool excludeETN = true)
        {
            List<SHCodeInfo> list = new List<SHCodeInfo>();

            foreach (var item in Get(XQt8430Gubun.코스피))
            {
                SHCodeInfo code = new SHCodeInfo(item.hname, item.shcode, item.expcode, item.etfgubun == '1');
                
                if (code.IsETN == true && excludeETN == true)
                {
                    continue;
                }

                list.Add(code);
            }

            return list.ToArray();
        }

        public static SHCodeInfo[] GetKOSDAQ(bool excludeETN = true)
        {
            List<SHCodeInfo> list = new List<SHCodeInfo>();

            foreach (var item in Get(XQt8430Gubun.코스닥))
            {
                SHCodeInfo code = new SHCodeInfo(item.hname, item.shcode, item.expcode, item.etfgubun == '1');

                if (code.IsETN == true && excludeETN == true)
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

    public partial class SHCodeInfo
    {
        public readonly string Name;
        public readonly string SHCode;
        public readonly string ExpCode;
        public readonly bool IsETF;
        public readonly bool IsETN;

        public SHCodeInfo(string name, string shcode, string expcode, bool isEtf)
        {
            Name = name;
            SHCode = shcode;
            ExpCode = expcode;
            IsETF = isEtf;
            IsETN = name.IndexOf("ETN") != -1;
        }

        public override string ToString()
        {
            return $"[{SHCode}] {Name}, IsETF={IsETF}";
        }
    }
}
