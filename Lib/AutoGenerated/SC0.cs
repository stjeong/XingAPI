using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XRSC0InBlock : XingBlock
	{
		/// <summary>
		/// InBlock
		/// </summary>
		static readonly string _blockName = "InBlock";
		/// <summary>
		/// 입력
		/// </summary>
		static readonly string _blockDesc = "입력";
		/// <summary>
		/// input
		/// </summary>
		static readonly string _blockType = "input";
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _hasOccurs = false;
		/// <summary>
		/// InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// InBlock
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// 입력
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


		public static class F
		{
		}

		public static string[] AllFields = new string[]
		{
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
		}

		public bool VerifyData()
		{

			return true;
		}
	}

	public partial class XRSC0OutBlock : XingBlock
	{
		/// <summary>
		/// OutBlock
		/// </summary>
		static readonly string _blockName = "OutBlock";
		/// <summary>
		/// 출력
		/// </summary>
		static readonly string _blockDesc = "출력";
		/// <summary>
		/// output
		/// </summary>
		static readonly string _blockType = "output";
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _hasOccurs = false;
		/// <summary>
		/// OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// OutBlock
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
		/// 라인일련번호
		/// </summary>
		[XAQueryFieldAttribute("라인일련번호")]
		public long lineseq;
		/// <summary>
		/// 계좌번호
		/// </summary>
		[XAQueryFieldAttribute("계좌번호")]
		public string accno;
		/// <summary>
		/// 조작자ID
		/// </summary>
		[XAQueryFieldAttribute("조작자ID")]
		public string user;
		/// <summary>
		/// 헤더길이
		/// </summary>
		[XAQueryFieldAttribute("헤더길이")]
		public long len;
		/// <summary>
		/// 헤더구분
		/// </summary>
		[XAQueryFieldAttribute("헤더구분")]
		public char gubun;
		/// <summary>
		/// 압축구분
		/// </summary>
		[XAQueryFieldAttribute("압축구분")]
		public char compress;
		/// <summary>
		/// 암호구분
		/// </summary>
		[XAQueryFieldAttribute("암호구분")]
		public char encrypt;
		/// <summary>
		/// 공통시작지점
		/// </summary>
		[XAQueryFieldAttribute("공통시작지점")]
		public long offset;
		/// <summary>
		/// TRCODE
		/// </summary>
		[XAQueryFieldAttribute("TRCODE")]
		public string trcode;
		/// <summary>
		/// 이용사번호
		/// </summary>
		[XAQueryFieldAttribute("이용사번호")]
		public string compid;
		/// <summary>
		/// 사용자ID
		/// </summary>
		[XAQueryFieldAttribute("사용자ID")]
		public string userid;
		/// <summary>
		/// 접속매체
		/// </summary>
		[XAQueryFieldAttribute("접속매체")]
		public string media;
		/// <summary>
		/// I/F일련번호
		/// </summary>
		[XAQueryFieldAttribute("I/F일련번호")]
		public string ifid;
		/// <summary>
		/// 전문일련번호
		/// </summary>
		[XAQueryFieldAttribute("전문일련번호")]
		public string seq;
		/// <summary>
		/// TR추적ID
		/// </summary>
		[XAQueryFieldAttribute("TR추적ID")]
		public string trid;
		/// <summary>
		/// 공인IP
		/// </summary>
		[XAQueryFieldAttribute("공인IP")]
		public string pubip;
		/// <summary>
		/// 사설IP
		/// </summary>
		[XAQueryFieldAttribute("사설IP")]
		public string prvip;
		/// <summary>
		/// 처리지점번호
		/// </summary>
		[XAQueryFieldAttribute("처리지점번호")]
		public string pcbpno;
		/// <summary>
		/// 지점번호
		/// </summary>
		[XAQueryFieldAttribute("지점번호")]
		public string bpno;
		/// <summary>
		/// 단말번호
		/// </summary>
		[XAQueryFieldAttribute("단말번호")]
		public string termno;
		/// <summary>
		/// 언어구분
		/// </summary>
		[XAQueryFieldAttribute("언어구분")]
		public char lang;
		/// <summary>
		/// AP처리시간
		/// </summary>
		[XAQueryFieldAttribute("AP처리시간")]
		public long proctm;
		/// <summary>
		/// 메세지코드
		/// </summary>
		[XAQueryFieldAttribute("메세지코드")]
		public string msgcode;
		/// <summary>
		/// 메세지출력구분
		/// </summary>
		[XAQueryFieldAttribute("메세지출력구분")]
		public char outgu;
		/// <summary>
		/// 압축요청구분
		/// </summary>
		[XAQueryFieldAttribute("압축요청구분")]
		public char compreq;
		/// <summary>
		/// 기능키
		/// </summary>
		[XAQueryFieldAttribute("기능키")]
		public string funckey;
		/// <summary>
		/// 요청레코드개수
		/// </summary>
		[XAQueryFieldAttribute("요청레코드개수")]
		public long reqcnt;
		/// <summary>
		/// 예비영역
		/// </summary>
		[XAQueryFieldAttribute("예비영역")]
		public string filler;
		/// <summary>
		/// 연속구분
		/// </summary>
		[XAQueryFieldAttribute("연속구분")]
		public char cont;
		/// <summary>
		/// 연속키값
		/// </summary>
		[XAQueryFieldAttribute("연속키값")]
		public string contkey;
		/// <summary>
		/// 가변시스템길이
		/// </summary>
		[XAQueryFieldAttribute("가변시스템길이")]
		public long varlen;
		/// <summary>
		/// 가변해더길이
		/// </summary>
		[XAQueryFieldAttribute("가변해더길이")]
		public long varhdlen;
		/// <summary>
		/// 가변메시지길이
		/// </summary>
		[XAQueryFieldAttribute("가변메시지길이")]
		public long varmsglen;
		/// <summary>
		/// 조회발원지
		/// </summary>
		[XAQueryFieldAttribute("조회발원지")]
		public char trsrc;
		/// <summary>
		/// I/F이벤트ID
		/// </summary>
		[XAQueryFieldAttribute("I/F이벤트ID")]
		public string eventid;
		/// <summary>
		/// I/F정보
		/// </summary>
		[XAQueryFieldAttribute("I/F정보")]
		public string ifinfo;
		/// <summary>
		/// 예비영역
		/// </summary>
		[XAQueryFieldAttribute("예비영역")]
		public string filler1;
		/// <summary>
		/// 주문체결구분
		/// </summary>
		[XAQueryFieldAttribute("주문체결구분")]
		public string ordchegb;
		/// <summary>
		/// 시장구분
		/// </summary>
		[XAQueryFieldAttribute("시장구분")]
		public string marketgb;
		/// <summary>
		/// 주문구분
		/// </summary>
		[XAQueryFieldAttribute("주문구분")]
		public string ordgb;
		/// <summary>
		/// 원주문번호
		/// </summary>
		[XAQueryFieldAttribute("원주문번호")]
		public long orgordno;
		/// <summary>
		/// 계좌번호
		/// </summary>
		[XAQueryFieldAttribute("계좌번호")]
		public string accno1;
		/// <summary>
		/// 계좌번호
		/// </summary>
		[XAQueryFieldAttribute("계좌번호")]
		public string accno2;
		/// <summary>
		/// 비밀번호
		/// </summary>
		[XAQueryFieldAttribute("비밀번호")]
		public string passwd;
		/// <summary>
		/// 종목번호
		/// </summary>
		[XAQueryFieldAttribute("종목번호")]
		public string expcode;
		/// <summary>
		/// 단축종목번호
		/// </summary>
		[XAQueryFieldAttribute("단축종목번호")]
		public string shtcode;
		/// <summary>
		/// 종목명
		/// </summary>
		[XAQueryFieldAttribute("종목명")]
		public string hname;
		/// <summary>
		/// 주문수량
		/// </summary>
		[XAQueryFieldAttribute("주문수량")]
		public long ordqty;
		/// <summary>
		/// 주문가격
		/// </summary>
		[XAQueryFieldAttribute("주문가격")]
		public long ordprice;
		/// <summary>
		/// 주문조건
		/// </summary>
		[XAQueryFieldAttribute("주문조건")]
		public char hogagb;
		/// <summary>
		/// 호가유형코드
		/// </summary>
		[XAQueryFieldAttribute("호가유형코드")]
		public string etfhogagb;
		/// <summary>
		/// 프로그램호가구분
		/// </summary>
		[XAQueryFieldAttribute("프로그램호가구분")]
		public long pgmtype;
		/// <summary>
		/// 공매도호가구분
		/// </summary>
		[XAQueryFieldAttribute("공매도호가구분")]
		public long gmhogagb;
		/// <summary>
		/// 공매도가능여부
		/// </summary>
		[XAQueryFieldAttribute("공매도가능여부")]
		public long gmhogayn;
		/// <summary>
		/// 신용구분
		/// </summary>
		[XAQueryFieldAttribute("신용구분")]
		public string singb;
		/// <summary>
		/// 대출일
		/// </summary>
		[XAQueryFieldAttribute("대출일")]
		public string loandt;
		/// <summary>
		/// 반대매매주문구분
		/// </summary>
		[XAQueryFieldAttribute("반대매매주문구분")]
		public char cvrgordtp;
		/// <summary>
		/// 전략코드
		/// </summary>
		[XAQueryFieldAttribute("전략코드")]
		public string strtgcode;
		/// <summary>
		/// 그룹ID
		/// </summary>
		[XAQueryFieldAttribute("그룹ID")]
		public string groupid;
		/// <summary>
		/// 주문회차
		/// </summary>
		[XAQueryFieldAttribute("주문회차")]
		public long ordseqno;
		/// <summary>
		/// 포트폴리오번호
		/// </summary>
		[XAQueryFieldAttribute("포트폴리오번호")]
		public long prtno;
		/// <summary>
		/// 바스켓번호
		/// </summary>
		[XAQueryFieldAttribute("바스켓번호")]
		public long basketno;
		/// <summary>
		/// 트렌치번호
		/// </summary>
		[XAQueryFieldAttribute("트렌치번호")]
		public long trchno;
		/// <summary>
		/// 아아템번호
		/// </summary>
		[XAQueryFieldAttribute("아아템번호")]
		public long itemno;
		/// <summary>
		/// 차입구분
		/// </summary>
		[XAQueryFieldAttribute("차입구분")]
		public long brwmgmyn;
		/// <summary>
		/// 회원사번호
		/// </summary>
		[XAQueryFieldAttribute("회원사번호")]
		public long mbrno;
		/// <summary>
		/// 처리구분
		/// </summary>
		[XAQueryFieldAttribute("처리구분")]
		public char procgb;
		/// <summary>
		/// 관리지점번호
		/// </summary>
		[XAQueryFieldAttribute("관리지점번호")]
		public string admbrchno;
		/// <summary>
		/// 선물계좌번호
		/// </summary>
		[XAQueryFieldAttribute("선물계좌번호")]
		public string futaccno;
		/// <summary>
		/// 선물상품구분
		/// </summary>
		[XAQueryFieldAttribute("선물상품구분")]
		public char futmarketgb;
		/// <summary>
		/// 통신매체구분
		/// </summary>
		[XAQueryFieldAttribute("통신매체구분")]
		public string tongsingb;
		/// <summary>
		/// 유동성공급자구분
		/// </summary>
		[XAQueryFieldAttribute("유동성공급자구분")]
		public char lpgb;
		/// <summary>
		/// DUMMY
		/// </summary>
		[XAQueryFieldAttribute("DUMMY")]
		public string dummy;
		/// <summary>
		/// 주문번호
		/// </summary>
		[XAQueryFieldAttribute("주문번호")]
		public long ordno;
		/// <summary>
		/// 주문시각
		/// </summary>
		[XAQueryFieldAttribute("주문시각")]
		public string ordtm;
		/// <summary>
		/// 모주문번호
		/// </summary>
		[XAQueryFieldAttribute("모주문번호")]
		public long prntordno;
		/// <summary>
		/// 관리사원번호
		/// </summary>
		[XAQueryFieldAttribute("관리사원번호")]
		public string mgempno;
		/// <summary>
		/// 원주문미체결수량
		/// </summary>
		[XAQueryFieldAttribute("원주문미체결수량")]
		public long orgordundrqty;
		/// <summary>
		/// 원주문정정수량
		/// </summary>
		[XAQueryFieldAttribute("원주문정정수량")]
		public long orgordmdfyqty;
		/// <summary>
		/// 원주문취소수량
		/// </summary>
		[XAQueryFieldAttribute("원주문취소수량")]
		public long ordordcancelqty;
		/// <summary>
		/// 비회원사송신번호
		/// </summary>
		[XAQueryFieldAttribute("비회원사송신번호")]
		public long nmcpysndno;
		/// <summary>
		/// 주문금액
		/// </summary>
		[XAQueryFieldAttribute("주문금액")]
		public long ordamt;
		/// <summary>
		/// 매매구분
		/// </summary>
		[XAQueryFieldAttribute("매매구분")]
		public char bnstp;
		/// <summary>
		/// 예비주문번호
		/// </summary>
		[XAQueryFieldAttribute("예비주문번호")]
		public long spareordno;
		/// <summary>
		/// 반대매매일련번호
		/// </summary>
		[XAQueryFieldAttribute("반대매매일련번호")]
		public long cvrgseqno;
		/// <summary>
		/// 예약주문번호
		/// </summary>
		[XAQueryFieldAttribute("예약주문번호")]
		public long rsvordno;
		/// <summary>
		/// 복수주문일련번호
		/// </summary>
		[XAQueryFieldAttribute("복수주문일련번호")]
		public long mtordseqno;
		/// <summary>
		/// 예비주문수량
		/// </summary>
		[XAQueryFieldAttribute("예비주문수량")]
		public long spareordqty;
		/// <summary>
		/// 주문사원번호
		/// </summary>
		[XAQueryFieldAttribute("주문사원번호")]
		public string orduserid;
		/// <summary>
		/// 실물주문수량
		/// </summary>
		[XAQueryFieldAttribute("실물주문수량")]
		public long spotordqty;
		/// <summary>
		/// 재사용주문수량
		/// </summary>
		[XAQueryFieldAttribute("재사용주문수량")]
		public long ordruseqty;
		/// <summary>
		/// 현금주문금액
		/// </summary>
		[XAQueryFieldAttribute("현금주문금액")]
		public long mnyordamt;
		/// <summary>
		/// 주문대용금액
		/// </summary>
		[XAQueryFieldAttribute("주문대용금액")]
		public long ordsubstamt;
		/// <summary>
		/// 재사용주문금액
		/// </summary>
		[XAQueryFieldAttribute("재사용주문금액")]
		public long ruseordamt;
		/// <summary>
		/// 수수료주문금액
		/// </summary>
		[XAQueryFieldAttribute("수수료주문금액")]
		public long ordcmsnamt;
		/// <summary>
		/// 사용신용담보재사용금
		/// </summary>
		[XAQueryFieldAttribute("사용신용담보재사용금")]
		public long crdtuseamt;
		/// <summary>
		/// 잔고수량
		/// </summary>
		[XAQueryFieldAttribute("잔고수량")]
		public long secbalqty;
		/// <summary>
		/// 실물가능수량
		/// </summary>
		[XAQueryFieldAttribute("실물가능수량")]
		public long spotordableqty;
		/// <summary>
		/// 재사용가능수량(매도)
		/// </summary>
		[XAQueryFieldAttribute("재사용가능수량(매도)")]
		public long ordableruseqty;
		/// <summary>
		/// 변동수량
		/// </summary>
		[XAQueryFieldAttribute("변동수량")]
		public long flctqty;
		/// <summary>
		/// 잔고수량(D2)
		/// </summary>
		[XAQueryFieldAttribute("잔고수량(D2)")]
		public long secbalqtyd2;
		/// <summary>
		/// 매도주문가능수량
		/// </summary>
		[XAQueryFieldAttribute("매도주문가능수량")]
		public long sellableqty;
		/// <summary>
		/// 미체결매도주문수량
		/// </summary>
		[XAQueryFieldAttribute("미체결매도주문수량")]
		public long unercsellordqty;
		/// <summary>
		/// 평균매입가
		/// </summary>
		[XAQueryFieldAttribute("평균매입가")]
		public long avrpchsprc;
		/// <summary>
		/// 매입금액
		/// </summary>
		[XAQueryFieldAttribute("매입금액")]
		public long pchsamt;
		/// <summary>
		/// 예수금
		/// </summary>
		[XAQueryFieldAttribute("예수금")]
		public long deposit;
		/// <summary>
		/// 대용금
		/// </summary>
		[XAQueryFieldAttribute("대용금")]
		public long substamt;
		/// <summary>
		/// 위탁증거금현금
		/// </summary>
		[XAQueryFieldAttribute("위탁증거금현금")]
		public long csgnmnymgn;
		/// <summary>
		/// 위탁증거금대용
		/// </summary>
		[XAQueryFieldAttribute("위탁증거금대용")]
		public long csgnsubstmgn;
		/// <summary>
		/// 신용담보재사용금
		/// </summary>
		[XAQueryFieldAttribute("신용담보재사용금")]
		public long crdtpldgruseamt;
		/// <summary>
		/// 주문가능현금
		/// </summary>
		[XAQueryFieldAttribute("주문가능현금")]
		public long ordablemny;
		/// <summary>
		/// 주문가능대용
		/// </summary>
		[XAQueryFieldAttribute("주문가능대용")]
		public long ordablesubstamt;
		/// <summary>
		/// 재사용가능금액
		/// </summary>
		[XAQueryFieldAttribute("재사용가능금액")]
		public long ruseableamt;

		public static class F
		{
			/// <summary>
			/// 라인일련번호
			/// </summary>
			public const string lineseq = "lineseq";
			/// <summary>
			/// 계좌번호
			/// </summary>
			public const string accno = "accno";
			/// <summary>
			/// 조작자ID
			/// </summary>
			public const string user = "user";
			/// <summary>
			/// 헤더길이
			/// </summary>
			public const string len = "len";
			/// <summary>
			/// 헤더구분
			/// </summary>
			public const string gubun = "gubun";
			/// <summary>
			/// 압축구분
			/// </summary>
			public const string compress = "compress";
			/// <summary>
			/// 암호구분
			/// </summary>
			public const string encrypt = "encrypt";
			/// <summary>
			/// 공통시작지점
			/// </summary>
			public const string offset = "offset";
			/// <summary>
			/// TRCODE
			/// </summary>
			public const string trcode = "trcode";
			/// <summary>
			/// 이용사번호
			/// </summary>
			public const string compid = "compid";
			/// <summary>
			/// 사용자ID
			/// </summary>
			public const string userid = "userid";
			/// <summary>
			/// 접속매체
			/// </summary>
			public const string media = "media";
			/// <summary>
			/// I/F일련번호
			/// </summary>
			public const string ifid = "ifid";
			/// <summary>
			/// 전문일련번호
			/// </summary>
			public const string seq = "seq";
			/// <summary>
			/// TR추적ID
			/// </summary>
			public const string trid = "trid";
			/// <summary>
			/// 공인IP
			/// </summary>
			public const string pubip = "pubip";
			/// <summary>
			/// 사설IP
			/// </summary>
			public const string prvip = "prvip";
			/// <summary>
			/// 처리지점번호
			/// </summary>
			public const string pcbpno = "pcbpno";
			/// <summary>
			/// 지점번호
			/// </summary>
			public const string bpno = "bpno";
			/// <summary>
			/// 단말번호
			/// </summary>
			public const string termno = "termno";
			/// <summary>
			/// 언어구분
			/// </summary>
			public const string lang = "lang";
			/// <summary>
			/// AP처리시간
			/// </summary>
			public const string proctm = "proctm";
			/// <summary>
			/// 메세지코드
			/// </summary>
			public const string msgcode = "msgcode";
			/// <summary>
			/// 메세지출력구분
			/// </summary>
			public const string outgu = "outgu";
			/// <summary>
			/// 압축요청구분
			/// </summary>
			public const string compreq = "compreq";
			/// <summary>
			/// 기능키
			/// </summary>
			public const string funckey = "funckey";
			/// <summary>
			/// 요청레코드개수
			/// </summary>
			public const string reqcnt = "reqcnt";
			/// <summary>
			/// 예비영역
			/// </summary>
			public const string filler = "filler";
			/// <summary>
			/// 연속구분
			/// </summary>
			public const string cont = "cont";
			/// <summary>
			/// 연속키값
			/// </summary>
			public const string contkey = "contkey";
			/// <summary>
			/// 가변시스템길이
			/// </summary>
			public const string varlen = "varlen";
			/// <summary>
			/// 가변해더길이
			/// </summary>
			public const string varhdlen = "varhdlen";
			/// <summary>
			/// 가변메시지길이
			/// </summary>
			public const string varmsglen = "varmsglen";
			/// <summary>
			/// 조회발원지
			/// </summary>
			public const string trsrc = "trsrc";
			/// <summary>
			/// I/F이벤트ID
			/// </summary>
			public const string eventid = "eventid";
			/// <summary>
			/// I/F정보
			/// </summary>
			public const string ifinfo = "ifinfo";
			/// <summary>
			/// 예비영역
			/// </summary>
			public const string filler1 = "filler1";
			/// <summary>
			/// 주문체결구분
			/// </summary>
			public const string ordchegb = "ordchegb";
			/// <summary>
			/// 시장구분
			/// </summary>
			public const string marketgb = "marketgb";
			/// <summary>
			/// 주문구분
			/// </summary>
			public const string ordgb = "ordgb";
			/// <summary>
			/// 원주문번호
			/// </summary>
			public const string orgordno = "orgordno";
			/// <summary>
			/// 계좌번호
			/// </summary>
			public const string accno1 = "accno1";
			/// <summary>
			/// 계좌번호
			/// </summary>
			public const string accno2 = "accno2";
			/// <summary>
			/// 비밀번호
			/// </summary>
			public const string passwd = "passwd";
			/// <summary>
			/// 종목번호
			/// </summary>
			public const string expcode = "expcode";
			/// <summary>
			/// 단축종목번호
			/// </summary>
			public const string shtcode = "shtcode";
			/// <summary>
			/// 종목명
			/// </summary>
			public const string hname = "hname";
			/// <summary>
			/// 주문수량
			/// </summary>
			public const string ordqty = "ordqty";
			/// <summary>
			/// 주문가격
			/// </summary>
			public const string ordprice = "ordprice";
			/// <summary>
			/// 주문조건
			/// </summary>
			public const string hogagb = "hogagb";
			/// <summary>
			/// 호가유형코드
			/// </summary>
			public const string etfhogagb = "etfhogagb";
			/// <summary>
			/// 프로그램호가구분
			/// </summary>
			public const string pgmtype = "pgmtype";
			/// <summary>
			/// 공매도호가구분
			/// </summary>
			public const string gmhogagb = "gmhogagb";
			/// <summary>
			/// 공매도가능여부
			/// </summary>
			public const string gmhogayn = "gmhogayn";
			/// <summary>
			/// 신용구분
			/// </summary>
			public const string singb = "singb";
			/// <summary>
			/// 대출일
			/// </summary>
			public const string loandt = "loandt";
			/// <summary>
			/// 반대매매주문구분
			/// </summary>
			public const string cvrgordtp = "cvrgordtp";
			/// <summary>
			/// 전략코드
			/// </summary>
			public const string strtgcode = "strtgcode";
			/// <summary>
			/// 그룹ID
			/// </summary>
			public const string groupid = "groupid";
			/// <summary>
			/// 주문회차
			/// </summary>
			public const string ordseqno = "ordseqno";
			/// <summary>
			/// 포트폴리오번호
			/// </summary>
			public const string prtno = "prtno";
			/// <summary>
			/// 바스켓번호
			/// </summary>
			public const string basketno = "basketno";
			/// <summary>
			/// 트렌치번호
			/// </summary>
			public const string trchno = "trchno";
			/// <summary>
			/// 아아템번호
			/// </summary>
			public const string itemno = "itemno";
			/// <summary>
			/// 차입구분
			/// </summary>
			public const string brwmgmyn = "brwmgmyn";
			/// <summary>
			/// 회원사번호
			/// </summary>
			public const string mbrno = "mbrno";
			/// <summary>
			/// 처리구분
			/// </summary>
			public const string procgb = "procgb";
			/// <summary>
			/// 관리지점번호
			/// </summary>
			public const string admbrchno = "admbrchno";
			/// <summary>
			/// 선물계좌번호
			/// </summary>
			public const string futaccno = "futaccno";
			/// <summary>
			/// 선물상품구분
			/// </summary>
			public const string futmarketgb = "futmarketgb";
			/// <summary>
			/// 통신매체구분
			/// </summary>
			public const string tongsingb = "tongsingb";
			/// <summary>
			/// 유동성공급자구분
			/// </summary>
			public const string lpgb = "lpgb";
			/// <summary>
			/// DUMMY
			/// </summary>
			public const string dummy = "dummy";
			/// <summary>
			/// 주문번호
			/// </summary>
			public const string ordno = "ordno";
			/// <summary>
			/// 주문시각
			/// </summary>
			public const string ordtm = "ordtm";
			/// <summary>
			/// 모주문번호
			/// </summary>
			public const string prntordno = "prntordno";
			/// <summary>
			/// 관리사원번호
			/// </summary>
			public const string mgempno = "mgempno";
			/// <summary>
			/// 원주문미체결수량
			/// </summary>
			public const string orgordundrqty = "orgordundrqty";
			/// <summary>
			/// 원주문정정수량
			/// </summary>
			public const string orgordmdfyqty = "orgordmdfyqty";
			/// <summary>
			/// 원주문취소수량
			/// </summary>
			public const string ordordcancelqty = "ordordcancelqty";
			/// <summary>
			/// 비회원사송신번호
			/// </summary>
			public const string nmcpysndno = "nmcpysndno";
			/// <summary>
			/// 주문금액
			/// </summary>
			public const string ordamt = "ordamt";
			/// <summary>
			/// 매매구분
			/// </summary>
			public const string bnstp = "bnstp";
			/// <summary>
			/// 예비주문번호
			/// </summary>
			public const string spareordno = "spareordno";
			/// <summary>
			/// 반대매매일련번호
			/// </summary>
			public const string cvrgseqno = "cvrgseqno";
			/// <summary>
			/// 예약주문번호
			/// </summary>
			public const string rsvordno = "rsvordno";
			/// <summary>
			/// 복수주문일련번호
			/// </summary>
			public const string mtordseqno = "mtordseqno";
			/// <summary>
			/// 예비주문수량
			/// </summary>
			public const string spareordqty = "spareordqty";
			/// <summary>
			/// 주문사원번호
			/// </summary>
			public const string orduserid = "orduserid";
			/// <summary>
			/// 실물주문수량
			/// </summary>
			public const string spotordqty = "spotordqty";
			/// <summary>
			/// 재사용주문수량
			/// </summary>
			public const string ordruseqty = "ordruseqty";
			/// <summary>
			/// 현금주문금액
			/// </summary>
			public const string mnyordamt = "mnyordamt";
			/// <summary>
			/// 주문대용금액
			/// </summary>
			public const string ordsubstamt = "ordsubstamt";
			/// <summary>
			/// 재사용주문금액
			/// </summary>
			public const string ruseordamt = "ruseordamt";
			/// <summary>
			/// 수수료주문금액
			/// </summary>
			public const string ordcmsnamt = "ordcmsnamt";
			/// <summary>
			/// 사용신용담보재사용금
			/// </summary>
			public const string crdtuseamt = "crdtuseamt";
			/// <summary>
			/// 잔고수량
			/// </summary>
			public const string secbalqty = "secbalqty";
			/// <summary>
			/// 실물가능수량
			/// </summary>
			public const string spotordableqty = "spotordableqty";
			/// <summary>
			/// 재사용가능수량(매도)
			/// </summary>
			public const string ordableruseqty = "ordableruseqty";
			/// <summary>
			/// 변동수량
			/// </summary>
			public const string flctqty = "flctqty";
			/// <summary>
			/// 잔고수량(D2)
			/// </summary>
			public const string secbalqtyd2 = "secbalqtyd2";
			/// <summary>
			/// 매도주문가능수량
			/// </summary>
			public const string sellableqty = "sellableqty";
			/// <summary>
			/// 미체결매도주문수량
			/// </summary>
			public const string unercsellordqty = "unercsellordqty";
			/// <summary>
			/// 평균매입가
			/// </summary>
			public const string avrpchsprc = "avrpchsprc";
			/// <summary>
			/// 매입금액
			/// </summary>
			public const string pchsamt = "pchsamt";
			/// <summary>
			/// 예수금
			/// </summary>
			public const string deposit = "deposit";
			/// <summary>
			/// 대용금
			/// </summary>
			public const string substamt = "substamt";
			/// <summary>
			/// 위탁증거금현금
			/// </summary>
			public const string csgnmnymgn = "csgnmnymgn";
			/// <summary>
			/// 위탁증거금대용
			/// </summary>
			public const string csgnsubstmgn = "csgnsubstmgn";
			/// <summary>
			/// 신용담보재사용금
			/// </summary>
			public const string crdtpldgruseamt = "crdtpldgruseamt";
			/// <summary>
			/// 주문가능현금
			/// </summary>
			public const string ordablemny = "ordablemny";
			/// <summary>
			/// 주문가능대용
			/// </summary>
			public const string ordablesubstamt = "ordablesubstamt";
			/// <summary>
			/// 재사용가능금액
			/// </summary>
			public const string ruseableamt = "ruseableamt";
		}

		public static string[] AllFields = new string[]
		{
			F.lineseq,
			F.accno,
			F.user,
			F.len,
			F.gubun,
			F.compress,
			F.encrypt,
			F.offset,
			F.trcode,
			F.compid,
			F.userid,
			F.media,
			F.ifid,
			F.seq,
			F.trid,
			F.pubip,
			F.prvip,
			F.pcbpno,
			F.bpno,
			F.termno,
			F.lang,
			F.proctm,
			F.msgcode,
			F.outgu,
			F.compreq,
			F.funckey,
			F.reqcnt,
			F.filler,
			F.cont,
			F.contkey,
			F.varlen,
			F.varhdlen,
			F.varmsglen,
			F.trsrc,
			F.eventid,
			F.ifinfo,
			F.filler1,
			F.ordchegb,
			F.marketgb,
			F.ordgb,
			F.orgordno,
			F.accno1,
			F.accno2,
			F.passwd,
			F.expcode,
			F.shtcode,
			F.hname,
			F.ordqty,
			F.ordprice,
			F.hogagb,
			F.etfhogagb,
			F.pgmtype,
			F.gmhogagb,
			F.gmhogayn,
			F.singb,
			F.loandt,
			F.cvrgordtp,
			F.strtgcode,
			F.groupid,
			F.ordseqno,
			F.prtno,
			F.basketno,
			F.trchno,
			F.itemno,
			F.brwmgmyn,
			F.mbrno,
			F.procgb,
			F.admbrchno,
			F.futaccno,
			F.futmarketgb,
			F.tongsingb,
			F.lpgb,
			F.dummy,
			F.ordno,
			F.ordtm,
			F.prntordno,
			F.mgempno,
			F.orgordundrqty,
			F.orgordmdfyqty,
			F.ordordcancelqty,
			F.nmcpysndno,
			F.ordamt,
			F.bnstp,
			F.spareordno,
			F.cvrgseqno,
			F.rsvordno,
			F.mtordseqno,
			F.spareordqty,
			F.orduserid,
			F.spotordqty,
			F.ordruseqty,
			F.mnyordamt,
			F.ordsubstamt,
			F.ruseordamt,
			F.ordcmsnamt,
			F.crdtuseamt,
			F.secbalqty,
			F.spotordableqty,
			F.ordableruseqty,
			F.flctqty,
			F.secbalqtyd2,
			F.sellableqty,
			F.unercsellordqty,
			F.avrpchsprc,
			F.pchsamt,
			F.deposit,
			F.substamt,
			F.csgnmnymgn,
			F.csgnsubstmgn,
			F.crdtpldgruseamt,
			F.ordablemny,
			F.ordablesubstamt,
			F.ruseableamt,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["lineseq"] = new XAQueryFieldInfo("long", lineseq, lineseq.ToString("d10"), "라인일련번호", (decimal)10);
			dict["accno"] = new XAQueryFieldInfo("char", accno, accno, "계좌번호", (decimal)11);
			dict["user"] = new XAQueryFieldInfo("char", user, user, "조작자ID", (decimal)8);
			dict["len"] = new XAQueryFieldInfo("long", len, len.ToString("d6"), "헤더길이", (decimal)6);
			dict["gubun"] = new XAQueryFieldInfo("char", gubun, gubun.ToString(), "헤더구분", (decimal)1);
			dict["compress"] = new XAQueryFieldInfo("char", compress, compress.ToString(), "압축구분", (decimal)1);
			dict["encrypt"] = new XAQueryFieldInfo("char", encrypt, encrypt.ToString(), "암호구분", (decimal)1);
			dict["offset"] = new XAQueryFieldInfo("long", offset, offset.ToString("d3"), "공통시작지점", (decimal)3);
			dict["trcode"] = new XAQueryFieldInfo("char", trcode, trcode, "TRCODE", (decimal)8);
			dict["compid"] = new XAQueryFieldInfo("char", compid, compid, "이용사번호", (decimal)3);
			dict["userid"] = new XAQueryFieldInfo("char", userid, userid, "사용자ID", (decimal)16);
			dict["media"] = new XAQueryFieldInfo("char", media, media, "접속매체", (decimal)2);
			dict["ifid"] = new XAQueryFieldInfo("char", ifid, ifid, "I/F일련번호", (decimal)3);
			dict["seq"] = new XAQueryFieldInfo("char", seq, seq, "전문일련번호", (decimal)9);
			dict["trid"] = new XAQueryFieldInfo("char", trid, trid, "TR추적ID", (decimal)16);
			dict["pubip"] = new XAQueryFieldInfo("char", pubip, pubip, "공인IP", (decimal)12);
			dict["prvip"] = new XAQueryFieldInfo("char", prvip, prvip, "사설IP", (decimal)12);
			dict["pcbpno"] = new XAQueryFieldInfo("char", pcbpno, pcbpno, "처리지점번호", (decimal)3);
			dict["bpno"] = new XAQueryFieldInfo("char", bpno, bpno, "지점번호", (decimal)3);
			dict["termno"] = new XAQueryFieldInfo("char", termno, termno, "단말번호", (decimal)8);
			dict["lang"] = new XAQueryFieldInfo("char", lang, lang.ToString(), "언어구분", (decimal)1);
			dict["proctm"] = new XAQueryFieldInfo("long", proctm, proctm.ToString("d9"), "AP처리시간", (decimal)9);
			dict["msgcode"] = new XAQueryFieldInfo("char", msgcode, msgcode, "메세지코드", (decimal)4);
			dict["outgu"] = new XAQueryFieldInfo("char", outgu, outgu.ToString(), "메세지출력구분", (decimal)1);
			dict["compreq"] = new XAQueryFieldInfo("char", compreq, compreq.ToString(), "압축요청구분", (decimal)1);
			dict["funckey"] = new XAQueryFieldInfo("char", funckey, funckey, "기능키", (decimal)4);
			dict["reqcnt"] = new XAQueryFieldInfo("long", reqcnt, reqcnt.ToString("d4"), "요청레코드개수", (decimal)4);
			dict["filler"] = new XAQueryFieldInfo("char", filler, filler, "예비영역", (decimal)6);
			dict["cont"] = new XAQueryFieldInfo("char", cont, cont.ToString(), "연속구분", (decimal)1);
			dict["contkey"] = new XAQueryFieldInfo("char", contkey, contkey, "연속키값", (decimal)18);
			dict["varlen"] = new XAQueryFieldInfo("long", varlen, varlen.ToString("d2"), "가변시스템길이", (decimal)2);
			dict["varhdlen"] = new XAQueryFieldInfo("long", varhdlen, varhdlen.ToString("d2"), "가변해더길이", (decimal)2);
			dict["varmsglen"] = new XAQueryFieldInfo("long", varmsglen, varmsglen.ToString("d2"), "가변메시지길이", (decimal)2);
			dict["trsrc"] = new XAQueryFieldInfo("char", trsrc, trsrc.ToString(), "조회발원지", (decimal)1);
			dict["eventid"] = new XAQueryFieldInfo("char", eventid, eventid, "I/F이벤트ID", (decimal)4);
			dict["ifinfo"] = new XAQueryFieldInfo("char", ifinfo, ifinfo, "I/F정보", (decimal)4);
			dict["filler1"] = new XAQueryFieldInfo("char", filler1, filler1, "예비영역", (decimal)41);
			dict["ordchegb"] = new XAQueryFieldInfo("char", ordchegb, ordchegb, "주문체결구분", (decimal)2);
			dict["marketgb"] = new XAQueryFieldInfo("char", marketgb, marketgb, "시장구분", (decimal)2);
			dict["ordgb"] = new XAQueryFieldInfo("char", ordgb, ordgb, "주문구분", (decimal)2);
			dict["orgordno"] = new XAQueryFieldInfo("long", orgordno, orgordno.ToString("d10"), "원주문번호", (decimal)10);
			dict["accno1"] = new XAQueryFieldInfo("char", accno1, accno1, "계좌번호", (decimal)11);
			dict["accno2"] = new XAQueryFieldInfo("char", accno2, accno2, "계좌번호", (decimal)9);
			dict["passwd"] = new XAQueryFieldInfo("char", passwd, passwd, "비밀번호", (decimal)8);
			dict["expcode"] = new XAQueryFieldInfo("char", expcode, expcode, "종목번호", (decimal)12);
			dict["shtcode"] = new XAQueryFieldInfo("char", shtcode, shtcode, "단축종목번호", (decimal)9);
			dict["hname"] = new XAQueryFieldInfo("char", hname, hname, "종목명", (decimal)40);
			dict["ordqty"] = new XAQueryFieldInfo("long", ordqty, ordqty.ToString("d16"), "주문수량", (decimal)16);
			dict["ordprice"] = new XAQueryFieldInfo("long", ordprice, ordprice.ToString("d13"), "주문가격", (decimal)13);
			dict["hogagb"] = new XAQueryFieldInfo("char", hogagb, hogagb.ToString(), "주문조건", (decimal)1);
			dict["etfhogagb"] = new XAQueryFieldInfo("char", etfhogagb, etfhogagb, "호가유형코드", (decimal)2);
			dict["pgmtype"] = new XAQueryFieldInfo("long", pgmtype, pgmtype.ToString("d2"), "프로그램호가구분", (decimal)2);
			dict["gmhogagb"] = new XAQueryFieldInfo("long", gmhogagb, gmhogagb.ToString("d1"), "공매도호가구분", (decimal)1);
			dict["gmhogayn"] = new XAQueryFieldInfo("long", gmhogayn, gmhogayn.ToString("d1"), "공매도가능여부", (decimal)1);
			dict["singb"] = new XAQueryFieldInfo("char", singb, singb, "신용구분", (decimal)3);
			dict["loandt"] = new XAQueryFieldInfo("char", loandt, loandt, "대출일", (decimal)8);
			dict["cvrgordtp"] = new XAQueryFieldInfo("char", cvrgordtp, cvrgordtp.ToString(), "반대매매주문구분", (decimal)1);
			dict["strtgcode"] = new XAQueryFieldInfo("char", strtgcode, strtgcode, "전략코드", (decimal)6);
			dict["groupid"] = new XAQueryFieldInfo("char", groupid, groupid, "그룹ID", (decimal)20);
			dict["ordseqno"] = new XAQueryFieldInfo("long", ordseqno, ordseqno.ToString("d10"), "주문회차", (decimal)10);
			dict["prtno"] = new XAQueryFieldInfo("long", prtno, prtno.ToString("d10"), "포트폴리오번호", (decimal)10);
			dict["basketno"] = new XAQueryFieldInfo("long", basketno, basketno.ToString("d10"), "바스켓번호", (decimal)10);
			dict["trchno"] = new XAQueryFieldInfo("long", trchno, trchno.ToString("d10"), "트렌치번호", (decimal)10);
			dict["itemno"] = new XAQueryFieldInfo("long", itemno, itemno.ToString("d10"), "아아템번호", (decimal)10);
			dict["brwmgmyn"] = new XAQueryFieldInfo("long", brwmgmyn, brwmgmyn.ToString("d1"), "차입구분", (decimal)1);
			dict["mbrno"] = new XAQueryFieldInfo("long", mbrno, mbrno.ToString("d3"), "회원사번호", (decimal)3);
			dict["procgb"] = new XAQueryFieldInfo("char", procgb, procgb.ToString(), "처리구분", (decimal)1);
			dict["admbrchno"] = new XAQueryFieldInfo("char", admbrchno, admbrchno, "관리지점번호", (decimal)3);
			dict["futaccno"] = new XAQueryFieldInfo("char", futaccno, futaccno, "선물계좌번호", (decimal)20);
			dict["futmarketgb"] = new XAQueryFieldInfo("char", futmarketgb, futmarketgb.ToString(), "선물상품구분", (decimal)1);
			dict["tongsingb"] = new XAQueryFieldInfo("char", tongsingb, tongsingb, "통신매체구분", (decimal)2);
			dict["lpgb"] = new XAQueryFieldInfo("char", lpgb, lpgb.ToString(), "유동성공급자구분", (decimal)1);
			dict["dummy"] = new XAQueryFieldInfo("char", dummy, dummy, "DUMMY", (decimal)20);
			dict["ordno"] = new XAQueryFieldInfo("long", ordno, ordno.ToString("d10"), "주문번호", (decimal)10);
			dict["ordtm"] = new XAQueryFieldInfo("char", ordtm, ordtm, "주문시각", (decimal)9);
			dict["prntordno"] = new XAQueryFieldInfo("long", prntordno, prntordno.ToString("d10"), "모주문번호", (decimal)10);
			dict["mgempno"] = new XAQueryFieldInfo("char", mgempno, mgempno, "관리사원번호", (decimal)9);
			dict["orgordundrqty"] = new XAQueryFieldInfo("long", orgordundrqty, orgordundrqty.ToString("d16"), "원주문미체결수량", (decimal)16);
			dict["orgordmdfyqty"] = new XAQueryFieldInfo("long", orgordmdfyqty, orgordmdfyqty.ToString("d16"), "원주문정정수량", (decimal)16);
			dict["ordordcancelqty"] = new XAQueryFieldInfo("long", ordordcancelqty, ordordcancelqty.ToString("d16"), "원주문취소수량", (decimal)16);
			dict["nmcpysndno"] = new XAQueryFieldInfo("long", nmcpysndno, nmcpysndno.ToString("d10"), "비회원사송신번호", (decimal)10);
			dict["ordamt"] = new XAQueryFieldInfo("long", ordamt, ordamt.ToString("d16"), "주문금액", (decimal)16);
			dict["bnstp"] = new XAQueryFieldInfo("char", bnstp, bnstp.ToString(), "매매구분", (decimal)1);
			dict["spareordno"] = new XAQueryFieldInfo("long", spareordno, spareordno.ToString("d10"), "예비주문번호", (decimal)10);
			dict["cvrgseqno"] = new XAQueryFieldInfo("long", cvrgseqno, cvrgseqno.ToString("d10"), "반대매매일련번호", (decimal)10);
			dict["rsvordno"] = new XAQueryFieldInfo("long", rsvordno, rsvordno.ToString("d10"), "예약주문번호", (decimal)10);
			dict["mtordseqno"] = new XAQueryFieldInfo("long", mtordseqno, mtordseqno.ToString("d10"), "복수주문일련번호", (decimal)10);
			dict["spareordqty"] = new XAQueryFieldInfo("long", spareordqty, spareordqty.ToString("d16"), "예비주문수량", (decimal)16);
			dict["orduserid"] = new XAQueryFieldInfo("char", orduserid, orduserid, "주문사원번호", (decimal)16);
			dict["spotordqty"] = new XAQueryFieldInfo("long", spotordqty, spotordqty.ToString("d16"), "실물주문수량", (decimal)16);
			dict["ordruseqty"] = new XAQueryFieldInfo("long", ordruseqty, ordruseqty.ToString("d16"), "재사용주문수량", (decimal)16);
			dict["mnyordamt"] = new XAQueryFieldInfo("long", mnyordamt, mnyordamt.ToString("d16"), "현금주문금액", (decimal)16);
			dict["ordsubstamt"] = new XAQueryFieldInfo("long", ordsubstamt, ordsubstamt.ToString("d16"), "주문대용금액", (decimal)16);
			dict["ruseordamt"] = new XAQueryFieldInfo("long", ruseordamt, ruseordamt.ToString("d16"), "재사용주문금액", (decimal)16);
			dict["ordcmsnamt"] = new XAQueryFieldInfo("long", ordcmsnamt, ordcmsnamt.ToString("d16"), "수수료주문금액", (decimal)16);
			dict["crdtuseamt"] = new XAQueryFieldInfo("long", crdtuseamt, crdtuseamt.ToString("d16"), "사용신용담보재사용금", (decimal)16);
			dict["secbalqty"] = new XAQueryFieldInfo("long", secbalqty, secbalqty.ToString("d16"), "잔고수량", (decimal)16);
			dict["spotordableqty"] = new XAQueryFieldInfo("long", spotordableqty, spotordableqty.ToString("d16"), "실물가능수량", (decimal)16);
			dict["ordableruseqty"] = new XAQueryFieldInfo("long", ordableruseqty, ordableruseqty.ToString("d16"), "재사용가능수량(매도)", (decimal)16);
			dict["flctqty"] = new XAQueryFieldInfo("long", flctqty, flctqty.ToString("d16"), "변동수량", (decimal)16);
			dict["secbalqtyd2"] = new XAQueryFieldInfo("long", secbalqtyd2, secbalqtyd2.ToString("d16"), "잔고수량(D2)", (decimal)16);
			dict["sellableqty"] = new XAQueryFieldInfo("long", sellableqty, sellableqty.ToString("d16"), "매도주문가능수량", (decimal)16);
			dict["unercsellordqty"] = new XAQueryFieldInfo("long", unercsellordqty, unercsellordqty.ToString("d16"), "미체결매도주문수량", (decimal)16);
			dict["avrpchsprc"] = new XAQueryFieldInfo("long", avrpchsprc, avrpchsprc.ToString("d13"), "평균매입가", (decimal)13);
			dict["pchsamt"] = new XAQueryFieldInfo("long", pchsamt, pchsamt.ToString("d16"), "매입금액", (decimal)16);
			dict["deposit"] = new XAQueryFieldInfo("long", deposit, deposit.ToString("d16"), "예수금", (decimal)16);
			dict["substamt"] = new XAQueryFieldInfo("long", substamt, substamt.ToString("d16"), "대용금", (decimal)16);
			dict["csgnmnymgn"] = new XAQueryFieldInfo("long", csgnmnymgn, csgnmnymgn.ToString("d16"), "위탁증거금현금", (decimal)16);
			dict["csgnsubstmgn"] = new XAQueryFieldInfo("long", csgnsubstmgn, csgnsubstmgn.ToString("d16"), "위탁증거금대용", (decimal)16);
			dict["crdtpldgruseamt"] = new XAQueryFieldInfo("long", crdtpldgruseamt, crdtpldgruseamt.ToString("d16"), "신용담보재사용금", (decimal)16);
			dict["ordablemny"] = new XAQueryFieldInfo("long", ordablemny, ordablemny.ToString("d16"), "주문가능현금", (decimal)16);
			dict["ordablesubstamt"] = new XAQueryFieldInfo("long", ordablesubstamt, ordablesubstamt.ToString("d16"), "주문가능대용", (decimal)16);
			dict["ruseableamt"] = new XAQueryFieldInfo("long", ruseableamt, ruseableamt.ToString("d16"), "재사용가능금액", (decimal)16);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "lineseq":
					this.lineseq = fieldInfo.FieldValue.ParseLong("lineseq");
				break;

				case "accno":
					this.accno = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "user":
					this.user = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "len":
					this.len = fieldInfo.FieldValue.ParseLong("len");
				break;

				case "gubun":
					this.gubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "compress":
					this.compress = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "encrypt":
					this.encrypt = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "offset":
					this.offset = fieldInfo.FieldValue.ParseLong("offset");
				break;

				case "trcode":
					this.trcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "compid":
					this.compid = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "userid":
					this.userid = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "media":
					this.media = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ifid":
					this.ifid = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "seq":
					this.seq = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "trid":
					this.trid = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "pubip":
					this.pubip = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "prvip":
					this.prvip = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "pcbpno":
					this.pcbpno = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "bpno":
					this.bpno = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "termno":
					this.termno = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "lang":
					this.lang = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "proctm":
					this.proctm = fieldInfo.FieldValue.ParseLong("proctm");
				break;

				case "msgcode":
					this.msgcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "outgu":
					this.outgu = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "compreq":
					this.compreq = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "funckey":
					this.funckey = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "reqcnt":
					this.reqcnt = fieldInfo.FieldValue.ParseLong("reqcnt");
				break;

				case "filler":
					this.filler = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cont":
					this.cont = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "contkey":
					this.contkey = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "varlen":
					this.varlen = fieldInfo.FieldValue.ParseLong("varlen");
				break;

				case "varhdlen":
					this.varhdlen = fieldInfo.FieldValue.ParseLong("varhdlen");
				break;

				case "varmsglen":
					this.varmsglen = fieldInfo.FieldValue.ParseLong("varmsglen");
				break;

				case "trsrc":
					this.trsrc = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "eventid":
					this.eventid = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ifinfo":
					this.ifinfo = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "filler1":
					this.filler1 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ordchegb":
					this.ordchegb = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "marketgb":
					this.marketgb = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ordgb":
					this.ordgb = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "orgordno":
					this.orgordno = fieldInfo.FieldValue.ParseLong("orgordno");
				break;

				case "accno1":
					this.accno1 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "accno2":
					this.accno2 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "passwd":
					this.passwd = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "expcode":
					this.expcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "shtcode":
					this.shtcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "hname":
					this.hname = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ordqty":
					this.ordqty = fieldInfo.FieldValue.ParseLong("ordqty");
				break;

				case "ordprice":
					this.ordprice = fieldInfo.FieldValue.ParseLong("ordprice");
				break;

				case "hogagb":
					this.hogagb = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "etfhogagb":
					this.etfhogagb = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "pgmtype":
					this.pgmtype = fieldInfo.FieldValue.ParseLong("pgmtype");
				break;

				case "gmhogagb":
					this.gmhogagb = fieldInfo.FieldValue.ParseLong("gmhogagb");
				break;

				case "gmhogayn":
					this.gmhogayn = fieldInfo.FieldValue.ParseLong("gmhogayn");
				break;

				case "singb":
					this.singb = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "loandt":
					this.loandt = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cvrgordtp":
					this.cvrgordtp = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "strtgcode":
					this.strtgcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "groupid":
					this.groupid = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ordseqno":
					this.ordseqno = fieldInfo.FieldValue.ParseLong("ordseqno");
				break;

				case "prtno":
					this.prtno = fieldInfo.FieldValue.ParseLong("prtno");
				break;

				case "basketno":
					this.basketno = fieldInfo.FieldValue.ParseLong("basketno");
				break;

				case "trchno":
					this.trchno = fieldInfo.FieldValue.ParseLong("trchno");
				break;

				case "itemno":
					this.itemno = fieldInfo.FieldValue.ParseLong("itemno");
				break;

				case "brwmgmyn":
					this.brwmgmyn = fieldInfo.FieldValue.ParseLong("brwmgmyn");
				break;

				case "mbrno":
					this.mbrno = fieldInfo.FieldValue.ParseLong("mbrno");
				break;

				case "procgb":
					this.procgb = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "admbrchno":
					this.admbrchno = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "futaccno":
					this.futaccno = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "futmarketgb":
					this.futmarketgb = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "tongsingb":
					this.tongsingb = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "lpgb":
					this.lpgb = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "dummy":
					this.dummy = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ordno":
					this.ordno = fieldInfo.FieldValue.ParseLong("ordno");
				break;

				case "ordtm":
					this.ordtm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "prntordno":
					this.prntordno = fieldInfo.FieldValue.ParseLong("prntordno");
				break;

				case "mgempno":
					this.mgempno = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "orgordundrqty":
					this.orgordundrqty = fieldInfo.FieldValue.ParseLong("orgordundrqty");
				break;

				case "orgordmdfyqty":
					this.orgordmdfyqty = fieldInfo.FieldValue.ParseLong("orgordmdfyqty");
				break;

				case "ordordcancelqty":
					this.ordordcancelqty = fieldInfo.FieldValue.ParseLong("ordordcancelqty");
				break;

				case "nmcpysndno":
					this.nmcpysndno = fieldInfo.FieldValue.ParseLong("nmcpysndno");
				break;

				case "ordamt":
					this.ordamt = fieldInfo.FieldValue.ParseLong("ordamt");
				break;

				case "bnstp":
					this.bnstp = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "spareordno":
					this.spareordno = fieldInfo.FieldValue.ParseLong("spareordno");
				break;

				case "cvrgseqno":
					this.cvrgseqno = fieldInfo.FieldValue.ParseLong("cvrgseqno");
				break;

				case "rsvordno":
					this.rsvordno = fieldInfo.FieldValue.ParseLong("rsvordno");
				break;

				case "mtordseqno":
					this.mtordseqno = fieldInfo.FieldValue.ParseLong("mtordseqno");
				break;

				case "spareordqty":
					this.spareordqty = fieldInfo.FieldValue.ParseLong("spareordqty");
				break;

				case "orduserid":
					this.orduserid = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "spotordqty":
					this.spotordqty = fieldInfo.FieldValue.ParseLong("spotordqty");
				break;

				case "ordruseqty":
					this.ordruseqty = fieldInfo.FieldValue.ParseLong("ordruseqty");
				break;

				case "mnyordamt":
					this.mnyordamt = fieldInfo.FieldValue.ParseLong("mnyordamt");
				break;

				case "ordsubstamt":
					this.ordsubstamt = fieldInfo.FieldValue.ParseLong("ordsubstamt");
				break;

				case "ruseordamt":
					this.ruseordamt = fieldInfo.FieldValue.ParseLong("ruseordamt");
				break;

				case "ordcmsnamt":
					this.ordcmsnamt = fieldInfo.FieldValue.ParseLong("ordcmsnamt");
				break;

				case "crdtuseamt":
					this.crdtuseamt = fieldInfo.FieldValue.ParseLong("crdtuseamt");
				break;

				case "secbalqty":
					this.secbalqty = fieldInfo.FieldValue.ParseLong("secbalqty");
				break;

				case "spotordableqty":
					this.spotordableqty = fieldInfo.FieldValue.ParseLong("spotordableqty");
				break;

				case "ordableruseqty":
					this.ordableruseqty = fieldInfo.FieldValue.ParseLong("ordableruseqty");
				break;

				case "flctqty":
					this.flctqty = fieldInfo.FieldValue.ParseLong("flctqty");
				break;

				case "secbalqtyd2":
					this.secbalqtyd2 = fieldInfo.FieldValue.ParseLong("secbalqtyd2");
				break;

				case "sellableqty":
					this.sellableqty = fieldInfo.FieldValue.ParseLong("sellableqty");
				break;

				case "unercsellordqty":
					this.unercsellordqty = fieldInfo.FieldValue.ParseLong("unercsellordqty");
				break;

				case "avrpchsprc":
					this.avrpchsprc = fieldInfo.FieldValue.ParseLong("avrpchsprc");
				break;

				case "pchsamt":
					this.pchsamt = fieldInfo.FieldValue.ParseLong("pchsamt");
				break;

				case "deposit":
					this.deposit = fieldInfo.FieldValue.ParseLong("deposit");
				break;

				case "substamt":
					this.substamt = fieldInfo.FieldValue.ParseLong("substamt");
				break;

				case "csgnmnymgn":
					this.csgnmnymgn = fieldInfo.FieldValue.ParseLong("csgnmnymgn");
				break;

				case "csgnsubstmgn":
					this.csgnsubstmgn = fieldInfo.FieldValue.ParseLong("csgnsubstmgn");
				break;

				case "crdtpldgruseamt":
					this.crdtpldgruseamt = fieldInfo.FieldValue.ParseLong("crdtpldgruseamt");
				break;

				case "ordablemny":
					this.ordablemny = fieldInfo.FieldValue.ParseLong("ordablemny");
				break;

				case "ordablesubstamt":
					this.ordablesubstamt = fieldInfo.FieldValue.ParseLong("ordablesubstamt");
				break;

				case "ruseableamt":
					this.ruseableamt = fieldInfo.FieldValue.ParseLong("ruseableamt");
				break;


			}
		}

		public static XRSC0OutBlock FromQuery(XRSC0 query)
		{
			XRSC0OutBlock block = new XRSC0OutBlock();
			block.IsValidData = true;
			block.InvalidReason = "";
			try
			{
				block.lineseq = query.GetFieldData(block.GetBlockName(), "lineseq").ParseLong("lineseq"); // long 10
				block.accno = query.GetFieldData(block.GetBlockName(), "accno").TrimEnd('?'); // char 11
				block.user = query.GetFieldData(block.GetBlockName(), "user").TrimEnd('?'); // char 8
				block.len = query.GetFieldData(block.GetBlockName(), "len").ParseLong("len"); // long 6
				block.gubun = query.GetFieldData(block.GetBlockName(), "gubun").FirstOrDefault(); // char 1
				block.compress = query.GetFieldData(block.GetBlockName(), "compress").FirstOrDefault(); // char 1
				block.encrypt = query.GetFieldData(block.GetBlockName(), "encrypt").FirstOrDefault(); // char 1
				block.offset = query.GetFieldData(block.GetBlockName(), "offset").ParseLong("offset"); // long 3
				block.trcode = query.GetFieldData(block.GetBlockName(), "trcode").TrimEnd('?'); // char 8
				block.compid = query.GetFieldData(block.GetBlockName(), "compid").TrimEnd('?'); // char 3
				block.userid = query.GetFieldData(block.GetBlockName(), "userid").TrimEnd('?'); // char 16
				block.media = query.GetFieldData(block.GetBlockName(), "media").TrimEnd('?'); // char 2
				block.ifid = query.GetFieldData(block.GetBlockName(), "ifid").TrimEnd('?'); // char 3
				block.seq = query.GetFieldData(block.GetBlockName(), "seq").TrimEnd('?'); // char 9
				block.trid = query.GetFieldData(block.GetBlockName(), "trid").TrimEnd('?'); // char 16
				block.pubip = query.GetFieldData(block.GetBlockName(), "pubip").TrimEnd('?'); // char 12
				block.prvip = query.GetFieldData(block.GetBlockName(), "prvip").TrimEnd('?'); // char 12
				block.pcbpno = query.GetFieldData(block.GetBlockName(), "pcbpno").TrimEnd('?'); // char 3
				block.bpno = query.GetFieldData(block.GetBlockName(), "bpno").TrimEnd('?'); // char 3
				block.termno = query.GetFieldData(block.GetBlockName(), "termno").TrimEnd('?'); // char 8
				block.lang = query.GetFieldData(block.GetBlockName(), "lang").FirstOrDefault(); // char 1
				block.proctm = query.GetFieldData(block.GetBlockName(), "proctm").ParseLong("proctm"); // long 9
				block.msgcode = query.GetFieldData(block.GetBlockName(), "msgcode").TrimEnd('?'); // char 4
				block.outgu = query.GetFieldData(block.GetBlockName(), "outgu").FirstOrDefault(); // char 1
				block.compreq = query.GetFieldData(block.GetBlockName(), "compreq").FirstOrDefault(); // char 1
				block.funckey = query.GetFieldData(block.GetBlockName(), "funckey").TrimEnd('?'); // char 4
				block.reqcnt = query.GetFieldData(block.GetBlockName(), "reqcnt").ParseLong("reqcnt"); // long 4
				block.filler = query.GetFieldData(block.GetBlockName(), "filler").TrimEnd('?'); // char 6
				block.cont = query.GetFieldData(block.GetBlockName(), "cont").FirstOrDefault(); // char 1
				block.contkey = query.GetFieldData(block.GetBlockName(), "contkey").TrimEnd('?'); // char 18
				block.varlen = query.GetFieldData(block.GetBlockName(), "varlen").ParseLong("varlen"); // long 2
				block.varhdlen = query.GetFieldData(block.GetBlockName(), "varhdlen").ParseLong("varhdlen"); // long 2
				block.varmsglen = query.GetFieldData(block.GetBlockName(), "varmsglen").ParseLong("varmsglen"); // long 2
				block.trsrc = query.GetFieldData(block.GetBlockName(), "trsrc").FirstOrDefault(); // char 1
				block.eventid = query.GetFieldData(block.GetBlockName(), "eventid").TrimEnd('?'); // char 4
				block.ifinfo = query.GetFieldData(block.GetBlockName(), "ifinfo").TrimEnd('?'); // char 4
				block.filler1 = query.GetFieldData(block.GetBlockName(), "filler1").TrimEnd('?'); // char 41
				block.ordchegb = query.GetFieldData(block.GetBlockName(), "ordchegb").TrimEnd('?'); // char 2
				block.marketgb = query.GetFieldData(block.GetBlockName(), "marketgb").TrimEnd('?'); // char 2
				block.ordgb = query.GetFieldData(block.GetBlockName(), "ordgb").TrimEnd('?'); // char 2
				block.orgordno = query.GetFieldData(block.GetBlockName(), "orgordno").ParseLong("orgordno"); // long 10
				block.accno1 = query.GetFieldData(block.GetBlockName(), "accno1").TrimEnd('?'); // char 11
				block.accno2 = query.GetFieldData(block.GetBlockName(), "accno2").TrimEnd('?'); // char 9
				block.passwd = query.GetFieldData(block.GetBlockName(), "passwd").TrimEnd('?'); // char 8
				block.expcode = query.GetFieldData(block.GetBlockName(), "expcode").TrimEnd('?'); // char 12
				block.shtcode = query.GetFieldData(block.GetBlockName(), "shtcode").TrimEnd('?'); // char 9
				block.hname = query.GetFieldData(block.GetBlockName(), "hname").TrimEnd('?'); // char 40
				block.ordqty = query.GetFieldData(block.GetBlockName(), "ordqty").ParseLong("ordqty"); // long 16
				block.ordprice = query.GetFieldData(block.GetBlockName(), "ordprice").ParseLong("ordprice"); // long 13
				block.hogagb = query.GetFieldData(block.GetBlockName(), "hogagb").FirstOrDefault(); // char 1
				block.etfhogagb = query.GetFieldData(block.GetBlockName(), "etfhogagb").TrimEnd('?'); // char 2
				block.pgmtype = query.GetFieldData(block.GetBlockName(), "pgmtype").ParseLong("pgmtype"); // long 2
				block.gmhogagb = query.GetFieldData(block.GetBlockName(), "gmhogagb").ParseLong("gmhogagb"); // long 1
				block.gmhogayn = query.GetFieldData(block.GetBlockName(), "gmhogayn").ParseLong("gmhogayn"); // long 1
				block.singb = query.GetFieldData(block.GetBlockName(), "singb").TrimEnd('?'); // char 3
				block.loandt = query.GetFieldData(block.GetBlockName(), "loandt").TrimEnd('?'); // char 8
				block.cvrgordtp = query.GetFieldData(block.GetBlockName(), "cvrgordtp").FirstOrDefault(); // char 1
				block.strtgcode = query.GetFieldData(block.GetBlockName(), "strtgcode").TrimEnd('?'); // char 6
				block.groupid = query.GetFieldData(block.GetBlockName(), "groupid").TrimEnd('?'); // char 20
				block.ordseqno = query.GetFieldData(block.GetBlockName(), "ordseqno").ParseLong("ordseqno"); // long 10
				block.prtno = query.GetFieldData(block.GetBlockName(), "prtno").ParseLong("prtno"); // long 10
				block.basketno = query.GetFieldData(block.GetBlockName(), "basketno").ParseLong("basketno"); // long 10
				block.trchno = query.GetFieldData(block.GetBlockName(), "trchno").ParseLong("trchno"); // long 10
				block.itemno = query.GetFieldData(block.GetBlockName(), "itemno").ParseLong("itemno"); // long 10
				block.brwmgmyn = query.GetFieldData(block.GetBlockName(), "brwmgmyn").ParseLong("brwmgmyn"); // long 1
				block.mbrno = query.GetFieldData(block.GetBlockName(), "mbrno").ParseLong("mbrno"); // long 3
				block.procgb = query.GetFieldData(block.GetBlockName(), "procgb").FirstOrDefault(); // char 1
				block.admbrchno = query.GetFieldData(block.GetBlockName(), "admbrchno").TrimEnd('?'); // char 3
				block.futaccno = query.GetFieldData(block.GetBlockName(), "futaccno").TrimEnd('?'); // char 20
				block.futmarketgb = query.GetFieldData(block.GetBlockName(), "futmarketgb").FirstOrDefault(); // char 1
				block.tongsingb = query.GetFieldData(block.GetBlockName(), "tongsingb").TrimEnd('?'); // char 2
				block.lpgb = query.GetFieldData(block.GetBlockName(), "lpgb").FirstOrDefault(); // char 1
				block.dummy = query.GetFieldData(block.GetBlockName(), "dummy").TrimEnd('?'); // char 20
				block.ordno = query.GetFieldData(block.GetBlockName(), "ordno").ParseLong("ordno"); // long 10
				block.ordtm = query.GetFieldData(block.GetBlockName(), "ordtm").TrimEnd('?'); // char 9
				block.prntordno = query.GetFieldData(block.GetBlockName(), "prntordno").ParseLong("prntordno"); // long 10
				block.mgempno = query.GetFieldData(block.GetBlockName(), "mgempno").TrimEnd('?'); // char 9
				block.orgordundrqty = query.GetFieldData(block.GetBlockName(), "orgordundrqty").ParseLong("orgordundrqty"); // long 16
				block.orgordmdfyqty = query.GetFieldData(block.GetBlockName(), "orgordmdfyqty").ParseLong("orgordmdfyqty"); // long 16
				block.ordordcancelqty = query.GetFieldData(block.GetBlockName(), "ordordcancelqty").ParseLong("ordordcancelqty"); // long 16
				block.nmcpysndno = query.GetFieldData(block.GetBlockName(), "nmcpysndno").ParseLong("nmcpysndno"); // long 10
				block.ordamt = query.GetFieldData(block.GetBlockName(), "ordamt").ParseLong("ordamt"); // long 16
				block.bnstp = query.GetFieldData(block.GetBlockName(), "bnstp").FirstOrDefault(); // char 1
				block.spareordno = query.GetFieldData(block.GetBlockName(), "spareordno").ParseLong("spareordno"); // long 10
				block.cvrgseqno = query.GetFieldData(block.GetBlockName(), "cvrgseqno").ParseLong("cvrgseqno"); // long 10
				block.rsvordno = query.GetFieldData(block.GetBlockName(), "rsvordno").ParseLong("rsvordno"); // long 10
				block.mtordseqno = query.GetFieldData(block.GetBlockName(), "mtordseqno").ParseLong("mtordseqno"); // long 10
				block.spareordqty = query.GetFieldData(block.GetBlockName(), "spareordqty").ParseLong("spareordqty"); // long 16
				block.orduserid = query.GetFieldData(block.GetBlockName(), "orduserid").TrimEnd('?'); // char 16
				block.spotordqty = query.GetFieldData(block.GetBlockName(), "spotordqty").ParseLong("spotordqty"); // long 16
				block.ordruseqty = query.GetFieldData(block.GetBlockName(), "ordruseqty").ParseLong("ordruseqty"); // long 16
				block.mnyordamt = query.GetFieldData(block.GetBlockName(), "mnyordamt").ParseLong("mnyordamt"); // long 16
				block.ordsubstamt = query.GetFieldData(block.GetBlockName(), "ordsubstamt").ParseLong("ordsubstamt"); // long 16
				block.ruseordamt = query.GetFieldData(block.GetBlockName(), "ruseordamt").ParseLong("ruseordamt"); // long 16
				block.ordcmsnamt = query.GetFieldData(block.GetBlockName(), "ordcmsnamt").ParseLong("ordcmsnamt"); // long 16
				block.crdtuseamt = query.GetFieldData(block.GetBlockName(), "crdtuseamt").ParseLong("crdtuseamt"); // long 16
				block.secbalqty = query.GetFieldData(block.GetBlockName(), "secbalqty").ParseLong("secbalqty"); // long 16
				block.spotordableqty = query.GetFieldData(block.GetBlockName(), "spotordableqty").ParseLong("spotordableqty"); // long 16
				block.ordableruseqty = query.GetFieldData(block.GetBlockName(), "ordableruseqty").ParseLong("ordableruseqty"); // long 16
				block.flctqty = query.GetFieldData(block.GetBlockName(), "flctqty").ParseLong("flctqty"); // long 16
				block.secbalqtyd2 = query.GetFieldData(block.GetBlockName(), "secbalqtyd2").ParseLong("secbalqtyd2"); // long 16
				block.sellableqty = query.GetFieldData(block.GetBlockName(), "sellableqty").ParseLong("sellableqty"); // long 16
				block.unercsellordqty = query.GetFieldData(block.GetBlockName(), "unercsellordqty").ParseLong("unercsellordqty"); // long 16
				block.avrpchsprc = query.GetFieldData(block.GetBlockName(), "avrpchsprc").ParseLong("avrpchsprc"); // long 13
				block.pchsamt = query.GetFieldData(block.GetBlockName(), "pchsamt").ParseLong("pchsamt"); // long 16
				block.deposit = query.GetFieldData(block.GetBlockName(), "deposit").ParseLong("deposit"); // long 16
				block.substamt = query.GetFieldData(block.GetBlockName(), "substamt").ParseLong("substamt"); // long 16
				block.csgnmnymgn = query.GetFieldData(block.GetBlockName(), "csgnmnymgn").ParseLong("csgnmnymgn"); // long 16
				block.csgnsubstmgn = query.GetFieldData(block.GetBlockName(), "csgnsubstmgn").ParseLong("csgnsubstmgn"); // long 16
				block.crdtpldgruseamt = query.GetFieldData(block.GetBlockName(), "crdtpldgruseamt").ParseLong("crdtpldgruseamt"); // long 16
				block.ordablemny = query.GetFieldData(block.GetBlockName(), "ordablemny").ParseLong("ordablemny"); // long 16
				block.ordablesubstamt = query.GetFieldData(block.GetBlockName(), "ordablesubstamt").ParseLong("ordablesubstamt"); // long 16
				block.ruseableamt = query.GetFieldData(block.GetBlockName(), "ruseableamt").ParseLong("ruseableamt"); // long 16

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (lineseq.ToString().Length > 10) return false; // long 10
			if (accno.Length > 11) return false; // char 11
			if (user.Length > 8) return false; // char 8
			if (len.ToString().Length > 6) return false; // long 6
			// gubun char 1
			// compress char 1
			// encrypt char 1
			if (offset.ToString().Length > 3) return false; // long 3
			if (trcode.Length > 8) return false; // char 8
			if (compid.Length > 3) return false; // char 3
			if (userid.Length > 16) return false; // char 16
			if (media.Length > 2) return false; // char 2
			if (ifid.Length > 3) return false; // char 3
			if (seq.Length > 9) return false; // char 9
			if (trid.Length > 16) return false; // char 16
			if (pubip.Length > 12) return false; // char 12
			if (prvip.Length > 12) return false; // char 12
			if (pcbpno.Length > 3) return false; // char 3
			if (bpno.Length > 3) return false; // char 3
			if (termno.Length > 8) return false; // char 8
			// lang char 1
			if (proctm.ToString().Length > 9) return false; // long 9
			if (msgcode.Length > 4) return false; // char 4
			// outgu char 1
			// compreq char 1
			if (funckey.Length > 4) return false; // char 4
			if (reqcnt.ToString().Length > 4) return false; // long 4
			if (filler.Length > 6) return false; // char 6
			// cont char 1
			if (contkey.Length > 18) return false; // char 18
			if (varlen.ToString().Length > 2) return false; // long 2
			if (varhdlen.ToString().Length > 2) return false; // long 2
			if (varmsglen.ToString().Length > 2) return false; // long 2
			// trsrc char 1
			if (eventid.Length > 4) return false; // char 4
			if (ifinfo.Length > 4) return false; // char 4
			if (filler1.Length > 41) return false; // char 41
			if (ordchegb.Length > 2) return false; // char 2
			if (marketgb.Length > 2) return false; // char 2
			if (ordgb.Length > 2) return false; // char 2
			if (orgordno.ToString().Length > 10) return false; // long 10
			if (accno1.Length > 11) return false; // char 11
			if (accno2.Length > 9) return false; // char 9
			if (passwd.Length > 8) return false; // char 8
			if (expcode.Length > 12) return false; // char 12
			if (shtcode.Length > 9) return false; // char 9
			if (hname.Length > 40) return false; // char 40
			if (ordqty.ToString().Length > 16) return false; // long 16
			if (ordprice.ToString().Length > 13) return false; // long 13
			// hogagb char 1
			if (etfhogagb.Length > 2) return false; // char 2
			if (pgmtype.ToString().Length > 2) return false; // long 2
			if (gmhogagb.ToString().Length > 1) return false; // long 1
			if (gmhogayn.ToString().Length > 1) return false; // long 1
			if (singb.Length > 3) return false; // char 3
			if (loandt.Length > 8) return false; // char 8
			// cvrgordtp char 1
			if (strtgcode.Length > 6) return false; // char 6
			if (groupid.Length > 20) return false; // char 20
			if (ordseqno.ToString().Length > 10) return false; // long 10
			if (prtno.ToString().Length > 10) return false; // long 10
			if (basketno.ToString().Length > 10) return false; // long 10
			if (trchno.ToString().Length > 10) return false; // long 10
			if (itemno.ToString().Length > 10) return false; // long 10
			if (brwmgmyn.ToString().Length > 1) return false; // long 1
			if (mbrno.ToString().Length > 3) return false; // long 3
			// procgb char 1
			if (admbrchno.Length > 3) return false; // char 3
			if (futaccno.Length > 20) return false; // char 20
			// futmarketgb char 1
			if (tongsingb.Length > 2) return false; // char 2
			// lpgb char 1
			if (dummy.Length > 20) return false; // char 20
			if (ordno.ToString().Length > 10) return false; // long 10
			if (ordtm.Length > 9) return false; // char 9
			if (prntordno.ToString().Length > 10) return false; // long 10
			if (mgempno.Length > 9) return false; // char 9
			if (orgordundrqty.ToString().Length > 16) return false; // long 16
			if (orgordmdfyqty.ToString().Length > 16) return false; // long 16
			if (ordordcancelqty.ToString().Length > 16) return false; // long 16
			if (nmcpysndno.ToString().Length > 10) return false; // long 10
			if (ordamt.ToString().Length > 16) return false; // long 16
			// bnstp char 1
			if (spareordno.ToString().Length > 10) return false; // long 10
			if (cvrgseqno.ToString().Length > 10) return false; // long 10
			if (rsvordno.ToString().Length > 10) return false; // long 10
			if (mtordseqno.ToString().Length > 10) return false; // long 10
			if (spareordqty.ToString().Length > 16) return false; // long 16
			if (orduserid.Length > 16) return false; // char 16
			if (spotordqty.ToString().Length > 16) return false; // long 16
			if (ordruseqty.ToString().Length > 16) return false; // long 16
			if (mnyordamt.ToString().Length > 16) return false; // long 16
			if (ordsubstamt.ToString().Length > 16) return false; // long 16
			if (ruseordamt.ToString().Length > 16) return false; // long 16
			if (ordcmsnamt.ToString().Length > 16) return false; // long 16
			if (crdtuseamt.ToString().Length > 16) return false; // long 16
			if (secbalqty.ToString().Length > 16) return false; // long 16
			if (spotordableqty.ToString().Length > 16) return false; // long 16
			if (ordableruseqty.ToString().Length > 16) return false; // long 16
			if (flctqty.ToString().Length > 16) return false; // long 16
			if (secbalqtyd2.ToString().Length > 16) return false; // long 16
			if (sellableqty.ToString().Length > 16) return false; // long 16
			if (unercsellordqty.ToString().Length > 16) return false; // long 16
			if (avrpchsprc.ToString().Length > 13) return false; // long 13
			if (pchsamt.ToString().Length > 16) return false; // long 16
			if (deposit.ToString().Length > 16) return false; // long 16
			if (substamt.ToString().Length > 16) return false; // long 16
			if (csgnmnymgn.ToString().Length > 16) return false; // long 16
			if (csgnsubstmgn.ToString().Length > 16) return false; // long 16
			if (crdtpldgruseamt.ToString().Length > 16) return false; // long 16
			if (ordablemny.ToString().Length > 16) return false; // long 16
			if (ordablesubstamt.ToString().Length > 16) return false; // long 16
			if (ruseableamt.ToString().Length > 16) return false; // long 16

			return true;
		}
	}

	public partial class XRSC0 : XingReal
	{
		/// <summary>
		/// SC0
		/// </summary>
		static readonly string _typeName = "SC0";
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _attr = false;
		/// <summary>
		/// 0
		/// </summary>
		static readonly int _key = 0;
		/// <summary>
		/// 0
		/// </summary>
		static readonly int _group = 0;

		/// <summary>
		/// SC0
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// false
		/// </summary>
		public bool Attr => _attr;
		/// <summary>
		/// 0
		/// </summary>
		public int Key => _key;
		/// <summary>
		/// 0
		/// </summary>
		public int Group => _group;

		public XRSC0() : base("SC0") { }


		public bool SetFields(XRSC0InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}


			return true;
		}

		public XRSC0OutBlock GetBlock()
		{
			XRSC0OutBlock instance = XRSC0OutBlock.FromQuery(this);
			return instance;

		}


	}

}
