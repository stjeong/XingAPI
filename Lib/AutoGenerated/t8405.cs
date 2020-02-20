using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt8405InBlock : XingBlock
	{
		/// <summary>
		/// t8405InBlock
		/// </summary>
		public const string _blockName = "t8405InBlock";
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
		/// t8405InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t8405InBlock
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
		[XAQueryFieldAttribute("shcode", "단축코드", "char", "8")]
		public string shcode;
		/// <summary>
		/// 선물최근월물
		/// </summary>
		[XAQueryFieldAttribute("futcheck", "선물최근월물", "char", "1")]
		public char futcheck;
		/// <summary>
		/// 날짜
		/// </summary>
		[XAQueryFieldAttribute("date", "날짜", "char", "8")]
		public string date;
		/// <summary>
		/// CTS종목코드
		/// </summary>
		[XAQueryFieldAttribute("cts_code", "CTS종목코드", "char", "8")]
		public string cts_code;
		/// <summary>
		/// 전종목만기일
		/// </summary>
		[XAQueryFieldAttribute("lastdate", "전종목만기일", "char", "8")]
		public string lastdate;
		/// <summary>
		/// 조회요청건수
		/// </summary>
		[XAQueryFieldAttribute("cnt", "조회요청건수", "int", "3")]
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
			if (shcode?.Length > 8) return false; // char 8
			// futcheck char 1
			if (date?.Length > 8) return false; // char 8
			if (cts_code?.Length > 8) return false; // char 8
			if (lastdate?.Length > 8) return false; // char 8
			// cnt int 3

			return true;
		}
	}

	public partial class XQt8405OutBlock : XingBlock
	{
		/// <summary>
		/// t8405OutBlock
		/// </summary>
		public const string _blockName = "t8405OutBlock";
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
		/// t8405OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t8405OutBlock
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
		[XAQueryFieldAttribute("date", "날짜", "char", "8")]
		public string date;
		/// <summary>
		/// CTS종목코드
		/// </summary>
		[XAQueryFieldAttribute("cts_code", "CTS종목코드", "char", "8")]
		public string cts_code;
		/// <summary>
		/// 전종목만기일
		/// </summary>
		[XAQueryFieldAttribute("lastdate", "전종목만기일", "char", "8")]
		public string lastdate;
		/// <summary>
		/// 최근월선물여부
		/// </summary>
		[XAQueryFieldAttribute("nowfutyn", "최근월선물여부", "char", "1")]
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

		public static XQt8405OutBlock FromQuery(XQt8405 query)
		{
			XQt8405OutBlock block = new XQt8405OutBlock();
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
			if (date?.Length > 8) return false; // char 8
			if (cts_code?.Length > 8) return false; // char 8
			if (lastdate?.Length > 8) return false; // char 8
			// nowfutyn char 1

			return true;
		}
	}

	public partial class XQt8405OutBlock1 : XingBlock
	{
		/// <summary>
		/// t8405OutBlock1
		/// </summary>
		public const string _blockName = "t8405OutBlock1";
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
		/// t8405OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t8405OutBlock1
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
		/// 전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("sign", "전일대비구분", "char", "1")]
		public char sign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[XAQueryFieldAttribute("change", "전일대비", "long", "8")]
		public long change;
		/// <summary>
		/// 등락율
		/// </summary>
		[XAQueryFieldAttribute("diff", "등락율", "float", "6.2")]
		public float diff;
		/// <summary>
		/// 거래량
		/// </summary>
		[XAQueryFieldAttribute("volume", "거래량", "long", "12")]
		public long volume;
		/// <summary>
		/// 거래증가율
		/// </summary>
		[XAQueryFieldAttribute("diff_vol", "거래증가율", "float", "10.2")]
		public float diff_vol;
		/// <summary>
		/// 미결수량
		/// </summary>
		[XAQueryFieldAttribute("openyak", "미결수량", "long", "8")]
		public long openyak;
		/// <summary>
		/// 미결증감
		/// </summary>
		[XAQueryFieldAttribute("openyakupdn", "미결증감", "long", "8")]
		public long openyakupdn;
		/// <summary>
		/// 거래대금
		/// </summary>
		[XAQueryFieldAttribute("value", "거래대금", "float", "12")]
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
			dict["open"] = new XAQueryFieldInfo("long", open, open.ToString("d8"), "시가", (decimal)8);
			dict["high"] = new XAQueryFieldInfo("long", high, high.ToString("d8"), "고가", (decimal)8);
			dict["low"] = new XAQueryFieldInfo("long", low, low.ToString("d8"), "저가", (decimal)8);
			dict["close"] = new XAQueryFieldInfo("long", close, close.ToString("d8"), "종가", (decimal)8);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("long", change, change.ToString("d8"), "전일대비", (decimal)8);
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

		public static XQt8405OutBlock1[] ListFromQuery(XQt8405 query)
		{
			int count = query.GetBlockCount(XQt8405OutBlock1.BlockName);
			List<XQt8405OutBlock1> list = new List<XQt8405OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt8405OutBlock1 block = new XQt8405OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.date = query.GetFieldData(block.GetBlockName(), "date", i).TrimEnd('?'); // char 8
					block.open = query.GetFieldData(block.GetBlockName(), "open", i).ParseLong("open"); // long 8
					block.high = query.GetFieldData(block.GetBlockName(), "high", i).ParseLong("high"); // long 8
					block.low = query.GetFieldData(block.GetBlockName(), "low", i).ParseLong("low"); // long 8
					block.close = query.GetFieldData(block.GetBlockName(), "close", i).ParseLong("close"); // long 8
					block.sign = query.GetFieldData(block.GetBlockName(), "sign", i).FirstOrDefault(); // char 1
					block.change = query.GetFieldData(block.GetBlockName(), "change", i).ParseLong("change"); // long 8
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
			if (date?.Length > 8) return false; // char 8
			if (open.ToString().Length > 8) return false; // long 8
			if (high.ToString().Length > 8) return false; // long 8
			if (low.ToString().Length > 8) return false; // long 8
			if (close.ToString().Length > 8) return false; // long 8
			// sign char 1
			if (change.ToString().Length > 8) return false; // long 8
			// diff float 6.2
			if (volume.ToString().Length > 12) return false; // long 12
			// diff_vol float 10.2
			if (openyak.ToString().Length > 8) return false; // long 8
			if (openyakupdn.ToString().Length > 8) return false; // long 8
			// value float 12

			return true;
		}
	}

	/// <summary>
	/// 주식선물기간별주가(API용)(t8405)
	/// </summary>
	public partial class XQt8405 : XingQuery
	{
		/// <summary>
		/// t8405
		/// </summary>
		public const string _typeName = "t8405";
		/// <summary>
		/// 주식선물기간별주가(API용)(t8405)
		/// </summary>
		public const string _typeDesc = "주식선물기간별주가(API용)(t8405)";
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
		/// t8405
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 주식선물기간별주가(API용)(t8405)
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
		/// 주식선물기간별주가(API용)(t8405)
		/// </summary>
		public XQt8405() : base("t8405") { }


		public class XQAllOutBlocks
		{
			public XQt8405OutBlock OutBlock { get; internal set; }
			public XQt8405OutBlock1[] OutBlock1 { get; internal set; }
		}

		public static XQAllOutBlocks Get(string shcode = default,char futcheck = default,string date = default,string cts_code = default,string lastdate = default,int cnt = default)
		{
			using (XQt8405 instance = new XQt8405())
			{
				instance.SetFieldData(XQt8405InBlock.BlockName, XQt8405InBlock.F.shcode, 0, shcode); // char 8
				instance.SetFieldData(XQt8405InBlock.BlockName, XQt8405InBlock.F.futcheck, 0, futcheck.ToString()); // char 1
				instance.SetFieldData(XQt8405InBlock.BlockName, XQt8405InBlock.F.date, 0, date); // char 8
				instance.SetFieldData(XQt8405InBlock.BlockName, XQt8405InBlock.F.cts_code, 0, cts_code); // char 8
				instance.SetFieldData(XQt8405InBlock.BlockName, XQt8405InBlock.F.lastdate, 0, lastdate); // char 8
				instance.SetFieldData(XQt8405InBlock.BlockName, XQt8405InBlock.F.cnt, 0, cnt.ToString("d3")); // int 3

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

		public static XQAllOutBlocks ReadFromDB(string tableNamePostfix = null /*, string shcode = default,char futcheck = default,string date = default,string cts_code = default,string lastdate = default,int cnt = default */)
		{
			using (XQt8405 instance = new XQt8405())
			{

				XQAllOutBlocks results = new XQAllOutBlocks();

				string tableName = (tableNamePostfix == null) ? "XQt8405OutBlock" : $"XQt8405OutBlock_{tableNamePostfix}";
				QueryOption qo = new QueryOption(tableName);
				results.OutBlock = instance.Select<XQt8405OutBlock>(qo);

				tableName = (tableNamePostfix == null) ? "XQt8405OutBlock1" : $"XQt8405OutBlock1_{tableNamePostfix}";
				qo = new QueryOption(tableName);
				results.OutBlock1 = instance.SelectMany<XQt8405OutBlock1>(qo);
				return results;
			}
		}

		public bool SetBlock(XQt8405InBlock block)
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

		public XQt8405OutBlock GetBlock()
		{
			XQt8405OutBlock instance = XQt8405OutBlock.FromQuery(this);
			return instance;

		}

		public XQt8405OutBlock1[] GetBlock1s()
		{
			XQt8405OutBlock1[] instance = XQt8405OutBlock1.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt8405OutBlock),
			typeof(XQt8405OutBlock1),

		};

	}

}
