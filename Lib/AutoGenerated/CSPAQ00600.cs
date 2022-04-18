using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQCSPAQ00600InBlock1 : XingBlock
	{
		/// <summary>
		/// CSPAQ00600InBlock1
		/// </summary>
		public const string _blockName = "CSPAQ00600InBlock1";
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
		/// CSPAQ00600InBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CSPAQ00600InBlock1
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
		/// 입력비밀번호
		/// </summary>
		[XAQueryFieldAttribute("InptPwd", "입력비밀번호", "char", "8")]
		public string InptPwd;
		/// <summary>
		/// 대출상세분류코드
		/// </summary>
		[XAQueryFieldAttribute("LoanDtlClssCode", "대출상세분류코드", "char", "2")]
		public string LoanDtlClssCode;
		/// <summary>
		/// 종목번호
		/// </summary>
		[XAQueryFieldAttribute("IsuNo", "종목번호", "char", "12")]
		public string IsuNo;
		/// <summary>
		/// 주문가
		/// </summary>
		[XAQueryFieldAttribute("OrdPrc", "주문가", "double", "13.2")]
		public double OrdPrc;
		/// <summary>
		/// 통신매체코드
		/// </summary>
		[XAQueryFieldAttribute("CommdaCode", "통신매체코드", "char", "2")]
		public string CommdaCode;

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
			/// 입력비밀번호
			/// </summary>
			public const string InptPwd = "InptPwd";
			/// <summary>
			/// 대출상세분류코드
			/// </summary>
			public const string LoanDtlClssCode = "LoanDtlClssCode";
			/// <summary>
			/// 종목번호
			/// </summary>
			public const string IsuNo = "IsuNo";
			/// <summary>
			/// 주문가
			/// </summary>
			public const string OrdPrc = "OrdPrc";
			/// <summary>
			/// 통신매체코드
			/// </summary>
			public const string CommdaCode = "CommdaCode";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.AcntNo,
			F.InptPwd,
			F.LoanDtlClssCode,
			F.IsuNo,
			F.OrdPrc,
			F.CommdaCode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["AcntNo"] = new XAQueryFieldInfo("char", AcntNo, AcntNo, "계좌번호", (decimal)20);
			dict["InptPwd"] = new XAQueryFieldInfo("char", InptPwd, InptPwd, "입력비밀번호", (decimal)8);
			dict["LoanDtlClssCode"] = new XAQueryFieldInfo("char", LoanDtlClssCode, LoanDtlClssCode, "대출상세분류코드", (decimal)2);
			dict["IsuNo"] = new XAQueryFieldInfo("char", IsuNo, IsuNo, "종목번호", (decimal)12);
			dict["OrdPrc"] = new XAQueryFieldInfo("double", OrdPrc, OrdPrc.ToString("0000000000000.00"), "주문가", (decimal)13.2);
			dict["CommdaCode"] = new XAQueryFieldInfo("char", CommdaCode, CommdaCode, "통신매체코드", (decimal)2);

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

				case "InptPwd":
					this.InptPwd = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "LoanDtlClssCode":
					this.LoanDtlClssCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "IsuNo":
					this.IsuNo = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "OrdPrc":
					this.OrdPrc = fieldInfo.FieldValue.ParseDouble("OrdPrc");
				break;

				case "CommdaCode":
					this.CommdaCode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (RecCnt.ToString().Length > 5) return false; // long 5
			if (AcntNo?.Length > 20) return false; // char 20
			if (InptPwd?.Length > 8) return false; // char 8
			if (LoanDtlClssCode?.Length > 2) return false; // char 2
			if (IsuNo?.Length > 12) return false; // char 12
			// OrdPrc double 13.2
			if (CommdaCode?.Length > 2) return false; // char 2

			return true;
		}
	}

	public partial class XQCSPAQ00600OutBlock1 : XingBlock
	{
		/// <summary>
		/// CSPAQ00600OutBlock1
		/// </summary>
		public const string _blockName = "CSPAQ00600OutBlock1";
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
		/// CSPAQ00600OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CSPAQ00600OutBlock1
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
		/// 입력비밀번호
		/// </summary>
		[XAQueryFieldAttribute("InptPwd", "입력비밀번호", "char", "8")]
		public string InptPwd;
		/// <summary>
		/// 대출상세분류코드
		/// </summary>
		[XAQueryFieldAttribute("LoanDtlClssCode", "대출상세분류코드", "char", "2")]
		public string LoanDtlClssCode;
		/// <summary>
		/// 종목번호
		/// </summary>
		[XAQueryFieldAttribute("IsuNo", "종목번호", "char", "12")]
		public string IsuNo;
		/// <summary>
		/// 주문가
		/// </summary>
		[XAQueryFieldAttribute("OrdPrc", "주문가", "double", "13.2")]
		public double OrdPrc;
		/// <summary>
		/// 통신매체코드
		/// </summary>
		[XAQueryFieldAttribute("CommdaCode", "통신매체코드", "char", "2")]
		public string CommdaCode;

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
			/// 입력비밀번호
			/// </summary>
			public const string InptPwd = "InptPwd";
			/// <summary>
			/// 대출상세분류코드
			/// </summary>
			public const string LoanDtlClssCode = "LoanDtlClssCode";
			/// <summary>
			/// 종목번호
			/// </summary>
			public const string IsuNo = "IsuNo";
			/// <summary>
			/// 주문가
			/// </summary>
			public const string OrdPrc = "OrdPrc";
			/// <summary>
			/// 통신매체코드
			/// </summary>
			public const string CommdaCode = "CommdaCode";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.AcntNo,
			F.InptPwd,
			F.LoanDtlClssCode,
			F.IsuNo,
			F.OrdPrc,
			F.CommdaCode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["AcntNo"] = new XAQueryFieldInfo("char", AcntNo, AcntNo, "계좌번호", (decimal)20);
			dict["InptPwd"] = new XAQueryFieldInfo("char", InptPwd, InptPwd, "입력비밀번호", (decimal)8);
			dict["LoanDtlClssCode"] = new XAQueryFieldInfo("char", LoanDtlClssCode, LoanDtlClssCode, "대출상세분류코드", (decimal)2);
			dict["IsuNo"] = new XAQueryFieldInfo("char", IsuNo, IsuNo, "종목번호", (decimal)12);
			dict["OrdPrc"] = new XAQueryFieldInfo("double", OrdPrc, OrdPrc.ToString("0000000000000.00"), "주문가", (decimal)13.2);
			dict["CommdaCode"] = new XAQueryFieldInfo("char", CommdaCode, CommdaCode, "통신매체코드", (decimal)2);

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

				case "InptPwd":
					this.InptPwd = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "LoanDtlClssCode":
					this.LoanDtlClssCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "IsuNo":
					this.IsuNo = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "OrdPrc":
					this.OrdPrc = fieldInfo.FieldValue.ParseDouble("OrdPrc");
				break;

				case "CommdaCode":
					this.CommdaCode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQCSPAQ00600OutBlock1 FromQuery(XQCSPAQ00600 query)
		{
			XQCSPAQ00600OutBlock1 block = new XQCSPAQ00600OutBlock1();
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
				block.InptPwd = query.GetFieldData(block.GetBlockName(), "InptPwd", 0).TrimEnd('?'); // char 8
				block.LoanDtlClssCode = query.GetFieldData(block.GetBlockName(), "LoanDtlClssCode", 0).TrimEnd('?'); // char 2
				block.IsuNo = query.GetFieldData(block.GetBlockName(), "IsuNo", 0).TrimEnd('?'); // char 12
				block.OrdPrc = query.GetFieldData(block.GetBlockName(), "OrdPrc", 0).ParseDouble("OrdPrc"); // double 13.2
				block.CommdaCode = query.GetFieldData(block.GetBlockName(), "CommdaCode", 0).TrimEnd('?'); // char 2

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
			if (InptPwd?.Length > 8) return false; // char 8
			if (LoanDtlClssCode?.Length > 2) return false; // char 2
			if (IsuNo?.Length > 12) return false; // char 12
			// OrdPrc double 13.2
			if (CommdaCode?.Length > 2) return false; // char 2

			return true;
		}
	}

	public partial class XQCSPAQ00600OutBlock2 : XingBlock
	{
		/// <summary>
		/// CSPAQ00600OutBlock2
		/// </summary>
		public const string _blockName = "CSPAQ00600OutBlock2";
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
		/// CSPAQ00600OutBlock2
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CSPAQ00600OutBlock2
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
		/// 주문가
		/// </summary>
		[XAQueryFieldAttribute("OrdPrc", "주문가", "double", "13.2")]
		public double OrdPrc;
		/// <summary>
		/// 대주한도
		/// </summary>
		[XAQueryFieldAttribute("SloanLmtAmt", "대주한도", "long", "16")]
		public long SloanLmtAmt;
		/// <summary>
		/// 대주금액합계
		/// </summary>
		[XAQueryFieldAttribute("SloanAmtSum", "대주금액합계", "long", "16")]
		public long SloanAmtSum;
		/// <summary>
		/// 대주신규금액
		/// </summary>
		[XAQueryFieldAttribute("SloanNewAmt", "대주신규금액", "long", "16")]
		public long SloanNewAmt;
		/// <summary>
		/// 대주상환금액
		/// </summary>
		[XAQueryFieldAttribute("SloanRfundAmt", "대주상환금액", "long", "16")]
		public long SloanRfundAmt;
		/// <summary>
		/// 유통융자한도금액
		/// </summary>
		[XAQueryFieldAttribute("MktcplMloanLmtAmt", "유통융자한도금액", "long", "16")]
		public long MktcplMloanLmtAmt;
		/// <summary>
		/// 유통융자금액합계
		/// </summary>
		[XAQueryFieldAttribute("MktcplMloanAmtSum", "유통융자금액합계", "long", "16")]
		public long MktcplMloanAmtSum;
		/// <summary>
		/// 유통융자신규금액
		/// </summary>
		[XAQueryFieldAttribute("MktcplMloanNewAmt", "유통융자신규금액", "long", "16")]
		public long MktcplMloanNewAmt;
		/// <summary>
		/// 유통융자상환금액
		/// </summary>
		[XAQueryFieldAttribute("MktcplMloanRfundAmt", "유통융자상환금액", "long", "16")]
		public long MktcplMloanRfundAmt;
		/// <summary>
		/// 자기융자한도금액
		/// </summary>
		[XAQueryFieldAttribute("SfaccMloanLmtAmt", "자기융자한도금액", "long", "16")]
		public long SfaccMloanLmtAmt;
		/// <summary>
		/// 자기융자금액합계
		/// </summary>
		[XAQueryFieldAttribute("SfaccMloanAmtSum", "자기융자금액합계", "long", "16")]
		public long SfaccMloanAmtSum;
		/// <summary>
		/// 자기융자신규금액
		/// </summary>
		[XAQueryFieldAttribute("SfaccMloanNewAmt", "자기융자신규금액", "long", "16")]
		public long SfaccMloanNewAmt;
		/// <summary>
		/// 자기융자상환금액
		/// </summary>
		[XAQueryFieldAttribute("SfaccMloanRfundAmt", "자기융자상환금액", "long", "16")]
		public long SfaccMloanRfundAmt;
		/// <summary>
		/// 지점유통융자한도금액
		/// </summary>
		[XAQueryFieldAttribute("BrnMktcplMloanLmtAmt", "지점유통융자한도금액", "long", "16")]
		public long BrnMktcplMloanLmtAmt;
		/// <summary>
		/// 지점유통융자신규금액
		/// </summary>
		[XAQueryFieldAttribute("BrnMktcplMloanNewAmt", "지점유통융자신규금액", "long", "16")]
		public long BrnMktcplMloanNewAmt;
		/// <summary>
		/// 지점유통융자상환금액
		/// </summary>
		[XAQueryFieldAttribute("BrnMktcplMloanRfundAmt", "지점유통융자상환금액", "long", "16")]
		public long BrnMktcplMloanRfundAmt;
		/// <summary>
		/// 지점유통융자사용금액
		/// </summary>
		[XAQueryFieldAttribute("BrnMktcplMloanUseAmt", "지점유통융자사용금액", "long", "16")]
		public long BrnMktcplMloanUseAmt;
		/// <summary>
		/// 지점자기융자한도금액
		/// </summary>
		[XAQueryFieldAttribute("BrnSfaccMloanLmtAmt", "지점자기융자한도금액", "long", "16")]
		public long BrnSfaccMloanLmtAmt;
		/// <summary>
		/// 지점자기융자신규금액
		/// </summary>
		[XAQueryFieldAttribute("BrnSfaccMloanNewAmt", "지점자기융자신규금액", "long", "16")]
		public long BrnSfaccMloanNewAmt;
		/// <summary>
		/// 지점자기융자상환금액
		/// </summary>
		[XAQueryFieldAttribute("BrnSfaccMloanRfundAmt", "지점자기융자상환금액", "long", "16")]
		public long BrnSfaccMloanRfundAmt;
		/// <summary>
		/// 지점자기융자사용금액
		/// </summary>
		[XAQueryFieldAttribute("BrnSfaccMloanUseAmt", "지점자기융자사용금액", "long", "16")]
		public long BrnSfaccMloanUseAmt;
		/// <summary>
		/// 이용사융자한도관리여부
		/// </summary>
		[XAQueryFieldAttribute("FirmMloanLmtMgmtYn", "이용사융자한도관리여부", "char", "1")]
		public char FirmMloanLmtMgmtYn;
		/// <summary>
		/// 이용사신용종목제한구분
		/// </summary>
		[XAQueryFieldAttribute("FirmCrdtIsuRestrcTp", "이용사신용종목제한구분", "char", "1")]
		public char FirmCrdtIsuRestrcTp;
		/// <summary>
		/// 담보유지비율
		/// </summary>
		[XAQueryFieldAttribute("PldgMaintRat", "담보유지비율", "double", "7.4")]
		public double PldgMaintRat;
		/// <summary>
		/// 이용사명
		/// </summary>
		[XAQueryFieldAttribute("FirmNm", "이용사명", "char", "50")]
		public string FirmNm;
		/// <summary>
		/// 담보비율
		/// </summary>
		[XAQueryFieldAttribute("PldgRat", "담보비율", "double", "7.4")]
		public double PldgRat;
		/// <summary>
		/// 예탁자산합계
		/// </summary>
		[XAQueryFieldAttribute("DpsastSum", "예탁자산합계", "long", "17")]
		public long DpsastSum;
		/// <summary>
		/// 한도변경가능금액
		/// </summary>
		[XAQueryFieldAttribute("LmtChgAbleAmt", "한도변경가능금액", "long", "16")]
		public long LmtChgAbleAmt;
		/// <summary>
		/// 주문가능금액
		/// </summary>
		[XAQueryFieldAttribute("OrdAbleAmt", "주문가능금액", "long", "16")]
		public long OrdAbleAmt;
		/// <summary>
		/// 주문가능수량
		/// </summary>
		[XAQueryFieldAttribute("OrdAbleQty", "주문가능수량", "long", "16")]
		public long OrdAbleQty;
		/// <summary>
		/// 미수불가주문가능수량
		/// </summary>
		[XAQueryFieldAttribute("RcvblUablOrdAbleQty", "미수불가주문가능수량", "long", "16")]
		public long RcvblUablOrdAbleQty;

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
			/// 주문가
			/// </summary>
			public const string OrdPrc = "OrdPrc";
			/// <summary>
			/// 대주한도
			/// </summary>
			public const string SloanLmtAmt = "SloanLmtAmt";
			/// <summary>
			/// 대주금액합계
			/// </summary>
			public const string SloanAmtSum = "SloanAmtSum";
			/// <summary>
			/// 대주신규금액
			/// </summary>
			public const string SloanNewAmt = "SloanNewAmt";
			/// <summary>
			/// 대주상환금액
			/// </summary>
			public const string SloanRfundAmt = "SloanRfundAmt";
			/// <summary>
			/// 유통융자한도금액
			/// </summary>
			public const string MktcplMloanLmtAmt = "MktcplMloanLmtAmt";
			/// <summary>
			/// 유통융자금액합계
			/// </summary>
			public const string MktcplMloanAmtSum = "MktcplMloanAmtSum";
			/// <summary>
			/// 유통융자신규금액
			/// </summary>
			public const string MktcplMloanNewAmt = "MktcplMloanNewAmt";
			/// <summary>
			/// 유통융자상환금액
			/// </summary>
			public const string MktcplMloanRfundAmt = "MktcplMloanRfundAmt";
			/// <summary>
			/// 자기융자한도금액
			/// </summary>
			public const string SfaccMloanLmtAmt = "SfaccMloanLmtAmt";
			/// <summary>
			/// 자기융자금액합계
			/// </summary>
			public const string SfaccMloanAmtSum = "SfaccMloanAmtSum";
			/// <summary>
			/// 자기융자신규금액
			/// </summary>
			public const string SfaccMloanNewAmt = "SfaccMloanNewAmt";
			/// <summary>
			/// 자기융자상환금액
			/// </summary>
			public const string SfaccMloanRfundAmt = "SfaccMloanRfundAmt";
			/// <summary>
			/// 지점유통융자한도금액
			/// </summary>
			public const string BrnMktcplMloanLmtAmt = "BrnMktcplMloanLmtAmt";
			/// <summary>
			/// 지점유통융자신규금액
			/// </summary>
			public const string BrnMktcplMloanNewAmt = "BrnMktcplMloanNewAmt";
			/// <summary>
			/// 지점유통융자상환금액
			/// </summary>
			public const string BrnMktcplMloanRfundAmt = "BrnMktcplMloanRfundAmt";
			/// <summary>
			/// 지점유통융자사용금액
			/// </summary>
			public const string BrnMktcplMloanUseAmt = "BrnMktcplMloanUseAmt";
			/// <summary>
			/// 지점자기융자한도금액
			/// </summary>
			public const string BrnSfaccMloanLmtAmt = "BrnSfaccMloanLmtAmt";
			/// <summary>
			/// 지점자기융자신규금액
			/// </summary>
			public const string BrnSfaccMloanNewAmt = "BrnSfaccMloanNewAmt";
			/// <summary>
			/// 지점자기융자상환금액
			/// </summary>
			public const string BrnSfaccMloanRfundAmt = "BrnSfaccMloanRfundAmt";
			/// <summary>
			/// 지점자기융자사용금액
			/// </summary>
			public const string BrnSfaccMloanUseAmt = "BrnSfaccMloanUseAmt";
			/// <summary>
			/// 이용사융자한도관리여부
			/// </summary>
			public const string FirmMloanLmtMgmtYn = "FirmMloanLmtMgmtYn";
			/// <summary>
			/// 이용사신용종목제한구분
			/// </summary>
			public const string FirmCrdtIsuRestrcTp = "FirmCrdtIsuRestrcTp";
			/// <summary>
			/// 담보유지비율
			/// </summary>
			public const string PldgMaintRat = "PldgMaintRat";
			/// <summary>
			/// 이용사명
			/// </summary>
			public const string FirmNm = "FirmNm";
			/// <summary>
			/// 담보비율
			/// </summary>
			public const string PldgRat = "PldgRat";
			/// <summary>
			/// 예탁자산합계
			/// </summary>
			public const string DpsastSum = "DpsastSum";
			/// <summary>
			/// 한도변경가능금액
			/// </summary>
			public const string LmtChgAbleAmt = "LmtChgAbleAmt";
			/// <summary>
			/// 주문가능금액
			/// </summary>
			public const string OrdAbleAmt = "OrdAbleAmt";
			/// <summary>
			/// 주문가능수량
			/// </summary>
			public const string OrdAbleQty = "OrdAbleQty";
			/// <summary>
			/// 미수불가주문가능수량
			/// </summary>
			public const string RcvblUablOrdAbleQty = "RcvblUablOrdAbleQty";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.AcntNm,
			F.OrdPrc,
			F.SloanLmtAmt,
			F.SloanAmtSum,
			F.SloanNewAmt,
			F.SloanRfundAmt,
			F.MktcplMloanLmtAmt,
			F.MktcplMloanAmtSum,
			F.MktcplMloanNewAmt,
			F.MktcplMloanRfundAmt,
			F.SfaccMloanLmtAmt,
			F.SfaccMloanAmtSum,
			F.SfaccMloanNewAmt,
			F.SfaccMloanRfundAmt,
			F.BrnMktcplMloanLmtAmt,
			F.BrnMktcplMloanNewAmt,
			F.BrnMktcplMloanRfundAmt,
			F.BrnMktcplMloanUseAmt,
			F.BrnSfaccMloanLmtAmt,
			F.BrnSfaccMloanNewAmt,
			F.BrnSfaccMloanRfundAmt,
			F.BrnSfaccMloanUseAmt,
			F.FirmMloanLmtMgmtYn,
			F.FirmCrdtIsuRestrcTp,
			F.PldgMaintRat,
			F.FirmNm,
			F.PldgRat,
			F.DpsastSum,
			F.LmtChgAbleAmt,
			F.OrdAbleAmt,
			F.OrdAbleQty,
			F.RcvblUablOrdAbleQty,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["AcntNm"] = new XAQueryFieldInfo("char", AcntNm, AcntNm, "계좌명", (decimal)40);
			dict["OrdPrc"] = new XAQueryFieldInfo("double", OrdPrc, OrdPrc.ToString("0000000000000.00"), "주문가", (decimal)13.2);
			dict["SloanLmtAmt"] = new XAQueryFieldInfo("long", SloanLmtAmt, SloanLmtAmt.ToString("d16"), "대주한도", (decimal)16);
			dict["SloanAmtSum"] = new XAQueryFieldInfo("long", SloanAmtSum, SloanAmtSum.ToString("d16"), "대주금액합계", (decimal)16);
			dict["SloanNewAmt"] = new XAQueryFieldInfo("long", SloanNewAmt, SloanNewAmt.ToString("d16"), "대주신규금액", (decimal)16);
			dict["SloanRfundAmt"] = new XAQueryFieldInfo("long", SloanRfundAmt, SloanRfundAmt.ToString("d16"), "대주상환금액", (decimal)16);
			dict["MktcplMloanLmtAmt"] = new XAQueryFieldInfo("long", MktcplMloanLmtAmt, MktcplMloanLmtAmt.ToString("d16"), "유통융자한도금액", (decimal)16);
			dict["MktcplMloanAmtSum"] = new XAQueryFieldInfo("long", MktcplMloanAmtSum, MktcplMloanAmtSum.ToString("d16"), "유통융자금액합계", (decimal)16);
			dict["MktcplMloanNewAmt"] = new XAQueryFieldInfo("long", MktcplMloanNewAmt, MktcplMloanNewAmt.ToString("d16"), "유통융자신규금액", (decimal)16);
			dict["MktcplMloanRfundAmt"] = new XAQueryFieldInfo("long", MktcplMloanRfundAmt, MktcplMloanRfundAmt.ToString("d16"), "유통융자상환금액", (decimal)16);
			dict["SfaccMloanLmtAmt"] = new XAQueryFieldInfo("long", SfaccMloanLmtAmt, SfaccMloanLmtAmt.ToString("d16"), "자기융자한도금액", (decimal)16);
			dict["SfaccMloanAmtSum"] = new XAQueryFieldInfo("long", SfaccMloanAmtSum, SfaccMloanAmtSum.ToString("d16"), "자기융자금액합계", (decimal)16);
			dict["SfaccMloanNewAmt"] = new XAQueryFieldInfo("long", SfaccMloanNewAmt, SfaccMloanNewAmt.ToString("d16"), "자기융자신규금액", (decimal)16);
			dict["SfaccMloanRfundAmt"] = new XAQueryFieldInfo("long", SfaccMloanRfundAmt, SfaccMloanRfundAmt.ToString("d16"), "자기융자상환금액", (decimal)16);
			dict["BrnMktcplMloanLmtAmt"] = new XAQueryFieldInfo("long", BrnMktcplMloanLmtAmt, BrnMktcplMloanLmtAmt.ToString("d16"), "지점유통융자한도금액", (decimal)16);
			dict["BrnMktcplMloanNewAmt"] = new XAQueryFieldInfo("long", BrnMktcplMloanNewAmt, BrnMktcplMloanNewAmt.ToString("d16"), "지점유통융자신규금액", (decimal)16);
			dict["BrnMktcplMloanRfundAmt"] = new XAQueryFieldInfo("long", BrnMktcplMloanRfundAmt, BrnMktcplMloanRfundAmt.ToString("d16"), "지점유통융자상환금액", (decimal)16);
			dict["BrnMktcplMloanUseAmt"] = new XAQueryFieldInfo("long", BrnMktcplMloanUseAmt, BrnMktcplMloanUseAmt.ToString("d16"), "지점유통융자사용금액", (decimal)16);
			dict["BrnSfaccMloanLmtAmt"] = new XAQueryFieldInfo("long", BrnSfaccMloanLmtAmt, BrnSfaccMloanLmtAmt.ToString("d16"), "지점자기융자한도금액", (decimal)16);
			dict["BrnSfaccMloanNewAmt"] = new XAQueryFieldInfo("long", BrnSfaccMloanNewAmt, BrnSfaccMloanNewAmt.ToString("d16"), "지점자기융자신규금액", (decimal)16);
			dict["BrnSfaccMloanRfundAmt"] = new XAQueryFieldInfo("long", BrnSfaccMloanRfundAmt, BrnSfaccMloanRfundAmt.ToString("d16"), "지점자기융자상환금액", (decimal)16);
			dict["BrnSfaccMloanUseAmt"] = new XAQueryFieldInfo("long", BrnSfaccMloanUseAmt, BrnSfaccMloanUseAmt.ToString("d16"), "지점자기융자사용금액", (decimal)16);
			dict["FirmMloanLmtMgmtYn"] = new XAQueryFieldInfo("char", FirmMloanLmtMgmtYn, FirmMloanLmtMgmtYn.ToString(), "이용사융자한도관리여부", (decimal)1);
			dict["FirmCrdtIsuRestrcTp"] = new XAQueryFieldInfo("char", FirmCrdtIsuRestrcTp, FirmCrdtIsuRestrcTp.ToString(), "이용사신용종목제한구분", (decimal)1);
			dict["PldgMaintRat"] = new XAQueryFieldInfo("double", PldgMaintRat, PldgMaintRat.ToString("0000000.0000"), "담보유지비율", (decimal)7.4);
			dict["FirmNm"] = new XAQueryFieldInfo("char", FirmNm, FirmNm, "이용사명", (decimal)50);
			dict["PldgRat"] = new XAQueryFieldInfo("double", PldgRat, PldgRat.ToString("0000000.0000"), "담보비율", (decimal)7.4);
			dict["DpsastSum"] = new XAQueryFieldInfo("long", DpsastSum, DpsastSum.ToString("d17"), "예탁자산합계", (decimal)17);
			dict["LmtChgAbleAmt"] = new XAQueryFieldInfo("long", LmtChgAbleAmt, LmtChgAbleAmt.ToString("d16"), "한도변경가능금액", (decimal)16);
			dict["OrdAbleAmt"] = new XAQueryFieldInfo("long", OrdAbleAmt, OrdAbleAmt.ToString("d16"), "주문가능금액", (decimal)16);
			dict["OrdAbleQty"] = new XAQueryFieldInfo("long", OrdAbleQty, OrdAbleQty.ToString("d16"), "주문가능수량", (decimal)16);
			dict["RcvblUablOrdAbleQty"] = new XAQueryFieldInfo("long", RcvblUablOrdAbleQty, RcvblUablOrdAbleQty.ToString("d16"), "미수불가주문가능수량", (decimal)16);

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

				case "OrdPrc":
					this.OrdPrc = fieldInfo.FieldValue.ParseDouble("OrdPrc");
				break;

				case "SloanLmtAmt":
					this.SloanLmtAmt = fieldInfo.FieldValue.ParseLong("SloanLmtAmt");
				break;

				case "SloanAmtSum":
					this.SloanAmtSum = fieldInfo.FieldValue.ParseLong("SloanAmtSum");
				break;

				case "SloanNewAmt":
					this.SloanNewAmt = fieldInfo.FieldValue.ParseLong("SloanNewAmt");
				break;

				case "SloanRfundAmt":
					this.SloanRfundAmt = fieldInfo.FieldValue.ParseLong("SloanRfundAmt");
				break;

				case "MktcplMloanLmtAmt":
					this.MktcplMloanLmtAmt = fieldInfo.FieldValue.ParseLong("MktcplMloanLmtAmt");
				break;

				case "MktcplMloanAmtSum":
					this.MktcplMloanAmtSum = fieldInfo.FieldValue.ParseLong("MktcplMloanAmtSum");
				break;

				case "MktcplMloanNewAmt":
					this.MktcplMloanNewAmt = fieldInfo.FieldValue.ParseLong("MktcplMloanNewAmt");
				break;

				case "MktcplMloanRfundAmt":
					this.MktcplMloanRfundAmt = fieldInfo.FieldValue.ParseLong("MktcplMloanRfundAmt");
				break;

				case "SfaccMloanLmtAmt":
					this.SfaccMloanLmtAmt = fieldInfo.FieldValue.ParseLong("SfaccMloanLmtAmt");
				break;

				case "SfaccMloanAmtSum":
					this.SfaccMloanAmtSum = fieldInfo.FieldValue.ParseLong("SfaccMloanAmtSum");
				break;

				case "SfaccMloanNewAmt":
					this.SfaccMloanNewAmt = fieldInfo.FieldValue.ParseLong("SfaccMloanNewAmt");
				break;

				case "SfaccMloanRfundAmt":
					this.SfaccMloanRfundAmt = fieldInfo.FieldValue.ParseLong("SfaccMloanRfundAmt");
				break;

				case "BrnMktcplMloanLmtAmt":
					this.BrnMktcplMloanLmtAmt = fieldInfo.FieldValue.ParseLong("BrnMktcplMloanLmtAmt");
				break;

				case "BrnMktcplMloanNewAmt":
					this.BrnMktcplMloanNewAmt = fieldInfo.FieldValue.ParseLong("BrnMktcplMloanNewAmt");
				break;

				case "BrnMktcplMloanRfundAmt":
					this.BrnMktcplMloanRfundAmt = fieldInfo.FieldValue.ParseLong("BrnMktcplMloanRfundAmt");
				break;

				case "BrnMktcplMloanUseAmt":
					this.BrnMktcplMloanUseAmt = fieldInfo.FieldValue.ParseLong("BrnMktcplMloanUseAmt");
				break;

				case "BrnSfaccMloanLmtAmt":
					this.BrnSfaccMloanLmtAmt = fieldInfo.FieldValue.ParseLong("BrnSfaccMloanLmtAmt");
				break;

				case "BrnSfaccMloanNewAmt":
					this.BrnSfaccMloanNewAmt = fieldInfo.FieldValue.ParseLong("BrnSfaccMloanNewAmt");
				break;

				case "BrnSfaccMloanRfundAmt":
					this.BrnSfaccMloanRfundAmt = fieldInfo.FieldValue.ParseLong("BrnSfaccMloanRfundAmt");
				break;

				case "BrnSfaccMloanUseAmt":
					this.BrnSfaccMloanUseAmt = fieldInfo.FieldValue.ParseLong("BrnSfaccMloanUseAmt");
				break;

				case "FirmMloanLmtMgmtYn":
					this.FirmMloanLmtMgmtYn = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "FirmCrdtIsuRestrcTp":
					this.FirmCrdtIsuRestrcTp = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "PldgMaintRat":
					this.PldgMaintRat = fieldInfo.FieldValue.ParseDouble("PldgMaintRat");
				break;

				case "FirmNm":
					this.FirmNm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "PldgRat":
					this.PldgRat = fieldInfo.FieldValue.ParseDouble("PldgRat");
				break;

				case "DpsastSum":
					this.DpsastSum = fieldInfo.FieldValue.ParseLong("DpsastSum");
				break;

				case "LmtChgAbleAmt":
					this.LmtChgAbleAmt = fieldInfo.FieldValue.ParseLong("LmtChgAbleAmt");
				break;

				case "OrdAbleAmt":
					this.OrdAbleAmt = fieldInfo.FieldValue.ParseLong("OrdAbleAmt");
				break;

				case "OrdAbleQty":
					this.OrdAbleQty = fieldInfo.FieldValue.ParseLong("OrdAbleQty");
				break;

				case "RcvblUablOrdAbleQty":
					this.RcvblUablOrdAbleQty = fieldInfo.FieldValue.ParseLong("RcvblUablOrdAbleQty");
				break;


			}
		}

		public static XQCSPAQ00600OutBlock2 FromQuery(XQCSPAQ00600 query)
		{
			XQCSPAQ00600OutBlock2 block = new XQCSPAQ00600OutBlock2();
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
				block.OrdPrc = query.GetFieldData(block.GetBlockName(), "OrdPrc", 0).ParseDouble("OrdPrc"); // double 13.2
				block.SloanLmtAmt = query.GetFieldData(block.GetBlockName(), "SloanLmtAmt", 0).ParseLong("SloanLmtAmt"); // long 16
				block.SloanAmtSum = query.GetFieldData(block.GetBlockName(), "SloanAmtSum", 0).ParseLong("SloanAmtSum"); // long 16
				block.SloanNewAmt = query.GetFieldData(block.GetBlockName(), "SloanNewAmt", 0).ParseLong("SloanNewAmt"); // long 16
				block.SloanRfundAmt = query.GetFieldData(block.GetBlockName(), "SloanRfundAmt", 0).ParseLong("SloanRfundAmt"); // long 16
				block.MktcplMloanLmtAmt = query.GetFieldData(block.GetBlockName(), "MktcplMloanLmtAmt", 0).ParseLong("MktcplMloanLmtAmt"); // long 16
				block.MktcplMloanAmtSum = query.GetFieldData(block.GetBlockName(), "MktcplMloanAmtSum", 0).ParseLong("MktcplMloanAmtSum"); // long 16
				block.MktcplMloanNewAmt = query.GetFieldData(block.GetBlockName(), "MktcplMloanNewAmt", 0).ParseLong("MktcplMloanNewAmt"); // long 16
				block.MktcplMloanRfundAmt = query.GetFieldData(block.GetBlockName(), "MktcplMloanRfundAmt", 0).ParseLong("MktcplMloanRfundAmt"); // long 16
				block.SfaccMloanLmtAmt = query.GetFieldData(block.GetBlockName(), "SfaccMloanLmtAmt", 0).ParseLong("SfaccMloanLmtAmt"); // long 16
				block.SfaccMloanAmtSum = query.GetFieldData(block.GetBlockName(), "SfaccMloanAmtSum", 0).ParseLong("SfaccMloanAmtSum"); // long 16
				block.SfaccMloanNewAmt = query.GetFieldData(block.GetBlockName(), "SfaccMloanNewAmt", 0).ParseLong("SfaccMloanNewAmt"); // long 16
				block.SfaccMloanRfundAmt = query.GetFieldData(block.GetBlockName(), "SfaccMloanRfundAmt", 0).ParseLong("SfaccMloanRfundAmt"); // long 16
				block.BrnMktcplMloanLmtAmt = query.GetFieldData(block.GetBlockName(), "BrnMktcplMloanLmtAmt", 0).ParseLong("BrnMktcplMloanLmtAmt"); // long 16
				block.BrnMktcplMloanNewAmt = query.GetFieldData(block.GetBlockName(), "BrnMktcplMloanNewAmt", 0).ParseLong("BrnMktcplMloanNewAmt"); // long 16
				block.BrnMktcplMloanRfundAmt = query.GetFieldData(block.GetBlockName(), "BrnMktcplMloanRfundAmt", 0).ParseLong("BrnMktcplMloanRfundAmt"); // long 16
				block.BrnMktcplMloanUseAmt = query.GetFieldData(block.GetBlockName(), "BrnMktcplMloanUseAmt", 0).ParseLong("BrnMktcplMloanUseAmt"); // long 16
				block.BrnSfaccMloanLmtAmt = query.GetFieldData(block.GetBlockName(), "BrnSfaccMloanLmtAmt", 0).ParseLong("BrnSfaccMloanLmtAmt"); // long 16
				block.BrnSfaccMloanNewAmt = query.GetFieldData(block.GetBlockName(), "BrnSfaccMloanNewAmt", 0).ParseLong("BrnSfaccMloanNewAmt"); // long 16
				block.BrnSfaccMloanRfundAmt = query.GetFieldData(block.GetBlockName(), "BrnSfaccMloanRfundAmt", 0).ParseLong("BrnSfaccMloanRfundAmt"); // long 16
				block.BrnSfaccMloanUseAmt = query.GetFieldData(block.GetBlockName(), "BrnSfaccMloanUseAmt", 0).ParseLong("BrnSfaccMloanUseAmt"); // long 16
				block.FirmMloanLmtMgmtYn = query.GetFieldData(block.GetBlockName(), "FirmMloanLmtMgmtYn", 0).FirstOrDefault(); // char 1
				block.FirmCrdtIsuRestrcTp = query.GetFieldData(block.GetBlockName(), "FirmCrdtIsuRestrcTp", 0).FirstOrDefault(); // char 1
				block.PldgMaintRat = query.GetFieldData(block.GetBlockName(), "PldgMaintRat", 0).ParseDouble("PldgMaintRat"); // double 7.4
				block.FirmNm = query.GetFieldData(block.GetBlockName(), "FirmNm", 0).TrimEnd('?'); // char 50
				block.PldgRat = query.GetFieldData(block.GetBlockName(), "PldgRat", 0).ParseDouble("PldgRat"); // double 7.4
				block.DpsastSum = query.GetFieldData(block.GetBlockName(), "DpsastSum", 0).ParseLong("DpsastSum"); // long 17
				block.LmtChgAbleAmt = query.GetFieldData(block.GetBlockName(), "LmtChgAbleAmt", 0).ParseLong("LmtChgAbleAmt"); // long 16
				block.OrdAbleAmt = query.GetFieldData(block.GetBlockName(), "OrdAbleAmt", 0).ParseLong("OrdAbleAmt"); // long 16
				block.OrdAbleQty = query.GetFieldData(block.GetBlockName(), "OrdAbleQty", 0).ParseLong("OrdAbleQty"); // long 16
				block.RcvblUablOrdAbleQty = query.GetFieldData(block.GetBlockName(), "RcvblUablOrdAbleQty", 0).ParseLong("RcvblUablOrdAbleQty"); // long 16

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
			// OrdPrc double 13.2
			if (SloanLmtAmt.ToString().Length > 16) return false; // long 16
			if (SloanAmtSum.ToString().Length > 16) return false; // long 16
			if (SloanNewAmt.ToString().Length > 16) return false; // long 16
			if (SloanRfundAmt.ToString().Length > 16) return false; // long 16
			if (MktcplMloanLmtAmt.ToString().Length > 16) return false; // long 16
			if (MktcplMloanAmtSum.ToString().Length > 16) return false; // long 16
			if (MktcplMloanNewAmt.ToString().Length > 16) return false; // long 16
			if (MktcplMloanRfundAmt.ToString().Length > 16) return false; // long 16
			if (SfaccMloanLmtAmt.ToString().Length > 16) return false; // long 16
			if (SfaccMloanAmtSum.ToString().Length > 16) return false; // long 16
			if (SfaccMloanNewAmt.ToString().Length > 16) return false; // long 16
			if (SfaccMloanRfundAmt.ToString().Length > 16) return false; // long 16
			if (BrnMktcplMloanLmtAmt.ToString().Length > 16) return false; // long 16
			if (BrnMktcplMloanNewAmt.ToString().Length > 16) return false; // long 16
			if (BrnMktcplMloanRfundAmt.ToString().Length > 16) return false; // long 16
			if (BrnMktcplMloanUseAmt.ToString().Length > 16) return false; // long 16
			if (BrnSfaccMloanLmtAmt.ToString().Length > 16) return false; // long 16
			if (BrnSfaccMloanNewAmt.ToString().Length > 16) return false; // long 16
			if (BrnSfaccMloanRfundAmt.ToString().Length > 16) return false; // long 16
			if (BrnSfaccMloanUseAmt.ToString().Length > 16) return false; // long 16
			// FirmMloanLmtMgmtYn char 1
			// FirmCrdtIsuRestrcTp char 1
			// PldgMaintRat double 7.4
			if (FirmNm?.Length > 50) return false; // char 50
			// PldgRat double 7.4
			if (DpsastSum.ToString().Length > 17) return false; // long 17
			if (LmtChgAbleAmt.ToString().Length > 16) return false; // long 16
			if (OrdAbleAmt.ToString().Length > 16) return false; // long 16
			if (OrdAbleQty.ToString().Length > 16) return false; // long 16
			if (RcvblUablOrdAbleQty.ToString().Length > 16) return false; // long 16

			return true;
		}
	}

	/// <summary>
	/// 계좌별신용한도조회
	/// </summary>
	public partial class XQCSPAQ00600 : XingQuery
	{
		/// <summary>
		/// CSPAQ00600
		/// </summary>
		public const string _typeName = "CSPAQ00600";
		/// <summary>
		/// 계좌별신용한도조회
		/// </summary>
		public const string _typeDesc = "계좌별신용한도조회";
		/// <summary>
		/// CSPAQ00600
		/// </summary>
		public const string _service = "CSPAQ00600";
		/// <summary>
		/// B
		/// </summary>
		public const string _headType = "B";
		/// <summary>
		/// 송우석
		/// </summary>
		public const string _creator = "송우석";
		/// <summary>
		/// 2018/09/17 15:17:35
		/// </summary>
		public const string _createdDate = "2018/09/17 15:17:35";
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
		/// CSPAQ00600
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 계좌별신용한도조회
		/// </summary>
		public string TypeDesc => _typeDesc;
		/// <summary>
		/// CSPAQ00600
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
		/// 2018/09/17 15:17:35
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
		/// 계좌별신용한도조회
		/// </summary>
		public XQCSPAQ00600() : base("CSPAQ00600") { }




		public bool SetBlock(XQCSPAQ00600InBlock1 block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "RecCnt", 0, block.RecCnt.ToString("d5")); // long 5
			_xaQuery.SetFieldData(block.GetBlockName(), "AcntNo", 0, block.AcntNo); // char 20
			_xaQuery.SetFieldData(block.GetBlockName(), "InptPwd", 0, block.InptPwd); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "LoanDtlClssCode", 0, block.LoanDtlClssCode); // char 2
			_xaQuery.SetFieldData(block.GetBlockName(), "IsuNo", 0, block.IsuNo); // char 12
			_xaQuery.SetFieldData(block.GetBlockName(), "OrdPrc", 0, block.OrdPrc.ToString("0000000000000.00")); // double 13.2
			_xaQuery.SetFieldData(block.GetBlockName(), "CommdaCode", 0, block.CommdaCode); // char 2

			return true;
		}

		public XQCSPAQ00600OutBlock1 GetBlock1()
		{
			XQCSPAQ00600OutBlock1 instance = XQCSPAQ00600OutBlock1.FromQuery(this);
			return instance;

		}

		public XQCSPAQ00600OutBlock2 GetBlock2()
		{
			XQCSPAQ00600OutBlock2 instance = XQCSPAQ00600OutBlock2.FromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQCSPAQ00600OutBlock1),
			typeof(XQCSPAQ00600OutBlock2),

		};

	}

}
