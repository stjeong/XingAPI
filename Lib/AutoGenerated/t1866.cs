using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1866InBlock : XingBlock
	{
		/// <summary>
		/// t1866InBlock
		/// </summary>
		static readonly string _blockName = "t1866InBlock";
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
		/// t1866InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1866InBlock
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
		/// 로그인ID
		/// </summary>
		[XAQueryFieldAttribute("로그인ID")]
		public string user_id;
		/// <summary>
		/// 조회구분
		/// </summary>
		[XAQueryFieldAttribute("조회구분")]
		public char gb;
		/// <summary>
		/// 그룹명
		/// </summary>
		[XAQueryFieldAttribute("그룹명")]
		public string group_name;
		/// <summary>
		/// 연속여부
		/// </summary>
		[XAQueryFieldAttribute("연속여부")]
		public char cont;
		/// <summary>
		/// 연속키
		/// </summary>
		[XAQueryFieldAttribute("연속키")]
		public string cont_key;

		public static class F
		{
			/// <summary>
			/// 로그인ID
			/// </summary>
			public const string user_id = "user_id";
			/// <summary>
			/// 조회구분
			/// </summary>
			public const string gb = "gb";
			/// <summary>
			/// 그룹명
			/// </summary>
			public const string group_name = "group_name";
			/// <summary>
			/// 연속여부
			/// </summary>
			public const string cont = "cont";
			/// <summary>
			/// 연속키
			/// </summary>
			public const string cont_key = "cont_key";
		}

		public static string[] AllFields = new string[]
		{
			F.user_id,
			F.gb,
			F.group_name,
			F.cont,
			F.cont_key,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["user_id"] = new XAQueryFieldInfo("char", user_id, user_id, "로그인ID", (decimal)8);
			dict["gb"] = new XAQueryFieldInfo("char", gb, gb.ToString(), "조회구분", (decimal)1);
			dict["group_name"] = new XAQueryFieldInfo("char", group_name, group_name, "그룹명", (decimal)40);
			dict["cont"] = new XAQueryFieldInfo("char", cont, cont.ToString(), "연속여부", (decimal)1);
			dict["cont_key"] = new XAQueryFieldInfo("char", cont_key, cont_key, "연속키", (decimal)40);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "user_id":
					this.user_id = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "gb":
					this.gb = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "group_name":
					this.group_name = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cont":
					this.cont = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "cont_key":
					this.cont_key = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (user_id.Length > 8) return false; // char 8
			// gb char 1
			if (group_name.Length > 40) return false; // char 40
			// cont char 1
			if (cont_key.Length > 40) return false; // char 40

			return true;
		}
	}

	public partial class XQt1866OutBlock : XingBlock
	{
		/// <summary>
		/// t1866OutBlock
		/// </summary>
		static readonly string _blockName = "t1866OutBlock";
		/// <summary>
		/// 출력
		/// </summary>
		static readonly string _blockDesc = "출력";
		/// <summary>
		/// output
		/// </summary>
		static readonly string _blockType = "output";
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _hasOccurs = false;
		/// <summary>
		/// t1866OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1866OutBlock
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
		/// 저장조건수
		/// </summary>
		[XAQueryFieldAttribute("저장조건수")]
		public long result_count;
		/// <summary>
		/// 연속여부
		/// </summary>
		[XAQueryFieldAttribute("연속여부")]
		public char cont;
		/// <summary>
		/// 연속키
		/// </summary>
		[XAQueryFieldAttribute("연속키")]
		public string cont_key;

		public static class F
		{
			/// <summary>
			/// 저장조건수
			/// </summary>
			public const string result_count = "result_count";
			/// <summary>
			/// 연속여부
			/// </summary>
			public const string cont = "cont";
			/// <summary>
			/// 연속키
			/// </summary>
			public const string cont_key = "cont_key";
		}

		public static string[] AllFields = new string[]
		{
			F.result_count,
			F.cont,
			F.cont_key,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["result_count"] = new XAQueryFieldInfo("long", result_count, result_count.ToString("d5"), "저장조건수", (decimal)5);
			dict["cont"] = new XAQueryFieldInfo("char", cont, cont.ToString(), "연속여부", (decimal)1);
			dict["cont_key"] = new XAQueryFieldInfo("char", cont_key, cont_key, "연속키", (decimal)40);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "result_count":
					this.result_count = fieldInfo.FieldValue.ParseLong("result_count");
				break;

				case "cont":
					this.cont = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "cont_key":
					this.cont_key = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt1866OutBlock FromQuery(XQt1866 query)
		{
			XQt1866OutBlock block = new XQt1866OutBlock();
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
				block.result_count = query.GetFieldData(block.GetBlockName(), "result_count", 0).ParseLong("result_count"); // long 5
				block.cont = query.GetFieldData(block.GetBlockName(), "cont", 0).FirstOrDefault(); // char 1
				block.cont_key = query.GetFieldData(block.GetBlockName(), "cont_key", 0).TrimEnd('?'); // char 40

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (result_count.ToString().Length > 5) return false; // long 5
			// cont char 1
			if (cont_key.Length > 40) return false; // char 40

			return true;
		}
	}

	public partial class XQt1866OutBlock1 : XingBlock
	{
		/// <summary>
		/// t1866OutBlock1
		/// </summary>
		static readonly string _blockName = "t1866OutBlock1";
		/// <summary>
		/// 출력1
		/// </summary>
		static readonly string _blockDesc = "출력1";
		/// <summary>
		/// output
		/// </summary>
		static readonly string _blockType = "output";
		/// <summary>
		/// true
		/// </summary>
		static readonly bool _hasOccurs = true;
		/// <summary>
		/// t1866OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1866OutBlock1
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
		/// 서버저장인덱스
		/// </summary>
		[XAQueryFieldAttribute("서버저장인덱스")]
		public string query_index;
		/// <summary>
		/// 그룹명
		/// </summary>
		[XAQueryFieldAttribute("그룹명")]
		public string group_name;
		/// <summary>
		/// 조건저장명
		/// </summary>
		[XAQueryFieldAttribute("조건저장명")]
		public string query_name;

		public static class F
		{
			/// <summary>
			/// 서버저장인덱스
			/// </summary>
			public const string query_index = "query_index";
			/// <summary>
			/// 그룹명
			/// </summary>
			public const string group_name = "group_name";
			/// <summary>
			/// 조건저장명
			/// </summary>
			public const string query_name = "query_name";
		}

		public static string[] AllFields = new string[]
		{
			F.query_index,
			F.group_name,
			F.query_name,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["query_index"] = new XAQueryFieldInfo("char", query_index, query_index, "서버저장인덱스", (decimal)12);
			dict["group_name"] = new XAQueryFieldInfo("char", group_name, group_name, "그룹명", (decimal)40);
			dict["query_name"] = new XAQueryFieldInfo("char", query_name, query_name, "조건저장명", (decimal)40);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "query_index":
					this.query_index = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "group_name":
					this.group_name = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "query_name":
					this.query_name = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt1866OutBlock1[] ListFromQuery(XQt1866 query)
		{
			int count = query.GetBlockCount(XQt1866OutBlock1.BlockName);
			List<XQt1866OutBlock1> list = new List<XQt1866OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1866OutBlock1 block = new XQt1866OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.query_index = query.GetFieldData(block.GetBlockName(), "query_index", i).TrimEnd('?'); // char 12
					block.group_name = query.GetFieldData(block.GetBlockName(), "group_name", i).TrimEnd('?'); // char 40
					block.query_name = query.GetFieldData(block.GetBlockName(), "query_name", i).TrimEnd('?'); // char 40

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
			if (query_index.Length > 12) return false; // char 12
			if (group_name.Length > 40) return false; // char 40
			if (query_name.Length > 40) return false; // char 40

			return true;
		}
	}

	public partial class XQt1866 : XingQuery
	{
		/// <summary>
		/// t1866
		/// </summary>
		static readonly string _typeName = "t1866";
		/// <summary>
		/// 서버저장조건리스트조회(API)(t1866)
		/// </summary>
		static readonly string _typeDesc = "서버저장조건리스트조회(API)(t1866)";
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
		/// true
		/// </summary>
		static readonly bool _encrypt = true;
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _signature = false;

		/// <summary>
		/// t1866
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 서버저장조건리스트조회(API)(t1866)
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
		/// true
		/// </summary>
		public bool Encrypt => _encrypt;
		/// <summary>
		/// false
		/// </summary>
		public bool Signature => _signature;

		public XQt1866() : base("t1866") { }


		public bool SetFields(XQt1866InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "user_id", 0, block.user_id); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "gb", 0, block.gb.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "group_name", 0, block.group_name); // char 40
			_xaQuery.SetFieldData(block.GetBlockName(), "cont", 0, block.cont.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "cont_key", 0, block.cont_key); // char 40

			return true;
		}

		public XQt1866OutBlock GetBlock()
		{
			XQt1866OutBlock instance = XQt1866OutBlock.FromQuery(this);
			return instance;

		}

		public XQt1866OutBlock1[] GetBlock1s()
		{
			XQt1866OutBlock1[] instance = XQt1866OutBlock1.ListFromQuery(this);
			return instance;

		}


	}

}
