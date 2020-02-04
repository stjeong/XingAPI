using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1904InBlock : XingBlock
	{
		/// <summary>
		/// t1904InBlock
		/// </summary>
		public const string _blockName = "t1904InBlock";
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
		/// t1904InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1904InBlock
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
		/// ETF단축코드
		/// </summary>
		[XAQueryFieldAttribute("ETF단축코드")]
		public string shcode;
		/// <summary>
		/// PDF적용일자
		/// </summary>
		[XAQueryFieldAttribute("PDF적용일자")]
		public string date;
		/// <summary>
		/// 정렬기준(1:평가금액2:증권수)
		/// </summary>
		[XAQueryFieldAttribute("정렬기준(1:평가금액2:증권수)")]
		public char sgb;

		public static class F
		{
			/// <summary>
			/// ETF단축코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// PDF적용일자
			/// </summary>
			public const string date = "date";
			/// <summary>
			/// 정렬기준(1:평가금액2:증권수)
			/// </summary>
			public const string sgb = "sgb";
		}

		public static string[] AllFields = new string[]
		{
			F.shcode,
			F.date,
			F.sgb,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "ETF단축코드", (decimal)6);
			dict["date"] = new XAQueryFieldInfo("char", date, date, "PDF적용일자", (decimal)8);
			dict["sgb"] = new XAQueryFieldInfo("char", sgb, sgb.ToString(), "정렬기준(1:평가금액2:증권수)", (decimal)1);

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

				case "sgb":
					this.sgb = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public bool VerifyData()
		{
			if (shcode?.Length > 6) return false; // char 6
			if (date?.Length > 8) return false; // char 8
			// sgb char 1

			return true;
		}
	}

	public partial class XQt1904OutBlock : XingBlock
	{
		/// <summary>
		/// t1904OutBlock
		/// </summary>
		public const string _blockName = "t1904OutBlock";
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
		/// t1904OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1904OutBlock
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
		/// 당일구분
		/// </summary>
		[XAQueryFieldAttribute("당일구분")]
		public char chk_tday;
		/// <summary>
		/// PDF적용일자
		/// </summary>
		[XAQueryFieldAttribute("PDF적용일자")]
		public string date;
		/// <summary>
		/// ETF현재가
		/// </summary>
		[XAQueryFieldAttribute("ETF현재가")]
		public long price;
		/// <summary>
		/// ETF전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("ETF전일대비구분")]
		public char sign;
		/// <summary>
		/// ETF전일대비
		/// </summary>
		[XAQueryFieldAttribute("ETF전일대비")]
		public long change;
		/// <summary>
		/// ETF등락율
		/// </summary>
		[XAQueryFieldAttribute("ETF등락율")]
		public float diff;
		/// <summary>
		/// ETF누적거래량
		/// </summary>
		[XAQueryFieldAttribute("ETF누적거래량")]
		public long volume;
		/// <summary>
		/// NAV
		/// </summary>
		[XAQueryFieldAttribute("NAV")]
		public float nav;
		/// <summary>
		/// NAV전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("NAV전일대비구분")]
		public char navsign;
		/// <summary>
		/// NAV전일대비
		/// </summary>
		[XAQueryFieldAttribute("NAV전일대비")]
		public float navchange;
		/// <summary>
		/// NAV등락율
		/// </summary>
		[XAQueryFieldAttribute("NAV등락율")]
		public float navdiff;
		/// <summary>
		/// 전일NAV
		/// </summary>
		[XAQueryFieldAttribute("전일NAV")]
		public float jnilnav;
		/// <summary>
		/// 전일NAV전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("전일NAV전일대비구분")]
		public char jnilnavsign;
		/// <summary>
		/// 전일NAV전일대비
		/// </summary>
		[XAQueryFieldAttribute("전일NAV전일대비")]
		public float jnilnavchange;
		/// <summary>
		/// 전일NAV등락율
		/// </summary>
		[XAQueryFieldAttribute("전일NAV등락율")]
		public float jnilnavdiff;
		/// <summary>
		/// 업종명
		/// </summary>
		[XAQueryFieldAttribute("업종명")]
		public string upname;
		/// <summary>
		/// 업종코드
		/// </summary>
		[XAQueryFieldAttribute("업종코드")]
		public string upcode;
		/// <summary>
		/// 업종현재가
		/// </summary>
		[XAQueryFieldAttribute("업종현재가")]
		public float upprice;
		/// <summary>
		/// 업종전일비구분
		/// </summary>
		[XAQueryFieldAttribute("업종전일비구분")]
		public char upsign;
		/// <summary>
		/// 업종전일대비
		/// </summary>
		[XAQueryFieldAttribute("업종전일대비")]
		public float upchange;
		/// <summary>
		/// 업종등락율
		/// </summary>
		[XAQueryFieldAttribute("업종등락율")]
		public float updiff;
		/// <summary>
		/// 선물최근월물명
		/// </summary>
		[XAQueryFieldAttribute("선물최근월물명")]
		public string futname;
		/// <summary>
		/// 선물최근월물코드
		/// </summary>
		[XAQueryFieldAttribute("선물최근월물코드")]
		public string futcode;
		/// <summary>
		/// 선물현재가
		/// </summary>
		[XAQueryFieldAttribute("선물현재가")]
		public float futprice;
		/// <summary>
		/// 선물전일비구분
		/// </summary>
		[XAQueryFieldAttribute("선물전일비구분")]
		public char futsign;
		/// <summary>
		/// 선물전일대비
		/// </summary>
		[XAQueryFieldAttribute("선물전일대비")]
		public float futchange;
		/// <summary>
		/// 선물등락율
		/// </summary>
		[XAQueryFieldAttribute("선물등락율")]
		public float futdiff;
		/// <summary>
		/// 참고지수명
		/// </summary>
		[XAQueryFieldAttribute("참고지수명")]
		public string upname2;
		/// <summary>
		/// 참고지수코드
		/// </summary>
		[XAQueryFieldAttribute("참고지수코드")]
		public string upcode2;
		/// <summary>
		/// 참고지수현재가
		/// </summary>
		[XAQueryFieldAttribute("참고지수현재가")]
		public float upprice2;
		/// <summary>
		/// 순자산총액(단위:억)
		/// </summary>
		[XAQueryFieldAttribute("순자산총액(단위:억)")]
		public long etftotcap;
		/// <summary>
		/// 구성종목수
		/// </summary>
		[XAQueryFieldAttribute("구성종목수")]
		public long etfnum;
		/// <summary>
		/// CU주식수
		/// </summary>
		[XAQueryFieldAttribute("CU주식수")]
		public long etfcunum;
		/// <summary>
		/// 현금
		/// </summary>
		[XAQueryFieldAttribute("현금")]
		public long cash;
		/// <summary>
		/// 운용사명
		/// </summary>
		[XAQueryFieldAttribute("운용사명")]
		public string opcom_nmk;
		/// <summary>
		/// 전종목평가금액합
		/// </summary>
		[XAQueryFieldAttribute("전종목평가금액합")]
		public long tot_pval;
		/// <summary>
		/// 전종목구성시가총액합
		/// </summary>
		[XAQueryFieldAttribute("전종목구성시가총액합")]
		public long tot_sigatval;

		public static class F
		{
			/// <summary>
			/// 당일구분
			/// </summary>
			public const string chk_tday = "chk_tday";
			/// <summary>
			/// PDF적용일자
			/// </summary>
			public const string date = "date";
			/// <summary>
			/// ETF현재가
			/// </summary>
			public const string price = "price";
			/// <summary>
			/// ETF전일대비구분
			/// </summary>
			public const string sign = "sign";
			/// <summary>
			/// ETF전일대비
			/// </summary>
			public const string change = "change";
			/// <summary>
			/// ETF등락율
			/// </summary>
			public const string diff = "diff";
			/// <summary>
			/// ETF누적거래량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// NAV
			/// </summary>
			public const string nav = "nav";
			/// <summary>
			/// NAV전일대비구분
			/// </summary>
			public const string navsign = "navsign";
			/// <summary>
			/// NAV전일대비
			/// </summary>
			public const string navchange = "navchange";
			/// <summary>
			/// NAV등락율
			/// </summary>
			public const string navdiff = "navdiff";
			/// <summary>
			/// 전일NAV
			/// </summary>
			public const string jnilnav = "jnilnav";
			/// <summary>
			/// 전일NAV전일대비구분
			/// </summary>
			public const string jnilnavsign = "jnilnavsign";
			/// <summary>
			/// 전일NAV전일대비
			/// </summary>
			public const string jnilnavchange = "jnilnavchange";
			/// <summary>
			/// 전일NAV등락율
			/// </summary>
			public const string jnilnavdiff = "jnilnavdiff";
			/// <summary>
			/// 업종명
			/// </summary>
			public const string upname = "upname";
			/// <summary>
			/// 업종코드
			/// </summary>
			public const string upcode = "upcode";
			/// <summary>
			/// 업종현재가
			/// </summary>
			public const string upprice = "upprice";
			/// <summary>
			/// 업종전일비구분
			/// </summary>
			public const string upsign = "upsign";
			/// <summary>
			/// 업종전일대비
			/// </summary>
			public const string upchange = "upchange";
			/// <summary>
			/// 업종등락율
			/// </summary>
			public const string updiff = "updiff";
			/// <summary>
			/// 선물최근월물명
			/// </summary>
			public const string futname = "futname";
			/// <summary>
			/// 선물최근월물코드
			/// </summary>
			public const string futcode = "futcode";
			/// <summary>
			/// 선물현재가
			/// </summary>
			public const string futprice = "futprice";
			/// <summary>
			/// 선물전일비구분
			/// </summary>
			public const string futsign = "futsign";
			/// <summary>
			/// 선물전일대비
			/// </summary>
			public const string futchange = "futchange";
			/// <summary>
			/// 선물등락율
			/// </summary>
			public const string futdiff = "futdiff";
			/// <summary>
			/// 참고지수명
			/// </summary>
			public const string upname2 = "upname2";
			/// <summary>
			/// 참고지수코드
			/// </summary>
			public const string upcode2 = "upcode2";
			/// <summary>
			/// 참고지수현재가
			/// </summary>
			public const string upprice2 = "upprice2";
			/// <summary>
			/// 순자산총액(단위:억)
			/// </summary>
			public const string etftotcap = "etftotcap";
			/// <summary>
			/// 구성종목수
			/// </summary>
			public const string etfnum = "etfnum";
			/// <summary>
			/// CU주식수
			/// </summary>
			public const string etfcunum = "etfcunum";
			/// <summary>
			/// 현금
			/// </summary>
			public const string cash = "cash";
			/// <summary>
			/// 운용사명
			/// </summary>
			public const string opcom_nmk = "opcom_nmk";
			/// <summary>
			/// 전종목평가금액합
			/// </summary>
			public const string tot_pval = "tot_pval";
			/// <summary>
			/// 전종목구성시가총액합
			/// </summary>
			public const string tot_sigatval = "tot_sigatval";
		}

		public static string[] AllFields = new string[]
		{
			F.chk_tday,
			F.date,
			F.price,
			F.sign,
			F.change,
			F.diff,
			F.volume,
			F.nav,
			F.navsign,
			F.navchange,
			F.navdiff,
			F.jnilnav,
			F.jnilnavsign,
			F.jnilnavchange,
			F.jnilnavdiff,
			F.upname,
			F.upcode,
			F.upprice,
			F.upsign,
			F.upchange,
			F.updiff,
			F.futname,
			F.futcode,
			F.futprice,
			F.futsign,
			F.futchange,
			F.futdiff,
			F.upname2,
			F.upcode2,
			F.upprice2,
			F.etftotcap,
			F.etfnum,
			F.etfcunum,
			F.cash,
			F.opcom_nmk,
			F.tot_pval,
			F.tot_sigatval,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["chk_tday"] = new XAQueryFieldInfo("char", chk_tday, chk_tday.ToString(), "당일구분", (decimal)1);
			dict["date"] = new XAQueryFieldInfo("char", date, date, "PDF적용일자", (decimal)8);
			dict["price"] = new XAQueryFieldInfo("long", price, price.ToString("d8"), "ETF현재가", (decimal)8);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "ETF전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("long", change, change.ToString("d8"), "ETF전일대비", (decimal)8);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "ETF등락율", (decimal)6.2);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "ETF누적거래량", (decimal)12);
			dict["nav"] = new XAQueryFieldInfo("float", nav, nav.ToString("00000000.00"), "NAV", (decimal)8.2);
			dict["navsign"] = new XAQueryFieldInfo("char", navsign, navsign.ToString(), "NAV전일대비구분", (decimal)1);
			dict["navchange"] = new XAQueryFieldInfo("float", navchange, navchange.ToString("00000000.00"), "NAV전일대비", (decimal)8.2);
			dict["navdiff"] = new XAQueryFieldInfo("float", navdiff, navdiff.ToString("000000.00"), "NAV등락율", (decimal)6.2);
			dict["jnilnav"] = new XAQueryFieldInfo("float", jnilnav, jnilnav.ToString("00000000.00"), "전일NAV", (decimal)8.2);
			dict["jnilnavsign"] = new XAQueryFieldInfo("char", jnilnavsign, jnilnavsign.ToString(), "전일NAV전일대비구분", (decimal)1);
			dict["jnilnavchange"] = new XAQueryFieldInfo("float", jnilnavchange, jnilnavchange.ToString("00000000.00"), "전일NAV전일대비", (decimal)8.2);
			dict["jnilnavdiff"] = new XAQueryFieldInfo("float", jnilnavdiff, jnilnavdiff.ToString("000000.00"), "전일NAV등락율", (decimal)6.2);
			dict["upname"] = new XAQueryFieldInfo("char", upname, upname, "업종명", (decimal)20);
			dict["upcode"] = new XAQueryFieldInfo("char", upcode, upcode, "업종코드", (decimal)3);
			dict["upprice"] = new XAQueryFieldInfo("float", upprice, upprice.ToString("0000000.00"), "업종현재가", (decimal)7.2);
			dict["upsign"] = new XAQueryFieldInfo("char", upsign, upsign.ToString(), "업종전일비구분", (decimal)1);
			dict["upchange"] = new XAQueryFieldInfo("float", upchange, upchange.ToString("000000.00"), "업종전일대비", (decimal)6.2);
			dict["updiff"] = new XAQueryFieldInfo("float", updiff, updiff.ToString("000000.00"), "업종등락율", (decimal)6.2);
			dict["futname"] = new XAQueryFieldInfo("char", futname, futname, "선물최근월물명", (decimal)20);
			dict["futcode"] = new XAQueryFieldInfo("char", futcode, futcode, "선물최근월물코드", (decimal)8);
			dict["futprice"] = new XAQueryFieldInfo("float", futprice, futprice.ToString("000000.00"), "선물현재가", (decimal)6.2);
			dict["futsign"] = new XAQueryFieldInfo("char", futsign, futsign.ToString(), "선물전일비구분", (decimal)1);
			dict["futchange"] = new XAQueryFieldInfo("float", futchange, futchange.ToString("000000.00"), "선물전일대비", (decimal)6.2);
			dict["futdiff"] = new XAQueryFieldInfo("float", futdiff, futdiff.ToString("000000.00"), "선물등락율", (decimal)6.2);
			dict["upname2"] = new XAQueryFieldInfo("char", upname2, upname2, "참고지수명", (decimal)20);
			dict["upcode2"] = new XAQueryFieldInfo("char", upcode2, upcode2, "참고지수코드", (decimal)3);
			dict["upprice2"] = new XAQueryFieldInfo("float", upprice2, upprice2.ToString("0000000.00"), "참고지수현재가", (decimal)7.2);
			dict["etftotcap"] = new XAQueryFieldInfo("long", etftotcap, etftotcap.ToString("d12"), "순자산총액(단위:억)", (decimal)12);
			dict["etfnum"] = new XAQueryFieldInfo("long", etfnum, etfnum.ToString("d4"), "구성종목수", (decimal)4);
			dict["etfcunum"] = new XAQueryFieldInfo("long", etfcunum, etfcunum.ToString("d12"), "CU주식수", (decimal)12);
			dict["cash"] = new XAQueryFieldInfo("long", cash, cash.ToString("d12"), "현금", (decimal)12);
			dict["opcom_nmk"] = new XAQueryFieldInfo("char", opcom_nmk, opcom_nmk, "운용사명", (decimal)20);
			dict["tot_pval"] = new XAQueryFieldInfo("long", tot_pval, tot_pval.ToString("d12"), "전종목평가금액합", (decimal)12);
			dict["tot_sigatval"] = new XAQueryFieldInfo("long", tot_sigatval, tot_sigatval.ToString("d12"), "전종목구성시가총액합", (decimal)12);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "chk_tday":
					this.chk_tday = fieldInfo.FieldValue.FirstOrDefault();
				break;

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

				case "diff":
					this.diff = fieldInfo.FieldValue.ParseFloat("diff");
				break;

				case "volume":
					this.volume = fieldInfo.FieldValue.ParseLong("volume");
				break;

				case "nav":
					this.nav = fieldInfo.FieldValue.ParseFloat("nav");
				break;

				case "navsign":
					this.navsign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "navchange":
					this.navchange = fieldInfo.FieldValue.ParseFloat("navchange");
				break;

				case "navdiff":
					this.navdiff = fieldInfo.FieldValue.ParseFloat("navdiff");
				break;

				case "jnilnav":
					this.jnilnav = fieldInfo.FieldValue.ParseFloat("jnilnav");
				break;

				case "jnilnavsign":
					this.jnilnavsign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "jnilnavchange":
					this.jnilnavchange = fieldInfo.FieldValue.ParseFloat("jnilnavchange");
				break;

				case "jnilnavdiff":
					this.jnilnavdiff = fieldInfo.FieldValue.ParseFloat("jnilnavdiff");
				break;

				case "upname":
					this.upname = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "upcode":
					this.upcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "upprice":
					this.upprice = fieldInfo.FieldValue.ParseFloat("upprice");
				break;

				case "upsign":
					this.upsign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "upchange":
					this.upchange = fieldInfo.FieldValue.ParseFloat("upchange");
				break;

				case "updiff":
					this.updiff = fieldInfo.FieldValue.ParseFloat("updiff");
				break;

				case "futname":
					this.futname = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "futcode":
					this.futcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "futprice":
					this.futprice = fieldInfo.FieldValue.ParseFloat("futprice");
				break;

				case "futsign":
					this.futsign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "futchange":
					this.futchange = fieldInfo.FieldValue.ParseFloat("futchange");
				break;

				case "futdiff":
					this.futdiff = fieldInfo.FieldValue.ParseFloat("futdiff");
				break;

				case "upname2":
					this.upname2 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "upcode2":
					this.upcode2 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "upprice2":
					this.upprice2 = fieldInfo.FieldValue.ParseFloat("upprice2");
				break;

				case "etftotcap":
					this.etftotcap = fieldInfo.FieldValue.ParseLong("etftotcap");
				break;

				case "etfnum":
					this.etfnum = fieldInfo.FieldValue.ParseLong("etfnum");
				break;

				case "etfcunum":
					this.etfcunum = fieldInfo.FieldValue.ParseLong("etfcunum");
				break;

				case "cash":
					this.cash = fieldInfo.FieldValue.ParseLong("cash");
				break;

				case "opcom_nmk":
					this.opcom_nmk = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "tot_pval":
					this.tot_pval = fieldInfo.FieldValue.ParseLong("tot_pval");
				break;

				case "tot_sigatval":
					this.tot_sigatval = fieldInfo.FieldValue.ParseLong("tot_sigatval");
				break;


			}
		}

		public static XQt1904OutBlock FromQuery(XQt1904 query)
		{
			XQt1904OutBlock block = new XQt1904OutBlock();
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
				block.chk_tday = query.GetFieldData(block.GetBlockName(), "chk_tday", 0).FirstOrDefault(); // char 1
				block.date = query.GetFieldData(block.GetBlockName(), "date", 0).TrimEnd('?'); // char 8
				block.price = query.GetFieldData(block.GetBlockName(), "price", 0).ParseLong("price"); // long 8
				block.sign = query.GetFieldData(block.GetBlockName(), "sign", 0).FirstOrDefault(); // char 1
				block.change = query.GetFieldData(block.GetBlockName(), "change", 0).ParseLong("change"); // long 8
				block.diff = query.GetFieldData(block.GetBlockName(), "diff", 0).ParseFloat("diff"); // float 6.2
				block.volume = query.GetFieldData(block.GetBlockName(), "volume", 0).ParseLong("volume"); // long 12
				block.nav = query.GetFieldData(block.GetBlockName(), "nav", 0).ParseFloat("nav"); // float 8.2
				block.navsign = query.GetFieldData(block.GetBlockName(), "navsign", 0).FirstOrDefault(); // char 1
				block.navchange = query.GetFieldData(block.GetBlockName(), "navchange", 0).ParseFloat("navchange"); // float 8.2
				block.navdiff = query.GetFieldData(block.GetBlockName(), "navdiff", 0).ParseFloat("navdiff"); // float 6.2
				block.jnilnav = query.GetFieldData(block.GetBlockName(), "jnilnav", 0).ParseFloat("jnilnav"); // float 8.2
				block.jnilnavsign = query.GetFieldData(block.GetBlockName(), "jnilnavsign", 0).FirstOrDefault(); // char 1
				block.jnilnavchange = query.GetFieldData(block.GetBlockName(), "jnilnavchange", 0).ParseFloat("jnilnavchange"); // float 8.2
				block.jnilnavdiff = query.GetFieldData(block.GetBlockName(), "jnilnavdiff", 0).ParseFloat("jnilnavdiff"); // float 6.2
				block.upname = query.GetFieldData(block.GetBlockName(), "upname", 0).TrimEnd('?'); // char 20
				block.upcode = query.GetFieldData(block.GetBlockName(), "upcode", 0).TrimEnd('?'); // char 3
				block.upprice = query.GetFieldData(block.GetBlockName(), "upprice", 0).ParseFloat("upprice"); // float 7.2
				block.upsign = query.GetFieldData(block.GetBlockName(), "upsign", 0).FirstOrDefault(); // char 1
				block.upchange = query.GetFieldData(block.GetBlockName(), "upchange", 0).ParseFloat("upchange"); // float 6.2
				block.updiff = query.GetFieldData(block.GetBlockName(), "updiff", 0).ParseFloat("updiff"); // float 6.2
				block.futname = query.GetFieldData(block.GetBlockName(), "futname", 0).TrimEnd('?'); // char 20
				block.futcode = query.GetFieldData(block.GetBlockName(), "futcode", 0).TrimEnd('?'); // char 8
				block.futprice = query.GetFieldData(block.GetBlockName(), "futprice", 0).ParseFloat("futprice"); // float 6.2
				block.futsign = query.GetFieldData(block.GetBlockName(), "futsign", 0).FirstOrDefault(); // char 1
				block.futchange = query.GetFieldData(block.GetBlockName(), "futchange", 0).ParseFloat("futchange"); // float 6.2
				block.futdiff = query.GetFieldData(block.GetBlockName(), "futdiff", 0).ParseFloat("futdiff"); // float 6.2
				block.upname2 = query.GetFieldData(block.GetBlockName(), "upname2", 0).TrimEnd('?'); // char 20
				block.upcode2 = query.GetFieldData(block.GetBlockName(), "upcode2", 0).TrimEnd('?'); // char 3
				block.upprice2 = query.GetFieldData(block.GetBlockName(), "upprice2", 0).ParseFloat("upprice2"); // float 7.2
				block.etftotcap = query.GetFieldData(block.GetBlockName(), "etftotcap", 0).ParseLong("etftotcap"); // long 12
				block.etfnum = query.GetFieldData(block.GetBlockName(), "etfnum", 0).ParseLong("etfnum"); // long 4
				block.etfcunum = query.GetFieldData(block.GetBlockName(), "etfcunum", 0).ParseLong("etfcunum"); // long 12
				block.cash = query.GetFieldData(block.GetBlockName(), "cash", 0).ParseLong("cash"); // long 12
				block.opcom_nmk = query.GetFieldData(block.GetBlockName(), "opcom_nmk", 0).TrimEnd('?'); // char 20
				block.tot_pval = query.GetFieldData(block.GetBlockName(), "tot_pval", 0).ParseLong("tot_pval"); // long 12
				block.tot_sigatval = query.GetFieldData(block.GetBlockName(), "tot_sigatval", 0).ParseLong("tot_sigatval"); // long 12

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			// chk_tday char 1
			if (date?.Length > 8) return false; // char 8
			if (price.ToString().Length > 8) return false; // long 8
			// sign char 1
			if (change.ToString().Length > 8) return false; // long 8
			// diff float 6.2
			if (volume.ToString().Length > 12) return false; // long 12
			// nav float 8.2
			// navsign char 1
			// navchange float 8.2
			// navdiff float 6.2
			// jnilnav float 8.2
			// jnilnavsign char 1
			// jnilnavchange float 8.2
			// jnilnavdiff float 6.2
			if (upname?.Length > 20) return false; // char 20
			if (upcode?.Length > 3) return false; // char 3
			// upprice float 7.2
			// upsign char 1
			// upchange float 6.2
			// updiff float 6.2
			if (futname?.Length > 20) return false; // char 20
			if (futcode?.Length > 8) return false; // char 8
			// futprice float 6.2
			// futsign char 1
			// futchange float 6.2
			// futdiff float 6.2
			if (upname2?.Length > 20) return false; // char 20
			if (upcode2?.Length > 3) return false; // char 3
			// upprice2 float 7.2
			if (etftotcap.ToString().Length > 12) return false; // long 12
			if (etfnum.ToString().Length > 4) return false; // long 4
			if (etfcunum.ToString().Length > 12) return false; // long 12
			if (cash.ToString().Length > 12) return false; // long 12
			if (opcom_nmk?.Length > 20) return false; // char 20
			if (tot_pval.ToString().Length > 12) return false; // long 12
			if (tot_sigatval.ToString().Length > 12) return false; // long 12

			return true;
		}
	}

	public partial class XQt1904OutBlock1 : XingBlock
	{
		/// <summary>
		/// t1904OutBlock1
		/// </summary>
		public const string _blockName = "t1904OutBlock1";
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
		/// t1904OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1904OutBlock1
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
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("단축코드")]
		public string shcode;
		/// <summary>
		/// 한글명
		/// </summary>
		[XAQueryFieldAttribute("한글명")]
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
		/// 거래대금(백만)
		/// </summary>
		[XAQueryFieldAttribute("거래대금(백만)")]
		public long value;
		/// <summary>
		/// 단위증권수(계약수/원화현금/USD현금/창고증권)
		/// </summary>
		[XAQueryFieldAttribute("단위증권수(계약수/원화현금/USD현금/창고증권)")]
		public long icux;
		/// <summary>
		/// 액면금액/설정현금액
		/// </summary>
		[XAQueryFieldAttribute("액면금액/설정현금액")]
		public long parprice;
		/// <summary>
		/// 평가금액
		/// </summary>
		[XAQueryFieldAttribute("평가금액")]
		public long pvalue;
		/// <summary>
		/// 구성시가총액
		/// </summary>
		[XAQueryFieldAttribute("구성시가총액")]
		public long sigatvalue;
		/// <summary>
		/// PDF적용일자
		/// </summary>
		[XAQueryFieldAttribute("PDF적용일자")]
		public string profitdate;
		/// <summary>
		/// 비중(평가금액)
		/// </summary>
		[XAQueryFieldAttribute("비중(평가금액)")]
		public float weight;
		/// <summary>
		/// ETF종목과등락차
		/// </summary>
		[XAQueryFieldAttribute("ETF종목과등락차")]
		public float diff2;

		public static class F
		{
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 한글명
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
			/// 거래대금(백만)
			/// </summary>
			public const string value = "value";
			/// <summary>
			/// 단위증권수(계약수/원화현금/USD현금/창고증권)
			/// </summary>
			public const string icux = "icux";
			/// <summary>
			/// 액면금액/설정현금액
			/// </summary>
			public const string parprice = "parprice";
			/// <summary>
			/// 평가금액
			/// </summary>
			public const string pvalue = "pvalue";
			/// <summary>
			/// 구성시가총액
			/// </summary>
			public const string sigatvalue = "sigatvalue";
			/// <summary>
			/// PDF적용일자
			/// </summary>
			public const string profitdate = "profitdate";
			/// <summary>
			/// 비중(평가금액)
			/// </summary>
			public const string weight = "weight";
			/// <summary>
			/// ETF종목과등락차
			/// </summary>
			public const string diff2 = "diff2";
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
			F.value,
			F.icux,
			F.parprice,
			F.pvalue,
			F.sigatvalue,
			F.profitdate,
			F.weight,
			F.diff2,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)12);
			dict["hname"] = new XAQueryFieldInfo("char", hname, hname, "한글명", (decimal)20);
			dict["price"] = new XAQueryFieldInfo("long", price, price.ToString("d8"), "현재가", (decimal)8);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("long", change, change.ToString("d8"), "전일대비", (decimal)8);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "누적거래량", (decimal)12);
			dict["value"] = new XAQueryFieldInfo("long", value, value.ToString("d12"), "거래대금(백만)", (decimal)12);
			dict["icux"] = new XAQueryFieldInfo("long", icux, icux.ToString("d12"), "단위증권수(계약수/원화현금/USD현금/창고증권)", (decimal)12);
			dict["parprice"] = new XAQueryFieldInfo("long", parprice, parprice.ToString("d12"), "액면금액/설정현금액", (decimal)12);
			dict["pvalue"] = new XAQueryFieldInfo("long", pvalue, pvalue.ToString("d12"), "평가금액", (decimal)12);
			dict["sigatvalue"] = new XAQueryFieldInfo("long", sigatvalue, sigatvalue.ToString("d12"), "구성시가총액", (decimal)12);
			dict["profitdate"] = new XAQueryFieldInfo("char", profitdate, profitdate, "PDF적용일자", (decimal)8);
			dict["weight"] = new XAQueryFieldInfo("float", weight, weight.ToString("000000.00"), "비중(평가금액)", (decimal)6.2);
			dict["diff2"] = new XAQueryFieldInfo("float", diff2, diff2.ToString("000000.00"), "ETF종목과등락차", (decimal)6.2);

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

				case "value":
					this.value = fieldInfo.FieldValue.ParseLong("value");
				break;

				case "icux":
					this.icux = fieldInfo.FieldValue.ParseLong("icux");
				break;

				case "parprice":
					this.parprice = fieldInfo.FieldValue.ParseLong("parprice");
				break;

				case "pvalue":
					this.pvalue = fieldInfo.FieldValue.ParseLong("pvalue");
				break;

				case "sigatvalue":
					this.sigatvalue = fieldInfo.FieldValue.ParseLong("sigatvalue");
				break;

				case "profitdate":
					this.profitdate = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "weight":
					this.weight = fieldInfo.FieldValue.ParseFloat("weight");
				break;

				case "diff2":
					this.diff2 = fieldInfo.FieldValue.ParseFloat("diff2");
				break;


			}
		}

		public static XQt1904OutBlock1[] ListFromQuery(XQt1904 query)
		{
			int count = query.GetBlockCount(XQt1904OutBlock1.BlockName);
			List<XQt1904OutBlock1> list = new List<XQt1904OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1904OutBlock1 block = new XQt1904OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.shcode = query.GetFieldData(block.GetBlockName(), "shcode", i).TrimEnd('?'); // char 12
					block.hname = query.GetFieldData(block.GetBlockName(), "hname", i).TrimEnd('?'); // char 20
					block.price = query.GetFieldData(block.GetBlockName(), "price", i).ParseLong("price"); // long 8
					block.sign = query.GetFieldData(block.GetBlockName(), "sign", i).FirstOrDefault(); // char 1
					block.change = query.GetFieldData(block.GetBlockName(), "change", i).ParseLong("change"); // long 8
					block.diff = query.GetFieldData(block.GetBlockName(), "diff", i).ParseFloat("diff"); // float 6.2
					block.volume = query.GetFieldData(block.GetBlockName(), "volume", i).ParseLong("volume"); // long 12
					block.value = query.GetFieldData(block.GetBlockName(), "value", i).ParseLong("value"); // long 12
					block.icux = query.GetFieldData(block.GetBlockName(), "icux", i).ParseLong("icux"); // long 12
					block.parprice = query.GetFieldData(block.GetBlockName(), "parprice", i).ParseLong("parprice"); // long 12
					block.pvalue = query.GetFieldData(block.GetBlockName(), "pvalue", i).ParseLong("pvalue"); // long 12
					block.sigatvalue = query.GetFieldData(block.GetBlockName(), "sigatvalue", i).ParseLong("sigatvalue"); // long 12
					block.profitdate = query.GetFieldData(block.GetBlockName(), "profitdate", i).TrimEnd('?'); // char 8
					block.weight = query.GetFieldData(block.GetBlockName(), "weight", i).ParseFloat("weight"); // float 6.2
					block.diff2 = query.GetFieldData(block.GetBlockName(), "diff2", i).ParseFloat("diff2"); // float 6.2

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
			if (shcode?.Length > 12) return false; // char 12
			if (hname?.Length > 20) return false; // char 20
			if (price.ToString().Length > 8) return false; // long 8
			// sign char 1
			if (change.ToString().Length > 8) return false; // long 8
			// diff float 6.2
			if (volume.ToString().Length > 12) return false; // long 12
			if (value.ToString().Length > 12) return false; // long 12
			if (icux.ToString().Length > 12) return false; // long 12
			if (parprice.ToString().Length > 12) return false; // long 12
			if (pvalue.ToString().Length > 12) return false; // long 12
			if (sigatvalue.ToString().Length > 12) return false; // long 12
			if (profitdate?.Length > 8) return false; // char 8
			// weight float 6.2
			// diff2 float 6.2

			return true;
		}
	}

	public partial class XQt1904 : XingQuery
	{
		/// <summary>
		/// t1904
		/// </summary>
		public const string _typeName = "t1904";
		/// <summary>
		/// ETF구성종목조회(t1904)
		/// </summary>
		public const string _typeDesc = "ETF구성종목조회(t1904)";
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
		/// t1904
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// ETF구성종목조회(t1904)
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

		public XQt1904() : base("t1904") { }


		public static XQt1904OutBlock1[] Get(string shcode = default,string date = default,char sgb = default)
		{
			using (XQt1904 instance = new XQt1904())
			{
				instance.SetFieldData(XQt1904InBlock.BlockName, XQt1904InBlock.F.shcode, 0, shcode); // char 6
				instance.SetFieldData(XQt1904InBlock.BlockName, XQt1904InBlock.F.date, 0, date); // char 8
				instance.SetFieldData(XQt1904InBlock.BlockName, XQt1904InBlock.F.sgb, 0, sgb.ToString()); // char 1

				if (instance.Request() < 0)
				{
					return null;
				}

				var outBlock = instance.GetBlock1s();
				return outBlock;
			}
		}

		public bool SetBlock(XQt1904InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "shcode", 0, block.shcode); // char 6
			_xaQuery.SetFieldData(block.GetBlockName(), "date", 0, block.date); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "sgb", 0, block.sgb.ToString()); // char 1

			return true;
		}

		public XQt1904OutBlock GetBlock()
		{
			XQt1904OutBlock instance = XQt1904OutBlock.FromQuery(this);
			return instance;

		}

		public XQt1904OutBlock1[] GetBlock1s()
		{
			XQt1904OutBlock1[] instance = XQt1904OutBlock1.ListFromQuery(this);
			return instance;

		}


	}

}
