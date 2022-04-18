using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1442InBlock : XingBlock
	{
		/// <summary>
		/// t1442InBlock
		/// </summary>
		public const string _blockName = "t1442InBlock";
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
		/// t1442InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1442InBlock
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
		/// 구분
		/// </summary>
		[XAQueryFieldAttribute("gubun", "구분", "char", "1")]
		public char gubun;
		/// <summary>
		/// 신고신저
		/// </summary>
		[XAQueryFieldAttribute("type1", "신고신저", "char", "1")]
		public char type1;
		/// <summary>
		/// 기간
		/// </summary>
		[XAQueryFieldAttribute("type2", "기간", "char", "1")]
		public char type2;
		/// <summary>
		/// 유지여부
		/// </summary>
		[XAQueryFieldAttribute("type3", "유지여부", "char", "1")]
		public char type3;
		/// <summary>
		/// 대상제외
		/// </summary>
		[XAQueryFieldAttribute("jc_num", "대상제외", "long", "12")]
		public long jc_num;
		/// <summary>
		/// 시작가격
		/// </summary>
		[XAQueryFieldAttribute("sprice", "시작가격", "long", "8")]
		public long sprice;
		/// <summary>
		/// 종료가격
		/// </summary>
		[XAQueryFieldAttribute("eprice", "종료가격", "long", "8")]
		public long eprice;
		/// <summary>
		/// 거래량
		/// </summary>
		[XAQueryFieldAttribute("volume", "거래량", "long", "12")]
		public long volume;
		/// <summary>
		/// IDX
		/// </summary>
		[XAQueryFieldAttribute("idx", "IDX", "long", "4")]
		public long idx;
		/// <summary>
		/// 대상제외2
		/// </summary>
		[XAQueryFieldAttribute("jc_num2", "대상제외2", "long", "12")]
		public long jc_num2;

		public static class F
		{
			/// <summary>
			/// 구분
			/// </summary>
			public const string gubun = "gubun";
			/// <summary>
			/// 신고신저
			/// </summary>
			public const string type1 = "type1";
			/// <summary>
			/// 기간
			/// </summary>
			public const string type2 = "type2";
			/// <summary>
			/// 유지여부
			/// </summary>
			public const string type3 = "type3";
			/// <summary>
			/// 대상제외
			/// </summary>
			public const string jc_num = "jc_num";
			/// <summary>
			/// 시작가격
			/// </summary>
			public const string sprice = "sprice";
			/// <summary>
			/// 종료가격
			/// </summary>
			public const string eprice = "eprice";
			/// <summary>
			/// 거래량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// IDX
			/// </summary>
			public const string idx = "idx";
			/// <summary>
			/// 대상제외2
			/// </summary>
			public const string jc_num2 = "jc_num2";
		}

		public static string[] AllFields = new string[]
		{
			F.gubun,
			F.type1,
			F.type2,
			F.type3,
			F.jc_num,
			F.sprice,
			F.eprice,
			F.volume,
			F.idx,
			F.jc_num2,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["gubun"] = new XAQueryFieldInfo("char", gubun, gubun.ToString(), "구분", (decimal)1);
			dict["type1"] = new XAQueryFieldInfo("char", type1, type1.ToString(), "신고신저", (decimal)1);
			dict["type2"] = new XAQueryFieldInfo("char", type2, type2.ToString(), "기간", (decimal)1);
			dict["type3"] = new XAQueryFieldInfo("char", type3, type3.ToString(), "유지여부", (decimal)1);
			dict["jc_num"] = new XAQueryFieldInfo("long", jc_num, jc_num.ToString("d12"), "대상제외", (decimal)12);
			dict["sprice"] = new XAQueryFieldInfo("long", sprice, sprice.ToString("d8"), "시작가격", (decimal)8);
			dict["eprice"] = new XAQueryFieldInfo("long", eprice, eprice.ToString("d8"), "종료가격", (decimal)8);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "거래량", (decimal)12);
			dict["idx"] = new XAQueryFieldInfo("long", idx, idx.ToString("d4"), "IDX", (decimal)4);
			dict["jc_num2"] = new XAQueryFieldInfo("long", jc_num2, jc_num2.ToString("d12"), "대상제외2", (decimal)12);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "gubun":
					this.gubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "type1":
					this.type1 = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "type2":
					this.type2 = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "type3":
					this.type3 = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "jc_num":
					this.jc_num = fieldInfo.FieldValue.ParseLong("jc_num");
				break;

				case "sprice":
					this.sprice = fieldInfo.FieldValue.ParseLong("sprice");
				break;

				case "eprice":
					this.eprice = fieldInfo.FieldValue.ParseLong("eprice");
				break;

				case "volume":
					this.volume = fieldInfo.FieldValue.ParseLong("volume");
				break;

				case "idx":
					this.idx = fieldInfo.FieldValue.ParseLong("idx");
				break;

				case "jc_num2":
					this.jc_num2 = fieldInfo.FieldValue.ParseLong("jc_num2");
				break;


			}
		}

		public bool VerifyData()
		{
			// gubun char 1
			// type1 char 1
			// type2 char 1
			// type3 char 1
			if (jc_num.ToString().Length > 12) return false; // long 12
			if (sprice.ToString().Length > 8) return false; // long 8
			if (eprice.ToString().Length > 8) return false; // long 8
			if (volume.ToString().Length > 12) return false; // long 12
			if (idx.ToString().Length > 4) return false; // long 4
			if (jc_num2.ToString().Length > 12) return false; // long 12

			return true;
		}
	}

	public partial class XQt1442OutBlock : XingBlock
	{
		/// <summary>
		/// t1442OutBlock
		/// </summary>
		public const string _blockName = "t1442OutBlock";
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
		/// t1442OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1442OutBlock
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
		/// IDX
		/// </summary>
		[XAQueryFieldAttribute("idx", "IDX", "long", "4")]
		public long idx;

		public static class F
		{
			/// <summary>
			/// IDX
			/// </summary>
			public const string idx = "idx";
		}

		public static string[] AllFields = new string[]
		{
			F.idx,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["idx"] = new XAQueryFieldInfo("long", idx, idx.ToString("d4"), "IDX", (decimal)4);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "idx":
					this.idx = fieldInfo.FieldValue.ParseLong("idx");
				break;


			}
		}

		public static XQt1442OutBlock FromQuery(XQt1442 query)
		{
			XQt1442OutBlock block = new XQt1442OutBlock();
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
				block.idx = query.GetFieldData(block.GetBlockName(), "idx", 0).ParseLong("idx"); // long 4

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (idx.ToString().Length > 4) return false; // long 4

			return true;
		}
	}

	public partial class XQt1442OutBlock1 : XingBlock
	{
		/// <summary>
		/// t1442OutBlock1
		/// </summary>
		public const string _blockName = "t1442OutBlock1";
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
		/// t1442OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1442OutBlock1
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
		/// 종목코드
		/// </summary>
		[XAQueryFieldAttribute("shcode", "종목코드", "char", "6")]
		public string shcode;
		/// <summary>
		/// 종목명
		/// </summary>
		[XAQueryFieldAttribute("hname", "종목명", "char", "20")]
		public string hname;
		/// <summary>
		/// 현재가
		/// </summary>
		[XAQueryFieldAttribute("price", "현재가", "long", "8")]
		public long price;
		/// <summary>
		/// 전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("sign", "전일대비구분", "char", "1")]
		public char sign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[XAQueryFieldAttribute("change", "전일대비", "long", "8")]
		public long change;
		/// <summary>
		/// 등락율
		/// </summary>
		[XAQueryFieldAttribute("diff", "등락율", "float", "6.2")]
		public float diff;
		/// <summary>
		/// 거래량
		/// </summary>
		[XAQueryFieldAttribute("volume", "거래량", "long", "12")]
		public long volume;
		/// <summary>
		/// 이전가
		/// </summary>
		[XAQueryFieldAttribute("pastprice", "이전가", "long", "8")]
		public long pastprice;
		/// <summary>
		/// 이전가대비구분
		/// </summary>
		[XAQueryFieldAttribute("pastsign", "이전가대비구분", "char", "1")]
		public char pastsign;
		/// <summary>
		/// 이전가대비
		/// </summary>
		[XAQueryFieldAttribute("pastchange", "이전가대비", "long", "8")]
		public long pastchange;
		/// <summary>
		/// 이전가대비율
		/// </summary>
		[XAQueryFieldAttribute("pastdiff", "이전가대비율", "float", "6.2")]
		public float pastdiff;

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
			/// 이전가
			/// </summary>
			public const string pastprice = "pastprice";
			/// <summary>
			/// 이전가대비구분
			/// </summary>
			public const string pastsign = "pastsign";
			/// <summary>
			/// 이전가대비
			/// </summary>
			public const string pastchange = "pastchange";
			/// <summary>
			/// 이전가대비율
			/// </summary>
			public const string pastdiff = "pastdiff";
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
			F.pastprice,
			F.pastsign,
			F.pastchange,
			F.pastdiff,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "종목코드", (decimal)6);
			dict["hname"] = new XAQueryFieldInfo("char", hname, hname, "종목명", (decimal)20);
			dict["price"] = new XAQueryFieldInfo("long", price, price.ToString("d8"), "현재가", (decimal)8);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("long", change, change.ToString("d8"), "전일대비", (decimal)8);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "거래량", (decimal)12);
			dict["pastprice"] = new XAQueryFieldInfo("long", pastprice, pastprice.ToString("d8"), "이전가", (decimal)8);
			dict["pastsign"] = new XAQueryFieldInfo("char", pastsign, pastsign.ToString(), "이전가대비구분", (decimal)1);
			dict["pastchange"] = new XAQueryFieldInfo("long", pastchange, pastchange.ToString("d8"), "이전가대비", (decimal)8);
			dict["pastdiff"] = new XAQueryFieldInfo("float", pastdiff, pastdiff.ToString("000000.00"), "이전가대비율", (decimal)6.2);

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

				case "pastprice":
					this.pastprice = fieldInfo.FieldValue.ParseLong("pastprice");
				break;

				case "pastsign":
					this.pastsign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "pastchange":
					this.pastchange = fieldInfo.FieldValue.ParseLong("pastchange");
				break;

				case "pastdiff":
					this.pastdiff = fieldInfo.FieldValue.ParseFloat("pastdiff");
				break;


			}
		}

		public static XQt1442OutBlock1[] ListFromQuery(XQt1442 query)
		{
			int count = query.GetBlockCount(XQt1442OutBlock1.BlockName);
			List<XQt1442OutBlock1> list = new List<XQt1442OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1442OutBlock1 block = new XQt1442OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.shcode = query.GetFieldData(block.GetBlockName(), "shcode", i).TrimEnd('?'); // char 6
					block.hname = query.GetFieldData(block.GetBlockName(), "hname", i).TrimEnd('?'); // char 20
					block.price = query.GetFieldData(block.GetBlockName(), "price", i).ParseLong("price"); // long 8
					block.sign = query.GetFieldData(block.GetBlockName(), "sign", i).FirstOrDefault(); // char 1
					block.change = query.GetFieldData(block.GetBlockName(), "change", i).ParseLong("change"); // long 8
					block.diff = query.GetFieldData(block.GetBlockName(), "diff", i).ParseFloat("diff"); // float 6.2
					block.volume = query.GetFieldData(block.GetBlockName(), "volume", i).ParseLong("volume"); // long 12
					block.pastprice = query.GetFieldData(block.GetBlockName(), "pastprice", i).ParseLong("pastprice"); // long 8
					block.pastsign = query.GetFieldData(block.GetBlockName(), "pastsign", i).FirstOrDefault(); // char 1
					block.pastchange = query.GetFieldData(block.GetBlockName(), "pastchange", i).ParseLong("pastchange"); // long 8
					block.pastdiff = query.GetFieldData(block.GetBlockName(), "pastdiff", i).ParseFloat("pastdiff"); // float 6.2

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
			if (shcode?.Length > 6) return false; // char 6
			if (hname?.Length > 20) return false; // char 20
			if (price.ToString().Length > 8) return false; // long 8
			// sign char 1
			if (change.ToString().Length > 8) return false; // long 8
			// diff float 6.2
			if (volume.ToString().Length > 12) return false; // long 12
			if (pastprice.ToString().Length > 8) return false; // long 8
			// pastsign char 1
			if (pastchange.ToString().Length > 8) return false; // long 8
			// pastdiff float 6.2

			return true;
		}
	}

	/// <summary>
	/// 신고/신저가(t1442)
	/// </summary>
	public partial class XQt1442 : XingQuery
	{
		/// <summary>
		/// t1442
		/// </summary>
		public const string _typeName = "t1442";
		/// <summary>
		/// 신고/신저가(t1442)
		/// </summary>
		public const string _typeDesc = "신고/신저가(t1442)";
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
		/// t1442
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 신고/신저가(t1442)
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
		/// 신고/신저가(t1442)
		/// </summary>
		public XQt1442() : base("t1442") { }


		public class XQAllOutBlocks
		{
			public XQt1442OutBlock OutBlock { get; internal set; }
			public XQt1442OutBlock1[] OutBlock1 { get; internal set; }
		}

		public static XQAllOutBlocks Get(char gubun = default,char type1 = default,char type2 = default,char type3 = default,long jc_num = default,long sprice = default,long eprice = default,long volume = default,long idx = default,long jc_num2 = default)
		{
			using (XQt1442 instance = new XQt1442())
			{
				instance.SetFieldData(XQt1442InBlock.BlockName, XQt1442InBlock.F.gubun, 0, gubun.ToString()); // char 1
				instance.SetFieldData(XQt1442InBlock.BlockName, XQt1442InBlock.F.type1, 0, type1.ToString()); // char 1
				instance.SetFieldData(XQt1442InBlock.BlockName, XQt1442InBlock.F.type2, 0, type2.ToString()); // char 1
				instance.SetFieldData(XQt1442InBlock.BlockName, XQt1442InBlock.F.type3, 0, type3.ToString()); // char 1
				instance.SetFieldData(XQt1442InBlock.BlockName, XQt1442InBlock.F.jc_num, 0, jc_num.ToString("d12")); // long 12
				instance.SetFieldData(XQt1442InBlock.BlockName, XQt1442InBlock.F.sprice, 0, sprice.ToString("d8")); // long 8
				instance.SetFieldData(XQt1442InBlock.BlockName, XQt1442InBlock.F.eprice, 0, eprice.ToString("d8")); // long 8
				instance.SetFieldData(XQt1442InBlock.BlockName, XQt1442InBlock.F.volume, 0, volume.ToString("d12")); // long 12
				instance.SetFieldData(XQt1442InBlock.BlockName, XQt1442InBlock.F.idx, 0, idx.ToString("d4")); // long 4
				instance.SetFieldData(XQt1442InBlock.BlockName, XQt1442InBlock.F.jc_num2, 0, jc_num2.ToString("d12")); // long 12

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

		public static XQAllOutBlocks ReadFromDB(string tableNamePostfix = null /*, char gubun = default,char type1 = default,char type2 = default,char type3 = default,long jc_num = default,long sprice = default,long eprice = default,long volume = default,long idx = default,long jc_num2 = default */)
		{
			using (XQt1442 instance = new XQt1442())
			{

				XQAllOutBlocks results = new XQAllOutBlocks();

				string tableName = (tableNamePostfix == null) ? "XQt1442OutBlock" : $"XQt1442OutBlock_{tableNamePostfix}";
				QueryOption qo = new QueryOption(tableName);
				results.OutBlock = instance.Select<XQt1442OutBlock>(qo);

				tableName = (tableNamePostfix == null) ? "XQt1442OutBlock1" : $"XQt1442OutBlock1_{tableNamePostfix}";
				qo = new QueryOption(tableName);
				results.OutBlock1 = instance.SelectMany<XQt1442OutBlock1>(qo);
				return results;
			}
		}

		public bool SetBlock(XQt1442InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "gubun", 0, block.gubun.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "type1", 0, block.type1.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "type2", 0, block.type2.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "type3", 0, block.type3.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "jc_num", 0, block.jc_num.ToString("d12")); // long 12
			_xaQuery.SetFieldData(block.GetBlockName(), "sprice", 0, block.sprice.ToString("d8")); // long 8
			_xaQuery.SetFieldData(block.GetBlockName(), "eprice", 0, block.eprice.ToString("d8")); // long 8
			_xaQuery.SetFieldData(block.GetBlockName(), "volume", 0, block.volume.ToString("d12")); // long 12
			_xaQuery.SetFieldData(block.GetBlockName(), "idx", 0, block.idx.ToString("d4")); // long 4
			_xaQuery.SetFieldData(block.GetBlockName(), "jc_num2", 0, block.jc_num2.ToString("d12")); // long 12

			return true;
		}

		public XQt1442OutBlock GetBlock()
		{
			XQt1442OutBlock instance = XQt1442OutBlock.FromQuery(this);
			return instance;

		}

		public XQt1442OutBlock1[] GetBlock1s()
		{
			XQt1442OutBlock1[] instance = XQt1442OutBlock1.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt1442OutBlock),
			typeof(XQt1442OutBlock1),

		};

	}

}
