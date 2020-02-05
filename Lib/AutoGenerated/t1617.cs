using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1617InBlock : XingBlock
	{
		/// <summary>
		/// t1617InBlock
		/// </summary>
		public const string _blockName = "t1617InBlock";
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
		/// t1617InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1617InBlock
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
		/// 시장구분(1:코스피2:코스닥3:선물4:콜옵션5:풋옵션6:주식선물)
		/// </summary>
		[XAQueryFieldAttribute("시장구분(1:코스피2:코스닥3:선물4:콜옵션5:풋옵션6:주식선물)")]
		public char gubun1;
		/// <summary>
		/// 수량금액구분(1:수량2:금액)
		/// </summary>
		[XAQueryFieldAttribute("수량금액구분(1:수량2:금액)")]
		public char gubun2;
		/// <summary>
		/// 일자구분(1:시간대별2:일별)
		/// </summary>
		[XAQueryFieldAttribute("일자구분(1:시간대별2:일별)")]
		public char gubun3;
		/// <summary>
		/// CTSDATE(연속키값-일자)
		/// </summary>
		[XAQueryFieldAttribute("CTSDATE(연속키값-일자)")]
		public string cts_date;
		/// <summary>
		/// CTSTIME(연속키값-시간)
		/// </summary>
		[XAQueryFieldAttribute("CTSTIME(연속키값-시간)")]
		public string cts_time;

		public static class F
		{
			/// <summary>
			/// 시장구분(1:코스피2:코스닥3:선물4:콜옵션5:풋옵션6:주식선물)
			/// </summary>
			public const string gubun1 = "gubun1";
			/// <summary>
			/// 수량금액구분(1:수량2:금액)
			/// </summary>
			public const string gubun2 = "gubun2";
			/// <summary>
			/// 일자구분(1:시간대별2:일별)
			/// </summary>
			public const string gubun3 = "gubun3";
			/// <summary>
			/// CTSDATE(연속키값-일자)
			/// </summary>
			public const string cts_date = "cts_date";
			/// <summary>
			/// CTSTIME(연속키값-시간)
			/// </summary>
			public const string cts_time = "cts_time";
		}

		public static string[] AllFields = new string[]
		{
			F.gubun1,
			F.gubun2,
			F.gubun3,
			F.cts_date,
			F.cts_time,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["gubun1"] = new XAQueryFieldInfo("char", gubun1, gubun1.ToString(), "시장구분(1:코스피2:코스닥3:선물4:콜옵션5:풋옵션6:주식선물)", (decimal)1);
			dict["gubun2"] = new XAQueryFieldInfo("char", gubun2, gubun2.ToString(), "수량금액구분(1:수량2:금액)", (decimal)1);
			dict["gubun3"] = new XAQueryFieldInfo("char", gubun3, gubun3.ToString(), "일자구분(1:시간대별2:일별)", (decimal)1);
			dict["cts_date"] = new XAQueryFieldInfo("char", cts_date, cts_date, "CTSDATE(연속키값-일자)", (decimal)8);
			dict["cts_time"] = new XAQueryFieldInfo("char", cts_time, cts_time, "CTSTIME(연속키값-시간)", (decimal)8);

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

				case "gubun3":
					this.gubun3 = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "cts_date":
					this.cts_date = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cts_time":
					this.cts_time = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			// gubun1 char 1
			// gubun2 char 1
			// gubun3 char 1
			if (cts_date?.Length > 8) return false; // char 8
			if (cts_time?.Length > 8) return false; // char 8

			return true;
		}
	}

	public partial class XQt1617OutBlock : XingBlock
	{
		/// <summary>
		/// t1617OutBlock
		/// </summary>
		public const string _blockName = "t1617OutBlock";
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
		/// t1617OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1617OutBlock
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
		/// CTSDATE
		/// </summary>
		[XAQueryFieldAttribute("CTSDATE")]
		public string cts_date;
		/// <summary>
		/// CTSTIME
		/// </summary>
		[XAQueryFieldAttribute("CTSTIME")]
		public string cts_time;
		/// <summary>
		/// 개인매수
		/// </summary>
		[XAQueryFieldAttribute("개인매수")]
		public long ms_08;
		/// <summary>
		/// 개인매도
		/// </summary>
		[XAQueryFieldAttribute("개인매도")]
		public long md_08;
		/// <summary>
		/// 개인순매수
		/// </summary>
		[XAQueryFieldAttribute("개인순매수")]
		public long sv_08;
		/// <summary>
		/// 외국인매수
		/// </summary>
		[XAQueryFieldAttribute("외국인매수")]
		public long ms_17;
		/// <summary>
		/// 외국인매도
		/// </summary>
		[XAQueryFieldAttribute("외국인매도")]
		public long md_17;
		/// <summary>
		/// 외국인순매수
		/// </summary>
		[XAQueryFieldAttribute("외국인순매수")]
		public long sv_17;
		/// <summary>
		/// 기관계매수
		/// </summary>
		[XAQueryFieldAttribute("기관계매수")]
		public long ms_18;
		/// <summary>
		/// 기관계매도
		/// </summary>
		[XAQueryFieldAttribute("기관계매도")]
		public long md_18;
		/// <summary>
		/// 기관계순매수
		/// </summary>
		[XAQueryFieldAttribute("기관계순매수")]
		public long sv_18;
		/// <summary>
		/// 증권매수
		/// </summary>
		[XAQueryFieldAttribute("증권매수")]
		public long ms_01;
		/// <summary>
		/// 증권매도
		/// </summary>
		[XAQueryFieldAttribute("증권매도")]
		public long md_01;
		/// <summary>
		/// 증권순매수
		/// </summary>
		[XAQueryFieldAttribute("증권순매수")]
		public long sv_01;

		public static class F
		{
			/// <summary>
			/// CTSDATE
			/// </summary>
			public const string cts_date = "cts_date";
			/// <summary>
			/// CTSTIME
			/// </summary>
			public const string cts_time = "cts_time";
			/// <summary>
			/// 개인매수
			/// </summary>
			public const string ms_08 = "ms_08";
			/// <summary>
			/// 개인매도
			/// </summary>
			public const string md_08 = "md_08";
			/// <summary>
			/// 개인순매수
			/// </summary>
			public const string sv_08 = "sv_08";
			/// <summary>
			/// 외국인매수
			/// </summary>
			public const string ms_17 = "ms_17";
			/// <summary>
			/// 외국인매도
			/// </summary>
			public const string md_17 = "md_17";
			/// <summary>
			/// 외국인순매수
			/// </summary>
			public const string sv_17 = "sv_17";
			/// <summary>
			/// 기관계매수
			/// </summary>
			public const string ms_18 = "ms_18";
			/// <summary>
			/// 기관계매도
			/// </summary>
			public const string md_18 = "md_18";
			/// <summary>
			/// 기관계순매수
			/// </summary>
			public const string sv_18 = "sv_18";
			/// <summary>
			/// 증권매수
			/// </summary>
			public const string ms_01 = "ms_01";
			/// <summary>
			/// 증권매도
			/// </summary>
			public const string md_01 = "md_01";
			/// <summary>
			/// 증권순매수
			/// </summary>
			public const string sv_01 = "sv_01";
		}

		public static string[] AllFields = new string[]
		{
			F.cts_date,
			F.cts_time,
			F.ms_08,
			F.md_08,
			F.sv_08,
			F.ms_17,
			F.md_17,
			F.sv_17,
			F.ms_18,
			F.md_18,
			F.sv_18,
			F.ms_01,
			F.md_01,
			F.sv_01,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["cts_date"] = new XAQueryFieldInfo("char", cts_date, cts_date, "CTSDATE", (decimal)8);
			dict["cts_time"] = new XAQueryFieldInfo("char", cts_time, cts_time, "CTSTIME", (decimal)8);
			dict["ms_08"] = new XAQueryFieldInfo("long", ms_08, ms_08.ToString("d12"), "개인매수", (decimal)12);
			dict["md_08"] = new XAQueryFieldInfo("long", md_08, md_08.ToString("d12"), "개인매도", (decimal)12);
			dict["sv_08"] = new XAQueryFieldInfo("long", sv_08, sv_08.ToString("d12"), "개인순매수", (decimal)12);
			dict["ms_17"] = new XAQueryFieldInfo("long", ms_17, ms_17.ToString("d12"), "외국인매수", (decimal)12);
			dict["md_17"] = new XAQueryFieldInfo("long", md_17, md_17.ToString("d12"), "외국인매도", (decimal)12);
			dict["sv_17"] = new XAQueryFieldInfo("long", sv_17, sv_17.ToString("d12"), "외국인순매수", (decimal)12);
			dict["ms_18"] = new XAQueryFieldInfo("long", ms_18, ms_18.ToString("d12"), "기관계매수", (decimal)12);
			dict["md_18"] = new XAQueryFieldInfo("long", md_18, md_18.ToString("d12"), "기관계매도", (decimal)12);
			dict["sv_18"] = new XAQueryFieldInfo("long", sv_18, sv_18.ToString("d12"), "기관계순매수", (decimal)12);
			dict["ms_01"] = new XAQueryFieldInfo("long", ms_01, ms_01.ToString("d12"), "증권매수", (decimal)12);
			dict["md_01"] = new XAQueryFieldInfo("long", md_01, md_01.ToString("d12"), "증권매도", (decimal)12);
			dict["sv_01"] = new XAQueryFieldInfo("long", sv_01, sv_01.ToString("d12"), "증권순매수", (decimal)12);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "cts_date":
					this.cts_date = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cts_time":
					this.cts_time = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ms_08":
					this.ms_08 = fieldInfo.FieldValue.ParseLong("ms_08");
				break;

				case "md_08":
					this.md_08 = fieldInfo.FieldValue.ParseLong("md_08");
				break;

				case "sv_08":
					this.sv_08 = fieldInfo.FieldValue.ParseLong("sv_08");
				break;

				case "ms_17":
					this.ms_17 = fieldInfo.FieldValue.ParseLong("ms_17");
				break;

				case "md_17":
					this.md_17 = fieldInfo.FieldValue.ParseLong("md_17");
				break;

				case "sv_17":
					this.sv_17 = fieldInfo.FieldValue.ParseLong("sv_17");
				break;

				case "ms_18":
					this.ms_18 = fieldInfo.FieldValue.ParseLong("ms_18");
				break;

				case "md_18":
					this.md_18 = fieldInfo.FieldValue.ParseLong("md_18");
				break;

				case "sv_18":
					this.sv_18 = fieldInfo.FieldValue.ParseLong("sv_18");
				break;

				case "ms_01":
					this.ms_01 = fieldInfo.FieldValue.ParseLong("ms_01");
				break;

				case "md_01":
					this.md_01 = fieldInfo.FieldValue.ParseLong("md_01");
				break;

				case "sv_01":
					this.sv_01 = fieldInfo.FieldValue.ParseLong("sv_01");
				break;


			}
		}

		public static XQt1617OutBlock FromQuery(XQt1617 query)
		{
			XQt1617OutBlock block = new XQt1617OutBlock();
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
				block.cts_date = query.GetFieldData(block.GetBlockName(), "cts_date", 0).TrimEnd('?'); // char 8
				block.cts_time = query.GetFieldData(block.GetBlockName(), "cts_time", 0).TrimEnd('?'); // char 8
				block.ms_08 = query.GetFieldData(block.GetBlockName(), "ms_08", 0).ParseLong("ms_08"); // long 12
				block.md_08 = query.GetFieldData(block.GetBlockName(), "md_08", 0).ParseLong("md_08"); // long 12
				block.sv_08 = query.GetFieldData(block.GetBlockName(), "sv_08", 0).ParseLong("sv_08"); // long 12
				block.ms_17 = query.GetFieldData(block.GetBlockName(), "ms_17", 0).ParseLong("ms_17"); // long 12
				block.md_17 = query.GetFieldData(block.GetBlockName(), "md_17", 0).ParseLong("md_17"); // long 12
				block.sv_17 = query.GetFieldData(block.GetBlockName(), "sv_17", 0).ParseLong("sv_17"); // long 12
				block.ms_18 = query.GetFieldData(block.GetBlockName(), "ms_18", 0).ParseLong("ms_18"); // long 12
				block.md_18 = query.GetFieldData(block.GetBlockName(), "md_18", 0).ParseLong("md_18"); // long 12
				block.sv_18 = query.GetFieldData(block.GetBlockName(), "sv_18", 0).ParseLong("sv_18"); // long 12
				block.ms_01 = query.GetFieldData(block.GetBlockName(), "ms_01", 0).ParseLong("ms_01"); // long 12
				block.md_01 = query.GetFieldData(block.GetBlockName(), "md_01", 0).ParseLong("md_01"); // long 12
				block.sv_01 = query.GetFieldData(block.GetBlockName(), "sv_01", 0).ParseLong("sv_01"); // long 12

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (cts_date?.Length > 8) return false; // char 8
			if (cts_time?.Length > 8) return false; // char 8
			if (ms_08.ToString().Length > 12) return false; // long 12
			if (md_08.ToString().Length > 12) return false; // long 12
			if (sv_08.ToString().Length > 12) return false; // long 12
			if (ms_17.ToString().Length > 12) return false; // long 12
			if (md_17.ToString().Length > 12) return false; // long 12
			if (sv_17.ToString().Length > 12) return false; // long 12
			if (ms_18.ToString().Length > 12) return false; // long 12
			if (md_18.ToString().Length > 12) return false; // long 12
			if (sv_18.ToString().Length > 12) return false; // long 12
			if (ms_01.ToString().Length > 12) return false; // long 12
			if (md_01.ToString().Length > 12) return false; // long 12
			if (sv_01.ToString().Length > 12) return false; // long 12

			return true;
		}
	}

	public partial class XQt1617OutBlock1 : XingBlock
	{
		/// <summary>
		/// t1617OutBlock1
		/// </summary>
		public const string _blockName = "t1617OutBlock1";
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
		/// t1617OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1617OutBlock1
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
		/// 날짜
		/// </summary>
		[XAQueryFieldAttribute("날짜")]
		public string date;
		/// <summary>
		/// 시간
		/// </summary>
		[XAQueryFieldAttribute("시간")]
		public string time;
		/// <summary>
		/// 개인
		/// </summary>
		[XAQueryFieldAttribute("개인")]
		public long sv_08;
		/// <summary>
		/// 외국인
		/// </summary>
		[XAQueryFieldAttribute("외국인")]
		public long sv_17;
		/// <summary>
		/// 기관계
		/// </summary>
		[XAQueryFieldAttribute("기관계")]
		public long sv_18;
		/// <summary>
		/// 증권
		/// </summary>
		[XAQueryFieldAttribute("증권")]
		public long sv_01;

		public static class F
		{
			/// <summary>
			/// 날짜
			/// </summary>
			public const string date = "date";
			/// <summary>
			/// 시간
			/// </summary>
			public const string time = "time";
			/// <summary>
			/// 개인
			/// </summary>
			public const string sv_08 = "sv_08";
			/// <summary>
			/// 외국인
			/// </summary>
			public const string sv_17 = "sv_17";
			/// <summary>
			/// 기관계
			/// </summary>
			public const string sv_18 = "sv_18";
			/// <summary>
			/// 증권
			/// </summary>
			public const string sv_01 = "sv_01";
		}

		public static string[] AllFields = new string[]
		{
			F.date,
			F.time,
			F.sv_08,
			F.sv_17,
			F.sv_18,
			F.sv_01,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["date"] = new XAQueryFieldInfo("char", date, date, "날짜", (decimal)8);
			dict["time"] = new XAQueryFieldInfo("char", time, time, "시간", (decimal)8);
			dict["sv_08"] = new XAQueryFieldInfo("long", sv_08, sv_08.ToString("d12"), "개인", (decimal)12);
			dict["sv_17"] = new XAQueryFieldInfo("long", sv_17, sv_17.ToString("d12"), "외국인", (decimal)12);
			dict["sv_18"] = new XAQueryFieldInfo("long", sv_18, sv_18.ToString("d12"), "기관계", (decimal)12);
			dict["sv_01"] = new XAQueryFieldInfo("long", sv_01, sv_01.ToString("d12"), "증권", (decimal)12);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "date":
					this.date = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "time":
					this.time = fieldInfo.FieldValue.TrimEnd('?');
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


			}
		}

		public static XQt1617OutBlock1[] ListFromQuery(XQt1617 query)
		{
			int count = query.GetBlockCount(XQt1617OutBlock1.BlockName);
			List<XQt1617OutBlock1> list = new List<XQt1617OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1617OutBlock1 block = new XQt1617OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.date = query.GetFieldData(block.GetBlockName(), "date", i).TrimEnd('?'); // char 8
					block.time = query.GetFieldData(block.GetBlockName(), "time", i).TrimEnd('?'); // char 8
					block.sv_08 = query.GetFieldData(block.GetBlockName(), "sv_08", i).ParseLong("sv_08"); // long 12
					block.sv_17 = query.GetFieldData(block.GetBlockName(), "sv_17", i).ParseLong("sv_17"); // long 12
					block.sv_18 = query.GetFieldData(block.GetBlockName(), "sv_18", i).ParseLong("sv_18"); // long 12
					block.sv_01 = query.GetFieldData(block.GetBlockName(), "sv_01", i).ParseLong("sv_01"); // long 12

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
			if (time?.Length > 8) return false; // char 8
			if (sv_08.ToString().Length > 12) return false; // long 12
			if (sv_17.ToString().Length > 12) return false; // long 12
			if (sv_18.ToString().Length > 12) return false; // long 12
			if (sv_01.ToString().Length > 12) return false; // long 12

			return true;
		}
	}

	/// <summary>
	/// 투자자매매종합2(t1617)
	/// </summary>
	public partial class XQt1617 : XingQuery
	{
		/// <summary>
		/// t1617
		/// </summary>
		public const string _typeName = "t1617";
		/// <summary>
		/// 투자자매매종합2(t1617)
		/// </summary>
		public const string _typeDesc = "투자자매매종합2(t1617)";
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
		/// t1617
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 투자자매매종합2(t1617)
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
		/// 투자자매매종합2(t1617)
		/// </summary>
		public XQt1617() : base("t1617") { }


		public static XQt1617OutBlock1[] Get(char gubun1 = default,char gubun2 = default,char gubun3 = default,string cts_date = default,string cts_time = default)
		{
			using (XQt1617 instance = new XQt1617())
			{
				instance.SetFieldData(XQt1617InBlock.BlockName, XQt1617InBlock.F.gubun1, 0, gubun1.ToString()); // char 1
				instance.SetFieldData(XQt1617InBlock.BlockName, XQt1617InBlock.F.gubun2, 0, gubun2.ToString()); // char 1
				instance.SetFieldData(XQt1617InBlock.BlockName, XQt1617InBlock.F.gubun3, 0, gubun3.ToString()); // char 1
				instance.SetFieldData(XQt1617InBlock.BlockName, XQt1617InBlock.F.cts_date, 0, cts_date); // char 8
				instance.SetFieldData(XQt1617InBlock.BlockName, XQt1617InBlock.F.cts_time, 0, cts_time); // char 8

				if (instance.Request() < 0)
				{
					return null;
				}

				var outBlock = instance.GetBlock1s();
				return outBlock;
			}
		}

		public bool SetBlock(XQt1617InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "gubun1", 0, block.gubun1.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "gubun2", 0, block.gubun2.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "gubun3", 0, block.gubun3.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "cts_date", 0, block.cts_date); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "cts_time", 0, block.cts_time); // char 8

			return true;
		}

		public XQt1617OutBlock GetBlock()
		{
			XQt1617OutBlock instance = XQt1617OutBlock.FromQuery(this);
			return instance;

		}

		public XQt1617OutBlock1[] GetBlock1s()
		{
			XQt1617OutBlock1[] instance = XQt1617OutBlock1.ListFromQuery(this);
			return instance;

		}


	}

}
