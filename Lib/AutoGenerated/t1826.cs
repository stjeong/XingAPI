using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1826InBlock : XingBlock
	{
		/// <summary>
		/// t1826InBlock
		/// </summary>
		public const string _blockName = "t1826InBlock";
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
		/// t1826InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1826InBlock
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
		/// 검색구분(0:핵심검색1:지표검색2:시세동향3:투자자동향)
		/// </summary>
		[XAQueryFieldAttribute("search_gb", "검색구분(0:핵심검색1:지표검색2:시세동향3:투자자동향)", "char", "1")]
		public char search_gb;

		public static class F
		{
			/// <summary>
			/// 검색구분(0:핵심검색1:지표검색2:시세동향3:투자자동향)
			/// </summary>
			public const string search_gb = "search_gb";
		}

		public static string[] AllFields = new string[]
		{
			F.search_gb,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["search_gb"] = new XAQueryFieldInfo("char", search_gb, search_gb.ToString(), "검색구분(0:핵심검색1:지표검색2:시세동향3:투자자동향)", (decimal)1);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "search_gb":
					this.search_gb = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public bool VerifyData()
		{
			// search_gb char 1

			return true;
		}
	}

	public partial class XQt1826OutBlock : XingBlock
	{
		/// <summary>
		/// t1826OutBlock
		/// </summary>
		public const string _blockName = "t1826OutBlock";
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
		/// t1826OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1826OutBlock
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
		/// 검색코드
		/// </summary>
		[XAQueryFieldAttribute("search_cd", "검색코드", "char", "4")]
		public string search_cd;
		/// <summary>
		/// 검색명
		/// </summary>
		[XAQueryFieldAttribute("search_nm", "검색명", "char", "40")]
		public string search_nm;

		public static class F
		{
			/// <summary>
			/// 검색코드
			/// </summary>
			public const string search_cd = "search_cd";
			/// <summary>
			/// 검색명
			/// </summary>
			public const string search_nm = "search_nm";
		}

		public static string[] AllFields = new string[]
		{
			F.search_cd,
			F.search_nm,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["search_cd"] = new XAQueryFieldInfo("char", search_cd, search_cd, "검색코드", (decimal)4);
			dict["search_nm"] = new XAQueryFieldInfo("char", search_nm, search_nm, "검색명", (decimal)40);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "search_cd":
					this.search_cd = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "search_nm":
					this.search_nm = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt1826OutBlock[] ListFromQuery(XQt1826 query)
		{
			int count = query.GetBlockCount(XQt1826OutBlock.BlockName);
			List<XQt1826OutBlock> list = new List<XQt1826OutBlock>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1826OutBlock block = new XQt1826OutBlock();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.search_cd = query.GetFieldData(block.GetBlockName(), "search_cd", i).TrimEnd('?'); // char 4
					block.search_nm = query.GetFieldData(block.GetBlockName(), "search_nm", i).TrimEnd('?'); // char 40

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
			if (search_cd?.Length > 4) return false; // char 4
			if (search_nm?.Length > 40) return false; // char 40

			return true;
		}
	}

	/// <summary>
	/// 종목Q클릭검색리스트조회(씽큐스마트)(t1826)
	/// </summary>
	public partial class XQt1826 : XingQuery
	{
		/// <summary>
		/// t1826
		/// </summary>
		public const string _typeName = "t1826";
		/// <summary>
		/// 종목Q클릭검색리스트조회(씽큐스마트)(t1826)
		/// </summary>
		public const string _typeDesc = "종목Q클릭검색리스트조회(씽큐스마트)(t1826)";
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
		/// false
		/// </summary>
		public const bool _attr = false;
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
		/// t1826
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 종목Q클릭검색리스트조회(씽큐스마트)(t1826)
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

		/// <summary>
		/// 종목Q클릭검색리스트조회(씽큐스마트)(t1826)
		/// </summary>
		public XQt1826() : base("t1826") { }


		public static XQt1826OutBlock[] Get(char search_gb = default)
		{
			using (XQt1826 instance = new XQt1826())
			{
				instance.SetFieldData(XQt1826InBlock.BlockName, XQt1826InBlock.F.search_gb, 0, search_gb.ToString()); // char 1

				if (instance.Request() < 0)
				{
					return null;
				}

				var outBlock = instance.GetBlocks();
				return outBlock;
			}
		}

		public bool SetBlock(XQt1826InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "search_gb", 0, block.search_gb.ToString()); // char 1

			return true;
		}

		public XQt1826OutBlock[] GetBlocks()
		{
			XQt1826OutBlock[] instance = XQt1826OutBlock.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt1826OutBlock),

		};

	}

}
