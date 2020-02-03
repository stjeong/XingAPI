using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1717InBlock : XingBlock
	{
		/// <summary>
		/// t1717InBlock
		/// </summary>
		static readonly string _blockName = "t1717InBlock";
		/// <summary>
		/// 기본입력
		/// </summary>
		static readonly string _blockDesc = "기본입력";
		/// <summary>
		/// input
		/// </summary>
		static readonly string _blockType = "input";
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _hasOccurs = false;
		/// <summary>
		/// t1717InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1717InBlock
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
		/// 종목코드
		/// </summary>
		[XAQueryFieldAttribute("종목코드")]
		public string shcode;
		/// <summary>
		/// 구분(0:일간순매수1:기간누적순매수)
		/// </summary>
		[XAQueryFieldAttribute("구분(0:일간순매수1:기간누적순매수)")]
		public char gubun;
		/// <summary>
		/// 시작일자(일간조회일경우는space)
		/// </summary>
		[XAQueryFieldAttribute("시작일자(일간조회일경우는space)")]
		public string fromdt;
		/// <summary>
		/// 종료일자
		/// </summary>
		[XAQueryFieldAttribute("종료일자")]
		public string todt;

		public static class F
		{
			/// <summary>
			/// 종목코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 구분(0:일간순매수1:기간누적순매수)
			/// </summary>
			public const string gubun = "gubun";
			/// <summary>
			/// 시작일자(일간조회일경우는space)
			/// </summary>
			public const string fromdt = "fromdt";
			/// <summary>
			/// 종료일자
			/// </summary>
			public const string todt = "todt";
		}

		public static string[] AllFields = new string[]
		{
			F.shcode,
			F.gubun,
			F.fromdt,
			F.todt,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "종목코드", (decimal)6);
			dict["gubun"] = new XAQueryFieldInfo("char", gubun, gubun.ToString(), "구분(0:일간순매수1:기간누적순매수)", (decimal)1);
			dict["fromdt"] = new XAQueryFieldInfo("char", fromdt, fromdt, "시작일자(일간조회일경우는space)", (decimal)8);
			dict["todt"] = new XAQueryFieldInfo("char", todt, todt, "종료일자", (decimal)8);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "gubun":
					this.gubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "fromdt":
					this.fromdt = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "todt":
					this.todt = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (shcode.Length > 6) return false; // char 6
			// gubun char 1
			if (fromdt.Length > 8) return false; // char 8
			if (todt.Length > 8) return false; // char 8

			return true;
		}
	}

	public partial class XQt1717OutBlock : XingBlock
	{
		/// <summary>
		/// t1717OutBlock
		/// </summary>
		static readonly string _blockName = "t1717OutBlock";
		/// <summary>
		/// 출력
		/// </summary>
		static readonly string _blockDesc = "출력";
		/// <summary>
		/// output
		/// </summary>
		static readonly string _blockType = "output";
		/// <summary>
		/// true
		/// </summary>
		static readonly bool _hasOccurs = true;
		/// <summary>
		/// t1717OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1717OutBlock
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
		/// true
		/// </summary>
		public bool HasOccurs => _hasOccurs;

		/// <summary>
		/// 일자
		/// </summary>
		[XAQueryFieldAttribute("일자")]
		public string date;
		/// <summary>
		/// 종가
		/// </summary>
		[XAQueryFieldAttribute("종가")]
		public long close;
		/// <summary>
		/// 전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("전일대비구분")]
		public char sign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[XAQueryFieldAttribute("전일대비")]
		public long change;
		/// <summary>
		/// 등락율
		/// </summary>
		[XAQueryFieldAttribute("등락율")]
		public float diff;
		/// <summary>
		/// 누적거래량
		/// </summary>
		[XAQueryFieldAttribute("누적거래량")]
		public long volume;
		/// <summary>
		/// 사모펀드(순매수량)
		/// </summary>
		[XAQueryFieldAttribute("사모펀드(순매수량)")]
		public long tjj0000_vol;
		/// <summary>
		/// 증권(순매수량)
		/// </summary>
		[XAQueryFieldAttribute("증권(순매수량)")]
		public long tjj0001_vol;
		/// <summary>
		/// 보험(순매수량)
		/// </summary>
		[XAQueryFieldAttribute("보험(순매수량)")]
		public long tjj0002_vol;
		/// <summary>
		/// 투신(순매수량)
		/// </summary>
		[XAQueryFieldAttribute("투신(순매수량)")]
		public long tjj0003_vol;
		/// <summary>
		/// 은행(순매수량)
		/// </summary>
		[XAQueryFieldAttribute("은행(순매수량)")]
		public long tjj0004_vol;
		/// <summary>
		/// 종금(순매수량)
		/// </summary>
		[XAQueryFieldAttribute("종금(순매수량)")]
		public long tjj0005_vol;
		/// <summary>
		/// 기금(순매수량)
		/// </summary>
		[XAQueryFieldAttribute("기금(순매수량)")]
		public long tjj0006_vol;
		/// <summary>
		/// 기타법인(순매수량)
		/// </summary>
		[XAQueryFieldAttribute("기타법인(순매수량)")]
		public long tjj0007_vol;
		/// <summary>
		/// 개인(순매수량)
		/// </summary>
		[XAQueryFieldAttribute("개인(순매수량)")]
		public long tjj0008_vol;
		/// <summary>
		/// 등록외국인(순매수량)
		/// </summary>
		[XAQueryFieldAttribute("등록외국인(순매수량)")]
		public long tjj0009_vol;
		/// <summary>
		/// 미등록외국인(순매수량)
		/// </summary>
		[XAQueryFieldAttribute("미등록외국인(순매수량)")]
		public long tjj0010_vol;
		/// <summary>
		/// 국가외(순매수량)
		/// </summary>
		[XAQueryFieldAttribute("국가외(순매수량)")]
		public long tjj0011_vol;
		/// <summary>
		/// 기관(순매수량)
		/// </summary>
		[XAQueryFieldAttribute("기관(순매수량)")]
		public long tjj0018_vol;
		/// <summary>
		/// 외인계(순매수량)(등록+미등록)
		/// </summary>
		[XAQueryFieldAttribute("외인계(순매수량)(등록+미등록)")]
		public long tjj0016_vol;
		/// <summary>
		/// 기타계(순매수량)(기타+국가)
		/// </summary>
		[XAQueryFieldAttribute("기타계(순매수량)(기타+국가)")]
		public long tjj0017_vol;
		/// <summary>
		/// 사모펀드(단가)
		/// </summary>
		[XAQueryFieldAttribute("사모펀드(단가)")]
		public long tjj0000_dan;
		/// <summary>
		/// 증권(단가)
		/// </summary>
		[XAQueryFieldAttribute("증권(단가)")]
		public long tjj0001_dan;
		/// <summary>
		/// 보험(단가)
		/// </summary>
		[XAQueryFieldAttribute("보험(단가)")]
		public long tjj0002_dan;
		/// <summary>
		/// 투신(단가)
		/// </summary>
		[XAQueryFieldAttribute("투신(단가)")]
		public long tjj0003_dan;
		/// <summary>
		/// 은행(단가)
		/// </summary>
		[XAQueryFieldAttribute("은행(단가)")]
		public long tjj0004_dan;
		/// <summary>
		/// 종금(단가)
		/// </summary>
		[XAQueryFieldAttribute("종금(단가)")]
		public long tjj0005_dan;
		/// <summary>
		/// 기금(단가)
		/// </summary>
		[XAQueryFieldAttribute("기금(단가)")]
		public long tjj0006_dan;
		/// <summary>
		/// 기타법인(단가)
		/// </summary>
		[XAQueryFieldAttribute("기타법인(단가)")]
		public long tjj0007_dan;
		/// <summary>
		/// 개인(단가)
		/// </summary>
		[XAQueryFieldAttribute("개인(단가)")]
		public long tjj0008_dan;
		/// <summary>
		/// 등록외국인(단가)
		/// </summary>
		[XAQueryFieldAttribute("등록외국인(단가)")]
		public long tjj0009_dan;
		/// <summary>
		/// 미등록외국인(단가)
		/// </summary>
		[XAQueryFieldAttribute("미등록외국인(단가)")]
		public long tjj0010_dan;
		/// <summary>
		/// 국가외(단가)
		/// </summary>
		[XAQueryFieldAttribute("국가외(단가)")]
		public long tjj0011_dan;
		/// <summary>
		/// 기관(단가)
		/// </summary>
		[XAQueryFieldAttribute("기관(단가)")]
		public long tjj0018_dan;
		/// <summary>
		/// 외인계(단가)(등록+미등록)
		/// </summary>
		[XAQueryFieldAttribute("외인계(단가)(등록+미등록)")]
		public long tjj0016_dan;
		/// <summary>
		/// 기타계(단가)(기타+국가)
		/// </summary>
		[XAQueryFieldAttribute("기타계(단가)(기타+국가)")]
		public long tjj0017_dan;

		public static class F
		{
			/// <summary>
			/// 일자
			/// </summary>
			public const string date = "date";
			/// <summary>
			/// 종가
			/// </summary>
			public const string close = "close";
			/// <summary>
			/// 전일대비구분
			/// </summary>
			public const string sign = "sign";
			/// <summary>
			/// 전일대비
			/// </summary>
			public const string change = "change";
			/// <summary>
			/// 등락율
			/// </summary>
			public const string diff = "diff";
			/// <summary>
			/// 누적거래량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// 사모펀드(순매수량)
			/// </summary>
			public const string tjj0000_vol = "tjj0000_vol";
			/// <summary>
			/// 증권(순매수량)
			/// </summary>
			public const string tjj0001_vol = "tjj0001_vol";
			/// <summary>
			/// 보험(순매수량)
			/// </summary>
			public const string tjj0002_vol = "tjj0002_vol";
			/// <summary>
			/// 투신(순매수량)
			/// </summary>
			public const string tjj0003_vol = "tjj0003_vol";
			/// <summary>
			/// 은행(순매수량)
			/// </summary>
			public const string tjj0004_vol = "tjj0004_vol";
			/// <summary>
			/// 종금(순매수량)
			/// </summary>
			public const string tjj0005_vol = "tjj0005_vol";
			/// <summary>
			/// 기금(순매수량)
			/// </summary>
			public const string tjj0006_vol = "tjj0006_vol";
			/// <summary>
			/// 기타법인(순매수량)
			/// </summary>
			public const string tjj0007_vol = "tjj0007_vol";
			/// <summary>
			/// 개인(순매수량)
			/// </summary>
			public const string tjj0008_vol = "tjj0008_vol";
			/// <summary>
			/// 등록외국인(순매수량)
			/// </summary>
			public const string tjj0009_vol = "tjj0009_vol";
			/// <summary>
			/// 미등록외국인(순매수량)
			/// </summary>
			public const string tjj0010_vol = "tjj0010_vol";
			/// <summary>
			/// 국가외(순매수량)
			/// </summary>
			public const string tjj0011_vol = "tjj0011_vol";
			/// <summary>
			/// 기관(순매수량)
			/// </summary>
			public const string tjj0018_vol = "tjj0018_vol";
			/// <summary>
			/// 외인계(순매수량)(등록+미등록)
			/// </summary>
			public const string tjj0016_vol = "tjj0016_vol";
			/// <summary>
			/// 기타계(순매수량)(기타+국가)
			/// </summary>
			public const string tjj0017_vol = "tjj0017_vol";
			/// <summary>
			/// 사모펀드(단가)
			/// </summary>
			public const string tjj0000_dan = "tjj0000_dan";
			/// <summary>
			/// 증권(단가)
			/// </summary>
			public const string tjj0001_dan = "tjj0001_dan";
			/// <summary>
			/// 보험(단가)
			/// </summary>
			public const string tjj0002_dan = "tjj0002_dan";
			/// <summary>
			/// 투신(단가)
			/// </summary>
			public const string tjj0003_dan = "tjj0003_dan";
			/// <summary>
			/// 은행(단가)
			/// </summary>
			public const string tjj0004_dan = "tjj0004_dan";
			/// <summary>
			/// 종금(단가)
			/// </summary>
			public const string tjj0005_dan = "tjj0005_dan";
			/// <summary>
			/// 기금(단가)
			/// </summary>
			public const string tjj0006_dan = "tjj0006_dan";
			/// <summary>
			/// 기타법인(단가)
			/// </summary>
			public const string tjj0007_dan = "tjj0007_dan";
			/// <summary>
			/// 개인(단가)
			/// </summary>
			public const string tjj0008_dan = "tjj0008_dan";
			/// <summary>
			/// 등록외국인(단가)
			/// </summary>
			public const string tjj0009_dan = "tjj0009_dan";
			/// <summary>
			/// 미등록외국인(단가)
			/// </summary>
			public const string tjj0010_dan = "tjj0010_dan";
			/// <summary>
			/// 국가외(단가)
			/// </summary>
			public const string tjj0011_dan = "tjj0011_dan";
			/// <summary>
			/// 기관(단가)
			/// </summary>
			public const string tjj0018_dan = "tjj0018_dan";
			/// <summary>
			/// 외인계(단가)(등록+미등록)
			/// </summary>
			public const string tjj0016_dan = "tjj0016_dan";
			/// <summary>
			/// 기타계(단가)(기타+국가)
			/// </summary>
			public const string tjj0017_dan = "tjj0017_dan";
		}

		public static string[] AllFields = new string[]
		{
			F.date,
			F.close,
			F.sign,
			F.change,
			F.diff,
			F.volume,
			F.tjj0000_vol,
			F.tjj0001_vol,
			F.tjj0002_vol,
			F.tjj0003_vol,
			F.tjj0004_vol,
			F.tjj0005_vol,
			F.tjj0006_vol,
			F.tjj0007_vol,
			F.tjj0008_vol,
			F.tjj0009_vol,
			F.tjj0010_vol,
			F.tjj0011_vol,
			F.tjj0018_vol,
			F.tjj0016_vol,
			F.tjj0017_vol,
			F.tjj0000_dan,
			F.tjj0001_dan,
			F.tjj0002_dan,
			F.tjj0003_dan,
			F.tjj0004_dan,
			F.tjj0005_dan,
			F.tjj0006_dan,
			F.tjj0007_dan,
			F.tjj0008_dan,
			F.tjj0009_dan,
			F.tjj0010_dan,
			F.tjj0011_dan,
			F.tjj0018_dan,
			F.tjj0016_dan,
			F.tjj0017_dan,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["date"] = new XAQueryFieldInfo("char", date, date, "일자", (decimal)8);
			dict["close"] = new XAQueryFieldInfo("long", close, close.ToString("d8"), "종가", (decimal)8);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("long", change, change.ToString("d8"), "전일대비", (decimal)8);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "누적거래량", (decimal)12);
			dict["tjj0000_vol"] = new XAQueryFieldInfo("long", tjj0000_vol, tjj0000_vol.ToString("d12"), "사모펀드(순매수량)", (decimal)12);
			dict["tjj0001_vol"] = new XAQueryFieldInfo("long", tjj0001_vol, tjj0001_vol.ToString("d12"), "증권(순매수량)", (decimal)12);
			dict["tjj0002_vol"] = new XAQueryFieldInfo("long", tjj0002_vol, tjj0002_vol.ToString("d12"), "보험(순매수량)", (decimal)12);
			dict["tjj0003_vol"] = new XAQueryFieldInfo("long", tjj0003_vol, tjj0003_vol.ToString("d12"), "투신(순매수량)", (decimal)12);
			dict["tjj0004_vol"] = new XAQueryFieldInfo("long", tjj0004_vol, tjj0004_vol.ToString("d12"), "은행(순매수량)", (decimal)12);
			dict["tjj0005_vol"] = new XAQueryFieldInfo("long", tjj0005_vol, tjj0005_vol.ToString("d12"), "종금(순매수량)", (decimal)12);
			dict["tjj0006_vol"] = new XAQueryFieldInfo("long", tjj0006_vol, tjj0006_vol.ToString("d12"), "기금(순매수량)", (decimal)12);
			dict["tjj0007_vol"] = new XAQueryFieldInfo("long", tjj0007_vol, tjj0007_vol.ToString("d12"), "기타법인(순매수량)", (decimal)12);
			dict["tjj0008_vol"] = new XAQueryFieldInfo("long", tjj0008_vol, tjj0008_vol.ToString("d12"), "개인(순매수량)", (decimal)12);
			dict["tjj0009_vol"] = new XAQueryFieldInfo("long", tjj0009_vol, tjj0009_vol.ToString("d12"), "등록외국인(순매수량)", (decimal)12);
			dict["tjj0010_vol"] = new XAQueryFieldInfo("long", tjj0010_vol, tjj0010_vol.ToString("d12"), "미등록외국인(순매수량)", (decimal)12);
			dict["tjj0011_vol"] = new XAQueryFieldInfo("long", tjj0011_vol, tjj0011_vol.ToString("d12"), "국가외(순매수량)", (decimal)12);
			dict["tjj0018_vol"] = new XAQueryFieldInfo("long", tjj0018_vol, tjj0018_vol.ToString("d12"), "기관(순매수량)", (decimal)12);
			dict["tjj0016_vol"] = new XAQueryFieldInfo("long", tjj0016_vol, tjj0016_vol.ToString("d12"), "외인계(순매수량)(등록+미등록)", (decimal)12);
			dict["tjj0017_vol"] = new XAQueryFieldInfo("long", tjj0017_vol, tjj0017_vol.ToString("d12"), "기타계(순매수량)(기타+국가)", (decimal)12);
			dict["tjj0000_dan"] = new XAQueryFieldInfo("long", tjj0000_dan, tjj0000_dan.ToString("d12"), "사모펀드(단가)", (decimal)12);
			dict["tjj0001_dan"] = new XAQueryFieldInfo("long", tjj0001_dan, tjj0001_dan.ToString("d12"), "증권(단가)", (decimal)12);
			dict["tjj0002_dan"] = new XAQueryFieldInfo("long", tjj0002_dan, tjj0002_dan.ToString("d12"), "보험(단가)", (decimal)12);
			dict["tjj0003_dan"] = new XAQueryFieldInfo("long", tjj0003_dan, tjj0003_dan.ToString("d12"), "투신(단가)", (decimal)12);
			dict["tjj0004_dan"] = new XAQueryFieldInfo("long", tjj0004_dan, tjj0004_dan.ToString("d12"), "은행(단가)", (decimal)12);
			dict["tjj0005_dan"] = new XAQueryFieldInfo("long", tjj0005_dan, tjj0005_dan.ToString("d12"), "종금(단가)", (decimal)12);
			dict["tjj0006_dan"] = new XAQueryFieldInfo("long", tjj0006_dan, tjj0006_dan.ToString("d12"), "기금(단가)", (decimal)12);
			dict["tjj0007_dan"] = new XAQueryFieldInfo("long", tjj0007_dan, tjj0007_dan.ToString("d12"), "기타법인(단가)", (decimal)12);
			dict["tjj0008_dan"] = new XAQueryFieldInfo("long", tjj0008_dan, tjj0008_dan.ToString("d12"), "개인(단가)", (decimal)12);
			dict["tjj0009_dan"] = new XAQueryFieldInfo("long", tjj0009_dan, tjj0009_dan.ToString("d12"), "등록외국인(단가)", (decimal)12);
			dict["tjj0010_dan"] = new XAQueryFieldInfo("long", tjj0010_dan, tjj0010_dan.ToString("d12"), "미등록외국인(단가)", (decimal)12);
			dict["tjj0011_dan"] = new XAQueryFieldInfo("long", tjj0011_dan, tjj0011_dan.ToString("d12"), "국가외(단가)", (decimal)12);
			dict["tjj0018_dan"] = new XAQueryFieldInfo("long", tjj0018_dan, tjj0018_dan.ToString("d12"), "기관(단가)", (decimal)12);
			dict["tjj0016_dan"] = new XAQueryFieldInfo("long", tjj0016_dan, tjj0016_dan.ToString("d12"), "외인계(단가)(등록+미등록)", (decimal)12);
			dict["tjj0017_dan"] = new XAQueryFieldInfo("long", tjj0017_dan, tjj0017_dan.ToString("d12"), "기타계(단가)(기타+국가)", (decimal)12);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "date":
					this.date = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "close":
					this.close = fieldInfo.FieldValue.ParseLong("close");
				break;

				case "sign":
					this.sign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "change":
					this.change = fieldInfo.FieldValue.ParseLong("change");
				break;

				case "diff":
					this.diff = fieldInfo.FieldValue.ParseFloat("diff");
				break;

				case "volume":
					this.volume = fieldInfo.FieldValue.ParseLong("volume");
				break;

				case "tjj0000_vol":
					this.tjj0000_vol = fieldInfo.FieldValue.ParseLong("tjj0000_vol");
				break;

				case "tjj0001_vol":
					this.tjj0001_vol = fieldInfo.FieldValue.ParseLong("tjj0001_vol");
				break;

				case "tjj0002_vol":
					this.tjj0002_vol = fieldInfo.FieldValue.ParseLong("tjj0002_vol");
				break;

				case "tjj0003_vol":
					this.tjj0003_vol = fieldInfo.FieldValue.ParseLong("tjj0003_vol");
				break;

				case "tjj0004_vol":
					this.tjj0004_vol = fieldInfo.FieldValue.ParseLong("tjj0004_vol");
				break;

				case "tjj0005_vol":
					this.tjj0005_vol = fieldInfo.FieldValue.ParseLong("tjj0005_vol");
				break;

				case "tjj0006_vol":
					this.tjj0006_vol = fieldInfo.FieldValue.ParseLong("tjj0006_vol");
				break;

				case "tjj0007_vol":
					this.tjj0007_vol = fieldInfo.FieldValue.ParseLong("tjj0007_vol");
				break;

				case "tjj0008_vol":
					this.tjj0008_vol = fieldInfo.FieldValue.ParseLong("tjj0008_vol");
				break;

				case "tjj0009_vol":
					this.tjj0009_vol = fieldInfo.FieldValue.ParseLong("tjj0009_vol");
				break;

				case "tjj0010_vol":
					this.tjj0010_vol = fieldInfo.FieldValue.ParseLong("tjj0010_vol");
				break;

				case "tjj0011_vol":
					this.tjj0011_vol = fieldInfo.FieldValue.ParseLong("tjj0011_vol");
				break;

				case "tjj0018_vol":
					this.tjj0018_vol = fieldInfo.FieldValue.ParseLong("tjj0018_vol");
				break;

				case "tjj0016_vol":
					this.tjj0016_vol = fieldInfo.FieldValue.ParseLong("tjj0016_vol");
				break;

				case "tjj0017_vol":
					this.tjj0017_vol = fieldInfo.FieldValue.ParseLong("tjj0017_vol");
				break;

				case "tjj0000_dan":
					this.tjj0000_dan = fieldInfo.FieldValue.ParseLong("tjj0000_dan");
				break;

				case "tjj0001_dan":
					this.tjj0001_dan = fieldInfo.FieldValue.ParseLong("tjj0001_dan");
				break;

				case "tjj0002_dan":
					this.tjj0002_dan = fieldInfo.FieldValue.ParseLong("tjj0002_dan");
				break;

				case "tjj0003_dan":
					this.tjj0003_dan = fieldInfo.FieldValue.ParseLong("tjj0003_dan");
				break;

				case "tjj0004_dan":
					this.tjj0004_dan = fieldInfo.FieldValue.ParseLong("tjj0004_dan");
				break;

				case "tjj0005_dan":
					this.tjj0005_dan = fieldInfo.FieldValue.ParseLong("tjj0005_dan");
				break;

				case "tjj0006_dan":
					this.tjj0006_dan = fieldInfo.FieldValue.ParseLong("tjj0006_dan");
				break;

				case "tjj0007_dan":
					this.tjj0007_dan = fieldInfo.FieldValue.ParseLong("tjj0007_dan");
				break;

				case "tjj0008_dan":
					this.tjj0008_dan = fieldInfo.FieldValue.ParseLong("tjj0008_dan");
				break;

				case "tjj0009_dan":
					this.tjj0009_dan = fieldInfo.FieldValue.ParseLong("tjj0009_dan");
				break;

				case "tjj0010_dan":
					this.tjj0010_dan = fieldInfo.FieldValue.ParseLong("tjj0010_dan");
				break;

				case "tjj0011_dan":
					this.tjj0011_dan = fieldInfo.FieldValue.ParseLong("tjj0011_dan");
				break;

				case "tjj0018_dan":
					this.tjj0018_dan = fieldInfo.FieldValue.ParseLong("tjj0018_dan");
				break;

				case "tjj0016_dan":
					this.tjj0016_dan = fieldInfo.FieldValue.ParseLong("tjj0016_dan");
				break;

				case "tjj0017_dan":
					this.tjj0017_dan = fieldInfo.FieldValue.ParseLong("tjj0017_dan");
				break;


			}
		}

		public static XQt1717OutBlock[] ListFromQuery(XQt1717 query)
		{
			int count = query.GetBlockCount(XQt1717OutBlock.BlockName);
			List<XQt1717OutBlock> list = new List<XQt1717OutBlock>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1717OutBlock block = new XQt1717OutBlock();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.date = query.GetFieldData(block.GetBlockName(), "date", i).TrimEnd('?'); // char 8
					block.close = query.GetFieldData(block.GetBlockName(), "close", i).ParseLong("close"); // long 8
					block.sign = query.GetFieldData(block.GetBlockName(), "sign", i).FirstOrDefault(); // char 1
					block.change = query.GetFieldData(block.GetBlockName(), "change", i).ParseLong("change"); // long 8
					block.diff = query.GetFieldData(block.GetBlockName(), "diff", i).ParseFloat("diff"); // float 6.2
					block.volume = query.GetFieldData(block.GetBlockName(), "volume", i).ParseLong("volume"); // long 12
					block.tjj0000_vol = query.GetFieldData(block.GetBlockName(), "tjj0000_vol", i).ParseLong("tjj0000_vol"); // long 12
					block.tjj0001_vol = query.GetFieldData(block.GetBlockName(), "tjj0001_vol", i).ParseLong("tjj0001_vol"); // long 12
					block.tjj0002_vol = query.GetFieldData(block.GetBlockName(), "tjj0002_vol", i).ParseLong("tjj0002_vol"); // long 12
					block.tjj0003_vol = query.GetFieldData(block.GetBlockName(), "tjj0003_vol", i).ParseLong("tjj0003_vol"); // long 12
					block.tjj0004_vol = query.GetFieldData(block.GetBlockName(), "tjj0004_vol", i).ParseLong("tjj0004_vol"); // long 12
					block.tjj0005_vol = query.GetFieldData(block.GetBlockName(), "tjj0005_vol", i).ParseLong("tjj0005_vol"); // long 12
					block.tjj0006_vol = query.GetFieldData(block.GetBlockName(), "tjj0006_vol", i).ParseLong("tjj0006_vol"); // long 12
					block.tjj0007_vol = query.GetFieldData(block.GetBlockName(), "tjj0007_vol", i).ParseLong("tjj0007_vol"); // long 12
					block.tjj0008_vol = query.GetFieldData(block.GetBlockName(), "tjj0008_vol", i).ParseLong("tjj0008_vol"); // long 12
					block.tjj0009_vol = query.GetFieldData(block.GetBlockName(), "tjj0009_vol", i).ParseLong("tjj0009_vol"); // long 12
					block.tjj0010_vol = query.GetFieldData(block.GetBlockName(), "tjj0010_vol", i).ParseLong("tjj0010_vol"); // long 12
					block.tjj0011_vol = query.GetFieldData(block.GetBlockName(), "tjj0011_vol", i).ParseLong("tjj0011_vol"); // long 12
					block.tjj0018_vol = query.GetFieldData(block.GetBlockName(), "tjj0018_vol", i).ParseLong("tjj0018_vol"); // long 12
					block.tjj0016_vol = query.GetFieldData(block.GetBlockName(), "tjj0016_vol", i).ParseLong("tjj0016_vol"); // long 12
					block.tjj0017_vol = query.GetFieldData(block.GetBlockName(), "tjj0017_vol", i).ParseLong("tjj0017_vol"); // long 12
					block.tjj0000_dan = query.GetFieldData(block.GetBlockName(), "tjj0000_dan", i).ParseLong("tjj0000_dan"); // long 12
					block.tjj0001_dan = query.GetFieldData(block.GetBlockName(), "tjj0001_dan", i).ParseLong("tjj0001_dan"); // long 12
					block.tjj0002_dan = query.GetFieldData(block.GetBlockName(), "tjj0002_dan", i).ParseLong("tjj0002_dan"); // long 12
					block.tjj0003_dan = query.GetFieldData(block.GetBlockName(), "tjj0003_dan", i).ParseLong("tjj0003_dan"); // long 12
					block.tjj0004_dan = query.GetFieldData(block.GetBlockName(), "tjj0004_dan", i).ParseLong("tjj0004_dan"); // long 12
					block.tjj0005_dan = query.GetFieldData(block.GetBlockName(), "tjj0005_dan", i).ParseLong("tjj0005_dan"); // long 12
					block.tjj0006_dan = query.GetFieldData(block.GetBlockName(), "tjj0006_dan", i).ParseLong("tjj0006_dan"); // long 12
					block.tjj0007_dan = query.GetFieldData(block.GetBlockName(), "tjj0007_dan", i).ParseLong("tjj0007_dan"); // long 12
					block.tjj0008_dan = query.GetFieldData(block.GetBlockName(), "tjj0008_dan", i).ParseLong("tjj0008_dan"); // long 12
					block.tjj0009_dan = query.GetFieldData(block.GetBlockName(), "tjj0009_dan", i).ParseLong("tjj0009_dan"); // long 12
					block.tjj0010_dan = query.GetFieldData(block.GetBlockName(), "tjj0010_dan", i).ParseLong("tjj0010_dan"); // long 12
					block.tjj0011_dan = query.GetFieldData(block.GetBlockName(), "tjj0011_dan", i).ParseLong("tjj0011_dan"); // long 12
					block.tjj0018_dan = query.GetFieldData(block.GetBlockName(), "tjj0018_dan", i).ParseLong("tjj0018_dan"); // long 12
					block.tjj0016_dan = query.GetFieldData(block.GetBlockName(), "tjj0016_dan", i).ParseLong("tjj0016_dan"); // long 12
					block.tjj0017_dan = query.GetFieldData(block.GetBlockName(), "tjj0017_dan", i).ParseLong("tjj0017_dan"); // long 12

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
			if (date.Length > 8) return false; // char 8
			if (close.ToString().Length > 8) return false; // long 8
			// sign char 1
			if (change.ToString().Length > 8) return false; // long 8
			// diff float 6.2
			if (volume.ToString().Length > 12) return false; // long 12
			if (tjj0000_vol.ToString().Length > 12) return false; // long 12
			if (tjj0001_vol.ToString().Length > 12) return false; // long 12
			if (tjj0002_vol.ToString().Length > 12) return false; // long 12
			if (tjj0003_vol.ToString().Length > 12) return false; // long 12
			if (tjj0004_vol.ToString().Length > 12) return false; // long 12
			if (tjj0005_vol.ToString().Length > 12) return false; // long 12
			if (tjj0006_vol.ToString().Length > 12) return false; // long 12
			if (tjj0007_vol.ToString().Length > 12) return false; // long 12
			if (tjj0008_vol.ToString().Length > 12) return false; // long 12
			if (tjj0009_vol.ToString().Length > 12) return false; // long 12
			if (tjj0010_vol.ToString().Length > 12) return false; // long 12
			if (tjj0011_vol.ToString().Length > 12) return false; // long 12
			if (tjj0018_vol.ToString().Length > 12) return false; // long 12
			if (tjj0016_vol.ToString().Length > 12) return false; // long 12
			if (tjj0017_vol.ToString().Length > 12) return false; // long 12
			if (tjj0000_dan.ToString().Length > 12) return false; // long 12
			if (tjj0001_dan.ToString().Length > 12) return false; // long 12
			if (tjj0002_dan.ToString().Length > 12) return false; // long 12
			if (tjj0003_dan.ToString().Length > 12) return false; // long 12
			if (tjj0004_dan.ToString().Length > 12) return false; // long 12
			if (tjj0005_dan.ToString().Length > 12) return false; // long 12
			if (tjj0006_dan.ToString().Length > 12) return false; // long 12
			if (tjj0007_dan.ToString().Length > 12) return false; // long 12
			if (tjj0008_dan.ToString().Length > 12) return false; // long 12
			if (tjj0009_dan.ToString().Length > 12) return false; // long 12
			if (tjj0010_dan.ToString().Length > 12) return false; // long 12
			if (tjj0011_dan.ToString().Length > 12) return false; // long 12
			if (tjj0018_dan.ToString().Length > 12) return false; // long 12
			if (tjj0016_dan.ToString().Length > 12) return false; // long 12
			if (tjj0017_dan.ToString().Length > 12) return false; // long 12

			return true;
		}
	}

	public partial class XQt1717 : XingQuery
	{
		/// <summary>
		/// t1717
		/// </summary>
		static readonly string _typeName = "t1717";
		/// <summary>
		/// 외인기관종목별동향(t1717)
		/// </summary>
		static readonly string _typeDesc = "외인기관종목별동향(t1717)";
		/// <summary>
		/// 
		/// </summary>
		static readonly string _service = "";
		/// <summary>
		/// A
		/// </summary>
		static readonly string _headType = "A";
		/// <summary>
		/// 
		/// </summary>
		static readonly string _creator = "";
		/// <summary>
		/// 
		/// </summary>
		static readonly string _createdDate = "";
		/// <summary>
		/// true
		/// </summary>
		static readonly bool _attr = true;
		/// <summary>
		/// true
		/// </summary>
		static readonly bool _block = true;
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _encrypt = false;
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _signature = false;

		/// <summary>
		/// t1717
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 외인기관종목별동향(t1717)
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

		public XQt1717() : base("t1717") { }


		public bool SetFields(XQt1717InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "shcode", 0, block.shcode); // char 6
			_xaQuery.SetFieldData(block.GetBlockName(), "gubun", 0, block.gubun.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "fromdt", 0, block.fromdt); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "todt", 0, block.todt); // char 8

			return true;
		}

		public XQt1717OutBlock[] GetBlocks()
		{
			XQt1717OutBlock[] instance = XQt1717OutBlock.ListFromQuery(this);
			return instance;

		}


	}

}
