using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQCFOFQ02400InBlock1 : XingBlock
	{
		/// <summary>
		/// CFOFQ02400InBlock1
		/// </summary>
		public const string _blockName = "CFOFQ02400InBlock1";
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
		/// CFOFQ02400InBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CFOFQ02400InBlock1
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
		/// 등록시장코드
		/// </summary>
		[XAQueryFieldAttribute("등록시장코드")]
		public string RegMktCode;
		/// <summary>
		/// 매수일자
		/// </summary>
		[XAQueryFieldAttribute("매수일자")]
		public string BuyDt;

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
			/// 등록시장코드
			/// </summary>
			public const string RegMktCode = "RegMktCode";
			/// <summary>
			/// 매수일자
			/// </summary>
			public const string BuyDt = "BuyDt";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.AcntNo,
			F.Pwd,
			F.RegMktCode,
			F.BuyDt,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["AcntNo"] = new XAQueryFieldInfo("char", AcntNo, AcntNo, "계좌번호", (decimal)20);
			dict["Pwd"] = new XAQueryFieldInfo("char", Pwd, Pwd, "비밀번호", (decimal)8);
			dict["RegMktCode"] = new XAQueryFieldInfo("char", RegMktCode, RegMktCode, "등록시장코드", (decimal)2);
			dict["BuyDt"] = new XAQueryFieldInfo("char", BuyDt, BuyDt, "매수일자", (decimal)8);

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

				case "RegMktCode":
					this.RegMktCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "BuyDt":
					this.BuyDt = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (RecCnt.ToString().Length > 5) return false; // long 5
			if (AcntNo?.Length > 20) return false; // char 20
			if (Pwd?.Length > 8) return false; // char 8
			if (RegMktCode?.Length > 2) return false; // char 2
			if (BuyDt?.Length > 8) return false; // char 8

			return true;
		}
	}

	public partial class XQCFOFQ02400OutBlock1 : XingBlock
	{
		/// <summary>
		/// CFOFQ02400OutBlock1
		/// </summary>
		public const string _blockName = "CFOFQ02400OutBlock1";
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
		/// CFOFQ02400OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CFOFQ02400OutBlock1
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
		/// 등록시장코드
		/// </summary>
		[XAQueryFieldAttribute("등록시장코드")]
		public string RegMktCode;
		/// <summary>
		/// 매수일자
		/// </summary>
		[XAQueryFieldAttribute("매수일자")]
		public string BuyDt;

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
			/// 등록시장코드
			/// </summary>
			public const string RegMktCode = "RegMktCode";
			/// <summary>
			/// 매수일자
			/// </summary>
			public const string BuyDt = "BuyDt";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.AcntNo,
			F.Pwd,
			F.RegMktCode,
			F.BuyDt,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["AcntNo"] = new XAQueryFieldInfo("char", AcntNo, AcntNo, "계좌번호", (decimal)20);
			dict["Pwd"] = new XAQueryFieldInfo("char", Pwd, Pwd, "비밀번호", (decimal)8);
			dict["RegMktCode"] = new XAQueryFieldInfo("char", RegMktCode, RegMktCode, "등록시장코드", (decimal)2);
			dict["BuyDt"] = new XAQueryFieldInfo("char", BuyDt, BuyDt, "매수일자", (decimal)8);

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

				case "RegMktCode":
					this.RegMktCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "BuyDt":
					this.BuyDt = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQCFOFQ02400OutBlock1 FromQuery(XQCFOFQ02400 query)
		{
			XQCFOFQ02400OutBlock1 block = new XQCFOFQ02400OutBlock1();
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
				block.RegMktCode = query.GetFieldData(block.GetBlockName(), "RegMktCode", 0).TrimEnd('?'); // char 2
				block.BuyDt = query.GetFieldData(block.GetBlockName(), "BuyDt", 0).TrimEnd('?'); // char 8

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
			if (RegMktCode?.Length > 2) return false; // char 2
			if (BuyDt?.Length > 8) return false; // char 8

			return true;
		}
	}

	public partial class XQCFOFQ02400OutBlock2 : XingBlock
	{
		/// <summary>
		/// CFOFQ02400OutBlock2
		/// </summary>
		public const string _blockName = "CFOFQ02400OutBlock2";
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
		/// CFOFQ02400OutBlock2
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CFOFQ02400OutBlock2
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
		/// 선물약정수량
		/// </summary>
		[XAQueryFieldAttribute("선물약정수량")]
		public long FutsCtrctQty;
		/// <summary>
		/// 옵션약정수량
		/// </summary>
		[XAQueryFieldAttribute("옵션약정수량")]
		public long OptCtrctQty;
		/// <summary>
		/// 약정수량
		/// </summary>
		[XAQueryFieldAttribute("약정수량")]
		public long CtrctQty;
		/// <summary>
		/// 선물약정금액
		/// </summary>
		[XAQueryFieldAttribute("선물약정금액")]
		public long FutsCtrctAmt;
		/// <summary>
		/// 선물매수약정금액
		/// </summary>
		[XAQueryFieldAttribute("선물매수약정금액")]
		public long FutsBuyctrAmt;
		/// <summary>
		/// 선물매도약정금액
		/// </summary>
		[XAQueryFieldAttribute("선물매도약정금액")]
		public long FutsSlctrAmt;
		/// <summary>
		/// 콜옵션약정금액
		/// </summary>
		[XAQueryFieldAttribute("콜옵션약정금액")]
		public long CalloptCtrctAmt;
		/// <summary>
		/// 콜매수금액
		/// </summary>
		[XAQueryFieldAttribute("콜매수금액")]
		public long CallBuyAmt;
		/// <summary>
		/// 콜매도금액
		/// </summary>
		[XAQueryFieldAttribute("콜매도금액")]
		public long CallSellAmt;
		/// <summary>
		/// 풋옵션약정금액
		/// </summary>
		[XAQueryFieldAttribute("풋옵션약정금액")]
		public long PutoptCtrctAmt;
		/// <summary>
		/// 풋매수금액
		/// </summary>
		[XAQueryFieldAttribute("풋매수금액")]
		public long PutBuyAmt;
		/// <summary>
		/// 풋매도금액
		/// </summary>
		[XAQueryFieldAttribute("풋매도금액")]
		public long PutSellAmt;
		/// <summary>
		/// 전체약정금액
		/// </summary>
		[XAQueryFieldAttribute("전체약정금액")]
		public long AllCtrctAmt;
		/// <summary>
		/// 매수약정누계금액
		/// </summary>
		[XAQueryFieldAttribute("매수약정누계금액")]
		public long BuyctrAsmAmt;
		/// <summary>
		/// 매도약정누계금액
		/// </summary>
		[XAQueryFieldAttribute("매도약정누계금액")]
		public long SlctrAsmAmt;
		/// <summary>
		/// 선물손익합계
		/// </summary>
		[XAQueryFieldAttribute("선물손익합계")]
		public long FutsPnlSum;
		/// <summary>
		/// 옵션손익합계
		/// </summary>
		[XAQueryFieldAttribute("옵션손익합계")]
		public long OptPnlSum;
		/// <summary>
		/// 전체손익합계
		/// </summary>
		[XAQueryFieldAttribute("전체손익합계")]
		public long AllPnlSum;

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
			/// 선물약정수량
			/// </summary>
			public const string FutsCtrctQty = "FutsCtrctQty";
			/// <summary>
			/// 옵션약정수량
			/// </summary>
			public const string OptCtrctQty = "OptCtrctQty";
			/// <summary>
			/// 약정수량
			/// </summary>
			public const string CtrctQty = "CtrctQty";
			/// <summary>
			/// 선물약정금액
			/// </summary>
			public const string FutsCtrctAmt = "FutsCtrctAmt";
			/// <summary>
			/// 선물매수약정금액
			/// </summary>
			public const string FutsBuyctrAmt = "FutsBuyctrAmt";
			/// <summary>
			/// 선물매도약정금액
			/// </summary>
			public const string FutsSlctrAmt = "FutsSlctrAmt";
			/// <summary>
			/// 콜옵션약정금액
			/// </summary>
			public const string CalloptCtrctAmt = "CalloptCtrctAmt";
			/// <summary>
			/// 콜매수금액
			/// </summary>
			public const string CallBuyAmt = "CallBuyAmt";
			/// <summary>
			/// 콜매도금액
			/// </summary>
			public const string CallSellAmt = "CallSellAmt";
			/// <summary>
			/// 풋옵션약정금액
			/// </summary>
			public const string PutoptCtrctAmt = "PutoptCtrctAmt";
			/// <summary>
			/// 풋매수금액
			/// </summary>
			public const string PutBuyAmt = "PutBuyAmt";
			/// <summary>
			/// 풋매도금액
			/// </summary>
			public const string PutSellAmt = "PutSellAmt";
			/// <summary>
			/// 전체약정금액
			/// </summary>
			public const string AllCtrctAmt = "AllCtrctAmt";
			/// <summary>
			/// 매수약정누계금액
			/// </summary>
			public const string BuyctrAsmAmt = "BuyctrAsmAmt";
			/// <summary>
			/// 매도약정누계금액
			/// </summary>
			public const string SlctrAsmAmt = "SlctrAsmAmt";
			/// <summary>
			/// 선물손익합계
			/// </summary>
			public const string FutsPnlSum = "FutsPnlSum";
			/// <summary>
			/// 옵션손익합계
			/// </summary>
			public const string OptPnlSum = "OptPnlSum";
			/// <summary>
			/// 전체손익합계
			/// </summary>
			public const string AllPnlSum = "AllPnlSum";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.AcntNm,
			F.FutsCtrctQty,
			F.OptCtrctQty,
			F.CtrctQty,
			F.FutsCtrctAmt,
			F.FutsBuyctrAmt,
			F.FutsSlctrAmt,
			F.CalloptCtrctAmt,
			F.CallBuyAmt,
			F.CallSellAmt,
			F.PutoptCtrctAmt,
			F.PutBuyAmt,
			F.PutSellAmt,
			F.AllCtrctAmt,
			F.BuyctrAsmAmt,
			F.SlctrAsmAmt,
			F.FutsPnlSum,
			F.OptPnlSum,
			F.AllPnlSum,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["AcntNm"] = new XAQueryFieldInfo("char", AcntNm, AcntNm, "계좌명", (decimal)40);
			dict["FutsCtrctQty"] = new XAQueryFieldInfo("long", FutsCtrctQty, FutsCtrctQty.ToString("d16"), "선물약정수량", (decimal)16);
			dict["OptCtrctQty"] = new XAQueryFieldInfo("long", OptCtrctQty, OptCtrctQty.ToString("d16"), "옵션약정수량", (decimal)16);
			dict["CtrctQty"] = new XAQueryFieldInfo("long", CtrctQty, CtrctQty.ToString("d16"), "약정수량", (decimal)16);
			dict["FutsCtrctAmt"] = new XAQueryFieldInfo("long", FutsCtrctAmt, FutsCtrctAmt.ToString("d16"), "선물약정금액", (decimal)16);
			dict["FutsBuyctrAmt"] = new XAQueryFieldInfo("long", FutsBuyctrAmt, FutsBuyctrAmt.ToString("d16"), "선물매수약정금액", (decimal)16);
			dict["FutsSlctrAmt"] = new XAQueryFieldInfo("long", FutsSlctrAmt, FutsSlctrAmt.ToString("d16"), "선물매도약정금액", (decimal)16);
			dict["CalloptCtrctAmt"] = new XAQueryFieldInfo("long", CalloptCtrctAmt, CalloptCtrctAmt.ToString("d16"), "콜옵션약정금액", (decimal)16);
			dict["CallBuyAmt"] = new XAQueryFieldInfo("long", CallBuyAmt, CallBuyAmt.ToString("d16"), "콜매수금액", (decimal)16);
			dict["CallSellAmt"] = new XAQueryFieldInfo("long", CallSellAmt, CallSellAmt.ToString("d16"), "콜매도금액", (decimal)16);
			dict["PutoptCtrctAmt"] = new XAQueryFieldInfo("long", PutoptCtrctAmt, PutoptCtrctAmt.ToString("d16"), "풋옵션약정금액", (decimal)16);
			dict["PutBuyAmt"] = new XAQueryFieldInfo("long", PutBuyAmt, PutBuyAmt.ToString("d16"), "풋매수금액", (decimal)16);
			dict["PutSellAmt"] = new XAQueryFieldInfo("long", PutSellAmt, PutSellAmt.ToString("d16"), "풋매도금액", (decimal)16);
			dict["AllCtrctAmt"] = new XAQueryFieldInfo("long", AllCtrctAmt, AllCtrctAmt.ToString("d16"), "전체약정금액", (decimal)16);
			dict["BuyctrAsmAmt"] = new XAQueryFieldInfo("long", BuyctrAsmAmt, BuyctrAsmAmt.ToString("d16"), "매수약정누계금액", (decimal)16);
			dict["SlctrAsmAmt"] = new XAQueryFieldInfo("long", SlctrAsmAmt, SlctrAsmAmt.ToString("d16"), "매도약정누계금액", (decimal)16);
			dict["FutsPnlSum"] = new XAQueryFieldInfo("long", FutsPnlSum, FutsPnlSum.ToString("d16"), "선물손익합계", (decimal)16);
			dict["OptPnlSum"] = new XAQueryFieldInfo("long", OptPnlSum, OptPnlSum.ToString("d16"), "옵션손익합계", (decimal)16);
			dict["AllPnlSum"] = new XAQueryFieldInfo("long", AllPnlSum, AllPnlSum.ToString("d16"), "전체손익합계", (decimal)16);

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

				case "FutsCtrctQty":
					this.FutsCtrctQty = fieldInfo.FieldValue.ParseLong("FutsCtrctQty");
				break;

				case "OptCtrctQty":
					this.OptCtrctQty = fieldInfo.FieldValue.ParseLong("OptCtrctQty");
				break;

				case "CtrctQty":
					this.CtrctQty = fieldInfo.FieldValue.ParseLong("CtrctQty");
				break;

				case "FutsCtrctAmt":
					this.FutsCtrctAmt = fieldInfo.FieldValue.ParseLong("FutsCtrctAmt");
				break;

				case "FutsBuyctrAmt":
					this.FutsBuyctrAmt = fieldInfo.FieldValue.ParseLong("FutsBuyctrAmt");
				break;

				case "FutsSlctrAmt":
					this.FutsSlctrAmt = fieldInfo.FieldValue.ParseLong("FutsSlctrAmt");
				break;

				case "CalloptCtrctAmt":
					this.CalloptCtrctAmt = fieldInfo.FieldValue.ParseLong("CalloptCtrctAmt");
				break;

				case "CallBuyAmt":
					this.CallBuyAmt = fieldInfo.FieldValue.ParseLong("CallBuyAmt");
				break;

				case "CallSellAmt":
					this.CallSellAmt = fieldInfo.FieldValue.ParseLong("CallSellAmt");
				break;

				case "PutoptCtrctAmt":
					this.PutoptCtrctAmt = fieldInfo.FieldValue.ParseLong("PutoptCtrctAmt");
				break;

				case "PutBuyAmt":
					this.PutBuyAmt = fieldInfo.FieldValue.ParseLong("PutBuyAmt");
				break;

				case "PutSellAmt":
					this.PutSellAmt = fieldInfo.FieldValue.ParseLong("PutSellAmt");
				break;

				case "AllCtrctAmt":
					this.AllCtrctAmt = fieldInfo.FieldValue.ParseLong("AllCtrctAmt");
				break;

				case "BuyctrAsmAmt":
					this.BuyctrAsmAmt = fieldInfo.FieldValue.ParseLong("BuyctrAsmAmt");
				break;

				case "SlctrAsmAmt":
					this.SlctrAsmAmt = fieldInfo.FieldValue.ParseLong("SlctrAsmAmt");
				break;

				case "FutsPnlSum":
					this.FutsPnlSum = fieldInfo.FieldValue.ParseLong("FutsPnlSum");
				break;

				case "OptPnlSum":
					this.OptPnlSum = fieldInfo.FieldValue.ParseLong("OptPnlSum");
				break;

				case "AllPnlSum":
					this.AllPnlSum = fieldInfo.FieldValue.ParseLong("AllPnlSum");
				break;


			}
		}

		public static XQCFOFQ02400OutBlock2 FromQuery(XQCFOFQ02400 query)
		{
			XQCFOFQ02400OutBlock2 block = new XQCFOFQ02400OutBlock2();
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
				block.FutsCtrctQty = query.GetFieldData(block.GetBlockName(), "FutsCtrctQty", 0).ParseLong("FutsCtrctQty"); // long 16
				block.OptCtrctQty = query.GetFieldData(block.GetBlockName(), "OptCtrctQty", 0).ParseLong("OptCtrctQty"); // long 16
				block.CtrctQty = query.GetFieldData(block.GetBlockName(), "CtrctQty", 0).ParseLong("CtrctQty"); // long 16
				block.FutsCtrctAmt = query.GetFieldData(block.GetBlockName(), "FutsCtrctAmt", 0).ParseLong("FutsCtrctAmt"); // long 16
				block.FutsBuyctrAmt = query.GetFieldData(block.GetBlockName(), "FutsBuyctrAmt", 0).ParseLong("FutsBuyctrAmt"); // long 16
				block.FutsSlctrAmt = query.GetFieldData(block.GetBlockName(), "FutsSlctrAmt", 0).ParseLong("FutsSlctrAmt"); // long 16
				block.CalloptCtrctAmt = query.GetFieldData(block.GetBlockName(), "CalloptCtrctAmt", 0).ParseLong("CalloptCtrctAmt"); // long 16
				block.CallBuyAmt = query.GetFieldData(block.GetBlockName(), "CallBuyAmt", 0).ParseLong("CallBuyAmt"); // long 16
				block.CallSellAmt = query.GetFieldData(block.GetBlockName(), "CallSellAmt", 0).ParseLong("CallSellAmt"); // long 16
				block.PutoptCtrctAmt = query.GetFieldData(block.GetBlockName(), "PutoptCtrctAmt", 0).ParseLong("PutoptCtrctAmt"); // long 16
				block.PutBuyAmt = query.GetFieldData(block.GetBlockName(), "PutBuyAmt", 0).ParseLong("PutBuyAmt"); // long 16
				block.PutSellAmt = query.GetFieldData(block.GetBlockName(), "PutSellAmt", 0).ParseLong("PutSellAmt"); // long 16
				block.AllCtrctAmt = query.GetFieldData(block.GetBlockName(), "AllCtrctAmt", 0).ParseLong("AllCtrctAmt"); // long 16
				block.BuyctrAsmAmt = query.GetFieldData(block.GetBlockName(), "BuyctrAsmAmt", 0).ParseLong("BuyctrAsmAmt"); // long 16
				block.SlctrAsmAmt = query.GetFieldData(block.GetBlockName(), "SlctrAsmAmt", 0).ParseLong("SlctrAsmAmt"); // long 16
				block.FutsPnlSum = query.GetFieldData(block.GetBlockName(), "FutsPnlSum", 0).ParseLong("FutsPnlSum"); // long 16
				block.OptPnlSum = query.GetFieldData(block.GetBlockName(), "OptPnlSum", 0).ParseLong("OptPnlSum"); // long 16
				block.AllPnlSum = query.GetFieldData(block.GetBlockName(), "AllPnlSum", 0).ParseLong("AllPnlSum"); // long 16

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
			if (FutsCtrctQty.ToString().Length > 16) return false; // long 16
			if (OptCtrctQty.ToString().Length > 16) return false; // long 16
			if (CtrctQty.ToString().Length > 16) return false; // long 16
			if (FutsCtrctAmt.ToString().Length > 16) return false; // long 16
			if (FutsBuyctrAmt.ToString().Length > 16) return false; // long 16
			if (FutsSlctrAmt.ToString().Length > 16) return false; // long 16
			if (CalloptCtrctAmt.ToString().Length > 16) return false; // long 16
			if (CallBuyAmt.ToString().Length > 16) return false; // long 16
			if (CallSellAmt.ToString().Length > 16) return false; // long 16
			if (PutoptCtrctAmt.ToString().Length > 16) return false; // long 16
			if (PutBuyAmt.ToString().Length > 16) return false; // long 16
			if (PutSellAmt.ToString().Length > 16) return false; // long 16
			if (AllCtrctAmt.ToString().Length > 16) return false; // long 16
			if (BuyctrAsmAmt.ToString().Length > 16) return false; // long 16
			if (SlctrAsmAmt.ToString().Length > 16) return false; // long 16
			if (FutsPnlSum.ToString().Length > 16) return false; // long 16
			if (OptPnlSum.ToString().Length > 16) return false; // long 16
			if (AllPnlSum.ToString().Length > 16) return false; // long 16

			return true;
		}
	}

	public partial class XQCFOFQ02400OutBlock3 : XingBlock
	{
		/// <summary>
		/// CFOFQ02400OutBlock3
		/// </summary>
		public const string _blockName = "CFOFQ02400OutBlock3";
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
		/// CFOFQ02400OutBlock3
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CFOFQ02400OutBlock3
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
		/// 선물옵션품목구분
		/// </summary>
		[XAQueryFieldAttribute("선물옵션품목구분")]
		public char FnoClssCode;
		/// <summary>
		/// 선물매도수량
		/// </summary>
		[XAQueryFieldAttribute("선물매도수량")]
		public long FutsSellQty;
		/// <summary>
		/// 선물매도손익
		/// </summary>
		[XAQueryFieldAttribute("선물매도손익")]
		public long FutsSellPnl;
		/// <summary>
		/// 선물매수수량
		/// </summary>
		[XAQueryFieldAttribute("선물매수수량")]
		public long FutsBuyQty;
		/// <summary>
		/// 선물매수손익
		/// </summary>
		[XAQueryFieldAttribute("선물매수손익")]
		public long FutsBuyPnl;
		/// <summary>
		/// 콜매도수량
		/// </summary>
		[XAQueryFieldAttribute("콜매도수량")]
		public long CallSellQty;
		/// <summary>
		/// 콜매도손익
		/// </summary>
		[XAQueryFieldAttribute("콜매도손익")]
		public long CallSellPnl;
		/// <summary>
		/// 콜매수수량
		/// </summary>
		[XAQueryFieldAttribute("콜매수수량")]
		public long CallBuyQty;
		/// <summary>
		/// 콜매수손익
		/// </summary>
		[XAQueryFieldAttribute("콜매수손익")]
		public long CallBuyPnl;
		/// <summary>
		/// 풋매도수량
		/// </summary>
		[XAQueryFieldAttribute("풋매도수량")]
		public long PutSellQty;
		/// <summary>
		/// 풋매도손익
		/// </summary>
		[XAQueryFieldAttribute("풋매도손익")]
		public long PutSellPnl;
		/// <summary>
		/// 풋매수수량
		/// </summary>
		[XAQueryFieldAttribute("풋매수수량")]
		public long PutBuyQty;
		/// <summary>
		/// 풋매수손익
		/// </summary>
		[XAQueryFieldAttribute("풋매수손익")]
		public long PutBuyPnl;

		public static class F
		{
			/// <summary>
			/// 선물옵션품목구분
			/// </summary>
			public const string FnoClssCode = "FnoClssCode";
			/// <summary>
			/// 선물매도수량
			/// </summary>
			public const string FutsSellQty = "FutsSellQty";
			/// <summary>
			/// 선물매도손익
			/// </summary>
			public const string FutsSellPnl = "FutsSellPnl";
			/// <summary>
			/// 선물매수수량
			/// </summary>
			public const string FutsBuyQty = "FutsBuyQty";
			/// <summary>
			/// 선물매수손익
			/// </summary>
			public const string FutsBuyPnl = "FutsBuyPnl";
			/// <summary>
			/// 콜매도수량
			/// </summary>
			public const string CallSellQty = "CallSellQty";
			/// <summary>
			/// 콜매도손익
			/// </summary>
			public const string CallSellPnl = "CallSellPnl";
			/// <summary>
			/// 콜매수수량
			/// </summary>
			public const string CallBuyQty = "CallBuyQty";
			/// <summary>
			/// 콜매수손익
			/// </summary>
			public const string CallBuyPnl = "CallBuyPnl";
			/// <summary>
			/// 풋매도수량
			/// </summary>
			public const string PutSellQty = "PutSellQty";
			/// <summary>
			/// 풋매도손익
			/// </summary>
			public const string PutSellPnl = "PutSellPnl";
			/// <summary>
			/// 풋매수수량
			/// </summary>
			public const string PutBuyQty = "PutBuyQty";
			/// <summary>
			/// 풋매수손익
			/// </summary>
			public const string PutBuyPnl = "PutBuyPnl";
		}

		public static string[] AllFields = new string[]
		{
			F.FnoClssCode,
			F.FutsSellQty,
			F.FutsSellPnl,
			F.FutsBuyQty,
			F.FutsBuyPnl,
			F.CallSellQty,
			F.CallSellPnl,
			F.CallBuyQty,
			F.CallBuyPnl,
			F.PutSellQty,
			F.PutSellPnl,
			F.PutBuyQty,
			F.PutBuyPnl,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["FnoClssCode"] = new XAQueryFieldInfo("char", FnoClssCode, FnoClssCode.ToString(), "선물옵션품목구분", (decimal)1);
			dict["FutsSellQty"] = new XAQueryFieldInfo("long", FutsSellQty, FutsSellQty.ToString("d16"), "선물매도수량", (decimal)16);
			dict["FutsSellPnl"] = new XAQueryFieldInfo("long", FutsSellPnl, FutsSellPnl.ToString("d16"), "선물매도손익", (decimal)16);
			dict["FutsBuyQty"] = new XAQueryFieldInfo("long", FutsBuyQty, FutsBuyQty.ToString("d16"), "선물매수수량", (decimal)16);
			dict["FutsBuyPnl"] = new XAQueryFieldInfo("long", FutsBuyPnl, FutsBuyPnl.ToString("d16"), "선물매수손익", (decimal)16);
			dict["CallSellQty"] = new XAQueryFieldInfo("long", CallSellQty, CallSellQty.ToString("d16"), "콜매도수량", (decimal)16);
			dict["CallSellPnl"] = new XAQueryFieldInfo("long", CallSellPnl, CallSellPnl.ToString("d16"), "콜매도손익", (decimal)16);
			dict["CallBuyQty"] = new XAQueryFieldInfo("long", CallBuyQty, CallBuyQty.ToString("d16"), "콜매수수량", (decimal)16);
			dict["CallBuyPnl"] = new XAQueryFieldInfo("long", CallBuyPnl, CallBuyPnl.ToString("d16"), "콜매수손익", (decimal)16);
			dict["PutSellQty"] = new XAQueryFieldInfo("long", PutSellQty, PutSellQty.ToString("d16"), "풋매도수량", (decimal)16);
			dict["PutSellPnl"] = new XAQueryFieldInfo("long", PutSellPnl, PutSellPnl.ToString("d16"), "풋매도손익", (decimal)16);
			dict["PutBuyQty"] = new XAQueryFieldInfo("long", PutBuyQty, PutBuyQty.ToString("d16"), "풋매수수량", (decimal)16);
			dict["PutBuyPnl"] = new XAQueryFieldInfo("long", PutBuyPnl, PutBuyPnl.ToString("d16"), "풋매수손익", (decimal)16);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "FnoClssCode":
					this.FnoClssCode = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "FutsSellQty":
					this.FutsSellQty = fieldInfo.FieldValue.ParseLong("FutsSellQty");
				break;

				case "FutsSellPnl":
					this.FutsSellPnl = fieldInfo.FieldValue.ParseLong("FutsSellPnl");
				break;

				case "FutsBuyQty":
					this.FutsBuyQty = fieldInfo.FieldValue.ParseLong("FutsBuyQty");
				break;

				case "FutsBuyPnl":
					this.FutsBuyPnl = fieldInfo.FieldValue.ParseLong("FutsBuyPnl");
				break;

				case "CallSellQty":
					this.CallSellQty = fieldInfo.FieldValue.ParseLong("CallSellQty");
				break;

				case "CallSellPnl":
					this.CallSellPnl = fieldInfo.FieldValue.ParseLong("CallSellPnl");
				break;

				case "CallBuyQty":
					this.CallBuyQty = fieldInfo.FieldValue.ParseLong("CallBuyQty");
				break;

				case "CallBuyPnl":
					this.CallBuyPnl = fieldInfo.FieldValue.ParseLong("CallBuyPnl");
				break;

				case "PutSellQty":
					this.PutSellQty = fieldInfo.FieldValue.ParseLong("PutSellQty");
				break;

				case "PutSellPnl":
					this.PutSellPnl = fieldInfo.FieldValue.ParseLong("PutSellPnl");
				break;

				case "PutBuyQty":
					this.PutBuyQty = fieldInfo.FieldValue.ParseLong("PutBuyQty");
				break;

				case "PutBuyPnl":
					this.PutBuyPnl = fieldInfo.FieldValue.ParseLong("PutBuyPnl");
				break;


			}
		}

		public static XQCFOFQ02400OutBlock3[] ListFromQuery(XQCFOFQ02400 query)
		{
			int count = query.GetBlockCount(XQCFOFQ02400OutBlock3.BlockName);
			List<XQCFOFQ02400OutBlock3> list = new List<XQCFOFQ02400OutBlock3>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQCFOFQ02400OutBlock3 block = new XQCFOFQ02400OutBlock3();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.FnoClssCode = query.GetFieldData(block.GetBlockName(), "FnoClssCode", i).FirstOrDefault(); // char 1
					block.FutsSellQty = query.GetFieldData(block.GetBlockName(), "FutsSellQty", i).ParseLong("FutsSellQty"); // long 16
					block.FutsSellPnl = query.GetFieldData(block.GetBlockName(), "FutsSellPnl", i).ParseLong("FutsSellPnl"); // long 16
					block.FutsBuyQty = query.GetFieldData(block.GetBlockName(), "FutsBuyQty", i).ParseLong("FutsBuyQty"); // long 16
					block.FutsBuyPnl = query.GetFieldData(block.GetBlockName(), "FutsBuyPnl", i).ParseLong("FutsBuyPnl"); // long 16
					block.CallSellQty = query.GetFieldData(block.GetBlockName(), "CallSellQty", i).ParseLong("CallSellQty"); // long 16
					block.CallSellPnl = query.GetFieldData(block.GetBlockName(), "CallSellPnl", i).ParseLong("CallSellPnl"); // long 16
					block.CallBuyQty = query.GetFieldData(block.GetBlockName(), "CallBuyQty", i).ParseLong("CallBuyQty"); // long 16
					block.CallBuyPnl = query.GetFieldData(block.GetBlockName(), "CallBuyPnl", i).ParseLong("CallBuyPnl"); // long 16
					block.PutSellQty = query.GetFieldData(block.GetBlockName(), "PutSellQty", i).ParseLong("PutSellQty"); // long 16
					block.PutSellPnl = query.GetFieldData(block.GetBlockName(), "PutSellPnl", i).ParseLong("PutSellPnl"); // long 16
					block.PutBuyQty = query.GetFieldData(block.GetBlockName(), "PutBuyQty", i).ParseLong("PutBuyQty"); // long 16
					block.PutBuyPnl = query.GetFieldData(block.GetBlockName(), "PutBuyPnl", i).ParseLong("PutBuyPnl"); // long 16

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
			// FnoClssCode char 1
			if (FutsSellQty.ToString().Length > 16) return false; // long 16
			if (FutsSellPnl.ToString().Length > 16) return false; // long 16
			if (FutsBuyQty.ToString().Length > 16) return false; // long 16
			if (FutsBuyPnl.ToString().Length > 16) return false; // long 16
			if (CallSellQty.ToString().Length > 16) return false; // long 16
			if (CallSellPnl.ToString().Length > 16) return false; // long 16
			if (CallBuyQty.ToString().Length > 16) return false; // long 16
			if (CallBuyPnl.ToString().Length > 16) return false; // long 16
			if (PutSellQty.ToString().Length > 16) return false; // long 16
			if (PutSellPnl.ToString().Length > 16) return false; // long 16
			if (PutBuyQty.ToString().Length > 16) return false; // long 16
			if (PutBuyPnl.ToString().Length > 16) return false; // long 16

			return true;
		}
	}

	public partial class XQCFOFQ02400OutBlock4 : XingBlock
	{
		/// <summary>
		/// CFOFQ02400OutBlock4
		/// </summary>
		public const string _blockName = "CFOFQ02400OutBlock4";
		/// <summary>
		/// Out3(*EMPTY*)
		/// </summary>
		public const string _blockDesc = "Out3(*EMPTY*)";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// true
		/// </summary>
		public const bool _hasOccurs = true;
		/// <summary>
		/// CFOFQ02400OutBlock4
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CFOFQ02400OutBlock4
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// Out3(*EMPTY*)
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
		/// 종목번호
		/// </summary>
		[XAQueryFieldAttribute("종목번호")]
		public string IsuNo;
		/// <summary>
		/// 종목명
		/// </summary>
		[XAQueryFieldAttribute("종목명")]
		public string IsuNm;
		/// <summary>
		/// 매매구분
		/// </summary>
		[XAQueryFieldAttribute("매매구분")]
		public char BnsTpCode;
		/// <summary>
		/// 매매구분
		/// </summary>
		[XAQueryFieldAttribute("매매구분")]
		public string BnsTpNm;
		/// <summary>
		/// 잔고수량
		/// </summary>
		[XAQueryFieldAttribute("잔고수량")]
		public long BalQty;
		/// <summary>
		/// 평균가
		/// </summary>
		[XAQueryFieldAttribute("평균가")]
		public double FnoAvrPrc;
		/// <summary>
		/// 당초금액
		/// </summary>
		[XAQueryFieldAttribute("당초금액")]
		public long BgnAmt;
		/// <summary>
		/// 당일청산수량
		/// </summary>
		[XAQueryFieldAttribute("당일청산수량")]
		public long ThdayLqdtQty;
		/// <summary>
		/// 현재가
		/// </summary>
		[XAQueryFieldAttribute("현재가")]
		public double Curprc;
		/// <summary>
		/// 평가금액
		/// </summary>
		[XAQueryFieldAttribute("평가금액")]
		public long EvalAmt;
		/// <summary>
		/// 평가손익금액
		/// </summary>
		[XAQueryFieldAttribute("평가손익금액")]
		public long EvalPnlAmt;
		/// <summary>
		/// 평가수익률
		/// </summary>
		[XAQueryFieldAttribute("평가수익률")]
		public double EvalErnrat;

		public static class F
		{
			/// <summary>
			/// 종목번호
			/// </summary>
			public const string IsuNo = "IsuNo";
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
			/// 잔고수량
			/// </summary>
			public const string BalQty = "BalQty";
			/// <summary>
			/// 평균가
			/// </summary>
			public const string FnoAvrPrc = "FnoAvrPrc";
			/// <summary>
			/// 당초금액
			/// </summary>
			public const string BgnAmt = "BgnAmt";
			/// <summary>
			/// 당일청산수량
			/// </summary>
			public const string ThdayLqdtQty = "ThdayLqdtQty";
			/// <summary>
			/// 현재가
			/// </summary>
			public const string Curprc = "Curprc";
			/// <summary>
			/// 평가금액
			/// </summary>
			public const string EvalAmt = "EvalAmt";
			/// <summary>
			/// 평가손익금액
			/// </summary>
			public const string EvalPnlAmt = "EvalPnlAmt";
			/// <summary>
			/// 평가수익률
			/// </summary>
			public const string EvalErnrat = "EvalErnrat";
		}

		public static string[] AllFields = new string[]
		{
			F.IsuNo,
			F.IsuNm,
			F.BnsTpCode,
			F.BnsTpNm,
			F.BalQty,
			F.FnoAvrPrc,
			F.BgnAmt,
			F.ThdayLqdtQty,
			F.Curprc,
			F.EvalAmt,
			F.EvalPnlAmt,
			F.EvalErnrat,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["IsuNo"] = new XAQueryFieldInfo("char", IsuNo, IsuNo, "종목번호", (decimal)12);
			dict["IsuNm"] = new XAQueryFieldInfo("char", IsuNm, IsuNm, "종목명", (decimal)40);
			dict["BnsTpCode"] = new XAQueryFieldInfo("char", BnsTpCode, BnsTpCode.ToString(), "매매구분", (decimal)1);
			dict["BnsTpNm"] = new XAQueryFieldInfo("char", BnsTpNm, BnsTpNm, "매매구분", (decimal)10);
			dict["BalQty"] = new XAQueryFieldInfo("long", BalQty, BalQty.ToString("d16"), "잔고수량", (decimal)16);
			dict["FnoAvrPrc"] = new XAQueryFieldInfo("double", FnoAvrPrc, FnoAvrPrc.ToString("0000000000000000000.00000000"), "평균가", (decimal)19.8);
			dict["BgnAmt"] = new XAQueryFieldInfo("long", BgnAmt, BgnAmt.ToString("d16"), "당초금액", (decimal)16);
			dict["ThdayLqdtQty"] = new XAQueryFieldInfo("long", ThdayLqdtQty, ThdayLqdtQty.ToString("d16"), "당일청산수량", (decimal)16);
			dict["Curprc"] = new XAQueryFieldInfo("double", Curprc, Curprc.ToString("0000000000000.00"), "현재가", (decimal)13.2);
			dict["EvalAmt"] = new XAQueryFieldInfo("long", EvalAmt, EvalAmt.ToString("d16"), "평가금액", (decimal)16);
			dict["EvalPnlAmt"] = new XAQueryFieldInfo("long", EvalPnlAmt, EvalPnlAmt.ToString("d16"), "평가손익금액", (decimal)16);
			dict["EvalErnrat"] = new XAQueryFieldInfo("double", EvalErnrat, EvalErnrat.ToString("000000000000.000000"), "평가수익률", (decimal)12.6);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "IsuNo":
					this.IsuNo = fieldInfo.FieldValue.TrimEnd('?');
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

				case "BalQty":
					this.BalQty = fieldInfo.FieldValue.ParseLong("BalQty");
				break;

				case "FnoAvrPrc":
					this.FnoAvrPrc = fieldInfo.FieldValue.ParseDouble("FnoAvrPrc");
				break;

				case "BgnAmt":
					this.BgnAmt = fieldInfo.FieldValue.ParseLong("BgnAmt");
				break;

				case "ThdayLqdtQty":
					this.ThdayLqdtQty = fieldInfo.FieldValue.ParseLong("ThdayLqdtQty");
				break;

				case "Curprc":
					this.Curprc = fieldInfo.FieldValue.ParseDouble("Curprc");
				break;

				case "EvalAmt":
					this.EvalAmt = fieldInfo.FieldValue.ParseLong("EvalAmt");
				break;

				case "EvalPnlAmt":
					this.EvalPnlAmt = fieldInfo.FieldValue.ParseLong("EvalPnlAmt");
				break;

				case "EvalErnrat":
					this.EvalErnrat = fieldInfo.FieldValue.ParseDouble("EvalErnrat");
				break;


			}
		}

		public static XQCFOFQ02400OutBlock4[] ListFromQuery(XQCFOFQ02400 query)
		{
			int count = query.GetBlockCount(XQCFOFQ02400OutBlock4.BlockName);
			List<XQCFOFQ02400OutBlock4> list = new List<XQCFOFQ02400OutBlock4>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQCFOFQ02400OutBlock4 block = new XQCFOFQ02400OutBlock4();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.IsuNo = query.GetFieldData(block.GetBlockName(), "IsuNo", i).TrimEnd('?'); // char 12
					block.IsuNm = query.GetFieldData(block.GetBlockName(), "IsuNm", i).TrimEnd('?'); // char 40
					block.BnsTpCode = query.GetFieldData(block.GetBlockName(), "BnsTpCode", i).FirstOrDefault(); // char 1
					block.BnsTpNm = query.GetFieldData(block.GetBlockName(), "BnsTpNm", i).TrimEnd('?'); // char 10
					block.BalQty = query.GetFieldData(block.GetBlockName(), "BalQty", i).ParseLong("BalQty"); // long 16
					block.FnoAvrPrc = query.GetFieldData(block.GetBlockName(), "FnoAvrPrc", i).ParseDouble("FnoAvrPrc"); // double 19.8
					block.BgnAmt = query.GetFieldData(block.GetBlockName(), "BgnAmt", i).ParseLong("BgnAmt"); // long 16
					block.ThdayLqdtQty = query.GetFieldData(block.GetBlockName(), "ThdayLqdtQty", i).ParseLong("ThdayLqdtQty"); // long 16
					block.Curprc = query.GetFieldData(block.GetBlockName(), "Curprc", i).ParseDouble("Curprc"); // double 13.2
					block.EvalAmt = query.GetFieldData(block.GetBlockName(), "EvalAmt", i).ParseLong("EvalAmt"); // long 16
					block.EvalPnlAmt = query.GetFieldData(block.GetBlockName(), "EvalPnlAmt", i).ParseLong("EvalPnlAmt"); // long 16
					block.EvalErnrat = query.GetFieldData(block.GetBlockName(), "EvalErnrat", i).ParseDouble("EvalErnrat"); // double 12.6

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
			if (IsuNo?.Length > 12) return false; // char 12
			if (IsuNm?.Length > 40) return false; // char 40
			// BnsTpCode char 1
			if (BnsTpNm?.Length > 10) return false; // char 10
			if (BalQty.ToString().Length > 16) return false; // long 16
			// FnoAvrPrc double 19.8
			if (BgnAmt.ToString().Length > 16) return false; // long 16
			if (ThdayLqdtQty.ToString().Length > 16) return false; // long 16
			// Curprc double 13.2
			if (EvalAmt.ToString().Length > 16) return false; // long 16
			if (EvalPnlAmt.ToString().Length > 16) return false; // long 16
			// EvalErnrat double 12.6

			return true;
		}
	}

	/// <summary>
	/// 계좌 미결제 약정현황(평균가)
	/// </summary>
	public partial class XQCFOFQ02400 : XingQuery
	{
		/// <summary>
		/// CFOFQ02400
		/// </summary>
		public const string _typeName = "CFOFQ02400";
		/// <summary>
		/// 계좌 미결제 약정현황(평균가)
		/// </summary>
		public const string _typeDesc = "계좌 미결제 약정현황(평균가)";
		/// <summary>
		/// CFOFQ02400
		/// </summary>
		public const string _service = "CFOFQ02400";
		/// <summary>
		/// B
		/// </summary>
		public const string _headType = "B";
		/// <summary>
		/// 김정현
		/// </summary>
		public const string _creator = "김정현";
		/// <summary>
		/// 2012/03/16 14:07:10
		/// </summary>
		public const string _createdDate = "2012/03/16 14:07:10";
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
		/// CFOFQ02400
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 계좌 미결제 약정현황(평균가)
		/// </summary>
		public string TypeDesc => _typeDesc;
		/// <summary>
		/// CFOFQ02400
		/// </summary>
		public string Service => _service;
		/// <summary>
		/// B
		/// </summary>
		public string HeadType => _headType;
		/// <summary>
		/// 김정현
		/// </summary>
		public string Creator => _creator;
		/// <summary>
		/// 2012/03/16 14:07:10
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
		/// 계좌 미결제 약정현황(평균가)
		/// </summary>
		public XQCFOFQ02400() : base("CFOFQ02400") { }



		public bool SetBlock(XQCFOFQ02400InBlock1 block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "RecCnt", 0, block.RecCnt.ToString("d5")); // long 5
			_xaQuery.SetFieldData(block.GetBlockName(), "AcntNo", 0, block.AcntNo); // char 20
			_xaQuery.SetFieldData(block.GetBlockName(), "Pwd", 0, block.Pwd); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "RegMktCode", 0, block.RegMktCode); // char 2
			_xaQuery.SetFieldData(block.GetBlockName(), "BuyDt", 0, block.BuyDt); // char 8

			return true;
		}

		public XQCFOFQ02400OutBlock1 GetBlock1()
		{
			XQCFOFQ02400OutBlock1 instance = XQCFOFQ02400OutBlock1.FromQuery(this);
			return instance;

		}

		public XQCFOFQ02400OutBlock2 GetBlock2()
		{
			XQCFOFQ02400OutBlock2 instance = XQCFOFQ02400OutBlock2.FromQuery(this);
			return instance;

		}

		public XQCFOFQ02400OutBlock3[] GetBlock3s()
		{
			XQCFOFQ02400OutBlock3[] instance = XQCFOFQ02400OutBlock3.ListFromQuery(this);
			return instance;

		}

		public XQCFOFQ02400OutBlock4[] GetBlock4s()
		{
			XQCFOFQ02400OutBlock4[] instance = XQCFOFQ02400OutBlock4.ListFromQuery(this);
			return instance;

		}


	}

}
