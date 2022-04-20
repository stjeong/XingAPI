using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQCFOEQ11100InBlock1 : XingBlock
	{
		/// <summary>
		/// CFOEQ11100InBlock1
		/// </summary>
		public const string _blockName = "CFOEQ11100InBlock1";
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
		/// CFOEQ11100InBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CFOEQ11100InBlock1
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
		/// 매매일
		/// </summary>
		[XAQueryFieldAttribute("BnsDt", "매매일", "char", "8")]
		public string BnsDt;

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
			/// 매매일
			/// </summary>
			public const string BnsDt = "BnsDt";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.AcntNo,
			F.Pwd,
			F.BnsDt,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["AcntNo"] = new XAQueryFieldInfo("char", AcntNo, AcntNo, "계좌번호", (decimal)20);
			dict["Pwd"] = new XAQueryFieldInfo("char", Pwd, Pwd, "비밀번호", (decimal)8);
			dict["BnsDt"] = new XAQueryFieldInfo("char", BnsDt, BnsDt, "매매일", (decimal)8);

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

				case "BnsDt":
					this.BnsDt = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (RecCnt.ToString().Length > 5) return false; // long 5
			if (AcntNo?.Length > 20) return false; // char 20
			if (Pwd?.Length > 8) return false; // char 8
			if (BnsDt?.Length > 8) return false; // char 8

			return true;
		}

		public void CopyTo(XQCFOEQ11100InBlock1 block)
		{
			block.RecCnt = this.RecCnt;
			block.AcntNo = this.AcntNo;
			block.Pwd = this.Pwd;
			block.BnsDt = this.BnsDt;

		}
	}

	public partial class XQCFOEQ11100OutBlock1 : XingBlock
	{
		/// <summary>
		/// CFOEQ11100OutBlock1
		/// </summary>
		public const string _blockName = "CFOEQ11100OutBlock1";
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
		/// CFOEQ11100OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CFOEQ11100OutBlock1
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
		/// 매매일
		/// </summary>
		[XAQueryFieldAttribute("BnsDt", "매매일", "char", "8")]
		public string BnsDt;

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
			/// 매매일
			/// </summary>
			public const string BnsDt = "BnsDt";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.AcntNo,
			F.Pwd,
			F.BnsDt,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["AcntNo"] = new XAQueryFieldInfo("char", AcntNo, AcntNo, "계좌번호", (decimal)20);
			dict["Pwd"] = new XAQueryFieldInfo("char", Pwd, Pwd, "비밀번호", (decimal)8);
			dict["BnsDt"] = new XAQueryFieldInfo("char", BnsDt, BnsDt, "매매일", (decimal)8);

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

				case "BnsDt":
					this.BnsDt = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQCFOEQ11100OutBlock1 FromQuery(XQCFOEQ11100 query)
		{
			XQCFOEQ11100OutBlock1 block = new XQCFOEQ11100OutBlock1();
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
				block.BnsDt = query.GetFieldData(block.GetBlockName(), "BnsDt", 0).TrimEnd('?'); // char 8

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
			if (BnsDt?.Length > 8) return false; // char 8

			return true;
		}

		public void CopyTo(XQCFOEQ11100OutBlock1 block)
		{
			block.RecCnt = this.RecCnt;
			block.AcntNo = this.AcntNo;
			block.Pwd = this.Pwd;
			block.BnsDt = this.BnsDt;

		}
	}

	public partial class XQCFOEQ11100OutBlock2 : XingBlock
	{
		/// <summary>
		/// CFOEQ11100OutBlock2
		/// </summary>
		public const string _blockName = "CFOEQ11100OutBlock2";
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
		/// CFOEQ11100OutBlock2
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CFOEQ11100OutBlock2
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
		/// 계좌명
		/// </summary>
		[XAQueryFieldAttribute("AcntNm", "계좌명", "char", "40")]
		public string AcntNm;
		/// <summary>
		/// 개장시예탁금총액
		/// </summary>
		[XAQueryFieldAttribute("OpnmkDpsamtTotamt", "개장시예탁금총액", "long", "16")]
		public long OpnmkDpsamtTotamt;
		/// <summary>
		/// 개장시예수금
		/// </summary>
		[XAQueryFieldAttribute("OpnmkDps", "개장시예수금", "long", "16")]
		public long OpnmkDps;
		/// <summary>
		/// 개장시현금미수금
		/// </summary>
		[XAQueryFieldAttribute("OpnmkMnyrclAmt", "개장시현금미수금", "long", "16")]
		public long OpnmkMnyrclAmt;
		/// <summary>
		/// 개장시대용금액
		/// </summary>
		[XAQueryFieldAttribute("OpnmkSubstAmt", "개장시대용금액", "long", "16")]
		public long OpnmkSubstAmt;
		/// <summary>
		/// 총금액
		/// </summary>
		[XAQueryFieldAttribute("TotAmt", "총금액", "long", "16")]
		public long TotAmt;
		/// <summary>
		/// 예수금
		/// </summary>
		[XAQueryFieldAttribute("Dps", "예수금", "long", "16")]
		public long Dps;
		/// <summary>
		/// 현금미수금액
		/// </summary>
		[XAQueryFieldAttribute("MnyrclAmt", "현금미수금액", "long", "16")]
		public long MnyrclAmt;
		/// <summary>
		/// 대용지정금액
		/// </summary>
		[XAQueryFieldAttribute("SubstDsgnAmt", "대용지정금액", "long", "16")]
		public long SubstDsgnAmt;
		/// <summary>
		/// 위탁증거금액
		/// </summary>
		[XAQueryFieldAttribute("CsgnMgn", "위탁증거금액", "long", "16")]
		public long CsgnMgn;
		/// <summary>
		/// 현금위탁증거금액
		/// </summary>
		[XAQueryFieldAttribute("MnyCsgnMgn", "현금위탁증거금액", "long", "16")]
		public long MnyCsgnMgn;
		/// <summary>
		/// 유지증거금액
		/// </summary>
		[XAQueryFieldAttribute("MaintMgn", "유지증거금액", "long", "16")]
		public long MaintMgn;
		/// <summary>
		/// 현금유지증거금액
		/// </summary>
		[XAQueryFieldAttribute("MnyMaintMgn", "현금유지증거금액", "long", "16")]
		public long MnyMaintMgn;
		/// <summary>
		/// 출금가능총액
		/// </summary>
		[XAQueryFieldAttribute("OutAbleAmt", "출금가능총액", "long", "16")]
		public long OutAbleAmt;
		/// <summary>
		/// 출금가능금액
		/// </summary>
		[XAQueryFieldAttribute("MnyoutAbleAmt", "출금가능금액", "long", "16")]
		public long MnyoutAbleAmt;
		/// <summary>
		/// 출금가능대용
		/// </summary>
		[XAQueryFieldAttribute("SubstOutAbleAmt", "출금가능대용", "long", "16")]
		public long SubstOutAbleAmt;
		/// <summary>
		/// 주문가능금액
		/// </summary>
		[XAQueryFieldAttribute("OrdAbleAmt", "주문가능금액", "long", "16")]
		public long OrdAbleAmt;
		/// <summary>
		/// 현금주문가능금액
		/// </summary>
		[XAQueryFieldAttribute("MnyOrdAbleAmt", "현금주문가능금액", "long", "16")]
		public long MnyOrdAbleAmt;
		/// <summary>
		/// 추가증거금구분
		/// </summary>
		[XAQueryFieldAttribute("AddMgnOcrTpCode", "추가증거금구분", "char", "1")]
		public char AddMgnOcrTpCode;
		/// <summary>
		/// 추가증거금액
		/// </summary>
		[XAQueryFieldAttribute("AddMgn", "추가증거금액", "long", "16")]
		public long AddMgn;
		/// <summary>
		/// 현금추가증거금액
		/// </summary>
		[XAQueryFieldAttribute("MnyAddMgn", "현금추가증거금액", "long", "16")]
		public long MnyAddMgn;
		/// <summary>
		/// 익일예탁총액
		/// </summary>
		[XAQueryFieldAttribute("NtdayTotAmt", "익일예탁총액", "long", "16")]
		public long NtdayTotAmt;
		/// <summary>
		/// 익일예탁현금
		/// </summary>
		[XAQueryFieldAttribute("NtdayDps", "익일예탁현금", "long", "16")]
		public long NtdayDps;
		/// <summary>
		/// 익일미수금
		/// </summary>
		[XAQueryFieldAttribute("NtdayMnyrclAmt", "익일미수금", "long", "16")]
		public long NtdayMnyrclAmt;
		/// <summary>
		/// 익일예탁대용
		/// </summary>
		[XAQueryFieldAttribute("NtdaySubstAmt", "익일예탁대용", "long", "16")]
		public long NtdaySubstAmt;
		/// <summary>
		/// 익일위탁증거금
		/// </summary>
		[XAQueryFieldAttribute("NtdayCsgnMgn", "익일위탁증거금", "long", "16")]
		public long NtdayCsgnMgn;
		/// <summary>
		/// 익일위탁증거금현금
		/// </summary>
		[XAQueryFieldAttribute("NtdayMnyCsgnMgn", "익일위탁증거금현금", "long", "16")]
		public long NtdayMnyCsgnMgn;
		/// <summary>
		/// 익일유지증거금
		/// </summary>
		[XAQueryFieldAttribute("NtdayMaintMgn", "익일유지증거금", "long", "16")]
		public long NtdayMaintMgn;
		/// <summary>
		/// 익일유지증거금현금
		/// </summary>
		[XAQueryFieldAttribute("NtdayMnyMaintMgn", "익일유지증거금현금", "long", "16")]
		public long NtdayMnyMaintMgn;
		/// <summary>
		/// 익일인출가능금액
		/// </summary>
		[XAQueryFieldAttribute("NtdayOutAbleAmt", "익일인출가능금액", "long", "16")]
		public long NtdayOutAbleAmt;
		/// <summary>
		/// 익일인출가능금액
		/// </summary>
		[XAQueryFieldAttribute("NtdayMnyoutAbleAmt", "익일인출가능금액", "long", "16")]
		public long NtdayMnyoutAbleAmt;
		/// <summary>
		/// 익일인출가능대용
		/// </summary>
		[XAQueryFieldAttribute("NtdaySubstOutAbleAmt", "익일인출가능대용", "long", "16")]
		public long NtdaySubstOutAbleAmt;
		/// <summary>
		/// 익일주문가능금액
		/// </summary>
		[XAQueryFieldAttribute("NtdayOrdAbleAmt", "익일주문가능금액", "long", "16")]
		public long NtdayOrdAbleAmt;
		/// <summary>
		/// 익일주문가능현금
		/// </summary>
		[XAQueryFieldAttribute("NtdayMnyOrdAbleAmt", "익일주문가능현금", "long", "16")]
		public long NtdayMnyOrdAbleAmt;
		/// <summary>
		/// 익일추가증거금구분
		/// </summary>
		[XAQueryFieldAttribute("NtdayAddMgnTp", "익일추가증거금구분", "char", "1")]
		public char NtdayAddMgnTp;
		/// <summary>
		/// 익일추가증거금
		/// </summary>
		[XAQueryFieldAttribute("NtdayAddMgn", "익일추가증거금", "long", "16")]
		public long NtdayAddMgn;
		/// <summary>
		/// 익일추가증거금현금
		/// </summary>
		[XAQueryFieldAttribute("NtdayMnyAddMgn", "익일추가증거금현금", "long", "16")]
		public long NtdayMnyAddMgn;
		/// <summary>
		/// 익일결제금액
		/// </summary>
		[XAQueryFieldAttribute("NtdaySettAmt", "익일결제금액", "long", "16")]
		public long NtdaySettAmt;
		/// <summary>
		/// 평가예탁금총액
		/// </summary>
		[XAQueryFieldAttribute("EvalDpsamtTotamt", "평가예탁금총액", "long", "15")]
		public long EvalDpsamtTotamt;
		/// <summary>
		/// 현금평가예탁금액
		/// </summary>
		[XAQueryFieldAttribute("MnyEvalDpstgAmt", "현금평가예탁금액", "long", "15")]
		public long MnyEvalDpstgAmt;
		/// <summary>
		/// 예탁금이용료지급예정금액
		/// </summary>
		[XAQueryFieldAttribute("DpsamtUtlfeeGivPrergAmt", "예탁금이용료지급예정금액", "long", "16")]
		public long DpsamtUtlfeeGivPrergAmt;
		/// <summary>
		/// 세금
		/// </summary>
		[XAQueryFieldAttribute("TaxAmt", "세금", "long", "16")]
		public long TaxAmt;
		/// <summary>
		/// 위탁증거금 비율
		/// </summary>
		[XAQueryFieldAttribute("CsgnMgnrat", "위탁증거금 비율", "double", "7.2")]
		public double CsgnMgnrat;
		/// <summary>
		/// 위탁증거금현금비율
		/// </summary>
		[XAQueryFieldAttribute("CsgnMnyMgnrat", "위탁증거금현금비율", "double", "7.2")]
		public double CsgnMnyMgnrat;
		/// <summary>
		/// 예탁총액부족금액(위탁증거금기준)
		/// </summary>
		[XAQueryFieldAttribute("DpstgTotamtLackAmt", "예탁총액부족금액(위탁증거금기준)", "long", "16")]
		public long DpstgTotamtLackAmt;
		/// <summary>
		/// 예탁현금부족금액(위탁증거금기준)
		/// </summary>
		[XAQueryFieldAttribute("DpstgMnyLackAmt", "예탁현금부족금액(위탁증거금기준)", "long", "16")]
		public long DpstgMnyLackAmt;
		/// <summary>
		/// 실입금액
		/// </summary>
		[XAQueryFieldAttribute("RealInAmt", "실입금액", "long", "16")]
		public long RealInAmt;
		/// <summary>
		/// 입금액
		/// </summary>
		[XAQueryFieldAttribute("InAmt", "입금액", "long", "16")]
		public long InAmt;
		/// <summary>
		/// 출금액
		/// </summary>
		[XAQueryFieldAttribute("OutAmt", "출금액", "long", "16")]
		public long OutAmt;
		/// <summary>
		/// 선물정산차금
		/// </summary>
		[XAQueryFieldAttribute("FutsAdjstDfamt", "선물정산차금", "long", "16")]
		public long FutsAdjstDfamt;
		/// <summary>
		/// 선물당일차금
		/// </summary>
		[XAQueryFieldAttribute("FutsThdayDfamt", "선물당일차금", "long", "16")]
		public long FutsThdayDfamt;
		/// <summary>
		/// 선물갱신차금
		/// </summary>
		[XAQueryFieldAttribute("FutsUpdtDfamt", "선물갱신차금", "long", "16")]
		public long FutsUpdtDfamt;
		/// <summary>
		/// 선물최종결제차금
		/// </summary>
		[XAQueryFieldAttribute("FutsLastSettDfamt", "선물최종결제차금", "long", "16")]
		public long FutsLastSettDfamt;
		/// <summary>
		/// 옵션결제차금
		/// </summary>
		[XAQueryFieldAttribute("OptSettDfamt", "옵션결제차금", "long", "16")]
		public long OptSettDfamt;
		/// <summary>
		/// 옵션매수금액
		/// </summary>
		[XAQueryFieldAttribute("OptBuyAmt", "옵션매수금액", "long", "16")]
		public long OptBuyAmt;
		/// <summary>
		/// 옵션매도금액
		/// </summary>
		[XAQueryFieldAttribute("OptSellAmt", "옵션매도금액", "long", "16")]
		public long OptSellAmt;
		/// <summary>
		/// 옵션행사차금
		/// </summary>
		[XAQueryFieldAttribute("OptXrcDfamt", "옵션행사차금", "long", "16")]
		public long OptXrcDfamt;
		/// <summary>
		/// 옵션배정차금
		/// </summary>
		[XAQueryFieldAttribute("OptAsgnDfamt", "옵션배정차금", "long", "16")]
		public long OptAsgnDfamt;
		/// <summary>
		/// 실물인수도금액
		/// </summary>
		[XAQueryFieldAttribute("RealGdsUndAmt", "실물인수도금액", "long", "16")]
		public long RealGdsUndAmt;
		/// <summary>
		/// 실물인수도배정대금
		/// </summary>
		[XAQueryFieldAttribute("RealGdsUndAsgnAmt", "실물인수도배정대금", "long", "16")]
		public long RealGdsUndAsgnAmt;
		/// <summary>
		/// 실물인수도행사대금
		/// </summary>
		[XAQueryFieldAttribute("RealGdsUndXrcAmt", "실물인수도행사대금", "long", "16")]
		public long RealGdsUndXrcAmt;
		/// <summary>
		/// 수수료
		/// </summary>
		[XAQueryFieldAttribute("CmsnAmt", "수수료", "long", "16")]
		public long CmsnAmt;
		/// <summary>
		/// 선물수수료
		/// </summary>
		[XAQueryFieldAttribute("FutsCmsn", "선물수수료", "long", "16")]
		public long FutsCmsn;
		/// <summary>
		/// 옵션수수료
		/// </summary>
		[XAQueryFieldAttribute("OptCmsn", "옵션수수료", "long", "16")]
		public long OptCmsn;
		/// <summary>
		/// 선물약정수량
		/// </summary>
		[XAQueryFieldAttribute("FutsCtrctQty", "선물약정수량", "long", "16")]
		public long FutsCtrctQty;
		/// <summary>
		/// 선물약정금액
		/// </summary>
		[XAQueryFieldAttribute("FutsCtrctAmt", "선물약정금액", "long", "16")]
		public long FutsCtrctAmt;
		/// <summary>
		/// 옵션약정수량
		/// </summary>
		[XAQueryFieldAttribute("OptCtrctQty", "옵션약정수량", "long", "16")]
		public long OptCtrctQty;
		/// <summary>
		/// 옵션약정금액
		/// </summary>
		[XAQueryFieldAttribute("OptCtrctAmt", "옵션약정금액", "long", "16")]
		public long OptCtrctAmt;
		/// <summary>
		/// 선물미결제수량
		/// </summary>
		[XAQueryFieldAttribute("FutsUnsttQty", "선물미결제수량", "long", "16")]
		public long FutsUnsttQty;
		/// <summary>
		/// 선물미결제금액
		/// </summary>
		[XAQueryFieldAttribute("FutsUnsttAmt", "선물미결제금액", "long", "16")]
		public long FutsUnsttAmt;
		/// <summary>
		/// 옵션미결제수량
		/// </summary>
		[XAQueryFieldAttribute("OptUnsttQty", "옵션미결제수량", "long", "16")]
		public long OptUnsttQty;
		/// <summary>
		/// 옵션미결제금액
		/// </summary>
		[XAQueryFieldAttribute("OptUnsttAmt", "옵션미결제금액", "long", "16")]
		public long OptUnsttAmt;
		/// <summary>
		/// 선물매수미결제수량
		/// </summary>
		[XAQueryFieldAttribute("FutsBuyUnsttQty", "선물매수미결제수량", "long", "16")]
		public long FutsBuyUnsttQty;
		/// <summary>
		/// 선물매수미결제금액
		/// </summary>
		[XAQueryFieldAttribute("FutsBuyUnsttAmt", "선물매수미결제금액", "long", "16")]
		public long FutsBuyUnsttAmt;
		/// <summary>
		/// 선물매도미결제수량
		/// </summary>
		[XAQueryFieldAttribute("FutsSellUnsttQty", "선물매도미결제수량", "long", "16")]
		public long FutsSellUnsttQty;
		/// <summary>
		/// 선물매도미결제금액
		/// </summary>
		[XAQueryFieldAttribute("FutsSellUnsttAmt", "선물매도미결제금액", "long", "16")]
		public long FutsSellUnsttAmt;
		/// <summary>
		/// 옵션매수미결제수량
		/// </summary>
		[XAQueryFieldAttribute("OptBuyUnsttQty", "옵션매수미결제수량", "long", "16")]
		public long OptBuyUnsttQty;
		/// <summary>
		/// 옵션매수미결제금액
		/// </summary>
		[XAQueryFieldAttribute("OptBuyUnsttAmt", "옵션매수미결제금액", "long", "16")]
		public long OptBuyUnsttAmt;
		/// <summary>
		/// 옵션매도미결제수량
		/// </summary>
		[XAQueryFieldAttribute("OptSellUnsttQty", "옵션매도미결제수량", "long", "16")]
		public long OptSellUnsttQty;
		/// <summary>
		/// 옵션매도미결제금액
		/// </summary>
		[XAQueryFieldAttribute("OptSellUnsttAmt", "옵션매도미결제금액", "long", "16")]
		public long OptSellUnsttAmt;
		/// <summary>
		/// 선물매수약정수량
		/// </summary>
		[XAQueryFieldAttribute("FutsBuyctrQty", "선물매수약정수량", "long", "16")]
		public long FutsBuyctrQty;
		/// <summary>
		/// 선물매수약정금액
		/// </summary>
		[XAQueryFieldAttribute("FutsBuyctrAmt", "선물매수약정금액", "long", "16")]
		public long FutsBuyctrAmt;
		/// <summary>
		/// 선물매도약정수량
		/// </summary>
		[XAQueryFieldAttribute("FutsSlctrQty", "선물매도약정수량", "long", "16")]
		public long FutsSlctrQty;
		/// <summary>
		/// 선물매도약정금액
		/// </summary>
		[XAQueryFieldAttribute("FutsSlctrAmt", "선물매도약정금액", "long", "16")]
		public long FutsSlctrAmt;
		/// <summary>
		/// 옵션매수약정수량
		/// </summary>
		[XAQueryFieldAttribute("OptBuyctrQty", "옵션매수약정수량", "long", "16")]
		public long OptBuyctrQty;
		/// <summary>
		/// 옵션매수약정금액
		/// </summary>
		[XAQueryFieldAttribute("OptBuyctrAmt", "옵션매수약정금액", "long", "16")]
		public long OptBuyctrAmt;
		/// <summary>
		/// 옵션매도약정수량
		/// </summary>
		[XAQueryFieldAttribute("OptSlctrQty", "옵션매도약정수량", "long", "16")]
		public long OptSlctrQty;
		/// <summary>
		/// 옵션매도약정금액
		/// </summary>
		[XAQueryFieldAttribute("OptSlctrAmt", "옵션매도약정금액", "long", "16")]
		public long OptSlctrAmt;
		/// <summary>
		/// 선물매매손익금액
		/// </summary>
		[XAQueryFieldAttribute("FutsBnsplAmt", "선물매매손익금액", "long", "16")]
		public long FutsBnsplAmt;
		/// <summary>
		/// 옵션매매손익금액
		/// </summary>
		[XAQueryFieldAttribute("OptBnsplAmt", "옵션매매손익금액", "long", "16")]
		public long OptBnsplAmt;
		/// <summary>
		/// 선물평가손익금액
		/// </summary>
		[XAQueryFieldAttribute("FutsEvalPnlAmt", "선물평가손익금액", "long", "16")]
		public long FutsEvalPnlAmt;
		/// <summary>
		/// 옵션평가손익금액
		/// </summary>
		[XAQueryFieldAttribute("OptEvalPnlAmt", "옵션평가손익금액", "long", "16")]
		public long OptEvalPnlAmt;
		/// <summary>
		/// 선물평가금액
		/// </summary>
		[XAQueryFieldAttribute("FutsEvalAmt", "선물평가금액", "long", "16")]
		public long FutsEvalAmt;
		/// <summary>
		/// 옵션평가금액
		/// </summary>
		[XAQueryFieldAttribute("OptEvalAmt", "옵션평가금액", "long", "16")]
		public long OptEvalAmt;
		/// <summary>
		/// 장종료후현금입금금액
		/// </summary>
		[XAQueryFieldAttribute("MktEndAfMnyInAmt", "장종료후현금입금금액", "long", "16")]
		public long MktEndAfMnyInAmt;
		/// <summary>
		/// 장종료후현금출금금액
		/// </summary>
		[XAQueryFieldAttribute("MktEndAfMnyOutAmt", "장종료후현금출금금액", "long", "16")]
		public long MktEndAfMnyOutAmt;
		/// <summary>
		/// 장종료후대용지정금액
		/// </summary>
		[XAQueryFieldAttribute("MktEndAfSubstDsgnAmt", "장종료후대용지정금액", "long", "16")]
		public long MktEndAfSubstDsgnAmt;
		/// <summary>
		/// 장종료후대용해지금액
		/// </summary>
		[XAQueryFieldAttribute("MktEndAfSubstAbndAmt", "장종료후대용해지금액", "long", "16")]
		public long MktEndAfSubstAbndAmt;

		public static class F
		{
			/// <summary>
			/// 레코드갯수
			/// </summary>
			public const string RecCnt = "RecCnt";
			/// <summary>
			/// 계좌명
			/// </summary>
			public const string AcntNm = "AcntNm";
			/// <summary>
			/// 개장시예탁금총액
			/// </summary>
			public const string OpnmkDpsamtTotamt = "OpnmkDpsamtTotamt";
			/// <summary>
			/// 개장시예수금
			/// </summary>
			public const string OpnmkDps = "OpnmkDps";
			/// <summary>
			/// 개장시현금미수금
			/// </summary>
			public const string OpnmkMnyrclAmt = "OpnmkMnyrclAmt";
			/// <summary>
			/// 개장시대용금액
			/// </summary>
			public const string OpnmkSubstAmt = "OpnmkSubstAmt";
			/// <summary>
			/// 총금액
			/// </summary>
			public const string TotAmt = "TotAmt";
			/// <summary>
			/// 예수금
			/// </summary>
			public const string Dps = "Dps";
			/// <summary>
			/// 현금미수금액
			/// </summary>
			public const string MnyrclAmt = "MnyrclAmt";
			/// <summary>
			/// 대용지정금액
			/// </summary>
			public const string SubstDsgnAmt = "SubstDsgnAmt";
			/// <summary>
			/// 위탁증거금액
			/// </summary>
			public const string CsgnMgn = "CsgnMgn";
			/// <summary>
			/// 현금위탁증거금액
			/// </summary>
			public const string MnyCsgnMgn = "MnyCsgnMgn";
			/// <summary>
			/// 유지증거금액
			/// </summary>
			public const string MaintMgn = "MaintMgn";
			/// <summary>
			/// 현금유지증거금액
			/// </summary>
			public const string MnyMaintMgn = "MnyMaintMgn";
			/// <summary>
			/// 출금가능총액
			/// </summary>
			public const string OutAbleAmt = "OutAbleAmt";
			/// <summary>
			/// 출금가능금액
			/// </summary>
			public const string MnyoutAbleAmt = "MnyoutAbleAmt";
			/// <summary>
			/// 출금가능대용
			/// </summary>
			public const string SubstOutAbleAmt = "SubstOutAbleAmt";
			/// <summary>
			/// 주문가능금액
			/// </summary>
			public const string OrdAbleAmt = "OrdAbleAmt";
			/// <summary>
			/// 현금주문가능금액
			/// </summary>
			public const string MnyOrdAbleAmt = "MnyOrdAbleAmt";
			/// <summary>
			/// 추가증거금구분
			/// </summary>
			public const string AddMgnOcrTpCode = "AddMgnOcrTpCode";
			/// <summary>
			/// 추가증거금액
			/// </summary>
			public const string AddMgn = "AddMgn";
			/// <summary>
			/// 현금추가증거금액
			/// </summary>
			public const string MnyAddMgn = "MnyAddMgn";
			/// <summary>
			/// 익일예탁총액
			/// </summary>
			public const string NtdayTotAmt = "NtdayTotAmt";
			/// <summary>
			/// 익일예탁현금
			/// </summary>
			public const string NtdayDps = "NtdayDps";
			/// <summary>
			/// 익일미수금
			/// </summary>
			public const string NtdayMnyrclAmt = "NtdayMnyrclAmt";
			/// <summary>
			/// 익일예탁대용
			/// </summary>
			public const string NtdaySubstAmt = "NtdaySubstAmt";
			/// <summary>
			/// 익일위탁증거금
			/// </summary>
			public const string NtdayCsgnMgn = "NtdayCsgnMgn";
			/// <summary>
			/// 익일위탁증거금현금
			/// </summary>
			public const string NtdayMnyCsgnMgn = "NtdayMnyCsgnMgn";
			/// <summary>
			/// 익일유지증거금
			/// </summary>
			public const string NtdayMaintMgn = "NtdayMaintMgn";
			/// <summary>
			/// 익일유지증거금현금
			/// </summary>
			public const string NtdayMnyMaintMgn = "NtdayMnyMaintMgn";
			/// <summary>
			/// 익일인출가능금액
			/// </summary>
			public const string NtdayOutAbleAmt = "NtdayOutAbleAmt";
			/// <summary>
			/// 익일인출가능금액
			/// </summary>
			public const string NtdayMnyoutAbleAmt = "NtdayMnyoutAbleAmt";
			/// <summary>
			/// 익일인출가능대용
			/// </summary>
			public const string NtdaySubstOutAbleAmt = "NtdaySubstOutAbleAmt";
			/// <summary>
			/// 익일주문가능금액
			/// </summary>
			public const string NtdayOrdAbleAmt = "NtdayOrdAbleAmt";
			/// <summary>
			/// 익일주문가능현금
			/// </summary>
			public const string NtdayMnyOrdAbleAmt = "NtdayMnyOrdAbleAmt";
			/// <summary>
			/// 익일추가증거금구분
			/// </summary>
			public const string NtdayAddMgnTp = "NtdayAddMgnTp";
			/// <summary>
			/// 익일추가증거금
			/// </summary>
			public const string NtdayAddMgn = "NtdayAddMgn";
			/// <summary>
			/// 익일추가증거금현금
			/// </summary>
			public const string NtdayMnyAddMgn = "NtdayMnyAddMgn";
			/// <summary>
			/// 익일결제금액
			/// </summary>
			public const string NtdaySettAmt = "NtdaySettAmt";
			/// <summary>
			/// 평가예탁금총액
			/// </summary>
			public const string EvalDpsamtTotamt = "EvalDpsamtTotamt";
			/// <summary>
			/// 현금평가예탁금액
			/// </summary>
			public const string MnyEvalDpstgAmt = "MnyEvalDpstgAmt";
			/// <summary>
			/// 예탁금이용료지급예정금액
			/// </summary>
			public const string DpsamtUtlfeeGivPrergAmt = "DpsamtUtlfeeGivPrergAmt";
			/// <summary>
			/// 세금
			/// </summary>
			public const string TaxAmt = "TaxAmt";
			/// <summary>
			/// 위탁증거금 비율
			/// </summary>
			public const string CsgnMgnrat = "CsgnMgnrat";
			/// <summary>
			/// 위탁증거금현금비율
			/// </summary>
			public const string CsgnMnyMgnrat = "CsgnMnyMgnrat";
			/// <summary>
			/// 예탁총액부족금액(위탁증거금기준)
			/// </summary>
			public const string DpstgTotamtLackAmt = "DpstgTotamtLackAmt";
			/// <summary>
			/// 예탁현금부족금액(위탁증거금기준)
			/// </summary>
			public const string DpstgMnyLackAmt = "DpstgMnyLackAmt";
			/// <summary>
			/// 실입금액
			/// </summary>
			public const string RealInAmt = "RealInAmt";
			/// <summary>
			/// 입금액
			/// </summary>
			public const string InAmt = "InAmt";
			/// <summary>
			/// 출금액
			/// </summary>
			public const string OutAmt = "OutAmt";
			/// <summary>
			/// 선물정산차금
			/// </summary>
			public const string FutsAdjstDfamt = "FutsAdjstDfamt";
			/// <summary>
			/// 선물당일차금
			/// </summary>
			public const string FutsThdayDfamt = "FutsThdayDfamt";
			/// <summary>
			/// 선물갱신차금
			/// </summary>
			public const string FutsUpdtDfamt = "FutsUpdtDfamt";
			/// <summary>
			/// 선물최종결제차금
			/// </summary>
			public const string FutsLastSettDfamt = "FutsLastSettDfamt";
			/// <summary>
			/// 옵션결제차금
			/// </summary>
			public const string OptSettDfamt = "OptSettDfamt";
			/// <summary>
			/// 옵션매수금액
			/// </summary>
			public const string OptBuyAmt = "OptBuyAmt";
			/// <summary>
			/// 옵션매도금액
			/// </summary>
			public const string OptSellAmt = "OptSellAmt";
			/// <summary>
			/// 옵션행사차금
			/// </summary>
			public const string OptXrcDfamt = "OptXrcDfamt";
			/// <summary>
			/// 옵션배정차금
			/// </summary>
			public const string OptAsgnDfamt = "OptAsgnDfamt";
			/// <summary>
			/// 실물인수도금액
			/// </summary>
			public const string RealGdsUndAmt = "RealGdsUndAmt";
			/// <summary>
			/// 실물인수도배정대금
			/// </summary>
			public const string RealGdsUndAsgnAmt = "RealGdsUndAsgnAmt";
			/// <summary>
			/// 실물인수도행사대금
			/// </summary>
			public const string RealGdsUndXrcAmt = "RealGdsUndXrcAmt";
			/// <summary>
			/// 수수료
			/// </summary>
			public const string CmsnAmt = "CmsnAmt";
			/// <summary>
			/// 선물수수료
			/// </summary>
			public const string FutsCmsn = "FutsCmsn";
			/// <summary>
			/// 옵션수수료
			/// </summary>
			public const string OptCmsn = "OptCmsn";
			/// <summary>
			/// 선물약정수량
			/// </summary>
			public const string FutsCtrctQty = "FutsCtrctQty";
			/// <summary>
			/// 선물약정금액
			/// </summary>
			public const string FutsCtrctAmt = "FutsCtrctAmt";
			/// <summary>
			/// 옵션약정수량
			/// </summary>
			public const string OptCtrctQty = "OptCtrctQty";
			/// <summary>
			/// 옵션약정금액
			/// </summary>
			public const string OptCtrctAmt = "OptCtrctAmt";
			/// <summary>
			/// 선물미결제수량
			/// </summary>
			public const string FutsUnsttQty = "FutsUnsttQty";
			/// <summary>
			/// 선물미결제금액
			/// </summary>
			public const string FutsUnsttAmt = "FutsUnsttAmt";
			/// <summary>
			/// 옵션미결제수량
			/// </summary>
			public const string OptUnsttQty = "OptUnsttQty";
			/// <summary>
			/// 옵션미결제금액
			/// </summary>
			public const string OptUnsttAmt = "OptUnsttAmt";
			/// <summary>
			/// 선물매수미결제수량
			/// </summary>
			public const string FutsBuyUnsttQty = "FutsBuyUnsttQty";
			/// <summary>
			/// 선물매수미결제금액
			/// </summary>
			public const string FutsBuyUnsttAmt = "FutsBuyUnsttAmt";
			/// <summary>
			/// 선물매도미결제수량
			/// </summary>
			public const string FutsSellUnsttQty = "FutsSellUnsttQty";
			/// <summary>
			/// 선물매도미결제금액
			/// </summary>
			public const string FutsSellUnsttAmt = "FutsSellUnsttAmt";
			/// <summary>
			/// 옵션매수미결제수량
			/// </summary>
			public const string OptBuyUnsttQty = "OptBuyUnsttQty";
			/// <summary>
			/// 옵션매수미결제금액
			/// </summary>
			public const string OptBuyUnsttAmt = "OptBuyUnsttAmt";
			/// <summary>
			/// 옵션매도미결제수량
			/// </summary>
			public const string OptSellUnsttQty = "OptSellUnsttQty";
			/// <summary>
			/// 옵션매도미결제금액
			/// </summary>
			public const string OptSellUnsttAmt = "OptSellUnsttAmt";
			/// <summary>
			/// 선물매수약정수량
			/// </summary>
			public const string FutsBuyctrQty = "FutsBuyctrQty";
			/// <summary>
			/// 선물매수약정금액
			/// </summary>
			public const string FutsBuyctrAmt = "FutsBuyctrAmt";
			/// <summary>
			/// 선물매도약정수량
			/// </summary>
			public const string FutsSlctrQty = "FutsSlctrQty";
			/// <summary>
			/// 선물매도약정금액
			/// </summary>
			public const string FutsSlctrAmt = "FutsSlctrAmt";
			/// <summary>
			/// 옵션매수약정수량
			/// </summary>
			public const string OptBuyctrQty = "OptBuyctrQty";
			/// <summary>
			/// 옵션매수약정금액
			/// </summary>
			public const string OptBuyctrAmt = "OptBuyctrAmt";
			/// <summary>
			/// 옵션매도약정수량
			/// </summary>
			public const string OptSlctrQty = "OptSlctrQty";
			/// <summary>
			/// 옵션매도약정금액
			/// </summary>
			public const string OptSlctrAmt = "OptSlctrAmt";
			/// <summary>
			/// 선물매매손익금액
			/// </summary>
			public const string FutsBnsplAmt = "FutsBnsplAmt";
			/// <summary>
			/// 옵션매매손익금액
			/// </summary>
			public const string OptBnsplAmt = "OptBnsplAmt";
			/// <summary>
			/// 선물평가손익금액
			/// </summary>
			public const string FutsEvalPnlAmt = "FutsEvalPnlAmt";
			/// <summary>
			/// 옵션평가손익금액
			/// </summary>
			public const string OptEvalPnlAmt = "OptEvalPnlAmt";
			/// <summary>
			/// 선물평가금액
			/// </summary>
			public const string FutsEvalAmt = "FutsEvalAmt";
			/// <summary>
			/// 옵션평가금액
			/// </summary>
			public const string OptEvalAmt = "OptEvalAmt";
			/// <summary>
			/// 장종료후현금입금금액
			/// </summary>
			public const string MktEndAfMnyInAmt = "MktEndAfMnyInAmt";
			/// <summary>
			/// 장종료후현금출금금액
			/// </summary>
			public const string MktEndAfMnyOutAmt = "MktEndAfMnyOutAmt";
			/// <summary>
			/// 장종료후대용지정금액
			/// </summary>
			public const string MktEndAfSubstDsgnAmt = "MktEndAfSubstDsgnAmt";
			/// <summary>
			/// 장종료후대용해지금액
			/// </summary>
			public const string MktEndAfSubstAbndAmt = "MktEndAfSubstAbndAmt";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.AcntNm,
			F.OpnmkDpsamtTotamt,
			F.OpnmkDps,
			F.OpnmkMnyrclAmt,
			F.OpnmkSubstAmt,
			F.TotAmt,
			F.Dps,
			F.MnyrclAmt,
			F.SubstDsgnAmt,
			F.CsgnMgn,
			F.MnyCsgnMgn,
			F.MaintMgn,
			F.MnyMaintMgn,
			F.OutAbleAmt,
			F.MnyoutAbleAmt,
			F.SubstOutAbleAmt,
			F.OrdAbleAmt,
			F.MnyOrdAbleAmt,
			F.AddMgnOcrTpCode,
			F.AddMgn,
			F.MnyAddMgn,
			F.NtdayTotAmt,
			F.NtdayDps,
			F.NtdayMnyrclAmt,
			F.NtdaySubstAmt,
			F.NtdayCsgnMgn,
			F.NtdayMnyCsgnMgn,
			F.NtdayMaintMgn,
			F.NtdayMnyMaintMgn,
			F.NtdayOutAbleAmt,
			F.NtdayMnyoutAbleAmt,
			F.NtdaySubstOutAbleAmt,
			F.NtdayOrdAbleAmt,
			F.NtdayMnyOrdAbleAmt,
			F.NtdayAddMgnTp,
			F.NtdayAddMgn,
			F.NtdayMnyAddMgn,
			F.NtdaySettAmt,
			F.EvalDpsamtTotamt,
			F.MnyEvalDpstgAmt,
			F.DpsamtUtlfeeGivPrergAmt,
			F.TaxAmt,
			F.CsgnMgnrat,
			F.CsgnMnyMgnrat,
			F.DpstgTotamtLackAmt,
			F.DpstgMnyLackAmt,
			F.RealInAmt,
			F.InAmt,
			F.OutAmt,
			F.FutsAdjstDfamt,
			F.FutsThdayDfamt,
			F.FutsUpdtDfamt,
			F.FutsLastSettDfamt,
			F.OptSettDfamt,
			F.OptBuyAmt,
			F.OptSellAmt,
			F.OptXrcDfamt,
			F.OptAsgnDfamt,
			F.RealGdsUndAmt,
			F.RealGdsUndAsgnAmt,
			F.RealGdsUndXrcAmt,
			F.CmsnAmt,
			F.FutsCmsn,
			F.OptCmsn,
			F.FutsCtrctQty,
			F.FutsCtrctAmt,
			F.OptCtrctQty,
			F.OptCtrctAmt,
			F.FutsUnsttQty,
			F.FutsUnsttAmt,
			F.OptUnsttQty,
			F.OptUnsttAmt,
			F.FutsBuyUnsttQty,
			F.FutsBuyUnsttAmt,
			F.FutsSellUnsttQty,
			F.FutsSellUnsttAmt,
			F.OptBuyUnsttQty,
			F.OptBuyUnsttAmt,
			F.OptSellUnsttQty,
			F.OptSellUnsttAmt,
			F.FutsBuyctrQty,
			F.FutsBuyctrAmt,
			F.FutsSlctrQty,
			F.FutsSlctrAmt,
			F.OptBuyctrQty,
			F.OptBuyctrAmt,
			F.OptSlctrQty,
			F.OptSlctrAmt,
			F.FutsBnsplAmt,
			F.OptBnsplAmt,
			F.FutsEvalPnlAmt,
			F.OptEvalPnlAmt,
			F.FutsEvalAmt,
			F.OptEvalAmt,
			F.MktEndAfMnyInAmt,
			F.MktEndAfMnyOutAmt,
			F.MktEndAfSubstDsgnAmt,
			F.MktEndAfSubstAbndAmt,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["AcntNm"] = new XAQueryFieldInfo("char", AcntNm, AcntNm, "계좌명", (decimal)40);
			dict["OpnmkDpsamtTotamt"] = new XAQueryFieldInfo("long", OpnmkDpsamtTotamt, OpnmkDpsamtTotamt.ToString("d16"), "개장시예탁금총액", (decimal)16);
			dict["OpnmkDps"] = new XAQueryFieldInfo("long", OpnmkDps, OpnmkDps.ToString("d16"), "개장시예수금", (decimal)16);
			dict["OpnmkMnyrclAmt"] = new XAQueryFieldInfo("long", OpnmkMnyrclAmt, OpnmkMnyrclAmt.ToString("d16"), "개장시현금미수금", (decimal)16);
			dict["OpnmkSubstAmt"] = new XAQueryFieldInfo("long", OpnmkSubstAmt, OpnmkSubstAmt.ToString("d16"), "개장시대용금액", (decimal)16);
			dict["TotAmt"] = new XAQueryFieldInfo("long", TotAmt, TotAmt.ToString("d16"), "총금액", (decimal)16);
			dict["Dps"] = new XAQueryFieldInfo("long", Dps, Dps.ToString("d16"), "예수금", (decimal)16);
			dict["MnyrclAmt"] = new XAQueryFieldInfo("long", MnyrclAmt, MnyrclAmt.ToString("d16"), "현금미수금액", (decimal)16);
			dict["SubstDsgnAmt"] = new XAQueryFieldInfo("long", SubstDsgnAmt, SubstDsgnAmt.ToString("d16"), "대용지정금액", (decimal)16);
			dict["CsgnMgn"] = new XAQueryFieldInfo("long", CsgnMgn, CsgnMgn.ToString("d16"), "위탁증거금액", (decimal)16);
			dict["MnyCsgnMgn"] = new XAQueryFieldInfo("long", MnyCsgnMgn, MnyCsgnMgn.ToString("d16"), "현금위탁증거금액", (decimal)16);
			dict["MaintMgn"] = new XAQueryFieldInfo("long", MaintMgn, MaintMgn.ToString("d16"), "유지증거금액", (decimal)16);
			dict["MnyMaintMgn"] = new XAQueryFieldInfo("long", MnyMaintMgn, MnyMaintMgn.ToString("d16"), "현금유지증거금액", (decimal)16);
			dict["OutAbleAmt"] = new XAQueryFieldInfo("long", OutAbleAmt, OutAbleAmt.ToString("d16"), "출금가능총액", (decimal)16);
			dict["MnyoutAbleAmt"] = new XAQueryFieldInfo("long", MnyoutAbleAmt, MnyoutAbleAmt.ToString("d16"), "출금가능금액", (decimal)16);
			dict["SubstOutAbleAmt"] = new XAQueryFieldInfo("long", SubstOutAbleAmt, SubstOutAbleAmt.ToString("d16"), "출금가능대용", (decimal)16);
			dict["OrdAbleAmt"] = new XAQueryFieldInfo("long", OrdAbleAmt, OrdAbleAmt.ToString("d16"), "주문가능금액", (decimal)16);
			dict["MnyOrdAbleAmt"] = new XAQueryFieldInfo("long", MnyOrdAbleAmt, MnyOrdAbleAmt.ToString("d16"), "현금주문가능금액", (decimal)16);
			dict["AddMgnOcrTpCode"] = new XAQueryFieldInfo("char", AddMgnOcrTpCode, AddMgnOcrTpCode.ToString(), "추가증거금구분", (decimal)1);
			dict["AddMgn"] = new XAQueryFieldInfo("long", AddMgn, AddMgn.ToString("d16"), "추가증거금액", (decimal)16);
			dict["MnyAddMgn"] = new XAQueryFieldInfo("long", MnyAddMgn, MnyAddMgn.ToString("d16"), "현금추가증거금액", (decimal)16);
			dict["NtdayTotAmt"] = new XAQueryFieldInfo("long", NtdayTotAmt, NtdayTotAmt.ToString("d16"), "익일예탁총액", (decimal)16);
			dict["NtdayDps"] = new XAQueryFieldInfo("long", NtdayDps, NtdayDps.ToString("d16"), "익일예탁현금", (decimal)16);
			dict["NtdayMnyrclAmt"] = new XAQueryFieldInfo("long", NtdayMnyrclAmt, NtdayMnyrclAmt.ToString("d16"), "익일미수금", (decimal)16);
			dict["NtdaySubstAmt"] = new XAQueryFieldInfo("long", NtdaySubstAmt, NtdaySubstAmt.ToString("d16"), "익일예탁대용", (decimal)16);
			dict["NtdayCsgnMgn"] = new XAQueryFieldInfo("long", NtdayCsgnMgn, NtdayCsgnMgn.ToString("d16"), "익일위탁증거금", (decimal)16);
			dict["NtdayMnyCsgnMgn"] = new XAQueryFieldInfo("long", NtdayMnyCsgnMgn, NtdayMnyCsgnMgn.ToString("d16"), "익일위탁증거금현금", (decimal)16);
			dict["NtdayMaintMgn"] = new XAQueryFieldInfo("long", NtdayMaintMgn, NtdayMaintMgn.ToString("d16"), "익일유지증거금", (decimal)16);
			dict["NtdayMnyMaintMgn"] = new XAQueryFieldInfo("long", NtdayMnyMaintMgn, NtdayMnyMaintMgn.ToString("d16"), "익일유지증거금현금", (decimal)16);
			dict["NtdayOutAbleAmt"] = new XAQueryFieldInfo("long", NtdayOutAbleAmt, NtdayOutAbleAmt.ToString("d16"), "익일인출가능금액", (decimal)16);
			dict["NtdayMnyoutAbleAmt"] = new XAQueryFieldInfo("long", NtdayMnyoutAbleAmt, NtdayMnyoutAbleAmt.ToString("d16"), "익일인출가능금액", (decimal)16);
			dict["NtdaySubstOutAbleAmt"] = new XAQueryFieldInfo("long", NtdaySubstOutAbleAmt, NtdaySubstOutAbleAmt.ToString("d16"), "익일인출가능대용", (decimal)16);
			dict["NtdayOrdAbleAmt"] = new XAQueryFieldInfo("long", NtdayOrdAbleAmt, NtdayOrdAbleAmt.ToString("d16"), "익일주문가능금액", (decimal)16);
			dict["NtdayMnyOrdAbleAmt"] = new XAQueryFieldInfo("long", NtdayMnyOrdAbleAmt, NtdayMnyOrdAbleAmt.ToString("d16"), "익일주문가능현금", (decimal)16);
			dict["NtdayAddMgnTp"] = new XAQueryFieldInfo("char", NtdayAddMgnTp, NtdayAddMgnTp.ToString(), "익일추가증거금구분", (decimal)1);
			dict["NtdayAddMgn"] = new XAQueryFieldInfo("long", NtdayAddMgn, NtdayAddMgn.ToString("d16"), "익일추가증거금", (decimal)16);
			dict["NtdayMnyAddMgn"] = new XAQueryFieldInfo("long", NtdayMnyAddMgn, NtdayMnyAddMgn.ToString("d16"), "익일추가증거금현금", (decimal)16);
			dict["NtdaySettAmt"] = new XAQueryFieldInfo("long", NtdaySettAmt, NtdaySettAmt.ToString("d16"), "익일결제금액", (decimal)16);
			dict["EvalDpsamtTotamt"] = new XAQueryFieldInfo("long", EvalDpsamtTotamt, EvalDpsamtTotamt.ToString("d15"), "평가예탁금총액", (decimal)15);
			dict["MnyEvalDpstgAmt"] = new XAQueryFieldInfo("long", MnyEvalDpstgAmt, MnyEvalDpstgAmt.ToString("d15"), "현금평가예탁금액", (decimal)15);
			dict["DpsamtUtlfeeGivPrergAmt"] = new XAQueryFieldInfo("long", DpsamtUtlfeeGivPrergAmt, DpsamtUtlfeeGivPrergAmt.ToString("d16"), "예탁금이용료지급예정금액", (decimal)16);
			dict["TaxAmt"] = new XAQueryFieldInfo("long", TaxAmt, TaxAmt.ToString("d16"), "세금", (decimal)16);
			dict["CsgnMgnrat"] = new XAQueryFieldInfo("double", CsgnMgnrat, CsgnMgnrat.ToString("0000000.00"), "위탁증거금 비율", (decimal)7.2);
			dict["CsgnMnyMgnrat"] = new XAQueryFieldInfo("double", CsgnMnyMgnrat, CsgnMnyMgnrat.ToString("0000000.00"), "위탁증거금현금비율", (decimal)7.2);
			dict["DpstgTotamtLackAmt"] = new XAQueryFieldInfo("long", DpstgTotamtLackAmt, DpstgTotamtLackAmt.ToString("d16"), "예탁총액부족금액(위탁증거금기준)", (decimal)16);
			dict["DpstgMnyLackAmt"] = new XAQueryFieldInfo("long", DpstgMnyLackAmt, DpstgMnyLackAmt.ToString("d16"), "예탁현금부족금액(위탁증거금기준)", (decimal)16);
			dict["RealInAmt"] = new XAQueryFieldInfo("long", RealInAmt, RealInAmt.ToString("d16"), "실입금액", (decimal)16);
			dict["InAmt"] = new XAQueryFieldInfo("long", InAmt, InAmt.ToString("d16"), "입금액", (decimal)16);
			dict["OutAmt"] = new XAQueryFieldInfo("long", OutAmt, OutAmt.ToString("d16"), "출금액", (decimal)16);
			dict["FutsAdjstDfamt"] = new XAQueryFieldInfo("long", FutsAdjstDfamt, FutsAdjstDfamt.ToString("d16"), "선물정산차금", (decimal)16);
			dict["FutsThdayDfamt"] = new XAQueryFieldInfo("long", FutsThdayDfamt, FutsThdayDfamt.ToString("d16"), "선물당일차금", (decimal)16);
			dict["FutsUpdtDfamt"] = new XAQueryFieldInfo("long", FutsUpdtDfamt, FutsUpdtDfamt.ToString("d16"), "선물갱신차금", (decimal)16);
			dict["FutsLastSettDfamt"] = new XAQueryFieldInfo("long", FutsLastSettDfamt, FutsLastSettDfamt.ToString("d16"), "선물최종결제차금", (decimal)16);
			dict["OptSettDfamt"] = new XAQueryFieldInfo("long", OptSettDfamt, OptSettDfamt.ToString("d16"), "옵션결제차금", (decimal)16);
			dict["OptBuyAmt"] = new XAQueryFieldInfo("long", OptBuyAmt, OptBuyAmt.ToString("d16"), "옵션매수금액", (decimal)16);
			dict["OptSellAmt"] = new XAQueryFieldInfo("long", OptSellAmt, OptSellAmt.ToString("d16"), "옵션매도금액", (decimal)16);
			dict["OptXrcDfamt"] = new XAQueryFieldInfo("long", OptXrcDfamt, OptXrcDfamt.ToString("d16"), "옵션행사차금", (decimal)16);
			dict["OptAsgnDfamt"] = new XAQueryFieldInfo("long", OptAsgnDfamt, OptAsgnDfamt.ToString("d16"), "옵션배정차금", (decimal)16);
			dict["RealGdsUndAmt"] = new XAQueryFieldInfo("long", RealGdsUndAmt, RealGdsUndAmt.ToString("d16"), "실물인수도금액", (decimal)16);
			dict["RealGdsUndAsgnAmt"] = new XAQueryFieldInfo("long", RealGdsUndAsgnAmt, RealGdsUndAsgnAmt.ToString("d16"), "실물인수도배정대금", (decimal)16);
			dict["RealGdsUndXrcAmt"] = new XAQueryFieldInfo("long", RealGdsUndXrcAmt, RealGdsUndXrcAmt.ToString("d16"), "실물인수도행사대금", (decimal)16);
			dict["CmsnAmt"] = new XAQueryFieldInfo("long", CmsnAmt, CmsnAmt.ToString("d16"), "수수료", (decimal)16);
			dict["FutsCmsn"] = new XAQueryFieldInfo("long", FutsCmsn, FutsCmsn.ToString("d16"), "선물수수료", (decimal)16);
			dict["OptCmsn"] = new XAQueryFieldInfo("long", OptCmsn, OptCmsn.ToString("d16"), "옵션수수료", (decimal)16);
			dict["FutsCtrctQty"] = new XAQueryFieldInfo("long", FutsCtrctQty, FutsCtrctQty.ToString("d16"), "선물약정수량", (decimal)16);
			dict["FutsCtrctAmt"] = new XAQueryFieldInfo("long", FutsCtrctAmt, FutsCtrctAmt.ToString("d16"), "선물약정금액", (decimal)16);
			dict["OptCtrctQty"] = new XAQueryFieldInfo("long", OptCtrctQty, OptCtrctQty.ToString("d16"), "옵션약정수량", (decimal)16);
			dict["OptCtrctAmt"] = new XAQueryFieldInfo("long", OptCtrctAmt, OptCtrctAmt.ToString("d16"), "옵션약정금액", (decimal)16);
			dict["FutsUnsttQty"] = new XAQueryFieldInfo("long", FutsUnsttQty, FutsUnsttQty.ToString("d16"), "선물미결제수량", (decimal)16);
			dict["FutsUnsttAmt"] = new XAQueryFieldInfo("long", FutsUnsttAmt, FutsUnsttAmt.ToString("d16"), "선물미결제금액", (decimal)16);
			dict["OptUnsttQty"] = new XAQueryFieldInfo("long", OptUnsttQty, OptUnsttQty.ToString("d16"), "옵션미결제수량", (decimal)16);
			dict["OptUnsttAmt"] = new XAQueryFieldInfo("long", OptUnsttAmt, OptUnsttAmt.ToString("d16"), "옵션미결제금액", (decimal)16);
			dict["FutsBuyUnsttQty"] = new XAQueryFieldInfo("long", FutsBuyUnsttQty, FutsBuyUnsttQty.ToString("d16"), "선물매수미결제수량", (decimal)16);
			dict["FutsBuyUnsttAmt"] = new XAQueryFieldInfo("long", FutsBuyUnsttAmt, FutsBuyUnsttAmt.ToString("d16"), "선물매수미결제금액", (decimal)16);
			dict["FutsSellUnsttQty"] = new XAQueryFieldInfo("long", FutsSellUnsttQty, FutsSellUnsttQty.ToString("d16"), "선물매도미결제수량", (decimal)16);
			dict["FutsSellUnsttAmt"] = new XAQueryFieldInfo("long", FutsSellUnsttAmt, FutsSellUnsttAmt.ToString("d16"), "선물매도미결제금액", (decimal)16);
			dict["OptBuyUnsttQty"] = new XAQueryFieldInfo("long", OptBuyUnsttQty, OptBuyUnsttQty.ToString("d16"), "옵션매수미결제수량", (decimal)16);
			dict["OptBuyUnsttAmt"] = new XAQueryFieldInfo("long", OptBuyUnsttAmt, OptBuyUnsttAmt.ToString("d16"), "옵션매수미결제금액", (decimal)16);
			dict["OptSellUnsttQty"] = new XAQueryFieldInfo("long", OptSellUnsttQty, OptSellUnsttQty.ToString("d16"), "옵션매도미결제수량", (decimal)16);
			dict["OptSellUnsttAmt"] = new XAQueryFieldInfo("long", OptSellUnsttAmt, OptSellUnsttAmt.ToString("d16"), "옵션매도미결제금액", (decimal)16);
			dict["FutsBuyctrQty"] = new XAQueryFieldInfo("long", FutsBuyctrQty, FutsBuyctrQty.ToString("d16"), "선물매수약정수량", (decimal)16);
			dict["FutsBuyctrAmt"] = new XAQueryFieldInfo("long", FutsBuyctrAmt, FutsBuyctrAmt.ToString("d16"), "선물매수약정금액", (decimal)16);
			dict["FutsSlctrQty"] = new XAQueryFieldInfo("long", FutsSlctrQty, FutsSlctrQty.ToString("d16"), "선물매도약정수량", (decimal)16);
			dict["FutsSlctrAmt"] = new XAQueryFieldInfo("long", FutsSlctrAmt, FutsSlctrAmt.ToString("d16"), "선물매도약정금액", (decimal)16);
			dict["OptBuyctrQty"] = new XAQueryFieldInfo("long", OptBuyctrQty, OptBuyctrQty.ToString("d16"), "옵션매수약정수량", (decimal)16);
			dict["OptBuyctrAmt"] = new XAQueryFieldInfo("long", OptBuyctrAmt, OptBuyctrAmt.ToString("d16"), "옵션매수약정금액", (decimal)16);
			dict["OptSlctrQty"] = new XAQueryFieldInfo("long", OptSlctrQty, OptSlctrQty.ToString("d16"), "옵션매도약정수량", (decimal)16);
			dict["OptSlctrAmt"] = new XAQueryFieldInfo("long", OptSlctrAmt, OptSlctrAmt.ToString("d16"), "옵션매도약정금액", (decimal)16);
			dict["FutsBnsplAmt"] = new XAQueryFieldInfo("long", FutsBnsplAmt, FutsBnsplAmt.ToString("d16"), "선물매매손익금액", (decimal)16);
			dict["OptBnsplAmt"] = new XAQueryFieldInfo("long", OptBnsplAmt, OptBnsplAmt.ToString("d16"), "옵션매매손익금액", (decimal)16);
			dict["FutsEvalPnlAmt"] = new XAQueryFieldInfo("long", FutsEvalPnlAmt, FutsEvalPnlAmt.ToString("d16"), "선물평가손익금액", (decimal)16);
			dict["OptEvalPnlAmt"] = new XAQueryFieldInfo("long", OptEvalPnlAmt, OptEvalPnlAmt.ToString("d16"), "옵션평가손익금액", (decimal)16);
			dict["FutsEvalAmt"] = new XAQueryFieldInfo("long", FutsEvalAmt, FutsEvalAmt.ToString("d16"), "선물평가금액", (decimal)16);
			dict["OptEvalAmt"] = new XAQueryFieldInfo("long", OptEvalAmt, OptEvalAmt.ToString("d16"), "옵션평가금액", (decimal)16);
			dict["MktEndAfMnyInAmt"] = new XAQueryFieldInfo("long", MktEndAfMnyInAmt, MktEndAfMnyInAmt.ToString("d16"), "장종료후현금입금금액", (decimal)16);
			dict["MktEndAfMnyOutAmt"] = new XAQueryFieldInfo("long", MktEndAfMnyOutAmt, MktEndAfMnyOutAmt.ToString("d16"), "장종료후현금출금금액", (decimal)16);
			dict["MktEndAfSubstDsgnAmt"] = new XAQueryFieldInfo("long", MktEndAfSubstDsgnAmt, MktEndAfSubstDsgnAmt.ToString("d16"), "장종료후대용지정금액", (decimal)16);
			dict["MktEndAfSubstAbndAmt"] = new XAQueryFieldInfo("long", MktEndAfSubstAbndAmt, MktEndAfSubstAbndAmt.ToString("d16"), "장종료후대용해지금액", (decimal)16);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "RecCnt":
					this.RecCnt = fieldInfo.FieldValue.ParseLong("RecCnt");
				break;

				case "AcntNm":
					this.AcntNm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "OpnmkDpsamtTotamt":
					this.OpnmkDpsamtTotamt = fieldInfo.FieldValue.ParseLong("OpnmkDpsamtTotamt");
				break;

				case "OpnmkDps":
					this.OpnmkDps = fieldInfo.FieldValue.ParseLong("OpnmkDps");
				break;

				case "OpnmkMnyrclAmt":
					this.OpnmkMnyrclAmt = fieldInfo.FieldValue.ParseLong("OpnmkMnyrclAmt");
				break;

				case "OpnmkSubstAmt":
					this.OpnmkSubstAmt = fieldInfo.FieldValue.ParseLong("OpnmkSubstAmt");
				break;

				case "TotAmt":
					this.TotAmt = fieldInfo.FieldValue.ParseLong("TotAmt");
				break;

				case "Dps":
					this.Dps = fieldInfo.FieldValue.ParseLong("Dps");
				break;

				case "MnyrclAmt":
					this.MnyrclAmt = fieldInfo.FieldValue.ParseLong("MnyrclAmt");
				break;

				case "SubstDsgnAmt":
					this.SubstDsgnAmt = fieldInfo.FieldValue.ParseLong("SubstDsgnAmt");
				break;

				case "CsgnMgn":
					this.CsgnMgn = fieldInfo.FieldValue.ParseLong("CsgnMgn");
				break;

				case "MnyCsgnMgn":
					this.MnyCsgnMgn = fieldInfo.FieldValue.ParseLong("MnyCsgnMgn");
				break;

				case "MaintMgn":
					this.MaintMgn = fieldInfo.FieldValue.ParseLong("MaintMgn");
				break;

				case "MnyMaintMgn":
					this.MnyMaintMgn = fieldInfo.FieldValue.ParseLong("MnyMaintMgn");
				break;

				case "OutAbleAmt":
					this.OutAbleAmt = fieldInfo.FieldValue.ParseLong("OutAbleAmt");
				break;

				case "MnyoutAbleAmt":
					this.MnyoutAbleAmt = fieldInfo.FieldValue.ParseLong("MnyoutAbleAmt");
				break;

				case "SubstOutAbleAmt":
					this.SubstOutAbleAmt = fieldInfo.FieldValue.ParseLong("SubstOutAbleAmt");
				break;

				case "OrdAbleAmt":
					this.OrdAbleAmt = fieldInfo.FieldValue.ParseLong("OrdAbleAmt");
				break;

				case "MnyOrdAbleAmt":
					this.MnyOrdAbleAmt = fieldInfo.FieldValue.ParseLong("MnyOrdAbleAmt");
				break;

				case "AddMgnOcrTpCode":
					this.AddMgnOcrTpCode = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "AddMgn":
					this.AddMgn = fieldInfo.FieldValue.ParseLong("AddMgn");
				break;

				case "MnyAddMgn":
					this.MnyAddMgn = fieldInfo.FieldValue.ParseLong("MnyAddMgn");
				break;

				case "NtdayTotAmt":
					this.NtdayTotAmt = fieldInfo.FieldValue.ParseLong("NtdayTotAmt");
				break;

				case "NtdayDps":
					this.NtdayDps = fieldInfo.FieldValue.ParseLong("NtdayDps");
				break;

				case "NtdayMnyrclAmt":
					this.NtdayMnyrclAmt = fieldInfo.FieldValue.ParseLong("NtdayMnyrclAmt");
				break;

				case "NtdaySubstAmt":
					this.NtdaySubstAmt = fieldInfo.FieldValue.ParseLong("NtdaySubstAmt");
				break;

				case "NtdayCsgnMgn":
					this.NtdayCsgnMgn = fieldInfo.FieldValue.ParseLong("NtdayCsgnMgn");
				break;

				case "NtdayMnyCsgnMgn":
					this.NtdayMnyCsgnMgn = fieldInfo.FieldValue.ParseLong("NtdayMnyCsgnMgn");
				break;

				case "NtdayMaintMgn":
					this.NtdayMaintMgn = fieldInfo.FieldValue.ParseLong("NtdayMaintMgn");
				break;

				case "NtdayMnyMaintMgn":
					this.NtdayMnyMaintMgn = fieldInfo.FieldValue.ParseLong("NtdayMnyMaintMgn");
				break;

				case "NtdayOutAbleAmt":
					this.NtdayOutAbleAmt = fieldInfo.FieldValue.ParseLong("NtdayOutAbleAmt");
				break;

				case "NtdayMnyoutAbleAmt":
					this.NtdayMnyoutAbleAmt = fieldInfo.FieldValue.ParseLong("NtdayMnyoutAbleAmt");
				break;

				case "NtdaySubstOutAbleAmt":
					this.NtdaySubstOutAbleAmt = fieldInfo.FieldValue.ParseLong("NtdaySubstOutAbleAmt");
				break;

				case "NtdayOrdAbleAmt":
					this.NtdayOrdAbleAmt = fieldInfo.FieldValue.ParseLong("NtdayOrdAbleAmt");
				break;

				case "NtdayMnyOrdAbleAmt":
					this.NtdayMnyOrdAbleAmt = fieldInfo.FieldValue.ParseLong("NtdayMnyOrdAbleAmt");
				break;

				case "NtdayAddMgnTp":
					this.NtdayAddMgnTp = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "NtdayAddMgn":
					this.NtdayAddMgn = fieldInfo.FieldValue.ParseLong("NtdayAddMgn");
				break;

				case "NtdayMnyAddMgn":
					this.NtdayMnyAddMgn = fieldInfo.FieldValue.ParseLong("NtdayMnyAddMgn");
				break;

				case "NtdaySettAmt":
					this.NtdaySettAmt = fieldInfo.FieldValue.ParseLong("NtdaySettAmt");
				break;

				case "EvalDpsamtTotamt":
					this.EvalDpsamtTotamt = fieldInfo.FieldValue.ParseLong("EvalDpsamtTotamt");
				break;

				case "MnyEvalDpstgAmt":
					this.MnyEvalDpstgAmt = fieldInfo.FieldValue.ParseLong("MnyEvalDpstgAmt");
				break;

				case "DpsamtUtlfeeGivPrergAmt":
					this.DpsamtUtlfeeGivPrergAmt = fieldInfo.FieldValue.ParseLong("DpsamtUtlfeeGivPrergAmt");
				break;

				case "TaxAmt":
					this.TaxAmt = fieldInfo.FieldValue.ParseLong("TaxAmt");
				break;

				case "CsgnMgnrat":
					this.CsgnMgnrat = fieldInfo.FieldValue.ParseDouble("CsgnMgnrat");
				break;

				case "CsgnMnyMgnrat":
					this.CsgnMnyMgnrat = fieldInfo.FieldValue.ParseDouble("CsgnMnyMgnrat");
				break;

				case "DpstgTotamtLackAmt":
					this.DpstgTotamtLackAmt = fieldInfo.FieldValue.ParseLong("DpstgTotamtLackAmt");
				break;

				case "DpstgMnyLackAmt":
					this.DpstgMnyLackAmt = fieldInfo.FieldValue.ParseLong("DpstgMnyLackAmt");
				break;

				case "RealInAmt":
					this.RealInAmt = fieldInfo.FieldValue.ParseLong("RealInAmt");
				break;

				case "InAmt":
					this.InAmt = fieldInfo.FieldValue.ParseLong("InAmt");
				break;

				case "OutAmt":
					this.OutAmt = fieldInfo.FieldValue.ParseLong("OutAmt");
				break;

				case "FutsAdjstDfamt":
					this.FutsAdjstDfamt = fieldInfo.FieldValue.ParseLong("FutsAdjstDfamt");
				break;

				case "FutsThdayDfamt":
					this.FutsThdayDfamt = fieldInfo.FieldValue.ParseLong("FutsThdayDfamt");
				break;

				case "FutsUpdtDfamt":
					this.FutsUpdtDfamt = fieldInfo.FieldValue.ParseLong("FutsUpdtDfamt");
				break;

				case "FutsLastSettDfamt":
					this.FutsLastSettDfamt = fieldInfo.FieldValue.ParseLong("FutsLastSettDfamt");
				break;

				case "OptSettDfamt":
					this.OptSettDfamt = fieldInfo.FieldValue.ParseLong("OptSettDfamt");
				break;

				case "OptBuyAmt":
					this.OptBuyAmt = fieldInfo.FieldValue.ParseLong("OptBuyAmt");
				break;

				case "OptSellAmt":
					this.OptSellAmt = fieldInfo.FieldValue.ParseLong("OptSellAmt");
				break;

				case "OptXrcDfamt":
					this.OptXrcDfamt = fieldInfo.FieldValue.ParseLong("OptXrcDfamt");
				break;

				case "OptAsgnDfamt":
					this.OptAsgnDfamt = fieldInfo.FieldValue.ParseLong("OptAsgnDfamt");
				break;

				case "RealGdsUndAmt":
					this.RealGdsUndAmt = fieldInfo.FieldValue.ParseLong("RealGdsUndAmt");
				break;

				case "RealGdsUndAsgnAmt":
					this.RealGdsUndAsgnAmt = fieldInfo.FieldValue.ParseLong("RealGdsUndAsgnAmt");
				break;

				case "RealGdsUndXrcAmt":
					this.RealGdsUndXrcAmt = fieldInfo.FieldValue.ParseLong("RealGdsUndXrcAmt");
				break;

				case "CmsnAmt":
					this.CmsnAmt = fieldInfo.FieldValue.ParseLong("CmsnAmt");
				break;

				case "FutsCmsn":
					this.FutsCmsn = fieldInfo.FieldValue.ParseLong("FutsCmsn");
				break;

				case "OptCmsn":
					this.OptCmsn = fieldInfo.FieldValue.ParseLong("OptCmsn");
				break;

				case "FutsCtrctQty":
					this.FutsCtrctQty = fieldInfo.FieldValue.ParseLong("FutsCtrctQty");
				break;

				case "FutsCtrctAmt":
					this.FutsCtrctAmt = fieldInfo.FieldValue.ParseLong("FutsCtrctAmt");
				break;

				case "OptCtrctQty":
					this.OptCtrctQty = fieldInfo.FieldValue.ParseLong("OptCtrctQty");
				break;

				case "OptCtrctAmt":
					this.OptCtrctAmt = fieldInfo.FieldValue.ParseLong("OptCtrctAmt");
				break;

				case "FutsUnsttQty":
					this.FutsUnsttQty = fieldInfo.FieldValue.ParseLong("FutsUnsttQty");
				break;

				case "FutsUnsttAmt":
					this.FutsUnsttAmt = fieldInfo.FieldValue.ParseLong("FutsUnsttAmt");
				break;

				case "OptUnsttQty":
					this.OptUnsttQty = fieldInfo.FieldValue.ParseLong("OptUnsttQty");
				break;

				case "OptUnsttAmt":
					this.OptUnsttAmt = fieldInfo.FieldValue.ParseLong("OptUnsttAmt");
				break;

				case "FutsBuyUnsttQty":
					this.FutsBuyUnsttQty = fieldInfo.FieldValue.ParseLong("FutsBuyUnsttQty");
				break;

				case "FutsBuyUnsttAmt":
					this.FutsBuyUnsttAmt = fieldInfo.FieldValue.ParseLong("FutsBuyUnsttAmt");
				break;

				case "FutsSellUnsttQty":
					this.FutsSellUnsttQty = fieldInfo.FieldValue.ParseLong("FutsSellUnsttQty");
				break;

				case "FutsSellUnsttAmt":
					this.FutsSellUnsttAmt = fieldInfo.FieldValue.ParseLong("FutsSellUnsttAmt");
				break;

				case "OptBuyUnsttQty":
					this.OptBuyUnsttQty = fieldInfo.FieldValue.ParseLong("OptBuyUnsttQty");
				break;

				case "OptBuyUnsttAmt":
					this.OptBuyUnsttAmt = fieldInfo.FieldValue.ParseLong("OptBuyUnsttAmt");
				break;

				case "OptSellUnsttQty":
					this.OptSellUnsttQty = fieldInfo.FieldValue.ParseLong("OptSellUnsttQty");
				break;

				case "OptSellUnsttAmt":
					this.OptSellUnsttAmt = fieldInfo.FieldValue.ParseLong("OptSellUnsttAmt");
				break;

				case "FutsBuyctrQty":
					this.FutsBuyctrQty = fieldInfo.FieldValue.ParseLong("FutsBuyctrQty");
				break;

				case "FutsBuyctrAmt":
					this.FutsBuyctrAmt = fieldInfo.FieldValue.ParseLong("FutsBuyctrAmt");
				break;

				case "FutsSlctrQty":
					this.FutsSlctrQty = fieldInfo.FieldValue.ParseLong("FutsSlctrQty");
				break;

				case "FutsSlctrAmt":
					this.FutsSlctrAmt = fieldInfo.FieldValue.ParseLong("FutsSlctrAmt");
				break;

				case "OptBuyctrQty":
					this.OptBuyctrQty = fieldInfo.FieldValue.ParseLong("OptBuyctrQty");
				break;

				case "OptBuyctrAmt":
					this.OptBuyctrAmt = fieldInfo.FieldValue.ParseLong("OptBuyctrAmt");
				break;

				case "OptSlctrQty":
					this.OptSlctrQty = fieldInfo.FieldValue.ParseLong("OptSlctrQty");
				break;

				case "OptSlctrAmt":
					this.OptSlctrAmt = fieldInfo.FieldValue.ParseLong("OptSlctrAmt");
				break;

				case "FutsBnsplAmt":
					this.FutsBnsplAmt = fieldInfo.FieldValue.ParseLong("FutsBnsplAmt");
				break;

				case "OptBnsplAmt":
					this.OptBnsplAmt = fieldInfo.FieldValue.ParseLong("OptBnsplAmt");
				break;

				case "FutsEvalPnlAmt":
					this.FutsEvalPnlAmt = fieldInfo.FieldValue.ParseLong("FutsEvalPnlAmt");
				break;

				case "OptEvalPnlAmt":
					this.OptEvalPnlAmt = fieldInfo.FieldValue.ParseLong("OptEvalPnlAmt");
				break;

				case "FutsEvalAmt":
					this.FutsEvalAmt = fieldInfo.FieldValue.ParseLong("FutsEvalAmt");
				break;

				case "OptEvalAmt":
					this.OptEvalAmt = fieldInfo.FieldValue.ParseLong("OptEvalAmt");
				break;

				case "MktEndAfMnyInAmt":
					this.MktEndAfMnyInAmt = fieldInfo.FieldValue.ParseLong("MktEndAfMnyInAmt");
				break;

				case "MktEndAfMnyOutAmt":
					this.MktEndAfMnyOutAmt = fieldInfo.FieldValue.ParseLong("MktEndAfMnyOutAmt");
				break;

				case "MktEndAfSubstDsgnAmt":
					this.MktEndAfSubstDsgnAmt = fieldInfo.FieldValue.ParseLong("MktEndAfSubstDsgnAmt");
				break;

				case "MktEndAfSubstAbndAmt":
					this.MktEndAfSubstAbndAmt = fieldInfo.FieldValue.ParseLong("MktEndAfSubstAbndAmt");
				break;


			}
		}

		public static XQCFOEQ11100OutBlock2 FromQuery(XQCFOEQ11100 query)
		{
			XQCFOEQ11100OutBlock2 block = new XQCFOEQ11100OutBlock2();
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
				block.AcntNm = query.GetFieldData(block.GetBlockName(), "AcntNm", 0).TrimEnd('?'); // char 40
				block.OpnmkDpsamtTotamt = query.GetFieldData(block.GetBlockName(), "OpnmkDpsamtTotamt", 0).ParseLong("OpnmkDpsamtTotamt"); // long 16
				block.OpnmkDps = query.GetFieldData(block.GetBlockName(), "OpnmkDps", 0).ParseLong("OpnmkDps"); // long 16
				block.OpnmkMnyrclAmt = query.GetFieldData(block.GetBlockName(), "OpnmkMnyrclAmt", 0).ParseLong("OpnmkMnyrclAmt"); // long 16
				block.OpnmkSubstAmt = query.GetFieldData(block.GetBlockName(), "OpnmkSubstAmt", 0).ParseLong("OpnmkSubstAmt"); // long 16
				block.TotAmt = query.GetFieldData(block.GetBlockName(), "TotAmt", 0).ParseLong("TotAmt"); // long 16
				block.Dps = query.GetFieldData(block.GetBlockName(), "Dps", 0).ParseLong("Dps"); // long 16
				block.MnyrclAmt = query.GetFieldData(block.GetBlockName(), "MnyrclAmt", 0).ParseLong("MnyrclAmt"); // long 16
				block.SubstDsgnAmt = query.GetFieldData(block.GetBlockName(), "SubstDsgnAmt", 0).ParseLong("SubstDsgnAmt"); // long 16
				block.CsgnMgn = query.GetFieldData(block.GetBlockName(), "CsgnMgn", 0).ParseLong("CsgnMgn"); // long 16
				block.MnyCsgnMgn = query.GetFieldData(block.GetBlockName(), "MnyCsgnMgn", 0).ParseLong("MnyCsgnMgn"); // long 16
				block.MaintMgn = query.GetFieldData(block.GetBlockName(), "MaintMgn", 0).ParseLong("MaintMgn"); // long 16
				block.MnyMaintMgn = query.GetFieldData(block.GetBlockName(), "MnyMaintMgn", 0).ParseLong("MnyMaintMgn"); // long 16
				block.OutAbleAmt = query.GetFieldData(block.GetBlockName(), "OutAbleAmt", 0).ParseLong("OutAbleAmt"); // long 16
				block.MnyoutAbleAmt = query.GetFieldData(block.GetBlockName(), "MnyoutAbleAmt", 0).ParseLong("MnyoutAbleAmt"); // long 16
				block.SubstOutAbleAmt = query.GetFieldData(block.GetBlockName(), "SubstOutAbleAmt", 0).ParseLong("SubstOutAbleAmt"); // long 16
				block.OrdAbleAmt = query.GetFieldData(block.GetBlockName(), "OrdAbleAmt", 0).ParseLong("OrdAbleAmt"); // long 16
				block.MnyOrdAbleAmt = query.GetFieldData(block.GetBlockName(), "MnyOrdAbleAmt", 0).ParseLong("MnyOrdAbleAmt"); // long 16
				block.AddMgnOcrTpCode = query.GetFieldData(block.GetBlockName(), "AddMgnOcrTpCode", 0).FirstOrDefault(); // char 1
				block.AddMgn = query.GetFieldData(block.GetBlockName(), "AddMgn", 0).ParseLong("AddMgn"); // long 16
				block.MnyAddMgn = query.GetFieldData(block.GetBlockName(), "MnyAddMgn", 0).ParseLong("MnyAddMgn"); // long 16
				block.NtdayTotAmt = query.GetFieldData(block.GetBlockName(), "NtdayTotAmt", 0).ParseLong("NtdayTotAmt"); // long 16
				block.NtdayDps = query.GetFieldData(block.GetBlockName(), "NtdayDps", 0).ParseLong("NtdayDps"); // long 16
				block.NtdayMnyrclAmt = query.GetFieldData(block.GetBlockName(), "NtdayMnyrclAmt", 0).ParseLong("NtdayMnyrclAmt"); // long 16
				block.NtdaySubstAmt = query.GetFieldData(block.GetBlockName(), "NtdaySubstAmt", 0).ParseLong("NtdaySubstAmt"); // long 16
				block.NtdayCsgnMgn = query.GetFieldData(block.GetBlockName(), "NtdayCsgnMgn", 0).ParseLong("NtdayCsgnMgn"); // long 16
				block.NtdayMnyCsgnMgn = query.GetFieldData(block.GetBlockName(), "NtdayMnyCsgnMgn", 0).ParseLong("NtdayMnyCsgnMgn"); // long 16
				block.NtdayMaintMgn = query.GetFieldData(block.GetBlockName(), "NtdayMaintMgn", 0).ParseLong("NtdayMaintMgn"); // long 16
				block.NtdayMnyMaintMgn = query.GetFieldData(block.GetBlockName(), "NtdayMnyMaintMgn", 0).ParseLong("NtdayMnyMaintMgn"); // long 16
				block.NtdayOutAbleAmt = query.GetFieldData(block.GetBlockName(), "NtdayOutAbleAmt", 0).ParseLong("NtdayOutAbleAmt"); // long 16
				block.NtdayMnyoutAbleAmt = query.GetFieldData(block.GetBlockName(), "NtdayMnyoutAbleAmt", 0).ParseLong("NtdayMnyoutAbleAmt"); // long 16
				block.NtdaySubstOutAbleAmt = query.GetFieldData(block.GetBlockName(), "NtdaySubstOutAbleAmt", 0).ParseLong("NtdaySubstOutAbleAmt"); // long 16
				block.NtdayOrdAbleAmt = query.GetFieldData(block.GetBlockName(), "NtdayOrdAbleAmt", 0).ParseLong("NtdayOrdAbleAmt"); // long 16
				block.NtdayMnyOrdAbleAmt = query.GetFieldData(block.GetBlockName(), "NtdayMnyOrdAbleAmt", 0).ParseLong("NtdayMnyOrdAbleAmt"); // long 16
				block.NtdayAddMgnTp = query.GetFieldData(block.GetBlockName(), "NtdayAddMgnTp", 0).FirstOrDefault(); // char 1
				block.NtdayAddMgn = query.GetFieldData(block.GetBlockName(), "NtdayAddMgn", 0).ParseLong("NtdayAddMgn"); // long 16
				block.NtdayMnyAddMgn = query.GetFieldData(block.GetBlockName(), "NtdayMnyAddMgn", 0).ParseLong("NtdayMnyAddMgn"); // long 16
				block.NtdaySettAmt = query.GetFieldData(block.GetBlockName(), "NtdaySettAmt", 0).ParseLong("NtdaySettAmt"); // long 16
				block.EvalDpsamtTotamt = query.GetFieldData(block.GetBlockName(), "EvalDpsamtTotamt", 0).ParseLong("EvalDpsamtTotamt"); // long 15
				block.MnyEvalDpstgAmt = query.GetFieldData(block.GetBlockName(), "MnyEvalDpstgAmt", 0).ParseLong("MnyEvalDpstgAmt"); // long 15
				block.DpsamtUtlfeeGivPrergAmt = query.GetFieldData(block.GetBlockName(), "DpsamtUtlfeeGivPrergAmt", 0).ParseLong("DpsamtUtlfeeGivPrergAmt"); // long 16
				block.TaxAmt = query.GetFieldData(block.GetBlockName(), "TaxAmt", 0).ParseLong("TaxAmt"); // long 16
				block.CsgnMgnrat = query.GetFieldData(block.GetBlockName(), "CsgnMgnrat", 0).ParseDouble("CsgnMgnrat"); // double 7.2
				block.CsgnMnyMgnrat = query.GetFieldData(block.GetBlockName(), "CsgnMnyMgnrat", 0).ParseDouble("CsgnMnyMgnrat"); // double 7.2
				block.DpstgTotamtLackAmt = query.GetFieldData(block.GetBlockName(), "DpstgTotamtLackAmt", 0).ParseLong("DpstgTotamtLackAmt"); // long 16
				block.DpstgMnyLackAmt = query.GetFieldData(block.GetBlockName(), "DpstgMnyLackAmt", 0).ParseLong("DpstgMnyLackAmt"); // long 16
				block.RealInAmt = query.GetFieldData(block.GetBlockName(), "RealInAmt", 0).ParseLong("RealInAmt"); // long 16
				block.InAmt = query.GetFieldData(block.GetBlockName(), "InAmt", 0).ParseLong("InAmt"); // long 16
				block.OutAmt = query.GetFieldData(block.GetBlockName(), "OutAmt", 0).ParseLong("OutAmt"); // long 16
				block.FutsAdjstDfamt = query.GetFieldData(block.GetBlockName(), "FutsAdjstDfamt", 0).ParseLong("FutsAdjstDfamt"); // long 16
				block.FutsThdayDfamt = query.GetFieldData(block.GetBlockName(), "FutsThdayDfamt", 0).ParseLong("FutsThdayDfamt"); // long 16
				block.FutsUpdtDfamt = query.GetFieldData(block.GetBlockName(), "FutsUpdtDfamt", 0).ParseLong("FutsUpdtDfamt"); // long 16
				block.FutsLastSettDfamt = query.GetFieldData(block.GetBlockName(), "FutsLastSettDfamt", 0).ParseLong("FutsLastSettDfamt"); // long 16
				block.OptSettDfamt = query.GetFieldData(block.GetBlockName(), "OptSettDfamt", 0).ParseLong("OptSettDfamt"); // long 16
				block.OptBuyAmt = query.GetFieldData(block.GetBlockName(), "OptBuyAmt", 0).ParseLong("OptBuyAmt"); // long 16
				block.OptSellAmt = query.GetFieldData(block.GetBlockName(), "OptSellAmt", 0).ParseLong("OptSellAmt"); // long 16
				block.OptXrcDfamt = query.GetFieldData(block.GetBlockName(), "OptXrcDfamt", 0).ParseLong("OptXrcDfamt"); // long 16
				block.OptAsgnDfamt = query.GetFieldData(block.GetBlockName(), "OptAsgnDfamt", 0).ParseLong("OptAsgnDfamt"); // long 16
				block.RealGdsUndAmt = query.GetFieldData(block.GetBlockName(), "RealGdsUndAmt", 0).ParseLong("RealGdsUndAmt"); // long 16
				block.RealGdsUndAsgnAmt = query.GetFieldData(block.GetBlockName(), "RealGdsUndAsgnAmt", 0).ParseLong("RealGdsUndAsgnAmt"); // long 16
				block.RealGdsUndXrcAmt = query.GetFieldData(block.GetBlockName(), "RealGdsUndXrcAmt", 0).ParseLong("RealGdsUndXrcAmt"); // long 16
				block.CmsnAmt = query.GetFieldData(block.GetBlockName(), "CmsnAmt", 0).ParseLong("CmsnAmt"); // long 16
				block.FutsCmsn = query.GetFieldData(block.GetBlockName(), "FutsCmsn", 0).ParseLong("FutsCmsn"); // long 16
				block.OptCmsn = query.GetFieldData(block.GetBlockName(), "OptCmsn", 0).ParseLong("OptCmsn"); // long 16
				block.FutsCtrctQty = query.GetFieldData(block.GetBlockName(), "FutsCtrctQty", 0).ParseLong("FutsCtrctQty"); // long 16
				block.FutsCtrctAmt = query.GetFieldData(block.GetBlockName(), "FutsCtrctAmt", 0).ParseLong("FutsCtrctAmt"); // long 16
				block.OptCtrctQty = query.GetFieldData(block.GetBlockName(), "OptCtrctQty", 0).ParseLong("OptCtrctQty"); // long 16
				block.OptCtrctAmt = query.GetFieldData(block.GetBlockName(), "OptCtrctAmt", 0).ParseLong("OptCtrctAmt"); // long 16
				block.FutsUnsttQty = query.GetFieldData(block.GetBlockName(), "FutsUnsttQty", 0).ParseLong("FutsUnsttQty"); // long 16
				block.FutsUnsttAmt = query.GetFieldData(block.GetBlockName(), "FutsUnsttAmt", 0).ParseLong("FutsUnsttAmt"); // long 16
				block.OptUnsttQty = query.GetFieldData(block.GetBlockName(), "OptUnsttQty", 0).ParseLong("OptUnsttQty"); // long 16
				block.OptUnsttAmt = query.GetFieldData(block.GetBlockName(), "OptUnsttAmt", 0).ParseLong("OptUnsttAmt"); // long 16
				block.FutsBuyUnsttQty = query.GetFieldData(block.GetBlockName(), "FutsBuyUnsttQty", 0).ParseLong("FutsBuyUnsttQty"); // long 16
				block.FutsBuyUnsttAmt = query.GetFieldData(block.GetBlockName(), "FutsBuyUnsttAmt", 0).ParseLong("FutsBuyUnsttAmt"); // long 16
				block.FutsSellUnsttQty = query.GetFieldData(block.GetBlockName(), "FutsSellUnsttQty", 0).ParseLong("FutsSellUnsttQty"); // long 16
				block.FutsSellUnsttAmt = query.GetFieldData(block.GetBlockName(), "FutsSellUnsttAmt", 0).ParseLong("FutsSellUnsttAmt"); // long 16
				block.OptBuyUnsttQty = query.GetFieldData(block.GetBlockName(), "OptBuyUnsttQty", 0).ParseLong("OptBuyUnsttQty"); // long 16
				block.OptBuyUnsttAmt = query.GetFieldData(block.GetBlockName(), "OptBuyUnsttAmt", 0).ParseLong("OptBuyUnsttAmt"); // long 16
				block.OptSellUnsttQty = query.GetFieldData(block.GetBlockName(), "OptSellUnsttQty", 0).ParseLong("OptSellUnsttQty"); // long 16
				block.OptSellUnsttAmt = query.GetFieldData(block.GetBlockName(), "OptSellUnsttAmt", 0).ParseLong("OptSellUnsttAmt"); // long 16
				block.FutsBuyctrQty = query.GetFieldData(block.GetBlockName(), "FutsBuyctrQty", 0).ParseLong("FutsBuyctrQty"); // long 16
				block.FutsBuyctrAmt = query.GetFieldData(block.GetBlockName(), "FutsBuyctrAmt", 0).ParseLong("FutsBuyctrAmt"); // long 16
				block.FutsSlctrQty = query.GetFieldData(block.GetBlockName(), "FutsSlctrQty", 0).ParseLong("FutsSlctrQty"); // long 16
				block.FutsSlctrAmt = query.GetFieldData(block.GetBlockName(), "FutsSlctrAmt", 0).ParseLong("FutsSlctrAmt"); // long 16
				block.OptBuyctrQty = query.GetFieldData(block.GetBlockName(), "OptBuyctrQty", 0).ParseLong("OptBuyctrQty"); // long 16
				block.OptBuyctrAmt = query.GetFieldData(block.GetBlockName(), "OptBuyctrAmt", 0).ParseLong("OptBuyctrAmt"); // long 16
				block.OptSlctrQty = query.GetFieldData(block.GetBlockName(), "OptSlctrQty", 0).ParseLong("OptSlctrQty"); // long 16
				block.OptSlctrAmt = query.GetFieldData(block.GetBlockName(), "OptSlctrAmt", 0).ParseLong("OptSlctrAmt"); // long 16
				block.FutsBnsplAmt = query.GetFieldData(block.GetBlockName(), "FutsBnsplAmt", 0).ParseLong("FutsBnsplAmt"); // long 16
				block.OptBnsplAmt = query.GetFieldData(block.GetBlockName(), "OptBnsplAmt", 0).ParseLong("OptBnsplAmt"); // long 16
				block.FutsEvalPnlAmt = query.GetFieldData(block.GetBlockName(), "FutsEvalPnlAmt", 0).ParseLong("FutsEvalPnlAmt"); // long 16
				block.OptEvalPnlAmt = query.GetFieldData(block.GetBlockName(), "OptEvalPnlAmt", 0).ParseLong("OptEvalPnlAmt"); // long 16
				block.FutsEvalAmt = query.GetFieldData(block.GetBlockName(), "FutsEvalAmt", 0).ParseLong("FutsEvalAmt"); // long 16
				block.OptEvalAmt = query.GetFieldData(block.GetBlockName(), "OptEvalAmt", 0).ParseLong("OptEvalAmt"); // long 16
				block.MktEndAfMnyInAmt = query.GetFieldData(block.GetBlockName(), "MktEndAfMnyInAmt", 0).ParseLong("MktEndAfMnyInAmt"); // long 16
				block.MktEndAfMnyOutAmt = query.GetFieldData(block.GetBlockName(), "MktEndAfMnyOutAmt", 0).ParseLong("MktEndAfMnyOutAmt"); // long 16
				block.MktEndAfSubstDsgnAmt = query.GetFieldData(block.GetBlockName(), "MktEndAfSubstDsgnAmt", 0).ParseLong("MktEndAfSubstDsgnAmt"); // long 16
				block.MktEndAfSubstAbndAmt = query.GetFieldData(block.GetBlockName(), "MktEndAfSubstAbndAmt", 0).ParseLong("MktEndAfSubstAbndAmt"); // long 16

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (RecCnt.ToString().Length > 5) return false; // long 5
			if (AcntNm?.Length > 40) return false; // char 40
			if (OpnmkDpsamtTotamt.ToString().Length > 16) return false; // long 16
			if (OpnmkDps.ToString().Length > 16) return false; // long 16
			if (OpnmkMnyrclAmt.ToString().Length > 16) return false; // long 16
			if (OpnmkSubstAmt.ToString().Length > 16) return false; // long 16
			if (TotAmt.ToString().Length > 16) return false; // long 16
			if (Dps.ToString().Length > 16) return false; // long 16
			if (MnyrclAmt.ToString().Length > 16) return false; // long 16
			if (SubstDsgnAmt.ToString().Length > 16) return false; // long 16
			if (CsgnMgn.ToString().Length > 16) return false; // long 16
			if (MnyCsgnMgn.ToString().Length > 16) return false; // long 16
			if (MaintMgn.ToString().Length > 16) return false; // long 16
			if (MnyMaintMgn.ToString().Length > 16) return false; // long 16
			if (OutAbleAmt.ToString().Length > 16) return false; // long 16
			if (MnyoutAbleAmt.ToString().Length > 16) return false; // long 16
			if (SubstOutAbleAmt.ToString().Length > 16) return false; // long 16
			if (OrdAbleAmt.ToString().Length > 16) return false; // long 16
			if (MnyOrdAbleAmt.ToString().Length > 16) return false; // long 16
			// AddMgnOcrTpCode char 1
			if (AddMgn.ToString().Length > 16) return false; // long 16
			if (MnyAddMgn.ToString().Length > 16) return false; // long 16
			if (NtdayTotAmt.ToString().Length > 16) return false; // long 16
			if (NtdayDps.ToString().Length > 16) return false; // long 16
			if (NtdayMnyrclAmt.ToString().Length > 16) return false; // long 16
			if (NtdaySubstAmt.ToString().Length > 16) return false; // long 16
			if (NtdayCsgnMgn.ToString().Length > 16) return false; // long 16
			if (NtdayMnyCsgnMgn.ToString().Length > 16) return false; // long 16
			if (NtdayMaintMgn.ToString().Length > 16) return false; // long 16
			if (NtdayMnyMaintMgn.ToString().Length > 16) return false; // long 16
			if (NtdayOutAbleAmt.ToString().Length > 16) return false; // long 16
			if (NtdayMnyoutAbleAmt.ToString().Length > 16) return false; // long 16
			if (NtdaySubstOutAbleAmt.ToString().Length > 16) return false; // long 16
			if (NtdayOrdAbleAmt.ToString().Length > 16) return false; // long 16
			if (NtdayMnyOrdAbleAmt.ToString().Length > 16) return false; // long 16
			// NtdayAddMgnTp char 1
			if (NtdayAddMgn.ToString().Length > 16) return false; // long 16
			if (NtdayMnyAddMgn.ToString().Length > 16) return false; // long 16
			if (NtdaySettAmt.ToString().Length > 16) return false; // long 16
			if (EvalDpsamtTotamt.ToString().Length > 15) return false; // long 15
			if (MnyEvalDpstgAmt.ToString().Length > 15) return false; // long 15
			if (DpsamtUtlfeeGivPrergAmt.ToString().Length > 16) return false; // long 16
			if (TaxAmt.ToString().Length > 16) return false; // long 16
			// CsgnMgnrat double 7.2
			// CsgnMnyMgnrat double 7.2
			if (DpstgTotamtLackAmt.ToString().Length > 16) return false; // long 16
			if (DpstgMnyLackAmt.ToString().Length > 16) return false; // long 16
			if (RealInAmt.ToString().Length > 16) return false; // long 16
			if (InAmt.ToString().Length > 16) return false; // long 16
			if (OutAmt.ToString().Length > 16) return false; // long 16
			if (FutsAdjstDfamt.ToString().Length > 16) return false; // long 16
			if (FutsThdayDfamt.ToString().Length > 16) return false; // long 16
			if (FutsUpdtDfamt.ToString().Length > 16) return false; // long 16
			if (FutsLastSettDfamt.ToString().Length > 16) return false; // long 16
			if (OptSettDfamt.ToString().Length > 16) return false; // long 16
			if (OptBuyAmt.ToString().Length > 16) return false; // long 16
			if (OptSellAmt.ToString().Length > 16) return false; // long 16
			if (OptXrcDfamt.ToString().Length > 16) return false; // long 16
			if (OptAsgnDfamt.ToString().Length > 16) return false; // long 16
			if (RealGdsUndAmt.ToString().Length > 16) return false; // long 16
			if (RealGdsUndAsgnAmt.ToString().Length > 16) return false; // long 16
			if (RealGdsUndXrcAmt.ToString().Length > 16) return false; // long 16
			if (CmsnAmt.ToString().Length > 16) return false; // long 16
			if (FutsCmsn.ToString().Length > 16) return false; // long 16
			if (OptCmsn.ToString().Length > 16) return false; // long 16
			if (FutsCtrctQty.ToString().Length > 16) return false; // long 16
			if (FutsCtrctAmt.ToString().Length > 16) return false; // long 16
			if (OptCtrctQty.ToString().Length > 16) return false; // long 16
			if (OptCtrctAmt.ToString().Length > 16) return false; // long 16
			if (FutsUnsttQty.ToString().Length > 16) return false; // long 16
			if (FutsUnsttAmt.ToString().Length > 16) return false; // long 16
			if (OptUnsttQty.ToString().Length > 16) return false; // long 16
			if (OptUnsttAmt.ToString().Length > 16) return false; // long 16
			if (FutsBuyUnsttQty.ToString().Length > 16) return false; // long 16
			if (FutsBuyUnsttAmt.ToString().Length > 16) return false; // long 16
			if (FutsSellUnsttQty.ToString().Length > 16) return false; // long 16
			if (FutsSellUnsttAmt.ToString().Length > 16) return false; // long 16
			if (OptBuyUnsttQty.ToString().Length > 16) return false; // long 16
			if (OptBuyUnsttAmt.ToString().Length > 16) return false; // long 16
			if (OptSellUnsttQty.ToString().Length > 16) return false; // long 16
			if (OptSellUnsttAmt.ToString().Length > 16) return false; // long 16
			if (FutsBuyctrQty.ToString().Length > 16) return false; // long 16
			if (FutsBuyctrAmt.ToString().Length > 16) return false; // long 16
			if (FutsSlctrQty.ToString().Length > 16) return false; // long 16
			if (FutsSlctrAmt.ToString().Length > 16) return false; // long 16
			if (OptBuyctrQty.ToString().Length > 16) return false; // long 16
			if (OptBuyctrAmt.ToString().Length > 16) return false; // long 16
			if (OptSlctrQty.ToString().Length > 16) return false; // long 16
			if (OptSlctrAmt.ToString().Length > 16) return false; // long 16
			if (FutsBnsplAmt.ToString().Length > 16) return false; // long 16
			if (OptBnsplAmt.ToString().Length > 16) return false; // long 16
			if (FutsEvalPnlAmt.ToString().Length > 16) return false; // long 16
			if (OptEvalPnlAmt.ToString().Length > 16) return false; // long 16
			if (FutsEvalAmt.ToString().Length > 16) return false; // long 16
			if (OptEvalAmt.ToString().Length > 16) return false; // long 16
			if (MktEndAfMnyInAmt.ToString().Length > 16) return false; // long 16
			if (MktEndAfMnyOutAmt.ToString().Length > 16) return false; // long 16
			if (MktEndAfSubstDsgnAmt.ToString().Length > 16) return false; // long 16
			if (MktEndAfSubstAbndAmt.ToString().Length > 16) return false; // long 16

			return true;
		}

		public void CopyTo(XQCFOEQ11100OutBlock2 block)
		{
			block.RecCnt = this.RecCnt;
			block.AcntNm = this.AcntNm;
			block.OpnmkDpsamtTotamt = this.OpnmkDpsamtTotamt;
			block.OpnmkDps = this.OpnmkDps;
			block.OpnmkMnyrclAmt = this.OpnmkMnyrclAmt;
			block.OpnmkSubstAmt = this.OpnmkSubstAmt;
			block.TotAmt = this.TotAmt;
			block.Dps = this.Dps;
			block.MnyrclAmt = this.MnyrclAmt;
			block.SubstDsgnAmt = this.SubstDsgnAmt;
			block.CsgnMgn = this.CsgnMgn;
			block.MnyCsgnMgn = this.MnyCsgnMgn;
			block.MaintMgn = this.MaintMgn;
			block.MnyMaintMgn = this.MnyMaintMgn;
			block.OutAbleAmt = this.OutAbleAmt;
			block.MnyoutAbleAmt = this.MnyoutAbleAmt;
			block.SubstOutAbleAmt = this.SubstOutAbleAmt;
			block.OrdAbleAmt = this.OrdAbleAmt;
			block.MnyOrdAbleAmt = this.MnyOrdAbleAmt;
			block.AddMgnOcrTpCode = this.AddMgnOcrTpCode;
			block.AddMgn = this.AddMgn;
			block.MnyAddMgn = this.MnyAddMgn;
			block.NtdayTotAmt = this.NtdayTotAmt;
			block.NtdayDps = this.NtdayDps;
			block.NtdayMnyrclAmt = this.NtdayMnyrclAmt;
			block.NtdaySubstAmt = this.NtdaySubstAmt;
			block.NtdayCsgnMgn = this.NtdayCsgnMgn;
			block.NtdayMnyCsgnMgn = this.NtdayMnyCsgnMgn;
			block.NtdayMaintMgn = this.NtdayMaintMgn;
			block.NtdayMnyMaintMgn = this.NtdayMnyMaintMgn;
			block.NtdayOutAbleAmt = this.NtdayOutAbleAmt;
			block.NtdayMnyoutAbleAmt = this.NtdayMnyoutAbleAmt;
			block.NtdaySubstOutAbleAmt = this.NtdaySubstOutAbleAmt;
			block.NtdayOrdAbleAmt = this.NtdayOrdAbleAmt;
			block.NtdayMnyOrdAbleAmt = this.NtdayMnyOrdAbleAmt;
			block.NtdayAddMgnTp = this.NtdayAddMgnTp;
			block.NtdayAddMgn = this.NtdayAddMgn;
			block.NtdayMnyAddMgn = this.NtdayMnyAddMgn;
			block.NtdaySettAmt = this.NtdaySettAmt;
			block.EvalDpsamtTotamt = this.EvalDpsamtTotamt;
			block.MnyEvalDpstgAmt = this.MnyEvalDpstgAmt;
			block.DpsamtUtlfeeGivPrergAmt = this.DpsamtUtlfeeGivPrergAmt;
			block.TaxAmt = this.TaxAmt;
			block.CsgnMgnrat = this.CsgnMgnrat;
			block.CsgnMnyMgnrat = this.CsgnMnyMgnrat;
			block.DpstgTotamtLackAmt = this.DpstgTotamtLackAmt;
			block.DpstgMnyLackAmt = this.DpstgMnyLackAmt;
			block.RealInAmt = this.RealInAmt;
			block.InAmt = this.InAmt;
			block.OutAmt = this.OutAmt;
			block.FutsAdjstDfamt = this.FutsAdjstDfamt;
			block.FutsThdayDfamt = this.FutsThdayDfamt;
			block.FutsUpdtDfamt = this.FutsUpdtDfamt;
			block.FutsLastSettDfamt = this.FutsLastSettDfamt;
			block.OptSettDfamt = this.OptSettDfamt;
			block.OptBuyAmt = this.OptBuyAmt;
			block.OptSellAmt = this.OptSellAmt;
			block.OptXrcDfamt = this.OptXrcDfamt;
			block.OptAsgnDfamt = this.OptAsgnDfamt;
			block.RealGdsUndAmt = this.RealGdsUndAmt;
			block.RealGdsUndAsgnAmt = this.RealGdsUndAsgnAmt;
			block.RealGdsUndXrcAmt = this.RealGdsUndXrcAmt;
			block.CmsnAmt = this.CmsnAmt;
			block.FutsCmsn = this.FutsCmsn;
			block.OptCmsn = this.OptCmsn;
			block.FutsCtrctQty = this.FutsCtrctQty;
			block.FutsCtrctAmt = this.FutsCtrctAmt;
			block.OptCtrctQty = this.OptCtrctQty;
			block.OptCtrctAmt = this.OptCtrctAmt;
			block.FutsUnsttQty = this.FutsUnsttQty;
			block.FutsUnsttAmt = this.FutsUnsttAmt;
			block.OptUnsttQty = this.OptUnsttQty;
			block.OptUnsttAmt = this.OptUnsttAmt;
			block.FutsBuyUnsttQty = this.FutsBuyUnsttQty;
			block.FutsBuyUnsttAmt = this.FutsBuyUnsttAmt;
			block.FutsSellUnsttQty = this.FutsSellUnsttQty;
			block.FutsSellUnsttAmt = this.FutsSellUnsttAmt;
			block.OptBuyUnsttQty = this.OptBuyUnsttQty;
			block.OptBuyUnsttAmt = this.OptBuyUnsttAmt;
			block.OptSellUnsttQty = this.OptSellUnsttQty;
			block.OptSellUnsttAmt = this.OptSellUnsttAmt;
			block.FutsBuyctrQty = this.FutsBuyctrQty;
			block.FutsBuyctrAmt = this.FutsBuyctrAmt;
			block.FutsSlctrQty = this.FutsSlctrQty;
			block.FutsSlctrAmt = this.FutsSlctrAmt;
			block.OptBuyctrQty = this.OptBuyctrQty;
			block.OptBuyctrAmt = this.OptBuyctrAmt;
			block.OptSlctrQty = this.OptSlctrQty;
			block.OptSlctrAmt = this.OptSlctrAmt;
			block.FutsBnsplAmt = this.FutsBnsplAmt;
			block.OptBnsplAmt = this.OptBnsplAmt;
			block.FutsEvalPnlAmt = this.FutsEvalPnlAmt;
			block.OptEvalPnlAmt = this.OptEvalPnlAmt;
			block.FutsEvalAmt = this.FutsEvalAmt;
			block.OptEvalAmt = this.OptEvalAmt;
			block.MktEndAfMnyInAmt = this.MktEndAfMnyInAmt;
			block.MktEndAfMnyOutAmt = this.MktEndAfMnyOutAmt;
			block.MktEndAfSubstDsgnAmt = this.MktEndAfSubstDsgnAmt;
			block.MktEndAfSubstAbndAmt = this.MktEndAfSubstAbndAmt;

		}
	}

	/// <summary>
	/// 선물옵션가정산예탁금상세
	/// </summary>
	public partial class XQCFOEQ11100 : XingQuery
	{
		/// <summary>
		/// CFOEQ11100
		/// </summary>
		public const string _typeName = "CFOEQ11100";
		/// <summary>
		/// 선물옵션가정산예탁금상세
		/// </summary>
		public const string _typeDesc = "선물옵션가정산예탁금상세";
		/// <summary>
		/// CFOEQ11100
		/// </summary>
		public const string _service = "CFOEQ11100";
		/// <summary>
		/// B
		/// </summary>
		public const string _headType = "B";
		/// <summary>
		/// 김정현
		/// </summary>
		public const string _creator = "김정현";
		/// <summary>
		/// 2012/03/16 14:04:41
		/// </summary>
		public const string _createdDate = "2012/03/16 14:04:41";
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
		/// CFOEQ11100
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 선물옵션가정산예탁금상세
		/// </summary>
		public string TypeDesc => _typeDesc;
		/// <summary>
		/// CFOEQ11100
		/// </summary>
		public string Service => _service;
		/// <summary>
		/// B
		/// </summary>
		public string HeadType => _headType;
		/// <summary>
		/// 김정현
		/// </summary>
		public string Creator => _creator;
		/// <summary>
		/// 2012/03/16 14:04:41
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
		/// 선물옵션가정산예탁금상세
		/// </summary>
		public XQCFOEQ11100() : base("CFOEQ11100") { }




		public bool SetBlock(XQCFOEQ11100InBlock1 block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "RecCnt", 0, block.RecCnt.ToString("d5")); // long 5
			_xaQuery.SetFieldData(block.GetBlockName(), "AcntNo", 0, block.AcntNo); // char 20
			_xaQuery.SetFieldData(block.GetBlockName(), "Pwd", 0, block.Pwd); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "BnsDt", 0, block.BnsDt); // char 8

			return true;
		}

		public XQCFOEQ11100OutBlock1 GetBlock1()
		{
			XQCFOEQ11100OutBlock1 instance = XQCFOEQ11100OutBlock1.FromQuery(this);
			return instance;

		}

		public XQCFOEQ11100OutBlock2 GetBlock2()
		{
			XQCFOEQ11100OutBlock2 instance = XQCFOEQ11100OutBlock2.FromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQCFOEQ11100OutBlock1),
			typeof(XQCFOEQ11100OutBlock2),

		};

	}

}
