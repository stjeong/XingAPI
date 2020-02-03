using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt3102InBlock : XingBlock
	{
		/// <summary>
		/// t3102InBlock
		/// </summary>
		static readonly string _blockName = "t3102InBlock";
		/// <summary>
		/// 기본입력
		/// </summary>
		static readonly string _blockDesc = "기본입력";
		/// <summary>
		/// input
		/// </summary>
		static readonly string _blockType = "input";
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _hasOccurs = false;
		/// <summary>
		/// t3102InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t3102InBlock
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// 기본입력
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
		/// 뉴스번호
		/// </summary>
		[XAQueryFieldAttribute("뉴스번호")]
		public string sNewsno;

		public static class F
		{
			/// <summary>
			/// 뉴스번호
			/// </summary>
			public const string sNewsno = "sNewsno";
		}

		public static string[] AllFields = new string[]
		{
			F.sNewsno,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["sNewsno"] = new XAQueryFieldInfo("char", sNewsno, sNewsno, "뉴스번호", (decimal)24);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "sNewsno":
					this.sNewsno = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (sNewsno.Length > 24) return false; // char 24

			return true;
		}
	}

	public partial class XQt3102OutBlock : XingBlock
	{
		/// <summary>
		/// t3102OutBlock
		/// </summary>
		static readonly string _blockName = "t3102OutBlock";
		/// <summary>
		/// 기본출력
		/// </summary>
		static readonly string _blockDesc = "기본출력";
		/// <summary>
		/// output
		/// </summary>
		static readonly string _blockType = "output";
		/// <summary>
		/// true
		/// </summary>
		static readonly bool _hasOccurs = true;
		/// <summary>
		/// t3102OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t3102OutBlock
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// 기본출력
		/// </summary>
		public string BlockDesc => _blockDesc;
		/// <summary>
		/// output
		/// </summary>
		public string BlockType => _blockType;
		/// <summary>
		/// true
		/// </summary>
		public bool HasOccurs => _hasOccurs;

		/// <summary>
		/// 뉴스종목
		/// </summary>
		[XAQueryFieldAttribute("뉴스종목")]
		public string sJongcode;

		public static class F
		{
			/// <summary>
			/// 뉴스종목
			/// </summary>
			public const string sJongcode = "sJongcode";
		}

		public static string[] AllFields = new string[]
		{
			F.sJongcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["sJongcode"] = new XAQueryFieldInfo("char", sJongcode, sJongcode, "뉴스종목", (decimal)6);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "sJongcode":
					this.sJongcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt3102OutBlock[] ListFromQuery(XQt3102 query)
		{
			int count = query.GetBlockCount(XQt3102OutBlock.BlockName);
			List<XQt3102OutBlock> list = new List<XQt3102OutBlock>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt3102OutBlock block = new XQt3102OutBlock();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.sJongcode = query.GetFieldData(block.GetBlockName(), "sJongcode", i).TrimEnd('?'); // char 6

				} catch (InvalidDataFormatException e) {
					block.IsValidData = false;
					block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
				}
				list.Add(block);
			}
			return list.ToArray();

		}

		public bool VerifyData()
		{
			if (sJongcode.Length > 6) return false; // char 6

			return true;
		}
	}

	public partial class XQt3102OutBlock1 : XingBlock
	{
		/// <summary>
		/// t3102OutBlock1
		/// </summary>
		static readonly string _blockName = "t3102OutBlock1";
		/// <summary>
		/// 기본출력1
		/// </summary>
		static readonly string _blockDesc = "기본출력1";
		/// <summary>
		/// output
		/// </summary>
		static readonly string _blockType = "output";
		/// <summary>
		/// true
		/// </summary>
		static readonly bool _hasOccurs = true;
		/// <summary>
		/// t3102OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t3102OutBlock1
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// 기본출력1
		/// </summary>
		public string BlockDesc => _blockDesc;
		/// <summary>
		/// output
		/// </summary>
		public string BlockType => _blockType;
		/// <summary>
		/// true
		/// </summary>
		public bool HasOccurs => _hasOccurs;

		/// <summary>
		/// 뉴스본문
		/// </summary>
		[XAQueryFieldAttribute("뉴스본문")]
		public string sBody;

		public static class F
		{
			/// <summary>
			/// 뉴스본문
			/// </summary>
			public const string sBody = "sBody";
		}

		public static string[] AllFields = new string[]
		{
			F.sBody,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["sBody"] = new XAQueryFieldInfo("char", sBody, sBody, "뉴스본문", (decimal)100);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "sBody":
					this.sBody = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt3102OutBlock1[] ListFromQuery(XQt3102 query)
		{
			int count = query.GetBlockCount(XQt3102OutBlock1.BlockName);
			List<XQt3102OutBlock1> list = new List<XQt3102OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt3102OutBlock1 block = new XQt3102OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.sBody = query.GetFieldData(block.GetBlockName(), "sBody", i).TrimEnd('?'); // char 100

				} catch (InvalidDataFormatException e) {
					block.IsValidData = false;
					block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
				}
				list.Add(block);
			}
			return list.ToArray();

		}

		public bool VerifyData()
		{
			if (sBody.Length > 100) return false; // char 100

			return true;
		}
	}

	public partial class XQt3102OutBlock2 : XingBlock
	{
		/// <summary>
		/// t3102OutBlock2
		/// </summary>
		static readonly string _blockName = "t3102OutBlock2";
		/// <summary>
		/// 기본출력2
		/// </summary>
		static readonly string _blockDesc = "기본출력2";
		/// <summary>
		/// output
		/// </summary>
		static readonly string _blockType = "output";
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _hasOccurs = false;
		/// <summary>
		/// t3102OutBlock2
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t3102OutBlock2
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// 기본출력2
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
		/// 뉴스타이틀
		/// </summary>
		[XAQueryFieldAttribute("뉴스타이틀")]
		public string sTitle;

		public static class F
		{
			/// <summary>
			/// 뉴스타이틀
			/// </summary>
			public const string sTitle = "sTitle";
		}

		public static string[] AllFields = new string[]
		{
			F.sTitle,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["sTitle"] = new XAQueryFieldInfo("char", sTitle, sTitle, "뉴스타이틀", (decimal)300);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "sTitle":
					this.sTitle = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt3102OutBlock2 FromQuery(XQt3102 query)
		{
			XQt3102OutBlock2 block = new XQt3102OutBlock2();
			block.IsValidData = true;
			block.InvalidReason = "";
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				block.IsValidData = false;
				block.InvalidReason = query.ReceiveMessage;
				return block;
			}
			try
			{
				block.sTitle = query.GetFieldData(block.GetBlockName(), "sTitle", 0).TrimEnd('?'); // char 300

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (sTitle.Length > 300) return false; // char 300

			return true;
		}
	}

	public partial class XQt3102 : XingQuery
	{
		/// <summary>
		/// t3102
		/// </summary>
		static readonly string _typeName = "t3102";
		/// <summary>
		/// 뉴스본문(t3102)
		/// </summary>
		static readonly string _typeDesc = "뉴스본문(t3102)";
		/// <summary>
		/// 
		/// </summary>
		static readonly string _service = "";
		/// <summary>
		/// A
		/// </summary>
		static readonly string _headType = "A";
		/// <summary>
		/// 
		/// </summary>
		static readonly string _creator = "";
		/// <summary>
		/// 
		/// </summary>
		static readonly string _createdDate = "";
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _attr = false;
		/// <summary>
		/// true
		/// </summary>
		static readonly bool _block = true;
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _encrypt = false;
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _signature = false;

		/// <summary>
		/// t3102
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 뉴스본문(t3102)
		/// </summary>
		public string TypeDesc => _typeDesc;
		/// <summary>
		/// 
		/// </summary>
		public string Service => _service;
		/// <summary>
		/// A
		/// </summary>
		public string HeadType => _headType;
		/// <summary>
		/// 
		/// </summary>
		public string Creator => _creator;
		/// <summary>
		/// 
		/// </summary>
		public string CreatedDate => _createdDate;
		/// <summary>
		/// false
		/// </summary>
		public bool Attr => _attr;
		/// <summary>
		/// true
		/// </summary>
		public bool Block => _block;
		/// <summary>
		/// false
		/// </summary>
		public bool Encrypt => _encrypt;
		/// <summary>
		/// false
		/// </summary>
		public bool Signature => _signature;

		public XQt3102() : base("t3102") { }


		public bool SetFields(XQt3102InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "sNewsno", 0, block.sNewsno); // char 24

			return true;
		}

		public XQt3102OutBlock[] GetBlocks()
		{
			XQt3102OutBlock[] instance = XQt3102OutBlock.ListFromQuery(this);
			return instance;

		}

		public XQt3102OutBlock1[] GetBlock1s()
		{
			XQt3102OutBlock1[] instance = XQt3102OutBlock1.ListFromQuery(this);
			return instance;

		}

		public XQt3102OutBlock2 GetBlock2()
		{
			XQt3102OutBlock2 instance = XQt3102OutBlock2.FromQuery(this);
			return instance;

		}


	}

}
