using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XRS4_InBlock : XingBlock
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
		[XAQueryFieldAttribute("단축코드")]
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

	public partial class XRS4_OutBlock : XingBlock
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
		public float drate;
		/// <summary>
		/// 현재가
		/// </summary>
		[XAQueryFieldAttribute("현재가")]
		public long price;
		/// <summary>
		/// 시가시간
		/// </summary>
		[XAQueryFieldAttribute("시가시간")]
		public string opentime;
		/// <summary>
		/// 시가
		/// </summary>
		[XAQueryFieldAttribute("시가")]
		public long open;
		/// <summary>
		/// 고가시간
		/// </summary>
		[XAQueryFieldAttribute("고가시간")]
		public string hightime;
		/// <summary>
		/// 고가
		/// </summary>
		[XAQueryFieldAttribute("고가")]
		public long high;
		/// <summary>
		/// 저가시간
		/// </summary>
		[XAQueryFieldAttribute("저가시간")]
		public string lowtime;
		/// <summary>
		/// 저가
		/// </summary>
		[XAQueryFieldAttribute("저가")]
		public long low;
		/// <summary>
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("단축코드")]
		public string shcode;

		public static class F
		{
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
			/// 단축코드
			/// </summary>
			public const string shcode = "shcode";
		}

		public static string[] AllFields = new string[]
		{
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
			F.shcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
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
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)6);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
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

				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XRS4_OutBlock FromQuery(XRS4_ query)
		{
			XRS4_OutBlock block = new XRS4_OutBlock();
			block.IsValidData = true;
			block.InvalidReason = "";
			try
			{
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
				block.shcode = query.GetFieldData(block.GetBlockName(), "shcode").TrimEnd('?'); // char 6

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
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
			if (shcode?.Length > 6) return false; // char 6

			return true;
		}
	}

	public partial class XRS4_ : XingReal
	{
		/// <summary>
		/// S4_
		/// </summary>
		public const string _typeName = "S4_";
		/// <summary>
		/// KOSPI기세(S4)
		/// </summary>
		public const string _typeDesc = "KOSPI기세(S4)";
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
		/// S4_
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// KOSPI기세(S4)
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

		public XRS4_() : base("S4_") { }


		public bool SetFields(XRS4_InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaReal.SetFieldData(block.GetBlockName(), "shcode", block.shcode); // char 6

			return true;
		}

		public XRS4_OutBlock GetBlock()
		{
			XRS4_OutBlock instance = XRS4_OutBlock.FromQuery(this);
			return instance;

		}


	}

}
