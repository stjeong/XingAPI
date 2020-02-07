using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt2816InBlock : XingBlock
	{
		/// <summary>
		/// t2816InBlock
		/// </summary>
		public const string _blockName = "t2816InBlock";
		/// <summary>
		/// 기본입력
		/// </summary>
		public const string _blockDesc = "기본입력";
		/// <summary>
		/// input
		/// </summary>
		public const string _blockType = "input";
		/// <summary>
		/// false
		/// </summary>
		public const bool _hasOccurs = false;
		/// <summary>
		/// t2816InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t2816InBlock
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// 기본입력
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
		/// Dummy
		/// </summary>
		[XAQueryFieldAttribute("Dummy")]
		public char dummy;

		public static class F
		{
			/// <summary>
			/// Dummy
			/// </summary>
			public const string dummy = "dummy";
		}

		public static string[] AllFields = new string[]
		{
			F.dummy,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["dummy"] = new XAQueryFieldInfo("char", dummy, dummy.ToString(), "Dummy", (decimal)1);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "dummy":
					this.dummy = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public bool VerifyData()
		{
			// dummy char 1

			return true;
		}
	}

	public partial class XQt2816OutBlock1 : XingBlock
	{
		/// <summary>
		/// t2816OutBlock1
		/// </summary>
		public const string _blockName = "t2816OutBlock1";
		/// <summary>
		/// 기본출력1
		/// </summary>
		public const string _blockDesc = "기본출력1";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// false
		/// </summary>
		public const bool _hasOccurs = false;
		/// <summary>
		/// t2816OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t2816OutBlock1
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// 기본출력1
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
		/// 개인투자자코드
		/// </summary>
		[XAQueryFieldAttribute("개인투자자코드")]
		public string tjjcode_08;
		/// <summary>
		/// 개인매수
		/// </summary>
		[XAQueryFieldAttribute("개인매수")]
		public long ms_08;
		/// <summary>
		/// 개인매도
		/// </summary>
		[XAQueryFieldAttribute("개인매도")]
		public long md_08;
		/// <summary>
		/// 개인증감
		/// </summary>
		[XAQueryFieldAttribute("개인증감")]
		public long rate_08;
		/// <summary>
		/// 개인순매수
		/// </summary>
		[XAQueryFieldAttribute("개인순매수")]
		public long svolume_08;
		/// <summary>
		/// 외국인투자자코드
		/// </summary>
		[XAQueryFieldAttribute("외국인투자자코드")]
		public string tjjcode_17;
		/// <summary>
		/// 외국인매수
		/// </summary>
		[XAQueryFieldAttribute("외국인매수")]
		public long ms_17;
		/// <summary>
		/// 외국인매도
		/// </summary>
		[XAQueryFieldAttribute("외국인매도")]
		public long md_17;
		/// <summary>
		/// 외국인증감
		/// </summary>
		[XAQueryFieldAttribute("외국인증감")]
		public long rate_17;
		/// <summary>
		/// 외국인순매수
		/// </summary>
		[XAQueryFieldAttribute("외국인순매수")]
		public long svolume_17;
		/// <summary>
		/// 기관계투자자코드
		/// </summary>
		[XAQueryFieldAttribute("기관계투자자코드")]
		public string tjjcode_18;
		/// <summary>
		/// 기관계매수
		/// </summary>
		[XAQueryFieldAttribute("기관계매수")]
		public long ms_18;
		/// <summary>
		/// 기관계매도
		/// </summary>
		[XAQueryFieldAttribute("기관계매도")]
		public long md_18;
		/// <summary>
		/// 기관계증감
		/// </summary>
		[XAQueryFieldAttribute("기관계증감")]
		public long rate_18;
		/// <summary>
		/// 기관계순매수
		/// </summary>
		[XAQueryFieldAttribute("기관계순매수")]
		public long svolume_18;
		/// <summary>
		/// 증권투자자코드
		/// </summary>
		[XAQueryFieldAttribute("증권투자자코드")]
		public string tjjcode_01;
		/// <summary>
		/// 증권매수
		/// </summary>
		[XAQueryFieldAttribute("증권매수")]
		public long ms_01;
		/// <summary>
		/// 증권매도
		/// </summary>
		[XAQueryFieldAttribute("증권매도")]
		public long md_01;
		/// <summary>
		/// 증권증감
		/// </summary>
		[XAQueryFieldAttribute("증권증감")]
		public long rate_01;
		/// <summary>
		/// 증권순매수
		/// </summary>
		[XAQueryFieldAttribute("증권순매수")]
		public long svolume_01;
		/// <summary>
		/// 투신투자자코드
		/// </summary>
		[XAQueryFieldAttribute("투신투자자코드")]
		public string tjjcode_03;
		/// <summary>
		/// 투신매수
		/// </summary>
		[XAQueryFieldAttribute("투신매수")]
		public long ms_03;
		/// <summary>
		/// 투신매도
		/// </summary>
		[XAQueryFieldAttribute("투신매도")]
		public long md_03;
		/// <summary>
		/// 투신증감
		/// </summary>
		[XAQueryFieldAttribute("투신증감")]
		public long rate_03;
		/// <summary>
		/// 투신순매수
		/// </summary>
		[XAQueryFieldAttribute("투신순매수")]
		public long svolume_03;
		/// <summary>
		/// 은행투자자코드
		/// </summary>
		[XAQueryFieldAttribute("은행투자자코드")]
		public string tjjcode_04;
		/// <summary>
		/// 은행매수
		/// </summary>
		[XAQueryFieldAttribute("은행매수")]
		public long ms_04;
		/// <summary>
		/// 은행매도
		/// </summary>
		[XAQueryFieldAttribute("은행매도")]
		public long md_04;
		/// <summary>
		/// 은행증감
		/// </summary>
		[XAQueryFieldAttribute("은행증감")]
		public long rate_04;
		/// <summary>
		/// 은행순매수
		/// </summary>
		[XAQueryFieldAttribute("은행순매수")]
		public long svolume_04;
		/// <summary>
		/// 보험투자자코드
		/// </summary>
		[XAQueryFieldAttribute("보험투자자코드")]
		public string tjjcode_02;
		/// <summary>
		/// 보험매수
		/// </summary>
		[XAQueryFieldAttribute("보험매수")]
		public long ms_02;
		/// <summary>
		/// 보험매도
		/// </summary>
		[XAQueryFieldAttribute("보험매도")]
		public long md_02;
		/// <summary>
		/// 보험증감
		/// </summary>
		[XAQueryFieldAttribute("보험증감")]
		public long rate_02;
		/// <summary>
		/// 보험순매수
		/// </summary>
		[XAQueryFieldAttribute("보험순매수")]
		public long svolume_02;
		/// <summary>
		/// 종금투자자코드
		/// </summary>
		[XAQueryFieldAttribute("종금투자자코드")]
		public string tjjcode_05;
		/// <summary>
		/// 종금매수
		/// </summary>
		[XAQueryFieldAttribute("종금매수")]
		public long ms_05;
		/// <summary>
		/// 종금매도
		/// </summary>
		[XAQueryFieldAttribute("종금매도")]
		public long md_05;
		/// <summary>
		/// 종금증감
		/// </summary>
		[XAQueryFieldAttribute("종금증감")]
		public long rate_05;
		/// <summary>
		/// 종금순매수
		/// </summary>
		[XAQueryFieldAttribute("종금순매수")]
		public long svolume_05;
		/// <summary>
		/// 기금투자자코드
		/// </summary>
		[XAQueryFieldAttribute("기금투자자코드")]
		public string tjjcode_06;
		/// <summary>
		/// 기금매수
		/// </summary>
		[XAQueryFieldAttribute("기금매수")]
		public long ms_06;
		/// <summary>
		/// 기금매도
		/// </summary>
		[XAQueryFieldAttribute("기금매도")]
		public long md_06;
		/// <summary>
		/// 기금증감
		/// </summary>
		[XAQueryFieldAttribute("기금증감")]
		public long rate_06;
		/// <summary>
		/// 기금순매수
		/// </summary>
		[XAQueryFieldAttribute("기금순매수")]
		public long svolume_06;
		/// <summary>
		/// 국가투자코드
		/// </summary>
		[XAQueryFieldAttribute("국가투자코드")]
		public string tjjcode_11;
		/// <summary>
		/// 국가매수
		/// </summary>
		[XAQueryFieldAttribute("국가매수")]
		public long ms_11;
		/// <summary>
		/// 국가매도
		/// </summary>
		[XAQueryFieldAttribute("국가매도")]
		public long md_11;
		/// <summary>
		/// 국가증감
		/// </summary>
		[XAQueryFieldAttribute("국가증감")]
		public long rate_11;
		/// <summary>
		/// 국가순매수
		/// </summary>
		[XAQueryFieldAttribute("국가순매수")]
		public long svolume_11;
		/// <summary>
		/// 기타투자자코드
		/// </summary>
		[XAQueryFieldAttribute("기타투자자코드")]
		public string tjjcode_07;
		/// <summary>
		/// 기타매수
		/// </summary>
		[XAQueryFieldAttribute("기타매수")]
		public long ms_07;
		/// <summary>
		/// 기타매도
		/// </summary>
		[XAQueryFieldAttribute("기타매도")]
		public long md_07;
		/// <summary>
		/// 기타증감
		/// </summary>
		[XAQueryFieldAttribute("기타증감")]
		public long rate_07;
		/// <summary>
		/// 기타순매수
		/// </summary>
		[XAQueryFieldAttribute("기타순매수")]
		public long svolume_07;
		/// <summary>
		/// 사모펀드투자자코드
		/// </summary>
		[XAQueryFieldAttribute("사모펀드투자자코드")]
		public string tjjcode_00;
		/// <summary>
		/// 사모펀드매수
		/// </summary>
		[XAQueryFieldAttribute("사모펀드매수")]
		public long ms_00;
		/// <summary>
		/// 사모펀드매도
		/// </summary>
		[XAQueryFieldAttribute("사모펀드매도")]
		public long md_00;
		/// <summary>
		/// 사모펀드증감
		/// </summary>
		[XAQueryFieldAttribute("사모펀드증감")]
		public long rate_00;
		/// <summary>
		/// 사모펀드순매수
		/// </summary>
		[XAQueryFieldAttribute("사모펀드순매수")]
		public long svolume_00;

		public static class F
		{
			/// <summary>
			/// 개인투자자코드
			/// </summary>
			public const string tjjcode_08 = "tjjcode_08";
			/// <summary>
			/// 개인매수
			/// </summary>
			public const string ms_08 = "ms_08";
			/// <summary>
			/// 개인매도
			/// </summary>
			public const string md_08 = "md_08";
			/// <summary>
			/// 개인증감
			/// </summary>
			public const string rate_08 = "rate_08";
			/// <summary>
			/// 개인순매수
			/// </summary>
			public const string svolume_08 = "svolume_08";
			/// <summary>
			/// 외국인투자자코드
			/// </summary>
			public const string tjjcode_17 = "tjjcode_17";
			/// <summary>
			/// 외국인매수
			/// </summary>
			public const string ms_17 = "ms_17";
			/// <summary>
			/// 외국인매도
			/// </summary>
			public const string md_17 = "md_17";
			/// <summary>
			/// 외국인증감
			/// </summary>
			public const string rate_17 = "rate_17";
			/// <summary>
			/// 외국인순매수
			/// </summary>
			public const string svolume_17 = "svolume_17";
			/// <summary>
			/// 기관계투자자코드
			/// </summary>
			public const string tjjcode_18 = "tjjcode_18";
			/// <summary>
			/// 기관계매수
			/// </summary>
			public const string ms_18 = "ms_18";
			/// <summary>
			/// 기관계매도
			/// </summary>
			public const string md_18 = "md_18";
			/// <summary>
			/// 기관계증감
			/// </summary>
			public const string rate_18 = "rate_18";
			/// <summary>
			/// 기관계순매수
			/// </summary>
			public const string svolume_18 = "svolume_18";
			/// <summary>
			/// 증권투자자코드
			/// </summary>
			public const string tjjcode_01 = "tjjcode_01";
			/// <summary>
			/// 증권매수
			/// </summary>
			public const string ms_01 = "ms_01";
			/// <summary>
			/// 증권매도
			/// </summary>
			public const string md_01 = "md_01";
			/// <summary>
			/// 증권증감
			/// </summary>
			public const string rate_01 = "rate_01";
			/// <summary>
			/// 증권순매수
			/// </summary>
			public const string svolume_01 = "svolume_01";
			/// <summary>
			/// 투신투자자코드
			/// </summary>
			public const string tjjcode_03 = "tjjcode_03";
			/// <summary>
			/// 투신매수
			/// </summary>
			public const string ms_03 = "ms_03";
			/// <summary>
			/// 투신매도
			/// </summary>
			public const string md_03 = "md_03";
			/// <summary>
			/// 투신증감
			/// </summary>
			public const string rate_03 = "rate_03";
			/// <summary>
			/// 투신순매수
			/// </summary>
			public const string svolume_03 = "svolume_03";
			/// <summary>
			/// 은행투자자코드
			/// </summary>
			public const string tjjcode_04 = "tjjcode_04";
			/// <summary>
			/// 은행매수
			/// </summary>
			public const string ms_04 = "ms_04";
			/// <summary>
			/// 은행매도
			/// </summary>
			public const string md_04 = "md_04";
			/// <summary>
			/// 은행증감
			/// </summary>
			public const string rate_04 = "rate_04";
			/// <summary>
			/// 은행순매수
			/// </summary>
			public const string svolume_04 = "svolume_04";
			/// <summary>
			/// 보험투자자코드
			/// </summary>
			public const string tjjcode_02 = "tjjcode_02";
			/// <summary>
			/// 보험매수
			/// </summary>
			public const string ms_02 = "ms_02";
			/// <summary>
			/// 보험매도
			/// </summary>
			public const string md_02 = "md_02";
			/// <summary>
			/// 보험증감
			/// </summary>
			public const string rate_02 = "rate_02";
			/// <summary>
			/// 보험순매수
			/// </summary>
			public const string svolume_02 = "svolume_02";
			/// <summary>
			/// 종금투자자코드
			/// </summary>
			public const string tjjcode_05 = "tjjcode_05";
			/// <summary>
			/// 종금매수
			/// </summary>
			public const string ms_05 = "ms_05";
			/// <summary>
			/// 종금매도
			/// </summary>
			public const string md_05 = "md_05";
			/// <summary>
			/// 종금증감
			/// </summary>
			public const string rate_05 = "rate_05";
			/// <summary>
			/// 종금순매수
			/// </summary>
			public const string svolume_05 = "svolume_05";
			/// <summary>
			/// 기금투자자코드
			/// </summary>
			public const string tjjcode_06 = "tjjcode_06";
			/// <summary>
			/// 기금매수
			/// </summary>
			public const string ms_06 = "ms_06";
			/// <summary>
			/// 기금매도
			/// </summary>
			public const string md_06 = "md_06";
			/// <summary>
			/// 기금증감
			/// </summary>
			public const string rate_06 = "rate_06";
			/// <summary>
			/// 기금순매수
			/// </summary>
			public const string svolume_06 = "svolume_06";
			/// <summary>
			/// 국가투자코드
			/// </summary>
			public const string tjjcode_11 = "tjjcode_11";
			/// <summary>
			/// 국가매수
			/// </summary>
			public const string ms_11 = "ms_11";
			/// <summary>
			/// 국가매도
			/// </summary>
			public const string md_11 = "md_11";
			/// <summary>
			/// 국가증감
			/// </summary>
			public const string rate_11 = "rate_11";
			/// <summary>
			/// 국가순매수
			/// </summary>
			public const string svolume_11 = "svolume_11";
			/// <summary>
			/// 기타투자자코드
			/// </summary>
			public const string tjjcode_07 = "tjjcode_07";
			/// <summary>
			/// 기타매수
			/// </summary>
			public const string ms_07 = "ms_07";
			/// <summary>
			/// 기타매도
			/// </summary>
			public const string md_07 = "md_07";
			/// <summary>
			/// 기타증감
			/// </summary>
			public const string rate_07 = "rate_07";
			/// <summary>
			/// 기타순매수
			/// </summary>
			public const string svolume_07 = "svolume_07";
			/// <summary>
			/// 사모펀드투자자코드
			/// </summary>
			public const string tjjcode_00 = "tjjcode_00";
			/// <summary>
			/// 사모펀드매수
			/// </summary>
			public const string ms_00 = "ms_00";
			/// <summary>
			/// 사모펀드매도
			/// </summary>
			public const string md_00 = "md_00";
			/// <summary>
			/// 사모펀드증감
			/// </summary>
			public const string rate_00 = "rate_00";
			/// <summary>
			/// 사모펀드순매수
			/// </summary>
			public const string svolume_00 = "svolume_00";
		}

		public static string[] AllFields = new string[]
		{
			F.tjjcode_08,
			F.ms_08,
			F.md_08,
			F.rate_08,
			F.svolume_08,
			F.tjjcode_17,
			F.ms_17,
			F.md_17,
			F.rate_17,
			F.svolume_17,
			F.tjjcode_18,
			F.ms_18,
			F.md_18,
			F.rate_18,
			F.svolume_18,
			F.tjjcode_01,
			F.ms_01,
			F.md_01,
			F.rate_01,
			F.svolume_01,
			F.tjjcode_03,
			F.ms_03,
			F.md_03,
			F.rate_03,
			F.svolume_03,
			F.tjjcode_04,
			F.ms_04,
			F.md_04,
			F.rate_04,
			F.svolume_04,
			F.tjjcode_02,
			F.ms_02,
			F.md_02,
			F.rate_02,
			F.svolume_02,
			F.tjjcode_05,
			F.ms_05,
			F.md_05,
			F.rate_05,
			F.svolume_05,
			F.tjjcode_06,
			F.ms_06,
			F.md_06,
			F.rate_06,
			F.svolume_06,
			F.tjjcode_11,
			F.ms_11,
			F.md_11,
			F.rate_11,
			F.svolume_11,
			F.tjjcode_07,
			F.ms_07,
			F.md_07,
			F.rate_07,
			F.svolume_07,
			F.tjjcode_00,
			F.ms_00,
			F.md_00,
			F.rate_00,
			F.svolume_00,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["tjjcode_08"] = new XAQueryFieldInfo("char", tjjcode_08, tjjcode_08, "개인투자자코드", (decimal)4);
			dict["ms_08"] = new XAQueryFieldInfo("long", ms_08, ms_08.ToString("d12"), "개인매수", (decimal)12);
			dict["md_08"] = new XAQueryFieldInfo("long", md_08, md_08.ToString("d12"), "개인매도", (decimal)12);
			dict["rate_08"] = new XAQueryFieldInfo("long", rate_08, rate_08.ToString("d12"), "개인증감", (decimal)12);
			dict["svolume_08"] = new XAQueryFieldInfo("long", svolume_08, svolume_08.ToString("d12"), "개인순매수", (decimal)12);
			dict["tjjcode_17"] = new XAQueryFieldInfo("char", tjjcode_17, tjjcode_17, "외국인투자자코드", (decimal)4);
			dict["ms_17"] = new XAQueryFieldInfo("long", ms_17, ms_17.ToString("d12"), "외국인매수", (decimal)12);
			dict["md_17"] = new XAQueryFieldInfo("long", md_17, md_17.ToString("d12"), "외국인매도", (decimal)12);
			dict["rate_17"] = new XAQueryFieldInfo("long", rate_17, rate_17.ToString("d12"), "외국인증감", (decimal)12);
			dict["svolume_17"] = new XAQueryFieldInfo("long", svolume_17, svolume_17.ToString("d12"), "외국인순매수", (decimal)12);
			dict["tjjcode_18"] = new XAQueryFieldInfo("char", tjjcode_18, tjjcode_18, "기관계투자자코드", (decimal)4);
			dict["ms_18"] = new XAQueryFieldInfo("long", ms_18, ms_18.ToString("d12"), "기관계매수", (decimal)12);
			dict["md_18"] = new XAQueryFieldInfo("long", md_18, md_18.ToString("d12"), "기관계매도", (decimal)12);
			dict["rate_18"] = new XAQueryFieldInfo("long", rate_18, rate_18.ToString("d12"), "기관계증감", (decimal)12);
			dict["svolume_18"] = new XAQueryFieldInfo("long", svolume_18, svolume_18.ToString("d12"), "기관계순매수", (decimal)12);
			dict["tjjcode_01"] = new XAQueryFieldInfo("char", tjjcode_01, tjjcode_01, "증권투자자코드", (decimal)4);
			dict["ms_01"] = new XAQueryFieldInfo("long", ms_01, ms_01.ToString("d12"), "증권매수", (decimal)12);
			dict["md_01"] = new XAQueryFieldInfo("long", md_01, md_01.ToString("d12"), "증권매도", (decimal)12);
			dict["rate_01"] = new XAQueryFieldInfo("long", rate_01, rate_01.ToString("d12"), "증권증감", (decimal)12);
			dict["svolume_01"] = new XAQueryFieldInfo("long", svolume_01, svolume_01.ToString("d12"), "증권순매수", (decimal)12);
			dict["tjjcode_03"] = new XAQueryFieldInfo("char", tjjcode_03, tjjcode_03, "투신투자자코드", (decimal)4);
			dict["ms_03"] = new XAQueryFieldInfo("long", ms_03, ms_03.ToString("d12"), "투신매수", (decimal)12);
			dict["md_03"] = new XAQueryFieldInfo("long", md_03, md_03.ToString("d12"), "투신매도", (decimal)12);
			dict["rate_03"] = new XAQueryFieldInfo("long", rate_03, rate_03.ToString("d12"), "투신증감", (decimal)12);
			dict["svolume_03"] = new XAQueryFieldInfo("long", svolume_03, svolume_03.ToString("d12"), "투신순매수", (decimal)12);
			dict["tjjcode_04"] = new XAQueryFieldInfo("char", tjjcode_04, tjjcode_04, "은행투자자코드", (decimal)4);
			dict["ms_04"] = new XAQueryFieldInfo("long", ms_04, ms_04.ToString("d12"), "은행매수", (decimal)12);
			dict["md_04"] = new XAQueryFieldInfo("long", md_04, md_04.ToString("d12"), "은행매도", (decimal)12);
			dict["rate_04"] = new XAQueryFieldInfo("long", rate_04, rate_04.ToString("d12"), "은행증감", (decimal)12);
			dict["svolume_04"] = new XAQueryFieldInfo("long", svolume_04, svolume_04.ToString("d12"), "은행순매수", (decimal)12);
			dict["tjjcode_02"] = new XAQueryFieldInfo("char", tjjcode_02, tjjcode_02, "보험투자자코드", (decimal)4);
			dict["ms_02"] = new XAQueryFieldInfo("long", ms_02, ms_02.ToString("d12"), "보험매수", (decimal)12);
			dict["md_02"] = new XAQueryFieldInfo("long", md_02, md_02.ToString("d12"), "보험매도", (decimal)12);
			dict["rate_02"] = new XAQueryFieldInfo("long", rate_02, rate_02.ToString("d12"), "보험증감", (decimal)12);
			dict["svolume_02"] = new XAQueryFieldInfo("long", svolume_02, svolume_02.ToString("d12"), "보험순매수", (decimal)12);
			dict["tjjcode_05"] = new XAQueryFieldInfo("char", tjjcode_05, tjjcode_05, "종금투자자코드", (decimal)4);
			dict["ms_05"] = new XAQueryFieldInfo("long", ms_05, ms_05.ToString("d12"), "종금매수", (decimal)12);
			dict["md_05"] = new XAQueryFieldInfo("long", md_05, md_05.ToString("d12"), "종금매도", (decimal)12);
			dict["rate_05"] = new XAQueryFieldInfo("long", rate_05, rate_05.ToString("d12"), "종금증감", (decimal)12);
			dict["svolume_05"] = new XAQueryFieldInfo("long", svolume_05, svolume_05.ToString("d12"), "종금순매수", (decimal)12);
			dict["tjjcode_06"] = new XAQueryFieldInfo("char", tjjcode_06, tjjcode_06, "기금투자자코드", (decimal)4);
			dict["ms_06"] = new XAQueryFieldInfo("long", ms_06, ms_06.ToString("d12"), "기금매수", (decimal)12);
			dict["md_06"] = new XAQueryFieldInfo("long", md_06, md_06.ToString("d12"), "기금매도", (decimal)12);
			dict["rate_06"] = new XAQueryFieldInfo("long", rate_06, rate_06.ToString("d12"), "기금증감", (decimal)12);
			dict["svolume_06"] = new XAQueryFieldInfo("long", svolume_06, svolume_06.ToString("d12"), "기금순매수", (decimal)12);
			dict["tjjcode_11"] = new XAQueryFieldInfo("char", tjjcode_11, tjjcode_11, "국가투자코드", (decimal)4);
			dict["ms_11"] = new XAQueryFieldInfo("long", ms_11, ms_11.ToString("d12"), "국가매수", (decimal)12);
			dict["md_11"] = new XAQueryFieldInfo("long", md_11, md_11.ToString("d12"), "국가매도", (decimal)12);
			dict["rate_11"] = new XAQueryFieldInfo("long", rate_11, rate_11.ToString("d12"), "국가증감", (decimal)12);
			dict["svolume_11"] = new XAQueryFieldInfo("long", svolume_11, svolume_11.ToString("d12"), "국가순매수", (decimal)12);
			dict["tjjcode_07"] = new XAQueryFieldInfo("char", tjjcode_07, tjjcode_07, "기타투자자코드", (decimal)4);
			dict["ms_07"] = new XAQueryFieldInfo("long", ms_07, ms_07.ToString("d12"), "기타매수", (decimal)12);
			dict["md_07"] = new XAQueryFieldInfo("long", md_07, md_07.ToString("d12"), "기타매도", (decimal)12);
			dict["rate_07"] = new XAQueryFieldInfo("long", rate_07, rate_07.ToString("d12"), "기타증감", (decimal)12);
			dict["svolume_07"] = new XAQueryFieldInfo("long", svolume_07, svolume_07.ToString("d12"), "기타순매수", (decimal)12);
			dict["tjjcode_00"] = new XAQueryFieldInfo("char", tjjcode_00, tjjcode_00, "사모펀드투자자코드", (decimal)4);
			dict["ms_00"] = new XAQueryFieldInfo("long", ms_00, ms_00.ToString("d12"), "사모펀드매수", (decimal)12);
			dict["md_00"] = new XAQueryFieldInfo("long", md_00, md_00.ToString("d12"), "사모펀드매도", (decimal)12);
			dict["rate_00"] = new XAQueryFieldInfo("long", rate_00, rate_00.ToString("d12"), "사모펀드증감", (decimal)12);
			dict["svolume_00"] = new XAQueryFieldInfo("long", svolume_00, svolume_00.ToString("d12"), "사모펀드순매수", (decimal)12);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "tjjcode_08":
					this.tjjcode_08 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ms_08":
					this.ms_08 = fieldInfo.FieldValue.ParseLong("ms_08");
				break;

				case "md_08":
					this.md_08 = fieldInfo.FieldValue.ParseLong("md_08");
				break;

				case "rate_08":
					this.rate_08 = fieldInfo.FieldValue.ParseLong("rate_08");
				break;

				case "svolume_08":
					this.svolume_08 = fieldInfo.FieldValue.ParseLong("svolume_08");
				break;

				case "tjjcode_17":
					this.tjjcode_17 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ms_17":
					this.ms_17 = fieldInfo.FieldValue.ParseLong("ms_17");
				break;

				case "md_17":
					this.md_17 = fieldInfo.FieldValue.ParseLong("md_17");
				break;

				case "rate_17":
					this.rate_17 = fieldInfo.FieldValue.ParseLong("rate_17");
				break;

				case "svolume_17":
					this.svolume_17 = fieldInfo.FieldValue.ParseLong("svolume_17");
				break;

				case "tjjcode_18":
					this.tjjcode_18 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ms_18":
					this.ms_18 = fieldInfo.FieldValue.ParseLong("ms_18");
				break;

				case "md_18":
					this.md_18 = fieldInfo.FieldValue.ParseLong("md_18");
				break;

				case "rate_18":
					this.rate_18 = fieldInfo.FieldValue.ParseLong("rate_18");
				break;

				case "svolume_18":
					this.svolume_18 = fieldInfo.FieldValue.ParseLong("svolume_18");
				break;

				case "tjjcode_01":
					this.tjjcode_01 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ms_01":
					this.ms_01 = fieldInfo.FieldValue.ParseLong("ms_01");
				break;

				case "md_01":
					this.md_01 = fieldInfo.FieldValue.ParseLong("md_01");
				break;

				case "rate_01":
					this.rate_01 = fieldInfo.FieldValue.ParseLong("rate_01");
				break;

				case "svolume_01":
					this.svolume_01 = fieldInfo.FieldValue.ParseLong("svolume_01");
				break;

				case "tjjcode_03":
					this.tjjcode_03 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ms_03":
					this.ms_03 = fieldInfo.FieldValue.ParseLong("ms_03");
				break;

				case "md_03":
					this.md_03 = fieldInfo.FieldValue.ParseLong("md_03");
				break;

				case "rate_03":
					this.rate_03 = fieldInfo.FieldValue.ParseLong("rate_03");
				break;

				case "svolume_03":
					this.svolume_03 = fieldInfo.FieldValue.ParseLong("svolume_03");
				break;

				case "tjjcode_04":
					this.tjjcode_04 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ms_04":
					this.ms_04 = fieldInfo.FieldValue.ParseLong("ms_04");
				break;

				case "md_04":
					this.md_04 = fieldInfo.FieldValue.ParseLong("md_04");
				break;

				case "rate_04":
					this.rate_04 = fieldInfo.FieldValue.ParseLong("rate_04");
				break;

				case "svolume_04":
					this.svolume_04 = fieldInfo.FieldValue.ParseLong("svolume_04");
				break;

				case "tjjcode_02":
					this.tjjcode_02 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ms_02":
					this.ms_02 = fieldInfo.FieldValue.ParseLong("ms_02");
				break;

				case "md_02":
					this.md_02 = fieldInfo.FieldValue.ParseLong("md_02");
				break;

				case "rate_02":
					this.rate_02 = fieldInfo.FieldValue.ParseLong("rate_02");
				break;

				case "svolume_02":
					this.svolume_02 = fieldInfo.FieldValue.ParseLong("svolume_02");
				break;

				case "tjjcode_05":
					this.tjjcode_05 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ms_05":
					this.ms_05 = fieldInfo.FieldValue.ParseLong("ms_05");
				break;

				case "md_05":
					this.md_05 = fieldInfo.FieldValue.ParseLong("md_05");
				break;

				case "rate_05":
					this.rate_05 = fieldInfo.FieldValue.ParseLong("rate_05");
				break;

				case "svolume_05":
					this.svolume_05 = fieldInfo.FieldValue.ParseLong("svolume_05");
				break;

				case "tjjcode_06":
					this.tjjcode_06 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ms_06":
					this.ms_06 = fieldInfo.FieldValue.ParseLong("ms_06");
				break;

				case "md_06":
					this.md_06 = fieldInfo.FieldValue.ParseLong("md_06");
				break;

				case "rate_06":
					this.rate_06 = fieldInfo.FieldValue.ParseLong("rate_06");
				break;

				case "svolume_06":
					this.svolume_06 = fieldInfo.FieldValue.ParseLong("svolume_06");
				break;

				case "tjjcode_11":
					this.tjjcode_11 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ms_11":
					this.ms_11 = fieldInfo.FieldValue.ParseLong("ms_11");
				break;

				case "md_11":
					this.md_11 = fieldInfo.FieldValue.ParseLong("md_11");
				break;

				case "rate_11":
					this.rate_11 = fieldInfo.FieldValue.ParseLong("rate_11");
				break;

				case "svolume_11":
					this.svolume_11 = fieldInfo.FieldValue.ParseLong("svolume_11");
				break;

				case "tjjcode_07":
					this.tjjcode_07 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ms_07":
					this.ms_07 = fieldInfo.FieldValue.ParseLong("ms_07");
				break;

				case "md_07":
					this.md_07 = fieldInfo.FieldValue.ParseLong("md_07");
				break;

				case "rate_07":
					this.rate_07 = fieldInfo.FieldValue.ParseLong("rate_07");
				break;

				case "svolume_07":
					this.svolume_07 = fieldInfo.FieldValue.ParseLong("svolume_07");
				break;

				case "tjjcode_00":
					this.tjjcode_00 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ms_00":
					this.ms_00 = fieldInfo.FieldValue.ParseLong("ms_00");
				break;

				case "md_00":
					this.md_00 = fieldInfo.FieldValue.ParseLong("md_00");
				break;

				case "rate_00":
					this.rate_00 = fieldInfo.FieldValue.ParseLong("rate_00");
				break;

				case "svolume_00":
					this.svolume_00 = fieldInfo.FieldValue.ParseLong("svolume_00");
				break;


			}
		}

		public static XQt2816OutBlock1 FromQuery(XQt2816 query)
		{
			XQt2816OutBlock1 block = new XQt2816OutBlock1();
			block.IsValidData = true;
			block.InvalidReason = "";
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				block.IsValidData = false;
				block.InvalidReason = query.ReceiveMessage;
				return block;
			}
			try
			{
				block.tjjcode_08 = query.GetFieldData(block.GetBlockName(), "tjjcode_08", 0).TrimEnd('?'); // char 4
				block.ms_08 = query.GetFieldData(block.GetBlockName(), "ms_08", 0).ParseLong("ms_08"); // long 12
				block.md_08 = query.GetFieldData(block.GetBlockName(), "md_08", 0).ParseLong("md_08"); // long 12
				block.rate_08 = query.GetFieldData(block.GetBlockName(), "rate_08", 0).ParseLong("rate_08"); // long 12
				block.svolume_08 = query.GetFieldData(block.GetBlockName(), "svolume_08", 0).ParseLong("svolume_08"); // long 12
				block.tjjcode_17 = query.GetFieldData(block.GetBlockName(), "tjjcode_17", 0).TrimEnd('?'); // char 4
				block.ms_17 = query.GetFieldData(block.GetBlockName(), "ms_17", 0).ParseLong("ms_17"); // long 12
				block.md_17 = query.GetFieldData(block.GetBlockName(), "md_17", 0).ParseLong("md_17"); // long 12
				block.rate_17 = query.GetFieldData(block.GetBlockName(), "rate_17", 0).ParseLong("rate_17"); // long 12
				block.svolume_17 = query.GetFieldData(block.GetBlockName(), "svolume_17", 0).ParseLong("svolume_17"); // long 12
				block.tjjcode_18 = query.GetFieldData(block.GetBlockName(), "tjjcode_18", 0).TrimEnd('?'); // char 4
				block.ms_18 = query.GetFieldData(block.GetBlockName(), "ms_18", 0).ParseLong("ms_18"); // long 12
				block.md_18 = query.GetFieldData(block.GetBlockName(), "md_18", 0).ParseLong("md_18"); // long 12
				block.rate_18 = query.GetFieldData(block.GetBlockName(), "rate_18", 0).ParseLong("rate_18"); // long 12
				block.svolume_18 = query.GetFieldData(block.GetBlockName(), "svolume_18", 0).ParseLong("svolume_18"); // long 12
				block.tjjcode_01 = query.GetFieldData(block.GetBlockName(), "tjjcode_01", 0).TrimEnd('?'); // char 4
				block.ms_01 = query.GetFieldData(block.GetBlockName(), "ms_01", 0).ParseLong("ms_01"); // long 12
				block.md_01 = query.GetFieldData(block.GetBlockName(), "md_01", 0).ParseLong("md_01"); // long 12
				block.rate_01 = query.GetFieldData(block.GetBlockName(), "rate_01", 0).ParseLong("rate_01"); // long 12
				block.svolume_01 = query.GetFieldData(block.GetBlockName(), "svolume_01", 0).ParseLong("svolume_01"); // long 12
				block.tjjcode_03 = query.GetFieldData(block.GetBlockName(), "tjjcode_03", 0).TrimEnd('?'); // char 4
				block.ms_03 = query.GetFieldData(block.GetBlockName(), "ms_03", 0).ParseLong("ms_03"); // long 12
				block.md_03 = query.GetFieldData(block.GetBlockName(), "md_03", 0).ParseLong("md_03"); // long 12
				block.rate_03 = query.GetFieldData(block.GetBlockName(), "rate_03", 0).ParseLong("rate_03"); // long 12
				block.svolume_03 = query.GetFieldData(block.GetBlockName(), "svolume_03", 0).ParseLong("svolume_03"); // long 12
				block.tjjcode_04 = query.GetFieldData(block.GetBlockName(), "tjjcode_04", 0).TrimEnd('?'); // char 4
				block.ms_04 = query.GetFieldData(block.GetBlockName(), "ms_04", 0).ParseLong("ms_04"); // long 12
				block.md_04 = query.GetFieldData(block.GetBlockName(), "md_04", 0).ParseLong("md_04"); // long 12
				block.rate_04 = query.GetFieldData(block.GetBlockName(), "rate_04", 0).ParseLong("rate_04"); // long 12
				block.svolume_04 = query.GetFieldData(block.GetBlockName(), "svolume_04", 0).ParseLong("svolume_04"); // long 12
				block.tjjcode_02 = query.GetFieldData(block.GetBlockName(), "tjjcode_02", 0).TrimEnd('?'); // char 4
				block.ms_02 = query.GetFieldData(block.GetBlockName(), "ms_02", 0).ParseLong("ms_02"); // long 12
				block.md_02 = query.GetFieldData(block.GetBlockName(), "md_02", 0).ParseLong("md_02"); // long 12
				block.rate_02 = query.GetFieldData(block.GetBlockName(), "rate_02", 0).ParseLong("rate_02"); // long 12
				block.svolume_02 = query.GetFieldData(block.GetBlockName(), "svolume_02", 0).ParseLong("svolume_02"); // long 12
				block.tjjcode_05 = query.GetFieldData(block.GetBlockName(), "tjjcode_05", 0).TrimEnd('?'); // char 4
				block.ms_05 = query.GetFieldData(block.GetBlockName(), "ms_05", 0).ParseLong("ms_05"); // long 12
				block.md_05 = query.GetFieldData(block.GetBlockName(), "md_05", 0).ParseLong("md_05"); // long 12
				block.rate_05 = query.GetFieldData(block.GetBlockName(), "rate_05", 0).ParseLong("rate_05"); // long 12
				block.svolume_05 = query.GetFieldData(block.GetBlockName(), "svolume_05", 0).ParseLong("svolume_05"); // long 12
				block.tjjcode_06 = query.GetFieldData(block.GetBlockName(), "tjjcode_06", 0).TrimEnd('?'); // char 4
				block.ms_06 = query.GetFieldData(block.GetBlockName(), "ms_06", 0).ParseLong("ms_06"); // long 12
				block.md_06 = query.GetFieldData(block.GetBlockName(), "md_06", 0).ParseLong("md_06"); // long 12
				block.rate_06 = query.GetFieldData(block.GetBlockName(), "rate_06", 0).ParseLong("rate_06"); // long 12
				block.svolume_06 = query.GetFieldData(block.GetBlockName(), "svolume_06", 0).ParseLong("svolume_06"); // long 12
				block.tjjcode_11 = query.GetFieldData(block.GetBlockName(), "tjjcode_11", 0).TrimEnd('?'); // char 4
				block.ms_11 = query.GetFieldData(block.GetBlockName(), "ms_11", 0).ParseLong("ms_11"); // long 12
				block.md_11 = query.GetFieldData(block.GetBlockName(), "md_11", 0).ParseLong("md_11"); // long 12
				block.rate_11 = query.GetFieldData(block.GetBlockName(), "rate_11", 0).ParseLong("rate_11"); // long 12
				block.svolume_11 = query.GetFieldData(block.GetBlockName(), "svolume_11", 0).ParseLong("svolume_11"); // long 12
				block.tjjcode_07 = query.GetFieldData(block.GetBlockName(), "tjjcode_07", 0).TrimEnd('?'); // char 4
				block.ms_07 = query.GetFieldData(block.GetBlockName(), "ms_07", 0).ParseLong("ms_07"); // long 12
				block.md_07 = query.GetFieldData(block.GetBlockName(), "md_07", 0).ParseLong("md_07"); // long 12
				block.rate_07 = query.GetFieldData(block.GetBlockName(), "rate_07", 0).ParseLong("rate_07"); // long 12
				block.svolume_07 = query.GetFieldData(block.GetBlockName(), "svolume_07", 0).ParseLong("svolume_07"); // long 12
				block.tjjcode_00 = query.GetFieldData(block.GetBlockName(), "tjjcode_00", 0).TrimEnd('?'); // char 4
				block.ms_00 = query.GetFieldData(block.GetBlockName(), "ms_00", 0).ParseLong("ms_00"); // long 12
				block.md_00 = query.GetFieldData(block.GetBlockName(), "md_00", 0).ParseLong("md_00"); // long 12
				block.rate_00 = query.GetFieldData(block.GetBlockName(), "rate_00", 0).ParseLong("rate_00"); // long 12
				block.svolume_00 = query.GetFieldData(block.GetBlockName(), "svolume_00", 0).ParseLong("svolume_00"); // long 12

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (tjjcode_08?.Length > 4) return false; // char 4
			if (ms_08.ToString().Length > 12) return false; // long 12
			if (md_08.ToString().Length > 12) return false; // long 12
			if (rate_08.ToString().Length > 12) return false; // long 12
			if (svolume_08.ToString().Length > 12) return false; // long 12
			if (tjjcode_17?.Length > 4) return false; // char 4
			if (ms_17.ToString().Length > 12) return false; // long 12
			if (md_17.ToString().Length > 12) return false; // long 12
			if (rate_17.ToString().Length > 12) return false; // long 12
			if (svolume_17.ToString().Length > 12) return false; // long 12
			if (tjjcode_18?.Length > 4) return false; // char 4
			if (ms_18.ToString().Length > 12) return false; // long 12
			if (md_18.ToString().Length > 12) return false; // long 12
			if (rate_18.ToString().Length > 12) return false; // long 12
			if (svolume_18.ToString().Length > 12) return false; // long 12
			if (tjjcode_01?.Length > 4) return false; // char 4
			if (ms_01.ToString().Length > 12) return false; // long 12
			if (md_01.ToString().Length > 12) return false; // long 12
			if (rate_01.ToString().Length > 12) return false; // long 12
			if (svolume_01.ToString().Length > 12) return false; // long 12
			if (tjjcode_03?.Length > 4) return false; // char 4
			if (ms_03.ToString().Length > 12) return false; // long 12
			if (md_03.ToString().Length > 12) return false; // long 12
			if (rate_03.ToString().Length > 12) return false; // long 12
			if (svolume_03.ToString().Length > 12) return false; // long 12
			if (tjjcode_04?.Length > 4) return false; // char 4
			if (ms_04.ToString().Length > 12) return false; // long 12
			if (md_04.ToString().Length > 12) return false; // long 12
			if (rate_04.ToString().Length > 12) return false; // long 12
			if (svolume_04.ToString().Length > 12) return false; // long 12
			if (tjjcode_02?.Length > 4) return false; // char 4
			if (ms_02.ToString().Length > 12) return false; // long 12
			if (md_02.ToString().Length > 12) return false; // long 12
			if (rate_02.ToString().Length > 12) return false; // long 12
			if (svolume_02.ToString().Length > 12) return false; // long 12
			if (tjjcode_05?.Length > 4) return false; // char 4
			if (ms_05.ToString().Length > 12) return false; // long 12
			if (md_05.ToString().Length > 12) return false; // long 12
			if (rate_05.ToString().Length > 12) return false; // long 12
			if (svolume_05.ToString().Length > 12) return false; // long 12
			if (tjjcode_06?.Length > 4) return false; // char 4
			if (ms_06.ToString().Length > 12) return false; // long 12
			if (md_06.ToString().Length > 12) return false; // long 12
			if (rate_06.ToString().Length > 12) return false; // long 12
			if (svolume_06.ToString().Length > 12) return false; // long 12
			if (tjjcode_11?.Length > 4) return false; // char 4
			if (ms_11.ToString().Length > 12) return false; // long 12
			if (md_11.ToString().Length > 12) return false; // long 12
			if (rate_11.ToString().Length > 12) return false; // long 12
			if (svolume_11.ToString().Length > 12) return false; // long 12
			if (tjjcode_07?.Length > 4) return false; // char 4
			if (ms_07.ToString().Length > 12) return false; // long 12
			if (md_07.ToString().Length > 12) return false; // long 12
			if (rate_07.ToString().Length > 12) return false; // long 12
			if (svolume_07.ToString().Length > 12) return false; // long 12
			if (tjjcode_00?.Length > 4) return false; // char 4
			if (ms_00.ToString().Length > 12) return false; // long 12
			if (md_00.ToString().Length > 12) return false; // long 12
			if (rate_00.ToString().Length > 12) return false; // long 12
			if (svolume_00.ToString().Length > 12) return false; // long 12

			return true;
		}
	}

	public partial class XQt2816OutBlock2 : XingBlock
	{
		/// <summary>
		/// t2816OutBlock2
		/// </summary>
		public const string _blockName = "t2816OutBlock2";
		/// <summary>
		/// 기본출력2
		/// </summary>
		public const string _blockDesc = "기본출력2";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// false
		/// </summary>
		public const bool _hasOccurs = false;
		/// <summary>
		/// t2816OutBlock2
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t2816OutBlock2
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// 기본출력2
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
		/// 개인투자자코드
		/// </summary>
		[XAQueryFieldAttribute("개인투자자코드")]
		public string tjjcode_08;
		/// <summary>
		/// 개인매수
		/// </summary>
		[XAQueryFieldAttribute("개인매수")]
		public long ms_08;
		/// <summary>
		/// 개인매도
		/// </summary>
		[XAQueryFieldAttribute("개인매도")]
		public long md_08;
		/// <summary>
		/// 개인증감
		/// </summary>
		[XAQueryFieldAttribute("개인증감")]
		public long rate_08;
		/// <summary>
		/// 개인순매수
		/// </summary>
		[XAQueryFieldAttribute("개인순매수")]
		public long svolume_08;
		/// <summary>
		/// 외국인투자자코드
		/// </summary>
		[XAQueryFieldAttribute("외국인투자자코드")]
		public string tjjcode_17;
		/// <summary>
		/// 외국인매수
		/// </summary>
		[XAQueryFieldAttribute("외국인매수")]
		public long ms_17;
		/// <summary>
		/// 외국인매도
		/// </summary>
		[XAQueryFieldAttribute("외국인매도")]
		public long md_17;
		/// <summary>
		/// 외국인증감
		/// </summary>
		[XAQueryFieldAttribute("외국인증감")]
		public long rate_17;
		/// <summary>
		/// 외국인순매수
		/// </summary>
		[XAQueryFieldAttribute("외국인순매수")]
		public long svolume_17;
		/// <summary>
		/// 기관계투자자코드
		/// </summary>
		[XAQueryFieldAttribute("기관계투자자코드")]
		public string tjjcode_18;
		/// <summary>
		/// 기관계매수
		/// </summary>
		[XAQueryFieldAttribute("기관계매수")]
		public long ms_18;
		/// <summary>
		/// 기관계매도
		/// </summary>
		[XAQueryFieldAttribute("기관계매도")]
		public long md_18;
		/// <summary>
		/// 기관계증감
		/// </summary>
		[XAQueryFieldAttribute("기관계증감")]
		public long rate_18;
		/// <summary>
		/// 기관계순매수
		/// </summary>
		[XAQueryFieldAttribute("기관계순매수")]
		public long svolume_18;
		/// <summary>
		/// 증권투자자코드
		/// </summary>
		[XAQueryFieldAttribute("증권투자자코드")]
		public string tjjcode_01;
		/// <summary>
		/// 증권매수
		/// </summary>
		[XAQueryFieldAttribute("증권매수")]
		public long ms_01;
		/// <summary>
		/// 증권매도
		/// </summary>
		[XAQueryFieldAttribute("증권매도")]
		public long md_01;
		/// <summary>
		/// 증권증감
		/// </summary>
		[XAQueryFieldAttribute("증권증감")]
		public long rate_01;
		/// <summary>
		/// 증권순매수
		/// </summary>
		[XAQueryFieldAttribute("증권순매수")]
		public long svolume_01;
		/// <summary>
		/// 투신투자자코드
		/// </summary>
		[XAQueryFieldAttribute("투신투자자코드")]
		public string tjjcode_03;
		/// <summary>
		/// 투신매수
		/// </summary>
		[XAQueryFieldAttribute("투신매수")]
		public long ms_03;
		/// <summary>
		/// 투신매도
		/// </summary>
		[XAQueryFieldAttribute("투신매도")]
		public long md_03;
		/// <summary>
		/// 투신증감
		/// </summary>
		[XAQueryFieldAttribute("투신증감")]
		public long rate_03;
		/// <summary>
		/// 투신순매수
		/// </summary>
		[XAQueryFieldAttribute("투신순매수")]
		public long svolume_03;
		/// <summary>
		/// 은행투자자코드
		/// </summary>
		[XAQueryFieldAttribute("은행투자자코드")]
		public string tjjcode_04;
		/// <summary>
		/// 은행매수
		/// </summary>
		[XAQueryFieldAttribute("은행매수")]
		public long ms_04;
		/// <summary>
		/// 은행매도
		/// </summary>
		[XAQueryFieldAttribute("은행매도")]
		public long md_04;
		/// <summary>
		/// 은행증감
		/// </summary>
		[XAQueryFieldAttribute("은행증감")]
		public long rate_04;
		/// <summary>
		/// 은행순매수
		/// </summary>
		[XAQueryFieldAttribute("은행순매수")]
		public long svolume_04;
		/// <summary>
		/// 보험투자자코드
		/// </summary>
		[XAQueryFieldAttribute("보험투자자코드")]
		public string tjjcode_02;
		/// <summary>
		/// 보험매수
		/// </summary>
		[XAQueryFieldAttribute("보험매수")]
		public long ms_02;
		/// <summary>
		/// 보험매도
		/// </summary>
		[XAQueryFieldAttribute("보험매도")]
		public long md_02;
		/// <summary>
		/// 보험증감
		/// </summary>
		[XAQueryFieldAttribute("보험증감")]
		public long rate_02;
		/// <summary>
		/// 보험순매수
		/// </summary>
		[XAQueryFieldAttribute("보험순매수")]
		public long svolume_02;
		/// <summary>
		/// 종금투자자코드
		/// </summary>
		[XAQueryFieldAttribute("종금투자자코드")]
		public string tjjcode_05;
		/// <summary>
		/// 종금매수
		/// </summary>
		[XAQueryFieldAttribute("종금매수")]
		public long ms_05;
		/// <summary>
		/// 종금매도
		/// </summary>
		[XAQueryFieldAttribute("종금매도")]
		public long md_05;
		/// <summary>
		/// 종금증감
		/// </summary>
		[XAQueryFieldAttribute("종금증감")]
		public long rate_05;
		/// <summary>
		/// 종금순매수
		/// </summary>
		[XAQueryFieldAttribute("종금순매수")]
		public long svolume_05;
		/// <summary>
		/// 기금투자자코드
		/// </summary>
		[XAQueryFieldAttribute("기금투자자코드")]
		public string tjjcode_06;
		/// <summary>
		/// 기금매수
		/// </summary>
		[XAQueryFieldAttribute("기금매수")]
		public long ms_06;
		/// <summary>
		/// 기금매도
		/// </summary>
		[XAQueryFieldAttribute("기금매도")]
		public long md_06;
		/// <summary>
		/// 기금증감
		/// </summary>
		[XAQueryFieldAttribute("기금증감")]
		public long rate_06;
		/// <summary>
		/// 기금순매수
		/// </summary>
		[XAQueryFieldAttribute("기금순매수")]
		public long svolume_06;
		/// <summary>
		/// 국가투자코드
		/// </summary>
		[XAQueryFieldAttribute("국가투자코드")]
		public string tjjcode_11;
		/// <summary>
		/// 국가매수
		/// </summary>
		[XAQueryFieldAttribute("국가매수")]
		public long ms_11;
		/// <summary>
		/// 국가매도
		/// </summary>
		[XAQueryFieldAttribute("국가매도")]
		public long md_11;
		/// <summary>
		/// 국가증감
		/// </summary>
		[XAQueryFieldAttribute("국가증감")]
		public long rate_11;
		/// <summary>
		/// 국가순매수
		/// </summary>
		[XAQueryFieldAttribute("국가순매수")]
		public long svolume_11;
		/// <summary>
		/// 기타투자자코드
		/// </summary>
		[XAQueryFieldAttribute("기타투자자코드")]
		public string tjjcode_07;
		/// <summary>
		/// 기타매수
		/// </summary>
		[XAQueryFieldAttribute("기타매수")]
		public long ms_07;
		/// <summary>
		/// 기타매도
		/// </summary>
		[XAQueryFieldAttribute("기타매도")]
		public long md_07;
		/// <summary>
		/// 기타증감
		/// </summary>
		[XAQueryFieldAttribute("기타증감")]
		public long rate_07;
		/// <summary>
		/// 기타순매수
		/// </summary>
		[XAQueryFieldAttribute("기타순매수")]
		public long svolume_07;
		/// <summary>
		/// 사모펀드투자자코드
		/// </summary>
		[XAQueryFieldAttribute("사모펀드투자자코드")]
		public string tjjcode_00;
		/// <summary>
		/// 사모펀드매수
		/// </summary>
		[XAQueryFieldAttribute("사모펀드매수")]
		public long ms_00;
		/// <summary>
		/// 사모펀드매도
		/// </summary>
		[XAQueryFieldAttribute("사모펀드매도")]
		public long md_00;
		/// <summary>
		/// 사모펀드증감
		/// </summary>
		[XAQueryFieldAttribute("사모펀드증감")]
		public long rate_00;
		/// <summary>
		/// 사모펀드순매수
		/// </summary>
		[XAQueryFieldAttribute("사모펀드순매수")]
		public long svolume_00;

		public static class F
		{
			/// <summary>
			/// 개인투자자코드
			/// </summary>
			public const string tjjcode_08 = "tjjcode_08";
			/// <summary>
			/// 개인매수
			/// </summary>
			public const string ms_08 = "ms_08";
			/// <summary>
			/// 개인매도
			/// </summary>
			public const string md_08 = "md_08";
			/// <summary>
			/// 개인증감
			/// </summary>
			public const string rate_08 = "rate_08";
			/// <summary>
			/// 개인순매수
			/// </summary>
			public const string svolume_08 = "svolume_08";
			/// <summary>
			/// 외국인투자자코드
			/// </summary>
			public const string tjjcode_17 = "tjjcode_17";
			/// <summary>
			/// 외국인매수
			/// </summary>
			public const string ms_17 = "ms_17";
			/// <summary>
			/// 외국인매도
			/// </summary>
			public const string md_17 = "md_17";
			/// <summary>
			/// 외국인증감
			/// </summary>
			public const string rate_17 = "rate_17";
			/// <summary>
			/// 외국인순매수
			/// </summary>
			public const string svolume_17 = "svolume_17";
			/// <summary>
			/// 기관계투자자코드
			/// </summary>
			public const string tjjcode_18 = "tjjcode_18";
			/// <summary>
			/// 기관계매수
			/// </summary>
			public const string ms_18 = "ms_18";
			/// <summary>
			/// 기관계매도
			/// </summary>
			public const string md_18 = "md_18";
			/// <summary>
			/// 기관계증감
			/// </summary>
			public const string rate_18 = "rate_18";
			/// <summary>
			/// 기관계순매수
			/// </summary>
			public const string svolume_18 = "svolume_18";
			/// <summary>
			/// 증권투자자코드
			/// </summary>
			public const string tjjcode_01 = "tjjcode_01";
			/// <summary>
			/// 증권매수
			/// </summary>
			public const string ms_01 = "ms_01";
			/// <summary>
			/// 증권매도
			/// </summary>
			public const string md_01 = "md_01";
			/// <summary>
			/// 증권증감
			/// </summary>
			public const string rate_01 = "rate_01";
			/// <summary>
			/// 증권순매수
			/// </summary>
			public const string svolume_01 = "svolume_01";
			/// <summary>
			/// 투신투자자코드
			/// </summary>
			public const string tjjcode_03 = "tjjcode_03";
			/// <summary>
			/// 투신매수
			/// </summary>
			public const string ms_03 = "ms_03";
			/// <summary>
			/// 투신매도
			/// </summary>
			public const string md_03 = "md_03";
			/// <summary>
			/// 투신증감
			/// </summary>
			public const string rate_03 = "rate_03";
			/// <summary>
			/// 투신순매수
			/// </summary>
			public const string svolume_03 = "svolume_03";
			/// <summary>
			/// 은행투자자코드
			/// </summary>
			public const string tjjcode_04 = "tjjcode_04";
			/// <summary>
			/// 은행매수
			/// </summary>
			public const string ms_04 = "ms_04";
			/// <summary>
			/// 은행매도
			/// </summary>
			public const string md_04 = "md_04";
			/// <summary>
			/// 은행증감
			/// </summary>
			public const string rate_04 = "rate_04";
			/// <summary>
			/// 은행순매수
			/// </summary>
			public const string svolume_04 = "svolume_04";
			/// <summary>
			/// 보험투자자코드
			/// </summary>
			public const string tjjcode_02 = "tjjcode_02";
			/// <summary>
			/// 보험매수
			/// </summary>
			public const string ms_02 = "ms_02";
			/// <summary>
			/// 보험매도
			/// </summary>
			public const string md_02 = "md_02";
			/// <summary>
			/// 보험증감
			/// </summary>
			public const string rate_02 = "rate_02";
			/// <summary>
			/// 보험순매수
			/// </summary>
			public const string svolume_02 = "svolume_02";
			/// <summary>
			/// 종금투자자코드
			/// </summary>
			public const string tjjcode_05 = "tjjcode_05";
			/// <summary>
			/// 종금매수
			/// </summary>
			public const string ms_05 = "ms_05";
			/// <summary>
			/// 종금매도
			/// </summary>
			public const string md_05 = "md_05";
			/// <summary>
			/// 종금증감
			/// </summary>
			public const string rate_05 = "rate_05";
			/// <summary>
			/// 종금순매수
			/// </summary>
			public const string svolume_05 = "svolume_05";
			/// <summary>
			/// 기금투자자코드
			/// </summary>
			public const string tjjcode_06 = "tjjcode_06";
			/// <summary>
			/// 기금매수
			/// </summary>
			public const string ms_06 = "ms_06";
			/// <summary>
			/// 기금매도
			/// </summary>
			public const string md_06 = "md_06";
			/// <summary>
			/// 기금증감
			/// </summary>
			public const string rate_06 = "rate_06";
			/// <summary>
			/// 기금순매수
			/// </summary>
			public const string svolume_06 = "svolume_06";
			/// <summary>
			/// 국가투자코드
			/// </summary>
			public const string tjjcode_11 = "tjjcode_11";
			/// <summary>
			/// 국가매수
			/// </summary>
			public const string ms_11 = "ms_11";
			/// <summary>
			/// 국가매도
			/// </summary>
			public const string md_11 = "md_11";
			/// <summary>
			/// 국가증감
			/// </summary>
			public const string rate_11 = "rate_11";
			/// <summary>
			/// 국가순매수
			/// </summary>
			public const string svolume_11 = "svolume_11";
			/// <summary>
			/// 기타투자자코드
			/// </summary>
			public const string tjjcode_07 = "tjjcode_07";
			/// <summary>
			/// 기타매수
			/// </summary>
			public const string ms_07 = "ms_07";
			/// <summary>
			/// 기타매도
			/// </summary>
			public const string md_07 = "md_07";
			/// <summary>
			/// 기타증감
			/// </summary>
			public const string rate_07 = "rate_07";
			/// <summary>
			/// 기타순매수
			/// </summary>
			public const string svolume_07 = "svolume_07";
			/// <summary>
			/// 사모펀드투자자코드
			/// </summary>
			public const string tjjcode_00 = "tjjcode_00";
			/// <summary>
			/// 사모펀드매수
			/// </summary>
			public const string ms_00 = "ms_00";
			/// <summary>
			/// 사모펀드매도
			/// </summary>
			public const string md_00 = "md_00";
			/// <summary>
			/// 사모펀드증감
			/// </summary>
			public const string rate_00 = "rate_00";
			/// <summary>
			/// 사모펀드순매수
			/// </summary>
			public const string svolume_00 = "svolume_00";
		}

		public static string[] AllFields = new string[]
		{
			F.tjjcode_08,
			F.ms_08,
			F.md_08,
			F.rate_08,
			F.svolume_08,
			F.tjjcode_17,
			F.ms_17,
			F.md_17,
			F.rate_17,
			F.svolume_17,
			F.tjjcode_18,
			F.ms_18,
			F.md_18,
			F.rate_18,
			F.svolume_18,
			F.tjjcode_01,
			F.ms_01,
			F.md_01,
			F.rate_01,
			F.svolume_01,
			F.tjjcode_03,
			F.ms_03,
			F.md_03,
			F.rate_03,
			F.svolume_03,
			F.tjjcode_04,
			F.ms_04,
			F.md_04,
			F.rate_04,
			F.svolume_04,
			F.tjjcode_02,
			F.ms_02,
			F.md_02,
			F.rate_02,
			F.svolume_02,
			F.tjjcode_05,
			F.ms_05,
			F.md_05,
			F.rate_05,
			F.svolume_05,
			F.tjjcode_06,
			F.ms_06,
			F.md_06,
			F.rate_06,
			F.svolume_06,
			F.tjjcode_11,
			F.ms_11,
			F.md_11,
			F.rate_11,
			F.svolume_11,
			F.tjjcode_07,
			F.ms_07,
			F.md_07,
			F.rate_07,
			F.svolume_07,
			F.tjjcode_00,
			F.ms_00,
			F.md_00,
			F.rate_00,
			F.svolume_00,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["tjjcode_08"] = new XAQueryFieldInfo("char", tjjcode_08, tjjcode_08, "개인투자자코드", (decimal)4);
			dict["ms_08"] = new XAQueryFieldInfo("long", ms_08, ms_08.ToString("d12"), "개인매수", (decimal)12);
			dict["md_08"] = new XAQueryFieldInfo("long", md_08, md_08.ToString("d12"), "개인매도", (decimal)12);
			dict["rate_08"] = new XAQueryFieldInfo("long", rate_08, rate_08.ToString("d12"), "개인증감", (decimal)12);
			dict["svolume_08"] = new XAQueryFieldInfo("long", svolume_08, svolume_08.ToString("d12"), "개인순매수", (decimal)12);
			dict["tjjcode_17"] = new XAQueryFieldInfo("char", tjjcode_17, tjjcode_17, "외국인투자자코드", (decimal)4);
			dict["ms_17"] = new XAQueryFieldInfo("long", ms_17, ms_17.ToString("d12"), "외국인매수", (decimal)12);
			dict["md_17"] = new XAQueryFieldInfo("long", md_17, md_17.ToString("d12"), "외국인매도", (decimal)12);
			dict["rate_17"] = new XAQueryFieldInfo("long", rate_17, rate_17.ToString("d12"), "외국인증감", (decimal)12);
			dict["svolume_17"] = new XAQueryFieldInfo("long", svolume_17, svolume_17.ToString("d12"), "외국인순매수", (decimal)12);
			dict["tjjcode_18"] = new XAQueryFieldInfo("char", tjjcode_18, tjjcode_18, "기관계투자자코드", (decimal)4);
			dict["ms_18"] = new XAQueryFieldInfo("long", ms_18, ms_18.ToString("d12"), "기관계매수", (decimal)12);
			dict["md_18"] = new XAQueryFieldInfo("long", md_18, md_18.ToString("d12"), "기관계매도", (decimal)12);
			dict["rate_18"] = new XAQueryFieldInfo("long", rate_18, rate_18.ToString("d12"), "기관계증감", (decimal)12);
			dict["svolume_18"] = new XAQueryFieldInfo("long", svolume_18, svolume_18.ToString("d12"), "기관계순매수", (decimal)12);
			dict["tjjcode_01"] = new XAQueryFieldInfo("char", tjjcode_01, tjjcode_01, "증권투자자코드", (decimal)4);
			dict["ms_01"] = new XAQueryFieldInfo("long", ms_01, ms_01.ToString("d12"), "증권매수", (decimal)12);
			dict["md_01"] = new XAQueryFieldInfo("long", md_01, md_01.ToString("d12"), "증권매도", (decimal)12);
			dict["rate_01"] = new XAQueryFieldInfo("long", rate_01, rate_01.ToString("d12"), "증권증감", (decimal)12);
			dict["svolume_01"] = new XAQueryFieldInfo("long", svolume_01, svolume_01.ToString("d12"), "증권순매수", (decimal)12);
			dict["tjjcode_03"] = new XAQueryFieldInfo("char", tjjcode_03, tjjcode_03, "투신투자자코드", (decimal)4);
			dict["ms_03"] = new XAQueryFieldInfo("long", ms_03, ms_03.ToString("d12"), "투신매수", (decimal)12);
			dict["md_03"] = new XAQueryFieldInfo("long", md_03, md_03.ToString("d12"), "투신매도", (decimal)12);
			dict["rate_03"] = new XAQueryFieldInfo("long", rate_03, rate_03.ToString("d12"), "투신증감", (decimal)12);
			dict["svolume_03"] = new XAQueryFieldInfo("long", svolume_03, svolume_03.ToString("d12"), "투신순매수", (decimal)12);
			dict["tjjcode_04"] = new XAQueryFieldInfo("char", tjjcode_04, tjjcode_04, "은행투자자코드", (decimal)4);
			dict["ms_04"] = new XAQueryFieldInfo("long", ms_04, ms_04.ToString("d12"), "은행매수", (decimal)12);
			dict["md_04"] = new XAQueryFieldInfo("long", md_04, md_04.ToString("d12"), "은행매도", (decimal)12);
			dict["rate_04"] = new XAQueryFieldInfo("long", rate_04, rate_04.ToString("d12"), "은행증감", (decimal)12);
			dict["svolume_04"] = new XAQueryFieldInfo("long", svolume_04, svolume_04.ToString("d12"), "은행순매수", (decimal)12);
			dict["tjjcode_02"] = new XAQueryFieldInfo("char", tjjcode_02, tjjcode_02, "보험투자자코드", (decimal)4);
			dict["ms_02"] = new XAQueryFieldInfo("long", ms_02, ms_02.ToString("d12"), "보험매수", (decimal)12);
			dict["md_02"] = new XAQueryFieldInfo("long", md_02, md_02.ToString("d12"), "보험매도", (decimal)12);
			dict["rate_02"] = new XAQueryFieldInfo("long", rate_02, rate_02.ToString("d12"), "보험증감", (decimal)12);
			dict["svolume_02"] = new XAQueryFieldInfo("long", svolume_02, svolume_02.ToString("d12"), "보험순매수", (decimal)12);
			dict["tjjcode_05"] = new XAQueryFieldInfo("char", tjjcode_05, tjjcode_05, "종금투자자코드", (decimal)4);
			dict["ms_05"] = new XAQueryFieldInfo("long", ms_05, ms_05.ToString("d12"), "종금매수", (decimal)12);
			dict["md_05"] = new XAQueryFieldInfo("long", md_05, md_05.ToString("d12"), "종금매도", (decimal)12);
			dict["rate_05"] = new XAQueryFieldInfo("long", rate_05, rate_05.ToString("d12"), "종금증감", (decimal)12);
			dict["svolume_05"] = new XAQueryFieldInfo("long", svolume_05, svolume_05.ToString("d12"), "종금순매수", (decimal)12);
			dict["tjjcode_06"] = new XAQueryFieldInfo("char", tjjcode_06, tjjcode_06, "기금투자자코드", (decimal)4);
			dict["ms_06"] = new XAQueryFieldInfo("long", ms_06, ms_06.ToString("d12"), "기금매수", (decimal)12);
			dict["md_06"] = new XAQueryFieldInfo("long", md_06, md_06.ToString("d12"), "기금매도", (decimal)12);
			dict["rate_06"] = new XAQueryFieldInfo("long", rate_06, rate_06.ToString("d12"), "기금증감", (decimal)12);
			dict["svolume_06"] = new XAQueryFieldInfo("long", svolume_06, svolume_06.ToString("d12"), "기금순매수", (decimal)12);
			dict["tjjcode_11"] = new XAQueryFieldInfo("char", tjjcode_11, tjjcode_11, "국가투자코드", (decimal)4);
			dict["ms_11"] = new XAQueryFieldInfo("long", ms_11, ms_11.ToString("d12"), "국가매수", (decimal)12);
			dict["md_11"] = new XAQueryFieldInfo("long", md_11, md_11.ToString("d12"), "국가매도", (decimal)12);
			dict["rate_11"] = new XAQueryFieldInfo("long", rate_11, rate_11.ToString("d12"), "국가증감", (decimal)12);
			dict["svolume_11"] = new XAQueryFieldInfo("long", svolume_11, svolume_11.ToString("d12"), "국가순매수", (decimal)12);
			dict["tjjcode_07"] = new XAQueryFieldInfo("char", tjjcode_07, tjjcode_07, "기타투자자코드", (decimal)4);
			dict["ms_07"] = new XAQueryFieldInfo("long", ms_07, ms_07.ToString("d12"), "기타매수", (decimal)12);
			dict["md_07"] = new XAQueryFieldInfo("long", md_07, md_07.ToString("d12"), "기타매도", (decimal)12);
			dict["rate_07"] = new XAQueryFieldInfo("long", rate_07, rate_07.ToString("d12"), "기타증감", (decimal)12);
			dict["svolume_07"] = new XAQueryFieldInfo("long", svolume_07, svolume_07.ToString("d12"), "기타순매수", (decimal)12);
			dict["tjjcode_00"] = new XAQueryFieldInfo("char", tjjcode_00, tjjcode_00, "사모펀드투자자코드", (decimal)4);
			dict["ms_00"] = new XAQueryFieldInfo("long", ms_00, ms_00.ToString("d12"), "사모펀드매수", (decimal)12);
			dict["md_00"] = new XAQueryFieldInfo("long", md_00, md_00.ToString("d12"), "사모펀드매도", (decimal)12);
			dict["rate_00"] = new XAQueryFieldInfo("long", rate_00, rate_00.ToString("d12"), "사모펀드증감", (decimal)12);
			dict["svolume_00"] = new XAQueryFieldInfo("long", svolume_00, svolume_00.ToString("d12"), "사모펀드순매수", (decimal)12);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "tjjcode_08":
					this.tjjcode_08 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ms_08":
					this.ms_08 = fieldInfo.FieldValue.ParseLong("ms_08");
				break;

				case "md_08":
					this.md_08 = fieldInfo.FieldValue.ParseLong("md_08");
				break;

				case "rate_08":
					this.rate_08 = fieldInfo.FieldValue.ParseLong("rate_08");
				break;

				case "svolume_08":
					this.svolume_08 = fieldInfo.FieldValue.ParseLong("svolume_08");
				break;

				case "tjjcode_17":
					this.tjjcode_17 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ms_17":
					this.ms_17 = fieldInfo.FieldValue.ParseLong("ms_17");
				break;

				case "md_17":
					this.md_17 = fieldInfo.FieldValue.ParseLong("md_17");
				break;

				case "rate_17":
					this.rate_17 = fieldInfo.FieldValue.ParseLong("rate_17");
				break;

				case "svolume_17":
					this.svolume_17 = fieldInfo.FieldValue.ParseLong("svolume_17");
				break;

				case "tjjcode_18":
					this.tjjcode_18 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ms_18":
					this.ms_18 = fieldInfo.FieldValue.ParseLong("ms_18");
				break;

				case "md_18":
					this.md_18 = fieldInfo.FieldValue.ParseLong("md_18");
				break;

				case "rate_18":
					this.rate_18 = fieldInfo.FieldValue.ParseLong("rate_18");
				break;

				case "svolume_18":
					this.svolume_18 = fieldInfo.FieldValue.ParseLong("svolume_18");
				break;

				case "tjjcode_01":
					this.tjjcode_01 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ms_01":
					this.ms_01 = fieldInfo.FieldValue.ParseLong("ms_01");
				break;

				case "md_01":
					this.md_01 = fieldInfo.FieldValue.ParseLong("md_01");
				break;

				case "rate_01":
					this.rate_01 = fieldInfo.FieldValue.ParseLong("rate_01");
				break;

				case "svolume_01":
					this.svolume_01 = fieldInfo.FieldValue.ParseLong("svolume_01");
				break;

				case "tjjcode_03":
					this.tjjcode_03 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ms_03":
					this.ms_03 = fieldInfo.FieldValue.ParseLong("ms_03");
				break;

				case "md_03":
					this.md_03 = fieldInfo.FieldValue.ParseLong("md_03");
				break;

				case "rate_03":
					this.rate_03 = fieldInfo.FieldValue.ParseLong("rate_03");
				break;

				case "svolume_03":
					this.svolume_03 = fieldInfo.FieldValue.ParseLong("svolume_03");
				break;

				case "tjjcode_04":
					this.tjjcode_04 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ms_04":
					this.ms_04 = fieldInfo.FieldValue.ParseLong("ms_04");
				break;

				case "md_04":
					this.md_04 = fieldInfo.FieldValue.ParseLong("md_04");
				break;

				case "rate_04":
					this.rate_04 = fieldInfo.FieldValue.ParseLong("rate_04");
				break;

				case "svolume_04":
					this.svolume_04 = fieldInfo.FieldValue.ParseLong("svolume_04");
				break;

				case "tjjcode_02":
					this.tjjcode_02 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ms_02":
					this.ms_02 = fieldInfo.FieldValue.ParseLong("ms_02");
				break;

				case "md_02":
					this.md_02 = fieldInfo.FieldValue.ParseLong("md_02");
				break;

				case "rate_02":
					this.rate_02 = fieldInfo.FieldValue.ParseLong("rate_02");
				break;

				case "svolume_02":
					this.svolume_02 = fieldInfo.FieldValue.ParseLong("svolume_02");
				break;

				case "tjjcode_05":
					this.tjjcode_05 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ms_05":
					this.ms_05 = fieldInfo.FieldValue.ParseLong("ms_05");
				break;

				case "md_05":
					this.md_05 = fieldInfo.FieldValue.ParseLong("md_05");
				break;

				case "rate_05":
					this.rate_05 = fieldInfo.FieldValue.ParseLong("rate_05");
				break;

				case "svolume_05":
					this.svolume_05 = fieldInfo.FieldValue.ParseLong("svolume_05");
				break;

				case "tjjcode_06":
					this.tjjcode_06 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ms_06":
					this.ms_06 = fieldInfo.FieldValue.ParseLong("ms_06");
				break;

				case "md_06":
					this.md_06 = fieldInfo.FieldValue.ParseLong("md_06");
				break;

				case "rate_06":
					this.rate_06 = fieldInfo.FieldValue.ParseLong("rate_06");
				break;

				case "svolume_06":
					this.svolume_06 = fieldInfo.FieldValue.ParseLong("svolume_06");
				break;

				case "tjjcode_11":
					this.tjjcode_11 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ms_11":
					this.ms_11 = fieldInfo.FieldValue.ParseLong("ms_11");
				break;

				case "md_11":
					this.md_11 = fieldInfo.FieldValue.ParseLong("md_11");
				break;

				case "rate_11":
					this.rate_11 = fieldInfo.FieldValue.ParseLong("rate_11");
				break;

				case "svolume_11":
					this.svolume_11 = fieldInfo.FieldValue.ParseLong("svolume_11");
				break;

				case "tjjcode_07":
					this.tjjcode_07 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ms_07":
					this.ms_07 = fieldInfo.FieldValue.ParseLong("ms_07");
				break;

				case "md_07":
					this.md_07 = fieldInfo.FieldValue.ParseLong("md_07");
				break;

				case "rate_07":
					this.rate_07 = fieldInfo.FieldValue.ParseLong("rate_07");
				break;

				case "svolume_07":
					this.svolume_07 = fieldInfo.FieldValue.ParseLong("svolume_07");
				break;

				case "tjjcode_00":
					this.tjjcode_00 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ms_00":
					this.ms_00 = fieldInfo.FieldValue.ParseLong("ms_00");
				break;

				case "md_00":
					this.md_00 = fieldInfo.FieldValue.ParseLong("md_00");
				break;

				case "rate_00":
					this.rate_00 = fieldInfo.FieldValue.ParseLong("rate_00");
				break;

				case "svolume_00":
					this.svolume_00 = fieldInfo.FieldValue.ParseLong("svolume_00");
				break;


			}
		}

		public static XQt2816OutBlock2 FromQuery(XQt2816 query)
		{
			XQt2816OutBlock2 block = new XQt2816OutBlock2();
			block.IsValidData = true;
			block.InvalidReason = "";
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				block.IsValidData = false;
				block.InvalidReason = query.ReceiveMessage;
				return block;
			}
			try
			{
				block.tjjcode_08 = query.GetFieldData(block.GetBlockName(), "tjjcode_08", 0).TrimEnd('?'); // char 4
				block.ms_08 = query.GetFieldData(block.GetBlockName(), "ms_08", 0).ParseLong("ms_08"); // long 12
				block.md_08 = query.GetFieldData(block.GetBlockName(), "md_08", 0).ParseLong("md_08"); // long 12
				block.rate_08 = query.GetFieldData(block.GetBlockName(), "rate_08", 0).ParseLong("rate_08"); // long 12
				block.svolume_08 = query.GetFieldData(block.GetBlockName(), "svolume_08", 0).ParseLong("svolume_08"); // long 12
				block.tjjcode_17 = query.GetFieldData(block.GetBlockName(), "tjjcode_17", 0).TrimEnd('?'); // char 4
				block.ms_17 = query.GetFieldData(block.GetBlockName(), "ms_17", 0).ParseLong("ms_17"); // long 12
				block.md_17 = query.GetFieldData(block.GetBlockName(), "md_17", 0).ParseLong("md_17"); // long 12
				block.rate_17 = query.GetFieldData(block.GetBlockName(), "rate_17", 0).ParseLong("rate_17"); // long 12
				block.svolume_17 = query.GetFieldData(block.GetBlockName(), "svolume_17", 0).ParseLong("svolume_17"); // long 12
				block.tjjcode_18 = query.GetFieldData(block.GetBlockName(), "tjjcode_18", 0).TrimEnd('?'); // char 4
				block.ms_18 = query.GetFieldData(block.GetBlockName(), "ms_18", 0).ParseLong("ms_18"); // long 12
				block.md_18 = query.GetFieldData(block.GetBlockName(), "md_18", 0).ParseLong("md_18"); // long 12
				block.rate_18 = query.GetFieldData(block.GetBlockName(), "rate_18", 0).ParseLong("rate_18"); // long 12
				block.svolume_18 = query.GetFieldData(block.GetBlockName(), "svolume_18", 0).ParseLong("svolume_18"); // long 12
				block.tjjcode_01 = query.GetFieldData(block.GetBlockName(), "tjjcode_01", 0).TrimEnd('?'); // char 4
				block.ms_01 = query.GetFieldData(block.GetBlockName(), "ms_01", 0).ParseLong("ms_01"); // long 12
				block.md_01 = query.GetFieldData(block.GetBlockName(), "md_01", 0).ParseLong("md_01"); // long 12
				block.rate_01 = query.GetFieldData(block.GetBlockName(), "rate_01", 0).ParseLong("rate_01"); // long 12
				block.svolume_01 = query.GetFieldData(block.GetBlockName(), "svolume_01", 0).ParseLong("svolume_01"); // long 12
				block.tjjcode_03 = query.GetFieldData(block.GetBlockName(), "tjjcode_03", 0).TrimEnd('?'); // char 4
				block.ms_03 = query.GetFieldData(block.GetBlockName(), "ms_03", 0).ParseLong("ms_03"); // long 12
				block.md_03 = query.GetFieldData(block.GetBlockName(), "md_03", 0).ParseLong("md_03"); // long 12
				block.rate_03 = query.GetFieldData(block.GetBlockName(), "rate_03", 0).ParseLong("rate_03"); // long 12
				block.svolume_03 = query.GetFieldData(block.GetBlockName(), "svolume_03", 0).ParseLong("svolume_03"); // long 12
				block.tjjcode_04 = query.GetFieldData(block.GetBlockName(), "tjjcode_04", 0).TrimEnd('?'); // char 4
				block.ms_04 = query.GetFieldData(block.GetBlockName(), "ms_04", 0).ParseLong("ms_04"); // long 12
				block.md_04 = query.GetFieldData(block.GetBlockName(), "md_04", 0).ParseLong("md_04"); // long 12
				block.rate_04 = query.GetFieldData(block.GetBlockName(), "rate_04", 0).ParseLong("rate_04"); // long 12
				block.svolume_04 = query.GetFieldData(block.GetBlockName(), "svolume_04", 0).ParseLong("svolume_04"); // long 12
				block.tjjcode_02 = query.GetFieldData(block.GetBlockName(), "tjjcode_02", 0).TrimEnd('?'); // char 4
				block.ms_02 = query.GetFieldData(block.GetBlockName(), "ms_02", 0).ParseLong("ms_02"); // long 12
				block.md_02 = query.GetFieldData(block.GetBlockName(), "md_02", 0).ParseLong("md_02"); // long 12
				block.rate_02 = query.GetFieldData(block.GetBlockName(), "rate_02", 0).ParseLong("rate_02"); // long 12
				block.svolume_02 = query.GetFieldData(block.GetBlockName(), "svolume_02", 0).ParseLong("svolume_02"); // long 12
				block.tjjcode_05 = query.GetFieldData(block.GetBlockName(), "tjjcode_05", 0).TrimEnd('?'); // char 4
				block.ms_05 = query.GetFieldData(block.GetBlockName(), "ms_05", 0).ParseLong("ms_05"); // long 12
				block.md_05 = query.GetFieldData(block.GetBlockName(), "md_05", 0).ParseLong("md_05"); // long 12
				block.rate_05 = query.GetFieldData(block.GetBlockName(), "rate_05", 0).ParseLong("rate_05"); // long 12
				block.svolume_05 = query.GetFieldData(block.GetBlockName(), "svolume_05", 0).ParseLong("svolume_05"); // long 12
				block.tjjcode_06 = query.GetFieldData(block.GetBlockName(), "tjjcode_06", 0).TrimEnd('?'); // char 4
				block.ms_06 = query.GetFieldData(block.GetBlockName(), "ms_06", 0).ParseLong("ms_06"); // long 12
				block.md_06 = query.GetFieldData(block.GetBlockName(), "md_06", 0).ParseLong("md_06"); // long 12
				block.rate_06 = query.GetFieldData(block.GetBlockName(), "rate_06", 0).ParseLong("rate_06"); // long 12
				block.svolume_06 = query.GetFieldData(block.GetBlockName(), "svolume_06", 0).ParseLong("svolume_06"); // long 12
				block.tjjcode_11 = query.GetFieldData(block.GetBlockName(), "tjjcode_11", 0).TrimEnd('?'); // char 4
				block.ms_11 = query.GetFieldData(block.GetBlockName(), "ms_11", 0).ParseLong("ms_11"); // long 12
				block.md_11 = query.GetFieldData(block.GetBlockName(), "md_11", 0).ParseLong("md_11"); // long 12
				block.rate_11 = query.GetFieldData(block.GetBlockName(), "rate_11", 0).ParseLong("rate_11"); // long 12
				block.svolume_11 = query.GetFieldData(block.GetBlockName(), "svolume_11", 0).ParseLong("svolume_11"); // long 12
				block.tjjcode_07 = query.GetFieldData(block.GetBlockName(), "tjjcode_07", 0).TrimEnd('?'); // char 4
				block.ms_07 = query.GetFieldData(block.GetBlockName(), "ms_07", 0).ParseLong("ms_07"); // long 12
				block.md_07 = query.GetFieldData(block.GetBlockName(), "md_07", 0).ParseLong("md_07"); // long 12
				block.rate_07 = query.GetFieldData(block.GetBlockName(), "rate_07", 0).ParseLong("rate_07"); // long 12
				block.svolume_07 = query.GetFieldData(block.GetBlockName(), "svolume_07", 0).ParseLong("svolume_07"); // long 12
				block.tjjcode_00 = query.GetFieldData(block.GetBlockName(), "tjjcode_00", 0).TrimEnd('?'); // char 4
				block.ms_00 = query.GetFieldData(block.GetBlockName(), "ms_00", 0).ParseLong("ms_00"); // long 12
				block.md_00 = query.GetFieldData(block.GetBlockName(), "md_00", 0).ParseLong("md_00"); // long 12
				block.rate_00 = query.GetFieldData(block.GetBlockName(), "rate_00", 0).ParseLong("rate_00"); // long 12
				block.svolume_00 = query.GetFieldData(block.GetBlockName(), "svolume_00", 0).ParseLong("svolume_00"); // long 12

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (tjjcode_08?.Length > 4) return false; // char 4
			if (ms_08.ToString().Length > 12) return false; // long 12
			if (md_08.ToString().Length > 12) return false; // long 12
			if (rate_08.ToString().Length > 12) return false; // long 12
			if (svolume_08.ToString().Length > 12) return false; // long 12
			if (tjjcode_17?.Length > 4) return false; // char 4
			if (ms_17.ToString().Length > 12) return false; // long 12
			if (md_17.ToString().Length > 12) return false; // long 12
			if (rate_17.ToString().Length > 12) return false; // long 12
			if (svolume_17.ToString().Length > 12) return false; // long 12
			if (tjjcode_18?.Length > 4) return false; // char 4
			if (ms_18.ToString().Length > 12) return false; // long 12
			if (md_18.ToString().Length > 12) return false; // long 12
			if (rate_18.ToString().Length > 12) return false; // long 12
			if (svolume_18.ToString().Length > 12) return false; // long 12
			if (tjjcode_01?.Length > 4) return false; // char 4
			if (ms_01.ToString().Length > 12) return false; // long 12
			if (md_01.ToString().Length > 12) return false; // long 12
			if (rate_01.ToString().Length > 12) return false; // long 12
			if (svolume_01.ToString().Length > 12) return false; // long 12
			if (tjjcode_03?.Length > 4) return false; // char 4
			if (ms_03.ToString().Length > 12) return false; // long 12
			if (md_03.ToString().Length > 12) return false; // long 12
			if (rate_03.ToString().Length > 12) return false; // long 12
			if (svolume_03.ToString().Length > 12) return false; // long 12
			if (tjjcode_04?.Length > 4) return false; // char 4
			if (ms_04.ToString().Length > 12) return false; // long 12
			if (md_04.ToString().Length > 12) return false; // long 12
			if (rate_04.ToString().Length > 12) return false; // long 12
			if (svolume_04.ToString().Length > 12) return false; // long 12
			if (tjjcode_02?.Length > 4) return false; // char 4
			if (ms_02.ToString().Length > 12) return false; // long 12
			if (md_02.ToString().Length > 12) return false; // long 12
			if (rate_02.ToString().Length > 12) return false; // long 12
			if (svolume_02.ToString().Length > 12) return false; // long 12
			if (tjjcode_05?.Length > 4) return false; // char 4
			if (ms_05.ToString().Length > 12) return false; // long 12
			if (md_05.ToString().Length > 12) return false; // long 12
			if (rate_05.ToString().Length > 12) return false; // long 12
			if (svolume_05.ToString().Length > 12) return false; // long 12
			if (tjjcode_06?.Length > 4) return false; // char 4
			if (ms_06.ToString().Length > 12) return false; // long 12
			if (md_06.ToString().Length > 12) return false; // long 12
			if (rate_06.ToString().Length > 12) return false; // long 12
			if (svolume_06.ToString().Length > 12) return false; // long 12
			if (tjjcode_11?.Length > 4) return false; // char 4
			if (ms_11.ToString().Length > 12) return false; // long 12
			if (md_11.ToString().Length > 12) return false; // long 12
			if (rate_11.ToString().Length > 12) return false; // long 12
			if (svolume_11.ToString().Length > 12) return false; // long 12
			if (tjjcode_07?.Length > 4) return false; // char 4
			if (ms_07.ToString().Length > 12) return false; // long 12
			if (md_07.ToString().Length > 12) return false; // long 12
			if (rate_07.ToString().Length > 12) return false; // long 12
			if (svolume_07.ToString().Length > 12) return false; // long 12
			if (tjjcode_00?.Length > 4) return false; // char 4
			if (ms_00.ToString().Length > 12) return false; // long 12
			if (md_00.ToString().Length > 12) return false; // long 12
			if (rate_00.ToString().Length > 12) return false; // long 12
			if (svolume_00.ToString().Length > 12) return false; // long 12

			return true;
		}
	}

	/// <summary>
	/// CME야간선물투자자별종합(t2816)
	/// </summary>
	public partial class XQt2816 : XingQuery
	{
		/// <summary>
		/// t2816
		/// </summary>
		public const string _typeName = "t2816";
		/// <summary>
		/// CME야간선물투자자별종합(t2816)
		/// </summary>
		public const string _typeDesc = "CME야간선물투자자별종합(t2816)";
		/// <summary>
		/// 
		/// </summary>
		public const string _service = "";
		/// <summary>
		/// A
		/// </summary>
		public const string _headType = "A";
		/// <summary>
		/// 
		/// </summary>
		public const string _creator = "";
		/// <summary>
		/// 
		/// </summary>
		public const string _createdDate = "";
		/// <summary>
		/// true
		/// </summary>
		public const bool _attr = true;
		/// <summary>
		/// true
		/// </summary>
		public const bool _block = true;
		/// <summary>
		/// false
		/// </summary>
		public const bool _encrypt = false;
		/// <summary>
		/// false
		/// </summary>
		public const bool _signature = false;

		/// <summary>
		/// t2816
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// CME야간선물투자자별종합(t2816)
		/// </summary>
		public string TypeDesc => _typeDesc;
		/// <summary>
		/// 
		/// </summary>
		public string Service => _service;
		/// <summary>
		/// A
		/// </summary>
		public string HeadType => _headType;
		/// <summary>
		/// 
		/// </summary>
		public string Creator => _creator;
		/// <summary>
		/// 
		/// </summary>
		public string CreatedDate => _createdDate;
		/// <summary>
		/// true
		/// </summary>
		public bool Attr => _attr;
		/// <summary>
		/// true
		/// </summary>
		public bool Block => _block;
		/// <summary>
		/// false
		/// </summary>
		public bool Encrypt => _encrypt;
		/// <summary>
		/// false
		/// </summary>
		public bool Signature => _signature;

		/// <summary>
		/// CME야간선물투자자별종합(t2816)
		/// </summary>
		public XQt2816() : base("t2816") { }



		public bool SetBlock(XQt2816InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "dummy", 0, block.dummy.ToString()); // char 1

			return true;
		}

		public XQt2816OutBlock1 GetBlock1()
		{
			XQt2816OutBlock1 instance = XQt2816OutBlock1.FromQuery(this);
			return instance;

		}

		public XQt2816OutBlock2 GetBlock2()
		{
			XQt2816OutBlock2 instance = XQt2816OutBlock2.FromQuery(this);
			return instance;

		}


	}

}
