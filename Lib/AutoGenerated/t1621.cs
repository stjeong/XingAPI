using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1621InBlock : XingBlock
	{
		/// <summary>
		/// t1621InBlock
		/// </summary>
		public const string _blockName = "t1621InBlock";
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
		/// t1621InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1621InBlock
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
		/// 업종코드
		/// </summary>
		[XAQueryFieldAttribute("업종코드", "3")]
		public string upcode;
		/// <summary>
		/// N분
		/// </summary>
		[XAQueryFieldAttribute("N분", "2")]
		public int nmin;
		/// <summary>
		/// 조회건수
		/// </summary>
		[XAQueryFieldAttribute("조회건수", "3")]
		public int cnt;
		/// <summary>
		/// 전일분
		/// </summary>
		[XAQueryFieldAttribute("전일분", "1")]
		public char bgubun;

		public static class F
		{
			/// <summary>
			/// 업종코드
			/// </summary>
			public const string upcode = "upcode";
			/// <summary>
			/// N분
			/// </summary>
			public const string nmin = "nmin";
			/// <summary>
			/// 조회건수
			/// </summary>
			public const string cnt = "cnt";
			/// <summary>
			/// 전일분
			/// </summary>
			public const string bgubun = "bgubun";
		}

		public static string[] AllFields = new string[]
		{
			F.upcode,
			F.nmin,
			F.cnt,
			F.bgubun,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["upcode"] = new XAQueryFieldInfo("char", upcode, upcode, "업종코드", (decimal)3);
			dict["nmin"] = new XAQueryFieldInfo("int", nmin, nmin.ToString("d2"), "N분", (decimal)2);
			dict["cnt"] = new XAQueryFieldInfo("int", cnt, cnt.ToString("d3"), "조회건수", (decimal)3);
			dict["bgubun"] = new XAQueryFieldInfo("char", bgubun, bgubun.ToString(), "전일분", (decimal)1);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "upcode":
					this.upcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "nmin":
					this.nmin = fieldInfo.FieldValue.ParseInt("nmin");
				break;

				case "cnt":
					this.cnt = fieldInfo.FieldValue.ParseInt("cnt");
				break;

				case "bgubun":
					this.bgubun = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public bool VerifyData()
		{
			if (upcode?.Length > 3) return false; // char 3
			// nmin int 2
			// cnt int 3
			// bgubun char 1

			return true;
		}
	}

	public partial class XQt1621OutBlock : XingBlock
	{
		/// <summary>
		/// t1621OutBlock
		/// </summary>
		public const string _blockName = "t1621OutBlock";
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
		/// t1621OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1621OutBlock
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
		/// 개인투자자코드
		/// </summary>
		[XAQueryFieldAttribute("개인투자자코드", "4")]
		public string indcode;
		/// <summary>
		/// 외국인투자자코드
		/// </summary>
		[XAQueryFieldAttribute("외국인투자자코드", "4")]
		public string forcode;
		/// <summary>
		/// 기관계투자자코드
		/// </summary>
		[XAQueryFieldAttribute("기관계투자자코드", "4")]
		public string syscode;
		/// <summary>
		/// 증권투자자코드
		/// </summary>
		[XAQueryFieldAttribute("증권투자자코드", "4")]
		public string stocode;
		/// <summary>
		/// 투신투자자코드
		/// </summary>
		[XAQueryFieldAttribute("투신투자자코드", "4")]
		public string invcode;
		/// <summary>
		/// 은행투자자코드
		/// </summary>
		[XAQueryFieldAttribute("은행투자자코드", "4")]
		public string bancode;
		/// <summary>
		/// 보험투자자코드
		/// </summary>
		[XAQueryFieldAttribute("보험투자자코드", "4")]
		public string inscode;
		/// <summary>
		/// 종금투자자코드
		/// </summary>
		[XAQueryFieldAttribute("종금투자자코드", "4")]
		public string fincode;
		/// <summary>
		/// 기금투자자코드
		/// </summary>
		[XAQueryFieldAttribute("기금투자자코드", "4")]
		public string moncode;
		/// <summary>
		/// 기타투자자코드
		/// </summary>
		[XAQueryFieldAttribute("기타투자자코드", "4")]
		public string etccode;
		/// <summary>
		/// 국가투자자코드
		/// </summary>
		[XAQueryFieldAttribute("국가투자자코드", "4")]
		public string natcode;
		/// <summary>
		/// 사모펀드투자자코드
		/// </summary>
		[XAQueryFieldAttribute("사모펀드투자자코드", "4")]
		public string pefcode;
		/// <summary>
		/// 기준지수코드
		/// </summary>
		[XAQueryFieldAttribute("기준지수코드", "8")]
		public string jisucd;
		/// <summary>
		/// 기준지수명
		/// </summary>
		[XAQueryFieldAttribute("기준지수명", "20")]
		public string jisunm;

		public static class F
		{
			/// <summary>
			/// 개인투자자코드
			/// </summary>
			public const string indcode = "indcode";
			/// <summary>
			/// 외국인투자자코드
			/// </summary>
			public const string forcode = "forcode";
			/// <summary>
			/// 기관계투자자코드
			/// </summary>
			public const string syscode = "syscode";
			/// <summary>
			/// 증권투자자코드
			/// </summary>
			public const string stocode = "stocode";
			/// <summary>
			/// 투신투자자코드
			/// </summary>
			public const string invcode = "invcode";
			/// <summary>
			/// 은행투자자코드
			/// </summary>
			public const string bancode = "bancode";
			/// <summary>
			/// 보험투자자코드
			/// </summary>
			public const string inscode = "inscode";
			/// <summary>
			/// 종금투자자코드
			/// </summary>
			public const string fincode = "fincode";
			/// <summary>
			/// 기금투자자코드
			/// </summary>
			public const string moncode = "moncode";
			/// <summary>
			/// 기타투자자코드
			/// </summary>
			public const string etccode = "etccode";
			/// <summary>
			/// 국가투자자코드
			/// </summary>
			public const string natcode = "natcode";
			/// <summary>
			/// 사모펀드투자자코드
			/// </summary>
			public const string pefcode = "pefcode";
			/// <summary>
			/// 기준지수코드
			/// </summary>
			public const string jisucd = "jisucd";
			/// <summary>
			/// 기준지수명
			/// </summary>
			public const string jisunm = "jisunm";
		}

		public static string[] AllFields = new string[]
		{
			F.indcode,
			F.forcode,
			F.syscode,
			F.stocode,
			F.invcode,
			F.bancode,
			F.inscode,
			F.fincode,
			F.moncode,
			F.etccode,
			F.natcode,
			F.pefcode,
			F.jisucd,
			F.jisunm,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["indcode"] = new XAQueryFieldInfo("char", indcode, indcode, "개인투자자코드", (decimal)4);
			dict["forcode"] = new XAQueryFieldInfo("char", forcode, forcode, "외국인투자자코드", (decimal)4);
			dict["syscode"] = new XAQueryFieldInfo("char", syscode, syscode, "기관계투자자코드", (decimal)4);
			dict["stocode"] = new XAQueryFieldInfo("char", stocode, stocode, "증권투자자코드", (decimal)4);
			dict["invcode"] = new XAQueryFieldInfo("char", invcode, invcode, "투신투자자코드", (decimal)4);
			dict["bancode"] = new XAQueryFieldInfo("char", bancode, bancode, "은행투자자코드", (decimal)4);
			dict["inscode"] = new XAQueryFieldInfo("char", inscode, inscode, "보험투자자코드", (decimal)4);
			dict["fincode"] = new XAQueryFieldInfo("char", fincode, fincode, "종금투자자코드", (decimal)4);
			dict["moncode"] = new XAQueryFieldInfo("char", moncode, moncode, "기금투자자코드", (decimal)4);
			dict["etccode"] = new XAQueryFieldInfo("char", etccode, etccode, "기타투자자코드", (decimal)4);
			dict["natcode"] = new XAQueryFieldInfo("char", natcode, natcode, "국가투자자코드", (decimal)4);
			dict["pefcode"] = new XAQueryFieldInfo("char", pefcode, pefcode, "사모펀드투자자코드", (decimal)4);
			dict["jisucd"] = new XAQueryFieldInfo("char", jisucd, jisucd, "기준지수코드", (decimal)8);
			dict["jisunm"] = new XAQueryFieldInfo("char", jisunm, jisunm, "기준지수명", (decimal)20);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "indcode":
					this.indcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "forcode":
					this.forcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "syscode":
					this.syscode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "stocode":
					this.stocode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "invcode":
					this.invcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "bancode":
					this.bancode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "inscode":
					this.inscode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "fincode":
					this.fincode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "moncode":
					this.moncode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "etccode":
					this.etccode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "natcode":
					this.natcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "pefcode":
					this.pefcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "jisucd":
					this.jisucd = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "jisunm":
					this.jisunm = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt1621OutBlock FromQuery(XQt1621 query)
		{
			XQt1621OutBlock block = new XQt1621OutBlock();
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
				block.indcode = query.GetFieldData(block.GetBlockName(), "indcode", 0).TrimEnd('?'); // char 4
				block.forcode = query.GetFieldData(block.GetBlockName(), "forcode", 0).TrimEnd('?'); // char 4
				block.syscode = query.GetFieldData(block.GetBlockName(), "syscode", 0).TrimEnd('?'); // char 4
				block.stocode = query.GetFieldData(block.GetBlockName(), "stocode", 0).TrimEnd('?'); // char 4
				block.invcode = query.GetFieldData(block.GetBlockName(), "invcode", 0).TrimEnd('?'); // char 4
				block.bancode = query.GetFieldData(block.GetBlockName(), "bancode", 0).TrimEnd('?'); // char 4
				block.inscode = query.GetFieldData(block.GetBlockName(), "inscode", 0).TrimEnd('?'); // char 4
				block.fincode = query.GetFieldData(block.GetBlockName(), "fincode", 0).TrimEnd('?'); // char 4
				block.moncode = query.GetFieldData(block.GetBlockName(), "moncode", 0).TrimEnd('?'); // char 4
				block.etccode = query.GetFieldData(block.GetBlockName(), "etccode", 0).TrimEnd('?'); // char 4
				block.natcode = query.GetFieldData(block.GetBlockName(), "natcode", 0).TrimEnd('?'); // char 4
				block.pefcode = query.GetFieldData(block.GetBlockName(), "pefcode", 0).TrimEnd('?'); // char 4
				block.jisucd = query.GetFieldData(block.GetBlockName(), "jisucd", 0).TrimEnd('?'); // char 8
				block.jisunm = query.GetFieldData(block.GetBlockName(), "jisunm", 0).TrimEnd('?'); // char 20

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (indcode?.Length > 4) return false; // char 4
			if (forcode?.Length > 4) return false; // char 4
			if (syscode?.Length > 4) return false; // char 4
			if (stocode?.Length > 4) return false; // char 4
			if (invcode?.Length > 4) return false; // char 4
			if (bancode?.Length > 4) return false; // char 4
			if (inscode?.Length > 4) return false; // char 4
			if (fincode?.Length > 4) return false; // char 4
			if (moncode?.Length > 4) return false; // char 4
			if (etccode?.Length > 4) return false; // char 4
			if (natcode?.Length > 4) return false; // char 4
			if (pefcode?.Length > 4) return false; // char 4
			if (jisucd?.Length > 8) return false; // char 8
			if (jisunm?.Length > 20) return false; // char 20

			return true;
		}
	}

	public partial class XQt1621OutBlock1 : XingBlock
	{
		/// <summary>
		/// t1621OutBlock1
		/// </summary>
		public const string _blockName = "t1621OutBlock1";
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
		/// t1621OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1621OutBlock1
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
		/// 일자
		/// </summary>
		[XAQueryFieldAttribute("일자", "8")]
		public string date;
		/// <summary>
		/// 시간
		/// </summary>
		[XAQueryFieldAttribute("시간", "6")]
		public string time;
		/// <summary>
		/// 일자시간
		/// </summary>
		[XAQueryFieldAttribute("일자시간", "14")]
		public string datetime;
		/// <summary>
		/// 개인순매수거래량
		/// </summary>
		[XAQueryFieldAttribute("개인순매수거래량", "8")]
		public long indmsvol;
		/// <summary>
		/// 개인순매수거래대금
		/// </summary>
		[XAQueryFieldAttribute("개인순매수거래대금", "12.0")]
		public double indmsamt;
		/// <summary>
		/// 외국인순매수거래량
		/// </summary>
		[XAQueryFieldAttribute("외국인순매수거래량", "8")]
		public long formsvol;
		/// <summary>
		/// 외국인순매수거래대금
		/// </summary>
		[XAQueryFieldAttribute("외국인순매수거래대금", "12.0")]
		public double formsamt;
		/// <summary>
		/// 기관계순매수거래량
		/// </summary>
		[XAQueryFieldAttribute("기관계순매수거래량", "8")]
		public long sysmsvol;
		/// <summary>
		/// 기관계순매수거래대금
		/// </summary>
		[XAQueryFieldAttribute("기관계순매수거래대금", "12.0")]
		public double sysmsamt;
		/// <summary>
		/// 증권순매수거래량
		/// </summary>
		[XAQueryFieldAttribute("증권순매수거래량", "8")]
		public long stomsvol;
		/// <summary>
		/// 증권순매수거래대금
		/// </summary>
		[XAQueryFieldAttribute("증권순매수거래대금", "12.0")]
		public double stomsamt;
		/// <summary>
		/// 투신순매수거래량
		/// </summary>
		[XAQueryFieldAttribute("투신순매수거래량", "8")]
		public long invmsvol;
		/// <summary>
		/// 투신순매수거래대금
		/// </summary>
		[XAQueryFieldAttribute("투신순매수거래대금", "12.0")]
		public double invmsamt;
		/// <summary>
		/// 은행순매수거래량
		/// </summary>
		[XAQueryFieldAttribute("은행순매수거래량", "8")]
		public long banmsvol;
		/// <summary>
		/// 은행순매수거래대금
		/// </summary>
		[XAQueryFieldAttribute("은행순매수거래대금", "12.0")]
		public double banmsamt;
		/// <summary>
		/// 보험순매수거래량
		/// </summary>
		[XAQueryFieldAttribute("보험순매수거래량", "8")]
		public long insmsvol;
		/// <summary>
		/// 보험순매수거래대금
		/// </summary>
		[XAQueryFieldAttribute("보험순매수거래대금", "12.0")]
		public double insmsamt;
		/// <summary>
		/// 종금순매수거래량
		/// </summary>
		[XAQueryFieldAttribute("종금순매수거래량", "8")]
		public long finmsvol;
		/// <summary>
		/// 종금순매수거래대금
		/// </summary>
		[XAQueryFieldAttribute("종금순매수거래대금", "12.0")]
		public double finmsamt;
		/// <summary>
		/// 기금순매수거래량
		/// </summary>
		[XAQueryFieldAttribute("기금순매수거래량", "8")]
		public long monmsvol;
		/// <summary>
		/// 기금순매수거래대금
		/// </summary>
		[XAQueryFieldAttribute("기금순매수거래대금", "12.0")]
		public double monmsamt;
		/// <summary>
		/// 기타순매수거래량
		/// </summary>
		[XAQueryFieldAttribute("기타순매수거래량", "8")]
		public long etcmsvol;
		/// <summary>
		/// 기타순매수거래대금
		/// </summary>
		[XAQueryFieldAttribute("기타순매수거래대금", "12.0")]
		public double etcmsamt;
		/// <summary>
		/// 국가순매수거래량
		/// </summary>
		[XAQueryFieldAttribute("국가순매수거래량", "8")]
		public long natmsvol;
		/// <summary>
		/// 국가순매수거래대금
		/// </summary>
		[XAQueryFieldAttribute("국가순매수거래대금", "12.0")]
		public double natmsamt;
		/// <summary>
		/// 사모펀드순매수거래량
		/// </summary>
		[XAQueryFieldAttribute("사모펀드순매수거래량", "8")]
		public long pefmsvol;
		/// <summary>
		/// 사모펀드순매수거래대금
		/// </summary>
		[XAQueryFieldAttribute("사모펀드순매수거래대금", "12.0")]
		public double pefmsamt;
		/// <summary>
		/// 기준지수
		/// </summary>
		[XAQueryFieldAttribute("기준지수", "6.2")]
		public float upclose;
		/// <summary>
		/// 기준체결거래량
		/// </summary>
		[XAQueryFieldAttribute("기준체결거래량", "8")]
		public long upcvolume;
		/// <summary>
		/// 기준누적거래량
		/// </summary>
		[XAQueryFieldAttribute("기준누적거래량", "12.0")]
		public double upvolume;
		/// <summary>
		/// 기준거래대금
		/// </summary>
		[XAQueryFieldAttribute("기준거래대금", "12.0")]
		public double upvalue;

		public static class F
		{
			/// <summary>
			/// 일자
			/// </summary>
			public const string date = "date";
			/// <summary>
			/// 시간
			/// </summary>
			public const string time = "time";
			/// <summary>
			/// 일자시간
			/// </summary>
			public const string datetime = "datetime";
			/// <summary>
			/// 개인순매수거래량
			/// </summary>
			public const string indmsvol = "indmsvol";
			/// <summary>
			/// 개인순매수거래대금
			/// </summary>
			public const string indmsamt = "indmsamt";
			/// <summary>
			/// 외국인순매수거래량
			/// </summary>
			public const string formsvol = "formsvol";
			/// <summary>
			/// 외국인순매수거래대금
			/// </summary>
			public const string formsamt = "formsamt";
			/// <summary>
			/// 기관계순매수거래량
			/// </summary>
			public const string sysmsvol = "sysmsvol";
			/// <summary>
			/// 기관계순매수거래대금
			/// </summary>
			public const string sysmsamt = "sysmsamt";
			/// <summary>
			/// 증권순매수거래량
			/// </summary>
			public const string stomsvol = "stomsvol";
			/// <summary>
			/// 증권순매수거래대금
			/// </summary>
			public const string stomsamt = "stomsamt";
			/// <summary>
			/// 투신순매수거래량
			/// </summary>
			public const string invmsvol = "invmsvol";
			/// <summary>
			/// 투신순매수거래대금
			/// </summary>
			public const string invmsamt = "invmsamt";
			/// <summary>
			/// 은행순매수거래량
			/// </summary>
			public const string banmsvol = "banmsvol";
			/// <summary>
			/// 은행순매수거래대금
			/// </summary>
			public const string banmsamt = "banmsamt";
			/// <summary>
			/// 보험순매수거래량
			/// </summary>
			public const string insmsvol = "insmsvol";
			/// <summary>
			/// 보험순매수거래대금
			/// </summary>
			public const string insmsamt = "insmsamt";
			/// <summary>
			/// 종금순매수거래량
			/// </summary>
			public const string finmsvol = "finmsvol";
			/// <summary>
			/// 종금순매수거래대금
			/// </summary>
			public const string finmsamt = "finmsamt";
			/// <summary>
			/// 기금순매수거래량
			/// </summary>
			public const string monmsvol = "monmsvol";
			/// <summary>
			/// 기금순매수거래대금
			/// </summary>
			public const string monmsamt = "monmsamt";
			/// <summary>
			/// 기타순매수거래량
			/// </summary>
			public const string etcmsvol = "etcmsvol";
			/// <summary>
			/// 기타순매수거래대금
			/// </summary>
			public const string etcmsamt = "etcmsamt";
			/// <summary>
			/// 국가순매수거래량
			/// </summary>
			public const string natmsvol = "natmsvol";
			/// <summary>
			/// 국가순매수거래대금
			/// </summary>
			public const string natmsamt = "natmsamt";
			/// <summary>
			/// 사모펀드순매수거래량
			/// </summary>
			public const string pefmsvol = "pefmsvol";
			/// <summary>
			/// 사모펀드순매수거래대금
			/// </summary>
			public const string pefmsamt = "pefmsamt";
			/// <summary>
			/// 기준지수
			/// </summary>
			public const string upclose = "upclose";
			/// <summary>
			/// 기준체결거래량
			/// </summary>
			public const string upcvolume = "upcvolume";
			/// <summary>
			/// 기준누적거래량
			/// </summary>
			public const string upvolume = "upvolume";
			/// <summary>
			/// 기준거래대금
			/// </summary>
			public const string upvalue = "upvalue";
		}

		public static string[] AllFields = new string[]
		{
			F.date,
			F.time,
			F.datetime,
			F.indmsvol,
			F.indmsamt,
			F.formsvol,
			F.formsamt,
			F.sysmsvol,
			F.sysmsamt,
			F.stomsvol,
			F.stomsamt,
			F.invmsvol,
			F.invmsamt,
			F.banmsvol,
			F.banmsamt,
			F.insmsvol,
			F.insmsamt,
			F.finmsvol,
			F.finmsamt,
			F.monmsvol,
			F.monmsamt,
			F.etcmsvol,
			F.etcmsamt,
			F.natmsvol,
			F.natmsamt,
			F.pefmsvol,
			F.pefmsamt,
			F.upclose,
			F.upcvolume,
			F.upvolume,
			F.upvalue,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["date"] = new XAQueryFieldInfo("char", date, date, "일자", (decimal)8);
			dict["time"] = new XAQueryFieldInfo("char", time, time, "시간", (decimal)6);
			dict["datetime"] = new XAQueryFieldInfo("char", datetime, datetime, "일자시간", (decimal)14);
			dict["indmsvol"] = new XAQueryFieldInfo("long", indmsvol, indmsvol.ToString("d8"), "개인순매수거래량", (decimal)8);
			dict["indmsamt"] = new XAQueryFieldInfo("double", indmsamt, indmsamt.ToString("000000000000."), "개인순매수거래대금", (decimal)12.0);
			dict["formsvol"] = new XAQueryFieldInfo("long", formsvol, formsvol.ToString("d8"), "외국인순매수거래량", (decimal)8);
			dict["formsamt"] = new XAQueryFieldInfo("double", formsamt, formsamt.ToString("000000000000."), "외국인순매수거래대금", (decimal)12.0);
			dict["sysmsvol"] = new XAQueryFieldInfo("long", sysmsvol, sysmsvol.ToString("d8"), "기관계순매수거래량", (decimal)8);
			dict["sysmsamt"] = new XAQueryFieldInfo("double", sysmsamt, sysmsamt.ToString("000000000000."), "기관계순매수거래대금", (decimal)12.0);
			dict["stomsvol"] = new XAQueryFieldInfo("long", stomsvol, stomsvol.ToString("d8"), "증권순매수거래량", (decimal)8);
			dict["stomsamt"] = new XAQueryFieldInfo("double", stomsamt, stomsamt.ToString("000000000000."), "증권순매수거래대금", (decimal)12.0);
			dict["invmsvol"] = new XAQueryFieldInfo("long", invmsvol, invmsvol.ToString("d8"), "투신순매수거래량", (decimal)8);
			dict["invmsamt"] = new XAQueryFieldInfo("double", invmsamt, invmsamt.ToString("000000000000."), "투신순매수거래대금", (decimal)12.0);
			dict["banmsvol"] = new XAQueryFieldInfo("long", banmsvol, banmsvol.ToString("d8"), "은행순매수거래량", (decimal)8);
			dict["banmsamt"] = new XAQueryFieldInfo("double", banmsamt, banmsamt.ToString("000000000000."), "은행순매수거래대금", (decimal)12.0);
			dict["insmsvol"] = new XAQueryFieldInfo("long", insmsvol, insmsvol.ToString("d8"), "보험순매수거래량", (decimal)8);
			dict["insmsamt"] = new XAQueryFieldInfo("double", insmsamt, insmsamt.ToString("000000000000."), "보험순매수거래대금", (decimal)12.0);
			dict["finmsvol"] = new XAQueryFieldInfo("long", finmsvol, finmsvol.ToString("d8"), "종금순매수거래량", (decimal)8);
			dict["finmsamt"] = new XAQueryFieldInfo("double", finmsamt, finmsamt.ToString("000000000000."), "종금순매수거래대금", (decimal)12.0);
			dict["monmsvol"] = new XAQueryFieldInfo("long", monmsvol, monmsvol.ToString("d8"), "기금순매수거래량", (decimal)8);
			dict["monmsamt"] = new XAQueryFieldInfo("double", monmsamt, monmsamt.ToString("000000000000."), "기금순매수거래대금", (decimal)12.0);
			dict["etcmsvol"] = new XAQueryFieldInfo("long", etcmsvol, etcmsvol.ToString("d8"), "기타순매수거래량", (decimal)8);
			dict["etcmsamt"] = new XAQueryFieldInfo("double", etcmsamt, etcmsamt.ToString("000000000000."), "기타순매수거래대금", (decimal)12.0);
			dict["natmsvol"] = new XAQueryFieldInfo("long", natmsvol, natmsvol.ToString("d8"), "국가순매수거래량", (decimal)8);
			dict["natmsamt"] = new XAQueryFieldInfo("double", natmsamt, natmsamt.ToString("000000000000."), "국가순매수거래대금", (decimal)12.0);
			dict["pefmsvol"] = new XAQueryFieldInfo("long", pefmsvol, pefmsvol.ToString("d8"), "사모펀드순매수거래량", (decimal)8);
			dict["pefmsamt"] = new XAQueryFieldInfo("double", pefmsamt, pefmsamt.ToString("000000000000."), "사모펀드순매수거래대금", (decimal)12.0);
			dict["upclose"] = new XAQueryFieldInfo("float", upclose, upclose.ToString("000000.00"), "기준지수", (decimal)6.2);
			dict["upcvolume"] = new XAQueryFieldInfo("long", upcvolume, upcvolume.ToString("d8"), "기준체결거래량", (decimal)8);
			dict["upvolume"] = new XAQueryFieldInfo("double", upvolume, upvolume.ToString("000000000000."), "기준누적거래량", (decimal)12.0);
			dict["upvalue"] = new XAQueryFieldInfo("double", upvalue, upvalue.ToString("000000000000."), "기준거래대금", (decimal)12.0);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "date":
					this.date = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "time":
					this.time = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "datetime":
					this.datetime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "indmsvol":
					this.indmsvol = fieldInfo.FieldValue.ParseLong("indmsvol");
				break;

				case "indmsamt":
					this.indmsamt = fieldInfo.FieldValue.ParseDouble("indmsamt");
				break;

				case "formsvol":
					this.formsvol = fieldInfo.FieldValue.ParseLong("formsvol");
				break;

				case "formsamt":
					this.formsamt = fieldInfo.FieldValue.ParseDouble("formsamt");
				break;

				case "sysmsvol":
					this.sysmsvol = fieldInfo.FieldValue.ParseLong("sysmsvol");
				break;

				case "sysmsamt":
					this.sysmsamt = fieldInfo.FieldValue.ParseDouble("sysmsamt");
				break;

				case "stomsvol":
					this.stomsvol = fieldInfo.FieldValue.ParseLong("stomsvol");
				break;

				case "stomsamt":
					this.stomsamt = fieldInfo.FieldValue.ParseDouble("stomsamt");
				break;

				case "invmsvol":
					this.invmsvol = fieldInfo.FieldValue.ParseLong("invmsvol");
				break;

				case "invmsamt":
					this.invmsamt = fieldInfo.FieldValue.ParseDouble("invmsamt");
				break;

				case "banmsvol":
					this.banmsvol = fieldInfo.FieldValue.ParseLong("banmsvol");
				break;

				case "banmsamt":
					this.banmsamt = fieldInfo.FieldValue.ParseDouble("banmsamt");
				break;

				case "insmsvol":
					this.insmsvol = fieldInfo.FieldValue.ParseLong("insmsvol");
				break;

				case "insmsamt":
					this.insmsamt = fieldInfo.FieldValue.ParseDouble("insmsamt");
				break;

				case "finmsvol":
					this.finmsvol = fieldInfo.FieldValue.ParseLong("finmsvol");
				break;

				case "finmsamt":
					this.finmsamt = fieldInfo.FieldValue.ParseDouble("finmsamt");
				break;

				case "monmsvol":
					this.monmsvol = fieldInfo.FieldValue.ParseLong("monmsvol");
				break;

				case "monmsamt":
					this.monmsamt = fieldInfo.FieldValue.ParseDouble("monmsamt");
				break;

				case "etcmsvol":
					this.etcmsvol = fieldInfo.FieldValue.ParseLong("etcmsvol");
				break;

				case "etcmsamt":
					this.etcmsamt = fieldInfo.FieldValue.ParseDouble("etcmsamt");
				break;

				case "natmsvol":
					this.natmsvol = fieldInfo.FieldValue.ParseLong("natmsvol");
				break;

				case "natmsamt":
					this.natmsamt = fieldInfo.FieldValue.ParseDouble("natmsamt");
				break;

				case "pefmsvol":
					this.pefmsvol = fieldInfo.FieldValue.ParseLong("pefmsvol");
				break;

				case "pefmsamt":
					this.pefmsamt = fieldInfo.FieldValue.ParseDouble("pefmsamt");
				break;

				case "upclose":
					this.upclose = fieldInfo.FieldValue.ParseFloat("upclose");
				break;

				case "upcvolume":
					this.upcvolume = fieldInfo.FieldValue.ParseLong("upcvolume");
				break;

				case "upvolume":
					this.upvolume = fieldInfo.FieldValue.ParseDouble("upvolume");
				break;

				case "upvalue":
					this.upvalue = fieldInfo.FieldValue.ParseDouble("upvalue");
				break;


			}
		}

		public static XQt1621OutBlock1[] ListFromQuery(XQt1621 query)
		{
			int count = query.GetBlockCount(XQt1621OutBlock1.BlockName);
			List<XQt1621OutBlock1> list = new List<XQt1621OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1621OutBlock1 block = new XQt1621OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.date = query.GetFieldData(block.GetBlockName(), "date", i).TrimEnd('?'); // char 8
					block.time = query.GetFieldData(block.GetBlockName(), "time", i).TrimEnd('?'); // char 6
					block.datetime = query.GetFieldData(block.GetBlockName(), "datetime", i).TrimEnd('?'); // char 14
					block.indmsvol = query.GetFieldData(block.GetBlockName(), "indmsvol", i).ParseLong("indmsvol"); // long 8
					block.indmsamt = query.GetFieldData(block.GetBlockName(), "indmsamt", i).ParseDouble("indmsamt"); // double 12.0
					block.formsvol = query.GetFieldData(block.GetBlockName(), "formsvol", i).ParseLong("formsvol"); // long 8
					block.formsamt = query.GetFieldData(block.GetBlockName(), "formsamt", i).ParseDouble("formsamt"); // double 12.0
					block.sysmsvol = query.GetFieldData(block.GetBlockName(), "sysmsvol", i).ParseLong("sysmsvol"); // long 8
					block.sysmsamt = query.GetFieldData(block.GetBlockName(), "sysmsamt", i).ParseDouble("sysmsamt"); // double 12.0
					block.stomsvol = query.GetFieldData(block.GetBlockName(), "stomsvol", i).ParseLong("stomsvol"); // long 8
					block.stomsamt = query.GetFieldData(block.GetBlockName(), "stomsamt", i).ParseDouble("stomsamt"); // double 12.0
					block.invmsvol = query.GetFieldData(block.GetBlockName(), "invmsvol", i).ParseLong("invmsvol"); // long 8
					block.invmsamt = query.GetFieldData(block.GetBlockName(), "invmsamt", i).ParseDouble("invmsamt"); // double 12.0
					block.banmsvol = query.GetFieldData(block.GetBlockName(), "banmsvol", i).ParseLong("banmsvol"); // long 8
					block.banmsamt = query.GetFieldData(block.GetBlockName(), "banmsamt", i).ParseDouble("banmsamt"); // double 12.0
					block.insmsvol = query.GetFieldData(block.GetBlockName(), "insmsvol", i).ParseLong("insmsvol"); // long 8
					block.insmsamt = query.GetFieldData(block.GetBlockName(), "insmsamt", i).ParseDouble("insmsamt"); // double 12.0
					block.finmsvol = query.GetFieldData(block.GetBlockName(), "finmsvol", i).ParseLong("finmsvol"); // long 8
					block.finmsamt = query.GetFieldData(block.GetBlockName(), "finmsamt", i).ParseDouble("finmsamt"); // double 12.0
					block.monmsvol = query.GetFieldData(block.GetBlockName(), "monmsvol", i).ParseLong("monmsvol"); // long 8
					block.monmsamt = query.GetFieldData(block.GetBlockName(), "monmsamt", i).ParseDouble("monmsamt"); // double 12.0
					block.etcmsvol = query.GetFieldData(block.GetBlockName(), "etcmsvol", i).ParseLong("etcmsvol"); // long 8
					block.etcmsamt = query.GetFieldData(block.GetBlockName(), "etcmsamt", i).ParseDouble("etcmsamt"); // double 12.0
					block.natmsvol = query.GetFieldData(block.GetBlockName(), "natmsvol", i).ParseLong("natmsvol"); // long 8
					block.natmsamt = query.GetFieldData(block.GetBlockName(), "natmsamt", i).ParseDouble("natmsamt"); // double 12.0
					block.pefmsvol = query.GetFieldData(block.GetBlockName(), "pefmsvol", i).ParseLong("pefmsvol"); // long 8
					block.pefmsamt = query.GetFieldData(block.GetBlockName(), "pefmsamt", i).ParseDouble("pefmsamt"); // double 12.0
					block.upclose = query.GetFieldData(block.GetBlockName(), "upclose", i).ParseFloat("upclose"); // float 6.2
					block.upcvolume = query.GetFieldData(block.GetBlockName(), "upcvolume", i).ParseLong("upcvolume"); // long 8
					block.upvolume = query.GetFieldData(block.GetBlockName(), "upvolume", i).ParseDouble("upvolume"); // double 12.0
					block.upvalue = query.GetFieldData(block.GetBlockName(), "upvalue", i).ParseDouble("upvalue"); // double 12.0

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
			if (date?.Length > 8) return false; // char 8
			if (time?.Length > 6) return false; // char 6
			if (datetime?.Length > 14) return false; // char 14
			if (indmsvol.ToString().Length > 8) return false; // long 8
			// indmsamt double 12.0
			if (formsvol.ToString().Length > 8) return false; // long 8
			// formsamt double 12.0
			if (sysmsvol.ToString().Length > 8) return false; // long 8
			// sysmsamt double 12.0
			if (stomsvol.ToString().Length > 8) return false; // long 8
			// stomsamt double 12.0
			if (invmsvol.ToString().Length > 8) return false; // long 8
			// invmsamt double 12.0
			if (banmsvol.ToString().Length > 8) return false; // long 8
			// banmsamt double 12.0
			if (insmsvol.ToString().Length > 8) return false; // long 8
			// insmsamt double 12.0
			if (finmsvol.ToString().Length > 8) return false; // long 8
			// finmsamt double 12.0
			if (monmsvol.ToString().Length > 8) return false; // long 8
			// monmsamt double 12.0
			if (etcmsvol.ToString().Length > 8) return false; // long 8
			// etcmsamt double 12.0
			if (natmsvol.ToString().Length > 8) return false; // long 8
			// natmsamt double 12.0
			if (pefmsvol.ToString().Length > 8) return false; // long 8
			// pefmsamt double 12.0
			// upclose float 6.2
			if (upcvolume.ToString().Length > 8) return false; // long 8
			// upvolume double 12.0
			// upvalue double 12.0

			return true;
		}
	}

	/// <summary>
	/// 업종별분별투자자매매동향(챠트용)
	/// </summary>
	public partial class XQt1621 : XingQuery
	{
		/// <summary>
		/// t1621
		/// </summary>
		public const string _typeName = "t1621";
		/// <summary>
		/// 업종별분별투자자매매동향(챠트용)
		/// </summary>
		public const string _typeDesc = "업종별분별투자자매매동향(챠트용)";
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
		/// t1621
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 업종별분별투자자매매동향(챠트용)
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
		/// 업종별분별투자자매매동향(챠트용)
		/// </summary>
		public XQt1621() : base("t1621") { }


		public class XQAllOutBlocks
		{
			public XQt1621OutBlock OutBlock { get; internal set; }
			public XQt1621OutBlock1[] OutBlock1 { get; internal set; }
		}

		public static XQAllOutBlocks Get(string upcode = default,int nmin = default,int cnt = default,char bgubun = default)
		{
			using (XQt1621 instance = new XQt1621())
			{
				instance.SetFieldData(XQt1621InBlock.BlockName, XQt1621InBlock.F.upcode, 0, upcode); // char 3
				instance.SetFieldData(XQt1621InBlock.BlockName, XQt1621InBlock.F.nmin, 0, nmin.ToString("d2")); // int 2
				instance.SetFieldData(XQt1621InBlock.BlockName, XQt1621InBlock.F.cnt, 0, cnt.ToString("d3")); // int 3
				instance.SetFieldData(XQt1621InBlock.BlockName, XQt1621InBlock.F.bgubun, 0, bgubun.ToString()); // char 1

				if (instance.Request() < 0)
				{
					return null;
				}

				XQAllOutBlocks results = new XQAllOutBlocks();
				results.OutBlock = instance.GetBlock();
				if (results.OutBlock.IsValidData == false)
				{
					return null;
				}

				results.OutBlock1 = instance.GetBlock1s();
				return results;
			}
		}

		public bool SetBlock(XQt1621InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "upcode", 0, block.upcode); // char 3
			_xaQuery.SetFieldData(block.GetBlockName(), "nmin", 0, block.nmin.ToString("d2")); // int 2
			_xaQuery.SetFieldData(block.GetBlockName(), "cnt", 0, block.cnt.ToString("d3")); // int 3
			_xaQuery.SetFieldData(block.GetBlockName(), "bgubun", 0, block.bgubun.ToString()); // char 1

			return true;
		}

		public XQt1621OutBlock GetBlock()
		{
			XQt1621OutBlock instance = XQt1621OutBlock.FromQuery(this);
			return instance;

		}

		public XQt1621OutBlock1[] GetBlock1s()
		{
			XQt1621OutBlock1[] instance = XQt1621OutBlock1.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt1621OutBlock),
			typeof(XQt1621OutBlock1),

		};

	}

}
