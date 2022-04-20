﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt8436InBlock : XingBlock
	{
		/// <summary>
		/// t8436InBlock
		/// </summary>
		public const string _blockName = "t8436InBlock";
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
		/// t8436InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t8436InBlock
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
		/// 구분(0:전체1:코스피2:코스닥)
		/// </summary>
		[XAQueryFieldAttribute("gubun", "구분(0:전체1:코스피2:코스닥)", "char", "1")]
		public char gubun;

		public static class F
		{
			/// <summary>
			/// 구분(0:전체1:코스피2:코스닥)
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
			dict["gubun"] = new XAQueryFieldInfo("char", gubun, gubun.ToString(), "구분(0:전체1:코스피2:코스닥)", (decimal)1);

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

		public void CopyTo(XQt8436InBlock block)
		{
			block.gubun = this.gubun;

		}
	}

	public partial class XQt8436OutBlock : XingBlock
	{
		/// <summary>
		/// t8436OutBlock
		/// </summary>
		public const string _blockName = "t8436OutBlock";
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
		/// t8436OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t8436OutBlock
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
		/// 종목명
		/// </summary>
		[XAQueryFieldAttribute("hname", "종목명", "char", "20")]
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
		/// ETF구분(1:ETF2:ETN)
		/// </summary>
		[XAQueryFieldAttribute("etfgubun", "ETF구분(1:ETF2:ETN)", "char", "1")]
		public char etfgubun;
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
		/// 전일가
		/// </summary>
		[XAQueryFieldAttribute("jnilclose", "전일가", "long", "8")]
		public long jnilclose;
		/// <summary>
		/// 주문수량단위
		/// </summary>
		[XAQueryFieldAttribute("memedan", "주문수량단위", "char", "5")]
		public string memedan;
		/// <summary>
		/// 기준가
		/// </summary>
		[XAQueryFieldAttribute("recprice", "기준가", "long", "8")]
		public long recprice;
		/// <summary>
		/// 구분(1:코스피2:코스닥)
		/// </summary>
		[XAQueryFieldAttribute("gubun", "구분(1:코스피2:코스닥)", "char", "1")]
		public char gubun;
		/// <summary>
		/// 증권그룹
		/// </summary>
		[XAQueryFieldAttribute("bu12gubun", "증권그룹", "char", "2")]
		public string bu12gubun;
		/// <summary>
		/// 기업인수목적회사여부(Y/N)
		/// </summary>
		[XAQueryFieldAttribute("spac_gubun", "기업인수목적회사여부(Y/N)", "char", "1")]
		public char spac_gubun;
		/// <summary>
		/// filler(미사용)
		/// </summary>
		[XAQueryFieldAttribute("filler", "filler(미사용)", "char", "32")]
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
			/// ETF구분(1:ETF2:ETN)
			/// </summary>
			public const string etfgubun = "etfgubun";
			/// <summary>
			/// 상한가
			/// </summary>
			public const string uplmtprice = "uplmtprice";
			/// <summary>
			/// 하한가
			/// </summary>
			public const string dnlmtprice = "dnlmtprice";
			/// <summary>
			/// 전일가
			/// </summary>
			public const string jnilclose = "jnilclose";
			/// <summary>
			/// 주문수량단위
			/// </summary>
			public const string memedan = "memedan";
			/// <summary>
			/// 기준가
			/// </summary>
			public const string recprice = "recprice";
			/// <summary>
			/// 구분(1:코스피2:코스닥)
			/// </summary>
			public const string gubun = "gubun";
			/// <summary>
			/// 증권그룹
			/// </summary>
			public const string bu12gubun = "bu12gubun";
			/// <summary>
			/// 기업인수목적회사여부(Y/N)
			/// </summary>
			public const string spac_gubun = "spac_gubun";
			/// <summary>
			/// filler(미사용)
			/// </summary>
			public const string filler = "filler";
		}

		public static string[] AllFields = new string[]
		{
			F.hname,
			F.shcode,
			F.expcode,
			F.etfgubun,
			F.uplmtprice,
			F.dnlmtprice,
			F.jnilclose,
			F.memedan,
			F.recprice,
			F.gubun,
			F.bu12gubun,
			F.spac_gubun,
			F.filler,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["hname"] = new XAQueryFieldInfo("char", hname, hname, "종목명", (decimal)20);
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)6);
			dict["expcode"] = new XAQueryFieldInfo("char", expcode, expcode, "확장코드", (decimal)12);
			dict["etfgubun"] = new XAQueryFieldInfo("char", etfgubun, etfgubun.ToString(), "ETF구분(1:ETF2:ETN)", (decimal)1);
			dict["uplmtprice"] = new XAQueryFieldInfo("long", uplmtprice, uplmtprice.ToString("d8"), "상한가", (decimal)8);
			dict["dnlmtprice"] = new XAQueryFieldInfo("long", dnlmtprice, dnlmtprice.ToString("d8"), "하한가", (decimal)8);
			dict["jnilclose"] = new XAQueryFieldInfo("long", jnilclose, jnilclose.ToString("d8"), "전일가", (decimal)8);
			dict["memedan"] = new XAQueryFieldInfo("char", memedan, memedan, "주문수량단위", (decimal)5);
			dict["recprice"] = new XAQueryFieldInfo("long", recprice, recprice.ToString("d8"), "기준가", (decimal)8);
			dict["gubun"] = new XAQueryFieldInfo("char", gubun, gubun.ToString(), "구분(1:코스피2:코스닥)", (decimal)1);
			dict["bu12gubun"] = new XAQueryFieldInfo("char", bu12gubun, bu12gubun, "증권그룹", (decimal)2);
			dict["spac_gubun"] = new XAQueryFieldInfo("char", spac_gubun, spac_gubun.ToString(), "기업인수목적회사여부(Y/N)", (decimal)1);
			dict["filler"] = new XAQueryFieldInfo("char", filler, filler, "filler(미사용)", (decimal)32);

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

				case "etfgubun":
					this.etfgubun = fieldInfo.FieldValue.FirstOrDefault();
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

				case "memedan":
					this.memedan = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "recprice":
					this.recprice = fieldInfo.FieldValue.ParseLong("recprice");
				break;

				case "gubun":
					this.gubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "bu12gubun":
					this.bu12gubun = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "spac_gubun":
					this.spac_gubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "filler":
					this.filler = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt8436OutBlock[] ListFromQuery(XQt8436 query)
		{
			int count = query.GetBlockCount(XQt8436OutBlock.BlockName);
			List<XQt8436OutBlock> list = new List<XQt8436OutBlock>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt8436OutBlock block = new XQt8436OutBlock();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.hname = query.GetFieldData(block.GetBlockName(), "hname", i).TrimEnd('?'); // char 20
					block.shcode = query.GetFieldData(block.GetBlockName(), "shcode", i).TrimEnd('?'); // char 6
					block.expcode = query.GetFieldData(block.GetBlockName(), "expcode", i).TrimEnd('?'); // char 12
					block.etfgubun = query.GetFieldData(block.GetBlockName(), "etfgubun", i).FirstOrDefault(); // char 1
					block.uplmtprice = query.GetFieldData(block.GetBlockName(), "uplmtprice", i).ParseLong("uplmtprice"); // long 8
					block.dnlmtprice = query.GetFieldData(block.GetBlockName(), "dnlmtprice", i).ParseLong("dnlmtprice"); // long 8
					block.jnilclose = query.GetFieldData(block.GetBlockName(), "jnilclose", i).ParseLong("jnilclose"); // long 8
					block.memedan = query.GetFieldData(block.GetBlockName(), "memedan", i).TrimEnd('?'); // char 5
					block.recprice = query.GetFieldData(block.GetBlockName(), "recprice", i).ParseLong("recprice"); // long 8
					block.gubun = query.GetFieldData(block.GetBlockName(), "gubun", i).FirstOrDefault(); // char 1
					block.bu12gubun = query.GetFieldData(block.GetBlockName(), "bu12gubun", i).TrimEnd('?'); // char 2
					block.spac_gubun = query.GetFieldData(block.GetBlockName(), "spac_gubun", i).FirstOrDefault(); // char 1
					block.filler = query.GetFieldData(block.GetBlockName(), "filler", i).TrimEnd('?'); // char 32

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
			if (shcode?.Length > 6) return false; // char 6
			if (expcode?.Length > 12) return false; // char 12
			// etfgubun char 1
			if (uplmtprice.ToString().Length > 8) return false; // long 8
			if (dnlmtprice.ToString().Length > 8) return false; // long 8
			if (jnilclose.ToString().Length > 8) return false; // long 8
			if (memedan?.Length > 5) return false; // char 5
			if (recprice.ToString().Length > 8) return false; // long 8
			// gubun char 1
			if (bu12gubun?.Length > 2) return false; // char 2
			// spac_gubun char 1
			if (filler?.Length > 32) return false; // char 32

			return true;
		}

		public void CopyTo(XQt8436OutBlock block)
		{
			block.hname = this.hname;
			block.shcode = this.shcode;
			block.expcode = this.expcode;
			block.etfgubun = this.etfgubun;
			block.uplmtprice = this.uplmtprice;
			block.dnlmtprice = this.dnlmtprice;
			block.jnilclose = this.jnilclose;
			block.memedan = this.memedan;
			block.recprice = this.recprice;
			block.gubun = this.gubun;
			block.bu12gubun = this.bu12gubun;
			block.spac_gubun = this.spac_gubun;
			block.filler = this.filler;

		}
	}

	/// <summary>
	/// 주식종목조회 API용(t8436)
	/// </summary>
	public partial class XQt8436 : XingQuery
	{
		/// <summary>
		/// t8436
		/// </summary>
		public const string _typeName = "t8436";
		/// <summary>
		/// 주식종목조회 API용(t8436)
		/// </summary>
		public const string _typeDesc = "주식종목조회 API용(t8436)";
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
		/// t8436
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 주식종목조회 API용(t8436)
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
		/// 주식종목조회 API용(t8436)
		/// </summary>
		public XQt8436() : base("t8436") { }


		public static XQt8436OutBlock[] Get(char gubun = default)
		{
			using (XQt8436 instance = new XQt8436())
			{
				instance.SetFieldData(XQt8436InBlock.BlockName, XQt8436InBlock.F.gubun, 0, gubun.ToString()); // char 1

				if (instance.Request() < 0)
				{
					return null;
				}

				var outBlock = instance.GetBlocks();
				return outBlock;
			}
		}

		public static XQt8436OutBlock[] ReadFromDB(string tableNamePostfix = null /*, char gubun = default */)
		{
			using (XQt8436 instance = new XQt8436())
			{

				string tableName = (tableNamePostfix == null) ? "XQt8436OutBlock" : $"XQt8436OutBlock_{tableNamePostfix}";
				QueryOption qo = new QueryOption(tableName);
				// if (gubun != default) qo.Add("gubun", gubun);


				var outBlock = instance.SelectMany<XQt8436OutBlock>(qo);
				return outBlock;
			}
		}

		public bool SetBlock(XQt8436InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "gubun", 0, block.gubun.ToString()); // char 1

			return true;
		}

		public XQt8436OutBlock[] GetBlocks()
		{
			XQt8436OutBlock[] instance = XQt8436OutBlock.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt8436OutBlock),

		};

	}

}
