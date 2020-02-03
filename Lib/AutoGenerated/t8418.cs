using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt8418InBlock : XingBlock
	{
		/// <summary>
		/// t8418InBlock
		/// </summary>
		static readonly string _blockName = "t8418InBlock";
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
		/// t8418InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t8418InBlock
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
		[XAQueryFieldAttribute("단축코드")]
		public string shcode;
		/// <summary>
		/// 단위(n분)
		/// </summary>
		[XAQueryFieldAttribute("단위(n분)")]
		public long ncnt;
		/// <summary>
		/// 요청건수(최대-압축:2000비압축:500)
		/// </summary>
		[XAQueryFieldAttribute("요청건수(최대-압축:2000비압축:500)")]
		public long qrycnt;
		/// <summary>
		/// 조회영업일수(0:미사용1>=사용)
		/// </summary>
		[XAQueryFieldAttribute("조회영업일수(0:미사용1>=사용)")]
		public char nday;
		/// <summary>
		/// 시작일자
		/// </summary>
		[XAQueryFieldAttribute("시작일자")]
		public string sdate;
		/// <summary>
		/// 시작시간(현재미사용)
		/// </summary>
		[XAQueryFieldAttribute("시작시간(현재미사용)")]
		public string stime;
		/// <summary>
		/// 종료일자
		/// </summary>
		[XAQueryFieldAttribute("종료일자")]
		public string edate;
		/// <summary>
		/// 종료시간(현재미사용)
		/// </summary>
		[XAQueryFieldAttribute("종료시간(현재미사용)")]
		public string etime;
		/// <summary>
		/// 연속일자
		/// </summary>
		[XAQueryFieldAttribute("연속일자")]
		public string cts_date;
		/// <summary>
		/// 연속시간
		/// </summary>
		[XAQueryFieldAttribute("연속시간")]
		public string cts_time;
		/// <summary>
		/// 압축여부(Y:압축N:비압축)
		/// </summary>
		[XAQueryFieldAttribute("압축여부(Y:압축N:비압축)")]
		public char comp_yn;

		public static class F
		{
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 단위(n분)
			/// </summary>
			public const string ncnt = "ncnt";
			/// <summary>
			/// 요청건수(최대-압축:2000비압축:500)
			/// </summary>
			public const string qrycnt = "qrycnt";
			/// <summary>
			/// 조회영업일수(0:미사용1>=사용)
			/// </summary>
			public const string nday = "nday";
			/// <summary>
			/// 시작일자
			/// </summary>
			public const string sdate = "sdate";
			/// <summary>
			/// 시작시간(현재미사용)
			/// </summary>
			public const string stime = "stime";
			/// <summary>
			/// 종료일자
			/// </summary>
			public const string edate = "edate";
			/// <summary>
			/// 종료시간(현재미사용)
			/// </summary>
			public const string etime = "etime";
			/// <summary>
			/// 연속일자
			/// </summary>
			public const string cts_date = "cts_date";
			/// <summary>
			/// 연속시간
			/// </summary>
			public const string cts_time = "cts_time";
			/// <summary>
			/// 압축여부(Y:압축N:비압축)
			/// </summary>
			public const string comp_yn = "comp_yn";
		}

		public static string[] AllFields = new string[]
		{
			F.shcode,
			F.ncnt,
			F.qrycnt,
			F.nday,
			F.sdate,
			F.stime,
			F.edate,
			F.etime,
			F.cts_date,
			F.cts_time,
			F.comp_yn,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)3);
			dict["ncnt"] = new XAQueryFieldInfo("long", ncnt, ncnt.ToString("d4"), "단위(n분)", (decimal)4);
			dict["qrycnt"] = new XAQueryFieldInfo("long", qrycnt, qrycnt.ToString("d4"), "요청건수(최대-압축:2000비압축:500)", (decimal)4);
			dict["nday"] = new XAQueryFieldInfo("char", nday, nday.ToString(), "조회영업일수(0:미사용1>=사용)", (decimal)1);
			dict["sdate"] = new XAQueryFieldInfo("char", sdate, sdate, "시작일자", (decimal)8);
			dict["stime"] = new XAQueryFieldInfo("char", stime, stime, "시작시간(현재미사용)", (decimal)6);
			dict["edate"] = new XAQueryFieldInfo("char", edate, edate, "종료일자", (decimal)8);
			dict["etime"] = new XAQueryFieldInfo("char", etime, etime, "종료시간(현재미사용)", (decimal)6);
			dict["cts_date"] = new XAQueryFieldInfo("char", cts_date, cts_date, "연속일자", (decimal)8);
			dict["cts_time"] = new XAQueryFieldInfo("char", cts_time, cts_time, "연속시간", (decimal)10);
			dict["comp_yn"] = new XAQueryFieldInfo("char", comp_yn, comp_yn.ToString(), "압축여부(Y:압축N:비압축)", (decimal)1);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ncnt":
					this.ncnt = fieldInfo.FieldValue.ParseLong("ncnt");
				break;

				case "qrycnt":
					this.qrycnt = fieldInfo.FieldValue.ParseLong("qrycnt");
				break;

				case "nday":
					this.nday = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "sdate":
					this.sdate = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "stime":
					this.stime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "edate":
					this.edate = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "etime":
					this.etime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cts_date":
					this.cts_date = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cts_time":
					this.cts_time = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "comp_yn":
					this.comp_yn = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public bool VerifyData()
		{
			if (shcode.Length > 3) return false; // char 3
			if (ncnt.ToString().Length > 4) return false; // long 4
			if (qrycnt.ToString().Length > 4) return false; // long 4
			// nday char 1
			if (sdate.Length > 8) return false; // char 8
			if (stime.Length > 6) return false; // char 6
			if (edate.Length > 8) return false; // char 8
			if (etime.Length > 6) return false; // char 6
			if (cts_date.Length > 8) return false; // char 8
			if (cts_time.Length > 10) return false; // char 10
			// comp_yn char 1

			return true;
		}
	}

	public partial class XQt8418OutBlock : XingBlock
	{
		/// <summary>
		/// t8418OutBlock
		/// </summary>
		static readonly string _blockName = "t8418OutBlock";
		/// <summary>
		/// 출력
		/// </summary>
		static readonly string _blockDesc = "출력";
		/// <summary>
		/// output
		/// </summary>
		static readonly string _blockType = "output";
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _hasOccurs = false;
		/// <summary>
		/// t8418OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t8418OutBlock
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
		[XAQueryFieldAttribute("단축코드")]
		public string shcode;
		/// <summary>
		/// 전일시가
		/// </summary>
		[XAQueryFieldAttribute("전일시가")]
		public float jisiga;
		/// <summary>
		/// 전일고가
		/// </summary>
		[XAQueryFieldAttribute("전일고가")]
		public float jihigh;
		/// <summary>
		/// 전일저가
		/// </summary>
		[XAQueryFieldAttribute("전일저가")]
		public float jilow;
		/// <summary>
		/// 전일종가
		/// </summary>
		[XAQueryFieldAttribute("전일종가")]
		public float jiclose;
		/// <summary>
		/// 전일거래량
		/// </summary>
		[XAQueryFieldAttribute("전일거래량")]
		public long jivolume;
		/// <summary>
		/// 당일시가
		/// </summary>
		[XAQueryFieldAttribute("당일시가")]
		public float disiga;
		/// <summary>
		/// 당일고가
		/// </summary>
		[XAQueryFieldAttribute("당일고가")]
		public float dihigh;
		/// <summary>
		/// 당일저가
		/// </summary>
		[XAQueryFieldAttribute("당일저가")]
		public float dilow;
		/// <summary>
		/// 당일종가
		/// </summary>
		[XAQueryFieldAttribute("당일종가")]
		public float diclose;
		/// <summary>
		/// 당일거래대금
		/// </summary>
		[XAQueryFieldAttribute("당일거래대금")]
		public long disvalue;
		/// <summary>
		/// 연속일자
		/// </summary>
		[XAQueryFieldAttribute("연속일자")]
		public string cts_date;
		/// <summary>
		/// 연속시간
		/// </summary>
		[XAQueryFieldAttribute("연속시간")]
		public string cts_time;
		/// <summary>
		/// 업종시작시간(HHMMSS)
		/// </summary>
		[XAQueryFieldAttribute("업종시작시간(HHMMSS)")]
		public string s_time;
		/// <summary>
		/// 업종종료시간(HHMMSS)
		/// </summary>
		[XAQueryFieldAttribute("업종종료시간(HHMMSS)")]
		public string e_time;
		/// <summary>
		/// 동시호가처리시간(MM:분)
		/// </summary>
		[XAQueryFieldAttribute("동시호가처리시간(MM:분)")]
		public string dshmin;
		/// <summary>
		/// 레코드카운트
		/// </summary>
		[XAQueryFieldAttribute("레코드카운트")]
		public long rec_count;

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
			/// 당일거래대금
			/// </summary>
			public const string disvalue = "disvalue";
			/// <summary>
			/// 연속일자
			/// </summary>
			public const string cts_date = "cts_date";
			/// <summary>
			/// 연속시간
			/// </summary>
			public const string cts_time = "cts_time";
			/// <summary>
			/// 업종시작시간(HHMMSS)
			/// </summary>
			public const string s_time = "s_time";
			/// <summary>
			/// 업종종료시간(HHMMSS)
			/// </summary>
			public const string e_time = "e_time";
			/// <summary>
			/// 동시호가처리시간(MM:분)
			/// </summary>
			public const string dshmin = "dshmin";
			/// <summary>
			/// 레코드카운트
			/// </summary>
			public const string rec_count = "rec_count";
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
			F.disvalue,
			F.cts_date,
			F.cts_time,
			F.s_time,
			F.e_time,
			F.dshmin,
			F.rec_count,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)3);
			dict["jisiga"] = new XAQueryFieldInfo("float", jisiga, jisiga.ToString("0000000.00"), "전일시가", (decimal)7.2);
			dict["jihigh"] = new XAQueryFieldInfo("float", jihigh, jihigh.ToString("0000000.00"), "전일고가", (decimal)7.2);
			dict["jilow"] = new XAQueryFieldInfo("float", jilow, jilow.ToString("0000000.00"), "전일저가", (decimal)7.2);
			dict["jiclose"] = new XAQueryFieldInfo("float", jiclose, jiclose.ToString("0000000.00"), "전일종가", (decimal)7.2);
			dict["jivolume"] = new XAQueryFieldInfo("long", jivolume, jivolume.ToString("d12"), "전일거래량", (decimal)12);
			dict["disiga"] = new XAQueryFieldInfo("float", disiga, disiga.ToString("0000000.00"), "당일시가", (decimal)7.2);
			dict["dihigh"] = new XAQueryFieldInfo("float", dihigh, dihigh.ToString("0000000.00"), "당일고가", (decimal)7.2);
			dict["dilow"] = new XAQueryFieldInfo("float", dilow, dilow.ToString("0000000.00"), "당일저가", (decimal)7.2);
			dict["diclose"] = new XAQueryFieldInfo("float", diclose, diclose.ToString("0000000.00"), "당일종가", (decimal)7.2);
			dict["disvalue"] = new XAQueryFieldInfo("long", disvalue, disvalue.ToString("d12"), "당일거래대금", (decimal)12);
			dict["cts_date"] = new XAQueryFieldInfo("char", cts_date, cts_date, "연속일자", (decimal)8);
			dict["cts_time"] = new XAQueryFieldInfo("char", cts_time, cts_time, "연속시간", (decimal)10);
			dict["s_time"] = new XAQueryFieldInfo("char", s_time, s_time, "업종시작시간(HHMMSS)", (decimal)6);
			dict["e_time"] = new XAQueryFieldInfo("char", e_time, e_time, "업종종료시간(HHMMSS)", (decimal)6);
			dict["dshmin"] = new XAQueryFieldInfo("char", dshmin, dshmin, "동시호가처리시간(MM:분)", (decimal)2);
			dict["rec_count"] = new XAQueryFieldInfo("long", rec_count, rec_count.ToString("d7"), "레코드카운트", (decimal)7);

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
					this.jisiga = fieldInfo.FieldValue.ParseFloat("jisiga");
				break;

				case "jihigh":
					this.jihigh = fieldInfo.FieldValue.ParseFloat("jihigh");
				break;

				case "jilow":
					this.jilow = fieldInfo.FieldValue.ParseFloat("jilow");
				break;

				case "jiclose":
					this.jiclose = fieldInfo.FieldValue.ParseFloat("jiclose");
				break;

				case "jivolume":
					this.jivolume = fieldInfo.FieldValue.ParseLong("jivolume");
				break;

				case "disiga":
					this.disiga = fieldInfo.FieldValue.ParseFloat("disiga");
				break;

				case "dihigh":
					this.dihigh = fieldInfo.FieldValue.ParseFloat("dihigh");
				break;

				case "dilow":
					this.dilow = fieldInfo.FieldValue.ParseFloat("dilow");
				break;

				case "diclose":
					this.diclose = fieldInfo.FieldValue.ParseFloat("diclose");
				break;

				case "disvalue":
					this.disvalue = fieldInfo.FieldValue.ParseLong("disvalue");
				break;

				case "cts_date":
					this.cts_date = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cts_time":
					this.cts_time = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "s_time":
					this.s_time = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "e_time":
					this.e_time = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "dshmin":
					this.dshmin = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "rec_count":
					this.rec_count = fieldInfo.FieldValue.ParseLong("rec_count");
				break;


			}
		}

		public static XQt8418OutBlock FromQuery(XQt8418 query)
		{
			XQt8418OutBlock block = new XQt8418OutBlock();
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
				block.shcode = query.GetFieldData(block.GetBlockName(), "shcode", 0).TrimEnd('?'); // char 3
				block.jisiga = query.GetFieldData(block.GetBlockName(), "jisiga", 0).ParseFloat("jisiga"); // float 7.2
				block.jihigh = query.GetFieldData(block.GetBlockName(), "jihigh", 0).ParseFloat("jihigh"); // float 7.2
				block.jilow = query.GetFieldData(block.GetBlockName(), "jilow", 0).ParseFloat("jilow"); // float 7.2
				block.jiclose = query.GetFieldData(block.GetBlockName(), "jiclose", 0).ParseFloat("jiclose"); // float 7.2
				block.jivolume = query.GetFieldData(block.GetBlockName(), "jivolume", 0).ParseLong("jivolume"); // long 12
				block.disiga = query.GetFieldData(block.GetBlockName(), "disiga", 0).ParseFloat("disiga"); // float 7.2
				block.dihigh = query.GetFieldData(block.GetBlockName(), "dihigh", 0).ParseFloat("dihigh"); // float 7.2
				block.dilow = query.GetFieldData(block.GetBlockName(), "dilow", 0).ParseFloat("dilow"); // float 7.2
				block.diclose = query.GetFieldData(block.GetBlockName(), "diclose", 0).ParseFloat("diclose"); // float 7.2
				block.disvalue = query.GetFieldData(block.GetBlockName(), "disvalue", 0).ParseLong("disvalue"); // long 12
				block.cts_date = query.GetFieldData(block.GetBlockName(), "cts_date", 0).TrimEnd('?'); // char 8
				block.cts_time = query.GetFieldData(block.GetBlockName(), "cts_time", 0).TrimEnd('?'); // char 10
				block.s_time = query.GetFieldData(block.GetBlockName(), "s_time", 0).TrimEnd('?'); // char 6
				block.e_time = query.GetFieldData(block.GetBlockName(), "e_time", 0).TrimEnd('?'); // char 6
				block.dshmin = query.GetFieldData(block.GetBlockName(), "dshmin", 0).TrimEnd('?'); // char 2
				block.rec_count = query.GetFieldData(block.GetBlockName(), "rec_count", 0).ParseLong("rec_count"); // long 7

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (shcode.Length > 3) return false; // char 3
			// jisiga float 7.2
			// jihigh float 7.2
			// jilow float 7.2
			// jiclose float 7.2
			if (jivolume.ToString().Length > 12) return false; // long 12
			// disiga float 7.2
			// dihigh float 7.2
			// dilow float 7.2
			// diclose float 7.2
			if (disvalue.ToString().Length > 12) return false; // long 12
			if (cts_date.Length > 8) return false; // char 8
			if (cts_time.Length > 10) return false; // char 10
			if (s_time.Length > 6) return false; // char 6
			if (e_time.Length > 6) return false; // char 6
			if (dshmin.Length > 2) return false; // char 2
			if (rec_count.ToString().Length > 7) return false; // long 7

			return true;
		}
	}

	public partial class XQt8418OutBlock1 : XingBlock
	{
		/// <summary>
		/// t8418OutBlock1
		/// </summary>
		static readonly string _blockName = "t8418OutBlock1";
		/// <summary>
		/// 출력1
		/// </summary>
		static readonly string _blockDesc = "출력1";
		/// <summary>
		/// output
		/// </summary>
		static readonly string _blockType = "output";
		/// <summary>
		/// true
		/// </summary>
		static readonly bool _hasOccurs = true;
		/// <summary>
		/// t8418OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t8418OutBlock1
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
		[XAQueryFieldAttribute("날짜")]
		public string date;
		/// <summary>
		/// 시간
		/// </summary>
		[XAQueryFieldAttribute("시간")]
		public string time;
		/// <summary>
		/// 시가
		/// </summary>
		[XAQueryFieldAttribute("시가")]
		public float open;
		/// <summary>
		/// 고가
		/// </summary>
		[XAQueryFieldAttribute("고가")]
		public float high;
		/// <summary>
		/// 저가
		/// </summary>
		[XAQueryFieldAttribute("저가")]
		public float low;
		/// <summary>
		/// 종가
		/// </summary>
		[XAQueryFieldAttribute("종가")]
		public float close;
		/// <summary>
		/// 거래량
		/// </summary>
		[XAQueryFieldAttribute("거래량")]
		public long jdiff_vol;
		/// <summary>
		/// 거래대금
		/// </summary>
		[XAQueryFieldAttribute("거래대금")]
		public long value;

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
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["date"] = new XAQueryFieldInfo("char", date, date, "날짜", (decimal)8);
			dict["time"] = new XAQueryFieldInfo("char", time, time, "시간", (decimal)6);
			dict["open"] = new XAQueryFieldInfo("float", open, open.ToString("0000000.00"), "시가", (decimal)7.2);
			dict["high"] = new XAQueryFieldInfo("float", high, high.ToString("0000000.00"), "고가", (decimal)7.2);
			dict["low"] = new XAQueryFieldInfo("float", low, low.ToString("0000000.00"), "저가", (decimal)7.2);
			dict["close"] = new XAQueryFieldInfo("float", close, close.ToString("0000000.00"), "종가", (decimal)7.2);
			dict["jdiff_vol"] = new XAQueryFieldInfo("long", jdiff_vol, jdiff_vol.ToString("d12"), "거래량", (decimal)12);
			dict["value"] = new XAQueryFieldInfo("long", value, value.ToString("d12"), "거래대금", (decimal)12);

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
					this.open = fieldInfo.FieldValue.ParseFloat("open");
				break;

				case "high":
					this.high = fieldInfo.FieldValue.ParseFloat("high");
				break;

				case "low":
					this.low = fieldInfo.FieldValue.ParseFloat("low");
				break;

				case "close":
					this.close = fieldInfo.FieldValue.ParseFloat("close");
				break;

				case "jdiff_vol":
					this.jdiff_vol = fieldInfo.FieldValue.ParseLong("jdiff_vol");
				break;

				case "value":
					this.value = fieldInfo.FieldValue.ParseLong("value");
				break;


			}
		}

		public static XQt8418OutBlock1[] ListFromQuery(XQt8418 query)
		{
			int count = query.GetBlockCount(XQt8418OutBlock1.BlockName);
			List<XQt8418OutBlock1> list = new List<XQt8418OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt8418OutBlock1 block = new XQt8418OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.date = query.GetFieldData(block.GetBlockName(), "date", i).TrimEnd('?'); // char 8
					block.time = query.GetFieldData(block.GetBlockName(), "time", i).TrimEnd('?'); // char 6
					block.open = query.GetFieldData(block.GetBlockName(), "open", i).ParseFloat("open"); // float 7.2
					block.high = query.GetFieldData(block.GetBlockName(), "high", i).ParseFloat("high"); // float 7.2
					block.low = query.GetFieldData(block.GetBlockName(), "low", i).ParseFloat("low"); // float 7.2
					block.close = query.GetFieldData(block.GetBlockName(), "close", i).ParseFloat("close"); // float 7.2
					block.jdiff_vol = query.GetFieldData(block.GetBlockName(), "jdiff_vol", i).ParseLong("jdiff_vol"); // long 12
					block.value = query.GetFieldData(block.GetBlockName(), "value", i).ParseLong("value"); // long 12

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
			if (time.Length > 6) return false; // char 6
			// open float 7.2
			// high float 7.2
			// low float 7.2
			// close float 7.2
			if (jdiff_vol.ToString().Length > 12) return false; // long 12
			if (value.ToString().Length > 12) return false; // long 12

			return true;
		}
	}

	public partial class XQt8418 : XingQuery
	{
		/// <summary>
		/// t8418
		/// </summary>
		static readonly string _typeName = "t8418";
		/// <summary>
		/// 업종챠트(N분)(t8418)
		/// </summary>
		static readonly string _typeDesc = "업종챠트(N분)(t8418)";
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
		/// t8418
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 업종챠트(N분)(t8418)
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

		public XQt8418() : base("t8418") { }


		public bool SetFields(XQt8418InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "shcode", 0, block.shcode); // char 3
			_xaQuery.SetFieldData(block.GetBlockName(), "ncnt", 0, block.ncnt.ToString("d4")); // long 4
			_xaQuery.SetFieldData(block.GetBlockName(), "qrycnt", 0, block.qrycnt.ToString("d4")); // long 4
			_xaQuery.SetFieldData(block.GetBlockName(), "nday", 0, block.nday.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "sdate", 0, block.sdate); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "stime", 0, block.stime); // char 6
			_xaQuery.SetFieldData(block.GetBlockName(), "edate", 0, block.edate); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "etime", 0, block.etime); // char 6
			_xaQuery.SetFieldData(block.GetBlockName(), "cts_date", 0, block.cts_date); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "cts_time", 0, block.cts_time); // char 10
			_xaQuery.SetFieldData(block.GetBlockName(), "comp_yn", 0, block.comp_yn.ToString()); // char 1

			return true;
		}

		public XQt8418OutBlock GetBlock()
		{
			XQt8418OutBlock instance = XQt8418OutBlock.FromQuery(this);
			return instance;

		}

		public XQt8418OutBlock1[] GetBlock1s()
		{
			XQt8418OutBlock1[] instance = XQt8418OutBlock1.ListFromQuery(this);
			return instance;

		}


	}

}
