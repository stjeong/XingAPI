using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt2106InBlock : XingBlock
	{
		/// <summary>
		/// t2106InBlock
		/// </summary>
		public const string _blockName = "t2106InBlock";
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
		/// t2106InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t2106InBlock
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
		[XAQueryFieldAttribute("종목코드")]
		public string code;
		/// <summary>
		/// 건수
		/// </summary>
		[XAQueryFieldAttribute("건수")]
		public string nrec;

		public static class F
		{
			/// <summary>
			/// 종목코드
			/// </summary>
			public const string code = "code";
			/// <summary>
			/// 건수
			/// </summary>
			public const string nrec = "nrec";
		}

		public static string[] AllFields = new string[]
		{
			F.code,
			F.nrec,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["code"] = new XAQueryFieldInfo("char", code, code, "종목코드", (decimal)8);
			dict["nrec"] = new XAQueryFieldInfo("char", nrec, nrec, "건수", (decimal)2);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "code":
					this.code = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "nrec":
					this.nrec = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (code?.Length > 8) return false; // char 8
			if (nrec?.Length > 2) return false; // char 2

			return true;
		}
	}

	public partial class XQt2106InBlock1 : XingBlock
	{
		/// <summary>
		/// t2106InBlock1
		/// </summary>
		public const string _blockName = "t2106InBlock1";
		/// <summary>
		/// 기본입력1
		/// </summary>
		public const string _blockDesc = "기본입력1";
		/// <summary>
		/// input
		/// </summary>
		public const string _blockType = "input";
		/// <summary>
		/// true
		/// </summary>
		public const bool _hasOccurs = true;
		/// <summary>
		/// t2106InBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t2106InBlock1
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// 기본입력1
		/// </summary>
		public string BlockDesc => _blockDesc;
		/// <summary>
		/// input
		/// </summary>
		public string BlockType => _blockType;
		/// <summary>
		/// true
		/// </summary>
		public bool HasOccurs => _hasOccurs;

		/// <summary>
		/// 인덱스
		/// </summary>
		[XAQueryFieldAttribute("인덱스")]
		public char indx;
		/// <summary>
		/// 조건구분
		/// </summary>
		[XAQueryFieldAttribute("조건구분")]
		public char gubn;
		/// <summary>
		/// 데이타1
		/// </summary>
		[XAQueryFieldAttribute("데이타1")]
		public char dat1;
		/// <summary>
		/// 데이타2
		/// </summary>
		[XAQueryFieldAttribute("데이타2")]
		public string dat2;

		public static class F
		{
			/// <summary>
			/// 인덱스
			/// </summary>
			public const string indx = "indx";
			/// <summary>
			/// 조건구분
			/// </summary>
			public const string gubn = "gubn";
			/// <summary>
			/// 데이타1
			/// </summary>
			public const string dat1 = "dat1";
			/// <summary>
			/// 데이타2
			/// </summary>
			public const string dat2 = "dat2";
		}

		public static string[] AllFields = new string[]
		{
			F.indx,
			F.gubn,
			F.dat1,
			F.dat2,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["indx"] = new XAQueryFieldInfo("char", indx, indx.ToString(), "인덱스", (decimal)1);
			dict["gubn"] = new XAQueryFieldInfo("char", gubn, gubn.ToString(), "조건구분", (decimal)1);
			dict["dat1"] = new XAQueryFieldInfo("char", dat1, dat1.ToString(), "데이타1", (decimal)1);
			dict["dat2"] = new XAQueryFieldInfo("char", dat2, dat2, "데이타2", (decimal)8);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "indx":
					this.indx = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "gubn":
					this.gubn = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "dat1":
					this.dat1 = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "dat2":
					this.dat2 = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			// indx char 1
			// gubn char 1
			// dat1 char 1
			if (dat2?.Length > 8) return false; // char 8

			return true;
		}
	}

	public partial class XQt2106OutBlock : XingBlock
	{
		/// <summary>
		/// t2106OutBlock
		/// </summary>
		public const string _blockName = "t2106OutBlock";
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
		/// t2106OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t2106OutBlock
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
		/// 출력건수
		/// </summary>
		[XAQueryFieldAttribute("출력건수")]
		public string nrec;

		public static class F
		{
			/// <summary>
			/// 출력건수
			/// </summary>
			public const string nrec = "nrec";
		}

		public static string[] AllFields = new string[]
		{
			F.nrec,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["nrec"] = new XAQueryFieldInfo("char", nrec, nrec, "출력건수", (decimal)2);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "nrec":
					this.nrec = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt2106OutBlock FromQuery(XQt2106 query)
		{
			XQt2106OutBlock block = new XQt2106OutBlock();
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
				block.nrec = query.GetFieldData(block.GetBlockName(), "nrec", 0).TrimEnd('?'); // char 2

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (nrec?.Length > 2) return false; // char 2

			return true;
		}
	}

	public partial class XQt2106OutBlock1 : XingBlock
	{
		/// <summary>
		/// t2106OutBlock1
		/// </summary>
		public const string _blockName = "t2106OutBlock1";
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
		/// t2106OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t2106OutBlock1
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
		/// 인덱스
		/// </summary>
		[XAQueryFieldAttribute("인덱스")]
		public char indx;
		/// <summary>
		/// 조건구분
		/// </summary>
		[XAQueryFieldAttribute("조건구분")]
		public char gubn;
		/// <summary>
		/// 출력값
		/// </summary>
		[XAQueryFieldAttribute("출력값")]
		public string vals;

		public static class F
		{
			/// <summary>
			/// 인덱스
			/// </summary>
			public const string indx = "indx";
			/// <summary>
			/// 조건구분
			/// </summary>
			public const string gubn = "gubn";
			/// <summary>
			/// 출력값
			/// </summary>
			public const string vals = "vals";
		}

		public static string[] AllFields = new string[]
		{
			F.indx,
			F.gubn,
			F.vals,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["indx"] = new XAQueryFieldInfo("char", indx, indx.ToString(), "인덱스", (decimal)1);
			dict["gubn"] = new XAQueryFieldInfo("char", gubn, gubn.ToString(), "조건구분", (decimal)1);
			dict["vals"] = new XAQueryFieldInfo("char", vals, vals, "출력값", (decimal)8);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "indx":
					this.indx = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "gubn":
					this.gubn = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "vals":
					this.vals = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt2106OutBlock1[] ListFromQuery(XQt2106 query)
		{
			int count = query.GetBlockCount(XQt2106OutBlock1.BlockName);
			List<XQt2106OutBlock1> list = new List<XQt2106OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt2106OutBlock1 block = new XQt2106OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.indx = query.GetFieldData(block.GetBlockName(), "indx", i).FirstOrDefault(); // char 1
					block.gubn = query.GetFieldData(block.GetBlockName(), "gubn", i).FirstOrDefault(); // char 1
					block.vals = query.GetFieldData(block.GetBlockName(), "vals", i).TrimEnd('?'); // char 8

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
			// indx char 1
			// gubn char 1
			if (vals?.Length > 8) return false; // char 8

			return true;
		}
	}

	/// <summary>
	/// 선물/옵션현재가시세메모(t2106)
	/// </summary>
	public partial class XQt2106 : XingQuery
	{
		/// <summary>
		/// t2106
		/// </summary>
		public const string _typeName = "t2106";
		/// <summary>
		/// 선물/옵션현재가시세메모(t2106)
		/// </summary>
		public const string _typeDesc = "선물/옵션현재가시세메모(t2106)";
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
		/// t2106
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 선물/옵션현재가시세메모(t2106)
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

		public XQt2106() : base("t2106") { }



		public bool SetBlock(XQt2106InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "code", 0, block.code); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "nrec", 0, block.nrec); // char 2

			return true;
		}

		public bool SetBlock(XQt2106InBlock1 block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

				_xaQuery.SetFieldData(block.GetBlockName(), "indx", 0, block.indx.ToString()); // char 1
				_xaQuery.SetFieldData(block.GetBlockName(), "gubn", 0, block.gubn.ToString()); // char 1
				_xaQuery.SetFieldData(block.GetBlockName(), "dat1", 0, block.dat1.ToString()); // char 1
				_xaQuery.SetFieldData(block.GetBlockName(), "dat2", 0, block.dat2); // char 8

			return true;
		}

		public XQt2106OutBlock GetBlock()
		{
			XQt2106OutBlock instance = XQt2106OutBlock.FromQuery(this);
			return instance;

		}

		public XQt2106OutBlock1[] GetBlock1s()
		{
			XQt2106OutBlock1[] instance = XQt2106OutBlock1.ListFromQuery(this);
			return instance;

		}


	}

}
