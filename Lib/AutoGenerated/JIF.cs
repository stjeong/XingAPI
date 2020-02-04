using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XRJIFInBlock : XingBlock
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
		/// 장구분
		/// </summary>
		[XAQueryFieldAttribute("장구분")]
		public char jangubun;

		public static class F
		{
			/// <summary>
			/// 장구분
			/// </summary>
			public const string jangubun = "jangubun";
		}

		public static string[] AllFields = new string[]
		{
			F.jangubun,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["jangubun"] = new XAQueryFieldInfo("char", jangubun, jangubun.ToString(), "장구분", (decimal)1);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "jangubun":
					this.jangubun = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public bool VerifyData()
		{
			// jangubun char 1

			return true;
		}
	}

	public partial class XRJIFOutBlock : XingBlock
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
		/// 장구분
		/// </summary>
		[XAQueryFieldAttribute("장구분")]
		public char jangubun;
		/// <summary>
		/// 장상태
		/// </summary>
		[XAQueryFieldAttribute("장상태")]
		public string jstatus;

		public static class F
		{
			/// <summary>
			/// 장구분
			/// </summary>
			public const string jangubun = "jangubun";
			/// <summary>
			/// 장상태
			/// </summary>
			public const string jstatus = "jstatus";
		}

		public static string[] AllFields = new string[]
		{
			F.jangubun,
			F.jstatus,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["jangubun"] = new XAQueryFieldInfo("char", jangubun, jangubun.ToString(), "장구분", (decimal)1);
			dict["jstatus"] = new XAQueryFieldInfo("char", jstatus, jstatus, "장상태", (decimal)2);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "jangubun":
					this.jangubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "jstatus":
					this.jstatus = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XRJIFOutBlock FromQuery(XRJIF query)
		{
			XRJIFOutBlock block = new XRJIFOutBlock();
			block.IsValidData = true;
			block.InvalidReason = "";
			try
			{
				block.jangubun = query.GetFieldData(block.GetBlockName(), "jangubun").FirstOrDefault(); // char 1
				block.jstatus = query.GetFieldData(block.GetBlockName(), "jstatus").TrimEnd('?'); // char 2

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			// jangubun char 1
			if (jstatus?.Length > 2) return false; // char 2

			return true;
		}
	}

	public partial class XRJIF : XingReal
	{
		/// <summary>
		/// JIF
		/// </summary>
		public const string _typeName = "JIF";
		/// <summary>
		/// 장운영정보(JIF)
		/// </summary>
		public const string _typeDesc = "장운영정보(JIF)";
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
		/// JIF
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 장운영정보(JIF)
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

		public XRJIF() : base("JIF") { }


		public bool SetFields(XRJIFInBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaReal.SetFieldData(block.GetBlockName(), "jangubun", block.jangubun.ToString()); // char 1

			return true;
		}

		public XRJIFOutBlock GetBlock()
		{
			XRJIFOutBlock instance = XRJIFOutBlock.FromQuery(this);
			return instance;

		}


	}

}
