using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XRBMTInBlock : XingBlock
	{
		/// <summary>
		/// InBlock
		/// </summary>
		public const string _blockName = "InBlock";
		/// <summary>
		/// 입력
		/// </summary>
		public const string _blockDesc = "입력";
		/// <summary>
		/// input
		/// </summary>
		public const string _blockType = "input";
		/// <summary>
		/// false
		/// </summary>
		public const bool _hasOccurs = false;
		/// <summary>
		/// InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// InBlock
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// 입력
		/// </summary>
		public string BlockDesc => _blockDesc;
		/// <summary>
		/// input
		/// </summary>
		public string BlockType => _blockType;
		/// <summary>
		/// false
		/// </summary>
		public bool HasOccurs => _hasOccurs;

		/// <summary>
		/// 업종코드
		/// </summary>
		[XAQueryFieldAttribute("upcode", "업종코드", "char", "3")]
		public string upcode;

		public static class F
		{
			/// <summary>
			/// 업종코드
			/// </summary>
			public const string upcode = "upcode";
		}

		public static string[] AllFields = new string[]
		{
			F.upcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["upcode"] = new XAQueryFieldInfo("char", upcode, upcode, "업종코드", (decimal)3);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "upcode":
					this.upcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (upcode?.Length > 3) return false; // char 3

			return true;
		}

		public void CopyTo(XRBMTInBlock block)
		{
			block.upcode = this.upcode;

		}
	}

	public partial class XRBMTOutBlock : XingBlock
	{
		/// <summary>
		/// OutBlock
		/// </summary>
		public const string _blockName = "OutBlock";
		/// <summary>
		/// 출력
		/// </summary>
		public const string _blockDesc = "출력";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// false
		/// </summary>
		public const bool _hasOccurs = false;
		/// <summary>
		/// OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// OutBlock
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// 출력
		/// </summary>
		public string BlockDesc => _blockDesc;
		/// <summary>
		/// output
		/// </summary>
		public string BlockType => _blockType;
		/// <summary>
		/// false
		/// </summary>
		public bool HasOccurs => _hasOccurs;

		/// <summary>
		/// 수신시간
		/// </summary>
		[XAQueryFieldAttribute("tjjtime", "수신시간", "char", "8")]
		public string tjjtime;
		/// <summary>
		/// 투자자코드1(개인)
		/// </summary>
		[XAQueryFieldAttribute("tjjcode1", "투자자코드1(개인)", "char", "4")]
		public string tjjcode1;
		/// <summary>
		/// 매수 거래량1
		/// </summary>
		[XAQueryFieldAttribute("msvolume1", "매수 거래량1", "long", "8")]
		public long msvolume1;
		/// <summary>
		/// 매도 거래량1
		/// </summary>
		[XAQueryFieldAttribute("mdvolume1", "매도 거래량1", "long", "8")]
		public long mdvolume1;
		/// <summary>
		/// 거래량 순매수1
		/// </summary>
		[XAQueryFieldAttribute("msvol1", "거래량 순매수1", "long", "8")]
		public long msvol1;
		/// <summary>
		/// 매수 거래대금1
		/// </summary>
		[XAQueryFieldAttribute("msvalue1", "매수 거래대금1", "long", "6")]
		public long msvalue1;
		/// <summary>
		/// 매도 거래대금1
		/// </summary>
		[XAQueryFieldAttribute("mdvalue1", "매도 거래대금1", "long", "6")]
		public long mdvalue1;
		/// <summary>
		/// 거래대금 순매수1
		/// </summary>
		[XAQueryFieldAttribute("msval1", "거래대금 순매수1", "long", "6")]
		public long msval1;
		/// <summary>
		/// 투자자코드2(외국인)
		/// </summary>
		[XAQueryFieldAttribute("tjjcode2", "투자자코드2(외국인)", "char", "4")]
		public string tjjcode2;
		/// <summary>
		/// 매수 거래량2
		/// </summary>
		[XAQueryFieldAttribute("msvolume2", "매수 거래량2", "long", "8")]
		public long msvolume2;
		/// <summary>
		/// 매도 거래량2
		/// </summary>
		[XAQueryFieldAttribute("mdvolume2", "매도 거래량2", "long", "8")]
		public long mdvolume2;
		/// <summary>
		/// 거래량 순매수2
		/// </summary>
		[XAQueryFieldAttribute("msvol2", "거래량 순매수2", "long", "8")]
		public long msvol2;
		/// <summary>
		/// 매수 거래대금2
		/// </summary>
		[XAQueryFieldAttribute("msvalue2", "매수 거래대금2", "long", "6")]
		public long msvalue2;
		/// <summary>
		/// 매도 거래대금2
		/// </summary>
		[XAQueryFieldAttribute("mdvalue2", "매도 거래대금2", "long", "6")]
		public long mdvalue2;
		/// <summary>
		/// 거래대금 순매수2
		/// </summary>
		[XAQueryFieldAttribute("msval2", "거래대금 순매수2", "long", "6")]
		public long msval2;
		/// <summary>
		/// 투자자코드3(기관계)
		/// </summary>
		[XAQueryFieldAttribute("tjjcode3", "투자자코드3(기관계)", "char", "4")]
		public string tjjcode3;
		/// <summary>
		/// 매수 거래량3
		/// </summary>
		[XAQueryFieldAttribute("msvolume3", "매수 거래량3", "long", "8")]
		public long msvolume3;
		/// <summary>
		/// 매도 거래량3
		/// </summary>
		[XAQueryFieldAttribute("mdvolume3", "매도 거래량3", "long", "8")]
		public long mdvolume3;
		/// <summary>
		/// 거래량 순매수3
		/// </summary>
		[XAQueryFieldAttribute("msvol3", "거래량 순매수3", "long", "8")]
		public long msvol3;
		/// <summary>
		/// 매수 거래대금3
		/// </summary>
		[XAQueryFieldAttribute("msvalue3", "매수 거래대금3", "long", "6")]
		public long msvalue3;
		/// <summary>
		/// 매도 거래대금3
		/// </summary>
		[XAQueryFieldAttribute("mdvalue3", "매도 거래대금3", "long", "6")]
		public long mdvalue3;
		/// <summary>
		/// 거래대금 순매수3
		/// </summary>
		[XAQueryFieldAttribute("msval3", "거래대금 순매수3", "long", "6")]
		public long msval3;
		/// <summary>
		/// 투자자코드4(증권)
		/// </summary>
		[XAQueryFieldAttribute("tjjcode4", "투자자코드4(증권)", "char", "4")]
		public string tjjcode4;
		/// <summary>
		/// 매수 거래량4
		/// </summary>
		[XAQueryFieldAttribute("msvolume4", "매수 거래량4", "long", "8")]
		public long msvolume4;
		/// <summary>
		/// 매도 거래량4
		/// </summary>
		[XAQueryFieldAttribute("mdvolume4", "매도 거래량4", "long", "8")]
		public long mdvolume4;
		/// <summary>
		/// 거래량 순매수4
		/// </summary>
		[XAQueryFieldAttribute("msvol4", "거래량 순매수4", "long", "8")]
		public long msvol4;
		/// <summary>
		/// 매수 거래대금4
		/// </summary>
		[XAQueryFieldAttribute("msvalue4", "매수 거래대금4", "long", "6")]
		public long msvalue4;
		/// <summary>
		/// 매도 거래대금4
		/// </summary>
		[XAQueryFieldAttribute("mdvalue4", "매도 거래대금4", "long", "6")]
		public long mdvalue4;
		/// <summary>
		/// 거래대금 순매수4
		/// </summary>
		[XAQueryFieldAttribute("msval4", "거래대금 순매수4", "long", "6")]
		public long msval4;
		/// <summary>
		/// 투자자코드5(투신)
		/// </summary>
		[XAQueryFieldAttribute("tjjcode5", "투자자코드5(투신)", "char", "4")]
		public string tjjcode5;
		/// <summary>
		/// 매수 거래량5
		/// </summary>
		[XAQueryFieldAttribute("msvolume5", "매수 거래량5", "long", "8")]
		public long msvolume5;
		/// <summary>
		/// 매도 거래량5
		/// </summary>
		[XAQueryFieldAttribute("mdvolume5", "매도 거래량5", "long", "8")]
		public long mdvolume5;
		/// <summary>
		/// 거래량 순매수5
		/// </summary>
		[XAQueryFieldAttribute("msvol5", "거래량 순매수5", "long", "8")]
		public long msvol5;
		/// <summary>
		/// 매수 거래대금5
		/// </summary>
		[XAQueryFieldAttribute("msvalue5", "매수 거래대금5", "long", "6")]
		public long msvalue5;
		/// <summary>
		/// 매도 거래대금5
		/// </summary>
		[XAQueryFieldAttribute("mdvalue5", "매도 거래대금5", "long", "6")]
		public long mdvalue5;
		/// <summary>
		/// 거래대금 순매수5
		/// </summary>
		[XAQueryFieldAttribute("msval5", "거래대금 순매수5", "long", "6")]
		public long msval5;
		/// <summary>
		/// 투자자코드6(은행)
		/// </summary>
		[XAQueryFieldAttribute("tjjcode6", "투자자코드6(은행)", "char", "4")]
		public string tjjcode6;
		/// <summary>
		/// 매수 거래량6
		/// </summary>
		[XAQueryFieldAttribute("msvolume6", "매수 거래량6", "long", "8")]
		public long msvolume6;
		/// <summary>
		/// 매도 거래량6
		/// </summary>
		[XAQueryFieldAttribute("mdvolume6", "매도 거래량6", "long", "8")]
		public long mdvolume6;
		/// <summary>
		/// 거래량 순매수6
		/// </summary>
		[XAQueryFieldAttribute("msvol6", "거래량 순매수6", "long", "8")]
		public long msvol6;
		/// <summary>
		/// 매수 거래대금6
		/// </summary>
		[XAQueryFieldAttribute("msvalue6", "매수 거래대금6", "long", "6")]
		public long msvalue6;
		/// <summary>
		/// 매도 거래대금6
		/// </summary>
		[XAQueryFieldAttribute("mdvalue6", "매도 거래대금6", "long", "6")]
		public long mdvalue6;
		/// <summary>
		/// 거래대금 순매수6
		/// </summary>
		[XAQueryFieldAttribute("msval6", "거래대금 순매수6", "long", "6")]
		public long msval6;
		/// <summary>
		/// 투자자코드7(보험)
		/// </summary>
		[XAQueryFieldAttribute("tjjcode7", "투자자코드7(보험)", "char", "4")]
		public string tjjcode7;
		/// <summary>
		/// 매수 거래량7
		/// </summary>
		[XAQueryFieldAttribute("msvolume7", "매수 거래량7", "long", "8")]
		public long msvolume7;
		/// <summary>
		/// 매도 거래량7
		/// </summary>
		[XAQueryFieldAttribute("mdvolume7", "매도 거래량7", "long", "8")]
		public long mdvolume7;
		/// <summary>
		/// 거래량 순매수7
		/// </summary>
		[XAQueryFieldAttribute("msvol7", "거래량 순매수7", "long", "8")]
		public long msvol7;
		/// <summary>
		/// 매수 거래대금7
		/// </summary>
		[XAQueryFieldAttribute("msvalue7", "매수 거래대금7", "long", "6")]
		public long msvalue7;
		/// <summary>
		/// 매도 거래대금7
		/// </summary>
		[XAQueryFieldAttribute("mdvalue7", "매도 거래대금7", "long", "6")]
		public long mdvalue7;
		/// <summary>
		/// 거래대금 순매수7
		/// </summary>
		[XAQueryFieldAttribute("msval7", "거래대금 순매수7", "long", "6")]
		public long msval7;
		/// <summary>
		/// 투자자코드8(종금)
		/// </summary>
		[XAQueryFieldAttribute("tjjcode8", "투자자코드8(종금)", "char", "4")]
		public string tjjcode8;
		/// <summary>
		/// 매수 거래량8
		/// </summary>
		[XAQueryFieldAttribute("msvolume8", "매수 거래량8", "long", "8")]
		public long msvolume8;
		/// <summary>
		/// 매도 거래량8
		/// </summary>
		[XAQueryFieldAttribute("mdvolume8", "매도 거래량8", "long", "8")]
		public long mdvolume8;
		/// <summary>
		/// 거래량 순매수8
		/// </summary>
		[XAQueryFieldAttribute("msvol8", "거래량 순매수8", "long", "8")]
		public long msvol8;
		/// <summary>
		/// 매수 거래대금8
		/// </summary>
		[XAQueryFieldAttribute("msvalue8", "매수 거래대금8", "long", "6")]
		public long msvalue8;
		/// <summary>
		/// 매도 거래대금8
		/// </summary>
		[XAQueryFieldAttribute("mdvalue8", "매도 거래대금8", "long", "6")]
		public long mdvalue8;
		/// <summary>
		/// 거래대금 순매수8
		/// </summary>
		[XAQueryFieldAttribute("msval8", "거래대금 순매수8", "long", "6")]
		public long msval8;
		/// <summary>
		/// 투자자코드9(기금)
		/// </summary>
		[XAQueryFieldAttribute("tjjcode9", "투자자코드9(기금)", "char", "4")]
		public string tjjcode9;
		/// <summary>
		/// 매수 거래량9
		/// </summary>
		[XAQueryFieldAttribute("msvolume9", "매수 거래량9", "long", "8")]
		public long msvolume9;
		/// <summary>
		/// 매도 거래량9
		/// </summary>
		[XAQueryFieldAttribute("mdvolume9", "매도 거래량9", "long", "8")]
		public long mdvolume9;
		/// <summary>
		/// 거래량 순매수9
		/// </summary>
		[XAQueryFieldAttribute("msvol9", "거래량 순매수9", "long", "8")]
		public long msvol9;
		/// <summary>
		/// 매수 거래대금9
		/// </summary>
		[XAQueryFieldAttribute("msvalue9", "매수 거래대금9", "long", "6")]
		public long msvalue9;
		/// <summary>
		/// 매도 거래대금9
		/// </summary>
		[XAQueryFieldAttribute("mdvalue9", "매도 거래대금9", "long", "6")]
		public long mdvalue9;
		/// <summary>
		/// 거래대금 순매수9
		/// </summary>
		[XAQueryFieldAttribute("msval9", "거래대금 순매수9", "long", "6")]
		public long msval9;
		/// <summary>
		/// 투자자코드10(선물업자)
		/// </summary>
		[XAQueryFieldAttribute("tjjcode10", "투자자코드10(선물업자)", "char", "4")]
		public string tjjcode10;
		/// <summary>
		/// 매수 거래량10
		/// </summary>
		[XAQueryFieldAttribute("msvolume10", "매수 거래량10", "long", "8")]
		public long msvolume10;
		/// <summary>
		/// 매도 거래량10
		/// </summary>
		[XAQueryFieldAttribute("mdvolume10", "매도 거래량10", "long", "8")]
		public long mdvolume10;
		/// <summary>
		/// 거래량 순매수10
		/// </summary>
		[XAQueryFieldAttribute("msvol10", "거래량 순매수10", "long", "8")]
		public long msvol10;
		/// <summary>
		/// 매수 거래대금10
		/// </summary>
		[XAQueryFieldAttribute("msvalue10", "매수 거래대금10", "long", "6")]
		public long msvalue10;
		/// <summary>
		/// 매도 거래대금10
		/// </summary>
		[XAQueryFieldAttribute("mdvalue10", "매도 거래대금10", "long", "6")]
		public long mdvalue10;
		/// <summary>
		/// 거래대금 순매수10
		/// </summary>
		[XAQueryFieldAttribute("msval10", "거래대금 순매수10", "long", "6")]
		public long msval10;
		/// <summary>
		/// 투자자코드11(기타)
		/// </summary>
		[XAQueryFieldAttribute("tjjcode11", "투자자코드11(기타)", "char", "4")]
		public string tjjcode11;
		/// <summary>
		/// 매수 거래량11
		/// </summary>
		[XAQueryFieldAttribute("msvolume11", "매수 거래량11", "long", "8")]
		public long msvolume11;
		/// <summary>
		/// 매도 거래량11
		/// </summary>
		[XAQueryFieldAttribute("mdvolume11", "매도 거래량11", "long", "8")]
		public long mdvolume11;
		/// <summary>
		/// 거래량 순매수11
		/// </summary>
		[XAQueryFieldAttribute("msvol11", "거래량 순매수11", "long", "8")]
		public long msvol11;
		/// <summary>
		/// 매수 거래대금11
		/// </summary>
		[XAQueryFieldAttribute("msvalue11", "매수 거래대금11", "long", "6")]
		public long msvalue11;
		/// <summary>
		/// 매도 거래대금11
		/// </summary>
		[XAQueryFieldAttribute("mdvalue11", "매도 거래대금11", "long", "6")]
		public long mdvalue11;
		/// <summary>
		/// 거래대금 순매수11
		/// </summary>
		[XAQueryFieldAttribute("msval11", "거래대금 순매수11", "long", "6")]
		public long msval11;
		/// <summary>
		/// 업종코드
		/// </summary>
		[XAQueryFieldAttribute("upcode", "업종코드", "char", "3")]
		public string upcode;
		/// <summary>
		/// 투자자코드0(사모펀드)
		/// </summary>
		[XAQueryFieldAttribute("tjjcode0", "투자자코드0(사모펀드)", "char", "4")]
		public string tjjcode0;
		/// <summary>
		/// 매수 거래량0
		/// </summary>
		[XAQueryFieldAttribute("msvolume0", "매수 거래량0", "long", "8")]
		public long msvolume0;
		/// <summary>
		/// 매도 거래량0
		/// </summary>
		[XAQueryFieldAttribute("mdvolume0", "매도 거래량0", "long", "8")]
		public long mdvolume0;
		/// <summary>
		/// 거래량 순매수0
		/// </summary>
		[XAQueryFieldAttribute("msvol0", "거래량 순매수0", "long", "8")]
		public long msvol0;
		/// <summary>
		/// 매수 거래대금0
		/// </summary>
		[XAQueryFieldAttribute("msvalue0", "매수 거래대금0", "long", "6")]
		public long msvalue0;
		/// <summary>
		/// 매도 거래대금0
		/// </summary>
		[XAQueryFieldAttribute("mdvalue0", "매도 거래대금0", "long", "6")]
		public long mdvalue0;
		/// <summary>
		/// 거래대금 순매수0
		/// </summary>
		[XAQueryFieldAttribute("msval0", "거래대금 순매수0", "long", "6")]
		public long msval0;

		public static class F
		{
			/// <summary>
			/// 수신시간
			/// </summary>
			public const string tjjtime = "tjjtime";
			/// <summary>
			/// 투자자코드1(개인)
			/// </summary>
			public const string tjjcode1 = "tjjcode1";
			/// <summary>
			/// 매수 거래량1
			/// </summary>
			public const string msvolume1 = "msvolume1";
			/// <summary>
			/// 매도 거래량1
			/// </summary>
			public const string mdvolume1 = "mdvolume1";
			/// <summary>
			/// 거래량 순매수1
			/// </summary>
			public const string msvol1 = "msvol1";
			/// <summary>
			/// 매수 거래대금1
			/// </summary>
			public const string msvalue1 = "msvalue1";
			/// <summary>
			/// 매도 거래대금1
			/// </summary>
			public const string mdvalue1 = "mdvalue1";
			/// <summary>
			/// 거래대금 순매수1
			/// </summary>
			public const string msval1 = "msval1";
			/// <summary>
			/// 투자자코드2(외국인)
			/// </summary>
			public const string tjjcode2 = "tjjcode2";
			/// <summary>
			/// 매수 거래량2
			/// </summary>
			public const string msvolume2 = "msvolume2";
			/// <summary>
			/// 매도 거래량2
			/// </summary>
			public const string mdvolume2 = "mdvolume2";
			/// <summary>
			/// 거래량 순매수2
			/// </summary>
			public const string msvol2 = "msvol2";
			/// <summary>
			/// 매수 거래대금2
			/// </summary>
			public const string msvalue2 = "msvalue2";
			/// <summary>
			/// 매도 거래대금2
			/// </summary>
			public const string mdvalue2 = "mdvalue2";
			/// <summary>
			/// 거래대금 순매수2
			/// </summary>
			public const string msval2 = "msval2";
			/// <summary>
			/// 투자자코드3(기관계)
			/// </summary>
			public const string tjjcode3 = "tjjcode3";
			/// <summary>
			/// 매수 거래량3
			/// </summary>
			public const string msvolume3 = "msvolume3";
			/// <summary>
			/// 매도 거래량3
			/// </summary>
			public const string mdvolume3 = "mdvolume3";
			/// <summary>
			/// 거래량 순매수3
			/// </summary>
			public const string msvol3 = "msvol3";
			/// <summary>
			/// 매수 거래대금3
			/// </summary>
			public const string msvalue3 = "msvalue3";
			/// <summary>
			/// 매도 거래대금3
			/// </summary>
			public const string mdvalue3 = "mdvalue3";
			/// <summary>
			/// 거래대금 순매수3
			/// </summary>
			public const string msval3 = "msval3";
			/// <summary>
			/// 투자자코드4(증권)
			/// </summary>
			public const string tjjcode4 = "tjjcode4";
			/// <summary>
			/// 매수 거래량4
			/// </summary>
			public const string msvolume4 = "msvolume4";
			/// <summary>
			/// 매도 거래량4
			/// </summary>
			public const string mdvolume4 = "mdvolume4";
			/// <summary>
			/// 거래량 순매수4
			/// </summary>
			public const string msvol4 = "msvol4";
			/// <summary>
			/// 매수 거래대금4
			/// </summary>
			public const string msvalue4 = "msvalue4";
			/// <summary>
			/// 매도 거래대금4
			/// </summary>
			public const string mdvalue4 = "mdvalue4";
			/// <summary>
			/// 거래대금 순매수4
			/// </summary>
			public const string msval4 = "msval4";
			/// <summary>
			/// 투자자코드5(투신)
			/// </summary>
			public const string tjjcode5 = "tjjcode5";
			/// <summary>
			/// 매수 거래량5
			/// </summary>
			public const string msvolume5 = "msvolume5";
			/// <summary>
			/// 매도 거래량5
			/// </summary>
			public const string mdvolume5 = "mdvolume5";
			/// <summary>
			/// 거래량 순매수5
			/// </summary>
			public const string msvol5 = "msvol5";
			/// <summary>
			/// 매수 거래대금5
			/// </summary>
			public const string msvalue5 = "msvalue5";
			/// <summary>
			/// 매도 거래대금5
			/// </summary>
			public const string mdvalue5 = "mdvalue5";
			/// <summary>
			/// 거래대금 순매수5
			/// </summary>
			public const string msval5 = "msval5";
			/// <summary>
			/// 투자자코드6(은행)
			/// </summary>
			public const string tjjcode6 = "tjjcode6";
			/// <summary>
			/// 매수 거래량6
			/// </summary>
			public const string msvolume6 = "msvolume6";
			/// <summary>
			/// 매도 거래량6
			/// </summary>
			public const string mdvolume6 = "mdvolume6";
			/// <summary>
			/// 거래량 순매수6
			/// </summary>
			public const string msvol6 = "msvol6";
			/// <summary>
			/// 매수 거래대금6
			/// </summary>
			public const string msvalue6 = "msvalue6";
			/// <summary>
			/// 매도 거래대금6
			/// </summary>
			public const string mdvalue6 = "mdvalue6";
			/// <summary>
			/// 거래대금 순매수6
			/// </summary>
			public const string msval6 = "msval6";
			/// <summary>
			/// 투자자코드7(보험)
			/// </summary>
			public const string tjjcode7 = "tjjcode7";
			/// <summary>
			/// 매수 거래량7
			/// </summary>
			public const string msvolume7 = "msvolume7";
			/// <summary>
			/// 매도 거래량7
			/// </summary>
			public const string mdvolume7 = "mdvolume7";
			/// <summary>
			/// 거래량 순매수7
			/// </summary>
			public const string msvol7 = "msvol7";
			/// <summary>
			/// 매수 거래대금7
			/// </summary>
			public const string msvalue7 = "msvalue7";
			/// <summary>
			/// 매도 거래대금7
			/// </summary>
			public const string mdvalue7 = "mdvalue7";
			/// <summary>
			/// 거래대금 순매수7
			/// </summary>
			public const string msval7 = "msval7";
			/// <summary>
			/// 투자자코드8(종금)
			/// </summary>
			public const string tjjcode8 = "tjjcode8";
			/// <summary>
			/// 매수 거래량8
			/// </summary>
			public const string msvolume8 = "msvolume8";
			/// <summary>
			/// 매도 거래량8
			/// </summary>
			public const string mdvolume8 = "mdvolume8";
			/// <summary>
			/// 거래량 순매수8
			/// </summary>
			public const string msvol8 = "msvol8";
			/// <summary>
			/// 매수 거래대금8
			/// </summary>
			public const string msvalue8 = "msvalue8";
			/// <summary>
			/// 매도 거래대금8
			/// </summary>
			public const string mdvalue8 = "mdvalue8";
			/// <summary>
			/// 거래대금 순매수8
			/// </summary>
			public const string msval8 = "msval8";
			/// <summary>
			/// 투자자코드9(기금)
			/// </summary>
			public const string tjjcode9 = "tjjcode9";
			/// <summary>
			/// 매수 거래량9
			/// </summary>
			public const string msvolume9 = "msvolume9";
			/// <summary>
			/// 매도 거래량9
			/// </summary>
			public const string mdvolume9 = "mdvolume9";
			/// <summary>
			/// 거래량 순매수9
			/// </summary>
			public const string msvol9 = "msvol9";
			/// <summary>
			/// 매수 거래대금9
			/// </summary>
			public const string msvalue9 = "msvalue9";
			/// <summary>
			/// 매도 거래대금9
			/// </summary>
			public const string mdvalue9 = "mdvalue9";
			/// <summary>
			/// 거래대금 순매수9
			/// </summary>
			public const string msval9 = "msval9";
			/// <summary>
			/// 투자자코드10(선물업자)
			/// </summary>
			public const string tjjcode10 = "tjjcode10";
			/// <summary>
			/// 매수 거래량10
			/// </summary>
			public const string msvolume10 = "msvolume10";
			/// <summary>
			/// 매도 거래량10
			/// </summary>
			public const string mdvolume10 = "mdvolume10";
			/// <summary>
			/// 거래량 순매수10
			/// </summary>
			public const string msvol10 = "msvol10";
			/// <summary>
			/// 매수 거래대금10
			/// </summary>
			public const string msvalue10 = "msvalue10";
			/// <summary>
			/// 매도 거래대금10
			/// </summary>
			public const string mdvalue10 = "mdvalue10";
			/// <summary>
			/// 거래대금 순매수10
			/// </summary>
			public const string msval10 = "msval10";
			/// <summary>
			/// 투자자코드11(기타)
			/// </summary>
			public const string tjjcode11 = "tjjcode11";
			/// <summary>
			/// 매수 거래량11
			/// </summary>
			public const string msvolume11 = "msvolume11";
			/// <summary>
			/// 매도 거래량11
			/// </summary>
			public const string mdvolume11 = "mdvolume11";
			/// <summary>
			/// 거래량 순매수11
			/// </summary>
			public const string msvol11 = "msvol11";
			/// <summary>
			/// 매수 거래대금11
			/// </summary>
			public const string msvalue11 = "msvalue11";
			/// <summary>
			/// 매도 거래대금11
			/// </summary>
			public const string mdvalue11 = "mdvalue11";
			/// <summary>
			/// 거래대금 순매수11
			/// </summary>
			public const string msval11 = "msval11";
			/// <summary>
			/// 업종코드
			/// </summary>
			public const string upcode = "upcode";
			/// <summary>
			/// 투자자코드0(사모펀드)
			/// </summary>
			public const string tjjcode0 = "tjjcode0";
			/// <summary>
			/// 매수 거래량0
			/// </summary>
			public const string msvolume0 = "msvolume0";
			/// <summary>
			/// 매도 거래량0
			/// </summary>
			public const string mdvolume0 = "mdvolume0";
			/// <summary>
			/// 거래량 순매수0
			/// </summary>
			public const string msvol0 = "msvol0";
			/// <summary>
			/// 매수 거래대금0
			/// </summary>
			public const string msvalue0 = "msvalue0";
			/// <summary>
			/// 매도 거래대금0
			/// </summary>
			public const string mdvalue0 = "mdvalue0";
			/// <summary>
			/// 거래대금 순매수0
			/// </summary>
			public const string msval0 = "msval0";
		}

		public static string[] AllFields = new string[]
		{
			F.tjjtime,
			F.tjjcode1,
			F.msvolume1,
			F.mdvolume1,
			F.msvol1,
			F.msvalue1,
			F.mdvalue1,
			F.msval1,
			F.tjjcode2,
			F.msvolume2,
			F.mdvolume2,
			F.msvol2,
			F.msvalue2,
			F.mdvalue2,
			F.msval2,
			F.tjjcode3,
			F.msvolume3,
			F.mdvolume3,
			F.msvol3,
			F.msvalue3,
			F.mdvalue3,
			F.msval3,
			F.tjjcode4,
			F.msvolume4,
			F.mdvolume4,
			F.msvol4,
			F.msvalue4,
			F.mdvalue4,
			F.msval4,
			F.tjjcode5,
			F.msvolume5,
			F.mdvolume5,
			F.msvol5,
			F.msvalue5,
			F.mdvalue5,
			F.msval5,
			F.tjjcode6,
			F.msvolume6,
			F.mdvolume6,
			F.msvol6,
			F.msvalue6,
			F.mdvalue6,
			F.msval6,
			F.tjjcode7,
			F.msvolume7,
			F.mdvolume7,
			F.msvol7,
			F.msvalue7,
			F.mdvalue7,
			F.msval7,
			F.tjjcode8,
			F.msvolume8,
			F.mdvolume8,
			F.msvol8,
			F.msvalue8,
			F.mdvalue8,
			F.msval8,
			F.tjjcode9,
			F.msvolume9,
			F.mdvolume9,
			F.msvol9,
			F.msvalue9,
			F.mdvalue9,
			F.msval9,
			F.tjjcode10,
			F.msvolume10,
			F.mdvolume10,
			F.msvol10,
			F.msvalue10,
			F.mdvalue10,
			F.msval10,
			F.tjjcode11,
			F.msvolume11,
			F.mdvolume11,
			F.msvol11,
			F.msvalue11,
			F.mdvalue11,
			F.msval11,
			F.upcode,
			F.tjjcode0,
			F.msvolume0,
			F.mdvolume0,
			F.msvol0,
			F.msvalue0,
			F.mdvalue0,
			F.msval0,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["tjjtime"] = new XAQueryFieldInfo("char", tjjtime, tjjtime, "수신시간", (decimal)8);
			dict["tjjcode1"] = new XAQueryFieldInfo("char", tjjcode1, tjjcode1, "투자자코드1(개인)", (decimal)4);
			dict["msvolume1"] = new XAQueryFieldInfo("long", msvolume1, msvolume1.ToString("d8"), "매수 거래량1", (decimal)8);
			dict["mdvolume1"] = new XAQueryFieldInfo("long", mdvolume1, mdvolume1.ToString("d8"), "매도 거래량1", (decimal)8);
			dict["msvol1"] = new XAQueryFieldInfo("long", msvol1, msvol1.ToString("d8"), "거래량 순매수1", (decimal)8);
			dict["msvalue1"] = new XAQueryFieldInfo("long", msvalue1, msvalue1.ToString("d6"), "매수 거래대금1", (decimal)6);
			dict["mdvalue1"] = new XAQueryFieldInfo("long", mdvalue1, mdvalue1.ToString("d6"), "매도 거래대금1", (decimal)6);
			dict["msval1"] = new XAQueryFieldInfo("long", msval1, msval1.ToString("d6"), "거래대금 순매수1", (decimal)6);
			dict["tjjcode2"] = new XAQueryFieldInfo("char", tjjcode2, tjjcode2, "투자자코드2(외국인)", (decimal)4);
			dict["msvolume2"] = new XAQueryFieldInfo("long", msvolume2, msvolume2.ToString("d8"), "매수 거래량2", (decimal)8);
			dict["mdvolume2"] = new XAQueryFieldInfo("long", mdvolume2, mdvolume2.ToString("d8"), "매도 거래량2", (decimal)8);
			dict["msvol2"] = new XAQueryFieldInfo("long", msvol2, msvol2.ToString("d8"), "거래량 순매수2", (decimal)8);
			dict["msvalue2"] = new XAQueryFieldInfo("long", msvalue2, msvalue2.ToString("d6"), "매수 거래대금2", (decimal)6);
			dict["mdvalue2"] = new XAQueryFieldInfo("long", mdvalue2, mdvalue2.ToString("d6"), "매도 거래대금2", (decimal)6);
			dict["msval2"] = new XAQueryFieldInfo("long", msval2, msval2.ToString("d6"), "거래대금 순매수2", (decimal)6);
			dict["tjjcode3"] = new XAQueryFieldInfo("char", tjjcode3, tjjcode3, "투자자코드3(기관계)", (decimal)4);
			dict["msvolume3"] = new XAQueryFieldInfo("long", msvolume3, msvolume3.ToString("d8"), "매수 거래량3", (decimal)8);
			dict["mdvolume3"] = new XAQueryFieldInfo("long", mdvolume3, mdvolume3.ToString("d8"), "매도 거래량3", (decimal)8);
			dict["msvol3"] = new XAQueryFieldInfo("long", msvol3, msvol3.ToString("d8"), "거래량 순매수3", (decimal)8);
			dict["msvalue3"] = new XAQueryFieldInfo("long", msvalue3, msvalue3.ToString("d6"), "매수 거래대금3", (decimal)6);
			dict["mdvalue3"] = new XAQueryFieldInfo("long", mdvalue3, mdvalue3.ToString("d6"), "매도 거래대금3", (decimal)6);
			dict["msval3"] = new XAQueryFieldInfo("long", msval3, msval3.ToString("d6"), "거래대금 순매수3", (decimal)6);
			dict["tjjcode4"] = new XAQueryFieldInfo("char", tjjcode4, tjjcode4, "투자자코드4(증권)", (decimal)4);
			dict["msvolume4"] = new XAQueryFieldInfo("long", msvolume4, msvolume4.ToString("d8"), "매수 거래량4", (decimal)8);
			dict["mdvolume4"] = new XAQueryFieldInfo("long", mdvolume4, mdvolume4.ToString("d8"), "매도 거래량4", (decimal)8);
			dict["msvol4"] = new XAQueryFieldInfo("long", msvol4, msvol4.ToString("d8"), "거래량 순매수4", (decimal)8);
			dict["msvalue4"] = new XAQueryFieldInfo("long", msvalue4, msvalue4.ToString("d6"), "매수 거래대금4", (decimal)6);
			dict["mdvalue4"] = new XAQueryFieldInfo("long", mdvalue4, mdvalue4.ToString("d6"), "매도 거래대금4", (decimal)6);
			dict["msval4"] = new XAQueryFieldInfo("long", msval4, msval4.ToString("d6"), "거래대금 순매수4", (decimal)6);
			dict["tjjcode5"] = new XAQueryFieldInfo("char", tjjcode5, tjjcode5, "투자자코드5(투신)", (decimal)4);
			dict["msvolume5"] = new XAQueryFieldInfo("long", msvolume5, msvolume5.ToString("d8"), "매수 거래량5", (decimal)8);
			dict["mdvolume5"] = new XAQueryFieldInfo("long", mdvolume5, mdvolume5.ToString("d8"), "매도 거래량5", (decimal)8);
			dict["msvol5"] = new XAQueryFieldInfo("long", msvol5, msvol5.ToString("d8"), "거래량 순매수5", (decimal)8);
			dict["msvalue5"] = new XAQueryFieldInfo("long", msvalue5, msvalue5.ToString("d6"), "매수 거래대금5", (decimal)6);
			dict["mdvalue5"] = new XAQueryFieldInfo("long", mdvalue5, mdvalue5.ToString("d6"), "매도 거래대금5", (decimal)6);
			dict["msval5"] = new XAQueryFieldInfo("long", msval5, msval5.ToString("d6"), "거래대금 순매수5", (decimal)6);
			dict["tjjcode6"] = new XAQueryFieldInfo("char", tjjcode6, tjjcode6, "투자자코드6(은행)", (decimal)4);
			dict["msvolume6"] = new XAQueryFieldInfo("long", msvolume6, msvolume6.ToString("d8"), "매수 거래량6", (decimal)8);
			dict["mdvolume6"] = new XAQueryFieldInfo("long", mdvolume6, mdvolume6.ToString("d8"), "매도 거래량6", (decimal)8);
			dict["msvol6"] = new XAQueryFieldInfo("long", msvol6, msvol6.ToString("d8"), "거래량 순매수6", (decimal)8);
			dict["msvalue6"] = new XAQueryFieldInfo("long", msvalue6, msvalue6.ToString("d6"), "매수 거래대금6", (decimal)6);
			dict["mdvalue6"] = new XAQueryFieldInfo("long", mdvalue6, mdvalue6.ToString("d6"), "매도 거래대금6", (decimal)6);
			dict["msval6"] = new XAQueryFieldInfo("long", msval6, msval6.ToString("d6"), "거래대금 순매수6", (decimal)6);
			dict["tjjcode7"] = new XAQueryFieldInfo("char", tjjcode7, tjjcode7, "투자자코드7(보험)", (decimal)4);
			dict["msvolume7"] = new XAQueryFieldInfo("long", msvolume7, msvolume7.ToString("d8"), "매수 거래량7", (decimal)8);
			dict["mdvolume7"] = new XAQueryFieldInfo("long", mdvolume7, mdvolume7.ToString("d8"), "매도 거래량7", (decimal)8);
			dict["msvol7"] = new XAQueryFieldInfo("long", msvol7, msvol7.ToString("d8"), "거래량 순매수7", (decimal)8);
			dict["msvalue7"] = new XAQueryFieldInfo("long", msvalue7, msvalue7.ToString("d6"), "매수 거래대금7", (decimal)6);
			dict["mdvalue7"] = new XAQueryFieldInfo("long", mdvalue7, mdvalue7.ToString("d6"), "매도 거래대금7", (decimal)6);
			dict["msval7"] = new XAQueryFieldInfo("long", msval7, msval7.ToString("d6"), "거래대금 순매수7", (decimal)6);
			dict["tjjcode8"] = new XAQueryFieldInfo("char", tjjcode8, tjjcode8, "투자자코드8(종금)", (decimal)4);
			dict["msvolume8"] = new XAQueryFieldInfo("long", msvolume8, msvolume8.ToString("d8"), "매수 거래량8", (decimal)8);
			dict["mdvolume8"] = new XAQueryFieldInfo("long", mdvolume8, mdvolume8.ToString("d8"), "매도 거래량8", (decimal)8);
			dict["msvol8"] = new XAQueryFieldInfo("long", msvol8, msvol8.ToString("d8"), "거래량 순매수8", (decimal)8);
			dict["msvalue8"] = new XAQueryFieldInfo("long", msvalue8, msvalue8.ToString("d6"), "매수 거래대금8", (decimal)6);
			dict["mdvalue8"] = new XAQueryFieldInfo("long", mdvalue8, mdvalue8.ToString("d6"), "매도 거래대금8", (decimal)6);
			dict["msval8"] = new XAQueryFieldInfo("long", msval8, msval8.ToString("d6"), "거래대금 순매수8", (decimal)6);
			dict["tjjcode9"] = new XAQueryFieldInfo("char", tjjcode9, tjjcode9, "투자자코드9(기금)", (decimal)4);
			dict["msvolume9"] = new XAQueryFieldInfo("long", msvolume9, msvolume9.ToString("d8"), "매수 거래량9", (decimal)8);
			dict["mdvolume9"] = new XAQueryFieldInfo("long", mdvolume9, mdvolume9.ToString("d8"), "매도 거래량9", (decimal)8);
			dict["msvol9"] = new XAQueryFieldInfo("long", msvol9, msvol9.ToString("d8"), "거래량 순매수9", (decimal)8);
			dict["msvalue9"] = new XAQueryFieldInfo("long", msvalue9, msvalue9.ToString("d6"), "매수 거래대금9", (decimal)6);
			dict["mdvalue9"] = new XAQueryFieldInfo("long", mdvalue9, mdvalue9.ToString("d6"), "매도 거래대금9", (decimal)6);
			dict["msval9"] = new XAQueryFieldInfo("long", msval9, msval9.ToString("d6"), "거래대금 순매수9", (decimal)6);
			dict["tjjcode10"] = new XAQueryFieldInfo("char", tjjcode10, tjjcode10, "투자자코드10(선물업자)", (decimal)4);
			dict["msvolume10"] = new XAQueryFieldInfo("long", msvolume10, msvolume10.ToString("d8"), "매수 거래량10", (decimal)8);
			dict["mdvolume10"] = new XAQueryFieldInfo("long", mdvolume10, mdvolume10.ToString("d8"), "매도 거래량10", (decimal)8);
			dict["msvol10"] = new XAQueryFieldInfo("long", msvol10, msvol10.ToString("d8"), "거래량 순매수10", (decimal)8);
			dict["msvalue10"] = new XAQueryFieldInfo("long", msvalue10, msvalue10.ToString("d6"), "매수 거래대금10", (decimal)6);
			dict["mdvalue10"] = new XAQueryFieldInfo("long", mdvalue10, mdvalue10.ToString("d6"), "매도 거래대금10", (decimal)6);
			dict["msval10"] = new XAQueryFieldInfo("long", msval10, msval10.ToString("d6"), "거래대금 순매수10", (decimal)6);
			dict["tjjcode11"] = new XAQueryFieldInfo("char", tjjcode11, tjjcode11, "투자자코드11(기타)", (decimal)4);
			dict["msvolume11"] = new XAQueryFieldInfo("long", msvolume11, msvolume11.ToString("d8"), "매수 거래량11", (decimal)8);
			dict["mdvolume11"] = new XAQueryFieldInfo("long", mdvolume11, mdvolume11.ToString("d8"), "매도 거래량11", (decimal)8);
			dict["msvol11"] = new XAQueryFieldInfo("long", msvol11, msvol11.ToString("d8"), "거래량 순매수11", (decimal)8);
			dict["msvalue11"] = new XAQueryFieldInfo("long", msvalue11, msvalue11.ToString("d6"), "매수 거래대금11", (decimal)6);
			dict["mdvalue11"] = new XAQueryFieldInfo("long", mdvalue11, mdvalue11.ToString("d6"), "매도 거래대금11", (decimal)6);
			dict["msval11"] = new XAQueryFieldInfo("long", msval11, msval11.ToString("d6"), "거래대금 순매수11", (decimal)6);
			dict["upcode"] = new XAQueryFieldInfo("char", upcode, upcode, "업종코드", (decimal)3);
			dict["tjjcode0"] = new XAQueryFieldInfo("char", tjjcode0, tjjcode0, "투자자코드0(사모펀드)", (decimal)4);
			dict["msvolume0"] = new XAQueryFieldInfo("long", msvolume0, msvolume0.ToString("d8"), "매수 거래량0", (decimal)8);
			dict["mdvolume0"] = new XAQueryFieldInfo("long", mdvolume0, mdvolume0.ToString("d8"), "매도 거래량0", (decimal)8);
			dict["msvol0"] = new XAQueryFieldInfo("long", msvol0, msvol0.ToString("d8"), "거래량 순매수0", (decimal)8);
			dict["msvalue0"] = new XAQueryFieldInfo("long", msvalue0, msvalue0.ToString("d6"), "매수 거래대금0", (decimal)6);
			dict["mdvalue0"] = new XAQueryFieldInfo("long", mdvalue0, mdvalue0.ToString("d6"), "매도 거래대금0", (decimal)6);
			dict["msval0"] = new XAQueryFieldInfo("long", msval0, msval0.ToString("d6"), "거래대금 순매수0", (decimal)6);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "tjjtime":
					this.tjjtime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "tjjcode1":
					this.tjjcode1 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "msvolume1":
					this.msvolume1 = fieldInfo.FieldValue.ParseLong("msvolume1");
				break;

				case "mdvolume1":
					this.mdvolume1 = fieldInfo.FieldValue.ParseLong("mdvolume1");
				break;

				case "msvol1":
					this.msvol1 = fieldInfo.FieldValue.ParseLong("msvol1");
				break;

				case "msvalue1":
					this.msvalue1 = fieldInfo.FieldValue.ParseLong("msvalue1");
				break;

				case "mdvalue1":
					this.mdvalue1 = fieldInfo.FieldValue.ParseLong("mdvalue1");
				break;

				case "msval1":
					this.msval1 = fieldInfo.FieldValue.ParseLong("msval1");
				break;

				case "tjjcode2":
					this.tjjcode2 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "msvolume2":
					this.msvolume2 = fieldInfo.FieldValue.ParseLong("msvolume2");
				break;

				case "mdvolume2":
					this.mdvolume2 = fieldInfo.FieldValue.ParseLong("mdvolume2");
				break;

				case "msvol2":
					this.msvol2 = fieldInfo.FieldValue.ParseLong("msvol2");
				break;

				case "msvalue2":
					this.msvalue2 = fieldInfo.FieldValue.ParseLong("msvalue2");
				break;

				case "mdvalue2":
					this.mdvalue2 = fieldInfo.FieldValue.ParseLong("mdvalue2");
				break;

				case "msval2":
					this.msval2 = fieldInfo.FieldValue.ParseLong("msval2");
				break;

				case "tjjcode3":
					this.tjjcode3 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "msvolume3":
					this.msvolume3 = fieldInfo.FieldValue.ParseLong("msvolume3");
				break;

				case "mdvolume3":
					this.mdvolume3 = fieldInfo.FieldValue.ParseLong("mdvolume3");
				break;

				case "msvol3":
					this.msvol3 = fieldInfo.FieldValue.ParseLong("msvol3");
				break;

				case "msvalue3":
					this.msvalue3 = fieldInfo.FieldValue.ParseLong("msvalue3");
				break;

				case "mdvalue3":
					this.mdvalue3 = fieldInfo.FieldValue.ParseLong("mdvalue3");
				break;

				case "msval3":
					this.msval3 = fieldInfo.FieldValue.ParseLong("msval3");
				break;

				case "tjjcode4":
					this.tjjcode4 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "msvolume4":
					this.msvolume4 = fieldInfo.FieldValue.ParseLong("msvolume4");
				break;

				case "mdvolume4":
					this.mdvolume4 = fieldInfo.FieldValue.ParseLong("mdvolume4");
				break;

				case "msvol4":
					this.msvol4 = fieldInfo.FieldValue.ParseLong("msvol4");
				break;

				case "msvalue4":
					this.msvalue4 = fieldInfo.FieldValue.ParseLong("msvalue4");
				break;

				case "mdvalue4":
					this.mdvalue4 = fieldInfo.FieldValue.ParseLong("mdvalue4");
				break;

				case "msval4":
					this.msval4 = fieldInfo.FieldValue.ParseLong("msval4");
				break;

				case "tjjcode5":
					this.tjjcode5 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "msvolume5":
					this.msvolume5 = fieldInfo.FieldValue.ParseLong("msvolume5");
				break;

				case "mdvolume5":
					this.mdvolume5 = fieldInfo.FieldValue.ParseLong("mdvolume5");
				break;

				case "msvol5":
					this.msvol5 = fieldInfo.FieldValue.ParseLong("msvol5");
				break;

				case "msvalue5":
					this.msvalue5 = fieldInfo.FieldValue.ParseLong("msvalue5");
				break;

				case "mdvalue5":
					this.mdvalue5 = fieldInfo.FieldValue.ParseLong("mdvalue5");
				break;

				case "msval5":
					this.msval5 = fieldInfo.FieldValue.ParseLong("msval5");
				break;

				case "tjjcode6":
					this.tjjcode6 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "msvolume6":
					this.msvolume6 = fieldInfo.FieldValue.ParseLong("msvolume6");
				break;

				case "mdvolume6":
					this.mdvolume6 = fieldInfo.FieldValue.ParseLong("mdvolume6");
				break;

				case "msvol6":
					this.msvol6 = fieldInfo.FieldValue.ParseLong("msvol6");
				break;

				case "msvalue6":
					this.msvalue6 = fieldInfo.FieldValue.ParseLong("msvalue6");
				break;

				case "mdvalue6":
					this.mdvalue6 = fieldInfo.FieldValue.ParseLong("mdvalue6");
				break;

				case "msval6":
					this.msval6 = fieldInfo.FieldValue.ParseLong("msval6");
				break;

				case "tjjcode7":
					this.tjjcode7 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "msvolume7":
					this.msvolume7 = fieldInfo.FieldValue.ParseLong("msvolume7");
				break;

				case "mdvolume7":
					this.mdvolume7 = fieldInfo.FieldValue.ParseLong("mdvolume7");
				break;

				case "msvol7":
					this.msvol7 = fieldInfo.FieldValue.ParseLong("msvol7");
				break;

				case "msvalue7":
					this.msvalue7 = fieldInfo.FieldValue.ParseLong("msvalue7");
				break;

				case "mdvalue7":
					this.mdvalue7 = fieldInfo.FieldValue.ParseLong("mdvalue7");
				break;

				case "msval7":
					this.msval7 = fieldInfo.FieldValue.ParseLong("msval7");
				break;

				case "tjjcode8":
					this.tjjcode8 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "msvolume8":
					this.msvolume8 = fieldInfo.FieldValue.ParseLong("msvolume8");
				break;

				case "mdvolume8":
					this.mdvolume8 = fieldInfo.FieldValue.ParseLong("mdvolume8");
				break;

				case "msvol8":
					this.msvol8 = fieldInfo.FieldValue.ParseLong("msvol8");
				break;

				case "msvalue8":
					this.msvalue8 = fieldInfo.FieldValue.ParseLong("msvalue8");
				break;

				case "mdvalue8":
					this.mdvalue8 = fieldInfo.FieldValue.ParseLong("mdvalue8");
				break;

				case "msval8":
					this.msval8 = fieldInfo.FieldValue.ParseLong("msval8");
				break;

				case "tjjcode9":
					this.tjjcode9 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "msvolume9":
					this.msvolume9 = fieldInfo.FieldValue.ParseLong("msvolume9");
				break;

				case "mdvolume9":
					this.mdvolume9 = fieldInfo.FieldValue.ParseLong("mdvolume9");
				break;

				case "msvol9":
					this.msvol9 = fieldInfo.FieldValue.ParseLong("msvol9");
				break;

				case "msvalue9":
					this.msvalue9 = fieldInfo.FieldValue.ParseLong("msvalue9");
				break;

				case "mdvalue9":
					this.mdvalue9 = fieldInfo.FieldValue.ParseLong("mdvalue9");
				break;

				case "msval9":
					this.msval9 = fieldInfo.FieldValue.ParseLong("msval9");
				break;

				case "tjjcode10":
					this.tjjcode10 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "msvolume10":
					this.msvolume10 = fieldInfo.FieldValue.ParseLong("msvolume10");
				break;

				case "mdvolume10":
					this.mdvolume10 = fieldInfo.FieldValue.ParseLong("mdvolume10");
				break;

				case "msvol10":
					this.msvol10 = fieldInfo.FieldValue.ParseLong("msvol10");
				break;

				case "msvalue10":
					this.msvalue10 = fieldInfo.FieldValue.ParseLong("msvalue10");
				break;

				case "mdvalue10":
					this.mdvalue10 = fieldInfo.FieldValue.ParseLong("mdvalue10");
				break;

				case "msval10":
					this.msval10 = fieldInfo.FieldValue.ParseLong("msval10");
				break;

				case "tjjcode11":
					this.tjjcode11 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "msvolume11":
					this.msvolume11 = fieldInfo.FieldValue.ParseLong("msvolume11");
				break;

				case "mdvolume11":
					this.mdvolume11 = fieldInfo.FieldValue.ParseLong("mdvolume11");
				break;

				case "msvol11":
					this.msvol11 = fieldInfo.FieldValue.ParseLong("msvol11");
				break;

				case "msvalue11":
					this.msvalue11 = fieldInfo.FieldValue.ParseLong("msvalue11");
				break;

				case "mdvalue11":
					this.mdvalue11 = fieldInfo.FieldValue.ParseLong("mdvalue11");
				break;

				case "msval11":
					this.msval11 = fieldInfo.FieldValue.ParseLong("msval11");
				break;

				case "upcode":
					this.upcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "tjjcode0":
					this.tjjcode0 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "msvolume0":
					this.msvolume0 = fieldInfo.FieldValue.ParseLong("msvolume0");
				break;

				case "mdvolume0":
					this.mdvolume0 = fieldInfo.FieldValue.ParseLong("mdvolume0");
				break;

				case "msvol0":
					this.msvol0 = fieldInfo.FieldValue.ParseLong("msvol0");
				break;

				case "msvalue0":
					this.msvalue0 = fieldInfo.FieldValue.ParseLong("msvalue0");
				break;

				case "mdvalue0":
					this.mdvalue0 = fieldInfo.FieldValue.ParseLong("mdvalue0");
				break;

				case "msval0":
					this.msval0 = fieldInfo.FieldValue.ParseLong("msval0");
				break;


			}
		}

		public static XRBMTOutBlock FromQuery(XRBMT query)
		{
			XRBMTOutBlock block = new XRBMTOutBlock();
			block.IsValidData = true;
			block.InvalidReason = "";
			try
			{
				block.tjjtime = query.GetFieldData(block.GetBlockName(), "tjjtime").TrimEnd('?'); // char 8
				block.tjjcode1 = query.GetFieldData(block.GetBlockName(), "tjjcode1").TrimEnd('?'); // char 4
				block.msvolume1 = query.GetFieldData(block.GetBlockName(), "msvolume1").ParseLong("msvolume1"); // long 8
				block.mdvolume1 = query.GetFieldData(block.GetBlockName(), "mdvolume1").ParseLong("mdvolume1"); // long 8
				block.msvol1 = query.GetFieldData(block.GetBlockName(), "msvol1").ParseLong("msvol1"); // long 8
				block.msvalue1 = query.GetFieldData(block.GetBlockName(), "msvalue1").ParseLong("msvalue1"); // long 6
				block.mdvalue1 = query.GetFieldData(block.GetBlockName(), "mdvalue1").ParseLong("mdvalue1"); // long 6
				block.msval1 = query.GetFieldData(block.GetBlockName(), "msval1").ParseLong("msval1"); // long 6
				block.tjjcode2 = query.GetFieldData(block.GetBlockName(), "tjjcode2").TrimEnd('?'); // char 4
				block.msvolume2 = query.GetFieldData(block.GetBlockName(), "msvolume2").ParseLong("msvolume2"); // long 8
				block.mdvolume2 = query.GetFieldData(block.GetBlockName(), "mdvolume2").ParseLong("mdvolume2"); // long 8
				block.msvol2 = query.GetFieldData(block.GetBlockName(), "msvol2").ParseLong("msvol2"); // long 8
				block.msvalue2 = query.GetFieldData(block.GetBlockName(), "msvalue2").ParseLong("msvalue2"); // long 6
				block.mdvalue2 = query.GetFieldData(block.GetBlockName(), "mdvalue2").ParseLong("mdvalue2"); // long 6
				block.msval2 = query.GetFieldData(block.GetBlockName(), "msval2").ParseLong("msval2"); // long 6
				block.tjjcode3 = query.GetFieldData(block.GetBlockName(), "tjjcode3").TrimEnd('?'); // char 4
				block.msvolume3 = query.GetFieldData(block.GetBlockName(), "msvolume3").ParseLong("msvolume3"); // long 8
				block.mdvolume3 = query.GetFieldData(block.GetBlockName(), "mdvolume3").ParseLong("mdvolume3"); // long 8
				block.msvol3 = query.GetFieldData(block.GetBlockName(), "msvol3").ParseLong("msvol3"); // long 8
				block.msvalue3 = query.GetFieldData(block.GetBlockName(), "msvalue3").ParseLong("msvalue3"); // long 6
				block.mdvalue3 = query.GetFieldData(block.GetBlockName(), "mdvalue3").ParseLong("mdvalue3"); // long 6
				block.msval3 = query.GetFieldData(block.GetBlockName(), "msval3").ParseLong("msval3"); // long 6
				block.tjjcode4 = query.GetFieldData(block.GetBlockName(), "tjjcode4").TrimEnd('?'); // char 4
				block.msvolume4 = query.GetFieldData(block.GetBlockName(), "msvolume4").ParseLong("msvolume4"); // long 8
				block.mdvolume4 = query.GetFieldData(block.GetBlockName(), "mdvolume4").ParseLong("mdvolume4"); // long 8
				block.msvol4 = query.GetFieldData(block.GetBlockName(), "msvol4").ParseLong("msvol4"); // long 8
				block.msvalue4 = query.GetFieldData(block.GetBlockName(), "msvalue4").ParseLong("msvalue4"); // long 6
				block.mdvalue4 = query.GetFieldData(block.GetBlockName(), "mdvalue4").ParseLong("mdvalue4"); // long 6
				block.msval4 = query.GetFieldData(block.GetBlockName(), "msval4").ParseLong("msval4"); // long 6
				block.tjjcode5 = query.GetFieldData(block.GetBlockName(), "tjjcode5").TrimEnd('?'); // char 4
				block.msvolume5 = query.GetFieldData(block.GetBlockName(), "msvolume5").ParseLong("msvolume5"); // long 8
				block.mdvolume5 = query.GetFieldData(block.GetBlockName(), "mdvolume5").ParseLong("mdvolume5"); // long 8
				block.msvol5 = query.GetFieldData(block.GetBlockName(), "msvol5").ParseLong("msvol5"); // long 8
				block.msvalue5 = query.GetFieldData(block.GetBlockName(), "msvalue5").ParseLong("msvalue5"); // long 6
				block.mdvalue5 = query.GetFieldData(block.GetBlockName(), "mdvalue5").ParseLong("mdvalue5"); // long 6
				block.msval5 = query.GetFieldData(block.GetBlockName(), "msval5").ParseLong("msval5"); // long 6
				block.tjjcode6 = query.GetFieldData(block.GetBlockName(), "tjjcode6").TrimEnd('?'); // char 4
				block.msvolume6 = query.GetFieldData(block.GetBlockName(), "msvolume6").ParseLong("msvolume6"); // long 8
				block.mdvolume6 = query.GetFieldData(block.GetBlockName(), "mdvolume6").ParseLong("mdvolume6"); // long 8
				block.msvol6 = query.GetFieldData(block.GetBlockName(), "msvol6").ParseLong("msvol6"); // long 8
				block.msvalue6 = query.GetFieldData(block.GetBlockName(), "msvalue6").ParseLong("msvalue6"); // long 6
				block.mdvalue6 = query.GetFieldData(block.GetBlockName(), "mdvalue6").ParseLong("mdvalue6"); // long 6
				block.msval6 = query.GetFieldData(block.GetBlockName(), "msval6").ParseLong("msval6"); // long 6
				block.tjjcode7 = query.GetFieldData(block.GetBlockName(), "tjjcode7").TrimEnd('?'); // char 4
				block.msvolume7 = query.GetFieldData(block.GetBlockName(), "msvolume7").ParseLong("msvolume7"); // long 8
				block.mdvolume7 = query.GetFieldData(block.GetBlockName(), "mdvolume7").ParseLong("mdvolume7"); // long 8
				block.msvol7 = query.GetFieldData(block.GetBlockName(), "msvol7").ParseLong("msvol7"); // long 8
				block.msvalue7 = query.GetFieldData(block.GetBlockName(), "msvalue7").ParseLong("msvalue7"); // long 6
				block.mdvalue7 = query.GetFieldData(block.GetBlockName(), "mdvalue7").ParseLong("mdvalue7"); // long 6
				block.msval7 = query.GetFieldData(block.GetBlockName(), "msval7").ParseLong("msval7"); // long 6
				block.tjjcode8 = query.GetFieldData(block.GetBlockName(), "tjjcode8").TrimEnd('?'); // char 4
				block.msvolume8 = query.GetFieldData(block.GetBlockName(), "msvolume8").ParseLong("msvolume8"); // long 8
				block.mdvolume8 = query.GetFieldData(block.GetBlockName(), "mdvolume8").ParseLong("mdvolume8"); // long 8
				block.msvol8 = query.GetFieldData(block.GetBlockName(), "msvol8").ParseLong("msvol8"); // long 8
				block.msvalue8 = query.GetFieldData(block.GetBlockName(), "msvalue8").ParseLong("msvalue8"); // long 6
				block.mdvalue8 = query.GetFieldData(block.GetBlockName(), "mdvalue8").ParseLong("mdvalue8"); // long 6
				block.msval8 = query.GetFieldData(block.GetBlockName(), "msval8").ParseLong("msval8"); // long 6
				block.tjjcode9 = query.GetFieldData(block.GetBlockName(), "tjjcode9").TrimEnd('?'); // char 4
				block.msvolume9 = query.GetFieldData(block.GetBlockName(), "msvolume9").ParseLong("msvolume9"); // long 8
				block.mdvolume9 = query.GetFieldData(block.GetBlockName(), "mdvolume9").ParseLong("mdvolume9"); // long 8
				block.msvol9 = query.GetFieldData(block.GetBlockName(), "msvol9").ParseLong("msvol9"); // long 8
				block.msvalue9 = query.GetFieldData(block.GetBlockName(), "msvalue9").ParseLong("msvalue9"); // long 6
				block.mdvalue9 = query.GetFieldData(block.GetBlockName(), "mdvalue9").ParseLong("mdvalue9"); // long 6
				block.msval9 = query.GetFieldData(block.GetBlockName(), "msval9").ParseLong("msval9"); // long 6
				block.tjjcode10 = query.GetFieldData(block.GetBlockName(), "tjjcode10").TrimEnd('?'); // char 4
				block.msvolume10 = query.GetFieldData(block.GetBlockName(), "msvolume10").ParseLong("msvolume10"); // long 8
				block.mdvolume10 = query.GetFieldData(block.GetBlockName(), "mdvolume10").ParseLong("mdvolume10"); // long 8
				block.msvol10 = query.GetFieldData(block.GetBlockName(), "msvol10").ParseLong("msvol10"); // long 8
				block.msvalue10 = query.GetFieldData(block.GetBlockName(), "msvalue10").ParseLong("msvalue10"); // long 6
				block.mdvalue10 = query.GetFieldData(block.GetBlockName(), "mdvalue10").ParseLong("mdvalue10"); // long 6
				block.msval10 = query.GetFieldData(block.GetBlockName(), "msval10").ParseLong("msval10"); // long 6
				block.tjjcode11 = query.GetFieldData(block.GetBlockName(), "tjjcode11").TrimEnd('?'); // char 4
				block.msvolume11 = query.GetFieldData(block.GetBlockName(), "msvolume11").ParseLong("msvolume11"); // long 8
				block.mdvolume11 = query.GetFieldData(block.GetBlockName(), "mdvolume11").ParseLong("mdvolume11"); // long 8
				block.msvol11 = query.GetFieldData(block.GetBlockName(), "msvol11").ParseLong("msvol11"); // long 8
				block.msvalue11 = query.GetFieldData(block.GetBlockName(), "msvalue11").ParseLong("msvalue11"); // long 6
				block.mdvalue11 = query.GetFieldData(block.GetBlockName(), "mdvalue11").ParseLong("mdvalue11"); // long 6
				block.msval11 = query.GetFieldData(block.GetBlockName(), "msval11").ParseLong("msval11"); // long 6
				block.upcode = query.GetFieldData(block.GetBlockName(), "upcode").TrimEnd('?'); // char 3
				block.tjjcode0 = query.GetFieldData(block.GetBlockName(), "tjjcode0").TrimEnd('?'); // char 4
				block.msvolume0 = query.GetFieldData(block.GetBlockName(), "msvolume0").ParseLong("msvolume0"); // long 8
				block.mdvolume0 = query.GetFieldData(block.GetBlockName(), "mdvolume0").ParseLong("mdvolume0"); // long 8
				block.msvol0 = query.GetFieldData(block.GetBlockName(), "msvol0").ParseLong("msvol0"); // long 8
				block.msvalue0 = query.GetFieldData(block.GetBlockName(), "msvalue0").ParseLong("msvalue0"); // long 6
				block.mdvalue0 = query.GetFieldData(block.GetBlockName(), "mdvalue0").ParseLong("mdvalue0"); // long 6
				block.msval0 = query.GetFieldData(block.GetBlockName(), "msval0").ParseLong("msval0"); // long 6

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (tjjtime?.Length > 8) return false; // char 8
			if (tjjcode1?.Length > 4) return false; // char 4
			if (msvolume1.ToString().Length > 8) return false; // long 8
			if (mdvolume1.ToString().Length > 8) return false; // long 8
			if (msvol1.ToString().Length > 8) return false; // long 8
			if (msvalue1.ToString().Length > 6) return false; // long 6
			if (mdvalue1.ToString().Length > 6) return false; // long 6
			if (msval1.ToString().Length > 6) return false; // long 6
			if (tjjcode2?.Length > 4) return false; // char 4
			if (msvolume2.ToString().Length > 8) return false; // long 8
			if (mdvolume2.ToString().Length > 8) return false; // long 8
			if (msvol2.ToString().Length > 8) return false; // long 8
			if (msvalue2.ToString().Length > 6) return false; // long 6
			if (mdvalue2.ToString().Length > 6) return false; // long 6
			if (msval2.ToString().Length > 6) return false; // long 6
			if (tjjcode3?.Length > 4) return false; // char 4
			if (msvolume3.ToString().Length > 8) return false; // long 8
			if (mdvolume3.ToString().Length > 8) return false; // long 8
			if (msvol3.ToString().Length > 8) return false; // long 8
			if (msvalue3.ToString().Length > 6) return false; // long 6
			if (mdvalue3.ToString().Length > 6) return false; // long 6
			if (msval3.ToString().Length > 6) return false; // long 6
			if (tjjcode4?.Length > 4) return false; // char 4
			if (msvolume4.ToString().Length > 8) return false; // long 8
			if (mdvolume4.ToString().Length > 8) return false; // long 8
			if (msvol4.ToString().Length > 8) return false; // long 8
			if (msvalue4.ToString().Length > 6) return false; // long 6
			if (mdvalue4.ToString().Length > 6) return false; // long 6
			if (msval4.ToString().Length > 6) return false; // long 6
			if (tjjcode5?.Length > 4) return false; // char 4
			if (msvolume5.ToString().Length > 8) return false; // long 8
			if (mdvolume5.ToString().Length > 8) return false; // long 8
			if (msvol5.ToString().Length > 8) return false; // long 8
			if (msvalue5.ToString().Length > 6) return false; // long 6
			if (mdvalue5.ToString().Length > 6) return false; // long 6
			if (msval5.ToString().Length > 6) return false; // long 6
			if (tjjcode6?.Length > 4) return false; // char 4
			if (msvolume6.ToString().Length > 8) return false; // long 8
			if (mdvolume6.ToString().Length > 8) return false; // long 8
			if (msvol6.ToString().Length > 8) return false; // long 8
			if (msvalue6.ToString().Length > 6) return false; // long 6
			if (mdvalue6.ToString().Length > 6) return false; // long 6
			if (msval6.ToString().Length > 6) return false; // long 6
			if (tjjcode7?.Length > 4) return false; // char 4
			if (msvolume7.ToString().Length > 8) return false; // long 8
			if (mdvolume7.ToString().Length > 8) return false; // long 8
			if (msvol7.ToString().Length > 8) return false; // long 8
			if (msvalue7.ToString().Length > 6) return false; // long 6
			if (mdvalue7.ToString().Length > 6) return false; // long 6
			if (msval7.ToString().Length > 6) return false; // long 6
			if (tjjcode8?.Length > 4) return false; // char 4
			if (msvolume8.ToString().Length > 8) return false; // long 8
			if (mdvolume8.ToString().Length > 8) return false; // long 8
			if (msvol8.ToString().Length > 8) return false; // long 8
			if (msvalue8.ToString().Length > 6) return false; // long 6
			if (mdvalue8.ToString().Length > 6) return false; // long 6
			if (msval8.ToString().Length > 6) return false; // long 6
			if (tjjcode9?.Length > 4) return false; // char 4
			if (msvolume9.ToString().Length > 8) return false; // long 8
			if (mdvolume9.ToString().Length > 8) return false; // long 8
			if (msvol9.ToString().Length > 8) return false; // long 8
			if (msvalue9.ToString().Length > 6) return false; // long 6
			if (mdvalue9.ToString().Length > 6) return false; // long 6
			if (msval9.ToString().Length > 6) return false; // long 6
			if (tjjcode10?.Length > 4) return false; // char 4
			if (msvolume10.ToString().Length > 8) return false; // long 8
			if (mdvolume10.ToString().Length > 8) return false; // long 8
			if (msvol10.ToString().Length > 8) return false; // long 8
			if (msvalue10.ToString().Length > 6) return false; // long 6
			if (mdvalue10.ToString().Length > 6) return false; // long 6
			if (msval10.ToString().Length > 6) return false; // long 6
			if (tjjcode11?.Length > 4) return false; // char 4
			if (msvolume11.ToString().Length > 8) return false; // long 8
			if (mdvolume11.ToString().Length > 8) return false; // long 8
			if (msvol11.ToString().Length > 8) return false; // long 8
			if (msvalue11.ToString().Length > 6) return false; // long 6
			if (mdvalue11.ToString().Length > 6) return false; // long 6
			if (msval11.ToString().Length > 6) return false; // long 6
			if (upcode?.Length > 3) return false; // char 3
			if (tjjcode0?.Length > 4) return false; // char 4
			if (msvolume0.ToString().Length > 8) return false; // long 8
			if (mdvolume0.ToString().Length > 8) return false; // long 8
			if (msvol0.ToString().Length > 8) return false; // long 8
			if (msvalue0.ToString().Length > 6) return false; // long 6
			if (mdvalue0.ToString().Length > 6) return false; // long 6
			if (msval0.ToString().Length > 6) return false; // long 6

			return true;
		}

		public void CopyTo(XRBMTOutBlock block)
		{
			block.tjjtime = this.tjjtime;
			block.tjjcode1 = this.tjjcode1;
			block.msvolume1 = this.msvolume1;
			block.mdvolume1 = this.mdvolume1;
			block.msvol1 = this.msvol1;
			block.msvalue1 = this.msvalue1;
			block.mdvalue1 = this.mdvalue1;
			block.msval1 = this.msval1;
			block.tjjcode2 = this.tjjcode2;
			block.msvolume2 = this.msvolume2;
			block.mdvolume2 = this.mdvolume2;
			block.msvol2 = this.msvol2;
			block.msvalue2 = this.msvalue2;
			block.mdvalue2 = this.mdvalue2;
			block.msval2 = this.msval2;
			block.tjjcode3 = this.tjjcode3;
			block.msvolume3 = this.msvolume3;
			block.mdvolume3 = this.mdvolume3;
			block.msvol3 = this.msvol3;
			block.msvalue3 = this.msvalue3;
			block.mdvalue3 = this.mdvalue3;
			block.msval3 = this.msval3;
			block.tjjcode4 = this.tjjcode4;
			block.msvolume4 = this.msvolume4;
			block.mdvolume4 = this.mdvolume4;
			block.msvol4 = this.msvol4;
			block.msvalue4 = this.msvalue4;
			block.mdvalue4 = this.mdvalue4;
			block.msval4 = this.msval4;
			block.tjjcode5 = this.tjjcode5;
			block.msvolume5 = this.msvolume5;
			block.mdvolume5 = this.mdvolume5;
			block.msvol5 = this.msvol5;
			block.msvalue5 = this.msvalue5;
			block.mdvalue5 = this.mdvalue5;
			block.msval5 = this.msval5;
			block.tjjcode6 = this.tjjcode6;
			block.msvolume6 = this.msvolume6;
			block.mdvolume6 = this.mdvolume6;
			block.msvol6 = this.msvol6;
			block.msvalue6 = this.msvalue6;
			block.mdvalue6 = this.mdvalue6;
			block.msval6 = this.msval6;
			block.tjjcode7 = this.tjjcode7;
			block.msvolume7 = this.msvolume7;
			block.mdvolume7 = this.mdvolume7;
			block.msvol7 = this.msvol7;
			block.msvalue7 = this.msvalue7;
			block.mdvalue7 = this.mdvalue7;
			block.msval7 = this.msval7;
			block.tjjcode8 = this.tjjcode8;
			block.msvolume8 = this.msvolume8;
			block.mdvolume8 = this.mdvolume8;
			block.msvol8 = this.msvol8;
			block.msvalue8 = this.msvalue8;
			block.mdvalue8 = this.mdvalue8;
			block.msval8 = this.msval8;
			block.tjjcode9 = this.tjjcode9;
			block.msvolume9 = this.msvolume9;
			block.mdvolume9 = this.mdvolume9;
			block.msvol9 = this.msvol9;
			block.msvalue9 = this.msvalue9;
			block.mdvalue9 = this.mdvalue9;
			block.msval9 = this.msval9;
			block.tjjcode10 = this.tjjcode10;
			block.msvolume10 = this.msvolume10;
			block.mdvolume10 = this.mdvolume10;
			block.msvol10 = this.msvol10;
			block.msvalue10 = this.msvalue10;
			block.mdvalue10 = this.mdvalue10;
			block.msval10 = this.msval10;
			block.tjjcode11 = this.tjjcode11;
			block.msvolume11 = this.msvolume11;
			block.mdvolume11 = this.mdvolume11;
			block.msvol11 = this.msvol11;
			block.msvalue11 = this.msvalue11;
			block.mdvalue11 = this.mdvalue11;
			block.msval11 = this.msval11;
			block.upcode = this.upcode;
			block.tjjcode0 = this.tjjcode0;
			block.msvolume0 = this.msvolume0;
			block.mdvolume0 = this.mdvolume0;
			block.msvol0 = this.msvol0;
			block.msvalue0 = this.msvalue0;
			block.mdvalue0 = this.mdvalue0;
			block.msval0 = this.msval0;

		}
	}

	/// <summary>
	/// 시간대별투자자매매추이(BMT)
	/// </summary>
	public partial class XRBMT : XingReal
	{
		/// <summary>
		/// BMT
		/// </summary>
		public const string _typeName = "BMT";
		/// <summary>
		/// 시간대별투자자매매추이(BMT)
		/// </summary>
		public const string _typeDesc = "시간대별투자자매매추이(BMT)";
		/// <summary>
		/// false
		/// </summary>
		public const bool _attr = false;
		/// <summary>
		/// 0
		/// </summary>
		public const int _key = 0;
		/// <summary>
		/// 0
		/// </summary>
		public const int _group = 0;

		/// <summary>
		/// BMT
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 시간대별투자자매매추이(BMT)
		/// </summary>
		public string TypeDesc => _typeDesc;
		/// <summary>
		/// false
		/// </summary>
		public bool Attr => _attr;
		/// <summary>
		/// 0
		/// </summary>
		public int Key => _key;
		/// <summary>
		/// 0
		/// </summary>
		public int Group => _group;

		/// <summary>
		/// 시간대별투자자매매추이(BMT)
		/// </summary>
		public XRBMT() : base("BMT") { }


		public bool SetBlock(XRBMTInBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaReal.SetFieldData(block.GetBlockName(), "upcode", block.upcode); // char 3

			return true;
		}

		public XRBMTOutBlock GetBlock()
		{
			XRBMTOutBlock instance = XRBMTOutBlock.FromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XRBMTOutBlock),

		};

	}

}
