using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQCFOEQ82600InBlock1 : XingBlock
	{
		/// <summary>
		/// CFOEQ82600InBlock1
		/// </summary>
		public const string _blockName = "CFOEQ82600InBlock1";
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
		/// CFOEQ82600InBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CFOEQ82600InBlock1
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
		/// 조회구분
		/// </summary>
		[XAQueryFieldAttribute("조회구분")]
		public char QryTp;
		/// <summary>
		/// 정렬순서구분
		/// </summary>
		[XAQueryFieldAttribute("정렬순서구분")]
		public char StnlnSeqTp;
		/// <summary>
		/// 선물옵션잔고평가구분코드
		/// </summary>
		[XAQueryFieldAttribute("선물옵션잔고평가구분코드")]
		public char FnoBalEvalTpCode;

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
			/// 조회시작일
			/// </summary>
			public const string QrySrtDt = "QrySrtDt";
			/// <summary>
			/// 조회종료일
			/// </summary>
			public const string QryEndDt = "QryEndDt";
			/// <summary>
			/// 조회구분
			/// </summary>
			public const string QryTp = "QryTp";
			/// <summary>
			/// 정렬순서구분
			/// </summary>
			public const string StnlnSeqTp = "StnlnSeqTp";
			/// <summary>
			/// 선물옵션잔고평가구분코드
			/// </summary>
			public const string FnoBalEvalTpCode = "FnoBalEvalTpCode";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.AcntNo,
			F.Pwd,
			F.QrySrtDt,
			F.QryEndDt,
			F.QryTp,
			F.StnlnSeqTp,
			F.FnoBalEvalTpCode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["AcntNo"] = new XAQueryFieldInfo("char", AcntNo, AcntNo, "계좌번호", (decimal)20);
			dict["Pwd"] = new XAQueryFieldInfo("char", Pwd, Pwd, "비밀번호", (decimal)8);
			dict["QrySrtDt"] = new XAQueryFieldInfo("char", QrySrtDt, QrySrtDt, "조회시작일", (decimal)8);
			dict["QryEndDt"] = new XAQueryFieldInfo("char", QryEndDt, QryEndDt, "조회종료일", (decimal)8);
			dict["QryTp"] = new XAQueryFieldInfo("char", QryTp, QryTp.ToString(), "조회구분", (decimal)1);
			dict["StnlnSeqTp"] = new XAQueryFieldInfo("char", StnlnSeqTp, StnlnSeqTp.ToString(), "정렬순서구분", (decimal)1);
			dict["FnoBalEvalTpCode"] = new XAQueryFieldInfo("char", FnoBalEvalTpCode, FnoBalEvalTpCode.ToString(), "선물옵션잔고평가구분코드", (decimal)1);

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

				case "QrySrtDt":
					this.QrySrtDt = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "QryEndDt":
					this.QryEndDt = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "QryTp":
					this.QryTp = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "StnlnSeqTp":
					this.StnlnSeqTp = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "FnoBalEvalTpCode":
					this.FnoBalEvalTpCode = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public bool VerifyData()
		{
			if (RecCnt.ToString().Length > 5) return false; // long 5
			if (AcntNo?.Length > 20) return false; // char 20
			if (Pwd?.Length > 8) return false; // char 8
			if (QrySrtDt?.Length > 8) return false; // char 8
			if (QryEndDt?.Length > 8) return false; // char 8
			// QryTp char 1
			// StnlnSeqTp char 1
			// FnoBalEvalTpCode char 1

			return true;
		}
	}

	public partial class XQCFOEQ82600OutBlock1 : XingBlock
	{
		/// <summary>
		/// CFOEQ82600OutBlock1
		/// </summary>
		public const string _blockName = "CFOEQ82600OutBlock1";
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
		/// CFOEQ82600OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CFOEQ82600OutBlock1
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
		/// 조회구분
		/// </summary>
		[XAQueryFieldAttribute("조회구분")]
		public char QryTp;
		/// <summary>
		/// 정렬순서구분
		/// </summary>
		[XAQueryFieldAttribute("정렬순서구분")]
		public char StnlnSeqTp;
		/// <summary>
		/// 선물옵션잔고평가구분코드
		/// </summary>
		[XAQueryFieldAttribute("선물옵션잔고평가구분코드")]
		public char FnoBalEvalTpCode;

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
			/// 조회시작일
			/// </summary>
			public const string QrySrtDt = "QrySrtDt";
			/// <summary>
			/// 조회종료일
			/// </summary>
			public const string QryEndDt = "QryEndDt";
			/// <summary>
			/// 조회구분
			/// </summary>
			public const string QryTp = "QryTp";
			/// <summary>
			/// 정렬순서구분
			/// </summary>
			public const string StnlnSeqTp = "StnlnSeqTp";
			/// <summary>
			/// 선물옵션잔고평가구분코드
			/// </summary>
			public const string FnoBalEvalTpCode = "FnoBalEvalTpCode";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.AcntNo,
			F.Pwd,
			F.QrySrtDt,
			F.QryEndDt,
			F.QryTp,
			F.StnlnSeqTp,
			F.FnoBalEvalTpCode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["AcntNo"] = new XAQueryFieldInfo("char", AcntNo, AcntNo, "계좌번호", (decimal)20);
			dict["Pwd"] = new XAQueryFieldInfo("char", Pwd, Pwd, "비밀번호", (decimal)8);
			dict["QrySrtDt"] = new XAQueryFieldInfo("char", QrySrtDt, QrySrtDt, "조회시작일", (decimal)8);
			dict["QryEndDt"] = new XAQueryFieldInfo("char", QryEndDt, QryEndDt, "조회종료일", (decimal)8);
			dict["QryTp"] = new XAQueryFieldInfo("char", QryTp, QryTp.ToString(), "조회구분", (decimal)1);
			dict["StnlnSeqTp"] = new XAQueryFieldInfo("char", StnlnSeqTp, StnlnSeqTp.ToString(), "정렬순서구분", (decimal)1);
			dict["FnoBalEvalTpCode"] = new XAQueryFieldInfo("char", FnoBalEvalTpCode, FnoBalEvalTpCode.ToString(), "선물옵션잔고평가구분코드", (decimal)1);

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

				case "QrySrtDt":
					this.QrySrtDt = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "QryEndDt":
					this.QryEndDt = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "QryTp":
					this.QryTp = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "StnlnSeqTp":
					this.StnlnSeqTp = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "FnoBalEvalTpCode":
					this.FnoBalEvalTpCode = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public static XQCFOEQ82600OutBlock1 FromQuery(XQCFOEQ82600 query)
		{
			XQCFOEQ82600OutBlock1 block = new XQCFOEQ82600OutBlock1();
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
				block.QrySrtDt = query.GetFieldData(block.GetBlockName(), "QrySrtDt", 0).TrimEnd('?'); // char 8
				block.QryEndDt = query.GetFieldData(block.GetBlockName(), "QryEndDt", 0).TrimEnd('?'); // char 8
				block.QryTp = query.GetFieldData(block.GetBlockName(), "QryTp", 0).FirstOrDefault(); // char 1
				block.StnlnSeqTp = query.GetFieldData(block.GetBlockName(), "StnlnSeqTp", 0).FirstOrDefault(); // char 1
				block.FnoBalEvalTpCode = query.GetFieldData(block.GetBlockName(), "FnoBalEvalTpCode", 0).FirstOrDefault(); // char 1

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
			if (QrySrtDt?.Length > 8) return false; // char 8
			if (QryEndDt?.Length > 8) return false; // char 8
			// QryTp char 1
			// StnlnSeqTp char 1
			// FnoBalEvalTpCode char 1

			return true;
		}
	}

	public partial class XQCFOEQ82600OutBlock2 : XingBlock
	{
		/// <summary>
		/// CFOEQ82600OutBlock2
		/// </summary>
		public const string _blockName = "CFOEQ82600OutBlock2";
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
		/// CFOEQ82600OutBlock2
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CFOEQ82600OutBlock2
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
		/// 선물정산차금
		/// </summary>
		[XAQueryFieldAttribute("선물정산차금")]
		public long FutsAdjstDfamt;
		/// <summary>
		/// 옵션매매손익금액
		/// </summary>
		[XAQueryFieldAttribute("옵션매매손익금액")]
		public long OptBnsplAmt;
		/// <summary>
		/// 선물옵션수수료
		/// </summary>
		[XAQueryFieldAttribute("선물옵션수수료")]
		public long FnoCmsnAmt;
		/// <summary>
		/// 손익합계금액
		/// </summary>
		[XAQueryFieldAttribute("손익합계금액")]
		public long PnlSumAmt;
		/// <summary>
		/// 입금합계금액
		/// </summary>
		[XAQueryFieldAttribute("입금합계금액")]
		public long MnyinSumAmt;
		/// <summary>
		/// 출금합계금액
		/// </summary>
		[XAQueryFieldAttribute("출금합계금액")]
		public long MnyoutSumAmt;
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
			/// 선물정산차금
			/// </summary>
			public const string FutsAdjstDfamt = "FutsAdjstDfamt";
			/// <summary>
			/// 옵션매매손익금액
			/// </summary>
			public const string OptBnsplAmt = "OptBnsplAmt";
			/// <summary>
			/// 선물옵션수수료
			/// </summary>
			public const string FnoCmsnAmt = "FnoCmsnAmt";
			/// <summary>
			/// 손익합계금액
			/// </summary>
			public const string PnlSumAmt = "PnlSumAmt";
			/// <summary>
			/// 입금합계금액
			/// </summary>
			public const string MnyinSumAmt = "MnyinSumAmt";
			/// <summary>
			/// 출금합계금액
			/// </summary>
			public const string MnyoutSumAmt = "MnyoutSumAmt";
			/// <summary>
			/// 계좌명
			/// </summary>
			public const string AcntNm = "AcntNm";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.FutsAdjstDfamt,
			F.OptBnsplAmt,
			F.FnoCmsnAmt,
			F.PnlSumAmt,
			F.MnyinSumAmt,
			F.MnyoutSumAmt,
			F.AcntNm,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["FutsAdjstDfamt"] = new XAQueryFieldInfo("long", FutsAdjstDfamt, FutsAdjstDfamt.ToString("d16"), "선물정산차금", (decimal)16);
			dict["OptBnsplAmt"] = new XAQueryFieldInfo("long", OptBnsplAmt, OptBnsplAmt.ToString("d16"), "옵션매매손익금액", (decimal)16);
			dict["FnoCmsnAmt"] = new XAQueryFieldInfo("long", FnoCmsnAmt, FnoCmsnAmt.ToString("d16"), "선물옵션수수료", (decimal)16);
			dict["PnlSumAmt"] = new XAQueryFieldInfo("long", PnlSumAmt, PnlSumAmt.ToString("d16"), "손익합계금액", (decimal)16);
			dict["MnyinSumAmt"] = new XAQueryFieldInfo("long", MnyinSumAmt, MnyinSumAmt.ToString("d16"), "입금합계금액", (decimal)16);
			dict["MnyoutSumAmt"] = new XAQueryFieldInfo("long", MnyoutSumAmt, MnyoutSumAmt.ToString("d16"), "출금합계금액", (decimal)16);
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

				case "FutsAdjstDfamt":
					this.FutsAdjstDfamt = fieldInfo.FieldValue.ParseLong("FutsAdjstDfamt");
				break;

				case "OptBnsplAmt":
					this.OptBnsplAmt = fieldInfo.FieldValue.ParseLong("OptBnsplAmt");
				break;

				case "FnoCmsnAmt":
					this.FnoCmsnAmt = fieldInfo.FieldValue.ParseLong("FnoCmsnAmt");
				break;

				case "PnlSumAmt":
					this.PnlSumAmt = fieldInfo.FieldValue.ParseLong("PnlSumAmt");
				break;

				case "MnyinSumAmt":
					this.MnyinSumAmt = fieldInfo.FieldValue.ParseLong("MnyinSumAmt");
				break;

				case "MnyoutSumAmt":
					this.MnyoutSumAmt = fieldInfo.FieldValue.ParseLong("MnyoutSumAmt");
				break;

				case "AcntNm":
					this.AcntNm = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQCFOEQ82600OutBlock2 FromQuery(XQCFOEQ82600 query)
		{
			XQCFOEQ82600OutBlock2 block = new XQCFOEQ82600OutBlock2();
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
				block.FutsAdjstDfamt = query.GetFieldData(block.GetBlockName(), "FutsAdjstDfamt", 0).ParseLong("FutsAdjstDfamt"); // long 16
				block.OptBnsplAmt = query.GetFieldData(block.GetBlockName(), "OptBnsplAmt", 0).ParseLong("OptBnsplAmt"); // long 16
				block.FnoCmsnAmt = query.GetFieldData(block.GetBlockName(), "FnoCmsnAmt", 0).ParseLong("FnoCmsnAmt"); // long 16
				block.PnlSumAmt = query.GetFieldData(block.GetBlockName(), "PnlSumAmt", 0).ParseLong("PnlSumAmt"); // long 16
				block.MnyinSumAmt = query.GetFieldData(block.GetBlockName(), "MnyinSumAmt", 0).ParseLong("MnyinSumAmt"); // long 16
				block.MnyoutSumAmt = query.GetFieldData(block.GetBlockName(), "MnyoutSumAmt", 0).ParseLong("MnyoutSumAmt"); // long 16
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
			if (FutsAdjstDfamt.ToString().Length > 16) return false; // long 16
			if (OptBnsplAmt.ToString().Length > 16) return false; // long 16
			if (FnoCmsnAmt.ToString().Length > 16) return false; // long 16
			if (PnlSumAmt.ToString().Length > 16) return false; // long 16
			if (MnyinSumAmt.ToString().Length > 16) return false; // long 16
			if (MnyoutSumAmt.ToString().Length > 16) return false; // long 16
			if (AcntNm?.Length > 40) return false; // char 40

			return true;
		}
	}

	public partial class XQCFOEQ82600OutBlock3 : XingBlock
	{
		/// <summary>
		/// CFOEQ82600OutBlock3
		/// </summary>
		public const string _blockName = "CFOEQ82600OutBlock3";
		/// <summary>
		/// OutList(*EMPTY*)
		/// </summary>
		public const string _blockDesc = "OutList(*EMPTY*)";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// true
		/// </summary>
		public const bool _hasOccurs = true;
		/// <summary>
		/// CFOEQ82600OutBlock3
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CFOEQ82600OutBlock3
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// OutList(*EMPTY*)
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
		/// 조회일
		/// </summary>
		[XAQueryFieldAttribute("조회일")]
		public string QryDt;
		/// <summary>
		/// 예탁총액
		/// </summary>
		[XAQueryFieldAttribute("예탁총액")]
		public long DpstgTotamt;
		/// <summary>
		/// 예탁현금
		/// </summary>
		[XAQueryFieldAttribute("예탁현금")]
		public long DpstgMny;
		/// <summary>
		/// 선물옵션증거금액
		/// </summary>
		[XAQueryFieldAttribute("선물옵션증거금액")]
		public long FnoMgn;
		/// <summary>
		/// 선물손익금액
		/// </summary>
		[XAQueryFieldAttribute("선물손익금액")]
		public long FutsPnlAmt;
		/// <summary>
		/// 옵션매매손익금액
		/// </summary>
		[XAQueryFieldAttribute("옵션매매손익금액")]
		public long OptBsnPnlAmt;
		/// <summary>
		/// 옵션평가손익금액
		/// </summary>
		[XAQueryFieldAttribute("옵션평가손익금액")]
		public long OptEvalPnlAmt;
		/// <summary>
		/// 수수료
		/// </summary>
		[XAQueryFieldAttribute("수수료")]
		public long CmsnAmt;
		/// <summary>
		/// 합계금액1
		/// </summary>
		[XAQueryFieldAttribute("합계금액1")]
		public long SumAmt1;
		/// <summary>
		/// 합계금액
		/// </summary>
		[XAQueryFieldAttribute("합계금액")]
		public long SumAmt2;
		/// <summary>
		/// 손익합계금액
		/// </summary>
		[XAQueryFieldAttribute("손익합계금액")]
		public long PnlSumAmt;
		/// <summary>
		/// 선물매수금액
		/// </summary>
		[XAQueryFieldAttribute("선물매수금액")]
		public long FutsBuyAmt;
		/// <summary>
		/// 선물매도금액
		/// </summary>
		[XAQueryFieldAttribute("선물매도금액")]
		public long FutsSellAmt;
		/// <summary>
		/// 옵션매수금액
		/// </summary>
		[XAQueryFieldAttribute("옵션매수금액")]
		public long OptBuyAmt;
		/// <summary>
		/// 옵션매도금액
		/// </summary>
		[XAQueryFieldAttribute("옵션매도금액")]
		public long OptSellAmt;
		/// <summary>
		/// 입금액
		/// </summary>
		[XAQueryFieldAttribute("입금액")]
		public long InAmt;
		/// <summary>
		/// 출금액
		/// </summary>
		[XAQueryFieldAttribute("출금액")]
		public long OutAmt;
		/// <summary>
		/// 평가금액
		/// </summary>
		[XAQueryFieldAttribute("평가금액")]
		public long EvalAmt;
		/// <summary>
		/// 합산평가금액
		/// </summary>
		[XAQueryFieldAttribute("합산평가금액")]
		public long AddupEvalAmt;
		/// <summary>
		/// 금액2
		/// </summary>
		[XAQueryFieldAttribute("금액2")]
		public long Amt2;

		public static class F
		{
			/// <summary>
			/// 조회일
			/// </summary>
			public const string QryDt = "QryDt";
			/// <summary>
			/// 예탁총액
			/// </summary>
			public const string DpstgTotamt = "DpstgTotamt";
			/// <summary>
			/// 예탁현금
			/// </summary>
			public const string DpstgMny = "DpstgMny";
			/// <summary>
			/// 선물옵션증거금액
			/// </summary>
			public const string FnoMgn = "FnoMgn";
			/// <summary>
			/// 선물손익금액
			/// </summary>
			public const string FutsPnlAmt = "FutsPnlAmt";
			/// <summary>
			/// 옵션매매손익금액
			/// </summary>
			public const string OptBsnPnlAmt = "OptBsnPnlAmt";
			/// <summary>
			/// 옵션평가손익금액
			/// </summary>
			public const string OptEvalPnlAmt = "OptEvalPnlAmt";
			/// <summary>
			/// 수수료
			/// </summary>
			public const string CmsnAmt = "CmsnAmt";
			/// <summary>
			/// 합계금액1
			/// </summary>
			public const string SumAmt1 = "SumAmt1";
			/// <summary>
			/// 합계금액
			/// </summary>
			public const string SumAmt2 = "SumAmt2";
			/// <summary>
			/// 손익합계금액
			/// </summary>
			public const string PnlSumAmt = "PnlSumAmt";
			/// <summary>
			/// 선물매수금액
			/// </summary>
			public const string FutsBuyAmt = "FutsBuyAmt";
			/// <summary>
			/// 선물매도금액
			/// </summary>
			public const string FutsSellAmt = "FutsSellAmt";
			/// <summary>
			/// 옵션매수금액
			/// </summary>
			public const string OptBuyAmt = "OptBuyAmt";
			/// <summary>
			/// 옵션매도금액
			/// </summary>
			public const string OptSellAmt = "OptSellAmt";
			/// <summary>
			/// 입금액
			/// </summary>
			public const string InAmt = "InAmt";
			/// <summary>
			/// 출금액
			/// </summary>
			public const string OutAmt = "OutAmt";
			/// <summary>
			/// 평가금액
			/// </summary>
			public const string EvalAmt = "EvalAmt";
			/// <summary>
			/// 합산평가금액
			/// </summary>
			public const string AddupEvalAmt = "AddupEvalAmt";
			/// <summary>
			/// 금액2
			/// </summary>
			public const string Amt2 = "Amt2";
		}

		public static string[] AllFields = new string[]
		{
			F.QryDt,
			F.DpstgTotamt,
			F.DpstgMny,
			F.FnoMgn,
			F.FutsPnlAmt,
			F.OptBsnPnlAmt,
			F.OptEvalPnlAmt,
			F.CmsnAmt,
			F.SumAmt1,
			F.SumAmt2,
			F.PnlSumAmt,
			F.FutsBuyAmt,
			F.FutsSellAmt,
			F.OptBuyAmt,
			F.OptSellAmt,
			F.InAmt,
			F.OutAmt,
			F.EvalAmt,
			F.AddupEvalAmt,
			F.Amt2,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["QryDt"] = new XAQueryFieldInfo("char", QryDt, QryDt, "조회일", (decimal)8);
			dict["DpstgTotamt"] = new XAQueryFieldInfo("long", DpstgTotamt, DpstgTotamt.ToString("d16"), "예탁총액", (decimal)16);
			dict["DpstgMny"] = new XAQueryFieldInfo("long", DpstgMny, DpstgMny.ToString("d16"), "예탁현금", (decimal)16);
			dict["FnoMgn"] = new XAQueryFieldInfo("long", FnoMgn, FnoMgn.ToString("d16"), "선물옵션증거금액", (decimal)16);
			dict["FutsPnlAmt"] = new XAQueryFieldInfo("long", FutsPnlAmt, FutsPnlAmt.ToString("d16"), "선물손익금액", (decimal)16);
			dict["OptBsnPnlAmt"] = new XAQueryFieldInfo("long", OptBsnPnlAmt, OptBsnPnlAmt.ToString("d16"), "옵션매매손익금액", (decimal)16);
			dict["OptEvalPnlAmt"] = new XAQueryFieldInfo("long", OptEvalPnlAmt, OptEvalPnlAmt.ToString("d16"), "옵션평가손익금액", (decimal)16);
			dict["CmsnAmt"] = new XAQueryFieldInfo("long", CmsnAmt, CmsnAmt.ToString("d16"), "수수료", (decimal)16);
			dict["SumAmt1"] = new XAQueryFieldInfo("long", SumAmt1, SumAmt1.ToString("d16"), "합계금액1", (decimal)16);
			dict["SumAmt2"] = new XAQueryFieldInfo("long", SumAmt2, SumAmt2.ToString("d16"), "합계금액", (decimal)16);
			dict["PnlSumAmt"] = new XAQueryFieldInfo("long", PnlSumAmt, PnlSumAmt.ToString("d16"), "손익합계금액", (decimal)16);
			dict["FutsBuyAmt"] = new XAQueryFieldInfo("long", FutsBuyAmt, FutsBuyAmt.ToString("d16"), "선물매수금액", (decimal)16);
			dict["FutsSellAmt"] = new XAQueryFieldInfo("long", FutsSellAmt, FutsSellAmt.ToString("d16"), "선물매도금액", (decimal)16);
			dict["OptBuyAmt"] = new XAQueryFieldInfo("long", OptBuyAmt, OptBuyAmt.ToString("d16"), "옵션매수금액", (decimal)16);
			dict["OptSellAmt"] = new XAQueryFieldInfo("long", OptSellAmt, OptSellAmt.ToString("d16"), "옵션매도금액", (decimal)16);
			dict["InAmt"] = new XAQueryFieldInfo("long", InAmt, InAmt.ToString("d16"), "입금액", (decimal)16);
			dict["OutAmt"] = new XAQueryFieldInfo("long", OutAmt, OutAmt.ToString("d16"), "출금액", (decimal)16);
			dict["EvalAmt"] = new XAQueryFieldInfo("long", EvalAmt, EvalAmt.ToString("d16"), "평가금액", (decimal)16);
			dict["AddupEvalAmt"] = new XAQueryFieldInfo("long", AddupEvalAmt, AddupEvalAmt.ToString("d16"), "합산평가금액", (decimal)16);
			dict["Amt2"] = new XAQueryFieldInfo("long", Amt2, Amt2.ToString("d16"), "금액2", (decimal)16);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "QryDt":
					this.QryDt = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "DpstgTotamt":
					this.DpstgTotamt = fieldInfo.FieldValue.ParseLong("DpstgTotamt");
				break;

				case "DpstgMny":
					this.DpstgMny = fieldInfo.FieldValue.ParseLong("DpstgMny");
				break;

				case "FnoMgn":
					this.FnoMgn = fieldInfo.FieldValue.ParseLong("FnoMgn");
				break;

				case "FutsPnlAmt":
					this.FutsPnlAmt = fieldInfo.FieldValue.ParseLong("FutsPnlAmt");
				break;

				case "OptBsnPnlAmt":
					this.OptBsnPnlAmt = fieldInfo.FieldValue.ParseLong("OptBsnPnlAmt");
				break;

				case "OptEvalPnlAmt":
					this.OptEvalPnlAmt = fieldInfo.FieldValue.ParseLong("OptEvalPnlAmt");
				break;

				case "CmsnAmt":
					this.CmsnAmt = fieldInfo.FieldValue.ParseLong("CmsnAmt");
				break;

				case "SumAmt1":
					this.SumAmt1 = fieldInfo.FieldValue.ParseLong("SumAmt1");
				break;

				case "SumAmt2":
					this.SumAmt2 = fieldInfo.FieldValue.ParseLong("SumAmt2");
				break;

				case "PnlSumAmt":
					this.PnlSumAmt = fieldInfo.FieldValue.ParseLong("PnlSumAmt");
				break;

				case "FutsBuyAmt":
					this.FutsBuyAmt = fieldInfo.FieldValue.ParseLong("FutsBuyAmt");
				break;

				case "FutsSellAmt":
					this.FutsSellAmt = fieldInfo.FieldValue.ParseLong("FutsSellAmt");
				break;

				case "OptBuyAmt":
					this.OptBuyAmt = fieldInfo.FieldValue.ParseLong("OptBuyAmt");
				break;

				case "OptSellAmt":
					this.OptSellAmt = fieldInfo.FieldValue.ParseLong("OptSellAmt");
				break;

				case "InAmt":
					this.InAmt = fieldInfo.FieldValue.ParseLong("InAmt");
				break;

				case "OutAmt":
					this.OutAmt = fieldInfo.FieldValue.ParseLong("OutAmt");
				break;

				case "EvalAmt":
					this.EvalAmt = fieldInfo.FieldValue.ParseLong("EvalAmt");
				break;

				case "AddupEvalAmt":
					this.AddupEvalAmt = fieldInfo.FieldValue.ParseLong("AddupEvalAmt");
				break;

				case "Amt2":
					this.Amt2 = fieldInfo.FieldValue.ParseLong("Amt2");
				break;


			}
		}

		public static XQCFOEQ82600OutBlock3[] ListFromQuery(XQCFOEQ82600 query)
		{
			int count = query.GetBlockCount(XQCFOEQ82600OutBlock3.BlockName);
			List<XQCFOEQ82600OutBlock3> list = new List<XQCFOEQ82600OutBlock3>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQCFOEQ82600OutBlock3 block = new XQCFOEQ82600OutBlock3();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.QryDt = query.GetFieldData(block.GetBlockName(), "QryDt", i).TrimEnd('?'); // char 8
					block.DpstgTotamt = query.GetFieldData(block.GetBlockName(), "DpstgTotamt", i).ParseLong("DpstgTotamt"); // long 16
					block.DpstgMny = query.GetFieldData(block.GetBlockName(), "DpstgMny", i).ParseLong("DpstgMny"); // long 16
					block.FnoMgn = query.GetFieldData(block.GetBlockName(), "FnoMgn", i).ParseLong("FnoMgn"); // long 16
					block.FutsPnlAmt = query.GetFieldData(block.GetBlockName(), "FutsPnlAmt", i).ParseLong("FutsPnlAmt"); // long 16
					block.OptBsnPnlAmt = query.GetFieldData(block.GetBlockName(), "OptBsnPnlAmt", i).ParseLong("OptBsnPnlAmt"); // long 16
					block.OptEvalPnlAmt = query.GetFieldData(block.GetBlockName(), "OptEvalPnlAmt", i).ParseLong("OptEvalPnlAmt"); // long 16
					block.CmsnAmt = query.GetFieldData(block.GetBlockName(), "CmsnAmt", i).ParseLong("CmsnAmt"); // long 16
					block.SumAmt1 = query.GetFieldData(block.GetBlockName(), "SumAmt1", i).ParseLong("SumAmt1"); // long 16
					block.SumAmt2 = query.GetFieldData(block.GetBlockName(), "SumAmt2", i).ParseLong("SumAmt2"); // long 16
					block.PnlSumAmt = query.GetFieldData(block.GetBlockName(), "PnlSumAmt", i).ParseLong("PnlSumAmt"); // long 16
					block.FutsBuyAmt = query.GetFieldData(block.GetBlockName(), "FutsBuyAmt", i).ParseLong("FutsBuyAmt"); // long 16
					block.FutsSellAmt = query.GetFieldData(block.GetBlockName(), "FutsSellAmt", i).ParseLong("FutsSellAmt"); // long 16
					block.OptBuyAmt = query.GetFieldData(block.GetBlockName(), "OptBuyAmt", i).ParseLong("OptBuyAmt"); // long 16
					block.OptSellAmt = query.GetFieldData(block.GetBlockName(), "OptSellAmt", i).ParseLong("OptSellAmt"); // long 16
					block.InAmt = query.GetFieldData(block.GetBlockName(), "InAmt", i).ParseLong("InAmt"); // long 16
					block.OutAmt = query.GetFieldData(block.GetBlockName(), "OutAmt", i).ParseLong("OutAmt"); // long 16
					block.EvalAmt = query.GetFieldData(block.GetBlockName(), "EvalAmt", i).ParseLong("EvalAmt"); // long 16
					block.AddupEvalAmt = query.GetFieldData(block.GetBlockName(), "AddupEvalAmt", i).ParseLong("AddupEvalAmt"); // long 16
					block.Amt2 = query.GetFieldData(block.GetBlockName(), "Amt2", i).ParseLong("Amt2"); // long 16

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
			if (QryDt?.Length > 8) return false; // char 8
			if (DpstgTotamt.ToString().Length > 16) return false; // long 16
			if (DpstgMny.ToString().Length > 16) return false; // long 16
			if (FnoMgn.ToString().Length > 16) return false; // long 16
			if (FutsPnlAmt.ToString().Length > 16) return false; // long 16
			if (OptBsnPnlAmt.ToString().Length > 16) return false; // long 16
			if (OptEvalPnlAmt.ToString().Length > 16) return false; // long 16
			if (CmsnAmt.ToString().Length > 16) return false; // long 16
			if (SumAmt1.ToString().Length > 16) return false; // long 16
			if (SumAmt2.ToString().Length > 16) return false; // long 16
			if (PnlSumAmt.ToString().Length > 16) return false; // long 16
			if (FutsBuyAmt.ToString().Length > 16) return false; // long 16
			if (FutsSellAmt.ToString().Length > 16) return false; // long 16
			if (OptBuyAmt.ToString().Length > 16) return false; // long 16
			if (OptSellAmt.ToString().Length > 16) return false; // long 16
			if (InAmt.ToString().Length > 16) return false; // long 16
			if (OutAmt.ToString().Length > 16) return false; // long 16
			if (EvalAmt.ToString().Length > 16) return false; // long 16
			if (AddupEvalAmt.ToString().Length > 16) return false; // long 16
			if (Amt2.ToString().Length > 16) return false; // long 16

			return true;
		}
	}

	/// <summary>
	/// 선물옵션 일별 계좌손익내역
	/// </summary>
	public partial class XQCFOEQ82600 : XingQuery
	{
		/// <summary>
		/// CFOEQ82600
		/// </summary>
		public const string _typeName = "CFOEQ82600";
		/// <summary>
		/// 선물옵션 일별 계좌손익내역
		/// </summary>
		public const string _typeDesc = "선물옵션 일별 계좌손익내역";
		/// <summary>
		/// CFOEQ82600
		/// </summary>
		public const string _service = "CFOEQ82600";
		/// <summary>
		/// B
		/// </summary>
		public const string _headType = "B";
		/// <summary>
		/// 황규석
		/// </summary>
		public const string _creator = "황규석";
		/// <summary>
		/// 2013/01/06 17:48:51
		/// </summary>
		public const string _createdDate = "2013/01/06 17:48:51";
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
		/// CFOEQ82600
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 선물옵션 일별 계좌손익내역
		/// </summary>
		public string TypeDesc => _typeDesc;
		/// <summary>
		/// CFOEQ82600
		/// </summary>
		public string Service => _service;
		/// <summary>
		/// B
		/// </summary>
		public string HeadType => _headType;
		/// <summary>
		/// 황규석
		/// </summary>
		public string Creator => _creator;
		/// <summary>
		/// 2013/01/06 17:48:51
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
		/// 선물옵션 일별 계좌손익내역
		/// </summary>
		public XQCFOEQ82600() : base("CFOEQ82600") { }



		public bool SetBlock(XQCFOEQ82600InBlock1 block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "RecCnt", 0, block.RecCnt.ToString("d5")); // long 5
			_xaQuery.SetFieldData(block.GetBlockName(), "AcntNo", 0, block.AcntNo); // char 20
			_xaQuery.SetFieldData(block.GetBlockName(), "Pwd", 0, block.Pwd); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "QrySrtDt", 0, block.QrySrtDt); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "QryEndDt", 0, block.QryEndDt); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "QryTp", 0, block.QryTp.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "StnlnSeqTp", 0, block.StnlnSeqTp.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "FnoBalEvalTpCode", 0, block.FnoBalEvalTpCode.ToString()); // char 1

			return true;
		}

		public XQCFOEQ82600OutBlock1 GetBlock1()
		{
			XQCFOEQ82600OutBlock1 instance = XQCFOEQ82600OutBlock1.FromQuery(this);
			return instance;

		}

		public XQCFOEQ82600OutBlock2 GetBlock2()
		{
			XQCFOEQ82600OutBlock2 instance = XQCFOEQ82600OutBlock2.FromQuery(this);
			return instance;

		}

		public XQCFOEQ82600OutBlock3[] GetBlock3s()
		{
			XQCFOEQ82600OutBlock3[] instance = XQCFOEQ82600OutBlock3.ListFromQuery(this);
			return instance;

		}


	}

}
