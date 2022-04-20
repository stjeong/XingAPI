using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt2801InBlock : XingBlock
	{
		/// <summary>
		/// t2801InBlock
		/// </summary>
		public const string _blockName = "t2801InBlock";
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
		/// t2801InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t2801InBlock
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
		[XAQueryFieldAttribute("focode", "단축코드", "char", "8")]
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

		public void CopyTo(XQt2801InBlock block)
		{
			block.focode = this.focode;

		}
	}

	public partial class XQt2801OutBlock : XingBlock
	{
		/// <summary>
		/// t2801OutBlock
		/// </summary>
		public const string _blockName = "t2801OutBlock";
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
		/// t2801OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t2801OutBlock
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
		[XAQueryFieldAttribute("hname", "한글명", "char", "20")]
		public string hname;
		/// <summary>
		/// 현재가
		/// </summary>
		[XAQueryFieldAttribute("price", "현재가", "float", "6.2")]
		public float price;
		/// <summary>
		/// 전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("sign", "전일대비구분", "char", "1")]
		public char sign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[XAQueryFieldAttribute("change", "전일대비", "float", "6.2")]
		public float change;
		/// <summary>
		/// 전일종가
		/// </summary>
		[XAQueryFieldAttribute("jnilclose", "전일종가", "float", "6.2")]
		public float jnilclose;
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
		/// 거래대금
		/// </summary>
		[XAQueryFieldAttribute("value", "거래대금", "long", "12")]
		public long value;
		/// <summary>
		/// 미결제량
		/// </summary>
		[XAQueryFieldAttribute("mgjv", "미결제량", "long", "8")]
		public long mgjv;
		/// <summary>
		/// 미결제증감
		/// </summary>
		[XAQueryFieldAttribute("mgjvdiff", "미결제증감", "long", "8")]
		public long mgjvdiff;
		/// <summary>
		/// 시가
		/// </summary>
		[XAQueryFieldAttribute("open", "시가", "float", "6.2")]
		public float open;
		/// <summary>
		/// 고가
		/// </summary>
		[XAQueryFieldAttribute("high", "고가", "float", "6.2")]
		public float high;
		/// <summary>
		/// 저가
		/// </summary>
		[XAQueryFieldAttribute("low", "저가", "float", "6.2")]
		public float low;
		/// <summary>
		/// 상한가
		/// </summary>
		[XAQueryFieldAttribute("uplmtprice", "상한가", "float", "6.2")]
		public float uplmtprice;
		/// <summary>
		/// 하한가
		/// </summary>
		[XAQueryFieldAttribute("dnlmtprice", "하한가", "float", "6.2")]
		public float dnlmtprice;
		/// <summary>
		/// 52최고가
		/// </summary>
		[XAQueryFieldAttribute("high52w", "52최고가", "float", "6.2")]
		public float high52w;
		/// <summary>
		/// 52최저가
		/// </summary>
		[XAQueryFieldAttribute("low52w", "52최저가", "float", "6.2")]
		public float low52w;
		/// <summary>
		/// 베이시스
		/// </summary>
		[XAQueryFieldAttribute("basis", "베이시스", "float", "6.2")]
		public float basis;
		/// <summary>
		/// 기준가
		/// </summary>
		[XAQueryFieldAttribute("recprice", "기준가", "float", "6.2")]
		public float recprice;
		/// <summary>
		/// 이론가
		/// </summary>
		[XAQueryFieldAttribute("theoryprice", "이론가", "float", "6.2")]
		public float theoryprice;
		/// <summary>
		/// 괴리율
		/// </summary>
		[XAQueryFieldAttribute("glyl", "괴리율", "float", "6.3")]
		public float glyl;
		/// <summary>
		/// CB상한가
		/// </summary>
		[XAQueryFieldAttribute("cbhprice", "CB상한가", "float", "6.2")]
		public float cbhprice;
		/// <summary>
		/// CB하한가
		/// </summary>
		[XAQueryFieldAttribute("cblprice", "CB하한가", "float", "6.2")]
		public float cblprice;
		/// <summary>
		/// 만기일
		/// </summary>
		[XAQueryFieldAttribute("lastmonth", "만기일", "char", "8")]
		public string lastmonth;
		/// <summary>
		/// 잔여일
		/// </summary>
		[XAQueryFieldAttribute("jandatecnt", "잔여일", "long", "8")]
		public long jandatecnt;
		/// <summary>
		/// 종합지수
		/// </summary>
		[XAQueryFieldAttribute("pricejisu", "종합지수", "float", "6.2")]
		public float pricejisu;
		/// <summary>
		/// 종합지수전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("jisusign", "종합지수전일대비구분", "char", "1")]
		public char jisusign;
		/// <summary>
		/// 종합지수전일대비
		/// </summary>
		[XAQueryFieldAttribute("jisuchange", "종합지수전일대비", "float", "6.2")]
		public float jisuchange;
		/// <summary>
		/// 종합지수등락율
		/// </summary>
		[XAQueryFieldAttribute("jisudiff", "종합지수등락율", "float", "6.2")]
		public float jisudiff;
		/// <summary>
		/// KOSPI200지수
		/// </summary>
		[XAQueryFieldAttribute("kospijisu", "KOSPI200지수", "float", "6.2")]
		public float kospijisu;
		/// <summary>
		/// KOSPI200전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("kospisign", "KOSPI200전일대비구분", "char", "1")]
		public char kospisign;
		/// <summary>
		/// KOSPI200전일대비
		/// </summary>
		[XAQueryFieldAttribute("kospichange", "KOSPI200전일대비", "float", "6.2")]
		public float kospichange;
		/// <summary>
		/// KOSPI200등락율
		/// </summary>
		[XAQueryFieldAttribute("kospidiff", "KOSPI200등락율", "float", "6.2")]
		public float kospidiff;
		/// <summary>
		/// 상장최고가
		/// </summary>
		[XAQueryFieldAttribute("listhprice", "상장최고가", "float", "6.2")]
		public float listhprice;
		/// <summary>
		/// 상장최저가
		/// </summary>
		[XAQueryFieldAttribute("listlprice", "상장최저가", "float", "6.2")]
		public float listlprice;
		/// <summary>
		/// 시장BASIS
		/// </summary>
		[XAQueryFieldAttribute("sbasis", "시장BASIS", "float", "6.2")]
		public float sbasis;
		/// <summary>
		/// 이론BASIS
		/// </summary>
		[XAQueryFieldAttribute("ibasis", "이론BASIS", "float", "6.2")]
		public float ibasis;
		/// <summary>
		/// 전일거래량
		/// </summary>
		[XAQueryFieldAttribute("jnilvolume", "전일거래량", "long", "12")]
		public long jnilvolume;
		/// <summary>
		/// 전일거래대금
		/// </summary>
		[XAQueryFieldAttribute("jnilvalue", "전일거래대금", "long", "12")]
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
			/// 미결제량
			/// </summary>
			public const string mgjv = "mgjv";
			/// <summary>
			/// 미결제증감
			/// </summary>
			public const string mgjvdiff = "mgjvdiff";
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
			/// 상한가
			/// </summary>
			public const string uplmtprice = "uplmtprice";
			/// <summary>
			/// 하한가
			/// </summary>
			public const string dnlmtprice = "dnlmtprice";
			/// <summary>
			/// 52최고가
			/// </summary>
			public const string high52w = "high52w";
			/// <summary>
			/// 52최저가
			/// </summary>
			public const string low52w = "low52w";
			/// <summary>
			/// 베이시스
			/// </summary>
			public const string basis = "basis";
			/// <summary>
			/// 기준가
			/// </summary>
			public const string recprice = "recprice";
			/// <summary>
			/// 이론가
			/// </summary>
			public const string theoryprice = "theoryprice";
			/// <summary>
			/// 괴리율
			/// </summary>
			public const string glyl = "glyl";
			/// <summary>
			/// CB상한가
			/// </summary>
			public const string cbhprice = "cbhprice";
			/// <summary>
			/// CB하한가
			/// </summary>
			public const string cblprice = "cblprice";
			/// <summary>
			/// 만기일
			/// </summary>
			public const string lastmonth = "lastmonth";
			/// <summary>
			/// 잔여일
			/// </summary>
			public const string jandatecnt = "jandatecnt";
			/// <summary>
			/// 종합지수
			/// </summary>
			public const string pricejisu = "pricejisu";
			/// <summary>
			/// 종합지수전일대비구분
			/// </summary>
			public const string jisusign = "jisusign";
			/// <summary>
			/// 종합지수전일대비
			/// </summary>
			public const string jisuchange = "jisuchange";
			/// <summary>
			/// 종합지수등락율
			/// </summary>
			public const string jisudiff = "jisudiff";
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
			/// 상장최고가
			/// </summary>
			public const string listhprice = "listhprice";
			/// <summary>
			/// 상장최저가
			/// </summary>
			public const string listlprice = "listlprice";
			/// <summary>
			/// 시장BASIS
			/// </summary>
			public const string sbasis = "sbasis";
			/// <summary>
			/// 이론BASIS
			/// </summary>
			public const string ibasis = "ibasis";
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
			F.mgjv,
			F.mgjvdiff,
			F.open,
			F.high,
			F.low,
			F.uplmtprice,
			F.dnlmtprice,
			F.high52w,
			F.low52w,
			F.basis,
			F.recprice,
			F.theoryprice,
			F.glyl,
			F.cbhprice,
			F.cblprice,
			F.lastmonth,
			F.jandatecnt,
			F.pricejisu,
			F.jisusign,
			F.jisuchange,
			F.jisudiff,
			F.kospijisu,
			F.kospisign,
			F.kospichange,
			F.kospidiff,
			F.listhprice,
			F.listlprice,
			F.sbasis,
			F.ibasis,
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
			dict["mgjv"] = new XAQueryFieldInfo("long", mgjv, mgjv.ToString("d8"), "미결제량", (decimal)8);
			dict["mgjvdiff"] = new XAQueryFieldInfo("long", mgjvdiff, mgjvdiff.ToString("d8"), "미결제증감", (decimal)8);
			dict["open"] = new XAQueryFieldInfo("float", open, open.ToString("000000.00"), "시가", (decimal)6.2);
			dict["high"] = new XAQueryFieldInfo("float", high, high.ToString("000000.00"), "고가", (decimal)6.2);
			dict["low"] = new XAQueryFieldInfo("float", low, low.ToString("000000.00"), "저가", (decimal)6.2);
			dict["uplmtprice"] = new XAQueryFieldInfo("float", uplmtprice, uplmtprice.ToString("000000.00"), "상한가", (decimal)6.2);
			dict["dnlmtprice"] = new XAQueryFieldInfo("float", dnlmtprice, dnlmtprice.ToString("000000.00"), "하한가", (decimal)6.2);
			dict["high52w"] = new XAQueryFieldInfo("float", high52w, high52w.ToString("000000.00"), "52최고가", (decimal)6.2);
			dict["low52w"] = new XAQueryFieldInfo("float", low52w, low52w.ToString("000000.00"), "52최저가", (decimal)6.2);
			dict["basis"] = new XAQueryFieldInfo("float", basis, basis.ToString("000000.00"), "베이시스", (decimal)6.2);
			dict["recprice"] = new XAQueryFieldInfo("float", recprice, recprice.ToString("000000.00"), "기준가", (decimal)6.2);
			dict["theoryprice"] = new XAQueryFieldInfo("float", theoryprice, theoryprice.ToString("000000.00"), "이론가", (decimal)6.2);
			dict["glyl"] = new XAQueryFieldInfo("float", glyl, glyl.ToString("000000.000"), "괴리율", (decimal)6.3);
			dict["cbhprice"] = new XAQueryFieldInfo("float", cbhprice, cbhprice.ToString("000000.00"), "CB상한가", (decimal)6.2);
			dict["cblprice"] = new XAQueryFieldInfo("float", cblprice, cblprice.ToString("000000.00"), "CB하한가", (decimal)6.2);
			dict["lastmonth"] = new XAQueryFieldInfo("char", lastmonth, lastmonth, "만기일", (decimal)8);
			dict["jandatecnt"] = new XAQueryFieldInfo("long", jandatecnt, jandatecnt.ToString("d8"), "잔여일", (decimal)8);
			dict["pricejisu"] = new XAQueryFieldInfo("float", pricejisu, pricejisu.ToString("000000.00"), "종합지수", (decimal)6.2);
			dict["jisusign"] = new XAQueryFieldInfo("char", jisusign, jisusign.ToString(), "종합지수전일대비구분", (decimal)1);
			dict["jisuchange"] = new XAQueryFieldInfo("float", jisuchange, jisuchange.ToString("000000.00"), "종합지수전일대비", (decimal)6.2);
			dict["jisudiff"] = new XAQueryFieldInfo("float", jisudiff, jisudiff.ToString("000000.00"), "종합지수등락율", (decimal)6.2);
			dict["kospijisu"] = new XAQueryFieldInfo("float", kospijisu, kospijisu.ToString("000000.00"), "KOSPI200지수", (decimal)6.2);
			dict["kospisign"] = new XAQueryFieldInfo("char", kospisign, kospisign.ToString(), "KOSPI200전일대비구분", (decimal)1);
			dict["kospichange"] = new XAQueryFieldInfo("float", kospichange, kospichange.ToString("000000.00"), "KOSPI200전일대비", (decimal)6.2);
			dict["kospidiff"] = new XAQueryFieldInfo("float", kospidiff, kospidiff.ToString("000000.00"), "KOSPI200등락율", (decimal)6.2);
			dict["listhprice"] = new XAQueryFieldInfo("float", listhprice, listhprice.ToString("000000.00"), "상장최고가", (decimal)6.2);
			dict["listlprice"] = new XAQueryFieldInfo("float", listlprice, listlprice.ToString("000000.00"), "상장최저가", (decimal)6.2);
			dict["sbasis"] = new XAQueryFieldInfo("float", sbasis, sbasis.ToString("000000.00"), "시장BASIS", (decimal)6.2);
			dict["ibasis"] = new XAQueryFieldInfo("float", ibasis, ibasis.ToString("000000.00"), "이론BASIS", (decimal)6.2);
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

				case "mgjv":
					this.mgjv = fieldInfo.FieldValue.ParseLong("mgjv");
				break;

				case "mgjvdiff":
					this.mgjvdiff = fieldInfo.FieldValue.ParseLong("mgjvdiff");
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

				case "uplmtprice":
					this.uplmtprice = fieldInfo.FieldValue.ParseFloat("uplmtprice");
				break;

				case "dnlmtprice":
					this.dnlmtprice = fieldInfo.FieldValue.ParseFloat("dnlmtprice");
				break;

				case "high52w":
					this.high52w = fieldInfo.FieldValue.ParseFloat("high52w");
				break;

				case "low52w":
					this.low52w = fieldInfo.FieldValue.ParseFloat("low52w");
				break;

				case "basis":
					this.basis = fieldInfo.FieldValue.ParseFloat("basis");
				break;

				case "recprice":
					this.recprice = fieldInfo.FieldValue.ParseFloat("recprice");
				break;

				case "theoryprice":
					this.theoryprice = fieldInfo.FieldValue.ParseFloat("theoryprice");
				break;

				case "glyl":
					this.glyl = fieldInfo.FieldValue.ParseFloat("glyl");
				break;

				case "cbhprice":
					this.cbhprice = fieldInfo.FieldValue.ParseFloat("cbhprice");
				break;

				case "cblprice":
					this.cblprice = fieldInfo.FieldValue.ParseFloat("cblprice");
				break;

				case "lastmonth":
					this.lastmonth = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "jandatecnt":
					this.jandatecnt = fieldInfo.FieldValue.ParseLong("jandatecnt");
				break;

				case "pricejisu":
					this.pricejisu = fieldInfo.FieldValue.ParseFloat("pricejisu");
				break;

				case "jisusign":
					this.jisusign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "jisuchange":
					this.jisuchange = fieldInfo.FieldValue.ParseFloat("jisuchange");
				break;

				case "jisudiff":
					this.jisudiff = fieldInfo.FieldValue.ParseFloat("jisudiff");
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

				case "listhprice":
					this.listhprice = fieldInfo.FieldValue.ParseFloat("listhprice");
				break;

				case "listlprice":
					this.listlprice = fieldInfo.FieldValue.ParseFloat("listlprice");
				break;

				case "sbasis":
					this.sbasis = fieldInfo.FieldValue.ParseFloat("sbasis");
				break;

				case "ibasis":
					this.ibasis = fieldInfo.FieldValue.ParseFloat("ibasis");
				break;

				case "jnilvolume":
					this.jnilvolume = fieldInfo.FieldValue.ParseLong("jnilvolume");
				break;

				case "jnilvalue":
					this.jnilvalue = fieldInfo.FieldValue.ParseLong("jnilvalue");
				break;


			}
		}

		public static XQt2801OutBlock FromQuery(XQt2801 query)
		{
			XQt2801OutBlock block = new XQt2801OutBlock();
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
				block.mgjv = query.GetFieldData(block.GetBlockName(), "mgjv", 0).ParseLong("mgjv"); // long 8
				block.mgjvdiff = query.GetFieldData(block.GetBlockName(), "mgjvdiff", 0).ParseLong("mgjvdiff"); // long 8
				block.open = query.GetFieldData(block.GetBlockName(), "open", 0).ParseFloat("open"); // float 6.2
				block.high = query.GetFieldData(block.GetBlockName(), "high", 0).ParseFloat("high"); // float 6.2
				block.low = query.GetFieldData(block.GetBlockName(), "low", 0).ParseFloat("low"); // float 6.2
				block.uplmtprice = query.GetFieldData(block.GetBlockName(), "uplmtprice", 0).ParseFloat("uplmtprice"); // float 6.2
				block.dnlmtprice = query.GetFieldData(block.GetBlockName(), "dnlmtprice", 0).ParseFloat("dnlmtprice"); // float 6.2
				block.high52w = query.GetFieldData(block.GetBlockName(), "high52w", 0).ParseFloat("high52w"); // float 6.2
				block.low52w = query.GetFieldData(block.GetBlockName(), "low52w", 0).ParseFloat("low52w"); // float 6.2
				block.basis = query.GetFieldData(block.GetBlockName(), "basis", 0).ParseFloat("basis"); // float 6.2
				block.recprice = query.GetFieldData(block.GetBlockName(), "recprice", 0).ParseFloat("recprice"); // float 6.2
				block.theoryprice = query.GetFieldData(block.GetBlockName(), "theoryprice", 0).ParseFloat("theoryprice"); // float 6.2
				block.glyl = query.GetFieldData(block.GetBlockName(), "glyl", 0).ParseFloat("glyl"); // float 6.3
				block.cbhprice = query.GetFieldData(block.GetBlockName(), "cbhprice", 0).ParseFloat("cbhprice"); // float 6.2
				block.cblprice = query.GetFieldData(block.GetBlockName(), "cblprice", 0).ParseFloat("cblprice"); // float 6.2
				block.lastmonth = query.GetFieldData(block.GetBlockName(), "lastmonth", 0).TrimEnd('?'); // char 8
				block.jandatecnt = query.GetFieldData(block.GetBlockName(), "jandatecnt", 0).ParseLong("jandatecnt"); // long 8
				block.pricejisu = query.GetFieldData(block.GetBlockName(), "pricejisu", 0).ParseFloat("pricejisu"); // float 6.2
				block.jisusign = query.GetFieldData(block.GetBlockName(), "jisusign", 0).FirstOrDefault(); // char 1
				block.jisuchange = query.GetFieldData(block.GetBlockName(), "jisuchange", 0).ParseFloat("jisuchange"); // float 6.2
				block.jisudiff = query.GetFieldData(block.GetBlockName(), "jisudiff", 0).ParseFloat("jisudiff"); // float 6.2
				block.kospijisu = query.GetFieldData(block.GetBlockName(), "kospijisu", 0).ParseFloat("kospijisu"); // float 6.2
				block.kospisign = query.GetFieldData(block.GetBlockName(), "kospisign", 0).FirstOrDefault(); // char 1
				block.kospichange = query.GetFieldData(block.GetBlockName(), "kospichange", 0).ParseFloat("kospichange"); // float 6.2
				block.kospidiff = query.GetFieldData(block.GetBlockName(), "kospidiff", 0).ParseFloat("kospidiff"); // float 6.2
				block.listhprice = query.GetFieldData(block.GetBlockName(), "listhprice", 0).ParseFloat("listhprice"); // float 6.2
				block.listlprice = query.GetFieldData(block.GetBlockName(), "listlprice", 0).ParseFloat("listlprice"); // float 6.2
				block.sbasis = query.GetFieldData(block.GetBlockName(), "sbasis", 0).ParseFloat("sbasis"); // float 6.2
				block.ibasis = query.GetFieldData(block.GetBlockName(), "ibasis", 0).ParseFloat("ibasis"); // float 6.2
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
			if (mgjv.ToString().Length > 8) return false; // long 8
			if (mgjvdiff.ToString().Length > 8) return false; // long 8
			// open float 6.2
			// high float 6.2
			// low float 6.2
			// uplmtprice float 6.2
			// dnlmtprice float 6.2
			// high52w float 6.2
			// low52w float 6.2
			// basis float 6.2
			// recprice float 6.2
			// theoryprice float 6.2
			// glyl float 6.3
			// cbhprice float 6.2
			// cblprice float 6.2
			if (lastmonth?.Length > 8) return false; // char 8
			if (jandatecnt.ToString().Length > 8) return false; // long 8
			// pricejisu float 6.2
			// jisusign char 1
			// jisuchange float 6.2
			// jisudiff float 6.2
			// kospijisu float 6.2
			// kospisign char 1
			// kospichange float 6.2
			// kospidiff float 6.2
			// listhprice float 6.2
			// listlprice float 6.2
			// sbasis float 6.2
			// ibasis float 6.2
			if (jnilvolume.ToString().Length > 12) return false; // long 12
			if (jnilvalue.ToString().Length > 12) return false; // long 12

			return true;
		}

		public void CopyTo(XQt2801OutBlock block)
		{
			block.hname = this.hname;
			block.price = this.price;
			block.sign = this.sign;
			block.change = this.change;
			block.jnilclose = this.jnilclose;
			block.diff = this.diff;
			block.volume = this.volume;
			block.value = this.value;
			block.mgjv = this.mgjv;
			block.mgjvdiff = this.mgjvdiff;
			block.open = this.open;
			block.high = this.high;
			block.low = this.low;
			block.uplmtprice = this.uplmtprice;
			block.dnlmtprice = this.dnlmtprice;
			block.high52w = this.high52w;
			block.low52w = this.low52w;
			block.basis = this.basis;
			block.recprice = this.recprice;
			block.theoryprice = this.theoryprice;
			block.glyl = this.glyl;
			block.cbhprice = this.cbhprice;
			block.cblprice = this.cblprice;
			block.lastmonth = this.lastmonth;
			block.jandatecnt = this.jandatecnt;
			block.pricejisu = this.pricejisu;
			block.jisusign = this.jisusign;
			block.jisuchange = this.jisuchange;
			block.jisudiff = this.jisudiff;
			block.kospijisu = this.kospijisu;
			block.kospisign = this.kospisign;
			block.kospichange = this.kospichange;
			block.kospidiff = this.kospidiff;
			block.listhprice = this.listhprice;
			block.listlprice = this.listlprice;
			block.sbasis = this.sbasis;
			block.ibasis = this.ibasis;
			block.jnilvolume = this.jnilvolume;
			block.jnilvalue = this.jnilvalue;

		}
	}

	/// <summary>
	/// CME야간선물현재가조회(t2801)
	/// </summary>
	public partial class XQt2801 : XingQuery
	{
		/// <summary>
		/// t2801
		/// </summary>
		public const string _typeName = "t2801";
		/// <summary>
		/// CME야간선물현재가조회(t2801)
		/// </summary>
		public const string _typeDesc = "CME야간선물현재가조회(t2801)";
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
		/// t2801
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// CME야간선물현재가조회(t2801)
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
		/// CME야간선물현재가조회(t2801)
		/// </summary>
		public XQt2801() : base("t2801") { }


		public static XQt2801OutBlock Get(string focode = default)
		{
			using (XQt2801 instance = new XQt2801())
			{
				instance.SetFieldData(XQt2801InBlock.BlockName, XQt2801InBlock.F.focode, 0, focode); // char 8

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

		public static XQt2801OutBlock ReadFromDB(string tableNamePostfix = null /*, string focode = default */)
		{
			using (XQt2801 instance = new XQt2801())
			{

				string tableName = (tableNamePostfix == null) ? "XQt2801OutBlock" : $"XQt2801OutBlock_{tableNamePostfix}";
				QueryOption qo = new QueryOption(tableName);
				// if (focode != default) qo.Add("focode", focode);


				var outBlock = instance.Select<XQt2801OutBlock>(qo);
				return outBlock;
			}
		}

		public bool SetBlock(XQt2801InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "focode", 0, block.focode); // char 8

			return true;
		}

		public XQt2801OutBlock GetBlock()
		{
			XQt2801OutBlock instance = XQt2801OutBlock.FromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt2801OutBlock),

		};

	}

}
