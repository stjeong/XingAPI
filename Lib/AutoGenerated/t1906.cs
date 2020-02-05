using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1906InBlock : XingBlock
	{
		/// <summary>
		/// t1906InBlock
		/// </summary>
		public const string _blockName = "t1906InBlock";
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
		/// t1906InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1906InBlock
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
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)6);

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
			if (shcode?.Length > 6) return false; // char 6

			return true;
		}
	}

	public partial class XQt1906OutBlock : XingBlock
	{
		/// <summary>
		/// t1906OutBlock
		/// </summary>
		public const string _blockName = "t1906OutBlock";
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
		/// t1906OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1906OutBlock
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
		/// LP매도호가수량1
		/// </summary>
		[XAQueryFieldAttribute("LP매도호가수량1")]
		public long lp_offerrem1;
		/// <summary>
		/// LP매수호가수량1
		/// </summary>
		[XAQueryFieldAttribute("LP매수호가수량1")]
		public long lp_bidrem1;
		/// <summary>
		/// LP매도호가수량2
		/// </summary>
		[XAQueryFieldAttribute("LP매도호가수량2")]
		public long lp_offerrem2;
		/// <summary>
		/// LP매수호가수량2
		/// </summary>
		[XAQueryFieldAttribute("LP매수호가수량2")]
		public long lp_bidrem2;
		/// <summary>
		/// LP매도호가수량3
		/// </summary>
		[XAQueryFieldAttribute("LP매도호가수량3")]
		public long lp_offerrem3;
		/// <summary>
		/// LP매수호가수량3
		/// </summary>
		[XAQueryFieldAttribute("LP매수호가수량3")]
		public long lp_bidrem3;
		/// <summary>
		/// LP매도호가수량4
		/// </summary>
		[XAQueryFieldAttribute("LP매도호가수량4")]
		public long lp_offerrem4;
		/// <summary>
		/// LP매수호가수량4
		/// </summary>
		[XAQueryFieldAttribute("LP매수호가수량4")]
		public long lp_bidrem4;
		/// <summary>
		/// LP매도호가수량5
		/// </summary>
		[XAQueryFieldAttribute("LP매도호가수량5")]
		public long lp_offerrem5;
		/// <summary>
		/// LP매수호가수량5
		/// </summary>
		[XAQueryFieldAttribute("LP매수호가수량5")]
		public long lp_bidrem5;
		/// <summary>
		/// LP매도호가수량6
		/// </summary>
		[XAQueryFieldAttribute("LP매도호가수량6")]
		public long lp_offerrem6;
		/// <summary>
		/// LP매수호가수량6
		/// </summary>
		[XAQueryFieldAttribute("LP매수호가수량6")]
		public long lp_bidrem6;
		/// <summary>
		/// LP매도호가수량7
		/// </summary>
		[XAQueryFieldAttribute("LP매도호가수량7")]
		public long lp_offerrem7;
		/// <summary>
		/// LP매수호가수량7
		/// </summary>
		[XAQueryFieldAttribute("LP매수호가수량7")]
		public long lp_bidrem7;
		/// <summary>
		/// LP매도호가수량8
		/// </summary>
		[XAQueryFieldAttribute("LP매도호가수량8")]
		public long lp_offerrem8;
		/// <summary>
		/// LP매수호가수량8
		/// </summary>
		[XAQueryFieldAttribute("LP매수호가수량8")]
		public long lp_bidrem8;
		/// <summary>
		/// LP매도호가수량9
		/// </summary>
		[XAQueryFieldAttribute("LP매도호가수량9")]
		public long lp_offerrem9;
		/// <summary>
		/// LP매수호가수량9
		/// </summary>
		[XAQueryFieldAttribute("LP매수호가수량9")]
		public long lp_bidrem9;
		/// <summary>
		/// LP매도호가수량10
		/// </summary>
		[XAQueryFieldAttribute("LP매도호가수량10")]
		public long lp_offerrem10;
		/// <summary>
		/// LP매수호가수량10
		/// </summary>
		[XAQueryFieldAttribute("LP매수호가수량10")]
		public long lp_bidrem10;
		/// <summary>
		/// 전일종가
		/// </summary>
		[XAQueryFieldAttribute("전일종가")]
		public long jnilclose;
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
		/// 매도호가수량1
		/// </summary>
		[XAQueryFieldAttribute("매도호가수량1")]
		public long offerrem1;
		/// <summary>
		/// 매수호가수량1
		/// </summary>
		[XAQueryFieldAttribute("매수호가수량1")]
		public long bidrem1;
		/// <summary>
		/// 직전매도대비수량1
		/// </summary>
		[XAQueryFieldAttribute("직전매도대비수량1")]
		public long preoffercha1;
		/// <summary>
		/// 직전매수대비수량1
		/// </summary>
		[XAQueryFieldAttribute("직전매수대비수량1")]
		public long prebidcha1;
		/// <summary>
		/// 매도호가2
		/// </summary>
		[XAQueryFieldAttribute("매도호가2")]
		public long offerho2;
		/// <summary>
		/// 매수호가2
		/// </summary>
		[XAQueryFieldAttribute("매수호가2")]
		public long bidho2;
		/// <summary>
		/// 매도호가수량2
		/// </summary>
		[XAQueryFieldAttribute("매도호가수량2")]
		public long offerrem2;
		/// <summary>
		/// 매수호가수량2
		/// </summary>
		[XAQueryFieldAttribute("매수호가수량2")]
		public long bidrem2;
		/// <summary>
		/// 직전매도대비수량2
		/// </summary>
		[XAQueryFieldAttribute("직전매도대비수량2")]
		public long preoffercha2;
		/// <summary>
		/// 직전매수대비수량2
		/// </summary>
		[XAQueryFieldAttribute("직전매수대비수량2")]
		public long prebidcha2;
		/// <summary>
		/// 매도호가3
		/// </summary>
		[XAQueryFieldAttribute("매도호가3")]
		public long offerho3;
		/// <summary>
		/// 매수호가3
		/// </summary>
		[XAQueryFieldAttribute("매수호가3")]
		public long bidho3;
		/// <summary>
		/// 매도호가수량3
		/// </summary>
		[XAQueryFieldAttribute("매도호가수량3")]
		public long offerrem3;
		/// <summary>
		/// 매수호가수량3
		/// </summary>
		[XAQueryFieldAttribute("매수호가수량3")]
		public long bidrem3;
		/// <summary>
		/// 직전매도대비수량3
		/// </summary>
		[XAQueryFieldAttribute("직전매도대비수량3")]
		public long preoffercha3;
		/// <summary>
		/// 직전매수대비수량3
		/// </summary>
		[XAQueryFieldAttribute("직전매수대비수량3")]
		public long prebidcha3;
		/// <summary>
		/// 매도호가4
		/// </summary>
		[XAQueryFieldAttribute("매도호가4")]
		public long offerho4;
		/// <summary>
		/// 매수호가4
		/// </summary>
		[XAQueryFieldAttribute("매수호가4")]
		public long bidho4;
		/// <summary>
		/// 매도호가수량4
		/// </summary>
		[XAQueryFieldAttribute("매도호가수량4")]
		public long offerrem4;
		/// <summary>
		/// 매수호가수량4
		/// </summary>
		[XAQueryFieldAttribute("매수호가수량4")]
		public long bidrem4;
		/// <summary>
		/// 직전매도대비수량4
		/// </summary>
		[XAQueryFieldAttribute("직전매도대비수량4")]
		public long preoffercha4;
		/// <summary>
		/// 직전매수대비수량4
		/// </summary>
		[XAQueryFieldAttribute("직전매수대비수량4")]
		public long prebidcha4;
		/// <summary>
		/// 매도호가5
		/// </summary>
		[XAQueryFieldAttribute("매도호가5")]
		public long offerho5;
		/// <summary>
		/// 매수호가5
		/// </summary>
		[XAQueryFieldAttribute("매수호가5")]
		public long bidho5;
		/// <summary>
		/// 매도호가수량5
		/// </summary>
		[XAQueryFieldAttribute("매도호가수량5")]
		public long offerrem5;
		/// <summary>
		/// 매수호가수량5
		/// </summary>
		[XAQueryFieldAttribute("매수호가수량5")]
		public long bidrem5;
		/// <summary>
		/// 직전매도대비수량5
		/// </summary>
		[XAQueryFieldAttribute("직전매도대비수량5")]
		public long preoffercha5;
		/// <summary>
		/// 직전매수대비수량5
		/// </summary>
		[XAQueryFieldAttribute("직전매수대비수량5")]
		public long prebidcha5;
		/// <summary>
		/// 매도호가6
		/// </summary>
		[XAQueryFieldAttribute("매도호가6")]
		public long offerho6;
		/// <summary>
		/// 매수호가6
		/// </summary>
		[XAQueryFieldAttribute("매수호가6")]
		public long bidho6;
		/// <summary>
		/// 매도호가수량6
		/// </summary>
		[XAQueryFieldAttribute("매도호가수량6")]
		public long offerrem6;
		/// <summary>
		/// 매수호가수량6
		/// </summary>
		[XAQueryFieldAttribute("매수호가수량6")]
		public long bidrem6;
		/// <summary>
		/// 직전매도대비수량6
		/// </summary>
		[XAQueryFieldAttribute("직전매도대비수량6")]
		public long preoffercha6;
		/// <summary>
		/// 직전매수대비수량6
		/// </summary>
		[XAQueryFieldAttribute("직전매수대비수량6")]
		public long prebidcha6;
		/// <summary>
		/// 매도호가7
		/// </summary>
		[XAQueryFieldAttribute("매도호가7")]
		public long offerho7;
		/// <summary>
		/// 매수호가7
		/// </summary>
		[XAQueryFieldAttribute("매수호가7")]
		public long bidho7;
		/// <summary>
		/// 매도호가수량7
		/// </summary>
		[XAQueryFieldAttribute("매도호가수량7")]
		public long offerrem7;
		/// <summary>
		/// 매수호가수량7
		/// </summary>
		[XAQueryFieldAttribute("매수호가수량7")]
		public long bidrem7;
		/// <summary>
		/// 직전매도대비수량7
		/// </summary>
		[XAQueryFieldAttribute("직전매도대비수량7")]
		public long preoffercha7;
		/// <summary>
		/// 직전매수대비수량7
		/// </summary>
		[XAQueryFieldAttribute("직전매수대비수량7")]
		public long prebidcha7;
		/// <summary>
		/// 매도호가8
		/// </summary>
		[XAQueryFieldAttribute("매도호가8")]
		public long offerho8;
		/// <summary>
		/// 매수호가8
		/// </summary>
		[XAQueryFieldAttribute("매수호가8")]
		public long bidho8;
		/// <summary>
		/// 매도호가수량8
		/// </summary>
		[XAQueryFieldAttribute("매도호가수량8")]
		public long offerrem8;
		/// <summary>
		/// 매수호가수량8
		/// </summary>
		[XAQueryFieldAttribute("매수호가수량8")]
		public long bidrem8;
		/// <summary>
		/// 직전매도대비수량8
		/// </summary>
		[XAQueryFieldAttribute("직전매도대비수량8")]
		public long preoffercha8;
		/// <summary>
		/// 직전매수대비수량8
		/// </summary>
		[XAQueryFieldAttribute("직전매수대비수량8")]
		public long prebidcha8;
		/// <summary>
		/// 매도호가9
		/// </summary>
		[XAQueryFieldAttribute("매도호가9")]
		public long offerho9;
		/// <summary>
		/// 매수호가9
		/// </summary>
		[XAQueryFieldAttribute("매수호가9")]
		public long bidho9;
		/// <summary>
		/// 매도호가수량9
		/// </summary>
		[XAQueryFieldAttribute("매도호가수량9")]
		public long offerrem9;
		/// <summary>
		/// 매수호가수량9
		/// </summary>
		[XAQueryFieldAttribute("매수호가수량9")]
		public long bidrem9;
		/// <summary>
		/// 직전매도대비수량9
		/// </summary>
		[XAQueryFieldAttribute("직전매도대비수량9")]
		public long preoffercha9;
		/// <summary>
		/// 직전매수대비수량9
		/// </summary>
		[XAQueryFieldAttribute("직전매수대비수량9")]
		public long prebidcha9;
		/// <summary>
		/// 매도호가10
		/// </summary>
		[XAQueryFieldAttribute("매도호가10")]
		public long offerho10;
		/// <summary>
		/// 매수호가10
		/// </summary>
		[XAQueryFieldAttribute("매수호가10")]
		public long bidho10;
		/// <summary>
		/// 매도호가수량10
		/// </summary>
		[XAQueryFieldAttribute("매도호가수량10")]
		public long offerrem10;
		/// <summary>
		/// 매수호가수량10
		/// </summary>
		[XAQueryFieldAttribute("매수호가수량10")]
		public long bidrem10;
		/// <summary>
		/// 직전매도대비수량10
		/// </summary>
		[XAQueryFieldAttribute("직전매도대비수량10")]
		public long preoffercha10;
		/// <summary>
		/// 직전매수대비수량10
		/// </summary>
		[XAQueryFieldAttribute("직전매수대비수량10")]
		public long prebidcha10;
		/// <summary>
		/// 매도호가수량합
		/// </summary>
		[XAQueryFieldAttribute("매도호가수량합")]
		public long offer;
		/// <summary>
		/// 매수호가수량합
		/// </summary>
		[XAQueryFieldAttribute("매수호가수량합")]
		public long bid;
		/// <summary>
		/// 직전매도대비수량합
		/// </summary>
		[XAQueryFieldAttribute("직전매도대비수량합")]
		public long preoffercha;
		/// <summary>
		/// 직전매수대비수량합
		/// </summary>
		[XAQueryFieldAttribute("직전매수대비수량합")]
		public long prebidcha;
		/// <summary>
		/// 수신시간
		/// </summary>
		[XAQueryFieldAttribute("수신시간")]
		public string hotime;
		/// <summary>
		/// 예상체결가격
		/// </summary>
		[XAQueryFieldAttribute("예상체결가격")]
		public long yeprice;
		/// <summary>
		/// 예상체결수량
		/// </summary>
		[XAQueryFieldAttribute("예상체결수량")]
		public long yevolume;
		/// <summary>
		/// 예상체결전일구분
		/// </summary>
		[XAQueryFieldAttribute("예상체결전일구분")]
		public char yesign;
		/// <summary>
		/// 예상체결전일대비
		/// </summary>
		[XAQueryFieldAttribute("예상체결전일대비")]
		public long yechange;
		/// <summary>
		/// 예상체결등락율
		/// </summary>
		[XAQueryFieldAttribute("예상체결등락율")]
		public float yediff;
		/// <summary>
		/// 시간외매도잔량
		/// </summary>
		[XAQueryFieldAttribute("시간외매도잔량")]
		public long tmoffer;
		/// <summary>
		/// 시간외매수잔량
		/// </summary>
		[XAQueryFieldAttribute("시간외매수잔량")]
		public long tmbid;
		/// <summary>
		/// 동시구분
		/// </summary>
		[XAQueryFieldAttribute("동시구분")]
		public char ho_status;
		/// <summary>
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("단축코드")]
		public string shcode;
		/// <summary>
		/// 상한가
		/// </summary>
		[XAQueryFieldAttribute("상한가")]
		public long uplmtprice;
		/// <summary>
		/// 하한가
		/// </summary>
		[XAQueryFieldAttribute("하한가")]
		public long dnlmtprice;
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
			/// LP매도호가수량1
			/// </summary>
			public const string lp_offerrem1 = "lp_offerrem1";
			/// <summary>
			/// LP매수호가수량1
			/// </summary>
			public const string lp_bidrem1 = "lp_bidrem1";
			/// <summary>
			/// LP매도호가수량2
			/// </summary>
			public const string lp_offerrem2 = "lp_offerrem2";
			/// <summary>
			/// LP매수호가수량2
			/// </summary>
			public const string lp_bidrem2 = "lp_bidrem2";
			/// <summary>
			/// LP매도호가수량3
			/// </summary>
			public const string lp_offerrem3 = "lp_offerrem3";
			/// <summary>
			/// LP매수호가수량3
			/// </summary>
			public const string lp_bidrem3 = "lp_bidrem3";
			/// <summary>
			/// LP매도호가수량4
			/// </summary>
			public const string lp_offerrem4 = "lp_offerrem4";
			/// <summary>
			/// LP매수호가수량4
			/// </summary>
			public const string lp_bidrem4 = "lp_bidrem4";
			/// <summary>
			/// LP매도호가수량5
			/// </summary>
			public const string lp_offerrem5 = "lp_offerrem5";
			/// <summary>
			/// LP매수호가수량5
			/// </summary>
			public const string lp_bidrem5 = "lp_bidrem5";
			/// <summary>
			/// LP매도호가수량6
			/// </summary>
			public const string lp_offerrem6 = "lp_offerrem6";
			/// <summary>
			/// LP매수호가수량6
			/// </summary>
			public const string lp_bidrem6 = "lp_bidrem6";
			/// <summary>
			/// LP매도호가수량7
			/// </summary>
			public const string lp_offerrem7 = "lp_offerrem7";
			/// <summary>
			/// LP매수호가수량7
			/// </summary>
			public const string lp_bidrem7 = "lp_bidrem7";
			/// <summary>
			/// LP매도호가수량8
			/// </summary>
			public const string lp_offerrem8 = "lp_offerrem8";
			/// <summary>
			/// LP매수호가수량8
			/// </summary>
			public const string lp_bidrem8 = "lp_bidrem8";
			/// <summary>
			/// LP매도호가수량9
			/// </summary>
			public const string lp_offerrem9 = "lp_offerrem9";
			/// <summary>
			/// LP매수호가수량9
			/// </summary>
			public const string lp_bidrem9 = "lp_bidrem9";
			/// <summary>
			/// LP매도호가수량10
			/// </summary>
			public const string lp_offerrem10 = "lp_offerrem10";
			/// <summary>
			/// LP매수호가수량10
			/// </summary>
			public const string lp_bidrem10 = "lp_bidrem10";
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
			/// 직전매도대비수량1
			/// </summary>
			public const string preoffercha1 = "preoffercha1";
			/// <summary>
			/// 직전매수대비수량1
			/// </summary>
			public const string prebidcha1 = "prebidcha1";
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
			/// 직전매도대비수량2
			/// </summary>
			public const string preoffercha2 = "preoffercha2";
			/// <summary>
			/// 직전매수대비수량2
			/// </summary>
			public const string prebidcha2 = "prebidcha2";
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
			/// 직전매도대비수량3
			/// </summary>
			public const string preoffercha3 = "preoffercha3";
			/// <summary>
			/// 직전매수대비수량3
			/// </summary>
			public const string prebidcha3 = "prebidcha3";
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
			/// 직전매도대비수량4
			/// </summary>
			public const string preoffercha4 = "preoffercha4";
			/// <summary>
			/// 직전매수대비수량4
			/// </summary>
			public const string prebidcha4 = "prebidcha4";
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
			/// 직전매도대비수량5
			/// </summary>
			public const string preoffercha5 = "preoffercha5";
			/// <summary>
			/// 직전매수대비수량5
			/// </summary>
			public const string prebidcha5 = "prebidcha5";
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
			/// 직전매도대비수량6
			/// </summary>
			public const string preoffercha6 = "preoffercha6";
			/// <summary>
			/// 직전매수대비수량6
			/// </summary>
			public const string prebidcha6 = "prebidcha6";
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
			/// 직전매도대비수량7
			/// </summary>
			public const string preoffercha7 = "preoffercha7";
			/// <summary>
			/// 직전매수대비수량7
			/// </summary>
			public const string prebidcha7 = "prebidcha7";
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
			/// 직전매도대비수량8
			/// </summary>
			public const string preoffercha8 = "preoffercha8";
			/// <summary>
			/// 직전매수대비수량8
			/// </summary>
			public const string prebidcha8 = "prebidcha8";
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
			/// 직전매도대비수량9
			/// </summary>
			public const string preoffercha9 = "preoffercha9";
			/// <summary>
			/// 직전매수대비수량9
			/// </summary>
			public const string prebidcha9 = "prebidcha9";
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
			/// 직전매도대비수량10
			/// </summary>
			public const string preoffercha10 = "preoffercha10";
			/// <summary>
			/// 직전매수대비수량10
			/// </summary>
			public const string prebidcha10 = "prebidcha10";
			/// <summary>
			/// 매도호가수량합
			/// </summary>
			public const string offer = "offer";
			/// <summary>
			/// 매수호가수량합
			/// </summary>
			public const string bid = "bid";
			/// <summary>
			/// 직전매도대비수량합
			/// </summary>
			public const string preoffercha = "preoffercha";
			/// <summary>
			/// 직전매수대비수량합
			/// </summary>
			public const string prebidcha = "prebidcha";
			/// <summary>
			/// 수신시간
			/// </summary>
			public const string hotime = "hotime";
			/// <summary>
			/// 예상체결가격
			/// </summary>
			public const string yeprice = "yeprice";
			/// <summary>
			/// 예상체결수량
			/// </summary>
			public const string yevolume = "yevolume";
			/// <summary>
			/// 예상체결전일구분
			/// </summary>
			public const string yesign = "yesign";
			/// <summary>
			/// 예상체결전일대비
			/// </summary>
			public const string yechange = "yechange";
			/// <summary>
			/// 예상체결등락율
			/// </summary>
			public const string yediff = "yediff";
			/// <summary>
			/// 시간외매도잔량
			/// </summary>
			public const string tmoffer = "tmoffer";
			/// <summary>
			/// 시간외매수잔량
			/// </summary>
			public const string tmbid = "tmbid";
			/// <summary>
			/// 동시구분
			/// </summary>
			public const string ho_status = "ho_status";
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 상한가
			/// </summary>
			public const string uplmtprice = "uplmtprice";
			/// <summary>
			/// 하한가
			/// </summary>
			public const string dnlmtprice = "dnlmtprice";
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
		}

		public static string[] AllFields = new string[]
		{
			F.hname,
			F.price,
			F.sign,
			F.change,
			F.diff,
			F.volume,
			F.lp_offerrem1,
			F.lp_bidrem1,
			F.lp_offerrem2,
			F.lp_bidrem2,
			F.lp_offerrem3,
			F.lp_bidrem3,
			F.lp_offerrem4,
			F.lp_bidrem4,
			F.lp_offerrem5,
			F.lp_bidrem5,
			F.lp_offerrem6,
			F.lp_bidrem6,
			F.lp_offerrem7,
			F.lp_bidrem7,
			F.lp_offerrem8,
			F.lp_bidrem8,
			F.lp_offerrem9,
			F.lp_bidrem9,
			F.lp_offerrem10,
			F.lp_bidrem10,
			F.jnilclose,
			F.offerho1,
			F.bidho1,
			F.offerrem1,
			F.bidrem1,
			F.preoffercha1,
			F.prebidcha1,
			F.offerho2,
			F.bidho2,
			F.offerrem2,
			F.bidrem2,
			F.preoffercha2,
			F.prebidcha2,
			F.offerho3,
			F.bidho3,
			F.offerrem3,
			F.bidrem3,
			F.preoffercha3,
			F.prebidcha3,
			F.offerho4,
			F.bidho4,
			F.offerrem4,
			F.bidrem4,
			F.preoffercha4,
			F.prebidcha4,
			F.offerho5,
			F.bidho5,
			F.offerrem5,
			F.bidrem5,
			F.preoffercha5,
			F.prebidcha5,
			F.offerho6,
			F.bidho6,
			F.offerrem6,
			F.bidrem6,
			F.preoffercha6,
			F.prebidcha6,
			F.offerho7,
			F.bidho7,
			F.offerrem7,
			F.bidrem7,
			F.preoffercha7,
			F.prebidcha7,
			F.offerho8,
			F.bidho8,
			F.offerrem8,
			F.bidrem8,
			F.preoffercha8,
			F.prebidcha8,
			F.offerho9,
			F.bidho9,
			F.offerrem9,
			F.bidrem9,
			F.preoffercha9,
			F.prebidcha9,
			F.offerho10,
			F.bidho10,
			F.offerrem10,
			F.bidrem10,
			F.preoffercha10,
			F.prebidcha10,
			F.offer,
			F.bid,
			F.preoffercha,
			F.prebidcha,
			F.hotime,
			F.yeprice,
			F.yevolume,
			F.yesign,
			F.yechange,
			F.yediff,
			F.tmoffer,
			F.tmbid,
			F.ho_status,
			F.shcode,
			F.uplmtprice,
			F.dnlmtprice,
			F.open,
			F.high,
			F.low,
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
			dict["lp_offerrem1"] = new XAQueryFieldInfo("long", lp_offerrem1, lp_offerrem1.ToString("d12"), "LP매도호가수량1", (decimal)12);
			dict["lp_bidrem1"] = new XAQueryFieldInfo("long", lp_bidrem1, lp_bidrem1.ToString("d12"), "LP매수호가수량1", (decimal)12);
			dict["lp_offerrem2"] = new XAQueryFieldInfo("long", lp_offerrem2, lp_offerrem2.ToString("d12"), "LP매도호가수량2", (decimal)12);
			dict["lp_bidrem2"] = new XAQueryFieldInfo("long", lp_bidrem2, lp_bidrem2.ToString("d12"), "LP매수호가수량2", (decimal)12);
			dict["lp_offerrem3"] = new XAQueryFieldInfo("long", lp_offerrem3, lp_offerrem3.ToString("d12"), "LP매도호가수량3", (decimal)12);
			dict["lp_bidrem3"] = new XAQueryFieldInfo("long", lp_bidrem3, lp_bidrem3.ToString("d12"), "LP매수호가수량3", (decimal)12);
			dict["lp_offerrem4"] = new XAQueryFieldInfo("long", lp_offerrem4, lp_offerrem4.ToString("d12"), "LP매도호가수량4", (decimal)12);
			dict["lp_bidrem4"] = new XAQueryFieldInfo("long", lp_bidrem4, lp_bidrem4.ToString("d12"), "LP매수호가수량4", (decimal)12);
			dict["lp_offerrem5"] = new XAQueryFieldInfo("long", lp_offerrem5, lp_offerrem5.ToString("d12"), "LP매도호가수량5", (decimal)12);
			dict["lp_bidrem5"] = new XAQueryFieldInfo("long", lp_bidrem5, lp_bidrem5.ToString("d12"), "LP매수호가수량5", (decimal)12);
			dict["lp_offerrem6"] = new XAQueryFieldInfo("long", lp_offerrem6, lp_offerrem6.ToString("d12"), "LP매도호가수량6", (decimal)12);
			dict["lp_bidrem6"] = new XAQueryFieldInfo("long", lp_bidrem6, lp_bidrem6.ToString("d12"), "LP매수호가수량6", (decimal)12);
			dict["lp_offerrem7"] = new XAQueryFieldInfo("long", lp_offerrem7, lp_offerrem7.ToString("d12"), "LP매도호가수량7", (decimal)12);
			dict["lp_bidrem7"] = new XAQueryFieldInfo("long", lp_bidrem7, lp_bidrem7.ToString("d12"), "LP매수호가수량7", (decimal)12);
			dict["lp_offerrem8"] = new XAQueryFieldInfo("long", lp_offerrem8, lp_offerrem8.ToString("d12"), "LP매도호가수량8", (decimal)12);
			dict["lp_bidrem8"] = new XAQueryFieldInfo("long", lp_bidrem8, lp_bidrem8.ToString("d12"), "LP매수호가수량8", (decimal)12);
			dict["lp_offerrem9"] = new XAQueryFieldInfo("long", lp_offerrem9, lp_offerrem9.ToString("d12"), "LP매도호가수량9", (decimal)12);
			dict["lp_bidrem9"] = new XAQueryFieldInfo("long", lp_bidrem9, lp_bidrem9.ToString("d12"), "LP매수호가수량9", (decimal)12);
			dict["lp_offerrem10"] = new XAQueryFieldInfo("long", lp_offerrem10, lp_offerrem10.ToString("d12"), "LP매도호가수량10", (decimal)12);
			dict["lp_bidrem10"] = new XAQueryFieldInfo("long", lp_bidrem10, lp_bidrem10.ToString("d12"), "LP매수호가수량10", (decimal)12);
			dict["jnilclose"] = new XAQueryFieldInfo("long", jnilclose, jnilclose.ToString("d8"), "전일종가", (decimal)8);
			dict["offerho1"] = new XAQueryFieldInfo("long", offerho1, offerho1.ToString("d8"), "매도호가1", (decimal)8);
			dict["bidho1"] = new XAQueryFieldInfo("long", bidho1, bidho1.ToString("d8"), "매수호가1", (decimal)8);
			dict["offerrem1"] = new XAQueryFieldInfo("long", offerrem1, offerrem1.ToString("d12"), "매도호가수량1", (decimal)12);
			dict["bidrem1"] = new XAQueryFieldInfo("long", bidrem1, bidrem1.ToString("d12"), "매수호가수량1", (decimal)12);
			dict["preoffercha1"] = new XAQueryFieldInfo("long", preoffercha1, preoffercha1.ToString("d12"), "직전매도대비수량1", (decimal)12);
			dict["prebidcha1"] = new XAQueryFieldInfo("long", prebidcha1, prebidcha1.ToString("d12"), "직전매수대비수량1", (decimal)12);
			dict["offerho2"] = new XAQueryFieldInfo("long", offerho2, offerho2.ToString("d8"), "매도호가2", (decimal)8);
			dict["bidho2"] = new XAQueryFieldInfo("long", bidho2, bidho2.ToString("d8"), "매수호가2", (decimal)8);
			dict["offerrem2"] = new XAQueryFieldInfo("long", offerrem2, offerrem2.ToString("d12"), "매도호가수량2", (decimal)12);
			dict["bidrem2"] = new XAQueryFieldInfo("long", bidrem2, bidrem2.ToString("d12"), "매수호가수량2", (decimal)12);
			dict["preoffercha2"] = new XAQueryFieldInfo("long", preoffercha2, preoffercha2.ToString("d12"), "직전매도대비수량2", (decimal)12);
			dict["prebidcha2"] = new XAQueryFieldInfo("long", prebidcha2, prebidcha2.ToString("d12"), "직전매수대비수량2", (decimal)12);
			dict["offerho3"] = new XAQueryFieldInfo("long", offerho3, offerho3.ToString("d8"), "매도호가3", (decimal)8);
			dict["bidho3"] = new XAQueryFieldInfo("long", bidho3, bidho3.ToString("d8"), "매수호가3", (decimal)8);
			dict["offerrem3"] = new XAQueryFieldInfo("long", offerrem3, offerrem3.ToString("d12"), "매도호가수량3", (decimal)12);
			dict["bidrem3"] = new XAQueryFieldInfo("long", bidrem3, bidrem3.ToString("d12"), "매수호가수량3", (decimal)12);
			dict["preoffercha3"] = new XAQueryFieldInfo("long", preoffercha3, preoffercha3.ToString("d12"), "직전매도대비수량3", (decimal)12);
			dict["prebidcha3"] = new XAQueryFieldInfo("long", prebidcha3, prebidcha3.ToString("d12"), "직전매수대비수량3", (decimal)12);
			dict["offerho4"] = new XAQueryFieldInfo("long", offerho4, offerho4.ToString("d8"), "매도호가4", (decimal)8);
			dict["bidho4"] = new XAQueryFieldInfo("long", bidho4, bidho4.ToString("d8"), "매수호가4", (decimal)8);
			dict["offerrem4"] = new XAQueryFieldInfo("long", offerrem4, offerrem4.ToString("d12"), "매도호가수량4", (decimal)12);
			dict["bidrem4"] = new XAQueryFieldInfo("long", bidrem4, bidrem4.ToString("d12"), "매수호가수량4", (decimal)12);
			dict["preoffercha4"] = new XAQueryFieldInfo("long", preoffercha4, preoffercha4.ToString("d12"), "직전매도대비수량4", (decimal)12);
			dict["prebidcha4"] = new XAQueryFieldInfo("long", prebidcha4, prebidcha4.ToString("d12"), "직전매수대비수량4", (decimal)12);
			dict["offerho5"] = new XAQueryFieldInfo("long", offerho5, offerho5.ToString("d8"), "매도호가5", (decimal)8);
			dict["bidho5"] = new XAQueryFieldInfo("long", bidho5, bidho5.ToString("d8"), "매수호가5", (decimal)8);
			dict["offerrem5"] = new XAQueryFieldInfo("long", offerrem5, offerrem5.ToString("d12"), "매도호가수량5", (decimal)12);
			dict["bidrem5"] = new XAQueryFieldInfo("long", bidrem5, bidrem5.ToString("d12"), "매수호가수량5", (decimal)12);
			dict["preoffercha5"] = new XAQueryFieldInfo("long", preoffercha5, preoffercha5.ToString("d12"), "직전매도대비수량5", (decimal)12);
			dict["prebidcha5"] = new XAQueryFieldInfo("long", prebidcha5, prebidcha5.ToString("d12"), "직전매수대비수량5", (decimal)12);
			dict["offerho6"] = new XAQueryFieldInfo("long", offerho6, offerho6.ToString("d8"), "매도호가6", (decimal)8);
			dict["bidho6"] = new XAQueryFieldInfo("long", bidho6, bidho6.ToString("d8"), "매수호가6", (decimal)8);
			dict["offerrem6"] = new XAQueryFieldInfo("long", offerrem6, offerrem6.ToString("d12"), "매도호가수량6", (decimal)12);
			dict["bidrem6"] = new XAQueryFieldInfo("long", bidrem6, bidrem6.ToString("d12"), "매수호가수량6", (decimal)12);
			dict["preoffercha6"] = new XAQueryFieldInfo("long", preoffercha6, preoffercha6.ToString("d12"), "직전매도대비수량6", (decimal)12);
			dict["prebidcha6"] = new XAQueryFieldInfo("long", prebidcha6, prebidcha6.ToString("d12"), "직전매수대비수량6", (decimal)12);
			dict["offerho7"] = new XAQueryFieldInfo("long", offerho7, offerho7.ToString("d8"), "매도호가7", (decimal)8);
			dict["bidho7"] = new XAQueryFieldInfo("long", bidho7, bidho7.ToString("d8"), "매수호가7", (decimal)8);
			dict["offerrem7"] = new XAQueryFieldInfo("long", offerrem7, offerrem7.ToString("d12"), "매도호가수량7", (decimal)12);
			dict["bidrem7"] = new XAQueryFieldInfo("long", bidrem7, bidrem7.ToString("d12"), "매수호가수량7", (decimal)12);
			dict["preoffercha7"] = new XAQueryFieldInfo("long", preoffercha7, preoffercha7.ToString("d12"), "직전매도대비수량7", (decimal)12);
			dict["prebidcha7"] = new XAQueryFieldInfo("long", prebidcha7, prebidcha7.ToString("d12"), "직전매수대비수량7", (decimal)12);
			dict["offerho8"] = new XAQueryFieldInfo("long", offerho8, offerho8.ToString("d8"), "매도호가8", (decimal)8);
			dict["bidho8"] = new XAQueryFieldInfo("long", bidho8, bidho8.ToString("d8"), "매수호가8", (decimal)8);
			dict["offerrem8"] = new XAQueryFieldInfo("long", offerrem8, offerrem8.ToString("d12"), "매도호가수량8", (decimal)12);
			dict["bidrem8"] = new XAQueryFieldInfo("long", bidrem8, bidrem8.ToString("d12"), "매수호가수량8", (decimal)12);
			dict["preoffercha8"] = new XAQueryFieldInfo("long", preoffercha8, preoffercha8.ToString("d12"), "직전매도대비수량8", (decimal)12);
			dict["prebidcha8"] = new XAQueryFieldInfo("long", prebidcha8, prebidcha8.ToString("d12"), "직전매수대비수량8", (decimal)12);
			dict["offerho9"] = new XAQueryFieldInfo("long", offerho9, offerho9.ToString("d8"), "매도호가9", (decimal)8);
			dict["bidho9"] = new XAQueryFieldInfo("long", bidho9, bidho9.ToString("d8"), "매수호가9", (decimal)8);
			dict["offerrem9"] = new XAQueryFieldInfo("long", offerrem9, offerrem9.ToString("d12"), "매도호가수량9", (decimal)12);
			dict["bidrem9"] = new XAQueryFieldInfo("long", bidrem9, bidrem9.ToString("d12"), "매수호가수량9", (decimal)12);
			dict["preoffercha9"] = new XAQueryFieldInfo("long", preoffercha9, preoffercha9.ToString("d12"), "직전매도대비수량9", (decimal)12);
			dict["prebidcha9"] = new XAQueryFieldInfo("long", prebidcha9, prebidcha9.ToString("d12"), "직전매수대비수량9", (decimal)12);
			dict["offerho10"] = new XAQueryFieldInfo("long", offerho10, offerho10.ToString("d8"), "매도호가10", (decimal)8);
			dict["bidho10"] = new XAQueryFieldInfo("long", bidho10, bidho10.ToString("d8"), "매수호가10", (decimal)8);
			dict["offerrem10"] = new XAQueryFieldInfo("long", offerrem10, offerrem10.ToString("d12"), "매도호가수량10", (decimal)12);
			dict["bidrem10"] = new XAQueryFieldInfo("long", bidrem10, bidrem10.ToString("d12"), "매수호가수량10", (decimal)12);
			dict["preoffercha10"] = new XAQueryFieldInfo("long", preoffercha10, preoffercha10.ToString("d12"), "직전매도대비수량10", (decimal)12);
			dict["prebidcha10"] = new XAQueryFieldInfo("long", prebidcha10, prebidcha10.ToString("d12"), "직전매수대비수량10", (decimal)12);
			dict["offer"] = new XAQueryFieldInfo("long", offer, offer.ToString("d12"), "매도호가수량합", (decimal)12);
			dict["bid"] = new XAQueryFieldInfo("long", bid, bid.ToString("d12"), "매수호가수량합", (decimal)12);
			dict["preoffercha"] = new XAQueryFieldInfo("long", preoffercha, preoffercha.ToString("d12"), "직전매도대비수량합", (decimal)12);
			dict["prebidcha"] = new XAQueryFieldInfo("long", prebidcha, prebidcha.ToString("d12"), "직전매수대비수량합", (decimal)12);
			dict["hotime"] = new XAQueryFieldInfo("char", hotime, hotime, "수신시간", (decimal)8);
			dict["yeprice"] = new XAQueryFieldInfo("long", yeprice, yeprice.ToString("d8"), "예상체결가격", (decimal)8);
			dict["yevolume"] = new XAQueryFieldInfo("long", yevolume, yevolume.ToString("d12"), "예상체결수량", (decimal)12);
			dict["yesign"] = new XAQueryFieldInfo("char", yesign, yesign.ToString(), "예상체결전일구분", (decimal)1);
			dict["yechange"] = new XAQueryFieldInfo("long", yechange, yechange.ToString("d8"), "예상체결전일대비", (decimal)8);
			dict["yediff"] = new XAQueryFieldInfo("float", yediff, yediff.ToString("000000.00"), "예상체결등락율", (decimal)6.2);
			dict["tmoffer"] = new XAQueryFieldInfo("long", tmoffer, tmoffer.ToString("d12"), "시간외매도잔량", (decimal)12);
			dict["tmbid"] = new XAQueryFieldInfo("long", tmbid, tmbid.ToString("d12"), "시간외매수잔량", (decimal)12);
			dict["ho_status"] = new XAQueryFieldInfo("char", ho_status, ho_status.ToString(), "동시구분", (decimal)1);
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)6);
			dict["uplmtprice"] = new XAQueryFieldInfo("long", uplmtprice, uplmtprice.ToString("d8"), "상한가", (decimal)8);
			dict["dnlmtprice"] = new XAQueryFieldInfo("long", dnlmtprice, dnlmtprice.ToString("d8"), "하한가", (decimal)8);
			dict["open"] = new XAQueryFieldInfo("long", open, open.ToString("d8"), "시가", (decimal)8);
			dict["high"] = new XAQueryFieldInfo("long", high, high.ToString("d8"), "고가", (decimal)8);
			dict["low"] = new XAQueryFieldInfo("long", low, low.ToString("d8"), "저가", (decimal)8);

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

				case "lp_offerrem1":
					this.lp_offerrem1 = fieldInfo.FieldValue.ParseLong("lp_offerrem1");
				break;

				case "lp_bidrem1":
					this.lp_bidrem1 = fieldInfo.FieldValue.ParseLong("lp_bidrem1");
				break;

				case "lp_offerrem2":
					this.lp_offerrem2 = fieldInfo.FieldValue.ParseLong("lp_offerrem2");
				break;

				case "lp_bidrem2":
					this.lp_bidrem2 = fieldInfo.FieldValue.ParseLong("lp_bidrem2");
				break;

				case "lp_offerrem3":
					this.lp_offerrem3 = fieldInfo.FieldValue.ParseLong("lp_offerrem3");
				break;

				case "lp_bidrem3":
					this.lp_bidrem3 = fieldInfo.FieldValue.ParseLong("lp_bidrem3");
				break;

				case "lp_offerrem4":
					this.lp_offerrem4 = fieldInfo.FieldValue.ParseLong("lp_offerrem4");
				break;

				case "lp_bidrem4":
					this.lp_bidrem4 = fieldInfo.FieldValue.ParseLong("lp_bidrem4");
				break;

				case "lp_offerrem5":
					this.lp_offerrem5 = fieldInfo.FieldValue.ParseLong("lp_offerrem5");
				break;

				case "lp_bidrem5":
					this.lp_bidrem5 = fieldInfo.FieldValue.ParseLong("lp_bidrem5");
				break;

				case "lp_offerrem6":
					this.lp_offerrem6 = fieldInfo.FieldValue.ParseLong("lp_offerrem6");
				break;

				case "lp_bidrem6":
					this.lp_bidrem6 = fieldInfo.FieldValue.ParseLong("lp_bidrem6");
				break;

				case "lp_offerrem7":
					this.lp_offerrem7 = fieldInfo.FieldValue.ParseLong("lp_offerrem7");
				break;

				case "lp_bidrem7":
					this.lp_bidrem7 = fieldInfo.FieldValue.ParseLong("lp_bidrem7");
				break;

				case "lp_offerrem8":
					this.lp_offerrem8 = fieldInfo.FieldValue.ParseLong("lp_offerrem8");
				break;

				case "lp_bidrem8":
					this.lp_bidrem8 = fieldInfo.FieldValue.ParseLong("lp_bidrem8");
				break;

				case "lp_offerrem9":
					this.lp_offerrem9 = fieldInfo.FieldValue.ParseLong("lp_offerrem9");
				break;

				case "lp_bidrem9":
					this.lp_bidrem9 = fieldInfo.FieldValue.ParseLong("lp_bidrem9");
				break;

				case "lp_offerrem10":
					this.lp_offerrem10 = fieldInfo.FieldValue.ParseLong("lp_offerrem10");
				break;

				case "lp_bidrem10":
					this.lp_bidrem10 = fieldInfo.FieldValue.ParseLong("lp_bidrem10");
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

				case "preoffercha1":
					this.preoffercha1 = fieldInfo.FieldValue.ParseLong("preoffercha1");
				break;

				case "prebidcha1":
					this.prebidcha1 = fieldInfo.FieldValue.ParseLong("prebidcha1");
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

				case "preoffercha2":
					this.preoffercha2 = fieldInfo.FieldValue.ParseLong("preoffercha2");
				break;

				case "prebidcha2":
					this.prebidcha2 = fieldInfo.FieldValue.ParseLong("prebidcha2");
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

				case "preoffercha3":
					this.preoffercha3 = fieldInfo.FieldValue.ParseLong("preoffercha3");
				break;

				case "prebidcha3":
					this.prebidcha3 = fieldInfo.FieldValue.ParseLong("prebidcha3");
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

				case "preoffercha4":
					this.preoffercha4 = fieldInfo.FieldValue.ParseLong("preoffercha4");
				break;

				case "prebidcha4":
					this.prebidcha4 = fieldInfo.FieldValue.ParseLong("prebidcha4");
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

				case "preoffercha5":
					this.preoffercha5 = fieldInfo.FieldValue.ParseLong("preoffercha5");
				break;

				case "prebidcha5":
					this.prebidcha5 = fieldInfo.FieldValue.ParseLong("prebidcha5");
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

				case "preoffercha6":
					this.preoffercha6 = fieldInfo.FieldValue.ParseLong("preoffercha6");
				break;

				case "prebidcha6":
					this.prebidcha6 = fieldInfo.FieldValue.ParseLong("prebidcha6");
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

				case "preoffercha7":
					this.preoffercha7 = fieldInfo.FieldValue.ParseLong("preoffercha7");
				break;

				case "prebidcha7":
					this.prebidcha7 = fieldInfo.FieldValue.ParseLong("prebidcha7");
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

				case "preoffercha8":
					this.preoffercha8 = fieldInfo.FieldValue.ParseLong("preoffercha8");
				break;

				case "prebidcha8":
					this.prebidcha8 = fieldInfo.FieldValue.ParseLong("prebidcha8");
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

				case "preoffercha9":
					this.preoffercha9 = fieldInfo.FieldValue.ParseLong("preoffercha9");
				break;

				case "prebidcha9":
					this.prebidcha9 = fieldInfo.FieldValue.ParseLong("prebidcha9");
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

				case "preoffercha10":
					this.preoffercha10 = fieldInfo.FieldValue.ParseLong("preoffercha10");
				break;

				case "prebidcha10":
					this.prebidcha10 = fieldInfo.FieldValue.ParseLong("prebidcha10");
				break;

				case "offer":
					this.offer = fieldInfo.FieldValue.ParseLong("offer");
				break;

				case "bid":
					this.bid = fieldInfo.FieldValue.ParseLong("bid");
				break;

				case "preoffercha":
					this.preoffercha = fieldInfo.FieldValue.ParseLong("preoffercha");
				break;

				case "prebidcha":
					this.prebidcha = fieldInfo.FieldValue.ParseLong("prebidcha");
				break;

				case "hotime":
					this.hotime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "yeprice":
					this.yeprice = fieldInfo.FieldValue.ParseLong("yeprice");
				break;

				case "yevolume":
					this.yevolume = fieldInfo.FieldValue.ParseLong("yevolume");
				break;

				case "yesign":
					this.yesign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "yechange":
					this.yechange = fieldInfo.FieldValue.ParseLong("yechange");
				break;

				case "yediff":
					this.yediff = fieldInfo.FieldValue.ParseFloat("yediff");
				break;

				case "tmoffer":
					this.tmoffer = fieldInfo.FieldValue.ParseLong("tmoffer");
				break;

				case "tmbid":
					this.tmbid = fieldInfo.FieldValue.ParseLong("tmbid");
				break;

				case "ho_status":
					this.ho_status = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "uplmtprice":
					this.uplmtprice = fieldInfo.FieldValue.ParseLong("uplmtprice");
				break;

				case "dnlmtprice":
					this.dnlmtprice = fieldInfo.FieldValue.ParseLong("dnlmtprice");
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


			}
		}

		public static XQt1906OutBlock FromQuery(XQt1906 query)
		{
			XQt1906OutBlock block = new XQt1906OutBlock();
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
				block.lp_offerrem1 = query.GetFieldData(block.GetBlockName(), "lp_offerrem1", 0).ParseLong("lp_offerrem1"); // long 12
				block.lp_bidrem1 = query.GetFieldData(block.GetBlockName(), "lp_bidrem1", 0).ParseLong("lp_bidrem1"); // long 12
				block.lp_offerrem2 = query.GetFieldData(block.GetBlockName(), "lp_offerrem2", 0).ParseLong("lp_offerrem2"); // long 12
				block.lp_bidrem2 = query.GetFieldData(block.GetBlockName(), "lp_bidrem2", 0).ParseLong("lp_bidrem2"); // long 12
				block.lp_offerrem3 = query.GetFieldData(block.GetBlockName(), "lp_offerrem3", 0).ParseLong("lp_offerrem3"); // long 12
				block.lp_bidrem3 = query.GetFieldData(block.GetBlockName(), "lp_bidrem3", 0).ParseLong("lp_bidrem3"); // long 12
				block.lp_offerrem4 = query.GetFieldData(block.GetBlockName(), "lp_offerrem4", 0).ParseLong("lp_offerrem4"); // long 12
				block.lp_bidrem4 = query.GetFieldData(block.GetBlockName(), "lp_bidrem4", 0).ParseLong("lp_bidrem4"); // long 12
				block.lp_offerrem5 = query.GetFieldData(block.GetBlockName(), "lp_offerrem5", 0).ParseLong("lp_offerrem5"); // long 12
				block.lp_bidrem5 = query.GetFieldData(block.GetBlockName(), "lp_bidrem5", 0).ParseLong("lp_bidrem5"); // long 12
				block.lp_offerrem6 = query.GetFieldData(block.GetBlockName(), "lp_offerrem6", 0).ParseLong("lp_offerrem6"); // long 12
				block.lp_bidrem6 = query.GetFieldData(block.GetBlockName(), "lp_bidrem6", 0).ParseLong("lp_bidrem6"); // long 12
				block.lp_offerrem7 = query.GetFieldData(block.GetBlockName(), "lp_offerrem7", 0).ParseLong("lp_offerrem7"); // long 12
				block.lp_bidrem7 = query.GetFieldData(block.GetBlockName(), "lp_bidrem7", 0).ParseLong("lp_bidrem7"); // long 12
				block.lp_offerrem8 = query.GetFieldData(block.GetBlockName(), "lp_offerrem8", 0).ParseLong("lp_offerrem8"); // long 12
				block.lp_bidrem8 = query.GetFieldData(block.GetBlockName(), "lp_bidrem8", 0).ParseLong("lp_bidrem8"); // long 12
				block.lp_offerrem9 = query.GetFieldData(block.GetBlockName(), "lp_offerrem9", 0).ParseLong("lp_offerrem9"); // long 12
				block.lp_bidrem9 = query.GetFieldData(block.GetBlockName(), "lp_bidrem9", 0).ParseLong("lp_bidrem9"); // long 12
				block.lp_offerrem10 = query.GetFieldData(block.GetBlockName(), "lp_offerrem10", 0).ParseLong("lp_offerrem10"); // long 12
				block.lp_bidrem10 = query.GetFieldData(block.GetBlockName(), "lp_bidrem10", 0).ParseLong("lp_bidrem10"); // long 12
				block.jnilclose = query.GetFieldData(block.GetBlockName(), "jnilclose", 0).ParseLong("jnilclose"); // long 8
				block.offerho1 = query.GetFieldData(block.GetBlockName(), "offerho1", 0).ParseLong("offerho1"); // long 8
				block.bidho1 = query.GetFieldData(block.GetBlockName(), "bidho1", 0).ParseLong("bidho1"); // long 8
				block.offerrem1 = query.GetFieldData(block.GetBlockName(), "offerrem1", 0).ParseLong("offerrem1"); // long 12
				block.bidrem1 = query.GetFieldData(block.GetBlockName(), "bidrem1", 0).ParseLong("bidrem1"); // long 12
				block.preoffercha1 = query.GetFieldData(block.GetBlockName(), "preoffercha1", 0).ParseLong("preoffercha1"); // long 12
				block.prebidcha1 = query.GetFieldData(block.GetBlockName(), "prebidcha1", 0).ParseLong("prebidcha1"); // long 12
				block.offerho2 = query.GetFieldData(block.GetBlockName(), "offerho2", 0).ParseLong("offerho2"); // long 8
				block.bidho2 = query.GetFieldData(block.GetBlockName(), "bidho2", 0).ParseLong("bidho2"); // long 8
				block.offerrem2 = query.GetFieldData(block.GetBlockName(), "offerrem2", 0).ParseLong("offerrem2"); // long 12
				block.bidrem2 = query.GetFieldData(block.GetBlockName(), "bidrem2", 0).ParseLong("bidrem2"); // long 12
				block.preoffercha2 = query.GetFieldData(block.GetBlockName(), "preoffercha2", 0).ParseLong("preoffercha2"); // long 12
				block.prebidcha2 = query.GetFieldData(block.GetBlockName(), "prebidcha2", 0).ParseLong("prebidcha2"); // long 12
				block.offerho3 = query.GetFieldData(block.GetBlockName(), "offerho3", 0).ParseLong("offerho3"); // long 8
				block.bidho3 = query.GetFieldData(block.GetBlockName(), "bidho3", 0).ParseLong("bidho3"); // long 8
				block.offerrem3 = query.GetFieldData(block.GetBlockName(), "offerrem3", 0).ParseLong("offerrem3"); // long 12
				block.bidrem3 = query.GetFieldData(block.GetBlockName(), "bidrem3", 0).ParseLong("bidrem3"); // long 12
				block.preoffercha3 = query.GetFieldData(block.GetBlockName(), "preoffercha3", 0).ParseLong("preoffercha3"); // long 12
				block.prebidcha3 = query.GetFieldData(block.GetBlockName(), "prebidcha3", 0).ParseLong("prebidcha3"); // long 12
				block.offerho4 = query.GetFieldData(block.GetBlockName(), "offerho4", 0).ParseLong("offerho4"); // long 8
				block.bidho4 = query.GetFieldData(block.GetBlockName(), "bidho4", 0).ParseLong("bidho4"); // long 8
				block.offerrem4 = query.GetFieldData(block.GetBlockName(), "offerrem4", 0).ParseLong("offerrem4"); // long 12
				block.bidrem4 = query.GetFieldData(block.GetBlockName(), "bidrem4", 0).ParseLong("bidrem4"); // long 12
				block.preoffercha4 = query.GetFieldData(block.GetBlockName(), "preoffercha4", 0).ParseLong("preoffercha4"); // long 12
				block.prebidcha4 = query.GetFieldData(block.GetBlockName(), "prebidcha4", 0).ParseLong("prebidcha4"); // long 12
				block.offerho5 = query.GetFieldData(block.GetBlockName(), "offerho5", 0).ParseLong("offerho5"); // long 8
				block.bidho5 = query.GetFieldData(block.GetBlockName(), "bidho5", 0).ParseLong("bidho5"); // long 8
				block.offerrem5 = query.GetFieldData(block.GetBlockName(), "offerrem5", 0).ParseLong("offerrem5"); // long 12
				block.bidrem5 = query.GetFieldData(block.GetBlockName(), "bidrem5", 0).ParseLong("bidrem5"); // long 12
				block.preoffercha5 = query.GetFieldData(block.GetBlockName(), "preoffercha5", 0).ParseLong("preoffercha5"); // long 12
				block.prebidcha5 = query.GetFieldData(block.GetBlockName(), "prebidcha5", 0).ParseLong("prebidcha5"); // long 12
				block.offerho6 = query.GetFieldData(block.GetBlockName(), "offerho6", 0).ParseLong("offerho6"); // long 8
				block.bidho6 = query.GetFieldData(block.GetBlockName(), "bidho6", 0).ParseLong("bidho6"); // long 8
				block.offerrem6 = query.GetFieldData(block.GetBlockName(), "offerrem6", 0).ParseLong("offerrem6"); // long 12
				block.bidrem6 = query.GetFieldData(block.GetBlockName(), "bidrem6", 0).ParseLong("bidrem6"); // long 12
				block.preoffercha6 = query.GetFieldData(block.GetBlockName(), "preoffercha6", 0).ParseLong("preoffercha6"); // long 12
				block.prebidcha6 = query.GetFieldData(block.GetBlockName(), "prebidcha6", 0).ParseLong("prebidcha6"); // long 12
				block.offerho7 = query.GetFieldData(block.GetBlockName(), "offerho7", 0).ParseLong("offerho7"); // long 8
				block.bidho7 = query.GetFieldData(block.GetBlockName(), "bidho7", 0).ParseLong("bidho7"); // long 8
				block.offerrem7 = query.GetFieldData(block.GetBlockName(), "offerrem7", 0).ParseLong("offerrem7"); // long 12
				block.bidrem7 = query.GetFieldData(block.GetBlockName(), "bidrem7", 0).ParseLong("bidrem7"); // long 12
				block.preoffercha7 = query.GetFieldData(block.GetBlockName(), "preoffercha7", 0).ParseLong("preoffercha7"); // long 12
				block.prebidcha7 = query.GetFieldData(block.GetBlockName(), "prebidcha7", 0).ParseLong("prebidcha7"); // long 12
				block.offerho8 = query.GetFieldData(block.GetBlockName(), "offerho8", 0).ParseLong("offerho8"); // long 8
				block.bidho8 = query.GetFieldData(block.GetBlockName(), "bidho8", 0).ParseLong("bidho8"); // long 8
				block.offerrem8 = query.GetFieldData(block.GetBlockName(), "offerrem8", 0).ParseLong("offerrem8"); // long 12
				block.bidrem8 = query.GetFieldData(block.GetBlockName(), "bidrem8", 0).ParseLong("bidrem8"); // long 12
				block.preoffercha8 = query.GetFieldData(block.GetBlockName(), "preoffercha8", 0).ParseLong("preoffercha8"); // long 12
				block.prebidcha8 = query.GetFieldData(block.GetBlockName(), "prebidcha8", 0).ParseLong("prebidcha8"); // long 12
				block.offerho9 = query.GetFieldData(block.GetBlockName(), "offerho9", 0).ParseLong("offerho9"); // long 8
				block.bidho9 = query.GetFieldData(block.GetBlockName(), "bidho9", 0).ParseLong("bidho9"); // long 8
				block.offerrem9 = query.GetFieldData(block.GetBlockName(), "offerrem9", 0).ParseLong("offerrem9"); // long 12
				block.bidrem9 = query.GetFieldData(block.GetBlockName(), "bidrem9", 0).ParseLong("bidrem9"); // long 12
				block.preoffercha9 = query.GetFieldData(block.GetBlockName(), "preoffercha9", 0).ParseLong("preoffercha9"); // long 12
				block.prebidcha9 = query.GetFieldData(block.GetBlockName(), "prebidcha9", 0).ParseLong("prebidcha9"); // long 12
				block.offerho10 = query.GetFieldData(block.GetBlockName(), "offerho10", 0).ParseLong("offerho10"); // long 8
				block.bidho10 = query.GetFieldData(block.GetBlockName(), "bidho10", 0).ParseLong("bidho10"); // long 8
				block.offerrem10 = query.GetFieldData(block.GetBlockName(), "offerrem10", 0).ParseLong("offerrem10"); // long 12
				block.bidrem10 = query.GetFieldData(block.GetBlockName(), "bidrem10", 0).ParseLong("bidrem10"); // long 12
				block.preoffercha10 = query.GetFieldData(block.GetBlockName(), "preoffercha10", 0).ParseLong("preoffercha10"); // long 12
				block.prebidcha10 = query.GetFieldData(block.GetBlockName(), "prebidcha10", 0).ParseLong("prebidcha10"); // long 12
				block.offer = query.GetFieldData(block.GetBlockName(), "offer", 0).ParseLong("offer"); // long 12
				block.bid = query.GetFieldData(block.GetBlockName(), "bid", 0).ParseLong("bid"); // long 12
				block.preoffercha = query.GetFieldData(block.GetBlockName(), "preoffercha", 0).ParseLong("preoffercha"); // long 12
				block.prebidcha = query.GetFieldData(block.GetBlockName(), "prebidcha", 0).ParseLong("prebidcha"); // long 12
				block.hotime = query.GetFieldData(block.GetBlockName(), "hotime", 0).TrimEnd('?'); // char 8
				block.yeprice = query.GetFieldData(block.GetBlockName(), "yeprice", 0).ParseLong("yeprice"); // long 8
				block.yevolume = query.GetFieldData(block.GetBlockName(), "yevolume", 0).ParseLong("yevolume"); // long 12
				block.yesign = query.GetFieldData(block.GetBlockName(), "yesign", 0).FirstOrDefault(); // char 1
				block.yechange = query.GetFieldData(block.GetBlockName(), "yechange", 0).ParseLong("yechange"); // long 8
				block.yediff = query.GetFieldData(block.GetBlockName(), "yediff", 0).ParseFloat("yediff"); // float 6.2
				block.tmoffer = query.GetFieldData(block.GetBlockName(), "tmoffer", 0).ParseLong("tmoffer"); // long 12
				block.tmbid = query.GetFieldData(block.GetBlockName(), "tmbid", 0).ParseLong("tmbid"); // long 12
				block.ho_status = query.GetFieldData(block.GetBlockName(), "ho_status", 0).FirstOrDefault(); // char 1
				block.shcode = query.GetFieldData(block.GetBlockName(), "shcode", 0).TrimEnd('?'); // char 6
				block.uplmtprice = query.GetFieldData(block.GetBlockName(), "uplmtprice", 0).ParseLong("uplmtprice"); // long 8
				block.dnlmtprice = query.GetFieldData(block.GetBlockName(), "dnlmtprice", 0).ParseLong("dnlmtprice"); // long 8
				block.open = query.GetFieldData(block.GetBlockName(), "open", 0).ParseLong("open"); // long 8
				block.high = query.GetFieldData(block.GetBlockName(), "high", 0).ParseLong("high"); // long 8
				block.low = query.GetFieldData(block.GetBlockName(), "low", 0).ParseLong("low"); // long 8

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
			if (lp_offerrem1.ToString().Length > 12) return false; // long 12
			if (lp_bidrem1.ToString().Length > 12) return false; // long 12
			if (lp_offerrem2.ToString().Length > 12) return false; // long 12
			if (lp_bidrem2.ToString().Length > 12) return false; // long 12
			if (lp_offerrem3.ToString().Length > 12) return false; // long 12
			if (lp_bidrem3.ToString().Length > 12) return false; // long 12
			if (lp_offerrem4.ToString().Length > 12) return false; // long 12
			if (lp_bidrem4.ToString().Length > 12) return false; // long 12
			if (lp_offerrem5.ToString().Length > 12) return false; // long 12
			if (lp_bidrem5.ToString().Length > 12) return false; // long 12
			if (lp_offerrem6.ToString().Length > 12) return false; // long 12
			if (lp_bidrem6.ToString().Length > 12) return false; // long 12
			if (lp_offerrem7.ToString().Length > 12) return false; // long 12
			if (lp_bidrem7.ToString().Length > 12) return false; // long 12
			if (lp_offerrem8.ToString().Length > 12) return false; // long 12
			if (lp_bidrem8.ToString().Length > 12) return false; // long 12
			if (lp_offerrem9.ToString().Length > 12) return false; // long 12
			if (lp_bidrem9.ToString().Length > 12) return false; // long 12
			if (lp_offerrem10.ToString().Length > 12) return false; // long 12
			if (lp_bidrem10.ToString().Length > 12) return false; // long 12
			if (jnilclose.ToString().Length > 8) return false; // long 8
			if (offerho1.ToString().Length > 8) return false; // long 8
			if (bidho1.ToString().Length > 8) return false; // long 8
			if (offerrem1.ToString().Length > 12) return false; // long 12
			if (bidrem1.ToString().Length > 12) return false; // long 12
			if (preoffercha1.ToString().Length > 12) return false; // long 12
			if (prebidcha1.ToString().Length > 12) return false; // long 12
			if (offerho2.ToString().Length > 8) return false; // long 8
			if (bidho2.ToString().Length > 8) return false; // long 8
			if (offerrem2.ToString().Length > 12) return false; // long 12
			if (bidrem2.ToString().Length > 12) return false; // long 12
			if (preoffercha2.ToString().Length > 12) return false; // long 12
			if (prebidcha2.ToString().Length > 12) return false; // long 12
			if (offerho3.ToString().Length > 8) return false; // long 8
			if (bidho3.ToString().Length > 8) return false; // long 8
			if (offerrem3.ToString().Length > 12) return false; // long 12
			if (bidrem3.ToString().Length > 12) return false; // long 12
			if (preoffercha3.ToString().Length > 12) return false; // long 12
			if (prebidcha3.ToString().Length > 12) return false; // long 12
			if (offerho4.ToString().Length > 8) return false; // long 8
			if (bidho4.ToString().Length > 8) return false; // long 8
			if (offerrem4.ToString().Length > 12) return false; // long 12
			if (bidrem4.ToString().Length > 12) return false; // long 12
			if (preoffercha4.ToString().Length > 12) return false; // long 12
			if (prebidcha4.ToString().Length > 12) return false; // long 12
			if (offerho5.ToString().Length > 8) return false; // long 8
			if (bidho5.ToString().Length > 8) return false; // long 8
			if (offerrem5.ToString().Length > 12) return false; // long 12
			if (bidrem5.ToString().Length > 12) return false; // long 12
			if (preoffercha5.ToString().Length > 12) return false; // long 12
			if (prebidcha5.ToString().Length > 12) return false; // long 12
			if (offerho6.ToString().Length > 8) return false; // long 8
			if (bidho6.ToString().Length > 8) return false; // long 8
			if (offerrem6.ToString().Length > 12) return false; // long 12
			if (bidrem6.ToString().Length > 12) return false; // long 12
			if (preoffercha6.ToString().Length > 12) return false; // long 12
			if (prebidcha6.ToString().Length > 12) return false; // long 12
			if (offerho7.ToString().Length > 8) return false; // long 8
			if (bidho7.ToString().Length > 8) return false; // long 8
			if (offerrem7.ToString().Length > 12) return false; // long 12
			if (bidrem7.ToString().Length > 12) return false; // long 12
			if (preoffercha7.ToString().Length > 12) return false; // long 12
			if (prebidcha7.ToString().Length > 12) return false; // long 12
			if (offerho8.ToString().Length > 8) return false; // long 8
			if (bidho8.ToString().Length > 8) return false; // long 8
			if (offerrem8.ToString().Length > 12) return false; // long 12
			if (bidrem8.ToString().Length > 12) return false; // long 12
			if (preoffercha8.ToString().Length > 12) return false; // long 12
			if (prebidcha8.ToString().Length > 12) return false; // long 12
			if (offerho9.ToString().Length > 8) return false; // long 8
			if (bidho9.ToString().Length > 8) return false; // long 8
			if (offerrem9.ToString().Length > 12) return false; // long 12
			if (bidrem9.ToString().Length > 12) return false; // long 12
			if (preoffercha9.ToString().Length > 12) return false; // long 12
			if (prebidcha9.ToString().Length > 12) return false; // long 12
			if (offerho10.ToString().Length > 8) return false; // long 8
			if (bidho10.ToString().Length > 8) return false; // long 8
			if (offerrem10.ToString().Length > 12) return false; // long 12
			if (bidrem10.ToString().Length > 12) return false; // long 12
			if (preoffercha10.ToString().Length > 12) return false; // long 12
			if (prebidcha10.ToString().Length > 12) return false; // long 12
			if (offer.ToString().Length > 12) return false; // long 12
			if (bid.ToString().Length > 12) return false; // long 12
			if (preoffercha.ToString().Length > 12) return false; // long 12
			if (prebidcha.ToString().Length > 12) return false; // long 12
			if (hotime?.Length > 8) return false; // char 8
			if (yeprice.ToString().Length > 8) return false; // long 8
			if (yevolume.ToString().Length > 12) return false; // long 12
			// yesign char 1
			if (yechange.ToString().Length > 8) return false; // long 8
			// yediff float 6.2
			if (tmoffer.ToString().Length > 12) return false; // long 12
			if (tmbid.ToString().Length > 12) return false; // long 12
			// ho_status char 1
			if (shcode?.Length > 6) return false; // char 6
			if (uplmtprice.ToString().Length > 8) return false; // long 8
			if (dnlmtprice.ToString().Length > 8) return false; // long 8
			if (open.ToString().Length > 8) return false; // long 8
			if (high.ToString().Length > 8) return false; // long 8
			if (low.ToString().Length > 8) return false; // long 8

			return true;
		}
	}

	/// <summary>
	/// ETFLP호가(t1906)
	/// </summary>
	public partial class XQt1906 : XingQuery
	{
		/// <summary>
		/// t1906
		/// </summary>
		public const string _typeName = "t1906";
		/// <summary>
		/// ETFLP호가(t1906)
		/// </summary>
		public const string _typeDesc = "ETFLP호가(t1906)";
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
		/// t1906
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// ETFLP호가(t1906)
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

		public XQt1906() : base("t1906") { }


		public static XQt1906OutBlock Get(string shcode = default)
		{
			using (XQt1906 instance = new XQt1906())
			{
				instance.SetFieldData(XQt1906InBlock.BlockName, XQt1906InBlock.F.shcode, 0, shcode); // char 6

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

		public bool SetBlock(XQt1906InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "shcode", 0, block.shcode); // char 6

			return true;
		}

		public XQt1906OutBlock GetBlock()
		{
			XQt1906OutBlock instance = XQt1906OutBlock.FromQuery(this);
			return instance;

		}


	}

}
