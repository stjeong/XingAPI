using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XROMGInBlock : XingBlock
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
		/// 옵션코드
		/// </summary>
		[XAQueryFieldAttribute("optcode", "옵션코드", "char", "8")]
		public string optcode;

		public static class F
		{
			/// <summary>
			/// 옵션코드
			/// </summary>
			public const string optcode = "optcode";
		}

		public static string[] AllFields = new string[]
		{
			F.optcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["optcode"] = new XAQueryFieldInfo("char", optcode, optcode, "옵션코드", (decimal)8);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "optcode":
					this.optcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (optcode?.Length > 8) return false; // char 8

			return true;
		}

		public void CopyTo(XROMGInBlock block)
		{
			block.optcode = this.optcode;

		}
	}

	public partial class XROMGOutBlock : XingBlock
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
		/// 행사가
		/// </summary>
		[XAQueryFieldAttribute("actprice", "행사가", "float", "6.2")]
		public float actprice;
		/// <summary>
		/// KOSPI200지수
		/// </summary>
		[XAQueryFieldAttribute("k200jisu", "KOSPI200지수", "float", "6.2")]
		public float k200jisu;
		/// <summary>
		/// 선물가격
		/// </summary>
		[XAQueryFieldAttribute("fut200jisu", "선물가격", "float", "6.2")]
		public float fut200jisu;
		/// <summary>
		/// 현재가
		/// </summary>
		[XAQueryFieldAttribute("price", "현재가", "float", "6.2")]
		public float price;
		/// <summary>
		/// 대표내재변동성
		/// </summary>
		[XAQueryFieldAttribute("capimpv", "대표내재변동성", "float", "6.2")]
		public float capimpv;
		/// <summary>
		/// 내재변동성
		/// </summary>
		[XAQueryFieldAttribute("impv", "내재변동성", "float", "6.2")]
		public float impv;
		/// <summary>
		/// 델타(블랙숄즈)
		/// </summary>
		[XAQueryFieldAttribute("delt", "델타(블랙숄즈)", "float", "7.4")]
		public float delt;
		/// <summary>
		/// 감마(블랙숄즈)
		/// </summary>
		[XAQueryFieldAttribute("gama", "감마(블랙숄즈)", "float", "7.4")]
		public float gama;
		/// <summary>
		/// 세타(블랙숄즈)
		/// </summary>
		[XAQueryFieldAttribute("ceta", "세타(블랙숄즈)", "float", "7.4")]
		public float ceta;
		/// <summary>
		/// 베가(블랙숄즈)
		/// </summary>
		[XAQueryFieldAttribute("vega", "베가(블랙숄즈)", "float", "7.4")]
		public float vega;
		/// <summary>
		/// 로우(블랙숄즈)
		/// </summary>
		[XAQueryFieldAttribute("rhox", "로우(블랙숄즈)", "float", "7.4")]
		public float rhox;
		/// <summary>
		/// 이론가(블랙숄즈)
		/// </summary>
		[XAQueryFieldAttribute("theoryprice", "이론가(블랙숄즈)", "float", "6.2")]
		public float theoryprice;
		/// <summary>
		/// 전일가내재변동성
		/// </summary>
		[XAQueryFieldAttribute("bimpv", "전일가내재변동성", "float", "6.2")]
		public float bimpv;
		/// <summary>
		/// 매도가내재변동성
		/// </summary>
		[XAQueryFieldAttribute("offerimpv", "매도가내재변동성", "float", "6.2")]
		public float offerimpv;
		/// <summary>
		/// 매수가내재변동성
		/// </summary>
		[XAQueryFieldAttribute("bidimpv", "매수가내재변동성", "float", "6.2")]
		public float bidimpv;
		/// <summary>
		/// 옵션코드
		/// </summary>
		[XAQueryFieldAttribute("optcode", "옵션코드", "char", "8")]
		public string optcode;

		public static class F
		{
			/// <summary>
			/// 체결시간
			/// </summary>
			public const string chetime = "chetime";
			/// <summary>
			/// 행사가
			/// </summary>
			public const string actprice = "actprice";
			/// <summary>
			/// KOSPI200지수
			/// </summary>
			public const string k200jisu = "k200jisu";
			/// <summary>
			/// 선물가격
			/// </summary>
			public const string fut200jisu = "fut200jisu";
			/// <summary>
			/// 현재가
			/// </summary>
			public const string price = "price";
			/// <summary>
			/// 대표내재변동성
			/// </summary>
			public const string capimpv = "capimpv";
			/// <summary>
			/// 내재변동성
			/// </summary>
			public const string impv = "impv";
			/// <summary>
			/// 델타(블랙숄즈)
			/// </summary>
			public const string delt = "delt";
			/// <summary>
			/// 감마(블랙숄즈)
			/// </summary>
			public const string gama = "gama";
			/// <summary>
			/// 세타(블랙숄즈)
			/// </summary>
			public const string ceta = "ceta";
			/// <summary>
			/// 베가(블랙숄즈)
			/// </summary>
			public const string vega = "vega";
			/// <summary>
			/// 로우(블랙숄즈)
			/// </summary>
			public const string rhox = "rhox";
			/// <summary>
			/// 이론가(블랙숄즈)
			/// </summary>
			public const string theoryprice = "theoryprice";
			/// <summary>
			/// 전일가내재변동성
			/// </summary>
			public const string bimpv = "bimpv";
			/// <summary>
			/// 매도가내재변동성
			/// </summary>
			public const string offerimpv = "offerimpv";
			/// <summary>
			/// 매수가내재변동성
			/// </summary>
			public const string bidimpv = "bidimpv";
			/// <summary>
			/// 옵션코드
			/// </summary>
			public const string optcode = "optcode";
		}

		public static string[] AllFields = new string[]
		{
			F.chetime,
			F.actprice,
			F.k200jisu,
			F.fut200jisu,
			F.price,
			F.capimpv,
			F.impv,
			F.delt,
			F.gama,
			F.ceta,
			F.vega,
			F.rhox,
			F.theoryprice,
			F.bimpv,
			F.offerimpv,
			F.bidimpv,
			F.optcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["chetime"] = new XAQueryFieldInfo("char", chetime, chetime, "체결시간", (decimal)6);
			dict["actprice"] = new XAQueryFieldInfo("float", actprice, actprice.ToString("000000.00"), "행사가", (decimal)6.2);
			dict["k200jisu"] = new XAQueryFieldInfo("float", k200jisu, k200jisu.ToString("000000.00"), "KOSPI200지수", (decimal)6.2);
			dict["fut200jisu"] = new XAQueryFieldInfo("float", fut200jisu, fut200jisu.ToString("000000.00"), "선물가격", (decimal)6.2);
			dict["price"] = new XAQueryFieldInfo("float", price, price.ToString("000000.00"), "현재가", (decimal)6.2);
			dict["capimpv"] = new XAQueryFieldInfo("float", capimpv, capimpv.ToString("000000.00"), "대표내재변동성", (decimal)6.2);
			dict["impv"] = new XAQueryFieldInfo("float", impv, impv.ToString("000000.00"), "내재변동성", (decimal)6.2);
			dict["delt"] = new XAQueryFieldInfo("float", delt, delt.ToString("0000000.0000"), "델타(블랙숄즈)", (decimal)7.4);
			dict["gama"] = new XAQueryFieldInfo("float", gama, gama.ToString("0000000.0000"), "감마(블랙숄즈)", (decimal)7.4);
			dict["ceta"] = new XAQueryFieldInfo("float", ceta, ceta.ToString("0000000.0000"), "세타(블랙숄즈)", (decimal)7.4);
			dict["vega"] = new XAQueryFieldInfo("float", vega, vega.ToString("0000000.0000"), "베가(블랙숄즈)", (decimal)7.4);
			dict["rhox"] = new XAQueryFieldInfo("float", rhox, rhox.ToString("0000000.0000"), "로우(블랙숄즈)", (decimal)7.4);
			dict["theoryprice"] = new XAQueryFieldInfo("float", theoryprice, theoryprice.ToString("000000.00"), "이론가(블랙숄즈)", (decimal)6.2);
			dict["bimpv"] = new XAQueryFieldInfo("float", bimpv, bimpv.ToString("000000.00"), "전일가내재변동성", (decimal)6.2);
			dict["offerimpv"] = new XAQueryFieldInfo("float", offerimpv, offerimpv.ToString("000000.00"), "매도가내재변동성", (decimal)6.2);
			dict["bidimpv"] = new XAQueryFieldInfo("float", bidimpv, bidimpv.ToString("000000.00"), "매수가내재변동성", (decimal)6.2);
			dict["optcode"] = new XAQueryFieldInfo("char", optcode, optcode, "옵션코드", (decimal)8);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "chetime":
					this.chetime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "actprice":
					this.actprice = fieldInfo.FieldValue.ParseFloat("actprice");
				break;

				case "k200jisu":
					this.k200jisu = fieldInfo.FieldValue.ParseFloat("k200jisu");
				break;

				case "fut200jisu":
					this.fut200jisu = fieldInfo.FieldValue.ParseFloat("fut200jisu");
				break;

				case "price":
					this.price = fieldInfo.FieldValue.ParseFloat("price");
				break;

				case "capimpv":
					this.capimpv = fieldInfo.FieldValue.ParseFloat("capimpv");
				break;

				case "impv":
					this.impv = fieldInfo.FieldValue.ParseFloat("impv");
				break;

				case "delt":
					this.delt = fieldInfo.FieldValue.ParseFloat("delt");
				break;

				case "gama":
					this.gama = fieldInfo.FieldValue.ParseFloat("gama");
				break;

				case "ceta":
					this.ceta = fieldInfo.FieldValue.ParseFloat("ceta");
				break;

				case "vega":
					this.vega = fieldInfo.FieldValue.ParseFloat("vega");
				break;

				case "rhox":
					this.rhox = fieldInfo.FieldValue.ParseFloat("rhox");
				break;

				case "theoryprice":
					this.theoryprice = fieldInfo.FieldValue.ParseFloat("theoryprice");
				break;

				case "bimpv":
					this.bimpv = fieldInfo.FieldValue.ParseFloat("bimpv");
				break;

				case "offerimpv":
					this.offerimpv = fieldInfo.FieldValue.ParseFloat("offerimpv");
				break;

				case "bidimpv":
					this.bidimpv = fieldInfo.FieldValue.ParseFloat("bidimpv");
				break;

				case "optcode":
					this.optcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XROMGOutBlock FromQuery(XROMG query)
		{
			XROMGOutBlock block = new XROMGOutBlock();
			block.IsValidData = true;
			block.InvalidReason = "";
			try
			{
				block.chetime = query.GetFieldData(block.GetBlockName(), "chetime").TrimEnd('?'); // char 6
				block.actprice = query.GetFieldData(block.GetBlockName(), "actprice").ParseFloat("actprice"); // float 6.2
				block.k200jisu = query.GetFieldData(block.GetBlockName(), "k200jisu").ParseFloat("k200jisu"); // float 6.2
				block.fut200jisu = query.GetFieldData(block.GetBlockName(), "fut200jisu").ParseFloat("fut200jisu"); // float 6.2
				block.price = query.GetFieldData(block.GetBlockName(), "price").ParseFloat("price"); // float 6.2
				block.capimpv = query.GetFieldData(block.GetBlockName(), "capimpv").ParseFloat("capimpv"); // float 6.2
				block.impv = query.GetFieldData(block.GetBlockName(), "impv").ParseFloat("impv"); // float 6.2
				block.delt = query.GetFieldData(block.GetBlockName(), "delt").ParseFloat("delt"); // float 7.4
				block.gama = query.GetFieldData(block.GetBlockName(), "gama").ParseFloat("gama"); // float 7.4
				block.ceta = query.GetFieldData(block.GetBlockName(), "ceta").ParseFloat("ceta"); // float 7.4
				block.vega = query.GetFieldData(block.GetBlockName(), "vega").ParseFloat("vega"); // float 7.4
				block.rhox = query.GetFieldData(block.GetBlockName(), "rhox").ParseFloat("rhox"); // float 7.4
				block.theoryprice = query.GetFieldData(block.GetBlockName(), "theoryprice").ParseFloat("theoryprice"); // float 6.2
				block.bimpv = query.GetFieldData(block.GetBlockName(), "bimpv").ParseFloat("bimpv"); // float 6.2
				block.offerimpv = query.GetFieldData(block.GetBlockName(), "offerimpv").ParseFloat("offerimpv"); // float 6.2
				block.bidimpv = query.GetFieldData(block.GetBlockName(), "bidimpv").ParseFloat("bidimpv"); // float 6.2
				block.optcode = query.GetFieldData(block.GetBlockName(), "optcode").TrimEnd('?'); // char 8

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (chetime?.Length > 6) return false; // char 6
			// actprice float 6.2
			// k200jisu float 6.2
			// fut200jisu float 6.2
			// price float 6.2
			// capimpv float 6.2
			// impv float 6.2
			// delt float 7.4
			// gama float 7.4
			// ceta float 7.4
			// vega float 7.4
			// rhox float 7.4
			// theoryprice float 6.2
			// bimpv float 6.2
			// offerimpv float 6.2
			// bidimpv float 6.2
			if (optcode?.Length > 8) return false; // char 8

			return true;
		}

		public void CopyTo(XROMGOutBlock block)
		{
			block.chetime = this.chetime;
			block.actprice = this.actprice;
			block.k200jisu = this.k200jisu;
			block.fut200jisu = this.fut200jisu;
			block.price = this.price;
			block.capimpv = this.capimpv;
			block.impv = this.impv;
			block.delt = this.delt;
			block.gama = this.gama;
			block.ceta = this.ceta;
			block.vega = this.vega;
			block.rhox = this.rhox;
			block.theoryprice = this.theoryprice;
			block.bimpv = this.bimpv;
			block.offerimpv = this.offerimpv;
			block.bidimpv = this.bidimpv;
			block.optcode = this.optcode;

		}
	}

	/// <summary>
	/// KOSPI200옵션민감도(MG)
	/// </summary>
	public partial class XROMG : XingReal
	{
		/// <summary>
		/// OMG
		/// </summary>
		public const string _typeName = "OMG";
		/// <summary>
		/// KOSPI200옵션민감도(MG)
		/// </summary>
		public const string _typeDesc = "KOSPI200옵션민감도(MG)";
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
		/// OMG
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// KOSPI200옵션민감도(MG)
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
		/// KOSPI200옵션민감도(MG)
		/// </summary>
		public XROMG() : base("OMG") { }


		public bool SetBlock(XROMGInBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaReal.SetFieldData(block.GetBlockName(), "optcode", block.optcode); // char 8

			return true;
		}

		public XROMGOutBlock GetBlock()
		{
			XROMGOutBlock instance = XROMGOutBlock.FromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XROMGOutBlock),

		};

	}

}
