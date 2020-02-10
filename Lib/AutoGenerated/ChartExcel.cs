using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQChartExcelInBlock : XingBlock
	{
		/// <summary>
		/// ChartExcelInBlock
		/// </summary>
		public const string _blockName = "ChartExcelInBlock";
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
		/// ChartExcelInBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// ChartExcelInBlock
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
		/// 지표ID
		/// </summary>
		[XAQueryFieldAttribute("지표ID", "10")]
		public long indexid;
		/// <summary>
		/// 지표명
		/// </summary>
		[XAQueryFieldAttribute("지표명", "40")]
		public string indexname;
		/// <summary>
		/// 지표조건설정
		/// </summary>
		[XAQueryFieldAttribute("지표조건설정", "40")]
		public string indexparam;
		/// <summary>
		/// 결과데이터 구분
		/// </summary>
		[XAQueryFieldAttribute("결과데이터 구분", "1")]
		public char indexouttype;
		/// <summary>
		/// 시장구분
		/// </summary>
		[XAQueryFieldAttribute("시장구분", "1")]
		public char market;
		/// <summary>
		/// 주기구분
		/// </summary>
		[XAQueryFieldAttribute("주기구분", "1")]
		public char period;
		/// <summary>
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("단축코드", "8")]
		public string shcode;
		/// <summary>
		/// 결과 지표데이터 엑셀표시 여부
		/// </summary>
		[XAQueryFieldAttribute("결과 지표데이터 엑셀표시 여부", "1")]
		public char isexcelout;
		/// <summary>
		/// 엑셀데이터 파일명
		/// </summary>
		[XAQueryFieldAttribute("엑셀데이터 파일명", "256")]
		public string excelfilename;
		/// <summary>
		/// 실시간 데이터수신 자동등록 여부
		/// </summary>
		[XAQueryFieldAttribute("실시간 데이터수신 자동등록 여부", "1")]
		public char IsReal;

		public static class F
		{
			/// <summary>
			/// 지표ID
			/// </summary>
			public const string indexid = "indexid";
			/// <summary>
			/// 지표명
			/// </summary>
			public const string indexname = "indexname";
			/// <summary>
			/// 지표조건설정
			/// </summary>
			public const string indexparam = "indexparam";
			/// <summary>
			/// 결과데이터 구분
			/// </summary>
			public const string indexouttype = "indexouttype";
			/// <summary>
			/// 시장구분
			/// </summary>
			public const string market = "market";
			/// <summary>
			/// 주기구분
			/// </summary>
			public const string period = "period";
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 결과 지표데이터 엑셀표시 여부
			/// </summary>
			public const string isexcelout = "isexcelout";
			/// <summary>
			/// 엑셀데이터 파일명
			/// </summary>
			public const string excelfilename = "excelfilename";
			/// <summary>
			/// 실시간 데이터수신 자동등록 여부
			/// </summary>
			public const string IsReal = "IsReal";
		}

		public static string[] AllFields = new string[]
		{
			F.indexid,
			F.indexname,
			F.indexparam,
			F.indexouttype,
			F.market,
			F.period,
			F.shcode,
			F.isexcelout,
			F.excelfilename,
			F.IsReal,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["indexid"] = new XAQueryFieldInfo("long", indexid, indexid.ToString("d10"), "지표ID", (decimal)10);
			dict["indexname"] = new XAQueryFieldInfo("char", indexname, indexname, "지표명", (decimal)40);
			dict["indexparam"] = new XAQueryFieldInfo("char", indexparam, indexparam, "지표조건설정", (decimal)40);
			dict["indexouttype"] = new XAQueryFieldInfo("char", indexouttype, indexouttype.ToString(), "결과데이터 구분", (decimal)1);
			dict["market"] = new XAQueryFieldInfo("char", market, market.ToString(), "시장구분", (decimal)1);
			dict["period"] = new XAQueryFieldInfo("char", period, period.ToString(), "주기구분", (decimal)1);
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)8);
			dict["isexcelout"] = new XAQueryFieldInfo("char", isexcelout, isexcelout.ToString(), "결과 지표데이터 엑셀표시 여부", (decimal)1);
			dict["excelfilename"] = new XAQueryFieldInfo("char", excelfilename, excelfilename, "엑셀데이터 파일명", (decimal)256);
			dict["IsReal"] = new XAQueryFieldInfo("char", IsReal, IsReal.ToString(), "실시간 데이터수신 자동등록 여부", (decimal)1);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "indexid":
					this.indexid = fieldInfo.FieldValue.ParseLong("indexid");
				break;

				case "indexname":
					this.indexname = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "indexparam":
					this.indexparam = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "indexouttype":
					this.indexouttype = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "market":
					this.market = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "period":
					this.period = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "isexcelout":
					this.isexcelout = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "excelfilename":
					this.excelfilename = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "IsReal":
					this.IsReal = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public bool VerifyData()
		{
			if (indexid.ToString().Length > 10) return false; // long 10
			if (indexname?.Length > 40) return false; // char 40
			if (indexparam?.Length > 40) return false; // char 40
			// indexouttype char 1
			// market char 1
			// period char 1
			if (shcode?.Length > 8) return false; // char 8
			// isexcelout char 1
			if (excelfilename?.Length > 256) return false; // char 256
			// IsReal char 1

			return true;
		}
	}

	public partial class XQChartExcelOutBlock : XingBlock
	{
		/// <summary>
		/// ChartExcelOutBlock
		/// </summary>
		public const string _blockName = "ChartExcelOutBlock";
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
		/// ChartExcelOutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// ChartExcelOutBlock
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
		/// 지표ID
		/// </summary>
		[XAQueryFieldAttribute("지표ID", "10")]
		public long indexid;
		/// <summary>
		/// 레코드갯수
		/// </summary>
		[XAQueryFieldAttribute("레코드갯수", "5")]
		public long rec_cnt;
		/// <summary>
		/// 유효 데이터 컬럼 갯수
		/// </summary>
		[XAQueryFieldAttribute("유효 데이터 컬럼 갯수", "2")]
		public long validdata_cnt;

		public static class F
		{
			/// <summary>
			/// 지표ID
			/// </summary>
			public const string indexid = "indexid";
			/// <summary>
			/// 레코드갯수
			/// </summary>
			public const string rec_cnt = "rec_cnt";
			/// <summary>
			/// 유효 데이터 컬럼 갯수
			/// </summary>
			public const string validdata_cnt = "validdata_cnt";
		}

		public static string[] AllFields = new string[]
		{
			F.indexid,
			F.rec_cnt,
			F.validdata_cnt,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["indexid"] = new XAQueryFieldInfo("long", indexid, indexid.ToString("d10"), "지표ID", (decimal)10);
			dict["rec_cnt"] = new XAQueryFieldInfo("long", rec_cnt, rec_cnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["validdata_cnt"] = new XAQueryFieldInfo("long", validdata_cnt, validdata_cnt.ToString("d2"), "유효 데이터 컬럼 갯수", (decimal)2);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "indexid":
					this.indexid = fieldInfo.FieldValue.ParseLong("indexid");
				break;

				case "rec_cnt":
					this.rec_cnt = fieldInfo.FieldValue.ParseLong("rec_cnt");
				break;

				case "validdata_cnt":
					this.validdata_cnt = fieldInfo.FieldValue.ParseLong("validdata_cnt");
				break;


			}
		}

		public static XQChartExcelOutBlock FromQuery(XQCHARTEXCEL query)
		{
			XQChartExcelOutBlock block = new XQChartExcelOutBlock();
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
				block.indexid = query.GetFieldData(block.GetBlockName(), "indexid", 0).ParseLong("indexid"); // long 10
				block.rec_cnt = query.GetFieldData(block.GetBlockName(), "rec_cnt", 0).ParseLong("rec_cnt"); // long 5
				block.validdata_cnt = query.GetFieldData(block.GetBlockName(), "validdata_cnt", 0).ParseLong("validdata_cnt"); // long 2

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (indexid.ToString().Length > 10) return false; // long 10
			if (rec_cnt.ToString().Length > 5) return false; // long 5
			if (validdata_cnt.ToString().Length > 2) return false; // long 2

			return true;
		}
	}

	public partial class XQChartExcelOutBlock1 : XingBlock
	{
		/// <summary>
		/// ChartExcelOutBlock1
		/// </summary>
		public const string _blockName = "ChartExcelOutBlock1";
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
		/// ChartExcelOutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// ChartExcelOutBlock1
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
		/// 일자
		/// </summary>
		[XAQueryFieldAttribute("일자", "8")]
		public string date;
		/// <summary>
		/// 시간
		/// </summary>
		[XAQueryFieldAttribute("시간", "6")]
		public string time;
		/// <summary>
		/// 시가
		/// </summary>
		[XAQueryFieldAttribute("시가", "10")]
		public float open;
		/// <summary>
		/// 고가
		/// </summary>
		[XAQueryFieldAttribute("고가", "10")]
		public float high;
		/// <summary>
		/// 저가
		/// </summary>
		[XAQueryFieldAttribute("저가", "10")]
		public float low;
		/// <summary>
		/// 종가
		/// </summary>
		[XAQueryFieldAttribute("종가", "10")]
		public float close;
		/// <summary>
		/// 거래량
		/// </summary>
		[XAQueryFieldAttribute("거래량", "12")]
		public float volume;
		/// <summary>
		/// 지표값1
		/// </summary>
		[XAQueryFieldAttribute("지표값1", "10")]
		public float value1;
		/// <summary>
		/// 지표값2
		/// </summary>
		[XAQueryFieldAttribute("지표값2", "10")]
		public float value2;
		/// <summary>
		/// 지표값3
		/// </summary>
		[XAQueryFieldAttribute("지표값3", "10")]
		public float value3;
		/// <summary>
		/// 지표값4
		/// </summary>
		[XAQueryFieldAttribute("지표값4", "10")]
		public float value4;
		/// <summary>
		/// 지표값5
		/// </summary>
		[XAQueryFieldAttribute("지표값5", "10")]
		public float value5;
		/// <summary>
		/// 위치
		/// </summary>
		[XAQueryFieldAttribute("위치", "8")]
		public long pos;

		public static class F
		{
			/// <summary>
			/// 일자
			/// </summary>
			public const string date = "date";
			/// <summary>
			/// 시간
			/// </summary>
			public const string time = "time";
			/// <summary>
			/// 시가
			/// </summary>
			public const string open = "open";
			/// <summary>
			/// 고가
			/// </summary>
			public const string high = "high";
			/// <summary>
			/// 저가
			/// </summary>
			public const string low = "low";
			/// <summary>
			/// 종가
			/// </summary>
			public const string close = "close";
			/// <summary>
			/// 거래량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// 지표값1
			/// </summary>
			public const string value1 = "value1";
			/// <summary>
			/// 지표값2
			/// </summary>
			public const string value2 = "value2";
			/// <summary>
			/// 지표값3
			/// </summary>
			public const string value3 = "value3";
			/// <summary>
			/// 지표값4
			/// </summary>
			public const string value4 = "value4";
			/// <summary>
			/// 지표값5
			/// </summary>
			public const string value5 = "value5";
			/// <summary>
			/// 위치
			/// </summary>
			public const string pos = "pos";
		}

		public static string[] AllFields = new string[]
		{
			F.date,
			F.time,
			F.open,
			F.high,
			F.low,
			F.close,
			F.volume,
			F.value1,
			F.value2,
			F.value3,
			F.value4,
			F.value5,
			F.pos,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["date"] = new XAQueryFieldInfo("char", date, date, "일자", (decimal)8);
			dict["time"] = new XAQueryFieldInfo("char", time, time, "시간", (decimal)6);
			dict["open"] = new XAQueryFieldInfo("float", open, open.ToString("0000000000"), "시가", (decimal)10);
			dict["high"] = new XAQueryFieldInfo("float", high, high.ToString("0000000000"), "고가", (decimal)10);
			dict["low"] = new XAQueryFieldInfo("float", low, low.ToString("0000000000"), "저가", (decimal)10);
			dict["close"] = new XAQueryFieldInfo("float", close, close.ToString("0000000000"), "종가", (decimal)10);
			dict["volume"] = new XAQueryFieldInfo("float", volume, volume.ToString("000000000000"), "거래량", (decimal)12);
			dict["value1"] = new XAQueryFieldInfo("float", value1, value1.ToString("0000000000"), "지표값1", (decimal)10);
			dict["value2"] = new XAQueryFieldInfo("float", value2, value2.ToString("0000000000"), "지표값2", (decimal)10);
			dict["value3"] = new XAQueryFieldInfo("float", value3, value3.ToString("0000000000"), "지표값3", (decimal)10);
			dict["value4"] = new XAQueryFieldInfo("float", value4, value4.ToString("0000000000"), "지표값4", (decimal)10);
			dict["value5"] = new XAQueryFieldInfo("float", value5, value5.ToString("0000000000"), "지표값5", (decimal)10);
			dict["pos"] = new XAQueryFieldInfo("long", pos, pos.ToString("d8"), "위치", (decimal)8);

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

				case "open":
					this.open = fieldInfo.FieldValue.ParseFloat("open");
				break;

				case "high":
					this.high = fieldInfo.FieldValue.ParseFloat("high");
				break;

				case "low":
					this.low = fieldInfo.FieldValue.ParseFloat("low");
				break;

				case "close":
					this.close = fieldInfo.FieldValue.ParseFloat("close");
				break;

				case "volume":
					this.volume = fieldInfo.FieldValue.ParseFloat("volume");
				break;

				case "value1":
					this.value1 = fieldInfo.FieldValue.ParseFloat("value1");
				break;

				case "value2":
					this.value2 = fieldInfo.FieldValue.ParseFloat("value2");
				break;

				case "value3":
					this.value3 = fieldInfo.FieldValue.ParseFloat("value3");
				break;

				case "value4":
					this.value4 = fieldInfo.FieldValue.ParseFloat("value4");
				break;

				case "value5":
					this.value5 = fieldInfo.FieldValue.ParseFloat("value5");
				break;

				case "pos":
					this.pos = fieldInfo.FieldValue.ParseLong("pos");
				break;


			}
		}

		public static XQChartExcelOutBlock1[] ListFromQuery(XQCHARTEXCEL query)
		{
			int count = query.GetBlockCount(XQChartExcelOutBlock1.BlockName);
			List<XQChartExcelOutBlock1> list = new List<XQChartExcelOutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQChartExcelOutBlock1 block = new XQChartExcelOutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.date = query.GetFieldData(block.GetBlockName(), "date", i).TrimEnd('?'); // char 8
					block.time = query.GetFieldData(block.GetBlockName(), "time", i).TrimEnd('?'); // char 6
					block.open = query.GetFieldData(block.GetBlockName(), "open", i).ParseFloat("open"); // float 10
					block.high = query.GetFieldData(block.GetBlockName(), "high", i).ParseFloat("high"); // float 10
					block.low = query.GetFieldData(block.GetBlockName(), "low", i).ParseFloat("low"); // float 10
					block.close = query.GetFieldData(block.GetBlockName(), "close", i).ParseFloat("close"); // float 10
					block.volume = query.GetFieldData(block.GetBlockName(), "volume", i).ParseFloat("volume"); // float 12
					block.value1 = query.GetFieldData(block.GetBlockName(), "value1", i).ParseFloat("value1"); // float 10
					block.value2 = query.GetFieldData(block.GetBlockName(), "value2", i).ParseFloat("value2"); // float 10
					block.value3 = query.GetFieldData(block.GetBlockName(), "value3", i).ParseFloat("value3"); // float 10
					block.value4 = query.GetFieldData(block.GetBlockName(), "value4", i).ParseFloat("value4"); // float 10
					block.value5 = query.GetFieldData(block.GetBlockName(), "value5", i).ParseFloat("value5"); // float 10
					block.pos = query.GetFieldData(block.GetBlockName(), "pos", i).ParseLong("pos"); // long 8

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
			if (time?.Length > 6) return false; // char 6
			// open float 10
			// high float 10
			// low float 10
			// close float 10
			// volume float 12
			// value1 float 10
			// value2 float 10
			// value3 float 10
			// value4 float 10
			// value5 float 10
			if (pos.ToString().Length > 8) return false; // long 8

			return true;
		}
	}

	/// <summary>
	/// 챠트엑셀데이터조회
	/// </summary>
	public partial class XQCHARTEXCEL : XingQuery
	{
		/// <summary>
		/// CHARTEXCEL
		/// </summary>
		public const string _typeName = "CHARTEXCEL";
		/// <summary>
		/// 챠트엑셀데이터조회
		/// </summary>
		public const string _typeDesc = "챠트엑셀데이터조회";
		/// <summary>
		/// 
		/// </summary>
		public const string _service = "";
		/// <summary>
		/// B
		/// </summary>
		public const string _headType = "B";
		/// <summary>
		/// 
		/// </summary>
		public const string _creator = "";
		/// <summary>
		/// 
		/// </summary>
		public const string _createdDate = "";
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
		/// CHARTEXCEL
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 챠트엑셀데이터조회
		/// </summary>
		public string TypeDesc => _typeDesc;
		/// <summary>
		/// 
		/// </summary>
		public string Service => _service;
		/// <summary>
		/// B
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
		/// 챠트엑셀데이터조회
		/// </summary>
		public XQCHARTEXCEL() : base("CHARTEXCEL") { }


		public class XQAllOutBlocks
		{
			public XQChartExcelOutBlock OutBlock { get; internal set; }
			public XQChartExcelOutBlock1[] OutBlock1 { get; internal set; }
		}

		public static XQAllOutBlocks Get(long indexid = default,string indexname = default,string indexparam = default,char indexouttype = default,char market = default,char period = default,string shcode = default,char isexcelout = default,string excelfilename = default,char IsReal = default)
		{
			using (XQCHARTEXCEL instance = new XQCHARTEXCEL())
			{
				instance.SetFieldData(XQChartExcelInBlock.BlockName, XQChartExcelInBlock.F.indexid, 0, indexid.ToString("d10")); // long 10
				instance.SetFieldData(XQChartExcelInBlock.BlockName, XQChartExcelInBlock.F.indexname, 0, indexname); // char 40
				instance.SetFieldData(XQChartExcelInBlock.BlockName, XQChartExcelInBlock.F.indexparam, 0, indexparam); // char 40
				instance.SetFieldData(XQChartExcelInBlock.BlockName, XQChartExcelInBlock.F.indexouttype, 0, indexouttype.ToString()); // char 1
				instance.SetFieldData(XQChartExcelInBlock.BlockName, XQChartExcelInBlock.F.market, 0, market.ToString()); // char 1
				instance.SetFieldData(XQChartExcelInBlock.BlockName, XQChartExcelInBlock.F.period, 0, period.ToString()); // char 1
				instance.SetFieldData(XQChartExcelInBlock.BlockName, XQChartExcelInBlock.F.shcode, 0, shcode); // char 8
				instance.SetFieldData(XQChartExcelInBlock.BlockName, XQChartExcelInBlock.F.isexcelout, 0, isexcelout.ToString()); // char 1
				instance.SetFieldData(XQChartExcelInBlock.BlockName, XQChartExcelInBlock.F.excelfilename, 0, excelfilename); // char 256
				instance.SetFieldData(XQChartExcelInBlock.BlockName, XQChartExcelInBlock.F.IsReal, 0, IsReal.ToString()); // char 1

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

		public bool SetBlock(XQChartExcelInBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "indexid", 0, block.indexid.ToString("d10")); // long 10
			_xaQuery.SetFieldData(block.GetBlockName(), "indexname", 0, block.indexname); // char 40
			_xaQuery.SetFieldData(block.GetBlockName(), "indexparam", 0, block.indexparam); // char 40
			_xaQuery.SetFieldData(block.GetBlockName(), "indexouttype", 0, block.indexouttype.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "market", 0, block.market.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "period", 0, block.period.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "shcode", 0, block.shcode); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "isexcelout", 0, block.isexcelout.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "excelfilename", 0, block.excelfilename); // char 256
			_xaQuery.SetFieldData(block.GetBlockName(), "IsReal", 0, block.IsReal.ToString()); // char 1

			return true;
		}

		public XQChartExcelOutBlock GetBlock()
		{
			XQChartExcelOutBlock instance = XQChartExcelOutBlock.FromQuery(this);
			return instance;

		}

		public XQChartExcelOutBlock1[] GetBlock1s()
		{
			XQChartExcelOutBlock1[] instance = XQChartExcelOutBlock1.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQChartExcelOutBlock),
			typeof(XQChartExcelOutBlock1),

		};

	}

}
