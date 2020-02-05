using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1102InBlock : XingBlock
	{
		/// <summary>
		/// t1102InBlock
		/// </summary>
		public const string _blockName = "t1102InBlock";
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
		/// t1102InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1102InBlock
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

	public partial class XQt1102OutBlock : XingBlock
	{
		/// <summary>
		/// t1102OutBlock
		/// </summary>
		public const string _blockName = "t1102OutBlock";
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
		/// t1102OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1102OutBlock
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
		/// 기준가(평가가격)
		/// </summary>
		[XAQueryFieldAttribute("기준가(평가가격)")]
		public long recprice;
		/// <summary>
		/// 가중평균
		/// </summary>
		[XAQueryFieldAttribute("가중평균")]
		public long avg;
		/// <summary>
		/// 상한가(최고호가가격)
		/// </summary>
		[XAQueryFieldAttribute("상한가(최고호가가격)")]
		public long uplmtprice;
		/// <summary>
		/// 하한가(최저호가가격)
		/// </summary>
		[XAQueryFieldAttribute("하한가(최저호가가격)")]
		public long dnlmtprice;
		/// <summary>
		/// 전일거래량
		/// </summary>
		[XAQueryFieldAttribute("전일거래량")]
		public long jnilvolume;
		/// <summary>
		/// 거래량차
		/// </summary>
		[XAQueryFieldAttribute("거래량차")]
		public long volumediff;
		/// <summary>
		/// 시가
		/// </summary>
		[XAQueryFieldAttribute("시가")]
		public long open;
		/// <summary>
		/// 시가시간
		/// </summary>
		[XAQueryFieldAttribute("시가시간")]
		public string opentime;
		/// <summary>
		/// 고가
		/// </summary>
		[XAQueryFieldAttribute("고가")]
		public long high;
		/// <summary>
		/// 고가시간
		/// </summary>
		[XAQueryFieldAttribute("고가시간")]
		public string hightime;
		/// <summary>
		/// 저가
		/// </summary>
		[XAQueryFieldAttribute("저가")]
		public long low;
		/// <summary>
		/// 저가시간
		/// </summary>
		[XAQueryFieldAttribute("저가시간")]
		public string lowtime;
		/// <summary>
		/// 52최고가
		/// </summary>
		[XAQueryFieldAttribute("52최고가")]
		public long high52w;
		/// <summary>
		/// 52최고가일
		/// </summary>
		[XAQueryFieldAttribute("52최고가일")]
		public string high52wdate;
		/// <summary>
		/// 52최저가
		/// </summary>
		[XAQueryFieldAttribute("52최저가")]
		public long low52w;
		/// <summary>
		/// 52최저가일
		/// </summary>
		[XAQueryFieldAttribute("52최저가일")]
		public string low52wdate;
		/// <summary>
		/// 소진율
		/// </summary>
		[XAQueryFieldAttribute("소진율")]
		public float exhratio;
		/// <summary>
		/// PER
		/// </summary>
		[XAQueryFieldAttribute("PER")]
		public float per;
		/// <summary>
		/// PBRX
		/// </summary>
		[XAQueryFieldAttribute("PBRX")]
		public float pbrx;
		/// <summary>
		/// 상장주식수(천)
		/// </summary>
		[XAQueryFieldAttribute("상장주식수(천)")]
		public long listing;
		/// <summary>
		/// 증거금율
		/// </summary>
		[XAQueryFieldAttribute("증거금율")]
		public long jkrate;
		/// <summary>
		/// 수량단위
		/// </summary>
		[XAQueryFieldAttribute("수량단위")]
		public string memedan;
		/// <summary>
		/// 매도증권사코드1
		/// </summary>
		[XAQueryFieldAttribute("매도증권사코드1")]
		public string offernocd1;
		/// <summary>
		/// 매수증권사코드1
		/// </summary>
		[XAQueryFieldAttribute("매수증권사코드1")]
		public string bidnocd1;
		/// <summary>
		/// 매도증권사명1
		/// </summary>
		[XAQueryFieldAttribute("매도증권사명1")]
		public string offerno1;
		/// <summary>
		/// 매수증권사명1
		/// </summary>
		[XAQueryFieldAttribute("매수증권사명1")]
		public string bidno1;
		/// <summary>
		/// 총매도수량1
		/// </summary>
		[XAQueryFieldAttribute("총매도수량1")]
		public long dvol1;
		/// <summary>
		/// 총매수수량1
		/// </summary>
		[XAQueryFieldAttribute("총매수수량1")]
		public long svol1;
		/// <summary>
		/// 매도증감1
		/// </summary>
		[XAQueryFieldAttribute("매도증감1")]
		public long dcha1;
		/// <summary>
		/// 매수증감1
		/// </summary>
		[XAQueryFieldAttribute("매수증감1")]
		public long scha1;
		/// <summary>
		/// 매도비율1
		/// </summary>
		[XAQueryFieldAttribute("매도비율1")]
		public float ddiff1;
		/// <summary>
		/// 매수비율1
		/// </summary>
		[XAQueryFieldAttribute("매수비율1")]
		public float sdiff1;
		/// <summary>
		/// 매도증권사코드2
		/// </summary>
		[XAQueryFieldAttribute("매도증권사코드2")]
		public string offernocd2;
		/// <summary>
		/// 매수증권사코드2
		/// </summary>
		[XAQueryFieldAttribute("매수증권사코드2")]
		public string bidnocd2;
		/// <summary>
		/// 매도증권사명2
		/// </summary>
		[XAQueryFieldAttribute("매도증권사명2")]
		public string offerno2;
		/// <summary>
		/// 매수증권사명2
		/// </summary>
		[XAQueryFieldAttribute("매수증권사명2")]
		public string bidno2;
		/// <summary>
		/// 총매도수량2
		/// </summary>
		[XAQueryFieldAttribute("총매도수량2")]
		public long dvol2;
		/// <summary>
		/// 총매수수량2
		/// </summary>
		[XAQueryFieldAttribute("총매수수량2")]
		public long svol2;
		/// <summary>
		/// 매도증감2
		/// </summary>
		[XAQueryFieldAttribute("매도증감2")]
		public long dcha2;
		/// <summary>
		/// 매수증감2
		/// </summary>
		[XAQueryFieldAttribute("매수증감2")]
		public long scha2;
		/// <summary>
		/// 매도비율2
		/// </summary>
		[XAQueryFieldAttribute("매도비율2")]
		public float ddiff2;
		/// <summary>
		/// 매수비율2
		/// </summary>
		[XAQueryFieldAttribute("매수비율2")]
		public float sdiff2;
		/// <summary>
		/// 매도증권사코드3
		/// </summary>
		[XAQueryFieldAttribute("매도증권사코드3")]
		public string offernocd3;
		/// <summary>
		/// 매수증권사코드3
		/// </summary>
		[XAQueryFieldAttribute("매수증권사코드3")]
		public string bidnocd3;
		/// <summary>
		/// 매도증권사명3
		/// </summary>
		[XAQueryFieldAttribute("매도증권사명3")]
		public string offerno3;
		/// <summary>
		/// 매수증권사명3
		/// </summary>
		[XAQueryFieldAttribute("매수증권사명3")]
		public string bidno3;
		/// <summary>
		/// 총매도수량3
		/// </summary>
		[XAQueryFieldAttribute("총매도수량3")]
		public long dvol3;
		/// <summary>
		/// 총매수수량3
		/// </summary>
		[XAQueryFieldAttribute("총매수수량3")]
		public long svol3;
		/// <summary>
		/// 매도증감3
		/// </summary>
		[XAQueryFieldAttribute("매도증감3")]
		public long dcha3;
		/// <summary>
		/// 매수증감3
		/// </summary>
		[XAQueryFieldAttribute("매수증감3")]
		public long scha3;
		/// <summary>
		/// 매도비율3
		/// </summary>
		[XAQueryFieldAttribute("매도비율3")]
		public float ddiff3;
		/// <summary>
		/// 매수비율3
		/// </summary>
		[XAQueryFieldAttribute("매수비율3")]
		public float sdiff3;
		/// <summary>
		/// 매도증권사코드4
		/// </summary>
		[XAQueryFieldAttribute("매도증권사코드4")]
		public string offernocd4;
		/// <summary>
		/// 매수증권사코드4
		/// </summary>
		[XAQueryFieldAttribute("매수증권사코드4")]
		public string bidnocd4;
		/// <summary>
		/// 매도증권사명4
		/// </summary>
		[XAQueryFieldAttribute("매도증권사명4")]
		public string offerno4;
		/// <summary>
		/// 매수증권사명4
		/// </summary>
		[XAQueryFieldAttribute("매수증권사명4")]
		public string bidno4;
		/// <summary>
		/// 총매도수량4
		/// </summary>
		[XAQueryFieldAttribute("총매도수량4")]
		public long dvol4;
		/// <summary>
		/// 총매수수량4
		/// </summary>
		[XAQueryFieldAttribute("총매수수량4")]
		public long svol4;
		/// <summary>
		/// 매도증감4
		/// </summary>
		[XAQueryFieldAttribute("매도증감4")]
		public long dcha4;
		/// <summary>
		/// 매수증감4
		/// </summary>
		[XAQueryFieldAttribute("매수증감4")]
		public long scha4;
		/// <summary>
		/// 매도비율4
		/// </summary>
		[XAQueryFieldAttribute("매도비율4")]
		public float ddiff4;
		/// <summary>
		/// 매수비율4
		/// </summary>
		[XAQueryFieldAttribute("매수비율4")]
		public float sdiff4;
		/// <summary>
		/// 매도증권사코드5
		/// </summary>
		[XAQueryFieldAttribute("매도증권사코드5")]
		public string offernocd5;
		/// <summary>
		/// 매수증권사코드5
		/// </summary>
		[XAQueryFieldAttribute("매수증권사코드5")]
		public string bidnocd5;
		/// <summary>
		/// 매도증권사명5
		/// </summary>
		[XAQueryFieldAttribute("매도증권사명5")]
		public string offerno5;
		/// <summary>
		/// 매수증권사명5
		/// </summary>
		[XAQueryFieldAttribute("매수증권사명5")]
		public string bidno5;
		/// <summary>
		/// 총매도수량5
		/// </summary>
		[XAQueryFieldAttribute("총매도수량5")]
		public long dvol5;
		/// <summary>
		/// 총매수수량5
		/// </summary>
		[XAQueryFieldAttribute("총매수수량5")]
		public long svol5;
		/// <summary>
		/// 매도증감5
		/// </summary>
		[XAQueryFieldAttribute("매도증감5")]
		public long dcha5;
		/// <summary>
		/// 매수증감5
		/// </summary>
		[XAQueryFieldAttribute("매수증감5")]
		public long scha5;
		/// <summary>
		/// 매도비율5
		/// </summary>
		[XAQueryFieldAttribute("매도비율5")]
		public float ddiff5;
		/// <summary>
		/// 매수비율5
		/// </summary>
		[XAQueryFieldAttribute("매수비율5")]
		public float sdiff5;
		/// <summary>
		/// 외국계매도합계수량
		/// </summary>
		[XAQueryFieldAttribute("외국계매도합계수량")]
		public long fwdvl;
		/// <summary>
		/// 외국계매도직전대비
		/// </summary>
		[XAQueryFieldAttribute("외국계매도직전대비")]
		public long ftradmdcha;
		/// <summary>
		/// 외국계매도비율
		/// </summary>
		[XAQueryFieldAttribute("외국계매도비율")]
		public float ftradmddiff;
		/// <summary>
		/// 외국계매수합계수량
		/// </summary>
		[XAQueryFieldAttribute("외국계매수합계수량")]
		public long fwsvl;
		/// <summary>
		/// 외국계매수직전대비
		/// </summary>
		[XAQueryFieldAttribute("외국계매수직전대비")]
		public long ftradmscha;
		/// <summary>
		/// 외국계매수비율
		/// </summary>
		[XAQueryFieldAttribute("외국계매수비율")]
		public float ftradmsdiff;
		/// <summary>
		/// 회전율
		/// </summary>
		[XAQueryFieldAttribute("회전율")]
		public float vol;
		/// <summary>
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("단축코드")]
		public string shcode;
		/// <summary>
		/// 누적거래대금
		/// </summary>
		[XAQueryFieldAttribute("누적거래대금")]
		public long value;
		/// <summary>
		/// 전일동시간거래량
		/// </summary>
		[XAQueryFieldAttribute("전일동시간거래량")]
		public long jvolume;
		/// <summary>
		/// 연중최고가
		/// </summary>
		[XAQueryFieldAttribute("연중최고가")]
		public long highyear;
		/// <summary>
		/// 연중최고일자
		/// </summary>
		[XAQueryFieldAttribute("연중최고일자")]
		public string highyeardate;
		/// <summary>
		/// 연중최저가
		/// </summary>
		[XAQueryFieldAttribute("연중최저가")]
		public long lowyear;
		/// <summary>
		/// 연중최저일자
		/// </summary>
		[XAQueryFieldAttribute("연중최저일자")]
		public string lowyeardate;
		/// <summary>
		/// 목표가
		/// </summary>
		[XAQueryFieldAttribute("목표가")]
		public long target;
		/// <summary>
		/// 자본금
		/// </summary>
		[XAQueryFieldAttribute("자본금")]
		public long capital;
		/// <summary>
		/// 유동주식수
		/// </summary>
		[XAQueryFieldAttribute("유동주식수")]
		public long abscnt;
		/// <summary>
		/// 액면가
		/// </summary>
		[XAQueryFieldAttribute("액면가")]
		public long parprice;
		/// <summary>
		/// 결산월
		/// </summary>
		[XAQueryFieldAttribute("결산월")]
		public string gsmm;
		/// <summary>
		/// 대용가
		/// </summary>
		[XAQueryFieldAttribute("대용가")]
		public long subprice;
		/// <summary>
		/// 시가총액
		/// </summary>
		[XAQueryFieldAttribute("시가총액")]
		public long total;
		/// <summary>
		/// 상장일
		/// </summary>
		[XAQueryFieldAttribute("상장일")]
		public string listdate;
		/// <summary>
		/// 전분기명
		/// </summary>
		[XAQueryFieldAttribute("전분기명")]
		public string name;
		/// <summary>
		/// 전분기매출액
		/// </summary>
		[XAQueryFieldAttribute("전분기매출액")]
		public long bfsales;
		/// <summary>
		/// 전분기영업이익
		/// </summary>
		[XAQueryFieldAttribute("전분기영업이익")]
		public long bfoperatingincome;
		/// <summary>
		/// 전분기경상이익
		/// </summary>
		[XAQueryFieldAttribute("전분기경상이익")]
		public long bfordinaryincome;
		/// <summary>
		/// 전분기순이익
		/// </summary>
		[XAQueryFieldAttribute("전분기순이익")]
		public long bfnetincome;
		/// <summary>
		/// 전분기EPS
		/// </summary>
		[XAQueryFieldAttribute("전분기EPS")]
		public float bfeps;
		/// <summary>
		/// 전전분기명
		/// </summary>
		[XAQueryFieldAttribute("전전분기명")]
		public string name2;
		/// <summary>
		/// 전전분기매출액
		/// </summary>
		[XAQueryFieldAttribute("전전분기매출액")]
		public long bfsales2;
		/// <summary>
		/// 전전분기영업이익
		/// </summary>
		[XAQueryFieldAttribute("전전분기영업이익")]
		public long bfoperatingincome2;
		/// <summary>
		/// 전전분기경상이익
		/// </summary>
		[XAQueryFieldAttribute("전전분기경상이익")]
		public long bfordinaryincome2;
		/// <summary>
		/// 전전분기순이익
		/// </summary>
		[XAQueryFieldAttribute("전전분기순이익")]
		public long bfnetincome2;
		/// <summary>
		/// 전전분기EPS
		/// </summary>
		[XAQueryFieldAttribute("전전분기EPS")]
		public float bfeps2;
		/// <summary>
		/// 전년대비매출액
		/// </summary>
		[XAQueryFieldAttribute("전년대비매출액")]
		public float salert;
		/// <summary>
		/// 전년대비영업이익
		/// </summary>
		[XAQueryFieldAttribute("전년대비영업이익")]
		public float opert;
		/// <summary>
		/// 전년대비경상이익
		/// </summary>
		[XAQueryFieldAttribute("전년대비경상이익")]
		public float ordrt;
		/// <summary>
		/// 전년대비순이익
		/// </summary>
		[XAQueryFieldAttribute("전년대비순이익")]
		public float netrt;
		/// <summary>
		/// 전년대비EPS
		/// </summary>
		[XAQueryFieldAttribute("전년대비EPS")]
		public float epsrt;
		/// <summary>
		/// 락구분
		/// </summary>
		[XAQueryFieldAttribute("락구분")]
		public string info1;
		/// <summary>
		/// 관리/급등구분
		/// </summary>
		[XAQueryFieldAttribute("관리/급등구분")]
		public string info2;
		/// <summary>
		/// 정지/연장구분
		/// </summary>
		[XAQueryFieldAttribute("정지/연장구분")]
		public string info3;
		/// <summary>
		/// 투자/불성실구분
		/// </summary>
		[XAQueryFieldAttribute("투자/불성실구분")]
		public string info4;
		/// <summary>
		/// 장구분
		/// </summary>
		[XAQueryFieldAttribute("장구분")]
		public string janginfo;
		/// <summary>
		/// T.PER
		/// </summary>
		[XAQueryFieldAttribute("T.PER")]
		public float t_per;
		/// <summary>
		/// 통화ISO코드
		/// </summary>
		[XAQueryFieldAttribute("통화ISO코드")]
		public string tonghwa;
		/// <summary>
		/// 총매도대금1
		/// </summary>
		[XAQueryFieldAttribute("총매도대금1")]
		public long dval1;
		/// <summary>
		/// 총매수대금1
		/// </summary>
		[XAQueryFieldAttribute("총매수대금1")]
		public long sval1;
		/// <summary>
		/// 총매도대금2
		/// </summary>
		[XAQueryFieldAttribute("총매도대금2")]
		public long dval2;
		/// <summary>
		/// 총매수대금2
		/// </summary>
		[XAQueryFieldAttribute("총매수대금2")]
		public long sval2;
		/// <summary>
		/// 총매도대금3
		/// </summary>
		[XAQueryFieldAttribute("총매도대금3")]
		public long dval3;
		/// <summary>
		/// 총매수대금3
		/// </summary>
		[XAQueryFieldAttribute("총매수대금3")]
		public long sval3;
		/// <summary>
		/// 총매도대금4
		/// </summary>
		[XAQueryFieldAttribute("총매도대금4")]
		public long dval4;
		/// <summary>
		/// 총매수대금4
		/// </summary>
		[XAQueryFieldAttribute("총매수대금4")]
		public long sval4;
		/// <summary>
		/// 총매도대금5
		/// </summary>
		[XAQueryFieldAttribute("총매도대금5")]
		public long dval5;
		/// <summary>
		/// 총매수대금5
		/// </summary>
		[XAQueryFieldAttribute("총매수대금5")]
		public long sval5;
		/// <summary>
		/// 총매도평단가1
		/// </summary>
		[XAQueryFieldAttribute("총매도평단가1")]
		public long davg1;
		/// <summary>
		/// 총매수평단가1
		/// </summary>
		[XAQueryFieldAttribute("총매수평단가1")]
		public long savg1;
		/// <summary>
		/// 총매도평단가2
		/// </summary>
		[XAQueryFieldAttribute("총매도평단가2")]
		public long davg2;
		/// <summary>
		/// 총매수평단가2
		/// </summary>
		[XAQueryFieldAttribute("총매수평단가2")]
		public long savg2;
		/// <summary>
		/// 총매도평단가3
		/// </summary>
		[XAQueryFieldAttribute("총매도평단가3")]
		public long davg3;
		/// <summary>
		/// 총매수평단가3
		/// </summary>
		[XAQueryFieldAttribute("총매수평단가3")]
		public long savg3;
		/// <summary>
		/// 총매도평단가4
		/// </summary>
		[XAQueryFieldAttribute("총매도평단가4")]
		public long davg4;
		/// <summary>
		/// 총매수평단가4
		/// </summary>
		[XAQueryFieldAttribute("총매수평단가4")]
		public long savg4;
		/// <summary>
		/// 총매도평단가5
		/// </summary>
		[XAQueryFieldAttribute("총매도평단가5")]
		public long davg5;
		/// <summary>
		/// 총매수평단가5
		/// </summary>
		[XAQueryFieldAttribute("총매수평단가5")]
		public long savg5;
		/// <summary>
		/// 외국계매도대금
		/// </summary>
		[XAQueryFieldAttribute("외국계매도대금")]
		public long ftradmdval;
		/// <summary>
		/// 외국계매수대금
		/// </summary>
		[XAQueryFieldAttribute("외국계매수대금")]
		public long ftradmsval;
		/// <summary>
		/// 외국계매도평단가
		/// </summary>
		[XAQueryFieldAttribute("외국계매도평단가")]
		public long ftradmdavg;
		/// <summary>
		/// 외국계매수평단가
		/// </summary>
		[XAQueryFieldAttribute("외국계매수평단가")]
		public long ftradmsavg;
		/// <summary>
		/// 투자주의환기
		/// </summary>
		[XAQueryFieldAttribute("투자주의환기")]
		public string info5;
		/// <summary>
		/// 기업인수목적회사여부
		/// </summary>
		[XAQueryFieldAttribute("기업인수목적회사여부")]
		public char spac_gubun;
		/// <summary>
		/// 발행가격
		/// </summary>
		[XAQueryFieldAttribute("발행가격")]
		public long issueprice;
		/// <summary>
		/// 배분적용구분코드(1:배분발생2:배분해제그외:미발생)
		/// </summary>
		[XAQueryFieldAttribute("배분적용구분코드(1:배분발생2:배분해제그외:미발생)")]
		public char alloc_gubun;
		/// <summary>
		/// 배분적용구분
		/// </summary>
		[XAQueryFieldAttribute("배분적용구분")]
		public string alloc_text;
		/// <summary>
		/// 단기과열/VI발동
		/// </summary>
		[XAQueryFieldAttribute("단기과열/VI발동")]
		public string shterm_text;
		/// <summary>
		/// 정적VI상한가
		/// </summary>
		[XAQueryFieldAttribute("정적VI상한가")]
		public long svi_uplmtprice;
		/// <summary>
		/// 정적VI하한가
		/// </summary>
		[XAQueryFieldAttribute("정적VI하한가")]
		public long svi_dnlmtprice;
		/// <summary>
		/// 저유동성종목여부
		/// </summary>
		[XAQueryFieldAttribute("저유동성종목여부")]
		public char low_lqdt_gu;
		/// <summary>
		/// 이상급등종목여부
		/// </summary>
		[XAQueryFieldAttribute("이상급등종목여부")]
		public char abnormal_rise_gu;
		/// <summary>
		/// 대차불가표시
		/// </summary>
		[XAQueryFieldAttribute("대차불가표시")]
		public string lend_text;

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
			/// 기준가(평가가격)
			/// </summary>
			public const string recprice = "recprice";
			/// <summary>
			/// 가중평균
			/// </summary>
			public const string avg = "avg";
			/// <summary>
			/// 상한가(최고호가가격)
			/// </summary>
			public const string uplmtprice = "uplmtprice";
			/// <summary>
			/// 하한가(최저호가가격)
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
			/// PER
			/// </summary>
			public const string per = "per";
			/// <summary>
			/// PBRX
			/// </summary>
			public const string pbrx = "pbrx";
			/// <summary>
			/// 상장주식수(천)
			/// </summary>
			public const string listing = "listing";
			/// <summary>
			/// 증거금율
			/// </summary>
			public const string jkrate = "jkrate";
			/// <summary>
			/// 수량단위
			/// </summary>
			public const string memedan = "memedan";
			/// <summary>
			/// 매도증권사코드1
			/// </summary>
			public const string offernocd1 = "offernocd1";
			/// <summary>
			/// 매수증권사코드1
			/// </summary>
			public const string bidnocd1 = "bidnocd1";
			/// <summary>
			/// 매도증권사명1
			/// </summary>
			public const string offerno1 = "offerno1";
			/// <summary>
			/// 매수증권사명1
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
			public const string offernocd2 = "offernocd2";
			/// <summary>
			/// 매수증권사코드2
			/// </summary>
			public const string bidnocd2 = "bidnocd2";
			/// <summary>
			/// 매도증권사명2
			/// </summary>
			public const string offerno2 = "offerno2";
			/// <summary>
			/// 매수증권사명2
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
			public const string offernocd3 = "offernocd3";
			/// <summary>
			/// 매수증권사코드3
			/// </summary>
			public const string bidnocd3 = "bidnocd3";
			/// <summary>
			/// 매도증권사명3
			/// </summary>
			public const string offerno3 = "offerno3";
			/// <summary>
			/// 매수증권사명3
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
			public const string offernocd4 = "offernocd4";
			/// <summary>
			/// 매수증권사코드4
			/// </summary>
			public const string bidnocd4 = "bidnocd4";
			/// <summary>
			/// 매도증권사명4
			/// </summary>
			public const string offerno4 = "offerno4";
			/// <summary>
			/// 매수증권사명4
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
			public const string offernocd5 = "offernocd5";
			/// <summary>
			/// 매수증권사코드5
			/// </summary>
			public const string bidnocd5 = "bidnocd5";
			/// <summary>
			/// 매도증권사명5
			/// </summary>
			public const string offerno5 = "offerno5";
			/// <summary>
			/// 매수증권사명5
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
			/// 전일동시간거래량
			/// </summary>
			public const string jvolume = "jvolume";
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
			/// 목표가
			/// </summary>
			public const string target = "target";
			/// <summary>
			/// 자본금
			/// </summary>
			public const string capital = "capital";
			/// <summary>
			/// 유동주식수
			/// </summary>
			public const string abscnt = "abscnt";
			/// <summary>
			/// 액면가
			/// </summary>
			public const string parprice = "parprice";
			/// <summary>
			/// 결산월
			/// </summary>
			public const string gsmm = "gsmm";
			/// <summary>
			/// 대용가
			/// </summary>
			public const string subprice = "subprice";
			/// <summary>
			/// 시가총액
			/// </summary>
			public const string total = "total";
			/// <summary>
			/// 상장일
			/// </summary>
			public const string listdate = "listdate";
			/// <summary>
			/// 전분기명
			/// </summary>
			public const string name = "name";
			/// <summary>
			/// 전분기매출액
			/// </summary>
			public const string bfsales = "bfsales";
			/// <summary>
			/// 전분기영업이익
			/// </summary>
			public const string bfoperatingincome = "bfoperatingincome";
			/// <summary>
			/// 전분기경상이익
			/// </summary>
			public const string bfordinaryincome = "bfordinaryincome";
			/// <summary>
			/// 전분기순이익
			/// </summary>
			public const string bfnetincome = "bfnetincome";
			/// <summary>
			/// 전분기EPS
			/// </summary>
			public const string bfeps = "bfeps";
			/// <summary>
			/// 전전분기명
			/// </summary>
			public const string name2 = "name2";
			/// <summary>
			/// 전전분기매출액
			/// </summary>
			public const string bfsales2 = "bfsales2";
			/// <summary>
			/// 전전분기영업이익
			/// </summary>
			public const string bfoperatingincome2 = "bfoperatingincome2";
			/// <summary>
			/// 전전분기경상이익
			/// </summary>
			public const string bfordinaryincome2 = "bfordinaryincome2";
			/// <summary>
			/// 전전분기순이익
			/// </summary>
			public const string bfnetincome2 = "bfnetincome2";
			/// <summary>
			/// 전전분기EPS
			/// </summary>
			public const string bfeps2 = "bfeps2";
			/// <summary>
			/// 전년대비매출액
			/// </summary>
			public const string salert = "salert";
			/// <summary>
			/// 전년대비영업이익
			/// </summary>
			public const string opert = "opert";
			/// <summary>
			/// 전년대비경상이익
			/// </summary>
			public const string ordrt = "ordrt";
			/// <summary>
			/// 전년대비순이익
			/// </summary>
			public const string netrt = "netrt";
			/// <summary>
			/// 전년대비EPS
			/// </summary>
			public const string epsrt = "epsrt";
			/// <summary>
			/// 락구분
			/// </summary>
			public const string info1 = "info1";
			/// <summary>
			/// 관리/급등구분
			/// </summary>
			public const string info2 = "info2";
			/// <summary>
			/// 정지/연장구분
			/// </summary>
			public const string info3 = "info3";
			/// <summary>
			/// 투자/불성실구분
			/// </summary>
			public const string info4 = "info4";
			/// <summary>
			/// 장구분
			/// </summary>
			public const string janginfo = "janginfo";
			/// <summary>
			/// T.PER
			/// </summary>
			public const string t_per = "t_per";
			/// <summary>
			/// 통화ISO코드
			/// </summary>
			public const string tonghwa = "tonghwa";
			/// <summary>
			/// 총매도대금1
			/// </summary>
			public const string dval1 = "dval1";
			/// <summary>
			/// 총매수대금1
			/// </summary>
			public const string sval1 = "sval1";
			/// <summary>
			/// 총매도대금2
			/// </summary>
			public const string dval2 = "dval2";
			/// <summary>
			/// 총매수대금2
			/// </summary>
			public const string sval2 = "sval2";
			/// <summary>
			/// 총매도대금3
			/// </summary>
			public const string dval3 = "dval3";
			/// <summary>
			/// 총매수대금3
			/// </summary>
			public const string sval3 = "sval3";
			/// <summary>
			/// 총매도대금4
			/// </summary>
			public const string dval4 = "dval4";
			/// <summary>
			/// 총매수대금4
			/// </summary>
			public const string sval4 = "sval4";
			/// <summary>
			/// 총매도대금5
			/// </summary>
			public const string dval5 = "dval5";
			/// <summary>
			/// 총매수대금5
			/// </summary>
			public const string sval5 = "sval5";
			/// <summary>
			/// 총매도평단가1
			/// </summary>
			public const string davg1 = "davg1";
			/// <summary>
			/// 총매수평단가1
			/// </summary>
			public const string savg1 = "savg1";
			/// <summary>
			/// 총매도평단가2
			/// </summary>
			public const string davg2 = "davg2";
			/// <summary>
			/// 총매수평단가2
			/// </summary>
			public const string savg2 = "savg2";
			/// <summary>
			/// 총매도평단가3
			/// </summary>
			public const string davg3 = "davg3";
			/// <summary>
			/// 총매수평단가3
			/// </summary>
			public const string savg3 = "savg3";
			/// <summary>
			/// 총매도평단가4
			/// </summary>
			public const string davg4 = "davg4";
			/// <summary>
			/// 총매수평단가4
			/// </summary>
			public const string savg4 = "savg4";
			/// <summary>
			/// 총매도평단가5
			/// </summary>
			public const string davg5 = "davg5";
			/// <summary>
			/// 총매수평단가5
			/// </summary>
			public const string savg5 = "savg5";
			/// <summary>
			/// 외국계매도대금
			/// </summary>
			public const string ftradmdval = "ftradmdval";
			/// <summary>
			/// 외국계매수대금
			/// </summary>
			public const string ftradmsval = "ftradmsval";
			/// <summary>
			/// 외국계매도평단가
			/// </summary>
			public const string ftradmdavg = "ftradmdavg";
			/// <summary>
			/// 외국계매수평단가
			/// </summary>
			public const string ftradmsavg = "ftradmsavg";
			/// <summary>
			/// 투자주의환기
			/// </summary>
			public const string info5 = "info5";
			/// <summary>
			/// 기업인수목적회사여부
			/// </summary>
			public const string spac_gubun = "spac_gubun";
			/// <summary>
			/// 발행가격
			/// </summary>
			public const string issueprice = "issueprice";
			/// <summary>
			/// 배분적용구분코드(1:배분발생2:배분해제그외:미발생)
			/// </summary>
			public const string alloc_gubun = "alloc_gubun";
			/// <summary>
			/// 배분적용구분
			/// </summary>
			public const string alloc_text = "alloc_text";
			/// <summary>
			/// 단기과열/VI발동
			/// </summary>
			public const string shterm_text = "shterm_text";
			/// <summary>
			/// 정적VI상한가
			/// </summary>
			public const string svi_uplmtprice = "svi_uplmtprice";
			/// <summary>
			/// 정적VI하한가
			/// </summary>
			public const string svi_dnlmtprice = "svi_dnlmtprice";
			/// <summary>
			/// 저유동성종목여부
			/// </summary>
			public const string low_lqdt_gu = "low_lqdt_gu";
			/// <summary>
			/// 이상급등종목여부
			/// </summary>
			public const string abnormal_rise_gu = "abnormal_rise_gu";
			/// <summary>
			/// 대차불가표시
			/// </summary>
			public const string lend_text = "lend_text";
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
			F.per,
			F.pbrx,
			F.listing,
			F.jkrate,
			F.memedan,
			F.offernocd1,
			F.bidnocd1,
			F.offerno1,
			F.bidno1,
			F.dvol1,
			F.svol1,
			F.dcha1,
			F.scha1,
			F.ddiff1,
			F.sdiff1,
			F.offernocd2,
			F.bidnocd2,
			F.offerno2,
			F.bidno2,
			F.dvol2,
			F.svol2,
			F.dcha2,
			F.scha2,
			F.ddiff2,
			F.sdiff2,
			F.offernocd3,
			F.bidnocd3,
			F.offerno3,
			F.bidno3,
			F.dvol3,
			F.svol3,
			F.dcha3,
			F.scha3,
			F.ddiff3,
			F.sdiff3,
			F.offernocd4,
			F.bidnocd4,
			F.offerno4,
			F.bidno4,
			F.dvol4,
			F.svol4,
			F.dcha4,
			F.scha4,
			F.ddiff4,
			F.sdiff4,
			F.offernocd5,
			F.bidnocd5,
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
			F.vol,
			F.shcode,
			F.value,
			F.jvolume,
			F.highyear,
			F.highyeardate,
			F.lowyear,
			F.lowyeardate,
			F.target,
			F.capital,
			F.abscnt,
			F.parprice,
			F.gsmm,
			F.subprice,
			F.total,
			F.listdate,
			F.name,
			F.bfsales,
			F.bfoperatingincome,
			F.bfordinaryincome,
			F.bfnetincome,
			F.bfeps,
			F.name2,
			F.bfsales2,
			F.bfoperatingincome2,
			F.bfordinaryincome2,
			F.bfnetincome2,
			F.bfeps2,
			F.salert,
			F.opert,
			F.ordrt,
			F.netrt,
			F.epsrt,
			F.info1,
			F.info2,
			F.info3,
			F.info4,
			F.janginfo,
			F.t_per,
			F.tonghwa,
			F.dval1,
			F.sval1,
			F.dval2,
			F.sval2,
			F.dval3,
			F.sval3,
			F.dval4,
			F.sval4,
			F.dval5,
			F.sval5,
			F.davg1,
			F.savg1,
			F.davg2,
			F.savg2,
			F.davg3,
			F.savg3,
			F.davg4,
			F.savg4,
			F.davg5,
			F.savg5,
			F.ftradmdval,
			F.ftradmsval,
			F.ftradmdavg,
			F.ftradmsavg,
			F.info5,
			F.spac_gubun,
			F.issueprice,
			F.alloc_gubun,
			F.alloc_text,
			F.shterm_text,
			F.svi_uplmtprice,
			F.svi_dnlmtprice,
			F.low_lqdt_gu,
			F.abnormal_rise_gu,
			F.lend_text,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["hname"] = new XAQueryFieldInfo("char", hname, hname, "한글명", (decimal)20);
			dict["price"] = new XAQueryFieldInfo("long", price, price.ToString("d8"), "현재가", (decimal)8);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("long", change, change.ToString("d8"), "전일대비", (decimal)8);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "누적거래량", (decimal)12);
			dict["recprice"] = new XAQueryFieldInfo("long", recprice, recprice.ToString("d8"), "기준가(평가가격)", (decimal)8);
			dict["avg"] = new XAQueryFieldInfo("long", avg, avg.ToString("d8"), "가중평균", (decimal)8);
			dict["uplmtprice"] = new XAQueryFieldInfo("long", uplmtprice, uplmtprice.ToString("d8"), "상한가(최고호가가격)", (decimal)8);
			dict["dnlmtprice"] = new XAQueryFieldInfo("long", dnlmtprice, dnlmtprice.ToString("d8"), "하한가(최저호가가격)", (decimal)8);
			dict["jnilvolume"] = new XAQueryFieldInfo("long", jnilvolume, jnilvolume.ToString("d12"), "전일거래량", (decimal)12);
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
			dict["per"] = new XAQueryFieldInfo("float", per, per.ToString("000000.00"), "PER", (decimal)6.2);
			dict["pbrx"] = new XAQueryFieldInfo("float", pbrx, pbrx.ToString("000000.00"), "PBRX", (decimal)6.2);
			dict["listing"] = new XAQueryFieldInfo("long", listing, listing.ToString("d12"), "상장주식수(천)", (decimal)12);
			dict["jkrate"] = new XAQueryFieldInfo("long", jkrate, jkrate.ToString("d8"), "증거금율", (decimal)8);
			dict["memedan"] = new XAQueryFieldInfo("char", memedan, memedan, "수량단위", (decimal)5);
			dict["offernocd1"] = new XAQueryFieldInfo("char", offernocd1, offernocd1, "매도증권사코드1", (decimal)3);
			dict["bidnocd1"] = new XAQueryFieldInfo("char", bidnocd1, bidnocd1, "매수증권사코드1", (decimal)3);
			dict["offerno1"] = new XAQueryFieldInfo("char", offerno1, offerno1, "매도증권사명1", (decimal)6);
			dict["bidno1"] = new XAQueryFieldInfo("char", bidno1, bidno1, "매수증권사명1", (decimal)6);
			dict["dvol1"] = new XAQueryFieldInfo("long", dvol1, dvol1.ToString("d8"), "총매도수량1", (decimal)8);
			dict["svol1"] = new XAQueryFieldInfo("long", svol1, svol1.ToString("d8"), "총매수수량1", (decimal)8);
			dict["dcha1"] = new XAQueryFieldInfo("long", dcha1, dcha1.ToString("d8"), "매도증감1", (decimal)8);
			dict["scha1"] = new XAQueryFieldInfo("long", scha1, scha1.ToString("d8"), "매수증감1", (decimal)8);
			dict["ddiff1"] = new XAQueryFieldInfo("float", ddiff1, ddiff1.ToString("000000.00"), "매도비율1", (decimal)6.2);
			dict["sdiff1"] = new XAQueryFieldInfo("float", sdiff1, sdiff1.ToString("000000.00"), "매수비율1", (decimal)6.2);
			dict["offernocd2"] = new XAQueryFieldInfo("char", offernocd2, offernocd2, "매도증권사코드2", (decimal)3);
			dict["bidnocd2"] = new XAQueryFieldInfo("char", bidnocd2, bidnocd2, "매수증권사코드2", (decimal)3);
			dict["offerno2"] = new XAQueryFieldInfo("char", offerno2, offerno2, "매도증권사명2", (decimal)6);
			dict["bidno2"] = new XAQueryFieldInfo("char", bidno2, bidno2, "매수증권사명2", (decimal)6);
			dict["dvol2"] = new XAQueryFieldInfo("long", dvol2, dvol2.ToString("d8"), "총매도수량2", (decimal)8);
			dict["svol2"] = new XAQueryFieldInfo("long", svol2, svol2.ToString("d8"), "총매수수량2", (decimal)8);
			dict["dcha2"] = new XAQueryFieldInfo("long", dcha2, dcha2.ToString("d8"), "매도증감2", (decimal)8);
			dict["scha2"] = new XAQueryFieldInfo("long", scha2, scha2.ToString("d8"), "매수증감2", (decimal)8);
			dict["ddiff2"] = new XAQueryFieldInfo("float", ddiff2, ddiff2.ToString("000000.00"), "매도비율2", (decimal)6.2);
			dict["sdiff2"] = new XAQueryFieldInfo("float", sdiff2, sdiff2.ToString("000000.00"), "매수비율2", (decimal)6.2);
			dict["offernocd3"] = new XAQueryFieldInfo("char", offernocd3, offernocd3, "매도증권사코드3", (decimal)3);
			dict["bidnocd3"] = new XAQueryFieldInfo("char", bidnocd3, bidnocd3, "매수증권사코드3", (decimal)3);
			dict["offerno3"] = new XAQueryFieldInfo("char", offerno3, offerno3, "매도증권사명3", (decimal)6);
			dict["bidno3"] = new XAQueryFieldInfo("char", bidno3, bidno3, "매수증권사명3", (decimal)6);
			dict["dvol3"] = new XAQueryFieldInfo("long", dvol3, dvol3.ToString("d8"), "총매도수량3", (decimal)8);
			dict["svol3"] = new XAQueryFieldInfo("long", svol3, svol3.ToString("d8"), "총매수수량3", (decimal)8);
			dict["dcha3"] = new XAQueryFieldInfo("long", dcha3, dcha3.ToString("d8"), "매도증감3", (decimal)8);
			dict["scha3"] = new XAQueryFieldInfo("long", scha3, scha3.ToString("d8"), "매수증감3", (decimal)8);
			dict["ddiff3"] = new XAQueryFieldInfo("float", ddiff3, ddiff3.ToString("000000.00"), "매도비율3", (decimal)6.2);
			dict["sdiff3"] = new XAQueryFieldInfo("float", sdiff3, sdiff3.ToString("000000.00"), "매수비율3", (decimal)6.2);
			dict["offernocd4"] = new XAQueryFieldInfo("char", offernocd4, offernocd4, "매도증권사코드4", (decimal)3);
			dict["bidnocd4"] = new XAQueryFieldInfo("char", bidnocd4, bidnocd4, "매수증권사코드4", (decimal)3);
			dict["offerno4"] = new XAQueryFieldInfo("char", offerno4, offerno4, "매도증권사명4", (decimal)6);
			dict["bidno4"] = new XAQueryFieldInfo("char", bidno4, bidno4, "매수증권사명4", (decimal)6);
			dict["dvol4"] = new XAQueryFieldInfo("long", dvol4, dvol4.ToString("d8"), "총매도수량4", (decimal)8);
			dict["svol4"] = new XAQueryFieldInfo("long", svol4, svol4.ToString("d8"), "총매수수량4", (decimal)8);
			dict["dcha4"] = new XAQueryFieldInfo("long", dcha4, dcha4.ToString("d8"), "매도증감4", (decimal)8);
			dict["scha4"] = new XAQueryFieldInfo("long", scha4, scha4.ToString("d8"), "매수증감4", (decimal)8);
			dict["ddiff4"] = new XAQueryFieldInfo("float", ddiff4, ddiff4.ToString("000000.00"), "매도비율4", (decimal)6.2);
			dict["sdiff4"] = new XAQueryFieldInfo("float", sdiff4, sdiff4.ToString("000000.00"), "매수비율4", (decimal)6.2);
			dict["offernocd5"] = new XAQueryFieldInfo("char", offernocd5, offernocd5, "매도증권사코드5", (decimal)3);
			dict["bidnocd5"] = new XAQueryFieldInfo("char", bidnocd5, bidnocd5, "매수증권사코드5", (decimal)3);
			dict["offerno5"] = new XAQueryFieldInfo("char", offerno5, offerno5, "매도증권사명5", (decimal)6);
			dict["bidno5"] = new XAQueryFieldInfo("char", bidno5, bidno5, "매수증권사명5", (decimal)6);
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
			dict["vol"] = new XAQueryFieldInfo("float", vol, vol.ToString("000000.00"), "회전율", (decimal)6.2);
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)6);
			dict["value"] = new XAQueryFieldInfo("long", value, value.ToString("d12"), "누적거래대금", (decimal)12);
			dict["jvolume"] = new XAQueryFieldInfo("long", jvolume, jvolume.ToString("d12"), "전일동시간거래량", (decimal)12);
			dict["highyear"] = new XAQueryFieldInfo("long", highyear, highyear.ToString("d8"), "연중최고가", (decimal)8);
			dict["highyeardate"] = new XAQueryFieldInfo("char", highyeardate, highyeardate, "연중최고일자", (decimal)8);
			dict["lowyear"] = new XAQueryFieldInfo("long", lowyear, lowyear.ToString("d8"), "연중최저가", (decimal)8);
			dict["lowyeardate"] = new XAQueryFieldInfo("char", lowyeardate, lowyeardate, "연중최저일자", (decimal)8);
			dict["target"] = new XAQueryFieldInfo("long", target, target.ToString("d8"), "목표가", (decimal)8);
			dict["capital"] = new XAQueryFieldInfo("long", capital, capital.ToString("d12"), "자본금", (decimal)12);
			dict["abscnt"] = new XAQueryFieldInfo("long", abscnt, abscnt.ToString("d12"), "유동주식수", (decimal)12);
			dict["parprice"] = new XAQueryFieldInfo("long", parprice, parprice.ToString("d8"), "액면가", (decimal)8);
			dict["gsmm"] = new XAQueryFieldInfo("char", gsmm, gsmm, "결산월", (decimal)2);
			dict["subprice"] = new XAQueryFieldInfo("long", subprice, subprice.ToString("d8"), "대용가", (decimal)8);
			dict["total"] = new XAQueryFieldInfo("long", total, total.ToString("d12"), "시가총액", (decimal)12);
			dict["listdate"] = new XAQueryFieldInfo("char", listdate, listdate, "상장일", (decimal)8);
			dict["name"] = new XAQueryFieldInfo("char", name, name, "전분기명", (decimal)10);
			dict["bfsales"] = new XAQueryFieldInfo("long", bfsales, bfsales.ToString("d12"), "전분기매출액", (decimal)12);
			dict["bfoperatingincome"] = new XAQueryFieldInfo("long", bfoperatingincome, bfoperatingincome.ToString("d12"), "전분기영업이익", (decimal)12);
			dict["bfordinaryincome"] = new XAQueryFieldInfo("long", bfordinaryincome, bfordinaryincome.ToString("d12"), "전분기경상이익", (decimal)12);
			dict["bfnetincome"] = new XAQueryFieldInfo("long", bfnetincome, bfnetincome.ToString("d12"), "전분기순이익", (decimal)12);
			dict["bfeps"] = new XAQueryFieldInfo("float", bfeps, bfeps.ToString("0000000000000.00"), "전분기EPS", (decimal)13.2);
			dict["name2"] = new XAQueryFieldInfo("char", name2, name2, "전전분기명", (decimal)10);
			dict["bfsales2"] = new XAQueryFieldInfo("long", bfsales2, bfsales2.ToString("d12"), "전전분기매출액", (decimal)12);
			dict["bfoperatingincome2"] = new XAQueryFieldInfo("long", bfoperatingincome2, bfoperatingincome2.ToString("d12"), "전전분기영업이익", (decimal)12);
			dict["bfordinaryincome2"] = new XAQueryFieldInfo("long", bfordinaryincome2, bfordinaryincome2.ToString("d12"), "전전분기경상이익", (decimal)12);
			dict["bfnetincome2"] = new XAQueryFieldInfo("long", bfnetincome2, bfnetincome2.ToString("d12"), "전전분기순이익", (decimal)12);
			dict["bfeps2"] = new XAQueryFieldInfo("float", bfeps2, bfeps2.ToString("0000000000000.00"), "전전분기EPS", (decimal)13.2);
			dict["salert"] = new XAQueryFieldInfo("float", salert, salert.ToString("0000000.00"), "전년대비매출액", (decimal)7.2);
			dict["opert"] = new XAQueryFieldInfo("float", opert, opert.ToString("0000000.00"), "전년대비영업이익", (decimal)7.2);
			dict["ordrt"] = new XAQueryFieldInfo("float", ordrt, ordrt.ToString("0000000.00"), "전년대비경상이익", (decimal)7.2);
			dict["netrt"] = new XAQueryFieldInfo("float", netrt, netrt.ToString("0000000.00"), "전년대비순이익", (decimal)7.2);
			dict["epsrt"] = new XAQueryFieldInfo("float", epsrt, epsrt.ToString("0000000.00"), "전년대비EPS", (decimal)7.2);
			dict["info1"] = new XAQueryFieldInfo("char", info1, info1, "락구분", (decimal)10);
			dict["info2"] = new XAQueryFieldInfo("char", info2, info2, "관리/급등구분", (decimal)10);
			dict["info3"] = new XAQueryFieldInfo("char", info3, info3, "정지/연장구분", (decimal)10);
			dict["info4"] = new XAQueryFieldInfo("char", info4, info4, "투자/불성실구분", (decimal)12);
			dict["janginfo"] = new XAQueryFieldInfo("char", janginfo, janginfo, "장구분", (decimal)10);
			dict["t_per"] = new XAQueryFieldInfo("float", t_per, t_per.ToString("000000.00"), "T.PER", (decimal)6.2);
			dict["tonghwa"] = new XAQueryFieldInfo("char", tonghwa, tonghwa, "통화ISO코드", (decimal)3);
			dict["dval1"] = new XAQueryFieldInfo("long", dval1, dval1.ToString("d18"), "총매도대금1", (decimal)18);
			dict["sval1"] = new XAQueryFieldInfo("long", sval1, sval1.ToString("d18"), "총매수대금1", (decimal)18);
			dict["dval2"] = new XAQueryFieldInfo("long", dval2, dval2.ToString("d18"), "총매도대금2", (decimal)18);
			dict["sval2"] = new XAQueryFieldInfo("long", sval2, sval2.ToString("d18"), "총매수대금2", (decimal)18);
			dict["dval3"] = new XAQueryFieldInfo("long", dval3, dval3.ToString("d18"), "총매도대금3", (decimal)18);
			dict["sval3"] = new XAQueryFieldInfo("long", sval3, sval3.ToString("d18"), "총매수대금3", (decimal)18);
			dict["dval4"] = new XAQueryFieldInfo("long", dval4, dval4.ToString("d18"), "총매도대금4", (decimal)18);
			dict["sval4"] = new XAQueryFieldInfo("long", sval4, sval4.ToString("d18"), "총매수대금4", (decimal)18);
			dict["dval5"] = new XAQueryFieldInfo("long", dval5, dval5.ToString("d18"), "총매도대금5", (decimal)18);
			dict["sval5"] = new XAQueryFieldInfo("long", sval5, sval5.ToString("d18"), "총매수대금5", (decimal)18);
			dict["davg1"] = new XAQueryFieldInfo("long", davg1, davg1.ToString("d8"), "총매도평단가1", (decimal)8);
			dict["savg1"] = new XAQueryFieldInfo("long", savg1, savg1.ToString("d8"), "총매수평단가1", (decimal)8);
			dict["davg2"] = new XAQueryFieldInfo("long", davg2, davg2.ToString("d8"), "총매도평단가2", (decimal)8);
			dict["savg2"] = new XAQueryFieldInfo("long", savg2, savg2.ToString("d8"), "총매수평단가2", (decimal)8);
			dict["davg3"] = new XAQueryFieldInfo("long", davg3, davg3.ToString("d8"), "총매도평단가3", (decimal)8);
			dict["savg3"] = new XAQueryFieldInfo("long", savg3, savg3.ToString("d8"), "총매수평단가3", (decimal)8);
			dict["davg4"] = new XAQueryFieldInfo("long", davg4, davg4.ToString("d8"), "총매도평단가4", (decimal)8);
			dict["savg4"] = new XAQueryFieldInfo("long", savg4, savg4.ToString("d8"), "총매수평단가4", (decimal)8);
			dict["davg5"] = new XAQueryFieldInfo("long", davg5, davg5.ToString("d8"), "총매도평단가5", (decimal)8);
			dict["savg5"] = new XAQueryFieldInfo("long", savg5, savg5.ToString("d8"), "총매수평단가5", (decimal)8);
			dict["ftradmdval"] = new XAQueryFieldInfo("long", ftradmdval, ftradmdval.ToString("d18"), "외국계매도대금", (decimal)18);
			dict["ftradmsval"] = new XAQueryFieldInfo("long", ftradmsval, ftradmsval.ToString("d18"), "외국계매수대금", (decimal)18);
			dict["ftradmdavg"] = new XAQueryFieldInfo("long", ftradmdavg, ftradmdavg.ToString("d8"), "외국계매도평단가", (decimal)8);
			dict["ftradmsavg"] = new XAQueryFieldInfo("long", ftradmsavg, ftradmsavg.ToString("d8"), "외국계매수평단가", (decimal)8);
			dict["info5"] = new XAQueryFieldInfo("char", info5, info5, "투자주의환기", (decimal)8);
			dict["spac_gubun"] = new XAQueryFieldInfo("char", spac_gubun, spac_gubun.ToString(), "기업인수목적회사여부", (decimal)1);
			dict["issueprice"] = new XAQueryFieldInfo("long", issueprice, issueprice.ToString("d8"), "발행가격", (decimal)8);
			dict["alloc_gubun"] = new XAQueryFieldInfo("char", alloc_gubun, alloc_gubun.ToString(), "배분적용구분코드(1:배분발생2:배분해제그외:미발생)", (decimal)1);
			dict["alloc_text"] = new XAQueryFieldInfo("char", alloc_text, alloc_text, "배분적용구분", (decimal)8);
			dict["shterm_text"] = new XAQueryFieldInfo("char", shterm_text, shterm_text, "단기과열/VI발동", (decimal)10);
			dict["svi_uplmtprice"] = new XAQueryFieldInfo("long", svi_uplmtprice, svi_uplmtprice.ToString("d8"), "정적VI상한가", (decimal)8);
			dict["svi_dnlmtprice"] = new XAQueryFieldInfo("long", svi_dnlmtprice, svi_dnlmtprice.ToString("d8"), "정적VI하한가", (decimal)8);
			dict["low_lqdt_gu"] = new XAQueryFieldInfo("char", low_lqdt_gu, low_lqdt_gu.ToString(), "저유동성종목여부", (decimal)1);
			dict["abnormal_rise_gu"] = new XAQueryFieldInfo("char", abnormal_rise_gu, abnormal_rise_gu.ToString(), "이상급등종목여부", (decimal)1);
			dict["lend_text"] = new XAQueryFieldInfo("char", lend_text, lend_text, "대차불가표시", (decimal)8);

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
					this.jnilvolume = fieldInfo.FieldValue.ParseLong("jnilvolume");
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

				case "per":
					this.per = fieldInfo.FieldValue.ParseFloat("per");
				break;

				case "pbrx":
					this.pbrx = fieldInfo.FieldValue.ParseFloat("pbrx");
				break;

				case "listing":
					this.listing = fieldInfo.FieldValue.ParseLong("listing");
				break;

				case "jkrate":
					this.jkrate = fieldInfo.FieldValue.ParseLong("jkrate");
				break;

				case "memedan":
					this.memedan = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "offernocd1":
					this.offernocd1 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "bidnocd1":
					this.bidnocd1 = fieldInfo.FieldValue.TrimEnd('?');
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

				case "offernocd2":
					this.offernocd2 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "bidnocd2":
					this.bidnocd2 = fieldInfo.FieldValue.TrimEnd('?');
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

				case "offernocd3":
					this.offernocd3 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "bidnocd3":
					this.bidnocd3 = fieldInfo.FieldValue.TrimEnd('?');
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

				case "offernocd4":
					this.offernocd4 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "bidnocd4":
					this.bidnocd4 = fieldInfo.FieldValue.TrimEnd('?');
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

				case "offernocd5":
					this.offernocd5 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "bidnocd5":
					this.bidnocd5 = fieldInfo.FieldValue.TrimEnd('?');
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

				case "vol":
					this.vol = fieldInfo.FieldValue.ParseFloat("vol");
				break;

				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "value":
					this.value = fieldInfo.FieldValue.ParseLong("value");
				break;

				case "jvolume":
					this.jvolume = fieldInfo.FieldValue.ParseLong("jvolume");
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

				case "target":
					this.target = fieldInfo.FieldValue.ParseLong("target");
				break;

				case "capital":
					this.capital = fieldInfo.FieldValue.ParseLong("capital");
				break;

				case "abscnt":
					this.abscnt = fieldInfo.FieldValue.ParseLong("abscnt");
				break;

				case "parprice":
					this.parprice = fieldInfo.FieldValue.ParseLong("parprice");
				break;

				case "gsmm":
					this.gsmm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "subprice":
					this.subprice = fieldInfo.FieldValue.ParseLong("subprice");
				break;

				case "total":
					this.total = fieldInfo.FieldValue.ParseLong("total");
				break;

				case "listdate":
					this.listdate = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "name":
					this.name = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "bfsales":
					this.bfsales = fieldInfo.FieldValue.ParseLong("bfsales");
				break;

				case "bfoperatingincome":
					this.bfoperatingincome = fieldInfo.FieldValue.ParseLong("bfoperatingincome");
				break;

				case "bfordinaryincome":
					this.bfordinaryincome = fieldInfo.FieldValue.ParseLong("bfordinaryincome");
				break;

				case "bfnetincome":
					this.bfnetincome = fieldInfo.FieldValue.ParseLong("bfnetincome");
				break;

				case "bfeps":
					this.bfeps = fieldInfo.FieldValue.ParseFloat("bfeps");
				break;

				case "name2":
					this.name2 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "bfsales2":
					this.bfsales2 = fieldInfo.FieldValue.ParseLong("bfsales2");
				break;

				case "bfoperatingincome2":
					this.bfoperatingincome2 = fieldInfo.FieldValue.ParseLong("bfoperatingincome2");
				break;

				case "bfordinaryincome2":
					this.bfordinaryincome2 = fieldInfo.FieldValue.ParseLong("bfordinaryincome2");
				break;

				case "bfnetincome2":
					this.bfnetincome2 = fieldInfo.FieldValue.ParseLong("bfnetincome2");
				break;

				case "bfeps2":
					this.bfeps2 = fieldInfo.FieldValue.ParseFloat("bfeps2");
				break;

				case "salert":
					this.salert = fieldInfo.FieldValue.ParseFloat("salert");
				break;

				case "opert":
					this.opert = fieldInfo.FieldValue.ParseFloat("opert");
				break;

				case "ordrt":
					this.ordrt = fieldInfo.FieldValue.ParseFloat("ordrt");
				break;

				case "netrt":
					this.netrt = fieldInfo.FieldValue.ParseFloat("netrt");
				break;

				case "epsrt":
					this.epsrt = fieldInfo.FieldValue.ParseFloat("epsrt");
				break;

				case "info1":
					this.info1 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "info2":
					this.info2 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "info3":
					this.info3 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "info4":
					this.info4 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "janginfo":
					this.janginfo = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "t_per":
					this.t_per = fieldInfo.FieldValue.ParseFloat("t_per");
				break;

				case "tonghwa":
					this.tonghwa = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "dval1":
					this.dval1 = fieldInfo.FieldValue.ParseLong("dval1");
				break;

				case "sval1":
					this.sval1 = fieldInfo.FieldValue.ParseLong("sval1");
				break;

				case "dval2":
					this.dval2 = fieldInfo.FieldValue.ParseLong("dval2");
				break;

				case "sval2":
					this.sval2 = fieldInfo.FieldValue.ParseLong("sval2");
				break;

				case "dval3":
					this.dval3 = fieldInfo.FieldValue.ParseLong("dval3");
				break;

				case "sval3":
					this.sval3 = fieldInfo.FieldValue.ParseLong("sval3");
				break;

				case "dval4":
					this.dval4 = fieldInfo.FieldValue.ParseLong("dval4");
				break;

				case "sval4":
					this.sval4 = fieldInfo.FieldValue.ParseLong("sval4");
				break;

				case "dval5":
					this.dval5 = fieldInfo.FieldValue.ParseLong("dval5");
				break;

				case "sval5":
					this.sval5 = fieldInfo.FieldValue.ParseLong("sval5");
				break;

				case "davg1":
					this.davg1 = fieldInfo.FieldValue.ParseLong("davg1");
				break;

				case "savg1":
					this.savg1 = fieldInfo.FieldValue.ParseLong("savg1");
				break;

				case "davg2":
					this.davg2 = fieldInfo.FieldValue.ParseLong("davg2");
				break;

				case "savg2":
					this.savg2 = fieldInfo.FieldValue.ParseLong("savg2");
				break;

				case "davg3":
					this.davg3 = fieldInfo.FieldValue.ParseLong("davg3");
				break;

				case "savg3":
					this.savg3 = fieldInfo.FieldValue.ParseLong("savg3");
				break;

				case "davg4":
					this.davg4 = fieldInfo.FieldValue.ParseLong("davg4");
				break;

				case "savg4":
					this.savg4 = fieldInfo.FieldValue.ParseLong("savg4");
				break;

				case "davg5":
					this.davg5 = fieldInfo.FieldValue.ParseLong("davg5");
				break;

				case "savg5":
					this.savg5 = fieldInfo.FieldValue.ParseLong("savg5");
				break;

				case "ftradmdval":
					this.ftradmdval = fieldInfo.FieldValue.ParseLong("ftradmdval");
				break;

				case "ftradmsval":
					this.ftradmsval = fieldInfo.FieldValue.ParseLong("ftradmsval");
				break;

				case "ftradmdavg":
					this.ftradmdavg = fieldInfo.FieldValue.ParseLong("ftradmdavg");
				break;

				case "ftradmsavg":
					this.ftradmsavg = fieldInfo.FieldValue.ParseLong("ftradmsavg");
				break;

				case "info5":
					this.info5 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "spac_gubun":
					this.spac_gubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "issueprice":
					this.issueprice = fieldInfo.FieldValue.ParseLong("issueprice");
				break;

				case "alloc_gubun":
					this.alloc_gubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "alloc_text":
					this.alloc_text = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "shterm_text":
					this.shterm_text = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "svi_uplmtprice":
					this.svi_uplmtprice = fieldInfo.FieldValue.ParseLong("svi_uplmtprice");
				break;

				case "svi_dnlmtprice":
					this.svi_dnlmtprice = fieldInfo.FieldValue.ParseLong("svi_dnlmtprice");
				break;

				case "low_lqdt_gu":
					this.low_lqdt_gu = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "abnormal_rise_gu":
					this.abnormal_rise_gu = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "lend_text":
					this.lend_text = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt1102OutBlock FromQuery(XQt1102 query)
		{
			XQt1102OutBlock block = new XQt1102OutBlock();
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
				block.volume = query.GetFieldData(block.GetBlockName(), "volume", 0).ParseLong("volume"); // long 12
				block.recprice = query.GetFieldData(block.GetBlockName(), "recprice", 0).ParseLong("recprice"); // long 8
				block.avg = query.GetFieldData(block.GetBlockName(), "avg", 0).ParseLong("avg"); // long 8
				block.uplmtprice = query.GetFieldData(block.GetBlockName(), "uplmtprice", 0).ParseLong("uplmtprice"); // long 8
				block.dnlmtprice = query.GetFieldData(block.GetBlockName(), "dnlmtprice", 0).ParseLong("dnlmtprice"); // long 8
				block.jnilvolume = query.GetFieldData(block.GetBlockName(), "jnilvolume", 0).ParseLong("jnilvolume"); // long 12
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
				block.per = query.GetFieldData(block.GetBlockName(), "per", 0).ParseFloat("per"); // float 6.2
				block.pbrx = query.GetFieldData(block.GetBlockName(), "pbrx", 0).ParseFloat("pbrx"); // float 6.2
				block.listing = query.GetFieldData(block.GetBlockName(), "listing", 0).ParseLong("listing"); // long 12
				block.jkrate = query.GetFieldData(block.GetBlockName(), "jkrate", 0).ParseLong("jkrate"); // long 8
				block.memedan = query.GetFieldData(block.GetBlockName(), "memedan", 0).TrimEnd('?'); // char 5
				block.offernocd1 = query.GetFieldData(block.GetBlockName(), "offernocd1", 0).TrimEnd('?'); // char 3
				block.bidnocd1 = query.GetFieldData(block.GetBlockName(), "bidnocd1", 0).TrimEnd('?'); // char 3
				block.offerno1 = query.GetFieldData(block.GetBlockName(), "offerno1", 0).TrimEnd('?'); // char 6
				block.bidno1 = query.GetFieldData(block.GetBlockName(), "bidno1", 0).TrimEnd('?'); // char 6
				block.dvol1 = query.GetFieldData(block.GetBlockName(), "dvol1", 0).ParseLong("dvol1"); // long 8
				block.svol1 = query.GetFieldData(block.GetBlockName(), "svol1", 0).ParseLong("svol1"); // long 8
				block.dcha1 = query.GetFieldData(block.GetBlockName(), "dcha1", 0).ParseLong("dcha1"); // long 8
				block.scha1 = query.GetFieldData(block.GetBlockName(), "scha1", 0).ParseLong("scha1"); // long 8
				block.ddiff1 = query.GetFieldData(block.GetBlockName(), "ddiff1", 0).ParseFloat("ddiff1"); // float 6.2
				block.sdiff1 = query.GetFieldData(block.GetBlockName(), "sdiff1", 0).ParseFloat("sdiff1"); // float 6.2
				block.offernocd2 = query.GetFieldData(block.GetBlockName(), "offernocd2", 0).TrimEnd('?'); // char 3
				block.bidnocd2 = query.GetFieldData(block.GetBlockName(), "bidnocd2", 0).TrimEnd('?'); // char 3
				block.offerno2 = query.GetFieldData(block.GetBlockName(), "offerno2", 0).TrimEnd('?'); // char 6
				block.bidno2 = query.GetFieldData(block.GetBlockName(), "bidno2", 0).TrimEnd('?'); // char 6
				block.dvol2 = query.GetFieldData(block.GetBlockName(), "dvol2", 0).ParseLong("dvol2"); // long 8
				block.svol2 = query.GetFieldData(block.GetBlockName(), "svol2", 0).ParseLong("svol2"); // long 8
				block.dcha2 = query.GetFieldData(block.GetBlockName(), "dcha2", 0).ParseLong("dcha2"); // long 8
				block.scha2 = query.GetFieldData(block.GetBlockName(), "scha2", 0).ParseLong("scha2"); // long 8
				block.ddiff2 = query.GetFieldData(block.GetBlockName(), "ddiff2", 0).ParseFloat("ddiff2"); // float 6.2
				block.sdiff2 = query.GetFieldData(block.GetBlockName(), "sdiff2", 0).ParseFloat("sdiff2"); // float 6.2
				block.offernocd3 = query.GetFieldData(block.GetBlockName(), "offernocd3", 0).TrimEnd('?'); // char 3
				block.bidnocd3 = query.GetFieldData(block.GetBlockName(), "bidnocd3", 0).TrimEnd('?'); // char 3
				block.offerno3 = query.GetFieldData(block.GetBlockName(), "offerno3", 0).TrimEnd('?'); // char 6
				block.bidno3 = query.GetFieldData(block.GetBlockName(), "bidno3", 0).TrimEnd('?'); // char 6
				block.dvol3 = query.GetFieldData(block.GetBlockName(), "dvol3", 0).ParseLong("dvol3"); // long 8
				block.svol3 = query.GetFieldData(block.GetBlockName(), "svol3", 0).ParseLong("svol3"); // long 8
				block.dcha3 = query.GetFieldData(block.GetBlockName(), "dcha3", 0).ParseLong("dcha3"); // long 8
				block.scha3 = query.GetFieldData(block.GetBlockName(), "scha3", 0).ParseLong("scha3"); // long 8
				block.ddiff3 = query.GetFieldData(block.GetBlockName(), "ddiff3", 0).ParseFloat("ddiff3"); // float 6.2
				block.sdiff3 = query.GetFieldData(block.GetBlockName(), "sdiff3", 0).ParseFloat("sdiff3"); // float 6.2
				block.offernocd4 = query.GetFieldData(block.GetBlockName(), "offernocd4", 0).TrimEnd('?'); // char 3
				block.bidnocd4 = query.GetFieldData(block.GetBlockName(), "bidnocd4", 0).TrimEnd('?'); // char 3
				block.offerno4 = query.GetFieldData(block.GetBlockName(), "offerno4", 0).TrimEnd('?'); // char 6
				block.bidno4 = query.GetFieldData(block.GetBlockName(), "bidno4", 0).TrimEnd('?'); // char 6
				block.dvol4 = query.GetFieldData(block.GetBlockName(), "dvol4", 0).ParseLong("dvol4"); // long 8
				block.svol4 = query.GetFieldData(block.GetBlockName(), "svol4", 0).ParseLong("svol4"); // long 8
				block.dcha4 = query.GetFieldData(block.GetBlockName(), "dcha4", 0).ParseLong("dcha4"); // long 8
				block.scha4 = query.GetFieldData(block.GetBlockName(), "scha4", 0).ParseLong("scha4"); // long 8
				block.ddiff4 = query.GetFieldData(block.GetBlockName(), "ddiff4", 0).ParseFloat("ddiff4"); // float 6.2
				block.sdiff4 = query.GetFieldData(block.GetBlockName(), "sdiff4", 0).ParseFloat("sdiff4"); // float 6.2
				block.offernocd5 = query.GetFieldData(block.GetBlockName(), "offernocd5", 0).TrimEnd('?'); // char 3
				block.bidnocd5 = query.GetFieldData(block.GetBlockName(), "bidnocd5", 0).TrimEnd('?'); // char 3
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
				block.vol = query.GetFieldData(block.GetBlockName(), "vol", 0).ParseFloat("vol"); // float 6.2
				block.shcode = query.GetFieldData(block.GetBlockName(), "shcode", 0).TrimEnd('?'); // char 6
				block.value = query.GetFieldData(block.GetBlockName(), "value", 0).ParseLong("value"); // long 12
				block.jvolume = query.GetFieldData(block.GetBlockName(), "jvolume", 0).ParseLong("jvolume"); // long 12
				block.highyear = query.GetFieldData(block.GetBlockName(), "highyear", 0).ParseLong("highyear"); // long 8
				block.highyeardate = query.GetFieldData(block.GetBlockName(), "highyeardate", 0).TrimEnd('?'); // char 8
				block.lowyear = query.GetFieldData(block.GetBlockName(), "lowyear", 0).ParseLong("lowyear"); // long 8
				block.lowyeardate = query.GetFieldData(block.GetBlockName(), "lowyeardate", 0).TrimEnd('?'); // char 8
				block.target = query.GetFieldData(block.GetBlockName(), "target", 0).ParseLong("target"); // long 8
				block.capital = query.GetFieldData(block.GetBlockName(), "capital", 0).ParseLong("capital"); // long 12
				block.abscnt = query.GetFieldData(block.GetBlockName(), "abscnt", 0).ParseLong("abscnt"); // long 12
				block.parprice = query.GetFieldData(block.GetBlockName(), "parprice", 0).ParseLong("parprice"); // long 8
				block.gsmm = query.GetFieldData(block.GetBlockName(), "gsmm", 0).TrimEnd('?'); // char 2
				block.subprice = query.GetFieldData(block.GetBlockName(), "subprice", 0).ParseLong("subprice"); // long 8
				block.total = query.GetFieldData(block.GetBlockName(), "total", 0).ParseLong("total"); // long 12
				block.listdate = query.GetFieldData(block.GetBlockName(), "listdate", 0).TrimEnd('?'); // char 8
				block.name = query.GetFieldData(block.GetBlockName(), "name", 0).TrimEnd('?'); // char 10
				block.bfsales = query.GetFieldData(block.GetBlockName(), "bfsales", 0).ParseLong("bfsales"); // long 12
				block.bfoperatingincome = query.GetFieldData(block.GetBlockName(), "bfoperatingincome", 0).ParseLong("bfoperatingincome"); // long 12
				block.bfordinaryincome = query.GetFieldData(block.GetBlockName(), "bfordinaryincome", 0).ParseLong("bfordinaryincome"); // long 12
				block.bfnetincome = query.GetFieldData(block.GetBlockName(), "bfnetincome", 0).ParseLong("bfnetincome"); // long 12
				block.bfeps = query.GetFieldData(block.GetBlockName(), "bfeps", 0).ParseFloat("bfeps"); // float 13.2
				block.name2 = query.GetFieldData(block.GetBlockName(), "name2", 0).TrimEnd('?'); // char 10
				block.bfsales2 = query.GetFieldData(block.GetBlockName(), "bfsales2", 0).ParseLong("bfsales2"); // long 12
				block.bfoperatingincome2 = query.GetFieldData(block.GetBlockName(), "bfoperatingincome2", 0).ParseLong("bfoperatingincome2"); // long 12
				block.bfordinaryincome2 = query.GetFieldData(block.GetBlockName(), "bfordinaryincome2", 0).ParseLong("bfordinaryincome2"); // long 12
				block.bfnetincome2 = query.GetFieldData(block.GetBlockName(), "bfnetincome2", 0).ParseLong("bfnetincome2"); // long 12
				block.bfeps2 = query.GetFieldData(block.GetBlockName(), "bfeps2", 0).ParseFloat("bfeps2"); // float 13.2
				block.salert = query.GetFieldData(block.GetBlockName(), "salert", 0).ParseFloat("salert"); // float 7.2
				block.opert = query.GetFieldData(block.GetBlockName(), "opert", 0).ParseFloat("opert"); // float 7.2
				block.ordrt = query.GetFieldData(block.GetBlockName(), "ordrt", 0).ParseFloat("ordrt"); // float 7.2
				block.netrt = query.GetFieldData(block.GetBlockName(), "netrt", 0).ParseFloat("netrt"); // float 7.2
				block.epsrt = query.GetFieldData(block.GetBlockName(), "epsrt", 0).ParseFloat("epsrt"); // float 7.2
				block.info1 = query.GetFieldData(block.GetBlockName(), "info1", 0).TrimEnd('?'); // char 10
				block.info2 = query.GetFieldData(block.GetBlockName(), "info2", 0).TrimEnd('?'); // char 10
				block.info3 = query.GetFieldData(block.GetBlockName(), "info3", 0).TrimEnd('?'); // char 10
				block.info4 = query.GetFieldData(block.GetBlockName(), "info4", 0).TrimEnd('?'); // char 12
				block.janginfo = query.GetFieldData(block.GetBlockName(), "janginfo", 0).TrimEnd('?'); // char 10
				block.t_per = query.GetFieldData(block.GetBlockName(), "t_per", 0).ParseFloat("t_per"); // float 6.2
				block.tonghwa = query.GetFieldData(block.GetBlockName(), "tonghwa", 0).TrimEnd('?'); // char 3
				block.dval1 = query.GetFieldData(block.GetBlockName(), "dval1", 0).ParseLong("dval1"); // long 18
				block.sval1 = query.GetFieldData(block.GetBlockName(), "sval1", 0).ParseLong("sval1"); // long 18
				block.dval2 = query.GetFieldData(block.GetBlockName(), "dval2", 0).ParseLong("dval2"); // long 18
				block.sval2 = query.GetFieldData(block.GetBlockName(), "sval2", 0).ParseLong("sval2"); // long 18
				block.dval3 = query.GetFieldData(block.GetBlockName(), "dval3", 0).ParseLong("dval3"); // long 18
				block.sval3 = query.GetFieldData(block.GetBlockName(), "sval3", 0).ParseLong("sval3"); // long 18
				block.dval4 = query.GetFieldData(block.GetBlockName(), "dval4", 0).ParseLong("dval4"); // long 18
				block.sval4 = query.GetFieldData(block.GetBlockName(), "sval4", 0).ParseLong("sval4"); // long 18
				block.dval5 = query.GetFieldData(block.GetBlockName(), "dval5", 0).ParseLong("dval5"); // long 18
				block.sval5 = query.GetFieldData(block.GetBlockName(), "sval5", 0).ParseLong("sval5"); // long 18
				block.davg1 = query.GetFieldData(block.GetBlockName(), "davg1", 0).ParseLong("davg1"); // long 8
				block.savg1 = query.GetFieldData(block.GetBlockName(), "savg1", 0).ParseLong("savg1"); // long 8
				block.davg2 = query.GetFieldData(block.GetBlockName(), "davg2", 0).ParseLong("davg2"); // long 8
				block.savg2 = query.GetFieldData(block.GetBlockName(), "savg2", 0).ParseLong("savg2"); // long 8
				block.davg3 = query.GetFieldData(block.GetBlockName(), "davg3", 0).ParseLong("davg3"); // long 8
				block.savg3 = query.GetFieldData(block.GetBlockName(), "savg3", 0).ParseLong("savg3"); // long 8
				block.davg4 = query.GetFieldData(block.GetBlockName(), "davg4", 0).ParseLong("davg4"); // long 8
				block.savg4 = query.GetFieldData(block.GetBlockName(), "savg4", 0).ParseLong("savg4"); // long 8
				block.davg5 = query.GetFieldData(block.GetBlockName(), "davg5", 0).ParseLong("davg5"); // long 8
				block.savg5 = query.GetFieldData(block.GetBlockName(), "savg5", 0).ParseLong("savg5"); // long 8
				block.ftradmdval = query.GetFieldData(block.GetBlockName(), "ftradmdval", 0).ParseLong("ftradmdval"); // long 18
				block.ftradmsval = query.GetFieldData(block.GetBlockName(), "ftradmsval", 0).ParseLong("ftradmsval"); // long 18
				block.ftradmdavg = query.GetFieldData(block.GetBlockName(), "ftradmdavg", 0).ParseLong("ftradmdavg"); // long 8
				block.ftradmsavg = query.GetFieldData(block.GetBlockName(), "ftradmsavg", 0).ParseLong("ftradmsavg"); // long 8
				block.info5 = query.GetFieldData(block.GetBlockName(), "info5", 0).TrimEnd('?'); // char 8
				block.spac_gubun = query.GetFieldData(block.GetBlockName(), "spac_gubun", 0).FirstOrDefault(); // char 1
				block.issueprice = query.GetFieldData(block.GetBlockName(), "issueprice", 0).ParseLong("issueprice"); // long 8
				block.alloc_gubun = query.GetFieldData(block.GetBlockName(), "alloc_gubun", 0).FirstOrDefault(); // char 1
				block.alloc_text = query.GetFieldData(block.GetBlockName(), "alloc_text", 0).TrimEnd('?'); // char 8
				block.shterm_text = query.GetFieldData(block.GetBlockName(), "shterm_text", 0).TrimEnd('?'); // char 10
				block.svi_uplmtprice = query.GetFieldData(block.GetBlockName(), "svi_uplmtprice", 0).ParseLong("svi_uplmtprice"); // long 8
				block.svi_dnlmtprice = query.GetFieldData(block.GetBlockName(), "svi_dnlmtprice", 0).ParseLong("svi_dnlmtprice"); // long 8
				block.low_lqdt_gu = query.GetFieldData(block.GetBlockName(), "low_lqdt_gu", 0).FirstOrDefault(); // char 1
				block.abnormal_rise_gu = query.GetFieldData(block.GetBlockName(), "abnormal_rise_gu", 0).FirstOrDefault(); // char 1
				block.lend_text = query.GetFieldData(block.GetBlockName(), "lend_text", 0).TrimEnd('?'); // char 8

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
			if (volume.ToString().Length > 12) return false; // long 12
			if (recprice.ToString().Length > 8) return false; // long 8
			if (avg.ToString().Length > 8) return false; // long 8
			if (uplmtprice.ToString().Length > 8) return false; // long 8
			if (dnlmtprice.ToString().Length > 8) return false; // long 8
			if (jnilvolume.ToString().Length > 12) return false; // long 12
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
			// per float 6.2
			// pbrx float 6.2
			if (listing.ToString().Length > 12) return false; // long 12
			if (jkrate.ToString().Length > 8) return false; // long 8
			if (memedan?.Length > 5) return false; // char 5
			if (offernocd1?.Length > 3) return false; // char 3
			if (bidnocd1?.Length > 3) return false; // char 3
			if (offerno1?.Length > 6) return false; // char 6
			if (bidno1?.Length > 6) return false; // char 6
			if (dvol1.ToString().Length > 8) return false; // long 8
			if (svol1.ToString().Length > 8) return false; // long 8
			if (dcha1.ToString().Length > 8) return false; // long 8
			if (scha1.ToString().Length > 8) return false; // long 8
			// ddiff1 float 6.2
			// sdiff1 float 6.2
			if (offernocd2?.Length > 3) return false; // char 3
			if (bidnocd2?.Length > 3) return false; // char 3
			if (offerno2?.Length > 6) return false; // char 6
			if (bidno2?.Length > 6) return false; // char 6
			if (dvol2.ToString().Length > 8) return false; // long 8
			if (svol2.ToString().Length > 8) return false; // long 8
			if (dcha2.ToString().Length > 8) return false; // long 8
			if (scha2.ToString().Length > 8) return false; // long 8
			// ddiff2 float 6.2
			// sdiff2 float 6.2
			if (offernocd3?.Length > 3) return false; // char 3
			if (bidnocd3?.Length > 3) return false; // char 3
			if (offerno3?.Length > 6) return false; // char 6
			if (bidno3?.Length > 6) return false; // char 6
			if (dvol3.ToString().Length > 8) return false; // long 8
			if (svol3.ToString().Length > 8) return false; // long 8
			if (dcha3.ToString().Length > 8) return false; // long 8
			if (scha3.ToString().Length > 8) return false; // long 8
			// ddiff3 float 6.2
			// sdiff3 float 6.2
			if (offernocd4?.Length > 3) return false; // char 3
			if (bidnocd4?.Length > 3) return false; // char 3
			if (offerno4?.Length > 6) return false; // char 6
			if (bidno4?.Length > 6) return false; // char 6
			if (dvol4.ToString().Length > 8) return false; // long 8
			if (svol4.ToString().Length > 8) return false; // long 8
			if (dcha4.ToString().Length > 8) return false; // long 8
			if (scha4.ToString().Length > 8) return false; // long 8
			// ddiff4 float 6.2
			// sdiff4 float 6.2
			if (offernocd5?.Length > 3) return false; // char 3
			if (bidnocd5?.Length > 3) return false; // char 3
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
			// vol float 6.2
			if (shcode?.Length > 6) return false; // char 6
			if (value.ToString().Length > 12) return false; // long 12
			if (jvolume.ToString().Length > 12) return false; // long 12
			if (highyear.ToString().Length > 8) return false; // long 8
			if (highyeardate?.Length > 8) return false; // char 8
			if (lowyear.ToString().Length > 8) return false; // long 8
			if (lowyeardate?.Length > 8) return false; // char 8
			if (target.ToString().Length > 8) return false; // long 8
			if (capital.ToString().Length > 12) return false; // long 12
			if (abscnt.ToString().Length > 12) return false; // long 12
			if (parprice.ToString().Length > 8) return false; // long 8
			if (gsmm?.Length > 2) return false; // char 2
			if (subprice.ToString().Length > 8) return false; // long 8
			if (total.ToString().Length > 12) return false; // long 12
			if (listdate?.Length > 8) return false; // char 8
			if (name?.Length > 10) return false; // char 10
			if (bfsales.ToString().Length > 12) return false; // long 12
			if (bfoperatingincome.ToString().Length > 12) return false; // long 12
			if (bfordinaryincome.ToString().Length > 12) return false; // long 12
			if (bfnetincome.ToString().Length > 12) return false; // long 12
			// bfeps float 13.2
			if (name2?.Length > 10) return false; // char 10
			if (bfsales2.ToString().Length > 12) return false; // long 12
			if (bfoperatingincome2.ToString().Length > 12) return false; // long 12
			if (bfordinaryincome2.ToString().Length > 12) return false; // long 12
			if (bfnetincome2.ToString().Length > 12) return false; // long 12
			// bfeps2 float 13.2
			// salert float 7.2
			// opert float 7.2
			// ordrt float 7.2
			// netrt float 7.2
			// epsrt float 7.2
			if (info1?.Length > 10) return false; // char 10
			if (info2?.Length > 10) return false; // char 10
			if (info3?.Length > 10) return false; // char 10
			if (info4?.Length > 12) return false; // char 12
			if (janginfo?.Length > 10) return false; // char 10
			// t_per float 6.2
			if (tonghwa?.Length > 3) return false; // char 3
			if (dval1.ToString().Length > 18) return false; // long 18
			if (sval1.ToString().Length > 18) return false; // long 18
			if (dval2.ToString().Length > 18) return false; // long 18
			if (sval2.ToString().Length > 18) return false; // long 18
			if (dval3.ToString().Length > 18) return false; // long 18
			if (sval3.ToString().Length > 18) return false; // long 18
			if (dval4.ToString().Length > 18) return false; // long 18
			if (sval4.ToString().Length > 18) return false; // long 18
			if (dval5.ToString().Length > 18) return false; // long 18
			if (sval5.ToString().Length > 18) return false; // long 18
			if (davg1.ToString().Length > 8) return false; // long 8
			if (savg1.ToString().Length > 8) return false; // long 8
			if (davg2.ToString().Length > 8) return false; // long 8
			if (savg2.ToString().Length > 8) return false; // long 8
			if (davg3.ToString().Length > 8) return false; // long 8
			if (savg3.ToString().Length > 8) return false; // long 8
			if (davg4.ToString().Length > 8) return false; // long 8
			if (savg4.ToString().Length > 8) return false; // long 8
			if (davg5.ToString().Length > 8) return false; // long 8
			if (savg5.ToString().Length > 8) return false; // long 8
			if (ftradmdval.ToString().Length > 18) return false; // long 18
			if (ftradmsval.ToString().Length > 18) return false; // long 18
			if (ftradmdavg.ToString().Length > 8) return false; // long 8
			if (ftradmsavg.ToString().Length > 8) return false; // long 8
			if (info5?.Length > 8) return false; // char 8
			// spac_gubun char 1
			if (issueprice.ToString().Length > 8) return false; // long 8
			// alloc_gubun char 1
			if (alloc_text?.Length > 8) return false; // char 8
			if (shterm_text?.Length > 10) return false; // char 10
			if (svi_uplmtprice.ToString().Length > 8) return false; // long 8
			if (svi_dnlmtprice.ToString().Length > 8) return false; // long 8
			// low_lqdt_gu char 1
			// abnormal_rise_gu char 1
			if (lend_text?.Length > 8) return false; // char 8

			return true;
		}
	}

	public partial class XQt1102 : XingQuery
	{
		/// <summary>
		/// t1102
		/// </summary>
		public const string _typeName = "t1102";
		/// <summary>
		/// 주식현재가(시세)조회(t1102)
		/// </summary>
		public const string _typeDesc = "주식현재가(시세)조회(t1102)";
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
		/// t1102
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 주식현재가(시세)조회(t1102)
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

		public XQt1102() : base("t1102") { }


		public static XQt1102OutBlock Get(string shcode = default)
		{
			using (XQt1102 instance = new XQt1102())
			{
				instance.SetFieldData(XQt1102InBlock.BlockName, XQt1102InBlock.F.shcode, 0, shcode); // char 6

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

		public bool SetBlock(XQt1102InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "shcode", 0, block.shcode); // char 6

			return true;
		}

		public XQt1102OutBlock GetBlock()
		{
			XQt1102OutBlock instance = XQt1102OutBlock.FromQuery(this);
			return instance;

		}


	}

}
