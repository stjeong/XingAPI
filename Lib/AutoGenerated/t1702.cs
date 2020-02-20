using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1702InBlock : XingBlock
	{
		/// <summary>
		/// t1702InBlock
		/// </summary>
		public const string _blockName = "t1702InBlock";
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
		/// t1702InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1702InBlock
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
		/// 종목코드
		/// </summary>
		[XAQueryFieldAttribute("shcode", "종목코드", "char", "6")]
		public string shcode;
		/// <summary>
		/// 종료일자
		/// </summary>
		[XAQueryFieldAttribute("todt", "종료일자", "char", "8")]
		public string todt;
		/// <summary>
		/// 금액수량구분(0:금액1:수량2:단가)
		/// </summary>
		[XAQueryFieldAttribute("volvalgb", "금액수량구분(0:금액1:수량2:단가)", "char", "1")]
		public char volvalgb;
		/// <summary>
		/// 매수매도구분(0:순매수1:매수2:매도)
		/// </summary>
		[XAQueryFieldAttribute("msmdgb", "매수매도구분(0:순매수1:매수2:매도)", "char", "1")]
		public char msmdgb;
		/// <summary>
		/// 누적구분(0:일간1:누적)
		/// </summary>
		[XAQueryFieldAttribute("cumulgb", "누적구분(0:일간1:누적)", "char", "1")]
		public char cumulgb;
		/// <summary>
		/// CTSDATE
		/// </summary>
		[XAQueryFieldAttribute("cts_date", "CTSDATE", "char", "8")]
		public string cts_date;
		/// <summary>
		/// CTSIDX
		/// </summary>
		[XAQueryFieldAttribute("cts_idx", "CTSIDX", "long", "4")]
		public long cts_idx;

		public static class F
		{
			/// <summary>
			/// 종목코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 종료일자
			/// </summary>
			public const string todt = "todt";
			/// <summary>
			/// 금액수량구분(0:금액1:수량2:단가)
			/// </summary>
			public const string volvalgb = "volvalgb";
			/// <summary>
			/// 매수매도구분(0:순매수1:매수2:매도)
			/// </summary>
			public const string msmdgb = "msmdgb";
			/// <summary>
			/// 누적구분(0:일간1:누적)
			/// </summary>
			public const string cumulgb = "cumulgb";
			/// <summary>
			/// CTSDATE
			/// </summary>
			public const string cts_date = "cts_date";
			/// <summary>
			/// CTSIDX
			/// </summary>
			public const string cts_idx = "cts_idx";
		}

		public static string[] AllFields = new string[]
		{
			F.shcode,
			F.todt,
			F.volvalgb,
			F.msmdgb,
			F.cumulgb,
			F.cts_date,
			F.cts_idx,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "종목코드", (decimal)6);
			dict["todt"] = new XAQueryFieldInfo("char", todt, todt, "종료일자", (decimal)8);
			dict["volvalgb"] = new XAQueryFieldInfo("char", volvalgb, volvalgb.ToString(), "금액수량구분(0:금액1:수량2:단가)", (decimal)1);
			dict["msmdgb"] = new XAQueryFieldInfo("char", msmdgb, msmdgb.ToString(), "매수매도구분(0:순매수1:매수2:매도)", (decimal)1);
			dict["cumulgb"] = new XAQueryFieldInfo("char", cumulgb, cumulgb.ToString(), "누적구분(0:일간1:누적)", (decimal)1);
			dict["cts_date"] = new XAQueryFieldInfo("char", cts_date, cts_date, "CTSDATE", (decimal)8);
			dict["cts_idx"] = new XAQueryFieldInfo("long", cts_idx, cts_idx.ToString("d4"), "CTSIDX", (decimal)4);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "todt":
					this.todt = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "volvalgb":
					this.volvalgb = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "msmdgb":
					this.msmdgb = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "cumulgb":
					this.cumulgb = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "cts_date":
					this.cts_date = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cts_idx":
					this.cts_idx = fieldInfo.FieldValue.ParseLong("cts_idx");
				break;


			}
		}

		public bool VerifyData()
		{
			if (shcode?.Length > 6) return false; // char 6
			if (todt?.Length > 8) return false; // char 8
			// volvalgb char 1
			// msmdgb char 1
			// cumulgb char 1
			if (cts_date?.Length > 8) return false; // char 8
			if (cts_idx.ToString().Length > 4) return false; // long 4

			return true;
		}
	}

	public partial class XQt1702OutBlock : XingBlock
	{
		/// <summary>
		/// t1702OutBlock
		/// </summary>
		public const string _blockName = "t1702OutBlock";
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
		/// t1702OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1702OutBlock
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
		/// CTSIDX
		/// </summary>
		[XAQueryFieldAttribute("cts_idx", "CTSIDX", "long", "4")]
		public long cts_idx;
		/// <summary>
		/// CTSDATE
		/// </summary>
		[XAQueryFieldAttribute("cts_date", "CTSDATE", "char", "8")]
		public string cts_date;

		public static class F
		{
			/// <summary>
			/// CTSIDX
			/// </summary>
			public const string cts_idx = "cts_idx";
			/// <summary>
			/// CTSDATE
			/// </summary>
			public const string cts_date = "cts_date";
		}

		public static string[] AllFields = new string[]
		{
			F.cts_idx,
			F.cts_date,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["cts_idx"] = new XAQueryFieldInfo("long", cts_idx, cts_idx.ToString("d4"), "CTSIDX", (decimal)4);
			dict["cts_date"] = new XAQueryFieldInfo("char", cts_date, cts_date, "CTSDATE", (decimal)8);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "cts_idx":
					this.cts_idx = fieldInfo.FieldValue.ParseLong("cts_idx");
				break;

				case "cts_date":
					this.cts_date = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt1702OutBlock FromQuery(XQt1702 query)
		{
			XQt1702OutBlock block = new XQt1702OutBlock();
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
				block.cts_idx = query.GetFieldData(block.GetBlockName(), "cts_idx", 0).ParseLong("cts_idx"); // long 4
				block.cts_date = query.GetFieldData(block.GetBlockName(), "cts_date", 0).TrimEnd('?'); // char 8

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (cts_idx.ToString().Length > 4) return false; // long 4
			if (cts_date?.Length > 8) return false; // char 8

			return true;
		}
	}

	public partial class XQt1702OutBlock1 : XingBlock
	{
		/// <summary>
		/// t1702OutBlock1
		/// </summary>
		public const string _blockName = "t1702OutBlock1";
		/// <summary>
		/// 출력
		/// </summary>
		public const string _blockDesc = "출력";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// true
		/// </summary>
		public const bool _hasOccurs = true;
		/// <summary>
		/// t1702OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1702OutBlock1
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// 출력
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
		[XAQueryFieldAttribute("date", "일자", "char", "8")]
		public string date;
		/// <summary>
		/// 종가
		/// </summary>
		[XAQueryFieldAttribute("close", "종가", "long", "8")]
		public long close;
		/// <summary>
		/// 전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("sign", "전일대비구분", "char", "1")]
		public char sign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[XAQueryFieldAttribute("change", "전일대비", "long", "8")]
		public long change;
		/// <summary>
		/// 등락율
		/// </summary>
		[XAQueryFieldAttribute("diff", "등락율", "float", "6.2")]
		public float diff;
		/// <summary>
		/// 누적거래량
		/// </summary>
		[XAQueryFieldAttribute("volume", "누적거래량", "long", "12")]
		public long volume;
		/// <summary>
		/// 사모펀드
		/// </summary>
		[XAQueryFieldAttribute("amt0000", "사모펀드", "long", "12")]
		public long amt0000;
		/// <summary>
		/// 증권
		/// </summary>
		[XAQueryFieldAttribute("amt0001", "증권", "long", "12")]
		public long amt0001;
		/// <summary>
		/// 보험
		/// </summary>
		[XAQueryFieldAttribute("amt0002", "보험", "long", "12")]
		public long amt0002;
		/// <summary>
		/// 투신
		/// </summary>
		[XAQueryFieldAttribute("amt0003", "투신", "long", "12")]
		public long amt0003;
		/// <summary>
		/// 은행
		/// </summary>
		[XAQueryFieldAttribute("amt0004", "은행", "long", "12")]
		public long amt0004;
		/// <summary>
		/// 종금
		/// </summary>
		[XAQueryFieldAttribute("amt0005", "종금", "long", "12")]
		public long amt0005;
		/// <summary>
		/// 기금
		/// </summary>
		[XAQueryFieldAttribute("amt0006", "기금", "long", "12")]
		public long amt0006;
		/// <summary>
		/// 기타법인
		/// </summary>
		[XAQueryFieldAttribute("amt0007", "기타법인", "long", "12")]
		public long amt0007;
		/// <summary>
		/// 개인
		/// </summary>
		[XAQueryFieldAttribute("amt0008", "개인", "long", "12")]
		public long amt0008;
		/// <summary>
		/// 등록외국인
		/// </summary>
		[XAQueryFieldAttribute("amt0009", "등록외국인", "long", "12")]
		public long amt0009;
		/// <summary>
		/// 미등록외국인
		/// </summary>
		[XAQueryFieldAttribute("amt0010", "미등록외국인", "long", "12")]
		public long amt0010;
		/// <summary>
		/// 국가외
		/// </summary>
		[XAQueryFieldAttribute("amt0011", "국가외", "long", "12")]
		public long amt0011;
		/// <summary>
		/// 기관
		/// </summary>
		[XAQueryFieldAttribute("amt0018", "기관", "long", "12")]
		public long amt0018;
		/// <summary>
		/// 외인계(등록+미등록)
		/// </summary>
		[XAQueryFieldAttribute("amt0088", "외인계(등록+미등록)", "long", "12")]
		public long amt0088;
		/// <summary>
		/// 기타계(기타+국가)
		/// </summary>
		[XAQueryFieldAttribute("amt0099", "기타계(기타+국가)", "long", "12")]
		public long amt0099;

		public static class F
		{
			/// <summary>
			/// 일자
			/// </summary>
			public const string date = "date";
			/// <summary>
			/// 종가
			/// </summary>
			public const string close = "close";
			/// <summary>
			/// 전일대비구분
			/// </summary>
			public const string sign = "sign";
			/// <summary>
			/// 전일대비
			/// </summary>
			public const string change = "change";
			/// <summary>
			/// 등락율
			/// </summary>
			public const string diff = "diff";
			/// <summary>
			/// 누적거래량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// 사모펀드
			/// </summary>
			public const string amt0000 = "amt0000";
			/// <summary>
			/// 증권
			/// </summary>
			public const string amt0001 = "amt0001";
			/// <summary>
			/// 보험
			/// </summary>
			public const string amt0002 = "amt0002";
			/// <summary>
			/// 투신
			/// </summary>
			public const string amt0003 = "amt0003";
			/// <summary>
			/// 은행
			/// </summary>
			public const string amt0004 = "amt0004";
			/// <summary>
			/// 종금
			/// </summary>
			public const string amt0005 = "amt0005";
			/// <summary>
			/// 기금
			/// </summary>
			public const string amt0006 = "amt0006";
			/// <summary>
			/// 기타법인
			/// </summary>
			public const string amt0007 = "amt0007";
			/// <summary>
			/// 개인
			/// </summary>
			public const string amt0008 = "amt0008";
			/// <summary>
			/// 등록외국인
			/// </summary>
			public const string amt0009 = "amt0009";
			/// <summary>
			/// 미등록외국인
			/// </summary>
			public const string amt0010 = "amt0010";
			/// <summary>
			/// 국가외
			/// </summary>
			public const string amt0011 = "amt0011";
			/// <summary>
			/// 기관
			/// </summary>
			public const string amt0018 = "amt0018";
			/// <summary>
			/// 외인계(등록+미등록)
			/// </summary>
			public const string amt0088 = "amt0088";
			/// <summary>
			/// 기타계(기타+국가)
			/// </summary>
			public const string amt0099 = "amt0099";
		}

		public static string[] AllFields = new string[]
		{
			F.date,
			F.close,
			F.sign,
			F.change,
			F.diff,
			F.volume,
			F.amt0000,
			F.amt0001,
			F.amt0002,
			F.amt0003,
			F.amt0004,
			F.amt0005,
			F.amt0006,
			F.amt0007,
			F.amt0008,
			F.amt0009,
			F.amt0010,
			F.amt0011,
			F.amt0018,
			F.amt0088,
			F.amt0099,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["date"] = new XAQueryFieldInfo("char", date, date, "일자", (decimal)8);
			dict["close"] = new XAQueryFieldInfo("long", close, close.ToString("d8"), "종가", (decimal)8);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("long", change, change.ToString("d8"), "전일대비", (decimal)8);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "누적거래량", (decimal)12);
			dict["amt0000"] = new XAQueryFieldInfo("long", amt0000, amt0000.ToString("d12"), "사모펀드", (decimal)12);
			dict["amt0001"] = new XAQueryFieldInfo("long", amt0001, amt0001.ToString("d12"), "증권", (decimal)12);
			dict["amt0002"] = new XAQueryFieldInfo("long", amt0002, amt0002.ToString("d12"), "보험", (decimal)12);
			dict["amt0003"] = new XAQueryFieldInfo("long", amt0003, amt0003.ToString("d12"), "투신", (decimal)12);
			dict["amt0004"] = new XAQueryFieldInfo("long", amt0004, amt0004.ToString("d12"), "은행", (decimal)12);
			dict["amt0005"] = new XAQueryFieldInfo("long", amt0005, amt0005.ToString("d12"), "종금", (decimal)12);
			dict["amt0006"] = new XAQueryFieldInfo("long", amt0006, amt0006.ToString("d12"), "기금", (decimal)12);
			dict["amt0007"] = new XAQueryFieldInfo("long", amt0007, amt0007.ToString("d12"), "기타법인", (decimal)12);
			dict["amt0008"] = new XAQueryFieldInfo("long", amt0008, amt0008.ToString("d12"), "개인", (decimal)12);
			dict["amt0009"] = new XAQueryFieldInfo("long", amt0009, amt0009.ToString("d12"), "등록외국인", (decimal)12);
			dict["amt0010"] = new XAQueryFieldInfo("long", amt0010, amt0010.ToString("d12"), "미등록외국인", (decimal)12);
			dict["amt0011"] = new XAQueryFieldInfo("long", amt0011, amt0011.ToString("d12"), "국가외", (decimal)12);
			dict["amt0018"] = new XAQueryFieldInfo("long", amt0018, amt0018.ToString("d12"), "기관", (decimal)12);
			dict["amt0088"] = new XAQueryFieldInfo("long", amt0088, amt0088.ToString("d12"), "외인계(등록+미등록)", (decimal)12);
			dict["amt0099"] = new XAQueryFieldInfo("long", amt0099, amt0099.ToString("d12"), "기타계(기타+국가)", (decimal)12);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "date":
					this.date = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "close":
					this.close = fieldInfo.FieldValue.ParseLong("close");
				break;

				case "sign":
					this.sign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "change":
					this.change = fieldInfo.FieldValue.ParseLong("change");
				break;

				case "diff":
					this.diff = fieldInfo.FieldValue.ParseFloat("diff");
				break;

				case "volume":
					this.volume = fieldInfo.FieldValue.ParseLong("volume");
				break;

				case "amt0000":
					this.amt0000 = fieldInfo.FieldValue.ParseLong("amt0000");
				break;

				case "amt0001":
					this.amt0001 = fieldInfo.FieldValue.ParseLong("amt0001");
				break;

				case "amt0002":
					this.amt0002 = fieldInfo.FieldValue.ParseLong("amt0002");
				break;

				case "amt0003":
					this.amt0003 = fieldInfo.FieldValue.ParseLong("amt0003");
				break;

				case "amt0004":
					this.amt0004 = fieldInfo.FieldValue.ParseLong("amt0004");
				break;

				case "amt0005":
					this.amt0005 = fieldInfo.FieldValue.ParseLong("amt0005");
				break;

				case "amt0006":
					this.amt0006 = fieldInfo.FieldValue.ParseLong("amt0006");
				break;

				case "amt0007":
					this.amt0007 = fieldInfo.FieldValue.ParseLong("amt0007");
				break;

				case "amt0008":
					this.amt0008 = fieldInfo.FieldValue.ParseLong("amt0008");
				break;

				case "amt0009":
					this.amt0009 = fieldInfo.FieldValue.ParseLong("amt0009");
				break;

				case "amt0010":
					this.amt0010 = fieldInfo.FieldValue.ParseLong("amt0010");
				break;

				case "amt0011":
					this.amt0011 = fieldInfo.FieldValue.ParseLong("amt0011");
				break;

				case "amt0018":
					this.amt0018 = fieldInfo.FieldValue.ParseLong("amt0018");
				break;

				case "amt0088":
					this.amt0088 = fieldInfo.FieldValue.ParseLong("amt0088");
				break;

				case "amt0099":
					this.amt0099 = fieldInfo.FieldValue.ParseLong("amt0099");
				break;


			}
		}

		public static XQt1702OutBlock1[] ListFromQuery(XQt1702 query)
		{
			int count = query.GetBlockCount(XQt1702OutBlock1.BlockName);
			List<XQt1702OutBlock1> list = new List<XQt1702OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1702OutBlock1 block = new XQt1702OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.date = query.GetFieldData(block.GetBlockName(), "date", i).TrimEnd('?'); // char 8
					block.close = query.GetFieldData(block.GetBlockName(), "close", i).ParseLong("close"); // long 8
					block.sign = query.GetFieldData(block.GetBlockName(), "sign", i).FirstOrDefault(); // char 1
					block.change = query.GetFieldData(block.GetBlockName(), "change", i).ParseLong("change"); // long 8
					block.diff = query.GetFieldData(block.GetBlockName(), "diff", i).ParseFloat("diff"); // float 6.2
					block.volume = query.GetFieldData(block.GetBlockName(), "volume", i).ParseLong("volume"); // long 12
					block.amt0000 = query.GetFieldData(block.GetBlockName(), "amt0000", i).ParseLong("amt0000"); // long 12
					block.amt0001 = query.GetFieldData(block.GetBlockName(), "amt0001", i).ParseLong("amt0001"); // long 12
					block.amt0002 = query.GetFieldData(block.GetBlockName(), "amt0002", i).ParseLong("amt0002"); // long 12
					block.amt0003 = query.GetFieldData(block.GetBlockName(), "amt0003", i).ParseLong("amt0003"); // long 12
					block.amt0004 = query.GetFieldData(block.GetBlockName(), "amt0004", i).ParseLong("amt0004"); // long 12
					block.amt0005 = query.GetFieldData(block.GetBlockName(), "amt0005", i).ParseLong("amt0005"); // long 12
					block.amt0006 = query.GetFieldData(block.GetBlockName(), "amt0006", i).ParseLong("amt0006"); // long 12
					block.amt0007 = query.GetFieldData(block.GetBlockName(), "amt0007", i).ParseLong("amt0007"); // long 12
					block.amt0008 = query.GetFieldData(block.GetBlockName(), "amt0008", i).ParseLong("amt0008"); // long 12
					block.amt0009 = query.GetFieldData(block.GetBlockName(), "amt0009", i).ParseLong("amt0009"); // long 12
					block.amt0010 = query.GetFieldData(block.GetBlockName(), "amt0010", i).ParseLong("amt0010"); // long 12
					block.amt0011 = query.GetFieldData(block.GetBlockName(), "amt0011", i).ParseLong("amt0011"); // long 12
					block.amt0018 = query.GetFieldData(block.GetBlockName(), "amt0018", i).ParseLong("amt0018"); // long 12
					block.amt0088 = query.GetFieldData(block.GetBlockName(), "amt0088", i).ParseLong("amt0088"); // long 12
					block.amt0099 = query.GetFieldData(block.GetBlockName(), "amt0099", i).ParseLong("amt0099"); // long 12

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
			if (close.ToString().Length > 8) return false; // long 8
			// sign char 1
			if (change.ToString().Length > 8) return false; // long 8
			// diff float 6.2
			if (volume.ToString().Length > 12) return false; // long 12
			if (amt0000.ToString().Length > 12) return false; // long 12
			if (amt0001.ToString().Length > 12) return false; // long 12
			if (amt0002.ToString().Length > 12) return false; // long 12
			if (amt0003.ToString().Length > 12) return false; // long 12
			if (amt0004.ToString().Length > 12) return false; // long 12
			if (amt0005.ToString().Length > 12) return false; // long 12
			if (amt0006.ToString().Length > 12) return false; // long 12
			if (amt0007.ToString().Length > 12) return false; // long 12
			if (amt0008.ToString().Length > 12) return false; // long 12
			if (amt0009.ToString().Length > 12) return false; // long 12
			if (amt0010.ToString().Length > 12) return false; // long 12
			if (amt0011.ToString().Length > 12) return false; // long 12
			if (amt0018.ToString().Length > 12) return false; // long 12
			if (amt0088.ToString().Length > 12) return false; // long 12
			if (amt0099.ToString().Length > 12) return false; // long 12

			return true;
		}
	}

	/// <summary>
	/// 외인기관종목별동향(t1702)
	/// </summary>
	public partial class XQt1702 : XingQuery
	{
		/// <summary>
		/// t1702
		/// </summary>
		public const string _typeName = "t1702";
		/// <summary>
		/// 외인기관종목별동향(t1702)
		/// </summary>
		public const string _typeDesc = "외인기관종목별동향(t1702)";
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
		/// t1702
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 외인기관종목별동향(t1702)
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
		/// 외인기관종목별동향(t1702)
		/// </summary>
		public XQt1702() : base("t1702") { }


		public class XQAllOutBlocks
		{
			public XQt1702OutBlock OutBlock { get; internal set; }
			public XQt1702OutBlock1[] OutBlock1 { get; internal set; }
		}

		public static XQAllOutBlocks Get(string shcode = default,string todt = default,char volvalgb = default,char msmdgb = default,char cumulgb = default,string cts_date = default,long cts_idx = default)
		{
			using (XQt1702 instance = new XQt1702())
			{
				instance.SetFieldData(XQt1702InBlock.BlockName, XQt1702InBlock.F.shcode, 0, shcode); // char 6
				instance.SetFieldData(XQt1702InBlock.BlockName, XQt1702InBlock.F.todt, 0, todt); // char 8
				instance.SetFieldData(XQt1702InBlock.BlockName, XQt1702InBlock.F.volvalgb, 0, volvalgb.ToString()); // char 1
				instance.SetFieldData(XQt1702InBlock.BlockName, XQt1702InBlock.F.msmdgb, 0, msmdgb.ToString()); // char 1
				instance.SetFieldData(XQt1702InBlock.BlockName, XQt1702InBlock.F.cumulgb, 0, cumulgb.ToString()); // char 1
				instance.SetFieldData(XQt1702InBlock.BlockName, XQt1702InBlock.F.cts_date, 0, cts_date); // char 8
				instance.SetFieldData(XQt1702InBlock.BlockName, XQt1702InBlock.F.cts_idx, 0, cts_idx.ToString("d4")); // long 4

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

		public static XQAllOutBlocks ReadFromDB(string tableNamePostfix = null /*, string shcode = default,string todt = default,char volvalgb = default,char msmdgb = default,char cumulgb = default,string cts_date = default,long cts_idx = default */)
		{
			using (XQt1702 instance = new XQt1702())
			{

				XQAllOutBlocks results = new XQAllOutBlocks();

				string tableName = (tableNamePostfix == null) ? "XQt1702OutBlock" : $"XQt1702OutBlock_{tableNamePostfix}";
				QueryOption qo = new QueryOption(tableName);
				results.OutBlock = instance.Select<XQt1702OutBlock>(qo);

				tableName = (tableNamePostfix == null) ? "XQt1702OutBlock1" : $"XQt1702OutBlock1_{tableNamePostfix}";
				qo = new QueryOption(tableName);
				results.OutBlock1 = instance.SelectMany<XQt1702OutBlock1>(qo);
				return results;
			}
		}

		public bool SetBlock(XQt1702InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "shcode", 0, block.shcode); // char 6
			_xaQuery.SetFieldData(block.GetBlockName(), "todt", 0, block.todt); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "volvalgb", 0, block.volvalgb.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "msmdgb", 0, block.msmdgb.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "cumulgb", 0, block.cumulgb.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "cts_date", 0, block.cts_date); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "cts_idx", 0, block.cts_idx.ToString("d4")); // long 4

			return true;
		}

		public XQt1702OutBlock GetBlock()
		{
			XQt1702OutBlock instance = XQt1702OutBlock.FromQuery(this);
			return instance;

		}

		public XQt1702OutBlock1[] GetBlock1s()
		{
			XQt1702OutBlock1[] instance = XQt1702OutBlock1.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt1702OutBlock),
			typeof(XQt1702OutBlock1),

		};

	}

}
