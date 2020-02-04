using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQCSPBQ00200InBlock1 : XingBlock
	{
		/// <summary>
		/// CSPBQ00200InBlock1
		/// </summary>
		public const string _blockName = "CSPBQ00200InBlock1";
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
		/// CSPBQ00200InBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CSPBQ00200InBlock1
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
		/// 매매구분
		/// </summary>
		[XAQueryFieldAttribute("매매구분")]
		public char BnsTpCode;
		/// <summary>
		/// 계좌번호
		/// </summary>
		[XAQueryFieldAttribute("계좌번호")]
		public string AcntNo;
		/// <summary>
		/// 입력비밀번호
		/// </summary>
		[XAQueryFieldAttribute("입력비밀번호")]
		public string InptPwd;
		/// <summary>
		/// 종목번호
		/// </summary>
		[XAQueryFieldAttribute("종목번호")]
		public string IsuNo;
		/// <summary>
		/// 주문가격
		/// </summary>
		[XAQueryFieldAttribute("주문가격")]
		public double OrdPrc;
		/// <summary>
		/// 통신매체코드
		/// </summary>
		[XAQueryFieldAttribute("통신매체코드")]
		public string RegCommdaCode;

		public static class F
		{
			/// <summary>
			/// 레코드갯수
			/// </summary>
			public const string RecCnt = "RecCnt";
			/// <summary>
			/// 매매구분
			/// </summary>
			public const string BnsTpCode = "BnsTpCode";
			/// <summary>
			/// 계좌번호
			/// </summary>
			public const string AcntNo = "AcntNo";
			/// <summary>
			/// 입력비밀번호
			/// </summary>
			public const string InptPwd = "InptPwd";
			/// <summary>
			/// 종목번호
			/// </summary>
			public const string IsuNo = "IsuNo";
			/// <summary>
			/// 주문가격
			/// </summary>
			public const string OrdPrc = "OrdPrc";
			/// <summary>
			/// 통신매체코드
			/// </summary>
			public const string RegCommdaCode = "RegCommdaCode";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.BnsTpCode,
			F.AcntNo,
			F.InptPwd,
			F.IsuNo,
			F.OrdPrc,
			F.RegCommdaCode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["BnsTpCode"] = new XAQueryFieldInfo("char", BnsTpCode, BnsTpCode.ToString(), "매매구분", (decimal)1);
			dict["AcntNo"] = new XAQueryFieldInfo("char", AcntNo, AcntNo, "계좌번호", (decimal)20);
			dict["InptPwd"] = new XAQueryFieldInfo("char", InptPwd, InptPwd, "입력비밀번호", (decimal)8);
			dict["IsuNo"] = new XAQueryFieldInfo("char", IsuNo, IsuNo, "종목번호", (decimal)12);
			dict["OrdPrc"] = new XAQueryFieldInfo("double", OrdPrc, OrdPrc.ToString("000000000000000.00"), "주문가격", (decimal)15.2);
			dict["RegCommdaCode"] = new XAQueryFieldInfo("char", RegCommdaCode, RegCommdaCode, "통신매체코드", (decimal)2);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "RecCnt":
					this.RecCnt = fieldInfo.FieldValue.ParseLong("RecCnt");
				break;

				case "BnsTpCode":
					this.BnsTpCode = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "AcntNo":
					this.AcntNo = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "InptPwd":
					this.InptPwd = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "IsuNo":
					this.IsuNo = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "OrdPrc":
					this.OrdPrc = fieldInfo.FieldValue.ParseDouble("OrdPrc");
				break;

				case "RegCommdaCode":
					this.RegCommdaCode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (RecCnt.ToString().Length > 5) return false; // long 5
			// BnsTpCode char 1
			if (AcntNo?.Length > 20) return false; // char 20
			if (InptPwd?.Length > 8) return false; // char 8
			if (IsuNo?.Length > 12) return false; // char 12
			// OrdPrc double 15.2
			if (RegCommdaCode?.Length > 2) return false; // char 2

			return true;
		}
	}

	public partial class XQCSPBQ00200OutBlock1 : XingBlock
	{
		/// <summary>
		/// CSPBQ00200OutBlock1
		/// </summary>
		public const string _blockName = "CSPBQ00200OutBlock1";
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
		/// CSPBQ00200OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CSPBQ00200OutBlock1
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
		/// 매매구분
		/// </summary>
		[XAQueryFieldAttribute("매매구분")]
		public char BnsTpCode;
		/// <summary>
		/// 계좌번호
		/// </summary>
		[XAQueryFieldAttribute("계좌번호")]
		public string AcntNo;
		/// <summary>
		/// 입력비밀번호
		/// </summary>
		[XAQueryFieldAttribute("입력비밀번호")]
		public string InptPwd;
		/// <summary>
		/// 종목번호
		/// </summary>
		[XAQueryFieldAttribute("종목번호")]
		public string IsuNo;
		/// <summary>
		/// 주문가격
		/// </summary>
		[XAQueryFieldAttribute("주문가격")]
		public double OrdPrc;
		/// <summary>
		/// 통신매체코드
		/// </summary>
		[XAQueryFieldAttribute("통신매체코드")]
		public string RegCommdaCode;

		public static class F
		{
			/// <summary>
			/// 레코드갯수
			/// </summary>
			public const string RecCnt = "RecCnt";
			/// <summary>
			/// 매매구분
			/// </summary>
			public const string BnsTpCode = "BnsTpCode";
			/// <summary>
			/// 계좌번호
			/// </summary>
			public const string AcntNo = "AcntNo";
			/// <summary>
			/// 입력비밀번호
			/// </summary>
			public const string InptPwd = "InptPwd";
			/// <summary>
			/// 종목번호
			/// </summary>
			public const string IsuNo = "IsuNo";
			/// <summary>
			/// 주문가격
			/// </summary>
			public const string OrdPrc = "OrdPrc";
			/// <summary>
			/// 통신매체코드
			/// </summary>
			public const string RegCommdaCode = "RegCommdaCode";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.BnsTpCode,
			F.AcntNo,
			F.InptPwd,
			F.IsuNo,
			F.OrdPrc,
			F.RegCommdaCode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["BnsTpCode"] = new XAQueryFieldInfo("char", BnsTpCode, BnsTpCode.ToString(), "매매구분", (decimal)1);
			dict["AcntNo"] = new XAQueryFieldInfo("char", AcntNo, AcntNo, "계좌번호", (decimal)20);
			dict["InptPwd"] = new XAQueryFieldInfo("char", InptPwd, InptPwd, "입력비밀번호", (decimal)8);
			dict["IsuNo"] = new XAQueryFieldInfo("char", IsuNo, IsuNo, "종목번호", (decimal)12);
			dict["OrdPrc"] = new XAQueryFieldInfo("double", OrdPrc, OrdPrc.ToString("000000000000000.00"), "주문가격", (decimal)15.2);
			dict["RegCommdaCode"] = new XAQueryFieldInfo("char", RegCommdaCode, RegCommdaCode, "통신매체코드", (decimal)2);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "RecCnt":
					this.RecCnt = fieldInfo.FieldValue.ParseLong("RecCnt");
				break;

				case "BnsTpCode":
					this.BnsTpCode = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "AcntNo":
					this.AcntNo = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "InptPwd":
					this.InptPwd = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "IsuNo":
					this.IsuNo = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "OrdPrc":
					this.OrdPrc = fieldInfo.FieldValue.ParseDouble("OrdPrc");
				break;

				case "RegCommdaCode":
					this.RegCommdaCode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQCSPBQ00200OutBlock1 FromQuery(XQCSPBQ00200 query)
		{
			XQCSPBQ00200OutBlock1 block = new XQCSPBQ00200OutBlock1();
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
				block.BnsTpCode = query.GetFieldData(block.GetBlockName(), "BnsTpCode", 0).FirstOrDefault(); // char 1
				block.AcntNo = query.GetFieldData(block.GetBlockName(), "AcntNo", 0).TrimEnd('?'); // char 20
				block.InptPwd = query.GetFieldData(block.GetBlockName(), "InptPwd", 0).TrimEnd('?'); // char 8
				block.IsuNo = query.GetFieldData(block.GetBlockName(), "IsuNo", 0).TrimEnd('?'); // char 12
				block.OrdPrc = query.GetFieldData(block.GetBlockName(), "OrdPrc", 0).ParseDouble("OrdPrc"); // double 15.2
				block.RegCommdaCode = query.GetFieldData(block.GetBlockName(), "RegCommdaCode", 0).TrimEnd('?'); // char 2

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (RecCnt.ToString().Length > 5) return false; // long 5
			// BnsTpCode char 1
			if (AcntNo?.Length > 20) return false; // char 20
			if (InptPwd?.Length > 8) return false; // char 8
			if (IsuNo?.Length > 12) return false; // char 12
			// OrdPrc double 15.2
			if (RegCommdaCode?.Length > 2) return false; // char 2

			return true;
		}
	}

	public partial class XQCSPBQ00200OutBlock2 : XingBlock
	{
		/// <summary>
		/// CSPBQ00200OutBlock2
		/// </summary>
		public const string _blockName = "CSPBQ00200OutBlock2";
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
		/// CSPBQ00200OutBlock2
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CSPBQ00200OutBlock2
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
		/// 종목명
		/// </summary>
		[XAQueryFieldAttribute("종목명")]
		public string IsuNm;
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
		/// 신용담보재사용금액
		/// </summary>
		[XAQueryFieldAttribute("신용담보재사용금액")]
		public long CrdtPldgRuseAmt;
		/// <summary>
		/// 현금주문가능금액
		/// </summary>
		[XAQueryFieldAttribute("현금주문가능금액")]
		public long MnyOrdAbleAmt;
		/// <summary>
		/// 대용주문가능금액
		/// </summary>
		[XAQueryFieldAttribute("대용주문가능금액")]
		public long SubstOrdAbleAmt;
		/// <summary>
		/// 현금증거금액
		/// </summary>
		[XAQueryFieldAttribute("현금증거금액")]
		public long MnyMgn;
		/// <summary>
		/// 대용증거금액
		/// </summary>
		[XAQueryFieldAttribute("대용증거금액")]
		public long SubstMgn;
		/// <summary>
		/// 거래소금액
		/// </summary>
		[XAQueryFieldAttribute("거래소금액")]
		public long SeOrdAbleAmt;
		/// <summary>
		/// 코스닥금액
		/// </summary>
		[XAQueryFieldAttribute("코스닥금액")]
		public long KdqOrdAbleAmt;
		/// <summary>
		/// 추정예수금(D+1)
		/// </summary>
		[XAQueryFieldAttribute("추정예수금(D+1)")]
		public long PrsmptDpsD1;
		/// <summary>
		/// 추정예수금(D+2)
		/// </summary>
		[XAQueryFieldAttribute("추정예수금(D+2)")]
		public long PrsmptDpsD2;
		/// <summary>
		/// 출금가능금액
		/// </summary>
		[XAQueryFieldAttribute("출금가능금액")]
		public long MnyoutAbleAmt;
		/// <summary>
		/// 미수금액
		/// </summary>
		[XAQueryFieldAttribute("미수금액")]
		public long RcvblAmt;
		/// <summary>
		/// 수수료율
		/// </summary>
		[XAQueryFieldAttribute("수수료율")]
		public double CmsnRat;
		/// <summary>
		/// 추가징수금액
		/// </summary>
		[XAQueryFieldAttribute("추가징수금액")]
		public long AddLevyAmt;
		/// <summary>
		/// 재사용대상금액
		/// </summary>
		[XAQueryFieldAttribute("재사용대상금액")]
		public long RuseObjAmt;
		/// <summary>
		/// 현금재사용대상금액
		/// </summary>
		[XAQueryFieldAttribute("현금재사용대상금액")]
		public long MnyRuseObjAmt;
		/// <summary>
		/// 이용사증거금률
		/// </summary>
		[XAQueryFieldAttribute("이용사증거금률")]
		public double FirmMgnRat;
		/// <summary>
		/// 대용재사용대상금액
		/// </summary>
		[XAQueryFieldAttribute("대용재사용대상금액")]
		public long SubstRuseObjAmt;
		/// <summary>
		/// 종목증거금률
		/// </summary>
		[XAQueryFieldAttribute("종목증거금률")]
		public double IsuMgnRat;
		/// <summary>
		/// 계좌증거금률
		/// </summary>
		[XAQueryFieldAttribute("계좌증거금률")]
		public double AcntMgnRat;
		/// <summary>
		/// 거래증거금률
		/// </summary>
		[XAQueryFieldAttribute("거래증거금률")]
		public double TrdMgnrt;
		/// <summary>
		/// 수수료
		/// </summary>
		[XAQueryFieldAttribute("수수료")]
		public long Cmsn;
		/// <summary>
		/// 증거금률20퍼센트주문가능금액
		/// </summary>
		[XAQueryFieldAttribute("증거금률20퍼센트주문가능금액")]
		public long MgnRat20pctOrdAbleAmt;
		/// <summary>
		/// 증거금률100퍼센트현금주문가능수량?
		/// </summary>
		[XAQueryFieldAttribute("증거금률100퍼센트현금주문가능수량?")]
		public long MgnRat20OrdAbleQty;
		/// <summary>
		/// 증거금률30퍼센트주문가능금액
		/// </summary>
		[XAQueryFieldAttribute("증거금률30퍼센트주문가능금액")]
		public long MgnRat30pctOrdAbleAmt;
		/// <summary>
		/// 증거금률30퍼센트주문가능수량??
		/// </summary>
		[XAQueryFieldAttribute("증거금률30퍼센트주문가능수량??")]
		public long MgnRat30OrdAbleQty;
		/// <summary>
		/// 증거금률40퍼센트주문가능금액
		/// </summary>
		[XAQueryFieldAttribute("증거금률40퍼센트주문가능금액")]
		public long MgnRat40pctOrdAbleAmt;
		/// <summary>
		/// 증거금률40퍼센트주문가능수량??
		/// </summary>
		[XAQueryFieldAttribute("증거금률40퍼센트주문가능수량??")]
		public long MgnRat40OrdAbleQty;
		/// <summary>
		/// 증거금률100퍼센트주문가능금액
		/// </summary>
		[XAQueryFieldAttribute("증거금률100퍼센트주문가능금액")]
		public long MgnRat100pctOrdAbleAmt;
		/// <summary>
		/// 증거금률100퍼센트주문가능수량??
		/// </summary>
		[XAQueryFieldAttribute("증거금률100퍼센트주문가능수량??")]
		public long MgnRat100OrdAbleQty;
		/// <summary>
		/// 증거금률100퍼센트현금주문가능금액?
		/// </summary>
		[XAQueryFieldAttribute("증거금률100퍼센트현금주문가능금액?")]
		public long MgnRat100MnyOrdAbleAmt;
		/// <summary>
		/// 증거금률100퍼센트현금주문가능수량
		/// </summary>
		[XAQueryFieldAttribute("증거금률100퍼센트현금주문가능수량")]
		public long MgnRat100MnyOrdAbleQty;
		/// <summary>
		/// 증거금률20퍼센트재사용가능금액
		/// </summary>
		[XAQueryFieldAttribute("증거금률20퍼센트재사용가능금액")]
		public long MgnRat20pctRuseAbleAmt;
		/// <summary>
		/// 증거금률30퍼센트재사용가능금액
		/// </summary>
		[XAQueryFieldAttribute("증거금률30퍼센트재사용가능금액")]
		public long MgnRat30pctRuseAbleAmt;
		/// <summary>
		/// 증거금률40퍼센트재사용가능금액
		/// </summary>
		[XAQueryFieldAttribute("증거금률40퍼센트재사용가능금액")]
		public long MgnRat40pctRuseAbleAmt;
		/// <summary>
		/// 증거금률100퍼센트재사용가능금액
		/// </summary>
		[XAQueryFieldAttribute("증거금률100퍼센트재사용가능금액")]
		public long MgnRat100pctRuseAbleAmt;
		/// <summary>
		/// 주문가능수량
		/// </summary>
		[XAQueryFieldAttribute("주문가능수량")]
		public long OrdAbleQty;
		/// <summary>
		/// 주문가능금액
		/// </summary>
		[XAQueryFieldAttribute("주문가능금액")]
		public long OrdAbleAmt;

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
			/// 종목명
			/// </summary>
			public const string IsuNm = "IsuNm";
			/// <summary>
			/// 예수금
			/// </summary>
			public const string Dps = "Dps";
			/// <summary>
			/// 대용금액
			/// </summary>
			public const string SubstAmt = "SubstAmt";
			/// <summary>
			/// 신용담보재사용금액
			/// </summary>
			public const string CrdtPldgRuseAmt = "CrdtPldgRuseAmt";
			/// <summary>
			/// 현금주문가능금액
			/// </summary>
			public const string MnyOrdAbleAmt = "MnyOrdAbleAmt";
			/// <summary>
			/// 대용주문가능금액
			/// </summary>
			public const string SubstOrdAbleAmt = "SubstOrdAbleAmt";
			/// <summary>
			/// 현금증거금액
			/// </summary>
			public const string MnyMgn = "MnyMgn";
			/// <summary>
			/// 대용증거금액
			/// </summary>
			public const string SubstMgn = "SubstMgn";
			/// <summary>
			/// 거래소금액
			/// </summary>
			public const string SeOrdAbleAmt = "SeOrdAbleAmt";
			/// <summary>
			/// 코스닥금액
			/// </summary>
			public const string KdqOrdAbleAmt = "KdqOrdAbleAmt";
			/// <summary>
			/// 추정예수금(D+1)
			/// </summary>
			public const string PrsmptDpsD1 = "PrsmptDpsD1";
			/// <summary>
			/// 추정예수금(D+2)
			/// </summary>
			public const string PrsmptDpsD2 = "PrsmptDpsD2";
			/// <summary>
			/// 출금가능금액
			/// </summary>
			public const string MnyoutAbleAmt = "MnyoutAbleAmt";
			/// <summary>
			/// 미수금액
			/// </summary>
			public const string RcvblAmt = "RcvblAmt";
			/// <summary>
			/// 수수료율
			/// </summary>
			public const string CmsnRat = "CmsnRat";
			/// <summary>
			/// 추가징수금액
			/// </summary>
			public const string AddLevyAmt = "AddLevyAmt";
			/// <summary>
			/// 재사용대상금액
			/// </summary>
			public const string RuseObjAmt = "RuseObjAmt";
			/// <summary>
			/// 현금재사용대상금액
			/// </summary>
			public const string MnyRuseObjAmt = "MnyRuseObjAmt";
			/// <summary>
			/// 이용사증거금률
			/// </summary>
			public const string FirmMgnRat = "FirmMgnRat";
			/// <summary>
			/// 대용재사용대상금액
			/// </summary>
			public const string SubstRuseObjAmt = "SubstRuseObjAmt";
			/// <summary>
			/// 종목증거금률
			/// </summary>
			public const string IsuMgnRat = "IsuMgnRat";
			/// <summary>
			/// 계좌증거금률
			/// </summary>
			public const string AcntMgnRat = "AcntMgnRat";
			/// <summary>
			/// 거래증거금률
			/// </summary>
			public const string TrdMgnrt = "TrdMgnrt";
			/// <summary>
			/// 수수료
			/// </summary>
			public const string Cmsn = "Cmsn";
			/// <summary>
			/// 증거금률20퍼센트주문가능금액
			/// </summary>
			public const string MgnRat20pctOrdAbleAmt = "MgnRat20pctOrdAbleAmt";
			/// <summary>
			/// 증거금률100퍼센트현금주문가능수량?
			/// </summary>
			public const string MgnRat20OrdAbleQty = "MgnRat20OrdAbleQty";
			/// <summary>
			/// 증거금률30퍼센트주문가능금액
			/// </summary>
			public const string MgnRat30pctOrdAbleAmt = "MgnRat30pctOrdAbleAmt";
			/// <summary>
			/// 증거금률30퍼센트주문가능수량??
			/// </summary>
			public const string MgnRat30OrdAbleQty = "MgnRat30OrdAbleQty";
			/// <summary>
			/// 증거금률40퍼센트주문가능금액
			/// </summary>
			public const string MgnRat40pctOrdAbleAmt = "MgnRat40pctOrdAbleAmt";
			/// <summary>
			/// 증거금률40퍼센트주문가능수량??
			/// </summary>
			public const string MgnRat40OrdAbleQty = "MgnRat40OrdAbleQty";
			/// <summary>
			/// 증거금률100퍼센트주문가능금액
			/// </summary>
			public const string MgnRat100pctOrdAbleAmt = "MgnRat100pctOrdAbleAmt";
			/// <summary>
			/// 증거금률100퍼센트주문가능수량??
			/// </summary>
			public const string MgnRat100OrdAbleQty = "MgnRat100OrdAbleQty";
			/// <summary>
			/// 증거금률100퍼센트현금주문가능금액?
			/// </summary>
			public const string MgnRat100MnyOrdAbleAmt = "MgnRat100MnyOrdAbleAmt";
			/// <summary>
			/// 증거금률100퍼센트현금주문가능수량
			/// </summary>
			public const string MgnRat100MnyOrdAbleQty = "MgnRat100MnyOrdAbleQty";
			/// <summary>
			/// 증거금률20퍼센트재사용가능금액
			/// </summary>
			public const string MgnRat20pctRuseAbleAmt = "MgnRat20pctRuseAbleAmt";
			/// <summary>
			/// 증거금률30퍼센트재사용가능금액
			/// </summary>
			public const string MgnRat30pctRuseAbleAmt = "MgnRat30pctRuseAbleAmt";
			/// <summary>
			/// 증거금률40퍼센트재사용가능금액
			/// </summary>
			public const string MgnRat40pctRuseAbleAmt = "MgnRat40pctRuseAbleAmt";
			/// <summary>
			/// 증거금률100퍼센트재사용가능금액
			/// </summary>
			public const string MgnRat100pctRuseAbleAmt = "MgnRat100pctRuseAbleAmt";
			/// <summary>
			/// 주문가능수량
			/// </summary>
			public const string OrdAbleQty = "OrdAbleQty";
			/// <summary>
			/// 주문가능금액
			/// </summary>
			public const string OrdAbleAmt = "OrdAbleAmt";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.AcntNm,
			F.IsuNm,
			F.Dps,
			F.SubstAmt,
			F.CrdtPldgRuseAmt,
			F.MnyOrdAbleAmt,
			F.SubstOrdAbleAmt,
			F.MnyMgn,
			F.SubstMgn,
			F.SeOrdAbleAmt,
			F.KdqOrdAbleAmt,
			F.PrsmptDpsD1,
			F.PrsmptDpsD2,
			F.MnyoutAbleAmt,
			F.RcvblAmt,
			F.CmsnRat,
			F.AddLevyAmt,
			F.RuseObjAmt,
			F.MnyRuseObjAmt,
			F.FirmMgnRat,
			F.SubstRuseObjAmt,
			F.IsuMgnRat,
			F.AcntMgnRat,
			F.TrdMgnrt,
			F.Cmsn,
			F.MgnRat20pctOrdAbleAmt,
			F.MgnRat20OrdAbleQty,
			F.MgnRat30pctOrdAbleAmt,
			F.MgnRat30OrdAbleQty,
			F.MgnRat40pctOrdAbleAmt,
			F.MgnRat40OrdAbleQty,
			F.MgnRat100pctOrdAbleAmt,
			F.MgnRat100OrdAbleQty,
			F.MgnRat100MnyOrdAbleAmt,
			F.MgnRat100MnyOrdAbleQty,
			F.MgnRat20pctRuseAbleAmt,
			F.MgnRat30pctRuseAbleAmt,
			F.MgnRat40pctRuseAbleAmt,
			F.MgnRat100pctRuseAbleAmt,
			F.OrdAbleQty,
			F.OrdAbleAmt,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["AcntNm"] = new XAQueryFieldInfo("char", AcntNm, AcntNm, "계좌명", (decimal)40);
			dict["IsuNm"] = new XAQueryFieldInfo("char", IsuNm, IsuNm, "종목명", (decimal)40);
			dict["Dps"] = new XAQueryFieldInfo("long", Dps, Dps.ToString("d16"), "예수금", (decimal)16);
			dict["SubstAmt"] = new XAQueryFieldInfo("long", SubstAmt, SubstAmt.ToString("d16"), "대용금액", (decimal)16);
			dict["CrdtPldgRuseAmt"] = new XAQueryFieldInfo("long", CrdtPldgRuseAmt, CrdtPldgRuseAmt.ToString("d16"), "신용담보재사용금액", (decimal)16);
			dict["MnyOrdAbleAmt"] = new XAQueryFieldInfo("long", MnyOrdAbleAmt, MnyOrdAbleAmt.ToString("d16"), "현금주문가능금액", (decimal)16);
			dict["SubstOrdAbleAmt"] = new XAQueryFieldInfo("long", SubstOrdAbleAmt, SubstOrdAbleAmt.ToString("d16"), "대용주문가능금액", (decimal)16);
			dict["MnyMgn"] = new XAQueryFieldInfo("long", MnyMgn, MnyMgn.ToString("d16"), "현금증거금액", (decimal)16);
			dict["SubstMgn"] = new XAQueryFieldInfo("long", SubstMgn, SubstMgn.ToString("d16"), "대용증거금액", (decimal)16);
			dict["SeOrdAbleAmt"] = new XAQueryFieldInfo("long", SeOrdAbleAmt, SeOrdAbleAmt.ToString("d16"), "거래소금액", (decimal)16);
			dict["KdqOrdAbleAmt"] = new XAQueryFieldInfo("long", KdqOrdAbleAmt, KdqOrdAbleAmt.ToString("d16"), "코스닥금액", (decimal)16);
			dict["PrsmptDpsD1"] = new XAQueryFieldInfo("long", PrsmptDpsD1, PrsmptDpsD1.ToString("d16"), "추정예수금(D+1)", (decimal)16);
			dict["PrsmptDpsD2"] = new XAQueryFieldInfo("long", PrsmptDpsD2, PrsmptDpsD2.ToString("d16"), "추정예수금(D+2)", (decimal)16);
			dict["MnyoutAbleAmt"] = new XAQueryFieldInfo("long", MnyoutAbleAmt, MnyoutAbleAmt.ToString("d16"), "출금가능금액", (decimal)16);
			dict["RcvblAmt"] = new XAQueryFieldInfo("long", RcvblAmt, RcvblAmt.ToString("d16"), "미수금액", (decimal)16);
			dict["CmsnRat"] = new XAQueryFieldInfo("double", CmsnRat, CmsnRat.ToString("000000000000000.00000"), "수수료율", (decimal)15.5);
			dict["AddLevyAmt"] = new XAQueryFieldInfo("long", AddLevyAmt, AddLevyAmt.ToString("d16"), "추가징수금액", (decimal)16);
			dict["RuseObjAmt"] = new XAQueryFieldInfo("long", RuseObjAmt, RuseObjAmt.ToString("d16"), "재사용대상금액", (decimal)16);
			dict["MnyRuseObjAmt"] = new XAQueryFieldInfo("long", MnyRuseObjAmt, MnyRuseObjAmt.ToString("d16"), "현금재사용대상금액", (decimal)16);
			dict["FirmMgnRat"] = new XAQueryFieldInfo("double", FirmMgnRat, FirmMgnRat.ToString("0000000.0000"), "이용사증거금률", (decimal)7.4);
			dict["SubstRuseObjAmt"] = new XAQueryFieldInfo("long", SubstRuseObjAmt, SubstRuseObjAmt.ToString("d16"), "대용재사용대상금액", (decimal)16);
			dict["IsuMgnRat"] = new XAQueryFieldInfo("double", IsuMgnRat, IsuMgnRat.ToString("0000000.0000"), "종목증거금률", (decimal)7.4);
			dict["AcntMgnRat"] = new XAQueryFieldInfo("double", AcntMgnRat, AcntMgnRat.ToString("0000000.0000"), "계좌증거금률", (decimal)7.4);
			dict["TrdMgnrt"] = new XAQueryFieldInfo("double", TrdMgnrt, TrdMgnrt.ToString("0000000.0000"), "거래증거금률", (decimal)7.4);
			dict["Cmsn"] = new XAQueryFieldInfo("long", Cmsn, Cmsn.ToString("d16"), "수수료", (decimal)16);
			dict["MgnRat20pctOrdAbleAmt"] = new XAQueryFieldInfo("long", MgnRat20pctOrdAbleAmt, MgnRat20pctOrdAbleAmt.ToString("d16"), "증거금률20퍼센트주문가능금액", (decimal)16);
			dict["MgnRat20OrdAbleQty"] = new XAQueryFieldInfo("long", MgnRat20OrdAbleQty, MgnRat20OrdAbleQty.ToString("d16"), "증거금률100퍼센트현금주문가능수량?", (decimal)16);
			dict["MgnRat30pctOrdAbleAmt"] = new XAQueryFieldInfo("long", MgnRat30pctOrdAbleAmt, MgnRat30pctOrdAbleAmt.ToString("d16"), "증거금률30퍼센트주문가능금액", (decimal)16);
			dict["MgnRat30OrdAbleQty"] = new XAQueryFieldInfo("long", MgnRat30OrdAbleQty, MgnRat30OrdAbleQty.ToString("d16"), "증거금률30퍼센트주문가능수량??", (decimal)16);
			dict["MgnRat40pctOrdAbleAmt"] = new XAQueryFieldInfo("long", MgnRat40pctOrdAbleAmt, MgnRat40pctOrdAbleAmt.ToString("d16"), "증거금률40퍼센트주문가능금액", (decimal)16);
			dict["MgnRat40OrdAbleQty"] = new XAQueryFieldInfo("long", MgnRat40OrdAbleQty, MgnRat40OrdAbleQty.ToString("d16"), "증거금률40퍼센트주문가능수량??", (decimal)16);
			dict["MgnRat100pctOrdAbleAmt"] = new XAQueryFieldInfo("long", MgnRat100pctOrdAbleAmt, MgnRat100pctOrdAbleAmt.ToString("d16"), "증거금률100퍼센트주문가능금액", (decimal)16);
			dict["MgnRat100OrdAbleQty"] = new XAQueryFieldInfo("long", MgnRat100OrdAbleQty, MgnRat100OrdAbleQty.ToString("d16"), "증거금률100퍼센트주문가능수량??", (decimal)16);
			dict["MgnRat100MnyOrdAbleAmt"] = new XAQueryFieldInfo("long", MgnRat100MnyOrdAbleAmt, MgnRat100MnyOrdAbleAmt.ToString("d16"), "증거금률100퍼센트현금주문가능금액?", (decimal)16);
			dict["MgnRat100MnyOrdAbleQty"] = new XAQueryFieldInfo("long", MgnRat100MnyOrdAbleQty, MgnRat100MnyOrdAbleQty.ToString("d16"), "증거금률100퍼센트현금주문가능수량", (decimal)16);
			dict["MgnRat20pctRuseAbleAmt"] = new XAQueryFieldInfo("long", MgnRat20pctRuseAbleAmt, MgnRat20pctRuseAbleAmt.ToString("d16"), "증거금률20퍼센트재사용가능금액", (decimal)16);
			dict["MgnRat30pctRuseAbleAmt"] = new XAQueryFieldInfo("long", MgnRat30pctRuseAbleAmt, MgnRat30pctRuseAbleAmt.ToString("d16"), "증거금률30퍼센트재사용가능금액", (decimal)16);
			dict["MgnRat40pctRuseAbleAmt"] = new XAQueryFieldInfo("long", MgnRat40pctRuseAbleAmt, MgnRat40pctRuseAbleAmt.ToString("d16"), "증거금률40퍼센트재사용가능금액", (decimal)16);
			dict["MgnRat100pctRuseAbleAmt"] = new XAQueryFieldInfo("long", MgnRat100pctRuseAbleAmt, MgnRat100pctRuseAbleAmt.ToString("d16"), "증거금률100퍼센트재사용가능금액", (decimal)16);
			dict["OrdAbleQty"] = new XAQueryFieldInfo("long", OrdAbleQty, OrdAbleQty.ToString("d16"), "주문가능수량", (decimal)16);
			dict["OrdAbleAmt"] = new XAQueryFieldInfo("long", OrdAbleAmt, OrdAbleAmt.ToString("d16"), "주문가능금액", (decimal)16);

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

				case "IsuNm":
					this.IsuNm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "Dps":
					this.Dps = fieldInfo.FieldValue.ParseLong("Dps");
				break;

				case "SubstAmt":
					this.SubstAmt = fieldInfo.FieldValue.ParseLong("SubstAmt");
				break;

				case "CrdtPldgRuseAmt":
					this.CrdtPldgRuseAmt = fieldInfo.FieldValue.ParseLong("CrdtPldgRuseAmt");
				break;

				case "MnyOrdAbleAmt":
					this.MnyOrdAbleAmt = fieldInfo.FieldValue.ParseLong("MnyOrdAbleAmt");
				break;

				case "SubstOrdAbleAmt":
					this.SubstOrdAbleAmt = fieldInfo.FieldValue.ParseLong("SubstOrdAbleAmt");
				break;

				case "MnyMgn":
					this.MnyMgn = fieldInfo.FieldValue.ParseLong("MnyMgn");
				break;

				case "SubstMgn":
					this.SubstMgn = fieldInfo.FieldValue.ParseLong("SubstMgn");
				break;

				case "SeOrdAbleAmt":
					this.SeOrdAbleAmt = fieldInfo.FieldValue.ParseLong("SeOrdAbleAmt");
				break;

				case "KdqOrdAbleAmt":
					this.KdqOrdAbleAmt = fieldInfo.FieldValue.ParseLong("KdqOrdAbleAmt");
				break;

				case "PrsmptDpsD1":
					this.PrsmptDpsD1 = fieldInfo.FieldValue.ParseLong("PrsmptDpsD1");
				break;

				case "PrsmptDpsD2":
					this.PrsmptDpsD2 = fieldInfo.FieldValue.ParseLong("PrsmptDpsD2");
				break;

				case "MnyoutAbleAmt":
					this.MnyoutAbleAmt = fieldInfo.FieldValue.ParseLong("MnyoutAbleAmt");
				break;

				case "RcvblAmt":
					this.RcvblAmt = fieldInfo.FieldValue.ParseLong("RcvblAmt");
				break;

				case "CmsnRat":
					this.CmsnRat = fieldInfo.FieldValue.ParseDouble("CmsnRat");
				break;

				case "AddLevyAmt":
					this.AddLevyAmt = fieldInfo.FieldValue.ParseLong("AddLevyAmt");
				break;

				case "RuseObjAmt":
					this.RuseObjAmt = fieldInfo.FieldValue.ParseLong("RuseObjAmt");
				break;

				case "MnyRuseObjAmt":
					this.MnyRuseObjAmt = fieldInfo.FieldValue.ParseLong("MnyRuseObjAmt");
				break;

				case "FirmMgnRat":
					this.FirmMgnRat = fieldInfo.FieldValue.ParseDouble("FirmMgnRat");
				break;

				case "SubstRuseObjAmt":
					this.SubstRuseObjAmt = fieldInfo.FieldValue.ParseLong("SubstRuseObjAmt");
				break;

				case "IsuMgnRat":
					this.IsuMgnRat = fieldInfo.FieldValue.ParseDouble("IsuMgnRat");
				break;

				case "AcntMgnRat":
					this.AcntMgnRat = fieldInfo.FieldValue.ParseDouble("AcntMgnRat");
				break;

				case "TrdMgnrt":
					this.TrdMgnrt = fieldInfo.FieldValue.ParseDouble("TrdMgnrt");
				break;

				case "Cmsn":
					this.Cmsn = fieldInfo.FieldValue.ParseLong("Cmsn");
				break;

				case "MgnRat20pctOrdAbleAmt":
					this.MgnRat20pctOrdAbleAmt = fieldInfo.FieldValue.ParseLong("MgnRat20pctOrdAbleAmt");
				break;

				case "MgnRat20OrdAbleQty":
					this.MgnRat20OrdAbleQty = fieldInfo.FieldValue.ParseLong("MgnRat20OrdAbleQty");
				break;

				case "MgnRat30pctOrdAbleAmt":
					this.MgnRat30pctOrdAbleAmt = fieldInfo.FieldValue.ParseLong("MgnRat30pctOrdAbleAmt");
				break;

				case "MgnRat30OrdAbleQty":
					this.MgnRat30OrdAbleQty = fieldInfo.FieldValue.ParseLong("MgnRat30OrdAbleQty");
				break;

				case "MgnRat40pctOrdAbleAmt":
					this.MgnRat40pctOrdAbleAmt = fieldInfo.FieldValue.ParseLong("MgnRat40pctOrdAbleAmt");
				break;

				case "MgnRat40OrdAbleQty":
					this.MgnRat40OrdAbleQty = fieldInfo.FieldValue.ParseLong("MgnRat40OrdAbleQty");
				break;

				case "MgnRat100pctOrdAbleAmt":
					this.MgnRat100pctOrdAbleAmt = fieldInfo.FieldValue.ParseLong("MgnRat100pctOrdAbleAmt");
				break;

				case "MgnRat100OrdAbleQty":
					this.MgnRat100OrdAbleQty = fieldInfo.FieldValue.ParseLong("MgnRat100OrdAbleQty");
				break;

				case "MgnRat100MnyOrdAbleAmt":
					this.MgnRat100MnyOrdAbleAmt = fieldInfo.FieldValue.ParseLong("MgnRat100MnyOrdAbleAmt");
				break;

				case "MgnRat100MnyOrdAbleQty":
					this.MgnRat100MnyOrdAbleQty = fieldInfo.FieldValue.ParseLong("MgnRat100MnyOrdAbleQty");
				break;

				case "MgnRat20pctRuseAbleAmt":
					this.MgnRat20pctRuseAbleAmt = fieldInfo.FieldValue.ParseLong("MgnRat20pctRuseAbleAmt");
				break;

				case "MgnRat30pctRuseAbleAmt":
					this.MgnRat30pctRuseAbleAmt = fieldInfo.FieldValue.ParseLong("MgnRat30pctRuseAbleAmt");
				break;

				case "MgnRat40pctRuseAbleAmt":
					this.MgnRat40pctRuseAbleAmt = fieldInfo.FieldValue.ParseLong("MgnRat40pctRuseAbleAmt");
				break;

				case "MgnRat100pctRuseAbleAmt":
					this.MgnRat100pctRuseAbleAmt = fieldInfo.FieldValue.ParseLong("MgnRat100pctRuseAbleAmt");
				break;

				case "OrdAbleQty":
					this.OrdAbleQty = fieldInfo.FieldValue.ParseLong("OrdAbleQty");
				break;

				case "OrdAbleAmt":
					this.OrdAbleAmt = fieldInfo.FieldValue.ParseLong("OrdAbleAmt");
				break;


			}
		}

		public static XQCSPBQ00200OutBlock2 FromQuery(XQCSPBQ00200 query)
		{
			XQCSPBQ00200OutBlock2 block = new XQCSPBQ00200OutBlock2();
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
				block.IsuNm = query.GetFieldData(block.GetBlockName(), "IsuNm", 0).TrimEnd('?'); // char 40
				block.Dps = query.GetFieldData(block.GetBlockName(), "Dps", 0).ParseLong("Dps"); // long 16
				block.SubstAmt = query.GetFieldData(block.GetBlockName(), "SubstAmt", 0).ParseLong("SubstAmt"); // long 16
				block.CrdtPldgRuseAmt = query.GetFieldData(block.GetBlockName(), "CrdtPldgRuseAmt", 0).ParseLong("CrdtPldgRuseAmt"); // long 16
				block.MnyOrdAbleAmt = query.GetFieldData(block.GetBlockName(), "MnyOrdAbleAmt", 0).ParseLong("MnyOrdAbleAmt"); // long 16
				block.SubstOrdAbleAmt = query.GetFieldData(block.GetBlockName(), "SubstOrdAbleAmt", 0).ParseLong("SubstOrdAbleAmt"); // long 16
				block.MnyMgn = query.GetFieldData(block.GetBlockName(), "MnyMgn", 0).ParseLong("MnyMgn"); // long 16
				block.SubstMgn = query.GetFieldData(block.GetBlockName(), "SubstMgn", 0).ParseLong("SubstMgn"); // long 16
				block.SeOrdAbleAmt = query.GetFieldData(block.GetBlockName(), "SeOrdAbleAmt", 0).ParseLong("SeOrdAbleAmt"); // long 16
				block.KdqOrdAbleAmt = query.GetFieldData(block.GetBlockName(), "KdqOrdAbleAmt", 0).ParseLong("KdqOrdAbleAmt"); // long 16
				block.PrsmptDpsD1 = query.GetFieldData(block.GetBlockName(), "PrsmptDpsD1", 0).ParseLong("PrsmptDpsD1"); // long 16
				block.PrsmptDpsD2 = query.GetFieldData(block.GetBlockName(), "PrsmptDpsD2", 0).ParseLong("PrsmptDpsD2"); // long 16
				block.MnyoutAbleAmt = query.GetFieldData(block.GetBlockName(), "MnyoutAbleAmt", 0).ParseLong("MnyoutAbleAmt"); // long 16
				block.RcvblAmt = query.GetFieldData(block.GetBlockName(), "RcvblAmt", 0).ParseLong("RcvblAmt"); // long 16
				block.CmsnRat = query.GetFieldData(block.GetBlockName(), "CmsnRat", 0).ParseDouble("CmsnRat"); // double 15.5
				block.AddLevyAmt = query.GetFieldData(block.GetBlockName(), "AddLevyAmt", 0).ParseLong("AddLevyAmt"); // long 16
				block.RuseObjAmt = query.GetFieldData(block.GetBlockName(), "RuseObjAmt", 0).ParseLong("RuseObjAmt"); // long 16
				block.MnyRuseObjAmt = query.GetFieldData(block.GetBlockName(), "MnyRuseObjAmt", 0).ParseLong("MnyRuseObjAmt"); // long 16
				block.FirmMgnRat = query.GetFieldData(block.GetBlockName(), "FirmMgnRat", 0).ParseDouble("FirmMgnRat"); // double 7.4
				block.SubstRuseObjAmt = query.GetFieldData(block.GetBlockName(), "SubstRuseObjAmt", 0).ParseLong("SubstRuseObjAmt"); // long 16
				block.IsuMgnRat = query.GetFieldData(block.GetBlockName(), "IsuMgnRat", 0).ParseDouble("IsuMgnRat"); // double 7.4
				block.AcntMgnRat = query.GetFieldData(block.GetBlockName(), "AcntMgnRat", 0).ParseDouble("AcntMgnRat"); // double 7.4
				block.TrdMgnrt = query.GetFieldData(block.GetBlockName(), "TrdMgnrt", 0).ParseDouble("TrdMgnrt"); // double 7.4
				block.Cmsn = query.GetFieldData(block.GetBlockName(), "Cmsn", 0).ParseLong("Cmsn"); // long 16
				block.MgnRat20pctOrdAbleAmt = query.GetFieldData(block.GetBlockName(), "MgnRat20pctOrdAbleAmt", 0).ParseLong("MgnRat20pctOrdAbleAmt"); // long 16
				block.MgnRat20OrdAbleQty = query.GetFieldData(block.GetBlockName(), "MgnRat20OrdAbleQty", 0).ParseLong("MgnRat20OrdAbleQty"); // long 16
				block.MgnRat30pctOrdAbleAmt = query.GetFieldData(block.GetBlockName(), "MgnRat30pctOrdAbleAmt", 0).ParseLong("MgnRat30pctOrdAbleAmt"); // long 16
				block.MgnRat30OrdAbleQty = query.GetFieldData(block.GetBlockName(), "MgnRat30OrdAbleQty", 0).ParseLong("MgnRat30OrdAbleQty"); // long 16
				block.MgnRat40pctOrdAbleAmt = query.GetFieldData(block.GetBlockName(), "MgnRat40pctOrdAbleAmt", 0).ParseLong("MgnRat40pctOrdAbleAmt"); // long 16
				block.MgnRat40OrdAbleQty = query.GetFieldData(block.GetBlockName(), "MgnRat40OrdAbleQty", 0).ParseLong("MgnRat40OrdAbleQty"); // long 16
				block.MgnRat100pctOrdAbleAmt = query.GetFieldData(block.GetBlockName(), "MgnRat100pctOrdAbleAmt", 0).ParseLong("MgnRat100pctOrdAbleAmt"); // long 16
				block.MgnRat100OrdAbleQty = query.GetFieldData(block.GetBlockName(), "MgnRat100OrdAbleQty", 0).ParseLong("MgnRat100OrdAbleQty"); // long 16
				block.MgnRat100MnyOrdAbleAmt = query.GetFieldData(block.GetBlockName(), "MgnRat100MnyOrdAbleAmt", 0).ParseLong("MgnRat100MnyOrdAbleAmt"); // long 16
				block.MgnRat100MnyOrdAbleQty = query.GetFieldData(block.GetBlockName(), "MgnRat100MnyOrdAbleQty", 0).ParseLong("MgnRat100MnyOrdAbleQty"); // long 16
				block.MgnRat20pctRuseAbleAmt = query.GetFieldData(block.GetBlockName(), "MgnRat20pctRuseAbleAmt", 0).ParseLong("MgnRat20pctRuseAbleAmt"); // long 16
				block.MgnRat30pctRuseAbleAmt = query.GetFieldData(block.GetBlockName(), "MgnRat30pctRuseAbleAmt", 0).ParseLong("MgnRat30pctRuseAbleAmt"); // long 16
				block.MgnRat40pctRuseAbleAmt = query.GetFieldData(block.GetBlockName(), "MgnRat40pctRuseAbleAmt", 0).ParseLong("MgnRat40pctRuseAbleAmt"); // long 16
				block.MgnRat100pctRuseAbleAmt = query.GetFieldData(block.GetBlockName(), "MgnRat100pctRuseAbleAmt", 0).ParseLong("MgnRat100pctRuseAbleAmt"); // long 16
				block.OrdAbleQty = query.GetFieldData(block.GetBlockName(), "OrdAbleQty", 0).ParseLong("OrdAbleQty"); // long 16
				block.OrdAbleAmt = query.GetFieldData(block.GetBlockName(), "OrdAbleAmt", 0).ParseLong("OrdAbleAmt"); // long 16

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
			if (IsuNm?.Length > 40) return false; // char 40
			if (Dps.ToString().Length > 16) return false; // long 16
			if (SubstAmt.ToString().Length > 16) return false; // long 16
			if (CrdtPldgRuseAmt.ToString().Length > 16) return false; // long 16
			if (MnyOrdAbleAmt.ToString().Length > 16) return false; // long 16
			if (SubstOrdAbleAmt.ToString().Length > 16) return false; // long 16
			if (MnyMgn.ToString().Length > 16) return false; // long 16
			if (SubstMgn.ToString().Length > 16) return false; // long 16
			if (SeOrdAbleAmt.ToString().Length > 16) return false; // long 16
			if (KdqOrdAbleAmt.ToString().Length > 16) return false; // long 16
			if (PrsmptDpsD1.ToString().Length > 16) return false; // long 16
			if (PrsmptDpsD2.ToString().Length > 16) return false; // long 16
			if (MnyoutAbleAmt.ToString().Length > 16) return false; // long 16
			if (RcvblAmt.ToString().Length > 16) return false; // long 16
			// CmsnRat double 15.5
			if (AddLevyAmt.ToString().Length > 16) return false; // long 16
			if (RuseObjAmt.ToString().Length > 16) return false; // long 16
			if (MnyRuseObjAmt.ToString().Length > 16) return false; // long 16
			// FirmMgnRat double 7.4
			if (SubstRuseObjAmt.ToString().Length > 16) return false; // long 16
			// IsuMgnRat double 7.4
			// AcntMgnRat double 7.4
			// TrdMgnrt double 7.4
			if (Cmsn.ToString().Length > 16) return false; // long 16
			if (MgnRat20pctOrdAbleAmt.ToString().Length > 16) return false; // long 16
			if (MgnRat20OrdAbleQty.ToString().Length > 16) return false; // long 16
			if (MgnRat30pctOrdAbleAmt.ToString().Length > 16) return false; // long 16
			if (MgnRat30OrdAbleQty.ToString().Length > 16) return false; // long 16
			if (MgnRat40pctOrdAbleAmt.ToString().Length > 16) return false; // long 16
			if (MgnRat40OrdAbleQty.ToString().Length > 16) return false; // long 16
			if (MgnRat100pctOrdAbleAmt.ToString().Length > 16) return false; // long 16
			if (MgnRat100OrdAbleQty.ToString().Length > 16) return false; // long 16
			if (MgnRat100MnyOrdAbleAmt.ToString().Length > 16) return false; // long 16
			if (MgnRat100MnyOrdAbleQty.ToString().Length > 16) return false; // long 16
			if (MgnRat20pctRuseAbleAmt.ToString().Length > 16) return false; // long 16
			if (MgnRat30pctRuseAbleAmt.ToString().Length > 16) return false; // long 16
			if (MgnRat40pctRuseAbleAmt.ToString().Length > 16) return false; // long 16
			if (MgnRat100pctRuseAbleAmt.ToString().Length > 16) return false; // long 16
			if (OrdAbleQty.ToString().Length > 16) return false; // long 16
			if (OrdAbleAmt.ToString().Length > 16) return false; // long 16

			return true;
		}
	}

	public partial class XQCSPBQ00200 : XingQuery
	{
		/// <summary>
		/// CSPBQ00200
		/// </summary>
		public const string _typeName = "CSPBQ00200";
		/// <summary>
		/// 현물계좌증거금률별주문가능수량조회
		/// </summary>
		public const string _typeDesc = "현물계좌증거금률별주문가능수량조회";
		/// <summary>
		/// CSPBQ00200
		/// </summary>
		public const string _service = "CSPBQ00200";
		/// <summary>
		/// B
		/// </summary>
		public const string _headType = "B";
		/// <summary>
		/// 이상은
		/// </summary>
		public const string _creator = "이상은";
		/// <summary>
		/// 2011/12/12 09:22:25
		/// </summary>
		public const string _createdDate = "2011/12/12 09:22:25";
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
		/// CSPBQ00200
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 현물계좌증거금률별주문가능수량조회
		/// </summary>
		public string TypeDesc => _typeDesc;
		/// <summary>
		/// CSPBQ00200
		/// </summary>
		public string Service => _service;
		/// <summary>
		/// B
		/// </summary>
		public string HeadType => _headType;
		/// <summary>
		/// 이상은
		/// </summary>
		public string Creator => _creator;
		/// <summary>
		/// 2011/12/12 09:22:25
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

		public XQCSPBQ00200() : base("CSPBQ00200") { }



		public bool SetBlock(XQCSPBQ00200InBlock1 block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "RecCnt", 0, block.RecCnt.ToString("d5")); // long 5
			_xaQuery.SetFieldData(block.GetBlockName(), "BnsTpCode", 0, block.BnsTpCode.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "AcntNo", 0, block.AcntNo); // char 20
			_xaQuery.SetFieldData(block.GetBlockName(), "InptPwd", 0, block.InptPwd); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "IsuNo", 0, block.IsuNo); // char 12
			_xaQuery.SetFieldData(block.GetBlockName(), "OrdPrc", 0, block.OrdPrc.ToString("000000000000000.00")); // double 15.2
			_xaQuery.SetFieldData(block.GetBlockName(), "RegCommdaCode", 0, block.RegCommdaCode); // char 2

			return true;
		}

		public XQCSPBQ00200OutBlock1 GetBlock1()
		{
			XQCSPBQ00200OutBlock1 instance = XQCSPBQ00200OutBlock1.FromQuery(this);
			return instance;

		}

		public XQCSPBQ00200OutBlock2 GetBlock2()
		{
			XQCSPBQ00200OutBlock2 instance = XQCSPBQ00200OutBlock2.FromQuery(this);
			return instance;

		}


	}

}
