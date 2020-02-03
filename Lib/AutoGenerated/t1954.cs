using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1954InBlock : XingBlock
	{
		/// <summary>
		/// t1954InBlock
		/// </summary>
		static readonly string _blockName = "t1954InBlock";
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
		/// t1954InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1954InBlock
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
		/// 날짜
		/// </summary>
		[XAQueryFieldAttribute("날짜")]
		public string date;
		/// <summary>
		/// 건수
		/// </summary>
		[XAQueryFieldAttribute("건수")]
		public long cnt;

		public static class F
		{
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 날짜
			/// </summary>
			public const string date = "date";
			/// <summary>
			/// 건수
			/// </summary>
			public const string cnt = "cnt";
		}

		public static string[] AllFields = new string[]
		{
			F.shcode,
			F.date,
			F.cnt,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)6);
			dict["date"] = new XAQueryFieldInfo("char", date, date, "날짜", (decimal)8);
			dict["cnt"] = new XAQueryFieldInfo("long", cnt, cnt.ToString("d3"), "건수", (decimal)3);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "date":
					this.date = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cnt":
					this.cnt = fieldInfo.FieldValue.ParseLong("cnt");
				break;


			}
		}

		public bool VerifyData()
		{
			if (shcode.Length > 6) return false; // char 6
			if (date.Length > 8) return false; // char 8
			if (cnt.ToString().Length > 3) return false; // long 3

			return true;
		}
	}

	public partial class XQt1954OutBlock : XingBlock
	{
		/// <summary>
		/// t1954OutBlock
		/// </summary>
		static readonly string _blockName = "t1954OutBlock";
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
		/// t1954OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1954OutBlock
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
		/// 기초자산구분
		/// </summary>
		[XAQueryFieldAttribute("기초자산구분")]
		public char bsjgubun;
		/// <summary>
		/// 기초자산코드(현물)
		/// </summary>
		[XAQueryFieldAttribute("기초자산코드(현물)")]
		public string bscode;
		/// <summary>
		/// 기초자산코드(지수)
		/// </summary>
		[XAQueryFieldAttribute("기초자산코드(지수)")]
		public string bjcode;

		public static class F
		{
			/// <summary>
			/// 날짜
			/// </summary>
			public const string date = "date";
			/// <summary>
			/// 기초자산구분
			/// </summary>
			public const string bsjgubun = "bsjgubun";
			/// <summary>
			/// 기초자산코드(현물)
			/// </summary>
			public const string bscode = "bscode";
			/// <summary>
			/// 기초자산코드(지수)
			/// </summary>
			public const string bjcode = "bjcode";
		}

		public static string[] AllFields = new string[]
		{
			F.date,
			F.bsjgubun,
			F.bscode,
			F.bjcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["date"] = new XAQueryFieldInfo("char", date, date, "날짜", (decimal)8);
			dict["bsjgubun"] = new XAQueryFieldInfo("char", bsjgubun, bsjgubun.ToString(), "기초자산구분", (decimal)1);
			dict["bscode"] = new XAQueryFieldInfo("char", bscode, bscode, "기초자산코드(현물)", (decimal)6);
			dict["bjcode"] = new XAQueryFieldInfo("char", bjcode, bjcode, "기초자산코드(지수)", (decimal)3);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "date":
					this.date = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "bsjgubun":
					this.bsjgubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "bscode":
					this.bscode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "bjcode":
					this.bjcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt1954OutBlock FromQuery(XQt1954 query)
		{
			XQt1954OutBlock block = new XQt1954OutBlock();
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
				block.bsjgubun = query.GetFieldData(block.GetBlockName(), "bsjgubun", 0).FirstOrDefault(); // char 1
				block.bscode = query.GetFieldData(block.GetBlockName(), "bscode", 0).TrimEnd('?'); // char 6
				block.bjcode = query.GetFieldData(block.GetBlockName(), "bjcode", 0).TrimEnd('?'); // char 3

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (date.Length > 8) return false; // char 8
			// bsjgubun char 1
			if (bscode.Length > 6) return false; // char 6
			if (bjcode.Length > 3) return false; // char 3

			return true;
		}
	}

	public partial class XQt1954OutBlock1 : XingBlock
	{
		/// <summary>
		/// t1954OutBlock1
		/// </summary>
		static readonly string _blockName = "t1954OutBlock1";
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
		/// t1954OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1954OutBlock1
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
		/// 거래량
		/// </summary>
		[XAQueryFieldAttribute("거래량")]
		public float volume;
		/// <summary>
		/// 기초자산(현물)
		/// </summary>
		[XAQueryFieldAttribute("기초자산(현물)")]
		public long bsprice;
		/// <summary>
		/// 기초자산(지수)
		/// </summary>
		[XAQueryFieldAttribute("기초자산(지수)")]
		public float bjprice;
		/// <summary>
		/// 전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("전일대비구분")]
		public char bsign;
		/// <summary>
		/// 전일대비(현물)
		/// </summary>
		[XAQueryFieldAttribute("전일대비(현물)")]
		public long bschange;
		/// <summary>
		/// 전일대비(지수)
		/// </summary>
		[XAQueryFieldAttribute("전일대비(지수)")]
		public float bjchange;
		/// <summary>
		/// 등락율
		/// </summary>
		[XAQueryFieldAttribute("등락율")]
		public float bdiff;
		/// <summary>
		/// 기초자산거래량
		/// </summary>
		[XAQueryFieldAttribute("기초자산거래량")]
		public float bvolume;
		/// <summary>
		/// 패리티
		/// </summary>
		[XAQueryFieldAttribute("패리티")]
		public float parity;
		/// <summary>
		/// e.기어링
		/// </summary>
		[XAQueryFieldAttribute("e.기어링")]
		public float egearing;
		/// <summary>
		/// 프리미엄
		/// </summary>
		[XAQueryFieldAttribute("프리미엄")]
		public float premium;
		/// <summary>
		/// 손익분기
		/// </summary>
		[XAQueryFieldAttribute("손익분기")]
		public float berate;
		/// <summary>
		/// 자본지지
		/// </summary>
		[XAQueryFieldAttribute("자본지지")]
		public float capt;
		/// <summary>
		/// 기어링
		/// </summary>
		[XAQueryFieldAttribute("기어링")]
		public float gearing;
		/// <summary>
		/// Moneyness
		/// </summary>
		[XAQueryFieldAttribute("Moneyness")]
		public char mness;

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
			/// 기초자산(현물)
			/// </summary>
			public const string bsprice = "bsprice";
			/// <summary>
			/// 기초자산(지수)
			/// </summary>
			public const string bjprice = "bjprice";
			/// <summary>
			/// 전일대비구분
			/// </summary>
			public const string bsign = "bsign";
			/// <summary>
			/// 전일대비(현물)
			/// </summary>
			public const string bschange = "bschange";
			/// <summary>
			/// 전일대비(지수)
			/// </summary>
			public const string bjchange = "bjchange";
			/// <summary>
			/// 등락율
			/// </summary>
			public const string bdiff = "bdiff";
			/// <summary>
			/// 기초자산거래량
			/// </summary>
			public const string bvolume = "bvolume";
			/// <summary>
			/// 패리티
			/// </summary>
			public const string parity = "parity";
			/// <summary>
			/// e.기어링
			/// </summary>
			public const string egearing = "egearing";
			/// <summary>
			/// 프리미엄
			/// </summary>
			public const string premium = "premium";
			/// <summary>
			/// 손익분기
			/// </summary>
			public const string berate = "berate";
			/// <summary>
			/// 자본지지
			/// </summary>
			public const string capt = "capt";
			/// <summary>
			/// 기어링
			/// </summary>
			public const string gearing = "gearing";
			/// <summary>
			/// Moneyness
			/// </summary>
			public const string mness = "mness";
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
			F.bsprice,
			F.bjprice,
			F.bsign,
			F.bschange,
			F.bjchange,
			F.bdiff,
			F.bvolume,
			F.parity,
			F.egearing,
			F.premium,
			F.berate,
			F.capt,
			F.gearing,
			F.mness,
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
			dict["volume"] = new XAQueryFieldInfo("float", volume, volume.ToString("000000000000"), "거래량", (decimal)12);
			dict["bsprice"] = new XAQueryFieldInfo("long", bsprice, bsprice.ToString("d8"), "기초자산(현물)", (decimal)8);
			dict["bjprice"] = new XAQueryFieldInfo("float", bjprice, bjprice.ToString("00000000.00"), "기초자산(지수)", (decimal)8.2);
			dict["bsign"] = new XAQueryFieldInfo("char", bsign, bsign.ToString(), "전일대비구분", (decimal)1);
			dict["bschange"] = new XAQueryFieldInfo("long", bschange, bschange.ToString("d8"), "전일대비(현물)", (decimal)8);
			dict["bjchange"] = new XAQueryFieldInfo("float", bjchange, bjchange.ToString("00000000.00"), "전일대비(지수)", (decimal)8.2);
			dict["bdiff"] = new XAQueryFieldInfo("float", bdiff, bdiff.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["bvolume"] = new XAQueryFieldInfo("float", bvolume, bvolume.ToString("000000000000"), "기초자산거래량", (decimal)12);
			dict["parity"] = new XAQueryFieldInfo("float", parity, parity.ToString("000000.00"), "패리티", (decimal)6.2);
			dict["egearing"] = new XAQueryFieldInfo("float", egearing, egearing.ToString("000000.00"), "e.기어링", (decimal)6.2);
			dict["premium"] = new XAQueryFieldInfo("float", premium, premium.ToString("000000.00"), "프리미엄", (decimal)6.2);
			dict["berate"] = new XAQueryFieldInfo("float", berate, berate.ToString("000000.00"), "손익분기", (decimal)6.2);
			dict["capt"] = new XAQueryFieldInfo("float", capt, capt.ToString("000000.00"), "자본지지", (decimal)6.2);
			dict["gearing"] = new XAQueryFieldInfo("float", gearing, gearing.ToString("000000.00"), "기어링", (decimal)6.2);
			dict["mness"] = new XAQueryFieldInfo("char", mness, mness.ToString(), "Moneyness", (decimal)1);

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
					this.volume = fieldInfo.FieldValue.ParseFloat("volume");
				break;

				case "bsprice":
					this.bsprice = fieldInfo.FieldValue.ParseLong("bsprice");
				break;

				case "bjprice":
					this.bjprice = fieldInfo.FieldValue.ParseFloat("bjprice");
				break;

				case "bsign":
					this.bsign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "bschange":
					this.bschange = fieldInfo.FieldValue.ParseLong("bschange");
				break;

				case "bjchange":
					this.bjchange = fieldInfo.FieldValue.ParseFloat("bjchange");
				break;

				case "bdiff":
					this.bdiff = fieldInfo.FieldValue.ParseFloat("bdiff");
				break;

				case "bvolume":
					this.bvolume = fieldInfo.FieldValue.ParseFloat("bvolume");
				break;

				case "parity":
					this.parity = fieldInfo.FieldValue.ParseFloat("parity");
				break;

				case "egearing":
					this.egearing = fieldInfo.FieldValue.ParseFloat("egearing");
				break;

				case "premium":
					this.premium = fieldInfo.FieldValue.ParseFloat("premium");
				break;

				case "berate":
					this.berate = fieldInfo.FieldValue.ParseFloat("berate");
				break;

				case "capt":
					this.capt = fieldInfo.FieldValue.ParseFloat("capt");
				break;

				case "gearing":
					this.gearing = fieldInfo.FieldValue.ParseFloat("gearing");
				break;

				case "mness":
					this.mness = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public static XQt1954OutBlock1[] ListFromQuery(XQt1954 query)
		{
			int count = query.GetBlockCount(XQt1954OutBlock1.BlockName);
			List<XQt1954OutBlock1> list = new List<XQt1954OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1954OutBlock1 block = new XQt1954OutBlock1();
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
					block.volume = query.GetFieldData(block.GetBlockName(), "volume", i).ParseFloat("volume"); // float 12
					block.bsprice = query.GetFieldData(block.GetBlockName(), "bsprice", i).ParseLong("bsprice"); // long 8
					block.bjprice = query.GetFieldData(block.GetBlockName(), "bjprice", i).ParseFloat("bjprice"); // float 8.2
					block.bsign = query.GetFieldData(block.GetBlockName(), "bsign", i).FirstOrDefault(); // char 1
					block.bschange = query.GetFieldData(block.GetBlockName(), "bschange", i).ParseLong("bschange"); // long 8
					block.bjchange = query.GetFieldData(block.GetBlockName(), "bjchange", i).ParseFloat("bjchange"); // float 8.2
					block.bdiff = query.GetFieldData(block.GetBlockName(), "bdiff", i).ParseFloat("bdiff"); // float 6.2
					block.bvolume = query.GetFieldData(block.GetBlockName(), "bvolume", i).ParseFloat("bvolume"); // float 12
					block.parity = query.GetFieldData(block.GetBlockName(), "parity", i).ParseFloat("parity"); // float 6.2
					block.egearing = query.GetFieldData(block.GetBlockName(), "egearing", i).ParseFloat("egearing"); // float 6.2
					block.premium = query.GetFieldData(block.GetBlockName(), "premium", i).ParseFloat("premium"); // float 6.2
					block.berate = query.GetFieldData(block.GetBlockName(), "berate", i).ParseFloat("berate"); // float 6.2
					block.capt = query.GetFieldData(block.GetBlockName(), "capt", i).ParseFloat("capt"); // float 6.2
					block.gearing = query.GetFieldData(block.GetBlockName(), "gearing", i).ParseFloat("gearing"); // float 6.2
					block.mness = query.GetFieldData(block.GetBlockName(), "mness", i).FirstOrDefault(); // char 1

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
			if (open.ToString().Length > 8) return false; // long 8
			if (high.ToString().Length > 8) return false; // long 8
			if (low.ToString().Length > 8) return false; // long 8
			if (close.ToString().Length > 8) return false; // long 8
			// sign char 1
			if (change.ToString().Length > 8) return false; // long 8
			// diff float 6.2
			// volume float 12
			if (bsprice.ToString().Length > 8) return false; // long 8
			// bjprice float 8.2
			// bsign char 1
			if (bschange.ToString().Length > 8) return false; // long 8
			// bjchange float 8.2
			// bdiff float 6.2
			// bvolume float 12
			// parity float 6.2
			// egearing float 6.2
			// premium float 6.2
			// berate float 6.2
			// capt float 6.2
			// gearing float 6.2
			// mness char 1

			return true;
		}
	}

	public partial class XQt1954 : XingQuery
	{
		/// <summary>
		/// t1954
		/// </summary>
		static readonly string _typeName = "t1954";
		/// <summary>
		/// ELW일별주가(t1954)
		/// </summary>
		static readonly string _typeDesc = "ELW일별주가(t1954)";
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
		/// t1954
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// ELW일별주가(t1954)
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

		public XQt1954() : base("t1954") { }


		public bool SetFields(XQt1954InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "shcode", 0, block.shcode); // char 6
			_xaQuery.SetFieldData(block.GetBlockName(), "date", 0, block.date); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "cnt", 0, block.cnt.ToString("d3")); // long 3

			return true;
		}

		public XQt1954OutBlock GetBlock()
		{
			XQt1954OutBlock instance = XQt1954OutBlock.FromQuery(this);
			return instance;

		}

		public XQt1954OutBlock1[] GetBlock1s()
		{
			XQt1954OutBlock1[] instance = XQt1954OutBlock1.ListFromQuery(this);
			return instance;

		}


	}

}
