using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQCEXAQ21200InBlock1 : XingBlock
	{
		/// <summary>
		/// CEXAQ21200InBlock1
		/// </summary>
		public const string _blockName = "CEXAQ21200InBlock1";
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
		/// CEXAQ21200InBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CEXAQ21200InBlock1
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
		/// 조회구분
		/// </summary>
		[XAQueryFieldAttribute("조회구분")]
		public char QryTp;
		/// <summary>
		/// 주문금액
		/// </summary>
		[XAQueryFieldAttribute("주문금액")]
		public long OrdAmt;
		/// <summary>
		/// 비율값
		/// </summary>
		[XAQueryFieldAttribute("비율값")]
		public double RatVal;
		/// <summary>
		/// 선물옵션종목번호
		/// </summary>
		[XAQueryFieldAttribute("선물옵션종목번호")]
		public string FnoIsuNo;
		/// <summary>
		/// 매매구분
		/// </summary>
		[XAQueryFieldAttribute("매매구분")]
		public char BnsTpCode;
		/// <summary>
		/// 주문가
		/// </summary>
		[XAQueryFieldAttribute("주문가")]
		public double OrdPrc;
		/// <summary>
		/// 유렉스가격조건구분코드
		/// </summary>
		[XAQueryFieldAttribute("유렉스가격조건구분코드")]
		public char ErxPrcCndiTpCode;

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
			/// 조회구분
			/// </summary>
			public const string QryTp = "QryTp";
			/// <summary>
			/// 주문금액
			/// </summary>
			public const string OrdAmt = "OrdAmt";
			/// <summary>
			/// 비율값
			/// </summary>
			public const string RatVal = "RatVal";
			/// <summary>
			/// 선물옵션종목번호
			/// </summary>
			public const string FnoIsuNo = "FnoIsuNo";
			/// <summary>
			/// 매매구분
			/// </summary>
			public const string BnsTpCode = "BnsTpCode";
			/// <summary>
			/// 주문가
			/// </summary>
			public const string OrdPrc = "OrdPrc";
			/// <summary>
			/// 유렉스가격조건구분코드
			/// </summary>
			public const string ErxPrcCndiTpCode = "ErxPrcCndiTpCode";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.AcntNo,
			F.Pwd,
			F.QryTp,
			F.OrdAmt,
			F.RatVal,
			F.FnoIsuNo,
			F.BnsTpCode,
			F.OrdPrc,
			F.ErxPrcCndiTpCode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["AcntNo"] = new XAQueryFieldInfo("char", AcntNo, AcntNo, "계좌번호", (decimal)20);
			dict["Pwd"] = new XAQueryFieldInfo("char", Pwd, Pwd, "비밀번호", (decimal)8);
			dict["QryTp"] = new XAQueryFieldInfo("char", QryTp, QryTp.ToString(), "조회구분", (decimal)1);
			dict["OrdAmt"] = new XAQueryFieldInfo("long", OrdAmt, OrdAmt.ToString("d16"), "주문금액", (decimal)16);
			dict["RatVal"] = new XAQueryFieldInfo("double", RatVal, RatVal.ToString("0000000000000000000.00000000"), "비율값", (decimal)19.8);
			dict["FnoIsuNo"] = new XAQueryFieldInfo("char", FnoIsuNo, FnoIsuNo, "선물옵션종목번호", (decimal)12);
			dict["BnsTpCode"] = new XAQueryFieldInfo("char", BnsTpCode, BnsTpCode.ToString(), "매매구분", (decimal)1);
			dict["OrdPrc"] = new XAQueryFieldInfo("double", OrdPrc, OrdPrc.ToString("0000000000000.00"), "주문가", (decimal)13.2);
			dict["ErxPrcCndiTpCode"] = new XAQueryFieldInfo("char", ErxPrcCndiTpCode, ErxPrcCndiTpCode.ToString(), "유렉스가격조건구분코드", (decimal)1);

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

				case "QryTp":
					this.QryTp = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "OrdAmt":
					this.OrdAmt = fieldInfo.FieldValue.ParseLong("OrdAmt");
				break;

				case "RatVal":
					this.RatVal = fieldInfo.FieldValue.ParseDouble("RatVal");
				break;

				case "FnoIsuNo":
					this.FnoIsuNo = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "BnsTpCode":
					this.BnsTpCode = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "OrdPrc":
					this.OrdPrc = fieldInfo.FieldValue.ParseDouble("OrdPrc");
				break;

				case "ErxPrcCndiTpCode":
					this.ErxPrcCndiTpCode = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public bool VerifyData()
		{
			if (RecCnt.ToString().Length > 5) return false; // long 5
			if (AcntNo?.Length > 20) return false; // char 20
			if (Pwd?.Length > 8) return false; // char 8
			// QryTp char 1
			if (OrdAmt.ToString().Length > 16) return false; // long 16
			// RatVal double 19.8
			if (FnoIsuNo?.Length > 12) return false; // char 12
			// BnsTpCode char 1
			// OrdPrc double 13.2
			// ErxPrcCndiTpCode char 1

			return true;
		}
	}

	public partial class XQCEXAQ21200OutBlock1 : XingBlock
	{
		/// <summary>
		/// CEXAQ21200OutBlock1
		/// </summary>
		public const string _blockName = "CEXAQ21200OutBlock1";
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
		/// CEXAQ21200OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CEXAQ21200OutBlock1
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
		/// 조회구분
		/// </summary>
		[XAQueryFieldAttribute("조회구분")]
		public char QryTp;
		/// <summary>
		/// 주문금액
		/// </summary>
		[XAQueryFieldAttribute("주문금액")]
		public long OrdAmt;
		/// <summary>
		/// 비율값
		/// </summary>
		[XAQueryFieldAttribute("비율값")]
		public double RatVal;
		/// <summary>
		/// 선물옵션종목번호
		/// </summary>
		[XAQueryFieldAttribute("선물옵션종목번호")]
		public string FnoIsuNo;
		/// <summary>
		/// 매매구분
		/// </summary>
		[XAQueryFieldAttribute("매매구분")]
		public char BnsTpCode;
		/// <summary>
		/// 주문가
		/// </summary>
		[XAQueryFieldAttribute("주문가")]
		public double OrdPrc;
		/// <summary>
		/// 유렉스가격조건구분코드
		/// </summary>
		[XAQueryFieldAttribute("유렉스가격조건구분코드")]
		public char ErxPrcCndiTpCode;

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
			/// 조회구분
			/// </summary>
			public const string QryTp = "QryTp";
			/// <summary>
			/// 주문금액
			/// </summary>
			public const string OrdAmt = "OrdAmt";
			/// <summary>
			/// 비율값
			/// </summary>
			public const string RatVal = "RatVal";
			/// <summary>
			/// 선물옵션종목번호
			/// </summary>
			public const string FnoIsuNo = "FnoIsuNo";
			/// <summary>
			/// 매매구분
			/// </summary>
			public const string BnsTpCode = "BnsTpCode";
			/// <summary>
			/// 주문가
			/// </summary>
			public const string OrdPrc = "OrdPrc";
			/// <summary>
			/// 유렉스가격조건구분코드
			/// </summary>
			public const string ErxPrcCndiTpCode = "ErxPrcCndiTpCode";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.AcntNo,
			F.Pwd,
			F.QryTp,
			F.OrdAmt,
			F.RatVal,
			F.FnoIsuNo,
			F.BnsTpCode,
			F.OrdPrc,
			F.ErxPrcCndiTpCode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["AcntNo"] = new XAQueryFieldInfo("char", AcntNo, AcntNo, "계좌번호", (decimal)20);
			dict["Pwd"] = new XAQueryFieldInfo("char", Pwd, Pwd, "비밀번호", (decimal)8);
			dict["QryTp"] = new XAQueryFieldInfo("char", QryTp, QryTp.ToString(), "조회구분", (decimal)1);
			dict["OrdAmt"] = new XAQueryFieldInfo("long", OrdAmt, OrdAmt.ToString("d16"), "주문금액", (decimal)16);
			dict["RatVal"] = new XAQueryFieldInfo("double", RatVal, RatVal.ToString("0000000000000000000.00000000"), "비율값", (decimal)19.8);
			dict["FnoIsuNo"] = new XAQueryFieldInfo("char", FnoIsuNo, FnoIsuNo, "선물옵션종목번호", (decimal)12);
			dict["BnsTpCode"] = new XAQueryFieldInfo("char", BnsTpCode, BnsTpCode.ToString(), "매매구분", (decimal)1);
			dict["OrdPrc"] = new XAQueryFieldInfo("double", OrdPrc, OrdPrc.ToString("0000000000000.00"), "주문가", (decimal)13.2);
			dict["ErxPrcCndiTpCode"] = new XAQueryFieldInfo("char", ErxPrcCndiTpCode, ErxPrcCndiTpCode.ToString(), "유렉스가격조건구분코드", (decimal)1);

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

				case "QryTp":
					this.QryTp = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "OrdAmt":
					this.OrdAmt = fieldInfo.FieldValue.ParseLong("OrdAmt");
				break;

				case "RatVal":
					this.RatVal = fieldInfo.FieldValue.ParseDouble("RatVal");
				break;

				case "FnoIsuNo":
					this.FnoIsuNo = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "BnsTpCode":
					this.BnsTpCode = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "OrdPrc":
					this.OrdPrc = fieldInfo.FieldValue.ParseDouble("OrdPrc");
				break;

				case "ErxPrcCndiTpCode":
					this.ErxPrcCndiTpCode = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public static XQCEXAQ21200OutBlock1 FromQuery(XQCEXAQ21200 query)
		{
			XQCEXAQ21200OutBlock1 block = new XQCEXAQ21200OutBlock1();
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
				block.QryTp = query.GetFieldData(block.GetBlockName(), "QryTp", 0).FirstOrDefault(); // char 1
				block.OrdAmt = query.GetFieldData(block.GetBlockName(), "OrdAmt", 0).ParseLong("OrdAmt"); // long 16
				block.RatVal = query.GetFieldData(block.GetBlockName(), "RatVal", 0).ParseDouble("RatVal"); // double 19.8
				block.FnoIsuNo = query.GetFieldData(block.GetBlockName(), "FnoIsuNo", 0).TrimEnd('?'); // char 12
				block.BnsTpCode = query.GetFieldData(block.GetBlockName(), "BnsTpCode", 0).FirstOrDefault(); // char 1
				block.OrdPrc = query.GetFieldData(block.GetBlockName(), "OrdPrc", 0).ParseDouble("OrdPrc"); // double 13.2
				block.ErxPrcCndiTpCode = query.GetFieldData(block.GetBlockName(), "ErxPrcCndiTpCode", 0).FirstOrDefault(); // char 1

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
			// QryTp char 1
			if (OrdAmt.ToString().Length > 16) return false; // long 16
			// RatVal double 19.8
			if (FnoIsuNo?.Length > 12) return false; // char 12
			// BnsTpCode char 1
			// OrdPrc double 13.2
			// ErxPrcCndiTpCode char 1

			return true;
		}
	}

	public partial class XQCEXAQ21200OutBlock2 : XingBlock
	{
		/// <summary>
		/// CEXAQ21200OutBlock2
		/// </summary>
		public const string _blockName = "CEXAQ21200OutBlock2";
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
		/// CEXAQ21200OutBlock2
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CEXAQ21200OutBlock2
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
		/// 조회일
		/// </summary>
		[XAQueryFieldAttribute("조회일")]
		public string QryDt;
		/// <summary>
		/// 현재가
		/// </summary>
		[XAQueryFieldAttribute("현재가")]
		public double NowPrc;
		/// <summary>
		/// 주문가능수량
		/// </summary>
		[XAQueryFieldAttribute("주문가능수량")]
		public long OrdAbleQty;
		/// <summary>
		/// 신규주문가능수량
		/// </summary>
		[XAQueryFieldAttribute("신규주문가능수량")]
		public long NewOrdAbleQty;
		/// <summary>
		/// 청산주문가능수량
		/// </summary>
		[XAQueryFieldAttribute("청산주문가능수량")]
		public long LqdtOrdAbleQty;
		/// <summary>
		/// 사용예정증거금액
		/// </summary>
		[XAQueryFieldAttribute("사용예정증거금액")]
		public long UsePreargMgn;
		/// <summary>
		/// 사용예정현금증거금액
		/// </summary>
		[XAQueryFieldAttribute("사용예정현금증거금액")]
		public long UsePreargMnyMgn;
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
			/// 조회일
			/// </summary>
			public const string QryDt = "QryDt";
			/// <summary>
			/// 현재가
			/// </summary>
			public const string NowPrc = "NowPrc";
			/// <summary>
			/// 주문가능수량
			/// </summary>
			public const string OrdAbleQty = "OrdAbleQty";
			/// <summary>
			/// 신규주문가능수량
			/// </summary>
			public const string NewOrdAbleQty = "NewOrdAbleQty";
			/// <summary>
			/// 청산주문가능수량
			/// </summary>
			public const string LqdtOrdAbleQty = "LqdtOrdAbleQty";
			/// <summary>
			/// 사용예정증거금액
			/// </summary>
			public const string UsePreargMgn = "UsePreargMgn";
			/// <summary>
			/// 사용예정현금증거금액
			/// </summary>
			public const string UsePreargMnyMgn = "UsePreargMnyMgn";
			/// <summary>
			/// 주문가능금액
			/// </summary>
			public const string OrdAbleAmt = "OrdAbleAmt";
			/// <summary>
			/// 현금주문가능금액
			/// </summary>
			public const string MnyOrdAbleAmt = "MnyOrdAbleAmt";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.AcntNm,
			F.QryDt,
			F.NowPrc,
			F.OrdAbleQty,
			F.NewOrdAbleQty,
			F.LqdtOrdAbleQty,
			F.UsePreargMgn,
			F.UsePreargMnyMgn,
			F.OrdAbleAmt,
			F.MnyOrdAbleAmt,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["AcntNm"] = new XAQueryFieldInfo("char", AcntNm, AcntNm, "계좌명", (decimal)40);
			dict["QryDt"] = new XAQueryFieldInfo("char", QryDt, QryDt, "조회일", (decimal)8);
			dict["NowPrc"] = new XAQueryFieldInfo("double", NowPrc, NowPrc.ToString("000000000000000.00"), "현재가", (decimal)15.2);
			dict["OrdAbleQty"] = new XAQueryFieldInfo("long", OrdAbleQty, OrdAbleQty.ToString("d16"), "주문가능수량", (decimal)16);
			dict["NewOrdAbleQty"] = new XAQueryFieldInfo("long", NewOrdAbleQty, NewOrdAbleQty.ToString("d16"), "신규주문가능수량", (decimal)16);
			dict["LqdtOrdAbleQty"] = new XAQueryFieldInfo("long", LqdtOrdAbleQty, LqdtOrdAbleQty.ToString("d16"), "청산주문가능수량", (decimal)16);
			dict["UsePreargMgn"] = new XAQueryFieldInfo("long", UsePreargMgn, UsePreargMgn.ToString("d16"), "사용예정증거금액", (decimal)16);
			dict["UsePreargMnyMgn"] = new XAQueryFieldInfo("long", UsePreargMnyMgn, UsePreargMnyMgn.ToString("d16"), "사용예정현금증거금액", (decimal)16);
			dict["OrdAbleAmt"] = new XAQueryFieldInfo("long", OrdAbleAmt, OrdAbleAmt.ToString("d16"), "주문가능금액", (decimal)16);
			dict["MnyOrdAbleAmt"] = new XAQueryFieldInfo("long", MnyOrdAbleAmt, MnyOrdAbleAmt.ToString("d16"), "현금주문가능금액", (decimal)16);

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

				case "QryDt":
					this.QryDt = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "NowPrc":
					this.NowPrc = fieldInfo.FieldValue.ParseDouble("NowPrc");
				break;

				case "OrdAbleQty":
					this.OrdAbleQty = fieldInfo.FieldValue.ParseLong("OrdAbleQty");
				break;

				case "NewOrdAbleQty":
					this.NewOrdAbleQty = fieldInfo.FieldValue.ParseLong("NewOrdAbleQty");
				break;

				case "LqdtOrdAbleQty":
					this.LqdtOrdAbleQty = fieldInfo.FieldValue.ParseLong("LqdtOrdAbleQty");
				break;

				case "UsePreargMgn":
					this.UsePreargMgn = fieldInfo.FieldValue.ParseLong("UsePreargMgn");
				break;

				case "UsePreargMnyMgn":
					this.UsePreargMnyMgn = fieldInfo.FieldValue.ParseLong("UsePreargMnyMgn");
				break;

				case "OrdAbleAmt":
					this.OrdAbleAmt = fieldInfo.FieldValue.ParseLong("OrdAbleAmt");
				break;

				case "MnyOrdAbleAmt":
					this.MnyOrdAbleAmt = fieldInfo.FieldValue.ParseLong("MnyOrdAbleAmt");
				break;


			}
		}

		public static XQCEXAQ21200OutBlock2 FromQuery(XQCEXAQ21200 query)
		{
			XQCEXAQ21200OutBlock2 block = new XQCEXAQ21200OutBlock2();
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
				block.QryDt = query.GetFieldData(block.GetBlockName(), "QryDt", 0).TrimEnd('?'); // char 8
				block.NowPrc = query.GetFieldData(block.GetBlockName(), "NowPrc", 0).ParseDouble("NowPrc"); // double 15.2
				block.OrdAbleQty = query.GetFieldData(block.GetBlockName(), "OrdAbleQty", 0).ParseLong("OrdAbleQty"); // long 16
				block.NewOrdAbleQty = query.GetFieldData(block.GetBlockName(), "NewOrdAbleQty", 0).ParseLong("NewOrdAbleQty"); // long 16
				block.LqdtOrdAbleQty = query.GetFieldData(block.GetBlockName(), "LqdtOrdAbleQty", 0).ParseLong("LqdtOrdAbleQty"); // long 16
				block.UsePreargMgn = query.GetFieldData(block.GetBlockName(), "UsePreargMgn", 0).ParseLong("UsePreargMgn"); // long 16
				block.UsePreargMnyMgn = query.GetFieldData(block.GetBlockName(), "UsePreargMnyMgn", 0).ParseLong("UsePreargMnyMgn"); // long 16
				block.OrdAbleAmt = query.GetFieldData(block.GetBlockName(), "OrdAbleAmt", 0).ParseLong("OrdAbleAmt"); // long 16
				block.MnyOrdAbleAmt = query.GetFieldData(block.GetBlockName(), "MnyOrdAbleAmt", 0).ParseLong("MnyOrdAbleAmt"); // long 16

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
			if (QryDt?.Length > 8) return false; // char 8
			// NowPrc double 15.2
			if (OrdAbleQty.ToString().Length > 16) return false; // long 16
			if (NewOrdAbleQty.ToString().Length > 16) return false; // long 16
			if (LqdtOrdAbleQty.ToString().Length > 16) return false; // long 16
			if (UsePreargMgn.ToString().Length > 16) return false; // long 16
			if (UsePreargMnyMgn.ToString().Length > 16) return false; // long 16
			if (OrdAbleAmt.ToString().Length > 16) return false; // long 16
			if (MnyOrdAbleAmt.ToString().Length > 16) return false; // long 16

			return true;
		}
	}

	public partial class XQCEXAQ21200 : XingQuery
	{
		/// <summary>
		/// CEXAQ21200
		/// </summary>
		public const string _typeName = "CEXAQ21200";
		/// <summary>
		/// 유렉스 주문가능 수량/금액 조회
		/// </summary>
		public const string _typeDesc = "유렉스 주문가능 수량/금액 조회";
		/// <summary>
		/// CEXAQ21200
		/// </summary>
		public const string _service = "CEXAQ21200";
		/// <summary>
		/// B
		/// </summary>
		public const string _headType = "B";
		/// <summary>
		/// 이시종
		/// </summary>
		public const string _creator = "이시종";
		/// <summary>
		/// 2012/07/06 14:21:09
		/// </summary>
		public const string _createdDate = "2012/07/06 14:21:09";
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
		/// CEXAQ21200
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 유렉스 주문가능 수량/금액 조회
		/// </summary>
		public string TypeDesc => _typeDesc;
		/// <summary>
		/// CEXAQ21200
		/// </summary>
		public string Service => _service;
		/// <summary>
		/// B
		/// </summary>
		public string HeadType => _headType;
		/// <summary>
		/// 이시종
		/// </summary>
		public string Creator => _creator;
		/// <summary>
		/// 2012/07/06 14:21:09
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

		public XQCEXAQ21200() : base("CEXAQ21200") { }


		public bool SetFields(XQCEXAQ21200InBlock1 block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "RecCnt", 0, block.RecCnt.ToString("d5")); // long 5
			_xaQuery.SetFieldData(block.GetBlockName(), "AcntNo", 0, block.AcntNo); // char 20
			_xaQuery.SetFieldData(block.GetBlockName(), "Pwd", 0, block.Pwd); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "QryTp", 0, block.QryTp.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "OrdAmt", 0, block.OrdAmt.ToString("d16")); // long 16
			_xaQuery.SetFieldData(block.GetBlockName(), "RatVal", 0, block.RatVal.ToString("0000000000000000000.00000000")); // double 19.8
			_xaQuery.SetFieldData(block.GetBlockName(), "FnoIsuNo", 0, block.FnoIsuNo); // char 12
			_xaQuery.SetFieldData(block.GetBlockName(), "BnsTpCode", 0, block.BnsTpCode.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "OrdPrc", 0, block.OrdPrc.ToString("0000000000000.00")); // double 13.2
			_xaQuery.SetFieldData(block.GetBlockName(), "ErxPrcCndiTpCode", 0, block.ErxPrcCndiTpCode.ToString()); // char 1

			return true;
		}

		public XQCEXAQ21200OutBlock1 GetBlock1()
		{
			XQCEXAQ21200OutBlock1 instance = XQCEXAQ21200OutBlock1.FromQuery(this);
			return instance;

		}

		public XQCEXAQ21200OutBlock2 GetBlock2()
		{
			XQCEXAQ21200OutBlock2 instance = XQCEXAQ21200OutBlock2.FromQuery(this);
			return instance;

		}


	}

}
