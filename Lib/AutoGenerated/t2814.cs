using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt2814InBlock : XingBlock
	{
		/// <summary>
		/// t2814InBlock
		/// </summary>
		public const string _blockName = "t2814InBlock";
		/// <summary>
		/// 기본입력
		/// </summary>
		public const string _blockDesc = "기본입력";
		/// <summary>
		/// input
		/// </summary>
		public const string _blockType = "input";
		/// <summary>
		/// false
		/// </summary>
		public const bool _hasOccurs = false;
		/// <summary>
		/// t2814InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t2814InBlock
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// 기본입력
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
		/// 수치구분(1:수치2:누적)
		/// </summary>
		[XAQueryFieldAttribute("수치구분(1:수치2:누적)")]
		public char gubun1;
		/// <summary>
		/// 단위구분(1:일2:주3:월)
		/// </summary>
		[XAQueryFieldAttribute("단위구분(1:일2:주3:월)")]
		public char gubun2;
		/// <summary>
		/// 시작날짜
		/// </summary>
		[XAQueryFieldAttribute("시작날짜")]
		public string from_date;
		/// <summary>
		/// 종료날짜
		/// </summary>
		[XAQueryFieldAttribute("종료날짜")]
		public string to_date;

		public static class F
		{
			/// <summary>
			/// 수치구분(1:수치2:누적)
			/// </summary>
			public const string gubun1 = "gubun1";
			/// <summary>
			/// 단위구분(1:일2:주3:월)
			/// </summary>
			public const string gubun2 = "gubun2";
			/// <summary>
			/// 시작날짜
			/// </summary>
			public const string from_date = "from_date";
			/// <summary>
			/// 종료날짜
			/// </summary>
			public const string to_date = "to_date";
		}

		public static string[] AllFields = new string[]
		{
			F.gubun1,
			F.gubun2,
			F.from_date,
			F.to_date,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["gubun1"] = new XAQueryFieldInfo("char", gubun1, gubun1.ToString(), "수치구분(1:수치2:누적)", (decimal)1);
			dict["gubun2"] = new XAQueryFieldInfo("char", gubun2, gubun2.ToString(), "단위구분(1:일2:주3:월)", (decimal)1);
			dict["from_date"] = new XAQueryFieldInfo("char", from_date, from_date, "시작날짜", (decimal)8);
			dict["to_date"] = new XAQueryFieldInfo("char", to_date, to_date, "종료날짜", (decimal)8);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "gubun1":
					this.gubun1 = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "gubun2":
					this.gubun2 = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "from_date":
					this.from_date = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "to_date":
					this.to_date = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			// gubun1 char 1
			// gubun2 char 1
			if (from_date?.Length > 8) return false; // char 8
			if (to_date?.Length > 8) return false; // char 8

			return true;
		}
	}

	public partial class XQt2814OutBlock : XingBlock
	{
		/// <summary>
		/// t2814OutBlock
		/// </summary>
		public const string _blockName = "t2814OutBlock";
		/// <summary>
		/// 기본출력
		/// </summary>
		public const string _blockDesc = "기본출력";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// false
		/// </summary>
		public const bool _hasOccurs = false;
		/// <summary>
		/// t2814OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t2814OutBlock
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// 기본출력
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
		/// 시장코드
		/// </summary>
		[XAQueryFieldAttribute("시장코드")]
		public string mcode;
		/// <summary>
		/// 시장명
		/// </summary>
		[XAQueryFieldAttribute("시장명")]
		public string mname;

		public static class F
		{
			/// <summary>
			/// 시장코드
			/// </summary>
			public const string mcode = "mcode";
			/// <summary>
			/// 시장명
			/// </summary>
			public const string mname = "mname";
		}

		public static string[] AllFields = new string[]
		{
			F.mcode,
			F.mname,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["mcode"] = new XAQueryFieldInfo("char", mcode, mcode, "시장코드", (decimal)8);
			dict["mname"] = new XAQueryFieldInfo("char", mname, mname, "시장명", (decimal)20);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "mcode":
					this.mcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "mname":
					this.mname = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt2814OutBlock FromQuery(XQt2814 query)
		{
			XQt2814OutBlock block = new XQt2814OutBlock();
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
				block.mcode = query.GetFieldData(block.GetBlockName(), "mcode", 0).TrimEnd('?'); // char 8
				block.mname = query.GetFieldData(block.GetBlockName(), "mname", 0).TrimEnd('?'); // char 20

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (mcode?.Length > 8) return false; // char 8
			if (mname?.Length > 20) return false; // char 20

			return true;
		}
	}

	public partial class XQt2814OutBlock1 : XingBlock
	{
		/// <summary>
		/// t2814OutBlock1
		/// </summary>
		public const string _blockName = "t2814OutBlock1";
		/// <summary>
		/// 출력1
		/// </summary>
		public const string _blockDesc = "출력1";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// true
		/// </summary>
		public const bool _hasOccurs = true;
		/// <summary>
		/// t2814OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t2814OutBlock1
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// 출력1
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
		/// 일자
		/// </summary>
		[XAQueryFieldAttribute("일자")]
		public string date;
		/// <summary>
		/// 개인수량
		/// </summary>
		[XAQueryFieldAttribute("개인수량")]
		public long sv_08;
		/// <summary>
		/// 외인계수량(등록+미등록)
		/// </summary>
		[XAQueryFieldAttribute("외인계수량(등록+미등록)")]
		public long sv_17;
		/// <summary>
		/// 기관계수량
		/// </summary>
		[XAQueryFieldAttribute("기관계수량")]
		public long sv_18;
		/// <summary>
		/// 증권수량
		/// </summary>
		[XAQueryFieldAttribute("증권수량")]
		public long sv_01;
		/// <summary>
		/// 투신수량
		/// </summary>
		[XAQueryFieldAttribute("투신수량")]
		public long sv_03;
		/// <summary>
		/// 은행수량
		/// </summary>
		[XAQueryFieldAttribute("은행수량")]
		public long sv_04;
		/// <summary>
		/// 보험수량
		/// </summary>
		[XAQueryFieldAttribute("보험수량")]
		public long sv_02;
		/// <summary>
		/// 종금수량
		/// </summary>
		[XAQueryFieldAttribute("종금수량")]
		public long sv_05;
		/// <summary>
		/// 기금수량
		/// </summary>
		[XAQueryFieldAttribute("기금수량")]
		public long sv_06;
		/// <summary>
		/// 기타수량
		/// </summary>
		[XAQueryFieldAttribute("기타수량")]
		public long sv_07;
		/// <summary>
		/// 사모펀드수량
		/// </summary>
		[XAQueryFieldAttribute("사모펀드수량")]
		public long sv_00;
		/// <summary>
		/// 등록외국인수량
		/// </summary>
		[XAQueryFieldAttribute("등록외국인수량")]
		public long sv_09;
		/// <summary>
		/// 미등록외국인수량
		/// </summary>
		[XAQueryFieldAttribute("미등록외국인수량")]
		public long sv_10;
		/// <summary>
		/// 국가수량
		/// </summary>
		[XAQueryFieldAttribute("국가수량")]
		public long sv_11;
		/// <summary>
		/// 기타계수량(기타+국가)
		/// </summary>
		[XAQueryFieldAttribute("기타계수량(기타+국가)")]
		public long sv_99;
		/// <summary>
		/// 개인금액
		/// </summary>
		[XAQueryFieldAttribute("개인금액")]
		public double sa_08;
		/// <summary>
		/// 외인계금액(등록+미등록)
		/// </summary>
		[XAQueryFieldAttribute("외인계금액(등록+미등록)")]
		public double sa_17;
		/// <summary>
		/// 기관계금액
		/// </summary>
		[XAQueryFieldAttribute("기관계금액")]
		public double sa_18;
		/// <summary>
		/// 증권금액
		/// </summary>
		[XAQueryFieldAttribute("증권금액")]
		public double sa_01;
		/// <summary>
		/// 투신금액
		/// </summary>
		[XAQueryFieldAttribute("투신금액")]
		public double sa_03;
		/// <summary>
		/// 은행금액
		/// </summary>
		[XAQueryFieldAttribute("은행금액")]
		public double sa_04;
		/// <summary>
		/// 보험금액
		/// </summary>
		[XAQueryFieldAttribute("보험금액")]
		public double sa_02;
		/// <summary>
		/// 종금금액
		/// </summary>
		[XAQueryFieldAttribute("종금금액")]
		public double sa_05;
		/// <summary>
		/// 기금금액
		/// </summary>
		[XAQueryFieldAttribute("기금금액")]
		public double sa_06;
		/// <summary>
		/// 기타금액
		/// </summary>
		[XAQueryFieldAttribute("기타금액")]
		public double sa_07;
		/// <summary>
		/// 사모펀드금액
		/// </summary>
		[XAQueryFieldAttribute("사모펀드금액")]
		public double sa_00;
		/// <summary>
		/// 등록외국인금액
		/// </summary>
		[XAQueryFieldAttribute("등록외국인금액")]
		public double sa_09;
		/// <summary>
		/// 미등록외국인금액
		/// </summary>
		[XAQueryFieldAttribute("미등록외국인금액")]
		public double sa_10;
		/// <summary>
		/// 국가금액
		/// </summary>
		[XAQueryFieldAttribute("국가금액")]
		public double sa_11;
		/// <summary>
		/// 기타계금액(기타+국가)
		/// </summary>
		[XAQueryFieldAttribute("기타계금액(기타+국가)")]
		public double sa_99;
		/// <summary>
		/// 시장지수
		/// </summary>
		[XAQueryFieldAttribute("시장지수")]
		public float jisu;

		public static class F
		{
			/// <summary>
			/// 일자
			/// </summary>
			public const string date = "date";
			/// <summary>
			/// 개인수량
			/// </summary>
			public const string sv_08 = "sv_08";
			/// <summary>
			/// 외인계수량(등록+미등록)
			/// </summary>
			public const string sv_17 = "sv_17";
			/// <summary>
			/// 기관계수량
			/// </summary>
			public const string sv_18 = "sv_18";
			/// <summary>
			/// 증권수량
			/// </summary>
			public const string sv_01 = "sv_01";
			/// <summary>
			/// 투신수량
			/// </summary>
			public const string sv_03 = "sv_03";
			/// <summary>
			/// 은행수량
			/// </summary>
			public const string sv_04 = "sv_04";
			/// <summary>
			/// 보험수량
			/// </summary>
			public const string sv_02 = "sv_02";
			/// <summary>
			/// 종금수량
			/// </summary>
			public const string sv_05 = "sv_05";
			/// <summary>
			/// 기금수량
			/// </summary>
			public const string sv_06 = "sv_06";
			/// <summary>
			/// 기타수량
			/// </summary>
			public const string sv_07 = "sv_07";
			/// <summary>
			/// 사모펀드수량
			/// </summary>
			public const string sv_00 = "sv_00";
			/// <summary>
			/// 등록외국인수량
			/// </summary>
			public const string sv_09 = "sv_09";
			/// <summary>
			/// 미등록외국인수량
			/// </summary>
			public const string sv_10 = "sv_10";
			/// <summary>
			/// 국가수량
			/// </summary>
			public const string sv_11 = "sv_11";
			/// <summary>
			/// 기타계수량(기타+국가)
			/// </summary>
			public const string sv_99 = "sv_99";
			/// <summary>
			/// 개인금액
			/// </summary>
			public const string sa_08 = "sa_08";
			/// <summary>
			/// 외인계금액(등록+미등록)
			/// </summary>
			public const string sa_17 = "sa_17";
			/// <summary>
			/// 기관계금액
			/// </summary>
			public const string sa_18 = "sa_18";
			/// <summary>
			/// 증권금액
			/// </summary>
			public const string sa_01 = "sa_01";
			/// <summary>
			/// 투신금액
			/// </summary>
			public const string sa_03 = "sa_03";
			/// <summary>
			/// 은행금액
			/// </summary>
			public const string sa_04 = "sa_04";
			/// <summary>
			/// 보험금액
			/// </summary>
			public const string sa_02 = "sa_02";
			/// <summary>
			/// 종금금액
			/// </summary>
			public const string sa_05 = "sa_05";
			/// <summary>
			/// 기금금액
			/// </summary>
			public const string sa_06 = "sa_06";
			/// <summary>
			/// 기타금액
			/// </summary>
			public const string sa_07 = "sa_07";
			/// <summary>
			/// 사모펀드금액
			/// </summary>
			public const string sa_00 = "sa_00";
			/// <summary>
			/// 등록외국인금액
			/// </summary>
			public const string sa_09 = "sa_09";
			/// <summary>
			/// 미등록외국인금액
			/// </summary>
			public const string sa_10 = "sa_10";
			/// <summary>
			/// 국가금액
			/// </summary>
			public const string sa_11 = "sa_11";
			/// <summary>
			/// 기타계금액(기타+국가)
			/// </summary>
			public const string sa_99 = "sa_99";
			/// <summary>
			/// 시장지수
			/// </summary>
			public const string jisu = "jisu";
		}

		public static string[] AllFields = new string[]
		{
			F.date,
			F.sv_08,
			F.sv_17,
			F.sv_18,
			F.sv_01,
			F.sv_03,
			F.sv_04,
			F.sv_02,
			F.sv_05,
			F.sv_06,
			F.sv_07,
			F.sv_00,
			F.sv_09,
			F.sv_10,
			F.sv_11,
			F.sv_99,
			F.sa_08,
			F.sa_17,
			F.sa_18,
			F.sa_01,
			F.sa_03,
			F.sa_04,
			F.sa_02,
			F.sa_05,
			F.sa_06,
			F.sa_07,
			F.sa_00,
			F.sa_09,
			F.sa_10,
			F.sa_11,
			F.sa_99,
			F.jisu,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["date"] = new XAQueryFieldInfo("char", date, date, "일자", (decimal)8);
			dict["sv_08"] = new XAQueryFieldInfo("long", sv_08, sv_08.ToString("d12"), "개인수량", (decimal)12);
			dict["sv_17"] = new XAQueryFieldInfo("long", sv_17, sv_17.ToString("d12"), "외인계수량(등록+미등록)", (decimal)12);
			dict["sv_18"] = new XAQueryFieldInfo("long", sv_18, sv_18.ToString("d12"), "기관계수량", (decimal)12);
			dict["sv_01"] = new XAQueryFieldInfo("long", sv_01, sv_01.ToString("d12"), "증권수량", (decimal)12);
			dict["sv_03"] = new XAQueryFieldInfo("long", sv_03, sv_03.ToString("d12"), "투신수량", (decimal)12);
			dict["sv_04"] = new XAQueryFieldInfo("long", sv_04, sv_04.ToString("d12"), "은행수량", (decimal)12);
			dict["sv_02"] = new XAQueryFieldInfo("long", sv_02, sv_02.ToString("d12"), "보험수량", (decimal)12);
			dict["sv_05"] = new XAQueryFieldInfo("long", sv_05, sv_05.ToString("d12"), "종금수량", (decimal)12);
			dict["sv_06"] = new XAQueryFieldInfo("long", sv_06, sv_06.ToString("d12"), "기금수량", (decimal)12);
			dict["sv_07"] = new XAQueryFieldInfo("long", sv_07, sv_07.ToString("d12"), "기타수량", (decimal)12);
			dict["sv_00"] = new XAQueryFieldInfo("long", sv_00, sv_00.ToString("d12"), "사모펀드수량", (decimal)12);
			dict["sv_09"] = new XAQueryFieldInfo("long", sv_09, sv_09.ToString("d12"), "등록외국인수량", (decimal)12);
			dict["sv_10"] = new XAQueryFieldInfo("long", sv_10, sv_10.ToString("d12"), "미등록외국인수량", (decimal)12);
			dict["sv_11"] = new XAQueryFieldInfo("long", sv_11, sv_11.ToString("d12"), "국가수량", (decimal)12);
			dict["sv_99"] = new XAQueryFieldInfo("long", sv_99, sv_99.ToString("d12"), "기타계수량(기타+국가)", (decimal)12);
			dict["sa_08"] = new XAQueryFieldInfo("double", sa_08, sa_08.ToString("000000000000."), "개인금액", (decimal)12.0);
			dict["sa_17"] = new XAQueryFieldInfo("double", sa_17, sa_17.ToString("000000000000."), "외인계금액(등록+미등록)", (decimal)12.0);
			dict["sa_18"] = new XAQueryFieldInfo("double", sa_18, sa_18.ToString("000000000000."), "기관계금액", (decimal)12.0);
			dict["sa_01"] = new XAQueryFieldInfo("double", sa_01, sa_01.ToString("000000000000."), "증권금액", (decimal)12.0);
			dict["sa_03"] = new XAQueryFieldInfo("double", sa_03, sa_03.ToString("000000000000."), "투신금액", (decimal)12.0);
			dict["sa_04"] = new XAQueryFieldInfo("double", sa_04, sa_04.ToString("000000000000."), "은행금액", (decimal)12.0);
			dict["sa_02"] = new XAQueryFieldInfo("double", sa_02, sa_02.ToString("000000000000."), "보험금액", (decimal)12.0);
			dict["sa_05"] = new XAQueryFieldInfo("double", sa_05, sa_05.ToString("000000000000."), "종금금액", (decimal)12.0);
			dict["sa_06"] = new XAQueryFieldInfo("double", sa_06, sa_06.ToString("000000000000."), "기금금액", (decimal)12.0);
			dict["sa_07"] = new XAQueryFieldInfo("double", sa_07, sa_07.ToString("000000000000."), "기타금액", (decimal)12.0);
			dict["sa_00"] = new XAQueryFieldInfo("double", sa_00, sa_00.ToString("000000000000."), "사모펀드금액", (decimal)12.0);
			dict["sa_09"] = new XAQueryFieldInfo("double", sa_09, sa_09.ToString("000000000000."), "등록외국인금액", (decimal)12.0);
			dict["sa_10"] = new XAQueryFieldInfo("double", sa_10, sa_10.ToString("000000000000."), "미등록외국인금액", (decimal)12.0);
			dict["sa_11"] = new XAQueryFieldInfo("double", sa_11, sa_11.ToString("000000000000."), "국가금액", (decimal)12.0);
			dict["sa_99"] = new XAQueryFieldInfo("double", sa_99, sa_99.ToString("000000000000."), "기타계금액(기타+국가)", (decimal)12.0);
			dict["jisu"] = new XAQueryFieldInfo("float", jisu, jisu.ToString("0000000.00"), "시장지수", (decimal)7.2);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "date":
					this.date = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "sv_08":
					this.sv_08 = fieldInfo.FieldValue.ParseLong("sv_08");
				break;

				case "sv_17":
					this.sv_17 = fieldInfo.FieldValue.ParseLong("sv_17");
				break;

				case "sv_18":
					this.sv_18 = fieldInfo.FieldValue.ParseLong("sv_18");
				break;

				case "sv_01":
					this.sv_01 = fieldInfo.FieldValue.ParseLong("sv_01");
				break;

				case "sv_03":
					this.sv_03 = fieldInfo.FieldValue.ParseLong("sv_03");
				break;

				case "sv_04":
					this.sv_04 = fieldInfo.FieldValue.ParseLong("sv_04");
				break;

				case "sv_02":
					this.sv_02 = fieldInfo.FieldValue.ParseLong("sv_02");
				break;

				case "sv_05":
					this.sv_05 = fieldInfo.FieldValue.ParseLong("sv_05");
				break;

				case "sv_06":
					this.sv_06 = fieldInfo.FieldValue.ParseLong("sv_06");
				break;

				case "sv_07":
					this.sv_07 = fieldInfo.FieldValue.ParseLong("sv_07");
				break;

				case "sv_00":
					this.sv_00 = fieldInfo.FieldValue.ParseLong("sv_00");
				break;

				case "sv_09":
					this.sv_09 = fieldInfo.FieldValue.ParseLong("sv_09");
				break;

				case "sv_10":
					this.sv_10 = fieldInfo.FieldValue.ParseLong("sv_10");
				break;

				case "sv_11":
					this.sv_11 = fieldInfo.FieldValue.ParseLong("sv_11");
				break;

				case "sv_99":
					this.sv_99 = fieldInfo.FieldValue.ParseLong("sv_99");
				break;

				case "sa_08":
					this.sa_08 = fieldInfo.FieldValue.ParseDouble("sa_08");
				break;

				case "sa_17":
					this.sa_17 = fieldInfo.FieldValue.ParseDouble("sa_17");
				break;

				case "sa_18":
					this.sa_18 = fieldInfo.FieldValue.ParseDouble("sa_18");
				break;

				case "sa_01":
					this.sa_01 = fieldInfo.FieldValue.ParseDouble("sa_01");
				break;

				case "sa_03":
					this.sa_03 = fieldInfo.FieldValue.ParseDouble("sa_03");
				break;

				case "sa_04":
					this.sa_04 = fieldInfo.FieldValue.ParseDouble("sa_04");
				break;

				case "sa_02":
					this.sa_02 = fieldInfo.FieldValue.ParseDouble("sa_02");
				break;

				case "sa_05":
					this.sa_05 = fieldInfo.FieldValue.ParseDouble("sa_05");
				break;

				case "sa_06":
					this.sa_06 = fieldInfo.FieldValue.ParseDouble("sa_06");
				break;

				case "sa_07":
					this.sa_07 = fieldInfo.FieldValue.ParseDouble("sa_07");
				break;

				case "sa_00":
					this.sa_00 = fieldInfo.FieldValue.ParseDouble("sa_00");
				break;

				case "sa_09":
					this.sa_09 = fieldInfo.FieldValue.ParseDouble("sa_09");
				break;

				case "sa_10":
					this.sa_10 = fieldInfo.FieldValue.ParseDouble("sa_10");
				break;

				case "sa_11":
					this.sa_11 = fieldInfo.FieldValue.ParseDouble("sa_11");
				break;

				case "sa_99":
					this.sa_99 = fieldInfo.FieldValue.ParseDouble("sa_99");
				break;

				case "jisu":
					this.jisu = fieldInfo.FieldValue.ParseFloat("jisu");
				break;


			}
		}

		public static XQt2814OutBlock1[] ListFromQuery(XQt2814 query)
		{
			int count = query.GetBlockCount(XQt2814OutBlock1.BlockName);
			List<XQt2814OutBlock1> list = new List<XQt2814OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt2814OutBlock1 block = new XQt2814OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.date = query.GetFieldData(block.GetBlockName(), "date", i).TrimEnd('?'); // char 8
					block.sv_08 = query.GetFieldData(block.GetBlockName(), "sv_08", i).ParseLong("sv_08"); // long 12
					block.sv_17 = query.GetFieldData(block.GetBlockName(), "sv_17", i).ParseLong("sv_17"); // long 12
					block.sv_18 = query.GetFieldData(block.GetBlockName(), "sv_18", i).ParseLong("sv_18"); // long 12
					block.sv_01 = query.GetFieldData(block.GetBlockName(), "sv_01", i).ParseLong("sv_01"); // long 12
					block.sv_03 = query.GetFieldData(block.GetBlockName(), "sv_03", i).ParseLong("sv_03"); // long 12
					block.sv_04 = query.GetFieldData(block.GetBlockName(), "sv_04", i).ParseLong("sv_04"); // long 12
					block.sv_02 = query.GetFieldData(block.GetBlockName(), "sv_02", i).ParseLong("sv_02"); // long 12
					block.sv_05 = query.GetFieldData(block.GetBlockName(), "sv_05", i).ParseLong("sv_05"); // long 12
					block.sv_06 = query.GetFieldData(block.GetBlockName(), "sv_06", i).ParseLong("sv_06"); // long 12
					block.sv_07 = query.GetFieldData(block.GetBlockName(), "sv_07", i).ParseLong("sv_07"); // long 12
					block.sv_00 = query.GetFieldData(block.GetBlockName(), "sv_00", i).ParseLong("sv_00"); // long 12
					block.sv_09 = query.GetFieldData(block.GetBlockName(), "sv_09", i).ParseLong("sv_09"); // long 12
					block.sv_10 = query.GetFieldData(block.GetBlockName(), "sv_10", i).ParseLong("sv_10"); // long 12
					block.sv_11 = query.GetFieldData(block.GetBlockName(), "sv_11", i).ParseLong("sv_11"); // long 12
					block.sv_99 = query.GetFieldData(block.GetBlockName(), "sv_99", i).ParseLong("sv_99"); // long 12
					block.sa_08 = query.GetFieldData(block.GetBlockName(), "sa_08", i).ParseDouble("sa_08"); // double 12.0
					block.sa_17 = query.GetFieldData(block.GetBlockName(), "sa_17", i).ParseDouble("sa_17"); // double 12.0
					block.sa_18 = query.GetFieldData(block.GetBlockName(), "sa_18", i).ParseDouble("sa_18"); // double 12.0
					block.sa_01 = query.GetFieldData(block.GetBlockName(), "sa_01", i).ParseDouble("sa_01"); // double 12.0
					block.sa_03 = query.GetFieldData(block.GetBlockName(), "sa_03", i).ParseDouble("sa_03"); // double 12.0
					block.sa_04 = query.GetFieldData(block.GetBlockName(), "sa_04", i).ParseDouble("sa_04"); // double 12.0
					block.sa_02 = query.GetFieldData(block.GetBlockName(), "sa_02", i).ParseDouble("sa_02"); // double 12.0
					block.sa_05 = query.GetFieldData(block.GetBlockName(), "sa_05", i).ParseDouble("sa_05"); // double 12.0
					block.sa_06 = query.GetFieldData(block.GetBlockName(), "sa_06", i).ParseDouble("sa_06"); // double 12.0
					block.sa_07 = query.GetFieldData(block.GetBlockName(), "sa_07", i).ParseDouble("sa_07"); // double 12.0
					block.sa_00 = query.GetFieldData(block.GetBlockName(), "sa_00", i).ParseDouble("sa_00"); // double 12.0
					block.sa_09 = query.GetFieldData(block.GetBlockName(), "sa_09", i).ParseDouble("sa_09"); // double 12.0
					block.sa_10 = query.GetFieldData(block.GetBlockName(), "sa_10", i).ParseDouble("sa_10"); // double 12.0
					block.sa_11 = query.GetFieldData(block.GetBlockName(), "sa_11", i).ParseDouble("sa_11"); // double 12.0
					block.sa_99 = query.GetFieldData(block.GetBlockName(), "sa_99", i).ParseDouble("sa_99"); // double 12.0
					block.jisu = query.GetFieldData(block.GetBlockName(), "jisu", i).ParseFloat("jisu"); // float 7.2

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
			if (date?.Length > 8) return false; // char 8
			if (sv_08.ToString().Length > 12) return false; // long 12
			if (sv_17.ToString().Length > 12) return false; // long 12
			if (sv_18.ToString().Length > 12) return false; // long 12
			if (sv_01.ToString().Length > 12) return false; // long 12
			if (sv_03.ToString().Length > 12) return false; // long 12
			if (sv_04.ToString().Length > 12) return false; // long 12
			if (sv_02.ToString().Length > 12) return false; // long 12
			if (sv_05.ToString().Length > 12) return false; // long 12
			if (sv_06.ToString().Length > 12) return false; // long 12
			if (sv_07.ToString().Length > 12) return false; // long 12
			if (sv_00.ToString().Length > 12) return false; // long 12
			if (sv_09.ToString().Length > 12) return false; // long 12
			if (sv_10.ToString().Length > 12) return false; // long 12
			if (sv_11.ToString().Length > 12) return false; // long 12
			if (sv_99.ToString().Length > 12) return false; // long 12
			// sa_08 double 12.0
			// sa_17 double 12.0
			// sa_18 double 12.0
			// sa_01 double 12.0
			// sa_03 double 12.0
			// sa_04 double 12.0
			// sa_02 double 12.0
			// sa_05 double 12.0
			// sa_06 double 12.0
			// sa_07 double 12.0
			// sa_00 double 12.0
			// sa_09 double 12.0
			// sa_10 double 12.0
			// sa_11 double 12.0
			// sa_99 double 12.0
			// jisu float 7.2

			return true;
		}
	}

	/// <summary>
	/// CME야간선물기간별투자자매매추이(챠트)
	/// </summary>
	public partial class XQt2814 : XingQuery
	{
		/// <summary>
		/// t2814
		/// </summary>
		public const string _typeName = "t2814";
		/// <summary>
		/// CME야간선물기간별투자자매매추이(챠트)
		/// </summary>
		public const string _typeDesc = "CME야간선물기간별투자자매매추이(챠트)";
		/// <summary>
		/// 
		/// </summary>
		public const string _service = "";
		/// <summary>
		/// A
		/// </summary>
		public const string _headType = "A";
		/// <summary>
		/// 
		/// </summary>
		public const string _creator = "";
		/// <summary>
		/// 
		/// </summary>
		public const string _createdDate = "";
		/// <summary>
		/// true
		/// </summary>
		public const bool _attr = true;
		/// <summary>
		/// true
		/// </summary>
		public const bool _block = true;
		/// <summary>
		/// false
		/// </summary>
		public const bool _encrypt = false;
		/// <summary>
		/// false
		/// </summary>
		public const bool _signature = false;

		/// <summary>
		/// t2814
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// CME야간선물기간별투자자매매추이(챠트)
		/// </summary>
		public string TypeDesc => _typeDesc;
		/// <summary>
		/// 
		/// </summary>
		public string Service => _service;
		/// <summary>
		/// A
		/// </summary>
		public string HeadType => _headType;
		/// <summary>
		/// 
		/// </summary>
		public string Creator => _creator;
		/// <summary>
		/// 
		/// </summary>
		public string CreatedDate => _createdDate;
		/// <summary>
		/// true
		/// </summary>
		public bool Attr => _attr;
		/// <summary>
		/// true
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
		/// CME야간선물기간별투자자매매추이(챠트)
		/// </summary>
		public XQt2814() : base("t2814") { }


		public class XQAllOutBlocks
		{
			public XQt2814OutBlock OutBlock { get; internal set; }
			public XQt2814OutBlock1[] OutBlock1 { get; internal set; }
		}

		public static XQAllOutBlocks Get(char gubun1 = default,char gubun2 = default,string from_date = default,string to_date = default)
		{
			using (XQt2814 instance = new XQt2814())
			{
				instance.SetFieldData(XQt2814InBlock.BlockName, XQt2814InBlock.F.gubun1, 0, gubun1.ToString()); // char 1
				instance.SetFieldData(XQt2814InBlock.BlockName, XQt2814InBlock.F.gubun2, 0, gubun2.ToString()); // char 1
				instance.SetFieldData(XQt2814InBlock.BlockName, XQt2814InBlock.F.from_date, 0, from_date); // char 8
				instance.SetFieldData(XQt2814InBlock.BlockName, XQt2814InBlock.F.to_date, 0, to_date); // char 8

				if (instance.Request() < 0)
				{
					return null;
				}

				XQAllOutBlocks results = new XQAllOutBlocks();
				results.OutBlock = instance.GetBlock();
				if (results.OutBlock.IsValidData == false)
				{
					return null;
				}

				results.OutBlock1 = instance.GetBlock1s();
				return results;
			}
		}

		public bool SetBlock(XQt2814InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "gubun1", 0, block.gubun1.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "gubun2", 0, block.gubun2.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "from_date", 0, block.from_date); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "to_date", 0, block.to_date); // char 8

			return true;
		}

		public XQt2814OutBlock GetBlock()
		{
			XQt2814OutBlock instance = XQt2814OutBlock.FromQuery(this);
			return instance;

		}

		public XQt2814OutBlock1[] GetBlock1s()
		{
			XQt2814OutBlock1[] instance = XQt2814OutBlock1.ListFromQuery(this);
			return instance;

		}


	}

}
