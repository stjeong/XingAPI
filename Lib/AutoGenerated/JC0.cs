using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XRJC0InBlock : XingBlock
	{
		/// <summary>
		/// InBlock
		/// </summary>
		static readonly string _blockName = "InBlock";
		/// <summary>
		/// 입력
		/// </summary>
		static readonly string _blockDesc = "입력";
		/// <summary>
		/// input
		/// </summary>
		static readonly string _blockType = "input";
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _hasOccurs = false;
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
			if (futcode.Length > 8) return false; // char 8

			return true;
		}
	}

	public partial class XRJC0OutBlock : XingBlock
	{
		/// <summary>
		/// OutBlock
		/// </summary>
		static readonly string _blockName = "OutBlock";
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
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("단축코드")]
		public string futcode;
		/// <summary>
		/// 체결시간
		/// </summary>
		[XAQueryFieldAttribute("체결시간")]
		public string chetime;
		/// <summary>
		/// 대비기호
		/// </summary>
		[XAQueryFieldAttribute("대비기호")]
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
		public double drate;
		/// <summary>
		/// 현재가
		/// </summary>
		[XAQueryFieldAttribute("현재가")]
		public long price;
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
		public double cpower;
		/// <summary>
		/// 매도호가1
		/// </summary>
		[XAQueryFieldAttribute("매도호가1")]
		public long offerho1;
		/// <summary>
		/// 매수호가1
		/// </summary>
		[XAQueryFieldAttribute("매수호가1")]
		public long bidho1;
		/// <summary>
		/// 미결제약정수량
		/// </summary>
		[XAQueryFieldAttribute("미결제약정수량")]
		public long openyak;
		/// <summary>
		/// KOSPI200지수
		/// </summary>
		[XAQueryFieldAttribute("KOSPI200지수")]
		public double k200jisu;
		/// <summary>
		/// 이론가
		/// </summary>
		[XAQueryFieldAttribute("이론가")]
		public long theoryprice;
		/// <summary>
		/// 괴리율
		/// </summary>
		[XAQueryFieldAttribute("괴리율")]
		public double kasis;
		/// <summary>
		/// 시장BASIS
		/// </summary>
		[XAQueryFieldAttribute("시장BASIS")]
		public long sbasis;
		/// <summary>
		/// 이론BASIS
		/// </summary>
		[XAQueryFieldAttribute("이론BASIS")]
		public long ibasis;
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
		/// 기초자산현재가
		/// </summary>
		[XAQueryFieldAttribute("기초자산현재가")]
		public long basprice;

		public static class F
		{
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string futcode = "futcode";
			/// <summary>
			/// 체결시간
			/// </summary>
			public const string chetime = "chetime";
			/// <summary>
			/// 대비기호
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
			/// 기초자산현재가
			/// </summary>
			public const string basprice = "basprice";
		}

		public static string[] AllFields = new string[]
		{
			F.futcode,
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
			F.basprice,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["futcode"] = new XAQueryFieldInfo("char", futcode, futcode, "단축코드", (decimal)8);
			dict["chetime"] = new XAQueryFieldInfo("char", chetime, chetime, "체결시간", (decimal)6);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "대비기호", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("long", change, change.ToString("d10"), "전일대비", (decimal)10);
			dict["drate"] = new XAQueryFieldInfo("double", drate, drate.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["price"] = new XAQueryFieldInfo("long", price, price.ToString("d10"), "현재가", (decimal)10);
			dict["open"] = new XAQueryFieldInfo("long", open, open.ToString("d10"), "시가", (decimal)10);
			dict["high"] = new XAQueryFieldInfo("long", high, high.ToString("d10"), "고가", (decimal)10);
			dict["low"] = new XAQueryFieldInfo("long", low, low.ToString("d10"), "저가", (decimal)10);
			dict["cgubun"] = new XAQueryFieldInfo("char", cgubun, cgubun.ToString(), "체결구분", (decimal)1);
			dict["cvolume"] = new XAQueryFieldInfo("long", cvolume, cvolume.ToString("d6"), "체결량", (decimal)6);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "누적거래량", (decimal)12);
			dict["value"] = new XAQueryFieldInfo("long", value, value.ToString("d15"), "누적거래대금", (decimal)15);
			dict["mdvolume"] = new XAQueryFieldInfo("long", mdvolume, mdvolume.ToString("d12"), "매도누적체결량", (decimal)12);
			dict["mdchecnt"] = new XAQueryFieldInfo("long", mdchecnt, mdchecnt.ToString("d8"), "매도누적체결건수", (decimal)8);
			dict["msvolume"] = new XAQueryFieldInfo("long", msvolume, msvolume.ToString("d12"), "매수누적체결량", (decimal)12);
			dict["mschecnt"] = new XAQueryFieldInfo("long", mschecnt, mschecnt.ToString("d8"), "매수누적체결건수", (decimal)8);
			dict["cpower"] = new XAQueryFieldInfo("double", cpower, cpower.ToString("000000000.00"), "체결강도", (decimal)9.2);
			dict["offerho1"] = new XAQueryFieldInfo("long", offerho1, offerho1.ToString("d10"), "매도호가1", (decimal)10);
			dict["bidho1"] = new XAQueryFieldInfo("long", bidho1, bidho1.ToString("d10"), "매수호가1", (decimal)10);
			dict["openyak"] = new XAQueryFieldInfo("long", openyak, openyak.ToString("d8"), "미결제약정수량", (decimal)8);
			dict["k200jisu"] = new XAQueryFieldInfo("double", k200jisu, k200jisu.ToString("000000.00"), "KOSPI200지수", (decimal)6.2);
			dict["theoryprice"] = new XAQueryFieldInfo("long", theoryprice, theoryprice.ToString("d8"), "이론가", (decimal)8);
			dict["kasis"] = new XAQueryFieldInfo("double", kasis, kasis.ToString("000000.000"), "괴리율", (decimal)6.3);
			dict["sbasis"] = new XAQueryFieldInfo("long", sbasis, sbasis.ToString("d6"), "시장BASIS", (decimal)6);
			dict["ibasis"] = new XAQueryFieldInfo("long", ibasis, ibasis.ToString("d6"), "이론BASIS", (decimal)6);
			dict["openyakcha"] = new XAQueryFieldInfo("long", openyakcha, openyakcha.ToString("d8"), "미결제약정증감", (decimal)8);
			dict["jgubun"] = new XAQueryFieldInfo("char", jgubun, jgubun, "장운영정보", (decimal)2);
			dict["jnilvolume"] = new XAQueryFieldInfo("long", jnilvolume, jnilvolume.ToString("d12"), "전일동시간대거래량", (decimal)12);
			dict["basprice"] = new XAQueryFieldInfo("long", basprice, basprice.ToString("d8"), "기초자산현재가", (decimal)8);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "futcode":
					this.futcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "chetime":
					this.chetime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "sign":
					this.sign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "change":
					this.change = fieldInfo.FieldValue.ParseLong("change");
				break;

				case "drate":
					this.drate = fieldInfo.FieldValue.ParseDouble("drate");
				break;

				case "price":
					this.price = fieldInfo.FieldValue.ParseLong("price");
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
					this.cpower = fieldInfo.FieldValue.ParseDouble("cpower");
				break;

				case "offerho1":
					this.offerho1 = fieldInfo.FieldValue.ParseLong("offerho1");
				break;

				case "bidho1":
					this.bidho1 = fieldInfo.FieldValue.ParseLong("bidho1");
				break;

				case "openyak":
					this.openyak = fieldInfo.FieldValue.ParseLong("openyak");
				break;

				case "k200jisu":
					this.k200jisu = fieldInfo.FieldValue.ParseDouble("k200jisu");
				break;

				case "theoryprice":
					this.theoryprice = fieldInfo.FieldValue.ParseLong("theoryprice");
				break;

				case "kasis":
					this.kasis = fieldInfo.FieldValue.ParseDouble("kasis");
				break;

				case "sbasis":
					this.sbasis = fieldInfo.FieldValue.ParseLong("sbasis");
				break;

				case "ibasis":
					this.ibasis = fieldInfo.FieldValue.ParseLong("ibasis");
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

				case "basprice":
					this.basprice = fieldInfo.FieldValue.ParseLong("basprice");
				break;


			}
		}

		public static XRJC0OutBlock FromQuery(XRJC0 query)
		{
			XRJC0OutBlock block = new XRJC0OutBlock();
			block.IsValidData = true;
			block.InvalidReason = "";
			try
			{
				block.futcode = query.GetFieldData(block.GetBlockName(), "futcode").TrimEnd('?'); // char 8
				block.chetime = query.GetFieldData(block.GetBlockName(), "chetime").TrimEnd('?'); // char 6
				block.sign = query.GetFieldData(block.GetBlockName(), "sign").FirstOrDefault(); // char 1
				block.change = query.GetFieldData(block.GetBlockName(), "change").ParseLong("change"); // long 10
				block.drate = query.GetFieldData(block.GetBlockName(), "drate").ParseDouble("drate"); // double 6.2
				block.price = query.GetFieldData(block.GetBlockName(), "price").ParseLong("price"); // long 10
				block.open = query.GetFieldData(block.GetBlockName(), "open").ParseLong("open"); // long 10
				block.high = query.GetFieldData(block.GetBlockName(), "high").ParseLong("high"); // long 10
				block.low = query.GetFieldData(block.GetBlockName(), "low").ParseLong("low"); // long 10
				block.cgubun = query.GetFieldData(block.GetBlockName(), "cgubun").FirstOrDefault(); // char 1
				block.cvolume = query.GetFieldData(block.GetBlockName(), "cvolume").ParseLong("cvolume"); // long 6
				block.volume = query.GetFieldData(block.GetBlockName(), "volume").ParseLong("volume"); // long 12
				block.value = query.GetFieldData(block.GetBlockName(), "value").ParseLong("value"); // long 15
				block.mdvolume = query.GetFieldData(block.GetBlockName(), "mdvolume").ParseLong("mdvolume"); // long 12
				block.mdchecnt = query.GetFieldData(block.GetBlockName(), "mdchecnt").ParseLong("mdchecnt"); // long 8
				block.msvolume = query.GetFieldData(block.GetBlockName(), "msvolume").ParseLong("msvolume"); // long 12
				block.mschecnt = query.GetFieldData(block.GetBlockName(), "mschecnt").ParseLong("mschecnt"); // long 8
				block.cpower = query.GetFieldData(block.GetBlockName(), "cpower").ParseDouble("cpower"); // double 9.2
				block.offerho1 = query.GetFieldData(block.GetBlockName(), "offerho1").ParseLong("offerho1"); // long 10
				block.bidho1 = query.GetFieldData(block.GetBlockName(), "bidho1").ParseLong("bidho1"); // long 10
				block.openyak = query.GetFieldData(block.GetBlockName(), "openyak").ParseLong("openyak"); // long 8
				block.k200jisu = query.GetFieldData(block.GetBlockName(), "k200jisu").ParseDouble("k200jisu"); // double 6.2
				block.theoryprice = query.GetFieldData(block.GetBlockName(), "theoryprice").ParseLong("theoryprice"); // long 8
				block.kasis = query.GetFieldData(block.GetBlockName(), "kasis").ParseDouble("kasis"); // double 6.3
				block.sbasis = query.GetFieldData(block.GetBlockName(), "sbasis").ParseLong("sbasis"); // long 6
				block.ibasis = query.GetFieldData(block.GetBlockName(), "ibasis").ParseLong("ibasis"); // long 6
				block.openyakcha = query.GetFieldData(block.GetBlockName(), "openyakcha").ParseLong("openyakcha"); // long 8
				block.jgubun = query.GetFieldData(block.GetBlockName(), "jgubun").TrimEnd('?'); // char 2
				block.jnilvolume = query.GetFieldData(block.GetBlockName(), "jnilvolume").ParseLong("jnilvolume"); // long 12
				block.basprice = query.GetFieldData(block.GetBlockName(), "basprice").ParseLong("basprice"); // long 8

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (futcode.Length > 8) return false; // char 8
			if (chetime.Length > 6) return false; // char 6
			// sign char 1
			if (change.ToString().Length > 10) return false; // long 10
			// drate double 6.2
			if (price.ToString().Length > 10) return false; // long 10
			if (open.ToString().Length > 10) return false; // long 10
			if (high.ToString().Length > 10) return false; // long 10
			if (low.ToString().Length > 10) return false; // long 10
			// cgubun char 1
			if (cvolume.ToString().Length > 6) return false; // long 6
			if (volume.ToString().Length > 12) return false; // long 12
			if (value.ToString().Length > 15) return false; // long 15
			if (mdvolume.ToString().Length > 12) return false; // long 12
			if (mdchecnt.ToString().Length > 8) return false; // long 8
			if (msvolume.ToString().Length > 12) return false; // long 12
			if (mschecnt.ToString().Length > 8) return false; // long 8
			// cpower double 9.2
			if (offerho1.ToString().Length > 10) return false; // long 10
			if (bidho1.ToString().Length > 10) return false; // long 10
			if (openyak.ToString().Length > 8) return false; // long 8
			// k200jisu double 6.2
			if (theoryprice.ToString().Length > 8) return false; // long 8
			// kasis double 6.3
			if (sbasis.ToString().Length > 6) return false; // long 6
			if (ibasis.ToString().Length > 6) return false; // long 6
			if (openyakcha.ToString().Length > 8) return false; // long 8
			if (jgubun.Length > 2) return false; // char 2
			if (jnilvolume.ToString().Length > 12) return false; // long 12
			if (basprice.ToString().Length > 8) return false; // long 8

			return true;
		}
	}

	public partial class XRJC0 : XingReal
	{
		/// <summary>
		/// JC0
		/// </summary>
		static readonly string _typeName = "JC0";
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _attr = false;
		/// <summary>
		/// 0
		/// </summary>
		static readonly int _key = 0;
		/// <summary>
		/// 0
		/// </summary>
		static readonly int _group = 0;

		/// <summary>
		/// JC0
		/// </summary>
		public string TypeName => _typeName;
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

		public XRJC0() : base("JC0") { }


		public bool SetFields(XRJC0InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaReal.SetFieldData(block.GetBlockName(), "futcode", block.futcode); // char 8

			return true;
		}

		public XRJC0OutBlock GetBlock()
		{
			XRJC0OutBlock instance = XRJC0OutBlock.FromQuery(this);
			return instance;

		}


	}

}
