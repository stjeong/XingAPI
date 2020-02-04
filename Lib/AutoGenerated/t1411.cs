using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1411InBlock : XingBlock
	{
		/// <summary>
		/// t1411InBlock
		/// </summary>
		public const string _blockName = "t1411InBlock";
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
		/// t1411InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1411InBlock
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
		/// 시장구분
		/// </summary>
		[XAQueryFieldAttribute("시장구분")]
		public char gubun;
		/// <summary>
		/// 위탁신용구분
		/// </summary>
		[XAQueryFieldAttribute("위탁신용구분")]
		public char jongchk;
		/// <summary>
		/// 증거금율구분
		/// </summary>
		[XAQueryFieldAttribute("증거금율구분")]
		public char jkrate;
		/// <summary>
		/// 종목코드
		/// </summary>
		[XAQueryFieldAttribute("종목코드")]
		public string shcode;
		/// <summary>
		/// IDX
		/// </summary>
		[XAQueryFieldAttribute("IDX")]
		public long idx;

		public static class F
		{
			/// <summary>
			/// 시장구분
			/// </summary>
			public const string gubun = "gubun";
			/// <summary>
			/// 위탁신용구분
			/// </summary>
			public const string jongchk = "jongchk";
			/// <summary>
			/// 증거금율구분
			/// </summary>
			public const string jkrate = "jkrate";
			/// <summary>
			/// 종목코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// IDX
			/// </summary>
			public const string idx = "idx";
		}

		public static string[] AllFields = new string[]
		{
			F.gubun,
			F.jongchk,
			F.jkrate,
			F.shcode,
			F.idx,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["gubun"] = new XAQueryFieldInfo("char", gubun, gubun.ToString(), "시장구분", (decimal)1);
			dict["jongchk"] = new XAQueryFieldInfo("char", jongchk, jongchk.ToString(), "위탁신용구분", (decimal)1);
			dict["jkrate"] = new XAQueryFieldInfo("char", jkrate, jkrate.ToString(), "증거금율구분", (decimal)1);
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "종목코드", (decimal)6);
			dict["idx"] = new XAQueryFieldInfo("long", idx, idx.ToString("d4"), "IDX", (decimal)4);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "gubun":
					this.gubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "jongchk":
					this.jongchk = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "jkrate":
					this.jkrate = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "idx":
					this.idx = fieldInfo.FieldValue.ParseLong("idx");
				break;


			}
		}

		public bool VerifyData()
		{
			// gubun char 1
			// jongchk char 1
			// jkrate char 1
			if (shcode?.Length > 6) return false; // char 6
			if (idx.ToString().Length > 4) return false; // long 4

			return true;
		}
	}

	public partial class XQt1411OutBlock : XingBlock
	{
		/// <summary>
		/// t1411OutBlock
		/// </summary>
		public const string _blockName = "t1411OutBlock";
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
		/// t1411OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1411OutBlock
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
		/// 위탁증거금율
		/// </summary>
		[XAQueryFieldAttribute("위탁증거금율")]
		public long jkrate;
		/// <summary>
		/// 신용증거금율
		/// </summary>
		[XAQueryFieldAttribute("신용증거금율")]
		public long sjkrate;
		/// <summary>
		/// IDX
		/// </summary>
		[XAQueryFieldAttribute("IDX")]
		public long idx;

		public static class F
		{
			/// <summary>
			/// 위탁증거금율
			/// </summary>
			public const string jkrate = "jkrate";
			/// <summary>
			/// 신용증거금율
			/// </summary>
			public const string sjkrate = "sjkrate";
			/// <summary>
			/// IDX
			/// </summary>
			public const string idx = "idx";
		}

		public static string[] AllFields = new string[]
		{
			F.jkrate,
			F.sjkrate,
			F.idx,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["jkrate"] = new XAQueryFieldInfo("long", jkrate, jkrate.ToString("d3"), "위탁증거금율", (decimal)3);
			dict["sjkrate"] = new XAQueryFieldInfo("long", sjkrate, sjkrate.ToString("d3"), "신용증거금율", (decimal)3);
			dict["idx"] = new XAQueryFieldInfo("long", idx, idx.ToString("d4"), "IDX", (decimal)4);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "jkrate":
					this.jkrate = fieldInfo.FieldValue.ParseLong("jkrate");
				break;

				case "sjkrate":
					this.sjkrate = fieldInfo.FieldValue.ParseLong("sjkrate");
				break;

				case "idx":
					this.idx = fieldInfo.FieldValue.ParseLong("idx");
				break;


			}
		}

		public static XQt1411OutBlock FromQuery(XQt1411 query)
		{
			XQt1411OutBlock block = new XQt1411OutBlock();
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
				block.jkrate = query.GetFieldData(block.GetBlockName(), "jkrate", 0).ParseLong("jkrate"); // long 3
				block.sjkrate = query.GetFieldData(block.GetBlockName(), "sjkrate", 0).ParseLong("sjkrate"); // long 3
				block.idx = query.GetFieldData(block.GetBlockName(), "idx", 0).ParseLong("idx"); // long 4

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (jkrate.ToString().Length > 3) return false; // long 3
			if (sjkrate.ToString().Length > 3) return false; // long 3
			if (idx.ToString().Length > 4) return false; // long 4

			return true;
		}
	}

	public partial class XQt1411OutBlock1 : XingBlock
	{
		/// <summary>
		/// t1411OutBlock1
		/// </summary>
		public const string _blockName = "t1411OutBlock1";
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
		/// t1411OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1411OutBlock1
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
		[XAQueryFieldAttribute("종목코드")]
		public string shcode;
		/// <summary>
		/// 종목명
		/// </summary>
		[XAQueryFieldAttribute("종목명")]
		public string hname;
		/// <summary>
		/// 위탁증거금율
		/// </summary>
		[XAQueryFieldAttribute("위탁증거금율")]
		public long jkrate;
		/// <summary>
		/// 신용증거금율
		/// </summary>
		[XAQueryFieldAttribute("신용증거금율")]
		public long sjkrate;
		/// <summary>
		/// 대용가
		/// </summary>
		[XAQueryFieldAttribute("대용가")]
		public long subprice;
		/// <summary>
		/// 전일종가
		/// </summary>
		[XAQueryFieldAttribute("전일종가")]
		public long recprice;
		/// <summary>
		/// 현재가
		/// </summary>
		[XAQueryFieldAttribute("현재가")]
		public long price;
		/// <summary>
		/// 전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("전일대비구분")]
		public char sign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[XAQueryFieldAttribute("전일대비")]
		public long change;
		/// <summary>
		/// 등락율
		/// </summary>
		[XAQueryFieldAttribute("등락율")]
		public float diff;
		/// <summary>
		/// 누적거래량
		/// </summary>
		[XAQueryFieldAttribute("누적거래량")]
		public long volume;

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
			/// 위탁증거금율
			/// </summary>
			public const string jkrate = "jkrate";
			/// <summary>
			/// 신용증거금율
			/// </summary>
			public const string sjkrate = "sjkrate";
			/// <summary>
			/// 대용가
			/// </summary>
			public const string subprice = "subprice";
			/// <summary>
			/// 전일종가
			/// </summary>
			public const string recprice = "recprice";
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
			/// 누적거래량
			/// </summary>
			public const string volume = "volume";
		}

		public static string[] AllFields = new string[]
		{
			F.shcode,
			F.hname,
			F.jkrate,
			F.sjkrate,
			F.subprice,
			F.recprice,
			F.price,
			F.sign,
			F.change,
			F.diff,
			F.volume,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "종목코드", (decimal)6);
			dict["hname"] = new XAQueryFieldInfo("char", hname, hname, "종목명", (decimal)20);
			dict["jkrate"] = new XAQueryFieldInfo("long", jkrate, jkrate.ToString("d3"), "위탁증거금율", (decimal)3);
			dict["sjkrate"] = new XAQueryFieldInfo("long", sjkrate, sjkrate.ToString("d3"), "신용증거금율", (decimal)3);
			dict["subprice"] = new XAQueryFieldInfo("long", subprice, subprice.ToString("d8"), "대용가", (decimal)8);
			dict["recprice"] = new XAQueryFieldInfo("long", recprice, recprice.ToString("d8"), "전일종가", (decimal)8);
			dict["price"] = new XAQueryFieldInfo("long", price, price.ToString("d8"), "현재가", (decimal)8);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("long", change, change.ToString("d8"), "전일대비", (decimal)8);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "누적거래량", (decimal)12);

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

				case "jkrate":
					this.jkrate = fieldInfo.FieldValue.ParseLong("jkrate");
				break;

				case "sjkrate":
					this.sjkrate = fieldInfo.FieldValue.ParseLong("sjkrate");
				break;

				case "subprice":
					this.subprice = fieldInfo.FieldValue.ParseLong("subprice");
				break;

				case "recprice":
					this.recprice = fieldInfo.FieldValue.ParseLong("recprice");
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


			}
		}

		public static XQt1411OutBlock1[] ListFromQuery(XQt1411 query)
		{
			int count = query.GetBlockCount(XQt1411OutBlock1.BlockName);
			List<XQt1411OutBlock1> list = new List<XQt1411OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1411OutBlock1 block = new XQt1411OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.shcode = query.GetFieldData(block.GetBlockName(), "shcode", i).TrimEnd('?'); // char 6
					block.hname = query.GetFieldData(block.GetBlockName(), "hname", i).TrimEnd('?'); // char 20
					block.jkrate = query.GetFieldData(block.GetBlockName(), "jkrate", i).ParseLong("jkrate"); // long 3
					block.sjkrate = query.GetFieldData(block.GetBlockName(), "sjkrate", i).ParseLong("sjkrate"); // long 3
					block.subprice = query.GetFieldData(block.GetBlockName(), "subprice", i).ParseLong("subprice"); // long 8
					block.recprice = query.GetFieldData(block.GetBlockName(), "recprice", i).ParseLong("recprice"); // long 8
					block.price = query.GetFieldData(block.GetBlockName(), "price", i).ParseLong("price"); // long 8
					block.sign = query.GetFieldData(block.GetBlockName(), "sign", i).FirstOrDefault(); // char 1
					block.change = query.GetFieldData(block.GetBlockName(), "change", i).ParseLong("change"); // long 8
					block.diff = query.GetFieldData(block.GetBlockName(), "diff", i).ParseFloat("diff"); // float 6.2
					block.volume = query.GetFieldData(block.GetBlockName(), "volume", i).ParseLong("volume"); // long 12

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
			if (jkrate.ToString().Length > 3) return false; // long 3
			if (sjkrate.ToString().Length > 3) return false; // long 3
			if (subprice.ToString().Length > 8) return false; // long 8
			if (recprice.ToString().Length > 8) return false; // long 8
			if (price.ToString().Length > 8) return false; // long 8
			// sign char 1
			if (change.ToString().Length > 8) return false; // long 8
			// diff float 6.2
			if (volume.ToString().Length > 12) return false; // long 12

			return true;
		}
	}

	public partial class XQt1411 : XingQuery
	{
		/// <summary>
		/// t1411
		/// </summary>
		public const string _typeName = "t1411";
		/// <summary>
		/// 증거금율별종목조회(t1411)
		/// </summary>
		public const string _typeDesc = "증거금율별종목조회(t1411)";
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
		/// t1411
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 증거금율별종목조회(t1411)
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

		public XQt1411() : base("t1411") { }


		public bool SetFields(XQt1411InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "gubun", 0, block.gubun.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "jongchk", 0, block.jongchk.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "jkrate", 0, block.jkrate.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "shcode", 0, block.shcode); // char 6
			_xaQuery.SetFieldData(block.GetBlockName(), "idx", 0, block.idx.ToString("d4")); // long 4

			return true;
		}

		public XQt1411OutBlock GetBlock()
		{
			XQt1411OutBlock instance = XQt1411OutBlock.FromQuery(this);
			return instance;

		}

		public XQt1411OutBlock1[] GetBlock1s()
		{
			XQt1411OutBlock1[] instance = XQt1411OutBlock1.ListFromQuery(this);
			return instance;

		}


	}

}
