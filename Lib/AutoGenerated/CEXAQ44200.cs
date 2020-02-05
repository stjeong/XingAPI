using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQCEXAQ44200InBlock1 : XingBlock
	{
		/// <summary>
		/// CEXAQ44200InBlock1
		/// </summary>
		public const string _blockName = "CEXAQ44200InBlock1";
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
		/// CEXAQ44200InBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CEXAQ44200InBlock1
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
		/// 선택입력구분
		/// </summary>
		[XAQueryFieldAttribute("선택입력구분")]
		public char ChoicInptTpCode;
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
		/// 체결구분
		/// </summary>
		[XAQueryFieldAttribute("체결구분")]
		public char PrdtExecTpCode;
		/// <summary>
		/// 선물옵션거래유형코드
		/// </summary>
		[XAQueryFieldAttribute("선물옵션거래유형코드")]
		public string FnoTrdPtnCode;
		/// <summary>
		/// 시작주문번호2
		/// </summary>
		[XAQueryFieldAttribute("시작주문번호2")]
		public long SrtOrdNo2;
		/// <summary>
		/// 정렬순서구분
		/// </summary>
		[XAQueryFieldAttribute("정렬순서구분")]
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
			F.PrdtExecTpCode,
			F.FnoTrdPtnCode,
			F.SrtOrdNo2,
			F.StnlnSeqTp,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["ChoicInptTpCode"] = new XAQueryFieldInfo("char", ChoicInptTpCode, ChoicInptTpCode.ToString(), "선택입력구분", (decimal)1);
			dict["AcntNo"] = new XAQueryFieldInfo("char", AcntNo, AcntNo, "계좌번호", (decimal)20);
			dict["Pwd"] = new XAQueryFieldInfo("char", Pwd, Pwd, "비밀번호", (decimal)8);
			dict["QrySrtDt"] = new XAQueryFieldInfo("char", QrySrtDt, QrySrtDt, "조회시작일", (decimal)8);
			dict["QryEndDt"] = new XAQueryFieldInfo("char", QryEndDt, QryEndDt, "조회종료일", (decimal)8);
			dict["PrdtExecTpCode"] = new XAQueryFieldInfo("char", PrdtExecTpCode, PrdtExecTpCode.ToString(), "체결구분", (decimal)1);
			dict["FnoTrdPtnCode"] = new XAQueryFieldInfo("char", FnoTrdPtnCode, FnoTrdPtnCode, "선물옵션거래유형코드", (decimal)2);
			dict["SrtOrdNo2"] = new XAQueryFieldInfo("long", SrtOrdNo2, SrtOrdNo2.ToString("d10"), "시작주문번호2", (decimal)10);
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

				case "PrdtExecTpCode":
					this.PrdtExecTpCode = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "FnoTrdPtnCode":
					this.FnoTrdPtnCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "SrtOrdNo2":
					this.SrtOrdNo2 = fieldInfo.FieldValue.ParseLong("SrtOrdNo2");
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
			// PrdtExecTpCode char 1
			if (FnoTrdPtnCode?.Length > 2) return false; // char 2
			if (SrtOrdNo2.ToString().Length > 10) return false; // long 10
			// StnlnSeqTp char 1

			return true;
		}
	}

	public partial class XQCEXAQ44200OutBlock1 : XingBlock
	{
		/// <summary>
		/// CEXAQ44200OutBlock1
		/// </summary>
		public const string _blockName = "CEXAQ44200OutBlock1";
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
		/// CEXAQ44200OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CEXAQ44200OutBlock1
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
		/// 선택입력구분
		/// </summary>
		[XAQueryFieldAttribute("선택입력구분")]
		public char ChoicInptTpCode;
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
		/// 체결구분
		/// </summary>
		[XAQueryFieldAttribute("체결구분")]
		public char PrdtExecTpCode;
		/// <summary>
		/// 선물옵션거래유형코드
		/// </summary>
		[XAQueryFieldAttribute("선물옵션거래유형코드")]
		public string FnoTrdPtnCode;
		/// <summary>
		/// 시작주문번호2
		/// </summary>
		[XAQueryFieldAttribute("시작주문번호2")]
		public long SrtOrdNo2;
		/// <summary>
		/// 정렬순서구분
		/// </summary>
		[XAQueryFieldAttribute("정렬순서구분")]
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
			F.PrdtExecTpCode,
			F.FnoTrdPtnCode,
			F.SrtOrdNo2,
			F.StnlnSeqTp,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["ChoicInptTpCode"] = new XAQueryFieldInfo("char", ChoicInptTpCode, ChoicInptTpCode.ToString(), "선택입력구분", (decimal)1);
			dict["AcntNo"] = new XAQueryFieldInfo("char", AcntNo, AcntNo, "계좌번호", (decimal)20);
			dict["Pwd"] = new XAQueryFieldInfo("char", Pwd, Pwd, "비밀번호", (decimal)8);
			dict["QrySrtDt"] = new XAQueryFieldInfo("char", QrySrtDt, QrySrtDt, "조회시작일", (decimal)8);
			dict["QryEndDt"] = new XAQueryFieldInfo("char", QryEndDt, QryEndDt, "조회종료일", (decimal)8);
			dict["PrdtExecTpCode"] = new XAQueryFieldInfo("char", PrdtExecTpCode, PrdtExecTpCode.ToString(), "체결구분", (decimal)1);
			dict["FnoTrdPtnCode"] = new XAQueryFieldInfo("char", FnoTrdPtnCode, FnoTrdPtnCode, "선물옵션거래유형코드", (decimal)2);
			dict["SrtOrdNo2"] = new XAQueryFieldInfo("long", SrtOrdNo2, SrtOrdNo2.ToString("d10"), "시작주문번호2", (decimal)10);
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

				case "PrdtExecTpCode":
					this.PrdtExecTpCode = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "FnoTrdPtnCode":
					this.FnoTrdPtnCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "SrtOrdNo2":
					this.SrtOrdNo2 = fieldInfo.FieldValue.ParseLong("SrtOrdNo2");
				break;

				case "StnlnSeqTp":
					this.StnlnSeqTp = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public static XQCEXAQ44200OutBlock1 FromQuery(XQCEXAQ44200 query)
		{
			XQCEXAQ44200OutBlock1 block = new XQCEXAQ44200OutBlock1();
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
				block.PrdtExecTpCode = query.GetFieldData(block.GetBlockName(), "PrdtExecTpCode", 0).FirstOrDefault(); // char 1
				block.FnoTrdPtnCode = query.GetFieldData(block.GetBlockName(), "FnoTrdPtnCode", 0).TrimEnd('?'); // char 2
				block.SrtOrdNo2 = query.GetFieldData(block.GetBlockName(), "SrtOrdNo2", 0).ParseLong("SrtOrdNo2"); // long 10
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
			// PrdtExecTpCode char 1
			if (FnoTrdPtnCode?.Length > 2) return false; // char 2
			if (SrtOrdNo2.ToString().Length > 10) return false; // long 10
			// StnlnSeqTp char 1

			return true;
		}
	}

	public partial class XQCEXAQ44200OutBlock2 : XingBlock
	{
		/// <summary>
		/// CEXAQ44200OutBlock2
		/// </summary>
		public const string _blockName = "CEXAQ44200OutBlock2";
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
		/// CEXAQ44200OutBlock2
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CEXAQ44200OutBlock2
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
		/// 주문수량
		/// </summary>
		[XAQueryFieldAttribute("주문수량")]
		public long OrdQty;
		/// <summary>
		/// 체결수량
		/// </summary>
		[XAQueryFieldAttribute("체결수량")]
		public long ExecQty;
		/// <summary>
		/// 미체결수량
		/// </summary>
		[XAQueryFieldAttribute("미체결수량")]
		public long UnercQty;
		/// <summary>
		/// 체결가
		/// </summary>
		[XAQueryFieldAttribute("체결가")]
		public double ExecPrc;

		public static class F
		{
			/// <summary>
			/// 레코드갯수
			/// </summary>
			public const string RecCnt = "RecCnt";
			/// <summary>
			/// 주문수량
			/// </summary>
			public const string OrdQty = "OrdQty";
			/// <summary>
			/// 체결수량
			/// </summary>
			public const string ExecQty = "ExecQty";
			/// <summary>
			/// 미체결수량
			/// </summary>
			public const string UnercQty = "UnercQty";
			/// <summary>
			/// 체결가
			/// </summary>
			public const string ExecPrc = "ExecPrc";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.OrdQty,
			F.ExecQty,
			F.UnercQty,
			F.ExecPrc,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["OrdQty"] = new XAQueryFieldInfo("long", OrdQty, OrdQty.ToString("d16"), "주문수량", (decimal)16);
			dict["ExecQty"] = new XAQueryFieldInfo("long", ExecQty, ExecQty.ToString("d16"), "체결수량", (decimal)16);
			dict["UnercQty"] = new XAQueryFieldInfo("long", UnercQty, UnercQty.ToString("d16"), "미체결수량", (decimal)16);
			dict["ExecPrc"] = new XAQueryFieldInfo("double", ExecPrc, ExecPrc.ToString("000000000000000.00"), "체결가", (decimal)15.2);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "RecCnt":
					this.RecCnt = fieldInfo.FieldValue.ParseLong("RecCnt");
				break;

				case "OrdQty":
					this.OrdQty = fieldInfo.FieldValue.ParseLong("OrdQty");
				break;

				case "ExecQty":
					this.ExecQty = fieldInfo.FieldValue.ParseLong("ExecQty");
				break;

				case "UnercQty":
					this.UnercQty = fieldInfo.FieldValue.ParseLong("UnercQty");
				break;

				case "ExecPrc":
					this.ExecPrc = fieldInfo.FieldValue.ParseDouble("ExecPrc");
				break;


			}
		}

		public static XQCEXAQ44200OutBlock2 FromQuery(XQCEXAQ44200 query)
		{
			XQCEXAQ44200OutBlock2 block = new XQCEXAQ44200OutBlock2();
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
				block.OrdQty = query.GetFieldData(block.GetBlockName(), "OrdQty", 0).ParseLong("OrdQty"); // long 16
				block.ExecQty = query.GetFieldData(block.GetBlockName(), "ExecQty", 0).ParseLong("ExecQty"); // long 16
				block.UnercQty = query.GetFieldData(block.GetBlockName(), "UnercQty", 0).ParseLong("UnercQty"); // long 16
				block.ExecPrc = query.GetFieldData(block.GetBlockName(), "ExecPrc", 0).ParseDouble("ExecPrc"); // double 15.2

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (RecCnt.ToString().Length > 5) return false; // long 5
			if (OrdQty.ToString().Length > 16) return false; // long 16
			if (ExecQty.ToString().Length > 16) return false; // long 16
			if (UnercQty.ToString().Length > 16) return false; // long 16
			// ExecPrc double 15.2

			return true;
		}
	}

	public partial class XQCEXAQ44200OutBlock3 : XingBlock
	{
		/// <summary>
		/// CEXAQ44200OutBlock3
		/// </summary>
		public const string _blockName = "CEXAQ44200OutBlock3";
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
		/// CEXAQ44200OutBlock3
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CEXAQ44200OutBlock3
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
		[XAQueryFieldAttribute("계좌번호1")]
		public string AcntNo1;
		/// <summary>
		/// 계좌명
		/// </summary>
		[XAQueryFieldAttribute("계좌명")]
		public string AcntNm;
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
		/// 종목번호
		/// </summary>
		[XAQueryFieldAttribute("종목번호")]
		public string IsuNo;
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
		/// 매매구분
		/// </summary>
		[XAQueryFieldAttribute("매매구분")]
		public char BnsTpCode;
		/// <summary>
		/// 유렉스호가구분코드
		/// </summary>
		[XAQueryFieldAttribute("유렉스호가구분코드")]
		public char ErxOrdprcTpCode;
		/// <summary>
		/// 정정취소구분명
		/// </summary>
		[XAQueryFieldAttribute("정정취소구분명")]
		public string MrcTpNm;
		/// <summary>
		/// 유렉스가격조건구분코드
		/// </summary>
		[XAQueryFieldAttribute("유렉스가격조건구분코드")]
		public char ErxPrcCndiTpCode;
		/// <summary>
		/// 코드명
		/// </summary>
		[XAQueryFieldAttribute("코드명")]
		public string CodeNm;
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
		/// 선물옵션거부사유코드
		/// </summary>
		[XAQueryFieldAttribute("선물옵션거부사유코드")]
		public string FnoRjtRsnCode;
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
		/// 체결시각
		/// </summary>
		[XAQueryFieldAttribute("체결시각")]
		public string ExecTime;
		/// <summary>
		/// 체결번호
		/// </summary>
		[XAQueryFieldAttribute("체결번호")]
		public long ExecNo;
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
		/// <summary>
		/// IP주소
		/// </summary>
		[XAQueryFieldAttribute("IP주소")]
		public string IpAddr;
		/// <summary>
		/// 거래유형구분
		/// </summary>
		[XAQueryFieldAttribute("거래유형구분")]
		public string TrdPtnTpNm;
		/// <summary>
		/// 유렉스주문상태코드
		/// </summary>
		[XAQueryFieldAttribute("유렉스주문상태코드")]
		public char ErxOrdStatCode;
		/// <summary>
		/// 코드명0
		/// </summary>
		[XAQueryFieldAttribute("코드명0")]
		public string CodeNm0;
		/// <summary>
		/// 거래소접수시각
		/// </summary>
		[XAQueryFieldAttribute("거래소접수시각")]
		public string ExchRcptTime;

		public static class F
		{
			/// <summary>
			/// 계좌번호1
			/// </summary>
			public const string AcntNo1 = "AcntNo1";
			/// <summary>
			/// 계좌명
			/// </summary>
			public const string AcntNm = "AcntNm";
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
			/// 종목번호
			/// </summary>
			public const string IsuNo = "IsuNo";
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
			/// 유렉스호가구분코드
			/// </summary>
			public const string ErxOrdprcTpCode = "ErxOrdprcTpCode";
			/// <summary>
			/// 정정취소구분명
			/// </summary>
			public const string MrcTpNm = "MrcTpNm";
			/// <summary>
			/// 유렉스가격조건구분코드
			/// </summary>
			public const string ErxPrcCndiTpCode = "ErxPrcCndiTpCode";
			/// <summary>
			/// 코드명
			/// </summary>
			public const string CodeNm = "CodeNm";
			/// <summary>
			/// 주문가
			/// </summary>
			public const string OrdPrc = "OrdPrc";
			/// <summary>
			/// 주문수량
			/// </summary>
			public const string OrdQty = "OrdQty";
			/// <summary>
			/// 선물옵션거부사유코드
			/// </summary>
			public const string FnoRjtRsnCode = "FnoRjtRsnCode";
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
			/// 체결시각
			/// </summary>
			public const string ExecTime = "ExecTime";
			/// <summary>
			/// 체결번호
			/// </summary>
			public const string ExecNo = "ExecNo";
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
			/// 유렉스주문상태코드
			/// </summary>
			public const string ErxOrdStatCode = "ErxOrdStatCode";
			/// <summary>
			/// 코드명0
			/// </summary>
			public const string CodeNm0 = "CodeNm0";
			/// <summary>
			/// 거래소접수시각
			/// </summary>
			public const string ExchRcptTime = "ExchRcptTime";
		}

		public static string[] AllFields = new string[]
		{
			F.AcntNo1,
			F.AcntNm,
			F.OrdDt,
			F.OrdNo,
			F.OrgOrdNo,
			F.OrdTime,
			F.IsuNo,
			F.IsuNm,
			F.BnsTpNm,
			F.BnsTpCode,
			F.ErxOrdprcTpCode,
			F.MrcTpNm,
			F.ErxPrcCndiTpCode,
			F.CodeNm,
			F.OrdPrc,
			F.OrdQty,
			F.FnoRjtRsnCode,
			F.OrdTpNm,
			F.ExecTpNm,
			F.ExecPrc,
			F.ExecQty,
			F.ExecTime,
			F.ExecNo,
			F.UnercQty,
			F.UserId,
			F.CommdaCode,
			F.CommdaCodeNm,
			F.IpAddr,
			F.TrdPtnTpNm,
			F.ErxOrdStatCode,
			F.CodeNm0,
			F.ExchRcptTime,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["AcntNo1"] = new XAQueryFieldInfo("char", AcntNo1, AcntNo1, "계좌번호1", (decimal)20);
			dict["AcntNm"] = new XAQueryFieldInfo("char", AcntNm, AcntNm, "계좌명", (decimal)40);
			dict["OrdDt"] = new XAQueryFieldInfo("char", OrdDt, OrdDt, "주문일", (decimal)8);
			dict["OrdNo"] = new XAQueryFieldInfo("long", OrdNo, OrdNo.ToString("d10"), "주문번호", (decimal)10);
			dict["OrgOrdNo"] = new XAQueryFieldInfo("long", OrgOrdNo, OrgOrdNo.ToString("d10"), "원주문번호", (decimal)10);
			dict["OrdTime"] = new XAQueryFieldInfo("char", OrdTime, OrdTime, "주문시각", (decimal)9);
			dict["IsuNo"] = new XAQueryFieldInfo("char", IsuNo, IsuNo, "종목번호", (decimal)12);
			dict["IsuNm"] = new XAQueryFieldInfo("char", IsuNm, IsuNm, "종목명", (decimal)40);
			dict["BnsTpNm"] = new XAQueryFieldInfo("char", BnsTpNm, BnsTpNm, "매매구분", (decimal)10);
			dict["BnsTpCode"] = new XAQueryFieldInfo("char", BnsTpCode, BnsTpCode.ToString(), "매매구분", (decimal)1);
			dict["ErxOrdprcTpCode"] = new XAQueryFieldInfo("char", ErxOrdprcTpCode, ErxOrdprcTpCode.ToString(), "유렉스호가구분코드", (decimal)1);
			dict["MrcTpNm"] = new XAQueryFieldInfo("char", MrcTpNm, MrcTpNm, "정정취소구분명", (decimal)10);
			dict["ErxPrcCndiTpCode"] = new XAQueryFieldInfo("char", ErxPrcCndiTpCode, ErxPrcCndiTpCode.ToString(), "유렉스가격조건구분코드", (decimal)1);
			dict["CodeNm"] = new XAQueryFieldInfo("char", CodeNm, CodeNm, "코드명", (decimal)40);
			dict["OrdPrc"] = new XAQueryFieldInfo("double", OrdPrc, OrdPrc.ToString("0000000000000.00"), "주문가", (decimal)13.2);
			dict["OrdQty"] = new XAQueryFieldInfo("long", OrdQty, OrdQty.ToString("d16"), "주문수량", (decimal)16);
			dict["FnoRjtRsnCode"] = new XAQueryFieldInfo("char", FnoRjtRsnCode, FnoRjtRsnCode, "선물옵션거부사유코드", (decimal)3);
			dict["OrdTpNm"] = new XAQueryFieldInfo("char", OrdTpNm, OrdTpNm, "주문구분명", (decimal)10);
			dict["ExecTpNm"] = new XAQueryFieldInfo("char", ExecTpNm, ExecTpNm, "체결구분명", (decimal)10);
			dict["ExecPrc"] = new XAQueryFieldInfo("double", ExecPrc, ExecPrc.ToString("0000000000000.00"), "체결가", (decimal)13.2);
			dict["ExecQty"] = new XAQueryFieldInfo("long", ExecQty, ExecQty.ToString("d16"), "체결수량", (decimal)16);
			dict["ExecTime"] = new XAQueryFieldInfo("char", ExecTime, ExecTime, "체결시각", (decimal)9);
			dict["ExecNo"] = new XAQueryFieldInfo("long", ExecNo, ExecNo.ToString("d10"), "체결번호", (decimal)10);
			dict["UnercQty"] = new XAQueryFieldInfo("long", UnercQty, UnercQty.ToString("d16"), "미체결수량", (decimal)16);
			dict["UserId"] = new XAQueryFieldInfo("char", UserId, UserId, "사용자ID", (decimal)16);
			dict["CommdaCode"] = new XAQueryFieldInfo("char", CommdaCode, CommdaCode, "통신매체코드", (decimal)2);
			dict["CommdaCodeNm"] = new XAQueryFieldInfo("char", CommdaCodeNm, CommdaCodeNm, "통신매체코드명", (decimal)40);
			dict["IpAddr"] = new XAQueryFieldInfo("char", IpAddr, IpAddr, "IP주소", (decimal)16);
			dict["TrdPtnTpNm"] = new XAQueryFieldInfo("char", TrdPtnTpNm, TrdPtnTpNm, "거래유형구분", (decimal)20);
			dict["ErxOrdStatCode"] = new XAQueryFieldInfo("char", ErxOrdStatCode, ErxOrdStatCode.ToString(), "유렉스주문상태코드", (decimal)1);
			dict["CodeNm0"] = new XAQueryFieldInfo("char", CodeNm0, CodeNm0, "코드명0", (decimal)40);
			dict["ExchRcptTime"] = new XAQueryFieldInfo("char", ExchRcptTime, ExchRcptTime, "거래소접수시각", (decimal)30);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "AcntNo1":
					this.AcntNo1 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "AcntNm":
					this.AcntNm = fieldInfo.FieldValue.TrimEnd('?');
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

				case "IsuNo":
					this.IsuNo = fieldInfo.FieldValue.TrimEnd('?');
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

				case "ErxOrdprcTpCode":
					this.ErxOrdprcTpCode = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "MrcTpNm":
					this.MrcTpNm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ErxPrcCndiTpCode":
					this.ErxPrcCndiTpCode = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "CodeNm":
					this.CodeNm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "OrdPrc":
					this.OrdPrc = fieldInfo.FieldValue.ParseDouble("OrdPrc");
				break;

				case "OrdQty":
					this.OrdQty = fieldInfo.FieldValue.ParseLong("OrdQty");
				break;

				case "FnoRjtRsnCode":
					this.FnoRjtRsnCode = fieldInfo.FieldValue.TrimEnd('?');
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

				case "ExecTime":
					this.ExecTime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ExecNo":
					this.ExecNo = fieldInfo.FieldValue.ParseLong("ExecNo");
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

				case "ErxOrdStatCode":
					this.ErxOrdStatCode = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "CodeNm0":
					this.CodeNm0 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ExchRcptTime":
					this.ExchRcptTime = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQCEXAQ44200OutBlock3[] ListFromQuery(XQCEXAQ44200 query)
		{
			int count = query.GetBlockCount(XQCEXAQ44200OutBlock3.BlockName);
			List<XQCEXAQ44200OutBlock3> list = new List<XQCEXAQ44200OutBlock3>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQCEXAQ44200OutBlock3 block = new XQCEXAQ44200OutBlock3();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.AcntNo1 = query.GetFieldData(block.GetBlockName(), "AcntNo1", i).TrimEnd('?'); // char 20
					block.AcntNm = query.GetFieldData(block.GetBlockName(), "AcntNm", i).TrimEnd('?'); // char 40
					block.OrdDt = query.GetFieldData(block.GetBlockName(), "OrdDt", i).TrimEnd('?'); // char 8
					block.OrdNo = query.GetFieldData(block.GetBlockName(), "OrdNo", i).ParseLong("OrdNo"); // long 10
					block.OrgOrdNo = query.GetFieldData(block.GetBlockName(), "OrgOrdNo", i).ParseLong("OrgOrdNo"); // long 10
					block.OrdTime = query.GetFieldData(block.GetBlockName(), "OrdTime", i).TrimEnd('?'); // char 9
					block.IsuNo = query.GetFieldData(block.GetBlockName(), "IsuNo", i).TrimEnd('?'); // char 12
					block.IsuNm = query.GetFieldData(block.GetBlockName(), "IsuNm", i).TrimEnd('?'); // char 40
					block.BnsTpNm = query.GetFieldData(block.GetBlockName(), "BnsTpNm", i).TrimEnd('?'); // char 10
					block.BnsTpCode = query.GetFieldData(block.GetBlockName(), "BnsTpCode", i).FirstOrDefault(); // char 1
					block.ErxOrdprcTpCode = query.GetFieldData(block.GetBlockName(), "ErxOrdprcTpCode", i).FirstOrDefault(); // char 1
					block.MrcTpNm = query.GetFieldData(block.GetBlockName(), "MrcTpNm", i).TrimEnd('?'); // char 10
					block.ErxPrcCndiTpCode = query.GetFieldData(block.GetBlockName(), "ErxPrcCndiTpCode", i).FirstOrDefault(); // char 1
					block.CodeNm = query.GetFieldData(block.GetBlockName(), "CodeNm", i).TrimEnd('?'); // char 40
					block.OrdPrc = query.GetFieldData(block.GetBlockName(), "OrdPrc", i).ParseDouble("OrdPrc"); // double 13.2
					block.OrdQty = query.GetFieldData(block.GetBlockName(), "OrdQty", i).ParseLong("OrdQty"); // long 16
					block.FnoRjtRsnCode = query.GetFieldData(block.GetBlockName(), "FnoRjtRsnCode", i).TrimEnd('?'); // char 3
					block.OrdTpNm = query.GetFieldData(block.GetBlockName(), "OrdTpNm", i).TrimEnd('?'); // char 10
					block.ExecTpNm = query.GetFieldData(block.GetBlockName(), "ExecTpNm", i).TrimEnd('?'); // char 10
					block.ExecPrc = query.GetFieldData(block.GetBlockName(), "ExecPrc", i).ParseDouble("ExecPrc"); // double 13.2
					block.ExecQty = query.GetFieldData(block.GetBlockName(), "ExecQty", i).ParseLong("ExecQty"); // long 16
					block.ExecTime = query.GetFieldData(block.GetBlockName(), "ExecTime", i).TrimEnd('?'); // char 9
					block.ExecNo = query.GetFieldData(block.GetBlockName(), "ExecNo", i).ParseLong("ExecNo"); // long 10
					block.UnercQty = query.GetFieldData(block.GetBlockName(), "UnercQty", i).ParseLong("UnercQty"); // long 16
					block.UserId = query.GetFieldData(block.GetBlockName(), "UserId", i).TrimEnd('?'); // char 16
					block.CommdaCode = query.GetFieldData(block.GetBlockName(), "CommdaCode", i).TrimEnd('?'); // char 2
					block.CommdaCodeNm = query.GetFieldData(block.GetBlockName(), "CommdaCodeNm", i).TrimEnd('?'); // char 40
					block.IpAddr = query.GetFieldData(block.GetBlockName(), "IpAddr", i).TrimEnd('?'); // char 16
					block.TrdPtnTpNm = query.GetFieldData(block.GetBlockName(), "TrdPtnTpNm", i).TrimEnd('?'); // char 20
					block.ErxOrdStatCode = query.GetFieldData(block.GetBlockName(), "ErxOrdStatCode", i).FirstOrDefault(); // char 1
					block.CodeNm0 = query.GetFieldData(block.GetBlockName(), "CodeNm0", i).TrimEnd('?'); // char 40
					block.ExchRcptTime = query.GetFieldData(block.GetBlockName(), "ExchRcptTime", i).TrimEnd('?'); // char 30

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
			if (AcntNm?.Length > 40) return false; // char 40
			if (OrdDt?.Length > 8) return false; // char 8
			if (OrdNo.ToString().Length > 10) return false; // long 10
			if (OrgOrdNo.ToString().Length > 10) return false; // long 10
			if (OrdTime?.Length > 9) return false; // char 9
			if (IsuNo?.Length > 12) return false; // char 12
			if (IsuNm?.Length > 40) return false; // char 40
			if (BnsTpNm?.Length > 10) return false; // char 10
			// BnsTpCode char 1
			// ErxOrdprcTpCode char 1
			if (MrcTpNm?.Length > 10) return false; // char 10
			// ErxPrcCndiTpCode char 1
			if (CodeNm?.Length > 40) return false; // char 40
			// OrdPrc double 13.2
			if (OrdQty.ToString().Length > 16) return false; // long 16
			if (FnoRjtRsnCode?.Length > 3) return false; // char 3
			if (OrdTpNm?.Length > 10) return false; // char 10
			if (ExecTpNm?.Length > 10) return false; // char 10
			// ExecPrc double 13.2
			if (ExecQty.ToString().Length > 16) return false; // long 16
			if (ExecTime?.Length > 9) return false; // char 9
			if (ExecNo.ToString().Length > 10) return false; // long 10
			if (UnercQty.ToString().Length > 16) return false; // long 16
			if (UserId?.Length > 16) return false; // char 16
			if (CommdaCode?.Length > 2) return false; // char 2
			if (CommdaCodeNm?.Length > 40) return false; // char 40
			if (IpAddr?.Length > 16) return false; // char 16
			if (TrdPtnTpNm?.Length > 20) return false; // char 20
			// ErxOrdStatCode char 1
			if (CodeNm0?.Length > 40) return false; // char 40
			if (ExchRcptTime?.Length > 30) return false; // char 30

			return true;
		}
	}

	/// <summary>
	/// EUREX 야간옵션 기간주문체결조회
	/// </summary>
	public partial class XQCEXAQ44200 : XingQuery
	{
		/// <summary>
		/// CEXAQ44200
		/// </summary>
		public const string _typeName = "CEXAQ44200";
		/// <summary>
		/// EUREX 야간옵션 기간주문체결조회
		/// </summary>
		public const string _typeDesc = "EUREX 야간옵션 기간주문체결조회";
		/// <summary>
		/// CEXAQ44200
		/// </summary>
		public const string _service = "CEXAQ44200";
		/// <summary>
		/// B
		/// </summary>
		public const string _headType = "B";
		/// <summary>
		/// 
		/// </summary>
		public const string _creator = "";
		/// <summary>
		/// 2012/11/08 17:10:28
		/// </summary>
		public const string _createdDate = "2012/11/08 17:10:28";
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
		/// CEXAQ44200
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// EUREX 야간옵션 기간주문체결조회
		/// </summary>
		public string TypeDesc => _typeDesc;
		/// <summary>
		/// CEXAQ44200
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
		/// 2012/11/08 17:10:28
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
		/// EUREX 야간옵션 기간주문체결조회
		/// </summary>
		public XQCEXAQ44200() : base("CEXAQ44200") { }



		public bool SetBlock(XQCEXAQ44200InBlock1 block)
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
			_xaQuery.SetFieldData(block.GetBlockName(), "PrdtExecTpCode", 0, block.PrdtExecTpCode.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "FnoTrdPtnCode", 0, block.FnoTrdPtnCode); // char 2
			_xaQuery.SetFieldData(block.GetBlockName(), "SrtOrdNo2", 0, block.SrtOrdNo2.ToString("d10")); // long 10
			_xaQuery.SetFieldData(block.GetBlockName(), "StnlnSeqTp", 0, block.StnlnSeqTp.ToString()); // char 1

			return true;
		}

		public XQCEXAQ44200OutBlock1 GetBlock1()
		{
			XQCEXAQ44200OutBlock1 instance = XQCEXAQ44200OutBlock1.FromQuery(this);
			return instance;

		}

		public XQCEXAQ44200OutBlock2 GetBlock2()
		{
			XQCEXAQ44200OutBlock2 instance = XQCEXAQ44200OutBlock2.FromQuery(this);
			return instance;

		}

		public XQCEXAQ44200OutBlock3[] GetBlock3s()
		{
			XQCEXAQ44200OutBlock3[] instance = XQCEXAQ44200OutBlock3.ListFromQuery(this);
			return instance;

		}


	}

}
