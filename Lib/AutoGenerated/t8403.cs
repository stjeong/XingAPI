using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt8403InBlock : XingBlock
	{
		/// <summary>
		/// t8403InBlock
		/// </summary>
		public const string _blockName = "t8403InBlock";
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
		/// t8403InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t8403InBlock
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

	public partial class XQt8403OutBlock : XingBlock
	{
		/// <summary>
		/// t8403OutBlock
		/// </summary>
		public const string _blockName = "t8403OutBlock";
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
		/// t8403OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t8403OutBlock
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
		[XAQueryFieldAttribute("price", "현재가", "long", "8")]
		public long price;
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
		/// 거래량
		/// </summary>
		[XAQueryFieldAttribute("volume", "거래량", "long", "12")]
		public long volume;
		/// <summary>
		/// 거래량전일동시간비율
		/// </summary>
		[XAQueryFieldAttribute("stimeqrt", "거래량전일동시간비율", "float", "6.2")]
		public float stimeqrt;
		/// <summary>
		/// 전일종가
		/// </summary>
		[XAQueryFieldAttribute("jnilclose", "전일종가", "long", "8")]
		public long jnilclose;
		/// <summary>
		/// 매도호가1
		/// </summary>
		[XAQueryFieldAttribute("offerho1", "매도호가1", "long", "8")]
		public long offerho1;
		/// <summary>
		/// 매수호가1
		/// </summary>
		[XAQueryFieldAttribute("bidho1", "매수호가1", "long", "8")]
		public long bidho1;
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
		[XAQueryFieldAttribute("offerho2", "매도호가2", "long", "8")]
		public long offerho2;
		/// <summary>
		/// 매수호가2
		/// </summary>
		[XAQueryFieldAttribute("bidho2", "매수호가2", "long", "8")]
		public long bidho2;
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
		[XAQueryFieldAttribute("offerho3", "매도호가3", "long", "8")]
		public long offerho3;
		/// <summary>
		/// 매수호가3
		/// </summary>
		[XAQueryFieldAttribute("bidho3", "매수호가3", "long", "8")]
		public long bidho3;
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
		[XAQueryFieldAttribute("offerho4", "매도호가4", "long", "8")]
		public long offerho4;
		/// <summary>
		/// 매수호가4
		/// </summary>
		[XAQueryFieldAttribute("bidho4", "매수호가4", "long", "8")]
		public long bidho4;
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
		[XAQueryFieldAttribute("offerho5", "매도호가5", "long", "8")]
		public long offerho5;
		/// <summary>
		/// 매수호가5
		/// </summary>
		[XAQueryFieldAttribute("bidho5", "매수호가5", "long", "8")]
		public long bidho5;
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
		/// 매도호가6
		/// </summary>
		[XAQueryFieldAttribute("offerho6", "매도호가6", "long", "8")]
		public long offerho6;
		/// <summary>
		/// 매수호가6
		/// </summary>
		[XAQueryFieldAttribute("bidho6", "매수호가6", "long", "8")]
		public long bidho6;
		/// <summary>
		/// 매도호가수량6
		/// </summary>
		[XAQueryFieldAttribute("offerrem6", "매도호가수량6", "long", "8")]
		public long offerrem6;
		/// <summary>
		/// 매수호가수량6
		/// </summary>
		[XAQueryFieldAttribute("bidrem6", "매수호가수량6", "long", "8")]
		public long bidrem6;
		/// <summary>
		/// 매도호가건수6
		/// </summary>
		[XAQueryFieldAttribute("dcnt6", "매도호가건수6", "long", "8")]
		public long dcnt6;
		/// <summary>
		/// 매수호가건수6
		/// </summary>
		[XAQueryFieldAttribute("scnt6", "매수호가건수6", "long", "8")]
		public long scnt6;
		/// <summary>
		/// 매도호가7
		/// </summary>
		[XAQueryFieldAttribute("offerho7", "매도호가7", "long", "8")]
		public long offerho7;
		/// <summary>
		/// 매수호가7
		/// </summary>
		[XAQueryFieldAttribute("bidho7", "매수호가7", "long", "8")]
		public long bidho7;
		/// <summary>
		/// 매도호가수량7
		/// </summary>
		[XAQueryFieldAttribute("offerrem7", "매도호가수량7", "long", "8")]
		public long offerrem7;
		/// <summary>
		/// 매수호가수량7
		/// </summary>
		[XAQueryFieldAttribute("bidrem7", "매수호가수량7", "long", "8")]
		public long bidrem7;
		/// <summary>
		/// 매도호가건수7
		/// </summary>
		[XAQueryFieldAttribute("dcnt7", "매도호가건수7", "long", "8")]
		public long dcnt7;
		/// <summary>
		/// 매수호가건수7
		/// </summary>
		[XAQueryFieldAttribute("scnt7", "매수호가건수7", "long", "8")]
		public long scnt7;
		/// <summary>
		/// 매도호가8
		/// </summary>
		[XAQueryFieldAttribute("offerho8", "매도호가8", "long", "8")]
		public long offerho8;
		/// <summary>
		/// 매수호가8
		/// </summary>
		[XAQueryFieldAttribute("bidho8", "매수호가8", "long", "8")]
		public long bidho8;
		/// <summary>
		/// 매도호가수량8
		/// </summary>
		[XAQueryFieldAttribute("offerrem8", "매도호가수량8", "long", "8")]
		public long offerrem8;
		/// <summary>
		/// 매수호가수량8
		/// </summary>
		[XAQueryFieldAttribute("bidrem8", "매수호가수량8", "long", "8")]
		public long bidrem8;
		/// <summary>
		/// 매도호가건수8
		/// </summary>
		[XAQueryFieldAttribute("dcnt8", "매도호가건수8", "long", "8")]
		public long dcnt8;
		/// <summary>
		/// 매수호가건수8
		/// </summary>
		[XAQueryFieldAttribute("scnt8", "매수호가건수8", "long", "8")]
		public long scnt8;
		/// <summary>
		/// 매도호가9
		/// </summary>
		[XAQueryFieldAttribute("offerho9", "매도호가9", "long", "8")]
		public long offerho9;
		/// <summary>
		/// 매수호가9
		/// </summary>
		[XAQueryFieldAttribute("bidho9", "매수호가9", "long", "8")]
		public long bidho9;
		/// <summary>
		/// 매도호가수량9
		/// </summary>
		[XAQueryFieldAttribute("offerrem9", "매도호가수량9", "long", "8")]
		public long offerrem9;
		/// <summary>
		/// 매수호가수량9
		/// </summary>
		[XAQueryFieldAttribute("bidrem9", "매수호가수량9", "long", "8")]
		public long bidrem9;
		/// <summary>
		/// 매도호가건수9
		/// </summary>
		[XAQueryFieldAttribute("dcnt9", "매도호가건수9", "long", "8")]
		public long dcnt9;
		/// <summary>
		/// 매수호가건수9
		/// </summary>
		[XAQueryFieldAttribute("scnt9", "매수호가건수9", "long", "8")]
		public long scnt9;
		/// <summary>
		/// 매도호가10
		/// </summary>
		[XAQueryFieldAttribute("offerho10", "매도호가10", "long", "8")]
		public long offerho10;
		/// <summary>
		/// 매수호가10
		/// </summary>
		[XAQueryFieldAttribute("bidho10", "매수호가10", "long", "8")]
		public long bidho10;
		/// <summary>
		/// 매도호가수량10
		/// </summary>
		[XAQueryFieldAttribute("offerrem10", "매도호가수량10", "long", "8")]
		public long offerrem10;
		/// <summary>
		/// 매수호가수량10
		/// </summary>
		[XAQueryFieldAttribute("bidrem10", "매수호가수량10", "long", "8")]
		public long bidrem10;
		/// <summary>
		/// 매도호가건수10
		/// </summary>
		[XAQueryFieldAttribute("dcnt10", "매도호가건수10", "long", "8")]
		public long dcnt10;
		/// <summary>
		/// 매수호가건수10
		/// </summary>
		[XAQueryFieldAttribute("scnt10", "매수호가건수10", "long", "8")]
		public long scnt10;
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
		[XAQueryFieldAttribute("shcode", "단축코드", "char", "6")]
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
			/// 거래량전일동시간비율
			/// </summary>
			public const string stimeqrt = "stimeqrt";
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
			/// 매도호가6
			/// </summary>
			public const string offerho6 = "offerho6";
			/// <summary>
			/// 매수호가6
			/// </summary>
			public const string bidho6 = "bidho6";
			/// <summary>
			/// 매도호가수량6
			/// </summary>
			public const string offerrem6 = "offerrem6";
			/// <summary>
			/// 매수호가수량6
			/// </summary>
			public const string bidrem6 = "bidrem6";
			/// <summary>
			/// 매도호가건수6
			/// </summary>
			public const string dcnt6 = "dcnt6";
			/// <summary>
			/// 매수호가건수6
			/// </summary>
			public const string scnt6 = "scnt6";
			/// <summary>
			/// 매도호가7
			/// </summary>
			public const string offerho7 = "offerho7";
			/// <summary>
			/// 매수호가7
			/// </summary>
			public const string bidho7 = "bidho7";
			/// <summary>
			/// 매도호가수량7
			/// </summary>
			public const string offerrem7 = "offerrem7";
			/// <summary>
			/// 매수호가수량7
			/// </summary>
			public const string bidrem7 = "bidrem7";
			/// <summary>
			/// 매도호가건수7
			/// </summary>
			public const string dcnt7 = "dcnt7";
			/// <summary>
			/// 매수호가건수7
			/// </summary>
			public const string scnt7 = "scnt7";
			/// <summary>
			/// 매도호가8
			/// </summary>
			public const string offerho8 = "offerho8";
			/// <summary>
			/// 매수호가8
			/// </summary>
			public const string bidho8 = "bidho8";
			/// <summary>
			/// 매도호가수량8
			/// </summary>
			public const string offerrem8 = "offerrem8";
			/// <summary>
			/// 매수호가수량8
			/// </summary>
			public const string bidrem8 = "bidrem8";
			/// <summary>
			/// 매도호가건수8
			/// </summary>
			public const string dcnt8 = "dcnt8";
			/// <summary>
			/// 매수호가건수8
			/// </summary>
			public const string scnt8 = "scnt8";
			/// <summary>
			/// 매도호가9
			/// </summary>
			public const string offerho9 = "offerho9";
			/// <summary>
			/// 매수호가9
			/// </summary>
			public const string bidho9 = "bidho9";
			/// <summary>
			/// 매도호가수량9
			/// </summary>
			public const string offerrem9 = "offerrem9";
			/// <summary>
			/// 매수호가수량9
			/// </summary>
			public const string bidrem9 = "bidrem9";
			/// <summary>
			/// 매도호가건수9
			/// </summary>
			public const string dcnt9 = "dcnt9";
			/// <summary>
			/// 매수호가건수9
			/// </summary>
			public const string scnt9 = "scnt9";
			/// <summary>
			/// 매도호가10
			/// </summary>
			public const string offerho10 = "offerho10";
			/// <summary>
			/// 매수호가10
			/// </summary>
			public const string bidho10 = "bidho10";
			/// <summary>
			/// 매도호가수량10
			/// </summary>
			public const string offerrem10 = "offerrem10";
			/// <summary>
			/// 매수호가수량10
			/// </summary>
			public const string bidrem10 = "bidrem10";
			/// <summary>
			/// 매도호가건수10
			/// </summary>
			public const string dcnt10 = "dcnt10";
			/// <summary>
			/// 매수호가건수10
			/// </summary>
			public const string scnt10 = "scnt10";
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
			F.stimeqrt,
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
			F.offerho6,
			F.bidho6,
			F.offerrem6,
			F.bidrem6,
			F.dcnt6,
			F.scnt6,
			F.offerho7,
			F.bidho7,
			F.offerrem7,
			F.bidrem7,
			F.dcnt7,
			F.scnt7,
			F.offerho8,
			F.bidho8,
			F.offerrem8,
			F.bidrem8,
			F.dcnt8,
			F.scnt8,
			F.offerho9,
			F.bidho9,
			F.offerrem9,
			F.bidrem9,
			F.dcnt9,
			F.scnt9,
			F.offerho10,
			F.bidho10,
			F.offerrem10,
			F.bidrem10,
			F.dcnt10,
			F.scnt10,
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
			dict["price"] = new XAQueryFieldInfo("long", price, price.ToString("d8"), "현재가", (decimal)8);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("long", change, change.ToString("d8"), "전일대비", (decimal)8);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "거래량", (decimal)12);
			dict["stimeqrt"] = new XAQueryFieldInfo("float", stimeqrt, stimeqrt.ToString("000000.00"), "거래량전일동시간비율", (decimal)6.2);
			dict["jnilclose"] = new XAQueryFieldInfo("long", jnilclose, jnilclose.ToString("d8"), "전일종가", (decimal)8);
			dict["offerho1"] = new XAQueryFieldInfo("long", offerho1, offerho1.ToString("d8"), "매도호가1", (decimal)8);
			dict["bidho1"] = new XAQueryFieldInfo("long", bidho1, bidho1.ToString("d8"), "매수호가1", (decimal)8);
			dict["offerrem1"] = new XAQueryFieldInfo("long", offerrem1, offerrem1.ToString("d8"), "매도호가수량1", (decimal)8);
			dict["bidrem1"] = new XAQueryFieldInfo("long", bidrem1, bidrem1.ToString("d8"), "매수호가수량1", (decimal)8);
			dict["dcnt1"] = new XAQueryFieldInfo("long", dcnt1, dcnt1.ToString("d8"), "매도호가건수1", (decimal)8);
			dict["scnt1"] = new XAQueryFieldInfo("long", scnt1, scnt1.ToString("d8"), "매수호가건수1", (decimal)8);
			dict["offerho2"] = new XAQueryFieldInfo("long", offerho2, offerho2.ToString("d8"), "매도호가2", (decimal)8);
			dict["bidho2"] = new XAQueryFieldInfo("long", bidho2, bidho2.ToString("d8"), "매수호가2", (decimal)8);
			dict["offerrem2"] = new XAQueryFieldInfo("long", offerrem2, offerrem2.ToString("d8"), "매도호가수량2", (decimal)8);
			dict["bidrem2"] = new XAQueryFieldInfo("long", bidrem2, bidrem2.ToString("d8"), "매수호가수량2", (decimal)8);
			dict["dcnt2"] = new XAQueryFieldInfo("long", dcnt2, dcnt2.ToString("d8"), "매도호가건수2", (decimal)8);
			dict["scnt2"] = new XAQueryFieldInfo("long", scnt2, scnt2.ToString("d8"), "매수호가건수2", (decimal)8);
			dict["offerho3"] = new XAQueryFieldInfo("long", offerho3, offerho3.ToString("d8"), "매도호가3", (decimal)8);
			dict["bidho3"] = new XAQueryFieldInfo("long", bidho3, bidho3.ToString("d8"), "매수호가3", (decimal)8);
			dict["offerrem3"] = new XAQueryFieldInfo("long", offerrem3, offerrem3.ToString("d8"), "매도호가수량3", (decimal)8);
			dict["bidrem3"] = new XAQueryFieldInfo("long", bidrem3, bidrem3.ToString("d8"), "매수호가수량3", (decimal)8);
			dict["dcnt3"] = new XAQueryFieldInfo("long", dcnt3, dcnt3.ToString("d8"), "매도호가건수3", (decimal)8);
			dict["scnt3"] = new XAQueryFieldInfo("long", scnt3, scnt3.ToString("d8"), "매수호가건수3", (decimal)8);
			dict["offerho4"] = new XAQueryFieldInfo("long", offerho4, offerho4.ToString("d8"), "매도호가4", (decimal)8);
			dict["bidho4"] = new XAQueryFieldInfo("long", bidho4, bidho4.ToString("d8"), "매수호가4", (decimal)8);
			dict["offerrem4"] = new XAQueryFieldInfo("long", offerrem4, offerrem4.ToString("d8"), "매도호가수량4", (decimal)8);
			dict["bidrem4"] = new XAQueryFieldInfo("long", bidrem4, bidrem4.ToString("d8"), "매수호가수량4", (decimal)8);
			dict["dcnt4"] = new XAQueryFieldInfo("long", dcnt4, dcnt4.ToString("d8"), "매도호가건수4", (decimal)8);
			dict["scnt4"] = new XAQueryFieldInfo("long", scnt4, scnt4.ToString("d8"), "매수호가건수4", (decimal)8);
			dict["offerho5"] = new XAQueryFieldInfo("long", offerho5, offerho5.ToString("d8"), "매도호가5", (decimal)8);
			dict["bidho5"] = new XAQueryFieldInfo("long", bidho5, bidho5.ToString("d8"), "매수호가5", (decimal)8);
			dict["offerrem5"] = new XAQueryFieldInfo("long", offerrem5, offerrem5.ToString("d8"), "매도호가수량5", (decimal)8);
			dict["bidrem5"] = new XAQueryFieldInfo("long", bidrem5, bidrem5.ToString("d8"), "매수호가수량5", (decimal)8);
			dict["dcnt5"] = new XAQueryFieldInfo("long", dcnt5, dcnt5.ToString("d8"), "매도호가건수5", (decimal)8);
			dict["scnt5"] = new XAQueryFieldInfo("long", scnt5, scnt5.ToString("d8"), "매수호가건수5", (decimal)8);
			dict["offerho6"] = new XAQueryFieldInfo("long", offerho6, offerho6.ToString("d8"), "매도호가6", (decimal)8);
			dict["bidho6"] = new XAQueryFieldInfo("long", bidho6, bidho6.ToString("d8"), "매수호가6", (decimal)8);
			dict["offerrem6"] = new XAQueryFieldInfo("long", offerrem6, offerrem6.ToString("d8"), "매도호가수량6", (decimal)8);
			dict["bidrem6"] = new XAQueryFieldInfo("long", bidrem6, bidrem6.ToString("d8"), "매수호가수량6", (decimal)8);
			dict["dcnt6"] = new XAQueryFieldInfo("long", dcnt6, dcnt6.ToString("d8"), "매도호가건수6", (decimal)8);
			dict["scnt6"] = new XAQueryFieldInfo("long", scnt6, scnt6.ToString("d8"), "매수호가건수6", (decimal)8);
			dict["offerho7"] = new XAQueryFieldInfo("long", offerho7, offerho7.ToString("d8"), "매도호가7", (decimal)8);
			dict["bidho7"] = new XAQueryFieldInfo("long", bidho7, bidho7.ToString("d8"), "매수호가7", (decimal)8);
			dict["offerrem7"] = new XAQueryFieldInfo("long", offerrem7, offerrem7.ToString("d8"), "매도호가수량7", (decimal)8);
			dict["bidrem7"] = new XAQueryFieldInfo("long", bidrem7, bidrem7.ToString("d8"), "매수호가수량7", (decimal)8);
			dict["dcnt7"] = new XAQueryFieldInfo("long", dcnt7, dcnt7.ToString("d8"), "매도호가건수7", (decimal)8);
			dict["scnt7"] = new XAQueryFieldInfo("long", scnt7, scnt7.ToString("d8"), "매수호가건수7", (decimal)8);
			dict["offerho8"] = new XAQueryFieldInfo("long", offerho8, offerho8.ToString("d8"), "매도호가8", (decimal)8);
			dict["bidho8"] = new XAQueryFieldInfo("long", bidho8, bidho8.ToString("d8"), "매수호가8", (decimal)8);
			dict["offerrem8"] = new XAQueryFieldInfo("long", offerrem8, offerrem8.ToString("d8"), "매도호가수량8", (decimal)8);
			dict["bidrem8"] = new XAQueryFieldInfo("long", bidrem8, bidrem8.ToString("d8"), "매수호가수량8", (decimal)8);
			dict["dcnt8"] = new XAQueryFieldInfo("long", dcnt8, dcnt8.ToString("d8"), "매도호가건수8", (decimal)8);
			dict["scnt8"] = new XAQueryFieldInfo("long", scnt8, scnt8.ToString("d8"), "매수호가건수8", (decimal)8);
			dict["offerho9"] = new XAQueryFieldInfo("long", offerho9, offerho9.ToString("d8"), "매도호가9", (decimal)8);
			dict["bidho9"] = new XAQueryFieldInfo("long", bidho9, bidho9.ToString("d8"), "매수호가9", (decimal)8);
			dict["offerrem9"] = new XAQueryFieldInfo("long", offerrem9, offerrem9.ToString("d8"), "매도호가수량9", (decimal)8);
			dict["bidrem9"] = new XAQueryFieldInfo("long", bidrem9, bidrem9.ToString("d8"), "매수호가수량9", (decimal)8);
			dict["dcnt9"] = new XAQueryFieldInfo("long", dcnt9, dcnt9.ToString("d8"), "매도호가건수9", (decimal)8);
			dict["scnt9"] = new XAQueryFieldInfo("long", scnt9, scnt9.ToString("d8"), "매수호가건수9", (decimal)8);
			dict["offerho10"] = new XAQueryFieldInfo("long", offerho10, offerho10.ToString("d8"), "매도호가10", (decimal)8);
			dict["bidho10"] = new XAQueryFieldInfo("long", bidho10, bidho10.ToString("d8"), "매수호가10", (decimal)8);
			dict["offerrem10"] = new XAQueryFieldInfo("long", offerrem10, offerrem10.ToString("d8"), "매도호가수량10", (decimal)8);
			dict["bidrem10"] = new XAQueryFieldInfo("long", bidrem10, bidrem10.ToString("d8"), "매수호가수량10", (decimal)8);
			dict["dcnt10"] = new XAQueryFieldInfo("long", dcnt10, dcnt10.ToString("d8"), "매도호가건수10", (decimal)8);
			dict["scnt10"] = new XAQueryFieldInfo("long", scnt10, scnt10.ToString("d8"), "매수호가건수10", (decimal)8);
			dict["dvol"] = new XAQueryFieldInfo("long", dvol, dvol.ToString("d8"), "매도호가총수량", (decimal)8);
			dict["svol"] = new XAQueryFieldInfo("long", svol, svol.ToString("d8"), "매수호가총수량", (decimal)8);
			dict["toffernum"] = new XAQueryFieldInfo("long", toffernum, toffernum.ToString("d8"), "총매도호가건수", (decimal)8);
			dict["tbidnum"] = new XAQueryFieldInfo("long", tbidnum, tbidnum.ToString("d8"), "총매수호가건수", (decimal)8);
			dict["time"] = new XAQueryFieldInfo("char", time, time, "수신시간", (decimal)6);
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)6);

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

				case "stimeqrt":
					this.stimeqrt = fieldInfo.FieldValue.ParseFloat("stimeqrt");
				break;

				case "jnilclose":
					this.jnilclose = fieldInfo.FieldValue.ParseLong("jnilclose");
				break;

				case "offerho1":
					this.offerho1 = fieldInfo.FieldValue.ParseLong("offerho1");
				break;

				case "bidho1":
					this.bidho1 = fieldInfo.FieldValue.ParseLong("bidho1");
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
					this.offerho2 = fieldInfo.FieldValue.ParseLong("offerho2");
				break;

				case "bidho2":
					this.bidho2 = fieldInfo.FieldValue.ParseLong("bidho2");
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
					this.offerho3 = fieldInfo.FieldValue.ParseLong("offerho3");
				break;

				case "bidho3":
					this.bidho3 = fieldInfo.FieldValue.ParseLong("bidho3");
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
					this.offerho4 = fieldInfo.FieldValue.ParseLong("offerho4");
				break;

				case "bidho4":
					this.bidho4 = fieldInfo.FieldValue.ParseLong("bidho4");
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
					this.offerho5 = fieldInfo.FieldValue.ParseLong("offerho5");
				break;

				case "bidho5":
					this.bidho5 = fieldInfo.FieldValue.ParseLong("bidho5");
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

				case "offerho6":
					this.offerho6 = fieldInfo.FieldValue.ParseLong("offerho6");
				break;

				case "bidho6":
					this.bidho6 = fieldInfo.FieldValue.ParseLong("bidho6");
				break;

				case "offerrem6":
					this.offerrem6 = fieldInfo.FieldValue.ParseLong("offerrem6");
				break;

				case "bidrem6":
					this.bidrem6 = fieldInfo.FieldValue.ParseLong("bidrem6");
				break;

				case "dcnt6":
					this.dcnt6 = fieldInfo.FieldValue.ParseLong("dcnt6");
				break;

				case "scnt6":
					this.scnt6 = fieldInfo.FieldValue.ParseLong("scnt6");
				break;

				case "offerho7":
					this.offerho7 = fieldInfo.FieldValue.ParseLong("offerho7");
				break;

				case "bidho7":
					this.bidho7 = fieldInfo.FieldValue.ParseLong("bidho7");
				break;

				case "offerrem7":
					this.offerrem7 = fieldInfo.FieldValue.ParseLong("offerrem7");
				break;

				case "bidrem7":
					this.bidrem7 = fieldInfo.FieldValue.ParseLong("bidrem7");
				break;

				case "dcnt7":
					this.dcnt7 = fieldInfo.FieldValue.ParseLong("dcnt7");
				break;

				case "scnt7":
					this.scnt7 = fieldInfo.FieldValue.ParseLong("scnt7");
				break;

				case "offerho8":
					this.offerho8 = fieldInfo.FieldValue.ParseLong("offerho8");
				break;

				case "bidho8":
					this.bidho8 = fieldInfo.FieldValue.ParseLong("bidho8");
				break;

				case "offerrem8":
					this.offerrem8 = fieldInfo.FieldValue.ParseLong("offerrem8");
				break;

				case "bidrem8":
					this.bidrem8 = fieldInfo.FieldValue.ParseLong("bidrem8");
				break;

				case "dcnt8":
					this.dcnt8 = fieldInfo.FieldValue.ParseLong("dcnt8");
				break;

				case "scnt8":
					this.scnt8 = fieldInfo.FieldValue.ParseLong("scnt8");
				break;

				case "offerho9":
					this.offerho9 = fieldInfo.FieldValue.ParseLong("offerho9");
				break;

				case "bidho9":
					this.bidho9 = fieldInfo.FieldValue.ParseLong("bidho9");
				break;

				case "offerrem9":
					this.offerrem9 = fieldInfo.FieldValue.ParseLong("offerrem9");
				break;

				case "bidrem9":
					this.bidrem9 = fieldInfo.FieldValue.ParseLong("bidrem9");
				break;

				case "dcnt9":
					this.dcnt9 = fieldInfo.FieldValue.ParseLong("dcnt9");
				break;

				case "scnt9":
					this.scnt9 = fieldInfo.FieldValue.ParseLong("scnt9");
				break;

				case "offerho10":
					this.offerho10 = fieldInfo.FieldValue.ParseLong("offerho10");
				break;

				case "bidho10":
					this.bidho10 = fieldInfo.FieldValue.ParseLong("bidho10");
				break;

				case "offerrem10":
					this.offerrem10 = fieldInfo.FieldValue.ParseLong("offerrem10");
				break;

				case "bidrem10":
					this.bidrem10 = fieldInfo.FieldValue.ParseLong("bidrem10");
				break;

				case "dcnt10":
					this.dcnt10 = fieldInfo.FieldValue.ParseLong("dcnt10");
				break;

				case "scnt10":
					this.scnt10 = fieldInfo.FieldValue.ParseLong("scnt10");
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

		public static XQt8403OutBlock FromQuery(XQt8403 query)
		{
			XQt8403OutBlock block = new XQt8403OutBlock();
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
				block.price = query.GetFieldData(block.GetBlockName(), "price", 0).ParseLong("price"); // long 8
				block.sign = query.GetFieldData(block.GetBlockName(), "sign", 0).FirstOrDefault(); // char 1
				block.change = query.GetFieldData(block.GetBlockName(), "change", 0).ParseLong("change"); // long 8
				block.diff = query.GetFieldData(block.GetBlockName(), "diff", 0).ParseFloat("diff"); // float 6.2
				block.volume = query.GetFieldData(block.GetBlockName(), "volume", 0).ParseLong("volume"); // long 12
				block.stimeqrt = query.GetFieldData(block.GetBlockName(), "stimeqrt", 0).ParseFloat("stimeqrt"); // float 6.2
				block.jnilclose = query.GetFieldData(block.GetBlockName(), "jnilclose", 0).ParseLong("jnilclose"); // long 8
				block.offerho1 = query.GetFieldData(block.GetBlockName(), "offerho1", 0).ParseLong("offerho1"); // long 8
				block.bidho1 = query.GetFieldData(block.GetBlockName(), "bidho1", 0).ParseLong("bidho1"); // long 8
				block.offerrem1 = query.GetFieldData(block.GetBlockName(), "offerrem1", 0).ParseLong("offerrem1"); // long 8
				block.bidrem1 = query.GetFieldData(block.GetBlockName(), "bidrem1", 0).ParseLong("bidrem1"); // long 8
				block.dcnt1 = query.GetFieldData(block.GetBlockName(), "dcnt1", 0).ParseLong("dcnt1"); // long 8
				block.scnt1 = query.GetFieldData(block.GetBlockName(), "scnt1", 0).ParseLong("scnt1"); // long 8
				block.offerho2 = query.GetFieldData(block.GetBlockName(), "offerho2", 0).ParseLong("offerho2"); // long 8
				block.bidho2 = query.GetFieldData(block.GetBlockName(), "bidho2", 0).ParseLong("bidho2"); // long 8
				block.offerrem2 = query.GetFieldData(block.GetBlockName(), "offerrem2", 0).ParseLong("offerrem2"); // long 8
				block.bidrem2 = query.GetFieldData(block.GetBlockName(), "bidrem2", 0).ParseLong("bidrem2"); // long 8
				block.dcnt2 = query.GetFieldData(block.GetBlockName(), "dcnt2", 0).ParseLong("dcnt2"); // long 8
				block.scnt2 = query.GetFieldData(block.GetBlockName(), "scnt2", 0).ParseLong("scnt2"); // long 8
				block.offerho3 = query.GetFieldData(block.GetBlockName(), "offerho3", 0).ParseLong("offerho3"); // long 8
				block.bidho3 = query.GetFieldData(block.GetBlockName(), "bidho3", 0).ParseLong("bidho3"); // long 8
				block.offerrem3 = query.GetFieldData(block.GetBlockName(), "offerrem3", 0).ParseLong("offerrem3"); // long 8
				block.bidrem3 = query.GetFieldData(block.GetBlockName(), "bidrem3", 0).ParseLong("bidrem3"); // long 8
				block.dcnt3 = query.GetFieldData(block.GetBlockName(), "dcnt3", 0).ParseLong("dcnt3"); // long 8
				block.scnt3 = query.GetFieldData(block.GetBlockName(), "scnt3", 0).ParseLong("scnt3"); // long 8
				block.offerho4 = query.GetFieldData(block.GetBlockName(), "offerho4", 0).ParseLong("offerho4"); // long 8
				block.bidho4 = query.GetFieldData(block.GetBlockName(), "bidho4", 0).ParseLong("bidho4"); // long 8
				block.offerrem4 = query.GetFieldData(block.GetBlockName(), "offerrem4", 0).ParseLong("offerrem4"); // long 8
				block.bidrem4 = query.GetFieldData(block.GetBlockName(), "bidrem4", 0).ParseLong("bidrem4"); // long 8
				block.dcnt4 = query.GetFieldData(block.GetBlockName(), "dcnt4", 0).ParseLong("dcnt4"); // long 8
				block.scnt4 = query.GetFieldData(block.GetBlockName(), "scnt4", 0).ParseLong("scnt4"); // long 8
				block.offerho5 = query.GetFieldData(block.GetBlockName(), "offerho5", 0).ParseLong("offerho5"); // long 8
				block.bidho5 = query.GetFieldData(block.GetBlockName(), "bidho5", 0).ParseLong("bidho5"); // long 8
				block.offerrem5 = query.GetFieldData(block.GetBlockName(), "offerrem5", 0).ParseLong("offerrem5"); // long 8
				block.bidrem5 = query.GetFieldData(block.GetBlockName(), "bidrem5", 0).ParseLong("bidrem5"); // long 8
				block.dcnt5 = query.GetFieldData(block.GetBlockName(), "dcnt5", 0).ParseLong("dcnt5"); // long 8
				block.scnt5 = query.GetFieldData(block.GetBlockName(), "scnt5", 0).ParseLong("scnt5"); // long 8
				block.offerho6 = query.GetFieldData(block.GetBlockName(), "offerho6", 0).ParseLong("offerho6"); // long 8
				block.bidho6 = query.GetFieldData(block.GetBlockName(), "bidho6", 0).ParseLong("bidho6"); // long 8
				block.offerrem6 = query.GetFieldData(block.GetBlockName(), "offerrem6", 0).ParseLong("offerrem6"); // long 8
				block.bidrem6 = query.GetFieldData(block.GetBlockName(), "bidrem6", 0).ParseLong("bidrem6"); // long 8
				block.dcnt6 = query.GetFieldData(block.GetBlockName(), "dcnt6", 0).ParseLong("dcnt6"); // long 8
				block.scnt6 = query.GetFieldData(block.GetBlockName(), "scnt6", 0).ParseLong("scnt6"); // long 8
				block.offerho7 = query.GetFieldData(block.GetBlockName(), "offerho7", 0).ParseLong("offerho7"); // long 8
				block.bidho7 = query.GetFieldData(block.GetBlockName(), "bidho7", 0).ParseLong("bidho7"); // long 8
				block.offerrem7 = query.GetFieldData(block.GetBlockName(), "offerrem7", 0).ParseLong("offerrem7"); // long 8
				block.bidrem7 = query.GetFieldData(block.GetBlockName(), "bidrem7", 0).ParseLong("bidrem7"); // long 8
				block.dcnt7 = query.GetFieldData(block.GetBlockName(), "dcnt7", 0).ParseLong("dcnt7"); // long 8
				block.scnt7 = query.GetFieldData(block.GetBlockName(), "scnt7", 0).ParseLong("scnt7"); // long 8
				block.offerho8 = query.GetFieldData(block.GetBlockName(), "offerho8", 0).ParseLong("offerho8"); // long 8
				block.bidho8 = query.GetFieldData(block.GetBlockName(), "bidho8", 0).ParseLong("bidho8"); // long 8
				block.offerrem8 = query.GetFieldData(block.GetBlockName(), "offerrem8", 0).ParseLong("offerrem8"); // long 8
				block.bidrem8 = query.GetFieldData(block.GetBlockName(), "bidrem8", 0).ParseLong("bidrem8"); // long 8
				block.dcnt8 = query.GetFieldData(block.GetBlockName(), "dcnt8", 0).ParseLong("dcnt8"); // long 8
				block.scnt8 = query.GetFieldData(block.GetBlockName(), "scnt8", 0).ParseLong("scnt8"); // long 8
				block.offerho9 = query.GetFieldData(block.GetBlockName(), "offerho9", 0).ParseLong("offerho9"); // long 8
				block.bidho9 = query.GetFieldData(block.GetBlockName(), "bidho9", 0).ParseLong("bidho9"); // long 8
				block.offerrem9 = query.GetFieldData(block.GetBlockName(), "offerrem9", 0).ParseLong("offerrem9"); // long 8
				block.bidrem9 = query.GetFieldData(block.GetBlockName(), "bidrem9", 0).ParseLong("bidrem9"); // long 8
				block.dcnt9 = query.GetFieldData(block.GetBlockName(), "dcnt9", 0).ParseLong("dcnt9"); // long 8
				block.scnt9 = query.GetFieldData(block.GetBlockName(), "scnt9", 0).ParseLong("scnt9"); // long 8
				block.offerho10 = query.GetFieldData(block.GetBlockName(), "offerho10", 0).ParseLong("offerho10"); // long 8
				block.bidho10 = query.GetFieldData(block.GetBlockName(), "bidho10", 0).ParseLong("bidho10"); // long 8
				block.offerrem10 = query.GetFieldData(block.GetBlockName(), "offerrem10", 0).ParseLong("offerrem10"); // long 8
				block.bidrem10 = query.GetFieldData(block.GetBlockName(), "bidrem10", 0).ParseLong("bidrem10"); // long 8
				block.dcnt10 = query.GetFieldData(block.GetBlockName(), "dcnt10", 0).ParseLong("dcnt10"); // long 8
				block.scnt10 = query.GetFieldData(block.GetBlockName(), "scnt10", 0).ParseLong("scnt10"); // long 8
				block.dvol = query.GetFieldData(block.GetBlockName(), "dvol", 0).ParseLong("dvol"); // long 8
				block.svol = query.GetFieldData(block.GetBlockName(), "svol", 0).ParseLong("svol"); // long 8
				block.toffernum = query.GetFieldData(block.GetBlockName(), "toffernum", 0).ParseLong("toffernum"); // long 8
				block.tbidnum = query.GetFieldData(block.GetBlockName(), "tbidnum", 0).ParseLong("tbidnum"); // long 8
				block.time = query.GetFieldData(block.GetBlockName(), "time", 0).TrimEnd('?'); // char 6
				block.shcode = query.GetFieldData(block.GetBlockName(), "shcode", 0).TrimEnd('?'); // char 6

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (hname?.Length > 20) return false; // char 20
			if (price.ToString().Length > 8) return false; // long 8
			// sign char 1
			if (change.ToString().Length > 8) return false; // long 8
			// diff float 6.2
			if (volume.ToString().Length > 12) return false; // long 12
			// stimeqrt float 6.2
			if (jnilclose.ToString().Length > 8) return false; // long 8
			if (offerho1.ToString().Length > 8) return false; // long 8
			if (bidho1.ToString().Length > 8) return false; // long 8
			if (offerrem1.ToString().Length > 8) return false; // long 8
			if (bidrem1.ToString().Length > 8) return false; // long 8
			if (dcnt1.ToString().Length > 8) return false; // long 8
			if (scnt1.ToString().Length > 8) return false; // long 8
			if (offerho2.ToString().Length > 8) return false; // long 8
			if (bidho2.ToString().Length > 8) return false; // long 8
			if (offerrem2.ToString().Length > 8) return false; // long 8
			if (bidrem2.ToString().Length > 8) return false; // long 8
			if (dcnt2.ToString().Length > 8) return false; // long 8
			if (scnt2.ToString().Length > 8) return false; // long 8
			if (offerho3.ToString().Length > 8) return false; // long 8
			if (bidho3.ToString().Length > 8) return false; // long 8
			if (offerrem3.ToString().Length > 8) return false; // long 8
			if (bidrem3.ToString().Length > 8) return false; // long 8
			if (dcnt3.ToString().Length > 8) return false; // long 8
			if (scnt3.ToString().Length > 8) return false; // long 8
			if (offerho4.ToString().Length > 8) return false; // long 8
			if (bidho4.ToString().Length > 8) return false; // long 8
			if (offerrem4.ToString().Length > 8) return false; // long 8
			if (bidrem4.ToString().Length > 8) return false; // long 8
			if (dcnt4.ToString().Length > 8) return false; // long 8
			if (scnt4.ToString().Length > 8) return false; // long 8
			if (offerho5.ToString().Length > 8) return false; // long 8
			if (bidho5.ToString().Length > 8) return false; // long 8
			if (offerrem5.ToString().Length > 8) return false; // long 8
			if (bidrem5.ToString().Length > 8) return false; // long 8
			if (dcnt5.ToString().Length > 8) return false; // long 8
			if (scnt5.ToString().Length > 8) return false; // long 8
			if (offerho6.ToString().Length > 8) return false; // long 8
			if (bidho6.ToString().Length > 8) return false; // long 8
			if (offerrem6.ToString().Length > 8) return false; // long 8
			if (bidrem6.ToString().Length > 8) return false; // long 8
			if (dcnt6.ToString().Length > 8) return false; // long 8
			if (scnt6.ToString().Length > 8) return false; // long 8
			if (offerho7.ToString().Length > 8) return false; // long 8
			if (bidho7.ToString().Length > 8) return false; // long 8
			if (offerrem7.ToString().Length > 8) return false; // long 8
			if (bidrem7.ToString().Length > 8) return false; // long 8
			if (dcnt7.ToString().Length > 8) return false; // long 8
			if (scnt7.ToString().Length > 8) return false; // long 8
			if (offerho8.ToString().Length > 8) return false; // long 8
			if (bidho8.ToString().Length > 8) return false; // long 8
			if (offerrem8.ToString().Length > 8) return false; // long 8
			if (bidrem8.ToString().Length > 8) return false; // long 8
			if (dcnt8.ToString().Length > 8) return false; // long 8
			if (scnt8.ToString().Length > 8) return false; // long 8
			if (offerho9.ToString().Length > 8) return false; // long 8
			if (bidho9.ToString().Length > 8) return false; // long 8
			if (offerrem9.ToString().Length > 8) return false; // long 8
			if (bidrem9.ToString().Length > 8) return false; // long 8
			if (dcnt9.ToString().Length > 8) return false; // long 8
			if (scnt9.ToString().Length > 8) return false; // long 8
			if (offerho10.ToString().Length > 8) return false; // long 8
			if (bidho10.ToString().Length > 8) return false; // long 8
			if (offerrem10.ToString().Length > 8) return false; // long 8
			if (bidrem10.ToString().Length > 8) return false; // long 8
			if (dcnt10.ToString().Length > 8) return false; // long 8
			if (scnt10.ToString().Length > 8) return false; // long 8
			if (dvol.ToString().Length > 8) return false; // long 8
			if (svol.ToString().Length > 8) return false; // long 8
			if (toffernum.ToString().Length > 8) return false; // long 8
			if (tbidnum.ToString().Length > 8) return false; // long 8
			if (time?.Length > 6) return false; // char 6
			if (shcode?.Length > 6) return false; // char 6

			return true;
		}
	}

	/// <summary>
	/// 주식선물호가조회(API용)(t8403)
	/// </summary>
	public partial class XQt8403 : XingQuery
	{
		/// <summary>
		/// t8403
		/// </summary>
		public const string _typeName = "t8403";
		/// <summary>
		/// 주식선물호가조회(API용)(t8403)
		/// </summary>
		public const string _typeDesc = "주식선물호가조회(API용)(t8403)";
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
		/// t8403
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 주식선물호가조회(API용)(t8403)
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
		/// 주식선물호가조회(API용)(t8403)
		/// </summary>
		public XQt8403() : base("t8403") { }


		public static XQt8403OutBlock Get(string shcode = default)
		{
			using (XQt8403 instance = new XQt8403())
			{
				instance.SetFieldData(XQt8403InBlock.BlockName, XQt8403InBlock.F.shcode, 0, shcode); // char 8

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

		public static XQt8403OutBlock ReadFromDB(string tableNamePostfix = null /*, string shcode = default */)
		{
			using (XQt8403 instance = new XQt8403())
			{

				string tableName = (tableNamePostfix == null) ? "XQt8403OutBlock" : $"XQt8403OutBlock_{tableNamePostfix}";
				QueryOption qo = new QueryOption(tableName);
				// if (shcode != default) qo.Add("shcode", shcode);


				var outBlock = instance.Select<XQt8403OutBlock>(qo);
				return outBlock;
			}
		}

		public bool SetBlock(XQt8403InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "shcode", 0, block.shcode); // char 8

			return true;
		}

		public XQt8403OutBlock GetBlock()
		{
			XQt8403OutBlock instance = XQt8403OutBlock.FromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt8403OutBlock),

		};

	}

}
