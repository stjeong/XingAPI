using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt3518InBlock : XingBlock
	{
		/// <summary>
		/// t3518InBlock
		/// </summary>
		public const string _blockName = "t3518InBlock";
		/// <summary>
		/// 입력
		/// </summary>
		public const string _blockDesc = "입력";
		/// <summary>
		/// input
		/// </summary>
		public const string _blockType = "input";
		/// <summary>
		/// false
		/// </summary>
		public const bool _hasOccurs = false;
		/// <summary>
		/// t3518InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t3518InBlock
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// 입력
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
		/// 종목종류
		/// </summary>
		[XAQueryFieldAttribute("종목종류")]
		public char kind;
		/// <summary>
		/// SYMBOL
		/// </summary>
		[XAQueryFieldAttribute("SYMBOL")]
		public string symbol;
		/// <summary>
		/// 입력건수
		/// </summary>
		[XAQueryFieldAttribute("입력건수")]
		public long cnt;
		/// <summary>
		/// 조회구분
		/// </summary>
		[XAQueryFieldAttribute("조회구분")]
		public char jgbn;
		/// <summary>
		/// N분
		/// </summary>
		[XAQueryFieldAttribute("N분")]
		public long nmin;
		/// <summary>
		/// CTS_DATE
		/// </summary>
		[XAQueryFieldAttribute("CTS_DATE")]
		public string cts_date;
		/// <summary>
		/// CTS_TIME
		/// </summary>
		[XAQueryFieldAttribute("CTS_TIME")]
		public string cts_time;

		public static class F
		{
			/// <summary>
			/// 종목종류
			/// </summary>
			public const string kind = "kind";
			/// <summary>
			/// SYMBOL
			/// </summary>
			public const string symbol = "symbol";
			/// <summary>
			/// 입력건수
			/// </summary>
			public const string cnt = "cnt";
			/// <summary>
			/// 조회구분
			/// </summary>
			public const string jgbn = "jgbn";
			/// <summary>
			/// N분
			/// </summary>
			public const string nmin = "nmin";
			/// <summary>
			/// CTS_DATE
			/// </summary>
			public const string cts_date = "cts_date";
			/// <summary>
			/// CTS_TIME
			/// </summary>
			public const string cts_time = "cts_time";
		}

		public static string[] AllFields = new string[]
		{
			F.kind,
			F.symbol,
			F.cnt,
			F.jgbn,
			F.nmin,
			F.cts_date,
			F.cts_time,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["kind"] = new XAQueryFieldInfo("char", kind, kind.ToString(), "종목종류", (decimal)1);
			dict["symbol"] = new XAQueryFieldInfo("char", symbol, symbol, "SYMBOL", (decimal)16);
			dict["cnt"] = new XAQueryFieldInfo("long", cnt, cnt.ToString("d4"), "입력건수", (decimal)4);
			dict["jgbn"] = new XAQueryFieldInfo("char", jgbn, jgbn.ToString(), "조회구분", (decimal)1);
			dict["nmin"] = new XAQueryFieldInfo("long", nmin, nmin.ToString("d3"), "N분", (decimal)3);
			dict["cts_date"] = new XAQueryFieldInfo("char", cts_date, cts_date, "CTS_DATE", (decimal)8);
			dict["cts_time"] = new XAQueryFieldInfo("char", cts_time, cts_time, "CTS_TIME", (decimal)6);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "kind":
					this.kind = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "symbol":
					this.symbol = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cnt":
					this.cnt = fieldInfo.FieldValue.ParseLong("cnt");
				break;

				case "jgbn":
					this.jgbn = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "nmin":
					this.nmin = fieldInfo.FieldValue.ParseLong("nmin");
				break;

				case "cts_date":
					this.cts_date = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cts_time":
					this.cts_time = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			// kind char 1
			if (symbol?.Length > 16) return false; // char 16
			if (cnt.ToString().Length > 4) return false; // long 4
			// jgbn char 1
			if (nmin.ToString().Length > 3) return false; // long 3
			if (cts_date?.Length > 8) return false; // char 8
			if (cts_time?.Length > 6) return false; // char 6

			return true;
		}
	}

	public partial class XQt3518OutBlock : XingBlock
	{
		/// <summary>
		/// t3518OutBlock
		/// </summary>
		public const string _blockName = "t3518OutBlock";
		/// <summary>
		/// 단일출력
		/// </summary>
		public const string _blockDesc = "단일출력";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// false
		/// </summary>
		public const bool _hasOccurs = false;
		/// <summary>
		/// t3518OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t3518OutBlock
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// 단일출력
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
		/// CTS_DATE
		/// </summary>
		[XAQueryFieldAttribute("CTS_DATE")]
		public string cts_date;
		/// <summary>
		/// CTS_TIME
		/// </summary>
		[XAQueryFieldAttribute("CTS_TIME")]
		public string cts_time;

		public static class F
		{
			/// <summary>
			/// CTS_DATE
			/// </summary>
			public const string cts_date = "cts_date";
			/// <summary>
			/// CTS_TIME
			/// </summary>
			public const string cts_time = "cts_time";
		}

		public static string[] AllFields = new string[]
		{
			F.cts_date,
			F.cts_time,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["cts_date"] = new XAQueryFieldInfo("char", cts_date, cts_date, "CTS_DATE", (decimal)8);
			dict["cts_time"] = new XAQueryFieldInfo("char", cts_time, cts_time, "CTS_TIME", (decimal)6);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "cts_date":
					this.cts_date = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cts_time":
					this.cts_time = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt3518OutBlock FromQuery(XQt3518 query)
		{
			XQt3518OutBlock block = new XQt3518OutBlock();
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
				block.cts_date = query.GetFieldData(block.GetBlockName(), "cts_date", 0).TrimEnd('?'); // char 8
				block.cts_time = query.GetFieldData(block.GetBlockName(), "cts_time", 0).TrimEnd('?'); // char 6

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (cts_date?.Length > 8) return false; // char 8
			if (cts_time?.Length > 6) return false; // char 6

			return true;
		}
	}

	public partial class XQt3518OutBlock1 : XingBlock
	{
		/// <summary>
		/// t3518OutBlock1
		/// </summary>
		public const string _blockName = "t3518OutBlock1";
		/// <summary>
		/// 멀티출력
		/// </summary>
		public const string _blockDesc = "멀티출력";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// true
		/// </summary>
		public const bool _hasOccurs = true;
		/// <summary>
		/// t3518OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t3518OutBlock1
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// 멀티출력
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
		/// 시간
		/// </summary>
		[XAQueryFieldAttribute("시간")]
		public string time;
		/// <summary>
		/// 시가
		/// </summary>
		[XAQueryFieldAttribute("시가")]
		public double open;
		/// <summary>
		/// 고가
		/// </summary>
		[XAQueryFieldAttribute("고가")]
		public double high;
		/// <summary>
		/// 저가
		/// </summary>
		[XAQueryFieldAttribute("저가")]
		public double low;
		/// <summary>
		/// 현재가
		/// </summary>
		[XAQueryFieldAttribute("현재가")]
		public double price;
		/// <summary>
		/// 전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("전일대비구분")]
		public char sign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[XAQueryFieldAttribute("전일대비")]
		public double change;
		/// <summary>
		/// 등락율
		/// </summary>
		[XAQueryFieldAttribute("등락율")]
		public double uprate;
		/// <summary>
		/// 누적거래량
		/// </summary>
		[XAQueryFieldAttribute("누적거래량")]
		public double volume;
		/// <summary>
		/// 매수호가
		/// </summary>
		[XAQueryFieldAttribute("매수호가")]
		public double bidho;
		/// <summary>
		/// 매도호가
		/// </summary>
		[XAQueryFieldAttribute("매도호가")]
		public double offerho;
		/// <summary>
		/// 매수잔량
		/// </summary>
		[XAQueryFieldAttribute("매수잔량")]
		public double bidrem;
		/// <summary>
		/// 매도잔량
		/// </summary>
		[XAQueryFieldAttribute("매도잔량")]
		public double offerrem;
		/// <summary>
		/// 종목종류
		/// </summary>
		[XAQueryFieldAttribute("종목종류")]
		public char kind;
		/// <summary>
		/// SYMBOL
		/// </summary>
		[XAQueryFieldAttribute("SYMBOL")]
		public string symbol;
		/// <summary>
		/// EXID
		/// </summary>
		[XAQueryFieldAttribute("EXID")]
		public string exid;
		/// <summary>
		/// 한국일자
		/// </summary>
		[XAQueryFieldAttribute("한국일자")]
		public string kodate;
		/// <summary>
		/// 한국시간
		/// </summary>
		[XAQueryFieldAttribute("한국시간")]
		public string kotime;

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
			/// 현재가
			/// </summary>
			public const string price = "price";
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
			public const string uprate = "uprate";
			/// <summary>
			/// 누적거래량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// 매수호가
			/// </summary>
			public const string bidho = "bidho";
			/// <summary>
			/// 매도호가
			/// </summary>
			public const string offerho = "offerho";
			/// <summary>
			/// 매수잔량
			/// </summary>
			public const string bidrem = "bidrem";
			/// <summary>
			/// 매도잔량
			/// </summary>
			public const string offerrem = "offerrem";
			/// <summary>
			/// 종목종류
			/// </summary>
			public const string kind = "kind";
			/// <summary>
			/// SYMBOL
			/// </summary>
			public const string symbol = "symbol";
			/// <summary>
			/// EXID
			/// </summary>
			public const string exid = "exid";
			/// <summary>
			/// 한국일자
			/// </summary>
			public const string kodate = "kodate";
			/// <summary>
			/// 한국시간
			/// </summary>
			public const string kotime = "kotime";
		}

		public static string[] AllFields = new string[]
		{
			F.date,
			F.time,
			F.open,
			F.high,
			F.low,
			F.price,
			F.sign,
			F.change,
			F.uprate,
			F.volume,
			F.bidho,
			F.offerho,
			F.bidrem,
			F.offerrem,
			F.kind,
			F.symbol,
			F.exid,
			F.kodate,
			F.kotime,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["date"] = new XAQueryFieldInfo("char", date, date, "일자", (decimal)8);
			dict["time"] = new XAQueryFieldInfo("char", time, time, "시간", (decimal)8);
			dict["open"] = new XAQueryFieldInfo("double", open, open.ToString("000000000.0000"), "시가", (decimal)9.4);
			dict["high"] = new XAQueryFieldInfo("double", high, high.ToString("000000000.0000"), "고가", (decimal)9.4);
			dict["low"] = new XAQueryFieldInfo("double", low, low.ToString("000000000.0000"), "저가", (decimal)9.4);
			dict["price"] = new XAQueryFieldInfo("double", price, price.ToString("000000000.0000"), "현재가", (decimal)9.4);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("double", change, change.ToString("000000000.0000"), "전일대비", (decimal)9.4);
			dict["uprate"] = new XAQueryFieldInfo("double", uprate, uprate.ToString("000000000.0000"), "등락율", (decimal)9.4);
			dict["volume"] = new XAQueryFieldInfo("double", volume, volume.ToString("000000000000."), "누적거래량", (decimal)12.0);
			dict["bidho"] = new XAQueryFieldInfo("double", bidho, bidho.ToString("000000000.0000"), "매수호가", (decimal)9.4);
			dict["offerho"] = new XAQueryFieldInfo("double", offerho, offerho.ToString("000000000.0000"), "매도호가", (decimal)9.4);
			dict["bidrem"] = new XAQueryFieldInfo("double", bidrem, bidrem.ToString("000000000000."), "매수잔량", (decimal)12.0);
			dict["offerrem"] = new XAQueryFieldInfo("double", offerrem, offerrem.ToString("000000000000."), "매도잔량", (decimal)12.0);
			dict["kind"] = new XAQueryFieldInfo("char", kind, kind.ToString(), "종목종류", (decimal)1);
			dict["symbol"] = new XAQueryFieldInfo("char", symbol, symbol, "SYMBOL", (decimal)16);
			dict["exid"] = new XAQueryFieldInfo("char", exid, exid, "EXID", (decimal)4);
			dict["kodate"] = new XAQueryFieldInfo("char", kodate, kodate, "한국일자", (decimal)8);
			dict["kotime"] = new XAQueryFieldInfo("char", kotime, kotime, "한국시간", (decimal)8);

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
					this.open = fieldInfo.FieldValue.ParseDouble("open");
				break;

				case "high":
					this.high = fieldInfo.FieldValue.ParseDouble("high");
				break;

				case "low":
					this.low = fieldInfo.FieldValue.ParseDouble("low");
				break;

				case "price":
					this.price = fieldInfo.FieldValue.ParseDouble("price");
				break;

				case "sign":
					this.sign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "change":
					this.change = fieldInfo.FieldValue.ParseDouble("change");
				break;

				case "uprate":
					this.uprate = fieldInfo.FieldValue.ParseDouble("uprate");
				break;

				case "volume":
					this.volume = fieldInfo.FieldValue.ParseDouble("volume");
				break;

				case "bidho":
					this.bidho = fieldInfo.FieldValue.ParseDouble("bidho");
				break;

				case "offerho":
					this.offerho = fieldInfo.FieldValue.ParseDouble("offerho");
				break;

				case "bidrem":
					this.bidrem = fieldInfo.FieldValue.ParseDouble("bidrem");
				break;

				case "offerrem":
					this.offerrem = fieldInfo.FieldValue.ParseDouble("offerrem");
				break;

				case "kind":
					this.kind = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "symbol":
					this.symbol = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "exid":
					this.exid = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "kodate":
					this.kodate = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "kotime":
					this.kotime = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt3518OutBlock1[] ListFromQuery(XQt3518 query)
		{
			int count = query.GetBlockCount(XQt3518OutBlock1.BlockName);
			List<XQt3518OutBlock1> list = new List<XQt3518OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt3518OutBlock1 block = new XQt3518OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.date = query.GetFieldData(block.GetBlockName(), "date", i).TrimEnd('?'); // char 8
					block.time = query.GetFieldData(block.GetBlockName(), "time", i).TrimEnd('?'); // char 8
					block.open = query.GetFieldData(block.GetBlockName(), "open", i).ParseDouble("open"); // double 9.4
					block.high = query.GetFieldData(block.GetBlockName(), "high", i).ParseDouble("high"); // double 9.4
					block.low = query.GetFieldData(block.GetBlockName(), "low", i).ParseDouble("low"); // double 9.4
					block.price = query.GetFieldData(block.GetBlockName(), "price", i).ParseDouble("price"); // double 9.4
					block.sign = query.GetFieldData(block.GetBlockName(), "sign", i).FirstOrDefault(); // char 1
					block.change = query.GetFieldData(block.GetBlockName(), "change", i).ParseDouble("change"); // double 9.4
					block.uprate = query.GetFieldData(block.GetBlockName(), "uprate", i).ParseDouble("uprate"); // double 9.4
					block.volume = query.GetFieldData(block.GetBlockName(), "volume", i).ParseDouble("volume"); // double 12.0
					block.bidho = query.GetFieldData(block.GetBlockName(), "bidho", i).ParseDouble("bidho"); // double 9.4
					block.offerho = query.GetFieldData(block.GetBlockName(), "offerho", i).ParseDouble("offerho"); // double 9.4
					block.bidrem = query.GetFieldData(block.GetBlockName(), "bidrem", i).ParseDouble("bidrem"); // double 12.0
					block.offerrem = query.GetFieldData(block.GetBlockName(), "offerrem", i).ParseDouble("offerrem"); // double 12.0
					block.kind = query.GetFieldData(block.GetBlockName(), "kind", i).FirstOrDefault(); // char 1
					block.symbol = query.GetFieldData(block.GetBlockName(), "symbol", i).TrimEnd('?'); // char 16
					block.exid = query.GetFieldData(block.GetBlockName(), "exid", i).TrimEnd('?'); // char 4
					block.kodate = query.GetFieldData(block.GetBlockName(), "kodate", i).TrimEnd('?'); // char 8
					block.kotime = query.GetFieldData(block.GetBlockName(), "kotime", i).TrimEnd('?'); // char 8

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
			if (time?.Length > 8) return false; // char 8
			// open double 9.4
			// high double 9.4
			// low double 9.4
			// price double 9.4
			// sign char 1
			// change double 9.4
			// uprate double 9.4
			// volume double 12.0
			// bidho double 9.4
			// offerho double 9.4
			// bidrem double 12.0
			// offerrem double 12.0
			// kind char 1
			if (symbol?.Length > 16) return false; // char 16
			if (exid?.Length > 4) return false; // char 4
			if (kodate?.Length > 8) return false; // char 8
			if (kotime?.Length > 8) return false; // char 8

			return true;
		}
	}

	/// <summary>
	/// 해외실시간지수(t3518)
	/// </summary>
	public partial class XQt3518 : XingQuery
	{
		/// <summary>
		/// t3518
		/// </summary>
		public const string _typeName = "t3518";
		/// <summary>
		/// 해외실시간지수(t3518)
		/// </summary>
		public const string _typeDesc = "해외실시간지수(t3518)";
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
		/// t3518
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 해외실시간지수(t3518)
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
		/// 해외실시간지수(t3518)
		/// </summary>
		public XQt3518() : base("t3518") { }


		public static XQt3518OutBlock1[] Get(char kind = default,string symbol = default,long cnt = default,char jgbn = default,long nmin = default,string cts_date = default,string cts_time = default)
		{
			using (XQt3518 instance = new XQt3518())
			{
				instance.SetFieldData(XQt3518InBlock.BlockName, XQt3518InBlock.F.kind, 0, kind.ToString()); // char 1
				instance.SetFieldData(XQt3518InBlock.BlockName, XQt3518InBlock.F.symbol, 0, symbol); // char 16
				instance.SetFieldData(XQt3518InBlock.BlockName, XQt3518InBlock.F.cnt, 0, cnt.ToString("d4")); // long 4
				instance.SetFieldData(XQt3518InBlock.BlockName, XQt3518InBlock.F.jgbn, 0, jgbn.ToString()); // char 1
				instance.SetFieldData(XQt3518InBlock.BlockName, XQt3518InBlock.F.nmin, 0, nmin.ToString("d3")); // long 3
				instance.SetFieldData(XQt3518InBlock.BlockName, XQt3518InBlock.F.cts_date, 0, cts_date); // char 8
				instance.SetFieldData(XQt3518InBlock.BlockName, XQt3518InBlock.F.cts_time, 0, cts_time); // char 6

				if (instance.Request() < 0)
				{
					return null;
				}

				var outBlock = instance.GetBlock1s();
				return outBlock;
			}
		}

		public bool SetBlock(XQt3518InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "kind", 0, block.kind.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "symbol", 0, block.symbol); // char 16
			_xaQuery.SetFieldData(block.GetBlockName(), "cnt", 0, block.cnt.ToString("d4")); // long 4
			_xaQuery.SetFieldData(block.GetBlockName(), "jgbn", 0, block.jgbn.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "nmin", 0, block.nmin.ToString("d3")); // long 3
			_xaQuery.SetFieldData(block.GetBlockName(), "cts_date", 0, block.cts_date); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "cts_time", 0, block.cts_time); // char 6

			return true;
		}

		public XQt3518OutBlock GetBlock()
		{
			XQt3518OutBlock instance = XQt3518OutBlock.FromQuery(this);
			return instance;

		}

		public XQt3518OutBlock1[] GetBlock1s()
		{
			XQt3518OutBlock1[] instance = XQt3518OutBlock1.ListFromQuery(this);
			return instance;

		}


	}

}
