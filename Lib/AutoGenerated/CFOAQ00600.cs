using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQCFOAQ00600InBlock1 : XingBlock
	{
		/// <summary>
		/// CFOAQ00600InBlock1
		/// </summary>
		public const string _blockName = "CFOAQ00600InBlock1";
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
		/// CFOAQ00600InBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CFOAQ00600InBlock1
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
		/// 선물옵션분류코드
		/// </summary>
		[XAQueryFieldAttribute("선물옵션분류코드")]
		public string FnoClssCode;
		/// <summary>
		/// 상품군코드
		/// </summary>
		[XAQueryFieldAttribute("상품군코드")]
		public string PrdgrpCode;
		/// <summary>
		/// 체결구분
		/// </summary>
		[XAQueryFieldAttribute("체결구분")]
		public char PrdtExecTpCode;
		/// <summary>
		/// 정렬순서구분
		/// </summary>
		[XAQueryFieldAttribute("정렬순서구분")]
		public char StnlnSeqTp;
		/// <summary>
		/// 통신매체코드
		/// </summary>
		[XAQueryFieldAttribute("통신매체코드")]
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
			/// 조회시작일
			/// </summary>
			public const string QrySrtDt = "QrySrtDt";
			/// <summary>
			/// 조회종료일
			/// </summary>
			public const string QryEndDt = "QryEndDt";
			/// <summary>
			/// 선물옵션분류코드
			/// </summary>
			public const string FnoClssCode = "FnoClssCode";
			/// <summary>
			/// 상품군코드
			/// </summary>
			public const string PrdgrpCode = "PrdgrpCode";
			/// <summary>
			/// 체결구분
			/// </summary>
			public const string PrdtExecTpCode = "PrdtExecTpCode";
			/// <summary>
			/// 정렬순서구분
			/// </summary>
			public const string StnlnSeqTp = "StnlnSeqTp";
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
			F.QrySrtDt,
			F.QryEndDt,
			F.FnoClssCode,
			F.PrdgrpCode,
			F.PrdtExecTpCode,
			F.StnlnSeqTp,
			F.CommdaCode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["AcntNo"] = new XAQueryFieldInfo("char", AcntNo, AcntNo, "계좌번호", (decimal)20);
			dict["InptPwd"] = new XAQueryFieldInfo("char", InptPwd, InptPwd, "입력비밀번호", (decimal)8);
			dict["QrySrtDt"] = new XAQueryFieldInfo("char", QrySrtDt, QrySrtDt, "조회시작일", (decimal)8);
			dict["QryEndDt"] = new XAQueryFieldInfo("char", QryEndDt, QryEndDt, "조회종료일", (decimal)8);
			dict["FnoClssCode"] = new XAQueryFieldInfo("char", FnoClssCode, FnoClssCode, "선물옵션분류코드", (decimal)2);
			dict["PrdgrpCode"] = new XAQueryFieldInfo("char", PrdgrpCode, PrdgrpCode, "상품군코드", (decimal)2);
			dict["PrdtExecTpCode"] = new XAQueryFieldInfo("char", PrdtExecTpCode, PrdtExecTpCode.ToString(), "체결구분", (decimal)1);
			dict["StnlnSeqTp"] = new XAQueryFieldInfo("char", StnlnSeqTp, StnlnSeqTp.ToString(), "정렬순서구분", (decimal)1);
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

				case "QrySrtDt":
					this.QrySrtDt = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "QryEndDt":
					this.QryEndDt = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "FnoClssCode":
					this.FnoClssCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "PrdgrpCode":
					this.PrdgrpCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "PrdtExecTpCode":
					this.PrdtExecTpCode = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "StnlnSeqTp":
					this.StnlnSeqTp = fieldInfo.FieldValue.FirstOrDefault();
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
			if (QrySrtDt?.Length > 8) return false; // char 8
			if (QryEndDt?.Length > 8) return false; // char 8
			if (FnoClssCode?.Length > 2) return false; // char 2
			if (PrdgrpCode?.Length > 2) return false; // char 2
			// PrdtExecTpCode char 1
			// StnlnSeqTp char 1
			if (CommdaCode?.Length > 2) return false; // char 2

			return true;
		}
	}

	public partial class XQCFOAQ00600OutBlock1 : XingBlock
	{
		/// <summary>
		/// CFOAQ00600OutBlock1
		/// </summary>
		public const string _blockName = "CFOAQ00600OutBlock1";
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
		/// CFOAQ00600OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CFOAQ00600OutBlock1
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
		/// 선물옵션분류코드
		/// </summary>
		[XAQueryFieldAttribute("선물옵션분류코드")]
		public string FnoClssCode;
		/// <summary>
		/// 상품군코드
		/// </summary>
		[XAQueryFieldAttribute("상품군코드")]
		public string PrdgrpCode;
		/// <summary>
		/// 체결구분
		/// </summary>
		[XAQueryFieldAttribute("체결구분")]
		public char PrdtExecTpCode;
		/// <summary>
		/// 정렬순서구분
		/// </summary>
		[XAQueryFieldAttribute("정렬순서구분")]
		public char StnlnSeqTp;
		/// <summary>
		/// 통신매체코드
		/// </summary>
		[XAQueryFieldAttribute("통신매체코드")]
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
			/// 조회시작일
			/// </summary>
			public const string QrySrtDt = "QrySrtDt";
			/// <summary>
			/// 조회종료일
			/// </summary>
			public const string QryEndDt = "QryEndDt";
			/// <summary>
			/// 선물옵션분류코드
			/// </summary>
			public const string FnoClssCode = "FnoClssCode";
			/// <summary>
			/// 상품군코드
			/// </summary>
			public const string PrdgrpCode = "PrdgrpCode";
			/// <summary>
			/// 체결구분
			/// </summary>
			public const string PrdtExecTpCode = "PrdtExecTpCode";
			/// <summary>
			/// 정렬순서구분
			/// </summary>
			public const string StnlnSeqTp = "StnlnSeqTp";
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
			F.QrySrtDt,
			F.QryEndDt,
			F.FnoClssCode,
			F.PrdgrpCode,
			F.PrdtExecTpCode,
			F.StnlnSeqTp,
			F.CommdaCode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["AcntNo"] = new XAQueryFieldInfo("char", AcntNo, AcntNo, "계좌번호", (decimal)20);
			dict["InptPwd"] = new XAQueryFieldInfo("char", InptPwd, InptPwd, "입력비밀번호", (decimal)8);
			dict["QrySrtDt"] = new XAQueryFieldInfo("char", QrySrtDt, QrySrtDt, "조회시작일", (decimal)8);
			dict["QryEndDt"] = new XAQueryFieldInfo("char", QryEndDt, QryEndDt, "조회종료일", (decimal)8);
			dict["FnoClssCode"] = new XAQueryFieldInfo("char", FnoClssCode, FnoClssCode, "선물옵션분류코드", (decimal)2);
			dict["PrdgrpCode"] = new XAQueryFieldInfo("char", PrdgrpCode, PrdgrpCode, "상품군코드", (decimal)2);
			dict["PrdtExecTpCode"] = new XAQueryFieldInfo("char", PrdtExecTpCode, PrdtExecTpCode.ToString(), "체결구분", (decimal)1);
			dict["StnlnSeqTp"] = new XAQueryFieldInfo("char", StnlnSeqTp, StnlnSeqTp.ToString(), "정렬순서구분", (decimal)1);
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

				case "QrySrtDt":
					this.QrySrtDt = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "QryEndDt":
					this.QryEndDt = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "FnoClssCode":
					this.FnoClssCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "PrdgrpCode":
					this.PrdgrpCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "PrdtExecTpCode":
					this.PrdtExecTpCode = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "StnlnSeqTp":
					this.StnlnSeqTp = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "CommdaCode":
					this.CommdaCode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQCFOAQ00600OutBlock1 FromQuery(XQCFOAQ00600 query)
		{
			XQCFOAQ00600OutBlock1 block = new XQCFOAQ00600OutBlock1();
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
				block.QrySrtDt = query.GetFieldData(block.GetBlockName(), "QrySrtDt", 0).TrimEnd('?'); // char 8
				block.QryEndDt = query.GetFieldData(block.GetBlockName(), "QryEndDt", 0).TrimEnd('?'); // char 8
				block.FnoClssCode = query.GetFieldData(block.GetBlockName(), "FnoClssCode", 0).TrimEnd('?'); // char 2
				block.PrdgrpCode = query.GetFieldData(block.GetBlockName(), "PrdgrpCode", 0).TrimEnd('?'); // char 2
				block.PrdtExecTpCode = query.GetFieldData(block.GetBlockName(), "PrdtExecTpCode", 0).FirstOrDefault(); // char 1
				block.StnlnSeqTp = query.GetFieldData(block.GetBlockName(), "StnlnSeqTp", 0).FirstOrDefault(); // char 1
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
			if (QrySrtDt?.Length > 8) return false; // char 8
			if (QryEndDt?.Length > 8) return false; // char 8
			if (FnoClssCode?.Length > 2) return false; // char 2
			if (PrdgrpCode?.Length > 2) return false; // char 2
			// PrdtExecTpCode char 1
			// StnlnSeqTp char 1
			if (CommdaCode?.Length > 2) return false; // char 2

			return true;
		}
	}

	public partial class XQCFOAQ00600OutBlock2 : XingBlock
	{
		/// <summary>
		/// CFOAQ00600OutBlock2
		/// </summary>
		public const string _blockName = "CFOAQ00600OutBlock2";
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
		/// CFOAQ00600OutBlock2
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CFOAQ00600OutBlock2
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
		/// <summary>
		/// 선물주문수량
		/// </summary>
		[XAQueryFieldAttribute("선물주문수량")]
		public long FutsOrdQty;
		/// <summary>
		/// 선물체결수량
		/// </summary>
		[XAQueryFieldAttribute("선물체결수량")]
		public long FutsExecQty;
		/// <summary>
		/// 옵션주문수량
		/// </summary>
		[XAQueryFieldAttribute("옵션주문수량")]
		public long OptOrdQty;
		/// <summary>
		/// 옵션체결수량
		/// </summary>
		[XAQueryFieldAttribute("옵션체결수량")]
		public long OptExecQty;

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
			/// 선물주문수량
			/// </summary>
			public const string FutsOrdQty = "FutsOrdQty";
			/// <summary>
			/// 선물체결수량
			/// </summary>
			public const string FutsExecQty = "FutsExecQty";
			/// <summary>
			/// 옵션주문수량
			/// </summary>
			public const string OptOrdQty = "OptOrdQty";
			/// <summary>
			/// 옵션체결수량
			/// </summary>
			public const string OptExecQty = "OptExecQty";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.AcntNm,
			F.FutsOrdQty,
			F.FutsExecQty,
			F.OptOrdQty,
			F.OptExecQty,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["AcntNm"] = new XAQueryFieldInfo("char", AcntNm, AcntNm, "계좌명", (decimal)40);
			dict["FutsOrdQty"] = new XAQueryFieldInfo("long", FutsOrdQty, FutsOrdQty.ToString("d16"), "선물주문수량", (decimal)16);
			dict["FutsExecQty"] = new XAQueryFieldInfo("long", FutsExecQty, FutsExecQty.ToString("d16"), "선물체결수량", (decimal)16);
			dict["OptOrdQty"] = new XAQueryFieldInfo("long", OptOrdQty, OptOrdQty.ToString("d16"), "옵션주문수량", (decimal)16);
			dict["OptExecQty"] = new XAQueryFieldInfo("long", OptExecQty, OptExecQty.ToString("d16"), "옵션체결수량", (decimal)16);

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

				case "FutsOrdQty":
					this.FutsOrdQty = fieldInfo.FieldValue.ParseLong("FutsOrdQty");
				break;

				case "FutsExecQty":
					this.FutsExecQty = fieldInfo.FieldValue.ParseLong("FutsExecQty");
				break;

				case "OptOrdQty":
					this.OptOrdQty = fieldInfo.FieldValue.ParseLong("OptOrdQty");
				break;

				case "OptExecQty":
					this.OptExecQty = fieldInfo.FieldValue.ParseLong("OptExecQty");
				break;


			}
		}

		public static XQCFOAQ00600OutBlock2 FromQuery(XQCFOAQ00600 query)
		{
			XQCFOAQ00600OutBlock2 block = new XQCFOAQ00600OutBlock2();
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
				block.FutsOrdQty = query.GetFieldData(block.GetBlockName(), "FutsOrdQty", 0).ParseLong("FutsOrdQty"); // long 16
				block.FutsExecQty = query.GetFieldData(block.GetBlockName(), "FutsExecQty", 0).ParseLong("FutsExecQty"); // long 16
				block.OptOrdQty = query.GetFieldData(block.GetBlockName(), "OptOrdQty", 0).ParseLong("OptOrdQty"); // long 16
				block.OptExecQty = query.GetFieldData(block.GetBlockName(), "OptExecQty", 0).ParseLong("OptExecQty"); // long 16

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
			if (FutsOrdQty.ToString().Length > 16) return false; // long 16
			if (FutsExecQty.ToString().Length > 16) return false; // long 16
			if (OptOrdQty.ToString().Length > 16) return false; // long 16
			if (OptExecQty.ToString().Length > 16) return false; // long 16

			return true;
		}
	}

	public partial class XQCFOAQ00600OutBlock3 : XingBlock
	{
		/// <summary>
		/// CFOAQ00600OutBlock3
		/// </summary>
		public const string _blockName = "CFOAQ00600OutBlock3";
		/// <summary>
		/// Out1(*EMPTY*)
		/// </summary>
		public const string _blockDesc = "Out1(*EMPTY*)";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// true
		/// </summary>
		public const bool _hasOccurs = true;
		/// <summary>
		/// CFOAQ00600OutBlock3
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CFOAQ00600OutBlock3
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// Out1(*EMPTY*)
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
		/// 주문일
		/// </summary>
		[XAQueryFieldAttribute("주문일")]
		public string OrdDt;
		/// <summary>
		/// 주문번호
		/// </summary>
		[XAQueryFieldAttribute("주문번호")]
		public long OrdNo;
		/// <summary>
		/// 원주문번호
		/// </summary>
		[XAQueryFieldAttribute("원주문번호")]
		public long OrgOrdNo;
		/// <summary>
		/// 주문시각
		/// </summary>
		[XAQueryFieldAttribute("주문시각")]
		public string OrdTime;
		/// <summary>
		/// 선물옵션종목번호
		/// </summary>
		[XAQueryFieldAttribute("선물옵션종목번호")]
		public string FnoIsuNo;
		/// <summary>
		/// 종목명
		/// </summary>
		[XAQueryFieldAttribute("종목명")]
		public string IsuNm;
		/// <summary>
		/// 매매구분
		/// </summary>
		[XAQueryFieldAttribute("매매구분")]
		public string BnsTpNm;
		/// <summary>
		/// 정정취소구분명
		/// </summary>
		[XAQueryFieldAttribute("정정취소구분명")]
		public string MrcTpNm;
		/// <summary>
		/// 선물옵션호가유형코드
		/// </summary>
		[XAQueryFieldAttribute("선물옵션호가유형코드")]
		public string FnoOrdprcPtnCode;
		/// <summary>
		/// 선물옵션호가유형명
		/// </summary>
		[XAQueryFieldAttribute("선물옵션호가유형명")]
		public string FnoOrdprcPtnNm;
		/// <summary>
		/// 주문가
		/// </summary>
		[XAQueryFieldAttribute("주문가")]
		public double OrdPrc;
		/// <summary>
		/// 주문수량
		/// </summary>
		[XAQueryFieldAttribute("주문수량")]
		public long OrdQty;
		/// <summary>
		/// 주문구분명
		/// </summary>
		[XAQueryFieldAttribute("주문구분명")]
		public string OrdTpNm;
		/// <summary>
		/// 체결구분명
		/// </summary>
		[XAQueryFieldAttribute("체결구분명")]
		public string ExecTpNm;
		/// <summary>
		/// 체결가
		/// </summary>
		[XAQueryFieldAttribute("체결가")]
		public double ExecPrc;
		/// <summary>
		/// 체결수량
		/// </summary>
		[XAQueryFieldAttribute("체결수량")]
		public long ExecQty;
		/// <summary>
		/// 약정시각
		/// </summary>
		[XAQueryFieldAttribute("약정시각")]
		public string CtrctTime;
		/// <summary>
		/// 약정번호
		/// </summary>
		[XAQueryFieldAttribute("약정번호")]
		public long CtrctNo;
		/// <summary>
		/// 체결번호
		/// </summary>
		[XAQueryFieldAttribute("체결번호")]
		public long ExecNo;
		/// <summary>
		/// 매매손익금액
		/// </summary>
		[XAQueryFieldAttribute("매매손익금액")]
		public long BnsplAmt;
		/// <summary>
		/// 미체결수량
		/// </summary>
		[XAQueryFieldAttribute("미체결수량")]
		public long UnercQty;
		/// <summary>
		/// 사용자ID
		/// </summary>
		[XAQueryFieldAttribute("사용자ID")]
		public string UserId;
		/// <summary>
		/// 통신매체코드
		/// </summary>
		[XAQueryFieldAttribute("통신매체코드")]
		public string CommdaCode;
		/// <summary>
		/// 통신매체코드명
		/// </summary>
		[XAQueryFieldAttribute("통신매체코드명")]
		public string CommdaCodeNm;

		public static class F
		{
			/// <summary>
			/// 주문일
			/// </summary>
			public const string OrdDt = "OrdDt";
			/// <summary>
			/// 주문번호
			/// </summary>
			public const string OrdNo = "OrdNo";
			/// <summary>
			/// 원주문번호
			/// </summary>
			public const string OrgOrdNo = "OrgOrdNo";
			/// <summary>
			/// 주문시각
			/// </summary>
			public const string OrdTime = "OrdTime";
			/// <summary>
			/// 선물옵션종목번호
			/// </summary>
			public const string FnoIsuNo = "FnoIsuNo";
			/// <summary>
			/// 종목명
			/// </summary>
			public const string IsuNm = "IsuNm";
			/// <summary>
			/// 매매구분
			/// </summary>
			public const string BnsTpNm = "BnsTpNm";
			/// <summary>
			/// 정정취소구분명
			/// </summary>
			public const string MrcTpNm = "MrcTpNm";
			/// <summary>
			/// 선물옵션호가유형코드
			/// </summary>
			public const string FnoOrdprcPtnCode = "FnoOrdprcPtnCode";
			/// <summary>
			/// 선물옵션호가유형명
			/// </summary>
			public const string FnoOrdprcPtnNm = "FnoOrdprcPtnNm";
			/// <summary>
			/// 주문가
			/// </summary>
			public const string OrdPrc = "OrdPrc";
			/// <summary>
			/// 주문수량
			/// </summary>
			public const string OrdQty = "OrdQty";
			/// <summary>
			/// 주문구분명
			/// </summary>
			public const string OrdTpNm = "OrdTpNm";
			/// <summary>
			/// 체결구분명
			/// </summary>
			public const string ExecTpNm = "ExecTpNm";
			/// <summary>
			/// 체결가
			/// </summary>
			public const string ExecPrc = "ExecPrc";
			/// <summary>
			/// 체결수량
			/// </summary>
			public const string ExecQty = "ExecQty";
			/// <summary>
			/// 약정시각
			/// </summary>
			public const string CtrctTime = "CtrctTime";
			/// <summary>
			/// 약정번호
			/// </summary>
			public const string CtrctNo = "CtrctNo";
			/// <summary>
			/// 체결번호
			/// </summary>
			public const string ExecNo = "ExecNo";
			/// <summary>
			/// 매매손익금액
			/// </summary>
			public const string BnsplAmt = "BnsplAmt";
			/// <summary>
			/// 미체결수량
			/// </summary>
			public const string UnercQty = "UnercQty";
			/// <summary>
			/// 사용자ID
			/// </summary>
			public const string UserId = "UserId";
			/// <summary>
			/// 통신매체코드
			/// </summary>
			public const string CommdaCode = "CommdaCode";
			/// <summary>
			/// 통신매체코드명
			/// </summary>
			public const string CommdaCodeNm = "CommdaCodeNm";
		}

		public static string[] AllFields = new string[]
		{
			F.OrdDt,
			F.OrdNo,
			F.OrgOrdNo,
			F.OrdTime,
			F.FnoIsuNo,
			F.IsuNm,
			F.BnsTpNm,
			F.MrcTpNm,
			F.FnoOrdprcPtnCode,
			F.FnoOrdprcPtnNm,
			F.OrdPrc,
			F.OrdQty,
			F.OrdTpNm,
			F.ExecTpNm,
			F.ExecPrc,
			F.ExecQty,
			F.CtrctTime,
			F.CtrctNo,
			F.ExecNo,
			F.BnsplAmt,
			F.UnercQty,
			F.UserId,
			F.CommdaCode,
			F.CommdaCodeNm,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["OrdDt"] = new XAQueryFieldInfo("char", OrdDt, OrdDt, "주문일", (decimal)8);
			dict["OrdNo"] = new XAQueryFieldInfo("long", OrdNo, OrdNo.ToString("d10"), "주문번호", (decimal)10);
			dict["OrgOrdNo"] = new XAQueryFieldInfo("long", OrgOrdNo, OrgOrdNo.ToString("d10"), "원주문번호", (decimal)10);
			dict["OrdTime"] = new XAQueryFieldInfo("char", OrdTime, OrdTime, "주문시각", (decimal)9);
			dict["FnoIsuNo"] = new XAQueryFieldInfo("char", FnoIsuNo, FnoIsuNo, "선물옵션종목번호", (decimal)12);
			dict["IsuNm"] = new XAQueryFieldInfo("char", IsuNm, IsuNm, "종목명", (decimal)40);
			dict["BnsTpNm"] = new XAQueryFieldInfo("char", BnsTpNm, BnsTpNm, "매매구분", (decimal)10);
			dict["MrcTpNm"] = new XAQueryFieldInfo("char", MrcTpNm, MrcTpNm, "정정취소구분명", (decimal)10);
			dict["FnoOrdprcPtnCode"] = new XAQueryFieldInfo("char", FnoOrdprcPtnCode, FnoOrdprcPtnCode, "선물옵션호가유형코드", (decimal)2);
			dict["FnoOrdprcPtnNm"] = new XAQueryFieldInfo("char", FnoOrdprcPtnNm, FnoOrdprcPtnNm, "선물옵션호가유형명", (decimal)40);
			dict["OrdPrc"] = new XAQueryFieldInfo("double", OrdPrc, OrdPrc.ToString("0000000000000.00"), "주문가", (decimal)13.2);
			dict["OrdQty"] = new XAQueryFieldInfo("long", OrdQty, OrdQty.ToString("d16"), "주문수량", (decimal)16);
			dict["OrdTpNm"] = new XAQueryFieldInfo("char", OrdTpNm, OrdTpNm, "주문구분명", (decimal)10);
			dict["ExecTpNm"] = new XAQueryFieldInfo("char", ExecTpNm, ExecTpNm, "체결구분명", (decimal)10);
			dict["ExecPrc"] = new XAQueryFieldInfo("double", ExecPrc, ExecPrc.ToString("0000000000000.00"), "체결가", (decimal)13.2);
			dict["ExecQty"] = new XAQueryFieldInfo("long", ExecQty, ExecQty.ToString("d16"), "체결수량", (decimal)16);
			dict["CtrctTime"] = new XAQueryFieldInfo("char", CtrctTime, CtrctTime, "약정시각", (decimal)9);
			dict["CtrctNo"] = new XAQueryFieldInfo("long", CtrctNo, CtrctNo.ToString("d10"), "약정번호", (decimal)10);
			dict["ExecNo"] = new XAQueryFieldInfo("long", ExecNo, ExecNo.ToString("d10"), "체결번호", (decimal)10);
			dict["BnsplAmt"] = new XAQueryFieldInfo("long", BnsplAmt, BnsplAmt.ToString("d16"), "매매손익금액", (decimal)16);
			dict["UnercQty"] = new XAQueryFieldInfo("long", UnercQty, UnercQty.ToString("d16"), "미체결수량", (decimal)16);
			dict["UserId"] = new XAQueryFieldInfo("char", UserId, UserId, "사용자ID", (decimal)16);
			dict["CommdaCode"] = new XAQueryFieldInfo("char", CommdaCode, CommdaCode, "통신매체코드", (decimal)2);
			dict["CommdaCodeNm"] = new XAQueryFieldInfo("char", CommdaCodeNm, CommdaCodeNm, "통신매체코드명", (decimal)40);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "OrdDt":
					this.OrdDt = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "OrdNo":
					this.OrdNo = fieldInfo.FieldValue.ParseLong("OrdNo");
				break;

				case "OrgOrdNo":
					this.OrgOrdNo = fieldInfo.FieldValue.ParseLong("OrgOrdNo");
				break;

				case "OrdTime":
					this.OrdTime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "FnoIsuNo":
					this.FnoIsuNo = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "IsuNm":
					this.IsuNm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "BnsTpNm":
					this.BnsTpNm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "MrcTpNm":
					this.MrcTpNm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "FnoOrdprcPtnCode":
					this.FnoOrdprcPtnCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "FnoOrdprcPtnNm":
					this.FnoOrdprcPtnNm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "OrdPrc":
					this.OrdPrc = fieldInfo.FieldValue.ParseDouble("OrdPrc");
				break;

				case "OrdQty":
					this.OrdQty = fieldInfo.FieldValue.ParseLong("OrdQty");
				break;

				case "OrdTpNm":
					this.OrdTpNm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ExecTpNm":
					this.ExecTpNm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ExecPrc":
					this.ExecPrc = fieldInfo.FieldValue.ParseDouble("ExecPrc");
				break;

				case "ExecQty":
					this.ExecQty = fieldInfo.FieldValue.ParseLong("ExecQty");
				break;

				case "CtrctTime":
					this.CtrctTime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "CtrctNo":
					this.CtrctNo = fieldInfo.FieldValue.ParseLong("CtrctNo");
				break;

				case "ExecNo":
					this.ExecNo = fieldInfo.FieldValue.ParseLong("ExecNo");
				break;

				case "BnsplAmt":
					this.BnsplAmt = fieldInfo.FieldValue.ParseLong("BnsplAmt");
				break;

				case "UnercQty":
					this.UnercQty = fieldInfo.FieldValue.ParseLong("UnercQty");
				break;

				case "UserId":
					this.UserId = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "CommdaCode":
					this.CommdaCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "CommdaCodeNm":
					this.CommdaCodeNm = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQCFOAQ00600OutBlock3[] ListFromQuery(XQCFOAQ00600 query)
		{
			int count = query.GetBlockCount(XQCFOAQ00600OutBlock3.BlockName);
			List<XQCFOAQ00600OutBlock3> list = new List<XQCFOAQ00600OutBlock3>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQCFOAQ00600OutBlock3 block = new XQCFOAQ00600OutBlock3();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.OrdDt = query.GetFieldData(block.GetBlockName(), "OrdDt", i).TrimEnd('?'); // char 8
					block.OrdNo = query.GetFieldData(block.GetBlockName(), "OrdNo", i).ParseLong("OrdNo"); // long 10
					block.OrgOrdNo = query.GetFieldData(block.GetBlockName(), "OrgOrdNo", i).ParseLong("OrgOrdNo"); // long 10
					block.OrdTime = query.GetFieldData(block.GetBlockName(), "OrdTime", i).TrimEnd('?'); // char 9
					block.FnoIsuNo = query.GetFieldData(block.GetBlockName(), "FnoIsuNo", i).TrimEnd('?'); // char 12
					block.IsuNm = query.GetFieldData(block.GetBlockName(), "IsuNm", i).TrimEnd('?'); // char 40
					block.BnsTpNm = query.GetFieldData(block.GetBlockName(), "BnsTpNm", i).TrimEnd('?'); // char 10
					block.MrcTpNm = query.GetFieldData(block.GetBlockName(), "MrcTpNm", i).TrimEnd('?'); // char 10
					block.FnoOrdprcPtnCode = query.GetFieldData(block.GetBlockName(), "FnoOrdprcPtnCode", i).TrimEnd('?'); // char 2
					block.FnoOrdprcPtnNm = query.GetFieldData(block.GetBlockName(), "FnoOrdprcPtnNm", i).TrimEnd('?'); // char 40
					block.OrdPrc = query.GetFieldData(block.GetBlockName(), "OrdPrc", i).ParseDouble("OrdPrc"); // double 13.2
					block.OrdQty = query.GetFieldData(block.GetBlockName(), "OrdQty", i).ParseLong("OrdQty"); // long 16
					block.OrdTpNm = query.GetFieldData(block.GetBlockName(), "OrdTpNm", i).TrimEnd('?'); // char 10
					block.ExecTpNm = query.GetFieldData(block.GetBlockName(), "ExecTpNm", i).TrimEnd('?'); // char 10
					block.ExecPrc = query.GetFieldData(block.GetBlockName(), "ExecPrc", i).ParseDouble("ExecPrc"); // double 13.2
					block.ExecQty = query.GetFieldData(block.GetBlockName(), "ExecQty", i).ParseLong("ExecQty"); // long 16
					block.CtrctTime = query.GetFieldData(block.GetBlockName(), "CtrctTime", i).TrimEnd('?'); // char 9
					block.CtrctNo = query.GetFieldData(block.GetBlockName(), "CtrctNo", i).ParseLong("CtrctNo"); // long 10
					block.ExecNo = query.GetFieldData(block.GetBlockName(), "ExecNo", i).ParseLong("ExecNo"); // long 10
					block.BnsplAmt = query.GetFieldData(block.GetBlockName(), "BnsplAmt", i).ParseLong("BnsplAmt"); // long 16
					block.UnercQty = query.GetFieldData(block.GetBlockName(), "UnercQty", i).ParseLong("UnercQty"); // long 16
					block.UserId = query.GetFieldData(block.GetBlockName(), "UserId", i).TrimEnd('?'); // char 16
					block.CommdaCode = query.GetFieldData(block.GetBlockName(), "CommdaCode", i).TrimEnd('?'); // char 2
					block.CommdaCodeNm = query.GetFieldData(block.GetBlockName(), "CommdaCodeNm", i).TrimEnd('?'); // char 40

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
			if (OrdDt?.Length > 8) return false; // char 8
			if (OrdNo.ToString().Length > 10) return false; // long 10
			if (OrgOrdNo.ToString().Length > 10) return false; // long 10
			if (OrdTime?.Length > 9) return false; // char 9
			if (FnoIsuNo?.Length > 12) return false; // char 12
			if (IsuNm?.Length > 40) return false; // char 40
			if (BnsTpNm?.Length > 10) return false; // char 10
			if (MrcTpNm?.Length > 10) return false; // char 10
			if (FnoOrdprcPtnCode?.Length > 2) return false; // char 2
			if (FnoOrdprcPtnNm?.Length > 40) return false; // char 40
			// OrdPrc double 13.2
			if (OrdQty.ToString().Length > 16) return false; // long 16
			if (OrdTpNm?.Length > 10) return false; // char 10
			if (ExecTpNm?.Length > 10) return false; // char 10
			// ExecPrc double 13.2
			if (ExecQty.ToString().Length > 16) return false; // long 16
			if (CtrctTime?.Length > 9) return false; // char 9
			if (CtrctNo.ToString().Length > 10) return false; // long 10
			if (ExecNo.ToString().Length > 10) return false; // long 10
			if (BnsplAmt.ToString().Length > 16) return false; // long 16
			if (UnercQty.ToString().Length > 16) return false; // long 16
			if (UserId?.Length > 16) return false; // char 16
			if (CommdaCode?.Length > 2) return false; // char 2
			if (CommdaCodeNm?.Length > 40) return false; // char 40

			return true;
		}
	}

	/// <summary>
	/// 선물옵션 계좌주문체결내역조회
	/// </summary>
	public partial class XQCFOAQ00600 : XingQuery
	{
		/// <summary>
		/// CFOAQ00600
		/// </summary>
		public const string _typeName = "CFOAQ00600";
		/// <summary>
		/// 선물옵션 계좌주문체결내역조회
		/// </summary>
		public const string _typeDesc = "선물옵션 계좌주문체결내역조회";
		/// <summary>
		/// CFOAQ00600
		/// </summary>
		public const string _service = "CFOAQ00600";
		/// <summary>
		/// B
		/// </summary>
		public const string _headType = "B";
		/// <summary>
		/// 정명기
		/// </summary>
		public const string _creator = "정명기";
		/// <summary>
		/// 2012/03/12 16:35:20
		/// </summary>
		public const string _createdDate = "2012/03/12 16:35:20";
		/// <summary>
		/// false
		/// </summary>
		public const bool _attr = false;
		/// <summary>
		/// false
		/// </summary>
		public const bool _block = false;
		/// <summary>
		/// true
		/// </summary>
		public const bool _encrypt = true;
		/// <summary>
		/// false
		/// </summary>
		public const bool _signature = false;

		/// <summary>
		/// CFOAQ00600
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 선물옵션 계좌주문체결내역조회
		/// </summary>
		public string TypeDesc => _typeDesc;
		/// <summary>
		/// CFOAQ00600
		/// </summary>
		public string Service => _service;
		/// <summary>
		/// B
		/// </summary>
		public string HeadType => _headType;
		/// <summary>
		/// 정명기
		/// </summary>
		public string Creator => _creator;
		/// <summary>
		/// 2012/03/12 16:35:20
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
		/// false
		/// </summary>
		public bool Signature => _signature;

		public XQCFOAQ00600() : base("CFOAQ00600") { }



		public bool SetBlock(XQCFOAQ00600InBlock1 block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "RecCnt", 0, block.RecCnt.ToString("d5")); // long 5
			_xaQuery.SetFieldData(block.GetBlockName(), "AcntNo", 0, block.AcntNo); // char 20
			_xaQuery.SetFieldData(block.GetBlockName(), "InptPwd", 0, block.InptPwd); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "QrySrtDt", 0, block.QrySrtDt); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "QryEndDt", 0, block.QryEndDt); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "FnoClssCode", 0, block.FnoClssCode); // char 2
			_xaQuery.SetFieldData(block.GetBlockName(), "PrdgrpCode", 0, block.PrdgrpCode); // char 2
			_xaQuery.SetFieldData(block.GetBlockName(), "PrdtExecTpCode", 0, block.PrdtExecTpCode.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "StnlnSeqTp", 0, block.StnlnSeqTp.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "CommdaCode", 0, block.CommdaCode); // char 2

			return true;
		}

		public XQCFOAQ00600OutBlock1 GetBlock1()
		{
			XQCFOAQ00600OutBlock1 instance = XQCFOAQ00600OutBlock1.FromQuery(this);
			return instance;

		}

		public XQCFOAQ00600OutBlock2 GetBlock2()
		{
			XQCFOAQ00600OutBlock2 instance = XQCFOAQ00600OutBlock2.FromQuery(this);
			return instance;

		}

		public XQCFOAQ00600OutBlock3[] GetBlock3s()
		{
			XQCFOAQ00600OutBlock3[] instance = XQCFOAQ00600OutBlock3.ListFromQuery(this);
			return instance;

		}


	}

}
