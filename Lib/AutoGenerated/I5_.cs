using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XRI5_InBlock : XingBlock
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

	public partial class XRI5_OutBlock : XingBlock
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
		/// 현재가
		/// </summary>
		[XAQueryFieldAttribute("현재가")]
		public long price;
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
		/// 누적거래량
		/// </summary>
		[XAQueryFieldAttribute("누적거래량")]
		public float volume;
		/// <summary>
		/// NAV대비
		/// </summary>
		[XAQueryFieldAttribute("NAV대비")]
		public float navdiff;
		/// <summary>
		/// NAV
		/// </summary>
		[XAQueryFieldAttribute("NAV")]
		public float nav;
		/// <summary>
		/// 전일대비
		/// </summary>
		[XAQueryFieldAttribute("전일대비")]
		public float navchange;
		/// <summary>
		/// 추적오차
		/// </summary>
		[XAQueryFieldAttribute("추적오차")]
		public float crate;
		/// <summary>
		/// 괴리
		/// </summary>
		[XAQueryFieldAttribute("괴리")]
		public float grate;
		/// <summary>
		/// 지수
		/// </summary>
		[XAQueryFieldAttribute("지수")]
		public float jisu;
		/// <summary>
		/// 전일대비
		/// </summary>
		[XAQueryFieldAttribute("전일대비")]
		public float jichange;
		/// <summary>
		/// 전일대비율
		/// </summary>
		[XAQueryFieldAttribute("전일대비율")]
		public float jirate;
		/// <summary>
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("단축코드")]
		public string shcode;

		public static class F
		{
			/// <summary>
			/// 시간
			/// </summary>
			public const string time = "time";
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
			/// 누적거래량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// NAV대비
			/// </summary>
			public const string navdiff = "navdiff";
			/// <summary>
			/// NAV
			/// </summary>
			public const string nav = "nav";
			/// <summary>
			/// 전일대비
			/// </summary>
			public const string navchange = "navchange";
			/// <summary>
			/// 추적오차
			/// </summary>
			public const string crate = "crate";
			/// <summary>
			/// 괴리
			/// </summary>
			public const string grate = "grate";
			/// <summary>
			/// 지수
			/// </summary>
			public const string jisu = "jisu";
			/// <summary>
			/// 전일대비
			/// </summary>
			public const string jichange = "jichange";
			/// <summary>
			/// 전일대비율
			/// </summary>
			public const string jirate = "jirate";
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string shcode = "shcode";
		}

		public static string[] AllFields = new string[]
		{
			F.time,
			F.price,
			F.sign,
			F.change,
			F.volume,
			F.navdiff,
			F.nav,
			F.navchange,
			F.crate,
			F.grate,
			F.jisu,
			F.jichange,
			F.jirate,
			F.shcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["time"] = new XAQueryFieldInfo("char", time, time, "시간", (decimal)8);
			dict["price"] = new XAQueryFieldInfo("long", price, price.ToString("d8"), "현재가", (decimal)8);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("long", change, change.ToString("d8"), "전일대비", (decimal)8);
			dict["volume"] = new XAQueryFieldInfo("float", volume, volume.ToString("000000000000"), "누적거래량", (decimal)12);
			dict["navdiff"] = new XAQueryFieldInfo("float", navdiff, navdiff.ToString("000000000.00"), "NAV대비", (decimal)9.2);
			dict["nav"] = new XAQueryFieldInfo("float", nav, nav.ToString("000000000.00"), "NAV", (decimal)9.2);
			dict["navchange"] = new XAQueryFieldInfo("float", navchange, navchange.ToString("000000000.00"), "전일대비", (decimal)9.2);
			dict["crate"] = new XAQueryFieldInfo("float", crate, crate.ToString("000000000.00"), "추적오차", (decimal)9.2);
			dict["grate"] = new XAQueryFieldInfo("float", grate, grate.ToString("000000000.00"), "괴리", (decimal)9.2);
			dict["jisu"] = new XAQueryFieldInfo("float", jisu, jisu.ToString("00000000.00"), "지수", (decimal)8.2);
			dict["jichange"] = new XAQueryFieldInfo("float", jichange, jichange.ToString("00000000.00"), "전일대비", (decimal)8.2);
			dict["jirate"] = new XAQueryFieldInfo("float", jirate, jirate.ToString("00000000.00"), "전일대비율", (decimal)8.2);
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)6);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "time":
					this.time = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "price":
					this.price = fieldInfo.FieldValue.ParseLong("price");
				break;

				case "sign":
					this.sign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "change":
					this.change = fieldInfo.FieldValue.ParseLong("change");
				break;

				case "volume":
					this.volume = fieldInfo.FieldValue.ParseFloat("volume");
				break;

				case "navdiff":
					this.navdiff = fieldInfo.FieldValue.ParseFloat("navdiff");
				break;

				case "nav":
					this.nav = fieldInfo.FieldValue.ParseFloat("nav");
				break;

				case "navchange":
					this.navchange = fieldInfo.FieldValue.ParseFloat("navchange");
				break;

				case "crate":
					this.crate = fieldInfo.FieldValue.ParseFloat("crate");
				break;

				case "grate":
					this.grate = fieldInfo.FieldValue.ParseFloat("grate");
				break;

				case "jisu":
					this.jisu = fieldInfo.FieldValue.ParseFloat("jisu");
				break;

				case "jichange":
					this.jichange = fieldInfo.FieldValue.ParseFloat("jichange");
				break;

				case "jirate":
					this.jirate = fieldInfo.FieldValue.ParseFloat("jirate");
				break;

				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XRI5_OutBlock FromQuery(XRI5_ query)
		{
			XRI5_OutBlock block = new XRI5_OutBlock();
			block.IsValidData = true;
			block.InvalidReason = "";
			try
			{
				block.time = query.GetFieldData(block.GetBlockName(), "time").TrimEnd('?'); // char 8
				block.price = query.GetFieldData(block.GetBlockName(), "price").ParseLong("price"); // long 8
				block.sign = query.GetFieldData(block.GetBlockName(), "sign").FirstOrDefault(); // char 1
				block.change = query.GetFieldData(block.GetBlockName(), "change").ParseLong("change"); // long 8
				block.volume = query.GetFieldData(block.GetBlockName(), "volume").ParseFloat("volume"); // float 12
				block.navdiff = query.GetFieldData(block.GetBlockName(), "navdiff").ParseFloat("navdiff"); // float 9.2
				block.nav = query.GetFieldData(block.GetBlockName(), "nav").ParseFloat("nav"); // float 9.2
				block.navchange = query.GetFieldData(block.GetBlockName(), "navchange").ParseFloat("navchange"); // float 9.2
				block.crate = query.GetFieldData(block.GetBlockName(), "crate").ParseFloat("crate"); // float 9.2
				block.grate = query.GetFieldData(block.GetBlockName(), "grate").ParseFloat("grate"); // float 9.2
				block.jisu = query.GetFieldData(block.GetBlockName(), "jisu").ParseFloat("jisu"); // float 8.2
				block.jichange = query.GetFieldData(block.GetBlockName(), "jichange").ParseFloat("jichange"); // float 8.2
				block.jirate = query.GetFieldData(block.GetBlockName(), "jirate").ParseFloat("jirate"); // float 8.2
				block.shcode = query.GetFieldData(block.GetBlockName(), "shcode").TrimEnd('?'); // char 6

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (time?.Length > 8) return false; // char 8
			if (price.ToString().Length > 8) return false; // long 8
			// sign char 1
			if (change.ToString().Length > 8) return false; // long 8
			// volume float 12
			// navdiff float 9.2
			// nav float 9.2
			// navchange float 9.2
			// crate float 9.2
			// grate float 9.2
			// jisu float 8.2
			// jichange float 8.2
			// jirate float 8.2
			if (shcode?.Length > 6) return false; // char 6

			return true;
		}
	}

	public partial class XRI5_ : XingReal
	{
		/// <summary>
		/// I5_
		/// </summary>
		public const string _typeName = "I5_";
		/// <summary>
		/// 코스피ETF종목실시간NAV(I5)
		/// </summary>
		public const string _typeDesc = "코스피ETF종목실시간NAV(I5)";
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
		/// I5_
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 코스피ETF종목실시간NAV(I5)
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

		public XRI5_() : base("I5_") { }


		public bool SetFields(XRI5_InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaReal.SetFieldData(block.GetBlockName(), "shcode", block.shcode); // char 6

			return true;
		}

		public XRI5_OutBlock GetBlock()
		{
			XRI5_OutBlock instance = XRI5_OutBlock.FromQuery(this);
			return instance;

		}


	}

}
