using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XRDK3InBlock : XingBlock
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

	public partial class XRDK3OutBlock : XingBlock
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
		/// 시간외단일가체결시간
		/// </summary>
		[XAQueryFieldAttribute("dan_chetime", "시간외단일가체결시간", "char", "6")]
		public string dan_chetime;
		/// <summary>
		/// 시간외단일가전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("dan_sign", "시간외단일가전일대비구분", "char", "1")]
		public char dan_sign;
		/// <summary>
		/// 시간외단일가전일대비
		/// </summary>
		[XAQueryFieldAttribute("dan_change", "시간외단일가전일대비", "long", "8")]
		public long dan_change;
		/// <summary>
		/// 시간외단일가등락율
		/// </summary>
		[XAQueryFieldAttribute("dan_drate", "시간외단일가등락율", "float", "6.2")]
		public float dan_drate;
		/// <summary>
		/// 시간외단일가현재가
		/// </summary>
		[XAQueryFieldAttribute("dan_price", "시간외단일가현재가", "long", "8")]
		public long dan_price;
		/// <summary>
		/// 시간외단일가시가시간
		/// </summary>
		[XAQueryFieldAttribute("dan_opentime", "시간외단일가시가시간", "char", "6")]
		public string dan_opentime;
		/// <summary>
		/// 시간외단일가시가
		/// </summary>
		[XAQueryFieldAttribute("dan_open", "시간외단일가시가", "long", "8")]
		public long dan_open;
		/// <summary>
		/// 시간외단일가고가시간
		/// </summary>
		[XAQueryFieldAttribute("dan_hightime", "시간외단일가고가시간", "char", "6")]
		public string dan_hightime;
		/// <summary>
		/// 시간외단일가고가
		/// </summary>
		[XAQueryFieldAttribute("dan_high", "시간외단일가고가", "long", "8")]
		public long dan_high;
		/// <summary>
		/// 시간외단일가저가시간
		/// </summary>
		[XAQueryFieldAttribute("dan_lowtime", "시간외단일가저가시간", "char", "6")]
		public string dan_lowtime;
		/// <summary>
		/// 시간외단일가저가
		/// </summary>
		[XAQueryFieldAttribute("dan_low", "시간외단일가저가", "long", "8")]
		public long dan_low;
		/// <summary>
		/// 시간외단일가체결구분
		/// </summary>
		[XAQueryFieldAttribute("dan_cgubun", "시간외단일가체결구분", "char", "1")]
		public char dan_cgubun;
		/// <summary>
		/// 시간외단일가체결량
		/// </summary>
		[XAQueryFieldAttribute("dan_cvolume", "시간외단일가체결량", "long", "8")]
		public long dan_cvolume;
		/// <summary>
		/// 시간외단일가누적거래량
		/// </summary>
		[XAQueryFieldAttribute("dan_volume", "시간외단일가누적거래량", "long", "12")]
		public long dan_volume;
		/// <summary>
		/// 시간외단일가누적거래대금
		/// </summary>
		[XAQueryFieldAttribute("dan_value", "시간외단일가누적거래대금", "long", "12")]
		public long dan_value;
		/// <summary>
		/// 시간외단일가매도누적체결량
		/// </summary>
		[XAQueryFieldAttribute("dan_mdvolume", "시간외단일가매도누적체결량", "long", "12")]
		public long dan_mdvolume;
		/// <summary>
		/// 시간외단일가매도누적체결건수
		/// </summary>
		[XAQueryFieldAttribute("dan_mdchecnt", "시간외단일가매도누적체결건수", "long", "8")]
		public long dan_mdchecnt;
		/// <summary>
		/// 시간외단일가매수누적체결량
		/// </summary>
		[XAQueryFieldAttribute("dan_msvolume", "시간외단일가매수누적체결량", "long", "12")]
		public long dan_msvolume;
		/// <summary>
		/// 시간외단일가매수누적체결건수
		/// </summary>
		[XAQueryFieldAttribute("dan_mschecnt", "시간외단일가매수누적체결건수", "long", "8")]
		public long dan_mschecnt;
		/// <summary>
		/// 시간외단일가직전거래량
		/// </summary>
		[XAQueryFieldAttribute("dan_prevolume", "시간외단일가직전거래량", "long", "8")]
		public long dan_prevolume;
		/// <summary>
		/// 시간외단일가직전체결수량
		/// </summary>
		[XAQueryFieldAttribute("dan_precvolume", "시간외단일가직전체결수량", "long", "8")]
		public long dan_precvolume;
		/// <summary>
		/// 시간외단일가체결강도
		/// </summary>
		[XAQueryFieldAttribute("dan_cpower", "시간외단일가체결강도", "float", "9.2")]
		public float dan_cpower;
		/// <summary>
		/// 시간외단일가장정보
		/// </summary>
		[XAQueryFieldAttribute("dan_status", "시간외단일가장정보", "char", "2")]
		public string dan_status;
		/// <summary>
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("shcode", "단축코드", "char", "6")]
		public string shcode;

		public static class F
		{
			/// <summary>
			/// 시간외단일가체결시간
			/// </summary>
			public const string dan_chetime = "dan_chetime";
			/// <summary>
			/// 시간외단일가전일대비구분
			/// </summary>
			public const string dan_sign = "dan_sign";
			/// <summary>
			/// 시간외단일가전일대비
			/// </summary>
			public const string dan_change = "dan_change";
			/// <summary>
			/// 시간외단일가등락율
			/// </summary>
			public const string dan_drate = "dan_drate";
			/// <summary>
			/// 시간외단일가현재가
			/// </summary>
			public const string dan_price = "dan_price";
			/// <summary>
			/// 시간외단일가시가시간
			/// </summary>
			public const string dan_opentime = "dan_opentime";
			/// <summary>
			/// 시간외단일가시가
			/// </summary>
			public const string dan_open = "dan_open";
			/// <summary>
			/// 시간외단일가고가시간
			/// </summary>
			public const string dan_hightime = "dan_hightime";
			/// <summary>
			/// 시간외단일가고가
			/// </summary>
			public const string dan_high = "dan_high";
			/// <summary>
			/// 시간외단일가저가시간
			/// </summary>
			public const string dan_lowtime = "dan_lowtime";
			/// <summary>
			/// 시간외단일가저가
			/// </summary>
			public const string dan_low = "dan_low";
			/// <summary>
			/// 시간외단일가체결구분
			/// </summary>
			public const string dan_cgubun = "dan_cgubun";
			/// <summary>
			/// 시간외단일가체결량
			/// </summary>
			public const string dan_cvolume = "dan_cvolume";
			/// <summary>
			/// 시간외단일가누적거래량
			/// </summary>
			public const string dan_volume = "dan_volume";
			/// <summary>
			/// 시간외단일가누적거래대금
			/// </summary>
			public const string dan_value = "dan_value";
			/// <summary>
			/// 시간외단일가매도누적체결량
			/// </summary>
			public const string dan_mdvolume = "dan_mdvolume";
			/// <summary>
			/// 시간외단일가매도누적체결건수
			/// </summary>
			public const string dan_mdchecnt = "dan_mdchecnt";
			/// <summary>
			/// 시간외단일가매수누적체결량
			/// </summary>
			public const string dan_msvolume = "dan_msvolume";
			/// <summary>
			/// 시간외단일가매수누적체결건수
			/// </summary>
			public const string dan_mschecnt = "dan_mschecnt";
			/// <summary>
			/// 시간외단일가직전거래량
			/// </summary>
			public const string dan_prevolume = "dan_prevolume";
			/// <summary>
			/// 시간외단일가직전체결수량
			/// </summary>
			public const string dan_precvolume = "dan_precvolume";
			/// <summary>
			/// 시간외단일가체결강도
			/// </summary>
			public const string dan_cpower = "dan_cpower";
			/// <summary>
			/// 시간외단일가장정보
			/// </summary>
			public const string dan_status = "dan_status";
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string shcode = "shcode";
		}

		public static string[] AllFields = new string[]
		{
			F.dan_chetime,
			F.dan_sign,
			F.dan_change,
			F.dan_drate,
			F.dan_price,
			F.dan_opentime,
			F.dan_open,
			F.dan_hightime,
			F.dan_high,
			F.dan_lowtime,
			F.dan_low,
			F.dan_cgubun,
			F.dan_cvolume,
			F.dan_volume,
			F.dan_value,
			F.dan_mdvolume,
			F.dan_mdchecnt,
			F.dan_msvolume,
			F.dan_mschecnt,
			F.dan_prevolume,
			F.dan_precvolume,
			F.dan_cpower,
			F.dan_status,
			F.shcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["dan_chetime"] = new XAQueryFieldInfo("char", dan_chetime, dan_chetime, "시간외단일가체결시간", (decimal)6);
			dict["dan_sign"] = new XAQueryFieldInfo("char", dan_sign, dan_sign.ToString(), "시간외단일가전일대비구분", (decimal)1);
			dict["dan_change"] = new XAQueryFieldInfo("long", dan_change, dan_change.ToString("d8"), "시간외단일가전일대비", (decimal)8);
			dict["dan_drate"] = new XAQueryFieldInfo("float", dan_drate, dan_drate.ToString("000000.00"), "시간외단일가등락율", (decimal)6.2);
			dict["dan_price"] = new XAQueryFieldInfo("long", dan_price, dan_price.ToString("d8"), "시간외단일가현재가", (decimal)8);
			dict["dan_opentime"] = new XAQueryFieldInfo("char", dan_opentime, dan_opentime, "시간외단일가시가시간", (decimal)6);
			dict["dan_open"] = new XAQueryFieldInfo("long", dan_open, dan_open.ToString("d8"), "시간외단일가시가", (decimal)8);
			dict["dan_hightime"] = new XAQueryFieldInfo("char", dan_hightime, dan_hightime, "시간외단일가고가시간", (decimal)6);
			dict["dan_high"] = new XAQueryFieldInfo("long", dan_high, dan_high.ToString("d8"), "시간외단일가고가", (decimal)8);
			dict["dan_lowtime"] = new XAQueryFieldInfo("char", dan_lowtime, dan_lowtime, "시간외단일가저가시간", (decimal)6);
			dict["dan_low"] = new XAQueryFieldInfo("long", dan_low, dan_low.ToString("d8"), "시간외단일가저가", (decimal)8);
			dict["dan_cgubun"] = new XAQueryFieldInfo("char", dan_cgubun, dan_cgubun.ToString(), "시간외단일가체결구분", (decimal)1);
			dict["dan_cvolume"] = new XAQueryFieldInfo("long", dan_cvolume, dan_cvolume.ToString("d8"), "시간외단일가체결량", (decimal)8);
			dict["dan_volume"] = new XAQueryFieldInfo("long", dan_volume, dan_volume.ToString("d12"), "시간외단일가누적거래량", (decimal)12);
			dict["dan_value"] = new XAQueryFieldInfo("long", dan_value, dan_value.ToString("d12"), "시간외단일가누적거래대금", (decimal)12);
			dict["dan_mdvolume"] = new XAQueryFieldInfo("long", dan_mdvolume, dan_mdvolume.ToString("d12"), "시간외단일가매도누적체결량", (decimal)12);
			dict["dan_mdchecnt"] = new XAQueryFieldInfo("long", dan_mdchecnt, dan_mdchecnt.ToString("d8"), "시간외단일가매도누적체결건수", (decimal)8);
			dict["dan_msvolume"] = new XAQueryFieldInfo("long", dan_msvolume, dan_msvolume.ToString("d12"), "시간외단일가매수누적체결량", (decimal)12);
			dict["dan_mschecnt"] = new XAQueryFieldInfo("long", dan_mschecnt, dan_mschecnt.ToString("d8"), "시간외단일가매수누적체결건수", (decimal)8);
			dict["dan_prevolume"] = new XAQueryFieldInfo("long", dan_prevolume, dan_prevolume.ToString("d8"), "시간외단일가직전거래량", (decimal)8);
			dict["dan_precvolume"] = new XAQueryFieldInfo("long", dan_precvolume, dan_precvolume.ToString("d8"), "시간외단일가직전체결수량", (decimal)8);
			dict["dan_cpower"] = new XAQueryFieldInfo("float", dan_cpower, dan_cpower.ToString("000000000.00"), "시간외단일가체결강도", (decimal)9.2);
			dict["dan_status"] = new XAQueryFieldInfo("char", dan_status, dan_status, "시간외단일가장정보", (decimal)2);
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)6);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "dan_chetime":
					this.dan_chetime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "dan_sign":
					this.dan_sign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "dan_change":
					this.dan_change = fieldInfo.FieldValue.ParseLong("dan_change");
				break;

				case "dan_drate":
					this.dan_drate = fieldInfo.FieldValue.ParseFloat("dan_drate");
				break;

				case "dan_price":
					this.dan_price = fieldInfo.FieldValue.ParseLong("dan_price");
				break;

				case "dan_opentime":
					this.dan_opentime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "dan_open":
					this.dan_open = fieldInfo.FieldValue.ParseLong("dan_open");
				break;

				case "dan_hightime":
					this.dan_hightime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "dan_high":
					this.dan_high = fieldInfo.FieldValue.ParseLong("dan_high");
				break;

				case "dan_lowtime":
					this.dan_lowtime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "dan_low":
					this.dan_low = fieldInfo.FieldValue.ParseLong("dan_low");
				break;

				case "dan_cgubun":
					this.dan_cgubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "dan_cvolume":
					this.dan_cvolume = fieldInfo.FieldValue.ParseLong("dan_cvolume");
				break;

				case "dan_volume":
					this.dan_volume = fieldInfo.FieldValue.ParseLong("dan_volume");
				break;

				case "dan_value":
					this.dan_value = fieldInfo.FieldValue.ParseLong("dan_value");
				break;

				case "dan_mdvolume":
					this.dan_mdvolume = fieldInfo.FieldValue.ParseLong("dan_mdvolume");
				break;

				case "dan_mdchecnt":
					this.dan_mdchecnt = fieldInfo.FieldValue.ParseLong("dan_mdchecnt");
				break;

				case "dan_msvolume":
					this.dan_msvolume = fieldInfo.FieldValue.ParseLong("dan_msvolume");
				break;

				case "dan_mschecnt":
					this.dan_mschecnt = fieldInfo.FieldValue.ParseLong("dan_mschecnt");
				break;

				case "dan_prevolume":
					this.dan_prevolume = fieldInfo.FieldValue.ParseLong("dan_prevolume");
				break;

				case "dan_precvolume":
					this.dan_precvolume = fieldInfo.FieldValue.ParseLong("dan_precvolume");
				break;

				case "dan_cpower":
					this.dan_cpower = fieldInfo.FieldValue.ParseFloat("dan_cpower");
				break;

				case "dan_status":
					this.dan_status = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XRDK3OutBlock FromQuery(XRDK3 query)
		{
			XRDK3OutBlock block = new XRDK3OutBlock();
			block.IsValidData = true;
			block.InvalidReason = "";
			try
			{
				block.dan_chetime = query.GetFieldData(block.GetBlockName(), "dan_chetime").TrimEnd('?'); // char 6
				block.dan_sign = query.GetFieldData(block.GetBlockName(), "dan_sign").FirstOrDefault(); // char 1
				block.dan_change = query.GetFieldData(block.GetBlockName(), "dan_change").ParseLong("dan_change"); // long 8
				block.dan_drate = query.GetFieldData(block.GetBlockName(), "dan_drate").ParseFloat("dan_drate"); // float 6.2
				block.dan_price = query.GetFieldData(block.GetBlockName(), "dan_price").ParseLong("dan_price"); // long 8
				block.dan_opentime = query.GetFieldData(block.GetBlockName(), "dan_opentime").TrimEnd('?'); // char 6
				block.dan_open = query.GetFieldData(block.GetBlockName(), "dan_open").ParseLong("dan_open"); // long 8
				block.dan_hightime = query.GetFieldData(block.GetBlockName(), "dan_hightime").TrimEnd('?'); // char 6
				block.dan_high = query.GetFieldData(block.GetBlockName(), "dan_high").ParseLong("dan_high"); // long 8
				block.dan_lowtime = query.GetFieldData(block.GetBlockName(), "dan_lowtime").TrimEnd('?'); // char 6
				block.dan_low = query.GetFieldData(block.GetBlockName(), "dan_low").ParseLong("dan_low"); // long 8
				block.dan_cgubun = query.GetFieldData(block.GetBlockName(), "dan_cgubun").FirstOrDefault(); // char 1
				block.dan_cvolume = query.GetFieldData(block.GetBlockName(), "dan_cvolume").ParseLong("dan_cvolume"); // long 8
				block.dan_volume = query.GetFieldData(block.GetBlockName(), "dan_volume").ParseLong("dan_volume"); // long 12
				block.dan_value = query.GetFieldData(block.GetBlockName(), "dan_value").ParseLong("dan_value"); // long 12
				block.dan_mdvolume = query.GetFieldData(block.GetBlockName(), "dan_mdvolume").ParseLong("dan_mdvolume"); // long 12
				block.dan_mdchecnt = query.GetFieldData(block.GetBlockName(), "dan_mdchecnt").ParseLong("dan_mdchecnt"); // long 8
				block.dan_msvolume = query.GetFieldData(block.GetBlockName(), "dan_msvolume").ParseLong("dan_msvolume"); // long 12
				block.dan_mschecnt = query.GetFieldData(block.GetBlockName(), "dan_mschecnt").ParseLong("dan_mschecnt"); // long 8
				block.dan_prevolume = query.GetFieldData(block.GetBlockName(), "dan_prevolume").ParseLong("dan_prevolume"); // long 8
				block.dan_precvolume = query.GetFieldData(block.GetBlockName(), "dan_precvolume").ParseLong("dan_precvolume"); // long 8
				block.dan_cpower = query.GetFieldData(block.GetBlockName(), "dan_cpower").ParseFloat("dan_cpower"); // float 9.2
				block.dan_status = query.GetFieldData(block.GetBlockName(), "dan_status").TrimEnd('?'); // char 2
				block.shcode = query.GetFieldData(block.GetBlockName(), "shcode").TrimEnd('?'); // char 6

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (dan_chetime?.Length > 6) return false; // char 6
			// dan_sign char 1
			if (dan_change.ToString().Length > 8) return false; // long 8
			// dan_drate float 6.2
			if (dan_price.ToString().Length > 8) return false; // long 8
			if (dan_opentime?.Length > 6) return false; // char 6
			if (dan_open.ToString().Length > 8) return false; // long 8
			if (dan_hightime?.Length > 6) return false; // char 6
			if (dan_high.ToString().Length > 8) return false; // long 8
			if (dan_lowtime?.Length > 6) return false; // char 6
			if (dan_low.ToString().Length > 8) return false; // long 8
			// dan_cgubun char 1
			if (dan_cvolume.ToString().Length > 8) return false; // long 8
			if (dan_volume.ToString().Length > 12) return false; // long 12
			if (dan_value.ToString().Length > 12) return false; // long 12
			if (dan_mdvolume.ToString().Length > 12) return false; // long 12
			if (dan_mdchecnt.ToString().Length > 8) return false; // long 8
			if (dan_msvolume.ToString().Length > 12) return false; // long 12
			if (dan_mschecnt.ToString().Length > 8) return false; // long 8
			if (dan_prevolume.ToString().Length > 8) return false; // long 8
			if (dan_precvolume.ToString().Length > 8) return false; // long 8
			// dan_cpower float 9.2
			if (dan_status?.Length > 2) return false; // char 2
			if (shcode?.Length > 6) return false; // char 6

			return true;
		}
	}

	/// <summary>
	/// KOSDAQ시간외단일가체결(DK3)
	/// </summary>
	public partial class XRDK3 : XingReal
	{
		/// <summary>
		/// DK3
		/// </summary>
		public const string _typeName = "DK3";
		/// <summary>
		/// KOSDAQ시간외단일가체결(DK3)
		/// </summary>
		public const string _typeDesc = "KOSDAQ시간외단일가체결(DK3)";
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
		/// DK3
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// KOSDAQ시간외단일가체결(DK3)
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
		/// KOSDAQ시간외단일가체결(DK3)
		/// </summary>
		public XRDK3() : base("DK3") { }


		public bool SetBlock(XRDK3InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaReal.SetFieldData(block.GetBlockName(), "shcode", block.shcode); // char 6

			return true;
		}

		public XRDK3OutBlock GetBlock()
		{
			XRDK3OutBlock instance = XRDK3OutBlock.FromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XRDK3OutBlock),

		};

	}

}
