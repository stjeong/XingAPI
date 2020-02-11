using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XRB7_InBlock : XingBlock
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
		[XAQueryFieldAttribute("shcode", "단축코드", "char", "6")]
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

	public partial class XRB7_OutBlock : XingBlock
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
		/// 호가시간
		/// </summary>
		[XAQueryFieldAttribute("hotime", "호가시간", "char", "6")]
		public string hotime;
		/// <summary>
		/// LP매도호가수량1
		/// </summary>
		[XAQueryFieldAttribute("lp_offerho1", "LP매도호가수량1", "long", "9")]
		public long lp_offerho1;
		/// <summary>
		/// LP매수호가수량1
		/// </summary>
		[XAQueryFieldAttribute("lp_bidho1", "LP매수호가수량1", "long", "9")]
		public long lp_bidho1;
		/// <summary>
		/// LP매도호가수량2
		/// </summary>
		[XAQueryFieldAttribute("lp_offerho2", "LP매도호가수량2", "long", "9")]
		public long lp_offerho2;
		/// <summary>
		/// LP매수호가수량2
		/// </summary>
		[XAQueryFieldAttribute("lp_bidho2", "LP매수호가수량2", "long", "9")]
		public long lp_bidho2;
		/// <summary>
		/// LP매도호가수량3
		/// </summary>
		[XAQueryFieldAttribute("lp_offerho3", "LP매도호가수량3", "long", "9")]
		public long lp_offerho3;
		/// <summary>
		/// LP매수호가수량3
		/// </summary>
		[XAQueryFieldAttribute("lp_bidho3", "LP매수호가수량3", "long", "9")]
		public long lp_bidho3;
		/// <summary>
		/// LP매도호가수량4
		/// </summary>
		[XAQueryFieldAttribute("lp_offerho4", "LP매도호가수량4", "long", "9")]
		public long lp_offerho4;
		/// <summary>
		/// LP매수호가수량4
		/// </summary>
		[XAQueryFieldAttribute("lp_bidho4", "LP매수호가수량4", "long", "9")]
		public long lp_bidho4;
		/// <summary>
		/// LP매도호가수량5
		/// </summary>
		[XAQueryFieldAttribute("lp_offerho5", "LP매도호가수량5", "long", "9")]
		public long lp_offerho5;
		/// <summary>
		/// LP매수호가수량5
		/// </summary>
		[XAQueryFieldAttribute("lp_bidho5", "LP매수호가수량5", "long", "9")]
		public long lp_bidho5;
		/// <summary>
		/// LP매도호가수량6
		/// </summary>
		[XAQueryFieldAttribute("lp_offerho6", "LP매도호가수량6", "long", "9")]
		public long lp_offerho6;
		/// <summary>
		/// LP매수호가수량6
		/// </summary>
		[XAQueryFieldAttribute("lp_bidho6", "LP매수호가수량6", "long", "9")]
		public long lp_bidho6;
		/// <summary>
		/// LP매도호가수량7
		/// </summary>
		[XAQueryFieldAttribute("lp_offerho7", "LP매도호가수량7", "long", "9")]
		public long lp_offerho7;
		/// <summary>
		/// LP매수호가수량7
		/// </summary>
		[XAQueryFieldAttribute("lp_bidho7", "LP매수호가수량7", "long", "9")]
		public long lp_bidho7;
		/// <summary>
		/// LP매도호가수량8
		/// </summary>
		[XAQueryFieldAttribute("lp_offerho8", "LP매도호가수량8", "long", "9")]
		public long lp_offerho8;
		/// <summary>
		/// LP매수호가수량8
		/// </summary>
		[XAQueryFieldAttribute("lp_bidho8", "LP매수호가수량8", "long", "9")]
		public long lp_bidho8;
		/// <summary>
		/// LP매도호가수량9
		/// </summary>
		[XAQueryFieldAttribute("lp_offerho9", "LP매도호가수량9", "long", "9")]
		public long lp_offerho9;
		/// <summary>
		/// LP매수호가수량9
		/// </summary>
		[XAQueryFieldAttribute("lp_bidho9", "LP매수호가수량9", "long", "9")]
		public long lp_bidho9;
		/// <summary>
		/// LP매도호가수량10
		/// </summary>
		[XAQueryFieldAttribute("lp_offerho10", "LP매도호가수량10", "long", "9")]
		public long lp_offerho10;
		/// <summary>
		/// LP매수호가수량10
		/// </summary>
		[XAQueryFieldAttribute("lp_bidho10", "LP매수호가수량10", "long", "9")]
		public long lp_bidho10;
		/// <summary>
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("shcode", "단축코드", "char", "6")]
		public string shcode;
		/// <summary>
		/// 매도호가1
		/// </summary>
		[XAQueryFieldAttribute("offerho1", "매도호가1", "long", "7")]
		public long offerho1;
		/// <summary>
		/// 매수호가1
		/// </summary>
		[XAQueryFieldAttribute("bidho1", "매수호가1", "long", "7")]
		public long bidho1;
		/// <summary>
		/// 매도호가잔량1
		/// </summary>
		[XAQueryFieldAttribute("offerrem1", "매도호가잔량1", "long", "9")]
		public long offerrem1;
		/// <summary>
		/// 매수호가잔량1
		/// </summary>
		[XAQueryFieldAttribute("bidrem1", "매수호가잔량1", "long", "9")]
		public long bidrem1;
		/// <summary>
		/// 매도호가2
		/// </summary>
		[XAQueryFieldAttribute("offerho2", "매도호가2", "long", "7")]
		public long offerho2;
		/// <summary>
		/// 매수호가2
		/// </summary>
		[XAQueryFieldAttribute("bidho2", "매수호가2", "long", "7")]
		public long bidho2;
		/// <summary>
		/// 매도호가잔량2
		/// </summary>
		[XAQueryFieldAttribute("offerrem2", "매도호가잔량2", "long", "9")]
		public long offerrem2;
		/// <summary>
		/// 매수호가잔량2
		/// </summary>
		[XAQueryFieldAttribute("bidrem2", "매수호가잔량2", "long", "9")]
		public long bidrem2;
		/// <summary>
		/// 매도호가3
		/// </summary>
		[XAQueryFieldAttribute("offerho3", "매도호가3", "long", "7")]
		public long offerho3;
		/// <summary>
		/// 매수호가3
		/// </summary>
		[XAQueryFieldAttribute("bidho3", "매수호가3", "long", "7")]
		public long bidho3;
		/// <summary>
		/// 매도호가잔량3
		/// </summary>
		[XAQueryFieldAttribute("offerrem3", "매도호가잔량3", "long", "9")]
		public long offerrem3;
		/// <summary>
		/// 매수호가잔량3
		/// </summary>
		[XAQueryFieldAttribute("bidrem3", "매수호가잔량3", "long", "9")]
		public long bidrem3;
		/// <summary>
		/// 매도호가4
		/// </summary>
		[XAQueryFieldAttribute("offerho4", "매도호가4", "long", "7")]
		public long offerho4;
		/// <summary>
		/// 매수호가4
		/// </summary>
		[XAQueryFieldAttribute("bidho4", "매수호가4", "long", "7")]
		public long bidho4;
		/// <summary>
		/// 매도호가잔량4
		/// </summary>
		[XAQueryFieldAttribute("offerrem4", "매도호가잔량4", "long", "9")]
		public long offerrem4;
		/// <summary>
		/// 매수호가잔량4
		/// </summary>
		[XAQueryFieldAttribute("bidrem4", "매수호가잔량4", "long", "9")]
		public long bidrem4;
		/// <summary>
		/// 매도호가5
		/// </summary>
		[XAQueryFieldAttribute("offerho5", "매도호가5", "long", "7")]
		public long offerho5;
		/// <summary>
		/// 매수호가5
		/// </summary>
		[XAQueryFieldAttribute("bidho5", "매수호가5", "long", "7")]
		public long bidho5;
		/// <summary>
		/// 매도호가잔량5
		/// </summary>
		[XAQueryFieldAttribute("offerrem5", "매도호가잔량5", "long", "9")]
		public long offerrem5;
		/// <summary>
		/// 매수호가잔량5
		/// </summary>
		[XAQueryFieldAttribute("bidrem5", "매수호가잔량5", "long", "9")]
		public long bidrem5;
		/// <summary>
		/// 매도호가6
		/// </summary>
		[XAQueryFieldAttribute("offerho6", "매도호가6", "long", "7")]
		public long offerho6;
		/// <summary>
		/// 매수호가6
		/// </summary>
		[XAQueryFieldAttribute("bidho6", "매수호가6", "long", "7")]
		public long bidho6;
		/// <summary>
		/// 매도호가잔량6
		/// </summary>
		[XAQueryFieldAttribute("offerrem6", "매도호가잔량6", "long", "9")]
		public long offerrem6;
		/// <summary>
		/// 매수호가잔량6
		/// </summary>
		[XAQueryFieldAttribute("bidrem6", "매수호가잔량6", "long", "9")]
		public long bidrem6;
		/// <summary>
		/// 매도호가7
		/// </summary>
		[XAQueryFieldAttribute("offerho7", "매도호가7", "long", "7")]
		public long offerho7;
		/// <summary>
		/// 매수호가7
		/// </summary>
		[XAQueryFieldAttribute("bidho7", "매수호가7", "long", "7")]
		public long bidho7;
		/// <summary>
		/// 매도호가잔량7
		/// </summary>
		[XAQueryFieldAttribute("offerrem7", "매도호가잔량7", "long", "9")]
		public long offerrem7;
		/// <summary>
		/// 매수호가잔량7
		/// </summary>
		[XAQueryFieldAttribute("bidrem7", "매수호가잔량7", "long", "9")]
		public long bidrem7;
		/// <summary>
		/// 매도호가8
		/// </summary>
		[XAQueryFieldAttribute("offerho8", "매도호가8", "long", "7")]
		public long offerho8;
		/// <summary>
		/// 매수호가8
		/// </summary>
		[XAQueryFieldAttribute("bidho8", "매수호가8", "long", "7")]
		public long bidho8;
		/// <summary>
		/// 매도호가잔량8
		/// </summary>
		[XAQueryFieldAttribute("offerrem8", "매도호가잔량8", "long", "9")]
		public long offerrem8;
		/// <summary>
		/// 매수호가잔량8
		/// </summary>
		[XAQueryFieldAttribute("bidrem8", "매수호가잔량8", "long", "9")]
		public long bidrem8;
		/// <summary>
		/// 매도호가9
		/// </summary>
		[XAQueryFieldAttribute("offerho9", "매도호가9", "long", "7")]
		public long offerho9;
		/// <summary>
		/// 매수호가9
		/// </summary>
		[XAQueryFieldAttribute("bidho9", "매수호가9", "long", "7")]
		public long bidho9;
		/// <summary>
		/// 매도호가잔량9
		/// </summary>
		[XAQueryFieldAttribute("offerrem9", "매도호가잔량9", "long", "9")]
		public long offerrem9;
		/// <summary>
		/// 매수호가잔량9
		/// </summary>
		[XAQueryFieldAttribute("bidrem9", "매수호가잔량9", "long", "9")]
		public long bidrem9;
		/// <summary>
		/// 매도호가10
		/// </summary>
		[XAQueryFieldAttribute("offerho10", "매도호가10", "long", "7")]
		public long offerho10;
		/// <summary>
		/// 매수호가10
		/// </summary>
		[XAQueryFieldAttribute("bidho10", "매수호가10", "long", "7")]
		public long bidho10;
		/// <summary>
		/// 매도호가잔량10
		/// </summary>
		[XAQueryFieldAttribute("offerrem10", "매도호가잔량10", "long", "9")]
		public long offerrem10;
		/// <summary>
		/// 매수호가잔량10
		/// </summary>
		[XAQueryFieldAttribute("bidrem10", "매수호가잔량10", "long", "9")]
		public long bidrem10;
		/// <summary>
		/// 총매도호가잔량
		/// </summary>
		[XAQueryFieldAttribute("totofferrem", "총매도호가잔량", "long", "9")]
		public long totofferrem;
		/// <summary>
		/// 총매수호가잔량
		/// </summary>
		[XAQueryFieldAttribute("totbidrem", "총매수호가잔량", "long", "9")]
		public long totbidrem;
		/// <summary>
		/// 동시호가구분
		/// </summary>
		[XAQueryFieldAttribute("donsigubun", "동시호가구분", "char", "1")]
		public char donsigubun;
		/// <summary>
		/// 배분적용구분
		/// </summary>
		[XAQueryFieldAttribute("alloc_gubun", "배분적용구분", "char", "1")]
		public char alloc_gubun;

		public static class F
		{
			/// <summary>
			/// 호가시간
			/// </summary>
			public const string hotime = "hotime";
			/// <summary>
			/// LP매도호가수량1
			/// </summary>
			public const string lp_offerho1 = "lp_offerho1";
			/// <summary>
			/// LP매수호가수량1
			/// </summary>
			public const string lp_bidho1 = "lp_bidho1";
			/// <summary>
			/// LP매도호가수량2
			/// </summary>
			public const string lp_offerho2 = "lp_offerho2";
			/// <summary>
			/// LP매수호가수량2
			/// </summary>
			public const string lp_bidho2 = "lp_bidho2";
			/// <summary>
			/// LP매도호가수량3
			/// </summary>
			public const string lp_offerho3 = "lp_offerho3";
			/// <summary>
			/// LP매수호가수량3
			/// </summary>
			public const string lp_bidho3 = "lp_bidho3";
			/// <summary>
			/// LP매도호가수량4
			/// </summary>
			public const string lp_offerho4 = "lp_offerho4";
			/// <summary>
			/// LP매수호가수량4
			/// </summary>
			public const string lp_bidho4 = "lp_bidho4";
			/// <summary>
			/// LP매도호가수량5
			/// </summary>
			public const string lp_offerho5 = "lp_offerho5";
			/// <summary>
			/// LP매수호가수량5
			/// </summary>
			public const string lp_bidho5 = "lp_bidho5";
			/// <summary>
			/// LP매도호가수량6
			/// </summary>
			public const string lp_offerho6 = "lp_offerho6";
			/// <summary>
			/// LP매수호가수량6
			/// </summary>
			public const string lp_bidho6 = "lp_bidho6";
			/// <summary>
			/// LP매도호가수량7
			/// </summary>
			public const string lp_offerho7 = "lp_offerho7";
			/// <summary>
			/// LP매수호가수량7
			/// </summary>
			public const string lp_bidho7 = "lp_bidho7";
			/// <summary>
			/// LP매도호가수량8
			/// </summary>
			public const string lp_offerho8 = "lp_offerho8";
			/// <summary>
			/// LP매수호가수량8
			/// </summary>
			public const string lp_bidho8 = "lp_bidho8";
			/// <summary>
			/// LP매도호가수량9
			/// </summary>
			public const string lp_offerho9 = "lp_offerho9";
			/// <summary>
			/// LP매수호가수량9
			/// </summary>
			public const string lp_bidho9 = "lp_bidho9";
			/// <summary>
			/// LP매도호가수량10
			/// </summary>
			public const string lp_offerho10 = "lp_offerho10";
			/// <summary>
			/// LP매수호가수량10
			/// </summary>
			public const string lp_bidho10 = "lp_bidho10";
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 매도호가1
			/// </summary>
			public const string offerho1 = "offerho1";
			/// <summary>
			/// 매수호가1
			/// </summary>
			public const string bidho1 = "bidho1";
			/// <summary>
			/// 매도호가잔량1
			/// </summary>
			public const string offerrem1 = "offerrem1";
			/// <summary>
			/// 매수호가잔량1
			/// </summary>
			public const string bidrem1 = "bidrem1";
			/// <summary>
			/// 매도호가2
			/// </summary>
			public const string offerho2 = "offerho2";
			/// <summary>
			/// 매수호가2
			/// </summary>
			public const string bidho2 = "bidho2";
			/// <summary>
			/// 매도호가잔량2
			/// </summary>
			public const string offerrem2 = "offerrem2";
			/// <summary>
			/// 매수호가잔량2
			/// </summary>
			public const string bidrem2 = "bidrem2";
			/// <summary>
			/// 매도호가3
			/// </summary>
			public const string offerho3 = "offerho3";
			/// <summary>
			/// 매수호가3
			/// </summary>
			public const string bidho3 = "bidho3";
			/// <summary>
			/// 매도호가잔량3
			/// </summary>
			public const string offerrem3 = "offerrem3";
			/// <summary>
			/// 매수호가잔량3
			/// </summary>
			public const string bidrem3 = "bidrem3";
			/// <summary>
			/// 매도호가4
			/// </summary>
			public const string offerho4 = "offerho4";
			/// <summary>
			/// 매수호가4
			/// </summary>
			public const string bidho4 = "bidho4";
			/// <summary>
			/// 매도호가잔량4
			/// </summary>
			public const string offerrem4 = "offerrem4";
			/// <summary>
			/// 매수호가잔량4
			/// </summary>
			public const string bidrem4 = "bidrem4";
			/// <summary>
			/// 매도호가5
			/// </summary>
			public const string offerho5 = "offerho5";
			/// <summary>
			/// 매수호가5
			/// </summary>
			public const string bidho5 = "bidho5";
			/// <summary>
			/// 매도호가잔량5
			/// </summary>
			public const string offerrem5 = "offerrem5";
			/// <summary>
			/// 매수호가잔량5
			/// </summary>
			public const string bidrem5 = "bidrem5";
			/// <summary>
			/// 매도호가6
			/// </summary>
			public const string offerho6 = "offerho6";
			/// <summary>
			/// 매수호가6
			/// </summary>
			public const string bidho6 = "bidho6";
			/// <summary>
			/// 매도호가잔량6
			/// </summary>
			public const string offerrem6 = "offerrem6";
			/// <summary>
			/// 매수호가잔량6
			/// </summary>
			public const string bidrem6 = "bidrem6";
			/// <summary>
			/// 매도호가7
			/// </summary>
			public const string offerho7 = "offerho7";
			/// <summary>
			/// 매수호가7
			/// </summary>
			public const string bidho7 = "bidho7";
			/// <summary>
			/// 매도호가잔량7
			/// </summary>
			public const string offerrem7 = "offerrem7";
			/// <summary>
			/// 매수호가잔량7
			/// </summary>
			public const string bidrem7 = "bidrem7";
			/// <summary>
			/// 매도호가8
			/// </summary>
			public const string offerho8 = "offerho8";
			/// <summary>
			/// 매수호가8
			/// </summary>
			public const string bidho8 = "bidho8";
			/// <summary>
			/// 매도호가잔량8
			/// </summary>
			public const string offerrem8 = "offerrem8";
			/// <summary>
			/// 매수호가잔량8
			/// </summary>
			public const string bidrem8 = "bidrem8";
			/// <summary>
			/// 매도호가9
			/// </summary>
			public const string offerho9 = "offerho9";
			/// <summary>
			/// 매수호가9
			/// </summary>
			public const string bidho9 = "bidho9";
			/// <summary>
			/// 매도호가잔량9
			/// </summary>
			public const string offerrem9 = "offerrem9";
			/// <summary>
			/// 매수호가잔량9
			/// </summary>
			public const string bidrem9 = "bidrem9";
			/// <summary>
			/// 매도호가10
			/// </summary>
			public const string offerho10 = "offerho10";
			/// <summary>
			/// 매수호가10
			/// </summary>
			public const string bidho10 = "bidho10";
			/// <summary>
			/// 매도호가잔량10
			/// </summary>
			public const string offerrem10 = "offerrem10";
			/// <summary>
			/// 매수호가잔량10
			/// </summary>
			public const string bidrem10 = "bidrem10";
			/// <summary>
			/// 총매도호가잔량
			/// </summary>
			public const string totofferrem = "totofferrem";
			/// <summary>
			/// 총매수호가잔량
			/// </summary>
			public const string totbidrem = "totbidrem";
			/// <summary>
			/// 동시호가구분
			/// </summary>
			public const string donsigubun = "donsigubun";
			/// <summary>
			/// 배분적용구분
			/// </summary>
			public const string alloc_gubun = "alloc_gubun";
		}

		public static string[] AllFields = new string[]
		{
			F.hotime,
			F.lp_offerho1,
			F.lp_bidho1,
			F.lp_offerho2,
			F.lp_bidho2,
			F.lp_offerho3,
			F.lp_bidho3,
			F.lp_offerho4,
			F.lp_bidho4,
			F.lp_offerho5,
			F.lp_bidho5,
			F.lp_offerho6,
			F.lp_bidho6,
			F.lp_offerho7,
			F.lp_bidho7,
			F.lp_offerho8,
			F.lp_bidho8,
			F.lp_offerho9,
			F.lp_bidho9,
			F.lp_offerho10,
			F.lp_bidho10,
			F.shcode,
			F.offerho1,
			F.bidho1,
			F.offerrem1,
			F.bidrem1,
			F.offerho2,
			F.bidho2,
			F.offerrem2,
			F.bidrem2,
			F.offerho3,
			F.bidho3,
			F.offerrem3,
			F.bidrem3,
			F.offerho4,
			F.bidho4,
			F.offerrem4,
			F.bidrem4,
			F.offerho5,
			F.bidho5,
			F.offerrem5,
			F.bidrem5,
			F.offerho6,
			F.bidho6,
			F.offerrem6,
			F.bidrem6,
			F.offerho7,
			F.bidho7,
			F.offerrem7,
			F.bidrem7,
			F.offerho8,
			F.bidho8,
			F.offerrem8,
			F.bidrem8,
			F.offerho9,
			F.bidho9,
			F.offerrem9,
			F.bidrem9,
			F.offerho10,
			F.bidho10,
			F.offerrem10,
			F.bidrem10,
			F.totofferrem,
			F.totbidrem,
			F.donsigubun,
			F.alloc_gubun,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["hotime"] = new XAQueryFieldInfo("char", hotime, hotime, "호가시간", (decimal)6);
			dict["lp_offerho1"] = new XAQueryFieldInfo("long", lp_offerho1, lp_offerho1.ToString("d9"), "LP매도호가수량1", (decimal)9);
			dict["lp_bidho1"] = new XAQueryFieldInfo("long", lp_bidho1, lp_bidho1.ToString("d9"), "LP매수호가수량1", (decimal)9);
			dict["lp_offerho2"] = new XAQueryFieldInfo("long", lp_offerho2, lp_offerho2.ToString("d9"), "LP매도호가수량2", (decimal)9);
			dict["lp_bidho2"] = new XAQueryFieldInfo("long", lp_bidho2, lp_bidho2.ToString("d9"), "LP매수호가수량2", (decimal)9);
			dict["lp_offerho3"] = new XAQueryFieldInfo("long", lp_offerho3, lp_offerho3.ToString("d9"), "LP매도호가수량3", (decimal)9);
			dict["lp_bidho3"] = new XAQueryFieldInfo("long", lp_bidho3, lp_bidho3.ToString("d9"), "LP매수호가수량3", (decimal)9);
			dict["lp_offerho4"] = new XAQueryFieldInfo("long", lp_offerho4, lp_offerho4.ToString("d9"), "LP매도호가수량4", (decimal)9);
			dict["lp_bidho4"] = new XAQueryFieldInfo("long", lp_bidho4, lp_bidho4.ToString("d9"), "LP매수호가수량4", (decimal)9);
			dict["lp_offerho5"] = new XAQueryFieldInfo("long", lp_offerho5, lp_offerho5.ToString("d9"), "LP매도호가수량5", (decimal)9);
			dict["lp_bidho5"] = new XAQueryFieldInfo("long", lp_bidho5, lp_bidho5.ToString("d9"), "LP매수호가수량5", (decimal)9);
			dict["lp_offerho6"] = new XAQueryFieldInfo("long", lp_offerho6, lp_offerho6.ToString("d9"), "LP매도호가수량6", (decimal)9);
			dict["lp_bidho6"] = new XAQueryFieldInfo("long", lp_bidho6, lp_bidho6.ToString("d9"), "LP매수호가수량6", (decimal)9);
			dict["lp_offerho7"] = new XAQueryFieldInfo("long", lp_offerho7, lp_offerho7.ToString("d9"), "LP매도호가수량7", (decimal)9);
			dict["lp_bidho7"] = new XAQueryFieldInfo("long", lp_bidho7, lp_bidho7.ToString("d9"), "LP매수호가수량7", (decimal)9);
			dict["lp_offerho8"] = new XAQueryFieldInfo("long", lp_offerho8, lp_offerho8.ToString("d9"), "LP매도호가수량8", (decimal)9);
			dict["lp_bidho8"] = new XAQueryFieldInfo("long", lp_bidho8, lp_bidho8.ToString("d9"), "LP매수호가수량8", (decimal)9);
			dict["lp_offerho9"] = new XAQueryFieldInfo("long", lp_offerho9, lp_offerho9.ToString("d9"), "LP매도호가수량9", (decimal)9);
			dict["lp_bidho9"] = new XAQueryFieldInfo("long", lp_bidho9, lp_bidho9.ToString("d9"), "LP매수호가수량9", (decimal)9);
			dict["lp_offerho10"] = new XAQueryFieldInfo("long", lp_offerho10, lp_offerho10.ToString("d9"), "LP매도호가수량10", (decimal)9);
			dict["lp_bidho10"] = new XAQueryFieldInfo("long", lp_bidho10, lp_bidho10.ToString("d9"), "LP매수호가수량10", (decimal)9);
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)6);
			dict["offerho1"] = new XAQueryFieldInfo("long", offerho1, offerho1.ToString("d7"), "매도호가1", (decimal)7);
			dict["bidho1"] = new XAQueryFieldInfo("long", bidho1, bidho1.ToString("d7"), "매수호가1", (decimal)7);
			dict["offerrem1"] = new XAQueryFieldInfo("long", offerrem1, offerrem1.ToString("d9"), "매도호가잔량1", (decimal)9);
			dict["bidrem1"] = new XAQueryFieldInfo("long", bidrem1, bidrem1.ToString("d9"), "매수호가잔량1", (decimal)9);
			dict["offerho2"] = new XAQueryFieldInfo("long", offerho2, offerho2.ToString("d7"), "매도호가2", (decimal)7);
			dict["bidho2"] = new XAQueryFieldInfo("long", bidho2, bidho2.ToString("d7"), "매수호가2", (decimal)7);
			dict["offerrem2"] = new XAQueryFieldInfo("long", offerrem2, offerrem2.ToString("d9"), "매도호가잔량2", (decimal)9);
			dict["bidrem2"] = new XAQueryFieldInfo("long", bidrem2, bidrem2.ToString("d9"), "매수호가잔량2", (decimal)9);
			dict["offerho3"] = new XAQueryFieldInfo("long", offerho3, offerho3.ToString("d7"), "매도호가3", (decimal)7);
			dict["bidho3"] = new XAQueryFieldInfo("long", bidho3, bidho3.ToString("d7"), "매수호가3", (decimal)7);
			dict["offerrem3"] = new XAQueryFieldInfo("long", offerrem3, offerrem3.ToString("d9"), "매도호가잔량3", (decimal)9);
			dict["bidrem3"] = new XAQueryFieldInfo("long", bidrem3, bidrem3.ToString("d9"), "매수호가잔량3", (decimal)9);
			dict["offerho4"] = new XAQueryFieldInfo("long", offerho4, offerho4.ToString("d7"), "매도호가4", (decimal)7);
			dict["bidho4"] = new XAQueryFieldInfo("long", bidho4, bidho4.ToString("d7"), "매수호가4", (decimal)7);
			dict["offerrem4"] = new XAQueryFieldInfo("long", offerrem4, offerrem4.ToString("d9"), "매도호가잔량4", (decimal)9);
			dict["bidrem4"] = new XAQueryFieldInfo("long", bidrem4, bidrem4.ToString("d9"), "매수호가잔량4", (decimal)9);
			dict["offerho5"] = new XAQueryFieldInfo("long", offerho5, offerho5.ToString("d7"), "매도호가5", (decimal)7);
			dict["bidho5"] = new XAQueryFieldInfo("long", bidho5, bidho5.ToString("d7"), "매수호가5", (decimal)7);
			dict["offerrem5"] = new XAQueryFieldInfo("long", offerrem5, offerrem5.ToString("d9"), "매도호가잔량5", (decimal)9);
			dict["bidrem5"] = new XAQueryFieldInfo("long", bidrem5, bidrem5.ToString("d9"), "매수호가잔량5", (decimal)9);
			dict["offerho6"] = new XAQueryFieldInfo("long", offerho6, offerho6.ToString("d7"), "매도호가6", (decimal)7);
			dict["bidho6"] = new XAQueryFieldInfo("long", bidho6, bidho6.ToString("d7"), "매수호가6", (decimal)7);
			dict["offerrem6"] = new XAQueryFieldInfo("long", offerrem6, offerrem6.ToString("d9"), "매도호가잔량6", (decimal)9);
			dict["bidrem6"] = new XAQueryFieldInfo("long", bidrem6, bidrem6.ToString("d9"), "매수호가잔량6", (decimal)9);
			dict["offerho7"] = new XAQueryFieldInfo("long", offerho7, offerho7.ToString("d7"), "매도호가7", (decimal)7);
			dict["bidho7"] = new XAQueryFieldInfo("long", bidho7, bidho7.ToString("d7"), "매수호가7", (decimal)7);
			dict["offerrem7"] = new XAQueryFieldInfo("long", offerrem7, offerrem7.ToString("d9"), "매도호가잔량7", (decimal)9);
			dict["bidrem7"] = new XAQueryFieldInfo("long", bidrem7, bidrem7.ToString("d9"), "매수호가잔량7", (decimal)9);
			dict["offerho8"] = new XAQueryFieldInfo("long", offerho8, offerho8.ToString("d7"), "매도호가8", (decimal)7);
			dict["bidho8"] = new XAQueryFieldInfo("long", bidho8, bidho8.ToString("d7"), "매수호가8", (decimal)7);
			dict["offerrem8"] = new XAQueryFieldInfo("long", offerrem8, offerrem8.ToString("d9"), "매도호가잔량8", (decimal)9);
			dict["bidrem8"] = new XAQueryFieldInfo("long", bidrem8, bidrem8.ToString("d9"), "매수호가잔량8", (decimal)9);
			dict["offerho9"] = new XAQueryFieldInfo("long", offerho9, offerho9.ToString("d7"), "매도호가9", (decimal)7);
			dict["bidho9"] = new XAQueryFieldInfo("long", bidho9, bidho9.ToString("d7"), "매수호가9", (decimal)7);
			dict["offerrem9"] = new XAQueryFieldInfo("long", offerrem9, offerrem9.ToString("d9"), "매도호가잔량9", (decimal)9);
			dict["bidrem9"] = new XAQueryFieldInfo("long", bidrem9, bidrem9.ToString("d9"), "매수호가잔량9", (decimal)9);
			dict["offerho10"] = new XAQueryFieldInfo("long", offerho10, offerho10.ToString("d7"), "매도호가10", (decimal)7);
			dict["bidho10"] = new XAQueryFieldInfo("long", bidho10, bidho10.ToString("d7"), "매수호가10", (decimal)7);
			dict["offerrem10"] = new XAQueryFieldInfo("long", offerrem10, offerrem10.ToString("d9"), "매도호가잔량10", (decimal)9);
			dict["bidrem10"] = new XAQueryFieldInfo("long", bidrem10, bidrem10.ToString("d9"), "매수호가잔량10", (decimal)9);
			dict["totofferrem"] = new XAQueryFieldInfo("long", totofferrem, totofferrem.ToString("d9"), "총매도호가잔량", (decimal)9);
			dict["totbidrem"] = new XAQueryFieldInfo("long", totbidrem, totbidrem.ToString("d9"), "총매수호가잔량", (decimal)9);
			dict["donsigubun"] = new XAQueryFieldInfo("char", donsigubun, donsigubun.ToString(), "동시호가구분", (decimal)1);
			dict["alloc_gubun"] = new XAQueryFieldInfo("char", alloc_gubun, alloc_gubun.ToString(), "배분적용구분", (decimal)1);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "hotime":
					this.hotime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "lp_offerho1":
					this.lp_offerho1 = fieldInfo.FieldValue.ParseLong("lp_offerho1");
				break;

				case "lp_bidho1":
					this.lp_bidho1 = fieldInfo.FieldValue.ParseLong("lp_bidho1");
				break;

				case "lp_offerho2":
					this.lp_offerho2 = fieldInfo.FieldValue.ParseLong("lp_offerho2");
				break;

				case "lp_bidho2":
					this.lp_bidho2 = fieldInfo.FieldValue.ParseLong("lp_bidho2");
				break;

				case "lp_offerho3":
					this.lp_offerho3 = fieldInfo.FieldValue.ParseLong("lp_offerho3");
				break;

				case "lp_bidho3":
					this.lp_bidho3 = fieldInfo.FieldValue.ParseLong("lp_bidho3");
				break;

				case "lp_offerho4":
					this.lp_offerho4 = fieldInfo.FieldValue.ParseLong("lp_offerho4");
				break;

				case "lp_bidho4":
					this.lp_bidho4 = fieldInfo.FieldValue.ParseLong("lp_bidho4");
				break;

				case "lp_offerho5":
					this.lp_offerho5 = fieldInfo.FieldValue.ParseLong("lp_offerho5");
				break;

				case "lp_bidho5":
					this.lp_bidho5 = fieldInfo.FieldValue.ParseLong("lp_bidho5");
				break;

				case "lp_offerho6":
					this.lp_offerho6 = fieldInfo.FieldValue.ParseLong("lp_offerho6");
				break;

				case "lp_bidho6":
					this.lp_bidho6 = fieldInfo.FieldValue.ParseLong("lp_bidho6");
				break;

				case "lp_offerho7":
					this.lp_offerho7 = fieldInfo.FieldValue.ParseLong("lp_offerho7");
				break;

				case "lp_bidho7":
					this.lp_bidho7 = fieldInfo.FieldValue.ParseLong("lp_bidho7");
				break;

				case "lp_offerho8":
					this.lp_offerho8 = fieldInfo.FieldValue.ParseLong("lp_offerho8");
				break;

				case "lp_bidho8":
					this.lp_bidho8 = fieldInfo.FieldValue.ParseLong("lp_bidho8");
				break;

				case "lp_offerho9":
					this.lp_offerho9 = fieldInfo.FieldValue.ParseLong("lp_offerho9");
				break;

				case "lp_bidho9":
					this.lp_bidho9 = fieldInfo.FieldValue.ParseLong("lp_bidho9");
				break;

				case "lp_offerho10":
					this.lp_offerho10 = fieldInfo.FieldValue.ParseLong("lp_offerho10");
				break;

				case "lp_bidho10":
					this.lp_bidho10 = fieldInfo.FieldValue.ParseLong("lp_bidho10");
				break;

				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
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

				case "totofferrem":
					this.totofferrem = fieldInfo.FieldValue.ParseLong("totofferrem");
				break;

				case "totbidrem":
					this.totbidrem = fieldInfo.FieldValue.ParseLong("totbidrem");
				break;

				case "donsigubun":
					this.donsigubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "alloc_gubun":
					this.alloc_gubun = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public static XRB7_OutBlock FromQuery(XRB7_ query)
		{
			XRB7_OutBlock block = new XRB7_OutBlock();
			block.IsValidData = true;
			block.InvalidReason = "";
			try
			{
				block.hotime = query.GetFieldData(block.GetBlockName(), "hotime").TrimEnd('?'); // char 6
				block.lp_offerho1 = query.GetFieldData(block.GetBlockName(), "lp_offerho1").ParseLong("lp_offerho1"); // long 9
				block.lp_bidho1 = query.GetFieldData(block.GetBlockName(), "lp_bidho1").ParseLong("lp_bidho1"); // long 9
				block.lp_offerho2 = query.GetFieldData(block.GetBlockName(), "lp_offerho2").ParseLong("lp_offerho2"); // long 9
				block.lp_bidho2 = query.GetFieldData(block.GetBlockName(), "lp_bidho2").ParseLong("lp_bidho2"); // long 9
				block.lp_offerho3 = query.GetFieldData(block.GetBlockName(), "lp_offerho3").ParseLong("lp_offerho3"); // long 9
				block.lp_bidho3 = query.GetFieldData(block.GetBlockName(), "lp_bidho3").ParseLong("lp_bidho3"); // long 9
				block.lp_offerho4 = query.GetFieldData(block.GetBlockName(), "lp_offerho4").ParseLong("lp_offerho4"); // long 9
				block.lp_bidho4 = query.GetFieldData(block.GetBlockName(), "lp_bidho4").ParseLong("lp_bidho4"); // long 9
				block.lp_offerho5 = query.GetFieldData(block.GetBlockName(), "lp_offerho5").ParseLong("lp_offerho5"); // long 9
				block.lp_bidho5 = query.GetFieldData(block.GetBlockName(), "lp_bidho5").ParseLong("lp_bidho5"); // long 9
				block.lp_offerho6 = query.GetFieldData(block.GetBlockName(), "lp_offerho6").ParseLong("lp_offerho6"); // long 9
				block.lp_bidho6 = query.GetFieldData(block.GetBlockName(), "lp_bidho6").ParseLong("lp_bidho6"); // long 9
				block.lp_offerho7 = query.GetFieldData(block.GetBlockName(), "lp_offerho7").ParseLong("lp_offerho7"); // long 9
				block.lp_bidho7 = query.GetFieldData(block.GetBlockName(), "lp_bidho7").ParseLong("lp_bidho7"); // long 9
				block.lp_offerho8 = query.GetFieldData(block.GetBlockName(), "lp_offerho8").ParseLong("lp_offerho8"); // long 9
				block.lp_bidho8 = query.GetFieldData(block.GetBlockName(), "lp_bidho8").ParseLong("lp_bidho8"); // long 9
				block.lp_offerho9 = query.GetFieldData(block.GetBlockName(), "lp_offerho9").ParseLong("lp_offerho9"); // long 9
				block.lp_bidho9 = query.GetFieldData(block.GetBlockName(), "lp_bidho9").ParseLong("lp_bidho9"); // long 9
				block.lp_offerho10 = query.GetFieldData(block.GetBlockName(), "lp_offerho10").ParseLong("lp_offerho10"); // long 9
				block.lp_bidho10 = query.GetFieldData(block.GetBlockName(), "lp_bidho10").ParseLong("lp_bidho10"); // long 9
				block.shcode = query.GetFieldData(block.GetBlockName(), "shcode").TrimEnd('?'); // char 6
				block.offerho1 = query.GetFieldData(block.GetBlockName(), "offerho1").ParseLong("offerho1"); // long 7
				block.bidho1 = query.GetFieldData(block.GetBlockName(), "bidho1").ParseLong("bidho1"); // long 7
				block.offerrem1 = query.GetFieldData(block.GetBlockName(), "offerrem1").ParseLong("offerrem1"); // long 9
				block.bidrem1 = query.GetFieldData(block.GetBlockName(), "bidrem1").ParseLong("bidrem1"); // long 9
				block.offerho2 = query.GetFieldData(block.GetBlockName(), "offerho2").ParseLong("offerho2"); // long 7
				block.bidho2 = query.GetFieldData(block.GetBlockName(), "bidho2").ParseLong("bidho2"); // long 7
				block.offerrem2 = query.GetFieldData(block.GetBlockName(), "offerrem2").ParseLong("offerrem2"); // long 9
				block.bidrem2 = query.GetFieldData(block.GetBlockName(), "bidrem2").ParseLong("bidrem2"); // long 9
				block.offerho3 = query.GetFieldData(block.GetBlockName(), "offerho3").ParseLong("offerho3"); // long 7
				block.bidho3 = query.GetFieldData(block.GetBlockName(), "bidho3").ParseLong("bidho3"); // long 7
				block.offerrem3 = query.GetFieldData(block.GetBlockName(), "offerrem3").ParseLong("offerrem3"); // long 9
				block.bidrem3 = query.GetFieldData(block.GetBlockName(), "bidrem3").ParseLong("bidrem3"); // long 9
				block.offerho4 = query.GetFieldData(block.GetBlockName(), "offerho4").ParseLong("offerho4"); // long 7
				block.bidho4 = query.GetFieldData(block.GetBlockName(), "bidho4").ParseLong("bidho4"); // long 7
				block.offerrem4 = query.GetFieldData(block.GetBlockName(), "offerrem4").ParseLong("offerrem4"); // long 9
				block.bidrem4 = query.GetFieldData(block.GetBlockName(), "bidrem4").ParseLong("bidrem4"); // long 9
				block.offerho5 = query.GetFieldData(block.GetBlockName(), "offerho5").ParseLong("offerho5"); // long 7
				block.bidho5 = query.GetFieldData(block.GetBlockName(), "bidho5").ParseLong("bidho5"); // long 7
				block.offerrem5 = query.GetFieldData(block.GetBlockName(), "offerrem5").ParseLong("offerrem5"); // long 9
				block.bidrem5 = query.GetFieldData(block.GetBlockName(), "bidrem5").ParseLong("bidrem5"); // long 9
				block.offerho6 = query.GetFieldData(block.GetBlockName(), "offerho6").ParseLong("offerho6"); // long 7
				block.bidho6 = query.GetFieldData(block.GetBlockName(), "bidho6").ParseLong("bidho6"); // long 7
				block.offerrem6 = query.GetFieldData(block.GetBlockName(), "offerrem6").ParseLong("offerrem6"); // long 9
				block.bidrem6 = query.GetFieldData(block.GetBlockName(), "bidrem6").ParseLong("bidrem6"); // long 9
				block.offerho7 = query.GetFieldData(block.GetBlockName(), "offerho7").ParseLong("offerho7"); // long 7
				block.bidho7 = query.GetFieldData(block.GetBlockName(), "bidho7").ParseLong("bidho7"); // long 7
				block.offerrem7 = query.GetFieldData(block.GetBlockName(), "offerrem7").ParseLong("offerrem7"); // long 9
				block.bidrem7 = query.GetFieldData(block.GetBlockName(), "bidrem7").ParseLong("bidrem7"); // long 9
				block.offerho8 = query.GetFieldData(block.GetBlockName(), "offerho8").ParseLong("offerho8"); // long 7
				block.bidho8 = query.GetFieldData(block.GetBlockName(), "bidho8").ParseLong("bidho8"); // long 7
				block.offerrem8 = query.GetFieldData(block.GetBlockName(), "offerrem8").ParseLong("offerrem8"); // long 9
				block.bidrem8 = query.GetFieldData(block.GetBlockName(), "bidrem8").ParseLong("bidrem8"); // long 9
				block.offerho9 = query.GetFieldData(block.GetBlockName(), "offerho9").ParseLong("offerho9"); // long 7
				block.bidho9 = query.GetFieldData(block.GetBlockName(), "bidho9").ParseLong("bidho9"); // long 7
				block.offerrem9 = query.GetFieldData(block.GetBlockName(), "offerrem9").ParseLong("offerrem9"); // long 9
				block.bidrem9 = query.GetFieldData(block.GetBlockName(), "bidrem9").ParseLong("bidrem9"); // long 9
				block.offerho10 = query.GetFieldData(block.GetBlockName(), "offerho10").ParseLong("offerho10"); // long 7
				block.bidho10 = query.GetFieldData(block.GetBlockName(), "bidho10").ParseLong("bidho10"); // long 7
				block.offerrem10 = query.GetFieldData(block.GetBlockName(), "offerrem10").ParseLong("offerrem10"); // long 9
				block.bidrem10 = query.GetFieldData(block.GetBlockName(), "bidrem10").ParseLong("bidrem10"); // long 9
				block.totofferrem = query.GetFieldData(block.GetBlockName(), "totofferrem").ParseLong("totofferrem"); // long 9
				block.totbidrem = query.GetFieldData(block.GetBlockName(), "totbidrem").ParseLong("totbidrem"); // long 9
				block.donsigubun = query.GetFieldData(block.GetBlockName(), "donsigubun").FirstOrDefault(); // char 1
				block.alloc_gubun = query.GetFieldData(block.GetBlockName(), "alloc_gubun").FirstOrDefault(); // char 1

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (hotime?.Length > 6) return false; // char 6
			if (lp_offerho1.ToString().Length > 9) return false; // long 9
			if (lp_bidho1.ToString().Length > 9) return false; // long 9
			if (lp_offerho2.ToString().Length > 9) return false; // long 9
			if (lp_bidho2.ToString().Length > 9) return false; // long 9
			if (lp_offerho3.ToString().Length > 9) return false; // long 9
			if (lp_bidho3.ToString().Length > 9) return false; // long 9
			if (lp_offerho4.ToString().Length > 9) return false; // long 9
			if (lp_bidho4.ToString().Length > 9) return false; // long 9
			if (lp_offerho5.ToString().Length > 9) return false; // long 9
			if (lp_bidho5.ToString().Length > 9) return false; // long 9
			if (lp_offerho6.ToString().Length > 9) return false; // long 9
			if (lp_bidho6.ToString().Length > 9) return false; // long 9
			if (lp_offerho7.ToString().Length > 9) return false; // long 9
			if (lp_bidho7.ToString().Length > 9) return false; // long 9
			if (lp_offerho8.ToString().Length > 9) return false; // long 9
			if (lp_bidho8.ToString().Length > 9) return false; // long 9
			if (lp_offerho9.ToString().Length > 9) return false; // long 9
			if (lp_bidho9.ToString().Length > 9) return false; // long 9
			if (lp_offerho10.ToString().Length > 9) return false; // long 9
			if (lp_bidho10.ToString().Length > 9) return false; // long 9
			if (shcode?.Length > 6) return false; // char 6
			if (offerho1.ToString().Length > 7) return false; // long 7
			if (bidho1.ToString().Length > 7) return false; // long 7
			if (offerrem1.ToString().Length > 9) return false; // long 9
			if (bidrem1.ToString().Length > 9) return false; // long 9
			if (offerho2.ToString().Length > 7) return false; // long 7
			if (bidho2.ToString().Length > 7) return false; // long 7
			if (offerrem2.ToString().Length > 9) return false; // long 9
			if (bidrem2.ToString().Length > 9) return false; // long 9
			if (offerho3.ToString().Length > 7) return false; // long 7
			if (bidho3.ToString().Length > 7) return false; // long 7
			if (offerrem3.ToString().Length > 9) return false; // long 9
			if (bidrem3.ToString().Length > 9) return false; // long 9
			if (offerho4.ToString().Length > 7) return false; // long 7
			if (bidho4.ToString().Length > 7) return false; // long 7
			if (offerrem4.ToString().Length > 9) return false; // long 9
			if (bidrem4.ToString().Length > 9) return false; // long 9
			if (offerho5.ToString().Length > 7) return false; // long 7
			if (bidho5.ToString().Length > 7) return false; // long 7
			if (offerrem5.ToString().Length > 9) return false; // long 9
			if (bidrem5.ToString().Length > 9) return false; // long 9
			if (offerho6.ToString().Length > 7) return false; // long 7
			if (bidho6.ToString().Length > 7) return false; // long 7
			if (offerrem6.ToString().Length > 9) return false; // long 9
			if (bidrem6.ToString().Length > 9) return false; // long 9
			if (offerho7.ToString().Length > 7) return false; // long 7
			if (bidho7.ToString().Length > 7) return false; // long 7
			if (offerrem7.ToString().Length > 9) return false; // long 9
			if (bidrem7.ToString().Length > 9) return false; // long 9
			if (offerho8.ToString().Length > 7) return false; // long 7
			if (bidho8.ToString().Length > 7) return false; // long 7
			if (offerrem8.ToString().Length > 9) return false; // long 9
			if (bidrem8.ToString().Length > 9) return false; // long 9
			if (offerho9.ToString().Length > 7) return false; // long 7
			if (bidho9.ToString().Length > 7) return false; // long 7
			if (offerrem9.ToString().Length > 9) return false; // long 9
			if (bidrem9.ToString().Length > 9) return false; // long 9
			if (offerho10.ToString().Length > 7) return false; // long 7
			if (bidho10.ToString().Length > 7) return false; // long 7
			if (offerrem10.ToString().Length > 9) return false; // long 9
			if (bidrem10.ToString().Length > 9) return false; // long 9
			if (totofferrem.ToString().Length > 9) return false; // long 9
			if (totbidrem.ToString().Length > 9) return false; // long 9
			// donsigubun char 1
			// alloc_gubun char 1

			return true;
		}
	}

	/// <summary>
	/// ETF호가잔량(B7)
	/// </summary>
	public partial class XRB7_ : XingReal
	{
		/// <summary>
		/// B7_
		/// </summary>
		public const string _typeName = "B7_";
		/// <summary>
		/// ETF호가잔량(B7)
		/// </summary>
		public const string _typeDesc = "ETF호가잔량(B7)";
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
		/// B7_
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// ETF호가잔량(B7)
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

		/// <summary>
		/// ETF호가잔량(B7)
		/// </summary>
		public XRB7_() : base("B7_") { }


		public bool SetBlock(XRB7_InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaReal.SetFieldData(block.GetBlockName(), "shcode", block.shcode); // char 6

			return true;
		}

		public XRB7_OutBlock GetBlock()
		{
			XRB7_OutBlock instance = XRB7_OutBlock.FromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XRB7_OutBlock),

		};

	}

}
