using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1427InBlock : XingBlock
	{
		/// <summary>
		/// t1427InBlock
		/// </summary>
		public const string _blockName = "t1427InBlock";
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
		/// t1427InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1427InBlock
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
		/// 조회구분
		/// </summary>
		[XAQueryFieldAttribute("조회구분")]
		public char qrygb;
		/// <summary>
		/// 구분
		/// </summary>
		[XAQueryFieldAttribute("구분")]
		public char gubun;
		/// <summary>
		/// 상하한가구분
		/// </summary>
		[XAQueryFieldAttribute("상하한가구분")]
		public char signgubun;
		/// <summary>
		/// 등락율
		/// </summary>
		[XAQueryFieldAttribute("등락율")]
		public long diff;
		/// <summary>
		/// 대상제외
		/// </summary>
		[XAQueryFieldAttribute("대상제외")]
		public long jc_num;
		/// <summary>
		/// 시작가격
		/// </summary>
		[XAQueryFieldAttribute("시작가격")]
		public long sprice;
		/// <summary>
		/// 종료가격
		/// </summary>
		[XAQueryFieldAttribute("종료가격")]
		public long eprice;
		/// <summary>
		/// 거래량
		/// </summary>
		[XAQueryFieldAttribute("거래량")]
		public long volume;
		/// <summary>
		/// IDX
		/// </summary>
		[XAQueryFieldAttribute("IDX")]
		public long idx;
		/// <summary>
		/// 전일상하한제외
		/// </summary>
		[XAQueryFieldAttribute("전일상하한제외")]
		public char jshex;

		public static class F
		{
			/// <summary>
			/// 조회구분
			/// </summary>
			public const string qrygb = "qrygb";
			/// <summary>
			/// 구분
			/// </summary>
			public const string gubun = "gubun";
			/// <summary>
			/// 상하한가구분
			/// </summary>
			public const string signgubun = "signgubun";
			/// <summary>
			/// 등락율
			/// </summary>
			public const string diff = "diff";
			/// <summary>
			/// 대상제외
			/// </summary>
			public const string jc_num = "jc_num";
			/// <summary>
			/// 시작가격
			/// </summary>
			public const string sprice = "sprice";
			/// <summary>
			/// 종료가격
			/// </summary>
			public const string eprice = "eprice";
			/// <summary>
			/// 거래량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// IDX
			/// </summary>
			public const string idx = "idx";
			/// <summary>
			/// 전일상하한제외
			/// </summary>
			public const string jshex = "jshex";
		}

		public static string[] AllFields = new string[]
		{
			F.qrygb,
			F.gubun,
			F.signgubun,
			F.diff,
			F.jc_num,
			F.sprice,
			F.eprice,
			F.volume,
			F.idx,
			F.jshex,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["qrygb"] = new XAQueryFieldInfo("char", qrygb, qrygb.ToString(), "조회구분", (decimal)1);
			dict["gubun"] = new XAQueryFieldInfo("char", gubun, gubun.ToString(), "구분", (decimal)1);
			dict["signgubun"] = new XAQueryFieldInfo("char", signgubun, signgubun.ToString(), "상하한가구분", (decimal)1);
			dict["diff"] = new XAQueryFieldInfo("long", diff, diff.ToString("d3"), "등락율", (decimal)3);
			dict["jc_num"] = new XAQueryFieldInfo("long", jc_num, jc_num.ToString("d12"), "대상제외", (decimal)12);
			dict["sprice"] = new XAQueryFieldInfo("long", sprice, sprice.ToString("d8"), "시작가격", (decimal)8);
			dict["eprice"] = new XAQueryFieldInfo("long", eprice, eprice.ToString("d8"), "종료가격", (decimal)8);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "거래량", (decimal)12);
			dict["idx"] = new XAQueryFieldInfo("long", idx, idx.ToString("d4"), "IDX", (decimal)4);
			dict["jshex"] = new XAQueryFieldInfo("char", jshex, jshex.ToString(), "전일상하한제외", (decimal)1);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "qrygb":
					this.qrygb = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "gubun":
					this.gubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "signgubun":
					this.signgubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "diff":
					this.diff = fieldInfo.FieldValue.ParseLong("diff");
				break;

				case "jc_num":
					this.jc_num = fieldInfo.FieldValue.ParseLong("jc_num");
				break;

				case "sprice":
					this.sprice = fieldInfo.FieldValue.ParseLong("sprice");
				break;

				case "eprice":
					this.eprice = fieldInfo.FieldValue.ParseLong("eprice");
				break;

				case "volume":
					this.volume = fieldInfo.FieldValue.ParseLong("volume");
				break;

				case "idx":
					this.idx = fieldInfo.FieldValue.ParseLong("idx");
				break;

				case "jshex":
					this.jshex = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public bool VerifyData()
		{
			// qrygb char 1
			// gubun char 1
			// signgubun char 1
			if (diff.ToString().Length > 3) return false; // long 3
			if (jc_num.ToString().Length > 12) return false; // long 12
			if (sprice.ToString().Length > 8) return false; // long 8
			if (eprice.ToString().Length > 8) return false; // long 8
			if (volume.ToString().Length > 12) return false; // long 12
			if (idx.ToString().Length > 4) return false; // long 4
			// jshex char 1

			return true;
		}
	}

	public partial class XQt1427OutBlock : XingBlock
	{
		/// <summary>
		/// t1427OutBlock
		/// </summary>
		public const string _blockName = "t1427OutBlock";
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
		/// t1427OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1427OutBlock
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
			/// IDX
			/// </summary>
			public const string idx = "idx";
		}

		public static string[] AllFields = new string[]
		{
			F.cnt,
			F.idx,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["cnt"] = new XAQueryFieldInfo("long", cnt, cnt.ToString("d4"), "CNT", (decimal)4);
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

				case "idx":
					this.idx = fieldInfo.FieldValue.ParseLong("idx");
				break;


			}
		}

		public static XQt1427OutBlock FromQuery(XQt1427 query)
		{
			XQt1427OutBlock block = new XQt1427OutBlock();
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
			if (idx.ToString().Length > 4) return false; // long 4

			return true;
		}
	}

	public partial class XQt1427OutBlock1 : XingBlock
	{
		/// <summary>
		/// t1427OutBlock1
		/// </summary>
		public const string _blockName = "t1427OutBlock1";
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
		/// t1427OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1427OutBlock1
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
		/// 한글명
		/// </summary>
		[XAQueryFieldAttribute("한글명")]
		public string hname;
		/// <summary>
		/// 현재가
		/// </summary>
		[XAQueryFieldAttribute("현재가")]
		public long price;
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
		/// 상한가/하한가
		/// </summary>
		[XAQueryFieldAttribute("상한가/하한가")]
		public long lmtprice;
		/// <summary>
		/// 대비율
		/// </summary>
		[XAQueryFieldAttribute("대비율")]
		public float rate;
		/// <summary>
		/// 종목코드
		/// </summary>
		[XAQueryFieldAttribute("종목코드")]
		public string shcode;
		/// <summary>
		/// 전일거래량
		/// </summary>
		[XAQueryFieldAttribute("전일거래량")]
		public long jnilvolume;
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
		/// 연속
		/// </summary>
		[XAQueryFieldAttribute("연속")]
		public long lmtdaycnt;
		/// <summary>
		/// 거래대금
		/// </summary>
		[XAQueryFieldAttribute("거래대금")]
		public long value;
		/// <summary>
		/// 시가총액
		/// </summary>
		[XAQueryFieldAttribute("시가총액")]
		public long total;

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
			/// 상한가/하한가
			/// </summary>
			public const string lmtprice = "lmtprice";
			/// <summary>
			/// 대비율
			/// </summary>
			public const string rate = "rate";
			/// <summary>
			/// 종목코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 전일거래량
			/// </summary>
			public const string jnilvolume = "jnilvolume";
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
			/// 연속
			/// </summary>
			public const string lmtdaycnt = "lmtdaycnt";
			/// <summary>
			/// 거래대금
			/// </summary>
			public const string value = "value";
			/// <summary>
			/// 시가총액
			/// </summary>
			public const string total = "total";
		}

		public static string[] AllFields = new string[]
		{
			F.hname,
			F.price,
			F.sign,
			F.change,
			F.diff,
			F.volume,
			F.diff_vol,
			F.lmtprice,
			F.rate,
			F.shcode,
			F.jnilvolume,
			F.open,
			F.high,
			F.low,
			F.lmtdaycnt,
			F.value,
			F.total,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["hname"] = new XAQueryFieldInfo("char", hname, hname, "한글명", (decimal)20);
			dict["price"] = new XAQueryFieldInfo("long", price, price.ToString("d8"), "현재가", (decimal)8);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("long", change, change.ToString("d8"), "전일대비", (decimal)8);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "누적거래량", (decimal)12);
			dict["diff_vol"] = new XAQueryFieldInfo("float", diff_vol, diff_vol.ToString("0000000000.00"), "거래증가율", (decimal)10.2);
			dict["lmtprice"] = new XAQueryFieldInfo("long", lmtprice, lmtprice.ToString("d8"), "상한가/하한가", (decimal)8);
			dict["rate"] = new XAQueryFieldInfo("float", rate, rate.ToString("000000000000.00"), "대비율", (decimal)12.2);
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "종목코드", (decimal)6);
			dict["jnilvolume"] = new XAQueryFieldInfo("long", jnilvolume, jnilvolume.ToString("d12"), "전일거래량", (decimal)12);
			dict["open"] = new XAQueryFieldInfo("long", open, open.ToString("d8"), "시가", (decimal)8);
			dict["high"] = new XAQueryFieldInfo("long", high, high.ToString("d8"), "고가", (decimal)8);
			dict["low"] = new XAQueryFieldInfo("long", low, low.ToString("d8"), "저가", (decimal)8);
			dict["lmtdaycnt"] = new XAQueryFieldInfo("long", lmtdaycnt, lmtdaycnt.ToString("d8"), "연속", (decimal)8);
			dict["value"] = new XAQueryFieldInfo("long", value, value.ToString("d12"), "거래대금", (decimal)12);
			dict["total"] = new XAQueryFieldInfo("long", total, total.ToString("d12"), "시가총액", (decimal)12);

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
					this.price = fieldInfo.FieldValue.ParseLong("price");
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

				case "lmtprice":
					this.lmtprice = fieldInfo.FieldValue.ParseLong("lmtprice");
				break;

				case "rate":
					this.rate = fieldInfo.FieldValue.ParseFloat("rate");
				break;

				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "jnilvolume":
					this.jnilvolume = fieldInfo.FieldValue.ParseLong("jnilvolume");
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

				case "lmtdaycnt":
					this.lmtdaycnt = fieldInfo.FieldValue.ParseLong("lmtdaycnt");
				break;

				case "value":
					this.value = fieldInfo.FieldValue.ParseLong("value");
				break;

				case "total":
					this.total = fieldInfo.FieldValue.ParseLong("total");
				break;


			}
		}

		public static XQt1427OutBlock1[] ListFromQuery(XQt1427 query)
		{
			int count = query.GetBlockCount(XQt1427OutBlock1.BlockName);
			List<XQt1427OutBlock1> list = new List<XQt1427OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1427OutBlock1 block = new XQt1427OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.hname = query.GetFieldData(block.GetBlockName(), "hname", i).TrimEnd('?'); // char 20
					block.price = query.GetFieldData(block.GetBlockName(), "price", i).ParseLong("price"); // long 8
					block.sign = query.GetFieldData(block.GetBlockName(), "sign", i).FirstOrDefault(); // char 1
					block.change = query.GetFieldData(block.GetBlockName(), "change", i).ParseLong("change"); // long 8
					block.diff = query.GetFieldData(block.GetBlockName(), "diff", i).ParseFloat("diff"); // float 6.2
					block.volume = query.GetFieldData(block.GetBlockName(), "volume", i).ParseLong("volume"); // long 12
					block.diff_vol = query.GetFieldData(block.GetBlockName(), "diff_vol", i).ParseFloat("diff_vol"); // float 10.2
					block.lmtprice = query.GetFieldData(block.GetBlockName(), "lmtprice", i).ParseLong("lmtprice"); // long 8
					block.rate = query.GetFieldData(block.GetBlockName(), "rate", i).ParseFloat("rate"); // float 12.2
					block.shcode = query.GetFieldData(block.GetBlockName(), "shcode", i).TrimEnd('?'); // char 6
					block.jnilvolume = query.GetFieldData(block.GetBlockName(), "jnilvolume", i).ParseLong("jnilvolume"); // long 12
					block.open = query.GetFieldData(block.GetBlockName(), "open", i).ParseLong("open"); // long 8
					block.high = query.GetFieldData(block.GetBlockName(), "high", i).ParseLong("high"); // long 8
					block.low = query.GetFieldData(block.GetBlockName(), "low", i).ParseLong("low"); // long 8
					block.lmtdaycnt = query.GetFieldData(block.GetBlockName(), "lmtdaycnt", i).ParseLong("lmtdaycnt"); // long 8
					block.value = query.GetFieldData(block.GetBlockName(), "value", i).ParseLong("value"); // long 12
					block.total = query.GetFieldData(block.GetBlockName(), "total", i).ParseLong("total"); // long 12

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
			if (hname?.Length > 20) return false; // char 20
			if (price.ToString().Length > 8) return false; // long 8
			// sign char 1
			if (change.ToString().Length > 8) return false; // long 8
			// diff float 6.2
			if (volume.ToString().Length > 12) return false; // long 12
			// diff_vol float 10.2
			if (lmtprice.ToString().Length > 8) return false; // long 8
			// rate float 12.2
			if (shcode?.Length > 6) return false; // char 6
			if (jnilvolume.ToString().Length > 12) return false; // long 12
			if (open.ToString().Length > 8) return false; // long 8
			if (high.ToString().Length > 8) return false; // long 8
			if (low.ToString().Length > 8) return false; // long 8
			if (lmtdaycnt.ToString().Length > 8) return false; // long 8
			if (value.ToString().Length > 12) return false; // long 12
			if (total.ToString().Length > 12) return false; // long 12

			return true;
		}
	}

	/// <summary>
	/// 상/하한가직전(t1427)
	/// </summary>
	public partial class XQt1427 : XingQuery
	{
		/// <summary>
		/// t1427
		/// </summary>
		public const string _typeName = "t1427";
		/// <summary>
		/// 상/하한가직전(t1427)
		/// </summary>
		public const string _typeDesc = "상/하한가직전(t1427)";
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
		/// t1427
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 상/하한가직전(t1427)
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
		/// 상/하한가직전(t1427)
		/// </summary>
		public XQt1427() : base("t1427") { }


		public static XQt1427OutBlock1[] Get(char qrygb = default,char gubun = default,char signgubun = default,long diff = default,long jc_num = default,long sprice = default,long eprice = default,long volume = default,long idx = default,char jshex = default)
		{
			using (XQt1427 instance = new XQt1427())
			{
				instance.SetFieldData(XQt1427InBlock.BlockName, XQt1427InBlock.F.qrygb, 0, qrygb.ToString()); // char 1
				instance.SetFieldData(XQt1427InBlock.BlockName, XQt1427InBlock.F.gubun, 0, gubun.ToString()); // char 1
				instance.SetFieldData(XQt1427InBlock.BlockName, XQt1427InBlock.F.signgubun, 0, signgubun.ToString()); // char 1
				instance.SetFieldData(XQt1427InBlock.BlockName, XQt1427InBlock.F.diff, 0, diff.ToString("d3")); // long 3
				instance.SetFieldData(XQt1427InBlock.BlockName, XQt1427InBlock.F.jc_num, 0, jc_num.ToString("d12")); // long 12
				instance.SetFieldData(XQt1427InBlock.BlockName, XQt1427InBlock.F.sprice, 0, sprice.ToString("d8")); // long 8
				instance.SetFieldData(XQt1427InBlock.BlockName, XQt1427InBlock.F.eprice, 0, eprice.ToString("d8")); // long 8
				instance.SetFieldData(XQt1427InBlock.BlockName, XQt1427InBlock.F.volume, 0, volume.ToString("d12")); // long 12
				instance.SetFieldData(XQt1427InBlock.BlockName, XQt1427InBlock.F.idx, 0, idx.ToString("d4")); // long 4
				instance.SetFieldData(XQt1427InBlock.BlockName, XQt1427InBlock.F.jshex, 0, jshex.ToString()); // char 1

				if (instance.Request() < 0)
				{
					return null;
				}

				var outBlock = instance.GetBlock1s();
				return outBlock;
			}
		}

		public bool SetBlock(XQt1427InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "qrygb", 0, block.qrygb.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "gubun", 0, block.gubun.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "signgubun", 0, block.signgubun.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "diff", 0, block.diff.ToString("d3")); // long 3
			_xaQuery.SetFieldData(block.GetBlockName(), "jc_num", 0, block.jc_num.ToString("d12")); // long 12
			_xaQuery.SetFieldData(block.GetBlockName(), "sprice", 0, block.sprice.ToString("d8")); // long 8
			_xaQuery.SetFieldData(block.GetBlockName(), "eprice", 0, block.eprice.ToString("d8")); // long 8
			_xaQuery.SetFieldData(block.GetBlockName(), "volume", 0, block.volume.ToString("d12")); // long 12
			_xaQuery.SetFieldData(block.GetBlockName(), "idx", 0, block.idx.ToString("d4")); // long 4
			_xaQuery.SetFieldData(block.GetBlockName(), "jshex", 0, block.jshex.ToString()); // char 1

			return true;
		}

		public XQt1427OutBlock GetBlock()
		{
			XQt1427OutBlock instance = XQt1427OutBlock.FromQuery(this);
			return instance;

		}

		public XQt1427OutBlock1[] GetBlock1s()
		{
			XQt1427OutBlock1[] instance = XQt1427OutBlock1.ListFromQuery(this);
			return instance;

		}


	}

}
