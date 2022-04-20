using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQCEXAQ31100InBlock1 : XingBlock
	{
		/// <summary>
		/// CEXAQ31100InBlock1
		/// </summary>
		public const string _blockName = "CEXAQ31100InBlock1";
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
		/// CEXAQ31100InBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CEXAQ31100InBlock1
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
		/// 종목코드
		/// </summary>
		[XAQueryFieldAttribute("IsuCode", "종목코드", "char", "12")]
		public string IsuCode;
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
			/// 종목코드
			/// </summary>
			public const string IsuCode = "IsuCode";
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
			F.IsuCode,
			F.BalEvalTp,
			F.FutsPrcEvalTp,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["AcntNo"] = new XAQueryFieldInfo("char", AcntNo, AcntNo, "계좌번호", (decimal)20);
			dict["InptPwd"] = new XAQueryFieldInfo("char", InptPwd, InptPwd, "입력비밀번호", (decimal)8);
			dict["IsuCode"] = new XAQueryFieldInfo("char", IsuCode, IsuCode, "종목코드", (decimal)12);
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

				case "IsuCode":
					this.IsuCode = fieldInfo.FieldValue.TrimEnd('?');
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
			if (IsuCode?.Length > 12) return false; // char 12
			// BalEvalTp char 1
			// FutsPrcEvalTp char 1

			return true;
		}

		public void CopyTo(XQCEXAQ31100InBlock1 block)
		{
			block.RecCnt = this.RecCnt;
			block.AcntNo = this.AcntNo;
			block.InptPwd = this.InptPwd;
			block.IsuCode = this.IsuCode;
			block.BalEvalTp = this.BalEvalTp;
			block.FutsPrcEvalTp = this.FutsPrcEvalTp;

		}
	}

	public partial class XQCEXAQ31100OutBlock1 : XingBlock
	{
		/// <summary>
		/// CEXAQ31100OutBlock1
		/// </summary>
		public const string _blockName = "CEXAQ31100OutBlock1";
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
		/// CEXAQ31100OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CEXAQ31100OutBlock1
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
		/// 종목코드
		/// </summary>
		[XAQueryFieldAttribute("IsuCode", "종목코드", "char", "12")]
		public string IsuCode;
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
			/// 종목코드
			/// </summary>
			public const string IsuCode = "IsuCode";
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
			F.IsuCode,
			F.BalEvalTp,
			F.FutsPrcEvalTp,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["AcntNo"] = new XAQueryFieldInfo("char", AcntNo, AcntNo, "계좌번호", (decimal)20);
			dict["InptPwd"] = new XAQueryFieldInfo("char", InptPwd, InptPwd, "입력비밀번호", (decimal)8);
			dict["IsuCode"] = new XAQueryFieldInfo("char", IsuCode, IsuCode, "종목코드", (decimal)12);
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

				case "IsuCode":
					this.IsuCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "BalEvalTp":
					this.BalEvalTp = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "FutsPrcEvalTp":
					this.FutsPrcEvalTp = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public static XQCEXAQ31100OutBlock1 FromQuery(XQCEXAQ31100 query)
		{
			XQCEXAQ31100OutBlock1 block = new XQCEXAQ31100OutBlock1();
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
				block.IsuCode = query.GetFieldData(block.GetBlockName(), "IsuCode", 0).TrimEnd('?'); // char 12
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
			if (IsuCode?.Length > 12) return false; // char 12
			// BalEvalTp char 1
			// FutsPrcEvalTp char 1

			return true;
		}

		public void CopyTo(XQCEXAQ31100OutBlock1 block)
		{
			block.RecCnt = this.RecCnt;
			block.AcntNo = this.AcntNo;
			block.InptPwd = this.InptPwd;
			block.IsuCode = this.IsuCode;
			block.BalEvalTp = this.BalEvalTp;
			block.FutsPrcEvalTp = this.FutsPrcEvalTp;

		}
	}

	public partial class XQCEXAQ31100OutBlock2 : XingBlock
	{
		/// <summary>
		/// CEXAQ31100OutBlock2
		/// </summary>
		public const string _blockName = "CEXAQ31100OutBlock2";
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
		/// CEXAQ31100OutBlock2
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CEXAQ31100OutBlock2
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
		/// 매매손익금액
		/// </summary>
		[XAQueryFieldAttribute("BnsplAmt", "매매손익금액", "long", "16")]
		public long BnsplAmt;
		/// <summary>
		/// 정산차금
		/// </summary>
		[XAQueryFieldAttribute("AdjstDfamt", "정산차금", "long", "16")]
		public long AdjstDfamt;
		/// <summary>
		/// 총평가금액
		/// </summary>
		[XAQueryFieldAttribute("TotEvalAmt", "총평가금액", "long", "16")]
		public long TotEvalAmt;
		/// <summary>
		/// 총손익금액
		/// </summary>
		[XAQueryFieldAttribute("TotPnlAmt", "총손익금액", "long", "16")]
		public long TotPnlAmt;

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
			/// 매매손익금액
			/// </summary>
			public const string BnsplAmt = "BnsplAmt";
			/// <summary>
			/// 정산차금
			/// </summary>
			public const string AdjstDfamt = "AdjstDfamt";
			/// <summary>
			/// 총평가금액
			/// </summary>
			public const string TotEvalAmt = "TotEvalAmt";
			/// <summary>
			/// 총손익금액
			/// </summary>
			public const string TotPnlAmt = "TotPnlAmt";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.AcntNo,
			F.AcntNm,
			F.BnsplAmt,
			F.AdjstDfamt,
			F.TotEvalAmt,
			F.TotPnlAmt,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["AcntNo"] = new XAQueryFieldInfo("char", AcntNo, AcntNo, "계좌번호", (decimal)20);
			dict["AcntNm"] = new XAQueryFieldInfo("char", AcntNm, AcntNm, "계좌명", (decimal)40);
			dict["BnsplAmt"] = new XAQueryFieldInfo("long", BnsplAmt, BnsplAmt.ToString("d16"), "매매손익금액", (decimal)16);
			dict["AdjstDfamt"] = new XAQueryFieldInfo("long", AdjstDfamt, AdjstDfamt.ToString("d16"), "정산차금", (decimal)16);
			dict["TotEvalAmt"] = new XAQueryFieldInfo("long", TotEvalAmt, TotEvalAmt.ToString("d16"), "총평가금액", (decimal)16);
			dict["TotPnlAmt"] = new XAQueryFieldInfo("long", TotPnlAmt, TotPnlAmt.ToString("d16"), "총손익금액", (decimal)16);

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

				case "BnsplAmt":
					this.BnsplAmt = fieldInfo.FieldValue.ParseLong("BnsplAmt");
				break;

				case "AdjstDfamt":
					this.AdjstDfamt = fieldInfo.FieldValue.ParseLong("AdjstDfamt");
				break;

				case "TotEvalAmt":
					this.TotEvalAmt = fieldInfo.FieldValue.ParseLong("TotEvalAmt");
				break;

				case "TotPnlAmt":
					this.TotPnlAmt = fieldInfo.FieldValue.ParseLong("TotPnlAmt");
				break;


			}
		}

		public static XQCEXAQ31100OutBlock2 FromQuery(XQCEXAQ31100 query)
		{
			XQCEXAQ31100OutBlock2 block = new XQCEXAQ31100OutBlock2();
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
				block.BnsplAmt = query.GetFieldData(block.GetBlockName(), "BnsplAmt", 0).ParseLong("BnsplAmt"); // long 16
				block.AdjstDfamt = query.GetFieldData(block.GetBlockName(), "AdjstDfamt", 0).ParseLong("AdjstDfamt"); // long 16
				block.TotEvalAmt = query.GetFieldData(block.GetBlockName(), "TotEvalAmt", 0).ParseLong("TotEvalAmt"); // long 16
				block.TotPnlAmt = query.GetFieldData(block.GetBlockName(), "TotPnlAmt", 0).ParseLong("TotPnlAmt"); // long 16

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
			if (BnsplAmt.ToString().Length > 16) return false; // long 16
			if (AdjstDfamt.ToString().Length > 16) return false; // long 16
			if (TotEvalAmt.ToString().Length > 16) return false; // long 16
			if (TotPnlAmt.ToString().Length > 16) return false; // long 16

			return true;
		}

		public void CopyTo(XQCEXAQ31100OutBlock2 block)
		{
			block.RecCnt = this.RecCnt;
			block.AcntNo = this.AcntNo;
			block.AcntNm = this.AcntNm;
			block.BnsplAmt = this.BnsplAmt;
			block.AdjstDfamt = this.AdjstDfamt;
			block.TotEvalAmt = this.TotEvalAmt;
			block.TotPnlAmt = this.TotPnlAmt;

		}
	}

	public partial class XQCEXAQ31100OutBlock3 : XingBlock
	{
		/// <summary>
		/// CEXAQ31100OutBlock3
		/// </summary>
		public const string _blockName = "CEXAQ31100OutBlock3";
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
		/// CEXAQ31100OutBlock3
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CEXAQ31100OutBlock3
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
		/// 청산가능수량
		/// </summary>
		[XAQueryFieldAttribute("LqdtAbleQty", "청산가능수량", "long", "16")]
		public long LqdtAbleQty;
		/// <summary>
		/// 평균가
		/// </summary>
		[XAQueryFieldAttribute("FnoAvrPrc", "평균가", "double", "19.8")]
		public double FnoAvrPrc;
		/// <summary>
		/// 기준가
		/// </summary>
		[XAQueryFieldAttribute("BasePrc", "기준가", "double", "30.10")]
		public double BasePrc;
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
		/// 평가금액
		/// </summary>
		[XAQueryFieldAttribute("EvalAmt", "평가금액", "long", "16")]
		public long EvalAmt;
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
		/// 미결제금액
		/// </summary>
		[XAQueryFieldAttribute("UnsttAmt", "미결제금액", "long", "16")]
		public long UnsttAmt;
		/// <summary>
		/// 매매손익금액
		/// </summary>
		[XAQueryFieldAttribute("BnsplAmt", "매매손익금액", "long", "16")]
		public long BnsplAmt;

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
			/// 청산가능수량
			/// </summary>
			public const string LqdtAbleQty = "LqdtAbleQty";
			/// <summary>
			/// 평균가
			/// </summary>
			public const string FnoAvrPrc = "FnoAvrPrc";
			/// <summary>
			/// 기준가
			/// </summary>
			public const string BasePrc = "BasePrc";
			/// <summary>
			/// 현재가
			/// </summary>
			public const string NowPrc = "NowPrc";
			/// <summary>
			/// 대비가
			/// </summary>
			public const string CmpPrc = "CmpPrc";
			/// <summary>
			/// 평가금액
			/// </summary>
			public const string EvalAmt = "EvalAmt";
			/// <summary>
			/// 평가손익
			/// </summary>
			public const string EvalPnl = "EvalPnl";
			/// <summary>
			/// 손익률
			/// </summary>
			public const string PnlRat = "PnlRat";
			/// <summary>
			/// 미결제금액
			/// </summary>
			public const string UnsttAmt = "UnsttAmt";
			/// <summary>
			/// 매매손익금액
			/// </summary>
			public const string BnsplAmt = "BnsplAmt";
		}

		public static string[] AllFields = new string[]
		{
			F.FnoIsuNo,
			F.IsuNm,
			F.BnsTpCode,
			F.BnsTpNm,
			F.UnsttQty,
			F.LqdtAbleQty,
			F.FnoAvrPrc,
			F.BasePrc,
			F.NowPrc,
			F.CmpPrc,
			F.EvalAmt,
			F.EvalPnl,
			F.PnlRat,
			F.UnsttAmt,
			F.BnsplAmt,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["FnoIsuNo"] = new XAQueryFieldInfo("char", FnoIsuNo, FnoIsuNo, "선물옵션종목번호", (decimal)12);
			dict["IsuNm"] = new XAQueryFieldInfo("char", IsuNm, IsuNm, "종목명", (decimal)40);
			dict["BnsTpCode"] = new XAQueryFieldInfo("char", BnsTpCode, BnsTpCode.ToString(), "매매구분", (decimal)1);
			dict["BnsTpNm"] = new XAQueryFieldInfo("char", BnsTpNm, BnsTpNm, "매매구분", (decimal)10);
			dict["UnsttQty"] = new XAQueryFieldInfo("long", UnsttQty, UnsttQty.ToString("d16"), "미결제수량", (decimal)16);
			dict["LqdtAbleQty"] = new XAQueryFieldInfo("long", LqdtAbleQty, LqdtAbleQty.ToString("d16"), "청산가능수량", (decimal)16);
			dict["FnoAvrPrc"] = new XAQueryFieldInfo("double", FnoAvrPrc, FnoAvrPrc.ToString("0000000000000000000.00000000"), "평균가", (decimal)19.8);
			dict["BasePrc"] = new XAQueryFieldInfo("double", BasePrc, BasePrc.ToString("000000000000000000000000000000.0000000000"), "기준가", (decimal)30.10);
			dict["NowPrc"] = new XAQueryFieldInfo("double", NowPrc, NowPrc.ToString("0000000000000.00"), "현재가", (decimal)13.2);
			dict["CmpPrc"] = new XAQueryFieldInfo("double", CmpPrc, CmpPrc.ToString("0000000000000.00"), "대비가", (decimal)13.2);
			dict["EvalAmt"] = new XAQueryFieldInfo("long", EvalAmt, EvalAmt.ToString("d16"), "평가금액", (decimal)16);
			dict["EvalPnl"] = new XAQueryFieldInfo("long", EvalPnl, EvalPnl.ToString("d16"), "평가손익", (decimal)16);
			dict["PnlRat"] = new XAQueryFieldInfo("double", PnlRat, PnlRat.ToString("000000000000.000000"), "손익률", (decimal)12.6);
			dict["UnsttAmt"] = new XAQueryFieldInfo("long", UnsttAmt, UnsttAmt.ToString("d16"), "미결제금액", (decimal)16);
			dict["BnsplAmt"] = new XAQueryFieldInfo("long", BnsplAmt, BnsplAmt.ToString("d16"), "매매손익금액", (decimal)16);

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

				case "LqdtAbleQty":
					this.LqdtAbleQty = fieldInfo.FieldValue.ParseLong("LqdtAbleQty");
				break;

				case "FnoAvrPrc":
					this.FnoAvrPrc = fieldInfo.FieldValue.ParseDouble("FnoAvrPrc");
				break;

				case "BasePrc":
					this.BasePrc = fieldInfo.FieldValue.ParseDouble("BasePrc");
				break;

				case "NowPrc":
					this.NowPrc = fieldInfo.FieldValue.ParseDouble("NowPrc");
				break;

				case "CmpPrc":
					this.CmpPrc = fieldInfo.FieldValue.ParseDouble("CmpPrc");
				break;

				case "EvalAmt":
					this.EvalAmt = fieldInfo.FieldValue.ParseLong("EvalAmt");
				break;

				case "EvalPnl":
					this.EvalPnl = fieldInfo.FieldValue.ParseLong("EvalPnl");
				break;

				case "PnlRat":
					this.PnlRat = fieldInfo.FieldValue.ParseDouble("PnlRat");
				break;

				case "UnsttAmt":
					this.UnsttAmt = fieldInfo.FieldValue.ParseLong("UnsttAmt");
				break;

				case "BnsplAmt":
					this.BnsplAmt = fieldInfo.FieldValue.ParseLong("BnsplAmt");
				break;


			}
		}

		public static XQCEXAQ31100OutBlock3[] ListFromQuery(XQCEXAQ31100 query)
		{
			int count = query.GetBlockCount(XQCEXAQ31100OutBlock3.BlockName);
			List<XQCEXAQ31100OutBlock3> list = new List<XQCEXAQ31100OutBlock3>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQCEXAQ31100OutBlock3 block = new XQCEXAQ31100OutBlock3();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.FnoIsuNo = query.GetFieldData(block.GetBlockName(), "FnoIsuNo", i).TrimEnd('?'); // char 12
					block.IsuNm = query.GetFieldData(block.GetBlockName(), "IsuNm", i).TrimEnd('?'); // char 40
					block.BnsTpCode = query.GetFieldData(block.GetBlockName(), "BnsTpCode", i).FirstOrDefault(); // char 1
					block.BnsTpNm = query.GetFieldData(block.GetBlockName(), "BnsTpNm", i).TrimEnd('?'); // char 10
					block.UnsttQty = query.GetFieldData(block.GetBlockName(), "UnsttQty", i).ParseLong("UnsttQty"); // long 16
					block.LqdtAbleQty = query.GetFieldData(block.GetBlockName(), "LqdtAbleQty", i).ParseLong("LqdtAbleQty"); // long 16
					block.FnoAvrPrc = query.GetFieldData(block.GetBlockName(), "FnoAvrPrc", i).ParseDouble("FnoAvrPrc"); // double 19.8
					block.BasePrc = query.GetFieldData(block.GetBlockName(), "BasePrc", i).ParseDouble("BasePrc"); // double 30.10
					block.NowPrc = query.GetFieldData(block.GetBlockName(), "NowPrc", i).ParseDouble("NowPrc"); // double 13.2
					block.CmpPrc = query.GetFieldData(block.GetBlockName(), "CmpPrc", i).ParseDouble("CmpPrc"); // double 13.2
					block.EvalAmt = query.GetFieldData(block.GetBlockName(), "EvalAmt", i).ParseLong("EvalAmt"); // long 16
					block.EvalPnl = query.GetFieldData(block.GetBlockName(), "EvalPnl", i).ParseLong("EvalPnl"); // long 16
					block.PnlRat = query.GetFieldData(block.GetBlockName(), "PnlRat", i).ParseDouble("PnlRat"); // double 12.6
					block.UnsttAmt = query.GetFieldData(block.GetBlockName(), "UnsttAmt", i).ParseLong("UnsttAmt"); // long 16
					block.BnsplAmt = query.GetFieldData(block.GetBlockName(), "BnsplAmt", i).ParseLong("BnsplAmt"); // long 16

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
			if (LqdtAbleQty.ToString().Length > 16) return false; // long 16
			// FnoAvrPrc double 19.8
			// BasePrc double 30.10
			// NowPrc double 13.2
			// CmpPrc double 13.2
			if (EvalAmt.ToString().Length > 16) return false; // long 16
			if (EvalPnl.ToString().Length > 16) return false; // long 16
			// PnlRat double 12.6
			if (UnsttAmt.ToString().Length > 16) return false; // long 16
			if (BnsplAmt.ToString().Length > 16) return false; // long 16

			return true;
		}

		public void CopyTo(XQCEXAQ31100OutBlock3 block)
		{
			block.FnoIsuNo = this.FnoIsuNo;
			block.IsuNm = this.IsuNm;
			block.BnsTpCode = this.BnsTpCode;
			block.BnsTpNm = this.BnsTpNm;
			block.UnsttQty = this.UnsttQty;
			block.LqdtAbleQty = this.LqdtAbleQty;
			block.FnoAvrPrc = this.FnoAvrPrc;
			block.BasePrc = this.BasePrc;
			block.NowPrc = this.NowPrc;
			block.CmpPrc = this.CmpPrc;
			block.EvalAmt = this.EvalAmt;
			block.EvalPnl = this.EvalPnl;
			block.PnlRat = this.PnlRat;
			block.UnsttAmt = this.UnsttAmt;
			block.BnsplAmt = this.BnsplAmt;

		}
	}

	/// <summary>
	/// 유렉스 야간장잔고및 평가현황
	/// </summary>
	public partial class XQCEXAQ31100 : XingQuery
	{
		/// <summary>
		/// CEXAQ31100
		/// </summary>
		public const string _typeName = "CEXAQ31100";
		/// <summary>
		/// 유렉스 야간장잔고및 평가현황
		/// </summary>
		public const string _typeDesc = "유렉스 야간장잔고및 평가현황";
		/// <summary>
		/// CEXAQ31100
		/// </summary>
		public const string _service = "CEXAQ31100";
		/// <summary>
		/// B
		/// </summary>
		public const string _headType = "B";
		/// <summary>
		/// 이시종
		/// </summary>
		public const string _creator = "이시종";
		/// <summary>
		/// 2012/12/22 14:39:24
		/// </summary>
		public const string _createdDate = "2012/12/22 14:39:24";
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
		/// CEXAQ31100
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 유렉스 야간장잔고및 평가현황
		/// </summary>
		public string TypeDesc => _typeDesc;
		/// <summary>
		/// CEXAQ31100
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
		/// 2012/12/22 14:39:24
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
		/// 유렉스 야간장잔고및 평가현황
		/// </summary>
		public XQCEXAQ31100() : base("CEXAQ31100") { }




		public bool SetBlock(XQCEXAQ31100InBlock1 block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "RecCnt", 0, block.RecCnt.ToString("d5")); // long 5
			_xaQuery.SetFieldData(block.GetBlockName(), "AcntNo", 0, block.AcntNo); // char 20
			_xaQuery.SetFieldData(block.GetBlockName(), "InptPwd", 0, block.InptPwd); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "IsuCode", 0, block.IsuCode); // char 12
			_xaQuery.SetFieldData(block.GetBlockName(), "BalEvalTp", 0, block.BalEvalTp.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "FutsPrcEvalTp", 0, block.FutsPrcEvalTp.ToString()); // char 1

			return true;
		}

		public XQCEXAQ31100OutBlock1 GetBlock1()
		{
			XQCEXAQ31100OutBlock1 instance = XQCEXAQ31100OutBlock1.FromQuery(this);
			return instance;

		}

		public XQCEXAQ31100OutBlock2 GetBlock2()
		{
			XQCEXAQ31100OutBlock2 instance = XQCEXAQ31100OutBlock2.FromQuery(this);
			return instance;

		}

		public XQCEXAQ31100OutBlock3[] GetBlock3s()
		{
			XQCEXAQ31100OutBlock3[] instance = XQCEXAQ31100OutBlock3.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQCEXAQ31100OutBlock1),
			typeof(XQCEXAQ31100OutBlock2),
			typeof(XQCEXAQ31100OutBlock3),

		};

	}

}
