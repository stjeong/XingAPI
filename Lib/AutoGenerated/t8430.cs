using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt8430InBlock : XingBlock
	{
		/// <summary>
		/// t8430InBlock
		/// </summary>
		public const string _blockName = "t8430InBlock";
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
		/// t8430InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t8430InBlock
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
		[XAQueryFieldAttribute("구분(0:전체1:코스피2:코스닥)")]
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
	}

	public partial class XQt8430OutBlock : XingBlock
	{
		/// <summary>
		/// t8430OutBlock
		/// </summary>
		public const string _blockName = "t8430OutBlock";
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
		/// t8430OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t8430OutBlock
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
		[XAQueryFieldAttribute("종목명")]
		public string hname;
		/// <summary>
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("단축코드")]
		public string shcode;
		/// <summary>
		/// 확장코드
		/// </summary>
		[XAQueryFieldAttribute("확장코드")]
		public string expcode;
		/// <summary>
		/// ETF구분(1:ETF)
		/// </summary>
		[XAQueryFieldAttribute("ETF구분(1:ETF)")]
		public char etfgubun;
		/// <summary>
		/// 상한가
		/// </summary>
		[XAQueryFieldAttribute("상한가")]
		public long uplmtprice;
		/// <summary>
		/// 하한가
		/// </summary>
		[XAQueryFieldAttribute("하한가")]
		public long dnlmtprice;
		/// <summary>
		/// 전일가
		/// </summary>
		[XAQueryFieldAttribute("전일가")]
		public long jnilclose;
		/// <summary>
		/// 주문수량단위
		/// </summary>
		[XAQueryFieldAttribute("주문수량단위")]
		public string memedan;
		/// <summary>
		/// 기준가
		/// </summary>
		[XAQueryFieldAttribute("기준가")]
		public long recprice;
		/// <summary>
		/// 구분(1:코스피2:코스닥)
		/// </summary>
		[XAQueryFieldAttribute("구분(1:코스피2:코스닥)")]
		public char gubun;

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
			/// ETF구분(1:ETF)
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
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["hname"] = new XAQueryFieldInfo("char", hname, hname, "종목명", (decimal)20);
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)6);
			dict["expcode"] = new XAQueryFieldInfo("char", expcode, expcode, "확장코드", (decimal)12);
			dict["etfgubun"] = new XAQueryFieldInfo("char", etfgubun, etfgubun.ToString(), "ETF구분(1:ETF)", (decimal)1);
			dict["uplmtprice"] = new XAQueryFieldInfo("long", uplmtprice, uplmtprice.ToString("d8"), "상한가", (decimal)8);
			dict["dnlmtprice"] = new XAQueryFieldInfo("long", dnlmtprice, dnlmtprice.ToString("d8"), "하한가", (decimal)8);
			dict["jnilclose"] = new XAQueryFieldInfo("long", jnilclose, jnilclose.ToString("d8"), "전일가", (decimal)8);
			dict["memedan"] = new XAQueryFieldInfo("char", memedan, memedan, "주문수량단위", (decimal)5);
			dict["recprice"] = new XAQueryFieldInfo("long", recprice, recprice.ToString("d8"), "기준가", (decimal)8);
			dict["gubun"] = new XAQueryFieldInfo("char", gubun, gubun.ToString(), "구분(1:코스피2:코스닥)", (decimal)1);

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


			}
		}

		public static XQt8430OutBlock[] ListFromQuery(XQt8430 query)
		{
			int count = query.GetBlockCount(XQt8430OutBlock.BlockName);
			List<XQt8430OutBlock> list = new List<XQt8430OutBlock>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt8430OutBlock block = new XQt8430OutBlock();
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

			return true;
		}
	}

	/// <summary>
	/// 주식종목조회(t8430)
	/// </summary>
	public partial class XQt8430 : XingQuery
	{
		/// <summary>
		/// t8430
		/// </summary>
		public const string _typeName = "t8430";
		/// <summary>
		/// 주식종목조회(t8430)
		/// </summary>
		public const string _typeDesc = "주식종목조회(t8430)";
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
		/// t8430
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 주식종목조회(t8430)
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
		/// 주식종목조회(t8430)
		/// </summary>
		public XQt8430() : base("t8430") { }


		public static XQt8430OutBlock[] Get(char gubun = default)
		{
			using (XQt8430 instance = new XQt8430())
			{
				instance.SetFieldData(XQt8430InBlock.BlockName, XQt8430InBlock.F.gubun, 0, gubun.ToString()); // char 1

				if (instance.Request() < 0)
				{
					return null;
				}

				var outBlock = instance.GetBlocks();
				return outBlock;
			}
		}

		public bool SetBlock(XQt8430InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "gubun", 0, block.gubun.ToString()); // char 1

			return true;
		}

		public XQt8430OutBlock[] GetBlocks()
		{
			XQt8430OutBlock[] instance = XQt8430OutBlock.ListFromQuery(this);
			return instance;

		}


	}

}
