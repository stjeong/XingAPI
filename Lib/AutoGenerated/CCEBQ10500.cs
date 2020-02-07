using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQCCEBQ10500InBlock1 : XingBlock
	{
		/// <summary>
		/// CCEBQ10500InBlock1
		/// </summary>
		public const string _blockName = "CCEBQ10500InBlock1";
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
		/// CCEBQ10500InBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CCEBQ10500InBlock1
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
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.AcntNo,
			F.Pwd,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["AcntNo"] = new XAQueryFieldInfo("char", AcntNo, AcntNo, "계좌번호", (decimal)20);
			dict["Pwd"] = new XAQueryFieldInfo("char", Pwd, Pwd, "비밀번호", (decimal)8);

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


			}
		}

		public bool VerifyData()
		{
			if (RecCnt.ToString().Length > 5) return false; // long 5
			if (AcntNo?.Length > 20) return false; // char 20
			if (Pwd?.Length > 8) return false; // char 8

			return true;
		}
	}

	public partial class XQCCEBQ10500OutBlock1 : XingBlock
	{
		/// <summary>
		/// CCEBQ10500OutBlock1
		/// </summary>
		public const string _blockName = "CCEBQ10500OutBlock1";
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
		/// CCEBQ10500OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CCEBQ10500OutBlock1
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
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.AcntNo,
			F.Pwd,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["AcntNo"] = new XAQueryFieldInfo("char", AcntNo, AcntNo, "계좌번호", (decimal)20);
			dict["Pwd"] = new XAQueryFieldInfo("char", Pwd, Pwd, "비밀번호", (decimal)8);

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


			}
		}

		public static XQCCEBQ10500OutBlock1 FromQuery(XQCCEBQ10500 query)
		{
			XQCCEBQ10500OutBlock1 block = new XQCCEBQ10500OutBlock1();
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

			return true;
		}
	}

	public partial class XQCCEBQ10500OutBlock2 : XingBlock
	{
		/// <summary>
		/// CCEBQ10500OutBlock2
		/// </summary>
		public const string _blockName = "CCEBQ10500OutBlock2";
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
		/// CCEBQ10500OutBlock2
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CCEBQ10500OutBlock2
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
		/// 예탁금총액
		/// </summary>
		[XAQueryFieldAttribute("예탁금총액")]
		public long DpsamtTotamt;
		/// <summary>
		/// 예수금
		/// </summary>
		[XAQueryFieldAttribute("예수금")]
		public long Dps;
		/// <summary>
		/// 대용금액
		/// </summary>
		[XAQueryFieldAttribute("대용금액")]
		public long SubstAmt;
		/// <summary>
		/// 충당예탁금총액
		/// </summary>
		[XAQueryFieldAttribute("충당예탁금총액")]
		public long FilupDpsamtTotamt;
		/// <summary>
		/// 충당예수금
		/// </summary>
		[XAQueryFieldAttribute("충당예수금")]
		public long FilupDps;
		/// <summary>
		/// 선물손익금액
		/// </summary>
		[XAQueryFieldAttribute("선물손익금액")]
		public long FutsPnlAmt;
		/// <summary>
		/// 인출가능금액
		/// </summary>
		[XAQueryFieldAttribute("인출가능금액")]
		public long WthdwAbleAmt;
		/// <summary>
		/// 인출가능현금액
		/// </summary>
		[XAQueryFieldAttribute("인출가능현금액")]
		public long PsnOutAbleCurAmt;
		/// <summary>
		/// 인출가능대용금액
		/// </summary>
		[XAQueryFieldAttribute("인출가능대용금액")]
		public long PsnOutAbleSubstAmt;
		/// <summary>
		/// 증거금액
		/// </summary>
		[XAQueryFieldAttribute("증거금액")]
		public long Mgn;
		/// <summary>
		/// 현금증거금액
		/// </summary>
		[XAQueryFieldAttribute("현금증거금액")]
		public long MnyMgn;
		/// <summary>
		/// 주문가능금액
		/// </summary>
		[XAQueryFieldAttribute("주문가능금액")]
		public long OrdAbleAmt;
		/// <summary>
		/// 현금주문가능금액
		/// </summary>
		[XAQueryFieldAttribute("현금주문가능금액")]
		public long MnyOrdAbleAmt;
		/// <summary>
		/// 추가증거금액
		/// </summary>
		[XAQueryFieldAttribute("추가증거금액")]
		public long AddMgn;
		/// <summary>
		/// 현금추가증거금액
		/// </summary>
		[XAQueryFieldAttribute("현금추가증거금액")]
		public long MnyAddMgn;
		/// <summary>
		/// 금전일수표입금액
		/// </summary>
		[XAQueryFieldAttribute("금전일수표입금액")]
		public long AmtPrdayChckInAmt;
		/// <summary>
		/// 선물옵션전일대용매도금액
		/// </summary>
		[XAQueryFieldAttribute("선물옵션전일대용매도금액")]
		public long FnoPrdaySubstSellAmt;
		/// <summary>
		/// 선물옵션금일대용매도금액
		/// </summary>
		[XAQueryFieldAttribute("선물옵션금일대용매도금액")]
		public long FnoCrdaySubstSellAmt;
		/// <summary>
		/// 선물옵션전일가입금액
		/// </summary>
		[XAQueryFieldAttribute("선물옵션전일가입금액")]
		public long FnoPrdayFdamt;
		/// <summary>
		/// 선물옵션금일가입금액
		/// </summary>
		[XAQueryFieldAttribute("선물옵션금일가입금액")]
		public long FnoCrdayFdamt;
		/// <summary>
		/// 외화대용금액
		/// </summary>
		[XAQueryFieldAttribute("외화대용금액")]
		public long FcurrSubstAmt;
		/// <summary>
		/// 선물옵션계좌사후증거금명
		/// </summary>
		[XAQueryFieldAttribute("선물옵션계좌사후증거금명")]
		public string FnoAcntAfmgnNm;

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
			/// 예탁금총액
			/// </summary>
			public const string DpsamtTotamt = "DpsamtTotamt";
			/// <summary>
			/// 예수금
			/// </summary>
			public const string Dps = "Dps";
			/// <summary>
			/// 대용금액
			/// </summary>
			public const string SubstAmt = "SubstAmt";
			/// <summary>
			/// 충당예탁금총액
			/// </summary>
			public const string FilupDpsamtTotamt = "FilupDpsamtTotamt";
			/// <summary>
			/// 충당예수금
			/// </summary>
			public const string FilupDps = "FilupDps";
			/// <summary>
			/// 선물손익금액
			/// </summary>
			public const string FutsPnlAmt = "FutsPnlAmt";
			/// <summary>
			/// 인출가능금액
			/// </summary>
			public const string WthdwAbleAmt = "WthdwAbleAmt";
			/// <summary>
			/// 인출가능현금액
			/// </summary>
			public const string PsnOutAbleCurAmt = "PsnOutAbleCurAmt";
			/// <summary>
			/// 인출가능대용금액
			/// </summary>
			public const string PsnOutAbleSubstAmt = "PsnOutAbleSubstAmt";
			/// <summary>
			/// 증거금액
			/// </summary>
			public const string Mgn = "Mgn";
			/// <summary>
			/// 현금증거금액
			/// </summary>
			public const string MnyMgn = "MnyMgn";
			/// <summary>
			/// 주문가능금액
			/// </summary>
			public const string OrdAbleAmt = "OrdAbleAmt";
			/// <summary>
			/// 현금주문가능금액
			/// </summary>
			public const string MnyOrdAbleAmt = "MnyOrdAbleAmt";
			/// <summary>
			/// 추가증거금액
			/// </summary>
			public const string AddMgn = "AddMgn";
			/// <summary>
			/// 현금추가증거금액
			/// </summary>
			public const string MnyAddMgn = "MnyAddMgn";
			/// <summary>
			/// 금전일수표입금액
			/// </summary>
			public const string AmtPrdayChckInAmt = "AmtPrdayChckInAmt";
			/// <summary>
			/// 선물옵션전일대용매도금액
			/// </summary>
			public const string FnoPrdaySubstSellAmt = "FnoPrdaySubstSellAmt";
			/// <summary>
			/// 선물옵션금일대용매도금액
			/// </summary>
			public const string FnoCrdaySubstSellAmt = "FnoCrdaySubstSellAmt";
			/// <summary>
			/// 선물옵션전일가입금액
			/// </summary>
			public const string FnoPrdayFdamt = "FnoPrdayFdamt";
			/// <summary>
			/// 선물옵션금일가입금액
			/// </summary>
			public const string FnoCrdayFdamt = "FnoCrdayFdamt";
			/// <summary>
			/// 외화대용금액
			/// </summary>
			public const string FcurrSubstAmt = "FcurrSubstAmt";
			/// <summary>
			/// 선물옵션계좌사후증거금명
			/// </summary>
			public const string FnoAcntAfmgnNm = "FnoAcntAfmgnNm";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.AcntNm,
			F.DpsamtTotamt,
			F.Dps,
			F.SubstAmt,
			F.FilupDpsamtTotamt,
			F.FilupDps,
			F.FutsPnlAmt,
			F.WthdwAbleAmt,
			F.PsnOutAbleCurAmt,
			F.PsnOutAbleSubstAmt,
			F.Mgn,
			F.MnyMgn,
			F.OrdAbleAmt,
			F.MnyOrdAbleAmt,
			F.AddMgn,
			F.MnyAddMgn,
			F.AmtPrdayChckInAmt,
			F.FnoPrdaySubstSellAmt,
			F.FnoCrdaySubstSellAmt,
			F.FnoPrdayFdamt,
			F.FnoCrdayFdamt,
			F.FcurrSubstAmt,
			F.FnoAcntAfmgnNm,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["AcntNm"] = new XAQueryFieldInfo("char", AcntNm, AcntNm, "계좌명", (decimal)40);
			dict["DpsamtTotamt"] = new XAQueryFieldInfo("long", DpsamtTotamt, DpsamtTotamt.ToString("d16"), "예탁금총액", (decimal)16);
			dict["Dps"] = new XAQueryFieldInfo("long", Dps, Dps.ToString("d16"), "예수금", (decimal)16);
			dict["SubstAmt"] = new XAQueryFieldInfo("long", SubstAmt, SubstAmt.ToString("d16"), "대용금액", (decimal)16);
			dict["FilupDpsamtTotamt"] = new XAQueryFieldInfo("long", FilupDpsamtTotamt, FilupDpsamtTotamt.ToString("d16"), "충당예탁금총액", (decimal)16);
			dict["FilupDps"] = new XAQueryFieldInfo("long", FilupDps, FilupDps.ToString("d16"), "충당예수금", (decimal)16);
			dict["FutsPnlAmt"] = new XAQueryFieldInfo("long", FutsPnlAmt, FutsPnlAmt.ToString("d16"), "선물손익금액", (decimal)16);
			dict["WthdwAbleAmt"] = new XAQueryFieldInfo("long", WthdwAbleAmt, WthdwAbleAmt.ToString("d16"), "인출가능금액", (decimal)16);
			dict["PsnOutAbleCurAmt"] = new XAQueryFieldInfo("long", PsnOutAbleCurAmt, PsnOutAbleCurAmt.ToString("d16"), "인출가능현금액", (decimal)16);
			dict["PsnOutAbleSubstAmt"] = new XAQueryFieldInfo("long", PsnOutAbleSubstAmt, PsnOutAbleSubstAmt.ToString("d16"), "인출가능대용금액", (decimal)16);
			dict["Mgn"] = new XAQueryFieldInfo("long", Mgn, Mgn.ToString("d16"), "증거금액", (decimal)16);
			dict["MnyMgn"] = new XAQueryFieldInfo("long", MnyMgn, MnyMgn.ToString("d16"), "현금증거금액", (decimal)16);
			dict["OrdAbleAmt"] = new XAQueryFieldInfo("long", OrdAbleAmt, OrdAbleAmt.ToString("d16"), "주문가능금액", (decimal)16);
			dict["MnyOrdAbleAmt"] = new XAQueryFieldInfo("long", MnyOrdAbleAmt, MnyOrdAbleAmt.ToString("d16"), "현금주문가능금액", (decimal)16);
			dict["AddMgn"] = new XAQueryFieldInfo("long", AddMgn, AddMgn.ToString("d16"), "추가증거금액", (decimal)16);
			dict["MnyAddMgn"] = new XAQueryFieldInfo("long", MnyAddMgn, MnyAddMgn.ToString("d16"), "현금추가증거금액", (decimal)16);
			dict["AmtPrdayChckInAmt"] = new XAQueryFieldInfo("long", AmtPrdayChckInAmt, AmtPrdayChckInAmt.ToString("d16"), "금전일수표입금액", (decimal)16);
			dict["FnoPrdaySubstSellAmt"] = new XAQueryFieldInfo("long", FnoPrdaySubstSellAmt, FnoPrdaySubstSellAmt.ToString("d16"), "선물옵션전일대용매도금액", (decimal)16);
			dict["FnoCrdaySubstSellAmt"] = new XAQueryFieldInfo("long", FnoCrdaySubstSellAmt, FnoCrdaySubstSellAmt.ToString("d16"), "선물옵션금일대용매도금액", (decimal)16);
			dict["FnoPrdayFdamt"] = new XAQueryFieldInfo("long", FnoPrdayFdamt, FnoPrdayFdamt.ToString("d16"), "선물옵션전일가입금액", (decimal)16);
			dict["FnoCrdayFdamt"] = new XAQueryFieldInfo("long", FnoCrdayFdamt, FnoCrdayFdamt.ToString("d16"), "선물옵션금일가입금액", (decimal)16);
			dict["FcurrSubstAmt"] = new XAQueryFieldInfo("long", FcurrSubstAmt, FcurrSubstAmt.ToString("d16"), "외화대용금액", (decimal)16);
			dict["FnoAcntAfmgnNm"] = new XAQueryFieldInfo("char", FnoAcntAfmgnNm, FnoAcntAfmgnNm, "선물옵션계좌사후증거금명", (decimal)20);

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

				case "DpsamtTotamt":
					this.DpsamtTotamt = fieldInfo.FieldValue.ParseLong("DpsamtTotamt");
				break;

				case "Dps":
					this.Dps = fieldInfo.FieldValue.ParseLong("Dps");
				break;

				case "SubstAmt":
					this.SubstAmt = fieldInfo.FieldValue.ParseLong("SubstAmt");
				break;

				case "FilupDpsamtTotamt":
					this.FilupDpsamtTotamt = fieldInfo.FieldValue.ParseLong("FilupDpsamtTotamt");
				break;

				case "FilupDps":
					this.FilupDps = fieldInfo.FieldValue.ParseLong("FilupDps");
				break;

				case "FutsPnlAmt":
					this.FutsPnlAmt = fieldInfo.FieldValue.ParseLong("FutsPnlAmt");
				break;

				case "WthdwAbleAmt":
					this.WthdwAbleAmt = fieldInfo.FieldValue.ParseLong("WthdwAbleAmt");
				break;

				case "PsnOutAbleCurAmt":
					this.PsnOutAbleCurAmt = fieldInfo.FieldValue.ParseLong("PsnOutAbleCurAmt");
				break;

				case "PsnOutAbleSubstAmt":
					this.PsnOutAbleSubstAmt = fieldInfo.FieldValue.ParseLong("PsnOutAbleSubstAmt");
				break;

				case "Mgn":
					this.Mgn = fieldInfo.FieldValue.ParseLong("Mgn");
				break;

				case "MnyMgn":
					this.MnyMgn = fieldInfo.FieldValue.ParseLong("MnyMgn");
				break;

				case "OrdAbleAmt":
					this.OrdAbleAmt = fieldInfo.FieldValue.ParseLong("OrdAbleAmt");
				break;

				case "MnyOrdAbleAmt":
					this.MnyOrdAbleAmt = fieldInfo.FieldValue.ParseLong("MnyOrdAbleAmt");
				break;

				case "AddMgn":
					this.AddMgn = fieldInfo.FieldValue.ParseLong("AddMgn");
				break;

				case "MnyAddMgn":
					this.MnyAddMgn = fieldInfo.FieldValue.ParseLong("MnyAddMgn");
				break;

				case "AmtPrdayChckInAmt":
					this.AmtPrdayChckInAmt = fieldInfo.FieldValue.ParseLong("AmtPrdayChckInAmt");
				break;

				case "FnoPrdaySubstSellAmt":
					this.FnoPrdaySubstSellAmt = fieldInfo.FieldValue.ParseLong("FnoPrdaySubstSellAmt");
				break;

				case "FnoCrdaySubstSellAmt":
					this.FnoCrdaySubstSellAmt = fieldInfo.FieldValue.ParseLong("FnoCrdaySubstSellAmt");
				break;

				case "FnoPrdayFdamt":
					this.FnoPrdayFdamt = fieldInfo.FieldValue.ParseLong("FnoPrdayFdamt");
				break;

				case "FnoCrdayFdamt":
					this.FnoCrdayFdamt = fieldInfo.FieldValue.ParseLong("FnoCrdayFdamt");
				break;

				case "FcurrSubstAmt":
					this.FcurrSubstAmt = fieldInfo.FieldValue.ParseLong("FcurrSubstAmt");
				break;

				case "FnoAcntAfmgnNm":
					this.FnoAcntAfmgnNm = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQCCEBQ10500OutBlock2 FromQuery(XQCCEBQ10500 query)
		{
			XQCCEBQ10500OutBlock2 block = new XQCCEBQ10500OutBlock2();
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
				block.DpsamtTotamt = query.GetFieldData(block.GetBlockName(), "DpsamtTotamt", 0).ParseLong("DpsamtTotamt"); // long 16
				block.Dps = query.GetFieldData(block.GetBlockName(), "Dps", 0).ParseLong("Dps"); // long 16
				block.SubstAmt = query.GetFieldData(block.GetBlockName(), "SubstAmt", 0).ParseLong("SubstAmt"); // long 16
				block.FilupDpsamtTotamt = query.GetFieldData(block.GetBlockName(), "FilupDpsamtTotamt", 0).ParseLong("FilupDpsamtTotamt"); // long 16
				block.FilupDps = query.GetFieldData(block.GetBlockName(), "FilupDps", 0).ParseLong("FilupDps"); // long 16
				block.FutsPnlAmt = query.GetFieldData(block.GetBlockName(), "FutsPnlAmt", 0).ParseLong("FutsPnlAmt"); // long 16
				block.WthdwAbleAmt = query.GetFieldData(block.GetBlockName(), "WthdwAbleAmt", 0).ParseLong("WthdwAbleAmt"); // long 16
				block.PsnOutAbleCurAmt = query.GetFieldData(block.GetBlockName(), "PsnOutAbleCurAmt", 0).ParseLong("PsnOutAbleCurAmt"); // long 16
				block.PsnOutAbleSubstAmt = query.GetFieldData(block.GetBlockName(), "PsnOutAbleSubstAmt", 0).ParseLong("PsnOutAbleSubstAmt"); // long 16
				block.Mgn = query.GetFieldData(block.GetBlockName(), "Mgn", 0).ParseLong("Mgn"); // long 16
				block.MnyMgn = query.GetFieldData(block.GetBlockName(), "MnyMgn", 0).ParseLong("MnyMgn"); // long 16
				block.OrdAbleAmt = query.GetFieldData(block.GetBlockName(), "OrdAbleAmt", 0).ParseLong("OrdAbleAmt"); // long 16
				block.MnyOrdAbleAmt = query.GetFieldData(block.GetBlockName(), "MnyOrdAbleAmt", 0).ParseLong("MnyOrdAbleAmt"); // long 16
				block.AddMgn = query.GetFieldData(block.GetBlockName(), "AddMgn", 0).ParseLong("AddMgn"); // long 16
				block.MnyAddMgn = query.GetFieldData(block.GetBlockName(), "MnyAddMgn", 0).ParseLong("MnyAddMgn"); // long 16
				block.AmtPrdayChckInAmt = query.GetFieldData(block.GetBlockName(), "AmtPrdayChckInAmt", 0).ParseLong("AmtPrdayChckInAmt"); // long 16
				block.FnoPrdaySubstSellAmt = query.GetFieldData(block.GetBlockName(), "FnoPrdaySubstSellAmt", 0).ParseLong("FnoPrdaySubstSellAmt"); // long 16
				block.FnoCrdaySubstSellAmt = query.GetFieldData(block.GetBlockName(), "FnoCrdaySubstSellAmt", 0).ParseLong("FnoCrdaySubstSellAmt"); // long 16
				block.FnoPrdayFdamt = query.GetFieldData(block.GetBlockName(), "FnoPrdayFdamt", 0).ParseLong("FnoPrdayFdamt"); // long 16
				block.FnoCrdayFdamt = query.GetFieldData(block.GetBlockName(), "FnoCrdayFdamt", 0).ParseLong("FnoCrdayFdamt"); // long 16
				block.FcurrSubstAmt = query.GetFieldData(block.GetBlockName(), "FcurrSubstAmt", 0).ParseLong("FcurrSubstAmt"); // long 16
				block.FnoAcntAfmgnNm = query.GetFieldData(block.GetBlockName(), "FnoAcntAfmgnNm", 0).TrimEnd('?'); // char 20

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
			if (DpsamtTotamt.ToString().Length > 16) return false; // long 16
			if (Dps.ToString().Length > 16) return false; // long 16
			if (SubstAmt.ToString().Length > 16) return false; // long 16
			if (FilupDpsamtTotamt.ToString().Length > 16) return false; // long 16
			if (FilupDps.ToString().Length > 16) return false; // long 16
			if (FutsPnlAmt.ToString().Length > 16) return false; // long 16
			if (WthdwAbleAmt.ToString().Length > 16) return false; // long 16
			if (PsnOutAbleCurAmt.ToString().Length > 16) return false; // long 16
			if (PsnOutAbleSubstAmt.ToString().Length > 16) return false; // long 16
			if (Mgn.ToString().Length > 16) return false; // long 16
			if (MnyMgn.ToString().Length > 16) return false; // long 16
			if (OrdAbleAmt.ToString().Length > 16) return false; // long 16
			if (MnyOrdAbleAmt.ToString().Length > 16) return false; // long 16
			if (AddMgn.ToString().Length > 16) return false; // long 16
			if (MnyAddMgn.ToString().Length > 16) return false; // long 16
			if (AmtPrdayChckInAmt.ToString().Length > 16) return false; // long 16
			if (FnoPrdaySubstSellAmt.ToString().Length > 16) return false; // long 16
			if (FnoCrdaySubstSellAmt.ToString().Length > 16) return false; // long 16
			if (FnoPrdayFdamt.ToString().Length > 16) return false; // long 16
			if (FnoCrdayFdamt.ToString().Length > 16) return false; // long 16
			if (FcurrSubstAmt.ToString().Length > 16) return false; // long 16
			if (FnoAcntAfmgnNm?.Length > 20) return false; // char 20

			return true;
		}
	}

	public partial class XQCCEBQ10500OutBlock3 : XingBlock
	{
		/// <summary>
		/// CCEBQ10500OutBlock3
		/// </summary>
		public const string _blockName = "CCEBQ10500OutBlock3";
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
		/// CCEBQ10500OutBlock3
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CCEBQ10500OutBlock3
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
		/// 상품군코드명
		/// </summary>
		[XAQueryFieldAttribute("상품군코드명")]
		public string PdGrpCodeNm;
		/// <summary>
		/// 순위험증거금액
		/// </summary>
		[XAQueryFieldAttribute("순위험증거금액")]
		public long NetRiskMgn;
		/// <summary>
		/// 가격증거금액
		/// </summary>
		[XAQueryFieldAttribute("가격증거금액")]
		public long PrcMgn;
		/// <summary>
		/// 스프레드증거금액
		/// </summary>
		[XAQueryFieldAttribute("스프레드증거금액")]
		public long SprdMgn;
		/// <summary>
		/// 가격변동증거금액
		/// </summary>
		[XAQueryFieldAttribute("가격변동증거금액")]
		public long PrcFlctMgn;
		/// <summary>
		/// 최소증거금액
		/// </summary>
		[XAQueryFieldAttribute("최소증거금액")]
		public long MinMgn;
		/// <summary>
		/// 주문증거금액
		/// </summary>
		[XAQueryFieldAttribute("주문증거금액")]
		public long OrdMgn;
		/// <summary>
		/// 옵션순매수금액
		/// </summary>
		[XAQueryFieldAttribute("옵션순매수금액")]
		public long OptNetBuyAmt;
		/// <summary>
		/// 위탁증거금액
		/// </summary>
		[XAQueryFieldAttribute("위탁증거금액")]
		public long CsgnMgn;
		/// <summary>
		/// 유지증거금액
		/// </summary>
		[XAQueryFieldAttribute("유지증거금액")]
		public long MaintMgn;
		/// <summary>
		/// 선물매수체결금액
		/// </summary>
		[XAQueryFieldAttribute("선물매수체결금액")]
		public long FutsBuyExecAmt;
		/// <summary>
		/// 선물매도체결금액
		/// </summary>
		[XAQueryFieldAttribute("선물매도체결금액")]
		public long FutsSellExecAmt;
		/// <summary>
		/// 옵션매수체결금액
		/// </summary>
		[XAQueryFieldAttribute("옵션매수체결금액")]
		public long OptBuyExecAmt;
		/// <summary>
		/// 옵션매도체결금액
		/// </summary>
		[XAQueryFieldAttribute("옵션매도체결금액")]
		public long OptSellExecAmt;
		/// <summary>
		/// 선물손익금액
		/// </summary>
		[XAQueryFieldAttribute("선물손익금액")]
		public long FutsPnlAmt;
		/// <summary>
		/// 총위험위탁증거금
		/// </summary>
		[XAQueryFieldAttribute("총위험위탁증거금")]
		public long TotRiskCsgnMgn;
		/// <summary>
		/// 인수도위탁증거금
		/// </summary>
		[XAQueryFieldAttribute("인수도위탁증거금")]
		public long UndCsgnMgn;
		/// <summary>
		/// 증거금감면금액
		/// </summary>
		[XAQueryFieldAttribute("증거금감면금액")]
		public long MgnRdctAmt;

		public static class F
		{
			/// <summary>
			/// 상품군코드명
			/// </summary>
			public const string PdGrpCodeNm = "PdGrpCodeNm";
			/// <summary>
			/// 순위험증거금액
			/// </summary>
			public const string NetRiskMgn = "NetRiskMgn";
			/// <summary>
			/// 가격증거금액
			/// </summary>
			public const string PrcMgn = "PrcMgn";
			/// <summary>
			/// 스프레드증거금액
			/// </summary>
			public const string SprdMgn = "SprdMgn";
			/// <summary>
			/// 가격변동증거금액
			/// </summary>
			public const string PrcFlctMgn = "PrcFlctMgn";
			/// <summary>
			/// 최소증거금액
			/// </summary>
			public const string MinMgn = "MinMgn";
			/// <summary>
			/// 주문증거금액
			/// </summary>
			public const string OrdMgn = "OrdMgn";
			/// <summary>
			/// 옵션순매수금액
			/// </summary>
			public const string OptNetBuyAmt = "OptNetBuyAmt";
			/// <summary>
			/// 위탁증거금액
			/// </summary>
			public const string CsgnMgn = "CsgnMgn";
			/// <summary>
			/// 유지증거금액
			/// </summary>
			public const string MaintMgn = "MaintMgn";
			/// <summary>
			/// 선물매수체결금액
			/// </summary>
			public const string FutsBuyExecAmt = "FutsBuyExecAmt";
			/// <summary>
			/// 선물매도체결금액
			/// </summary>
			public const string FutsSellExecAmt = "FutsSellExecAmt";
			/// <summary>
			/// 옵션매수체결금액
			/// </summary>
			public const string OptBuyExecAmt = "OptBuyExecAmt";
			/// <summary>
			/// 옵션매도체결금액
			/// </summary>
			public const string OptSellExecAmt = "OptSellExecAmt";
			/// <summary>
			/// 선물손익금액
			/// </summary>
			public const string FutsPnlAmt = "FutsPnlAmt";
			/// <summary>
			/// 총위험위탁증거금
			/// </summary>
			public const string TotRiskCsgnMgn = "TotRiskCsgnMgn";
			/// <summary>
			/// 인수도위탁증거금
			/// </summary>
			public const string UndCsgnMgn = "UndCsgnMgn";
			/// <summary>
			/// 증거금감면금액
			/// </summary>
			public const string MgnRdctAmt = "MgnRdctAmt";
		}

		public static string[] AllFields = new string[]
		{
			F.PdGrpCodeNm,
			F.NetRiskMgn,
			F.PrcMgn,
			F.SprdMgn,
			F.PrcFlctMgn,
			F.MinMgn,
			F.OrdMgn,
			F.OptNetBuyAmt,
			F.CsgnMgn,
			F.MaintMgn,
			F.FutsBuyExecAmt,
			F.FutsSellExecAmt,
			F.OptBuyExecAmt,
			F.OptSellExecAmt,
			F.FutsPnlAmt,
			F.TotRiskCsgnMgn,
			F.UndCsgnMgn,
			F.MgnRdctAmt,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["PdGrpCodeNm"] = new XAQueryFieldInfo("char", PdGrpCodeNm, PdGrpCodeNm, "상품군코드명", (decimal)20);
			dict["NetRiskMgn"] = new XAQueryFieldInfo("long", NetRiskMgn, NetRiskMgn.ToString("d16"), "순위험증거금액", (decimal)16);
			dict["PrcMgn"] = new XAQueryFieldInfo("long", PrcMgn, PrcMgn.ToString("d16"), "가격증거금액", (decimal)16);
			dict["SprdMgn"] = new XAQueryFieldInfo("long", SprdMgn, SprdMgn.ToString("d16"), "스프레드증거금액", (decimal)16);
			dict["PrcFlctMgn"] = new XAQueryFieldInfo("long", PrcFlctMgn, PrcFlctMgn.ToString("d16"), "가격변동증거금액", (decimal)16);
			dict["MinMgn"] = new XAQueryFieldInfo("long", MinMgn, MinMgn.ToString("d16"), "최소증거금액", (decimal)16);
			dict["OrdMgn"] = new XAQueryFieldInfo("long", OrdMgn, OrdMgn.ToString("d16"), "주문증거금액", (decimal)16);
			dict["OptNetBuyAmt"] = new XAQueryFieldInfo("long", OptNetBuyAmt, OptNetBuyAmt.ToString("d16"), "옵션순매수금액", (decimal)16);
			dict["CsgnMgn"] = new XAQueryFieldInfo("long", CsgnMgn, CsgnMgn.ToString("d16"), "위탁증거금액", (decimal)16);
			dict["MaintMgn"] = new XAQueryFieldInfo("long", MaintMgn, MaintMgn.ToString("d16"), "유지증거금액", (decimal)16);
			dict["FutsBuyExecAmt"] = new XAQueryFieldInfo("long", FutsBuyExecAmt, FutsBuyExecAmt.ToString("d16"), "선물매수체결금액", (decimal)16);
			dict["FutsSellExecAmt"] = new XAQueryFieldInfo("long", FutsSellExecAmt, FutsSellExecAmt.ToString("d16"), "선물매도체결금액", (decimal)16);
			dict["OptBuyExecAmt"] = new XAQueryFieldInfo("long", OptBuyExecAmt, OptBuyExecAmt.ToString("d16"), "옵션매수체결금액", (decimal)16);
			dict["OptSellExecAmt"] = new XAQueryFieldInfo("long", OptSellExecAmt, OptSellExecAmt.ToString("d16"), "옵션매도체결금액", (decimal)16);
			dict["FutsPnlAmt"] = new XAQueryFieldInfo("long", FutsPnlAmt, FutsPnlAmt.ToString("d16"), "선물손익금액", (decimal)16);
			dict["TotRiskCsgnMgn"] = new XAQueryFieldInfo("long", TotRiskCsgnMgn, TotRiskCsgnMgn.ToString("d16"), "총위험위탁증거금", (decimal)16);
			dict["UndCsgnMgn"] = new XAQueryFieldInfo("long", UndCsgnMgn, UndCsgnMgn.ToString("d16"), "인수도위탁증거금", (decimal)16);
			dict["MgnRdctAmt"] = new XAQueryFieldInfo("long", MgnRdctAmt, MgnRdctAmt.ToString("d16"), "증거금감면금액", (decimal)16);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "PdGrpCodeNm":
					this.PdGrpCodeNm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "NetRiskMgn":
					this.NetRiskMgn = fieldInfo.FieldValue.ParseLong("NetRiskMgn");
				break;

				case "PrcMgn":
					this.PrcMgn = fieldInfo.FieldValue.ParseLong("PrcMgn");
				break;

				case "SprdMgn":
					this.SprdMgn = fieldInfo.FieldValue.ParseLong("SprdMgn");
				break;

				case "PrcFlctMgn":
					this.PrcFlctMgn = fieldInfo.FieldValue.ParseLong("PrcFlctMgn");
				break;

				case "MinMgn":
					this.MinMgn = fieldInfo.FieldValue.ParseLong("MinMgn");
				break;

				case "OrdMgn":
					this.OrdMgn = fieldInfo.FieldValue.ParseLong("OrdMgn");
				break;

				case "OptNetBuyAmt":
					this.OptNetBuyAmt = fieldInfo.FieldValue.ParseLong("OptNetBuyAmt");
				break;

				case "CsgnMgn":
					this.CsgnMgn = fieldInfo.FieldValue.ParseLong("CsgnMgn");
				break;

				case "MaintMgn":
					this.MaintMgn = fieldInfo.FieldValue.ParseLong("MaintMgn");
				break;

				case "FutsBuyExecAmt":
					this.FutsBuyExecAmt = fieldInfo.FieldValue.ParseLong("FutsBuyExecAmt");
				break;

				case "FutsSellExecAmt":
					this.FutsSellExecAmt = fieldInfo.FieldValue.ParseLong("FutsSellExecAmt");
				break;

				case "OptBuyExecAmt":
					this.OptBuyExecAmt = fieldInfo.FieldValue.ParseLong("OptBuyExecAmt");
				break;

				case "OptSellExecAmt":
					this.OptSellExecAmt = fieldInfo.FieldValue.ParseLong("OptSellExecAmt");
				break;

				case "FutsPnlAmt":
					this.FutsPnlAmt = fieldInfo.FieldValue.ParseLong("FutsPnlAmt");
				break;

				case "TotRiskCsgnMgn":
					this.TotRiskCsgnMgn = fieldInfo.FieldValue.ParseLong("TotRiskCsgnMgn");
				break;

				case "UndCsgnMgn":
					this.UndCsgnMgn = fieldInfo.FieldValue.ParseLong("UndCsgnMgn");
				break;

				case "MgnRdctAmt":
					this.MgnRdctAmt = fieldInfo.FieldValue.ParseLong("MgnRdctAmt");
				break;


			}
		}

		public static XQCCEBQ10500OutBlock3[] ListFromQuery(XQCCEBQ10500 query)
		{
			int count = query.GetBlockCount(XQCCEBQ10500OutBlock3.BlockName);
			List<XQCCEBQ10500OutBlock3> list = new List<XQCCEBQ10500OutBlock3>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQCCEBQ10500OutBlock3 block = new XQCCEBQ10500OutBlock3();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.PdGrpCodeNm = query.GetFieldData(block.GetBlockName(), "PdGrpCodeNm", i).TrimEnd('?'); // char 20
					block.NetRiskMgn = query.GetFieldData(block.GetBlockName(), "NetRiskMgn", i).ParseLong("NetRiskMgn"); // long 16
					block.PrcMgn = query.GetFieldData(block.GetBlockName(), "PrcMgn", i).ParseLong("PrcMgn"); // long 16
					block.SprdMgn = query.GetFieldData(block.GetBlockName(), "SprdMgn", i).ParseLong("SprdMgn"); // long 16
					block.PrcFlctMgn = query.GetFieldData(block.GetBlockName(), "PrcFlctMgn", i).ParseLong("PrcFlctMgn"); // long 16
					block.MinMgn = query.GetFieldData(block.GetBlockName(), "MinMgn", i).ParseLong("MinMgn"); // long 16
					block.OrdMgn = query.GetFieldData(block.GetBlockName(), "OrdMgn", i).ParseLong("OrdMgn"); // long 16
					block.OptNetBuyAmt = query.GetFieldData(block.GetBlockName(), "OptNetBuyAmt", i).ParseLong("OptNetBuyAmt"); // long 16
					block.CsgnMgn = query.GetFieldData(block.GetBlockName(), "CsgnMgn", i).ParseLong("CsgnMgn"); // long 16
					block.MaintMgn = query.GetFieldData(block.GetBlockName(), "MaintMgn", i).ParseLong("MaintMgn"); // long 16
					block.FutsBuyExecAmt = query.GetFieldData(block.GetBlockName(), "FutsBuyExecAmt", i).ParseLong("FutsBuyExecAmt"); // long 16
					block.FutsSellExecAmt = query.GetFieldData(block.GetBlockName(), "FutsSellExecAmt", i).ParseLong("FutsSellExecAmt"); // long 16
					block.OptBuyExecAmt = query.GetFieldData(block.GetBlockName(), "OptBuyExecAmt", i).ParseLong("OptBuyExecAmt"); // long 16
					block.OptSellExecAmt = query.GetFieldData(block.GetBlockName(), "OptSellExecAmt", i).ParseLong("OptSellExecAmt"); // long 16
					block.FutsPnlAmt = query.GetFieldData(block.GetBlockName(), "FutsPnlAmt", i).ParseLong("FutsPnlAmt"); // long 16
					block.TotRiskCsgnMgn = query.GetFieldData(block.GetBlockName(), "TotRiskCsgnMgn", i).ParseLong("TotRiskCsgnMgn"); // long 16
					block.UndCsgnMgn = query.GetFieldData(block.GetBlockName(), "UndCsgnMgn", i).ParseLong("UndCsgnMgn"); // long 16
					block.MgnRdctAmt = query.GetFieldData(block.GetBlockName(), "MgnRdctAmt", i).ParseLong("MgnRdctAmt"); // long 16

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
			if (PdGrpCodeNm?.Length > 20) return false; // char 20
			if (NetRiskMgn.ToString().Length > 16) return false; // long 16
			if (PrcMgn.ToString().Length > 16) return false; // long 16
			if (SprdMgn.ToString().Length > 16) return false; // long 16
			if (PrcFlctMgn.ToString().Length > 16) return false; // long 16
			if (MinMgn.ToString().Length > 16) return false; // long 16
			if (OrdMgn.ToString().Length > 16) return false; // long 16
			if (OptNetBuyAmt.ToString().Length > 16) return false; // long 16
			if (CsgnMgn.ToString().Length > 16) return false; // long 16
			if (MaintMgn.ToString().Length > 16) return false; // long 16
			if (FutsBuyExecAmt.ToString().Length > 16) return false; // long 16
			if (FutsSellExecAmt.ToString().Length > 16) return false; // long 16
			if (OptBuyExecAmt.ToString().Length > 16) return false; // long 16
			if (OptSellExecAmt.ToString().Length > 16) return false; // long 16
			if (FutsPnlAmt.ToString().Length > 16) return false; // long 16
			if (TotRiskCsgnMgn.ToString().Length > 16) return false; // long 16
			if (UndCsgnMgn.ToString().Length > 16) return false; // long 16
			if (MgnRdctAmt.ToString().Length > 16) return false; // long 16

			return true;
		}
	}

	/// <summary>
	/// 선물옵션 CME 예탁금증거금조회
	/// </summary>
	public partial class XQCCEBQ10500 : XingQuery
	{
		/// <summary>
		/// CCEBQ10500
		/// </summary>
		public const string _typeName = "CCEBQ10500";
		/// <summary>
		/// 선물옵션 CME 예탁금증거금조회
		/// </summary>
		public const string _typeDesc = "선물옵션 CME 예탁금증거금조회";
		/// <summary>
		/// CCEBQ10500
		/// </summary>
		public const string _service = "CCEBQ10500";
		/// <summary>
		/// B
		/// </summary>
		public const string _headType = "B";
		/// <summary>
		/// 김승환
		/// </summary>
		public const string _creator = "김승환";
		/// <summary>
		/// 2012/04/16 18:02:19
		/// </summary>
		public const string _createdDate = "2012/04/16 18:02:19";
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
		/// CCEBQ10500
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 선물옵션 CME 예탁금증거금조회
		/// </summary>
		public string TypeDesc => _typeDesc;
		/// <summary>
		/// CCEBQ10500
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
		/// 2012/04/16 18:02:19
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
		/// 선물옵션 CME 예탁금증거금조회
		/// </summary>
		public XQCCEBQ10500() : base("CCEBQ10500") { }



		public bool SetBlock(XQCCEBQ10500InBlock1 block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "RecCnt", 0, block.RecCnt.ToString("d5")); // long 5
			_xaQuery.SetFieldData(block.GetBlockName(), "AcntNo", 0, block.AcntNo); // char 20
			_xaQuery.SetFieldData(block.GetBlockName(), "Pwd", 0, block.Pwd); // char 8

			return true;
		}

		public XQCCEBQ10500OutBlock1 GetBlock1()
		{
			XQCCEBQ10500OutBlock1 instance = XQCCEBQ10500OutBlock1.FromQuery(this);
			return instance;

		}

		public XQCCEBQ10500OutBlock2 GetBlock2()
		{
			XQCCEBQ10500OutBlock2 instance = XQCCEBQ10500OutBlock2.FromQuery(this);
			return instance;

		}

		public XQCCEBQ10500OutBlock3[] GetBlock3s()
		{
			XQCCEBQ10500OutBlock3[] instance = XQCCEBQ10500OutBlock3.ListFromQuery(this);
			return instance;

		}


	}

}
