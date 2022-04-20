using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1516InBlock : XingBlock
	{
		/// <summary>
		/// t1516InBlock
		/// </summary>
		public const string _blockName = "t1516InBlock";
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
		/// t1516InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1516InBlock
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
		/// 업종코드
		/// </summary>
		[XAQueryFieldAttribute("upcode", "업종코드", "char", "3")]
		public string upcode;
		/// <summary>
		/// 구분
		/// </summary>
		[XAQueryFieldAttribute("gubun", "구분", "char", "1")]
		public char gubun;
		/// <summary>
		/// 종목코드
		/// </summary>
		[XAQueryFieldAttribute("shcode", "종목코드", "char", "6")]
		public string shcode;

		public static class F
		{
			/// <summary>
			/// 업종코드
			/// </summary>
			public const string upcode = "upcode";
			/// <summary>
			/// 구분
			/// </summary>
			public const string gubun = "gubun";
			/// <summary>
			/// 종목코드
			/// </summary>
			public const string shcode = "shcode";
		}

		public static string[] AllFields = new string[]
		{
			F.upcode,
			F.gubun,
			F.shcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["upcode"] = new XAQueryFieldInfo("char", upcode, upcode, "업종코드", (decimal)3);
			dict["gubun"] = new XAQueryFieldInfo("char", gubun, gubun.ToString(), "구분", (decimal)1);
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "종목코드", (decimal)6);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "upcode":
					this.upcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "gubun":
					this.gubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (upcode?.Length > 3) return false; // char 3
			// gubun char 1
			if (shcode?.Length > 6) return false; // char 6

			return true;
		}

		public void CopyTo(XQt1516InBlock block)
		{
			block.upcode = this.upcode;
			block.gubun = this.gubun;
			block.shcode = this.shcode;

		}
	}

	public partial class XQt1516OutBlock : XingBlock
	{
		/// <summary>
		/// t1516OutBlock
		/// </summary>
		public const string _blockName = "t1516OutBlock";
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
		/// t1516OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1516OutBlock
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
		/// 종목코드
		/// </summary>
		[XAQueryFieldAttribute("shcode", "종목코드", "char", "6")]
		public string shcode;
		/// <summary>
		/// 지수
		/// </summary>
		[XAQueryFieldAttribute("pricejisu", "지수", "float", "12.2")]
		public float pricejisu;
		/// <summary>
		/// 전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("sign", "전일대비구분", "char", "1")]
		public char sign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[XAQueryFieldAttribute("change", "전일대비", "float", "7.2")]
		public float change;
		/// <summary>
		/// 등락율
		/// </summary>
		[XAQueryFieldAttribute("jdiff", "등락율", "float", "6.2")]
		public float jdiff;

		public static class F
		{
			/// <summary>
			/// 종목코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 지수
			/// </summary>
			public const string pricejisu = "pricejisu";
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
			public const string jdiff = "jdiff";
		}

		public static string[] AllFields = new string[]
		{
			F.shcode,
			F.pricejisu,
			F.sign,
			F.change,
			F.jdiff,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "종목코드", (decimal)6);
			dict["pricejisu"] = new XAQueryFieldInfo("float", pricejisu, pricejisu.ToString("000000000000.00"), "지수", (decimal)12.2);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("float", change, change.ToString("0000000.00"), "전일대비", (decimal)7.2);
			dict["jdiff"] = new XAQueryFieldInfo("float", jdiff, jdiff.ToString("000000.00"), "등락율", (decimal)6.2);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "pricejisu":
					this.pricejisu = fieldInfo.FieldValue.ParseFloat("pricejisu");
				break;

				case "sign":
					this.sign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "change":
					this.change = fieldInfo.FieldValue.ParseFloat("change");
				break;

				case "jdiff":
					this.jdiff = fieldInfo.FieldValue.ParseFloat("jdiff");
				break;


			}
		}

		public static XQt1516OutBlock FromQuery(XQt1516 query)
		{
			XQt1516OutBlock block = new XQt1516OutBlock();
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
				block.shcode = query.GetFieldData(block.GetBlockName(), "shcode", 0).TrimEnd('?'); // char 6
				block.pricejisu = query.GetFieldData(block.GetBlockName(), "pricejisu", 0).ParseFloat("pricejisu"); // float 12.2
				block.sign = query.GetFieldData(block.GetBlockName(), "sign", 0).FirstOrDefault(); // char 1
				block.change = query.GetFieldData(block.GetBlockName(), "change", 0).ParseFloat("change"); // float 7.2
				block.jdiff = query.GetFieldData(block.GetBlockName(), "jdiff", 0).ParseFloat("jdiff"); // float 6.2

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (shcode?.Length > 6) return false; // char 6
			// pricejisu float 12.2
			// sign char 1
			// change float 7.2
			// jdiff float 6.2

			return true;
		}

		public void CopyTo(XQt1516OutBlock block)
		{
			block.shcode = this.shcode;
			block.pricejisu = this.pricejisu;
			block.sign = this.sign;
			block.change = this.change;
			block.jdiff = this.jdiff;

		}
	}

	public partial class XQt1516OutBlock1 : XingBlock
	{
		/// <summary>
		/// t1516OutBlock1
		/// </summary>
		public const string _blockName = "t1516OutBlock1";
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
		/// t1516OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1516OutBlock1
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
		/// 소진율
		/// </summary>
		[XAQueryFieldAttribute("sojinrate", "소진율", "float", "6.2")]
		public float sojinrate;
		/// <summary>
		/// 베타계수
		/// </summary>
		[XAQueryFieldAttribute("beta", "베타계수", "float", "6.5")]
		public float beta;
		/// <summary>
		/// PER
		/// </summary>
		[XAQueryFieldAttribute("perx", "PER", "float", "8.2")]
		public float perx;
		/// <summary>
		/// 외인순매수
		/// </summary>
		[XAQueryFieldAttribute("frgsvolume", "외인순매수", "long", "12")]
		public long frgsvolume;
		/// <summary>
		/// 기관순매수
		/// </summary>
		[XAQueryFieldAttribute("orgsvolume", "기관순매수", "long", "12")]
		public long orgsvolume;
		/// <summary>
		/// 거래증가율
		/// </summary>
		[XAQueryFieldAttribute("diff_vol", "거래증가율", "float", "10.2")]
		public float diff_vol;
		/// <summary>
		/// 종목코드
		/// </summary>
		[XAQueryFieldAttribute("shcode", "종목코드", "char", "6")]
		public string shcode;
		/// <summary>
		/// 시가총액
		/// </summary>
		[XAQueryFieldAttribute("total", "시가총액", "long", "12")]
		public long total;
		/// <summary>
		/// 거래대금
		/// </summary>
		[XAQueryFieldAttribute("value", "거래대금", "long", "12")]
		public long value;

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
			/// 소진율
			/// </summary>
			public const string sojinrate = "sojinrate";
			/// <summary>
			/// 베타계수
			/// </summary>
			public const string beta = "beta";
			/// <summary>
			/// PER
			/// </summary>
			public const string perx = "perx";
			/// <summary>
			/// 외인순매수
			/// </summary>
			public const string frgsvolume = "frgsvolume";
			/// <summary>
			/// 기관순매수
			/// </summary>
			public const string orgsvolume = "orgsvolume";
			/// <summary>
			/// 거래증가율
			/// </summary>
			public const string diff_vol = "diff_vol";
			/// <summary>
			/// 종목코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 시가총액
			/// </summary>
			public const string total = "total";
			/// <summary>
			/// 거래대금
			/// </summary>
			public const string value = "value";
		}

		public static string[] AllFields = new string[]
		{
			F.hname,
			F.price,
			F.sign,
			F.change,
			F.diff,
			F.volume,
			F.open,
			F.high,
			F.low,
			F.sojinrate,
			F.beta,
			F.perx,
			F.frgsvolume,
			F.orgsvolume,
			F.diff_vol,
			F.shcode,
			F.total,
			F.value,
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
			dict["open"] = new XAQueryFieldInfo("long", open, open.ToString("d8"), "시가", (decimal)8);
			dict["high"] = new XAQueryFieldInfo("long", high, high.ToString("d8"), "고가", (decimal)8);
			dict["low"] = new XAQueryFieldInfo("long", low, low.ToString("d8"), "저가", (decimal)8);
			dict["sojinrate"] = new XAQueryFieldInfo("float", sojinrate, sojinrate.ToString("000000.00"), "소진율", (decimal)6.2);
			dict["beta"] = new XAQueryFieldInfo("float", beta, beta.ToString("000000.00000"), "베타계수", (decimal)6.5);
			dict["perx"] = new XAQueryFieldInfo("float", perx, perx.ToString("00000000.00"), "PER", (decimal)8.2);
			dict["frgsvolume"] = new XAQueryFieldInfo("long", frgsvolume, frgsvolume.ToString("d12"), "외인순매수", (decimal)12);
			dict["orgsvolume"] = new XAQueryFieldInfo("long", orgsvolume, orgsvolume.ToString("d12"), "기관순매수", (decimal)12);
			dict["diff_vol"] = new XAQueryFieldInfo("float", diff_vol, diff_vol.ToString("0000000000.00"), "거래증가율", (decimal)10.2);
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "종목코드", (decimal)6);
			dict["total"] = new XAQueryFieldInfo("long", total, total.ToString("d12"), "시가총액", (decimal)12);
			dict["value"] = new XAQueryFieldInfo("long", value, value.ToString("d12"), "거래대금", (decimal)12);

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

				case "open":
					this.open = fieldInfo.FieldValue.ParseLong("open");
				break;

				case "high":
					this.high = fieldInfo.FieldValue.ParseLong("high");
				break;

				case "low":
					this.low = fieldInfo.FieldValue.ParseLong("low");
				break;

				case "sojinrate":
					this.sojinrate = fieldInfo.FieldValue.ParseFloat("sojinrate");
				break;

				case "beta":
					this.beta = fieldInfo.FieldValue.ParseFloat("beta");
				break;

				case "perx":
					this.perx = fieldInfo.FieldValue.ParseFloat("perx");
				break;

				case "frgsvolume":
					this.frgsvolume = fieldInfo.FieldValue.ParseLong("frgsvolume");
				break;

				case "orgsvolume":
					this.orgsvolume = fieldInfo.FieldValue.ParseLong("orgsvolume");
				break;

				case "diff_vol":
					this.diff_vol = fieldInfo.FieldValue.ParseFloat("diff_vol");
				break;

				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "total":
					this.total = fieldInfo.FieldValue.ParseLong("total");
				break;

				case "value":
					this.value = fieldInfo.FieldValue.ParseLong("value");
				break;


			}
		}

		public static XQt1516OutBlock1[] ListFromQuery(XQt1516 query)
		{
			int count = query.GetBlockCount(XQt1516OutBlock1.BlockName);
			List<XQt1516OutBlock1> list = new List<XQt1516OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1516OutBlock1 block = new XQt1516OutBlock1();
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
					block.open = query.GetFieldData(block.GetBlockName(), "open", i).ParseLong("open"); // long 8
					block.high = query.GetFieldData(block.GetBlockName(), "high", i).ParseLong("high"); // long 8
					block.low = query.GetFieldData(block.GetBlockName(), "low", i).ParseLong("low"); // long 8
					block.sojinrate = query.GetFieldData(block.GetBlockName(), "sojinrate", i).ParseFloat("sojinrate"); // float 6.2
					block.beta = query.GetFieldData(block.GetBlockName(), "beta", i).ParseFloat("beta"); // float 6.5
					block.perx = query.GetFieldData(block.GetBlockName(), "perx", i).ParseFloat("perx"); // float 8.2
					block.frgsvolume = query.GetFieldData(block.GetBlockName(), "frgsvolume", i).ParseLong("frgsvolume"); // long 12
					block.orgsvolume = query.GetFieldData(block.GetBlockName(), "orgsvolume", i).ParseLong("orgsvolume"); // long 12
					block.diff_vol = query.GetFieldData(block.GetBlockName(), "diff_vol", i).ParseFloat("diff_vol"); // float 10.2
					block.shcode = query.GetFieldData(block.GetBlockName(), "shcode", i).TrimEnd('?'); // char 6
					block.total = query.GetFieldData(block.GetBlockName(), "total", i).ParseLong("total"); // long 12
					block.value = query.GetFieldData(block.GetBlockName(), "value", i).ParseLong("value"); // long 12

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
			if (open.ToString().Length > 8) return false; // long 8
			if (high.ToString().Length > 8) return false; // long 8
			if (low.ToString().Length > 8) return false; // long 8
			// sojinrate float 6.2
			// beta float 6.5
			// perx float 8.2
			if (frgsvolume.ToString().Length > 12) return false; // long 12
			if (orgsvolume.ToString().Length > 12) return false; // long 12
			// diff_vol float 10.2
			if (shcode?.Length > 6) return false; // char 6
			if (total.ToString().Length > 12) return false; // long 12
			if (value.ToString().Length > 12) return false; // long 12

			return true;
		}

		public void CopyTo(XQt1516OutBlock1 block)
		{
			block.hname = this.hname;
			block.price = this.price;
			block.sign = this.sign;
			block.change = this.change;
			block.diff = this.diff;
			block.volume = this.volume;
			block.open = this.open;
			block.high = this.high;
			block.low = this.low;
			block.sojinrate = this.sojinrate;
			block.beta = this.beta;
			block.perx = this.perx;
			block.frgsvolume = this.frgsvolume;
			block.orgsvolume = this.orgsvolume;
			block.diff_vol = this.diff_vol;
			block.shcode = this.shcode;
			block.total = this.total;
			block.value = this.value;

		}
	}

	/// <summary>
	/// 업종별종목시세(t1516)
	/// </summary>
	public partial class XQt1516 : XingQuery
	{
		/// <summary>
		/// t1516
		/// </summary>
		public const string _typeName = "t1516";
		/// <summary>
		/// 업종별종목시세(t1516)
		/// </summary>
		public const string _typeDesc = "업종별종목시세(t1516)";
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
		/// t1516
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 업종별종목시세(t1516)
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
		/// 업종별종목시세(t1516)
		/// </summary>
		public XQt1516() : base("t1516") { }


		public class XQAllOutBlocks
		{
			public XQt1516OutBlock OutBlock { get; internal set; }
			public XQt1516OutBlock1[] OutBlock1 { get; internal set; }
		}

		public static XQAllOutBlocks Get(string upcode = default,char gubun = default,string shcode = default)
		{
			using (XQt1516 instance = new XQt1516())
			{
				instance.SetFieldData(XQt1516InBlock.BlockName, XQt1516InBlock.F.upcode, 0, upcode); // char 3
				instance.SetFieldData(XQt1516InBlock.BlockName, XQt1516InBlock.F.gubun, 0, gubun.ToString()); // char 1
				instance.SetFieldData(XQt1516InBlock.BlockName, XQt1516InBlock.F.shcode, 0, shcode); // char 6

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

		public static XQAllOutBlocks ReadFromDB(string tableNamePostfix = null /*, string upcode = default,char gubun = default,string shcode = default */)
		{
			using (XQt1516 instance = new XQt1516())
			{

				XQAllOutBlocks results = new XQAllOutBlocks();

				string tableName = (tableNamePostfix == null) ? "XQt1516OutBlock" : $"XQt1516OutBlock_{tableNamePostfix}";
				QueryOption qo = new QueryOption(tableName);
				results.OutBlock = instance.Select<XQt1516OutBlock>(qo);

				tableName = (tableNamePostfix == null) ? "XQt1516OutBlock1" : $"XQt1516OutBlock1_{tableNamePostfix}";
				qo = new QueryOption(tableName);
				results.OutBlock1 = instance.SelectMany<XQt1516OutBlock1>(qo);
				return results;
			}
		}

		public bool SetBlock(XQt1516InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "upcode", 0, block.upcode); // char 3
			_xaQuery.SetFieldData(block.GetBlockName(), "gubun", 0, block.gubun.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "shcode", 0, block.shcode); // char 6

			return true;
		}

		public XQt1516OutBlock GetBlock()
		{
			XQt1516OutBlock instance = XQt1516OutBlock.FromQuery(this);
			return instance;

		}

		public XQt1516OutBlock1[] GetBlock1s()
		{
			XQt1516OutBlock1[] instance = XQt1516OutBlock1.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt1516OutBlock),
			typeof(XQt1516OutBlock1),

		};

	}

}
