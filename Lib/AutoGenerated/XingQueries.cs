using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQCDPCQ04700InBlock1 : XingBlock
	{
		/// <summary>
		/// CDPCQ04700InBlock1
		/// </summary>
		static readonly string _blockName = "CDPCQ04700InBlock1";
		/// <summary>
		/// In(*EMPTY*)
		/// </summary>
		static readonly string _blockDesc = "In(*EMPTY*)";
		/// <summary>
		/// input
		/// </summary>
		static readonly string _blockType = "input";
		/// <summary>
		/// CDPCQ04700InBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CDPCQ04700InBlock1
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// In(*EMPTY*)
		/// </summary>
		public string BlockDesc => _blockDesc;
		/// <summary>
		/// input
		/// </summary>
		public string BlockType => _blockType;

		/// <summary>
		/// 레코드갯수
		/// </summary>
		[XAQueryFieldAttribute("레코드갯수")]
		public long RecCnt;
		/// <summary>
		/// 조회구분
		/// </summary>
		[XAQueryFieldAttribute("조회구분")]
		public char QryTp;
		/// <summary>
		/// 계좌번호
		/// </summary>
		[XAQueryFieldAttribute("계좌번호")]
		public string AcntNo;
		/// <summary>
		/// 비밀번호
		/// </summary>
		[XAQueryFieldAttribute("비밀번호")]
		public string Pwd;
		/// <summary>
		/// 조회시작일
		/// </summary>
		[XAQueryFieldAttribute("조회시작일")]
		public string QrySrtDt;
		/// <summary>
		/// 조회종료일
		/// </summary>
		[XAQueryFieldAttribute("조회종료일")]
		public string QryEndDt;
		/// <summary>
		/// 시작번호
		/// </summary>
		[XAQueryFieldAttribute("시작번호")]
		public long SrtNo;
		/// <summary>
		/// 상품유형코드
		/// </summary>
		[XAQueryFieldAttribute("상품유형코드")]
		public string PdptnCode;
		/// <summary>
		/// 종목대분류코드
		/// </summary>
		[XAQueryFieldAttribute("종목대분류코드")]
		public string IsuLgclssCode;
		/// <summary>
		/// 종목번호
		/// </summary>
		[XAQueryFieldAttribute("종목번호")]
		public string IsuNo;

		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["QryTp"] = new XAQueryFieldInfo("char", QryTp, QryTp.ToString(), "조회구분", (decimal)1);
			dict["AcntNo"] = new XAQueryFieldInfo("char", AcntNo, AcntNo, "계좌번호", (decimal)20);
			dict["Pwd"] = new XAQueryFieldInfo("char", Pwd, Pwd, "비밀번호", (decimal)8);
			dict["QrySrtDt"] = new XAQueryFieldInfo("char", QrySrtDt, QrySrtDt, "조회시작일", (decimal)8);
			dict["QryEndDt"] = new XAQueryFieldInfo("char", QryEndDt, QryEndDt, "조회종료일", (decimal)8);
			dict["SrtNo"] = new XAQueryFieldInfo("long", SrtNo, SrtNo.ToString("d10"), "시작번호", (decimal)10);
			dict["PdptnCode"] = new XAQueryFieldInfo("char", PdptnCode, PdptnCode, "상품유형코드", (decimal)2);
			dict["IsuLgclssCode"] = new XAQueryFieldInfo("char", IsuLgclssCode, IsuLgclssCode, "종목대분류코드", (decimal)2);
			dict["IsuNo"] = new XAQueryFieldInfo("char", IsuNo, IsuNo, "종목번호", (decimal)12);

			return dict;
		}

		public bool VerifyData()
		{
			if (RecCnt.ToString().Length > 5) return false; // long 5
			// QryTp char 1
			if (AcntNo.Length > 20) return false; // char 20
			if (Pwd.Length > 8) return false; // char 8
			if (QrySrtDt.Length > 8) return false; // char 8
			if (QryEndDt.Length > 8) return false; // char 8
			if (SrtNo.ToString().Length > 10) return false; // long 10
			if (PdptnCode.Length > 2) return false; // char 2
			if (IsuLgclssCode.Length > 2) return false; // char 2
			if (IsuNo.Length > 12) return false; // char 12

			return true;
		}
	}

	public partial class XQCDPCQ04700OutBlock1 : XingBlock
	{
		/// <summary>
		/// CDPCQ04700OutBlock1
		/// </summary>
		static readonly string _blockName = "CDPCQ04700OutBlock1";
		/// <summary>
		/// In(*EMPTY*)
		/// </summary>
		static readonly string _blockDesc = "In(*EMPTY*)";
		/// <summary>
		/// output
		/// </summary>
		static readonly string _blockType = "output";
		/// <summary>
		/// CDPCQ04700OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CDPCQ04700OutBlock1
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// In(*EMPTY*)
		/// </summary>
		public string BlockDesc => _blockDesc;
		/// <summary>
		/// output
		/// </summary>
		public string BlockType => _blockType;

		/// <summary>
		/// 레코드갯수
		/// </summary>
		[XAQueryFieldAttribute("레코드갯수")]
		public long RecCnt;
		/// <summary>
		/// 조회구분
		/// </summary>
		[XAQueryFieldAttribute("조회구분")]
		public char QryTp;
		/// <summary>
		/// 계좌번호
		/// </summary>
		[XAQueryFieldAttribute("계좌번호")]
		public string AcntNo;
		/// <summary>
		/// 비밀번호
		/// </summary>
		[XAQueryFieldAttribute("비밀번호")]
		public string Pwd;
		/// <summary>
		/// 조회시작일
		/// </summary>
		[XAQueryFieldAttribute("조회시작일")]
		public string QrySrtDt;
		/// <summary>
		/// 조회종료일
		/// </summary>
		[XAQueryFieldAttribute("조회종료일")]
		public string QryEndDt;
		/// <summary>
		/// 시작번호
		/// </summary>
		[XAQueryFieldAttribute("시작번호")]
		public long SrtNo;
		/// <summary>
		/// 상품유형코드
		/// </summary>
		[XAQueryFieldAttribute("상품유형코드")]
		public string PdptnCode;
		/// <summary>
		/// 종목대분류코드
		/// </summary>
		[XAQueryFieldAttribute("종목대분류코드")]
		public string IsuLgclssCode;
		/// <summary>
		/// 종목번호
		/// </summary>
		[XAQueryFieldAttribute("종목번호")]
		public string IsuNo;

		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["QryTp"] = new XAQueryFieldInfo("char", QryTp, QryTp.ToString(), "조회구분", (decimal)1);
			dict["AcntNo"] = new XAQueryFieldInfo("char", AcntNo, AcntNo, "계좌번호", (decimal)20);
			dict["Pwd"] = new XAQueryFieldInfo("char", Pwd, Pwd, "비밀번호", (decimal)8);
			dict["QrySrtDt"] = new XAQueryFieldInfo("char", QrySrtDt, QrySrtDt, "조회시작일", (decimal)8);
			dict["QryEndDt"] = new XAQueryFieldInfo("char", QryEndDt, QryEndDt, "조회종료일", (decimal)8);
			dict["SrtNo"] = new XAQueryFieldInfo("long", SrtNo, SrtNo.ToString("d10"), "시작번호", (decimal)10);
			dict["PdptnCode"] = new XAQueryFieldInfo("char", PdptnCode, PdptnCode, "상품유형코드", (decimal)2);
			dict["IsuLgclssCode"] = new XAQueryFieldInfo("char", IsuLgclssCode, IsuLgclssCode, "종목대분류코드", (decimal)2);
			dict["IsuNo"] = new XAQueryFieldInfo("char", IsuNo, IsuNo, "종목번호", (decimal)12);

			return dict;
		}

		public static XQCDPCQ04700OutBlock1 FromQuery(XQCDPCQ04700 query)
		{
			XQCDPCQ04700OutBlock1 block = new XQCDPCQ04700OutBlock1();
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
				block.RecCnt = query.GetFieldData(block.GetBlockName(), "RecCnt", 0).ParseLong("RecCnt"); // long 5
				block.QryTp = query.GetFieldData(block.GetBlockName(), "QryTp", 0).First(); // char 1
				block.AcntNo = query.GetFieldData(block.GetBlockName(), "AcntNo", 0); // char 20
				block.Pwd = query.GetFieldData(block.GetBlockName(), "Pwd", 0); // char 8
				block.QrySrtDt = query.GetFieldData(block.GetBlockName(), "QrySrtDt", 0); // char 8
				block.QryEndDt = query.GetFieldData(block.GetBlockName(), "QryEndDt", 0); // char 8
				block.SrtNo = query.GetFieldData(block.GetBlockName(), "SrtNo", 0).ParseLong("SrtNo"); // long 10
				block.PdptnCode = query.GetFieldData(block.GetBlockName(), "PdptnCode", 0); // char 2
				block.IsuLgclssCode = query.GetFieldData(block.GetBlockName(), "IsuLgclssCode", 0); // char 2
				block.IsuNo = query.GetFieldData(block.GetBlockName(), "IsuNo", 0); // char 12

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (RecCnt.ToString().Length > 5) return false; // long 5
			// QryTp char 1
			if (AcntNo.Length > 20) return false; // char 20
			if (Pwd.Length > 8) return false; // char 8
			if (QrySrtDt.Length > 8) return false; // char 8
			if (QryEndDt.Length > 8) return false; // char 8
			if (SrtNo.ToString().Length > 10) return false; // long 10
			if (PdptnCode.Length > 2) return false; // char 2
			if (IsuLgclssCode.Length > 2) return false; // char 2
			if (IsuNo.Length > 12) return false; // char 12

			return true;
		}
	}

	public partial class XQCDPCQ04700OutBlock2 : XingBlock
	{
		/// <summary>
		/// CDPCQ04700OutBlock2
		/// </summary>
		static readonly string _blockName = "CDPCQ04700OutBlock2";
		/// <summary>
		/// Out(*EMPTY*)
		/// </summary>
		static readonly string _blockDesc = "Out(*EMPTY*)";
		/// <summary>
		/// output
		/// </summary>
		static readonly string _blockType = "output";
		/// <summary>
		/// CDPCQ04700OutBlock2
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CDPCQ04700OutBlock2
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// Out(*EMPTY*)
		/// </summary>
		public string BlockDesc => _blockDesc;
		/// <summary>
		/// output
		/// </summary>
		public string BlockType => _blockType;

		/// <summary>
		/// 레코드갯수
		/// </summary>
		[XAQueryFieldAttribute("레코드갯수")]
		public long RecCnt;
		/// <summary>
		/// 계좌명
		/// </summary>
		[XAQueryFieldAttribute("계좌명")]
		public string AcntNm;

		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["AcntNm"] = new XAQueryFieldInfo("char", AcntNm, AcntNm, "계좌명", (decimal)40);

			return dict;
		}

		public static XQCDPCQ04700OutBlock2 FromQuery(XQCDPCQ04700 query)
		{
			XQCDPCQ04700OutBlock2 block = new XQCDPCQ04700OutBlock2();
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
				block.RecCnt = query.GetFieldData(block.GetBlockName(), "RecCnt", 0).ParseLong("RecCnt"); // long 5
				block.AcntNm = query.GetFieldData(block.GetBlockName(), "AcntNm", 0); // char 40

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (RecCnt.ToString().Length > 5) return false; // long 5
			if (AcntNm.Length > 40) return false; // char 40

			return true;
		}
	}

	public partial class XQCDPCQ04700OutBlock3 : XingBlock
	{
		/// <summary>
		/// CDPCQ04700OutBlock3
		/// </summary>
		static readonly string _blockName = "CDPCQ04700OutBlock3";
		/// <summary>
		/// Out2(*EMPTY*)
		/// </summary>
		static readonly string _blockDesc = "Out2(*EMPTY*)";
		/// <summary>
		/// output
		/// </summary>
		static readonly string _blockType = "output";
		/// <summary>
		/// CDPCQ04700OutBlock3
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CDPCQ04700OutBlock3
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// Out2(*EMPTY*)
		/// </summary>
		public string BlockDesc => _blockDesc;
		/// <summary>
		/// output
		/// </summary>
		public string BlockType => _blockType;

		/// <summary>
		/// 계좌번호
		/// </summary>
		[XAQueryFieldAttribute("계좌번호")]
		public string AcntNo;
		/// <summary>
		/// 거래일자
		/// </summary>
		[XAQueryFieldAttribute("거래일자")]
		public string TrdDt;
		/// <summary>
		/// 거래번호
		/// </summary>
		[XAQueryFieldAttribute("거래번호")]
		public long TrdNo;
		/// <summary>
		/// 구분코드명
		/// </summary>
		[XAQueryFieldAttribute("구분코드명")]
		public string TpCodeNm;
		/// <summary>
		/// 적요번호
		/// </summary>
		[XAQueryFieldAttribute("적요번호")]
		public string SmryNo;
		/// <summary>
		/// 적요명
		/// </summary>
		[XAQueryFieldAttribute("적요명")]
		public string SmryNm;
		/// <summary>
		/// 취소구분
		/// </summary>
		[XAQueryFieldAttribute("취소구분")]
		public string CancTpNm;
		/// <summary>
		/// 거래수량
		/// </summary>
		[XAQueryFieldAttribute("거래수량")]
		public long TrdQty;
		/// <summary>
		/// 거래세
		/// </summary>
		[XAQueryFieldAttribute("거래세")]
		public long Trtax;
		/// <summary>
		/// 외화정산금액
		/// </summary>
		[XAQueryFieldAttribute("외화정산금액")]
		public double FcurrAdjstAmt;
		/// <summary>
		/// 정산금액
		/// </summary>
		[XAQueryFieldAttribute("정산금액")]
		public long AdjstAmt;
		/// <summary>
		/// 연체합
		/// </summary>
		[XAQueryFieldAttribute("연체합")]
		public long OvdSum;
		/// <summary>
		/// 예수금전잔금액
		/// </summary>
		[XAQueryFieldAttribute("예수금전잔금액")]
		public long DpsBfbalAmt;
		/// <summary>
		/// 매도담보상환금
		/// </summary>
		[XAQueryFieldAttribute("매도담보상환금")]
		public long SellPldgRfundAmt;
		/// <summary>
		/// 예탁담보대출전잔금액
		/// </summary>
		[XAQueryFieldAttribute("예탁담보대출전잔금액")]
		public long DpspdgLoanBfbalAmt;
		/// <summary>
		/// 거래매체명
		/// </summary>
		[XAQueryFieldAttribute("거래매체명")]
		public string TrdmdaNm;
		/// <summary>
		/// 원거래번호
		/// </summary>
		[XAQueryFieldAttribute("원거래번호")]
		public long OrgTrdNo;
		/// <summary>
		/// 종목명
		/// </summary>
		[XAQueryFieldAttribute("종목명")]
		public string IsuNm;
		/// <summary>
		/// 거래단가
		/// </summary>
		[XAQueryFieldAttribute("거래단가")]
		public double TrdUprc;
		/// <summary>
		/// 수수료
		/// </summary>
		[XAQueryFieldAttribute("수수료")]
		public long CmsnAmt;
		/// <summary>
		/// 외화수수료금액
		/// </summary>
		[XAQueryFieldAttribute("외화수수료금액")]
		public double FcurrCmsnAmt;
		/// <summary>
		/// 상환차이금액
		/// </summary>
		[XAQueryFieldAttribute("상환차이금액")]
		public long RfundDiffAmt;
		/// <summary>
		/// 변제금합계
		/// </summary>
		[XAQueryFieldAttribute("변제금합계")]
		public long RepayAmtSum;
		/// <summary>
		/// 유가증권금잔수량
		/// </summary>
		[XAQueryFieldAttribute("유가증권금잔수량")]
		public long SecCrbalQty;
		/// <summary>
		/// 매도대금담보대출상환이자금액
		/// </summary>
		[XAQueryFieldAttribute("매도대금담보대출상환이자금액")]
		public long CslLoanRfundIntrstAmt;
		/// <summary>
		/// 예탁담보대출금잔금액
		/// </summary>
		[XAQueryFieldAttribute("예탁담보대출금잔금액")]
		public long DpspdgLoanCrbalAmt;
		/// <summary>
		/// 처리시각
		/// </summary>
		[XAQueryFieldAttribute("처리시각")]
		public string TrxTime;
		/// <summary>
		/// 출납번호
		/// </summary>
		[XAQueryFieldAttribute("출납번호")]
		public long Inouno;
		/// <summary>
		/// 종목번호
		/// </summary>
		[XAQueryFieldAttribute("종목번호")]
		public string IsuNo;
		/// <summary>
		/// 거래금액
		/// </summary>
		[XAQueryFieldAttribute("거래금액")]
		public long TrdAmt;
		/// <summary>
		/// 수표금액
		/// </summary>
		[XAQueryFieldAttribute("수표금액")]
		public long ChckAmt;
		/// <summary>
		/// 세금합계금액
		/// </summary>
		[XAQueryFieldAttribute("세금합계금액")]
		public long TaxSumAmt;
		/// <summary>
		/// 외화세금합계금액
		/// </summary>
		[XAQueryFieldAttribute("외화세금합계금액")]
		public double FcurrTaxSumAmt;
		/// <summary>
		/// 이자이용료
		/// </summary>
		[XAQueryFieldAttribute("이자이용료")]
		public long IntrstUtlfee;
		/// <summary>
		/// 배당금액
		/// </summary>
		[XAQueryFieldAttribute("배당금액")]
		public long MnyDvdAmt;
		/// <summary>
		/// 미수발생금액
		/// </summary>
		[XAQueryFieldAttribute("미수발생금액")]
		public long RcvblOcrAmt;
		/// <summary>
		/// 처리지점번호
		/// </summary>
		[XAQueryFieldAttribute("처리지점번호")]
		public string TrxBrnNo;
		/// <summary>
		/// 처리지점명
		/// </summary>
		[XAQueryFieldAttribute("처리지점명")]
		public string TrxBrnNm;
		/// <summary>
		/// 예탁담보대출금액
		/// </summary>
		[XAQueryFieldAttribute("예탁담보대출금액")]
		public long DpspdgLoanAmt;
		/// <summary>
		/// 예탁담보대출상환금액
		/// </summary>
		[XAQueryFieldAttribute("예탁담보대출상환금액")]
		public long DpspdgLoanRfundAmt;
		/// <summary>
		/// 기준가
		/// </summary>
		[XAQueryFieldAttribute("기준가")]
		public double BasePrc;
		/// <summary>
		/// 예수금금잔금액
		/// </summary>
		[XAQueryFieldAttribute("예수금금잔금액")]
		public long DpsCrbalAmt;
		/// <summary>
		/// 과표
		/// </summary>
		[XAQueryFieldAttribute("과표")]
		public long BoaAmt;
		/// <summary>
		/// 출금가능금액
		/// </summary>
		[XAQueryFieldAttribute("출금가능금액")]
		public long MnyoutAbleAmt;
		/// <summary>
		/// 수익증권담보대출발생금
		/// </summary>
		[XAQueryFieldAttribute("수익증권담보대출발생금")]
		public long BcrLoanOcrAmt;
		/// <summary>
		/// 수익증권담보대출전잔금
		/// </summary>
		[XAQueryFieldAttribute("수익증권담보대출전잔금")]
		public long BcrLoanBfbalAmt;
		/// <summary>
		/// 매매기준가
		/// </summary>
		[XAQueryFieldAttribute("매매기준가")]
		public double BnsBasePrc;
		/// <summary>
		/// 과세기준가
		/// </summary>
		[XAQueryFieldAttribute("과세기준가")]
		public double TaxchrBasePrc;
		/// <summary>
		/// 거래좌수
		/// </summary>
		[XAQueryFieldAttribute("거래좌수")]
		public long TrdUnit;
		/// <summary>
		/// 잔고좌수
		/// </summary>
		[XAQueryFieldAttribute("잔고좌수")]
		public long BalUnit;
		/// <summary>
		/// 제세금
		/// </summary>
		[XAQueryFieldAttribute("제세금")]
		public long EvrTax;
		/// <summary>
		/// 평가금액
		/// </summary>
		[XAQueryFieldAttribute("평가금액")]
		public long EvalAmt;
		/// <summary>
		/// 수익증권담보대출상환금
		/// </summary>
		[XAQueryFieldAttribute("수익증권담보대출상환금")]
		public long BcrLoanRfundAmt;
		/// <summary>
		/// 수익증권담보대출금잔금
		/// </summary>
		[XAQueryFieldAttribute("수익증권담보대출금잔금")]
		public long BcrLoanCrbalAmt;
		/// <summary>
		/// 추가증거금발생총액
		/// </summary>
		[XAQueryFieldAttribute("추가증거금발생총액")]
		public long AddMgnOcrTotamt;
		/// <summary>
		/// 추가현금증거금발생금액
		/// </summary>
		[XAQueryFieldAttribute("추가현금증거금발생금액")]
		public long AddMnyMgnOcrAmt;
		/// <summary>
		/// 추가증거금납부총액
		/// </summary>
		[XAQueryFieldAttribute("추가증거금납부총액")]
		public long AddMgnDfryTotamt;
		/// <summary>
		/// 추가현금증거금납부금액
		/// </summary>
		[XAQueryFieldAttribute("추가현금증거금납부금액")]
		public long AddMnyMgnDfryAmt;
		/// <summary>
		/// 매매손익금액
		/// </summary>
		[XAQueryFieldAttribute("매매손익금액")]
		public long BnsplAmt;
		/// <summary>
		/// 소득세
		/// </summary>
		[XAQueryFieldAttribute("소득세")]
		public long Ictax;
		/// <summary>
		/// 주민세
		/// </summary>
		[XAQueryFieldAttribute("주민세")]
		public long Ihtax;
		/// <summary>
		/// 대출일
		/// </summary>
		[XAQueryFieldAttribute("대출일")]
		public string LoanDt;
		/// <summary>
		/// 통화코드
		/// </summary>
		[XAQueryFieldAttribute("통화코드")]
		public string CrcyCode;
		/// <summary>
		/// 외화금액
		/// </summary>
		[XAQueryFieldAttribute("외화금액")]
		public double FcurrAmt;
		/// <summary>
		/// 외화거래금액
		/// </summary>
		[XAQueryFieldAttribute("외화거래금액")]
		public double FcurrTrdAmt;
		/// <summary>
		/// 외화예수금
		/// </summary>
		[XAQueryFieldAttribute("외화예수금")]
		public double FcurrDps;
		/// <summary>
		/// 외화예수금전잔금액
		/// </summary>
		[XAQueryFieldAttribute("외화예수금전잔금액")]
		public double FcurrDpsBfbalAmt;
		/// <summary>
		/// 상대계좌명
		/// </summary>
		[XAQueryFieldAttribute("상대계좌명")]
		public string OppAcntNm;
		/// <summary>
		/// 상대계좌번호
		/// </summary>
		[XAQueryFieldAttribute("상대계좌번호")]
		public string OppAcntNo;
		/// <summary>
		/// 대출상환금액
		/// </summary>
		[XAQueryFieldAttribute("대출상환금액")]
		public long LoanRfundAmt;
		/// <summary>
		/// 대출이자금액
		/// </summary>
		[XAQueryFieldAttribute("대출이자금액")]
		public long LoanIntrstAmt;
		/// <summary>
		/// 의뢰인명
		/// </summary>
		[XAQueryFieldAttribute("의뢰인명")]
		public string AskpsnNm;
		/// <summary>
		/// 주문일자
		/// </summary>
		[XAQueryFieldAttribute("주문일자")]
		public string OrdDt;
		/// <summary>
		/// 거래환율
		/// </summary>
		[XAQueryFieldAttribute("거래환율")]
		public double TrdXchrat;
		/// <summary>
		/// 감면수수료
		/// </summary>
		[XAQueryFieldAttribute("감면수수료")]
		public double RdctCmsn;
		/// <summary>
		/// 외화인지세
		/// </summary>
		[XAQueryFieldAttribute("외화인지세")]
		public double FcurrStmpTx;
		/// <summary>
		/// 외화전자금융거래세
		/// </summary>
		[XAQueryFieldAttribute("외화전자금융거래세")]
		public double FcurrElecfnTrtax;
		/// <summary>
		/// 외화증권거래세
		/// </summary>
		[XAQueryFieldAttribute("외화증권거래세")]
		public double FcstckTrtax;

		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["AcntNo"] = new XAQueryFieldInfo("char", AcntNo, AcntNo, "계좌번호", (decimal)20);
			dict["TrdDt"] = new XAQueryFieldInfo("char", TrdDt, TrdDt, "거래일자", (decimal)8);
			dict["TrdNo"] = new XAQueryFieldInfo("long", TrdNo, TrdNo.ToString("d10"), "거래번호", (decimal)10);
			dict["TpCodeNm"] = new XAQueryFieldInfo("char", TpCodeNm, TpCodeNm, "구분코드명", (decimal)50);
			dict["SmryNo"] = new XAQueryFieldInfo("char", SmryNo, SmryNo, "적요번호", (decimal)4);
			dict["SmryNm"] = new XAQueryFieldInfo("char", SmryNm, SmryNm, "적요명", (decimal)40);
			dict["CancTpNm"] = new XAQueryFieldInfo("char", CancTpNm, CancTpNm, "취소구분", (decimal)20);
			dict["TrdQty"] = new XAQueryFieldInfo("long", TrdQty, TrdQty.ToString("d16"), "거래수량", (decimal)16);
			dict["Trtax"] = new XAQueryFieldInfo("long", Trtax, Trtax.ToString("d16"), "거래세", (decimal)16);
			dict["FcurrAdjstAmt"] = new XAQueryFieldInfo("double", FcurrAdjstAmt, FcurrAdjstAmt.ToString("0000000000000000000000000.0000"), "외화정산금액", (decimal)25.4);
			dict["AdjstAmt"] = new XAQueryFieldInfo("long", AdjstAmt, AdjstAmt.ToString("d16"), "정산금액", (decimal)16);
			dict["OvdSum"] = new XAQueryFieldInfo("long", OvdSum, OvdSum.ToString("d16"), "연체합", (decimal)16);
			dict["DpsBfbalAmt"] = new XAQueryFieldInfo("long", DpsBfbalAmt, DpsBfbalAmt.ToString("d16"), "예수금전잔금액", (decimal)16);
			dict["SellPldgRfundAmt"] = new XAQueryFieldInfo("long", SellPldgRfundAmt, SellPldgRfundAmt.ToString("d16"), "매도담보상환금", (decimal)16);
			dict["DpspdgLoanBfbalAmt"] = new XAQueryFieldInfo("long", DpspdgLoanBfbalAmt, DpspdgLoanBfbalAmt.ToString("d16"), "예탁담보대출전잔금액", (decimal)16);
			dict["TrdmdaNm"] = new XAQueryFieldInfo("char", TrdmdaNm, TrdmdaNm, "거래매체명", (decimal)40);
			dict["OrgTrdNo"] = new XAQueryFieldInfo("long", OrgTrdNo, OrgTrdNo.ToString("d10"), "원거래번호", (decimal)10);
			dict["IsuNm"] = new XAQueryFieldInfo("char", IsuNm, IsuNm, "종목명", (decimal)40);
			dict["TrdUprc"] = new XAQueryFieldInfo("double", TrdUprc, TrdUprc.ToString("0000000000000.00"), "거래단가", (decimal)13.2);
			dict["CmsnAmt"] = new XAQueryFieldInfo("long", CmsnAmt, CmsnAmt.ToString("d16"), "수수료", (decimal)16);
			dict["FcurrCmsnAmt"] = new XAQueryFieldInfo("double", FcurrCmsnAmt, FcurrCmsnAmt.ToString("000000000000000.00"), "외화수수료금액", (decimal)15.2);
			dict["RfundDiffAmt"] = new XAQueryFieldInfo("long", RfundDiffAmt, RfundDiffAmt.ToString("d16"), "상환차이금액", (decimal)16);
			dict["RepayAmtSum"] = new XAQueryFieldInfo("long", RepayAmtSum, RepayAmtSum.ToString("d16"), "변제금합계", (decimal)16);
			dict["SecCrbalQty"] = new XAQueryFieldInfo("long", SecCrbalQty, SecCrbalQty.ToString("d16"), "유가증권금잔수량", (decimal)16);
			dict["CslLoanRfundIntrstAmt"] = new XAQueryFieldInfo("long", CslLoanRfundIntrstAmt, CslLoanRfundIntrstAmt.ToString("d16"), "매도대금담보대출상환이자금액", (decimal)16);
			dict["DpspdgLoanCrbalAmt"] = new XAQueryFieldInfo("long", DpspdgLoanCrbalAmt, DpspdgLoanCrbalAmt.ToString("d16"), "예탁담보대출금잔금액", (decimal)16);
			dict["TrxTime"] = new XAQueryFieldInfo("char", TrxTime, TrxTime, "처리시각", (decimal)9);
			dict["Inouno"] = new XAQueryFieldInfo("long", Inouno, Inouno.ToString("d10"), "출납번호", (decimal)10);
			dict["IsuNo"] = new XAQueryFieldInfo("char", IsuNo, IsuNo, "종목번호", (decimal)12);
			dict["TrdAmt"] = new XAQueryFieldInfo("long", TrdAmt, TrdAmt.ToString("d16"), "거래금액", (decimal)16);
			dict["ChckAmt"] = new XAQueryFieldInfo("long", ChckAmt, ChckAmt.ToString("d16"), "수표금액", (decimal)16);
			dict["TaxSumAmt"] = new XAQueryFieldInfo("long", TaxSumAmt, TaxSumAmt.ToString("d16"), "세금합계금액", (decimal)16);
			dict["FcurrTaxSumAmt"] = new XAQueryFieldInfo("double", FcurrTaxSumAmt, FcurrTaxSumAmt.ToString("00000000000000000000000000.000000"), "외화세금합계금액", (decimal)26.6);
			dict["IntrstUtlfee"] = new XAQueryFieldInfo("long", IntrstUtlfee, IntrstUtlfee.ToString("d16"), "이자이용료", (decimal)16);
			dict["MnyDvdAmt"] = new XAQueryFieldInfo("long", MnyDvdAmt, MnyDvdAmt.ToString("d16"), "배당금액", (decimal)16);
			dict["RcvblOcrAmt"] = new XAQueryFieldInfo("long", RcvblOcrAmt, RcvblOcrAmt.ToString("d16"), "미수발생금액", (decimal)16);
			dict["TrxBrnNo"] = new XAQueryFieldInfo("char", TrxBrnNo, TrxBrnNo, "처리지점번호", (decimal)3);
			dict["TrxBrnNm"] = new XAQueryFieldInfo("char", TrxBrnNm, TrxBrnNm, "처리지점명", (decimal)40);
			dict["DpspdgLoanAmt"] = new XAQueryFieldInfo("long", DpspdgLoanAmt, DpspdgLoanAmt.ToString("d16"), "예탁담보대출금액", (decimal)16);
			dict["DpspdgLoanRfundAmt"] = new XAQueryFieldInfo("long", DpspdgLoanRfundAmt, DpspdgLoanRfundAmt.ToString("d16"), "예탁담보대출상환금액", (decimal)16);
			dict["BasePrc"] = new XAQueryFieldInfo("double", BasePrc, BasePrc.ToString("0000000000000.00"), "기준가", (decimal)13.2);
			dict["DpsCrbalAmt"] = new XAQueryFieldInfo("long", DpsCrbalAmt, DpsCrbalAmt.ToString("d16"), "예수금금잔금액", (decimal)16);
			dict["BoaAmt"] = new XAQueryFieldInfo("long", BoaAmt, BoaAmt.ToString("d16"), "과표", (decimal)16);
			dict["MnyoutAbleAmt"] = new XAQueryFieldInfo("long", MnyoutAbleAmt, MnyoutAbleAmt.ToString("d16"), "출금가능금액", (decimal)16);
			dict["BcrLoanOcrAmt"] = new XAQueryFieldInfo("long", BcrLoanOcrAmt, BcrLoanOcrAmt.ToString("d16"), "수익증권담보대출발생금", (decimal)16);
			dict["BcrLoanBfbalAmt"] = new XAQueryFieldInfo("long", BcrLoanBfbalAmt, BcrLoanBfbalAmt.ToString("d16"), "수익증권담보대출전잔금", (decimal)16);
			dict["BnsBasePrc"] = new XAQueryFieldInfo("double", BnsBasePrc, BnsBasePrc.ToString("00000000000000000000.0000000000"), "매매기준가", (decimal)20.10);
			dict["TaxchrBasePrc"] = new XAQueryFieldInfo("double", TaxchrBasePrc, TaxchrBasePrc.ToString("00000000000000000000.0000000000"), "과세기준가", (decimal)20.10);
			dict["TrdUnit"] = new XAQueryFieldInfo("long", TrdUnit, TrdUnit.ToString("d16"), "거래좌수", (decimal)16);
			dict["BalUnit"] = new XAQueryFieldInfo("long", BalUnit, BalUnit.ToString("d16"), "잔고좌수", (decimal)16);
			dict["EvrTax"] = new XAQueryFieldInfo("long", EvrTax, EvrTax.ToString("d16"), "제세금", (decimal)16);
			dict["EvalAmt"] = new XAQueryFieldInfo("long", EvalAmt, EvalAmt.ToString("d16"), "평가금액", (decimal)16);
			dict["BcrLoanRfundAmt"] = new XAQueryFieldInfo("long", BcrLoanRfundAmt, BcrLoanRfundAmt.ToString("d16"), "수익증권담보대출상환금", (decimal)16);
			dict["BcrLoanCrbalAmt"] = new XAQueryFieldInfo("long", BcrLoanCrbalAmt, BcrLoanCrbalAmt.ToString("d16"), "수익증권담보대출금잔금", (decimal)16);
			dict["AddMgnOcrTotamt"] = new XAQueryFieldInfo("long", AddMgnOcrTotamt, AddMgnOcrTotamt.ToString("d16"), "추가증거금발생총액", (decimal)16);
			dict["AddMnyMgnOcrAmt"] = new XAQueryFieldInfo("long", AddMnyMgnOcrAmt, AddMnyMgnOcrAmt.ToString("d16"), "추가현금증거금발생금액", (decimal)16);
			dict["AddMgnDfryTotamt"] = new XAQueryFieldInfo("long", AddMgnDfryTotamt, AddMgnDfryTotamt.ToString("d16"), "추가증거금납부총액", (decimal)16);
			dict["AddMnyMgnDfryAmt"] = new XAQueryFieldInfo("long", AddMnyMgnDfryAmt, AddMnyMgnDfryAmt.ToString("d16"), "추가현금증거금납부금액", (decimal)16);
			dict["BnsplAmt"] = new XAQueryFieldInfo("long", BnsplAmt, BnsplAmt.ToString("d16"), "매매손익금액", (decimal)16);
			dict["Ictax"] = new XAQueryFieldInfo("long", Ictax, Ictax.ToString("d16"), "소득세", (decimal)16);
			dict["Ihtax"] = new XAQueryFieldInfo("long", Ihtax, Ihtax.ToString("d16"), "주민세", (decimal)16);
			dict["LoanDt"] = new XAQueryFieldInfo("char", LoanDt, LoanDt, "대출일", (decimal)8);
			dict["CrcyCode"] = new XAQueryFieldInfo("char", CrcyCode, CrcyCode, "통화코드", (decimal)3);
			dict["FcurrAmt"] = new XAQueryFieldInfo("double", FcurrAmt, FcurrAmt.ToString("000000000000000000000000.0000"), "외화금액", (decimal)24.4);
			dict["FcurrTrdAmt"] = new XAQueryFieldInfo("double", FcurrTrdAmt, FcurrTrdAmt.ToString("000000000000000000000000.0000"), "외화거래금액", (decimal)24.4);
			dict["FcurrDps"] = new XAQueryFieldInfo("double", FcurrDps, FcurrDps.ToString("000000000000000000000.0000"), "외화예수금", (decimal)21.4);
			dict["FcurrDpsBfbalAmt"] = new XAQueryFieldInfo("double", FcurrDpsBfbalAmt, FcurrDpsBfbalAmt.ToString("000000000000000000000.0000"), "외화예수금전잔금액", (decimal)21.4);
			dict["OppAcntNm"] = new XAQueryFieldInfo("char", OppAcntNm, OppAcntNm, "상대계좌명", (decimal)40);
			dict["OppAcntNo"] = new XAQueryFieldInfo("char", OppAcntNo, OppAcntNo, "상대계좌번호", (decimal)20);
			dict["LoanRfundAmt"] = new XAQueryFieldInfo("long", LoanRfundAmt, LoanRfundAmt.ToString("d16"), "대출상환금액", (decimal)16);
			dict["LoanIntrstAmt"] = new XAQueryFieldInfo("long", LoanIntrstAmt, LoanIntrstAmt.ToString("d16"), "대출이자금액", (decimal)16);
			dict["AskpsnNm"] = new XAQueryFieldInfo("char", AskpsnNm, AskpsnNm, "의뢰인명", (decimal)40);
			dict["OrdDt"] = new XAQueryFieldInfo("char", OrdDt, OrdDt, "주문일자", (decimal)8);
			dict["TrdXchrat"] = new XAQueryFieldInfo("double", TrdXchrat, TrdXchrat.ToString("000000000000000.0000"), "거래환율", (decimal)15.4);
			dict["RdctCmsn"] = new XAQueryFieldInfo("double", RdctCmsn, RdctCmsn.ToString("000000000000000000000.0000"), "감면수수료", (decimal)21.4);
			dict["FcurrStmpTx"] = new XAQueryFieldInfo("double", FcurrStmpTx, FcurrStmpTx.ToString("000000000000000000000.0000"), "외화인지세", (decimal)21.4);
			dict["FcurrElecfnTrtax"] = new XAQueryFieldInfo("double", FcurrElecfnTrtax, FcurrElecfnTrtax.ToString("000000000000000000000.0000"), "외화전자금융거래세", (decimal)21.4);
			dict["FcstckTrtax"] = new XAQueryFieldInfo("double", FcstckTrtax, FcstckTrtax.ToString("000000000000000000000.0000"), "외화증권거래세", (decimal)21.4);

			return dict;
		}

		public static XQCDPCQ04700OutBlock3 FromQuery(XQCDPCQ04700 query)
		{
			XQCDPCQ04700OutBlock3 block = new XQCDPCQ04700OutBlock3();
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
				block.AcntNo = query.GetFieldData(block.GetBlockName(), "AcntNo", 0); // char 20
				block.TrdDt = query.GetFieldData(block.GetBlockName(), "TrdDt", 0); // char 8
				block.TrdNo = query.GetFieldData(block.GetBlockName(), "TrdNo", 0).ParseLong("TrdNo"); // long 10
				block.TpCodeNm = query.GetFieldData(block.GetBlockName(), "TpCodeNm", 0); // char 50
				block.SmryNo = query.GetFieldData(block.GetBlockName(), "SmryNo", 0); // char 4
				block.SmryNm = query.GetFieldData(block.GetBlockName(), "SmryNm", 0); // char 40
				block.CancTpNm = query.GetFieldData(block.GetBlockName(), "CancTpNm", 0); // char 20
				block.TrdQty = query.GetFieldData(block.GetBlockName(), "TrdQty", 0).ParseLong("TrdQty"); // long 16
				block.Trtax = query.GetFieldData(block.GetBlockName(), "Trtax", 0).ParseLong("Trtax"); // long 16
				block.FcurrAdjstAmt = query.GetFieldData(block.GetBlockName(), "FcurrAdjstAmt", 0).ParseDouble("FcurrAdjstAmt"); // double 25.4
				block.AdjstAmt = query.GetFieldData(block.GetBlockName(), "AdjstAmt", 0).ParseLong("AdjstAmt"); // long 16
				block.OvdSum = query.GetFieldData(block.GetBlockName(), "OvdSum", 0).ParseLong("OvdSum"); // long 16
				block.DpsBfbalAmt = query.GetFieldData(block.GetBlockName(), "DpsBfbalAmt", 0).ParseLong("DpsBfbalAmt"); // long 16
				block.SellPldgRfundAmt = query.GetFieldData(block.GetBlockName(), "SellPldgRfundAmt", 0).ParseLong("SellPldgRfundAmt"); // long 16
				block.DpspdgLoanBfbalAmt = query.GetFieldData(block.GetBlockName(), "DpspdgLoanBfbalAmt", 0).ParseLong("DpspdgLoanBfbalAmt"); // long 16
				block.TrdmdaNm = query.GetFieldData(block.GetBlockName(), "TrdmdaNm", 0); // char 40
				block.OrgTrdNo = query.GetFieldData(block.GetBlockName(), "OrgTrdNo", 0).ParseLong("OrgTrdNo"); // long 10
				block.IsuNm = query.GetFieldData(block.GetBlockName(), "IsuNm", 0); // char 40
				block.TrdUprc = query.GetFieldData(block.GetBlockName(), "TrdUprc", 0).ParseDouble("TrdUprc"); // double 13.2
				block.CmsnAmt = query.GetFieldData(block.GetBlockName(), "CmsnAmt", 0).ParseLong("CmsnAmt"); // long 16
				block.FcurrCmsnAmt = query.GetFieldData(block.GetBlockName(), "FcurrCmsnAmt", 0).ParseDouble("FcurrCmsnAmt"); // double 15.2
				block.RfundDiffAmt = query.GetFieldData(block.GetBlockName(), "RfundDiffAmt", 0).ParseLong("RfundDiffAmt"); // long 16
				block.RepayAmtSum = query.GetFieldData(block.GetBlockName(), "RepayAmtSum", 0).ParseLong("RepayAmtSum"); // long 16
				block.SecCrbalQty = query.GetFieldData(block.GetBlockName(), "SecCrbalQty", 0).ParseLong("SecCrbalQty"); // long 16
				block.CslLoanRfundIntrstAmt = query.GetFieldData(block.GetBlockName(), "CslLoanRfundIntrstAmt", 0).ParseLong("CslLoanRfundIntrstAmt"); // long 16
				block.DpspdgLoanCrbalAmt = query.GetFieldData(block.GetBlockName(), "DpspdgLoanCrbalAmt", 0).ParseLong("DpspdgLoanCrbalAmt"); // long 16
				block.TrxTime = query.GetFieldData(block.GetBlockName(), "TrxTime", 0); // char 9
				block.Inouno = query.GetFieldData(block.GetBlockName(), "Inouno", 0).ParseLong("Inouno"); // long 10
				block.IsuNo = query.GetFieldData(block.GetBlockName(), "IsuNo", 0); // char 12
				block.TrdAmt = query.GetFieldData(block.GetBlockName(), "TrdAmt", 0).ParseLong("TrdAmt"); // long 16
				block.ChckAmt = query.GetFieldData(block.GetBlockName(), "ChckAmt", 0).ParseLong("ChckAmt"); // long 16
				block.TaxSumAmt = query.GetFieldData(block.GetBlockName(), "TaxSumAmt", 0).ParseLong("TaxSumAmt"); // long 16
				block.FcurrTaxSumAmt = query.GetFieldData(block.GetBlockName(), "FcurrTaxSumAmt", 0).ParseDouble("FcurrTaxSumAmt"); // double 26.6
				block.IntrstUtlfee = query.GetFieldData(block.GetBlockName(), "IntrstUtlfee", 0).ParseLong("IntrstUtlfee"); // long 16
				block.MnyDvdAmt = query.GetFieldData(block.GetBlockName(), "MnyDvdAmt", 0).ParseLong("MnyDvdAmt"); // long 16
				block.RcvblOcrAmt = query.GetFieldData(block.GetBlockName(), "RcvblOcrAmt", 0).ParseLong("RcvblOcrAmt"); // long 16
				block.TrxBrnNo = query.GetFieldData(block.GetBlockName(), "TrxBrnNo", 0); // char 3
				block.TrxBrnNm = query.GetFieldData(block.GetBlockName(), "TrxBrnNm", 0); // char 40
				block.DpspdgLoanAmt = query.GetFieldData(block.GetBlockName(), "DpspdgLoanAmt", 0).ParseLong("DpspdgLoanAmt"); // long 16
				block.DpspdgLoanRfundAmt = query.GetFieldData(block.GetBlockName(), "DpspdgLoanRfundAmt", 0).ParseLong("DpspdgLoanRfundAmt"); // long 16
				block.BasePrc = query.GetFieldData(block.GetBlockName(), "BasePrc", 0).ParseDouble("BasePrc"); // double 13.2
				block.DpsCrbalAmt = query.GetFieldData(block.GetBlockName(), "DpsCrbalAmt", 0).ParseLong("DpsCrbalAmt"); // long 16
				block.BoaAmt = query.GetFieldData(block.GetBlockName(), "BoaAmt", 0).ParseLong("BoaAmt"); // long 16
				block.MnyoutAbleAmt = query.GetFieldData(block.GetBlockName(), "MnyoutAbleAmt", 0).ParseLong("MnyoutAbleAmt"); // long 16
				block.BcrLoanOcrAmt = query.GetFieldData(block.GetBlockName(), "BcrLoanOcrAmt", 0).ParseLong("BcrLoanOcrAmt"); // long 16
				block.BcrLoanBfbalAmt = query.GetFieldData(block.GetBlockName(), "BcrLoanBfbalAmt", 0).ParseLong("BcrLoanBfbalAmt"); // long 16
				block.BnsBasePrc = query.GetFieldData(block.GetBlockName(), "BnsBasePrc", 0).ParseDouble("BnsBasePrc"); // double 20.10
				block.TaxchrBasePrc = query.GetFieldData(block.GetBlockName(), "TaxchrBasePrc", 0).ParseDouble("TaxchrBasePrc"); // double 20.10
				block.TrdUnit = query.GetFieldData(block.GetBlockName(), "TrdUnit", 0).ParseLong("TrdUnit"); // long 16
				block.BalUnit = query.GetFieldData(block.GetBlockName(), "BalUnit", 0).ParseLong("BalUnit"); // long 16
				block.EvrTax = query.GetFieldData(block.GetBlockName(), "EvrTax", 0).ParseLong("EvrTax"); // long 16
				block.EvalAmt = query.GetFieldData(block.GetBlockName(), "EvalAmt", 0).ParseLong("EvalAmt"); // long 16
				block.BcrLoanRfundAmt = query.GetFieldData(block.GetBlockName(), "BcrLoanRfundAmt", 0).ParseLong("BcrLoanRfundAmt"); // long 16
				block.BcrLoanCrbalAmt = query.GetFieldData(block.GetBlockName(), "BcrLoanCrbalAmt", 0).ParseLong("BcrLoanCrbalAmt"); // long 16
				block.AddMgnOcrTotamt = query.GetFieldData(block.GetBlockName(), "AddMgnOcrTotamt", 0).ParseLong("AddMgnOcrTotamt"); // long 16
				block.AddMnyMgnOcrAmt = query.GetFieldData(block.GetBlockName(), "AddMnyMgnOcrAmt", 0).ParseLong("AddMnyMgnOcrAmt"); // long 16
				block.AddMgnDfryTotamt = query.GetFieldData(block.GetBlockName(), "AddMgnDfryTotamt", 0).ParseLong("AddMgnDfryTotamt"); // long 16
				block.AddMnyMgnDfryAmt = query.GetFieldData(block.GetBlockName(), "AddMnyMgnDfryAmt", 0).ParseLong("AddMnyMgnDfryAmt"); // long 16
				block.BnsplAmt = query.GetFieldData(block.GetBlockName(), "BnsplAmt", 0).ParseLong("BnsplAmt"); // long 16
				block.Ictax = query.GetFieldData(block.GetBlockName(), "Ictax", 0).ParseLong("Ictax"); // long 16
				block.Ihtax = query.GetFieldData(block.GetBlockName(), "Ihtax", 0).ParseLong("Ihtax"); // long 16
				block.LoanDt = query.GetFieldData(block.GetBlockName(), "LoanDt", 0); // char 8
				block.CrcyCode = query.GetFieldData(block.GetBlockName(), "CrcyCode", 0); // char 3
				block.FcurrAmt = query.GetFieldData(block.GetBlockName(), "FcurrAmt", 0).ParseDouble("FcurrAmt"); // double 24.4
				block.FcurrTrdAmt = query.GetFieldData(block.GetBlockName(), "FcurrTrdAmt", 0).ParseDouble("FcurrTrdAmt"); // double 24.4
				block.FcurrDps = query.GetFieldData(block.GetBlockName(), "FcurrDps", 0).ParseDouble("FcurrDps"); // double 21.4
				block.FcurrDpsBfbalAmt = query.GetFieldData(block.GetBlockName(), "FcurrDpsBfbalAmt", 0).ParseDouble("FcurrDpsBfbalAmt"); // double 21.4
				block.OppAcntNm = query.GetFieldData(block.GetBlockName(), "OppAcntNm", 0); // char 40
				block.OppAcntNo = query.GetFieldData(block.GetBlockName(), "OppAcntNo", 0); // char 20
				block.LoanRfundAmt = query.GetFieldData(block.GetBlockName(), "LoanRfundAmt", 0).ParseLong("LoanRfundAmt"); // long 16
				block.LoanIntrstAmt = query.GetFieldData(block.GetBlockName(), "LoanIntrstAmt", 0).ParseLong("LoanIntrstAmt"); // long 16
				block.AskpsnNm = query.GetFieldData(block.GetBlockName(), "AskpsnNm", 0); // char 40
				block.OrdDt = query.GetFieldData(block.GetBlockName(), "OrdDt", 0); // char 8
				block.TrdXchrat = query.GetFieldData(block.GetBlockName(), "TrdXchrat", 0).ParseDouble("TrdXchrat"); // double 15.4
				block.RdctCmsn = query.GetFieldData(block.GetBlockName(), "RdctCmsn", 0).ParseDouble("RdctCmsn"); // double 21.4
				block.FcurrStmpTx = query.GetFieldData(block.GetBlockName(), "FcurrStmpTx", 0).ParseDouble("FcurrStmpTx"); // double 21.4
				block.FcurrElecfnTrtax = query.GetFieldData(block.GetBlockName(), "FcurrElecfnTrtax", 0).ParseDouble("FcurrElecfnTrtax"); // double 21.4
				block.FcstckTrtax = query.GetFieldData(block.GetBlockName(), "FcstckTrtax", 0).ParseDouble("FcstckTrtax"); // double 21.4

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (AcntNo.Length > 20) return false; // char 20
			if (TrdDt.Length > 8) return false; // char 8
			if (TrdNo.ToString().Length > 10) return false; // long 10
			if (TpCodeNm.Length > 50) return false; // char 50
			if (SmryNo.Length > 4) return false; // char 4
			if (SmryNm.Length > 40) return false; // char 40
			if (CancTpNm.Length > 20) return false; // char 20
			if (TrdQty.ToString().Length > 16) return false; // long 16
			if (Trtax.ToString().Length > 16) return false; // long 16
			// FcurrAdjstAmt double 25.4
			if (AdjstAmt.ToString().Length > 16) return false; // long 16
			if (OvdSum.ToString().Length > 16) return false; // long 16
			if (DpsBfbalAmt.ToString().Length > 16) return false; // long 16
			if (SellPldgRfundAmt.ToString().Length > 16) return false; // long 16
			if (DpspdgLoanBfbalAmt.ToString().Length > 16) return false; // long 16
			if (TrdmdaNm.Length > 40) return false; // char 40
			if (OrgTrdNo.ToString().Length > 10) return false; // long 10
			if (IsuNm.Length > 40) return false; // char 40
			// TrdUprc double 13.2
			if (CmsnAmt.ToString().Length > 16) return false; // long 16
			// FcurrCmsnAmt double 15.2
			if (RfundDiffAmt.ToString().Length > 16) return false; // long 16
			if (RepayAmtSum.ToString().Length > 16) return false; // long 16
			if (SecCrbalQty.ToString().Length > 16) return false; // long 16
			if (CslLoanRfundIntrstAmt.ToString().Length > 16) return false; // long 16
			if (DpspdgLoanCrbalAmt.ToString().Length > 16) return false; // long 16
			if (TrxTime.Length > 9) return false; // char 9
			if (Inouno.ToString().Length > 10) return false; // long 10
			if (IsuNo.Length > 12) return false; // char 12
			if (TrdAmt.ToString().Length > 16) return false; // long 16
			if (ChckAmt.ToString().Length > 16) return false; // long 16
			if (TaxSumAmt.ToString().Length > 16) return false; // long 16
			// FcurrTaxSumAmt double 26.6
			if (IntrstUtlfee.ToString().Length > 16) return false; // long 16
			if (MnyDvdAmt.ToString().Length > 16) return false; // long 16
			if (RcvblOcrAmt.ToString().Length > 16) return false; // long 16
			if (TrxBrnNo.Length > 3) return false; // char 3
			if (TrxBrnNm.Length > 40) return false; // char 40
			if (DpspdgLoanAmt.ToString().Length > 16) return false; // long 16
			if (DpspdgLoanRfundAmt.ToString().Length > 16) return false; // long 16
			// BasePrc double 13.2
			if (DpsCrbalAmt.ToString().Length > 16) return false; // long 16
			if (BoaAmt.ToString().Length > 16) return false; // long 16
			if (MnyoutAbleAmt.ToString().Length > 16) return false; // long 16
			if (BcrLoanOcrAmt.ToString().Length > 16) return false; // long 16
			if (BcrLoanBfbalAmt.ToString().Length > 16) return false; // long 16
			// BnsBasePrc double 20.10
			// TaxchrBasePrc double 20.10
			if (TrdUnit.ToString().Length > 16) return false; // long 16
			if (BalUnit.ToString().Length > 16) return false; // long 16
			if (EvrTax.ToString().Length > 16) return false; // long 16
			if (EvalAmt.ToString().Length > 16) return false; // long 16
			if (BcrLoanRfundAmt.ToString().Length > 16) return false; // long 16
			if (BcrLoanCrbalAmt.ToString().Length > 16) return false; // long 16
			if (AddMgnOcrTotamt.ToString().Length > 16) return false; // long 16
			if (AddMnyMgnOcrAmt.ToString().Length > 16) return false; // long 16
			if (AddMgnDfryTotamt.ToString().Length > 16) return false; // long 16
			if (AddMnyMgnDfryAmt.ToString().Length > 16) return false; // long 16
			if (BnsplAmt.ToString().Length > 16) return false; // long 16
			if (Ictax.ToString().Length > 16) return false; // long 16
			if (Ihtax.ToString().Length > 16) return false; // long 16
			if (LoanDt.Length > 8) return false; // char 8
			if (CrcyCode.Length > 3) return false; // char 3
			// FcurrAmt double 24.4
			// FcurrTrdAmt double 24.4
			// FcurrDps double 21.4
			// FcurrDpsBfbalAmt double 21.4
			if (OppAcntNm.Length > 40) return false; // char 40
			if (OppAcntNo.Length > 20) return false; // char 20
			if (LoanRfundAmt.ToString().Length > 16) return false; // long 16
			if (LoanIntrstAmt.ToString().Length > 16) return false; // long 16
			if (AskpsnNm.Length > 40) return false; // char 40
			if (OrdDt.Length > 8) return false; // char 8
			// TrdXchrat double 15.4
			// RdctCmsn double 21.4
			// FcurrStmpTx double 21.4
			// FcurrElecfnTrtax double 21.4
			// FcstckTrtax double 21.4

			return true;
		}
	}

	public partial class XQCDPCQ04700OutBlock4 : XingBlock
	{
		/// <summary>
		/// CDPCQ04700OutBlock4
		/// </summary>
		static readonly string _blockName = "CDPCQ04700OutBlock4";
		/// <summary>
		/// Out3(*EMPTY*)
		/// </summary>
		static readonly string _blockDesc = "Out3(*EMPTY*)";
		/// <summary>
		/// output
		/// </summary>
		static readonly string _blockType = "output";
		/// <summary>
		/// CDPCQ04700OutBlock4
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CDPCQ04700OutBlock4
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// Out3(*EMPTY*)
		/// </summary>
		public string BlockDesc => _blockDesc;
		/// <summary>
		/// output
		/// </summary>
		public string BlockType => _blockType;

		/// <summary>
		/// 레코드갯수
		/// </summary>
		[XAQueryFieldAttribute("레코드갯수")]
		public long RecCnt;
		/// <summary>
		/// 손익합계금액
		/// </summary>
		[XAQueryFieldAttribute("손익합계금액")]
		public long PnlSumAmt;
		/// <summary>
		/// 약정누계
		/// </summary>
		[XAQueryFieldAttribute("약정누계")]
		public long CtrctAsm;
		/// <summary>
		/// 수수료합계금액
		/// </summary>
		[XAQueryFieldAttribute("수수료합계금액")]
		public long CmsnAmtSumAmt;

		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["PnlSumAmt"] = new XAQueryFieldInfo("long", PnlSumAmt, PnlSumAmt.ToString("d16"), "손익합계금액", (decimal)16);
			dict["CtrctAsm"] = new XAQueryFieldInfo("long", CtrctAsm, CtrctAsm.ToString("d16"), "약정누계", (decimal)16);
			dict["CmsnAmtSumAmt"] = new XAQueryFieldInfo("long", CmsnAmtSumAmt, CmsnAmtSumAmt.ToString("d16"), "수수료합계금액", (decimal)16);

			return dict;
		}

		public static XQCDPCQ04700OutBlock4 FromQuery(XQCDPCQ04700 query)
		{
			XQCDPCQ04700OutBlock4 block = new XQCDPCQ04700OutBlock4();
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
				block.RecCnt = query.GetFieldData(block.GetBlockName(), "RecCnt", 0).ParseLong("RecCnt"); // long 5
				block.PnlSumAmt = query.GetFieldData(block.GetBlockName(), "PnlSumAmt", 0).ParseLong("PnlSumAmt"); // long 16
				block.CtrctAsm = query.GetFieldData(block.GetBlockName(), "CtrctAsm", 0).ParseLong("CtrctAsm"); // long 16
				block.CmsnAmtSumAmt = query.GetFieldData(block.GetBlockName(), "CmsnAmtSumAmt", 0).ParseLong("CmsnAmtSumAmt"); // long 16

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (RecCnt.ToString().Length > 5) return false; // long 5
			if (PnlSumAmt.ToString().Length > 16) return false; // long 16
			if (CtrctAsm.ToString().Length > 16) return false; // long 16
			if (CmsnAmtSumAmt.ToString().Length > 16) return false; // long 16

			return true;
		}
	}

	public partial class XQCDPCQ04700OutBlock5 : XingBlock
	{
		/// <summary>
		/// CDPCQ04700OutBlock5
		/// </summary>
		static readonly string _blockName = "CDPCQ04700OutBlock5";
		/// <summary>
		/// Out4(*EMPTY*)
		/// </summary>
		static readonly string _blockDesc = "Out4(*EMPTY*)";
		/// <summary>
		/// output
		/// </summary>
		static readonly string _blockType = "output";
		/// <summary>
		/// CDPCQ04700OutBlock5
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CDPCQ04700OutBlock5
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// Out4(*EMPTY*)
		/// </summary>
		public string BlockDesc => _blockDesc;
		/// <summary>
		/// output
		/// </summary>
		public string BlockType => _blockType;

		/// <summary>
		/// 레코드갯수
		/// </summary>
		[XAQueryFieldAttribute("레코드갯수")]
		public long RecCnt;
		/// <summary>
		/// 입금금액
		/// </summary>
		[XAQueryFieldAttribute("입금금액")]
		public long MnyinAmt;
		/// <summary>
		/// 입고금액
		/// </summary>
		[XAQueryFieldAttribute("입고금액")]
		public long SecinAmt;
		/// <summary>
		/// 출금금액
		/// </summary>
		[XAQueryFieldAttribute("출금금액")]
		public long MnyoutAmt;
		/// <summary>
		/// 출고금액
		/// </summary>
		[XAQueryFieldAttribute("출고금액")]
		public long SecoutAmt;
		/// <summary>
		/// 차이금액
		/// </summary>
		[XAQueryFieldAttribute("차이금액")]
		public long DiffAmt;
		/// <summary>
		/// 차이금액0
		/// </summary>
		[XAQueryFieldAttribute("차이금액0")]
		public long DiffAmt0;
		/// <summary>
		/// 매도수량
		/// </summary>
		[XAQueryFieldAttribute("매도수량")]
		public long SellQty;
		/// <summary>
		/// 매도금액
		/// </summary>
		[XAQueryFieldAttribute("매도금액")]
		public long SellAmt;
		/// <summary>
		/// 매도수수료
		/// </summary>
		[XAQueryFieldAttribute("매도수수료")]
		public long SellCmsn;
		/// <summary>
		/// 제세금
		/// </summary>
		[XAQueryFieldAttribute("제세금")]
		public long EvrTax;
		/// <summary>
		/// 외화매도정산금액
		/// </summary>
		[XAQueryFieldAttribute("외화매도정산금액")]
		public double FcurrSellAdjstAmt;
		/// <summary>
		/// 매수수량
		/// </summary>
		[XAQueryFieldAttribute("매수수량")]
		public long BuyQty;
		/// <summary>
		/// 매수금액
		/// </summary>
		[XAQueryFieldAttribute("매수금액")]
		public long BuyAmt;
		/// <summary>
		/// 매수수수료
		/// </summary>
		[XAQueryFieldAttribute("매수수수료")]
		public long BuyCmsn;
		/// <summary>
		/// 체결세금
		/// </summary>
		[XAQueryFieldAttribute("체결세금")]
		public long ExecTax;
		/// <summary>
		/// 외화매수정산금액
		/// </summary>
		[XAQueryFieldAttribute("외화매수정산금액")]
		public double FcurrBuyAdjstAmt;

		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["MnyinAmt"] = new XAQueryFieldInfo("long", MnyinAmt, MnyinAmt.ToString("d16"), "입금금액", (decimal)16);
			dict["SecinAmt"] = new XAQueryFieldInfo("long", SecinAmt, SecinAmt.ToString("d16"), "입고금액", (decimal)16);
			dict["MnyoutAmt"] = new XAQueryFieldInfo("long", MnyoutAmt, MnyoutAmt.ToString("d16"), "출금금액", (decimal)16);
			dict["SecoutAmt"] = new XAQueryFieldInfo("long", SecoutAmt, SecoutAmt.ToString("d16"), "출고금액", (decimal)16);
			dict["DiffAmt"] = new XAQueryFieldInfo("long", DiffAmt, DiffAmt.ToString("d16"), "차이금액", (decimal)16);
			dict["DiffAmt0"] = new XAQueryFieldInfo("long", DiffAmt0, DiffAmt0.ToString("d16"), "차이금액0", (decimal)16);
			dict["SellQty"] = new XAQueryFieldInfo("long", SellQty, SellQty.ToString("d16"), "매도수량", (decimal)16);
			dict["SellAmt"] = new XAQueryFieldInfo("long", SellAmt, SellAmt.ToString("d16"), "매도금액", (decimal)16);
			dict["SellCmsn"] = new XAQueryFieldInfo("long", SellCmsn, SellCmsn.ToString("d16"), "매도수수료", (decimal)16);
			dict["EvrTax"] = new XAQueryFieldInfo("long", EvrTax, EvrTax.ToString("d19"), "제세금", (decimal)19);
			dict["FcurrSellAdjstAmt"] = new XAQueryFieldInfo("double", FcurrSellAdjstAmt, FcurrSellAdjstAmt.ToString("0000000000000000000000000.0000"), "외화매도정산금액", (decimal)25.4);
			dict["BuyQty"] = new XAQueryFieldInfo("long", BuyQty, BuyQty.ToString("d16"), "매수수량", (decimal)16);
			dict["BuyAmt"] = new XAQueryFieldInfo("long", BuyAmt, BuyAmt.ToString("d16"), "매수금액", (decimal)16);
			dict["BuyCmsn"] = new XAQueryFieldInfo("long", BuyCmsn, BuyCmsn.ToString("d16"), "매수수수료", (decimal)16);
			dict["ExecTax"] = new XAQueryFieldInfo("long", ExecTax, ExecTax.ToString("d16"), "체결세금", (decimal)16);
			dict["FcurrBuyAdjstAmt"] = new XAQueryFieldInfo("double", FcurrBuyAdjstAmt, FcurrBuyAdjstAmt.ToString("0000000000000000000000000.0000"), "외화매수정산금액", (decimal)25.4);

			return dict;
		}

		public static XQCDPCQ04700OutBlock5 FromQuery(XQCDPCQ04700 query)
		{
			XQCDPCQ04700OutBlock5 block = new XQCDPCQ04700OutBlock5();
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
				block.RecCnt = query.GetFieldData(block.GetBlockName(), "RecCnt", 0).ParseLong("RecCnt"); // long 5
				block.MnyinAmt = query.GetFieldData(block.GetBlockName(), "MnyinAmt", 0).ParseLong("MnyinAmt"); // long 16
				block.SecinAmt = query.GetFieldData(block.GetBlockName(), "SecinAmt", 0).ParseLong("SecinAmt"); // long 16
				block.MnyoutAmt = query.GetFieldData(block.GetBlockName(), "MnyoutAmt", 0).ParseLong("MnyoutAmt"); // long 16
				block.SecoutAmt = query.GetFieldData(block.GetBlockName(), "SecoutAmt", 0).ParseLong("SecoutAmt"); // long 16
				block.DiffAmt = query.GetFieldData(block.GetBlockName(), "DiffAmt", 0).ParseLong("DiffAmt"); // long 16
				block.DiffAmt0 = query.GetFieldData(block.GetBlockName(), "DiffAmt0", 0).ParseLong("DiffAmt0"); // long 16
				block.SellQty = query.GetFieldData(block.GetBlockName(), "SellQty", 0).ParseLong("SellQty"); // long 16
				block.SellAmt = query.GetFieldData(block.GetBlockName(), "SellAmt", 0).ParseLong("SellAmt"); // long 16
				block.SellCmsn = query.GetFieldData(block.GetBlockName(), "SellCmsn", 0).ParseLong("SellCmsn"); // long 16
				block.EvrTax = query.GetFieldData(block.GetBlockName(), "EvrTax", 0).ParseLong("EvrTax"); // long 19
				block.FcurrSellAdjstAmt = query.GetFieldData(block.GetBlockName(), "FcurrSellAdjstAmt", 0).ParseDouble("FcurrSellAdjstAmt"); // double 25.4
				block.BuyQty = query.GetFieldData(block.GetBlockName(), "BuyQty", 0).ParseLong("BuyQty"); // long 16
				block.BuyAmt = query.GetFieldData(block.GetBlockName(), "BuyAmt", 0).ParseLong("BuyAmt"); // long 16
				block.BuyCmsn = query.GetFieldData(block.GetBlockName(), "BuyCmsn", 0).ParseLong("BuyCmsn"); // long 16
				block.ExecTax = query.GetFieldData(block.GetBlockName(), "ExecTax", 0).ParseLong("ExecTax"); // long 16
				block.FcurrBuyAdjstAmt = query.GetFieldData(block.GetBlockName(), "FcurrBuyAdjstAmt", 0).ParseDouble("FcurrBuyAdjstAmt"); // double 25.4

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (RecCnt.ToString().Length > 5) return false; // long 5
			if (MnyinAmt.ToString().Length > 16) return false; // long 16
			if (SecinAmt.ToString().Length > 16) return false; // long 16
			if (MnyoutAmt.ToString().Length > 16) return false; // long 16
			if (SecoutAmt.ToString().Length > 16) return false; // long 16
			if (DiffAmt.ToString().Length > 16) return false; // long 16
			if (DiffAmt0.ToString().Length > 16) return false; // long 16
			if (SellQty.ToString().Length > 16) return false; // long 16
			if (SellAmt.ToString().Length > 16) return false; // long 16
			if (SellCmsn.ToString().Length > 16) return false; // long 16
			if (EvrTax.ToString().Length > 19) return false; // long 19
			// FcurrSellAdjstAmt double 25.4
			if (BuyQty.ToString().Length > 16) return false; // long 16
			if (BuyAmt.ToString().Length > 16) return false; // long 16
			if (BuyCmsn.ToString().Length > 16) return false; // long 16
			if (ExecTax.ToString().Length > 16) return false; // long 16
			// FcurrBuyAdjstAmt double 25.4

			return true;
		}
	}

	public partial class XQCDPCQ04700 : XingQuery
	{
		/// <summary>
		/// CDPCQ04700
		/// </summary>
		static readonly string _typeName = "CDPCQ04700";
		/// <summary>
		/// 계좌 거래내역
		/// </summary>
		static readonly string _typeDesc = "계좌 거래내역";
		/// <summary>
		/// CDPCQ04700
		/// </summary>
		static readonly string _service = "CDPCQ04700";
		/// <summary>
		/// B
		/// </summary>
		static readonly string _headType = "B";
		/// <summary>
		/// 류화숙
		/// </summary>
		static readonly string _creator = "류화숙";
		/// <summary>
		/// 2012/06/14 10:25:09
		/// </summary>
		static readonly string _createdDate = "2012/06/14 10:25:09";
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _attr = false;
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _block = false;
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _encrypt = false;
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _signature = false;

	/// <summary>
	/// CDPCQ04700
	/// </summary>
	public string TypeName => _typeName;
	/// <summary>
	/// 계좌 거래내역
	/// </summary>
	public string TypeDesc => _typeDesc;
	/// <summary>
	/// CDPCQ04700
	/// </summary>
	public string Service => _service;
	/// <summary>
	/// B
	/// </summary>
	public string HeadType => _headType;
	/// <summary>
	/// 류화숙
	/// </summary>
	public string Creator => _creator;
	/// <summary>
	/// 2012/06/14 10:25:09
	/// </summary>
	public string CreatedDate => _createdDate;
	/// <summary>
	/// false
	/// </summary>
	public bool Attr => _attr;
	/// <summary>
	/// false
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

		public XQCDPCQ04700() : base("CDPCQ04700") { }


		public bool SetFields(XQCDPCQ04700InBlock1 block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "RecCnt", 0, block.RecCnt.ToString("d5")); // long 5
			_xaQuery.SetFieldData(block.GetBlockName(), "QryTp", 0, block.QryTp.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "AcntNo", 0, block.AcntNo); // char 20
			_xaQuery.SetFieldData(block.GetBlockName(), "Pwd", 0, block.Pwd); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "QrySrtDt", 0, block.QrySrtDt); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "QryEndDt", 0, block.QryEndDt); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "SrtNo", 0, block.SrtNo.ToString("d10")); // long 10
			_xaQuery.SetFieldData(block.GetBlockName(), "PdptnCode", 0, block.PdptnCode); // char 2
			_xaQuery.SetFieldData(block.GetBlockName(), "IsuLgclssCode", 0, block.IsuLgclssCode); // char 2
			_xaQuery.SetFieldData(block.GetBlockName(), "IsuNo", 0, block.IsuNo); // char 12

			return true;
		}

		public XQCDPCQ04700OutBlock1 GetBlock1()
		{
			XQCDPCQ04700OutBlock1 instance = XQCDPCQ04700OutBlock1.FromQuery(this);
			return instance;

		}

		public XQCDPCQ04700OutBlock2 GetBlock2()
		{
			XQCDPCQ04700OutBlock2 instance = XQCDPCQ04700OutBlock2.FromQuery(this);
			return instance;

		}

		public XQCDPCQ04700OutBlock3 GetBlock3()
		{
			XQCDPCQ04700OutBlock3 instance = XQCDPCQ04700OutBlock3.FromQuery(this);
			return instance;

		}

		public XQCDPCQ04700OutBlock4 GetBlock4()
		{
			XQCDPCQ04700OutBlock4 instance = XQCDPCQ04700OutBlock4.FromQuery(this);
			return instance;

		}

		public XQCDPCQ04700OutBlock5 GetBlock5()
		{
			XQCDPCQ04700OutBlock5 instance = XQCDPCQ04700OutBlock5.FromQuery(this);
			return instance;

		}


	}

	public partial class XQChartExcelInBlock : XingBlock
	{
		/// <summary>
		/// ChartExcelInBlock
		/// </summary>
		static readonly string _blockName = "ChartExcelInBlock";
		/// <summary>
		/// In(*EMPTY*)
		/// </summary>
		static readonly string _blockDesc = "In(*EMPTY*)";
		/// <summary>
		/// input
		/// </summary>
		static readonly string _blockType = "input";
		/// <summary>
		/// ChartExcelInBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// ChartExcelInBlock
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// In(*EMPTY*)
		/// </summary>
		public string BlockDesc => _blockDesc;
		/// <summary>
		/// input
		/// </summary>
		public string BlockType => _blockType;

		/// <summary>
		/// 지표ID
		/// </summary>
		[XAQueryFieldAttribute("지표ID")]
		public long indexid;
		/// <summary>
		/// 지표명
		/// </summary>
		[XAQueryFieldAttribute("지표명")]
		public string indexname;
		/// <summary>
		/// 지표조건설정
		/// </summary>
		[XAQueryFieldAttribute("지표조건설정")]
		public string indexparam;
		/// <summary>
		/// 결과데이터 구분
		/// </summary>
		[XAQueryFieldAttribute("결과데이터 구분")]
		public char indexouttype;
		/// <summary>
		/// 시장구분
		/// </summary>
		[XAQueryFieldAttribute("시장구분")]
		public char market;
		/// <summary>
		/// 주기구분
		/// </summary>
		[XAQueryFieldAttribute("주기구분")]
		public char period;
		/// <summary>
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("단축코드")]
		public string shcode;
		/// <summary>
		/// 결과 지표데이터 엑셀표시 여부
		/// </summary>
		[XAQueryFieldAttribute("결과 지표데이터 엑셀표시 여부")]
		public char isexcelout;
		/// <summary>
		/// 엑셀데이터 파일명
		/// </summary>
		[XAQueryFieldAttribute("엑셀데이터 파일명")]
		public string excelfilename;
		/// <summary>
		/// 실시간 데이터수신 자동등록 여부
		/// </summary>
		[XAQueryFieldAttribute("실시간 데이터수신 자동등록 여부")]
		public char IsReal;

		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["indexid"] = new XAQueryFieldInfo("long", indexid, indexid.ToString("d10"), "지표ID", (decimal)10);
			dict["indexname"] = new XAQueryFieldInfo("char", indexname, indexname, "지표명", (decimal)40);
			dict["indexparam"] = new XAQueryFieldInfo("char", indexparam, indexparam, "지표조건설정", (decimal)40);
			dict["indexouttype"] = new XAQueryFieldInfo("char", indexouttype, indexouttype.ToString(), "결과데이터 구분", (decimal)1);
			dict["market"] = new XAQueryFieldInfo("char", market, market.ToString(), "시장구분", (decimal)1);
			dict["period"] = new XAQueryFieldInfo("char", period, period.ToString(), "주기구분", (decimal)1);
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)8);
			dict["isexcelout"] = new XAQueryFieldInfo("char", isexcelout, isexcelout.ToString(), "결과 지표데이터 엑셀표시 여부", (decimal)1);
			dict["excelfilename"] = new XAQueryFieldInfo("char", excelfilename, excelfilename, "엑셀데이터 파일명", (decimal)256);
			dict["IsReal"] = new XAQueryFieldInfo("char", IsReal, IsReal.ToString(), "실시간 데이터수신 자동등록 여부", (decimal)1);

			return dict;
		}

		public bool VerifyData()
		{
			if (indexid.ToString().Length > 10) return false; // long 10
			if (indexname.Length > 40) return false; // char 40
			if (indexparam.Length > 40) return false; // char 40
			// indexouttype char 1
			// market char 1
			// period char 1
			if (shcode.Length > 8) return false; // char 8
			// isexcelout char 1
			if (excelfilename.Length > 256) return false; // char 256
			// IsReal char 1

			return true;
		}
	}

	public partial class XQChartExcelOutBlock : XingBlock
	{
		/// <summary>
		/// ChartExcelOutBlock
		/// </summary>
		static readonly string _blockName = "ChartExcelOutBlock";
		/// <summary>
		/// Out(*EMPTY*)
		/// </summary>
		static readonly string _blockDesc = "Out(*EMPTY*)";
		/// <summary>
		/// output
		/// </summary>
		static readonly string _blockType = "output";
		/// <summary>
		/// ChartExcelOutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// ChartExcelOutBlock
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// Out(*EMPTY*)
		/// </summary>
		public string BlockDesc => _blockDesc;
		/// <summary>
		/// output
		/// </summary>
		public string BlockType => _blockType;

		/// <summary>
		/// 지표ID
		/// </summary>
		[XAQueryFieldAttribute("지표ID")]
		public long indexid;
		/// <summary>
		/// 레코드갯수
		/// </summary>
		[XAQueryFieldAttribute("레코드갯수")]
		public long rec_cnt;
		/// <summary>
		/// 유효 데이터 컬럼 갯수
		/// </summary>
		[XAQueryFieldAttribute("유효 데이터 컬럼 갯수")]
		public long validdata_cnt;

		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["indexid"] = new XAQueryFieldInfo("long", indexid, indexid.ToString("d10"), "지표ID", (decimal)10);
			dict["rec_cnt"] = new XAQueryFieldInfo("long", rec_cnt, rec_cnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["validdata_cnt"] = new XAQueryFieldInfo("long", validdata_cnt, validdata_cnt.ToString("d2"), "유효 데이터 컬럼 갯수", (decimal)2);

			return dict;
		}

		public static XQChartExcelOutBlock FromQuery(XQCHARTEXCEL query)
		{
			XQChartExcelOutBlock block = new XQChartExcelOutBlock();
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
				block.indexid = query.GetFieldData(block.GetBlockName(), "indexid", 0).ParseLong("indexid"); // long 10
				block.rec_cnt = query.GetFieldData(block.GetBlockName(), "rec_cnt", 0).ParseLong("rec_cnt"); // long 5
				block.validdata_cnt = query.GetFieldData(block.GetBlockName(), "validdata_cnt", 0).ParseLong("validdata_cnt"); // long 2

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (indexid.ToString().Length > 10) return false; // long 10
			if (rec_cnt.ToString().Length > 5) return false; // long 5
			if (validdata_cnt.ToString().Length > 2) return false; // long 2

			return true;
		}
	}

	public partial class XQChartExcelOutBlock1 : XingBlock
	{
		/// <summary>
		/// ChartExcelOutBlock1
		/// </summary>
		static readonly string _blockName = "ChartExcelOutBlock1";
		/// <summary>
		/// Out(*EMPTY*)
		/// </summary>
		static readonly string _blockDesc = "Out(*EMPTY*)";
		/// <summary>
		/// output
		/// </summary>
		static readonly string _blockType = "output";
		/// <summary>
		/// ChartExcelOutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// ChartExcelOutBlock1
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// Out(*EMPTY*)
		/// </summary>
		public string BlockDesc => _blockDesc;
		/// <summary>
		/// output
		/// </summary>
		public string BlockType => _blockType;

		/// <summary>
		/// 일자
		/// </summary>
		[XAQueryFieldAttribute("일자")]
		public string date;
		/// <summary>
		/// 시간
		/// </summary>
		[XAQueryFieldAttribute("시간")]
		public string time;
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
		/// 종가
		/// </summary>
		[XAQueryFieldAttribute("종가")]
		public float close;
		/// <summary>
		/// 거래량
		/// </summary>
		[XAQueryFieldAttribute("거래량")]
		public float volume;
		/// <summary>
		/// 지표값1
		/// </summary>
		[XAQueryFieldAttribute("지표값1")]
		public float value1;
		/// <summary>
		/// 지표값2
		/// </summary>
		[XAQueryFieldAttribute("지표값2")]
		public float value2;
		/// <summary>
		/// 지표값3
		/// </summary>
		[XAQueryFieldAttribute("지표값3")]
		public float value3;
		/// <summary>
		/// 지표값4
		/// </summary>
		[XAQueryFieldAttribute("지표값4")]
		public float value4;
		/// <summary>
		/// 지표값5
		/// </summary>
		[XAQueryFieldAttribute("지표값5")]
		public float value5;
		/// <summary>
		/// 위치
		/// </summary>
		[XAQueryFieldAttribute("위치")]
		public long pos;

		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["date"] = new XAQueryFieldInfo("char", date, date, "일자", (decimal)8);
			dict["time"] = new XAQueryFieldInfo("char", time, time, "시간", (decimal)6);
			dict["open"] = new XAQueryFieldInfo("float", open, open.ToString("0000000000"), "시가", (decimal)10);
			dict["high"] = new XAQueryFieldInfo("float", high, high.ToString("0000000000"), "고가", (decimal)10);
			dict["low"] = new XAQueryFieldInfo("float", low, low.ToString("0000000000"), "저가", (decimal)10);
			dict["close"] = new XAQueryFieldInfo("float", close, close.ToString("0000000000"), "종가", (decimal)10);
			dict["volume"] = new XAQueryFieldInfo("float", volume, volume.ToString("000000000000"), "거래량", (decimal)12);
			dict["value1"] = new XAQueryFieldInfo("float", value1, value1.ToString("0000000000"), "지표값1", (decimal)10);
			dict["value2"] = new XAQueryFieldInfo("float", value2, value2.ToString("0000000000"), "지표값2", (decimal)10);
			dict["value3"] = new XAQueryFieldInfo("float", value3, value3.ToString("0000000000"), "지표값3", (decimal)10);
			dict["value4"] = new XAQueryFieldInfo("float", value4, value4.ToString("0000000000"), "지표값4", (decimal)10);
			dict["value5"] = new XAQueryFieldInfo("float", value5, value5.ToString("0000000000"), "지표값5", (decimal)10);
			dict["pos"] = new XAQueryFieldInfo("long", pos, pos.ToString("d8"), "위치", (decimal)8);

			return dict;
		}

		public static XQChartExcelOutBlock1 FromQuery(XQCHARTEXCEL query)
		{
			XQChartExcelOutBlock1 block = new XQChartExcelOutBlock1();
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
				block.date = query.GetFieldData(block.GetBlockName(), "date", 0); // char 8
				block.time = query.GetFieldData(block.GetBlockName(), "time", 0); // char 6
				block.open = query.GetFieldData(block.GetBlockName(), "open", 0).ParseFloat("open"); // float 10
				block.high = query.GetFieldData(block.GetBlockName(), "high", 0).ParseFloat("high"); // float 10
				block.low = query.GetFieldData(block.GetBlockName(), "low", 0).ParseFloat("low"); // float 10
				block.close = query.GetFieldData(block.GetBlockName(), "close", 0).ParseFloat("close"); // float 10
				block.volume = query.GetFieldData(block.GetBlockName(), "volume", 0).ParseFloat("volume"); // float 12
				block.value1 = query.GetFieldData(block.GetBlockName(), "value1", 0).ParseFloat("value1"); // float 10
				block.value2 = query.GetFieldData(block.GetBlockName(), "value2", 0).ParseFloat("value2"); // float 10
				block.value3 = query.GetFieldData(block.GetBlockName(), "value3", 0).ParseFloat("value3"); // float 10
				block.value4 = query.GetFieldData(block.GetBlockName(), "value4", 0).ParseFloat("value4"); // float 10
				block.value5 = query.GetFieldData(block.GetBlockName(), "value5", 0).ParseFloat("value5"); // float 10
				block.pos = query.GetFieldData(block.GetBlockName(), "pos", 0).ParseLong("pos"); // long 8

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (date.Length > 8) return false; // char 8
			if (time.Length > 6) return false; // char 6
			// open float 10
			// high float 10
			// low float 10
			// close float 10
			// volume float 12
			// value1 float 10
			// value2 float 10
			// value3 float 10
			// value4 float 10
			// value5 float 10
			if (pos.ToString().Length > 8) return false; // long 8

			return true;
		}
	}

	public partial class XQCHARTEXCEL : XingQuery
	{
		/// <summary>
		/// CHARTEXCEL
		/// </summary>
		static readonly string _typeName = "CHARTEXCEL";
		/// <summary>
		/// 챠트엑셀데이터조회
		/// </summary>
		static readonly string _typeDesc = "챠트엑셀데이터조회";
		/// <summary>
		/// 
		/// </summary>
		static readonly string _service = "";
		/// <summary>
		/// B
		/// </summary>
		static readonly string _headType = "B";
		/// <summary>
		/// 
		/// </summary>
		static readonly string _creator = "";
		/// <summary>
		/// 
		/// </summary>
		static readonly string _createdDate = "";
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _attr = false;
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _block = false;
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _encrypt = false;
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _signature = false;

	/// <summary>
	/// CHARTEXCEL
	/// </summary>
	public string TypeName => _typeName;
	/// <summary>
	/// 챠트엑셀데이터조회
	/// </summary>
	public string TypeDesc => _typeDesc;
	/// <summary>
	/// 
	/// </summary>
	public string Service => _service;
	/// <summary>
	/// B
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
	/// false
	/// </summary>
	public bool Attr => _attr;
	/// <summary>
	/// false
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

		public XQCHARTEXCEL() : base("CHARTEXCEL") { }


		public bool SetFields(XQChartExcelInBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "indexid", 0, block.indexid.ToString("d10")); // long 10
			_xaQuery.SetFieldData(block.GetBlockName(), "indexname", 0, block.indexname); // char 40
			_xaQuery.SetFieldData(block.GetBlockName(), "indexparam", 0, block.indexparam); // char 40
			_xaQuery.SetFieldData(block.GetBlockName(), "indexouttype", 0, block.indexouttype.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "market", 0, block.market.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "period", 0, block.period.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "shcode", 0, block.shcode); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "isexcelout", 0, block.isexcelout.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "excelfilename", 0, block.excelfilename); // char 256
			_xaQuery.SetFieldData(block.GetBlockName(), "IsReal", 0, block.IsReal.ToString()); // char 1

			return true;
		}

		public XQChartExcelOutBlock GetBlock()
		{
			XQChartExcelOutBlock instance = XQChartExcelOutBlock.FromQuery(this);
			return instance;

		}

		public XQChartExcelOutBlock1 GetBlock1()
		{
			XQChartExcelOutBlock1 instance = XQChartExcelOutBlock1.FromQuery(this);
			return instance;

		}


	}

	public partial class XQCSPAT00600InBlock1 : XingBlock
	{
		/// <summary>
		/// CSPAT00600InBlock1
		/// </summary>
		static readonly string _blockName = "CSPAT00600InBlock1";
		/// <summary>
		/// In(*EMPTY*)
		/// </summary>
		static readonly string _blockDesc = "In(*EMPTY*)";
		/// <summary>
		/// input
		/// </summary>
		static readonly string _blockType = "input";
		/// <summary>
		/// CSPAT00600InBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CSPAT00600InBlock1
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// In(*EMPTY*)
		/// </summary>
		public string BlockDesc => _blockDesc;
		/// <summary>
		/// input
		/// </summary>
		public string BlockType => _blockType;

		/// <summary>
		/// 계좌번호
		/// </summary>
		[XAQueryFieldAttribute("계좌번호")]
		public string AcntNo;
		/// <summary>
		/// 입력비밀번호
		/// </summary>
		[XAQueryFieldAttribute("입력비밀번호")]
		public string InptPwd;
		/// <summary>
		/// 종목번호
		/// </summary>
		[XAQueryFieldAttribute("종목번호")]
		public string IsuNo;
		/// <summary>
		/// 주문수량
		/// </summary>
		[XAQueryFieldAttribute("주문수량")]
		public long OrdQty;
		/// <summary>
		/// 주문가
		/// </summary>
		[XAQueryFieldAttribute("주문가")]
		public double OrdPrc;
		/// <summary>
		/// 매매구분
		/// </summary>
		[XAQueryFieldAttribute("매매구분")]
		public char BnsTpCode;
		/// <summary>
		/// 호가유형코드
		/// </summary>
		[XAQueryFieldAttribute("호가유형코드")]
		public string OrdprcPtnCode;
		/// <summary>
		/// 신용거래코드
		/// </summary>
		[XAQueryFieldAttribute("신용거래코드")]
		public string MgntrnCode;
		/// <summary>
		/// 대출일
		/// </summary>
		[XAQueryFieldAttribute("대출일")]
		public string LoanDt;
		/// <summary>
		/// 주문조건구분
		/// </summary>
		[XAQueryFieldAttribute("주문조건구분")]
		public char OrdCndiTpCode;

		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["AcntNo"] = new XAQueryFieldInfo("char", AcntNo, AcntNo, "계좌번호", (decimal)20);
			dict["InptPwd"] = new XAQueryFieldInfo("char", InptPwd, InptPwd, "입력비밀번호", (decimal)8);
			dict["IsuNo"] = new XAQueryFieldInfo("char", IsuNo, IsuNo, "종목번호", (decimal)12);
			dict["OrdQty"] = new XAQueryFieldInfo("long", OrdQty, OrdQty.ToString("d16"), "주문수량", (decimal)16);
			dict["OrdPrc"] = new XAQueryFieldInfo("double", OrdPrc, OrdPrc.ToString("0000000000000.00"), "주문가", (decimal)13.2);
			dict["BnsTpCode"] = new XAQueryFieldInfo("char", BnsTpCode, BnsTpCode.ToString(), "매매구분", (decimal)1);
			dict["OrdprcPtnCode"] = new XAQueryFieldInfo("char", OrdprcPtnCode, OrdprcPtnCode, "호가유형코드", (decimal)2);
			dict["MgntrnCode"] = new XAQueryFieldInfo("char", MgntrnCode, MgntrnCode, "신용거래코드", (decimal)3);
			dict["LoanDt"] = new XAQueryFieldInfo("char", LoanDt, LoanDt, "대출일", (decimal)8);
			dict["OrdCndiTpCode"] = new XAQueryFieldInfo("char", OrdCndiTpCode, OrdCndiTpCode.ToString(), "주문조건구분", (decimal)1);

			return dict;
		}

		public bool VerifyData()
		{
			if (AcntNo.Length > 20) return false; // char 20
			if (InptPwd.Length > 8) return false; // char 8
			if (IsuNo.Length > 12) return false; // char 12
			if (OrdQty.ToString().Length > 16) return false; // long 16
			// OrdPrc double 13.2
			// BnsTpCode char 1
			if (OrdprcPtnCode.Length > 2) return false; // char 2
			if (MgntrnCode.Length > 3) return false; // char 3
			if (LoanDt.Length > 8) return false; // char 8
			// OrdCndiTpCode char 1

			return true;
		}
	}

	public partial class XQCSPAT00600OutBlock1 : XingBlock
	{
		/// <summary>
		/// CSPAT00600OutBlock1
		/// </summary>
		static readonly string _blockName = "CSPAT00600OutBlock1";
		/// <summary>
		/// In(*EMPTY*)
		/// </summary>
		static readonly string _blockDesc = "In(*EMPTY*)";
		/// <summary>
		/// output
		/// </summary>
		static readonly string _blockType = "output";
		/// <summary>
		/// CSPAT00600OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CSPAT00600OutBlock1
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// In(*EMPTY*)
		/// </summary>
		public string BlockDesc => _blockDesc;
		/// <summary>
		/// output
		/// </summary>
		public string BlockType => _blockType;

		/// <summary>
		/// 레코드갯수
		/// </summary>
		[XAQueryFieldAttribute("레코드갯수")]
		public long RecCnt;
		/// <summary>
		/// 계좌번호
		/// </summary>
		[XAQueryFieldAttribute("계좌번호")]
		public string AcntNo;
		/// <summary>
		/// 입력비밀번호
		/// </summary>
		[XAQueryFieldAttribute("입력비밀번호")]
		public string InptPwd;
		/// <summary>
		/// 종목번호
		/// </summary>
		[XAQueryFieldAttribute("종목번호")]
		public string IsuNo;
		/// <summary>
		/// 주문수량
		/// </summary>
		[XAQueryFieldAttribute("주문수량")]
		public long OrdQty;
		/// <summary>
		/// 주문가
		/// </summary>
		[XAQueryFieldAttribute("주문가")]
		public double OrdPrc;
		/// <summary>
		/// 매매구분
		/// </summary>
		[XAQueryFieldAttribute("매매구분")]
		public char BnsTpCode;
		/// <summary>
		/// 호가유형코드
		/// </summary>
		[XAQueryFieldAttribute("호가유형코드")]
		public string OrdprcPtnCode;
		/// <summary>
		/// 프로그램호가유형코드
		/// </summary>
		[XAQueryFieldAttribute("프로그램호가유형코드")]
		public string PrgmOrdprcPtnCode;
		/// <summary>
		/// 공매도가능여부
		/// </summary>
		[XAQueryFieldAttribute("공매도가능여부")]
		public char StslAbleYn;
		/// <summary>
		/// 공매도호가구분
		/// </summary>
		[XAQueryFieldAttribute("공매도호가구분")]
		public char StslOrdprcTpCode;
		/// <summary>
		/// 통신매체코드
		/// </summary>
		[XAQueryFieldAttribute("통신매체코드")]
		public string CommdaCode;
		/// <summary>
		/// 신용거래코드
		/// </summary>
		[XAQueryFieldAttribute("신용거래코드")]
		public string MgntrnCode;
		/// <summary>
		/// 대출일
		/// </summary>
		[XAQueryFieldAttribute("대출일")]
		public string LoanDt;
		/// <summary>
		/// 회원번호
		/// </summary>
		[XAQueryFieldAttribute("회원번호")]
		public string MbrNo;
		/// <summary>
		/// 주문조건구분
		/// </summary>
		[XAQueryFieldAttribute("주문조건구분")]
		public char OrdCndiTpCode;
		/// <summary>
		/// 전략코드
		/// </summary>
		[XAQueryFieldAttribute("전략코드")]
		public string StrtgCode;
		/// <summary>
		/// 그룹ID
		/// </summary>
		[XAQueryFieldAttribute("그룹ID")]
		public string GrpId;
		/// <summary>
		/// 주문회차
		/// </summary>
		[XAQueryFieldAttribute("주문회차")]
		public long OrdSeqNo;
		/// <summary>
		/// 포트폴리오번호
		/// </summary>
		[XAQueryFieldAttribute("포트폴리오번호")]
		public long PtflNo;
		/// <summary>
		/// 바스켓번호
		/// </summary>
		[XAQueryFieldAttribute("바스켓번호")]
		public long BskNo;
		/// <summary>
		/// 트렌치번호
		/// </summary>
		[XAQueryFieldAttribute("트렌치번호")]
		public long TrchNo;
		/// <summary>
		/// 아이템번호
		/// </summary>
		[XAQueryFieldAttribute("아이템번호")]
		public long ItemNo;
		/// <summary>
		/// 운용지시번호
		/// </summary>
		[XAQueryFieldAttribute("운용지시번호")]
		public string OpDrtnNo;
		/// <summary>
		/// 유동성공급자여부
		/// </summary>
		[XAQueryFieldAttribute("유동성공급자여부")]
		public char LpYn;
		/// <summary>
		/// 반대매매구분
		/// </summary>
		[XAQueryFieldAttribute("반대매매구분")]
		public char CvrgTpCode;

		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["AcntNo"] = new XAQueryFieldInfo("char", AcntNo, AcntNo, "계좌번호", (decimal)20);
			dict["InptPwd"] = new XAQueryFieldInfo("char", InptPwd, InptPwd, "입력비밀번호", (decimal)8);
			dict["IsuNo"] = new XAQueryFieldInfo("char", IsuNo, IsuNo, "종목번호", (decimal)12);
			dict["OrdQty"] = new XAQueryFieldInfo("long", OrdQty, OrdQty.ToString("d16"), "주문수량", (decimal)16);
			dict["OrdPrc"] = new XAQueryFieldInfo("double", OrdPrc, OrdPrc.ToString("0000000000000.00"), "주문가", (decimal)13.2);
			dict["BnsTpCode"] = new XAQueryFieldInfo("char", BnsTpCode, BnsTpCode.ToString(), "매매구분", (decimal)1);
			dict["OrdprcPtnCode"] = new XAQueryFieldInfo("char", OrdprcPtnCode, OrdprcPtnCode, "호가유형코드", (decimal)2);
			dict["PrgmOrdprcPtnCode"] = new XAQueryFieldInfo("char", PrgmOrdprcPtnCode, PrgmOrdprcPtnCode, "프로그램호가유형코드", (decimal)2);
			dict["StslAbleYn"] = new XAQueryFieldInfo("char", StslAbleYn, StslAbleYn.ToString(), "공매도가능여부", (decimal)1);
			dict["StslOrdprcTpCode"] = new XAQueryFieldInfo("char", StslOrdprcTpCode, StslOrdprcTpCode.ToString(), "공매도호가구분", (decimal)1);
			dict["CommdaCode"] = new XAQueryFieldInfo("char", CommdaCode, CommdaCode, "통신매체코드", (decimal)2);
			dict["MgntrnCode"] = new XAQueryFieldInfo("char", MgntrnCode, MgntrnCode, "신용거래코드", (decimal)3);
			dict["LoanDt"] = new XAQueryFieldInfo("char", LoanDt, LoanDt, "대출일", (decimal)8);
			dict["MbrNo"] = new XAQueryFieldInfo("char", MbrNo, MbrNo, "회원번호", (decimal)3);
			dict["OrdCndiTpCode"] = new XAQueryFieldInfo("char", OrdCndiTpCode, OrdCndiTpCode.ToString(), "주문조건구분", (decimal)1);
			dict["StrtgCode"] = new XAQueryFieldInfo("char", StrtgCode, StrtgCode, "전략코드", (decimal)6);
			dict["GrpId"] = new XAQueryFieldInfo("char", GrpId, GrpId, "그룹ID", (decimal)20);
			dict["OrdSeqNo"] = new XAQueryFieldInfo("long", OrdSeqNo, OrdSeqNo.ToString("d10"), "주문회차", (decimal)10);
			dict["PtflNo"] = new XAQueryFieldInfo("long", PtflNo, PtflNo.ToString("d10"), "포트폴리오번호", (decimal)10);
			dict["BskNo"] = new XAQueryFieldInfo("long", BskNo, BskNo.ToString("d10"), "바스켓번호", (decimal)10);
			dict["TrchNo"] = new XAQueryFieldInfo("long", TrchNo, TrchNo.ToString("d10"), "트렌치번호", (decimal)10);
			dict["ItemNo"] = new XAQueryFieldInfo("long", ItemNo, ItemNo.ToString("d10"), "아이템번호", (decimal)10);
			dict["OpDrtnNo"] = new XAQueryFieldInfo("char", OpDrtnNo, OpDrtnNo, "운용지시번호", (decimal)12);
			dict["LpYn"] = new XAQueryFieldInfo("char", LpYn, LpYn.ToString(), "유동성공급자여부", (decimal)1);
			dict["CvrgTpCode"] = new XAQueryFieldInfo("char", CvrgTpCode, CvrgTpCode.ToString(), "반대매매구분", (decimal)1);

			return dict;
		}

		public static XQCSPAT00600OutBlock1 FromQuery(XQCSPAT00600 query)
		{
			XQCSPAT00600OutBlock1 block = new XQCSPAT00600OutBlock1();
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
				block.RecCnt = query.GetFieldData(block.GetBlockName(), "RecCnt", 0).ParseLong("RecCnt"); // long 5
				block.AcntNo = query.GetFieldData(block.GetBlockName(), "AcntNo", 0); // char 20
				block.InptPwd = query.GetFieldData(block.GetBlockName(), "InptPwd", 0); // char 8
				block.IsuNo = query.GetFieldData(block.GetBlockName(), "IsuNo", 0); // char 12
				block.OrdQty = query.GetFieldData(block.GetBlockName(), "OrdQty", 0).ParseLong("OrdQty"); // long 16
				block.OrdPrc = query.GetFieldData(block.GetBlockName(), "OrdPrc", 0).ParseDouble("OrdPrc"); // double 13.2
				block.BnsTpCode = query.GetFieldData(block.GetBlockName(), "BnsTpCode", 0).First(); // char 1
				block.OrdprcPtnCode = query.GetFieldData(block.GetBlockName(), "OrdprcPtnCode", 0); // char 2
				block.PrgmOrdprcPtnCode = query.GetFieldData(block.GetBlockName(), "PrgmOrdprcPtnCode", 0); // char 2
				block.StslAbleYn = query.GetFieldData(block.GetBlockName(), "StslAbleYn", 0).First(); // char 1
				block.StslOrdprcTpCode = query.GetFieldData(block.GetBlockName(), "StslOrdprcTpCode", 0).First(); // char 1
				block.CommdaCode = query.GetFieldData(block.GetBlockName(), "CommdaCode", 0); // char 2
				block.MgntrnCode = query.GetFieldData(block.GetBlockName(), "MgntrnCode", 0); // char 3
				block.LoanDt = query.GetFieldData(block.GetBlockName(), "LoanDt", 0); // char 8
				block.MbrNo = query.GetFieldData(block.GetBlockName(), "MbrNo", 0); // char 3
				block.OrdCndiTpCode = query.GetFieldData(block.GetBlockName(), "OrdCndiTpCode", 0).First(); // char 1
				block.StrtgCode = query.GetFieldData(block.GetBlockName(), "StrtgCode", 0); // char 6
				block.GrpId = query.GetFieldData(block.GetBlockName(), "GrpId", 0); // char 20
				block.OrdSeqNo = query.GetFieldData(block.GetBlockName(), "OrdSeqNo", 0).ParseLong("OrdSeqNo"); // long 10
				block.PtflNo = query.GetFieldData(block.GetBlockName(), "PtflNo", 0).ParseLong("PtflNo"); // long 10
				block.BskNo = query.GetFieldData(block.GetBlockName(), "BskNo", 0).ParseLong("BskNo"); // long 10
				block.TrchNo = query.GetFieldData(block.GetBlockName(), "TrchNo", 0).ParseLong("TrchNo"); // long 10
				block.ItemNo = query.GetFieldData(block.GetBlockName(), "ItemNo", 0).ParseLong("ItemNo"); // long 10
				block.OpDrtnNo = query.GetFieldData(block.GetBlockName(), "OpDrtnNo", 0); // char 12
				block.LpYn = query.GetFieldData(block.GetBlockName(), "LpYn", 0).First(); // char 1
				block.CvrgTpCode = query.GetFieldData(block.GetBlockName(), "CvrgTpCode", 0).First(); // char 1

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (RecCnt.ToString().Length > 5) return false; // long 5
			if (AcntNo.Length > 20) return false; // char 20
			if (InptPwd.Length > 8) return false; // char 8
			if (IsuNo.Length > 12) return false; // char 12
			if (OrdQty.ToString().Length > 16) return false; // long 16
			// OrdPrc double 13.2
			// BnsTpCode char 1
			if (OrdprcPtnCode.Length > 2) return false; // char 2
			if (PrgmOrdprcPtnCode.Length > 2) return false; // char 2
			// StslAbleYn char 1
			// StslOrdprcTpCode char 1
			if (CommdaCode.Length > 2) return false; // char 2
			if (MgntrnCode.Length > 3) return false; // char 3
			if (LoanDt.Length > 8) return false; // char 8
			if (MbrNo.Length > 3) return false; // char 3
			// OrdCndiTpCode char 1
			if (StrtgCode.Length > 6) return false; // char 6
			if (GrpId.Length > 20) return false; // char 20
			if (OrdSeqNo.ToString().Length > 10) return false; // long 10
			if (PtflNo.ToString().Length > 10) return false; // long 10
			if (BskNo.ToString().Length > 10) return false; // long 10
			if (TrchNo.ToString().Length > 10) return false; // long 10
			if (ItemNo.ToString().Length > 10) return false; // long 10
			if (OpDrtnNo.Length > 12) return false; // char 12
			// LpYn char 1
			// CvrgTpCode char 1

			return true;
		}
	}

	public partial class XQCSPAT00600OutBlock2 : XingBlock
	{
		/// <summary>
		/// CSPAT00600OutBlock2
		/// </summary>
		static readonly string _blockName = "CSPAT00600OutBlock2";
		/// <summary>
		/// Out(*EMPTY*)
		/// </summary>
		static readonly string _blockDesc = "Out(*EMPTY*)";
		/// <summary>
		/// output
		/// </summary>
		static readonly string _blockType = "output";
		/// <summary>
		/// CSPAT00600OutBlock2
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CSPAT00600OutBlock2
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// Out(*EMPTY*)
		/// </summary>
		public string BlockDesc => _blockDesc;
		/// <summary>
		/// output
		/// </summary>
		public string BlockType => _blockType;

		/// <summary>
		/// 레코드갯수
		/// </summary>
		[XAQueryFieldAttribute("레코드갯수")]
		public long RecCnt;
		/// <summary>
		/// 주문번호
		/// </summary>
		[XAQueryFieldAttribute("주문번호")]
		public long OrdNo;
		/// <summary>
		/// 주문시각
		/// </summary>
		[XAQueryFieldAttribute("주문시각")]
		public string OrdTime;
		/// <summary>
		/// 주문시장코드
		/// </summary>
		[XAQueryFieldAttribute("주문시장코드")]
		public string OrdMktCode;
		/// <summary>
		/// 주문유형코드
		/// </summary>
		[XAQueryFieldAttribute("주문유형코드")]
		public string OrdPtnCode;
		/// <summary>
		/// 단축종목번호
		/// </summary>
		[XAQueryFieldAttribute("단축종목번호")]
		public string ShtnIsuNo;
		/// <summary>
		/// 관리사원번호
		/// </summary>
		[XAQueryFieldAttribute("관리사원번호")]
		public string MgempNo;
		/// <summary>
		/// 주문금액
		/// </summary>
		[XAQueryFieldAttribute("주문금액")]
		public long OrdAmt;
		/// <summary>
		/// 예비주문번호
		/// </summary>
		[XAQueryFieldAttribute("예비주문번호")]
		public long SpareOrdNo;
		/// <summary>
		/// 반대매매일련번호
		/// </summary>
		[XAQueryFieldAttribute("반대매매일련번호")]
		public long CvrgSeqno;
		/// <summary>
		/// 예약주문번호
		/// </summary>
		[XAQueryFieldAttribute("예약주문번호")]
		public long RsvOrdNo;
		/// <summary>
		/// 실물주문수량
		/// </summary>
		[XAQueryFieldAttribute("실물주문수량")]
		public long SpotOrdQty;
		/// <summary>
		/// 재사용주문수량
		/// </summary>
		[XAQueryFieldAttribute("재사용주문수량")]
		public long RuseOrdQty;
		/// <summary>
		/// 현금주문금액
		/// </summary>
		[XAQueryFieldAttribute("현금주문금액")]
		public long MnyOrdAmt;
		/// <summary>
		/// 대용주문금액
		/// </summary>
		[XAQueryFieldAttribute("대용주문금액")]
		public long SubstOrdAmt;
		/// <summary>
		/// 재사용주문금액
		/// </summary>
		[XAQueryFieldAttribute("재사용주문금액")]
		public long RuseOrdAmt;
		/// <summary>
		/// 계좌명
		/// </summary>
		[XAQueryFieldAttribute("계좌명")]
		public string AcntNm;
		/// <summary>
		/// 종목명
		/// </summary>
		[XAQueryFieldAttribute("종목명")]
		public string IsuNm;

		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["OrdNo"] = new XAQueryFieldInfo("long", OrdNo, OrdNo.ToString("d10"), "주문번호", (decimal)10);
			dict["OrdTime"] = new XAQueryFieldInfo("char", OrdTime, OrdTime, "주문시각", (decimal)9);
			dict["OrdMktCode"] = new XAQueryFieldInfo("char", OrdMktCode, OrdMktCode, "주문시장코드", (decimal)2);
			dict["OrdPtnCode"] = new XAQueryFieldInfo("char", OrdPtnCode, OrdPtnCode, "주문유형코드", (decimal)2);
			dict["ShtnIsuNo"] = new XAQueryFieldInfo("char", ShtnIsuNo, ShtnIsuNo, "단축종목번호", (decimal)9);
			dict["MgempNo"] = new XAQueryFieldInfo("char", MgempNo, MgempNo, "관리사원번호", (decimal)9);
			dict["OrdAmt"] = new XAQueryFieldInfo("long", OrdAmt, OrdAmt.ToString("d16"), "주문금액", (decimal)16);
			dict["SpareOrdNo"] = new XAQueryFieldInfo("long", SpareOrdNo, SpareOrdNo.ToString("d10"), "예비주문번호", (decimal)10);
			dict["CvrgSeqno"] = new XAQueryFieldInfo("long", CvrgSeqno, CvrgSeqno.ToString("d10"), "반대매매일련번호", (decimal)10);
			dict["RsvOrdNo"] = new XAQueryFieldInfo("long", RsvOrdNo, RsvOrdNo.ToString("d10"), "예약주문번호", (decimal)10);
			dict["SpotOrdQty"] = new XAQueryFieldInfo("long", SpotOrdQty, SpotOrdQty.ToString("d16"), "실물주문수량", (decimal)16);
			dict["RuseOrdQty"] = new XAQueryFieldInfo("long", RuseOrdQty, RuseOrdQty.ToString("d16"), "재사용주문수량", (decimal)16);
			dict["MnyOrdAmt"] = new XAQueryFieldInfo("long", MnyOrdAmt, MnyOrdAmt.ToString("d16"), "현금주문금액", (decimal)16);
			dict["SubstOrdAmt"] = new XAQueryFieldInfo("long", SubstOrdAmt, SubstOrdAmt.ToString("d16"), "대용주문금액", (decimal)16);
			dict["RuseOrdAmt"] = new XAQueryFieldInfo("long", RuseOrdAmt, RuseOrdAmt.ToString("d16"), "재사용주문금액", (decimal)16);
			dict["AcntNm"] = new XAQueryFieldInfo("char", AcntNm, AcntNm, "계좌명", (decimal)40);
			dict["IsuNm"] = new XAQueryFieldInfo("char", IsuNm, IsuNm, "종목명", (decimal)40);

			return dict;
		}

		public static XQCSPAT00600OutBlock2 FromQuery(XQCSPAT00600 query)
		{
			XQCSPAT00600OutBlock2 block = new XQCSPAT00600OutBlock2();
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
				block.RecCnt = query.GetFieldData(block.GetBlockName(), "RecCnt", 0).ParseLong("RecCnt"); // long 5
				block.OrdNo = query.GetFieldData(block.GetBlockName(), "OrdNo", 0).ParseLong("OrdNo"); // long 10
				block.OrdTime = query.GetFieldData(block.GetBlockName(), "OrdTime", 0); // char 9
				block.OrdMktCode = query.GetFieldData(block.GetBlockName(), "OrdMktCode", 0); // char 2
				block.OrdPtnCode = query.GetFieldData(block.GetBlockName(), "OrdPtnCode", 0); // char 2
				block.ShtnIsuNo = query.GetFieldData(block.GetBlockName(), "ShtnIsuNo", 0); // char 9
				block.MgempNo = query.GetFieldData(block.GetBlockName(), "MgempNo", 0); // char 9
				block.OrdAmt = query.GetFieldData(block.GetBlockName(), "OrdAmt", 0).ParseLong("OrdAmt"); // long 16
				block.SpareOrdNo = query.GetFieldData(block.GetBlockName(), "SpareOrdNo", 0).ParseLong("SpareOrdNo"); // long 10
				block.CvrgSeqno = query.GetFieldData(block.GetBlockName(), "CvrgSeqno", 0).ParseLong("CvrgSeqno"); // long 10
				block.RsvOrdNo = query.GetFieldData(block.GetBlockName(), "RsvOrdNo", 0).ParseLong("RsvOrdNo"); // long 10
				block.SpotOrdQty = query.GetFieldData(block.GetBlockName(), "SpotOrdQty", 0).ParseLong("SpotOrdQty"); // long 16
				block.RuseOrdQty = query.GetFieldData(block.GetBlockName(), "RuseOrdQty", 0).ParseLong("RuseOrdQty"); // long 16
				block.MnyOrdAmt = query.GetFieldData(block.GetBlockName(), "MnyOrdAmt", 0).ParseLong("MnyOrdAmt"); // long 16
				block.SubstOrdAmt = query.GetFieldData(block.GetBlockName(), "SubstOrdAmt", 0).ParseLong("SubstOrdAmt"); // long 16
				block.RuseOrdAmt = query.GetFieldData(block.GetBlockName(), "RuseOrdAmt", 0).ParseLong("RuseOrdAmt"); // long 16
				block.AcntNm = query.GetFieldData(block.GetBlockName(), "AcntNm", 0); // char 40
				block.IsuNm = query.GetFieldData(block.GetBlockName(), "IsuNm", 0); // char 40

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (RecCnt.ToString().Length > 5) return false; // long 5
			if (OrdNo.ToString().Length > 10) return false; // long 10
			if (OrdTime.Length > 9) return false; // char 9
			if (OrdMktCode.Length > 2) return false; // char 2
			if (OrdPtnCode.Length > 2) return false; // char 2
			if (ShtnIsuNo.Length > 9) return false; // char 9
			if (MgempNo.Length > 9) return false; // char 9
			if (OrdAmt.ToString().Length > 16) return false; // long 16
			if (SpareOrdNo.ToString().Length > 10) return false; // long 10
			if (CvrgSeqno.ToString().Length > 10) return false; // long 10
			if (RsvOrdNo.ToString().Length > 10) return false; // long 10
			if (SpotOrdQty.ToString().Length > 16) return false; // long 16
			if (RuseOrdQty.ToString().Length > 16) return false; // long 16
			if (MnyOrdAmt.ToString().Length > 16) return false; // long 16
			if (SubstOrdAmt.ToString().Length > 16) return false; // long 16
			if (RuseOrdAmt.ToString().Length > 16) return false; // long 16
			if (AcntNm.Length > 40) return false; // char 40
			if (IsuNm.Length > 40) return false; // char 40

			return true;
		}
	}

	public partial class XQCSPAT00600 : XingQuery
	{
		/// <summary>
		/// CSPAT00600
		/// </summary>
		static readonly string _typeName = "CSPAT00600";
		/// <summary>
		/// 현물주문
		/// </summary>
		static readonly string _typeDesc = "현물주문";
		/// <summary>
		/// CSPAT00600
		/// </summary>
		static readonly string _service = "CSPAT00600";
		/// <summary>
		/// B
		/// </summary>
		static readonly string _headType = "B";
		/// <summary>
		/// 김기종
		/// </summary>
		static readonly string _creator = "김기종";
		/// <summary>
		/// 2011/12/07 09:23:39
		/// </summary>
		static readonly string _createdDate = "2011/12/07 09:23:39";
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _attr = false;
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _block = false;
		/// <summary>
		/// true
		/// </summary>
		static readonly bool _encrypt = true;
		/// <summary>
		/// true
		/// </summary>
		static readonly bool _signature = true;

	/// <summary>
	/// CSPAT00600
	/// </summary>
	public string TypeName => _typeName;
	/// <summary>
	/// 현물주문
	/// </summary>
	public string TypeDesc => _typeDesc;
	/// <summary>
	/// CSPAT00600
	/// </summary>
	public string Service => _service;
	/// <summary>
	/// B
	/// </summary>
	public string HeadType => _headType;
	/// <summary>
	/// 김기종
	/// </summary>
	public string Creator => _creator;
	/// <summary>
	/// 2011/12/07 09:23:39
	/// </summary>
	public string CreatedDate => _createdDate;
	/// <summary>
	/// false
	/// </summary>
	public bool Attr => _attr;
	/// <summary>
	/// false
	/// </summary>
	public bool Block => _block;
	/// <summary>
	/// true
	/// </summary>
	public bool Encrypt => _encrypt;
	/// <summary>
	/// true
	/// </summary>
	public bool Signature => _signature;

		public XQCSPAT00600() : base("CSPAT00600") { }


		public bool SetFields(XQCSPAT00600InBlock1 block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "AcntNo", 0, block.AcntNo); // char 20
			_xaQuery.SetFieldData(block.GetBlockName(), "InptPwd", 0, block.InptPwd); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "IsuNo", 0, block.IsuNo); // char 12
			_xaQuery.SetFieldData(block.GetBlockName(), "OrdQty", 0, block.OrdQty.ToString("d16")); // long 16
			_xaQuery.SetFieldData(block.GetBlockName(), "OrdPrc", 0, block.OrdPrc.ToString("0000000000000.00")); // double 13.2
			_xaQuery.SetFieldData(block.GetBlockName(), "BnsTpCode", 0, block.BnsTpCode.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "OrdprcPtnCode", 0, block.OrdprcPtnCode); // char 2
			_xaQuery.SetFieldData(block.GetBlockName(), "MgntrnCode", 0, block.MgntrnCode); // char 3
			_xaQuery.SetFieldData(block.GetBlockName(), "LoanDt", 0, block.LoanDt); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "OrdCndiTpCode", 0, block.OrdCndiTpCode.ToString()); // char 1

			return true;
		}

		public XQCSPAT00600OutBlock1 GetBlock1()
		{
			XQCSPAT00600OutBlock1 instance = XQCSPAT00600OutBlock1.FromQuery(this);
			return instance;

		}

		public XQCSPAT00600OutBlock2 GetBlock2()
		{
			XQCSPAT00600OutBlock2 instance = XQCSPAT00600OutBlock2.FromQuery(this);
			return instance;

		}


	}

	public partial class XQCSPAT00700InBlock1 : XingBlock
	{
		/// <summary>
		/// CSPAT00700InBlock1
		/// </summary>
		static readonly string _blockName = "CSPAT00700InBlock1";
		/// <summary>
		/// In(*EMPTY*)
		/// </summary>
		static readonly string _blockDesc = "In(*EMPTY*)";
		/// <summary>
		/// input
		/// </summary>
		static readonly string _blockType = "input";
		/// <summary>
		/// CSPAT00700InBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CSPAT00700InBlock1
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// In(*EMPTY*)
		/// </summary>
		public string BlockDesc => _blockDesc;
		/// <summary>
		/// input
		/// </summary>
		public string BlockType => _blockType;

		/// <summary>
		/// 원주문번호
		/// </summary>
		[XAQueryFieldAttribute("원주문번호")]
		public long OrgOrdNo;
		/// <summary>
		/// 계좌번호
		/// </summary>
		[XAQueryFieldAttribute("계좌번호")]
		public string AcntNo;
		/// <summary>
		/// 입력비밀번호
		/// </summary>
		[XAQueryFieldAttribute("입력비밀번호")]
		public string InptPwd;
		/// <summary>
		/// 종목번호
		/// </summary>
		[XAQueryFieldAttribute("종목번호")]
		public string IsuNo;
		/// <summary>
		/// 주문수량
		/// </summary>
		[XAQueryFieldAttribute("주문수량")]
		public long OrdQty;
		/// <summary>
		/// 호가유형코드
		/// </summary>
		[XAQueryFieldAttribute("호가유형코드")]
		public string OrdprcPtnCode;
		/// <summary>
		/// 주문조건구분
		/// </summary>
		[XAQueryFieldAttribute("주문조건구분")]
		public char OrdCndiTpCode;
		/// <summary>
		/// 주문가
		/// </summary>
		[XAQueryFieldAttribute("주문가")]
		public double OrdPrc;

		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["OrgOrdNo"] = new XAQueryFieldInfo("long", OrgOrdNo, OrgOrdNo.ToString("d10"), "원주문번호", (decimal)10);
			dict["AcntNo"] = new XAQueryFieldInfo("char", AcntNo, AcntNo, "계좌번호", (decimal)20);
			dict["InptPwd"] = new XAQueryFieldInfo("char", InptPwd, InptPwd, "입력비밀번호", (decimal)8);
			dict["IsuNo"] = new XAQueryFieldInfo("char", IsuNo, IsuNo, "종목번호", (decimal)12);
			dict["OrdQty"] = new XAQueryFieldInfo("long", OrdQty, OrdQty.ToString("d16"), "주문수량", (decimal)16);
			dict["OrdprcPtnCode"] = new XAQueryFieldInfo("char", OrdprcPtnCode, OrdprcPtnCode, "호가유형코드", (decimal)2);
			dict["OrdCndiTpCode"] = new XAQueryFieldInfo("char", OrdCndiTpCode, OrdCndiTpCode.ToString(), "주문조건구분", (decimal)1);
			dict["OrdPrc"] = new XAQueryFieldInfo("double", OrdPrc, OrdPrc.ToString("0000000000000.00"), "주문가", (decimal)13.2);

			return dict;
		}

		public bool VerifyData()
		{
			if (OrgOrdNo.ToString().Length > 10) return false; // long 10
			if (AcntNo.Length > 20) return false; // char 20
			if (InptPwd.Length > 8) return false; // char 8
			if (IsuNo.Length > 12) return false; // char 12
			if (OrdQty.ToString().Length > 16) return false; // long 16
			if (OrdprcPtnCode.Length > 2) return false; // char 2
			// OrdCndiTpCode char 1
			// OrdPrc double 13.2

			return true;
		}
	}

	public partial class XQCSPAT00700OutBlock1 : XingBlock
	{
		/// <summary>
		/// CSPAT00700OutBlock1
		/// </summary>
		static readonly string _blockName = "CSPAT00700OutBlock1";
		/// <summary>
		/// In(*EMPTY*)
		/// </summary>
		static readonly string _blockDesc = "In(*EMPTY*)";
		/// <summary>
		/// output
		/// </summary>
		static readonly string _blockType = "output";
		/// <summary>
		/// CSPAT00700OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CSPAT00700OutBlock1
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// In(*EMPTY*)
		/// </summary>
		public string BlockDesc => _blockDesc;
		/// <summary>
		/// output
		/// </summary>
		public string BlockType => _blockType;

		/// <summary>
		/// 레코드갯수
		/// </summary>
		[XAQueryFieldAttribute("레코드갯수")]
		public long RecCnt;
		/// <summary>
		/// 원주문번호
		/// </summary>
		[XAQueryFieldAttribute("원주문번호")]
		public long OrgOrdNo;
		/// <summary>
		/// 계좌번호
		/// </summary>
		[XAQueryFieldAttribute("계좌번호")]
		public string AcntNo;
		/// <summary>
		/// 입력비밀번호
		/// </summary>
		[XAQueryFieldAttribute("입력비밀번호")]
		public string InptPwd;
		/// <summary>
		/// 종목번호
		/// </summary>
		[XAQueryFieldAttribute("종목번호")]
		public string IsuNo;
		/// <summary>
		/// 주문수량
		/// </summary>
		[XAQueryFieldAttribute("주문수량")]
		public long OrdQty;
		/// <summary>
		/// 호가유형코드
		/// </summary>
		[XAQueryFieldAttribute("호가유형코드")]
		public string OrdprcPtnCode;
		/// <summary>
		/// 주문조건구분
		/// </summary>
		[XAQueryFieldAttribute("주문조건구분")]
		public char OrdCndiTpCode;
		/// <summary>
		/// 주문가
		/// </summary>
		[XAQueryFieldAttribute("주문가")]
		public double OrdPrc;
		/// <summary>
		/// 통신매체코드
		/// </summary>
		[XAQueryFieldAttribute("통신매체코드")]
		public string CommdaCode;
		/// <summary>
		/// 전략코드
		/// </summary>
		[XAQueryFieldAttribute("전략코드")]
		public string StrtgCode;
		/// <summary>
		/// 그룹ID
		/// </summary>
		[XAQueryFieldAttribute("그룹ID")]
		public string GrpId;
		/// <summary>
		/// 주문회차
		/// </summary>
		[XAQueryFieldAttribute("주문회차")]
		public long OrdSeqNo;
		/// <summary>
		/// 포트폴리오번호
		/// </summary>
		[XAQueryFieldAttribute("포트폴리오번호")]
		public long PtflNo;
		/// <summary>
		/// 바스켓번호
		/// </summary>
		[XAQueryFieldAttribute("바스켓번호")]
		public long BskNo;
		/// <summary>
		/// 트렌치번호
		/// </summary>
		[XAQueryFieldAttribute("트렌치번호")]
		public long TrchNo;
		/// <summary>
		/// 아이템번호
		/// </summary>
		[XAQueryFieldAttribute("아이템번호")]
		public long ItemNo;

		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["OrgOrdNo"] = new XAQueryFieldInfo("long", OrgOrdNo, OrgOrdNo.ToString("d10"), "원주문번호", (decimal)10);
			dict["AcntNo"] = new XAQueryFieldInfo("char", AcntNo, AcntNo, "계좌번호", (decimal)20);
			dict["InptPwd"] = new XAQueryFieldInfo("char", InptPwd, InptPwd, "입력비밀번호", (decimal)8);
			dict["IsuNo"] = new XAQueryFieldInfo("char", IsuNo, IsuNo, "종목번호", (decimal)12);
			dict["OrdQty"] = new XAQueryFieldInfo("long", OrdQty, OrdQty.ToString("d16"), "주문수량", (decimal)16);
			dict["OrdprcPtnCode"] = new XAQueryFieldInfo("char", OrdprcPtnCode, OrdprcPtnCode, "호가유형코드", (decimal)2);
			dict["OrdCndiTpCode"] = new XAQueryFieldInfo("char", OrdCndiTpCode, OrdCndiTpCode.ToString(), "주문조건구분", (decimal)1);
			dict["OrdPrc"] = new XAQueryFieldInfo("double", OrdPrc, OrdPrc.ToString("0000000000000.00"), "주문가", (decimal)13.2);
			dict["CommdaCode"] = new XAQueryFieldInfo("char", CommdaCode, CommdaCode, "통신매체코드", (decimal)2);
			dict["StrtgCode"] = new XAQueryFieldInfo("char", StrtgCode, StrtgCode, "전략코드", (decimal)6);
			dict["GrpId"] = new XAQueryFieldInfo("char", GrpId, GrpId, "그룹ID", (decimal)20);
			dict["OrdSeqNo"] = new XAQueryFieldInfo("long", OrdSeqNo, OrdSeqNo.ToString("d10"), "주문회차", (decimal)10);
			dict["PtflNo"] = new XAQueryFieldInfo("long", PtflNo, PtflNo.ToString("d10"), "포트폴리오번호", (decimal)10);
			dict["BskNo"] = new XAQueryFieldInfo("long", BskNo, BskNo.ToString("d10"), "바스켓번호", (decimal)10);
			dict["TrchNo"] = new XAQueryFieldInfo("long", TrchNo, TrchNo.ToString("d10"), "트렌치번호", (decimal)10);
			dict["ItemNo"] = new XAQueryFieldInfo("long", ItemNo, ItemNo.ToString("d10"), "아이템번호", (decimal)10);

			return dict;
		}

		public static XQCSPAT00700OutBlock1 FromQuery(XQCSPAT00700 query)
		{
			XQCSPAT00700OutBlock1 block = new XQCSPAT00700OutBlock1();
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
				block.RecCnt = query.GetFieldData(block.GetBlockName(), "RecCnt", 0).ParseLong("RecCnt"); // long 5
				block.OrgOrdNo = query.GetFieldData(block.GetBlockName(), "OrgOrdNo", 0).ParseLong("OrgOrdNo"); // long 10
				block.AcntNo = query.GetFieldData(block.GetBlockName(), "AcntNo", 0); // char 20
				block.InptPwd = query.GetFieldData(block.GetBlockName(), "InptPwd", 0); // char 8
				block.IsuNo = query.GetFieldData(block.GetBlockName(), "IsuNo", 0); // char 12
				block.OrdQty = query.GetFieldData(block.GetBlockName(), "OrdQty", 0).ParseLong("OrdQty"); // long 16
				block.OrdprcPtnCode = query.GetFieldData(block.GetBlockName(), "OrdprcPtnCode", 0); // char 2
				block.OrdCndiTpCode = query.GetFieldData(block.GetBlockName(), "OrdCndiTpCode", 0).First(); // char 1
				block.OrdPrc = query.GetFieldData(block.GetBlockName(), "OrdPrc", 0).ParseDouble("OrdPrc"); // double 13.2
				block.CommdaCode = query.GetFieldData(block.GetBlockName(), "CommdaCode", 0); // char 2
				block.StrtgCode = query.GetFieldData(block.GetBlockName(), "StrtgCode", 0); // char 6
				block.GrpId = query.GetFieldData(block.GetBlockName(), "GrpId", 0); // char 20
				block.OrdSeqNo = query.GetFieldData(block.GetBlockName(), "OrdSeqNo", 0).ParseLong("OrdSeqNo"); // long 10
				block.PtflNo = query.GetFieldData(block.GetBlockName(), "PtflNo", 0).ParseLong("PtflNo"); // long 10
				block.BskNo = query.GetFieldData(block.GetBlockName(), "BskNo", 0).ParseLong("BskNo"); // long 10
				block.TrchNo = query.GetFieldData(block.GetBlockName(), "TrchNo", 0).ParseLong("TrchNo"); // long 10
				block.ItemNo = query.GetFieldData(block.GetBlockName(), "ItemNo", 0).ParseLong("ItemNo"); // long 10

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (RecCnt.ToString().Length > 5) return false; // long 5
			if (OrgOrdNo.ToString().Length > 10) return false; // long 10
			if (AcntNo.Length > 20) return false; // char 20
			if (InptPwd.Length > 8) return false; // char 8
			if (IsuNo.Length > 12) return false; // char 12
			if (OrdQty.ToString().Length > 16) return false; // long 16
			if (OrdprcPtnCode.Length > 2) return false; // char 2
			// OrdCndiTpCode char 1
			// OrdPrc double 13.2
			if (CommdaCode.Length > 2) return false; // char 2
			if (StrtgCode.Length > 6) return false; // char 6
			if (GrpId.Length > 20) return false; // char 20
			if (OrdSeqNo.ToString().Length > 10) return false; // long 10
			if (PtflNo.ToString().Length > 10) return false; // long 10
			if (BskNo.ToString().Length > 10) return false; // long 10
			if (TrchNo.ToString().Length > 10) return false; // long 10
			if (ItemNo.ToString().Length > 10) return false; // long 10

			return true;
		}
	}

	public partial class XQCSPAT00700OutBlock2 : XingBlock
	{
		/// <summary>
		/// CSPAT00700OutBlock2
		/// </summary>
		static readonly string _blockName = "CSPAT00700OutBlock2";
		/// <summary>
		/// Out(*EMPTY*)
		/// </summary>
		static readonly string _blockDesc = "Out(*EMPTY*)";
		/// <summary>
		/// output
		/// </summary>
		static readonly string _blockType = "output";
		/// <summary>
		/// CSPAT00700OutBlock2
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CSPAT00700OutBlock2
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// Out(*EMPTY*)
		/// </summary>
		public string BlockDesc => _blockDesc;
		/// <summary>
		/// output
		/// </summary>
		public string BlockType => _blockType;

		/// <summary>
		/// 레코드갯수
		/// </summary>
		[XAQueryFieldAttribute("레코드갯수")]
		public long RecCnt;
		/// <summary>
		/// 주문번호
		/// </summary>
		[XAQueryFieldAttribute("주문번호")]
		public long OrdNo;
		/// <summary>
		/// 모주문번호
		/// </summary>
		[XAQueryFieldAttribute("모주문번호")]
		public long PrntOrdNo;
		/// <summary>
		/// 주문시각
		/// </summary>
		[XAQueryFieldAttribute("주문시각")]
		public string OrdTime;
		/// <summary>
		/// 주문시장코드
		/// </summary>
		[XAQueryFieldAttribute("주문시장코드")]
		public string OrdMktCode;
		/// <summary>
		/// 주문유형코드
		/// </summary>
		[XAQueryFieldAttribute("주문유형코드")]
		public string OrdPtnCode;
		/// <summary>
		/// 단축종목번호
		/// </summary>
		[XAQueryFieldAttribute("단축종목번호")]
		public string ShtnIsuNo;
		/// <summary>
		/// 프로그램호가유형코드
		/// </summary>
		[XAQueryFieldAttribute("프로그램호가유형코드")]
		public string PrgmOrdprcPtnCode;
		/// <summary>
		/// 공매도호가구분
		/// </summary>
		[XAQueryFieldAttribute("공매도호가구분")]
		public char StslOrdprcTpCode;
		/// <summary>
		/// 공매도가능여부
		/// </summary>
		[XAQueryFieldAttribute("공매도가능여부")]
		public char StslAbleYn;
		/// <summary>
		/// 신용거래코드
		/// </summary>
		[XAQueryFieldAttribute("신용거래코드")]
		public string MgntrnCode;
		/// <summary>
		/// 대출일
		/// </summary>
		[XAQueryFieldAttribute("대출일")]
		public string LoanDt;
		/// <summary>
		/// 반대매매주문구분
		/// </summary>
		[XAQueryFieldAttribute("반대매매주문구분")]
		public char CvrgOrdTp;
		/// <summary>
		/// 유동성공급자여부
		/// </summary>
		[XAQueryFieldAttribute("유동성공급자여부")]
		public char LpYn;
		/// <summary>
		/// 관리사원번호
		/// </summary>
		[XAQueryFieldAttribute("관리사원번호")]
		public string MgempNo;
		/// <summary>
		/// 주문금액
		/// </summary>
		[XAQueryFieldAttribute("주문금액")]
		public long OrdAmt;
		/// <summary>
		/// 매매구분
		/// </summary>
		[XAQueryFieldAttribute("매매구분")]
		public char BnsTpCode;
		/// <summary>
		/// 예비주문번호
		/// </summary>
		[XAQueryFieldAttribute("예비주문번호")]
		public long SpareOrdNo;
		/// <summary>
		/// 반대매매일련번호
		/// </summary>
		[XAQueryFieldAttribute("반대매매일련번호")]
		public long CvrgSeqno;
		/// <summary>
		/// 예약주문번호
		/// </summary>
		[XAQueryFieldAttribute("예약주문번호")]
		public long RsvOrdNo;
		/// <summary>
		/// 현금주문금액
		/// </summary>
		[XAQueryFieldAttribute("현금주문금액")]
		public long MnyOrdAmt;
		/// <summary>
		/// 대용주문금액
		/// </summary>
		[XAQueryFieldAttribute("대용주문금액")]
		public long SubstOrdAmt;
		/// <summary>
		/// 재사용주문금액
		/// </summary>
		[XAQueryFieldAttribute("재사용주문금액")]
		public long RuseOrdAmt;
		/// <summary>
		/// 계좌명
		/// </summary>
		[XAQueryFieldAttribute("계좌명")]
		public string AcntNm;
		/// <summary>
		/// 종목명
		/// </summary>
		[XAQueryFieldAttribute("종목명")]
		public string IsuNm;

		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["OrdNo"] = new XAQueryFieldInfo("long", OrdNo, OrdNo.ToString("d10"), "주문번호", (decimal)10);
			dict["PrntOrdNo"] = new XAQueryFieldInfo("long", PrntOrdNo, PrntOrdNo.ToString("d10"), "모주문번호", (decimal)10);
			dict["OrdTime"] = new XAQueryFieldInfo("char", OrdTime, OrdTime, "주문시각", (decimal)9);
			dict["OrdMktCode"] = new XAQueryFieldInfo("char", OrdMktCode, OrdMktCode, "주문시장코드", (decimal)2);
			dict["OrdPtnCode"] = new XAQueryFieldInfo("char", OrdPtnCode, OrdPtnCode, "주문유형코드", (decimal)2);
			dict["ShtnIsuNo"] = new XAQueryFieldInfo("char", ShtnIsuNo, ShtnIsuNo, "단축종목번호", (decimal)9);
			dict["PrgmOrdprcPtnCode"] = new XAQueryFieldInfo("char", PrgmOrdprcPtnCode, PrgmOrdprcPtnCode, "프로그램호가유형코드", (decimal)2);
			dict["StslOrdprcTpCode"] = new XAQueryFieldInfo("char", StslOrdprcTpCode, StslOrdprcTpCode.ToString(), "공매도호가구분", (decimal)1);
			dict["StslAbleYn"] = new XAQueryFieldInfo("char", StslAbleYn, StslAbleYn.ToString(), "공매도가능여부", (decimal)1);
			dict["MgntrnCode"] = new XAQueryFieldInfo("char", MgntrnCode, MgntrnCode, "신용거래코드", (decimal)3);
			dict["LoanDt"] = new XAQueryFieldInfo("char", LoanDt, LoanDt, "대출일", (decimal)8);
			dict["CvrgOrdTp"] = new XAQueryFieldInfo("char", CvrgOrdTp, CvrgOrdTp.ToString(), "반대매매주문구분", (decimal)1);
			dict["LpYn"] = new XAQueryFieldInfo("char", LpYn, LpYn.ToString(), "유동성공급자여부", (decimal)1);
			dict["MgempNo"] = new XAQueryFieldInfo("char", MgempNo, MgempNo, "관리사원번호", (decimal)9);
			dict["OrdAmt"] = new XAQueryFieldInfo("long", OrdAmt, OrdAmt.ToString("d16"), "주문금액", (decimal)16);
			dict["BnsTpCode"] = new XAQueryFieldInfo("char", BnsTpCode, BnsTpCode.ToString(), "매매구분", (decimal)1);
			dict["SpareOrdNo"] = new XAQueryFieldInfo("long", SpareOrdNo, SpareOrdNo.ToString("d10"), "예비주문번호", (decimal)10);
			dict["CvrgSeqno"] = new XAQueryFieldInfo("long", CvrgSeqno, CvrgSeqno.ToString("d10"), "반대매매일련번호", (decimal)10);
			dict["RsvOrdNo"] = new XAQueryFieldInfo("long", RsvOrdNo, RsvOrdNo.ToString("d10"), "예약주문번호", (decimal)10);
			dict["MnyOrdAmt"] = new XAQueryFieldInfo("long", MnyOrdAmt, MnyOrdAmt.ToString("d16"), "현금주문금액", (decimal)16);
			dict["SubstOrdAmt"] = new XAQueryFieldInfo("long", SubstOrdAmt, SubstOrdAmt.ToString("d16"), "대용주문금액", (decimal)16);
			dict["RuseOrdAmt"] = new XAQueryFieldInfo("long", RuseOrdAmt, RuseOrdAmt.ToString("d16"), "재사용주문금액", (decimal)16);
			dict["AcntNm"] = new XAQueryFieldInfo("char", AcntNm, AcntNm, "계좌명", (decimal)40);
			dict["IsuNm"] = new XAQueryFieldInfo("char", IsuNm, IsuNm, "종목명", (decimal)40);

			return dict;
		}

		public static XQCSPAT00700OutBlock2 FromQuery(XQCSPAT00700 query)
		{
			XQCSPAT00700OutBlock2 block = new XQCSPAT00700OutBlock2();
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
				block.RecCnt = query.GetFieldData(block.GetBlockName(), "RecCnt", 0).ParseLong("RecCnt"); // long 5
				block.OrdNo = query.GetFieldData(block.GetBlockName(), "OrdNo", 0).ParseLong("OrdNo"); // long 10
				block.PrntOrdNo = query.GetFieldData(block.GetBlockName(), "PrntOrdNo", 0).ParseLong("PrntOrdNo"); // long 10
				block.OrdTime = query.GetFieldData(block.GetBlockName(), "OrdTime", 0); // char 9
				block.OrdMktCode = query.GetFieldData(block.GetBlockName(), "OrdMktCode", 0); // char 2
				block.OrdPtnCode = query.GetFieldData(block.GetBlockName(), "OrdPtnCode", 0); // char 2
				block.ShtnIsuNo = query.GetFieldData(block.GetBlockName(), "ShtnIsuNo", 0); // char 9
				block.PrgmOrdprcPtnCode = query.GetFieldData(block.GetBlockName(), "PrgmOrdprcPtnCode", 0); // char 2
				block.StslOrdprcTpCode = query.GetFieldData(block.GetBlockName(), "StslOrdprcTpCode", 0).First(); // char 1
				block.StslAbleYn = query.GetFieldData(block.GetBlockName(), "StslAbleYn", 0).First(); // char 1
				block.MgntrnCode = query.GetFieldData(block.GetBlockName(), "MgntrnCode", 0); // char 3
				block.LoanDt = query.GetFieldData(block.GetBlockName(), "LoanDt", 0); // char 8
				block.CvrgOrdTp = query.GetFieldData(block.GetBlockName(), "CvrgOrdTp", 0).First(); // char 1
				block.LpYn = query.GetFieldData(block.GetBlockName(), "LpYn", 0).First(); // char 1
				block.MgempNo = query.GetFieldData(block.GetBlockName(), "MgempNo", 0); // char 9
				block.OrdAmt = query.GetFieldData(block.GetBlockName(), "OrdAmt", 0).ParseLong("OrdAmt"); // long 16
				block.BnsTpCode = query.GetFieldData(block.GetBlockName(), "BnsTpCode", 0).First(); // char 1
				block.SpareOrdNo = query.GetFieldData(block.GetBlockName(), "SpareOrdNo", 0).ParseLong("SpareOrdNo"); // long 10
				block.CvrgSeqno = query.GetFieldData(block.GetBlockName(), "CvrgSeqno", 0).ParseLong("CvrgSeqno"); // long 10
				block.RsvOrdNo = query.GetFieldData(block.GetBlockName(), "RsvOrdNo", 0).ParseLong("RsvOrdNo"); // long 10
				block.MnyOrdAmt = query.GetFieldData(block.GetBlockName(), "MnyOrdAmt", 0).ParseLong("MnyOrdAmt"); // long 16
				block.SubstOrdAmt = query.GetFieldData(block.GetBlockName(), "SubstOrdAmt", 0).ParseLong("SubstOrdAmt"); // long 16
				block.RuseOrdAmt = query.GetFieldData(block.GetBlockName(), "RuseOrdAmt", 0).ParseLong("RuseOrdAmt"); // long 16
				block.AcntNm = query.GetFieldData(block.GetBlockName(), "AcntNm", 0); // char 40
				block.IsuNm = query.GetFieldData(block.GetBlockName(), "IsuNm", 0); // char 40

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (RecCnt.ToString().Length > 5) return false; // long 5
			if (OrdNo.ToString().Length > 10) return false; // long 10
			if (PrntOrdNo.ToString().Length > 10) return false; // long 10
			if (OrdTime.Length > 9) return false; // char 9
			if (OrdMktCode.Length > 2) return false; // char 2
			if (OrdPtnCode.Length > 2) return false; // char 2
			if (ShtnIsuNo.Length > 9) return false; // char 9
			if (PrgmOrdprcPtnCode.Length > 2) return false; // char 2
			// StslOrdprcTpCode char 1
			// StslAbleYn char 1
			if (MgntrnCode.Length > 3) return false; // char 3
			if (LoanDt.Length > 8) return false; // char 8
			// CvrgOrdTp char 1
			// LpYn char 1
			if (MgempNo.Length > 9) return false; // char 9
			if (OrdAmt.ToString().Length > 16) return false; // long 16
			// BnsTpCode char 1
			if (SpareOrdNo.ToString().Length > 10) return false; // long 10
			if (CvrgSeqno.ToString().Length > 10) return false; // long 10
			if (RsvOrdNo.ToString().Length > 10) return false; // long 10
			if (MnyOrdAmt.ToString().Length > 16) return false; // long 16
			if (SubstOrdAmt.ToString().Length > 16) return false; // long 16
			if (RuseOrdAmt.ToString().Length > 16) return false; // long 16
			if (AcntNm.Length > 40) return false; // char 40
			if (IsuNm.Length > 40) return false; // char 40

			return true;
		}
	}

	public partial class XQCSPAT00700 : XingQuery
	{
		/// <summary>
		/// CSPAT00700
		/// </summary>
		static readonly string _typeName = "CSPAT00700";
		/// <summary>
		/// 현물정정주문
		/// </summary>
		static readonly string _typeDesc = "현물정정주문";
		/// <summary>
		/// CSPAT00700
		/// </summary>
		static readonly string _service = "CSPAT00700";
		/// <summary>
		/// B
		/// </summary>
		static readonly string _headType = "B";
		/// <summary>
		/// 김기종
		/// </summary>
		static readonly string _creator = "김기종";
		/// <summary>
		/// 2011/12/07 09:23:43
		/// </summary>
		static readonly string _createdDate = "2011/12/07 09:23:43";
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _attr = false;
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _block = false;
		/// <summary>
		/// true
		/// </summary>
		static readonly bool _encrypt = true;
		/// <summary>
		/// true
		/// </summary>
		static readonly bool _signature = true;

	/// <summary>
	/// CSPAT00700
	/// </summary>
	public string TypeName => _typeName;
	/// <summary>
	/// 현물정정주문
	/// </summary>
	public string TypeDesc => _typeDesc;
	/// <summary>
	/// CSPAT00700
	/// </summary>
	public string Service => _service;
	/// <summary>
	/// B
	/// </summary>
	public string HeadType => _headType;
	/// <summary>
	/// 김기종
	/// </summary>
	public string Creator => _creator;
	/// <summary>
	/// 2011/12/07 09:23:43
	/// </summary>
	public string CreatedDate => _createdDate;
	/// <summary>
	/// false
	/// </summary>
	public bool Attr => _attr;
	/// <summary>
	/// false
	/// </summary>
	public bool Block => _block;
	/// <summary>
	/// true
	/// </summary>
	public bool Encrypt => _encrypt;
	/// <summary>
	/// true
	/// </summary>
	public bool Signature => _signature;

		public XQCSPAT00700() : base("CSPAT00700") { }


		public bool SetFields(XQCSPAT00700InBlock1 block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "OrgOrdNo", 0, block.OrgOrdNo.ToString("d10")); // long 10
			_xaQuery.SetFieldData(block.GetBlockName(), "AcntNo", 0, block.AcntNo); // char 20
			_xaQuery.SetFieldData(block.GetBlockName(), "InptPwd", 0, block.InptPwd); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "IsuNo", 0, block.IsuNo); // char 12
			_xaQuery.SetFieldData(block.GetBlockName(), "OrdQty", 0, block.OrdQty.ToString("d16")); // long 16
			_xaQuery.SetFieldData(block.GetBlockName(), "OrdprcPtnCode", 0, block.OrdprcPtnCode); // char 2
			_xaQuery.SetFieldData(block.GetBlockName(), "OrdCndiTpCode", 0, block.OrdCndiTpCode.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "OrdPrc", 0, block.OrdPrc.ToString("0000000000000.00")); // double 13.2

			return true;
		}

		public XQCSPAT00700OutBlock1 GetBlock1()
		{
			XQCSPAT00700OutBlock1 instance = XQCSPAT00700OutBlock1.FromQuery(this);
			return instance;

		}

		public XQCSPAT00700OutBlock2 GetBlock2()
		{
			XQCSPAT00700OutBlock2 instance = XQCSPAT00700OutBlock2.FromQuery(this);
			return instance;

		}


	}

	public partial class XRS3_InBlock : XingBlock
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
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("단축코드")]
		public string shcode;

		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)6);

			return dict;
		}

		public bool VerifyData()
		{
			if (shcode.Length > 6) return false; // char 6

			return true;
		}
	}

	public partial class XRS3_OutBlock : XingBlock
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
		/// 체결시간
		/// </summary>
		[XAQueryFieldAttribute("체결시간")]
		public string chetime;
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
		public float drate;
		/// <summary>
		/// 현재가
		/// </summary>
		[XAQueryFieldAttribute("현재가")]
		public long price;
		/// <summary>
		/// 시가시간
		/// </summary>
		[XAQueryFieldAttribute("시가시간")]
		public string opentime;
		/// <summary>
		/// 시가
		/// </summary>
		[XAQueryFieldAttribute("시가")]
		public long open;
		/// <summary>
		/// 고가시간
		/// </summary>
		[XAQueryFieldAttribute("고가시간")]
		public string hightime;
		/// <summary>
		/// 고가
		/// </summary>
		[XAQueryFieldAttribute("고가")]
		public long high;
		/// <summary>
		/// 저가시간
		/// </summary>
		[XAQueryFieldAttribute("저가시간")]
		public string lowtime;
		/// <summary>
		/// 저가
		/// </summary>
		[XAQueryFieldAttribute("저가")]
		public long low;
		/// <summary>
		/// 체결구분
		/// </summary>
		[XAQueryFieldAttribute("체결구분")]
		public char cgubun;
		/// <summary>
		/// 체결량
		/// </summary>
		[XAQueryFieldAttribute("체결량")]
		public long cvolume;
		/// <summary>
		/// 누적거래량
		/// </summary>
		[XAQueryFieldAttribute("누적거래량")]
		public long volume;
		/// <summary>
		/// 누적거래대금
		/// </summary>
		[XAQueryFieldAttribute("누적거래대금")]
		public long value;
		/// <summary>
		/// 매도누적체결량
		/// </summary>
		[XAQueryFieldAttribute("매도누적체결량")]
		public long mdvolume;
		/// <summary>
		/// 매도누적체결건수
		/// </summary>
		[XAQueryFieldAttribute("매도누적체결건수")]
		public long mdchecnt;
		/// <summary>
		/// 매수누적체결량
		/// </summary>
		[XAQueryFieldAttribute("매수누적체결량")]
		public long msvolume;
		/// <summary>
		/// 매수누적체결건수
		/// </summary>
		[XAQueryFieldAttribute("매수누적체결건수")]
		public long mschecnt;
		/// <summary>
		/// 체결강도
		/// </summary>
		[XAQueryFieldAttribute("체결강도")]
		public float cpower;
		/// <summary>
		/// 가중평균가
		/// </summary>
		[XAQueryFieldAttribute("가중평균가")]
		public long w_avrg;
		/// <summary>
		/// 매도호가
		/// </summary>
		[XAQueryFieldAttribute("매도호가")]
		public long offerho;
		/// <summary>
		/// 매수호가
		/// </summary>
		[XAQueryFieldAttribute("매수호가")]
		public long bidho;
		/// <summary>
		/// 장정보
		/// </summary>
		[XAQueryFieldAttribute("장정보")]
		public string status;
		/// <summary>
		/// 전일동시간대거래량
		/// </summary>
		[XAQueryFieldAttribute("전일동시간대거래량")]
		public long jnilvolume;
		/// <summary>
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("단축코드")]
		public string shcode;

		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["chetime"] = new XAQueryFieldInfo("char", chetime, chetime, "체결시간", (decimal)6);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("long", change, change.ToString("d8"), "전일대비", (decimal)8);
			dict["drate"] = new XAQueryFieldInfo("float", drate, drate.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["price"] = new XAQueryFieldInfo("long", price, price.ToString("d8"), "현재가", (decimal)8);
			dict["opentime"] = new XAQueryFieldInfo("char", opentime, opentime, "시가시간", (decimal)6);
			dict["open"] = new XAQueryFieldInfo("long", open, open.ToString("d8"), "시가", (decimal)8);
			dict["hightime"] = new XAQueryFieldInfo("char", hightime, hightime, "고가시간", (decimal)6);
			dict["high"] = new XAQueryFieldInfo("long", high, high.ToString("d8"), "고가", (decimal)8);
			dict["lowtime"] = new XAQueryFieldInfo("char", lowtime, lowtime, "저가시간", (decimal)6);
			dict["low"] = new XAQueryFieldInfo("long", low, low.ToString("d8"), "저가", (decimal)8);
			dict["cgubun"] = new XAQueryFieldInfo("char", cgubun, cgubun.ToString(), "체결구분", (decimal)1);
			dict["cvolume"] = new XAQueryFieldInfo("long", cvolume, cvolume.ToString("d8"), "체결량", (decimal)8);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "누적거래량", (decimal)12);
			dict["value"] = new XAQueryFieldInfo("long", value, value.ToString("d12"), "누적거래대금", (decimal)12);
			dict["mdvolume"] = new XAQueryFieldInfo("long", mdvolume, mdvolume.ToString("d12"), "매도누적체결량", (decimal)12);
			dict["mdchecnt"] = new XAQueryFieldInfo("long", mdchecnt, mdchecnt.ToString("d8"), "매도누적체결건수", (decimal)8);
			dict["msvolume"] = new XAQueryFieldInfo("long", msvolume, msvolume.ToString("d12"), "매수누적체결량", (decimal)12);
			dict["mschecnt"] = new XAQueryFieldInfo("long", mschecnt, mschecnt.ToString("d8"), "매수누적체결건수", (decimal)8);
			dict["cpower"] = new XAQueryFieldInfo("float", cpower, cpower.ToString("000000000.00"), "체결강도", (decimal)9.2);
			dict["w_avrg"] = new XAQueryFieldInfo("long", w_avrg, w_avrg.ToString("d8"), "가중평균가", (decimal)8);
			dict["offerho"] = new XAQueryFieldInfo("long", offerho, offerho.ToString("d8"), "매도호가", (decimal)8);
			dict["bidho"] = new XAQueryFieldInfo("long", bidho, bidho.ToString("d8"), "매수호가", (decimal)8);
			dict["status"] = new XAQueryFieldInfo("char", status, status, "장정보", (decimal)2);
			dict["jnilvolume"] = new XAQueryFieldInfo("long", jnilvolume, jnilvolume.ToString("d12"), "전일동시간대거래량", (decimal)12);
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)6);

			return dict;
		}

		public static XRS3_OutBlock FromQuery(XRS3_ query)
		{
			XRS3_OutBlock block = new XRS3_OutBlock();
			block.IsValidData = true;
			block.InvalidReason = "";
			try
			{
				block.chetime = query.GetFieldData(block.GetBlockName(), "chetime"); // char 6
				block.sign = query.GetFieldData(block.GetBlockName(), "sign").First(); // char 1
				block.change = query.GetFieldData(block.GetBlockName(), "change").ParseLong("change"); // long 8
				block.drate = query.GetFieldData(block.GetBlockName(), "drate").ParseFloat("drate"); // float 6.2
				block.price = query.GetFieldData(block.GetBlockName(), "price").ParseLong("price"); // long 8
				block.opentime = query.GetFieldData(block.GetBlockName(), "opentime"); // char 6
				block.open = query.GetFieldData(block.GetBlockName(), "open").ParseLong("open"); // long 8
				block.hightime = query.GetFieldData(block.GetBlockName(), "hightime"); // char 6
				block.high = query.GetFieldData(block.GetBlockName(), "high").ParseLong("high"); // long 8
				block.lowtime = query.GetFieldData(block.GetBlockName(), "lowtime"); // char 6
				block.low = query.GetFieldData(block.GetBlockName(), "low").ParseLong("low"); // long 8
				block.cgubun = query.GetFieldData(block.GetBlockName(), "cgubun").First(); // char 1
				block.cvolume = query.GetFieldData(block.GetBlockName(), "cvolume").ParseLong("cvolume"); // long 8
				block.volume = query.GetFieldData(block.GetBlockName(), "volume").ParseLong("volume"); // long 12
				block.value = query.GetFieldData(block.GetBlockName(), "value").ParseLong("value"); // long 12
				block.mdvolume = query.GetFieldData(block.GetBlockName(), "mdvolume").ParseLong("mdvolume"); // long 12
				block.mdchecnt = query.GetFieldData(block.GetBlockName(), "mdchecnt").ParseLong("mdchecnt"); // long 8
				block.msvolume = query.GetFieldData(block.GetBlockName(), "msvolume").ParseLong("msvolume"); // long 12
				block.mschecnt = query.GetFieldData(block.GetBlockName(), "mschecnt").ParseLong("mschecnt"); // long 8
				block.cpower = query.GetFieldData(block.GetBlockName(), "cpower").ParseFloat("cpower"); // float 9.2
				block.w_avrg = query.GetFieldData(block.GetBlockName(), "w_avrg").ParseLong("w_avrg"); // long 8
				block.offerho = query.GetFieldData(block.GetBlockName(), "offerho").ParseLong("offerho"); // long 8
				block.bidho = query.GetFieldData(block.GetBlockName(), "bidho").ParseLong("bidho"); // long 8
				block.status = query.GetFieldData(block.GetBlockName(), "status"); // char 2
				block.jnilvolume = query.GetFieldData(block.GetBlockName(), "jnilvolume").ParseLong("jnilvolume"); // long 12
				block.shcode = query.GetFieldData(block.GetBlockName(), "shcode"); // char 6

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (chetime.Length > 6) return false; // char 6
			// sign char 1
			if (change.ToString().Length > 8) return false; // long 8
			// drate float 6.2
			if (price.ToString().Length > 8) return false; // long 8
			if (opentime.Length > 6) return false; // char 6
			if (open.ToString().Length > 8) return false; // long 8
			if (hightime.Length > 6) return false; // char 6
			if (high.ToString().Length > 8) return false; // long 8
			if (lowtime.Length > 6) return false; // char 6
			if (low.ToString().Length > 8) return false; // long 8
			// cgubun char 1
			if (cvolume.ToString().Length > 8) return false; // long 8
			if (volume.ToString().Length > 12) return false; // long 12
			if (value.ToString().Length > 12) return false; // long 12
			if (mdvolume.ToString().Length > 12) return false; // long 12
			if (mdchecnt.ToString().Length > 8) return false; // long 8
			if (msvolume.ToString().Length > 12) return false; // long 12
			if (mschecnt.ToString().Length > 8) return false; // long 8
			// cpower float 9.2
			if (w_avrg.ToString().Length > 8) return false; // long 8
			if (offerho.ToString().Length > 8) return false; // long 8
			if (bidho.ToString().Length > 8) return false; // long 8
			if (status.Length > 2) return false; // char 2
			if (jnilvolume.ToString().Length > 12) return false; // long 12
			if (shcode.Length > 6) return false; // char 6

			return true;
		}
	}

	public partial class XRS3_ : XingReal
	{
		/// <summary>
		/// S3_
		/// </summary>
		static readonly string _typeName = "S3_";
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
		/// S3_
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

		public XRS3_() : base("S3_") { }


		public bool SetFields(XRS3_InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaReal.SetFieldData(block.GetBlockName(), "shcode", block.shcode); // char 6

			return true;
		}

		public XRS3_OutBlock GetBlock()
		{
			XRS3_OutBlock instance = XRS3_OutBlock.FromQuery(this);
			return instance;

		}


	}

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


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();

			return dict;
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

		public static XRSC0OutBlock FromQuery(XRSC0 query)
		{
			XRSC0OutBlock block = new XRSC0OutBlock();
			block.IsValidData = true;
			block.InvalidReason = "";
			try
			{
				block.lineseq = query.GetFieldData(block.GetBlockName(), "lineseq").ParseLong("lineseq"); // long 10
				block.accno = query.GetFieldData(block.GetBlockName(), "accno"); // char 11
				block.user = query.GetFieldData(block.GetBlockName(), "user"); // char 8
				block.len = query.GetFieldData(block.GetBlockName(), "len").ParseLong("len"); // long 6
				block.gubun = query.GetFieldData(block.GetBlockName(), "gubun").First(); // char 1
				block.compress = query.GetFieldData(block.GetBlockName(), "compress").First(); // char 1
				block.encrypt = query.GetFieldData(block.GetBlockName(), "encrypt").First(); // char 1
				block.offset = query.GetFieldData(block.GetBlockName(), "offset").ParseLong("offset"); // long 3
				block.trcode = query.GetFieldData(block.GetBlockName(), "trcode"); // char 8
				block.compid = query.GetFieldData(block.GetBlockName(), "compid"); // char 3
				block.userid = query.GetFieldData(block.GetBlockName(), "userid"); // char 16
				block.media = query.GetFieldData(block.GetBlockName(), "media"); // char 2
				block.ifid = query.GetFieldData(block.GetBlockName(), "ifid"); // char 3
				block.seq = query.GetFieldData(block.GetBlockName(), "seq"); // char 9
				block.trid = query.GetFieldData(block.GetBlockName(), "trid"); // char 16
				block.pubip = query.GetFieldData(block.GetBlockName(), "pubip"); // char 12
				block.prvip = query.GetFieldData(block.GetBlockName(), "prvip"); // char 12
				block.pcbpno = query.GetFieldData(block.GetBlockName(), "pcbpno"); // char 3
				block.bpno = query.GetFieldData(block.GetBlockName(), "bpno"); // char 3
				block.termno = query.GetFieldData(block.GetBlockName(), "termno"); // char 8
				block.lang = query.GetFieldData(block.GetBlockName(), "lang").First(); // char 1
				block.proctm = query.GetFieldData(block.GetBlockName(), "proctm").ParseLong("proctm"); // long 9
				block.msgcode = query.GetFieldData(block.GetBlockName(), "msgcode"); // char 4
				block.outgu = query.GetFieldData(block.GetBlockName(), "outgu").First(); // char 1
				block.compreq = query.GetFieldData(block.GetBlockName(), "compreq").First(); // char 1
				block.funckey = query.GetFieldData(block.GetBlockName(), "funckey"); // char 4
				block.reqcnt = query.GetFieldData(block.GetBlockName(), "reqcnt").ParseLong("reqcnt"); // long 4
				block.filler = query.GetFieldData(block.GetBlockName(), "filler"); // char 6
				block.cont = query.GetFieldData(block.GetBlockName(), "cont").First(); // char 1
				block.contkey = query.GetFieldData(block.GetBlockName(), "contkey"); // char 18
				block.varlen = query.GetFieldData(block.GetBlockName(), "varlen").ParseLong("varlen"); // long 2
				block.varhdlen = query.GetFieldData(block.GetBlockName(), "varhdlen").ParseLong("varhdlen"); // long 2
				block.varmsglen = query.GetFieldData(block.GetBlockName(), "varmsglen").ParseLong("varmsglen"); // long 2
				block.trsrc = query.GetFieldData(block.GetBlockName(), "trsrc").First(); // char 1
				block.eventid = query.GetFieldData(block.GetBlockName(), "eventid"); // char 4
				block.ifinfo = query.GetFieldData(block.GetBlockName(), "ifinfo"); // char 4
				block.filler1 = query.GetFieldData(block.GetBlockName(), "filler1"); // char 41
				block.ordchegb = query.GetFieldData(block.GetBlockName(), "ordchegb"); // char 2
				block.marketgb = query.GetFieldData(block.GetBlockName(), "marketgb"); // char 2
				block.ordgb = query.GetFieldData(block.GetBlockName(), "ordgb"); // char 2
				block.orgordno = query.GetFieldData(block.GetBlockName(), "orgordno").ParseLong("orgordno"); // long 10
				block.accno1 = query.GetFieldData(block.GetBlockName(), "accno1"); // char 11
				block.accno2 = query.GetFieldData(block.GetBlockName(), "accno2"); // char 9
				block.passwd = query.GetFieldData(block.GetBlockName(), "passwd"); // char 8
				block.expcode = query.GetFieldData(block.GetBlockName(), "expcode"); // char 12
				block.shtcode = query.GetFieldData(block.GetBlockName(), "shtcode"); // char 9
				block.hname = query.GetFieldData(block.GetBlockName(), "hname"); // char 40
				block.ordqty = query.GetFieldData(block.GetBlockName(), "ordqty").ParseLong("ordqty"); // long 16
				block.ordprice = query.GetFieldData(block.GetBlockName(), "ordprice").ParseLong("ordprice"); // long 13
				block.hogagb = query.GetFieldData(block.GetBlockName(), "hogagb").First(); // char 1
				block.etfhogagb = query.GetFieldData(block.GetBlockName(), "etfhogagb"); // char 2
				block.pgmtype = query.GetFieldData(block.GetBlockName(), "pgmtype").ParseLong("pgmtype"); // long 2
				block.gmhogagb = query.GetFieldData(block.GetBlockName(), "gmhogagb").ParseLong("gmhogagb"); // long 1
				block.gmhogayn = query.GetFieldData(block.GetBlockName(), "gmhogayn").ParseLong("gmhogayn"); // long 1
				block.singb = query.GetFieldData(block.GetBlockName(), "singb"); // char 3
				block.loandt = query.GetFieldData(block.GetBlockName(), "loandt"); // char 8
				block.cvrgordtp = query.GetFieldData(block.GetBlockName(), "cvrgordtp").First(); // char 1
				block.strtgcode = query.GetFieldData(block.GetBlockName(), "strtgcode"); // char 6
				block.groupid = query.GetFieldData(block.GetBlockName(), "groupid"); // char 20
				block.ordseqno = query.GetFieldData(block.GetBlockName(), "ordseqno").ParseLong("ordseqno"); // long 10
				block.prtno = query.GetFieldData(block.GetBlockName(), "prtno").ParseLong("prtno"); // long 10
				block.basketno = query.GetFieldData(block.GetBlockName(), "basketno").ParseLong("basketno"); // long 10
				block.trchno = query.GetFieldData(block.GetBlockName(), "trchno").ParseLong("trchno"); // long 10
				block.itemno = query.GetFieldData(block.GetBlockName(), "itemno").ParseLong("itemno"); // long 10
				block.brwmgmyn = query.GetFieldData(block.GetBlockName(), "brwmgmyn").ParseLong("brwmgmyn"); // long 1
				block.mbrno = query.GetFieldData(block.GetBlockName(), "mbrno").ParseLong("mbrno"); // long 3
				block.procgb = query.GetFieldData(block.GetBlockName(), "procgb").First(); // char 1
				block.admbrchno = query.GetFieldData(block.GetBlockName(), "admbrchno"); // char 3
				block.futaccno = query.GetFieldData(block.GetBlockName(), "futaccno"); // char 20
				block.futmarketgb = query.GetFieldData(block.GetBlockName(), "futmarketgb").First(); // char 1
				block.tongsingb = query.GetFieldData(block.GetBlockName(), "tongsingb"); // char 2
				block.lpgb = query.GetFieldData(block.GetBlockName(), "lpgb").First(); // char 1
				block.dummy = query.GetFieldData(block.GetBlockName(), "dummy"); // char 20
				block.ordno = query.GetFieldData(block.GetBlockName(), "ordno").ParseLong("ordno"); // long 10
				block.ordtm = query.GetFieldData(block.GetBlockName(), "ordtm"); // char 9
				block.prntordno = query.GetFieldData(block.GetBlockName(), "prntordno").ParseLong("prntordno"); // long 10
				block.mgempno = query.GetFieldData(block.GetBlockName(), "mgempno"); // char 9
				block.orgordundrqty = query.GetFieldData(block.GetBlockName(), "orgordundrqty").ParseLong("orgordundrqty"); // long 16
				block.orgordmdfyqty = query.GetFieldData(block.GetBlockName(), "orgordmdfyqty").ParseLong("orgordmdfyqty"); // long 16
				block.ordordcancelqty = query.GetFieldData(block.GetBlockName(), "ordordcancelqty").ParseLong("ordordcancelqty"); // long 16
				block.nmcpysndno = query.GetFieldData(block.GetBlockName(), "nmcpysndno").ParseLong("nmcpysndno"); // long 10
				block.ordamt = query.GetFieldData(block.GetBlockName(), "ordamt").ParseLong("ordamt"); // long 16
				block.bnstp = query.GetFieldData(block.GetBlockName(), "bnstp").First(); // char 1
				block.spareordno = query.GetFieldData(block.GetBlockName(), "spareordno").ParseLong("spareordno"); // long 10
				block.cvrgseqno = query.GetFieldData(block.GetBlockName(), "cvrgseqno").ParseLong("cvrgseqno"); // long 10
				block.rsvordno = query.GetFieldData(block.GetBlockName(), "rsvordno").ParseLong("rsvordno"); // long 10
				block.mtordseqno = query.GetFieldData(block.GetBlockName(), "mtordseqno").ParseLong("mtordseqno"); // long 10
				block.spareordqty = query.GetFieldData(block.GetBlockName(), "spareordqty").ParseLong("spareordqty"); // long 16
				block.orduserid = query.GetFieldData(block.GetBlockName(), "orduserid"); // char 16
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

	public partial class XQt1101InBlock : XingBlock
	{
		/// <summary>
		/// t1101InBlock
		/// </summary>
		static readonly string _blockName = "t1101InBlock";
		/// <summary>
		/// 기본입력
		/// </summary>
		static readonly string _blockDesc = "기본입력";
		/// <summary>
		/// input
		/// </summary>
		static readonly string _blockType = "input";
		/// <summary>
		/// t1101InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1101InBlock
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
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("단축코드")]
		public string shcode;

		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)6);

			return dict;
		}

		public bool VerifyData()
		{
			if (shcode.Length > 6) return false; // char 6

			return true;
		}
	}

	public partial class XQt1101OutBlock : XingBlock
	{
		/// <summary>
		/// t1101OutBlock
		/// </summary>
		static readonly string _blockName = "t1101OutBlock";
		/// <summary>
		/// 출력
		/// </summary>
		static readonly string _blockDesc = "출력";
		/// <summary>
		/// output
		/// </summary>
		static readonly string _blockType = "output";
		/// <summary>
		/// t1101OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1101OutBlock
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
		/// 전일종가
		/// </summary>
		[XAQueryFieldAttribute("전일종가")]
		public long jnilclose;
		/// <summary>
		/// 매도호가1
		/// </summary>
		[XAQueryFieldAttribute("매도호가1")]
		public long offerho1;
		/// <summary>
		/// 매수호가1
		/// </summary>
		[XAQueryFieldAttribute("매수호가1")]
		public long bidho1;
		/// <summary>
		/// 매도호가수량1
		/// </summary>
		[XAQueryFieldAttribute("매도호가수량1")]
		public long offerrem1;
		/// <summary>
		/// 매수호가수량1
		/// </summary>
		[XAQueryFieldAttribute("매수호가수량1")]
		public long bidrem1;
		/// <summary>
		/// 직전매도대비수량1
		/// </summary>
		[XAQueryFieldAttribute("직전매도대비수량1")]
		public long preoffercha1;
		/// <summary>
		/// 직전매수대비수량1
		/// </summary>
		[XAQueryFieldAttribute("직전매수대비수량1")]
		public long prebidcha1;
		/// <summary>
		/// 매도호가2
		/// </summary>
		[XAQueryFieldAttribute("매도호가2")]
		public long offerho2;
		/// <summary>
		/// 매수호가2
		/// </summary>
		[XAQueryFieldAttribute("매수호가2")]
		public long bidho2;
		/// <summary>
		/// 매도호가수량2
		/// </summary>
		[XAQueryFieldAttribute("매도호가수량2")]
		public long offerrem2;
		/// <summary>
		/// 매수호가수량2
		/// </summary>
		[XAQueryFieldAttribute("매수호가수량2")]
		public long bidrem2;
		/// <summary>
		/// 직전매도대비수량2
		/// </summary>
		[XAQueryFieldAttribute("직전매도대비수량2")]
		public long preoffercha2;
		/// <summary>
		/// 직전매수대비수량2
		/// </summary>
		[XAQueryFieldAttribute("직전매수대비수량2")]
		public long prebidcha2;
		/// <summary>
		/// 매도호가3
		/// </summary>
		[XAQueryFieldAttribute("매도호가3")]
		public long offerho3;
		/// <summary>
		/// 매수호가3
		/// </summary>
		[XAQueryFieldAttribute("매수호가3")]
		public long bidho3;
		/// <summary>
		/// 매도호가수량3
		/// </summary>
		[XAQueryFieldAttribute("매도호가수량3")]
		public long offerrem3;
		/// <summary>
		/// 매수호가수량3
		/// </summary>
		[XAQueryFieldAttribute("매수호가수량3")]
		public long bidrem3;
		/// <summary>
		/// 직전매도대비수량3
		/// </summary>
		[XAQueryFieldAttribute("직전매도대비수량3")]
		public long preoffercha3;
		/// <summary>
		/// 직전매수대비수량3
		/// </summary>
		[XAQueryFieldAttribute("직전매수대비수량3")]
		public long prebidcha3;
		/// <summary>
		/// 매도호가4
		/// </summary>
		[XAQueryFieldAttribute("매도호가4")]
		public long offerho4;
		/// <summary>
		/// 매수호가4
		/// </summary>
		[XAQueryFieldAttribute("매수호가4")]
		public long bidho4;
		/// <summary>
		/// 매도호가수량4
		/// </summary>
		[XAQueryFieldAttribute("매도호가수량4")]
		public long offerrem4;
		/// <summary>
		/// 매수호가수량4
		/// </summary>
		[XAQueryFieldAttribute("매수호가수량4")]
		public long bidrem4;
		/// <summary>
		/// 직전매도대비수량4
		/// </summary>
		[XAQueryFieldAttribute("직전매도대비수량4")]
		public long preoffercha4;
		/// <summary>
		/// 직전매수대비수량4
		/// </summary>
		[XAQueryFieldAttribute("직전매수대비수량4")]
		public long prebidcha4;
		/// <summary>
		/// 매도호가5
		/// </summary>
		[XAQueryFieldAttribute("매도호가5")]
		public long offerho5;
		/// <summary>
		/// 매수호가5
		/// </summary>
		[XAQueryFieldAttribute("매수호가5")]
		public long bidho5;
		/// <summary>
		/// 매도호가수량5
		/// </summary>
		[XAQueryFieldAttribute("매도호가수량5")]
		public long offerrem5;
		/// <summary>
		/// 매수호가수량5
		/// </summary>
		[XAQueryFieldAttribute("매수호가수량5")]
		public long bidrem5;
		/// <summary>
		/// 직전매도대비수량5
		/// </summary>
		[XAQueryFieldAttribute("직전매도대비수량5")]
		public long preoffercha5;
		/// <summary>
		/// 직전매수대비수량5
		/// </summary>
		[XAQueryFieldAttribute("직전매수대비수량5")]
		public long prebidcha5;
		/// <summary>
		/// 매도호가6
		/// </summary>
		[XAQueryFieldAttribute("매도호가6")]
		public long offerho6;
		/// <summary>
		/// 매수호가6
		/// </summary>
		[XAQueryFieldAttribute("매수호가6")]
		public long bidho6;
		/// <summary>
		/// 매도호가수량6
		/// </summary>
		[XAQueryFieldAttribute("매도호가수량6")]
		public long offerrem6;
		/// <summary>
		/// 매수호가수량6
		/// </summary>
		[XAQueryFieldAttribute("매수호가수량6")]
		public long bidrem6;
		/// <summary>
		/// 직전매도대비수량6
		/// </summary>
		[XAQueryFieldAttribute("직전매도대비수량6")]
		public long preoffercha6;
		/// <summary>
		/// 직전매수대비수량6
		/// </summary>
		[XAQueryFieldAttribute("직전매수대비수량6")]
		public long prebidcha6;
		/// <summary>
		/// 매도호가7
		/// </summary>
		[XAQueryFieldAttribute("매도호가7")]
		public long offerho7;
		/// <summary>
		/// 매수호가7
		/// </summary>
		[XAQueryFieldAttribute("매수호가7")]
		public long bidho7;
		/// <summary>
		/// 매도호가수량7
		/// </summary>
		[XAQueryFieldAttribute("매도호가수량7")]
		public long offerrem7;
		/// <summary>
		/// 매수호가수량7
		/// </summary>
		[XAQueryFieldAttribute("매수호가수량7")]
		public long bidrem7;
		/// <summary>
		/// 직전매도대비수량7
		/// </summary>
		[XAQueryFieldAttribute("직전매도대비수량7")]
		public long preoffercha7;
		/// <summary>
		/// 직전매수대비수량7
		/// </summary>
		[XAQueryFieldAttribute("직전매수대비수량7")]
		public long prebidcha7;
		/// <summary>
		/// 매도호가8
		/// </summary>
		[XAQueryFieldAttribute("매도호가8")]
		public long offerho8;
		/// <summary>
		/// 매수호가8
		/// </summary>
		[XAQueryFieldAttribute("매수호가8")]
		public long bidho8;
		/// <summary>
		/// 매도호가수량8
		/// </summary>
		[XAQueryFieldAttribute("매도호가수량8")]
		public long offerrem8;
		/// <summary>
		/// 매수호가수량8
		/// </summary>
		[XAQueryFieldAttribute("매수호가수량8")]
		public long bidrem8;
		/// <summary>
		/// 직전매도대비수량8
		/// </summary>
		[XAQueryFieldAttribute("직전매도대비수량8")]
		public long preoffercha8;
		/// <summary>
		/// 직전매수대비수량8
		/// </summary>
		[XAQueryFieldAttribute("직전매수대비수량8")]
		public long prebidcha8;
		/// <summary>
		/// 매도호가9
		/// </summary>
		[XAQueryFieldAttribute("매도호가9")]
		public long offerho9;
		/// <summary>
		/// 매수호가9
		/// </summary>
		[XAQueryFieldAttribute("매수호가9")]
		public long bidho9;
		/// <summary>
		/// 매도호가수량9
		/// </summary>
		[XAQueryFieldAttribute("매도호가수량9")]
		public long offerrem9;
		/// <summary>
		/// 매수호가수량9
		/// </summary>
		[XAQueryFieldAttribute("매수호가수량9")]
		public long bidrem9;
		/// <summary>
		/// 직전매도대비수량9
		/// </summary>
		[XAQueryFieldAttribute("직전매도대비수량9")]
		public long preoffercha9;
		/// <summary>
		/// 직전매수대비수량9
		/// </summary>
		[XAQueryFieldAttribute("직전매수대비수량9")]
		public long prebidcha9;
		/// <summary>
		/// 매도호가10
		/// </summary>
		[XAQueryFieldAttribute("매도호가10")]
		public long offerho10;
		/// <summary>
		/// 매수호가10
		/// </summary>
		[XAQueryFieldAttribute("매수호가10")]
		public long bidho10;
		/// <summary>
		/// 매도호가수량10
		/// </summary>
		[XAQueryFieldAttribute("매도호가수량10")]
		public long offerrem10;
		/// <summary>
		/// 매수호가수량10
		/// </summary>
		[XAQueryFieldAttribute("매수호가수량10")]
		public long bidrem10;
		/// <summary>
		/// 직전매도대비수량10
		/// </summary>
		[XAQueryFieldAttribute("직전매도대비수량10")]
		public long preoffercha10;
		/// <summary>
		/// 직전매수대비수량10
		/// </summary>
		[XAQueryFieldAttribute("직전매수대비수량10")]
		public long prebidcha10;
		/// <summary>
		/// 매도호가수량합
		/// </summary>
		[XAQueryFieldAttribute("매도호가수량합")]
		public long offer;
		/// <summary>
		/// 매수호가수량합
		/// </summary>
		[XAQueryFieldAttribute("매수호가수량합")]
		public long bid;
		/// <summary>
		/// 직전매도대비수량합
		/// </summary>
		[XAQueryFieldAttribute("직전매도대비수량합")]
		public long preoffercha;
		/// <summary>
		/// 직전매수대비수량합
		/// </summary>
		[XAQueryFieldAttribute("직전매수대비수량합")]
		public long prebidcha;
		/// <summary>
		/// 수신시간
		/// </summary>
		[XAQueryFieldAttribute("수신시간")]
		public string hotime;
		/// <summary>
		/// 예상체결가격
		/// </summary>
		[XAQueryFieldAttribute("예상체결가격")]
		public long yeprice;
		/// <summary>
		/// 예상체결수량
		/// </summary>
		[XAQueryFieldAttribute("예상체결수량")]
		public long yevolume;
		/// <summary>
		/// 예상체결전일구분
		/// </summary>
		[XAQueryFieldAttribute("예상체결전일구분")]
		public char yesign;
		/// <summary>
		/// 예상체결전일대비
		/// </summary>
		[XAQueryFieldAttribute("예상체결전일대비")]
		public long yechange;
		/// <summary>
		/// 예상체결등락율
		/// </summary>
		[XAQueryFieldAttribute("예상체결등락율")]
		public float yediff;
		/// <summary>
		/// 시간외매도잔량
		/// </summary>
		[XAQueryFieldAttribute("시간외매도잔량")]
		public long tmoffer;
		/// <summary>
		/// 시간외매수잔량
		/// </summary>
		[XAQueryFieldAttribute("시간외매수잔량")]
		public long tmbid;
		/// <summary>
		/// 동시구분
		/// </summary>
		[XAQueryFieldAttribute("동시구분")]
		public char ho_status;
		/// <summary>
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("단축코드")]
		public string shcode;
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

		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["hname"] = new XAQueryFieldInfo("char", hname, hname, "한글명", (decimal)20);
			dict["price"] = new XAQueryFieldInfo("long", price, price.ToString("d8"), "현재가", (decimal)8);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("long", change, change.ToString("d8"), "전일대비", (decimal)8);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "누적거래량", (decimal)12);
			dict["jnilclose"] = new XAQueryFieldInfo("long", jnilclose, jnilclose.ToString("d8"), "전일종가", (decimal)8);
			dict["offerho1"] = new XAQueryFieldInfo("long", offerho1, offerho1.ToString("d8"), "매도호가1", (decimal)8);
			dict["bidho1"] = new XAQueryFieldInfo("long", bidho1, bidho1.ToString("d8"), "매수호가1", (decimal)8);
			dict["offerrem1"] = new XAQueryFieldInfo("long", offerrem1, offerrem1.ToString("d12"), "매도호가수량1", (decimal)12);
			dict["bidrem1"] = new XAQueryFieldInfo("long", bidrem1, bidrem1.ToString("d12"), "매수호가수량1", (decimal)12);
			dict["preoffercha1"] = new XAQueryFieldInfo("long", preoffercha1, preoffercha1.ToString("d12"), "직전매도대비수량1", (decimal)12);
			dict["prebidcha1"] = new XAQueryFieldInfo("long", prebidcha1, prebidcha1.ToString("d12"), "직전매수대비수량1", (decimal)12);
			dict["offerho2"] = new XAQueryFieldInfo("long", offerho2, offerho2.ToString("d8"), "매도호가2", (decimal)8);
			dict["bidho2"] = new XAQueryFieldInfo("long", bidho2, bidho2.ToString("d8"), "매수호가2", (decimal)8);
			dict["offerrem2"] = new XAQueryFieldInfo("long", offerrem2, offerrem2.ToString("d12"), "매도호가수량2", (decimal)12);
			dict["bidrem2"] = new XAQueryFieldInfo("long", bidrem2, bidrem2.ToString("d12"), "매수호가수량2", (decimal)12);
			dict["preoffercha2"] = new XAQueryFieldInfo("long", preoffercha2, preoffercha2.ToString("d12"), "직전매도대비수량2", (decimal)12);
			dict["prebidcha2"] = new XAQueryFieldInfo("long", prebidcha2, prebidcha2.ToString("d12"), "직전매수대비수량2", (decimal)12);
			dict["offerho3"] = new XAQueryFieldInfo("long", offerho3, offerho3.ToString("d8"), "매도호가3", (decimal)8);
			dict["bidho3"] = new XAQueryFieldInfo("long", bidho3, bidho3.ToString("d8"), "매수호가3", (decimal)8);
			dict["offerrem3"] = new XAQueryFieldInfo("long", offerrem3, offerrem3.ToString("d12"), "매도호가수량3", (decimal)12);
			dict["bidrem3"] = new XAQueryFieldInfo("long", bidrem3, bidrem3.ToString("d12"), "매수호가수량3", (decimal)12);
			dict["preoffercha3"] = new XAQueryFieldInfo("long", preoffercha3, preoffercha3.ToString("d12"), "직전매도대비수량3", (decimal)12);
			dict["prebidcha3"] = new XAQueryFieldInfo("long", prebidcha3, prebidcha3.ToString("d12"), "직전매수대비수량3", (decimal)12);
			dict["offerho4"] = new XAQueryFieldInfo("long", offerho4, offerho4.ToString("d8"), "매도호가4", (decimal)8);
			dict["bidho4"] = new XAQueryFieldInfo("long", bidho4, bidho4.ToString("d8"), "매수호가4", (decimal)8);
			dict["offerrem4"] = new XAQueryFieldInfo("long", offerrem4, offerrem4.ToString("d12"), "매도호가수량4", (decimal)12);
			dict["bidrem4"] = new XAQueryFieldInfo("long", bidrem4, bidrem4.ToString("d12"), "매수호가수량4", (decimal)12);
			dict["preoffercha4"] = new XAQueryFieldInfo("long", preoffercha4, preoffercha4.ToString("d12"), "직전매도대비수량4", (decimal)12);
			dict["prebidcha4"] = new XAQueryFieldInfo("long", prebidcha4, prebidcha4.ToString("d12"), "직전매수대비수량4", (decimal)12);
			dict["offerho5"] = new XAQueryFieldInfo("long", offerho5, offerho5.ToString("d8"), "매도호가5", (decimal)8);
			dict["bidho5"] = new XAQueryFieldInfo("long", bidho5, bidho5.ToString("d8"), "매수호가5", (decimal)8);
			dict["offerrem5"] = new XAQueryFieldInfo("long", offerrem5, offerrem5.ToString("d12"), "매도호가수량5", (decimal)12);
			dict["bidrem5"] = new XAQueryFieldInfo("long", bidrem5, bidrem5.ToString("d12"), "매수호가수량5", (decimal)12);
			dict["preoffercha5"] = new XAQueryFieldInfo("long", preoffercha5, preoffercha5.ToString("d12"), "직전매도대비수량5", (decimal)12);
			dict["prebidcha5"] = new XAQueryFieldInfo("long", prebidcha5, prebidcha5.ToString("d12"), "직전매수대비수량5", (decimal)12);
			dict["offerho6"] = new XAQueryFieldInfo("long", offerho6, offerho6.ToString("d8"), "매도호가6", (decimal)8);
			dict["bidho6"] = new XAQueryFieldInfo("long", bidho6, bidho6.ToString("d8"), "매수호가6", (decimal)8);
			dict["offerrem6"] = new XAQueryFieldInfo("long", offerrem6, offerrem6.ToString("d12"), "매도호가수량6", (decimal)12);
			dict["bidrem6"] = new XAQueryFieldInfo("long", bidrem6, bidrem6.ToString("d12"), "매수호가수량6", (decimal)12);
			dict["preoffercha6"] = new XAQueryFieldInfo("long", preoffercha6, preoffercha6.ToString("d12"), "직전매도대비수량6", (decimal)12);
			dict["prebidcha6"] = new XAQueryFieldInfo("long", prebidcha6, prebidcha6.ToString("d12"), "직전매수대비수량6", (decimal)12);
			dict["offerho7"] = new XAQueryFieldInfo("long", offerho7, offerho7.ToString("d8"), "매도호가7", (decimal)8);
			dict["bidho7"] = new XAQueryFieldInfo("long", bidho7, bidho7.ToString("d8"), "매수호가7", (decimal)8);
			dict["offerrem7"] = new XAQueryFieldInfo("long", offerrem7, offerrem7.ToString("d12"), "매도호가수량7", (decimal)12);
			dict["bidrem7"] = new XAQueryFieldInfo("long", bidrem7, bidrem7.ToString("d12"), "매수호가수량7", (decimal)12);
			dict["preoffercha7"] = new XAQueryFieldInfo("long", preoffercha7, preoffercha7.ToString("d12"), "직전매도대비수량7", (decimal)12);
			dict["prebidcha7"] = new XAQueryFieldInfo("long", prebidcha7, prebidcha7.ToString("d12"), "직전매수대비수량7", (decimal)12);
			dict["offerho8"] = new XAQueryFieldInfo("long", offerho8, offerho8.ToString("d8"), "매도호가8", (decimal)8);
			dict["bidho8"] = new XAQueryFieldInfo("long", bidho8, bidho8.ToString("d8"), "매수호가8", (decimal)8);
			dict["offerrem8"] = new XAQueryFieldInfo("long", offerrem8, offerrem8.ToString("d12"), "매도호가수량8", (decimal)12);
			dict["bidrem8"] = new XAQueryFieldInfo("long", bidrem8, bidrem8.ToString("d12"), "매수호가수량8", (decimal)12);
			dict["preoffercha8"] = new XAQueryFieldInfo("long", preoffercha8, preoffercha8.ToString("d12"), "직전매도대비수량8", (decimal)12);
			dict["prebidcha8"] = new XAQueryFieldInfo("long", prebidcha8, prebidcha8.ToString("d12"), "직전매수대비수량8", (decimal)12);
			dict["offerho9"] = new XAQueryFieldInfo("long", offerho9, offerho9.ToString("d8"), "매도호가9", (decimal)8);
			dict["bidho9"] = new XAQueryFieldInfo("long", bidho9, bidho9.ToString("d8"), "매수호가9", (decimal)8);
			dict["offerrem9"] = new XAQueryFieldInfo("long", offerrem9, offerrem9.ToString("d12"), "매도호가수량9", (decimal)12);
			dict["bidrem9"] = new XAQueryFieldInfo("long", bidrem9, bidrem9.ToString("d12"), "매수호가수량9", (decimal)12);
			dict["preoffercha9"] = new XAQueryFieldInfo("long", preoffercha9, preoffercha9.ToString("d12"), "직전매도대비수량9", (decimal)12);
			dict["prebidcha9"] = new XAQueryFieldInfo("long", prebidcha9, prebidcha9.ToString("d12"), "직전매수대비수량9", (decimal)12);
			dict["offerho10"] = new XAQueryFieldInfo("long", offerho10, offerho10.ToString("d8"), "매도호가10", (decimal)8);
			dict["bidho10"] = new XAQueryFieldInfo("long", bidho10, bidho10.ToString("d8"), "매수호가10", (decimal)8);
			dict["offerrem10"] = new XAQueryFieldInfo("long", offerrem10, offerrem10.ToString("d12"), "매도호가수량10", (decimal)12);
			dict["bidrem10"] = new XAQueryFieldInfo("long", bidrem10, bidrem10.ToString("d12"), "매수호가수량10", (decimal)12);
			dict["preoffercha10"] = new XAQueryFieldInfo("long", preoffercha10, preoffercha10.ToString("d12"), "직전매도대비수량10", (decimal)12);
			dict["prebidcha10"] = new XAQueryFieldInfo("long", prebidcha10, prebidcha10.ToString("d12"), "직전매수대비수량10", (decimal)12);
			dict["offer"] = new XAQueryFieldInfo("long", offer, offer.ToString("d12"), "매도호가수량합", (decimal)12);
			dict["bid"] = new XAQueryFieldInfo("long", bid, bid.ToString("d12"), "매수호가수량합", (decimal)12);
			dict["preoffercha"] = new XAQueryFieldInfo("long", preoffercha, preoffercha.ToString("d12"), "직전매도대비수량합", (decimal)12);
			dict["prebidcha"] = new XAQueryFieldInfo("long", prebidcha, prebidcha.ToString("d12"), "직전매수대비수량합", (decimal)12);
			dict["hotime"] = new XAQueryFieldInfo("char", hotime, hotime, "수신시간", (decimal)8);
			dict["yeprice"] = new XAQueryFieldInfo("long", yeprice, yeprice.ToString("d8"), "예상체결가격", (decimal)8);
			dict["yevolume"] = new XAQueryFieldInfo("long", yevolume, yevolume.ToString("d12"), "예상체결수량", (decimal)12);
			dict["yesign"] = new XAQueryFieldInfo("char", yesign, yesign.ToString(), "예상체결전일구분", (decimal)1);
			dict["yechange"] = new XAQueryFieldInfo("long", yechange, yechange.ToString("d8"), "예상체결전일대비", (decimal)8);
			dict["yediff"] = new XAQueryFieldInfo("float", yediff, yediff.ToString("000000.00"), "예상체결등락율", (decimal)6.2);
			dict["tmoffer"] = new XAQueryFieldInfo("long", tmoffer, tmoffer.ToString("d12"), "시간외매도잔량", (decimal)12);
			dict["tmbid"] = new XAQueryFieldInfo("long", tmbid, tmbid.ToString("d12"), "시간외매수잔량", (decimal)12);
			dict["ho_status"] = new XAQueryFieldInfo("char", ho_status, ho_status.ToString(), "동시구분", (decimal)1);
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)6);
			dict["uplmtprice"] = new XAQueryFieldInfo("long", uplmtprice, uplmtprice.ToString("d8"), "상한가", (decimal)8);
			dict["dnlmtprice"] = new XAQueryFieldInfo("long", dnlmtprice, dnlmtprice.ToString("d8"), "하한가", (decimal)8);
			dict["open"] = new XAQueryFieldInfo("long", open, open.ToString("d8"), "시가", (decimal)8);
			dict["high"] = new XAQueryFieldInfo("long", high, high.ToString("d8"), "고가", (decimal)8);
			dict["low"] = new XAQueryFieldInfo("long", low, low.ToString("d8"), "저가", (decimal)8);

			return dict;
		}

		public static XQt1101OutBlock FromQuery(XQt1101 query)
		{
			XQt1101OutBlock block = new XQt1101OutBlock();
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
				block.hname = query.GetFieldData(block.GetBlockName(), "hname", 0); // char 20
				block.price = query.GetFieldData(block.GetBlockName(), "price", 0).ParseLong("price"); // long 8
				block.sign = query.GetFieldData(block.GetBlockName(), "sign", 0).First(); // char 1
				block.change = query.GetFieldData(block.GetBlockName(), "change", 0).ParseLong("change"); // long 8
				block.diff = query.GetFieldData(block.GetBlockName(), "diff", 0).ParseFloat("diff"); // float 6.2
				block.volume = query.GetFieldData(block.GetBlockName(), "volume", 0).ParseLong("volume"); // long 12
				block.jnilclose = query.GetFieldData(block.GetBlockName(), "jnilclose", 0).ParseLong("jnilclose"); // long 8
				block.offerho1 = query.GetFieldData(block.GetBlockName(), "offerho1", 0).ParseLong("offerho1"); // long 8
				block.bidho1 = query.GetFieldData(block.GetBlockName(), "bidho1", 0).ParseLong("bidho1"); // long 8
				block.offerrem1 = query.GetFieldData(block.GetBlockName(), "offerrem1", 0).ParseLong("offerrem1"); // long 12
				block.bidrem1 = query.GetFieldData(block.GetBlockName(), "bidrem1", 0).ParseLong("bidrem1"); // long 12
				block.preoffercha1 = query.GetFieldData(block.GetBlockName(), "preoffercha1", 0).ParseLong("preoffercha1"); // long 12
				block.prebidcha1 = query.GetFieldData(block.GetBlockName(), "prebidcha1", 0).ParseLong("prebidcha1"); // long 12
				block.offerho2 = query.GetFieldData(block.GetBlockName(), "offerho2", 0).ParseLong("offerho2"); // long 8
				block.bidho2 = query.GetFieldData(block.GetBlockName(), "bidho2", 0).ParseLong("bidho2"); // long 8
				block.offerrem2 = query.GetFieldData(block.GetBlockName(), "offerrem2", 0).ParseLong("offerrem2"); // long 12
				block.bidrem2 = query.GetFieldData(block.GetBlockName(), "bidrem2", 0).ParseLong("bidrem2"); // long 12
				block.preoffercha2 = query.GetFieldData(block.GetBlockName(), "preoffercha2", 0).ParseLong("preoffercha2"); // long 12
				block.prebidcha2 = query.GetFieldData(block.GetBlockName(), "prebidcha2", 0).ParseLong("prebidcha2"); // long 12
				block.offerho3 = query.GetFieldData(block.GetBlockName(), "offerho3", 0).ParseLong("offerho3"); // long 8
				block.bidho3 = query.GetFieldData(block.GetBlockName(), "bidho3", 0).ParseLong("bidho3"); // long 8
				block.offerrem3 = query.GetFieldData(block.GetBlockName(), "offerrem3", 0).ParseLong("offerrem3"); // long 12
				block.bidrem3 = query.GetFieldData(block.GetBlockName(), "bidrem3", 0).ParseLong("bidrem3"); // long 12
				block.preoffercha3 = query.GetFieldData(block.GetBlockName(), "preoffercha3", 0).ParseLong("preoffercha3"); // long 12
				block.prebidcha3 = query.GetFieldData(block.GetBlockName(), "prebidcha3", 0).ParseLong("prebidcha3"); // long 12
				block.offerho4 = query.GetFieldData(block.GetBlockName(), "offerho4", 0).ParseLong("offerho4"); // long 8
				block.bidho4 = query.GetFieldData(block.GetBlockName(), "bidho4", 0).ParseLong("bidho4"); // long 8
				block.offerrem4 = query.GetFieldData(block.GetBlockName(), "offerrem4", 0).ParseLong("offerrem4"); // long 12
				block.bidrem4 = query.GetFieldData(block.GetBlockName(), "bidrem4", 0).ParseLong("bidrem4"); // long 12
				block.preoffercha4 = query.GetFieldData(block.GetBlockName(), "preoffercha4", 0).ParseLong("preoffercha4"); // long 12
				block.prebidcha4 = query.GetFieldData(block.GetBlockName(), "prebidcha4", 0).ParseLong("prebidcha4"); // long 12
				block.offerho5 = query.GetFieldData(block.GetBlockName(), "offerho5", 0).ParseLong("offerho5"); // long 8
				block.bidho5 = query.GetFieldData(block.GetBlockName(), "bidho5", 0).ParseLong("bidho5"); // long 8
				block.offerrem5 = query.GetFieldData(block.GetBlockName(), "offerrem5", 0).ParseLong("offerrem5"); // long 12
				block.bidrem5 = query.GetFieldData(block.GetBlockName(), "bidrem5", 0).ParseLong("bidrem5"); // long 12
				block.preoffercha5 = query.GetFieldData(block.GetBlockName(), "preoffercha5", 0).ParseLong("preoffercha5"); // long 12
				block.prebidcha5 = query.GetFieldData(block.GetBlockName(), "prebidcha5", 0).ParseLong("prebidcha5"); // long 12
				block.offerho6 = query.GetFieldData(block.GetBlockName(), "offerho6", 0).ParseLong("offerho6"); // long 8
				block.bidho6 = query.GetFieldData(block.GetBlockName(), "bidho6", 0).ParseLong("bidho6"); // long 8
				block.offerrem6 = query.GetFieldData(block.GetBlockName(), "offerrem6", 0).ParseLong("offerrem6"); // long 12
				block.bidrem6 = query.GetFieldData(block.GetBlockName(), "bidrem6", 0).ParseLong("bidrem6"); // long 12
				block.preoffercha6 = query.GetFieldData(block.GetBlockName(), "preoffercha6", 0).ParseLong("preoffercha6"); // long 12
				block.prebidcha6 = query.GetFieldData(block.GetBlockName(), "prebidcha6", 0).ParseLong("prebidcha6"); // long 12
				block.offerho7 = query.GetFieldData(block.GetBlockName(), "offerho7", 0).ParseLong("offerho7"); // long 8
				block.bidho7 = query.GetFieldData(block.GetBlockName(), "bidho7", 0).ParseLong("bidho7"); // long 8
				block.offerrem7 = query.GetFieldData(block.GetBlockName(), "offerrem7", 0).ParseLong("offerrem7"); // long 12
				block.bidrem7 = query.GetFieldData(block.GetBlockName(), "bidrem7", 0).ParseLong("bidrem7"); // long 12
				block.preoffercha7 = query.GetFieldData(block.GetBlockName(), "preoffercha7", 0).ParseLong("preoffercha7"); // long 12
				block.prebidcha7 = query.GetFieldData(block.GetBlockName(), "prebidcha7", 0).ParseLong("prebidcha7"); // long 12
				block.offerho8 = query.GetFieldData(block.GetBlockName(), "offerho8", 0).ParseLong("offerho8"); // long 8
				block.bidho8 = query.GetFieldData(block.GetBlockName(), "bidho8", 0).ParseLong("bidho8"); // long 8
				block.offerrem8 = query.GetFieldData(block.GetBlockName(), "offerrem8", 0).ParseLong("offerrem8"); // long 12
				block.bidrem8 = query.GetFieldData(block.GetBlockName(), "bidrem8", 0).ParseLong("bidrem8"); // long 12
				block.preoffercha8 = query.GetFieldData(block.GetBlockName(), "preoffercha8", 0).ParseLong("preoffercha8"); // long 12
				block.prebidcha8 = query.GetFieldData(block.GetBlockName(), "prebidcha8", 0).ParseLong("prebidcha8"); // long 12
				block.offerho9 = query.GetFieldData(block.GetBlockName(), "offerho9", 0).ParseLong("offerho9"); // long 8
				block.bidho9 = query.GetFieldData(block.GetBlockName(), "bidho9", 0).ParseLong("bidho9"); // long 8
				block.offerrem9 = query.GetFieldData(block.GetBlockName(), "offerrem9", 0).ParseLong("offerrem9"); // long 12
				block.bidrem9 = query.GetFieldData(block.GetBlockName(), "bidrem9", 0).ParseLong("bidrem9"); // long 12
				block.preoffercha9 = query.GetFieldData(block.GetBlockName(), "preoffercha9", 0).ParseLong("preoffercha9"); // long 12
				block.prebidcha9 = query.GetFieldData(block.GetBlockName(), "prebidcha9", 0).ParseLong("prebidcha9"); // long 12
				block.offerho10 = query.GetFieldData(block.GetBlockName(), "offerho10", 0).ParseLong("offerho10"); // long 8
				block.bidho10 = query.GetFieldData(block.GetBlockName(), "bidho10", 0).ParseLong("bidho10"); // long 8
				block.offerrem10 = query.GetFieldData(block.GetBlockName(), "offerrem10", 0).ParseLong("offerrem10"); // long 12
				block.bidrem10 = query.GetFieldData(block.GetBlockName(), "bidrem10", 0).ParseLong("bidrem10"); // long 12
				block.preoffercha10 = query.GetFieldData(block.GetBlockName(), "preoffercha10", 0).ParseLong("preoffercha10"); // long 12
				block.prebidcha10 = query.GetFieldData(block.GetBlockName(), "prebidcha10", 0).ParseLong("prebidcha10"); // long 12
				block.offer = query.GetFieldData(block.GetBlockName(), "offer", 0).ParseLong("offer"); // long 12
				block.bid = query.GetFieldData(block.GetBlockName(), "bid", 0).ParseLong("bid"); // long 12
				block.preoffercha = query.GetFieldData(block.GetBlockName(), "preoffercha", 0).ParseLong("preoffercha"); // long 12
				block.prebidcha = query.GetFieldData(block.GetBlockName(), "prebidcha", 0).ParseLong("prebidcha"); // long 12
				block.hotime = query.GetFieldData(block.GetBlockName(), "hotime", 0); // char 8
				block.yeprice = query.GetFieldData(block.GetBlockName(), "yeprice", 0).ParseLong("yeprice"); // long 8
				block.yevolume = query.GetFieldData(block.GetBlockName(), "yevolume", 0).ParseLong("yevolume"); // long 12
				block.yesign = query.GetFieldData(block.GetBlockName(), "yesign", 0).First(); // char 1
				block.yechange = query.GetFieldData(block.GetBlockName(), "yechange", 0).ParseLong("yechange"); // long 8
				block.yediff = query.GetFieldData(block.GetBlockName(), "yediff", 0).ParseFloat("yediff"); // float 6.2
				block.tmoffer = query.GetFieldData(block.GetBlockName(), "tmoffer", 0).ParseLong("tmoffer"); // long 12
				block.tmbid = query.GetFieldData(block.GetBlockName(), "tmbid", 0).ParseLong("tmbid"); // long 12
				block.ho_status = query.GetFieldData(block.GetBlockName(), "ho_status", 0).First(); // char 1
				block.shcode = query.GetFieldData(block.GetBlockName(), "shcode", 0); // char 6
				block.uplmtprice = query.GetFieldData(block.GetBlockName(), "uplmtprice", 0).ParseLong("uplmtprice"); // long 8
				block.dnlmtprice = query.GetFieldData(block.GetBlockName(), "dnlmtprice", 0).ParseLong("dnlmtprice"); // long 8
				block.open = query.GetFieldData(block.GetBlockName(), "open", 0).ParseLong("open"); // long 8
				block.high = query.GetFieldData(block.GetBlockName(), "high", 0).ParseLong("high"); // long 8
				block.low = query.GetFieldData(block.GetBlockName(), "low", 0).ParseLong("low"); // long 8

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (hname.Length > 20) return false; // char 20
			if (price.ToString().Length > 8) return false; // long 8
			// sign char 1
			if (change.ToString().Length > 8) return false; // long 8
			// diff float 6.2
			if (volume.ToString().Length > 12) return false; // long 12
			if (jnilclose.ToString().Length > 8) return false; // long 8
			if (offerho1.ToString().Length > 8) return false; // long 8
			if (bidho1.ToString().Length > 8) return false; // long 8
			if (offerrem1.ToString().Length > 12) return false; // long 12
			if (bidrem1.ToString().Length > 12) return false; // long 12
			if (preoffercha1.ToString().Length > 12) return false; // long 12
			if (prebidcha1.ToString().Length > 12) return false; // long 12
			if (offerho2.ToString().Length > 8) return false; // long 8
			if (bidho2.ToString().Length > 8) return false; // long 8
			if (offerrem2.ToString().Length > 12) return false; // long 12
			if (bidrem2.ToString().Length > 12) return false; // long 12
			if (preoffercha2.ToString().Length > 12) return false; // long 12
			if (prebidcha2.ToString().Length > 12) return false; // long 12
			if (offerho3.ToString().Length > 8) return false; // long 8
			if (bidho3.ToString().Length > 8) return false; // long 8
			if (offerrem3.ToString().Length > 12) return false; // long 12
			if (bidrem3.ToString().Length > 12) return false; // long 12
			if (preoffercha3.ToString().Length > 12) return false; // long 12
			if (prebidcha3.ToString().Length > 12) return false; // long 12
			if (offerho4.ToString().Length > 8) return false; // long 8
			if (bidho4.ToString().Length > 8) return false; // long 8
			if (offerrem4.ToString().Length > 12) return false; // long 12
			if (bidrem4.ToString().Length > 12) return false; // long 12
			if (preoffercha4.ToString().Length > 12) return false; // long 12
			if (prebidcha4.ToString().Length > 12) return false; // long 12
			if (offerho5.ToString().Length > 8) return false; // long 8
			if (bidho5.ToString().Length > 8) return false; // long 8
			if (offerrem5.ToString().Length > 12) return false; // long 12
			if (bidrem5.ToString().Length > 12) return false; // long 12
			if (preoffercha5.ToString().Length > 12) return false; // long 12
			if (prebidcha5.ToString().Length > 12) return false; // long 12
			if (offerho6.ToString().Length > 8) return false; // long 8
			if (bidho6.ToString().Length > 8) return false; // long 8
			if (offerrem6.ToString().Length > 12) return false; // long 12
			if (bidrem6.ToString().Length > 12) return false; // long 12
			if (preoffercha6.ToString().Length > 12) return false; // long 12
			if (prebidcha6.ToString().Length > 12) return false; // long 12
			if (offerho7.ToString().Length > 8) return false; // long 8
			if (bidho7.ToString().Length > 8) return false; // long 8
			if (offerrem7.ToString().Length > 12) return false; // long 12
			if (bidrem7.ToString().Length > 12) return false; // long 12
			if (preoffercha7.ToString().Length > 12) return false; // long 12
			if (prebidcha7.ToString().Length > 12) return false; // long 12
			if (offerho8.ToString().Length > 8) return false; // long 8
			if (bidho8.ToString().Length > 8) return false; // long 8
			if (offerrem8.ToString().Length > 12) return false; // long 12
			if (bidrem8.ToString().Length > 12) return false; // long 12
			if (preoffercha8.ToString().Length > 12) return false; // long 12
			if (prebidcha8.ToString().Length > 12) return false; // long 12
			if (offerho9.ToString().Length > 8) return false; // long 8
			if (bidho9.ToString().Length > 8) return false; // long 8
			if (offerrem9.ToString().Length > 12) return false; // long 12
			if (bidrem9.ToString().Length > 12) return false; // long 12
			if (preoffercha9.ToString().Length > 12) return false; // long 12
			if (prebidcha9.ToString().Length > 12) return false; // long 12
			if (offerho10.ToString().Length > 8) return false; // long 8
			if (bidho10.ToString().Length > 8) return false; // long 8
			if (offerrem10.ToString().Length > 12) return false; // long 12
			if (bidrem10.ToString().Length > 12) return false; // long 12
			if (preoffercha10.ToString().Length > 12) return false; // long 12
			if (prebidcha10.ToString().Length > 12) return false; // long 12
			if (offer.ToString().Length > 12) return false; // long 12
			if (bid.ToString().Length > 12) return false; // long 12
			if (preoffercha.ToString().Length > 12) return false; // long 12
			if (prebidcha.ToString().Length > 12) return false; // long 12
			if (hotime.Length > 8) return false; // char 8
			if (yeprice.ToString().Length > 8) return false; // long 8
			if (yevolume.ToString().Length > 12) return false; // long 12
			// yesign char 1
			if (yechange.ToString().Length > 8) return false; // long 8
			// yediff float 6.2
			if (tmoffer.ToString().Length > 12) return false; // long 12
			if (tmbid.ToString().Length > 12) return false; // long 12
			// ho_status char 1
			if (shcode.Length > 6) return false; // char 6
			if (uplmtprice.ToString().Length > 8) return false; // long 8
			if (dnlmtprice.ToString().Length > 8) return false; // long 8
			if (open.ToString().Length > 8) return false; // long 8
			if (high.ToString().Length > 8) return false; // long 8
			if (low.ToString().Length > 8) return false; // long 8

			return true;
		}
	}

	public partial class XQt1101 : XingQuery
	{
		/// <summary>
		/// t1101
		/// </summary>
		static readonly string _typeName = "t1101";
		/// <summary>
		/// 주식현재가호가조회(t1101)
		/// </summary>
		static readonly string _typeDesc = "주식현재가호가조회(t1101)";
		/// <summary>
		/// 
		/// </summary>
		static readonly string _service = "";
		/// <summary>
		/// A
		/// </summary>
		static readonly string _headType = "A";
		/// <summary>
		/// 
		/// </summary>
		static readonly string _creator = "";
		/// <summary>
		/// 
		/// </summary>
		static readonly string _createdDate = "";
		/// <summary>
		/// true
		/// </summary>
		static readonly bool _attr = true;
		/// <summary>
		/// true
		/// </summary>
		static readonly bool _block = true;
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _encrypt = false;
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _signature = false;

	/// <summary>
	/// t1101
	/// </summary>
	public string TypeName => _typeName;
	/// <summary>
	/// 주식현재가호가조회(t1101)
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

		public XQt1101() : base("t1101") { }


		public bool SetFields(XQt1101InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "shcode", 0, block.shcode); // char 6

			return true;
		}

		public XQt1101OutBlock GetBlock()
		{
			XQt1101OutBlock instance = XQt1101OutBlock.FromQuery(this);
			return instance;

		}


	}

	public partial class XQt1102InBlock : XingBlock
	{
		/// <summary>
		/// t1102InBlock
		/// </summary>
		static readonly string _blockName = "t1102InBlock";
		/// <summary>
		/// 기본입력
		/// </summary>
		static readonly string _blockDesc = "기본입력";
		/// <summary>
		/// input
		/// </summary>
		static readonly string _blockType = "input";
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
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("단축코드")]
		public string shcode;

		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)6);

			return dict;
		}

		public bool VerifyData()
		{
			if (shcode.Length > 6) return false; // char 6

			return true;
		}
	}

	public partial class XQt1102OutBlock : XingBlock
	{
		/// <summary>
		/// t1102OutBlock
		/// </summary>
		static readonly string _blockName = "t1102OutBlock";
		/// <summary>
		/// 출력
		/// </summary>
		static readonly string _blockDesc = "출력";
		/// <summary>
		/// output
		/// </summary>
		static readonly string _blockType = "output";
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
				block.hname = query.GetFieldData(block.GetBlockName(), "hname", 0); // char 20
				block.price = query.GetFieldData(block.GetBlockName(), "price", 0).ParseLong("price"); // long 8
				block.sign = query.GetFieldData(block.GetBlockName(), "sign", 0).First(); // char 1
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
				block.opentime = query.GetFieldData(block.GetBlockName(), "opentime", 0); // char 6
				block.high = query.GetFieldData(block.GetBlockName(), "high", 0).ParseLong("high"); // long 8
				block.hightime = query.GetFieldData(block.GetBlockName(), "hightime", 0); // char 6
				block.low = query.GetFieldData(block.GetBlockName(), "low", 0).ParseLong("low"); // long 8
				block.lowtime = query.GetFieldData(block.GetBlockName(), "lowtime", 0); // char 6
				block.high52w = query.GetFieldData(block.GetBlockName(), "high52w", 0).ParseLong("high52w"); // long 8
				block.high52wdate = query.GetFieldData(block.GetBlockName(), "high52wdate", 0); // char 8
				block.low52w = query.GetFieldData(block.GetBlockName(), "low52w", 0).ParseLong("low52w"); // long 8
				block.low52wdate = query.GetFieldData(block.GetBlockName(), "low52wdate", 0); // char 8
				block.exhratio = query.GetFieldData(block.GetBlockName(), "exhratio", 0).ParseFloat("exhratio"); // float 6.2
				block.per = query.GetFieldData(block.GetBlockName(), "per", 0).ParseFloat("per"); // float 6.2
				block.pbrx = query.GetFieldData(block.GetBlockName(), "pbrx", 0).ParseFloat("pbrx"); // float 6.2
				block.listing = query.GetFieldData(block.GetBlockName(), "listing", 0).ParseLong("listing"); // long 12
				block.jkrate = query.GetFieldData(block.GetBlockName(), "jkrate", 0).ParseLong("jkrate"); // long 8
				block.memedan = query.GetFieldData(block.GetBlockName(), "memedan", 0); // char 5
				block.offernocd1 = query.GetFieldData(block.GetBlockName(), "offernocd1", 0); // char 3
				block.bidnocd1 = query.GetFieldData(block.GetBlockName(), "bidnocd1", 0); // char 3
				block.offerno1 = query.GetFieldData(block.GetBlockName(), "offerno1", 0); // char 6
				block.bidno1 = query.GetFieldData(block.GetBlockName(), "bidno1", 0); // char 6
				block.dvol1 = query.GetFieldData(block.GetBlockName(), "dvol1", 0).ParseLong("dvol1"); // long 8
				block.svol1 = query.GetFieldData(block.GetBlockName(), "svol1", 0).ParseLong("svol1"); // long 8
				block.dcha1 = query.GetFieldData(block.GetBlockName(), "dcha1", 0).ParseLong("dcha1"); // long 8
				block.scha1 = query.GetFieldData(block.GetBlockName(), "scha1", 0).ParseLong("scha1"); // long 8
				block.ddiff1 = query.GetFieldData(block.GetBlockName(), "ddiff1", 0).ParseFloat("ddiff1"); // float 6.2
				block.sdiff1 = query.GetFieldData(block.GetBlockName(), "sdiff1", 0).ParseFloat("sdiff1"); // float 6.2
				block.offernocd2 = query.GetFieldData(block.GetBlockName(), "offernocd2", 0); // char 3
				block.bidnocd2 = query.GetFieldData(block.GetBlockName(), "bidnocd2", 0); // char 3
				block.offerno2 = query.GetFieldData(block.GetBlockName(), "offerno2", 0); // char 6
				block.bidno2 = query.GetFieldData(block.GetBlockName(), "bidno2", 0); // char 6
				block.dvol2 = query.GetFieldData(block.GetBlockName(), "dvol2", 0).ParseLong("dvol2"); // long 8
				block.svol2 = query.GetFieldData(block.GetBlockName(), "svol2", 0).ParseLong("svol2"); // long 8
				block.dcha2 = query.GetFieldData(block.GetBlockName(), "dcha2", 0).ParseLong("dcha2"); // long 8
				block.scha2 = query.GetFieldData(block.GetBlockName(), "scha2", 0).ParseLong("scha2"); // long 8
				block.ddiff2 = query.GetFieldData(block.GetBlockName(), "ddiff2", 0).ParseFloat("ddiff2"); // float 6.2
				block.sdiff2 = query.GetFieldData(block.GetBlockName(), "sdiff2", 0).ParseFloat("sdiff2"); // float 6.2
				block.offernocd3 = query.GetFieldData(block.GetBlockName(), "offernocd3", 0); // char 3
				block.bidnocd3 = query.GetFieldData(block.GetBlockName(), "bidnocd3", 0); // char 3
				block.offerno3 = query.GetFieldData(block.GetBlockName(), "offerno3", 0); // char 6
				block.bidno3 = query.GetFieldData(block.GetBlockName(), "bidno3", 0); // char 6
				block.dvol3 = query.GetFieldData(block.GetBlockName(), "dvol3", 0).ParseLong("dvol3"); // long 8
				block.svol3 = query.GetFieldData(block.GetBlockName(), "svol3", 0).ParseLong("svol3"); // long 8
				block.dcha3 = query.GetFieldData(block.GetBlockName(), "dcha3", 0).ParseLong("dcha3"); // long 8
				block.scha3 = query.GetFieldData(block.GetBlockName(), "scha3", 0).ParseLong("scha3"); // long 8
				block.ddiff3 = query.GetFieldData(block.GetBlockName(), "ddiff3", 0).ParseFloat("ddiff3"); // float 6.2
				block.sdiff3 = query.GetFieldData(block.GetBlockName(), "sdiff3", 0).ParseFloat("sdiff3"); // float 6.2
				block.offernocd4 = query.GetFieldData(block.GetBlockName(), "offernocd4", 0); // char 3
				block.bidnocd4 = query.GetFieldData(block.GetBlockName(), "bidnocd4", 0); // char 3
				block.offerno4 = query.GetFieldData(block.GetBlockName(), "offerno4", 0); // char 6
				block.bidno4 = query.GetFieldData(block.GetBlockName(), "bidno4", 0); // char 6
				block.dvol4 = query.GetFieldData(block.GetBlockName(), "dvol4", 0).ParseLong("dvol4"); // long 8
				block.svol4 = query.GetFieldData(block.GetBlockName(), "svol4", 0).ParseLong("svol4"); // long 8
				block.dcha4 = query.GetFieldData(block.GetBlockName(), "dcha4", 0).ParseLong("dcha4"); // long 8
				block.scha4 = query.GetFieldData(block.GetBlockName(), "scha4", 0).ParseLong("scha4"); // long 8
				block.ddiff4 = query.GetFieldData(block.GetBlockName(), "ddiff4", 0).ParseFloat("ddiff4"); // float 6.2
				block.sdiff4 = query.GetFieldData(block.GetBlockName(), "sdiff4", 0).ParseFloat("sdiff4"); // float 6.2
				block.offernocd5 = query.GetFieldData(block.GetBlockName(), "offernocd5", 0); // char 3
				block.bidnocd5 = query.GetFieldData(block.GetBlockName(), "bidnocd5", 0); // char 3
				block.offerno5 = query.GetFieldData(block.GetBlockName(), "offerno5", 0); // char 6
				block.bidno5 = query.GetFieldData(block.GetBlockName(), "bidno5", 0); // char 6
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
				block.shcode = query.GetFieldData(block.GetBlockName(), "shcode", 0); // char 6
				block.value = query.GetFieldData(block.GetBlockName(), "value", 0).ParseLong("value"); // long 12
				block.jvolume = query.GetFieldData(block.GetBlockName(), "jvolume", 0).ParseLong("jvolume"); // long 12
				block.highyear = query.GetFieldData(block.GetBlockName(), "highyear", 0).ParseLong("highyear"); // long 8
				block.highyeardate = query.GetFieldData(block.GetBlockName(), "highyeardate", 0); // char 8
				block.lowyear = query.GetFieldData(block.GetBlockName(), "lowyear", 0).ParseLong("lowyear"); // long 8
				block.lowyeardate = query.GetFieldData(block.GetBlockName(), "lowyeardate", 0); // char 8
				block.target = query.GetFieldData(block.GetBlockName(), "target", 0).ParseLong("target"); // long 8
				block.capital = query.GetFieldData(block.GetBlockName(), "capital", 0).ParseLong("capital"); // long 12
				block.abscnt = query.GetFieldData(block.GetBlockName(), "abscnt", 0).ParseLong("abscnt"); // long 12
				block.parprice = query.GetFieldData(block.GetBlockName(), "parprice", 0).ParseLong("parprice"); // long 8
				block.gsmm = query.GetFieldData(block.GetBlockName(), "gsmm", 0); // char 2
				block.subprice = query.GetFieldData(block.GetBlockName(), "subprice", 0).ParseLong("subprice"); // long 8
				block.total = query.GetFieldData(block.GetBlockName(), "total", 0).ParseLong("total"); // long 12
				block.listdate = query.GetFieldData(block.GetBlockName(), "listdate", 0); // char 8
				block.name = query.GetFieldData(block.GetBlockName(), "name", 0); // char 10
				block.bfsales = query.GetFieldData(block.GetBlockName(), "bfsales", 0).ParseLong("bfsales"); // long 12
				block.bfoperatingincome = query.GetFieldData(block.GetBlockName(), "bfoperatingincome", 0).ParseLong("bfoperatingincome"); // long 12
				block.bfordinaryincome = query.GetFieldData(block.GetBlockName(), "bfordinaryincome", 0).ParseLong("bfordinaryincome"); // long 12
				block.bfnetincome = query.GetFieldData(block.GetBlockName(), "bfnetincome", 0).ParseLong("bfnetincome"); // long 12
				block.bfeps = query.GetFieldData(block.GetBlockName(), "bfeps", 0).ParseFloat("bfeps"); // float 13.2
				block.name2 = query.GetFieldData(block.GetBlockName(), "name2", 0); // char 10
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
				block.info1 = query.GetFieldData(block.GetBlockName(), "info1", 0); // char 10
				block.info2 = query.GetFieldData(block.GetBlockName(), "info2", 0); // char 10
				block.info3 = query.GetFieldData(block.GetBlockName(), "info3", 0); // char 10
				block.info4 = query.GetFieldData(block.GetBlockName(), "info4", 0); // char 12
				block.janginfo = query.GetFieldData(block.GetBlockName(), "janginfo", 0); // char 10
				block.t_per = query.GetFieldData(block.GetBlockName(), "t_per", 0).ParseFloat("t_per"); // float 6.2
				block.tonghwa = query.GetFieldData(block.GetBlockName(), "tonghwa", 0); // char 3
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
				block.info5 = query.GetFieldData(block.GetBlockName(), "info5", 0); // char 8
				block.spac_gubun = query.GetFieldData(block.GetBlockName(), "spac_gubun", 0).First(); // char 1
				block.issueprice = query.GetFieldData(block.GetBlockName(), "issueprice", 0).ParseLong("issueprice"); // long 8
				block.alloc_gubun = query.GetFieldData(block.GetBlockName(), "alloc_gubun", 0).First(); // char 1
				block.alloc_text = query.GetFieldData(block.GetBlockName(), "alloc_text", 0); // char 8
				block.shterm_text = query.GetFieldData(block.GetBlockName(), "shterm_text", 0); // char 10
				block.svi_uplmtprice = query.GetFieldData(block.GetBlockName(), "svi_uplmtprice", 0).ParseLong("svi_uplmtprice"); // long 8
				block.svi_dnlmtprice = query.GetFieldData(block.GetBlockName(), "svi_dnlmtprice", 0).ParseLong("svi_dnlmtprice"); // long 8
				block.low_lqdt_gu = query.GetFieldData(block.GetBlockName(), "low_lqdt_gu", 0).First(); // char 1
				block.abnormal_rise_gu = query.GetFieldData(block.GetBlockName(), "abnormal_rise_gu", 0).First(); // char 1
				block.lend_text = query.GetFieldData(block.GetBlockName(), "lend_text", 0); // char 8

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (hname.Length > 20) return false; // char 20
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
			if (opentime.Length > 6) return false; // char 6
			if (high.ToString().Length > 8) return false; // long 8
			if (hightime.Length > 6) return false; // char 6
			if (low.ToString().Length > 8) return false; // long 8
			if (lowtime.Length > 6) return false; // char 6
			if (high52w.ToString().Length > 8) return false; // long 8
			if (high52wdate.Length > 8) return false; // char 8
			if (low52w.ToString().Length > 8) return false; // long 8
			if (low52wdate.Length > 8) return false; // char 8
			// exhratio float 6.2
			// per float 6.2
			// pbrx float 6.2
			if (listing.ToString().Length > 12) return false; // long 12
			if (jkrate.ToString().Length > 8) return false; // long 8
			if (memedan.Length > 5) return false; // char 5
			if (offernocd1.Length > 3) return false; // char 3
			if (bidnocd1.Length > 3) return false; // char 3
			if (offerno1.Length > 6) return false; // char 6
			if (bidno1.Length > 6) return false; // char 6
			if (dvol1.ToString().Length > 8) return false; // long 8
			if (svol1.ToString().Length > 8) return false; // long 8
			if (dcha1.ToString().Length > 8) return false; // long 8
			if (scha1.ToString().Length > 8) return false; // long 8
			// ddiff1 float 6.2
			// sdiff1 float 6.2
			if (offernocd2.Length > 3) return false; // char 3
			if (bidnocd2.Length > 3) return false; // char 3
			if (offerno2.Length > 6) return false; // char 6
			if (bidno2.Length > 6) return false; // char 6
			if (dvol2.ToString().Length > 8) return false; // long 8
			if (svol2.ToString().Length > 8) return false; // long 8
			if (dcha2.ToString().Length > 8) return false; // long 8
			if (scha2.ToString().Length > 8) return false; // long 8
			// ddiff2 float 6.2
			// sdiff2 float 6.2
			if (offernocd3.Length > 3) return false; // char 3
			if (bidnocd3.Length > 3) return false; // char 3
			if (offerno3.Length > 6) return false; // char 6
			if (bidno3.Length > 6) return false; // char 6
			if (dvol3.ToString().Length > 8) return false; // long 8
			if (svol3.ToString().Length > 8) return false; // long 8
			if (dcha3.ToString().Length > 8) return false; // long 8
			if (scha3.ToString().Length > 8) return false; // long 8
			// ddiff3 float 6.2
			// sdiff3 float 6.2
			if (offernocd4.Length > 3) return false; // char 3
			if (bidnocd4.Length > 3) return false; // char 3
			if (offerno4.Length > 6) return false; // char 6
			if (bidno4.Length > 6) return false; // char 6
			if (dvol4.ToString().Length > 8) return false; // long 8
			if (svol4.ToString().Length > 8) return false; // long 8
			if (dcha4.ToString().Length > 8) return false; // long 8
			if (scha4.ToString().Length > 8) return false; // long 8
			// ddiff4 float 6.2
			// sdiff4 float 6.2
			if (offernocd5.Length > 3) return false; // char 3
			if (bidnocd5.Length > 3) return false; // char 3
			if (offerno5.Length > 6) return false; // char 6
			if (bidno5.Length > 6) return false; // char 6
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
			if (shcode.Length > 6) return false; // char 6
			if (value.ToString().Length > 12) return false; // long 12
			if (jvolume.ToString().Length > 12) return false; // long 12
			if (highyear.ToString().Length > 8) return false; // long 8
			if (highyeardate.Length > 8) return false; // char 8
			if (lowyear.ToString().Length > 8) return false; // long 8
			if (lowyeardate.Length > 8) return false; // char 8
			if (target.ToString().Length > 8) return false; // long 8
			if (capital.ToString().Length > 12) return false; // long 12
			if (abscnt.ToString().Length > 12) return false; // long 12
			if (parprice.ToString().Length > 8) return false; // long 8
			if (gsmm.Length > 2) return false; // char 2
			if (subprice.ToString().Length > 8) return false; // long 8
			if (total.ToString().Length > 12) return false; // long 12
			if (listdate.Length > 8) return false; // char 8
			if (name.Length > 10) return false; // char 10
			if (bfsales.ToString().Length > 12) return false; // long 12
			if (bfoperatingincome.ToString().Length > 12) return false; // long 12
			if (bfordinaryincome.ToString().Length > 12) return false; // long 12
			if (bfnetincome.ToString().Length > 12) return false; // long 12
			// bfeps float 13.2
			if (name2.Length > 10) return false; // char 10
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
			if (info1.Length > 10) return false; // char 10
			if (info2.Length > 10) return false; // char 10
			if (info3.Length > 10) return false; // char 10
			if (info4.Length > 12) return false; // char 12
			if (janginfo.Length > 10) return false; // char 10
			// t_per float 6.2
			if (tonghwa.Length > 3) return false; // char 3
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
			if (info5.Length > 8) return false; // char 8
			// spac_gubun char 1
			if (issueprice.ToString().Length > 8) return false; // long 8
			// alloc_gubun char 1
			if (alloc_text.Length > 8) return false; // char 8
			if (shterm_text.Length > 10) return false; // char 10
			if (svi_uplmtprice.ToString().Length > 8) return false; // long 8
			if (svi_dnlmtprice.ToString().Length > 8) return false; // long 8
			// low_lqdt_gu char 1
			// abnormal_rise_gu char 1
			if (lend_text.Length > 8) return false; // char 8

			return true;
		}
	}

	public partial class XQt1102 : XingQuery
	{
		/// <summary>
		/// t1102
		/// </summary>
		static readonly string _typeName = "t1102";
		/// <summary>
		/// 주식현재가(시세)조회(t1102)
		/// </summary>
		static readonly string _typeDesc = "주식현재가(시세)조회(t1102)";
		/// <summary>
		/// 
		/// </summary>
		static readonly string _service = "";
		/// <summary>
		/// A
		/// </summary>
		static readonly string _headType = "A";
		/// <summary>
		/// 
		/// </summary>
		static readonly string _creator = "";
		/// <summary>
		/// 
		/// </summary>
		static readonly string _createdDate = "";
		/// <summary>
		/// true
		/// </summary>
		static readonly bool _attr = true;
		/// <summary>
		/// true
		/// </summary>
		static readonly bool _block = true;
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _encrypt = false;
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _signature = false;

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


		public bool SetFields(XQt1102InBlock block)
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

	public static class ResourceCodes
	{
		public const string CDPCQ04700 = "CDPCQ04700";
		public const string CHARTEXCEL = "CHARTEXCEL";
		public const string CSPAT00600 = "CSPAT00600";
		public const string CSPAT00700 = "CSPAT00700";
		public const string t1101 = "t1101";
		public const string t1102 = "t1102";
	}

}
