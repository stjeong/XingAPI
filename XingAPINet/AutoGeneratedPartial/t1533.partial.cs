

namespace XingAPINet
{
    public enum XQt1533Gubun : ushort
    {
        상승율상위 = '1',
        하락율상위 = '2',
        거래증가율상위 = '3',
        거래증가율하위 = '4',
        상승종목비율상위 = '5',
        상승종목비율하위 = '6',
        기준대비상승율상위 = '7',
        기준대비하락율상위 = '8',
    }

    public partial class XQt1533
    {
        public static XQt1533OutBlock[] Get(XQt1533Gubun gubun = XQt1533Gubun.상승율상위, long chgdate = default)
        {
            return Get((char)gubun, chgdate);
        }
    }
}