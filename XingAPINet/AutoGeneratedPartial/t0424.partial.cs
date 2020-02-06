using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XingAPINet
{
    partial class XQt0424
    {
        public static class PRCGB
        {
            public const char 평균단가 = '1';
            public const char BEP단가 = '2';
        }

        public static class CHEGB
        {
            public const char 결제기준잔고 = '0';
            public const char 체결기준 = '2';
        }

        public static class DANGB
        {
            public const char 정규장 = '0';
            public const char 시간외단일가 = '1';
        }

        public static class CHARGE
        {
            public const char 제비용미포함 = '0';
            public const char 제비용포함 = '1';
        }
    }
}
