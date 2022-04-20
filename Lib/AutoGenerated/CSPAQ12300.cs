using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQCSPAQ12300InBlock1 : XingBlock
	{
		/// <summary>
		/// CSPAQ12300InBlock1
		/// </summary>
		public const string _blockName = "CSPAQ12300InBlock1";
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
		/// CSPAQ12300InBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CSPAQ12300InBlock1
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
		/// <summary>
		/// 수수료적용구분
		/// </summary>
		[XAQueryFieldAttribute("CmsnAppTpCode", "수수료적용구분", "char", "1")]
		public char CmsnAppTpCode;
		/// <summary>
		/// D2잔고기준조회구분
		/// </summary>
		[XAQueryFieldAttribute("D2balBaseQryTp", "D2잔고기준조회구분", "char", "1")]
		public char D2balBaseQryTp;
		/// <summary>
		/// 단가구분
		/// </summary>
		[XAQueryFieldAttribute("UprcTpCode", "단가구분", "char", "1")]
		public char UprcTpCode;

		public static class F
		{
			/// <summary>
			/// 레코드갯수
			/// </summary>
			public const string RecCnt = "RecCnt";
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
			/// <summary>
			/// 수수료적용구분
			/// </summary>
			public const string CmsnAppTpCode = "CmsnAppTpCode";
			/// <summary>
			/// D2잔고기준조회구분
			/// </summary>
			public const string D2balBaseQryTp = "D2balBaseQryTp";
			/// <summary>
			/// 단가구분
			/// </summary>
			public const string UprcTpCode = "UprcTpCode";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.AcntNo,
			F.Pwd,
			F.BalCreTp,
			F.CmsnAppTpCode,
			F.D2balBaseQryTp,
			F.UprcTpCode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["AcntNo"] = new XAQueryFieldInfo("char", AcntNo, AcntNo, "계좌번호", (decimal)20);
			dict["Pwd"] = new XAQueryFieldInfo("char", Pwd, Pwd, "비밀번호", (decimal)8);
			dict["BalCreTp"] = new XAQueryFieldInfo("char", BalCreTp, BalCreTp.ToString(), "잔고생성구분", (decimal)1);
			dict["CmsnAppTpCode"] = new XAQueryFieldInfo("char", CmsnAppTpCode, CmsnAppTpCode.ToString(), "수수료적용구분", (decimal)1);
			dict["D2balBaseQryTp"] = new XAQueryFieldInfo("char", D2balBaseQryTp, D2balBaseQryTp.ToString(), "D2잔고기준조회구분", (decimal)1);
			dict["UprcTpCode"] = new XAQueryFieldInfo("char", UprcTpCode, UprcTpCode.ToString(), "단가구분", (decimal)1);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "RecCnt":
					this.RecCnt = fieldInfo.FieldValue.ParseLong("RecCnt");
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

				case "CmsnAppTpCode":
					this.CmsnAppTpCode = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "D2balBaseQryTp":
					this.D2balBaseQryTp = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "UprcTpCode":
					this.UprcTpCode = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public bool VerifyData()
		{
			if (RecCnt.ToString().Length > 5) return false; // long 5
			if (AcntNo?.Length > 20) return false; // char 20
			if (Pwd?.Length > 8) return false; // char 8
			// BalCreTp char 1
			// CmsnAppTpCode char 1
			// D2balBaseQryTp char 1
			// UprcTpCode char 1

			return true;
		}

		public void CopyTo(XQCSPAQ12300InBlock1 block)
		{
			block.RecCnt = this.RecCnt;
			block.AcntNo = this.AcntNo;
			block.Pwd = this.Pwd;
			block.BalCreTp = this.BalCreTp;
			block.CmsnAppTpCode = this.CmsnAppTpCode;
			block.D2balBaseQryTp = this.D2balBaseQryTp;
			block.UprcTpCode = this.UprcTpCode;

		}
	}

	public partial class XQCSPAQ12300OutBlock1 : XingBlock
	{
		/// <summary>
		/// CSPAQ12300OutBlock1
		/// </summary>
		public const string _blockName = "CSPAQ12300OutBlock1";
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
		/// CSPAQ12300OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CSPAQ12300OutBlock1
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
		/// <summary>
		/// 수수료적용구분
		/// </summary>
		[XAQueryFieldAttribute("CmsnAppTpCode", "수수료적용구분", "char", "1")]
		public char CmsnAppTpCode;
		/// <summary>
		/// D2잔고기준조회구분
		/// </summary>
		[XAQueryFieldAttribute("D2balBaseQryTp", "D2잔고기준조회구분", "char", "1")]
		public char D2balBaseQryTp;
		/// <summary>
		/// 단가구분
		/// </summary>
		[XAQueryFieldAttribute("UprcTpCode", "단가구분", "char", "1")]
		public char UprcTpCode;

		public static class F
		{
			/// <summary>
			/// 레코드갯수
			/// </summary>
			public const string RecCnt = "RecCnt";
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
			/// <summary>
			/// 수수료적용구분
			/// </summary>
			public const string CmsnAppTpCode = "CmsnAppTpCode";
			/// <summary>
			/// D2잔고기준조회구분
			/// </summary>
			public const string D2balBaseQryTp = "D2balBaseQryTp";
			/// <summary>
			/// 단가구분
			/// </summary>
			public const string UprcTpCode = "UprcTpCode";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.AcntNo,
			F.Pwd,
			F.BalCreTp,
			F.CmsnAppTpCode,
			F.D2balBaseQryTp,
			F.UprcTpCode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["AcntNo"] = new XAQueryFieldInfo("char", AcntNo, AcntNo, "계좌번호", (decimal)20);
			dict["Pwd"] = new XAQueryFieldInfo("char", Pwd, Pwd, "비밀번호", (decimal)8);
			dict["BalCreTp"] = new XAQueryFieldInfo("char", BalCreTp, BalCreTp.ToString(), "잔고생성구분", (decimal)1);
			dict["CmsnAppTpCode"] = new XAQueryFieldInfo("char", CmsnAppTpCode, CmsnAppTpCode.ToString(), "수수료적용구분", (decimal)1);
			dict["D2balBaseQryTp"] = new XAQueryFieldInfo("char", D2balBaseQryTp, D2balBaseQryTp.ToString(), "D2잔고기준조회구분", (decimal)1);
			dict["UprcTpCode"] = new XAQueryFieldInfo("char", UprcTpCode, UprcTpCode.ToString(), "단가구분", (decimal)1);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "RecCnt":
					this.RecCnt = fieldInfo.FieldValue.ParseLong("RecCnt");
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

				case "CmsnAppTpCode":
					this.CmsnAppTpCode = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "D2balBaseQryTp":
					this.D2balBaseQryTp = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "UprcTpCode":
					this.UprcTpCode = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public static XQCSPAQ12300OutBlock1 FromQuery(XQCSPAQ12300 query)
		{
			XQCSPAQ12300OutBlock1 block = new XQCSPAQ12300OutBlock1();
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
				block.AcntNo = query.GetFieldData(block.GetBlockName(), "AcntNo", 0).TrimEnd('?'); // char 20
				block.Pwd = query.GetFieldData(block.GetBlockName(), "Pwd", 0).TrimEnd('?'); // char 8
				block.BalCreTp = query.GetFieldData(block.GetBlockName(), "BalCreTp", 0).FirstOrDefault(); // char 1
				block.CmsnAppTpCode = query.GetFieldData(block.GetBlockName(), "CmsnAppTpCode", 0).FirstOrDefault(); // char 1
				block.D2balBaseQryTp = query.GetFieldData(block.GetBlockName(), "D2balBaseQryTp", 0).FirstOrDefault(); // char 1
				block.UprcTpCode = query.GetFieldData(block.GetBlockName(), "UprcTpCode", 0).FirstOrDefault(); // char 1

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (RecCnt.ToString().Length > 5) return false; // long 5
			if (AcntNo?.Length > 20) return false; // char 20
			if (Pwd?.Length > 8) return false; // char 8
			// BalCreTp char 1
			// CmsnAppTpCode char 1
			// D2balBaseQryTp char 1
			// UprcTpCode char 1

			return true;
		}

		public void CopyTo(XQCSPAQ12300OutBlock1 block)
		{
			block.RecCnt = this.RecCnt;
			block.AcntNo = this.AcntNo;
			block.Pwd = this.Pwd;
			block.BalCreTp = this.BalCreTp;
			block.CmsnAppTpCode = this.CmsnAppTpCode;
			block.D2balBaseQryTp = this.D2balBaseQryTp;
			block.UprcTpCode = this.UprcTpCode;

		}
	}

	public partial class XQCSPAQ12300OutBlock2 : XingBlock
	{
		/// <summary>
		/// CSPAQ12300OutBlock2
		/// </summary>
		public const string _blockName = "CSPAQ12300OutBlock2";
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
		/// CSPAQ12300OutBlock2
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CSPAQ12300OutBlock2
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
		/// 출금가능금액
		/// </summary>
		[XAQueryFieldAttribute("MnyoutAbleAmt", "출금가능금액", "long", "16")]
		public long MnyoutAbleAmt;
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
		/// HTS주문가능금액
		/// </summary>
		[XAQueryFieldAttribute("HtsOrdAbleAmt", "HTS주문가능금액", "long", "16")]
		public long HtsOrdAbleAmt;
		/// <summary>
		/// 증거금률100퍼센트주문가능금액
		/// </summary>
		[XAQueryFieldAttribute("MgnRat100pctOrdAbleAmt", "증거금률100퍼센트주문가능금액", "long", "16")]
		public long MgnRat100pctOrdAbleAmt;
		/// <summary>
		/// 잔고평가금액
		/// </summary>
		[XAQueryFieldAttribute("BalEvalAmt", "잔고평가금액", "long", "16")]
		public long BalEvalAmt;
		/// <summary>
		/// 매입금액
		/// </summary>
		[XAQueryFieldAttribute("PchsAmt", "매입금액", "long", "16")]
		public long PchsAmt;
		/// <summary>
		/// 미수금액
		/// </summary>
		[XAQueryFieldAttribute("RcvblAmt", "미수금액", "long", "16")]
		public long RcvblAmt;
		/// <summary>
		/// 손익율
		/// </summary>
		[XAQueryFieldAttribute("PnlRat", "손익율", "double", "18.6")]
		public double PnlRat;
		/// <summary>
		/// 투자원금
		/// </summary>
		[XAQueryFieldAttribute("InvstOrgAmt", "투자원금", "long", "20")]
		public long InvstOrgAmt;
		/// <summary>
		/// 투자손익금액
		/// </summary>
		[XAQueryFieldAttribute("InvstPlAmt", "투자손익금액", "long", "16")]
		public long InvstPlAmt;
		/// <summary>
		/// 신용담보주문금액
		/// </summary>
		[XAQueryFieldAttribute("CrdtPldgOrdAmt", "신용담보주문금액", "long", "16")]
		public long CrdtPldgOrdAmt;
		/// <summary>
		/// 예수금
		/// </summary>
		[XAQueryFieldAttribute("Dps", "예수금", "long", "16")]
		public long Dps;
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
		/// 주문일
		/// </summary>
		[XAQueryFieldAttribute("OrdDt", "주문일", "char", "8")]
		public string OrdDt;
		/// <summary>
		/// 현금증거금액
		/// </summary>
		[XAQueryFieldAttribute("MnyMgn", "현금증거금액", "long", "16")]
		public long MnyMgn;
		/// <summary>
		/// 대용증거금액
		/// </summary>
		[XAQueryFieldAttribute("SubstMgn", "대용증거금액", "long", "16")]
		public long SubstMgn;
		/// <summary>
		/// 대용금액
		/// </summary>
		[XAQueryFieldAttribute("SubstAmt", "대용금액", "long", "16")]
		public long SubstAmt;
		/// <summary>
		/// 전일매수체결금액
		/// </summary>
		[XAQueryFieldAttribute("PrdayBuyExecAmt", "전일매수체결금액", "long", "16")]
		public long PrdayBuyExecAmt;
		/// <summary>
		/// 전일매도체결금액
		/// </summary>
		[XAQueryFieldAttribute("PrdaySellExecAmt", "전일매도체결금액", "long", "16")]
		public long PrdaySellExecAmt;
		/// <summary>
		/// 금일매수체결금액
		/// </summary>
		[XAQueryFieldAttribute("CrdayBuyExecAmt", "금일매수체결금액", "long", "16")]
		public long CrdayBuyExecAmt;
		/// <summary>
		/// 금일매도체결금액
		/// </summary>
		[XAQueryFieldAttribute("CrdaySellExecAmt", "금일매도체결금액", "long", "16")]
		public long CrdaySellExecAmt;
		/// <summary>
		/// 평가손익합계
		/// </summary>
		[XAQueryFieldAttribute("EvalPnlSum", "평가손익합계", "long", "15")]
		public long EvalPnlSum;
		/// <summary>
		/// 예탁자산총액
		/// </summary>
		[XAQueryFieldAttribute("DpsastTotamt", "예탁자산총액", "long", "16")]
		public long DpsastTotamt;
		/// <summary>
		/// 제비용
		/// </summary>
		[XAQueryFieldAttribute("Evrprc", "제비용", "long", "19")]
		public long Evrprc;
		/// <summary>
		/// 재사용금액
		/// </summary>
		[XAQueryFieldAttribute("RuseAmt", "재사용금액", "long", "16")]
		public long RuseAmt;
		/// <summary>
		/// 기타대여금액
		/// </summary>
		[XAQueryFieldAttribute("EtclndAmt", "기타대여금액", "long", "16")]
		public long EtclndAmt;
		/// <summary>
		/// 가정산금액
		/// </summary>
		[XAQueryFieldAttribute("PrcAdjstAmt", "가정산금액", "long", "16")]
		public long PrcAdjstAmt;
		/// <summary>
		/// D1수수료
		/// </summary>
		[XAQueryFieldAttribute("D1CmsnAmt", "D1수수료", "long", "16")]
		public long D1CmsnAmt;
		/// <summary>
		/// D2수수료
		/// </summary>
		[XAQueryFieldAttribute("D2CmsnAmt", "D2수수료", "long", "16")]
		public long D2CmsnAmt;
		/// <summary>
		/// D1제세금
		/// </summary>
		[XAQueryFieldAttribute("D1EvrTax", "D1제세금", "long", "16")]
		public long D1EvrTax;
		/// <summary>
		/// D2제세금
		/// </summary>
		[XAQueryFieldAttribute("D2EvrTax", "D2제세금", "long", "16")]
		public long D2EvrTax;
		/// <summary>
		/// D1결제예정금액
		/// </summary>
		[XAQueryFieldAttribute("D1SettPrergAmt", "D1결제예정금액", "long", "16")]
		public long D1SettPrergAmt;
		/// <summary>
		/// D2결제예정금액
		/// </summary>
		[XAQueryFieldAttribute("D2SettPrergAmt", "D2결제예정금액", "long", "16")]
		public long D2SettPrergAmt;
		/// <summary>
		/// 전일KSE현금증거금
		/// </summary>
		[XAQueryFieldAttribute("PrdayKseMnyMgn", "전일KSE현금증거금", "long", "16")]
		public long PrdayKseMnyMgn;
		/// <summary>
		/// 전일KSE대용증거금
		/// </summary>
		[XAQueryFieldAttribute("PrdayKseSubstMgn", "전일KSE대용증거금", "long", "16")]
		public long PrdayKseSubstMgn;
		/// <summary>
		/// 전일KSE신용현금증거금
		/// </summary>
		[XAQueryFieldAttribute("PrdayKseCrdtMnyMgn", "전일KSE신용현금증거금", "long", "16")]
		public long PrdayKseCrdtMnyMgn;
		/// <summary>
		/// 전일KSE신용대용증거금
		/// </summary>
		[XAQueryFieldAttribute("PrdayKseCrdtSubstMgn", "전일KSE신용대용증거금", "long", "16")]
		public long PrdayKseCrdtSubstMgn;
		/// <summary>
		/// 금일KSE현금증거금
		/// </summary>
		[XAQueryFieldAttribute("CrdayKseMnyMgn", "금일KSE현금증거금", "long", "16")]
		public long CrdayKseMnyMgn;
		/// <summary>
		/// 금일KSE대용증거금
		/// </summary>
		[XAQueryFieldAttribute("CrdayKseSubstMgn", "금일KSE대용증거금", "long", "16")]
		public long CrdayKseSubstMgn;
		/// <summary>
		/// 금일KSE신용현금증거금
		/// </summary>
		[XAQueryFieldAttribute("CrdayKseCrdtMnyMgn", "금일KSE신용현금증거금", "long", "16")]
		public long CrdayKseCrdtMnyMgn;
		/// <summary>
		/// 금일KSE신용대용증거금
		/// </summary>
		[XAQueryFieldAttribute("CrdayKseCrdtSubstMgn", "금일KSE신용대용증거금", "long", "16")]
		public long CrdayKseCrdtSubstMgn;
		/// <summary>
		/// 전일코스닥현금증거금
		/// </summary>
		[XAQueryFieldAttribute("PrdayKdqMnyMgn", "전일코스닥현금증거금", "long", "16")]
		public long PrdayKdqMnyMgn;
		/// <summary>
		/// 전일코스닥대용증거금
		/// </summary>
		[XAQueryFieldAttribute("PrdayKdqSubstMgn", "전일코스닥대용증거금", "long", "16")]
		public long PrdayKdqSubstMgn;
		/// <summary>
		/// 전일코스닥신용현금증거금
		/// </summary>
		[XAQueryFieldAttribute("PrdayKdqCrdtMnyMgn", "전일코스닥신용현금증거금", "long", "16")]
		public long PrdayKdqCrdtMnyMgn;
		/// <summary>
		/// 전일코스닥신용대용증거금
		/// </summary>
		[XAQueryFieldAttribute("PrdayKdqCrdtSubstMgn", "전일코스닥신용대용증거금", "long", "16")]
		public long PrdayKdqCrdtSubstMgn;
		/// <summary>
		/// 금일코스닥현금증거금
		/// </summary>
		[XAQueryFieldAttribute("CrdayKdqMnyMgn", "금일코스닥현금증거금", "long", "16")]
		public long CrdayKdqMnyMgn;
		/// <summary>
		/// 금일코스닥대용증거금
		/// </summary>
		[XAQueryFieldAttribute("CrdayKdqSubstMgn", "금일코스닥대용증거금", "long", "16")]
		public long CrdayKdqSubstMgn;
		/// <summary>
		/// 금일코스닥신용현금증거금
		/// </summary>
		[XAQueryFieldAttribute("CrdayKdqCrdtMnyMgn", "금일코스닥신용현금증거금", "long", "16")]
		public long CrdayKdqCrdtMnyMgn;
		/// <summary>
		/// 금일코스닥신용대용증거금
		/// </summary>
		[XAQueryFieldAttribute("CrdayKdqCrdtSubstMgn", "금일코스닥신용대용증거금", "long", "16")]
		public long CrdayKdqCrdtSubstMgn;
		/// <summary>
		/// 전일프리보드현금증거금
		/// </summary>
		[XAQueryFieldAttribute("PrdayFrbrdMnyMgn", "전일프리보드현금증거금", "long", "16")]
		public long PrdayFrbrdMnyMgn;
		/// <summary>
		/// 전일프리보드대용증거금
		/// </summary>
		[XAQueryFieldAttribute("PrdayFrbrdSubstMgn", "전일프리보드대용증거금", "long", "16")]
		public long PrdayFrbrdSubstMgn;
		/// <summary>
		/// 금일프리보드현금증거금
		/// </summary>
		[XAQueryFieldAttribute("CrdayFrbrdMnyMgn", "금일프리보드현금증거금", "long", "16")]
		public long CrdayFrbrdMnyMgn;
		/// <summary>
		/// 금일프리보드대용증거금
		/// </summary>
		[XAQueryFieldAttribute("CrdayFrbrdSubstMgn", "금일프리보드대용증거금", "long", "16")]
		public long CrdayFrbrdSubstMgn;
		/// <summary>
		/// 전일장외현금증거금
		/// </summary>
		[XAQueryFieldAttribute("PrdayCrbmkMnyMgn", "전일장외현금증거금", "long", "16")]
		public long PrdayCrbmkMnyMgn;
		/// <summary>
		/// 전일장외대용증거금
		/// </summary>
		[XAQueryFieldAttribute("PrdayCrbmkSubstMgn", "전일장외대용증거금", "long", "16")]
		public long PrdayCrbmkSubstMgn;
		/// <summary>
		/// 금일장외현금증거금
		/// </summary>
		[XAQueryFieldAttribute("CrdayCrbmkMnyMgn", "금일장외현금증거금", "long", "16")]
		public long CrdayCrbmkMnyMgn;
		/// <summary>
		/// 금일장외대용증거금
		/// </summary>
		[XAQueryFieldAttribute("CrdayCrbmkSubstMgn", "금일장외대용증거금", "long", "16")]
		public long CrdayCrbmkSubstMgn;
		/// <summary>
		/// 예탁담보수량
		/// </summary>
		[XAQueryFieldAttribute("DpspdgQty", "예탁담보수량", "long", "16")]
		public long DpspdgQty;
		/// <summary>
		/// 매수정산금(D+2)
		/// </summary>
		[XAQueryFieldAttribute("BuyAdjstAmtD2", "매수정산금(D+2)", "long", "16")]
		public long BuyAdjstAmtD2;
		/// <summary>
		/// 매도정산금(D+2)
		/// </summary>
		[XAQueryFieldAttribute("SellAdjstAmtD2", "매도정산금(D+2)", "long", "16")]
		public long SellAdjstAmtD2;
		/// <summary>
		/// 변제소요금(D+1)
		/// </summary>
		[XAQueryFieldAttribute("RepayRqrdAmtD1", "변제소요금(D+1)", "long", "16")]
		public long RepayRqrdAmtD1;
		/// <summary>
		/// 변제소요금(D+2)
		/// </summary>
		[XAQueryFieldAttribute("RepayRqrdAmtD2", "변제소요금(D+2)", "long", "16")]
		public long RepayRqrdAmtD2;
		/// <summary>
		/// 대출금액
		/// </summary>
		[XAQueryFieldAttribute("LoanAmt", "대출금액", "long", "16")]
		public long LoanAmt;

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
			/// HTS주문가능금액
			/// </summary>
			public const string HtsOrdAbleAmt = "HtsOrdAbleAmt";
			/// <summary>
			/// 증거금률100퍼센트주문가능금액
			/// </summary>
			public const string MgnRat100pctOrdAbleAmt = "MgnRat100pctOrdAbleAmt";
			/// <summary>
			/// 잔고평가금액
			/// </summary>
			public const string BalEvalAmt = "BalEvalAmt";
			/// <summary>
			/// 매입금액
			/// </summary>
			public const string PchsAmt = "PchsAmt";
			/// <summary>
			/// 미수금액
			/// </summary>
			public const string RcvblAmt = "RcvblAmt";
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
			/// D1예수금
			/// </summary>
			public const string D1Dps = "D1Dps";
			/// <summary>
			/// D2예수금
			/// </summary>
			public const string D2Dps = "D2Dps";
			/// <summary>
			/// 주문일
			/// </summary>
			public const string OrdDt = "OrdDt";
			/// <summary>
			/// 현금증거금액
			/// </summary>
			public const string MnyMgn = "MnyMgn";
			/// <summary>
			/// 대용증거금액
			/// </summary>
			public const string SubstMgn = "SubstMgn";
			/// <summary>
			/// 대용금액
			/// </summary>
			public const string SubstAmt = "SubstAmt";
			/// <summary>
			/// 전일매수체결금액
			/// </summary>
			public const string PrdayBuyExecAmt = "PrdayBuyExecAmt";
			/// <summary>
			/// 전일매도체결금액
			/// </summary>
			public const string PrdaySellExecAmt = "PrdaySellExecAmt";
			/// <summary>
			/// 금일매수체결금액
			/// </summary>
			public const string CrdayBuyExecAmt = "CrdayBuyExecAmt";
			/// <summary>
			/// 금일매도체결금액
			/// </summary>
			public const string CrdaySellExecAmt = "CrdaySellExecAmt";
			/// <summary>
			/// 평가손익합계
			/// </summary>
			public const string EvalPnlSum = "EvalPnlSum";
			/// <summary>
			/// 예탁자산총액
			/// </summary>
			public const string DpsastTotamt = "DpsastTotamt";
			/// <summary>
			/// 제비용
			/// </summary>
			public const string Evrprc = "Evrprc";
			/// <summary>
			/// 재사용금액
			/// </summary>
			public const string RuseAmt = "RuseAmt";
			/// <summary>
			/// 기타대여금액
			/// </summary>
			public const string EtclndAmt = "EtclndAmt";
			/// <summary>
			/// 가정산금액
			/// </summary>
			public const string PrcAdjstAmt = "PrcAdjstAmt";
			/// <summary>
			/// D1수수료
			/// </summary>
			public const string D1CmsnAmt = "D1CmsnAmt";
			/// <summary>
			/// D2수수료
			/// </summary>
			public const string D2CmsnAmt = "D2CmsnAmt";
			/// <summary>
			/// D1제세금
			/// </summary>
			public const string D1EvrTax = "D1EvrTax";
			/// <summary>
			/// D2제세금
			/// </summary>
			public const string D2EvrTax = "D2EvrTax";
			/// <summary>
			/// D1결제예정금액
			/// </summary>
			public const string D1SettPrergAmt = "D1SettPrergAmt";
			/// <summary>
			/// D2결제예정금액
			/// </summary>
			public const string D2SettPrergAmt = "D2SettPrergAmt";
			/// <summary>
			/// 전일KSE현금증거금
			/// </summary>
			public const string PrdayKseMnyMgn = "PrdayKseMnyMgn";
			/// <summary>
			/// 전일KSE대용증거금
			/// </summary>
			public const string PrdayKseSubstMgn = "PrdayKseSubstMgn";
			/// <summary>
			/// 전일KSE신용현금증거금
			/// </summary>
			public const string PrdayKseCrdtMnyMgn = "PrdayKseCrdtMnyMgn";
			/// <summary>
			/// 전일KSE신용대용증거금
			/// </summary>
			public const string PrdayKseCrdtSubstMgn = "PrdayKseCrdtSubstMgn";
			/// <summary>
			/// 금일KSE현금증거금
			/// </summary>
			public const string CrdayKseMnyMgn = "CrdayKseMnyMgn";
			/// <summary>
			/// 금일KSE대용증거금
			/// </summary>
			public const string CrdayKseSubstMgn = "CrdayKseSubstMgn";
			/// <summary>
			/// 금일KSE신용현금증거금
			/// </summary>
			public const string CrdayKseCrdtMnyMgn = "CrdayKseCrdtMnyMgn";
			/// <summary>
			/// 금일KSE신용대용증거금
			/// </summary>
			public const string CrdayKseCrdtSubstMgn = "CrdayKseCrdtSubstMgn";
			/// <summary>
			/// 전일코스닥현금증거금
			/// </summary>
			public const string PrdayKdqMnyMgn = "PrdayKdqMnyMgn";
			/// <summary>
			/// 전일코스닥대용증거금
			/// </summary>
			public const string PrdayKdqSubstMgn = "PrdayKdqSubstMgn";
			/// <summary>
			/// 전일코스닥신용현금증거금
			/// </summary>
			public const string PrdayKdqCrdtMnyMgn = "PrdayKdqCrdtMnyMgn";
			/// <summary>
			/// 전일코스닥신용대용증거금
			/// </summary>
			public const string PrdayKdqCrdtSubstMgn = "PrdayKdqCrdtSubstMgn";
			/// <summary>
			/// 금일코스닥현금증거금
			/// </summary>
			public const string CrdayKdqMnyMgn = "CrdayKdqMnyMgn";
			/// <summary>
			/// 금일코스닥대용증거금
			/// </summary>
			public const string CrdayKdqSubstMgn = "CrdayKdqSubstMgn";
			/// <summary>
			/// 금일코스닥신용현금증거금
			/// </summary>
			public const string CrdayKdqCrdtMnyMgn = "CrdayKdqCrdtMnyMgn";
			/// <summary>
			/// 금일코스닥신용대용증거금
			/// </summary>
			public const string CrdayKdqCrdtSubstMgn = "CrdayKdqCrdtSubstMgn";
			/// <summary>
			/// 전일프리보드현금증거금
			/// </summary>
			public const string PrdayFrbrdMnyMgn = "PrdayFrbrdMnyMgn";
			/// <summary>
			/// 전일프리보드대용증거금
			/// </summary>
			public const string PrdayFrbrdSubstMgn = "PrdayFrbrdSubstMgn";
			/// <summary>
			/// 금일프리보드현금증거금
			/// </summary>
			public const string CrdayFrbrdMnyMgn = "CrdayFrbrdMnyMgn";
			/// <summary>
			/// 금일프리보드대용증거금
			/// </summary>
			public const string CrdayFrbrdSubstMgn = "CrdayFrbrdSubstMgn";
			/// <summary>
			/// 전일장외현금증거금
			/// </summary>
			public const string PrdayCrbmkMnyMgn = "PrdayCrbmkMnyMgn";
			/// <summary>
			/// 전일장외대용증거금
			/// </summary>
			public const string PrdayCrbmkSubstMgn = "PrdayCrbmkSubstMgn";
			/// <summary>
			/// 금일장외현금증거금
			/// </summary>
			public const string CrdayCrbmkMnyMgn = "CrdayCrbmkMnyMgn";
			/// <summary>
			/// 금일장외대용증거금
			/// </summary>
			public const string CrdayCrbmkSubstMgn = "CrdayCrbmkSubstMgn";
			/// <summary>
			/// 예탁담보수량
			/// </summary>
			public const string DpspdgQty = "DpspdgQty";
			/// <summary>
			/// 매수정산금(D+2)
			/// </summary>
			public const string BuyAdjstAmtD2 = "BuyAdjstAmtD2";
			/// <summary>
			/// 매도정산금(D+2)
			/// </summary>
			public const string SellAdjstAmtD2 = "SellAdjstAmtD2";
			/// <summary>
			/// 변제소요금(D+1)
			/// </summary>
			public const string RepayRqrdAmtD1 = "RepayRqrdAmtD1";
			/// <summary>
			/// 변제소요금(D+2)
			/// </summary>
			public const string RepayRqrdAmtD2 = "RepayRqrdAmtD2";
			/// <summary>
			/// 대출금액
			/// </summary>
			public const string LoanAmt = "LoanAmt";
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
			F.HtsOrdAbleAmt,
			F.MgnRat100pctOrdAbleAmt,
			F.BalEvalAmt,
			F.PchsAmt,
			F.RcvblAmt,
			F.PnlRat,
			F.InvstOrgAmt,
			F.InvstPlAmt,
			F.CrdtPldgOrdAmt,
			F.Dps,
			F.D1Dps,
			F.D2Dps,
			F.OrdDt,
			F.MnyMgn,
			F.SubstMgn,
			F.SubstAmt,
			F.PrdayBuyExecAmt,
			F.PrdaySellExecAmt,
			F.CrdayBuyExecAmt,
			F.CrdaySellExecAmt,
			F.EvalPnlSum,
			F.DpsastTotamt,
			F.Evrprc,
			F.RuseAmt,
			F.EtclndAmt,
			F.PrcAdjstAmt,
			F.D1CmsnAmt,
			F.D2CmsnAmt,
			F.D1EvrTax,
			F.D2EvrTax,
			F.D1SettPrergAmt,
			F.D2SettPrergAmt,
			F.PrdayKseMnyMgn,
			F.PrdayKseSubstMgn,
			F.PrdayKseCrdtMnyMgn,
			F.PrdayKseCrdtSubstMgn,
			F.CrdayKseMnyMgn,
			F.CrdayKseSubstMgn,
			F.CrdayKseCrdtMnyMgn,
			F.CrdayKseCrdtSubstMgn,
			F.PrdayKdqMnyMgn,
			F.PrdayKdqSubstMgn,
			F.PrdayKdqCrdtMnyMgn,
			F.PrdayKdqCrdtSubstMgn,
			F.CrdayKdqMnyMgn,
			F.CrdayKdqSubstMgn,
			F.CrdayKdqCrdtMnyMgn,
			F.CrdayKdqCrdtSubstMgn,
			F.PrdayFrbrdMnyMgn,
			F.PrdayFrbrdSubstMgn,
			F.CrdayFrbrdMnyMgn,
			F.CrdayFrbrdSubstMgn,
			F.PrdayCrbmkMnyMgn,
			F.PrdayCrbmkSubstMgn,
			F.CrdayCrbmkMnyMgn,
			F.CrdayCrbmkSubstMgn,
			F.DpspdgQty,
			F.BuyAdjstAmtD2,
			F.SellAdjstAmtD2,
			F.RepayRqrdAmtD1,
			F.RepayRqrdAmtD2,
			F.LoanAmt,
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
			dict["HtsOrdAbleAmt"] = new XAQueryFieldInfo("long", HtsOrdAbleAmt, HtsOrdAbleAmt.ToString("d16"), "HTS주문가능금액", (decimal)16);
			dict["MgnRat100pctOrdAbleAmt"] = new XAQueryFieldInfo("long", MgnRat100pctOrdAbleAmt, MgnRat100pctOrdAbleAmt.ToString("d16"), "증거금률100퍼센트주문가능금액", (decimal)16);
			dict["BalEvalAmt"] = new XAQueryFieldInfo("long", BalEvalAmt, BalEvalAmt.ToString("d16"), "잔고평가금액", (decimal)16);
			dict["PchsAmt"] = new XAQueryFieldInfo("long", PchsAmt, PchsAmt.ToString("d16"), "매입금액", (decimal)16);
			dict["RcvblAmt"] = new XAQueryFieldInfo("long", RcvblAmt, RcvblAmt.ToString("d16"), "미수금액", (decimal)16);
			dict["PnlRat"] = new XAQueryFieldInfo("double", PnlRat, PnlRat.ToString("000000000000000000.000000"), "손익율", (decimal)18.6);
			dict["InvstOrgAmt"] = new XAQueryFieldInfo("long", InvstOrgAmt, InvstOrgAmt.ToString("d20"), "투자원금", (decimal)20);
			dict["InvstPlAmt"] = new XAQueryFieldInfo("long", InvstPlAmt, InvstPlAmt.ToString("d16"), "투자손익금액", (decimal)16);
			dict["CrdtPldgOrdAmt"] = new XAQueryFieldInfo("long", CrdtPldgOrdAmt, CrdtPldgOrdAmt.ToString("d16"), "신용담보주문금액", (decimal)16);
			dict["Dps"] = new XAQueryFieldInfo("long", Dps, Dps.ToString("d16"), "예수금", (decimal)16);
			dict["D1Dps"] = new XAQueryFieldInfo("long", D1Dps, D1Dps.ToString("d16"), "D1예수금", (decimal)16);
			dict["D2Dps"] = new XAQueryFieldInfo("long", D2Dps, D2Dps.ToString("d16"), "D2예수금", (decimal)16);
			dict["OrdDt"] = new XAQueryFieldInfo("char", OrdDt, OrdDt, "주문일", (decimal)8);
			dict["MnyMgn"] = new XAQueryFieldInfo("long", MnyMgn, MnyMgn.ToString("d16"), "현금증거금액", (decimal)16);
			dict["SubstMgn"] = new XAQueryFieldInfo("long", SubstMgn, SubstMgn.ToString("d16"), "대용증거금액", (decimal)16);
			dict["SubstAmt"] = new XAQueryFieldInfo("long", SubstAmt, SubstAmt.ToString("d16"), "대용금액", (decimal)16);
			dict["PrdayBuyExecAmt"] = new XAQueryFieldInfo("long", PrdayBuyExecAmt, PrdayBuyExecAmt.ToString("d16"), "전일매수체결금액", (decimal)16);
			dict["PrdaySellExecAmt"] = new XAQueryFieldInfo("long", PrdaySellExecAmt, PrdaySellExecAmt.ToString("d16"), "전일매도체결금액", (decimal)16);
			dict["CrdayBuyExecAmt"] = new XAQueryFieldInfo("long", CrdayBuyExecAmt, CrdayBuyExecAmt.ToString("d16"), "금일매수체결금액", (decimal)16);
			dict["CrdaySellExecAmt"] = new XAQueryFieldInfo("long", CrdaySellExecAmt, CrdaySellExecAmt.ToString("d16"), "금일매도체결금액", (decimal)16);
			dict["EvalPnlSum"] = new XAQueryFieldInfo("long", EvalPnlSum, EvalPnlSum.ToString("d15"), "평가손익합계", (decimal)15);
			dict["DpsastTotamt"] = new XAQueryFieldInfo("long", DpsastTotamt, DpsastTotamt.ToString("d16"), "예탁자산총액", (decimal)16);
			dict["Evrprc"] = new XAQueryFieldInfo("long", Evrprc, Evrprc.ToString("d19"), "제비용", (decimal)19);
			dict["RuseAmt"] = new XAQueryFieldInfo("long", RuseAmt, RuseAmt.ToString("d16"), "재사용금액", (decimal)16);
			dict["EtclndAmt"] = new XAQueryFieldInfo("long", EtclndAmt, EtclndAmt.ToString("d16"), "기타대여금액", (decimal)16);
			dict["PrcAdjstAmt"] = new XAQueryFieldInfo("long", PrcAdjstAmt, PrcAdjstAmt.ToString("d16"), "가정산금액", (decimal)16);
			dict["D1CmsnAmt"] = new XAQueryFieldInfo("long", D1CmsnAmt, D1CmsnAmt.ToString("d16"), "D1수수료", (decimal)16);
			dict["D2CmsnAmt"] = new XAQueryFieldInfo("long", D2CmsnAmt, D2CmsnAmt.ToString("d16"), "D2수수료", (decimal)16);
			dict["D1EvrTax"] = new XAQueryFieldInfo("long", D1EvrTax, D1EvrTax.ToString("d16"), "D1제세금", (decimal)16);
			dict["D2EvrTax"] = new XAQueryFieldInfo("long", D2EvrTax, D2EvrTax.ToString("d16"), "D2제세금", (decimal)16);
			dict["D1SettPrergAmt"] = new XAQueryFieldInfo("long", D1SettPrergAmt, D1SettPrergAmt.ToString("d16"), "D1결제예정금액", (decimal)16);
			dict["D2SettPrergAmt"] = new XAQueryFieldInfo("long", D2SettPrergAmt, D2SettPrergAmt.ToString("d16"), "D2결제예정금액", (decimal)16);
			dict["PrdayKseMnyMgn"] = new XAQueryFieldInfo("long", PrdayKseMnyMgn, PrdayKseMnyMgn.ToString("d16"), "전일KSE현금증거금", (decimal)16);
			dict["PrdayKseSubstMgn"] = new XAQueryFieldInfo("long", PrdayKseSubstMgn, PrdayKseSubstMgn.ToString("d16"), "전일KSE대용증거금", (decimal)16);
			dict["PrdayKseCrdtMnyMgn"] = new XAQueryFieldInfo("long", PrdayKseCrdtMnyMgn, PrdayKseCrdtMnyMgn.ToString("d16"), "전일KSE신용현금증거금", (decimal)16);
			dict["PrdayKseCrdtSubstMgn"] = new XAQueryFieldInfo("long", PrdayKseCrdtSubstMgn, PrdayKseCrdtSubstMgn.ToString("d16"), "전일KSE신용대용증거금", (decimal)16);
			dict["CrdayKseMnyMgn"] = new XAQueryFieldInfo("long", CrdayKseMnyMgn, CrdayKseMnyMgn.ToString("d16"), "금일KSE현금증거금", (decimal)16);
			dict["CrdayKseSubstMgn"] = new XAQueryFieldInfo("long", CrdayKseSubstMgn, CrdayKseSubstMgn.ToString("d16"), "금일KSE대용증거금", (decimal)16);
			dict["CrdayKseCrdtMnyMgn"] = new XAQueryFieldInfo("long", CrdayKseCrdtMnyMgn, CrdayKseCrdtMnyMgn.ToString("d16"), "금일KSE신용현금증거금", (decimal)16);
			dict["CrdayKseCrdtSubstMgn"] = new XAQueryFieldInfo("long", CrdayKseCrdtSubstMgn, CrdayKseCrdtSubstMgn.ToString("d16"), "금일KSE신용대용증거금", (decimal)16);
			dict["PrdayKdqMnyMgn"] = new XAQueryFieldInfo("long", PrdayKdqMnyMgn, PrdayKdqMnyMgn.ToString("d16"), "전일코스닥현금증거금", (decimal)16);
			dict["PrdayKdqSubstMgn"] = new XAQueryFieldInfo("long", PrdayKdqSubstMgn, PrdayKdqSubstMgn.ToString("d16"), "전일코스닥대용증거금", (decimal)16);
			dict["PrdayKdqCrdtMnyMgn"] = new XAQueryFieldInfo("long", PrdayKdqCrdtMnyMgn, PrdayKdqCrdtMnyMgn.ToString("d16"), "전일코스닥신용현금증거금", (decimal)16);
			dict["PrdayKdqCrdtSubstMgn"] = new XAQueryFieldInfo("long", PrdayKdqCrdtSubstMgn, PrdayKdqCrdtSubstMgn.ToString("d16"), "전일코스닥신용대용증거금", (decimal)16);
			dict["CrdayKdqMnyMgn"] = new XAQueryFieldInfo("long", CrdayKdqMnyMgn, CrdayKdqMnyMgn.ToString("d16"), "금일코스닥현금증거금", (decimal)16);
			dict["CrdayKdqSubstMgn"] = new XAQueryFieldInfo("long", CrdayKdqSubstMgn, CrdayKdqSubstMgn.ToString("d16"), "금일코스닥대용증거금", (decimal)16);
			dict["CrdayKdqCrdtMnyMgn"] = new XAQueryFieldInfo("long", CrdayKdqCrdtMnyMgn, CrdayKdqCrdtMnyMgn.ToString("d16"), "금일코스닥신용현금증거금", (decimal)16);
			dict["CrdayKdqCrdtSubstMgn"] = new XAQueryFieldInfo("long", CrdayKdqCrdtSubstMgn, CrdayKdqCrdtSubstMgn.ToString("d16"), "금일코스닥신용대용증거금", (decimal)16);
			dict["PrdayFrbrdMnyMgn"] = new XAQueryFieldInfo("long", PrdayFrbrdMnyMgn, PrdayFrbrdMnyMgn.ToString("d16"), "전일프리보드현금증거금", (decimal)16);
			dict["PrdayFrbrdSubstMgn"] = new XAQueryFieldInfo("long", PrdayFrbrdSubstMgn, PrdayFrbrdSubstMgn.ToString("d16"), "전일프리보드대용증거금", (decimal)16);
			dict["CrdayFrbrdMnyMgn"] = new XAQueryFieldInfo("long", CrdayFrbrdMnyMgn, CrdayFrbrdMnyMgn.ToString("d16"), "금일프리보드현금증거금", (decimal)16);
			dict["CrdayFrbrdSubstMgn"] = new XAQueryFieldInfo("long", CrdayFrbrdSubstMgn, CrdayFrbrdSubstMgn.ToString("d16"), "금일프리보드대용증거금", (decimal)16);
			dict["PrdayCrbmkMnyMgn"] = new XAQueryFieldInfo("long", PrdayCrbmkMnyMgn, PrdayCrbmkMnyMgn.ToString("d16"), "전일장외현금증거금", (decimal)16);
			dict["PrdayCrbmkSubstMgn"] = new XAQueryFieldInfo("long", PrdayCrbmkSubstMgn, PrdayCrbmkSubstMgn.ToString("d16"), "전일장외대용증거금", (decimal)16);
			dict["CrdayCrbmkMnyMgn"] = new XAQueryFieldInfo("long", CrdayCrbmkMnyMgn, CrdayCrbmkMnyMgn.ToString("d16"), "금일장외현금증거금", (decimal)16);
			dict["CrdayCrbmkSubstMgn"] = new XAQueryFieldInfo("long", CrdayCrbmkSubstMgn, CrdayCrbmkSubstMgn.ToString("d16"), "금일장외대용증거금", (decimal)16);
			dict["DpspdgQty"] = new XAQueryFieldInfo("long", DpspdgQty, DpspdgQty.ToString("d16"), "예탁담보수량", (decimal)16);
			dict["BuyAdjstAmtD2"] = new XAQueryFieldInfo("long", BuyAdjstAmtD2, BuyAdjstAmtD2.ToString("d16"), "매수정산금(D+2)", (decimal)16);
			dict["SellAdjstAmtD2"] = new XAQueryFieldInfo("long", SellAdjstAmtD2, SellAdjstAmtD2.ToString("d16"), "매도정산금(D+2)", (decimal)16);
			dict["RepayRqrdAmtD1"] = new XAQueryFieldInfo("long", RepayRqrdAmtD1, RepayRqrdAmtD1.ToString("d16"), "변제소요금(D+1)", (decimal)16);
			dict["RepayRqrdAmtD2"] = new XAQueryFieldInfo("long", RepayRqrdAmtD2, RepayRqrdAmtD2.ToString("d16"), "변제소요금(D+2)", (decimal)16);
			dict["LoanAmt"] = new XAQueryFieldInfo("long", LoanAmt, LoanAmt.ToString("d16"), "대출금액", (decimal)16);

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

				case "HtsOrdAbleAmt":
					this.HtsOrdAbleAmt = fieldInfo.FieldValue.ParseLong("HtsOrdAbleAmt");
				break;

				case "MgnRat100pctOrdAbleAmt":
					this.MgnRat100pctOrdAbleAmt = fieldInfo.FieldValue.ParseLong("MgnRat100pctOrdAbleAmt");
				break;

				case "BalEvalAmt":
					this.BalEvalAmt = fieldInfo.FieldValue.ParseLong("BalEvalAmt");
				break;

				case "PchsAmt":
					this.PchsAmt = fieldInfo.FieldValue.ParseLong("PchsAmt");
				break;

				case "RcvblAmt":
					this.RcvblAmt = fieldInfo.FieldValue.ParseLong("RcvblAmt");
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

				case "D1Dps":
					this.D1Dps = fieldInfo.FieldValue.ParseLong("D1Dps");
				break;

				case "D2Dps":
					this.D2Dps = fieldInfo.FieldValue.ParseLong("D2Dps");
				break;

				case "OrdDt":
					this.OrdDt = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "MnyMgn":
					this.MnyMgn = fieldInfo.FieldValue.ParseLong("MnyMgn");
				break;

				case "SubstMgn":
					this.SubstMgn = fieldInfo.FieldValue.ParseLong("SubstMgn");
				break;

				case "SubstAmt":
					this.SubstAmt = fieldInfo.FieldValue.ParseLong("SubstAmt");
				break;

				case "PrdayBuyExecAmt":
					this.PrdayBuyExecAmt = fieldInfo.FieldValue.ParseLong("PrdayBuyExecAmt");
				break;

				case "PrdaySellExecAmt":
					this.PrdaySellExecAmt = fieldInfo.FieldValue.ParseLong("PrdaySellExecAmt");
				break;

				case "CrdayBuyExecAmt":
					this.CrdayBuyExecAmt = fieldInfo.FieldValue.ParseLong("CrdayBuyExecAmt");
				break;

				case "CrdaySellExecAmt":
					this.CrdaySellExecAmt = fieldInfo.FieldValue.ParseLong("CrdaySellExecAmt");
				break;

				case "EvalPnlSum":
					this.EvalPnlSum = fieldInfo.FieldValue.ParseLong("EvalPnlSum");
				break;

				case "DpsastTotamt":
					this.DpsastTotamt = fieldInfo.FieldValue.ParseLong("DpsastTotamt");
				break;

				case "Evrprc":
					this.Evrprc = fieldInfo.FieldValue.ParseLong("Evrprc");
				break;

				case "RuseAmt":
					this.RuseAmt = fieldInfo.FieldValue.ParseLong("RuseAmt");
				break;

				case "EtclndAmt":
					this.EtclndAmt = fieldInfo.FieldValue.ParseLong("EtclndAmt");
				break;

				case "PrcAdjstAmt":
					this.PrcAdjstAmt = fieldInfo.FieldValue.ParseLong("PrcAdjstAmt");
				break;

				case "D1CmsnAmt":
					this.D1CmsnAmt = fieldInfo.FieldValue.ParseLong("D1CmsnAmt");
				break;

				case "D2CmsnAmt":
					this.D2CmsnAmt = fieldInfo.FieldValue.ParseLong("D2CmsnAmt");
				break;

				case "D1EvrTax":
					this.D1EvrTax = fieldInfo.FieldValue.ParseLong("D1EvrTax");
				break;

				case "D2EvrTax":
					this.D2EvrTax = fieldInfo.FieldValue.ParseLong("D2EvrTax");
				break;

				case "D1SettPrergAmt":
					this.D1SettPrergAmt = fieldInfo.FieldValue.ParseLong("D1SettPrergAmt");
				break;

				case "D2SettPrergAmt":
					this.D2SettPrergAmt = fieldInfo.FieldValue.ParseLong("D2SettPrergAmt");
				break;

				case "PrdayKseMnyMgn":
					this.PrdayKseMnyMgn = fieldInfo.FieldValue.ParseLong("PrdayKseMnyMgn");
				break;

				case "PrdayKseSubstMgn":
					this.PrdayKseSubstMgn = fieldInfo.FieldValue.ParseLong("PrdayKseSubstMgn");
				break;

				case "PrdayKseCrdtMnyMgn":
					this.PrdayKseCrdtMnyMgn = fieldInfo.FieldValue.ParseLong("PrdayKseCrdtMnyMgn");
				break;

				case "PrdayKseCrdtSubstMgn":
					this.PrdayKseCrdtSubstMgn = fieldInfo.FieldValue.ParseLong("PrdayKseCrdtSubstMgn");
				break;

				case "CrdayKseMnyMgn":
					this.CrdayKseMnyMgn = fieldInfo.FieldValue.ParseLong("CrdayKseMnyMgn");
				break;

				case "CrdayKseSubstMgn":
					this.CrdayKseSubstMgn = fieldInfo.FieldValue.ParseLong("CrdayKseSubstMgn");
				break;

				case "CrdayKseCrdtMnyMgn":
					this.CrdayKseCrdtMnyMgn = fieldInfo.FieldValue.ParseLong("CrdayKseCrdtMnyMgn");
				break;

				case "CrdayKseCrdtSubstMgn":
					this.CrdayKseCrdtSubstMgn = fieldInfo.FieldValue.ParseLong("CrdayKseCrdtSubstMgn");
				break;

				case "PrdayKdqMnyMgn":
					this.PrdayKdqMnyMgn = fieldInfo.FieldValue.ParseLong("PrdayKdqMnyMgn");
				break;

				case "PrdayKdqSubstMgn":
					this.PrdayKdqSubstMgn = fieldInfo.FieldValue.ParseLong("PrdayKdqSubstMgn");
				break;

				case "PrdayKdqCrdtMnyMgn":
					this.PrdayKdqCrdtMnyMgn = fieldInfo.FieldValue.ParseLong("PrdayKdqCrdtMnyMgn");
				break;

				case "PrdayKdqCrdtSubstMgn":
					this.PrdayKdqCrdtSubstMgn = fieldInfo.FieldValue.ParseLong("PrdayKdqCrdtSubstMgn");
				break;

				case "CrdayKdqMnyMgn":
					this.CrdayKdqMnyMgn = fieldInfo.FieldValue.ParseLong("CrdayKdqMnyMgn");
				break;

				case "CrdayKdqSubstMgn":
					this.CrdayKdqSubstMgn = fieldInfo.FieldValue.ParseLong("CrdayKdqSubstMgn");
				break;

				case "CrdayKdqCrdtMnyMgn":
					this.CrdayKdqCrdtMnyMgn = fieldInfo.FieldValue.ParseLong("CrdayKdqCrdtMnyMgn");
				break;

				case "CrdayKdqCrdtSubstMgn":
					this.CrdayKdqCrdtSubstMgn = fieldInfo.FieldValue.ParseLong("CrdayKdqCrdtSubstMgn");
				break;

				case "PrdayFrbrdMnyMgn":
					this.PrdayFrbrdMnyMgn = fieldInfo.FieldValue.ParseLong("PrdayFrbrdMnyMgn");
				break;

				case "PrdayFrbrdSubstMgn":
					this.PrdayFrbrdSubstMgn = fieldInfo.FieldValue.ParseLong("PrdayFrbrdSubstMgn");
				break;

				case "CrdayFrbrdMnyMgn":
					this.CrdayFrbrdMnyMgn = fieldInfo.FieldValue.ParseLong("CrdayFrbrdMnyMgn");
				break;

				case "CrdayFrbrdSubstMgn":
					this.CrdayFrbrdSubstMgn = fieldInfo.FieldValue.ParseLong("CrdayFrbrdSubstMgn");
				break;

				case "PrdayCrbmkMnyMgn":
					this.PrdayCrbmkMnyMgn = fieldInfo.FieldValue.ParseLong("PrdayCrbmkMnyMgn");
				break;

				case "PrdayCrbmkSubstMgn":
					this.PrdayCrbmkSubstMgn = fieldInfo.FieldValue.ParseLong("PrdayCrbmkSubstMgn");
				break;

				case "CrdayCrbmkMnyMgn":
					this.CrdayCrbmkMnyMgn = fieldInfo.FieldValue.ParseLong("CrdayCrbmkMnyMgn");
				break;

				case "CrdayCrbmkSubstMgn":
					this.CrdayCrbmkSubstMgn = fieldInfo.FieldValue.ParseLong("CrdayCrbmkSubstMgn");
				break;

				case "DpspdgQty":
					this.DpspdgQty = fieldInfo.FieldValue.ParseLong("DpspdgQty");
				break;

				case "BuyAdjstAmtD2":
					this.BuyAdjstAmtD2 = fieldInfo.FieldValue.ParseLong("BuyAdjstAmtD2");
				break;

				case "SellAdjstAmtD2":
					this.SellAdjstAmtD2 = fieldInfo.FieldValue.ParseLong("SellAdjstAmtD2");
				break;

				case "RepayRqrdAmtD1":
					this.RepayRqrdAmtD1 = fieldInfo.FieldValue.ParseLong("RepayRqrdAmtD1");
				break;

				case "RepayRqrdAmtD2":
					this.RepayRqrdAmtD2 = fieldInfo.FieldValue.ParseLong("RepayRqrdAmtD2");
				break;

				case "LoanAmt":
					this.LoanAmt = fieldInfo.FieldValue.ParseLong("LoanAmt");
				break;


			}
		}

		public static XQCSPAQ12300OutBlock2 FromQuery(XQCSPAQ12300 query)
		{
			XQCSPAQ12300OutBlock2 block = new XQCSPAQ12300OutBlock2();
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
				block.HtsOrdAbleAmt = query.GetFieldData(block.GetBlockName(), "HtsOrdAbleAmt", 0).ParseLong("HtsOrdAbleAmt"); // long 16
				block.MgnRat100pctOrdAbleAmt = query.GetFieldData(block.GetBlockName(), "MgnRat100pctOrdAbleAmt", 0).ParseLong("MgnRat100pctOrdAbleAmt"); // long 16
				block.BalEvalAmt = query.GetFieldData(block.GetBlockName(), "BalEvalAmt", 0).ParseLong("BalEvalAmt"); // long 16
				block.PchsAmt = query.GetFieldData(block.GetBlockName(), "PchsAmt", 0).ParseLong("PchsAmt"); // long 16
				block.RcvblAmt = query.GetFieldData(block.GetBlockName(), "RcvblAmt", 0).ParseLong("RcvblAmt"); // long 16
				block.PnlRat = query.GetFieldData(block.GetBlockName(), "PnlRat", 0).ParseDouble("PnlRat"); // double 18.6
				block.InvstOrgAmt = query.GetFieldData(block.GetBlockName(), "InvstOrgAmt", 0).ParseLong("InvstOrgAmt"); // long 20
				block.InvstPlAmt = query.GetFieldData(block.GetBlockName(), "InvstPlAmt", 0).ParseLong("InvstPlAmt"); // long 16
				block.CrdtPldgOrdAmt = query.GetFieldData(block.GetBlockName(), "CrdtPldgOrdAmt", 0).ParseLong("CrdtPldgOrdAmt"); // long 16
				block.Dps = query.GetFieldData(block.GetBlockName(), "Dps", 0).ParseLong("Dps"); // long 16
				block.D1Dps = query.GetFieldData(block.GetBlockName(), "D1Dps", 0).ParseLong("D1Dps"); // long 16
				block.D2Dps = query.GetFieldData(block.GetBlockName(), "D2Dps", 0).ParseLong("D2Dps"); // long 16
				block.OrdDt = query.GetFieldData(block.GetBlockName(), "OrdDt", 0).TrimEnd('?'); // char 8
				block.MnyMgn = query.GetFieldData(block.GetBlockName(), "MnyMgn", 0).ParseLong("MnyMgn"); // long 16
				block.SubstMgn = query.GetFieldData(block.GetBlockName(), "SubstMgn", 0).ParseLong("SubstMgn"); // long 16
				block.SubstAmt = query.GetFieldData(block.GetBlockName(), "SubstAmt", 0).ParseLong("SubstAmt"); // long 16
				block.PrdayBuyExecAmt = query.GetFieldData(block.GetBlockName(), "PrdayBuyExecAmt", 0).ParseLong("PrdayBuyExecAmt"); // long 16
				block.PrdaySellExecAmt = query.GetFieldData(block.GetBlockName(), "PrdaySellExecAmt", 0).ParseLong("PrdaySellExecAmt"); // long 16
				block.CrdayBuyExecAmt = query.GetFieldData(block.GetBlockName(), "CrdayBuyExecAmt", 0).ParseLong("CrdayBuyExecAmt"); // long 16
				block.CrdaySellExecAmt = query.GetFieldData(block.GetBlockName(), "CrdaySellExecAmt", 0).ParseLong("CrdaySellExecAmt"); // long 16
				block.EvalPnlSum = query.GetFieldData(block.GetBlockName(), "EvalPnlSum", 0).ParseLong("EvalPnlSum"); // long 15
				block.DpsastTotamt = query.GetFieldData(block.GetBlockName(), "DpsastTotamt", 0).ParseLong("DpsastTotamt"); // long 16
				block.Evrprc = query.GetFieldData(block.GetBlockName(), "Evrprc", 0).ParseLong("Evrprc"); // long 19
				block.RuseAmt = query.GetFieldData(block.GetBlockName(), "RuseAmt", 0).ParseLong("RuseAmt"); // long 16
				block.EtclndAmt = query.GetFieldData(block.GetBlockName(), "EtclndAmt", 0).ParseLong("EtclndAmt"); // long 16
				block.PrcAdjstAmt = query.GetFieldData(block.GetBlockName(), "PrcAdjstAmt", 0).ParseLong("PrcAdjstAmt"); // long 16
				block.D1CmsnAmt = query.GetFieldData(block.GetBlockName(), "D1CmsnAmt", 0).ParseLong("D1CmsnAmt"); // long 16
				block.D2CmsnAmt = query.GetFieldData(block.GetBlockName(), "D2CmsnAmt", 0).ParseLong("D2CmsnAmt"); // long 16
				block.D1EvrTax = query.GetFieldData(block.GetBlockName(), "D1EvrTax", 0).ParseLong("D1EvrTax"); // long 16
				block.D2EvrTax = query.GetFieldData(block.GetBlockName(), "D2EvrTax", 0).ParseLong("D2EvrTax"); // long 16
				block.D1SettPrergAmt = query.GetFieldData(block.GetBlockName(), "D1SettPrergAmt", 0).ParseLong("D1SettPrergAmt"); // long 16
				block.D2SettPrergAmt = query.GetFieldData(block.GetBlockName(), "D2SettPrergAmt", 0).ParseLong("D2SettPrergAmt"); // long 16
				block.PrdayKseMnyMgn = query.GetFieldData(block.GetBlockName(), "PrdayKseMnyMgn", 0).ParseLong("PrdayKseMnyMgn"); // long 16
				block.PrdayKseSubstMgn = query.GetFieldData(block.GetBlockName(), "PrdayKseSubstMgn", 0).ParseLong("PrdayKseSubstMgn"); // long 16
				block.PrdayKseCrdtMnyMgn = query.GetFieldData(block.GetBlockName(), "PrdayKseCrdtMnyMgn", 0).ParseLong("PrdayKseCrdtMnyMgn"); // long 16
				block.PrdayKseCrdtSubstMgn = query.GetFieldData(block.GetBlockName(), "PrdayKseCrdtSubstMgn", 0).ParseLong("PrdayKseCrdtSubstMgn"); // long 16
				block.CrdayKseMnyMgn = query.GetFieldData(block.GetBlockName(), "CrdayKseMnyMgn", 0).ParseLong("CrdayKseMnyMgn"); // long 16
				block.CrdayKseSubstMgn = query.GetFieldData(block.GetBlockName(), "CrdayKseSubstMgn", 0).ParseLong("CrdayKseSubstMgn"); // long 16
				block.CrdayKseCrdtMnyMgn = query.GetFieldData(block.GetBlockName(), "CrdayKseCrdtMnyMgn", 0).ParseLong("CrdayKseCrdtMnyMgn"); // long 16
				block.CrdayKseCrdtSubstMgn = query.GetFieldData(block.GetBlockName(), "CrdayKseCrdtSubstMgn", 0).ParseLong("CrdayKseCrdtSubstMgn"); // long 16
				block.PrdayKdqMnyMgn = query.GetFieldData(block.GetBlockName(), "PrdayKdqMnyMgn", 0).ParseLong("PrdayKdqMnyMgn"); // long 16
				block.PrdayKdqSubstMgn = query.GetFieldData(block.GetBlockName(), "PrdayKdqSubstMgn", 0).ParseLong("PrdayKdqSubstMgn"); // long 16
				block.PrdayKdqCrdtMnyMgn = query.GetFieldData(block.GetBlockName(), "PrdayKdqCrdtMnyMgn", 0).ParseLong("PrdayKdqCrdtMnyMgn"); // long 16
				block.PrdayKdqCrdtSubstMgn = query.GetFieldData(block.GetBlockName(), "PrdayKdqCrdtSubstMgn", 0).ParseLong("PrdayKdqCrdtSubstMgn"); // long 16
				block.CrdayKdqMnyMgn = query.GetFieldData(block.GetBlockName(), "CrdayKdqMnyMgn", 0).ParseLong("CrdayKdqMnyMgn"); // long 16
				block.CrdayKdqSubstMgn = query.GetFieldData(block.GetBlockName(), "CrdayKdqSubstMgn", 0).ParseLong("CrdayKdqSubstMgn"); // long 16
				block.CrdayKdqCrdtMnyMgn = query.GetFieldData(block.GetBlockName(), "CrdayKdqCrdtMnyMgn", 0).ParseLong("CrdayKdqCrdtMnyMgn"); // long 16
				block.CrdayKdqCrdtSubstMgn = query.GetFieldData(block.GetBlockName(), "CrdayKdqCrdtSubstMgn", 0).ParseLong("CrdayKdqCrdtSubstMgn"); // long 16
				block.PrdayFrbrdMnyMgn = query.GetFieldData(block.GetBlockName(), "PrdayFrbrdMnyMgn", 0).ParseLong("PrdayFrbrdMnyMgn"); // long 16
				block.PrdayFrbrdSubstMgn = query.GetFieldData(block.GetBlockName(), "PrdayFrbrdSubstMgn", 0).ParseLong("PrdayFrbrdSubstMgn"); // long 16
				block.CrdayFrbrdMnyMgn = query.GetFieldData(block.GetBlockName(), "CrdayFrbrdMnyMgn", 0).ParseLong("CrdayFrbrdMnyMgn"); // long 16
				block.CrdayFrbrdSubstMgn = query.GetFieldData(block.GetBlockName(), "CrdayFrbrdSubstMgn", 0).ParseLong("CrdayFrbrdSubstMgn"); // long 16
				block.PrdayCrbmkMnyMgn = query.GetFieldData(block.GetBlockName(), "PrdayCrbmkMnyMgn", 0).ParseLong("PrdayCrbmkMnyMgn"); // long 16
				block.PrdayCrbmkSubstMgn = query.GetFieldData(block.GetBlockName(), "PrdayCrbmkSubstMgn", 0).ParseLong("PrdayCrbmkSubstMgn"); // long 16
				block.CrdayCrbmkMnyMgn = query.GetFieldData(block.GetBlockName(), "CrdayCrbmkMnyMgn", 0).ParseLong("CrdayCrbmkMnyMgn"); // long 16
				block.CrdayCrbmkSubstMgn = query.GetFieldData(block.GetBlockName(), "CrdayCrbmkSubstMgn", 0).ParseLong("CrdayCrbmkSubstMgn"); // long 16
				block.DpspdgQty = query.GetFieldData(block.GetBlockName(), "DpspdgQty", 0).ParseLong("DpspdgQty"); // long 16
				block.BuyAdjstAmtD2 = query.GetFieldData(block.GetBlockName(), "BuyAdjstAmtD2", 0).ParseLong("BuyAdjstAmtD2"); // long 16
				block.SellAdjstAmtD2 = query.GetFieldData(block.GetBlockName(), "SellAdjstAmtD2", 0).ParseLong("SellAdjstAmtD2"); // long 16
				block.RepayRqrdAmtD1 = query.GetFieldData(block.GetBlockName(), "RepayRqrdAmtD1", 0).ParseLong("RepayRqrdAmtD1"); // long 16
				block.RepayRqrdAmtD2 = query.GetFieldData(block.GetBlockName(), "RepayRqrdAmtD2", 0).ParseLong("RepayRqrdAmtD2"); // long 16
				block.LoanAmt = query.GetFieldData(block.GetBlockName(), "LoanAmt", 0).ParseLong("LoanAmt"); // long 16

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
			if (HtsOrdAbleAmt.ToString().Length > 16) return false; // long 16
			if (MgnRat100pctOrdAbleAmt.ToString().Length > 16) return false; // long 16
			if (BalEvalAmt.ToString().Length > 16) return false; // long 16
			if (PchsAmt.ToString().Length > 16) return false; // long 16
			if (RcvblAmt.ToString().Length > 16) return false; // long 16
			// PnlRat double 18.6
			if (InvstOrgAmt.ToString().Length > 20) return false; // long 20
			if (InvstPlAmt.ToString().Length > 16) return false; // long 16
			if (CrdtPldgOrdAmt.ToString().Length > 16) return false; // long 16
			if (Dps.ToString().Length > 16) return false; // long 16
			if (D1Dps.ToString().Length > 16) return false; // long 16
			if (D2Dps.ToString().Length > 16) return false; // long 16
			if (OrdDt?.Length > 8) return false; // char 8
			if (MnyMgn.ToString().Length > 16) return false; // long 16
			if (SubstMgn.ToString().Length > 16) return false; // long 16
			if (SubstAmt.ToString().Length > 16) return false; // long 16
			if (PrdayBuyExecAmt.ToString().Length > 16) return false; // long 16
			if (PrdaySellExecAmt.ToString().Length > 16) return false; // long 16
			if (CrdayBuyExecAmt.ToString().Length > 16) return false; // long 16
			if (CrdaySellExecAmt.ToString().Length > 16) return false; // long 16
			if (EvalPnlSum.ToString().Length > 15) return false; // long 15
			if (DpsastTotamt.ToString().Length > 16) return false; // long 16
			if (Evrprc.ToString().Length > 19) return false; // long 19
			if (RuseAmt.ToString().Length > 16) return false; // long 16
			if (EtclndAmt.ToString().Length > 16) return false; // long 16
			if (PrcAdjstAmt.ToString().Length > 16) return false; // long 16
			if (D1CmsnAmt.ToString().Length > 16) return false; // long 16
			if (D2CmsnAmt.ToString().Length > 16) return false; // long 16
			if (D1EvrTax.ToString().Length > 16) return false; // long 16
			if (D2EvrTax.ToString().Length > 16) return false; // long 16
			if (D1SettPrergAmt.ToString().Length > 16) return false; // long 16
			if (D2SettPrergAmt.ToString().Length > 16) return false; // long 16
			if (PrdayKseMnyMgn.ToString().Length > 16) return false; // long 16
			if (PrdayKseSubstMgn.ToString().Length > 16) return false; // long 16
			if (PrdayKseCrdtMnyMgn.ToString().Length > 16) return false; // long 16
			if (PrdayKseCrdtSubstMgn.ToString().Length > 16) return false; // long 16
			if (CrdayKseMnyMgn.ToString().Length > 16) return false; // long 16
			if (CrdayKseSubstMgn.ToString().Length > 16) return false; // long 16
			if (CrdayKseCrdtMnyMgn.ToString().Length > 16) return false; // long 16
			if (CrdayKseCrdtSubstMgn.ToString().Length > 16) return false; // long 16
			if (PrdayKdqMnyMgn.ToString().Length > 16) return false; // long 16
			if (PrdayKdqSubstMgn.ToString().Length > 16) return false; // long 16
			if (PrdayKdqCrdtMnyMgn.ToString().Length > 16) return false; // long 16
			if (PrdayKdqCrdtSubstMgn.ToString().Length > 16) return false; // long 16
			if (CrdayKdqMnyMgn.ToString().Length > 16) return false; // long 16
			if (CrdayKdqSubstMgn.ToString().Length > 16) return false; // long 16
			if (CrdayKdqCrdtMnyMgn.ToString().Length > 16) return false; // long 16
			if (CrdayKdqCrdtSubstMgn.ToString().Length > 16) return false; // long 16
			if (PrdayFrbrdMnyMgn.ToString().Length > 16) return false; // long 16
			if (PrdayFrbrdSubstMgn.ToString().Length > 16) return false; // long 16
			if (CrdayFrbrdMnyMgn.ToString().Length > 16) return false; // long 16
			if (CrdayFrbrdSubstMgn.ToString().Length > 16) return false; // long 16
			if (PrdayCrbmkMnyMgn.ToString().Length > 16) return false; // long 16
			if (PrdayCrbmkSubstMgn.ToString().Length > 16) return false; // long 16
			if (CrdayCrbmkMnyMgn.ToString().Length > 16) return false; // long 16
			if (CrdayCrbmkSubstMgn.ToString().Length > 16) return false; // long 16
			if (DpspdgQty.ToString().Length > 16) return false; // long 16
			if (BuyAdjstAmtD2.ToString().Length > 16) return false; // long 16
			if (SellAdjstAmtD2.ToString().Length > 16) return false; // long 16
			if (RepayRqrdAmtD1.ToString().Length > 16) return false; // long 16
			if (RepayRqrdAmtD2.ToString().Length > 16) return false; // long 16
			if (LoanAmt.ToString().Length > 16) return false; // long 16

			return true;
		}

		public void CopyTo(XQCSPAQ12300OutBlock2 block)
		{
			block.RecCnt = this.RecCnt;
			block.BrnNm = this.BrnNm;
			block.AcntNm = this.AcntNm;
			block.MnyOrdAbleAmt = this.MnyOrdAbleAmt;
			block.MnyoutAbleAmt = this.MnyoutAbleAmt;
			block.SeOrdAbleAmt = this.SeOrdAbleAmt;
			block.KdqOrdAbleAmt = this.KdqOrdAbleAmt;
			block.HtsOrdAbleAmt = this.HtsOrdAbleAmt;
			block.MgnRat100pctOrdAbleAmt = this.MgnRat100pctOrdAbleAmt;
			block.BalEvalAmt = this.BalEvalAmt;
			block.PchsAmt = this.PchsAmt;
			block.RcvblAmt = this.RcvblAmt;
			block.PnlRat = this.PnlRat;
			block.InvstOrgAmt = this.InvstOrgAmt;
			block.InvstPlAmt = this.InvstPlAmt;
			block.CrdtPldgOrdAmt = this.CrdtPldgOrdAmt;
			block.Dps = this.Dps;
			block.D1Dps = this.D1Dps;
			block.D2Dps = this.D2Dps;
			block.OrdDt = this.OrdDt;
			block.MnyMgn = this.MnyMgn;
			block.SubstMgn = this.SubstMgn;
			block.SubstAmt = this.SubstAmt;
			block.PrdayBuyExecAmt = this.PrdayBuyExecAmt;
			block.PrdaySellExecAmt = this.PrdaySellExecAmt;
			block.CrdayBuyExecAmt = this.CrdayBuyExecAmt;
			block.CrdaySellExecAmt = this.CrdaySellExecAmt;
			block.EvalPnlSum = this.EvalPnlSum;
			block.DpsastTotamt = this.DpsastTotamt;
			block.Evrprc = this.Evrprc;
			block.RuseAmt = this.RuseAmt;
			block.EtclndAmt = this.EtclndAmt;
			block.PrcAdjstAmt = this.PrcAdjstAmt;
			block.D1CmsnAmt = this.D1CmsnAmt;
			block.D2CmsnAmt = this.D2CmsnAmt;
			block.D1EvrTax = this.D1EvrTax;
			block.D2EvrTax = this.D2EvrTax;
			block.D1SettPrergAmt = this.D1SettPrergAmt;
			block.D2SettPrergAmt = this.D2SettPrergAmt;
			block.PrdayKseMnyMgn = this.PrdayKseMnyMgn;
			block.PrdayKseSubstMgn = this.PrdayKseSubstMgn;
			block.PrdayKseCrdtMnyMgn = this.PrdayKseCrdtMnyMgn;
			block.PrdayKseCrdtSubstMgn = this.PrdayKseCrdtSubstMgn;
			block.CrdayKseMnyMgn = this.CrdayKseMnyMgn;
			block.CrdayKseSubstMgn = this.CrdayKseSubstMgn;
			block.CrdayKseCrdtMnyMgn = this.CrdayKseCrdtMnyMgn;
			block.CrdayKseCrdtSubstMgn = this.CrdayKseCrdtSubstMgn;
			block.PrdayKdqMnyMgn = this.PrdayKdqMnyMgn;
			block.PrdayKdqSubstMgn = this.PrdayKdqSubstMgn;
			block.PrdayKdqCrdtMnyMgn = this.PrdayKdqCrdtMnyMgn;
			block.PrdayKdqCrdtSubstMgn = this.PrdayKdqCrdtSubstMgn;
			block.CrdayKdqMnyMgn = this.CrdayKdqMnyMgn;
			block.CrdayKdqSubstMgn = this.CrdayKdqSubstMgn;
			block.CrdayKdqCrdtMnyMgn = this.CrdayKdqCrdtMnyMgn;
			block.CrdayKdqCrdtSubstMgn = this.CrdayKdqCrdtSubstMgn;
			block.PrdayFrbrdMnyMgn = this.PrdayFrbrdMnyMgn;
			block.PrdayFrbrdSubstMgn = this.PrdayFrbrdSubstMgn;
			block.CrdayFrbrdMnyMgn = this.CrdayFrbrdMnyMgn;
			block.CrdayFrbrdSubstMgn = this.CrdayFrbrdSubstMgn;
			block.PrdayCrbmkMnyMgn = this.PrdayCrbmkMnyMgn;
			block.PrdayCrbmkSubstMgn = this.PrdayCrbmkSubstMgn;
			block.CrdayCrbmkMnyMgn = this.CrdayCrbmkMnyMgn;
			block.CrdayCrbmkSubstMgn = this.CrdayCrbmkSubstMgn;
			block.DpspdgQty = this.DpspdgQty;
			block.BuyAdjstAmtD2 = this.BuyAdjstAmtD2;
			block.SellAdjstAmtD2 = this.SellAdjstAmtD2;
			block.RepayRqrdAmtD1 = this.RepayRqrdAmtD1;
			block.RepayRqrdAmtD2 = this.RepayRqrdAmtD2;
			block.LoanAmt = this.LoanAmt;

		}
	}

	public partial class XQCSPAQ12300OutBlock3 : XingBlock
	{
		/// <summary>
		/// CSPAQ12300OutBlock3
		/// </summary>
		public const string _blockName = "CSPAQ12300OutBlock3";
		/// <summary>
		/// ST_OUT(*EMPTY*)
		/// </summary>
		public const string _blockDesc = "ST_OUT(*EMPTY*)";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// true
		/// </summary>
		public const bool _hasOccurs = true;
		/// <summary>
		/// CSPAQ12300OutBlock3
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CSPAQ12300OutBlock3
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// ST_OUT(*EMPTY*)
		/// </summary>
		public string BlockDesc => _blockDesc;
		/// <summary>
		/// output
		/// </summary>
		public string BlockType => _blockType;
		/// <summary>
		/// true
		/// </summary>
		public bool HasOccurs => _hasOccurs;

		/// <summary>
		/// 종목번호
		/// </summary>
		[XAQueryFieldAttribute("IsuNo", "종목번호", "char", "12")]
		public string IsuNo;
		/// <summary>
		/// 종목명
		/// </summary>
		[XAQueryFieldAttribute("IsuNm", "종목명", "char", "40")]
		public string IsuNm;
		/// <summary>
		/// 유가증권잔고유형코드
		/// </summary>
		[XAQueryFieldAttribute("SecBalPtnCode", "유가증권잔고유형코드", "char", "2")]
		public string SecBalPtnCode;
		/// <summary>
		/// 유가증권잔고유형명
		/// </summary>
		[XAQueryFieldAttribute("SecBalPtnNm", "유가증권잔고유형명", "char", "40")]
		public string SecBalPtnNm;
		/// <summary>
		/// 잔고수량
		/// </summary>
		[XAQueryFieldAttribute("BalQty", "잔고수량", "long", "16")]
		public long BalQty;
		/// <summary>
		/// 매매기준잔고수량
		/// </summary>
		[XAQueryFieldAttribute("BnsBaseBalQty", "매매기준잔고수량", "long", "16")]
		public long BnsBaseBalQty;
		/// <summary>
		/// 금일매수체결수량
		/// </summary>
		[XAQueryFieldAttribute("CrdayBuyExecQty", "금일매수체결수량", "long", "16")]
		public long CrdayBuyExecQty;
		/// <summary>
		/// 금일매도체결수량
		/// </summary>
		[XAQueryFieldAttribute("CrdaySellExecQty", "금일매도체결수량", "long", "16")]
		public long CrdaySellExecQty;
		/// <summary>
		/// 매도가
		/// </summary>
		[XAQueryFieldAttribute("SellPrc", "매도가", "double", "21.4")]
		public double SellPrc;
		/// <summary>
		/// 매수가
		/// </summary>
		[XAQueryFieldAttribute("BuyPrc", "매수가", "double", "21.4")]
		public double BuyPrc;
		/// <summary>
		/// 매도손익금액
		/// </summary>
		[XAQueryFieldAttribute("SellPnlAmt", "매도손익금액", "long", "16")]
		public long SellPnlAmt;
		/// <summary>
		/// 손익율
		/// </summary>
		[XAQueryFieldAttribute("PnlRat", "손익율", "double", "18.6")]
		public double PnlRat;
		/// <summary>
		/// 현재가
		/// </summary>
		[XAQueryFieldAttribute("NowPrc", "현재가", "double", "15.2")]
		public double NowPrc;
		/// <summary>
		/// 신용금액
		/// </summary>
		[XAQueryFieldAttribute("CrdtAmt", "신용금액", "long", "16")]
		public long CrdtAmt;
		/// <summary>
		/// 만기일
		/// </summary>
		[XAQueryFieldAttribute("DueDt", "만기일", "char", "8")]
		public string DueDt;
		/// <summary>
		/// 전일매도체결가
		/// </summary>
		[XAQueryFieldAttribute("PrdaySellExecPrc", "전일매도체결가", "double", "13.2")]
		public double PrdaySellExecPrc;
		/// <summary>
		/// 전일매도수량
		/// </summary>
		[XAQueryFieldAttribute("PrdaySellQty", "전일매도수량", "long", "16")]
		public long PrdaySellQty;
		/// <summary>
		/// 전일매수체결가
		/// </summary>
		[XAQueryFieldAttribute("PrdayBuyExecPrc", "전일매수체결가", "double", "13.2")]
		public double PrdayBuyExecPrc;
		/// <summary>
		/// 전일매수수량
		/// </summary>
		[XAQueryFieldAttribute("PrdayBuyQty", "전일매수수량", "long", "16")]
		public long PrdayBuyQty;
		/// <summary>
		/// 대출일
		/// </summary>
		[XAQueryFieldAttribute("LoanDt", "대출일", "char", "8")]
		public string LoanDt;
		/// <summary>
		/// 평균단가
		/// </summary>
		[XAQueryFieldAttribute("AvrUprc", "평균단가", "double", "13.2")]
		public double AvrUprc;
		/// <summary>
		/// 매도가능수량
		/// </summary>
		[XAQueryFieldAttribute("SellAbleQty", "매도가능수량", "long", "16")]
		public long SellAbleQty;
		/// <summary>
		/// 매도주문수량
		/// </summary>
		[XAQueryFieldAttribute("SellOrdQty", "매도주문수량", "long", "16")]
		public long SellOrdQty;
		/// <summary>
		/// 금일매수체결금액
		/// </summary>
		[XAQueryFieldAttribute("CrdayBuyExecAmt", "금일매수체결금액", "long", "16")]
		public long CrdayBuyExecAmt;
		/// <summary>
		/// 금일매도체결금액
		/// </summary>
		[XAQueryFieldAttribute("CrdaySellExecAmt", "금일매도체결금액", "long", "16")]
		public long CrdaySellExecAmt;
		/// <summary>
		/// 전일매수체결금액
		/// </summary>
		[XAQueryFieldAttribute("PrdayBuyExecAmt", "전일매수체결금액", "long", "16")]
		public long PrdayBuyExecAmt;
		/// <summary>
		/// 전일매도체결금액
		/// </summary>
		[XAQueryFieldAttribute("PrdaySellExecAmt", "전일매도체결금액", "long", "16")]
		public long PrdaySellExecAmt;
		/// <summary>
		/// 잔고평가금액
		/// </summary>
		[XAQueryFieldAttribute("BalEvalAmt", "잔고평가금액", "long", "16")]
		public long BalEvalAmt;
		/// <summary>
		/// 평가손익
		/// </summary>
		[XAQueryFieldAttribute("EvalPnl", "평가손익", "long", "16")]
		public long EvalPnl;
		/// <summary>
		/// 현금주문가능금액
		/// </summary>
		[XAQueryFieldAttribute("MnyOrdAbleAmt", "현금주문가능금액", "long", "16")]
		public long MnyOrdAbleAmt;
		/// <summary>
		/// 주문가능금액
		/// </summary>
		[XAQueryFieldAttribute("OrdAbleAmt", "주문가능금액", "long", "16")]
		public long OrdAbleAmt;
		/// <summary>
		/// 매도미체결수량
		/// </summary>
		[XAQueryFieldAttribute("SellUnercQty", "매도미체결수량", "long", "16")]
		public long SellUnercQty;
		/// <summary>
		/// 매도미결제수량
		/// </summary>
		[XAQueryFieldAttribute("SellUnsttQty", "매도미결제수량", "long", "16")]
		public long SellUnsttQty;
		/// <summary>
		/// 매수미체결수량
		/// </summary>
		[XAQueryFieldAttribute("BuyUnercQty", "매수미체결수량", "long", "16")]
		public long BuyUnercQty;
		/// <summary>
		/// 매수미결제수량
		/// </summary>
		[XAQueryFieldAttribute("BuyUnsttQty", "매수미결제수량", "long", "16")]
		public long BuyUnsttQty;
		/// <summary>
		/// 미결제수량
		/// </summary>
		[XAQueryFieldAttribute("UnsttQty", "미결제수량", "long", "16")]
		public long UnsttQty;
		/// <summary>
		/// 미체결수량
		/// </summary>
		[XAQueryFieldAttribute("UnercQty", "미체결수량", "long", "16")]
		public long UnercQty;
		/// <summary>
		/// 전일종가
		/// </summary>
		[XAQueryFieldAttribute("PrdayCprc", "전일종가", "double", "15.2")]
		public double PrdayCprc;
		/// <summary>
		/// 매입금액
		/// </summary>
		[XAQueryFieldAttribute("PchsAmt", "매입금액", "long", "16")]
		public long PchsAmt;
		/// <summary>
		/// 등록시장코드
		/// </summary>
		[XAQueryFieldAttribute("RegMktCode", "등록시장코드", "char", "2")]
		public string RegMktCode;
		/// <summary>
		/// 대출상세분류코드
		/// </summary>
		[XAQueryFieldAttribute("LoanDtlClssCode", "대출상세분류코드", "char", "2")]
		public string LoanDtlClssCode;
		/// <summary>
		/// 예탁담보대출수량
		/// </summary>
		[XAQueryFieldAttribute("DpspdgLoanQty", "예탁담보대출수량", "long", "16")]
		public long DpspdgLoanQty;

		public static class F
		{
			/// <summary>
			/// 종목번호
			/// </summary>
			public const string IsuNo = "IsuNo";
			/// <summary>
			/// 종목명
			/// </summary>
			public const string IsuNm = "IsuNm";
			/// <summary>
			/// 유가증권잔고유형코드
			/// </summary>
			public const string SecBalPtnCode = "SecBalPtnCode";
			/// <summary>
			/// 유가증권잔고유형명
			/// </summary>
			public const string SecBalPtnNm = "SecBalPtnNm";
			/// <summary>
			/// 잔고수량
			/// </summary>
			public const string BalQty = "BalQty";
			/// <summary>
			/// 매매기준잔고수량
			/// </summary>
			public const string BnsBaseBalQty = "BnsBaseBalQty";
			/// <summary>
			/// 금일매수체결수량
			/// </summary>
			public const string CrdayBuyExecQty = "CrdayBuyExecQty";
			/// <summary>
			/// 금일매도체결수량
			/// </summary>
			public const string CrdaySellExecQty = "CrdaySellExecQty";
			/// <summary>
			/// 매도가
			/// </summary>
			public const string SellPrc = "SellPrc";
			/// <summary>
			/// 매수가
			/// </summary>
			public const string BuyPrc = "BuyPrc";
			/// <summary>
			/// 매도손익금액
			/// </summary>
			public const string SellPnlAmt = "SellPnlAmt";
			/// <summary>
			/// 손익율
			/// </summary>
			public const string PnlRat = "PnlRat";
			/// <summary>
			/// 현재가
			/// </summary>
			public const string NowPrc = "NowPrc";
			/// <summary>
			/// 신용금액
			/// </summary>
			public const string CrdtAmt = "CrdtAmt";
			/// <summary>
			/// 만기일
			/// </summary>
			public const string DueDt = "DueDt";
			/// <summary>
			/// 전일매도체결가
			/// </summary>
			public const string PrdaySellExecPrc = "PrdaySellExecPrc";
			/// <summary>
			/// 전일매도수량
			/// </summary>
			public const string PrdaySellQty = "PrdaySellQty";
			/// <summary>
			/// 전일매수체결가
			/// </summary>
			public const string PrdayBuyExecPrc = "PrdayBuyExecPrc";
			/// <summary>
			/// 전일매수수량
			/// </summary>
			public const string PrdayBuyQty = "PrdayBuyQty";
			/// <summary>
			/// 대출일
			/// </summary>
			public const string LoanDt = "LoanDt";
			/// <summary>
			/// 평균단가
			/// </summary>
			public const string AvrUprc = "AvrUprc";
			/// <summary>
			/// 매도가능수량
			/// </summary>
			public const string SellAbleQty = "SellAbleQty";
			/// <summary>
			/// 매도주문수량
			/// </summary>
			public const string SellOrdQty = "SellOrdQty";
			/// <summary>
			/// 금일매수체결금액
			/// </summary>
			public const string CrdayBuyExecAmt = "CrdayBuyExecAmt";
			/// <summary>
			/// 금일매도체결금액
			/// </summary>
			public const string CrdaySellExecAmt = "CrdaySellExecAmt";
			/// <summary>
			/// 전일매수체결금액
			/// </summary>
			public const string PrdayBuyExecAmt = "PrdayBuyExecAmt";
			/// <summary>
			/// 전일매도체결금액
			/// </summary>
			public const string PrdaySellExecAmt = "PrdaySellExecAmt";
			/// <summary>
			/// 잔고평가금액
			/// </summary>
			public const string BalEvalAmt = "BalEvalAmt";
			/// <summary>
			/// 평가손익
			/// </summary>
			public const string EvalPnl = "EvalPnl";
			/// <summary>
			/// 현금주문가능금액
			/// </summary>
			public const string MnyOrdAbleAmt = "MnyOrdAbleAmt";
			/// <summary>
			/// 주문가능금액
			/// </summary>
			public const string OrdAbleAmt = "OrdAbleAmt";
			/// <summary>
			/// 매도미체결수량
			/// </summary>
			public const string SellUnercQty = "SellUnercQty";
			/// <summary>
			/// 매도미결제수량
			/// </summary>
			public const string SellUnsttQty = "SellUnsttQty";
			/// <summary>
			/// 매수미체결수량
			/// </summary>
			public const string BuyUnercQty = "BuyUnercQty";
			/// <summary>
			/// 매수미결제수량
			/// </summary>
			public const string BuyUnsttQty = "BuyUnsttQty";
			/// <summary>
			/// 미결제수량
			/// </summary>
			public const string UnsttQty = "UnsttQty";
			/// <summary>
			/// 미체결수량
			/// </summary>
			public const string UnercQty = "UnercQty";
			/// <summary>
			/// 전일종가
			/// </summary>
			public const string PrdayCprc = "PrdayCprc";
			/// <summary>
			/// 매입금액
			/// </summary>
			public const string PchsAmt = "PchsAmt";
			/// <summary>
			/// 등록시장코드
			/// </summary>
			public const string RegMktCode = "RegMktCode";
			/// <summary>
			/// 대출상세분류코드
			/// </summary>
			public const string LoanDtlClssCode = "LoanDtlClssCode";
			/// <summary>
			/// 예탁담보대출수량
			/// </summary>
			public const string DpspdgLoanQty = "DpspdgLoanQty";
		}

		public static string[] AllFields = new string[]
		{
			F.IsuNo,
			F.IsuNm,
			F.SecBalPtnCode,
			F.SecBalPtnNm,
			F.BalQty,
			F.BnsBaseBalQty,
			F.CrdayBuyExecQty,
			F.CrdaySellExecQty,
			F.SellPrc,
			F.BuyPrc,
			F.SellPnlAmt,
			F.PnlRat,
			F.NowPrc,
			F.CrdtAmt,
			F.DueDt,
			F.PrdaySellExecPrc,
			F.PrdaySellQty,
			F.PrdayBuyExecPrc,
			F.PrdayBuyQty,
			F.LoanDt,
			F.AvrUprc,
			F.SellAbleQty,
			F.SellOrdQty,
			F.CrdayBuyExecAmt,
			F.CrdaySellExecAmt,
			F.PrdayBuyExecAmt,
			F.PrdaySellExecAmt,
			F.BalEvalAmt,
			F.EvalPnl,
			F.MnyOrdAbleAmt,
			F.OrdAbleAmt,
			F.SellUnercQty,
			F.SellUnsttQty,
			F.BuyUnercQty,
			F.BuyUnsttQty,
			F.UnsttQty,
			F.UnercQty,
			F.PrdayCprc,
			F.PchsAmt,
			F.RegMktCode,
			F.LoanDtlClssCode,
			F.DpspdgLoanQty,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["IsuNo"] = new XAQueryFieldInfo("char", IsuNo, IsuNo, "종목번호", (decimal)12);
			dict["IsuNm"] = new XAQueryFieldInfo("char", IsuNm, IsuNm, "종목명", (decimal)40);
			dict["SecBalPtnCode"] = new XAQueryFieldInfo("char", SecBalPtnCode, SecBalPtnCode, "유가증권잔고유형코드", (decimal)2);
			dict["SecBalPtnNm"] = new XAQueryFieldInfo("char", SecBalPtnNm, SecBalPtnNm, "유가증권잔고유형명", (decimal)40);
			dict["BalQty"] = new XAQueryFieldInfo("long", BalQty, BalQty.ToString("d16"), "잔고수량", (decimal)16);
			dict["BnsBaseBalQty"] = new XAQueryFieldInfo("long", BnsBaseBalQty, BnsBaseBalQty.ToString("d16"), "매매기준잔고수량", (decimal)16);
			dict["CrdayBuyExecQty"] = new XAQueryFieldInfo("long", CrdayBuyExecQty, CrdayBuyExecQty.ToString("d16"), "금일매수체결수량", (decimal)16);
			dict["CrdaySellExecQty"] = new XAQueryFieldInfo("long", CrdaySellExecQty, CrdaySellExecQty.ToString("d16"), "금일매도체결수량", (decimal)16);
			dict["SellPrc"] = new XAQueryFieldInfo("double", SellPrc, SellPrc.ToString("000000000000000000000.0000"), "매도가", (decimal)21.4);
			dict["BuyPrc"] = new XAQueryFieldInfo("double", BuyPrc, BuyPrc.ToString("000000000000000000000.0000"), "매수가", (decimal)21.4);
			dict["SellPnlAmt"] = new XAQueryFieldInfo("long", SellPnlAmt, SellPnlAmt.ToString("d16"), "매도손익금액", (decimal)16);
			dict["PnlRat"] = new XAQueryFieldInfo("double", PnlRat, PnlRat.ToString("000000000000000000.000000"), "손익율", (decimal)18.6);
			dict["NowPrc"] = new XAQueryFieldInfo("double", NowPrc, NowPrc.ToString("000000000000000.00"), "현재가", (decimal)15.2);
			dict["CrdtAmt"] = new XAQueryFieldInfo("long", CrdtAmt, CrdtAmt.ToString("d16"), "신용금액", (decimal)16);
			dict["DueDt"] = new XAQueryFieldInfo("char", DueDt, DueDt, "만기일", (decimal)8);
			dict["PrdaySellExecPrc"] = new XAQueryFieldInfo("double", PrdaySellExecPrc, PrdaySellExecPrc.ToString("0000000000000.00"), "전일매도체결가", (decimal)13.2);
			dict["PrdaySellQty"] = new XAQueryFieldInfo("long", PrdaySellQty, PrdaySellQty.ToString("d16"), "전일매도수량", (decimal)16);
			dict["PrdayBuyExecPrc"] = new XAQueryFieldInfo("double", PrdayBuyExecPrc, PrdayBuyExecPrc.ToString("0000000000000.00"), "전일매수체결가", (decimal)13.2);
			dict["PrdayBuyQty"] = new XAQueryFieldInfo("long", PrdayBuyQty, PrdayBuyQty.ToString("d16"), "전일매수수량", (decimal)16);
			dict["LoanDt"] = new XAQueryFieldInfo("char", LoanDt, LoanDt, "대출일", (decimal)8);
			dict["AvrUprc"] = new XAQueryFieldInfo("double", AvrUprc, AvrUprc.ToString("0000000000000.00"), "평균단가", (decimal)13.2);
			dict["SellAbleQty"] = new XAQueryFieldInfo("long", SellAbleQty, SellAbleQty.ToString("d16"), "매도가능수량", (decimal)16);
			dict["SellOrdQty"] = new XAQueryFieldInfo("long", SellOrdQty, SellOrdQty.ToString("d16"), "매도주문수량", (decimal)16);
			dict["CrdayBuyExecAmt"] = new XAQueryFieldInfo("long", CrdayBuyExecAmt, CrdayBuyExecAmt.ToString("d16"), "금일매수체결금액", (decimal)16);
			dict["CrdaySellExecAmt"] = new XAQueryFieldInfo("long", CrdaySellExecAmt, CrdaySellExecAmt.ToString("d16"), "금일매도체결금액", (decimal)16);
			dict["PrdayBuyExecAmt"] = new XAQueryFieldInfo("long", PrdayBuyExecAmt, PrdayBuyExecAmt.ToString("d16"), "전일매수체결금액", (decimal)16);
			dict["PrdaySellExecAmt"] = new XAQueryFieldInfo("long", PrdaySellExecAmt, PrdaySellExecAmt.ToString("d16"), "전일매도체결금액", (decimal)16);
			dict["BalEvalAmt"] = new XAQueryFieldInfo("long", BalEvalAmt, BalEvalAmt.ToString("d16"), "잔고평가금액", (decimal)16);
			dict["EvalPnl"] = new XAQueryFieldInfo("long", EvalPnl, EvalPnl.ToString("d16"), "평가손익", (decimal)16);
			dict["MnyOrdAbleAmt"] = new XAQueryFieldInfo("long", MnyOrdAbleAmt, MnyOrdAbleAmt.ToString("d16"), "현금주문가능금액", (decimal)16);
			dict["OrdAbleAmt"] = new XAQueryFieldInfo("long", OrdAbleAmt, OrdAbleAmt.ToString("d16"), "주문가능금액", (decimal)16);
			dict["SellUnercQty"] = new XAQueryFieldInfo("long", SellUnercQty, SellUnercQty.ToString("d16"), "매도미체결수량", (decimal)16);
			dict["SellUnsttQty"] = new XAQueryFieldInfo("long", SellUnsttQty, SellUnsttQty.ToString("d16"), "매도미결제수량", (decimal)16);
			dict["BuyUnercQty"] = new XAQueryFieldInfo("long", BuyUnercQty, BuyUnercQty.ToString("d16"), "매수미체결수량", (decimal)16);
			dict["BuyUnsttQty"] = new XAQueryFieldInfo("long", BuyUnsttQty, BuyUnsttQty.ToString("d16"), "매수미결제수량", (decimal)16);
			dict["UnsttQty"] = new XAQueryFieldInfo("long", UnsttQty, UnsttQty.ToString("d16"), "미결제수량", (decimal)16);
			dict["UnercQty"] = new XAQueryFieldInfo("long", UnercQty, UnercQty.ToString("d16"), "미체결수량", (decimal)16);
			dict["PrdayCprc"] = new XAQueryFieldInfo("double", PrdayCprc, PrdayCprc.ToString("000000000000000.00"), "전일종가", (decimal)15.2);
			dict["PchsAmt"] = new XAQueryFieldInfo("long", PchsAmt, PchsAmt.ToString("d16"), "매입금액", (decimal)16);
			dict["RegMktCode"] = new XAQueryFieldInfo("char", RegMktCode, RegMktCode, "등록시장코드", (decimal)2);
			dict["LoanDtlClssCode"] = new XAQueryFieldInfo("char", LoanDtlClssCode, LoanDtlClssCode, "대출상세분류코드", (decimal)2);
			dict["DpspdgLoanQty"] = new XAQueryFieldInfo("long", DpspdgLoanQty, DpspdgLoanQty.ToString("d16"), "예탁담보대출수량", (decimal)16);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "IsuNo":
					this.IsuNo = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "IsuNm":
					this.IsuNm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "SecBalPtnCode":
					this.SecBalPtnCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "SecBalPtnNm":
					this.SecBalPtnNm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "BalQty":
					this.BalQty = fieldInfo.FieldValue.ParseLong("BalQty");
				break;

				case "BnsBaseBalQty":
					this.BnsBaseBalQty = fieldInfo.FieldValue.ParseLong("BnsBaseBalQty");
				break;

				case "CrdayBuyExecQty":
					this.CrdayBuyExecQty = fieldInfo.FieldValue.ParseLong("CrdayBuyExecQty");
				break;

				case "CrdaySellExecQty":
					this.CrdaySellExecQty = fieldInfo.FieldValue.ParseLong("CrdaySellExecQty");
				break;

				case "SellPrc":
					this.SellPrc = fieldInfo.FieldValue.ParseDouble("SellPrc");
				break;

				case "BuyPrc":
					this.BuyPrc = fieldInfo.FieldValue.ParseDouble("BuyPrc");
				break;

				case "SellPnlAmt":
					this.SellPnlAmt = fieldInfo.FieldValue.ParseLong("SellPnlAmt");
				break;

				case "PnlRat":
					this.PnlRat = fieldInfo.FieldValue.ParseDouble("PnlRat");
				break;

				case "NowPrc":
					this.NowPrc = fieldInfo.FieldValue.ParseDouble("NowPrc");
				break;

				case "CrdtAmt":
					this.CrdtAmt = fieldInfo.FieldValue.ParseLong("CrdtAmt");
				break;

				case "DueDt":
					this.DueDt = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "PrdaySellExecPrc":
					this.PrdaySellExecPrc = fieldInfo.FieldValue.ParseDouble("PrdaySellExecPrc");
				break;

				case "PrdaySellQty":
					this.PrdaySellQty = fieldInfo.FieldValue.ParseLong("PrdaySellQty");
				break;

				case "PrdayBuyExecPrc":
					this.PrdayBuyExecPrc = fieldInfo.FieldValue.ParseDouble("PrdayBuyExecPrc");
				break;

				case "PrdayBuyQty":
					this.PrdayBuyQty = fieldInfo.FieldValue.ParseLong("PrdayBuyQty");
				break;

				case "LoanDt":
					this.LoanDt = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "AvrUprc":
					this.AvrUprc = fieldInfo.FieldValue.ParseDouble("AvrUprc");
				break;

				case "SellAbleQty":
					this.SellAbleQty = fieldInfo.FieldValue.ParseLong("SellAbleQty");
				break;

				case "SellOrdQty":
					this.SellOrdQty = fieldInfo.FieldValue.ParseLong("SellOrdQty");
				break;

				case "CrdayBuyExecAmt":
					this.CrdayBuyExecAmt = fieldInfo.FieldValue.ParseLong("CrdayBuyExecAmt");
				break;

				case "CrdaySellExecAmt":
					this.CrdaySellExecAmt = fieldInfo.FieldValue.ParseLong("CrdaySellExecAmt");
				break;

				case "PrdayBuyExecAmt":
					this.PrdayBuyExecAmt = fieldInfo.FieldValue.ParseLong("PrdayBuyExecAmt");
				break;

				case "PrdaySellExecAmt":
					this.PrdaySellExecAmt = fieldInfo.FieldValue.ParseLong("PrdaySellExecAmt");
				break;

				case "BalEvalAmt":
					this.BalEvalAmt = fieldInfo.FieldValue.ParseLong("BalEvalAmt");
				break;

				case "EvalPnl":
					this.EvalPnl = fieldInfo.FieldValue.ParseLong("EvalPnl");
				break;

				case "MnyOrdAbleAmt":
					this.MnyOrdAbleAmt = fieldInfo.FieldValue.ParseLong("MnyOrdAbleAmt");
				break;

				case "OrdAbleAmt":
					this.OrdAbleAmt = fieldInfo.FieldValue.ParseLong("OrdAbleAmt");
				break;

				case "SellUnercQty":
					this.SellUnercQty = fieldInfo.FieldValue.ParseLong("SellUnercQty");
				break;

				case "SellUnsttQty":
					this.SellUnsttQty = fieldInfo.FieldValue.ParseLong("SellUnsttQty");
				break;

				case "BuyUnercQty":
					this.BuyUnercQty = fieldInfo.FieldValue.ParseLong("BuyUnercQty");
				break;

				case "BuyUnsttQty":
					this.BuyUnsttQty = fieldInfo.FieldValue.ParseLong("BuyUnsttQty");
				break;

				case "UnsttQty":
					this.UnsttQty = fieldInfo.FieldValue.ParseLong("UnsttQty");
				break;

				case "UnercQty":
					this.UnercQty = fieldInfo.FieldValue.ParseLong("UnercQty");
				break;

				case "PrdayCprc":
					this.PrdayCprc = fieldInfo.FieldValue.ParseDouble("PrdayCprc");
				break;

				case "PchsAmt":
					this.PchsAmt = fieldInfo.FieldValue.ParseLong("PchsAmt");
				break;

				case "RegMktCode":
					this.RegMktCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "LoanDtlClssCode":
					this.LoanDtlClssCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "DpspdgLoanQty":
					this.DpspdgLoanQty = fieldInfo.FieldValue.ParseLong("DpspdgLoanQty");
				break;


			}
		}

		public static XQCSPAQ12300OutBlock3[] ListFromQuery(XQCSPAQ12300 query)
		{
			int count = query.GetBlockCount(XQCSPAQ12300OutBlock3.BlockName);
			List<XQCSPAQ12300OutBlock3> list = new List<XQCSPAQ12300OutBlock3>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQCSPAQ12300OutBlock3 block = new XQCSPAQ12300OutBlock3();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.IsuNo = query.GetFieldData(block.GetBlockName(), "IsuNo", i).TrimEnd('?'); // char 12
					block.IsuNm = query.GetFieldData(block.GetBlockName(), "IsuNm", i).TrimEnd('?'); // char 40
					block.SecBalPtnCode = query.GetFieldData(block.GetBlockName(), "SecBalPtnCode", i).TrimEnd('?'); // char 2
					block.SecBalPtnNm = query.GetFieldData(block.GetBlockName(), "SecBalPtnNm", i).TrimEnd('?'); // char 40
					block.BalQty = query.GetFieldData(block.GetBlockName(), "BalQty", i).ParseLong("BalQty"); // long 16
					block.BnsBaseBalQty = query.GetFieldData(block.GetBlockName(), "BnsBaseBalQty", i).ParseLong("BnsBaseBalQty"); // long 16
					block.CrdayBuyExecQty = query.GetFieldData(block.GetBlockName(), "CrdayBuyExecQty", i).ParseLong("CrdayBuyExecQty"); // long 16
					block.CrdaySellExecQty = query.GetFieldData(block.GetBlockName(), "CrdaySellExecQty", i).ParseLong("CrdaySellExecQty"); // long 16
					block.SellPrc = query.GetFieldData(block.GetBlockName(), "SellPrc", i).ParseDouble("SellPrc"); // double 21.4
					block.BuyPrc = query.GetFieldData(block.GetBlockName(), "BuyPrc", i).ParseDouble("BuyPrc"); // double 21.4
					block.SellPnlAmt = query.GetFieldData(block.GetBlockName(), "SellPnlAmt", i).ParseLong("SellPnlAmt"); // long 16
					block.PnlRat = query.GetFieldData(block.GetBlockName(), "PnlRat", i).ParseDouble("PnlRat"); // double 18.6
					block.NowPrc = query.GetFieldData(block.GetBlockName(), "NowPrc", i).ParseDouble("NowPrc"); // double 15.2
					block.CrdtAmt = query.GetFieldData(block.GetBlockName(), "CrdtAmt", i).ParseLong("CrdtAmt"); // long 16
					block.DueDt = query.GetFieldData(block.GetBlockName(), "DueDt", i).TrimEnd('?'); // char 8
					block.PrdaySellExecPrc = query.GetFieldData(block.GetBlockName(), "PrdaySellExecPrc", i).ParseDouble("PrdaySellExecPrc"); // double 13.2
					block.PrdaySellQty = query.GetFieldData(block.GetBlockName(), "PrdaySellQty", i).ParseLong("PrdaySellQty"); // long 16
					block.PrdayBuyExecPrc = query.GetFieldData(block.GetBlockName(), "PrdayBuyExecPrc", i).ParseDouble("PrdayBuyExecPrc"); // double 13.2
					block.PrdayBuyQty = query.GetFieldData(block.GetBlockName(), "PrdayBuyQty", i).ParseLong("PrdayBuyQty"); // long 16
					block.LoanDt = query.GetFieldData(block.GetBlockName(), "LoanDt", i).TrimEnd('?'); // char 8
					block.AvrUprc = query.GetFieldData(block.GetBlockName(), "AvrUprc", i).ParseDouble("AvrUprc"); // double 13.2
					block.SellAbleQty = query.GetFieldData(block.GetBlockName(), "SellAbleQty", i).ParseLong("SellAbleQty"); // long 16
					block.SellOrdQty = query.GetFieldData(block.GetBlockName(), "SellOrdQty", i).ParseLong("SellOrdQty"); // long 16
					block.CrdayBuyExecAmt = query.GetFieldData(block.GetBlockName(), "CrdayBuyExecAmt", i).ParseLong("CrdayBuyExecAmt"); // long 16
					block.CrdaySellExecAmt = query.GetFieldData(block.GetBlockName(), "CrdaySellExecAmt", i).ParseLong("CrdaySellExecAmt"); // long 16
					block.PrdayBuyExecAmt = query.GetFieldData(block.GetBlockName(), "PrdayBuyExecAmt", i).ParseLong("PrdayBuyExecAmt"); // long 16
					block.PrdaySellExecAmt = query.GetFieldData(block.GetBlockName(), "PrdaySellExecAmt", i).ParseLong("PrdaySellExecAmt"); // long 16
					block.BalEvalAmt = query.GetFieldData(block.GetBlockName(), "BalEvalAmt", i).ParseLong("BalEvalAmt"); // long 16
					block.EvalPnl = query.GetFieldData(block.GetBlockName(), "EvalPnl", i).ParseLong("EvalPnl"); // long 16
					block.MnyOrdAbleAmt = query.GetFieldData(block.GetBlockName(), "MnyOrdAbleAmt", i).ParseLong("MnyOrdAbleAmt"); // long 16
					block.OrdAbleAmt = query.GetFieldData(block.GetBlockName(), "OrdAbleAmt", i).ParseLong("OrdAbleAmt"); // long 16
					block.SellUnercQty = query.GetFieldData(block.GetBlockName(), "SellUnercQty", i).ParseLong("SellUnercQty"); // long 16
					block.SellUnsttQty = query.GetFieldData(block.GetBlockName(), "SellUnsttQty", i).ParseLong("SellUnsttQty"); // long 16
					block.BuyUnercQty = query.GetFieldData(block.GetBlockName(), "BuyUnercQty", i).ParseLong("BuyUnercQty"); // long 16
					block.BuyUnsttQty = query.GetFieldData(block.GetBlockName(), "BuyUnsttQty", i).ParseLong("BuyUnsttQty"); // long 16
					block.UnsttQty = query.GetFieldData(block.GetBlockName(), "UnsttQty", i).ParseLong("UnsttQty"); // long 16
					block.UnercQty = query.GetFieldData(block.GetBlockName(), "UnercQty", i).ParseLong("UnercQty"); // long 16
					block.PrdayCprc = query.GetFieldData(block.GetBlockName(), "PrdayCprc", i).ParseDouble("PrdayCprc"); // double 15.2
					block.PchsAmt = query.GetFieldData(block.GetBlockName(), "PchsAmt", i).ParseLong("PchsAmt"); // long 16
					block.RegMktCode = query.GetFieldData(block.GetBlockName(), "RegMktCode", i).TrimEnd('?'); // char 2
					block.LoanDtlClssCode = query.GetFieldData(block.GetBlockName(), "LoanDtlClssCode", i).TrimEnd('?'); // char 2
					block.DpspdgLoanQty = query.GetFieldData(block.GetBlockName(), "DpspdgLoanQty", i).ParseLong("DpspdgLoanQty"); // long 16

				} catch (InvalidDataFormatException e) {
					block.IsValidData = false;
					block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
				}
				list.Add(block);
			}
			return list.ToArray();

		}

		public bool VerifyData()
		{
			if (IsuNo?.Length > 12) return false; // char 12
			if (IsuNm?.Length > 40) return false; // char 40
			if (SecBalPtnCode?.Length > 2) return false; // char 2
			if (SecBalPtnNm?.Length > 40) return false; // char 40
			if (BalQty.ToString().Length > 16) return false; // long 16
			if (BnsBaseBalQty.ToString().Length > 16) return false; // long 16
			if (CrdayBuyExecQty.ToString().Length > 16) return false; // long 16
			if (CrdaySellExecQty.ToString().Length > 16) return false; // long 16
			// SellPrc double 21.4
			// BuyPrc double 21.4
			if (SellPnlAmt.ToString().Length > 16) return false; // long 16
			// PnlRat double 18.6
			// NowPrc double 15.2
			if (CrdtAmt.ToString().Length > 16) return false; // long 16
			if (DueDt?.Length > 8) return false; // char 8
			// PrdaySellExecPrc double 13.2
			if (PrdaySellQty.ToString().Length > 16) return false; // long 16
			// PrdayBuyExecPrc double 13.2
			if (PrdayBuyQty.ToString().Length > 16) return false; // long 16
			if (LoanDt?.Length > 8) return false; // char 8
			// AvrUprc double 13.2
			if (SellAbleQty.ToString().Length > 16) return false; // long 16
			if (SellOrdQty.ToString().Length > 16) return false; // long 16
			if (CrdayBuyExecAmt.ToString().Length > 16) return false; // long 16
			if (CrdaySellExecAmt.ToString().Length > 16) return false; // long 16
			if (PrdayBuyExecAmt.ToString().Length > 16) return false; // long 16
			if (PrdaySellExecAmt.ToString().Length > 16) return false; // long 16
			if (BalEvalAmt.ToString().Length > 16) return false; // long 16
			if (EvalPnl.ToString().Length > 16) return false; // long 16
			if (MnyOrdAbleAmt.ToString().Length > 16) return false; // long 16
			if (OrdAbleAmt.ToString().Length > 16) return false; // long 16
			if (SellUnercQty.ToString().Length > 16) return false; // long 16
			if (SellUnsttQty.ToString().Length > 16) return false; // long 16
			if (BuyUnercQty.ToString().Length > 16) return false; // long 16
			if (BuyUnsttQty.ToString().Length > 16) return false; // long 16
			if (UnsttQty.ToString().Length > 16) return false; // long 16
			if (UnercQty.ToString().Length > 16) return false; // long 16
			// PrdayCprc double 15.2
			if (PchsAmt.ToString().Length > 16) return false; // long 16
			if (RegMktCode?.Length > 2) return false; // char 2
			if (LoanDtlClssCode?.Length > 2) return false; // char 2
			if (DpspdgLoanQty.ToString().Length > 16) return false; // long 16

			return true;
		}

		public void CopyTo(XQCSPAQ12300OutBlock3 block)
		{
			block.IsuNo = this.IsuNo;
			block.IsuNm = this.IsuNm;
			block.SecBalPtnCode = this.SecBalPtnCode;
			block.SecBalPtnNm = this.SecBalPtnNm;
			block.BalQty = this.BalQty;
			block.BnsBaseBalQty = this.BnsBaseBalQty;
			block.CrdayBuyExecQty = this.CrdayBuyExecQty;
			block.CrdaySellExecQty = this.CrdaySellExecQty;
			block.SellPrc = this.SellPrc;
			block.BuyPrc = this.BuyPrc;
			block.SellPnlAmt = this.SellPnlAmt;
			block.PnlRat = this.PnlRat;
			block.NowPrc = this.NowPrc;
			block.CrdtAmt = this.CrdtAmt;
			block.DueDt = this.DueDt;
			block.PrdaySellExecPrc = this.PrdaySellExecPrc;
			block.PrdaySellQty = this.PrdaySellQty;
			block.PrdayBuyExecPrc = this.PrdayBuyExecPrc;
			block.PrdayBuyQty = this.PrdayBuyQty;
			block.LoanDt = this.LoanDt;
			block.AvrUprc = this.AvrUprc;
			block.SellAbleQty = this.SellAbleQty;
			block.SellOrdQty = this.SellOrdQty;
			block.CrdayBuyExecAmt = this.CrdayBuyExecAmt;
			block.CrdaySellExecAmt = this.CrdaySellExecAmt;
			block.PrdayBuyExecAmt = this.PrdayBuyExecAmt;
			block.PrdaySellExecAmt = this.PrdaySellExecAmt;
			block.BalEvalAmt = this.BalEvalAmt;
			block.EvalPnl = this.EvalPnl;
			block.MnyOrdAbleAmt = this.MnyOrdAbleAmt;
			block.OrdAbleAmt = this.OrdAbleAmt;
			block.SellUnercQty = this.SellUnercQty;
			block.SellUnsttQty = this.SellUnsttQty;
			block.BuyUnercQty = this.BuyUnercQty;
			block.BuyUnsttQty = this.BuyUnsttQty;
			block.UnsttQty = this.UnsttQty;
			block.UnercQty = this.UnercQty;
			block.PrdayCprc = this.PrdayCprc;
			block.PchsAmt = this.PchsAmt;
			block.RegMktCode = this.RegMktCode;
			block.LoanDtlClssCode = this.LoanDtlClssCode;
			block.DpspdgLoanQty = this.DpspdgLoanQty;

		}
	}

	/// <summary>
	/// BEP단가조회
	/// </summary>
	public partial class XQCSPAQ12300 : XingQuery
	{
		/// <summary>
		/// CSPAQ12300
		/// </summary>
		public const string _typeName = "CSPAQ12300";
		/// <summary>
		/// BEP단가조회
		/// </summary>
		public const string _typeDesc = "BEP단가조회";
		/// <summary>
		/// CSPAQ12300
		/// </summary>
		public const string _service = "CSPAQ12300";
		/// <summary>
		/// B
		/// </summary>
		public const string _headType = "B";
		/// <summary>
		/// 이상은
		/// </summary>
		public const string _creator = "이상은";
		/// <summary>
		/// 2015/04/13 08:43:20
		/// </summary>
		public const string _createdDate = "2015/04/13 08:43:20";
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
		/// CSPAQ12300
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// BEP단가조회
		/// </summary>
		public string TypeDesc => _typeDesc;
		/// <summary>
		/// CSPAQ12300
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
		/// 2015/04/13 08:43:20
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
		/// BEP단가조회
		/// </summary>
		public XQCSPAQ12300() : base("CSPAQ12300") { }




		public bool SetBlock(XQCSPAQ12300InBlock1 block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "RecCnt", 0, block.RecCnt.ToString("d5")); // long 5
			_xaQuery.SetFieldData(block.GetBlockName(), "AcntNo", 0, block.AcntNo); // char 20
			_xaQuery.SetFieldData(block.GetBlockName(), "Pwd", 0, block.Pwd); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "BalCreTp", 0, block.BalCreTp.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "CmsnAppTpCode", 0, block.CmsnAppTpCode.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "D2balBaseQryTp", 0, block.D2balBaseQryTp.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "UprcTpCode", 0, block.UprcTpCode.ToString()); // char 1

			return true;
		}

		public XQCSPAQ12300OutBlock1 GetBlock1()
		{
			XQCSPAQ12300OutBlock1 instance = XQCSPAQ12300OutBlock1.FromQuery(this);
			return instance;

		}

		public XQCSPAQ12300OutBlock2 GetBlock2()
		{
			XQCSPAQ12300OutBlock2 instance = XQCSPAQ12300OutBlock2.FromQuery(this);
			return instance;

		}

		public XQCSPAQ12300OutBlock3[] GetBlock3s()
		{
			XQCSPAQ12300OutBlock3[] instance = XQCSPAQ12300OutBlock3.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQCSPAQ12300OutBlock1),
			typeof(XQCSPAQ12300OutBlock2),
			typeof(XQCSPAQ12300OutBlock3),

		};

	}

}
