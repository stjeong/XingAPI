using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XingAPINet
{
    partial class XQCSPAT00600
    {
        public static class BnsTpCode
        {
            public const char 매도 = '1';
            public const char 매수 = '2';
        }

        public static class OrdprcPtnCode
        {
            public const string 지정가 = "00";
            public const string 시장가 = "03";
            public const string 조건부지정가 = "05";
            public const string 최유리지정가 = "06";
            public const string 최우선지정가 = "07";
            public const string 장개시전시간외종가 = "61";
            public const string 시간외종가 = "81";
            public const string 시간외단일가 = "82";
        }

        public static class MgntrnCode
        {
            public const string 보통 = "000";
            public const string 유통_자기융자신규 = "003";
            public const string 유통대주신규 = "005";
            public const string 자기대주신규 = "007";
            public const string 유통융자상환 = "101";
            public const string 자기융자상환 = "103";
            public const string 유통대주상환 = "105";
            public const string 자기대주상환 = "107";
            public const string 예탁담보대출상환_신용 = "180";
        }

        public static class OrdCndiTpCode
        {
            public const char 없음 = '0';
            public const char IOC = '1';
            public const char FOK = '2';
        }
    }
}
