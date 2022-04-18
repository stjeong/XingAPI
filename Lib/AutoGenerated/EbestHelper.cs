using System;
using XingAPINet;

public static class XingTypeList
{
	/// <summary>
	/// ETF호가잔량(B7)
	/// </summary>
	public const string B7_ = "B7_";
	/// <summary>
	/// 시간대별투자자매매추이(BMT)
	/// </summary>
	public const string BMT = "BMT";
	/// <summary>
	/// 업종별투자자별매매현황(BM)
	/// </summary>
	public const string BM_ = "BM_";
	/// <summary>
	/// 선물주문체결
	/// </summary>
	public const string C01 = "C01";
	/// <summary>
	/// 선물옵션 CME 매매거래현황
	/// </summary>
	public const string CCEAQ01100 = "CCEAQ01100";
	/// <summary>
	/// 선물옵션 CME 주문체결내역조회
	/// </summary>
	public const string CCEAQ06000 = "CCEAQ06000";
	/// <summary>
	/// 선물옵션 CME 주문가능 수량/금액 조회
	/// </summary>
	public const string CCEAQ10100 = "CCEAQ10100";
	/// <summary>
	/// 선물옵션 CME 계좌잔고 및 평가현황
	/// </summary>
	public const string CCEAQ50600 = "CCEAQ50600";
	/// <summary>
	/// CME 정상주문
	/// </summary>
	public const string CCEAT00100 = "CCEAT00100";
	/// <summary>
	/// CME 정정주문
	/// </summary>
	public const string CCEAT00200 = "CCEAT00200";
	/// <summary>
	/// CME 취소주문
	/// </summary>
	public const string CCEAT00300 = "CCEAT00300";
	/// <summary>
	/// 선물옵션 CME 예탁금증거금조회
	/// </summary>
	public const string CCEBQ10500 = "CCEBQ10500";
	/// <summary>
	/// 상품선물실시간상하한가(D0)
	/// </summary>
	public const string CD0 = "CD0";
	/// <summary>
	/// 계좌 거래내역
	/// </summary>
	public const string CDPCQ04700 = "CDPCQ04700";
	/// <summary>
	/// 유렉스 주문체결내역조회
	/// </summary>
	public const string CEXAQ21100 = "CEXAQ21100";
	/// <summary>
	/// 유렉스 주문가능 수량/금액 조회
	/// </summary>
	public const string CEXAQ21200 = "CEXAQ21200";
	/// <summary>
	/// 유렉스 야간장잔고및 평가현황
	/// </summary>
	public const string CEXAQ31100 = "CEXAQ31100";
	/// <summary>
	/// 유렉스 예탁금 및 통합잔고조회
	/// </summary>
	public const string CEXAQ31200 = "CEXAQ31200";
	/// <summary>
	/// EUREX 야간옵션 기간주문체결조회
	/// </summary>
	public const string CEXAQ44200 = "CEXAQ44200";
	/// <summary>
	/// 유렉스 매수/매도주문
	/// </summary>
	public const string CEXAT11100 = "CEXAT11100";
	/// <summary>
	/// 유렉스 정정주문
	/// </summary>
	public const string CEXAT11200 = "CEXAT11200";
	/// <summary>
	/// 유렉스 취소주문
	/// </summary>
	public const string CEXAT11300 = "CEXAT11300";
	/// <summary>
	/// 선물옵션 계좌주문체결내역조회
	/// </summary>
	public const string CFOAQ00600 = "CFOAQ00600";
	/// <summary>
	/// 선물옵션 주문가능수량조회
	/// </summary>
	public const string CFOAQ10100 = "CFOAQ10100";
	/// <summary>
	/// 선물옵션 정상주문
	/// </summary>
	public const string CFOAT00100 = "CFOAT00100";
	/// <summary>
	/// 선물옵션 정정주문
	/// </summary>
	public const string CFOAT00200 = "CFOAT00200";
	/// <summary>
	/// 선물옵션 취소주문
	/// </summary>
	public const string CFOAT00300 = "CFOAT00300";
	/// <summary>
	/// 선물옵션 계좌예탁금증거금조회
	/// </summary>
	public const string CFOBQ10500 = "CFOBQ10500";
	/// <summary>
	/// 선물옵션 옵션매도시 주문증거금조회
	/// </summary>
	public const string CFOBQ10800 = "CFOBQ10800";
	/// <summary>
	/// 선물옵션가정산예탁금상세
	/// </summary>
	public const string CFOEQ11100 = "CFOEQ11100";
	/// <summary>
	/// 선물옵션 일별 계좌손익내역
	/// </summary>
	public const string CFOEQ82600 = "CFOEQ82600";
	/// <summary>
	/// 계좌 미결제 약정현황(평균가)
	/// </summary>
	public const string CFOFQ02400 = "CFOFQ02400";
	/// <summary>
	/// 챠트엑셀데이터조회
	/// </summary>
	public const string CHARTEXCEL = "CHARTEXCEL";
	/// <summary>
	/// 챠트지표데이터조회
	/// </summary>
	public const string CHARTINDEX = "CHARTINDEX";
	/// <summary>
	/// 예탁담보융자가능종목현황조회
	/// </summary>
	public const string CLNAQ00100 = "CLNAQ00100";
	/// <summary>
	/// CME접수
	/// </summary>
	public const string CM0 = "CM0";
	/// <summary>
	/// CME체결
	/// </summary>
	public const string CM1 = "CM1";
	/// <summary>
	/// CME확인
	/// </summary>
	public const string CM2 = "CM2";
	/// <summary>
	/// 계좌별신용한도조회
	/// </summary>
	public const string CSPAQ00600 = "CSPAQ00600";
	/// <summary>
	/// 현물계좌예수금 주문가능금액 총평가 조회
	/// </summary>
	public const string CSPAQ12200 = "CSPAQ12200";
	/// <summary>
	/// BEP단가조회
	/// </summary>
	public const string CSPAQ12300 = "CSPAQ12300";
	/// <summary>
	/// 현물계좌주문체결내역조회
	/// </summary>
	public const string CSPAQ13700 = "CSPAQ13700";
	/// <summary>
	/// 현물계좌예수금 주문가능금액 총평가2
	/// </summary>
	public const string CSPAQ22200 = "CSPAQ22200";
	/// <summary>
	/// 현물주문
	/// </summary>
	public const string CSPAT00600 = "CSPAT00600";
	/// <summary>
	/// 현물정정주문
	/// </summary>
	public const string CSPAT00700 = "CSPAT00700";
	/// <summary>
	/// 현물취소주문
	/// </summary>
	public const string CSPAT00800 = "CSPAT00800";
	/// <summary>
	/// 현물계좌증거금률별주문가능수량조회
	/// </summary>
	public const string CSPBQ00200 = "CSPBQ00200";
	/// <summary>
	/// 현물정보 USD 실시간(CUR)
	/// </summary>
	public const string CUR = "CUR";
	/// <summary>
	/// KOSPI시간외단일가호가잔량(DH1)
	/// </summary>
	public const string DH1 = "DH1";
	/// <summary>
	/// KOSDAQ시간외단일가호가잔량(DHA)
	/// </summary>
	public const string DHA = "DHA";
	/// <summary>
	/// KOSDAQ시간외단일가체결(DK3)
	/// </summary>
	public const string DK3 = "DK3";
	/// <summary>
	/// KOSPI시간외단일가체결(DS3)
	/// </summary>
	public const string DS3 = "DS3";
	/// <summary>
	/// 시간외단일가VI발동해제(DVI)
	/// </summary>
	public const string DVI = "DVI";
	/// <summary>
	/// EUREX연계KP200지수옵션선물체결(EC0)
	/// </summary>
	public const string EC0 = "EC0";
	/// <summary>
	/// EUREX연계KP200지수옵션선물호가(EH0)
	/// </summary>
	public const string EH0 = "EH0";
	/// <summary>
	/// 뉴ELW투자지표민감도(ESN)
	/// </summary>
	public const string ESN = "ESN";
	/// <summary>
	/// EUX접수
	/// </summary>
	public const string EU0 = "EU0";
	/// <summary>
	/// EUX체결
	/// </summary>
	public const string EU1 = "EU1";
	/// <summary>
	/// EUX확인
	/// </summary>
	public const string EU2 = "EU2";
	/// <summary>
	/// KOSPI200선물체결(C0)
	/// </summary>
	public const string FC0 = "FC0";
	/// <summary>
	/// KOSPI200선물실시간상하한가(D0)
	/// </summary>
	public const string FD0 = "FD0";
	/// <summary>
	/// KOSPI200선물호가(H0)
	/// </summary>
	public const string FH0 = "FH0";
	/// <summary>
	/// 주식계좌 기간별수익률 상세
	/// </summary>
	public const string FOCCQ33600 = "FOCCQ33600";
	/// <summary>
	/// 선물옵션 기간별 계좌 수익률 현황
	/// </summary>
	public const string FOCCQ33700 = "FOCCQ33700";
	/// <summary>
	/// KOSPI200선물가격제한폭확대(X0)
	/// </summary>
	public const string FX0 = "FX0";
	/// <summary>
	/// 선물주문정정취소
	/// </summary>
	public const string H01 = "H01";
	/// <summary>
	/// KOSPI호가잔량(H1)
	/// </summary>
	public const string H1_ = "H1_";
	/// <summary>
	/// KOSPI장전시간외호가잔량(H2)
	/// </summary>
	public const string H2_ = "H2_";
	/// <summary>
	/// ELW장전시간외호가잔량(h2)
	/// </summary>
	public const string h2_ = "h2_";
	/// <summary>
	/// ELW호가잔량(h3)
	/// </summary>
	public const string h3_ = "h3_";
	/// <summary>
	/// KOSDAQ호가잔량(HA)
	/// </summary>
	public const string HA_ = "HA_";
	/// <summary>
	/// KOSDAQ장전시간외호가잔량(HB)
	/// </summary>
	public const string HB_ = "HB_";
	/// <summary>
	/// 코스피ETF종목실시간NAV(I5)
	/// </summary>
	public const string I5_ = "I5_";
	/// <summary>
	/// 지수(IJ)
	/// </summary>
	public const string IJ_ = "IJ_";
	/// <summary>
	/// 주식선물체결(JC0)
	/// </summary>
	public const string JC0 = "JC0";
	/// <summary>
	/// 주식선물실시간상하한가(JD0)
	/// </summary>
	public const string JD0 = "JD0";
	/// <summary>
	/// 주식선물호가(JH0)
	/// </summary>
	public const string JH0 = "JH0";
	/// <summary>
	/// 장운영정보(JIF)
	/// </summary>
	public const string JIF = "JIF";
	/// <summary>
	/// 주식선물가격제한폭확대(JX0)
	/// </summary>
	public const string JX0 = "JX0";
	/// <summary>
	/// KOSPI거래원(K1)
	/// </summary>
	public const string K1_ = "K1_";
	/// <summary>
	/// ELW거래원(k1)
	/// </summary>
	public const string k1_ = "k1_";
	/// <summary>
	/// KOSDAQ체결(K3)
	/// </summary>
	public const string K3_ = "K3_";
	/// <summary>
	/// KOSDAQ프로그램매매종목별(KH)
	/// </summary>
	public const string KH_ = "KH_";
	/// <summary>
	/// KOSDAQ프로그램매매전체집계(KM)
	/// </summary>
	public const string KM_ = "KM_";
	/// <summary>
	/// KOSDAQ우선호가(KS)
	/// </summary>
	public const string KS_ = "KS_";
	/// <summary>
	/// US지수(MK2)
	/// </summary>
	public const string MK2 = "MK2";
	/// <summary>
	/// 파생상품증거금율조회
	/// </summary>
	public const string MMDAQ91200 = "MMDAQ91200";
	/// <summary>
	/// CME연계KP200지수선물체결(NC0)
	/// </summary>
	public const string NC0 = "NC0";
	/// <summary>
	/// CME연계KP200지수선물호가(NH0)
	/// </summary>
	public const string NH0 = "NH0";
	/// <summary>
	/// 실시간 뉴스 제목 패킷(NWS)
	/// </summary>
	public const string NWS = "NWS";
	/// <summary>
	/// 선물접수
	/// </summary>
	public const string O01 = "O01";
	/// <summary>
	/// KOSPI200옵션체결(C0)
	/// </summary>
	public const string OC0 = "OC0";
	/// <summary>
	/// KOSPI200옵션실시간상하한가(D0)
	/// </summary>
	public const string OD0 = "OD0";
	/// <summary>
	/// KOSPI200옵션호가(H0)
	/// </summary>
	public const string OH0 = "OH0";
	/// <summary>
	/// KOSDAQ거래원(OK)
	/// </summary>
	public const string OK_ = "OK_";
	/// <summary>
	/// KOSPI200옵션민감도(MG)
	/// </summary>
	public const string OMG = "OMG";
	/// <summary>
	/// KOSPI200옵션가격제한폭확대(X0)
	/// </summary>
	public const string OX0 = "OX0";
	/// <summary>
	/// KOSPI프로그램매매종목별(PH)
	/// </summary>
	public const string PH_ = "PH_";
	/// <summary>
	/// KOSPI프로그램매매전체집계(PM)
	/// </summary>
	public const string PM_ = "PM_";
	/// <summary>
	/// KOSPI우선호가(S2)
	/// </summary>
	public const string S2_ = "S2_";
	/// <summary>
	/// ELW우선호가(s2)
	/// </summary>
	public const string s2_ = "s2_";
	/// <summary>
	/// KOSPI체결(S3)
	/// </summary>
	public const string S3_ = "S3_";
	/// <summary>
	/// ELW체결(s3)
	/// </summary>
	public const string s3_ = "s3_";
	/// <summary>
	/// KOSPI기세(S4)
	/// </summary>
	public const string S4_ = "S4_";
	/// <summary>
	/// ELW기세(s4)
	/// </summary>
	public const string s4_ = "s4_";
	/// <summary>
	/// 주식주문접수
	/// </summary>
	public const string SC0 = "SC0";
	/// <summary>
	/// 주식주문체결
	/// </summary>
	public const string SC1 = "SC1";
	/// <summary>
	/// 주식주문정정
	/// </summary>
	public const string SC2 = "SC2";
	/// <summary>
	/// 주식주문취소
	/// </summary>
	public const string SC3 = "SC3";
	/// <summary>
	/// 주식주문거부
	/// </summary>
	public const string SC4 = "SC4";
	/// <summary>
	/// 상/하한가근접진입(SHC)
	/// </summary>
	public const string SHC = "SHC";
	/// <summary>
	/// 상/하한가근접이탈(SHD)
	/// </summary>
	public const string SHD = "SHD";
	/// <summary>
	/// 상/하한가진입(SHI)
	/// </summary>
	public const string SHI = "SHI";
	/// <summary>
	/// 상/하한가이탈(SHO)
	/// </summary>
	public const string SHO = "SHO";
	/// <summary>
	/// 주식당일매매일지/수수료(t0150)
	/// </summary>
	public const string t0150 = "t0150";
	/// <summary>
	/// 주식당일매매일지/수수료(전일)(t0151)
	/// </summary>
	public const string t0151 = "t0151";
	/// <summary>
	/// 서버시간조회(t0167)
	/// </summary>
	public const string t0167 = "t0167";
	/// <summary>
	/// 주식잔고2(t0424)
	/// </summary>
	public const string t0424 = "t0424";
	/// <summary>
	/// 주식체결/미체결(t0425)
	/// </summary>
	public const string t0425 = "t0425";
	/// <summary>
	/// 선물/옵션체결/미체결(t0434)
	/// </summary>
	public const string t0434 = "t0434";
	/// <summary>
	/// 선물/옵션잔고평가(이동평균)(t0441)
	/// </summary>
	public const string t0441 = "t0441";
	/// <summary>
	/// 주식현재가호가조회(t1101)
	/// </summary>
	public const string t1101 = "t1101";
	/// <summary>
	/// 주식현재가(시세)조회(t1102)
	/// </summary>
	public const string t1102 = "t1102";
	/// <summary>
	/// 주식현재가시세메모(t1104)
	/// </summary>
	public const string t1104 = "t1104";
	/// <summary>
	/// 주식피못/디마크조회(t1105)
	/// </summary>
	public const string t1105 = "t1105";
	/// <summary>
	/// 주식시간대별체결조회(t1301)
	/// </summary>
	public const string t1301 = "t1301";
	/// <summary>
	/// 주식분별주가조회(t1302)
	/// </summary>
	public const string t1302 = "t1302";
	/// <summary>
	/// 기간별주가(t1305)
	/// </summary>
	public const string t1305 = "t1305";
	/// <summary>
	/// 주식시간대별체결조회챠트(t1308)
	/// </summary>
	public const string t1308 = "t1308";
	/// <summary>
	/// 주식당일전일분틱조회(t1310)
	/// </summary>
	public const string t1310 = "t1310";
	/// <summary>
	/// 신규상장종목조회(t1403)
	/// </summary>
	public const string t1403 = "t1403";
	/// <summary>
	/// 관리/불성실/투자유의조회(t1404)
	/// </summary>
	public const string t1404 = "t1404";
	/// <summary>
	/// 투자경고/매매정지/정리매매조회(t1405)
	/// </summary>
	public const string t1405 = "t1405";
	/// <summary>
	/// 초저유동성조회(t1410)
	/// </summary>
	public const string t1410 = "t1410";
	/// <summary>
	/// 증거금율별종목조회(t1411)
	/// </summary>
	public const string t1411 = "t1411";
	/// <summary>
	/// 상/하한(t1422)
	/// </summary>
	public const string t1422 = "t1422";
	/// <summary>
	/// 상/하한가직전(t1427)
	/// </summary>
	public const string t1427 = "t1427";
	/// <summary>
	/// 신고/신저가(t1442)
	/// </summary>
	public const string t1442 = "t1442";
	/// <summary>
	/// 시가총액상위(t1444)
	/// </summary>
	public const string t1444 = "t1444";
	/// <summary>
	/// 가격대별매매비중조회(t1449)
	/// </summary>
	public const string t1449 = "t1449";
	/// <summary>
	/// 거래량상위(t1452)
	/// </summary>
	public const string t1452 = "t1452";
	/// <summary>
	/// 거래대금상위(t1463)
	/// </summary>
	public const string t1463 = "t1463";
	/// <summary>
	/// 시간대별호가잔량추이(t1471)
	/// </summary>
	public const string t1471 = "t1471";
	/// <summary>
	/// 체결강도추이(t1475)
	/// </summary>
	public const string t1475 = "t1475";
	/// <summary>
	/// 예상지수(t1485)
	/// </summary>
	public const string t1485 = "t1485";
	/// <summary>
	/// 시간별예상체결가(t1486)
	/// </summary>
	public const string t1486 = "t1486";
	/// <summary>
	/// 예상체결가등락율상위조회(t1488)
	/// </summary>
	public const string t1488 = "t1488";
	/// <summary>
	/// 예상체결량상위조회(t1489)
	/// </summary>
	public const string t1489 = "t1489";
	/// <summary>
	/// 업종현재가(t1511)
	/// </summary>
	public const string t1511 = "t1511";
	/// <summary>
	/// 업종기간별추이(t1514)
	/// </summary>
	public const string t1514 = "t1514";
	/// <summary>
	/// 업종별종목시세(t1516)
	/// </summary>
	public const string t1516 = "t1516";
	/// <summary>
	/// 테마별종목(t1531)
	/// </summary>
	public const string t1531 = "t1531";
	/// <summary>
	/// 종목별테마(t1532)
	/// </summary>
	public const string t1532 = "t1532";
	/// <summary>
	/// 특이테마(t1533)
	/// </summary>
	public const string t1533 = "t1533";
	/// <summary>
	/// 테마종목별시세조회(t1537)
	/// </summary>
	public const string t1537 = "t1537";
	/// <summary>
	/// 투자자별종합(t1601)
	/// </summary>
	public const string t1601 = "t1601";
	/// <summary>
	/// 시간대별투자자매매추이(t1602)
	/// </summary>
	public const string t1602 = "t1602";
	/// <summary>
	/// 시간대별투자자매매추이상세(t1603)
	/// </summary>
	public const string t1603 = "t1603";
	/// <summary>
	/// 투자자매매종합1(t1615)
	/// </summary>
	public const string t1615 = "t1615";
	/// <summary>
	/// 투자자매매종합2(t1617)
	/// </summary>
	public const string t1617 = "t1617";
	/// <summary>
	/// 업종별분별투자자매매동향(챠트용)
	/// </summary>
	public const string t1621 = "t1621";
	/// <summary>
	/// 프로그램매매종합조회(t1631)
	/// </summary>
	public const string t1631 = "t1631";
	/// <summary>
	/// 시간대별프로그램매매추이(t1632)
	/// </summary>
	public const string t1632 = "t1632";
	/// <summary>
	/// 기간별프로그램매매추이(t1633)
	/// </summary>
	public const string t1633 = "t1633";
	/// <summary>
	/// 종목별프로그램매매동향(t1636)
	/// </summary>
	public const string t1636 = "t1636";
	/// <summary>
	/// 종목별프로그램매매추이(t1637)
	/// </summary>
	public const string t1637 = "t1637";
	/// <summary>
	/// 종목별잔량/사전공시(t1638)
	/// </summary>
	public const string t1638 = "t1638";
	/// <summary>
	/// 프로그램매매종합조회(미니)(t1640)
	/// </summary>
	public const string t1640 = "t1640";
	/// <summary>
	/// 시간대별프로그램매매추이(차트)(t1662)
	/// </summary>
	public const string t1662 = "t1662";
	/// <summary>
	/// 투자자매매종합(챠트)
	/// </summary>
	public const string t1664 = "t1664";
	/// <summary>
	/// 기간별투자자매매추이(챠트)
	/// </summary>
	public const string t1665 = "t1665";
	/// <summary>
	/// 외인기관종목별동향(t1701)
	/// </summary>
	public const string t1701 = "t1701";
	/// <summary>
	/// 외인기관종목별동향(t1702)
	/// </summary>
	public const string t1702 = "t1702";
	/// <summary>
	/// 외인기관종목별동향(t1717)
	/// </summary>
	public const string t1717 = "t1717";
	/// <summary>
	/// 종목별상위회원사(t1752)
	/// </summary>
	public const string t1752 = "t1752";
	/// <summary>
	/// 회원사리스트(t1764)
	/// </summary>
	public const string t1764 = "t1764";
	/// <summary>
	/// 종목별회원사추이(t1771)
	/// </summary>
	public const string t1771 = "t1771";
	/// <summary>
	/// 신호조회(t1809)
	/// </summary>
	public const string t1809 = "t1809";
	/// <summary>
	/// 종목Q클릭검색(씽큐스마트)(t1825)
	/// </summary>
	public const string t1825 = "t1825";
	/// <summary>
	/// 종목Q클릭검색리스트조회(씽큐스마트)(t1826)
	/// </summary>
	public const string t1826 = "t1826";
	/// <summary>
	/// e종목검색(신버전API용)
	/// </summary>
	public const string t1857 = "t1857";
	/// <summary>
	/// 서버저장조건리스트조회(API)(t1866)
	/// </summary>
	public const string t1866 = "t1866";
	/// <summary>
	/// ETF현재가(시세)조회(t1901)
	/// </summary>
	public const string t1901 = "t1901";
	/// <summary>
	/// ETF시간별추이(t1902)
	/// </summary>
	public const string t1902 = "t1902";
	/// <summary>
	/// ETF일별추이(t1903)
	/// </summary>
	public const string t1903 = "t1903";
	/// <summary>
	/// ETF구성종목조회(t1904)
	/// </summary>
	public const string t1904 = "t1904";
	/// <summary>
	/// ETFLP호가(t1906)
	/// </summary>
	public const string t1906 = "t1906";
	/// <summary>
	/// 신용거래동향(t1921)
	/// </summary>
	public const string t1921 = "t1921";
	/// <summary>
	/// 종목별신용정보(t1926)
	/// </summary>
	public const string t1926 = "t1926";
	/// <summary>
	/// 공매도일별추이(t1927)
	/// </summary>
	public const string t1927 = "t1927";
	/// <summary>
	/// 종목별대차거래일간추이(t1941)
	/// </summary>
	public const string t1941 = "t1941";
	/// <summary>
	/// ELW현재가(시세)조회(t1950)
	/// </summary>
	public const string t1950 = "t1950";
	/// <summary>
	/// ELW시간대별체결조회(t1951)
	/// </summary>
	public const string t1951 = "t1951";
	/// <summary>
	/// ELW일별주가(t1954)
	/// </summary>
	public const string t1954 = "t1954";
	/// <summary>
	/// ELW지표검색(t1955)
	/// </summary>
	public const string t1955 = "t1955";
	/// <summary>
	/// ELW현재가(확정지급액)조회(t1956)
	/// </summary>
	public const string t1956 = "t1956";
	/// <summary>
	/// ELW종목비교(t1958)
	/// </summary>
	public const string t1958 = "t1958";
	/// <summary>
	/// LP대상종목정보조회(t1959)
	/// </summary>
	public const string t1959 = "t1959";
	/// <summary>
	/// ELW등락율상위(t1960)
	/// </summary>
	public const string t1960 = "t1960";
	/// <summary>
	/// ELW거래량상위(t1961)
	/// </summary>
	public const string t1961 = "t1961";
	/// <summary>
	/// ELW전광판(t1964)
	/// </summary>
	public const string t1964 = "t1964";
	/// <summary>
	/// ELW거래대금상위(t1966)
	/// </summary>
	public const string t1966 = "t1966";
	/// <summary>
	/// ELW현재가호가조회(t1971)
	/// </summary>
	public const string t1971 = "t1971";
	/// <summary>
	/// ELW현재가(거래원)조회(t1972)
	/// </summary>
	public const string t1972 = "t1972";
	/// <summary>
	/// ELW시간대별예상체결조회(t1973)
	/// </summary>
	public const string t1973 = "t1973";
	/// <summary>
	/// ELW기초자산동일종목(t1974)
	/// </summary>
	public const string t1974 = "t1974";
	/// <summary>
	/// 기초자산리스트조회(t1981)
	/// </summary>
	public const string t1981 = "t1981";
	/// <summary>
	/// 선물/옵션현재가(시세)조회(t2101)
	/// </summary>
	public const string t2101 = "t2101";
	/// <summary>
	/// 선물/옵션현재가호가조회(t2105)
	/// </summary>
	public const string t2105 = "t2105";
	/// <summary>
	/// 선물/옵션현재가시세메모(t2106)
	/// </summary>
	public const string t2106 = "t2106";
	/// <summary>
	/// 선물옵션시간대별체결조회(t2201)
	/// </summary>
	public const string t2201 = "t2201";
	/// <summary>
	/// 기간별주가(t2203)
	/// </summary>
	public const string t2203 = "t2203";
	/// <summary>
	/// 선물옵션틱분별체결조회챠트(t2209)
	/// </summary>
	public const string t2209 = "t2209";
	/// <summary>
	/// 선물옵션시간대별체결조회(단일출력용)
	/// </summary>
	public const string t2210 = "t2210";
	/// <summary>
	/// 옵션전광판(t2301)
	/// </summary>
	public const string t2301 = "t2301";
	/// <summary>
	/// 선물옵션호가잔량비율챠트(t2405)
	/// </summary>
	public const string t2405 = "t2405";
	/// <summary>
	/// 미결제약정추이(t2421)
	/// </summary>
	public const string t2421 = "t2421";
	/// <summary>
	/// 상품선물투자자매매동향(실시간)(t2541)
	/// </summary>
	public const string t2541 = "t2541";
	/// <summary>
	/// 상품선물투자자매매동향(챠트용)
	/// </summary>
	public const string t2545 = "t2545";
	/// <summary>
	/// CME야간선물현재가조회(t2801)
	/// </summary>
	public const string t2801 = "t2801";
	/// <summary>
	/// CME야간선물호가조회(t2802)
	/// </summary>
	public const string t2802 = "t2802";
	/// <summary>
	/// CME야간선물시간대별체결조회(t2804)
	/// </summary>
	public const string t2804 = "t2804";
	/// <summary>
	/// CME야간선물기간별주가(t2805)
	/// </summary>
	public const string t2805 = "t2805";
	/// <summary>
	/// CME야간선물시간대별투자자매매추이(t2813)
	/// </summary>
	public const string t2813 = "t2813";
	/// <summary>
	/// CME야간선물기간별투자자매매추이(챠트)
	/// </summary>
	public const string t2814 = "t2814";
	/// <summary>
	/// CME야간선물투자자별종합(t2816)
	/// </summary>
	public const string t2816 = "t2816";
	/// <summary>
	/// EUREXKOSPI200옵션선물현재가(시세)조회(t2830)
	/// </summary>
	public const string t2830 = "t2830";
	/// <summary>
	/// EUREXKOSPI200옵션선물호가조회(t2831)
	/// </summary>
	public const string t2831 = "t2831";
	/// <summary>
	/// EUREX야간옵션선물시간대별체결조회(t2832)
	/// </summary>
	public const string t2832 = "t2832";
	/// <summary>
	/// EUREX야간옵션선물기간별추이(t2833)
	/// </summary>
	public const string t2833 = "t2833";
	/// <summary>
	/// EUREX옵션선물시세전광판(t2835)
	/// </summary>
	public const string t2835 = "t2835";
	/// <summary>
	/// 뉴스본문(t3102)
	/// </summary>
	public const string t3102 = "t3102";
	/// <summary>
	/// 종목별증시일정(t3202)
	/// </summary>
	public const string t3202 = "t3202";
	/// <summary>
	/// FNG_요약(t3320)
	/// </summary>
	public const string t3320 = "t3320";
	/// <summary>
	/// 재무순위종합(t3341)
	/// </summary>
	public const string t3341 = "t3341";
	/// <summary>
	/// 투자의견(t3401)
	/// </summary>
	public const string t3401 = "t3401";
	/// <summary>
	/// 해외실시간지수(t3518)
	/// </summary>
	public const string t3518 = "t3518";
	/// <summary>
	/// 해외지수조회(API용)(t3521)
	/// </summary>
	public const string t3521 = "t3521";
	/// <summary>
	/// 주식챠트(종합)(t4201)
	/// </summary>
	public const string t4201 = "t4201";
	/// <summary>
	/// 업종챠트(종합)(t4203)
	/// </summary>
	public const string t4203 = "t4203";
	/// <summary>
	/// 주식선물마스터조회(API용)(t8401)
	/// </summary>
	public const string t8401 = "t8401";
	/// <summary>
	/// 주식선물현재가조회(API용)(t8402)
	/// </summary>
	public const string t8402 = "t8402";
	/// <summary>
	/// 주식선물호가조회(API용)(t8403)
	/// </summary>
	public const string t8403 = "t8403";
	/// <summary>
	/// 주식선물시간대별체결조회(API용)(t8404)
	/// </summary>
	public const string t8404 = "t8404";
	/// <summary>
	/// 주식선물기간별주가(API용)(t8405)
	/// </summary>
	public const string t8405 = "t8405";
	/// <summary>
	/// 주식선물틱분별체결조회(API용)(t8406)
	/// </summary>
	public const string t8406 = "t8406";
	/// <summary>
	/// API용주식멀티현재가조회(t8407)
	/// </summary>
	public const string t8407 = "t8407";
	/// <summary>
	/// CME야간선물틱분별체결조회(API용)(t8408)
	/// </summary>
	public const string t8408 = "t8408";
	/// <summary>
	/// CME야간선물미결제약정추이(API용)(t8409)
	/// </summary>
	public const string t8409 = "t8409";
	/// <summary>
	/// 주식챠트(틱/n틱)(t8411)
	/// </summary>
	public const string t8411 = "t8411";
	/// <summary>
	/// 주식챠트(N분)(t8412)
	/// </summary>
	public const string t8412 = "t8412";
	/// <summary>
	/// 주식챠트(일주월)(t8413)
	/// </summary>
	public const string t8413 = "t8413";
	/// <summary>
	/// 선물옵션차트(틱/n틱)(t8414)
	/// </summary>
	public const string t8414 = "t8414";
	/// <summary>
	/// 선물/옵션챠트(N분)(t8415)
	/// </summary>
	public const string t8415 = "t8415";
	/// <summary>
	/// 선물/옵션챠트(일주월)(t8416)
	/// </summary>
	public const string t8416 = "t8416";
	/// <summary>
	/// 업종차트(틱/n틱)(t8417)
	/// </summary>
	public const string t8417 = "t8417";
	/// <summary>
	/// 업종챠트(N분)(t8418)
	/// </summary>
	public const string t8418 = "t8418";
	/// <summary>
	/// 업종챠트(일주월)(t8419)
	/// </summary>
	public const string t8419 = "t8419";
	/// <summary>
	/// 전체업종(t8424)
	/// </summary>
	public const string t8424 = "t8424";
	/// <summary>
	/// 전체테마(t8425)
	/// </summary>
	public const string t8425 = "t8425";
	/// <summary>
	/// 상품선물마스터조회(API용)(t8426)
	/// </summary>
	public const string t8426 = "t8426";
	/// <summary>
	/// 과거데이터시간대별조회(t8427)
	/// </summary>
	public const string t8427 = "t8427";
	/// <summary>
	/// 증시주변자금추이(t8428)
	/// </summary>
	public const string t8428 = "t8428";
	/// <summary>
	/// EUREX야간옵션선물틱분별체결조회챠트(t8429)
	/// </summary>
	public const string t8429 = "t8429";
	/// <summary>
	/// 주식종목조회(t8430)
	/// </summary>
	public const string t8430 = "t8430";
	/// <summary>
	/// ELW종목조회(t8431)
	/// </summary>
	public const string t8431 = "t8431";
	/// <summary>
	/// 지수선물마스터조회API용(t8432)
	/// </summary>
	public const string t8432 = "t8432";
	/// <summary>
	/// 지수옵션마스터조회API용(t8433)
	/// </summary>
	public const string t8433 = "t8433";
	/// <summary>
	/// 선물/옵션멀티현재가조회(t8434)
	/// </summary>
	public const string t8434 = "t8434";
	/// <summary>
	/// 파생종목마스터조회API용(t8435)
	/// </summary>
	public const string t8435 = "t8435";
	/// <summary>
	/// 주식종목조회 API용(t8436)
	/// </summary>
	public const string t8436 = "t8436";
	/// <summary>
	/// CME/EUREX마스터조회(API용)(t8437)
	/// </summary>
	public const string t8437 = "t8437";
	/// <summary>
	/// 기초자산리스트조회(t9905)
	/// </summary>
	public const string t9905 = "t9905";
	/// <summary>
	/// 만기월조회(t9907)
	/// </summary>
	public const string t9907 = "t9907";
	/// <summary>
	/// ELW마스터조회API용(t9942)
	/// </summary>
	public const string t9942 = "t9942";
	/// <summary>
	/// 지수선물마스터조회API용(t9943)
	/// </summary>
	public const string t9943 = "t9943";
	/// <summary>
	/// 지수옵션마스터조회API용(t9944)
	/// </summary>
	public const string t9944 = "t9944";
	/// <summary>
	/// 주식마스터조회API용-종목명40bytes(t9945)
	/// </summary>
	public const string t9945 = "t9945";
	/// <summary>
	/// VI발동해제(VI_)
	/// </summary>
	public const string VI_ = "VI_";
	/// <summary>
	/// 상품선물예상체결(YC3)
	/// </summary>
	public const string YC3 = "YC3";
	/// <summary>
	/// 지수선물예상체결(YFC)
	/// </summary>
	public const string YFC = "YFC";
	/// <summary>
	/// 주식선물예상체결(YJC)
	/// </summary>
	public const string YJC = "YJC";
	/// <summary>
	/// 예상지수(YJ)
	/// </summary>
	public const string YJ_ = "YJ_";
	/// <summary>
	/// KOSDAQ예상체결(YK3)
	/// </summary>
	public const string YK3 = "YK3";
	/// <summary>
	/// 지수옵션예상체결(YOC)
	/// </summary>
	public const string YOC = "YOC";
	/// <summary>
	/// KOSPI예상체결(YS3)
	/// </summary>
	public const string YS3 = "YS3";
	/// <summary>
	/// ELW예상체결(Ys3)
	/// </summary>
	public const string Ys3 = "Ys3";

