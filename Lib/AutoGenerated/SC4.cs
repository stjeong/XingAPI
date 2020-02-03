using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XRSC4InBlock : XingBlock
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

	public partial class XRSC4OutBlock : XingBlock
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
		/// 주문체결유형코드
		/// </summary>
		[XAQueryFieldAttribute("주문체결유형코드")]
		public string ordxctptncode;
		/// <summary>
		/// 주문시장코드
		/// </summary>
		[XAQueryFieldAttribute("주문시장코드")]
		public string ordmktcode;
		/// <summary>
		/// 주문유형코드
		/// </summary>
		[XAQueryFieldAttribute("주문유형코드")]
		public string ordptncode;
		/// <summary>
		/// 관리지점번호
		/// </summary>
		[XAQueryFieldAttribute("관리지점번호")]
		public string mgmtbrnno;
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
		/// 계좌명
		/// </summary>
		[XAQueryFieldAttribute("계좌명")]
		public string acntnm;
		/// <summary>
		/// 종목번호
		/// </summary>
		[XAQueryFieldAttribute("종목번호")]
		public string Isuno;
		/// <summary>
		/// 종목명
		/// </summary>
		[XAQueryFieldAttribute("종목명")]
		public string Isunm;
		/// <summary>
		/// 주문번호
		/// </summary>
		[XAQueryFieldAttribute("주문번호")]
		public long ordno;
		/// <summary>
		/// 원주문번호
		/// </summary>
		[XAQueryFieldAttribute("원주문번호")]
		public long orgordno;
		/// <summary>
		/// 체결번호
		/// </summary>
		[XAQueryFieldAttribute("체결번호")]
		public long execno;
		/// <summary>
		/// 주문수량
		/// </summary>
		[XAQueryFieldAttribute("주문수량")]
		public long ordqty;
		/// <summary>
		/// 주문가격
		/// </summary>
		[XAQueryFieldAttribute("주문가격")]
		public long ordprc;
		/// <summary>
		/// 체결수량
		/// </summary>
		[XAQueryFieldAttribute("체결수량")]
		public long execqty;
		/// <summary>
		/// 체결가격
		/// </summary>
		[XAQueryFieldAttribute("체결가격")]
		public long execprc;
		/// <summary>
		/// 정정확인수량
		/// </summary>
		[XAQueryFieldAttribute("정정확인수량")]
		public long mdfycnfqty;
		/// <summary>
		/// 정정확인가격
		/// </summary>
		[XAQueryFieldAttribute("정정확인가격")]
		public long mdfycnfprc;
		/// <summary>
		/// 취소확인수량
		/// </summary>
		[XAQueryFieldAttribute("취소확인수량")]
		public long canccnfqty;
		/// <summary>
		/// 거부수량
		/// </summary>
		[XAQueryFieldAttribute("거부수량")]
		public long rjtqty;
		/// <summary>
		/// 주문처리유형코드
		/// </summary>
		[XAQueryFieldAttribute("주문처리유형코드")]
		public long ordtrxptncode;
		/// <summary>
		/// 복수주문일련번호
		/// </summary>
		[XAQueryFieldAttribute("복수주문일련번호")]
		public long mtiordseqno;
		/// <summary>
		/// 주문조건
		/// </summary>
		[XAQueryFieldAttribute("주문조건")]
		public char ordcndi;
		/// <summary>
		/// 호가유형코드
		/// </summary>
		[XAQueryFieldAttribute("호가유형코드")]
		public string ordprcptncode;
		/// <summary>
		/// 비저축체결수량
		/// </summary>
		[XAQueryFieldAttribute("비저축체결수량")]
		public long nsavtrdqty;
		/// <summary>
		/// 단축종목번호
		/// </summary>
		[XAQueryFieldAttribute("단축종목번호")]
		public string shtnIsuno;
		/// <summary>
		/// 운용지시번호
		/// </summary>
		[XAQueryFieldAttribute("운용지시번호")]
		public string opdrtnno;
		/// <summary>
		/// 반대매매주문구분
		/// </summary>
		[XAQueryFieldAttribute("반대매매주문구분")]
		public char cvrgordtp;
		/// <summary>
		/// 미체결수량(주문)
		/// </summary>
		[XAQueryFieldAttribute("미체결수량(주문)")]
		public long unercqty;
		/// <summary>
		/// 원주문미체결수량
		/// </summary>
		[XAQueryFieldAttribute("원주문미체결수량")]
		public long orgordunercqty;
		/// <summary>
		/// 원주문정정수량
		/// </summary>
		[XAQueryFieldAttribute("원주문정정수량")]
		public long orgordmdfyqty;
		/// <summary>
		/// 원주문취소수량
		/// </summary>
		[XAQueryFieldAttribute("원주문취소수량")]
		public long orgordcancqty;
		/// <summary>
		/// 주문평균체결가격
		/// </summary>
		[XAQueryFieldAttribute("주문평균체결가격")]
		public long ordavrexecprc;
		/// <summary>
		/// 주문금액
		/// </summary>
		[XAQueryFieldAttribute("주문금액")]
		public long ordamt;
		/// <summary>
		/// 표준종목번호
		/// </summary>
		[XAQueryFieldAttribute("표준종목번호")]
		public string stdIsuno;
		/// <summary>
		/// 전표준종목번호
		/// </summary>
		[XAQueryFieldAttribute("전표준종목번호")]
		public string bfstdIsuno;
		/// <summary>
		/// 매매구분
		/// </summary>
		[XAQueryFieldAttribute("매매구분")]
		public char bnstp;
		/// <summary>
		/// 주문거래유형코드
		/// </summary>
		[XAQueryFieldAttribute("주문거래유형코드")]
		public string ordtrdptncode;
		/// <summary>
		/// 신용거래코드
		/// </summary>
		[XAQueryFieldAttribute("신용거래코드")]
		public string mgntrncode;
		/// <summary>
		/// 수수료합산코드
		/// </summary>
		[XAQueryFieldAttribute("수수료합산코드")]
		public string adduptp;
		/// <summary>
		/// 통신매체코드
		/// </summary>
		[XAQueryFieldAttribute("통신매체코드")]
		public string commdacode;
		/// <summary>
		/// 대출일
		/// </summary>
		[XAQueryFieldAttribute("대출일")]
		public string Loandt;
		/// <summary>
		/// 회원/비회원사번호
		/// </summary>
		[XAQueryFieldAttribute("회원/비회원사번호")]
		public long mbrnmbrno;
		/// <summary>
		/// 주문계좌번호
		/// </summary>
		[XAQueryFieldAttribute("주문계좌번호")]
		public string ordacntno;
		/// <summary>
		/// 집계지점번호
		/// </summary>
		[XAQueryFieldAttribute("집계지점번호")]
		public string agrgbrnno;
		/// <summary>
		/// 관리사원번호
		/// </summary>
		[XAQueryFieldAttribute("관리사원번호")]
		public string mgempno;
		/// <summary>
		/// 선물연계지점번호
		/// </summary>
		[XAQueryFieldAttribute("선물연계지점번호")]
		public string futsLnkbrnno;
		/// <summary>
		/// 선물연계계좌번호
		/// </summary>
		[XAQueryFieldAttribute("선물연계계좌번호")]
		public string futsLnkacntno;
		/// <summary>
		/// 선물시장구분
		/// </summary>
		[XAQueryFieldAttribute("선물시장구분")]
		public char futsmkttp;
		/// <summary>
		/// 등록시장코드
		/// </summary>
		[XAQueryFieldAttribute("등록시장코드")]
		public string regmktcode;
		/// <summary>
		/// 현금증거금률
		/// </summary>
		[XAQueryFieldAttribute("현금증거금률")]
		public long mnymgnrat;
		/// <summary>
		/// 대용증거금률
		/// </summary>
		[XAQueryFieldAttribute("대용증거금률")]
		public long substmgnrat;
		/// <summary>
		/// 현금체결금액
		/// </summary>
		[XAQueryFieldAttribute("현금체결금액")]
		public long mnyexecamt;
		/// <summary>
		/// 대용체결금액
		/// </summary>
		[XAQueryFieldAttribute("대용체결금액")]
		public long ubstexecamt;
		/// <summary>
		/// 수수료체결금액
		/// </summary>
		[XAQueryFieldAttribute("수수료체결금액")]
		public long cmsnamtexecamt;
		/// <summary>
		/// 신용담보체결금액
		/// </summary>
		[XAQueryFieldAttribute("신용담보체결금액")]
		public long crdtpldgexecamt;
		/// <summary>
		/// 신용체결금액
		/// </summary>
		[XAQueryFieldAttribute("신용체결금액")]
		public long crdtexecamt;
		/// <summary>
		/// 전일재사용체결금액
		/// </summary>
		[XAQueryFieldAttribute("전일재사용체결금액")]
		public long prdayruseexecval;
		/// <summary>
		/// 금일재사용체결금액
		/// </summary>
		[XAQueryFieldAttribute("금일재사용체결금액")]
		public long crdayruseexecval;
		/// <summary>
		/// 실물체결수량
		/// </summary>
		[XAQueryFieldAttribute("실물체결수량")]
		public long spotexecqty;
		/// <summary>
		/// 공매도체결수량
		/// </summary>
		[XAQueryFieldAttribute("공매도체결수량")]
		public long stslexecqty;
		/// <summary>
		/// 전략코드
		/// </summary>
		[XAQueryFieldAttribute("전략코드")]
		public string strtgcode;
		/// <summary>
		/// 그룹Id
		/// </summary>
		[XAQueryFieldAttribute("그룹Id")]
		public string grpId;
		/// <summary>
		/// 주문회차
		/// </summary>
		[XAQueryFieldAttribute("주문회차")]
		public long ordseqno;
		/// <summary>
		/// 포트폴리오번호
		/// </summary>
		[XAQueryFieldAttribute("포트폴리오번호")]
		public long ptflno;
		/// <summary>
		/// 바스켓번호
		/// </summary>
		[XAQueryFieldAttribute("바스켓번호")]
		public long bskno;
		/// <summary>
		/// 트렌치번호
		/// </summary>
		[XAQueryFieldAttribute("트렌치번호")]
		public long trchno;
		/// <summary>
		/// 아이템번호
		/// </summary>
		[XAQueryFieldAttribute("아이템번호")]
		public long itemno;
		/// <summary>
		/// 주문자Id
		/// </summary>
		[XAQueryFieldAttribute("주문자Id")]
		public string orduserId;
		/// <summary>
		/// 차입관리여부
		/// </summary>
		[XAQueryFieldAttribute("차입관리여부")]
		public long brwmgmtYn;
		/// <summary>
		/// 외국인고유번호
		/// </summary>
		[XAQueryFieldAttribute("외국인고유번호")]
		public string frgrunqno;
		/// <summary>
		/// 거래세징수구분
		/// </summary>
		[XAQueryFieldAttribute("거래세징수구분")]
		public char trtzxLevytp;
		/// <summary>
		/// 유동성공급자구분
		/// </summary>
		[XAQueryFieldAttribute("유동성공급자구분")]
		public char lptp;
		/// <summary>
		/// 체결시각
		/// </summary>
		[XAQueryFieldAttribute("체결시각")]
		public string exectime;
		/// <summary>
		/// 거래소수신체결시각
		/// </summary>
		[XAQueryFieldAttribute("거래소수신체결시각")]
		public string rcptexectime;
		/// <summary>
		/// 잔여대출금액
		/// </summary>
		[XAQueryFieldAttribute("잔여대출금액")]
		public long rmndLoanamt;
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
		/// 잔고수량(d2)
		/// </summary>
		[XAQueryFieldAttribute("잔고수량(d2)")]
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
		public long pchsant;
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
			/// 주문체결유형코드
			/// </summary>
			public const string ordxctptncode = "ordxctptncode";
			/// <summary>
			/// 주문시장코드
			/// </summary>
			public const string ordmktcode = "ordmktcode";
			/// <summary>
			/// 주문유형코드
			/// </summary>
			public const string ordptncode = "ordptncode";
			/// <summary>
			/// 관리지점번호
			/// </summary>
			public const string mgmtbrnno = "mgmtbrnno";
			/// <summary>
			/// 계좌번호
			/// </summary>
			public const string accno1 = "accno1";
			/// <summary>
			/// 계좌번호
			/// </summary>
			public const string accno2 = "accno2";
			/// <summary>
			/// 계좌명
			/// </summary>
			public const string acntnm = "acntnm";
			/// <summary>
			/// 종목번호
			/// </summary>
			public const string Isuno = "Isuno";
			/// <summary>
			/// 종목명
			/// </summary>
			public const string Isunm = "Isunm";
			/// <summary>
			/// 주문번호
			/// </summary>
			public const string ordno = "ordno";
			/// <summary>
			/// 원주문번호
			/// </summary>
			public const string orgordno = "orgordno";
			/// <summary>
			/// 체결번호
			/// </summary>
			public const string execno = "execno";
			/// <summary>
			/// 주문수량
			/// </summary>
			public const string ordqty = "ordqty";
			/// <summary>
			/// 주문가격
			/// </summary>
			public const string ordprc = "ordprc";
			/// <summary>
			/// 체결수량
			/// </summary>
			public const string execqty = "execqty";
			/// <summary>
			/// 체결가격
			/// </summary>
			public const string execprc = "execprc";
			/// <summary>
			/// 정정확인수량
			/// </summary>
			public const string mdfycnfqty = "mdfycnfqty";
			/// <summary>
			/// 정정확인가격
			/// </summary>
			public const string mdfycnfprc = "mdfycnfprc";
			/// <summary>
			/// 취소확인수량
			/// </summary>
			public const string canccnfqty = "canccnfqty";
			/// <summary>
			/// 거부수량
			/// </summary>
			public const string rjtqty = "rjtqty";
			/// <summary>
			/// 주문처리유형코드
			/// </summary>
			public const string ordtrxptncode = "ordtrxptncode";
			/// <summary>
			/// 복수주문일련번호
			/// </summary>
			public const string mtiordseqno = "mtiordseqno";
			/// <summary>
			/// 주문조건
			/// </summary>
			public const string ordcndi = "ordcndi";
			/// <summary>
			/// 호가유형코드
			/// </summary>
			public const string ordprcptncode = "ordprcptncode";
			/// <summary>
			/// 비저축체결수량
			/// </summary>
			public const string nsavtrdqty = "nsavtrdqty";
			/// <summary>
			/// 단축종목번호
			/// </summary>
			public const string shtnIsuno = "shtnIsuno";
			/// <summary>
			/// 운용지시번호
			/// </summary>
			public const string opdrtnno = "opdrtnno";
			/// <summary>
			/// 반대매매주문구분
			/// </summary>
			public const string cvrgordtp = "cvrgordtp";
			/// <summary>
			/// 미체결수량(주문)
			/// </summary>
			public const string unercqty = "unercqty";
			/// <summary>
			/// 원주문미체결수량
			/// </summary>
			public const string orgordunercqty = "orgordunercqty";
			/// <summary>
			/// 원주문정정수량
			/// </summary>
			public const string orgordmdfyqty = "orgordmdfyqty";
			/// <summary>
			/// 원주문취소수량
			/// </summary>
			public const string orgordcancqty = "orgordcancqty";
			/// <summary>
			/// 주문평균체결가격
			/// </summary>
			public const string ordavrexecprc = "ordavrexecprc";
			/// <summary>
			/// 주문금액
			/// </summary>
			public const string ordamt = "ordamt";
			/// <summary>
			/// 표준종목번호
			/// </summary>
			public const string stdIsuno = "stdIsuno";
			/// <summary>
			/// 전표준종목번호
			/// </summary>
			public const string bfstdIsuno = "bfstdIsuno";
			/// <summary>
			/// 매매구분
			/// </summary>
			public const string bnstp = "bnstp";
			/// <summary>
			/// 주문거래유형코드
			/// </summary>
			public const string ordtrdptncode = "ordtrdptncode";
			/// <summary>
			/// 신용거래코드
			/// </summary>
			public const string mgntrncode = "mgntrncode";
			/// <summary>
			/// 수수료합산코드
			/// </summary>
			public const string adduptp = "adduptp";
			/// <summary>
			/// 통신매체코드
			/// </summary>
			public const string commdacode = "commdacode";
			/// <summary>
			/// 대출일
			/// </summary>
			public const string Loandt = "Loandt";
			/// <summary>
			/// 회원/비회원사번호
			/// </summary>
			public const string mbrnmbrno = "mbrnmbrno";
			/// <summary>
			/// 주문계좌번호
			/// </summary>
			public const string ordacntno = "ordacntno";
			/// <summary>
			/// 집계지점번호
			/// </summary>
			public const string agrgbrnno = "agrgbrnno";
			/// <summary>
			/// 관리사원번호
			/// </summary>
			public const string mgempno = "mgempno";
			/// <summary>
			/// 선물연계지점번호
			/// </summary>
			public const string futsLnkbrnno = "futsLnkbrnno";
			/// <summary>
			/// 선물연계계좌번호
			/// </summary>
			public const string futsLnkacntno = "futsLnkacntno";
			/// <summary>
			/// 선물시장구분
			/// </summary>
			public const string futsmkttp = "futsmkttp";
			/// <summary>
			/// 등록시장코드
			/// </summary>
			public const string regmktcode = "regmktcode";
			/// <summary>
			/// 현금증거금률
			/// </summary>
			public const string mnymgnrat = "mnymgnrat";
			/// <summary>
			/// 대용증거금률
			/// </summary>
			public const string substmgnrat = "substmgnrat";
			/// <summary>
			/// 현금체결금액
			/// </summary>
			public const string mnyexecamt = "mnyexecamt";
			/// <summary>
			/// 대용체결금액
			/// </summary>
			public const string ubstexecamt = "ubstexecamt";
			/// <summary>
			/// 수수료체결금액
			/// </summary>
			public const string cmsnamtexecamt = "cmsnamtexecamt";
			/// <summary>
			/// 신용담보체결금액
			/// </summary>
			public const string crdtpldgexecamt = "crdtpldgexecamt";
			/// <summary>
			/// 신용체결금액
			/// </summary>
			public const string crdtexecamt = "crdtexecamt";
			/// <summary>
			/// 전일재사용체결금액
			/// </summary>
			public const string prdayruseexecval = "prdayruseexecval";
			/// <summary>
			/// 금일재사용체결금액
			/// </summary>
			public const string crdayruseexecval = "crdayruseexecval";
			/// <summary>
			/// 실물체결수량
			/// </summary>
			public const string spotexecqty = "spotexecqty";
			/// <summary>
			/// 공매도체결수량
			/// </summary>
			public const string stslexecqty = "stslexecqty";
			/// <summary>
			/// 전략코드
			/// </summary>
			public const string strtgcode = "strtgcode";
			/// <summary>
			/// 그룹Id
			/// </summary>
			public const string grpId = "grpId";
			/// <summary>
			/// 주문회차
			/// </summary>
			public const string ordseqno = "ordseqno";
			/// <summary>
			/// 포트폴리오번호
			/// </summary>
			public const string ptflno = "ptflno";
			/// <summary>
			/// 바스켓번호
			/// </summary>
			public const string bskno = "bskno";
			/// <summary>
			/// 트렌치번호
			/// </summary>
			public const string trchno = "trchno";
			/// <summary>
			/// 아이템번호
			/// </summary>
			public const string itemno = "itemno";
			/// <summary>
			/// 주문자Id
			/// </summary>
			public const string orduserId = "orduserId";
			/// <summary>
			/// 차입관리여부
			/// </summary>
			public const string brwmgmtYn = "brwmgmtYn";
			/// <summary>
			/// 외국인고유번호
			/// </summary>
			public const string frgrunqno = "frgrunqno";
			/// <summary>
			/// 거래세징수구분
			/// </summary>
			public const string trtzxLevytp = "trtzxLevytp";
			/// <summary>
			/// 유동성공급자구분
			/// </summary>
			public const string lptp = "lptp";
			/// <summary>
			/// 체결시각
			/// </summary>
			public const string exectime = "exectime";
			/// <summary>
			/// 거래소수신체결시각
			/// </summary>
			public const string rcptexectime = "rcptexectime";
			/// <summary>
			/// 잔여대출금액
			/// </summary>
			public const string rmndLoanamt = "rmndLoanamt";
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
			/// 잔고수량(d2)
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
			public const string pchsant = "pchsant";
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
			F.ordxctptncode,
			F.ordmktcode,
			F.ordptncode,
			F.mgmtbrnno,
			F.accno1,
			F.accno2,
			F.acntnm,
			F.Isuno,
			F.Isunm,
			F.ordno,
			F.orgordno,
			F.execno,
			F.ordqty,
			F.ordprc,
			F.execqty,
			F.execprc,
			F.mdfycnfqty,
			F.mdfycnfprc,
			F.canccnfqty,
			F.rjtqty,
			F.ordtrxptncode,
			F.mtiordseqno,
			F.ordcndi,
			F.ordprcptncode,
			F.nsavtrdqty,
			F.shtnIsuno,
			F.opdrtnno,
			F.cvrgordtp,
			F.unercqty,
			F.orgordunercqty,
			F.orgordmdfyqty,
			F.orgordcancqty,
			F.ordavrexecprc,
			F.ordamt,
			F.stdIsuno,
			F.bfstdIsuno,
			F.bnstp,
			F.ordtrdptncode,
			F.mgntrncode,
			F.adduptp,
			F.commdacode,
			F.Loandt,
			F.mbrnmbrno,
			F.ordacntno,
			F.agrgbrnno,
			F.mgempno,
			F.futsLnkbrnno,
			F.futsLnkacntno,
			F.futsmkttp,
			F.regmktcode,
			F.mnymgnrat,
			F.substmgnrat,
			F.mnyexecamt,
			F.ubstexecamt,
			F.cmsnamtexecamt,
			F.crdtpldgexecamt,
			F.crdtexecamt,
			F.prdayruseexecval,
			F.crdayruseexecval,
			F.spotexecqty,
			F.stslexecqty,
			F.strtgcode,
			F.grpId,
			F.ordseqno,
			F.ptflno,
			F.bskno,
			F.trchno,
			F.itemno,
			F.orduserId,
			F.brwmgmtYn,
			F.frgrunqno,
			F.trtzxLevytp,
			F.lptp,
			F.exectime,
			F.rcptexectime,
			F.rmndLoanamt,
			F.secbalqty,
			F.spotordableqty,
			F.ordableruseqty,
			F.flctqty,
			F.secbalqtyd2,
			F.sellableqty,
			F.unercsellordqty,
			F.avrpchsprc,
			F.pchsant,
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
			dict["ordxctptncode"] = new XAQueryFieldInfo("char", ordxctptncode, ordxctptncode, "주문체결유형코드", (decimal)2);
			dict["ordmktcode"] = new XAQueryFieldInfo("char", ordmktcode, ordmktcode, "주문시장코드", (decimal)2);
			dict["ordptncode"] = new XAQueryFieldInfo("char", ordptncode, ordptncode, "주문유형코드", (decimal)2);
			dict["mgmtbrnno"] = new XAQueryFieldInfo("char", mgmtbrnno, mgmtbrnno, "관리지점번호", (decimal)3);
			dict["accno1"] = new XAQueryFieldInfo("char", accno1, accno1, "계좌번호", (decimal)11);
			dict["accno2"] = new XAQueryFieldInfo("char", accno2, accno2, "계좌번호", (decimal)9);
			dict["acntnm"] = new XAQueryFieldInfo("char", acntnm, acntnm, "계좌명", (decimal)40);
			dict["Isuno"] = new XAQueryFieldInfo("char", Isuno, Isuno, "종목번호", (decimal)12);
			dict["Isunm"] = new XAQueryFieldInfo("char", Isunm, Isunm, "종목명", (decimal)40);
			dict["ordno"] = new XAQueryFieldInfo("long", ordno, ordno.ToString("d10"), "주문번호", (decimal)10);
			dict["orgordno"] = new XAQueryFieldInfo("long", orgordno, orgordno.ToString("d10"), "원주문번호", (decimal)10);
			dict["execno"] = new XAQueryFieldInfo("long", execno, execno.ToString("d10"), "체결번호", (decimal)10);
			dict["ordqty"] = new XAQueryFieldInfo("long", ordqty, ordqty.ToString("d16"), "주문수량", (decimal)16);
			dict["ordprc"] = new XAQueryFieldInfo("long", ordprc, ordprc.ToString("d13"), "주문가격", (decimal)13);
			dict["execqty"] = new XAQueryFieldInfo("long", execqty, execqty.ToString("d16"), "체결수량", (decimal)16);
			dict["execprc"] = new XAQueryFieldInfo("long", execprc, execprc.ToString("d13"), "체결가격", (decimal)13);
			dict["mdfycnfqty"] = new XAQueryFieldInfo("long", mdfycnfqty, mdfycnfqty.ToString("d16"), "정정확인수량", (decimal)16);
			dict["mdfycnfprc"] = new XAQueryFieldInfo("long", mdfycnfprc, mdfycnfprc.ToString("d16"), "정정확인가격", (decimal)16);
			dict["canccnfqty"] = new XAQueryFieldInfo("long", canccnfqty, canccnfqty.ToString("d16"), "취소확인수량", (decimal)16);
			dict["rjtqty"] = new XAQueryFieldInfo("long", rjtqty, rjtqty.ToString("d16"), "거부수량", (decimal)16);
			dict["ordtrxptncode"] = new XAQueryFieldInfo("long", ordtrxptncode, ordtrxptncode.ToString("d4"), "주문처리유형코드", (decimal)4);
			dict["mtiordseqno"] = new XAQueryFieldInfo("long", mtiordseqno, mtiordseqno.ToString("d10"), "복수주문일련번호", (decimal)10);
			dict["ordcndi"] = new XAQueryFieldInfo("char", ordcndi, ordcndi.ToString(), "주문조건", (decimal)1);
			dict["ordprcptncode"] = new XAQueryFieldInfo("char", ordprcptncode, ordprcptncode, "호가유형코드", (decimal)2);
			dict["nsavtrdqty"] = new XAQueryFieldInfo("long", nsavtrdqty, nsavtrdqty.ToString("d16"), "비저축체결수량", (decimal)16);
			dict["shtnIsuno"] = new XAQueryFieldInfo("char", shtnIsuno, shtnIsuno, "단축종목번호", (decimal)9);
			dict["opdrtnno"] = new XAQueryFieldInfo("char", opdrtnno, opdrtnno, "운용지시번호", (decimal)12);
			dict["cvrgordtp"] = new XAQueryFieldInfo("char", cvrgordtp, cvrgordtp.ToString(), "반대매매주문구분", (decimal)1);
			dict["unercqty"] = new XAQueryFieldInfo("long", unercqty, unercqty.ToString("d16"), "미체결수량(주문)", (decimal)16);
			dict["orgordunercqty"] = new XAQueryFieldInfo("long", orgordunercqty, orgordunercqty.ToString("d16"), "원주문미체결수량", (decimal)16);
			dict["orgordmdfyqty"] = new XAQueryFieldInfo("long", orgordmdfyqty, orgordmdfyqty.ToString("d16"), "원주문정정수량", (decimal)16);
			dict["orgordcancqty"] = new XAQueryFieldInfo("long", orgordcancqty, orgordcancqty.ToString("d16"), "원주문취소수량", (decimal)16);
			dict["ordavrexecprc"] = new XAQueryFieldInfo("long", ordavrexecprc, ordavrexecprc.ToString("d13"), "주문평균체결가격", (decimal)13);
			dict["ordamt"] = new XAQueryFieldInfo("long", ordamt, ordamt.ToString("d16"), "주문금액", (decimal)16);
			dict["stdIsuno"] = new XAQueryFieldInfo("char", stdIsuno, stdIsuno, "표준종목번호", (decimal)12);
			dict["bfstdIsuno"] = new XAQueryFieldInfo("char", bfstdIsuno, bfstdIsuno, "전표준종목번호", (decimal)12);
			dict["bnstp"] = new XAQueryFieldInfo("char", bnstp, bnstp.ToString(), "매매구분", (decimal)1);
			dict["ordtrdptncode"] = new XAQueryFieldInfo("char", ordtrdptncode, ordtrdptncode, "주문거래유형코드", (decimal)2);
			dict["mgntrncode"] = new XAQueryFieldInfo("char", mgntrncode, mgntrncode, "신용거래코드", (decimal)3);
			dict["adduptp"] = new XAQueryFieldInfo("char", adduptp, adduptp, "수수료합산코드", (decimal)2);
			dict["commdacode"] = new XAQueryFieldInfo("char", commdacode, commdacode, "통신매체코드", (decimal)2);
			dict["Loandt"] = new XAQueryFieldInfo("char", Loandt, Loandt, "대출일", (decimal)8);
			dict["mbrnmbrno"] = new XAQueryFieldInfo("long", mbrnmbrno, mbrnmbrno.ToString("d3"), "회원/비회원사번호", (decimal)3);
			dict["ordacntno"] = new XAQueryFieldInfo("char", ordacntno, ordacntno, "주문계좌번호", (decimal)20);
			dict["agrgbrnno"] = new XAQueryFieldInfo("char", agrgbrnno, agrgbrnno, "집계지점번호", (decimal)3);
			dict["mgempno"] = new XAQueryFieldInfo("char", mgempno, mgempno, "관리사원번호", (decimal)9);
			dict["futsLnkbrnno"] = new XAQueryFieldInfo("char", futsLnkbrnno, futsLnkbrnno, "선물연계지점번호", (decimal)3);
			dict["futsLnkacntno"] = new XAQueryFieldInfo("char", futsLnkacntno, futsLnkacntno, "선물연계계좌번호", (decimal)20);
			dict["futsmkttp"] = new XAQueryFieldInfo("char", futsmkttp, futsmkttp.ToString(), "선물시장구분", (decimal)1);
			dict["regmktcode"] = new XAQueryFieldInfo("char", regmktcode, regmktcode, "등록시장코드", (decimal)2);
			dict["mnymgnrat"] = new XAQueryFieldInfo("long", mnymgnrat, mnymgnrat.ToString("d7"), "현금증거금률", (decimal)7);
			dict["substmgnrat"] = new XAQueryFieldInfo("long", substmgnrat, substmgnrat.ToString("d9"), "대용증거금률", (decimal)9);
			dict["mnyexecamt"] = new XAQueryFieldInfo("long", mnyexecamt, mnyexecamt.ToString("d16"), "현금체결금액", (decimal)16);
			dict["ubstexecamt"] = new XAQueryFieldInfo("long", ubstexecamt, ubstexecamt.ToString("d16"), "대용체결금액", (decimal)16);
			dict["cmsnamtexecamt"] = new XAQueryFieldInfo("long", cmsnamtexecamt, cmsnamtexecamt.ToString("d16"), "수수료체결금액", (decimal)16);
			dict["crdtpldgexecamt"] = new XAQueryFieldInfo("long", crdtpldgexecamt, crdtpldgexecamt.ToString("d16"), "신용담보체결금액", (decimal)16);
			dict["crdtexecamt"] = new XAQueryFieldInfo("long", crdtexecamt, crdtexecamt.ToString("d16"), "신용체결금액", (decimal)16);
			dict["prdayruseexecval"] = new XAQueryFieldInfo("long", prdayruseexecval, prdayruseexecval.ToString("d16"), "전일재사용체결금액", (decimal)16);
			dict["crdayruseexecval"] = new XAQueryFieldInfo("long", crdayruseexecval, crdayruseexecval.ToString("d16"), "금일재사용체결금액", (decimal)16);
			dict["spotexecqty"] = new XAQueryFieldInfo("long", spotexecqty, spotexecqty.ToString("d16"), "실물체결수량", (decimal)16);
			dict["stslexecqty"] = new XAQueryFieldInfo("long", stslexecqty, stslexecqty.ToString("d16"), "공매도체결수량", (decimal)16);
			dict["strtgcode"] = new XAQueryFieldInfo("char", strtgcode, strtgcode, "전략코드", (decimal)6);
			dict["grpId"] = new XAQueryFieldInfo("char", grpId, grpId, "그룹Id", (decimal)20);
			dict["ordseqno"] = new XAQueryFieldInfo("long", ordseqno, ordseqno.ToString("d10"), "주문회차", (decimal)10);
			dict["ptflno"] = new XAQueryFieldInfo("long", ptflno, ptflno.ToString("d10"), "포트폴리오번호", (decimal)10);
			dict["bskno"] = new XAQueryFieldInfo("long", bskno, bskno.ToString("d10"), "바스켓번호", (decimal)10);
			dict["trchno"] = new XAQueryFieldInfo("long", trchno, trchno.ToString("d10"), "트렌치번호", (decimal)10);
			dict["itemno"] = new XAQueryFieldInfo("long", itemno, itemno.ToString("d10"), "아이템번호", (decimal)10);
			dict["orduserId"] = new XAQueryFieldInfo("char", orduserId, orduserId, "주문자Id", (decimal)16);
			dict["brwmgmtYn"] = new XAQueryFieldInfo("long", brwmgmtYn, brwmgmtYn.ToString("d1"), "차입관리여부", (decimal)1);
			dict["frgrunqno"] = new XAQueryFieldInfo("char", frgrunqno, frgrunqno, "외국인고유번호", (decimal)6);
			dict["trtzxLevytp"] = new XAQueryFieldInfo("char", trtzxLevytp, trtzxLevytp.ToString(), "거래세징수구분", (decimal)1);
			dict["lptp"] = new XAQueryFieldInfo("char", lptp, lptp.ToString(), "유동성공급자구분", (decimal)1);
			dict["exectime"] = new XAQueryFieldInfo("char", exectime, exectime, "체결시각", (decimal)9);
			dict["rcptexectime"] = new XAQueryFieldInfo("char", rcptexectime, rcptexectime, "거래소수신체결시각", (decimal)9);
			dict["rmndLoanamt"] = new XAQueryFieldInfo("long", rmndLoanamt, rmndLoanamt.ToString("d16"), "잔여대출금액", (decimal)16);
			dict["secbalqty"] = new XAQueryFieldInfo("long", secbalqty, secbalqty.ToString("d16"), "잔고수량", (decimal)16);
			dict["spotordableqty"] = new XAQueryFieldInfo("long", spotordableqty, spotordableqty.ToString("d16"), "실물가능수량", (decimal)16);
			dict["ordableruseqty"] = new XAQueryFieldInfo("long", ordableruseqty, ordableruseqty.ToString("d16"), "재사용가능수량(매도)", (decimal)16);
			dict["flctqty"] = new XAQueryFieldInfo("long", flctqty, flctqty.ToString("d16"), "변동수량", (decimal)16);
			dict["secbalqtyd2"] = new XAQueryFieldInfo("long", secbalqtyd2, secbalqtyd2.ToString("d16"), "잔고수량(d2)", (decimal)16);
			dict["sellableqty"] = new XAQueryFieldInfo("long", sellableqty, sellableqty.ToString("d16"), "매도주문가능수량", (decimal)16);
			dict["unercsellordqty"] = new XAQueryFieldInfo("long", unercsellordqty, unercsellordqty.ToString("d16"), "미체결매도주문수량", (decimal)16);
			dict["avrpchsprc"] = new XAQueryFieldInfo("long", avrpchsprc, avrpchsprc.ToString("d13"), "평균매입가", (decimal)13);
			dict["pchsant"] = new XAQueryFieldInfo("long", pchsant, pchsant.ToString("d16"), "매입금액", (decimal)16);
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

				case "ordxctptncode":
					this.ordxctptncode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ordmktcode":
					this.ordmktcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ordptncode":
					this.ordptncode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "mgmtbrnno":
					this.mgmtbrnno = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "accno1":
					this.accno1 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "accno2":
					this.accno2 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "acntnm":
					this.acntnm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "Isuno":
					this.Isuno = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "Isunm":
					this.Isunm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ordno":
					this.ordno = fieldInfo.FieldValue.ParseLong("ordno");
				break;

				case "orgordno":
					this.orgordno = fieldInfo.FieldValue.ParseLong("orgordno");
				break;

				case "execno":
					this.execno = fieldInfo.FieldValue.ParseLong("execno");
				break;

				case "ordqty":
					this.ordqty = fieldInfo.FieldValue.ParseLong("ordqty");
				break;

				case "ordprc":
					this.ordprc = fieldInfo.FieldValue.ParseLong("ordprc");
				break;

				case "execqty":
					this.execqty = fieldInfo.FieldValue.ParseLong("execqty");
				break;

				case "execprc":
					this.execprc = fieldInfo.FieldValue.ParseLong("execprc");
				break;

				case "mdfycnfqty":
					this.mdfycnfqty = fieldInfo.FieldValue.ParseLong("mdfycnfqty");
				break;

				case "mdfycnfprc":
					this.mdfycnfprc = fieldInfo.FieldValue.ParseLong("mdfycnfprc");
				break;

				case "canccnfqty":
					this.canccnfqty = fieldInfo.FieldValue.ParseLong("canccnfqty");
				break;

				case "rjtqty":
					this.rjtqty = fieldInfo.FieldValue.ParseLong("rjtqty");
				break;

				case "ordtrxptncode":
					this.ordtrxptncode = fieldInfo.FieldValue.ParseLong("ordtrxptncode");
				break;

				case "mtiordseqno":
					this.mtiordseqno = fieldInfo.FieldValue.ParseLong("mtiordseqno");
				break;

				case "ordcndi":
					this.ordcndi = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "ordprcptncode":
					this.ordprcptncode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "nsavtrdqty":
					this.nsavtrdqty = fieldInfo.FieldValue.ParseLong("nsavtrdqty");
				break;

				case "shtnIsuno":
					this.shtnIsuno = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "opdrtnno":
					this.opdrtnno = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cvrgordtp":
					this.cvrgordtp = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "unercqty":
					this.unercqty = fieldInfo.FieldValue.ParseLong("unercqty");
				break;

				case "orgordunercqty":
					this.orgordunercqty = fieldInfo.FieldValue.ParseLong("orgordunercqty");
				break;

				case "orgordmdfyqty":
					this.orgordmdfyqty = fieldInfo.FieldValue.ParseLong("orgordmdfyqty");
				break;

				case "orgordcancqty":
					this.orgordcancqty = fieldInfo.FieldValue.ParseLong("orgordcancqty");
				break;

				case "ordavrexecprc":
					this.ordavrexecprc = fieldInfo.FieldValue.ParseLong("ordavrexecprc");
				break;

				case "ordamt":
					this.ordamt = fieldInfo.FieldValue.ParseLong("ordamt");
				break;

				case "stdIsuno":
					this.stdIsuno = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "bfstdIsuno":
					this.bfstdIsuno = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "bnstp":
					this.bnstp = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "ordtrdptncode":
					this.ordtrdptncode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "mgntrncode":
					this.mgntrncode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "adduptp":
					this.adduptp = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "commdacode":
					this.commdacode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "Loandt":
					this.Loandt = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "mbrnmbrno":
					this.mbrnmbrno = fieldInfo.FieldValue.ParseLong("mbrnmbrno");
				break;

				case "ordacntno":
					this.ordacntno = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "agrgbrnno":
					this.agrgbrnno = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "mgempno":
					this.mgempno = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "futsLnkbrnno":
					this.futsLnkbrnno = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "futsLnkacntno":
					this.futsLnkacntno = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "futsmkttp":
					this.futsmkttp = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "regmktcode":
					this.regmktcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "mnymgnrat":
					this.mnymgnrat = fieldInfo.FieldValue.ParseLong("mnymgnrat");
				break;

				case "substmgnrat":
					this.substmgnrat = fieldInfo.FieldValue.ParseLong("substmgnrat");
				break;

				case "mnyexecamt":
					this.mnyexecamt = fieldInfo.FieldValue.ParseLong("mnyexecamt");
				break;

				case "ubstexecamt":
					this.ubstexecamt = fieldInfo.FieldValue.ParseLong("ubstexecamt");
				break;

				case "cmsnamtexecamt":
					this.cmsnamtexecamt = fieldInfo.FieldValue.ParseLong("cmsnamtexecamt");
				break;

				case "crdtpldgexecamt":
					this.crdtpldgexecamt = fieldInfo.FieldValue.ParseLong("crdtpldgexecamt");
				break;

				case "crdtexecamt":
					this.crdtexecamt = fieldInfo.FieldValue.ParseLong("crdtexecamt");
				break;

				case "prdayruseexecval":
					this.prdayruseexecval = fieldInfo.FieldValue.ParseLong("prdayruseexecval");
				break;

				case "crdayruseexecval":
					this.crdayruseexecval = fieldInfo.FieldValue.ParseLong("crdayruseexecval");
				break;

				case "spotexecqty":
					this.spotexecqty = fieldInfo.FieldValue.ParseLong("spotexecqty");
				break;

				case "stslexecqty":
					this.stslexecqty = fieldInfo.FieldValue.ParseLong("stslexecqty");
				break;

				case "strtgcode":
					this.strtgcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "grpId":
					this.grpId = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ordseqno":
					this.ordseqno = fieldInfo.FieldValue.ParseLong("ordseqno");
				break;

				case "ptflno":
					this.ptflno = fieldInfo.FieldValue.ParseLong("ptflno");
				break;

				case "bskno":
					this.bskno = fieldInfo.FieldValue.ParseLong("bskno");
				break;

				case "trchno":
					this.trchno = fieldInfo.FieldValue.ParseLong("trchno");
				break;

				case "itemno":
					this.itemno = fieldInfo.FieldValue.ParseLong("itemno");
				break;

				case "orduserId":
					this.orduserId = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "brwmgmtYn":
					this.brwmgmtYn = fieldInfo.FieldValue.ParseLong("brwmgmtYn");
				break;

				case "frgrunqno":
					this.frgrunqno = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "trtzxLevytp":
					this.trtzxLevytp = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "lptp":
					this.lptp = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "exectime":
					this.exectime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "rcptexectime":
					this.rcptexectime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "rmndLoanamt":
					this.rmndLoanamt = fieldInfo.FieldValue.ParseLong("rmndLoanamt");
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

				case "pchsant":
					this.pchsant = fieldInfo.FieldValue.ParseLong("pchsant");
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

		public static XRSC4OutBlock FromQuery(XRSC4 query)
		{
			XRSC4OutBlock block = new XRSC4OutBlock();
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
				block.ordxctptncode = query.GetFieldData(block.GetBlockName(), "ordxctptncode").TrimEnd('?'); // char 2
				block.ordmktcode = query.GetFieldData(block.GetBlockName(), "ordmktcode").TrimEnd('?'); // char 2
				block.ordptncode = query.GetFieldData(block.GetBlockName(), "ordptncode").TrimEnd('?'); // char 2
				block.mgmtbrnno = query.GetFieldData(block.GetBlockName(), "mgmtbrnno").TrimEnd('?'); // char 3
				block.accno1 = query.GetFieldData(block.GetBlockName(), "accno1").TrimEnd('?'); // char 11
				block.accno2 = query.GetFieldData(block.GetBlockName(), "accno2").TrimEnd('?'); // char 9
				block.acntnm = query.GetFieldData(block.GetBlockName(), "acntnm").TrimEnd('?'); // char 40
				block.Isuno = query.GetFieldData(block.GetBlockName(), "Isuno").TrimEnd('?'); // char 12
				block.Isunm = query.GetFieldData(block.GetBlockName(), "Isunm").TrimEnd('?'); // char 40
				block.ordno = query.GetFieldData(block.GetBlockName(), "ordno").ParseLong("ordno"); // long 10
				block.orgordno = query.GetFieldData(block.GetBlockName(), "orgordno").ParseLong("orgordno"); // long 10
				block.execno = query.GetFieldData(block.GetBlockName(), "execno").ParseLong("execno"); // long 10
				block.ordqty = query.GetFieldData(block.GetBlockName(), "ordqty").ParseLong("ordqty"); // long 16
				block.ordprc = query.GetFieldData(block.GetBlockName(), "ordprc").ParseLong("ordprc"); // long 13
				block.execqty = query.GetFieldData(block.GetBlockName(), "execqty").ParseLong("execqty"); // long 16
				block.execprc = query.GetFieldData(block.GetBlockName(), "execprc").ParseLong("execprc"); // long 13
				block.mdfycnfqty = query.GetFieldData(block.GetBlockName(), "mdfycnfqty").ParseLong("mdfycnfqty"); // long 16
				block.mdfycnfprc = query.GetFieldData(block.GetBlockName(), "mdfycnfprc").ParseLong("mdfycnfprc"); // long 16
				block.canccnfqty = query.GetFieldData(block.GetBlockName(), "canccnfqty").ParseLong("canccnfqty"); // long 16
				block.rjtqty = query.GetFieldData(block.GetBlockName(), "rjtqty").ParseLong("rjtqty"); // long 16
				block.ordtrxptncode = query.GetFieldData(block.GetBlockName(), "ordtrxptncode").ParseLong("ordtrxptncode"); // long 4
				block.mtiordseqno = query.GetFieldData(block.GetBlockName(), "mtiordseqno").ParseLong("mtiordseqno"); // long 10
				block.ordcndi = query.GetFieldData(block.GetBlockName(), "ordcndi").FirstOrDefault(); // char 1
				block.ordprcptncode = query.GetFieldData(block.GetBlockName(), "ordprcptncode").TrimEnd('?'); // char 2
				block.nsavtrdqty = query.GetFieldData(block.GetBlockName(), "nsavtrdqty").ParseLong("nsavtrdqty"); // long 16
				block.shtnIsuno = query.GetFieldData(block.GetBlockName(), "shtnIsuno").TrimEnd('?'); // char 9
				block.opdrtnno = query.GetFieldData(block.GetBlockName(), "opdrtnno").TrimEnd('?'); // char 12
				block.cvrgordtp = query.GetFieldData(block.GetBlockName(), "cvrgordtp").FirstOrDefault(); // char 1
				block.unercqty = query.GetFieldData(block.GetBlockName(), "unercqty").ParseLong("unercqty"); // long 16
				block.orgordunercqty = query.GetFieldData(block.GetBlockName(), "orgordunercqty").ParseLong("orgordunercqty"); // long 16
				block.orgordmdfyqty = query.GetFieldData(block.GetBlockName(), "orgordmdfyqty").ParseLong("orgordmdfyqty"); // long 16
				block.orgordcancqty = query.GetFieldData(block.GetBlockName(), "orgordcancqty").ParseLong("orgordcancqty"); // long 16
				block.ordavrexecprc = query.GetFieldData(block.GetBlockName(), "ordavrexecprc").ParseLong("ordavrexecprc"); // long 13
				block.ordamt = query.GetFieldData(block.GetBlockName(), "ordamt").ParseLong("ordamt"); // long 16
				block.stdIsuno = query.GetFieldData(block.GetBlockName(), "stdIsuno").TrimEnd('?'); // char 12
				block.bfstdIsuno = query.GetFieldData(block.GetBlockName(), "bfstdIsuno").TrimEnd('?'); // char 12
				block.bnstp = query.GetFieldData(block.GetBlockName(), "bnstp").FirstOrDefault(); // char 1
				block.ordtrdptncode = query.GetFieldData(block.GetBlockName(), "ordtrdptncode").TrimEnd('?'); // char 2
				block.mgntrncode = query.GetFieldData(block.GetBlockName(), "mgntrncode").TrimEnd('?'); // char 3
				block.adduptp = query.GetFieldData(block.GetBlockName(), "adduptp").TrimEnd('?'); // char 2
				block.commdacode = query.GetFieldData(block.GetBlockName(), "commdacode").TrimEnd('?'); // char 2
				block.Loandt = query.GetFieldData(block.GetBlockName(), "Loandt").TrimEnd('?'); // char 8
				block.mbrnmbrno = query.GetFieldData(block.GetBlockName(), "mbrnmbrno").ParseLong("mbrnmbrno"); // long 3
				block.ordacntno = query.GetFieldData(block.GetBlockName(), "ordacntno").TrimEnd('?'); // char 20
				block.agrgbrnno = query.GetFieldData(block.GetBlockName(), "agrgbrnno").TrimEnd('?'); // char 3
				block.mgempno = query.GetFieldData(block.GetBlockName(), "mgempno").TrimEnd('?'); // char 9
				block.futsLnkbrnno = query.GetFieldData(block.GetBlockName(), "futsLnkbrnno").TrimEnd('?'); // char 3
				block.futsLnkacntno = query.GetFieldData(block.GetBlockName(), "futsLnkacntno").TrimEnd('?'); // char 20
				block.futsmkttp = query.GetFieldData(block.GetBlockName(), "futsmkttp").FirstOrDefault(); // char 1
				block.regmktcode = query.GetFieldData(block.GetBlockName(), "regmktcode").TrimEnd('?'); // char 2
				block.mnymgnrat = query.GetFieldData(block.GetBlockName(), "mnymgnrat").ParseLong("mnymgnrat"); // long 7
				block.substmgnrat = query.GetFieldData(block.GetBlockName(), "substmgnrat").ParseLong("substmgnrat"); // long 9
				block.mnyexecamt = query.GetFieldData(block.GetBlockName(), "mnyexecamt").ParseLong("mnyexecamt"); // long 16
				block.ubstexecamt = query.GetFieldData(block.GetBlockName(), "ubstexecamt").ParseLong("ubstexecamt"); // long 16
				block.cmsnamtexecamt = query.GetFieldData(block.GetBlockName(), "cmsnamtexecamt").ParseLong("cmsnamtexecamt"); // long 16
				block.crdtpldgexecamt = query.GetFieldData(block.GetBlockName(), "crdtpldgexecamt").ParseLong("crdtpldgexecamt"); // long 16
				block.crdtexecamt = query.GetFieldData(block.GetBlockName(), "crdtexecamt").ParseLong("crdtexecamt"); // long 16
				block.prdayruseexecval = query.GetFieldData(block.GetBlockName(), "prdayruseexecval").ParseLong("prdayruseexecval"); // long 16
				block.crdayruseexecval = query.GetFieldData(block.GetBlockName(), "crdayruseexecval").ParseLong("crdayruseexecval"); // long 16
				block.spotexecqty = query.GetFieldData(block.GetBlockName(), "spotexecqty").ParseLong("spotexecqty"); // long 16
				block.stslexecqty = query.GetFieldData(block.GetBlockName(), "stslexecqty").ParseLong("stslexecqty"); // long 16
				block.strtgcode = query.GetFieldData(block.GetBlockName(), "strtgcode").TrimEnd('?'); // char 6
				block.grpId = query.GetFieldData(block.GetBlockName(), "grpId").TrimEnd('?'); // char 20
				block.ordseqno = query.GetFieldData(block.GetBlockName(), "ordseqno").ParseLong("ordseqno"); // long 10
				block.ptflno = query.GetFieldData(block.GetBlockName(), "ptflno").ParseLong("ptflno"); // long 10
				block.bskno = query.GetFieldData(block.GetBlockName(), "bskno").ParseLong("bskno"); // long 10
				block.trchno = query.GetFieldData(block.GetBlockName(), "trchno").ParseLong("trchno"); // long 10
				block.itemno = query.GetFieldData(block.GetBlockName(), "itemno").ParseLong("itemno"); // long 10
				block.orduserId = query.GetFieldData(block.GetBlockName(), "orduserId").TrimEnd('?'); // char 16
				block.brwmgmtYn = query.GetFieldData(block.GetBlockName(), "brwmgmtYn").ParseLong("brwmgmtYn"); // long 1
				block.frgrunqno = query.GetFieldData(block.GetBlockName(), "frgrunqno").TrimEnd('?'); // char 6
				block.trtzxLevytp = query.GetFieldData(block.GetBlockName(), "trtzxLevytp").FirstOrDefault(); // char 1
				block.lptp = query.GetFieldData(block.GetBlockName(), "lptp").FirstOrDefault(); // char 1
				block.exectime = query.GetFieldData(block.GetBlockName(), "exectime").TrimEnd('?'); // char 9
				block.rcptexectime = query.GetFieldData(block.GetBlockName(), "rcptexectime").TrimEnd('?'); // char 9
				block.rmndLoanamt = query.GetFieldData(block.GetBlockName(), "rmndLoanamt").ParseLong("rmndLoanamt"); // long 16
				block.secbalqty = query.GetFieldData(block.GetBlockName(), "secbalqty").ParseLong("secbalqty"); // long 16
				block.spotordableqty = query.GetFieldData(block.GetBlockName(), "spotordableqty").ParseLong("spotordableqty"); // long 16
				block.ordableruseqty = query.GetFieldData(block.GetBlockName(), "ordableruseqty").ParseLong("ordableruseqty"); // long 16
				block.flctqty = query.GetFieldData(block.GetBlockName(), "flctqty").ParseLong("flctqty"); // long 16
				block.secbalqtyd2 = query.GetFieldData(block.GetBlockName(), "secbalqtyd2").ParseLong("secbalqtyd2"); // long 16
				block.sellableqty = query.GetFieldData(block.GetBlockName(), "sellableqty").ParseLong("sellableqty"); // long 16
				block.unercsellordqty = query.GetFieldData(block.GetBlockName(), "unercsellordqty").ParseLong("unercsellordqty"); // long 16
				block.avrpchsprc = query.GetFieldData(block.GetBlockName(), "avrpchsprc").ParseLong("avrpchsprc"); // long 13
				block.pchsant = query.GetFieldData(block.GetBlockName(), "pchsant").ParseLong("pchsant"); // long 16
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
			if (ordxctptncode.Length > 2) return false; // char 2
			if (ordmktcode.Length > 2) return false; // char 2
			if (ordptncode.Length > 2) return false; // char 2
			if (mgmtbrnno.Length > 3) return false; // char 3
			if (accno1.Length > 11) return false; // char 11
			if (accno2.Length > 9) return false; // char 9
			if (acntnm.Length > 40) return false; // char 40
			if (Isuno.Length > 12) return false; // char 12
			if (Isunm.Length > 40) return false; // char 40
			if (ordno.ToString().Length > 10) return false; // long 10
			if (orgordno.ToString().Length > 10) return false; // long 10
			if (execno.ToString().Length > 10) return false; // long 10
			if (ordqty.ToString().Length > 16) return false; // long 16
			if (ordprc.ToString().Length > 13) return false; // long 13
			if (execqty.ToString().Length > 16) return false; // long 16
			if (execprc.ToString().Length > 13) return false; // long 13
			if (mdfycnfqty.ToString().Length > 16) return false; // long 16
			if (mdfycnfprc.ToString().Length > 16) return false; // long 16
			if (canccnfqty.ToString().Length > 16) return false; // long 16
			if (rjtqty.ToString().Length > 16) return false; // long 16
			if (ordtrxptncode.ToString().Length > 4) return false; // long 4
			if (mtiordseqno.ToString().Length > 10) return false; // long 10
			// ordcndi char 1
			if (ordprcptncode.Length > 2) return false; // char 2
			if (nsavtrdqty.ToString().Length > 16) return false; // long 16
			if (shtnIsuno.Length > 9) return false; // char 9
			if (opdrtnno.Length > 12) return false; // char 12
			// cvrgordtp char 1
			if (unercqty.ToString().Length > 16) return false; // long 16
			if (orgordunercqty.ToString().Length > 16) return false; // long 16
			if (orgordmdfyqty.ToString().Length > 16) return false; // long 16
			if (orgordcancqty.ToString().Length > 16) return false; // long 16
			if (ordavrexecprc.ToString().Length > 13) return false; // long 13
			if (ordamt.ToString().Length > 16) return false; // long 16
			if (stdIsuno.Length > 12) return false; // char 12
			if (bfstdIsuno.Length > 12) return false; // char 12
			// bnstp char 1
			if (ordtrdptncode.Length > 2) return false; // char 2
			if (mgntrncode.Length > 3) return false; // char 3
			if (adduptp.Length > 2) return false; // char 2
			if (commdacode.Length > 2) return false; // char 2
			if (Loandt.Length > 8) return false; // char 8
			if (mbrnmbrno.ToString().Length > 3) return false; // long 3
			if (ordacntno.Length > 20) return false; // char 20
			if (agrgbrnno.Length > 3) return false; // char 3
			if (mgempno.Length > 9) return false; // char 9
			if (futsLnkbrnno.Length > 3) return false; // char 3
			if (futsLnkacntno.Length > 20) return false; // char 20
			// futsmkttp char 1
			if (regmktcode.Length > 2) return false; // char 2
			if (mnymgnrat.ToString().Length > 7) return false; // long 7
			if (substmgnrat.ToString().Length > 9) return false; // long 9
			if (mnyexecamt.ToString().Length > 16) return false; // long 16
			if (ubstexecamt.ToString().Length > 16) return false; // long 16
			if (cmsnamtexecamt.ToString().Length > 16) return false; // long 16
			if (crdtpldgexecamt.ToString().Length > 16) return false; // long 16
			if (crdtexecamt.ToString().Length > 16) return false; // long 16
			if (prdayruseexecval.ToString().Length > 16) return false; // long 16
			if (crdayruseexecval.ToString().Length > 16) return false; // long 16
			if (spotexecqty.ToString().Length > 16) return false; // long 16
			if (stslexecqty.ToString().Length > 16) return false; // long 16
			if (strtgcode.Length > 6) return false; // char 6
			if (grpId.Length > 20) return false; // char 20
			if (ordseqno.ToString().Length > 10) return false; // long 10
			if (ptflno.ToString().Length > 10) return false; // long 10
			if (bskno.ToString().Length > 10) return false; // long 10
			if (trchno.ToString().Length > 10) return false; // long 10
			if (itemno.ToString().Length > 10) return false; // long 10
			if (orduserId.Length > 16) return false; // char 16
			if (brwmgmtYn.ToString().Length > 1) return false; // long 1
			if (frgrunqno.Length > 6) return false; // char 6
			// trtzxLevytp char 1
			// lptp char 1
			if (exectime.Length > 9) return false; // char 9
			if (rcptexectime.Length > 9) return false; // char 9
			if (rmndLoanamt.ToString().Length > 16) return false; // long 16
			if (secbalqty.ToString().Length > 16) return false; // long 16
			if (spotordableqty.ToString().Length > 16) return false; // long 16
			if (ordableruseqty.ToString().Length > 16) return false; // long 16
			if (flctqty.ToString().Length > 16) return false; // long 16
			if (secbalqtyd2.ToString().Length > 16) return false; // long 16
			if (sellableqty.ToString().Length > 16) return false; // long 16
			if (unercsellordqty.ToString().Length > 16) return false; // long 16
			if (avrpchsprc.ToString().Length > 13) return false; // long 13
			if (pchsant.ToString().Length > 16) return false; // long 16
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

	public partial class XRSC4 : XingReal
	{
		/// <summary>
		/// SC4
		/// </summary>
		static readonly string _typeName = "SC4";
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
		/// SC4
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

		public XRSC4() : base("SC4") { }


		public bool SetFields(XRSC4InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}


			return true;
		}

		public XRSC4OutBlock GetBlock()
		{
			XRSC4OutBlock instance = XRSC4OutBlock.FromQuery(this);
			return instance;

		}


	}

}
