using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1959InBlock : XingBlock
	{
		/// <summary>
		/// t1959InBlock
		/// </summary>
		public const string _blockName = "t1959InBlock";
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
		/// t1959InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1959InBlock
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
		public string shcode;

		public static class F
		{
			/// <summary>
			/// 종목코드
			/// </summary>
			public const string shcode = "shcode";
		}

		public static string[] AllFields = new string[]
		{
			F.shcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "종목코드", (decimal)6);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (shcode?.Length > 6) return false; // char 6

			return true;
		}
	}

	public partial class XQt1959OutBlock1 : XingBlock
	{
		/// <summary>
		/// t1959OutBlock1
		/// </summary>
		public const string _blockName = "t1959OutBlock1";
		/// <summary>
		/// LP대상전종목정보
		/// </summary>
		public const string _blockDesc = "LP대상전종목정보";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// true
		/// </summary>
		public const bool _hasOccurs = true;
		/// <summary>
		/// t1959OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1959OutBlock1
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// LP대상전종목정보
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
		/// 현재가
		/// </summary>
		[XAQueryFieldAttribute("현재가")]
		public string price;
		/// <summary>
		/// 부호
		/// </summary>
		[XAQueryFieldAttribute("부호")]
		public char sign;
		/// <summary>
		/// 대비
		/// </summary>
		[XAQueryFieldAttribute("대비")]
		public string change;
		/// <summary>
		/// 등락율
		/// </summary>
		[XAQueryFieldAttribute("등락율")]
		public float rate;
		/// <summary>
		/// 누적거래량
		/// </summary>
		[XAQueryFieldAttribute("누적거래량")]
		public string volume;
		/// <summary>
		/// 누적거래대금
		/// </summary>
		[XAQueryFieldAttribute("누적거래대금")]
		public string value;
		/// <summary>
		/// LP주문가능여부
		/// </summary>
		[XAQueryFieldAttribute("LP주문가능여부")]
		public string lp_gb;
		/// <summary>
		/// LP회원사명1
		/// </summary>
		[XAQueryFieldAttribute("LP회원사명1")]
		public string lp_mem_nm1;
		/// <summary>
		/// LP회원사명2
		/// </summary>
		[XAQueryFieldAttribute("LP회원사명2")]
		public string lp_mem_nm2;
		/// <summary>
		/// LP회원사명3
		/// </summary>
		[XAQueryFieldAttribute("LP회원사명3")]
		public string lp_mem_nm3;
		/// <summary>
		/// LP회원사명4
		/// </summary>
		[XAQueryFieldAttribute("LP회원사명4")]
		public string lp_mem_nm4;
		/// <summary>
		/// LP회원사명5
		/// </summary>
		[XAQueryFieldAttribute("LP회원사명5")]
		public string lp_mem_nm5;
		/// <summary>
		/// LP최소호가수량
		/// </summary>
		[XAQueryFieldAttribute("LP최소호가수량")]
		public string lp_min_qty;
		/// <summary>
		/// LP시작일
		/// </summary>
		[XAQueryFieldAttribute("LP시작일")]
		public string lp_st_date;
		/// <summary>
		/// LP종료일
		/// </summary>
		[XAQueryFieldAttribute("LP종료일")]
		public string lp_end_date;
		/// <summary>
		/// LP스프레드
		/// </summary>
		[XAQueryFieldAttribute("LP스프레드")]
		public float lp_spread;

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
			/// 부호
			/// </summary>
			public const string sign = "sign";
			/// <summary>
			/// 대비
			/// </summary>
			public const string change = "change";
			/// <summary>
			/// 등락율
			/// </summary>
			public const string rate = "rate";
			/// <summary>
			/// 누적거래량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// 누적거래대금
			/// </summary>
			public const string value = "value";
			/// <summary>
			/// LP주문가능여부
			/// </summary>
			public const string lp_gb = "lp_gb";
			/// <summary>
			/// LP회원사명1
			/// </summary>
			public const string lp_mem_nm1 = "lp_mem_nm1";
			/// <summary>
			/// LP회원사명2
			/// </summary>
			public const string lp_mem_nm2 = "lp_mem_nm2";
			/// <summary>
			/// LP회원사명3
			/// </summary>
			public const string lp_mem_nm3 = "lp_mem_nm3";
			/// <summary>
			/// LP회원사명4
			/// </summary>
			public const string lp_mem_nm4 = "lp_mem_nm4";
			/// <summary>
			/// LP회원사명5
			/// </summary>
			public const string lp_mem_nm5 = "lp_mem_nm5";
			/// <summary>
			/// LP최소호가수량
			/// </summary>
			public const string lp_min_qty = "lp_min_qty";
			/// <summary>
			/// LP시작일
			/// </summary>
			public const string lp_st_date = "lp_st_date";
			/// <summary>
			/// LP종료일
			/// </summary>
			public const string lp_end_date = "lp_end_date";
			/// <summary>
			/// LP스프레드
			/// </summary>
			public const string lp_spread = "lp_spread";
		}

		public static string[] AllFields = new string[]
		{
			F.shcode,
			F.hname,
			F.price,
			F.sign,
			F.change,
			F.rate,
			F.volume,
			F.value,
			F.lp_gb,
			F.lp_mem_nm1,
			F.lp_mem_nm2,
			F.lp_mem_nm3,
			F.lp_mem_nm4,
			F.lp_mem_nm5,
			F.lp_min_qty,
			F.lp_st_date,
			F.lp_end_date,
			F.lp_spread,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "종목코드", (decimal)6);
			dict["hname"] = new XAQueryFieldInfo("char", hname, hname, "종목명", (decimal)40);
			dict["price"] = new XAQueryFieldInfo("char", price, price, "현재가", (decimal)12);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "부호", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("char", change, change, "대비", (decimal)12);
			dict["rate"] = new XAQueryFieldInfo("float", rate, rate.ToString("00000.00"), "등락율", (decimal)5.2);
			dict["volume"] = new XAQueryFieldInfo("char", volume, volume, "누적거래량", (decimal)12);
			dict["value"] = new XAQueryFieldInfo("char", value, value, "누적거래대금", (decimal)12);
			dict["lp_gb"] = new XAQueryFieldInfo("char", lp_gb, lp_gb, "LP주문가능여부", (decimal)4);
			dict["lp_mem_nm1"] = new XAQueryFieldInfo("char", lp_mem_nm1, lp_mem_nm1, "LP회원사명1", (decimal)20);
			dict["lp_mem_nm2"] = new XAQueryFieldInfo("char", lp_mem_nm2, lp_mem_nm2, "LP회원사명2", (decimal)20);
			dict["lp_mem_nm3"] = new XAQueryFieldInfo("char", lp_mem_nm3, lp_mem_nm3, "LP회원사명3", (decimal)20);
			dict["lp_mem_nm4"] = new XAQueryFieldInfo("char", lp_mem_nm4, lp_mem_nm4, "LP회원사명4", (decimal)20);
			dict["lp_mem_nm5"] = new XAQueryFieldInfo("char", lp_mem_nm5, lp_mem_nm5, "LP회원사명5", (decimal)20);
			dict["lp_min_qty"] = new XAQueryFieldInfo("char", lp_min_qty, lp_min_qty, "LP최소호가수량", (decimal)10);
			dict["lp_st_date"] = new XAQueryFieldInfo("char", lp_st_date, lp_st_date, "LP시작일", (decimal)8);
			dict["lp_end_date"] = new XAQueryFieldInfo("char", lp_end_date, lp_end_date, "LP종료일", (decimal)8);
			dict["lp_spread"] = new XAQueryFieldInfo("float", lp_spread, lp_spread.ToString("00000.00"), "LP스프레드", (decimal)5.2);

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
					this.price = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "sign":
					this.sign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "change":
					this.change = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "rate":
					this.rate = fieldInfo.FieldValue.ParseFloat("rate");
				break;

				case "volume":
					this.volume = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "value":
					this.value = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "lp_gb":
					this.lp_gb = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "lp_mem_nm1":
					this.lp_mem_nm1 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "lp_mem_nm2":
					this.lp_mem_nm2 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "lp_mem_nm3":
					this.lp_mem_nm3 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "lp_mem_nm4":
					this.lp_mem_nm4 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "lp_mem_nm5":
					this.lp_mem_nm5 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "lp_min_qty":
					this.lp_min_qty = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "lp_st_date":
					this.lp_st_date = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "lp_end_date":
					this.lp_end_date = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "lp_spread":
					this.lp_spread = fieldInfo.FieldValue.ParseFloat("lp_spread");
				break;


			}
		}

		public static XQt1959OutBlock1[] ListFromQuery(XQt1959 query)
		{
			int count = query.GetBlockCount(XQt1959OutBlock1.BlockName);
			List<XQt1959OutBlock1> list = new List<XQt1959OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1959OutBlock1 block = new XQt1959OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.shcode = query.GetFieldData(block.GetBlockName(), "shcode", i).TrimEnd('?'); // char 6
					block.hname = query.GetFieldData(block.GetBlockName(), "hname", i).TrimEnd('?'); // char 40
					block.price = query.GetFieldData(block.GetBlockName(), "price", i).TrimEnd('?'); // char 12
					block.sign = query.GetFieldData(block.GetBlockName(), "sign", i).FirstOrDefault(); // char 1
					block.change = query.GetFieldData(block.GetBlockName(), "change", i).TrimEnd('?'); // char 12
					block.rate = query.GetFieldData(block.GetBlockName(), "rate", i).ParseFloat("rate"); // float 5.2
					block.volume = query.GetFieldData(block.GetBlockName(), "volume", i).TrimEnd('?'); // char 12
					block.value = query.GetFieldData(block.GetBlockName(), "value", i).TrimEnd('?'); // char 12
					block.lp_gb = query.GetFieldData(block.GetBlockName(), "lp_gb", i).TrimEnd('?'); // char 4
					block.lp_mem_nm1 = query.GetFieldData(block.GetBlockName(), "lp_mem_nm1", i).TrimEnd('?'); // char 20
					block.lp_mem_nm2 = query.GetFieldData(block.GetBlockName(), "lp_mem_nm2", i).TrimEnd('?'); // char 20
					block.lp_mem_nm3 = query.GetFieldData(block.GetBlockName(), "lp_mem_nm3", i).TrimEnd('?'); // char 20
					block.lp_mem_nm4 = query.GetFieldData(block.GetBlockName(), "lp_mem_nm4", i).TrimEnd('?'); // char 20
					block.lp_mem_nm5 = query.GetFieldData(block.GetBlockName(), "lp_mem_nm5", i).TrimEnd('?'); // char 20
					block.lp_min_qty = query.GetFieldData(block.GetBlockName(), "lp_min_qty", i).TrimEnd('?'); // char 10
					block.lp_st_date = query.GetFieldData(block.GetBlockName(), "lp_st_date", i).TrimEnd('?'); // char 8
					block.lp_end_date = query.GetFieldData(block.GetBlockName(), "lp_end_date", i).TrimEnd('?'); // char 8
					block.lp_spread = query.GetFieldData(block.GetBlockName(), "lp_spread", i).ParseFloat("lp_spread"); // float 5.2

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
			if (hname?.Length > 40) return false; // char 40
			if (price?.Length > 12) return false; // char 12
			// sign char 1
			if (change?.Length > 12) return false; // char 12
			// rate float 5.2
			if (volume?.Length > 12) return false; // char 12
			if (value?.Length > 12) return false; // char 12
			if (lp_gb?.Length > 4) return false; // char 4
			if (lp_mem_nm1?.Length > 20) return false; // char 20
			if (lp_mem_nm2?.Length > 20) return false; // char 20
			if (lp_mem_nm3?.Length > 20) return false; // char 20
			if (lp_mem_nm4?.Length > 20) return false; // char 20
			if (lp_mem_nm5?.Length > 20) return false; // char 20
			if (lp_min_qty?.Length > 10) return false; // char 10
			if (lp_st_date?.Length > 8) return false; // char 8
			if (lp_end_date?.Length > 8) return false; // char 8
			// lp_spread float 5.2

			return true;
		}
	}

	/// <summary>
	/// LP대상종목정보조회(t1959)
	/// </summary>
	public partial class XQt1959 : XingQuery
	{
		/// <summary>
		/// t1959
		/// </summary>
		public const string _typeName = "t1959";
		/// <summary>
		/// LP대상종목정보조회(t1959)
		/// </summary>
		public const string _typeDesc = "LP대상종목정보조회(t1959)";
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
		/// t1959
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// LP대상종목정보조회(t1959)
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
		/// LP대상종목정보조회(t1959)
		/// </summary>
		public XQt1959() : base("t1959") { }


		public static XQt1959OutBlock1[] Get(string shcode = default)
		{
			using (XQt1959 instance = new XQt1959())
			{
				instance.SetFieldData(XQt1959InBlock.BlockName, XQt1959InBlock.F.shcode, 0, shcode); // char 6

				if (instance.Request() < 0)
				{
					return null;
				}

				var outBlock = instance.GetBlock1s();
				return outBlock;
			}
		}

		public bool SetBlock(XQt1959InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "shcode", 0, block.shcode); // char 6

			return true;
		}

		public XQt1959OutBlock1[] GetBlock1s()
		{
			XQt1959OutBlock1[] instance = XQt1959OutBlock1.ListFromQuery(this);
			return instance;

		}


	}

}
