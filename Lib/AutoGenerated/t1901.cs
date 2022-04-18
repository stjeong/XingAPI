using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1901InBlock : XingBlock
	{
		/// <summary>
		/// t1901InBlock
		/// </summary>
		public const string _blockName = "t1901InBlock";
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
		/// t1901InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1901InBlock
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

		public static class F
		{
			/// <summary>
			/// 단축코드
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
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)6);

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

	public partial class XQt1901OutBlock : XingBlock
	{
		/// <summary>
		/// t1901OutBlock
		/// </summary>
		public const string _blockName = "t1901OutBlock";
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
		/// t1901OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1901OutBlock
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
		[XAQueryFieldAttribute("hname", "한글명", "char", "20")]
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
		[XAQueryFieldAttribute("volume", "누적거래량", "float", "12")]
		public float volume;
		/// <summary>
		/// 기준가
		/// </summary>
		[XAQueryFieldAttribute("recprice", "기준가", "long", "8")]
		public long recprice;
		/// <summary>
		/// 가중평균
		/// </summary>
		[XAQueryFieldAttribute("avg", "가중평균", "long", "8")]
		public long avg;
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
		/// <summary>
		/// 전일거래량
		/// </summary>
		[XAQueryFieldAttribute("jnilvolume", "전일거래량", "float", "12")]
		public float jnilvolume;
		/// <summary>
		/// 거래량차
		/// </summary>
		[XAQueryFieldAttribute("volumediff", "거래량차", "long", "12")]
		public long volumediff;
		/// <summary>
		/// 시가
		/// </summary>
		[XAQueryFieldAttribute("open", "시가", "long", "8")]
		public long open;
		/// <summary>
		/// 시가시간
		/// </summary>
		[XAQueryFieldAttribute("opentime", "시가시간", "char", "6")]
		public string opentime;
		/// <summary>
		/// 고가
		/// </summary>
		[XAQueryFieldAttribute("high", "고가", "long", "8")]
		public long high;
		/// <summary>
		/// 고가시간
		/// </summary>
		[XAQueryFieldAttribute("hightime", "고가시간", "char", "6")]
		public string hightime;
		/// <summary>
		/// 저가
		/// </summary>
		[XAQueryFieldAttribute("low", "저가", "long", "8")]
		public long low;
		/// <summary>
		/// 저가시간
		/// </summary>
		[XAQueryFieldAttribute("lowtime", "저가시간", "char", "6")]
		public string lowtime;
		/// <summary>
		/// 52최고가
		/// </summary>
		[XAQueryFieldAttribute("high52w", "52최고가", "long", "8")]
		public long high52w;
		/// <summary>
		/// 52최고가일
		/// </summary>
		[XAQueryFieldAttribute("high52wdate", "52최고가일", "char", "8")]
		public string high52wdate;
		/// <summary>
		/// 52최저가
		/// </summary>
		[XAQueryFieldAttribute("low52w", "52최저가", "long", "8")]
		public long low52w;
		/// <summary>
		/// 52최저가일
		/// </summary>
		[XAQueryFieldAttribute("low52wdate", "52최저가일", "char", "8")]
		public string low52wdate;
		/// <summary>
		/// 소진율
		/// </summary>
		[XAQueryFieldAttribute("exhratio", "소진율", "float", "6.2")]
		public float exhratio;
		/// <summary>
		/// 외국인보유수량
		/// </summary>
		[XAQueryFieldAttribute("flmtvol", "외국인보유수량", "float", "12")]
		public float flmtvol;
		/// <summary>
		/// PER
		/// </summary>
		[XAQueryFieldAttribute("per", "PER", "float", "6.2")]
		public float per;
		/// <summary>
		/// 상장주식수(천)
		/// </summary>
		[XAQueryFieldAttribute("listing", "상장주식수(천)", "long", "12")]
		public long listing;
		/// <summary>
		/// 증거금율
		/// </summary>
		[XAQueryFieldAttribute("jkrate", "증거금율", "long", "8")]
		public long jkrate;
		/// <summary>
		/// 회전율
		/// </summary>
		[XAQueryFieldAttribute("vol", "회전율", "float", "6.2")]
		public float vol;
		/// <summary>
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("shcode", "단축코드", "char", "6")]
		public string shcode;
		/// <summary>
		/// 누적거래대금
		/// </summary>
		[XAQueryFieldAttribute("value", "누적거래대금", "long", "12")]
		public long value;
		/// <summary>
		/// 연중최고가
		/// </summary>
		[XAQueryFieldAttribute("highyear", "연중최고가", "long", "8")]
		public long highyear;
		/// <summary>
		/// 연중최고일자
		/// </summary>
		[XAQueryFieldAttribute("highyeardate", "연중최고일자", "char", "8")]
		public string highyeardate;
		/// <summary>
		/// 연중최저가
		/// </summary>
		[XAQueryFieldAttribute("lowyear", "연중최저가", "long", "8")]
		public long lowyear;
		/// <summary>
		/// 연중최저일자
		/// </summary>
		[XAQueryFieldAttribute("lowyeardate", "연중최저일자", "char", "8")]
		public string lowyeardate;
		/// <summary>
		/// 업종명
		/// </summary>
		[XAQueryFieldAttribute("upname", "업종명", "char", "20")]
		public string upname;
		/// <summary>
		/// 업종코드
		/// </summary>
		[XAQueryFieldAttribute("upcode", "업종코드", "char", "3")]
		public string upcode;
		/// <summary>
		/// 업종현재가
		/// </summary>
		[XAQueryFieldAttribute("upprice", "업종현재가", "float", "7.2")]
		public float upprice;
		/// <summary>
		/// 업종전일비구분
		/// </summary>
		[XAQueryFieldAttribute("upsign", "업종전일비구분", "char", "1")]
		public char upsign;
		/// <summary>
		/// 업종전일대비
		/// </summary>
		[XAQueryFieldAttribute("upchange", "업종전일대비", "float", "6.2")]
		public float upchange;
		/// <summary>
		/// 업종등락율
		/// </summary>
		[XAQueryFieldAttribute("updiff", "업종등락율", "float", "6.2")]
		public float updiff;
		/// <summary>
		/// 선물최근월물명
		/// </summary>
		[XAQueryFieldAttribute("futname", "선물최근월물명", "char", "20")]
		public string futname;
		/// <summary>
		/// 선물최근월물코드
		/// </summary>
		[XAQueryFieldAttribute("futcode", "선물최근월물코드", "char", "8")]
		public string futcode;
		/// <summary>
		/// 선물현재가
		/// </summary>
		[XAQueryFieldAttribute("futprice", "선물현재가", "float", "6.2")]
		public float futprice;
		/// <summary>
		/// 선물전일비구분
		/// </summary>
		[XAQueryFieldAttribute("futsign", "선물전일비구분", "char", "1")]
		public char futsign;
		/// <summary>
		/// 선물전일대비
		/// </summary>
		[XAQueryFieldAttribute("futchange", "선물전일대비", "float", "6.2")]
		public float futchange;
		/// <summary>
		/// 선물등락율
		/// </summary>
		[XAQueryFieldAttribute("futdiff", "선물등락율", "float", "6.2")]
		public float futdiff;
		/// <summary>
		/// NAV
		/// </summary>
		[XAQueryFieldAttribute("nav", "NAV", "float", "8.2")]
		public float nav;
		/// <summary>
		/// NAV전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("navsign", "NAV전일대비구분", "char", "1")]
		public char navsign;
		/// <summary>
		/// NAV전일대비
		/// </summary>
		[XAQueryFieldAttribute("navchange", "NAV전일대비", "float", "8.2")]
		public float navchange;
		/// <summary>
		/// NAV등락율
		/// </summary>
		[XAQueryFieldAttribute("navdiff", "NAV등락율", "float", "6.2")]
		public float navdiff;
		/// <summary>
		/// 추적오차율
		/// </summary>
		[XAQueryFieldAttribute("cocrate", "추적오차율", "float", "6.2")]
		public float cocrate;
		/// <summary>
		/// 괴리율
		/// </summary>
		[XAQueryFieldAttribute("kasis", "괴리율", "float", "6.2")]
		public float kasis;
		/// <summary>
		/// 대용가
		/// </summary>
		[XAQueryFieldAttribute("subprice", "대용가", "long", "10")]
		public long subprice;
		/// <summary>
		/// 매도증권사코드1
		/// </summary>
		[XAQueryFieldAttribute("offerno1", "매도증권사코드1", "char", "6")]
		public string offerno1;
		/// <summary>
		/// 매수증권사코드1
		/// </summary>
		[XAQueryFieldAttribute("bidno1", "매수증권사코드1", "char", "6")]
		public string bidno1;
		/// <summary>
		/// 총매도수량1
		/// </summary>
		[XAQueryFieldAttribute("dvol1", "총매도수량1", "long", "8")]
		public long dvol1;
		/// <summary>
		/// 총매수수량1
		/// </summary>
		[XAQueryFieldAttribute("svol1", "총매수수량1", "long", "8")]
		public long svol1;
		/// <summary>
		/// 매도증감1
		/// </summary>
		[XAQueryFieldAttribute("dcha1", "매도증감1", "long", "8")]
		public long dcha1;
		/// <summary>
		/// 매수증감1
		/// </summary>
		[XAQueryFieldAttribute("scha1", "매수증감1", "long", "8")]
		public long scha1;
		/// <summary>
		/// 매도비율1
		/// </summary>
		[XAQueryFieldAttribute("ddiff1", "매도비율1", "float", "6.2")]
		public float ddiff1;
		/// <summary>
		/// 매수비율1
		/// </summary>
		[XAQueryFieldAttribute("sdiff1", "매수비율1", "float", "6.2")]
		public float sdiff1;
		/// <summary>
		/// 매도증권사코드2
		/// </summary>
		[XAQueryFieldAttribute("offerno2", "매도증권사코드2", "char", "6")]
		public string offerno2;
		/// <summary>
		/// 매수증권사코드2
		/// </summary>
		[XAQueryFieldAttribute("bidno2", "매수증권사코드2", "char", "6")]
		public string bidno2;
		/// <summary>
		/// 총매도수량2
		/// </summary>
		[XAQueryFieldAttribute("dvol2", "총매도수량2", "long", "8")]
		public long dvol2;
		/// <summary>
		/// 총매수수량2
		/// </summary>
		[XAQueryFieldAttribute("svol2", "총매수수량2", "long", "8")]
		public long svol2;
		/// <summary>
		/// 매도증감2
		/// </summary>
		[XAQueryFieldAttribute("dcha2", "매도증감2", "long", "8")]
		public long dcha2;
		/// <summary>
		/// 매수증감2
		/// </summary>
		[XAQueryFieldAttribute("scha2", "매수증감2", "long", "8")]
		public long scha2;
		/// <summary>
		/// 매도비율2
		/// </summary>
		[XAQueryFieldAttribute("ddiff2", "매도비율2", "float", "6.2")]
		public float ddiff2;
		/// <summary>
		/// 매수비율2
		/// </summary>
		[XAQueryFieldAttribute("sdiff2", "매수비율2", "float", "6.2")]
		public float sdiff2;
		/// <summary>
		/// 매도증권사코드3
		/// </summary>
		[XAQueryFieldAttribute("offerno3", "매도증권사코드3", "char", "6")]
		public string offerno3;
		/// <summary>
		/// 매수증권사코드3
		/// </summary>
		[XAQueryFieldAttribute("bidno3", "매수증권사코드3", "char", "6")]
		public string bidno3;
		/// <summary>
		/// 총매도수량3
		/// </summary>
		[XAQueryFieldAttribute("dvol3", "총매도수량3", "long", "8")]
		public long dvol3;
		/// <summary>
		/// 총매수수량3
		/// </summary>
		[XAQueryFieldAttribute("svol3", "총매수수량3", "long", "8")]
		public long svol3;
		/// <summary>
		/// 매도증감3
		/// </summary>
		[XAQueryFieldAttribute("dcha3", "매도증감3", "long", "8")]
		public long dcha3;
		/// <summary>
		/// 매수증감3
		/// </summary>
		[XAQueryFieldAttribute("scha3", "매수증감3", "long", "8")]
		public long scha3;
		/// <summary>
		/// 매도비율3
		/// </summary>
		[XAQueryFieldAttribute("ddiff3", "매도비율3", "float", "6.2")]
		public float ddiff3;
		/// <summary>
		/// 매수비율3
		/// </summary>
		[XAQueryFieldAttribute("sdiff3", "매수비율3", "float", "6.2")]
		public float sdiff3;
		/// <summary>
		/// 매도증권사코드4
		/// </summary>
		[XAQueryFieldAttribute("offerno4", "매도증권사코드4", "char", "6")]
		public string offerno4;
		/// <summary>
		/// 매수증권사코드4
		/// </summary>
		[XAQueryFieldAttribute("bidno4", "매수증권사코드4", "char", "6")]
		public string bidno4;
		/// <summary>
		/// 총매도수량4
		/// </summary>
		[XAQueryFieldAttribute("dvol4", "총매도수량4", "long", "8")]
		public long dvol4;
		/// <summary>
		/// 총매수수량4
		/// </summary>
		[XAQueryFieldAttribute("svol4", "총매수수량4", "long", "8")]
		public long svol4;
		/// <summary>
		/// 매도증감4
		/// </summary>
		[XAQueryFieldAttribute("dcha4", "매도증감4", "long", "8")]
		public long dcha4;
		/// <summary>
		/// 매수증감4
		/// </summary>
		[XAQueryFieldAttribute("scha4", "매수증감4", "long", "8")]
		public long scha4;
		/// <summary>
		/// 매도비율4
		/// </summary>
		[XAQueryFieldAttribute("ddiff4", "매도비율4", "float", "6.2")]
		public float ddiff4;
		/// <summary>
		/// 매수비율4
		/// </summary>
		[XAQueryFieldAttribute("sdiff4", "매수비율4", "float", "6.2")]
		public float sdiff4;
		/// <summary>
		/// 매도증권사코드5
		/// </summary>
		[XAQueryFieldAttribute("offerno5", "매도증권사코드5", "char", "6")]
		public string offerno5;
		/// <summary>
		/// 매수증권사코드5
		/// </summary>
		[XAQueryFieldAttribute("bidno5", "매수증권사코드5", "char", "6")]
		public string bidno5;
		/// <summary>
		/// 총매도수량5
		/// </summary>
		[XAQueryFieldAttribute("dvol5", "총매도수량5", "long", "8")]
		public long dvol5;
		/// <summary>
		/// 총매수수량5
		/// </summary>
		[XAQueryFieldAttribute("svol5", "총매수수량5", "long", "8")]
		public long svol5;
		/// <summary>
		/// 매도증감5
		/// </summary>
		[XAQueryFieldAttribute("dcha5", "매도증감5", "long", "8")]
		public long dcha5;
		/// <summary>
		/// 매수증감5
		/// </summary>
		[XAQueryFieldAttribute("scha5", "매수증감5", "long", "8")]
		public long scha5;
		/// <summary>
		/// 매도비율5
		/// </summary>
		[XAQueryFieldAttribute("ddiff5", "매도비율5", "float", "6.2")]
		public float ddiff5;
		/// <summary>
		/// 매수비율5
		/// </summary>
		[XAQueryFieldAttribute("sdiff5", "매수비율5", "float", "6.2")]
		public float sdiff5;
		/// <summary>
		/// 외국계매도합계수량
		/// </summary>
		[XAQueryFieldAttribute("fwdvl", "외국계매도합계수량", "long", "12")]
		public long fwdvl;
		/// <summary>
		/// 외국계매도직전대비
		/// </summary>
		[XAQueryFieldAttribute("ftradmdcha", "외국계매도직전대비", "long", "12")]
		public long ftradmdcha;
		/// <summary>
		/// 외국계매도비율
		/// </summary>
		[XAQueryFieldAttribute("ftradmddiff", "외국계매도비율", "float", "6.2")]
		public float ftradmddiff;
		/// <summary>
		/// 외국계매수합계수량
		/// </summary>
		[XAQueryFieldAttribute("fwsvl", "외국계매수합계수량", "long", "12")]
		public long fwsvl;
		/// <summary>
		/// 외국계매수직전대비
		/// </summary>
		[XAQueryFieldAttribute("ftradmscha", "외국계매수직전대비", "long", "12")]
		public long ftradmscha;
		/// <summary>
		/// 외국계매수비율
		/// </summary>
		[XAQueryFieldAttribute("ftradmsdiff", "외국계매수비율", "float", "6.2")]
		public float ftradmsdiff;
		/// <summary>
		/// 참고지수명
		/// </summary>
		[XAQueryFieldAttribute("upname2", "참고지수명", "char", "20")]
		public string upname2;
		/// <summary>
		/// 참고지수코드
		/// </summary>
		[XAQueryFieldAttribute("upcode2", "참고지수코드", "char", "3")]
		public string upcode2;
		/// <summary>
		/// 참고지수현재가
		/// </summary>
		[XAQueryFieldAttribute("upprice2", "참고지수현재가", "float", "7.2")]
		public float upprice2;
		/// <summary>
		/// 전일NAV
		/// </summary>
		[XAQueryFieldAttribute("jnilnav", "전일NAV", "float", "8.2")]
		public float jnilnav;
		/// <summary>
		/// 전일NAV전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("jnilnavsign", "전일NAV전일대비구분", "char", "1")]
		public char jnilnavsign;
		/// <summary>
		/// 전일NAV전일대비
		/// </summary>
		[XAQueryFieldAttribute("jnilnavchange", "전일NAV전일대비", "float", "8.2")]
		public float jnilnavchange;
		/// <summary>
		/// 전일NAV등락율
		/// </summary>
		[XAQueryFieldAttribute("jnilnavdiff", "전일NAV등락율", "float", "6.2")]
		public float jnilnavdiff;
		/// <summary>
		/// 순자산총액(억원)
		/// </summary>
		[XAQueryFieldAttribute("etftotcap", "순자산총액(억원)", "long", "12")]
		public long etftotcap;
		/// <summary>
		/// 스프레드
		/// </summary>
		[XAQueryFieldAttribute("spread", "스프레드", "float", "6.2")]
		public float spread;
		/// <summary>
		/// 레버리지
		/// </summary>
		[XAQueryFieldAttribute("leverage", "레버리지", "long", "2")]
		public long leverage;
		/// <summary>
		/// 과세구분
		/// </summary>
		[XAQueryFieldAttribute("taxgubun", "과세구분", "char", "1")]
		public char taxgubun;
		/// <summary>
		/// 운용사
		/// </summary>
		[XAQueryFieldAttribute("opcom_nmk", "운용사", "char", "20")]
		public string opcom_nmk;
		/// <summary>
		/// LP1
		/// </summary>
		[XAQueryFieldAttribute("lp_nm1", "LP1", "char", "20")]
		public string lp_nm1;
		/// <summary>
		/// LP2
		/// </summary>
		[XAQueryFieldAttribute("lp_nm2", "LP2", "char", "20")]
		public string lp_nm2;
		/// <summary>
		/// LP3
		/// </summary>
		[XAQueryFieldAttribute("lp_nm3", "LP3", "char", "20")]
		public string lp_nm3;
		/// <summary>
		/// LP4
		/// </summary>
		[XAQueryFieldAttribute("lp_nm4", "LP4", "char", "20")]
		public string lp_nm4;
		/// <summary>
		/// LP5
		/// </summary>
		[XAQueryFieldAttribute("lp_nm5", "LP5", "char", "20")]
		public string lp_nm5;
		/// <summary>
		/// 복제방법
		/// </summary>
		[XAQueryFieldAttribute("etf_cp", "복제방법", "char", "10")]
		public string etf_cp;
		/// <summary>
		/// 상품유형(Filler)
		/// </summary>
		[XAQueryFieldAttribute("etf_kind", "상품유형(Filler)", "char", "10")]
		public string etf_kind;
		/// <summary>
		/// VI발동해제
		/// </summary>
		[XAQueryFieldAttribute("vi_gubun", "VI발동해제", "char", "10")]
		public string vi_gubun;
		/// <summary>
		/// ETN상품분류
		/// </summary>
		[XAQueryFieldAttribute("etn_kind_cd", "ETN상품분류", "char", "20")]
		public string etn_kind_cd;
		/// <summary>
		/// ETN만기일
		/// </summary>
		[XAQueryFieldAttribute("lastymd", "ETN만기일", "char", "8")]
		public string lastymd;
		/// <summary>
		/// ETN지급일
		/// </summary>
		[XAQueryFieldAttribute("payday", "ETN지급일", "char", "8")]
		public string payday;
		/// <summary>
		/// ETN최종거래일
		/// </summary>
		[XAQueryFieldAttribute("lastdate", "ETN최종거래일", "char", "8")]
		public string lastdate;
		/// <summary>
		/// ETN발행시장참가자
		/// </summary>
		[XAQueryFieldAttribute("issuernmk", "ETN발행시장참가자", "char", "20")]
		public string issuernmk;
		/// <summary>
		/// ETN만기상환가격결정시작일
		/// </summary>
		[XAQueryFieldAttribute("last_sdate", "ETN만기상환가격결정시작일", "char", "8")]
		public string last_sdate;
		/// <summary>
		/// ETN만기상환가격결정종료일
		/// </summary>
		[XAQueryFieldAttribute("last_edate", "ETN만기상환가격결정종료일", "char", "8")]
		public string last_edate;
		/// <summary>
		/// ETNLP보유수량
		/// </summary>
		[XAQueryFieldAttribute("lp_holdvol", "ETNLP보유수량", "char", "12")]
		public string lp_holdvol;
		/// <summary>
		/// 상장일
		/// </summary>
		[XAQueryFieldAttribute("listdate", "상장일", "char", "8")]
		public string listdate;
		/// <summary>
		/// ETP상품구분코드
		/// </summary>
		[XAQueryFieldAttribute("etp_gb", "ETP상품구분코드", "char", "1")]
		public char etp_gb;
		/// <summary>
		/// ETN조기상환가능여부
		/// </summary>
		[XAQueryFieldAttribute("etn_elback_yn", "ETN조기상환가능여부", "char", "1")]
		public char etn_elback_yn;
		/// <summary>
		/// 최종결제
		/// </summary>
		[XAQueryFieldAttribute("settletype", "최종결제", "char", "2")]
		public string settletype;
		/// <summary>
		/// 지수자산분류코드(대분류)
		/// </summary>
		[XAQueryFieldAttribute("idx_asset_class1", "지수자산분류코드(대분류)", "char", "2")]
		public string idx_asset_class1;
		/// <summary>
		/// ETF/ETN투자유의
		/// </summary>
		[XAQueryFieldAttribute("ty_text", "ETF/ETN투자유의", "char", "8")]
		public string ty_text;

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
			/// 등락율
			/// </summary>
			public const string diff = "diff";
			/// <summary>
			/// 누적거래량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// 기준가
			/// </summary>
			public const string recprice = "recprice";
			/// <summary>
			/// 가중평균
			/// </summary>
			public const string avg = "avg";
			/// <summary>
			/// 상한가
			/// </summary>
			public const string uplmtprice = "uplmtprice";
			/// <summary>
			/// 하한가
			/// </summary>
			public const string dnlmtprice = "dnlmtprice";
			/// <summary>
			/// 전일거래량
			/// </summary>
			public const string jnilvolume = "jnilvolume";
			/// <summary>
			/// 거래량차
			/// </summary>
			public const string volumediff = "volumediff";
			/// <summary>
			/// 시가
			/// </summary>
			public const string open = "open";
			/// <summary>
			/// 시가시간
			/// </summary>
			public const string opentime = "opentime";
			/// <summary>
			/// 고가
			/// </summary>
			public const string high = "high";
			/// <summary>
			/// 고가시간
			/// </summary>
			public const string hightime = "hightime";
			/// <summary>
			/// 저가
			/// </summary>
			public const string low = "low";
			/// <summary>
			/// 저가시간
			/// </summary>
			public const string lowtime = "lowtime";
			/// <summary>
			/// 52최고가
			/// </summary>
			public const string high52w = "high52w";
			/// <summary>
			/// 52최고가일
			/// </summary>
			public const string high52wdate = "high52wdate";
			/// <summary>
			/// 52최저가
			/// </summary>
			public const string low52w = "low52w";
			/// <summary>
			/// 52최저가일
			/// </summary>
			public const string low52wdate = "low52wdate";
			/// <summary>
			/// 소진율
			/// </summary>
			public const string exhratio = "exhratio";
			/// <summary>
			/// 외국인보유수량
			/// </summary>
			public const string flmtvol = "flmtvol";
			/// <summary>
			/// PER
			/// </summary>
			public const string per = "per";
			/// <summary>
			/// 상장주식수(천)
			/// </summary>
			public const string listing = "listing";
			/// <summary>
			/// 증거금율
			/// </summary>
			public const string jkrate = "jkrate";
			/// <summary>
			/// 회전율
			/// </summary>
			public const string vol = "vol";
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 누적거래대금
			/// </summary>
			public const string value = "value";
			/// <summary>
			/// 연중최고가
			/// </summary>
			public const string highyear = "highyear";
			/// <summary>
			/// 연중최고일자
			/// </summary>
			public const string highyeardate = "highyeardate";
			/// <summary>
			/// 연중최저가
			/// </summary>
			public const string lowyear = "lowyear";
			/// <summary>
			/// 연중최저일자
			/// </summary>
			public const string lowyeardate = "lowyeardate";
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
			/// 추적오차율
			/// </summary>
			public const string cocrate = "cocrate";
			/// <summary>
			/// 괴리율
			/// </summary>
			public const string kasis = "kasis";
			/// <summary>
			/// 대용가
			/// </summary>
			public const string subprice = "subprice";
			/// <summary>
			/// 매도증권사코드1
			/// </summary>
			public const string offerno1 = "offerno1";
			/// <summary>
			/// 매수증권사코드1
			/// </summary>
			public const string bidno1 = "bidno1";
			/// <summary>
			/// 총매도수량1
			/// </summary>
			public const string dvol1 = "dvol1";
			/// <summary>
			/// 총매수수량1
			/// </summary>
			public const string svol1 = "svol1";
			/// <summary>
			/// 매도증감1
			/// </summary>
			public const string dcha1 = "dcha1";
			/// <summary>
			/// 매수증감1
			/// </summary>
			public const string scha1 = "scha1";
			/// <summary>
			/// 매도비율1
			/// </summary>
			public const string ddiff1 = "ddiff1";
			/// <summary>
			/// 매수비율1
			/// </summary>
			public const string sdiff1 = "sdiff1";
			/// <summary>
			/// 매도증권사코드2
			/// </summary>
			public const string offerno2 = "offerno2";
			/// <summary>
			/// 매수증권사코드2
			/// </summary>
			public const string bidno2 = "bidno2";
			/// <summary>
			/// 총매도수량2
			/// </summary>
			public const string dvol2 = "dvol2";
			/// <summary>
			/// 총매수수량2
			/// </summary>
			public const string svol2 = "svol2";
			/// <summary>
			/// 매도증감2
			/// </summary>
			public const string dcha2 = "dcha2";
			/// <summary>
			/// 매수증감2
			/// </summary>
			public const string scha2 = "scha2";
			/// <summary>
			/// 매도비율2
			/// </summary>
			public const string ddiff2 = "ddiff2";
			/// <summary>
			/// 매수비율2
			/// </summary>
			public const string sdiff2 = "sdiff2";
			/// <summary>
			/// 매도증권사코드3
			/// </summary>
			public const string offerno3 = "offerno3";
			/// <summary>
			/// 매수증권사코드3
			/// </summary>
			public const string bidno3 = "bidno3";
			/// <summary>
			/// 총매도수량3
			/// </summary>
			public const string dvol3 = "dvol3";
			/// <summary>
			/// 총매수수량3
			/// </summary>
			public const string svol3 = "svol3";
			/// <summary>
			/// 매도증감3
			/// </summary>
			public const string dcha3 = "dcha3";
			/// <summary>
			/// 매수증감3
			/// </summary>
			public const string scha3 = "scha3";
			/// <summary>
			/// 매도비율3
			/// </summary>
			public const string ddiff3 = "ddiff3";
			/// <summary>
			/// 매수비율3
			/// </summary>
			public const string sdiff3 = "sdiff3";
			/// <summary>
			/// 매도증권사코드4
			/// </summary>
			public const string offerno4 = "offerno4";
			/// <summary>
			/// 매수증권사코드4
			/// </summary>
			public const string bidno4 = "bidno4";
			/// <summary>
			/// 총매도수량4
			/// </summary>
			public const string dvol4 = "dvol4";
			/// <summary>
			/// 총매수수량4
			/// </summary>
			public const string svol4 = "svol4";
			/// <summary>
			/// 매도증감4
			/// </summary>
			public const string dcha4 = "dcha4";
			/// <summary>
			/// 매수증감4
			/// </summary>
			public const string scha4 = "scha4";
			/// <summary>
			/// 매도비율4
			/// </summary>
			public const string ddiff4 = "ddiff4";
			/// <summary>
			/// 매수비율4
			/// </summary>
			public const string sdiff4 = "sdiff4";
			/// <summary>
			/// 매도증권사코드5
			/// </summary>
			public const string offerno5 = "offerno5";
			/// <summary>
			/// 매수증권사코드5
			/// </summary>
			public const string bidno5 = "bidno5";
			/// <summary>
			/// 총매도수량5
			/// </summary>
			public const string dvol5 = "dvol5";
			/// <summary>
			/// 총매수수량5
			/// </summary>
			public const string svol5 = "svol5";
			/// <summary>
			/// 매도증감5
			/// </summary>
			public const string dcha5 = "dcha5";
			/// <summary>
			/// 매수증감5
			/// </summary>
			public const string scha5 = "scha5";
			/// <summary>
			/// 매도비율5
			/// </summary>
			public const string ddiff5 = "ddiff5";
			/// <summary>
			/// 매수비율5
			/// </summary>
			public const string sdiff5 = "sdiff5";
			/// <summary>
			/// 외국계매도합계수량
			/// </summary>
			public const string fwdvl = "fwdvl";
			/// <summary>
			/// 외국계매도직전대비
			/// </summary>
			public const string ftradmdcha = "ftradmdcha";
			/// <summary>
			/// 외국계매도비율
			/// </summary>
			public const string ftradmddiff = "ftradmddiff";
			/// <summary>
			/// 외국계매수합계수량
			/// </summary>
			public const string fwsvl = "fwsvl";
			/// <summary>
			/// 외국계매수직전대비
			/// </summary>
			public const string ftradmscha = "ftradmscha";
			/// <summary>
			/// 외국계매수비율
			/// </summary>
			public const string ftradmsdiff = "ftradmsdiff";
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
			/// 순자산총액(억원)
			/// </summary>
			public const string etftotcap = "etftotcap";
			/// <summary>
			/// 스프레드
			/// </summary>
			public const string spread = "spread";
			/// <summary>
			/// 레버리지
			/// </summary>
			public const string leverage = "leverage";
			/// <summary>
			/// 과세구분
			/// </summary>
			public const string taxgubun = "taxgubun";
			/// <summary>
			/// 운용사
			/// </summary>
			public const string opcom_nmk = "opcom_nmk";
			/// <summary>
			/// LP1
			/// </summary>
			public const string lp_nm1 = "lp_nm1";
			/// <summary>
			/// LP2
			/// </summary>
			public const string lp_nm2 = "lp_nm2";
			/// <summary>
			/// LP3
			/// </summary>
			public const string lp_nm3 = "lp_nm3";
			/// <summary>
			/// LP4
			/// </summary>
			public const string lp_nm4 = "lp_nm4";
			/// <summary>
			/// LP5
			/// </summary>
			public const string lp_nm5 = "lp_nm5";
			/// <summary>
			/// 복제방법
			/// </summary>
			public const string etf_cp = "etf_cp";
			/// <summary>
			/// 상품유형(Filler)
			/// </summary>
			public const string etf_kind = "etf_kind";
			/// <summary>
			/// VI발동해제
			/// </summary>
			public const string vi_gubun = "vi_gubun";
			/// <summary>
			/// ETN상품분류
			/// </summary>
			public const string etn_kind_cd = "etn_kind_cd";
			/// <summary>
			/// ETN만기일
			/// </summary>
			public const string lastymd = "lastymd";
			/// <summary>
			/// ETN지급일
			/// </summary>
			public const string payday = "payday";
			/// <summary>
			/// ETN최종거래일
			/// </summary>
			public const string lastdate = "lastdate";
			/// <summary>
			/// ETN발행시장참가자
			/// </summary>
			public const string issuernmk = "issuernmk";
			/// <summary>
			/// ETN만기상환가격결정시작일
			/// </summary>
			public const string last_sdate = "last_sdate";
			/// <summary>
			/// ETN만기상환가격결정종료일
			/// </summary>
			public const string last_edate = "last_edate";
			/// <summary>
			/// ETNLP보유수량
			/// </summary>
			public const string lp_holdvol = "lp_holdvol";
			/// <summary>
			/// 상장일
			/// </summary>
			public const string listdate = "listdate";
			/// <summary>
			/// ETP상품구분코드
			/// </summary>
			public const string etp_gb = "etp_gb";
			/// <summary>
			/// ETN조기상환가능여부
			/// </summary>
			public const string etn_elback_yn = "etn_elback_yn";
			/// <summary>
			/// 최종결제
			/// </summary>
			public const string settletype = "settletype";
			/// <summary>
			/// 지수자산분류코드(대분류)
			/// </summary>
			public const string idx_asset_class1 = "idx_asset_class1";
			/// <summary>
			/// ETF/ETN투자유의
			/// </summary>
			public const string ty_text = "ty_text";
		}

		public static string[] AllFields = new string[]
		{
			F.hname,
			F.price,
			F.sign,
			F.change,
			F.diff,
			F.volume,
			F.recprice,
			F.avg,
			F.uplmtprice,
			F.dnlmtprice,
			F.jnilvolume,
			F.volumediff,
			F.open,
			F.opentime,
			F.high,
			F.hightime,
			F.low,
			F.lowtime,
			F.high52w,
			F.high52wdate,
			F.low52w,
			F.low52wdate,
			F.exhratio,
			F.flmtvol,
			F.per,
			F.listing,
			F.jkrate,
			F.vol,
			F.shcode,
			F.value,
			F.highyear,
			F.highyeardate,
			F.lowyear,
			F.lowyeardate,
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
			F.nav,
			F.navsign,
			F.navchange,
			F.navdiff,
			F.cocrate,
			F.kasis,
			F.subprice,
			F.offerno1,
			F.bidno1,
			F.dvol1,
			F.svol1,
			F.dcha1,
			F.scha1,
			F.ddiff1,
			F.sdiff1,
			F.offerno2,
			F.bidno2,
			F.dvol2,
			F.svol2,
			F.dcha2,
			F.scha2,
			F.ddiff2,
			F.sdiff2,
			F.offerno3,
			F.bidno3,
			F.dvol3,
			F.svol3,
			F.dcha3,
			F.scha3,
			F.ddiff3,
			F.sdiff3,
			F.offerno4,
			F.bidno4,
			F.dvol4,
			F.svol4,
			F.dcha4,
			F.scha4,
			F.ddiff4,
			F.sdiff4,
			F.offerno5,
			F.bidno5,
			F.dvol5,
			F.svol5,
			F.dcha5,
			F.scha5,
			F.ddiff5,
			F.sdiff5,
			F.fwdvl,
			F.ftradmdcha,
			F.ftradmddiff,
			F.fwsvl,
			F.ftradmscha,
			F.ftradmsdiff,
			F.upname2,
			F.upcode2,
			F.upprice2,
			F.jnilnav,
			F.jnilnavsign,
			F.jnilnavchange,
			F.jnilnavdiff,
			F.etftotcap,
			F.spread,
			F.leverage,
			F.taxgubun,
			F.opcom_nmk,
			F.lp_nm1,
			F.lp_nm2,
			F.lp_nm3,
			F.lp_nm4,
			F.lp_nm5,
			F.etf_cp,
			F.etf_kind,
			F.vi_gubun,
			F.etn_kind_cd,
			F.lastymd,
			F.payday,
			F.lastdate,
			F.issuernmk,
			F.last_sdate,
			F.last_edate,
			F.lp_holdvol,
			F.listdate,
			F.etp_gb,
			F.etn_elback_yn,
			F.settletype,
			F.idx_asset_class1,
			F.ty_text,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["hname"] = new XAQueryFieldInfo("char", hname, hname, "한글명", (decimal)20);
			dict["price"] = new XAQueryFieldInfo("long", price, price.ToString("d8"), "현재가", (decimal)8);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("long", change, change.ToString("d8"), "전일대비", (decimal)8);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["volume"] = new XAQueryFieldInfo("float", volume, volume.ToString("000000000000"), "누적거래량", (decimal)12);
			dict["recprice"] = new XAQueryFieldInfo("long", recprice, recprice.ToString("d8"), "기준가", (decimal)8);
			dict["avg"] = new XAQueryFieldInfo("long", avg, avg.ToString("d8"), "가중평균", (decimal)8);
			dict["uplmtprice"] = new XAQueryFieldInfo("long", uplmtprice, uplmtprice.ToString("d8"), "상한가", (decimal)8);
			dict["dnlmtprice"] = new XAQueryFieldInfo("long", dnlmtprice, dnlmtprice.ToString("d8"), "하한가", (decimal)8);
			dict["jnilvolume"] = new XAQueryFieldInfo("float", jnilvolume, jnilvolume.ToString("000000000000"), "전일거래량", (decimal)12);
			dict["volumediff"] = new XAQueryFieldInfo("long", volumediff, volumediff.ToString("d12"), "거래량차", (decimal)12);
			dict["open"] = new XAQueryFieldInfo("long", open, open.ToString("d8"), "시가", (decimal)8);
			dict["opentime"] = new XAQueryFieldInfo("char", opentime, opentime, "시가시간", (decimal)6);
			dict["high"] = new XAQueryFieldInfo("long", high, high.ToString("d8"), "고가", (decimal)8);
			dict["hightime"] = new XAQueryFieldInfo("char", hightime, hightime, "고가시간", (decimal)6);
			dict["low"] = new XAQueryFieldInfo("long", low, low.ToString("d8"), "저가", (decimal)8);
			dict["lowtime"] = new XAQueryFieldInfo("char", lowtime, lowtime, "저가시간", (decimal)6);
			dict["high52w"] = new XAQueryFieldInfo("long", high52w, high52w.ToString("d8"), "52최고가", (decimal)8);
			dict["high52wdate"] = new XAQueryFieldInfo("char", high52wdate, high52wdate, "52최고가일", (decimal)8);
			dict["low52w"] = new XAQueryFieldInfo("long", low52w, low52w.ToString("d8"), "52최저가", (decimal)8);
			dict["low52wdate"] = new XAQueryFieldInfo("char", low52wdate, low52wdate, "52최저가일", (decimal)8);
			dict["exhratio"] = new XAQueryFieldInfo("float", exhratio, exhratio.ToString("000000.00"), "소진율", (decimal)6.2);
			dict["flmtvol"] = new XAQueryFieldInfo("float", flmtvol, flmtvol.ToString("000000000000"), "외국인보유수량", (decimal)12);
			dict["per"] = new XAQueryFieldInfo("float", per, per.ToString("000000.00"), "PER", (decimal)6.2);
			dict["listing"] = new XAQueryFieldInfo("long", listing, listing.ToString("d12"), "상장주식수(천)", (decimal)12);
			dict["jkrate"] = new XAQueryFieldInfo("long", jkrate, jkrate.ToString("d8"), "증거금율", (decimal)8);
			dict["vol"] = new XAQueryFieldInfo("float", vol, vol.ToString("000000.00"), "회전율", (decimal)6.2);
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)6);
			dict["value"] = new XAQueryFieldInfo("long", value, value.ToString("d12"), "누적거래대금", (decimal)12);
			dict["highyear"] = new XAQueryFieldInfo("long", highyear, highyear.ToString("d8"), "연중최고가", (decimal)8);
			dict["highyeardate"] = new XAQueryFieldInfo("char", highyeardate, highyeardate, "연중최고일자", (decimal)8);
			dict["lowyear"] = new XAQueryFieldInfo("long", lowyear, lowyear.ToString("d8"), "연중최저가", (decimal)8);
			dict["lowyeardate"] = new XAQueryFieldInfo("char", lowyeardate, lowyeardate, "연중최저일자", (decimal)8);
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
			dict["nav"] = new XAQueryFieldInfo("float", nav, nav.ToString("00000000.00"), "NAV", (decimal)8.2);
			dict["navsign"] = new XAQueryFieldInfo("char", navsign, navsign.ToString(), "NAV전일대비구분", (decimal)1);
			dict["navchange"] = new XAQueryFieldInfo("float", navchange, navchange.ToString("00000000.00"), "NAV전일대비", (decimal)8.2);
			dict["navdiff"] = new XAQueryFieldInfo("float", navdiff, navdiff.ToString("000000.00"), "NAV등락율", (decimal)6.2);
			dict["cocrate"] = new XAQueryFieldInfo("float", cocrate, cocrate.ToString("000000.00"), "추적오차율", (decimal)6.2);
			dict["kasis"] = new XAQueryFieldInfo("float", kasis, kasis.ToString("000000.00"), "괴리율", (decimal)6.2);
			dict["subprice"] = new XAQueryFieldInfo("long", subprice, subprice.ToString("d10"), "대용가", (decimal)10);
			dict["offerno1"] = new XAQueryFieldInfo("char", offerno1, offerno1, "매도증권사코드1", (decimal)6);
			dict["bidno1"] = new XAQueryFieldInfo("char", bidno1, bidno1, "매수증권사코드1", (decimal)6);
			dict["dvol1"] = new XAQueryFieldInfo("long", dvol1, dvol1.ToString("d8"), "총매도수량1", (decimal)8);
			dict["svol1"] = new XAQueryFieldInfo("long", svol1, svol1.ToString("d8"), "총매수수량1", (decimal)8);
			dict["dcha1"] = new XAQueryFieldInfo("long", dcha1, dcha1.ToString("d8"), "매도증감1", (decimal)8);
			dict["scha1"] = new XAQueryFieldInfo("long", scha1, scha1.ToString("d8"), "매수증감1", (decimal)8);
			dict["ddiff1"] = new XAQueryFieldInfo("float", ddiff1, ddiff1.ToString("000000.00"), "매도비율1", (decimal)6.2);
			dict["sdiff1"] = new XAQueryFieldInfo("float", sdiff1, sdiff1.ToString("000000.00"), "매수비율1", (decimal)6.2);
			dict["offerno2"] = new XAQueryFieldInfo("char", offerno2, offerno2, "매도증권사코드2", (decimal)6);
			dict["bidno2"] = new XAQueryFieldInfo("char", bidno2, bidno2, "매수증권사코드2", (decimal)6);
			dict["dvol2"] = new XAQueryFieldInfo("long", dvol2, dvol2.ToString("d8"), "총매도수량2", (decimal)8);
			dict["svol2"] = new XAQueryFieldInfo("long", svol2, svol2.ToString("d8"), "총매수수량2", (decimal)8);
			dict["dcha2"] = new XAQueryFieldInfo("long", dcha2, dcha2.ToString("d8"), "매도증감2", (decimal)8);
			dict["scha2"] = new XAQueryFieldInfo("long", scha2, scha2.ToString("d8"), "매수증감2", (decimal)8);
			dict["ddiff2"] = new XAQueryFieldInfo("float", ddiff2, ddiff2.ToString("000000.00"), "매도비율2", (decimal)6.2);
			dict["sdiff2"] = new XAQueryFieldInfo("float", sdiff2, sdiff2.ToString("000000.00"), "매수비율2", (decimal)6.2);
			dict["offerno3"] = new XAQueryFieldInfo("char", offerno3, offerno3, "매도증권사코드3", (decimal)6);
			dict["bidno3"] = new XAQueryFieldInfo("char", bidno3, bidno3, "매수증권사코드3", (decimal)6);
			dict["dvol3"] = new XAQueryFieldInfo("long", dvol3, dvol3.ToString("d8"), "총매도수량3", (decimal)8);
			dict["svol3"] = new XAQueryFieldInfo("long", svol3, svol3.ToString("d8"), "총매수수량3", (decimal)8);
			dict["dcha3"] = new XAQueryFieldInfo("long", dcha3, dcha3.ToString("d8"), "매도증감3", (decimal)8);
			dict["scha3"] = new XAQueryFieldInfo("long", scha3, scha3.ToString("d8"), "매수증감3", (decimal)8);
			dict["ddiff3"] = new XAQueryFieldInfo("float", ddiff3, ddiff3.ToString("000000.00"), "매도비율3", (decimal)6.2);
			dict["sdiff3"] = new XAQueryFieldInfo("float", sdiff3, sdiff3.ToString("000000.00"), "매수비율3", (decimal)6.2);
			dict["offerno4"] = new XAQueryFieldInfo("char", offerno4, offerno4, "매도증권사코드4", (decimal)6);
			dict["bidno4"] = new XAQueryFieldInfo("char", bidno4, bidno4, "매수증권사코드4", (decimal)6);
			dict["dvol4"] = new XAQueryFieldInfo("long", dvol4, dvol4.ToString("d8"), "총매도수량4", (decimal)8);
			dict["svol4"] = new XAQueryFieldInfo("long", svol4, svol4.ToString("d8"), "총매수수량4", (decimal)8);
			dict["dcha4"] = new XAQueryFieldInfo("long", dcha4, dcha4.ToString("d8"), "매도증감4", (decimal)8);
			dict["scha4"] = new XAQueryFieldInfo("long", scha4, scha4.ToString("d8"), "매수증감4", (decimal)8);
			dict["ddiff4"] = new XAQueryFieldInfo("float", ddiff4, ddiff4.ToString("000000.00"), "매도비율4", (decimal)6.2);
			dict["sdiff4"] = new XAQueryFieldInfo("float", sdiff4, sdiff4.ToString("000000.00"), "매수비율4", (decimal)6.2);
			dict["offerno5"] = new XAQueryFieldInfo("char", offerno5, offerno5, "매도증권사코드5", (decimal)6);
			dict["bidno5"] = new XAQueryFieldInfo("char", bidno5, bidno5, "매수증권사코드5", (decimal)6);
			dict["dvol5"] = new XAQueryFieldInfo("long", dvol5, dvol5.ToString("d8"), "총매도수량5", (decimal)8);
			dict["svol5"] = new XAQueryFieldInfo("long", svol5, svol5.ToString("d8"), "총매수수량5", (decimal)8);
			dict["dcha5"] = new XAQueryFieldInfo("long", dcha5, dcha5.ToString("d8"), "매도증감5", (decimal)8);
			dict["scha5"] = new XAQueryFieldInfo("long", scha5, scha5.ToString("d8"), "매수증감5", (decimal)8);
			dict["ddiff5"] = new XAQueryFieldInfo("float", ddiff5, ddiff5.ToString("000000.00"), "매도비율5", (decimal)6.2);
			dict["sdiff5"] = new XAQueryFieldInfo("float", sdiff5, sdiff5.ToString("000000.00"), "매수비율5", (decimal)6.2);
			dict["fwdvl"] = new XAQueryFieldInfo("long", fwdvl, fwdvl.ToString("d12"), "외국계매도합계수량", (decimal)12);
			dict["ftradmdcha"] = new XAQueryFieldInfo("long", ftradmdcha, ftradmdcha.ToString("d12"), "외국계매도직전대비", (decimal)12);
			dict["ftradmddiff"] = new XAQueryFieldInfo("float", ftradmddiff, ftradmddiff.ToString("000000.00"), "외국계매도비율", (decimal)6.2);
			dict["fwsvl"] = new XAQueryFieldInfo("long", fwsvl, fwsvl.ToString("d12"), "외국계매수합계수량", (decimal)12);
			dict["ftradmscha"] = new XAQueryFieldInfo("long", ftradmscha, ftradmscha.ToString("d12"), "외국계매수직전대비", (decimal)12);
			dict["ftradmsdiff"] = new XAQueryFieldInfo("float", ftradmsdiff, ftradmsdiff.ToString("000000.00"), "외국계매수비율", (decimal)6.2);
			dict["upname2"] = new XAQueryFieldInfo("char", upname2, upname2, "참고지수명", (decimal)20);
			dict["upcode2"] = new XAQueryFieldInfo("char", upcode2, upcode2, "참고지수코드", (decimal)3);
			dict["upprice2"] = new XAQueryFieldInfo("float", upprice2, upprice2.ToString("0000000.00"), "참고지수현재가", (decimal)7.2);
			dict["jnilnav"] = new XAQueryFieldInfo("float", jnilnav, jnilnav.ToString("00000000.00"), "전일NAV", (decimal)8.2);
			dict["jnilnavsign"] = new XAQueryFieldInfo("char", jnilnavsign, jnilnavsign.ToString(), "전일NAV전일대비구분", (decimal)1);
			dict["jnilnavchange"] = new XAQueryFieldInfo("float", jnilnavchange, jnilnavchange.ToString("00000000.00"), "전일NAV전일대비", (decimal)8.2);
			dict["jnilnavdiff"] = new XAQueryFieldInfo("float", jnilnavdiff, jnilnavdiff.ToString("000000.00"), "전일NAV등락율", (decimal)6.2);
			dict["etftotcap"] = new XAQueryFieldInfo("long", etftotcap, etftotcap.ToString("d12"), "순자산총액(억원)", (decimal)12);
			dict["spread"] = new XAQueryFieldInfo("float", spread, spread.ToString("000000.00"), "스프레드", (decimal)6.2);
			dict["leverage"] = new XAQueryFieldInfo("long", leverage, leverage.ToString("d2"), "레버리지", (decimal)2);
			dict["taxgubun"] = new XAQueryFieldInfo("char", taxgubun, taxgubun.ToString(), "과세구분", (decimal)1);
			dict["opcom_nmk"] = new XAQueryFieldInfo("char", opcom_nmk, opcom_nmk, "운용사", (decimal)20);
			dict["lp_nm1"] = new XAQueryFieldInfo("char", lp_nm1, lp_nm1, "LP1", (decimal)20);
			dict["lp_nm2"] = new XAQueryFieldInfo("char", lp_nm2, lp_nm2, "LP2", (decimal)20);
			dict["lp_nm3"] = new XAQueryFieldInfo("char", lp_nm3, lp_nm3, "LP3", (decimal)20);
			dict["lp_nm4"] = new XAQueryFieldInfo("char", lp_nm4, lp_nm4, "LP4", (decimal)20);
			dict["lp_nm5"] = new XAQueryFieldInfo("char", lp_nm5, lp_nm5, "LP5", (decimal)20);
			dict["etf_cp"] = new XAQueryFieldInfo("char", etf_cp, etf_cp, "복제방법", (decimal)10);
			dict["etf_kind"] = new XAQueryFieldInfo("char", etf_kind, etf_kind, "상품유형(Filler)", (decimal)10);
			dict["vi_gubun"] = new XAQueryFieldInfo("char", vi_gubun, vi_gubun, "VI발동해제", (decimal)10);
			dict["etn_kind_cd"] = new XAQueryFieldInfo("char", etn_kind_cd, etn_kind_cd, "ETN상품분류", (decimal)20);
			dict["lastymd"] = new XAQueryFieldInfo("char", lastymd, lastymd, "ETN만기일", (decimal)8);
			dict["payday"] = new XAQueryFieldInfo("char", payday, payday, "ETN지급일", (decimal)8);
			dict["lastdate"] = new XAQueryFieldInfo("char", lastdate, lastdate, "ETN최종거래일", (decimal)8);
			dict["issuernmk"] = new XAQueryFieldInfo("char", issuernmk, issuernmk, "ETN발행시장참가자", (decimal)20);
			dict["last_sdate"] = new XAQueryFieldInfo("char", last_sdate, last_sdate, "ETN만기상환가격결정시작일", (decimal)8);
			dict["last_edate"] = new XAQueryFieldInfo("char", last_edate, last_edate, "ETN만기상환가격결정종료일", (decimal)8);
			dict["lp_holdvol"] = new XAQueryFieldInfo("char", lp_holdvol, lp_holdvol, "ETNLP보유수량", (decimal)12);
			dict["listdate"] = new XAQueryFieldInfo("char", listdate, listdate, "상장일", (decimal)8);
			dict["etp_gb"] = new XAQueryFieldInfo("char", etp_gb, etp_gb.ToString(), "ETP상품구분코드", (decimal)1);
			dict["etn_elback_yn"] = new XAQueryFieldInfo("char", etn_elback_yn, etn_elback_yn.ToString(), "ETN조기상환가능여부", (decimal)1);
			dict["settletype"] = new XAQueryFieldInfo("char", settletype, settletype, "최종결제", (decimal)2);
			dict["idx_asset_class1"] = new XAQueryFieldInfo("char", idx_asset_class1, idx_asset_class1, "지수자산분류코드(대분류)", (decimal)2);
			dict["ty_text"] = new XAQueryFieldInfo("char", ty_text, ty_text, "ETF/ETN투자유의", (decimal)8);

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
					this.volume = fieldInfo.FieldValue.ParseFloat("volume");
				break;

				case "recprice":
					this.recprice = fieldInfo.FieldValue.ParseLong("recprice");
				break;

				case "avg":
					this.avg = fieldInfo.FieldValue.ParseLong("avg");
				break;

				case "uplmtprice":
					this.uplmtprice = fieldInfo.FieldValue.ParseLong("uplmtprice");
				break;

				case "dnlmtprice":
					this.dnlmtprice = fieldInfo.FieldValue.ParseLong("dnlmtprice");
				break;

				case "jnilvolume":
					this.jnilvolume = fieldInfo.FieldValue.ParseFloat("jnilvolume");
				break;

				case "volumediff":
					this.volumediff = fieldInfo.FieldValue.ParseLong("volumediff");
				break;

				case "open":
					this.open = fieldInfo.FieldValue.ParseLong("open");
				break;

				case "opentime":
					this.opentime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "high":
					this.high = fieldInfo.FieldValue.ParseLong("high");
				break;

				case "hightime":
					this.hightime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "low":
					this.low = fieldInfo.FieldValue.ParseLong("low");
				break;

				case "lowtime":
					this.lowtime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "high52w":
					this.high52w = fieldInfo.FieldValue.ParseLong("high52w");
				break;

				case "high52wdate":
					this.high52wdate = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "low52w":
					this.low52w = fieldInfo.FieldValue.ParseLong("low52w");
				break;

				case "low52wdate":
					this.low52wdate = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "exhratio":
					this.exhratio = fieldInfo.FieldValue.ParseFloat("exhratio");
				break;

				case "flmtvol":
					this.flmtvol = fieldInfo.FieldValue.ParseFloat("flmtvol");
				break;

				case "per":
					this.per = fieldInfo.FieldValue.ParseFloat("per");
				break;

				case "listing":
					this.listing = fieldInfo.FieldValue.ParseLong("listing");
				break;

				case "jkrate":
					this.jkrate = fieldInfo.FieldValue.ParseLong("jkrate");
				break;

				case "vol":
					this.vol = fieldInfo.FieldValue.ParseFloat("vol");
				break;

				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "value":
					this.value = fieldInfo.FieldValue.ParseLong("value");
				break;

				case "highyear":
					this.highyear = fieldInfo.FieldValue.ParseLong("highyear");
				break;

				case "highyeardate":
					this.highyeardate = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "lowyear":
					this.lowyear = fieldInfo.FieldValue.ParseLong("lowyear");
				break;

				case "lowyeardate":
					this.lowyeardate = fieldInfo.FieldValue.TrimEnd('?');
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

				case "cocrate":
					this.cocrate = fieldInfo.FieldValue.ParseFloat("cocrate");
				break;

				case "kasis":
					this.kasis = fieldInfo.FieldValue.ParseFloat("kasis");
				break;

				case "subprice":
					this.subprice = fieldInfo.FieldValue.ParseLong("subprice");
				break;

				case "offerno1":
					this.offerno1 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "bidno1":
					this.bidno1 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "dvol1":
					this.dvol1 = fieldInfo.FieldValue.ParseLong("dvol1");
				break;

				case "svol1":
					this.svol1 = fieldInfo.FieldValue.ParseLong("svol1");
				break;

				case "dcha1":
					this.dcha1 = fieldInfo.FieldValue.ParseLong("dcha1");
				break;

				case "scha1":
					this.scha1 = fieldInfo.FieldValue.ParseLong("scha1");
				break;

				case "ddiff1":
					this.ddiff1 = fieldInfo.FieldValue.ParseFloat("ddiff1");
				break;

				case "sdiff1":
					this.sdiff1 = fieldInfo.FieldValue.ParseFloat("sdiff1");
				break;

				case "offerno2":
					this.offerno2 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "bidno2":
					this.bidno2 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "dvol2":
					this.dvol2 = fieldInfo.FieldValue.ParseLong("dvol2");
				break;

				case "svol2":
					this.svol2 = fieldInfo.FieldValue.ParseLong("svol2");
				break;

				case "dcha2":
					this.dcha2 = fieldInfo.FieldValue.ParseLong("dcha2");
				break;

				case "scha2":
					this.scha2 = fieldInfo.FieldValue.ParseLong("scha2");
				break;

				case "ddiff2":
					this.ddiff2 = fieldInfo.FieldValue.ParseFloat("ddiff2");
				break;

				case "sdiff2":
					this.sdiff2 = fieldInfo.FieldValue.ParseFloat("sdiff2");
				break;

				case "offerno3":
					this.offerno3 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "bidno3":
					this.bidno3 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "dvol3":
					this.dvol3 = fieldInfo.FieldValue.ParseLong("dvol3");
				break;

				case "svol3":
					this.svol3 = fieldInfo.FieldValue.ParseLong("svol3");
				break;

				case "dcha3":
					this.dcha3 = fieldInfo.FieldValue.ParseLong("dcha3");
				break;

				case "scha3":
					this.scha3 = fieldInfo.FieldValue.ParseLong("scha3");
				break;

				case "ddiff3":
					this.ddiff3 = fieldInfo.FieldValue.ParseFloat("ddiff3");
				break;

				case "sdiff3":
					this.sdiff3 = fieldInfo.FieldValue.ParseFloat("sdiff3");
				break;

				case "offerno4":
					this.offerno4 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "bidno4":
					this.bidno4 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "dvol4":
					this.dvol4 = fieldInfo.FieldValue.ParseLong("dvol4");
				break;

				case "svol4":
					this.svol4 = fieldInfo.FieldValue.ParseLong("svol4");
				break;

				case "dcha4":
					this.dcha4 = fieldInfo.FieldValue.ParseLong("dcha4");
				break;

				case "scha4":
					this.scha4 = fieldInfo.FieldValue.ParseLong("scha4");
				break;

				case "ddiff4":
					this.ddiff4 = fieldInfo.FieldValue.ParseFloat("ddiff4");
				break;

				case "sdiff4":
					this.sdiff4 = fieldInfo.FieldValue.ParseFloat("sdiff4");
				break;

				case "offerno5":
					this.offerno5 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "bidno5":
					this.bidno5 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "dvol5":
					this.dvol5 = fieldInfo.FieldValue.ParseLong("dvol5");
				break;

				case "svol5":
					this.svol5 = fieldInfo.FieldValue.ParseLong("svol5");
				break;

				case "dcha5":
					this.dcha5 = fieldInfo.FieldValue.ParseLong("dcha5");
				break;

				case "scha5":
					this.scha5 = fieldInfo.FieldValue.ParseLong("scha5");
				break;

				case "ddiff5":
					this.ddiff5 = fieldInfo.FieldValue.ParseFloat("ddiff5");
				break;

				case "sdiff5":
					this.sdiff5 = fieldInfo.FieldValue.ParseFloat("sdiff5");
				break;

				case "fwdvl":
					this.fwdvl = fieldInfo.FieldValue.ParseLong("fwdvl");
				break;

				case "ftradmdcha":
					this.ftradmdcha = fieldInfo.FieldValue.ParseLong("ftradmdcha");
				break;

				case "ftradmddiff":
					this.ftradmddiff = fieldInfo.FieldValue.ParseFloat("ftradmddiff");
				break;

				case "fwsvl":
					this.fwsvl = fieldInfo.FieldValue.ParseLong("fwsvl");
				break;

				case "ftradmscha":
					this.ftradmscha = fieldInfo.FieldValue.ParseLong("ftradmscha");
				break;

				case "ftradmsdiff":
					this.ftradmsdiff = fieldInfo.FieldValue.ParseFloat("ftradmsdiff");
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

				case "etftotcap":
					this.etftotcap = fieldInfo.FieldValue.ParseLong("etftotcap");
				break;

				case "spread":
					this.spread = fieldInfo.FieldValue.ParseFloat("spread");
				break;

				case "leverage":
					this.leverage = fieldInfo.FieldValue.ParseLong("leverage");
				break;

				case "taxgubun":
					this.taxgubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "opcom_nmk":
					this.opcom_nmk = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "lp_nm1":
					this.lp_nm1 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "lp_nm2":
					this.lp_nm2 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "lp_nm3":
					this.lp_nm3 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "lp_nm4":
					this.lp_nm4 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "lp_nm5":
					this.lp_nm5 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "etf_cp":
					this.etf_cp = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "etf_kind":
					this.etf_kind = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "vi_gubun":
					this.vi_gubun = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "etn_kind_cd":
					this.etn_kind_cd = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "lastymd":
					this.lastymd = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "payday":
					this.payday = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "lastdate":
					this.lastdate = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "issuernmk":
					this.issuernmk = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "last_sdate":
					this.last_sdate = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "last_edate":
					this.last_edate = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "lp_holdvol":
					this.lp_holdvol = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "listdate":
					this.listdate = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "etp_gb":
					this.etp_gb = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "etn_elback_yn":
					this.etn_elback_yn = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "settletype":
					this.settletype = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "idx_asset_class1":
					this.idx_asset_class1 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ty_text":
					this.ty_text = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt1901OutBlock FromQuery(XQt1901 query)
		{
			XQt1901OutBlock block = new XQt1901OutBlock();
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
				block.diff = query.GetFieldData(block.GetBlockName(), "diff", 0).ParseFloat("diff"); // float 6.2
				block.volume = query.GetFieldData(block.GetBlockName(), "volume", 0).ParseFloat("volume"); // float 12
				block.recprice = query.GetFieldData(block.GetBlockName(), "recprice", 0).ParseLong("recprice"); // long 8
				block.avg = query.GetFieldData(block.GetBlockName(), "avg", 0).ParseLong("avg"); // long 8
				block.uplmtprice = query.GetFieldData(block.GetBlockName(), "uplmtprice", 0).ParseLong("uplmtprice"); // long 8
				block.dnlmtprice = query.GetFieldData(block.GetBlockName(), "dnlmtprice", 0).ParseLong("dnlmtprice"); // long 8
				block.jnilvolume = query.GetFieldData(block.GetBlockName(), "jnilvolume", 0).ParseFloat("jnilvolume"); // float 12
				block.volumediff = query.GetFieldData(block.GetBlockName(), "volumediff", 0).ParseLong("volumediff"); // long 12
				block.open = query.GetFieldData(block.GetBlockName(), "open", 0).ParseLong("open"); // long 8
				block.opentime = query.GetFieldData(block.GetBlockName(), "opentime", 0).TrimEnd('?'); // char 6
				block.high = query.GetFieldData(block.GetBlockName(), "high", 0).ParseLong("high"); // long 8
				block.hightime = query.GetFieldData(block.GetBlockName(), "hightime", 0).TrimEnd('?'); // char 6
				block.low = query.GetFieldData(block.GetBlockName(), "low", 0).ParseLong("low"); // long 8
				block.lowtime = query.GetFieldData(block.GetBlockName(), "lowtime", 0).TrimEnd('?'); // char 6
				block.high52w = query.GetFieldData(block.GetBlockName(), "high52w", 0).ParseLong("high52w"); // long 8
				block.high52wdate = query.GetFieldData(block.GetBlockName(), "high52wdate", 0).TrimEnd('?'); // char 8
				block.low52w = query.GetFieldData(block.GetBlockName(), "low52w", 0).ParseLong("low52w"); // long 8
				block.low52wdate = query.GetFieldData(block.GetBlockName(), "low52wdate", 0).TrimEnd('?'); // char 8
				block.exhratio = query.GetFieldData(block.GetBlockName(), "exhratio", 0).ParseFloat("exhratio"); // float 6.2
				block.flmtvol = query.GetFieldData(block.GetBlockName(), "flmtvol", 0).ParseFloat("flmtvol"); // float 12
				block.per = query.GetFieldData(block.GetBlockName(), "per", 0).ParseFloat("per"); // float 6.2
				block.listing = query.GetFieldData(block.GetBlockName(), "listing", 0).ParseLong("listing"); // long 12
				block.jkrate = query.GetFieldData(block.GetBlockName(), "jkrate", 0).ParseLong("jkrate"); // long 8
				block.vol = query.GetFieldData(block.GetBlockName(), "vol", 0).ParseFloat("vol"); // float 6.2
				block.shcode = query.GetFieldData(block.GetBlockName(), "shcode", 0).TrimEnd('?'); // char 6
				block.value = query.GetFieldData(block.GetBlockName(), "value", 0).ParseLong("value"); // long 12
				block.highyear = query.GetFieldData(block.GetBlockName(), "highyear", 0).ParseLong("highyear"); // long 8
				block.highyeardate = query.GetFieldData(block.GetBlockName(), "highyeardate", 0).TrimEnd('?'); // char 8
				block.lowyear = query.GetFieldData(block.GetBlockName(), "lowyear", 0).ParseLong("lowyear"); // long 8
				block.lowyeardate = query.GetFieldData(block.GetBlockName(), "lowyeardate", 0).TrimEnd('?'); // char 8
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
				block.nav = query.GetFieldData(block.GetBlockName(), "nav", 0).ParseFloat("nav"); // float 8.2
				block.navsign = query.GetFieldData(block.GetBlockName(), "navsign", 0).FirstOrDefault(); // char 1
				block.navchange = query.GetFieldData(block.GetBlockName(), "navchange", 0).ParseFloat("navchange"); // float 8.2
				block.navdiff = query.GetFieldData(block.GetBlockName(), "navdiff", 0).ParseFloat("navdiff"); // float 6.2
				block.cocrate = query.GetFieldData(block.GetBlockName(), "cocrate", 0).ParseFloat("cocrate"); // float 6.2
				block.kasis = query.GetFieldData(block.GetBlockName(), "kasis", 0).ParseFloat("kasis"); // float 6.2
				block.subprice = query.GetFieldData(block.GetBlockName(), "subprice", 0).ParseLong("subprice"); // long 10
				block.offerno1 = query.GetFieldData(block.GetBlockName(), "offerno1", 0).TrimEnd('?'); // char 6
				block.bidno1 = query.GetFieldData(block.GetBlockName(), "bidno1", 0).TrimEnd('?'); // char 6
				block.dvol1 = query.GetFieldData(block.GetBlockName(), "dvol1", 0).ParseLong("dvol1"); // long 8
				block.svol1 = query.GetFieldData(block.GetBlockName(), "svol1", 0).ParseLong("svol1"); // long 8
				block.dcha1 = query.GetFieldData(block.GetBlockName(), "dcha1", 0).ParseLong("dcha1"); // long 8
				block.scha1 = query.GetFieldData(block.GetBlockName(), "scha1", 0).ParseLong("scha1"); // long 8
				block.ddiff1 = query.GetFieldData(block.GetBlockName(), "ddiff1", 0).ParseFloat("ddiff1"); // float 6.2
				block.sdiff1 = query.GetFieldData(block.GetBlockName(), "sdiff1", 0).ParseFloat("sdiff1"); // float 6.2
				block.offerno2 = query.GetFieldData(block.GetBlockName(), "offerno2", 0).TrimEnd('?'); // char 6
				block.bidno2 = query.GetFieldData(block.GetBlockName(), "bidno2", 0).TrimEnd('?'); // char 6
				block.dvol2 = query.GetFieldData(block.GetBlockName(), "dvol2", 0).ParseLong("dvol2"); // long 8
				block.svol2 = query.GetFieldData(block.GetBlockName(), "svol2", 0).ParseLong("svol2"); // long 8
				block.dcha2 = query.GetFieldData(block.GetBlockName(), "dcha2", 0).ParseLong("dcha2"); // long 8
				block.scha2 = query.GetFieldData(block.GetBlockName(), "scha2", 0).ParseLong("scha2"); // long 8
				block.ddiff2 = query.GetFieldData(block.GetBlockName(), "ddiff2", 0).ParseFloat("ddiff2"); // float 6.2
				block.sdiff2 = query.GetFieldData(block.GetBlockName(), "sdiff2", 0).ParseFloat("sdiff2"); // float 6.2
				block.offerno3 = query.GetFieldData(block.GetBlockName(), "offerno3", 0).TrimEnd('?'); // char 6
				block.bidno3 = query.GetFieldData(block.GetBlockName(), "bidno3", 0).TrimEnd('?'); // char 6
				block.dvol3 = query.GetFieldData(block.GetBlockName(), "dvol3", 0).ParseLong("dvol3"); // long 8
				block.svol3 = query.GetFieldData(block.GetBlockName(), "svol3", 0).ParseLong("svol3"); // long 8
				block.dcha3 = query.GetFieldData(block.GetBlockName(), "dcha3", 0).ParseLong("dcha3"); // long 8
				block.scha3 = query.GetFieldData(block.GetBlockName(), "scha3", 0).ParseLong("scha3"); // long 8
				block.ddiff3 = query.GetFieldData(block.GetBlockName(), "ddiff3", 0).ParseFloat("ddiff3"); // float 6.2
				block.sdiff3 = query.GetFieldData(block.GetBlockName(), "sdiff3", 0).ParseFloat("sdiff3"); // float 6.2
				block.offerno4 = query.GetFieldData(block.GetBlockName(), "offerno4", 0).TrimEnd('?'); // char 6
				block.bidno4 = query.GetFieldData(block.GetBlockName(), "bidno4", 0).TrimEnd('?'); // char 6
				block.dvol4 = query.GetFieldData(block.GetBlockName(), "dvol4", 0).ParseLong("dvol4"); // long 8
				block.svol4 = query.GetFieldData(block.GetBlockName(), "svol4", 0).ParseLong("svol4"); // long 8
				block.dcha4 = query.GetFieldData(block.GetBlockName(), "dcha4", 0).ParseLong("dcha4"); // long 8
				block.scha4 = query.GetFieldData(block.GetBlockName(), "scha4", 0).ParseLong("scha4"); // long 8
				block.ddiff4 = query.GetFieldData(block.GetBlockName(), "ddiff4", 0).ParseFloat("ddiff4"); // float 6.2
				block.sdiff4 = query.GetFieldData(block.GetBlockName(), "sdiff4", 0).ParseFloat("sdiff4"); // float 6.2
				block.offerno5 = query.GetFieldData(block.GetBlockName(), "offerno5", 0).TrimEnd('?'); // char 6
				block.bidno5 = query.GetFieldData(block.GetBlockName(), "bidno5", 0).TrimEnd('?'); // char 6
				block.dvol5 = query.GetFieldData(block.GetBlockName(), "dvol5", 0).ParseLong("dvol5"); // long 8
				block.svol5 = query.GetFieldData(block.GetBlockName(), "svol5", 0).ParseLong("svol5"); // long 8
				block.dcha5 = query.GetFieldData(block.GetBlockName(), "dcha5", 0).ParseLong("dcha5"); // long 8
				block.scha5 = query.GetFieldData(block.GetBlockName(), "scha5", 0).ParseLong("scha5"); // long 8
				block.ddiff5 = query.GetFieldData(block.GetBlockName(), "ddiff5", 0).ParseFloat("ddiff5"); // float 6.2
				block.sdiff5 = query.GetFieldData(block.GetBlockName(), "sdiff5", 0).ParseFloat("sdiff5"); // float 6.2
				block.fwdvl = query.GetFieldData(block.GetBlockName(), "fwdvl", 0).ParseLong("fwdvl"); // long 12
				block.ftradmdcha = query.GetFieldData(block.GetBlockName(), "ftradmdcha", 0).ParseLong("ftradmdcha"); // long 12
				block.ftradmddiff = query.GetFieldData(block.GetBlockName(), "ftradmddiff", 0).ParseFloat("ftradmddiff"); // float 6.2
				block.fwsvl = query.GetFieldData(block.GetBlockName(), "fwsvl", 0).ParseLong("fwsvl"); // long 12
				block.ftradmscha = query.GetFieldData(block.GetBlockName(), "ftradmscha", 0).ParseLong("ftradmscha"); // long 12
				block.ftradmsdiff = query.GetFieldData(block.GetBlockName(), "ftradmsdiff", 0).ParseFloat("ftradmsdiff"); // float 6.2
				block.upname2 = query.GetFieldData(block.GetBlockName(), "upname2", 0).TrimEnd('?'); // char 20
				block.upcode2 = query.GetFieldData(block.GetBlockName(), "upcode2", 0).TrimEnd('?'); // char 3
				block.upprice2 = query.GetFieldData(block.GetBlockName(), "upprice2", 0).ParseFloat("upprice2"); // float 7.2
				block.jnilnav = query.GetFieldData(block.GetBlockName(), "jnilnav", 0).ParseFloat("jnilnav"); // float 8.2
				block.jnilnavsign = query.GetFieldData(block.GetBlockName(), "jnilnavsign", 0).FirstOrDefault(); // char 1
				block.jnilnavchange = query.GetFieldData(block.GetBlockName(), "jnilnavchange", 0).ParseFloat("jnilnavchange"); // float 8.2
				block.jnilnavdiff = query.GetFieldData(block.GetBlockName(), "jnilnavdiff", 0).ParseFloat("jnilnavdiff"); // float 6.2
				block.etftotcap = query.GetFieldData(block.GetBlockName(), "etftotcap", 0).ParseLong("etftotcap"); // long 12
				block.spread = query.GetFieldData(block.GetBlockName(), "spread", 0).ParseFloat("spread"); // float 6.2
				block.leverage = query.GetFieldData(block.GetBlockName(), "leverage", 0).ParseLong("leverage"); // long 2
				block.taxgubun = query.GetFieldData(block.GetBlockName(), "taxgubun", 0).FirstOrDefault(); // char 1
				block.opcom_nmk = query.GetFieldData(block.GetBlockName(), "opcom_nmk", 0).TrimEnd('?'); // char 20
				block.lp_nm1 = query.GetFieldData(block.GetBlockName(), "lp_nm1", 0).TrimEnd('?'); // char 20
				block.lp_nm2 = query.GetFieldData(block.GetBlockName(), "lp_nm2", 0).TrimEnd('?'); // char 20
				block.lp_nm3 = query.GetFieldData(block.GetBlockName(), "lp_nm3", 0).TrimEnd('?'); // char 20
				block.lp_nm4 = query.GetFieldData(block.GetBlockName(), "lp_nm4", 0).TrimEnd('?'); // char 20
				block.lp_nm5 = query.GetFieldData(block.GetBlockName(), "lp_nm5", 0).TrimEnd('?'); // char 20
				block.etf_cp = query.GetFieldData(block.GetBlockName(), "etf_cp", 0).TrimEnd('?'); // char 10
				block.etf_kind = query.GetFieldData(block.GetBlockName(), "etf_kind", 0).TrimEnd('?'); // char 10
				block.vi_gubun = query.GetFieldData(block.GetBlockName(), "vi_gubun", 0).TrimEnd('?'); // char 10
				block.etn_kind_cd = query.GetFieldData(block.GetBlockName(), "etn_kind_cd", 0).TrimEnd('?'); // char 20
				block.lastymd = query.GetFieldData(block.GetBlockName(), "lastymd", 0).TrimEnd('?'); // char 8
				block.payday = query.GetFieldData(block.GetBlockName(), "payday", 0).TrimEnd('?'); // char 8
				block.lastdate = query.GetFieldData(block.GetBlockName(), "lastdate", 0).TrimEnd('?'); // char 8
				block.issuernmk = query.GetFieldData(block.GetBlockName(), "issuernmk", 0).TrimEnd('?'); // char 20
				block.last_sdate = query.GetFieldData(block.GetBlockName(), "last_sdate", 0).TrimEnd('?'); // char 8
				block.last_edate = query.GetFieldData(block.GetBlockName(), "last_edate", 0).TrimEnd('?'); // char 8
				block.lp_holdvol = query.GetFieldData(block.GetBlockName(), "lp_holdvol", 0).TrimEnd('?'); // char 12
				block.listdate = query.GetFieldData(block.GetBlockName(), "listdate", 0).TrimEnd('?'); // char 8
				block.etp_gb = query.GetFieldData(block.GetBlockName(), "etp_gb", 0).FirstOrDefault(); // char 1
				block.etn_elback_yn = query.GetFieldData(block.GetBlockName(), "etn_elback_yn", 0).FirstOrDefault(); // char 1
				block.settletype = query.GetFieldData(block.GetBlockName(), "settletype", 0).TrimEnd('?'); // char 2
				block.idx_asset_class1 = query.GetFieldData(block.GetBlockName(), "idx_asset_class1", 0).TrimEnd('?'); // char 2
				block.ty_text = query.GetFieldData(block.GetBlockName(), "ty_text", 0).TrimEnd('?'); // char 8

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
			// diff float 6.2
			// volume float 12
			if (recprice.ToString().Length > 8) return false; // long 8
			if (avg.ToString().Length > 8) return false; // long 8
			if (uplmtprice.ToString().Length > 8) return false; // long 8
			if (dnlmtprice.ToString().Length > 8) return false; // long 8
			// jnilvolume float 12
			if (volumediff.ToString().Length > 12) return false; // long 12
			if (open.ToString().Length > 8) return false; // long 8
			if (opentime?.Length > 6) return false; // char 6
			if (high.ToString().Length > 8) return false; // long 8
			if (hightime?.Length > 6) return false; // char 6
			if (low.ToString().Length > 8) return false; // long 8
			if (lowtime?.Length > 6) return false; // char 6
			if (high52w.ToString().Length > 8) return false; // long 8
			if (high52wdate?.Length > 8) return false; // char 8
			if (low52w.ToString().Length > 8) return false; // long 8
			if (low52wdate?.Length > 8) return false; // char 8
			// exhratio float 6.2
			// flmtvol float 12
			// per float 6.2
			if (listing.ToString().Length > 12) return false; // long 12
			if (jkrate.ToString().Length > 8) return false; // long 8
			// vol float 6.2
			if (shcode?.Length > 6) return false; // char 6
			if (value.ToString().Length > 12) return false; // long 12
			if (highyear.ToString().Length > 8) return false; // long 8
			if (highyeardate?.Length > 8) return false; // char 8
			if (lowyear.ToString().Length > 8) return false; // long 8
			if (lowyeardate?.Length > 8) return false; // char 8
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
			// nav float 8.2
			// navsign char 1
			// navchange float 8.2
			// navdiff float 6.2
			// cocrate float 6.2
			// kasis float 6.2
			if (subprice.ToString().Length > 10) return false; // long 10
			if (offerno1?.Length > 6) return false; // char 6
			if (bidno1?.Length > 6) return false; // char 6
			if (dvol1.ToString().Length > 8) return false; // long 8
			if (svol1.ToString().Length > 8) return false; // long 8
			if (dcha1.ToString().Length > 8) return false; // long 8
			if (scha1.ToString().Length > 8) return false; // long 8
			// ddiff1 float 6.2
			// sdiff1 float 6.2
			if (offerno2?.Length > 6) return false; // char 6
			if (bidno2?.Length > 6) return false; // char 6
			if (dvol2.ToString().Length > 8) return false; // long 8
			if (svol2.ToString().Length > 8) return false; // long 8
			if (dcha2.ToString().Length > 8) return false; // long 8
			if (scha2.ToString().Length > 8) return false; // long 8
			// ddiff2 float 6.2
			// sdiff2 float 6.2
			if (offerno3?.Length > 6) return false; // char 6
			if (bidno3?.Length > 6) return false; // char 6
			if (dvol3.ToString().Length > 8) return false; // long 8
			if (svol3.ToString().Length > 8) return false; // long 8
			if (dcha3.ToString().Length > 8) return false; // long 8
			if (scha3.ToString().Length > 8) return false; // long 8
			// ddiff3 float 6.2
			// sdiff3 float 6.2
			if (offerno4?.Length > 6) return false; // char 6
			if (bidno4?.Length > 6) return false; // char 6
			if (dvol4.ToString().Length > 8) return false; // long 8
			if (svol4.ToString().Length > 8) return false; // long 8
			if (dcha4.ToString().Length > 8) return false; // long 8
			if (scha4.ToString().Length > 8) return false; // long 8
			// ddiff4 float 6.2
			// sdiff4 float 6.2
			if (offerno5?.Length > 6) return false; // char 6
			if (bidno5?.Length > 6) return false; // char 6
			if (dvol5.ToString().Length > 8) return false; // long 8
			if (svol5.ToString().Length > 8) return false; // long 8
			if (dcha5.ToString().Length > 8) return false; // long 8
			if (scha5.ToString().Length > 8) return false; // long 8
			// ddiff5 float 6.2
			// sdiff5 float 6.2
			if (fwdvl.ToString().Length > 12) return false; // long 12
			if (ftradmdcha.ToString().Length > 12) return false; // long 12
			// ftradmddiff float 6.2
			if (fwsvl.ToString().Length > 12) return false; // long 12
			if (ftradmscha.ToString().Length > 12) return false; // long 12
			// ftradmsdiff float 6.2
			if (upname2?.Length > 20) return false; // char 20
			if (upcode2?.Length > 3) return false; // char 3
			// upprice2 float 7.2
			// jnilnav float 8.2
			// jnilnavsign char 1
			// jnilnavchange float 8.2
			// jnilnavdiff float 6.2
			if (etftotcap.ToString().Length > 12) return false; // long 12
			// spread float 6.2
			if (leverage.ToString().Length > 2) return false; // long 2
			// taxgubun char 1
			if (opcom_nmk?.Length > 20) return false; // char 20
			if (lp_nm1?.Length > 20) return false; // char 20
			if (lp_nm2?.Length > 20) return false; // char 20
			if (lp_nm3?.Length > 20) return false; // char 20
			if (lp_nm4?.Length > 20) return false; // char 20
			if (lp_nm5?.Length > 20) return false; // char 20
			if (etf_cp?.Length > 10) return false; // char 10
			if (etf_kind?.Length > 10) return false; // char 10
			if (vi_gubun?.Length > 10) return false; // char 10
			if (etn_kind_cd?.Length > 20) return false; // char 20
			if (lastymd?.Length > 8) return false; // char 8
			if (payday?.Length > 8) return false; // char 8
			if (lastdate?.Length > 8) return false; // char 8
			if (issuernmk?.Length > 20) return false; // char 20
			if (last_sdate?.Length > 8) return false; // char 8
			if (last_edate?.Length > 8) return false; // char 8
			if (lp_holdvol?.Length > 12) return false; // char 12
			if (listdate?.Length > 8) return false; // char 8
			// etp_gb char 1
			// etn_elback_yn char 1
			if (settletype?.Length > 2) return false; // char 2
			if (idx_asset_class1?.Length > 2) return false; // char 2
			if (ty_text?.Length > 8) return false; // char 8

			return true;
		}
	}

	/// <summary>
	/// ETF현재가(시세)조회(t1901)
	/// </summary>
	public partial class XQt1901 : XingQuery
	{
		/// <summary>
		/// t1901
		/// </summary>
		public const string _typeName = "t1901";
		/// <summary>
		/// ETF현재가(시세)조회(t1901)
		/// </summary>
		public const string _typeDesc = "ETF현재가(시세)조회(t1901)";
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
		/// t1901
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// ETF현재가(시세)조회(t1901)
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
		/// ETF현재가(시세)조회(t1901)
		/// </summary>
		public XQt1901() : base("t1901") { }


		public static XQt1901OutBlock Get(string shcode = default)
		{
			using (XQt1901 instance = new XQt1901())
			{
				instance.SetFieldData(XQt1901InBlock.BlockName, XQt1901InBlock.F.shcode, 0, shcode); // char 6

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

		public static XQt1901OutBlock ReadFromDB(string tableNamePostfix = null /*, string shcode = default */)
		{
			using (XQt1901 instance = new XQt1901())
			{

				string tableName = (tableNamePostfix == null) ? "XQt1901OutBlock" : $"XQt1901OutBlock_{tableNamePostfix}";
				QueryOption qo = new QueryOption(tableName);
				// if (shcode != default) qo.Add("shcode", shcode);


				var outBlock = instance.Select<XQt1901OutBlock>(qo);
				return outBlock;
			}
		}

		public bool SetBlock(XQt1901InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "shcode", 0, block.shcode); // char 6

			return true;
		}

		public XQt1901OutBlock GetBlock()
		{
			XQt1901OutBlock instance = XQt1901OutBlock.FromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt1901OutBlock),

		};

	}

}
