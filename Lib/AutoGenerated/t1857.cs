using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1857InBlock : XingBlock
	{
		/// <summary>
		/// t1857InBlock
		/// </summary>
		public const string _blockName = "t1857InBlock";
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
		/// t1857InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1857InBlock
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
		/// 실시간구분(0:조회 1:실시간)
		/// </summary>
		[XAQueryFieldAttribute("sRealFlag", "실시간구분(0:조회 1:실시간)", "char", "1")]
		public char sRealFlag;
		/// <summary>
		/// 종목검색구분(F:파일 S:서버)
		/// </summary>
		[XAQueryFieldAttribute("sSearchFlag", "종목검색구분(F:파일 S:서버)", "char", "1")]
		public char sSearchFlag;
		/// <summary>
		/// 종목검색입력값
		/// </summary>
		[XAQueryFieldAttribute("query_index", "종목검색입력값", "char", "256")]
		public string query_index;

		public static class F
		{
			/// <summary>
			/// 실시간구분(0:조회 1:실시간)
			/// </summary>
			public const string sRealFlag = "sRealFlag";
			/// <summary>
			/// 종목검색구분(F:파일 S:서버)
			/// </summary>
			public const string sSearchFlag = "sSearchFlag";
			/// <summary>
			/// 종목검색입력값
			/// </summary>
			public const string query_index = "query_index";
		}

		public static string[] AllFields = new string[]
		{
			F.sRealFlag,
			F.sSearchFlag,
			F.query_index,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["sRealFlag"] = new XAQueryFieldInfo("char", sRealFlag, sRealFlag.ToString(), "실시간구분(0:조회 1:실시간)", (decimal)1);
			dict["sSearchFlag"] = new XAQueryFieldInfo("char", sSearchFlag, sSearchFlag.ToString(), "종목검색구분(F:파일 S:서버)", (decimal)1);
			dict["query_index"] = new XAQueryFieldInfo("char", query_index, query_index, "종목검색입력값", (decimal)256);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "sRealFlag":
					this.sRealFlag = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "sSearchFlag":
					this.sSearchFlag = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "query_index":
					this.query_index = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			// sRealFlag char 1
			// sSearchFlag char 1
			if (query_index?.Length > 256) return false; // char 256

			return true;
		}

		public void CopyTo(XQt1857InBlock block)
		{
			block.sRealFlag = this.sRealFlag;
			block.sSearchFlag = this.sSearchFlag;
			block.query_index = this.query_index;

		}
	}

	public partial class XQt1857OutBlock : XingBlock
	{
		/// <summary>
		/// t1857OutBlock
		/// </summary>
		public const string _blockName = "t1857OutBlock";
		/// <summary>
		/// Out(*EMPTY*)
		/// </summary>
		public const string _blockDesc = "Out(*EMPTY*)";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// false
		/// </summary>
		public const bool _hasOccurs = false;
		/// <summary>
		/// t1857OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1857OutBlock
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
		/// false
		/// </summary>
		public bool HasOccurs => _hasOccurs;

		/// <summary>
		/// 검색종목수
		/// </summary>
		[XAQueryFieldAttribute("result_count", "검색종목수", "long", "5")]
		public long result_count;
		/// <summary>
		/// 포착시간
		/// </summary>
		[XAQueryFieldAttribute("result_time", "포착시간", "char", "6")]
		public string result_time;
		/// <summary>
		/// 실시간키
		/// </summary>
		[XAQueryFieldAttribute("AlertNum", "실시간키", "char", "11")]
		public string AlertNum;

		public static class F
		{
			/// <summary>
			/// 검색종목수
			/// </summary>
			public const string result_count = "result_count";
			/// <summary>
			/// 포착시간
			/// </summary>
			public const string result_time = "result_time";
			/// <summary>
			/// 실시간키
			/// </summary>
			public const string AlertNum = "AlertNum";
		}

		public static string[] AllFields = new string[]
		{
			F.result_count,
			F.result_time,
			F.AlertNum,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["result_count"] = new XAQueryFieldInfo("long", result_count, result_count.ToString("d5"), "검색종목수", (decimal)5);
			dict["result_time"] = new XAQueryFieldInfo("char", result_time, result_time, "포착시간", (decimal)6);
			dict["AlertNum"] = new XAQueryFieldInfo("char", AlertNum, AlertNum, "실시간키", (decimal)11);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "result_count":
					this.result_count = fieldInfo.FieldValue.ParseLong("result_count");
				break;

				case "result_time":
					this.result_time = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "AlertNum":
					this.AlertNum = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt1857OutBlock FromQuery(XQt1857 query)
		{
			XQt1857OutBlock block = new XQt1857OutBlock();
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
				block.result_time = query.GetFieldData(block.GetBlockName(), "result_time", 0).TrimEnd('?'); // char 6
				block.AlertNum = query.GetFieldData(block.GetBlockName(), "AlertNum", 0).TrimEnd('?'); // char 11

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (result_count.ToString().Length > 5) return false; // long 5
			if (result_time?.Length > 6) return false; // char 6
			if (AlertNum?.Length > 11) return false; // char 11

			return true;
		}

		public void CopyTo(XQt1857OutBlock block)
		{
			block.result_count = this.result_count;
			block.result_time = this.result_time;
			block.AlertNum = this.AlertNum;

		}
	}

	public partial class XQt1857OutBlock1 : XingBlock
	{
		/// <summary>
		/// t1857OutBlock1
		/// </summary>
		public const string _blockName = "t1857OutBlock1";
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
		/// t1857OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1857OutBlock1
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
		/// 종목코드
		/// </summary>
		[XAQueryFieldAttribute("shcode", "종목코드", "char", "7")]
		public string shcode;
		/// <summary>
		/// 종목명
		/// </summary>
		[XAQueryFieldAttribute("hname", "종목명", "char", "40")]
		public string hname;
		/// <summary>
		/// 현재가
		/// </summary>
		[XAQueryFieldAttribute("price", "현재가", "long", "9")]
		public long price;
		/// <summary>
		/// 전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("sign", "전일대비구분", "char", "1")]
		public char sign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[XAQueryFieldAttribute("change", "전일대비", "long", "9")]
		public long change;
		/// <summary>
		/// 등락율
		/// </summary>
		[XAQueryFieldAttribute("diff", "등락율", "float", "6")]
		public float diff;
		/// <summary>
		/// 거래량
		/// </summary>
		[XAQueryFieldAttribute("volume", "거래량", "long", "12")]
		public long volume;
		/// <summary>
		/// 종목상태(N:진입 R:재진입 O:이탈)
		/// </summary>
		[XAQueryFieldAttribute("JobFlag", "종목상태(N:진입 R:재진입 O:이탈)", "char", "1")]
		public char JobFlag;

		public static class F
		{
			/// <summary>
			/// 종목코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 종목명
			/// </summary>
			public const string hname = "hname";
			/// <summary>
			/// 현재가
			/// </summary>
			public const string price = "price";
			/// <summary>
			/// 전일대비구분
			/// </summary>
			public const string sign = "sign";
			/// <summary>
			/// 전일대비
			/// </summary>
			public const string change = "change";
			/// <summary>
			/// 등락율
			/// </summary>
			public const string diff = "diff";
			/// <summary>
			/// 거래량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// 종목상태(N:진입 R:재진입 O:이탈)
			/// </summary>
			public const string JobFlag = "JobFlag";
		}

		public static string[] AllFields = new string[]
		{
			F.shcode,
			F.hname,
			F.price,
			F.sign,
			F.change,
			F.diff,
			F.volume,
			F.JobFlag,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "종목코드", (decimal)7);
			dict["hname"] = new XAQueryFieldInfo("char", hname, hname, "종목명", (decimal)40);
			dict["price"] = new XAQueryFieldInfo("long", price, price.ToString("d9"), "현재가", (decimal)9);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("long", change, change.ToString("d9"), "전일대비", (decimal)9);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000"), "등락율", (decimal)6);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "거래량", (decimal)12);
			dict["JobFlag"] = new XAQueryFieldInfo("char", JobFlag, JobFlag.ToString(), "종목상태(N:진입 R:재진입 O:이탈)", (decimal)1);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "hname":
					this.hname = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "price":
					this.price = fieldInfo.FieldValue.ParseLong("price");
				break;

				case "sign":
					this.sign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "change":
					this.change = fieldInfo.FieldValue.ParseLong("change");
				break;

				case "diff":
					this.diff = fieldInfo.FieldValue.ParseFloat("diff");
				break;

				case "volume":
					this.volume = fieldInfo.FieldValue.ParseLong("volume");
				break;

				case "JobFlag":
					this.JobFlag = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public static XQt1857OutBlock1[] ListFromQuery(XQt1857 query)
		{
			int count = query.GetBlockCount(XQt1857OutBlock1.BlockName);
			List<XQt1857OutBlock1> list = new List<XQt1857OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1857OutBlock1 block = new XQt1857OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.shcode = query.GetFieldData(block.GetBlockName(), "shcode", i).TrimEnd('?'); // char 7
					block.hname = query.GetFieldData(block.GetBlockName(), "hname", i).TrimEnd('?'); // char 40
					block.price = query.GetFieldData(block.GetBlockName(), "price", i).ParseLong("price"); // long 9
					block.sign = query.GetFieldData(block.GetBlockName(), "sign", i).FirstOrDefault(); // char 1
					block.change = query.GetFieldData(block.GetBlockName(), "change", i).ParseLong("change"); // long 9
					block.diff = query.GetFieldData(block.GetBlockName(), "diff", i).ParseFloat("diff"); // float 6
					block.volume = query.GetFieldData(block.GetBlockName(), "volume", i).ParseLong("volume"); // long 12
					block.JobFlag = query.GetFieldData(block.GetBlockName(), "JobFlag", i).FirstOrDefault(); // char 1

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
			if (shcode?.Length > 7) return false; // char 7
			if (hname?.Length > 40) return false; // char 40
			if (price.ToString().Length > 9) return false; // long 9
			// sign char 1
			if (change.ToString().Length > 9) return false; // long 9
			// diff float 6
			if (volume.ToString().Length > 12) return false; // long 12
			// JobFlag char 1

			return true;
		}

		public void CopyTo(XQt1857OutBlock1 block)
		{
			block.shcode = this.shcode;
			block.hname = this.hname;
			block.price = this.price;
			block.sign = this.sign;
			block.change = this.change;
			block.diff = this.diff;
			block.volume = this.volume;
			block.JobFlag = this.JobFlag;

		}
	}

	/// <summary>
	/// e종목검색(신버전API용)
	/// </summary>
	public partial class XQt1857 : XingQuery
	{
		/// <summary>
		/// t1857
		/// </summary>
		public const string _typeName = "t1857";
		/// <summary>
		/// e종목검색(신버전API용)
		/// </summary>
		public const string _typeDesc = "e종목검색(신버전API용)";
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
		/// t1857
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// e종목검색(신버전API용)
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
		/// e종목검색(신버전API용)
		/// </summary>
		public XQt1857() : base("t1857") { }


		public class XQAllOutBlocks
		{
			public XQt1857OutBlock OutBlock { get; internal set; }
			public XQt1857OutBlock1[] OutBlock1 { get; internal set; }
		}

		public static XQAllOutBlocks Get(char sRealFlag = default,char sSearchFlag = default,string query_index = default)
		{
			using (XQt1857 instance = new XQt1857())
			{
				instance.SetFieldData(XQt1857InBlock.BlockName, XQt1857InBlock.F.sRealFlag, 0, sRealFlag.ToString()); // char 1
				instance.SetFieldData(XQt1857InBlock.BlockName, XQt1857InBlock.F.sSearchFlag, 0, sSearchFlag.ToString()); // char 1
				instance.SetFieldData(XQt1857InBlock.BlockName, XQt1857InBlock.F.query_index, 0, query_index); // char 256

				if (instance.Request() < 0)
				{
					return null;
				}

				XQAllOutBlocks results = new XQAllOutBlocks();
				results.OutBlock = instance.GetBlock();
				if (results.OutBlock.IsValidData == false)
				{
					return null;
				}

				results.OutBlock1 = instance.GetBlock1s();
				return results;
			}
		}

		public static XQAllOutBlocks ReadFromDB(string tableNamePostfix = null /*, char sRealFlag = default,char sSearchFlag = default,string query_index = default */)
		{
			using (XQt1857 instance = new XQt1857())
			{

				XQAllOutBlocks results = new XQAllOutBlocks();

				string tableName = (tableNamePostfix == null) ? "XQt1857OutBlock" : $"XQt1857OutBlock_{tableNamePostfix}";
				QueryOption qo = new QueryOption(tableName);
				results.OutBlock = instance.Select<XQt1857OutBlock>(qo);

				tableName = (tableNamePostfix == null) ? "XQt1857OutBlock1" : $"XQt1857OutBlock1_{tableNamePostfix}";
				qo = new QueryOption(tableName);
				results.OutBlock1 = instance.SelectMany<XQt1857OutBlock1>(qo);
				return results;
			}
		}

		public bool SetBlock(XQt1857InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "sRealFlag", 0, block.sRealFlag.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "sSearchFlag", 0, block.sSearchFlag.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "query_index", 0, block.query_index); // char 256

			return true;
		}

		public XQt1857OutBlock GetBlock()
		{
			XQt1857OutBlock instance = XQt1857OutBlock.FromQuery(this);
			return instance;

		}

		public XQt1857OutBlock1[] GetBlock1s()
		{
			XQt1857OutBlock1[] instance = XQt1857OutBlock1.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt1857OutBlock),
			typeof(XQt1857OutBlock1),

		};

	}

}
