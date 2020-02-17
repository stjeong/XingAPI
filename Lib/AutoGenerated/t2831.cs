using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt2831InBlock : XingBlock
	{
		/// <summary>
		/// t2831InBlock
		/// </summary>
		public const string _blockName = "t2831InBlock";
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
		/// t2831InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t2831InBlock
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
		[XAQueryFieldAttribute("shcode", "단축코드", "char", "8")]
		public string shcode;

		public static class F
		{
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string shcode = "shcode";
		}

		public static string[] AllFields = new string[]
		{
			F.shcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)8);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (shcode?.Length > 8) return false; // char 8

			return true;
		}
	}

	public partial class XQt2831OutBlock : XingBlock
	{
		/// <summary>
		/// t2831OutBlock
		/// </summary>
		public const string _blockName = "t2831OutBlock";
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
		/// t2831OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t2831OutBlock
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
		/// 종목명
		/// </summary>
		[XAQueryFieldAttribute("hname", "종목명", "char", "20")]
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
		/// 전일종가
		/// </summary>
		[XAQueryFieldAttribute("jnilclose", "전일종가", "float", "6.2")]
		public float jnilclose;
		/// <summary>
		/// 매도호가1
		/// </summary>
		[XAQueryFieldAttribute("offerho1", "매도호가1", "float", "6.2")]
		public float offerho1;
		/// <summary>
		/// 매수호가1
		/// </summary>
		[XAQueryFieldAttribute("bidho1", "매수호가1", "float", "6.2")]
		public float bidho1;
		/// <summary>
		/// 매도호가수량1
		/// </summary>
		[XAQueryFieldAttribute("offerrem1", "매도호가수량1", "long", "8")]
		public long offerrem1;
		/// <summary>
		/// 매수호가수량1
		/// </summary>
		[XAQueryFieldAttribute("bidrem1", "매수호가수량1", "long", "8")]
		public long bidrem1;
		/// <summary>
		/// 매도호가건수1
		/// </summary>
		[XAQueryFieldAttribute("dcnt1", "매도호가건수1", "long", "8")]
		public long dcnt1;
		/// <summary>
		/// 매수호가건수1
		/// </summary>
		[XAQueryFieldAttribute("scnt1", "매수호가건수1", "long", "8")]
		public long scnt1;
		/// <summary>
		/// 매도호가2
		/// </summary>
		[XAQueryFieldAttribute("offerho2", "매도호가2", "float", "6.2")]
		public float offerho2;
		/// <summary>
		/// 매수호가2
		/// </summary>
		[XAQueryFieldAttribute("bidho2", "매수호가2", "float", "6.2")]
		public float bidho2;
		/// <summary>
		/// 매도호가수량2
		/// </summary>
		[XAQueryFieldAttribute("offerrem2", "매도호가수량2", "long", "8")]
		public long offerrem2;
		/// <summary>
		/// 매수호가수량2
		/// </summary>
		[XAQueryFieldAttribute("bidrem2", "매수호가수량2", "long", "8")]
		public long bidrem2;
		/// <summary>
		/// 매도호가건수2
		/// </summary>
		[XAQueryFieldAttribute("dcnt2", "매도호가건수2", "long", "8")]
		public long dcnt2;
		/// <summary>
		/// 매수호가건수2
		/// </summary>
		[XAQueryFieldAttribute("scnt2", "매수호가건수2", "long", "8")]
		public long scnt2;
		/// <summary>
		/// 매도호가3
		/// </summary>
		[XAQueryFieldAttribute("offerho3", "매도호가3", "float", "6.2")]
		public float offerho3;
		/// <summary>
		/// 매수호가3
		/// </summary>
		[XAQueryFieldAttribute("bidho3", "매수호가3", "float", "6.2")]
		public float bidho3;
		/// <summary>
		/// 매도호가수량3
		/// </summary>
		[XAQueryFieldAttribute("offerrem3", "매도호가수량3", "long", "8")]
		public long offerrem3;
		/// <summary>
		/// 매수호가수량3
		/// </summary>
		[XAQueryFieldAttribute("bidrem3", "매수호가수량3", "long", "8")]
		public long bidrem3;
		/// <summary>
		/// 매도호가건수3
		/// </summary>
		[XAQueryFieldAttribute("dcnt3", "매도호가건수3", "long", "8")]
		public long dcnt3;
		/// <summary>
		/// 매수호가건수3
		/// </summary>
		[XAQueryFieldAttribute("scnt3", "매수호가건수3", "long", "8")]
		public long scnt3;
		/// <summary>
		/// 매도호가4
		/// </summary>
		[XAQueryFieldAttribute("offerho4", "매도호가4", "float", "6.2")]
		public float offerho4;
		/// <summary>
		/// 매수호가4
		/// </summary>
		[XAQueryFieldAttribute("bidho4", "매수호가4", "float", "6.2")]
		public float bidho4;
		/// <summary>
		/// 매도호가수량4
		/// </summary>
		[XAQueryFieldAttribute("offerrem4", "매도호가수량4", "long", "8")]
		public long offerrem4;
		/// <summary>
		/// 매수호가수량4
		/// </summary>
		[XAQueryFieldAttribute("bidrem4", "매수호가수량4", "long", "8")]
		public long bidrem4;
		/// <summary>
		/// 매도호가건수4
		/// </summary>
		[XAQueryFieldAttribute("dcnt4", "매도호가건수4", "long", "8")]
		public long dcnt4;
		/// <summary>
		/// 매수호가건수4
		/// </summary>
		[XAQueryFieldAttribute("scnt4", "매수호가건수4", "long", "8")]
		public long scnt4;
		/// <summary>
		/// 매도호가5
		/// </summary>
		[XAQueryFieldAttribute("offerho5", "매도호가5", "float", "6.2")]
		public float offerho5;
		/// <summary>
		/// 매수호가5
		/// </summary>
		[XAQueryFieldAttribute("bidho5", "매수호가5", "float", "6.2")]
		public float bidho5;
		/// <summary>
		/// 매도호가수량5
		/// </summary>
		[XAQueryFieldAttribute("offerrem5", "매도호가수량5", "long", "8")]
		public long offerrem5;
		/// <summary>
		/// 매수호가수량5
		/// </summary>
		[XAQueryFieldAttribute("bidrem5", "매수호가수량5", "long", "8")]
		public long bidrem5;
		/// <summary>
		/// 매도호가건수5
		/// </summary>
		[XAQueryFieldAttribute("dcnt5", "매도호가건수5", "long", "8")]
		public long dcnt5;
		/// <summary>
		/// 매수호가건수5
		/// </summary>
		[XAQueryFieldAttribute("scnt5", "매수호가건수5", "long", "8")]
		public long scnt5;
		/// <summary>
		/// 매도호가총수량
		/// </summary>
		[XAQueryFieldAttribute("dvol", "매도호가총수량", "long", "8")]
		public long dvol;
		/// <summary>
		/// 매수호가총수량
		/// </summary>
		[XAQueryFieldAttribute("svol", "매수호가총수량", "long", "8")]
		public long svol;
		/// <summary>
		/// 총매도호가건수
		/// </summary>
		[XAQueryFieldAttribute("toffernum", "총매도호가건수", "long", "8")]
		public long toffernum;
		/// <summary>
		/// 총매수호가건수
		/// </summary>
		[XAQueryFieldAttribute("tbidnum", "총매수호가건수", "long", "8")]
		public long tbidnum;
		/// <summary>
		/// 수신시간
		/// </summary>
		[XAQueryFieldAttribute("time", "수신시간", "char", "6")]
		public string time;
		/// <summary>
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("shcode", "단축코드", "char", "8")]
		public string shcode;

		public static class F
		{
			/// <summary>
			/// 종목명
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
			/// 거래량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// 전일종가
			/// </summary>
			public const string jnilclose = "jnilclose";
			/// <summary>
			/// 매도호가1
			/// </summary>
			public const string offerho1 = "offerho1";
			/// <summary>
			/// 매수호가1
			/// </summary>
			public const string bidho1 = "bidho1";
			/// <summary>
			/// 매도호가수량1
			/// </summary>
			public const string offerrem1 = "offerrem1";
			/// <summary>
			/// 매수호가수량1
			/// </summary>
			public const string bidrem1 = "bidrem1";
			/// <summary>
			/// 매도호가건수1
			/// </summary>
			public const string dcnt1 = "dcnt1";
			/// <summary>
			/// 매수호가건수1
			/// </summary>
			public const string scnt1 = "scnt1";
			/// <summary>
			/// 매도호가2
			/// </summary>
			public const string offerho2 = "offerho2";
			/// <summary>
			/// 매수호가2
			/// </summary>
			public const string bidho2 = "bidho2";
			/// <summary>
			/// 매도호가수량2
			/// </summary>
			public const string offerrem2 = "offerrem2";
			/// <summary>
			/// 매수호가수량2
			/// </summary>
			public const string bidrem2 = "bidrem2";
			/// <summary>
			/// 매도호가건수2
			/// </summary>
			public const string dcnt2 = "dcnt2";
			/// <summary>
			/// 매수호가건수2
			/// </summary>
			public const string scnt2 = "scnt2";
			/// <summary>
			/// 매도호가3
			/// </summary>
			public const string offerho3 = "offerho3";
			/// <summary>
			/// 매수호가3
			/// </summary>
			public const string bidho3 = "bidho3";
			/// <summary>
			/// 매도호가수량3
			/// </summary>
			public const string offerrem3 = "offerrem3";
			/// <summary>
			/// 매수호가수량3
			/// </summary>
			public const string bidrem3 = "bidrem3";
			/// <summary>
			/// 매도호가건수3
			/// </summary>
			public const string dcnt3 = "dcnt3";
			/// <summary>
			/// 매수호가건수3
			/// </summary>
			public const string scnt3 = "scnt3";
			/// <summary>
			/// 매도호가4
			/// </summary>
			public const string offerho4 = "offerho4";
			/// <summary>
			/// 매수호가4
			/// </summary>
			public const string bidho4 = "bidho4";
			/// <summary>
			/// 매도호가수량4
			/// </summary>
			public const string offerrem4 = "offerrem4";
			/// <summary>
			/// 매수호가수량4
			/// </summary>
			public const string bidrem4 = "bidrem4";
			/// <summary>
			/// 매도호가건수4
			/// </summary>
			public const string dcnt4 = "dcnt4";
			/// <summary>
			/// 매수호가건수4
			/// </summary>
			public const string scnt4 = "scnt4";
			/// <summary>
			/// 매도호가5
			/// </summary>
			public const string offerho5 = "offerho5";
			/// <summary>
			/// 매수호가5
			/// </summary>
			public const string bidho5 = "bidho5";
			/// <summary>
			/// 매도호가수량5
			/// </summary>
			public const string offerrem5 = "offerrem5";
			/// <summary>
			/// 매수호가수량5
			/// </summary>
			public const string bidrem5 = "bidrem5";
			/// <summary>
			/// 매도호가건수5
			/// </summary>
			public const string dcnt5 = "dcnt5";
			/// <summary>
			/// 매수호가건수5
			/// </summary>
			public const string scnt5 = "scnt5";
			/// <summary>
			/// 매도호가총수량
			/// </summary>
			public const string dvol = "dvol";
			/// <summary>
			/// 매수호가총수량
			/// </summary>
			public const string svol = "svol";
			/// <summary>
			/// 총매도호가건수
			/// </summary>
			public const string toffernum = "toffernum";
			/// <summary>
			/// 총매수호가건수
			/// </summary>
			public const string tbidnum = "tbidnum";
			/// <summary>
			/// 수신시간
			/// </summary>
			public const string time = "time";
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string shcode = "shcode";
		}

		public static string[] AllFields = new string[]
		{
			F.hname,
			F.price,
			F.sign,
			F.change,
			F.diff,
			F.volume,
			F.jnilclose,
			F.offerho1,
			F.bidho1,
			F.offerrem1,
			F.bidrem1,
			F.dcnt1,
			F.scnt1,
			F.offerho2,
			F.bidho2,
			F.offerrem2,
			F.bidrem2,
			F.dcnt2,
			F.scnt2,
			F.offerho3,
			F.bidho3,
			F.offerrem3,
			F.bidrem3,
			F.dcnt3,
			F.scnt3,
			F.offerho4,
			F.bidho4,
			F.offerrem4,
			F.bidrem4,
			F.dcnt4,
			F.scnt4,
			F.offerho5,
			F.bidho5,
			F.offerrem5,
			F.bidrem5,
			F.dcnt5,
			F.scnt5,
			F.dvol,
			F.svol,
			F.toffernum,
			F.tbidnum,
			F.time,
			F.shcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["hname"] = new XAQueryFieldInfo("char", hname, hname, "종목명", (decimal)20);
			dict["price"] = new XAQueryFieldInfo("float", price, price.ToString("000000.00"), "현재가", (decimal)6.2);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("float", change, change.ToString("000000.00"), "전일대비", (decimal)6.2);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "거래량", (decimal)12);
			dict["jnilclose"] = new XAQueryFieldInfo("float", jnilclose, jnilclose.ToString("000000.00"), "전일종가", (decimal)6.2);
			dict["offerho1"] = new XAQueryFieldInfo("float", offerho1, offerho1.ToString("000000.00"), "매도호가1", (decimal)6.2);
			dict["bidho1"] = new XAQueryFieldInfo("float", bidho1, bidho1.ToString("000000.00"), "매수호가1", (decimal)6.2);
			dict["offerrem1"] = new XAQueryFieldInfo("long", offerrem1, offerrem1.ToString("d8"), "매도호가수량1", (decimal)8);
			dict["bidrem1"] = new XAQueryFieldInfo("long", bidrem1, bidrem1.ToString("d8"), "매수호가수량1", (decimal)8);
			dict["dcnt1"] = new XAQueryFieldInfo("long", dcnt1, dcnt1.ToString("d8"), "매도호가건수1", (decimal)8);
			dict["scnt1"] = new XAQueryFieldInfo("long", scnt1, scnt1.ToString("d8"), "매수호가건수1", (decimal)8);
			dict["offerho2"] = new XAQueryFieldInfo("float", offerho2, offerho2.ToString("000000.00"), "매도호가2", (decimal)6.2);
			dict["bidho2"] = new XAQueryFieldInfo("float", bidho2, bidho2.ToString("000000.00"), "매수호가2", (decimal)6.2);
			dict["offerrem2"] = new XAQueryFieldInfo("long", offerrem2, offerrem2.ToString("d8"), "매도호가수량2", (decimal)8);
			dict["bidrem2"] = new XAQueryFieldInfo("long", bidrem2, bidrem2.ToString("d8"), "매수호가수량2", (decimal)8);
			dict["dcnt2"] = new XAQueryFieldInfo("long", dcnt2, dcnt2.ToString("d8"), "매도호가건수2", (decimal)8);
			dict["scnt2"] = new XAQueryFieldInfo("long", scnt2, scnt2.ToString("d8"), "매수호가건수2", (decimal)8);
			dict["offerho3"] = new XAQueryFieldInfo("float", offerho3, offerho3.ToString("000000.00"), "매도호가3", (decimal)6.2);
			dict["bidho3"] = new XAQueryFieldInfo("float", bidho3, bidho3.ToString("000000.00"), "매수호가3", (decimal)6.2);
			dict["offerrem3"] = new XAQueryFieldInfo("long", offerrem3, offerrem3.ToString("d8"), "매도호가수량3", (decimal)8);
			dict["bidrem3"] = new XAQueryFieldInfo("long", bidrem3, bidrem3.ToString("d8"), "매수호가수량3", (decimal)8);
			dict["dcnt3"] = new XAQueryFieldInfo("long", dcnt3, dcnt3.ToString("d8"), "매도호가건수3", (decimal)8);
			dict["scnt3"] = new XAQueryFieldInfo("long", scnt3, scnt3.ToString("d8"), "매수호가건수3", (decimal)8);
			dict["offerho4"] = new XAQueryFieldInfo("float", offerho4, offerho4.ToString("000000.00"), "매도호가4", (decimal)6.2);
			dict["bidho4"] = new XAQueryFieldInfo("float", bidho4, bidho4.ToString("000000.00"), "매수호가4", (decimal)6.2);
			dict["offerrem4"] = new XAQueryFieldInfo("long", offerrem4, offerrem4.ToString("d8"), "매도호가수량4", (decimal)8);
			dict["bidrem4"] = new XAQueryFieldInfo("long", bidrem4, bidrem4.ToString("d8"), "매수호가수량4", (decimal)8);
			dict["dcnt4"] = new XAQueryFieldInfo("long", dcnt4, dcnt4.ToString("d8"), "매도호가건수4", (decimal)8);
			dict["scnt4"] = new XAQueryFieldInfo("long", scnt4, scnt4.ToString("d8"), "매수호가건수4", (decimal)8);
			dict["offerho5"] = new XAQueryFieldInfo("float", offerho5, offerho5.ToString("000000.00"), "매도호가5", (decimal)6.2);
			dict["bidho5"] = new XAQueryFieldInfo("float", bidho5, bidho5.ToString("000000.00"), "매수호가5", (decimal)6.2);
			dict["offerrem5"] = new XAQueryFieldInfo("long", offerrem5, offerrem5.ToString("d8"), "매도호가수량5", (decimal)8);
			dict["bidrem5"] = new XAQueryFieldInfo("long", bidrem5, bidrem5.ToString("d8"), "매수호가수량5", (decimal)8);
			dict["dcnt5"] = new XAQueryFieldInfo("long", dcnt5, dcnt5.ToString("d8"), "매도호가건수5", (decimal)8);
			dict["scnt5"] = new XAQueryFieldInfo("long", scnt5, scnt5.ToString("d8"), "매수호가건수5", (decimal)8);
			dict["dvol"] = new XAQueryFieldInfo("long", dvol, dvol.ToString("d8"), "매도호가총수량", (decimal)8);
			dict["svol"] = new XAQueryFieldInfo("long", svol, svol.ToString("d8"), "매수호가총수량", (decimal)8);
			dict["toffernum"] = new XAQueryFieldInfo("long", toffernum, toffernum.ToString("d8"), "총매도호가건수", (decimal)8);
			dict["tbidnum"] = new XAQueryFieldInfo("long", tbidnum, tbidnum.ToString("d8"), "총매수호가건수", (decimal)8);
			dict["time"] = new XAQueryFieldInfo("char", time, time, "수신시간", (decimal)6);
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)8);

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

				case "diff":
					this.diff = fieldInfo.FieldValue.ParseFloat("diff");
				break;

				case "volume":
					this.volume = fieldInfo.FieldValue.ParseLong("volume");
				break;

				case "jnilclose":
					this.jnilclose = fieldInfo.FieldValue.ParseFloat("jnilclose");
				break;

				case "offerho1":
					this.offerho1 = fieldInfo.FieldValue.ParseFloat("offerho1");
				break;

				case "bidho1":
					this.bidho1 = fieldInfo.FieldValue.ParseFloat("bidho1");
				break;

				case "offerrem1":
					this.offerrem1 = fieldInfo.FieldValue.ParseLong("offerrem1");
				break;

				case "bidrem1":
					this.bidrem1 = fieldInfo.FieldValue.ParseLong("bidrem1");
				break;

				case "dcnt1":
					this.dcnt1 = fieldInfo.FieldValue.ParseLong("dcnt1");
				break;

				case "scnt1":
					this.scnt1 = fieldInfo.FieldValue.ParseLong("scnt1");
				break;

				case "offerho2":
					this.offerho2 = fieldInfo.FieldValue.ParseFloat("offerho2");
				break;

				case "bidho2":
					this.bidho2 = fieldInfo.FieldValue.ParseFloat("bidho2");
				break;

				case "offerrem2":
					this.offerrem2 = fieldInfo.FieldValue.ParseLong("offerrem2");
				break;

				case "bidrem2":
					this.bidrem2 = fieldInfo.FieldValue.ParseLong("bidrem2");
				break;

				case "dcnt2":
					this.dcnt2 = fieldInfo.FieldValue.ParseLong("dcnt2");
				break;

				case "scnt2":
					this.scnt2 = fieldInfo.FieldValue.ParseLong("scnt2");
				break;

				case "offerho3":
					this.offerho3 = fieldInfo.FieldValue.ParseFloat("offerho3");
				break;

				case "bidho3":
					this.bidho3 = fieldInfo.FieldValue.ParseFloat("bidho3");
				break;

				case "offerrem3":
					this.offerrem3 = fieldInfo.FieldValue.ParseLong("offerrem3");
				break;

				case "bidrem3":
					this.bidrem3 = fieldInfo.FieldValue.ParseLong("bidrem3");
				break;

				case "dcnt3":
					this.dcnt3 = fieldInfo.FieldValue.ParseLong("dcnt3");
				break;

				case "scnt3":
					this.scnt3 = fieldInfo.FieldValue.ParseLong("scnt3");
				break;

				case "offerho4":
					this.offerho4 = fieldInfo.FieldValue.ParseFloat("offerho4");
				break;

				case "bidho4":
					this.bidho4 = fieldInfo.FieldValue.ParseFloat("bidho4");
				break;

				case "offerrem4":
					this.offerrem4 = fieldInfo.FieldValue.ParseLong("offerrem4");
				break;

				case "bidrem4":
					this.bidrem4 = fieldInfo.FieldValue.ParseLong("bidrem4");
				break;

				case "dcnt4":
					this.dcnt4 = fieldInfo.FieldValue.ParseLong("dcnt4");
				break;

				case "scnt4":
					this.scnt4 = fieldInfo.FieldValue.ParseLong("scnt4");
				break;

				case "offerho5":
					this.offerho5 = fieldInfo.FieldValue.ParseFloat("offerho5");
				break;

				case "bidho5":
					this.bidho5 = fieldInfo.FieldValue.ParseFloat("bidho5");
				break;

				case "offerrem5":
					this.offerrem5 = fieldInfo.FieldValue.ParseLong("offerrem5");
				break;

				case "bidrem5":
					this.bidrem5 = fieldInfo.FieldValue.ParseLong("bidrem5");
				break;

				case "dcnt5":
					this.dcnt5 = fieldInfo.FieldValue.ParseLong("dcnt5");
				break;

				case "scnt5":
					this.scnt5 = fieldInfo.FieldValue.ParseLong("scnt5");
				break;

				case "dvol":
					this.dvol = fieldInfo.FieldValue.ParseLong("dvol");
				break;

				case "svol":
					this.svol = fieldInfo.FieldValue.ParseLong("svol");
				break;

				case "toffernum":
					this.toffernum = fieldInfo.FieldValue.ParseLong("toffernum");
				break;

				case "tbidnum":
					this.tbidnum = fieldInfo.FieldValue.ParseLong("tbidnum");
				break;

				case "time":
					this.time = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt2831OutBlock FromQuery(XQt2831 query)
		{
			XQt2831OutBlock block = new XQt2831OutBlock();
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
				block.diff = query.GetFieldData(block.GetBlockName(), "diff", 0).ParseFloat("diff"); // float 6.2
				block.volume = query.GetFieldData(block.GetBlockName(), "volume", 0).ParseLong("volume"); // long 12
				block.jnilclose = query.GetFieldData(block.GetBlockName(), "jnilclose", 0).ParseFloat("jnilclose"); // float 6.2
				block.offerho1 = query.GetFieldData(block.GetBlockName(), "offerho1", 0).ParseFloat("offerho1"); // float 6.2
				block.bidho1 = query.GetFieldData(block.GetBlockName(), "bidho1", 0).ParseFloat("bidho1"); // float 6.2
				block.offerrem1 = query.GetFieldData(block.GetBlockName(), "offerrem1", 0).ParseLong("offerrem1"); // long 8
				block.bidrem1 = query.GetFieldData(block.GetBlockName(), "bidrem1", 0).ParseLong("bidrem1"); // long 8
				block.dcnt1 = query.GetFieldData(block.GetBlockName(), "dcnt1", 0).ParseLong("dcnt1"); // long 8
				block.scnt1 = query.GetFieldData(block.GetBlockName(), "scnt1", 0).ParseLong("scnt1"); // long 8
				block.offerho2 = query.GetFieldData(block.GetBlockName(), "offerho2", 0).ParseFloat("offerho2"); // float 6.2
				block.bidho2 = query.GetFieldData(block.GetBlockName(), "bidho2", 0).ParseFloat("bidho2"); // float 6.2
				block.offerrem2 = query.GetFieldData(block.GetBlockName(), "offerrem2", 0).ParseLong("offerrem2"); // long 8
				block.bidrem2 = query.GetFieldData(block.GetBlockName(), "bidrem2", 0).ParseLong("bidrem2"); // long 8
				block.dcnt2 = query.GetFieldData(block.GetBlockName(), "dcnt2", 0).ParseLong("dcnt2"); // long 8
				block.scnt2 = query.GetFieldData(block.GetBlockName(), "scnt2", 0).ParseLong("scnt2"); // long 8
				block.offerho3 = query.GetFieldData(block.GetBlockName(), "offerho3", 0).ParseFloat("offerho3"); // float 6.2
				block.bidho3 = query.GetFieldData(block.GetBlockName(), "bidho3", 0).ParseFloat("bidho3"); // float 6.2
				block.offerrem3 = query.GetFieldData(block.GetBlockName(), "offerrem3", 0).ParseLong("offerrem3"); // long 8
				block.bidrem3 = query.GetFieldData(block.GetBlockName(), "bidrem3", 0).ParseLong("bidrem3"); // long 8
				block.dcnt3 = query.GetFieldData(block.GetBlockName(), "dcnt3", 0).ParseLong("dcnt3"); // long 8
				block.scnt3 = query.GetFieldData(block.GetBlockName(), "scnt3", 0).ParseLong("scnt3"); // long 8
				block.offerho4 = query.GetFieldData(block.GetBlockName(), "offerho4", 0).ParseFloat("offerho4"); // float 6.2
				block.bidho4 = query.GetFieldData(block.GetBlockName(), "bidho4", 0).ParseFloat("bidho4"); // float 6.2
				block.offerrem4 = query.GetFieldData(block.GetBlockName(), "offerrem4", 0).ParseLong("offerrem4"); // long 8
				block.bidrem4 = query.GetFieldData(block.GetBlockName(), "bidrem4", 0).ParseLong("bidrem4"); // long 8
				block.dcnt4 = query.GetFieldData(block.GetBlockName(), "dcnt4", 0).ParseLong("dcnt4"); // long 8
				block.scnt4 = query.GetFieldData(block.GetBlockName(), "scnt4", 0).ParseLong("scnt4"); // long 8
				block.offerho5 = query.GetFieldData(block.GetBlockName(), "offerho5", 0).ParseFloat("offerho5"); // float 6.2
				block.bidho5 = query.GetFieldData(block.GetBlockName(), "bidho5", 0).ParseFloat("bidho5"); // float 6.2
				block.offerrem5 = query.GetFieldData(block.GetBlockName(), "offerrem5", 0).ParseLong("offerrem5"); // long 8
				block.bidrem5 = query.GetFieldData(block.GetBlockName(), "bidrem5", 0).ParseLong("bidrem5"); // long 8
				block.dcnt5 = query.GetFieldData(block.GetBlockName(), "dcnt5", 0).ParseLong("dcnt5"); // long 8
				block.scnt5 = query.GetFieldData(block.GetBlockName(), "scnt5", 0).ParseLong("scnt5"); // long 8
				block.dvol = query.GetFieldData(block.GetBlockName(), "dvol", 0).ParseLong("dvol"); // long 8
				block.svol = query.GetFieldData(block.GetBlockName(), "svol", 0).ParseLong("svol"); // long 8
				block.toffernum = query.GetFieldData(block.GetBlockName(), "toffernum", 0).ParseLong("toffernum"); // long 8
				block.tbidnum = query.GetFieldData(block.GetBlockName(), "tbidnum", 0).ParseLong("tbidnum"); // long 8
				block.time = query.GetFieldData(block.GetBlockName(), "time", 0).TrimEnd('?'); // char 6
				block.shcode = query.GetFieldData(block.GetBlockName(), "shcode", 0).TrimEnd('?'); // char 8

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
			// diff float 6.2
			if (volume.ToString().Length > 12) return false; // long 12
			// jnilclose float 6.2
			// offerho1 float 6.2
			// bidho1 float 6.2
			if (offerrem1.ToString().Length > 8) return false; // long 8
			if (bidrem1.ToString().Length > 8) return false; // long 8
			if (dcnt1.ToString().Length > 8) return false; // long 8
			if (scnt1.ToString().Length > 8) return false; // long 8
			// offerho2 float 6.2
			// bidho2 float 6.2
			if (offerrem2.ToString().Length > 8) return false; // long 8
			if (bidrem2.ToString().Length > 8) return false; // long 8
			if (dcnt2.ToString().Length > 8) return false; // long 8
			if (scnt2.ToString().Length > 8) return false; // long 8
			// offerho3 float 6.2
			// bidho3 float 6.2
			if (offerrem3.ToString().Length > 8) return false; // long 8
			if (bidrem3.ToString().Length > 8) return false; // long 8
			if (dcnt3.ToString().Length > 8) return false; // long 8
			if (scnt3.ToString().Length > 8) return false; // long 8
			// offerho4 float 6.2
			// bidho4 float 6.2
			if (offerrem4.ToString().Length > 8) return false; // long 8
			if (bidrem4.ToString().Length > 8) return false; // long 8
			if (dcnt4.ToString().Length > 8) return false; // long 8
			if (scnt4.ToString().Length > 8) return false; // long 8
			// offerho5 float 6.2
			// bidho5 float 6.2
			if (offerrem5.ToString().Length > 8) return false; // long 8
			if (bidrem5.ToString().Length > 8) return false; // long 8
			if (dcnt5.ToString().Length > 8) return false; // long 8
			if (scnt5.ToString().Length > 8) return false; // long 8
			if (dvol.ToString().Length > 8) return false; // long 8
			if (svol.ToString().Length > 8) return false; // long 8
			if (toffernum.ToString().Length > 8) return false; // long 8
			if (tbidnum.ToString().Length > 8) return false; // long 8
			if (time?.Length > 6) return false; // char 6
			if (shcode?.Length > 8) return false; // char 8

			return true;
		}
	}

	/// <summary>
	/// EUREXKOSPI200옵션선물호가조회(t2831)
	/// </summary>
	public partial class XQt2831 : XingQuery
	{
		/// <summary>
		/// t2831
		/// </summary>
		public const string _typeName = "t2831";
		/// <summary>
		/// EUREXKOSPI200옵션선물호가조회(t2831)
		/// </summary>
		public const string _typeDesc = "EUREXKOSPI200옵션선물호가조회(t2831)";
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
		/// t2831
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// EUREXKOSPI200옵션선물호가조회(t2831)
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
		/// EUREXKOSPI200옵션선물호가조회(t2831)
		/// </summary>
		public XQt2831() : base("t2831") { }


		public static XQt2831OutBlock Get(string shcode = default)
		{
			using (XQt2831 instance = new XQt2831())
			{
				instance.SetFieldData(XQt2831InBlock.BlockName, XQt2831InBlock.F.shcode, 0, shcode); // char 8

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

		public static XQt2831OutBlock ReadFromDB(/* string shcode = default */)
		{
			using (XQt2831 instance = new XQt2831())
			{

				QueryOption qo = new QueryOption("XQt2831OutBlock");
				// if (shcode != default) qo.Add("shcode", shcode);


				var outBlock = instance.Select<XQt2831OutBlock>(qo);
				return outBlock;
			}
		}

		public bool SetBlock(XQt2831InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "shcode", 0, block.shcode); // char 8

			return true;
		}

		public XQt2831OutBlock GetBlock()
		{
			XQt2831OutBlock instance = XQt2831OutBlock.FromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt2831OutBlock),

		};

	}

}
