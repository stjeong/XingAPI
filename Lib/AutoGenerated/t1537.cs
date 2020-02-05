using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1537InBlock : XingBlock
	{
		/// <summary>
		/// t1537InBlock
		/// </summary>
		public const string _blockName = "t1537InBlock";
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
		/// t1537InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1537InBlock
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
		/// 테마코드
		/// </summary>
		[XAQueryFieldAttribute("테마코드")]
		public string tmcode;

		public static class F
		{
			/// <summary>
			/// 테마코드
			/// </summary>
			public const string tmcode = "tmcode";
		}

		public static string[] AllFields = new string[]
		{
			F.tmcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["tmcode"] = new XAQueryFieldInfo("char", tmcode, tmcode, "테마코드", (decimal)4);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "tmcode":
					this.tmcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (tmcode?.Length > 4) return false; // char 4

			return true;
		}
	}

	public partial class XQt1537OutBlock : XingBlock
	{
		/// <summary>
		/// t1537OutBlock
		/// </summary>
		public const string _blockName = "t1537OutBlock";
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
		/// t1537OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1537OutBlock
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
		/// 상승종목수
		/// </summary>
		[XAQueryFieldAttribute("상승종목수")]
		public long upcnt;
		/// <summary>
		/// 테마종목수
		/// </summary>
		[XAQueryFieldAttribute("테마종목수")]
		public long tmcnt;
		/// <summary>
		/// 상승종목비율
		/// </summary>
		[XAQueryFieldAttribute("상승종목비율")]
		public long uprate;
		/// <summary>
		/// 테마명
		/// </summary>
		[XAQueryFieldAttribute("테마명")]
		public string tmname;

		public static class F
		{
			/// <summary>
			/// 상승종목수
			/// </summary>
			public const string upcnt = "upcnt";
			/// <summary>
			/// 테마종목수
			/// </summary>
			public const string tmcnt = "tmcnt";
			/// <summary>
			/// 상승종목비율
			/// </summary>
			public const string uprate = "uprate";
			/// <summary>
			/// 테마명
			/// </summary>
			public const string tmname = "tmname";
		}

		public static string[] AllFields = new string[]
		{
			F.upcnt,
			F.tmcnt,
			F.uprate,
			F.tmname,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["upcnt"] = new XAQueryFieldInfo("long", upcnt, upcnt.ToString("d4"), "상승종목수", (decimal)4);
			dict["tmcnt"] = new XAQueryFieldInfo("long", tmcnt, tmcnt.ToString("d4"), "테마종목수", (decimal)4);
			dict["uprate"] = new XAQueryFieldInfo("long", uprate, uprate.ToString("d4"), "상승종목비율", (decimal)4);
			dict["tmname"] = new XAQueryFieldInfo("char", tmname, tmname, "테마명", (decimal)36);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "upcnt":
					this.upcnt = fieldInfo.FieldValue.ParseLong("upcnt");
				break;

				case "tmcnt":
					this.tmcnt = fieldInfo.FieldValue.ParseLong("tmcnt");
				break;

				case "uprate":
					this.uprate = fieldInfo.FieldValue.ParseLong("uprate");
				break;

				case "tmname":
					this.tmname = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt1537OutBlock FromQuery(XQt1537 query)
		{
			XQt1537OutBlock block = new XQt1537OutBlock();
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
				block.upcnt = query.GetFieldData(block.GetBlockName(), "upcnt", 0).ParseLong("upcnt"); // long 4
				block.tmcnt = query.GetFieldData(block.GetBlockName(), "tmcnt", 0).ParseLong("tmcnt"); // long 4
				block.uprate = query.GetFieldData(block.GetBlockName(), "uprate", 0).ParseLong("uprate"); // long 4
				block.tmname = query.GetFieldData(block.GetBlockName(), "tmname", 0).TrimEnd('?'); // char 36

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (upcnt.ToString().Length > 4) return false; // long 4
			if (tmcnt.ToString().Length > 4) return false; // long 4
			if (uprate.ToString().Length > 4) return false; // long 4
			if (tmname?.Length > 36) return false; // char 36

			return true;
		}
	}

	public partial class XQt1537OutBlock1 : XingBlock
	{
		/// <summary>
		/// t1537OutBlock1
		/// </summary>
		public const string _blockName = "t1537OutBlock1";
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
		/// t1537OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1537OutBlock1
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
		/// <summary>
		/// 전일동시간
		/// </summary>
		[XAQueryFieldAttribute("전일동시간")]
		public float jniltime;
		/// <summary>
		/// 종목코드
		/// </summary>
		[XAQueryFieldAttribute("종목코드")]
		public string shcode;
		/// <summary>
		/// 예상체결가
		/// </summary>
		[XAQueryFieldAttribute("예상체결가")]
		public long yeprice;
		/// <summary>
		/// 시가
		/// </summary>
		[XAQueryFieldAttribute("시가")]
		public long open;
		/// <summary>
		/// 고가
		/// </summary>
		[XAQueryFieldAttribute("고가")]
		public long high;
		/// <summary>
		/// 저가
		/// </summary>
		[XAQueryFieldAttribute("저가")]
		public long low;
		/// <summary>
		/// 누적거래대금(단위:백만)
		/// </summary>
		[XAQueryFieldAttribute("누적거래대금(단위:백만)")]
		public long value;
		/// <summary>
		/// 시가총액(단위:백만)
		/// </summary>
		[XAQueryFieldAttribute("시가총액(단위:백만)")]
		public long marketcap;

		public static class F
		{
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
			/// 누적거래량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// 전일동시간
			/// </summary>
			public const string jniltime = "jniltime";
			/// <summary>
			/// 종목코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 예상체결가
			/// </summary>
			public const string yeprice = "yeprice";
			/// <summary>
			/// 시가
			/// </summary>
			public const string open = "open";
			/// <summary>
			/// 고가
			/// </summary>
			public const string high = "high";
			/// <summary>
			/// 저가
			/// </summary>
			public const string low = "low";
			/// <summary>
			/// 누적거래대금(단위:백만)
			/// </summary>
			public const string value = "value";
			/// <summary>
			/// 시가총액(단위:백만)
			/// </summary>
			public const string marketcap = "marketcap";
		}

		public static string[] AllFields = new string[]
		{
			F.hname,
			F.price,
			F.sign,
			F.change,
			F.diff,
			F.volume,
			F.jniltime,
			F.shcode,
			F.yeprice,
			F.open,
			F.high,
			F.low,
			F.value,
			F.marketcap,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["hname"] = new XAQueryFieldInfo("char", hname, hname, "종목명", (decimal)20);
			dict["price"] = new XAQueryFieldInfo("long", price, price.ToString("d8"), "현재가", (decimal)8);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("long", change, change.ToString("d8"), "전일대비", (decimal)8);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "누적거래량", (decimal)12);
			dict["jniltime"] = new XAQueryFieldInfo("float", jniltime, jniltime.ToString("000000000.00"), "전일동시간", (decimal)9.2);
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "종목코드", (decimal)6);
			dict["yeprice"] = new XAQueryFieldInfo("long", yeprice, yeprice.ToString("d8"), "예상체결가", (decimal)8);
			dict["open"] = new XAQueryFieldInfo("long", open, open.ToString("d8"), "시가", (decimal)8);
			dict["high"] = new XAQueryFieldInfo("long", high, high.ToString("d8"), "고가", (decimal)8);
			dict["low"] = new XAQueryFieldInfo("long", low, low.ToString("d8"), "저가", (decimal)8);
			dict["value"] = new XAQueryFieldInfo("long", value, value.ToString("d12"), "누적거래대금(단위:백만)", (decimal)12);
			dict["marketcap"] = new XAQueryFieldInfo("long", marketcap, marketcap.ToString("d12"), "시가총액(단위:백만)", (decimal)12);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
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

				case "jniltime":
					this.jniltime = fieldInfo.FieldValue.ParseFloat("jniltime");
				break;

				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "yeprice":
					this.yeprice = fieldInfo.FieldValue.ParseLong("yeprice");
				break;

				case "open":
					this.open = fieldInfo.FieldValue.ParseLong("open");
				break;

				case "high":
					this.high = fieldInfo.FieldValue.ParseLong("high");
				break;

				case "low":
					this.low = fieldInfo.FieldValue.ParseLong("low");
				break;

				case "value":
					this.value = fieldInfo.FieldValue.ParseLong("value");
				break;

				case "marketcap":
					this.marketcap = fieldInfo.FieldValue.ParseLong("marketcap");
				break;


			}
		}

		public static XQt1537OutBlock1[] ListFromQuery(XQt1537 query)
		{
			int count = query.GetBlockCount(XQt1537OutBlock1.BlockName);
			List<XQt1537OutBlock1> list = new List<XQt1537OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1537OutBlock1 block = new XQt1537OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.hname = query.GetFieldData(block.GetBlockName(), "hname", i).TrimEnd('?'); // char 20
					block.price = query.GetFieldData(block.GetBlockName(), "price", i).ParseLong("price"); // long 8
					block.sign = query.GetFieldData(block.GetBlockName(), "sign", i).FirstOrDefault(); // char 1
					block.change = query.GetFieldData(block.GetBlockName(), "change", i).ParseLong("change"); // long 8
					block.diff = query.GetFieldData(block.GetBlockName(), "diff", i).ParseFloat("diff"); // float 6.2
					block.volume = query.GetFieldData(block.GetBlockName(), "volume", i).ParseLong("volume"); // long 12
					block.jniltime = query.GetFieldData(block.GetBlockName(), "jniltime", i).ParseFloat("jniltime"); // float 9.2
					block.shcode = query.GetFieldData(block.GetBlockName(), "shcode", i).TrimEnd('?'); // char 6
					block.yeprice = query.GetFieldData(block.GetBlockName(), "yeprice", i).ParseLong("yeprice"); // long 8
					block.open = query.GetFieldData(block.GetBlockName(), "open", i).ParseLong("open"); // long 8
					block.high = query.GetFieldData(block.GetBlockName(), "high", i).ParseLong("high"); // long 8
					block.low = query.GetFieldData(block.GetBlockName(), "low", i).ParseLong("low"); // long 8
					block.value = query.GetFieldData(block.GetBlockName(), "value", i).ParseLong("value"); // long 12
					block.marketcap = query.GetFieldData(block.GetBlockName(), "marketcap", i).ParseLong("marketcap"); // long 12

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
			if (price.ToString().Length > 8) return false; // long 8
			// sign char 1
			if (change.ToString().Length > 8) return false; // long 8
			// diff float 6.2
			if (volume.ToString().Length > 12) return false; // long 12
			// jniltime float 9.2
			if (shcode?.Length > 6) return false; // char 6
			if (yeprice.ToString().Length > 8) return false; // long 8
			if (open.ToString().Length > 8) return false; // long 8
			if (high.ToString().Length > 8) return false; // long 8
			if (low.ToString().Length > 8) return false; // long 8
			if (value.ToString().Length > 12) return false; // long 12
			if (marketcap.ToString().Length > 12) return false; // long 12

			return true;
		}
	}

	/// <summary>
	/// 테마종목별시세조회(t1537)
	/// </summary>
	public partial class XQt1537 : XingQuery
	{
		/// <summary>
		/// t1537
		/// </summary>
		public const string _typeName = "t1537";
		/// <summary>
		/// 테마종목별시세조회(t1537)
		/// </summary>
		public const string _typeDesc = "테마종목별시세조회(t1537)";
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
		/// t1537
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 테마종목별시세조회(t1537)
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
		/// 테마종목별시세조회(t1537)
		/// </summary>
		public XQt1537() : base("t1537") { }


		public static XQt1537OutBlock1[] Get(string tmcode = default)
		{
			using (XQt1537 instance = new XQt1537())
			{
				instance.SetFieldData(XQt1537InBlock.BlockName, XQt1537InBlock.F.tmcode, 0, tmcode); // char 4

				if (instance.Request() < 0)
				{
					return null;
				}

				var outBlock = instance.GetBlock1s();
				return outBlock;
			}
		}

		public bool SetBlock(XQt1537InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "tmcode", 0, block.tmcode); // char 4

			return true;
		}

		public XQt1537OutBlock GetBlock()
		{
			XQt1537OutBlock instance = XQt1537OutBlock.FromQuery(this);
			return instance;

		}

		public XQt1537OutBlock1[] GetBlock1s()
		{
			XQt1537OutBlock1[] instance = XQt1537OutBlock1.ListFromQuery(this);
			return instance;

		}


	}

}
