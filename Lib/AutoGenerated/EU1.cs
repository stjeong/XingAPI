using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XREU1InBlock : XingBlock
	{
		/// <summary>
		/// InBlock
		/// </summary>
		public const string _blockName = "InBlock";
		/// <summary>
		/// 입력
		/// </summary>
		public const string _blockDesc = "입력";
		/// <summary>
		/// input
		/// </summary>
		public const string _blockType = "input";
		/// <summary>
		/// false
		/// </summary>
		public const bool _hasOccurs = false;
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

	public partial class XREU1OutBlock : XingBlock
	{
		/// <summary>
		/// OutBlock
		/// </summary>
		public const string _blockName = "OutBlock";
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
		/// tr코드
		/// </summary>
		[XAQueryFieldAttribute("tr코드")]
		public string trcode1;
		/// <summary>
		/// 회사번호
		/// </summary>
		[XAQueryFieldAttribute("회사번호")]
		public string firmno;
		/// <summary>
		/// 계좌번호
		/// </summary>
		[XAQueryFieldAttribute("계좌번호")]
		public string acntno;
		/// <summary>
		/// 계좌번호
		/// </summary>
		[XAQueryFieldAttribute("계좌번호")]
		public string acntno1;
		/// <summary>
		/// 계좌명
		/// </summary>
		[XAQueryFieldAttribute("계좌명")]
		public string acntnm;
		/// <summary>
		/// 지점번호
		/// </summary>
		[XAQueryFieldAttribute("지점번호")]
		public string brnno;
		/// <summary>
		/// 주문시장코드
		/// </summary>
		[XAQueryFieldAttribute("주문시장코드")]
		public string ordmktcode;
		/// <summary>
		/// 주문번호
		/// </summary>
		[XAQueryFieldAttribute("주문번호")]
		public string ordno1;
		/// <summary>
		/// 주문번호
		/// </summary>
		[XAQueryFieldAttribute("주문번호")]
		public long ordno;
		/// <summary>
		/// 원주문번호
		/// </summary>
		[XAQueryFieldAttribute("원주문번호")]
		public string orgordno1;
		/// <summary>
		/// 원주문번호
		/// </summary>
		[XAQueryFieldAttribute("원주문번호")]
		public long orgordno;
		/// <summary>
		/// 모주문번호
		/// </summary>
		[XAQueryFieldAttribute("모주문번호")]
		public string prntordno;
		/// <summary>
		/// 모주문번호
		/// </summary>
		[XAQueryFieldAttribute("모주문번호")]
		public long prntordno1;
		/// <summary>
		/// 종목번호
		/// </summary>
		[XAQueryFieldAttribute("종목번호")]
		public string isuno;
		/// <summary>
		/// 선물옵션종목번호
		/// </summary>
		[XAQueryFieldAttribute("선물옵션종목번호")]
		public string fnoIsuno;
		/// <summary>
		/// 선물옵션종목명
		/// </summary>
		[XAQueryFieldAttribute("선물옵션종목명")]
		public string fnoIsunm;
		/// <summary>
		/// 상품군분류코드
		/// </summary>
		[XAQueryFieldAttribute("상품군분류코드")]
		public string pdgrpcode;
		/// <summary>
		/// 선물옵션종목유형구분
		/// </summary>
		[XAQueryFieldAttribute("선물옵션종목유형구분")]
		public char fnoIsuptntp;
		/// <summary>
		/// 매매구분
		/// </summary>
		[XAQueryFieldAttribute("매매구분")]
		public char bnstp;
		/// <summary>
		/// 정정취소구분
		/// </summary>
		[XAQueryFieldAttribute("정정취소구분")]
		public char mrctp;
		/// <summary>
		/// 주문수량
		/// </summary>
		[XAQueryFieldAttribute("주문수량")]
		public long ordqty;
		/// <summary>
		/// 호가유형코드
		/// </summary>
		[XAQueryFieldAttribute("호가유형코드")]
		public string hogatype;
		/// <summary>
		/// 거래유형코드
		/// </summary>
		[XAQueryFieldAttribute("거래유형코드")]
		public string mmgb;
		/// <summary>
		/// 주문가격
		/// </summary>
		[XAQueryFieldAttribute("주문가격")]
		public double ordprc;
		/// <summary>
		/// 미체결수량
		/// </summary>
		[XAQueryFieldAttribute("미체결수량")]
		public long unercqty;
		/// <summary>
		/// 통신매체
		/// </summary>
		[XAQueryFieldAttribute("통신매체")]
		public string commdacode;
		/// <summary>
		/// 수수료합산코드
		/// </summary>
		[XAQueryFieldAttribute("수수료합산코드")]
		public string peeamtcode;
		/// <summary>
		/// 관리사원
		/// </summary>
		[XAQueryFieldAttribute("관리사원")]
		public string mgempno;
		/// <summary>
		/// 선물옵션거래단위금액
		/// </summary>
		[XAQueryFieldAttribute("선물옵션거래단위금액")]
		public double fnotrdunitamt;
		/// <summary>
		/// 처리시각
		/// </summary>
		[XAQueryFieldAttribute("처리시각")]
		public string trxtime;
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
		public string ordseqno;
		/// <summary>
		/// 포트폴리오 번호
		/// </summary>
		[XAQueryFieldAttribute("포트폴리오 번호")]
		public string ptflno;
		/// <summary>
		/// 바스켓번호
		/// </summary>
		[XAQueryFieldAttribute("바스켓번호")]
		public string bskno;
		/// <summary>
		/// 트렌치번호
		/// </summary>
		[XAQueryFieldAttribute("트렌치번호")]
		public string trchno;
		/// <summary>
		/// 아이템번호
		/// </summary>
		[XAQueryFieldAttribute("아이템번호")]
		public string Itemno;
		/// <summary>
		/// 주문자Id
		/// </summary>
		[XAQueryFieldAttribute("주문자Id")]
		public string OrderID;
		/// <summary>
		/// 운영지시번호
		/// </summary>
		[XAQueryFieldAttribute("운영지시번호")]
		public string opdrtnno;
		/// <summary>
		/// 부적격코드
		/// </summary>
		[XAQueryFieldAttribute("부적격코드")]
		public string rjtcode;
		/// <summary>
		/// 정정취소확인수량
		/// </summary>
		[XAQueryFieldAttribute("정정취소확인수량")]
		public long mrccnfqty;
		/// <summary>
		/// 원주문미체결수량
		/// </summary>
		[XAQueryFieldAttribute("원주문미체결수량")]
		public long orgordunercqty;
		/// <summary>
		/// 원주문정정취소수량
		/// </summary>
		[XAQueryFieldAttribute("원주문정정취소수량")]
		public long orgordmrcqty;
		/// <summary>
		/// 약정시각(체결시각)
		/// </summary>
		[XAQueryFieldAttribute("약정시각(체결시각)")]
		public string ctrcttime;
		/// <summary>
		/// 약정번호
		/// </summary>
		[XAQueryFieldAttribute("약정번호")]
		public string ctrctno;
		/// <summary>
		/// 체결가격
		/// </summary>
		[XAQueryFieldAttribute("체결가격")]
		public double execprc;
		/// <summary>
		/// 체결수량
		/// </summary>
		[XAQueryFieldAttribute("체결수량")]
		public long execqty;
		/// <summary>
		/// 신규체결수량
		/// </summary>
		[XAQueryFieldAttribute("신규체결수량")]
		public long newqty;
		/// <summary>
		/// 청산체결수량
		/// </summary>
		[XAQueryFieldAttribute("청산체결수량")]
		public long qdtqty;
		/// <summary>
		/// 최종결제수량
		/// </summary>
		[XAQueryFieldAttribute("최종결제수량")]
		public long lastqty;
		/// <summary>
		/// 전체체결수량
		/// </summary>
		[XAQueryFieldAttribute("전체체결수량")]
		public long lallexecqty;
		/// <summary>
		/// 전체체결금액
		/// </summary>
		[XAQueryFieldAttribute("전체체결금액")]
		public long allexecamt;
		/// <summary>
		/// 잔고평가구분
		/// </summary>
		[XAQueryFieldAttribute("잔고평가구분")]
		public char fnobalevaltp;
		/// <summary>
		/// 매매손익금액
		/// </summary>
		[XAQueryFieldAttribute("매매손익금액")]
		public long bnsplamt;
		/// <summary>
		/// 선물옵션종목번호1
		/// </summary>
		[XAQueryFieldAttribute("선물옵션종목번호1")]
		public string fnoIsuno1;
		/// <summary>
		/// 매매구분1
		/// </summary>
		[XAQueryFieldAttribute("매매구분1")]
		public char bnstp1;
		/// <summary>
		/// 체결가1
		/// </summary>
		[XAQueryFieldAttribute("체결가1")]
		public double execprc1;
		/// <summary>
		/// 신규체결수량1
		/// </summary>
		[XAQueryFieldAttribute("신규체결수량1")]
		public long newqty1;
		/// <summary>
		/// 청산체결수량1
		/// </summary>
		[XAQueryFieldAttribute("청산체결수량1")]
		public long qdtqty1;
		/// <summary>
		/// 전체체결금액1
		/// </summary>
		[XAQueryFieldAttribute("전체체결금액1")]
		public long allexecamt1;
		/// <summary>
		/// 선물옵션종목번호2
		/// </summary>
		[XAQueryFieldAttribute("선물옵션종목번호2")]
		public string fnoIsuno2;
		/// <summary>
		/// 매매구분2
		/// </summary>
		[XAQueryFieldAttribute("매매구분2")]
		public char bnstp2;
		/// <summary>
		/// 체결가2
		/// </summary>
		[XAQueryFieldAttribute("체결가2")]
		public double execprc2;
		/// <summary>
		/// 신규체결수량2
		/// </summary>
		[XAQueryFieldAttribute("신규체결수량2")]
		public long newqty2;
		/// <summary>
		/// 청산체결수량2
		/// </summary>
		[XAQueryFieldAttribute("청산체결수량2")]
		public long lqdtqty2;
		/// <summary>
		/// 전체체결금액2
		/// </summary>
		[XAQueryFieldAttribute("전체체결금액2")]
		public long allexecamt2;
		/// <summary>
		/// 예수금
		/// </summary>
		[XAQueryFieldAttribute("예수금")]
		public long dps;
		/// <summary>
		/// 선물대용지정금액
		/// </summary>
		[XAQueryFieldAttribute("선물대용지정금액")]
		public long ftsubtdsgnamt;
		/// <summary>
		/// 증거금
		/// </summary>
		[XAQueryFieldAttribute("증거금")]
		public long mgn;
		/// <summary>
		/// 증거금현금
		/// </summary>
		[XAQueryFieldAttribute("증거금현금")]
		public long mnymgn;
		/// <summary>
		/// 주문가능금액
		/// </summary>
		[XAQueryFieldAttribute("주문가능금액")]
		public long ordableamt;
		/// <summary>
		/// 주문가능현금액
		/// </summary>
		[XAQueryFieldAttribute("주문가능현금액")]
		public long mnyordableamt;
		/// <summary>
		/// 잔고 종목번호1
		/// </summary>
		[XAQueryFieldAttribute("잔고 종목번호1")]
		public string fnoIsuno_1;
		/// <summary>
		/// 잔고 매매구분1
		/// </summary>
		[XAQueryFieldAttribute("잔고 매매구분1")]
		public char bnstp_1;
		/// <summary>
		/// 미결제수량1
		/// </summary>
		[XAQueryFieldAttribute("미결제수량1")]
		public long unsttqty_1;
		/// <summary>
		/// 주문가능수량1
		/// </summary>
		[XAQueryFieldAttribute("주문가능수량1")]
		public long lqdtableqty_1;
		/// <summary>
		/// 평균가1
		/// </summary>
		[XAQueryFieldAttribute("평균가1")]
		public double avrprc_1;
		/// <summary>
		/// 잔고 종목번호2
		/// </summary>
		[XAQueryFieldAttribute("잔고 종목번호2")]
		public string fnoIsuno_2;
		/// <summary>
		/// 잔고 매매구분2
		/// </summary>
		[XAQueryFieldAttribute("잔고 매매구분2")]
		public char bnstp_2;
		/// <summary>
		/// 미결제수량2
		/// </summary>
		[XAQueryFieldAttribute("미결제수량2")]
		public long unsttqty_2;
		/// <summary>
		/// 주문가능수량2
		/// </summary>
		[XAQueryFieldAttribute("주문가능수량2")]
		public long lqdtableqty_2;
		/// <summary>
		/// 평균가2
		/// </summary>
		[XAQueryFieldAttribute("평균가2")]
		public double avrprc_2;

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
			/// tr코드
			/// </summary>
			public const string trcode1 = "trcode1";
			/// <summary>
			/// 회사번호
			/// </summary>
			public const string firmno = "firmno";
			/// <summary>
			/// 계좌번호
			/// </summary>
			public const string acntno = "acntno";
			/// <summary>
			/// 계좌번호
			/// </summary>
			public const string acntno1 = "acntno1";
			/// <summary>
			/// 계좌명
			/// </summary>
			public const string acntnm = "acntnm";
			/// <summary>
			/// 지점번호
			/// </summary>
			public const string brnno = "brnno";
			/// <summary>
			/// 주문시장코드
			/// </summary>
			public const string ordmktcode = "ordmktcode";
			/// <summary>
			/// 주문번호
			/// </summary>
			public const string ordno1 = "ordno1";
			/// <summary>
			/// 주문번호
			/// </summary>
			public const string ordno = "ordno";
			/// <summary>
			/// 원주문번호
			/// </summary>
			public const string orgordno1 = "orgordno1";
			/// <summary>
			/// 원주문번호
			/// </summary>
			public const string orgordno = "orgordno";
			/// <summary>
			/// 모주문번호
			/// </summary>
			public const string prntordno = "prntordno";
			/// <summary>
			/// 모주문번호
			/// </summary>
			public const string prntordno1 = "prntordno1";
			/// <summary>
			/// 종목번호
			/// </summary>
			public const string isuno = "isuno";
			/// <summary>
			/// 선물옵션종목번호
			/// </summary>
			public const string fnoIsuno = "fnoIsuno";
			/// <summary>
			/// 선물옵션종목명
			/// </summary>
			public const string fnoIsunm = "fnoIsunm";
			/// <summary>
			/// 상품군분류코드
			/// </summary>
			public const string pdgrpcode = "pdgrpcode";
			/// <summary>
			/// 선물옵션종목유형구분
			/// </summary>
			public const string fnoIsuptntp = "fnoIsuptntp";
			/// <summary>
			/// 매매구분
			/// </summary>
			public const string bnstp = "bnstp";
			/// <summary>
			/// 정정취소구분
			/// </summary>
			public const string mrctp = "mrctp";
			/// <summary>
			/// 주문수량
			/// </summary>
			public const string ordqty = "ordqty";
			/// <summary>
			/// 호가유형코드
			/// </summary>
			public const string hogatype = "hogatype";
			/// <summary>
			/// 거래유형코드
			/// </summary>
			public const string mmgb = "mmgb";
			/// <summary>
			/// 주문가격
			/// </summary>
			public const string ordprc = "ordprc";
			/// <summary>
			/// 미체결수량
			/// </summary>
			public const string unercqty = "unercqty";
			/// <summary>
			/// 통신매체
			/// </summary>
			public const string commdacode = "commdacode";
			/// <summary>
			/// 수수료합산코드
			/// </summary>
			public const string peeamtcode = "peeamtcode";
			/// <summary>
			/// 관리사원
			/// </summary>
			public const string mgempno = "mgempno";
			/// <summary>
			/// 선물옵션거래단위금액
			/// </summary>
			public const string fnotrdunitamt = "fnotrdunitamt";
			/// <summary>
			/// 처리시각
			/// </summary>
			public const string trxtime = "trxtime";
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
			/// 포트폴리오 번호
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
			public const string Itemno = "Itemno";
			/// <summary>
			/// 주문자Id
			/// </summary>
			public const string OrderID = "OrderID";
			/// <summary>
			/// 운영지시번호
			/// </summary>
			public const string opdrtnno = "opdrtnno";
			/// <summary>
			/// 부적격코드
			/// </summary>
			public const string rjtcode = "rjtcode";
			/// <summary>
			/// 정정취소확인수량
			/// </summary>
			public const string mrccnfqty = "mrccnfqty";
			/// <summary>
			/// 원주문미체결수량
			/// </summary>
			public const string orgordunercqty = "orgordunercqty";
			/// <summary>
			/// 원주문정정취소수량
			/// </summary>
			public const string orgordmrcqty = "orgordmrcqty";
			/// <summary>
			/// 약정시각(체결시각)
			/// </summary>
			public const string ctrcttime = "ctrcttime";
			/// <summary>
			/// 약정번호
			/// </summary>
			public const string ctrctno = "ctrctno";
			/// <summary>
			/// 체결가격
			/// </summary>
			public const string execprc = "execprc";
			/// <summary>
			/// 체결수량
			/// </summary>
			public const string execqty = "execqty";
			/// <summary>
			/// 신규체결수량
			/// </summary>
			public const string newqty = "newqty";
			/// <summary>
			/// 청산체결수량
			/// </summary>
			public const string qdtqty = "qdtqty";
			/// <summary>
			/// 최종결제수량
			/// </summary>
			public const string lastqty = "lastqty";
			/// <summary>
			/// 전체체결수량
			/// </summary>
			public const string lallexecqty = "lallexecqty";
			/// <summary>
			/// 전체체결금액
			/// </summary>
			public const string allexecamt = "allexecamt";
			/// <summary>
			/// 잔고평가구분
			/// </summary>
			public const string fnobalevaltp = "fnobalevaltp";
			/// <summary>
			/// 매매손익금액
			/// </summary>
			public const string bnsplamt = "bnsplamt";
			/// <summary>
			/// 선물옵션종목번호1
			/// </summary>
			public const string fnoIsuno1 = "fnoIsuno1";
			/// <summary>
			/// 매매구분1
			/// </summary>
			public const string bnstp1 = "bnstp1";
			/// <summary>
			/// 체결가1
			/// </summary>
			public const string execprc1 = "execprc1";
			/// <summary>
			/// 신규체결수량1
			/// </summary>
			public const string newqty1 = "newqty1";
			/// <summary>
			/// 청산체결수량1
			/// </summary>
			public const string qdtqty1 = "qdtqty1";
			/// <summary>
			/// 전체체결금액1
			/// </summary>
			public const string allexecamt1 = "allexecamt1";
			/// <summary>
			/// 선물옵션종목번호2
			/// </summary>
			public const string fnoIsuno2 = "fnoIsuno2";
			/// <summary>
			/// 매매구분2
			/// </summary>
			public const string bnstp2 = "bnstp2";
			/// <summary>
			/// 체결가2
			/// </summary>
			public const string execprc2 = "execprc2";
			/// <summary>
			/// 신규체결수량2
			/// </summary>
			public const string newqty2 = "newqty2";
			/// <summary>
			/// 청산체결수량2
			/// </summary>
			public const string lqdtqty2 = "lqdtqty2";
			/// <summary>
			/// 전체체결금액2
			/// </summary>
			public const string allexecamt2 = "allexecamt2";
			/// <summary>
			/// 예수금
			/// </summary>
			public const string dps = "dps";
			/// <summary>
			/// 선물대용지정금액
			/// </summary>
			public const string ftsubtdsgnamt = "ftsubtdsgnamt";
			/// <summary>
			/// 증거금
			/// </summary>
			public const string mgn = "mgn";
			/// <summary>
			/// 증거금현금
			/// </summary>
			public const string mnymgn = "mnymgn";
			/// <summary>
			/// 주문가능금액
			/// </summary>
			public const string ordableamt = "ordableamt";
			/// <summary>
			/// 주문가능현금액
			/// </summary>
			public const string mnyordableamt = "mnyordableamt";
			/// <summary>
			/// 잔고 종목번호1
			/// </summary>
			public const string fnoIsuno_1 = "fnoIsuno_1";
			/// <summary>
			/// 잔고 매매구분1
			/// </summary>
			public const string bnstp_1 = "bnstp_1";
			/// <summary>
			/// 미결제수량1
			/// </summary>
			public const string unsttqty_1 = "unsttqty_1";
			/// <summary>
			/// 주문가능수량1
			/// </summary>
			public const string lqdtableqty_1 = "lqdtableqty_1";
			/// <summary>
			/// 평균가1
			/// </summary>
			public const string avrprc_1 = "avrprc_1";
			/// <summary>
			/// 잔고 종목번호2
			/// </summary>
			public const string fnoIsuno_2 = "fnoIsuno_2";
			/// <summary>
			/// 잔고 매매구분2
			/// </summary>
			public const string bnstp_2 = "bnstp_2";
			/// <summary>
			/// 미결제수량2
			/// </summary>
			public const string unsttqty_2 = "unsttqty_2";
			/// <summary>
			/// 주문가능수량2
			/// </summary>
			public const string lqdtableqty_2 = "lqdtableqty_2";
			/// <summary>
			/// 평균가2
			/// </summary>
			public const string avrprc_2 = "avrprc_2";
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
			F.trcode1,
			F.firmno,
			F.acntno,
			F.acntno1,
			F.acntnm,
			F.brnno,
			F.ordmktcode,
			F.ordno1,
			F.ordno,
			F.orgordno1,
			F.orgordno,
			F.prntordno,
			F.prntordno1,
			F.isuno,
			F.fnoIsuno,
			F.fnoIsunm,
			F.pdgrpcode,
			F.fnoIsuptntp,
			F.bnstp,
			F.mrctp,
			F.ordqty,
			F.hogatype,
			F.mmgb,
			F.ordprc,
			F.unercqty,
			F.commdacode,
			F.peeamtcode,
			F.mgempno,
			F.fnotrdunitamt,
			F.trxtime,
			F.strtgcode,
			F.grpId,
			F.ordseqno,
			F.ptflno,
			F.bskno,
			F.trchno,
			F.Itemno,
			F.OrderID,
			F.opdrtnno,
			F.rjtcode,
			F.mrccnfqty,
			F.orgordunercqty,
			F.orgordmrcqty,
			F.ctrcttime,
			F.ctrctno,
			F.execprc,
			F.execqty,
			F.newqty,
			F.qdtqty,
			F.lastqty,
			F.lallexecqty,
			F.allexecamt,
			F.fnobalevaltp,
			F.bnsplamt,
			F.fnoIsuno1,
			F.bnstp1,
			F.execprc1,
			F.newqty1,
			F.qdtqty1,
			F.allexecamt1,
			F.fnoIsuno2,
			F.bnstp2,
			F.execprc2,
			F.newqty2,
			F.lqdtqty2,
			F.allexecamt2,
			F.dps,
			F.ftsubtdsgnamt,
			F.mgn,
			F.mnymgn,
			F.ordableamt,
			F.mnyordableamt,
			F.fnoIsuno_1,
			F.bnstp_1,
			F.unsttqty_1,
			F.lqdtableqty_1,
			F.avrprc_1,
			F.fnoIsuno_2,
			F.bnstp_2,
			F.unsttqty_2,
			F.lqdtableqty_2,
			F.avrprc_2,
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
			dict["trcode1"] = new XAQueryFieldInfo("char", trcode1, trcode1, "tr코드", (decimal)4);
			dict["firmno"] = new XAQueryFieldInfo("char", firmno, firmno, "회사번호", (decimal)3);
			dict["acntno"] = new XAQueryFieldInfo("char", acntno, acntno, "계좌번호", (decimal)11);
			dict["acntno1"] = new XAQueryFieldInfo("char", acntno1, acntno1, "계좌번호", (decimal)9);
			dict["acntnm"] = new XAQueryFieldInfo("char", acntnm, acntnm, "계좌명", (decimal)40);
			dict["brnno"] = new XAQueryFieldInfo("char", brnno, brnno, "지점번호", (decimal)3);
			dict["ordmktcode"] = new XAQueryFieldInfo("char", ordmktcode, ordmktcode, "주문시장코드", (decimal)2);
			dict["ordno1"] = new XAQueryFieldInfo("char", ordno1, ordno1, "주문번호", (decimal)3);
			dict["ordno"] = new XAQueryFieldInfo("long", ordno, ordno.ToString("d7"), "주문번호", (decimal)7);
			dict["orgordno1"] = new XAQueryFieldInfo("char", orgordno1, orgordno1, "원주문번호", (decimal)3);
			dict["orgordno"] = new XAQueryFieldInfo("long", orgordno, orgordno.ToString("d7"), "원주문번호", (decimal)7);
			dict["prntordno"] = new XAQueryFieldInfo("char", prntordno, prntordno, "모주문번호", (decimal)3);
			dict["prntordno1"] = new XAQueryFieldInfo("long", prntordno1, prntordno1.ToString("d7"), "모주문번호", (decimal)7);
			dict["isuno"] = new XAQueryFieldInfo("char", isuno, isuno, "종목번호", (decimal)12);
			dict["fnoIsuno"] = new XAQueryFieldInfo("char", fnoIsuno, fnoIsuno, "선물옵션종목번호", (decimal)8);
			dict["fnoIsunm"] = new XAQueryFieldInfo("char", fnoIsunm, fnoIsunm, "선물옵션종목명", (decimal)40);
			dict["pdgrpcode"] = new XAQueryFieldInfo("char", pdgrpcode, pdgrpcode, "상품군분류코드", (decimal)2);
			dict["fnoIsuptntp"] = new XAQueryFieldInfo("char", fnoIsuptntp, fnoIsuptntp.ToString(), "선물옵션종목유형구분", (decimal)1);
			dict["bnstp"] = new XAQueryFieldInfo("char", bnstp, bnstp.ToString(), "매매구분", (decimal)1);
			dict["mrctp"] = new XAQueryFieldInfo("char", mrctp, mrctp.ToString(), "정정취소구분", (decimal)1);
			dict["ordqty"] = new XAQueryFieldInfo("long", ordqty, ordqty.ToString("d16"), "주문수량", (decimal)16);
			dict["hogatype"] = new XAQueryFieldInfo("char", hogatype, hogatype, "호가유형코드", (decimal)2);
			dict["mmgb"] = new XAQueryFieldInfo("char", mmgb, mmgb, "거래유형코드", (decimal)2);
			dict["ordprc"] = new XAQueryFieldInfo("double", ordprc, ordprc.ToString("0000000000000.00"), "주문가격", (decimal)13.2);
			dict["unercqty"] = new XAQueryFieldInfo("long", unercqty, unercqty.ToString("d16"), "미체결수량", (decimal)16);
			dict["commdacode"] = new XAQueryFieldInfo("char", commdacode, commdacode, "통신매체", (decimal)2);
			dict["peeamtcode"] = new XAQueryFieldInfo("char", peeamtcode, peeamtcode, "수수료합산코드", (decimal)2);
			dict["mgempno"] = new XAQueryFieldInfo("char", mgempno, mgempno, "관리사원", (decimal)9);
			dict["fnotrdunitamt"] = new XAQueryFieldInfo("double", fnotrdunitamt, fnotrdunitamt.ToString("0000000000000000000.00000000"), "선물옵션거래단위금액", (decimal)19.8);
			dict["trxtime"] = new XAQueryFieldInfo("char", trxtime, trxtime, "처리시각", (decimal)9);
			dict["strtgcode"] = new XAQueryFieldInfo("char", strtgcode, strtgcode, "전략코드", (decimal)6);
			dict["grpId"] = new XAQueryFieldInfo("char", grpId, grpId, "그룹Id", (decimal)20);
			dict["ordseqno"] = new XAQueryFieldInfo("char", ordseqno, ordseqno, "주문회차", (decimal)10);
			dict["ptflno"] = new XAQueryFieldInfo("char", ptflno, ptflno, "포트폴리오 번호", (decimal)10);
			dict["bskno"] = new XAQueryFieldInfo("char", bskno, bskno, "바스켓번호", (decimal)10);
			dict["trchno"] = new XAQueryFieldInfo("char", trchno, trchno, "트렌치번호", (decimal)10);
			dict["Itemno"] = new XAQueryFieldInfo("char", Itemno, Itemno, "아이템번호", (decimal)10);
			dict["OrderID"] = new XAQueryFieldInfo("char", OrderID, OrderID, "주문자Id", (decimal)16);
			dict["opdrtnno"] = new XAQueryFieldInfo("char", opdrtnno, opdrtnno, "운영지시번호", (decimal)12);
			dict["rjtcode"] = new XAQueryFieldInfo("char", rjtcode, rjtcode, "부적격코드", (decimal)4);
			dict["mrccnfqty"] = new XAQueryFieldInfo("long", mrccnfqty, mrccnfqty.ToString("d16"), "정정취소확인수량", (decimal)16);
			dict["orgordunercqty"] = new XAQueryFieldInfo("long", orgordunercqty, orgordunercqty.ToString("d16"), "원주문미체결수량", (decimal)16);
			dict["orgordmrcqty"] = new XAQueryFieldInfo("long", orgordmrcqty, orgordmrcqty.ToString("d16"), "원주문정정취소수량", (decimal)16);
			dict["ctrcttime"] = new XAQueryFieldInfo("char", ctrcttime, ctrcttime, "약정시각(체결시각)", (decimal)8);
			dict["ctrctno"] = new XAQueryFieldInfo("char", ctrctno, ctrctno, "약정번호", (decimal)10);
			dict["execprc"] = new XAQueryFieldInfo("double", execprc, execprc.ToString("0000000000000.00"), "체결가격", (decimal)13.2);
			dict["execqty"] = new XAQueryFieldInfo("long", execqty, execqty.ToString("d16"), "체결수량", (decimal)16);
			dict["newqty"] = new XAQueryFieldInfo("long", newqty, newqty.ToString("d16"), "신규체결수량", (decimal)16);
			dict["qdtqty"] = new XAQueryFieldInfo("long", qdtqty, qdtqty.ToString("d16"), "청산체결수량", (decimal)16);
			dict["lastqty"] = new XAQueryFieldInfo("long", lastqty, lastqty.ToString("d16"), "최종결제수량", (decimal)16);
			dict["lallexecqty"] = new XAQueryFieldInfo("long", lallexecqty, lallexecqty.ToString("d16"), "전체체결수량", (decimal)16);
			dict["allexecamt"] = new XAQueryFieldInfo("long", allexecamt, allexecamt.ToString("d16"), "전체체결금액", (decimal)16);
			dict["fnobalevaltp"] = new XAQueryFieldInfo("char", fnobalevaltp, fnobalevaltp.ToString(), "잔고평가구분", (decimal)1);
			dict["bnsplamt"] = new XAQueryFieldInfo("long", bnsplamt, bnsplamt.ToString("d16"), "매매손익금액", (decimal)16);
			dict["fnoIsuno1"] = new XAQueryFieldInfo("char", fnoIsuno1, fnoIsuno1, "선물옵션종목번호1", (decimal)8);
			dict["bnstp1"] = new XAQueryFieldInfo("char", bnstp1, bnstp1.ToString(), "매매구분1", (decimal)1);
			dict["execprc1"] = new XAQueryFieldInfo("double", execprc1, execprc1.ToString("0000000000000.00"), "체결가1", (decimal)13.2);
			dict["newqty1"] = new XAQueryFieldInfo("long", newqty1, newqty1.ToString("d16"), "신규체결수량1", (decimal)16);
			dict["qdtqty1"] = new XAQueryFieldInfo("long", qdtqty1, qdtqty1.ToString("d16"), "청산체결수량1", (decimal)16);
			dict["allexecamt1"] = new XAQueryFieldInfo("long", allexecamt1, allexecamt1.ToString("d16"), "전체체결금액1", (decimal)16);
			dict["fnoIsuno2"] = new XAQueryFieldInfo("char", fnoIsuno2, fnoIsuno2, "선물옵션종목번호2", (decimal)8);
			dict["bnstp2"] = new XAQueryFieldInfo("char", bnstp2, bnstp2.ToString(), "매매구분2", (decimal)1);
			dict["execprc2"] = new XAQueryFieldInfo("double", execprc2, execprc2.ToString("0000000000000.00"), "체결가2", (decimal)13.2);
			dict["newqty2"] = new XAQueryFieldInfo("long", newqty2, newqty2.ToString("d16"), "신규체결수량2", (decimal)16);
			dict["lqdtqty2"] = new XAQueryFieldInfo("long", lqdtqty2, lqdtqty2.ToString("d16"), "청산체결수량2", (decimal)16);
			dict["allexecamt2"] = new XAQueryFieldInfo("long", allexecamt2, allexecamt2.ToString("d16"), "전체체결금액2", (decimal)16);
			dict["dps"] = new XAQueryFieldInfo("long", dps, dps.ToString("d16"), "예수금", (decimal)16);
			dict["ftsubtdsgnamt"] = new XAQueryFieldInfo("long", ftsubtdsgnamt, ftsubtdsgnamt.ToString("d16"), "선물대용지정금액", (decimal)16);
			dict["mgn"] = new XAQueryFieldInfo("long", mgn, mgn.ToString("d16"), "증거금", (decimal)16);
			dict["mnymgn"] = new XAQueryFieldInfo("long", mnymgn, mnymgn.ToString("d16"), "증거금현금", (decimal)16);
			dict["ordableamt"] = new XAQueryFieldInfo("long", ordableamt, ordableamt.ToString("d16"), "주문가능금액", (decimal)16);
			dict["mnyordableamt"] = new XAQueryFieldInfo("long", mnyordableamt, mnyordableamt.ToString("d16"), "주문가능현금액", (decimal)16);
			dict["fnoIsuno_1"] = new XAQueryFieldInfo("char", fnoIsuno_1, fnoIsuno_1, "잔고 종목번호1", (decimal)8);
			dict["bnstp_1"] = new XAQueryFieldInfo("char", bnstp_1, bnstp_1.ToString(), "잔고 매매구분1", (decimal)1);
			dict["unsttqty_1"] = new XAQueryFieldInfo("long", unsttqty_1, unsttqty_1.ToString("d16"), "미결제수량1", (decimal)16);
			dict["lqdtableqty_1"] = new XAQueryFieldInfo("long", lqdtableqty_1, lqdtableqty_1.ToString("d16"), "주문가능수량1", (decimal)16);
			dict["avrprc_1"] = new XAQueryFieldInfo("double", avrprc_1, avrprc_1.ToString("0000000000000.00"), "평균가1", (decimal)13.2);
			dict["fnoIsuno_2"] = new XAQueryFieldInfo("char", fnoIsuno_2, fnoIsuno_2, "잔고 종목번호2", (decimal)8);
			dict["bnstp_2"] = new XAQueryFieldInfo("char", bnstp_2, bnstp_2.ToString(), "잔고 매매구분2", (decimal)1);
			dict["unsttqty_2"] = new XAQueryFieldInfo("long", unsttqty_2, unsttqty_2.ToString("d16"), "미결제수량2", (decimal)16);
			dict["lqdtableqty_2"] = new XAQueryFieldInfo("long", lqdtableqty_2, lqdtableqty_2.ToString("d16"), "주문가능수량2", (decimal)16);
			dict["avrprc_2"] = new XAQueryFieldInfo("double", avrprc_2, avrprc_2.ToString("0000000000000.00"), "평균가2", (decimal)13.2);

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

				case "trcode1":
					this.trcode1 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "firmno":
					this.firmno = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "acntno":
					this.acntno = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "acntno1":
					this.acntno1 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "acntnm":
					this.acntnm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "brnno":
					this.brnno = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ordmktcode":
					this.ordmktcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ordno1":
					this.ordno1 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ordno":
					this.ordno = fieldInfo.FieldValue.ParseLong("ordno");
				break;

				case "orgordno1":
					this.orgordno1 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "orgordno":
					this.orgordno = fieldInfo.FieldValue.ParseLong("orgordno");
				break;

				case "prntordno":
					this.prntordno = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "prntordno1":
					this.prntordno1 = fieldInfo.FieldValue.ParseLong("prntordno1");
				break;

				case "isuno":
					this.isuno = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "fnoIsuno":
					this.fnoIsuno = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "fnoIsunm":
					this.fnoIsunm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "pdgrpcode":
					this.pdgrpcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "fnoIsuptntp":
					this.fnoIsuptntp = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "bnstp":
					this.bnstp = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "mrctp":
					this.mrctp = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "ordqty":
					this.ordqty = fieldInfo.FieldValue.ParseLong("ordqty");
				break;

				case "hogatype":
					this.hogatype = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "mmgb":
					this.mmgb = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ordprc":
					this.ordprc = fieldInfo.FieldValue.ParseDouble("ordprc");
				break;

				case "unercqty":
					this.unercqty = fieldInfo.FieldValue.ParseLong("unercqty");
				break;

				case "commdacode":
					this.commdacode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "peeamtcode":
					this.peeamtcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "mgempno":
					this.mgempno = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "fnotrdunitamt":
					this.fnotrdunitamt = fieldInfo.FieldValue.ParseDouble("fnotrdunitamt");
				break;

				case "trxtime":
					this.trxtime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "strtgcode":
					this.strtgcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "grpId":
					this.grpId = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ordseqno":
					this.ordseqno = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ptflno":
					this.ptflno = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "bskno":
					this.bskno = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "trchno":
					this.trchno = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "Itemno":
					this.Itemno = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "OrderID":
					this.OrderID = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "opdrtnno":
					this.opdrtnno = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "rjtcode":
					this.rjtcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "mrccnfqty":
					this.mrccnfqty = fieldInfo.FieldValue.ParseLong("mrccnfqty");
				break;

				case "orgordunercqty":
					this.orgordunercqty = fieldInfo.FieldValue.ParseLong("orgordunercqty");
				break;

				case "orgordmrcqty":
					this.orgordmrcqty = fieldInfo.FieldValue.ParseLong("orgordmrcqty");
				break;

				case "ctrcttime":
					this.ctrcttime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ctrctno":
					this.ctrctno = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "execprc":
					this.execprc = fieldInfo.FieldValue.ParseDouble("execprc");
				break;

				case "execqty":
					this.execqty = fieldInfo.FieldValue.ParseLong("execqty");
				break;

				case "newqty":
					this.newqty = fieldInfo.FieldValue.ParseLong("newqty");
				break;

				case "qdtqty":
					this.qdtqty = fieldInfo.FieldValue.ParseLong("qdtqty");
				break;

				case "lastqty":
					this.lastqty = fieldInfo.FieldValue.ParseLong("lastqty");
				break;

				case "lallexecqty":
					this.lallexecqty = fieldInfo.FieldValue.ParseLong("lallexecqty");
				break;

				case "allexecamt":
					this.allexecamt = fieldInfo.FieldValue.ParseLong("allexecamt");
				break;

				case "fnobalevaltp":
					this.fnobalevaltp = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "bnsplamt":
					this.bnsplamt = fieldInfo.FieldValue.ParseLong("bnsplamt");
				break;

				case "fnoIsuno1":
					this.fnoIsuno1 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "bnstp1":
					this.bnstp1 = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "execprc1":
					this.execprc1 = fieldInfo.FieldValue.ParseDouble("execprc1");
				break;

				case "newqty1":
					this.newqty1 = fieldInfo.FieldValue.ParseLong("newqty1");
				break;

				case "qdtqty1":
					this.qdtqty1 = fieldInfo.FieldValue.ParseLong("qdtqty1");
				break;

				case "allexecamt1":
					this.allexecamt1 = fieldInfo.FieldValue.ParseLong("allexecamt1");
				break;

				case "fnoIsuno2":
					this.fnoIsuno2 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "bnstp2":
					this.bnstp2 = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "execprc2":
					this.execprc2 = fieldInfo.FieldValue.ParseDouble("execprc2");
				break;

				case "newqty2":
					this.newqty2 = fieldInfo.FieldValue.ParseLong("newqty2");
				break;

				case "lqdtqty2":
					this.lqdtqty2 = fieldInfo.FieldValue.ParseLong("lqdtqty2");
				break;

				case "allexecamt2":
					this.allexecamt2 = fieldInfo.FieldValue.ParseLong("allexecamt2");
				break;

				case "dps":
					this.dps = fieldInfo.FieldValue.ParseLong("dps");
				break;

				case "ftsubtdsgnamt":
					this.ftsubtdsgnamt = fieldInfo.FieldValue.ParseLong("ftsubtdsgnamt");
				break;

				case "mgn":
					this.mgn = fieldInfo.FieldValue.ParseLong("mgn");
				break;

				case "mnymgn":
					this.mnymgn = fieldInfo.FieldValue.ParseLong("mnymgn");
				break;

				case "ordableamt":
					this.ordableamt = fieldInfo.FieldValue.ParseLong("ordableamt");
				break;

				case "mnyordableamt":
					this.mnyordableamt = fieldInfo.FieldValue.ParseLong("mnyordableamt");
				break;

				case "fnoIsuno_1":
					this.fnoIsuno_1 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "bnstp_1":
					this.bnstp_1 = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "unsttqty_1":
					this.unsttqty_1 = fieldInfo.FieldValue.ParseLong("unsttqty_1");
				break;

				case "lqdtableqty_1":
					this.lqdtableqty_1 = fieldInfo.FieldValue.ParseLong("lqdtableqty_1");
				break;

				case "avrprc_1":
					this.avrprc_1 = fieldInfo.FieldValue.ParseDouble("avrprc_1");
				break;

				case "fnoIsuno_2":
					this.fnoIsuno_2 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "bnstp_2":
					this.bnstp_2 = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "unsttqty_2":
					this.unsttqty_2 = fieldInfo.FieldValue.ParseLong("unsttqty_2");
				break;

				case "lqdtableqty_2":
					this.lqdtableqty_2 = fieldInfo.FieldValue.ParseLong("lqdtableqty_2");
				break;

				case "avrprc_2":
					this.avrprc_2 = fieldInfo.FieldValue.ParseDouble("avrprc_2");
				break;


			}
		}

		public static XREU1OutBlock FromQuery(XREU1 query)
		{
			XREU1OutBlock block = new XREU1OutBlock();
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
				block.trcode1 = query.GetFieldData(block.GetBlockName(), "trcode1").TrimEnd('?'); // char 4
				block.firmno = query.GetFieldData(block.GetBlockName(), "firmno").TrimEnd('?'); // char 3
				block.acntno = query.GetFieldData(block.GetBlockName(), "acntno").TrimEnd('?'); // char 11
				block.acntno1 = query.GetFieldData(block.GetBlockName(), "acntno1").TrimEnd('?'); // char 9
				block.acntnm = query.GetFieldData(block.GetBlockName(), "acntnm").TrimEnd('?'); // char 40
				block.brnno = query.GetFieldData(block.GetBlockName(), "brnno").TrimEnd('?'); // char 3
				block.ordmktcode = query.GetFieldData(block.GetBlockName(), "ordmktcode").TrimEnd('?'); // char 2
				block.ordno1 = query.GetFieldData(block.GetBlockName(), "ordno1").TrimEnd('?'); // char 3
				block.ordno = query.GetFieldData(block.GetBlockName(), "ordno").ParseLong("ordno"); // long 7
				block.orgordno1 = query.GetFieldData(block.GetBlockName(), "orgordno1").TrimEnd('?'); // char 3
				block.orgordno = query.GetFieldData(block.GetBlockName(), "orgordno").ParseLong("orgordno"); // long 7
				block.prntordno = query.GetFieldData(block.GetBlockName(), "prntordno").TrimEnd('?'); // char 3
				block.prntordno1 = query.GetFieldData(block.GetBlockName(), "prntordno1").ParseLong("prntordno1"); // long 7
				block.isuno = query.GetFieldData(block.GetBlockName(), "isuno").TrimEnd('?'); // char 12
				block.fnoIsuno = query.GetFieldData(block.GetBlockName(), "fnoIsuno").TrimEnd('?'); // char 8
				block.fnoIsunm = query.GetFieldData(block.GetBlockName(), "fnoIsunm").TrimEnd('?'); // char 40
				block.pdgrpcode = query.GetFieldData(block.GetBlockName(), "pdgrpcode").TrimEnd('?'); // char 2
				block.fnoIsuptntp = query.GetFieldData(block.GetBlockName(), "fnoIsuptntp").FirstOrDefault(); // char 1
				block.bnstp = query.GetFieldData(block.GetBlockName(), "bnstp").FirstOrDefault(); // char 1
				block.mrctp = query.GetFieldData(block.GetBlockName(), "mrctp").FirstOrDefault(); // char 1
				block.ordqty = query.GetFieldData(block.GetBlockName(), "ordqty").ParseLong("ordqty"); // long 16
				block.hogatype = query.GetFieldData(block.GetBlockName(), "hogatype").TrimEnd('?'); // char 2
				block.mmgb = query.GetFieldData(block.GetBlockName(), "mmgb").TrimEnd('?'); // char 2
				block.ordprc = query.GetFieldData(block.GetBlockName(), "ordprc").ParseDouble("ordprc"); // double 13.2
				block.unercqty = query.GetFieldData(block.GetBlockName(), "unercqty").ParseLong("unercqty"); // long 16
				block.commdacode = query.GetFieldData(block.GetBlockName(), "commdacode").TrimEnd('?'); // char 2
				block.peeamtcode = query.GetFieldData(block.GetBlockName(), "peeamtcode").TrimEnd('?'); // char 2
				block.mgempno = query.GetFieldData(block.GetBlockName(), "mgempno").TrimEnd('?'); // char 9
				block.fnotrdunitamt = query.GetFieldData(block.GetBlockName(), "fnotrdunitamt").ParseDouble("fnotrdunitamt"); // double 19.8
				block.trxtime = query.GetFieldData(block.GetBlockName(), "trxtime").TrimEnd('?'); // char 9
				block.strtgcode = query.GetFieldData(block.GetBlockName(), "strtgcode").TrimEnd('?'); // char 6
				block.grpId = query.GetFieldData(block.GetBlockName(), "grpId").TrimEnd('?'); // char 20
				block.ordseqno = query.GetFieldData(block.GetBlockName(), "ordseqno").TrimEnd('?'); // char 10
				block.ptflno = query.GetFieldData(block.GetBlockName(), "ptflno").TrimEnd('?'); // char 10
				block.bskno = query.GetFieldData(block.GetBlockName(), "bskno").TrimEnd('?'); // char 10
				block.trchno = query.GetFieldData(block.GetBlockName(), "trchno").TrimEnd('?'); // char 10
				block.Itemno = query.GetFieldData(block.GetBlockName(), "Itemno").TrimEnd('?'); // char 10
				block.OrderID = query.GetFieldData(block.GetBlockName(), "OrderID").TrimEnd('?'); // char 16
				block.opdrtnno = query.GetFieldData(block.GetBlockName(), "opdrtnno").TrimEnd('?'); // char 12
				block.rjtcode = query.GetFieldData(block.GetBlockName(), "rjtcode").TrimEnd('?'); // char 4
				block.mrccnfqty = query.GetFieldData(block.GetBlockName(), "mrccnfqty").ParseLong("mrccnfqty"); // long 16
				block.orgordunercqty = query.GetFieldData(block.GetBlockName(), "orgordunercqty").ParseLong("orgordunercqty"); // long 16
				block.orgordmrcqty = query.GetFieldData(block.GetBlockName(), "orgordmrcqty").ParseLong("orgordmrcqty"); // long 16
				block.ctrcttime = query.GetFieldData(block.GetBlockName(), "ctrcttime").TrimEnd('?'); // char 8
				block.ctrctno = query.GetFieldData(block.GetBlockName(), "ctrctno").TrimEnd('?'); // char 10
				block.execprc = query.GetFieldData(block.GetBlockName(), "execprc").ParseDouble("execprc"); // double 13.2
				block.execqty = query.GetFieldData(block.GetBlockName(), "execqty").ParseLong("execqty"); // long 16
				block.newqty = query.GetFieldData(block.GetBlockName(), "newqty").ParseLong("newqty"); // long 16
				block.qdtqty = query.GetFieldData(block.GetBlockName(), "qdtqty").ParseLong("qdtqty"); // long 16
				block.lastqty = query.GetFieldData(block.GetBlockName(), "lastqty").ParseLong("lastqty"); // long 16
				block.lallexecqty = query.GetFieldData(block.GetBlockName(), "lallexecqty").ParseLong("lallexecqty"); // long 16
				block.allexecamt = query.GetFieldData(block.GetBlockName(), "allexecamt").ParseLong("allexecamt"); // long 16
				block.fnobalevaltp = query.GetFieldData(block.GetBlockName(), "fnobalevaltp").FirstOrDefault(); // char 1
				block.bnsplamt = query.GetFieldData(block.GetBlockName(), "bnsplamt").ParseLong("bnsplamt"); // long 16
				block.fnoIsuno1 = query.GetFieldData(block.GetBlockName(), "fnoIsuno1").TrimEnd('?'); // char 8
				block.bnstp1 = query.GetFieldData(block.GetBlockName(), "bnstp1").FirstOrDefault(); // char 1
				block.execprc1 = query.GetFieldData(block.GetBlockName(), "execprc1").ParseDouble("execprc1"); // double 13.2
				block.newqty1 = query.GetFieldData(block.GetBlockName(), "newqty1").ParseLong("newqty1"); // long 16
				block.qdtqty1 = query.GetFieldData(block.GetBlockName(), "qdtqty1").ParseLong("qdtqty1"); // long 16
				block.allexecamt1 = query.GetFieldData(block.GetBlockName(), "allexecamt1").ParseLong("allexecamt1"); // long 16
				block.fnoIsuno2 = query.GetFieldData(block.GetBlockName(), "fnoIsuno2").TrimEnd('?'); // char 8
				block.bnstp2 = query.GetFieldData(block.GetBlockName(), "bnstp2").FirstOrDefault(); // char 1
				block.execprc2 = query.GetFieldData(block.GetBlockName(), "execprc2").ParseDouble("execprc2"); // double 13.2
				block.newqty2 = query.GetFieldData(block.GetBlockName(), "newqty2").ParseLong("newqty2"); // long 16
				block.lqdtqty2 = query.GetFieldData(block.GetBlockName(), "lqdtqty2").ParseLong("lqdtqty2"); // long 16
				block.allexecamt2 = query.GetFieldData(block.GetBlockName(), "allexecamt2").ParseLong("allexecamt2"); // long 16
				block.dps = query.GetFieldData(block.GetBlockName(), "dps").ParseLong("dps"); // long 16
				block.ftsubtdsgnamt = query.GetFieldData(block.GetBlockName(), "ftsubtdsgnamt").ParseLong("ftsubtdsgnamt"); // long 16
				block.mgn = query.GetFieldData(block.GetBlockName(), "mgn").ParseLong("mgn"); // long 16
				block.mnymgn = query.GetFieldData(block.GetBlockName(), "mnymgn").ParseLong("mnymgn"); // long 16
				block.ordableamt = query.GetFieldData(block.GetBlockName(), "ordableamt").ParseLong("ordableamt"); // long 16
				block.mnyordableamt = query.GetFieldData(block.GetBlockName(), "mnyordableamt").ParseLong("mnyordableamt"); // long 16
				block.fnoIsuno_1 = query.GetFieldData(block.GetBlockName(), "fnoIsuno_1").TrimEnd('?'); // char 8
				block.bnstp_1 = query.GetFieldData(block.GetBlockName(), "bnstp_1").FirstOrDefault(); // char 1
				block.unsttqty_1 = query.GetFieldData(block.GetBlockName(), "unsttqty_1").ParseLong("unsttqty_1"); // long 16
				block.lqdtableqty_1 = query.GetFieldData(block.GetBlockName(), "lqdtableqty_1").ParseLong("lqdtableqty_1"); // long 16
				block.avrprc_1 = query.GetFieldData(block.GetBlockName(), "avrprc_1").ParseDouble("avrprc_1"); // double 13.2
				block.fnoIsuno_2 = query.GetFieldData(block.GetBlockName(), "fnoIsuno_2").TrimEnd('?'); // char 8
				block.bnstp_2 = query.GetFieldData(block.GetBlockName(), "bnstp_2").FirstOrDefault(); // char 1
				block.unsttqty_2 = query.GetFieldData(block.GetBlockName(), "unsttqty_2").ParseLong("unsttqty_2"); // long 16
				block.lqdtableqty_2 = query.GetFieldData(block.GetBlockName(), "lqdtableqty_2").ParseLong("lqdtableqty_2"); // long 16
				block.avrprc_2 = query.GetFieldData(block.GetBlockName(), "avrprc_2").ParseDouble("avrprc_2"); // double 13.2

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (lineseq.ToString().Length > 10) return false; // long 10
			if (accno?.Length > 11) return false; // char 11
			if (user?.Length > 8) return false; // char 8
			if (len.ToString().Length > 6) return false; // long 6
			// gubun char 1
			// compress char 1
			// encrypt char 1
			if (offset.ToString().Length > 3) return false; // long 3
			if (trcode?.Length > 8) return false; // char 8
			if (compid?.Length > 3) return false; // char 3
			if (userid?.Length > 16) return false; // char 16
			if (media?.Length > 2) return false; // char 2
			if (ifid?.Length > 3) return false; // char 3
			if (seq?.Length > 9) return false; // char 9
			if (trid?.Length > 16) return false; // char 16
			if (pubip?.Length > 12) return false; // char 12
			if (prvip?.Length > 12) return false; // char 12
			if (pcbpno?.Length > 3) return false; // char 3
			if (bpno?.Length > 3) return false; // char 3
			if (termno?.Length > 8) return false; // char 8
			// lang char 1
			if (proctm.ToString().Length > 9) return false; // long 9
			if (msgcode?.Length > 4) return false; // char 4
			// outgu char 1
			// compreq char 1
			if (funckey?.Length > 4) return false; // char 4
			if (reqcnt.ToString().Length > 4) return false; // long 4
			if (filler?.Length > 6) return false; // char 6
			// cont char 1
			if (contkey?.Length > 18) return false; // char 18
			if (varlen.ToString().Length > 2) return false; // long 2
			if (varhdlen.ToString().Length > 2) return false; // long 2
			if (varmsglen.ToString().Length > 2) return false; // long 2
			// trsrc char 1
			if (eventid?.Length > 4) return false; // char 4
			if (ifinfo?.Length > 4) return false; // char 4
			if (filler1?.Length > 41) return false; // char 41
			if (trcode1?.Length > 4) return false; // char 4
			if (firmno?.Length > 3) return false; // char 3
			if (acntno?.Length > 11) return false; // char 11
			if (acntno1?.Length > 9) return false; // char 9
			if (acntnm?.Length > 40) return false; // char 40
			if (brnno?.Length > 3) return false; // char 3
			if (ordmktcode?.Length > 2) return false; // char 2
			if (ordno1?.Length > 3) return false; // char 3
			if (ordno.ToString().Length > 7) return false; // long 7
			if (orgordno1?.Length > 3) return false; // char 3
			if (orgordno.ToString().Length > 7) return false; // long 7
			if (prntordno?.Length > 3) return false; // char 3
			if (prntordno1.ToString().Length > 7) return false; // long 7
			if (isuno?.Length > 12) return false; // char 12
			if (fnoIsuno?.Length > 8) return false; // char 8
			if (fnoIsunm?.Length > 40) return false; // char 40
			if (pdgrpcode?.Length > 2) return false; // char 2
			// fnoIsuptntp char 1
			// bnstp char 1
			// mrctp char 1
			if (ordqty.ToString().Length > 16) return false; // long 16
			if (hogatype?.Length > 2) return false; // char 2
			if (mmgb?.Length > 2) return false; // char 2
			// ordprc double 13.2
			if (unercqty.ToString().Length > 16) return false; // long 16
			if (commdacode?.Length > 2) return false; // char 2
			if (peeamtcode?.Length > 2) return false; // char 2
			if (mgempno?.Length > 9) return false; // char 9
			// fnotrdunitamt double 19.8
			if (trxtime?.Length > 9) return false; // char 9
			if (strtgcode?.Length > 6) return false; // char 6
			if (grpId?.Length > 20) return false; // char 20
			if (ordseqno?.Length > 10) return false; // char 10
			if (ptflno?.Length > 10) return false; // char 10
			if (bskno?.Length > 10) return false; // char 10
			if (trchno?.Length > 10) return false; // char 10
			if (Itemno?.Length > 10) return false; // char 10
			if (OrderID?.Length > 16) return false; // char 16
			if (opdrtnno?.Length > 12) return false; // char 12
			if (rjtcode?.Length > 4) return false; // char 4
			if (mrccnfqty.ToString().Length > 16) return false; // long 16
			if (orgordunercqty.ToString().Length > 16) return false; // long 16
			if (orgordmrcqty.ToString().Length > 16) return false; // long 16
			if (ctrcttime?.Length > 8) return false; // char 8
			if (ctrctno?.Length > 10) return false; // char 10
			// execprc double 13.2
			if (execqty.ToString().Length > 16) return false; // long 16
			if (newqty.ToString().Length > 16) return false; // long 16
			if (qdtqty.ToString().Length > 16) return false; // long 16
			if (lastqty.ToString().Length > 16) return false; // long 16
			if (lallexecqty.ToString().Length > 16) return false; // long 16
			if (allexecamt.ToString().Length > 16) return false; // long 16
			// fnobalevaltp char 1
			if (bnsplamt.ToString().Length > 16) return false; // long 16
			if (fnoIsuno1?.Length > 8) return false; // char 8
			// bnstp1 char 1
			// execprc1 double 13.2
			if (newqty1.ToString().Length > 16) return false; // long 16
			if (qdtqty1.ToString().Length > 16) return false; // long 16
			if (allexecamt1.ToString().Length > 16) return false; // long 16
			if (fnoIsuno2?.Length > 8) return false; // char 8
			// bnstp2 char 1
			// execprc2 double 13.2
			if (newqty2.ToString().Length > 16) return false; // long 16
			if (lqdtqty2.ToString().Length > 16) return false; // long 16
			if (allexecamt2.ToString().Length > 16) return false; // long 16
			if (dps.ToString().Length > 16) return false; // long 16
			if (ftsubtdsgnamt.ToString().Length > 16) return false; // long 16
			if (mgn.ToString().Length > 16) return false; // long 16
			if (mnymgn.ToString().Length > 16) return false; // long 16
			if (ordableamt.ToString().Length > 16) return false; // long 16
			if (mnyordableamt.ToString().Length > 16) return false; // long 16
			if (fnoIsuno_1?.Length > 8) return false; // char 8
			// bnstp_1 char 1
			if (unsttqty_1.ToString().Length > 16) return false; // long 16
			if (lqdtableqty_1.ToString().Length > 16) return false; // long 16
			// avrprc_1 double 13.2
			if (fnoIsuno_2?.Length > 8) return false; // char 8
			// bnstp_2 char 1
			if (unsttqty_2.ToString().Length > 16) return false; // long 16
			if (lqdtableqty_2.ToString().Length > 16) return false; // long 16
			// avrprc_2 double 13.2

			return true;
		}
	}

	/// <summary>
	/// EUX체결
	/// </summary>
	public partial class XREU1 : XingReal
	{
		/// <summary>
		/// EU1
		/// </summary>
		public const string _typeName = "EU1";
		/// <summary>
		/// EUX체결
		/// </summary>
		public const string _typeDesc = "EUX체결";
		/// <summary>
		/// false
		/// </summary>
		public const bool _attr = false;
		/// <summary>
		/// 0
		/// </summary>
		public const int _key = 0;
		/// <summary>
		/// 0
		/// </summary>
		public const int _group = 0;

		/// <summary>
		/// EU1
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// EUX체결
		/// </summary>
		public string TypeDesc => _typeDesc;
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

		/// <summary>
		/// EUX체결
		/// </summary>
		public XREU1() : base("EU1") { }


		public bool SetBlock(XREU1InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}


			return true;
		}

		public XREU1OutBlock GetBlock()
		{
			XREU1OutBlock instance = XREU1OutBlock.FromQuery(this);
			return instance;

		}


	}

}
