using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XRESNInBlock : XingBlock
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
		[XAQueryFieldAttribute("단축코드", "6")]
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

	public partial class XRESNOutBlock : XingBlock
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
		[XAQueryFieldAttribute("시간", "6")]
		public string time;
		/// <summary>
		/// 장중이론가
		/// </summary>
		[XAQueryFieldAttribute("장중이론가", "10.2")]
		public float theoryprice;
		/// <summary>
		/// 델타
		/// </summary>
		[XAQueryFieldAttribute("델타", "7.6")]
		public float delt;
		/// <summary>
		/// 감마
		/// </summary>
		[XAQueryFieldAttribute("감마", "7.6")]
		public float gama;
		/// <summary>
		/// 세타
		/// </summary>
		[XAQueryFieldAttribute("세타", "12.6")]
		public float ceta;
		/// <summary>
		/// 베가
		/// </summary>
		[XAQueryFieldAttribute("베가", "12.6")]
		public float vega;
		/// <summary>
		/// 로우
		/// </summary>
		[XAQueryFieldAttribute("로우", "12.6")]
		public float rhox;
		/// <summary>
		/// 내재변동성
		/// </summary>
		[XAQueryFieldAttribute("내재변동성", "5.2")]
		public float impv;
		/// <summary>
		/// E.기어링
		/// </summary>
		[XAQueryFieldAttribute("E.기어링", "8.2")]
		public float egearing;
		/// <summary>
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("단축코드", "6")]
		public string shcode;
		/// <summary>
		/// ELW현재가
		/// </summary>
		[XAQueryFieldAttribute("ELW현재가", "8")]
		public long elwclose;
		/// <summary>
		/// ELW전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("ELW전일대비구분", "1")]
		public char sign;
		/// <summary>
		/// ELW전일대비
		/// </summary>
		[XAQueryFieldAttribute("ELW전일대비", "8")]
		public long change;
		/// <summary>
		/// 일자
		/// </summary>
		[XAQueryFieldAttribute("일자", "8")]
		public string date;
		/// <summary>
		/// 틱환산
		/// </summary>
		[XAQueryFieldAttribute("틱환산", "10.2")]
		public float tickvalue;
		/// <summary>
		/// LP내재변동성
		/// </summary>
		[XAQueryFieldAttribute("LP내재변동성", "5.2")]
		public float lp_impv;

		public static class F
		{
			/// <summary>
			/// 시간
			/// </summary>
			public const string time = "time";
			/// <summary>
			/// 장중이론가
			/// </summary>
			public const string theoryprice = "theoryprice";
			/// <summary>
			/// 델타
			/// </summary>
			public const string delt = "delt";
			/// <summary>
			/// 감마
			/// </summary>
			public const string gama = "gama";
			/// <summary>
			/// 세타
			/// </summary>
			public const string ceta = "ceta";
			/// <summary>
			/// 베가
			/// </summary>
			public const string vega = "vega";
			/// <summary>
			/// 로우
			/// </summary>
			public const string rhox = "rhox";
			/// <summary>
			/// 내재변동성
			/// </summary>
			public const string impv = "impv";
			/// <summary>
			/// E.기어링
			/// </summary>
			public const string egearing = "egearing";
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// ELW현재가
			/// </summary>
			public const string elwclose = "elwclose";
			/// <summary>
			/// ELW전일대비구분
			/// </summary>
			public const string sign = "sign";
			/// <summary>
			/// ELW전일대비
			/// </summary>
			public const string change = "change";
			/// <summary>
			/// 일자
			/// </summary>
			public const string date = "date";
			/// <summary>
			/// 틱환산
			/// </summary>
			public const string tickvalue = "tickvalue";
			/// <summary>
			/// LP내재변동성
			/// </summary>
			public const string lp_impv = "lp_impv";
		}

		public static string[] AllFields = new string[]
		{
			F.time,
			F.theoryprice,
			F.delt,
			F.gama,
			F.ceta,
			F.vega,
			F.rhox,
			F.impv,
			F.egearing,
			F.shcode,
			F.elwclose,
			F.sign,
			F.change,
			F.date,
			F.tickvalue,
			F.lp_impv,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["time"] = new XAQueryFieldInfo("char", time, time, "시간", (decimal)6);
			dict["theoryprice"] = new XAQueryFieldInfo("float", theoryprice, theoryprice.ToString("0000000000.00"), "장중이론가", (decimal)10.2);
			dict["delt"] = new XAQueryFieldInfo("float", delt, delt.ToString("0000000.000000"), "델타", (decimal)7.6);
			dict["gama"] = new XAQueryFieldInfo("float", gama, gama.ToString("0000000.000000"), "감마", (decimal)7.6);
			dict["ceta"] = new XAQueryFieldInfo("float", ceta, ceta.ToString("000000000000.000000"), "세타", (decimal)12.6);
			dict["vega"] = new XAQueryFieldInfo("float", vega, vega.ToString("000000000000.000000"), "베가", (decimal)12.6);
			dict["rhox"] = new XAQueryFieldInfo("float", rhox, rhox.ToString("000000000000.000000"), "로우", (decimal)12.6);
			dict["impv"] = new XAQueryFieldInfo("float", impv, impv.ToString("00000.00"), "내재변동성", (decimal)5.2);
			dict["egearing"] = new XAQueryFieldInfo("float", egearing, egearing.ToString("00000000.00"), "E.기어링", (decimal)8.2);
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)6);
			dict["elwclose"] = new XAQueryFieldInfo("long", elwclose, elwclose.ToString("d8"), "ELW현재가", (decimal)8);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "ELW전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("long", change, change.ToString("d8"), "ELW전일대비", (decimal)8);
			dict["date"] = new XAQueryFieldInfo("char", date, date, "일자", (decimal)8);
			dict["tickvalue"] = new XAQueryFieldInfo("float", tickvalue, tickvalue.ToString("0000000000.00"), "틱환산", (decimal)10.2);
			dict["lp_impv"] = new XAQueryFieldInfo("float", lp_impv, lp_impv.ToString("00000.00"), "LP내재변동성", (decimal)5.2);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "time":
					this.time = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "theoryprice":
					this.theoryprice = fieldInfo.FieldValue.ParseFloat("theoryprice");
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

				case "impv":
					this.impv = fieldInfo.FieldValue.ParseFloat("impv");
				break;

				case "egearing":
					this.egearing = fieldInfo.FieldValue.ParseFloat("egearing");
				break;

				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "elwclose":
					this.elwclose = fieldInfo.FieldValue.ParseLong("elwclose");
				break;

				case "sign":
					this.sign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "change":
					this.change = fieldInfo.FieldValue.ParseLong("change");
				break;

				case "date":
					this.date = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "tickvalue":
					this.tickvalue = fieldInfo.FieldValue.ParseFloat("tickvalue");
				break;

				case "lp_impv":
					this.lp_impv = fieldInfo.FieldValue.ParseFloat("lp_impv");
				break;


			}
		}

		public static XRESNOutBlock FromQuery(XRESN query)
		{
			XRESNOutBlock block = new XRESNOutBlock();
			block.IsValidData = true;
			block.InvalidReason = "";
			try
			{
				block.time = query.GetFieldData(block.GetBlockName(), "time").TrimEnd('?'); // char 6
				block.theoryprice = query.GetFieldData(block.GetBlockName(), "theoryprice").ParseFloat("theoryprice"); // float 10.2
				block.delt = query.GetFieldData(block.GetBlockName(), "delt").ParseFloat("delt"); // float 7.6
				block.gama = query.GetFieldData(block.GetBlockName(), "gama").ParseFloat("gama"); // float 7.6
				block.ceta = query.GetFieldData(block.GetBlockName(), "ceta").ParseFloat("ceta"); // float 12.6
				block.vega = query.GetFieldData(block.GetBlockName(), "vega").ParseFloat("vega"); // float 12.6
				block.rhox = query.GetFieldData(block.GetBlockName(), "rhox").ParseFloat("rhox"); // float 12.6
				block.impv = query.GetFieldData(block.GetBlockName(), "impv").ParseFloat("impv"); // float 5.2
				block.egearing = query.GetFieldData(block.GetBlockName(), "egearing").ParseFloat("egearing"); // float 8.2
				block.shcode = query.GetFieldData(block.GetBlockName(), "shcode").TrimEnd('?'); // char 6
				block.elwclose = query.GetFieldData(block.GetBlockName(), "elwclose").ParseLong("elwclose"); // long 8
				block.sign = query.GetFieldData(block.GetBlockName(), "sign").FirstOrDefault(); // char 1
				block.change = query.GetFieldData(block.GetBlockName(), "change").ParseLong("change"); // long 8
				block.date = query.GetFieldData(block.GetBlockName(), "date").TrimEnd('?'); // char 8
				block.tickvalue = query.GetFieldData(block.GetBlockName(), "tickvalue").ParseFloat("tickvalue"); // float 10.2
				block.lp_impv = query.GetFieldData(block.GetBlockName(), "lp_impv").ParseFloat("lp_impv"); // float 5.2

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (time?.Length > 6) return false; // char 6
			// theoryprice float 10.2
			// delt float 7.6
			// gama float 7.6
			// ceta float 12.6
			// vega float 12.6
			// rhox float 12.6
			// impv float 5.2
			// egearing float 8.2
			if (shcode?.Length > 6) return false; // char 6
			if (elwclose.ToString().Length > 8) return false; // long 8
			// sign char 1
			if (change.ToString().Length > 8) return false; // long 8
			if (date?.Length > 8) return false; // char 8
			// tickvalue float 10.2
			// lp_impv float 5.2

			return true;
		}
	}

	/// <summary>
	/// 뉴ELW투자지표민감도(ESN)
	/// </summary>
	public partial class XRESN : XingReal
	{
		/// <summary>
		/// ESN
		/// </summary>
		public const string _typeName = "ESN";
		/// <summary>
		/// 뉴ELW투자지표민감도(ESN)
		/// </summary>
		public const string _typeDesc = "뉴ELW투자지표민감도(ESN)";
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
		/// ESN
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 뉴ELW투자지표민감도(ESN)
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
		/// 뉴ELW투자지표민감도(ESN)
		/// </summary>
		public XRESN() : base("ESN") { }


		public bool SetBlock(XRESNInBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaReal.SetFieldData(block.GetBlockName(), "shcode", block.shcode); // char 6

			return true;
		}

		public XRESNOutBlock GetBlock()
		{
			XRESNOutBlock instance = XRESNOutBlock.FromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XRESNOutBlock),

		};

	}

}
