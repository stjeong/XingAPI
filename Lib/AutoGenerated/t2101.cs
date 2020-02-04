using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt2101InBlock : XingBlock
	{
		/// <summary>
		/// t2101InBlock
		/// </summary>
		public const string _blockName = "t2101InBlock";
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
		/// t2101InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t2101InBlock
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

	public partial class XQt2101OutBlock : XingBlock
	{
		/// <summary>
		/// t2101OutBlock
		/// </summary>
		public const string _blockName = "t2101OutBlock";
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
		/// t2101OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t2101OutBlock
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
		public float price;
		/// <summary>
		/// 전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("전일대비구분")]
		public char sign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[XAQueryFieldAttribute("전일대비")]
		public float change;
		/// <summary>
		/// 전일종가
		/// </summary>
		[XAQueryFieldAttribute("전일종가")]
		public float jnilclose;
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
		public float open;
		/// <summary>
		/// 고가
		/// </summary>
		[XAQueryFieldAttribute("고가")]
		public float high;
		/// <summary>
		/// 저가
		/// </summary>
		[XAQueryFieldAttribute("저가")]
		public float low;
		/// <summary>
		/// 상한가
		/// </summary>
		[XAQueryFieldAttribute("상한가")]
		public float uplmtprice;
		/// <summary>
		/// 하한가
		/// </summary>
		[XAQueryFieldAttribute("하한가")]
		public float dnlmtprice;
		/// <summary>
		/// 52최고가
		/// </summary>
		[XAQueryFieldAttribute("52최고가")]
		public float high52w;
		/// <summary>
		/// 52최저가
		/// </summary>
		[XAQueryFieldAttribute("52최저가")]
		public float low52w;
		/// <summary>
		/// 베이시스
		/// </summary>
		[XAQueryFieldAttribute("베이시스")]
		public float basis;
		/// <summary>
		/// 기준가
		/// </summary>
		[XAQueryFieldAttribute("기준가")]
		public float recprice;
		/// <summary>
		/// 이론가
		/// </summary>
		[XAQueryFieldAttribute("이론가")]
		public float theoryprice;
		/// <summary>
		/// 괴리율
		/// </summary>
		[XAQueryFieldAttribute("괴리율")]
		public float glyl;
		/// <summary>
		/// CB상한가
		/// </summary>
		[XAQueryFieldAttribute("CB상한가")]
		public float cbhprice;
		/// <summary>
		/// CB하한가
		/// </summary>
		[XAQueryFieldAttribute("CB하한가")]
		public float cblprice;
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
		public float listhprice;
		/// <summary>
		/// 상장최저가
		/// </summary>
		[XAQueryFieldAttribute("상장최저가")]
		public float listlprice;
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
		public float gmprice;
		/// <summary>
		/// 근월물전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("근월물전일대비구분")]
		public char gmsign;
		/// <summary>
		/// 근월물전일대비
		/// </summary>
		[XAQueryFieldAttribute("근월물전일대비")]
		public float gmchange;
		/// <summary>
		/// 근월물등락율
		/// </summary>
		[XAQueryFieldAttribute("근월물등락율")]
		public float gmdiff;
		/// <summary>
		/// 이론가
		/// </summary>
		[XAQueryFieldAttribute("이론가")]
		public float theorypriceg;
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
		public float sbasis;
		/// <summary>
		/// 이론BASIS
		/// </summary>
		[XAQueryFieldAttribute("이론BASIS")]
		public float ibasis;
		/// <summary>
		/// 근월물종목코드
		/// </summary>
		[XAQueryFieldAttribute("근월물종목코드")]
		public string gmfutcode;
		/// <summary>
		/// 행사가
		/// </summary>
		[XAQueryFieldAttribute("행사가")]
		public float actprice;
		/// <summary>
		/// 거래소민감도수신시간
		/// </summary>
		[XAQueryFieldAttribute("거래소민감도수신시간")]
		public string greeks_time;
		/// <summary>
		/// 거래소민감도확정여부
		/// </summary>
		[XAQueryFieldAttribute("거래소민감도확정여부")]
		public string greeks_confirm;
		/// <summary>
		/// 단일가호가여부
		/// </summary>
		[XAQueryFieldAttribute("단일가호가여부")]
		public char danhochk;
		/// <summary>
		/// 예상체결가
		/// </summary>
		[XAQueryFieldAttribute("예상체결가")]
		public float yeprice;
		/// <summary>
		/// 예상체결가전일종가대비구분
		/// </summary>
		[XAQueryFieldAttribute("예상체결가전일종가대비구분")]
		public char jnilysign;
		/// <summary>
		/// 예상체결가전일종가대비
		/// </summary>
		[XAQueryFieldAttribute("예상체결가전일종가대비")]
		public float jnilychange;
		/// <summary>
		/// 예상체결가전일종가등락율
		/// </summary>
		[XAQueryFieldAttribute("예상체결가전일종가등락율")]
		public float jnilydrate;
		/// <summary>
		/// 배분구분(1:배분개시2:배분해제0:미발생)
		/// </summary>
		[XAQueryFieldAttribute("배분구분(1:배분개시2:배분해제0:미발생)")]
		public char alloc_gubun;
		/// <summary>
		/// 잔여일(영업일)
		/// </summary>
		[XAQueryFieldAttribute("잔여일(영업일)")]
		public long bjandatecnt;
		/// <summary>
		/// 종목코드
		/// </summary>
		[XAQueryFieldAttribute("종목코드")]
		public string focode;
		/// <summary>
		/// 실시간가격제한여부(0:대상아님1:적용중2:미적용중3:일시해제)
		/// </summary>
		[XAQueryFieldAttribute("실시간가격제한여부(0:대상아님1:적용중2:미적용중3:일시해제)")]
		public char dy_gubun;
		/// <summary>
		/// 실시간상한가
		/// </summary>
		[XAQueryFieldAttribute("실시간상한가")]
		public float dy_uplmtprice;
		/// <summary>
		/// 실시간하한가
		/// </summary>
		[XAQueryFieldAttribute("실시간하한가")]
		public float dy_dnlmtprice;
		/// <summary>
		/// 가격제한폭확대(0:미확대1:확대2:대상아님)
		/// </summary>
		[XAQueryFieldAttribute("가격제한폭확대(0:미확대1:확대2:대상아님)")]
		public char updnstep_gubun;
		/// <summary>
		/// 상한적용단계
		/// </summary>
		[XAQueryFieldAttribute("상한적용단계")]
		public string upstep;
		/// <summary>
		/// 하한적용단계
		/// </summary>
		[XAQueryFieldAttribute("하한적용단계")]
		public string dnstep;
		/// <summary>
		/// 3단계상한가
		/// </summary>
		[XAQueryFieldAttribute("3단계상한가")]
		public float uplmtprice_3rd;
		/// <summary>
		/// 3단계하한가
		/// </summary>
		[XAQueryFieldAttribute("3단계하한가")]
		public float dnlmtprice_3rd;

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
			/// CB상한가
			/// </summary>
			public const string cbhprice = "cbhprice";
			/// <summary>
			/// CB하한가
			/// </summary>
			public const string cblprice = "cblprice";
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
			/// 거래소민감도수신시간
			/// </summary>
			public const string greeks_time = "greeks_time";
			/// <summary>
			/// 거래소민감도확정여부
			/// </summary>
			public const string greeks_confirm = "greeks_confirm";
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
			/// <summary>
			/// 배분구분(1:배분개시2:배분해제0:미발생)
			/// </summary>
			public const string alloc_gubun = "alloc_gubun";
			/// <summary>
			/// 잔여일(영업일)
			/// </summary>
			public const string bjandatecnt = "bjandatecnt";
			/// <summary>
			/// 종목코드
			/// </summary>
			public const string focode = "focode";
			/// <summary>
			/// 실시간가격제한여부(0:대상아님1:적용중2:미적용중3:일시해제)
			/// </summary>
			public const string dy_gubun = "dy_gubun";
			/// <summary>
			/// 실시간상한가
			/// </summary>
			public const string dy_uplmtprice = "dy_uplmtprice";
			/// <summary>
			/// 실시간하한가
			/// </summary>
			public const string dy_dnlmtprice = "dy_dnlmtprice";
			/// <summary>
			/// 가격제한폭확대(0:미확대1:확대2:대상아님)
			/// </summary>
			public const string updnstep_gubun = "updnstep_gubun";
			/// <summary>
			/// 상한적용단계
			/// </summary>
			public const string upstep = "upstep";
			/// <summary>
			/// 하한적용단계
			/// </summary>
			public const string dnstep = "dnstep";
			/// <summary>
			/// 3단계상한가
			/// </summary>
			public const string uplmtprice_3rd = "uplmtprice_3rd";
			/// <summary>
			/// 3단계하한가
			/// </summary>
			public const string dnlmtprice_3rd = "dnlmtprice_3rd";
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
			F.cbhprice,
			F.cblprice,
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
			F.greeks_time,
			F.greeks_confirm,
			F.danhochk,
			F.yeprice,
			F.jnilysign,
			F.jnilychange,
			F.jnilydrate,
			F.alloc_gubun,
			F.bjandatecnt,
			F.focode,
			F.dy_gubun,
			F.dy_uplmtprice,
			F.dy_dnlmtprice,
			F.updnstep_gubun,
			F.upstep,
			F.dnstep,
			F.uplmtprice_3rd,
			F.dnlmtprice_3rd,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["hname"] = new XAQueryFieldInfo("char", hname, hname, "한글명", (decimal)20);
			dict["price"] = new XAQueryFieldInfo("float", price, price.ToString("000000.00"), "현재가", (decimal)6.2);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("float", change, change.ToString("000000.00"), "전일대비", (decimal)6.2);
			dict["jnilclose"] = new XAQueryFieldInfo("float", jnilclose, jnilclose.ToString("000000.00"), "전일종가", (decimal)6.2);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "거래량", (decimal)12);
			dict["value"] = new XAQueryFieldInfo("long", value, value.ToString("d12"), "거래대금", (decimal)12);
			dict["mgjv"] = new XAQueryFieldInfo("long", mgjv, mgjv.ToString("d8"), "미결제량", (decimal)8);
			dict["mgjvdiff"] = new XAQueryFieldInfo("long", mgjvdiff, mgjvdiff.ToString("d8"), "미결제증감", (decimal)8);
			dict["open"] = new XAQueryFieldInfo("float", open, open.ToString("000000.00"), "시가", (decimal)6.2);
			dict["high"] = new XAQueryFieldInfo("float", high, high.ToString("000000.00"), "고가", (decimal)6.2);
			dict["low"] = new XAQueryFieldInfo("float", low, low.ToString("000000.00"), "저가", (decimal)6.2);
			dict["uplmtprice"] = new XAQueryFieldInfo("float", uplmtprice, uplmtprice.ToString("000000.00"), "상한가", (decimal)6.2);
			dict["dnlmtprice"] = new XAQueryFieldInfo("float", dnlmtprice, dnlmtprice.ToString("000000.00"), "하한가", (decimal)6.2);
			dict["high52w"] = new XAQueryFieldInfo("float", high52w, high52w.ToString("000000.00"), "52최고가", (decimal)6.2);
			dict["low52w"] = new XAQueryFieldInfo("float", low52w, low52w.ToString("000000.00"), "52최저가", (decimal)6.2);
			dict["basis"] = new XAQueryFieldInfo("float", basis, basis.ToString("000000.00"), "베이시스", (decimal)6.2);
			dict["recprice"] = new XAQueryFieldInfo("float", recprice, recprice.ToString("000000.00"), "기준가", (decimal)6.2);
			dict["theoryprice"] = new XAQueryFieldInfo("float", theoryprice, theoryprice.ToString("000000.00"), "이론가", (decimal)6.2);
			dict["glyl"] = new XAQueryFieldInfo("float", glyl, glyl.ToString("000000.000"), "괴리율", (decimal)6.3);
			dict["cbhprice"] = new XAQueryFieldInfo("float", cbhprice, cbhprice.ToString("000000.00"), "CB상한가", (decimal)6.2);
			dict["cblprice"] = new XAQueryFieldInfo("float", cblprice, cblprice.ToString("000000.00"), "CB하한가", (decimal)6.2);
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
			dict["listhprice"] = new XAQueryFieldInfo("float", listhprice, listhprice.ToString("000000.00"), "상장최고가", (decimal)6.2);
			dict["listlprice"] = new XAQueryFieldInfo("float", listlprice, listlprice.ToString("000000.00"), "상장최저가", (decimal)6.2);
			dict["delt"] = new XAQueryFieldInfo("float", delt, delt.ToString("000000.0000"), "델타", (decimal)6.4);
			dict["gama"] = new XAQueryFieldInfo("float", gama, gama.ToString("000000.0000"), "감마", (decimal)6.4);
			dict["ceta"] = new XAQueryFieldInfo("float", ceta, ceta.ToString("000000.0000"), "세타", (decimal)6.4);
			dict["vega"] = new XAQueryFieldInfo("float", vega, vega.ToString("000000.0000"), "베가", (decimal)6.4);
			dict["rhox"] = new XAQueryFieldInfo("float", rhox, rhox.ToString("000000.0000"), "로우", (decimal)6.4);
			dict["gmprice"] = new XAQueryFieldInfo("float", gmprice, gmprice.ToString("000000.00"), "근월물현재가", (decimal)6.2);
			dict["gmsign"] = new XAQueryFieldInfo("char", gmsign, gmsign.ToString(), "근월물전일대비구분", (decimal)1);
			dict["gmchange"] = new XAQueryFieldInfo("float", gmchange, gmchange.ToString("000000.00"), "근월물전일대비", (decimal)6.2);
			dict["gmdiff"] = new XAQueryFieldInfo("float", gmdiff, gmdiff.ToString("000000.00"), "근월물등락율", (decimal)6.2);
			dict["theorypriceg"] = new XAQueryFieldInfo("float", theorypriceg, theorypriceg.ToString("000000.00"), "이론가", (decimal)6.2);
			dict["histimpv"] = new XAQueryFieldInfo("float", histimpv, histimpv.ToString("000000.00"), "역사적변동성", (decimal)6.2);
			dict["impv"] = new XAQueryFieldInfo("float", impv, impv.ToString("000000.00"), "내재변동성", (decimal)6.2);
			dict["sbasis"] = new XAQueryFieldInfo("float", sbasis, sbasis.ToString("000000.00"), "시장BASIS", (decimal)6.2);
			dict["ibasis"] = new XAQueryFieldInfo("float", ibasis, ibasis.ToString("000000.00"), "이론BASIS", (decimal)6.2);
			dict["gmfutcode"] = new XAQueryFieldInfo("char", gmfutcode, gmfutcode, "근월물종목코드", (decimal)8);
			dict["actprice"] = new XAQueryFieldInfo("float", actprice, actprice.ToString("000000.00"), "행사가", (decimal)6.2);
			dict["greeks_time"] = new XAQueryFieldInfo("char", greeks_time, greeks_time, "거래소민감도수신시간", (decimal)6);
			dict["greeks_confirm"] = new XAQueryFieldInfo("char", greeks_confirm, greeks_confirm, "거래소민감도확정여부", (decimal)8);
			dict["danhochk"] = new XAQueryFieldInfo("char", danhochk, danhochk.ToString(), "단일가호가여부", (decimal)1);
			dict["yeprice"] = new XAQueryFieldInfo("float", yeprice, yeprice.ToString("000000.00"), "예상체결가", (decimal)6.2);
			dict["jnilysign"] = new XAQueryFieldInfo("char", jnilysign, jnilysign.ToString(), "예상체결가전일종가대비구분", (decimal)1);
			dict["jnilychange"] = new XAQueryFieldInfo("float", jnilychange, jnilychange.ToString("000000.00"), "예상체결가전일종가대비", (decimal)6.2);
			dict["jnilydrate"] = new XAQueryFieldInfo("float", jnilydrate, jnilydrate.ToString("000000.00"), "예상체결가전일종가등락율", (decimal)6.2);
			dict["alloc_gubun"] = new XAQueryFieldInfo("char", alloc_gubun, alloc_gubun.ToString(), "배분구분(1:배분개시2:배분해제0:미발생)", (decimal)1);
			dict["bjandatecnt"] = new XAQueryFieldInfo("long", bjandatecnt, bjandatecnt.ToString("d8"), "잔여일(영업일)", (decimal)8);
			dict["focode"] = new XAQueryFieldInfo("char", focode, focode, "종목코드", (decimal)8);
			dict["dy_gubun"] = new XAQueryFieldInfo("char", dy_gubun, dy_gubun.ToString(), "실시간가격제한여부(0:대상아님1:적용중2:미적용중3:일시해제)", (decimal)1);
			dict["dy_uplmtprice"] = new XAQueryFieldInfo("float", dy_uplmtprice, dy_uplmtprice.ToString("000000.00"), "실시간상한가", (decimal)6.2);
			dict["dy_dnlmtprice"] = new XAQueryFieldInfo("float", dy_dnlmtprice, dy_dnlmtprice.ToString("000000.00"), "실시간하한가", (decimal)6.2);
			dict["updnstep_gubun"] = new XAQueryFieldInfo("char", updnstep_gubun, updnstep_gubun.ToString(), "가격제한폭확대(0:미확대1:확대2:대상아님)", (decimal)1);
			dict["upstep"] = new XAQueryFieldInfo("char", upstep, upstep, "상한적용단계", (decimal)2);
			dict["dnstep"] = new XAQueryFieldInfo("char", dnstep, dnstep, "하한적용단계", (decimal)2);
			dict["uplmtprice_3rd"] = new XAQueryFieldInfo("float", uplmtprice_3rd, uplmtprice_3rd.ToString("000000.00"), "3단계상한가", (decimal)6.2);
			dict["dnlmtprice_3rd"] = new XAQueryFieldInfo("float", dnlmtprice_3rd, dnlmtprice_3rd.ToString("000000.00"), "3단계하한가", (decimal)6.2);

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
					this.price = fieldInfo.FieldValue.ParseFloat("price");
				break;

				case "sign":
					this.sign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "change":
					this.change = fieldInfo.FieldValue.ParseFloat("change");
				break;

				case "jnilclose":
					this.jnilclose = fieldInfo.FieldValue.ParseFloat("jnilclose");
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

				case "mgjv":
					this.mgjv = fieldInfo.FieldValue.ParseLong("mgjv");
				break;

				case "mgjvdiff":
					this.mgjvdiff = fieldInfo.FieldValue.ParseLong("mgjvdiff");
				break;

				case "open":
					this.open = fieldInfo.FieldValue.ParseFloat("open");
				break;

				case "high":
					this.high = fieldInfo.FieldValue.ParseFloat("high");
				break;

				case "low":
					this.low = fieldInfo.FieldValue.ParseFloat("low");
				break;

				case "uplmtprice":
					this.uplmtprice = fieldInfo.FieldValue.ParseFloat("uplmtprice");
				break;

				case "dnlmtprice":
					this.dnlmtprice = fieldInfo.FieldValue.ParseFloat("dnlmtprice");
				break;

				case "high52w":
					this.high52w = fieldInfo.FieldValue.ParseFloat("high52w");
				break;

				case "low52w":
					this.low52w = fieldInfo.FieldValue.ParseFloat("low52w");
				break;

				case "basis":
					this.basis = fieldInfo.FieldValue.ParseFloat("basis");
				break;

				case "recprice":
					this.recprice = fieldInfo.FieldValue.ParseFloat("recprice");
				break;

				case "theoryprice":
					this.theoryprice = fieldInfo.FieldValue.ParseFloat("theoryprice");
				break;

				case "glyl":
					this.glyl = fieldInfo.FieldValue.ParseFloat("glyl");
				break;

				case "cbhprice":
					this.cbhprice = fieldInfo.FieldValue.ParseFloat("cbhprice");
				break;

				case "cblprice":
					this.cblprice = fieldInfo.FieldValue.ParseFloat("cblprice");
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
					this.listhprice = fieldInfo.FieldValue.ParseFloat("listhprice");
				break;

				case "listlprice":
					this.listlprice = fieldInfo.FieldValue.ParseFloat("listlprice");
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
					this.gmprice = fieldInfo.FieldValue.ParseFloat("gmprice");
				break;

				case "gmsign":
					this.gmsign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "gmchange":
					this.gmchange = fieldInfo.FieldValue.ParseFloat("gmchange");
				break;

				case "gmdiff":
					this.gmdiff = fieldInfo.FieldValue.ParseFloat("gmdiff");
				break;

				case "theorypriceg":
					this.theorypriceg = fieldInfo.FieldValue.ParseFloat("theorypriceg");
				break;

				case "histimpv":
					this.histimpv = fieldInfo.FieldValue.ParseFloat("histimpv");
				break;

				case "impv":
					this.impv = fieldInfo.FieldValue.ParseFloat("impv");
				break;

				case "sbasis":
					this.sbasis = fieldInfo.FieldValue.ParseFloat("sbasis");
				break;

				case "ibasis":
					this.ibasis = fieldInfo.FieldValue.ParseFloat("ibasis");
				break;

				case "gmfutcode":
					this.gmfutcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "actprice":
					this.actprice = fieldInfo.FieldValue.ParseFloat("actprice");
				break;

				case "greeks_time":
					this.greeks_time = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "greeks_confirm":
					this.greeks_confirm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "danhochk":
					this.danhochk = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "yeprice":
					this.yeprice = fieldInfo.FieldValue.ParseFloat("yeprice");
				break;

				case "jnilysign":
					this.jnilysign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "jnilychange":
					this.jnilychange = fieldInfo.FieldValue.ParseFloat("jnilychange");
				break;

				case "jnilydrate":
					this.jnilydrate = fieldInfo.FieldValue.ParseFloat("jnilydrate");
				break;

				case "alloc_gubun":
					this.alloc_gubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "bjandatecnt":
					this.bjandatecnt = fieldInfo.FieldValue.ParseLong("bjandatecnt");
				break;

				case "focode":
					this.focode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "dy_gubun":
					this.dy_gubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "dy_uplmtprice":
					this.dy_uplmtprice = fieldInfo.FieldValue.ParseFloat("dy_uplmtprice");
				break;

				case "dy_dnlmtprice":
					this.dy_dnlmtprice = fieldInfo.FieldValue.ParseFloat("dy_dnlmtprice");
				break;

				case "updnstep_gubun":
					this.updnstep_gubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "upstep":
					this.upstep = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "dnstep":
					this.dnstep = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "uplmtprice_3rd":
					this.uplmtprice_3rd = fieldInfo.FieldValue.ParseFloat("uplmtprice_3rd");
				break;

				case "dnlmtprice_3rd":
					this.dnlmtprice_3rd = fieldInfo.FieldValue.ParseFloat("dnlmtprice_3rd");
				break;


			}
		}

		public static XQt2101OutBlock FromQuery(XQt2101 query)
		{
			XQt2101OutBlock block = new XQt2101OutBlock();
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
				block.price = query.GetFieldData(block.GetBlockName(), "price", 0).ParseFloat("price"); // float 6.2
				block.sign = query.GetFieldData(block.GetBlockName(), "sign", 0).FirstOrDefault(); // char 1
				block.change = query.GetFieldData(block.GetBlockName(), "change", 0).ParseFloat("change"); // float 6.2
				block.jnilclose = query.GetFieldData(block.GetBlockName(), "jnilclose", 0).ParseFloat("jnilclose"); // float 6.2
				block.diff = query.GetFieldData(block.GetBlockName(), "diff", 0).ParseFloat("diff"); // float 6.2
				block.volume = query.GetFieldData(block.GetBlockName(), "volume", 0).ParseLong("volume"); // long 12
				block.value = query.GetFieldData(block.GetBlockName(), "value", 0).ParseLong("value"); // long 12
				block.mgjv = query.GetFieldData(block.GetBlockName(), "mgjv", 0).ParseLong("mgjv"); // long 8
				block.mgjvdiff = query.GetFieldData(block.GetBlockName(), "mgjvdiff", 0).ParseLong("mgjvdiff"); // long 8
				block.open = query.GetFieldData(block.GetBlockName(), "open", 0).ParseFloat("open"); // float 6.2
				block.high = query.GetFieldData(block.GetBlockName(), "high", 0).ParseFloat("high"); // float 6.2
				block.low = query.GetFieldData(block.GetBlockName(), "low", 0).ParseFloat("low"); // float 6.2
				block.uplmtprice = query.GetFieldData(block.GetBlockName(), "uplmtprice", 0).ParseFloat("uplmtprice"); // float 6.2
				block.dnlmtprice = query.GetFieldData(block.GetBlockName(), "dnlmtprice", 0).ParseFloat("dnlmtprice"); // float 6.2
				block.high52w = query.GetFieldData(block.GetBlockName(), "high52w", 0).ParseFloat("high52w"); // float 6.2
				block.low52w = query.GetFieldData(block.GetBlockName(), "low52w", 0).ParseFloat("low52w"); // float 6.2
				block.basis = query.GetFieldData(block.GetBlockName(), "basis", 0).ParseFloat("basis"); // float 6.2
				block.recprice = query.GetFieldData(block.GetBlockName(), "recprice", 0).ParseFloat("recprice"); // float 6.2
				block.theoryprice = query.GetFieldData(block.GetBlockName(), "theoryprice", 0).ParseFloat("theoryprice"); // float 6.2
				block.glyl = query.GetFieldData(block.GetBlockName(), "glyl", 0).ParseFloat("glyl"); // float 6.3
				block.cbhprice = query.GetFieldData(block.GetBlockName(), "cbhprice", 0).ParseFloat("cbhprice"); // float 6.2
				block.cblprice = query.GetFieldData(block.GetBlockName(), "cblprice", 0).ParseFloat("cblprice"); // float 6.2
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
				block.listhprice = query.GetFieldData(block.GetBlockName(), "listhprice", 0).ParseFloat("listhprice"); // float 6.2
				block.listlprice = query.GetFieldData(block.GetBlockName(), "listlprice", 0).ParseFloat("listlprice"); // float 6.2
				block.delt = query.GetFieldData(block.GetBlockName(), "delt", 0).ParseFloat("delt"); // float 6.4
				block.gama = query.GetFieldData(block.GetBlockName(), "gama", 0).ParseFloat("gama"); // float 6.4
				block.ceta = query.GetFieldData(block.GetBlockName(), "ceta", 0).ParseFloat("ceta"); // float 6.4
				block.vega = query.GetFieldData(block.GetBlockName(), "vega", 0).ParseFloat("vega"); // float 6.4
				block.rhox = query.GetFieldData(block.GetBlockName(), "rhox", 0).ParseFloat("rhox"); // float 6.4
				block.gmprice = query.GetFieldData(block.GetBlockName(), "gmprice", 0).ParseFloat("gmprice"); // float 6.2
				block.gmsign = query.GetFieldData(block.GetBlockName(), "gmsign", 0).FirstOrDefault(); // char 1
				block.gmchange = query.GetFieldData(block.GetBlockName(), "gmchange", 0).ParseFloat("gmchange"); // float 6.2
				block.gmdiff = query.GetFieldData(block.GetBlockName(), "gmdiff", 0).ParseFloat("gmdiff"); // float 6.2
				block.theorypriceg = query.GetFieldData(block.GetBlockName(), "theorypriceg", 0).ParseFloat("theorypriceg"); // float 6.2
				block.histimpv = query.GetFieldData(block.GetBlockName(), "histimpv", 0).ParseFloat("histimpv"); // float 6.2
				block.impv = query.GetFieldData(block.GetBlockName(), "impv", 0).ParseFloat("impv"); // float 6.2
				block.sbasis = query.GetFieldData(block.GetBlockName(), "sbasis", 0).ParseFloat("sbasis"); // float 6.2
				block.ibasis = query.GetFieldData(block.GetBlockName(), "ibasis", 0).ParseFloat("ibasis"); // float 6.2
				block.gmfutcode = query.GetFieldData(block.GetBlockName(), "gmfutcode", 0).TrimEnd('?'); // char 8
				block.actprice = query.GetFieldData(block.GetBlockName(), "actprice", 0).ParseFloat("actprice"); // float 6.2
				block.greeks_time = query.GetFieldData(block.GetBlockName(), "greeks_time", 0).TrimEnd('?'); // char 6
				block.greeks_confirm = query.GetFieldData(block.GetBlockName(), "greeks_confirm", 0).TrimEnd('?'); // char 8
				block.danhochk = query.GetFieldData(block.GetBlockName(), "danhochk", 0).FirstOrDefault(); // char 1
				block.yeprice = query.GetFieldData(block.GetBlockName(), "yeprice", 0).ParseFloat("yeprice"); // float 6.2
				block.jnilysign = query.GetFieldData(block.GetBlockName(), "jnilysign", 0).FirstOrDefault(); // char 1
				block.jnilychange = query.GetFieldData(block.GetBlockName(), "jnilychange", 0).ParseFloat("jnilychange"); // float 6.2
				block.jnilydrate = query.GetFieldData(block.GetBlockName(), "jnilydrate", 0).ParseFloat("jnilydrate"); // float 6.2
				block.alloc_gubun = query.GetFieldData(block.GetBlockName(), "alloc_gubun", 0).FirstOrDefault(); // char 1
				block.bjandatecnt = query.GetFieldData(block.GetBlockName(), "bjandatecnt", 0).ParseLong("bjandatecnt"); // long 8
				block.focode = query.GetFieldData(block.GetBlockName(), "focode", 0).TrimEnd('?'); // char 8
				block.dy_gubun = query.GetFieldData(block.GetBlockName(), "dy_gubun", 0).FirstOrDefault(); // char 1
				block.dy_uplmtprice = query.GetFieldData(block.GetBlockName(), "dy_uplmtprice", 0).ParseFloat("dy_uplmtprice"); // float 6.2
				block.dy_dnlmtprice = query.GetFieldData(block.GetBlockName(), "dy_dnlmtprice", 0).ParseFloat("dy_dnlmtprice"); // float 6.2
				block.updnstep_gubun = query.GetFieldData(block.GetBlockName(), "updnstep_gubun", 0).FirstOrDefault(); // char 1
				block.upstep = query.GetFieldData(block.GetBlockName(), "upstep", 0).TrimEnd('?'); // char 2
				block.dnstep = query.GetFieldData(block.GetBlockName(), "dnstep", 0).TrimEnd('?'); // char 2
				block.uplmtprice_3rd = query.GetFieldData(block.GetBlockName(), "uplmtprice_3rd", 0).ParseFloat("uplmtprice_3rd"); // float 6.2
				block.dnlmtprice_3rd = query.GetFieldData(block.GetBlockName(), "dnlmtprice_3rd", 0).ParseFloat("dnlmtprice_3rd"); // float 6.2

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (hname?.Length > 20) return false; // char 20
			// price float 6.2
			// sign char 1
			// change float 6.2
			// jnilclose float 6.2
			// diff float 6.2
			if (volume.ToString().Length > 12) return false; // long 12
			if (value.ToString().Length > 12) return false; // long 12
			if (mgjv.ToString().Length > 8) return false; // long 8
			if (mgjvdiff.ToString().Length > 8) return false; // long 8
			// open float 6.2
			// high float 6.2
			// low float 6.2
			// uplmtprice float 6.2
			// dnlmtprice float 6.2
			// high52w float 6.2
			// low52w float 6.2
			// basis float 6.2
			// recprice float 6.2
			// theoryprice float 6.2
			// glyl float 6.3
			// cbhprice float 6.2
			// cblprice float 6.2
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
			// listhprice float 6.2
			// listlprice float 6.2
			// delt float 6.4
			// gama float 6.4
			// ceta float 6.4
			// vega float 6.4
			// rhox float 6.4
			// gmprice float 6.2
			// gmsign char 1
			// gmchange float 6.2
			// gmdiff float 6.2
			// theorypriceg float 6.2
			// histimpv float 6.2
			// impv float 6.2
			// sbasis float 6.2
			// ibasis float 6.2
			if (gmfutcode?.Length > 8) return false; // char 8
			// actprice float 6.2
			if (greeks_time?.Length > 6) return false; // char 6
			if (greeks_confirm?.Length > 8) return false; // char 8
			// danhochk char 1
			// yeprice float 6.2
			// jnilysign char 1
			// jnilychange float 6.2
			// jnilydrate float 6.2
			// alloc_gubun char 1
			if (bjandatecnt.ToString().Length > 8) return false; // long 8
			if (focode?.Length > 8) return false; // char 8
			// dy_gubun char 1
			// dy_uplmtprice float 6.2
			// dy_dnlmtprice float 6.2
			// updnstep_gubun char 1
			if (upstep?.Length > 2) return false; // char 2
			if (dnstep?.Length > 2) return false; // char 2
			// uplmtprice_3rd float 6.2
			// dnlmtprice_3rd float 6.2

			return true;
		}
	}

	public partial class XQt2101 : XingQuery
	{
		/// <summary>
		/// t2101
		/// </summary>
		public const string _typeName = "t2101";
		/// <summary>
		/// 선물/옵션현재가(시세)조회(t2101)
		/// </summary>
		public const string _typeDesc = "선물/옵션현재가(시세)조회(t2101)";
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
		/// t2101
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 선물/옵션현재가(시세)조회(t2101)
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

		public XQt2101() : base("t2101") { }


		public static XQt2101OutBlock Get(string focode = default)
		{
			using (XQt2101 instance = new XQt2101())
			{
				instance.SetFieldData(XQt2101InBlock.BlockName, XQt2101InBlock.F.focode, 0, focode); // char 8

				if (instance.Request() < 0)
				{
					return null;
				}

				var outBlock = instance.GetBlock();
				if (outBlock.IsValidData == false)
				{
					return null;
				}
				return outBlock;
			}
		}

		public bool SetBlock(XQt2101InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "focode", 0, block.focode); // char 8

			return true;
		}

		public XQt2101OutBlock GetBlock()
		{
			XQt2101OutBlock instance = XQt2101OutBlock.FromQuery(this);
			return instance;

		}


	}

}
