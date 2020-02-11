using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XRMK2InBlock : XingBlock
	{
		/// <summary>
		/// InBlock
		/// </summary>
		public const string _blockName = "InBlock";
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
		/// InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// InBlock
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
		/// 심볼코드
		/// </summary>
		[XAQueryFieldAttribute("symbol", "심볼코드", "char", "16")]
		public string symbol;

		public static class F
		{
			/// <summary>
			/// 심볼코드
			/// </summary>
			public const string symbol = "symbol";
		}

		public static string[] AllFields = new string[]
		{
			F.symbol,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["symbol"] = new XAQueryFieldInfo("char", symbol, symbol, "심볼코드", (decimal)16);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "symbol":
					this.symbol = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (symbol?.Length > 16) return false; // char 16

			return true;
		}
	}

	public partial class XRMK2OutBlock : XingBlock
	{
		/// <summary>
		/// OutBlock
		/// </summary>
		public const string _blockName = "OutBlock";
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
		/// OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// OutBlock
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
		/// 일자
		/// </summary>
		[XAQueryFieldAttribute("date", "일자", "char", "8")]
		public string date;
		/// <summary>
		/// 시간
		/// </summary>
		[XAQueryFieldAttribute("time", "시간", "char", "6")]
		public string time;
		/// <summary>
		/// 한국일자
		/// </summary>
		[XAQueryFieldAttribute("kodate", "한국일자", "char", "8")]
		public string kodate;
		/// <summary>
		/// 한국시간
		/// </summary>
		[XAQueryFieldAttribute("kotime", "한국시간", "char", "6")]
		public string kotime;
		/// <summary>
		/// 시가
		/// </summary>
		[XAQueryFieldAttribute("open", "시가", "float", "9.2")]
		public float open;
		/// <summary>
		/// 고가
		/// </summary>
		[XAQueryFieldAttribute("high", "고가", "float", "9.2")]
		public float high;
		/// <summary>
		/// 저가
		/// </summary>
		[XAQueryFieldAttribute("low", "저가", "float", "9.2")]
		public float low;
		/// <summary>
		/// 현재가
		/// </summary>
		[XAQueryFieldAttribute("price", "현재가", "float", "9.2")]
		public float price;
		/// <summary>
		/// 전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("sign", "전일대비구분", "char", "1")]
		public char sign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[XAQueryFieldAttribute("change", "전일대비", "float", "9.2")]
		public float change;
		/// <summary>
		/// 등락율
		/// </summary>
		[XAQueryFieldAttribute("uprate", "등락율", "float", "9.2")]
		public float uprate;
		/// <summary>
		/// 매수호가
		/// </summary>
		[XAQueryFieldAttribute("bidho", "매수호가", "float", "9.2")]
		public float bidho;
		/// <summary>
		/// 매수잔량
		/// </summary>
		[XAQueryFieldAttribute("bidrem", "매수잔량", "long", "9")]
		public long bidrem;
		/// <summary>
		/// 매도호가
		/// </summary>
		[XAQueryFieldAttribute("offerho", "매도호가", "float", "9.2")]
		public float offerho;
		/// <summary>
		/// 매도잔량
		/// </summary>
		[XAQueryFieldAttribute("offerrem", "매도잔량", "long", "9")]
		public long offerrem;
		/// <summary>
		/// 누적거래량
		/// </summary>
		[XAQueryFieldAttribute("volume", "누적거래량", "float", "12.0")]
		public float volume;
		/// <summary>
		/// 심벌
		/// </summary>
		[XAQueryFieldAttribute("xsymbol", "심벌", "char", "16")]
		public string xsymbol;
		/// <summary>
		/// 체결거래량
		/// </summary>
		[XAQueryFieldAttribute("cvolume", "체결거래량", "float", "8.0")]
		public float cvolume;

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
			/// 한국일자
			/// </summary>
			public const string kodate = "kodate";
			/// <summary>
			/// 한국시간
			/// </summary>
			public const string kotime = "kotime";
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
			/// 매수호가
			/// </summary>
			public const string bidho = "bidho";
			/// <summary>
			/// 매수잔량
			/// </summary>
			public const string bidrem = "bidrem";
			/// <summary>
			/// 매도호가
			/// </summary>
			public const string offerho = "offerho";
			/// <summary>
			/// 매도잔량
			/// </summary>
			public const string offerrem = "offerrem";
			/// <summary>
			/// 누적거래량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// 심벌
			/// </summary>
			public const string xsymbol = "xsymbol";
			/// <summary>
			/// 체결거래량
			/// </summary>
			public const string cvolume = "cvolume";
		}

		public static string[] AllFields = new string[]
		{
			F.date,
			F.time,
			F.kodate,
			F.kotime,
			F.open,
			F.high,
			F.low,
			F.price,
			F.sign,
			F.change,
			F.uprate,
			F.bidho,
			F.bidrem,
			F.offerho,
			F.offerrem,
			F.volume,
			F.xsymbol,
			F.cvolume,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["date"] = new XAQueryFieldInfo("char", date, date, "일자", (decimal)8);
			dict["time"] = new XAQueryFieldInfo("char", time, time, "시간", (decimal)6);
			dict["kodate"] = new XAQueryFieldInfo("char", kodate, kodate, "한국일자", (decimal)8);
			dict["kotime"] = new XAQueryFieldInfo("char", kotime, kotime, "한국시간", (decimal)6);
			dict["open"] = new XAQueryFieldInfo("float", open, open.ToString("000000000.00"), "시가", (decimal)9.2);
			dict["high"] = new XAQueryFieldInfo("float", high, high.ToString("000000000.00"), "고가", (decimal)9.2);
			dict["low"] = new XAQueryFieldInfo("float", low, low.ToString("000000000.00"), "저가", (decimal)9.2);
			dict["price"] = new XAQueryFieldInfo("float", price, price.ToString("000000000.00"), "현재가", (decimal)9.2);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("float", change, change.ToString("000000000.00"), "전일대비", (decimal)9.2);
			dict["uprate"] = new XAQueryFieldInfo("float", uprate, uprate.ToString("000000000.00"), "등락율", (decimal)9.2);
			dict["bidho"] = new XAQueryFieldInfo("float", bidho, bidho.ToString("000000000.00"), "매수호가", (decimal)9.2);
			dict["bidrem"] = new XAQueryFieldInfo("long", bidrem, bidrem.ToString("d9"), "매수잔량", (decimal)9);
			dict["offerho"] = new XAQueryFieldInfo("float", offerho, offerho.ToString("000000000.00"), "매도호가", (decimal)9.2);
			dict["offerrem"] = new XAQueryFieldInfo("long", offerrem, offerrem.ToString("d9"), "매도잔량", (decimal)9);
			dict["volume"] = new XAQueryFieldInfo("float", volume, volume.ToString("000000000000."), "누적거래량", (decimal)12.0);
			dict["xsymbol"] = new XAQueryFieldInfo("char", xsymbol, xsymbol, "심벌", (decimal)16);
			dict["cvolume"] = new XAQueryFieldInfo("float", cvolume, cvolume.ToString("00000000."), "체결거래량", (decimal)8.0);

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

				case "kodate":
					this.kodate = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "kotime":
					this.kotime = fieldInfo.FieldValue.TrimEnd('?');
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

				case "price":
					this.price = fieldInfo.FieldValue.ParseFloat("price");
				break;

				case "sign":
					this.sign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "change":
					this.change = fieldInfo.FieldValue.ParseFloat("change");
				break;

				case "uprate":
					this.uprate = fieldInfo.FieldValue.ParseFloat("uprate");
				break;

				case "bidho":
					this.bidho = fieldInfo.FieldValue.ParseFloat("bidho");
				break;

				case "bidrem":
					this.bidrem = fieldInfo.FieldValue.ParseLong("bidrem");
				break;

				case "offerho":
					this.offerho = fieldInfo.FieldValue.ParseFloat("offerho");
				break;

				case "offerrem":
					this.offerrem = fieldInfo.FieldValue.ParseLong("offerrem");
				break;

				case "volume":
					this.volume = fieldInfo.FieldValue.ParseFloat("volume");
				break;

				case "xsymbol":
					this.xsymbol = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cvolume":
					this.cvolume = fieldInfo.FieldValue.ParseFloat("cvolume");
				break;


			}
		}

		public static XRMK2OutBlock FromQuery(XRMK2 query)
		{
			XRMK2OutBlock block = new XRMK2OutBlock();
			block.IsValidData = true;
			block.InvalidReason = "";
			try
			{
				block.date = query.GetFieldData(block.GetBlockName(), "date").TrimEnd('?'); // char 8
				block.time = query.GetFieldData(block.GetBlockName(), "time").TrimEnd('?'); // char 6
				block.kodate = query.GetFieldData(block.GetBlockName(), "kodate").TrimEnd('?'); // char 8
				block.kotime = query.GetFieldData(block.GetBlockName(), "kotime").TrimEnd('?'); // char 6
				block.open = query.GetFieldData(block.GetBlockName(), "open").ParseFloat("open"); // float 9.2
				block.high = query.GetFieldData(block.GetBlockName(), "high").ParseFloat("high"); // float 9.2
				block.low = query.GetFieldData(block.GetBlockName(), "low").ParseFloat("low"); // float 9.2
				block.price = query.GetFieldData(block.GetBlockName(), "price").ParseFloat("price"); // float 9.2
				block.sign = query.GetFieldData(block.GetBlockName(), "sign").FirstOrDefault(); // char 1
				block.change = query.GetFieldData(block.GetBlockName(), "change").ParseFloat("change"); // float 9.2
				block.uprate = query.GetFieldData(block.GetBlockName(), "uprate").ParseFloat("uprate"); // float 9.2
				block.bidho = query.GetFieldData(block.GetBlockName(), "bidho").ParseFloat("bidho"); // float 9.2
				block.bidrem = query.GetFieldData(block.GetBlockName(), "bidrem").ParseLong("bidrem"); // long 9
				block.offerho = query.GetFieldData(block.GetBlockName(), "offerho").ParseFloat("offerho"); // float 9.2
				block.offerrem = query.GetFieldData(block.GetBlockName(), "offerrem").ParseLong("offerrem"); // long 9
				block.volume = query.GetFieldData(block.GetBlockName(), "volume").ParseFloat("volume"); // float 12.0
				block.xsymbol = query.GetFieldData(block.GetBlockName(), "xsymbol").TrimEnd('?'); // char 16
				block.cvolume = query.GetFieldData(block.GetBlockName(), "cvolume").ParseFloat("cvolume"); // float 8.0

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (date?.Length > 8) return false; // char 8
			if (time?.Length > 6) return false; // char 6
			if (kodate?.Length > 8) return false; // char 8
			if (kotime?.Length > 6) return false; // char 6
			// open float 9.2
			// high float 9.2
			// low float 9.2
			// price float 9.2
			// sign char 1
			// change float 9.2
			// uprate float 9.2
			// bidho float 9.2
			if (bidrem.ToString().Length > 9) return false; // long 9
			// offerho float 9.2
			if (offerrem.ToString().Length > 9) return false; // long 9
			// volume float 12.0
			if (xsymbol?.Length > 16) return false; // char 16
			// cvolume float 8.0

			return true;
		}
	}

	/// <summary>
	/// US지수(MK2)
	/// </summary>
	public partial class XRMK2 : XingReal
	{
		/// <summary>
		/// MK2
		/// </summary>
		public const string _typeName = "MK2";
		/// <summary>
		/// US지수(MK2)
		/// </summary>
		public const string _typeDesc = "US지수(MK2)";
		/// <summary>
		/// false
		/// </summary>
		public const bool _attr = false;
		/// <summary>
		/// 0
		/// </summary>
		public const int _key = 0;
		/// <summary>
		/// 0
		/// </summary>
		public const int _group = 0;

		/// <summary>
		/// MK2
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// US지수(MK2)
		/// </summary>
		public string TypeDesc => _typeDesc;
		/// <summary>
		/// false
		/// </summary>
		public bool Attr => _attr;
		/// <summary>
		/// 0
		/// </summary>
		public int Key => _key;
		/// <summary>
		/// 0
		/// </summary>
		public int Group => _group;

		/// <summary>
		/// US지수(MK2)
		/// </summary>
		public XRMK2() : base("MK2") { }


		public bool SetBlock(XRMK2InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaReal.SetFieldData(block.GetBlockName(), "symbol", block.symbol); // char 16

			return true;
		}

		public XRMK2OutBlock GetBlock()
		{
			XRMK2OutBlock instance = XRMK2OutBlock.FromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XRMK2OutBlock),

		};

	}

}
