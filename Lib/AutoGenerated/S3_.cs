using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XRS3_InBlock : XingBlock
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
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("shcode", "단축코드", "char", "6")]
		public string shcode;

		public static class F
		{
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string shcode = "shcode";
		}

		public static string[] AllFields = new string[]
		{
			F.shcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)6);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (shcode?.Length > 6) return false; // char 6

			return true;
		}
	}

	public partial class XRS3_OutBlock : XingBlock
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
		/// 체결시간
		/// </summary>
		[XAQueryFieldAttribute("chetime", "체결시간", "char", "6")]
		public string chetime;
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
		[XAQueryFieldAttribute("drate", "등락율", "float", "6.2")]
		public float drate;
		/// <summary>
		/// 현재가
		/// </summary>
		[XAQueryFieldAttribute("price", "현재가", "long", "8")]
		public long price;
		/// <summary>
		/// 시가시간
		/// </summary>
		[XAQueryFieldAttribute("opentime", "시가시간", "char", "6")]
		public string opentime;
		/// <summary>
		/// 시가
		/// </summary>
		[XAQueryFieldAttribute("open", "시가", "long", "8")]
		public long open;
		/// <summary>
		/// 고가시간
		/// </summary>
		[XAQueryFieldAttribute("hightime", "고가시간", "char", "6")]
		public string hightime;
		/// <summary>
		/// 고가
		/// </summary>
		[XAQueryFieldAttribute("high", "고가", "long", "8")]
		public long high;
		/// <summary>
		/// 저가시간
		/// </summary>
		[XAQueryFieldAttribute("lowtime", "저가시간", "char", "6")]
		public string lowtime;
		/// <summary>
		/// 저가
		/// </summary>
		[XAQueryFieldAttribute("low", "저가", "long", "8")]
		public long low;
		/// <summary>
		/// 체결구분
		/// </summary>
		[XAQueryFieldAttribute("cgubun", "체결구분", "char", "1")]
		public char cgubun;
		/// <summary>
		/// 체결량
		/// </summary>
		[XAQueryFieldAttribute("cvolume", "체결량", "long", "8")]
		public long cvolume;
		/// <summary>
		/// 누적거래량
		/// </summary>
		[XAQueryFieldAttribute("volume", "누적거래량", "long", "12")]
		public long volume;
		/// <summary>
		/// 누적거래대금
		/// </summary>
		[XAQueryFieldAttribute("value", "누적거래대금", "long", "12")]
		public long value;
		/// <summary>
		/// 매도누적체결량
		/// </summary>
		[XAQueryFieldAttribute("mdvolume", "매도누적체결량", "long", "12")]
		public long mdvolume;
		/// <summary>
		/// 매도누적체결건수
		/// </summary>
		[XAQueryFieldAttribute("mdchecnt", "매도누적체결건수", "long", "8")]
		public long mdchecnt;
		/// <summary>
		/// 매수누적체결량
		/// </summary>
		[XAQueryFieldAttribute("msvolume", "매수누적체결량", "long", "12")]
		public long msvolume;
		/// <summary>
		/// 매수누적체결건수
		/// </summary>
		[XAQueryFieldAttribute("mschecnt", "매수누적체결건수", "long", "8")]
		public long mschecnt;
		/// <summary>
		/// 체결강도
		/// </summary>
		[XAQueryFieldAttribute("cpower", "체결강도", "float", "9.2")]
		public float cpower;
		/// <summary>
		/// 가중평균가
		/// </summary>
		[XAQueryFieldAttribute("w_avrg", "가중평균가", "long", "8")]
		public long w_avrg;
		/// <summary>
		/// 매도호가
		/// </summary>
		[XAQueryFieldAttribute("offerho", "매도호가", "long", "8")]
		public long offerho;
		/// <summary>
		/// 매수호가
		/// </summary>
		[XAQueryFieldAttribute("bidho", "매수호가", "long", "8")]
		public long bidho;
		/// <summary>
		/// 장정보
		/// </summary>
		[XAQueryFieldAttribute("status", "장정보", "char", "2")]
		public string status;
		/// <summary>
		/// 전일동시간대거래량
		/// </summary>
		[XAQueryFieldAttribute("jnilvolume", "전일동시간대거래량", "long", "12")]
		public long jnilvolume;
		/// <summary>
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("shcode", "단축코드", "char", "6")]
		public string shcode;

		public static class F
		{
			/// <summary>
			/// 체결시간
			/// </summary>
			public const string chetime = "chetime";
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
			public const string drate = "drate";
			/// <summary>
			/// 현재가
			/// </summary>
			public const string price = "price";
			/// <summary>
			/// 시가시간
			/// </summary>
			public const string opentime = "opentime";
			/// <summary>
			/// 시가
			/// </summary>
			public const string open = "open";
			/// <summary>
			/// 고가시간
			/// </summary>
			public const string hightime = "hightime";
			/// <summary>
			/// 고가
			/// </summary>
			public const string high = "high";
			/// <summary>
			/// 저가시간
			/// </summary>
			public const string lowtime = "lowtime";
			/// <summary>
			/// 저가
			/// </summary>
			public const string low = "low";
			/// <summary>
			/// 체결구분
			/// </summary>
			public const string cgubun = "cgubun";
			/// <summary>
			/// 체결량
			/// </summary>
			public const string cvolume = "cvolume";
			/// <summary>
			/// 누적거래량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// 누적거래대금
			/// </summary>
			public const string value = "value";
			/// <summary>
			/// 매도누적체결량
			/// </summary>
			public const string mdvolume = "mdvolume";
			/// <summary>
			/// 매도누적체결건수
			/// </summary>
			public const string mdchecnt = "mdchecnt";
			/// <summary>
			/// 매수누적체결량
			/// </summary>
			public const string msvolume = "msvolume";
			/// <summary>
			/// 매수누적체결건수
			/// </summary>
			public const string mschecnt = "mschecnt";
			/// <summary>
			/// 체결강도
			/// </summary>
			public const string cpower = "cpower";
			/// <summary>
			/// 가중평균가
			/// </summary>
			public const string w_avrg = "w_avrg";
			/// <summary>
			/// 매도호가
			/// </summary>
			public const string offerho = "offerho";
			/// <summary>
			/// 매수호가
			/// </summary>
			public const string bidho = "bidho";
			/// <summary>
			/// 장정보
			/// </summary>
			public const string status = "status";
			/// <summary>
			/// 전일동시간대거래량
			/// </summary>
			public const string jnilvolume = "jnilvolume";
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string shcode = "shcode";
		}

		public static string[] AllFields = new string[]
		{
			F.chetime,
			F.sign,
			F.change,
			F.drate,
			F.price,
			F.opentime,
			F.open,
			F.hightime,
			F.high,
			F.lowtime,
			F.low,
			F.cgubun,
			F.cvolume,
			F.volume,
			F.value,
			F.mdvolume,
			F.mdchecnt,
			F.msvolume,
			F.mschecnt,
			F.cpower,
			F.w_avrg,
			F.offerho,
			F.bidho,
			F.status,
			F.jnilvolume,
			F.shcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["chetime"] = new XAQueryFieldInfo("char", chetime, chetime, "체결시간", (decimal)6);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("long", change, change.ToString("d8"), "전일대비", (decimal)8);
			dict["drate"] = new XAQueryFieldInfo("float", drate, drate.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["price"] = new XAQueryFieldInfo("long", price, price.ToString("d8"), "현재가", (decimal)8);
			dict["opentime"] = new XAQueryFieldInfo("char", opentime, opentime, "시가시간", (decimal)6);
			dict["open"] = new XAQueryFieldInfo("long", open, open.ToString("d8"), "시가", (decimal)8);
			dict["hightime"] = new XAQueryFieldInfo("char", hightime, hightime, "고가시간", (decimal)6);
			dict["high"] = new XAQueryFieldInfo("long", high, high.ToString("d8"), "고가", (decimal)8);
			dict["lowtime"] = new XAQueryFieldInfo("char", lowtime, lowtime, "저가시간", (decimal)6);
			dict["low"] = new XAQueryFieldInfo("long", low, low.ToString("d8"), "저가", (decimal)8);
			dict["cgubun"] = new XAQueryFieldInfo("char", cgubun, cgubun.ToString(), "체결구분", (decimal)1);
			dict["cvolume"] = new XAQueryFieldInfo("long", cvolume, cvolume.ToString("d8"), "체결량", (decimal)8);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "누적거래량", (decimal)12);
			dict["value"] = new XAQueryFieldInfo("long", value, value.ToString("d12"), "누적거래대금", (decimal)12);
			dict["mdvolume"] = new XAQueryFieldInfo("long", mdvolume, mdvolume.ToString("d12"), "매도누적체결량", (decimal)12);
			dict["mdchecnt"] = new XAQueryFieldInfo("long", mdchecnt, mdchecnt.ToString("d8"), "매도누적체결건수", (decimal)8);
			dict["msvolume"] = new XAQueryFieldInfo("long", msvolume, msvolume.ToString("d12"), "매수누적체결량", (decimal)12);
			dict["mschecnt"] = new XAQueryFieldInfo("long", mschecnt, mschecnt.ToString("d8"), "매수누적체결건수", (decimal)8);
			dict["cpower"] = new XAQueryFieldInfo("float", cpower, cpower.ToString("000000000.00"), "체결강도", (decimal)9.2);
			dict["w_avrg"] = new XAQueryFieldInfo("long", w_avrg, w_avrg.ToString("d8"), "가중평균가", (decimal)8);
			dict["offerho"] = new XAQueryFieldInfo("long", offerho, offerho.ToString("d8"), "매도호가", (decimal)8);
			dict["bidho"] = new XAQueryFieldInfo("long", bidho, bidho.ToString("d8"), "매수호가", (decimal)8);
			dict["status"] = new XAQueryFieldInfo("char", status, status, "장정보", (decimal)2);
			dict["jnilvolume"] = new XAQueryFieldInfo("long", jnilvolume, jnilvolume.ToString("d12"), "전일동시간대거래량", (decimal)12);
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)6);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "chetime":
					this.chetime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "sign":
					this.sign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "change":
					this.change = fieldInfo.FieldValue.ParseLong("change");
				break;

				case "drate":
					this.drate = fieldInfo.FieldValue.ParseFloat("drate");
				break;

				case "price":
					this.price = fieldInfo.FieldValue.ParseLong("price");
				break;

				case "opentime":
					this.opentime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "open":
					this.open = fieldInfo.FieldValue.ParseLong("open");
				break;

				case "hightime":
					this.hightime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "high":
					this.high = fieldInfo.FieldValue.ParseLong("high");
				break;

				case "lowtime":
					this.lowtime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "low":
					this.low = fieldInfo.FieldValue.ParseLong("low");
				break;

				case "cgubun":
					this.cgubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "cvolume":
					this.cvolume = fieldInfo.FieldValue.ParseLong("cvolume");
				break;

				case "volume":
					this.volume = fieldInfo.FieldValue.ParseLong("volume");
				break;

				case "value":
					this.value = fieldInfo.FieldValue.ParseLong("value");
				break;

				case "mdvolume":
					this.mdvolume = fieldInfo.FieldValue.ParseLong("mdvolume");
				break;

				case "mdchecnt":
					this.mdchecnt = fieldInfo.FieldValue.ParseLong("mdchecnt");
				break;

				case "msvolume":
					this.msvolume = fieldInfo.FieldValue.ParseLong("msvolume");
				break;

				case "mschecnt":
					this.mschecnt = fieldInfo.FieldValue.ParseLong("mschecnt");
				break;

				case "cpower":
					this.cpower = fieldInfo.FieldValue.ParseFloat("cpower");
				break;

				case "w_avrg":
					this.w_avrg = fieldInfo.FieldValue.ParseLong("w_avrg");
				break;

				case "offerho":
					this.offerho = fieldInfo.FieldValue.ParseLong("offerho");
				break;

				case "bidho":
					this.bidho = fieldInfo.FieldValue.ParseLong("bidho");
				break;

				case "status":
					this.status = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "jnilvolume":
					this.jnilvolume = fieldInfo.FieldValue.ParseLong("jnilvolume");
				break;

				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XRS3_OutBlock FromQuery(XRS3_ query)
		{
			XRS3_OutBlock block = new XRS3_OutBlock();
			block.IsValidData = true;
			block.InvalidReason = "";
			try
			{
				block.chetime = query.GetFieldData(block.GetBlockName(), "chetime").TrimEnd('?'); // char 6
				block.sign = query.GetFieldData(block.GetBlockName(), "sign").FirstOrDefault(); // char 1
				block.change = query.GetFieldData(block.GetBlockName(), "change").ParseLong("change"); // long 8
				block.drate = query.GetFieldData(block.GetBlockName(), "drate").ParseFloat("drate"); // float 6.2
				block.price = query.GetFieldData(block.GetBlockName(), "price").ParseLong("price"); // long 8
				block.opentime = query.GetFieldData(block.GetBlockName(), "opentime").TrimEnd('?'); // char 6
				block.open = query.GetFieldData(block.GetBlockName(), "open").ParseLong("open"); // long 8
				block.hightime = query.GetFieldData(block.GetBlockName(), "hightime").TrimEnd('?'); // char 6
				block.high = query.GetFieldData(block.GetBlockName(), "high").ParseLong("high"); // long 8
				block.lowtime = query.GetFieldData(block.GetBlockName(), "lowtime").TrimEnd('?'); // char 6
				block.low = query.GetFieldData(block.GetBlockName(), "low").ParseLong("low"); // long 8
				block.cgubun = query.GetFieldData(block.GetBlockName(), "cgubun").FirstOrDefault(); // char 1
				block.cvolume = query.GetFieldData(block.GetBlockName(), "cvolume").ParseLong("cvolume"); // long 8
				block.volume = query.GetFieldData(block.GetBlockName(), "volume").ParseLong("volume"); // long 12
				block.value = query.GetFieldData(block.GetBlockName(), "value").ParseLong("value"); // long 12
				block.mdvolume = query.GetFieldData(block.GetBlockName(), "mdvolume").ParseLong("mdvolume"); // long 12
				block.mdchecnt = query.GetFieldData(block.GetBlockName(), "mdchecnt").ParseLong("mdchecnt"); // long 8
				block.msvolume = query.GetFieldData(block.GetBlockName(), "msvolume").ParseLong("msvolume"); // long 12
				block.mschecnt = query.GetFieldData(block.GetBlockName(), "mschecnt").ParseLong("mschecnt"); // long 8
				block.cpower = query.GetFieldData(block.GetBlockName(), "cpower").ParseFloat("cpower"); // float 9.2
				block.w_avrg = query.GetFieldData(block.GetBlockName(), "w_avrg").ParseLong("w_avrg"); // long 8
				block.offerho = query.GetFieldData(block.GetBlockName(), "offerho").ParseLong("offerho"); // long 8
				block.bidho = query.GetFieldData(block.GetBlockName(), "bidho").ParseLong("bidho"); // long 8
				block.status = query.GetFieldData(block.GetBlockName(), "status").TrimEnd('?'); // char 2
				block.jnilvolume = query.GetFieldData(block.GetBlockName(), "jnilvolume").ParseLong("jnilvolume"); // long 12
				block.shcode = query.GetFieldData(block.GetBlockName(), "shcode").TrimEnd('?'); // char 6

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (chetime?.Length > 6) return false; // char 6
			// sign char 1
			if (change.ToString().Length > 8) return false; // long 8
			// drate float 6.2
			if (price.ToString().Length > 8) return false; // long 8
			if (opentime?.Length > 6) return false; // char 6
			if (open.ToString().Length > 8) return false; // long 8
			if (hightime?.Length > 6) return false; // char 6
			if (high.ToString().Length > 8) return false; // long 8
			if (lowtime?.Length > 6) return false; // char 6
			if (low.ToString().Length > 8) return false; // long 8
			// cgubun char 1
			if (cvolume.ToString().Length > 8) return false; // long 8
			if (volume.ToString().Length > 12) return false; // long 12
			if (value.ToString().Length > 12) return false; // long 12
			if (mdvolume.ToString().Length > 12) return false; // long 12
			if (mdchecnt.ToString().Length > 8) return false; // long 8
			if (msvolume.ToString().Length > 12) return false; // long 12
			if (mschecnt.ToString().Length > 8) return false; // long 8
			// cpower float 9.2
			if (w_avrg.ToString().Length > 8) return false; // long 8
			if (offerho.ToString().Length > 8) return false; // long 8
			if (bidho.ToString().Length > 8) return false; // long 8
			if (status?.Length > 2) return false; // char 2
			if (jnilvolume.ToString().Length > 12) return false; // long 12
			if (shcode?.Length > 6) return false; // char 6

			return true;
		}
	}

	/// <summary>
	/// KOSPI체결(S3)
	/// </summary>
	public partial class XRS3_ : XingReal
	{
		/// <summary>
		/// S3_
		/// </summary>
		public const string _typeName = "S3_";
		/// <summary>
		/// KOSPI체결(S3)
		/// </summary>
		public const string _typeDesc = "KOSPI체결(S3)";
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
		/// S3_
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// KOSPI체결(S3)
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
		/// KOSPI체결(S3)
		/// </summary>
		public XRS3_() : base("S3_") { }


		public bool SetBlock(XRS3_InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaReal.SetFieldData(block.GetBlockName(), "shcode", block.shcode); // char 6

			return true;
		}

		public XRS3_OutBlock GetBlock()
		{
			XRS3_OutBlock instance = XRS3_OutBlock.FromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XRS3_OutBlock),

		};

	}

}
