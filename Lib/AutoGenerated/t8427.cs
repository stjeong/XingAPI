using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt8427InBlock : XingBlock
	{
		/// <summary>
		/// t8427InBlock
		/// </summary>
		public const string _blockName = "t8427InBlock";
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
		/// t8427InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t8427InBlock
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
		/// 선물옵션구분
		/// </summary>
		[XAQueryFieldAttribute("fo_gbn", "선물옵션구분", "char", "1")]
		public char fo_gbn;
		/// <summary>
		/// 조회년도
		/// </summary>
		[XAQueryFieldAttribute("yyyy", "조회년도", "char", "4")]
		public string yyyy;
		/// <summary>
		/// 조회월
		/// </summary>
		[XAQueryFieldAttribute("mm", "조회월", "char", "2")]
		public string mm;
		/// <summary>
		/// 옵션콜풋구분
		/// </summary>
		[XAQueryFieldAttribute("cp_gbn", "옵션콜풋구분", "char", "1")]
		public char cp_gbn;
		/// <summary>
		/// 옵션행사가
		/// </summary>
		[XAQueryFieldAttribute("actprice", "옵션행사가", "float", "6.2")]
		public float actprice;
		/// <summary>
		/// 선물옵션코드
		/// </summary>
		[XAQueryFieldAttribute("focode", "선물옵션코드", "char", "8")]
		public string focode;
		/// <summary>
		/// 일분구분
		/// </summary>
		[XAQueryFieldAttribute("dt_gbn", "일분구분", "char", "1")]
		public char dt_gbn;
		/// <summary>
		/// 분간격
		/// </summary>
		[XAQueryFieldAttribute("min_term", "분간격", "char", "2")]
		public string min_term;
		/// <summary>
		/// 날짜
		/// </summary>
		[XAQueryFieldAttribute("date", "날짜", "char", "8")]
		public string date;
		/// <summary>
		/// 시간
		/// </summary>
		[XAQueryFieldAttribute("time", "시간", "char", "6")]
		public string time;

		public static class F
		{
			/// <summary>
			/// 선물옵션구분
			/// </summary>
			public const string fo_gbn = "fo_gbn";
			/// <summary>
			/// 조회년도
			/// </summary>
			public const string yyyy = "yyyy";
			/// <summary>
			/// 조회월
			/// </summary>
			public const string mm = "mm";
			/// <summary>
			/// 옵션콜풋구분
			/// </summary>
			public const string cp_gbn = "cp_gbn";
			/// <summary>
			/// 옵션행사가
			/// </summary>
			public const string actprice = "actprice";
			/// <summary>
			/// 선물옵션코드
			/// </summary>
			public const string focode = "focode";
			/// <summary>
			/// 일분구분
			/// </summary>
			public const string dt_gbn = "dt_gbn";
			/// <summary>
			/// 분간격
			/// </summary>
			public const string min_term = "min_term";
			/// <summary>
			/// 날짜
			/// </summary>
			public const string date = "date";
			/// <summary>
			/// 시간
			/// </summary>
			public const string time = "time";
		}

		public static string[] AllFields = new string[]
		{
			F.fo_gbn,
			F.yyyy,
			F.mm,
			F.cp_gbn,
			F.actprice,
			F.focode,
			F.dt_gbn,
			F.min_term,
			F.date,
			F.time,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["fo_gbn"] = new XAQueryFieldInfo("char", fo_gbn, fo_gbn.ToString(), "선물옵션구분", (decimal)1);
			dict["yyyy"] = new XAQueryFieldInfo("char", yyyy, yyyy, "조회년도", (decimal)4);
			dict["mm"] = new XAQueryFieldInfo("char", mm, mm, "조회월", (decimal)2);
			dict["cp_gbn"] = new XAQueryFieldInfo("char", cp_gbn, cp_gbn.ToString(), "옵션콜풋구분", (decimal)1);
			dict["actprice"] = new XAQueryFieldInfo("float", actprice, actprice.ToString("000000.00"), "옵션행사가", (decimal)6.2);
			dict["focode"] = new XAQueryFieldInfo("char", focode, focode, "선물옵션코드", (decimal)8);
			dict["dt_gbn"] = new XAQueryFieldInfo("char", dt_gbn, dt_gbn.ToString(), "일분구분", (decimal)1);
			dict["min_term"] = new XAQueryFieldInfo("char", min_term, min_term, "분간격", (decimal)2);
			dict["date"] = new XAQueryFieldInfo("char", date, date, "날짜", (decimal)8);
			dict["time"] = new XAQueryFieldInfo("char", time, time, "시간", (decimal)6);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "fo_gbn":
					this.fo_gbn = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "yyyy":
					this.yyyy = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "mm":
					this.mm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cp_gbn":
					this.cp_gbn = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "actprice":
					this.actprice = fieldInfo.FieldValue.ParseFloat("actprice");
				break;

				case "focode":
					this.focode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "dt_gbn":
					this.dt_gbn = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "min_term":
					this.min_term = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "date":
					this.date = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "time":
					this.time = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			// fo_gbn char 1
			if (yyyy?.Length > 4) return false; // char 4
			if (mm?.Length > 2) return false; // char 2
			// cp_gbn char 1
			// actprice float 6.2
			if (focode?.Length > 8) return false; // char 8
			// dt_gbn char 1
			if (min_term?.Length > 2) return false; // char 2
			if (date?.Length > 8) return false; // char 8
			if (time?.Length > 6) return false; // char 6

			return true;
		}
	}

	public partial class XQt8427OutBlock : XingBlock
	{
		/// <summary>
		/// t8427OutBlock
		/// </summary>
		public const string _blockName = "t8427OutBlock";
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
		/// t8427OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t8427OutBlock
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
		/// 선물옵션코드
		/// </summary>
		[XAQueryFieldAttribute("focode", "선물옵션코드", "char", "8")]
		public string focode;
		/// <summary>
		/// 날짜
		/// </summary>
		[XAQueryFieldAttribute("date", "날짜", "char", "8")]
		public string date;
		/// <summary>
		/// 시간
		/// </summary>
		[XAQueryFieldAttribute("time", "시간", "char", "6")]
		public string time;

		public static class F
		{
			/// <summary>
			/// 선물옵션코드
			/// </summary>
			public const string focode = "focode";
			/// <summary>
			/// 날짜
			/// </summary>
			public const string date = "date";
			/// <summary>
			/// 시간
			/// </summary>
			public const string time = "time";
		}

		public static string[] AllFields = new string[]
		{
			F.focode,
			F.date,
			F.time,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["focode"] = new XAQueryFieldInfo("char", focode, focode, "선물옵션코드", (decimal)8);
			dict["date"] = new XAQueryFieldInfo("char", date, date, "날짜", (decimal)8);
			dict["time"] = new XAQueryFieldInfo("char", time, time, "시간", (decimal)6);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "focode":
					this.focode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "date":
					this.date = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "time":
					this.time = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt8427OutBlock FromQuery(XQt8427 query)
		{
			XQt8427OutBlock block = new XQt8427OutBlock();
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
				block.focode = query.GetFieldData(block.GetBlockName(), "focode", 0).TrimEnd('?'); // char 8
				block.date = query.GetFieldData(block.GetBlockName(), "date", 0).TrimEnd('?'); // char 8
				block.time = query.GetFieldData(block.GetBlockName(), "time", 0).TrimEnd('?'); // char 6

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (focode?.Length > 8) return false; // char 8
			if (date?.Length > 8) return false; // char 8
			if (time?.Length > 6) return false; // char 6

			return true;
		}
	}

	public partial class XQt8427OutBlock1 : XingBlock
	{
		/// <summary>
		/// t8427OutBlock1
		/// </summary>
		public const string _blockName = "t8427OutBlock1";
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
		/// t8427OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t8427OutBlock1
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
		[XAQueryFieldAttribute("time", "시간", "char", "6")]
		public string time;
		/// <summary>
		/// 시가
		/// </summary>
		[XAQueryFieldAttribute("open", "시가", "float", "6.2")]
		public float open;
		/// <summary>
		/// 고가
		/// </summary>
		[XAQueryFieldAttribute("high", "고가", "float", "6.2")]
		public float high;
		/// <summary>
		/// 저가
		/// </summary>
		[XAQueryFieldAttribute("low", "저가", "float", "6.2")]
		public float low;
		/// <summary>
		/// 종가
		/// </summary>
		[XAQueryFieldAttribute("close", "종가", "float", "6.2")]
		public float close;
		/// <summary>
		/// 전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("sign", "전일대비구분", "char", "1")]
		public char sign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[XAQueryFieldAttribute("change", "전일대비", "float", "6.2")]
		public float change;
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
			F.time,
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
			dict["time"] = new XAQueryFieldInfo("char", time, time, "시간", (decimal)6);
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

		public static XQt8427OutBlock1[] ListFromQuery(XQt8427 query)
		{
			int count = query.GetBlockCount(XQt8427OutBlock1.BlockName);
			List<XQt8427OutBlock1> list = new List<XQt8427OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt8427OutBlock1 block = new XQt8427OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.date = query.GetFieldData(block.GetBlockName(), "date", i).TrimEnd('?'); // char 8
					block.time = query.GetFieldData(block.GetBlockName(), "time", i).TrimEnd('?'); // char 6
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
			if (date?.Length > 8) return false; // char 8
			if (time?.Length > 6) return false; // char 6
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

	/// <summary>
	/// 과거데이터시간대별조회(t8427)
	/// </summary>
	public partial class XQt8427 : XingQuery
	{
		/// <summary>
		/// t8427
		/// </summary>
		public const string _typeName = "t8427";
		/// <summary>
		/// 과거데이터시간대별조회(t8427)
		/// </summary>
		public const string _typeDesc = "과거데이터시간대별조회(t8427)";
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
		/// t8427
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 과거데이터시간대별조회(t8427)
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
		/// 과거데이터시간대별조회(t8427)
		/// </summary>
		public XQt8427() : base("t8427") { }


		public class XQAllOutBlocks
		{
			public XQt8427OutBlock OutBlock { get; internal set; }
			public XQt8427OutBlock1[] OutBlock1 { get; internal set; }
		}

		public static XQAllOutBlocks Get(char fo_gbn = default,string yyyy = default,string mm = default,char cp_gbn = default,float actprice = default,string focode = default,char dt_gbn = default,string min_term = default,string date = default,string time = default)
		{
			using (XQt8427 instance = new XQt8427())
			{
				instance.SetFieldData(XQt8427InBlock.BlockName, XQt8427InBlock.F.fo_gbn, 0, fo_gbn.ToString()); // char 1
				instance.SetFieldData(XQt8427InBlock.BlockName, XQt8427InBlock.F.yyyy, 0, yyyy); // char 4
				instance.SetFieldData(XQt8427InBlock.BlockName, XQt8427InBlock.F.mm, 0, mm); // char 2
				instance.SetFieldData(XQt8427InBlock.BlockName, XQt8427InBlock.F.cp_gbn, 0, cp_gbn.ToString()); // char 1
				instance.SetFieldData(XQt8427InBlock.BlockName, XQt8427InBlock.F.actprice, 0, actprice.ToString("000000.00")); // float 6.2
				instance.SetFieldData(XQt8427InBlock.BlockName, XQt8427InBlock.F.focode, 0, focode); // char 8
				instance.SetFieldData(XQt8427InBlock.BlockName, XQt8427InBlock.F.dt_gbn, 0, dt_gbn.ToString()); // char 1
				instance.SetFieldData(XQt8427InBlock.BlockName, XQt8427InBlock.F.min_term, 0, min_term); // char 2
				instance.SetFieldData(XQt8427InBlock.BlockName, XQt8427InBlock.F.date, 0, date); // char 8
				instance.SetFieldData(XQt8427InBlock.BlockName, XQt8427InBlock.F.time, 0, time); // char 6

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

		public static XQAllOutBlocks ReadFromDB(string tableNamePostfix = null /*, char fo_gbn = default,string yyyy = default,string mm = default,char cp_gbn = default,float actprice = default,string focode = default,char dt_gbn = default,string min_term = default,string date = default,string time = default */)
		{
			using (XQt8427 instance = new XQt8427())
			{

				XQAllOutBlocks results = new XQAllOutBlocks();

				string tableName = (tableNamePostfix == null) ? "XQt8427OutBlock" : $"XQt8427OutBlock_{tableNamePostfix}";
				QueryOption qo = new QueryOption(tableName);
				results.OutBlock = instance.Select<XQt8427OutBlock>(qo);

				tableName = (tableNamePostfix == null) ? "XQt8427OutBlock1" : $"XQt8427OutBlock1_{tableNamePostfix}";
				qo = new QueryOption(tableName);
				results.OutBlock1 = instance.SelectMany<XQt8427OutBlock1>(qo);
				return results;
			}
		}

		public bool SetBlock(XQt8427InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "fo_gbn", 0, block.fo_gbn.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "yyyy", 0, block.yyyy); // char 4
			_xaQuery.SetFieldData(block.GetBlockName(), "mm", 0, block.mm); // char 2
			_xaQuery.SetFieldData(block.GetBlockName(), "cp_gbn", 0, block.cp_gbn.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "actprice", 0, block.actprice.ToString("000000.00")); // float 6.2
			_xaQuery.SetFieldData(block.GetBlockName(), "focode", 0, block.focode); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "dt_gbn", 0, block.dt_gbn.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "min_term", 0, block.min_term); // char 2
			_xaQuery.SetFieldData(block.GetBlockName(), "date", 0, block.date); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "time", 0, block.time); // char 6

			return true;
		}

		public XQt8427OutBlock GetBlock()
		{
			XQt8427OutBlock instance = XQt8427OutBlock.FromQuery(this);
			return instance;

		}

		public XQt8427OutBlock1[] GetBlock1s()
		{
			XQt8427OutBlock1[] instance = XQt8427OutBlock1.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt8427OutBlock),
			typeof(XQt8427OutBlock1),

		};

	}

}
