using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQFOCCQ33600InBlock1 : XingBlock
	{
		/// <summary>
		/// FOCCQ33600InBlock1
		/// </summary>
		public const string _blockName = "FOCCQ33600InBlock1";
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
		/// FOCCQ33600InBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// FOCCQ33600InBlock1
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
		/// 기간구분
		/// </summary>
		[XAQueryFieldAttribute("TermTp", "기간구분", "char", "1")]
		public char TermTp;

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
			/// 기간구분
			/// </summary>
			public const string TermTp = "TermTp";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.AcntNo,
			F.Pwd,
			F.QrySrtDt,
			F.QryEndDt,
			F.TermTp,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["AcntNo"] = new XAQueryFieldInfo("char", AcntNo, AcntNo, "계좌번호", (decimal)20);
			dict["Pwd"] = new XAQueryFieldInfo("char", Pwd, Pwd, "비밀번호", (decimal)8);
			dict["QrySrtDt"] = new XAQueryFieldInfo("char", QrySrtDt, QrySrtDt, "조회시작일", (decimal)8);
			dict["QryEndDt"] = new XAQueryFieldInfo("char", QryEndDt, QryEndDt, "조회종료일", (decimal)8);
			dict["TermTp"] = new XAQueryFieldInfo("char", TermTp, TermTp.ToString(), "기간구분", (decimal)1);

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

				case "TermTp":
					this.TermTp = fieldInfo.FieldValue.FirstOrDefault();
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
			// TermTp char 1

			return true;
		}
	}

	public partial class XQFOCCQ33600OutBlock1 : XingBlock
	{
		/// <summary>
		/// FOCCQ33600OutBlock1
		/// </summary>
		public const string _blockName = "FOCCQ33600OutBlock1";
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
		/// FOCCQ33600OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// FOCCQ33600OutBlock1
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
		/// 기간구분
		/// </summary>
		[XAQueryFieldAttribute("TermTp", "기간구분", "char", "1")]
		public char TermTp;

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
			/// 기간구분
			/// </summary>
			public const string TermTp = "TermTp";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.AcntNo,
			F.Pwd,
			F.QrySrtDt,
			F.QryEndDt,
			F.TermTp,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["AcntNo"] = new XAQueryFieldInfo("char", AcntNo, AcntNo, "계좌번호", (decimal)20);
			dict["Pwd"] = new XAQueryFieldInfo("char", Pwd, Pwd, "비밀번호", (decimal)8);
			dict["QrySrtDt"] = new XAQueryFieldInfo("char", QrySrtDt, QrySrtDt, "조회시작일", (decimal)8);
			dict["QryEndDt"] = new XAQueryFieldInfo("char", QryEndDt, QryEndDt, "조회종료일", (decimal)8);
			dict["TermTp"] = new XAQueryFieldInfo("char", TermTp, TermTp.ToString(), "기간구분", (decimal)1);

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

				case "TermTp":
					this.TermTp = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public static XQFOCCQ33600OutBlock1 FromQuery(XQFOCCQ33600 query)
		{
			XQFOCCQ33600OutBlock1 block = new XQFOCCQ33600OutBlock1();
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
				block.TermTp = query.GetFieldData(block.GetBlockName(), "TermTp", 0).FirstOrDefault(); // char 1

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
			// TermTp char 1

			return true;
		}
	}

	public partial class XQFOCCQ33600OutBlock2 : XingBlock
	{
		/// <summary>
		/// FOCCQ33600OutBlock2
		/// </summary>
		public const string _blockName = "FOCCQ33600OutBlock2";
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
		/// FOCCQ33600OutBlock2
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// FOCCQ33600OutBlock2
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
		/// 매매약정금액
		/// </summary>
		[XAQueryFieldAttribute("BnsctrAmt", "매매약정금액", "long", "16")]
		public long BnsctrAmt;
		/// <summary>
		/// 입금금액
		/// </summary>
		[XAQueryFieldAttribute("MnyinAmt", "입금금액", "long", "16")]
		public long MnyinAmt;
		/// <summary>
		/// 출금금액
		/// </summary>
		[XAQueryFieldAttribute("MnyoutAmt", "출금금액", "long", "16")]
		public long MnyoutAmt;
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
		/// 투자수익률
		/// </summary>
		[XAQueryFieldAttribute("InvstErnrat", "투자수익률", "double", "9.2")]
		public double InvstErnrat;

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
			/// 매매약정금액
			/// </summary>
			public const string BnsctrAmt = "BnsctrAmt";
			/// <summary>
			/// 입금금액
			/// </summary>
			public const string MnyinAmt = "MnyinAmt";
			/// <summary>
			/// 출금금액
			/// </summary>
			public const string MnyoutAmt = "MnyoutAmt";
			/// <summary>
			/// 투자원금평잔금액
			/// </summary>
			public const string InvstAvrbalPramt = "InvstAvrbalPramt";
			/// <summary>
			/// 투자손익금액
			/// </summary>
			public const string InvstPlAmt = "InvstPlAmt";
			/// <summary>
			/// 투자수익률
			/// </summary>
			public const string InvstErnrat = "InvstErnrat";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.AcntNm,
			F.BnsctrAmt,
			F.MnyinAmt,
			F.MnyoutAmt,
			F.InvstAvrbalPramt,
			F.InvstPlAmt,
			F.InvstErnrat,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["AcntNm"] = new XAQueryFieldInfo("char", AcntNm, AcntNm, "계좌명", (decimal)40);
			dict["BnsctrAmt"] = new XAQueryFieldInfo("long", BnsctrAmt, BnsctrAmt.ToString("d16"), "매매약정금액", (decimal)16);
			dict["MnyinAmt"] = new XAQueryFieldInfo("long", MnyinAmt, MnyinAmt.ToString("d16"), "입금금액", (decimal)16);
			dict["MnyoutAmt"] = new XAQueryFieldInfo("long", MnyoutAmt, MnyoutAmt.ToString("d16"), "출금금액", (decimal)16);
			dict["InvstAvrbalPramt"] = new XAQueryFieldInfo("long", InvstAvrbalPramt, InvstAvrbalPramt.ToString("d16"), "투자원금평잔금액", (decimal)16);
			dict["InvstPlAmt"] = new XAQueryFieldInfo("long", InvstPlAmt, InvstPlAmt.ToString("d16"), "투자손익금액", (decimal)16);
			dict["InvstErnrat"] = new XAQueryFieldInfo("double", InvstErnrat, InvstErnrat.ToString("000000000.00"), "투자수익률", (decimal)9.2);

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

				case "BnsctrAmt":
					this.BnsctrAmt = fieldInfo.FieldValue.ParseLong("BnsctrAmt");
				break;

				case "MnyinAmt":
					this.MnyinAmt = fieldInfo.FieldValue.ParseLong("MnyinAmt");
				break;

				case "MnyoutAmt":
					this.MnyoutAmt = fieldInfo.FieldValue.ParseLong("MnyoutAmt");
				break;

				case "InvstAvrbalPramt":
					this.InvstAvrbalPramt = fieldInfo.FieldValue.ParseLong("InvstAvrbalPramt");
				break;

				case "InvstPlAmt":
					this.InvstPlAmt = fieldInfo.FieldValue.ParseLong("InvstPlAmt");
				break;

				case "InvstErnrat":
					this.InvstErnrat = fieldInfo.FieldValue.ParseDouble("InvstErnrat");
				break;


			}
		}

		public static XQFOCCQ33600OutBlock2 FromQuery(XQFOCCQ33600 query)
		{
			XQFOCCQ33600OutBlock2 block = new XQFOCCQ33600OutBlock2();
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
				block.BnsctrAmt = query.GetFieldData(block.GetBlockName(), "BnsctrAmt", 0).ParseLong("BnsctrAmt"); // long 16
				block.MnyinAmt = query.GetFieldData(block.GetBlockName(), "MnyinAmt", 0).ParseLong("MnyinAmt"); // long 16
				block.MnyoutAmt = query.GetFieldData(block.GetBlockName(), "MnyoutAmt", 0).ParseLong("MnyoutAmt"); // long 16
				block.InvstAvrbalPramt = query.GetFieldData(block.GetBlockName(), "InvstAvrbalPramt", 0).ParseLong("InvstAvrbalPramt"); // long 16
				block.InvstPlAmt = query.GetFieldData(block.GetBlockName(), "InvstPlAmt", 0).ParseLong("InvstPlAmt"); // long 16
				block.InvstErnrat = query.GetFieldData(block.GetBlockName(), "InvstErnrat", 0).ParseDouble("InvstErnrat"); // double 9.2

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
			if (BnsctrAmt.ToString().Length > 16) return false; // long 16
			if (MnyinAmt.ToString().Length > 16) return false; // long 16
			if (MnyoutAmt.ToString().Length > 16) return false; // long 16
			if (InvstAvrbalPramt.ToString().Length > 16) return false; // long 16
			if (InvstPlAmt.ToString().Length > 16) return false; // long 16
			// InvstErnrat double 9.2

			return true;
		}
	}

	public partial class XQFOCCQ33600OutBlock3 : XingBlock
	{
		/// <summary>
		/// FOCCQ33600OutBlock3
		/// </summary>
		public const string _blockName = "FOCCQ33600OutBlock3";
		/// <summary>
		/// OutLst(*EMPTY*)
		/// </summary>
		public const string _blockDesc = "OutLst(*EMPTY*)";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// true
		/// </summary>
		public const bool _hasOccurs = true;
		/// <summary>
		/// FOCCQ33600OutBlock3
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// FOCCQ33600OutBlock3
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// OutLst(*EMPTY*)
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
		/// 기준일
		/// </summary>
		[XAQueryFieldAttribute("BaseDt", "기준일", "char", "8")]
		public string BaseDt;
		/// <summary>
		/// 기초평가금액
		/// </summary>
		[XAQueryFieldAttribute("FdEvalAmt", "기초평가금액", "long", "19")]
		public long FdEvalAmt;
		/// <summary>
		/// 기말평가금액
		/// </summary>
		[XAQueryFieldAttribute("EotEvalAmt", "기말평가금액", "long", "19")]
		public long EotEvalAmt;
		/// <summary>
		/// 투자원금평잔금액
		/// </summary>
		[XAQueryFieldAttribute("InvstAvrbalPramt", "투자원금평잔금액", "long", "16")]
		public long InvstAvrbalPramt;
		/// <summary>
		/// 매매약정금액
		/// </summary>
		[XAQueryFieldAttribute("BnsctrAmt", "매매약정금액", "long", "16")]
		public long BnsctrAmt;
		/// <summary>
		/// 입금고액
		/// </summary>
		[XAQueryFieldAttribute("MnyinSecinAmt", "입금고액", "long", "16")]
		public long MnyinSecinAmt;
		/// <summary>
		/// 출금고액
		/// </summary>
		[XAQueryFieldAttribute("MnyoutSecoutAmt", "출금고액", "long", "16")]
		public long MnyoutSecoutAmt;
		/// <summary>
		/// 평가손익금액
		/// </summary>
		[XAQueryFieldAttribute("EvalPnlAmt", "평가손익금액", "long", "16")]
		public long EvalPnlAmt;
		/// <summary>
		/// 기간수익률
		/// </summary>
		[XAQueryFieldAttribute("TermErnrat", "기간수익률", "double", "11.3")]
		public double TermErnrat;
		/// <summary>
		/// 지수
		/// </summary>
		[XAQueryFieldAttribute("Idx", "지수", "double", "13.2")]
		public double Idx;

		public static class F
		{
			/// <summary>
			/// 기준일
			/// </summary>
			public const string BaseDt = "BaseDt";
			/// <summary>
			/// 기초평가금액
			/// </summary>
			public const string FdEvalAmt = "FdEvalAmt";
			/// <summary>
			/// 기말평가금액
			/// </summary>
			public const string EotEvalAmt = "EotEvalAmt";
			/// <summary>
			/// 투자원금평잔금액
			/// </summary>
			public const string InvstAvrbalPramt = "InvstAvrbalPramt";
			/// <summary>
			/// 매매약정금액
			/// </summary>
			public const string BnsctrAmt = "BnsctrAmt";
			/// <summary>
			/// 입금고액
			/// </summary>
			public const string MnyinSecinAmt = "MnyinSecinAmt";
			/// <summary>
			/// 출금고액
			/// </summary>
			public const string MnyoutSecoutAmt = "MnyoutSecoutAmt";
			/// <summary>
			/// 평가손익금액
			/// </summary>
			public const string EvalPnlAmt = "EvalPnlAmt";
			/// <summary>
			/// 기간수익률
			/// </summary>
			public const string TermErnrat = "TermErnrat";
			/// <summary>
			/// 지수
			/// </summary>
			public const string Idx = "Idx";
		}

		public static string[] AllFields = new string[]
		{
			F.BaseDt,
			F.FdEvalAmt,
			F.EotEvalAmt,
			F.InvstAvrbalPramt,
			F.BnsctrAmt,
			F.MnyinSecinAmt,
			F.MnyoutSecoutAmt,
			F.EvalPnlAmt,
			F.TermErnrat,
			F.Idx,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["BaseDt"] = new XAQueryFieldInfo("char", BaseDt, BaseDt, "기준일", (decimal)8);
			dict["FdEvalAmt"] = new XAQueryFieldInfo("long", FdEvalAmt, FdEvalAmt.ToString("d19"), "기초평가금액", (decimal)19);
			dict["EotEvalAmt"] = new XAQueryFieldInfo("long", EotEvalAmt, EotEvalAmt.ToString("d19"), "기말평가금액", (decimal)19);
			dict["InvstAvrbalPramt"] = new XAQueryFieldInfo("long", InvstAvrbalPramt, InvstAvrbalPramt.ToString("d16"), "투자원금평잔금액", (decimal)16);
			dict["BnsctrAmt"] = new XAQueryFieldInfo("long", BnsctrAmt, BnsctrAmt.ToString("d16"), "매매약정금액", (decimal)16);
			dict["MnyinSecinAmt"] = new XAQueryFieldInfo("long", MnyinSecinAmt, MnyinSecinAmt.ToString("d16"), "입금고액", (decimal)16);
			dict["MnyoutSecoutAmt"] = new XAQueryFieldInfo("long", MnyoutSecoutAmt, MnyoutSecoutAmt.ToString("d16"), "출금고액", (decimal)16);
			dict["EvalPnlAmt"] = new XAQueryFieldInfo("long", EvalPnlAmt, EvalPnlAmt.ToString("d16"), "평가손익금액", (decimal)16);
			dict["TermErnrat"] = new XAQueryFieldInfo("double", TermErnrat, TermErnrat.ToString("00000000000.000"), "기간수익률", (decimal)11.3);
			dict["Idx"] = new XAQueryFieldInfo("double", Idx, Idx.ToString("0000000000000.00"), "지수", (decimal)13.2);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "BaseDt":
					this.BaseDt = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "FdEvalAmt":
					this.FdEvalAmt = fieldInfo.FieldValue.ParseLong("FdEvalAmt");
				break;

				case "EotEvalAmt":
					this.EotEvalAmt = fieldInfo.FieldValue.ParseLong("EotEvalAmt");
				break;

				case "InvstAvrbalPramt":
					this.InvstAvrbalPramt = fieldInfo.FieldValue.ParseLong("InvstAvrbalPramt");
				break;

				case "BnsctrAmt":
					this.BnsctrAmt = fieldInfo.FieldValue.ParseLong("BnsctrAmt");
				break;

				case "MnyinSecinAmt":
					this.MnyinSecinAmt = fieldInfo.FieldValue.ParseLong("MnyinSecinAmt");
				break;

				case "MnyoutSecoutAmt":
					this.MnyoutSecoutAmt = fieldInfo.FieldValue.ParseLong("MnyoutSecoutAmt");
				break;

				case "EvalPnlAmt":
					this.EvalPnlAmt = fieldInfo.FieldValue.ParseLong("EvalPnlAmt");
				break;

				case "TermErnrat":
					this.TermErnrat = fieldInfo.FieldValue.ParseDouble("TermErnrat");
				break;

				case "Idx":
					this.Idx = fieldInfo.FieldValue.ParseDouble("Idx");
				break;


			}
		}

		public static XQFOCCQ33600OutBlock3[] ListFromQuery(XQFOCCQ33600 query)
		{
			int count = query.GetBlockCount(XQFOCCQ33600OutBlock3.BlockName);
			List<XQFOCCQ33600OutBlock3> list = new List<XQFOCCQ33600OutBlock3>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQFOCCQ33600OutBlock3 block = new XQFOCCQ33600OutBlock3();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.BaseDt = query.GetFieldData(block.GetBlockName(), "BaseDt", i).TrimEnd('?'); // char 8
					block.FdEvalAmt = query.GetFieldData(block.GetBlockName(), "FdEvalAmt", i).ParseLong("FdEvalAmt"); // long 19
					block.EotEvalAmt = query.GetFieldData(block.GetBlockName(), "EotEvalAmt", i).ParseLong("EotEvalAmt"); // long 19
					block.InvstAvrbalPramt = query.GetFieldData(block.GetBlockName(), "InvstAvrbalPramt", i).ParseLong("InvstAvrbalPramt"); // long 16
					block.BnsctrAmt = query.GetFieldData(block.GetBlockName(), "BnsctrAmt", i).ParseLong("BnsctrAmt"); // long 16
					block.MnyinSecinAmt = query.GetFieldData(block.GetBlockName(), "MnyinSecinAmt", i).ParseLong("MnyinSecinAmt"); // long 16
					block.MnyoutSecoutAmt = query.GetFieldData(block.GetBlockName(), "MnyoutSecoutAmt", i).ParseLong("MnyoutSecoutAmt"); // long 16
					block.EvalPnlAmt = query.GetFieldData(block.GetBlockName(), "EvalPnlAmt", i).ParseLong("EvalPnlAmt"); // long 16
					block.TermErnrat = query.GetFieldData(block.GetBlockName(), "TermErnrat", i).ParseDouble("TermErnrat"); // double 11.3
					block.Idx = query.GetFieldData(block.GetBlockName(), "Idx", i).ParseDouble("Idx"); // double 13.2

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
			if (BaseDt?.Length > 8) return false; // char 8
			if (FdEvalAmt.ToString().Length > 19) return false; // long 19
			if (EotEvalAmt.ToString().Length > 19) return false; // long 19
			if (InvstAvrbalPramt.ToString().Length > 16) return false; // long 16
			if (BnsctrAmt.ToString().Length > 16) return false; // long 16
			if (MnyinSecinAmt.ToString().Length > 16) return false; // long 16
			if (MnyoutSecoutAmt.ToString().Length > 16) return false; // long 16
			if (EvalPnlAmt.ToString().Length > 16) return false; // long 16
			// TermErnrat double 11.3
			// Idx double 13.2

			return true;
		}
	}

	/// <summary>
	/// 주식계좌 기간별수익률 상세
	/// </summary>
	public partial class XQFOCCQ33600 : XingQuery
	{
		/// <summary>
		/// FOCCQ33600
		/// </summary>
		public const string _typeName = "FOCCQ33600";
		/// <summary>
		/// 주식계좌 기간별수익률 상세
		/// </summary>
		public const string _typeDesc = "주식계좌 기간별수익률 상세";
		/// <summary>
		/// FOCCQ33600
		/// </summary>
		public const string _service = "FOCCQ33600";
		/// <summary>
		/// B
		/// </summary>
		public const string _headType = "B";
		/// <summary>
		/// 유종우
		/// </summary>
		public const string _creator = "유종우";
		/// <summary>
		/// 2012/03/15 11:06:33
		/// </summary>
		public const string _createdDate = "2012/03/15 11:06:33";
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
		/// FOCCQ33600
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 주식계좌 기간별수익률 상세
		/// </summary>
		public string TypeDesc => _typeDesc;
		/// <summary>
		/// FOCCQ33600
		/// </summary>
		public string Service => _service;
		/// <summary>
		/// B
		/// </summary>
		public string HeadType => _headType;
		/// <summary>
		/// 유종우
		/// </summary>
		public string Creator => _creator;
		/// <summary>
		/// 2012/03/15 11:06:33
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
		/// 주식계좌 기간별수익률 상세
		/// </summary>
		public XQFOCCQ33600() : base("FOCCQ33600") { }



		public bool SetBlock(XQFOCCQ33600InBlock1 block)
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
			_xaQuery.SetFieldData(block.GetBlockName(), "TermTp", 0, block.TermTp.ToString()); // char 1

			return true;
		}

		public XQFOCCQ33600OutBlock1 GetBlock1()
		{
			XQFOCCQ33600OutBlock1 instance = XQFOCCQ33600OutBlock1.FromQuery(this);
			return instance;

		}

		public XQFOCCQ33600OutBlock2 GetBlock2()
		{
			XQFOCCQ33600OutBlock2 instance = XQFOCCQ33600OutBlock2.FromQuery(this);
			return instance;

		}

		public XQFOCCQ33600OutBlock3[] GetBlock3s()
		{
			XQFOCCQ33600OutBlock3[] instance = XQFOCCQ33600OutBlock3.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQFOCCQ33600OutBlock1),
			typeof(XQFOCCQ33600OutBlock2),
			typeof(XQFOCCQ33600OutBlock3),

		};

	}

}
