using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt9945InBlock : XingBlock
	{
		/// <summary>
		/// t9945InBlock
		/// </summary>
		public const string _blockName = "t9945InBlock";
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
		/// t9945InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t9945InBlock
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
		/// 구분(KSP:1KSD:2)
		/// </summary>
		[XAQueryFieldAttribute("gubun", "구분(KSP:1KSD:2)", "char", "1")]
		public char gubun;

		public static class F
		{
			/// <summary>
			/// 구분(KSP:1KSD:2)
			/// </summary>
			public const string gubun = "gubun";
		}

		public static string[] AllFields = new string[]
		{
			F.gubun,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["gubun"] = new XAQueryFieldInfo("char", gubun, gubun.ToString(), "구분(KSP:1KSD:2)", (decimal)1);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "gubun":
					this.gubun = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public bool VerifyData()
		{
			// gubun char 1

			return true;
		}
	}

	public partial class XQt9945OutBlock : XingBlock
	{
		/// <summary>
		/// t9945OutBlock
		/// </summary>
		public const string _blockName = "t9945OutBlock";
		/// <summary>
		/// 주식종목마스터
		/// </summary>
		public const string _blockDesc = "주식종목마스터";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// true
		/// </summary>
		public const bool _hasOccurs = true;
		/// <summary>
		/// t9945OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t9945OutBlock
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// 주식종목마스터
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
		/// 종목명
		/// </summary>
		[XAQueryFieldAttribute("hname", "종목명", "char", "40")]
		public string hname;
		/// <summary>
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("shcode", "단축코드", "char", "6")]
		public string shcode;
		/// <summary>
		/// 확장코드
		/// </summary>
		[XAQueryFieldAttribute("expcode", "확장코드", "char", "12")]
		public string expcode;
		/// <summary>
		/// ETF구분
		/// </summary>
		[XAQueryFieldAttribute("etfchk", "ETF구분", "char", "1")]
		public char etfchk;
		/// <summary>
		/// filler
		/// </summary>
		[XAQueryFieldAttribute("filler", "filler", "char", "5")]
		public string filler;

		public static class F
		{
			/// <summary>
			/// 종목명
			/// </summary>
			public const string hname = "hname";
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 확장코드
			/// </summary>
			public const string expcode = "expcode";
			/// <summary>
			/// ETF구분
			/// </summary>
			public const string etfchk = "etfchk";
			/// <summary>
			/// filler
			/// </summary>
			public const string filler = "filler";
		}

		public static string[] AllFields = new string[]
		{
			F.hname,
			F.shcode,
			F.expcode,
			F.etfchk,
			F.filler,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["hname"] = new XAQueryFieldInfo("char", hname, hname, "종목명", (decimal)40);
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)6);
			dict["expcode"] = new XAQueryFieldInfo("char", expcode, expcode, "확장코드", (decimal)12);
			dict["etfchk"] = new XAQueryFieldInfo("char", etfchk, etfchk.ToString(), "ETF구분", (decimal)1);
			dict["filler"] = new XAQueryFieldInfo("char", filler, filler, "filler", (decimal)5);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "hname":
					this.hname = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "expcode":
					this.expcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "etfchk":
					this.etfchk = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "filler":
					this.filler = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt9945OutBlock[] ListFromQuery(XQt9945 query)
		{
			int count = query.GetBlockCount(XQt9945OutBlock.BlockName);
			List<XQt9945OutBlock> list = new List<XQt9945OutBlock>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt9945OutBlock block = new XQt9945OutBlock();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.hname = query.GetFieldData(block.GetBlockName(), "hname", i).TrimEnd('?'); // char 40
					block.shcode = query.GetFieldData(block.GetBlockName(), "shcode", i).TrimEnd('?'); // char 6
					block.expcode = query.GetFieldData(block.GetBlockName(), "expcode", i).TrimEnd('?'); // char 12
					block.etfchk = query.GetFieldData(block.GetBlockName(), "etfchk", i).FirstOrDefault(); // char 1
					block.filler = query.GetFieldData(block.GetBlockName(), "filler", i).TrimEnd('?'); // char 5

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
			if (hname?.Length > 40) return false; // char 40
			if (shcode?.Length > 6) return false; // char 6
			if (expcode?.Length > 12) return false; // char 12
			// etfchk char 1
			if (filler?.Length > 5) return false; // char 5

			return true;
		}
	}

	/// <summary>
	/// 주식마스터조회API용-종목명40bytes(t9945)
	/// </summary>
	public partial class XQt9945 : XingQuery
	{
		/// <summary>
		/// t9945
		/// </summary>
		public const string _typeName = "t9945";
		/// <summary>
		/// 주식마스터조회API용-종목명40bytes(t9945)
		/// </summary>
		public const string _typeDesc = "주식마스터조회API용-종목명40bytes(t9945)";
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
		/// t9945
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 주식마스터조회API용-종목명40bytes(t9945)
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
		/// 주식마스터조회API용-종목명40bytes(t9945)
		/// </summary>
		public XQt9945() : base("t9945") { }


		public static XQt9945OutBlock[] Get(char gubun = default)
		{
			using (XQt9945 instance = new XQt9945())
			{
				instance.SetFieldData(XQt9945InBlock.BlockName, XQt9945InBlock.F.gubun, 0, gubun.ToString()); // char 1

				if (instance.Request() < 0)
				{
					return null;
				}

				var outBlock = instance.GetBlocks();
				return outBlock;
			}
		}

		public bool SetBlock(XQt9945InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "gubun", 0, block.gubun.ToString()); // char 1

			return true;
		}

		public XQt9945OutBlock[] GetBlocks()
		{
			XQt9945OutBlock[] instance = XQt9945OutBlock.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt9945OutBlock),

		};

	}

}
