using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XRDH1InBlock : XingBlock
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

	public partial class XRDH1OutBlock : XingBlock
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
		/// 시간외단일가호가시간
		/// </summary>
		[XAQueryFieldAttribute("dan_hotime", "시간외단일가호가시간", "char", "6")]
		public string dan_hotime;
		/// <summary>
		/// 시간외단일가장구분
		/// </summary>
		[XAQueryFieldAttribute("dan_hstatus", "시간외단일가장구분", "char", "2")]
		public string dan_hstatus;
		/// <summary>
		/// 시간외단일가매도호가1
		/// </summary>
		[XAQueryFieldAttribute("dan_offerho1", "시간외단일가매도호가1", "long", "8")]
		public long dan_offerho1;
		/// <summary>
		/// 시간외단일가매수호가1
		/// </summary>
		[XAQueryFieldAttribute("dan_bidho1", "시간외단일가매수호가1", "long", "8")]
		public long dan_bidho1;
		/// <summary>
		/// 시간외단일가매도호가잔량1
		/// </summary>
		[XAQueryFieldAttribute("dan_offerrem1", "시간외단일가매도호가잔량1", "long", "12")]
		public long dan_offerrem1;
		/// <summary>
		/// 시간외단일가매수호가잔량1
		/// </summary>
		[XAQueryFieldAttribute("dan_bidrem1", "시간외단일가매수호가잔량1", "long", "12")]
		public long dan_bidrem1;
		/// <summary>
		/// 시간외단일가직전매도대비수량1
		/// </summary>
		[XAQueryFieldAttribute("dan_preoffercha1", "시간외단일가직전매도대비수량1", "long", "12")]
		public long dan_preoffercha1;
		/// <summary>
		/// 시간외단일가직전매수대비수량1
		/// </summary>
		[XAQueryFieldAttribute("dan_prebidcha1", "시간외단일가직전매수대비수량1", "long", "12")]
		public long dan_prebidcha1;
		/// <summary>
		/// 시간외단일가매도호가2
		/// </summary>
		[XAQueryFieldAttribute("dan_offerho2", "시간외단일가매도호가2", "long", "8")]
		public long dan_offerho2;
		/// <summary>
		/// 시간외단일가매수호가2
		/// </summary>
		[XAQueryFieldAttribute("dan_bidho2", "시간외단일가매수호가2", "long", "8")]
		public long dan_bidho2;
		/// <summary>
		/// 시간외단일가매도호가잔량2
		/// </summary>
		[XAQueryFieldAttribute("dan_offerrem2", "시간외단일가매도호가잔량2", "long", "12")]
		public long dan_offerrem2;
		/// <summary>
		/// 시간외단일가매수호가잔량2
		/// </summary>
		[XAQueryFieldAttribute("dan_bidrem2", "시간외단일가매수호가잔량2", "long", "12")]
		public long dan_bidrem2;
		/// <summary>
		/// 시간외단일가직전매도대비수량2
		/// </summary>
		[XAQueryFieldAttribute("dan_preoffercha2", "시간외단일가직전매도대비수량2", "long", "12")]
		public long dan_preoffercha2;
		/// <summary>
		/// 시간외단일가직전매수대비수량2
		/// </summary>
		[XAQueryFieldAttribute("dan_prebidcha2", "시간외단일가직전매수대비수량2", "long", "12")]
		public long dan_prebidcha2;
		/// <summary>
		/// 시간외단일가매도호가3
		/// </summary>
		[XAQueryFieldAttribute("dan_offerho3", "시간외단일가매도호가3", "long", "8")]
		public long dan_offerho3;
		/// <summary>
		/// 시간외단일가매수호가3
		/// </summary>
		[XAQueryFieldAttribute("dan_bidho3", "시간외단일가매수호가3", "long", "8")]
		public long dan_bidho3;
		/// <summary>
		/// 시간외단일가매도호가잔량3
		/// </summary>
		[XAQueryFieldAttribute("dan_offerrem3", "시간외단일가매도호가잔량3", "long", "12")]
		public long dan_offerrem3;
		/// <summary>
		/// 시간외단일가매수호가잔량3
		/// </summary>
		[XAQueryFieldAttribute("dan_bidrem3", "시간외단일가매수호가잔량3", "long", "12")]
		public long dan_bidrem3;
		/// <summary>
		/// 시간외단일가직전매도대비수량3
		/// </summary>
		[XAQueryFieldAttribute("dan_preoffercha3", "시간외단일가직전매도대비수량3", "long", "12")]
		public long dan_preoffercha3;
		/// <summary>
		/// 시간외단일가직전매수대비수량3
		/// </summary>
		[XAQueryFieldAttribute("dan_prebidcha3", "시간외단일가직전매수대비수량3", "long", "12")]
		public long dan_prebidcha3;
		/// <summary>
		/// 시간외단일가매도호가4
		/// </summary>
		[XAQueryFieldAttribute("dan_offerho4", "시간외단일가매도호가4", "long", "8")]
		public long dan_offerho4;
		/// <summary>
		/// 시간외단일가매수호가4
		/// </summary>
		[XAQueryFieldAttribute("dan_bidho4", "시간외단일가매수호가4", "long", "8")]
		public long dan_bidho4;
		/// <summary>
		/// 시간외단일가매도호가잔량4
		/// </summary>
		[XAQueryFieldAttribute("dan_offerrem4", "시간외단일가매도호가잔량4", "long", "12")]
		public long dan_offerrem4;
		/// <summary>
		/// 시간외단일가매수호가잔량4
		/// </summary>
		[XAQueryFieldAttribute("dan_bidrem4", "시간외단일가매수호가잔량4", "long", "12")]
		public long dan_bidrem4;
		/// <summary>
		/// 시간외단일가직전매도대비수량4
		/// </summary>
		[XAQueryFieldAttribute("dan_preoffercha4", "시간외단일가직전매도대비수량4", "long", "12")]
		public long dan_preoffercha4;
		/// <summary>
		/// 시간외단일가직전매수대비수량4
		/// </summary>
		[XAQueryFieldAttribute("dan_prebidcha4", "시간외단일가직전매수대비수량4", "long", "12")]
		public long dan_prebidcha4;
		/// <summary>
		/// 시간외단일가매도호가5
		/// </summary>
		[XAQueryFieldAttribute("dan_offerho5", "시간외단일가매도호가5", "long", "8")]
		public long dan_offerho5;
		/// <summary>
		/// 시간외단일가매수호가5
		/// </summary>
		[XAQueryFieldAttribute("dan_bidho5", "시간외단일가매수호가5", "long", "8")]
		public long dan_bidho5;
		/// <summary>
		/// 시간외단일가매도호가잔량5
		/// </summary>
		[XAQueryFieldAttribute("dan_offerrem5", "시간외단일가매도호가잔량5", "long", "12")]
		public long dan_offerrem5;
		/// <summary>
		/// 시간외단일가매수호가잔량5
		/// </summary>
		[XAQueryFieldAttribute("dan_bidrem5", "시간외단일가매수호가잔량5", "long", "12")]
		public long dan_bidrem5;
		/// <summary>
		/// 시간외단일가직전매도대비수량5
		/// </summary>
		[XAQueryFieldAttribute("dan_preoffercha5", "시간외단일가직전매도대비수량5", "long", "12")]
		public long dan_preoffercha5;
		/// <summary>
		/// 시간외단일가직전매수대비수량5
		/// </summary>
		[XAQueryFieldAttribute("dan_prebidcha5", "시간외단일가직전매수대비수량5", "long", "12")]
		public long dan_prebidcha5;
		/// <summary>
		/// 시간외단일가총매도호가잔량
		/// </summary>
		[XAQueryFieldAttribute("dan_totofferrem", "시간외단일가총매도호가잔량", "long", "12")]
		public long dan_totofferrem;
		/// <summary>
		/// 시간외단일가총매수호가잔량
		/// </summary>
		[XAQueryFieldAttribute("dan_totbidrem", "시간외단일가총매수호가잔량", "long", "12")]
		public long dan_totbidrem;
		/// <summary>
		/// 시간외단일가직전매도호가총대비수량
		/// </summary>
		[XAQueryFieldAttribute("dan_preoffercha", "시간외단일가직전매도호가총대비수량", "long", "12")]
		public long dan_preoffercha;
		/// <summary>
		/// 시간외단일가직전매수호가총대비수량
		/// </summary>
		[XAQueryFieldAttribute("dan_prebidcha", "시간외단일가직전매수호가총대비수량", "long", "12")]
		public long dan_prebidcha;
		/// <summary>
		/// 시간외단일가예상체결가격
		/// </summary>
		[XAQueryFieldAttribute("dan_yeprice", "시간외단일가예상체결가격", "long", "8")]
		public long dan_yeprice;
		/// <summary>
		/// 시간외단일가예상체결수량
		/// </summary>
		[XAQueryFieldAttribute("dan_yevolume", "시간외단일가예상체결수량", "long", "12")]
		public long dan_yevolume;
		/// <summary>
		/// 시간외단일가예상가직전가대비구분
		/// </summary>
		[XAQueryFieldAttribute("dan_preysign", "시간외단일가예상가직전가대비구분", "char", "1")]
		public char dan_preysign;
		/// <summary>
		/// 시간외단일가예상가직전가대비
		/// </summary>
		[XAQueryFieldAttribute("dan_preychange", "시간외단일가예상가직전가대비", "long", "8")]
		public long dan_preychange;
		/// <summary>
		/// 시간외단일가예상가전일가대비구분
		/// </summary>
		[XAQueryFieldAttribute("dan_jnilysign", "시간외단일가예상가전일가대비구분", "char", "1")]
		public char dan_jnilysign;
		/// <summary>
		/// 시간외단일가예상가전일가대비
		/// </summary>
		[XAQueryFieldAttribute("dan_jnilychange", "시간외단일가예상가전일가대비", "long", "8")]
		public long dan_jnilychange;
		/// <summary>
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("shcode", "단축코드", "char", "6")]
		public string shcode;
		/// <summary>
		/// 누적거래량
		/// </summary>
		[XAQueryFieldAttribute("volume", "누적거래량", "long", "12")]
		public long volume;

		public static class F
		{
			/// <summary>
			/// 시간외단일가호가시간
			/// </summary>
			public const string dan_hotime = "dan_hotime";
			/// <summary>
			/// 시간외단일가장구분
			/// </summary>
			public const string dan_hstatus = "dan_hstatus";
			/// <summary>
			/// 시간외단일가매도호가1
			/// </summary>
			public const string dan_offerho1 = "dan_offerho1";
			/// <summary>
			/// 시간외단일가매수호가1
			/// </summary>
			public const string dan_bidho1 = "dan_bidho1";
			/// <summary>
			/// 시간외단일가매도호가잔량1
			/// </summary>
			public const string dan_offerrem1 = "dan_offerrem1";
			/// <summary>
			/// 시간외단일가매수호가잔량1
			/// </summary>
			public const string dan_bidrem1 = "dan_bidrem1";
			/// <summary>
			/// 시간외단일가직전매도대비수량1
			/// </summary>
			public const string dan_preoffercha1 = "dan_preoffercha1";
			/// <summary>
			/// 시간외단일가직전매수대비수량1
			/// </summary>
			public const string dan_prebidcha1 = "dan_prebidcha1";
			/// <summary>
			/// 시간외단일가매도호가2
			/// </summary>
			public const string dan_offerho2 = "dan_offerho2";
			/// <summary>
			/// 시간외단일가매수호가2
			/// </summary>
			public const string dan_bidho2 = "dan_bidho2";
			/// <summary>
			/// 시간외단일가매도호가잔량2
			/// </summary>
			public const string dan_offerrem2 = "dan_offerrem2";
			/// <summary>
			/// 시간외단일가매수호가잔량2
			/// </summary>
			public const string dan_bidrem2 = "dan_bidrem2";
			/// <summary>
			/// 시간외단일가직전매도대비수량2
			/// </summary>
			public const string dan_preoffercha2 = "dan_preoffercha2";
			/// <summary>
			/// 시간외단일가직전매수대비수량2
			/// </summary>
			public const string dan_prebidcha2 = "dan_prebidcha2";
			/// <summary>
			/// 시간외단일가매도호가3
			/// </summary>
			public const string dan_offerho3 = "dan_offerho3";
			/// <summary>
			/// 시간외단일가매수호가3
			/// </summary>
			public const string dan_bidho3 = "dan_bidho3";
			/// <summary>
			/// 시간외단일가매도호가잔량3
			/// </summary>
			public const string dan_offerrem3 = "dan_offerrem3";
			/// <summary>
			/// 시간외단일가매수호가잔량3
			/// </summary>
			public const string dan_bidrem3 = "dan_bidrem3";
			/// <summary>
			/// 시간외단일가직전매도대비수량3
			/// </summary>
			public const string dan_preoffercha3 = "dan_preoffercha3";
			/// <summary>
			/// 시간외단일가직전매수대비수량3
			/// </summary>
			public const string dan_prebidcha3 = "dan_prebidcha3";
			/// <summary>
			/// 시간외단일가매도호가4
			/// </summary>
			public const string dan_offerho4 = "dan_offerho4";
			/// <summary>
			/// 시간외단일가매수호가4
			/// </summary>
			public const string dan_bidho4 = "dan_bidho4";
			/// <summary>
			/// 시간외단일가매도호가잔량4
			/// </summary>
			public const string dan_offerrem4 = "dan_offerrem4";
			/// <summary>
			/// 시간외단일가매수호가잔량4
			/// </summary>
			public const string dan_bidrem4 = "dan_bidrem4";
			/// <summary>
			/// 시간외단일가직전매도대비수량4
			/// </summary>
			public const string dan_preoffercha4 = "dan_preoffercha4";
			/// <summary>
			/// 시간외단일가직전매수대비수량4
			/// </summary>
			public const string dan_prebidcha4 = "dan_prebidcha4";
			/// <summary>
			/// 시간외단일가매도호가5
			/// </summary>
			public const string dan_offerho5 = "dan_offerho5";
			/// <summary>
			/// 시간외단일가매수호가5
			/// </summary>
			public const string dan_bidho5 = "dan_bidho5";
			/// <summary>
			/// 시간외단일가매도호가잔량5
			/// </summary>
			public const string dan_offerrem5 = "dan_offerrem5";
			/// <summary>
			/// 시간외단일가매수호가잔량5
			/// </summary>
			public const string dan_bidrem5 = "dan_bidrem5";
			/// <summary>
			/// 시간외단일가직전매도대비수량5
			/// </summary>
			public const string dan_preoffercha5 = "dan_preoffercha5";
			/// <summary>
			/// 시간외단일가직전매수대비수량5
			/// </summary>
			public const string dan_prebidcha5 = "dan_prebidcha5";
			/// <summary>
			/// 시간외단일가총매도호가잔량
			/// </summary>
			public const string dan_totofferrem = "dan_totofferrem";
			/// <summary>
			/// 시간외단일가총매수호가잔량
			/// </summary>
			public const string dan_totbidrem = "dan_totbidrem";
			/// <summary>
			/// 시간외단일가직전매도호가총대비수량
			/// </summary>
			public const string dan_preoffercha = "dan_preoffercha";
			/// <summary>
			/// 시간외단일가직전매수호가총대비수량
			/// </summary>
			public const string dan_prebidcha = "dan_prebidcha";
			/// <summary>
			/// 시간외단일가예상체결가격
			/// </summary>
			public const string dan_yeprice = "dan_yeprice";
			/// <summary>
			/// 시간외단일가예상체결수량
			/// </summary>
			public const string dan_yevolume = "dan_yevolume";
			/// <summary>
			/// 시간외단일가예상가직전가대비구분
			/// </summary>
			public const string dan_preysign = "dan_preysign";
			/// <summary>
			/// 시간외단일가예상가직전가대비
			/// </summary>
			public const string dan_preychange = "dan_preychange";
			/// <summary>
			/// 시간외단일가예상가전일가대비구분
			/// </summary>
			public const string dan_jnilysign = "dan_jnilysign";
			/// <summary>
			/// 시간외단일가예상가전일가대비
			/// </summary>
			public const string dan_jnilychange = "dan_jnilychange";
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 누적거래량
			/// </summary>
			public const string volume = "volume";
		}

		public static string[] AllFields = new string[]
		{
			F.dan_hotime,
			F.dan_hstatus,
			F.dan_offerho1,
			F.dan_bidho1,
			F.dan_offerrem1,
			F.dan_bidrem1,
			F.dan_preoffercha1,
			F.dan_prebidcha1,
			F.dan_offerho2,
			F.dan_bidho2,
			F.dan_offerrem2,
			F.dan_bidrem2,
			F.dan_preoffercha2,
			F.dan_prebidcha2,
			F.dan_offerho3,
			F.dan_bidho3,
			F.dan_offerrem3,
			F.dan_bidrem3,
			F.dan_preoffercha3,
			F.dan_prebidcha3,
			F.dan_offerho4,
			F.dan_bidho4,
			F.dan_offerrem4,
			F.dan_bidrem4,
			F.dan_preoffercha4,
			F.dan_prebidcha4,
			F.dan_offerho5,
			F.dan_bidho5,
			F.dan_offerrem5,
			F.dan_bidrem5,
			F.dan_preoffercha5,
			F.dan_prebidcha5,
			F.dan_totofferrem,
			F.dan_totbidrem,
			F.dan_preoffercha,
			F.dan_prebidcha,
			F.dan_yeprice,
			F.dan_yevolume,
			F.dan_preysign,
			F.dan_preychange,
			F.dan_jnilysign,
			F.dan_jnilychange,
			F.shcode,
			F.volume,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["dan_hotime"] = new XAQueryFieldInfo("char", dan_hotime, dan_hotime, "시간외단일가호가시간", (decimal)6);
			dict["dan_hstatus"] = new XAQueryFieldInfo("char", dan_hstatus, dan_hstatus, "시간외단일가장구분", (decimal)2);
			dict["dan_offerho1"] = new XAQueryFieldInfo("long", dan_offerho1, dan_offerho1.ToString("d8"), "시간외단일가매도호가1", (decimal)8);
			dict["dan_bidho1"] = new XAQueryFieldInfo("long", dan_bidho1, dan_bidho1.ToString("d8"), "시간외단일가매수호가1", (decimal)8);
			dict["dan_offerrem1"] = new XAQueryFieldInfo("long", dan_offerrem1, dan_offerrem1.ToString("d12"), "시간외단일가매도호가잔량1", (decimal)12);
			dict["dan_bidrem1"] = new XAQueryFieldInfo("long", dan_bidrem1, dan_bidrem1.ToString("d12"), "시간외단일가매수호가잔량1", (decimal)12);
			dict["dan_preoffercha1"] = new XAQueryFieldInfo("long", dan_preoffercha1, dan_preoffercha1.ToString("d12"), "시간외단일가직전매도대비수량1", (decimal)12);
			dict["dan_prebidcha1"] = new XAQueryFieldInfo("long", dan_prebidcha1, dan_prebidcha1.ToString("d12"), "시간외단일가직전매수대비수량1", (decimal)12);
			dict["dan_offerho2"] = new XAQueryFieldInfo("long", dan_offerho2, dan_offerho2.ToString("d8"), "시간외단일가매도호가2", (decimal)8);
			dict["dan_bidho2"] = new XAQueryFieldInfo("long", dan_bidho2, dan_bidho2.ToString("d8"), "시간외단일가매수호가2", (decimal)8);
			dict["dan_offerrem2"] = new XAQueryFieldInfo("long", dan_offerrem2, dan_offerrem2.ToString("d12"), "시간외단일가매도호가잔량2", (decimal)12);
			dict["dan_bidrem2"] = new XAQueryFieldInfo("long", dan_bidrem2, dan_bidrem2.ToString("d12"), "시간외단일가매수호가잔량2", (decimal)12);
			dict["dan_preoffercha2"] = new XAQueryFieldInfo("long", dan_preoffercha2, dan_preoffercha2.ToString("d12"), "시간외단일가직전매도대비수량2", (decimal)12);
			dict["dan_prebidcha2"] = new XAQueryFieldInfo("long", dan_prebidcha2, dan_prebidcha2.ToString("d12"), "시간외단일가직전매수대비수량2", (decimal)12);
			dict["dan_offerho3"] = new XAQueryFieldInfo("long", dan_offerho3, dan_offerho3.ToString("d8"), "시간외단일가매도호가3", (decimal)8);
			dict["dan_bidho3"] = new XAQueryFieldInfo("long", dan_bidho3, dan_bidho3.ToString("d8"), "시간외단일가매수호가3", (decimal)8);
			dict["dan_offerrem3"] = new XAQueryFieldInfo("long", dan_offerrem3, dan_offerrem3.ToString("d12"), "시간외단일가매도호가잔량3", (decimal)12);
			dict["dan_bidrem3"] = new XAQueryFieldInfo("long", dan_bidrem3, dan_bidrem3.ToString("d12"), "시간외단일가매수호가잔량3", (decimal)12);
			dict["dan_preoffercha3"] = new XAQueryFieldInfo("long", dan_preoffercha3, dan_preoffercha3.ToString("d12"), "시간외단일가직전매도대비수량3", (decimal)12);
			dict["dan_prebidcha3"] = new XAQueryFieldInfo("long", dan_prebidcha3, dan_prebidcha3.ToString("d12"), "시간외단일가직전매수대비수량3", (decimal)12);
			dict["dan_offerho4"] = new XAQueryFieldInfo("long", dan_offerho4, dan_offerho4.ToString("d8"), "시간외단일가매도호가4", (decimal)8);
			dict["dan_bidho4"] = new XAQueryFieldInfo("long", dan_bidho4, dan_bidho4.ToString("d8"), "시간외단일가매수호가4", (decimal)8);
			dict["dan_offerrem4"] = new XAQueryFieldInfo("long", dan_offerrem4, dan_offerrem4.ToString("d12"), "시간외단일가매도호가잔량4", (decimal)12);
			dict["dan_bidrem4"] = new XAQueryFieldInfo("long", dan_bidrem4, dan_bidrem4.ToString("d12"), "시간외단일가매수호가잔량4", (decimal)12);
			dict["dan_preoffercha4"] = new XAQueryFieldInfo("long", dan_preoffercha4, dan_preoffercha4.ToString("d12"), "시간외단일가직전매도대비수량4", (decimal)12);
			dict["dan_prebidcha4"] = new XAQueryFieldInfo("long", dan_prebidcha4, dan_prebidcha4.ToString("d12"), "시간외단일가직전매수대비수량4", (decimal)12);
			dict["dan_offerho5"] = new XAQueryFieldInfo("long", dan_offerho5, dan_offerho5.ToString("d8"), "시간외단일가매도호가5", (decimal)8);
			dict["dan_bidho5"] = new XAQueryFieldInfo("long", dan_bidho5, dan_bidho5.ToString("d8"), "시간외단일가매수호가5", (decimal)8);
			dict["dan_offerrem5"] = new XAQueryFieldInfo("long", dan_offerrem5, dan_offerrem5.ToString("d12"), "시간외단일가매도호가잔량5", (decimal)12);
			dict["dan_bidrem5"] = new XAQueryFieldInfo("long", dan_bidrem5, dan_bidrem5.ToString("d12"), "시간외단일가매수호가잔량5", (decimal)12);
			dict["dan_preoffercha5"] = new XAQueryFieldInfo("long", dan_preoffercha5, dan_preoffercha5.ToString("d12"), "시간외단일가직전매도대비수량5", (decimal)12);
			dict["dan_prebidcha5"] = new XAQueryFieldInfo("long", dan_prebidcha5, dan_prebidcha5.ToString("d12"), "시간외단일가직전매수대비수량5", (decimal)12);
			dict["dan_totofferrem"] = new XAQueryFieldInfo("long", dan_totofferrem, dan_totofferrem.ToString("d12"), "시간외단일가총매도호가잔량", (decimal)12);
			dict["dan_totbidrem"] = new XAQueryFieldInfo("long", dan_totbidrem, dan_totbidrem.ToString("d12"), "시간외단일가총매수호가잔량", (decimal)12);
			dict["dan_preoffercha"] = new XAQueryFieldInfo("long", dan_preoffercha, dan_preoffercha.ToString("d12"), "시간외단일가직전매도호가총대비수량", (decimal)12);
			dict["dan_prebidcha"] = new XAQueryFieldInfo("long", dan_prebidcha, dan_prebidcha.ToString("d12"), "시간외단일가직전매수호가총대비수량", (decimal)12);
			dict["dan_yeprice"] = new XAQueryFieldInfo("long", dan_yeprice, dan_yeprice.ToString("d8"), "시간외단일가예상체결가격", (decimal)8);
			dict["dan_yevolume"] = new XAQueryFieldInfo("long", dan_yevolume, dan_yevolume.ToString("d12"), "시간외단일가예상체결수량", (decimal)12);
			dict["dan_preysign"] = new XAQueryFieldInfo("char", dan_preysign, dan_preysign.ToString(), "시간외단일가예상가직전가대비구분", (decimal)1);
			dict["dan_preychange"] = new XAQueryFieldInfo("long", dan_preychange, dan_preychange.ToString("d8"), "시간외단일가예상가직전가대비", (decimal)8);
			dict["dan_jnilysign"] = new XAQueryFieldInfo("char", dan_jnilysign, dan_jnilysign.ToString(), "시간외단일가예상가전일가대비구분", (decimal)1);
			dict["dan_jnilychange"] = new XAQueryFieldInfo("long", dan_jnilychange, dan_jnilychange.ToString("d8"), "시간외단일가예상가전일가대비", (decimal)8);
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)6);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "누적거래량", (decimal)12);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "dan_hotime":
					this.dan_hotime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "dan_hstatus":
					this.dan_hstatus = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "dan_offerho1":
					this.dan_offerho1 = fieldInfo.FieldValue.ParseLong("dan_offerho1");
				break;

				case "dan_bidho1":
					this.dan_bidho1 = fieldInfo.FieldValue.ParseLong("dan_bidho1");
				break;

				case "dan_offerrem1":
					this.dan_offerrem1 = fieldInfo.FieldValue.ParseLong("dan_offerrem1");
				break;

				case "dan_bidrem1":
					this.dan_bidrem1 = fieldInfo.FieldValue.ParseLong("dan_bidrem1");
				break;

				case "dan_preoffercha1":
					this.dan_preoffercha1 = fieldInfo.FieldValue.ParseLong("dan_preoffercha1");
				break;

				case "dan_prebidcha1":
					this.dan_prebidcha1 = fieldInfo.FieldValue.ParseLong("dan_prebidcha1");
				break;

				case "dan_offerho2":
					this.dan_offerho2 = fieldInfo.FieldValue.ParseLong("dan_offerho2");
				break;

				case "dan_bidho2":
					this.dan_bidho2 = fieldInfo.FieldValue.ParseLong("dan_bidho2");
				break;

				case "dan_offerrem2":
					this.dan_offerrem2 = fieldInfo.FieldValue.ParseLong("dan_offerrem2");
				break;

				case "dan_bidrem2":
					this.dan_bidrem2 = fieldInfo.FieldValue.ParseLong("dan_bidrem2");
				break;

				case "dan_preoffercha2":
					this.dan_preoffercha2 = fieldInfo.FieldValue.ParseLong("dan_preoffercha2");
				break;

				case "dan_prebidcha2":
					this.dan_prebidcha2 = fieldInfo.FieldValue.ParseLong("dan_prebidcha2");
				break;

				case "dan_offerho3":
					this.dan_offerho3 = fieldInfo.FieldValue.ParseLong("dan_offerho3");
				break;

				case "dan_bidho3":
					this.dan_bidho3 = fieldInfo.FieldValue.ParseLong("dan_bidho3");
				break;

				case "dan_offerrem3":
					this.dan_offerrem3 = fieldInfo.FieldValue.ParseLong("dan_offerrem3");
				break;

				case "dan_bidrem3":
					this.dan_bidrem3 = fieldInfo.FieldValue.ParseLong("dan_bidrem3");
				break;

				case "dan_preoffercha3":
					this.dan_preoffercha3 = fieldInfo.FieldValue.ParseLong("dan_preoffercha3");
				break;

				case "dan_prebidcha3":
					this.dan_prebidcha3 = fieldInfo.FieldValue.ParseLong("dan_prebidcha3");
				break;

				case "dan_offerho4":
					this.dan_offerho4 = fieldInfo.FieldValue.ParseLong("dan_offerho4");
				break;

				case "dan_bidho4":
					this.dan_bidho4 = fieldInfo.FieldValue.ParseLong("dan_bidho4");
				break;

				case "dan_offerrem4":
					this.dan_offerrem4 = fieldInfo.FieldValue.ParseLong("dan_offerrem4");
				break;

				case "dan_bidrem4":
					this.dan_bidrem4 = fieldInfo.FieldValue.ParseLong("dan_bidrem4");
				break;

				case "dan_preoffercha4":
					this.dan_preoffercha4 = fieldInfo.FieldValue.ParseLong("dan_preoffercha4");
				break;

				case "dan_prebidcha4":
					this.dan_prebidcha4 = fieldInfo.FieldValue.ParseLong("dan_prebidcha4");
				break;

				case "dan_offerho5":
					this.dan_offerho5 = fieldInfo.FieldValue.ParseLong("dan_offerho5");
				break;

				case "dan_bidho5":
					this.dan_bidho5 = fieldInfo.FieldValue.ParseLong("dan_bidho5");
				break;

				case "dan_offerrem5":
					this.dan_offerrem5 = fieldInfo.FieldValue.ParseLong("dan_offerrem5");
				break;

				case "dan_bidrem5":
					this.dan_bidrem5 = fieldInfo.FieldValue.ParseLong("dan_bidrem5");
				break;

				case "dan_preoffercha5":
					this.dan_preoffercha5 = fieldInfo.FieldValue.ParseLong("dan_preoffercha5");
				break;

				case "dan_prebidcha5":
					this.dan_prebidcha5 = fieldInfo.FieldValue.ParseLong("dan_prebidcha5");
				break;

				case "dan_totofferrem":
					this.dan_totofferrem = fieldInfo.FieldValue.ParseLong("dan_totofferrem");
				break;

				case "dan_totbidrem":
					this.dan_totbidrem = fieldInfo.FieldValue.ParseLong("dan_totbidrem");
				break;

				case "dan_preoffercha":
					this.dan_preoffercha = fieldInfo.FieldValue.ParseLong("dan_preoffercha");
				break;

				case "dan_prebidcha":
					this.dan_prebidcha = fieldInfo.FieldValue.ParseLong("dan_prebidcha");
				break;

				case "dan_yeprice":
					this.dan_yeprice = fieldInfo.FieldValue.ParseLong("dan_yeprice");
				break;

				case "dan_yevolume":
					this.dan_yevolume = fieldInfo.FieldValue.ParseLong("dan_yevolume");
				break;

				case "dan_preysign":
					this.dan_preysign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "dan_preychange":
					this.dan_preychange = fieldInfo.FieldValue.ParseLong("dan_preychange");
				break;

				case "dan_jnilysign":
					this.dan_jnilysign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "dan_jnilychange":
					this.dan_jnilychange = fieldInfo.FieldValue.ParseLong("dan_jnilychange");
				break;

				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "volume":
					this.volume = fieldInfo.FieldValue.ParseLong("volume");
				break;


			}
		}

		public static XRDH1OutBlock FromQuery(XRDH1 query)
		{
			XRDH1OutBlock block = new XRDH1OutBlock();
			block.IsValidData = true;
			block.InvalidReason = "";
			try
			{
				block.dan_hotime = query.GetFieldData(block.GetBlockName(), "dan_hotime").TrimEnd('?'); // char 6
				block.dan_hstatus = query.GetFieldData(block.GetBlockName(), "dan_hstatus").TrimEnd('?'); // char 2
				block.dan_offerho1 = query.GetFieldData(block.GetBlockName(), "dan_offerho1").ParseLong("dan_offerho1"); // long 8
				block.dan_bidho1 = query.GetFieldData(block.GetBlockName(), "dan_bidho1").ParseLong("dan_bidho1"); // long 8
				block.dan_offerrem1 = query.GetFieldData(block.GetBlockName(), "dan_offerrem1").ParseLong("dan_offerrem1"); // long 12
				block.dan_bidrem1 = query.GetFieldData(block.GetBlockName(), "dan_bidrem1").ParseLong("dan_bidrem1"); // long 12
				block.dan_preoffercha1 = query.GetFieldData(block.GetBlockName(), "dan_preoffercha1").ParseLong("dan_preoffercha1"); // long 12
				block.dan_prebidcha1 = query.GetFieldData(block.GetBlockName(), "dan_prebidcha1").ParseLong("dan_prebidcha1"); // long 12
				block.dan_offerho2 = query.GetFieldData(block.GetBlockName(), "dan_offerho2").ParseLong("dan_offerho2"); // long 8
				block.dan_bidho2 = query.GetFieldData(block.GetBlockName(), "dan_bidho2").ParseLong("dan_bidho2"); // long 8
				block.dan_offerrem2 = query.GetFieldData(block.GetBlockName(), "dan_offerrem2").ParseLong("dan_offerrem2"); // long 12
				block.dan_bidrem2 = query.GetFieldData(block.GetBlockName(), "dan_bidrem2").ParseLong("dan_bidrem2"); // long 12
				block.dan_preoffercha2 = query.GetFieldData(block.GetBlockName(), "dan_preoffercha2").ParseLong("dan_preoffercha2"); // long 12
				block.dan_prebidcha2 = query.GetFieldData(block.GetBlockName(), "dan_prebidcha2").ParseLong("dan_prebidcha2"); // long 12
				block.dan_offerho3 = query.GetFieldData(block.GetBlockName(), "dan_offerho3").ParseLong("dan_offerho3"); // long 8
				block.dan_bidho3 = query.GetFieldData(block.GetBlockName(), "dan_bidho3").ParseLong("dan_bidho3"); // long 8
				block.dan_offerrem3 = query.GetFieldData(block.GetBlockName(), "dan_offerrem3").ParseLong("dan_offerrem3"); // long 12
				block.dan_bidrem3 = query.GetFieldData(block.GetBlockName(), "dan_bidrem3").ParseLong("dan_bidrem3"); // long 12
				block.dan_preoffercha3 = query.GetFieldData(block.GetBlockName(), "dan_preoffercha3").ParseLong("dan_preoffercha3"); // long 12
				block.dan_prebidcha3 = query.GetFieldData(block.GetBlockName(), "dan_prebidcha3").ParseLong("dan_prebidcha3"); // long 12
				block.dan_offerho4 = query.GetFieldData(block.GetBlockName(), "dan_offerho4").ParseLong("dan_offerho4"); // long 8
				block.dan_bidho4 = query.GetFieldData(block.GetBlockName(), "dan_bidho4").ParseLong("dan_bidho4"); // long 8
				block.dan_offerrem4 = query.GetFieldData(block.GetBlockName(), "dan_offerrem4").ParseLong("dan_offerrem4"); // long 12
				block.dan_bidrem4 = query.GetFieldData(block.GetBlockName(), "dan_bidrem4").ParseLong("dan_bidrem4"); // long 12
				block.dan_preoffercha4 = query.GetFieldData(block.GetBlockName(), "dan_preoffercha4").ParseLong("dan_preoffercha4"); // long 12
				block.dan_prebidcha4 = query.GetFieldData(block.GetBlockName(), "dan_prebidcha4").ParseLong("dan_prebidcha4"); // long 12
				block.dan_offerho5 = query.GetFieldData(block.GetBlockName(), "dan_offerho5").ParseLong("dan_offerho5"); // long 8
				block.dan_bidho5 = query.GetFieldData(block.GetBlockName(), "dan_bidho5").ParseLong("dan_bidho5"); // long 8
				block.dan_offerrem5 = query.GetFieldData(block.GetBlockName(), "dan_offerrem5").ParseLong("dan_offerrem5"); // long 12
				block.dan_bidrem5 = query.GetFieldData(block.GetBlockName(), "dan_bidrem5").ParseLong("dan_bidrem5"); // long 12
				block.dan_preoffercha5 = query.GetFieldData(block.GetBlockName(), "dan_preoffercha5").ParseLong("dan_preoffercha5"); // long 12
				block.dan_prebidcha5 = query.GetFieldData(block.GetBlockName(), "dan_prebidcha5").ParseLong("dan_prebidcha5"); // long 12
				block.dan_totofferrem = query.GetFieldData(block.GetBlockName(), "dan_totofferrem").ParseLong("dan_totofferrem"); // long 12
				block.dan_totbidrem = query.GetFieldData(block.GetBlockName(), "dan_totbidrem").ParseLong("dan_totbidrem"); // long 12
				block.dan_preoffercha = query.GetFieldData(block.GetBlockName(), "dan_preoffercha").ParseLong("dan_preoffercha"); // long 12
				block.dan_prebidcha = query.GetFieldData(block.GetBlockName(), "dan_prebidcha").ParseLong("dan_prebidcha"); // long 12
				block.dan_yeprice = query.GetFieldData(block.GetBlockName(), "dan_yeprice").ParseLong("dan_yeprice"); // long 8
				block.dan_yevolume = query.GetFieldData(block.GetBlockName(), "dan_yevolume").ParseLong("dan_yevolume"); // long 12
				block.dan_preysign = query.GetFieldData(block.GetBlockName(), "dan_preysign").FirstOrDefault(); // char 1
				block.dan_preychange = query.GetFieldData(block.GetBlockName(), "dan_preychange").ParseLong("dan_preychange"); // long 8
				block.dan_jnilysign = query.GetFieldData(block.GetBlockName(), "dan_jnilysign").FirstOrDefault(); // char 1
				block.dan_jnilychange = query.GetFieldData(block.GetBlockName(), "dan_jnilychange").ParseLong("dan_jnilychange"); // long 8
				block.shcode = query.GetFieldData(block.GetBlockName(), "shcode").TrimEnd('?'); // char 6
				block.volume = query.GetFieldData(block.GetBlockName(), "volume").ParseLong("volume"); // long 12

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (dan_hotime?.Length > 6) return false; // char 6
			if (dan_hstatus?.Length > 2) return false; // char 2
			if (dan_offerho1.ToString().Length > 8) return false; // long 8
			if (dan_bidho1.ToString().Length > 8) return false; // long 8
			if (dan_offerrem1.ToString().Length > 12) return false; // long 12
			if (dan_bidrem1.ToString().Length > 12) return false; // long 12
			if (dan_preoffercha1.ToString().Length > 12) return false; // long 12
			if (dan_prebidcha1.ToString().Length > 12) return false; // long 12
			if (dan_offerho2.ToString().Length > 8) return false; // long 8
			if (dan_bidho2.ToString().Length > 8) return false; // long 8
			if (dan_offerrem2.ToString().Length > 12) return false; // long 12
			if (dan_bidrem2.ToString().Length > 12) return false; // long 12
			if (dan_preoffercha2.ToString().Length > 12) return false; // long 12
			if (dan_prebidcha2.ToString().Length > 12) return false; // long 12
			if (dan_offerho3.ToString().Length > 8) return false; // long 8
			if (dan_bidho3.ToString().Length > 8) return false; // long 8
			if (dan_offerrem3.ToString().Length > 12) return false; // long 12
			if (dan_bidrem3.ToString().Length > 12) return false; // long 12
			if (dan_preoffercha3.ToString().Length > 12) return false; // long 12
			if (dan_prebidcha3.ToString().Length > 12) return false; // long 12
			if (dan_offerho4.ToString().Length > 8) return false; // long 8
			if (dan_bidho4.ToString().Length > 8) return false; // long 8
			if (dan_offerrem4.ToString().Length > 12) return false; // long 12
			if (dan_bidrem4.ToString().Length > 12) return false; // long 12
			if (dan_preoffercha4.ToString().Length > 12) return false; // long 12
			if (dan_prebidcha4.ToString().Length > 12) return false; // long 12
			if (dan_offerho5.ToString().Length > 8) return false; // long 8
			if (dan_bidho5.ToString().Length > 8) return false; // long 8
			if (dan_offerrem5.ToString().Length > 12) return false; // long 12
			if (dan_bidrem5.ToString().Length > 12) return false; // long 12
			if (dan_preoffercha5.ToString().Length > 12) return false; // long 12
			if (dan_prebidcha5.ToString().Length > 12) return false; // long 12
			if (dan_totofferrem.ToString().Length > 12) return false; // long 12
			if (dan_totbidrem.ToString().Length > 12) return false; // long 12
			if (dan_preoffercha.ToString().Length > 12) return false; // long 12
			if (dan_prebidcha.ToString().Length > 12) return false; // long 12
			if (dan_yeprice.ToString().Length > 8) return false; // long 8
			if (dan_yevolume.ToString().Length > 12) return false; // long 12
			// dan_preysign char 1
			if (dan_preychange.ToString().Length > 8) return false; // long 8
			// dan_jnilysign char 1
			if (dan_jnilychange.ToString().Length > 8) return false; // long 8
			if (shcode?.Length > 6) return false; // char 6
			if (volume.ToString().Length > 12) return false; // long 12

			return true;
		}
	}

	/// <summary>
	/// KOSPI시간외단일가호가잔량(DH1)
	/// </summary>
	public partial class XRDH1 : XingReal
	{
		/// <summary>
		/// DH1
		/// </summary>
		public const string _typeName = "DH1";
		/// <summary>
		/// KOSPI시간외단일가호가잔량(DH1)
		/// </summary>
		public const string _typeDesc = "KOSPI시간외단일가호가잔량(DH1)";
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
		/// DH1
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// KOSPI시간외단일가호가잔량(DH1)
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
		/// KOSPI시간외단일가호가잔량(DH1)
		/// </summary>
		public XRDH1() : base("DH1") { }


		public bool SetBlock(XRDH1InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaReal.SetFieldData(block.GetBlockName(), "shcode", block.shcode); // char 6

			return true;
		}

		public XRDH1OutBlock GetBlock()
		{
			XRDH1OutBlock instance = XRDH1OutBlock.FromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XRDH1OutBlock),

		};

	}

}
