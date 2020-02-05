using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQCEXAQ21100InBlock1 : XingBlock
	{
		/// <summary>
		/// CEXAQ21100InBlock1
		/// </summary>
		public const string _blockName = "CEXAQ21100InBlock1";
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
		/// CEXAQ21100InBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CEXAQ21100InBlock1
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
		/// 지점번호
		/// </summary>
		[XAQueryFieldAttribute("지점번호")]
		public string AcntNo;
		/// <summary>
		/// 비밀번호
		/// </summary>
		[XAQueryFieldAttribute("비밀번호")]
		public string Pwd;
		/// <summary>
		/// 체결구분
		/// </summary>
		[XAQueryFieldAttribute("체결구분")]
		public char PrdtExecTpCode;
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
			/// 지점번호
			/// </summary>
			public const string AcntNo = "AcntNo";
			/// <summary>
			/// 비밀번호
			/// </summary>
			public const string Pwd = "Pwd";
			/// <summary>
			/// 체결구분
			/// </summary>
			public const string PrdtExecTpCode = "PrdtExecTpCode";
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
			F.PrdtExecTpCode,
			F.StnlnSeqTp,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["ChoicInptTpCode"] = new XAQueryFieldInfo("char", ChoicInptTpCode, ChoicInptTpCode.ToString(), "선택입력구분", (decimal)1);
			dict["AcntNo"] = new XAQueryFieldInfo("char", AcntNo, AcntNo, "지점번호", (decimal)20);
			dict["Pwd"] = new XAQueryFieldInfo("char", Pwd, Pwd, "비밀번호", (decimal)8);
			dict["PrdtExecTpCode"] = new XAQueryFieldInfo("char", PrdtExecTpCode, PrdtExecTpCode.ToString(), "체결구분", (decimal)1);
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

				case "PrdtExecTpCode":
					this.PrdtExecTpCode = fieldInfo.FieldValue.FirstOrDefault();
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
			// PrdtExecTpCode char 1
			// StnlnSeqTp char 1

			return true;
		}
	}

	public partial class XQCEXAQ21100OutBlock1 : XingBlock
	{
		/// <summary>
		/// CEXAQ21100OutBlock1
		/// </summary>
		public const string _blockName = "CEXAQ21100OutBlock1";
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
		/// CEXAQ21100OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CEXAQ21100OutBlock1
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
		/// 지점번호
		/// </summary>
		[XAQueryFieldAttribute("지점번호")]
		public string AcntNo;
		/// <summary>
		/// 비밀번호
		/// </summary>
		[XAQueryFieldAttribute("비밀번호")]
		public string Pwd;
		/// <summary>
		/// 체결구분
		/// </summary>
		[XAQueryFieldAttribute("체결구분")]
		public char PrdtExecTpCode;
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
			/// 지점번호
			/// </summary>
			public const string AcntNo = "AcntNo";
			/// <summary>
			/// 비밀번호
			/// </summary>
			public const string Pwd = "Pwd";
			/// <summary>
			/// 체결구분
			/// </summary>
			public const string PrdtExecTpCode = "PrdtExecTpCode";
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
			F.PrdtExecTpCode,
			F.StnlnSeqTp,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["ChoicInptTpCode"] = new XAQueryFieldInfo("char", ChoicInptTpCode, ChoicInptTpCode.ToString(), "선택입력구분", (decimal)1);
			dict["AcntNo"] = new XAQueryFieldInfo("char", AcntNo, AcntNo, "지점번호", (decimal)20);
			dict["Pwd"] = new XAQueryFieldInfo("char", Pwd, Pwd, "비밀번호", (decimal)8);
			dict["PrdtExecTpCode"] = new XAQueryFieldInfo("char", PrdtExecTpCode, PrdtExecTpCode.ToString(), "체결구분", (decimal)1);
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

				case "PrdtExecTpCode":
					this.PrdtExecTpCode = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "StnlnSeqTp":
					this.StnlnSeqTp = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public static XQCEXAQ21100OutBlock1 FromQuery(XQCEXAQ21100 query)
		{
			XQCEXAQ21100OutBlock1 block = new XQCEXAQ21100OutBlock1();
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
				block.PrdtExecTpCode = query.GetFieldData(block.GetBlockName(), "PrdtExecTpCode", 0).FirstOrDefault(); // char 1
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
			// PrdtExecTpCode char 1
			// StnlnSeqTp char 1

			return true;
		}
	}

	public partial class XQCEXAQ21100OutBlock2 : XingBlock
	{
		/// <summary>
		/// CEXAQ21100OutBlock2
		/// </summary>
		public const string _blockName = "CEXAQ21100OutBlock2";
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
		/// CEXAQ21100OutBlock2
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CEXAQ21100OutBlock2
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
		/// 주문수량
		/// </summary>
		[XAQueryFieldAttribute("주문수량")]
		public long OrdQty;
		/// <summary>
		/// 체결수량
		/// </summary>
		[XAQueryFieldAttribute("체결수량")]
		public long ExecQty;

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
			/// 주문수량
			/// </summary>
			public const string OrdQty = "OrdQty";
			/// <summary>
			/// 체결수량
			/// </summary>
			public const string ExecQty = "ExecQty";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.AcntNm,
			F.OrdQty,
			F.ExecQty,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["AcntNm"] = new XAQueryFieldInfo("char", AcntNm, AcntNm, "계좌명", (decimal)40);
			dict["OrdQty"] = new XAQueryFieldInfo("long", OrdQty, OrdQty.ToString("d16"), "주문수량", (decimal)16);
			dict["ExecQty"] = new XAQueryFieldInfo("long", ExecQty, ExecQty.ToString("d16"), "체결수량", (decimal)16);

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

				case "OrdQty":
					this.OrdQty = fieldInfo.FieldValue.ParseLong("OrdQty");
				break;

				case "ExecQty":
					this.ExecQty = fieldInfo.FieldValue.ParseLong("ExecQty");
				break;


			}
		}

		public static XQCEXAQ21100OutBlock2 FromQuery(XQCEXAQ21100 query)
		{
			XQCEXAQ21100OutBlock2 block = new XQCEXAQ21100OutBlock2();
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
				block.OrdQty = query.GetFieldData(block.GetBlockName(), "OrdQty", 0).ParseLong("OrdQty"); // long 16
				block.ExecQty = query.GetFieldData(block.GetBlockName(), "ExecQty", 0).ParseLong("ExecQty"); // long 16

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
			if (OrdQty.ToString().Length > 16) return false; // long 16
			if (ExecQty.ToString().Length > 16) return false; // long 16

			return true;
		}
	}

	public partial class XQCEXAQ21100OutBlock3 : XingBlock
	{
		/// <summary>
		/// CEXAQ21100OutBlock3
		/// </summary>
		public const string _blockName = "CEXAQ21100OutBlock3";
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
		/// CEXAQ21100OutBlock3
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CEXAQ21100OutBlock3
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
		/// 선물옵션종목번호
		/// </summary>
		[XAQueryFieldAttribute("선물옵션종목번호")]
		public string FnoIsuNo;
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
		/// 선물옵션호가유형명
		/// </summary>
		[XAQueryFieldAttribute("선물옵션호가유형명")]
		public string FnoOrdprcPtnNm;
		/// <summary>
		/// 주문조건가격
		/// </summary>
		[XAQueryFieldAttribute("주문조건가격")]
		public double OrdCndiPrc;
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
		/// 주문구분명
		/// </summary>
		[XAQueryFieldAttribute("주문구분명")]
		public string OrdTpNm;
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
		/// 미체결수량
		/// </summary>
		[XAQueryFieldAttribute("미체결수량")]
		public long UnercQty;
		/// <summary>
		/// 통신매체코드
		/// </summary>
		[XAQueryFieldAttribute("통신매체코드")]
		public string CommdaCode;
		/// <summary>
		/// 통신매체명
		/// </summary>
		[XAQueryFieldAttribute("통신매체명")]
		public string CommdaNm;

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
			/// 유렉스가격조건구분코드
			/// </summary>
			public const string ErxPrcCndiTpCode = "ErxPrcCndiTpCode";
			/// <summary>
			/// 선물옵션호가유형명
			/// </summary>
			public const string FnoOrdprcPtnNm = "FnoOrdprcPtnNm";
			/// <summary>
			/// 주문조건가격
			/// </summary>
			public const string OrdCndiPrc = "OrdCndiPrc";
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
			/// 체결가
			/// </summary>
			public const string ExecPrc = "ExecPrc";
			/// <summary>
			/// 체결수량
			/// </summary>
			public const string ExecQty = "ExecQty";
			/// <summary>
			/// 미체결수량
			/// </summary>
			public const string UnercQty = "UnercQty";
			/// <summary>
			/// 통신매체코드
			/// </summary>
			public const string CommdaCode = "CommdaCode";
			/// <summary>
			/// 통신매체명
			/// </summary>
			public const string CommdaNm = "CommdaNm";
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
			F.ErxPrcCndiTpCode,
			F.FnoOrdprcPtnNm,
			F.OrdCndiPrc,
			F.OrdPrc,
			F.OrdQty,
			F.OrdTpNm,
			F.ExecPrc,
			F.ExecQty,
			F.UnercQty,
			F.CommdaCode,
			F.CommdaNm,
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
			dict["ErxPrcCndiTpCode"] = new XAQueryFieldInfo("char", ErxPrcCndiTpCode, ErxPrcCndiTpCode.ToString(), "유렉스가격조건구분코드", (decimal)1);
			dict["FnoOrdprcPtnNm"] = new XAQueryFieldInfo("char", FnoOrdprcPtnNm, FnoOrdprcPtnNm, "선물옵션호가유형명", (decimal)40);
			dict["OrdCndiPrc"] = new XAQueryFieldInfo("double", OrdCndiPrc, OrdCndiPrc.ToString("0000000000000000000000000.00000000"), "주문조건가격", (decimal)25.8);
			dict["OrdPrc"] = new XAQueryFieldInfo("double", OrdPrc, OrdPrc.ToString("0000000000000.00"), "주문가", (decimal)13.2);
			dict["OrdQty"] = new XAQueryFieldInfo("long", OrdQty, OrdQty.ToString("d16"), "주문수량", (decimal)16);
			dict["OrdTpNm"] = new XAQueryFieldInfo("char", OrdTpNm, OrdTpNm, "주문구분명", (decimal)10);
			dict["ExecPrc"] = new XAQueryFieldInfo("double", ExecPrc, ExecPrc.ToString("0000000000000.00"), "체결가", (decimal)13.2);
			dict["ExecQty"] = new XAQueryFieldInfo("long", ExecQty, ExecQty.ToString("d16"), "체결수량", (decimal)16);
			dict["UnercQty"] = new XAQueryFieldInfo("long", UnercQty, UnercQty.ToString("d16"), "미체결수량", (decimal)16);
			dict["CommdaCode"] = new XAQueryFieldInfo("char", CommdaCode, CommdaCode, "통신매체코드", (decimal)2);
			dict["CommdaNm"] = new XAQueryFieldInfo("char", CommdaNm, CommdaNm, "통신매체명", (decimal)40);

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

				case "ErxPrcCndiTpCode":
					this.ErxPrcCndiTpCode = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "FnoOrdprcPtnNm":
					this.FnoOrdprcPtnNm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "OrdCndiPrc":
					this.OrdCndiPrc = fieldInfo.FieldValue.ParseDouble("OrdCndiPrc");
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

				case "ExecPrc":
					this.ExecPrc = fieldInfo.FieldValue.ParseDouble("ExecPrc");
				break;

				case "ExecQty":
					this.ExecQty = fieldInfo.FieldValue.ParseLong("ExecQty");
				break;

				case "UnercQty":
					this.UnercQty = fieldInfo.FieldValue.ParseLong("UnercQty");
				break;

				case "CommdaCode":
					this.CommdaCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "CommdaNm":
					this.CommdaNm = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQCEXAQ21100OutBlock3[] ListFromQuery(XQCEXAQ21100 query)
		{
			int count = query.GetBlockCount(XQCEXAQ21100OutBlock3.BlockName);
			List<XQCEXAQ21100OutBlock3> list = new List<XQCEXAQ21100OutBlock3>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQCEXAQ21100OutBlock3 block = new XQCEXAQ21100OutBlock3();
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
					block.ErxPrcCndiTpCode = query.GetFieldData(block.GetBlockName(), "ErxPrcCndiTpCode", i).FirstOrDefault(); // char 1
					block.FnoOrdprcPtnNm = query.GetFieldData(block.GetBlockName(), "FnoOrdprcPtnNm", i).TrimEnd('?'); // char 40
					block.OrdCndiPrc = query.GetFieldData(block.GetBlockName(), "OrdCndiPrc", i).ParseDouble("OrdCndiPrc"); // double 25.8
					block.OrdPrc = query.GetFieldData(block.GetBlockName(), "OrdPrc", i).ParseDouble("OrdPrc"); // double 13.2
					block.OrdQty = query.GetFieldData(block.GetBlockName(), "OrdQty", i).ParseLong("OrdQty"); // long 16
					block.OrdTpNm = query.GetFieldData(block.GetBlockName(), "OrdTpNm", i).TrimEnd('?'); // char 10
					block.ExecPrc = query.GetFieldData(block.GetBlockName(), "ExecPrc", i).ParseDouble("ExecPrc"); // double 13.2
					block.ExecQty = query.GetFieldData(block.GetBlockName(), "ExecQty", i).ParseLong("ExecQty"); // long 16
					block.UnercQty = query.GetFieldData(block.GetBlockName(), "UnercQty", i).ParseLong("UnercQty"); // long 16
					block.CommdaCode = query.GetFieldData(block.GetBlockName(), "CommdaCode", i).TrimEnd('?'); // char 2
					block.CommdaNm = query.GetFieldData(block.GetBlockName(), "CommdaNm", i).TrimEnd('?'); // char 40

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
			// ErxPrcCndiTpCode char 1
			if (FnoOrdprcPtnNm?.Length > 40) return false; // char 40
			// OrdCndiPrc double 25.8
			// OrdPrc double 13.2
			if (OrdQty.ToString().Length > 16) return false; // long 16
			if (OrdTpNm?.Length > 10) return false; // char 10
			// ExecPrc double 13.2
			if (ExecQty.ToString().Length > 16) return false; // long 16
			if (UnercQty.ToString().Length > 16) return false; // long 16
			if (CommdaCode?.Length > 2) return false; // char 2
			if (CommdaNm?.Length > 40) return false; // char 40

			return true;
		}
	}

	/// <summary>
	/// 유렉스 주문체결내역조회
	/// </summary>
	public partial class XQCEXAQ21100 : XingQuery
	{
		/// <summary>
		/// CEXAQ21100
		/// </summary>
		public const string _typeName = "CEXAQ21100";
		/// <summary>
		/// 유렉스 주문체결내역조회
		/// </summary>
		public const string _typeDesc = "유렉스 주문체결내역조회";
		/// <summary>
		/// CEXAQ21100
		/// </summary>
		public const string _service = "CEXAQ21100";
		/// <summary>
		/// B
		/// </summary>
		public const string _headType = "B";
		/// <summary>
		/// 이시종
		/// </summary>
		public const string _creator = "이시종";
		/// <summary>
		/// 2012/07/02 21:01:29
		/// </summary>
		public const string _createdDate = "2012/07/02 21:01:29";
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
		/// CEXAQ21100
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 유렉스 주문체결내역조회
		/// </summary>
		public string TypeDesc => _typeDesc;
		/// <summary>
		/// CEXAQ21100
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
		/// 2012/07/02 21:01:29
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

		public XQCEXAQ21100() : base("CEXAQ21100") { }



		public bool SetBlock(XQCEXAQ21100InBlock1 block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "RecCnt", 0, block.RecCnt.ToString("d5")); // long 5
			_xaQuery.SetFieldData(block.GetBlockName(), "ChoicInptTpCode", 0, block.ChoicInptTpCode.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "AcntNo", 0, block.AcntNo); // char 20
			_xaQuery.SetFieldData(block.GetBlockName(), "Pwd", 0, block.Pwd); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "PrdtExecTpCode", 0, block.PrdtExecTpCode.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "StnlnSeqTp", 0, block.StnlnSeqTp.ToString()); // char 1

			return true;
		}

		public XQCEXAQ21100OutBlock1 GetBlock1()
		{
			XQCEXAQ21100OutBlock1 instance = XQCEXAQ21100OutBlock1.FromQuery(this);
			return instance;

		}

		public XQCEXAQ21100OutBlock2 GetBlock2()
		{
			XQCEXAQ21100OutBlock2 instance = XQCEXAQ21100OutBlock2.FromQuery(this);
			return instance;

		}

		public XQCEXAQ21100OutBlock3[] GetBlock3s()
		{
			XQCEXAQ21100OutBlock3[] instance = XQCEXAQ21100OutBlock3.ListFromQuery(this);
			return instance;

		}


	}

}
