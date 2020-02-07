using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt8424InBlock : XingBlock
	{
		/// <summary>
		/// t8424InBlock
		/// </summary>
		public const string _blockName = "t8424InBlock";
		/// <summary>
		/// 기본입력
		/// </summary>
		public const string _blockDesc = "기본입력";
		/// <summary>
		/// input
		/// </summary>
		public const string _blockType = "input";
		/// <summary>
		/// false
		/// </summary>
		public const bool _hasOccurs = false;
		/// <summary>
		/// t8424InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t8424InBlock
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
		/// 구분1
		/// </summary>
		[XAQueryFieldAttribute("구분1")]
		public char gubun1;

		public static class F
		{
			/// <summary>
			/// 구분1
			/// </summary>
			public const string gubun1 = "gubun1";
		}

		public static string[] AllFields = new string[]
		{
			F.gubun1,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["gubun1"] = new XAQueryFieldInfo("char", gubun1, gubun1.ToString(), "구분1", (decimal)1);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "gubun1":
					this.gubun1 = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public bool VerifyData()
		{
			// gubun1 char 1

			return true;
		}
	}

	public partial class XQt8424OutBlock : XingBlock
	{
		/// <summary>
		/// t8424OutBlock
		/// </summary>
		public const string _blockName = "t8424OutBlock";
		/// <summary>
		/// 출력
		/// </summary>
		public const string _blockDesc = "출력";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// true
		/// </summary>
		public const bool _hasOccurs = true;
		/// <summary>
		/// t8424OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t8424OutBlock
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
		/// true
		/// </summary>
		public bool HasOccurs => _hasOccurs;

		/// <summary>
		/// 업종명
		/// </summary>
		[XAQueryFieldAttribute("업종명")]
		public string hname;
		/// <summary>
		/// 업종코드
		/// </summary>
		[XAQueryFieldAttribute("업종코드")]
		public string upcode;

		public static class F
		{
			/// <summary>
			/// 업종명
			/// </summary>
			public const string hname = "hname";
			/// <summary>
			/// 업종코드
			/// </summary>
			public const string upcode = "upcode";
		}

		public static string[] AllFields = new string[]
		{
			F.hname,
			F.upcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["hname"] = new XAQueryFieldInfo("char", hname, hname, "업종명", (decimal)20);
			dict["upcode"] = new XAQueryFieldInfo("char", upcode, upcode, "업종코드", (decimal)3);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "hname":
					this.hname = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "upcode":
					this.upcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt8424OutBlock[] ListFromQuery(XQt8424 query)
		{
			int count = query.GetBlockCount(XQt8424OutBlock.BlockName);
			List<XQt8424OutBlock> list = new List<XQt8424OutBlock>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt8424OutBlock block = new XQt8424OutBlock();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.hname = query.GetFieldData(block.GetBlockName(), "hname", i).TrimEnd('?'); // char 20
					block.upcode = query.GetFieldData(block.GetBlockName(), "upcode", i).TrimEnd('?'); // char 3

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
			if (hname?.Length > 20) return false; // char 20
			if (upcode?.Length > 3) return false; // char 3

			return true;
		}
	}

	/// <summary>
	/// 전체업종(t8424)
	/// </summary>
	public partial class XQt8424 : XingQuery
	{
		/// <summary>
		/// t8424
		/// </summary>
		public const string _typeName = "t8424";
		/// <summary>
		/// 전체업종(t8424)
		/// </summary>
		public const string _typeDesc = "전체업종(t8424)";
		/// <summary>
		/// 
		/// </summary>
		public const string _service = "";
		/// <summary>
		/// A
		/// </summary>
		public const string _headType = "A";
		/// <summary>
		/// 
		/// </summary>
		public const string _creator = "";
		/// <summary>
		/// 
		/// </summary>
		public const string _createdDate = "";
		/// <summary>
		/// true
		/// </summary>
		public const bool _attr = true;
		/// <summary>
		/// true
		/// </summary>
		public const bool _block = true;
		/// <summary>
		/// false
		/// </summary>
		public const bool _encrypt = false;
		/// <summary>
		/// false
		/// </summary>
		public const bool _signature = false;

		/// <summary>
		/// t8424
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 전체업종(t8424)
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
		/// true
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

		/// <summary>
		/// 전체업종(t8424)
		/// </summary>
		public XQt8424() : base("t8424") { }


		public static XQt8424OutBlock[] Get(char gubun1 = default)
		{
			using (XQt8424 instance = new XQt8424())
			{
				instance.SetFieldData(XQt8424InBlock.BlockName, XQt8424InBlock.F.gubun1, 0, gubun1.ToString()); // char 1

				if (instance.Request() < 0)
				{
					return null;
				}

				var outBlock = instance.GetBlocks();
				return outBlock;
			}
		}

		public bool SetBlock(XQt8424InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "gubun1", 0, block.gubun1.ToString()); // char 1

			return true;
		}

		public XQt8424OutBlock[] GetBlocks()
		{
			XQt8424OutBlock[] instance = XQt8424OutBlock.ListFromQuery(this);
			return instance;

		}


	}

}
