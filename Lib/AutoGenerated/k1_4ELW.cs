using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XRk1_InBlock : XingBlock
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

	public partial class XRk1_OutBlock : XingBlock
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
		/// 매도증권사코드1
		/// </summary>
		[XAQueryFieldAttribute("매도증권사코드1")]
		public string offerno1;
		/// <summary>
		/// 매수증권사코드1
		/// </summary>
		[XAQueryFieldAttribute("매수증권사코드1")]
		public string bidno1;
		/// <summary>
		/// 매도회원사명1
		/// </summary>
		[XAQueryFieldAttribute("매도회원사명1")]
		public string offertrad1;
		/// <summary>
		/// 매수회원사명1
		/// </summary>
		[XAQueryFieldAttribute("매수회원사명1")]
		public string bidtrad1;
		/// <summary>
		/// 매도거래량1
		/// </summary>
		[XAQueryFieldAttribute("매도거래량1")]
		public long tradmdvol1;
		/// <summary>
		/// 매수거래량1
		/// </summary>
		[XAQueryFieldAttribute("매수거래량1")]
		public long tradmsvol1;
		/// <summary>
		/// 매도거래량비중1
		/// </summary>
		[XAQueryFieldAttribute("매도거래량비중1")]
		public float tradmdrate1;
		/// <summary>
		/// 매도거래량비중1
		/// </summary>
		[XAQueryFieldAttribute("매도거래량비중1")]
		public float tradmsrate1;
		/// <summary>
		/// 매도거래량직전대비1
		/// </summary>
		[XAQueryFieldAttribute("매도거래량직전대비1")]
		public long tradmdcha1;
		/// <summary>
		/// 매수거래량직전대비1
		/// </summary>
		[XAQueryFieldAttribute("매수거래량직전대비1")]
		public long tradmscha1;
		/// <summary>
		/// 매도증권사코드2
		/// </summary>
		[XAQueryFieldAttribute("매도증권사코드2")]
		public string offerno2;
		/// <summary>
		/// 매수증권사코드2
		/// </summary>
		[XAQueryFieldAttribute("매수증권사코드2")]
		public string bidno2;
		/// <summary>
		/// 매도회원사명2
		/// </summary>
		[XAQueryFieldAttribute("매도회원사명2")]
		public string offertrad2;
		/// <summary>
		/// 매수회원사명2
		/// </summary>
		[XAQueryFieldAttribute("매수회원사명2")]
		public string bidtrad2;
		/// <summary>
		/// 매도거래량2
		/// </summary>
		[XAQueryFieldAttribute("매도거래량2")]
		public long tradmdvol2;
		/// <summary>
		/// 매수거래량2
		/// </summary>
		[XAQueryFieldAttribute("매수거래량2")]
		public long tradmsvol2;
		/// <summary>
		/// 매도거래량비중2
		/// </summary>
		[XAQueryFieldAttribute("매도거래량비중2")]
		public float tradmdrate2;
		/// <summary>
		/// 매수거래량비중2
		/// </summary>
		[XAQueryFieldAttribute("매수거래량비중2")]
		public float tradmsrate2;
		/// <summary>
		/// 매도거래량직전대비2
		/// </summary>
		[XAQueryFieldAttribute("매도거래량직전대비2")]
		public long tradmdcha2;
		/// <summary>
		/// 매수거래량직전대비2
		/// </summary>
		[XAQueryFieldAttribute("매수거래량직전대비2")]
		public long tradmscha2;
		/// <summary>
		/// 매도증권사코드3
		/// </summary>
		[XAQueryFieldAttribute("매도증권사코드3")]
		public string offerno3;
		/// <summary>
		/// 매수증권사코드3
		/// </summary>
		[XAQueryFieldAttribute("매수증권사코드3")]
		public string bidno3;
		/// <summary>
		/// 매도회원사명3
		/// </summary>
		[XAQueryFieldAttribute("매도회원사명3")]
		public string offertrad3;
		/// <summary>
		/// 매수회원사명3
		/// </summary>
		[XAQueryFieldAttribute("매수회원사명3")]
		public string bidtrad3;
		/// <summary>
		/// 매도거래량3
		/// </summary>
		[XAQueryFieldAttribute("매도거래량3")]
		public long tradmdvol3;
		/// <summary>
		/// 매수거래량3
		/// </summary>
		[XAQueryFieldAttribute("매수거래량3")]
		public long tradmsvol3;
		/// <summary>
		/// 매도거래량비중3
		/// </summary>
		[XAQueryFieldAttribute("매도거래량비중3")]
		public float tradmdrate3;
		/// <summary>
		/// 매수거래량비중3
		/// </summary>
		[XAQueryFieldAttribute("매수거래량비중3")]
		public float tradmsrate3;
		/// <summary>
		/// 매도거래량직전대비3
		/// </summary>
		[XAQueryFieldAttribute("매도거래량직전대비3")]
		public long tradmdcha3;
		/// <summary>
		/// 매수거래량직전대비3
		/// </summary>
		[XAQueryFieldAttribute("매수거래량직전대비3")]
		public long tradmscha3;
		/// <summary>
		/// 매도증권사코드4
		/// </summary>
		[XAQueryFieldAttribute("매도증권사코드4")]
		public string offerno4;
		/// <summary>
		/// 매수증권사코드4
		/// </summary>
		[XAQueryFieldAttribute("매수증권사코드4")]
		public string bidno4;
		/// <summary>
		/// 매도회원사명4
		/// </summary>
		[XAQueryFieldAttribute("매도회원사명4")]
		public string offertrad4;
		/// <summary>
		/// 매수회원사명4
		/// </summary>
		[XAQueryFieldAttribute("매수회원사명4")]
		public string bidtrad4;
		/// <summary>
		/// 매도거래량4
		/// </summary>
		[XAQueryFieldAttribute("매도거래량4")]
		public long tradmdvol4;
		/// <summary>
		/// 매수거래량4
		/// </summary>
		[XAQueryFieldAttribute("매수거래량4")]
		public long tradmsvol4;
		/// <summary>
		/// 매도거래량비중4
		/// </summary>
		[XAQueryFieldAttribute("매도거래량비중4")]
		public float tradmdrate4;
		/// <summary>
		/// 매수거래량비중4
		/// </summary>
		[XAQueryFieldAttribute("매수거래량비중4")]
		public float tradmsrate4;
		/// <summary>
		/// 매도거래량직전대비4
		/// </summary>
		[XAQueryFieldAttribute("매도거래량직전대비4")]
		public long tradmdcha4;
		/// <summary>
		/// 매수거래량직전대비4
		/// </summary>
		[XAQueryFieldAttribute("매수거래량직전대비4")]
		public long tradmscha4;
		/// <summary>
		/// 매도증권사코드5
		/// </summary>
		[XAQueryFieldAttribute("매도증권사코드5")]
		public string offerno5;
		/// <summary>
		/// 매수증권사코드5
		/// </summary>
		[XAQueryFieldAttribute("매수증권사코드5")]
		public string bidno5;
		/// <summary>
		/// 매도회원사명5
		/// </summary>
		[XAQueryFieldAttribute("매도회원사명5")]
		public string offertrad5;
		/// <summary>
		/// 매수회원사명5
		/// </summary>
		[XAQueryFieldAttribute("매수회원사명5")]
		public string bidtrad5;
		/// <summary>
		/// 매도거래량5
		/// </summary>
		[XAQueryFieldAttribute("매도거래량5")]
		public long tradmdvol5;
		/// <summary>
		/// 매수거래량5
		/// </summary>
		[XAQueryFieldAttribute("매수거래량5")]
		public long tradmsvol5;
		/// <summary>
		/// 매도거래량비중5
		/// </summary>
		[XAQueryFieldAttribute("매도거래량비중5")]
		public float tradmdrate5;
		/// <summary>
		/// 매수거래량비중5
		/// </summary>
		[XAQueryFieldAttribute("매수거래량비중5")]
		public float tradmsrate5;
		/// <summary>
		/// 매도거래량직전대비5
		/// </summary>
		[XAQueryFieldAttribute("매도거래량직전대비5")]
		public long tradmdcha5;
		/// <summary>
		/// 매수거래량직전대비5
		/// </summary>
		[XAQueryFieldAttribute("매수거래량직전대비5")]
		public long tradmscha5;
		/// <summary>
		/// 외국계증권사매도합계
		/// </summary>
		[XAQueryFieldAttribute("외국계증권사매도합계")]
		public string ftradmdvol;
		/// <summary>
		/// 외국계증권사매수합계
		/// </summary>
		[XAQueryFieldAttribute("외국계증권사매수합계")]
		public string ftradmsvol;
		/// <summary>
		/// 외국계증권사매도거래량비중
		/// </summary>
		[XAQueryFieldAttribute("외국계증권사매도거래량비중")]
		public float ftradmdrate;
		/// <summary>
		/// 외국계증권사매수거래량비중
		/// </summary>
		[XAQueryFieldAttribute("외국계증권사매수거래량비중")]
		public float ftradmsrate;
		/// <summary>
		/// 외국계증권사매도거래량직전대비
		/// </summary>
		[XAQueryFieldAttribute("외국계증권사매도거래량직전대비")]
		public string ftradmdcha;
		/// <summary>
		/// 외국계증권사매수거래량직전대비
		/// </summary>
		[XAQueryFieldAttribute("외국계증권사매수거래량직전대비")]
		public string ftradmscha;
		/// <summary>
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("단축코드")]
		public string shcode;

		public static class F
		{
			/// <summary>
			/// 매도증권사코드1
			/// </summary>
			public const string offerno1 = "offerno1";
			/// <summary>
			/// 매수증권사코드1
			/// </summary>
			public const string bidno1 = "bidno1";
			/// <summary>
			/// 매도회원사명1
			/// </summary>
			public const string offertrad1 = "offertrad1";
			/// <summary>
			/// 매수회원사명1
			/// </summary>
			public const string bidtrad1 = "bidtrad1";
			/// <summary>
			/// 매도거래량1
			/// </summary>
			public const string tradmdvol1 = "tradmdvol1";
			/// <summary>
			/// 매수거래량1
			/// </summary>
			public const string tradmsvol1 = "tradmsvol1";
			/// <summary>
			/// 매도거래량비중1
			/// </summary>
			public const string tradmdrate1 = "tradmdrate1";
			/// <summary>
			/// 매도거래량비중1
			/// </summary>
			public const string tradmsrate1 = "tradmsrate1";
			/// <summary>
			/// 매도거래량직전대비1
			/// </summary>
			public const string tradmdcha1 = "tradmdcha1";
			/// <summary>
			/// 매수거래량직전대비1
			/// </summary>
			public const string tradmscha1 = "tradmscha1";
			/// <summary>
			/// 매도증권사코드2
			/// </summary>
			public const string offerno2 = "offerno2";
			/// <summary>
			/// 매수증권사코드2
			/// </summary>
			public const string bidno2 = "bidno2";
			/// <summary>
			/// 매도회원사명2
			/// </summary>
			public const string offertrad2 = "offertrad2";
			/// <summary>
			/// 매수회원사명2
			/// </summary>
			public const string bidtrad2 = "bidtrad2";
			/// <summary>
			/// 매도거래량2
			/// </summary>
			public const string tradmdvol2 = "tradmdvol2";
			/// <summary>
			/// 매수거래량2
			/// </summary>
			public const string tradmsvol2 = "tradmsvol2";
			/// <summary>
			/// 매도거래량비중2
			/// </summary>
			public const string tradmdrate2 = "tradmdrate2";
			/// <summary>
			/// 매수거래량비중2
			/// </summary>
			public const string tradmsrate2 = "tradmsrate2";
			/// <summary>
			/// 매도거래량직전대비2
			/// </summary>
			public const string tradmdcha2 = "tradmdcha2";
			/// <summary>
			/// 매수거래량직전대비2
			/// </summary>
			public const string tradmscha2 = "tradmscha2";
			/// <summary>
			/// 매도증권사코드3
			/// </summary>
			public const string offerno3 = "offerno3";
			/// <summary>
			/// 매수증권사코드3
			/// </summary>
			public const string bidno3 = "bidno3";
			/// <summary>
			/// 매도회원사명3
			/// </summary>
			public const string offertrad3 = "offertrad3";
			/// <summary>
			/// 매수회원사명3
			/// </summary>
			public const string bidtrad3 = "bidtrad3";
			/// <summary>
			/// 매도거래량3
			/// </summary>
			public const string tradmdvol3 = "tradmdvol3";
			/// <summary>
			/// 매수거래량3
			/// </summary>
			public const string tradmsvol3 = "tradmsvol3";
			/// <summary>
			/// 매도거래량비중3
			/// </summary>
			public const string tradmdrate3 = "tradmdrate3";
			/// <summary>
			/// 매수거래량비중3
			/// </summary>
			public const string tradmsrate3 = "tradmsrate3";
			/// <summary>
			/// 매도거래량직전대비3
			/// </summary>
			public const string tradmdcha3 = "tradmdcha3";
			/// <summary>
			/// 매수거래량직전대비3
			/// </summary>
			public const string tradmscha3 = "tradmscha3";
			/// <summary>
			/// 매도증권사코드4
			/// </summary>
			public const string offerno4 = "offerno4";
			/// <summary>
			/// 매수증권사코드4
			/// </summary>
			public const string bidno4 = "bidno4";
			/// <summary>
			/// 매도회원사명4
			/// </summary>
			public const string offertrad4 = "offertrad4";
			/// <summary>
			/// 매수회원사명4
			/// </summary>
			public const string bidtrad4 = "bidtrad4";
			/// <summary>
			/// 매도거래량4
			/// </summary>
			public const string tradmdvol4 = "tradmdvol4";
			/// <summary>
			/// 매수거래량4
			/// </summary>
			public const string tradmsvol4 = "tradmsvol4";
			/// <summary>
			/// 매도거래량비중4
			/// </summary>
			public const string tradmdrate4 = "tradmdrate4";
			/// <summary>
			/// 매수거래량비중4
			/// </summary>
			public const string tradmsrate4 = "tradmsrate4";
			/// <summary>
			/// 매도거래량직전대비4
			/// </summary>
			public const string tradmdcha4 = "tradmdcha4";
			/// <summary>
			/// 매수거래량직전대비4
			/// </summary>
			public const string tradmscha4 = "tradmscha4";
			/// <summary>
			/// 매도증권사코드5
			/// </summary>
			public const string offerno5 = "offerno5";
			/// <summary>
			/// 매수증권사코드5
			/// </summary>
			public const string bidno5 = "bidno5";
			/// <summary>
			/// 매도회원사명5
			/// </summary>
			public const string offertrad5 = "offertrad5";
			/// <summary>
			/// 매수회원사명5
			/// </summary>
			public const string bidtrad5 = "bidtrad5";
			/// <summary>
			/// 매도거래량5
			/// </summary>
			public const string tradmdvol5 = "tradmdvol5";
			/// <summary>
			/// 매수거래량5
			/// </summary>
			public const string tradmsvol5 = "tradmsvol5";
			/// <summary>
			/// 매도거래량비중5
			/// </summary>
			public const string tradmdrate5 = "tradmdrate5";
			/// <summary>
			/// 매수거래량비중5
			/// </summary>
			public const string tradmsrate5 = "tradmsrate5";
			/// <summary>
			/// 매도거래량직전대비5
			/// </summary>
			public const string tradmdcha5 = "tradmdcha5";
			/// <summary>
			/// 매수거래량직전대비5
			/// </summary>
			public const string tradmscha5 = "tradmscha5";
			/// <summary>
			/// 외국계증권사매도합계
			/// </summary>
			public const string ftradmdvol = "ftradmdvol";
			/// <summary>
			/// 외국계증권사매수합계
			/// </summary>
			public const string ftradmsvol = "ftradmsvol";
			/// <summary>
			/// 외국계증권사매도거래량비중
			/// </summary>
			public const string ftradmdrate = "ftradmdrate";
			/// <summary>
			/// 외국계증권사매수거래량비중
			/// </summary>
			public const string ftradmsrate = "ftradmsrate";
			/// <summary>
			/// 외국계증권사매도거래량직전대비
			/// </summary>
			public const string ftradmdcha = "ftradmdcha";
			/// <summary>
			/// 외국계증권사매수거래량직전대비
			/// </summary>
			public const string ftradmscha = "ftradmscha";
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string shcode = "shcode";
		}

		public static string[] AllFields = new string[]
		{
			F.offerno1,
			F.bidno1,
			F.offertrad1,
			F.bidtrad1,
			F.tradmdvol1,
			F.tradmsvol1,
			F.tradmdrate1,
			F.tradmsrate1,
			F.tradmdcha1,
			F.tradmscha1,
			F.offerno2,
			F.bidno2,
			F.offertrad2,
			F.bidtrad2,
			F.tradmdvol2,
			F.tradmsvol2,
			F.tradmdrate2,
			F.tradmsrate2,
			F.tradmdcha2,
			F.tradmscha2,
			F.offerno3,
			F.bidno3,
			F.offertrad3,
			F.bidtrad3,
			F.tradmdvol3,
			F.tradmsvol3,
			F.tradmdrate3,
			F.tradmsrate3,
			F.tradmdcha3,
			F.tradmscha3,
			F.offerno4,
			F.bidno4,
			F.offertrad4,
			F.bidtrad4,
			F.tradmdvol4,
			F.tradmsvol4,
			F.tradmdrate4,
			F.tradmsrate4,
			F.tradmdcha4,
			F.tradmscha4,
			F.offerno5,
			F.bidno5,
			F.offertrad5,
			F.bidtrad5,
			F.tradmdvol5,
			F.tradmsvol5,
			F.tradmdrate5,
			F.tradmsrate5,
			F.tradmdcha5,
			F.tradmscha5,
			F.ftradmdvol,
			F.ftradmsvol,
			F.ftradmdrate,
			F.ftradmsrate,
			F.ftradmdcha,
			F.ftradmscha,
			F.shcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["offerno1"] = new XAQueryFieldInfo("char", offerno1, offerno1, "매도증권사코드1", (decimal)3);
			dict["bidno1"] = new XAQueryFieldInfo("char", bidno1, bidno1, "매수증권사코드1", (decimal)3);
			dict["offertrad1"] = new XAQueryFieldInfo("char", offertrad1, offertrad1, "매도회원사명1", (decimal)6);
			dict["bidtrad1"] = new XAQueryFieldInfo("char", bidtrad1, bidtrad1, "매수회원사명1", (decimal)6);
			dict["tradmdvol1"] = new XAQueryFieldInfo("long", tradmdvol1, tradmdvol1.ToString("d10"), "매도거래량1", (decimal)10);
			dict["tradmsvol1"] = new XAQueryFieldInfo("long", tradmsvol1, tradmsvol1.ToString("d10"), "매수거래량1", (decimal)10);
			dict["tradmdrate1"] = new XAQueryFieldInfo("float", tradmdrate1, tradmdrate1.ToString("000000.00"), "매도거래량비중1", (decimal)6.2);
			dict["tradmsrate1"] = new XAQueryFieldInfo("float", tradmsrate1, tradmsrate1.ToString("000000.00"), "매도거래량비중1", (decimal)6.2);
			dict["tradmdcha1"] = new XAQueryFieldInfo("long", tradmdcha1, tradmdcha1.ToString("d10"), "매도거래량직전대비1", (decimal)10);
			dict["tradmscha1"] = new XAQueryFieldInfo("long", tradmscha1, tradmscha1.ToString("d10"), "매수거래량직전대비1", (decimal)10);
			dict["offerno2"] = new XAQueryFieldInfo("char", offerno2, offerno2, "매도증권사코드2", (decimal)3);
			dict["bidno2"] = new XAQueryFieldInfo("char", bidno2, bidno2, "매수증권사코드2", (decimal)3);
			dict["offertrad2"] = new XAQueryFieldInfo("char", offertrad2, offertrad2, "매도회원사명2", (decimal)6);
			dict["bidtrad2"] = new XAQueryFieldInfo("char", bidtrad2, bidtrad2, "매수회원사명2", (decimal)6);
			dict["tradmdvol2"] = new XAQueryFieldInfo("long", tradmdvol2, tradmdvol2.ToString("d10"), "매도거래량2", (decimal)10);
			dict["tradmsvol2"] = new XAQueryFieldInfo("long", tradmsvol2, tradmsvol2.ToString("d10"), "매수거래량2", (decimal)10);
			dict["tradmdrate2"] = new XAQueryFieldInfo("float", tradmdrate2, tradmdrate2.ToString("000000.00"), "매도거래량비중2", (decimal)6.2);
			dict["tradmsrate2"] = new XAQueryFieldInfo("float", tradmsrate2, tradmsrate2.ToString("000000.00"), "매수거래량비중2", (decimal)6.2);
			dict["tradmdcha2"] = new XAQueryFieldInfo("long", tradmdcha2, tradmdcha2.ToString("d10"), "매도거래량직전대비2", (decimal)10);
			dict["tradmscha2"] = new XAQueryFieldInfo("long", tradmscha2, tradmscha2.ToString("d10"), "매수거래량직전대비2", (decimal)10);
			dict["offerno3"] = new XAQueryFieldInfo("char", offerno3, offerno3, "매도증권사코드3", (decimal)3);
			dict["bidno3"] = new XAQueryFieldInfo("char", bidno3, bidno3, "매수증권사코드3", (decimal)3);
			dict["offertrad3"] = new XAQueryFieldInfo("char", offertrad3, offertrad3, "매도회원사명3", (decimal)6);
			dict["bidtrad3"] = new XAQueryFieldInfo("char", bidtrad3, bidtrad3, "매수회원사명3", (decimal)6);
			dict["tradmdvol3"] = new XAQueryFieldInfo("long", tradmdvol3, tradmdvol3.ToString("d10"), "매도거래량3", (decimal)10);
			dict["tradmsvol3"] = new XAQueryFieldInfo("long", tradmsvol3, tradmsvol3.ToString("d10"), "매수거래량3", (decimal)10);
			dict["tradmdrate3"] = new XAQueryFieldInfo("float", tradmdrate3, tradmdrate3.ToString("000000.00"), "매도거래량비중3", (decimal)6.2);
			dict["tradmsrate3"] = new XAQueryFieldInfo("float", tradmsrate3, tradmsrate3.ToString("000000.00"), "매수거래량비중3", (decimal)6.2);
			dict["tradmdcha3"] = new XAQueryFieldInfo("long", tradmdcha3, tradmdcha3.ToString("d10"), "매도거래량직전대비3", (decimal)10);
			dict["tradmscha3"] = new XAQueryFieldInfo("long", tradmscha3, tradmscha3.ToString("d10"), "매수거래량직전대비3", (decimal)10);
			dict["offerno4"] = new XAQueryFieldInfo("char", offerno4, offerno4, "매도증권사코드4", (decimal)3);
			dict["bidno4"] = new XAQueryFieldInfo("char", bidno4, bidno4, "매수증권사코드4", (decimal)3);
			dict["offertrad4"] = new XAQueryFieldInfo("char", offertrad4, offertrad4, "매도회원사명4", (decimal)6);
			dict["bidtrad4"] = new XAQueryFieldInfo("char", bidtrad4, bidtrad4, "매수회원사명4", (decimal)6);
			dict["tradmdvol4"] = new XAQueryFieldInfo("long", tradmdvol4, tradmdvol4.ToString("d10"), "매도거래량4", (decimal)10);
			dict["tradmsvol4"] = new XAQueryFieldInfo("long", tradmsvol4, tradmsvol4.ToString("d10"), "매수거래량4", (decimal)10);
			dict["tradmdrate4"] = new XAQueryFieldInfo("float", tradmdrate4, tradmdrate4.ToString("000000.00"), "매도거래량비중4", (decimal)6.2);
			dict["tradmsrate4"] = new XAQueryFieldInfo("float", tradmsrate4, tradmsrate4.ToString("000000.00"), "매수거래량비중4", (decimal)6.2);
			dict["tradmdcha4"] = new XAQueryFieldInfo("long", tradmdcha4, tradmdcha4.ToString("d10"), "매도거래량직전대비4", (decimal)10);
			dict["tradmscha4"] = new XAQueryFieldInfo("long", tradmscha4, tradmscha4.ToString("d10"), "매수거래량직전대비4", (decimal)10);
			dict["offerno5"] = new XAQueryFieldInfo("char", offerno5, offerno5, "매도증권사코드5", (decimal)3);
			dict["bidno5"] = new XAQueryFieldInfo("char", bidno5, bidno5, "매수증권사코드5", (decimal)3);
			dict["offertrad5"] = new XAQueryFieldInfo("char", offertrad5, offertrad5, "매도회원사명5", (decimal)6);
			dict["bidtrad5"] = new XAQueryFieldInfo("char", bidtrad5, bidtrad5, "매수회원사명5", (decimal)6);
			dict["tradmdvol5"] = new XAQueryFieldInfo("long", tradmdvol5, tradmdvol5.ToString("d10"), "매도거래량5", (decimal)10);
			dict["tradmsvol5"] = new XAQueryFieldInfo("long", tradmsvol5, tradmsvol5.ToString("d10"), "매수거래량5", (decimal)10);
			dict["tradmdrate5"] = new XAQueryFieldInfo("float", tradmdrate5, tradmdrate5.ToString("000000.00"), "매도거래량비중5", (decimal)6.2);
			dict["tradmsrate5"] = new XAQueryFieldInfo("float", tradmsrate5, tradmsrate5.ToString("000000.00"), "매수거래량비중5", (decimal)6.2);
			dict["tradmdcha5"] = new XAQueryFieldInfo("long", tradmdcha5, tradmdcha5.ToString("d10"), "매도거래량직전대비5", (decimal)10);
			dict["tradmscha5"] = new XAQueryFieldInfo("long", tradmscha5, tradmscha5.ToString("d10"), "매수거래량직전대비5", (decimal)10);
			dict["ftradmdvol"] = new XAQueryFieldInfo("char", ftradmdvol, ftradmdvol, "외국계증권사매도합계", (decimal)10);
			dict["ftradmsvol"] = new XAQueryFieldInfo("char", ftradmsvol, ftradmsvol, "외국계증권사매수합계", (decimal)10);
			dict["ftradmdrate"] = new XAQueryFieldInfo("float", ftradmdrate, ftradmdrate.ToString("000000.00"), "외국계증권사매도거래량비중", (decimal)6.2);
			dict["ftradmsrate"] = new XAQueryFieldInfo("float", ftradmsrate, ftradmsrate.ToString("000000.00"), "외국계증권사매수거래량비중", (decimal)6.2);
			dict["ftradmdcha"] = new XAQueryFieldInfo("char", ftradmdcha, ftradmdcha, "외국계증권사매도거래량직전대비", (decimal)10);
			dict["ftradmscha"] = new XAQueryFieldInfo("char", ftradmscha, ftradmscha, "외국계증권사매수거래량직전대비", (decimal)10);
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)6);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "offerno1":
					this.offerno1 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "bidno1":
					this.bidno1 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "offertrad1":
					this.offertrad1 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "bidtrad1":
					this.bidtrad1 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "tradmdvol1":
					this.tradmdvol1 = fieldInfo.FieldValue.ParseLong("tradmdvol1");
				break;

				case "tradmsvol1":
					this.tradmsvol1 = fieldInfo.FieldValue.ParseLong("tradmsvol1");
				break;

				case "tradmdrate1":
					this.tradmdrate1 = fieldInfo.FieldValue.ParseFloat("tradmdrate1");
				break;

				case "tradmsrate1":
					this.tradmsrate1 = fieldInfo.FieldValue.ParseFloat("tradmsrate1");
				break;

				case "tradmdcha1":
					this.tradmdcha1 = fieldInfo.FieldValue.ParseLong("tradmdcha1");
				break;

				case "tradmscha1":
					this.tradmscha1 = fieldInfo.FieldValue.ParseLong("tradmscha1");
				break;

				case "offerno2":
					this.offerno2 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "bidno2":
					this.bidno2 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "offertrad2":
					this.offertrad2 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "bidtrad2":
					this.bidtrad2 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "tradmdvol2":
					this.tradmdvol2 = fieldInfo.FieldValue.ParseLong("tradmdvol2");
				break;

				case "tradmsvol2":
					this.tradmsvol2 = fieldInfo.FieldValue.ParseLong("tradmsvol2");
				break;

				case "tradmdrate2":
					this.tradmdrate2 = fieldInfo.FieldValue.ParseFloat("tradmdrate2");
				break;

				case "tradmsrate2":
					this.tradmsrate2 = fieldInfo.FieldValue.ParseFloat("tradmsrate2");
				break;

				case "tradmdcha2":
					this.tradmdcha2 = fieldInfo.FieldValue.ParseLong("tradmdcha2");
				break;

				case "tradmscha2":
					this.tradmscha2 = fieldInfo.FieldValue.ParseLong("tradmscha2");
				break;

				case "offerno3":
					this.offerno3 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "bidno3":
					this.bidno3 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "offertrad3":
					this.offertrad3 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "bidtrad3":
					this.bidtrad3 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "tradmdvol3":
					this.tradmdvol3 = fieldInfo.FieldValue.ParseLong("tradmdvol3");
				break;

				case "tradmsvol3":
					this.tradmsvol3 = fieldInfo.FieldValue.ParseLong("tradmsvol3");
				break;

				case "tradmdrate3":
					this.tradmdrate3 = fieldInfo.FieldValue.ParseFloat("tradmdrate3");
				break;

				case "tradmsrate3":
					this.tradmsrate3 = fieldInfo.FieldValue.ParseFloat("tradmsrate3");
				break;

				case "tradmdcha3":
					this.tradmdcha3 = fieldInfo.FieldValue.ParseLong("tradmdcha3");
				break;

				case "tradmscha3":
					this.tradmscha3 = fieldInfo.FieldValue.ParseLong("tradmscha3");
				break;

				case "offerno4":
					this.offerno4 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "bidno4":
					this.bidno4 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "offertrad4":
					this.offertrad4 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "bidtrad4":
					this.bidtrad4 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "tradmdvol4":
					this.tradmdvol4 = fieldInfo.FieldValue.ParseLong("tradmdvol4");
				break;

				case "tradmsvol4":
					this.tradmsvol4 = fieldInfo.FieldValue.ParseLong("tradmsvol4");
				break;

				case "tradmdrate4":
					this.tradmdrate4 = fieldInfo.FieldValue.ParseFloat("tradmdrate4");
				break;

				case "tradmsrate4":
					this.tradmsrate4 = fieldInfo.FieldValue.ParseFloat("tradmsrate4");
				break;

				case "tradmdcha4":
					this.tradmdcha4 = fieldInfo.FieldValue.ParseLong("tradmdcha4");
				break;

				case "tradmscha4":
					this.tradmscha4 = fieldInfo.FieldValue.ParseLong("tradmscha4");
				break;

				case "offerno5":
					this.offerno5 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "bidno5":
					this.bidno5 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "offertrad5":
					this.offertrad5 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "bidtrad5":
					this.bidtrad5 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "tradmdvol5":
					this.tradmdvol5 = fieldInfo.FieldValue.ParseLong("tradmdvol5");
				break;

				case "tradmsvol5":
					this.tradmsvol5 = fieldInfo.FieldValue.ParseLong("tradmsvol5");
				break;

				case "tradmdrate5":
					this.tradmdrate5 = fieldInfo.FieldValue.ParseFloat("tradmdrate5");
				break;

				case "tradmsrate5":
					this.tradmsrate5 = fieldInfo.FieldValue.ParseFloat("tradmsrate5");
				break;

				case "tradmdcha5":
					this.tradmdcha5 = fieldInfo.FieldValue.ParseLong("tradmdcha5");
				break;

				case "tradmscha5":
					this.tradmscha5 = fieldInfo.FieldValue.ParseLong("tradmscha5");
				break;

				case "ftradmdvol":
					this.ftradmdvol = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ftradmsvol":
					this.ftradmsvol = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ftradmdrate":
					this.ftradmdrate = fieldInfo.FieldValue.ParseFloat("ftradmdrate");
				break;

				case "ftradmsrate":
					this.ftradmsrate = fieldInfo.FieldValue.ParseFloat("ftradmsrate");
				break;

				case "ftradmdcha":
					this.ftradmdcha = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ftradmscha":
					this.ftradmscha = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XRk1_OutBlock FromQuery(XRk1_ query)
		{
			XRk1_OutBlock block = new XRk1_OutBlock();
			block.IsValidData = true;
			block.InvalidReason = "";
			try
			{
				block.offerno1 = query.GetFieldData(block.GetBlockName(), "offerno1").TrimEnd('?'); // char 3
				block.bidno1 = query.GetFieldData(block.GetBlockName(), "bidno1").TrimEnd('?'); // char 3
				block.offertrad1 = query.GetFieldData(block.GetBlockName(), "offertrad1").TrimEnd('?'); // char 6
				block.bidtrad1 = query.GetFieldData(block.GetBlockName(), "bidtrad1").TrimEnd('?'); // char 6
				block.tradmdvol1 = query.GetFieldData(block.GetBlockName(), "tradmdvol1").ParseLong("tradmdvol1"); // long 10
				block.tradmsvol1 = query.GetFieldData(block.GetBlockName(), "tradmsvol1").ParseLong("tradmsvol1"); // long 10
				block.tradmdrate1 = query.GetFieldData(block.GetBlockName(), "tradmdrate1").ParseFloat("tradmdrate1"); // float 6.2
				block.tradmsrate1 = query.GetFieldData(block.GetBlockName(), "tradmsrate1").ParseFloat("tradmsrate1"); // float 6.2
				block.tradmdcha1 = query.GetFieldData(block.GetBlockName(), "tradmdcha1").ParseLong("tradmdcha1"); // long 10
				block.tradmscha1 = query.GetFieldData(block.GetBlockName(), "tradmscha1").ParseLong("tradmscha1"); // long 10
				block.offerno2 = query.GetFieldData(block.GetBlockName(), "offerno2").TrimEnd('?'); // char 3
				block.bidno2 = query.GetFieldData(block.GetBlockName(), "bidno2").TrimEnd('?'); // char 3
				block.offertrad2 = query.GetFieldData(block.GetBlockName(), "offertrad2").TrimEnd('?'); // char 6
				block.bidtrad2 = query.GetFieldData(block.GetBlockName(), "bidtrad2").TrimEnd('?'); // char 6
				block.tradmdvol2 = query.GetFieldData(block.GetBlockName(), "tradmdvol2").ParseLong("tradmdvol2"); // long 10
				block.tradmsvol2 = query.GetFieldData(block.GetBlockName(), "tradmsvol2").ParseLong("tradmsvol2"); // long 10
				block.tradmdrate2 = query.GetFieldData(block.GetBlockName(), "tradmdrate2").ParseFloat("tradmdrate2"); // float 6.2
				block.tradmsrate2 = query.GetFieldData(block.GetBlockName(), "tradmsrate2").ParseFloat("tradmsrate2"); // float 6.2
				block.tradmdcha2 = query.GetFieldData(block.GetBlockName(), "tradmdcha2").ParseLong("tradmdcha2"); // long 10
				block.tradmscha2 = query.GetFieldData(block.GetBlockName(), "tradmscha2").ParseLong("tradmscha2"); // long 10
				block.offerno3 = query.GetFieldData(block.GetBlockName(), "offerno3").TrimEnd('?'); // char 3
				block.bidno3 = query.GetFieldData(block.GetBlockName(), "bidno3").TrimEnd('?'); // char 3
				block.offertrad3 = query.GetFieldData(block.GetBlockName(), "offertrad3").TrimEnd('?'); // char 6
				block.bidtrad3 = query.GetFieldData(block.GetBlockName(), "bidtrad3").TrimEnd('?'); // char 6
				block.tradmdvol3 = query.GetFieldData(block.GetBlockName(), "tradmdvol3").ParseLong("tradmdvol3"); // long 10
				block.tradmsvol3 = query.GetFieldData(block.GetBlockName(), "tradmsvol3").ParseLong("tradmsvol3"); // long 10
				block.tradmdrate3 = query.GetFieldData(block.GetBlockName(), "tradmdrate3").ParseFloat("tradmdrate3"); // float 6.2
				block.tradmsrate3 = query.GetFieldData(block.GetBlockName(), "tradmsrate3").ParseFloat("tradmsrate3"); // float 6.2
				block.tradmdcha3 = query.GetFieldData(block.GetBlockName(), "tradmdcha3").ParseLong("tradmdcha3"); // long 10
				block.tradmscha3 = query.GetFieldData(block.GetBlockName(), "tradmscha3").ParseLong("tradmscha3"); // long 10
				block.offerno4 = query.GetFieldData(block.GetBlockName(), "offerno4").TrimEnd('?'); // char 3
				block.bidno4 = query.GetFieldData(block.GetBlockName(), "bidno4").TrimEnd('?'); // char 3
				block.offertrad4 = query.GetFieldData(block.GetBlockName(), "offertrad4").TrimEnd('?'); // char 6
				block.bidtrad4 = query.GetFieldData(block.GetBlockName(), "bidtrad4").TrimEnd('?'); // char 6
				block.tradmdvol4 = query.GetFieldData(block.GetBlockName(), "tradmdvol4").ParseLong("tradmdvol4"); // long 10
				block.tradmsvol4 = query.GetFieldData(block.GetBlockName(), "tradmsvol4").ParseLong("tradmsvol4"); // long 10
				block.tradmdrate4 = query.GetFieldData(block.GetBlockName(), "tradmdrate4").ParseFloat("tradmdrate4"); // float 6.2
				block.tradmsrate4 = query.GetFieldData(block.GetBlockName(), "tradmsrate4").ParseFloat("tradmsrate4"); // float 6.2
				block.tradmdcha4 = query.GetFieldData(block.GetBlockName(), "tradmdcha4").ParseLong("tradmdcha4"); // long 10
				block.tradmscha4 = query.GetFieldData(block.GetBlockName(), "tradmscha4").ParseLong("tradmscha4"); // long 10
				block.offerno5 = query.GetFieldData(block.GetBlockName(), "offerno5").TrimEnd('?'); // char 3
				block.bidno5 = query.GetFieldData(block.GetBlockName(), "bidno5").TrimEnd('?'); // char 3
				block.offertrad5 = query.GetFieldData(block.GetBlockName(), "offertrad5").TrimEnd('?'); // char 6
				block.bidtrad5 = query.GetFieldData(block.GetBlockName(), "bidtrad5").TrimEnd('?'); // char 6
				block.tradmdvol5 = query.GetFieldData(block.GetBlockName(), "tradmdvol5").ParseLong("tradmdvol5"); // long 10
				block.tradmsvol5 = query.GetFieldData(block.GetBlockName(), "tradmsvol5").ParseLong("tradmsvol5"); // long 10
				block.tradmdrate5 = query.GetFieldData(block.GetBlockName(), "tradmdrate5").ParseFloat("tradmdrate5"); // float 6.2
				block.tradmsrate5 = query.GetFieldData(block.GetBlockName(), "tradmsrate5").ParseFloat("tradmsrate5"); // float 6.2
				block.tradmdcha5 = query.GetFieldData(block.GetBlockName(), "tradmdcha5").ParseLong("tradmdcha5"); // long 10
				block.tradmscha5 = query.GetFieldData(block.GetBlockName(), "tradmscha5").ParseLong("tradmscha5"); // long 10
				block.ftradmdvol = query.GetFieldData(block.GetBlockName(), "ftradmdvol").TrimEnd('?'); // char 10
				block.ftradmsvol = query.GetFieldData(block.GetBlockName(), "ftradmsvol").TrimEnd('?'); // char 10
				block.ftradmdrate = query.GetFieldData(block.GetBlockName(), "ftradmdrate").ParseFloat("ftradmdrate"); // float 6.2
				block.ftradmsrate = query.GetFieldData(block.GetBlockName(), "ftradmsrate").ParseFloat("ftradmsrate"); // float 6.2
				block.ftradmdcha = query.GetFieldData(block.GetBlockName(), "ftradmdcha").TrimEnd('?'); // char 10
				block.ftradmscha = query.GetFieldData(block.GetBlockName(), "ftradmscha").TrimEnd('?'); // char 10
				block.shcode = query.GetFieldData(block.GetBlockName(), "shcode").TrimEnd('?'); // char 6

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (offerno1?.Length > 3) return false; // char 3
			if (bidno1?.Length > 3) return false; // char 3
			if (offertrad1?.Length > 6) return false; // char 6
			if (bidtrad1?.Length > 6) return false; // char 6
			if (tradmdvol1.ToString().Length > 10) return false; // long 10
			if (tradmsvol1.ToString().Length > 10) return false; // long 10
			// tradmdrate1 float 6.2
			// tradmsrate1 float 6.2
			if (tradmdcha1.ToString().Length > 10) return false; // long 10
			if (tradmscha1.ToString().Length > 10) return false; // long 10
			if (offerno2?.Length > 3) return false; // char 3
			if (bidno2?.Length > 3) return false; // char 3
			if (offertrad2?.Length > 6) return false; // char 6
			if (bidtrad2?.Length > 6) return false; // char 6
			if (tradmdvol2.ToString().Length > 10) return false; // long 10
			if (tradmsvol2.ToString().Length > 10) return false; // long 10
			// tradmdrate2 float 6.2
			// tradmsrate2 float 6.2
			if (tradmdcha2.ToString().Length > 10) return false; // long 10
			if (tradmscha2.ToString().Length > 10) return false; // long 10
			if (offerno3?.Length > 3) return false; // char 3
			if (bidno3?.Length > 3) return false; // char 3
			if (offertrad3?.Length > 6) return false; // char 6
			if (bidtrad3?.Length > 6) return false; // char 6
			if (tradmdvol3.ToString().Length > 10) return false; // long 10
			if (tradmsvol3.ToString().Length > 10) return false; // long 10
			// tradmdrate3 float 6.2
			// tradmsrate3 float 6.2
			if (tradmdcha3.ToString().Length > 10) return false; // long 10
			if (tradmscha3.ToString().Length > 10) return false; // long 10
			if (offerno4?.Length > 3) return false; // char 3
			if (bidno4?.Length > 3) return false; // char 3
			if (offertrad4?.Length > 6) return false; // char 6
			if (bidtrad4?.Length > 6) return false; // char 6
			if (tradmdvol4.ToString().Length > 10) return false; // long 10
			if (tradmsvol4.ToString().Length > 10) return false; // long 10
			// tradmdrate4 float 6.2
			// tradmsrate4 float 6.2
			if (tradmdcha4.ToString().Length > 10) return false; // long 10
			if (tradmscha4.ToString().Length > 10) return false; // long 10
			if (offerno5?.Length > 3) return false; // char 3
			if (bidno5?.Length > 3) return false; // char 3
			if (offertrad5?.Length > 6) return false; // char 6
			if (bidtrad5?.Length > 6) return false; // char 6
			if (tradmdvol5.ToString().Length > 10) return false; // long 10
			if (tradmsvol5.ToString().Length > 10) return false; // long 10
			// tradmdrate5 float 6.2
			// tradmsrate5 float 6.2
			if (tradmdcha5.ToString().Length > 10) return false; // long 10
			if (tradmscha5.ToString().Length > 10) return false; // long 10
			if (ftradmdvol?.Length > 10) return false; // char 10
			if (ftradmsvol?.Length > 10) return false; // char 10
			// ftradmdrate float 6.2
			// ftradmsrate float 6.2
			if (ftradmdcha?.Length > 10) return false; // char 10
			if (ftradmscha?.Length > 10) return false; // char 10
			if (shcode?.Length > 6) return false; // char 6

			return true;
		}
	}

	public partial class XRk1_ : XingReal
	{
		/// <summary>
		/// k1_
		/// </summary>
		public const string _typeName = "k1_";
		/// <summary>
		/// ELW거래원(k1)
		/// </summary>
		public const string _typeDesc = "ELW거래원(k1)";
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
		/// k1_
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// ELW거래원(k1)
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

		public XRk1_() : base("k1_") { }


		public bool SetFields(XRk1_InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaReal.SetFieldData(block.GetBlockName(), "shcode", block.shcode); // char 6

			return true;
		}

		public XRk1_OutBlock GetBlock()
		{
			XRk1_OutBlock instance = XRk1_OutBlock.FromQuery(this);
			return instance;

		}


	}

}
