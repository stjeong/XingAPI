using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1903InBlock : XingBlock
	{
		/// <summary>
		/// t1903InBlock
		/// </summary>
		public const string _blockName = "t1903InBlock";
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
		/// t1903InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1903InBlock
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
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("shcode", "단축코드", "char", "6")]
		public string shcode;
		/// <summary>
		/// 일자
		/// </summary>
		[XAQueryFieldAttribute("date", "일자", "char", "8")]
		public string date;

		public static class F
		{
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 일자
			/// </summary>
			public const string date = "date";
		}

		public static string[] AllFields = new string[]
		{
			F.shcode,
			F.date,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)6);
			dict["date"] = new XAQueryFieldInfo("char", date, date, "일자", (decimal)8);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "date":
					this.date = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (shcode?.Length > 6) return false; // char 6
			if (date?.Length > 8) return false; // char 8

			return true;
		}
	}

	public partial class XQt1903OutBlock : XingBlock
	{
		/// <summary>
		/// t1903OutBlock
		/// </summary>
		public const string _blockName = "t1903OutBlock";
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
		/// t1903OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1903OutBlock
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
		/// 일자
		/// </summary>
		[XAQueryFieldAttribute("date", "일자", "char", "8")]
		public string date;
		/// <summary>
		/// 종목명
		/// </summary>
		[XAQueryFieldAttribute("hname", "종목명", "char", "20")]
		public string hname;
		/// <summary>
		/// 업종지수명
		/// </summary>
		[XAQueryFieldAttribute("upname", "업종지수명", "char", "20")]
		public string upname;

		public static class F
		{
			/// <summary>
			/// 일자
			/// </summary>
			public const string date = "date";
			/// <summary>
			/// 종목명
			/// </summary>
			public const string hname = "hname";
			/// <summary>
			/// 업종지수명
			/// </summary>
			public const string upname = "upname";
		}

		public static string[] AllFields = new string[]
		{
			F.date,
			F.hname,
			F.upname,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["date"] = new XAQueryFieldInfo("char", date, date, "일자", (decimal)8);
			dict["hname"] = new XAQueryFieldInfo("char", hname, hname, "종목명", (decimal)20);
			dict["upname"] = new XAQueryFieldInfo("char", upname, upname, "업종지수명", (decimal)20);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "date":
					this.date = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "hname":
					this.hname = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "upname":
					this.upname = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt1903OutBlock FromQuery(XQt1903 query)
		{
			XQt1903OutBlock block = new XQt1903OutBlock();
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
				block.date = query.GetFieldData(block.GetBlockName(), "date", 0).TrimEnd('?'); // char 8
				block.hname = query.GetFieldData(block.GetBlockName(), "hname", 0).TrimEnd('?'); // char 20
				block.upname = query.GetFieldData(block.GetBlockName(), "upname", 0).TrimEnd('?'); // char 20

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (date?.Length > 8) return false; // char 8
			if (hname?.Length > 20) return false; // char 20
			if (upname?.Length > 20) return false; // char 20

			return true;
		}
	}

	public partial class XQt1903OutBlock1 : XingBlock
	{
		/// <summary>
		/// t1903OutBlock1
		/// </summary>
		public const string _blockName = "t1903OutBlock1";
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
		/// t1903OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1903OutBlock1
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
		/// 일자
		/// </summary>
		[XAQueryFieldAttribute("date", "일자", "char", "8")]
		public string date;
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
		/// 누적거래량
		/// </summary>
		[XAQueryFieldAttribute("volume", "누적거래량", "float", "12")]
		public float volume;
		/// <summary>
		/// NAV대비
		/// </summary>
		[XAQueryFieldAttribute("navdiff", "NAV대비", "float", "9.2")]
		public float navdiff;
		/// <summary>
		/// NAV
		/// </summary>
		[XAQueryFieldAttribute("nav", "NAV", "float", "9.2")]
		public float nav;
		/// <summary>
		/// 전일대비
		/// </summary>
		[XAQueryFieldAttribute("navchange", "전일대비", "float", "9.2")]
		public float navchange;
		/// <summary>
		/// 추적오차
		/// </summary>
		[XAQueryFieldAttribute("crate", "추적오차", "float", "9.2")]
		public float crate;
		/// <summary>
		/// 괴리
		/// </summary>
		[XAQueryFieldAttribute("grate", "괴리", "float", "9.2")]
		public float grate;
		/// <summary>
		/// 지수
		/// </summary>
		[XAQueryFieldAttribute("jisu", "지수", "float", "8.2")]
		public float jisu;
		/// <summary>
		/// 전일대비
		/// </summary>
		[XAQueryFieldAttribute("jichange", "전일대비", "float", "8.2")]
		public float jichange;
		/// <summary>
		/// 전일대비율
		/// </summary>
		[XAQueryFieldAttribute("jirate", "전일대비율", "float", "8.2")]
		public float jirate;

		public static class F
		{
			/// <summary>
			/// 일자
			/// </summary>
			public const string date = "date";
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
			/// 누적거래량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// NAV대비
			/// </summary>
			public const string navdiff = "navdiff";
			/// <summary>
			/// NAV
			/// </summary>
			public const string nav = "nav";
			/// <summary>
			/// 전일대비
			/// </summary>
			public const string navchange = "navchange";
			/// <summary>
			/// 추적오차
			/// </summary>
			public const string crate = "crate";
			/// <summary>
			/// 괴리
			/// </summary>
			public const string grate = "grate";
			/// <summary>
			/// 지수
			/// </summary>
			public const string jisu = "jisu";
			/// <summary>
			/// 전일대비
			/// </summary>
			public const string jichange = "jichange";
			/// <summary>
			/// 전일대비율
			/// </summary>
			public const string jirate = "jirate";
		}

		public static string[] AllFields = new string[]
		{
			F.date,
			F.price,
			F.sign,
			F.change,
			F.volume,
			F.navdiff,
			F.nav,
			F.navchange,
			F.crate,
			F.grate,
			F.jisu,
			F.jichange,
			F.jirate,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["date"] = new XAQueryFieldInfo("char", date, date, "일자", (decimal)8);
			dict["price"] = new XAQueryFieldInfo("long", price, price.ToString("d8"), "현재가", (decimal)8);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("long", change, change.ToString("d8"), "전일대비", (decimal)8);
			dict["volume"] = new XAQueryFieldInfo("float", volume, volume.ToString("000000000000"), "누적거래량", (decimal)12);
			dict["navdiff"] = new XAQueryFieldInfo("float", navdiff, navdiff.ToString("000000000.00"), "NAV대비", (decimal)9.2);
			dict["nav"] = new XAQueryFieldInfo("float", nav, nav.ToString("000000000.00"), "NAV", (decimal)9.2);
			dict["navchange"] = new XAQueryFieldInfo("float", navchange, navchange.ToString("000000000.00"), "전일대비", (decimal)9.2);
			dict["crate"] = new XAQueryFieldInfo("float", crate, crate.ToString("000000000.00"), "추적오차", (decimal)9.2);
			dict["grate"] = new XAQueryFieldInfo("float", grate, grate.ToString("000000000.00"), "괴리", (decimal)9.2);
			dict["jisu"] = new XAQueryFieldInfo("float", jisu, jisu.ToString("00000000.00"), "지수", (decimal)8.2);
			dict["jichange"] = new XAQueryFieldInfo("float", jichange, jichange.ToString("00000000.00"), "전일대비", (decimal)8.2);
			dict["jirate"] = new XAQueryFieldInfo("float", jirate, jirate.ToString("00000000.00"), "전일대비율", (decimal)8.2);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "date":
					this.date = fieldInfo.FieldValue.TrimEnd('?');
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

				case "volume":
					this.volume = fieldInfo.FieldValue.ParseFloat("volume");
				break;

				case "navdiff":
					this.navdiff = fieldInfo.FieldValue.ParseFloat("navdiff");
				break;

				case "nav":
					this.nav = fieldInfo.FieldValue.ParseFloat("nav");
				break;

				case "navchange":
					this.navchange = fieldInfo.FieldValue.ParseFloat("navchange");
				break;

				case "crate":
					this.crate = fieldInfo.FieldValue.ParseFloat("crate");
				break;

				case "grate":
					this.grate = fieldInfo.FieldValue.ParseFloat("grate");
				break;

				case "jisu":
					this.jisu = fieldInfo.FieldValue.ParseFloat("jisu");
				break;

				case "jichange":
					this.jichange = fieldInfo.FieldValue.ParseFloat("jichange");
				break;

				case "jirate":
					this.jirate = fieldInfo.FieldValue.ParseFloat("jirate");
				break;


			}
		}

		public static XQt1903OutBlock1[] ListFromQuery(XQt1903 query)
		{
			int count = query.GetBlockCount(XQt1903OutBlock1.BlockName);
			List<XQt1903OutBlock1> list = new List<XQt1903OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1903OutBlock1 block = new XQt1903OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.date = query.GetFieldData(block.GetBlockName(), "date", i).TrimEnd('?'); // char 8
					block.price = query.GetFieldData(block.GetBlockName(), "price", i).ParseLong("price"); // long 8
					block.sign = query.GetFieldData(block.GetBlockName(), "sign", i).FirstOrDefault(); // char 1
					block.change = query.GetFieldData(block.GetBlockName(), "change", i).ParseLong("change"); // long 8
					block.volume = query.GetFieldData(block.GetBlockName(), "volume", i).ParseFloat("volume"); // float 12
					block.navdiff = query.GetFieldData(block.GetBlockName(), "navdiff", i).ParseFloat("navdiff"); // float 9.2
					block.nav = query.GetFieldData(block.GetBlockName(), "nav", i).ParseFloat("nav"); // float 9.2
					block.navchange = query.GetFieldData(block.GetBlockName(), "navchange", i).ParseFloat("navchange"); // float 9.2
					block.crate = query.GetFieldData(block.GetBlockName(), "crate", i).ParseFloat("crate"); // float 9.2
					block.grate = query.GetFieldData(block.GetBlockName(), "grate", i).ParseFloat("grate"); // float 9.2
					block.jisu = query.GetFieldData(block.GetBlockName(), "jisu", i).ParseFloat("jisu"); // float 8.2
					block.jichange = query.GetFieldData(block.GetBlockName(), "jichange", i).ParseFloat("jichange"); // float 8.2
					block.jirate = query.GetFieldData(block.GetBlockName(), "jirate", i).ParseFloat("jirate"); // float 8.2

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
			if (date?.Length > 8) return false; // char 8
			if (price.ToString().Length > 8) return false; // long 8
			// sign char 1
			if (change.ToString().Length > 8) return false; // long 8
			// volume float 12
			// navdiff float 9.2
			// nav float 9.2
			// navchange float 9.2
			// crate float 9.2
			// grate float 9.2
			// jisu float 8.2
			// jichange float 8.2
			// jirate float 8.2

			return true;
		}
	}

	/// <summary>
	/// ETF일별추이(t1903)
	/// </summary>
	public partial class XQt1903 : XingQuery
	{
		/// <summary>
		/// t1903
		/// </summary>
		public const string _typeName = "t1903";
		/// <summary>
		/// ETF일별추이(t1903)
		/// </summary>
		public const string _typeDesc = "ETF일별추이(t1903)";
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
		/// t1903
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// ETF일별추이(t1903)
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
		/// ETF일별추이(t1903)
		/// </summary>
		public XQt1903() : base("t1903") { }


		public class XQAllOutBlocks
		{
			public XQt1903OutBlock OutBlock { get; internal set; }
			public XQt1903OutBlock1[] OutBlock1 { get; internal set; }
		}

		public static XQAllOutBlocks Get(string shcode = default,string date = default)
		{
			using (XQt1903 instance = new XQt1903())
			{
				instance.SetFieldData(XQt1903InBlock.BlockName, XQt1903InBlock.F.shcode, 0, shcode); // char 6
				instance.SetFieldData(XQt1903InBlock.BlockName, XQt1903InBlock.F.date, 0, date); // char 8

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

		public bool SetBlock(XQt1903InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "shcode", 0, block.shcode); // char 6
			_xaQuery.SetFieldData(block.GetBlockName(), "date", 0, block.date); // char 8

			return true;
		}

		public XQt1903OutBlock GetBlock()
		{
			XQt1903OutBlock instance = XQt1903OutBlock.FromQuery(this);
			return instance;

		}

		public XQt1903OutBlock1[] GetBlock1s()
		{
			XQt1903OutBlock1[] instance = XQt1903OutBlock1.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt1903OutBlock),
			typeof(XQt1903OutBlock1),

		};

	}

}
