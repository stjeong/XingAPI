using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQCLNAQ00100InBlock1 : XingBlock
	{
		/// <summary>
		/// CLNAQ00100InBlock1
		/// </summary>
		public const string _blockName = "CLNAQ00100InBlock1";
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
		/// CLNAQ00100InBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CLNAQ00100InBlock1
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
		/// 조회구분
		/// </summary>
		[XAQueryFieldAttribute("QryTp", "조회구분", "char", "1")]
		public char QryTp;
		/// <summary>
		/// 종목번호
		/// </summary>
		[XAQueryFieldAttribute("IsuNo", "종목번호", "char", "12")]
		public string IsuNo;
		/// <summary>
		/// 유가증권구분
		/// </summary>
		[XAQueryFieldAttribute("SecTpCode", "유가증권구분", "char", "1")]
		public char SecTpCode;
		/// <summary>
		/// 대출이자등급코드
		/// </summary>
		[XAQueryFieldAttribute("LoanIntrstGrdCode", "대출이자등급코드", "char", "2")]
		public string LoanIntrstGrdCode;
		/// <summary>
		/// 대출구분
		/// </summary>
		[XAQueryFieldAttribute("LoanTp", "대출구분", "char", "1")]
		public char LoanTp;

		public static class F
		{
			/// <summary>
			/// 레코드갯수
			/// </summary>
			public const string RecCnt = "RecCnt";
			/// <summary>
			/// 조회구분
			/// </summary>
			public const string QryTp = "QryTp";
			/// <summary>
			/// 종목번호
			/// </summary>
			public const string IsuNo = "IsuNo";
			/// <summary>
			/// 유가증권구분
			/// </summary>
			public const string SecTpCode = "SecTpCode";
			/// <summary>
			/// 대출이자등급코드
			/// </summary>
			public const string LoanIntrstGrdCode = "LoanIntrstGrdCode";
			/// <summary>
			/// 대출구분
			/// </summary>
			public const string LoanTp = "LoanTp";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.QryTp,
			F.IsuNo,
			F.SecTpCode,
			F.LoanIntrstGrdCode,
			F.LoanTp,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["QryTp"] = new XAQueryFieldInfo("char", QryTp, QryTp.ToString(), "조회구분", (decimal)1);
			dict["IsuNo"] = new XAQueryFieldInfo("char", IsuNo, IsuNo, "종목번호", (decimal)12);
			dict["SecTpCode"] = new XAQueryFieldInfo("char", SecTpCode, SecTpCode.ToString(), "유가증권구분", (decimal)1);
			dict["LoanIntrstGrdCode"] = new XAQueryFieldInfo("char", LoanIntrstGrdCode, LoanIntrstGrdCode, "대출이자등급코드", (decimal)2);
			dict["LoanTp"] = new XAQueryFieldInfo("char", LoanTp, LoanTp.ToString(), "대출구분", (decimal)1);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "RecCnt":
					this.RecCnt = fieldInfo.FieldValue.ParseLong("RecCnt");
				break;

				case "QryTp":
					this.QryTp = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "IsuNo":
					this.IsuNo = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "SecTpCode":
					this.SecTpCode = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "LoanIntrstGrdCode":
					this.LoanIntrstGrdCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "LoanTp":
					this.LoanTp = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public bool VerifyData()
		{
			if (RecCnt.ToString().Length > 5) return false; // long 5
			// QryTp char 1
			if (IsuNo?.Length > 12) return false; // char 12
			// SecTpCode char 1
			if (LoanIntrstGrdCode?.Length > 2) return false; // char 2
			// LoanTp char 1

			return true;
		}

		public void CopyTo(XQCLNAQ00100InBlock1 block)
		{
			block.RecCnt = this.RecCnt;
			block.QryTp = this.QryTp;
			block.IsuNo = this.IsuNo;
			block.SecTpCode = this.SecTpCode;
			block.LoanIntrstGrdCode = this.LoanIntrstGrdCode;
			block.LoanTp = this.LoanTp;

		}
	}

	public partial class XQCLNAQ00100OutBlock1 : XingBlock
	{
		/// <summary>
		/// CLNAQ00100OutBlock1
		/// </summary>
		public const string _blockName = "CLNAQ00100OutBlock1";
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
		/// CLNAQ00100OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CLNAQ00100OutBlock1
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
		/// 조회구분
		/// </summary>
		[XAQueryFieldAttribute("QryTp", "조회구분", "char", "1")]
		public char QryTp;
		/// <summary>
		/// 종목번호
		/// </summary>
		[XAQueryFieldAttribute("IsuNo", "종목번호", "char", "12")]
		public string IsuNo;
		/// <summary>
		/// 유가증권구분
		/// </summary>
		[XAQueryFieldAttribute("SecTpCode", "유가증권구분", "char", "1")]
		public char SecTpCode;
		/// <summary>
		/// 대출이자등급코드
		/// </summary>
		[XAQueryFieldAttribute("LoanIntrstGrdCode", "대출이자등급코드", "char", "2")]
		public string LoanIntrstGrdCode;
		/// <summary>
		/// 대출구분
		/// </summary>
		[XAQueryFieldAttribute("LoanTp", "대출구분", "char", "1")]
		public char LoanTp;

		public static class F
		{
			/// <summary>
			/// 레코드갯수
			/// </summary>
			public const string RecCnt = "RecCnt";
			/// <summary>
			/// 조회구분
			/// </summary>
			public const string QryTp = "QryTp";
			/// <summary>
			/// 종목번호
			/// </summary>
			public const string IsuNo = "IsuNo";
			/// <summary>
			/// 유가증권구분
			/// </summary>
			public const string SecTpCode = "SecTpCode";
			/// <summary>
			/// 대출이자등급코드
			/// </summary>
			public const string LoanIntrstGrdCode = "LoanIntrstGrdCode";
			/// <summary>
			/// 대출구분
			/// </summary>
			public const string LoanTp = "LoanTp";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.QryTp,
			F.IsuNo,
			F.SecTpCode,
			F.LoanIntrstGrdCode,
			F.LoanTp,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["QryTp"] = new XAQueryFieldInfo("char", QryTp, QryTp.ToString(), "조회구분", (decimal)1);
			dict["IsuNo"] = new XAQueryFieldInfo("char", IsuNo, IsuNo, "종목번호", (decimal)12);
			dict["SecTpCode"] = new XAQueryFieldInfo("char", SecTpCode, SecTpCode.ToString(), "유가증권구분", (decimal)1);
			dict["LoanIntrstGrdCode"] = new XAQueryFieldInfo("char", LoanIntrstGrdCode, LoanIntrstGrdCode, "대출이자등급코드", (decimal)2);
			dict["LoanTp"] = new XAQueryFieldInfo("char", LoanTp, LoanTp.ToString(), "대출구분", (decimal)1);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "RecCnt":
					this.RecCnt = fieldInfo.FieldValue.ParseLong("RecCnt");
				break;

				case "QryTp":
					this.QryTp = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "IsuNo":
					this.IsuNo = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "SecTpCode":
					this.SecTpCode = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "LoanIntrstGrdCode":
					this.LoanIntrstGrdCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "LoanTp":
					this.LoanTp = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public static XQCLNAQ00100OutBlock1 FromQuery(XQCLNAQ00100 query)
		{
			XQCLNAQ00100OutBlock1 block = new XQCLNAQ00100OutBlock1();
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
				block.QryTp = query.GetFieldData(block.GetBlockName(), "QryTp", 0).FirstOrDefault(); // char 1
				block.IsuNo = query.GetFieldData(block.GetBlockName(), "IsuNo", 0).TrimEnd('?'); // char 12
				block.SecTpCode = query.GetFieldData(block.GetBlockName(), "SecTpCode", 0).FirstOrDefault(); // char 1
				block.LoanIntrstGrdCode = query.GetFieldData(block.GetBlockName(), "LoanIntrstGrdCode", 0).TrimEnd('?'); // char 2
				block.LoanTp = query.GetFieldData(block.GetBlockName(), "LoanTp", 0).FirstOrDefault(); // char 1

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (RecCnt.ToString().Length > 5) return false; // long 5
			// QryTp char 1
			if (IsuNo?.Length > 12) return false; // char 12
			// SecTpCode char 1
			if (LoanIntrstGrdCode?.Length > 2) return false; // char 2
			// LoanTp char 1

			return true;
		}

		public void CopyTo(XQCLNAQ00100OutBlock1 block)
		{
			block.RecCnt = this.RecCnt;
			block.QryTp = this.QryTp;
			block.IsuNo = this.IsuNo;
			block.SecTpCode = this.SecTpCode;
			block.LoanIntrstGrdCode = this.LoanIntrstGrdCode;
			block.LoanTp = this.LoanTp;

		}
	}

	public partial class XQCLNAQ00100OutBlock2 : XingBlock
	{
		/// <summary>
		/// CLNAQ00100OutBlock2
		/// </summary>
		public const string _blockName = "CLNAQ00100OutBlock2";
		/// <summary>
		/// Out(*EMPTY*)
		/// </summary>
		public const string _blockDesc = "Out(*EMPTY*)";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// true
		/// </summary>
		public const bool _hasOccurs = true;
		/// <summary>
		/// CLNAQ00100OutBlock2
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CLNAQ00100OutBlock2
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
		/// true
		/// </summary>
		public bool HasOccurs => _hasOccurs;

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
		/// 액면가
		/// </summary>
		[XAQueryFieldAttribute("Parprc", "액면가", "double", "13.2")]
		public double Parprc;
		/// <summary>
		/// 전일종가
		/// </summary>
		[XAQueryFieldAttribute("PrdayCprc", "전일종가", "double", "13.2")]
		public double PrdayCprc;
		/// <summary>
		/// 비율값
		/// </summary>
		[XAQueryFieldAttribute("RatVal", "비율값", "double", "19.8")]
		public double RatVal;
		/// <summary>
		/// 대용가
		/// </summary>
		[XAQueryFieldAttribute("SubstPrc", "대용가", "double", "13.2")]
		public double SubstPrc;
		/// <summary>
		/// 등록구분
		/// </summary>
		[XAQueryFieldAttribute("RegTpNm", "등록구분", "char", "20")]
		public string RegTpNm;
		/// <summary>
		/// 현물증거금징수분류명
		/// </summary>
		[XAQueryFieldAttribute("SpotMgnLevyClssNm", "현물증거금징수분류명", "char", "40")]
		public string SpotMgnLevyClssNm;
		/// <summary>
		/// 거래정지사유
		/// </summary>
		[XAQueryFieldAttribute("FnoTrdStopRsnCnts", "거래정지사유", "char", "40")]
		public string FnoTrdStopRsnCnts;
		/// <summary>
		/// 요주의유형명
		/// </summary>
		[XAQueryFieldAttribute("DgrsPtnNm", "요주의유형명", "char", "40")]
		public string DgrsPtnNm;
		/// <summary>
		/// 사고유형
		/// </summary>
		[XAQueryFieldAttribute("AcdPtnNm", "사고유형", "char", "40")]
		public string AcdPtnNm;
		/// <summary>
		/// 시장구분
		/// </summary>
		[XAQueryFieldAttribute("MktTpNm", "시장구분", "char", "20")]
		public string MktTpNm;
		/// <summary>
		/// 한도값
		/// </summary>
		[XAQueryFieldAttribute("LmtVal", "한도값", "long", "18")]
		public long LmtVal;
		/// <summary>
		/// 계좌한도값
		/// </summary>
		[XAQueryFieldAttribute("AcntLmtVal", "계좌한도값", "long", "18")]
		public long AcntLmtVal;
		/// <summary>
		/// 대출등급코드
		/// </summary>
		[XAQueryFieldAttribute("LoanGrdCode", "대출등급코드", "char", "2")]
		public string LoanGrdCode;
		/// <summary>
		/// 대출금액
		/// </summary>
		[XAQueryFieldAttribute("LoanAmt", "대출금액", "long", "16")]
		public long LoanAmt;
		/// <summary>
		/// 대출가능율
		/// </summary>
		[XAQueryFieldAttribute("LoanAbleRat", "대출가능율", "double", "26.9")]
		public double LoanAbleRat;
		/// <summary>
		/// 대출이율1
		/// </summary>
		[XAQueryFieldAttribute("LoanIntrat1", "대출이율1", "double", "14.4")]
		public double LoanIntrat1;
		/// <summary>
		/// 등록자ID
		/// </summary>
		[XAQueryFieldAttribute("RegPsnId", "등록자ID", "char", "16")]
		public string RegPsnId;
		/// <summary>
		/// 비율값
		/// </summary>
		[XAQueryFieldAttribute("Rat01", "비율값", "double", "19.8")]
		public double Rat01;
		/// <summary>
		/// 비율값
		/// </summary>
		[XAQueryFieldAttribute("Rat02", "비율값", "double", "19.8")]
		public double Rat02;

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
			/// 액면가
			/// </summary>
			public const string Parprc = "Parprc";
			/// <summary>
			/// 전일종가
			/// </summary>
			public const string PrdayCprc = "PrdayCprc";
			/// <summary>
			/// 비율값
			/// </summary>
			public const string RatVal = "RatVal";
			/// <summary>
			/// 대용가
			/// </summary>
			public const string SubstPrc = "SubstPrc";
			/// <summary>
			/// 등록구분
			/// </summary>
			public const string RegTpNm = "RegTpNm";
			/// <summary>
			/// 현물증거금징수분류명
			/// </summary>
			public const string SpotMgnLevyClssNm = "SpotMgnLevyClssNm";
			/// <summary>
			/// 거래정지사유
			/// </summary>
			public const string FnoTrdStopRsnCnts = "FnoTrdStopRsnCnts";
			/// <summary>
			/// 요주의유형명
			/// </summary>
			public const string DgrsPtnNm = "DgrsPtnNm";
			/// <summary>
			/// 사고유형
			/// </summary>
			public const string AcdPtnNm = "AcdPtnNm";
			/// <summary>
			/// 시장구분
			/// </summary>
			public const string MktTpNm = "MktTpNm";
			/// <summary>
			/// 한도값
			/// </summary>
			public const string LmtVal = "LmtVal";
			/// <summary>
			/// 계좌한도값
			/// </summary>
			public const string AcntLmtVal = "AcntLmtVal";
			/// <summary>
			/// 대출등급코드
			/// </summary>
			public const string LoanGrdCode = "LoanGrdCode";
			/// <summary>
			/// 대출금액
			/// </summary>
			public const string LoanAmt = "LoanAmt";
			/// <summary>
			/// 대출가능율
			/// </summary>
			public const string LoanAbleRat = "LoanAbleRat";
			/// <summary>
			/// 대출이율1
			/// </summary>
			public const string LoanIntrat1 = "LoanIntrat1";
			/// <summary>
			/// 등록자ID
			/// </summary>
			public const string RegPsnId = "RegPsnId";
			/// <summary>
			/// 비율값
			/// </summary>
			public const string Rat01 = "Rat01";
			/// <summary>
			/// 비율값
			/// </summary>
			public const string Rat02 = "Rat02";
		}

		public static string[] AllFields = new string[]
		{
			F.IsuNo,
			F.IsuNm,
			F.Parprc,
			F.PrdayCprc,
			F.RatVal,
			F.SubstPrc,
			F.RegTpNm,
			F.SpotMgnLevyClssNm,
			F.FnoTrdStopRsnCnts,
			F.DgrsPtnNm,
			F.AcdPtnNm,
			F.MktTpNm,
			F.LmtVal,
			F.AcntLmtVal,
			F.LoanGrdCode,
			F.LoanAmt,
			F.LoanAbleRat,
			F.LoanIntrat1,
			F.RegPsnId,
			F.Rat01,
			F.Rat02,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["IsuNo"] = new XAQueryFieldInfo("char", IsuNo, IsuNo, "종목번호", (decimal)12);
			dict["IsuNm"] = new XAQueryFieldInfo("char", IsuNm, IsuNm, "종목명", (decimal)40);
			dict["Parprc"] = new XAQueryFieldInfo("double", Parprc, Parprc.ToString("0000000000000.00"), "액면가", (decimal)13.2);
			dict["PrdayCprc"] = new XAQueryFieldInfo("double", PrdayCprc, PrdayCprc.ToString("0000000000000.00"), "전일종가", (decimal)13.2);
			dict["RatVal"] = new XAQueryFieldInfo("double", RatVal, RatVal.ToString("0000000000000000000.00000000"), "비율값", (decimal)19.8);
			dict["SubstPrc"] = new XAQueryFieldInfo("double", SubstPrc, SubstPrc.ToString("0000000000000.00"), "대용가", (decimal)13.2);
			dict["RegTpNm"] = new XAQueryFieldInfo("char", RegTpNm, RegTpNm, "등록구분", (decimal)20);
			dict["SpotMgnLevyClssNm"] = new XAQueryFieldInfo("char", SpotMgnLevyClssNm, SpotMgnLevyClssNm, "현물증거금징수분류명", (decimal)40);
			dict["FnoTrdStopRsnCnts"] = new XAQueryFieldInfo("char", FnoTrdStopRsnCnts, FnoTrdStopRsnCnts, "거래정지사유", (decimal)40);
			dict["DgrsPtnNm"] = new XAQueryFieldInfo("char", DgrsPtnNm, DgrsPtnNm, "요주의유형명", (decimal)40);
			dict["AcdPtnNm"] = new XAQueryFieldInfo("char", AcdPtnNm, AcdPtnNm, "사고유형", (decimal)40);
			dict["MktTpNm"] = new XAQueryFieldInfo("char", MktTpNm, MktTpNm, "시장구분", (decimal)20);
			dict["LmtVal"] = new XAQueryFieldInfo("long", LmtVal, LmtVal.ToString("d18"), "한도값", (decimal)18);
			dict["AcntLmtVal"] = new XAQueryFieldInfo("long", AcntLmtVal, AcntLmtVal.ToString("d18"), "계좌한도값", (decimal)18);
			dict["LoanGrdCode"] = new XAQueryFieldInfo("char", LoanGrdCode, LoanGrdCode, "대출등급코드", (decimal)2);
			dict["LoanAmt"] = new XAQueryFieldInfo("long", LoanAmt, LoanAmt.ToString("d16"), "대출금액", (decimal)16);
			dict["LoanAbleRat"] = new XAQueryFieldInfo("double", LoanAbleRat, LoanAbleRat.ToString("00000000000000000000000000.000000000"), "대출가능율", (decimal)26.9);
			dict["LoanIntrat1"] = new XAQueryFieldInfo("double", LoanIntrat1, LoanIntrat1.ToString("00000000000000.0000"), "대출이율1", (decimal)14.4);
			dict["RegPsnId"] = new XAQueryFieldInfo("char", RegPsnId, RegPsnId, "등록자ID", (decimal)16);
			dict["Rat01"] = new XAQueryFieldInfo("double", Rat01, Rat01.ToString("0000000000000000000.00000000"), "비율값", (decimal)19.8);
			dict["Rat02"] = new XAQueryFieldInfo("double", Rat02, Rat02.ToString("0000000000000000000.00000000"), "비율값", (decimal)19.8);

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

				case "Parprc":
					this.Parprc = fieldInfo.FieldValue.ParseDouble("Parprc");
				break;

				case "PrdayCprc":
					this.PrdayCprc = fieldInfo.FieldValue.ParseDouble("PrdayCprc");
				break;

				case "RatVal":
					this.RatVal = fieldInfo.FieldValue.ParseDouble("RatVal");
				break;

				case "SubstPrc":
					this.SubstPrc = fieldInfo.FieldValue.ParseDouble("SubstPrc");
				break;

				case "RegTpNm":
					this.RegTpNm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "SpotMgnLevyClssNm":
					this.SpotMgnLevyClssNm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "FnoTrdStopRsnCnts":
					this.FnoTrdStopRsnCnts = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "DgrsPtnNm":
					this.DgrsPtnNm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "AcdPtnNm":
					this.AcdPtnNm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "MktTpNm":
					this.MktTpNm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "LmtVal":
					this.LmtVal = fieldInfo.FieldValue.ParseLong("LmtVal");
				break;

				case "AcntLmtVal":
					this.AcntLmtVal = fieldInfo.FieldValue.ParseLong("AcntLmtVal");
				break;

				case "LoanGrdCode":
					this.LoanGrdCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "LoanAmt":
					this.LoanAmt = fieldInfo.FieldValue.ParseLong("LoanAmt");
				break;

				case "LoanAbleRat":
					this.LoanAbleRat = fieldInfo.FieldValue.ParseDouble("LoanAbleRat");
				break;

				case "LoanIntrat1":
					this.LoanIntrat1 = fieldInfo.FieldValue.ParseDouble("LoanIntrat1");
				break;

				case "RegPsnId":
					this.RegPsnId = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "Rat01":
					this.Rat01 = fieldInfo.FieldValue.ParseDouble("Rat01");
				break;

				case "Rat02":
					this.Rat02 = fieldInfo.FieldValue.ParseDouble("Rat02");
				break;


			}
		}

		public static XQCLNAQ00100OutBlock2[] ListFromQuery(XQCLNAQ00100 query)
		{
			int count = query.GetBlockCount(XQCLNAQ00100OutBlock2.BlockName);
			List<XQCLNAQ00100OutBlock2> list = new List<XQCLNAQ00100OutBlock2>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQCLNAQ00100OutBlock2 block = new XQCLNAQ00100OutBlock2();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.IsuNo = query.GetFieldData(block.GetBlockName(), "IsuNo", i).TrimEnd('?'); // char 12
					block.IsuNm = query.GetFieldData(block.GetBlockName(), "IsuNm", i).TrimEnd('?'); // char 40
					block.Parprc = query.GetFieldData(block.GetBlockName(), "Parprc", i).ParseDouble("Parprc"); // double 13.2
					block.PrdayCprc = query.GetFieldData(block.GetBlockName(), "PrdayCprc", i).ParseDouble("PrdayCprc"); // double 13.2
					block.RatVal = query.GetFieldData(block.GetBlockName(), "RatVal", i).ParseDouble("RatVal"); // double 19.8
					block.SubstPrc = query.GetFieldData(block.GetBlockName(), "SubstPrc", i).ParseDouble("SubstPrc"); // double 13.2
					block.RegTpNm = query.GetFieldData(block.GetBlockName(), "RegTpNm", i).TrimEnd('?'); // char 20
					block.SpotMgnLevyClssNm = query.GetFieldData(block.GetBlockName(), "SpotMgnLevyClssNm", i).TrimEnd('?'); // char 40
					block.FnoTrdStopRsnCnts = query.GetFieldData(block.GetBlockName(), "FnoTrdStopRsnCnts", i).TrimEnd('?'); // char 40
					block.DgrsPtnNm = query.GetFieldData(block.GetBlockName(), "DgrsPtnNm", i).TrimEnd('?'); // char 40
					block.AcdPtnNm = query.GetFieldData(block.GetBlockName(), "AcdPtnNm", i).TrimEnd('?'); // char 40
					block.MktTpNm = query.GetFieldData(block.GetBlockName(), "MktTpNm", i).TrimEnd('?'); // char 20
					block.LmtVal = query.GetFieldData(block.GetBlockName(), "LmtVal", i).ParseLong("LmtVal"); // long 18
					block.AcntLmtVal = query.GetFieldData(block.GetBlockName(), "AcntLmtVal", i).ParseLong("AcntLmtVal"); // long 18
					block.LoanGrdCode = query.GetFieldData(block.GetBlockName(), "LoanGrdCode", i).TrimEnd('?'); // char 2
					block.LoanAmt = query.GetFieldData(block.GetBlockName(), "LoanAmt", i).ParseLong("LoanAmt"); // long 16
					block.LoanAbleRat = query.GetFieldData(block.GetBlockName(), "LoanAbleRat", i).ParseDouble("LoanAbleRat"); // double 26.9
					block.LoanIntrat1 = query.GetFieldData(block.GetBlockName(), "LoanIntrat1", i).ParseDouble("LoanIntrat1"); // double 14.4
					block.RegPsnId = query.GetFieldData(block.GetBlockName(), "RegPsnId", i).TrimEnd('?'); // char 16
					block.Rat01 = query.GetFieldData(block.GetBlockName(), "Rat01", i).ParseDouble("Rat01"); // double 19.8
					block.Rat02 = query.GetFieldData(block.GetBlockName(), "Rat02", i).ParseDouble("Rat02"); // double 19.8

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
			// Parprc double 13.2
			// PrdayCprc double 13.2
			// RatVal double 19.8
			// SubstPrc double 13.2
			if (RegTpNm?.Length > 20) return false; // char 20
			if (SpotMgnLevyClssNm?.Length > 40) return false; // char 40
			if (FnoTrdStopRsnCnts?.Length > 40) return false; // char 40
			if (DgrsPtnNm?.Length > 40) return false; // char 40
			if (AcdPtnNm?.Length > 40) return false; // char 40
			if (MktTpNm?.Length > 20) return false; // char 20
			if (LmtVal.ToString().Length > 18) return false; // long 18
			if (AcntLmtVal.ToString().Length > 18) return false; // long 18
			if (LoanGrdCode?.Length > 2) return false; // char 2
			if (LoanAmt.ToString().Length > 16) return false; // long 16
			// LoanAbleRat double 26.9
			// LoanIntrat1 double 14.4
			if (RegPsnId?.Length > 16) return false; // char 16
			// Rat01 double 19.8
			// Rat02 double 19.8

			return true;
		}

		public void CopyTo(XQCLNAQ00100OutBlock2 block)
		{
			block.IsuNo = this.IsuNo;
			block.IsuNm = this.IsuNm;
			block.Parprc = this.Parprc;
			block.PrdayCprc = this.PrdayCprc;
			block.RatVal = this.RatVal;
			block.SubstPrc = this.SubstPrc;
			block.RegTpNm = this.RegTpNm;
			block.SpotMgnLevyClssNm = this.SpotMgnLevyClssNm;
			block.FnoTrdStopRsnCnts = this.FnoTrdStopRsnCnts;
			block.DgrsPtnNm = this.DgrsPtnNm;
			block.AcdPtnNm = this.AcdPtnNm;
			block.MktTpNm = this.MktTpNm;
			block.LmtVal = this.LmtVal;
			block.AcntLmtVal = this.AcntLmtVal;
			block.LoanGrdCode = this.LoanGrdCode;
			block.LoanAmt = this.LoanAmt;
			block.LoanAbleRat = this.LoanAbleRat;
			block.LoanIntrat1 = this.LoanIntrat1;
			block.RegPsnId = this.RegPsnId;
			block.Rat01 = this.Rat01;
			block.Rat02 = this.Rat02;

		}
	}

	public partial class XQCLNAQ00100OutBlock3 : XingBlock
	{
		/// <summary>
		/// CLNAQ00100OutBlock3
		/// </summary>
		public const string _blockName = "CLNAQ00100OutBlock3";
		/// <summary>
		/// Sum(*EMPTY*)
		/// </summary>
		public const string _blockDesc = "Sum(*EMPTY*)";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// false
		/// </summary>
		public const bool _hasOccurs = false;
		/// <summary>
		/// CLNAQ00100OutBlock3
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CLNAQ00100OutBlock3
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// Sum(*EMPTY*)
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
		/// 대출금합계금액
		/// </summary>
		[XAQueryFieldAttribute("LrgMnyoutSumAmt", "대출금합계금액", "long", "16")]
		public long LrgMnyoutSumAmt;

		public static class F
		{
			/// <summary>
			/// 레코드갯수
			/// </summary>
			public const string RecCnt = "RecCnt";
			/// <summary>
			/// 대출금합계금액
			/// </summary>
			public const string LrgMnyoutSumAmt = "LrgMnyoutSumAmt";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.LrgMnyoutSumAmt,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["LrgMnyoutSumAmt"] = new XAQueryFieldInfo("long", LrgMnyoutSumAmt, LrgMnyoutSumAmt.ToString("d16"), "대출금합계금액", (decimal)16);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "RecCnt":
					this.RecCnt = fieldInfo.FieldValue.ParseLong("RecCnt");
				break;

				case "LrgMnyoutSumAmt":
					this.LrgMnyoutSumAmt = fieldInfo.FieldValue.ParseLong("LrgMnyoutSumAmt");
				break;


			}
		}

		public static XQCLNAQ00100OutBlock3 FromQuery(XQCLNAQ00100 query)
		{
			XQCLNAQ00100OutBlock3 block = new XQCLNAQ00100OutBlock3();
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
				block.LrgMnyoutSumAmt = query.GetFieldData(block.GetBlockName(), "LrgMnyoutSumAmt", 0).ParseLong("LrgMnyoutSumAmt"); // long 16

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (RecCnt.ToString().Length > 5) return false; // long 5
			if (LrgMnyoutSumAmt.ToString().Length > 16) return false; // long 16

			return true;
		}

		public void CopyTo(XQCLNAQ00100OutBlock3 block)
		{
			block.RecCnt = this.RecCnt;
			block.LrgMnyoutSumAmt = this.LrgMnyoutSumAmt;

		}
	}

	/// <summary>
	/// 예탁담보융자가능종목현황조회
	/// </summary>
	public partial class XQCLNAQ00100 : XingQuery
	{
		/// <summary>
		/// CLNAQ00100
		/// </summary>
		public const string _typeName = "CLNAQ00100";
		/// <summary>
		/// 예탁담보융자가능종목현황조회
		/// </summary>
		public const string _typeDesc = "예탁담보융자가능종목현황조회";
		/// <summary>
		/// CLNAQ00100
		/// </summary>
		public const string _service = "CLNAQ00100";
		/// <summary>
		/// B
		/// </summary>
		public const string _headType = "B";
		/// <summary>
		/// 이성호
		/// </summary>
		public const string _creator = "이성호";
		/// <summary>
		/// 2012/01/10 15:45:49
		/// </summary>
		public const string _createdDate = "2012/01/10 15:45:49";
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
		/// CLNAQ00100
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 예탁담보융자가능종목현황조회
		/// </summary>
		public string TypeDesc => _typeDesc;
		/// <summary>
		/// CLNAQ00100
		/// </summary>
		public string Service => _service;
		/// <summary>
		/// B
		/// </summary>
		public string HeadType => _headType;
		/// <summary>
		/// 이성호
		/// </summary>
		public string Creator => _creator;
		/// <summary>
		/// 2012/01/10 15:45:49
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
		/// 예탁담보융자가능종목현황조회
		/// </summary>
		public XQCLNAQ00100() : base("CLNAQ00100") { }




		public bool SetBlock(XQCLNAQ00100InBlock1 block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "RecCnt", 0, block.RecCnt.ToString("d5")); // long 5
			_xaQuery.SetFieldData(block.GetBlockName(), "QryTp", 0, block.QryTp.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "IsuNo", 0, block.IsuNo); // char 12
			_xaQuery.SetFieldData(block.GetBlockName(), "SecTpCode", 0, block.SecTpCode.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "LoanIntrstGrdCode", 0, block.LoanIntrstGrdCode); // char 2
			_xaQuery.SetFieldData(block.GetBlockName(), "LoanTp", 0, block.LoanTp.ToString()); // char 1

			return true;
		}

		public XQCLNAQ00100OutBlock1 GetBlock1()
		{
			XQCLNAQ00100OutBlock1 instance = XQCLNAQ00100OutBlock1.FromQuery(this);
			return instance;

		}

		public XQCLNAQ00100OutBlock2[] GetBlock2s()
		{
			XQCLNAQ00100OutBlock2[] instance = XQCLNAQ00100OutBlock2.ListFromQuery(this);
			return instance;

		}

		public XQCLNAQ00100OutBlock3 GetBlock3()
		{
			XQCLNAQ00100OutBlock3 instance = XQCLNAQ00100OutBlock3.FromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQCLNAQ00100OutBlock1),
			typeof(XQCLNAQ00100OutBlock2),
			typeof(XQCLNAQ00100OutBlock3),

		};

	}

}
