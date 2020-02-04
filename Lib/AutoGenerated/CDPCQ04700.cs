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
		public const string _blockName = "CDPCQ04700InBlock1";
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
		/// false
		/// </summary>
		public bool HasOccurs => _hasOccurs;

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

		public static class F
		{
			/// <summary>
			/// 레코드갯수
			/// </summary>
			public const string RecCnt = "RecCnt";
			/// <summary>
			/// 조회구분
			/// </summary>
			public const string QryTp = "QryTp";
			/// <summary>
			/// 계좌번호
			/// </summary>
			public const string AcntNo = "AcntNo";
			/// <summary>
			/// 비밀번호
			/// </summary>
			public const string Pwd = "Pwd";
			/// <summary>
			/// 조회시작일
			/// </summary>
			public const string QrySrtDt = "QrySrtDt";
			/// <summary>
			/// 조회종료일
			/// </summary>
			public const string QryEndDt = "QryEndDt";
			/// <summary>
			/// 시작번호
			/// </summary>
			public const string SrtNo = "SrtNo";
			/// <summary>
			/// 상품유형코드
			/// </summary>
			public const string PdptnCode = "PdptnCode";
			/// <summary>
			/// 종목대분류코드
			/// </summary>
			public const string IsuLgclssCode = "IsuLgclssCode";
			/// <summary>
			/// 종목번호
			/// </summary>
			public const string IsuNo = "IsuNo";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.QryTp,
			F.AcntNo,
			F.Pwd,
			F.QrySrtDt,
			F.QryEndDt,
			F.SrtNo,
			F.PdptnCode,
			F.IsuLgclssCode,
			F.IsuNo,
		};


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

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "RecCnt":
					this.RecCnt = fieldInfo.FieldValue.ParseLong("RecCnt");
				break;

				case "QryTp":
					this.QryTp = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "AcntNo":
					this.AcntNo = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "Pwd":
					this.Pwd = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "QrySrtDt":
					this.QrySrtDt = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "QryEndDt":
					this.QryEndDt = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "SrtNo":
					this.SrtNo = fieldInfo.FieldValue.ParseLong("SrtNo");
				break;

				case "PdptnCode":
					this.PdptnCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "IsuLgclssCode":
					this.IsuLgclssCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "IsuNo":
					this.IsuNo = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (RecCnt.ToString().Length > 5) return false; // long 5
			// QryTp char 1
			if (AcntNo?.Length > 20) return false; // char 20
			if (Pwd?.Length > 8) return false; // char 8
			if (QrySrtDt?.Length > 8) return false; // char 8
			if (QryEndDt?.Length > 8) return false; // char 8
			if (SrtNo.ToString().Length > 10) return false; // long 10
			if (PdptnCode?.Length > 2) return false; // char 2
			if (IsuLgclssCode?.Length > 2) return false; // char 2
			if (IsuNo?.Length > 12) return false; // char 12

			return true;
		}
	}

	public partial class XQCDPCQ04700OutBlock1 : XingBlock
	{
		/// <summary>
		/// CDPCQ04700OutBlock1
		/// </summary>
		public const string _blockName = "CDPCQ04700OutBlock1";
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
		/// false
		/// </summary>
		public bool HasOccurs => _hasOccurs;

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

		public static class F
		{
			/// <summary>
			/// 레코드갯수
			/// </summary>
			public const string RecCnt = "RecCnt";
			/// <summary>
			/// 조회구분
			/// </summary>
			public const string QryTp = "QryTp";
			/// <summary>
			/// 계좌번호
			/// </summary>
			public const string AcntNo = "AcntNo";
			/// <summary>
			/// 비밀번호
			/// </summary>
			public const string Pwd = "Pwd";
			/// <summary>
			/// 조회시작일
			/// </summary>
			public const string QrySrtDt = "QrySrtDt";
			/// <summary>
			/// 조회종료일
			/// </summary>
			public const string QryEndDt = "QryEndDt";
			/// <summary>
			/// 시작번호
			/// </summary>
			public const string SrtNo = "SrtNo";
			/// <summary>
			/// 상품유형코드
			/// </summary>
			public const string PdptnCode = "PdptnCode";
			/// <summary>
			/// 종목대분류코드
			/// </summary>
			public const string IsuLgclssCode = "IsuLgclssCode";
			/// <summary>
			/// 종목번호
			/// </summary>
			public const string IsuNo = "IsuNo";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.QryTp,
			F.AcntNo,
			F.Pwd,
			F.QrySrtDt,
			F.QryEndDt,
			F.SrtNo,
			F.PdptnCode,
			F.IsuLgclssCode,
			F.IsuNo,
		};


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

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "RecCnt":
					this.RecCnt = fieldInfo.FieldValue.ParseLong("RecCnt");
				break;

				case "QryTp":
					this.QryTp = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "AcntNo":
					this.AcntNo = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "Pwd":
					this.Pwd = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "QrySrtDt":
					this.QrySrtDt = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "QryEndDt":
					this.QryEndDt = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "SrtNo":
					this.SrtNo = fieldInfo.FieldValue.ParseLong("SrtNo");
				break;

				case "PdptnCode":
					this.PdptnCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "IsuLgclssCode":
					this.IsuLgclssCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "IsuNo":
					this.IsuNo = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
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
				block.QryTp = query.GetFieldData(block.GetBlockName(), "QryTp", 0).FirstOrDefault(); // char 1
				block.AcntNo = query.GetFieldData(block.GetBlockName(), "AcntNo", 0).TrimEnd('?'); // char 20
				block.Pwd = query.GetFieldData(block.GetBlockName(), "Pwd", 0).TrimEnd('?'); // char 8
				block.QrySrtDt = query.GetFieldData(block.GetBlockName(), "QrySrtDt", 0).TrimEnd('?'); // char 8
				block.QryEndDt = query.GetFieldData(block.GetBlockName(), "QryEndDt", 0).TrimEnd('?'); // char 8
				block.SrtNo = query.GetFieldData(block.GetBlockName(), "SrtNo", 0).ParseLong("SrtNo"); // long 10
				block.PdptnCode = query.GetFieldData(block.GetBlockName(), "PdptnCode", 0).TrimEnd('?'); // char 2
				block.IsuLgclssCode = query.GetFieldData(block.GetBlockName(), "IsuLgclssCode", 0).TrimEnd('?'); // char 2
				block.IsuNo = query.GetFieldData(block.GetBlockName(), "IsuNo", 0).TrimEnd('?'); // char 12

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
			if (AcntNo?.Length > 20) return false; // char 20
			if (Pwd?.Length > 8) return false; // char 8
			if (QrySrtDt?.Length > 8) return false; // char 8
			if (QryEndDt?.Length > 8) return false; // char 8
			if (SrtNo.ToString().Length > 10) return false; // long 10
			if (PdptnCode?.Length > 2) return false; // char 2
			if (IsuLgclssCode?.Length > 2) return false; // char 2
			if (IsuNo?.Length > 12) return false; // char 12

			return true;
		}
	}

	public partial class XQCDPCQ04700OutBlock2 : XingBlock
	{
		/// <summary>
		/// CDPCQ04700OutBlock2
		/// </summary>
		public const string _blockName = "CDPCQ04700OutBlock2";
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
		/// false
		/// </summary>
		public bool HasOccurs => _hasOccurs;

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
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.AcntNm,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["AcntNm"] = new XAQueryFieldInfo("char", AcntNm, AcntNm, "계좌명", (decimal)40);

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


			}
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
				block.AcntNm = query.GetFieldData(block.GetBlockName(), "AcntNm", 0).TrimEnd('?'); // char 40

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

			return true;
		}
	}

	public partial class XQCDPCQ04700OutBlock3 : XingBlock
	{
		/// <summary>
		/// CDPCQ04700OutBlock3
		/// </summary>
		public const string _blockName = "CDPCQ04700OutBlock3";
		/// <summary>
		/// Out2(*EMPTY*)
		/// </summary>
		public const string _blockDesc = "Out2(*EMPTY*)";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// true
		/// </summary>
		public const bool _hasOccurs = true;
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
		/// true
		/// </summary>
		public bool HasOccurs => _hasOccurs;

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

		public static class F
		{
			/// <summary>
			/// 계좌번호
			/// </summary>
			public const string AcntNo = "AcntNo";
			/// <summary>
			/// 거래일자
			/// </summary>
			public const string TrdDt = "TrdDt";
			/// <summary>
			/// 거래번호
			/// </summary>
			public const string TrdNo = "TrdNo";
			/// <summary>
			/// 구분코드명
			/// </summary>
			public const string TpCodeNm = "TpCodeNm";
			/// <summary>
			/// 적요번호
			/// </summary>
			public const string SmryNo = "SmryNo";
			/// <summary>
			/// 적요명
			/// </summary>
			public const string SmryNm = "SmryNm";
			/// <summary>
			/// 취소구분
			/// </summary>
			public const string CancTpNm = "CancTpNm";
			/// <summary>
			/// 거래수량
			/// </summary>
			public const string TrdQty = "TrdQty";
			/// <summary>
			/// 거래세
			/// </summary>
			public const string Trtax = "Trtax";
			/// <summary>
			/// 외화정산금액
			/// </summary>
			public const string FcurrAdjstAmt = "FcurrAdjstAmt";
			/// <summary>
			/// 정산금액
			/// </summary>
			public const string AdjstAmt = "AdjstAmt";
			/// <summary>
			/// 연체합
			/// </summary>
			public const string OvdSum = "OvdSum";
			/// <summary>
			/// 예수금전잔금액
			/// </summary>
			public const string DpsBfbalAmt = "DpsBfbalAmt";
			/// <summary>
			/// 매도담보상환금
			/// </summary>
			public const string SellPldgRfundAmt = "SellPldgRfundAmt";
			/// <summary>
			/// 예탁담보대출전잔금액
			/// </summary>
			public const string DpspdgLoanBfbalAmt = "DpspdgLoanBfbalAmt";
			/// <summary>
			/// 거래매체명
			/// </summary>
			public const string TrdmdaNm = "TrdmdaNm";
			/// <summary>
			/// 원거래번호
			/// </summary>
			public const string OrgTrdNo = "OrgTrdNo";
			/// <summary>
			/// 종목명
			/// </summary>
			public const string IsuNm = "IsuNm";
			/// <summary>
			/// 거래단가
			/// </summary>
			public const string TrdUprc = "TrdUprc";
			/// <summary>
			/// 수수료
			/// </summary>
			public const string CmsnAmt = "CmsnAmt";
			/// <summary>
			/// 외화수수료금액
			/// </summary>
			public const string FcurrCmsnAmt = "FcurrCmsnAmt";
			/// <summary>
			/// 상환차이금액
			/// </summary>
			public const string RfundDiffAmt = "RfundDiffAmt";
			/// <summary>
			/// 변제금합계
			/// </summary>
			public const string RepayAmtSum = "RepayAmtSum";
			/// <summary>
			/// 유가증권금잔수량
			/// </summary>
			public const string SecCrbalQty = "SecCrbalQty";
			/// <summary>
			/// 매도대금담보대출상환이자금액
			/// </summary>
			public const string CslLoanRfundIntrstAmt = "CslLoanRfundIntrstAmt";
			/// <summary>
			/// 예탁담보대출금잔금액
			/// </summary>
			public const string DpspdgLoanCrbalAmt = "DpspdgLoanCrbalAmt";
			/// <summary>
			/// 처리시각
			/// </summary>
			public const string TrxTime = "TrxTime";
			/// <summary>
			/// 출납번호
			/// </summary>
			public const string Inouno = "Inouno";
			/// <summary>
			/// 종목번호
			/// </summary>
			public const string IsuNo = "IsuNo";
			/// <summary>
			/// 거래금액
			/// </summary>
			public const string TrdAmt = "TrdAmt";
			/// <summary>
			/// 수표금액
			/// </summary>
			public const string ChckAmt = "ChckAmt";
			/// <summary>
			/// 세금합계금액
			/// </summary>
			public const string TaxSumAmt = "TaxSumAmt";
			/// <summary>
			/// 외화세금합계금액
			/// </summary>
			public const string FcurrTaxSumAmt = "FcurrTaxSumAmt";
			/// <summary>
			/// 이자이용료
			/// </summary>
			public const string IntrstUtlfee = "IntrstUtlfee";
			/// <summary>
			/// 배당금액
			/// </summary>
			public const string MnyDvdAmt = "MnyDvdAmt";
			/// <summary>
			/// 미수발생금액
			/// </summary>
			public const string RcvblOcrAmt = "RcvblOcrAmt";
			/// <summary>
			/// 처리지점번호
			/// </summary>
			public const string TrxBrnNo = "TrxBrnNo";
			/// <summary>
			/// 처리지점명
			/// </summary>
			public const string TrxBrnNm = "TrxBrnNm";
			/// <summary>
			/// 예탁담보대출금액
			/// </summary>
			public const string DpspdgLoanAmt = "DpspdgLoanAmt";
			/// <summary>
			/// 예탁담보대출상환금액
			/// </summary>
			public const string DpspdgLoanRfundAmt = "DpspdgLoanRfundAmt";
			/// <summary>
			/// 기준가
			/// </summary>
			public const string BasePrc = "BasePrc";
			/// <summary>
			/// 예수금금잔금액
			/// </summary>
			public const string DpsCrbalAmt = "DpsCrbalAmt";
			/// <summary>
			/// 과표
			/// </summary>
			public const string BoaAmt = "BoaAmt";
			/// <summary>
			/// 출금가능금액
			/// </summary>
			public const string MnyoutAbleAmt = "MnyoutAbleAmt";
			/// <summary>
			/// 수익증권담보대출발생금
			/// </summary>
			public const string BcrLoanOcrAmt = "BcrLoanOcrAmt";
			/// <summary>
			/// 수익증권담보대출전잔금
			/// </summary>
			public const string BcrLoanBfbalAmt = "BcrLoanBfbalAmt";
			/// <summary>
			/// 매매기준가
			/// </summary>
			public const string BnsBasePrc = "BnsBasePrc";
			/// <summary>
			/// 과세기준가
			/// </summary>
			public const string TaxchrBasePrc = "TaxchrBasePrc";
			/// <summary>
			/// 거래좌수
			/// </summary>
			public const string TrdUnit = "TrdUnit";
			/// <summary>
			/// 잔고좌수
			/// </summary>
			public const string BalUnit = "BalUnit";
			/// <summary>
			/// 제세금
			/// </summary>
			public const string EvrTax = "EvrTax";
			/// <summary>
			/// 평가금액
			/// </summary>
			public const string EvalAmt = "EvalAmt";
			/// <summary>
			/// 수익증권담보대출상환금
			/// </summary>
			public const string BcrLoanRfundAmt = "BcrLoanRfundAmt";
			/// <summary>
			/// 수익증권담보대출금잔금
			/// </summary>
			public const string BcrLoanCrbalAmt = "BcrLoanCrbalAmt";
			/// <summary>
			/// 추가증거금발생총액
			/// </summary>
			public const string AddMgnOcrTotamt = "AddMgnOcrTotamt";
			/// <summary>
			/// 추가현금증거금발생금액
			/// </summary>
			public const string AddMnyMgnOcrAmt = "AddMnyMgnOcrAmt";
			/// <summary>
			/// 추가증거금납부총액
			/// </summary>
			public const string AddMgnDfryTotamt = "AddMgnDfryTotamt";
			/// <summary>
			/// 추가현금증거금납부금액
			/// </summary>
			public const string AddMnyMgnDfryAmt = "AddMnyMgnDfryAmt";
			/// <summary>
			/// 매매손익금액
			/// </summary>
			public const string BnsplAmt = "BnsplAmt";
			/// <summary>
			/// 소득세
			/// </summary>
			public const string Ictax = "Ictax";
			/// <summary>
			/// 주민세
			/// </summary>
			public const string Ihtax = "Ihtax";
			/// <summary>
			/// 대출일
			/// </summary>
			public const string LoanDt = "LoanDt";
			/// <summary>
			/// 통화코드
			/// </summary>
			public const string CrcyCode = "CrcyCode";
			/// <summary>
			/// 외화금액
			/// </summary>
			public const string FcurrAmt = "FcurrAmt";
			/// <summary>
			/// 외화거래금액
			/// </summary>
			public const string FcurrTrdAmt = "FcurrTrdAmt";
			/// <summary>
			/// 외화예수금
			/// </summary>
			public const string FcurrDps = "FcurrDps";
			/// <summary>
			/// 외화예수금전잔금액
			/// </summary>
			public const string FcurrDpsBfbalAmt = "FcurrDpsBfbalAmt";
			/// <summary>
			/// 상대계좌명
			/// </summary>
			public const string OppAcntNm = "OppAcntNm";
			/// <summary>
			/// 상대계좌번호
			/// </summary>
			public const string OppAcntNo = "OppAcntNo";
			/// <summary>
			/// 대출상환금액
			/// </summary>
			public const string LoanRfundAmt = "LoanRfundAmt";
			/// <summary>
			/// 대출이자금액
			/// </summary>
			public const string LoanIntrstAmt = "LoanIntrstAmt";
			/// <summary>
			/// 의뢰인명
			/// </summary>
			public const string AskpsnNm = "AskpsnNm";
			/// <summary>
			/// 주문일자
			/// </summary>
			public const string OrdDt = "OrdDt";
			/// <summary>
			/// 거래환율
			/// </summary>
			public const string TrdXchrat = "TrdXchrat";
			/// <summary>
			/// 감면수수료
			/// </summary>
			public const string RdctCmsn = "RdctCmsn";
			/// <summary>
			/// 외화인지세
			/// </summary>
			public const string FcurrStmpTx = "FcurrStmpTx";
			/// <summary>
			/// 외화전자금융거래세
			/// </summary>
			public const string FcurrElecfnTrtax = "FcurrElecfnTrtax";
			/// <summary>
			/// 외화증권거래세
			/// </summary>
			public const string FcstckTrtax = "FcstckTrtax";
		}

		public static string[] AllFields = new string[]
		{
			F.AcntNo,
			F.TrdDt,
			F.TrdNo,
			F.TpCodeNm,
			F.SmryNo,
			F.SmryNm,
			F.CancTpNm,
			F.TrdQty,
			F.Trtax,
			F.FcurrAdjstAmt,
			F.AdjstAmt,
			F.OvdSum,
			F.DpsBfbalAmt,
			F.SellPldgRfundAmt,
			F.DpspdgLoanBfbalAmt,
			F.TrdmdaNm,
			F.OrgTrdNo,
			F.IsuNm,
			F.TrdUprc,
			F.CmsnAmt,
			F.FcurrCmsnAmt,
			F.RfundDiffAmt,
			F.RepayAmtSum,
			F.SecCrbalQty,
			F.CslLoanRfundIntrstAmt,
			F.DpspdgLoanCrbalAmt,
			F.TrxTime,
			F.Inouno,
			F.IsuNo,
			F.TrdAmt,
			F.ChckAmt,
			F.TaxSumAmt,
			F.FcurrTaxSumAmt,
			F.IntrstUtlfee,
			F.MnyDvdAmt,
			F.RcvblOcrAmt,
			F.TrxBrnNo,
			F.TrxBrnNm,
			F.DpspdgLoanAmt,
			F.DpspdgLoanRfundAmt,
			F.BasePrc,
			F.DpsCrbalAmt,
			F.BoaAmt,
			F.MnyoutAbleAmt,
			F.BcrLoanOcrAmt,
			F.BcrLoanBfbalAmt,
			F.BnsBasePrc,
			F.TaxchrBasePrc,
			F.TrdUnit,
			F.BalUnit,
			F.EvrTax,
			F.EvalAmt,
			F.BcrLoanRfundAmt,
			F.BcrLoanCrbalAmt,
			F.AddMgnOcrTotamt,
			F.AddMnyMgnOcrAmt,
			F.AddMgnDfryTotamt,
			F.AddMnyMgnDfryAmt,
			F.BnsplAmt,
			F.Ictax,
			F.Ihtax,
			F.LoanDt,
			F.CrcyCode,
			F.FcurrAmt,
			F.FcurrTrdAmt,
			F.FcurrDps,
			F.FcurrDpsBfbalAmt,
			F.OppAcntNm,
			F.OppAcntNo,
			F.LoanRfundAmt,
			F.LoanIntrstAmt,
			F.AskpsnNm,
			F.OrdDt,
			F.TrdXchrat,
			F.RdctCmsn,
			F.FcurrStmpTx,
			F.FcurrElecfnTrtax,
			F.FcstckTrtax,
		};


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

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "AcntNo":
					this.AcntNo = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "TrdDt":
					this.TrdDt = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "TrdNo":
					this.TrdNo = fieldInfo.FieldValue.ParseLong("TrdNo");
				break;

				case "TpCodeNm":
					this.TpCodeNm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "SmryNo":
					this.SmryNo = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "SmryNm":
					this.SmryNm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "CancTpNm":
					this.CancTpNm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "TrdQty":
					this.TrdQty = fieldInfo.FieldValue.ParseLong("TrdQty");
				break;

				case "Trtax":
					this.Trtax = fieldInfo.FieldValue.ParseLong("Trtax");
				break;

				case "FcurrAdjstAmt":
					this.FcurrAdjstAmt = fieldInfo.FieldValue.ParseDouble("FcurrAdjstAmt");
				break;

				case "AdjstAmt":
					this.AdjstAmt = fieldInfo.FieldValue.ParseLong("AdjstAmt");
				break;

				case "OvdSum":
					this.OvdSum = fieldInfo.FieldValue.ParseLong("OvdSum");
				break;

				case "DpsBfbalAmt":
					this.DpsBfbalAmt = fieldInfo.FieldValue.ParseLong("DpsBfbalAmt");
				break;

				case "SellPldgRfundAmt":
					this.SellPldgRfundAmt = fieldInfo.FieldValue.ParseLong("SellPldgRfundAmt");
				break;

				case "DpspdgLoanBfbalAmt":
					this.DpspdgLoanBfbalAmt = fieldInfo.FieldValue.ParseLong("DpspdgLoanBfbalAmt");
				break;

				case "TrdmdaNm":
					this.TrdmdaNm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "OrgTrdNo":
					this.OrgTrdNo = fieldInfo.FieldValue.ParseLong("OrgTrdNo");
				break;

				case "IsuNm":
					this.IsuNm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "TrdUprc":
					this.TrdUprc = fieldInfo.FieldValue.ParseDouble("TrdUprc");
				break;

				case "CmsnAmt":
					this.CmsnAmt = fieldInfo.FieldValue.ParseLong("CmsnAmt");
				break;

				case "FcurrCmsnAmt":
					this.FcurrCmsnAmt = fieldInfo.FieldValue.ParseDouble("FcurrCmsnAmt");
				break;

				case "RfundDiffAmt":
					this.RfundDiffAmt = fieldInfo.FieldValue.ParseLong("RfundDiffAmt");
				break;

				case "RepayAmtSum":
					this.RepayAmtSum = fieldInfo.FieldValue.ParseLong("RepayAmtSum");
				break;

				case "SecCrbalQty":
					this.SecCrbalQty = fieldInfo.FieldValue.ParseLong("SecCrbalQty");
				break;

				case "CslLoanRfundIntrstAmt":
					this.CslLoanRfundIntrstAmt = fieldInfo.FieldValue.ParseLong("CslLoanRfundIntrstAmt");
				break;

				case "DpspdgLoanCrbalAmt":
					this.DpspdgLoanCrbalAmt = fieldInfo.FieldValue.ParseLong("DpspdgLoanCrbalAmt");
				break;

				case "TrxTime":
					this.TrxTime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "Inouno":
					this.Inouno = fieldInfo.FieldValue.ParseLong("Inouno");
				break;

				case "IsuNo":
					this.IsuNo = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "TrdAmt":
					this.TrdAmt = fieldInfo.FieldValue.ParseLong("TrdAmt");
				break;

				case "ChckAmt":
					this.ChckAmt = fieldInfo.FieldValue.ParseLong("ChckAmt");
				break;

				case "TaxSumAmt":
					this.TaxSumAmt = fieldInfo.FieldValue.ParseLong("TaxSumAmt");
				break;

				case "FcurrTaxSumAmt":
					this.FcurrTaxSumAmt = fieldInfo.FieldValue.ParseDouble("FcurrTaxSumAmt");
				break;

				case "IntrstUtlfee":
					this.IntrstUtlfee = fieldInfo.FieldValue.ParseLong("IntrstUtlfee");
				break;

				case "MnyDvdAmt":
					this.MnyDvdAmt = fieldInfo.FieldValue.ParseLong("MnyDvdAmt");
				break;

				case "RcvblOcrAmt":
					this.RcvblOcrAmt = fieldInfo.FieldValue.ParseLong("RcvblOcrAmt");
				break;

				case "TrxBrnNo":
					this.TrxBrnNo = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "TrxBrnNm":
					this.TrxBrnNm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "DpspdgLoanAmt":
					this.DpspdgLoanAmt = fieldInfo.FieldValue.ParseLong("DpspdgLoanAmt");
				break;

				case "DpspdgLoanRfundAmt":
					this.DpspdgLoanRfundAmt = fieldInfo.FieldValue.ParseLong("DpspdgLoanRfundAmt");
				break;

				case "BasePrc":
					this.BasePrc = fieldInfo.FieldValue.ParseDouble("BasePrc");
				break;

				case "DpsCrbalAmt":
					this.DpsCrbalAmt = fieldInfo.FieldValue.ParseLong("DpsCrbalAmt");
				break;

				case "BoaAmt":
					this.BoaAmt = fieldInfo.FieldValue.ParseLong("BoaAmt");
				break;

				case "MnyoutAbleAmt":
					this.MnyoutAbleAmt = fieldInfo.FieldValue.ParseLong("MnyoutAbleAmt");
				break;

				case "BcrLoanOcrAmt":
					this.BcrLoanOcrAmt = fieldInfo.FieldValue.ParseLong("BcrLoanOcrAmt");
				break;

				case "BcrLoanBfbalAmt":
					this.BcrLoanBfbalAmt = fieldInfo.FieldValue.ParseLong("BcrLoanBfbalAmt");
				break;

				case "BnsBasePrc":
					this.BnsBasePrc = fieldInfo.FieldValue.ParseDouble("BnsBasePrc");
				break;

				case "TaxchrBasePrc":
					this.TaxchrBasePrc = fieldInfo.FieldValue.ParseDouble("TaxchrBasePrc");
				break;

				case "TrdUnit":
					this.TrdUnit = fieldInfo.FieldValue.ParseLong("TrdUnit");
				break;

				case "BalUnit":
					this.BalUnit = fieldInfo.FieldValue.ParseLong("BalUnit");
				break;

				case "EvrTax":
					this.EvrTax = fieldInfo.FieldValue.ParseLong("EvrTax");
				break;

				case "EvalAmt":
					this.EvalAmt = fieldInfo.FieldValue.ParseLong("EvalAmt");
				break;

				case "BcrLoanRfundAmt":
					this.BcrLoanRfundAmt = fieldInfo.FieldValue.ParseLong("BcrLoanRfundAmt");
				break;

				case "BcrLoanCrbalAmt":
					this.BcrLoanCrbalAmt = fieldInfo.FieldValue.ParseLong("BcrLoanCrbalAmt");
				break;

				case "AddMgnOcrTotamt":
					this.AddMgnOcrTotamt = fieldInfo.FieldValue.ParseLong("AddMgnOcrTotamt");
				break;

				case "AddMnyMgnOcrAmt":
					this.AddMnyMgnOcrAmt = fieldInfo.FieldValue.ParseLong("AddMnyMgnOcrAmt");
				break;

				case "AddMgnDfryTotamt":
					this.AddMgnDfryTotamt = fieldInfo.FieldValue.ParseLong("AddMgnDfryTotamt");
				break;

				case "AddMnyMgnDfryAmt":
					this.AddMnyMgnDfryAmt = fieldInfo.FieldValue.ParseLong("AddMnyMgnDfryAmt");
				break;

				case "BnsplAmt":
					this.BnsplAmt = fieldInfo.FieldValue.ParseLong("BnsplAmt");
				break;

				case "Ictax":
					this.Ictax = fieldInfo.FieldValue.ParseLong("Ictax");
				break;

				case "Ihtax":
					this.Ihtax = fieldInfo.FieldValue.ParseLong("Ihtax");
				break;

				case "LoanDt":
					this.LoanDt = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "CrcyCode":
					this.CrcyCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "FcurrAmt":
					this.FcurrAmt = fieldInfo.FieldValue.ParseDouble("FcurrAmt");
				break;

				case "FcurrTrdAmt":
					this.FcurrTrdAmt = fieldInfo.FieldValue.ParseDouble("FcurrTrdAmt");
				break;

				case "FcurrDps":
					this.FcurrDps = fieldInfo.FieldValue.ParseDouble("FcurrDps");
				break;

				case "FcurrDpsBfbalAmt":
					this.FcurrDpsBfbalAmt = fieldInfo.FieldValue.ParseDouble("FcurrDpsBfbalAmt");
				break;

				case "OppAcntNm":
					this.OppAcntNm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "OppAcntNo":
					this.OppAcntNo = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "LoanRfundAmt":
					this.LoanRfundAmt = fieldInfo.FieldValue.ParseLong("LoanRfundAmt");
				break;

				case "LoanIntrstAmt":
					this.LoanIntrstAmt = fieldInfo.FieldValue.ParseLong("LoanIntrstAmt");
				break;

				case "AskpsnNm":
					this.AskpsnNm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "OrdDt":
					this.OrdDt = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "TrdXchrat":
					this.TrdXchrat = fieldInfo.FieldValue.ParseDouble("TrdXchrat");
				break;

				case "RdctCmsn":
					this.RdctCmsn = fieldInfo.FieldValue.ParseDouble("RdctCmsn");
				break;

				case "FcurrStmpTx":
					this.FcurrStmpTx = fieldInfo.FieldValue.ParseDouble("FcurrStmpTx");
				break;

				case "FcurrElecfnTrtax":
					this.FcurrElecfnTrtax = fieldInfo.FieldValue.ParseDouble("FcurrElecfnTrtax");
				break;

				case "FcstckTrtax":
					this.FcstckTrtax = fieldInfo.FieldValue.ParseDouble("FcstckTrtax");
				break;


			}
		}

		public static XQCDPCQ04700OutBlock3[] ListFromQuery(XQCDPCQ04700 query)
		{
			int count = query.GetBlockCount(XQCDPCQ04700OutBlock3.BlockName);
			List<XQCDPCQ04700OutBlock3> list = new List<XQCDPCQ04700OutBlock3>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQCDPCQ04700OutBlock3 block = new XQCDPCQ04700OutBlock3();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.AcntNo = query.GetFieldData(block.GetBlockName(), "AcntNo", i).TrimEnd('?'); // char 20
					block.TrdDt = query.GetFieldData(block.GetBlockName(), "TrdDt", i).TrimEnd('?'); // char 8
					block.TrdNo = query.GetFieldData(block.GetBlockName(), "TrdNo", i).ParseLong("TrdNo"); // long 10
					block.TpCodeNm = query.GetFieldData(block.GetBlockName(), "TpCodeNm", i).TrimEnd('?'); // char 50
					block.SmryNo = query.GetFieldData(block.GetBlockName(), "SmryNo", i).TrimEnd('?'); // char 4
					block.SmryNm = query.GetFieldData(block.GetBlockName(), "SmryNm", i).TrimEnd('?'); // char 40
					block.CancTpNm = query.GetFieldData(block.GetBlockName(), "CancTpNm", i).TrimEnd('?'); // char 20
					block.TrdQty = query.GetFieldData(block.GetBlockName(), "TrdQty", i).ParseLong("TrdQty"); // long 16
					block.Trtax = query.GetFieldData(block.GetBlockName(), "Trtax", i).ParseLong("Trtax"); // long 16
					block.FcurrAdjstAmt = query.GetFieldData(block.GetBlockName(), "FcurrAdjstAmt", i).ParseDouble("FcurrAdjstAmt"); // double 25.4
					block.AdjstAmt = query.GetFieldData(block.GetBlockName(), "AdjstAmt", i).ParseLong("AdjstAmt"); // long 16
					block.OvdSum = query.GetFieldData(block.GetBlockName(), "OvdSum", i).ParseLong("OvdSum"); // long 16
					block.DpsBfbalAmt = query.GetFieldData(block.GetBlockName(), "DpsBfbalAmt", i).ParseLong("DpsBfbalAmt"); // long 16
					block.SellPldgRfundAmt = query.GetFieldData(block.GetBlockName(), "SellPldgRfundAmt", i).ParseLong("SellPldgRfundAmt"); // long 16
					block.DpspdgLoanBfbalAmt = query.GetFieldData(block.GetBlockName(), "DpspdgLoanBfbalAmt", i).ParseLong("DpspdgLoanBfbalAmt"); // long 16
					block.TrdmdaNm = query.GetFieldData(block.GetBlockName(), "TrdmdaNm", i).TrimEnd('?'); // char 40
					block.OrgTrdNo = query.GetFieldData(block.GetBlockName(), "OrgTrdNo", i).ParseLong("OrgTrdNo"); // long 10
					block.IsuNm = query.GetFieldData(block.GetBlockName(), "IsuNm", i).TrimEnd('?'); // char 40
					block.TrdUprc = query.GetFieldData(block.GetBlockName(), "TrdUprc", i).ParseDouble("TrdUprc"); // double 13.2
					block.CmsnAmt = query.GetFieldData(block.GetBlockName(), "CmsnAmt", i).ParseLong("CmsnAmt"); // long 16
					block.FcurrCmsnAmt = query.GetFieldData(block.GetBlockName(), "FcurrCmsnAmt", i).ParseDouble("FcurrCmsnAmt"); // double 15.2
					block.RfundDiffAmt = query.GetFieldData(block.GetBlockName(), "RfundDiffAmt", i).ParseLong("RfundDiffAmt"); // long 16
					block.RepayAmtSum = query.GetFieldData(block.GetBlockName(), "RepayAmtSum", i).ParseLong("RepayAmtSum"); // long 16
					block.SecCrbalQty = query.GetFieldData(block.GetBlockName(), "SecCrbalQty", i).ParseLong("SecCrbalQty"); // long 16
					block.CslLoanRfundIntrstAmt = query.GetFieldData(block.GetBlockName(), "CslLoanRfundIntrstAmt", i).ParseLong("CslLoanRfundIntrstAmt"); // long 16
					block.DpspdgLoanCrbalAmt = query.GetFieldData(block.GetBlockName(), "DpspdgLoanCrbalAmt", i).ParseLong("DpspdgLoanCrbalAmt"); // long 16
					block.TrxTime = query.GetFieldData(block.GetBlockName(), "TrxTime", i).TrimEnd('?'); // char 9
					block.Inouno = query.GetFieldData(block.GetBlockName(), "Inouno", i).ParseLong("Inouno"); // long 10
					block.IsuNo = query.GetFieldData(block.GetBlockName(), "IsuNo", i).TrimEnd('?'); // char 12
					block.TrdAmt = query.GetFieldData(block.GetBlockName(), "TrdAmt", i).ParseLong("TrdAmt"); // long 16
					block.ChckAmt = query.GetFieldData(block.GetBlockName(), "ChckAmt", i).ParseLong("ChckAmt"); // long 16
					block.TaxSumAmt = query.GetFieldData(block.GetBlockName(), "TaxSumAmt", i).ParseLong("TaxSumAmt"); // long 16
					block.FcurrTaxSumAmt = query.GetFieldData(block.GetBlockName(), "FcurrTaxSumAmt", i).ParseDouble("FcurrTaxSumAmt"); // double 26.6
					block.IntrstUtlfee = query.GetFieldData(block.GetBlockName(), "IntrstUtlfee", i).ParseLong("IntrstUtlfee"); // long 16
					block.MnyDvdAmt = query.GetFieldData(block.GetBlockName(), "MnyDvdAmt", i).ParseLong("MnyDvdAmt"); // long 16
					block.RcvblOcrAmt = query.GetFieldData(block.GetBlockName(), "RcvblOcrAmt", i).ParseLong("RcvblOcrAmt"); // long 16
					block.TrxBrnNo = query.GetFieldData(block.GetBlockName(), "TrxBrnNo", i).TrimEnd('?'); // char 3
					block.TrxBrnNm = query.GetFieldData(block.GetBlockName(), "TrxBrnNm", i).TrimEnd('?'); // char 40
					block.DpspdgLoanAmt = query.GetFieldData(block.GetBlockName(), "DpspdgLoanAmt", i).ParseLong("DpspdgLoanAmt"); // long 16
					block.DpspdgLoanRfundAmt = query.GetFieldData(block.GetBlockName(), "DpspdgLoanRfundAmt", i).ParseLong("DpspdgLoanRfundAmt"); // long 16
					block.BasePrc = query.GetFieldData(block.GetBlockName(), "BasePrc", i).ParseDouble("BasePrc"); // double 13.2
					block.DpsCrbalAmt = query.GetFieldData(block.GetBlockName(), "DpsCrbalAmt", i).ParseLong("DpsCrbalAmt"); // long 16
					block.BoaAmt = query.GetFieldData(block.GetBlockName(), "BoaAmt", i).ParseLong("BoaAmt"); // long 16
					block.MnyoutAbleAmt = query.GetFieldData(block.GetBlockName(), "MnyoutAbleAmt", i).ParseLong("MnyoutAbleAmt"); // long 16
					block.BcrLoanOcrAmt = query.GetFieldData(block.GetBlockName(), "BcrLoanOcrAmt", i).ParseLong("BcrLoanOcrAmt"); // long 16
					block.BcrLoanBfbalAmt = query.GetFieldData(block.GetBlockName(), "BcrLoanBfbalAmt", i).ParseLong("BcrLoanBfbalAmt"); // long 16
					block.BnsBasePrc = query.GetFieldData(block.GetBlockName(), "BnsBasePrc", i).ParseDouble("BnsBasePrc"); // double 20.10
					block.TaxchrBasePrc = query.GetFieldData(block.GetBlockName(), "TaxchrBasePrc", i).ParseDouble("TaxchrBasePrc"); // double 20.10
					block.TrdUnit = query.GetFieldData(block.GetBlockName(), "TrdUnit", i).ParseLong("TrdUnit"); // long 16
					block.BalUnit = query.GetFieldData(block.GetBlockName(), "BalUnit", i).ParseLong("BalUnit"); // long 16
					block.EvrTax = query.GetFieldData(block.GetBlockName(), "EvrTax", i).ParseLong("EvrTax"); // long 16
					block.EvalAmt = query.GetFieldData(block.GetBlockName(), "EvalAmt", i).ParseLong("EvalAmt"); // long 16
					block.BcrLoanRfundAmt = query.GetFieldData(block.GetBlockName(), "BcrLoanRfundAmt", i).ParseLong("BcrLoanRfundAmt"); // long 16
					block.BcrLoanCrbalAmt = query.GetFieldData(block.GetBlockName(), "BcrLoanCrbalAmt", i).ParseLong("BcrLoanCrbalAmt"); // long 16
					block.AddMgnOcrTotamt = query.GetFieldData(block.GetBlockName(), "AddMgnOcrTotamt", i).ParseLong("AddMgnOcrTotamt"); // long 16
					block.AddMnyMgnOcrAmt = query.GetFieldData(block.GetBlockName(), "AddMnyMgnOcrAmt", i).ParseLong("AddMnyMgnOcrAmt"); // long 16
					block.AddMgnDfryTotamt = query.GetFieldData(block.GetBlockName(), "AddMgnDfryTotamt", i).ParseLong("AddMgnDfryTotamt"); // long 16
					block.AddMnyMgnDfryAmt = query.GetFieldData(block.GetBlockName(), "AddMnyMgnDfryAmt", i).ParseLong("AddMnyMgnDfryAmt"); // long 16
					block.BnsplAmt = query.GetFieldData(block.GetBlockName(), "BnsplAmt", i).ParseLong("BnsplAmt"); // long 16
					block.Ictax = query.GetFieldData(block.GetBlockName(), "Ictax", i).ParseLong("Ictax"); // long 16
					block.Ihtax = query.GetFieldData(block.GetBlockName(), "Ihtax", i).ParseLong("Ihtax"); // long 16
					block.LoanDt = query.GetFieldData(block.GetBlockName(), "LoanDt", i).TrimEnd('?'); // char 8
					block.CrcyCode = query.GetFieldData(block.GetBlockName(), "CrcyCode", i).TrimEnd('?'); // char 3
					block.FcurrAmt = query.GetFieldData(block.GetBlockName(), "FcurrAmt", i).ParseDouble("FcurrAmt"); // double 24.4
					block.FcurrTrdAmt = query.GetFieldData(block.GetBlockName(), "FcurrTrdAmt", i).ParseDouble("FcurrTrdAmt"); // double 24.4
					block.FcurrDps = query.GetFieldData(block.GetBlockName(), "FcurrDps", i).ParseDouble("FcurrDps"); // double 21.4
					block.FcurrDpsBfbalAmt = query.GetFieldData(block.GetBlockName(), "FcurrDpsBfbalAmt", i).ParseDouble("FcurrDpsBfbalAmt"); // double 21.4
					block.OppAcntNm = query.GetFieldData(block.GetBlockName(), "OppAcntNm", i).TrimEnd('?'); // char 40
					block.OppAcntNo = query.GetFieldData(block.GetBlockName(), "OppAcntNo", i).TrimEnd('?'); // char 20
					block.LoanRfundAmt = query.GetFieldData(block.GetBlockName(), "LoanRfundAmt", i).ParseLong("LoanRfundAmt"); // long 16
					block.LoanIntrstAmt = query.GetFieldData(block.GetBlockName(), "LoanIntrstAmt", i).ParseLong("LoanIntrstAmt"); // long 16
					block.AskpsnNm = query.GetFieldData(block.GetBlockName(), "AskpsnNm", i).TrimEnd('?'); // char 40
					block.OrdDt = query.GetFieldData(block.GetBlockName(), "OrdDt", i).TrimEnd('?'); // char 8
					block.TrdXchrat = query.GetFieldData(block.GetBlockName(), "TrdXchrat", i).ParseDouble("TrdXchrat"); // double 15.4
					block.RdctCmsn = query.GetFieldData(block.GetBlockName(), "RdctCmsn", i).ParseDouble("RdctCmsn"); // double 21.4
					block.FcurrStmpTx = query.GetFieldData(block.GetBlockName(), "FcurrStmpTx", i).ParseDouble("FcurrStmpTx"); // double 21.4
					block.FcurrElecfnTrtax = query.GetFieldData(block.GetBlockName(), "FcurrElecfnTrtax", i).ParseDouble("FcurrElecfnTrtax"); // double 21.4
					block.FcstckTrtax = query.GetFieldData(block.GetBlockName(), "FcstckTrtax", i).ParseDouble("FcstckTrtax"); // double 21.4

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
			if (AcntNo?.Length > 20) return false; // char 20
			if (TrdDt?.Length > 8) return false; // char 8
			if (TrdNo.ToString().Length > 10) return false; // long 10
			if (TpCodeNm?.Length > 50) return false; // char 50
			if (SmryNo?.Length > 4) return false; // char 4
			if (SmryNm?.Length > 40) return false; // char 40
			if (CancTpNm?.Length > 20) return false; // char 20
			if (TrdQty.ToString().Length > 16) return false; // long 16
			if (Trtax.ToString().Length > 16) return false; // long 16
			// FcurrAdjstAmt double 25.4
			if (AdjstAmt.ToString().Length > 16) return false; // long 16
			if (OvdSum.ToString().Length > 16) return false; // long 16
			if (DpsBfbalAmt.ToString().Length > 16) return false; // long 16
			if (SellPldgRfundAmt.ToString().Length > 16) return false; // long 16
			if (DpspdgLoanBfbalAmt.ToString().Length > 16) return false; // long 16
			if (TrdmdaNm?.Length > 40) return false; // char 40
			if (OrgTrdNo.ToString().Length > 10) return false; // long 10
			if (IsuNm?.Length > 40) return false; // char 40
			// TrdUprc double 13.2
			if (CmsnAmt.ToString().Length > 16) return false; // long 16
			// FcurrCmsnAmt double 15.2
			if (RfundDiffAmt.ToString().Length > 16) return false; // long 16
			if (RepayAmtSum.ToString().Length > 16) return false; // long 16
			if (SecCrbalQty.ToString().Length > 16) return false; // long 16
			if (CslLoanRfundIntrstAmt.ToString().Length > 16) return false; // long 16
			if (DpspdgLoanCrbalAmt.ToString().Length > 16) return false; // long 16
			if (TrxTime?.Length > 9) return false; // char 9
			if (Inouno.ToString().Length > 10) return false; // long 10
			if (IsuNo?.Length > 12) return false; // char 12
			if (TrdAmt.ToString().Length > 16) return false; // long 16
			if (ChckAmt.ToString().Length > 16) return false; // long 16
			if (TaxSumAmt.ToString().Length > 16) return false; // long 16
			// FcurrTaxSumAmt double 26.6
			if (IntrstUtlfee.ToString().Length > 16) return false; // long 16
			if (MnyDvdAmt.ToString().Length > 16) return false; // long 16
			if (RcvblOcrAmt.ToString().Length > 16) return false; // long 16
			if (TrxBrnNo?.Length > 3) return false; // char 3
			if (TrxBrnNm?.Length > 40) return false; // char 40
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
			if (LoanDt?.Length > 8) return false; // char 8
			if (CrcyCode?.Length > 3) return false; // char 3
			// FcurrAmt double 24.4
			// FcurrTrdAmt double 24.4
			// FcurrDps double 21.4
			// FcurrDpsBfbalAmt double 21.4
			if (OppAcntNm?.Length > 40) return false; // char 40
			if (OppAcntNo?.Length > 20) return false; // char 20
			if (LoanRfundAmt.ToString().Length > 16) return false; // long 16
			if (LoanIntrstAmt.ToString().Length > 16) return false; // long 16
			if (AskpsnNm?.Length > 40) return false; // char 40
			if (OrdDt?.Length > 8) return false; // char 8
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
		public const string _blockName = "CDPCQ04700OutBlock4";
		/// <summary>
		/// Out3(*EMPTY*)
		/// </summary>
		public const string _blockDesc = "Out3(*EMPTY*)";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// false
		/// </summary>
		public const bool _hasOccurs = false;
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
		/// false
		/// </summary>
		public bool HasOccurs => _hasOccurs;

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

		public static class F
		{
			/// <summary>
			/// 레코드갯수
			/// </summary>
			public const string RecCnt = "RecCnt";
			/// <summary>
			/// 손익합계금액
			/// </summary>
			public const string PnlSumAmt = "PnlSumAmt";
			/// <summary>
			/// 약정누계
			/// </summary>
			public const string CtrctAsm = "CtrctAsm";
			/// <summary>
			/// 수수료합계금액
			/// </summary>
			public const string CmsnAmtSumAmt = "CmsnAmtSumAmt";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.PnlSumAmt,
			F.CtrctAsm,
			F.CmsnAmtSumAmt,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["PnlSumAmt"] = new XAQueryFieldInfo("long", PnlSumAmt, PnlSumAmt.ToString("d16"), "손익합계금액", (decimal)16);
			dict["CtrctAsm"] = new XAQueryFieldInfo("long", CtrctAsm, CtrctAsm.ToString("d16"), "약정누계", (decimal)16);
			dict["CmsnAmtSumAmt"] = new XAQueryFieldInfo("long", CmsnAmtSumAmt, CmsnAmtSumAmt.ToString("d16"), "수수료합계금액", (decimal)16);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "RecCnt":
					this.RecCnt = fieldInfo.FieldValue.ParseLong("RecCnt");
				break;

				case "PnlSumAmt":
					this.PnlSumAmt = fieldInfo.FieldValue.ParseLong("PnlSumAmt");
				break;

				case "CtrctAsm":
					this.CtrctAsm = fieldInfo.FieldValue.ParseLong("CtrctAsm");
				break;

				case "CmsnAmtSumAmt":
					this.CmsnAmtSumAmt = fieldInfo.FieldValue.ParseLong("CmsnAmtSumAmt");
				break;


			}
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
		public const string _blockName = "CDPCQ04700OutBlock5";
		/// <summary>
		/// Out4(*EMPTY*)
		/// </summary>
		public const string _blockDesc = "Out4(*EMPTY*)";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// false
		/// </summary>
		public const bool _hasOccurs = false;
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
		/// false
		/// </summary>
		public bool HasOccurs => _hasOccurs;

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

		public static class F
		{
			/// <summary>
			/// 레코드갯수
			/// </summary>
			public const string RecCnt = "RecCnt";
			/// <summary>
			/// 입금금액
			/// </summary>
			public const string MnyinAmt = "MnyinAmt";
			/// <summary>
			/// 입고금액
			/// </summary>
			public const string SecinAmt = "SecinAmt";
			/// <summary>
			/// 출금금액
			/// </summary>
			public const string MnyoutAmt = "MnyoutAmt";
			/// <summary>
			/// 출고금액
			/// </summary>
			public const string SecoutAmt = "SecoutAmt";
			/// <summary>
			/// 차이금액
			/// </summary>
			public const string DiffAmt = "DiffAmt";
			/// <summary>
			/// 차이금액0
			/// </summary>
			public const string DiffAmt0 = "DiffAmt0";
			/// <summary>
			/// 매도수량
			/// </summary>
			public const string SellQty = "SellQty";
			/// <summary>
			/// 매도금액
			/// </summary>
			public const string SellAmt = "SellAmt";
			/// <summary>
			/// 매도수수료
			/// </summary>
			public const string SellCmsn = "SellCmsn";
			/// <summary>
			/// 제세금
			/// </summary>
			public const string EvrTax = "EvrTax";
			/// <summary>
			/// 외화매도정산금액
			/// </summary>
			public const string FcurrSellAdjstAmt = "FcurrSellAdjstAmt";
			/// <summary>
			/// 매수수량
			/// </summary>
			public const string BuyQty = "BuyQty";
			/// <summary>
			/// 매수금액
			/// </summary>
			public const string BuyAmt = "BuyAmt";
			/// <summary>
			/// 매수수수료
			/// </summary>
			public const string BuyCmsn = "BuyCmsn";
			/// <summary>
			/// 체결세금
			/// </summary>
			public const string ExecTax = "ExecTax";
			/// <summary>
			/// 외화매수정산금액
			/// </summary>
			public const string FcurrBuyAdjstAmt = "FcurrBuyAdjstAmt";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.MnyinAmt,
			F.SecinAmt,
			F.MnyoutAmt,
			F.SecoutAmt,
			F.DiffAmt,
			F.DiffAmt0,
			F.SellQty,
			F.SellAmt,
			F.SellCmsn,
			F.EvrTax,
			F.FcurrSellAdjstAmt,
			F.BuyQty,
			F.BuyAmt,
			F.BuyCmsn,
			F.ExecTax,
			F.FcurrBuyAdjstAmt,
		};


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

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "RecCnt":
					this.RecCnt = fieldInfo.FieldValue.ParseLong("RecCnt");
				break;

				case "MnyinAmt":
					this.MnyinAmt = fieldInfo.FieldValue.ParseLong("MnyinAmt");
				break;

				case "SecinAmt":
					this.SecinAmt = fieldInfo.FieldValue.ParseLong("SecinAmt");
				break;

				case "MnyoutAmt":
					this.MnyoutAmt = fieldInfo.FieldValue.ParseLong("MnyoutAmt");
				break;

				case "SecoutAmt":
					this.SecoutAmt = fieldInfo.FieldValue.ParseLong("SecoutAmt");
				break;

				case "DiffAmt":
					this.DiffAmt = fieldInfo.FieldValue.ParseLong("DiffAmt");
				break;

				case "DiffAmt0":
					this.DiffAmt0 = fieldInfo.FieldValue.ParseLong("DiffAmt0");
				break;

				case "SellQty":
					this.SellQty = fieldInfo.FieldValue.ParseLong("SellQty");
				break;

				case "SellAmt":
					this.SellAmt = fieldInfo.FieldValue.ParseLong("SellAmt");
				break;

				case "SellCmsn":
					this.SellCmsn = fieldInfo.FieldValue.ParseLong("SellCmsn");
				break;

				case "EvrTax":
					this.EvrTax = fieldInfo.FieldValue.ParseLong("EvrTax");
				break;

				case "FcurrSellAdjstAmt":
					this.FcurrSellAdjstAmt = fieldInfo.FieldValue.ParseDouble("FcurrSellAdjstAmt");
				break;

				case "BuyQty":
					this.BuyQty = fieldInfo.FieldValue.ParseLong("BuyQty");
				break;

				case "BuyAmt":
					this.BuyAmt = fieldInfo.FieldValue.ParseLong("BuyAmt");
				break;

				case "BuyCmsn":
					this.BuyCmsn = fieldInfo.FieldValue.ParseLong("BuyCmsn");
				break;

				case "ExecTax":
					this.ExecTax = fieldInfo.FieldValue.ParseLong("ExecTax");
				break;

				case "FcurrBuyAdjstAmt":
					this.FcurrBuyAdjstAmt = fieldInfo.FieldValue.ParseDouble("FcurrBuyAdjstAmt");
				break;


			}
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
		public const string _typeName = "CDPCQ04700";
		/// <summary>
		/// 계좌 거래내역
		/// </summary>
		public const string _typeDesc = "계좌 거래내역";
		/// <summary>
		/// CDPCQ04700
		/// </summary>
		public const string _service = "CDPCQ04700";
		/// <summary>
		/// B
		/// </summary>
		public const string _headType = "B";
		/// <summary>
		/// 류화숙
		/// </summary>
		public const string _creator = "류화숙";
		/// <summary>
		/// 2012/06/14 10:25:09
		/// </summary>
		public const string _createdDate = "2012/06/14 10:25:09";
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



		public bool SetBlock(XQCDPCQ04700InBlock1 block)
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

		public XQCDPCQ04700OutBlock3[] GetBlock3s()
		{
			XQCDPCQ04700OutBlock3[] instance = XQCDPCQ04700OutBlock3.ListFromQuery(this);
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

}
