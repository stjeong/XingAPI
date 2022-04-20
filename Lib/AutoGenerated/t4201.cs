using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt4201InBlock : XingBlock
	{
		/// <summary>
		/// t4201InBlock
		/// </summary>
		public const string _blockName = "t4201InBlock";
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
		/// t4201InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t4201InBlock
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
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("shcode", "단축코드", "char", "6")]
		public string shcode;
		/// <summary>
		/// 주기구분(0:틱1:분2:일3:주4:월)
		/// </summary>
		[XAQueryFieldAttribute("gubun", "주기구분(0:틱1:분2:일3:주4:월)", "char", "1")]
		public char gubun;
		/// <summary>
		/// 틱개수
		/// </summary>
		[XAQueryFieldAttribute("ncnt", "틱개수", "long", "4")]
		public long ncnt;
		/// <summary>
		/// 건수(500건이하)
		/// </summary>
		[XAQueryFieldAttribute("qrycnt", "건수(500건이하)", "long", "4")]
		public long qrycnt;
		/// <summary>
		/// 당일구분(0:전체1:당일만)
		/// </summary>
		[XAQueryFieldAttribute("tdgb", "당일구분(0:전체1:당일만)", "char", "1")]
		public char tdgb;
		/// <summary>
		/// 시작일자
		/// </summary>
		[XAQueryFieldAttribute("sdate", "시작일자", "char", "8")]
		public string sdate;
		/// <summary>
		/// 종료일자
		/// </summary>
		[XAQueryFieldAttribute("edate", "종료일자", "char", "8")]
		public string edate;
		/// <summary>
		/// 연속일자
		/// </summary>
		[XAQueryFieldAttribute("cts_date", "연속일자", "char", "8")]
		public string cts_date;
		/// <summary>
		/// 연속시간
		/// </summary>
		[XAQueryFieldAttribute("cts_time", "연속시간", "char", "10")]
		public string cts_time;
		/// <summary>
		/// 연속당일구분(0:연속전체1:연속당일만2:연속전일만)
		/// </summary>
		[XAQueryFieldAttribute("cts_daygb", "연속당일구분(0:연속전체1:연속당일만2:연속전일만)", "char", "1")]
		public char cts_daygb;

		public static class F
		{
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 주기구분(0:틱1:분2:일3:주4:월)
			/// </summary>
			public const string gubun = "gubun";
			/// <summary>
			/// 틱개수
			/// </summary>
			public const string ncnt = "ncnt";
			/// <summary>
			/// 건수(500건이하)
			/// </summary>
			public const string qrycnt = "qrycnt";
			/// <summary>
			/// 당일구분(0:전체1:당일만)
			/// </summary>
			public const string tdgb = "tdgb";
			/// <summary>
			/// 시작일자
			/// </summary>
			public const string sdate = "sdate";
			/// <summary>
			/// 종료일자
			/// </summary>
			public const string edate = "edate";
			/// <summary>
			/// 연속일자
			/// </summary>
			public const string cts_date = "cts_date";
			/// <summary>
			/// 연속시간
			/// </summary>
			public const string cts_time = "cts_time";
			/// <summary>
			/// 연속당일구분(0:연속전체1:연속당일만2:연속전일만)
			/// </summary>
			public const string cts_daygb = "cts_daygb";
		}

		public static string[] AllFields = new string[]
		{
			F.shcode,
			F.gubun,
			F.ncnt,
			F.qrycnt,
			F.tdgb,
			F.sdate,
			F.edate,
			F.cts_date,
			F.cts_time,
			F.cts_daygb,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)6);
			dict["gubun"] = new XAQueryFieldInfo("char", gubun, gubun.ToString(), "주기구분(0:틱1:분2:일3:주4:월)", (decimal)1);
			dict["ncnt"] = new XAQueryFieldInfo("long", ncnt, ncnt.ToString("d4"), "틱개수", (decimal)4);
			dict["qrycnt"] = new XAQueryFieldInfo("long", qrycnt, qrycnt.ToString("d4"), "건수(500건이하)", (decimal)4);
			dict["tdgb"] = new XAQueryFieldInfo("char", tdgb, tdgb.ToString(), "당일구분(0:전체1:당일만)", (decimal)1);
			dict["sdate"] = new XAQueryFieldInfo("char", sdate, sdate, "시작일자", (decimal)8);
			dict["edate"] = new XAQueryFieldInfo("char", edate, edate, "종료일자", (decimal)8);
			dict["cts_date"] = new XAQueryFieldInfo("char", cts_date, cts_date, "연속일자", (decimal)8);
			dict["cts_time"] = new XAQueryFieldInfo("char", cts_time, cts_time, "연속시간", (decimal)10);
			dict["cts_daygb"] = new XAQueryFieldInfo("char", cts_daygb, cts_daygb.ToString(), "연속당일구분(0:연속전체1:연속당일만2:연속전일만)", (decimal)1);

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

				case "ncnt":
					this.ncnt = fieldInfo.FieldValue.ParseLong("ncnt");
				break;

				case "qrycnt":
					this.qrycnt = fieldInfo.FieldValue.ParseLong("qrycnt");
				break;

				case "tdgb":
					this.tdgb = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "sdate":
					this.sdate = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "edate":
					this.edate = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cts_date":
					this.cts_date = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cts_time":
					this.cts_time = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cts_daygb":
					this.cts_daygb = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public bool VerifyData()
		{
			if (shcode?.Length > 6) return false; // char 6
			// gubun char 1
			if (ncnt.ToString().Length > 4) return false; // long 4
			if (qrycnt.ToString().Length > 4) return false; // long 4
			// tdgb char 1
			if (sdate?.Length > 8) return false; // char 8
			if (edate?.Length > 8) return false; // char 8
			if (cts_date?.Length > 8) return false; // char 8
			if (cts_time?.Length > 10) return false; // char 10
			// cts_daygb char 1

			return true;
		}

		public void CopyTo(XQt4201InBlock block)
		{
			block.shcode = this.shcode;
			block.gubun = this.gubun;
			block.ncnt = this.ncnt;
			block.qrycnt = this.qrycnt;
			block.tdgb = this.tdgb;
			block.sdate = this.sdate;
			block.edate = this.edate;
			block.cts_date = this.cts_date;
			block.cts_time = this.cts_time;
			block.cts_daygb = this.cts_daygb;

		}
	}

	public partial class XQt4201OutBlock : XingBlock
	{
		/// <summary>
		/// t4201OutBlock
		/// </summary>
		public const string _blockName = "t4201OutBlock";
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
		/// t4201OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t4201OutBlock
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
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("shcode", "단축코드", "char", "6")]
		public string shcode;
		/// <summary>
		/// 전일시가
		/// </summary>
		[XAQueryFieldAttribute("jisiga", "전일시가", "long", "8")]
		public long jisiga;
		/// <summary>
		/// 전일고가
		/// </summary>
		[XAQueryFieldAttribute("jihigh", "전일고가", "long", "8")]
		public long jihigh;
		/// <summary>
		/// 전일저가
		/// </summary>
		[XAQueryFieldAttribute("jilow", "전일저가", "long", "8")]
		public long jilow;
		/// <summary>
		/// 전일종가
		/// </summary>
		[XAQueryFieldAttribute("jiclose", "전일종가", "long", "8")]
		public long jiclose;
		/// <summary>
		/// 전일거래량
		/// </summary>
		[XAQueryFieldAttribute("jivolume", "전일거래량", "long", "12")]
		public long jivolume;
		/// <summary>
		/// 당일시가
		/// </summary>
		[XAQueryFieldAttribute("disiga", "당일시가", "long", "8")]
		public long disiga;
		/// <summary>
		/// 당일고가
		/// </summary>
		[XAQueryFieldAttribute("dihigh", "당일고가", "long", "8")]
		public long dihigh;
		/// <summary>
		/// 당일저가
		/// </summary>
		[XAQueryFieldAttribute("dilow", "당일저가", "long", "8")]
		public long dilow;
		/// <summary>
		/// 당일종가
		/// </summary>
		[XAQueryFieldAttribute("diclose", "당일종가", "long", "8")]
		public long diclose;
		/// <summary>
		/// 상한가
		/// </summary>
		[XAQueryFieldAttribute("highend", "상한가", "long", "8")]
		public long highend;
		/// <summary>
		/// 하한가
		/// </summary>
		[XAQueryFieldAttribute("lowend", "하한가", "long", "8")]
		public long lowend;
		/// <summary>
		/// 연속일자
		/// </summary>
		[XAQueryFieldAttribute("cts_date", "연속일자", "char", "8")]
		public string cts_date;
		/// <summary>
		/// 연속시간
		/// </summary>
		[XAQueryFieldAttribute("cts_time", "연속시간", "char", "10")]
		public string cts_time;
		/// <summary>
		/// 연속당일구분
		/// </summary>
		[XAQueryFieldAttribute("cts_daygb", "연속당일구분", "char", "1")]
		public char cts_daygb;

		public static class F
		{
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 전일시가
			/// </summary>
			public const string jisiga = "jisiga";
			/// <summary>
			/// 전일고가
			/// </summary>
			public const string jihigh = "jihigh";
			/// <summary>
			/// 전일저가
			/// </summary>
			public const string jilow = "jilow";
			/// <summary>
			/// 전일종가
			/// </summary>
			public const string jiclose = "jiclose";
			/// <summary>
			/// 전일거래량
			/// </summary>
			public const string jivolume = "jivolume";
			/// <summary>
			/// 당일시가
			/// </summary>
			public const string disiga = "disiga";
			/// <summary>
			/// 당일고가
			/// </summary>
			public const string dihigh = "dihigh";
			/// <summary>
			/// 당일저가
			/// </summary>
			public const string dilow = "dilow";
			/// <summary>
			/// 당일종가
			/// </summary>
			public const string diclose = "diclose";
			/// <summary>
			/// 상한가
			/// </summary>
			public const string highend = "highend";
			/// <summary>
			/// 하한가
			/// </summary>
			public const string lowend = "lowend";
			/// <summary>
			/// 연속일자
			/// </summary>
			public const string cts_date = "cts_date";
			/// <summary>
			/// 연속시간
			/// </summary>
			public const string cts_time = "cts_time";
			/// <summary>
			/// 연속당일구분
			/// </summary>
			public const string cts_daygb = "cts_daygb";
		}

		public static string[] AllFields = new string[]
		{
			F.shcode,
			F.jisiga,
			F.jihigh,
			F.jilow,
			F.jiclose,
			F.jivolume,
			F.disiga,
			F.dihigh,
			F.dilow,
			F.diclose,
			F.highend,
			F.lowend,
			F.cts_date,
			F.cts_time,
			F.cts_daygb,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)6);
			dict["jisiga"] = new XAQueryFieldInfo("long", jisiga, jisiga.ToString("d8"), "전일시가", (decimal)8);
			dict["jihigh"] = new XAQueryFieldInfo("long", jihigh, jihigh.ToString("d8"), "전일고가", (decimal)8);
			dict["jilow"] = new XAQueryFieldInfo("long", jilow, jilow.ToString("d8"), "전일저가", (decimal)8);
			dict["jiclose"] = new XAQueryFieldInfo("long", jiclose, jiclose.ToString("d8"), "전일종가", (decimal)8);
			dict["jivolume"] = new XAQueryFieldInfo("long", jivolume, jivolume.ToString("d12"), "전일거래량", (decimal)12);
			dict["disiga"] = new XAQueryFieldInfo("long", disiga, disiga.ToString("d8"), "당일시가", (decimal)8);
			dict["dihigh"] = new XAQueryFieldInfo("long", dihigh, dihigh.ToString("d8"), "당일고가", (decimal)8);
			dict["dilow"] = new XAQueryFieldInfo("long", dilow, dilow.ToString("d8"), "당일저가", (decimal)8);
			dict["diclose"] = new XAQueryFieldInfo("long", diclose, diclose.ToString("d8"), "당일종가", (decimal)8);
			dict["highend"] = new XAQueryFieldInfo("long", highend, highend.ToString("d8"), "상한가", (decimal)8);
			dict["lowend"] = new XAQueryFieldInfo("long", lowend, lowend.ToString("d8"), "하한가", (decimal)8);
			dict["cts_date"] = new XAQueryFieldInfo("char", cts_date, cts_date, "연속일자", (decimal)8);
			dict["cts_time"] = new XAQueryFieldInfo("char", cts_time, cts_time, "연속시간", (decimal)10);
			dict["cts_daygb"] = new XAQueryFieldInfo("char", cts_daygb, cts_daygb.ToString(), "연속당일구분", (decimal)1);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "jisiga":
					this.jisiga = fieldInfo.FieldValue.ParseLong("jisiga");
				break;

				case "jihigh":
					this.jihigh = fieldInfo.FieldValue.ParseLong("jihigh");
				break;

				case "jilow":
					this.jilow = fieldInfo.FieldValue.ParseLong("jilow");
				break;

				case "jiclose":
					this.jiclose = fieldInfo.FieldValue.ParseLong("jiclose");
				break;

				case "jivolume":
					this.jivolume = fieldInfo.FieldValue.ParseLong("jivolume");
				break;

				case "disiga":
					this.disiga = fieldInfo.FieldValue.ParseLong("disiga");
				break;

				case "dihigh":
					this.dihigh = fieldInfo.FieldValue.ParseLong("dihigh");
				break;

				case "dilow":
					this.dilow = fieldInfo.FieldValue.ParseLong("dilow");
				break;

				case "diclose":
					this.diclose = fieldInfo.FieldValue.ParseLong("diclose");
				break;

				case "highend":
					this.highend = fieldInfo.FieldValue.ParseLong("highend");
				break;

				case "lowend":
					this.lowend = fieldInfo.FieldValue.ParseLong("lowend");
				break;

				case "cts_date":
					this.cts_date = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cts_time":
					this.cts_time = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cts_daygb":
					this.cts_daygb = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public static XQt4201OutBlock FromQuery(XQt4201 query)
		{
			XQt4201OutBlock block = new XQt4201OutBlock();
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
				block.shcode = query.GetFieldData(block.GetBlockName(), "shcode", 0).TrimEnd('?'); // char 6
				block.jisiga = query.GetFieldData(block.GetBlockName(), "jisiga", 0).ParseLong("jisiga"); // long 8
				block.jihigh = query.GetFieldData(block.GetBlockName(), "jihigh", 0).ParseLong("jihigh"); // long 8
				block.jilow = query.GetFieldData(block.GetBlockName(), "jilow", 0).ParseLong("jilow"); // long 8
				block.jiclose = query.GetFieldData(block.GetBlockName(), "jiclose", 0).ParseLong("jiclose"); // long 8
				block.jivolume = query.GetFieldData(block.GetBlockName(), "jivolume", 0).ParseLong("jivolume"); // long 12
				block.disiga = query.GetFieldData(block.GetBlockName(), "disiga", 0).ParseLong("disiga"); // long 8
				block.dihigh = query.GetFieldData(block.GetBlockName(), "dihigh", 0).ParseLong("dihigh"); // long 8
				block.dilow = query.GetFieldData(block.GetBlockName(), "dilow", 0).ParseLong("dilow"); // long 8
				block.diclose = query.GetFieldData(block.GetBlockName(), "diclose", 0).ParseLong("diclose"); // long 8
				block.highend = query.GetFieldData(block.GetBlockName(), "highend", 0).ParseLong("highend"); // long 8
				block.lowend = query.GetFieldData(block.GetBlockName(), "lowend", 0).ParseLong("lowend"); // long 8
				block.cts_date = query.GetFieldData(block.GetBlockName(), "cts_date", 0).TrimEnd('?'); // char 8
				block.cts_time = query.GetFieldData(block.GetBlockName(), "cts_time", 0).TrimEnd('?'); // char 10
				block.cts_daygb = query.GetFieldData(block.GetBlockName(), "cts_daygb", 0).FirstOrDefault(); // char 1

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (shcode?.Length > 6) return false; // char 6
			if (jisiga.ToString().Length > 8) return false; // long 8
			if (jihigh.ToString().Length > 8) return false; // long 8
			if (jilow.ToString().Length > 8) return false; // long 8
			if (jiclose.ToString().Length > 8) return false; // long 8
			if (jivolume.ToString().Length > 12) return false; // long 12
			if (disiga.ToString().Length > 8) return false; // long 8
			if (dihigh.ToString().Length > 8) return false; // long 8
			if (dilow.ToString().Length > 8) return false; // long 8
			if (diclose.ToString().Length > 8) return false; // long 8
			if (highend.ToString().Length > 8) return false; // long 8
			if (lowend.ToString().Length > 8) return false; // long 8
			if (cts_date?.Length > 8) return false; // char 8
			if (cts_time?.Length > 10) return false; // char 10
			// cts_daygb char 1

			return true;
		}

		public void CopyTo(XQt4201OutBlock block)
		{
			block.shcode = this.shcode;
			block.jisiga = this.jisiga;
			block.jihigh = this.jihigh;
			block.jilow = this.jilow;
			block.jiclose = this.jiclose;
			block.jivolume = this.jivolume;
			block.disiga = this.disiga;
			block.dihigh = this.dihigh;
			block.dilow = this.dilow;
			block.diclose = this.diclose;
			block.highend = this.highend;
			block.lowend = this.lowend;
			block.cts_date = this.cts_date;
			block.cts_time = this.cts_time;
			block.cts_daygb = this.cts_daygb;

		}
	}

	public partial class XQt4201OutBlock1 : XingBlock
	{
		/// <summary>
		/// t4201OutBlock1
		/// </summary>
		public const string _blockName = "t4201OutBlock1";
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
		/// t4201OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t4201OutBlock1
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
		/// 날짜
		/// </summary>
		[XAQueryFieldAttribute("date", "날짜", "char", "8")]
		public string date;
		/// <summary>
		/// 시간
		/// </summary>
		[XAQueryFieldAttribute("time", "시간", "char", "10")]
		public string time;
		/// <summary>
		/// 시가
		/// </summary>
		[XAQueryFieldAttribute("open", "시가", "long", "8")]
		public long open;
		/// <summary>
		/// 고가
		/// </summary>
		[XAQueryFieldAttribute("high", "고가", "long", "8")]
		public long high;
		/// <summary>
		/// 저가
		/// </summary>
		[XAQueryFieldAttribute("low", "저가", "long", "8")]
		public long low;
		/// <summary>
		/// 종가
		/// </summary>
		[XAQueryFieldAttribute("close", "종가", "long", "8")]
		public long close;
		/// <summary>
		/// 거래량
		/// </summary>
		[XAQueryFieldAttribute("jdiff_vol", "거래량", "long", "12")]
		public long jdiff_vol;
		/// <summary>
		/// 거래대금
		/// </summary>
		[XAQueryFieldAttribute("value", "거래대금", "long", "12")]
		public long value;
		/// <summary>
		/// 수정구분
		/// </summary>
		[XAQueryFieldAttribute("jongchk", "수정구분", "long", "13")]
		public long jongchk;
		/// <summary>
		/// 수정비율
		/// </summary>
		[XAQueryFieldAttribute("rate", "수정비율", "double", "6.2")]
		public double rate;
		/// <summary>
		/// 수정주가반영항목
		/// </summary>
		[XAQueryFieldAttribute("pricechk", "수정주가반영항목", "long", "13")]
		public long pricechk;
		/// <summary>
		/// 수정비율반영거래대금
		/// </summary>
		[XAQueryFieldAttribute("ratevalue", "수정비율반영거래대금", "long", "12")]
		public long ratevalue;

		public static class F
		{
			/// <summary>
			/// 날짜
			/// </summary>
			public const string date = "date";
			/// <summary>
			/// 시간
			/// </summary>
			public const string time = "time";
			/// <summary>
			/// 시가
			/// </summary>
			public const string open = "open";
			/// <summary>
			/// 고가
			/// </summary>
			public const string high = "high";
			/// <summary>
			/// 저가
			/// </summary>
			public const string low = "low";
			/// <summary>
			/// 종가
			/// </summary>
			public const string close = "close";
			/// <summary>
			/// 거래량
			/// </summary>
			public const string jdiff_vol = "jdiff_vol";
			/// <summary>
			/// 거래대금
			/// </summary>
			public const string value = "value";
			/// <summary>
			/// 수정구분
			/// </summary>
			public const string jongchk = "jongchk";
			/// <summary>
			/// 수정비율
			/// </summary>
			public const string rate = "rate";
			/// <summary>
			/// 수정주가반영항목
			/// </summary>
			public const string pricechk = "pricechk";
			/// <summary>
			/// 수정비율반영거래대금
			/// </summary>
			public const string ratevalue = "ratevalue";
		}

		public static string[] AllFields = new string[]
		{
			F.date,
			F.time,
			F.open,
			F.high,
			F.low,
			F.close,
			F.jdiff_vol,
			F.value,
			F.jongchk,
			F.rate,
			F.pricechk,
			F.ratevalue,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["date"] = new XAQueryFieldInfo("char", date, date, "날짜", (decimal)8);
			dict["time"] = new XAQueryFieldInfo("char", time, time, "시간", (decimal)10);
			dict["open"] = new XAQueryFieldInfo("long", open, open.ToString("d8"), "시가", (decimal)8);
			dict["high"] = new XAQueryFieldInfo("long", high, high.ToString("d8"), "고가", (decimal)8);
			dict["low"] = new XAQueryFieldInfo("long", low, low.ToString("d8"), "저가", (decimal)8);
			dict["close"] = new XAQueryFieldInfo("long", close, close.ToString("d8"), "종가", (decimal)8);
			dict["jdiff_vol"] = new XAQueryFieldInfo("long", jdiff_vol, jdiff_vol.ToString("d12"), "거래량", (decimal)12);
			dict["value"] = new XAQueryFieldInfo("long", value, value.ToString("d12"), "거래대금", (decimal)12);
			dict["jongchk"] = new XAQueryFieldInfo("long", jongchk, jongchk.ToString("d13"), "수정구분", (decimal)13);
			dict["rate"] = new XAQueryFieldInfo("double", rate, rate.ToString("000000.00"), "수정비율", (decimal)6.2);
			dict["pricechk"] = new XAQueryFieldInfo("long", pricechk, pricechk.ToString("d13"), "수정주가반영항목", (decimal)13);
			dict["ratevalue"] = new XAQueryFieldInfo("long", ratevalue, ratevalue.ToString("d12"), "수정비율반영거래대금", (decimal)12);

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

				case "open":
					this.open = fieldInfo.FieldValue.ParseLong("open");
				break;

				case "high":
					this.high = fieldInfo.FieldValue.ParseLong("high");
				break;

				case "low":
					this.low = fieldInfo.FieldValue.ParseLong("low");
				break;

				case "close":
					this.close = fieldInfo.FieldValue.ParseLong("close");
				break;

				case "jdiff_vol":
					this.jdiff_vol = fieldInfo.FieldValue.ParseLong("jdiff_vol");
				break;

				case "value":
					this.value = fieldInfo.FieldValue.ParseLong("value");
				break;

				case "jongchk":
					this.jongchk = fieldInfo.FieldValue.ParseLong("jongchk");
				break;

				case "rate":
					this.rate = fieldInfo.FieldValue.ParseDouble("rate");
				break;

				case "pricechk":
					this.pricechk = fieldInfo.FieldValue.ParseLong("pricechk");
				break;

				case "ratevalue":
					this.ratevalue = fieldInfo.FieldValue.ParseLong("ratevalue");
				break;


			}
		}

		public static XQt4201OutBlock1[] ListFromQuery(XQt4201 query)
		{
			int count = query.GetBlockCount(XQt4201OutBlock1.BlockName);
			List<XQt4201OutBlock1> list = new List<XQt4201OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt4201OutBlock1 block = new XQt4201OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.date = query.GetFieldData(block.GetBlockName(), "date", i).TrimEnd('?'); // char 8
					block.time = query.GetFieldData(block.GetBlockName(), "time", i).TrimEnd('?'); // char 10
					block.open = query.GetFieldData(block.GetBlockName(), "open", i).ParseLong("open"); // long 8
					block.high = query.GetFieldData(block.GetBlockName(), "high", i).ParseLong("high"); // long 8
					block.low = query.GetFieldData(block.GetBlockName(), "low", i).ParseLong("low"); // long 8
					block.close = query.GetFieldData(block.GetBlockName(), "close", i).ParseLong("close"); // long 8
					block.jdiff_vol = query.GetFieldData(block.GetBlockName(), "jdiff_vol", i).ParseLong("jdiff_vol"); // long 12
					block.value = query.GetFieldData(block.GetBlockName(), "value", i).ParseLong("value"); // long 12
					block.jongchk = query.GetFieldData(block.GetBlockName(), "jongchk", i).ParseLong("jongchk"); // long 13
					block.rate = query.GetFieldData(block.GetBlockName(), "rate", i).ParseDouble("rate"); // double 6.2
					block.pricechk = query.GetFieldData(block.GetBlockName(), "pricechk", i).ParseLong("pricechk"); // long 13
					block.ratevalue = query.GetFieldData(block.GetBlockName(), "ratevalue", i).ParseLong("ratevalue"); // long 12

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
			if (time?.Length > 10) return false; // char 10
			if (open.ToString().Length > 8) return false; // long 8
			if (high.ToString().Length > 8) return false; // long 8
			if (low.ToString().Length > 8) return false; // long 8
			if (close.ToString().Length > 8) return false; // long 8
			if (jdiff_vol.ToString().Length > 12) return false; // long 12
			if (value.ToString().Length > 12) return false; // long 12
			if (jongchk.ToString().Length > 13) return false; // long 13
			// rate double 6.2
			if (pricechk.ToString().Length > 13) return false; // long 13
			if (ratevalue.ToString().Length > 12) return false; // long 12

			return true;
		}

		public void CopyTo(XQt4201OutBlock1 block)
		{
			block.date = this.date;
			block.time = this.time;
			block.open = this.open;
			block.high = this.high;
			block.low = this.low;
			block.close = this.close;
			block.jdiff_vol = this.jdiff_vol;
			block.value = this.value;
			block.jongchk = this.jongchk;
			block.rate = this.rate;
			block.pricechk = this.pricechk;
			block.ratevalue = this.ratevalue;

		}
	}

	/// <summary>
	/// 주식챠트(종합)(t4201)
	/// </summary>
	public partial class XQt4201 : XingQuery
	{
		/// <summary>
		/// t4201
		/// </summary>
		public const string _typeName = "t4201";
		/// <summary>
		/// 주식챠트(종합)(t4201)
		/// </summary>
		public const string _typeDesc = "주식챠트(종합)(t4201)";
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
		/// t4201
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 주식챠트(종합)(t4201)
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
		/// 주식챠트(종합)(t4201)
		/// </summary>
		public XQt4201() : base("t4201") { }


		public class XQAllOutBlocks
		{
			public XQt4201OutBlock OutBlock { get; internal set; }
			public XQt4201OutBlock1[] OutBlock1 { get; internal set; }
		}

		public static XQAllOutBlocks Get(string shcode = default,char gubun = default,long ncnt = default,long qrycnt = default,char tdgb = default,string sdate = default,string edate = default,string cts_date = default,string cts_time = default,char cts_daygb = default)
		{
			using (XQt4201 instance = new XQt4201())
			{
				instance.SetFieldData(XQt4201InBlock.BlockName, XQt4201InBlock.F.shcode, 0, shcode); // char 6
				instance.SetFieldData(XQt4201InBlock.BlockName, XQt4201InBlock.F.gubun, 0, gubun.ToString()); // char 1
				instance.SetFieldData(XQt4201InBlock.BlockName, XQt4201InBlock.F.ncnt, 0, ncnt.ToString("d4")); // long 4
				instance.SetFieldData(XQt4201InBlock.BlockName, XQt4201InBlock.F.qrycnt, 0, qrycnt.ToString("d4")); // long 4
				instance.SetFieldData(XQt4201InBlock.BlockName, XQt4201InBlock.F.tdgb, 0, tdgb.ToString()); // char 1
				instance.SetFieldData(XQt4201InBlock.BlockName, XQt4201InBlock.F.sdate, 0, sdate); // char 8
				instance.SetFieldData(XQt4201InBlock.BlockName, XQt4201InBlock.F.edate, 0, edate); // char 8
				instance.SetFieldData(XQt4201InBlock.BlockName, XQt4201InBlock.F.cts_date, 0, cts_date); // char 8
				instance.SetFieldData(XQt4201InBlock.BlockName, XQt4201InBlock.F.cts_time, 0, cts_time); // char 10
				instance.SetFieldData(XQt4201InBlock.BlockName, XQt4201InBlock.F.cts_daygb, 0, cts_daygb.ToString()); // char 1

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

		public static XQAllOutBlocks ReadFromDB(string tableNamePostfix = null /*, string shcode = default,char gubun = default,long ncnt = default,long qrycnt = default,char tdgb = default,string sdate = default,string edate = default,string cts_date = default,string cts_time = default,char cts_daygb = default */)
		{
			using (XQt4201 instance = new XQt4201())
			{

				XQAllOutBlocks results = new XQAllOutBlocks();

				string tableName = (tableNamePostfix == null) ? "XQt4201OutBlock" : $"XQt4201OutBlock_{tableNamePostfix}";
				QueryOption qo = new QueryOption(tableName);
				results.OutBlock = instance.Select<XQt4201OutBlock>(qo);

				tableName = (tableNamePostfix == null) ? "XQt4201OutBlock1" : $"XQt4201OutBlock1_{tableNamePostfix}";
				qo = new QueryOption(tableName);
				results.OutBlock1 = instance.SelectMany<XQt4201OutBlock1>(qo);
				return results;
			}
		}

		public bool SetBlock(XQt4201InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "shcode", 0, block.shcode); // char 6
			_xaQuery.SetFieldData(block.GetBlockName(), "gubun", 0, block.gubun.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "ncnt", 0, block.ncnt.ToString("d4")); // long 4
			_xaQuery.SetFieldData(block.GetBlockName(), "qrycnt", 0, block.qrycnt.ToString("d4")); // long 4
			_xaQuery.SetFieldData(block.GetBlockName(), "tdgb", 0, block.tdgb.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "sdate", 0, block.sdate); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "edate", 0, block.edate); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "cts_date", 0, block.cts_date); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "cts_time", 0, block.cts_time); // char 10
			_xaQuery.SetFieldData(block.GetBlockName(), "cts_daygb", 0, block.cts_daygb.ToString()); // char 1

			return true;
		}

		public XQt4201OutBlock GetBlock()
		{
			XQt4201OutBlock instance = XQt4201OutBlock.FromQuery(this);
			return instance;

		}

		public XQt4201OutBlock1[] GetBlock1s()
		{
			XQt4201OutBlock1[] instance = XQt4201OutBlock1.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt4201OutBlock),
			typeof(XQt4201OutBlock1),

		};

	}

}
