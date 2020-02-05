using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XRYFCInBlock : XingBlock
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
		public string futcode;

		public static class F
		{
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string futcode = "futcode";
		}

		public static string[] AllFields = new string[]
		{
			F.futcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["futcode"] = new XAQueryFieldInfo("char", futcode, futcode, "단축코드", (decimal)8);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "futcode":
					this.futcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (futcode?.Length > 8) return false; // char 8

			return true;
		}
	}

	public partial class XRYFCOutBlock : XingBlock
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
		[XAQueryFieldAttribute("예상체결시간")]
		public string ychetime;
		/// <summary>
		/// 예상체결가격
		/// </summary>
		[XAQueryFieldAttribute("예상체결가격")]
		public float yeprice;
		/// <summary>
		/// 예상체결가전일종가대비구분
		/// </summary>
		[XAQueryFieldAttribute("예상체결가전일종가대비구분")]
		public char jnilysign;
		/// <summary>
		/// 예상체결가전일종가대비
		/// </summary>
		[XAQueryFieldAttribute("예상체결가전일종가대비")]
		public float preychange;
		/// <summary>
		/// 예상체결가전일종가등락율
		/// </summary>
		[XAQueryFieldAttribute("예상체결가전일종가등락율")]
		public float jnilydrate;
		/// <summary>
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("단축코드")]
		public string futcode;

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
			public const string futcode = "futcode";
		}

		public static string[] AllFields = new string[]
		{
			F.ychetime,
			F.yeprice,
			F.jnilysign,
			F.preychange,
			F.jnilydrate,
			F.futcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["ychetime"] = new XAQueryFieldInfo("char", ychetime, ychetime, "예상체결시간", (decimal)6);
			dict["yeprice"] = new XAQueryFieldInfo("float", yeprice, yeprice.ToString("000000.00"), "예상체결가격", (decimal)6.2);
			dict["jnilysign"] = new XAQueryFieldInfo("char", jnilysign, jnilysign.ToString(), "예상체결가전일종가대비구분", (decimal)1);
			dict["preychange"] = new XAQueryFieldInfo("float", preychange, preychange.ToString("000000.00"), "예상체결가전일종가대비", (decimal)6.2);
			dict["jnilydrate"] = new XAQueryFieldInfo("float", jnilydrate, jnilydrate.ToString("000000.00"), "예상체결가전일종가등락율", (decimal)6.2);
			dict["futcode"] = new XAQueryFieldInfo("char", futcode, futcode, "단축코드", (decimal)8);

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

				case "futcode":
					this.futcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XRYFCOutBlock FromQuery(XRYFC query)
		{
			XRYFCOutBlock block = new XRYFCOutBlock();
			block.IsValidData = true;
			block.InvalidReason = "";
			try
			{
				block.ychetime = query.GetFieldData(block.GetBlockName(), "ychetime").TrimEnd('?'); // char 6
				block.yeprice = query.GetFieldData(block.GetBlockName(), "yeprice").ParseFloat("yeprice"); // float 6.2
				block.jnilysign = query.GetFieldData(block.GetBlockName(), "jnilysign").FirstOrDefault(); // char 1
				block.preychange = query.GetFieldData(block.GetBlockName(), "preychange").ParseFloat("preychange"); // float 6.2
				block.jnilydrate = query.GetFieldData(block.GetBlockName(), "jnilydrate").ParseFloat("jnilydrate"); // float 6.2
				block.futcode = query.GetFieldData(block.GetBlockName(), "futcode").TrimEnd('?'); // char 8

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
			if (futcode?.Length > 8) return false; // char 8

			return true;
		}
	}

	public partial class XRYFC : XingReal
	{
		/// <summary>
		/// YFC
		/// </summary>
		public const string _typeName = "YFC";
		/// <summary>
		/// 지수선물예상체결(YFC)
		/// </summary>
		public const string _typeDesc = "지수선물예상체결(YFC)";
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
		/// YFC
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 지수선물예상체결(YFC)
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

		public XRYFC() : base("YFC") { }


		public bool SetBlock(XRYFCInBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaReal.SetFieldData(block.GetBlockName(), "futcode", block.futcode); // char 8

			return true;
		}

		public XRYFCOutBlock GetBlock()
		{
			XRYFCOutBlock instance = XRYFCOutBlock.FromQuery(this);
			return instance;

		}


	}

}
