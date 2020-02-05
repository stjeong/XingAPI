using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt2830InBlock : XingBlock
	{
		/// <summary>
		/// t2830InBlock
		/// </summary>
		public const string _blockName = "t2830InBlock";
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
		/// t2830InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t2830InBlock
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
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("단축코드")]
		public string focode;

		public static class F
		{
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string focode = "focode";
		}

		public static string[] AllFields = new string[]
		{
			F.focode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["focode"] = new XAQueryFieldInfo("char", focode, focode, "단축코드", (decimal)8);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "focode":
					this.focode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (focode?.Length > 8) return false; // char 8

			return true;
		}
	}

	public partial class XQt2830OutBlock : XingBlock
	{
		/// <summary>
		/// t2830OutBlock
		/// </summary>
		public const string _blockName = "t2830OutBlock";
		/// <summary>
		/// 출력
		/// </summary>
		public const string _blockDesc = "출력";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// false
		/// </summary>
		public const bool _hasOccurs = false;
		/// <summary>
		/// t2830OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t2830OutBlock
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
		/// false
		/// </summary>
		public bool HasOccurs => _hasOccurs;

		/// <summary>
		/// 한글명
		/// </summary>
		[XAQueryFieldAttribute("한글명")]
		public string hname;
		/// <summary>
		/// 현재가
		/// </summary>
		[XAQueryFieldAttribute("현재가")]
		public float price;
		/// <summary>
		/// 전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("전일대비구분")]
		public char sign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[XAQueryFieldAttribute("전일대비")]
		public float change;
		/// <summary>
		/// 전일종가
		/// </summary>
		[XAQueryFieldAttribute("전일종가")]
		public float jnilclose;
		/// <summary>
		/// 등락율
		/// </summary>
		[XAQueryFieldAttribute("등락율")]
		public float diff;
		/// <summary>
		/// 거래량
		/// </summary>
		[XAQueryFieldAttribute("거래량")]
		public long volume;
		/// <summary>
		/// 거래대금
		/// </summary>
		[XAQueryFieldAttribute("거래대금")]
		public long value;
		/// <summary>
		/// 시가
		/// </summary>
		[XAQueryFieldAttribute("시가")]
		public float open;
		/// <summary>
		/// 고가
		/// </summary>
		[XAQueryFieldAttribute("고가")]
		public float high;
		/// <summary>
		/// 저가
		/// </summary>
		[XAQueryFieldAttribute("저가")]
		public float low;
		/// <summary>
		/// 기준가
		/// </summary>
		[XAQueryFieldAttribute("기준가")]
		public float recprice;
		/// <summary>
		/// 이론가
		/// </summary>
		[XAQueryFieldAttribute("이론가")]
		public float theoryprice;
		/// <summary>
		/// 행사가
		/// </summary>
		[XAQueryFieldAttribute("행사가")]
		public float actprice;
		/// <summary>
		/// 내재가치
		/// </summary>
		[XAQueryFieldAttribute("내재가치")]
		public float impv;
		/// <summary>
		/// 시간가치
		/// </summary>
		[XAQueryFieldAttribute("시간가치")]
		public float timevl;
		/// <summary>
		/// KOSPI200지수
		/// </summary>
		[XAQueryFieldAttribute("KOSPI200지수")]
		public float kospijisu;
		/// <summary>
		/// KOSPI200전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("KOSPI200전일대비구분")]
		public char kospisign;
		/// <summary>
		/// KOSPI200전일대비
		/// </summary>
		[XAQueryFieldAttribute("KOSPI200전일대비")]
		public float kospichange;
		/// <summary>
		/// KOSPI200등락율
		/// </summary>
		[XAQueryFieldAttribute("KOSPI200등락율")]
		public float kospidiff;
		/// <summary>
		/// CME야간선물현재가
		/// </summary>
		[XAQueryFieldAttribute("CME야간선물현재가")]
		public float cmeprice;
		/// <summary>
		/// CME야간선물전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("CME야간선물전일대비구분")]
		public char cmesign;
		/// <summary>
		/// CME야간선물전일대비
		/// </summary>
		[XAQueryFieldAttribute("CME야간선물전일대비")]
		public float cmechange;
		/// <summary>
		/// CME야간선물등락율
		/// </summary>
		[XAQueryFieldAttribute("CME야간선물등락율")]
		public float cmediff;
		/// <summary>
		/// CME야간선물종목코드
		/// </summary>
		[XAQueryFieldAttribute("CME야간선물종목코드")]
		public string cmefocode;
		/// <summary>
		/// 정규장상한가
		/// </summary>
		[XAQueryFieldAttribute("정규장상한가")]
		public float uplmtprice;
		/// <summary>
		/// 정규장하한가
		/// </summary>
		[XAQueryFieldAttribute("정규장하한가")]
		public float dnlmtprice;
		/// <summary>
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("단축코드")]
		public string focode;
		/// <summary>
		/// 예상체결가
		/// </summary>
		[XAQueryFieldAttribute("예상체결가")]
		public float yeprice;
		/// <summary>
		/// 전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("전일대비구분")]
		public char ysign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[XAQueryFieldAttribute("전일대비")]
		public float ychange;
		/// <summary>
		/// 등락율
		/// </summary>
		[XAQueryFieldAttribute("등락율")]
		public float ydiff;
		/// <summary>
		/// 단일가호가여부
		/// </summary>
		[XAQueryFieldAttribute("단일가호가여부")]
		public char danhochk;
		/// <summary>
		/// 전일거래량
		/// </summary>
		[XAQueryFieldAttribute("전일거래량")]
		public long jnilvolume;
		/// <summary>
		/// 전일거래대금
		/// </summary>
		[XAQueryFieldAttribute("전일거래대금")]
		public long jnilvalue;

		public static class F
		{
			/// <summary>
			/// 한글명
			/// </summary>
			public const string hname = "hname";
			/// <summary>
			/// 현재가
			/// </summary>
			public const string price = "price";
			/// <summary>
			/// 전일대비구분
			/// </summary>
			public const string sign = "sign";
			/// <summary>
			/// 전일대비
			/// </summary>
			public const string change = "change";
			/// <summary>
			/// 전일종가
			/// </summary>
			public const string jnilclose = "jnilclose";
			/// <summary>
			/// 등락율
			/// </summary>
			public const string diff = "diff";
			/// <summary>
			/// 거래량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// 거래대금
			/// </summary>
			public const string value = "value";
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
			/// 기준가
			/// </summary>
			public const string recprice = "recprice";
			/// <summary>
			/// 이론가
			/// </summary>
			public const string theoryprice = "theoryprice";
			/// <summary>
			/// 행사가
			/// </summary>
			public const string actprice = "actprice";
			/// <summary>
			/// 내재가치
			/// </summary>
			public const string impv = "impv";
			/// <summary>
			/// 시간가치
			/// </summary>
			public const string timevl = "timevl";
			/// <summary>
			/// KOSPI200지수
			/// </summary>
			public const string kospijisu = "kospijisu";
			/// <summary>
			/// KOSPI200전일대비구분
			/// </summary>
			public const string kospisign = "kospisign";
			/// <summary>
			/// KOSPI200전일대비
			/// </summary>
			public const string kospichange = "kospichange";
			/// <summary>
			/// KOSPI200등락율
			/// </summary>
			public const string kospidiff = "kospidiff";
			/// <summary>
			/// CME야간선물현재가
			/// </summary>
			public const string cmeprice = "cmeprice";
			/// <summary>
			/// CME야간선물전일대비구분
			/// </summary>
			public const string cmesign = "cmesign";
			/// <summary>
			/// CME야간선물전일대비
			/// </summary>
			public const string cmechange = "cmechange";
			/// <summary>
			/// CME야간선물등락율
			/// </summary>
			public const string cmediff = "cmediff";
			/// <summary>
			/// CME야간선물종목코드
			/// </summary>
			public const string cmefocode = "cmefocode";
			/// <summary>
			/// 정규장상한가
			/// </summary>
			public const string uplmtprice = "uplmtprice";
			/// <summary>
			/// 정규장하한가
			/// </summary>
			public const string dnlmtprice = "dnlmtprice";
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string focode = "focode";
			/// <summary>
			/// 예상체결가
			/// </summary>
			public const string yeprice = "yeprice";
			/// <summary>
			/// 전일대비구분
			/// </summary>
			public const string ysign = "ysign";
			/// <summary>
			/// 전일대비
			/// </summary>
			public const string ychange = "ychange";
			/// <summary>
			/// 등락율
			/// </summary>
			public const string ydiff = "ydiff";
			/// <summary>
			/// 단일가호가여부
			/// </summary>
			public const string danhochk = "danhochk";
			/// <summary>
			/// 전일거래량
			/// </summary>
			public const string jnilvolume = "jnilvolume";
			/// <summary>
			/// 전일거래대금
			/// </summary>
			public const string jnilvalue = "jnilvalue";
		}

		public static string[] AllFields = new string[]
		{
			F.hname,
			F.price,
			F.sign,
			F.change,
			F.jnilclose,
			F.diff,
			F.volume,
			F.value,
			F.open,
			F.high,
			F.low,
			F.recprice,
			F.theoryprice,
			F.actprice,
			F.impv,
			F.timevl,
			F.kospijisu,
			F.kospisign,
			F.kospichange,
			F.kospidiff,
			F.cmeprice,
			F.cmesign,
			F.cmechange,
			F.cmediff,
			F.cmefocode,
			F.uplmtprice,
			F.dnlmtprice,
			F.focode,
			F.yeprice,
			F.ysign,
			F.ychange,
			F.ydiff,
			F.danhochk,
			F.jnilvolume,
			F.jnilvalue,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["hname"] = new XAQueryFieldInfo("char", hname, hname, "한글명", (decimal)20);
			dict["price"] = new XAQueryFieldInfo("float", price, price.ToString("000000.00"), "현재가", (decimal)6.2);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("float", change, change.ToString("000000.00"), "전일대비", (decimal)6.2);
			dict["jnilclose"] = new XAQueryFieldInfo("float", jnilclose, jnilclose.ToString("000000.00"), "전일종가", (decimal)6.2);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "거래량", (decimal)12);
			dict["value"] = new XAQueryFieldInfo("long", value, value.ToString("d12"), "거래대금", (decimal)12);
			dict["open"] = new XAQueryFieldInfo("float", open, open.ToString("000000.00"), "시가", (decimal)6.2);
			dict["high"] = new XAQueryFieldInfo("float", high, high.ToString("000000.00"), "고가", (decimal)6.2);
			dict["low"] = new XAQueryFieldInfo("float", low, low.ToString("000000.00"), "저가", (decimal)6.2);
			dict["recprice"] = new XAQueryFieldInfo("float", recprice, recprice.ToString("000000.00"), "기준가", (decimal)6.2);
			dict["theoryprice"] = new XAQueryFieldInfo("float", theoryprice, theoryprice.ToString("000000.00"), "이론가", (decimal)6.2);
			dict["actprice"] = new XAQueryFieldInfo("float", actprice, actprice.ToString("000000.00"), "행사가", (decimal)6.2);
			dict["impv"] = new XAQueryFieldInfo("float", impv, impv.ToString("000000.00"), "내재가치", (decimal)6.2);
			dict["timevl"] = new XAQueryFieldInfo("float", timevl, timevl.ToString("000000.00"), "시간가치", (decimal)6.2);
			dict["kospijisu"] = new XAQueryFieldInfo("float", kospijisu, kospijisu.ToString("000000.00"), "KOSPI200지수", (decimal)6.2);
			dict["kospisign"] = new XAQueryFieldInfo("char", kospisign, kospisign.ToString(), "KOSPI200전일대비구분", (decimal)1);
			dict["kospichange"] = new XAQueryFieldInfo("float", kospichange, kospichange.ToString("000000.00"), "KOSPI200전일대비", (decimal)6.2);
			dict["kospidiff"] = new XAQueryFieldInfo("float", kospidiff, kospidiff.ToString("000000.00"), "KOSPI200등락율", (decimal)6.2);
			dict["cmeprice"] = new XAQueryFieldInfo("float", cmeprice, cmeprice.ToString("000000.00"), "CME야간선물현재가", (decimal)6.2);
			dict["cmesign"] = new XAQueryFieldInfo("char", cmesign, cmesign.ToString(), "CME야간선물전일대비구분", (decimal)1);
			dict["cmechange"] = new XAQueryFieldInfo("float", cmechange, cmechange.ToString("000000.00"), "CME야간선물전일대비", (decimal)6.2);
			dict["cmediff"] = new XAQueryFieldInfo("float", cmediff, cmediff.ToString("000000.00"), "CME야간선물등락율", (decimal)6.2);
			dict["cmefocode"] = new XAQueryFieldInfo("char", cmefocode, cmefocode, "CME야간선물종목코드", (decimal)8);
			dict["uplmtprice"] = new XAQueryFieldInfo("float", uplmtprice, uplmtprice.ToString("000000.00"), "정규장상한가", (decimal)6.2);
			dict["dnlmtprice"] = new XAQueryFieldInfo("float", dnlmtprice, dnlmtprice.ToString("000000.00"), "정규장하한가", (decimal)6.2);
			dict["focode"] = new XAQueryFieldInfo("char", focode, focode, "단축코드", (decimal)8);
			dict["yeprice"] = new XAQueryFieldInfo("float", yeprice, yeprice.ToString("000000.00"), "예상체결가", (decimal)6.2);
			dict["ysign"] = new XAQueryFieldInfo("char", ysign, ysign.ToString(), "전일대비구분", (decimal)1);
			dict["ychange"] = new XAQueryFieldInfo("float", ychange, ychange.ToString("000000.00"), "전일대비", (decimal)6.2);
			dict["ydiff"] = new XAQueryFieldInfo("float", ydiff, ydiff.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["danhochk"] = new XAQueryFieldInfo("char", danhochk, danhochk.ToString(), "단일가호가여부", (decimal)1);
			dict["jnilvolume"] = new XAQueryFieldInfo("long", jnilvolume, jnilvolume.ToString("d12"), "전일거래량", (decimal)12);
			dict["jnilvalue"] = new XAQueryFieldInfo("long", jnilvalue, jnilvalue.ToString("d12"), "전일거래대금", (decimal)12);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "hname":
					this.hname = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "price":
					this.price = fieldInfo.FieldValue.ParseFloat("price");
				break;

				case "sign":
					this.sign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "change":
					this.change = fieldInfo.FieldValue.ParseFloat("change");
				break;

				case "jnilclose":
					this.jnilclose = fieldInfo.FieldValue.ParseFloat("jnilclose");
				break;

				case "diff":
					this.diff = fieldInfo.FieldValue.ParseFloat("diff");
				break;

				case "volume":
					this.volume = fieldInfo.FieldValue.ParseLong("volume");
				break;

				case "value":
					this.value = fieldInfo.FieldValue.ParseLong("value");
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

				case "recprice":
					this.recprice = fieldInfo.FieldValue.ParseFloat("recprice");
				break;

				case "theoryprice":
					this.theoryprice = fieldInfo.FieldValue.ParseFloat("theoryprice");
				break;

				case "actprice":
					this.actprice = fieldInfo.FieldValue.ParseFloat("actprice");
				break;

				case "impv":
					this.impv = fieldInfo.FieldValue.ParseFloat("impv");
				break;

				case "timevl":
					this.timevl = fieldInfo.FieldValue.ParseFloat("timevl");
				break;

				case "kospijisu":
					this.kospijisu = fieldInfo.FieldValue.ParseFloat("kospijisu");
				break;

				case "kospisign":
					this.kospisign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "kospichange":
					this.kospichange = fieldInfo.FieldValue.ParseFloat("kospichange");
				break;

				case "kospidiff":
					this.kospidiff = fieldInfo.FieldValue.ParseFloat("kospidiff");
				break;

				case "cmeprice":
					this.cmeprice = fieldInfo.FieldValue.ParseFloat("cmeprice");
				break;

				case "cmesign":
					this.cmesign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "cmechange":
					this.cmechange = fieldInfo.FieldValue.ParseFloat("cmechange");
				break;

				case "cmediff":
					this.cmediff = fieldInfo.FieldValue.ParseFloat("cmediff");
				break;

				case "cmefocode":
					this.cmefocode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "uplmtprice":
					this.uplmtprice = fieldInfo.FieldValue.ParseFloat("uplmtprice");
				break;

				case "dnlmtprice":
					this.dnlmtprice = fieldInfo.FieldValue.ParseFloat("dnlmtprice");
				break;

				case "focode":
					this.focode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "yeprice":
					this.yeprice = fieldInfo.FieldValue.ParseFloat("yeprice");
				break;

				case "ysign":
					this.ysign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "ychange":
					this.ychange = fieldInfo.FieldValue.ParseFloat("ychange");
				break;

				case "ydiff":
					this.ydiff = fieldInfo.FieldValue.ParseFloat("ydiff");
				break;

				case "danhochk":
					this.danhochk = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "jnilvolume":
					this.jnilvolume = fieldInfo.FieldValue.ParseLong("jnilvolume");
				break;

				case "jnilvalue":
					this.jnilvalue = fieldInfo.FieldValue.ParseLong("jnilvalue");
				break;


			}
		}

		public static XQt2830OutBlock FromQuery(XQt2830 query)
		{
			XQt2830OutBlock block = new XQt2830OutBlock();
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
				block.hname = query.GetFieldData(block.GetBlockName(), "hname", 0).TrimEnd('?'); // char 20
				block.price = query.GetFieldData(block.GetBlockName(), "price", 0).ParseFloat("price"); // float 6.2
				block.sign = query.GetFieldData(block.GetBlockName(), "sign", 0).FirstOrDefault(); // char 1
				block.change = query.GetFieldData(block.GetBlockName(), "change", 0).ParseFloat("change"); // float 6.2
				block.jnilclose = query.GetFieldData(block.GetBlockName(), "jnilclose", 0).ParseFloat("jnilclose"); // float 6.2
				block.diff = query.GetFieldData(block.GetBlockName(), "diff", 0).ParseFloat("diff"); // float 6.2
				block.volume = query.GetFieldData(block.GetBlockName(), "volume", 0).ParseLong("volume"); // long 12
				block.value = query.GetFieldData(block.GetBlockName(), "value", 0).ParseLong("value"); // long 12
				block.open = query.GetFieldData(block.GetBlockName(), "open", 0).ParseFloat("open"); // float 6.2
				block.high = query.GetFieldData(block.GetBlockName(), "high", 0).ParseFloat("high"); // float 6.2
				block.low = query.GetFieldData(block.GetBlockName(), "low", 0).ParseFloat("low"); // float 6.2
				block.recprice = query.GetFieldData(block.GetBlockName(), "recprice", 0).ParseFloat("recprice"); // float 6.2
				block.theoryprice = query.GetFieldData(block.GetBlockName(), "theoryprice", 0).ParseFloat("theoryprice"); // float 6.2
				block.actprice = query.GetFieldData(block.GetBlockName(), "actprice", 0).ParseFloat("actprice"); // float 6.2
				block.impv = query.GetFieldData(block.GetBlockName(), "impv", 0).ParseFloat("impv"); // float 6.2
				block.timevl = query.GetFieldData(block.GetBlockName(), "timevl", 0).ParseFloat("timevl"); // float 6.2
				block.kospijisu = query.GetFieldData(block.GetBlockName(), "kospijisu", 0).ParseFloat("kospijisu"); // float 6.2
				block.kospisign = query.GetFieldData(block.GetBlockName(), "kospisign", 0).FirstOrDefault(); // char 1
				block.kospichange = query.GetFieldData(block.GetBlockName(), "kospichange", 0).ParseFloat("kospichange"); // float 6.2
				block.kospidiff = query.GetFieldData(block.GetBlockName(), "kospidiff", 0).ParseFloat("kospidiff"); // float 6.2
				block.cmeprice = query.GetFieldData(block.GetBlockName(), "cmeprice", 0).ParseFloat("cmeprice"); // float 6.2
				block.cmesign = query.GetFieldData(block.GetBlockName(), "cmesign", 0).FirstOrDefault(); // char 1
				block.cmechange = query.GetFieldData(block.GetBlockName(), "cmechange", 0).ParseFloat("cmechange"); // float 6.2
				block.cmediff = query.GetFieldData(block.GetBlockName(), "cmediff", 0).ParseFloat("cmediff"); // float 6.2
				block.cmefocode = query.GetFieldData(block.GetBlockName(), "cmefocode", 0).TrimEnd('?'); // char 8
				block.uplmtprice = query.GetFieldData(block.GetBlockName(), "uplmtprice", 0).ParseFloat("uplmtprice"); // float 6.2
				block.dnlmtprice = query.GetFieldData(block.GetBlockName(), "dnlmtprice", 0).ParseFloat("dnlmtprice"); // float 6.2
				block.focode = query.GetFieldData(block.GetBlockName(), "focode", 0).TrimEnd('?'); // char 8
				block.yeprice = query.GetFieldData(block.GetBlockName(), "yeprice", 0).ParseFloat("yeprice"); // float 6.2
				block.ysign = query.GetFieldData(block.GetBlockName(), "ysign", 0).FirstOrDefault(); // char 1
				block.ychange = query.GetFieldData(block.GetBlockName(), "ychange", 0).ParseFloat("ychange"); // float 6.2
				block.ydiff = query.GetFieldData(block.GetBlockName(), "ydiff", 0).ParseFloat("ydiff"); // float 6.2
				block.danhochk = query.GetFieldData(block.GetBlockName(), "danhochk", 0).FirstOrDefault(); // char 1
				block.jnilvolume = query.GetFieldData(block.GetBlockName(), "jnilvolume", 0).ParseLong("jnilvolume"); // long 12
				block.jnilvalue = query.GetFieldData(block.GetBlockName(), "jnilvalue", 0).ParseLong("jnilvalue"); // long 12

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (hname?.Length > 20) return false; // char 20
			// price float 6.2
			// sign char 1
			// change float 6.2
			// jnilclose float 6.2
			// diff float 6.2
			if (volume.ToString().Length > 12) return false; // long 12
			if (value.ToString().Length > 12) return false; // long 12
			// open float 6.2
			// high float 6.2
			// low float 6.2
			// recprice float 6.2
			// theoryprice float 6.2
			// actprice float 6.2
			// impv float 6.2
			// timevl float 6.2
			// kospijisu float 6.2
			// kospisign char 1
			// kospichange float 6.2
			// kospidiff float 6.2
			// cmeprice float 6.2
			// cmesign char 1
			// cmechange float 6.2
			// cmediff float 6.2
			if (cmefocode?.Length > 8) return false; // char 8
			// uplmtprice float 6.2
			// dnlmtprice float 6.2
			if (focode?.Length > 8) return false; // char 8
			// yeprice float 6.2
			// ysign char 1
			// ychange float 6.2
			// ydiff float 6.2
			// danhochk char 1
			if (jnilvolume.ToString().Length > 12) return false; // long 12
			if (jnilvalue.ToString().Length > 12) return false; // long 12

			return true;
		}
	}

	public partial class XQt2830 : XingQuery
	{
		/// <summary>
		/// t2830
		/// </summary>
		public const string _typeName = "t2830";
		/// <summary>
		/// EUREXKOSPI200옵션선물현재가(시세)조회(t2830)
		/// </summary>
		public const string _typeDesc = "EUREXKOSPI200옵션선물현재가(시세)조회(t2830)";
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
		/// t2830
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// EUREXKOSPI200옵션선물현재가(시세)조회(t2830)
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

		public XQt2830() : base("t2830") { }


		public static XQt2830OutBlock Get(string focode = default)
		{
			using (XQt2830 instance = new XQt2830())
			{
				instance.SetFieldData(XQt2830InBlock.BlockName, XQt2830InBlock.F.focode, 0, focode); // char 8

				if (instance.Request() < 0)
				{
					return null;
				}

				var outBlock = instance.GetBlock();
				if (outBlock.IsValidData == false)
				{
					return null;
				}
				return outBlock;
			}
		}

		public bool SetBlock(XQt2830InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "focode", 0, block.focode); // char 8

			return true;
		}

		public XQt2830OutBlock GetBlock()
		{
			XQt2830OutBlock instance = XQt2830OutBlock.FromQuery(this);
			return instance;

		}


	}

}
