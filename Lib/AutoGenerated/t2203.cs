using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt2203InBlock : XingBlock
	{
		/// <summary>
		/// t2203InBlock
		/// </summary>
		static readonly string _blockName = "t2203InBlock";
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
		/// t2203InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t2203InBlock
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
		/// 선물최근월물
		/// </summary>
		[XAQueryFieldAttribute("선물최근월물")]
		public char futcheck;
		/// <summary>
		/// 날짜
		/// </summary>
		[XAQueryFieldAttribute("날짜")]
		public string date;
		/// <summary>
		/// CTS종목코드
		/// </summary>
		[XAQueryFieldAttribute("CTS종목코드")]
		public string cts_code;
		/// <summary>
		/// 전종목만기일
		/// </summary>
		[XAQueryFieldAttribute("전종목만기일")]
		public string lastdate;
		/// <summary>
		/// 조회요청건수
		/// </summary>
		[XAQueryFieldAttribute("조회요청건수")]
		public int cnt;

		public static class F
		{
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 선물최근월물
			/// </summary>
			public const string futcheck = "futcheck";
			/// <summary>
			/// 날짜
			/// </summary>
			public const string date = "date";
			/// <summary>
			/// CTS종목코드
			/// </summary>
			public const string cts_code = "cts_code";
			/// <summary>
			/// 전종목만기일
			/// </summary>
			public const string lastdate = "lastdate";
			/// <summary>
			/// 조회요청건수
			/// </summary>
			public const string cnt = "cnt";
		}

		public static string[] AllFields = new string[]
		{
			F.shcode,
			F.futcheck,
			F.date,
			F.cts_code,
			F.lastdate,
			F.cnt,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)8);
			dict["futcheck"] = new XAQueryFieldInfo("char", futcheck, futcheck.ToString(), "선물최근월물", (decimal)1);
			dict["date"] = new XAQueryFieldInfo("char", date, date, "날짜", (decimal)8);
			dict["cts_code"] = new XAQueryFieldInfo("char", cts_code, cts_code, "CTS종목코드", (decimal)8);
			dict["lastdate"] = new XAQueryFieldInfo("char", lastdate, lastdate, "전종목만기일", (decimal)8);
			dict["cnt"] = new XAQueryFieldInfo("int", cnt, cnt.ToString("d3"), "조회요청건수", (decimal)3);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "futcheck":
					this.futcheck = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "date":
					this.date = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cts_code":
					this.cts_code = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "lastdate":
					this.lastdate = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cnt":
					this.cnt = fieldInfo.FieldValue.ParseInt("cnt");
				break;


			}
		}

		public bool VerifyData()
		{
			if (shcode.Length > 8) return false; // char 8
			// futcheck char 1
			if (date.Length > 8) return false; // char 8
			if (cts_code.Length > 8) return false; // char 8
			if (lastdate.Length > 8) return false; // char 8
			// cnt int 3

			return true;
		}
	}

	public partial class XQt2203OutBlock : XingBlock
	{
		/// <summary>
		/// t2203OutBlock
		/// </summary>
		static readonly string _blockName = "t2203OutBlock";
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
		/// t2203OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t2203OutBlock
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
		/// 날짜
		/// </summary>
		[XAQueryFieldAttribute("날짜")]
		public string date;
		/// <summary>
		/// CTS종목코드
		/// </summary>
		[XAQueryFieldAttribute("CTS종목코드")]
		public string cts_code;
		/// <summary>
		/// 전종목만기일
		/// </summary>
		[XAQueryFieldAttribute("전종목만기일")]
		public string lastdate;
		/// <summary>
		/// 최근월선물여부
		/// </summary>
		[XAQueryFieldAttribute("최근월선물여부")]
		public char nowfutyn;

		public static class F
		{
			/// <summary>
			/// 날짜
			/// </summary>
			public const string date = "date";
			/// <summary>
			/// CTS종목코드
			/// </summary>
			public const string cts_code = "cts_code";
			/// <summary>
			/// 전종목만기일
			/// </summary>
			public const string lastdate = "lastdate";
			/// <summary>
			/// 최근월선물여부
			/// </summary>
			public const string nowfutyn = "nowfutyn";
		}

		public static string[] AllFields = new string[]
		{
			F.date,
			F.cts_code,
			F.lastdate,
			F.nowfutyn,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["date"] = new XAQueryFieldInfo("char", date, date, "날짜", (decimal)8);
			dict["cts_code"] = new XAQueryFieldInfo("char", cts_code, cts_code, "CTS종목코드", (decimal)8);
			dict["lastdate"] = new XAQueryFieldInfo("char", lastdate, lastdate, "전종목만기일", (decimal)8);
			dict["nowfutyn"] = new XAQueryFieldInfo("char", nowfutyn, nowfutyn.ToString(), "최근월선물여부", (decimal)1);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "date":
					this.date = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cts_code":
					this.cts_code = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "lastdate":
					this.lastdate = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "nowfutyn":
					this.nowfutyn = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public static XQt2203OutBlock FromQuery(XQt2203 query)
		{
			XQt2203OutBlock block = new XQt2203OutBlock();
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
				block.date = query.GetFieldData(block.GetBlockName(), "date", 0).TrimEnd('?'); // char 8
				block.cts_code = query.GetFieldData(block.GetBlockName(), "cts_code", 0).TrimEnd('?'); // char 8
				block.lastdate = query.GetFieldData(block.GetBlockName(), "lastdate", 0).TrimEnd('?'); // char 8
				block.nowfutyn = query.GetFieldData(block.GetBlockName(), "nowfutyn", 0).FirstOrDefault(); // char 1

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (date.Length > 8) return false; // char 8
			if (cts_code.Length > 8) return false; // char 8
			if (lastdate.Length > 8) return false; // char 8
			// nowfutyn char 1

			return true;
		}
	}

	public partial class XQt2203OutBlock1 : XingBlock
	{
		/// <summary>
		/// t2203OutBlock1
		/// </summary>
		static readonly string _blockName = "t2203OutBlock1";
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
		/// t2203OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t2203OutBlock1
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
		/// 전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("전일대비구분")]
		public char sign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[XAQueryFieldAttribute("전일대비")]
		public float change;
		/// <summary>
		/// 등락율
		/// </summary>
		[XAQueryFieldAttribute("등락율")]
		public float diff;
		/// <summary>
		/// 거래량
		/// </summary>
		[XAQueryFieldAttribute("거래량")]
		public long volume;
		/// <summary>
		/// 거래증가율
		/// </summary>
		[XAQueryFieldAttribute("거래증가율")]
		public float diff_vol;
		/// <summary>
		/// 미결수량
		/// </summary>
		[XAQueryFieldAttribute("미결수량")]
		public long openyak;
		/// <summary>
		/// 미결증감
		/// </summary>
		[XAQueryFieldAttribute("미결증감")]
		public long openyakupdn;
		/// <summary>
		/// 거래대금
		/// </summary>
		[XAQueryFieldAttribute("거래대금")]
		public float value;

		public static class F
		{
			/// <summary>
			/// 날짜
			/// </summary>
			public const string date = "date";
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
			/// 거래량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// 거래증가율
			/// </summary>
			public const string diff_vol = "diff_vol";
			/// <summary>
			/// 미결수량
			/// </summary>
			public const string openyak = "openyak";
			/// <summary>
			/// 미결증감
			/// </summary>
			public const string openyakupdn = "openyakupdn";
			/// <summary>
			/// 거래대금
			/// </summary>
			public const string value = "value";
		}

		public static string[] AllFields = new string[]
		{
			F.date,
			F.open,
			F.high,
			F.low,
			F.close,
			F.sign,
			F.change,
			F.diff,
			F.volume,
			F.diff_vol,
			F.openyak,
			F.openyakupdn,
			F.value,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["date"] = new XAQueryFieldInfo("char", date, date, "날짜", (decimal)8);
			dict["open"] = new XAQueryFieldInfo("float", open, open.ToString("000000.00"), "시가", (decimal)6.2);
			dict["high"] = new XAQueryFieldInfo("float", high, high.ToString("000000.00"), "고가", (decimal)6.2);
			dict["low"] = new XAQueryFieldInfo("float", low, low.ToString("000000.00"), "저가", (decimal)6.2);
			dict["close"] = new XAQueryFieldInfo("float", close, close.ToString("000000.00"), "종가", (decimal)6.2);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("float", change, change.ToString("000000.00"), "전일대비", (decimal)6.2);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "거래량", (decimal)12);
			dict["diff_vol"] = new XAQueryFieldInfo("float", diff_vol, diff_vol.ToString("0000000000.00"), "거래증가율", (decimal)10.2);
			dict["openyak"] = new XAQueryFieldInfo("long", openyak, openyak.ToString("d8"), "미결수량", (decimal)8);
			dict["openyakupdn"] = new XAQueryFieldInfo("long", openyakupdn, openyakupdn.ToString("d8"), "미결증감", (decimal)8);
			dict["value"] = new XAQueryFieldInfo("float", value, value.ToString("000000000000"), "거래대금", (decimal)12);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "date":
					this.date = fieldInfo.FieldValue.TrimEnd('?');
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

				case "sign":
					this.sign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "change":
					this.change = fieldInfo.FieldValue.ParseFloat("change");
				break;

				case "diff":
					this.diff = fieldInfo.FieldValue.ParseFloat("diff");
				break;

				case "volume":
					this.volume = fieldInfo.FieldValue.ParseLong("volume");
				break;

				case "diff_vol":
					this.diff_vol = fieldInfo.FieldValue.ParseFloat("diff_vol");
				break;

				case "openyak":
					this.openyak = fieldInfo.FieldValue.ParseLong("openyak");
				break;

				case "openyakupdn":
					this.openyakupdn = fieldInfo.FieldValue.ParseLong("openyakupdn");
				break;

				case "value":
					this.value = fieldInfo.FieldValue.ParseFloat("value");
				break;


			}
		}

		public static XQt2203OutBlock1[] ListFromQuery(XQt2203 query)
		{
			int count = query.GetBlockCount(XQt2203OutBlock1.BlockName);
			List<XQt2203OutBlock1> list = new List<XQt2203OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt2203OutBlock1 block = new XQt2203OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.date = query.GetFieldData(block.GetBlockName(), "date", i).TrimEnd('?'); // char 8
					block.open = query.GetFieldData(block.GetBlockName(), "open", i).ParseFloat("open"); // float 6.2
					block.high = query.GetFieldData(block.GetBlockName(), "high", i).ParseFloat("high"); // float 6.2
					block.low = query.GetFieldData(block.GetBlockName(), "low", i).ParseFloat("low"); // float 6.2
					block.close = query.GetFieldData(block.GetBlockName(), "close", i).ParseFloat("close"); // float 6.2
					block.sign = query.GetFieldData(block.GetBlockName(), "sign", i).FirstOrDefault(); // char 1
					block.change = query.GetFieldData(block.GetBlockName(), "change", i).ParseFloat("change"); // float 6.2
					block.diff = query.GetFieldData(block.GetBlockName(), "diff", i).ParseFloat("diff"); // float 6.2
					block.volume = query.GetFieldData(block.GetBlockName(), "volume", i).ParseLong("volume"); // long 12
					block.diff_vol = query.GetFieldData(block.GetBlockName(), "diff_vol", i).ParseFloat("diff_vol"); // float 10.2
					block.openyak = query.GetFieldData(block.GetBlockName(), "openyak", i).ParseLong("openyak"); // long 8
					block.openyakupdn = query.GetFieldData(block.GetBlockName(), "openyakupdn", i).ParseLong("openyakupdn"); // long 8
					block.value = query.GetFieldData(block.GetBlockName(), "value", i).ParseFloat("value"); // float 12

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
			// open float 6.2
			// high float 6.2
			// low float 6.2
			// close float 6.2
			// sign char 1
			// change float 6.2
			// diff float 6.2
			if (volume.ToString().Length > 12) return false; // long 12
			// diff_vol float 10.2
			if (openyak.ToString().Length > 8) return false; // long 8
			if (openyakupdn.ToString().Length > 8) return false; // long 8
			// value float 12

			return true;
		}
	}

	public partial class XQt2203 : XingQuery
	{
		/// <summary>
		/// t2203
		/// </summary>
		static readonly string _typeName = "t2203";
		/// <summary>
		/// 기간별주가(t2203)
		/// </summary>
		static readonly string _typeDesc = "기간별주가(t2203)";
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
		/// t2203
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 기간별주가(t2203)
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

		public XQt2203() : base("t2203") { }


		public bool SetFields(XQt2203InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "shcode", 0, block.shcode); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "futcheck", 0, block.futcheck.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "date", 0, block.date); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "cts_code", 0, block.cts_code); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "lastdate", 0, block.lastdate); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "cnt", 0, block.cnt.ToString("d3")); // int 3

			return true;
		}

		public XQt2203OutBlock GetBlock()
		{
			XQt2203OutBlock instance = XQt2203OutBlock.FromQuery(this);
			return instance;

		}

		public XQt2203OutBlock1[] GetBlock1s()
		{
			XQt2203OutBlock1[] instance = XQt2203OutBlock1.ListFromQuery(this);
			return instance;

		}


	}

}
