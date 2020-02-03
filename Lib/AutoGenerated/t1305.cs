using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1305InBlock : XingBlock
	{
		/// <summary>
		/// t1305InBlock
		/// </summary>
		static readonly string _blockName = "t1305InBlock";
		/// <summary>
		/// 기본입력
		/// </summary>
		static readonly string _blockDesc = "기본입력";
		/// <summary>
		/// input
		/// </summary>
		static readonly string _blockType = "input";
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _hasOccurs = false;
		/// <summary>
		/// t1305InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1305InBlock
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
		public string shcode;
		/// <summary>
		/// 일주월구분
		/// </summary>
		[XAQueryFieldAttribute("일주월구분")]
		public long dwmcode;
		/// <summary>
		/// 날짜
		/// </summary>
		[XAQueryFieldAttribute("날짜")]
		public string date;
		/// <summary>
		/// IDX
		/// </summary>
		[XAQueryFieldAttribute("IDX")]
		public long idx;
		/// <summary>
		/// 건수
		/// </summary>
		[XAQueryFieldAttribute("건수")]
		public long cnt;

		public static class F
		{
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 일주월구분
			/// </summary>
			public const string dwmcode = "dwmcode";
			/// <summary>
			/// 날짜
			/// </summary>
			public const string date = "date";
			/// <summary>
			/// IDX
			/// </summary>
			public const string idx = "idx";
			/// <summary>
			/// 건수
			/// </summary>
			public const string cnt = "cnt";
		}

		public static string[] AllFields = new string[]
		{
			F.shcode,
			F.dwmcode,
			F.date,
			F.idx,
			F.cnt,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)6);
			dict["dwmcode"] = new XAQueryFieldInfo("long", dwmcode, dwmcode.ToString("d1"), "일주월구분", (decimal)1);
			dict["date"] = new XAQueryFieldInfo("char", date, date, "날짜", (decimal)8);
			dict["idx"] = new XAQueryFieldInfo("long", idx, idx.ToString("d4"), "IDX", (decimal)4);
			dict["cnt"] = new XAQueryFieldInfo("long", cnt, cnt.ToString("d4"), "건수", (decimal)4);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "dwmcode":
					this.dwmcode = fieldInfo.FieldValue.ParseLong("dwmcode");
				break;

				case "date":
					this.date = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "idx":
					this.idx = fieldInfo.FieldValue.ParseLong("idx");
				break;

				case "cnt":
					this.cnt = fieldInfo.FieldValue.ParseLong("cnt");
				break;


			}
		}

		public bool VerifyData()
		{
			if (shcode.Length > 6) return false; // char 6
			if (dwmcode.ToString().Length > 1) return false; // long 1
			if (date.Length > 8) return false; // char 8
			if (idx.ToString().Length > 4) return false; // long 4
			if (cnt.ToString().Length > 4) return false; // long 4

			return true;
		}
	}

	public partial class XQt1305OutBlock : XingBlock
	{
		/// <summary>
		/// t1305OutBlock
		/// </summary>
		static readonly string _blockName = "t1305OutBlock";
		/// <summary>
		/// 출력
		/// </summary>
		static readonly string _blockDesc = "출력";
		/// <summary>
		/// output
		/// </summary>
		static readonly string _blockType = "output";
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _hasOccurs = false;
		/// <summary>
		/// t1305OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1305OutBlock
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
		/// CNT
		/// </summary>
		[XAQueryFieldAttribute("CNT")]
		public long cnt;
		/// <summary>
		/// 날짜
		/// </summary>
		[XAQueryFieldAttribute("날짜")]
		public string date;
		/// <summary>
		/// IDX
		/// </summary>
		[XAQueryFieldAttribute("IDX")]
		public long idx;

		public static class F
		{
			/// <summary>
			/// CNT
			/// </summary>
			public const string cnt = "cnt";
			/// <summary>
			/// 날짜
			/// </summary>
			public const string date = "date";
			/// <summary>
			/// IDX
			/// </summary>
			public const string idx = "idx";
		}

		public static string[] AllFields = new string[]
		{
			F.cnt,
			F.date,
			F.idx,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["cnt"] = new XAQueryFieldInfo("long", cnt, cnt.ToString("d4"), "CNT", (decimal)4);
			dict["date"] = new XAQueryFieldInfo("char", date, date, "날짜", (decimal)8);
			dict["idx"] = new XAQueryFieldInfo("long", idx, idx.ToString("d4"), "IDX", (decimal)4);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "cnt":
					this.cnt = fieldInfo.FieldValue.ParseLong("cnt");
				break;

				case "date":
					this.date = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "idx":
					this.idx = fieldInfo.FieldValue.ParseLong("idx");
				break;


			}
		}

		public static XQt1305OutBlock FromQuery(XQt1305 query)
		{
			XQt1305OutBlock block = new XQt1305OutBlock();
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
				block.cnt = query.GetFieldData(block.GetBlockName(), "cnt", 0).ParseLong("cnt"); // long 4
				block.date = query.GetFieldData(block.GetBlockName(), "date", 0).TrimEnd('?'); // char 8
				block.idx = query.GetFieldData(block.GetBlockName(), "idx", 0).ParseLong("idx"); // long 4

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (cnt.ToString().Length > 4) return false; // long 4
			if (date.Length > 8) return false; // char 8
			if (idx.ToString().Length > 4) return false; // long 4

			return true;
		}
	}

	public partial class XQt1305OutBlock1 : XingBlock
	{
		/// <summary>
		/// t1305OutBlock1
		/// </summary>
		static readonly string _blockName = "t1305OutBlock1";
		/// <summary>
		/// 출력1
		/// </summary>
		static readonly string _blockDesc = "출력1";
		/// <summary>
		/// output
		/// </summary>
		static readonly string _blockType = "output";
		/// <summary>
		/// true
		/// </summary>
		static readonly bool _hasOccurs = true;
		/// <summary>
		/// t1305OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1305OutBlock1
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
		/// 시가
		/// </summary>
		[XAQueryFieldAttribute("시가")]
		public long open;
		/// <summary>
		/// 고가
		/// </summary>
		[XAQueryFieldAttribute("고가")]
		public long high;
		/// <summary>
		/// 저가
		/// </summary>
		[XAQueryFieldAttribute("저가")]
		public long low;
		/// <summary>
		/// 종가
		/// </summary>
		[XAQueryFieldAttribute("종가")]
		public long close;
		/// <summary>
		/// 전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("전일대비구분")]
		public char sign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[XAQueryFieldAttribute("전일대비")]
		public long change;
		/// <summary>
		/// 등락율
		/// </summary>
		[XAQueryFieldAttribute("등락율")]
		public float diff;
		/// <summary>
		/// 누적거래량
		/// </summary>
		[XAQueryFieldAttribute("누적거래량")]
		public long volume;
		/// <summary>
		/// 거래증가율
		/// </summary>
		[XAQueryFieldAttribute("거래증가율")]
		public float diff_vol;
		/// <summary>
		/// 체결강도
		/// </summary>
		[XAQueryFieldAttribute("체결강도")]
		public float chdegree;
		/// <summary>
		/// 소진율
		/// </summary>
		[XAQueryFieldAttribute("소진율")]
		public float sojinrate;
		/// <summary>
		/// 회전율
		/// </summary>
		[XAQueryFieldAttribute("회전율")]
		public float changerate;
		/// <summary>
		/// 외인순매수
		/// </summary>
		[XAQueryFieldAttribute("외인순매수")]
		public long fpvolume;
		/// <summary>
		/// 기관순매수
		/// </summary>
		[XAQueryFieldAttribute("기관순매수")]
		public long covolume;
		/// <summary>
		/// 종목코드
		/// </summary>
		[XAQueryFieldAttribute("종목코드")]
		public string shcode;
		/// <summary>
		/// 누적거래대금(단위:백만)
		/// </summary>
		[XAQueryFieldAttribute("누적거래대금(단위:백만)")]
		public long value;
		/// <summary>
		/// 개인순매수
		/// </summary>
		[XAQueryFieldAttribute("개인순매수")]
		public long ppvolume;
		/// <summary>
		/// 시가대비구분
		/// </summary>
		[XAQueryFieldAttribute("시가대비구분")]
		public char o_sign;
		/// <summary>
		/// 시가대비
		/// </summary>
		[XAQueryFieldAttribute("시가대비")]
		public long o_change;
		/// <summary>
		/// 시가기준등락율
		/// </summary>
		[XAQueryFieldAttribute("시가기준등락율")]
		public float o_diff;
		/// <summary>
		/// 고가대비구분
		/// </summary>
		[XAQueryFieldAttribute("고가대비구분")]
		public char h_sign;
		/// <summary>
		/// 고가대비
		/// </summary>
		[XAQueryFieldAttribute("고가대비")]
		public long h_change;
		/// <summary>
		/// 고가기준등락율
		/// </summary>
		[XAQueryFieldAttribute("고가기준등락율")]
		public float h_diff;
		/// <summary>
		/// 저가대비구분
		/// </summary>
		[XAQueryFieldAttribute("저가대비구분")]
		public char l_sign;
		/// <summary>
		/// 저가대비
		/// </summary>
		[XAQueryFieldAttribute("저가대비")]
		public long l_change;
		/// <summary>
		/// 저가기준등락율
		/// </summary>
		[XAQueryFieldAttribute("저가기준등락율")]
		public float l_diff;
		/// <summary>
		/// 시가총액(단위:백만)
		/// </summary>
		[XAQueryFieldAttribute("시가총액(단위:백만)")]
		public long marketcap;

		public static class F
		{
			/// <summary>
			/// 날짜
			/// </summary>
			public const string date = "date";
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
			/// 거래증가율
			/// </summary>
			public const string diff_vol = "diff_vol";
			/// <summary>
			/// 체결강도
			/// </summary>
			public const string chdegree = "chdegree";
			/// <summary>
			/// 소진율
			/// </summary>
			public const string sojinrate = "sojinrate";
			/// <summary>
			/// 회전율
			/// </summary>
			public const string changerate = "changerate";
			/// <summary>
			/// 외인순매수
			/// </summary>
			public const string fpvolume = "fpvolume";
			/// <summary>
			/// 기관순매수
			/// </summary>
			public const string covolume = "covolume";
			/// <summary>
			/// 종목코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 누적거래대금(단위:백만)
			/// </summary>
			public const string value = "value";
			/// <summary>
			/// 개인순매수
			/// </summary>
			public const string ppvolume = "ppvolume";
			/// <summary>
			/// 시가대비구분
			/// </summary>
			public const string o_sign = "o_sign";
			/// <summary>
			/// 시가대비
			/// </summary>
			public const string o_change = "o_change";
			/// <summary>
			/// 시가기준등락율
			/// </summary>
			public const string o_diff = "o_diff";
			/// <summary>
			/// 고가대비구분
			/// </summary>
			public const string h_sign = "h_sign";
			/// <summary>
			/// 고가대비
			/// </summary>
			public const string h_change = "h_change";
			/// <summary>
			/// 고가기준등락율
			/// </summary>
			public const string h_diff = "h_diff";
			/// <summary>
			/// 저가대비구분
			/// </summary>
			public const string l_sign = "l_sign";
			/// <summary>
			/// 저가대비
			/// </summary>
			public const string l_change = "l_change";
			/// <summary>
			/// 저가기준등락율
			/// </summary>
			public const string l_diff = "l_diff";
			/// <summary>
			/// 시가총액(단위:백만)
			/// </summary>
			public const string marketcap = "marketcap";
		}

		public static string[] AllFields = new string[]
		{
			F.date,
			F.open,
			F.high,
			F.low,
			F.close,
			F.sign,
			F.change,
			F.diff,
			F.volume,
			F.diff_vol,
			F.chdegree,
			F.sojinrate,
			F.changerate,
			F.fpvolume,
			F.covolume,
			F.shcode,
			F.value,
			F.ppvolume,
			F.o_sign,
			F.o_change,
			F.o_diff,
			F.h_sign,
			F.h_change,
			F.h_diff,
			F.l_sign,
			F.l_change,
			F.l_diff,
			F.marketcap,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["date"] = new XAQueryFieldInfo("char", date, date, "날짜", (decimal)8);
			dict["open"] = new XAQueryFieldInfo("long", open, open.ToString("d8"), "시가", (decimal)8);
			dict["high"] = new XAQueryFieldInfo("long", high, high.ToString("d8"), "고가", (decimal)8);
			dict["low"] = new XAQueryFieldInfo("long", low, low.ToString("d8"), "저가", (decimal)8);
			dict["close"] = new XAQueryFieldInfo("long", close, close.ToString("d8"), "종가", (decimal)8);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("long", change, change.ToString("d8"), "전일대비", (decimal)8);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "누적거래량", (decimal)12);
			dict["diff_vol"] = new XAQueryFieldInfo("float", diff_vol, diff_vol.ToString("0000000000.00"), "거래증가율", (decimal)10.2);
			dict["chdegree"] = new XAQueryFieldInfo("float", chdegree, chdegree.ToString("000000.00"), "체결강도", (decimal)6.2);
			dict["sojinrate"] = new XAQueryFieldInfo("float", sojinrate, sojinrate.ToString("000000.00"), "소진율", (decimal)6.2);
			dict["changerate"] = new XAQueryFieldInfo("float", changerate, changerate.ToString("000000.00"), "회전율", (decimal)6.2);
			dict["fpvolume"] = new XAQueryFieldInfo("long", fpvolume, fpvolume.ToString("d12"), "외인순매수", (decimal)12);
			dict["covolume"] = new XAQueryFieldInfo("long", covolume, covolume.ToString("d12"), "기관순매수", (decimal)12);
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "종목코드", (decimal)6);
			dict["value"] = new XAQueryFieldInfo("long", value, value.ToString("d12"), "누적거래대금(단위:백만)", (decimal)12);
			dict["ppvolume"] = new XAQueryFieldInfo("long", ppvolume, ppvolume.ToString("d12"), "개인순매수", (decimal)12);
			dict["o_sign"] = new XAQueryFieldInfo("char", o_sign, o_sign.ToString(), "시가대비구분", (decimal)1);
			dict["o_change"] = new XAQueryFieldInfo("long", o_change, o_change.ToString("d8"), "시가대비", (decimal)8);
			dict["o_diff"] = new XAQueryFieldInfo("float", o_diff, o_diff.ToString("000000.00"), "시가기준등락율", (decimal)6.2);
			dict["h_sign"] = new XAQueryFieldInfo("char", h_sign, h_sign.ToString(), "고가대비구분", (decimal)1);
			dict["h_change"] = new XAQueryFieldInfo("long", h_change, h_change.ToString("d8"), "고가대비", (decimal)8);
			dict["h_diff"] = new XAQueryFieldInfo("float", h_diff, h_diff.ToString("000000.00"), "고가기준등락율", (decimal)6.2);
			dict["l_sign"] = new XAQueryFieldInfo("char", l_sign, l_sign.ToString(), "저가대비구분", (decimal)1);
			dict["l_change"] = new XAQueryFieldInfo("long", l_change, l_change.ToString("d8"), "저가대비", (decimal)8);
			dict["l_diff"] = new XAQueryFieldInfo("float", l_diff, l_diff.ToString("000000.00"), "저가기준등락율", (decimal)6.2);
			dict["marketcap"] = new XAQueryFieldInfo("long", marketcap, marketcap.ToString("d12"), "시가총액(단위:백만)", (decimal)12);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "date":
					this.date = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "open":
					this.open = fieldInfo.FieldValue.ParseLong("open");
				break;

				case "high":
					this.high = fieldInfo.FieldValue.ParseLong("high");
				break;

				case "low":
					this.low = fieldInfo.FieldValue.ParseLong("low");
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

				case "diff_vol":
					this.diff_vol = fieldInfo.FieldValue.ParseFloat("diff_vol");
				break;

				case "chdegree":
					this.chdegree = fieldInfo.FieldValue.ParseFloat("chdegree");
				break;

				case "sojinrate":
					this.sojinrate = fieldInfo.FieldValue.ParseFloat("sojinrate");
				break;

				case "changerate":
					this.changerate = fieldInfo.FieldValue.ParseFloat("changerate");
				break;

				case "fpvolume":
					this.fpvolume = fieldInfo.FieldValue.ParseLong("fpvolume");
				break;

				case "covolume":
					this.covolume = fieldInfo.FieldValue.ParseLong("covolume");
				break;

				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "value":
					this.value = fieldInfo.FieldValue.ParseLong("value");
				break;

				case "ppvolume":
					this.ppvolume = fieldInfo.FieldValue.ParseLong("ppvolume");
				break;

				case "o_sign":
					this.o_sign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "o_change":
					this.o_change = fieldInfo.FieldValue.ParseLong("o_change");
				break;

				case "o_diff":
					this.o_diff = fieldInfo.FieldValue.ParseFloat("o_diff");
				break;

				case "h_sign":
					this.h_sign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "h_change":
					this.h_change = fieldInfo.FieldValue.ParseLong("h_change");
				break;

				case "h_diff":
					this.h_diff = fieldInfo.FieldValue.ParseFloat("h_diff");
				break;

				case "l_sign":
					this.l_sign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "l_change":
					this.l_change = fieldInfo.FieldValue.ParseLong("l_change");
				break;

				case "l_diff":
					this.l_diff = fieldInfo.FieldValue.ParseFloat("l_diff");
				break;

				case "marketcap":
					this.marketcap = fieldInfo.FieldValue.ParseLong("marketcap");
				break;


			}
		}

		public static XQt1305OutBlock1[] ListFromQuery(XQt1305 query)
		{
			int count = query.GetBlockCount(XQt1305OutBlock1.BlockName);
			List<XQt1305OutBlock1> list = new List<XQt1305OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1305OutBlock1 block = new XQt1305OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.date = query.GetFieldData(block.GetBlockName(), "date", i).TrimEnd('?'); // char 8
					block.open = query.GetFieldData(block.GetBlockName(), "open", i).ParseLong("open"); // long 8
					block.high = query.GetFieldData(block.GetBlockName(), "high", i).ParseLong("high"); // long 8
					block.low = query.GetFieldData(block.GetBlockName(), "low", i).ParseLong("low"); // long 8
					block.close = query.GetFieldData(block.GetBlockName(), "close", i).ParseLong("close"); // long 8
					block.sign = query.GetFieldData(block.GetBlockName(), "sign", i).FirstOrDefault(); // char 1
					block.change = query.GetFieldData(block.GetBlockName(), "change", i).ParseLong("change"); // long 8
					block.diff = query.GetFieldData(block.GetBlockName(), "diff", i).ParseFloat("diff"); // float 6.2
					block.volume = query.GetFieldData(block.GetBlockName(), "volume", i).ParseLong("volume"); // long 12
					block.diff_vol = query.GetFieldData(block.GetBlockName(), "diff_vol", i).ParseFloat("diff_vol"); // float 10.2
					block.chdegree = query.GetFieldData(block.GetBlockName(), "chdegree", i).ParseFloat("chdegree"); // float 6.2
					block.sojinrate = query.GetFieldData(block.GetBlockName(), "sojinrate", i).ParseFloat("sojinrate"); // float 6.2
					block.changerate = query.GetFieldData(block.GetBlockName(), "changerate", i).ParseFloat("changerate"); // float 6.2
					block.fpvolume = query.GetFieldData(block.GetBlockName(), "fpvolume", i).ParseLong("fpvolume"); // long 12
					block.covolume = query.GetFieldData(block.GetBlockName(), "covolume", i).ParseLong("covolume"); // long 12
					block.shcode = query.GetFieldData(block.GetBlockName(), "shcode", i).TrimEnd('?'); // char 6
					block.value = query.GetFieldData(block.GetBlockName(), "value", i).ParseLong("value"); // long 12
					block.ppvolume = query.GetFieldData(block.GetBlockName(), "ppvolume", i).ParseLong("ppvolume"); // long 12
					block.o_sign = query.GetFieldData(block.GetBlockName(), "o_sign", i).FirstOrDefault(); // char 1
					block.o_change = query.GetFieldData(block.GetBlockName(), "o_change", i).ParseLong("o_change"); // long 8
					block.o_diff = query.GetFieldData(block.GetBlockName(), "o_diff", i).ParseFloat("o_diff"); // float 6.2
					block.h_sign = query.GetFieldData(block.GetBlockName(), "h_sign", i).FirstOrDefault(); // char 1
					block.h_change = query.GetFieldData(block.GetBlockName(), "h_change", i).ParseLong("h_change"); // long 8
					block.h_diff = query.GetFieldData(block.GetBlockName(), "h_diff", i).ParseFloat("h_diff"); // float 6.2
					block.l_sign = query.GetFieldData(block.GetBlockName(), "l_sign", i).FirstOrDefault(); // char 1
					block.l_change = query.GetFieldData(block.GetBlockName(), "l_change", i).ParseLong("l_change"); // long 8
					block.l_diff = query.GetFieldData(block.GetBlockName(), "l_diff", i).ParseFloat("l_diff"); // float 6.2
					block.marketcap = query.GetFieldData(block.GetBlockName(), "marketcap", i).ParseLong("marketcap"); // long 12

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
			if (date.Length > 8) return false; // char 8
			if (open.ToString().Length > 8) return false; // long 8
			if (high.ToString().Length > 8) return false; // long 8
			if (low.ToString().Length > 8) return false; // long 8
			if (close.ToString().Length > 8) return false; // long 8
			// sign char 1
			if (change.ToString().Length > 8) return false; // long 8
			// diff float 6.2
			if (volume.ToString().Length > 12) return false; // long 12
			// diff_vol float 10.2
			// chdegree float 6.2
			// sojinrate float 6.2
			// changerate float 6.2
			if (fpvolume.ToString().Length > 12) return false; // long 12
			if (covolume.ToString().Length > 12) return false; // long 12
			if (shcode.Length > 6) return false; // char 6
			if (value.ToString().Length > 12) return false; // long 12
			if (ppvolume.ToString().Length > 12) return false; // long 12
			// o_sign char 1
			if (o_change.ToString().Length > 8) return false; // long 8
			// o_diff float 6.2
			// h_sign char 1
			if (h_change.ToString().Length > 8) return false; // long 8
			// h_diff float 6.2
			// l_sign char 1
			if (l_change.ToString().Length > 8) return false; // long 8
			// l_diff float 6.2
			if (marketcap.ToString().Length > 12) return false; // long 12

			return true;
		}
	}

	public partial class XQt1305 : XingQuery
	{
		/// <summary>
		/// t1305
		/// </summary>
		static readonly string _typeName = "t1305";
		/// <summary>
		/// 기간별주가(t1305)
		/// </summary>
		static readonly string _typeDesc = "기간별주가(t1305)";
		/// <summary>
		/// 
		/// </summary>
		static readonly string _service = "";
		/// <summary>
		/// A
		/// </summary>
		static readonly string _headType = "A";
		/// <summary>
		/// 
		/// </summary>
		static readonly string _creator = "";
		/// <summary>
		/// 
		/// </summary>
		static readonly string _createdDate = "";
		/// <summary>
		/// true
		/// </summary>
		static readonly bool _attr = true;
		/// <summary>
		/// true
		/// </summary>
		static readonly bool _block = true;
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _encrypt = false;
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _signature = false;

		/// <summary>
		/// t1305
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 기간별주가(t1305)
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

		public XQt1305() : base("t1305") { }


		public bool SetFields(XQt1305InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "shcode", 0, block.shcode); // char 6
			_xaQuery.SetFieldData(block.GetBlockName(), "dwmcode", 0, block.dwmcode.ToString("d1")); // long 1
			_xaQuery.SetFieldData(block.GetBlockName(), "date", 0, block.date); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "idx", 0, block.idx.ToString("d4")); // long 4
			_xaQuery.SetFieldData(block.GetBlockName(), "cnt", 0, block.cnt.ToString("d4")); // long 4

			return true;
		}

		public XQt1305OutBlock GetBlock()
		{
			XQt1305OutBlock instance = XQt1305OutBlock.FromQuery(this);
			return instance;

		}

		public XQt1305OutBlock1[] GetBlock1s()
		{
			XQt1305OutBlock1[] instance = XQt1305OutBlock1.ListFromQuery(this);
			return instance;

		}


	}

}
