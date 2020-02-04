using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1302InBlock : XingBlock
	{
		/// <summary>
		/// t1302InBlock
		/// </summary>
		public const string _blockName = "t1302InBlock";
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
		/// t1302InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1302InBlock
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
		/// 작업구분
		/// </summary>
		[XAQueryFieldAttribute("작업구분")]
		public char gubun;
		/// <summary>
		/// 시간
		/// </summary>
		[XAQueryFieldAttribute("시간")]
		public string time;
		/// <summary>
		/// 건수
		/// </summary>
		[XAQueryFieldAttribute("건수")]
		public int cnt;

		public static class F
		{
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 작업구분
			/// </summary>
			public const string gubun = "gubun";
			/// <summary>
			/// 시간
			/// </summary>
			public const string time = "time";
			/// <summary>
			/// 건수
			/// </summary>
			public const string cnt = "cnt";
		}

		public static string[] AllFields = new string[]
		{
			F.shcode,
			F.gubun,
			F.time,
			F.cnt,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)6);
			dict["gubun"] = new XAQueryFieldInfo("char", gubun, gubun.ToString(), "작업구분", (decimal)1);
			dict["time"] = new XAQueryFieldInfo("char", time, time, "시간", (decimal)6);
			dict["cnt"] = new XAQueryFieldInfo("int", cnt, cnt.ToString("d3"), "건수", (decimal)3);

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

				case "time":
					this.time = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cnt":
					this.cnt = fieldInfo.FieldValue.ParseInt("cnt");
				break;


			}
		}

		public bool VerifyData()
		{
			if (shcode?.Length > 6) return false; // char 6
			// gubun char 1
			if (time?.Length > 6) return false; // char 6
			// cnt int 3

			return true;
		}
	}

	public partial class XQt1302OutBlock : XingBlock
	{
		/// <summary>
		/// t1302OutBlock
		/// </summary>
		public const string _blockName = "t1302OutBlock";
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
		/// t1302OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1302OutBlock
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
		/// 시간CTS
		/// </summary>
		[XAQueryFieldAttribute("시간CTS")]
		public string cts_time;

		public static class F
		{
			/// <summary>
			/// 시간CTS
			/// </summary>
			public const string cts_time = "cts_time";
		}

		public static string[] AllFields = new string[]
		{
			F.cts_time,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["cts_time"] = new XAQueryFieldInfo("char", cts_time, cts_time, "시간CTS", (decimal)6);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "cts_time":
					this.cts_time = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt1302OutBlock FromQuery(XQt1302 query)
		{
			XQt1302OutBlock block = new XQt1302OutBlock();
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
				block.cts_time = query.GetFieldData(block.GetBlockName(), "cts_time", 0).TrimEnd('?'); // char 6

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (cts_time?.Length > 6) return false; // char 6

			return true;
		}
	}

	public partial class XQt1302OutBlock1 : XingBlock
	{
		/// <summary>
		/// t1302OutBlock1
		/// </summary>
		public const string _blockName = "t1302OutBlock1";
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
		/// t1302OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1302OutBlock1
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
		public string chetime;
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
		/// 체결강도
		/// </summary>
		[XAQueryFieldAttribute("체결강도")]
		public float chdegree;
		/// <summary>
		/// 매도체결수량
		/// </summary>
		[XAQueryFieldAttribute("매도체결수량")]
		public long mdvolume;
		/// <summary>
		/// 매수체결수량
		/// </summary>
		[XAQueryFieldAttribute("매수체결수량")]
		public long msvolume;
		/// <summary>
		/// 순매수체결량
		/// </summary>
		[XAQueryFieldAttribute("순매수체결량")]
		public long revolume;
		/// <summary>
		/// 매도체결건수
		/// </summary>
		[XAQueryFieldAttribute("매도체결건수")]
		public long mdchecnt;
		/// <summary>
		/// 매수체결건수
		/// </summary>
		[XAQueryFieldAttribute("매수체결건수")]
		public long mschecnt;
		/// <summary>
		/// 순체결건수
		/// </summary>
		[XAQueryFieldAttribute("순체결건수")]
		public long rechecnt;
		/// <summary>
		/// 거래량
		/// </summary>
		[XAQueryFieldAttribute("거래량")]
		public long volume;
		/// <summary>
		/// 시가
		/// </summary>
		[XAQueryFieldAttribute("시가")]
		public long open;
		/// <summary>
		/// 고가
		/// </summary>
		[XAQueryFieldAttribute("고가")]
		public long high;
		/// <summary>
		/// 저가
		/// </summary>
		[XAQueryFieldAttribute("저가")]
		public long low;
		/// <summary>
		/// 체결량
		/// </summary>
		[XAQueryFieldAttribute("체결량")]
		public long cvolume;
		/// <summary>
		/// 매도체결건수(시간)
		/// </summary>
		[XAQueryFieldAttribute("매도체결건수(시간)")]
		public long mdchecnttm;
		/// <summary>
		/// 매수체결건수(시간)
		/// </summary>
		[XAQueryFieldAttribute("매수체결건수(시간)")]
		public long mschecnttm;
		/// <summary>
		/// 매도잔량
		/// </summary>
		[XAQueryFieldAttribute("매도잔량")]
		public long totofferrem;
		/// <summary>
		/// 매수잔량
		/// </summary>
		[XAQueryFieldAttribute("매수잔량")]
		public long totbidrem;
		/// <summary>
		/// 시간별매도체결량
		/// </summary>
		[XAQueryFieldAttribute("시간별매도체결량")]
		public long mdvolumetm;
		/// <summary>
		/// 시간별매수체결량
		/// </summary>
		[XAQueryFieldAttribute("시간별매수체결량")]
		public long msvolumetm;

		public static class F
		{
			/// <summary>
			/// 시간
			/// </summary>
			public const string chetime = "chetime";
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
			/// 체결강도
			/// </summary>
			public const string chdegree = "chdegree";
			/// <summary>
			/// 매도체결수량
			/// </summary>
			public const string mdvolume = "mdvolume";
			/// <summary>
			/// 매수체결수량
			/// </summary>
			public const string msvolume = "msvolume";
			/// <summary>
			/// 순매수체결량
			/// </summary>
			public const string revolume = "revolume";
			/// <summary>
			/// 매도체결건수
			/// </summary>
			public const string mdchecnt = "mdchecnt";
			/// <summary>
			/// 매수체결건수
			/// </summary>
			public const string mschecnt = "mschecnt";
			/// <summary>
			/// 순체결건수
			/// </summary>
			public const string rechecnt = "rechecnt";
			/// <summary>
			/// 거래량
			/// </summary>
			public const string volume = "volume";
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
			/// 체결량
			/// </summary>
			public const string cvolume = "cvolume";
			/// <summary>
			/// 매도체결건수(시간)
			/// </summary>
			public const string mdchecnttm = "mdchecnttm";
			/// <summary>
			/// 매수체결건수(시간)
			/// </summary>
			public const string mschecnttm = "mschecnttm";
			/// <summary>
			/// 매도잔량
			/// </summary>
			public const string totofferrem = "totofferrem";
			/// <summary>
			/// 매수잔량
			/// </summary>
			public const string totbidrem = "totbidrem";
			/// <summary>
			/// 시간별매도체결량
			/// </summary>
			public const string mdvolumetm = "mdvolumetm";
			/// <summary>
			/// 시간별매수체결량
			/// </summary>
			public const string msvolumetm = "msvolumetm";
		}

		public static string[] AllFields = new string[]
		{
			F.chetime,
			F.close,
			F.sign,
			F.change,
			F.diff,
			F.chdegree,
			F.mdvolume,
			F.msvolume,
			F.revolume,
			F.mdchecnt,
			F.mschecnt,
			F.rechecnt,
			F.volume,
			F.open,
			F.high,
			F.low,
			F.cvolume,
			F.mdchecnttm,
			F.mschecnttm,
			F.totofferrem,
			F.totbidrem,
			F.mdvolumetm,
			F.msvolumetm,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["chetime"] = new XAQueryFieldInfo("char", chetime, chetime, "시간", (decimal)6);
			dict["close"] = new XAQueryFieldInfo("long", close, close.ToString("d8"), "종가", (decimal)8);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("long", change, change.ToString("d8"), "전일대비", (decimal)8);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["chdegree"] = new XAQueryFieldInfo("float", chdegree, chdegree.ToString("00000000.00"), "체결강도", (decimal)8.2);
			dict["mdvolume"] = new XAQueryFieldInfo("long", mdvolume, mdvolume.ToString("d12"), "매도체결수량", (decimal)12);
			dict["msvolume"] = new XAQueryFieldInfo("long", msvolume, msvolume.ToString("d12"), "매수체결수량", (decimal)12);
			dict["revolume"] = new XAQueryFieldInfo("long", revolume, revolume.ToString("d12"), "순매수체결량", (decimal)12);
			dict["mdchecnt"] = new XAQueryFieldInfo("long", mdchecnt, mdchecnt.ToString("d8"), "매도체결건수", (decimal)8);
			dict["mschecnt"] = new XAQueryFieldInfo("long", mschecnt, mschecnt.ToString("d8"), "매수체결건수", (decimal)8);
			dict["rechecnt"] = new XAQueryFieldInfo("long", rechecnt, rechecnt.ToString("d8"), "순체결건수", (decimal)8);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "거래량", (decimal)12);
			dict["open"] = new XAQueryFieldInfo("long", open, open.ToString("d8"), "시가", (decimal)8);
			dict["high"] = new XAQueryFieldInfo("long", high, high.ToString("d8"), "고가", (decimal)8);
			dict["low"] = new XAQueryFieldInfo("long", low, low.ToString("d8"), "저가", (decimal)8);
			dict["cvolume"] = new XAQueryFieldInfo("long", cvolume, cvolume.ToString("d12"), "체결량", (decimal)12);
			dict["mdchecnttm"] = new XAQueryFieldInfo("long", mdchecnttm, mdchecnttm.ToString("d8"), "매도체결건수(시간)", (decimal)8);
			dict["mschecnttm"] = new XAQueryFieldInfo("long", mschecnttm, mschecnttm.ToString("d8"), "매수체결건수(시간)", (decimal)8);
			dict["totofferrem"] = new XAQueryFieldInfo("long", totofferrem, totofferrem.ToString("d12"), "매도잔량", (decimal)12);
			dict["totbidrem"] = new XAQueryFieldInfo("long", totbidrem, totbidrem.ToString("d12"), "매수잔량", (decimal)12);
			dict["mdvolumetm"] = new XAQueryFieldInfo("long", mdvolumetm, mdvolumetm.ToString("d12"), "시간별매도체결량", (decimal)12);
			dict["msvolumetm"] = new XAQueryFieldInfo("long", msvolumetm, msvolumetm.ToString("d12"), "시간별매수체결량", (decimal)12);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "chetime":
					this.chetime = fieldInfo.FieldValue.TrimEnd('?');
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

				case "chdegree":
					this.chdegree = fieldInfo.FieldValue.ParseFloat("chdegree");
				break;

				case "mdvolume":
					this.mdvolume = fieldInfo.FieldValue.ParseLong("mdvolume");
				break;

				case "msvolume":
					this.msvolume = fieldInfo.FieldValue.ParseLong("msvolume");
				break;

				case "revolume":
					this.revolume = fieldInfo.FieldValue.ParseLong("revolume");
				break;

				case "mdchecnt":
					this.mdchecnt = fieldInfo.FieldValue.ParseLong("mdchecnt");
				break;

				case "mschecnt":
					this.mschecnt = fieldInfo.FieldValue.ParseLong("mschecnt");
				break;

				case "rechecnt":
					this.rechecnt = fieldInfo.FieldValue.ParseLong("rechecnt");
				break;

				case "volume":
					this.volume = fieldInfo.FieldValue.ParseLong("volume");
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

				case "cvolume":
					this.cvolume = fieldInfo.FieldValue.ParseLong("cvolume");
				break;

				case "mdchecnttm":
					this.mdchecnttm = fieldInfo.FieldValue.ParseLong("mdchecnttm");
				break;

				case "mschecnttm":
					this.mschecnttm = fieldInfo.FieldValue.ParseLong("mschecnttm");
				break;

				case "totofferrem":
					this.totofferrem = fieldInfo.FieldValue.ParseLong("totofferrem");
				break;

				case "totbidrem":
					this.totbidrem = fieldInfo.FieldValue.ParseLong("totbidrem");
				break;

				case "mdvolumetm":
					this.mdvolumetm = fieldInfo.FieldValue.ParseLong("mdvolumetm");
				break;

				case "msvolumetm":
					this.msvolumetm = fieldInfo.FieldValue.ParseLong("msvolumetm");
				break;


			}
		}

		public static XQt1302OutBlock1[] ListFromQuery(XQt1302 query)
		{
			int count = query.GetBlockCount(XQt1302OutBlock1.BlockName);
			List<XQt1302OutBlock1> list = new List<XQt1302OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1302OutBlock1 block = new XQt1302OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.chetime = query.GetFieldData(block.GetBlockName(), "chetime", i).TrimEnd('?'); // char 6
					block.close = query.GetFieldData(block.GetBlockName(), "close", i).ParseLong("close"); // long 8
					block.sign = query.GetFieldData(block.GetBlockName(), "sign", i).FirstOrDefault(); // char 1
					block.change = query.GetFieldData(block.GetBlockName(), "change", i).ParseLong("change"); // long 8
					block.diff = query.GetFieldData(block.GetBlockName(), "diff", i).ParseFloat("diff"); // float 6.2
					block.chdegree = query.GetFieldData(block.GetBlockName(), "chdegree", i).ParseFloat("chdegree"); // float 8.2
					block.mdvolume = query.GetFieldData(block.GetBlockName(), "mdvolume", i).ParseLong("mdvolume"); // long 12
					block.msvolume = query.GetFieldData(block.GetBlockName(), "msvolume", i).ParseLong("msvolume"); // long 12
					block.revolume = query.GetFieldData(block.GetBlockName(), "revolume", i).ParseLong("revolume"); // long 12
					block.mdchecnt = query.GetFieldData(block.GetBlockName(), "mdchecnt", i).ParseLong("mdchecnt"); // long 8
					block.mschecnt = query.GetFieldData(block.GetBlockName(), "mschecnt", i).ParseLong("mschecnt"); // long 8
					block.rechecnt = query.GetFieldData(block.GetBlockName(), "rechecnt", i).ParseLong("rechecnt"); // long 8
					block.volume = query.GetFieldData(block.GetBlockName(), "volume", i).ParseLong("volume"); // long 12
					block.open = query.GetFieldData(block.GetBlockName(), "open", i).ParseLong("open"); // long 8
					block.high = query.GetFieldData(block.GetBlockName(), "high", i).ParseLong("high"); // long 8
					block.low = query.GetFieldData(block.GetBlockName(), "low", i).ParseLong("low"); // long 8
					block.cvolume = query.GetFieldData(block.GetBlockName(), "cvolume", i).ParseLong("cvolume"); // long 12
					block.mdchecnttm = query.GetFieldData(block.GetBlockName(), "mdchecnttm", i).ParseLong("mdchecnttm"); // long 8
					block.mschecnttm = query.GetFieldData(block.GetBlockName(), "mschecnttm", i).ParseLong("mschecnttm"); // long 8
					block.totofferrem = query.GetFieldData(block.GetBlockName(), "totofferrem", i).ParseLong("totofferrem"); // long 12
					block.totbidrem = query.GetFieldData(block.GetBlockName(), "totbidrem", i).ParseLong("totbidrem"); // long 12
					block.mdvolumetm = query.GetFieldData(block.GetBlockName(), "mdvolumetm", i).ParseLong("mdvolumetm"); // long 12
					block.msvolumetm = query.GetFieldData(block.GetBlockName(), "msvolumetm", i).ParseLong("msvolumetm"); // long 12

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
			if (chetime?.Length > 6) return false; // char 6
			if (close.ToString().Length > 8) return false; // long 8
			// sign char 1
			if (change.ToString().Length > 8) return false; // long 8
			// diff float 6.2
			// chdegree float 8.2
			if (mdvolume.ToString().Length > 12) return false; // long 12
			if (msvolume.ToString().Length > 12) return false; // long 12
			if (revolume.ToString().Length > 12) return false; // long 12
			if (mdchecnt.ToString().Length > 8) return false; // long 8
			if (mschecnt.ToString().Length > 8) return false; // long 8
			if (rechecnt.ToString().Length > 8) return false; // long 8
			if (volume.ToString().Length > 12) return false; // long 12
			if (open.ToString().Length > 8) return false; // long 8
			if (high.ToString().Length > 8) return false; // long 8
			if (low.ToString().Length > 8) return false; // long 8
			if (cvolume.ToString().Length > 12) return false; // long 12
			if (mdchecnttm.ToString().Length > 8) return false; // long 8
			if (mschecnttm.ToString().Length > 8) return false; // long 8
			if (totofferrem.ToString().Length > 12) return false; // long 12
			if (totbidrem.ToString().Length > 12) return false; // long 12
			if (mdvolumetm.ToString().Length > 12) return false; // long 12
			if (msvolumetm.ToString().Length > 12) return false; // long 12

			return true;
		}
	}

	public partial class XQt1302 : XingQuery
	{
		/// <summary>
		/// t1302
		/// </summary>
		public const string _typeName = "t1302";
		/// <summary>
		/// 주식분별주가조회(t1302)
		/// </summary>
		public const string _typeDesc = "주식분별주가조회(t1302)";
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
		/// t1302
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 주식분별주가조회(t1302)
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

		public XQt1302() : base("t1302") { }


		public bool SetFields(XQt1302InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "shcode", 0, block.shcode); // char 6
			_xaQuery.SetFieldData(block.GetBlockName(), "gubun", 0, block.gubun.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "time", 0, block.time); // char 6
			_xaQuery.SetFieldData(block.GetBlockName(), "cnt", 0, block.cnt.ToString("d3")); // int 3

			return true;
		}

		public XQt1302OutBlock GetBlock()
		{
			XQt1302OutBlock instance = XQt1302OutBlock.FromQuery(this);
			return instance;

		}

		public XQt1302OutBlock1[] GetBlock1s()
		{
			XQt1302OutBlock1[] instance = XQt1302OutBlock1.ListFromQuery(this);
			return instance;

		}


	}

}
