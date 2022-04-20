using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1514InBlock : XingBlock
	{
		/// <summary>
		/// t1514InBlock
		/// </summary>
		public const string _blockName = "t1514InBlock";
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
		/// t1514InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1514InBlock
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
		/// 업종코드
		/// </summary>
		[XAQueryFieldAttribute("upcode", "업종코드", "char", "3")]
		public string upcode;
		/// <summary>
		/// 구분1
		/// </summary>
		[XAQueryFieldAttribute("gubun1", "구분1", "char", "1")]
		public char gubun1;
		/// <summary>
		/// 구분2
		/// </summary>
		[XAQueryFieldAttribute("gubun2", "구분2", "char", "1")]
		public char gubun2;
		/// <summary>
		/// CTS_일자
		/// </summary>
		[XAQueryFieldAttribute("cts_date", "CTS_일자", "char", "8")]
		public string cts_date;
		/// <summary>
		/// 조회건수
		/// </summary>
		[XAQueryFieldAttribute("cnt", "조회건수", "int", "4")]
		public int cnt;
		/// <summary>
		/// 비중구분
		/// </summary>
		[XAQueryFieldAttribute("rate_gbn", "비중구분", "char", "1")]
		public char rate_gbn;

		public static class F
		{
			/// <summary>
			/// 업종코드
			/// </summary>
			public const string upcode = "upcode";
			/// <summary>
			/// 구분1
			/// </summary>
			public const string gubun1 = "gubun1";
			/// <summary>
			/// 구분2
			/// </summary>
			public const string gubun2 = "gubun2";
			/// <summary>
			/// CTS_일자
			/// </summary>
			public const string cts_date = "cts_date";
			/// <summary>
			/// 조회건수
			/// </summary>
			public const string cnt = "cnt";
			/// <summary>
			/// 비중구분
			/// </summary>
			public const string rate_gbn = "rate_gbn";
		}

		public static string[] AllFields = new string[]
		{
			F.upcode,
			F.gubun1,
			F.gubun2,
			F.cts_date,
			F.cnt,
			F.rate_gbn,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["upcode"] = new XAQueryFieldInfo("char", upcode, upcode, "업종코드", (decimal)3);
			dict["gubun1"] = new XAQueryFieldInfo("char", gubun1, gubun1.ToString(), "구분1", (decimal)1);
			dict["gubun2"] = new XAQueryFieldInfo("char", gubun2, gubun2.ToString(), "구분2", (decimal)1);
			dict["cts_date"] = new XAQueryFieldInfo("char", cts_date, cts_date, "CTS_일자", (decimal)8);
			dict["cnt"] = new XAQueryFieldInfo("int", cnt, cnt.ToString("d4"), "조회건수", (decimal)4);
			dict["rate_gbn"] = new XAQueryFieldInfo("char", rate_gbn, rate_gbn.ToString(), "비중구분", (decimal)1);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "upcode":
					this.upcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "gubun1":
					this.gubun1 = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "gubun2":
					this.gubun2 = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "cts_date":
					this.cts_date = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cnt":
					this.cnt = fieldInfo.FieldValue.ParseInt("cnt");
				break;

				case "rate_gbn":
					this.rate_gbn = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public bool VerifyData()
		{
			if (upcode?.Length > 3) return false; // char 3
			// gubun1 char 1
			// gubun2 char 1
			if (cts_date?.Length > 8) return false; // char 8
			// cnt int 4
			// rate_gbn char 1

			return true;
		}

		public void CopyTo(XQt1514InBlock block)
		{
			block.upcode = this.upcode;
			block.gubun1 = this.gubun1;
			block.gubun2 = this.gubun2;
			block.cts_date = this.cts_date;
			block.cnt = this.cnt;
			block.rate_gbn = this.rate_gbn;

		}
	}

	public partial class XQt1514OutBlock : XingBlock
	{
		/// <summary>
		/// t1514OutBlock
		/// </summary>
		public const string _blockName = "t1514OutBlock";
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
		/// t1514OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1514OutBlock
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
		/// CTS_일자
		/// </summary>
		[XAQueryFieldAttribute("cts_date", "CTS_일자", "char", "8")]
		public string cts_date;

		public static class F
		{
			/// <summary>
			/// CTS_일자
			/// </summary>
			public const string cts_date = "cts_date";
		}

		public static string[] AllFields = new string[]
		{
			F.cts_date,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["cts_date"] = new XAQueryFieldInfo("char", cts_date, cts_date, "CTS_일자", (decimal)8);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "cts_date":
					this.cts_date = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt1514OutBlock FromQuery(XQt1514 query)
		{
			XQt1514OutBlock block = new XQt1514OutBlock();
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

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (cts_date?.Length > 8) return false; // char 8

			return true;
		}

		public void CopyTo(XQt1514OutBlock block)
		{
			block.cts_date = this.cts_date;

		}
	}

	public partial class XQt1514OutBlock1 : XingBlock
	{
		/// <summary>
		/// t1514OutBlock1
		/// </summary>
		public const string _blockName = "t1514OutBlock1";
		/// <summary>
		/// 기본출력1
		/// </summary>
		public const string _blockDesc = "기본출력1";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// true
		/// </summary>
		public const bool _hasOccurs = true;
		/// <summary>
		/// t1514OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1514OutBlock1
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// 기본출력1
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
		/// 지수
		/// </summary>
		[XAQueryFieldAttribute("jisu", "지수", "float", "12.2")]
		public float jisu;
		/// <summary>
		/// 전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("sign", "전일대비구분", "char", "1")]
		public char sign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[XAQueryFieldAttribute("change", "전일대비", "float", "7.2")]
		public float change;
		/// <summary>
		/// 등락율
		/// </summary>
		[XAQueryFieldAttribute("diff", "등락율", "float", "6.2")]
		public float diff;
		/// <summary>
		/// 거래량
		/// </summary>
		[XAQueryFieldAttribute("volume", "거래량", "long", "12")]
		public long volume;
		/// <summary>
		/// 거래증가율
		/// </summary>
		[XAQueryFieldAttribute("diff_vol", "거래증가율", "float", "12.2")]
		public float diff_vol;
		/// <summary>
		/// 거래대금1
		/// </summary>
		[XAQueryFieldAttribute("value1", "거래대금1", "long", "12")]
		public long value1;
		/// <summary>
		/// 상승
		/// </summary>
		[XAQueryFieldAttribute("high", "상승", "long", "4")]
		public long high;
		/// <summary>
		/// 보합
		/// </summary>
		[XAQueryFieldAttribute("unchg", "보합", "long", "4")]
		public long unchg;
		/// <summary>
		/// 하락
		/// </summary>
		[XAQueryFieldAttribute("low", "하락", "long", "4")]
		public long low;
		/// <summary>
		/// 상승종목비율
		/// </summary>
		[XAQueryFieldAttribute("uprate", "상승종목비율", "float", "6.2")]
		public float uprate;
		/// <summary>
		/// 외인순매수
		/// </summary>
		[XAQueryFieldAttribute("frgsvolume", "외인순매수", "long", "8")]
		public long frgsvolume;
		/// <summary>
		/// 시가
		/// </summary>
		[XAQueryFieldAttribute("openjisu", "시가", "float", "12.2")]
		public float openjisu;
		/// <summary>
		/// 고가
		/// </summary>
		[XAQueryFieldAttribute("highjisu", "고가", "float", "12.2")]
		public float highjisu;
		/// <summary>
		/// 저가
		/// </summary>
		[XAQueryFieldAttribute("lowjisu", "저가", "float", "12.2")]
		public float lowjisu;
		/// <summary>
		/// 거래대금2
		/// </summary>
		[XAQueryFieldAttribute("value2", "거래대금2", "long", "12")]
		public long value2;
		/// <summary>
		/// 상한
		/// </summary>
		[XAQueryFieldAttribute("up", "상한", "long", "4")]
		public long up;
		/// <summary>
		/// 하한
		/// </summary>
		[XAQueryFieldAttribute("down", "하한", "long", "4")]
		public long down;
		/// <summary>
		/// 종목수
		/// </summary>
		[XAQueryFieldAttribute("totjo", "종목수", "long", "4")]
		public long totjo;
		/// <summary>
		/// 기관순매수
		/// </summary>
		[XAQueryFieldAttribute("orgsvolume", "기관순매수", "long", "8")]
		public long orgsvolume;
		/// <summary>
		/// 업종코드
		/// </summary>
		[XAQueryFieldAttribute("upcode", "업종코드", "char", "3")]
		public string upcode;
		/// <summary>
		/// 거래비중
		/// </summary>
		[XAQueryFieldAttribute("rate", "거래비중", "float", "7.2")]
		public float rate;
		/// <summary>
		/// 업종배당수익률
		/// </summary>
		[XAQueryFieldAttribute("divrate", "업종배당수익률", "float", "7.2")]
		public float divrate;

		public static class F
		{
			/// <summary>
			/// 일자
			/// </summary>
			public const string date = "date";
			/// <summary>
			/// 지수
			/// </summary>
			public const string jisu = "jisu";
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
			/// 거래량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// 거래증가율
			/// </summary>
			public const string diff_vol = "diff_vol";
			/// <summary>
			/// 거래대금1
			/// </summary>
			public const string value1 = "value1";
			/// <summary>
			/// 상승
			/// </summary>
			public const string high = "high";
			/// <summary>
			/// 보합
			/// </summary>
			public const string unchg = "unchg";
			/// <summary>
			/// 하락
			/// </summary>
			public const string low = "low";
			/// <summary>
			/// 상승종목비율
			/// </summary>
			public const string uprate = "uprate";
			/// <summary>
			/// 외인순매수
			/// </summary>
			public const string frgsvolume = "frgsvolume";
			/// <summary>
			/// 시가
			/// </summary>
			public const string openjisu = "openjisu";
			/// <summary>
			/// 고가
			/// </summary>
			public const string highjisu = "highjisu";
			/// <summary>
			/// 저가
			/// </summary>
			public const string lowjisu = "lowjisu";
			/// <summary>
			/// 거래대금2
			/// </summary>
			public const string value2 = "value2";
			/// <summary>
			/// 상한
			/// </summary>
			public const string up = "up";
			/// <summary>
			/// 하한
			/// </summary>
			public const string down = "down";
			/// <summary>
			/// 종목수
			/// </summary>
			public const string totjo = "totjo";
			/// <summary>
			/// 기관순매수
			/// </summary>
			public const string orgsvolume = "orgsvolume";
			/// <summary>
			/// 업종코드
			/// </summary>
			public const string upcode = "upcode";
			/// <summary>
			/// 거래비중
			/// </summary>
			public const string rate = "rate";
			/// <summary>
			/// 업종배당수익률
			/// </summary>
			public const string divrate = "divrate";
		}

		public static string[] AllFields = new string[]
		{
			F.date,
			F.jisu,
			F.sign,
			F.change,
			F.diff,
			F.volume,
			F.diff_vol,
			F.value1,
			F.high,
			F.unchg,
			F.low,
			F.uprate,
			F.frgsvolume,
			F.openjisu,
			F.highjisu,
			F.lowjisu,
			F.value2,
			F.up,
			F.down,
			F.totjo,
			F.orgsvolume,
			F.upcode,
			F.rate,
			F.divrate,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["date"] = new XAQueryFieldInfo("char", date, date, "일자", (decimal)8);
			dict["jisu"] = new XAQueryFieldInfo("float", jisu, jisu.ToString("000000000000.00"), "지수", (decimal)12.2);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("float", change, change.ToString("0000000.00"), "전일대비", (decimal)7.2);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "거래량", (decimal)12);
			dict["diff_vol"] = new XAQueryFieldInfo("float", diff_vol, diff_vol.ToString("000000000000.00"), "거래증가율", (decimal)12.2);
			dict["value1"] = new XAQueryFieldInfo("long", value1, value1.ToString("d12"), "거래대금1", (decimal)12);
			dict["high"] = new XAQueryFieldInfo("long", high, high.ToString("d4"), "상승", (decimal)4);
			dict["unchg"] = new XAQueryFieldInfo("long", unchg, unchg.ToString("d4"), "보합", (decimal)4);
			dict["low"] = new XAQueryFieldInfo("long", low, low.ToString("d4"), "하락", (decimal)4);
			dict["uprate"] = new XAQueryFieldInfo("float", uprate, uprate.ToString("000000.00"), "상승종목비율", (decimal)6.2);
			dict["frgsvolume"] = new XAQueryFieldInfo("long", frgsvolume, frgsvolume.ToString("d8"), "외인순매수", (decimal)8);
			dict["openjisu"] = new XAQueryFieldInfo("float", openjisu, openjisu.ToString("000000000000.00"), "시가", (decimal)12.2);
			dict["highjisu"] = new XAQueryFieldInfo("float", highjisu, highjisu.ToString("000000000000.00"), "고가", (decimal)12.2);
			dict["lowjisu"] = new XAQueryFieldInfo("float", lowjisu, lowjisu.ToString("000000000000.00"), "저가", (decimal)12.2);
			dict["value2"] = new XAQueryFieldInfo("long", value2, value2.ToString("d12"), "거래대금2", (decimal)12);
			dict["up"] = new XAQueryFieldInfo("long", up, up.ToString("d4"), "상한", (decimal)4);
			dict["down"] = new XAQueryFieldInfo("long", down, down.ToString("d4"), "하한", (decimal)4);
			dict["totjo"] = new XAQueryFieldInfo("long", totjo, totjo.ToString("d4"), "종목수", (decimal)4);
			dict["orgsvolume"] = new XAQueryFieldInfo("long", orgsvolume, orgsvolume.ToString("d8"), "기관순매수", (decimal)8);
			dict["upcode"] = new XAQueryFieldInfo("char", upcode, upcode, "업종코드", (decimal)3);
			dict["rate"] = new XAQueryFieldInfo("float", rate, rate.ToString("0000000.00"), "거래비중", (decimal)7.2);
			dict["divrate"] = new XAQueryFieldInfo("float", divrate, divrate.ToString("0000000.00"), "업종배당수익률", (decimal)7.2);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "date":
					this.date = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "jisu":
					this.jisu = fieldInfo.FieldValue.ParseFloat("jisu");
				break;

				case "sign":
					this.sign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "change":
					this.change = fieldInfo.FieldValue.ParseFloat("change");
				break;

				case "diff":
					this.diff = fieldInfo.FieldValue.ParseFloat("diff");
				break;

				case "volume":
					this.volume = fieldInfo.FieldValue.ParseLong("volume");
				break;

				case "diff_vol":
					this.diff_vol = fieldInfo.FieldValue.ParseFloat("diff_vol");
				break;

				case "value1":
					this.value1 = fieldInfo.FieldValue.ParseLong("value1");
				break;

				case "high":
					this.high = fieldInfo.FieldValue.ParseLong("high");
				break;

				case "unchg":
					this.unchg = fieldInfo.FieldValue.ParseLong("unchg");
				break;

				case "low":
					this.low = fieldInfo.FieldValue.ParseLong("low");
				break;

				case "uprate":
					this.uprate = fieldInfo.FieldValue.ParseFloat("uprate");
				break;

				case "frgsvolume":
					this.frgsvolume = fieldInfo.FieldValue.ParseLong("frgsvolume");
				break;

				case "openjisu":
					this.openjisu = fieldInfo.FieldValue.ParseFloat("openjisu");
				break;

				case "highjisu":
					this.highjisu = fieldInfo.FieldValue.ParseFloat("highjisu");
				break;

				case "lowjisu":
					this.lowjisu = fieldInfo.FieldValue.ParseFloat("lowjisu");
				break;

				case "value2":
					this.value2 = fieldInfo.FieldValue.ParseLong("value2");
				break;

				case "up":
					this.up = fieldInfo.FieldValue.ParseLong("up");
				break;

				case "down":
					this.down = fieldInfo.FieldValue.ParseLong("down");
				break;

				case "totjo":
					this.totjo = fieldInfo.FieldValue.ParseLong("totjo");
				break;

				case "orgsvolume":
					this.orgsvolume = fieldInfo.FieldValue.ParseLong("orgsvolume");
				break;

				case "upcode":
					this.upcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "rate":
					this.rate = fieldInfo.FieldValue.ParseFloat("rate");
				break;

				case "divrate":
					this.divrate = fieldInfo.FieldValue.ParseFloat("divrate");
				break;


			}
		}

		public static XQt1514OutBlock1[] ListFromQuery(XQt1514 query)
		{
			int count = query.GetBlockCount(XQt1514OutBlock1.BlockName);
			List<XQt1514OutBlock1> list = new List<XQt1514OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1514OutBlock1 block = new XQt1514OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.date = query.GetFieldData(block.GetBlockName(), "date", i).TrimEnd('?'); // char 8
					block.jisu = query.GetFieldData(block.GetBlockName(), "jisu", i).ParseFloat("jisu"); // float 12.2
					block.sign = query.GetFieldData(block.GetBlockName(), "sign", i).FirstOrDefault(); // char 1
					block.change = query.GetFieldData(block.GetBlockName(), "change", i).ParseFloat("change"); // float 7.2
					block.diff = query.GetFieldData(block.GetBlockName(), "diff", i).ParseFloat("diff"); // float 6.2
					block.volume = query.GetFieldData(block.GetBlockName(), "volume", i).ParseLong("volume"); // long 12
					block.diff_vol = query.GetFieldData(block.GetBlockName(), "diff_vol", i).ParseFloat("diff_vol"); // float 12.2
					block.value1 = query.GetFieldData(block.GetBlockName(), "value1", i).ParseLong("value1"); // long 12
					block.high = query.GetFieldData(block.GetBlockName(), "high", i).ParseLong("high"); // long 4
					block.unchg = query.GetFieldData(block.GetBlockName(), "unchg", i).ParseLong("unchg"); // long 4
					block.low = query.GetFieldData(block.GetBlockName(), "low", i).ParseLong("low"); // long 4
					block.uprate = query.GetFieldData(block.GetBlockName(), "uprate", i).ParseFloat("uprate"); // float 6.2
					block.frgsvolume = query.GetFieldData(block.GetBlockName(), "frgsvolume", i).ParseLong("frgsvolume"); // long 8
					block.openjisu = query.GetFieldData(block.GetBlockName(), "openjisu", i).ParseFloat("openjisu"); // float 12.2
					block.highjisu = query.GetFieldData(block.GetBlockName(), "highjisu", i).ParseFloat("highjisu"); // float 12.2
					block.lowjisu = query.GetFieldData(block.GetBlockName(), "lowjisu", i).ParseFloat("lowjisu"); // float 12.2
					block.value2 = query.GetFieldData(block.GetBlockName(), "value2", i).ParseLong("value2"); // long 12
					block.up = query.GetFieldData(block.GetBlockName(), "up", i).ParseLong("up"); // long 4
					block.down = query.GetFieldData(block.GetBlockName(), "down", i).ParseLong("down"); // long 4
					block.totjo = query.GetFieldData(block.GetBlockName(), "totjo", i).ParseLong("totjo"); // long 4
					block.orgsvolume = query.GetFieldData(block.GetBlockName(), "orgsvolume", i).ParseLong("orgsvolume"); // long 8
					block.upcode = query.GetFieldData(block.GetBlockName(), "upcode", i).TrimEnd('?'); // char 3
					block.rate = query.GetFieldData(block.GetBlockName(), "rate", i).ParseFloat("rate"); // float 7.2
					block.divrate = query.GetFieldData(block.GetBlockName(), "divrate", i).ParseFloat("divrate"); // float 7.2

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
			// jisu float 12.2
			// sign char 1
			// change float 7.2
			// diff float 6.2
			if (volume.ToString().Length > 12) return false; // long 12
			// diff_vol float 12.2
			if (value1.ToString().Length > 12) return false; // long 12
			if (high.ToString().Length > 4) return false; // long 4
			if (unchg.ToString().Length > 4) return false; // long 4
			if (low.ToString().Length > 4) return false; // long 4
			// uprate float 6.2
			if (frgsvolume.ToString().Length > 8) return false; // long 8
			// openjisu float 12.2
			// highjisu float 12.2
			// lowjisu float 12.2
			if (value2.ToString().Length > 12) return false; // long 12
			if (up.ToString().Length > 4) return false; // long 4
			if (down.ToString().Length > 4) return false; // long 4
			if (totjo.ToString().Length > 4) return false; // long 4
			if (orgsvolume.ToString().Length > 8) return false; // long 8
			if (upcode?.Length > 3) return false; // char 3
			// rate float 7.2
			// divrate float 7.2

			return true;
		}

		public void CopyTo(XQt1514OutBlock1 block)
		{
			block.date = this.date;
			block.jisu = this.jisu;
			block.sign = this.sign;
			block.change = this.change;
			block.diff = this.diff;
			block.volume = this.volume;
			block.diff_vol = this.diff_vol;
			block.value1 = this.value1;
			block.high = this.high;
			block.unchg = this.unchg;
			block.low = this.low;
			block.uprate = this.uprate;
			block.frgsvolume = this.frgsvolume;
			block.openjisu = this.openjisu;
			block.highjisu = this.highjisu;
			block.lowjisu = this.lowjisu;
			block.value2 = this.value2;
			block.up = this.up;
			block.down = this.down;
			block.totjo = this.totjo;
			block.orgsvolume = this.orgsvolume;
			block.upcode = this.upcode;
			block.rate = this.rate;
			block.divrate = this.divrate;

		}
	}

	/// <summary>
	/// 업종기간별추이(t1514)
	/// </summary>
	public partial class XQt1514 : XingQuery
	{
		/// <summary>
		/// t1514
		/// </summary>
		public const string _typeName = "t1514";
		/// <summary>
		/// 업종기간별추이(t1514)
		/// </summary>
		public const string _typeDesc = "업종기간별추이(t1514)";
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
		/// t1514
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 업종기간별추이(t1514)
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
		/// 업종기간별추이(t1514)
		/// </summary>
		public XQt1514() : base("t1514") { }


		public class XQAllOutBlocks
		{
			public XQt1514OutBlock OutBlock { get; internal set; }
			public XQt1514OutBlock1[] OutBlock1 { get; internal set; }
		}

		public static XQAllOutBlocks Get(string upcode = default,char gubun1 = default,char gubun2 = default,string cts_date = default,int cnt = default,char rate_gbn = default)
		{
			using (XQt1514 instance = new XQt1514())
			{
				instance.SetFieldData(XQt1514InBlock.BlockName, XQt1514InBlock.F.upcode, 0, upcode); // char 3
				instance.SetFieldData(XQt1514InBlock.BlockName, XQt1514InBlock.F.gubun1, 0, gubun1.ToString()); // char 1
				instance.SetFieldData(XQt1514InBlock.BlockName, XQt1514InBlock.F.gubun2, 0, gubun2.ToString()); // char 1
				instance.SetFieldData(XQt1514InBlock.BlockName, XQt1514InBlock.F.cts_date, 0, cts_date); // char 8
				instance.SetFieldData(XQt1514InBlock.BlockName, XQt1514InBlock.F.cnt, 0, cnt.ToString("d4")); // int 4
				instance.SetFieldData(XQt1514InBlock.BlockName, XQt1514InBlock.F.rate_gbn, 0, rate_gbn.ToString()); // char 1

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

		public static XQAllOutBlocks ReadFromDB(string tableNamePostfix = null /*, string upcode = default,char gubun1 = default,char gubun2 = default,string cts_date = default,int cnt = default,char rate_gbn = default */)
		{
			using (XQt1514 instance = new XQt1514())
			{

				XQAllOutBlocks results = new XQAllOutBlocks();

				string tableName = (tableNamePostfix == null) ? "XQt1514OutBlock" : $"XQt1514OutBlock_{tableNamePostfix}";
				QueryOption qo = new QueryOption(tableName);
				results.OutBlock = instance.Select<XQt1514OutBlock>(qo);

				tableName = (tableNamePostfix == null) ? "XQt1514OutBlock1" : $"XQt1514OutBlock1_{tableNamePostfix}";
				qo = new QueryOption(tableName);
				results.OutBlock1 = instance.SelectMany<XQt1514OutBlock1>(qo);
				return results;
			}
		}

		public bool SetBlock(XQt1514InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "upcode", 0, block.upcode); // char 3
			_xaQuery.SetFieldData(block.GetBlockName(), "gubun1", 0, block.gubun1.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "gubun2", 0, block.gubun2.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "cts_date", 0, block.cts_date); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "cnt", 0, block.cnt.ToString("d4")); // int 4
			_xaQuery.SetFieldData(block.GetBlockName(), "rate_gbn", 0, block.rate_gbn.ToString()); // char 1

			return true;
		}

		public XQt1514OutBlock GetBlock()
		{
			XQt1514OutBlock instance = XQt1514OutBlock.FromQuery(this);
			return instance;

		}

		public XQt1514OutBlock1[] GetBlock1s()
		{
			XQt1514OutBlock1[] instance = XQt1514OutBlock1.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt1514OutBlock),
			typeof(XQt1514OutBlock1),

		};

	}

}
