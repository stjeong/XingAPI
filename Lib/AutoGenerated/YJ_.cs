using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XRYJ_InBlock : XingBlock
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
		[XAQueryFieldAttribute("업종코드")]
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

	public partial class XRYJ_OutBlock : XingBlock
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
		[XAQueryFieldAttribute("시간")]
		public string time;
		/// <summary>
		/// 예상지수
		/// </summary>
		[XAQueryFieldAttribute("예상지수")]
		public float jisu;
		/// <summary>
		/// 예상전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("예상전일대비구분")]
		public char sign;
		/// <summary>
		/// 예상전일비
		/// </summary>
		[XAQueryFieldAttribute("예상전일비")]
		public float change;
		/// <summary>
		/// 예상등락율
		/// </summary>
		[XAQueryFieldAttribute("예상등락율")]
		public float drate;
		/// <summary>
		/// 예상체결량
		/// </summary>
		[XAQueryFieldAttribute("예상체결량")]
		public long cvolume;
		/// <summary>
		/// 누적거래량
		/// </summary>
		[XAQueryFieldAttribute("누적거래량")]
		public long volume;
		/// <summary>
		/// 예상거래대금
		/// </summary>
		[XAQueryFieldAttribute("예상거래대금")]
		public long value;
		/// <summary>
		/// 업종코드
		/// </summary>
		[XAQueryFieldAttribute("업종코드")]
		public string upcode;

		public static class F
		{
			/// <summary>
			/// 시간
			/// </summary>
			public const string time = "time";
			/// <summary>
			/// 예상지수
			/// </summary>
			public const string jisu = "jisu";
			/// <summary>
			/// 예상전일대비구분
			/// </summary>
			public const string sign = "sign";
			/// <summary>
			/// 예상전일비
			/// </summary>
			public const string change = "change";
			/// <summary>
			/// 예상등락율
			/// </summary>
			public const string drate = "drate";
			/// <summary>
			/// 예상체결량
			/// </summary>
			public const string cvolume = "cvolume";
			/// <summary>
			/// 누적거래량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// 예상거래대금
			/// </summary>
			public const string value = "value";
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
			F.upcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["time"] = new XAQueryFieldInfo("char", time, time, "시간", (decimal)6);
			dict["jisu"] = new XAQueryFieldInfo("float", jisu, jisu.ToString("00000000.00"), "예상지수", (decimal)8.2);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "예상전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("float", change, change.ToString("00000000.00"), "예상전일비", (decimal)8.2);
			dict["drate"] = new XAQueryFieldInfo("float", drate, drate.ToString("000000.00"), "예상등락율", (decimal)6.2);
			dict["cvolume"] = new XAQueryFieldInfo("long", cvolume, cvolume.ToString("d8"), "예상체결량", (decimal)8);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d8"), "누적거래량", (decimal)8);
			dict["value"] = new XAQueryFieldInfo("long", value, value.ToString("d8"), "예상거래대금", (decimal)8);
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

				case "upcode":
					this.upcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XRYJ_OutBlock FromQuery(XRYJ_ query)
		{
			XRYJ_OutBlock block = new XRYJ_OutBlock();
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
			if (upcode?.Length > 3) return false; // char 3

			return true;
		}
	}

	/// <summary>
	/// 예상지수(YJ)
	/// </summary>
	public partial class XRYJ_ : XingReal
	{
		/// <summary>
		/// YJ_
		/// </summary>
		public const string _typeName = "YJ_";
		/// <summary>
		/// 예상지수(YJ)
		/// </summary>
		public const string _typeDesc = "예상지수(YJ)";
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
		/// YJ_
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 예상지수(YJ)
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
		/// 예상지수(YJ)
		/// </summary>
		public XRYJ_() : base("YJ_") { }


		public bool SetBlock(XRYJ_InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaReal.SetFieldData(block.GetBlockName(), "upcode", block.upcode); // char 3

			return true;
		}

		public XRYJ_OutBlock GetBlock()
		{
			XRYJ_OutBlock instance = XRYJ_OutBlock.FromQuery(this);
			return instance;

		}


	}

}
