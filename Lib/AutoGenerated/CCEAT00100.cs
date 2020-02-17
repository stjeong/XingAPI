using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQCCEAT00100InBlock1 : XingBlock
	{
		/// <summary>
		/// CCEAT00100InBlock1
		/// </summary>
		public const string _blockName = "CCEAT00100InBlock1";
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
		/// CCEAT00100InBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CCEAT00100InBlock1
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
		/// 선물옵션종목번호
		/// </summary>
		[XAQueryFieldAttribute("FnoIsuNo", "선물옵션종목번호", "char", "12")]
		public string FnoIsuNo;
		/// <summary>
		/// 매매구분
		/// </summary>
		[XAQueryFieldAttribute("BnsTpCode", "매매구분", "char", "1")]
		public char BnsTpCode;
		/// <summary>
		/// 선물옵션호가유형코드
		/// </summary>
		[XAQueryFieldAttribute("FnoOrdprcPtnCode", "선물옵션호가유형코드", "char", "2")]
		public string FnoOrdprcPtnCode;
		/// <summary>
		/// 주문가격
		/// </summary>
		[XAQueryFieldAttribute("OrdPrc", "주문가격", "double", "15.2")]
		public double OrdPrc;
		/// <summary>
		/// 주문수량
		/// </summary>
		[XAQueryFieldAttribute("OrdQty", "주문수량", "long", "16")]
		public long OrdQty;

		public static class F
		{
			/// <summary>
			/// 계좌번호
			/// </summary>
			public const string AcntNo = "AcntNo";
			/// <summary>
			/// 비밀번호
			/// </summary>
			public const string Pwd = "Pwd";
			/// <summary>
			/// 선물옵션종목번호
			/// </summary>
			public const string FnoIsuNo = "FnoIsuNo";
			/// <summary>
			/// 매매구분
			/// </summary>
			public const string BnsTpCode = "BnsTpCode";
			/// <summary>
			/// 선물옵션호가유형코드
			/// </summary>
			public const string FnoOrdprcPtnCode = "FnoOrdprcPtnCode";
			/// <summary>
			/// 주문가격
			/// </summary>
			public const string OrdPrc = "OrdPrc";
			/// <summary>
			/// 주문수량
			/// </summary>
			public const string OrdQty = "OrdQty";
		}

		public static string[] AllFields = new string[]
		{
			F.AcntNo,
			F.Pwd,
			F.FnoIsuNo,
			F.BnsTpCode,
			F.FnoOrdprcPtnCode,
			F.OrdPrc,
			F.OrdQty,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["AcntNo"] = new XAQueryFieldInfo("char", AcntNo, AcntNo, "계좌번호", (decimal)20);
			dict["Pwd"] = new XAQueryFieldInfo("char", Pwd, Pwd, "비밀번호", (decimal)8);
			dict["FnoIsuNo"] = new XAQueryFieldInfo("char", FnoIsuNo, FnoIsuNo, "선물옵션종목번호", (decimal)12);
			dict["BnsTpCode"] = new XAQueryFieldInfo("char", BnsTpCode, BnsTpCode.ToString(), "매매구분", (decimal)1);
			dict["FnoOrdprcPtnCode"] = new XAQueryFieldInfo("char", FnoOrdprcPtnCode, FnoOrdprcPtnCode, "선물옵션호가유형코드", (decimal)2);
			dict["OrdPrc"] = new XAQueryFieldInfo("double", OrdPrc, OrdPrc.ToString("000000000000000.00"), "주문가격", (decimal)15.2);
			dict["OrdQty"] = new XAQueryFieldInfo("long", OrdQty, OrdQty.ToString("d16"), "주문수량", (decimal)16);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "AcntNo":
					this.AcntNo = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "Pwd":
					this.Pwd = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "FnoIsuNo":
					this.FnoIsuNo = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "BnsTpCode":
					this.BnsTpCode = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "FnoOrdprcPtnCode":
					this.FnoOrdprcPtnCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "OrdPrc":
					this.OrdPrc = fieldInfo.FieldValue.ParseDouble("OrdPrc");
				break;

				case "OrdQty":
					this.OrdQty = fieldInfo.FieldValue.ParseLong("OrdQty");
				break;


			}
		}

		public bool VerifyData()
		{
			if (AcntNo?.Length > 20) return false; // char 20
			if (Pwd?.Length > 8) return false; // char 8
			if (FnoIsuNo?.Length > 12) return false; // char 12
			// BnsTpCode char 1
			if (FnoOrdprcPtnCode?.Length > 2) return false; // char 2
			// OrdPrc double 15.2
			if (OrdQty.ToString().Length > 16) return false; // long 16

			return true;
		}
	}

	public partial class XQCCEAT00100OutBlock1 : XingBlock
	{
		/// <summary>
		/// CCEAT00100OutBlock1
		/// </summary>
		public const string _blockName = "CCEAT00100OutBlock1";
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
		/// CCEAT00100OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CCEAT00100OutBlock1
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
		/// 주문시장코드
		/// </summary>
		[XAQueryFieldAttribute("OrdMktCode", "주문시장코드", "char", "2")]
		public string OrdMktCode;
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
		/// 선물옵션종목번호
		/// </summary>
		[XAQueryFieldAttribute("FnoIsuNo", "선물옵션종목번호", "char", "12")]
		public string FnoIsuNo;
		/// <summary>
		/// 매매구분
		/// </summary>
		[XAQueryFieldAttribute("BnsTpCode", "매매구분", "char", "1")]
		public char BnsTpCode;
		/// <summary>
		/// 선물옵션주문유형코드
		/// </summary>
		[XAQueryFieldAttribute("FnoOrdPtnCode", "선물옵션주문유형코드", "char", "2")]
		public string FnoOrdPtnCode;
		/// <summary>
		/// 선물옵션호가유형코드
		/// </summary>
		[XAQueryFieldAttribute("FnoOrdprcPtnCode", "선물옵션호가유형코드", "char", "2")]
		public string FnoOrdprcPtnCode;
		/// <summary>
		/// 선물옵션거래유형코드
		/// </summary>
		[XAQueryFieldAttribute("FnoTrdPtnCode", "선물옵션거래유형코드", "char", "2")]
		public string FnoTrdPtnCode;
		/// <summary>
		/// 주문가격
		/// </summary>
		[XAQueryFieldAttribute("OrdPrc", "주문가격", "double", "15.2")]
		public double OrdPrc;
		/// <summary>
		/// 주문수량
		/// </summary>
		[XAQueryFieldAttribute("OrdQty", "주문수량", "long", "16")]
		public long OrdQty;
		/// <summary>
		/// 통신매체코드
		/// </summary>
		[XAQueryFieldAttribute("CommdaCode", "통신매체코드", "char", "2")]
		public string CommdaCode;
		/// <summary>
		/// 협의매매완료시각
		/// </summary>
		[XAQueryFieldAttribute("DscusBnsCmpltTime", "협의매매완료시각", "char", "9")]
		public string DscusBnsCmpltTime;
		/// <summary>
		/// 그룹ID
		/// </summary>
		[XAQueryFieldAttribute("GrpId", "그룹ID", "char", "20")]
		public string GrpId;
		/// <summary>
		/// 주문일련번호
		/// </summary>
		[XAQueryFieldAttribute("OrdSeqno", "주문일련번호", "long", "10")]
		public long OrdSeqno;
		/// <summary>
		/// 포트폴리오번호
		/// </summary>
		[XAQueryFieldAttribute("PtflNo", "포트폴리오번호", "long", "10")]
		public long PtflNo;
		/// <summary>
		/// 바스켓번호
		/// </summary>
		[XAQueryFieldAttribute("BskNo", "바스켓번호", "long", "10")]
		public long BskNo;
		/// <summary>
		/// 트렌치번호
		/// </summary>
		[XAQueryFieldAttribute("TrchNo", "트렌치번호", "long", "10")]
		public long TrchNo;
		/// <summary>
		/// 항목번호
		/// </summary>
		[XAQueryFieldAttribute("ItemNo", "항목번호", "long", "16")]
		public long ItemNo;
		/// <summary>
		/// 운용지시번호
		/// </summary>
		[XAQueryFieldAttribute("OpDrtnNo", "운용지시번호", "char", "12")]
		public string OpDrtnNo;
		/// <summary>
		/// 관리사원번호
		/// </summary>
		[XAQueryFieldAttribute("MgempNo", "관리사원번호", "char", "9")]
		public string MgempNo;
		/// <summary>
		/// 펀드ID
		/// </summary>
		[XAQueryFieldAttribute("FundId", "펀드ID", "char", "12")]
		public string FundId;
		/// <summary>
		/// 펀드주문번호
		/// </summary>
		[XAQueryFieldAttribute("FundOrdNo", "펀드주문번호", "long", "10")]
		public long FundOrdNo;

		public static class F
		{
			/// <summary>
			/// 레코드갯수
			/// </summary>
			public const string RecCnt = "RecCnt";
			/// <summary>
			/// 주문시장코드
			/// </summary>
			public const string OrdMktCode = "OrdMktCode";
			/// <summary>
			/// 계좌번호
			/// </summary>
			public const string AcntNo = "AcntNo";
			/// <summary>
			/// 비밀번호
			/// </summary>
			public const string Pwd = "Pwd";
			/// <summary>
			/// 선물옵션종목번호
			/// </summary>
			public const string FnoIsuNo = "FnoIsuNo";
			/// <summary>
			/// 매매구분
			/// </summary>
			public const string BnsTpCode = "BnsTpCode";
			/// <summary>
			/// 선물옵션주문유형코드
			/// </summary>
			public const string FnoOrdPtnCode = "FnoOrdPtnCode";
			/// <summary>
			/// 선물옵션호가유형코드
			/// </summary>
			public const string FnoOrdprcPtnCode = "FnoOrdprcPtnCode";
			/// <summary>
			/// 선물옵션거래유형코드
			/// </summary>
			public const string FnoTrdPtnCode = "FnoTrdPtnCode";
			/// <summary>
			/// 주문가격
			/// </summary>
			public const string OrdPrc = "OrdPrc";
			/// <summary>
			/// 주문수량
			/// </summary>
			public const string OrdQty = "OrdQty";
			/// <summary>
			/// 통신매체코드
			/// </summary>
			public const string CommdaCode = "CommdaCode";
			/// <summary>
			/// 협의매매완료시각
			/// </summary>
			public const string DscusBnsCmpltTime = "DscusBnsCmpltTime";
			/// <summary>
			/// 그룹ID
			/// </summary>
			public const string GrpId = "GrpId";
			/// <summary>
			/// 주문일련번호
			/// </summary>
			public const string OrdSeqno = "OrdSeqno";
			/// <summary>
			/// 포트폴리오번호
			/// </summary>
			public const string PtflNo = "PtflNo";
			/// <summary>
			/// 바스켓번호
			/// </summary>
			public const string BskNo = "BskNo";
			/// <summary>
			/// 트렌치번호
			/// </summary>
			public const string TrchNo = "TrchNo";
			/// <summary>
			/// 항목번호
			/// </summary>
			public const string ItemNo = "ItemNo";
			/// <summary>
			/// 운용지시번호
			/// </summary>
			public const string OpDrtnNo = "OpDrtnNo";
			/// <summary>
			/// 관리사원번호
			/// </summary>
			public const string MgempNo = "MgempNo";
			/// <summary>
			/// 펀드ID
			/// </summary>
			public const string FundId = "FundId";
			/// <summary>
			/// 펀드주문번호
			/// </summary>
			public const string FundOrdNo = "FundOrdNo";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.OrdMktCode,
			F.AcntNo,
			F.Pwd,
			F.FnoIsuNo,
			F.BnsTpCode,
			F.FnoOrdPtnCode,
			F.FnoOrdprcPtnCode,
			F.FnoTrdPtnCode,
			F.OrdPrc,
			F.OrdQty,
			F.CommdaCode,
			F.DscusBnsCmpltTime,
			F.GrpId,
			F.OrdSeqno,
			F.PtflNo,
			F.BskNo,
			F.TrchNo,
			F.ItemNo,
			F.OpDrtnNo,
			F.MgempNo,
			F.FundId,
			F.FundOrdNo,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["OrdMktCode"] = new XAQueryFieldInfo("char", OrdMktCode, OrdMktCode, "주문시장코드", (decimal)2);
			dict["AcntNo"] = new XAQueryFieldInfo("char", AcntNo, AcntNo, "계좌번호", (decimal)20);
			dict["Pwd"] = new XAQueryFieldInfo("char", Pwd, Pwd, "비밀번호", (decimal)8);
			dict["FnoIsuNo"] = new XAQueryFieldInfo("char", FnoIsuNo, FnoIsuNo, "선물옵션종목번호", (decimal)12);
			dict["BnsTpCode"] = new XAQueryFieldInfo("char", BnsTpCode, BnsTpCode.ToString(), "매매구분", (decimal)1);
			dict["FnoOrdPtnCode"] = new XAQueryFieldInfo("char", FnoOrdPtnCode, FnoOrdPtnCode, "선물옵션주문유형코드", (decimal)2);
			dict["FnoOrdprcPtnCode"] = new XAQueryFieldInfo("char", FnoOrdprcPtnCode, FnoOrdprcPtnCode, "선물옵션호가유형코드", (decimal)2);
			dict["FnoTrdPtnCode"] = new XAQueryFieldInfo("char", FnoTrdPtnCode, FnoTrdPtnCode, "선물옵션거래유형코드", (decimal)2);
			dict["OrdPrc"] = new XAQueryFieldInfo("double", OrdPrc, OrdPrc.ToString("000000000000000.00"), "주문가격", (decimal)15.2);
			dict["OrdQty"] = new XAQueryFieldInfo("long", OrdQty, OrdQty.ToString("d16"), "주문수량", (decimal)16);
			dict["CommdaCode"] = new XAQueryFieldInfo("char", CommdaCode, CommdaCode, "통신매체코드", (decimal)2);
			dict["DscusBnsCmpltTime"] = new XAQueryFieldInfo("char", DscusBnsCmpltTime, DscusBnsCmpltTime, "협의매매완료시각", (decimal)9);
			dict["GrpId"] = new XAQueryFieldInfo("char", GrpId, GrpId, "그룹ID", (decimal)20);
			dict["OrdSeqno"] = new XAQueryFieldInfo("long", OrdSeqno, OrdSeqno.ToString("d10"), "주문일련번호", (decimal)10);
			dict["PtflNo"] = new XAQueryFieldInfo("long", PtflNo, PtflNo.ToString("d10"), "포트폴리오번호", (decimal)10);
			dict["BskNo"] = new XAQueryFieldInfo("long", BskNo, BskNo.ToString("d10"), "바스켓번호", (decimal)10);
			dict["TrchNo"] = new XAQueryFieldInfo("long", TrchNo, TrchNo.ToString("d10"), "트렌치번호", (decimal)10);
			dict["ItemNo"] = new XAQueryFieldInfo("long", ItemNo, ItemNo.ToString("d16"), "항목번호", (decimal)16);
			dict["OpDrtnNo"] = new XAQueryFieldInfo("char", OpDrtnNo, OpDrtnNo, "운용지시번호", (decimal)12);
			dict["MgempNo"] = new XAQueryFieldInfo("char", MgempNo, MgempNo, "관리사원번호", (decimal)9);
			dict["FundId"] = new XAQueryFieldInfo("char", FundId, FundId, "펀드ID", (decimal)12);
			dict["FundOrdNo"] = new XAQueryFieldInfo("long", FundOrdNo, FundOrdNo.ToString("d10"), "펀드주문번호", (decimal)10);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "RecCnt":
					this.RecCnt = fieldInfo.FieldValue.ParseLong("RecCnt");
				break;

				case "OrdMktCode":
					this.OrdMktCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "AcntNo":
					this.AcntNo = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "Pwd":
					this.Pwd = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "FnoIsuNo":
					this.FnoIsuNo = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "BnsTpCode":
					this.BnsTpCode = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "FnoOrdPtnCode":
					this.FnoOrdPtnCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "FnoOrdprcPtnCode":
					this.FnoOrdprcPtnCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "FnoTrdPtnCode":
					this.FnoTrdPtnCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "OrdPrc":
					this.OrdPrc = fieldInfo.FieldValue.ParseDouble("OrdPrc");
				break;

				case "OrdQty":
					this.OrdQty = fieldInfo.FieldValue.ParseLong("OrdQty");
				break;

				case "CommdaCode":
					this.CommdaCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "DscusBnsCmpltTime":
					this.DscusBnsCmpltTime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "GrpId":
					this.GrpId = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "OrdSeqno":
					this.OrdSeqno = fieldInfo.FieldValue.ParseLong("OrdSeqno");
				break;

				case "PtflNo":
					this.PtflNo = fieldInfo.FieldValue.ParseLong("PtflNo");
				break;

				case "BskNo":
					this.BskNo = fieldInfo.FieldValue.ParseLong("BskNo");
				break;

				case "TrchNo":
					this.TrchNo = fieldInfo.FieldValue.ParseLong("TrchNo");
				break;

				case "ItemNo":
					this.ItemNo = fieldInfo.FieldValue.ParseLong("ItemNo");
				break;

				case "OpDrtnNo":
					this.OpDrtnNo = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "MgempNo":
					this.MgempNo = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "FundId":
					this.FundId = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "FundOrdNo":
					this.FundOrdNo = fieldInfo.FieldValue.ParseLong("FundOrdNo");
				break;


			}
		}

		public static XQCCEAT00100OutBlock1 FromQuery(XQCCEAT00100 query)
		{
			XQCCEAT00100OutBlock1 block = new XQCCEAT00100OutBlock1();
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
				block.OrdMktCode = query.GetFieldData(block.GetBlockName(), "OrdMktCode", 0).TrimEnd('?'); // char 2
				block.AcntNo = query.GetFieldData(block.GetBlockName(), "AcntNo", 0).TrimEnd('?'); // char 20
				block.Pwd = query.GetFieldData(block.GetBlockName(), "Pwd", 0).TrimEnd('?'); // char 8
				block.FnoIsuNo = query.GetFieldData(block.GetBlockName(), "FnoIsuNo", 0).TrimEnd('?'); // char 12
				block.BnsTpCode = query.GetFieldData(block.GetBlockName(), "BnsTpCode", 0).FirstOrDefault(); // char 1
				block.FnoOrdPtnCode = query.GetFieldData(block.GetBlockName(), "FnoOrdPtnCode", 0).TrimEnd('?'); // char 2
				block.FnoOrdprcPtnCode = query.GetFieldData(block.GetBlockName(), "FnoOrdprcPtnCode", 0).TrimEnd('?'); // char 2
				block.FnoTrdPtnCode = query.GetFieldData(block.GetBlockName(), "FnoTrdPtnCode", 0).TrimEnd('?'); // char 2
				block.OrdPrc = query.GetFieldData(block.GetBlockName(), "OrdPrc", 0).ParseDouble("OrdPrc"); // double 15.2
				block.OrdQty = query.GetFieldData(block.GetBlockName(), "OrdQty", 0).ParseLong("OrdQty"); // long 16
				block.CommdaCode = query.GetFieldData(block.GetBlockName(), "CommdaCode", 0).TrimEnd('?'); // char 2
				block.DscusBnsCmpltTime = query.GetFieldData(block.GetBlockName(), "DscusBnsCmpltTime", 0).TrimEnd('?'); // char 9
				block.GrpId = query.GetFieldData(block.GetBlockName(), "GrpId", 0).TrimEnd('?'); // char 20
				block.OrdSeqno = query.GetFieldData(block.GetBlockName(), "OrdSeqno", 0).ParseLong("OrdSeqno"); // long 10
				block.PtflNo = query.GetFieldData(block.GetBlockName(), "PtflNo", 0).ParseLong("PtflNo"); // long 10
				block.BskNo = query.GetFieldData(block.GetBlockName(), "BskNo", 0).ParseLong("BskNo"); // long 10
				block.TrchNo = query.GetFieldData(block.GetBlockName(), "TrchNo", 0).ParseLong("TrchNo"); // long 10
				block.ItemNo = query.GetFieldData(block.GetBlockName(), "ItemNo", 0).ParseLong("ItemNo"); // long 16
				block.OpDrtnNo = query.GetFieldData(block.GetBlockName(), "OpDrtnNo", 0).TrimEnd('?'); // char 12
				block.MgempNo = query.GetFieldData(block.GetBlockName(), "MgempNo", 0).TrimEnd('?'); // char 9
				block.FundId = query.GetFieldData(block.GetBlockName(), "FundId", 0).TrimEnd('?'); // char 12
				block.FundOrdNo = query.GetFieldData(block.GetBlockName(), "FundOrdNo", 0).ParseLong("FundOrdNo"); // long 10

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (RecCnt.ToString().Length > 5) return false; // long 5
			if (OrdMktCode?.Length > 2) return false; // char 2
			if (AcntNo?.Length > 20) return false; // char 20
			if (Pwd?.Length > 8) return false; // char 8
			if (FnoIsuNo?.Length > 12) return false; // char 12
			// BnsTpCode char 1
			if (FnoOrdPtnCode?.Length > 2) return false; // char 2
			if (FnoOrdprcPtnCode?.Length > 2) return false; // char 2
			if (FnoTrdPtnCode?.Length > 2) return false; // char 2
			// OrdPrc double 15.2
			if (OrdQty.ToString().Length > 16) return false; // long 16
			if (CommdaCode?.Length > 2) return false; // char 2
			if (DscusBnsCmpltTime?.Length > 9) return false; // char 9
			if (GrpId?.Length > 20) return false; // char 20
			if (OrdSeqno.ToString().Length > 10) return false; // long 10
			if (PtflNo.ToString().Length > 10) return false; // long 10
			if (BskNo.ToString().Length > 10) return false; // long 10
			if (TrchNo.ToString().Length > 10) return false; // long 10
			if (ItemNo.ToString().Length > 16) return false; // long 16
			if (OpDrtnNo?.Length > 12) return false; // char 12
			if (MgempNo?.Length > 9) return false; // char 9
			if (FundId?.Length > 12) return false; // char 12
			if (FundOrdNo.ToString().Length > 10) return false; // long 10

			return true;
		}
	}

	public partial class XQCCEAT00100OutBlock2 : XingBlock
	{
		/// <summary>
		/// CCEAT00100OutBlock2
		/// </summary>
		public const string _blockName = "CCEAT00100OutBlock2";
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
		/// CCEAT00100OutBlock2
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CCEAT00100OutBlock2
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
		/// 주문번호
		/// </summary>
		[XAQueryFieldAttribute("OrdNo", "주문번호", "long", "10")]
		public long OrdNo;
		/// <summary>
		/// 지점명
		/// </summary>
		[XAQueryFieldAttribute("BrnNm", "지점명", "char", "40")]
		public string BrnNm;
		/// <summary>
		/// 계좌명
		/// </summary>
		[XAQueryFieldAttribute("AcntNm", "계좌명", "char", "40")]
		public string AcntNm;
		/// <summary>
		/// 종목명
		/// </summary>
		[XAQueryFieldAttribute("IsuNm", "종목명", "char", "50")]
		public string IsuNm;
		/// <summary>
		/// 주문가능금액
		/// </summary>
		[XAQueryFieldAttribute("OrdAbleAmt", "주문가능금액", "long", "16")]
		public long OrdAbleAmt;
		/// <summary>
		/// 현금주문가능금액
		/// </summary>
		[XAQueryFieldAttribute("MnyOrdAbleAmt", "현금주문가능금액", "long", "16")]
		public long MnyOrdAbleAmt;
		/// <summary>
		/// 주문증거금
		/// </summary>
		[XAQueryFieldAttribute("OrdMgn", "주문증거금", "long", "16")]
		public long OrdMgn;
		/// <summary>
		/// 현금주문증거금
		/// </summary>
		[XAQueryFieldAttribute("MnyOrdMgn", "현금주문증거금", "long", "16")]
		public long MnyOrdMgn;
		/// <summary>
		/// 주문가능수량
		/// </summary>
		[XAQueryFieldAttribute("OrdAbleQty", "주문가능수량", "long", "16")]
		public long OrdAbleQty;

		public static class F
		{
			/// <summary>
			/// 레코드갯수
			/// </summary>
			public const string RecCnt = "RecCnt";
			/// <summary>
			/// 주문번호
			/// </summary>
			public const string OrdNo = "OrdNo";
			/// <summary>
			/// 지점명
			/// </summary>
			public const string BrnNm = "BrnNm";
			/// <summary>
			/// 계좌명
			/// </summary>
			public const string AcntNm = "AcntNm";
			/// <summary>
			/// 종목명
			/// </summary>
			public const string IsuNm = "IsuNm";
			/// <summary>
			/// 주문가능금액
			/// </summary>
			public const string OrdAbleAmt = "OrdAbleAmt";
			/// <summary>
			/// 현금주문가능금액
			/// </summary>
			public const string MnyOrdAbleAmt = "MnyOrdAbleAmt";
			/// <summary>
			/// 주문증거금
			/// </summary>
			public const string OrdMgn = "OrdMgn";
			/// <summary>
			/// 현금주문증거금
			/// </summary>
			public const string MnyOrdMgn = "MnyOrdMgn";
			/// <summary>
			/// 주문가능수량
			/// </summary>
			public const string OrdAbleQty = "OrdAbleQty";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.OrdNo,
			F.BrnNm,
			F.AcntNm,
			F.IsuNm,
			F.OrdAbleAmt,
			F.MnyOrdAbleAmt,
			F.OrdMgn,
			F.MnyOrdMgn,
			F.OrdAbleQty,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["OrdNo"] = new XAQueryFieldInfo("long", OrdNo, OrdNo.ToString("d10"), "주문번호", (decimal)10);
			dict["BrnNm"] = new XAQueryFieldInfo("char", BrnNm, BrnNm, "지점명", (decimal)40);
			dict["AcntNm"] = new XAQueryFieldInfo("char", AcntNm, AcntNm, "계좌명", (decimal)40);
			dict["IsuNm"] = new XAQueryFieldInfo("char", IsuNm, IsuNm, "종목명", (decimal)50);
			dict["OrdAbleAmt"] = new XAQueryFieldInfo("long", OrdAbleAmt, OrdAbleAmt.ToString("d16"), "주문가능금액", (decimal)16);
			dict["MnyOrdAbleAmt"] = new XAQueryFieldInfo("long", MnyOrdAbleAmt, MnyOrdAbleAmt.ToString("d16"), "현금주문가능금액", (decimal)16);
			dict["OrdMgn"] = new XAQueryFieldInfo("long", OrdMgn, OrdMgn.ToString("d16"), "주문증거금", (decimal)16);
			dict["MnyOrdMgn"] = new XAQueryFieldInfo("long", MnyOrdMgn, MnyOrdMgn.ToString("d16"), "현금주문증거금", (decimal)16);
			dict["OrdAbleQty"] = new XAQueryFieldInfo("long", OrdAbleQty, OrdAbleQty.ToString("d16"), "주문가능수량", (decimal)16);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "RecCnt":
					this.RecCnt = fieldInfo.FieldValue.ParseLong("RecCnt");
				break;

				case "OrdNo":
					this.OrdNo = fieldInfo.FieldValue.ParseLong("OrdNo");
				break;

				case "BrnNm":
					this.BrnNm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "AcntNm":
					this.AcntNm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "IsuNm":
					this.IsuNm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "OrdAbleAmt":
					this.OrdAbleAmt = fieldInfo.FieldValue.ParseLong("OrdAbleAmt");
				break;

				case "MnyOrdAbleAmt":
					this.MnyOrdAbleAmt = fieldInfo.FieldValue.ParseLong("MnyOrdAbleAmt");
				break;

				case "OrdMgn":
					this.OrdMgn = fieldInfo.FieldValue.ParseLong("OrdMgn");
				break;

				case "MnyOrdMgn":
					this.MnyOrdMgn = fieldInfo.FieldValue.ParseLong("MnyOrdMgn");
				break;

				case "OrdAbleQty":
					this.OrdAbleQty = fieldInfo.FieldValue.ParseLong("OrdAbleQty");
				break;


			}
		}

		public static XQCCEAT00100OutBlock2 FromQuery(XQCCEAT00100 query)
		{
			XQCCEAT00100OutBlock2 block = new XQCCEAT00100OutBlock2();
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
				block.OrdNo = query.GetFieldData(block.GetBlockName(), "OrdNo", 0).ParseLong("OrdNo"); // long 10
				block.BrnNm = query.GetFieldData(block.GetBlockName(), "BrnNm", 0).TrimEnd('?'); // char 40
				block.AcntNm = query.GetFieldData(block.GetBlockName(), "AcntNm", 0).TrimEnd('?'); // char 40
				block.IsuNm = query.GetFieldData(block.GetBlockName(), "IsuNm", 0).TrimEnd('?'); // char 50
				block.OrdAbleAmt = query.GetFieldData(block.GetBlockName(), "OrdAbleAmt", 0).ParseLong("OrdAbleAmt"); // long 16
				block.MnyOrdAbleAmt = query.GetFieldData(block.GetBlockName(), "MnyOrdAbleAmt", 0).ParseLong("MnyOrdAbleAmt"); // long 16
				block.OrdMgn = query.GetFieldData(block.GetBlockName(), "OrdMgn", 0).ParseLong("OrdMgn"); // long 16
				block.MnyOrdMgn = query.GetFieldData(block.GetBlockName(), "MnyOrdMgn", 0).ParseLong("MnyOrdMgn"); // long 16
				block.OrdAbleQty = query.GetFieldData(block.GetBlockName(), "OrdAbleQty", 0).ParseLong("OrdAbleQty"); // long 16

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (RecCnt.ToString().Length > 5) return false; // long 5
			if (OrdNo.ToString().Length > 10) return false; // long 10
			if (BrnNm?.Length > 40) return false; // char 40
			if (AcntNm?.Length > 40) return false; // char 40
			if (IsuNm?.Length > 50) return false; // char 50
			if (OrdAbleAmt.ToString().Length > 16) return false; // long 16
			if (MnyOrdAbleAmt.ToString().Length > 16) return false; // long 16
			if (OrdMgn.ToString().Length > 16) return false; // long 16
			if (MnyOrdMgn.ToString().Length > 16) return false; // long 16
			if (OrdAbleQty.ToString().Length > 16) return false; // long 16

			return true;
		}
	}

	/// <summary>
	/// CME 정상주문
	/// </summary>
	public partial class XQCCEAT00100 : XingQuery
	{
		/// <summary>
		/// CCEAT00100
		/// </summary>
		public const string _typeName = "CCEAT00100";
		/// <summary>
		/// CME 정상주문
		/// </summary>
		public const string _typeDesc = "CME 정상주문";
		/// <summary>
		/// CCEAT00100
		/// </summary>
		public const string _service = "CCEAT00100";
		/// <summary>
		/// B
		/// </summary>
		public const string _headType = "B";
		/// <summary>
		/// 이호섭
		/// </summary>
		public const string _creator = "이호섭";
		/// <summary>
		/// 2012/04/10 10:02:33
		/// </summary>
		public const string _createdDate = "2012/04/10 10:02:33";
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
		/// CCEAT00100
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// CME 정상주문
		/// </summary>
		public string TypeDesc => _typeDesc;
		/// <summary>
		/// CCEAT00100
		/// </summary>
		public string Service => _service;
		/// <summary>
		/// B
		/// </summary>
		public string HeadType => _headType;
		/// <summary>
		/// 이호섭
		/// </summary>
		public string Creator => _creator;
		/// <summary>
		/// 2012/04/10 10:02:33
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
		/// CME 정상주문
		/// </summary>
		public XQCCEAT00100() : base("CCEAT00100") { }




		public bool SetBlock(XQCCEAT00100InBlock1 block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "AcntNo", 0, block.AcntNo); // char 20
			_xaQuery.SetFieldData(block.GetBlockName(), "Pwd", 0, block.Pwd); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "FnoIsuNo", 0, block.FnoIsuNo); // char 12
			_xaQuery.SetFieldData(block.GetBlockName(), "BnsTpCode", 0, block.BnsTpCode.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "FnoOrdprcPtnCode", 0, block.FnoOrdprcPtnCode); // char 2
			_xaQuery.SetFieldData(block.GetBlockName(), "OrdPrc", 0, block.OrdPrc.ToString("000000000000000.00")); // double 15.2
			_xaQuery.SetFieldData(block.GetBlockName(), "OrdQty", 0, block.OrdQty.ToString("d16")); // long 16

			return true;
		}

		public XQCCEAT00100OutBlock1 GetBlock1()
		{
			XQCCEAT00100OutBlock1 instance = XQCCEAT00100OutBlock1.FromQuery(this);
			return instance;

		}

		public XQCCEAT00100OutBlock2 GetBlock2()
		{
			XQCCEAT00100OutBlock2 instance = XQCCEAT00100OutBlock2.FromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQCCEAT00100OutBlock1),
			typeof(XQCCEAT00100OutBlock2),

		};

	}

}
