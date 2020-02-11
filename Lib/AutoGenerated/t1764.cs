using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1764InBlock : XingBlock
	{
		/// <summary>
		/// t1764InBlock
		/// </summary>
		public const string _blockName = "t1764InBlock";
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
		/// t1764InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1764InBlock
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
		/// 종목코드
		/// </summary>
		[XAQueryFieldAttribute("shcode", "종목코드", "char", "6")]
		public string shcode;
		/// <summary>
		/// 구분1
		/// </summary>
		[XAQueryFieldAttribute("gubun1", "구분1", "char", "1")]
		public char gubun1;

		public static class F
		{
			/// <summary>
			/// 종목코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 구분1
			/// </summary>
			public const string gubun1 = "gubun1";
		}

		public static string[] AllFields = new string[]
		{
			F.shcode,
			F.gubun1,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "종목코드", (decimal)6);
			dict["gubun1"] = new XAQueryFieldInfo("char", gubun1, gubun1.ToString(), "구분1", (decimal)1);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "gubun1":
					this.gubun1 = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public bool VerifyData()
		{
			if (shcode?.Length > 6) return false; // char 6
			// gubun1 char 1

			return true;
		}
	}

	public partial class XQt1764OutBlock : XingBlock
	{
		/// <summary>
		/// t1764OutBlock
		/// </summary>
		public const string _blockName = "t1764OutBlock";
		/// <summary>
		/// 출력1
		/// </summary>
		public const string _blockDesc = "출력1";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// true
		/// </summary>
		public const bool _hasOccurs = true;
		/// <summary>
		/// t1764OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1764OutBlock
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// 출력1
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
		/// 순위
		/// </summary>
		[XAQueryFieldAttribute("rank", "순위", "long", "4")]
		public long rank;
		/// <summary>
		/// 거래원번호
		/// </summary>
		[XAQueryFieldAttribute("tradno", "거래원번호", "char", "3")]
		public string tradno;
		/// <summary>
		/// 거래원이름
		/// </summary>
		[XAQueryFieldAttribute("tradname", "거래원이름", "char", "20")]
		public string tradname;

		public static class F
		{
			/// <summary>
			/// 순위
			/// </summary>
			public const string rank = "rank";
			/// <summary>
			/// 거래원번호
			/// </summary>
			public const string tradno = "tradno";
			/// <summary>
			/// 거래원이름
			/// </summary>
			public const string tradname = "tradname";
		}

		public static string[] AllFields = new string[]
		{
			F.rank,
			F.tradno,
			F.tradname,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["rank"] = new XAQueryFieldInfo("long", rank, rank.ToString("d4"), "순위", (decimal)4);
			dict["tradno"] = new XAQueryFieldInfo("char", tradno, tradno, "거래원번호", (decimal)3);
			dict["tradname"] = new XAQueryFieldInfo("char", tradname, tradname, "거래원이름", (decimal)20);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "rank":
					this.rank = fieldInfo.FieldValue.ParseLong("rank");
				break;

				case "tradno":
					this.tradno = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "tradname":
					this.tradname = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt1764OutBlock[] ListFromQuery(XQt1764 query)
		{
			int count = query.GetBlockCount(XQt1764OutBlock.BlockName);
			List<XQt1764OutBlock> list = new List<XQt1764OutBlock>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1764OutBlock block = new XQt1764OutBlock();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.rank = query.GetFieldData(block.GetBlockName(), "rank", i).ParseLong("rank"); // long 4
					block.tradno = query.GetFieldData(block.GetBlockName(), "tradno", i).TrimEnd('?'); // char 3
					block.tradname = query.GetFieldData(block.GetBlockName(), "tradname", i).TrimEnd('?'); // char 20

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
			if (rank.ToString().Length > 4) return false; // long 4
			if (tradno?.Length > 3) return false; // char 3
			if (tradname?.Length > 20) return false; // char 20

			return true;
		}
	}

	/// <summary>
	/// 회원사리스트(t1764)
	/// </summary>
	public partial class XQt1764 : XingQuery
	{
		/// <summary>
		/// t1764
		/// </summary>
		public const string _typeName = "t1764";
		/// <summary>
		/// 회원사리스트(t1764)
		/// </summary>
		public const string _typeDesc = "회원사리스트(t1764)";
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
		/// t1764
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 회원사리스트(t1764)
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
		/// 회원사리스트(t1764)
		/// </summary>
		public XQt1764() : base("t1764") { }


		public static XQt1764OutBlock[] Get(string shcode = default,char gubun1 = default)
		{
			using (XQt1764 instance = new XQt1764())
			{
				instance.SetFieldData(XQt1764InBlock.BlockName, XQt1764InBlock.F.shcode, 0, shcode); // char 6
				instance.SetFieldData(XQt1764InBlock.BlockName, XQt1764InBlock.F.gubun1, 0, gubun1.ToString()); // char 1

				if (instance.Request() < 0)
				{
					return null;
				}

				var outBlock = instance.GetBlocks();
				return outBlock;
			}
		}

		public bool SetBlock(XQt1764InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "shcode", 0, block.shcode); // char 6
			_xaQuery.SetFieldData(block.GetBlockName(), "gubun1", 0, block.gubun1.ToString()); // char 1

			return true;
		}

		public XQt1764OutBlock[] GetBlocks()
		{
			XQt1764OutBlock[] instance = XQt1764OutBlock.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt1764OutBlock),

		};

	}

}
