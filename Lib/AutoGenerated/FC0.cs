using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XRFC0InBlock : XingBlock
	{
		/// <summary>
		/// InBlock
		/// </summary>
		public const string _blockName = "InBlock";
		/// <summary>
		/// 입력
		/// </summary>
		public const string _blockDesc = "입력";
		/// <summary>
		/// input
		/// </summary>
		public const string _blockType = "input";
		/// <summary>
		/// false
		/// </summary>
		public const bool _hasOccurs = false;
		/// <summary>
		/// InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// InBlock
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// 입력
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
		public string futcode;

		public static class F
		{
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string futcode = "futcode";
		}

		public static string[] AllFields = new string[]
		{
			F.futcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["futcode"] = new XAQueryFieldInfo("char", futcode, futcode, "단축코드", (decimal)8);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "futcode":
					this.futcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (futcode?.Length > 8) return false; // char 8

			return true;
		}
	}

	public partial class XRFC0OutBlock : XingBlock
	{
		/// <summary>
		/// OutBlock
		/// </summary>
		public const string _blockName = "OutBlock";
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
		/// OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// OutBlock
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
		/// 체결시간
		/// </summary>
		[XAQueryFieldAttribute("체결시간")]
		public string chetime;
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
		/// 등락율
		/// </summary>
		[XAQueryFieldAttribute("등락율")]
		public float drate;
		/// <summary>
		/// 현재가
		/// </summary>
		[XAQueryFieldAttribute("현재가")]
		public float price;
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
		/// 체결구분
		/// </summary>
		[XAQueryFieldAttribute("체결구분")]
		public char cgubun;
		/// <summary>
		/// 체결량
		/// </summary>
		[XAQueryFieldAttribute("체결량")]
		public long cvolume;
		/// <summary>
		/// 누적거래량
		/// </summary>
		[XAQueryFieldAttribute("누적거래량")]
		public long volume;
		/// <summary>
		/// 누적거래대금
		/// </summary>
		[XAQueryFieldAttribute("누적거래대금")]
		public long value;
		/// <summary>
		/// 매도누적체결량
		/// </summary>
		[XAQueryFieldAttribute("매도누적체결량")]
		public long mdvolume;
		/// <summary>
		/// 매도누적체결건수
		/// </summary>
		[XAQueryFieldAttribute("매도누적체결건수")]
		public long mdchecnt;
		/// <summary>
		/// 매수누적체결량
		/// </summary>
		[XAQueryFieldAttribute("매수누적체결량")]
		public long msvolume;
		/// <summary>
		/// 매수누적체결건수
		/// </summary>
		[XAQueryFieldAttribute("매수누적체결건수")]
		public long mschecnt;
		/// <summary>
		/// 체결강도
		/// </summary>
		[XAQueryFieldAttribute("체결강도")]
		public float cpower;
		/// <summary>
		/// 매도호가1
		/// </summary>
		[XAQueryFieldAttribute("매도호가1")]
		public float offerho1;
		/// <summary>
		/// 매수호가1
		/// </summary>
		[XAQueryFieldAttribute("매수호가1")]
		public float bidho1;
		/// <summary>
		/// 미결제약정수량
		/// </summary>
		[XAQueryFieldAttribute("미결제약정수량")]
		public long openyak;
		/// <summary>
		/// KOSPI200지수
		/// </summary>
		[XAQueryFieldAttribute("KOSPI200지수")]
		public float k200jisu;
		/// <summary>
		/// 이론가
		/// </summary>
		[XAQueryFieldAttribute("이론가")]
		public float theoryprice;
		/// <summary>
		/// 괴리율
		/// </summary>
		[XAQueryFieldAttribute("괴리율")]
		public float kasis;
		/// <summary>
		/// 시장BASIS
		/// </summary>
		[XAQueryFieldAttribute("시장BASIS")]
		public float sbasis;
		/// <summary>
		/// 이론BASIS
		/// </summary>
		[XAQueryFieldAttribute("이론BASIS")]
		public float ibasis;
		/// <summary>
		/// 미결제약정증감
		/// </summary>
		[XAQueryFieldAttribute("미결제약정증감")]
		public long openyakcha;
		/// <summary>
		/// 장운영정보
		/// </summary>
		[XAQueryFieldAttribute("장운영정보")]
		public string jgubun;
		/// <summary>
		/// 전일동시간대거래량
		/// </summary>
		[XAQueryFieldAttribute("전일동시간대거래량")]
		public long jnilvolume;
		/// <summary>
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("단축코드")]
		public string futcode;

		public static class F
		{
			/// <summary>
			/// 체결시간
			/// </summary>
			public const string chetime = "chetime";
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
			public const string drate = "drate";
			/// <summary>
			/// 현재가
			/// </summary>
			public const string price = "price";
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
			/// 체결구분
			/// </summary>
			public const string cgubun = "cgubun";
			/// <summary>
			/// 체결량
			/// </summary>
			public const string cvolume = "cvolume";
			/// <summary>
			/// 누적거래량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// 누적거래대금
			/// </summary>
			public const string value = "value";
			/// <summary>
			/// 매도누적체결량
			/// </summary>
			public const string mdvolume = "mdvolume";
			/// <summary>
			/// 매도누적체결건수
			/// </summary>
			public const string mdchecnt = "mdchecnt";
			/// <summary>
			/// 매수누적체결량
			/// </summary>
			public const string msvolume = "msvolume";
			/// <summary>
			/// 매수누적체결건수
			/// </summary>
			public const string mschecnt = "mschecnt";
			/// <summary>
			/// 체결강도
			/// </summary>
			public const string cpower = "cpower";
			/// <summary>
			/// 매도호가1
			/// </summary>
			public const string offerho1 = "offerho1";
			/// <summary>
			/// 매수호가1
			/// </summary>
			public const string bidho1 = "bidho1";
			/// <summary>
			/// 미결제약정수량
			/// </summary>
			public const string openyak = "openyak";
			/// <summary>
			/// KOSPI200지수
			/// </summary>
			public const string k200jisu = "k200jisu";
			/// <summary>
			/// 이론가
			/// </summary>
			public const string theoryprice = "theoryprice";
			/// <summary>
			/// 괴리율
			/// </summary>
			public const string kasis = "kasis";
			/// <summary>
			/// 시장BASIS
			/// </summary>
			public const string sbasis = "sbasis";
			/// <summary>
			/// 이론BASIS
			/// </summary>
			public const string ibasis = "ibasis";
			/// <summary>
			/// 미결제약정증감
			/// </summary>
			public const string openyakcha = "openyakcha";
			/// <summary>
			/// 장운영정보
			/// </summary>
			public const string jgubun = "jgubun";
			/// <summary>
			/// 전일동시간대거래량
			/// </summary>
			public const string jnilvolume = "jnilvolume";
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string futcode = "futcode";
		}

		public static string[] AllFields = new string[]
		{
			F.chetime,
			F.sign,
			F.change,
			F.drate,
			F.price,
			F.open,
			F.high,
			F.low,
			F.cgubun,
			F.cvolume,
			F.volume,
			F.value,
			F.mdvolume,
			F.mdchecnt,
			F.msvolume,
			F.mschecnt,
			F.cpower,
			F.offerho1,
			F.bidho1,
			F.openyak,
			F.k200jisu,
			F.theoryprice,
			F.kasis,
			F.sbasis,
			F.ibasis,
			F.openyakcha,
			F.jgubun,
			F.jnilvolume,
			F.futcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["chetime"] = new XAQueryFieldInfo("char", chetime, chetime, "체결시간", (decimal)6);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("float", change, change.ToString("000000.00"), "전일대비", (decimal)6.2);
			dict["drate"] = new XAQueryFieldInfo("float", drate, drate.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["price"] = new XAQueryFieldInfo("float", price, price.ToString("000000.00"), "현재가", (decimal)6.2);
			dict["open"] = new XAQueryFieldInfo("float", open, open.ToString("000000.00"), "시가", (decimal)6.2);
			dict["high"] = new XAQueryFieldInfo("float", high, high.ToString("000000.00"), "고가", (decimal)6.2);
			dict["low"] = new XAQueryFieldInfo("float", low, low.ToString("000000.00"), "저가", (decimal)6.2);
			dict["cgubun"] = new XAQueryFieldInfo("char", cgubun, cgubun.ToString(), "체결구분", (decimal)1);
			dict["cvolume"] = new XAQueryFieldInfo("long", cvolume, cvolume.ToString("d6"), "체결량", (decimal)6);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "누적거래량", (decimal)12);
			dict["value"] = new XAQueryFieldInfo("long", value, value.ToString("d12"), "누적거래대금", (decimal)12);
			dict["mdvolume"] = new XAQueryFieldInfo("long", mdvolume, mdvolume.ToString("d12"), "매도누적체결량", (decimal)12);
			dict["mdchecnt"] = new XAQueryFieldInfo("long", mdchecnt, mdchecnt.ToString("d8"), "매도누적체결건수", (decimal)8);
			dict["msvolume"] = new XAQueryFieldInfo("long", msvolume, msvolume.ToString("d12"), "매수누적체결량", (decimal)12);
			dict["mschecnt"] = new XAQueryFieldInfo("long", mschecnt, mschecnt.ToString("d8"), "매수누적체결건수", (decimal)8);
			dict["cpower"] = new XAQueryFieldInfo("float", cpower, cpower.ToString("000000000.00"), "체결강도", (decimal)9.2);
			dict["offerho1"] = new XAQueryFieldInfo("float", offerho1, offerho1.ToString("000000.00"), "매도호가1", (decimal)6.2);
			dict["bidho1"] = new XAQueryFieldInfo("float", bidho1, bidho1.ToString("000000.00"), "매수호가1", (decimal)6.2);
			dict["openyak"] = new XAQueryFieldInfo("long", openyak, openyak.ToString("d8"), "미결제약정수량", (decimal)8);
			dict["k200jisu"] = new XAQueryFieldInfo("float", k200jisu, k200jisu.ToString("000000.00"), "KOSPI200지수", (decimal)6.2);
			dict["theoryprice"] = new XAQueryFieldInfo("float", theoryprice, theoryprice.ToString("000000.00"), "이론가", (decimal)6.2);
			dict["kasis"] = new XAQueryFieldInfo("float", kasis, kasis.ToString("000000.00"), "괴리율", (decimal)6.2);
			dict["sbasis"] = new XAQueryFieldInfo("float", sbasis, sbasis.ToString("000000.00"), "시장BASIS", (decimal)6.2);
			dict["ibasis"] = new XAQueryFieldInfo("float", ibasis, ibasis.ToString("000000.00"), "이론BASIS", (decimal)6.2);
			dict["openyakcha"] = new XAQueryFieldInfo("long", openyakcha, openyakcha.ToString("d8"), "미결제약정증감", (decimal)8);
			dict["jgubun"] = new XAQueryFieldInfo("char", jgubun, jgubun, "장운영정보", (decimal)2);
			dict["jnilvolume"] = new XAQueryFieldInfo("long", jnilvolume, jnilvolume.ToString("d12"), "전일동시간대거래량", (decimal)12);
			dict["futcode"] = new XAQueryFieldInfo("char", futcode, futcode, "단축코드", (decimal)8);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "chetime":
					this.chetime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "sign":
					this.sign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "change":
					this.change = fieldInfo.FieldValue.ParseFloat("change");
				break;

				case "drate":
					this.drate = fieldInfo.FieldValue.ParseFloat("drate");
				break;

				case "price":
					this.price = fieldInfo.FieldValue.ParseFloat("price");
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

				case "cgubun":
					this.cgubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "cvolume":
					this.cvolume = fieldInfo.FieldValue.ParseLong("cvolume");
				break;

				case "volume":
					this.volume = fieldInfo.FieldValue.ParseLong("volume");
				break;

				case "value":
					this.value = fieldInfo.FieldValue.ParseLong("value");
				break;

				case "mdvolume":
					this.mdvolume = fieldInfo.FieldValue.ParseLong("mdvolume");
				break;

				case "mdchecnt":
					this.mdchecnt = fieldInfo.FieldValue.ParseLong("mdchecnt");
				break;

				case "msvolume":
					this.msvolume = fieldInfo.FieldValue.ParseLong("msvolume");
				break;

				case "mschecnt":
					this.mschecnt = fieldInfo.FieldValue.ParseLong("mschecnt");
				break;

				case "cpower":
					this.cpower = fieldInfo.FieldValue.ParseFloat("cpower");
				break;

				case "offerho1":
					this.offerho1 = fieldInfo.FieldValue.ParseFloat("offerho1");
				break;

				case "bidho1":
					this.bidho1 = fieldInfo.FieldValue.ParseFloat("bidho1");
				break;

				case "openyak":
					this.openyak = fieldInfo.FieldValue.ParseLong("openyak");
				break;

				case "k200jisu":
					this.k200jisu = fieldInfo.FieldValue.ParseFloat("k200jisu");
				break;

				case "theoryprice":
					this.theoryprice = fieldInfo.FieldValue.ParseFloat("theoryprice");
				break;

				case "kasis":
					this.kasis = fieldInfo.FieldValue.ParseFloat("kasis");
				break;

				case "sbasis":
					this.sbasis = fieldInfo.FieldValue.ParseFloat("sbasis");
				break;

				case "ibasis":
					this.ibasis = fieldInfo.FieldValue.ParseFloat("ibasis");
				break;

				case "openyakcha":
					this.openyakcha = fieldInfo.FieldValue.ParseLong("openyakcha");
				break;

				case "jgubun":
					this.jgubun = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "jnilvolume":
					this.jnilvolume = fieldInfo.FieldValue.ParseLong("jnilvolume");
				break;

				case "futcode":
					this.futcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XRFC0OutBlock FromQuery(XRFC0 query)
		{
			XRFC0OutBlock block = new XRFC0OutBlock();
			block.IsValidData = true;
			block.InvalidReason = "";
			try
			{
				block.chetime = query.GetFieldData(block.GetBlockName(), "chetime").TrimEnd('?'); // char 6
				block.sign = query.GetFieldData(block.GetBlockName(), "sign").FirstOrDefault(); // char 1
				block.change = query.GetFieldData(block.GetBlockName(), "change").ParseFloat("change"); // float 6.2
				block.drate = query.GetFieldData(block.GetBlockName(), "drate").ParseFloat("drate"); // float 6.2
				block.price = query.GetFieldData(block.GetBlockName(), "price").ParseFloat("price"); // float 6.2
				block.open = query.GetFieldData(block.GetBlockName(), "open").ParseFloat("open"); // float 6.2
				block.high = query.GetFieldData(block.GetBlockName(), "high").ParseFloat("high"); // float 6.2
				block.low = query.GetFieldData(block.GetBlockName(), "low").ParseFloat("low"); // float 6.2
				block.cgubun = query.GetFieldData(block.GetBlockName(), "cgubun").FirstOrDefault(); // char 1
				block.cvolume = query.GetFieldData(block.GetBlockName(), "cvolume").ParseLong("cvolume"); // long 6
				block.volume = query.GetFieldData(block.GetBlockName(), "volume").ParseLong("volume"); // long 12
				block.value = query.GetFieldData(block.GetBlockName(), "value").ParseLong("value"); // long 12
				block.mdvolume = query.GetFieldData(block.GetBlockName(), "mdvolume").ParseLong("mdvolume"); // long 12
				block.mdchecnt = query.GetFieldData(block.GetBlockName(), "mdchecnt").ParseLong("mdchecnt"); // long 8
				block.msvolume = query.GetFieldData(block.GetBlockName(), "msvolume").ParseLong("msvolume"); // long 12
				block.mschecnt = query.GetFieldData(block.GetBlockName(), "mschecnt").ParseLong("mschecnt"); // long 8
				block.cpower = query.GetFieldData(block.GetBlockName(), "cpower").ParseFloat("cpower"); // float 9.2
				block.offerho1 = query.GetFieldData(block.GetBlockName(), "offerho1").ParseFloat("offerho1"); // float 6.2
				block.bidho1 = query.GetFieldData(block.GetBlockName(), "bidho1").ParseFloat("bidho1"); // float 6.2
				block.openyak = query.GetFieldData(block.GetBlockName(), "openyak").ParseLong("openyak"); // long 8
				block.k200jisu = query.GetFieldData(block.GetBlockName(), "k200jisu").ParseFloat("k200jisu"); // float 6.2
				block.theoryprice = query.GetFieldData(block.GetBlockName(), "theoryprice").ParseFloat("theoryprice"); // float 6.2
				block.kasis = query.GetFieldData(block.GetBlockName(), "kasis").ParseFloat("kasis"); // float 6.2
				block.sbasis = query.GetFieldData(block.GetBlockName(), "sbasis").ParseFloat("sbasis"); // float 6.2
				block.ibasis = query.GetFieldData(block.GetBlockName(), "ibasis").ParseFloat("ibasis"); // float 6.2
				block.openyakcha = query.GetFieldData(block.GetBlockName(), "openyakcha").ParseLong("openyakcha"); // long 8
				block.jgubun = query.GetFieldData(block.GetBlockName(), "jgubun").TrimEnd('?'); // char 2
				block.jnilvolume = query.GetFieldData(block.GetBlockName(), "jnilvolume").ParseLong("jnilvolume"); // long 12
				block.futcode = query.GetFieldData(block.GetBlockName(), "futcode").TrimEnd('?'); // char 8

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (chetime?.Length > 6) return false; // char 6
			// sign char 1
			// change float 6.2
			// drate float 6.2
			// price float 6.2
			// open float 6.2
			// high float 6.2
			// low float 6.2
			// cgubun char 1
			if (cvolume.ToString().Length > 6) return false; // long 6
			if (volume.ToString().Length > 12) return false; // long 12
			if (value.ToString().Length > 12) return false; // long 12
			if (mdvolume.ToString().Length > 12) return false; // long 12
			if (mdchecnt.ToString().Length > 8) return false; // long 8
			if (msvolume.ToString().Length > 12) return false; // long 12
			if (mschecnt.ToString().Length > 8) return false; // long 8
			// cpower float 9.2
			// offerho1 float 6.2
			// bidho1 float 6.2
			if (openyak.ToString().Length > 8) return false; // long 8
			// k200jisu float 6.2
			// theoryprice float 6.2
			// kasis float 6.2
			// sbasis float 6.2
			// ibasis float 6.2
			if (openyakcha.ToString().Length > 8) return false; // long 8
			if (jgubun?.Length > 2) return false; // char 2
			if (jnilvolume.ToString().Length > 12) return false; // long 12
			if (futcode?.Length > 8) return false; // char 8

			return true;
		}
	}

	public partial class XRFC0 : XingReal
	{
		/// <summary>
		/// FC0
		/// </summary>
		public const string _typeName = "FC0";
		/// <summary>
		/// KOSPI200선물체결(C0)
		/// </summary>
		public const string _typeDesc = "KOSPI200선물체결(C0)";
		/// <summary>
		/// false
		/// </summary>
		public const bool _attr = false;
		/// <summary>
		/// 0
		/// </summary>
		public const int _key = 0;
		/// <summary>
		/// 0
		/// </summary>
		public const int _group = 0;

		/// <summary>
		/// FC0
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// KOSPI200선물체결(C0)
		/// </summary>
		public string TypeDesc => _typeDesc;
		/// <summary>
		/// false
		/// </summary>
		public bool Attr => _attr;
		/// <summary>
		/// 0
		/// </summary>
		public int Key => _key;
		/// <summary>
		/// 0
		/// </summary>
		public int Group => _group;

		public XRFC0() : base("FC0") { }


		public bool SetFields(XRFC0InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaReal.SetFieldData(block.GetBlockName(), "futcode", block.futcode); // char 8

			return true;
		}

		public XRFC0OutBlock GetBlock()
		{
			XRFC0OutBlock instance = XRFC0OutBlock.FromQuery(this);
			return instance;

		}


	}

}
