using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQCEXAT11300InBlock1 : XingBlock
	{
		/// <summary>
		/// CEXAT11300InBlock1
		/// </summary>
		public const string _blockName = "CEXAT11300InBlock1";
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
		/// CEXAT11300InBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CEXAT11300InBlock1
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
		/// 원주문번호
		/// </summary>
		[XAQueryFieldAttribute("원주문번호")]
		public long OrgOrdNo;
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
		/// 선물옵션종목번호
		/// </summary>
		[XAQueryFieldAttribute("선물옵션종목번호")]
		public string FnoIsuNo;

		public static class F
		{
			/// <summary>
			/// 원주문번호
			/// </summary>
			public const string OrgOrdNo = "OrgOrdNo";
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
		}

		public static string[] AllFields = new string[]
		{
			F.OrgOrdNo,
			F.AcntNo,
			F.Pwd,
			F.FnoIsuNo,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["OrgOrdNo"] = new XAQueryFieldInfo("long", OrgOrdNo, OrgOrdNo.ToString("d10"), "원주문번호", (decimal)10);
			dict["AcntNo"] = new XAQueryFieldInfo("char", AcntNo, AcntNo, "계좌번호", (decimal)20);
			dict["Pwd"] = new XAQueryFieldInfo("char", Pwd, Pwd, "비밀번호", (decimal)8);
			dict["FnoIsuNo"] = new XAQueryFieldInfo("char", FnoIsuNo, FnoIsuNo, "선물옵션종목번호", (decimal)12);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "OrgOrdNo":
					this.OrgOrdNo = fieldInfo.FieldValue.ParseLong("OrgOrdNo");
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


			}
		}

		public bool VerifyData()
		{
			if (OrgOrdNo.ToString().Length > 10) return false; // long 10
			if (AcntNo?.Length > 20) return false; // char 20
			if (Pwd?.Length > 8) return false; // char 8
			if (FnoIsuNo?.Length > 12) return false; // char 12

			return true;
		}
	}

	public partial class XQCEXAT11300OutBlock1 : XingBlock
	{
		/// <summary>
		/// CEXAT11300OutBlock1
		/// </summary>
		public const string _blockName = "CEXAT11300OutBlock1";
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
		/// CEXAT11300OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CEXAT11300OutBlock1
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
		/// 원주문번호
		/// </summary>
		[XAQueryFieldAttribute("원주문번호")]
		public long OrgOrdNo;
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
		/// 선물옵션종목번호
		/// </summary>
		[XAQueryFieldAttribute("선물옵션종목번호")]
		public string FnoIsuNo;
		/// <summary>
		/// 취소수량
		/// </summary>
		[XAQueryFieldAttribute("취소수량")]
		public long CancQty;
		/// <summary>
		/// 통신매체코드
		/// </summary>
		[XAQueryFieldAttribute("통신매체코드")]
		public string CommdaCode;

		public static class F
		{
			/// <summary>
			/// 레코드갯수
			/// </summary>
			public const string RecCnt = "RecCnt";
			/// <summary>
			/// 원주문번호
			/// </summary>
			public const string OrgOrdNo = "OrgOrdNo";
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
			/// 취소수량
			/// </summary>
			public const string CancQty = "CancQty";
			/// <summary>
			/// 통신매체코드
			/// </summary>
			public const string CommdaCode = "CommdaCode";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.OrgOrdNo,
			F.AcntNo,
			F.Pwd,
			F.FnoIsuNo,
			F.CancQty,
			F.CommdaCode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["OrgOrdNo"] = new XAQueryFieldInfo("long", OrgOrdNo, OrgOrdNo.ToString("d10"), "원주문번호", (decimal)10);
			dict["AcntNo"] = new XAQueryFieldInfo("char", AcntNo, AcntNo, "계좌번호", (decimal)20);
			dict["Pwd"] = new XAQueryFieldInfo("char", Pwd, Pwd, "비밀번호", (decimal)8);
			dict["FnoIsuNo"] = new XAQueryFieldInfo("char", FnoIsuNo, FnoIsuNo, "선물옵션종목번호", (decimal)12);
			dict["CancQty"] = new XAQueryFieldInfo("long", CancQty, CancQty.ToString("d16"), "취소수량", (decimal)16);
			dict["CommdaCode"] = new XAQueryFieldInfo("char", CommdaCode, CommdaCode, "통신매체코드", (decimal)2);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "RecCnt":
					this.RecCnt = fieldInfo.FieldValue.ParseLong("RecCnt");
				break;

				case "OrgOrdNo":
					this.OrgOrdNo = fieldInfo.FieldValue.ParseLong("OrgOrdNo");
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

				case "CancQty":
					this.CancQty = fieldInfo.FieldValue.ParseLong("CancQty");
				break;

				case "CommdaCode":
					this.CommdaCode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQCEXAT11300OutBlock1 FromQuery(XQCEXAT11300 query)
		{
			XQCEXAT11300OutBlock1 block = new XQCEXAT11300OutBlock1();
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
				block.OrgOrdNo = query.GetFieldData(block.GetBlockName(), "OrgOrdNo", 0).ParseLong("OrgOrdNo"); // long 10
				block.AcntNo = query.GetFieldData(block.GetBlockName(), "AcntNo", 0).TrimEnd('?'); // char 20
				block.Pwd = query.GetFieldData(block.GetBlockName(), "Pwd", 0).TrimEnd('?'); // char 8
				block.FnoIsuNo = query.GetFieldData(block.GetBlockName(), "FnoIsuNo", 0).TrimEnd('?'); // char 12
				block.CancQty = query.GetFieldData(block.GetBlockName(), "CancQty", 0).ParseLong("CancQty"); // long 16
				block.CommdaCode = query.GetFieldData(block.GetBlockName(), "CommdaCode", 0).TrimEnd('?'); // char 2

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (RecCnt.ToString().Length > 5) return false; // long 5
			if (OrgOrdNo.ToString().Length > 10) return false; // long 10
			if (AcntNo?.Length > 20) return false; // char 20
			if (Pwd?.Length > 8) return false; // char 8
			if (FnoIsuNo?.Length > 12) return false; // char 12
			if (CancQty.ToString().Length > 16) return false; // long 16
			if (CommdaCode?.Length > 2) return false; // char 2

			return true;
		}
	}

	public partial class XQCEXAT11300OutBlock2 : XingBlock
	{
		/// <summary>
		/// CEXAT11300OutBlock2
		/// </summary>
		public const string _blockName = "CEXAT11300OutBlock2";
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
		/// CEXAT11300OutBlock2
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CEXAT11300OutBlock2
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
		/// 주문번호
		/// </summary>
		[XAQueryFieldAttribute("주문번호")]
		public long OrdNo;
		/// <summary>
		/// 지점명
		/// </summary>
		[XAQueryFieldAttribute("지점명")]
		public string BrnNm;
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
		/// 주문증거금액
		/// </summary>
		[XAQueryFieldAttribute("주문증거금액")]
		public long OrdMgn;
		/// <summary>
		/// 현금주문증거금액
		/// </summary>
		[XAQueryFieldAttribute("현금주문증거금액")]
		public long MnyOrdMgn;
		/// <summary>
		/// 주문가능수량
		/// </summary>
		[XAQueryFieldAttribute("주문가능수량")]
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
			/// 주문증거금액
			/// </summary>
			public const string OrdMgn = "OrdMgn";
			/// <summary>
			/// 현금주문증거금액
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
			dict["OrdMgn"] = new XAQueryFieldInfo("long", OrdMgn, OrdMgn.ToString("d16"), "주문증거금액", (decimal)16);
			dict["MnyOrdMgn"] = new XAQueryFieldInfo("long", MnyOrdMgn, MnyOrdMgn.ToString("d16"), "현금주문증거금액", (decimal)16);
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

		public static XQCEXAT11300OutBlock2 FromQuery(XQCEXAT11300 query)
		{
			XQCEXAT11300OutBlock2 block = new XQCEXAT11300OutBlock2();
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
	/// 유렉스 취소주문
	/// </summary>
	public partial class XQCEXAT11300 : XingQuery
	{
		/// <summary>
		/// CEXAT11300
		/// </summary>
		public const string _typeName = "CEXAT11300";
		/// <summary>
		/// 유렉스 취소주문
		/// </summary>
		public const string _typeDesc = "유렉스 취소주문";
		/// <summary>
		/// CEXAT11300
		/// </summary>
		public const string _service = "CEXAT11300";
		/// <summary>
		/// B
		/// </summary>
		public const string _headType = "B";
		/// <summary>
		/// 이시종
		/// </summary>
		public const string _creator = "이시종";
		/// <summary>
		/// 2012/06/27 21:31:41
		/// </summary>
		public const string _createdDate = "2012/06/27 21:31:41";
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
		/// CEXAT11300
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 유렉스 취소주문
		/// </summary>
		public string TypeDesc => _typeDesc;
		/// <summary>
		/// CEXAT11300
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
		/// 2012/06/27 21:31:41
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

		public XQCEXAT11300() : base("CEXAT11300") { }



		public bool SetBlock(XQCEXAT11300InBlock1 block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "OrgOrdNo", 0, block.OrgOrdNo.ToString("d10")); // long 10
			_xaQuery.SetFieldData(block.GetBlockName(), "AcntNo", 0, block.AcntNo); // char 20
			_xaQuery.SetFieldData(block.GetBlockName(), "Pwd", 0, block.Pwd); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "FnoIsuNo", 0, block.FnoIsuNo); // char 12

			return true;
		}

		public XQCEXAT11300OutBlock1 GetBlock1()
		{
			XQCEXAT11300OutBlock1 instance = XQCEXAT11300OutBlock1.FromQuery(this);
			return instance;

		}

		public XQCEXAT11300OutBlock2 GetBlock2()
		{
			XQCEXAT11300OutBlock2 instance = XQCEXAT11300OutBlock2.FromQuery(this);
			return instance;

		}


	}

}
