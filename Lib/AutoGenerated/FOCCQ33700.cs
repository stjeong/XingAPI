using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQFOCCQ33700InBlock1 : XingBlock
	{
		/// <summary>
		/// FOCCQ33700InBlock1
		/// </summary>
		public const string _blockName = "FOCCQ33700InBlock1";
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
		/// FOCCQ33700InBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// FOCCQ33700InBlock1
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
		/// 조회구분
		/// </summary>
		[XAQueryFieldAttribute("QryTp", "조회구분", "char", "1")]
		public char QryTp;
		/// <summary>
		/// 기준금액구분
		/// </summary>
		[XAQueryFieldAttribute("BaseAmtTp", "기준금액구분", "char", "1")]
		public char BaseAmtTp;
		/// <summary>
		/// 조회기간구분
		/// </summary>
		[XAQueryFieldAttribute("QryTermTp", "조회기간구분", "char", "1")]
		public char QryTermTp;
		/// <summary>
		/// 손익산출구분코드
		/// </summary>
		[XAQueryFieldAttribute("PnlCalcTpCode", "손익산출구분코드", "char", "1")]
		public char PnlCalcTpCode;

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
			/// 기준금액구분
			/// </summary>
			public const string BaseAmtTp = "BaseAmtTp";
			/// <summary>
			/// 조회기간구분
			/// </summary>
			public const string QryTermTp = "QryTermTp";
			/// <summary>
			/// 손익산출구분코드
			/// </summary>
			public const string PnlCalcTpCode = "PnlCalcTpCode";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.AcntNo,
			F.Pwd,
			F.QrySrtDt,
			F.QryEndDt,
			F.QryTp,
			F.BaseAmtTp,
			F.QryTermTp,
			F.PnlCalcTpCode,
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
			dict["BaseAmtTp"] = new XAQueryFieldInfo("char", BaseAmtTp, BaseAmtTp.ToString(), "기준금액구분", (decimal)1);
			dict["QryTermTp"] = new XAQueryFieldInfo("char", QryTermTp, QryTermTp.ToString(), "조회기간구분", (decimal)1);
			dict["PnlCalcTpCode"] = new XAQueryFieldInfo("char", PnlCalcTpCode, PnlCalcTpCode.ToString(), "손익산출구분코드", (decimal)1);

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

				case "BaseAmtTp":
					this.BaseAmtTp = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "QryTermTp":
					this.QryTermTp = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "PnlCalcTpCode":
					this.PnlCalcTpCode = fieldInfo.FieldValue.FirstOrDefault();
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
			// BaseAmtTp char 1
			// QryTermTp char 1
			// PnlCalcTpCode char 1

			return true;
		}
	}

	public partial class XQFOCCQ33700OutBlock1 : XingBlock
	{
		/// <summary>
		/// FOCCQ33700OutBlock1
		/// </summary>
		public const string _blockName = "FOCCQ33700OutBlock1";
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
		/// FOCCQ33700OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// FOCCQ33700OutBlock1
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
		/// 조회구분
		/// </summary>
		[XAQueryFieldAttribute("QryTp", "조회구분", "char", "1")]
		public char QryTp;
		/// <summary>
		/// 기준금액구분
		/// </summary>
		[XAQueryFieldAttribute("BaseAmtTp", "기준금액구분", "char", "1")]
		public char BaseAmtTp;
		/// <summary>
		/// 조회기간구분
		/// </summary>
		[XAQueryFieldAttribute("QryTermTp", "조회기간구분", "char", "1")]
		public char QryTermTp;
		/// <summary>
		/// 손익산출구분코드
		/// </summary>
		[XAQueryFieldAttribute("PnlCalcTpCode", "손익산출구분코드", "char", "1")]
		public char PnlCalcTpCode;

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
			/// 기준금액구분
			/// </summary>
			public const string BaseAmtTp = "BaseAmtTp";
			/// <summary>
			/// 조회기간구분
			/// </summary>
			public const string QryTermTp = "QryTermTp";
			/// <summary>
			/// 손익산출구분코드
			/// </summary>
			public const string PnlCalcTpCode = "PnlCalcTpCode";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.AcntNo,
			F.Pwd,
			F.QrySrtDt,
			F.QryEndDt,
			F.QryTp,
			F.BaseAmtTp,
			F.QryTermTp,
			F.PnlCalcTpCode,
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
			dict["BaseAmtTp"] = new XAQueryFieldInfo("char", BaseAmtTp, BaseAmtTp.ToString(), "기준금액구분", (decimal)1);
			dict["QryTermTp"] = new XAQueryFieldInfo("char", QryTermTp, QryTermTp.ToString(), "조회기간구분", (decimal)1);
			dict["PnlCalcTpCode"] = new XAQueryFieldInfo("char", PnlCalcTpCode, PnlCalcTpCode.ToString(), "손익산출구분코드", (decimal)1);

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

				case "BaseAmtTp":
					this.BaseAmtTp = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "QryTermTp":
					this.QryTermTp = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "PnlCalcTpCode":
					this.PnlCalcTpCode = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public static XQFOCCQ33700OutBlock1 FromQuery(XQFOCCQ33700 query)
		{
			XQFOCCQ33700OutBlock1 block = new XQFOCCQ33700OutBlock1();
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
				block.BaseAmtTp = query.GetFieldData(block.GetBlockName(), "BaseAmtTp", 0).FirstOrDefault(); // char 1
				block.QryTermTp = query.GetFieldData(block.GetBlockName(), "QryTermTp", 0).FirstOrDefault(); // char 1
				block.PnlCalcTpCode = query.GetFieldData(block.GetBlockName(), "PnlCalcTpCode", 0).FirstOrDefault(); // char 1

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
			// BaseAmtTp char 1
			// QryTermTp char 1
			// PnlCalcTpCode char 1

			return true;
		}
	}

	public partial class XQFOCCQ33700OutBlock2 : XingBlock
	{
		/// <summary>
		/// FOCCQ33700OutBlock2
		/// </summary>
		public const string _blockName = "FOCCQ33700OutBlock2";
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
		/// FOCCQ33700OutBlock2
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// FOCCQ33700OutBlock2
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
		/// 선물옵션약정금액
		/// </summary>
		[XAQueryFieldAttribute("FnoCtrctAmt", "선물옵션약정금액", "long", "16")]
		public long FnoCtrctAmt;
		/// <summary>
		/// 투자원금평잔금액
		/// </summary>
		[XAQueryFieldAttribute("InvstPramtAvrbalAmt", "투자원금평잔금액", "long", "16")]
		public long InvstPramtAvrbalAmt;
		/// <summary>
		/// 선물정산차금
		/// </summary>
		[XAQueryFieldAttribute("FutsAdjstDfamt", "선물정산차금", "long", "16")]
		public long FutsAdjstDfamt;
		/// <summary>
		/// 옵션매매손익금액
		/// </summary>
		[XAQueryFieldAttribute("OptBsnPnlAmt", "옵션매매손익금액", "long", "16")]
		public long OptBsnPnlAmt;
		/// <summary>
		/// 옵션평가손익금액
		/// </summary>
		[XAQueryFieldAttribute("OptEvalPnlAmt", "옵션평가손익금액", "long", "16")]
		public long OptEvalPnlAmt;
		/// <summary>
		/// 투자손익금액
		/// </summary>
		[XAQueryFieldAttribute("InvstPlAmt", "투자손익금액", "long", "16")]
		public long InvstPlAmt;
		/// <summary>
		/// 수익률
		/// </summary>
		[XAQueryFieldAttribute("ErnRat", "수익률", "double", "12.6")]
		public double ErnRat;

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
			/// 입금액
			/// </summary>
			public const string InAmt = "InAmt";
			/// <summary>
			/// 출금액
			/// </summary>
			public const string OutAmt = "OutAmt";
			/// <summary>
			/// 선물옵션약정금액
			/// </summary>
			public const string FnoCtrctAmt = "FnoCtrctAmt";
			/// <summary>
			/// 투자원금평잔금액
			/// </summary>
			public const string InvstPramtAvrbalAmt = "InvstPramtAvrbalAmt";
			/// <summary>
			/// 선물정산차금
			/// </summary>
			public const string FutsAdjstDfamt = "FutsAdjstDfamt";
			/// <summary>
			/// 옵션매매손익금액
			/// </summary>
			public const string OptBsnPnlAmt = "OptBsnPnlAmt";
			/// <summary>
			/// 옵션평가손익금액
			/// </summary>
			public const string OptEvalPnlAmt = "OptEvalPnlAmt";
			/// <summary>
			/// 투자손익금액
			/// </summary>
			public const string InvstPlAmt = "InvstPlAmt";
			/// <summary>
			/// 수익률
			/// </summary>
			public const string ErnRat = "ErnRat";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.AcntNm,
			F.InAmt,
			F.OutAmt,
			F.FnoCtrctAmt,
			F.InvstPramtAvrbalAmt,
			F.FutsAdjstDfamt,
			F.OptBsnPnlAmt,
			F.OptEvalPnlAmt,
			F.InvstPlAmt,
			F.ErnRat,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["AcntNm"] = new XAQueryFieldInfo("char", AcntNm, AcntNm, "계좌명", (decimal)40);
			dict["InAmt"] = new XAQueryFieldInfo("long", InAmt, InAmt.ToString("d16"), "입금액", (decimal)16);
			dict["OutAmt"] = new XAQueryFieldInfo("long", OutAmt, OutAmt.ToString("d16"), "출금액", (decimal)16);
			dict["FnoCtrctAmt"] = new XAQueryFieldInfo("long", FnoCtrctAmt, FnoCtrctAmt.ToString("d16"), "선물옵션약정금액", (decimal)16);
			dict["InvstPramtAvrbalAmt"] = new XAQueryFieldInfo("long", InvstPramtAvrbalAmt, InvstPramtAvrbalAmt.ToString("d16"), "투자원금평잔금액", (decimal)16);
			dict["FutsAdjstDfamt"] = new XAQueryFieldInfo("long", FutsAdjstDfamt, FutsAdjstDfamt.ToString("d16"), "선물정산차금", (decimal)16);
			dict["OptBsnPnlAmt"] = new XAQueryFieldInfo("long", OptBsnPnlAmt, OptBsnPnlAmt.ToString("d16"), "옵션매매손익금액", (decimal)16);
			dict["OptEvalPnlAmt"] = new XAQueryFieldInfo("long", OptEvalPnlAmt, OptEvalPnlAmt.ToString("d16"), "옵션평가손익금액", (decimal)16);
			dict["InvstPlAmt"] = new XAQueryFieldInfo("long", InvstPlAmt, InvstPlAmt.ToString("d16"), "투자손익금액", (decimal)16);
			dict["ErnRat"] = new XAQueryFieldInfo("double", ErnRat, ErnRat.ToString("000000000000.000000"), "수익률", (decimal)12.6);

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

				case "InAmt":
					this.InAmt = fieldInfo.FieldValue.ParseLong("InAmt");
				break;

				case "OutAmt":
					this.OutAmt = fieldInfo.FieldValue.ParseLong("OutAmt");
				break;

				case "FnoCtrctAmt":
					this.FnoCtrctAmt = fieldInfo.FieldValue.ParseLong("FnoCtrctAmt");
				break;

				case "InvstPramtAvrbalAmt":
					this.InvstPramtAvrbalAmt = fieldInfo.FieldValue.ParseLong("InvstPramtAvrbalAmt");
				break;

				case "FutsAdjstDfamt":
					this.FutsAdjstDfamt = fieldInfo.FieldValue.ParseLong("FutsAdjstDfamt");
				break;

				case "OptBsnPnlAmt":
					this.OptBsnPnlAmt = fieldInfo.FieldValue.ParseLong("OptBsnPnlAmt");
				break;

				case "OptEvalPnlAmt":
					this.OptEvalPnlAmt = fieldInfo.FieldValue.ParseLong("OptEvalPnlAmt");
				break;

				case "InvstPlAmt":
					this.InvstPlAmt = fieldInfo.FieldValue.ParseLong("InvstPlAmt");
				break;

				case "ErnRat":
					this.ErnRat = fieldInfo.FieldValue.ParseDouble("ErnRat");
				break;


			}
		}

		public static XQFOCCQ33700OutBlock2 FromQuery(XQFOCCQ33700 query)
		{
			XQFOCCQ33700OutBlock2 block = new XQFOCCQ33700OutBlock2();
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
				block.InAmt = query.GetFieldData(block.GetBlockName(), "InAmt", 0).ParseLong("InAmt"); // long 16
				block.OutAmt = query.GetFieldData(block.GetBlockName(), "OutAmt", 0).ParseLong("OutAmt"); // long 16
				block.FnoCtrctAmt = query.GetFieldData(block.GetBlockName(), "FnoCtrctAmt", 0).ParseLong("FnoCtrctAmt"); // long 16
				block.InvstPramtAvrbalAmt = query.GetFieldData(block.GetBlockName(), "InvstPramtAvrbalAmt", 0).ParseLong("InvstPramtAvrbalAmt"); // long 16
				block.FutsAdjstDfamt = query.GetFieldData(block.GetBlockName(), "FutsAdjstDfamt", 0).ParseLong("FutsAdjstDfamt"); // long 16
				block.OptBsnPnlAmt = query.GetFieldData(block.GetBlockName(), "OptBsnPnlAmt", 0).ParseLong("OptBsnPnlAmt"); // long 16
				block.OptEvalPnlAmt = query.GetFieldData(block.GetBlockName(), "OptEvalPnlAmt", 0).ParseLong("OptEvalPnlAmt"); // long 16
				block.InvstPlAmt = query.GetFieldData(block.GetBlockName(), "InvstPlAmt", 0).ParseLong("InvstPlAmt"); // long 16
				block.ErnRat = query.GetFieldData(block.GetBlockName(), "ErnRat", 0).ParseDouble("ErnRat"); // double 12.6

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
			if (InAmt.ToString().Length > 16) return false; // long 16
			if (OutAmt.ToString().Length > 16) return false; // long 16
			if (FnoCtrctAmt.ToString().Length > 16) return false; // long 16
			if (InvstPramtAvrbalAmt.ToString().Length > 16) return false; // long 16
			if (FutsAdjstDfamt.ToString().Length > 16) return false; // long 16
			if (OptBsnPnlAmt.ToString().Length > 16) return false; // long 16
			if (OptEvalPnlAmt.ToString().Length > 16) return false; // long 16
			if (InvstPlAmt.ToString().Length > 16) return false; // long 16
			// ErnRat double 12.6

			return true;
		}
	}

	public partial class XQFOCCQ33700OutBlock3 : XingBlock
	{
		/// <summary>
		/// FOCCQ33700OutBlock3
		/// </summary>
		public const string _blockName = "FOCCQ33700OutBlock3";
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
		/// FOCCQ33700OutBlock3
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// FOCCQ33700OutBlock3
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
		/// 거래일
		/// </summary>
		[XAQueryFieldAttribute("TrdDt", "거래일", "char", "8")]
		public string TrdDt;
		/// <summary>
		/// 기초예탁자산금액
		/// </summary>
		[XAQueryFieldAttribute("FdDpsastAmt", "기초예탁자산금액", "long", "16")]
		public long FdDpsastAmt;
		/// <summary>
		/// 기말예탁자산금액
		/// </summary>
		[XAQueryFieldAttribute("EotDpsastAmt", "기말예탁자산금액", "long", "16")]
		public long EotDpsastAmt;
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
		/// 투자원금평잔금액
		/// </summary>
		[XAQueryFieldAttribute("InvstAvrbalPramt", "투자원금평잔금액", "long", "16")]
		public long InvstAvrbalPramt;
		/// <summary>
		/// 투자손익금액
		/// </summary>
		[XAQueryFieldAttribute("InvstPlAmt", "투자손익금액", "long", "16")]
		public long InvstPlAmt;
		/// <summary>
		/// 수익률
		/// </summary>
		[XAQueryFieldAttribute("Ernrat", "수익률", "double", "12.6")]
		public double Ernrat;
		/// <summary>
		/// 선물옵션약정금액
		/// </summary>
		[XAQueryFieldAttribute("FnoCtrctAmt", "선물옵션약정금액", "long", "16")]
		public long FnoCtrctAmt;
		/// <summary>
		/// 회전율
		/// </summary>
		[XAQueryFieldAttribute("Trnrat", "회전율", "double", "12.6")]
		public double Trnrat;
		/// <summary>
		/// 선물정산차금
		/// </summary>
		[XAQueryFieldAttribute("FutsAdjstDfamt", "선물정산차금", "long", "16")]
		public long FutsAdjstDfamt;
		/// <summary>
		/// 옵션매매손익금액
		/// </summary>
		[XAQueryFieldAttribute("OptBsnPnlAmt", "옵션매매손익금액", "long", "16")]
		public long OptBsnPnlAmt;
		/// <summary>
		/// 옵션평가손익금액
		/// </summary>
		[XAQueryFieldAttribute("OptEvalPnlAmt", "옵션평가손익금액", "long", "16")]
		public long OptEvalPnlAmt;

		public static class F
		{
			/// <summary>
			/// 거래일
			/// </summary>
			public const string TrdDt = "TrdDt";
			/// <summary>
			/// 기초예탁자산금액
			/// </summary>
			public const string FdDpsastAmt = "FdDpsastAmt";
			/// <summary>
			/// 기말예탁자산금액
			/// </summary>
			public const string EotDpsastAmt = "EotDpsastAmt";
			/// <summary>
			/// 입금액
			/// </summary>
			public const string InAmt = "InAmt";
			/// <summary>
			/// 출금액
			/// </summary>
			public const string OutAmt = "OutAmt";
			/// <summary>
			/// 투자원금평잔금액
			/// </summary>
			public const string InvstAvrbalPramt = "InvstAvrbalPramt";
			/// <summary>
			/// 투자손익금액
			/// </summary>
			public const string InvstPlAmt = "InvstPlAmt";
			/// <summary>
			/// 수익률
			/// </summary>
			public const string Ernrat = "Ernrat";
			/// <summary>
			/// 선물옵션약정금액
			/// </summary>
			public const string FnoCtrctAmt = "FnoCtrctAmt";
			/// <summary>
			/// 회전율
			/// </summary>
			public const string Trnrat = "Trnrat";
			/// <summary>
			/// 선물정산차금
			/// </summary>
			public const string FutsAdjstDfamt = "FutsAdjstDfamt";
			/// <summary>
			/// 옵션매매손익금액
			/// </summary>
			public const string OptBsnPnlAmt = "OptBsnPnlAmt";
			/// <summary>
			/// 옵션평가손익금액
			/// </summary>
			public const string OptEvalPnlAmt = "OptEvalPnlAmt";
		}

		public static string[] AllFields = new string[]
		{
			F.TrdDt,
			F.FdDpsastAmt,
			F.EotDpsastAmt,
			F.InAmt,
			F.OutAmt,
			F.InvstAvrbalPramt,
			F.InvstPlAmt,
			F.Ernrat,
			F.FnoCtrctAmt,
			F.Trnrat,
			F.FutsAdjstDfamt,
			F.OptBsnPnlAmt,
			F.OptEvalPnlAmt,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["TrdDt"] = new XAQueryFieldInfo("char", TrdDt, TrdDt, "거래일", (decimal)8);
			dict["FdDpsastAmt"] = new XAQueryFieldInfo("long", FdDpsastAmt, FdDpsastAmt.ToString("d16"), "기초예탁자산금액", (decimal)16);
			dict["EotDpsastAmt"] = new XAQueryFieldInfo("long", EotDpsastAmt, EotDpsastAmt.ToString("d16"), "기말예탁자산금액", (decimal)16);
			dict["InAmt"] = new XAQueryFieldInfo("long", InAmt, InAmt.ToString("d16"), "입금액", (decimal)16);
			dict["OutAmt"] = new XAQueryFieldInfo("long", OutAmt, OutAmt.ToString("d16"), "출금액", (decimal)16);
			dict["InvstAvrbalPramt"] = new XAQueryFieldInfo("long", InvstAvrbalPramt, InvstAvrbalPramt.ToString("d16"), "투자원금평잔금액", (decimal)16);
			dict["InvstPlAmt"] = new XAQueryFieldInfo("long", InvstPlAmt, InvstPlAmt.ToString("d16"), "투자손익금액", (decimal)16);
			dict["Ernrat"] = new XAQueryFieldInfo("double", Ernrat, Ernrat.ToString("000000000000.000000"), "수익률", (decimal)12.6);
			dict["FnoCtrctAmt"] = new XAQueryFieldInfo("long", FnoCtrctAmt, FnoCtrctAmt.ToString("d16"), "선물옵션약정금액", (decimal)16);
			dict["Trnrat"] = new XAQueryFieldInfo("double", Trnrat, Trnrat.ToString("000000000000.000000"), "회전율", (decimal)12.6);
			dict["FutsAdjstDfamt"] = new XAQueryFieldInfo("long", FutsAdjstDfamt, FutsAdjstDfamt.ToString("d16"), "선물정산차금", (decimal)16);
			dict["OptBsnPnlAmt"] = new XAQueryFieldInfo("long", OptBsnPnlAmt, OptBsnPnlAmt.ToString("d16"), "옵션매매손익금액", (decimal)16);
			dict["OptEvalPnlAmt"] = new XAQueryFieldInfo("long", OptEvalPnlAmt, OptEvalPnlAmt.ToString("d16"), "옵션평가손익금액", (decimal)16);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "TrdDt":
					this.TrdDt = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "FdDpsastAmt":
					this.FdDpsastAmt = fieldInfo.FieldValue.ParseLong("FdDpsastAmt");
				break;

				case "EotDpsastAmt":
					this.EotDpsastAmt = fieldInfo.FieldValue.ParseLong("EotDpsastAmt");
				break;

				case "InAmt":
					this.InAmt = fieldInfo.FieldValue.ParseLong("InAmt");
				break;

				case "OutAmt":
					this.OutAmt = fieldInfo.FieldValue.ParseLong("OutAmt");
				break;

				case "InvstAvrbalPramt":
					this.InvstAvrbalPramt = fieldInfo.FieldValue.ParseLong("InvstAvrbalPramt");
				break;

				case "InvstPlAmt":
					this.InvstPlAmt = fieldInfo.FieldValue.ParseLong("InvstPlAmt");
				break;

				case "Ernrat":
					this.Ernrat = fieldInfo.FieldValue.ParseDouble("Ernrat");
				break;

				case "FnoCtrctAmt":
					this.FnoCtrctAmt = fieldInfo.FieldValue.ParseLong("FnoCtrctAmt");
				break;

				case "Trnrat":
					this.Trnrat = fieldInfo.FieldValue.ParseDouble("Trnrat");
				break;

				case "FutsAdjstDfamt":
					this.FutsAdjstDfamt = fieldInfo.FieldValue.ParseLong("FutsAdjstDfamt");
				break;

				case "OptBsnPnlAmt":
					this.OptBsnPnlAmt = fieldInfo.FieldValue.ParseLong("OptBsnPnlAmt");
				break;

				case "OptEvalPnlAmt":
					this.OptEvalPnlAmt = fieldInfo.FieldValue.ParseLong("OptEvalPnlAmt");
				break;


			}
		}

		public static XQFOCCQ33700OutBlock3[] ListFromQuery(XQFOCCQ33700 query)
		{
			int count = query.GetBlockCount(XQFOCCQ33700OutBlock3.BlockName);
			List<XQFOCCQ33700OutBlock3> list = new List<XQFOCCQ33700OutBlock3>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQFOCCQ33700OutBlock3 block = new XQFOCCQ33700OutBlock3();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.TrdDt = query.GetFieldData(block.GetBlockName(), "TrdDt", i).TrimEnd('?'); // char 8
					block.FdDpsastAmt = query.GetFieldData(block.GetBlockName(), "FdDpsastAmt", i).ParseLong("FdDpsastAmt"); // long 16
					block.EotDpsastAmt = query.GetFieldData(block.GetBlockName(), "EotDpsastAmt", i).ParseLong("EotDpsastAmt"); // long 16
					block.InAmt = query.GetFieldData(block.GetBlockName(), "InAmt", i).ParseLong("InAmt"); // long 16
					block.OutAmt = query.GetFieldData(block.GetBlockName(), "OutAmt", i).ParseLong("OutAmt"); // long 16
					block.InvstAvrbalPramt = query.GetFieldData(block.GetBlockName(), "InvstAvrbalPramt", i).ParseLong("InvstAvrbalPramt"); // long 16
					block.InvstPlAmt = query.GetFieldData(block.GetBlockName(), "InvstPlAmt", i).ParseLong("InvstPlAmt"); // long 16
					block.Ernrat = query.GetFieldData(block.GetBlockName(), "Ernrat", i).ParseDouble("Ernrat"); // double 12.6
					block.FnoCtrctAmt = query.GetFieldData(block.GetBlockName(), "FnoCtrctAmt", i).ParseLong("FnoCtrctAmt"); // long 16
					block.Trnrat = query.GetFieldData(block.GetBlockName(), "Trnrat", i).ParseDouble("Trnrat"); // double 12.6
					block.FutsAdjstDfamt = query.GetFieldData(block.GetBlockName(), "FutsAdjstDfamt", i).ParseLong("FutsAdjstDfamt"); // long 16
					block.OptBsnPnlAmt = query.GetFieldData(block.GetBlockName(), "OptBsnPnlAmt", i).ParseLong("OptBsnPnlAmt"); // long 16
					block.OptEvalPnlAmt = query.GetFieldData(block.GetBlockName(), "OptEvalPnlAmt", i).ParseLong("OptEvalPnlAmt"); // long 16

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
			if (TrdDt?.Length > 8) return false; // char 8
			if (FdDpsastAmt.ToString().Length > 16) return false; // long 16
			if (EotDpsastAmt.ToString().Length > 16) return false; // long 16
			if (InAmt.ToString().Length > 16) return false; // long 16
			if (OutAmt.ToString().Length > 16) return false; // long 16
			if (InvstAvrbalPramt.ToString().Length > 16) return false; // long 16
			if (InvstPlAmt.ToString().Length > 16) return false; // long 16
			// Ernrat double 12.6
			if (FnoCtrctAmt.ToString().Length > 16) return false; // long 16
			// Trnrat double 12.6
			if (FutsAdjstDfamt.ToString().Length > 16) return false; // long 16
			if (OptBsnPnlAmt.ToString().Length > 16) return false; // long 16
			if (OptEvalPnlAmt.ToString().Length > 16) return false; // long 16

			return true;
		}
	}

	/// <summary>
	/// 선물옵션 기간별 계좌 수익률 현황
	/// </summary>
	public partial class XQFOCCQ33700 : XingQuery
	{
		/// <summary>
		/// FOCCQ33700
		/// </summary>
		public const string _typeName = "FOCCQ33700";
		/// <summary>
		/// 선물옵션 기간별 계좌 수익률 현황
		/// </summary>
		public const string _typeDesc = "선물옵션 기간별 계좌 수익률 현황";
		/// <summary>
		/// FOCCQ33700
		/// </summary>
		public const string _service = "FOCCQ33700";
		/// <summary>
		/// B
		/// </summary>
		public const string _headType = "B";
		/// <summary>
		/// 이석희
		/// </summary>
		public const string _creator = "이석희";
		/// <summary>
		/// 2013/01/08 10:45:28
		/// </summary>
		public const string _createdDate = "2013/01/08 10:45:28";
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
		/// FOCCQ33700
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 선물옵션 기간별 계좌 수익률 현황
		/// </summary>
		public string TypeDesc => _typeDesc;
		/// <summary>
		/// FOCCQ33700
		/// </summary>
		public string Service => _service;
		/// <summary>
		/// B
		/// </summary>
		public string HeadType => _headType;
		/// <summary>
		/// 이석희
		/// </summary>
		public string Creator => _creator;
		/// <summary>
		/// 2013/01/08 10:45:28
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
		/// 선물옵션 기간별 계좌 수익률 현황
		/// </summary>
		public XQFOCCQ33700() : base("FOCCQ33700") { }




		public bool SetBlock(XQFOCCQ33700InBlock1 block)
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
			_xaQuery.SetFieldData(block.GetBlockName(), "BaseAmtTp", 0, block.BaseAmtTp.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "QryTermTp", 0, block.QryTermTp.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "PnlCalcTpCode", 0, block.PnlCalcTpCode.ToString()); // char 1

			return true;
		}

		public XQFOCCQ33700OutBlock1 GetBlock1()
		{
			XQFOCCQ33700OutBlock1 instance = XQFOCCQ33700OutBlock1.FromQuery(this);
			return instance;

		}

		public XQFOCCQ33700OutBlock2 GetBlock2()
		{
			XQFOCCQ33700OutBlock2 instance = XQFOCCQ33700OutBlock2.FromQuery(this);
			return instance;

		}

		public XQFOCCQ33700OutBlock3[] GetBlock3s()
		{
			XQFOCCQ33700OutBlock3[] instance = XQFOCCQ33700OutBlock3.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQFOCCQ33700OutBlock1),
			typeof(XQFOCCQ33700OutBlock2),
			typeof(XQFOCCQ33700OutBlock3),

		};

	}

}
