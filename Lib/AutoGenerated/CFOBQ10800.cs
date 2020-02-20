using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQCFOBQ10800InBlock1 : XingBlock
	{
		/// <summary>
		/// CFOBQ10800InBlock1
		/// </summary>
		public const string _blockName = "CFOBQ10800InBlock1";
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
		/// CFOBQ10800InBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CFOBQ10800InBlock1
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
		/// 상품군코드
		/// </summary>
		[XAQueryFieldAttribute("PrdgrpClssCode", "상품군코드", "char", "2")]
		public string PrdgrpClssCode;
		/// <summary>
		/// 기초자산코드
		/// </summary>
		[XAQueryFieldAttribute("ClssGrpCode", "기초자산코드", "char", "3")]
		public string ClssGrpCode;
		/// <summary>
		/// 기준연도
		/// </summary>
		[XAQueryFieldAttribute("BaseYear", "기준연도", "char", "4")]
		public string BaseYear;
		/// <summary>
		/// 최근월물구분
		/// </summary>
		[XAQueryFieldAttribute("FstmmTpCode", "최근월물구분", "char", "1")]
		public char FstmmTpCode;

		public static class F
		{
			/// <summary>
			/// 레코드갯수
			/// </summary>
			public const string RecCnt = "RecCnt";
			/// <summary>
			/// 상품군코드
			/// </summary>
			public const string PrdgrpClssCode = "PrdgrpClssCode";
			/// <summary>
			/// 기초자산코드
			/// </summary>
			public const string ClssGrpCode = "ClssGrpCode";
			/// <summary>
			/// 기준연도
			/// </summary>
			public const string BaseYear = "BaseYear";
			/// <summary>
			/// 최근월물구분
			/// </summary>
			public const string FstmmTpCode = "FstmmTpCode";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.PrdgrpClssCode,
			F.ClssGrpCode,
			F.BaseYear,
			F.FstmmTpCode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["PrdgrpClssCode"] = new XAQueryFieldInfo("char", PrdgrpClssCode, PrdgrpClssCode, "상품군코드", (decimal)2);
			dict["ClssGrpCode"] = new XAQueryFieldInfo("char", ClssGrpCode, ClssGrpCode, "기초자산코드", (decimal)3);
			dict["BaseYear"] = new XAQueryFieldInfo("char", BaseYear, BaseYear, "기준연도", (decimal)4);
			dict["FstmmTpCode"] = new XAQueryFieldInfo("char", FstmmTpCode, FstmmTpCode.ToString(), "최근월물구분", (decimal)1);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "RecCnt":
					this.RecCnt = fieldInfo.FieldValue.ParseLong("RecCnt");
				break;

				case "PrdgrpClssCode":
					this.PrdgrpClssCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ClssGrpCode":
					this.ClssGrpCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "BaseYear":
					this.BaseYear = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "FstmmTpCode":
					this.FstmmTpCode = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public bool VerifyData()
		{
			if (RecCnt.ToString().Length > 5) return false; // long 5
			if (PrdgrpClssCode?.Length > 2) return false; // char 2
			if (ClssGrpCode?.Length > 3) return false; // char 3
			if (BaseYear?.Length > 4) return false; // char 4
			// FstmmTpCode char 1

			return true;
		}
	}

	public partial class XQCFOBQ10800OutBlock1 : XingBlock
	{
		/// <summary>
		/// CFOBQ10800OutBlock1
		/// </summary>
		public const string _blockName = "CFOBQ10800OutBlock1";
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
		/// CFOBQ10800OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CFOBQ10800OutBlock1
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
		/// 상품군코드
		/// </summary>
		[XAQueryFieldAttribute("PrdgrpClssCode", "상품군코드", "char", "2")]
		public string PrdgrpClssCode;
		/// <summary>
		/// 기초자산코드
		/// </summary>
		[XAQueryFieldAttribute("ClssGrpCode", "기초자산코드", "char", "3")]
		public string ClssGrpCode;
		/// <summary>
		/// 기준연도
		/// </summary>
		[XAQueryFieldAttribute("BaseYear", "기준연도", "char", "4")]
		public string BaseYear;
		/// <summary>
		/// 최근월물구분
		/// </summary>
		[XAQueryFieldAttribute("FstmmTpCode", "최근월물구분", "char", "1")]
		public char FstmmTpCode;

		public static class F
		{
			/// <summary>
			/// 레코드갯수
			/// </summary>
			public const string RecCnt = "RecCnt";
			/// <summary>
			/// 상품군코드
			/// </summary>
			public const string PrdgrpClssCode = "PrdgrpClssCode";
			/// <summary>
			/// 기초자산코드
			/// </summary>
			public const string ClssGrpCode = "ClssGrpCode";
			/// <summary>
			/// 기준연도
			/// </summary>
			public const string BaseYear = "BaseYear";
			/// <summary>
			/// 최근월물구분
			/// </summary>
			public const string FstmmTpCode = "FstmmTpCode";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.PrdgrpClssCode,
			F.ClssGrpCode,
			F.BaseYear,
			F.FstmmTpCode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["PrdgrpClssCode"] = new XAQueryFieldInfo("char", PrdgrpClssCode, PrdgrpClssCode, "상품군코드", (decimal)2);
			dict["ClssGrpCode"] = new XAQueryFieldInfo("char", ClssGrpCode, ClssGrpCode, "기초자산코드", (decimal)3);
			dict["BaseYear"] = new XAQueryFieldInfo("char", BaseYear, BaseYear, "기준연도", (decimal)4);
			dict["FstmmTpCode"] = new XAQueryFieldInfo("char", FstmmTpCode, FstmmTpCode.ToString(), "최근월물구분", (decimal)1);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "RecCnt":
					this.RecCnt = fieldInfo.FieldValue.ParseLong("RecCnt");
				break;

				case "PrdgrpClssCode":
					this.PrdgrpClssCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ClssGrpCode":
					this.ClssGrpCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "BaseYear":
					this.BaseYear = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "FstmmTpCode":
					this.FstmmTpCode = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public static XQCFOBQ10800OutBlock1 FromQuery(XQCFOBQ10800 query)
		{
			XQCFOBQ10800OutBlock1 block = new XQCFOBQ10800OutBlock1();
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
				block.PrdgrpClssCode = query.GetFieldData(block.GetBlockName(), "PrdgrpClssCode", 0).TrimEnd('?'); // char 2
				block.ClssGrpCode = query.GetFieldData(block.GetBlockName(), "ClssGrpCode", 0).TrimEnd('?'); // char 3
				block.BaseYear = query.GetFieldData(block.GetBlockName(), "BaseYear", 0).TrimEnd('?'); // char 4
				block.FstmmTpCode = query.GetFieldData(block.GetBlockName(), "FstmmTpCode", 0).FirstOrDefault(); // char 1

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (RecCnt.ToString().Length > 5) return false; // long 5
			if (PrdgrpClssCode?.Length > 2) return false; // char 2
			if (ClssGrpCode?.Length > 3) return false; // char 3
			if (BaseYear?.Length > 4) return false; // char 4
			// FstmmTpCode char 1

			return true;
		}
	}

	public partial class XQCFOBQ10800OutBlock2 : XingBlock
	{
		/// <summary>
		/// CFOBQ10800OutBlock2
		/// </summary>
		public const string _blockName = "CFOBQ10800OutBlock2";
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
		/// CFOBQ10800OutBlock2
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CFOBQ10800OutBlock2
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
		/// 행사가
		/// </summary>
		[XAQueryFieldAttribute("ElwXrcPrc", "행사가", "double", "13.2")]
		public double ElwXrcPrc;
		/// <summary>
		/// 선물옵션종목번호
		/// </summary>
		[XAQueryFieldAttribute("FnoIsuNo", "선물옵션종목번호", "char", "12")]
		public string FnoIsuNo;
		/// <summary>
		/// 한글종목명1
		/// </summary>
		[XAQueryFieldAttribute("HanglIsuNm1", "한글종목명1", "char", "40")]
		public string HanglIsuNm1;
		/// <summary>
		/// 구분명1
		/// </summary>
		[XAQueryFieldAttribute("TpNm1", "구분명1", "char", "40")]
		public string TpNm1;
		/// <summary>
		/// 상승옵션조정이론가
		/// </summary>
		[XAQueryFieldAttribute("UpOptRegulThrprc", "상승옵션조정이론가", "double", "27.8")]
		public double UpOptRegulThrprc;
		/// <summary>
		/// 이론가1
		/// </summary>
		[XAQueryFieldAttribute("Thrprc1", "이론가1", "double", "19.8")]
		public double Thrprc1;
		/// <summary>
		/// 기준가1
		/// </summary>
		[XAQueryFieldAttribute("BasePrc1", "기준가1", "double", "13.2")]
		public double BasePrc1;
		/// <summary>
		/// 주문증거금액1
		/// </summary>
		[XAQueryFieldAttribute("OrdMgn1", "주문증거금액1", "long", "16")]
		public long OrdMgn1;
		/// <summary>
		/// 선물옵션종목번호0
		/// </summary>
		[XAQueryFieldAttribute("FnoIsuNo0", "선물옵션종목번호0", "char", "12")]
		public string FnoIsuNo0;
		/// <summary>
		/// 한글종목명2
		/// </summary>
		[XAQueryFieldAttribute("HanglIsuNm2", "한글종목명2", "char", "40")]
		public string HanglIsuNm2;
		/// <summary>
		/// 구분명2
		/// </summary>
		[XAQueryFieldAttribute("TpNm2", "구분명2", "char", "40")]
		public string TpNm2;
		/// <summary>
		/// 하락옵션조정이론가
		/// </summary>
		[XAQueryFieldAttribute("DownOptRegulThrprc", "하락옵션조정이론가", "double", "27.8")]
		public double DownOptRegulThrprc;
		/// <summary>
		/// 이론가2
		/// </summary>
		[XAQueryFieldAttribute("Thrprc2", "이론가2", "double", "19.8")]
		public double Thrprc2;
		/// <summary>
		/// 기준가2
		/// </summary>
		[XAQueryFieldAttribute("BasePrc2", "기준가2", "double", "13.2")]
		public double BasePrc2;
		/// <summary>
		/// 주문증거금액2
		/// </summary>
		[XAQueryFieldAttribute("OrdMgn2", "주문증거금액2", "long", "16")]
		public long OrdMgn2;

		public static class F
		{
			/// <summary>
			/// 행사가
			/// </summary>
			public const string ElwXrcPrc = "ElwXrcPrc";
			/// <summary>
			/// 선물옵션종목번호
			/// </summary>
			public const string FnoIsuNo = "FnoIsuNo";
			/// <summary>
			/// 한글종목명1
			/// </summary>
			public const string HanglIsuNm1 = "HanglIsuNm1";
			/// <summary>
			/// 구분명1
			/// </summary>
			public const string TpNm1 = "TpNm1";
			/// <summary>
			/// 상승옵션조정이론가
			/// </summary>
			public const string UpOptRegulThrprc = "UpOptRegulThrprc";
			/// <summary>
			/// 이론가1
			/// </summary>
			public const string Thrprc1 = "Thrprc1";
			/// <summary>
			/// 기준가1
			/// </summary>
			public const string BasePrc1 = "BasePrc1";
			/// <summary>
			/// 주문증거금액1
			/// </summary>
			public const string OrdMgn1 = "OrdMgn1";
			/// <summary>
			/// 선물옵션종목번호0
			/// </summary>
			public const string FnoIsuNo0 = "FnoIsuNo0";
			/// <summary>
			/// 한글종목명2
			/// </summary>
			public const string HanglIsuNm2 = "HanglIsuNm2";
			/// <summary>
			/// 구분명2
			/// </summary>
			public const string TpNm2 = "TpNm2";
			/// <summary>
			/// 하락옵션조정이론가
			/// </summary>
			public const string DownOptRegulThrprc = "DownOptRegulThrprc";
			/// <summary>
			/// 이론가2
			/// </summary>
			public const string Thrprc2 = "Thrprc2";
			/// <summary>
			/// 기준가2
			/// </summary>
			public const string BasePrc2 = "BasePrc2";
			/// <summary>
			/// 주문증거금액2
			/// </summary>
			public const string OrdMgn2 = "OrdMgn2";
		}

		public static string[] AllFields = new string[]
		{
			F.ElwXrcPrc,
			F.FnoIsuNo,
			F.HanglIsuNm1,
			F.TpNm1,
			F.UpOptRegulThrprc,
			F.Thrprc1,
			F.BasePrc1,
			F.OrdMgn1,
			F.FnoIsuNo0,
			F.HanglIsuNm2,
			F.TpNm2,
			F.DownOptRegulThrprc,
			F.Thrprc2,
			F.BasePrc2,
			F.OrdMgn2,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["ElwXrcPrc"] = new XAQueryFieldInfo("double", ElwXrcPrc, ElwXrcPrc.ToString("0000000000000.00"), "행사가", (decimal)13.2);
			dict["FnoIsuNo"] = new XAQueryFieldInfo("char", FnoIsuNo, FnoIsuNo, "선물옵션종목번호", (decimal)12);
			dict["HanglIsuNm1"] = new XAQueryFieldInfo("char", HanglIsuNm1, HanglIsuNm1, "한글종목명1", (decimal)40);
			dict["TpNm1"] = new XAQueryFieldInfo("char", TpNm1, TpNm1, "구분명1", (decimal)40);
			dict["UpOptRegulThrprc"] = new XAQueryFieldInfo("double", UpOptRegulThrprc, UpOptRegulThrprc.ToString("000000000000000000000000000.00000000"), "상승옵션조정이론가", (decimal)27.8);
			dict["Thrprc1"] = new XAQueryFieldInfo("double", Thrprc1, Thrprc1.ToString("0000000000000000000.00000000"), "이론가1", (decimal)19.8);
			dict["BasePrc1"] = new XAQueryFieldInfo("double", BasePrc1, BasePrc1.ToString("0000000000000.00"), "기준가1", (decimal)13.2);
			dict["OrdMgn1"] = new XAQueryFieldInfo("long", OrdMgn1, OrdMgn1.ToString("d16"), "주문증거금액1", (decimal)16);
			dict["FnoIsuNo0"] = new XAQueryFieldInfo("char", FnoIsuNo0, FnoIsuNo0, "선물옵션종목번호0", (decimal)12);
			dict["HanglIsuNm2"] = new XAQueryFieldInfo("char", HanglIsuNm2, HanglIsuNm2, "한글종목명2", (decimal)40);
			dict["TpNm2"] = new XAQueryFieldInfo("char", TpNm2, TpNm2, "구분명2", (decimal)40);
			dict["DownOptRegulThrprc"] = new XAQueryFieldInfo("double", DownOptRegulThrprc, DownOptRegulThrprc.ToString("000000000000000000000000000.00000000"), "하락옵션조정이론가", (decimal)27.8);
			dict["Thrprc2"] = new XAQueryFieldInfo("double", Thrprc2, Thrprc2.ToString("0000000000000000000.00000000"), "이론가2", (decimal)19.8);
			dict["BasePrc2"] = new XAQueryFieldInfo("double", BasePrc2, BasePrc2.ToString("0000000000000.00"), "기준가2", (decimal)13.2);
			dict["OrdMgn2"] = new XAQueryFieldInfo("long", OrdMgn2, OrdMgn2.ToString("d16"), "주문증거금액2", (decimal)16);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "ElwXrcPrc":
					this.ElwXrcPrc = fieldInfo.FieldValue.ParseDouble("ElwXrcPrc");
				break;

				case "FnoIsuNo":
					this.FnoIsuNo = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "HanglIsuNm1":
					this.HanglIsuNm1 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "TpNm1":
					this.TpNm1 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "UpOptRegulThrprc":
					this.UpOptRegulThrprc = fieldInfo.FieldValue.ParseDouble("UpOptRegulThrprc");
				break;

				case "Thrprc1":
					this.Thrprc1 = fieldInfo.FieldValue.ParseDouble("Thrprc1");
				break;

				case "BasePrc1":
					this.BasePrc1 = fieldInfo.FieldValue.ParseDouble("BasePrc1");
				break;

				case "OrdMgn1":
					this.OrdMgn1 = fieldInfo.FieldValue.ParseLong("OrdMgn1");
				break;

				case "FnoIsuNo0":
					this.FnoIsuNo0 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "HanglIsuNm2":
					this.HanglIsuNm2 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "TpNm2":
					this.TpNm2 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "DownOptRegulThrprc":
					this.DownOptRegulThrprc = fieldInfo.FieldValue.ParseDouble("DownOptRegulThrprc");
				break;

				case "Thrprc2":
					this.Thrprc2 = fieldInfo.FieldValue.ParseDouble("Thrprc2");
				break;

				case "BasePrc2":
					this.BasePrc2 = fieldInfo.FieldValue.ParseDouble("BasePrc2");
				break;

				case "OrdMgn2":
					this.OrdMgn2 = fieldInfo.FieldValue.ParseLong("OrdMgn2");
				break;


			}
		}

		public static XQCFOBQ10800OutBlock2[] ListFromQuery(XQCFOBQ10800 query)
		{
			int count = query.GetBlockCount(XQCFOBQ10800OutBlock2.BlockName);
			List<XQCFOBQ10800OutBlock2> list = new List<XQCFOBQ10800OutBlock2>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQCFOBQ10800OutBlock2 block = new XQCFOBQ10800OutBlock2();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.ElwXrcPrc = query.GetFieldData(block.GetBlockName(), "ElwXrcPrc", i).ParseDouble("ElwXrcPrc"); // double 13.2
					block.FnoIsuNo = query.GetFieldData(block.GetBlockName(), "FnoIsuNo", i).TrimEnd('?'); // char 12
					block.HanglIsuNm1 = query.GetFieldData(block.GetBlockName(), "HanglIsuNm1", i).TrimEnd('?'); // char 40
					block.TpNm1 = query.GetFieldData(block.GetBlockName(), "TpNm1", i).TrimEnd('?'); // char 40
					block.UpOptRegulThrprc = query.GetFieldData(block.GetBlockName(), "UpOptRegulThrprc", i).ParseDouble("UpOptRegulThrprc"); // double 27.8
					block.Thrprc1 = query.GetFieldData(block.GetBlockName(), "Thrprc1", i).ParseDouble("Thrprc1"); // double 19.8
					block.BasePrc1 = query.GetFieldData(block.GetBlockName(), "BasePrc1", i).ParseDouble("BasePrc1"); // double 13.2
					block.OrdMgn1 = query.GetFieldData(block.GetBlockName(), "OrdMgn1", i).ParseLong("OrdMgn1"); // long 16
					block.FnoIsuNo0 = query.GetFieldData(block.GetBlockName(), "FnoIsuNo0", i).TrimEnd('?'); // char 12
					block.HanglIsuNm2 = query.GetFieldData(block.GetBlockName(), "HanglIsuNm2", i).TrimEnd('?'); // char 40
					block.TpNm2 = query.GetFieldData(block.GetBlockName(), "TpNm2", i).TrimEnd('?'); // char 40
					block.DownOptRegulThrprc = query.GetFieldData(block.GetBlockName(), "DownOptRegulThrprc", i).ParseDouble("DownOptRegulThrprc"); // double 27.8
					block.Thrprc2 = query.GetFieldData(block.GetBlockName(), "Thrprc2", i).ParseDouble("Thrprc2"); // double 19.8
					block.BasePrc2 = query.GetFieldData(block.GetBlockName(), "BasePrc2", i).ParseDouble("BasePrc2"); // double 13.2
					block.OrdMgn2 = query.GetFieldData(block.GetBlockName(), "OrdMgn2", i).ParseLong("OrdMgn2"); // long 16

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
			// ElwXrcPrc double 13.2
			if (FnoIsuNo?.Length > 12) return false; // char 12
			if (HanglIsuNm1?.Length > 40) return false; // char 40
			if (TpNm1?.Length > 40) return false; // char 40
			// UpOptRegulThrprc double 27.8
			// Thrprc1 double 19.8
			// BasePrc1 double 13.2
			if (OrdMgn1.ToString().Length > 16) return false; // long 16
			if (FnoIsuNo0?.Length > 12) return false; // char 12
			if (HanglIsuNm2?.Length > 40) return false; // char 40
			if (TpNm2?.Length > 40) return false; // char 40
			// DownOptRegulThrprc double 27.8
			// Thrprc2 double 19.8
			// BasePrc2 double 13.2
			if (OrdMgn2.ToString().Length > 16) return false; // long 16

			return true;
		}
	}

	/// <summary>
	/// 선물옵션 옵션매도시 주문증거금조회
	/// </summary>
	public partial class XQCFOBQ10800 : XingQuery
	{
		/// <summary>
		/// CFOBQ10800
		/// </summary>
		public const string _typeName = "CFOBQ10800";
		/// <summary>
		/// 선물옵션 옵션매도시 주문증거금조회
		/// </summary>
		public const string _typeDesc = "선물옵션 옵션매도시 주문증거금조회";
		/// <summary>
		/// CFOBQ10800
		/// </summary>
		public const string _service = "CFOBQ10800";
		/// <summary>
		/// B
		/// </summary>
		public const string _headType = "B";
		/// <summary>
		/// 원종혁
		/// </summary>
		public const string _creator = "원종혁";
		/// <summary>
		/// 2019/08/01 10:51:29
		/// </summary>
		public const string _createdDate = "2019/08/01 10:51:29";
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
		/// CFOBQ10800
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 선물옵션 옵션매도시 주문증거금조회
		/// </summary>
		public string TypeDesc => _typeDesc;
		/// <summary>
		/// CFOBQ10800
		/// </summary>
		public string Service => _service;
		/// <summary>
		/// B
		/// </summary>
		public string HeadType => _headType;
		/// <summary>
		/// 원종혁
		/// </summary>
		public string Creator => _creator;
		/// <summary>
		/// 2019/08/01 10:51:29
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
		/// 선물옵션 옵션매도시 주문증거금조회
		/// </summary>
		public XQCFOBQ10800() : base("CFOBQ10800") { }


		public class XQAllOutBlocks
		{
			public XQCFOBQ10800OutBlock1 OutBlock1 { get; internal set; }
			public XQCFOBQ10800OutBlock2[] OutBlock2 { get; internal set; }
		}

		public static XQAllOutBlocks Get(long RecCnt = default,string PrdgrpClssCode = default,string ClssGrpCode = default,string BaseYear = default,char FstmmTpCode = default)
		{
			using (XQCFOBQ10800 instance = new XQCFOBQ10800())
			{
				instance.SetFieldData(XQCFOBQ10800InBlock1.BlockName, XQCFOBQ10800InBlock1.F.RecCnt, 0, RecCnt.ToString("d5")); // long 5
				instance.SetFieldData(XQCFOBQ10800InBlock1.BlockName, XQCFOBQ10800InBlock1.F.PrdgrpClssCode, 0, PrdgrpClssCode); // char 2
				instance.SetFieldData(XQCFOBQ10800InBlock1.BlockName, XQCFOBQ10800InBlock1.F.ClssGrpCode, 0, ClssGrpCode); // char 3
				instance.SetFieldData(XQCFOBQ10800InBlock1.BlockName, XQCFOBQ10800InBlock1.F.BaseYear, 0, BaseYear); // char 4
				instance.SetFieldData(XQCFOBQ10800InBlock1.BlockName, XQCFOBQ10800InBlock1.F.FstmmTpCode, 0, FstmmTpCode.ToString()); // char 1

				if (instance.Request() < 0)
				{
					return null;
				}

				XQAllOutBlocks results = new XQAllOutBlocks();
				results.OutBlock1 = instance.GetBlock1();
				if (results.OutBlock1.IsValidData == false)
				{
					return null;
				}

				results.OutBlock2 = instance.GetBlock2s();
				return results;
			}
		}

		public static XQAllOutBlocks ReadFromDB(string tableNamePostfix = null /*, long RecCnt = default,string PrdgrpClssCode = default,string ClssGrpCode = default,string BaseYear = default,char FstmmTpCode = default */)
		{
			using (XQCFOBQ10800 instance = new XQCFOBQ10800())
			{

				XQAllOutBlocks results = new XQAllOutBlocks();

				string tableName = (tableNamePostfix == null) ? "XQCFOBQ10800OutBlock1" : $"XQCFOBQ10800OutBlock1_{tableNamePostfix}";
				QueryOption qo = new QueryOption(tableName);
				results.OutBlock1 = instance.Select<XQCFOBQ10800OutBlock1>(qo);

				tableName = (tableNamePostfix == null) ? "XQCFOBQ10800OutBlock2" : $"XQCFOBQ10800OutBlock2_{tableNamePostfix}";
				qo = new QueryOption(tableName);
				results.OutBlock2 = instance.SelectMany<XQCFOBQ10800OutBlock2>(qo);
				return results;
			}
		}

		public bool SetBlock(XQCFOBQ10800InBlock1 block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "RecCnt", 0, block.RecCnt.ToString("d5")); // long 5
			_xaQuery.SetFieldData(block.GetBlockName(), "PrdgrpClssCode", 0, block.PrdgrpClssCode); // char 2
			_xaQuery.SetFieldData(block.GetBlockName(), "ClssGrpCode", 0, block.ClssGrpCode); // char 3
			_xaQuery.SetFieldData(block.GetBlockName(), "BaseYear", 0, block.BaseYear); // char 4
			_xaQuery.SetFieldData(block.GetBlockName(), "FstmmTpCode", 0, block.FstmmTpCode.ToString()); // char 1

			return true;
		}

		public XQCFOBQ10800OutBlock1 GetBlock1()
		{
			XQCFOBQ10800OutBlock1 instance = XQCFOBQ10800OutBlock1.FromQuery(this);
			return instance;

		}

		public XQCFOBQ10800OutBlock2[] GetBlock2s()
		{
			XQCFOBQ10800OutBlock2[] instance = XQCFOBQ10800OutBlock2.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQCFOBQ10800OutBlock1),
			typeof(XQCFOBQ10800OutBlock2),

		};

	}

}
