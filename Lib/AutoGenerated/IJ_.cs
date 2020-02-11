using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XRIJ_InBlock : XingBlock
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
		/// 업종코드
		/// </summary>
		[XAQueryFieldAttribute("upcode", "업종코드", "char", "3")]
		public string upcode;

		public static class F
		{
			/// <summary>
			/// 업종코드
			/// </summary>
			public const string upcode = "upcode";
		}

		public static string[] AllFields = new string[]
		{
			F.upcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["upcode"] = new XAQueryFieldInfo("char", upcode, upcode, "업종코드", (decimal)3);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "upcode":
					this.upcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (upcode?.Length > 3) return false; // char 3

			return true;
		}
	}

	public partial class XRIJ_OutBlock : XingBlock
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
		/// 시간
		/// </summary>
		[XAQueryFieldAttribute("time", "시간", "char", "6")]
		public string time;
		/// <summary>
		/// 지수
		/// </summary>
		[XAQueryFieldAttribute("jisu", "지수", "float", "8.2")]
		public float jisu;
		/// <summary>
		/// 전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("sign", "전일대비구분", "char", "1")]
		public char sign;
		/// <summary>
		/// 전일비
		/// </summary>
		[XAQueryFieldAttribute("change", "전일비", "float", "8.2")]
		public float change;
		/// <summary>
		/// 등락율
		/// </summary>
		[XAQueryFieldAttribute("drate", "등락율", "float", "6.2")]
		public float drate;
		/// <summary>
		/// 체결량
		/// </summary>
		[XAQueryFieldAttribute("cvolume", "체결량", "long", "8")]
		public long cvolume;
		/// <summary>
		/// 거래량
		/// </summary>
		[XAQueryFieldAttribute("volume", "거래량", "long", "8")]
		public long volume;
		/// <summary>
		/// 거래대금
		/// </summary>
		[XAQueryFieldAttribute("value", "거래대금", "long", "8")]
		public long value;
		/// <summary>
		/// 상한종목수
		/// </summary>
		[XAQueryFieldAttribute("upjo", "상한종목수", "long", "4")]
		public long upjo;
		/// <summary>
		/// 상승종목수
		/// </summary>
		[XAQueryFieldAttribute("highjo", "상승종목수", "long", "4")]
		public long highjo;
		/// <summary>
		/// 보합종목수
		/// </summary>
		[XAQueryFieldAttribute("unchgjo", "보합종목수", "long", "4")]
		public long unchgjo;
		/// <summary>
		/// 하락종목수
		/// </summary>
		[XAQueryFieldAttribute("lowjo", "하락종목수", "long", "4")]
		public long lowjo;
		/// <summary>
		/// 하한종목수
		/// </summary>
		[XAQueryFieldAttribute("downjo", "하한종목수", "long", "4")]
		public long downjo;
		/// <summary>
		/// 상승종목비율
		/// </summary>
		[XAQueryFieldAttribute("upjrate", "상승종목비율", "float", "6.2")]
		public float upjrate;
		/// <summary>
		/// 시가지수
		/// </summary>
		[XAQueryFieldAttribute("openjisu", "시가지수", "float", "8.2")]
		public float openjisu;
		/// <summary>
		/// 시가시간
		/// </summary>
		[XAQueryFieldAttribute("opentime", "시가시간", "char", "6")]
		public string opentime;
		/// <summary>
		/// 고가지수
		/// </summary>
		[XAQueryFieldAttribute("highjisu", "고가지수", "float", "8.2")]
		public float highjisu;
		/// <summary>
		/// 고가시간
		/// </summary>
		[XAQueryFieldAttribute("hightime", "고가시간", "char", "6")]
		public string hightime;
		/// <summary>
		/// 저가지수
		/// </summary>
		[XAQueryFieldAttribute("lowjisu", "저가지수", "float", "8.2")]
		public float lowjisu;
		/// <summary>
		/// 저가시간
		/// </summary>
		[XAQueryFieldAttribute("lowtime", "저가시간", "char", "6")]
		public string lowtime;
		/// <summary>
		/// 외인순매수수량
		/// </summary>
		[XAQueryFieldAttribute("frgsvolume", "외인순매수수량", "long", "8")]
		public long frgsvolume;
		/// <summary>
		/// 기관순매수수량
		/// </summary>
		[XAQueryFieldAttribute("orgsvolume", "기관순매수수량", "long", "8")]
		public long orgsvolume;
		/// <summary>
		/// 외인순매수금액
		/// </summary>
		[XAQueryFieldAttribute("frgsvalue", "외인순매수금액", "long", "10")]
		public long frgsvalue;
		/// <summary>
		/// 기관순매수금액
		/// </summary>
		[XAQueryFieldAttribute("orgsvalue", "기관순매수금액", "long", "10")]
		public long orgsvalue;
		/// <summary>
		/// 업종코드
		/// </summary>
		[XAQueryFieldAttribute("upcode", "업종코드", "char", "3")]
		public string upcode;

		public static class F
		{
			/// <summary>
			/// 시간
			/// </summary>
			public const string time = "time";
			/// <summary>
			/// 지수
			/// </summary>
			public const string jisu = "jisu";
			/// <summary>
			/// 전일대비구분
			/// </summary>
			public const string sign = "sign";
			/// <summary>
			/// 전일비
			/// </summary>
			public const string change = "change";
			/// <summary>
			/// 등락율
			/// </summary>
			public const string drate = "drate";
			/// <summary>
			/// 체결량
			/// </summary>
			public const string cvolume = "cvolume";
			/// <summary>
			/// 거래량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// 거래대금
			/// </summary>
			public const string value = "value";
			/// <summary>
			/// 상한종목수
			/// </summary>
			public const string upjo = "upjo";
			/// <summary>
			/// 상승종목수
			/// </summary>
			public const string highjo = "highjo";
			/// <summary>
			/// 보합종목수
			/// </summary>
			public const string unchgjo = "unchgjo";
			/// <summary>
			/// 하락종목수
			/// </summary>
			public const string lowjo = "lowjo";
			/// <summary>
			/// 하한종목수
			/// </summary>
			public const string downjo = "downjo";
			/// <summary>
			/// 상승종목비율
			/// </summary>
			public const string upjrate = "upjrate";
			/// <summary>
			/// 시가지수
			/// </summary>
			public const string openjisu = "openjisu";
			/// <summary>
			/// 시가시간
			/// </summary>
			public const string opentime = "opentime";
			/// <summary>
			/// 고가지수
			/// </summary>
			public const string highjisu = "highjisu";
			/// <summary>
			/// 고가시간
			/// </summary>
			public const string hightime = "hightime";
			/// <summary>
			/// 저가지수
			/// </summary>
			public const string lowjisu = "lowjisu";
			/// <summary>
			/// 저가시간
			/// </summary>
			public const string lowtime = "lowtime";
			/// <summary>
			/// 외인순매수수량
			/// </summary>
			public const string frgsvolume = "frgsvolume";
			/// <summary>
			/// 기관순매수수량
			/// </summary>
			public const string orgsvolume = "orgsvolume";
			/// <summary>
			/// 외인순매수금액
			/// </summary>
			public const string frgsvalue = "frgsvalue";
			/// <summary>
			/// 기관순매수금액
			/// </summary>
			public const string orgsvalue = "orgsvalue";
			/// <summary>
			/// 업종코드
			/// </summary>
			public const string upcode = "upcode";
		}

		public static string[] AllFields = new string[]
		{
			F.time,
			F.jisu,
			F.sign,
			F.change,
			F.drate,
			F.cvolume,
			F.volume,
			F.value,
			F.upjo,
			F.highjo,
			F.unchgjo,
			F.lowjo,
			F.downjo,
			F.upjrate,
			F.openjisu,
			F.opentime,
			F.highjisu,
			F.hightime,
			F.lowjisu,
			F.lowtime,
			F.frgsvolume,
			F.orgsvolume,
			F.frgsvalue,
			F.orgsvalue,
			F.upcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["time"] = new XAQueryFieldInfo("char", time, time, "시간", (decimal)6);
			dict["jisu"] = new XAQueryFieldInfo("float", jisu, jisu.ToString("00000000.00"), "지수", (decimal)8.2);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("float", change, change.ToString("00000000.00"), "전일비", (decimal)8.2);
			dict["drate"] = new XAQueryFieldInfo("float", drate, drate.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["cvolume"] = new XAQueryFieldInfo("long", cvolume, cvolume.ToString("d8"), "체결량", (decimal)8);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d8"), "거래량", (decimal)8);
			dict["value"] = new XAQueryFieldInfo("long", value, value.ToString("d8"), "거래대금", (decimal)8);
			dict["upjo"] = new XAQueryFieldInfo("long", upjo, upjo.ToString("d4"), "상한종목수", (decimal)4);
			dict["highjo"] = new XAQueryFieldInfo("long", highjo, highjo.ToString("d4"), "상승종목수", (decimal)4);
			dict["unchgjo"] = new XAQueryFieldInfo("long", unchgjo, unchgjo.ToString("d4"), "보합종목수", (decimal)4);
			dict["lowjo"] = new XAQueryFieldInfo("long", lowjo, lowjo.ToString("d4"), "하락종목수", (decimal)4);
			dict["downjo"] = new XAQueryFieldInfo("long", downjo, downjo.ToString("d4"), "하한종목수", (decimal)4);
			dict["upjrate"] = new XAQueryFieldInfo("float", upjrate, upjrate.ToString("000000.00"), "상승종목비율", (decimal)6.2);
			dict["openjisu"] = new XAQueryFieldInfo("float", openjisu, openjisu.ToString("00000000.00"), "시가지수", (decimal)8.2);
			dict["opentime"] = new XAQueryFieldInfo("char", opentime, opentime, "시가시간", (decimal)6);
			dict["highjisu"] = new XAQueryFieldInfo("float", highjisu, highjisu.ToString("00000000.00"), "고가지수", (decimal)8.2);
			dict["hightime"] = new XAQueryFieldInfo("char", hightime, hightime, "고가시간", (decimal)6);
			dict["lowjisu"] = new XAQueryFieldInfo("float", lowjisu, lowjisu.ToString("00000000.00"), "저가지수", (decimal)8.2);
			dict["lowtime"] = new XAQueryFieldInfo("char", lowtime, lowtime, "저가시간", (decimal)6);
			dict["frgsvolume"] = new XAQueryFieldInfo("long", frgsvolume, frgsvolume.ToString("d8"), "외인순매수수량", (decimal)8);
			dict["orgsvolume"] = new XAQueryFieldInfo("long", orgsvolume, orgsvolume.ToString("d8"), "기관순매수수량", (decimal)8);
			dict["frgsvalue"] = new XAQueryFieldInfo("long", frgsvalue, frgsvalue.ToString("d10"), "외인순매수금액", (decimal)10);
			dict["orgsvalue"] = new XAQueryFieldInfo("long", orgsvalue, orgsvalue.ToString("d10"), "기관순매수금액", (decimal)10);
			dict["upcode"] = new XAQueryFieldInfo("char", upcode, upcode, "업종코드", (decimal)3);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "time":
					this.time = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "jisu":
					this.jisu = fieldInfo.FieldValue.ParseFloat("jisu");
				break;

				case "sign":
					this.sign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "change":
					this.change = fieldInfo.FieldValue.ParseFloat("change");
				break;

				case "drate":
					this.drate = fieldInfo.FieldValue.ParseFloat("drate");
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

				case "upjo":
					this.upjo = fieldInfo.FieldValue.ParseLong("upjo");
				break;

				case "highjo":
					this.highjo = fieldInfo.FieldValue.ParseLong("highjo");
				break;

				case "unchgjo":
					this.unchgjo = fieldInfo.FieldValue.ParseLong("unchgjo");
				break;

				case "lowjo":
					this.lowjo = fieldInfo.FieldValue.ParseLong("lowjo");
				break;

				case "downjo":
					this.downjo = fieldInfo.FieldValue.ParseLong("downjo");
				break;

				case "upjrate":
					this.upjrate = fieldInfo.FieldValue.ParseFloat("upjrate");
				break;

				case "openjisu":
					this.openjisu = fieldInfo.FieldValue.ParseFloat("openjisu");
				break;

				case "opentime":
					this.opentime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "highjisu":
					this.highjisu = fieldInfo.FieldValue.ParseFloat("highjisu");
				break;

				case "hightime":
					this.hightime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "lowjisu":
					this.lowjisu = fieldInfo.FieldValue.ParseFloat("lowjisu");
				break;

				case "lowtime":
					this.lowtime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "frgsvolume":
					this.frgsvolume = fieldInfo.FieldValue.ParseLong("frgsvolume");
				break;

				case "orgsvolume":
					this.orgsvolume = fieldInfo.FieldValue.ParseLong("orgsvolume");
				break;

				case "frgsvalue":
					this.frgsvalue = fieldInfo.FieldValue.ParseLong("frgsvalue");
				break;

				case "orgsvalue":
					this.orgsvalue = fieldInfo.FieldValue.ParseLong("orgsvalue");
				break;

				case "upcode":
					this.upcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XRIJ_OutBlock FromQuery(XRIJ_ query)
		{
			XRIJ_OutBlock block = new XRIJ_OutBlock();
			block.IsValidData = true;
			block.InvalidReason = "";
			try
			{
				block.time = query.GetFieldData(block.GetBlockName(), "time").TrimEnd('?'); // char 6
				block.jisu = query.GetFieldData(block.GetBlockName(), "jisu").ParseFloat("jisu"); // float 8.2
				block.sign = query.GetFieldData(block.GetBlockName(), "sign").FirstOrDefault(); // char 1
				block.change = query.GetFieldData(block.GetBlockName(), "change").ParseFloat("change"); // float 8.2
				block.drate = query.GetFieldData(block.GetBlockName(), "drate").ParseFloat("drate"); // float 6.2
				block.cvolume = query.GetFieldData(block.GetBlockName(), "cvolume").ParseLong("cvolume"); // long 8
				block.volume = query.GetFieldData(block.GetBlockName(), "volume").ParseLong("volume"); // long 8
				block.value = query.GetFieldData(block.GetBlockName(), "value").ParseLong("value"); // long 8
				block.upjo = query.GetFieldData(block.GetBlockName(), "upjo").ParseLong("upjo"); // long 4
				block.highjo = query.GetFieldData(block.GetBlockName(), "highjo").ParseLong("highjo"); // long 4
				block.unchgjo = query.GetFieldData(block.GetBlockName(), "unchgjo").ParseLong("unchgjo"); // long 4
				block.lowjo = query.GetFieldData(block.GetBlockName(), "lowjo").ParseLong("lowjo"); // long 4
				block.downjo = query.GetFieldData(block.GetBlockName(), "downjo").ParseLong("downjo"); // long 4
				block.upjrate = query.GetFieldData(block.GetBlockName(), "upjrate").ParseFloat("upjrate"); // float 6.2
				block.openjisu = query.GetFieldData(block.GetBlockName(), "openjisu").ParseFloat("openjisu"); // float 8.2
				block.opentime = query.GetFieldData(block.GetBlockName(), "opentime").TrimEnd('?'); // char 6
				block.highjisu = query.GetFieldData(block.GetBlockName(), "highjisu").ParseFloat("highjisu"); // float 8.2
				block.hightime = query.GetFieldData(block.GetBlockName(), "hightime").TrimEnd('?'); // char 6
				block.lowjisu = query.GetFieldData(block.GetBlockName(), "lowjisu").ParseFloat("lowjisu"); // float 8.2
				block.lowtime = query.GetFieldData(block.GetBlockName(), "lowtime").TrimEnd('?'); // char 6
				block.frgsvolume = query.GetFieldData(block.GetBlockName(), "frgsvolume").ParseLong("frgsvolume"); // long 8
				block.orgsvolume = query.GetFieldData(block.GetBlockName(), "orgsvolume").ParseLong("orgsvolume"); // long 8
				block.frgsvalue = query.GetFieldData(block.GetBlockName(), "frgsvalue").ParseLong("frgsvalue"); // long 10
				block.orgsvalue = query.GetFieldData(block.GetBlockName(), "orgsvalue").ParseLong("orgsvalue"); // long 10
				block.upcode = query.GetFieldData(block.GetBlockName(), "upcode").TrimEnd('?'); // char 3

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (time?.Length > 6) return false; // char 6
			// jisu float 8.2
			// sign char 1
			// change float 8.2
			// drate float 6.2
			if (cvolume.ToString().Length > 8) return false; // long 8
			if (volume.ToString().Length > 8) return false; // long 8
			if (value.ToString().Length > 8) return false; // long 8
			if (upjo.ToString().Length > 4) return false; // long 4
			if (highjo.ToString().Length > 4) return false; // long 4
			if (unchgjo.ToString().Length > 4) return false; // long 4
			if (lowjo.ToString().Length > 4) return false; // long 4
			if (downjo.ToString().Length > 4) return false; // long 4
			// upjrate float 6.2
			// openjisu float 8.2
			if (opentime?.Length > 6) return false; // char 6
			// highjisu float 8.2
			if (hightime?.Length > 6) return false; // char 6
			// lowjisu float 8.2
			if (lowtime?.Length > 6) return false; // char 6
			if (frgsvolume.ToString().Length > 8) return false; // long 8
			if (orgsvolume.ToString().Length > 8) return false; // long 8
			if (frgsvalue.ToString().Length > 10) return false; // long 10
			if (orgsvalue.ToString().Length > 10) return false; // long 10
			if (upcode?.Length > 3) return false; // char 3

			return true;
		}
	}

	/// <summary>
	/// 지수(IJ)
	/// </summary>
	public partial class XRIJ_ : XingReal
	{
		/// <summary>
		/// IJ_
		/// </summary>
		public const string _typeName = "IJ_";
		/// <summary>
		/// 지수(IJ)
		/// </summary>
		public const string _typeDesc = "지수(IJ)";
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
		/// IJ_
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 지수(IJ)
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
		/// 지수(IJ)
		/// </summary>
		public XRIJ_() : base("IJ_") { }


		public bool SetBlock(XRIJ_InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaReal.SetFieldData(block.GetBlockName(), "upcode", block.upcode); // char 3

			return true;
		}

		public XRIJ_OutBlock GetBlock()
		{
			XRIJ_OutBlock instance = XRIJ_OutBlock.FromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XRIJ_OutBlock),

		};

	}

}
