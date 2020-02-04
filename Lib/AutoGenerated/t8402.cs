using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt8402InBlock : XingBlock
	{
		/// <summary>
		/// t8402InBlock
		/// </summary>
		public const string _blockName = "t8402InBlock";
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
		/// t8402InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t8402InBlock
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
		[XAQueryFieldAttribute("단축코드")]
		public string focode;

		public static class F
		{
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string focode = "focode";
		}

		public static string[] AllFields = new string[]
		{
			F.focode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["focode"] = new XAQueryFieldInfo("char", focode, focode, "단축코드", (decimal)8);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "focode":
					this.focode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (focode?.Length > 8) return false; // char 8

			return true;
		}
	}

	public partial class XQt8402OutBlock : XingBlock
	{
		/// <summary>
		/// t8402OutBlock
		/// </summary>
		public const string _blockName = "t8402OutBlock";
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
		/// t8402OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t8402OutBlock
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
		/// 전일종가
		/// </summary>
		[XAQueryFieldAttribute("전일종가")]
		public long jnilclose;
		/// <summary>
		/// 등락율
		/// </summary>
		[XAQueryFieldAttribute("등락율")]
		public float diff;
		/// <summary>
		/// 거래량
		/// </summary>
		[XAQueryFieldAttribute("거래량")]
		public long volume;
		/// <summary>
		/// 거래량전일동시간비율
		/// </summary>
		[XAQueryFieldAttribute("거래량전일동시간비율")]
		public double stimeqrt;
		/// <summary>
		/// 거래대금
		/// </summary>
		[XAQueryFieldAttribute("거래대금")]
		public long value;
		/// <summary>
		/// 미결제량
		/// </summary>
		[XAQueryFieldAttribute("미결제량")]
		public long mgjv;
		/// <summary>
		/// 미결제증감
		/// </summary>
		[XAQueryFieldAttribute("미결제증감")]
		public long mgjvdiff;
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
		/// 52최고가
		/// </summary>
		[XAQueryFieldAttribute("52최고가")]
		public long high52w;
		/// <summary>
		/// 52최저가
		/// </summary>
		[XAQueryFieldAttribute("52최저가")]
		public long low52w;
		/// <summary>
		/// 베이시스
		/// </summary>
		[XAQueryFieldAttribute("베이시스")]
		public float basis;
		/// <summary>
		/// 기준가
		/// </summary>
		[XAQueryFieldAttribute("기준가")]
		public long recprice;
		/// <summary>
		/// 이론가
		/// </summary>
		[XAQueryFieldAttribute("이론가")]
		public long theoryprice;
		/// <summary>
		/// 괴리율
		/// </summary>
		[XAQueryFieldAttribute("괴리율")]
		public float glyl;
		/// <summary>
		/// 만기일
		/// </summary>
		[XAQueryFieldAttribute("만기일")]
		public string lastmonth;
		/// <summary>
		/// 잔여일
		/// </summary>
		[XAQueryFieldAttribute("잔여일")]
		public long jandatecnt;
		/// <summary>
		/// 종합지수
		/// </summary>
		[XAQueryFieldAttribute("종합지수")]
		public float pricejisu;
		/// <summary>
		/// 종합지수전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("종합지수전일대비구분")]
		public char jisusign;
		/// <summary>
		/// 종합지수전일대비
		/// </summary>
		[XAQueryFieldAttribute("종합지수전일대비")]
		public float jisuchange;
		/// <summary>
		/// 종합지수등락율
		/// </summary>
		[XAQueryFieldAttribute("종합지수등락율")]
		public float jisudiff;
		/// <summary>
		/// KOSPI200지수
		/// </summary>
		[XAQueryFieldAttribute("KOSPI200지수")]
		public float kospijisu;
		/// <summary>
		/// KOSPI200전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("KOSPI200전일대비구분")]
		public char kospisign;
		/// <summary>
		/// KOSPI200전일대비
		/// </summary>
		[XAQueryFieldAttribute("KOSPI200전일대비")]
		public float kospichange;
		/// <summary>
		/// KOSPI200등락율
		/// </summary>
		[XAQueryFieldAttribute("KOSPI200등락율")]
		public float kospidiff;
		/// <summary>
		/// 상장최고가
		/// </summary>
		[XAQueryFieldAttribute("상장최고가")]
		public long listhprice;
		/// <summary>
		/// 상장최저가
		/// </summary>
		[XAQueryFieldAttribute("상장최저가")]
		public long listlprice;
		/// <summary>
		/// 델타
		/// </summary>
		[XAQueryFieldAttribute("델타")]
		public float delt;
		/// <summary>
		/// 감마
		/// </summary>
		[XAQueryFieldAttribute("감마")]
		public float gama;
		/// <summary>
		/// 세타
		/// </summary>
		[XAQueryFieldAttribute("세타")]
		public float ceta;
		/// <summary>
		/// 베가
		/// </summary>
		[XAQueryFieldAttribute("베가")]
		public float vega;
		/// <summary>
		/// 로우
		/// </summary>
		[XAQueryFieldAttribute("로우")]
		public float rhox;
		/// <summary>
		/// 근월물현재가
		/// </summary>
		[XAQueryFieldAttribute("근월물현재가")]
		public long gmprice;
		/// <summary>
		/// 근월물전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("근월물전일대비구분")]
		public char gmsign;
		/// <summary>
		/// 근월물전일대비
		/// </summary>
		[XAQueryFieldAttribute("근월물전일대비")]
		public long gmchange;
		/// <summary>
		/// 근월물등락율
		/// </summary>
		[XAQueryFieldAttribute("근월물등락율")]
		public float gmdiff;
		/// <summary>
		/// 이론가
		/// </summary>
		[XAQueryFieldAttribute("이론가")]
		public long theorypriceg;
		/// <summary>
		/// 역사적변동성
		/// </summary>
		[XAQueryFieldAttribute("역사적변동성")]
		public float histimpv;
		/// <summary>
		/// 내재변동성
		/// </summary>
		[XAQueryFieldAttribute("내재변동성")]
		public float impv;
		/// <summary>
		/// 시장BASIS
		/// </summary>
		[XAQueryFieldAttribute("시장BASIS")]
		public long sbasis;
		/// <summary>
		/// 이론BASIS
		/// </summary>
		[XAQueryFieldAttribute("이론BASIS")]
		public long ibasis;
		/// <summary>
		/// 근월물종목코드
		/// </summary>
		[XAQueryFieldAttribute("근월물종목코드")]
		public string gmfutcode;
		/// <summary>
		/// 행사가
		/// </summary>
		[XAQueryFieldAttribute("행사가")]
		public long actprice;
		/// <summary>
		/// 기초자산단축코드
		/// </summary>
		[XAQueryFieldAttribute("기초자산단축코드")]
		public string shcode;
		/// <summary>
		/// 기초자산한글명
		/// </summary>
		[XAQueryFieldAttribute("기초자산한글명")]
		public string basehname;
		/// <summary>
		/// 기초자산현재가
		/// </summary>
		[XAQueryFieldAttribute("기초자산현재가")]
		public long baseprice;
		/// <summary>
		/// 기초자산현재가대비구분
		/// </summary>
		[XAQueryFieldAttribute("기초자산현재가대비구분")]
		public char basesign;
		/// <summary>
		/// 기초자산현재가전일대비
		/// </summary>
		[XAQueryFieldAttribute("기초자산현재가전일대비")]
		public long basechange;
		/// <summary>
		/// 기초자산등락률
		/// </summary>
		[XAQueryFieldAttribute("기초자산등락률")]
		public float basediff;
		/// <summary>
		/// 기초자산거래량
		/// </summary>
		[XAQueryFieldAttribute("기초자산거래량")]
		public long basevol;
		/// <summary>
		/// 기초자산전일거래량
		/// </summary>
		[XAQueryFieldAttribute("기초자산전일거래량")]
		public long baseprevol;
		/// <summary>
		/// 기초자산매수호가
		/// </summary>
		[XAQueryFieldAttribute("기초자산매수호가")]
		public long basebidprc;
		/// <summary>
		/// 기초자산매도호가
		/// </summary>
		[XAQueryFieldAttribute("기초자산매도호가")]
		public long baseaskprc;
		/// <summary>
		/// 기초자산외국계회원사순매수
		/// </summary>
		[XAQueryFieldAttribute("기초자산외국계회원사순매수")]
		public long basefornetbid;
		/// <summary>
		/// 상품군
		/// </summary>
		[XAQueryFieldAttribute("상품군")]
		public string prodgrp;
		/// <summary>
		/// 승수
		/// </summary>
		[XAQueryFieldAttribute("승수")]
		public float mulcnt;
		/// <summary>
		/// 단일가호가여부
		/// </summary>
		[XAQueryFieldAttribute("단일가호가여부")]
		public char danhochk;
		/// <summary>
		/// 예상체결가
		/// </summary>
		[XAQueryFieldAttribute("예상체결가")]
		public long yeprice;
		/// <summary>
		/// 예상체결가전일종가대비구분
		/// </summary>
		[XAQueryFieldAttribute("예상체결가전일종가대비구분")]
		public char jnilysign;
		/// <summary>
		/// 예상체결가전일종가대비
		/// </summary>
		[XAQueryFieldAttribute("예상체결가전일종가대비")]
		public long jnilychange;
		/// <summary>
		/// 예상체결가전일종가등락율
		/// </summary>
		[XAQueryFieldAttribute("예상체결가전일종가등락율")]
		public float jnilydrate;

		public static class F
		{
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
			/// 전일종가
			/// </summary>
			public const string jnilclose = "jnilclose";
			/// <summary>
			/// 등락율
			/// </summary>
			public const string diff = "diff";
			/// <summary>
			/// 거래량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// 거래량전일동시간비율
			/// </summary>
			public const string stimeqrt = "stimeqrt";
			/// <summary>
			/// 거래대금
			/// </summary>
			public const string value = "value";
			/// <summary>
			/// 미결제량
			/// </summary>
			public const string mgjv = "mgjv";
			/// <summary>
			/// 미결제증감
			/// </summary>
			public const string mgjvdiff = "mgjvdiff";
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
			/// 상한가
			/// </summary>
			public const string uplmtprice = "uplmtprice";
			/// <summary>
			/// 하한가
			/// </summary>
			public const string dnlmtprice = "dnlmtprice";
			/// <summary>
			/// 52최고가
			/// </summary>
			public const string high52w = "high52w";
			/// <summary>
			/// 52최저가
			/// </summary>
			public const string low52w = "low52w";
			/// <summary>
			/// 베이시스
			/// </summary>
			public const string basis = "basis";
			/// <summary>
			/// 기준가
			/// </summary>
			public const string recprice = "recprice";
			/// <summary>
			/// 이론가
			/// </summary>
			public const string theoryprice = "theoryprice";
			/// <summary>
			/// 괴리율
			/// </summary>
			public const string glyl = "glyl";
			/// <summary>
			/// 만기일
			/// </summary>
			public const string lastmonth = "lastmonth";
			/// <summary>
			/// 잔여일
			/// </summary>
			public const string jandatecnt = "jandatecnt";
			/// <summary>
			/// 종합지수
			/// </summary>
			public const string pricejisu = "pricejisu";
			/// <summary>
			/// 종합지수전일대비구분
			/// </summary>
			public const string jisusign = "jisusign";
			/// <summary>
			/// 종합지수전일대비
			/// </summary>
			public const string jisuchange = "jisuchange";
			/// <summary>
			/// 종합지수등락율
			/// </summary>
			public const string jisudiff = "jisudiff";
			/// <summary>
			/// KOSPI200지수
			/// </summary>
			public const string kospijisu = "kospijisu";
			/// <summary>
			/// KOSPI200전일대비구분
			/// </summary>
			public const string kospisign = "kospisign";
			/// <summary>
			/// KOSPI200전일대비
			/// </summary>
			public const string kospichange = "kospichange";
			/// <summary>
			/// KOSPI200등락율
			/// </summary>
			public const string kospidiff = "kospidiff";
			/// <summary>
			/// 상장최고가
			/// </summary>
			public const string listhprice = "listhprice";
			/// <summary>
			/// 상장최저가
			/// </summary>
			public const string listlprice = "listlprice";
			/// <summary>
			/// 델타
			/// </summary>
			public const string delt = "delt";
			/// <summary>
			/// 감마
			/// </summary>
			public const string gama = "gama";
			/// <summary>
			/// 세타
			/// </summary>
			public const string ceta = "ceta";
			/// <summary>
			/// 베가
			/// </summary>
			public const string vega = "vega";
			/// <summary>
			/// 로우
			/// </summary>
			public const string rhox = "rhox";
			/// <summary>
			/// 근월물현재가
			/// </summary>
			public const string gmprice = "gmprice";
			/// <summary>
			/// 근월물전일대비구분
			/// </summary>
			public const string gmsign = "gmsign";
			/// <summary>
			/// 근월물전일대비
			/// </summary>
			public const string gmchange = "gmchange";
			/// <summary>
			/// 근월물등락율
			/// </summary>
			public const string gmdiff = "gmdiff";
			/// <summary>
			/// 이론가
			/// </summary>
			public const string theorypriceg = "theorypriceg";
			/// <summary>
			/// 역사적변동성
			/// </summary>
			public const string histimpv = "histimpv";
			/// <summary>
			/// 내재변동성
			/// </summary>
			public const string impv = "impv";
			/// <summary>
			/// 시장BASIS
			/// </summary>
			public const string sbasis = "sbasis";
			/// <summary>
			/// 이론BASIS
			/// </summary>
			public const string ibasis = "ibasis";
			/// <summary>
			/// 근월물종목코드
			/// </summary>
			public const string gmfutcode = "gmfutcode";
			/// <summary>
			/// 행사가
			/// </summary>
			public const string actprice = "actprice";
			/// <summary>
			/// 기초자산단축코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 기초자산한글명
			/// </summary>
			public const string basehname = "basehname";
			/// <summary>
			/// 기초자산현재가
			/// </summary>
			public const string baseprice = "baseprice";
			/// <summary>
			/// 기초자산현재가대비구분
			/// </summary>
			public const string basesign = "basesign";
			/// <summary>
			/// 기초자산현재가전일대비
			/// </summary>
			public const string basechange = "basechange";
			/// <summary>
			/// 기초자산등락률
			/// </summary>
			public const string basediff = "basediff";
			/// <summary>
			/// 기초자산거래량
			/// </summary>
			public const string basevol = "basevol";
			/// <summary>
			/// 기초자산전일거래량
			/// </summary>
			public const string baseprevol = "baseprevol";
			/// <summary>
			/// 기초자산매수호가
			/// </summary>
			public const string basebidprc = "basebidprc";
			/// <summary>
			/// 기초자산매도호가
			/// </summary>
			public const string baseaskprc = "baseaskprc";
			/// <summary>
			/// 기초자산외국계회원사순매수
			/// </summary>
			public const string basefornetbid = "basefornetbid";
			/// <summary>
			/// 상품군
			/// </summary>
			public const string prodgrp = "prodgrp";
			/// <summary>
			/// 승수
			/// </summary>
			public const string mulcnt = "mulcnt";
			/// <summary>
			/// 단일가호가여부
			/// </summary>
			public const string danhochk = "danhochk";
			/// <summary>
			/// 예상체결가
			/// </summary>
			public const string yeprice = "yeprice";
			/// <summary>
			/// 예상체결가전일종가대비구분
			/// </summary>
			public const string jnilysign = "jnilysign";
			/// <summary>
			/// 예상체결가전일종가대비
			/// </summary>
			public const string jnilychange = "jnilychange";
			/// <summary>
			/// 예상체결가전일종가등락율
			/// </summary>
			public const string jnilydrate = "jnilydrate";
		}

		public static string[] AllFields = new string[]
		{
			F.hname,
			F.price,
			F.sign,
			F.change,
			F.jnilclose,
			F.diff,
			F.volume,
			F.stimeqrt,
			F.value,
			F.mgjv,
			F.mgjvdiff,
			F.open,
			F.high,
			F.low,
			F.uplmtprice,
			F.dnlmtprice,
			F.high52w,
			F.low52w,
			F.basis,
			F.recprice,
			F.theoryprice,
			F.glyl,
			F.lastmonth,
			F.jandatecnt,
			F.pricejisu,
			F.jisusign,
			F.jisuchange,
			F.jisudiff,
			F.kospijisu,
			F.kospisign,
			F.kospichange,
			F.kospidiff,
			F.listhprice,
			F.listlprice,
			F.delt,
			F.gama,
			F.ceta,
			F.vega,
			F.rhox,
			F.gmprice,
			F.gmsign,
			F.gmchange,
			F.gmdiff,
			F.theorypriceg,
			F.histimpv,
			F.impv,
			F.sbasis,
			F.ibasis,
			F.gmfutcode,
			F.actprice,
			F.shcode,
			F.basehname,
			F.baseprice,
			F.basesign,
			F.basechange,
			F.basediff,
			F.basevol,
			F.baseprevol,
			F.basebidprc,
			F.baseaskprc,
			F.basefornetbid,
			F.prodgrp,
			F.mulcnt,
			F.danhochk,
			F.yeprice,
			F.jnilysign,
			F.jnilychange,
			F.jnilydrate,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["hname"] = new XAQueryFieldInfo("char", hname, hname, "한글명", (decimal)20);
			dict["price"] = new XAQueryFieldInfo("long", price, price.ToString("d8"), "현재가", (decimal)8);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("long", change, change.ToString("d8"), "전일대비", (decimal)8);
			dict["jnilclose"] = new XAQueryFieldInfo("long", jnilclose, jnilclose.ToString("d8"), "전일종가", (decimal)8);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "거래량", (decimal)12);
			dict["stimeqrt"] = new XAQueryFieldInfo("double", stimeqrt, stimeqrt.ToString("000000.00"), "거래량전일동시간비율", (decimal)6.2);
			dict["value"] = new XAQueryFieldInfo("long", value, value.ToString("d12"), "거래대금", (decimal)12);
			dict["mgjv"] = new XAQueryFieldInfo("long", mgjv, mgjv.ToString("d8"), "미결제량", (decimal)8);
			dict["mgjvdiff"] = new XAQueryFieldInfo("long", mgjvdiff, mgjvdiff.ToString("d8"), "미결제증감", (decimal)8);
			dict["open"] = new XAQueryFieldInfo("long", open, open.ToString("d8"), "시가", (decimal)8);
			dict["high"] = new XAQueryFieldInfo("long", high, high.ToString("d8"), "고가", (decimal)8);
			dict["low"] = new XAQueryFieldInfo("long", low, low.ToString("d8"), "저가", (decimal)8);
			dict["uplmtprice"] = new XAQueryFieldInfo("long", uplmtprice, uplmtprice.ToString("d8"), "상한가", (decimal)8);
			dict["dnlmtprice"] = new XAQueryFieldInfo("long", dnlmtprice, dnlmtprice.ToString("d8"), "하한가", (decimal)8);
			dict["high52w"] = new XAQueryFieldInfo("long", high52w, high52w.ToString("d8"), "52최고가", (decimal)8);
			dict["low52w"] = new XAQueryFieldInfo("long", low52w, low52w.ToString("d8"), "52최저가", (decimal)8);
			dict["basis"] = new XAQueryFieldInfo("float", basis, basis.ToString("000000.00"), "베이시스", (decimal)6.2);
			dict["recprice"] = new XAQueryFieldInfo("long", recprice, recprice.ToString("d8"), "기준가", (decimal)8);
			dict["theoryprice"] = new XAQueryFieldInfo("long", theoryprice, theoryprice.ToString("d8"), "이론가", (decimal)8);
			dict["glyl"] = new XAQueryFieldInfo("float", glyl, glyl.ToString("000000.000"), "괴리율", (decimal)6.3);
			dict["lastmonth"] = new XAQueryFieldInfo("char", lastmonth, lastmonth, "만기일", (decimal)8);
			dict["jandatecnt"] = new XAQueryFieldInfo("long", jandatecnt, jandatecnt.ToString("d8"), "잔여일", (decimal)8);
			dict["pricejisu"] = new XAQueryFieldInfo("float", pricejisu, pricejisu.ToString("000000.00"), "종합지수", (decimal)6.2);
			dict["jisusign"] = new XAQueryFieldInfo("char", jisusign, jisusign.ToString(), "종합지수전일대비구분", (decimal)1);
			dict["jisuchange"] = new XAQueryFieldInfo("float", jisuchange, jisuchange.ToString("000000.00"), "종합지수전일대비", (decimal)6.2);
			dict["jisudiff"] = new XAQueryFieldInfo("float", jisudiff, jisudiff.ToString("000000.00"), "종합지수등락율", (decimal)6.2);
			dict["kospijisu"] = new XAQueryFieldInfo("float", kospijisu, kospijisu.ToString("000000.00"), "KOSPI200지수", (decimal)6.2);
			dict["kospisign"] = new XAQueryFieldInfo("char", kospisign, kospisign.ToString(), "KOSPI200전일대비구분", (decimal)1);
			dict["kospichange"] = new XAQueryFieldInfo("float", kospichange, kospichange.ToString("000000.00"), "KOSPI200전일대비", (decimal)6.2);
			dict["kospidiff"] = new XAQueryFieldInfo("float", kospidiff, kospidiff.ToString("000000.00"), "KOSPI200등락율", (decimal)6.2);
			dict["listhprice"] = new XAQueryFieldInfo("long", listhprice, listhprice.ToString("d8"), "상장최고가", (decimal)8);
			dict["listlprice"] = new XAQueryFieldInfo("long", listlprice, listlprice.ToString("d8"), "상장최저가", (decimal)8);
			dict["delt"] = new XAQueryFieldInfo("float", delt, delt.ToString("000000.0000"), "델타", (decimal)6.4);
			dict["gama"] = new XAQueryFieldInfo("float", gama, gama.ToString("000000.0000"), "감마", (decimal)6.4);
			dict["ceta"] = new XAQueryFieldInfo("float", ceta, ceta.ToString("000000.0000"), "세타", (decimal)6.4);
			dict["vega"] = new XAQueryFieldInfo("float", vega, vega.ToString("000000.0000"), "베가", (decimal)6.4);
			dict["rhox"] = new XAQueryFieldInfo("float", rhox, rhox.ToString("000000.0000"), "로우", (decimal)6.4);
			dict["gmprice"] = new XAQueryFieldInfo("long", gmprice, gmprice.ToString("d8"), "근월물현재가", (decimal)8);
			dict["gmsign"] = new XAQueryFieldInfo("char", gmsign, gmsign.ToString(), "근월물전일대비구분", (decimal)1);
			dict["gmchange"] = new XAQueryFieldInfo("long", gmchange, gmchange.ToString("d8"), "근월물전일대비", (decimal)8);
			dict["gmdiff"] = new XAQueryFieldInfo("float", gmdiff, gmdiff.ToString("000000.00"), "근월물등락율", (decimal)6.2);
			dict["theorypriceg"] = new XAQueryFieldInfo("long", theorypriceg, theorypriceg.ToString("d8"), "이론가", (decimal)8);
			dict["histimpv"] = new XAQueryFieldInfo("float", histimpv, histimpv.ToString("000000.00"), "역사적변동성", (decimal)6.2);
			dict["impv"] = new XAQueryFieldInfo("float", impv, impv.ToString("000000.00"), "내재변동성", (decimal)6.2);
			dict["sbasis"] = new XAQueryFieldInfo("long", sbasis, sbasis.ToString("d8"), "시장BASIS", (decimal)8);
			dict["ibasis"] = new XAQueryFieldInfo("long", ibasis, ibasis.ToString("d8"), "이론BASIS", (decimal)8);
			dict["gmfutcode"] = new XAQueryFieldInfo("char", gmfutcode, gmfutcode, "근월물종목코드", (decimal)8);
			dict["actprice"] = new XAQueryFieldInfo("long", actprice, actprice.ToString("d8"), "행사가", (decimal)8);
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "기초자산단축코드", (decimal)6);
			dict["basehname"] = new XAQueryFieldInfo("char", basehname, basehname, "기초자산한글명", (decimal)20);
			dict["baseprice"] = new XAQueryFieldInfo("long", baseprice, baseprice.ToString("d8"), "기초자산현재가", (decimal)8);
			dict["basesign"] = new XAQueryFieldInfo("char", basesign, basesign.ToString(), "기초자산현재가대비구분", (decimal)1);
			dict["basechange"] = new XAQueryFieldInfo("long", basechange, basechange.ToString("d8"), "기초자산현재가전일대비", (decimal)8);
			dict["basediff"] = new XAQueryFieldInfo("float", basediff, basediff.ToString("000000.00"), "기초자산등락률", (decimal)6.2);
			dict["basevol"] = new XAQueryFieldInfo("long", basevol, basevol.ToString("d12"), "기초자산거래량", (decimal)12);
			dict["baseprevol"] = new XAQueryFieldInfo("long", baseprevol, baseprevol.ToString("d12"), "기초자산전일거래량", (decimal)12);
			dict["basebidprc"] = new XAQueryFieldInfo("long", basebidprc, basebidprc.ToString("d9"), "기초자산매수호가", (decimal)9);
			dict["baseaskprc"] = new XAQueryFieldInfo("long", baseaskprc, baseaskprc.ToString("d9"), "기초자산매도호가", (decimal)9);
			dict["basefornetbid"] = new XAQueryFieldInfo("long", basefornetbid, basefornetbid.ToString("d12"), "기초자산외국계회원사순매수", (decimal)12);
			dict["prodgrp"] = new XAQueryFieldInfo("char", prodgrp, prodgrp, "상품군", (decimal)20);
			dict["mulcnt"] = new XAQueryFieldInfo("float", mulcnt, mulcnt.ToString("000000000000.00000000"), "승수", (decimal)12.8);
			dict["danhochk"] = new XAQueryFieldInfo("char", danhochk, danhochk.ToString(), "단일가호가여부", (decimal)1);
			dict["yeprice"] = new XAQueryFieldInfo("long", yeprice, yeprice.ToString("d8"), "예상체결가", (decimal)8);
			dict["jnilysign"] = new XAQueryFieldInfo("char", jnilysign, jnilysign.ToString(), "예상체결가전일종가대비구분", (decimal)1);
			dict["jnilychange"] = new XAQueryFieldInfo("long", jnilychange, jnilychange.ToString("d8"), "예상체결가전일종가대비", (decimal)8);
			dict["jnilydrate"] = new XAQueryFieldInfo("float", jnilydrate, jnilydrate.ToString("000000.00"), "예상체결가전일종가등락율", (decimal)6.2);

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

				case "jnilclose":
					this.jnilclose = fieldInfo.FieldValue.ParseLong("jnilclose");
				break;

				case "diff":
					this.diff = fieldInfo.FieldValue.ParseFloat("diff");
				break;

				case "volume":
					this.volume = fieldInfo.FieldValue.ParseLong("volume");
				break;

				case "stimeqrt":
					this.stimeqrt = fieldInfo.FieldValue.ParseDouble("stimeqrt");
				break;

				case "value":
					this.value = fieldInfo.FieldValue.ParseLong("value");
				break;

				case "mgjv":
					this.mgjv = fieldInfo.FieldValue.ParseLong("mgjv");
				break;

				case "mgjvdiff":
					this.mgjvdiff = fieldInfo.FieldValue.ParseLong("mgjvdiff");
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

				case "uplmtprice":
					this.uplmtprice = fieldInfo.FieldValue.ParseLong("uplmtprice");
				break;

				case "dnlmtprice":
					this.dnlmtprice = fieldInfo.FieldValue.ParseLong("dnlmtprice");
				break;

				case "high52w":
					this.high52w = fieldInfo.FieldValue.ParseLong("high52w");
				break;

				case "low52w":
					this.low52w = fieldInfo.FieldValue.ParseLong("low52w");
				break;

				case "basis":
					this.basis = fieldInfo.FieldValue.ParseFloat("basis");
				break;

				case "recprice":
					this.recprice = fieldInfo.FieldValue.ParseLong("recprice");
				break;

				case "theoryprice":
					this.theoryprice = fieldInfo.FieldValue.ParseLong("theoryprice");
				break;

				case "glyl":
					this.glyl = fieldInfo.FieldValue.ParseFloat("glyl");
				break;

				case "lastmonth":
					this.lastmonth = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "jandatecnt":
					this.jandatecnt = fieldInfo.FieldValue.ParseLong("jandatecnt");
				break;

				case "pricejisu":
					this.pricejisu = fieldInfo.FieldValue.ParseFloat("pricejisu");
				break;

				case "jisusign":
					this.jisusign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "jisuchange":
					this.jisuchange = fieldInfo.FieldValue.ParseFloat("jisuchange");
				break;

				case "jisudiff":
					this.jisudiff = fieldInfo.FieldValue.ParseFloat("jisudiff");
				break;

				case "kospijisu":
					this.kospijisu = fieldInfo.FieldValue.ParseFloat("kospijisu");
				break;

				case "kospisign":
					this.kospisign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "kospichange":
					this.kospichange = fieldInfo.FieldValue.ParseFloat("kospichange");
				break;

				case "kospidiff":
					this.kospidiff = fieldInfo.FieldValue.ParseFloat("kospidiff");
				break;

				case "listhprice":
					this.listhprice = fieldInfo.FieldValue.ParseLong("listhprice");
				break;

				case "listlprice":
					this.listlprice = fieldInfo.FieldValue.ParseLong("listlprice");
				break;

				case "delt":
					this.delt = fieldInfo.FieldValue.ParseFloat("delt");
				break;

				case "gama":
					this.gama = fieldInfo.FieldValue.ParseFloat("gama");
				break;

				case "ceta":
					this.ceta = fieldInfo.FieldValue.ParseFloat("ceta");
				break;

				case "vega":
					this.vega = fieldInfo.FieldValue.ParseFloat("vega");
				break;

				case "rhox":
					this.rhox = fieldInfo.FieldValue.ParseFloat("rhox");
				break;

				case "gmprice":
					this.gmprice = fieldInfo.FieldValue.ParseLong("gmprice");
				break;

				case "gmsign":
					this.gmsign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "gmchange":
					this.gmchange = fieldInfo.FieldValue.ParseLong("gmchange");
				break;

				case "gmdiff":
					this.gmdiff = fieldInfo.FieldValue.ParseFloat("gmdiff");
				break;

				case "theorypriceg":
					this.theorypriceg = fieldInfo.FieldValue.ParseLong("theorypriceg");
				break;

				case "histimpv":
					this.histimpv = fieldInfo.FieldValue.ParseFloat("histimpv");
				break;

				case "impv":
					this.impv = fieldInfo.FieldValue.ParseFloat("impv");
				break;

				case "sbasis":
					this.sbasis = fieldInfo.FieldValue.ParseLong("sbasis");
				break;

				case "ibasis":
					this.ibasis = fieldInfo.FieldValue.ParseLong("ibasis");
				break;

				case "gmfutcode":
					this.gmfutcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "actprice":
					this.actprice = fieldInfo.FieldValue.ParseLong("actprice");
				break;

				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "basehname":
					this.basehname = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "baseprice":
					this.baseprice = fieldInfo.FieldValue.ParseLong("baseprice");
				break;

				case "basesign":
					this.basesign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "basechange":
					this.basechange = fieldInfo.FieldValue.ParseLong("basechange");
				break;

				case "basediff":
					this.basediff = fieldInfo.FieldValue.ParseFloat("basediff");
				break;

				case "basevol":
					this.basevol = fieldInfo.FieldValue.ParseLong("basevol");
				break;

				case "baseprevol":
					this.baseprevol = fieldInfo.FieldValue.ParseLong("baseprevol");
				break;

				case "basebidprc":
					this.basebidprc = fieldInfo.FieldValue.ParseLong("basebidprc");
				break;

				case "baseaskprc":
					this.baseaskprc = fieldInfo.FieldValue.ParseLong("baseaskprc");
				break;

				case "basefornetbid":
					this.basefornetbid = fieldInfo.FieldValue.ParseLong("basefornetbid");
				break;

				case "prodgrp":
					this.prodgrp = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "mulcnt":
					this.mulcnt = fieldInfo.FieldValue.ParseFloat("mulcnt");
				break;

				case "danhochk":
					this.danhochk = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "yeprice":
					this.yeprice = fieldInfo.FieldValue.ParseLong("yeprice");
				break;

				case "jnilysign":
					this.jnilysign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "jnilychange":
					this.jnilychange = fieldInfo.FieldValue.ParseLong("jnilychange");
				break;

				case "jnilydrate":
					this.jnilydrate = fieldInfo.FieldValue.ParseFloat("jnilydrate");
				break;


			}
		}

		public static XQt8402OutBlock FromQuery(XQt8402 query)
		{
			XQt8402OutBlock block = new XQt8402OutBlock();
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
				block.hname = query.GetFieldData(block.GetBlockName(), "hname", 0).TrimEnd('?'); // char 20
				block.price = query.GetFieldData(block.GetBlockName(), "price", 0).ParseLong("price"); // long 8
				block.sign = query.GetFieldData(block.GetBlockName(), "sign", 0).FirstOrDefault(); // char 1
				block.change = query.GetFieldData(block.GetBlockName(), "change", 0).ParseLong("change"); // long 8
				block.jnilclose = query.GetFieldData(block.GetBlockName(), "jnilclose", 0).ParseLong("jnilclose"); // long 8
				block.diff = query.GetFieldData(block.GetBlockName(), "diff", 0).ParseFloat("diff"); // float 6.2
				block.volume = query.GetFieldData(block.GetBlockName(), "volume", 0).ParseLong("volume"); // long 12
				block.stimeqrt = query.GetFieldData(block.GetBlockName(), "stimeqrt", 0).ParseDouble("stimeqrt"); // double 6.2
				block.value = query.GetFieldData(block.GetBlockName(), "value", 0).ParseLong("value"); // long 12
				block.mgjv = query.GetFieldData(block.GetBlockName(), "mgjv", 0).ParseLong("mgjv"); // long 8
				block.mgjvdiff = query.GetFieldData(block.GetBlockName(), "mgjvdiff", 0).ParseLong("mgjvdiff"); // long 8
				block.open = query.GetFieldData(block.GetBlockName(), "open", 0).ParseLong("open"); // long 8
				block.high = query.GetFieldData(block.GetBlockName(), "high", 0).ParseLong("high"); // long 8
				block.low = query.GetFieldData(block.GetBlockName(), "low", 0).ParseLong("low"); // long 8
				block.uplmtprice = query.GetFieldData(block.GetBlockName(), "uplmtprice", 0).ParseLong("uplmtprice"); // long 8
				block.dnlmtprice = query.GetFieldData(block.GetBlockName(), "dnlmtprice", 0).ParseLong("dnlmtprice"); // long 8
				block.high52w = query.GetFieldData(block.GetBlockName(), "high52w", 0).ParseLong("high52w"); // long 8
				block.low52w = query.GetFieldData(block.GetBlockName(), "low52w", 0).ParseLong("low52w"); // long 8
				block.basis = query.GetFieldData(block.GetBlockName(), "basis", 0).ParseFloat("basis"); // float 6.2
				block.recprice = query.GetFieldData(block.GetBlockName(), "recprice", 0).ParseLong("recprice"); // long 8
				block.theoryprice = query.GetFieldData(block.GetBlockName(), "theoryprice", 0).ParseLong("theoryprice"); // long 8
				block.glyl = query.GetFieldData(block.GetBlockName(), "glyl", 0).ParseFloat("glyl"); // float 6.3
				block.lastmonth = query.GetFieldData(block.GetBlockName(), "lastmonth", 0).TrimEnd('?'); // char 8
				block.jandatecnt = query.GetFieldData(block.GetBlockName(), "jandatecnt", 0).ParseLong("jandatecnt"); // long 8
				block.pricejisu = query.GetFieldData(block.GetBlockName(), "pricejisu", 0).ParseFloat("pricejisu"); // float 6.2
				block.jisusign = query.GetFieldData(block.GetBlockName(), "jisusign", 0).FirstOrDefault(); // char 1
				block.jisuchange = query.GetFieldData(block.GetBlockName(), "jisuchange", 0).ParseFloat("jisuchange"); // float 6.2
				block.jisudiff = query.GetFieldData(block.GetBlockName(), "jisudiff", 0).ParseFloat("jisudiff"); // float 6.2
				block.kospijisu = query.GetFieldData(block.GetBlockName(), "kospijisu", 0).ParseFloat("kospijisu"); // float 6.2
				block.kospisign = query.GetFieldData(block.GetBlockName(), "kospisign", 0).FirstOrDefault(); // char 1
				block.kospichange = query.GetFieldData(block.GetBlockName(), "kospichange", 0).ParseFloat("kospichange"); // float 6.2
				block.kospidiff = query.GetFieldData(block.GetBlockName(), "kospidiff", 0).ParseFloat("kospidiff"); // float 6.2
				block.listhprice = query.GetFieldData(block.GetBlockName(), "listhprice", 0).ParseLong("listhprice"); // long 8
				block.listlprice = query.GetFieldData(block.GetBlockName(), "listlprice", 0).ParseLong("listlprice"); // long 8
				block.delt = query.GetFieldData(block.GetBlockName(), "delt", 0).ParseFloat("delt"); // float 6.4
				block.gama = query.GetFieldData(block.GetBlockName(), "gama", 0).ParseFloat("gama"); // float 6.4
				block.ceta = query.GetFieldData(block.GetBlockName(), "ceta", 0).ParseFloat("ceta"); // float 6.4
				block.vega = query.GetFieldData(block.GetBlockName(), "vega", 0).ParseFloat("vega"); // float 6.4
				block.rhox = query.GetFieldData(block.GetBlockName(), "rhox", 0).ParseFloat("rhox"); // float 6.4
				block.gmprice = query.GetFieldData(block.GetBlockName(), "gmprice", 0).ParseLong("gmprice"); // long 8
				block.gmsign = query.GetFieldData(block.GetBlockName(), "gmsign", 0).FirstOrDefault(); // char 1
				block.gmchange = query.GetFieldData(block.GetBlockName(), "gmchange", 0).ParseLong("gmchange"); // long 8
				block.gmdiff = query.GetFieldData(block.GetBlockName(), "gmdiff", 0).ParseFloat("gmdiff"); // float 6.2
				block.theorypriceg = query.GetFieldData(block.GetBlockName(), "theorypriceg", 0).ParseLong("theorypriceg"); // long 8
				block.histimpv = query.GetFieldData(block.GetBlockName(), "histimpv", 0).ParseFloat("histimpv"); // float 6.2
				block.impv = query.GetFieldData(block.GetBlockName(), "impv", 0).ParseFloat("impv"); // float 6.2
				block.sbasis = query.GetFieldData(block.GetBlockName(), "sbasis", 0).ParseLong("sbasis"); // long 8
				block.ibasis = query.GetFieldData(block.GetBlockName(), "ibasis", 0).ParseLong("ibasis"); // long 8
				block.gmfutcode = query.GetFieldData(block.GetBlockName(), "gmfutcode", 0).TrimEnd('?'); // char 8
				block.actprice = query.GetFieldData(block.GetBlockName(), "actprice", 0).ParseLong("actprice"); // long 8
				block.shcode = query.GetFieldData(block.GetBlockName(), "shcode", 0).TrimEnd('?'); // char 6
				block.basehname = query.GetFieldData(block.GetBlockName(), "basehname", 0).TrimEnd('?'); // char 20
				block.baseprice = query.GetFieldData(block.GetBlockName(), "baseprice", 0).ParseLong("baseprice"); // long 8
				block.basesign = query.GetFieldData(block.GetBlockName(), "basesign", 0).FirstOrDefault(); // char 1
				block.basechange = query.GetFieldData(block.GetBlockName(), "basechange", 0).ParseLong("basechange"); // long 8
				block.basediff = query.GetFieldData(block.GetBlockName(), "basediff", 0).ParseFloat("basediff"); // float 6.2
				block.basevol = query.GetFieldData(block.GetBlockName(), "basevol", 0).ParseLong("basevol"); // long 12
				block.baseprevol = query.GetFieldData(block.GetBlockName(), "baseprevol", 0).ParseLong("baseprevol"); // long 12
				block.basebidprc = query.GetFieldData(block.GetBlockName(), "basebidprc", 0).ParseLong("basebidprc"); // long 9
				block.baseaskprc = query.GetFieldData(block.GetBlockName(), "baseaskprc", 0).ParseLong("baseaskprc"); // long 9
				block.basefornetbid = query.GetFieldData(block.GetBlockName(), "basefornetbid", 0).ParseLong("basefornetbid"); // long 12
				block.prodgrp = query.GetFieldData(block.GetBlockName(), "prodgrp", 0).TrimEnd('?'); // char 20
				block.mulcnt = query.GetFieldData(block.GetBlockName(), "mulcnt", 0).ParseFloat("mulcnt"); // float 12.8
				block.danhochk = query.GetFieldData(block.GetBlockName(), "danhochk", 0).FirstOrDefault(); // char 1
				block.yeprice = query.GetFieldData(block.GetBlockName(), "yeprice", 0).ParseLong("yeprice"); // long 8
				block.jnilysign = query.GetFieldData(block.GetBlockName(), "jnilysign", 0).FirstOrDefault(); // char 1
				block.jnilychange = query.GetFieldData(block.GetBlockName(), "jnilychange", 0).ParseLong("jnilychange"); // long 8
				block.jnilydrate = query.GetFieldData(block.GetBlockName(), "jnilydrate", 0).ParseFloat("jnilydrate"); // float 6.2

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (hname?.Length > 20) return false; // char 20
			if (price.ToString().Length > 8) return false; // long 8
			// sign char 1
			if (change.ToString().Length > 8) return false; // long 8
			if (jnilclose.ToString().Length > 8) return false; // long 8
			// diff float 6.2
			if (volume.ToString().Length > 12) return false; // long 12
			// stimeqrt double 6.2
			if (value.ToString().Length > 12) return false; // long 12
			if (mgjv.ToString().Length > 8) return false; // long 8
			if (mgjvdiff.ToString().Length > 8) return false; // long 8
			if (open.ToString().Length > 8) return false; // long 8
			if (high.ToString().Length > 8) return false; // long 8
			if (low.ToString().Length > 8) return false; // long 8
			if (uplmtprice.ToString().Length > 8) return false; // long 8
			if (dnlmtprice.ToString().Length > 8) return false; // long 8
			if (high52w.ToString().Length > 8) return false; // long 8
			if (low52w.ToString().Length > 8) return false; // long 8
			// basis float 6.2
			if (recprice.ToString().Length > 8) return false; // long 8
			if (theoryprice.ToString().Length > 8) return false; // long 8
			// glyl float 6.3
			if (lastmonth?.Length > 8) return false; // char 8
			if (jandatecnt.ToString().Length > 8) return false; // long 8
			// pricejisu float 6.2
			// jisusign char 1
			// jisuchange float 6.2
			// jisudiff float 6.2
			// kospijisu float 6.2
			// kospisign char 1
			// kospichange float 6.2
			// kospidiff float 6.2
			if (listhprice.ToString().Length > 8) return false; // long 8
			if (listlprice.ToString().Length > 8) return false; // long 8
			// delt float 6.4
			// gama float 6.4
			// ceta float 6.4
			// vega float 6.4
			// rhox float 6.4
			if (gmprice.ToString().Length > 8) return false; // long 8
			// gmsign char 1
			if (gmchange.ToString().Length > 8) return false; // long 8
			// gmdiff float 6.2
			if (theorypriceg.ToString().Length > 8) return false; // long 8
			// histimpv float 6.2
			// impv float 6.2
			if (sbasis.ToString().Length > 8) return false; // long 8
			if (ibasis.ToString().Length > 8) return false; // long 8
			if (gmfutcode?.Length > 8) return false; // char 8
			if (actprice.ToString().Length > 8) return false; // long 8
			if (shcode?.Length > 6) return false; // char 6
			if (basehname?.Length > 20) return false; // char 20
			if (baseprice.ToString().Length > 8) return false; // long 8
			// basesign char 1
			if (basechange.ToString().Length > 8) return false; // long 8
			// basediff float 6.2
			if (basevol.ToString().Length > 12) return false; // long 12
			if (baseprevol.ToString().Length > 12) return false; // long 12
			if (basebidprc.ToString().Length > 9) return false; // long 9
			if (baseaskprc.ToString().Length > 9) return false; // long 9
			if (basefornetbid.ToString().Length > 12) return false; // long 12
			if (prodgrp?.Length > 20) return false; // char 20
			// mulcnt float 12.8
			// danhochk char 1
			if (yeprice.ToString().Length > 8) return false; // long 8
			// jnilysign char 1
			if (jnilychange.ToString().Length > 8) return false; // long 8
			// jnilydrate float 6.2

			return true;
		}
	}

	public partial class XQt8402 : XingQuery
	{
		/// <summary>
		/// t8402
		/// </summary>
		public const string _typeName = "t8402";
		/// <summary>
		/// 주식선물현재가조회(API용)(t8402)
		/// </summary>
		public const string _typeDesc = "주식선물현재가조회(API용)(t8402)";
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
		/// t8402
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 주식선물현재가조회(API용)(t8402)
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

		public XQt8402() : base("t8402") { }


		public bool SetFields(XQt8402InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "focode", 0, block.focode); // char 8

			return true;
		}

		public XQt8402OutBlock GetBlock()
		{
			XQt8402OutBlock instance = XQt8402OutBlock.FromQuery(this);
			return instance;

		}


	}

}
