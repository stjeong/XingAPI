using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQCSPAQ13700InBlock1 : XingBlock
	{
		/// <summary>
		/// CSPAQ13700InBlock1
		/// </summary>
		public const string _blockName = "CSPAQ13700InBlock1";
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
		/// CSPAQ13700InBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CSPAQ13700InBlock1
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
		/// 주문시장코드
		/// </summary>
		[XAQueryFieldAttribute("OrdMktCode", "주문시장코드", "char", "2")]
		public string OrdMktCode;
		/// <summary>
		/// 매매구분
		/// </summary>
		[XAQueryFieldAttribute("BnsTpCode", "매매구분", "char", "1")]
		public char BnsTpCode;
		/// <summary>
		/// 종목번호
		/// </summary>
		[XAQueryFieldAttribute("IsuNo", "종목번호", "char", "12")]
		public string IsuNo;
		/// <summary>
		/// 체결여부
		/// </summary>
		[XAQueryFieldAttribute("ExecYn", "체결여부", "char", "1")]
		public char ExecYn;
		/// <summary>
		/// 주문일
		/// </summary>
		[XAQueryFieldAttribute("OrdDt", "주문일", "char", "8")]
		public string OrdDt;
		/// <summary>
		/// 시작주문번호2
		/// </summary>
		[XAQueryFieldAttribute("SrtOrdNo2", "시작주문번호2", "long", "10")]
		public long SrtOrdNo2;
		/// <summary>
		/// 역순구분
		/// </summary>
		[XAQueryFieldAttribute("BkseqTpCode", "역순구분", "char", "1")]
		public char BkseqTpCode;
		/// <summary>
		/// 주문유형코드
		/// </summary>
		[XAQueryFieldAttribute("OrdPtnCode", "주문유형코드", "char", "2")]
		public string OrdPtnCode;

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
			/// 주문시장코드
			/// </summary>
			public const string OrdMktCode = "OrdMktCode";
			/// <summary>
			/// 매매구분
			/// </summary>
			public const string BnsTpCode = "BnsTpCode";
			/// <summary>
			/// 종목번호
			/// </summary>
			public const string IsuNo = "IsuNo";
			/// <summary>
			/// 체결여부
			/// </summary>
			public const string ExecYn = "ExecYn";
			/// <summary>
			/// 주문일
			/// </summary>
			public const string OrdDt = "OrdDt";
			/// <summary>
			/// 시작주문번호2
			/// </summary>
			public const string SrtOrdNo2 = "SrtOrdNo2";
			/// <summary>
			/// 역순구분
			/// </summary>
			public const string BkseqTpCode = "BkseqTpCode";
			/// <summary>
			/// 주문유형코드
			/// </summary>
			public const string OrdPtnCode = "OrdPtnCode";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.AcntNo,
			F.InptPwd,
			F.OrdMktCode,
			F.BnsTpCode,
			F.IsuNo,
			F.ExecYn,
			F.OrdDt,
			F.SrtOrdNo2,
			F.BkseqTpCode,
			F.OrdPtnCode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["AcntNo"] = new XAQueryFieldInfo("char", AcntNo, AcntNo, "계좌번호", (decimal)20);
			dict["InptPwd"] = new XAQueryFieldInfo("char", InptPwd, InptPwd, "입력비밀번호", (decimal)8);
			dict["OrdMktCode"] = new XAQueryFieldInfo("char", OrdMktCode, OrdMktCode, "주문시장코드", (decimal)2);
			dict["BnsTpCode"] = new XAQueryFieldInfo("char", BnsTpCode, BnsTpCode.ToString(), "매매구분", (decimal)1);
			dict["IsuNo"] = new XAQueryFieldInfo("char", IsuNo, IsuNo, "종목번호", (decimal)12);
			dict["ExecYn"] = new XAQueryFieldInfo("char", ExecYn, ExecYn.ToString(), "체결여부", (decimal)1);
			dict["OrdDt"] = new XAQueryFieldInfo("char", OrdDt, OrdDt, "주문일", (decimal)8);
			dict["SrtOrdNo2"] = new XAQueryFieldInfo("long", SrtOrdNo2, SrtOrdNo2.ToString("d10"), "시작주문번호2", (decimal)10);
			dict["BkseqTpCode"] = new XAQueryFieldInfo("char", BkseqTpCode, BkseqTpCode.ToString(), "역순구분", (decimal)1);
			dict["OrdPtnCode"] = new XAQueryFieldInfo("char", OrdPtnCode, OrdPtnCode, "주문유형코드", (decimal)2);

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

				case "OrdMktCode":
					this.OrdMktCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "BnsTpCode":
					this.BnsTpCode = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "IsuNo":
					this.IsuNo = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ExecYn":
					this.ExecYn = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "OrdDt":
					this.OrdDt = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "SrtOrdNo2":
					this.SrtOrdNo2 = fieldInfo.FieldValue.ParseLong("SrtOrdNo2");
				break;

				case "BkseqTpCode":
					this.BkseqTpCode = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "OrdPtnCode":
					this.OrdPtnCode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (RecCnt.ToString().Length > 5) return false; // long 5
			if (AcntNo?.Length > 20) return false; // char 20
			if (InptPwd?.Length > 8) return false; // char 8
			if (OrdMktCode?.Length > 2) return false; // char 2
			// BnsTpCode char 1
			if (IsuNo?.Length > 12) return false; // char 12
			// ExecYn char 1
			if (OrdDt?.Length > 8) return false; // char 8
			if (SrtOrdNo2.ToString().Length > 10) return false; // long 10
			// BkseqTpCode char 1
			if (OrdPtnCode?.Length > 2) return false; // char 2

			return true;
		}

		public void CopyTo(XQCSPAQ13700InBlock1 block)
		{
			block.RecCnt = this.RecCnt;
			block.AcntNo = this.AcntNo;
			block.InptPwd = this.InptPwd;
			block.OrdMktCode = this.OrdMktCode;
			block.BnsTpCode = this.BnsTpCode;
			block.IsuNo = this.IsuNo;
			block.ExecYn = this.ExecYn;
			block.OrdDt = this.OrdDt;
			block.SrtOrdNo2 = this.SrtOrdNo2;
			block.BkseqTpCode = this.BkseqTpCode;
			block.OrdPtnCode = this.OrdPtnCode;

		}
	}

	public partial class XQCSPAQ13700OutBlock1 : XingBlock
	{
		/// <summary>
		/// CSPAQ13700OutBlock1
		/// </summary>
		public const string _blockName = "CSPAQ13700OutBlock1";
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
		/// CSPAQ13700OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CSPAQ13700OutBlock1
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
		/// 주문시장코드
		/// </summary>
		[XAQueryFieldAttribute("OrdMktCode", "주문시장코드", "char", "2")]
		public string OrdMktCode;
		/// <summary>
		/// 매매구분
		/// </summary>
		[XAQueryFieldAttribute("BnsTpCode", "매매구분", "char", "1")]
		public char BnsTpCode;
		/// <summary>
		/// 종목번호
		/// </summary>
		[XAQueryFieldAttribute("IsuNo", "종목번호", "char", "12")]
		public string IsuNo;
		/// <summary>
		/// 체결여부
		/// </summary>
		[XAQueryFieldAttribute("ExecYn", "체결여부", "char", "1")]
		public char ExecYn;
		/// <summary>
		/// 주문일
		/// </summary>
		[XAQueryFieldAttribute("OrdDt", "주문일", "char", "8")]
		public string OrdDt;
		/// <summary>
		/// 시작주문번호2
		/// </summary>
		[XAQueryFieldAttribute("SrtOrdNo2", "시작주문번호2", "long", "10")]
		public long SrtOrdNo2;
		/// <summary>
		/// 역순구분
		/// </summary>
		[XAQueryFieldAttribute("BkseqTpCode", "역순구분", "char", "1")]
		public char BkseqTpCode;
		/// <summary>
		/// 주문유형코드
		/// </summary>
		[XAQueryFieldAttribute("OrdPtnCode", "주문유형코드", "char", "2")]
		public string OrdPtnCode;

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
			/// 주문시장코드
			/// </summary>
			public const string OrdMktCode = "OrdMktCode";
			/// <summary>
			/// 매매구분
			/// </summary>
			public const string BnsTpCode = "BnsTpCode";
			/// <summary>
			/// 종목번호
			/// </summary>
			public const string IsuNo = "IsuNo";
			/// <summary>
			/// 체결여부
			/// </summary>
			public const string ExecYn = "ExecYn";
			/// <summary>
			/// 주문일
			/// </summary>
			public const string OrdDt = "OrdDt";
			/// <summary>
			/// 시작주문번호2
			/// </summary>
			public const string SrtOrdNo2 = "SrtOrdNo2";
			/// <summary>
			/// 역순구분
			/// </summary>
			public const string BkseqTpCode = "BkseqTpCode";
			/// <summary>
			/// 주문유형코드
			/// </summary>
			public const string OrdPtnCode = "OrdPtnCode";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.AcntNo,
			F.InptPwd,
			F.OrdMktCode,
			F.BnsTpCode,
			F.IsuNo,
			F.ExecYn,
			F.OrdDt,
			F.SrtOrdNo2,
			F.BkseqTpCode,
			F.OrdPtnCode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["AcntNo"] = new XAQueryFieldInfo("char", AcntNo, AcntNo, "계좌번호", (decimal)20);
			dict["InptPwd"] = new XAQueryFieldInfo("char", InptPwd, InptPwd, "입력비밀번호", (decimal)8);
			dict["OrdMktCode"] = new XAQueryFieldInfo("char", OrdMktCode, OrdMktCode, "주문시장코드", (decimal)2);
			dict["BnsTpCode"] = new XAQueryFieldInfo("char", BnsTpCode, BnsTpCode.ToString(), "매매구분", (decimal)1);
			dict["IsuNo"] = new XAQueryFieldInfo("char", IsuNo, IsuNo, "종목번호", (decimal)12);
			dict["ExecYn"] = new XAQueryFieldInfo("char", ExecYn, ExecYn.ToString(), "체결여부", (decimal)1);
			dict["OrdDt"] = new XAQueryFieldInfo("char", OrdDt, OrdDt, "주문일", (decimal)8);
			dict["SrtOrdNo2"] = new XAQueryFieldInfo("long", SrtOrdNo2, SrtOrdNo2.ToString("d10"), "시작주문번호2", (decimal)10);
			dict["BkseqTpCode"] = new XAQueryFieldInfo("char", BkseqTpCode, BkseqTpCode.ToString(), "역순구분", (decimal)1);
			dict["OrdPtnCode"] = new XAQueryFieldInfo("char", OrdPtnCode, OrdPtnCode, "주문유형코드", (decimal)2);

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

				case "OrdMktCode":
					this.OrdMktCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "BnsTpCode":
					this.BnsTpCode = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "IsuNo":
					this.IsuNo = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ExecYn":
					this.ExecYn = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "OrdDt":
					this.OrdDt = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "SrtOrdNo2":
					this.SrtOrdNo2 = fieldInfo.FieldValue.ParseLong("SrtOrdNo2");
				break;

				case "BkseqTpCode":
					this.BkseqTpCode = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "OrdPtnCode":
					this.OrdPtnCode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQCSPAQ13700OutBlock1 FromQuery(XQCSPAQ13700 query)
		{
			XQCSPAQ13700OutBlock1 block = new XQCSPAQ13700OutBlock1();
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
				block.OrdMktCode = query.GetFieldData(block.GetBlockName(), "OrdMktCode", 0).TrimEnd('?'); // char 2
				block.BnsTpCode = query.GetFieldData(block.GetBlockName(), "BnsTpCode", 0).FirstOrDefault(); // char 1
				block.IsuNo = query.GetFieldData(block.GetBlockName(), "IsuNo", 0).TrimEnd('?'); // char 12
				block.ExecYn = query.GetFieldData(block.GetBlockName(), "ExecYn", 0).FirstOrDefault(); // char 1
				block.OrdDt = query.GetFieldData(block.GetBlockName(), "OrdDt", 0).TrimEnd('?'); // char 8
				block.SrtOrdNo2 = query.GetFieldData(block.GetBlockName(), "SrtOrdNo2", 0).ParseLong("SrtOrdNo2"); // long 10
				block.BkseqTpCode = query.GetFieldData(block.GetBlockName(), "BkseqTpCode", 0).FirstOrDefault(); // char 1
				block.OrdPtnCode = query.GetFieldData(block.GetBlockName(), "OrdPtnCode", 0).TrimEnd('?'); // char 2

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
			if (OrdMktCode?.Length > 2) return false; // char 2
			// BnsTpCode char 1
			if (IsuNo?.Length > 12) return false; // char 12
			// ExecYn char 1
			if (OrdDt?.Length > 8) return false; // char 8
			if (SrtOrdNo2.ToString().Length > 10) return false; // long 10
			// BkseqTpCode char 1
			if (OrdPtnCode?.Length > 2) return false; // char 2

			return true;
		}

		public void CopyTo(XQCSPAQ13700OutBlock1 block)
		{
			block.RecCnt = this.RecCnt;
			block.AcntNo = this.AcntNo;
			block.InptPwd = this.InptPwd;
			block.OrdMktCode = this.OrdMktCode;
			block.BnsTpCode = this.BnsTpCode;
			block.IsuNo = this.IsuNo;
			block.ExecYn = this.ExecYn;
			block.OrdDt = this.OrdDt;
			block.SrtOrdNo2 = this.SrtOrdNo2;
			block.BkseqTpCode = this.BkseqTpCode;
			block.OrdPtnCode = this.OrdPtnCode;

		}
	}

	public partial class XQCSPAQ13700OutBlock2 : XingBlock
	{
		/// <summary>
		/// CSPAQ13700OutBlock2
		/// </summary>
		public const string _blockName = "CSPAQ13700OutBlock2";
		/// <summary>
		/// OUT1(*EMPTY*)
		/// </summary>
		public const string _blockDesc = "OUT1(*EMPTY*)";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// false
		/// </summary>
		public const bool _hasOccurs = false;
		/// <summary>
		/// CSPAQ13700OutBlock2
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CSPAQ13700OutBlock2
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// OUT1(*EMPTY*)
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
		/// 매도체결금액
		/// </summary>
		[XAQueryFieldAttribute("SellExecAmt", "매도체결금액", "long", "16")]
		public long SellExecAmt;
		/// <summary>
		/// 매수체결금액
		/// </summary>
		[XAQueryFieldAttribute("BuyExecAmt", "매수체결금액", "long", "16")]
		public long BuyExecAmt;
		/// <summary>
		/// 매도체결수량
		/// </summary>
		[XAQueryFieldAttribute("SellExecQty", "매도체결수량", "long", "16")]
		public long SellExecQty;
		/// <summary>
		/// 매수체결수량
		/// </summary>
		[XAQueryFieldAttribute("BuyExecQty", "매수체결수량", "long", "16")]
		public long BuyExecQty;
		/// <summary>
		/// 매도주문수량
		/// </summary>
		[XAQueryFieldAttribute("SellOrdQty", "매도주문수량", "long", "16")]
		public long SellOrdQty;
		/// <summary>
		/// 매수주문수량
		/// </summary>
		[XAQueryFieldAttribute("BuyOrdQty", "매수주문수량", "long", "16")]
		public long BuyOrdQty;

		public static class F
		{
			/// <summary>
			/// 레코드갯수
			/// </summary>
			public const string RecCnt = "RecCnt";
			/// <summary>
			/// 매도체결금액
			/// </summary>
			public const string SellExecAmt = "SellExecAmt";
			/// <summary>
			/// 매수체결금액
			/// </summary>
			public const string BuyExecAmt = "BuyExecAmt";
			/// <summary>
			/// 매도체결수량
			/// </summary>
			public const string SellExecQty = "SellExecQty";
			/// <summary>
			/// 매수체결수량
			/// </summary>
			public const string BuyExecQty = "BuyExecQty";
			/// <summary>
			/// 매도주문수량
			/// </summary>
			public const string SellOrdQty = "SellOrdQty";
			/// <summary>
			/// 매수주문수량
			/// </summary>
			public const string BuyOrdQty = "BuyOrdQty";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.SellExecAmt,
			F.BuyExecAmt,
			F.SellExecQty,
			F.BuyExecQty,
			F.SellOrdQty,
			F.BuyOrdQty,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["SellExecAmt"] = new XAQueryFieldInfo("long", SellExecAmt, SellExecAmt.ToString("d16"), "매도체결금액", (decimal)16);
			dict["BuyExecAmt"] = new XAQueryFieldInfo("long", BuyExecAmt, BuyExecAmt.ToString("d16"), "매수체결금액", (decimal)16);
			dict["SellExecQty"] = new XAQueryFieldInfo("long", SellExecQty, SellExecQty.ToString("d16"), "매도체결수량", (decimal)16);
			dict["BuyExecQty"] = new XAQueryFieldInfo("long", BuyExecQty, BuyExecQty.ToString("d16"), "매수체결수량", (decimal)16);
			dict["SellOrdQty"] = new XAQueryFieldInfo("long", SellOrdQty, SellOrdQty.ToString("d16"), "매도주문수량", (decimal)16);
			dict["BuyOrdQty"] = new XAQueryFieldInfo("long", BuyOrdQty, BuyOrdQty.ToString("d16"), "매수주문수량", (decimal)16);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "RecCnt":
					this.RecCnt = fieldInfo.FieldValue.ParseLong("RecCnt");
				break;

				case "SellExecAmt":
					this.SellExecAmt = fieldInfo.FieldValue.ParseLong("SellExecAmt");
				break;

				case "BuyExecAmt":
					this.BuyExecAmt = fieldInfo.FieldValue.ParseLong("BuyExecAmt");
				break;

				case "SellExecQty":
					this.SellExecQty = fieldInfo.FieldValue.ParseLong("SellExecQty");
				break;

				case "BuyExecQty":
					this.BuyExecQty = fieldInfo.FieldValue.ParseLong("BuyExecQty");
				break;

				case "SellOrdQty":
					this.SellOrdQty = fieldInfo.FieldValue.ParseLong("SellOrdQty");
				break;

				case "BuyOrdQty":
					this.BuyOrdQty = fieldInfo.FieldValue.ParseLong("BuyOrdQty");
				break;


			}
		}

		public static XQCSPAQ13700OutBlock2 FromQuery(XQCSPAQ13700 query)
		{
			XQCSPAQ13700OutBlock2 block = new XQCSPAQ13700OutBlock2();
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
				block.SellExecAmt = query.GetFieldData(block.GetBlockName(), "SellExecAmt", 0).ParseLong("SellExecAmt"); // long 16
				block.BuyExecAmt = query.GetFieldData(block.GetBlockName(), "BuyExecAmt", 0).ParseLong("BuyExecAmt"); // long 16
				block.SellExecQty = query.GetFieldData(block.GetBlockName(), "SellExecQty", 0).ParseLong("SellExecQty"); // long 16
				block.BuyExecQty = query.GetFieldData(block.GetBlockName(), "BuyExecQty", 0).ParseLong("BuyExecQty"); // long 16
				block.SellOrdQty = query.GetFieldData(block.GetBlockName(), "SellOrdQty", 0).ParseLong("SellOrdQty"); // long 16
				block.BuyOrdQty = query.GetFieldData(block.GetBlockName(), "BuyOrdQty", 0).ParseLong("BuyOrdQty"); // long 16

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (RecCnt.ToString().Length > 5) return false; // long 5
			if (SellExecAmt.ToString().Length > 16) return false; // long 16
			if (BuyExecAmt.ToString().Length > 16) return false; // long 16
			if (SellExecQty.ToString().Length > 16) return false; // long 16
			if (BuyExecQty.ToString().Length > 16) return false; // long 16
			if (SellOrdQty.ToString().Length > 16) return false; // long 16
			if (BuyOrdQty.ToString().Length > 16) return false; // long 16

			return true;
		}

		public void CopyTo(XQCSPAQ13700OutBlock2 block)
		{
			block.RecCnt = this.RecCnt;
			block.SellExecAmt = this.SellExecAmt;
			block.BuyExecAmt = this.BuyExecAmt;
			block.SellExecQty = this.SellExecQty;
			block.BuyExecQty = this.BuyExecQty;
			block.SellOrdQty = this.SellOrdQty;
			block.BuyOrdQty = this.BuyOrdQty;

		}
	}

	public partial class XQCSPAQ13700OutBlock3 : XingBlock
	{
		/// <summary>
		/// CSPAQ13700OutBlock3
		/// </summary>
		public const string _blockName = "CSPAQ13700OutBlock3";
		/// <summary>
		/// OUT(*EMPTY*)
		/// </summary>
		public const string _blockDesc = "OUT(*EMPTY*)";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// true
		/// </summary>
		public const bool _hasOccurs = true;
		/// <summary>
		/// CSPAQ13700OutBlock3
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CSPAQ13700OutBlock3
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// OUT(*EMPTY*)
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
		/// 주문일
		/// </summary>
		[XAQueryFieldAttribute("OrdDt", "주문일", "char", "8")]
		public string OrdDt;
		/// <summary>
		/// 관리지점번호
		/// </summary>
		[XAQueryFieldAttribute("MgmtBrnNo", "관리지점번호", "char", "3")]
		public string MgmtBrnNo;
		/// <summary>
		/// 주문시장코드
		/// </summary>
		[XAQueryFieldAttribute("OrdMktCode", "주문시장코드", "char", "2")]
		public string OrdMktCode;
		/// <summary>
		/// 주문번호
		/// </summary>
		[XAQueryFieldAttribute("OrdNo", "주문번호", "long", "10")]
		public long OrdNo;
		/// <summary>
		/// 원주문번호
		/// </summary>
		[XAQueryFieldAttribute("OrgOrdNo", "원주문번호", "long", "10")]
		public long OrgOrdNo;
		/// <summary>
		/// 종목번호
		/// </summary>
		[XAQueryFieldAttribute("IsuNo", "종목번호", "char", "12")]
		public string IsuNo;
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
		/// 주문유형코드
		/// </summary>
		[XAQueryFieldAttribute("OrdPtnCode", "주문유형코드", "char", "2")]
		public string OrdPtnCode;
		/// <summary>
		/// 주문유형명
		/// </summary>
		[XAQueryFieldAttribute("OrdPtnNm", "주문유형명", "char", "40")]
		public string OrdPtnNm;
		/// <summary>
		/// 주문처리유형코드
		/// </summary>
		[XAQueryFieldAttribute("OrdTrxPtnCode", "주문처리유형코드", "long", "9")]
		public long OrdTrxPtnCode;
		/// <summary>
		/// 주문처리유형명
		/// </summary>
		[XAQueryFieldAttribute("OrdTrxPtnNm", "주문처리유형명", "char", "50")]
		public string OrdTrxPtnNm;
		/// <summary>
		/// 정정취소구분
		/// </summary>
		[XAQueryFieldAttribute("MrcTpCode", "정정취소구분", "char", "1")]
		public char MrcTpCode;
		/// <summary>
		/// 정정취소구분명
		/// </summary>
		[XAQueryFieldAttribute("MrcTpNm", "정정취소구분명", "char", "10")]
		public string MrcTpNm;
		/// <summary>
		/// 정정취소수량
		/// </summary>
		[XAQueryFieldAttribute("MrcQty", "정정취소수량", "long", "16")]
		public long MrcQty;
		/// <summary>
		/// 정정취소가능수량
		/// </summary>
		[XAQueryFieldAttribute("MrcAbleQty", "정정취소가능수량", "long", "16")]
		public long MrcAbleQty;
		/// <summary>
		/// 주문수량
		/// </summary>
		[XAQueryFieldAttribute("OrdQty", "주문수량", "long", "16")]
		public long OrdQty;
		/// <summary>
		/// 주문가격
		/// </summary>
		[XAQueryFieldAttribute("OrdPrc", "주문가격", "double", "15.2")]
		public double OrdPrc;
		/// <summary>
		/// 체결수량
		/// </summary>
		[XAQueryFieldAttribute("ExecQty", "체결수량", "long", "16")]
		public long ExecQty;
		/// <summary>
		/// 체결가
		/// </summary>
		[XAQueryFieldAttribute("ExecPrc", "체결가", "double", "15.2")]
		public double ExecPrc;
		/// <summary>
		/// 체결처리시각
		/// </summary>
		[XAQueryFieldAttribute("ExecTrxTime", "체결처리시각", "char", "9")]
		public string ExecTrxTime;
		/// <summary>
		/// 최종체결시각
		/// </summary>
		[XAQueryFieldAttribute("LastExecTime", "최종체결시각", "char", "9")]
		public string LastExecTime;
		/// <summary>
		/// 호가유형코드
		/// </summary>
		[XAQueryFieldAttribute("OrdprcPtnCode", "호가유형코드", "char", "2")]
		public string OrdprcPtnCode;
		/// <summary>
		/// 호가유형명
		/// </summary>
		[XAQueryFieldAttribute("OrdprcPtnNm", "호가유형명", "char", "40")]
		public string OrdprcPtnNm;
		/// <summary>
		/// 주문조건구분
		/// </summary>
		[XAQueryFieldAttribute("OrdCndiTpCode", "주문조건구분", "char", "1")]
		public char OrdCndiTpCode;
		/// <summary>
		/// 전체체결수량
		/// </summary>
		[XAQueryFieldAttribute("AllExecQty", "전체체결수량", "long", "16")]
		public long AllExecQty;
		/// <summary>
		/// 통신매체코드
		/// </summary>
		[XAQueryFieldAttribute("RegCommdaCode", "통신매체코드", "char", "2")]
		public string RegCommdaCode;
		/// <summary>
		/// 통신매체명
		/// </summary>
		[XAQueryFieldAttribute("CommdaNm", "통신매체명", "char", "40")]
		public string CommdaNm;
		/// <summary>
		/// 회원번호
		/// </summary>
		[XAQueryFieldAttribute("MbrNo", "회원번호", "char", "3")]
		public string MbrNo;
		/// <summary>
		/// 예약주문여부
		/// </summary>
		[XAQueryFieldAttribute("RsvOrdYn", "예약주문여부", "char", "1")]
		public char RsvOrdYn;
		/// <summary>
		/// 대출일
		/// </summary>
		[XAQueryFieldAttribute("LoanDt", "대출일", "char", "8")]
		public string LoanDt;
		/// <summary>
		/// 주문시각
		/// </summary>
		[XAQueryFieldAttribute("OrdTime", "주문시각", "char", "9")]
		public string OrdTime;
		/// <summary>
		/// 운용지시번호
		/// </summary>
		[XAQueryFieldAttribute("OpDrtnNo", "운용지시번호", "char", "12")]
		public string OpDrtnNo;
		/// <summary>
		/// 주문자ID
		/// </summary>
		[XAQueryFieldAttribute("OdrrId", "주문자ID", "char", "16")]
		public string OdrrId;

		public static class F
		{
			/// <summary>
			/// 주문일
			/// </summary>
			public const string OrdDt = "OrdDt";
			/// <summary>
			/// 관리지점번호
			/// </summary>
			public const string MgmtBrnNo = "MgmtBrnNo";
			/// <summary>
			/// 주문시장코드
			/// </summary>
			public const string OrdMktCode = "OrdMktCode";
			/// <summary>
			/// 주문번호
			/// </summary>
			public const string OrdNo = "OrdNo";
			/// <summary>
			/// 원주문번호
			/// </summary>
			public const string OrgOrdNo = "OrgOrdNo";
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
			/// 주문유형코드
			/// </summary>
			public const string OrdPtnCode = "OrdPtnCode";
			/// <summary>
			/// 주문유형명
			/// </summary>
			public const string OrdPtnNm = "OrdPtnNm";
			/// <summary>
			/// 주문처리유형코드
			/// </summary>
			public const string OrdTrxPtnCode = "OrdTrxPtnCode";
			/// <summary>
			/// 주문처리유형명
			/// </summary>
			public const string OrdTrxPtnNm = "OrdTrxPtnNm";
			/// <summary>
			/// 정정취소구분
			/// </summary>
			public const string MrcTpCode = "MrcTpCode";
			/// <summary>
			/// 정정취소구분명
			/// </summary>
			public const string MrcTpNm = "MrcTpNm";
			/// <summary>
			/// 정정취소수량
			/// </summary>
			public const string MrcQty = "MrcQty";
			/// <summary>
			/// 정정취소가능수량
			/// </summary>
			public const string MrcAbleQty = "MrcAbleQty";
			/// <summary>
			/// 주문수량
			/// </summary>
			public const string OrdQty = "OrdQty";
			/// <summary>
			/// 주문가격
			/// </summary>
			public const string OrdPrc = "OrdPrc";
			/// <summary>
			/// 체결수량
			/// </summary>
			public const string ExecQty = "ExecQty";
			/// <summary>
			/// 체결가
			/// </summary>
			public const string ExecPrc = "ExecPrc";
			/// <summary>
			/// 체결처리시각
			/// </summary>
			public const string ExecTrxTime = "ExecTrxTime";
			/// <summary>
			/// 최종체결시각
			/// </summary>
			public const string LastExecTime = "LastExecTime";
			/// <summary>
			/// 호가유형코드
			/// </summary>
			public const string OrdprcPtnCode = "OrdprcPtnCode";
			/// <summary>
			/// 호가유형명
			/// </summary>
			public const string OrdprcPtnNm = "OrdprcPtnNm";
			/// <summary>
			/// 주문조건구분
			/// </summary>
			public const string OrdCndiTpCode = "OrdCndiTpCode";
			/// <summary>
			/// 전체체결수량
			/// </summary>
			public const string AllExecQty = "AllExecQty";
			/// <summary>
			/// 통신매체코드
			/// </summary>
			public const string RegCommdaCode = "RegCommdaCode";
			/// <summary>
			/// 통신매체명
			/// </summary>
			public const string CommdaNm = "CommdaNm";
			/// <summary>
			/// 회원번호
			/// </summary>
			public const string MbrNo = "MbrNo";
			/// <summary>
			/// 예약주문여부
			/// </summary>
			public const string RsvOrdYn = "RsvOrdYn";
			/// <summary>
			/// 대출일
			/// </summary>
			public const string LoanDt = "LoanDt";
			/// <summary>
			/// 주문시각
			/// </summary>
			public const string OrdTime = "OrdTime";
			/// <summary>
			/// 운용지시번호
			/// </summary>
			public const string OpDrtnNo = "OpDrtnNo";
			/// <summary>
			/// 주문자ID
			/// </summary>
			public const string OdrrId = "OdrrId";
		}

		public static string[] AllFields = new string[]
		{
			F.OrdDt,
			F.MgmtBrnNo,
			F.OrdMktCode,
			F.OrdNo,
			F.OrgOrdNo,
			F.IsuNo,
			F.IsuNm,
			F.BnsTpCode,
			F.BnsTpNm,
			F.OrdPtnCode,
			F.OrdPtnNm,
			F.OrdTrxPtnCode,
			F.OrdTrxPtnNm,
			F.MrcTpCode,
			F.MrcTpNm,
			F.MrcQty,
			F.MrcAbleQty,
			F.OrdQty,
			F.OrdPrc,
			F.ExecQty,
			F.ExecPrc,
			F.ExecTrxTime,
			F.LastExecTime,
			F.OrdprcPtnCode,
			F.OrdprcPtnNm,
			F.OrdCndiTpCode,
			F.AllExecQty,
			F.RegCommdaCode,
			F.CommdaNm,
			F.MbrNo,
			F.RsvOrdYn,
			F.LoanDt,
			F.OrdTime,
			F.OpDrtnNo,
			F.OdrrId,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["OrdDt"] = new XAQueryFieldInfo("char", OrdDt, OrdDt, "주문일", (decimal)8);
			dict["MgmtBrnNo"] = new XAQueryFieldInfo("char", MgmtBrnNo, MgmtBrnNo, "관리지점번호", (decimal)3);
			dict["OrdMktCode"] = new XAQueryFieldInfo("char", OrdMktCode, OrdMktCode, "주문시장코드", (decimal)2);
			dict["OrdNo"] = new XAQueryFieldInfo("long", OrdNo, OrdNo.ToString("d10"), "주문번호", (decimal)10);
			dict["OrgOrdNo"] = new XAQueryFieldInfo("long", OrgOrdNo, OrgOrdNo.ToString("d10"), "원주문번호", (decimal)10);
			dict["IsuNo"] = new XAQueryFieldInfo("char", IsuNo, IsuNo, "종목번호", (decimal)12);
			dict["IsuNm"] = new XAQueryFieldInfo("char", IsuNm, IsuNm, "종목명", (decimal)40);
			dict["BnsTpCode"] = new XAQueryFieldInfo("char", BnsTpCode, BnsTpCode.ToString(), "매매구분", (decimal)1);
			dict["BnsTpNm"] = new XAQueryFieldInfo("char", BnsTpNm, BnsTpNm, "매매구분", (decimal)10);
			dict["OrdPtnCode"] = new XAQueryFieldInfo("char", OrdPtnCode, OrdPtnCode, "주문유형코드", (decimal)2);
			dict["OrdPtnNm"] = new XAQueryFieldInfo("char", OrdPtnNm, OrdPtnNm, "주문유형명", (decimal)40);
			dict["OrdTrxPtnCode"] = new XAQueryFieldInfo("long", OrdTrxPtnCode, OrdTrxPtnCode.ToString("d9"), "주문처리유형코드", (decimal)9);
			dict["OrdTrxPtnNm"] = new XAQueryFieldInfo("char", OrdTrxPtnNm, OrdTrxPtnNm, "주문처리유형명", (decimal)50);
			dict["MrcTpCode"] = new XAQueryFieldInfo("char", MrcTpCode, MrcTpCode.ToString(), "정정취소구분", (decimal)1);
			dict["MrcTpNm"] = new XAQueryFieldInfo("char", MrcTpNm, MrcTpNm, "정정취소구분명", (decimal)10);
			dict["MrcQty"] = new XAQueryFieldInfo("long", MrcQty, MrcQty.ToString("d16"), "정정취소수량", (decimal)16);
			dict["MrcAbleQty"] = new XAQueryFieldInfo("long", MrcAbleQty, MrcAbleQty.ToString("d16"), "정정취소가능수량", (decimal)16);
			dict["OrdQty"] = new XAQueryFieldInfo("long", OrdQty, OrdQty.ToString("d16"), "주문수량", (decimal)16);
			dict["OrdPrc"] = new XAQueryFieldInfo("double", OrdPrc, OrdPrc.ToString("000000000000000.00"), "주문가격", (decimal)15.2);
			dict["ExecQty"] = new XAQueryFieldInfo("long", ExecQty, ExecQty.ToString("d16"), "체결수량", (decimal)16);
			dict["ExecPrc"] = new XAQueryFieldInfo("double", ExecPrc, ExecPrc.ToString("000000000000000.00"), "체결가", (decimal)15.2);
			dict["ExecTrxTime"] = new XAQueryFieldInfo("char", ExecTrxTime, ExecTrxTime, "체결처리시각", (decimal)9);
			dict["LastExecTime"] = new XAQueryFieldInfo("char", LastExecTime, LastExecTime, "최종체결시각", (decimal)9);
			dict["OrdprcPtnCode"] = new XAQueryFieldInfo("char", OrdprcPtnCode, OrdprcPtnCode, "호가유형코드", (decimal)2);
			dict["OrdprcPtnNm"] = new XAQueryFieldInfo("char", OrdprcPtnNm, OrdprcPtnNm, "호가유형명", (decimal)40);
			dict["OrdCndiTpCode"] = new XAQueryFieldInfo("char", OrdCndiTpCode, OrdCndiTpCode.ToString(), "주문조건구분", (decimal)1);
			dict["AllExecQty"] = new XAQueryFieldInfo("long", AllExecQty, AllExecQty.ToString("d16"), "전체체결수량", (decimal)16);
			dict["RegCommdaCode"] = new XAQueryFieldInfo("char", RegCommdaCode, RegCommdaCode, "통신매체코드", (decimal)2);
			dict["CommdaNm"] = new XAQueryFieldInfo("char", CommdaNm, CommdaNm, "통신매체명", (decimal)40);
			dict["MbrNo"] = new XAQueryFieldInfo("char", MbrNo, MbrNo, "회원번호", (decimal)3);
			dict["RsvOrdYn"] = new XAQueryFieldInfo("char", RsvOrdYn, RsvOrdYn.ToString(), "예약주문여부", (decimal)1);
			dict["LoanDt"] = new XAQueryFieldInfo("char", LoanDt, LoanDt, "대출일", (decimal)8);
			dict["OrdTime"] = new XAQueryFieldInfo("char", OrdTime, OrdTime, "주문시각", (decimal)9);
			dict["OpDrtnNo"] = new XAQueryFieldInfo("char", OpDrtnNo, OpDrtnNo, "운용지시번호", (decimal)12);
			dict["OdrrId"] = new XAQueryFieldInfo("char", OdrrId, OdrrId, "주문자ID", (decimal)16);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "OrdDt":
					this.OrdDt = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "MgmtBrnNo":
					this.MgmtBrnNo = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "OrdMktCode":
					this.OrdMktCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "OrdNo":
					this.OrdNo = fieldInfo.FieldValue.ParseLong("OrdNo");
				break;

				case "OrgOrdNo":
					this.OrgOrdNo = fieldInfo.FieldValue.ParseLong("OrgOrdNo");
				break;

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

				case "OrdPtnCode":
					this.OrdPtnCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "OrdPtnNm":
					this.OrdPtnNm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "OrdTrxPtnCode":
					this.OrdTrxPtnCode = fieldInfo.FieldValue.ParseLong("OrdTrxPtnCode");
				break;

				case "OrdTrxPtnNm":
					this.OrdTrxPtnNm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "MrcTpCode":
					this.MrcTpCode = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "MrcTpNm":
					this.MrcTpNm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "MrcQty":
					this.MrcQty = fieldInfo.FieldValue.ParseLong("MrcQty");
				break;

				case "MrcAbleQty":
					this.MrcAbleQty = fieldInfo.FieldValue.ParseLong("MrcAbleQty");
				break;

				case "OrdQty":
					this.OrdQty = fieldInfo.FieldValue.ParseLong("OrdQty");
				break;

				case "OrdPrc":
					this.OrdPrc = fieldInfo.FieldValue.ParseDouble("OrdPrc");
				break;

				case "ExecQty":
					this.ExecQty = fieldInfo.FieldValue.ParseLong("ExecQty");
				break;

				case "ExecPrc":
					this.ExecPrc = fieldInfo.FieldValue.ParseDouble("ExecPrc");
				break;

				case "ExecTrxTime":
					this.ExecTrxTime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "LastExecTime":
					this.LastExecTime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "OrdprcPtnCode":
					this.OrdprcPtnCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "OrdprcPtnNm":
					this.OrdprcPtnNm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "OrdCndiTpCode":
					this.OrdCndiTpCode = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "AllExecQty":
					this.AllExecQty = fieldInfo.FieldValue.ParseLong("AllExecQty");
				break;

				case "RegCommdaCode":
					this.RegCommdaCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "CommdaNm":
					this.CommdaNm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "MbrNo":
					this.MbrNo = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "RsvOrdYn":
					this.RsvOrdYn = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "LoanDt":
					this.LoanDt = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "OrdTime":
					this.OrdTime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "OpDrtnNo":
					this.OpDrtnNo = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "OdrrId":
					this.OdrrId = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQCSPAQ13700OutBlock3[] ListFromQuery(XQCSPAQ13700 query)
		{
			int count = query.GetBlockCount(XQCSPAQ13700OutBlock3.BlockName);
			List<XQCSPAQ13700OutBlock3> list = new List<XQCSPAQ13700OutBlock3>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQCSPAQ13700OutBlock3 block = new XQCSPAQ13700OutBlock3();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.OrdDt = query.GetFieldData(block.GetBlockName(), "OrdDt", i).TrimEnd('?'); // char 8
					block.MgmtBrnNo = query.GetFieldData(block.GetBlockName(), "MgmtBrnNo", i).TrimEnd('?'); // char 3
					block.OrdMktCode = query.GetFieldData(block.GetBlockName(), "OrdMktCode", i).TrimEnd('?'); // char 2
					block.OrdNo = query.GetFieldData(block.GetBlockName(), "OrdNo", i).ParseLong("OrdNo"); // long 10
					block.OrgOrdNo = query.GetFieldData(block.GetBlockName(), "OrgOrdNo", i).ParseLong("OrgOrdNo"); // long 10
					block.IsuNo = query.GetFieldData(block.GetBlockName(), "IsuNo", i).TrimEnd('?'); // char 12
					block.IsuNm = query.GetFieldData(block.GetBlockName(), "IsuNm", i).TrimEnd('?'); // char 40
					block.BnsTpCode = query.GetFieldData(block.GetBlockName(), "BnsTpCode", i).FirstOrDefault(); // char 1
					block.BnsTpNm = query.GetFieldData(block.GetBlockName(), "BnsTpNm", i).TrimEnd('?'); // char 10
					block.OrdPtnCode = query.GetFieldData(block.GetBlockName(), "OrdPtnCode", i).TrimEnd('?'); // char 2
					block.OrdPtnNm = query.GetFieldData(block.GetBlockName(), "OrdPtnNm", i).TrimEnd('?'); // char 40
					block.OrdTrxPtnCode = query.GetFieldData(block.GetBlockName(), "OrdTrxPtnCode", i).ParseLong("OrdTrxPtnCode"); // long 9
					block.OrdTrxPtnNm = query.GetFieldData(block.GetBlockName(), "OrdTrxPtnNm", i).TrimEnd('?'); // char 50
					block.MrcTpCode = query.GetFieldData(block.GetBlockName(), "MrcTpCode", i).FirstOrDefault(); // char 1
					block.MrcTpNm = query.GetFieldData(block.GetBlockName(), "MrcTpNm", i).TrimEnd('?'); // char 10
					block.MrcQty = query.GetFieldData(block.GetBlockName(), "MrcQty", i).ParseLong("MrcQty"); // long 16
					block.MrcAbleQty = query.GetFieldData(block.GetBlockName(), "MrcAbleQty", i).ParseLong("MrcAbleQty"); // long 16
					block.OrdQty = query.GetFieldData(block.GetBlockName(), "OrdQty", i).ParseLong("OrdQty"); // long 16
					block.OrdPrc = query.GetFieldData(block.GetBlockName(), "OrdPrc", i).ParseDouble("OrdPrc"); // double 15.2
					block.ExecQty = query.GetFieldData(block.GetBlockName(), "ExecQty", i).ParseLong("ExecQty"); // long 16
					block.ExecPrc = query.GetFieldData(block.GetBlockName(), "ExecPrc", i).ParseDouble("ExecPrc"); // double 15.2
					block.ExecTrxTime = query.GetFieldData(block.GetBlockName(), "ExecTrxTime", i).TrimEnd('?'); // char 9
					block.LastExecTime = query.GetFieldData(block.GetBlockName(), "LastExecTime", i).TrimEnd('?'); // char 9
					block.OrdprcPtnCode = query.GetFieldData(block.GetBlockName(), "OrdprcPtnCode", i).TrimEnd('?'); // char 2
					block.OrdprcPtnNm = query.GetFieldData(block.GetBlockName(), "OrdprcPtnNm", i).TrimEnd('?'); // char 40
					block.OrdCndiTpCode = query.GetFieldData(block.GetBlockName(), "OrdCndiTpCode", i).FirstOrDefault(); // char 1
					block.AllExecQty = query.GetFieldData(block.GetBlockName(), "AllExecQty", i).ParseLong("AllExecQty"); // long 16
					block.RegCommdaCode = query.GetFieldData(block.GetBlockName(), "RegCommdaCode", i).TrimEnd('?'); // char 2
					block.CommdaNm = query.GetFieldData(block.GetBlockName(), "CommdaNm", i).TrimEnd('?'); // char 40
					block.MbrNo = query.GetFieldData(block.GetBlockName(), "MbrNo", i).TrimEnd('?'); // char 3
					block.RsvOrdYn = query.GetFieldData(block.GetBlockName(), "RsvOrdYn", i).FirstOrDefault(); // char 1
					block.LoanDt = query.GetFieldData(block.GetBlockName(), "LoanDt", i).TrimEnd('?'); // char 8
					block.OrdTime = query.GetFieldData(block.GetBlockName(), "OrdTime", i).TrimEnd('?'); // char 9
					block.OpDrtnNo = query.GetFieldData(block.GetBlockName(), "OpDrtnNo", i).TrimEnd('?'); // char 12
					block.OdrrId = query.GetFieldData(block.GetBlockName(), "OdrrId", i).TrimEnd('?'); // char 16

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
			if (OrdDt?.Length > 8) return false; // char 8
			if (MgmtBrnNo?.Length > 3) return false; // char 3
			if (OrdMktCode?.Length > 2) return false; // char 2
			if (OrdNo.ToString().Length > 10) return false; // long 10
			if (OrgOrdNo.ToString().Length > 10) return false; // long 10
			if (IsuNo?.Length > 12) return false; // char 12
			if (IsuNm?.Length > 40) return false; // char 40
			// BnsTpCode char 1
			if (BnsTpNm?.Length > 10) return false; // char 10
			if (OrdPtnCode?.Length > 2) return false; // char 2
			if (OrdPtnNm?.Length > 40) return false; // char 40
			if (OrdTrxPtnCode.ToString().Length > 9) return false; // long 9
			if (OrdTrxPtnNm?.Length > 50) return false; // char 50
			// MrcTpCode char 1
			if (MrcTpNm?.Length > 10) return false; // char 10
			if (MrcQty.ToString().Length > 16) return false; // long 16
			if (MrcAbleQty.ToString().Length > 16) return false; // long 16
			if (OrdQty.ToString().Length > 16) return false; // long 16
			// OrdPrc double 15.2
			if (ExecQty.ToString().Length > 16) return false; // long 16
			// ExecPrc double 15.2
			if (ExecTrxTime?.Length > 9) return false; // char 9
			if (LastExecTime?.Length > 9) return false; // char 9
			if (OrdprcPtnCode?.Length > 2) return false; // char 2
			if (OrdprcPtnNm?.Length > 40) return false; // char 40
			// OrdCndiTpCode char 1
			if (AllExecQty.ToString().Length > 16) return false; // long 16
			if (RegCommdaCode?.Length > 2) return false; // char 2
			if (CommdaNm?.Length > 40) return false; // char 40
			if (MbrNo?.Length > 3) return false; // char 3
			// RsvOrdYn char 1
			if (LoanDt?.Length > 8) return false; // char 8
			if (OrdTime?.Length > 9) return false; // char 9
			if (OpDrtnNo?.Length > 12) return false; // char 12
			if (OdrrId?.Length > 16) return false; // char 16

			return true;
		}

		public void CopyTo(XQCSPAQ13700OutBlock3 block)
		{
			block.OrdDt = this.OrdDt;
			block.MgmtBrnNo = this.MgmtBrnNo;
			block.OrdMktCode = this.OrdMktCode;
			block.OrdNo = this.OrdNo;
			block.OrgOrdNo = this.OrgOrdNo;
			block.IsuNo = this.IsuNo;
			block.IsuNm = this.IsuNm;
			block.BnsTpCode = this.BnsTpCode;
			block.BnsTpNm = this.BnsTpNm;
			block.OrdPtnCode = this.OrdPtnCode;
			block.OrdPtnNm = this.OrdPtnNm;
			block.OrdTrxPtnCode = this.OrdTrxPtnCode;
			block.OrdTrxPtnNm = this.OrdTrxPtnNm;
			block.MrcTpCode = this.MrcTpCode;
			block.MrcTpNm = this.MrcTpNm;
			block.MrcQty = this.MrcQty;
			block.MrcAbleQty = this.MrcAbleQty;
			block.OrdQty = this.OrdQty;
			block.OrdPrc = this.OrdPrc;
			block.ExecQty = this.ExecQty;
			block.ExecPrc = this.ExecPrc;
			block.ExecTrxTime = this.ExecTrxTime;
			block.LastExecTime = this.LastExecTime;
			block.OrdprcPtnCode = this.OrdprcPtnCode;
			block.OrdprcPtnNm = this.OrdprcPtnNm;
			block.OrdCndiTpCode = this.OrdCndiTpCode;
			block.AllExecQty = this.AllExecQty;
			block.RegCommdaCode = this.RegCommdaCode;
			block.CommdaNm = this.CommdaNm;
			block.MbrNo = this.MbrNo;
			block.RsvOrdYn = this.RsvOrdYn;
			block.LoanDt = this.LoanDt;
			block.OrdTime = this.OrdTime;
			block.OpDrtnNo = this.OpDrtnNo;
			block.OdrrId = this.OdrrId;

		}
	}

	/// <summary>
	/// 현물계좌주문체결내역조회
	/// </summary>
	public partial class XQCSPAQ13700 : XingQuery
	{
		/// <summary>
		/// CSPAQ13700
		/// </summary>
		public const string _typeName = "CSPAQ13700";
		/// <summary>
		/// 현물계좌주문체결내역조회
		/// </summary>
		public const string _typeDesc = "현물계좌주문체결내역조회";
		/// <summary>
		/// CSPAQ13700
		/// </summary>
		public const string _service = "CSPAQ13700";
		/// <summary>
		/// B
		/// </summary>
		public const string _headType = "B";
		/// <summary>
		/// 이상은
		/// </summary>
		public const string _creator = "이상은";
		/// <summary>
		/// 2015/04/13 08:39:53
		/// </summary>
		public const string _createdDate = "2015/04/13 08:39:53";
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
		/// CSPAQ13700
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 현물계좌주문체결내역조회
		/// </summary>
		public string TypeDesc => _typeDesc;
		/// <summary>
		/// CSPAQ13700
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
		/// 2015/04/13 08:39:53
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
		/// 현물계좌주문체결내역조회
		/// </summary>
		public XQCSPAQ13700() : base("CSPAQ13700") { }




		public bool SetBlock(XQCSPAQ13700InBlock1 block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "RecCnt", 0, block.RecCnt.ToString("d5")); // long 5
			_xaQuery.SetFieldData(block.GetBlockName(), "AcntNo", 0, block.AcntNo); // char 20
			_xaQuery.SetFieldData(block.GetBlockName(), "InptPwd", 0, block.InptPwd); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "OrdMktCode", 0, block.OrdMktCode); // char 2
			_xaQuery.SetFieldData(block.GetBlockName(), "BnsTpCode", 0, block.BnsTpCode.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "IsuNo", 0, block.IsuNo); // char 12
			_xaQuery.SetFieldData(block.GetBlockName(), "ExecYn", 0, block.ExecYn.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "OrdDt", 0, block.OrdDt); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "SrtOrdNo2", 0, block.SrtOrdNo2.ToString("d10")); // long 10
			_xaQuery.SetFieldData(block.GetBlockName(), "BkseqTpCode", 0, block.BkseqTpCode.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "OrdPtnCode", 0, block.OrdPtnCode); // char 2

			return true;
		}

		public XQCSPAQ13700OutBlock1 GetBlock1()
		{
			XQCSPAQ13700OutBlock1 instance = XQCSPAQ13700OutBlock1.FromQuery(this);
			return instance;

		}

		public XQCSPAQ13700OutBlock2 GetBlock2()
		{
			XQCSPAQ13700OutBlock2 instance = XQCSPAQ13700OutBlock2.FromQuery(this);
			return instance;

		}

		public XQCSPAQ13700OutBlock3[] GetBlock3s()
		{
			XQCSPAQ13700OutBlock3[] instance = XQCSPAQ13700OutBlock3.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQCSPAQ13700OutBlock1),
			typeof(XQCSPAQ13700OutBlock2),
			typeof(XQCSPAQ13700OutBlock3),

		};

	}

}
