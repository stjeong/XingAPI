using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt2541InBlock : XingBlock
	{
		/// <summary>
		/// t2541InBlock
		/// </summary>
		public const string _blockName = "t2541InBlock";
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
		/// t2541InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t2541InBlock
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
		/// 상품ID
		/// </summary>
		[XAQueryFieldAttribute("상품ID")]
		public string eitem;
		/// <summary>
		/// 시장구분
		/// </summary>
		[XAQueryFieldAttribute("시장구분")]
		public char market;
		/// <summary>
		/// 업종코드
		/// </summary>
		[XAQueryFieldAttribute("업종코드")]
		public string upcode;
		/// <summary>
		/// 수량구분
		/// </summary>
		[XAQueryFieldAttribute("수량구분")]
		public char gubun1;
		/// <summary>
		/// 전일분구분
		/// </summary>
		[XAQueryFieldAttribute("전일분구분")]
		public char gubun2;
		/// <summary>
		/// CTSTIME
		/// </summary>
		[XAQueryFieldAttribute("CTSTIME")]
		public string cts_time;
		/// <summary>
		/// CTSIDX
		/// </summary>
		[XAQueryFieldAttribute("CTSIDX")]
		public long cts_idx;
		/// <summary>
		/// 조회건수
		/// </summary>
		[XAQueryFieldAttribute("조회건수")]
		public int cnt;

		public static class F
		{
			/// <summary>
			/// 상품ID
			/// </summary>
			public const string eitem = "eitem";
			/// <summary>
			/// 시장구분
			/// </summary>
			public const string market = "market";
			/// <summary>
			/// 업종코드
			/// </summary>
			public const string upcode = "upcode";
			/// <summary>
			/// 수량구분
			/// </summary>
			public const string gubun1 = "gubun1";
			/// <summary>
			/// 전일분구분
			/// </summary>
			public const string gubun2 = "gubun2";
			/// <summary>
			/// CTSTIME
			/// </summary>
			public const string cts_time = "cts_time";
			/// <summary>
			/// CTSIDX
			/// </summary>
			public const string cts_idx = "cts_idx";
			/// <summary>
			/// 조회건수
			/// </summary>
			public const string cnt = "cnt";
		}

		public static string[] AllFields = new string[]
		{
			F.eitem,
			F.market,
			F.upcode,
			F.gubun1,
			F.gubun2,
			F.cts_time,
			F.cts_idx,
			F.cnt,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["eitem"] = new XAQueryFieldInfo("char", eitem, eitem, "상품ID", (decimal)2);
			dict["market"] = new XAQueryFieldInfo("char", market, market.ToString(), "시장구분", (decimal)1);
			dict["upcode"] = new XAQueryFieldInfo("char", upcode, upcode, "업종코드", (decimal)3);
			dict["gubun1"] = new XAQueryFieldInfo("char", gubun1, gubun1.ToString(), "수량구분", (decimal)1);
			dict["gubun2"] = new XAQueryFieldInfo("char", gubun2, gubun2.ToString(), "전일분구분", (decimal)1);
			dict["cts_time"] = new XAQueryFieldInfo("char", cts_time, cts_time, "CTSTIME", (decimal)8);
			dict["cts_idx"] = new XAQueryFieldInfo("long", cts_idx, cts_idx.ToString("d4"), "CTSIDX", (decimal)4);
			dict["cnt"] = new XAQueryFieldInfo("int", cnt, cnt.ToString("d4"), "조회건수", (decimal)4);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "eitem":
					this.eitem = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "market":
					this.market = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "upcode":
					this.upcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "gubun1":
					this.gubun1 = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "gubun2":
					this.gubun2 = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "cts_time":
					this.cts_time = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cts_idx":
					this.cts_idx = fieldInfo.FieldValue.ParseLong("cts_idx");
				break;

				case "cnt":
					this.cnt = fieldInfo.FieldValue.ParseInt("cnt");
				break;


			}
		}

		public bool VerifyData()
		{
			if (eitem?.Length > 2) return false; // char 2
			// market char 1
			if (upcode?.Length > 3) return false; // char 3
			// gubun1 char 1
			// gubun2 char 1
			if (cts_time?.Length > 8) return false; // char 8
			if (cts_idx.ToString().Length > 4) return false; // long 4
			// cnt int 4

			return true;
		}
	}

	public partial class XQt2541OutBlock : XingBlock
	{
		/// <summary>
		/// t2541OutBlock
		/// </summary>
		public const string _blockName = "t2541OutBlock";
		/// <summary>
		/// 기본출력
		/// </summary>
		public const string _blockDesc = "기본출력";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// false
		/// </summary>
		public const bool _hasOccurs = false;
		/// <summary>
		/// t2541OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t2541OutBlock
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// 기본출력
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
		/// 상품ID
		/// </summary>
		[XAQueryFieldAttribute("상품ID")]
		public string eitem;
		/// <summary>
		/// 시장구분
		/// </summary>
		[XAQueryFieldAttribute("시장구분")]
		public char sgubun;
		/// <summary>
		/// CTSTIME
		/// </summary>
		[XAQueryFieldAttribute("CTSTIME")]
		public string cts_time;
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
		/// 국가투자자코드
		/// </summary>
		[XAQueryFieldAttribute("국가투자자코드")]
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
		/// 사모펀드코드
		/// </summary>
		[XAQueryFieldAttribute("사모펀드코드")]
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
			/// 상품ID
			/// </summary>
			public const string eitem = "eitem";
			/// <summary>
			/// 시장구분
			/// </summary>
			public const string sgubun = "sgubun";
			/// <summary>
			/// CTSTIME
			/// </summary>
			public const string cts_time = "cts_time";
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
			/// 국가투자자코드
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
			/// 사모펀드코드
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
			F.eitem,
			F.sgubun,
			F.cts_time,
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
			F.tjjcode_07,
			F.ms_07,
			F.md_07,
			F.rate_07,
			F.svolume_07,
			F.tjjcode_11,
			F.ms_11,
			F.md_11,
			F.rate_11,
			F.svolume_11,
			F.tjjcode_00,
			F.ms_00,
			F.md_00,
			F.rate_00,
			F.svolume_00,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["eitem"] = new XAQueryFieldInfo("char", eitem, eitem, "상품ID", (decimal)2);
			dict["sgubun"] = new XAQueryFieldInfo("char", sgubun, sgubun.ToString(), "시장구분", (decimal)1);
			dict["cts_time"] = new XAQueryFieldInfo("char", cts_time, cts_time, "CTSTIME", (decimal)8);
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
			dict["tjjcode_07"] = new XAQueryFieldInfo("char", tjjcode_07, tjjcode_07, "기타투자자코드", (decimal)4);
			dict["ms_07"] = new XAQueryFieldInfo("long", ms_07, ms_07.ToString("d12"), "기타매수", (decimal)12);
			dict["md_07"] = new XAQueryFieldInfo("long", md_07, md_07.ToString("d12"), "기타매도", (decimal)12);
			dict["rate_07"] = new XAQueryFieldInfo("long", rate_07, rate_07.ToString("d12"), "기타증감", (decimal)12);
			dict["svolume_07"] = new XAQueryFieldInfo("long", svolume_07, svolume_07.ToString("d12"), "기타순매수", (decimal)12);
			dict["tjjcode_11"] = new XAQueryFieldInfo("char", tjjcode_11, tjjcode_11, "국가투자자코드", (decimal)4);
			dict["ms_11"] = new XAQueryFieldInfo("long", ms_11, ms_11.ToString("d12"), "국가매수", (decimal)12);
			dict["md_11"] = new XAQueryFieldInfo("long", md_11, md_11.ToString("d12"), "국가매도", (decimal)12);
			dict["rate_11"] = new XAQueryFieldInfo("long", rate_11, rate_11.ToString("d12"), "국가증감", (decimal)12);
			dict["svolume_11"] = new XAQueryFieldInfo("long", svolume_11, svolume_11.ToString("d12"), "국가순매수", (decimal)12);
			dict["tjjcode_00"] = new XAQueryFieldInfo("char", tjjcode_00, tjjcode_00, "사모펀드코드", (decimal)4);
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
				case "eitem":
					this.eitem = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "sgubun":
					this.sgubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "cts_time":
					this.cts_time = fieldInfo.FieldValue.TrimEnd('?');
				break;

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

		public static XQt2541OutBlock FromQuery(XQt2541 query)
		{
			XQt2541OutBlock block = new XQt2541OutBlock();
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
				block.eitem = query.GetFieldData(block.GetBlockName(), "eitem", 0).TrimEnd('?'); // char 2
				block.sgubun = query.GetFieldData(block.GetBlockName(), "sgubun", 0).FirstOrDefault(); // char 1
				block.cts_time = query.GetFieldData(block.GetBlockName(), "cts_time", 0).TrimEnd('?'); // char 8
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
				block.tjjcode_07 = query.GetFieldData(block.GetBlockName(), "tjjcode_07", 0).TrimEnd('?'); // char 4
				block.ms_07 = query.GetFieldData(block.GetBlockName(), "ms_07", 0).ParseLong("ms_07"); // long 12
				block.md_07 = query.GetFieldData(block.GetBlockName(), "md_07", 0).ParseLong("md_07"); // long 12
				block.rate_07 = query.GetFieldData(block.GetBlockName(), "rate_07", 0).ParseLong("rate_07"); // long 12
				block.svolume_07 = query.GetFieldData(block.GetBlockName(), "svolume_07", 0).ParseLong("svolume_07"); // long 12
				block.tjjcode_11 = query.GetFieldData(block.GetBlockName(), "tjjcode_11", 0).TrimEnd('?'); // char 4
				block.ms_11 = query.GetFieldData(block.GetBlockName(), "ms_11", 0).ParseLong("ms_11"); // long 12
				block.md_11 = query.GetFieldData(block.GetBlockName(), "md_11", 0).ParseLong("md_11"); // long 12
				block.rate_11 = query.GetFieldData(block.GetBlockName(), "rate_11", 0).ParseLong("rate_11"); // long 12
				block.svolume_11 = query.GetFieldData(block.GetBlockName(), "svolume_11", 0).ParseLong("svolume_11"); // long 12
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
			if (eitem?.Length > 2) return false; // char 2
			// sgubun char 1
			if (cts_time?.Length > 8) return false; // char 8
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
			if (tjjcode_07?.Length > 4) return false; // char 4
			if (ms_07.ToString().Length > 12) return false; // long 12
			if (md_07.ToString().Length > 12) return false; // long 12
			if (rate_07.ToString().Length > 12) return false; // long 12
			if (svolume_07.ToString().Length > 12) return false; // long 12
			if (tjjcode_11?.Length > 4) return false; // char 4
			if (ms_11.ToString().Length > 12) return false; // long 12
			if (md_11.ToString().Length > 12) return false; // long 12
			if (rate_11.ToString().Length > 12) return false; // long 12
			if (svolume_11.ToString().Length > 12) return false; // long 12
			if (tjjcode_00?.Length > 4) return false; // char 4
			if (ms_00.ToString().Length > 12) return false; // long 12
			if (md_00.ToString().Length > 12) return false; // long 12
			if (rate_00.ToString().Length > 12) return false; // long 12
			if (svolume_00.ToString().Length > 12) return false; // long 12

			return true;
		}
	}

	public partial class XQt2541OutBlock1 : XingBlock
	{
		/// <summary>
		/// t2541OutBlock1
		/// </summary>
		public const string _blockName = "t2541OutBlock1";
		/// <summary>
		/// 출력1
		/// </summary>
		public const string _blockDesc = "출력1";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// true
		/// </summary>
		public const bool _hasOccurs = true;
		/// <summary>
		/// t2541OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t2541OutBlock1
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// 출력1
		/// </summary>
		public string BlockDesc => _blockDesc;
		/// <summary>
		/// output
		/// </summary>
		public string BlockType => _blockType;
		/// <summary>
		/// true
		/// </summary>
		public bool HasOccurs => _hasOccurs;

		/// <summary>
		/// 시간
		/// </summary>
		[XAQueryFieldAttribute("시간")]
		public string time;
		/// <summary>
		/// 개인순매수
		/// </summary>
		[XAQueryFieldAttribute("개인순매수")]
		public long sv_08;
		/// <summary>
		/// 외국인순매수
		/// </summary>
		[XAQueryFieldAttribute("외국인순매수")]
		public long sv_17;
		/// <summary>
		/// 기관계순매수
		/// </summary>
		[XAQueryFieldAttribute("기관계순매수")]
		public long sv_18;
		/// <summary>
		/// 증권순매수
		/// </summary>
		[XAQueryFieldAttribute("증권순매수")]
		public long sv_01;
		/// <summary>
		/// 투신순매수
		/// </summary>
		[XAQueryFieldAttribute("투신순매수")]
		public long sv_03;
		/// <summary>
		/// 은행순매수
		/// </summary>
		[XAQueryFieldAttribute("은행순매수")]
		public long sv_04;
		/// <summary>
		/// 보험순매수
		/// </summary>
		[XAQueryFieldAttribute("보험순매수")]
		public long sv_02;
		/// <summary>
		/// 종금순매수
		/// </summary>
		[XAQueryFieldAttribute("종금순매수")]
		public long sv_05;
		/// <summary>
		/// 기금순매수
		/// </summary>
		[XAQueryFieldAttribute("기금순매수")]
		public long sv_06;
		/// <summary>
		/// 기타순매수
		/// </summary>
		[XAQueryFieldAttribute("기타순매수")]
		public long sv_07;
		/// <summary>
		/// 국가순매수
		/// </summary>
		[XAQueryFieldAttribute("국가순매수")]
		public long sv_11;
		/// <summary>
		/// 사모펀드순매수
		/// </summary>
		[XAQueryFieldAttribute("사모펀드순매수")]
		public long sv_00;

		public static class F
		{
			/// <summary>
			/// 시간
			/// </summary>
			public const string time = "time";
			/// <summary>
			/// 개인순매수
			/// </summary>
			public const string sv_08 = "sv_08";
			/// <summary>
			/// 외국인순매수
			/// </summary>
			public const string sv_17 = "sv_17";
			/// <summary>
			/// 기관계순매수
			/// </summary>
			public const string sv_18 = "sv_18";
			/// <summary>
			/// 증권순매수
			/// </summary>
			public const string sv_01 = "sv_01";
			/// <summary>
			/// 투신순매수
			/// </summary>
			public const string sv_03 = "sv_03";
			/// <summary>
			/// 은행순매수
			/// </summary>
			public const string sv_04 = "sv_04";
			/// <summary>
			/// 보험순매수
			/// </summary>
			public const string sv_02 = "sv_02";
			/// <summary>
			/// 종금순매수
			/// </summary>
			public const string sv_05 = "sv_05";
			/// <summary>
			/// 기금순매수
			/// </summary>
			public const string sv_06 = "sv_06";
			/// <summary>
			/// 기타순매수
			/// </summary>
			public const string sv_07 = "sv_07";
			/// <summary>
			/// 국가순매수
			/// </summary>
			public const string sv_11 = "sv_11";
			/// <summary>
			/// 사모펀드순매수
			/// </summary>
			public const string sv_00 = "sv_00";
		}

		public static string[] AllFields = new string[]
		{
			F.time,
			F.sv_08,
			F.sv_17,
			F.sv_18,
			F.sv_01,
			F.sv_03,
			F.sv_04,
			F.sv_02,
			F.sv_05,
			F.sv_06,
			F.sv_07,
			F.sv_11,
			F.sv_00,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["time"] = new XAQueryFieldInfo("char", time, time, "시간", (decimal)8);
			dict["sv_08"] = new XAQueryFieldInfo("long", sv_08, sv_08.ToString("d12"), "개인순매수", (decimal)12);
			dict["sv_17"] = new XAQueryFieldInfo("long", sv_17, sv_17.ToString("d12"), "외국인순매수", (decimal)12);
			dict["sv_18"] = new XAQueryFieldInfo("long", sv_18, sv_18.ToString("d12"), "기관계순매수", (decimal)12);
			dict["sv_01"] = new XAQueryFieldInfo("long", sv_01, sv_01.ToString("d12"), "증권순매수", (decimal)12);
			dict["sv_03"] = new XAQueryFieldInfo("long", sv_03, sv_03.ToString("d12"), "투신순매수", (decimal)12);
			dict["sv_04"] = new XAQueryFieldInfo("long", sv_04, sv_04.ToString("d12"), "은행순매수", (decimal)12);
			dict["sv_02"] = new XAQueryFieldInfo("long", sv_02, sv_02.ToString("d12"), "보험순매수", (decimal)12);
			dict["sv_05"] = new XAQueryFieldInfo("long", sv_05, sv_05.ToString("d12"), "종금순매수", (decimal)12);
			dict["sv_06"] = new XAQueryFieldInfo("long", sv_06, sv_06.ToString("d12"), "기금순매수", (decimal)12);
			dict["sv_07"] = new XAQueryFieldInfo("long", sv_07, sv_07.ToString("d12"), "기타순매수", (decimal)12);
			dict["sv_11"] = new XAQueryFieldInfo("long", sv_11, sv_11.ToString("d12"), "국가순매수", (decimal)12);
			dict["sv_00"] = new XAQueryFieldInfo("long", sv_00, sv_00.ToString("d12"), "사모펀드순매수", (decimal)12);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "time":
					this.time = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "sv_08":
					this.sv_08 = fieldInfo.FieldValue.ParseLong("sv_08");
				break;

				case "sv_17":
					this.sv_17 = fieldInfo.FieldValue.ParseLong("sv_17");
				break;

				case "sv_18":
					this.sv_18 = fieldInfo.FieldValue.ParseLong("sv_18");
				break;

				case "sv_01":
					this.sv_01 = fieldInfo.FieldValue.ParseLong("sv_01");
				break;

				case "sv_03":
					this.sv_03 = fieldInfo.FieldValue.ParseLong("sv_03");
				break;

				case "sv_04":
					this.sv_04 = fieldInfo.FieldValue.ParseLong("sv_04");
				break;

				case "sv_02":
					this.sv_02 = fieldInfo.FieldValue.ParseLong("sv_02");
				break;

				case "sv_05":
					this.sv_05 = fieldInfo.FieldValue.ParseLong("sv_05");
				break;

				case "sv_06":
					this.sv_06 = fieldInfo.FieldValue.ParseLong("sv_06");
				break;

				case "sv_07":
					this.sv_07 = fieldInfo.FieldValue.ParseLong("sv_07");
				break;

				case "sv_11":
					this.sv_11 = fieldInfo.FieldValue.ParseLong("sv_11");
				break;

				case "sv_00":
					this.sv_00 = fieldInfo.FieldValue.ParseLong("sv_00");
				break;


			}
		}

		public static XQt2541OutBlock1[] ListFromQuery(XQt2541 query)
		{
			int count = query.GetBlockCount(XQt2541OutBlock1.BlockName);
			List<XQt2541OutBlock1> list = new List<XQt2541OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt2541OutBlock1 block = new XQt2541OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.time = query.GetFieldData(block.GetBlockName(), "time", i).TrimEnd('?'); // char 8
					block.sv_08 = query.GetFieldData(block.GetBlockName(), "sv_08", i).ParseLong("sv_08"); // long 12
					block.sv_17 = query.GetFieldData(block.GetBlockName(), "sv_17", i).ParseLong("sv_17"); // long 12
					block.sv_18 = query.GetFieldData(block.GetBlockName(), "sv_18", i).ParseLong("sv_18"); // long 12
					block.sv_01 = query.GetFieldData(block.GetBlockName(), "sv_01", i).ParseLong("sv_01"); // long 12
					block.sv_03 = query.GetFieldData(block.GetBlockName(), "sv_03", i).ParseLong("sv_03"); // long 12
					block.sv_04 = query.GetFieldData(block.GetBlockName(), "sv_04", i).ParseLong("sv_04"); // long 12
					block.sv_02 = query.GetFieldData(block.GetBlockName(), "sv_02", i).ParseLong("sv_02"); // long 12
					block.sv_05 = query.GetFieldData(block.GetBlockName(), "sv_05", i).ParseLong("sv_05"); // long 12
					block.sv_06 = query.GetFieldData(block.GetBlockName(), "sv_06", i).ParseLong("sv_06"); // long 12
					block.sv_07 = query.GetFieldData(block.GetBlockName(), "sv_07", i).ParseLong("sv_07"); // long 12
					block.sv_11 = query.GetFieldData(block.GetBlockName(), "sv_11", i).ParseLong("sv_11"); // long 12
					block.sv_00 = query.GetFieldData(block.GetBlockName(), "sv_00", i).ParseLong("sv_00"); // long 12

				} catch (InvalidDataFormatException e) {
					block.IsValidData = false;
					block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
				}
				list.Add(block);
			}
			return list.ToArray();

		}

		public bool VerifyData()
		{
			if (time?.Length > 8) return false; // char 8
			if (sv_08.ToString().Length > 12) return false; // long 12
			if (sv_17.ToString().Length > 12) return false; // long 12
			if (sv_18.ToString().Length > 12) return false; // long 12
			if (sv_01.ToString().Length > 12) return false; // long 12
			if (sv_03.ToString().Length > 12) return false; // long 12
			if (sv_04.ToString().Length > 12) return false; // long 12
			if (sv_02.ToString().Length > 12) return false; // long 12
			if (sv_05.ToString().Length > 12) return false; // long 12
			if (sv_06.ToString().Length > 12) return false; // long 12
			if (sv_07.ToString().Length > 12) return false; // long 12
			if (sv_11.ToString().Length > 12) return false; // long 12
			if (sv_00.ToString().Length > 12) return false; // long 12

			return true;
		}
	}

	public partial class XQt2541 : XingQuery
	{
		/// <summary>
		/// t2541
		/// </summary>
		public const string _typeName = "t2541";
		/// <summary>
		/// 상품선물투자자매매동향(실시간)(t2541)
		/// </summary>
		public const string _typeDesc = "상품선물투자자매매동향(실시간)(t2541)";
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
		/// t2541
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 상품선물투자자매매동향(실시간)(t2541)
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

		public XQt2541() : base("t2541") { }


		public static XQt2541OutBlock1[] Get(string eitem = default,char market = default,string upcode = default,char gubun1 = default,char gubun2 = default,string cts_time = default,long cts_idx = default,int cnt = default)
		{
			using (XQt2541 instance = new XQt2541())
			{
				instance.SetFieldData(XQt2541InBlock.BlockName, XQt2541InBlock.F.eitem, 0, eitem); // char 2
				instance.SetFieldData(XQt2541InBlock.BlockName, XQt2541InBlock.F.market, 0, market.ToString()); // char 1
				instance.SetFieldData(XQt2541InBlock.BlockName, XQt2541InBlock.F.upcode, 0, upcode); // char 3
				instance.SetFieldData(XQt2541InBlock.BlockName, XQt2541InBlock.F.gubun1, 0, gubun1.ToString()); // char 1
				instance.SetFieldData(XQt2541InBlock.BlockName, XQt2541InBlock.F.gubun2, 0, gubun2.ToString()); // char 1
				instance.SetFieldData(XQt2541InBlock.BlockName, XQt2541InBlock.F.cts_time, 0, cts_time); // char 8
				instance.SetFieldData(XQt2541InBlock.BlockName, XQt2541InBlock.F.cts_idx, 0, cts_idx.ToString("d4")); // long 4
				instance.SetFieldData(XQt2541InBlock.BlockName, XQt2541InBlock.F.cnt, 0, cnt.ToString("d4")); // int 4

				if (instance.Request() < 0)
				{
					return null;
				}

				var outBlock = instance.GetBlock1s();
				return outBlock;
			}
		}

		public bool SetBlock(XQt2541InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "eitem", 0, block.eitem); // char 2
			_xaQuery.SetFieldData(block.GetBlockName(), "market", 0, block.market.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "upcode", 0, block.upcode); // char 3
			_xaQuery.SetFieldData(block.GetBlockName(), "gubun1", 0, block.gubun1.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "gubun2", 0, block.gubun2.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "cts_time", 0, block.cts_time); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "cts_idx", 0, block.cts_idx.ToString("d4")); // long 4
			_xaQuery.SetFieldData(block.GetBlockName(), "cnt", 0, block.cnt.ToString("d4")); // int 4

			return true;
		}

		public XQt2541OutBlock GetBlock()
		{
			XQt2541OutBlock instance = XQt2541OutBlock.FromQuery(this);
			return instance;

		}

		public XQt2541OutBlock1[] GetBlock1s()
		{
			XQt2541OutBlock1[] instance = XQt2541OutBlock1.ListFromQuery(this);
			return instance;

		}


	}

}
