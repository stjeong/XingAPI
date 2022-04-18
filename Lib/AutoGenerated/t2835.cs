using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt2835InBlock : XingBlock
	{
		/// <summary>
		/// t2835InBlock
		/// </summary>
		public const string _blockName = "t2835InBlock";
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
		/// t2835InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t2835InBlock
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
		/// 월물(혹은주물WN)
		/// </summary>
		[XAQueryFieldAttribute("yyyymm", "월물(혹은주물WN)", "char", "6")]
		public string yyyymm;
		/// <summary>
		/// 구분(G:원지수W:위클리)
		/// </summary>
		[XAQueryFieldAttribute("gubun", "구분(G:원지수W:위클리)", "char", "1")]
		public char gubun;

		public static class F
		{
			/// <summary>
			/// 월물(혹은주물WN)
			/// </summary>
			public const string yyyymm = "yyyymm";
			/// <summary>
			/// 구분(G:원지수W:위클리)
			/// </summary>
			public const string gubun = "gubun";
		}

		public static string[] AllFields = new string[]
		{
			F.yyyymm,
			F.gubun,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["yyyymm"] = new XAQueryFieldInfo("char", yyyymm, yyyymm, "월물(혹은주물WN)", (decimal)6);
			dict["gubun"] = new XAQueryFieldInfo("char", gubun, gubun.ToString(), "구분(G:원지수W:위클리)", (decimal)1);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "yyyymm":
					this.yyyymm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "gubun":
					this.gubun = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public bool VerifyData()
		{
			if (yyyymm?.Length > 6) return false; // char 6
			// gubun char 1

			return true;
		}
	}

	public partial class XQt2835OutBlock : XingBlock
	{
		/// <summary>
		/// t2835OutBlock
		/// </summary>
		public const string _blockName = "t2835OutBlock";
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
		/// t2835OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t2835OutBlock
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
		/// 근월물현재가
		/// </summary>
		[XAQueryFieldAttribute("gmprice", "근월물현재가", "float", "6.2")]
		public float gmprice;
		/// <summary>
		/// 근월물전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("gmsign", "근월물전일대비구분", "char", "1")]
		public char gmsign;
		/// <summary>
		/// 근월물전일대비
		/// </summary>
		[XAQueryFieldAttribute("gmchange", "근월물전일대비", "float", "6.2")]
		public float gmchange;
		/// <summary>
		/// 근월물등락율
		/// </summary>
		[XAQueryFieldAttribute("gmdiff", "근월물등락율", "float", "6.2")]
		public float gmdiff;
		/// <summary>
		/// 근월물거래량
		/// </summary>
		[XAQueryFieldAttribute("gmvolume", "근월물거래량", "long", "12")]
		public long gmvolume;
		/// <summary>
		/// 근월물선물코드
		/// </summary>
		[XAQueryFieldAttribute("gmshcode", "근월물선물코드", "char", "8")]
		public string gmshcode;

		public static class F
		{
			/// <summary>
			/// 근월물현재가
			/// </summary>
			public const string gmprice = "gmprice";
			/// <summary>
			/// 근월물전일대비구분
			/// </summary>
			public const string gmsign = "gmsign";
			/// <summary>
			/// 근월물전일대비
			/// </summary>
			public const string gmchange = "gmchange";
			/// <summary>
			/// 근월물등락율
			/// </summary>
			public const string gmdiff = "gmdiff";
			/// <summary>
			/// 근월물거래량
			/// </summary>
			public const string gmvolume = "gmvolume";
			/// <summary>
			/// 근월물선물코드
			/// </summary>
			public const string gmshcode = "gmshcode";
		}

		public static string[] AllFields = new string[]
		{
			F.gmprice,
			F.gmsign,
			F.gmchange,
			F.gmdiff,
			F.gmvolume,
			F.gmshcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["gmprice"] = new XAQueryFieldInfo("float", gmprice, gmprice.ToString("000000.00"), "근월물현재가", (decimal)6.2);
			dict["gmsign"] = new XAQueryFieldInfo("char", gmsign, gmsign.ToString(), "근월물전일대비구분", (decimal)1);
			dict["gmchange"] = new XAQueryFieldInfo("float", gmchange, gmchange.ToString("000000.00"), "근월물전일대비", (decimal)6.2);
			dict["gmdiff"] = new XAQueryFieldInfo("float", gmdiff, gmdiff.ToString("000000.00"), "근월물등락율", (decimal)6.2);
			dict["gmvolume"] = new XAQueryFieldInfo("long", gmvolume, gmvolume.ToString("d12"), "근월물거래량", (decimal)12);
			dict["gmshcode"] = new XAQueryFieldInfo("char", gmshcode, gmshcode, "근월물선물코드", (decimal)8);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "gmprice":
					this.gmprice = fieldInfo.FieldValue.ParseFloat("gmprice");
				break;

				case "gmsign":
					this.gmsign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "gmchange":
					this.gmchange = fieldInfo.FieldValue.ParseFloat("gmchange");
				break;

				case "gmdiff":
					this.gmdiff = fieldInfo.FieldValue.ParseFloat("gmdiff");
				break;

				case "gmvolume":
					this.gmvolume = fieldInfo.FieldValue.ParseLong("gmvolume");
				break;

				case "gmshcode":
					this.gmshcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt2835OutBlock FromQuery(XQt2835 query)
		{
			XQt2835OutBlock block = new XQt2835OutBlock();
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
				block.gmprice = query.GetFieldData(block.GetBlockName(), "gmprice", 0).ParseFloat("gmprice"); // float 6.2
				block.gmsign = query.GetFieldData(block.GetBlockName(), "gmsign", 0).FirstOrDefault(); // char 1
				block.gmchange = query.GetFieldData(block.GetBlockName(), "gmchange", 0).ParseFloat("gmchange"); // float 6.2
				block.gmdiff = query.GetFieldData(block.GetBlockName(), "gmdiff", 0).ParseFloat("gmdiff"); // float 6.2
				block.gmvolume = query.GetFieldData(block.GetBlockName(), "gmvolume", 0).ParseLong("gmvolume"); // long 12
				block.gmshcode = query.GetFieldData(block.GetBlockName(), "gmshcode", 0).TrimEnd('?'); // char 8

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			// gmprice float 6.2
			// gmsign char 1
			// gmchange float 6.2
			// gmdiff float 6.2
			if (gmvolume.ToString().Length > 12) return false; // long 12
			if (gmshcode?.Length > 8) return false; // char 8

			return true;
		}
	}

	public partial class XQt2835OutBlock1 : XingBlock
	{
		/// <summary>
		/// t2835OutBlock1
		/// </summary>
		public const string _blockName = "t2835OutBlock1";
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
		/// t2835OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t2835OutBlock1
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
		/// 행사가
		/// </summary>
		[XAQueryFieldAttribute("actprice", "행사가", "float", "6.2")]
		public float actprice;
		/// <summary>
		/// 콜옵션코드
		/// </summary>
		[XAQueryFieldAttribute("optcode", "콜옵션코드", "char", "8")]
		public string optcode;
		/// <summary>
		/// 현재가
		/// </summary>
		[XAQueryFieldAttribute("price", "현재가", "float", "6.2")]
		public float price;
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
		/// 매도호가
		/// </summary>
		[XAQueryFieldAttribute("offerho1", "매도호가", "float", "6.2")]
		public float offerho1;
		/// <summary>
		/// 매수호가
		/// </summary>
		[XAQueryFieldAttribute("bidho1", "매수호가", "float", "6.2")]
		public float bidho1;
		/// <summary>
		/// 체결량
		/// </summary>
		[XAQueryFieldAttribute("cvolume", "체결량", "long", "12")]
		public long cvolume;
		/// <summary>
		/// 내재가치
		/// </summary>
		[XAQueryFieldAttribute("impv", "내재가치", "float", "6.2")]
		public float impv;
		/// <summary>
		/// 시간가치
		/// </summary>
		[XAQueryFieldAttribute("timevl", "시간가치", "float", "6.2")]
		public float timevl;
		/// <summary>
		/// 매도잔량
		/// </summary>
		[XAQueryFieldAttribute("offerrem1", "매도잔량", "long", "12")]
		public long offerrem1;
		/// <summary>
		/// 매수잔량
		/// </summary>
		[XAQueryFieldAttribute("bidrem1", "매수잔량", "long", "12")]
		public long bidrem1;
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
		/// ATM구분
		/// </summary>
		[XAQueryFieldAttribute("atmgubun", "ATM구분", "char", "1")]
		public char atmgubun;
		/// <summary>
		/// 지수환산
		/// </summary>
		[XAQueryFieldAttribute("jisuconv", "지수환산", "float", "6.2")]
		public float jisuconv;

		public static class F
		{
			/// <summary>
			/// 행사가
			/// </summary>
			public const string actprice = "actprice";
			/// <summary>
			/// 콜옵션코드
			/// </summary>
			public const string optcode = "optcode";
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
			public const string diff = "diff";
			/// <summary>
			/// 거래량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// 매도호가
			/// </summary>
			public const string offerho1 = "offerho1";
			/// <summary>
			/// 매수호가
			/// </summary>
			public const string bidho1 = "bidho1";
			/// <summary>
			/// 체결량
			/// </summary>
			public const string cvolume = "cvolume";
			/// <summary>
			/// 내재가치
			/// </summary>
			public const string impv = "impv";
			/// <summary>
			/// 시간가치
			/// </summary>
			public const string timevl = "timevl";
			/// <summary>
			/// 매도잔량
			/// </summary>
			public const string offerrem1 = "offerrem1";
			/// <summary>
			/// 매수잔량
			/// </summary>
			public const string bidrem1 = "bidrem1";
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
			/// ATM구분
			/// </summary>
			public const string atmgubun = "atmgubun";
			/// <summary>
			/// 지수환산
			/// </summary>
			public const string jisuconv = "jisuconv";
		}

		public static string[] AllFields = new string[]
		{
			F.actprice,
			F.optcode,
			F.price,
			F.sign,
			F.change,
			F.diff,
			F.volume,
			F.offerho1,
			F.bidho1,
			F.cvolume,
			F.impv,
			F.timevl,
			F.offerrem1,
			F.bidrem1,
			F.open,
			F.high,
			F.low,
			F.atmgubun,
			F.jisuconv,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["actprice"] = new XAQueryFieldInfo("float", actprice, actprice.ToString("000000.00"), "행사가", (decimal)6.2);
			dict["optcode"] = new XAQueryFieldInfo("char", optcode, optcode, "콜옵션코드", (decimal)8);
			dict["price"] = new XAQueryFieldInfo("float", price, price.ToString("000000.00"), "현재가", (decimal)6.2);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("float", change, change.ToString("000000.00"), "전일대비", (decimal)6.2);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "거래량", (decimal)12);
			dict["offerho1"] = new XAQueryFieldInfo("float", offerho1, offerho1.ToString("000000.00"), "매도호가", (decimal)6.2);
			dict["bidho1"] = new XAQueryFieldInfo("float", bidho1, bidho1.ToString("000000.00"), "매수호가", (decimal)6.2);
			dict["cvolume"] = new XAQueryFieldInfo("long", cvolume, cvolume.ToString("d12"), "체결량", (decimal)12);
			dict["impv"] = new XAQueryFieldInfo("float", impv, impv.ToString("000000.00"), "내재가치", (decimal)6.2);
			dict["timevl"] = new XAQueryFieldInfo("float", timevl, timevl.ToString("000000.00"), "시간가치", (decimal)6.2);
			dict["offerrem1"] = new XAQueryFieldInfo("long", offerrem1, offerrem1.ToString("d12"), "매도잔량", (decimal)12);
			dict["bidrem1"] = new XAQueryFieldInfo("long", bidrem1, bidrem1.ToString("d12"), "매수잔량", (decimal)12);
			dict["open"] = new XAQueryFieldInfo("float", open, open.ToString("000000.00"), "시가", (decimal)6.2);
			dict["high"] = new XAQueryFieldInfo("float", high, high.ToString("000000.00"), "고가", (decimal)6.2);
			dict["low"] = new XAQueryFieldInfo("float", low, low.ToString("000000.00"), "저가", (decimal)6.2);
			dict["atmgubun"] = new XAQueryFieldInfo("char", atmgubun, atmgubun.ToString(), "ATM구분", (decimal)1);
			dict["jisuconv"] = new XAQueryFieldInfo("float", jisuconv, jisuconv.ToString("000000.00"), "지수환산", (decimal)6.2);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "actprice":
					this.actprice = fieldInfo.FieldValue.ParseFloat("actprice");
				break;

				case "optcode":
					this.optcode = fieldInfo.FieldValue.TrimEnd('?');
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

				case "diff":
					this.diff = fieldInfo.FieldValue.ParseFloat("diff");
				break;

				case "volume":
					this.volume = fieldInfo.FieldValue.ParseLong("volume");
				break;

				case "offerho1":
					this.offerho1 = fieldInfo.FieldValue.ParseFloat("offerho1");
				break;

				case "bidho1":
					this.bidho1 = fieldInfo.FieldValue.ParseFloat("bidho1");
				break;

				case "cvolume":
					this.cvolume = fieldInfo.FieldValue.ParseLong("cvolume");
				break;

				case "impv":
					this.impv = fieldInfo.FieldValue.ParseFloat("impv");
				break;

				case "timevl":
					this.timevl = fieldInfo.FieldValue.ParseFloat("timevl");
				break;

				case "offerrem1":
					this.offerrem1 = fieldInfo.FieldValue.ParseLong("offerrem1");
				break;

				case "bidrem1":
					this.bidrem1 = fieldInfo.FieldValue.ParseLong("bidrem1");
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

				case "atmgubun":
					this.atmgubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "jisuconv":
					this.jisuconv = fieldInfo.FieldValue.ParseFloat("jisuconv");
				break;


			}
		}

		public static XQt2835OutBlock1[] ListFromQuery(XQt2835 query)
		{
			int count = query.GetBlockCount(XQt2835OutBlock1.BlockName);
			List<XQt2835OutBlock1> list = new List<XQt2835OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt2835OutBlock1 block = new XQt2835OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.actprice = query.GetFieldData(block.GetBlockName(), "actprice", i).ParseFloat("actprice"); // float 6.2
					block.optcode = query.GetFieldData(block.GetBlockName(), "optcode", i).TrimEnd('?'); // char 8
					block.price = query.GetFieldData(block.GetBlockName(), "price", i).ParseFloat("price"); // float 6.2
					block.sign = query.GetFieldData(block.GetBlockName(), "sign", i).FirstOrDefault(); // char 1
					block.change = query.GetFieldData(block.GetBlockName(), "change", i).ParseFloat("change"); // float 6.2
					block.diff = query.GetFieldData(block.GetBlockName(), "diff", i).ParseFloat("diff"); // float 6.2
					block.volume = query.GetFieldData(block.GetBlockName(), "volume", i).ParseLong("volume"); // long 12
					block.offerho1 = query.GetFieldData(block.GetBlockName(), "offerho1", i).ParseFloat("offerho1"); // float 6.2
					block.bidho1 = query.GetFieldData(block.GetBlockName(), "bidho1", i).ParseFloat("bidho1"); // float 6.2
					block.cvolume = query.GetFieldData(block.GetBlockName(), "cvolume", i).ParseLong("cvolume"); // long 12
					block.impv = query.GetFieldData(block.GetBlockName(), "impv", i).ParseFloat("impv"); // float 6.2
					block.timevl = query.GetFieldData(block.GetBlockName(), "timevl", i).ParseFloat("timevl"); // float 6.2
					block.offerrem1 = query.GetFieldData(block.GetBlockName(), "offerrem1", i).ParseLong("offerrem1"); // long 12
					block.bidrem1 = query.GetFieldData(block.GetBlockName(), "bidrem1", i).ParseLong("bidrem1"); // long 12
					block.open = query.GetFieldData(block.GetBlockName(), "open", i).ParseFloat("open"); // float 6.2
					block.high = query.GetFieldData(block.GetBlockName(), "high", i).ParseFloat("high"); // float 6.2
					block.low = query.GetFieldData(block.GetBlockName(), "low", i).ParseFloat("low"); // float 6.2
					block.atmgubun = query.GetFieldData(block.GetBlockName(), "atmgubun", i).FirstOrDefault(); // char 1
					block.jisuconv = query.GetFieldData(block.GetBlockName(), "jisuconv", i).ParseFloat("jisuconv"); // float 6.2

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
			// actprice float 6.2
			if (optcode?.Length > 8) return false; // char 8
			// price float 6.2
			// sign char 1
			// change float 6.2
			// diff float 6.2
			if (volume.ToString().Length > 12) return false; // long 12
			// offerho1 float 6.2
			// bidho1 float 6.2
			if (cvolume.ToString().Length > 12) return false; // long 12
			// impv float 6.2
			// timevl float 6.2
			if (offerrem1.ToString().Length > 12) return false; // long 12
			if (bidrem1.ToString().Length > 12) return false; // long 12
			// open float 6.2
			// high float 6.2
			// low float 6.2
			// atmgubun char 1
			// jisuconv float 6.2

			return true;
		}
	}

	public partial class XQt2835OutBlock2 : XingBlock
	{
		/// <summary>
		/// t2835OutBlock2
		/// </summary>
		public const string _blockName = "t2835OutBlock2";
		/// <summary>
		/// 출력2
		/// </summary>
		public const string _blockDesc = "출력2";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// true
		/// </summary>
		public const bool _hasOccurs = true;
		/// <summary>
		/// t2835OutBlock2
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t2835OutBlock2
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// 출력2
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
		/// 행사가
		/// </summary>
		[XAQueryFieldAttribute("actprice", "행사가", "float", "6.2")]
		public float actprice;
		/// <summary>
		/// 풋옵션코드
		/// </summary>
		[XAQueryFieldAttribute("optcode", "풋옵션코드", "char", "8")]
		public string optcode;
		/// <summary>
		/// 현재가
		/// </summary>
		[XAQueryFieldAttribute("price", "현재가", "float", "6.2")]
		public float price;
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
		/// 매도호가
		/// </summary>
		[XAQueryFieldAttribute("offerho1", "매도호가", "float", "6.2")]
		public float offerho1;
		/// <summary>
		/// 매수호가
		/// </summary>
		[XAQueryFieldAttribute("bidho1", "매수호가", "float", "6.2")]
		public float bidho1;
		/// <summary>
		/// 체결량
		/// </summary>
		[XAQueryFieldAttribute("cvolume", "체결량", "long", "12")]
		public long cvolume;
		/// <summary>
		/// 내재가치
		/// </summary>
		[XAQueryFieldAttribute("impv", "내재가치", "float", "6.2")]
		public float impv;
		/// <summary>
		/// 시간가치
		/// </summary>
		[XAQueryFieldAttribute("timevl", "시간가치", "float", "6.2")]
		public float timevl;
		/// <summary>
		/// 매도잔량
		/// </summary>
		[XAQueryFieldAttribute("offerrem1", "매도잔량", "long", "12")]
		public long offerrem1;
		/// <summary>
		/// 매수잔량
		/// </summary>
		[XAQueryFieldAttribute("bidrem1", "매수잔량", "long", "12")]
		public long bidrem1;
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
		/// ATM구분
		/// </summary>
		[XAQueryFieldAttribute("atmgubun", "ATM구분", "char", "1")]
		public char atmgubun;
		/// <summary>
		/// 지수환산
		/// </summary>
		[XAQueryFieldAttribute("jisuconv", "지수환산", "float", "6.2")]
		public float jisuconv;

		public static class F
		{
			/// <summary>
			/// 행사가
			/// </summary>
			public const string actprice = "actprice";
			/// <summary>
			/// 풋옵션코드
			/// </summary>
			public const string optcode = "optcode";
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
			public const string diff = "diff";
			/// <summary>
			/// 거래량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// 매도호가
			/// </summary>
			public const string offerho1 = "offerho1";
			/// <summary>
			/// 매수호가
			/// </summary>
			public const string bidho1 = "bidho1";
			/// <summary>
			/// 체결량
			/// </summary>
			public const string cvolume = "cvolume";
			/// <summary>
			/// 내재가치
			/// </summary>
			public const string impv = "impv";
			/// <summary>
			/// 시간가치
			/// </summary>
			public const string timevl = "timevl";
			/// <summary>
			/// 매도잔량
			/// </summary>
			public const string offerrem1 = "offerrem1";
			/// <summary>
			/// 매수잔량
			/// </summary>
			public const string bidrem1 = "bidrem1";
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
			/// ATM구분
			/// </summary>
			public const string atmgubun = "atmgubun";
			/// <summary>
			/// 지수환산
			/// </summary>
			public const string jisuconv = "jisuconv";
		}

		public static string[] AllFields = new string[]
		{
			F.actprice,
			F.optcode,
			F.price,
			F.sign,
			F.change,
			F.diff,
			F.volume,
			F.offerho1,
			F.bidho1,
			F.cvolume,
			F.impv,
			F.timevl,
			F.offerrem1,
			F.bidrem1,
			F.open,
			F.high,
			F.low,
			F.atmgubun,
			F.jisuconv,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["actprice"] = new XAQueryFieldInfo("float", actprice, actprice.ToString("000000.00"), "행사가", (decimal)6.2);
			dict["optcode"] = new XAQueryFieldInfo("char", optcode, optcode, "풋옵션코드", (decimal)8);
			dict["price"] = new XAQueryFieldInfo("float", price, price.ToString("000000.00"), "현재가", (decimal)6.2);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("float", change, change.ToString("000000.00"), "전일대비", (decimal)6.2);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "거래량", (decimal)12);
			dict["offerho1"] = new XAQueryFieldInfo("float", offerho1, offerho1.ToString("000000.00"), "매도호가", (decimal)6.2);
			dict["bidho1"] = new XAQueryFieldInfo("float", bidho1, bidho1.ToString("000000.00"), "매수호가", (decimal)6.2);
			dict["cvolume"] = new XAQueryFieldInfo("long", cvolume, cvolume.ToString("d12"), "체결량", (decimal)12);
			dict["impv"] = new XAQueryFieldInfo("float", impv, impv.ToString("000000.00"), "내재가치", (decimal)6.2);
			dict["timevl"] = new XAQueryFieldInfo("float", timevl, timevl.ToString("000000.00"), "시간가치", (decimal)6.2);
			dict["offerrem1"] = new XAQueryFieldInfo("long", offerrem1, offerrem1.ToString("d12"), "매도잔량", (decimal)12);
			dict["bidrem1"] = new XAQueryFieldInfo("long", bidrem1, bidrem1.ToString("d12"), "매수잔량", (decimal)12);
			dict["open"] = new XAQueryFieldInfo("float", open, open.ToString("000000.00"), "시가", (decimal)6.2);
			dict["high"] = new XAQueryFieldInfo("float", high, high.ToString("000000.00"), "고가", (decimal)6.2);
			dict["low"] = new XAQueryFieldInfo("float", low, low.ToString("000000.00"), "저가", (decimal)6.2);
			dict["atmgubun"] = new XAQueryFieldInfo("char", atmgubun, atmgubun.ToString(), "ATM구분", (decimal)1);
			dict["jisuconv"] = new XAQueryFieldInfo("float", jisuconv, jisuconv.ToString("000000.00"), "지수환산", (decimal)6.2);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "actprice":
					this.actprice = fieldInfo.FieldValue.ParseFloat("actprice");
				break;

				case "optcode":
					this.optcode = fieldInfo.FieldValue.TrimEnd('?');
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

				case "diff":
					this.diff = fieldInfo.FieldValue.ParseFloat("diff");
				break;

				case "volume":
					this.volume = fieldInfo.FieldValue.ParseLong("volume");
				break;

				case "offerho1":
					this.offerho1 = fieldInfo.FieldValue.ParseFloat("offerho1");
				break;

				case "bidho1":
					this.bidho1 = fieldInfo.FieldValue.ParseFloat("bidho1");
				break;

				case "cvolume":
					this.cvolume = fieldInfo.FieldValue.ParseLong("cvolume");
				break;

				case "impv":
					this.impv = fieldInfo.FieldValue.ParseFloat("impv");
				break;

				case "timevl":
					this.timevl = fieldInfo.FieldValue.ParseFloat("timevl");
				break;

				case "offerrem1":
					this.offerrem1 = fieldInfo.FieldValue.ParseLong("offerrem1");
				break;

				case "bidrem1":
					this.bidrem1 = fieldInfo.FieldValue.ParseLong("bidrem1");
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

				case "atmgubun":
					this.atmgubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "jisuconv":
					this.jisuconv = fieldInfo.FieldValue.ParseFloat("jisuconv");
				break;


			}
		}

		public static XQt2835OutBlock2[] ListFromQuery(XQt2835 query)
		{
			int count = query.GetBlockCount(XQt2835OutBlock2.BlockName);
			List<XQt2835OutBlock2> list = new List<XQt2835OutBlock2>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt2835OutBlock2 block = new XQt2835OutBlock2();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.actprice = query.GetFieldData(block.GetBlockName(), "actprice", i).ParseFloat("actprice"); // float 6.2
					block.optcode = query.GetFieldData(block.GetBlockName(), "optcode", i).TrimEnd('?'); // char 8
					block.price = query.GetFieldData(block.GetBlockName(), "price", i).ParseFloat("price"); // float 6.2
					block.sign = query.GetFieldData(block.GetBlockName(), "sign", i).FirstOrDefault(); // char 1
					block.change = query.GetFieldData(block.GetBlockName(), "change", i).ParseFloat("change"); // float 6.2
					block.diff = query.GetFieldData(block.GetBlockName(), "diff", i).ParseFloat("diff"); // float 6.2
					block.volume = query.GetFieldData(block.GetBlockName(), "volume", i).ParseLong("volume"); // long 12
					block.offerho1 = query.GetFieldData(block.GetBlockName(), "offerho1", i).ParseFloat("offerho1"); // float 6.2
					block.bidho1 = query.GetFieldData(block.GetBlockName(), "bidho1", i).ParseFloat("bidho1"); // float 6.2
					block.cvolume = query.GetFieldData(block.GetBlockName(), "cvolume", i).ParseLong("cvolume"); // long 12
					block.impv = query.GetFieldData(block.GetBlockName(), "impv", i).ParseFloat("impv"); // float 6.2
					block.timevl = query.GetFieldData(block.GetBlockName(), "timevl", i).ParseFloat("timevl"); // float 6.2
					block.offerrem1 = query.GetFieldData(block.GetBlockName(), "offerrem1", i).ParseLong("offerrem1"); // long 12
					block.bidrem1 = query.GetFieldData(block.GetBlockName(), "bidrem1", i).ParseLong("bidrem1"); // long 12
					block.open = query.GetFieldData(block.GetBlockName(), "open", i).ParseFloat("open"); // float 6.2
					block.high = query.GetFieldData(block.GetBlockName(), "high", i).ParseFloat("high"); // float 6.2
					block.low = query.GetFieldData(block.GetBlockName(), "low", i).ParseFloat("low"); // float 6.2
					block.atmgubun = query.GetFieldData(block.GetBlockName(), "atmgubun", i).FirstOrDefault(); // char 1
					block.jisuconv = query.GetFieldData(block.GetBlockName(), "jisuconv", i).ParseFloat("jisuconv"); // float 6.2

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
			// actprice float 6.2
			if (optcode?.Length > 8) return false; // char 8
			// price float 6.2
			// sign char 1
			// change float 6.2
			// diff float 6.2
			if (volume.ToString().Length > 12) return false; // long 12
			// offerho1 float 6.2
			// bidho1 float 6.2
			if (cvolume.ToString().Length > 12) return false; // long 12
			// impv float 6.2
			// timevl float 6.2
			if (offerrem1.ToString().Length > 12) return false; // long 12
			if (bidrem1.ToString().Length > 12) return false; // long 12
			// open float 6.2
			// high float 6.2
			// low float 6.2
			// atmgubun char 1
			// jisuconv float 6.2

			return true;
		}
	}

	/// <summary>
	/// EUREX옵션선물시세전광판(t2835)
	/// </summary>
	public partial class XQt2835 : XingQuery
	{
		/// <summary>
		/// t2835
		/// </summary>
		public const string _typeName = "t2835";
		/// <summary>
		/// EUREX옵션선물시세전광판(t2835)
		/// </summary>
		public const string _typeDesc = "EUREX옵션선물시세전광판(t2835)";
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
		/// t2835
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// EUREX옵션선물시세전광판(t2835)
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
		/// EUREX옵션선물시세전광판(t2835)
		/// </summary>
		public XQt2835() : base("t2835") { }




		public bool SetBlock(XQt2835InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "yyyymm", 0, block.yyyymm); // char 6
			_xaQuery.SetFieldData(block.GetBlockName(), "gubun", 0, block.gubun.ToString()); // char 1

			return true;
		}

		public XQt2835OutBlock GetBlock()
		{
			XQt2835OutBlock instance = XQt2835OutBlock.FromQuery(this);
			return instance;

		}

		public XQt2835OutBlock1[] GetBlock1s()
		{
			XQt2835OutBlock1[] instance = XQt2835OutBlock1.ListFromQuery(this);
			return instance;

		}

		public XQt2835OutBlock2[] GetBlock2s()
		{
			XQt2835OutBlock2[] instance = XQt2835OutBlock2.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt2835OutBlock),
			typeof(XQt2835OutBlock1),
			typeof(XQt2835OutBlock2),

		};

	}

}
