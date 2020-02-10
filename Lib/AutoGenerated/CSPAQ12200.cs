using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQCSPAQ12200InBlock1 : XingBlock
	{
		/// <summary>
		/// CSPAQ12200InBlock1
		/// </summary>
		public const string _blockName = "CSPAQ12200InBlock1";
		/// <summary>
		/// In(*EMPTY*)
		/// </summary>
		public const string _blockDesc = "In(*EMPTY*)";
		/// <summary>
		/// input
		/// </summary>
		public const string _blockType = "input";
		/// <summary>
		/// false
		/// </summary>
		public const bool _hasOccurs = false;
		/// <summary>
		/// CSPAQ12200InBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CSPAQ12200InBlock1
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
		/// false
		/// </summary>
		public bool HasOccurs => _hasOccurs;

		/// <summary>
		/// 레코드갯수
		/// </summary>
		[XAQueryFieldAttribute("레코드갯수", "5")]
		public long RecCnt;
		/// <summary>
		/// 관리지점번호
		/// </summary>
		[XAQueryFieldAttribute("관리지점번호", "3")]
		public string MgmtBrnNo;
		/// <summary>
		/// 계좌번호
		/// </summary>
		[XAQueryFieldAttribute("계좌번호", "20")]
		public string AcntNo;
		/// <summary>
		/// 비밀번호
		/// </summary>
		[XAQueryFieldAttribute("비밀번호", "8")]
		public string Pwd;
		/// <summary>
		/// 잔고생성구분
		/// </summary>
		[XAQueryFieldAttribute("잔고생성구분", "1")]
		public char BalCreTp;

		public static class F
		{
			/// <summary>
			/// 레코드갯수
			/// </summary>
			public const string RecCnt = "RecCnt";
			/// <summary>
			/// 관리지점번호
			/// </summary>
			public const string MgmtBrnNo = "MgmtBrnNo";
			/// <summary>
			/// 계좌번호
			/// </summary>
			public const string AcntNo = "AcntNo";
			/// <summary>
			/// 비밀번호
			/// </summary>
			public const string Pwd = "Pwd";
			/// <summary>
			/// 잔고생성구분
			/// </summary>
			public const string BalCreTp = "BalCreTp";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.MgmtBrnNo,
			F.AcntNo,
			F.Pwd,
			F.BalCreTp,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["MgmtBrnNo"] = new XAQueryFieldInfo("char", MgmtBrnNo, MgmtBrnNo, "관리지점번호", (decimal)3);
			dict["AcntNo"] = new XAQueryFieldInfo("char", AcntNo, AcntNo, "계좌번호", (decimal)20);
			dict["Pwd"] = new XAQueryFieldInfo("char", Pwd, Pwd, "비밀번호", (decimal)8);
			dict["BalCreTp"] = new XAQueryFieldInfo("char", BalCreTp, BalCreTp.ToString(), "잔고생성구분", (decimal)1);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "RecCnt":
					this.RecCnt = fieldInfo.FieldValue.ParseLong("RecCnt");
				break;

				case "MgmtBrnNo":
					this.MgmtBrnNo = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "AcntNo":
					this.AcntNo = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "Pwd":
					this.Pwd = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "BalCreTp":
					this.BalCreTp = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public bool VerifyData()
		{
			if (RecCnt.ToString().Length > 5) return false; // long 5
			if (MgmtBrnNo?.Length > 3) return false; // char 3
			if (AcntNo?.Length > 20) return false; // char 20
			if (Pwd?.Length > 8) return false; // char 8
			// BalCreTp char 1

			return true;
		}
	}

	public partial class XQCSPAQ12200OutBlock1 : XingBlock
	{
		/// <summary>
		/// CSPAQ12200OutBlock1
		/// </summary>
		public const string _blockName = "CSPAQ12200OutBlock1";
		/// <summary>
		/// In(*EMPTY*)
		/// </summary>
		public const string _blockDesc = "In(*EMPTY*)";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// false
		/// </summary>
		public const bool _hasOccurs = false;
		/// <summary>
		/// CSPAQ12200OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CSPAQ12200OutBlock1
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
		/// false
		/// </summary>
		public bool HasOccurs => _hasOccurs;

		/// <summary>
		/// 레코드갯수
		/// </summary>
		[XAQueryFieldAttribute("레코드갯수", "5")]
		public long RecCnt;
		/// <summary>
		/// 관리지점번호
		/// </summary>
		[XAQueryFieldAttribute("관리지점번호", "3")]
		public string MgmtBrnNo;
		/// <summary>
		/// 계좌번호
		/// </summary>
		[XAQueryFieldAttribute("계좌번호", "20")]
		public string AcntNo;
		/// <summary>
		/// 비밀번호
		/// </summary>
		[XAQueryFieldAttribute("비밀번호", "8")]
		public string Pwd;
		/// <summary>
		/// 잔고생성구분
		/// </summary>
		[XAQueryFieldAttribute("잔고생성구분", "1")]
		public char BalCreTp;

		public static class F
		{
			/// <summary>
			/// 레코드갯수
			/// </summary>
			public const string RecCnt = "RecCnt";
			/// <summary>
			/// 관리지점번호
			/// </summary>
			public const string MgmtBrnNo = "MgmtBrnNo";
			/// <summary>
			/// 계좌번호
			/// </summary>
			public const string AcntNo = "AcntNo";
			/// <summary>
			/// 비밀번호
			/// </summary>
			public const string Pwd = "Pwd";
			/// <summary>
			/// 잔고생성구분
			/// </summary>
			public const string BalCreTp = "BalCreTp";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.MgmtBrnNo,
			F.AcntNo,
			F.Pwd,
			F.BalCreTp,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["MgmtBrnNo"] = new XAQueryFieldInfo("char", MgmtBrnNo, MgmtBrnNo, "관리지점번호", (decimal)3);
			dict["AcntNo"] = new XAQueryFieldInfo("char", AcntNo, AcntNo, "계좌번호", (decimal)20);
			dict["Pwd"] = new XAQueryFieldInfo("char", Pwd, Pwd, "비밀번호", (decimal)8);
			dict["BalCreTp"] = new XAQueryFieldInfo("char", BalCreTp, BalCreTp.ToString(), "잔고생성구분", (decimal)1);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "RecCnt":
					this.RecCnt = fieldInfo.FieldValue.ParseLong("RecCnt");
				break;

				case "MgmtBrnNo":
					this.MgmtBrnNo = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "AcntNo":
					this.AcntNo = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "Pwd":
					this.Pwd = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "BalCreTp":
					this.BalCreTp = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public static XQCSPAQ12200OutBlock1 FromQuery(XQCSPAQ12200 query)
		{
			XQCSPAQ12200OutBlock1 block = new XQCSPAQ12200OutBlock1();
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
				block.MgmtBrnNo = query.GetFieldData(block.GetBlockName(), "MgmtBrnNo", 0).TrimEnd('?'); // char 3
				block.AcntNo = query.GetFieldData(block.GetBlockName(), "AcntNo", 0).TrimEnd('?'); // char 20
				block.Pwd = query.GetFieldData(block.GetBlockName(), "Pwd", 0).TrimEnd('?'); // char 8
				block.BalCreTp = query.GetFieldData(block.GetBlockName(), "BalCreTp", 0).FirstOrDefault(); // char 1

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (RecCnt.ToString().Length > 5) return false; // long 5
			if (MgmtBrnNo?.Length > 3) return false; // char 3
			if (AcntNo?.Length > 20) return false; // char 20
			if (Pwd?.Length > 8) return false; // char 8
			// BalCreTp char 1

			return true;
		}
	}

	public partial class XQCSPAQ12200OutBlock2 : XingBlock
	{
		/// <summary>
		/// CSPAQ12200OutBlock2
		/// </summary>
		public const string _blockName = "CSPAQ12200OutBlock2";
		/// <summary>
		/// Out(*EMPTY*)
		/// </summary>
		public const string _blockDesc = "Out(*EMPTY*)";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// false
		/// </summary>
		public const bool _hasOccurs = false;
		/// <summary>
		/// CSPAQ12200OutBlock2
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CSPAQ12200OutBlock2
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
		/// false
		/// </summary>
		public bool HasOccurs => _hasOccurs;

		/// <summary>
		/// 레코드갯수
		/// </summary>
		[XAQueryFieldAttribute("레코드갯수", "5")]
		public long RecCnt;
		/// <summary>
		/// 지점명
		/// </summary>
		[XAQueryFieldAttribute("지점명", "40")]
		public string BrnNm;
		/// <summary>
		/// 계좌명
		/// </summary>
		[XAQueryFieldAttribute("계좌명", "40")]
		public string AcntNm;
		/// <summary>
		/// 현금주문가능금액
		/// </summary>
		[XAQueryFieldAttribute("현금주문가능금액", "16")]
		public long MnyOrdAbleAmt;
		/// <summary>
		/// 출금가능금액
		/// </summary>
		[XAQueryFieldAttribute("출금가능금액", "16")]
		public long MnyoutAbleAmt;
		/// <summary>
		/// 거래소금액
		/// </summary>
		[XAQueryFieldAttribute("거래소금액", "16")]
		public long SeOrdAbleAmt;
		/// <summary>
		/// 코스닥금액
		/// </summary>
		[XAQueryFieldAttribute("코스닥금액", "16")]
		public long KdqOrdAbleAmt;
		/// <summary>
		/// 잔고평가금액
		/// </summary>
		[XAQueryFieldAttribute("잔고평가금액", "16")]
		public long BalEvalAmt;
		/// <summary>
		/// 미수금액
		/// </summary>
		[XAQueryFieldAttribute("미수금액", "16")]
		public long RcvblAmt;
		/// <summary>
		/// 예탁자산총액
		/// </summary>
		[XAQueryFieldAttribute("예탁자산총액", "16")]
		public long DpsastTotamt;
		/// <summary>
		/// 손익율
		/// </summary>
		[XAQueryFieldAttribute("손익율", "18.6")]
		public double PnlRat;
		/// <summary>
		/// 투자원금
		/// </summary>
		[XAQueryFieldAttribute("투자원금", "20")]
		public long InvstOrgAmt;
		/// <summary>
		/// 투자손익금액
		/// </summary>
		[XAQueryFieldAttribute("투자손익금액", "16")]
		public long InvstPlAmt;
		/// <summary>
		/// 신용담보주문금액
		/// </summary>
		[XAQueryFieldAttribute("신용담보주문금액", "16")]
		public long CrdtPldgOrdAmt;
		/// <summary>
		/// 예수금
		/// </summary>
		[XAQueryFieldAttribute("예수금", "16")]
		public long Dps;
		/// <summary>
		/// 대용금액
		/// </summary>
		[XAQueryFieldAttribute("대용금액", "16")]
		public long SubstAmt;
		/// <summary>
		/// D1예수금
		/// </summary>
		[XAQueryFieldAttribute("D1예수금", "16")]
		public long D1Dps;
		/// <summary>
		/// D2예수금
		/// </summary>
		[XAQueryFieldAttribute("D2예수금", "16")]
		public long D2Dps;
		/// <summary>
		/// 현금미수금액
		/// </summary>
		[XAQueryFieldAttribute("현금미수금액", "16")]
		public long MnyrclAmt;
		/// <summary>
		/// 증거금현금
		/// </summary>
		[XAQueryFieldAttribute("증거금현금", "16")]
		public long MgnMny;
		/// <summary>
		/// 증거금대용
		/// </summary>
		[XAQueryFieldAttribute("증거금대용", "16")]
		public long MgnSubst;
		/// <summary>
		/// 수표금액
		/// </summary>
		[XAQueryFieldAttribute("수표금액", "16")]
		public long ChckAmt;
		/// <summary>
		/// 대용주문가능금액
		/// </summary>
		[XAQueryFieldAttribute("대용주문가능금액", "16")]
		public long SubstOrdAbleAmt;
		/// <summary>
		/// 증거금률100퍼센트주문가능금액
		/// </summary>
		[XAQueryFieldAttribute("증거금률100퍼센트주문가능금액", "16")]
		public long MgnRat100pctOrdAbleAmt;
		/// <summary>
		/// 증거금률35%주문가능금액
		/// </summary>
		[XAQueryFieldAttribute("증거금률35%주문가능금액", "16")]
		public long MgnRat35ordAbleAmt;
		/// <summary>
		/// 증거금률50%주문가능금액
		/// </summary>
		[XAQueryFieldAttribute("증거금률50%주문가능금액", "16")]
		public long MgnRat50ordAbleAmt;
		/// <summary>
		/// 전일매도정산금액
		/// </summary>
		[XAQueryFieldAttribute("전일매도정산금액", "16")]
		public long PrdaySellAdjstAmt;
		/// <summary>
		/// 전일매수정산금액
		/// </summary>
		[XAQueryFieldAttribute("전일매수정산금액", "16")]
		public long PrdayBuyAdjstAmt;
		/// <summary>
		/// 금일매도정산금액
		/// </summary>
		[XAQueryFieldAttribute("금일매도정산금액", "16")]
		public long CrdaySellAdjstAmt;
		/// <summary>
		/// 금일매수정산금액
		/// </summary>
		[XAQueryFieldAttribute("금일매수정산금액", "16")]
		public long CrdayBuyAdjstAmt;
		/// <summary>
		/// D1연체변제소요금액
		/// </summary>
		[XAQueryFieldAttribute("D1연체변제소요금액", "16")]
		public long D1ovdRepayRqrdAmt;
		/// <summary>
		/// D2연체변제소요금액
		/// </summary>
		[XAQueryFieldAttribute("D2연체변제소요금액", "16")]
		public long D2ovdRepayRqrdAmt;
		/// <summary>
		/// D1추정인출가능금액
		/// </summary>
		[XAQueryFieldAttribute("D1추정인출가능금액", "16")]
		public long D1PrsmptWthdwAbleAmt;
		/// <summary>
		/// D2추정인출가능금액
		/// </summary>
		[XAQueryFieldAttribute("D2추정인출가능금액", "16")]
		public long D2PrsmptWthdwAbleAmt;
		/// <summary>
		/// 예탁담보대출금액
		/// </summary>
		[XAQueryFieldAttribute("예탁담보대출금액", "16")]
		public long DpspdgLoanAmt;
		/// <summary>
		/// 신용설정보증금
		/// </summary>
		[XAQueryFieldAttribute("신용설정보증금", "16")]
		public long Imreq;
		/// <summary>
		/// 융자금액
		/// </summary>
		[XAQueryFieldAttribute("융자금액", "16")]
		public long MloanAmt;
		/// <summary>
		/// 변경후담보비율
		/// </summary>
		[XAQueryFieldAttribute("변경후담보비율", "9.3")]
		public double ChgAfPldgRat;
		/// <summary>
		/// 원담보금액
		/// </summary>
		[XAQueryFieldAttribute("원담보금액", "16")]
		public long OrgPldgAmt;
		/// <summary>
		/// 부담보금액
		/// </summary>
		[XAQueryFieldAttribute("부담보금액", "16")]
		public long SubPldgAmt;
		/// <summary>
		/// 소요담보금액
		/// </summary>
		[XAQueryFieldAttribute("소요담보금액", "16")]
		public long RqrdPldgAmt;
		/// <summary>
		/// 원담보부족금액
		/// </summary>
		[XAQueryFieldAttribute("원담보부족금액", "16")]
		public long OrgPdlckAmt;
		/// <summary>
		/// 담보부족금액
		/// </summary>
		[XAQueryFieldAttribute("담보부족금액", "16")]
		public long PdlckAmt;
		/// <summary>
		/// 추가담보현금
		/// </summary>
		[XAQueryFieldAttribute("추가담보현금", "16")]
		public long AddPldgMny;
		/// <summary>
		/// D1주문가능금액
		/// </summary>
		[XAQueryFieldAttribute("D1주문가능금액", "16")]
		public long D1OrdAbleAmt;
		/// <summary>
		/// 신용이자미납금액
		/// </summary>
		[XAQueryFieldAttribute("신용이자미납금액", "16")]
		public long CrdtIntdltAmt;
		/// <summary>
		/// 기타대여금액
		/// </summary>
		[XAQueryFieldAttribute("기타대여금액", "16")]
		public long EtclndAmt;
		/// <summary>
		/// 익일추정반대매매금액
		/// </summary>
		[XAQueryFieldAttribute("익일추정반대매매금액", "16")]
		public long NtdayPrsmptCvrgAmt;
		/// <summary>
		/// 원담보합계금액
		/// </summary>
		[XAQueryFieldAttribute("원담보합계금액", "16")]
		public long OrgPldgSumAmt;
		/// <summary>
		/// 신용주문가능금액
		/// </summary>
		[XAQueryFieldAttribute("신용주문가능금액", "16")]
		public long CrdtOrdAbleAmt;
		/// <summary>
		/// 부담보합계금액
		/// </summary>
		[XAQueryFieldAttribute("부담보합계금액", "16")]
		public long SubPldgSumAmt;
		/// <summary>
		/// 신용담보금현금
		/// </summary>
		[XAQueryFieldAttribute("신용담보금현금", "16")]
		public long CrdtPldgAmtMny;
		/// <summary>
		/// 신용담보대용금액
		/// </summary>
		[XAQueryFieldAttribute("신용담보대용금액", "16")]
		public long CrdtPldgSubstAmt;
		/// <summary>
		/// 추가신용담보현금
		/// </summary>
		[XAQueryFieldAttribute("추가신용담보현금", "16")]
		public long AddCrdtPldgMny;
		/// <summary>
		/// 신용담보재사용금액
		/// </summary>
		[XAQueryFieldAttribute("신용담보재사용금액", "16")]
		public long CrdtPldgRuseAmt;
		/// <summary>
		/// 추가신용담보대용
		/// </summary>
		[XAQueryFieldAttribute("추가신용담보대용", "16")]
		public long AddCrdtPldgSubst;
		/// <summary>
		/// 매도대금담보대출금액
		/// </summary>
		[XAQueryFieldAttribute("매도대금담보대출금액", "16")]
		public long CslLoanAmtdt1;
		/// <summary>
		/// 처분제한금액
		/// </summary>
		[XAQueryFieldAttribute("처분제한금액", "16")]
		public long DpslRestrcAmt;

		public static class F
		{
			/// <summary>
			/// 레코드갯수
			/// </summary>
			public const string RecCnt = "RecCnt";
			/// <summary>
			/// 지점명
			/// </summary>
			public const string BrnNm = "BrnNm";
			/// <summary>
			/// 계좌명
			/// </summary>
			public const string AcntNm = "AcntNm";
			/// <summary>
			/// 현금주문가능금액
			/// </summary>
			public const string MnyOrdAbleAmt = "MnyOrdAbleAmt";
			/// <summary>
			/// 출금가능금액
			/// </summary>
			public const string MnyoutAbleAmt = "MnyoutAbleAmt";
			/// <summary>
			/// 거래소금액
			/// </summary>
			public const string SeOrdAbleAmt = "SeOrdAbleAmt";
			/// <summary>
			/// 코스닥금액
			/// </summary>
			public const string KdqOrdAbleAmt = "KdqOrdAbleAmt";
			/// <summary>
			/// 잔고평가금액
			/// </summary>
			public const string BalEvalAmt = "BalEvalAmt";
			/// <summary>
			/// 미수금액
			/// </summary>
			public const string RcvblAmt = "RcvblAmt";
			/// <summary>
			/// 예탁자산총액
			/// </summary>
			public const string DpsastTotamt = "DpsastTotamt";
			/// <summary>
			/// 손익율
			/// </summary>
			public const string PnlRat = "PnlRat";
			/// <summary>
			/// 투자원금
			/// </summary>
			public const string InvstOrgAmt = "InvstOrgAmt";
			/// <summary>
			/// 투자손익금액
			/// </summary>
			public const string InvstPlAmt = "InvstPlAmt";
			/// <summary>
			/// 신용담보주문금액
			/// </summary>
			public const string CrdtPldgOrdAmt = "CrdtPldgOrdAmt";
			/// <summary>
			/// 예수금
			/// </summary>
			public const string Dps = "Dps";
			/// <summary>
			/// 대용금액
			/// </summary>
			public const string SubstAmt = "SubstAmt";
			/// <summary>
			/// D1예수금
			/// </summary>
			public const string D1Dps = "D1Dps";
			/// <summary>
			/// D2예수금
			/// </summary>
			public const string D2Dps = "D2Dps";
			/// <summary>
			/// 현금미수금액
			/// </summary>
			public const string MnyrclAmt = "MnyrclAmt";
			/// <summary>
			/// 증거금현금
			/// </summary>
			public const string MgnMny = "MgnMny";
			/// <summary>
			/// 증거금대용
			/// </summary>
			public const string MgnSubst = "MgnSubst";
			/// <summary>
			/// 수표금액
			/// </summary>
			public const string ChckAmt = "ChckAmt";
			/// <summary>
			/// 대용주문가능금액
			/// </summary>
			public const string SubstOrdAbleAmt = "SubstOrdAbleAmt";
			/// <summary>
			/// 증거금률100퍼센트주문가능금액
			/// </summary>
			public const string MgnRat100pctOrdAbleAmt = "MgnRat100pctOrdAbleAmt";
			/// <summary>
			/// 증거금률35%주문가능금액
			/// </summary>
			public const string MgnRat35ordAbleAmt = "MgnRat35ordAbleAmt";
			/// <summary>
			/// 증거금률50%주문가능금액
			/// </summary>
			public const string MgnRat50ordAbleAmt = "MgnRat50ordAbleAmt";
			/// <summary>
			/// 전일매도정산금액
			/// </summary>
			public const string PrdaySellAdjstAmt = "PrdaySellAdjstAmt";
			/// <summary>
			/// 전일매수정산금액
			/// </summary>
			public const string PrdayBuyAdjstAmt = "PrdayBuyAdjstAmt";
			/// <summary>
			/// 금일매도정산금액
			/// </summary>
			public const string CrdaySellAdjstAmt = "CrdaySellAdjstAmt";
			/// <summary>
			/// 금일매수정산금액
			/// </summary>
			public const string CrdayBuyAdjstAmt = "CrdayBuyAdjstAmt";
			/// <summary>
			/// D1연체변제소요금액
			/// </summary>
			public const string D1ovdRepayRqrdAmt = "D1ovdRepayRqrdAmt";
			/// <summary>
			/// D2연체변제소요금액
			/// </summary>
			public const string D2ovdRepayRqrdAmt = "D2ovdRepayRqrdAmt";
			/// <summary>
			/// D1추정인출가능금액
			/// </summary>
			public const string D1PrsmptWthdwAbleAmt = "D1PrsmptWthdwAbleAmt";
			/// <summary>
			/// D2추정인출가능금액
			/// </summary>
			public const string D2PrsmptWthdwAbleAmt = "D2PrsmptWthdwAbleAmt";
			/// <summary>
			/// 예탁담보대출금액
			/// </summary>
			public const string DpspdgLoanAmt = "DpspdgLoanAmt";
			/// <summary>
			/// 신용설정보증금
			/// </summary>
			public const string Imreq = "Imreq";
			/// <summary>
			/// 융자금액
			/// </summary>
			public const string MloanAmt = "MloanAmt";
			/// <summary>
			/// 변경후담보비율
			/// </summary>
			public const string ChgAfPldgRat = "ChgAfPldgRat";
			/// <summary>
			/// 원담보금액
			/// </summary>
			public const string OrgPldgAmt = "OrgPldgAmt";
			/// <summary>
			/// 부담보금액
			/// </summary>
			public const string SubPldgAmt = "SubPldgAmt";
			/// <summary>
			/// 소요담보금액
			/// </summary>
			public const string RqrdPldgAmt = "RqrdPldgAmt";
			/// <summary>
			/// 원담보부족금액
			/// </summary>
			public const string OrgPdlckAmt = "OrgPdlckAmt";
			/// <summary>
			/// 담보부족금액
			/// </summary>
			public const string PdlckAmt = "PdlckAmt";
			/// <summary>
			/// 추가담보현금
			/// </summary>
			public const string AddPldgMny = "AddPldgMny";
			/// <summary>
			/// D1주문가능금액
			/// </summary>
			public const string D1OrdAbleAmt = "D1OrdAbleAmt";
			/// <summary>
			/// 신용이자미납금액
			/// </summary>
			public const string CrdtIntdltAmt = "CrdtIntdltAmt";
			/// <summary>
			/// 기타대여금액
			/// </summary>
			public const string EtclndAmt = "EtclndAmt";
			/// <summary>
			/// 익일추정반대매매금액
			/// </summary>
			public const string NtdayPrsmptCvrgAmt = "NtdayPrsmptCvrgAmt";
			/// <summary>
			/// 원담보합계금액
			/// </summary>
			public const string OrgPldgSumAmt = "OrgPldgSumAmt";
			/// <summary>
			/// 신용주문가능금액
			/// </summary>
			public const string CrdtOrdAbleAmt = "CrdtOrdAbleAmt";
			/// <summary>
			/// 부담보합계금액
			/// </summary>
			public const string SubPldgSumAmt = "SubPldgSumAmt";
			/// <summary>
			/// 신용담보금현금
			/// </summary>
			public const string CrdtPldgAmtMny = "CrdtPldgAmtMny";
			/// <summary>
			/// 신용담보대용금액
			/// </summary>
			public const string CrdtPldgSubstAmt = "CrdtPldgSubstAmt";
			/// <summary>
			/// 추가신용담보현금
			/// </summary>
			public const string AddCrdtPldgMny = "AddCrdtPldgMny";
			/// <summary>
			/// 신용담보재사용금액
			/// </summary>
			public const string CrdtPldgRuseAmt = "CrdtPldgRuseAmt";
			/// <summary>
			/// 추가신용담보대용
			/// </summary>
			public const string AddCrdtPldgSubst = "AddCrdtPldgSubst";
			/// <summary>
			/// 매도대금담보대출금액
			/// </summary>
			public const string CslLoanAmtdt1 = "CslLoanAmtdt1";
			/// <summary>
			/// 처분제한금액
			/// </summary>
			public const string DpslRestrcAmt = "DpslRestrcAmt";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.BrnNm,
			F.AcntNm,
			F.MnyOrdAbleAmt,
			F.MnyoutAbleAmt,
			F.SeOrdAbleAmt,
			F.KdqOrdAbleAmt,
			F.BalEvalAmt,
			F.RcvblAmt,
			F.DpsastTotamt,
			F.PnlRat,
			F.InvstOrgAmt,
			F.InvstPlAmt,
			F.CrdtPldgOrdAmt,
			F.Dps,
			F.SubstAmt,
			F.D1Dps,
			F.D2Dps,
			F.MnyrclAmt,
			F.MgnMny,
			F.MgnSubst,
			F.ChckAmt,
			F.SubstOrdAbleAmt,
			F.MgnRat100pctOrdAbleAmt,
			F.MgnRat35ordAbleAmt,
			F.MgnRat50ordAbleAmt,
			F.PrdaySellAdjstAmt,
			F.PrdayBuyAdjstAmt,
			F.CrdaySellAdjstAmt,
			F.CrdayBuyAdjstAmt,
			F.D1ovdRepayRqrdAmt,
			F.D2ovdRepayRqrdAmt,
			F.D1PrsmptWthdwAbleAmt,
			F.D2PrsmptWthdwAbleAmt,
			F.DpspdgLoanAmt,
			F.Imreq,
			F.MloanAmt,
			F.ChgAfPldgRat,
			F.OrgPldgAmt,
			F.SubPldgAmt,
			F.RqrdPldgAmt,
			F.OrgPdlckAmt,
			F.PdlckAmt,
			F.AddPldgMny,
			F.D1OrdAbleAmt,
			F.CrdtIntdltAmt,
			F.EtclndAmt,
			F.NtdayPrsmptCvrgAmt,
			F.OrgPldgSumAmt,
			F.CrdtOrdAbleAmt,
			F.SubPldgSumAmt,
			F.CrdtPldgAmtMny,
			F.CrdtPldgSubstAmt,
			F.AddCrdtPldgMny,
			F.CrdtPldgRuseAmt,
			F.AddCrdtPldgSubst,
			F.CslLoanAmtdt1,
			F.DpslRestrcAmt,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["BrnNm"] = new XAQueryFieldInfo("char", BrnNm, BrnNm, "지점명", (decimal)40);
			dict["AcntNm"] = new XAQueryFieldInfo("char", AcntNm, AcntNm, "계좌명", (decimal)40);
			dict["MnyOrdAbleAmt"] = new XAQueryFieldInfo("long", MnyOrdAbleAmt, MnyOrdAbleAmt.ToString("d16"), "현금주문가능금액", (decimal)16);
			dict["MnyoutAbleAmt"] = new XAQueryFieldInfo("long", MnyoutAbleAmt, MnyoutAbleAmt.ToString("d16"), "출금가능금액", (decimal)16);
			dict["SeOrdAbleAmt"] = new XAQueryFieldInfo("long", SeOrdAbleAmt, SeOrdAbleAmt.ToString("d16"), "거래소금액", (decimal)16);
			dict["KdqOrdAbleAmt"] = new XAQueryFieldInfo("long", KdqOrdAbleAmt, KdqOrdAbleAmt.ToString("d16"), "코스닥금액", (decimal)16);
			dict["BalEvalAmt"] = new XAQueryFieldInfo("long", BalEvalAmt, BalEvalAmt.ToString("d16"), "잔고평가금액", (decimal)16);
			dict["RcvblAmt"] = new XAQueryFieldInfo("long", RcvblAmt, RcvblAmt.ToString("d16"), "미수금액", (decimal)16);
			dict["DpsastTotamt"] = new XAQueryFieldInfo("long", DpsastTotamt, DpsastTotamt.ToString("d16"), "예탁자산총액", (decimal)16);
			dict["PnlRat"] = new XAQueryFieldInfo("double", PnlRat, PnlRat.ToString("000000000000000000.000000"), "손익율", (decimal)18.6);
			dict["InvstOrgAmt"] = new XAQueryFieldInfo("long", InvstOrgAmt, InvstOrgAmt.ToString("d20"), "투자원금", (decimal)20);
			dict["InvstPlAmt"] = new XAQueryFieldInfo("long", InvstPlAmt, InvstPlAmt.ToString("d16"), "투자손익금액", (decimal)16);
			dict["CrdtPldgOrdAmt"] = new XAQueryFieldInfo("long", CrdtPldgOrdAmt, CrdtPldgOrdAmt.ToString("d16"), "신용담보주문금액", (decimal)16);
			dict["Dps"] = new XAQueryFieldInfo("long", Dps, Dps.ToString("d16"), "예수금", (decimal)16);
			dict["SubstAmt"] = new XAQueryFieldInfo("long", SubstAmt, SubstAmt.ToString("d16"), "대용금액", (decimal)16);
			dict["D1Dps"] = new XAQueryFieldInfo("long", D1Dps, D1Dps.ToString("d16"), "D1예수금", (decimal)16);
			dict["D2Dps"] = new XAQueryFieldInfo("long", D2Dps, D2Dps.ToString("d16"), "D2예수금", (decimal)16);
			dict["MnyrclAmt"] = new XAQueryFieldInfo("long", MnyrclAmt, MnyrclAmt.ToString("d16"), "현금미수금액", (decimal)16);
			dict["MgnMny"] = new XAQueryFieldInfo("long", MgnMny, MgnMny.ToString("d16"), "증거금현금", (decimal)16);
			dict["MgnSubst"] = new XAQueryFieldInfo("long", MgnSubst, MgnSubst.ToString("d16"), "증거금대용", (decimal)16);
			dict["ChckAmt"] = new XAQueryFieldInfo("long", ChckAmt, ChckAmt.ToString("d16"), "수표금액", (decimal)16);
			dict["SubstOrdAbleAmt"] = new XAQueryFieldInfo("long", SubstOrdAbleAmt, SubstOrdAbleAmt.ToString("d16"), "대용주문가능금액", (decimal)16);
			dict["MgnRat100pctOrdAbleAmt"] = new XAQueryFieldInfo("long", MgnRat100pctOrdAbleAmt, MgnRat100pctOrdAbleAmt.ToString("d16"), "증거금률100퍼센트주문가능금액", (decimal)16);
			dict["MgnRat35ordAbleAmt"] = new XAQueryFieldInfo("long", MgnRat35ordAbleAmt, MgnRat35ordAbleAmt.ToString("d16"), "증거금률35%주문가능금액", (decimal)16);
			dict["MgnRat50ordAbleAmt"] = new XAQueryFieldInfo("long", MgnRat50ordAbleAmt, MgnRat50ordAbleAmt.ToString("d16"), "증거금률50%주문가능금액", (decimal)16);
			dict["PrdaySellAdjstAmt"] = new XAQueryFieldInfo("long", PrdaySellAdjstAmt, PrdaySellAdjstAmt.ToString("d16"), "전일매도정산금액", (decimal)16);
			dict["PrdayBuyAdjstAmt"] = new XAQueryFieldInfo("long", PrdayBuyAdjstAmt, PrdayBuyAdjstAmt.ToString("d16"), "전일매수정산금액", (decimal)16);
			dict["CrdaySellAdjstAmt"] = new XAQueryFieldInfo("long", CrdaySellAdjstAmt, CrdaySellAdjstAmt.ToString("d16"), "금일매도정산금액", (decimal)16);
			dict["CrdayBuyAdjstAmt"] = new XAQueryFieldInfo("long", CrdayBuyAdjstAmt, CrdayBuyAdjstAmt.ToString("d16"), "금일매수정산금액", (decimal)16);
			dict["D1ovdRepayRqrdAmt"] = new XAQueryFieldInfo("long", D1ovdRepayRqrdAmt, D1ovdRepayRqrdAmt.ToString("d16"), "D1연체변제소요금액", (decimal)16);
			dict["D2ovdRepayRqrdAmt"] = new XAQueryFieldInfo("long", D2ovdRepayRqrdAmt, D2ovdRepayRqrdAmt.ToString("d16"), "D2연체변제소요금액", (decimal)16);
			dict["D1PrsmptWthdwAbleAmt"] = new XAQueryFieldInfo("long", D1PrsmptWthdwAbleAmt, D1PrsmptWthdwAbleAmt.ToString("d16"), "D1추정인출가능금액", (decimal)16);
			dict["D2PrsmptWthdwAbleAmt"] = new XAQueryFieldInfo("long", D2PrsmptWthdwAbleAmt, D2PrsmptWthdwAbleAmt.ToString("d16"), "D2추정인출가능금액", (decimal)16);
			dict["DpspdgLoanAmt"] = new XAQueryFieldInfo("long", DpspdgLoanAmt, DpspdgLoanAmt.ToString("d16"), "예탁담보대출금액", (decimal)16);
			dict["Imreq"] = new XAQueryFieldInfo("long", Imreq, Imreq.ToString("d16"), "신용설정보증금", (decimal)16);
			dict["MloanAmt"] = new XAQueryFieldInfo("long", MloanAmt, MloanAmt.ToString("d16"), "융자금액", (decimal)16);
			dict["ChgAfPldgRat"] = new XAQueryFieldInfo("double", ChgAfPldgRat, ChgAfPldgRat.ToString("000000000.000"), "변경후담보비율", (decimal)9.3);
			dict["OrgPldgAmt"] = new XAQueryFieldInfo("long", OrgPldgAmt, OrgPldgAmt.ToString("d16"), "원담보금액", (decimal)16);
			dict["SubPldgAmt"] = new XAQueryFieldInfo("long", SubPldgAmt, SubPldgAmt.ToString("d16"), "부담보금액", (decimal)16);
			dict["RqrdPldgAmt"] = new XAQueryFieldInfo("long", RqrdPldgAmt, RqrdPldgAmt.ToString("d16"), "소요담보금액", (decimal)16);
			dict["OrgPdlckAmt"] = new XAQueryFieldInfo("long", OrgPdlckAmt, OrgPdlckAmt.ToString("d16"), "원담보부족금액", (decimal)16);
			dict["PdlckAmt"] = new XAQueryFieldInfo("long", PdlckAmt, PdlckAmt.ToString("d16"), "담보부족금액", (decimal)16);
			dict["AddPldgMny"] = new XAQueryFieldInfo("long", AddPldgMny, AddPldgMny.ToString("d16"), "추가담보현금", (decimal)16);
			dict["D1OrdAbleAmt"] = new XAQueryFieldInfo("long", D1OrdAbleAmt, D1OrdAbleAmt.ToString("d16"), "D1주문가능금액", (decimal)16);
			dict["CrdtIntdltAmt"] = new XAQueryFieldInfo("long", CrdtIntdltAmt, CrdtIntdltAmt.ToString("d16"), "신용이자미납금액", (decimal)16);
			dict["EtclndAmt"] = new XAQueryFieldInfo("long", EtclndAmt, EtclndAmt.ToString("d16"), "기타대여금액", (decimal)16);
			dict["NtdayPrsmptCvrgAmt"] = new XAQueryFieldInfo("long", NtdayPrsmptCvrgAmt, NtdayPrsmptCvrgAmt.ToString("d16"), "익일추정반대매매금액", (decimal)16);
			dict["OrgPldgSumAmt"] = new XAQueryFieldInfo("long", OrgPldgSumAmt, OrgPldgSumAmt.ToString("d16"), "원담보합계금액", (decimal)16);
			dict["CrdtOrdAbleAmt"] = new XAQueryFieldInfo("long", CrdtOrdAbleAmt, CrdtOrdAbleAmt.ToString("d16"), "신용주문가능금액", (decimal)16);
			dict["SubPldgSumAmt"] = new XAQueryFieldInfo("long", SubPldgSumAmt, SubPldgSumAmt.ToString("d16"), "부담보합계금액", (decimal)16);
			dict["CrdtPldgAmtMny"] = new XAQueryFieldInfo("long", CrdtPldgAmtMny, CrdtPldgAmtMny.ToString("d16"), "신용담보금현금", (decimal)16);
			dict["CrdtPldgSubstAmt"] = new XAQueryFieldInfo("long", CrdtPldgSubstAmt, CrdtPldgSubstAmt.ToString("d16"), "신용담보대용금액", (decimal)16);
			dict["AddCrdtPldgMny"] = new XAQueryFieldInfo("long", AddCrdtPldgMny, AddCrdtPldgMny.ToString("d16"), "추가신용담보현금", (decimal)16);
			dict["CrdtPldgRuseAmt"] = new XAQueryFieldInfo("long", CrdtPldgRuseAmt, CrdtPldgRuseAmt.ToString("d16"), "신용담보재사용금액", (decimal)16);
			dict["AddCrdtPldgSubst"] = new XAQueryFieldInfo("long", AddCrdtPldgSubst, AddCrdtPldgSubst.ToString("d16"), "추가신용담보대용", (decimal)16);
			dict["CslLoanAmtdt1"] = new XAQueryFieldInfo("long", CslLoanAmtdt1, CslLoanAmtdt1.ToString("d16"), "매도대금담보대출금액", (decimal)16);
			dict["DpslRestrcAmt"] = new XAQueryFieldInfo("long", DpslRestrcAmt, DpslRestrcAmt.ToString("d16"), "처분제한금액", (decimal)16);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "RecCnt":
					this.RecCnt = fieldInfo.FieldValue.ParseLong("RecCnt");
				break;

				case "BrnNm":
					this.BrnNm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "AcntNm":
					this.AcntNm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "MnyOrdAbleAmt":
					this.MnyOrdAbleAmt = fieldInfo.FieldValue.ParseLong("MnyOrdAbleAmt");
				break;

				case "MnyoutAbleAmt":
					this.MnyoutAbleAmt = fieldInfo.FieldValue.ParseLong("MnyoutAbleAmt");
				break;

				case "SeOrdAbleAmt":
					this.SeOrdAbleAmt = fieldInfo.FieldValue.ParseLong("SeOrdAbleAmt");
				break;

				case "KdqOrdAbleAmt":
					this.KdqOrdAbleAmt = fieldInfo.FieldValue.ParseLong("KdqOrdAbleAmt");
				break;

				case "BalEvalAmt":
					this.BalEvalAmt = fieldInfo.FieldValue.ParseLong("BalEvalAmt");
				break;

				case "RcvblAmt":
					this.RcvblAmt = fieldInfo.FieldValue.ParseLong("RcvblAmt");
				break;

				case "DpsastTotamt":
					this.DpsastTotamt = fieldInfo.FieldValue.ParseLong("DpsastTotamt");
				break;

				case "PnlRat":
					this.PnlRat = fieldInfo.FieldValue.ParseDouble("PnlRat");
				break;

				case "InvstOrgAmt":
					this.InvstOrgAmt = fieldInfo.FieldValue.ParseLong("InvstOrgAmt");
				break;

				case "InvstPlAmt":
					this.InvstPlAmt = fieldInfo.FieldValue.ParseLong("InvstPlAmt");
				break;

				case "CrdtPldgOrdAmt":
					this.CrdtPldgOrdAmt = fieldInfo.FieldValue.ParseLong("CrdtPldgOrdAmt");
				break;

				case "Dps":
					this.Dps = fieldInfo.FieldValue.ParseLong("Dps");
				break;

				case "SubstAmt":
					this.SubstAmt = fieldInfo.FieldValue.ParseLong("SubstAmt");
				break;

				case "D1Dps":
					this.D1Dps = fieldInfo.FieldValue.ParseLong("D1Dps");
				break;

				case "D2Dps":
					this.D2Dps = fieldInfo.FieldValue.ParseLong("D2Dps");
				break;

				case "MnyrclAmt":
					this.MnyrclAmt = fieldInfo.FieldValue.ParseLong("MnyrclAmt");
				break;

				case "MgnMny":
					this.MgnMny = fieldInfo.FieldValue.ParseLong("MgnMny");
				break;

				case "MgnSubst":
					this.MgnSubst = fieldInfo.FieldValue.ParseLong("MgnSubst");
				break;

				case "ChckAmt":
					this.ChckAmt = fieldInfo.FieldValue.ParseLong("ChckAmt");
				break;

				case "SubstOrdAbleAmt":
					this.SubstOrdAbleAmt = fieldInfo.FieldValue.ParseLong("SubstOrdAbleAmt");
				break;

				case "MgnRat100pctOrdAbleAmt":
					this.MgnRat100pctOrdAbleAmt = fieldInfo.FieldValue.ParseLong("MgnRat100pctOrdAbleAmt");
				break;

				case "MgnRat35ordAbleAmt":
					this.MgnRat35ordAbleAmt = fieldInfo.FieldValue.ParseLong("MgnRat35ordAbleAmt");
				break;

				case "MgnRat50ordAbleAmt":
					this.MgnRat50ordAbleAmt = fieldInfo.FieldValue.ParseLong("MgnRat50ordAbleAmt");
				break;

				case "PrdaySellAdjstAmt":
					this.PrdaySellAdjstAmt = fieldInfo.FieldValue.ParseLong("PrdaySellAdjstAmt");
				break;

				case "PrdayBuyAdjstAmt":
					this.PrdayBuyAdjstAmt = fieldInfo.FieldValue.ParseLong("PrdayBuyAdjstAmt");
				break;

				case "CrdaySellAdjstAmt":
					this.CrdaySellAdjstAmt = fieldInfo.FieldValue.ParseLong("CrdaySellAdjstAmt");
				break;

				case "CrdayBuyAdjstAmt":
					this.CrdayBuyAdjstAmt = fieldInfo.FieldValue.ParseLong("CrdayBuyAdjstAmt");
				break;

				case "D1ovdRepayRqrdAmt":
					this.D1ovdRepayRqrdAmt = fieldInfo.FieldValue.ParseLong("D1ovdRepayRqrdAmt");
				break;

				case "D2ovdRepayRqrdAmt":
					this.D2ovdRepayRqrdAmt = fieldInfo.FieldValue.ParseLong("D2ovdRepayRqrdAmt");
				break;

				case "D1PrsmptWthdwAbleAmt":
					this.D1PrsmptWthdwAbleAmt = fieldInfo.FieldValue.ParseLong("D1PrsmptWthdwAbleAmt");
				break;

				case "D2PrsmptWthdwAbleAmt":
					this.D2PrsmptWthdwAbleAmt = fieldInfo.FieldValue.ParseLong("D2PrsmptWthdwAbleAmt");
				break;

				case "DpspdgLoanAmt":
					this.DpspdgLoanAmt = fieldInfo.FieldValue.ParseLong("DpspdgLoanAmt");
				break;

				case "Imreq":
					this.Imreq = fieldInfo.FieldValue.ParseLong("Imreq");
				break;

				case "MloanAmt":
					this.MloanAmt = fieldInfo.FieldValue.ParseLong("MloanAmt");
				break;

				case "ChgAfPldgRat":
					this.ChgAfPldgRat = fieldInfo.FieldValue.ParseDouble("ChgAfPldgRat");
				break;

				case "OrgPldgAmt":
					this.OrgPldgAmt = fieldInfo.FieldValue.ParseLong("OrgPldgAmt");
				break;

				case "SubPldgAmt":
					this.SubPldgAmt = fieldInfo.FieldValue.ParseLong("SubPldgAmt");
				break;

				case "RqrdPldgAmt":
					this.RqrdPldgAmt = fieldInfo.FieldValue.ParseLong("RqrdPldgAmt");
				break;

				case "OrgPdlckAmt":
					this.OrgPdlckAmt = fieldInfo.FieldValue.ParseLong("OrgPdlckAmt");
				break;

				case "PdlckAmt":
					this.PdlckAmt = fieldInfo.FieldValue.ParseLong("PdlckAmt");
				break;

				case "AddPldgMny":
					this.AddPldgMny = fieldInfo.FieldValue.ParseLong("AddPldgMny");
				break;

				case "D1OrdAbleAmt":
					this.D1OrdAbleAmt = fieldInfo.FieldValue.ParseLong("D1OrdAbleAmt");
				break;

				case "CrdtIntdltAmt":
					this.CrdtIntdltAmt = fieldInfo.FieldValue.ParseLong("CrdtIntdltAmt");
				break;

				case "EtclndAmt":
					this.EtclndAmt = fieldInfo.FieldValue.ParseLong("EtclndAmt");
				break;

				case "NtdayPrsmptCvrgAmt":
					this.NtdayPrsmptCvrgAmt = fieldInfo.FieldValue.ParseLong("NtdayPrsmptCvrgAmt");
				break;

				case "OrgPldgSumAmt":
					this.OrgPldgSumAmt = fieldInfo.FieldValue.ParseLong("OrgPldgSumAmt");
				break;

				case "CrdtOrdAbleAmt":
					this.CrdtOrdAbleAmt = fieldInfo.FieldValue.ParseLong("CrdtOrdAbleAmt");
				break;

				case "SubPldgSumAmt":
					this.SubPldgSumAmt = fieldInfo.FieldValue.ParseLong("SubPldgSumAmt");
				break;

				case "CrdtPldgAmtMny":
					this.CrdtPldgAmtMny = fieldInfo.FieldValue.ParseLong("CrdtPldgAmtMny");
				break;

				case "CrdtPldgSubstAmt":
					this.CrdtPldgSubstAmt = fieldInfo.FieldValue.ParseLong("CrdtPldgSubstAmt");
				break;

				case "AddCrdtPldgMny":
					this.AddCrdtPldgMny = fieldInfo.FieldValue.ParseLong("AddCrdtPldgMny");
				break;

				case "CrdtPldgRuseAmt":
					this.CrdtPldgRuseAmt = fieldInfo.FieldValue.ParseLong("CrdtPldgRuseAmt");
				break;

				case "AddCrdtPldgSubst":
					this.AddCrdtPldgSubst = fieldInfo.FieldValue.ParseLong("AddCrdtPldgSubst");
				break;

				case "CslLoanAmtdt1":
					this.CslLoanAmtdt1 = fieldInfo.FieldValue.ParseLong("CslLoanAmtdt1");
				break;

				case "DpslRestrcAmt":
					this.DpslRestrcAmt = fieldInfo.FieldValue.ParseLong("DpslRestrcAmt");
				break;


			}
		}

		public static XQCSPAQ12200OutBlock2 FromQuery(XQCSPAQ12200 query)
		{
			XQCSPAQ12200OutBlock2 block = new XQCSPAQ12200OutBlock2();
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
				block.BrnNm = query.GetFieldData(block.GetBlockName(), "BrnNm", 0).TrimEnd('?'); // char 40
				block.AcntNm = query.GetFieldData(block.GetBlockName(), "AcntNm", 0).TrimEnd('?'); // char 40
				block.MnyOrdAbleAmt = query.GetFieldData(block.GetBlockName(), "MnyOrdAbleAmt", 0).ParseLong("MnyOrdAbleAmt"); // long 16
				block.MnyoutAbleAmt = query.GetFieldData(block.GetBlockName(), "MnyoutAbleAmt", 0).ParseLong("MnyoutAbleAmt"); // long 16
				block.SeOrdAbleAmt = query.GetFieldData(block.GetBlockName(), "SeOrdAbleAmt", 0).ParseLong("SeOrdAbleAmt"); // long 16
				block.KdqOrdAbleAmt = query.GetFieldData(block.GetBlockName(), "KdqOrdAbleAmt", 0).ParseLong("KdqOrdAbleAmt"); // long 16
				block.BalEvalAmt = query.GetFieldData(block.GetBlockName(), "BalEvalAmt", 0).ParseLong("BalEvalAmt"); // long 16
				block.RcvblAmt = query.GetFieldData(block.GetBlockName(), "RcvblAmt", 0).ParseLong("RcvblAmt"); // long 16
				block.DpsastTotamt = query.GetFieldData(block.GetBlockName(), "DpsastTotamt", 0).ParseLong("DpsastTotamt"); // long 16
				block.PnlRat = query.GetFieldData(block.GetBlockName(), "PnlRat", 0).ParseDouble("PnlRat"); // double 18.6
				block.InvstOrgAmt = query.GetFieldData(block.GetBlockName(), "InvstOrgAmt", 0).ParseLong("InvstOrgAmt"); // long 20
				block.InvstPlAmt = query.GetFieldData(block.GetBlockName(), "InvstPlAmt", 0).ParseLong("InvstPlAmt"); // long 16
				block.CrdtPldgOrdAmt = query.GetFieldData(block.GetBlockName(), "CrdtPldgOrdAmt", 0).ParseLong("CrdtPldgOrdAmt"); // long 16
				block.Dps = query.GetFieldData(block.GetBlockName(), "Dps", 0).ParseLong("Dps"); // long 16
				block.SubstAmt = query.GetFieldData(block.GetBlockName(), "SubstAmt", 0).ParseLong("SubstAmt"); // long 16
				block.D1Dps = query.GetFieldData(block.GetBlockName(), "D1Dps", 0).ParseLong("D1Dps"); // long 16
				block.D2Dps = query.GetFieldData(block.GetBlockName(), "D2Dps", 0).ParseLong("D2Dps"); // long 16
				block.MnyrclAmt = query.GetFieldData(block.GetBlockName(), "MnyrclAmt", 0).ParseLong("MnyrclAmt"); // long 16
				block.MgnMny = query.GetFieldData(block.GetBlockName(), "MgnMny", 0).ParseLong("MgnMny"); // long 16
				block.MgnSubst = query.GetFieldData(block.GetBlockName(), "MgnSubst", 0).ParseLong("MgnSubst"); // long 16
				block.ChckAmt = query.GetFieldData(block.GetBlockName(), "ChckAmt", 0).ParseLong("ChckAmt"); // long 16
				block.SubstOrdAbleAmt = query.GetFieldData(block.GetBlockName(), "SubstOrdAbleAmt", 0).ParseLong("SubstOrdAbleAmt"); // long 16
				block.MgnRat100pctOrdAbleAmt = query.GetFieldData(block.GetBlockName(), "MgnRat100pctOrdAbleAmt", 0).ParseLong("MgnRat100pctOrdAbleAmt"); // long 16
				block.MgnRat35ordAbleAmt = query.GetFieldData(block.GetBlockName(), "MgnRat35ordAbleAmt", 0).ParseLong("MgnRat35ordAbleAmt"); // long 16
				block.MgnRat50ordAbleAmt = query.GetFieldData(block.GetBlockName(), "MgnRat50ordAbleAmt", 0).ParseLong("MgnRat50ordAbleAmt"); // long 16
				block.PrdaySellAdjstAmt = query.GetFieldData(block.GetBlockName(), "PrdaySellAdjstAmt", 0).ParseLong("PrdaySellAdjstAmt"); // long 16
				block.PrdayBuyAdjstAmt = query.GetFieldData(block.GetBlockName(), "PrdayBuyAdjstAmt", 0).ParseLong("PrdayBuyAdjstAmt"); // long 16
				block.CrdaySellAdjstAmt = query.GetFieldData(block.GetBlockName(), "CrdaySellAdjstAmt", 0).ParseLong("CrdaySellAdjstAmt"); // long 16
				block.CrdayBuyAdjstAmt = query.GetFieldData(block.GetBlockName(), "CrdayBuyAdjstAmt", 0).ParseLong("CrdayBuyAdjstAmt"); // long 16
				block.D1ovdRepayRqrdAmt = query.GetFieldData(block.GetBlockName(), "D1ovdRepayRqrdAmt", 0).ParseLong("D1ovdRepayRqrdAmt"); // long 16
				block.D2ovdRepayRqrdAmt = query.GetFieldData(block.GetBlockName(), "D2ovdRepayRqrdAmt", 0).ParseLong("D2ovdRepayRqrdAmt"); // long 16
				block.D1PrsmptWthdwAbleAmt = query.GetFieldData(block.GetBlockName(), "D1PrsmptWthdwAbleAmt", 0).ParseLong("D1PrsmptWthdwAbleAmt"); // long 16
				block.D2PrsmptWthdwAbleAmt = query.GetFieldData(block.GetBlockName(), "D2PrsmptWthdwAbleAmt", 0).ParseLong("D2PrsmptWthdwAbleAmt"); // long 16
				block.DpspdgLoanAmt = query.GetFieldData(block.GetBlockName(), "DpspdgLoanAmt", 0).ParseLong("DpspdgLoanAmt"); // long 16
				block.Imreq = query.GetFieldData(block.GetBlockName(), "Imreq", 0).ParseLong("Imreq"); // long 16
				block.MloanAmt = query.GetFieldData(block.GetBlockName(), "MloanAmt", 0).ParseLong("MloanAmt"); // long 16
				block.ChgAfPldgRat = query.GetFieldData(block.GetBlockName(), "ChgAfPldgRat", 0).ParseDouble("ChgAfPldgRat"); // double 9.3
				block.OrgPldgAmt = query.GetFieldData(block.GetBlockName(), "OrgPldgAmt", 0).ParseLong("OrgPldgAmt"); // long 16
				block.SubPldgAmt = query.GetFieldData(block.GetBlockName(), "SubPldgAmt", 0).ParseLong("SubPldgAmt"); // long 16
				block.RqrdPldgAmt = query.GetFieldData(block.GetBlockName(), "RqrdPldgAmt", 0).ParseLong("RqrdPldgAmt"); // long 16
				block.OrgPdlckAmt = query.GetFieldData(block.GetBlockName(), "OrgPdlckAmt", 0).ParseLong("OrgPdlckAmt"); // long 16
				block.PdlckAmt = query.GetFieldData(block.GetBlockName(), "PdlckAmt", 0).ParseLong("PdlckAmt"); // long 16
				block.AddPldgMny = query.GetFieldData(block.GetBlockName(), "AddPldgMny", 0).ParseLong("AddPldgMny"); // long 16
				block.D1OrdAbleAmt = query.GetFieldData(block.GetBlockName(), "D1OrdAbleAmt", 0).ParseLong("D1OrdAbleAmt"); // long 16
				block.CrdtIntdltAmt = query.GetFieldData(block.GetBlockName(), "CrdtIntdltAmt", 0).ParseLong("CrdtIntdltAmt"); // long 16
				block.EtclndAmt = query.GetFieldData(block.GetBlockName(), "EtclndAmt", 0).ParseLong("EtclndAmt"); // long 16
				block.NtdayPrsmptCvrgAmt = query.GetFieldData(block.GetBlockName(), "NtdayPrsmptCvrgAmt", 0).ParseLong("NtdayPrsmptCvrgAmt"); // long 16
				block.OrgPldgSumAmt = query.GetFieldData(block.GetBlockName(), "OrgPldgSumAmt", 0).ParseLong("OrgPldgSumAmt"); // long 16
				block.CrdtOrdAbleAmt = query.GetFieldData(block.GetBlockName(), "CrdtOrdAbleAmt", 0).ParseLong("CrdtOrdAbleAmt"); // long 16
				block.SubPldgSumAmt = query.GetFieldData(block.GetBlockName(), "SubPldgSumAmt", 0).ParseLong("SubPldgSumAmt"); // long 16
				block.CrdtPldgAmtMny = query.GetFieldData(block.GetBlockName(), "CrdtPldgAmtMny", 0).ParseLong("CrdtPldgAmtMny"); // long 16
				block.CrdtPldgSubstAmt = query.GetFieldData(block.GetBlockName(), "CrdtPldgSubstAmt", 0).ParseLong("CrdtPldgSubstAmt"); // long 16
				block.AddCrdtPldgMny = query.GetFieldData(block.GetBlockName(), "AddCrdtPldgMny", 0).ParseLong("AddCrdtPldgMny"); // long 16
				block.CrdtPldgRuseAmt = query.GetFieldData(block.GetBlockName(), "CrdtPldgRuseAmt", 0).ParseLong("CrdtPldgRuseAmt"); // long 16
				block.AddCrdtPldgSubst = query.GetFieldData(block.GetBlockName(), "AddCrdtPldgSubst", 0).ParseLong("AddCrdtPldgSubst"); // long 16
				block.CslLoanAmtdt1 = query.GetFieldData(block.GetBlockName(), "CslLoanAmtdt1", 0).ParseLong("CslLoanAmtdt1"); // long 16
				block.DpslRestrcAmt = query.GetFieldData(block.GetBlockName(), "DpslRestrcAmt", 0).ParseLong("DpslRestrcAmt"); // long 16

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (RecCnt.ToString().Length > 5) return false; // long 5
			if (BrnNm?.Length > 40) return false; // char 40
			if (AcntNm?.Length > 40) return false; // char 40
			if (MnyOrdAbleAmt.ToString().Length > 16) return false; // long 16
			if (MnyoutAbleAmt.ToString().Length > 16) return false; // long 16
			if (SeOrdAbleAmt.ToString().Length > 16) return false; // long 16
			if (KdqOrdAbleAmt.ToString().Length > 16) return false; // long 16
			if (BalEvalAmt.ToString().Length > 16) return false; // long 16
			if (RcvblAmt.ToString().Length > 16) return false; // long 16
			if (DpsastTotamt.ToString().Length > 16) return false; // long 16
			// PnlRat double 18.6
			if (InvstOrgAmt.ToString().Length > 20) return false; // long 20
			if (InvstPlAmt.ToString().Length > 16) return false; // long 16
			if (CrdtPldgOrdAmt.ToString().Length > 16) return false; // long 16
			if (Dps.ToString().Length > 16) return false; // long 16
			if (SubstAmt.ToString().Length > 16) return false; // long 16
			if (D1Dps.ToString().Length > 16) return false; // long 16
			if (D2Dps.ToString().Length > 16) return false; // long 16
			if (MnyrclAmt.ToString().Length > 16) return false; // long 16
			if (MgnMny.ToString().Length > 16) return false; // long 16
			if (MgnSubst.ToString().Length > 16) return false; // long 16
			if (ChckAmt.ToString().Length > 16) return false; // long 16
			if (SubstOrdAbleAmt.ToString().Length > 16) return false; // long 16
			if (MgnRat100pctOrdAbleAmt.ToString().Length > 16) return false; // long 16
			if (MgnRat35ordAbleAmt.ToString().Length > 16) return false; // long 16
			if (MgnRat50ordAbleAmt.ToString().Length > 16) return false; // long 16
			if (PrdaySellAdjstAmt.ToString().Length > 16) return false; // long 16
			if (PrdayBuyAdjstAmt.ToString().Length > 16) return false; // long 16
			if (CrdaySellAdjstAmt.ToString().Length > 16) return false; // long 16
			if (CrdayBuyAdjstAmt.ToString().Length > 16) return false; // long 16
			if (D1ovdRepayRqrdAmt.ToString().Length > 16) return false; // long 16
			if (D2ovdRepayRqrdAmt.ToString().Length > 16) return false; // long 16
			if (D1PrsmptWthdwAbleAmt.ToString().Length > 16) return false; // long 16
			if (D2PrsmptWthdwAbleAmt.ToString().Length > 16) return false; // long 16
			if (DpspdgLoanAmt.ToString().Length > 16) return false; // long 16
			if (Imreq.ToString().Length > 16) return false; // long 16
			if (MloanAmt.ToString().Length > 16) return false; // long 16
			// ChgAfPldgRat double 9.3
			if (OrgPldgAmt.ToString().Length > 16) return false; // long 16
			if (SubPldgAmt.ToString().Length > 16) return false; // long 16
			if (RqrdPldgAmt.ToString().Length > 16) return false; // long 16
			if (OrgPdlckAmt.ToString().Length > 16) return false; // long 16
			if (PdlckAmt.ToString().Length > 16) return false; // long 16
			if (AddPldgMny.ToString().Length > 16) return false; // long 16
			if (D1OrdAbleAmt.ToString().Length > 16) return false; // long 16
			if (CrdtIntdltAmt.ToString().Length > 16) return false; // long 16
			if (EtclndAmt.ToString().Length > 16) return false; // long 16
			if (NtdayPrsmptCvrgAmt.ToString().Length > 16) return false; // long 16
			if (OrgPldgSumAmt.ToString().Length > 16) return false; // long 16
			if (CrdtOrdAbleAmt.ToString().Length > 16) return false; // long 16
			if (SubPldgSumAmt.ToString().Length > 16) return false; // long 16
			if (CrdtPldgAmtMny.ToString().Length > 16) return false; // long 16
			if (CrdtPldgSubstAmt.ToString().Length > 16) return false; // long 16
			if (AddCrdtPldgMny.ToString().Length > 16) return false; // long 16
			if (CrdtPldgRuseAmt.ToString().Length > 16) return false; // long 16
			if (AddCrdtPldgSubst.ToString().Length > 16) return false; // long 16
			if (CslLoanAmtdt1.ToString().Length > 16) return false; // long 16
			if (DpslRestrcAmt.ToString().Length > 16) return false; // long 16

			return true;
		}
	}

	/// <summary>
	/// 현물계좌예수금 주문가능금액 총평가 조회
	/// </summary>
	public partial class XQCSPAQ12200 : XingQuery
	{
		/// <summary>
		/// CSPAQ12200
		/// </summary>
		public const string _typeName = "CSPAQ12200";
		/// <summary>
		/// 현물계좌예수금 주문가능금액 총평가 조회
		/// </summary>
		public const string _typeDesc = "현물계좌예수금 주문가능금액 총평가 조회";
		/// <summary>
		/// CSPAQ12200
		/// </summary>
		public const string _service = "CSPAQ12200";
		/// <summary>
		/// B
		/// </summary>
		public const string _headType = "B";
		/// <summary>
		/// 이상은
		/// </summary>
		public const string _creator = "이상은";
		/// <summary>
		/// 2015/04/13 08:41:27
		/// </summary>
		public const string _createdDate = "2015/04/13 08:41:27";
		/// <summary>
		/// false
		/// </summary>
		public const bool _attr = false;
		/// <summary>
		/// false
		/// </summary>
		public const bool _block = false;
		/// <summary>
		/// false
		/// </summary>
		public const bool _encrypt = false;
		/// <summary>
		/// false
		/// </summary>
		public const bool _signature = false;

		/// <summary>
		/// CSPAQ12200
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 현물계좌예수금 주문가능금액 총평가 조회
		/// </summary>
		public string TypeDesc => _typeDesc;
		/// <summary>
		/// CSPAQ12200
		/// </summary>
		public string Service => _service;
		/// <summary>
		/// B
		/// </summary>
		public string HeadType => _headType;
		/// <summary>
		/// 이상은
		/// </summary>
		public string Creator => _creator;
		/// <summary>
		/// 2015/04/13 08:41:27
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

		/// <summary>
		/// 현물계좌예수금 주문가능금액 총평가 조회
		/// </summary>
		public XQCSPAQ12200() : base("CSPAQ12200") { }



		public bool SetBlock(XQCSPAQ12200InBlock1 block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "RecCnt", 0, block.RecCnt.ToString("d5")); // long 5
			_xaQuery.SetFieldData(block.GetBlockName(), "MgmtBrnNo", 0, block.MgmtBrnNo); // char 3
			_xaQuery.SetFieldData(block.GetBlockName(), "AcntNo", 0, block.AcntNo); // char 20
			_xaQuery.SetFieldData(block.GetBlockName(), "Pwd", 0, block.Pwd); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "BalCreTp", 0, block.BalCreTp.ToString()); // char 1

			return true;
		}

		public XQCSPAQ12200OutBlock1 GetBlock1()
		{
			XQCSPAQ12200OutBlock1 instance = XQCSPAQ12200OutBlock1.FromQuery(this);
			return instance;

		}

		public XQCSPAQ12200OutBlock2 GetBlock2()
		{
			XQCSPAQ12200OutBlock2 instance = XQCSPAQ12200OutBlock2.FromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQCSPAQ12200OutBlock1),
			typeof(XQCSPAQ12200OutBlock2),

		};

	}

}
