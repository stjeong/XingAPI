using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1921InBlock : XingBlock
	{
		/// <summary>
		/// t1921InBlock
		/// </summary>
		public const string _blockName = "t1921InBlock";
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
		/// t1921InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1921InBlock
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
		/// <summary>
		/// 융자대주구분
		/// </summary>
		[XAQueryFieldAttribute("융자대주구분")]
		public char gubun;
		/// <summary>
		/// 날짜
		/// </summary>
		[XAQueryFieldAttribute("날짜")]
		public string date;
		/// <summary>
		/// IDX
		/// </summary>
		[XAQueryFieldAttribute("IDX")]
		public long idx;

		public static class F
		{
			/// <summary>
			/// 종목코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 융자대주구분
			/// </summary>
			public const string gubun = "gubun";
			/// <summary>
			/// 날짜
			/// </summary>
			public const string date = "date";
			/// <summary>
			/// IDX
			/// </summary>
			public const string idx = "idx";
		}

		public static string[] AllFields = new string[]
		{
			F.shcode,
			F.gubun,
			F.date,
			F.idx,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "종목코드", (decimal)6);
			dict["gubun"] = new XAQueryFieldInfo("char", gubun, gubun.ToString(), "융자대주구분", (decimal)1);
			dict["date"] = new XAQueryFieldInfo("char", date, date, "날짜", (decimal)8);
			dict["idx"] = new XAQueryFieldInfo("long", idx, idx.ToString("d4"), "IDX", (decimal)4);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "gubun":
					this.gubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "date":
					this.date = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "idx":
					this.idx = fieldInfo.FieldValue.ParseLong("idx");
				break;


			}
		}

		public bool VerifyData()
		{
			if (shcode?.Length > 6) return false; // char 6
			// gubun char 1
			if (date?.Length > 8) return false; // char 8
			if (idx.ToString().Length > 4) return false; // long 4

			return true;
		}
	}

	public partial class XQt1921OutBlock : XingBlock
	{
		/// <summary>
		/// t1921OutBlock
		/// </summary>
		public const string _blockName = "t1921OutBlock";
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
		/// t1921OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1921OutBlock
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
		/// CNT
		/// </summary>
		[XAQueryFieldAttribute("CNT")]
		public long cnt;
		/// <summary>
		/// 날짜
		/// </summary>
		[XAQueryFieldAttribute("날짜")]
		public string date;
		/// <summary>
		/// IDX
		/// </summary>
		[XAQueryFieldAttribute("IDX")]
		public long idx;

		public static class F
		{
			/// <summary>
			/// CNT
			/// </summary>
			public const string cnt = "cnt";
			/// <summary>
			/// 날짜
			/// </summary>
			public const string date = "date";
			/// <summary>
			/// IDX
			/// </summary>
			public const string idx = "idx";
		}

		public static string[] AllFields = new string[]
		{
			F.cnt,
			F.date,
			F.idx,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["cnt"] = new XAQueryFieldInfo("long", cnt, cnt.ToString("d4"), "CNT", (decimal)4);
			dict["date"] = new XAQueryFieldInfo("char", date, date, "날짜", (decimal)8);
			dict["idx"] = new XAQueryFieldInfo("long", idx, idx.ToString("d4"), "IDX", (decimal)4);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "cnt":
					this.cnt = fieldInfo.FieldValue.ParseLong("cnt");
				break;

				case "date":
					this.date = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "idx":
					this.idx = fieldInfo.FieldValue.ParseLong("idx");
				break;


			}
		}

		public static XQt1921OutBlock FromQuery(XQt1921 query)
		{
			XQt1921OutBlock block = new XQt1921OutBlock();
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
				block.cnt = query.GetFieldData(block.GetBlockName(), "cnt", 0).ParseLong("cnt"); // long 4
				block.date = query.GetFieldData(block.GetBlockName(), "date", 0).TrimEnd('?'); // char 8
				block.idx = query.GetFieldData(block.GetBlockName(), "idx", 0).ParseLong("idx"); // long 4

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (cnt.ToString().Length > 4) return false; // long 4
			if (date?.Length > 8) return false; // char 8
			if (idx.ToString().Length > 4) return false; // long 4

			return true;
		}
	}

	public partial class XQt1921OutBlock1 : XingBlock
	{
		/// <summary>
		/// t1921OutBlock1
		/// </summary>
		public const string _blockName = "t1921OutBlock1";
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
		/// t1921OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1921OutBlock1
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
		/// 날짜
		/// </summary>
		[XAQueryFieldAttribute("날짜")]
		public string mmdate;
		/// <summary>
		/// 종가
		/// </summary>
		[XAQueryFieldAttribute("종가")]
		public long close;
		/// <summary>
		/// 전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("전일대비구분")]
		public char sign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[XAQueryFieldAttribute("전일대비")]
		public long jchange;
		/// <summary>
		/// 등락율
		/// </summary>
		[XAQueryFieldAttribute("등락율")]
		public float diff;
		/// <summary>
		/// 신규
		/// </summary>
		[XAQueryFieldAttribute("신규")]
		public long nvolume;
		/// <summary>
		/// 상환
		/// </summary>
		[XAQueryFieldAttribute("상환")]
		public long svolume;
		/// <summary>
		/// 잔고
		/// </summary>
		[XAQueryFieldAttribute("잔고")]
		public long jvolume;
		/// <summary>
		/// 금액
		/// </summary>
		[XAQueryFieldAttribute("금액")]
		public long price;
		/// <summary>
		/// 대비
		/// </summary>
		[XAQueryFieldAttribute("대비")]
		public long change;
		/// <summary>
		/// 공여율
		/// </summary>
		[XAQueryFieldAttribute("공여율")]
		public float gyrate;
		/// <summary>
		/// 잔고율
		/// </summary>
		[XAQueryFieldAttribute("잔고율")]
		public float jkrate;
		/// <summary>
		/// 종목코드
		/// </summary>
		[XAQueryFieldAttribute("종목코드")]
		public string shcode;

		public static class F
		{
			/// <summary>
			/// 날짜
			/// </summary>
			public const string mmdate = "mmdate";
			/// <summary>
			/// 종가
			/// </summary>
			public const string close = "close";
			/// <summary>
			/// 전일대비구분
			/// </summary>
			public const string sign = "sign";
			/// <summary>
			/// 전일대비
			/// </summary>
			public const string jchange = "jchange";
			/// <summary>
			/// 등락율
			/// </summary>
			public const string diff = "diff";
			/// <summary>
			/// 신규
			/// </summary>
			public const string nvolume = "nvolume";
			/// <summary>
			/// 상환
			/// </summary>
			public const string svolume = "svolume";
			/// <summary>
			/// 잔고
			/// </summary>
			public const string jvolume = "jvolume";
			/// <summary>
			/// 금액
			/// </summary>
			public const string price = "price";
			/// <summary>
			/// 대비
			/// </summary>
			public const string change = "change";
			/// <summary>
			/// 공여율
			/// </summary>
			public const string gyrate = "gyrate";
			/// <summary>
			/// 잔고율
			/// </summary>
			public const string jkrate = "jkrate";
			/// <summary>
			/// 종목코드
			/// </summary>
			public const string shcode = "shcode";
		}

		public static string[] AllFields = new string[]
		{
			F.mmdate,
			F.close,
			F.sign,
			F.jchange,
			F.diff,
			F.nvolume,
			F.svolume,
			F.jvolume,
			F.price,
			F.change,
			F.gyrate,
			F.jkrate,
			F.shcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["mmdate"] = new XAQueryFieldInfo("char", mmdate, mmdate, "날짜", (decimal)8);
			dict["close"] = new XAQueryFieldInfo("long", close, close.ToString("d8"), "종가", (decimal)8);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["jchange"] = new XAQueryFieldInfo("long", jchange, jchange.ToString("d8"), "전일대비", (decimal)8);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["nvolume"] = new XAQueryFieldInfo("long", nvolume, nvolume.ToString("d8"), "신규", (decimal)8);
			dict["svolume"] = new XAQueryFieldInfo("long", svolume, svolume.ToString("d8"), "상환", (decimal)8);
			dict["jvolume"] = new XAQueryFieldInfo("long", jvolume, jvolume.ToString("d8"), "잔고", (decimal)8);
			dict["price"] = new XAQueryFieldInfo("long", price, price.ToString("d8"), "금액", (decimal)8);
			dict["change"] = new XAQueryFieldInfo("long", change, change.ToString("d8"), "대비", (decimal)8);
			dict["gyrate"] = new XAQueryFieldInfo("float", gyrate, gyrate.ToString("000000.00"), "공여율", (decimal)6.2);
			dict["jkrate"] = new XAQueryFieldInfo("float", jkrate, jkrate.ToString("000000.00"), "잔고율", (decimal)6.2);
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "종목코드", (decimal)6);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "mmdate":
					this.mmdate = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "close":
					this.close = fieldInfo.FieldValue.ParseLong("close");
				break;

				case "sign":
					this.sign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "jchange":
					this.jchange = fieldInfo.FieldValue.ParseLong("jchange");
				break;

				case "diff":
					this.diff = fieldInfo.FieldValue.ParseFloat("diff");
				break;

				case "nvolume":
					this.nvolume = fieldInfo.FieldValue.ParseLong("nvolume");
				break;

				case "svolume":
					this.svolume = fieldInfo.FieldValue.ParseLong("svolume");
				break;

				case "jvolume":
					this.jvolume = fieldInfo.FieldValue.ParseLong("jvolume");
				break;

				case "price":
					this.price = fieldInfo.FieldValue.ParseLong("price");
				break;

				case "change":
					this.change = fieldInfo.FieldValue.ParseLong("change");
				break;

				case "gyrate":
					this.gyrate = fieldInfo.FieldValue.ParseFloat("gyrate");
				break;

				case "jkrate":
					this.jkrate = fieldInfo.FieldValue.ParseFloat("jkrate");
				break;

				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt1921OutBlock1[] ListFromQuery(XQt1921 query)
		{
			int count = query.GetBlockCount(XQt1921OutBlock1.BlockName);
			List<XQt1921OutBlock1> list = new List<XQt1921OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1921OutBlock1 block = new XQt1921OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.mmdate = query.GetFieldData(block.GetBlockName(), "mmdate", i).TrimEnd('?'); // char 8
					block.close = query.GetFieldData(block.GetBlockName(), "close", i).ParseLong("close"); // long 8
					block.sign = query.GetFieldData(block.GetBlockName(), "sign", i).FirstOrDefault(); // char 1
					block.jchange = query.GetFieldData(block.GetBlockName(), "jchange", i).ParseLong("jchange"); // long 8
					block.diff = query.GetFieldData(block.GetBlockName(), "diff", i).ParseFloat("diff"); // float 6.2
					block.nvolume = query.GetFieldData(block.GetBlockName(), "nvolume", i).ParseLong("nvolume"); // long 8
					block.svolume = query.GetFieldData(block.GetBlockName(), "svolume", i).ParseLong("svolume"); // long 8
					block.jvolume = query.GetFieldData(block.GetBlockName(), "jvolume", i).ParseLong("jvolume"); // long 8
					block.price = query.GetFieldData(block.GetBlockName(), "price", i).ParseLong("price"); // long 8
					block.change = query.GetFieldData(block.GetBlockName(), "change", i).ParseLong("change"); // long 8
					block.gyrate = query.GetFieldData(block.GetBlockName(), "gyrate", i).ParseFloat("gyrate"); // float 6.2
					block.jkrate = query.GetFieldData(block.GetBlockName(), "jkrate", i).ParseFloat("jkrate"); // float 6.2
					block.shcode = query.GetFieldData(block.GetBlockName(), "shcode", i).TrimEnd('?'); // char 6

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
			if (mmdate?.Length > 8) return false; // char 8
			if (close.ToString().Length > 8) return false; // long 8
			// sign char 1
			if (jchange.ToString().Length > 8) return false; // long 8
			// diff float 6.2
			if (nvolume.ToString().Length > 8) return false; // long 8
			if (svolume.ToString().Length > 8) return false; // long 8
			if (jvolume.ToString().Length > 8) return false; // long 8
			if (price.ToString().Length > 8) return false; // long 8
			if (change.ToString().Length > 8) return false; // long 8
			// gyrate float 6.2
			// jkrate float 6.2
			if (shcode?.Length > 6) return false; // char 6

			return true;
		}
	}

	/// <summary>
	/// 신용거래동향(t1921)
	/// </summary>
	public partial class XQt1921 : XingQuery
	{
		/// <summary>
		/// t1921
		/// </summary>
		public const string _typeName = "t1921";
		/// <summary>
		/// 신용거래동향(t1921)
		/// </summary>
		public const string _typeDesc = "신용거래동향(t1921)";
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
		/// t1921
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 신용거래동향(t1921)
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
		/// 신용거래동향(t1921)
		/// </summary>
		public XQt1921() : base("t1921") { }


		public static XQt1921OutBlock1[] Get(string shcode = default,char gubun = default,string date = default,long idx = default)
		{
			using (XQt1921 instance = new XQt1921())
			{
				instance.SetFieldData(XQt1921InBlock.BlockName, XQt1921InBlock.F.shcode, 0, shcode); // char 6
				instance.SetFieldData(XQt1921InBlock.BlockName, XQt1921InBlock.F.gubun, 0, gubun.ToString()); // char 1
				instance.SetFieldData(XQt1921InBlock.BlockName, XQt1921InBlock.F.date, 0, date); // char 8
				instance.SetFieldData(XQt1921InBlock.BlockName, XQt1921InBlock.F.idx, 0, idx.ToString("d4")); // long 4

				if (instance.Request() < 0)
				{
					return null;
				}

				var outBlock = instance.GetBlock1s();
				return outBlock;
			}
		}

		public bool SetBlock(XQt1921InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "shcode", 0, block.shcode); // char 6
			_xaQuery.SetFieldData(block.GetBlockName(), "gubun", 0, block.gubun.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "date", 0, block.date); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "idx", 0, block.idx.ToString("d4")); // long 4

			return true;
		}

		public XQt1921OutBlock GetBlock()
		{
			XQt1921OutBlock instance = XQt1921OutBlock.FromQuery(this);
			return instance;

		}

		public XQt1921OutBlock1[] GetBlock1s()
		{
			XQt1921OutBlock1[] instance = XQt1921OutBlock1.ListFromQuery(this);
			return instance;

		}


	}

}
