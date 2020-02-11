using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XRYOCInBlock : XingBlock
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
		[XAQueryFieldAttribute("optcode", "단축코드", "char", "8")]
		public string optcode;

		public static class F
		{
			/// <summary>
			/// 단축코드
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
			dict["optcode"] = new XAQueryFieldInfo("char", optcode, optcode, "단축코드", (decimal)8);

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
	}

	public partial class XRYOCOutBlock : XingBlock
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
		[XAQueryFieldAttribute("yeprice", "예상체결가격", "float", "6.2")]
		public float yeprice;
		/// <summary>
		/// 예상체결가전일종가대비구분
		/// </summary>
		[XAQueryFieldAttribute("jnilysign", "예상체결가전일종가대비구분", "char", "1")]
		public char jnilysign;
		/// <summary>
		/// 예상체결가전일종가대비
		/// </summary>
		[XAQueryFieldAttribute("preychange", "예상체결가전일종가대비", "float", "6.2")]
		public float preychange;
		/// <summary>
		/// 예상체결가전일종가등락율
		/// </summary>
		[XAQueryFieldAttribute("jnilydrate", "예상체결가전일종가등락율", "float", "6.2")]
		public float jnilydrate;
		/// <summary>
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("optcode", "단축코드", "char", "8")]
		public string optcode;

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
			public const string optcode = "optcode";
		}

		public static string[] AllFields = new string[]
		{
			F.ychetime,
			F.yeprice,
			F.jnilysign,
			F.preychange,
			F.jnilydrate,
			F.optcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["ychetime"] = new XAQueryFieldInfo("char", ychetime, ychetime, "예상체결시간", (decimal)6);
			dict["yeprice"] = new XAQueryFieldInfo("float", yeprice, yeprice.ToString("000000.00"), "예상체결가격", (decimal)6.2);
			dict["jnilysign"] = new XAQueryFieldInfo("char", jnilysign, jnilysign.ToString(), "예상체결가전일종가대비구분", (decimal)1);
			dict["preychange"] = new XAQueryFieldInfo("float", preychange, preychange.ToString("000000.00"), "예상체결가전일종가대비", (decimal)6.2);
			dict["jnilydrate"] = new XAQueryFieldInfo("float", jnilydrate, jnilydrate.ToString("000000.00"), "예상체결가전일종가등락율", (decimal)6.2);
			dict["optcode"] = new XAQueryFieldInfo("char", optcode, optcode, "단축코드", (decimal)8);

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

				case "jnilysign":
					this.jnilysign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "preychange":
					this.preychange = fieldInfo.FieldValue.ParseFloat("preychange");
				break;

				case "jnilydrate":
					this.jnilydrate = fieldInfo.FieldValue.ParseFloat("jnilydrate");
				break;

				case "optcode":
					this.optcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XRYOCOutBlock FromQuery(XRYOC query)
		{
			XRYOCOutBlock block = new XRYOCOutBlock();
			block.IsValidData = true;
			block.InvalidReason = "";
			try
			{
				block.ychetime = query.GetFieldData(block.GetBlockName(), "ychetime").TrimEnd('?'); // char 6
				block.yeprice = query.GetFieldData(block.GetBlockName(), "yeprice").ParseFloat("yeprice"); // float 6.2
				block.jnilysign = query.GetFieldData(block.GetBlockName(), "jnilysign").FirstOrDefault(); // char 1
				block.preychange = query.GetFieldData(block.GetBlockName(), "preychange").ParseFloat("preychange"); // float 6.2
				block.jnilydrate = query.GetFieldData(block.GetBlockName(), "jnilydrate").ParseFloat("jnilydrate"); // float 6.2
				block.optcode = query.GetFieldData(block.GetBlockName(), "optcode").TrimEnd('?'); // char 8

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (ychetime?.Length > 6) return false; // char 6
			// yeprice float 6.2
			// jnilysign char 1
			// preychange float 6.2
			// jnilydrate float 6.2
			if (optcode?.Length > 8) return false; // char 8

			return true;
		}
	}

	/// <summary>
	/// 지수옵션예상체결(YOC)
	/// </summary>
	public partial class XRYOC : XingReal
	{
		/// <summary>
		/// YOC
		/// </summary>
		public const string _typeName = "YOC";
		/// <summary>
		/// 지수옵션예상체결(YOC)
		/// </summary>
		public const string _typeDesc = "지수옵션예상체결(YOC)";
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
		/// YOC
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 지수옵션예상체결(YOC)
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
		/// 지수옵션예상체결(YOC)
		/// </summary>
		public XRYOC() : base("YOC") { }


		public bool SetBlock(XRYOCInBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaReal.SetFieldData(block.GetBlockName(), "optcode", block.optcode); // char 8

			return true;
		}

		public XRYOCOutBlock GetBlock()
		{
			XRYOCOutBlock instance = XRYOCOutBlock.FromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XRYOCOutBlock),

		};

	}

}
