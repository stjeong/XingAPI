using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt8431InBlock : XingBlock
	{
		/// <summary>
		/// t8431InBlock
		/// </summary>
		public const string _blockName = "t8431InBlock";
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
		/// t8431InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t8431InBlock
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
		/// Dummy
		/// </summary>
		[XAQueryFieldAttribute("dummy", "Dummy", "char", "1")]
		public char dummy;

		public static class F
		{
			/// <summary>
			/// Dummy
			/// </summary>
			public const string dummy = "dummy";
		}

		public static string[] AllFields = new string[]
		{
			F.dummy,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["dummy"] = new XAQueryFieldInfo("char", dummy, dummy.ToString(), "Dummy", (decimal)1);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "dummy":
					this.dummy = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public bool VerifyData()
		{
			// dummy char 1

			return true;
		}

		public void CopyTo(XQt8431InBlock block)
		{
			block.dummy = this.dummy;

		}
	}

	public partial class XQt8431OutBlock : XingBlock
	{
		/// <summary>
		/// t8431OutBlock
		/// </summary>
		public const string _blockName = "t8431OutBlock";
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
		/// t8431OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t8431OutBlock
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
		/// 상한가
		/// </summary>
		[XAQueryFieldAttribute("uplmtprice", "상한가", "long", "8")]
		public long uplmtprice;
		/// <summary>
		/// 하한가
		/// </summary>
		[XAQueryFieldAttribute("dnlmtprice", "하한가", "long", "8")]
		public long dnlmtprice;
		/// <summary>
		/// 전일종가
		/// </summary>
		[XAQueryFieldAttribute("jnilclose", "전일종가", "long", "8")]
		public long jnilclose;
		/// <summary>
		/// 기준가
		/// </summary>
		[XAQueryFieldAttribute("recprice", "기준가", "long", "8")]
		public long recprice;

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
			/// 상한가
			/// </summary>
			public const string uplmtprice = "uplmtprice";
			/// <summary>
			/// 하한가
			/// </summary>
			public const string dnlmtprice = "dnlmtprice";
			/// <summary>
			/// 전일종가
			/// </summary>
			public const string jnilclose = "jnilclose";
			/// <summary>
			/// 기준가
			/// </summary>
			public const string recprice = "recprice";
		}

		public static string[] AllFields = new string[]
		{
			F.hname,
			F.shcode,
			F.expcode,
			F.uplmtprice,
			F.dnlmtprice,
			F.jnilclose,
			F.recprice,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["hname"] = new XAQueryFieldInfo("char", hname, hname, "종목명", (decimal)40);
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)6);
			dict["expcode"] = new XAQueryFieldInfo("char", expcode, expcode, "확장코드", (decimal)12);
			dict["uplmtprice"] = new XAQueryFieldInfo("long", uplmtprice, uplmtprice.ToString("d8"), "상한가", (decimal)8);
			dict["dnlmtprice"] = new XAQueryFieldInfo("long", dnlmtprice, dnlmtprice.ToString("d8"), "하한가", (decimal)8);
			dict["jnilclose"] = new XAQueryFieldInfo("long", jnilclose, jnilclose.ToString("d8"), "전일종가", (decimal)8);
			dict["recprice"] = new XAQueryFieldInfo("long", recprice, recprice.ToString("d8"), "기준가", (decimal)8);

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

				case "uplmtprice":
					this.uplmtprice = fieldInfo.FieldValue.ParseLong("uplmtprice");
				break;

				case "dnlmtprice":
					this.dnlmtprice = fieldInfo.FieldValue.ParseLong("dnlmtprice");
				break;

				case "jnilclose":
					this.jnilclose = fieldInfo.FieldValue.ParseLong("jnilclose");
				break;

				case "recprice":
					this.recprice = fieldInfo.FieldValue.ParseLong("recprice");
				break;


			}
		}

		public static XQt8431OutBlock[] ListFromQuery(XQt8431 query)
		{
			int count = query.GetBlockCount(XQt8431OutBlock.BlockName);
			List<XQt8431OutBlock> list = new List<XQt8431OutBlock>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt8431OutBlock block = new XQt8431OutBlock();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.hname = query.GetFieldData(block.GetBlockName(), "hname", i).TrimEnd('?'); // char 40
					block.shcode = query.GetFieldData(block.GetBlockName(), "shcode", i).TrimEnd('?'); // char 6
					block.expcode = query.GetFieldData(block.GetBlockName(), "expcode", i).TrimEnd('?'); // char 12
					block.uplmtprice = query.GetFieldData(block.GetBlockName(), "uplmtprice", i).ParseLong("uplmtprice"); // long 8
					block.dnlmtprice = query.GetFieldData(block.GetBlockName(), "dnlmtprice", i).ParseLong("dnlmtprice"); // long 8
					block.jnilclose = query.GetFieldData(block.GetBlockName(), "jnilclose", i).ParseLong("jnilclose"); // long 8
					block.recprice = query.GetFieldData(block.GetBlockName(), "recprice", i).ParseLong("recprice"); // long 8

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
			if (uplmtprice.ToString().Length > 8) return false; // long 8
			if (dnlmtprice.ToString().Length > 8) return false; // long 8
			if (jnilclose.ToString().Length > 8) return false; // long 8
			if (recprice.ToString().Length > 8) return false; // long 8

			return true;
		}

		public void CopyTo(XQt8431OutBlock block)
		{
			block.hname = this.hname;
			block.shcode = this.shcode;
			block.expcode = this.expcode;
			block.uplmtprice = this.uplmtprice;
			block.dnlmtprice = this.dnlmtprice;
			block.jnilclose = this.jnilclose;
			block.recprice = this.recprice;

		}
	}

	/// <summary>
	/// ELW종목조회(t8431)
	/// </summary>
	public partial class XQt8431 : XingQuery
	{
		/// <summary>
		/// t8431
		/// </summary>
		public const string _typeName = "t8431";
		/// <summary>
		/// ELW종목조회(t8431)
		/// </summary>
		public const string _typeDesc = "ELW종목조회(t8431)";
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
		/// t8431
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// ELW종목조회(t8431)
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
		/// ELW종목조회(t8431)
		/// </summary>
		public XQt8431() : base("t8431") { }


		public static XQt8431OutBlock[] Get(char dummy = default)
		{
			using (XQt8431 instance = new XQt8431())
			{
				instance.SetFieldData(XQt8431InBlock.BlockName, XQt8431InBlock.F.dummy, 0, dummy.ToString()); // char 1

				if (instance.Request() < 0)
				{
					return null;
				}

				var outBlock = instance.GetBlocks();
				return outBlock;
			}
		}

		public static XQt8431OutBlock[] ReadFromDB(string tableNamePostfix = null /*, char dummy = default */)
		{
			using (XQt8431 instance = new XQt8431())
			{

				string tableName = (tableNamePostfix == null) ? "XQt8431OutBlock" : $"XQt8431OutBlock_{tableNamePostfix}";
				QueryOption qo = new QueryOption(tableName);
				// if (dummy != default) qo.Add("dummy", dummy);


				var outBlock = instance.SelectMany<XQt8431OutBlock>(qo);
				return outBlock;
			}
		}

		public bool SetBlock(XQt8431InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "dummy", 0, block.dummy.ToString()); // char 1

			return true;
		}

		public XQt8431OutBlock[] GetBlocks()
		{
			XQt8431OutBlock[] instance = XQt8431OutBlock.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt8431OutBlock),

		};

	}

}
