using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XRYC3InBlock : XingBlock
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
		[XAQueryFieldAttribute("shcode", "단축코드", "char", "8")]
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
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)8);

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
			if (shcode?.Length > 8) return false; // char 8

			return true;
		}
	}

	public partial class XRYC3OutBlock : XingBlock
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
		/// 예상체결시간
		/// </summary>
		[XAQueryFieldAttribute("ychetime", "예상체결시간", "char", "6")]
		public string ychetime;
		/// <summary>
		/// 예상체결가격
		/// </summary>
		[XAQueryFieldAttribute("yeprice", "예상체결가격", "float", "9.2")]
		public float yeprice;
		/// <summary>
		/// 예상체결수량
		/// </summary>
		[XAQueryFieldAttribute("yevolume", "예상체결수량", "long", "6")]
		public long yevolume;
		/// <summary>
		/// 예상체결가전일종가대비구분
		/// </summary>
		[XAQueryFieldAttribute("jnilysign", "예상체결가전일종가대비구분", "char", "1")]
		public char jnilysign;
		/// <summary>
		/// 예상체결가전일종가대비
		/// </summary>
		[XAQueryFieldAttribute("preychange", "예상체결가전일종가대비", "float", "9.2")]
		public float preychange;
		/// <summary>
		/// 예상체결가전일종가등락율
		/// </summary>
		[XAQueryFieldAttribute("jnilydrate", "예상체결가전일종가등락율", "float", "9.2")]
		public float jnilydrate;
		/// <summary>
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("shcode", "단축코드", "char", "8")]
		public string shcode;

		public static class F
		{
			/// <summary>
			/// 예상체결시간
			/// </summary>
			public const string ychetime = "ychetime";
			/// <summary>
			/// 예상체결가격
			/// </summary>
			public const string yeprice = "yeprice";
			/// <summary>
			/// 예상체결수량
			/// </summary>
			public const string yevolume = "yevolume";
			/// <summary>
			/// 예상체결가전일종가대비구분
			/// </summary>
			public const string jnilysign = "jnilysign";
			/// <summary>
			/// 예상체결가전일종가대비
			/// </summary>
			public const string preychange = "preychange";
			/// <summary>
			/// 예상체결가전일종가등락율
			/// </summary>
			public const string jnilydrate = "jnilydrate";
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string shcode = "shcode";
		}

		public static string[] AllFields = new string[]
		{
			F.ychetime,
			F.yeprice,
			F.yevolume,
			F.jnilysign,
			F.preychange,
			F.jnilydrate,
			F.shcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["ychetime"] = new XAQueryFieldInfo("char", ychetime, ychetime, "예상체결시간", (decimal)6);
			dict["yeprice"] = new XAQueryFieldInfo("float", yeprice, yeprice.ToString("000000000.00"), "예상체결가격", (decimal)9.2);
			dict["yevolume"] = new XAQueryFieldInfo("long", yevolume, yevolume.ToString("d6"), "예상체결수량", (decimal)6);
			dict["jnilysign"] = new XAQueryFieldInfo("char", jnilysign, jnilysign.ToString(), "예상체결가전일종가대비구분", (decimal)1);
			dict["preychange"] = new XAQueryFieldInfo("float", preychange, preychange.ToString("000000000.00"), "예상체결가전일종가대비", (decimal)9.2);
			dict["jnilydrate"] = new XAQueryFieldInfo("float", jnilydrate, jnilydrate.ToString("000000000.00"), "예상체결가전일종가등락율", (decimal)9.2);
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)8);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "ychetime":
					this.ychetime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "yeprice":
					this.yeprice = fieldInfo.FieldValue.ParseFloat("yeprice");
				break;

				case "yevolume":
					this.yevolume = fieldInfo.FieldValue.ParseLong("yevolume");
				break;

				case "jnilysign":
					this.jnilysign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "preychange":
					this.preychange = fieldInfo.FieldValue.ParseFloat("preychange");
				break;

				case "jnilydrate":
					this.jnilydrate = fieldInfo.FieldValue.ParseFloat("jnilydrate");
				break;

				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XRYC3OutBlock FromQuery(XRYC3 query)
		{
			XRYC3OutBlock block = new XRYC3OutBlock();
			block.IsValidData = true;
			block.InvalidReason = "";
			try
			{
				block.ychetime = query.GetFieldData(block.GetBlockName(), "ychetime").TrimEnd('?'); // char 6
				block.yeprice = query.GetFieldData(block.GetBlockName(), "yeprice").ParseFloat("yeprice"); // float 9.2
				block.yevolume = query.GetFieldData(block.GetBlockName(), "yevolume").ParseLong("yevolume"); // long 6
				block.jnilysign = query.GetFieldData(block.GetBlockName(), "jnilysign").FirstOrDefault(); // char 1
				block.preychange = query.GetFieldData(block.GetBlockName(), "preychange").ParseFloat("preychange"); // float 9.2
				block.jnilydrate = query.GetFieldData(block.GetBlockName(), "jnilydrate").ParseFloat("jnilydrate"); // float 9.2
				block.shcode = query.GetFieldData(block.GetBlockName(), "shcode").TrimEnd('?'); // char 8

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (ychetime?.Length > 6) return false; // char 6
			// yeprice float 9.2
			if (yevolume.ToString().Length > 6) return false; // long 6
			// jnilysign char 1
			// preychange float 9.2
			// jnilydrate float 9.2
			if (shcode?.Length > 8) return false; // char 8

			return true;
		}
	}

	/// <summary>
	/// 상품선물예상체결(YC3)
	/// </summary>
	public partial class XRYC3 : XingReal
	{
		/// <summary>
		/// YC3
		/// </summary>
		public const string _typeName = "YC3";
		/// <summary>
		/// 상품선물예상체결(YC3)
		/// </summary>
		public const string _typeDesc = "상품선물예상체결(YC3)";
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
		/// YC3
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 상품선물예상체결(YC3)
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
		/// 상품선물예상체결(YC3)
		/// </summary>
		public XRYC3() : base("YC3") { }


		public bool SetBlock(XRYC3InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaReal.SetFieldData(block.GetBlockName(), "shcode", block.shcode); // char 8

			return true;
		}

		public XRYC3OutBlock GetBlock()
		{
			XRYC3OutBlock instance = XRYC3OutBlock.FromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XRYC3OutBlock),

		};

	}

}
