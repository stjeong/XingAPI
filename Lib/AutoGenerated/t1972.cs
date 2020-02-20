using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1972InBlock : XingBlock
	{
		/// <summary>
		/// t1972InBlock
		/// </summary>
		public const string _blockName = "t1972InBlock";
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
		/// t1972InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1972InBlock
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

	public partial class XQt1972OutBlock : XingBlock
	{
		/// <summary>
		/// t1972OutBlock
		/// </summary>
		public const string _blockName = "t1972OutBlock";
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
		/// t1972OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1972OutBlock
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
		[XAQueryFieldAttribute("hname", "한글명", "char", "40")]
		public string hname;
		/// <summary>
		/// 표준코드
		/// </summary>
		[XAQueryFieldAttribute("expcode", "표준코드", "char", "12")]
		public string expcode;
		/// <summary>
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("shcode", "단축코드", "char", "9")]
		public string shcode;
		/// <summary>
		/// 매도증권사코드1
		/// </summary>
		[XAQueryFieldAttribute("offerno1", "매도증권사코드1", "char", "6")]
		public string offerno1;
		/// <summary>
		/// 매수증권사코드1
		/// </summary>
		[XAQueryFieldAttribute("bidno1", "매수증권사코드1", "char", "6")]
		public string bidno1;
		/// <summary>
		/// 총매도수량1
		/// </summary>
		[XAQueryFieldAttribute("dvol1", "총매도수량1", "long", "12")]
		public long dvol1;
		/// <summary>
		/// 총매수수량1
		/// </summary>
		[XAQueryFieldAttribute("svol1", "총매수수량1", "long", "12")]
		public long svol1;
		/// <summary>
		/// 매도증감1
		/// </summary>
		[XAQueryFieldAttribute("dcha1", "매도증감1", "long", "12")]
		public long dcha1;
		/// <summary>
		/// 매수증감1
		/// </summary>
		[XAQueryFieldAttribute("scha1", "매수증감1", "long", "12")]
		public long scha1;
		/// <summary>
		/// 매도비율1
		/// </summary>
		[XAQueryFieldAttribute("ddiff1", "매도비율1", "float", "6.2")]
		public float ddiff1;
		/// <summary>
		/// 매수비율1
		/// </summary>
		[XAQueryFieldAttribute("sdiff1", "매수비율1", "float", "6.2")]
		public float sdiff1;
		/// <summary>
		/// 매도증권사코드2
		/// </summary>
		[XAQueryFieldAttribute("offerno2", "매도증권사코드2", "char", "6")]
		public string offerno2;
		/// <summary>
		/// 매수증권사코드2
		/// </summary>
		[XAQueryFieldAttribute("bidno2", "매수증권사코드2", "char", "6")]
		public string bidno2;
		/// <summary>
		/// 총매도수량2
		/// </summary>
		[XAQueryFieldAttribute("dvol2", "총매도수량2", "long", "12")]
		public long dvol2;
		/// <summary>
		/// 총매수수량2
		/// </summary>
		[XAQueryFieldAttribute("svol2", "총매수수량2", "long", "12")]
		public long svol2;
		/// <summary>
		/// 매도증감2
		/// </summary>
		[XAQueryFieldAttribute("dcha2", "매도증감2", "long", "12")]
		public long dcha2;
		/// <summary>
		/// 매수증감2
		/// </summary>
		[XAQueryFieldAttribute("scha2", "매수증감2", "long", "12")]
		public long scha2;
		/// <summary>
		/// 매도비율2
		/// </summary>
		[XAQueryFieldAttribute("ddiff2", "매도비율2", "float", "6.2")]
		public float ddiff2;
		/// <summary>
		/// 매수비율2
		/// </summary>
		[XAQueryFieldAttribute("sdiff2", "매수비율2", "float", "6.2")]
		public float sdiff2;
		/// <summary>
		/// 매도증권사코드3
		/// </summary>
		[XAQueryFieldAttribute("offerno3", "매도증권사코드3", "char", "6")]
		public string offerno3;
		/// <summary>
		/// 매수증권사코드3
		/// </summary>
		[XAQueryFieldAttribute("bidno3", "매수증권사코드3", "char", "6")]
		public string bidno3;
		/// <summary>
		/// 총매도수량3
		/// </summary>
		[XAQueryFieldAttribute("dvol3", "총매도수량3", "long", "12")]
		public long dvol3;
		/// <summary>
		/// 총매수수량3
		/// </summary>
		[XAQueryFieldAttribute("svol3", "총매수수량3", "long", "12")]
		public long svol3;
		/// <summary>
		/// 매도증감3
		/// </summary>
		[XAQueryFieldAttribute("dcha3", "매도증감3", "long", "12")]
		public long dcha3;
		/// <summary>
		/// 매수증감3
		/// </summary>
		[XAQueryFieldAttribute("scha3", "매수증감3", "long", "12")]
		public long scha3;
		/// <summary>
		/// 매도비율3
		/// </summary>
		[XAQueryFieldAttribute("ddiff3", "매도비율3", "float", "6.2")]
		public float ddiff3;
		/// <summary>
		/// 매수비율3
		/// </summary>
		[XAQueryFieldAttribute("sdiff3", "매수비율3", "float", "6.2")]
		public float sdiff3;
		/// <summary>
		/// 매도증권사코드4
		/// </summary>
		[XAQueryFieldAttribute("offerno4", "매도증권사코드4", "char", "6")]
		public string offerno4;
		/// <summary>
		/// 매수증권사코드4
		/// </summary>
		[XAQueryFieldAttribute("bidno4", "매수증권사코드4", "char", "6")]
		public string bidno4;
		/// <summary>
		/// 총매도수량4
		/// </summary>
		[XAQueryFieldAttribute("dvol4", "총매도수량4", "long", "12")]
		public long dvol4;
		/// <summary>
		/// 총매수수량4
		/// </summary>
		[XAQueryFieldAttribute("svol4", "총매수수량4", "long", "12")]
		public long svol4;
		/// <summary>
		/// 매도증감4
		/// </summary>
		[XAQueryFieldAttribute("dcha4", "매도증감4", "long", "12")]
		public long dcha4;
		/// <summary>
		/// 매수증감4
		/// </summary>
		[XAQueryFieldAttribute("scha4", "매수증감4", "long", "12")]
		public long scha4;
		/// <summary>
		/// 매도비율4
		/// </summary>
		[XAQueryFieldAttribute("ddiff4", "매도비율4", "float", "6.2")]
		public float ddiff4;
		/// <summary>
		/// 매수비율4
		/// </summary>
		[XAQueryFieldAttribute("sdiff4", "매수비율4", "float", "6.2")]
		public float sdiff4;
		/// <summary>
		/// 매도증권사코드5
		/// </summary>
		[XAQueryFieldAttribute("offerno5", "매도증권사코드5", "char", "6")]
		public string offerno5;
		/// <summary>
		/// 매수증권사코드5
		/// </summary>
		[XAQueryFieldAttribute("bidno5", "매수증권사코드5", "char", "6")]
		public string bidno5;
		/// <summary>
		/// 총매도수량5
		/// </summary>
		[XAQueryFieldAttribute("dvol5", "총매도수량5", "long", "12")]
		public long dvol5;
		/// <summary>
		/// 총매수수량5
		/// </summary>
		[XAQueryFieldAttribute("svol5", "총매수수량5", "long", "12")]
		public long svol5;
		/// <summary>
		/// 매도증감5
		/// </summary>
		[XAQueryFieldAttribute("dcha5", "매도증감5", "long", "12")]
		public long dcha5;
		/// <summary>
		/// 매수증감5
		/// </summary>
		[XAQueryFieldAttribute("scha5", "매수증감5", "long", "12")]
		public long scha5;
		/// <summary>
		/// 매도비율5
		/// </summary>
		[XAQueryFieldAttribute("ddiff5", "매도비율5", "float", "6.2")]
		public float ddiff5;
		/// <summary>
		/// 매수비율5
		/// </summary>
		[XAQueryFieldAttribute("sdiff5", "매수비율5", "float", "6.2")]
		public float sdiff5;
		/// <summary>
		/// 외국계매도합계수량
		/// </summary>
		[XAQueryFieldAttribute("fwdvl", "외국계매도합계수량", "long", "12")]
		public long fwdvl;
		/// <summary>
		/// 외국계매수합계수량
		/// </summary>
		[XAQueryFieldAttribute("fwsvl", "외국계매수합계수량", "long", "12")]
		public long fwsvl;
		/// <summary>
		/// 외국계매도직전대비
		/// </summary>
		[XAQueryFieldAttribute("ftradmdcha", "외국계매도직전대비", "long", "12")]
		public long ftradmdcha;
		/// <summary>
		/// 외국계매수직전대비
		/// </summary>
		[XAQueryFieldAttribute("ftradmscha", "외국계매수직전대비", "long", "12")]
		public long ftradmscha;
		/// <summary>
		/// 외국계매도합계비율
		/// </summary>
		[XAQueryFieldAttribute("fwddiff", "외국계매도합계비율", "float", "6.2")]
		public float fwddiff;
		/// <summary>
		/// 외국계매수합계비율
		/// </summary>
		[XAQueryFieldAttribute("fwsdiff", "외국계매수합계비율", "float", "6.2")]
		public float fwsdiff;

		public static class F
		{
			/// <summary>
			/// 한글명
			/// </summary>
			public const string hname = "hname";
			/// <summary>
			/// 표준코드
			/// </summary>
			public const string expcode = "expcode";
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 매도증권사코드1
			/// </summary>
			public const string offerno1 = "offerno1";
			/// <summary>
			/// 매수증권사코드1
			/// </summary>
			public const string bidno1 = "bidno1";
			/// <summary>
			/// 총매도수량1
			/// </summary>
			public const string dvol1 = "dvol1";
			/// <summary>
			/// 총매수수량1
			/// </summary>
			public const string svol1 = "svol1";
			/// <summary>
			/// 매도증감1
			/// </summary>
			public const string dcha1 = "dcha1";
			/// <summary>
			/// 매수증감1
			/// </summary>
			public const string scha1 = "scha1";
			/// <summary>
			/// 매도비율1
			/// </summary>
			public const string ddiff1 = "ddiff1";
			/// <summary>
			/// 매수비율1
			/// </summary>
			public const string sdiff1 = "sdiff1";
			/// <summary>
			/// 매도증권사코드2
			/// </summary>
			public const string offerno2 = "offerno2";
			/// <summary>
			/// 매수증권사코드2
			/// </summary>
			public const string bidno2 = "bidno2";
			/// <summary>
			/// 총매도수량2
			/// </summary>
			public const string dvol2 = "dvol2";
			/// <summary>
			/// 총매수수량2
			/// </summary>
			public const string svol2 = "svol2";
			/// <summary>
			/// 매도증감2
			/// </summary>
			public const string dcha2 = "dcha2";
			/// <summary>
			/// 매수증감2
			/// </summary>
			public const string scha2 = "scha2";
			/// <summary>
			/// 매도비율2
			/// </summary>
			public const string ddiff2 = "ddiff2";
			/// <summary>
			/// 매수비율2
			/// </summary>
			public const string sdiff2 = "sdiff2";
			/// <summary>
			/// 매도증권사코드3
			/// </summary>
			public const string offerno3 = "offerno3";
			/// <summary>
			/// 매수증권사코드3
			/// </summary>
			public const string bidno3 = "bidno3";
			/// <summary>
			/// 총매도수량3
			/// </summary>
			public const string dvol3 = "dvol3";
			/// <summary>
			/// 총매수수량3
			/// </summary>
			public const string svol3 = "svol3";
			/// <summary>
			/// 매도증감3
			/// </summary>
			public const string dcha3 = "dcha3";
			/// <summary>
			/// 매수증감3
			/// </summary>
			public const string scha3 = "scha3";
			/// <summary>
			/// 매도비율3
			/// </summary>
			public const string ddiff3 = "ddiff3";
			/// <summary>
			/// 매수비율3
			/// </summary>
			public const string sdiff3 = "sdiff3";
			/// <summary>
			/// 매도증권사코드4
			/// </summary>
			public const string offerno4 = "offerno4";
			/// <summary>
			/// 매수증권사코드4
			/// </summary>
			public const string bidno4 = "bidno4";
			/// <summary>
			/// 총매도수량4
			/// </summary>
			public const string dvol4 = "dvol4";
			/// <summary>
			/// 총매수수량4
			/// </summary>
			public const string svol4 = "svol4";
			/// <summary>
			/// 매도증감4
			/// </summary>
			public const string dcha4 = "dcha4";
			/// <summary>
			/// 매수증감4
			/// </summary>
			public const string scha4 = "scha4";
			/// <summary>
			/// 매도비율4
			/// </summary>
			public const string ddiff4 = "ddiff4";
			/// <summary>
			/// 매수비율4
			/// </summary>
			public const string sdiff4 = "sdiff4";
			/// <summary>
			/// 매도증권사코드5
			/// </summary>
			public const string offerno5 = "offerno5";
			/// <summary>
			/// 매수증권사코드5
			/// </summary>
			public const string bidno5 = "bidno5";
			/// <summary>
			/// 총매도수량5
			/// </summary>
			public const string dvol5 = "dvol5";
			/// <summary>
			/// 총매수수량5
			/// </summary>
			public const string svol5 = "svol5";
			/// <summary>
			/// 매도증감5
			/// </summary>
			public const string dcha5 = "dcha5";
			/// <summary>
			/// 매수증감5
			/// </summary>
			public const string scha5 = "scha5";
			/// <summary>
			/// 매도비율5
			/// </summary>
			public const string ddiff5 = "ddiff5";
			/// <summary>
			/// 매수비율5
			/// </summary>
			public const string sdiff5 = "sdiff5";
			/// <summary>
			/// 외국계매도합계수량
			/// </summary>
			public const string fwdvl = "fwdvl";
			/// <summary>
			/// 외국계매수합계수량
			/// </summary>
			public const string fwsvl = "fwsvl";
			/// <summary>
			/// 외국계매도직전대비
			/// </summary>
			public const string ftradmdcha = "ftradmdcha";
			/// <summary>
			/// 외국계매수직전대비
			/// </summary>
			public const string ftradmscha = "ftradmscha";
			/// <summary>
			/// 외국계매도합계비율
			/// </summary>
			public const string fwddiff = "fwddiff";
			/// <summary>
			/// 외국계매수합계비율
			/// </summary>
			public const string fwsdiff = "fwsdiff";
		}

		public static string[] AllFields = new string[]
		{
			F.hname,
			F.expcode,
			F.shcode,
			F.offerno1,
			F.bidno1,
			F.dvol1,
			F.svol1,
			F.dcha1,
			F.scha1,
			F.ddiff1,
			F.sdiff1,
			F.offerno2,
			F.bidno2,
			F.dvol2,
			F.svol2,
			F.dcha2,
			F.scha2,
			F.ddiff2,
			F.sdiff2,
			F.offerno3,
			F.bidno3,
			F.dvol3,
			F.svol3,
			F.dcha3,
			F.scha3,
			F.ddiff3,
			F.sdiff3,
			F.offerno4,
			F.bidno4,
			F.dvol4,
			F.svol4,
			F.dcha4,
			F.scha4,
			F.ddiff4,
			F.sdiff4,
			F.offerno5,
			F.bidno5,
			F.dvol5,
			F.svol5,
			F.dcha5,
			F.scha5,
			F.ddiff5,
			F.sdiff5,
			F.fwdvl,
			F.fwsvl,
			F.ftradmdcha,
			F.ftradmscha,
			F.fwddiff,
			F.fwsdiff,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["hname"] = new XAQueryFieldInfo("char", hname, hname, "한글명", (decimal)40);
			dict["expcode"] = new XAQueryFieldInfo("char", expcode, expcode, "표준코드", (decimal)12);
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)9);
			dict["offerno1"] = new XAQueryFieldInfo("char", offerno1, offerno1, "매도증권사코드1", (decimal)6);
			dict["bidno1"] = new XAQueryFieldInfo("char", bidno1, bidno1, "매수증권사코드1", (decimal)6);
			dict["dvol1"] = new XAQueryFieldInfo("long", dvol1, dvol1.ToString("d12"), "총매도수량1", (decimal)12);
			dict["svol1"] = new XAQueryFieldInfo("long", svol1, svol1.ToString("d12"), "총매수수량1", (decimal)12);
			dict["dcha1"] = new XAQueryFieldInfo("long", dcha1, dcha1.ToString("d12"), "매도증감1", (decimal)12);
			dict["scha1"] = new XAQueryFieldInfo("long", scha1, scha1.ToString("d12"), "매수증감1", (decimal)12);
			dict["ddiff1"] = new XAQueryFieldInfo("float", ddiff1, ddiff1.ToString("000000.00"), "매도비율1", (decimal)6.2);
			dict["sdiff1"] = new XAQueryFieldInfo("float", sdiff1, sdiff1.ToString("000000.00"), "매수비율1", (decimal)6.2);
			dict["offerno2"] = new XAQueryFieldInfo("char", offerno2, offerno2, "매도증권사코드2", (decimal)6);
			dict["bidno2"] = new XAQueryFieldInfo("char", bidno2, bidno2, "매수증권사코드2", (decimal)6);
			dict["dvol2"] = new XAQueryFieldInfo("long", dvol2, dvol2.ToString("d12"), "총매도수량2", (decimal)12);
			dict["svol2"] = new XAQueryFieldInfo("long", svol2, svol2.ToString("d12"), "총매수수량2", (decimal)12);
			dict["dcha2"] = new XAQueryFieldInfo("long", dcha2, dcha2.ToString("d12"), "매도증감2", (decimal)12);
			dict["scha2"] = new XAQueryFieldInfo("long", scha2, scha2.ToString("d12"), "매수증감2", (decimal)12);
			dict["ddiff2"] = new XAQueryFieldInfo("float", ddiff2, ddiff2.ToString("000000.00"), "매도비율2", (decimal)6.2);
			dict["sdiff2"] = new XAQueryFieldInfo("float", sdiff2, sdiff2.ToString("000000.00"), "매수비율2", (decimal)6.2);
			dict["offerno3"] = new XAQueryFieldInfo("char", offerno3, offerno3, "매도증권사코드3", (decimal)6);
			dict["bidno3"] = new XAQueryFieldInfo("char", bidno3, bidno3, "매수증권사코드3", (decimal)6);
			dict["dvol3"] = new XAQueryFieldInfo("long", dvol3, dvol3.ToString("d12"), "총매도수량3", (decimal)12);
			dict["svol3"] = new XAQueryFieldInfo("long", svol3, svol3.ToString("d12"), "총매수수량3", (decimal)12);
			dict["dcha3"] = new XAQueryFieldInfo("long", dcha3, dcha3.ToString("d12"), "매도증감3", (decimal)12);
			dict["scha3"] = new XAQueryFieldInfo("long", scha3, scha3.ToString("d12"), "매수증감3", (decimal)12);
			dict["ddiff3"] = new XAQueryFieldInfo("float", ddiff3, ddiff3.ToString("000000.00"), "매도비율3", (decimal)6.2);
			dict["sdiff3"] = new XAQueryFieldInfo("float", sdiff3, sdiff3.ToString("000000.00"), "매수비율3", (decimal)6.2);
			dict["offerno4"] = new XAQueryFieldInfo("char", offerno4, offerno4, "매도증권사코드4", (decimal)6);
			dict["bidno4"] = new XAQueryFieldInfo("char", bidno4, bidno4, "매수증권사코드4", (decimal)6);
			dict["dvol4"] = new XAQueryFieldInfo("long", dvol4, dvol4.ToString("d12"), "총매도수량4", (decimal)12);
			dict["svol4"] = new XAQueryFieldInfo("long", svol4, svol4.ToString("d12"), "총매수수량4", (decimal)12);
			dict["dcha4"] = new XAQueryFieldInfo("long", dcha4, dcha4.ToString("d12"), "매도증감4", (decimal)12);
			dict["scha4"] = new XAQueryFieldInfo("long", scha4, scha4.ToString("d12"), "매수증감4", (decimal)12);
			dict["ddiff4"] = new XAQueryFieldInfo("float", ddiff4, ddiff4.ToString("000000.00"), "매도비율4", (decimal)6.2);
			dict["sdiff4"] = new XAQueryFieldInfo("float", sdiff4, sdiff4.ToString("000000.00"), "매수비율4", (decimal)6.2);
			dict["offerno5"] = new XAQueryFieldInfo("char", offerno5, offerno5, "매도증권사코드5", (decimal)6);
			dict["bidno5"] = new XAQueryFieldInfo("char", bidno5, bidno5, "매수증권사코드5", (decimal)6);
			dict["dvol5"] = new XAQueryFieldInfo("long", dvol5, dvol5.ToString("d12"), "총매도수량5", (decimal)12);
			dict["svol5"] = new XAQueryFieldInfo("long", svol5, svol5.ToString("d12"), "총매수수량5", (decimal)12);
			dict["dcha5"] = new XAQueryFieldInfo("long", dcha5, dcha5.ToString("d12"), "매도증감5", (decimal)12);
			dict["scha5"] = new XAQueryFieldInfo("long", scha5, scha5.ToString("d12"), "매수증감5", (decimal)12);
			dict["ddiff5"] = new XAQueryFieldInfo("float", ddiff5, ddiff5.ToString("000000.00"), "매도비율5", (decimal)6.2);
			dict["sdiff5"] = new XAQueryFieldInfo("float", sdiff5, sdiff5.ToString("000000.00"), "매수비율5", (decimal)6.2);
			dict["fwdvl"] = new XAQueryFieldInfo("long", fwdvl, fwdvl.ToString("d12"), "외국계매도합계수량", (decimal)12);
			dict["fwsvl"] = new XAQueryFieldInfo("long", fwsvl, fwsvl.ToString("d12"), "외국계매수합계수량", (decimal)12);
			dict["ftradmdcha"] = new XAQueryFieldInfo("long", ftradmdcha, ftradmdcha.ToString("d12"), "외국계매도직전대비", (decimal)12);
			dict["ftradmscha"] = new XAQueryFieldInfo("long", ftradmscha, ftradmscha.ToString("d12"), "외국계매수직전대비", (decimal)12);
			dict["fwddiff"] = new XAQueryFieldInfo("float", fwddiff, fwddiff.ToString("000000.00"), "외국계매도합계비율", (decimal)6.2);
			dict["fwsdiff"] = new XAQueryFieldInfo("float", fwsdiff, fwsdiff.ToString("000000.00"), "외국계매수합계비율", (decimal)6.2);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "hname":
					this.hname = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "expcode":
					this.expcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "offerno1":
					this.offerno1 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "bidno1":
					this.bidno1 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "dvol1":
					this.dvol1 = fieldInfo.FieldValue.ParseLong("dvol1");
				break;

				case "svol1":
					this.svol1 = fieldInfo.FieldValue.ParseLong("svol1");
				break;

				case "dcha1":
					this.dcha1 = fieldInfo.FieldValue.ParseLong("dcha1");
				break;

				case "scha1":
					this.scha1 = fieldInfo.FieldValue.ParseLong("scha1");
				break;

				case "ddiff1":
					this.ddiff1 = fieldInfo.FieldValue.ParseFloat("ddiff1");
				break;

				case "sdiff1":
					this.sdiff1 = fieldInfo.FieldValue.ParseFloat("sdiff1");
				break;

				case "offerno2":
					this.offerno2 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "bidno2":
					this.bidno2 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "dvol2":
					this.dvol2 = fieldInfo.FieldValue.ParseLong("dvol2");
				break;

				case "svol2":
					this.svol2 = fieldInfo.FieldValue.ParseLong("svol2");
				break;

				case "dcha2":
					this.dcha2 = fieldInfo.FieldValue.ParseLong("dcha2");
				break;

				case "scha2":
					this.scha2 = fieldInfo.FieldValue.ParseLong("scha2");
				break;

				case "ddiff2":
					this.ddiff2 = fieldInfo.FieldValue.ParseFloat("ddiff2");
				break;

				case "sdiff2":
					this.sdiff2 = fieldInfo.FieldValue.ParseFloat("sdiff2");
				break;

				case "offerno3":
					this.offerno3 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "bidno3":
					this.bidno3 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "dvol3":
					this.dvol3 = fieldInfo.FieldValue.ParseLong("dvol3");
				break;

				case "svol3":
					this.svol3 = fieldInfo.FieldValue.ParseLong("svol3");
				break;

				case "dcha3":
					this.dcha3 = fieldInfo.FieldValue.ParseLong("dcha3");
				break;

				case "scha3":
					this.scha3 = fieldInfo.FieldValue.ParseLong("scha3");
				break;

				case "ddiff3":
					this.ddiff3 = fieldInfo.FieldValue.ParseFloat("ddiff3");
				break;

				case "sdiff3":
					this.sdiff3 = fieldInfo.FieldValue.ParseFloat("sdiff3");
				break;

				case "offerno4":
					this.offerno4 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "bidno4":
					this.bidno4 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "dvol4":
					this.dvol4 = fieldInfo.FieldValue.ParseLong("dvol4");
				break;

				case "svol4":
					this.svol4 = fieldInfo.FieldValue.ParseLong("svol4");
				break;

				case "dcha4":
					this.dcha4 = fieldInfo.FieldValue.ParseLong("dcha4");
				break;

				case "scha4":
					this.scha4 = fieldInfo.FieldValue.ParseLong("scha4");
				break;

				case "ddiff4":
					this.ddiff4 = fieldInfo.FieldValue.ParseFloat("ddiff4");
				break;

				case "sdiff4":
					this.sdiff4 = fieldInfo.FieldValue.ParseFloat("sdiff4");
				break;

				case "offerno5":
					this.offerno5 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "bidno5":
					this.bidno5 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "dvol5":
					this.dvol5 = fieldInfo.FieldValue.ParseLong("dvol5");
				break;

				case "svol5":
					this.svol5 = fieldInfo.FieldValue.ParseLong("svol5");
				break;

				case "dcha5":
					this.dcha5 = fieldInfo.FieldValue.ParseLong("dcha5");
				break;

				case "scha5":
					this.scha5 = fieldInfo.FieldValue.ParseLong("scha5");
				break;

				case "ddiff5":
					this.ddiff5 = fieldInfo.FieldValue.ParseFloat("ddiff5");
				break;

				case "sdiff5":
					this.sdiff5 = fieldInfo.FieldValue.ParseFloat("sdiff5");
				break;

				case "fwdvl":
					this.fwdvl = fieldInfo.FieldValue.ParseLong("fwdvl");
				break;

				case "fwsvl":
					this.fwsvl = fieldInfo.FieldValue.ParseLong("fwsvl");
				break;

				case "ftradmdcha":
					this.ftradmdcha = fieldInfo.FieldValue.ParseLong("ftradmdcha");
				break;

				case "ftradmscha":
					this.ftradmscha = fieldInfo.FieldValue.ParseLong("ftradmscha");
				break;

				case "fwddiff":
					this.fwddiff = fieldInfo.FieldValue.ParseFloat("fwddiff");
				break;

				case "fwsdiff":
					this.fwsdiff = fieldInfo.FieldValue.ParseFloat("fwsdiff");
				break;


			}
		}

		public static XQt1972OutBlock FromQuery(XQt1972 query)
		{
			XQt1972OutBlock block = new XQt1972OutBlock();
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
				block.hname = query.GetFieldData(block.GetBlockName(), "hname", 0).TrimEnd('?'); // char 40
				block.expcode = query.GetFieldData(block.GetBlockName(), "expcode", 0).TrimEnd('?'); // char 12
				block.shcode = query.GetFieldData(block.GetBlockName(), "shcode", 0).TrimEnd('?'); // char 9
				block.offerno1 = query.GetFieldData(block.GetBlockName(), "offerno1", 0).TrimEnd('?'); // char 6
				block.bidno1 = query.GetFieldData(block.GetBlockName(), "bidno1", 0).TrimEnd('?'); // char 6
				block.dvol1 = query.GetFieldData(block.GetBlockName(), "dvol1", 0).ParseLong("dvol1"); // long 12
				block.svol1 = query.GetFieldData(block.GetBlockName(), "svol1", 0).ParseLong("svol1"); // long 12
				block.dcha1 = query.GetFieldData(block.GetBlockName(), "dcha1", 0).ParseLong("dcha1"); // long 12
				block.scha1 = query.GetFieldData(block.GetBlockName(), "scha1", 0).ParseLong("scha1"); // long 12
				block.ddiff1 = query.GetFieldData(block.GetBlockName(), "ddiff1", 0).ParseFloat("ddiff1"); // float 6.2
				block.sdiff1 = query.GetFieldData(block.GetBlockName(), "sdiff1", 0).ParseFloat("sdiff1"); // float 6.2
				block.offerno2 = query.GetFieldData(block.GetBlockName(), "offerno2", 0).TrimEnd('?'); // char 6
				block.bidno2 = query.GetFieldData(block.GetBlockName(), "bidno2", 0).TrimEnd('?'); // char 6
				block.dvol2 = query.GetFieldData(block.GetBlockName(), "dvol2", 0).ParseLong("dvol2"); // long 12
				block.svol2 = query.GetFieldData(block.GetBlockName(), "svol2", 0).ParseLong("svol2"); // long 12
				block.dcha2 = query.GetFieldData(block.GetBlockName(), "dcha2", 0).ParseLong("dcha2"); // long 12
				block.scha2 = query.GetFieldData(block.GetBlockName(), "scha2", 0).ParseLong("scha2"); // long 12
				block.ddiff2 = query.GetFieldData(block.GetBlockName(), "ddiff2", 0).ParseFloat("ddiff2"); // float 6.2
				block.sdiff2 = query.GetFieldData(block.GetBlockName(), "sdiff2", 0).ParseFloat("sdiff2"); // float 6.2
				block.offerno3 = query.GetFieldData(block.GetBlockName(), "offerno3", 0).TrimEnd('?'); // char 6
				block.bidno3 = query.GetFieldData(block.GetBlockName(), "bidno3", 0).TrimEnd('?'); // char 6
				block.dvol3 = query.GetFieldData(block.GetBlockName(), "dvol3", 0).ParseLong("dvol3"); // long 12
				block.svol3 = query.GetFieldData(block.GetBlockName(), "svol3", 0).ParseLong("svol3"); // long 12
				block.dcha3 = query.GetFieldData(block.GetBlockName(), "dcha3", 0).ParseLong("dcha3"); // long 12
				block.scha3 = query.GetFieldData(block.GetBlockName(), "scha3", 0).ParseLong("scha3"); // long 12
				block.ddiff3 = query.GetFieldData(block.GetBlockName(), "ddiff3", 0).ParseFloat("ddiff3"); // float 6.2
				block.sdiff3 = query.GetFieldData(block.GetBlockName(), "sdiff3", 0).ParseFloat("sdiff3"); // float 6.2
				block.offerno4 = query.GetFieldData(block.GetBlockName(), "offerno4", 0).TrimEnd('?'); // char 6
				block.bidno4 = query.GetFieldData(block.GetBlockName(), "bidno4", 0).TrimEnd('?'); // char 6
				block.dvol4 = query.GetFieldData(block.GetBlockName(), "dvol4", 0).ParseLong("dvol4"); // long 12
				block.svol4 = query.GetFieldData(block.GetBlockName(), "svol4", 0).ParseLong("svol4"); // long 12
				block.dcha4 = query.GetFieldData(block.GetBlockName(), "dcha4", 0).ParseLong("dcha4"); // long 12
				block.scha4 = query.GetFieldData(block.GetBlockName(), "scha4", 0).ParseLong("scha4"); // long 12
				block.ddiff4 = query.GetFieldData(block.GetBlockName(), "ddiff4", 0).ParseFloat("ddiff4"); // float 6.2
				block.sdiff4 = query.GetFieldData(block.GetBlockName(), "sdiff4", 0).ParseFloat("sdiff4"); // float 6.2
				block.offerno5 = query.GetFieldData(block.GetBlockName(), "offerno5", 0).TrimEnd('?'); // char 6
				block.bidno5 = query.GetFieldData(block.GetBlockName(), "bidno5", 0).TrimEnd('?'); // char 6
				block.dvol5 = query.GetFieldData(block.GetBlockName(), "dvol5", 0).ParseLong("dvol5"); // long 12
				block.svol5 = query.GetFieldData(block.GetBlockName(), "svol5", 0).ParseLong("svol5"); // long 12
				block.dcha5 = query.GetFieldData(block.GetBlockName(), "dcha5", 0).ParseLong("dcha5"); // long 12
				block.scha5 = query.GetFieldData(block.GetBlockName(), "scha5", 0).ParseLong("scha5"); // long 12
				block.ddiff5 = query.GetFieldData(block.GetBlockName(), "ddiff5", 0).ParseFloat("ddiff5"); // float 6.2
				block.sdiff5 = query.GetFieldData(block.GetBlockName(), "sdiff5", 0).ParseFloat("sdiff5"); // float 6.2
				block.fwdvl = query.GetFieldData(block.GetBlockName(), "fwdvl", 0).ParseLong("fwdvl"); // long 12
				block.fwsvl = query.GetFieldData(block.GetBlockName(), "fwsvl", 0).ParseLong("fwsvl"); // long 12
				block.ftradmdcha = query.GetFieldData(block.GetBlockName(), "ftradmdcha", 0).ParseLong("ftradmdcha"); // long 12
				block.ftradmscha = query.GetFieldData(block.GetBlockName(), "ftradmscha", 0).ParseLong("ftradmscha"); // long 12
				block.fwddiff = query.GetFieldData(block.GetBlockName(), "fwddiff", 0).ParseFloat("fwddiff"); // float 6.2
				block.fwsdiff = query.GetFieldData(block.GetBlockName(), "fwsdiff", 0).ParseFloat("fwsdiff"); // float 6.2

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (hname?.Length > 40) return false; // char 40
			if (expcode?.Length > 12) return false; // char 12
			if (shcode?.Length > 9) return false; // char 9
			if (offerno1?.Length > 6) return false; // char 6
			if (bidno1?.Length > 6) return false; // char 6
			if (dvol1.ToString().Length > 12) return false; // long 12
			if (svol1.ToString().Length > 12) return false; // long 12
			if (dcha1.ToString().Length > 12) return false; // long 12
			if (scha1.ToString().Length > 12) return false; // long 12
			// ddiff1 float 6.2
			// sdiff1 float 6.2
			if (offerno2?.Length > 6) return false; // char 6
			if (bidno2?.Length > 6) return false; // char 6
			if (dvol2.ToString().Length > 12) return false; // long 12
			if (svol2.ToString().Length > 12) return false; // long 12
			if (dcha2.ToString().Length > 12) return false; // long 12
			if (scha2.ToString().Length > 12) return false; // long 12
			// ddiff2 float 6.2
			// sdiff2 float 6.2
			if (offerno3?.Length > 6) return false; // char 6
			if (bidno3?.Length > 6) return false; // char 6
			if (dvol3.ToString().Length > 12) return false; // long 12
			if (svol3.ToString().Length > 12) return false; // long 12
			if (dcha3.ToString().Length > 12) return false; // long 12
			if (scha3.ToString().Length > 12) return false; // long 12
			// ddiff3 float 6.2
			// sdiff3 float 6.2
			if (offerno4?.Length > 6) return false; // char 6
			if (bidno4?.Length > 6) return false; // char 6
			if (dvol4.ToString().Length > 12) return false; // long 12
			if (svol4.ToString().Length > 12) return false; // long 12
			if (dcha4.ToString().Length > 12) return false; // long 12
			if (scha4.ToString().Length > 12) return false; // long 12
			// ddiff4 float 6.2
			// sdiff4 float 6.2
			if (offerno5?.Length > 6) return false; // char 6
			if (bidno5?.Length > 6) return false; // char 6
			if (dvol5.ToString().Length > 12) return false; // long 12
			if (svol5.ToString().Length > 12) return false; // long 12
			if (dcha5.ToString().Length > 12) return false; // long 12
			if (scha5.ToString().Length > 12) return false; // long 12
			// ddiff5 float 6.2
			// sdiff5 float 6.2
			if (fwdvl.ToString().Length > 12) return false; // long 12
			if (fwsvl.ToString().Length > 12) return false; // long 12
			if (ftradmdcha.ToString().Length > 12) return false; // long 12
			if (ftradmscha.ToString().Length > 12) return false; // long 12
			// fwddiff float 6.2
			// fwsdiff float 6.2

			return true;
		}
	}

	/// <summary>
	/// ELW현재가(거래원)조회(t1972)
	/// </summary>
	public partial class XQt1972 : XingQuery
	{
		/// <summary>
		/// t1972
		/// </summary>
		public const string _typeName = "t1972";
		/// <summary>
		/// ELW현재가(거래원)조회(t1972)
		/// </summary>
		public const string _typeDesc = "ELW현재가(거래원)조회(t1972)";
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
		/// t1972
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// ELW현재가(거래원)조회(t1972)
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
		/// ELW현재가(거래원)조회(t1972)
		/// </summary>
		public XQt1972() : base("t1972") { }


		public static XQt1972OutBlock Get(string shcode = default)
		{
			using (XQt1972 instance = new XQt1972())
			{
				instance.SetFieldData(XQt1972InBlock.BlockName, XQt1972InBlock.F.shcode, 0, shcode); // char 6

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

		public static XQt1972OutBlock ReadFromDB(string tableNamePostfix = null /*, string shcode = default */)
		{
			using (XQt1972 instance = new XQt1972())
			{

				string tableName = (tableNamePostfix == null) ? "XQt1972OutBlock" : $"XQt1972OutBlock_{tableNamePostfix}";
				QueryOption qo = new QueryOption(tableName);
				// if (shcode != default) qo.Add("shcode", shcode);


				var outBlock = instance.Select<XQt1972OutBlock>(qo);
				return outBlock;
			}
		}

		public bool SetBlock(XQt1972InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "shcode", 0, block.shcode); // char 6

			return true;
		}

		public XQt1972OutBlock GetBlock()
		{
			XQt1972OutBlock instance = XQt1972OutBlock.FromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt1972OutBlock),

		};

	}

}
