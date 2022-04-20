using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XRYS3InBlock : XingBlock
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

		public void CopyTo(XRYS3InBlock block)
		{
			block.shcode = this.shcode;

		}
	}

	public partial class XRYS3OutBlock : XingBlock
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
		/// 호가시간
		/// </summary>
		[XAQueryFieldAttribute("hotime", "호가시간", "char", "6")]
		public string hotime;
		/// <summary>
		/// 예상체결가격
		/// </summary>
		[XAQueryFieldAttribute("yeprice", "예상체결가격", "long", "8")]
		public long yeprice;
		/// <summary>
		/// 예상체결수량
		/// </summary>
		[XAQueryFieldAttribute("yevolume", "예상체결수량", "long", "12")]
		public long yevolume;
		/// <summary>
		/// 예상체결가전일종가대비구분
		/// </summary>
		[XAQueryFieldAttribute("jnilysign", "예상체결가전일종가대비구분", "char", "1")]
		public char jnilysign;
		/// <summary>
		/// 예상체결가전일종가대비
		/// </summary>
		[XAQueryFieldAttribute("preychange", "예상체결가전일종가대비", "long", "8")]
		public long preychange;
		/// <summary>
		/// 예상체결가전일종가등락율
		/// </summary>
		[XAQueryFieldAttribute("jnilydrate", "예상체결가전일종가등락율", "float", "6.2")]
		public float jnilydrate;
		/// <summary>
		/// 예상매도호가
		/// </summary>
		[XAQueryFieldAttribute("yofferho0", "예상매도호가", "long", "8")]
		public long yofferho0;
		/// <summary>
		/// 예상매수호가
		/// </summary>
		[XAQueryFieldAttribute("ybidho0", "예상매수호가", "long", "8")]
		public long ybidho0;
		/// <summary>
		/// 예상매도호가수량
		/// </summary>
		[XAQueryFieldAttribute("yofferrem0", "예상매도호가수량", "long", "12")]
		public long yofferrem0;
		/// <summary>
		/// 예상매수호가수량
		/// </summary>
		[XAQueryFieldAttribute("ybidrem0", "예상매수호가수량", "long", "12")]
		public long ybidrem0;
		/// <summary>
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("shcode", "단축코드", "char", "6")]
		public string shcode;

		public static class F
		{
			/// <summary>
			/// 호가시간
			/// </summary>
			public const string hotime = "hotime";
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
			/// 예상매도호가
			/// </summary>
			public const string yofferho0 = "yofferho0";
			/// <summary>
			/// 예상매수호가
			/// </summary>
			public const string ybidho0 = "ybidho0";
			/// <summary>
			/// 예상매도호가수량
			/// </summary>
			public const string yofferrem0 = "yofferrem0";
			/// <summary>
			/// 예상매수호가수량
			/// </summary>
			public const string ybidrem0 = "ybidrem0";
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string shcode = "shcode";
		}

		public static string[] AllFields = new string[]
		{
			F.hotime,
			F.yeprice,
			F.yevolume,
			F.jnilysign,
			F.preychange,
			F.jnilydrate,
			F.yofferho0,
			F.ybidho0,
			F.yofferrem0,
			F.ybidrem0,
			F.shcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["hotime"] = new XAQueryFieldInfo("char", hotime, hotime, "호가시간", (decimal)6);
			dict["yeprice"] = new XAQueryFieldInfo("long", yeprice, yeprice.ToString("d8"), "예상체결가격", (decimal)8);
			dict["yevolume"] = new XAQueryFieldInfo("long", yevolume, yevolume.ToString("d12"), "예상체결수량", (decimal)12);
			dict["jnilysign"] = new XAQueryFieldInfo("char", jnilysign, jnilysign.ToString(), "예상체결가전일종가대비구분", (decimal)1);
			dict["preychange"] = new XAQueryFieldInfo("long", preychange, preychange.ToString("d8"), "예상체결가전일종가대비", (decimal)8);
			dict["jnilydrate"] = new XAQueryFieldInfo("float", jnilydrate, jnilydrate.ToString("000000.00"), "예상체결가전일종가등락율", (decimal)6.2);
			dict["yofferho0"] = new XAQueryFieldInfo("long", yofferho0, yofferho0.ToString("d8"), "예상매도호가", (decimal)8);
			dict["ybidho0"] = new XAQueryFieldInfo("long", ybidho0, ybidho0.ToString("d8"), "예상매수호가", (decimal)8);
			dict["yofferrem0"] = new XAQueryFieldInfo("long", yofferrem0, yofferrem0.ToString("d12"), "예상매도호가수량", (decimal)12);
			dict["ybidrem0"] = new XAQueryFieldInfo("long", ybidrem0, ybidrem0.ToString("d12"), "예상매수호가수량", (decimal)12);
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)6);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "hotime":
					this.hotime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "yeprice":
					this.yeprice = fieldInfo.FieldValue.ParseLong("yeprice");
				break;

				case "yevolume":
					this.yevolume = fieldInfo.FieldValue.ParseLong("yevolume");
				break;

				case "jnilysign":
					this.jnilysign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "preychange":
					this.preychange = fieldInfo.FieldValue.ParseLong("preychange");
				break;

				case "jnilydrate":
					this.jnilydrate = fieldInfo.FieldValue.ParseFloat("jnilydrate");
				break;

				case "yofferho0":
					this.yofferho0 = fieldInfo.FieldValue.ParseLong("yofferho0");
				break;

				case "ybidho0":
					this.ybidho0 = fieldInfo.FieldValue.ParseLong("ybidho0");
				break;

				case "yofferrem0":
					this.yofferrem0 = fieldInfo.FieldValue.ParseLong("yofferrem0");
				break;

				case "ybidrem0":
					this.ybidrem0 = fieldInfo.FieldValue.ParseLong("ybidrem0");
				break;

				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XRYS3OutBlock FromQuery(XRYS3 query)
		{
			XRYS3OutBlock block = new XRYS3OutBlock();
			block.IsValidData = true;
			block.InvalidReason = "";
			try
			{
				block.hotime = query.GetFieldData(block.GetBlockName(), "hotime").TrimEnd('?'); // char 6
				block.yeprice = query.GetFieldData(block.GetBlockName(), "yeprice").ParseLong("yeprice"); // long 8
				block.yevolume = query.GetFieldData(block.GetBlockName(), "yevolume").ParseLong("yevolume"); // long 12
				block.jnilysign = query.GetFieldData(block.GetBlockName(), "jnilysign").FirstOrDefault(); // char 1
				block.preychange = query.GetFieldData(block.GetBlockName(), "preychange").ParseLong("preychange"); // long 8
				block.jnilydrate = query.GetFieldData(block.GetBlockName(), "jnilydrate").ParseFloat("jnilydrate"); // float 6.2
				block.yofferho0 = query.GetFieldData(block.GetBlockName(), "yofferho0").ParseLong("yofferho0"); // long 8
				block.ybidho0 = query.GetFieldData(block.GetBlockName(), "ybidho0").ParseLong("ybidho0"); // long 8
				block.yofferrem0 = query.GetFieldData(block.GetBlockName(), "yofferrem0").ParseLong("yofferrem0"); // long 12
				block.ybidrem0 = query.GetFieldData(block.GetBlockName(), "ybidrem0").ParseLong("ybidrem0"); // long 12
				block.shcode = query.GetFieldData(block.GetBlockName(), "shcode").TrimEnd('?'); // char 6

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (hotime?.Length > 6) return false; // char 6
			if (yeprice.ToString().Length > 8) return false; // long 8
			if (yevolume.ToString().Length > 12) return false; // long 12
			// jnilysign char 1
			if (preychange.ToString().Length > 8) return false; // long 8
			// jnilydrate float 6.2
			if (yofferho0.ToString().Length > 8) return false; // long 8
			if (ybidho0.ToString().Length > 8) return false; // long 8
			if (yofferrem0.ToString().Length > 12) return false; // long 12
			if (ybidrem0.ToString().Length > 12) return false; // long 12
			if (shcode?.Length > 6) return false; // char 6

			return true;
		}

		public void CopyTo(XRYS3OutBlock block)
		{
			block.hotime = this.hotime;
			block.yeprice = this.yeprice;
			block.yevolume = this.yevolume;
			block.jnilysign = this.jnilysign;
			block.preychange = this.preychange;
			block.jnilydrate = this.jnilydrate;
			block.yofferho0 = this.yofferho0;
			block.ybidho0 = this.ybidho0;
			block.yofferrem0 = this.yofferrem0;
			block.ybidrem0 = this.ybidrem0;
			block.shcode = this.shcode;

		}
	}

	/// <summary>
	/// KOSPI예상체결(YS3)
	/// </summary>
	public partial class XRYS3 : XingReal
	{
		/// <summary>
		/// YS3
		/// </summary>
		public const string _typeName = "YS3";
		/// <summary>
		/// KOSPI예상체결(YS3)
		/// </summary>
		public const string _typeDesc = "KOSPI예상체결(YS3)";
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
		/// YS3
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// KOSPI예상체결(YS3)
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
		/// KOSPI예상체결(YS3)
		/// </summary>
		public XRYS3() : base("YS3") { }


		public bool SetBlock(XRYS3InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaReal.SetFieldData(block.GetBlockName(), "shcode", block.shcode); // char 6

			return true;
		}

		public XRYS3OutBlock GetBlock()
		{
			XRYS3OutBlock instance = XRYS3OutBlock.FromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XRYS3OutBlock),

		};

	}

}
