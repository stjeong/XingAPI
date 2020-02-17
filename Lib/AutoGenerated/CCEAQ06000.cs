using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQCCEAQ06000InBlock1 : XingBlock
	{
		/// <summary>
		/// CCEAQ06000InBlock1
		/// </summary>
		public const string _blockName = "CCEAQ06000InBlock1";
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
		/// CCEAQ06000InBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CCEAQ06000InBlock1
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
		/// 선택입력구분
		/// </summary>
		[XAQueryFieldAttribute("ChoicInptTpCode", "선택입력구분", "char", "1")]
		public char ChoicInptTpCode;
		/// <summary>
		/// 지점번호
		/// </summary>
		[XAQueryFieldAttribute("AcntNo", "지점번호", "char", "20")]
		public string AcntNo;
		/// <summary>
		/// 비밀번호
		/// </summary>
		[XAQueryFieldAttribute("Pwd", "비밀번호", "char", "8")]
		public string Pwd;
		/// <summary>
		/// 조회시작일
		/// </summary>
		[XAQueryFieldAttribute("QrySrtDt", "조회시작일", "char", "8")]
		public string QrySrtDt;
		/// <summary>
		/// 조회종료일
		/// </summary>
		[XAQueryFieldAttribute("QryEndDt", "조회종료일", "char", "8")]
		public string QryEndDt;
		/// <summary>
		/// 선물옵션분류코드
		/// </summary>
		[XAQueryFieldAttribute("FnoClssCode", "선물옵션분류코드", "char", "2")]
		public string FnoClssCode;
		/// <summary>
		/// 상품군코드
		/// </summary>
		[XAQueryFieldAttribute("PrdgrpCode", "상품군코드", "char", "2")]
		public string PrdgrpCode;
		/// <summary>
		/// 체결구분
		/// </summary>
		[XAQueryFieldAttribute("PrdtExecTpCode", "체결구분", "char", "1")]
		public char PrdtExecTpCode;
		/// <summary>
		/// 선물옵션거래유형코드
		/// </summary>
		[XAQueryFieldAttribute("FnoTrdPtnCode", "선물옵션거래유형코드", "char", "2")]
		public string FnoTrdPtnCode;
		/// <summary>
		/// 시작주문번호2
		/// </summary>
		[XAQueryFieldAttribute("SrtOrdNo2", "시작주문번호2", "long", "10")]
		public long SrtOrdNo2;
		/// <summary>
		/// 종료번호
		/// </summary>
		[XAQueryFieldAttribute("EndNo", "종료번호", "long", "10")]
		public long EndNo;
		/// <summary>
		/// 정렬순서구분
		/// </summary>
		[XAQueryFieldAttribute("StnlnSeqTp", "정렬순서구분", "char", "1")]
		public char StnlnSeqTp;

		public static class F
		{
			/// <summary>
			/// 레코드갯수
			/// </summary>
			public const string RecCnt = "RecCnt";
			/// <summary>
			/// 선택입력구분
			/// </summary>
			public const string ChoicInptTpCode = "ChoicInptTpCode";
			/// <summary>
			/// 지점번호
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
			/// 선물옵션거래유형코드
			/// </summary>
			public const string FnoTrdPtnCode = "FnoTrdPtnCode";
			/// <summary>
			/// 시작주문번호2
			/// </summary>
			public const string SrtOrdNo2 = "SrtOrdNo2";
			/// <summary>
			/// 종료번호
			/// </summary>
			public const string EndNo = "EndNo";
			/// <summary>
			/// 정렬순서구분
			/// </summary>
			public const string StnlnSeqTp = "StnlnSeqTp";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.ChoicInptTpCode,
			F.AcntNo,
			F.Pwd,
			F.QrySrtDt,
			F.QryEndDt,
			F.FnoClssCode,
			F.PrdgrpCode,
			F.PrdtExecTpCode,
			F.FnoTrdPtnCode,
			F.SrtOrdNo2,
			F.EndNo,
			F.StnlnSeqTp,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["ChoicInptTpCode"] = new XAQueryFieldInfo("char", ChoicInptTpCode, ChoicInptTpCode.ToString(), "선택입력구분", (decimal)1);
			dict["AcntNo"] = new XAQueryFieldInfo("char", AcntNo, AcntNo, "지점번호", (decimal)20);
			dict["Pwd"] = new XAQueryFieldInfo("char", Pwd, Pwd, "비밀번호", (decimal)8);
			dict["QrySrtDt"] = new XAQueryFieldInfo("char", QrySrtDt, QrySrtDt, "조회시작일", (decimal)8);
			dict["QryEndDt"] = new XAQueryFieldInfo("char", QryEndDt, QryEndDt, "조회종료일", (decimal)8);
			dict["FnoClssCode"] = new XAQueryFieldInfo("char", FnoClssCode, FnoClssCode, "선물옵션분류코드", (decimal)2);
			dict["PrdgrpCode"] = new XAQueryFieldInfo("char", PrdgrpCode, PrdgrpCode, "상품군코드", (decimal)2);
			dict["PrdtExecTpCode"] = new XAQueryFieldInfo("char", PrdtExecTpCode, PrdtExecTpCode.ToString(), "체결구분", (decimal)1);
			dict["FnoTrdPtnCode"] = new XAQueryFieldInfo("char", FnoTrdPtnCode, FnoTrdPtnCode, "선물옵션거래유형코드", (decimal)2);
			dict["SrtOrdNo2"] = new XAQueryFieldInfo("long", SrtOrdNo2, SrtOrdNo2.ToString("d10"), "시작주문번호2", (decimal)10);
			dict["EndNo"] = new XAQueryFieldInfo("long", EndNo, EndNo.ToString("d10"), "종료번호", (decimal)10);
			dict["StnlnSeqTp"] = new XAQueryFieldInfo("char", StnlnSeqTp, StnlnSeqTp.ToString(), "정렬순서구분", (decimal)1);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "RecCnt":
					this.RecCnt = fieldInfo.FieldValue.ParseLong("RecCnt");
				break;

				case "ChoicInptTpCode":
					this.ChoicInptTpCode = fieldInfo.FieldValue.FirstOrDefault();
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

				case "FnoClssCode":
					this.FnoClssCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "PrdgrpCode":
					this.PrdgrpCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "PrdtExecTpCode":
					this.PrdtExecTpCode = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "FnoTrdPtnCode":
					this.FnoTrdPtnCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "SrtOrdNo2":
					this.SrtOrdNo2 = fieldInfo.FieldValue.ParseLong("SrtOrdNo2");
				break;

				case "EndNo":
					this.EndNo = fieldInfo.FieldValue.ParseLong("EndNo");
				break;

				case "StnlnSeqTp":
					this.StnlnSeqTp = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public bool VerifyData()
		{
			if (RecCnt.ToString().Length > 5) return false; // long 5
			// ChoicInptTpCode char 1
			if (AcntNo?.Length > 20) return false; // char 20
			if (Pwd?.Length > 8) return false; // char 8
			if (QrySrtDt?.Length > 8) return false; // char 8
			if (QryEndDt?.Length > 8) return false; // char 8
			if (FnoClssCode?.Length > 2) return false; // char 2
			if (PrdgrpCode?.Length > 2) return false; // char 2
			// PrdtExecTpCode char 1
			if (FnoTrdPtnCode?.Length > 2) return false; // char 2
			if (SrtOrdNo2.ToString().Length > 10) return false; // long 10
			if (EndNo.ToString().Length > 10) return false; // long 10
			// StnlnSeqTp char 1

			return true;
		}
	}

	public partial class XQCCEAQ06000OutBlock1 : XingBlock
	{
		/// <summary>
		/// CCEAQ06000OutBlock1
		/// </summary>
		public const string _blockName = "CCEAQ06000OutBlock1";
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
		/// CCEAQ06000OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CCEAQ06000OutBlock1
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
		/// 선택입력구분
		/// </summary>
		[XAQueryFieldAttribute("ChoicInptTpCode", "선택입력구분", "char", "1")]
		public char ChoicInptTpCode;
		/// <summary>
		/// 지점번호
		/// </summary>
		[XAQueryFieldAttribute("AcntNo", "지점번호", "char", "20")]
		public string AcntNo;
		/// <summary>
		/// 비밀번호
		/// </summary>
		[XAQueryFieldAttribute("Pwd", "비밀번호", "char", "8")]
		public string Pwd;
		/// <summary>
		/// 조회시작일
		/// </summary>
		[XAQueryFieldAttribute("QrySrtDt", "조회시작일", "char", "8")]
		public string QrySrtDt;
		/// <summary>
		/// 조회종료일
		/// </summary>
		[XAQueryFieldAttribute("QryEndDt", "조회종료일", "char", "8")]
		public string QryEndDt;
		/// <summary>
		/// 선물옵션분류코드
		/// </summary>
		[XAQueryFieldAttribute("FnoClssCode", "선물옵션분류코드", "char", "2")]
		public string FnoClssCode;
		/// <summary>
		/// 상품군코드
		/// </summary>
		[XAQueryFieldAttribute("PrdgrpCode", "상품군코드", "char", "2")]
		public string PrdgrpCode;
		/// <summary>
		/// 체결구분
		/// </summary>
		[XAQueryFieldAttribute("PrdtExecTpCode", "체결구분", "char", "1")]
		public char PrdtExecTpCode;
		/// <summary>
		/// 선물옵션거래유형코드
		/// </summary>
		[XAQueryFieldAttribute("FnoTrdPtnCode", "선물옵션거래유형코드", "char", "2")]
		public string FnoTrdPtnCode;
		/// <summary>
		/// 시작주문번호2
		/// </summary>
		[XAQueryFieldAttribute("SrtOrdNo2", "시작주문번호2", "long", "10")]
		public long SrtOrdNo2;
		/// <summary>
		/// 종료번호
		/// </summary>
		[XAQueryFieldAttribute("EndNo", "종료번호", "long", "10")]
		public long EndNo;
		/// <summary>
		/// 정렬순서구분
		/// </summary>
		[XAQueryFieldAttribute("StnlnSeqTp", "정렬순서구분", "char", "1")]
		public char StnlnSeqTp;

		public static class F
		{
			/// <summary>
			/// 레코드갯수
			/// </summary>
			public const string RecCnt = "RecCnt";
			/// <summary>
			/// 선택입력구분
			/// </summary>
			public const string ChoicInptTpCode = "ChoicInptTpCode";
			/// <summary>
			/// 지점번호
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
			/// 선물옵션거래유형코드
			/// </summary>
			public const string FnoTrdPtnCode = "FnoTrdPtnCode";
			/// <summary>
			/// 시작주문번호2
			/// </summary>
			public const string SrtOrdNo2 = "SrtOrdNo2";
			/// <summary>
			/// 종료번호
			/// </summary>
			public const string EndNo = "EndNo";
			/// <summary>
			/// 정렬순서구분
			/// </summary>
			public const string StnlnSeqTp = "StnlnSeqTp";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.ChoicInptTpCode,
			F.AcntNo,
			F.Pwd,
			F.QrySrtDt,
			F.QryEndDt,
			F.FnoClssCode,
			F.PrdgrpCode,
			F.PrdtExecTpCode,
			F.FnoTrdPtnCode,
			F.SrtOrdNo2,
			F.EndNo,
			F.StnlnSeqTp,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["ChoicInptTpCode"] = new XAQueryFieldInfo("char", ChoicInptTpCode, ChoicInptTpCode.ToString(), "선택입력구분", (decimal)1);
			dict["AcntNo"] = new XAQueryFieldInfo("char", AcntNo, AcntNo, "지점번호", (decimal)20);
			dict["Pwd"] = new XAQueryFieldInfo("char", Pwd, Pwd, "비밀번호", (decimal)8);
			dict["QrySrtDt"] = new XAQueryFieldInfo("char", QrySrtDt, QrySrtDt, "조회시작일", (decimal)8);
			dict["QryEndDt"] = new XAQueryFieldInfo("char", QryEndDt, QryEndDt, "조회종료일", (decimal)8);
			dict["FnoClssCode"] = new XAQueryFieldInfo("char", FnoClssCode, FnoClssCode, "선물옵션분류코드", (decimal)2);
			dict["PrdgrpCode"] = new XAQueryFieldInfo("char", PrdgrpCode, PrdgrpCode, "상품군코드", (decimal)2);
			dict["PrdtExecTpCode"] = new XAQueryFieldInfo("char", PrdtExecTpCode, PrdtExecTpCode.ToString(), "체결구분", (decimal)1);
			dict["FnoTrdPtnCode"] = new XAQueryFieldInfo("char", FnoTrdPtnCode, FnoTrdPtnCode, "선물옵션거래유형코드", (decimal)2);
			dict["SrtOrdNo2"] = new XAQueryFieldInfo("long", SrtOrdNo2, SrtOrdNo2.ToString("d10"), "시작주문번호2", (decimal)10);
			dict["EndNo"] = new XAQueryFieldInfo("long", EndNo, EndNo.ToString("d10"), "종료번호", (decimal)10);
			dict["StnlnSeqTp"] = new XAQueryFieldInfo("char", StnlnSeqTp, StnlnSeqTp.ToString(), "정렬순서구분", (decimal)1);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "RecCnt":
					this.RecCnt = fieldInfo.FieldValue.ParseLong("RecCnt");
				break;

				case "ChoicInptTpCode":
					this.ChoicInptTpCode = fieldInfo.FieldValue.FirstOrDefault();
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

				case "FnoClssCode":
					this.FnoClssCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "PrdgrpCode":
					this.PrdgrpCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "PrdtExecTpCode":
					this.PrdtExecTpCode = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "FnoTrdPtnCode":
					this.FnoTrdPtnCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "SrtOrdNo2":
					this.SrtOrdNo2 = fieldInfo.FieldValue.ParseLong("SrtOrdNo2");
				break;

				case "EndNo":
					this.EndNo = fieldInfo.FieldValue.ParseLong("EndNo");
				break;

				case "StnlnSeqTp":
					this.StnlnSeqTp = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public static XQCCEAQ06000OutBlock1 FromQuery(XQCCEAQ06000 query)
		{
			XQCCEAQ06000OutBlock1 block = new XQCCEAQ06000OutBlock1();
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
				block.ChoicInptTpCode = query.GetFieldData(block.GetBlockName(), "ChoicInptTpCode", 0).FirstOrDefault(); // char 1
				block.AcntNo = query.GetFieldData(block.GetBlockName(), "AcntNo", 0).TrimEnd('?'); // char 20
				block.Pwd = query.GetFieldData(block.GetBlockName(), "Pwd", 0).TrimEnd('?'); // char 8
				block.QrySrtDt = query.GetFieldData(block.GetBlockName(), "QrySrtDt", 0).TrimEnd('?'); // char 8
				block.QryEndDt = query.GetFieldData(block.GetBlockName(), "QryEndDt", 0).TrimEnd('?'); // char 8
				block.FnoClssCode = query.GetFieldData(block.GetBlockName(), "FnoClssCode", 0).TrimEnd('?'); // char 2
				block.PrdgrpCode = query.GetFieldData(block.GetBlockName(), "PrdgrpCode", 0).TrimEnd('?'); // char 2
				block.PrdtExecTpCode = query.GetFieldData(block.GetBlockName(), "PrdtExecTpCode", 0).FirstOrDefault(); // char 1
				block.FnoTrdPtnCode = query.GetFieldData(block.GetBlockName(), "FnoTrdPtnCode", 0).TrimEnd('?'); // char 2
				block.SrtOrdNo2 = query.GetFieldData(block.GetBlockName(), "SrtOrdNo2", 0).ParseLong("SrtOrdNo2"); // long 10
				block.EndNo = query.GetFieldData(block.GetBlockName(), "EndNo", 0).ParseLong("EndNo"); // long 10
				block.StnlnSeqTp = query.GetFieldData(block.GetBlockName(), "StnlnSeqTp", 0).FirstOrDefault(); // char 1

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (RecCnt.ToString().Length > 5) return false; // long 5
			// ChoicInptTpCode char 1
			if (AcntNo?.Length > 20) return false; // char 20
			if (Pwd?.Length > 8) return false; // char 8
			if (QrySrtDt?.Length > 8) return false; // char 8
			if (QryEndDt?.Length > 8) return false; // char 8
			if (FnoClssCode?.Length > 2) return false; // char 2
			if (PrdgrpCode?.Length > 2) return false; // char 2
			// PrdtExecTpCode char 1
			if (FnoTrdPtnCode?.Length > 2) return false; // char 2
			if (SrtOrdNo2.ToString().Length > 10) return false; // long 10
			if (EndNo.ToString().Length > 10) return false; // long 10
			// StnlnSeqTp char 1

			return true;
		}
	}

	public partial class XQCCEAQ06000OutBlock2 : XingBlock
	{
		/// <summary>
		/// CCEAQ06000OutBlock2
		/// </summary>
		public const string _blockName = "CCEAQ06000OutBlock2";
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
		/// CCEAQ06000OutBlock2
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CCEAQ06000OutBlock2
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
		/// 선물주문수량
		/// </summary>
		[XAQueryFieldAttribute("FutsOrdQty", "선물주문수량", "long", "16")]
		public long FutsOrdQty;
		/// <summary>
		/// 선물체결수량
		/// </summary>
		[XAQueryFieldAttribute("FutsExecQty", "선물체결수량", "long", "16")]
		public long FutsExecQty;

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
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.AcntNm,
			F.FutsOrdQty,
			F.FutsExecQty,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["AcntNm"] = new XAQueryFieldInfo("char", AcntNm, AcntNm, "계좌명", (decimal)40);
			dict["FutsOrdQty"] = new XAQueryFieldInfo("long", FutsOrdQty, FutsOrdQty.ToString("d16"), "선물주문수량", (decimal)16);
			dict["FutsExecQty"] = new XAQueryFieldInfo("long", FutsExecQty, FutsExecQty.ToString("d16"), "선물체결수량", (decimal)16);

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


			}
		}

		public static XQCCEAQ06000OutBlock2 FromQuery(XQCCEAQ06000 query)
		{
			XQCCEAQ06000OutBlock2 block = new XQCCEAQ06000OutBlock2();
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

			return true;
		}
	}

	public partial class XQCCEAQ06000OutBlock3 : XingBlock
	{
		/// <summary>
		/// CCEAQ06000OutBlock3
		/// </summary>
		public const string _blockName = "CCEAQ06000OutBlock3";
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
		/// CCEAQ06000OutBlock3
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CCEAQ06000OutBlock3
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
		/// 계좌번호1
		/// </summary>
		[XAQueryFieldAttribute("AcntNo1", "계좌번호1", "char", "20")]
		public string AcntNo1;
		/// <summary>
		/// 주문일
		/// </summary>
		[XAQueryFieldAttribute("OrdDt", "주문일", "char", "8")]
		public string OrdDt;
		/// <summary>
		/// 주문번호
		/// </summary>
		[XAQueryFieldAttribute("OrdNo", "주문번호", "long", "10")]
		public long OrdNo;
		/// <summary>
		/// 원주문번호
		/// </summary>
		[XAQueryFieldAttribute("OrgOrdNo", "원주문번호", "long", "10")]
		public long OrgOrdNo;
		/// <summary>
		/// 주문시각
		/// </summary>
		[XAQueryFieldAttribute("OrdTime", "주문시각", "char", "9")]
		public string OrdTime;
		/// <summary>
		/// 선물옵션종목번호
		/// </summary>
		[XAQueryFieldAttribute("FnoIsuNo", "선물옵션종목번호", "char", "12")]
		public string FnoIsuNo;
		/// <summary>
		/// 종목명
		/// </summary>
		[XAQueryFieldAttribute("IsuNm", "종목명", "char", "40")]
		public string IsuNm;
		/// <summary>
		/// 매매구분
		/// </summary>
		[XAQueryFieldAttribute("BnsTpNm", "매매구분", "char", "10")]
		public string BnsTpNm;
		/// <summary>
		/// 매매구분
		/// </summary>
		[XAQueryFieldAttribute("BnsTpCode", "매매구분", "char", "1")]
		public char BnsTpCode;
		/// <summary>
		/// 정정취소구분명
		/// </summary>
		[XAQueryFieldAttribute("MrcTpNm", "정정취소구분명", "char", "10")]
		public string MrcTpNm;
		/// <summary>
		/// 선물옵션호가유형코드
		/// </summary>
		[XAQueryFieldAttribute("FnoOrdprcPtnCode", "선물옵션호가유형코드", "char", "2")]
		public string FnoOrdprcPtnCode;
		/// <summary>
		/// 선물옵션호가유형명
		/// </summary>
		[XAQueryFieldAttribute("FnoOrdprcPtnNm", "선물옵션호가유형명", "char", "40")]
		public string FnoOrdprcPtnNm;
		/// <summary>
		/// 주문가
		/// </summary>
		[XAQueryFieldAttribute("OrdPrc", "주문가", "double", "13.2")]
		public double OrdPrc;
		/// <summary>
		/// 주문수량
		/// </summary>
		[XAQueryFieldAttribute("OrdQty", "주문수량", "long", "16")]
		public long OrdQty;
		/// <summary>
		/// 주문구분명
		/// </summary>
		[XAQueryFieldAttribute("OrdTpNm", "주문구분명", "char", "10")]
		public string OrdTpNm;
		/// <summary>
		/// 체결구분명
		/// </summary>
		[XAQueryFieldAttribute("ExecTpNm", "체결구분명", "char", "10")]
		public string ExecTpNm;
		/// <summary>
		/// 체결가
		/// </summary>
		[XAQueryFieldAttribute("ExecPrc", "체결가", "double", "13.2")]
		public double ExecPrc;
		/// <summary>
		/// 체결수량
		/// </summary>
		[XAQueryFieldAttribute("ExecQty", "체결수량", "long", "16")]
		public long ExecQty;
		/// <summary>
		/// 약정시각
		/// </summary>
		[XAQueryFieldAttribute("CtrctTime", "약정시각", "char", "9")]
		public string CtrctTime;
		/// <summary>
		/// 약정번호
		/// </summary>
		[XAQueryFieldAttribute("CtrctNo", "약정번호", "long", "10")]
		public long CtrctNo;
		/// <summary>
		/// 체결번호
		/// </summary>
		[XAQueryFieldAttribute("ExecNo", "체결번호", "long", "10")]
		public long ExecNo;
		/// <summary>
		/// 매매손익금액
		/// </summary>
		[XAQueryFieldAttribute("BnsplAmt", "매매손익금액", "long", "16")]
		public long BnsplAmt;
		/// <summary>
		/// 미체결수량
		/// </summary>
		[XAQueryFieldAttribute("UnercQty", "미체결수량", "long", "16")]
		public long UnercQty;
		/// <summary>
		/// 사용자ID
		/// </summary>
		[XAQueryFieldAttribute("UserId", "사용자ID", "char", "16")]
		public string UserId;
		/// <summary>
		/// 통신매체코드
		/// </summary>
		[XAQueryFieldAttribute("CommdaCode", "통신매체코드", "char", "2")]
		public string CommdaCode;
		/// <summary>
		/// 통신매체코드명
		/// </summary>
		[XAQueryFieldAttribute("CommdaCodeNm", "통신매체코드명", "char", "40")]
		public string CommdaCodeNm;
		/// <summary>
		/// IP주소
		/// </summary>
		[XAQueryFieldAttribute("IpAddr", "IP주소", "char", "16")]
		public string IpAddr;
		/// <summary>
		/// 거래유형구분
		/// </summary>
		[XAQueryFieldAttribute("TrdPtnTpNm", "거래유형구분", "char", "20")]
		public string TrdPtnTpNm;
		/// <summary>
		/// 그룹ID
		/// </summary>
		[XAQueryFieldAttribute("GrpId", "그룹ID", "char", "20")]
		public string GrpId;

		public static class F
		{
			/// <summary>
			/// 계좌번호1
			/// </summary>
			public const string AcntNo1 = "AcntNo1";
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
			/// 매매구분
			/// </summary>
			public const string BnsTpCode = "BnsTpCode";
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
			/// <summary>
			/// IP주소
			/// </summary>
			public const string IpAddr = "IpAddr";
			/// <summary>
			/// 거래유형구분
			/// </summary>
			public const string TrdPtnTpNm = "TrdPtnTpNm";
			/// <summary>
			/// 그룹ID
			/// </summary>
			public const string GrpId = "GrpId";
		}

		public static string[] AllFields = new string[]
		{
			F.AcntNo1,
			F.OrdDt,
			F.OrdNo,
			F.OrgOrdNo,
			F.OrdTime,
			F.FnoIsuNo,
			F.IsuNm,
			F.BnsTpNm,
			F.BnsTpCode,
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
			F.IpAddr,
			F.TrdPtnTpNm,
			F.GrpId,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["AcntNo1"] = new XAQueryFieldInfo("char", AcntNo1, AcntNo1, "계좌번호1", (decimal)20);
			dict["OrdDt"] = new XAQueryFieldInfo("char", OrdDt, OrdDt, "주문일", (decimal)8);
			dict["OrdNo"] = new XAQueryFieldInfo("long", OrdNo, OrdNo.ToString("d10"), "주문번호", (decimal)10);
			dict["OrgOrdNo"] = new XAQueryFieldInfo("long", OrgOrdNo, OrgOrdNo.ToString("d10"), "원주문번호", (decimal)10);
			dict["OrdTime"] = new XAQueryFieldInfo("char", OrdTime, OrdTime, "주문시각", (decimal)9);
			dict["FnoIsuNo"] = new XAQueryFieldInfo("char", FnoIsuNo, FnoIsuNo, "선물옵션종목번호", (decimal)12);
			dict["IsuNm"] = new XAQueryFieldInfo("char", IsuNm, IsuNm, "종목명", (decimal)40);
			dict["BnsTpNm"] = new XAQueryFieldInfo("char", BnsTpNm, BnsTpNm, "매매구분", (decimal)10);
			dict["BnsTpCode"] = new XAQueryFieldInfo("char", BnsTpCode, BnsTpCode.ToString(), "매매구분", (decimal)1);
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
			dict["IpAddr"] = new XAQueryFieldInfo("char", IpAddr, IpAddr, "IP주소", (decimal)16);
			dict["TrdPtnTpNm"] = new XAQueryFieldInfo("char", TrdPtnTpNm, TrdPtnTpNm, "거래유형구분", (decimal)20);
			dict["GrpId"] = new XAQueryFieldInfo("char", GrpId, GrpId, "그룹ID", (decimal)20);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "AcntNo1":
					this.AcntNo1 = fieldInfo.FieldValue.TrimEnd('?');
				break;

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

				case "BnsTpCode":
					this.BnsTpCode = fieldInfo.FieldValue.FirstOrDefault();
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

				case "IpAddr":
					this.IpAddr = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "TrdPtnTpNm":
					this.TrdPtnTpNm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "GrpId":
					this.GrpId = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQCCEAQ06000OutBlock3[] ListFromQuery(XQCCEAQ06000 query)
		{
			int count = query.GetBlockCount(XQCCEAQ06000OutBlock3.BlockName);
			List<XQCCEAQ06000OutBlock3> list = new List<XQCCEAQ06000OutBlock3>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQCCEAQ06000OutBlock3 block = new XQCCEAQ06000OutBlock3();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.AcntNo1 = query.GetFieldData(block.GetBlockName(), "AcntNo1", i).TrimEnd('?'); // char 20
					block.OrdDt = query.GetFieldData(block.GetBlockName(), "OrdDt", i).TrimEnd('?'); // char 8
					block.OrdNo = query.GetFieldData(block.GetBlockName(), "OrdNo", i).ParseLong("OrdNo"); // long 10
					block.OrgOrdNo = query.GetFieldData(block.GetBlockName(), "OrgOrdNo", i).ParseLong("OrgOrdNo"); // long 10
					block.OrdTime = query.GetFieldData(block.GetBlockName(), "OrdTime", i).TrimEnd('?'); // char 9
					block.FnoIsuNo = query.GetFieldData(block.GetBlockName(), "FnoIsuNo", i).TrimEnd('?'); // char 12
					block.IsuNm = query.GetFieldData(block.GetBlockName(), "IsuNm", i).TrimEnd('?'); // char 40
					block.BnsTpNm = query.GetFieldData(block.GetBlockName(), "BnsTpNm", i).TrimEnd('?'); // char 10
					block.BnsTpCode = query.GetFieldData(block.GetBlockName(), "BnsTpCode", i).FirstOrDefault(); // char 1
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
					block.IpAddr = query.GetFieldData(block.GetBlockName(), "IpAddr", i).TrimEnd('?'); // char 16
					block.TrdPtnTpNm = query.GetFieldData(block.GetBlockName(), "TrdPtnTpNm", i).TrimEnd('?'); // char 20
					block.GrpId = query.GetFieldData(block.GetBlockName(), "GrpId", i).TrimEnd('?'); // char 20

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
			if (AcntNo1?.Length > 20) return false; // char 20
			if (OrdDt?.Length > 8) return false; // char 8
			if (OrdNo.ToString().Length > 10) return false; // long 10
			if (OrgOrdNo.ToString().Length > 10) return false; // long 10
			if (OrdTime?.Length > 9) return false; // char 9
			if (FnoIsuNo?.Length > 12) return false; // char 12
			if (IsuNm?.Length > 40) return false; // char 40
			if (BnsTpNm?.Length > 10) return false; // char 10
			// BnsTpCode char 1
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
			if (IpAddr?.Length > 16) return false; // char 16
			if (TrdPtnTpNm?.Length > 20) return false; // char 20
			if (GrpId?.Length > 20) return false; // char 20

			return true;
		}
	}

	/// <summary>
	/// 선물옵션 CME 주문체결내역조회
	/// </summary>
	public partial class XQCCEAQ06000 : XingQuery
	{
		/// <summary>
		/// CCEAQ06000
		/// </summary>
		public const string _typeName = "CCEAQ06000";
		/// <summary>
		/// 선물옵션 CME 주문체결내역조회
		/// </summary>
		public const string _typeDesc = "선물옵션 CME 주문체결내역조회";
		/// <summary>
		/// CCEAQ06000
		/// </summary>
		public const string _service = "CCEAQ06000";
		/// <summary>
		/// B
		/// </summary>
		public const string _headType = "B";
		/// <summary>
		/// 김효종
		/// </summary>
		public const string _creator = "김효종";
		/// <summary>
		/// 2012/04/17 17:48:18
		/// </summary>
		public const string _createdDate = "2012/04/17 17:48:18";
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
		/// CCEAQ06000
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 선물옵션 CME 주문체결내역조회
		/// </summary>
		public string TypeDesc => _typeDesc;
		/// <summary>
		/// CCEAQ06000
		/// </summary>
		public string Service => _service;
		/// <summary>
		/// B
		/// </summary>
		public string HeadType => _headType;
		/// <summary>
		/// 김효종
		/// </summary>
		public string Creator => _creator;
		/// <summary>
		/// 2012/04/17 17:48:18
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
		/// 선물옵션 CME 주문체결내역조회
		/// </summary>
		public XQCCEAQ06000() : base("CCEAQ06000") { }




		public bool SetBlock(XQCCEAQ06000InBlock1 block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "RecCnt", 0, block.RecCnt.ToString("d5")); // long 5
			_xaQuery.SetFieldData(block.GetBlockName(), "ChoicInptTpCode", 0, block.ChoicInptTpCode.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "AcntNo", 0, block.AcntNo); // char 20
			_xaQuery.SetFieldData(block.GetBlockName(), "Pwd", 0, block.Pwd); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "QrySrtDt", 0, block.QrySrtDt); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "QryEndDt", 0, block.QryEndDt); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "FnoClssCode", 0, block.FnoClssCode); // char 2
			_xaQuery.SetFieldData(block.GetBlockName(), "PrdgrpCode", 0, block.PrdgrpCode); // char 2
			_xaQuery.SetFieldData(block.GetBlockName(), "PrdtExecTpCode", 0, block.PrdtExecTpCode.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "FnoTrdPtnCode", 0, block.FnoTrdPtnCode); // char 2
			_xaQuery.SetFieldData(block.GetBlockName(), "SrtOrdNo2", 0, block.SrtOrdNo2.ToString("d10")); // long 10
			_xaQuery.SetFieldData(block.GetBlockName(), "EndNo", 0, block.EndNo.ToString("d10")); // long 10
			_xaQuery.SetFieldData(block.GetBlockName(), "StnlnSeqTp", 0, block.StnlnSeqTp.ToString()); // char 1

			return true;
		}

		public XQCCEAQ06000OutBlock1 GetBlock1()
		{
			XQCCEAQ06000OutBlock1 instance = XQCCEAQ06000OutBlock1.FromQuery(this);
			return instance;

		}

		public XQCCEAQ06000OutBlock2 GetBlock2()
		{
			XQCCEAQ06000OutBlock2 instance = XQCCEAQ06000OutBlock2.FromQuery(this);
			return instance;

		}

		public XQCCEAQ06000OutBlock3[] GetBlock3s()
		{
			XQCCEAQ06000OutBlock3[] instance = XQCCEAQ06000OutBlock3.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQCCEAQ06000OutBlock1),
			typeof(XQCCEAQ06000OutBlock2),
			typeof(XQCCEAQ06000OutBlock3),

		};

	}

}
