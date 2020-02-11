using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt8407InBlock : XingBlock
	{
		/// <summary>
		/// t8407InBlock
		/// </summary>
		public const string _blockName = "t8407InBlock";
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
		/// t8407InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t8407InBlock
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
		/// 건수
		/// </summary>
		[XAQueryFieldAttribute("nrec", "건수", "long", "3")]
		public long nrec;
		/// <summary>
		/// 종목코드
		/// </summary>
		[XAQueryFieldAttribute("shcode", "종목코드", "char", "300")]
		public string shcode;

		public static class F
		{
			/// <summary>
			/// 건수
			/// </summary>
			public const string nrec = "nrec";
			/// <summary>
			/// 종목코드
			/// </summary>
			public const string shcode = "shcode";
		}

		public static string[] AllFields = new string[]
		{
			F.nrec,
			F.shcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["nrec"] = new XAQueryFieldInfo("long", nrec, nrec.ToString("d3"), "건수", (decimal)3);
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "종목코드", (decimal)300);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "nrec":
					this.nrec = fieldInfo.FieldValue.ParseLong("nrec");
				break;

				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (nrec.ToString().Length > 3) return false; // long 3
			if (shcode?.Length > 300) return false; // char 300

			return true;
		}
	}

	public partial class XQt8407OutBlock1 : XingBlock
	{
		/// <summary>
		/// t8407OutBlock1
		/// </summary>
		public const string _blockName = "t8407OutBlock1";
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
		/// t8407OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t8407OutBlock1
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
		[XAQueryFieldAttribute("hname", "종목명", "char", "40")]
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
		/// 누적거래량
		/// </summary>
		[XAQueryFieldAttribute("volume", "누적거래량", "long", "12")]
		public long volume;
		/// <summary>
		/// 매도호가
		/// </summary>
		[XAQueryFieldAttribute("offerho", "매도호가", "long", "8")]
		public long offerho;
		/// <summary>
		/// 매수호가
		/// </summary>
		[XAQueryFieldAttribute("bidho", "매수호가", "long", "8")]
		public long bidho;
		/// <summary>
		/// 체결수량
		/// </summary>
		[XAQueryFieldAttribute("cvolume", "체결수량", "long", "8")]
		public long cvolume;
		/// <summary>
		/// 체결강도
		/// </summary>
		[XAQueryFieldAttribute("chdegree", "체결강도", "float", "9.2")]
		public float chdegree;
		/// <summary>
		/// 시가
		/// </summary>
		[XAQueryFieldAttribute("open", "시가", "long", "8")]
		public long open;
		/// <summary>
		/// 고가
		/// </summary>
		[XAQueryFieldAttribute("high", "고가", "long", "8")]
		public long high;
		/// <summary>
		/// 저가
		/// </summary>
		[XAQueryFieldAttribute("low", "저가", "long", "8")]
		public long low;
		/// <summary>
		/// 거래대금(백만)
		/// </summary>
		[XAQueryFieldAttribute("value", "거래대금(백만)", "long", "12")]
		public long value;
		/// <summary>
		/// 우선매도잔량
		/// </summary>
		[XAQueryFieldAttribute("offerrem", "우선매도잔량", "long", "12")]
		public long offerrem;
		/// <summary>
		/// 우선매수잔량
		/// </summary>
		[XAQueryFieldAttribute("bidrem", "우선매수잔량", "long", "12")]
		public long bidrem;
		/// <summary>
		/// 총매도잔량
		/// </summary>
		[XAQueryFieldAttribute("totofferrem", "총매도잔량", "long", "12")]
		public long totofferrem;
		/// <summary>
		/// 총매수잔량
		/// </summary>
		[XAQueryFieldAttribute("totbidrem", "총매수잔량", "long", "12")]
		public long totbidrem;
		/// <summary>
		/// 전일종가
		/// </summary>
		[XAQueryFieldAttribute("jnilclose", "전일종가", "long", "8")]
		public long jnilclose;
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
			/// 누적거래량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// 매도호가
			/// </summary>
			public const string offerho = "offerho";
			/// <summary>
			/// 매수호가
			/// </summary>
			public const string bidho = "bidho";
			/// <summary>
			/// 체결수량
			/// </summary>
			public const string cvolume = "cvolume";
			/// <summary>
			/// 체결강도
			/// </summary>
			public const string chdegree = "chdegree";
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
			/// 거래대금(백만)
			/// </summary>
			public const string value = "value";
			/// <summary>
			/// 우선매도잔량
			/// </summary>
			public const string offerrem = "offerrem";
			/// <summary>
			/// 우선매수잔량
			/// </summary>
			public const string bidrem = "bidrem";
			/// <summary>
			/// 총매도잔량
			/// </summary>
			public const string totofferrem = "totofferrem";
			/// <summary>
			/// 총매수잔량
			/// </summary>
			public const string totbidrem = "totbidrem";
			/// <summary>
			/// 전일종가
			/// </summary>
			public const string jnilclose = "jnilclose";
			/// <summary>
			/// 상한가
			/// </summary>
			public const string uplmtprice = "uplmtprice";
			/// <summary>
			/// 하한가
			/// </summary>
			public const string dnlmtprice = "dnlmtprice";
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
			F.offerho,
			F.bidho,
			F.cvolume,
			F.chdegree,
			F.open,
			F.high,
			F.low,
			F.value,
			F.offerrem,
			F.bidrem,
			F.totofferrem,
			F.totbidrem,
			F.jnilclose,
			F.uplmtprice,
			F.dnlmtprice,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "종목코드", (decimal)6);
			dict["hname"] = new XAQueryFieldInfo("char", hname, hname, "종목명", (decimal)40);
			dict["price"] = new XAQueryFieldInfo("long", price, price.ToString("d8"), "현재가", (decimal)8);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("long", change, change.ToString("d8"), "전일대비", (decimal)8);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "누적거래량", (decimal)12);
			dict["offerho"] = new XAQueryFieldInfo("long", offerho, offerho.ToString("d8"), "매도호가", (decimal)8);
			dict["bidho"] = new XAQueryFieldInfo("long", bidho, bidho.ToString("d8"), "매수호가", (decimal)8);
			dict["cvolume"] = new XAQueryFieldInfo("long", cvolume, cvolume.ToString("d8"), "체결수량", (decimal)8);
			dict["chdegree"] = new XAQueryFieldInfo("float", chdegree, chdegree.ToString("000000000.00"), "체결강도", (decimal)9.2);
			dict["open"] = new XAQueryFieldInfo("long", open, open.ToString("d8"), "시가", (decimal)8);
			dict["high"] = new XAQueryFieldInfo("long", high, high.ToString("d8"), "고가", (decimal)8);
			dict["low"] = new XAQueryFieldInfo("long", low, low.ToString("d8"), "저가", (decimal)8);
			dict["value"] = new XAQueryFieldInfo("long", value, value.ToString("d12"), "거래대금(백만)", (decimal)12);
			dict["offerrem"] = new XAQueryFieldInfo("long", offerrem, offerrem.ToString("d12"), "우선매도잔량", (decimal)12);
			dict["bidrem"] = new XAQueryFieldInfo("long", bidrem, bidrem.ToString("d12"), "우선매수잔량", (decimal)12);
			dict["totofferrem"] = new XAQueryFieldInfo("long", totofferrem, totofferrem.ToString("d12"), "총매도잔량", (decimal)12);
			dict["totbidrem"] = new XAQueryFieldInfo("long", totbidrem, totbidrem.ToString("d12"), "총매수잔량", (decimal)12);
			dict["jnilclose"] = new XAQueryFieldInfo("long", jnilclose, jnilclose.ToString("d8"), "전일종가", (decimal)8);
			dict["uplmtprice"] = new XAQueryFieldInfo("long", uplmtprice, uplmtprice.ToString("d8"), "상한가", (decimal)8);
			dict["dnlmtprice"] = new XAQueryFieldInfo("long", dnlmtprice, dnlmtprice.ToString("d8"), "하한가", (decimal)8);

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

				case "offerho":
					this.offerho = fieldInfo.FieldValue.ParseLong("offerho");
				break;

				case "bidho":
					this.bidho = fieldInfo.FieldValue.ParseLong("bidho");
				break;

				case "cvolume":
					this.cvolume = fieldInfo.FieldValue.ParseLong("cvolume");
				break;

				case "chdegree":
					this.chdegree = fieldInfo.FieldValue.ParseFloat("chdegree");
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

				case "offerrem":
					this.offerrem = fieldInfo.FieldValue.ParseLong("offerrem");
				break;

				case "bidrem":
					this.bidrem = fieldInfo.FieldValue.ParseLong("bidrem");
				break;

				case "totofferrem":
					this.totofferrem = fieldInfo.FieldValue.ParseLong("totofferrem");
				break;

				case "totbidrem":
					this.totbidrem = fieldInfo.FieldValue.ParseLong("totbidrem");
				break;

				case "jnilclose":
					this.jnilclose = fieldInfo.FieldValue.ParseLong("jnilclose");
				break;

				case "uplmtprice":
					this.uplmtprice = fieldInfo.FieldValue.ParseLong("uplmtprice");
				break;

				case "dnlmtprice":
					this.dnlmtprice = fieldInfo.FieldValue.ParseLong("dnlmtprice");
				break;


			}
		}

		public static XQt8407OutBlock1[] ListFromQuery(XQt8407 query)
		{
			int count = query.GetBlockCount(XQt8407OutBlock1.BlockName);
			List<XQt8407OutBlock1> list = new List<XQt8407OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt8407OutBlock1 block = new XQt8407OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.shcode = query.GetFieldData(block.GetBlockName(), "shcode", i).TrimEnd('?'); // char 6
					block.hname = query.GetFieldData(block.GetBlockName(), "hname", i).TrimEnd('?'); // char 40
					block.price = query.GetFieldData(block.GetBlockName(), "price", i).ParseLong("price"); // long 8
					block.sign = query.GetFieldData(block.GetBlockName(), "sign", i).FirstOrDefault(); // char 1
					block.change = query.GetFieldData(block.GetBlockName(), "change", i).ParseLong("change"); // long 8
					block.diff = query.GetFieldData(block.GetBlockName(), "diff", i).ParseFloat("diff"); // float 6.2
					block.volume = query.GetFieldData(block.GetBlockName(), "volume", i).ParseLong("volume"); // long 12
					block.offerho = query.GetFieldData(block.GetBlockName(), "offerho", i).ParseLong("offerho"); // long 8
					block.bidho = query.GetFieldData(block.GetBlockName(), "bidho", i).ParseLong("bidho"); // long 8
					block.cvolume = query.GetFieldData(block.GetBlockName(), "cvolume", i).ParseLong("cvolume"); // long 8
					block.chdegree = query.GetFieldData(block.GetBlockName(), "chdegree", i).ParseFloat("chdegree"); // float 9.2
					block.open = query.GetFieldData(block.GetBlockName(), "open", i).ParseLong("open"); // long 8
					block.high = query.GetFieldData(block.GetBlockName(), "high", i).ParseLong("high"); // long 8
					block.low = query.GetFieldData(block.GetBlockName(), "low", i).ParseLong("low"); // long 8
					block.value = query.GetFieldData(block.GetBlockName(), "value", i).ParseLong("value"); // long 12
					block.offerrem = query.GetFieldData(block.GetBlockName(), "offerrem", i).ParseLong("offerrem"); // long 12
					block.bidrem = query.GetFieldData(block.GetBlockName(), "bidrem", i).ParseLong("bidrem"); // long 12
					block.totofferrem = query.GetFieldData(block.GetBlockName(), "totofferrem", i).ParseLong("totofferrem"); // long 12
					block.totbidrem = query.GetFieldData(block.GetBlockName(), "totbidrem", i).ParseLong("totbidrem"); // long 12
					block.jnilclose = query.GetFieldData(block.GetBlockName(), "jnilclose", i).ParseLong("jnilclose"); // long 8
					block.uplmtprice = query.GetFieldData(block.GetBlockName(), "uplmtprice", i).ParseLong("uplmtprice"); // long 8
					block.dnlmtprice = query.GetFieldData(block.GetBlockName(), "dnlmtprice", i).ParseLong("dnlmtprice"); // long 8

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
			if (price.ToString().Length > 8) return false; // long 8
			// sign char 1
			if (change.ToString().Length > 8) return false; // long 8
			// diff float 6.2
			if (volume.ToString().Length > 12) return false; // long 12
			if (offerho.ToString().Length > 8) return false; // long 8
			if (bidho.ToString().Length > 8) return false; // long 8
			if (cvolume.ToString().Length > 8) return false; // long 8
			// chdegree float 9.2
			if (open.ToString().Length > 8) return false; // long 8
			if (high.ToString().Length > 8) return false; // long 8
			if (low.ToString().Length > 8) return false; // long 8
			if (value.ToString().Length > 12) return false; // long 12
			if (offerrem.ToString().Length > 12) return false; // long 12
			if (bidrem.ToString().Length > 12) return false; // long 12
			if (totofferrem.ToString().Length > 12) return false; // long 12
			if (totbidrem.ToString().Length > 12) return false; // long 12
			if (jnilclose.ToString().Length > 8) return false; // long 8
			if (uplmtprice.ToString().Length > 8) return false; // long 8
			if (dnlmtprice.ToString().Length > 8) return false; // long 8

			return true;
		}
	}

	/// <summary>
	/// API용주식멀티현재가조회(t8407)
	/// </summary>
	public partial class XQt8407 : XingQuery
	{
		/// <summary>
		/// t8407
		/// </summary>
		public const string _typeName = "t8407";
		/// <summary>
		/// API용주식멀티현재가조회(t8407)
		/// </summary>
		public const string _typeDesc = "API용주식멀티현재가조회(t8407)";
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
		/// t8407
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// API용주식멀티현재가조회(t8407)
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
		/// API용주식멀티현재가조회(t8407)
		/// </summary>
		public XQt8407() : base("t8407") { }


		public static XQt8407OutBlock1[] Get(long nrec = default,string shcode = default)
		{
			using (XQt8407 instance = new XQt8407())
			{
				instance.SetFieldData(XQt8407InBlock.BlockName, XQt8407InBlock.F.nrec, 0, nrec.ToString("d3")); // long 3
				instance.SetFieldData(XQt8407InBlock.BlockName, XQt8407InBlock.F.shcode, 0, shcode); // char 300

				if (instance.Request() < 0)
				{
					return null;
				}

				var outBlock = instance.GetBlock1s();
				return outBlock;
			}
		}

		public bool SetBlock(XQt8407InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "nrec", 0, block.nrec.ToString("d3")); // long 3
			_xaQuery.SetFieldData(block.GetBlockName(), "shcode", 0, block.shcode); // char 300

			return true;
		}

		public XQt8407OutBlock1[] GetBlock1s()
		{
			XQt8407OutBlock1[] instance = XQt8407OutBlock1.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt8407OutBlock1),

		};

	}

}