	public static Type [] All = new Type []
	{
		typeof(XRB7_), // ETF호가잔량(B7)
		typeof(XRBMT), // 시간대별투자자매매추이(BMT)
		typeof(XRBM_), // 업종별투자자별매매현황(BM)
		typeof(XRC01), // 선물주문체결
		typeof(XQCCEAQ01100), // 선물옵션 CME 매매거래현황
		typeof(XQCCEAQ06000), // 선물옵션 CME 주문체결내역조회
		typeof(XQCCEAQ10100), // 선물옵션 CME 주문가능 수량/금액 조회
		typeof(XQCCEAQ50600), // 선물옵션 CME 계좌잔고 및 평가현황
		typeof(XQCCEAT00100), // CME 정상주문
		typeof(XQCCEAT00200), // CME 정정주문
		typeof(XQCCEAT00300), // CME 취소주문
		typeof(XQCCEBQ10500), // 선물옵션 CME 예탁금증거금조회
		typeof(XRCD0), // 상품선물실시간상하한가(D0)
		typeof(XQCDPCQ04700), // 계좌 거래내역
		typeof(XQCEXAQ21100), // 유렉스 주문체결내역조회
		typeof(XQCEXAQ21200), // 유렉스 주문가능 수량/금액 조회
		typeof(XQCEXAQ31100), // 유렉스 야간장잔고및 평가현황
		typeof(XQCEXAQ31200), // 유렉스 예탁금 및 통합잔고조회
		typeof(XQCEXAQ44200), // EUREX 야간옵션 기간주문체결조회
		typeof(XQCEXAT11100), // 유렉스 매수/매도주문
		typeof(XQCEXAT11200), // 유렉스 정정주문
		typeof(XQCEXAT11300), // 유렉스 취소주문
		typeof(XQCFOAQ00600), // 선물옵션 계좌주문체결내역조회
		typeof(XQCFOAQ10100), // 선물옵션 주문가능수량조회
		typeof(XQCFOAT00100), // 선물옵션 정상주문
		typeof(XQCFOAT00200), // 선물옵션 정정주문
		typeof(XQCFOAT00300), // 선물옵션 취소주문
		typeof(XQCFOBQ10500), // 선물옵션 계좌예탁금증거금조회
		typeof(XQCFOBQ10800), // 선물옵션 옵션매도시 주문증거금조회
		typeof(XQCFOEQ11100), // 선물옵션가정산예탁금상세
		typeof(XQCFOEQ82600), // 선물옵션 일별 계좌손익내역
		typeof(XQCFOFQ02400), // 계좌 미결제 약정현황(평균가)
		typeof(XQCHARTEXCEL), // 챠트엑셀데이터조회
		typeof(XQCHARTINDEX), // 챠트지표데이터조회
		typeof(XQCLNAQ00100), // 예탁담보융자가능종목현황조회
		typeof(XRCM0), // CME접수
		typeof(XRCM1), // CME체결
		typeof(XRCM2), // CME확인
		typeof(XQCSPAQ00600), // 계좌별신용한도조회
		typeof(XQCSPAQ12200), // 현물계좌예수금 주문가능금액 총평가 조회
		typeof(XQCSPAQ12300), // BEP단가조회
		typeof(XQCSPAQ13700), // 현물계좌주문체결내역조회
		typeof(XQCSPAQ22200), // 현물계좌예수금 주문가능금액 총평가2
		typeof(XQCSPAT00600), // 현물주문
		typeof(XQCSPAT00700), // 현물정정주문
		typeof(XQCSPAT00800), // 현물취소주문
		typeof(XQCSPBQ00200), // 현물계좌증거금률별주문가능수량조회
		typeof(XRCUR), // 현물정보 USD 실시간(CUR)
		typeof(XRDH1), // KOSPI시간외단일가호가잔량(DH1)
		typeof(XRDHA), // KOSDAQ시간외단일가호가잔량(DHA)
		typeof(XRDK3), // KOSDAQ시간외단일가체결(DK3)
		typeof(XRDS3), // KOSPI시간외단일가체결(DS3)
		typeof(XRDVI), // 시간외단일가VI발동해제(DVI)
		typeof(XREC0), // EUREX연계KP200지수옵션선물체결(EC0)
		typeof(XREH0), // EUREX연계KP200지수옵션선물호가(EH0)
		typeof(XRESN), // 뉴ELW투자지표민감도(ESN)
		typeof(XREU0), // EUX접수
		typeof(XREU1), // EUX체결
		typeof(XREU2), // EUX확인
		typeof(XRFC0), // KOSPI200선물체결(C0)
		typeof(XRFD0), // KOSPI200선물실시간상하한가(D0)
		typeof(XRFH0), // KOSPI200선물호가(H0)
		typeof(XQFOCCQ33600), // 주식계좌 기간별수익률 상세
		typeof(XQFOCCQ33700), // 선물옵션 기간별 계좌 수익률 현황
		typeof(XRFX0), // KOSPI200선물가격제한폭확대(X0)
		typeof(XRH01), // 선물주문정정취소
		typeof(XRH1_), // KOSPI호가잔량(H1)
		typeof(XRH2_), // KOSPI장전시간외호가잔량(H2)
		typeof(XRh2_), // ELW장전시간외호가잔량(h2)
		typeof(XRh3_), // ELW호가잔량(h3)
		typeof(XRHA_), // KOSDAQ호가잔량(HA)
		typeof(XRHB_), // KOSDAQ장전시간외호가잔량(HB)
		typeof(XRI5_), // 코스피ETF종목실시간NAV(I5)
		typeof(XRIJ_), // 지수(IJ)
		typeof(XRJC0), // 주식선물체결(JC0)
		typeof(XRJD0), // 주식선물실시간상하한가(JD0)
		typeof(XRJH0), // 주식선물호가(JH0)
		typeof(XRJIF), // 장운영정보(JIF)
		typeof(XRJX0), // 주식선물가격제한폭확대(JX0)
		typeof(XRK1_), // KOSPI거래원(K1)
		typeof(XRk1_), // ELW거래원(k1)
		typeof(XRK3_), // KOSDAQ체결(K3)
		typeof(XRKH_), // KOSDAQ프로그램매매종목별(KH)
		typeof(XRKM_), // KOSDAQ프로그램매매전체집계(KM)
		typeof(XRKS_), // KOSDAQ우선호가(KS)
		typeof(XRMK2), // US지수(MK2)
		typeof(XQMMDAQ91200), // 파생상품증거금율조회
		typeof(XRNC0), // CME연계KP200지수선물체결(NC0)
		typeof(XRNH0), // CME연계KP200지수선물호가(NH0)
		typeof(XRNWS), // 실시간 뉴스 제목 패킷(NWS)
		typeof(XRO01), // 선물접수
		typeof(XROC0), // KOSPI200옵션체결(C0)
		typeof(XROD0), // KOSPI200옵션실시간상하한가(D0)
		typeof(XROH0), // KOSPI200옵션호가(H0)
		typeof(XROK_), // KOSDAQ거래원(OK)
		typeof(XROMG), // KOSPI200옵션민감도(MG)
		typeof(XROX0), // KOSPI200옵션가격제한폭확대(X0)
		typeof(XRPH_), // KOSPI프로그램매매종목별(PH)
		typeof(XRPM_), // KOSPI프로그램매매전체집계(PM)
		typeof(XRS2_), // KOSPI우선호가(S2)
		typeof(XRs2_), // ELW우선호가(s2)
		typeof(XRS3_), // KOSPI체결(S3)
		typeof(XRs3_), // ELW체결(s3)
		typeof(XRS4_), // KOSPI기세(S4)
		typeof(XRs4_), // ELW기세(s4)
		typeof(XRSC0), // 주식주문접수
		typeof(XRSC1), // 주식주문체결
		typeof(XRSC2), // 주식주문정정
		typeof(XRSC3), // 주식주문취소
		typeof(XRSC4), // 주식주문거부
		typeof(XRSHC), // 상/하한가근접진입(SHC)
		typeof(XRSHD), // 상/하한가근접이탈(SHD)
		typeof(XRSHI), // 상/하한가진입(SHI)
		typeof(XRSHO), // 상/하한가이탈(SHO)
		typeof(XQt0150), // 주식당일매매일지/수수료(t0150)
		typeof(XQt0151), // 주식당일매매일지/수수료(전일)(t0151)
		typeof(XQt0167), // 서버시간조회(t0167)
		typeof(XQt0424), // 주식잔고2(t0424)
		typeof(XQt0425), // 주식체결/미체결(t0425)
		typeof(XQt0434), // 선물/옵션체결/미체결(t0434)
		typeof(XQt0441), // 선물/옵션잔고평가(이동평균)(t0441)
		typeof(XQt1101), // 주식현재가호가조회(t1101)
		typeof(XQt1102), // 주식현재가(시세)조회(t1102)
		typeof(XQt1104), // 주식현재가시세메모(t1104)
		typeof(XQt1105), // 주식피못/디마크조회(t1105)
		typeof(XQt1301), // 주식시간대별체결조회(t1301)
		typeof(XQt1302), // 주식분별주가조회(t1302)
		typeof(XQt1305), // 기간별주가(t1305)
		typeof(XQt1308), // 주식시간대별체결조회챠트(t1308)
		typeof(XQt1310), // 주식당일전일분틱조회(t1310)
		typeof(XQt1403), // 신규상장종목조회(t1403)
		typeof(XQt1404), // 관리/불성실/투자유의조회(t1404)
		typeof(XQt1405), // 투자경고/매매정지/정리매매조회(t1405)
		typeof(XQt1410), // 초저유동성조회(t1410)
		typeof(XQt1411), // 증거금율별종목조회(t1411)
		typeof(XQt1422), // 상/하한(t1422)
		typeof(XQt1427), // 상/하한가직전(t1427)
		typeof(XQt1442), // 신고/신저가(t1442)
		typeof(XQt1444), // 시가총액상위(t1444)
		typeof(XQt1449), // 가격대별매매비중조회(t1449)
		typeof(XQt1452), // 거래량상위(t1452)
		typeof(XQt1463), // 거래대금상위(t1463)
		typeof(XQt1471), // 시간대별호가잔량추이(t1471)
		typeof(XQt1475), // 체결강도추이(t1475)
		typeof(XQt1485), // 예상지수(t1485)
		typeof(XQt1486), // 시간별예상체결가(t1486)
		typeof(XQt1488), // 예상체결가등락율상위조회(t1488)
		typeof(XQt1489), // 예상체결량상위조회(t1489)
		typeof(XQt1511), // 업종현재가(t1511)
		typeof(XQt1514), // 업종기간별추이(t1514)
		typeof(XQt1516), // 업종별종목시세(t1516)
		typeof(XQt1531), // 테마별종목(t1531)
		typeof(XQt1532), // 종목별테마(t1532)
		typeof(XQt1533), // 특이테마(t1533)
		typeof(XQt1537), // 테마종목별시세조회(t1537)
		typeof(XQt1601), // 투자자별종합(t1601)
		typeof(XQt1602), // 시간대별투자자매매추이(t1602)
		typeof(XQt1603), // 시간대별투자자매매추이상세(t1603)
		typeof(XQt1615), // 투자자매매종합1(t1615)
		typeof(XQt1617), // 투자자매매종합2(t1617)
		typeof(XQt1621), // 업종별분별투자자매매동향(챠트용)
		typeof(XQt1631), // 프로그램매매종합조회(t1631)
		typeof(XQt1632), // 시간대별프로그램매매추이(t1632)
		typeof(XQt1633), // 기간별프로그램매매추이(t1633)
		typeof(XQt1636), // 종목별프로그램매매동향(t1636)
		typeof(XQt1637), // 종목별프로그램매매추이(t1637)
		typeof(XQt1638), // 종목별잔량/사전공시(t1638)
		typeof(XQt1640), // 프로그램매매종합조회(미니)(t1640)
		typeof(XQt1662), // 시간대별프로그램매매추이(차트)(t1662)
		typeof(XQt1664), // 투자자매매종합(챠트)
		typeof(XQt1665), // 기간별투자자매매추이(챠트)
		typeof(XQt1701), // 외인기관종목별동향(t1701)
		typeof(XQt1702), // 외인기관종목별동향(t1702)
		typeof(XQt1717), // 외인기관종목별동향(t1717)
		typeof(XQt1752), // 종목별상위회원사(t1752)
		typeof(XQt1764), // 회원사리스트(t1764)
		typeof(XQt1771), // 종목별회원사추이(t1771)
		typeof(XQt1809), // 신호조회(t1809)
		typeof(XQt1825), // 종목Q클릭검색(씽큐스마트)(t1825)
		typeof(XQt1826), // 종목Q클릭검색리스트조회(씽큐스마트)(t1826)
		typeof(XQt1857), // e종목검색(신버전API용)
		typeof(XQt1866), // 서버저장조건리스트조회(API)(t1866)
		typeof(XQt1901), // ETF현재가(시세)조회(t1901)
		typeof(XQt1902), // ETF시간별추이(t1902)
		typeof(XQt1903), // ETF일별추이(t1903)
		typeof(XQt1904), // ETF구성종목조회(t1904)
		typeof(XQt1906), // ETFLP호가(t1906)
		typeof(XQt1921), // 신용거래동향(t1921)
		typeof(XQt1926), // 종목별신용정보(t1926)
		typeof(XQt1927), // 공매도일별추이(t1927)
		typeof(XQt1941), // 종목별대차거래일간추이(t1941)
		typeof(XQt1950), // ELW현재가(시세)조회(t1950)
		typeof(XQt1951), // ELW시간대별체결조회(t1951)
		typeof(XQt1954), // ELW일별주가(t1954)
		typeof(XQt1955), // ELW지표검색(t1955)
		typeof(XQt1956), // ELW현재가(확정지급액)조회(t1956)
		typeof(XQt1958), // ELW종목비교(t1958)
		typeof(XQt1959), // LP대상종목정보조회(t1959)
		typeof(XQt1960), // ELW등락율상위(t1960)
		typeof(XQt1961), // ELW거래량상위(t1961)
		typeof(XQt1964), // ELW전광판(t1964)
		typeof(XQt1966), // ELW거래대금상위(t1966)
		typeof(XQt1971), // ELW현재가호가조회(t1971)
		typeof(XQt1972), // ELW현재가(거래원)조회(t1972)
		typeof(XQt1973), // ELW시간대별예상체결조회(t1973)
		typeof(XQt1974), // ELW기초자산동일종목(t1974)
		typeof(XQt1981), // 기초자산리스트조회(t1981)
		typeof(XQt2101), // 선물/옵션현재가(시세)조회(t2101)
		typeof(XQt2105), // 선물/옵션현재가호가조회(t2105)
		typeof(XQt2106), // 선물/옵션현재가시세메모(t2106)
		typeof(XQt2201), // 선물옵션시간대별체결조회(t2201)
		typeof(XQt2203), // 기간별주가(t2203)
		typeof(XQt2209), // 선물옵션틱분별체결조회챠트(t2209)
		typeof(XQt2210), // 선물옵션시간대별체결조회(단일출력용)
		typeof(XQt2301), // 옵션전광판(t2301)
		typeof(XQt2405), // 선물옵션호가잔량비율챠트(t2405)
		typeof(XQt2421), // 미결제약정추이(t2421)
		typeof(XQt2541), // 상품선물투자자매매동향(실시간)(t2541)
		typeof(XQt2545), // 상품선물투자자매매동향(챠트용)
		typeof(XQt2801), // CME야간선물현재가조회(t2801)
		typeof(XQt2802), // CME야간선물호가조회(t2802)
		typeof(XQt2804), // CME야간선물시간대별체결조회(t2804)
		typeof(XQt2805), // CME야간선물기간별주가(t2805)
		typeof(XQt2813), // CME야간선물시간대별투자자매매추이(t2813)
		typeof(XQt2814), // CME야간선물기간별투자자매매추이(챠트)
		typeof(XQt2816), // CME야간선물투자자별종합(t2816)
		typeof(XQt2830), // EUREXKOSPI200옵션선물현재가(시세)조회(t2830)
		typeof(XQt2831), // EUREXKOSPI200옵션선물호가조회(t2831)
		typeof(XQt2832), // EUREX야간옵션선물시간대별체결조회(t2832)
		typeof(XQt2833), // EUREX야간옵션선물기간별추이(t2833)
		typeof(XQt2835), // EUREX옵션선물시세전광판(t2835)
		typeof(XQt3102), // 뉴스본문(t3102)
		typeof(XQt3202), // 종목별증시일정(t3202)
		typeof(XQt3320), // FNG_요약(t3320)
		typeof(XQt3341), // 재무순위종합(t3341)
		typeof(XQt3401), // 투자의견(t3401)
		typeof(XQt3518), // 해외실시간지수(t3518)
		typeof(XQt3521), // 해외지수조회(API용)(t3521)
		typeof(XQt4201), // 주식챠트(종합)(t4201)
		typeof(XQt4203), // 업종챠트(종합)(t4203)
		typeof(XQt8401), // 주식선물마스터조회(API용)(t8401)
		typeof(XQt8402), // 주식선물현재가조회(API용)(t8402)
		typeof(XQt8403), // 주식선물호가조회(API용)(t8403)
		typeof(XQt8404), // 주식선물시간대별체결조회(API용)(t8404)
		typeof(XQt8405), // 주식선물기간별주가(API용)(t8405)
		typeof(XQt8406), // 주식선물틱분별체결조회(API용)(t8406)
		typeof(XQt8407), // API용주식멀티현재가조회(t8407)
		typeof(XQt8408), // CME야간선물틱분별체결조회(API용)(t8408)
		typeof(XQt8409), // CME야간선물미결제약정추이(API용)(t8409)
		typeof(XQt8411), // 주식챠트(틱/n틱)(t8411)
		typeof(XQt8412), // 주식챠트(N분)(t8412)
		typeof(XQt8413), // 주식챠트(일주월)(t8413)
		typeof(XQt8414), // 선물옵션차트(틱/n틱)(t8414)
		typeof(XQt8415), // 선물/옵션챠트(N분)(t8415)
		typeof(XQt8416), // 선물/옵션챠트(일주월)(t8416)
		typeof(XQt8417), // 업종차트(틱/n틱)(t8417)
		typeof(XQt8418), // 업종챠트(N분)(t8418)
		typeof(XQt8419), // 업종챠트(일주월)(t8419)
		typeof(XQt8424), // 전체업종(t8424)
		typeof(XQt8425), // 전체테마(t8425)
		typeof(XQt8426), // 상품선물마스터조회(API용)(t8426)
		typeof(XQt8427), // 과거데이터시간대별조회(t8427)
		typeof(XQt8428), // 증시주변자금추이(t8428)
		typeof(XQt8429), // EUREX야간옵션선물틱분별체결조회챠트(t8429)
		typeof(XQt8430), // 주식종목조회(t8430)
		typeof(XQt8431), // ELW종목조회(t8431)
		typeof(XQt8432), // 지수선물마스터조회API용(t8432)
		typeof(XQt8433), // 지수옵션마스터조회API용(t8433)
		typeof(XQt8434), // 선물/옵션멀티현재가조회(t8434)
		typeof(XQt8435), // 파생종목마스터조회API용(t8435)
		typeof(XQt8436), // 주식종목조회 API용(t8436)
		typeof(XQt8437), // CME/EUREX마스터조회(API용)(t8437)
		typeof(XQt9905), // 기초자산리스트조회(t9905)
		typeof(XQt9907), // 만기월조회(t9907)
		typeof(XQt9942), // ELW마스터조회API용(t9942)
		typeof(XQt9943), // 지수선물마스터조회API용(t9943)
		typeof(XQt9944), // 지수옵션마스터조회API용(t9944)
		typeof(XQt9945), // 주식마스터조회API용-종목명40bytes(t9945)
		typeof(XRVI_), // VI발동해제(VI_)
		typeof(XRYC3), // 상품선물예상체결(YC3)
		typeof(XRYFC), // 지수선물예상체결(YFC)
		typeof(XRYJC), // 주식선물예상체결(YJC)
		typeof(XRYJ_), // 예상지수(YJ)
		typeof(XRYK3), // KOSDAQ예상체결(YK3)
		typeof(XRYOC), // 지수옵션예상체결(YOC)
		typeof(XRYS3), // KOSPI예상체결(YS3)
		typeof(XRYs3), // ELW예상체결(Ys3)

	};
	public const int Count = 287;
}
