using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XRFX0InBlock : XingBlock
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
		[XAQueryFieldAttribute("단축코드", "8")]
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

	public partial class XRFX0OutBlock : XingBlock
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
		/// 적용 상한단계
		/// </summary>
		[XAQueryFieldAttribute("적용 상한단계", "2")]
		public string upstep;
		/// <summary>
		/// 적용 하한단계
		/// </summary>
		[XAQueryFieldAttribute("적용 하한단계", "2")]
		public string dnstep;
		/// <summary>
		/// 적용 상한가
		/// </summary>
		[XAQueryFieldAttribute("적용 상한가", "6.2")]
		public float uplmtprice;
		/// <summary>
		/// 적용 하한가
		/// </summary>
		[XAQueryFieldAttribute("적용 하한가", "6.2")]
		public float dnlmtprice;
		/// <summary>
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("단축코드", "8")]
		public string futcode;

		public static class F
		{
			/// <summary>
			/// 적용 상한단계
			/// </summary>
			public const string upstep = "upstep";
			/// <summary>
			/// 적용 하한단계
			/// </summary>
			public const string dnstep = "dnstep";
			/// <summary>
			/// 적용 상한가
			/// </summary>
			public const string uplmtprice = "uplmtprice";
			/// <summary>
			/// 적용 하한가
			/// </summary>
			public const string dnlmtprice = "dnlmtprice";
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string futcode = "futcode";
		}

		public static string[] AllFields = new string[]
		{
			F.upstep,
			F.dnstep,
			F.uplmtprice,
			F.dnlmtprice,
			F.futcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["upstep"] = new XAQueryFieldInfo("char", upstep, upstep, "적용 상한단계", (decimal)2);
			dict["dnstep"] = new XAQueryFieldInfo("char", dnstep, dnstep, "적용 하한단계", (decimal)2);
			dict["uplmtprice"] = new XAQueryFieldInfo("float", uplmtprice, uplmtprice.ToString("000000.00"), "적용 상한가", (decimal)6.2);
			dict["dnlmtprice"] = new XAQueryFieldInfo("float", dnlmtprice, dnlmtprice.ToString("000000.00"), "적용 하한가", (decimal)6.2);
			dict["futcode"] = new XAQueryFieldInfo("char", futcode, futcode, "단축코드", (decimal)8);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "upstep":
					this.upstep = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "dnstep":
					this.dnstep = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "uplmtprice":
					this.uplmtprice = fieldInfo.FieldValue.ParseFloat("uplmtprice");
				break;

				case "dnlmtprice":
					this.dnlmtprice = fieldInfo.FieldValue.ParseFloat("dnlmtprice");
				break;

				case "futcode":
					this.futcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XRFX0OutBlock FromQuery(XRFX0 query)
		{
			XRFX0OutBlock block = new XRFX0OutBlock();
			block.IsValidData = true;
			block.InvalidReason = "";
			try
			{
				block.upstep = query.GetFieldData(block.GetBlockName(), "upstep").TrimEnd('?'); // char 2
				block.dnstep = query.GetFieldData(block.GetBlockName(), "dnstep").TrimEnd('?'); // char 2
				block.uplmtprice = query.GetFieldData(block.GetBlockName(), "uplmtprice").ParseFloat("uplmtprice"); // float 6.2
				block.dnlmtprice = query.GetFieldData(block.GetBlockName(), "dnlmtprice").ParseFloat("dnlmtprice"); // float 6.2
				block.futcode = query.GetFieldData(block.GetBlockName(), "futcode").TrimEnd('?'); // char 8

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (upstep?.Length > 2) return false; // char 2
			if (dnstep?.Length > 2) return false; // char 2
			// uplmtprice float 6.2
			// dnlmtprice float 6.2
			if (futcode?.Length > 8) return false; // char 8

			return true;
		}
	}

	/// <summary>
	/// KOSPI200선물가격제한폭확대(X0)
	/// </summary>
	public partial class XRFX0 : XingReal
	{
		/// <summary>
		/// FX0
		/// </summary>
		public const string _typeName = "FX0";
		/// <summary>
		/// KOSPI200선물가격제한폭확대(X0)
		/// </summary>
		public const string _typeDesc = "KOSPI200선물가격제한폭확대(X0)";
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
		/// FX0
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// KOSPI200선물가격제한폭확대(X0)
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
		/// KOSPI200선물가격제한폭확대(X0)
		/// </summary>
		public XRFX0() : base("FX0") { }


		public bool SetBlock(XRFX0InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaReal.SetFieldData(block.GetBlockName(), "futcode", block.futcode); // char 8

			return true;
		}

		public XRFX0OutBlock GetBlock()
		{
			XRFX0OutBlock instance = XRFX0OutBlock.FromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XRFX0OutBlock),

		};

	}

}
