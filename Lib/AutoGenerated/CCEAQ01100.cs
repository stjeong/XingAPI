using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQCCEAQ01100InBlock1 : XingBlock
	{
		/// <summary>
		/// CCEAQ01100InBlock1
		/// </summary>
		public const string _blockName = "CCEAQ01100InBlock1";
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
		/// CCEAQ01100InBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CCEAQ01100InBlock1
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
			/// 정렬순서구분
			/// </summary>
			public const string StnlnSeqTp = "StnlnSeqTp";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.AcntNo,
			F.Pwd,
			F.QrySrtDt,
			F.QryEndDt,
			F.StnlnSeqTp,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["AcntNo"] = new XAQueryFieldInfo("char", AcntNo, AcntNo, "계좌번호", (decimal)20);
			dict["Pwd"] = new XAQueryFieldInfo("char", Pwd, Pwd, "비밀번호", (decimal)8);
			dict["QrySrtDt"] = new XAQueryFieldInfo("char", QrySrtDt, QrySrtDt, "조회시작일", (decimal)8);
			dict["QryEndDt"] = new XAQueryFieldInfo("char", QryEndDt, QryEndDt, "조회종료일", (decimal)8);
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

				case "StnlnSeqTp":
					this.StnlnSeqTp = fieldInfo.FieldValue.FirstOrDefault();
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
			// StnlnSeqTp char 1

			return true;
		}
	}

	public partial class XQCCEAQ01100OutBlock1 : XingBlock
	{
		/// <summary>
		/// CCEAQ01100OutBlock1
		/// </summary>
		public const string _blockName = "CCEAQ01100OutBlock1";
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
		/// CCEAQ01100OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CCEAQ01100OutBlock1
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
			/// 정렬순서구분
			/// </summary>
			public const string StnlnSeqTp = "StnlnSeqTp";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.AcntNo,
			F.Pwd,
			F.QrySrtDt,
			F.QryEndDt,
			F.StnlnSeqTp,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["AcntNo"] = new XAQueryFieldInfo("char", AcntNo, AcntNo, "계좌번호", (decimal)20);
			dict["Pwd"] = new XAQueryFieldInfo("char", Pwd, Pwd, "비밀번호", (decimal)8);
			dict["QrySrtDt"] = new XAQueryFieldInfo("char", QrySrtDt, QrySrtDt, "조회시작일", (decimal)8);
			dict["QryEndDt"] = new XAQueryFieldInfo("char", QryEndDt, QryEndDt, "조회종료일", (decimal)8);
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

				case "StnlnSeqTp":
					this.StnlnSeqTp = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public static XQCCEAQ01100OutBlock1 FromQuery(XQCCEAQ01100 query)
		{
			XQCCEAQ01100OutBlock1 block = new XQCCEAQ01100OutBlock1();
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
			if (AcntNo?.Length > 20) return false; // char 20
			if (Pwd?.Length > 8) return false; // char 8
			if (QrySrtDt?.Length > 8) return false; // char 8
			if (QryEndDt?.Length > 8) return false; // char 8
			// StnlnSeqTp char 1

			return true;
		}
	}

	public partial class XQCCEAQ01100OutBlock2 : XingBlock
	{
		/// <summary>
		/// CCEAQ01100OutBlock2
		/// </summary>
		public const string _blockName = "CCEAQ01100OutBlock2";
		/// <summary>
		/// Sum(*EMPTY*)
		/// </summary>
		public const string _blockDesc = "Sum(*EMPTY*)";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// false
		/// </summary>
		public const bool _hasOccurs = false;
		/// <summary>
		/// CCEAQ01100OutBlock2
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CCEAQ01100OutBlock2
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// Sum(*EMPTY*)
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
		/// 매매손익금액
		/// </summary>
		[XAQueryFieldAttribute("BnsplAmt", "매매손익금액", "long", "16")]
		public long BnsplAmt;
		/// <summary>
		/// 선물옵션약정금액
		/// </summary>
		[XAQueryFieldAttribute("FnoCtrctAmt", "선물옵션약정금액", "long", "16")]
		public long FnoCtrctAmt;
		/// <summary>
		/// 수수료합계금액
		/// </summary>
		[XAQueryFieldAttribute("CmsnAmtSumAmt", "수수료합계금액", "long", "16")]
		public long CmsnAmtSumAmt;

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
			/// 매매손익금액
			/// </summary>
			public const string BnsplAmt = "BnsplAmt";
			/// <summary>
			/// 선물옵션약정금액
			/// </summary>
			public const string FnoCtrctAmt = "FnoCtrctAmt";
			/// <summary>
			/// 수수료합계금액
			/// </summary>
			public const string CmsnAmtSumAmt = "CmsnAmtSumAmt";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.AcntNm,
			F.BnsplAmt,
			F.FnoCtrctAmt,
			F.CmsnAmtSumAmt,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["AcntNm"] = new XAQueryFieldInfo("char", AcntNm, AcntNm, "계좌명", (decimal)40);
			dict["BnsplAmt"] = new XAQueryFieldInfo("long", BnsplAmt, BnsplAmt.ToString("d16"), "매매손익금액", (decimal)16);
			dict["FnoCtrctAmt"] = new XAQueryFieldInfo("long", FnoCtrctAmt, FnoCtrctAmt.ToString("d16"), "선물옵션약정금액", (decimal)16);
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

				case "AcntNm":
					this.AcntNm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "BnsplAmt":
					this.BnsplAmt = fieldInfo.FieldValue.ParseLong("BnsplAmt");
				break;

				case "FnoCtrctAmt":
					this.FnoCtrctAmt = fieldInfo.FieldValue.ParseLong("FnoCtrctAmt");
				break;

				case "CmsnAmtSumAmt":
					this.CmsnAmtSumAmt = fieldInfo.FieldValue.ParseLong("CmsnAmtSumAmt");
				break;


			}
		}

		public static XQCCEAQ01100OutBlock2 FromQuery(XQCCEAQ01100 query)
		{
			XQCCEAQ01100OutBlock2 block = new XQCCEAQ01100OutBlock2();
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
				block.BnsplAmt = query.GetFieldData(block.GetBlockName(), "BnsplAmt", 0).ParseLong("BnsplAmt"); // long 16
				block.FnoCtrctAmt = query.GetFieldData(block.GetBlockName(), "FnoCtrctAmt", 0).ParseLong("FnoCtrctAmt"); // long 16
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
			if (AcntNm?.Length > 40) return false; // char 40
			if (BnsplAmt.ToString().Length > 16) return false; // long 16
			if (FnoCtrctAmt.ToString().Length > 16) return false; // long 16
			if (CmsnAmtSumAmt.ToString().Length > 16) return false; // long 16

			return true;
		}
	}

	public partial class XQCCEAQ01100OutBlock3 : XingBlock
	{
		/// <summary>
		/// CCEAQ01100OutBlock3
		/// </summary>
		public const string _blockName = "CCEAQ01100OutBlock3";
		/// <summary>
		/// Out(*EMPTY*)
		/// </summary>
		public const string _blockDesc = "Out(*EMPTY*)";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// true
		/// </summary>
		public const bool _hasOccurs = true;
		/// <summary>
		/// CCEAQ01100OutBlock3
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CCEAQ01100OutBlock3
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
		/// true
		/// </summary>
		public bool HasOccurs => _hasOccurs;

		/// <summary>
		/// 매매일
		/// </summary>
		[XAQueryFieldAttribute("BnsDt", "매매일", "char", "8")]
		public string BnsDt;
		/// <summary>
		/// 주문번호
		/// </summary>
		[XAQueryFieldAttribute("OrdNo", "주문번호", "long", "10")]
		public long OrdNo;
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
		[XAQueryFieldAttribute("BnsTpCode", "매매구분", "char", "1")]
		public char BnsTpCode;
		/// <summary>
		/// 매매구분
		/// </summary>
		[XAQueryFieldAttribute("BnsTpNm", "매매구분", "char", "10")]
		public string BnsTpNm;
		/// <summary>
		/// 당초약정지수체결가
		/// </summary>
		[XAQueryFieldAttribute("BgnCtrctIdxExecPrc", "당초약정지수체결가", "double", "13.2")]
		public double BgnCtrctIdxExecPrc;
		/// <summary>
		/// 당초금액
		/// </summary>
		[XAQueryFieldAttribute("BgnAmt", "당초금액", "long", "16")]
		public long BgnAmt;
		/// <summary>
		/// 약정수량
		/// </summary>
		[XAQueryFieldAttribute("CtrctQty", "약정수량", "long", "16")]
		public long CtrctQty;
		/// <summary>
		/// 체결가
		/// </summary>
		[XAQueryFieldAttribute("ExecPrc", "체결가", "double", "13.2")]
		public double ExecPrc;
		/// <summary>
		/// 약정금액
		/// </summary>
		[XAQueryFieldAttribute("CtrctAmt", "약정금액", "long", "16")]
		public long CtrctAmt;
		/// <summary>
		/// 수수료금액
		/// </summary>
		[XAQueryFieldAttribute("CmsnAmt", "수수료금액", "long", "16")]
		public long CmsnAmt;
		/// <summary>
		/// 매매손익금액
		/// </summary>
		[XAQueryFieldAttribute("BnsplAmt", "매매손익금액", "long", "16")]
		public long BnsplAmt;
		/// <summary>
		/// 수수료합산코드
		/// </summary>
		[XAQueryFieldAttribute("CmsnAddupCode", "수수료합산코드", "char", "2")]
		public string CmsnAddupCode;
		/// <summary>
		/// 통신매체코드명
		/// </summary>
		[XAQueryFieldAttribute("CommdaCodeNm", "통신매체코드명", "char", "40")]
		public string CommdaCodeNm;

		public static class F
		{
			/// <summary>
			/// 매매일
			/// </summary>
			public const string BnsDt = "BnsDt";
			/// <summary>
			/// 주문번호
			/// </summary>
			public const string OrdNo = "OrdNo";
			/// <summary>
			/// 약정번호
			/// </summary>
			public const string CtrctNo = "CtrctNo";
			/// <summary>
			/// 체결번호
			/// </summary>
			public const string ExecNo = "ExecNo";
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
			public const string BnsTpCode = "BnsTpCode";
			/// <summary>
			/// 매매구분
			/// </summary>
			public const string BnsTpNm = "BnsTpNm";
			/// <summary>
			/// 당초약정지수체결가
			/// </summary>
			public const string BgnCtrctIdxExecPrc = "BgnCtrctIdxExecPrc";
			/// <summary>
			/// 당초금액
			/// </summary>
			public const string BgnAmt = "BgnAmt";
			/// <summary>
			/// 약정수량
			/// </summary>
			public const string CtrctQty = "CtrctQty";
			/// <summary>
			/// 체결가
			/// </summary>
			public const string ExecPrc = "ExecPrc";
			/// <summary>
			/// 약정금액
			/// </summary>
			public const string CtrctAmt = "CtrctAmt";
			/// <summary>
			/// 수수료금액
			/// </summary>
			public const string CmsnAmt = "CmsnAmt";
			/// <summary>
			/// 매매손익금액
			/// </summary>
			public const string BnsplAmt = "BnsplAmt";
			/// <summary>
			/// 수수료합산코드
			/// </summary>
			public const string CmsnAddupCode = "CmsnAddupCode";
			/// <summary>
			/// 통신매체코드명
			/// </summary>
			public const string CommdaCodeNm = "CommdaCodeNm";
		}

		public static string[] AllFields = new string[]
		{
			F.BnsDt,
			F.OrdNo,
			F.CtrctNo,
			F.ExecNo,
			F.FnoIsuNo,
			F.IsuNm,
			F.BnsTpCode,
			F.BnsTpNm,
			F.BgnCtrctIdxExecPrc,
			F.BgnAmt,
			F.CtrctQty,
			F.ExecPrc,
			F.CtrctAmt,
			F.CmsnAmt,
			F.BnsplAmt,
			F.CmsnAddupCode,
			F.CommdaCodeNm,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["BnsDt"] = new XAQueryFieldInfo("char", BnsDt, BnsDt, "매매일", (decimal)8);
			dict["OrdNo"] = new XAQueryFieldInfo("long", OrdNo, OrdNo.ToString("d10"), "주문번호", (decimal)10);
			dict["CtrctNo"] = new XAQueryFieldInfo("long", CtrctNo, CtrctNo.ToString("d10"), "약정번호", (decimal)10);
			dict["ExecNo"] = new XAQueryFieldInfo("long", ExecNo, ExecNo.ToString("d10"), "체결번호", (decimal)10);
			dict["FnoIsuNo"] = new XAQueryFieldInfo("char", FnoIsuNo, FnoIsuNo, "선물옵션종목번호", (decimal)12);
			dict["IsuNm"] = new XAQueryFieldInfo("char", IsuNm, IsuNm, "종목명", (decimal)40);
			dict["BnsTpCode"] = new XAQueryFieldInfo("char", BnsTpCode, BnsTpCode.ToString(), "매매구분", (decimal)1);
			dict["BnsTpNm"] = new XAQueryFieldInfo("char", BnsTpNm, BnsTpNm, "매매구분", (decimal)10);
			dict["BgnCtrctIdxExecPrc"] = new XAQueryFieldInfo("double", BgnCtrctIdxExecPrc, BgnCtrctIdxExecPrc.ToString("0000000000000.00"), "당초약정지수체결가", (decimal)13.2);
			dict["BgnAmt"] = new XAQueryFieldInfo("long", BgnAmt, BgnAmt.ToString("d16"), "당초금액", (decimal)16);
			dict["CtrctQty"] = new XAQueryFieldInfo("long", CtrctQty, CtrctQty.ToString("d16"), "약정수량", (decimal)16);
			dict["ExecPrc"] = new XAQueryFieldInfo("double", ExecPrc, ExecPrc.ToString("0000000000000.00"), "체결가", (decimal)13.2);
			dict["CtrctAmt"] = new XAQueryFieldInfo("long", CtrctAmt, CtrctAmt.ToString("d16"), "약정금액", (decimal)16);
			dict["CmsnAmt"] = new XAQueryFieldInfo("long", CmsnAmt, CmsnAmt.ToString("d16"), "수수료금액", (decimal)16);
			dict["BnsplAmt"] = new XAQueryFieldInfo("long", BnsplAmt, BnsplAmt.ToString("d16"), "매매손익금액", (decimal)16);
			dict["CmsnAddupCode"] = new XAQueryFieldInfo("char", CmsnAddupCode, CmsnAddupCode, "수수료합산코드", (decimal)2);
			dict["CommdaCodeNm"] = new XAQueryFieldInfo("char", CommdaCodeNm, CommdaCodeNm, "통신매체코드명", (decimal)40);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "BnsDt":
					this.BnsDt = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "OrdNo":
					this.OrdNo = fieldInfo.FieldValue.ParseLong("OrdNo");
				break;

				case "CtrctNo":
					this.CtrctNo = fieldInfo.FieldValue.ParseLong("CtrctNo");
				break;

				case "ExecNo":
					this.ExecNo = fieldInfo.FieldValue.ParseLong("ExecNo");
				break;

				case "FnoIsuNo":
					this.FnoIsuNo = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "IsuNm":
					this.IsuNm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "BnsTpCode":
					this.BnsTpCode = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "BnsTpNm":
					this.BnsTpNm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "BgnCtrctIdxExecPrc":
					this.BgnCtrctIdxExecPrc = fieldInfo.FieldValue.ParseDouble("BgnCtrctIdxExecPrc");
				break;

				case "BgnAmt":
					this.BgnAmt = fieldInfo.FieldValue.ParseLong("BgnAmt");
				break;

				case "CtrctQty":
					this.CtrctQty = fieldInfo.FieldValue.ParseLong("CtrctQty");
				break;

				case "ExecPrc":
					this.ExecPrc = fieldInfo.FieldValue.ParseDouble("ExecPrc");
				break;

				case "CtrctAmt":
					this.CtrctAmt = fieldInfo.FieldValue.ParseLong("CtrctAmt");
				break;

				case "CmsnAmt":
					this.CmsnAmt = fieldInfo.FieldValue.ParseLong("CmsnAmt");
				break;

				case "BnsplAmt":
					this.BnsplAmt = fieldInfo.FieldValue.ParseLong("BnsplAmt");
				break;

				case "CmsnAddupCode":
					this.CmsnAddupCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "CommdaCodeNm":
					this.CommdaCodeNm = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQCCEAQ01100OutBlock3[] ListFromQuery(XQCCEAQ01100 query)
		{
			int count = query.GetBlockCount(XQCCEAQ01100OutBlock3.BlockName);
			List<XQCCEAQ01100OutBlock3> list = new List<XQCCEAQ01100OutBlock3>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQCCEAQ01100OutBlock3 block = new XQCCEAQ01100OutBlock3();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.BnsDt = query.GetFieldData(block.GetBlockName(), "BnsDt", i).TrimEnd('?'); // char 8
					block.OrdNo = query.GetFieldData(block.GetBlockName(), "OrdNo", i).ParseLong("OrdNo"); // long 10
					block.CtrctNo = query.GetFieldData(block.GetBlockName(), "CtrctNo", i).ParseLong("CtrctNo"); // long 10
					block.ExecNo = query.GetFieldData(block.GetBlockName(), "ExecNo", i).ParseLong("ExecNo"); // long 10
					block.FnoIsuNo = query.GetFieldData(block.GetBlockName(), "FnoIsuNo", i).TrimEnd('?'); // char 12
					block.IsuNm = query.GetFieldData(block.GetBlockName(), "IsuNm", i).TrimEnd('?'); // char 40
					block.BnsTpCode = query.GetFieldData(block.GetBlockName(), "BnsTpCode", i).FirstOrDefault(); // char 1
					block.BnsTpNm = query.GetFieldData(block.GetBlockName(), "BnsTpNm", i).TrimEnd('?'); // char 10
					block.BgnCtrctIdxExecPrc = query.GetFieldData(block.GetBlockName(), "BgnCtrctIdxExecPrc", i).ParseDouble("BgnCtrctIdxExecPrc"); // double 13.2
					block.BgnAmt = query.GetFieldData(block.GetBlockName(), "BgnAmt", i).ParseLong("BgnAmt"); // long 16
					block.CtrctQty = query.GetFieldData(block.GetBlockName(), "CtrctQty", i).ParseLong("CtrctQty"); // long 16
					block.ExecPrc = query.GetFieldData(block.GetBlockName(), "ExecPrc", i).ParseDouble("ExecPrc"); // double 13.2
					block.CtrctAmt = query.GetFieldData(block.GetBlockName(), "CtrctAmt", i).ParseLong("CtrctAmt"); // long 16
					block.CmsnAmt = query.GetFieldData(block.GetBlockName(), "CmsnAmt", i).ParseLong("CmsnAmt"); // long 16
					block.BnsplAmt = query.GetFieldData(block.GetBlockName(), "BnsplAmt", i).ParseLong("BnsplAmt"); // long 16
					block.CmsnAddupCode = query.GetFieldData(block.GetBlockName(), "CmsnAddupCode", i).TrimEnd('?'); // char 2
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
			if (BnsDt?.Length > 8) return false; // char 8
			if (OrdNo.ToString().Length > 10) return false; // long 10
			if (CtrctNo.ToString().Length > 10) return false; // long 10
			if (ExecNo.ToString().Length > 10) return false; // long 10
			if (FnoIsuNo?.Length > 12) return false; // char 12
			if (IsuNm?.Length > 40) return false; // char 40
			// BnsTpCode char 1
			if (BnsTpNm?.Length > 10) return false; // char 10
			// BgnCtrctIdxExecPrc double 13.2
			if (BgnAmt.ToString().Length > 16) return false; // long 16
			if (CtrctQty.ToString().Length > 16) return false; // long 16
			// ExecPrc double 13.2
			if (CtrctAmt.ToString().Length > 16) return false; // long 16
			if (CmsnAmt.ToString().Length > 16) return false; // long 16
			if (BnsplAmt.ToString().Length > 16) return false; // long 16
			if (CmsnAddupCode?.Length > 2) return false; // char 2
			if (CommdaCodeNm?.Length > 40) return false; // char 40

			return true;
		}
	}

	/// <summary>
	/// 선물옵션 CME 매매거래현황
	/// </summary>
	public partial class XQCCEAQ01100 : XingQuery
	{
		/// <summary>
		/// CCEAQ01100
		/// </summary>
		public const string _typeName = "CCEAQ01100";
		/// <summary>
		/// 선물옵션 CME 매매거래현황
		/// </summary>
		public const string _typeDesc = "선물옵션 CME 매매거래현황";
		/// <summary>
		/// CCEAQ01100
		/// </summary>
		public const string _service = "CCEAQ01100";
		/// <summary>
		/// B
		/// </summary>
		public const string _headType = "B";
		/// <summary>
		/// 원종혁
		/// </summary>
		public const string _creator = "원종혁";
		/// <summary>
		/// 2019/04/03 16:08:04
		/// </summary>
		public const string _createdDate = "2019/04/03 16:08:04";
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
		/// CCEAQ01100
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 선물옵션 CME 매매거래현황
		/// </summary>
		public string TypeDesc => _typeDesc;
		/// <summary>
		/// CCEAQ01100
		/// </summary>
		public string Service => _service;
		/// <summary>
		/// B
		/// </summary>
		public string HeadType => _headType;
		/// <summary>
		/// 원종혁
		/// </summary>
		public string Creator => _creator;
		/// <summary>
		/// 2019/04/03 16:08:04
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
		/// 선물옵션 CME 매매거래현황
		/// </summary>
		public XQCCEAQ01100() : base("CCEAQ01100") { }




		public bool SetBlock(XQCCEAQ01100InBlock1 block)
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
			_xaQuery.SetFieldData(block.GetBlockName(), "StnlnSeqTp", 0, block.StnlnSeqTp.ToString()); // char 1

			return true;
		}

		public XQCCEAQ01100OutBlock1 GetBlock1()
		{
			XQCCEAQ01100OutBlock1 instance = XQCCEAQ01100OutBlock1.FromQuery(this);
			return instance;

		}

		public XQCCEAQ01100OutBlock2 GetBlock2()
		{
			XQCCEAQ01100OutBlock2 instance = XQCCEAQ01100OutBlock2.FromQuery(this);
			return instance;

		}

		public XQCCEAQ01100OutBlock3[] GetBlock3s()
		{
			XQCCEAQ01100OutBlock3[] instance = XQCCEAQ01100OutBlock3.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQCCEAQ01100OutBlock1),
			typeof(XQCCEAQ01100OutBlock2),
			typeof(XQCCEAQ01100OutBlock3),

		};

	}

}
