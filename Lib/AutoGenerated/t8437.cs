using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt8437InBlock : XingBlock
	{
		/// <summary>
		/// t8437InBlock
		/// </summary>
		public const string _blockName = "t8437InBlock";
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
		/// t8437InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t8437InBlock
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
		/// 구분(NF/NC/NM/NO)
		/// </summary>
		[XAQueryFieldAttribute("gubun", "구분(NF/NC/NM/NO)", "char", "2")]
		public string gubun;

		public static class F
		{
			/// <summary>
			/// 구분(NF/NC/NM/NO)
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
			dict["gubun"] = new XAQueryFieldInfo("char", gubun, gubun, "구분(NF/NC/NM/NO)", (decimal)2);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "gubun":
					this.gubun = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (gubun?.Length > 2) return false; // char 2

			return true;
		}

		public void CopyTo(XQt8437InBlock block)
		{
			block.gubun = this.gubun;

		}
	}

	public partial class XQt8437OutBlock : XingBlock
	{
		/// <summary>
		/// t8437OutBlock
		/// </summary>
		public const string _blockName = "t8437OutBlock";
		/// <summary>
		/// 야간시장마스터
		/// </summary>
		public const string _blockDesc = "야간시장마스터";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// true
		/// </summary>
		public const bool _hasOccurs = true;
		/// <summary>
		/// t8437OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t8437OutBlock
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// 야간시장마스터
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
		[XAQueryFieldAttribute("hname", "종목명", "char", "20")]
		public string hname;
		/// <summary>
		/// 종목코드
		/// </summary>
		[XAQueryFieldAttribute("shcode", "종목코드", "char", "8")]
		public string shcode;
		/// <summary>
		/// 표준코드
		/// </summary>
		[XAQueryFieldAttribute("expcode", "표준코드", "char", "12")]
		public string expcode;
		/// <summary>
		/// 거래승수
		/// </summary>
		[XAQueryFieldAttribute("tradeunit", "거래승수", "float", "21.8")]
		public float tradeunit;
		/// <summary>
		/// ATM구분(1:ATM2:ITM3:OTM)
		/// </summary>
		[XAQueryFieldAttribute("atmgb", "ATM구분(1:ATM2:ITM3:OTM)", "char", "1")]
		public char atmgb;

		public static class F
		{
			/// <summary>
			/// 종목명
			/// </summary>
			public const string hname = "hname";
			/// <summary>
			/// 종목코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 표준코드
			/// </summary>
			public const string expcode = "expcode";
			/// <summary>
			/// 거래승수
			/// </summary>
			public const string tradeunit = "tradeunit";
			/// <summary>
			/// ATM구분(1:ATM2:ITM3:OTM)
			/// </summary>
			public const string atmgb = "atmgb";
		}

		public static string[] AllFields = new string[]
		{
			F.hname,
			F.shcode,
			F.expcode,
			F.tradeunit,
			F.atmgb,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["hname"] = new XAQueryFieldInfo("char", hname, hname, "종목명", (decimal)20);
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "종목코드", (decimal)8);
			dict["expcode"] = new XAQueryFieldInfo("char", expcode, expcode, "표준코드", (decimal)12);
			dict["tradeunit"] = new XAQueryFieldInfo("float", tradeunit, tradeunit.ToString("000000000000000000000.00000000"), "거래승수", (decimal)21.8);
			dict["atmgb"] = new XAQueryFieldInfo("char", atmgb, atmgb.ToString(), "ATM구분(1:ATM2:ITM3:OTM)", (decimal)1);

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

				case "tradeunit":
					this.tradeunit = fieldInfo.FieldValue.ParseFloat("tradeunit");
				break;

				case "atmgb":
					this.atmgb = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public static XQt8437OutBlock[] ListFromQuery(XQt8437 query)
		{
			int count = query.GetBlockCount(XQt8437OutBlock.BlockName);
			List<XQt8437OutBlock> list = new List<XQt8437OutBlock>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt8437OutBlock block = new XQt8437OutBlock();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.hname = query.GetFieldData(block.GetBlockName(), "hname", i).TrimEnd('?'); // char 20
					block.shcode = query.GetFieldData(block.GetBlockName(), "shcode", i).TrimEnd('?'); // char 8
					block.expcode = query.GetFieldData(block.GetBlockName(), "expcode", i).TrimEnd('?'); // char 12
					block.tradeunit = query.GetFieldData(block.GetBlockName(), "tradeunit", i).ParseFloat("tradeunit"); // float 21.8
					block.atmgb = query.GetFieldData(block.GetBlockName(), "atmgb", i).FirstOrDefault(); // char 1

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
			if (shcode?.Length > 8) return false; // char 8
			if (expcode?.Length > 12) return false; // char 12
			// tradeunit float 21.8
			// atmgb char 1

			return true;
		}

		public void CopyTo(XQt8437OutBlock block)
		{
			block.hname = this.hname;
			block.shcode = this.shcode;
			block.expcode = this.expcode;
			block.tradeunit = this.tradeunit;
			block.atmgb = this.atmgb;

		}
	}

	/// <summary>
	/// CME/EUREX마스터조회(API용)(t8437)
	/// </summary>
	public partial class XQt8437 : XingQuery
	{
		/// <summary>
		/// t8437
		/// </summary>
		public const string _typeName = "t8437";
		/// <summary>
		/// CME/EUREX마스터조회(API용)(t8437)
		/// </summary>
		public const string _typeDesc = "CME/EUREX마스터조회(API용)(t8437)";
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
		/// t8437
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// CME/EUREX마스터조회(API용)(t8437)
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
		/// CME/EUREX마스터조회(API용)(t8437)
		/// </summary>
		public XQt8437() : base("t8437") { }


		public static XQt8437OutBlock[] Get(string gubun = default)
		{
			using (XQt8437 instance = new XQt8437())
			{
				instance.SetFieldData(XQt8437InBlock.BlockName, XQt8437InBlock.F.gubun, 0, gubun); // char 2

				if (instance.Request() < 0)
				{
					return null;
				}

				var outBlock = instance.GetBlocks();
				return outBlock;
			}
		}

		public static XQt8437OutBlock[] ReadFromDB(string tableNamePostfix = null /*, string gubun = default */)
		{
			using (XQt8437 instance = new XQt8437())
			{

				string tableName = (tableNamePostfix == null) ? "XQt8437OutBlock" : $"XQt8437OutBlock_{tableNamePostfix}";
				QueryOption qo = new QueryOption(tableName);
				// if (gubun != default) qo.Add("gubun", gubun);


				var outBlock = instance.SelectMany<XQt8437OutBlock>(qo);
				return outBlock;
			}
		}

		public bool SetBlock(XQt8437InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "gubun", 0, block.gubun); // char 2

			return true;
		}

		public XQt8437OutBlock[] GetBlocks()
		{
			XQt8437OutBlock[] instance = XQt8437OutBlock.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt8437OutBlock),

		};

	}

}
