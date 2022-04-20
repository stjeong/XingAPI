using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XROX0InBlock : XingBlock
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

		public void CopyTo(XROX0InBlock block)
		{
			block.optcode = this.optcode;

		}
	}

	public partial class XROX0OutBlock : XingBlock
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
		[XAQueryFieldAttribute("upstep", "적용 상한단계", "char", "2")]
		public string upstep;
		/// <summary>
		/// 적용 하한단계
		/// </summary>
		[XAQueryFieldAttribute("dnstep", "적용 하한단계", "char", "2")]
		public string dnstep;
		/// <summary>
		/// 적용 상한가
		/// </summary>
		[XAQueryFieldAttribute("uplmtprice", "적용 상한가", "float", "6.2")]
		public float uplmtprice;
		/// <summary>
		/// 적용 하한가
		/// </summary>
		[XAQueryFieldAttribute("dnlmtprice", "적용 하한가", "float", "6.2")]
		public float dnlmtprice;
		/// <summary>
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("opttcode", "단축코드", "char", "8")]
		public string opttcode;

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
			public const string opttcode = "opttcode";
		}

		public static string[] AllFields = new string[]
		{
			F.upstep,
			F.dnstep,
			F.uplmtprice,
			F.dnlmtprice,
			F.opttcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["upstep"] = new XAQueryFieldInfo("char", upstep, upstep, "적용 상한단계", (decimal)2);
			dict["dnstep"] = new XAQueryFieldInfo("char", dnstep, dnstep, "적용 하한단계", (decimal)2);
			dict["uplmtprice"] = new XAQueryFieldInfo("float", uplmtprice, uplmtprice.ToString("000000.00"), "적용 상한가", (decimal)6.2);
			dict["dnlmtprice"] = new XAQueryFieldInfo("float", dnlmtprice, dnlmtprice.ToString("000000.00"), "적용 하한가", (decimal)6.2);
			dict["opttcode"] = new XAQueryFieldInfo("char", opttcode, opttcode, "단축코드", (decimal)8);

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

				case "opttcode":
					this.opttcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XROX0OutBlock FromQuery(XROX0 query)
		{
			XROX0OutBlock block = new XROX0OutBlock();
			block.IsValidData = true;
			block.InvalidReason = "";
			try
			{
				block.upstep = query.GetFieldData(block.GetBlockName(), "upstep").TrimEnd('?'); // char 2
				block.dnstep = query.GetFieldData(block.GetBlockName(), "dnstep").TrimEnd('?'); // char 2
				block.uplmtprice = query.GetFieldData(block.GetBlockName(), "uplmtprice").ParseFloat("uplmtprice"); // float 6.2
				block.dnlmtprice = query.GetFieldData(block.GetBlockName(), "dnlmtprice").ParseFloat("dnlmtprice"); // float 6.2
				block.opttcode = query.GetFieldData(block.GetBlockName(), "opttcode").TrimEnd('?'); // char 8

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
			if (opttcode?.Length > 8) return false; // char 8

			return true;
		}

		public void CopyTo(XROX0OutBlock block)
		{
			block.upstep = this.upstep;
			block.dnstep = this.dnstep;
			block.uplmtprice = this.uplmtprice;
			block.dnlmtprice = this.dnlmtprice;
			block.opttcode = this.opttcode;

		}
	}

	/// <summary>
	/// KOSPI200옵션가격제한폭확대(X0)
	/// </summary>
	public partial class XROX0 : XingReal
	{
		/// <summary>
		/// OX0
		/// </summary>
		public const string _typeName = "OX0";
		/// <summary>
		/// KOSPI200옵션가격제한폭확대(X0)
		/// </summary>
		public const string _typeDesc = "KOSPI200옵션가격제한폭확대(X0)";
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
		/// OX0
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// KOSPI200옵션가격제한폭확대(X0)
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
		/// KOSPI200옵션가격제한폭확대(X0)
		/// </summary>
		public XROX0() : base("OX0") { }


		public bool SetBlock(XROX0InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaReal.SetFieldData(block.GetBlockName(), "optcode", block.optcode); // char 8

			return true;
		}

		public XROX0OutBlock GetBlock()
		{
			XROX0OutBlock instance = XROX0OutBlock.FromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XROX0OutBlock),

		};

	}

}
