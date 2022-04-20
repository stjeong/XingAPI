﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt8435InBlock : XingBlock
	{
		/// <summary>
		/// t8435InBlock
		/// </summary>
		public const string _blockName = "t8435InBlock";
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
		/// t8435InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t8435InBlock
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
		/// 구분(MF/MO)
		/// </summary>
		[XAQueryFieldAttribute("gubun", "구분(MF/MO)", "char", "2")]
		public string gubun;

		public static class F
		{
			/// <summary>
			/// 구분(MF/MO)
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
			dict["gubun"] = new XAQueryFieldInfo("char", gubun, gubun, "구분(MF/MO)", (decimal)2);

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

		public void CopyTo(XQt8435InBlock block)
		{
			block.gubun = this.gubun;

		}
	}

	public partial class XQt8435OutBlock : XingBlock
	{
		/// <summary>
		/// t8435OutBlock
		/// </summary>
		public const string _blockName = "t8435OutBlock";
		/// <summary>
		/// 파생종목마스터
		/// </summary>
		public const string _blockDesc = "파생종목마스터";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// true
		/// </summary>
		public const bool _hasOccurs = true;
		/// <summary>
		/// t8435OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t8435OutBlock
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// 파생종목마스터
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
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("shcode", "단축코드", "char", "8")]
		public string shcode;
		/// <summary>
		/// 확장코드
		/// </summary>
		[XAQueryFieldAttribute("expcode", "확장코드", "char", "12")]
		public string expcode;
		/// <summary>
		/// 상한가
		/// </summary>
		[XAQueryFieldAttribute("uplmtprice", "상한가", "float", "6.2")]
		public float uplmtprice;
		/// <summary>
		/// 하한가
		/// </summary>
		[XAQueryFieldAttribute("dnlmtprice", "하한가", "float", "6.2")]
		public float dnlmtprice;
		/// <summary>
		/// 전일종가
		/// </summary>
		[XAQueryFieldAttribute("jnilclose", "전일종가", "float", "6.2")]
		public float jnilclose;
		/// <summary>
		/// 전일고가
		/// </summary>
		[XAQueryFieldAttribute("jnilhigh", "전일고가", "float", "6.2")]
		public float jnilhigh;
		/// <summary>
		/// 전일저가
		/// </summary>
		[XAQueryFieldAttribute("jnillow", "전일저가", "float", "6.2")]
		public float jnillow;
		/// <summary>
		/// 기준가
		/// </summary>
		[XAQueryFieldAttribute("recprice", "기준가", "float", "6.2")]
		public float recprice;

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
			/// 전일고가
			/// </summary>
			public const string jnilhigh = "jnilhigh";
			/// <summary>
			/// 전일저가
			/// </summary>
			public const string jnillow = "jnillow";
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
			F.jnilhigh,
			F.jnillow,
			F.recprice,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["hname"] = new XAQueryFieldInfo("char", hname, hname, "종목명", (decimal)20);
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)8);
			dict["expcode"] = new XAQueryFieldInfo("char", expcode, expcode, "확장코드", (decimal)12);
			dict["uplmtprice"] = new XAQueryFieldInfo("float", uplmtprice, uplmtprice.ToString("000000.00"), "상한가", (decimal)6.2);
			dict["dnlmtprice"] = new XAQueryFieldInfo("float", dnlmtprice, dnlmtprice.ToString("000000.00"), "하한가", (decimal)6.2);
			dict["jnilclose"] = new XAQueryFieldInfo("float", jnilclose, jnilclose.ToString("000000.00"), "전일종가", (decimal)6.2);
			dict["jnilhigh"] = new XAQueryFieldInfo("float", jnilhigh, jnilhigh.ToString("000000.00"), "전일고가", (decimal)6.2);
			dict["jnillow"] = new XAQueryFieldInfo("float", jnillow, jnillow.ToString("000000.00"), "전일저가", (decimal)6.2);
			dict["recprice"] = new XAQueryFieldInfo("float", recprice, recprice.ToString("000000.00"), "기준가", (decimal)6.2);

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
					this.uplmtprice = fieldInfo.FieldValue.ParseFloat("uplmtprice");
				break;

				case "dnlmtprice":
					this.dnlmtprice = fieldInfo.FieldValue.ParseFloat("dnlmtprice");
				break;

				case "jnilclose":
					this.jnilclose = fieldInfo.FieldValue.ParseFloat("jnilclose");
				break;

				case "jnilhigh":
					this.jnilhigh = fieldInfo.FieldValue.ParseFloat("jnilhigh");
				break;

				case "jnillow":
					this.jnillow = fieldInfo.FieldValue.ParseFloat("jnillow");
				break;

				case "recprice":
					this.recprice = fieldInfo.FieldValue.ParseFloat("recprice");
				break;


			}
		}

		public static XQt8435OutBlock[] ListFromQuery(XQt8435 query)
		{
			int count = query.GetBlockCount(XQt8435OutBlock.BlockName);
			List<XQt8435OutBlock> list = new List<XQt8435OutBlock>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt8435OutBlock block = new XQt8435OutBlock();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.hname = query.GetFieldData(block.GetBlockName(), "hname", i).TrimEnd('?'); // char 20
					block.shcode = query.GetFieldData(block.GetBlockName(), "shcode", i).TrimEnd('?'); // char 8
					block.expcode = query.GetFieldData(block.GetBlockName(), "expcode", i).TrimEnd('?'); // char 12
					block.uplmtprice = query.GetFieldData(block.GetBlockName(), "uplmtprice", i).ParseFloat("uplmtprice"); // float 6.2
					block.dnlmtprice = query.GetFieldData(block.GetBlockName(), "dnlmtprice", i).ParseFloat("dnlmtprice"); // float 6.2
					block.jnilclose = query.GetFieldData(block.GetBlockName(), "jnilclose", i).ParseFloat("jnilclose"); // float 6.2
					block.jnilhigh = query.GetFieldData(block.GetBlockName(), "jnilhigh", i).ParseFloat("jnilhigh"); // float 6.2
					block.jnillow = query.GetFieldData(block.GetBlockName(), "jnillow", i).ParseFloat("jnillow"); // float 6.2
					block.recprice = query.GetFieldData(block.GetBlockName(), "recprice", i).ParseFloat("recprice"); // float 6.2

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
			// uplmtprice float 6.2
			// dnlmtprice float 6.2
			// jnilclose float 6.2
			// jnilhigh float 6.2
			// jnillow float 6.2
			// recprice float 6.2

			return true;
		}

		public void CopyTo(XQt8435OutBlock block)
		{
			block.hname = this.hname;
			block.shcode = this.shcode;
			block.expcode = this.expcode;
			block.uplmtprice = this.uplmtprice;
			block.dnlmtprice = this.dnlmtprice;
			block.jnilclose = this.jnilclose;
			block.jnilhigh = this.jnilhigh;
			block.jnillow = this.jnillow;
			block.recprice = this.recprice;

		}
	}

	/// <summary>
	/// 파생종목마스터조회API용(t8435)
	/// </summary>
	public partial class XQt8435 : XingQuery
	{
		/// <summary>
		/// t8435
		/// </summary>
		public const string _typeName = "t8435";
		/// <summary>
		/// 파생종목마스터조회API용(t8435)
		/// </summary>
		public const string _typeDesc = "파생종목마스터조회API용(t8435)";
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
		/// t8435
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 파생종목마스터조회API용(t8435)
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
		/// 파생종목마스터조회API용(t8435)
		/// </summary>
		public XQt8435() : base("t8435") { }


		public static XQt8435OutBlock[] Get(string gubun = default)
		{
			using (XQt8435 instance = new XQt8435())
			{
				instance.SetFieldData(XQt8435InBlock.BlockName, XQt8435InBlock.F.gubun, 0, gubun); // char 2

				if (instance.Request() < 0)
				{
					return null;
				}

				var outBlock = instance.GetBlocks();
				return outBlock;
			}
		}

		public static XQt8435OutBlock[] ReadFromDB(string tableNamePostfix = null /*, string gubun = default */)
		{
			using (XQt8435 instance = new XQt8435())
			{

				string tableName = (tableNamePostfix == null) ? "XQt8435OutBlock" : $"XQt8435OutBlock_{tableNamePostfix}";
				QueryOption qo = new QueryOption(tableName);
				// if (gubun != default) qo.Add("gubun", gubun);


				var outBlock = instance.SelectMany<XQt8435OutBlock>(qo);
				return outBlock;
			}
		}

		public bool SetBlock(XQt8435InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "gubun", 0, block.gubun); // char 2

			return true;
		}

		public XQt8435OutBlock[] GetBlocks()
		{
			XQt8435OutBlock[] instance = XQt8435OutBlock.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt8435OutBlock),

		};

	}

}
