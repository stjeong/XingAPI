using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQCCEAQ50600InBlock1 : XingBlock
	{
		/// <summary>
		/// CCEAQ50600InBlock1
		/// </summary>
		public const string _blockName = "CCEAQ50600InBlock1";
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
		/// CCEAQ50600InBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CCEAQ50600InBlock1
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
		/// 잔고평가구분
		/// </summary>
		[XAQueryFieldAttribute("BalEvalTp", "잔고평가구분", "char", "1")]
		public char BalEvalTp;
		/// <summary>
		/// 선물가격평가구분
		/// </summary>
		[XAQueryFieldAttribute("FutsPrcEvalTp", "선물가격평가구분", "char", "1")]
		public char FutsPrcEvalTp;

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
			/// 잔고평가구분
			/// </summary>
			public const string BalEvalTp = "BalEvalTp";
			/// <summary>
			/// 선물가격평가구분
			/// </summary>
			public const string FutsPrcEvalTp = "FutsPrcEvalTp";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.AcntNo,
			F.InptPwd,
			F.BalEvalTp,
			F.FutsPrcEvalTp,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["AcntNo"] = new XAQueryFieldInfo("char", AcntNo, AcntNo, "계좌번호", (decimal)20);
			dict["InptPwd"] = new XAQueryFieldInfo("char", InptPwd, InptPwd, "입력비밀번호", (decimal)8);
			dict["BalEvalTp"] = new XAQueryFieldInfo("char", BalEvalTp, BalEvalTp.ToString(), "잔고평가구분", (decimal)1);
			dict["FutsPrcEvalTp"] = new XAQueryFieldInfo("char", FutsPrcEvalTp, FutsPrcEvalTp.ToString(), "선물가격평가구분", (decimal)1);

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

				case "BalEvalTp":
					this.BalEvalTp = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "FutsPrcEvalTp":
					this.FutsPrcEvalTp = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public bool VerifyData()
		{
			if (RecCnt.ToString().Length > 5) return false; // long 5
			if (AcntNo?.Length > 20) return false; // char 20
			if (InptPwd?.Length > 8) return false; // char 8
			// BalEvalTp char 1
			// FutsPrcEvalTp char 1

			return true;
		}

		public void CopyTo(XQCCEAQ50600InBlock1 block)
		{
			block.RecCnt = this.RecCnt;
			block.AcntNo = this.AcntNo;
			block.InptPwd = this.InptPwd;
			block.BalEvalTp = this.BalEvalTp;
			block.FutsPrcEvalTp = this.FutsPrcEvalTp;

		}
	}

	public partial class XQCCEAQ50600OutBlock1 : XingBlock
	{
		/// <summary>
		/// CCEAQ50600OutBlock1
		/// </summary>
		public const string _blockName = "CCEAQ50600OutBlock1";
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
		/// CCEAQ50600OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CCEAQ50600OutBlock1
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
		/// 잔고평가구분
		/// </summary>
		[XAQueryFieldAttribute("BalEvalTp", "잔고평가구분", "char", "1")]
		public char BalEvalTp;
		/// <summary>
		/// 선물가격평가구분
		/// </summary>
		[XAQueryFieldAttribute("FutsPrcEvalTp", "선물가격평가구분", "char", "1")]
		public char FutsPrcEvalTp;

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
			/// 잔고평가구분
			/// </summary>
			public const string BalEvalTp = "BalEvalTp";
			/// <summary>
			/// 선물가격평가구분
			/// </summary>
			public const string FutsPrcEvalTp = "FutsPrcEvalTp";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.AcntNo,
			F.InptPwd,
			F.BalEvalTp,
			F.FutsPrcEvalTp,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["AcntNo"] = new XAQueryFieldInfo("char", AcntNo, AcntNo, "계좌번호", (decimal)20);
			dict["InptPwd"] = new XAQueryFieldInfo("char", InptPwd, InptPwd, "입력비밀번호", (decimal)8);
			dict["BalEvalTp"] = new XAQueryFieldInfo("char", BalEvalTp, BalEvalTp.ToString(), "잔고평가구분", (decimal)1);
			dict["FutsPrcEvalTp"] = new XAQueryFieldInfo("char", FutsPrcEvalTp, FutsPrcEvalTp.ToString(), "선물가격평가구분", (decimal)1);

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

				case "BalEvalTp":
					this.BalEvalTp = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "FutsPrcEvalTp":
					this.FutsPrcEvalTp = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public static XQCCEAQ50600OutBlock1 FromQuery(XQCCEAQ50600 query)
		{
			XQCCEAQ50600OutBlock1 block = new XQCCEAQ50600OutBlock1();
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
				block.BalEvalTp = query.GetFieldData(block.GetBlockName(), "BalEvalTp", 0).FirstOrDefault(); // char 1
				block.FutsPrcEvalTp = query.GetFieldData(block.GetBlockName(), "FutsPrcEvalTp", 0).FirstOrDefault(); // char 1

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
			// BalEvalTp char 1
			// FutsPrcEvalTp char 1

			return true;
		}

		public void CopyTo(XQCCEAQ50600OutBlock1 block)
		{
			block.RecCnt = this.RecCnt;
			block.AcntNo = this.AcntNo;
			block.InptPwd = this.InptPwd;
			block.BalEvalTp = this.BalEvalTp;
			block.FutsPrcEvalTp = this.FutsPrcEvalTp;

		}
	}

	public partial class XQCCEAQ50600OutBlock2 : XingBlock
	{
		/// <summary>
		/// CCEAQ50600OutBlock2
		/// </summary>
		public const string _blockName = "CCEAQ50600OutBlock2";
		/// <summary>
		/// Out1(*EMPTY*)
		/// </summary>
		public const string _blockDesc = "Out1(*EMPTY*)";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// false
		/// </summary>
		public const bool _hasOccurs = false;
		/// <summary>
		/// CCEAQ50600OutBlock2
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CCEAQ50600OutBlock2
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
		/// 계좌명
		/// </summary>
		[XAQueryFieldAttribute("AcntNm", "계좌명", "char", "40")]
		public string AcntNm;
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
		/// 예탁금총액
		/// </summary>
		[XAQueryFieldAttribute("DpsamtTotamt", "예탁금총액", "long", "16")]
		public long DpsamtTotamt;
		/// <summary>
		/// 예탁현금
		/// </summary>
		[XAQueryFieldAttribute("DpstgMny", "예탁현금", "long", "16")]
		public long DpstgMny;
		/// <summary>
		/// 인출가능총금액
		/// </summary>
		[XAQueryFieldAttribute("PsnOutAbleTotAmt", "인출가능총금액", "long", "15")]
		public long PsnOutAbleTotAmt;
		/// <summary>
		/// 인출가능현금액
		/// </summary>
		[XAQueryFieldAttribute("PsnOutAbleCurAmt", "인출가능현금액", "long", "16")]
		public long PsnOutAbleCurAmt;
		/// <summary>
		/// 주문가능총금액
		/// </summary>
		[XAQueryFieldAttribute("OrdAbleTotAmt", "주문가능총금액", "long", "15")]
		public long OrdAbleTotAmt;
		/// <summary>
		/// 현금주문가능금액
		/// </summary>
		[XAQueryFieldAttribute("MnyOrdAbleAmt", "현금주문가능금액", "long", "16")]
		public long MnyOrdAbleAmt;
		/// <summary>
		/// 위탁증거금총액
		/// </summary>
		[XAQueryFieldAttribute("CsgnMgnTotamt", "위탁증거금총액", "long", "16")]
		public long CsgnMgnTotamt;
		/// <summary>
		/// 현금위탁증거금액
		/// </summary>
		[XAQueryFieldAttribute("MnyCsgnMgn", "현금위탁증거금액", "long", "16")]
		public long MnyCsgnMgn;
		/// <summary>
		/// 추가증거금총액
		/// </summary>
		[XAQueryFieldAttribute("AddMgnTotamt", "추가증거금총액", "long", "15")]
		public long AddMgnTotamt;
		/// <summary>
		/// 현금추가증거금액
		/// </summary>
		[XAQueryFieldAttribute("MnyAddMgn", "현금추가증거금액", "long", "16")]
		public long MnyAddMgn;
		/// <summary>
		/// 수수료
		/// </summary>
		[XAQueryFieldAttribute("CmsnAmt", "수수료", "long", "16")]
		public long CmsnAmt;
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
		/// 옵션평가금액
		/// </summary>
		[XAQueryFieldAttribute("OptEvalAmt", "옵션평가금액", "long", "16")]
		public long OptEvalAmt;
		/// <summary>
		/// 옵션매매손익금액
		/// </summary>
		[XAQueryFieldAttribute("OptBnsplAmt", "옵션매매손익금액", "long", "16")]
		public long OptBnsplAmt;
		/// <summary>
		/// 선물정산차금
		/// </summary>
		[XAQueryFieldAttribute("FutsAdjstDfamt", "선물정산차금", "long", "16")]
		public long FutsAdjstDfamt;
		/// <summary>
		/// 총손익금액
		/// </summary>
		[XAQueryFieldAttribute("TotPnlAmt", "총손익금액", "long", "16")]
		public long TotPnlAmt;
		/// <summary>
		/// 순손익금액
		/// </summary>
		[XAQueryFieldAttribute("NetPnlAmt", "순손익금액", "long", "16")]
		public long NetPnlAmt;
		/// <summary>
		/// 총평가금액
		/// </summary>
		[XAQueryFieldAttribute("TotEvalAmt", "총평가금액", "long", "16")]
		public long TotEvalAmt;
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
			/// 계좌명
			/// </summary>
			public const string AcntNm = "AcntNm";
			/// <summary>
			/// 평가예탁금총액
			/// </summary>
			public const string EvalDpsamtTotamt = "EvalDpsamtTotamt";
			/// <summary>
			/// 현금평가예탁금액
			/// </summary>
			public const string MnyEvalDpstgAmt = "MnyEvalDpstgAmt";
			/// <summary>
			/// 예탁금총액
			/// </summary>
			public const string DpsamtTotamt = "DpsamtTotamt";
			/// <summary>
			/// 예탁현금
			/// </summary>
			public const string DpstgMny = "DpstgMny";
			/// <summary>
			/// 인출가능총금액
			/// </summary>
			public const string PsnOutAbleTotAmt = "PsnOutAbleTotAmt";
			/// <summary>
			/// 인출가능현금액
			/// </summary>
			public const string PsnOutAbleCurAmt = "PsnOutAbleCurAmt";
			/// <summary>
			/// 주문가능총금액
			/// </summary>
			public const string OrdAbleTotAmt = "OrdAbleTotAmt";
			/// <summary>
			/// 현금주문가능금액
			/// </summary>
			public const string MnyOrdAbleAmt = "MnyOrdAbleAmt";
			/// <summary>
			/// 위탁증거금총액
			/// </summary>
			public const string CsgnMgnTotamt = "CsgnMgnTotamt";
			/// <summary>
			/// 현금위탁증거금액
			/// </summary>
			public const string MnyCsgnMgn = "MnyCsgnMgn";
			/// <summary>
			/// 추가증거금총액
			/// </summary>
			public const string AddMgnTotamt = "AddMgnTotamt";
			/// <summary>
			/// 현금추가증거금액
			/// </summary>
			public const string MnyAddMgn = "MnyAddMgn";
			/// <summary>
			/// 수수료
			/// </summary>
			public const string CmsnAmt = "CmsnAmt";
			/// <summary>
			/// 선물평가손익금액
			/// </summary>
			public const string FutsEvalPnlAmt = "FutsEvalPnlAmt";
			/// <summary>
			/// 옵션평가손익금액
			/// </summary>
			public const string OptEvalPnlAmt = "OptEvalPnlAmt";
			/// <summary>
			/// 옵션평가금액
			/// </summary>
			public const string OptEvalAmt = "OptEvalAmt";
			/// <summary>
			/// 옵션매매손익금액
			/// </summary>
			public const string OptBnsplAmt = "OptBnsplAmt";
			/// <summary>
			/// 선물정산차금
			/// </summary>
			public const string FutsAdjstDfamt = "FutsAdjstDfamt";
			/// <summary>
			/// 총손익금액
			/// </summary>
			public const string TotPnlAmt = "TotPnlAmt";
			/// <summary>
			/// 순손익금액
			/// </summary>
			public const string NetPnlAmt = "NetPnlAmt";
			/// <summary>
			/// 총평가금액
			/// </summary>
			public const string TotEvalAmt = "TotEvalAmt";
			/// <summary>
			/// 입금금액
			/// </summary>
			public const string MnyinAmt = "MnyinAmt";
			/// <summary>
			/// 출금금액
			/// </summary>
			public const string MnyoutAmt = "MnyoutAmt";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.AcntNo,
			F.AcntNm,
			F.EvalDpsamtTotamt,
			F.MnyEvalDpstgAmt,
			F.DpsamtTotamt,
			F.DpstgMny,
			F.PsnOutAbleTotAmt,
			F.PsnOutAbleCurAmt,
			F.OrdAbleTotAmt,
			F.MnyOrdAbleAmt,
			F.CsgnMgnTotamt,
			F.MnyCsgnMgn,
			F.AddMgnTotamt,
			F.MnyAddMgn,
			F.CmsnAmt,
			F.FutsEvalPnlAmt,
			F.OptEvalPnlAmt,
			F.OptEvalAmt,
			F.OptBnsplAmt,
			F.FutsAdjstDfamt,
			F.TotPnlAmt,
			F.NetPnlAmt,
			F.TotEvalAmt,
			F.MnyinAmt,
			F.MnyoutAmt,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["AcntNo"] = new XAQueryFieldInfo("char", AcntNo, AcntNo, "계좌번호", (decimal)20);
			dict["AcntNm"] = new XAQueryFieldInfo("char", AcntNm, AcntNm, "계좌명", (decimal)40);
			dict["EvalDpsamtTotamt"] = new XAQueryFieldInfo("long", EvalDpsamtTotamt, EvalDpsamtTotamt.ToString("d15"), "평가예탁금총액", (decimal)15);
			dict["MnyEvalDpstgAmt"] = new XAQueryFieldInfo("long", MnyEvalDpstgAmt, MnyEvalDpstgAmt.ToString("d15"), "현금평가예탁금액", (decimal)15);
			dict["DpsamtTotamt"] = new XAQueryFieldInfo("long", DpsamtTotamt, DpsamtTotamt.ToString("d16"), "예탁금총액", (decimal)16);
			dict["DpstgMny"] = new XAQueryFieldInfo("long", DpstgMny, DpstgMny.ToString("d16"), "예탁현금", (decimal)16);
			dict["PsnOutAbleTotAmt"] = new XAQueryFieldInfo("long", PsnOutAbleTotAmt, PsnOutAbleTotAmt.ToString("d15"), "인출가능총금액", (decimal)15);
			dict["PsnOutAbleCurAmt"] = new XAQueryFieldInfo("long", PsnOutAbleCurAmt, PsnOutAbleCurAmt.ToString("d16"), "인출가능현금액", (decimal)16);
			dict["OrdAbleTotAmt"] = new XAQueryFieldInfo("long", OrdAbleTotAmt, OrdAbleTotAmt.ToString("d15"), "주문가능총금액", (decimal)15);
			dict["MnyOrdAbleAmt"] = new XAQueryFieldInfo("long", MnyOrdAbleAmt, MnyOrdAbleAmt.ToString("d16"), "현금주문가능금액", (decimal)16);
			dict["CsgnMgnTotamt"] = new XAQueryFieldInfo("long", CsgnMgnTotamt, CsgnMgnTotamt.ToString("d16"), "위탁증거금총액", (decimal)16);
			dict["MnyCsgnMgn"] = new XAQueryFieldInfo("long", MnyCsgnMgn, MnyCsgnMgn.ToString("d16"), "현금위탁증거금액", (decimal)16);
			dict["AddMgnTotamt"] = new XAQueryFieldInfo("long", AddMgnTotamt, AddMgnTotamt.ToString("d15"), "추가증거금총액", (decimal)15);
			dict["MnyAddMgn"] = new XAQueryFieldInfo("long", MnyAddMgn, MnyAddMgn.ToString("d16"), "현금추가증거금액", (decimal)16);
			dict["CmsnAmt"] = new XAQueryFieldInfo("long", CmsnAmt, CmsnAmt.ToString("d16"), "수수료", (decimal)16);
			dict["FutsEvalPnlAmt"] = new XAQueryFieldInfo("long", FutsEvalPnlAmt, FutsEvalPnlAmt.ToString("d16"), "선물평가손익금액", (decimal)16);
			dict["OptEvalPnlAmt"] = new XAQueryFieldInfo("long", OptEvalPnlAmt, OptEvalPnlAmt.ToString("d16"), "옵션평가손익금액", (decimal)16);
			dict["OptEvalAmt"] = new XAQueryFieldInfo("long", OptEvalAmt, OptEvalAmt.ToString("d16"), "옵션평가금액", (decimal)16);
			dict["OptBnsplAmt"] = new XAQueryFieldInfo("long", OptBnsplAmt, OptBnsplAmt.ToString("d16"), "옵션매매손익금액", (decimal)16);
			dict["FutsAdjstDfamt"] = new XAQueryFieldInfo("long", FutsAdjstDfamt, FutsAdjstDfamt.ToString("d16"), "선물정산차금", (decimal)16);
			dict["TotPnlAmt"] = new XAQueryFieldInfo("long", TotPnlAmt, TotPnlAmt.ToString("d16"), "총손익금액", (decimal)16);
			dict["NetPnlAmt"] = new XAQueryFieldInfo("long", NetPnlAmt, NetPnlAmt.ToString("d16"), "순손익금액", (decimal)16);
			dict["TotEvalAmt"] = new XAQueryFieldInfo("long", TotEvalAmt, TotEvalAmt.ToString("d16"), "총평가금액", (decimal)16);
			dict["MnyinAmt"] = new XAQueryFieldInfo("long", MnyinAmt, MnyinAmt.ToString("d16"), "입금금액", (decimal)16);
			dict["MnyoutAmt"] = new XAQueryFieldInfo("long", MnyoutAmt, MnyoutAmt.ToString("d16"), "출금금액", (decimal)16);

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

				case "AcntNm":
					this.AcntNm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "EvalDpsamtTotamt":
					this.EvalDpsamtTotamt = fieldInfo.FieldValue.ParseLong("EvalDpsamtTotamt");
				break;

				case "MnyEvalDpstgAmt":
					this.MnyEvalDpstgAmt = fieldInfo.FieldValue.ParseLong("MnyEvalDpstgAmt");
				break;

				case "DpsamtTotamt":
					this.DpsamtTotamt = fieldInfo.FieldValue.ParseLong("DpsamtTotamt");
				break;

				case "DpstgMny":
					this.DpstgMny = fieldInfo.FieldValue.ParseLong("DpstgMny");
				break;

				case "PsnOutAbleTotAmt":
					this.PsnOutAbleTotAmt = fieldInfo.FieldValue.ParseLong("PsnOutAbleTotAmt");
				break;

				case "PsnOutAbleCurAmt":
					this.PsnOutAbleCurAmt = fieldInfo.FieldValue.ParseLong("PsnOutAbleCurAmt");
				break;

				case "OrdAbleTotAmt":
					this.OrdAbleTotAmt = fieldInfo.FieldValue.ParseLong("OrdAbleTotAmt");
				break;

				case "MnyOrdAbleAmt":
					this.MnyOrdAbleAmt = fieldInfo.FieldValue.ParseLong("MnyOrdAbleAmt");
				break;

				case "CsgnMgnTotamt":
					this.CsgnMgnTotamt = fieldInfo.FieldValue.ParseLong("CsgnMgnTotamt");
				break;

				case "MnyCsgnMgn":
					this.MnyCsgnMgn = fieldInfo.FieldValue.ParseLong("MnyCsgnMgn");
				break;

				case "AddMgnTotamt":
					this.AddMgnTotamt = fieldInfo.FieldValue.ParseLong("AddMgnTotamt");
				break;

				case "MnyAddMgn":
					this.MnyAddMgn = fieldInfo.FieldValue.ParseLong("MnyAddMgn");
				break;

				case "CmsnAmt":
					this.CmsnAmt = fieldInfo.FieldValue.ParseLong("CmsnAmt");
				break;

				case "FutsEvalPnlAmt":
					this.FutsEvalPnlAmt = fieldInfo.FieldValue.ParseLong("FutsEvalPnlAmt");
				break;

				case "OptEvalPnlAmt":
					this.OptEvalPnlAmt = fieldInfo.FieldValue.ParseLong("OptEvalPnlAmt");
				break;

				case "OptEvalAmt":
					this.OptEvalAmt = fieldInfo.FieldValue.ParseLong("OptEvalAmt");
				break;

				case "OptBnsplAmt":
					this.OptBnsplAmt = fieldInfo.FieldValue.ParseLong("OptBnsplAmt");
				break;

				case "FutsAdjstDfamt":
					this.FutsAdjstDfamt = fieldInfo.FieldValue.ParseLong("FutsAdjstDfamt");
				break;

				case "TotPnlAmt":
					this.TotPnlAmt = fieldInfo.FieldValue.ParseLong("TotPnlAmt");
				break;

				case "NetPnlAmt":
					this.NetPnlAmt = fieldInfo.FieldValue.ParseLong("NetPnlAmt");
				break;

				case "TotEvalAmt":
					this.TotEvalAmt = fieldInfo.FieldValue.ParseLong("TotEvalAmt");
				break;

				case "MnyinAmt":
					this.MnyinAmt = fieldInfo.FieldValue.ParseLong("MnyinAmt");
				break;

				case "MnyoutAmt":
					this.MnyoutAmt = fieldInfo.FieldValue.ParseLong("MnyoutAmt");
				break;


			}
		}

		public static XQCCEAQ50600OutBlock2 FromQuery(XQCCEAQ50600 query)
		{
			XQCCEAQ50600OutBlock2 block = new XQCCEAQ50600OutBlock2();
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
				block.AcntNm = query.GetFieldData(block.GetBlockName(), "AcntNm", 0).TrimEnd('?'); // char 40
				block.EvalDpsamtTotamt = query.GetFieldData(block.GetBlockName(), "EvalDpsamtTotamt", 0).ParseLong("EvalDpsamtTotamt"); // long 15
				block.MnyEvalDpstgAmt = query.GetFieldData(block.GetBlockName(), "MnyEvalDpstgAmt", 0).ParseLong("MnyEvalDpstgAmt"); // long 15
				block.DpsamtTotamt = query.GetFieldData(block.GetBlockName(), "DpsamtTotamt", 0).ParseLong("DpsamtTotamt"); // long 16
				block.DpstgMny = query.GetFieldData(block.GetBlockName(), "DpstgMny", 0).ParseLong("DpstgMny"); // long 16
				block.PsnOutAbleTotAmt = query.GetFieldData(block.GetBlockName(), "PsnOutAbleTotAmt", 0).ParseLong("PsnOutAbleTotAmt"); // long 15
				block.PsnOutAbleCurAmt = query.GetFieldData(block.GetBlockName(), "PsnOutAbleCurAmt", 0).ParseLong("PsnOutAbleCurAmt"); // long 16
				block.OrdAbleTotAmt = query.GetFieldData(block.GetBlockName(), "OrdAbleTotAmt", 0).ParseLong("OrdAbleTotAmt"); // long 15
				block.MnyOrdAbleAmt = query.GetFieldData(block.GetBlockName(), "MnyOrdAbleAmt", 0).ParseLong("MnyOrdAbleAmt"); // long 16
				block.CsgnMgnTotamt = query.GetFieldData(block.GetBlockName(), "CsgnMgnTotamt", 0).ParseLong("CsgnMgnTotamt"); // long 16
				block.MnyCsgnMgn = query.GetFieldData(block.GetBlockName(), "MnyCsgnMgn", 0).ParseLong("MnyCsgnMgn"); // long 16
				block.AddMgnTotamt = query.GetFieldData(block.GetBlockName(), "AddMgnTotamt", 0).ParseLong("AddMgnTotamt"); // long 15
				block.MnyAddMgn = query.GetFieldData(block.GetBlockName(), "MnyAddMgn", 0).ParseLong("MnyAddMgn"); // long 16
				block.CmsnAmt = query.GetFieldData(block.GetBlockName(), "CmsnAmt", 0).ParseLong("CmsnAmt"); // long 16
				block.FutsEvalPnlAmt = query.GetFieldData(block.GetBlockName(), "FutsEvalPnlAmt", 0).ParseLong("FutsEvalPnlAmt"); // long 16
				block.OptEvalPnlAmt = query.GetFieldData(block.GetBlockName(), "OptEvalPnlAmt", 0).ParseLong("OptEvalPnlAmt"); // long 16
				block.OptEvalAmt = query.GetFieldData(block.GetBlockName(), "OptEvalAmt", 0).ParseLong("OptEvalAmt"); // long 16
				block.OptBnsplAmt = query.GetFieldData(block.GetBlockName(), "OptBnsplAmt", 0).ParseLong("OptBnsplAmt"); // long 16
				block.FutsAdjstDfamt = query.GetFieldData(block.GetBlockName(), "FutsAdjstDfamt", 0).ParseLong("FutsAdjstDfamt"); // long 16
				block.TotPnlAmt = query.GetFieldData(block.GetBlockName(), "TotPnlAmt", 0).ParseLong("TotPnlAmt"); // long 16
				block.NetPnlAmt = query.GetFieldData(block.GetBlockName(), "NetPnlAmt", 0).ParseLong("NetPnlAmt"); // long 16
				block.TotEvalAmt = query.GetFieldData(block.GetBlockName(), "TotEvalAmt", 0).ParseLong("TotEvalAmt"); // long 16
				block.MnyinAmt = query.GetFieldData(block.GetBlockName(), "MnyinAmt", 0).ParseLong("MnyinAmt"); // long 16
				block.MnyoutAmt = query.GetFieldData(block.GetBlockName(), "MnyoutAmt", 0).ParseLong("MnyoutAmt"); // long 16

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
			if (AcntNm?.Length > 40) return false; // char 40
			if (EvalDpsamtTotamt.ToString().Length > 15) return false; // long 15
			if (MnyEvalDpstgAmt.ToString().Length > 15) return false; // long 15
			if (DpsamtTotamt.ToString().Length > 16) return false; // long 16
			if (DpstgMny.ToString().Length > 16) return false; // long 16
			if (PsnOutAbleTotAmt.ToString().Length > 15) return false; // long 15
			if (PsnOutAbleCurAmt.ToString().Length > 16) return false; // long 16
			if (OrdAbleTotAmt.ToString().Length > 15) return false; // long 15
			if (MnyOrdAbleAmt.ToString().Length > 16) return false; // long 16
			if (CsgnMgnTotamt.ToString().Length > 16) return false; // long 16
			if (MnyCsgnMgn.ToString().Length > 16) return false; // long 16
			if (AddMgnTotamt.ToString().Length > 15) return false; // long 15
			if (MnyAddMgn.ToString().Length > 16) return false; // long 16
			if (CmsnAmt.ToString().Length > 16) return false; // long 16
			if (FutsEvalPnlAmt.ToString().Length > 16) return false; // long 16
			if (OptEvalPnlAmt.ToString().Length > 16) return false; // long 16
			if (OptEvalAmt.ToString().Length > 16) return false; // long 16
			if (OptBnsplAmt.ToString().Length > 16) return false; // long 16
			if (FutsAdjstDfamt.ToString().Length > 16) return false; // long 16
			if (TotPnlAmt.ToString().Length > 16) return false; // long 16
			if (NetPnlAmt.ToString().Length > 16) return false; // long 16
			if (TotEvalAmt.ToString().Length > 16) return false; // long 16
			if (MnyinAmt.ToString().Length > 16) return false; // long 16
			if (MnyoutAmt.ToString().Length > 16) return false; // long 16

			return true;
		}

		public void CopyTo(XQCCEAQ50600OutBlock2 block)
		{
			block.RecCnt = this.RecCnt;
			block.AcntNo = this.AcntNo;
			block.AcntNm = this.AcntNm;
			block.EvalDpsamtTotamt = this.EvalDpsamtTotamt;
			block.MnyEvalDpstgAmt = this.MnyEvalDpstgAmt;
			block.DpsamtTotamt = this.DpsamtTotamt;
			block.DpstgMny = this.DpstgMny;
			block.PsnOutAbleTotAmt = this.PsnOutAbleTotAmt;
			block.PsnOutAbleCurAmt = this.PsnOutAbleCurAmt;
			block.OrdAbleTotAmt = this.OrdAbleTotAmt;
			block.MnyOrdAbleAmt = this.MnyOrdAbleAmt;
			block.CsgnMgnTotamt = this.CsgnMgnTotamt;
			block.MnyCsgnMgn = this.MnyCsgnMgn;
			block.AddMgnTotamt = this.AddMgnTotamt;
			block.MnyAddMgn = this.MnyAddMgn;
			block.CmsnAmt = this.CmsnAmt;
			block.FutsEvalPnlAmt = this.FutsEvalPnlAmt;
			block.OptEvalPnlAmt = this.OptEvalPnlAmt;
			block.OptEvalAmt = this.OptEvalAmt;
			block.OptBnsplAmt = this.OptBnsplAmt;
			block.FutsAdjstDfamt = this.FutsAdjstDfamt;
			block.TotPnlAmt = this.TotPnlAmt;
			block.NetPnlAmt = this.NetPnlAmt;
			block.TotEvalAmt = this.TotEvalAmt;
			block.MnyinAmt = this.MnyinAmt;
			block.MnyoutAmt = this.MnyoutAmt;

		}
	}

	public partial class XQCCEAQ50600OutBlock3 : XingBlock
	{
		/// <summary>
		/// CCEAQ50600OutBlock3
		/// </summary>
		public const string _blockName = "CCEAQ50600OutBlock3";
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
		/// CCEAQ50600OutBlock3
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CCEAQ50600OutBlock3
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
		/// 미결제수량
		/// </summary>
		[XAQueryFieldAttribute("UnsttQty", "미결제수량", "long", "16")]
		public long UnsttQty;
		/// <summary>
		/// 평균가
		/// </summary>
		[XAQueryFieldAttribute("FnoAvrPrc", "평균가", "double", "19.8")]
		public double FnoAvrPrc;
		/// <summary>
		/// 현재가
		/// </summary>
		[XAQueryFieldAttribute("NowPrc", "현재가", "double", "13.2")]
		public double NowPrc;
		/// <summary>
		/// 대비가
		/// </summary>
		[XAQueryFieldAttribute("CmpPrc", "대비가", "double", "13.2")]
		public double CmpPrc;
		/// <summary>
		/// 평가손익
		/// </summary>
		[XAQueryFieldAttribute("EvalPnl", "평가손익", "long", "16")]
		public long EvalPnl;
		/// <summary>
		/// 손익률
		/// </summary>
		[XAQueryFieldAttribute("PnlRat", "손익률", "double", "12.6")]
		public double PnlRat;
		/// <summary>
		/// 평가금액
		/// </summary>
		[XAQueryFieldAttribute("EvalAmt", "평가금액", "long", "16")]
		public long EvalAmt;

		public static class F
		{
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
			/// 미결제수량
			/// </summary>
			public const string UnsttQty = "UnsttQty";
			/// <summary>
			/// 평균가
			/// </summary>
			public const string FnoAvrPrc = "FnoAvrPrc";
			/// <summary>
			/// 현재가
			/// </summary>
			public const string NowPrc = "NowPrc";
			/// <summary>
			/// 대비가
			/// </summary>
			public const string CmpPrc = "CmpPrc";
			/// <summary>
			/// 평가손익
			/// </summary>
			public const string EvalPnl = "EvalPnl";
			/// <summary>
			/// 손익률
			/// </summary>
			public const string PnlRat = "PnlRat";
			/// <summary>
			/// 평가금액
			/// </summary>
			public const string EvalAmt = "EvalAmt";
		}

		public static string[] AllFields = new string[]
		{
			F.FnoIsuNo,
			F.IsuNm,
			F.BnsTpCode,
			F.BnsTpNm,
			F.UnsttQty,
			F.FnoAvrPrc,
			F.NowPrc,
			F.CmpPrc,
			F.EvalPnl,
			F.PnlRat,
			F.EvalAmt,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["FnoIsuNo"] = new XAQueryFieldInfo("char", FnoIsuNo, FnoIsuNo, "선물옵션종목번호", (decimal)12);
			dict["IsuNm"] = new XAQueryFieldInfo("char", IsuNm, IsuNm, "종목명", (decimal)40);
			dict["BnsTpCode"] = new XAQueryFieldInfo("char", BnsTpCode, BnsTpCode.ToString(), "매매구분", (decimal)1);
			dict["BnsTpNm"] = new XAQueryFieldInfo("char", BnsTpNm, BnsTpNm, "매매구분", (decimal)10);
			dict["UnsttQty"] = new XAQueryFieldInfo("long", UnsttQty, UnsttQty.ToString("d16"), "미결제수량", (decimal)16);
			dict["FnoAvrPrc"] = new XAQueryFieldInfo("double", FnoAvrPrc, FnoAvrPrc.ToString("0000000000000000000.00000000"), "평균가", (decimal)19.8);
			dict["NowPrc"] = new XAQueryFieldInfo("double", NowPrc, NowPrc.ToString("0000000000000.00"), "현재가", (decimal)13.2);
			dict["CmpPrc"] = new XAQueryFieldInfo("double", CmpPrc, CmpPrc.ToString("0000000000000.00"), "대비가", (decimal)13.2);
			dict["EvalPnl"] = new XAQueryFieldInfo("long", EvalPnl, EvalPnl.ToString("d16"), "평가손익", (decimal)16);
			dict["PnlRat"] = new XAQueryFieldInfo("double", PnlRat, PnlRat.ToString("000000000000.000000"), "손익률", (decimal)12.6);
			dict["EvalAmt"] = new XAQueryFieldInfo("long", EvalAmt, EvalAmt.ToString("d16"), "평가금액", (decimal)16);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
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

				case "UnsttQty":
					this.UnsttQty = fieldInfo.FieldValue.ParseLong("UnsttQty");
				break;

				case "FnoAvrPrc":
					this.FnoAvrPrc = fieldInfo.FieldValue.ParseDouble("FnoAvrPrc");
				break;

				case "NowPrc":
					this.NowPrc = fieldInfo.FieldValue.ParseDouble("NowPrc");
				break;

				case "CmpPrc":
					this.CmpPrc = fieldInfo.FieldValue.ParseDouble("CmpPrc");
				break;

				case "EvalPnl":
					this.EvalPnl = fieldInfo.FieldValue.ParseLong("EvalPnl");
				break;

				case "PnlRat":
					this.PnlRat = fieldInfo.FieldValue.ParseDouble("PnlRat");
				break;

				case "EvalAmt":
					this.EvalAmt = fieldInfo.FieldValue.ParseLong("EvalAmt");
				break;


			}
		}

		public static XQCCEAQ50600OutBlock3[] ListFromQuery(XQCCEAQ50600 query)
		{
			int count = query.GetBlockCount(XQCCEAQ50600OutBlock3.BlockName);
			List<XQCCEAQ50600OutBlock3> list = new List<XQCCEAQ50600OutBlock3>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQCCEAQ50600OutBlock3 block = new XQCCEAQ50600OutBlock3();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.FnoIsuNo = query.GetFieldData(block.GetBlockName(), "FnoIsuNo", i).TrimEnd('?'); // char 12
					block.IsuNm = query.GetFieldData(block.GetBlockName(), "IsuNm", i).TrimEnd('?'); // char 40
					block.BnsTpCode = query.GetFieldData(block.GetBlockName(), "BnsTpCode", i).FirstOrDefault(); // char 1
					block.BnsTpNm = query.GetFieldData(block.GetBlockName(), "BnsTpNm", i).TrimEnd('?'); // char 10
					block.UnsttQty = query.GetFieldData(block.GetBlockName(), "UnsttQty", i).ParseLong("UnsttQty"); // long 16
					block.FnoAvrPrc = query.GetFieldData(block.GetBlockName(), "FnoAvrPrc", i).ParseDouble("FnoAvrPrc"); // double 19.8
					block.NowPrc = query.GetFieldData(block.GetBlockName(), "NowPrc", i).ParseDouble("NowPrc"); // double 13.2
					block.CmpPrc = query.GetFieldData(block.GetBlockName(), "CmpPrc", i).ParseDouble("CmpPrc"); // double 13.2
					block.EvalPnl = query.GetFieldData(block.GetBlockName(), "EvalPnl", i).ParseLong("EvalPnl"); // long 16
					block.PnlRat = query.GetFieldData(block.GetBlockName(), "PnlRat", i).ParseDouble("PnlRat"); // double 12.6
					block.EvalAmt = query.GetFieldData(block.GetBlockName(), "EvalAmt", i).ParseLong("EvalAmt"); // long 16

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
			if (FnoIsuNo?.Length > 12) return false; // char 12
			if (IsuNm?.Length > 40) return false; // char 40
			// BnsTpCode char 1
			if (BnsTpNm?.Length > 10) return false; // char 10
			if (UnsttQty.ToString().Length > 16) return false; // long 16
			// FnoAvrPrc double 19.8
			// NowPrc double 13.2
			// CmpPrc double 13.2
			if (EvalPnl.ToString().Length > 16) return false; // long 16
			// PnlRat double 12.6
			if (EvalAmt.ToString().Length > 16) return false; // long 16

			return true;
		}

		public void CopyTo(XQCCEAQ50600OutBlock3 block)
		{
			block.FnoIsuNo = this.FnoIsuNo;
			block.IsuNm = this.IsuNm;
			block.BnsTpCode = this.BnsTpCode;
			block.BnsTpNm = this.BnsTpNm;
			block.UnsttQty = this.UnsttQty;
			block.FnoAvrPrc = this.FnoAvrPrc;
			block.NowPrc = this.NowPrc;
			block.CmpPrc = this.CmpPrc;
			block.EvalPnl = this.EvalPnl;
			block.PnlRat = this.PnlRat;
			block.EvalAmt = this.EvalAmt;

		}
	}

	/// <summary>
	/// 선물옵션 CME 계좌잔고 및 평가현황
	/// </summary>
	public partial class XQCCEAQ50600 : XingQuery
	{
		/// <summary>
		/// CCEAQ50600
		/// </summary>
		public const string _typeName = "CCEAQ50600";
		/// <summary>
		/// 선물옵션 CME 계좌잔고 및 평가현황
		/// </summary>
		public const string _typeDesc = "선물옵션 CME 계좌잔고 및 평가현황";
		/// <summary>
		/// CCEAQ50600
		/// </summary>
		public const string _service = "CCEAQ50600";
		/// <summary>
		/// B
		/// </summary>
		public const string _headType = "B";
		/// <summary>
		/// 김승환
		/// </summary>
		public const string _creator = "김승환";
		/// <summary>
		/// 2012/05/01 12:18:45
		/// </summary>
		public const string _createdDate = "2012/05/01 12:18:45";
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
		/// CCEAQ50600
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 선물옵션 CME 계좌잔고 및 평가현황
		/// </summary>
		public string TypeDesc => _typeDesc;
		/// <summary>
		/// CCEAQ50600
		/// </summary>
		public string Service => _service;
		/// <summary>
		/// B
		/// </summary>
		public string HeadType => _headType;
		/// <summary>
		/// 김승환
		/// </summary>
		public string Creator => _creator;
		/// <summary>
		/// 2012/05/01 12:18:45
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
		/// 선물옵션 CME 계좌잔고 및 평가현황
		/// </summary>
		public XQCCEAQ50600() : base("CCEAQ50600") { }




		public bool SetBlock(XQCCEAQ50600InBlock1 block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "RecCnt", 0, block.RecCnt.ToString("d5")); // long 5
			_xaQuery.SetFieldData(block.GetBlockName(), "AcntNo", 0, block.AcntNo); // char 20
			_xaQuery.SetFieldData(block.GetBlockName(), "InptPwd", 0, block.InptPwd); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "BalEvalTp", 0, block.BalEvalTp.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "FutsPrcEvalTp", 0, block.FutsPrcEvalTp.ToString()); // char 1

			return true;
		}

		public XQCCEAQ50600OutBlock1 GetBlock1()
		{
			XQCCEAQ50600OutBlock1 instance = XQCCEAQ50600OutBlock1.FromQuery(this);
			return instance;

		}

		public XQCCEAQ50600OutBlock2 GetBlock2()
		{
			XQCCEAQ50600OutBlock2 instance = XQCCEAQ50600OutBlock2.FromQuery(this);
			return instance;

		}

		public XQCCEAQ50600OutBlock3[] GetBlock3s()
		{
			XQCCEAQ50600OutBlock3[] instance = XQCCEAQ50600OutBlock3.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQCCEAQ50600OutBlock1),
			typeof(XQCCEAQ50600OutBlock2),
			typeof(XQCCEAQ50600OutBlock3),

		};

	}

}
