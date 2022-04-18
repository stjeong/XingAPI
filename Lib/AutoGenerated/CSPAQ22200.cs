using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQCSPAQ22200InBlock1 : XingBlock
	{
		/// <summary>
		/// CSPAQ22200InBlock1
		/// </summary>
		public const string _blockName = "CSPAQ22200InBlock1";
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
		/// CSPAQ22200InBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CSPAQ22200InBlock1
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
		[XAQueryFieldAttribute("RecCnt", "레코드갯수", "long", "5")]
		public long RecCnt;
		/// <summary>
		/// 관리지점번호
		/// </summary>
		[XAQueryFieldAttribute("MgmtBrnNo", "관리지점번호", "char", "3")]
		public string MgmtBrnNo;
		/// <summary>
		/// 계좌번호
		/// </summary>
		[XAQueryFieldAttribute("AcntNo", "계좌번호", "char", "20")]
		public string AcntNo;
		/// <summary>
		/// 비밀번호
		/// </summary>
		[XAQueryFieldAttribute("Pwd", "비밀번호", "char", "8")]
		public string Pwd;
		/// <summary>
		/// 잔고생성구분
		/// </summary>
		[XAQueryFieldAttribute("BalCreTp", "잔고생성구분", "char", "1")]
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

	public partial class XQCSPAQ22200OutBlock1 : XingBlock
	{
		/// <summary>
		/// CSPAQ22200OutBlock1
		/// </summary>
		public const string _blockName = "CSPAQ22200OutBlock1";
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
		/// CSPAQ22200OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CSPAQ22200OutBlock1
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
		[XAQueryFieldAttribute("RecCnt", "레코드갯수", "long", "5")]
		public long RecCnt;
		/// <summary>
		/// 관리지점번호
		/// </summary>
		[XAQueryFieldAttribute("MgmtBrnNo", "관리지점번호", "char", "3")]
		public string MgmtBrnNo;
		/// <summary>
		/// 계좌번호
		/// </summary>
		[XAQueryFieldAttribute("AcntNo", "계좌번호", "char", "20")]
		public string AcntNo;
		/// <summary>
		/// 비밀번호
		/// </summary>
		[XAQueryFieldAttribute("Pwd", "비밀번호", "char", "8")]
		public string Pwd;
		/// <summary>
		/// 잔고생성구분
		/// </summary>
		[XAQueryFieldAttribute("BalCreTp", "잔고생성구분", "char", "1")]
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

		public static XQCSPAQ22200OutBlock1 FromQuery(XQCSPAQ22200 query)
		{
			XQCSPAQ22200OutBlock1 block = new XQCSPAQ22200OutBlock1();
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

	public partial class XQCSPAQ22200OutBlock2 : XingBlock
	{
		/// <summary>
		/// CSPAQ22200OutBlock2
		/// </summary>
		public const string _blockName = "CSPAQ22200OutBlock2";
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
		/// CSPAQ22200OutBlock2
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CSPAQ22200OutBlock2
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
		[XAQueryFieldAttribute("RecCnt", "레코드갯수", "long", "5")]
		public long RecCnt;
		/// <summary>
		/// 지점명
		/// </summary>
		[XAQueryFieldAttribute("BrnNm", "지점명", "char", "40")]
		public string BrnNm;
		/// <summary>
		/// 계좌명
		/// </summary>
		[XAQueryFieldAttribute("AcntNm", "계좌명", "char", "40")]
		public string AcntNm;
		/// <summary>
		/// 현금주문가능금액
		/// </summary>
		[XAQueryFieldAttribute("MnyOrdAbleAmt", "현금주문가능금액", "long", "16")]
		public long MnyOrdAbleAmt;
		/// <summary>
		/// 대용주문가능금액
		/// </summary>
		[XAQueryFieldAttribute("SubstOrdAbleAmt", "대용주문가능금액", "long", "16")]
		public long SubstOrdAbleAmt;
		/// <summary>
		/// 거래소금액
		/// </summary>
		[XAQueryFieldAttribute("SeOrdAbleAmt", "거래소금액", "long", "16")]
		public long SeOrdAbleAmt;
		/// <summary>
		/// 코스닥금액
		/// </summary>
		[XAQueryFieldAttribute("KdqOrdAbleAmt", "코스닥금액", "long", "16")]
		public long KdqOrdAbleAmt;
		/// <summary>
		/// 신용담보주문금액
		/// </summary>
		[XAQueryFieldAttribute("CrdtPldgOrdAmt", "신용담보주문금액", "long", "16")]
		public long CrdtPldgOrdAmt;
		/// <summary>
		/// 증거금률100퍼센트주문가능금액
		/// </summary>
		[XAQueryFieldAttribute("MgnRat100pctOrdAbleAmt", "증거금률100퍼센트주문가능금액", "long", "16")]
		public long MgnRat100pctOrdAbleAmt;
		/// <summary>
		/// 증거금률35%주문가능금액
		/// </summary>
		[XAQueryFieldAttribute("MgnRat35ordAbleAmt", "증거금률35%주문가능금액", "long", "16")]
		public long MgnRat35ordAbleAmt;
		/// <summary>
		/// 증거금률50%주문가능금액
		/// </summary>
		[XAQueryFieldAttribute("MgnRat50ordAbleAmt", "증거금률50%주문가능금액", "long", "16")]
		public long MgnRat50ordAbleAmt;
		/// <summary>
		/// 신용주문가능금액
		/// </summary>
		[XAQueryFieldAttribute("CrdtOrdAbleAmt", "신용주문가능금액", "long", "16")]
		public long CrdtOrdAbleAmt;
		/// <summary>
		/// 예수금
		/// </summary>
		[XAQueryFieldAttribute("Dps", "예수금", "long", "16")]
		public long Dps;
		/// <summary>
		/// 대용금액
		/// </summary>
		[XAQueryFieldAttribute("SubstAmt", "대용금액", "long", "16")]
		public long SubstAmt;
		/// <summary>
		/// 증거금현금
		/// </summary>
		[XAQueryFieldAttribute("MgnMny", "증거금현금", "long", "16")]
		public long MgnMny;
		/// <summary>
		/// 증거금대용
		/// </summary>
		[XAQueryFieldAttribute("MgnSubst", "증거금대용", "long", "16")]
		public long MgnSubst;
		/// <summary>
		/// D1예수금
		/// </summary>
		[XAQueryFieldAttribute("D1Dps", "D1예수금", "long", "16")]
		public long D1Dps;
		/// <summary>
		/// D2예수금
		/// </summary>
		[XAQueryFieldAttribute("D2Dps", "D2예수금", "long", "16")]
		public long D2Dps;
		/// <summary>
		/// 미수금액
		/// </summary>
		[XAQueryFieldAttribute("RcvblAmt", "미수금액", "long", "16")]
		public long RcvblAmt;
		/// <summary>
		/// D1연체변제소요금액
		/// </summary>
		[XAQueryFieldAttribute("D1ovdRepayRqrdAmt", "D1연체변제소요금액", "long", "16")]
		public long D1ovdRepayRqrdAmt;
		/// <summary>
		/// D2연체변제소요금액
		/// </summary>
		[XAQueryFieldAttribute("D2ovdRepayRqrdAmt", "D2연체변제소요금액", "long", "16")]
		public long D2ovdRepayRqrdAmt;
		/// <summary>
		/// 융자금액
		/// </summary>
		[XAQueryFieldAttribute("MloanAmt", "융자금액", "long", "16")]
		public long MloanAmt;
		/// <summary>
		/// 변경후담보비율
		/// </summary>
		[XAQueryFieldAttribute("ChgAfPldgRat", "변경후담보비율", "double", "9.3")]
		public double ChgAfPldgRat;
		/// <summary>
		/// 소요담보금액
		/// </summary>
		[XAQueryFieldAttribute("RqrdPldgAmt", "소요담보금액", "long", "16")]
		public long RqrdPldgAmt;
		/// <summary>
		/// 담보부족금액
		/// </summary>
		[XAQueryFieldAttribute("PdlckAmt", "담보부족금액", "long", "16")]
		public long PdlckAmt;
		/// <summary>
		/// 원담보합계금액
		/// </summary>
		[XAQueryFieldAttribute("OrgPldgSumAmt", "원담보합계금액", "long", "16")]
		public long OrgPldgSumAmt;
		/// <summary>
		/// 부담보합계금액
		/// </summary>
		[XAQueryFieldAttribute("SubPldgSumAmt", "부담보합계금액", "long", "16")]
		public long SubPldgSumAmt;
		/// <summary>
		/// 신용담보금현금
		/// </summary>
		[XAQueryFieldAttribute("CrdtPldgAmtMny", "신용담보금현금", "long", "16")]
		public long CrdtPldgAmtMny;
		/// <summary>
		/// 신용담보대용금액
		/// </summary>
		[XAQueryFieldAttribute("CrdtPldgSubstAmt", "신용담보대용금액", "long", "16")]
		public long CrdtPldgSubstAmt;
		/// <summary>
		/// 신용설정보증금
		/// </summary>
		[XAQueryFieldAttribute("Imreq", "신용설정보증금", "long", "16")]
		public long Imreq;
		/// <summary>
		/// 신용담보재사용금액
		/// </summary>
		[XAQueryFieldAttribute("CrdtPldgRuseAmt", "신용담보재사용금액", "long", "16")]
		public long CrdtPldgRuseAmt;
		/// <summary>
		/// 처분제한금액
		/// </summary>
		[XAQueryFieldAttribute("DpslRestrcAmt", "처분제한금액", "long", "16")]
		public long DpslRestrcAmt;
		/// <summary>
		/// 전일매도정산금액
		/// </summary>
		[XAQueryFieldAttribute("PrdaySellAdjstAmt", "전일매도정산금액", "long", "16")]
		public long PrdaySellAdjstAmt;
		/// <summary>
		/// 전일매수정산금액
		/// </summary>
		[XAQueryFieldAttribute("PrdayBuyAdjstAmt", "전일매수정산금액", "long", "16")]
		public long PrdayBuyAdjstAmt;
		/// <summary>
		/// 금일매도정산금액
		/// </summary>
		[XAQueryFieldAttribute("CrdaySellAdjstAmt", "금일매도정산금액", "long", "16")]
		public long CrdaySellAdjstAmt;
		/// <summary>
		/// 금일매수정산금액
		/// </summary>
		[XAQueryFieldAttribute("CrdayBuyAdjstAmt", "금일매수정산금액", "long", "16")]
		public long CrdayBuyAdjstAmt;
		/// <summary>
		/// 매도대금담보대출금액
		/// </summary>
		[XAQueryFieldAttribute("CslLoanAmtdt1", "매도대금담보대출금액", "long", "16")]
		public long CslLoanAmtdt1;

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
			/// 대용주문가능금액
			/// </summary>
			public const string SubstOrdAbleAmt = "SubstOrdAbleAmt";
			/// <summary>
			/// 거래소금액
			/// </summary>
			public const string SeOrdAbleAmt = "SeOrdAbleAmt";
			/// <summary>
			/// 코스닥금액
			/// </summary>
			public const string KdqOrdAbleAmt = "KdqOrdAbleAmt";
			/// <summary>
			/// 신용담보주문금액
			/// </summary>
			public const string CrdtPldgOrdAmt = "CrdtPldgOrdAmt";
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
			/// 신용주문가능금액
			/// </summary>
			public const string CrdtOrdAbleAmt = "CrdtOrdAbleAmt";
			/// <summary>
			/// 예수금
			/// </summary>
			public const string Dps = "Dps";
			/// <summary>
			/// 대용금액
			/// </summary>
			public const string SubstAmt = "SubstAmt";
			/// <summary>
			/// 증거금현금
			/// </summary>
			public const string MgnMny = "MgnMny";
			/// <summary>
			/// 증거금대용
			/// </summary>
			public const string MgnSubst = "MgnSubst";
			/// <summary>
			/// D1예수금
			/// </summary>
			public const string D1Dps = "D1Dps";
			/// <summary>
			/// D2예수금
			/// </summary>
			public const string D2Dps = "D2Dps";
			/// <summary>
			/// 미수금액
			/// </summary>
			public const string RcvblAmt = "RcvblAmt";
			/// <summary>
			/// D1연체변제소요금액
			/// </summary>
			public const string D1ovdRepayRqrdAmt = "D1ovdRepayRqrdAmt";
			/// <summary>
			/// D2연체변제소요금액
			/// </summary>
			public const string D2ovdRepayRqrdAmt = "D2ovdRepayRqrdAmt";
			/// <summary>
			/// 융자금액
			/// </summary>
			public const string MloanAmt = "MloanAmt";
			/// <summary>
			/// 변경후담보비율
			/// </summary>
			public const string ChgAfPldgRat = "ChgAfPldgRat";
			/// <summary>
			/// 소요담보금액
			/// </summary>
			public const string RqrdPldgAmt = "RqrdPldgAmt";
			/// <summary>
			/// 담보부족금액
			/// </summary>
			public const string PdlckAmt = "PdlckAmt";
			/// <summary>
			/// 원담보합계금액
			/// </summary>
			public const string OrgPldgSumAmt = "OrgPldgSumAmt";
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
			/// 신용설정보증금
			/// </summary>
			public const string Imreq = "Imreq";
			/// <summary>
			/// 신용담보재사용금액
			/// </summary>
			public const string CrdtPldgRuseAmt = "CrdtPldgRuseAmt";
			/// <summary>
			/// 처분제한금액
			/// </summary>
			public const string DpslRestrcAmt = "DpslRestrcAmt";
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
			/// 매도대금담보대출금액
			/// </summary>
			public const string CslLoanAmtdt1 = "CslLoanAmtdt1";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.BrnNm,
			F.AcntNm,
			F.MnyOrdAbleAmt,
			F.SubstOrdAbleAmt,
			F.SeOrdAbleAmt,
			F.KdqOrdAbleAmt,
			F.CrdtPldgOrdAmt,
			F.MgnRat100pctOrdAbleAmt,
			F.MgnRat35ordAbleAmt,
			F.MgnRat50ordAbleAmt,
			F.CrdtOrdAbleAmt,
			F.Dps,
			F.SubstAmt,
			F.MgnMny,
			F.MgnSubst,
			F.D1Dps,
			F.D2Dps,
			F.RcvblAmt,
			F.D1ovdRepayRqrdAmt,
			F.D2ovdRepayRqrdAmt,
			F.MloanAmt,
			F.ChgAfPldgRat,
			F.RqrdPldgAmt,
			F.PdlckAmt,
			F.OrgPldgSumAmt,
			F.SubPldgSumAmt,
			F.CrdtPldgAmtMny,
			F.CrdtPldgSubstAmt,
			F.Imreq,
			F.CrdtPldgRuseAmt,
			F.DpslRestrcAmt,
			F.PrdaySellAdjstAmt,
			F.PrdayBuyAdjstAmt,
			F.CrdaySellAdjstAmt,
			F.CrdayBuyAdjstAmt,
			F.CslLoanAmtdt1,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["BrnNm"] = new XAQueryFieldInfo("char", BrnNm, BrnNm, "지점명", (decimal)40);
			dict["AcntNm"] = new XAQueryFieldInfo("char", AcntNm, AcntNm, "계좌명", (decimal)40);
			dict["MnyOrdAbleAmt"] = new XAQueryFieldInfo("long", MnyOrdAbleAmt, MnyOrdAbleAmt.ToString("d16"), "현금주문가능금액", (decimal)16);
			dict["SubstOrdAbleAmt"] = new XAQueryFieldInfo("long", SubstOrdAbleAmt, SubstOrdAbleAmt.ToString("d16"), "대용주문가능금액", (decimal)16);
			dict["SeOrdAbleAmt"] = new XAQueryFieldInfo("long", SeOrdAbleAmt, SeOrdAbleAmt.ToString("d16"), "거래소금액", (decimal)16);
			dict["KdqOrdAbleAmt"] = new XAQueryFieldInfo("long", KdqOrdAbleAmt, KdqOrdAbleAmt.ToString("d16"), "코스닥금액", (decimal)16);
			dict["CrdtPldgOrdAmt"] = new XAQueryFieldInfo("long", CrdtPldgOrdAmt, CrdtPldgOrdAmt.ToString("d16"), "신용담보주문금액", (decimal)16);
			dict["MgnRat100pctOrdAbleAmt"] = new XAQueryFieldInfo("long", MgnRat100pctOrdAbleAmt, MgnRat100pctOrdAbleAmt.ToString("d16"), "증거금률100퍼센트주문가능금액", (decimal)16);
			dict["MgnRat35ordAbleAmt"] = new XAQueryFieldInfo("long", MgnRat35ordAbleAmt, MgnRat35ordAbleAmt.ToString("d16"), "증거금률35%주문가능금액", (decimal)16);
			dict["MgnRat50ordAbleAmt"] = new XAQueryFieldInfo("long", MgnRat50ordAbleAmt, MgnRat50ordAbleAmt.ToString("d16"), "증거금률50%주문가능금액", (decimal)16);
			dict["CrdtOrdAbleAmt"] = new XAQueryFieldInfo("long", CrdtOrdAbleAmt, CrdtOrdAbleAmt.ToString("d16"), "신용주문가능금액", (decimal)16);
			dict["Dps"] = new XAQueryFieldInfo("long", Dps, Dps.ToString("d16"), "예수금", (decimal)16);
			dict["SubstAmt"] = new XAQueryFieldInfo("long", SubstAmt, SubstAmt.ToString("d16"), "대용금액", (decimal)16);
			dict["MgnMny"] = new XAQueryFieldInfo("long", MgnMny, MgnMny.ToString("d16"), "증거금현금", (decimal)16);
			dict["MgnSubst"] = new XAQueryFieldInfo("long", MgnSubst, MgnSubst.ToString("d16"), "증거금대용", (decimal)16);
			dict["D1Dps"] = new XAQueryFieldInfo("long", D1Dps, D1Dps.ToString("d16"), "D1예수금", (decimal)16);
			dict["D2Dps"] = new XAQueryFieldInfo("long", D2Dps, D2Dps.ToString("d16"), "D2예수금", (decimal)16);
			dict["RcvblAmt"] = new XAQueryFieldInfo("long", RcvblAmt, RcvblAmt.ToString("d16"), "미수금액", (decimal)16);
			dict["D1ovdRepayRqrdAmt"] = new XAQueryFieldInfo("long", D1ovdRepayRqrdAmt, D1ovdRepayRqrdAmt.ToString("d16"), "D1연체변제소요금액", (decimal)16);
			dict["D2ovdRepayRqrdAmt"] = new XAQueryFieldInfo("long", D2ovdRepayRqrdAmt, D2ovdRepayRqrdAmt.ToString("d16"), "D2연체변제소요금액", (decimal)16);
			dict["MloanAmt"] = new XAQueryFieldInfo("long", MloanAmt, MloanAmt.ToString("d16"), "융자금액", (decimal)16);
			dict["ChgAfPldgRat"] = new XAQueryFieldInfo("double", ChgAfPldgRat, ChgAfPldgRat.ToString("000000000.000"), "변경후담보비율", (decimal)9.3);
			dict["RqrdPldgAmt"] = new XAQueryFieldInfo("long", RqrdPldgAmt, RqrdPldgAmt.ToString("d16"), "소요담보금액", (decimal)16);
			dict["PdlckAmt"] = new XAQueryFieldInfo("long", PdlckAmt, PdlckAmt.ToString("d16"), "담보부족금액", (decimal)16);
			dict["OrgPldgSumAmt"] = new XAQueryFieldInfo("long", OrgPldgSumAmt, OrgPldgSumAmt.ToString("d16"), "원담보합계금액", (decimal)16);
			dict["SubPldgSumAmt"] = new XAQueryFieldInfo("long", SubPldgSumAmt, SubPldgSumAmt.ToString("d16"), "부담보합계금액", (decimal)16);
			dict["CrdtPldgAmtMny"] = new XAQueryFieldInfo("long", CrdtPldgAmtMny, CrdtPldgAmtMny.ToString("d16"), "신용담보금현금", (decimal)16);
			dict["CrdtPldgSubstAmt"] = new XAQueryFieldInfo("long", CrdtPldgSubstAmt, CrdtPldgSubstAmt.ToString("d16"), "신용담보대용금액", (decimal)16);
			dict["Imreq"] = new XAQueryFieldInfo("long", Imreq, Imreq.ToString("d16"), "신용설정보증금", (decimal)16);
			dict["CrdtPldgRuseAmt"] = new XAQueryFieldInfo("long", CrdtPldgRuseAmt, CrdtPldgRuseAmt.ToString("d16"), "신용담보재사용금액", (decimal)16);
			dict["DpslRestrcAmt"] = new XAQueryFieldInfo("long", DpslRestrcAmt, DpslRestrcAmt.ToString("d16"), "처분제한금액", (decimal)16);
			dict["PrdaySellAdjstAmt"] = new XAQueryFieldInfo("long", PrdaySellAdjstAmt, PrdaySellAdjstAmt.ToString("d16"), "전일매도정산금액", (decimal)16);
			dict["PrdayBuyAdjstAmt"] = new XAQueryFieldInfo("long", PrdayBuyAdjstAmt, PrdayBuyAdjstAmt.ToString("d16"), "전일매수정산금액", (decimal)16);
			dict["CrdaySellAdjstAmt"] = new XAQueryFieldInfo("long", CrdaySellAdjstAmt, CrdaySellAdjstAmt.ToString("d16"), "금일매도정산금액", (decimal)16);
			dict["CrdayBuyAdjstAmt"] = new XAQueryFieldInfo("long", CrdayBuyAdjstAmt, CrdayBuyAdjstAmt.ToString("d16"), "금일매수정산금액", (decimal)16);
			dict["CslLoanAmtdt1"] = new XAQueryFieldInfo("long", CslLoanAmtdt1, CslLoanAmtdt1.ToString("d16"), "매도대금담보대출금액", (decimal)16);

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

				case "SubstOrdAbleAmt":
					this.SubstOrdAbleAmt = fieldInfo.FieldValue.ParseLong("SubstOrdAbleAmt");
				break;

				case "SeOrdAbleAmt":
					this.SeOrdAbleAmt = fieldInfo.FieldValue.ParseLong("SeOrdAbleAmt");
				break;

				case "KdqOrdAbleAmt":
					this.KdqOrdAbleAmt = fieldInfo.FieldValue.ParseLong("KdqOrdAbleAmt");
				break;

				case "CrdtPldgOrdAmt":
					this.CrdtPldgOrdAmt = fieldInfo.FieldValue.ParseLong("CrdtPldgOrdAmt");
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

				case "CrdtOrdAbleAmt":
					this.CrdtOrdAbleAmt = fieldInfo.FieldValue.ParseLong("CrdtOrdAbleAmt");
				break;

				case "Dps":
					this.Dps = fieldInfo.FieldValue.ParseLong("Dps");
				break;

				case "SubstAmt":
					this.SubstAmt = fieldInfo.FieldValue.ParseLong("SubstAmt");
				break;

				case "MgnMny":
					this.MgnMny = fieldInfo.FieldValue.ParseLong("MgnMny");
				break;

				case "MgnSubst":
					this.MgnSubst = fieldInfo.FieldValue.ParseLong("MgnSubst");
				break;

				case "D1Dps":
					this.D1Dps = fieldInfo.FieldValue.ParseLong("D1Dps");
				break;

				case "D2Dps":
					this.D2Dps = fieldInfo.FieldValue.ParseLong("D2Dps");
				break;

				case "RcvblAmt":
					this.RcvblAmt = fieldInfo.FieldValue.ParseLong("RcvblAmt");
				break;

				case "D1ovdRepayRqrdAmt":
					this.D1ovdRepayRqrdAmt = fieldInfo.FieldValue.ParseLong("D1ovdRepayRqrdAmt");
				break;

				case "D2ovdRepayRqrdAmt":
					this.D2ovdRepayRqrdAmt = fieldInfo.FieldValue.ParseLong("D2ovdRepayRqrdAmt");
				break;

				case "MloanAmt":
					this.MloanAmt = fieldInfo.FieldValue.ParseLong("MloanAmt");
				break;

				case "ChgAfPldgRat":
					this.ChgAfPldgRat = fieldInfo.FieldValue.ParseDouble("ChgAfPldgRat");
				break;

				case "RqrdPldgAmt":
					this.RqrdPldgAmt = fieldInfo.FieldValue.ParseLong("RqrdPldgAmt");
				break;

				case "PdlckAmt":
					this.PdlckAmt = fieldInfo.FieldValue.ParseLong("PdlckAmt");
				break;

				case "OrgPldgSumAmt":
					this.OrgPldgSumAmt = fieldInfo.FieldValue.ParseLong("OrgPldgSumAmt");
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

				case "Imreq":
					this.Imreq = fieldInfo.FieldValue.ParseLong("Imreq");
				break;

				case "CrdtPldgRuseAmt":
					this.CrdtPldgRuseAmt = fieldInfo.FieldValue.ParseLong("CrdtPldgRuseAmt");
				break;

				case "DpslRestrcAmt":
					this.DpslRestrcAmt = fieldInfo.FieldValue.ParseLong("DpslRestrcAmt");
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

				case "CslLoanAmtdt1":
					this.CslLoanAmtdt1 = fieldInfo.FieldValue.ParseLong("CslLoanAmtdt1");
				break;


			}
		}

		public static XQCSPAQ22200OutBlock2 FromQuery(XQCSPAQ22200 query)
		{
			XQCSPAQ22200OutBlock2 block = new XQCSPAQ22200OutBlock2();
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
				block.SubstOrdAbleAmt = query.GetFieldData(block.GetBlockName(), "SubstOrdAbleAmt", 0).ParseLong("SubstOrdAbleAmt"); // long 16
				block.SeOrdAbleAmt = query.GetFieldData(block.GetBlockName(), "SeOrdAbleAmt", 0).ParseLong("SeOrdAbleAmt"); // long 16
				block.KdqOrdAbleAmt = query.GetFieldData(block.GetBlockName(), "KdqOrdAbleAmt", 0).ParseLong("KdqOrdAbleAmt"); // long 16
				block.CrdtPldgOrdAmt = query.GetFieldData(block.GetBlockName(), "CrdtPldgOrdAmt", 0).ParseLong("CrdtPldgOrdAmt"); // long 16
				block.MgnRat100pctOrdAbleAmt = query.GetFieldData(block.GetBlockName(), "MgnRat100pctOrdAbleAmt", 0).ParseLong("MgnRat100pctOrdAbleAmt"); // long 16
				block.MgnRat35ordAbleAmt = query.GetFieldData(block.GetBlockName(), "MgnRat35ordAbleAmt", 0).ParseLong("MgnRat35ordAbleAmt"); // long 16
				block.MgnRat50ordAbleAmt = query.GetFieldData(block.GetBlockName(), "MgnRat50ordAbleAmt", 0).ParseLong("MgnRat50ordAbleAmt"); // long 16
				block.CrdtOrdAbleAmt = query.GetFieldData(block.GetBlockName(), "CrdtOrdAbleAmt", 0).ParseLong("CrdtOrdAbleAmt"); // long 16
				block.Dps = query.GetFieldData(block.GetBlockName(), "Dps", 0).ParseLong("Dps"); // long 16
				block.SubstAmt = query.GetFieldData(block.GetBlockName(), "SubstAmt", 0).ParseLong("SubstAmt"); // long 16
				block.MgnMny = query.GetFieldData(block.GetBlockName(), "MgnMny", 0).ParseLong("MgnMny"); // long 16
				block.MgnSubst = query.GetFieldData(block.GetBlockName(), "MgnSubst", 0).ParseLong("MgnSubst"); // long 16
				block.D1Dps = query.GetFieldData(block.GetBlockName(), "D1Dps", 0).ParseLong("D1Dps"); // long 16
				block.D2Dps = query.GetFieldData(block.GetBlockName(), "D2Dps", 0).ParseLong("D2Dps"); // long 16
				block.RcvblAmt = query.GetFieldData(block.GetBlockName(), "RcvblAmt", 0).ParseLong("RcvblAmt"); // long 16
				block.D1ovdRepayRqrdAmt = query.GetFieldData(block.GetBlockName(), "D1ovdRepayRqrdAmt", 0).ParseLong("D1ovdRepayRqrdAmt"); // long 16
				block.D2ovdRepayRqrdAmt = query.GetFieldData(block.GetBlockName(), "D2ovdRepayRqrdAmt", 0).ParseLong("D2ovdRepayRqrdAmt"); // long 16
				block.MloanAmt = query.GetFieldData(block.GetBlockName(), "MloanAmt", 0).ParseLong("MloanAmt"); // long 16
				block.ChgAfPldgRat = query.GetFieldData(block.GetBlockName(), "ChgAfPldgRat", 0).ParseDouble("ChgAfPldgRat"); // double 9.3
				block.RqrdPldgAmt = query.GetFieldData(block.GetBlockName(), "RqrdPldgAmt", 0).ParseLong("RqrdPldgAmt"); // long 16
				block.PdlckAmt = query.GetFieldData(block.GetBlockName(), "PdlckAmt", 0).ParseLong("PdlckAmt"); // long 16
				block.OrgPldgSumAmt = query.GetFieldData(block.GetBlockName(), "OrgPldgSumAmt", 0).ParseLong("OrgPldgSumAmt"); // long 16
				block.SubPldgSumAmt = query.GetFieldData(block.GetBlockName(), "SubPldgSumAmt", 0).ParseLong("SubPldgSumAmt"); // long 16
				block.CrdtPldgAmtMny = query.GetFieldData(block.GetBlockName(), "CrdtPldgAmtMny", 0).ParseLong("CrdtPldgAmtMny"); // long 16
				block.CrdtPldgSubstAmt = query.GetFieldData(block.GetBlockName(), "CrdtPldgSubstAmt", 0).ParseLong("CrdtPldgSubstAmt"); // long 16
				block.Imreq = query.GetFieldData(block.GetBlockName(), "Imreq", 0).ParseLong("Imreq"); // long 16
				block.CrdtPldgRuseAmt = query.GetFieldData(block.GetBlockName(), "CrdtPldgRuseAmt", 0).ParseLong("CrdtPldgRuseAmt"); // long 16
				block.DpslRestrcAmt = query.GetFieldData(block.GetBlockName(), "DpslRestrcAmt", 0).ParseLong("DpslRestrcAmt"); // long 16
				block.PrdaySellAdjstAmt = query.GetFieldData(block.GetBlockName(), "PrdaySellAdjstAmt", 0).ParseLong("PrdaySellAdjstAmt"); // long 16
				block.PrdayBuyAdjstAmt = query.GetFieldData(block.GetBlockName(), "PrdayBuyAdjstAmt", 0).ParseLong("PrdayBuyAdjstAmt"); // long 16
				block.CrdaySellAdjstAmt = query.GetFieldData(block.GetBlockName(), "CrdaySellAdjstAmt", 0).ParseLong("CrdaySellAdjstAmt"); // long 16
				block.CrdayBuyAdjstAmt = query.GetFieldData(block.GetBlockName(), "CrdayBuyAdjstAmt", 0).ParseLong("CrdayBuyAdjstAmt"); // long 16
				block.CslLoanAmtdt1 = query.GetFieldData(block.GetBlockName(), "CslLoanAmtdt1", 0).ParseLong("CslLoanAmtdt1"); // long 16

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
			if (SubstOrdAbleAmt.ToString().Length > 16) return false; // long 16
			if (SeOrdAbleAmt.ToString().Length > 16) return false; // long 16
			if (KdqOrdAbleAmt.ToString().Length > 16) return false; // long 16
			if (CrdtPldgOrdAmt.ToString().Length > 16) return false; // long 16
			if (MgnRat100pctOrdAbleAmt.ToString().Length > 16) return false; // long 16
			if (MgnRat35ordAbleAmt.ToString().Length > 16) return false; // long 16
			if (MgnRat50ordAbleAmt.ToString().Length > 16) return false; // long 16
			if (CrdtOrdAbleAmt.ToString().Length > 16) return false; // long 16
			if (Dps.ToString().Length > 16) return false; // long 16
			if (SubstAmt.ToString().Length > 16) return false; // long 16
			if (MgnMny.ToString().Length > 16) return false; // long 16
			if (MgnSubst.ToString().Length > 16) return false; // long 16
			if (D1Dps.ToString().Length > 16) return false; // long 16
			if (D2Dps.ToString().Length > 16) return false; // long 16
			if (RcvblAmt.ToString().Length > 16) return false; // long 16
			if (D1ovdRepayRqrdAmt.ToString().Length > 16) return false; // long 16
			if (D2ovdRepayRqrdAmt.ToString().Length > 16) return false; // long 16
			if (MloanAmt.ToString().Length > 16) return false; // long 16
			// ChgAfPldgRat double 9.3
			if (RqrdPldgAmt.ToString().Length > 16) return false; // long 16
			if (PdlckAmt.ToString().Length > 16) return false; // long 16
			if (OrgPldgSumAmt.ToString().Length > 16) return false; // long 16
			if (SubPldgSumAmt.ToString().Length > 16) return false; // long 16
			if (CrdtPldgAmtMny.ToString().Length > 16) return false; // long 16
			if (CrdtPldgSubstAmt.ToString().Length > 16) return false; // long 16
			if (Imreq.ToString().Length > 16) return false; // long 16
			if (CrdtPldgRuseAmt.ToString().Length > 16) return false; // long 16
			if (DpslRestrcAmt.ToString().Length > 16) return false; // long 16
			if (PrdaySellAdjstAmt.ToString().Length > 16) return false; // long 16
			if (PrdayBuyAdjstAmt.ToString().Length > 16) return false; // long 16
			if (CrdaySellAdjstAmt.ToString().Length > 16) return false; // long 16
			if (CrdayBuyAdjstAmt.ToString().Length > 16) return false; // long 16
			if (CslLoanAmtdt1.ToString().Length > 16) return false; // long 16

			return true;
		}
	}

	/// <summary>
	/// 현물계좌예수금 주문가능금액 총평가2
	/// </summary>
	public partial class XQCSPAQ22200 : XingQuery
	{
		/// <summary>
		/// CSPAQ22200
		/// </summary>
		public const string _typeName = "CSPAQ22200";
		/// <summary>
		/// 현물계좌예수금 주문가능금액 총평가2
		/// </summary>
		public const string _typeDesc = "현물계좌예수금 주문가능금액 총평가2";
		/// <summary>
		/// CSPAQ22200
		/// </summary>
		public const string _service = "CSPAQ22200";
		/// <summary>
		/// B
		/// </summary>
		public const string _headType = "B";
		/// <summary>
		/// 송우석
		/// </summary>
		public const string _creator = "송우석";
		/// <summary>
		/// 2020/02/25 08:21:10
		/// </summary>
		public const string _createdDate = "2020/02/25 08:21:10";
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
		/// CSPAQ22200
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 현물계좌예수금 주문가능금액 총평가2
		/// </summary>
		public string TypeDesc => _typeDesc;
		/// <summary>
		/// CSPAQ22200
		/// </summary>
		public string Service => _service;
		/// <summary>
		/// B
		/// </summary>
		public string HeadType => _headType;
		/// <summary>
		/// 송우석
		/// </summary>
		public string Creator => _creator;
		/// <summary>
		/// 2020/02/25 08:21:10
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
		/// 현물계좌예수금 주문가능금액 총평가2
		/// </summary>
		public XQCSPAQ22200() : base("CSPAQ22200") { }




		public bool SetBlock(XQCSPAQ22200InBlock1 block)
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

		public XQCSPAQ22200OutBlock1 GetBlock1()
		{
			XQCSPAQ22200OutBlock1 instance = XQCSPAQ22200OutBlock1.FromQuery(this);
			return instance;

		}

		public XQCSPAQ22200OutBlock2 GetBlock2()
		{
			XQCSPAQ22200OutBlock2 instance = XQCSPAQ22200OutBlock2.FromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQCSPAQ22200OutBlock1),
			typeof(XQCSPAQ22200OutBlock2),

		};

	}

}
