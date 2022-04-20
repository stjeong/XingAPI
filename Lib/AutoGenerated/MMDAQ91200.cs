using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQMMDAQ91200InBlock1 : XingBlock
	{
		/// <summary>
		/// MMDAQ91200InBlock1
		/// </summary>
		public const string _blockName = "MMDAQ91200InBlock1";
		/// <summary>
		/// In(*EMPTY*)
		/// </summary>
		public const string _blockDesc = "In(*EMPTY*)";
		/// <summary>
		/// input
		/// </summary>
		public const string _blockType = "input";
		/// <summary>
		/// false
		/// </summary>
		public const bool _hasOccurs = false;
		/// <summary>
		/// MMDAQ91200InBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// MMDAQ91200InBlock1
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// In(*EMPTY*)
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
		/// 레코드갯수
		/// </summary>
		[XAQueryFieldAttribute("RecCnt", "레코드갯수", "long", "5")]
		public long RecCnt;
		/// <summary>
		/// 종목대분류코드
		/// </summary>
		[XAQueryFieldAttribute("IsuLgclssCode", "종목대분류코드", "char", "2")]
		public string IsuLgclssCode;
		/// <summary>
		/// 종목중분류코드
		/// </summary>
		[XAQueryFieldAttribute("IsuMdclssCode", "종목중분류코드", "char", "2")]
		public string IsuMdclssCode;

		public static class F
		{
			/// <summary>
			/// 레코드갯수
			/// </summary>
			public const string RecCnt = "RecCnt";
			/// <summary>
			/// 종목대분류코드
			/// </summary>
			public const string IsuLgclssCode = "IsuLgclssCode";
			/// <summary>
			/// 종목중분류코드
			/// </summary>
			public const string IsuMdclssCode = "IsuMdclssCode";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.IsuLgclssCode,
			F.IsuMdclssCode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["IsuLgclssCode"] = new XAQueryFieldInfo("char", IsuLgclssCode, IsuLgclssCode, "종목대분류코드", (decimal)2);
			dict["IsuMdclssCode"] = new XAQueryFieldInfo("char", IsuMdclssCode, IsuMdclssCode, "종목중분류코드", (decimal)2);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "RecCnt":
					this.RecCnt = fieldInfo.FieldValue.ParseLong("RecCnt");
				break;

				case "IsuLgclssCode":
					this.IsuLgclssCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "IsuMdclssCode":
					this.IsuMdclssCode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (RecCnt.ToString().Length > 5) return false; // long 5
			if (IsuLgclssCode?.Length > 2) return false; // char 2
			if (IsuMdclssCode?.Length > 2) return false; // char 2

			return true;
		}

		public void CopyTo(XQMMDAQ91200InBlock1 block)
		{
			block.RecCnt = this.RecCnt;
			block.IsuLgclssCode = this.IsuLgclssCode;
			block.IsuMdclssCode = this.IsuMdclssCode;

		}
	}

	public partial class XQMMDAQ91200OutBlock1 : XingBlock
	{
		/// <summary>
		/// MMDAQ91200OutBlock1
		/// </summary>
		public const string _blockName = "MMDAQ91200OutBlock1";
		/// <summary>
		/// In(*EMPTY*)
		/// </summary>
		public const string _blockDesc = "In(*EMPTY*)";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// false
		/// </summary>
		public const bool _hasOccurs = false;
		/// <summary>
		/// MMDAQ91200OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// MMDAQ91200OutBlock1
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// In(*EMPTY*)
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
		/// 레코드갯수
		/// </summary>
		[XAQueryFieldAttribute("RecCnt", "레코드갯수", "long", "5")]
		public long RecCnt;
		/// <summary>
		/// 종목대분류코드
		/// </summary>
		[XAQueryFieldAttribute("IsuLgclssCode", "종목대분류코드", "char", "2")]
		public string IsuLgclssCode;
		/// <summary>
		/// 종목중분류코드
		/// </summary>
		[XAQueryFieldAttribute("IsuMdclssCode", "종목중분류코드", "char", "2")]
		public string IsuMdclssCode;

		public static class F
		{
			/// <summary>
			/// 레코드갯수
			/// </summary>
			public const string RecCnt = "RecCnt";
			/// <summary>
			/// 종목대분류코드
			/// </summary>
			public const string IsuLgclssCode = "IsuLgclssCode";
			/// <summary>
			/// 종목중분류코드
			/// </summary>
			public const string IsuMdclssCode = "IsuMdclssCode";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.IsuLgclssCode,
			F.IsuMdclssCode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["IsuLgclssCode"] = new XAQueryFieldInfo("char", IsuLgclssCode, IsuLgclssCode, "종목대분류코드", (decimal)2);
			dict["IsuMdclssCode"] = new XAQueryFieldInfo("char", IsuMdclssCode, IsuMdclssCode, "종목중분류코드", (decimal)2);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "RecCnt":
					this.RecCnt = fieldInfo.FieldValue.ParseLong("RecCnt");
				break;

				case "IsuLgclssCode":
					this.IsuLgclssCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "IsuMdclssCode":
					this.IsuMdclssCode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQMMDAQ91200OutBlock1 FromQuery(XQMMDAQ91200 query)
		{
			XQMMDAQ91200OutBlock1 block = new XQMMDAQ91200OutBlock1();
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
				block.RecCnt = query.GetFieldData(block.GetBlockName(), "RecCnt", 0).ParseLong("RecCnt"); // long 5
				block.IsuLgclssCode = query.GetFieldData(block.GetBlockName(), "IsuLgclssCode", 0).TrimEnd('?'); // char 2
				block.IsuMdclssCode = query.GetFieldData(block.GetBlockName(), "IsuMdclssCode", 0).TrimEnd('?'); // char 2

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (RecCnt.ToString().Length > 5) return false; // long 5
			if (IsuLgclssCode?.Length > 2) return false; // char 2
			if (IsuMdclssCode?.Length > 2) return false; // char 2

			return true;
		}

		public void CopyTo(XQMMDAQ91200OutBlock1 block)
		{
			block.RecCnt = this.RecCnt;
			block.IsuLgclssCode = this.IsuLgclssCode;
			block.IsuMdclssCode = this.IsuMdclssCode;

		}
	}

	public partial class XQMMDAQ91200OutBlock2 : XingBlock
	{
		/// <summary>
		/// MMDAQ91200OutBlock2
		/// </summary>
		public const string _blockName = "MMDAQ91200OutBlock2";
		/// <summary>
		/// Out(*EMPTY*)
		/// </summary>
		public const string _blockDesc = "Out(*EMPTY*)";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// true
		/// </summary>
		public const bool _hasOccurs = true;
		/// <summary>
		/// MMDAQ91200OutBlock2
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// MMDAQ91200OutBlock2
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// Out(*EMPTY*)
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
		/// 종목소분류코드
		/// </summary>
		[XAQueryFieldAttribute("IsuSmclssCode", "종목소분류코드", "char", "3")]
		public string IsuSmclssCode;
		/// <summary>
		/// 종목중분류코드
		/// </summary>
		[XAQueryFieldAttribute("IsuMdclssCode", "종목중분류코드", "char", "2")]
		public string IsuMdclssCode;
		/// <summary>
		/// 종목대중분류명
		/// </summary>
		[XAQueryFieldAttribute("IsuLrgMdclssNm", "종목대중분류명", "char", "40")]
		public string IsuLrgMdclssNm;
		/// <summary>
		/// 종목대중소분류명
		/// </summary>
		[XAQueryFieldAttribute("IsuLrgMidSmclssNm", "종목대중소분류명", "char", "40")]
		public string IsuLrgMidSmclssNm;
		/// <summary>
		/// 단축한글종목명
		/// </summary>
		[XAQueryFieldAttribute("ShtnHanglIsuNm", "단축한글종목명", "char", "40")]
		public string ShtnHanglIsuNm;
		/// <summary>
		/// 위탁증거금율
		/// </summary>
		[XAQueryFieldAttribute("CsgnMgnrt", "위탁증거금율", "double", "26.9")]
		public double CsgnMgnrt;
		/// <summary>
		/// 유지증거금율
		/// </summary>
		[XAQueryFieldAttribute("MaintMgnrt", "유지증거금율", "double", "26.9")]
		public double MaintMgnrt;
		/// <summary>
		/// 현금증거금율
		/// </summary>
		[XAQueryFieldAttribute("MnyMgnrt", "현금증거금율", "double", "26.9")]
		public double MnyMgnrt;
		/// <summary>
		/// 잔여일수
		/// </summary>
		[XAQueryFieldAttribute("RmndDays", "잔여일수", "long", "6")]
		public long RmndDays;

		public static class F
		{
			/// <summary>
			/// 종목소분류코드
			/// </summary>
			public const string IsuSmclssCode = "IsuSmclssCode";
			/// <summary>
			/// 종목중분류코드
			/// </summary>
			public const string IsuMdclssCode = "IsuMdclssCode";
			/// <summary>
			/// 종목대중분류명
			/// </summary>
			public const string IsuLrgMdclssNm = "IsuLrgMdclssNm";
			/// <summary>
			/// 종목대중소분류명
			/// </summary>
			public const string IsuLrgMidSmclssNm = "IsuLrgMidSmclssNm";
			/// <summary>
			/// 단축한글종목명
			/// </summary>
			public const string ShtnHanglIsuNm = "ShtnHanglIsuNm";
			/// <summary>
			/// 위탁증거금율
			/// </summary>
			public const string CsgnMgnrt = "CsgnMgnrt";
			/// <summary>
			/// 유지증거금율
			/// </summary>
			public const string MaintMgnrt = "MaintMgnrt";
			/// <summary>
			/// 현금증거금율
			/// </summary>
			public const string MnyMgnrt = "MnyMgnrt";
			/// <summary>
			/// 잔여일수
			/// </summary>
			public const string RmndDays = "RmndDays";
		}

		public static string[] AllFields = new string[]
		{
			F.IsuSmclssCode,
			F.IsuMdclssCode,
			F.IsuLrgMdclssNm,
			F.IsuLrgMidSmclssNm,
			F.ShtnHanglIsuNm,
			F.CsgnMgnrt,
			F.MaintMgnrt,
			F.MnyMgnrt,
			F.RmndDays,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["IsuSmclssCode"] = new XAQueryFieldInfo("char", IsuSmclssCode, IsuSmclssCode, "종목소분류코드", (decimal)3);
			dict["IsuMdclssCode"] = new XAQueryFieldInfo("char", IsuMdclssCode, IsuMdclssCode, "종목중분류코드", (decimal)2);
			dict["IsuLrgMdclssNm"] = new XAQueryFieldInfo("char", IsuLrgMdclssNm, IsuLrgMdclssNm, "종목대중분류명", (decimal)40);
			dict["IsuLrgMidSmclssNm"] = new XAQueryFieldInfo("char", IsuLrgMidSmclssNm, IsuLrgMidSmclssNm, "종목대중소분류명", (decimal)40);
			dict["ShtnHanglIsuNm"] = new XAQueryFieldInfo("char", ShtnHanglIsuNm, ShtnHanglIsuNm, "단축한글종목명", (decimal)40);
			dict["CsgnMgnrt"] = new XAQueryFieldInfo("double", CsgnMgnrt, CsgnMgnrt.ToString("00000000000000000000000000.000000000"), "위탁증거금율", (decimal)26.9);
			dict["MaintMgnrt"] = new XAQueryFieldInfo("double", MaintMgnrt, MaintMgnrt.ToString("00000000000000000000000000.000000000"), "유지증거금율", (decimal)26.9);
			dict["MnyMgnrt"] = new XAQueryFieldInfo("double", MnyMgnrt, MnyMgnrt.ToString("00000000000000000000000000.000000000"), "현금증거금율", (decimal)26.9);
			dict["RmndDays"] = new XAQueryFieldInfo("long", RmndDays, RmndDays.ToString("d6"), "잔여일수", (decimal)6);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "IsuSmclssCode":
					this.IsuSmclssCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "IsuMdclssCode":
					this.IsuMdclssCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "IsuLrgMdclssNm":
					this.IsuLrgMdclssNm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "IsuLrgMidSmclssNm":
					this.IsuLrgMidSmclssNm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ShtnHanglIsuNm":
					this.ShtnHanglIsuNm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "CsgnMgnrt":
					this.CsgnMgnrt = fieldInfo.FieldValue.ParseDouble("CsgnMgnrt");
				break;

				case "MaintMgnrt":
					this.MaintMgnrt = fieldInfo.FieldValue.ParseDouble("MaintMgnrt");
				break;

				case "MnyMgnrt":
					this.MnyMgnrt = fieldInfo.FieldValue.ParseDouble("MnyMgnrt");
				break;

				case "RmndDays":
					this.RmndDays = fieldInfo.FieldValue.ParseLong("RmndDays");
				break;


			}
		}

		public static XQMMDAQ91200OutBlock2[] ListFromQuery(XQMMDAQ91200 query)
		{
			int count = query.GetBlockCount(XQMMDAQ91200OutBlock2.BlockName);
			List<XQMMDAQ91200OutBlock2> list = new List<XQMMDAQ91200OutBlock2>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQMMDAQ91200OutBlock2 block = new XQMMDAQ91200OutBlock2();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.IsuSmclssCode = query.GetFieldData(block.GetBlockName(), "IsuSmclssCode", i).TrimEnd('?'); // char 3
					block.IsuMdclssCode = query.GetFieldData(block.GetBlockName(), "IsuMdclssCode", i).TrimEnd('?'); // char 2
					block.IsuLrgMdclssNm = query.GetFieldData(block.GetBlockName(), "IsuLrgMdclssNm", i).TrimEnd('?'); // char 40
					block.IsuLrgMidSmclssNm = query.GetFieldData(block.GetBlockName(), "IsuLrgMidSmclssNm", i).TrimEnd('?'); // char 40
					block.ShtnHanglIsuNm = query.GetFieldData(block.GetBlockName(), "ShtnHanglIsuNm", i).TrimEnd('?'); // char 40
					block.CsgnMgnrt = query.GetFieldData(block.GetBlockName(), "CsgnMgnrt", i).ParseDouble("CsgnMgnrt"); // double 26.9
					block.MaintMgnrt = query.GetFieldData(block.GetBlockName(), "MaintMgnrt", i).ParseDouble("MaintMgnrt"); // double 26.9
					block.MnyMgnrt = query.GetFieldData(block.GetBlockName(), "MnyMgnrt", i).ParseDouble("MnyMgnrt"); // double 26.9
					block.RmndDays = query.GetFieldData(block.GetBlockName(), "RmndDays", i).ParseLong("RmndDays"); // long 6

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
			if (IsuSmclssCode?.Length > 3) return false; // char 3
			if (IsuMdclssCode?.Length > 2) return false; // char 2
			if (IsuLrgMdclssNm?.Length > 40) return false; // char 40
			if (IsuLrgMidSmclssNm?.Length > 40) return false; // char 40
			if (ShtnHanglIsuNm?.Length > 40) return false; // char 40
			// CsgnMgnrt double 26.9
			// MaintMgnrt double 26.9
			// MnyMgnrt double 26.9
			if (RmndDays.ToString().Length > 6) return false; // long 6

			return true;
		}

		public void CopyTo(XQMMDAQ91200OutBlock2 block)
		{
			block.IsuSmclssCode = this.IsuSmclssCode;
			block.IsuMdclssCode = this.IsuMdclssCode;
			block.IsuLrgMdclssNm = this.IsuLrgMdclssNm;
			block.IsuLrgMidSmclssNm = this.IsuLrgMidSmclssNm;
			block.ShtnHanglIsuNm = this.ShtnHanglIsuNm;
			block.CsgnMgnrt = this.CsgnMgnrt;
			block.MaintMgnrt = this.MaintMgnrt;
			block.MnyMgnrt = this.MnyMgnrt;
			block.RmndDays = this.RmndDays;

		}
	}

	/// <summary>
	/// 파생상품증거금율조회
	/// </summary>
	public partial class XQMMDAQ91200 : XingQuery
	{
		/// <summary>
		/// MMDAQ91200
		/// </summary>
		public const string _typeName = "MMDAQ91200";
		/// <summary>
		/// 파생상품증거금율조회
		/// </summary>
		public const string _typeDesc = "파생상품증거금율조회";
		/// <summary>
		/// MMDAQ91200
		/// </summary>
		public const string _service = "MMDAQ91200";
		/// <summary>
		/// B
		/// </summary>
		public const string _headType = "B";
		/// <summary>
		/// 임정선
		/// </summary>
		public const string _creator = "임정선";
		/// <summary>
		/// 2014/09/03 15:16:28
		/// </summary>
		public const string _createdDate = "2014/09/03 15:16:28";
		/// <summary>
		/// false
		/// </summary>
		public const bool _attr = false;
		/// <summary>
		/// false
		/// </summary>
		public const bool _block = false;
		/// <summary>
		/// false
		/// </summary>
		public const bool _encrypt = false;
		/// <summary>
		/// false
		/// </summary>
		public const bool _signature = false;

		/// <summary>
		/// MMDAQ91200
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 파생상품증거금율조회
		/// </summary>
		public string TypeDesc => _typeDesc;
		/// <summary>
		/// MMDAQ91200
		/// </summary>
		public string Service => _service;
		/// <summary>
		/// B
		/// </summary>
		public string HeadType => _headType;
		/// <summary>
		/// 임정선
		/// </summary>
		public string Creator => _creator;
		/// <summary>
		/// 2014/09/03 15:16:28
		/// </summary>
		public string CreatedDate => _createdDate;
		/// <summary>
		/// false
		/// </summary>
		public bool Attr => _attr;
		/// <summary>
		/// false
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
		/// 파생상품증거금율조회
		/// </summary>
		public XQMMDAQ91200() : base("MMDAQ91200") { }


		public class XQAllOutBlocks
		{
			public XQMMDAQ91200OutBlock1 OutBlock1 { get; internal set; }
			public XQMMDAQ91200OutBlock2[] OutBlock2 { get; internal set; }
		}

		public static XQAllOutBlocks Get(long RecCnt = default,string IsuLgclssCode = default,string IsuMdclssCode = default)
		{
			using (XQMMDAQ91200 instance = new XQMMDAQ91200())
			{
				instance.SetFieldData(XQMMDAQ91200InBlock1.BlockName, XQMMDAQ91200InBlock1.F.RecCnt, 0, RecCnt.ToString("d5")); // long 5
				instance.SetFieldData(XQMMDAQ91200InBlock1.BlockName, XQMMDAQ91200InBlock1.F.IsuLgclssCode, 0, IsuLgclssCode); // char 2
				instance.SetFieldData(XQMMDAQ91200InBlock1.BlockName, XQMMDAQ91200InBlock1.F.IsuMdclssCode, 0, IsuMdclssCode); // char 2

				if (instance.Request() < 0)
				{
					return null;
				}

				XQAllOutBlocks results = new XQAllOutBlocks();
				results.OutBlock1 = instance.GetBlock1();
				if (results.OutBlock1.IsValidData == false)
				{
					return null;
				}

				results.OutBlock2 = instance.GetBlock2s();
				return results;
			}
		}

		public static XQAllOutBlocks ReadFromDB(string tableNamePostfix = null /*, long RecCnt = default,string IsuLgclssCode = default,string IsuMdclssCode = default */)
		{
			using (XQMMDAQ91200 instance = new XQMMDAQ91200())
			{

				XQAllOutBlocks results = new XQAllOutBlocks();

				string tableName = (tableNamePostfix == null) ? "XQMMDAQ91200OutBlock1" : $"XQMMDAQ91200OutBlock1_{tableNamePostfix}";
				QueryOption qo = new QueryOption(tableName);
				results.OutBlock1 = instance.Select<XQMMDAQ91200OutBlock1>(qo);

				tableName = (tableNamePostfix == null) ? "XQMMDAQ91200OutBlock2" : $"XQMMDAQ91200OutBlock2_{tableNamePostfix}";
				qo = new QueryOption(tableName);
				results.OutBlock2 = instance.SelectMany<XQMMDAQ91200OutBlock2>(qo);
				return results;
			}
		}

		public bool SetBlock(XQMMDAQ91200InBlock1 block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "RecCnt", 0, block.RecCnt.ToString("d5")); // long 5
			_xaQuery.SetFieldData(block.GetBlockName(), "IsuLgclssCode", 0, block.IsuLgclssCode); // char 2
			_xaQuery.SetFieldData(block.GetBlockName(), "IsuMdclssCode", 0, block.IsuMdclssCode); // char 2

			return true;
		}

		public XQMMDAQ91200OutBlock1 GetBlock1()
		{
			XQMMDAQ91200OutBlock1 instance = XQMMDAQ91200OutBlock1.FromQuery(this);
			return instance;

		}

		public XQMMDAQ91200OutBlock2[] GetBlock2s()
		{
			XQMMDAQ91200OutBlock2[] instance = XQMMDAQ91200OutBlock2.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQMMDAQ91200OutBlock1),
			typeof(XQMMDAQ91200OutBlock2),

		};

	}

}
