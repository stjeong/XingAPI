using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1955InBlock : XingBlock
	{
		/// <summary>
		/// t1955InBlock
		/// </summary>
		public const string _blockName = "t1955InBlock";
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
		/// t1955InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1955InBlock
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
		/// 기초자산chk구분
		/// </summary>
		[XAQueryFieldAttribute("chkitem", "기초자산chk구분", "char", "1")]
		public char chkitem;
		/// <summary>
		/// 기초자산코드
		/// </summary>
		[XAQueryFieldAttribute("cbitem", "기초자산코드", "char", "12")]
		public string cbitem;
		/// <summary>
		/// 발행사chk구분
		/// </summary>
		[XAQueryFieldAttribute("chkissuer", "발행사chk구분", "char", "1")]
		public char chkissuer;
		/// <summary>
		/// 발행사
		/// </summary>
		[XAQueryFieldAttribute("cbissuer", "발행사", "char", "12")]
		public string cbissuer;
		/// <summary>
		/// 권리chk구분
		/// </summary>
		[XAQueryFieldAttribute("chkcallput", "권리chk구분", "char", "1")]
		public char chkcallput;
		/// <summary>
		/// 권리(call:01.put:02)
		/// </summary>
		[XAQueryFieldAttribute("cbcallput", "권리(call:01.put:02)", "char", "2")]
		public string cbcallput;
		/// <summary>
		/// 행사가chk구분
		/// </summary>
		[XAQueryFieldAttribute("chkexec", "행사가chk구분", "char", "1")]
		public char chkexec;
		/// <summary>
		/// 행사가(>=:1.<=:2)
		/// </summary>
		[XAQueryFieldAttribute("cbexec", "행사가(>=:1.<=:2)", "char", "1")]
		public char cbexec;
		/// <summary>
		/// 행사방식chk구분
		/// </summary>
		[XAQueryFieldAttribute("chktype", "행사방식chk구분", "char", "1")]
		public char chktype;
		/// <summary>
		/// 행사방식
		/// </summary>
		[XAQueryFieldAttribute("cbtype", "행사방식", "char", "2")]
		public string cbtype;
		/// <summary>
		/// 결제방법chk구분
		/// </summary>
		[XAQueryFieldAttribute("chksettle", "결제방법chk구분", "char", "1")]
		public char chksettle;
		/// <summary>
		/// 결제방법
		/// </summary>
		[XAQueryFieldAttribute("cbsettle", "결제방법", "char", "2")]
		public string cbsettle;
		/// <summary>
		/// 만기chk구분
		/// </summary>
		[XAQueryFieldAttribute("chklast", "만기chk구분", "char", "1")]
		public char chklast;
		/// <summary>
		/// 만기월별
		/// </summary>
		[XAQueryFieldAttribute("cblast", "만기월별", "char", "6")]
		public string cblast;
		/// <summary>
		/// 행사가격chk구분
		/// </summary>
		[XAQueryFieldAttribute("chkelwexec", "행사가격chk구분", "char", "1")]
		public char chkelwexec;
		/// <summary>
		/// 행사가이상
		/// </summary>
		[XAQueryFieldAttribute("elwexecs", "행사가이상", "float", "10.2")]
		public float elwexecs;
		/// <summary>
		/// 행사가이하
		/// </summary>
		[XAQueryFieldAttribute("elwexece", "행사가이하", "float", "10.2")]
		public float elwexece;
		/// <summary>
		/// 거래량chk구분
		/// </summary>
		[XAQueryFieldAttribute("chkvolume", "거래량chk구분", "char", "1")]
		public char chkvolume;
		/// <summary>
		/// 거래량이상
		/// </summary>
		[XAQueryFieldAttribute("volumes", "거래량이상", "float", "12")]
		public float volumes;
		/// <summary>
		/// 거래량이하
		/// </summary>
		[XAQueryFieldAttribute("volumee", "거래량이하", "float", "12")]
		public float volumee;
		/// <summary>
		/// 등락율chk구분
		/// </summary>
		[XAQueryFieldAttribute("chkrate", "등락율chk구분", "char", "1")]
		public char chkrate;
		/// <summary>
		/// 등락율이상
		/// </summary>
		[XAQueryFieldAttribute("rates", "등락율이상", "float", "6.2")]
		public float rates;
		/// <summary>
		/// 등락율이하
		/// </summary>
		[XAQueryFieldAttribute("ratee", "등락율이하", "float", "6.2")]
		public float ratee;
		/// <summary>
		/// 프리미엄chk구분
		/// </summary>
		[XAQueryFieldAttribute("chkpremium", "프리미엄chk구분", "char", "1")]
		public char chkpremium;
		/// <summary>
		/// 프리미엄이상
		/// </summary>
		[XAQueryFieldAttribute("premiums", "프리미엄이상", "float", "6.2")]
		public float premiums;
		/// <summary>
		/// 프리미엄이하
		/// </summary>
		[XAQueryFieldAttribute("premiume", "프리미엄이하", "float", "6.2")]
		public float premiume;
		/// <summary>
		/// 패리티chk구분
		/// </summary>
		[XAQueryFieldAttribute("chkparity", "패리티chk구분", "char", "1")]
		public char chkparity;
		/// <summary>
		/// 패리티이상
		/// </summary>
		[XAQueryFieldAttribute("paritys", "패리티이상", "float", "6.2")]
		public float paritys;
		/// <summary>
		/// 패리티이하
		/// </summary>
		[XAQueryFieldAttribute("paritye", "패리티이하", "float", "6.2")]
		public float paritye;
		/// <summary>
		/// 손익분기chk구분
		/// </summary>
		[XAQueryFieldAttribute("chkberate", "손익분기chk구분", "char", "1")]
		public char chkberate;
		/// <summary>
		/// 손익분기이상
		/// </summary>
		[XAQueryFieldAttribute("berates", "손익분기이상", "float", "6.2")]
		public float berates;
		/// <summary>
		/// 손익분기이하
		/// </summary>
		[XAQueryFieldAttribute("beratee", "손익분기이하", "float", "6.2")]
		public float beratee;
		/// <summary>
		/// 자본지지chk구분
		/// </summary>
		[XAQueryFieldAttribute("chkcapt", "자본지지chk구분", "char", "1")]
		public char chkcapt;
		/// <summary>
		/// 자본지지이상
		/// </summary>
		[XAQueryFieldAttribute("capts", "자본지지이상", "float", "6.2")]
		public float capts;
		/// <summary>
		/// 자본지지이하
		/// </summary>
		[XAQueryFieldAttribute("capte", "자본지지이하", "float", "6.2")]
		public float capte;
		/// <summary>
		/// e.기어링chk구분
		/// </summary>
		[XAQueryFieldAttribute("chkegearing", "e.기어링chk구분", "char", "1")]
		public char chkegearing;
		/// <summary>
		/// e.기어링이상
		/// </summary>
		[XAQueryFieldAttribute("egearings", "e.기어링이상", "float", "6.2")]
		public float egearings;
		/// <summary>
		/// e.기어링이하
		/// </summary>
		[XAQueryFieldAttribute("egearinge", "e.기어링이하", "float", "6.2")]
		public float egearinge;
		/// <summary>
		/// 기어링chk구분
		/// </summary>
		[XAQueryFieldAttribute("chkgearing", "기어링chk구분", "char", "1")]
		public char chkgearing;
		/// <summary>
		/// 기어링이상
		/// </summary>
		[XAQueryFieldAttribute("gearings", "기어링이상", "float", "6.2")]
		public float gearings;
		/// <summary>
		/// 기어링이하
		/// </summary>
		[XAQueryFieldAttribute("gearinge", "기어링이하", "float", "6.2")]
		public float gearinge;
		/// <summary>
		/// 델타chk구분
		/// </summary>
		[XAQueryFieldAttribute("chkdelta", "델타chk구분", "char", "1")]
		public char chkdelta;
		/// <summary>
		/// 델타이상
		/// </summary>
		[XAQueryFieldAttribute("deltas", "델타이상", "float", "10.6")]
		public float deltas;
		/// <summary>
		/// 델타이하
		/// </summary>
		[XAQueryFieldAttribute("deltae", "델타이하", "float", "10.6")]
		public float deltae;
		/// <summary>
		/// 쎄타chk구분
		/// </summary>
		[XAQueryFieldAttribute("chktheta", "쎄타chk구분", "char", "1")]
		public char chktheta;
		/// <summary>
		/// 쎄타이상
		/// </summary>
		[XAQueryFieldAttribute("thetas", "쎄타이상", "float", "10.6")]
		public float thetas;
		/// <summary>
		/// 쎄타이하
		/// </summary>
		[XAQueryFieldAttribute("thetae", "쎄타이하", "float", "10.6")]
		public float thetae;
		/// <summary>
		/// 최종거래일chk구분
		/// </summary>
		[XAQueryFieldAttribute("chkduedate", "최종거래일chk구분", "char", "1")]
		public char chkduedate;
		/// <summary>
		/// 최종거래일이상
		/// </summary>
		[XAQueryFieldAttribute("duedates", "최종거래일이상", "char", "8")]
		public string duedates;
		/// <summary>
		/// 최종거래일이하
		/// </summary>
		[XAQueryFieldAttribute("duedatee", "최종거래일이하", "char", "8")]
		public string duedatee;
		/// <summary>
		/// 조기종료chk구분
		/// </summary>
		[XAQueryFieldAttribute("chkkoba", "조기종료chk구분", "char", "1")]
		public char chkkoba;
		/// <summary>
		/// 조기종료(0:전체1:조기종료만2:조기종료제외)
		/// </summary>
		[XAQueryFieldAttribute("cbkoba", "조기종료(0:전체1:조기종료만2:조기종료제외)", "char", "1")]
		public char cbkoba;

		public static class F
		{
			/// <summary>
			/// 기초자산chk구분
			/// </summary>
			public const string chkitem = "chkitem";
			/// <summary>
			/// 기초자산코드
			/// </summary>
			public const string cbitem = "cbitem";
			/// <summary>
			/// 발행사chk구분
			/// </summary>
			public const string chkissuer = "chkissuer";
			/// <summary>
			/// 발행사
			/// </summary>
			public const string cbissuer = "cbissuer";
			/// <summary>
			/// 권리chk구분
			/// </summary>
			public const string chkcallput = "chkcallput";
			/// <summary>
			/// 권리(call:01.put:02)
			/// </summary>
			public const string cbcallput = "cbcallput";
			/// <summary>
			/// 행사가chk구분
			/// </summary>
			public const string chkexec = "chkexec";
			/// <summary>
			/// 행사가(>=:1.<=:2)
			/// </summary>
			public const string cbexec = "cbexec";
			/// <summary>
			/// 행사방식chk구분
			/// </summary>
			public const string chktype = "chktype";
			/// <summary>
			/// 행사방식
			/// </summary>
			public const string cbtype = "cbtype";
			/// <summary>
			/// 결제방법chk구분
			/// </summary>
			public const string chksettle = "chksettle";
			/// <summary>
			/// 결제방법
			/// </summary>
			public const string cbsettle = "cbsettle";
			/// <summary>
			/// 만기chk구분
			/// </summary>
			public const string chklast = "chklast";
			/// <summary>
			/// 만기월별
			/// </summary>
			public const string cblast = "cblast";
			/// <summary>
			/// 행사가격chk구분
			/// </summary>
			public const string chkelwexec = "chkelwexec";
			/// <summary>
			/// 행사가이상
			/// </summary>
			public const string elwexecs = "elwexecs";
			/// <summary>
			/// 행사가이하
			/// </summary>
			public const string elwexece = "elwexece";
			/// <summary>
			/// 거래량chk구분
			/// </summary>
			public const string chkvolume = "chkvolume";
			/// <summary>
			/// 거래량이상
			/// </summary>
			public const string volumes = "volumes";
			/// <summary>
			/// 거래량이하
			/// </summary>
			public const string volumee = "volumee";
			/// <summary>
			/// 등락율chk구분
			/// </summary>
			public const string chkrate = "chkrate";
			/// <summary>
			/// 등락율이상
			/// </summary>
			public const string rates = "rates";
			/// <summary>
			/// 등락율이하
			/// </summary>
			public const string ratee = "ratee";
			/// <summary>
			/// 프리미엄chk구분
			/// </summary>
			public const string chkpremium = "chkpremium";
			/// <summary>
			/// 프리미엄이상
			/// </summary>
			public const string premiums = "premiums";
			/// <summary>
			/// 프리미엄이하
			/// </summary>
			public const string premiume = "premiume";
			/// <summary>
			/// 패리티chk구분
			/// </summary>
			public const string chkparity = "chkparity";
			/// <summary>
			/// 패리티이상
			/// </summary>
			public const string paritys = "paritys";
			/// <summary>
			/// 패리티이하
			/// </summary>
			public const string paritye = "paritye";
			/// <summary>
			/// 손익분기chk구분
			/// </summary>
			public const string chkberate = "chkberate";
			/// <summary>
			/// 손익분기이상
			/// </summary>
			public const string berates = "berates";
			/// <summary>
			/// 손익분기이하
			/// </summary>
			public const string beratee = "beratee";
			/// <summary>
			/// 자본지지chk구분
			/// </summary>
			public const string chkcapt = "chkcapt";
			/// <summary>
			/// 자본지지이상
			/// </summary>
			public const string capts = "capts";
			/// <summary>
			/// 자본지지이하
			/// </summary>
			public const string capte = "capte";
			/// <summary>
			/// e.기어링chk구분
			/// </summary>
			public const string chkegearing = "chkegearing";
			/// <summary>
			/// e.기어링이상
			/// </summary>
			public const string egearings = "egearings";
			/// <summary>
			/// e.기어링이하
			/// </summary>
			public const string egearinge = "egearinge";
			/// <summary>
			/// 기어링chk구분
			/// </summary>
			public const string chkgearing = "chkgearing";
			/// <summary>
			/// 기어링이상
			/// </summary>
			public const string gearings = "gearings";
			/// <summary>
			/// 기어링이하
			/// </summary>
			public const string gearinge = "gearinge";
			/// <summary>
			/// 델타chk구분
			/// </summary>
			public const string chkdelta = "chkdelta";
			/// <summary>
			/// 델타이상
			/// </summary>
			public const string deltas = "deltas";
			/// <summary>
			/// 델타이하
			/// </summary>
			public const string deltae = "deltae";
			/// <summary>
			/// 쎄타chk구분
			/// </summary>
			public const string chktheta = "chktheta";
			/// <summary>
			/// 쎄타이상
			/// </summary>
			public const string thetas = "thetas";
			/// <summary>
			/// 쎄타이하
			/// </summary>
			public const string thetae = "thetae";
			/// <summary>
			/// 최종거래일chk구분
			/// </summary>
			public const string chkduedate = "chkduedate";
			/// <summary>
			/// 최종거래일이상
			/// </summary>
			public const string duedates = "duedates";
			/// <summary>
			/// 최종거래일이하
			/// </summary>
			public const string duedatee = "duedatee";
			/// <summary>
			/// 조기종료chk구분
			/// </summary>
			public const string chkkoba = "chkkoba";
			/// <summary>
			/// 조기종료(0:전체1:조기종료만2:조기종료제외)
			/// </summary>
			public const string cbkoba = "cbkoba";
		}

		public static string[] AllFields = new string[]
		{
			F.chkitem,
			F.cbitem,
			F.chkissuer,
			F.cbissuer,
			F.chkcallput,
			F.cbcallput,
			F.chkexec,
			F.cbexec,
			F.chktype,
			F.cbtype,
			F.chksettle,
			F.cbsettle,
			F.chklast,
			F.cblast,
			F.chkelwexec,
			F.elwexecs,
			F.elwexece,
			F.chkvolume,
			F.volumes,
			F.volumee,
			F.chkrate,
			F.rates,
			F.ratee,
			F.chkpremium,
			F.premiums,
			F.premiume,
			F.chkparity,
			F.paritys,
			F.paritye,
			F.chkberate,
			F.berates,
			F.beratee,
			F.chkcapt,
			F.capts,
			F.capte,
			F.chkegearing,
			F.egearings,
			F.egearinge,
			F.chkgearing,
			F.gearings,
			F.gearinge,
			F.chkdelta,
			F.deltas,
			F.deltae,
			F.chktheta,
			F.thetas,
			F.thetae,
			F.chkduedate,
			F.duedates,
			F.duedatee,
			F.chkkoba,
			F.cbkoba,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["chkitem"] = new XAQueryFieldInfo("char", chkitem, chkitem.ToString(), "기초자산chk구분", (decimal)1);
			dict["cbitem"] = new XAQueryFieldInfo("char", cbitem, cbitem, "기초자산코드", (decimal)12);
			dict["chkissuer"] = new XAQueryFieldInfo("char", chkissuer, chkissuer.ToString(), "발행사chk구분", (decimal)1);
			dict["cbissuer"] = new XAQueryFieldInfo("char", cbissuer, cbissuer, "발행사", (decimal)12);
			dict["chkcallput"] = new XAQueryFieldInfo("char", chkcallput, chkcallput.ToString(), "권리chk구분", (decimal)1);
			dict["cbcallput"] = new XAQueryFieldInfo("char", cbcallput, cbcallput, "권리(call:01.put:02)", (decimal)2);
			dict["chkexec"] = new XAQueryFieldInfo("char", chkexec, chkexec.ToString(), "행사가chk구분", (decimal)1);
			dict["cbexec"] = new XAQueryFieldInfo("char", cbexec, cbexec.ToString(), "행사가(>=:1.<=:2)", (decimal)1);
			dict["chktype"] = new XAQueryFieldInfo("char", chktype, chktype.ToString(), "행사방식chk구분", (decimal)1);
			dict["cbtype"] = new XAQueryFieldInfo("char", cbtype, cbtype, "행사방식", (decimal)2);
			dict["chksettle"] = new XAQueryFieldInfo("char", chksettle, chksettle.ToString(), "결제방법chk구분", (decimal)1);
			dict["cbsettle"] = new XAQueryFieldInfo("char", cbsettle, cbsettle, "결제방법", (decimal)2);
			dict["chklast"] = new XAQueryFieldInfo("char", chklast, chklast.ToString(), "만기chk구분", (decimal)1);
			dict["cblast"] = new XAQueryFieldInfo("char", cblast, cblast, "만기월별", (decimal)6);
			dict["chkelwexec"] = new XAQueryFieldInfo("char", chkelwexec, chkelwexec.ToString(), "행사가격chk구분", (decimal)1);
			dict["elwexecs"] = new XAQueryFieldInfo("float", elwexecs, elwexecs.ToString("0000000000.00"), "행사가이상", (decimal)10.2);
			dict["elwexece"] = new XAQueryFieldInfo("float", elwexece, elwexece.ToString("0000000000.00"), "행사가이하", (decimal)10.2);
			dict["chkvolume"] = new XAQueryFieldInfo("char", chkvolume, chkvolume.ToString(), "거래량chk구분", (decimal)1);
			dict["volumes"] = new XAQueryFieldInfo("float", volumes, volumes.ToString("000000000000"), "거래량이상", (decimal)12);
			dict["volumee"] = new XAQueryFieldInfo("float", volumee, volumee.ToString("000000000000"), "거래량이하", (decimal)12);
			dict["chkrate"] = new XAQueryFieldInfo("char", chkrate, chkrate.ToString(), "등락율chk구분", (decimal)1);
			dict["rates"] = new XAQueryFieldInfo("float", rates, rates.ToString("000000.00"), "등락율이상", (decimal)6.2);
			dict["ratee"] = new XAQueryFieldInfo("float", ratee, ratee.ToString("000000.00"), "등락율이하", (decimal)6.2);
			dict["chkpremium"] = new XAQueryFieldInfo("char", chkpremium, chkpremium.ToString(), "프리미엄chk구분", (decimal)1);
			dict["premiums"] = new XAQueryFieldInfo("float", premiums, premiums.ToString("000000.00"), "프리미엄이상", (decimal)6.2);
			dict["premiume"] = new XAQueryFieldInfo("float", premiume, premiume.ToString("000000.00"), "프리미엄이하", (decimal)6.2);
			dict["chkparity"] = new XAQueryFieldInfo("char", chkparity, chkparity.ToString(), "패리티chk구분", (decimal)1);
			dict["paritys"] = new XAQueryFieldInfo("float", paritys, paritys.ToString("000000.00"), "패리티이상", (decimal)6.2);
			dict["paritye"] = new XAQueryFieldInfo("float", paritye, paritye.ToString("000000.00"), "패리티이하", (decimal)6.2);
			dict["chkberate"] = new XAQueryFieldInfo("char", chkberate, chkberate.ToString(), "손익분기chk구분", (decimal)1);
			dict["berates"] = new XAQueryFieldInfo("float", berates, berates.ToString("000000.00"), "손익분기이상", (decimal)6.2);
			dict["beratee"] = new XAQueryFieldInfo("float", beratee, beratee.ToString("000000.00"), "손익분기이하", (decimal)6.2);
			dict["chkcapt"] = new XAQueryFieldInfo("char", chkcapt, chkcapt.ToString(), "자본지지chk구분", (decimal)1);
			dict["capts"] = new XAQueryFieldInfo("float", capts, capts.ToString("000000.00"), "자본지지이상", (decimal)6.2);
			dict["capte"] = new XAQueryFieldInfo("float", capte, capte.ToString("000000.00"), "자본지지이하", (decimal)6.2);
			dict["chkegearing"] = new XAQueryFieldInfo("char", chkegearing, chkegearing.ToString(), "e.기어링chk구분", (decimal)1);
			dict["egearings"] = new XAQueryFieldInfo("float", egearings, egearings.ToString("000000.00"), "e.기어링이상", (decimal)6.2);
			dict["egearinge"] = new XAQueryFieldInfo("float", egearinge, egearinge.ToString("000000.00"), "e.기어링이하", (decimal)6.2);
			dict["chkgearing"] = new XAQueryFieldInfo("char", chkgearing, chkgearing.ToString(), "기어링chk구분", (decimal)1);
			dict["gearings"] = new XAQueryFieldInfo("float", gearings, gearings.ToString("000000.00"), "기어링이상", (decimal)6.2);
			dict["gearinge"] = new XAQueryFieldInfo("float", gearinge, gearinge.ToString("000000.00"), "기어링이하", (decimal)6.2);
			dict["chkdelta"] = new XAQueryFieldInfo("char", chkdelta, chkdelta.ToString(), "델타chk구분", (decimal)1);
			dict["deltas"] = new XAQueryFieldInfo("float", deltas, deltas.ToString("0000000000.000000"), "델타이상", (decimal)10.6);
			dict["deltae"] = new XAQueryFieldInfo("float", deltae, deltae.ToString("0000000000.000000"), "델타이하", (decimal)10.6);
			dict["chktheta"] = new XAQueryFieldInfo("char", chktheta, chktheta.ToString(), "쎄타chk구분", (decimal)1);
			dict["thetas"] = new XAQueryFieldInfo("float", thetas, thetas.ToString("0000000000.000000"), "쎄타이상", (decimal)10.6);
			dict["thetae"] = new XAQueryFieldInfo("float", thetae, thetae.ToString("0000000000.000000"), "쎄타이하", (decimal)10.6);
			dict["chkduedate"] = new XAQueryFieldInfo("char", chkduedate, chkduedate.ToString(), "최종거래일chk구분", (decimal)1);
			dict["duedates"] = new XAQueryFieldInfo("char", duedates, duedates, "최종거래일이상", (decimal)8);
			dict["duedatee"] = new XAQueryFieldInfo("char", duedatee, duedatee, "최종거래일이하", (decimal)8);
			dict["chkkoba"] = new XAQueryFieldInfo("char", chkkoba, chkkoba.ToString(), "조기종료chk구분", (decimal)1);
			dict["cbkoba"] = new XAQueryFieldInfo("char", cbkoba, cbkoba.ToString(), "조기종료(0:전체1:조기종료만2:조기종료제외)", (decimal)1);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "chkitem":
					this.chkitem = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "cbitem":
					this.cbitem = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "chkissuer":
					this.chkissuer = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "cbissuer":
					this.cbissuer = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "chkcallput":
					this.chkcallput = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "cbcallput":
					this.cbcallput = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "chkexec":
					this.chkexec = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "cbexec":
					this.cbexec = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "chktype":
					this.chktype = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "cbtype":
					this.cbtype = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "chksettle":
					this.chksettle = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "cbsettle":
					this.cbsettle = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "chklast":
					this.chklast = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "cblast":
					this.cblast = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "chkelwexec":
					this.chkelwexec = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "elwexecs":
					this.elwexecs = fieldInfo.FieldValue.ParseFloat("elwexecs");
				break;

				case "elwexece":
					this.elwexece = fieldInfo.FieldValue.ParseFloat("elwexece");
				break;

				case "chkvolume":
					this.chkvolume = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "volumes":
					this.volumes = fieldInfo.FieldValue.ParseFloat("volumes");
				break;

				case "volumee":
					this.volumee = fieldInfo.FieldValue.ParseFloat("volumee");
				break;

				case "chkrate":
					this.chkrate = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "rates":
					this.rates = fieldInfo.FieldValue.ParseFloat("rates");
				break;

				case "ratee":
					this.ratee = fieldInfo.FieldValue.ParseFloat("ratee");
				break;

				case "chkpremium":
					this.chkpremium = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "premiums":
					this.premiums = fieldInfo.FieldValue.ParseFloat("premiums");
				break;

				case "premiume":
					this.premiume = fieldInfo.FieldValue.ParseFloat("premiume");
				break;

				case "chkparity":
					this.chkparity = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "paritys":
					this.paritys = fieldInfo.FieldValue.ParseFloat("paritys");
				break;

				case "paritye":
					this.paritye = fieldInfo.FieldValue.ParseFloat("paritye");
				break;

				case "chkberate":
					this.chkberate = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "berates":
					this.berates = fieldInfo.FieldValue.ParseFloat("berates");
				break;

				case "beratee":
					this.beratee = fieldInfo.FieldValue.ParseFloat("beratee");
				break;

				case "chkcapt":
					this.chkcapt = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "capts":
					this.capts = fieldInfo.FieldValue.ParseFloat("capts");
				break;

				case "capte":
					this.capte = fieldInfo.FieldValue.ParseFloat("capte");
				break;

				case "chkegearing":
					this.chkegearing = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "egearings":
					this.egearings = fieldInfo.FieldValue.ParseFloat("egearings");
				break;

				case "egearinge":
					this.egearinge = fieldInfo.FieldValue.ParseFloat("egearinge");
				break;

				case "chkgearing":
					this.chkgearing = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "gearings":
					this.gearings = fieldInfo.FieldValue.ParseFloat("gearings");
				break;

				case "gearinge":
					this.gearinge = fieldInfo.FieldValue.ParseFloat("gearinge");
				break;

				case "chkdelta":
					this.chkdelta = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "deltas":
					this.deltas = fieldInfo.FieldValue.ParseFloat("deltas");
				break;

				case "deltae":
					this.deltae = fieldInfo.FieldValue.ParseFloat("deltae");
				break;

				case "chktheta":
					this.chktheta = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "thetas":
					this.thetas = fieldInfo.FieldValue.ParseFloat("thetas");
				break;

				case "thetae":
					this.thetae = fieldInfo.FieldValue.ParseFloat("thetae");
				break;

				case "chkduedate":
					this.chkduedate = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "duedates":
					this.duedates = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "duedatee":
					this.duedatee = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "chkkoba":
					this.chkkoba = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "cbkoba":
					this.cbkoba = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public bool VerifyData()
		{
			// chkitem char 1
			if (cbitem?.Length > 12) return false; // char 12
			// chkissuer char 1
			if (cbissuer?.Length > 12) return false; // char 12
			// chkcallput char 1
			if (cbcallput?.Length > 2) return false; // char 2
			// chkexec char 1
			// cbexec char 1
			// chktype char 1
			if (cbtype?.Length > 2) return false; // char 2
			// chksettle char 1
			if (cbsettle?.Length > 2) return false; // char 2
			// chklast char 1
			if (cblast?.Length > 6) return false; // char 6
			// chkelwexec char 1
			// elwexecs float 10.2
			// elwexece float 10.2
			// chkvolume char 1
			// volumes float 12
			// volumee float 12
			// chkrate char 1
			// rates float 6.2
			// ratee float 6.2
			// chkpremium char 1
			// premiums float 6.2
			// premiume float 6.2
			// chkparity char 1
			// paritys float 6.2
			// paritye float 6.2
			// chkberate char 1
			// berates float 6.2
			// beratee float 6.2
			// chkcapt char 1
			// capts float 6.2
			// capte float 6.2
			// chkegearing char 1
			// egearings float 6.2
			// egearinge float 6.2
			// chkgearing char 1
			// gearings float 6.2
			// gearinge float 6.2
			// chkdelta char 1
			// deltas float 10.6
			// deltae float 10.6
			// chktheta char 1
			// thetas float 10.6
			// thetae float 10.6
			// chkduedate char 1
			if (duedates?.Length > 8) return false; // char 8
			if (duedatee?.Length > 8) return false; // char 8
			// chkkoba char 1
			// cbkoba char 1

			return true;
		}
	}

	public partial class XQt1955OutBlock : XingBlock
	{
		/// <summary>
		/// t1955OutBlock
		/// </summary>
		public const string _blockName = "t1955OutBlock";
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
		/// t1955OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1955OutBlock
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
		/// 종목갯수
		/// </summary>
		[XAQueryFieldAttribute("cnt", "종목갯수", "long", "4")]
		public long cnt;

		public static class F
		{
			/// <summary>
			/// 종목갯수
			/// </summary>
			public const string cnt = "cnt";
		}

		public static string[] AllFields = new string[]
		{
			F.cnt,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["cnt"] = new XAQueryFieldInfo("long", cnt, cnt.ToString("d4"), "종목갯수", (decimal)4);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "cnt":
					this.cnt = fieldInfo.FieldValue.ParseLong("cnt");
				break;


			}
		}

		public static XQt1955OutBlock FromQuery(XQt1955 query)
		{
			XQt1955OutBlock block = new XQt1955OutBlock();
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

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (cnt.ToString().Length > 4) return false; // long 4

			return true;
		}
	}

	public partial class XQt1955OutBlock1 : XingBlock
	{
		/// <summary>
		/// t1955OutBlock1
		/// </summary>
		public const string _blockName = "t1955OutBlock1";
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
		/// t1955OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1955OutBlock1
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
		/// 종목명
		/// </summary>
		[XAQueryFieldAttribute("hname", "종목명", "char", "40")]
		public string hname;
		/// <summary>
		/// 종목코드
		/// </summary>
		[XAQueryFieldAttribute("shcode", "종목코드", "char", "6")]
		public string shcode;
		/// <summary>
		/// 발행사
		/// </summary>
		[XAQueryFieldAttribute("issuernmk", "발행사", "char", "40")]
		public string issuernmk;
		/// <summary>
		/// 기초자산코드
		/// </summary>
		[XAQueryFieldAttribute("itemcode", "기초자산코드", "char", "12")]
		public string itemcode;
		/// <summary>
		/// 콜/풋구분
		/// </summary>
		[XAQueryFieldAttribute("cpgubun", "콜/풋구분", "char", "2")]
		public string cpgubun;
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
		[XAQueryFieldAttribute("volume", "거래량", "float", "12")]
		public float volume;
		/// <summary>
		/// 전일거래량
		/// </summary>
		[XAQueryFieldAttribute("jnilvolume", "전일거래량", "float", "12")]
		public float jnilvolume;
		/// <summary>
		/// 행사가
		/// </summary>
		[XAQueryFieldAttribute("elwexec", "행사가", "float", "10.2")]
		public float elwexec;
		/// <summary>
		/// 기초자산명
		/// </summary>
		[XAQueryFieldAttribute("item", "기초자산명", "char", "20")]
		public string item;
		/// <summary>
		/// 기초자산가
		/// </summary>
		[XAQueryFieldAttribute("bprice", "기초자산가", "float", "10.2")]
		public float bprice;
		/// <summary>
		/// 기초전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("bsign", "기초전일대비구분", "char", "1")]
		public char bsign;
		/// <summary>
		/// 기초전일대비
		/// </summary>
		[XAQueryFieldAttribute("bchange", "기초전일대비", "float", "10.2")]
		public float bchange;
		/// <summary>
		/// 기초등락율
		/// </summary>
		[XAQueryFieldAttribute("bdiff", "기초등락율", "float", "6.2")]
		public float bdiff;
		/// <summary>
		/// 프리미엄
		/// </summary>
		[XAQueryFieldAttribute("premium", "프리미엄", "float", "6.2")]
		public float premium;
		/// <summary>
		/// 패리티
		/// </summary>
		[XAQueryFieldAttribute("parity", "패리티", "float", "6.2")]
		public float parity;
		/// <summary>
		/// 손익분기
		/// </summary>
		[XAQueryFieldAttribute("berate", "손익분기", "float", "6.2")]
		public float berate;
		/// <summary>
		/// 자본지지
		/// </summary>
		[XAQueryFieldAttribute("capt", "자본지지", "float", "6.2")]
		public float capt;
		/// <summary>
		/// e.기어링
		/// </summary>
		[XAQueryFieldAttribute("egearing", "e.기어링", "float", "6.2")]
		public float egearing;
		/// <summary>
		/// 기어링
		/// </summary>
		[XAQueryFieldAttribute("gearing", "기어링", "float", "6.2")]
		public float gearing;
		/// <summary>
		/// 최종거래일
		/// </summary>
		[XAQueryFieldAttribute("lastdate", "최종거래일", "char", "8")]
		public string lastdate;
		/// <summary>
		/// 델타
		/// </summary>
		[XAQueryFieldAttribute("delta", "델타", "float", "10.6")]
		public float delta;
		/// <summary>
		/// 쎄타
		/// </summary>
		[XAQueryFieldAttribute("theta", "쎄타", "float", "10.6")]
		public float theta;

		public static class F
		{
			/// <summary>
			/// 종목명
			/// </summary>
			public const string hname = "hname";
			/// <summary>
			/// 종목코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 발행사
			/// </summary>
			public const string issuernmk = "issuernmk";
			/// <summary>
			/// 기초자산코드
			/// </summary>
			public const string itemcode = "itemcode";
			/// <summary>
			/// 콜/풋구분
			/// </summary>
			public const string cpgubun = "cpgubun";
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
			/// 전일거래량
			/// </summary>
			public const string jnilvolume = "jnilvolume";
			/// <summary>
			/// 행사가
			/// </summary>
			public const string elwexec = "elwexec";
			/// <summary>
			/// 기초자산명
			/// </summary>
			public const string item = "item";
			/// <summary>
			/// 기초자산가
			/// </summary>
			public const string bprice = "bprice";
			/// <summary>
			/// 기초전일대비구분
			/// </summary>
			public const string bsign = "bsign";
			/// <summary>
			/// 기초전일대비
			/// </summary>
			public const string bchange = "bchange";
			/// <summary>
			/// 기초등락율
			/// </summary>
			public const string bdiff = "bdiff";
			/// <summary>
			/// 프리미엄
			/// </summary>
			public const string premium = "premium";
			/// <summary>
			/// 패리티
			/// </summary>
			public const string parity = "parity";
			/// <summary>
			/// 손익분기
			/// </summary>
			public const string berate = "berate";
			/// <summary>
			/// 자본지지
			/// </summary>
			public const string capt = "capt";
			/// <summary>
			/// e.기어링
			/// </summary>
			public const string egearing = "egearing";
			/// <summary>
			/// 기어링
			/// </summary>
			public const string gearing = "gearing";
			/// <summary>
			/// 최종거래일
			/// </summary>
			public const string lastdate = "lastdate";
			/// <summary>
			/// 델타
			/// </summary>
			public const string delta = "delta";
			/// <summary>
			/// 쎄타
			/// </summary>
			public const string theta = "theta";
		}

		public static string[] AllFields = new string[]
		{
			F.hname,
			F.shcode,
			F.issuernmk,
			F.itemcode,
			F.cpgubun,
			F.price,
			F.sign,
			F.change,
			F.diff,
			F.volume,
			F.jnilvolume,
			F.elwexec,
			F.item,
			F.bprice,
			F.bsign,
			F.bchange,
			F.bdiff,
			F.premium,
			F.parity,
			F.berate,
			F.capt,
			F.egearing,
			F.gearing,
			F.lastdate,
			F.delta,
			F.theta,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["hname"] = new XAQueryFieldInfo("char", hname, hname, "종목명", (decimal)40);
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "종목코드", (decimal)6);
			dict["issuernmk"] = new XAQueryFieldInfo("char", issuernmk, issuernmk, "발행사", (decimal)40);
			dict["itemcode"] = new XAQueryFieldInfo("char", itemcode, itemcode, "기초자산코드", (decimal)12);
			dict["cpgubun"] = new XAQueryFieldInfo("char", cpgubun, cpgubun, "콜/풋구분", (decimal)2);
			dict["price"] = new XAQueryFieldInfo("long", price, price.ToString("d8"), "현재가", (decimal)8);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("long", change, change.ToString("d8"), "전일대비", (decimal)8);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["volume"] = new XAQueryFieldInfo("float", volume, volume.ToString("000000000000"), "거래량", (decimal)12);
			dict["jnilvolume"] = new XAQueryFieldInfo("float", jnilvolume, jnilvolume.ToString("000000000000"), "전일거래량", (decimal)12);
			dict["elwexec"] = new XAQueryFieldInfo("float", elwexec, elwexec.ToString("0000000000.00"), "행사가", (decimal)10.2);
			dict["item"] = new XAQueryFieldInfo("char", item, item, "기초자산명", (decimal)20);
			dict["bprice"] = new XAQueryFieldInfo("float", bprice, bprice.ToString("0000000000.00"), "기초자산가", (decimal)10.2);
			dict["bsign"] = new XAQueryFieldInfo("char", bsign, bsign.ToString(), "기초전일대비구분", (decimal)1);
			dict["bchange"] = new XAQueryFieldInfo("float", bchange, bchange.ToString("0000000000.00"), "기초전일대비", (decimal)10.2);
			dict["bdiff"] = new XAQueryFieldInfo("float", bdiff, bdiff.ToString("000000.00"), "기초등락율", (decimal)6.2);
			dict["premium"] = new XAQueryFieldInfo("float", premium, premium.ToString("000000.00"), "프리미엄", (decimal)6.2);
			dict["parity"] = new XAQueryFieldInfo("float", parity, parity.ToString("000000.00"), "패리티", (decimal)6.2);
			dict["berate"] = new XAQueryFieldInfo("float", berate, berate.ToString("000000.00"), "손익분기", (decimal)6.2);
			dict["capt"] = new XAQueryFieldInfo("float", capt, capt.ToString("000000.00"), "자본지지", (decimal)6.2);
			dict["egearing"] = new XAQueryFieldInfo("float", egearing, egearing.ToString("000000.00"), "e.기어링", (decimal)6.2);
			dict["gearing"] = new XAQueryFieldInfo("float", gearing, gearing.ToString("000000.00"), "기어링", (decimal)6.2);
			dict["lastdate"] = new XAQueryFieldInfo("char", lastdate, lastdate, "최종거래일", (decimal)8);
			dict["delta"] = new XAQueryFieldInfo("float", delta, delta.ToString("0000000000.000000"), "델타", (decimal)10.6);
			dict["theta"] = new XAQueryFieldInfo("float", theta, theta.ToString("0000000000.000000"), "쎄타", (decimal)10.6);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "hname":
					this.hname = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "issuernmk":
					this.issuernmk = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "itemcode":
					this.itemcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cpgubun":
					this.cpgubun = fieldInfo.FieldValue.TrimEnd('?');
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
					this.volume = fieldInfo.FieldValue.ParseFloat("volume");
				break;

				case "jnilvolume":
					this.jnilvolume = fieldInfo.FieldValue.ParseFloat("jnilvolume");
				break;

				case "elwexec":
					this.elwexec = fieldInfo.FieldValue.ParseFloat("elwexec");
				break;

				case "item":
					this.item = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "bprice":
					this.bprice = fieldInfo.FieldValue.ParseFloat("bprice");
				break;

				case "bsign":
					this.bsign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "bchange":
					this.bchange = fieldInfo.FieldValue.ParseFloat("bchange");
				break;

				case "bdiff":
					this.bdiff = fieldInfo.FieldValue.ParseFloat("bdiff");
				break;

				case "premium":
					this.premium = fieldInfo.FieldValue.ParseFloat("premium");
				break;

				case "parity":
					this.parity = fieldInfo.FieldValue.ParseFloat("parity");
				break;

				case "berate":
					this.berate = fieldInfo.FieldValue.ParseFloat("berate");
				break;

				case "capt":
					this.capt = fieldInfo.FieldValue.ParseFloat("capt");
				break;

				case "egearing":
					this.egearing = fieldInfo.FieldValue.ParseFloat("egearing");
				break;

				case "gearing":
					this.gearing = fieldInfo.FieldValue.ParseFloat("gearing");
				break;

				case "lastdate":
					this.lastdate = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "delta":
					this.delta = fieldInfo.FieldValue.ParseFloat("delta");
				break;

				case "theta":
					this.theta = fieldInfo.FieldValue.ParseFloat("theta");
				break;


			}
		}

		public static XQt1955OutBlock1[] ListFromQuery(XQt1955 query)
		{
			int count = query.GetBlockCount(XQt1955OutBlock1.BlockName);
			List<XQt1955OutBlock1> list = new List<XQt1955OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1955OutBlock1 block = new XQt1955OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.hname = query.GetFieldData(block.GetBlockName(), "hname", i).TrimEnd('?'); // char 40
					block.shcode = query.GetFieldData(block.GetBlockName(), "shcode", i).TrimEnd('?'); // char 6
					block.issuernmk = query.GetFieldData(block.GetBlockName(), "issuernmk", i).TrimEnd('?'); // char 40
					block.itemcode = query.GetFieldData(block.GetBlockName(), "itemcode", i).TrimEnd('?'); // char 12
					block.cpgubun = query.GetFieldData(block.GetBlockName(), "cpgubun", i).TrimEnd('?'); // char 2
					block.price = query.GetFieldData(block.GetBlockName(), "price", i).ParseLong("price"); // long 8
					block.sign = query.GetFieldData(block.GetBlockName(), "sign", i).FirstOrDefault(); // char 1
					block.change = query.GetFieldData(block.GetBlockName(), "change", i).ParseLong("change"); // long 8
					block.diff = query.GetFieldData(block.GetBlockName(), "diff", i).ParseFloat("diff"); // float 6.2
					block.volume = query.GetFieldData(block.GetBlockName(), "volume", i).ParseFloat("volume"); // float 12
					block.jnilvolume = query.GetFieldData(block.GetBlockName(), "jnilvolume", i).ParseFloat("jnilvolume"); // float 12
					block.elwexec = query.GetFieldData(block.GetBlockName(), "elwexec", i).ParseFloat("elwexec"); // float 10.2
					block.item = query.GetFieldData(block.GetBlockName(), "item", i).TrimEnd('?'); // char 20
					block.bprice = query.GetFieldData(block.GetBlockName(), "bprice", i).ParseFloat("bprice"); // float 10.2
					block.bsign = query.GetFieldData(block.GetBlockName(), "bsign", i).FirstOrDefault(); // char 1
					block.bchange = query.GetFieldData(block.GetBlockName(), "bchange", i).ParseFloat("bchange"); // float 10.2
					block.bdiff = query.GetFieldData(block.GetBlockName(), "bdiff", i).ParseFloat("bdiff"); // float 6.2
					block.premium = query.GetFieldData(block.GetBlockName(), "premium", i).ParseFloat("premium"); // float 6.2
					block.parity = query.GetFieldData(block.GetBlockName(), "parity", i).ParseFloat("parity"); // float 6.2
					block.berate = query.GetFieldData(block.GetBlockName(), "berate", i).ParseFloat("berate"); // float 6.2
					block.capt = query.GetFieldData(block.GetBlockName(), "capt", i).ParseFloat("capt"); // float 6.2
					block.egearing = query.GetFieldData(block.GetBlockName(), "egearing", i).ParseFloat("egearing"); // float 6.2
					block.gearing = query.GetFieldData(block.GetBlockName(), "gearing", i).ParseFloat("gearing"); // float 6.2
					block.lastdate = query.GetFieldData(block.GetBlockName(), "lastdate", i).TrimEnd('?'); // char 8
					block.delta = query.GetFieldData(block.GetBlockName(), "delta", i).ParseFloat("delta"); // float 10.6
					block.theta = query.GetFieldData(block.GetBlockName(), "theta", i).ParseFloat("theta"); // float 10.6

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
			if (hname?.Length > 40) return false; // char 40
			if (shcode?.Length > 6) return false; // char 6
			if (issuernmk?.Length > 40) return false; // char 40
			if (itemcode?.Length > 12) return false; // char 12
			if (cpgubun?.Length > 2) return false; // char 2
			if (price.ToString().Length > 8) return false; // long 8
			// sign char 1
			if (change.ToString().Length > 8) return false; // long 8
			// diff float 6.2
			// volume float 12
			// jnilvolume float 12
			// elwexec float 10.2
			if (item?.Length > 20) return false; // char 20
			// bprice float 10.2
			// bsign char 1
			// bchange float 10.2
			// bdiff float 6.2
			// premium float 6.2
			// parity float 6.2
			// berate float 6.2
			// capt float 6.2
			// egearing float 6.2
			// gearing float 6.2
			if (lastdate?.Length > 8) return false; // char 8
			// delta float 10.6
			// theta float 10.6

			return true;
		}
	}

	/// <summary>
	/// ELW지표검색(t1955)
	/// </summary>
	public partial class XQt1955 : XingQuery
	{
		/// <summary>
		/// t1955
		/// </summary>
		public const string _typeName = "t1955";
		/// <summary>
		/// ELW지표검색(t1955)
		/// </summary>
		public const string _typeDesc = "ELW지표검색(t1955)";
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
		/// t1955
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// ELW지표검색(t1955)
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
		/// ELW지표검색(t1955)
		/// </summary>
		public XQt1955() : base("t1955") { }


		public class XQAllOutBlocks
		{
			public XQt1955OutBlock OutBlock { get; internal set; }
			public XQt1955OutBlock1[] OutBlock1 { get; internal set; }
		}

		public static XQAllOutBlocks Get(char chkitem = default,string cbitem = default,char chkissuer = default,string cbissuer = default,char chkcallput = default,string cbcallput = default,char chkexec = default,char cbexec = default,char chktype = default,string cbtype = default,char chksettle = default,string cbsettle = default,char chklast = default,string cblast = default,char chkelwexec = default,float elwexecs = default,float elwexece = default,char chkvolume = default,float volumes = default,float volumee = default,char chkrate = default,float rates = default,float ratee = default,char chkpremium = default,float premiums = default,float premiume = default,char chkparity = default,float paritys = default,float paritye = default,char chkberate = default,float berates = default,float beratee = default,char chkcapt = default,float capts = default,float capte = default,char chkegearing = default,float egearings = default,float egearinge = default,char chkgearing = default,float gearings = default,float gearinge = default,char chkdelta = default,float deltas = default,float deltae = default,char chktheta = default,float thetas = default,float thetae = default,char chkduedate = default,string duedates = default,string duedatee = default,char chkkoba = default,char cbkoba = default)
		{
			using (XQt1955 instance = new XQt1955())
			{
				instance.SetFieldData(XQt1955InBlock.BlockName, XQt1955InBlock.F.chkitem, 0, chkitem.ToString()); // char 1
				instance.SetFieldData(XQt1955InBlock.BlockName, XQt1955InBlock.F.cbitem, 0, cbitem); // char 12
				instance.SetFieldData(XQt1955InBlock.BlockName, XQt1955InBlock.F.chkissuer, 0, chkissuer.ToString()); // char 1
				instance.SetFieldData(XQt1955InBlock.BlockName, XQt1955InBlock.F.cbissuer, 0, cbissuer); // char 12
				instance.SetFieldData(XQt1955InBlock.BlockName, XQt1955InBlock.F.chkcallput, 0, chkcallput.ToString()); // char 1
				instance.SetFieldData(XQt1955InBlock.BlockName, XQt1955InBlock.F.cbcallput, 0, cbcallput); // char 2
				instance.SetFieldData(XQt1955InBlock.BlockName, XQt1955InBlock.F.chkexec, 0, chkexec.ToString()); // char 1
				instance.SetFieldData(XQt1955InBlock.BlockName, XQt1955InBlock.F.cbexec, 0, cbexec.ToString()); // char 1
				instance.SetFieldData(XQt1955InBlock.BlockName, XQt1955InBlock.F.chktype, 0, chktype.ToString()); // char 1
				instance.SetFieldData(XQt1955InBlock.BlockName, XQt1955InBlock.F.cbtype, 0, cbtype); // char 2
				instance.SetFieldData(XQt1955InBlock.BlockName, XQt1955InBlock.F.chksettle, 0, chksettle.ToString()); // char 1
				instance.SetFieldData(XQt1955InBlock.BlockName, XQt1955InBlock.F.cbsettle, 0, cbsettle); // char 2
				instance.SetFieldData(XQt1955InBlock.BlockName, XQt1955InBlock.F.chklast, 0, chklast.ToString()); // char 1
				instance.SetFieldData(XQt1955InBlock.BlockName, XQt1955InBlock.F.cblast, 0, cblast); // char 6
				instance.SetFieldData(XQt1955InBlock.BlockName, XQt1955InBlock.F.chkelwexec, 0, chkelwexec.ToString()); // char 1
				instance.SetFieldData(XQt1955InBlock.BlockName, XQt1955InBlock.F.elwexecs, 0, elwexecs.ToString("0000000000.00")); // float 10.2
				instance.SetFieldData(XQt1955InBlock.BlockName, XQt1955InBlock.F.elwexece, 0, elwexece.ToString("0000000000.00")); // float 10.2
				instance.SetFieldData(XQt1955InBlock.BlockName, XQt1955InBlock.F.chkvolume, 0, chkvolume.ToString()); // char 1
				instance.SetFieldData(XQt1955InBlock.BlockName, XQt1955InBlock.F.volumes, 0, volumes.ToString("000000000000")); // float 12
				instance.SetFieldData(XQt1955InBlock.BlockName, XQt1955InBlock.F.volumee, 0, volumee.ToString("000000000000")); // float 12
				instance.SetFieldData(XQt1955InBlock.BlockName, XQt1955InBlock.F.chkrate, 0, chkrate.ToString()); // char 1
				instance.SetFieldData(XQt1955InBlock.BlockName, XQt1955InBlock.F.rates, 0, rates.ToString("000000.00")); // float 6.2
				instance.SetFieldData(XQt1955InBlock.BlockName, XQt1955InBlock.F.ratee, 0, ratee.ToString("000000.00")); // float 6.2
				instance.SetFieldData(XQt1955InBlock.BlockName, XQt1955InBlock.F.chkpremium, 0, chkpremium.ToString()); // char 1
				instance.SetFieldData(XQt1955InBlock.BlockName, XQt1955InBlock.F.premiums, 0, premiums.ToString("000000.00")); // float 6.2
				instance.SetFieldData(XQt1955InBlock.BlockName, XQt1955InBlock.F.premiume, 0, premiume.ToString("000000.00")); // float 6.2
				instance.SetFieldData(XQt1955InBlock.BlockName, XQt1955InBlock.F.chkparity, 0, chkparity.ToString()); // char 1
				instance.SetFieldData(XQt1955InBlock.BlockName, XQt1955InBlock.F.paritys, 0, paritys.ToString("000000.00")); // float 6.2
				instance.SetFieldData(XQt1955InBlock.BlockName, XQt1955InBlock.F.paritye, 0, paritye.ToString("000000.00")); // float 6.2
				instance.SetFieldData(XQt1955InBlock.BlockName, XQt1955InBlock.F.chkberate, 0, chkberate.ToString()); // char 1
				instance.SetFieldData(XQt1955InBlock.BlockName, XQt1955InBlock.F.berates, 0, berates.ToString("000000.00")); // float 6.2
				instance.SetFieldData(XQt1955InBlock.BlockName, XQt1955InBlock.F.beratee, 0, beratee.ToString("000000.00")); // float 6.2
				instance.SetFieldData(XQt1955InBlock.BlockName, XQt1955InBlock.F.chkcapt, 0, chkcapt.ToString()); // char 1
				instance.SetFieldData(XQt1955InBlock.BlockName, XQt1955InBlock.F.capts, 0, capts.ToString("000000.00")); // float 6.2
				instance.SetFieldData(XQt1955InBlock.BlockName, XQt1955InBlock.F.capte, 0, capte.ToString("000000.00")); // float 6.2
				instance.SetFieldData(XQt1955InBlock.BlockName, XQt1955InBlock.F.chkegearing, 0, chkegearing.ToString()); // char 1
				instance.SetFieldData(XQt1955InBlock.BlockName, XQt1955InBlock.F.egearings, 0, egearings.ToString("000000.00")); // float 6.2
				instance.SetFieldData(XQt1955InBlock.BlockName, XQt1955InBlock.F.egearinge, 0, egearinge.ToString("000000.00")); // float 6.2
				instance.SetFieldData(XQt1955InBlock.BlockName, XQt1955InBlock.F.chkgearing, 0, chkgearing.ToString()); // char 1
				instance.SetFieldData(XQt1955InBlock.BlockName, XQt1955InBlock.F.gearings, 0, gearings.ToString("000000.00")); // float 6.2
				instance.SetFieldData(XQt1955InBlock.BlockName, XQt1955InBlock.F.gearinge, 0, gearinge.ToString("000000.00")); // float 6.2
				instance.SetFieldData(XQt1955InBlock.BlockName, XQt1955InBlock.F.chkdelta, 0, chkdelta.ToString()); // char 1
				instance.SetFieldData(XQt1955InBlock.BlockName, XQt1955InBlock.F.deltas, 0, deltas.ToString("0000000000.000000")); // float 10.6
				instance.SetFieldData(XQt1955InBlock.BlockName, XQt1955InBlock.F.deltae, 0, deltae.ToString("0000000000.000000")); // float 10.6
				instance.SetFieldData(XQt1955InBlock.BlockName, XQt1955InBlock.F.chktheta, 0, chktheta.ToString()); // char 1
				instance.SetFieldData(XQt1955InBlock.BlockName, XQt1955InBlock.F.thetas, 0, thetas.ToString("0000000000.000000")); // float 10.6
				instance.SetFieldData(XQt1955InBlock.BlockName, XQt1955InBlock.F.thetae, 0, thetae.ToString("0000000000.000000")); // float 10.6
				instance.SetFieldData(XQt1955InBlock.BlockName, XQt1955InBlock.F.chkduedate, 0, chkduedate.ToString()); // char 1
				instance.SetFieldData(XQt1955InBlock.BlockName, XQt1955InBlock.F.duedates, 0, duedates); // char 8
				instance.SetFieldData(XQt1955InBlock.BlockName, XQt1955InBlock.F.duedatee, 0, duedatee); // char 8
				instance.SetFieldData(XQt1955InBlock.BlockName, XQt1955InBlock.F.chkkoba, 0, chkkoba.ToString()); // char 1
				instance.SetFieldData(XQt1955InBlock.BlockName, XQt1955InBlock.F.cbkoba, 0, cbkoba.ToString()); // char 1

				if (instance.Request() < 0)
				{
					return null;
				}

				XQAllOutBlocks results = new XQAllOutBlocks();
				results.OutBlock = instance.GetBlock();
				if (results.OutBlock.IsValidData == false)
				{
					return null;
				}

				results.OutBlock1 = instance.GetBlock1s();
				return results;
			}
		}

		public bool SetBlock(XQt1955InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "chkitem", 0, block.chkitem.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "cbitem", 0, block.cbitem); // char 12
			_xaQuery.SetFieldData(block.GetBlockName(), "chkissuer", 0, block.chkissuer.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "cbissuer", 0, block.cbissuer); // char 12
			_xaQuery.SetFieldData(block.GetBlockName(), "chkcallput", 0, block.chkcallput.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "cbcallput", 0, block.cbcallput); // char 2
			_xaQuery.SetFieldData(block.GetBlockName(), "chkexec", 0, block.chkexec.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "cbexec", 0, block.cbexec.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "chktype", 0, block.chktype.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "cbtype", 0, block.cbtype); // char 2
			_xaQuery.SetFieldData(block.GetBlockName(), "chksettle", 0, block.chksettle.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "cbsettle", 0, block.cbsettle); // char 2
			_xaQuery.SetFieldData(block.GetBlockName(), "chklast", 0, block.chklast.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "cblast", 0, block.cblast); // char 6
			_xaQuery.SetFieldData(block.GetBlockName(), "chkelwexec", 0, block.chkelwexec.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "elwexecs", 0, block.elwexecs.ToString("0000000000.00")); // float 10.2
			_xaQuery.SetFieldData(block.GetBlockName(), "elwexece", 0, block.elwexece.ToString("0000000000.00")); // float 10.2
			_xaQuery.SetFieldData(block.GetBlockName(), "chkvolume", 0, block.chkvolume.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "volumes", 0, block.volumes.ToString("000000000000")); // float 12
			_xaQuery.SetFieldData(block.GetBlockName(), "volumee", 0, block.volumee.ToString("000000000000")); // float 12
			_xaQuery.SetFieldData(block.GetBlockName(), "chkrate", 0, block.chkrate.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "rates", 0, block.rates.ToString("000000.00")); // float 6.2
			_xaQuery.SetFieldData(block.GetBlockName(), "ratee", 0, block.ratee.ToString("000000.00")); // float 6.2
			_xaQuery.SetFieldData(block.GetBlockName(), "chkpremium", 0, block.chkpremium.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "premiums", 0, block.premiums.ToString("000000.00")); // float 6.2
			_xaQuery.SetFieldData(block.GetBlockName(), "premiume", 0, block.premiume.ToString("000000.00")); // float 6.2
			_xaQuery.SetFieldData(block.GetBlockName(), "chkparity", 0, block.chkparity.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "paritys", 0, block.paritys.ToString("000000.00")); // float 6.2
			_xaQuery.SetFieldData(block.GetBlockName(), "paritye", 0, block.paritye.ToString("000000.00")); // float 6.2
			_xaQuery.SetFieldData(block.GetBlockName(), "chkberate", 0, block.chkberate.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "berates", 0, block.berates.ToString("000000.00")); // float 6.2
			_xaQuery.SetFieldData(block.GetBlockName(), "beratee", 0, block.beratee.ToString("000000.00")); // float 6.2
			_xaQuery.SetFieldData(block.GetBlockName(), "chkcapt", 0, block.chkcapt.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "capts", 0, block.capts.ToString("000000.00")); // float 6.2
			_xaQuery.SetFieldData(block.GetBlockName(), "capte", 0, block.capte.ToString("000000.00")); // float 6.2
			_xaQuery.SetFieldData(block.GetBlockName(), "chkegearing", 0, block.chkegearing.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "egearings", 0, block.egearings.ToString("000000.00")); // float 6.2
			_xaQuery.SetFieldData(block.GetBlockName(), "egearinge", 0, block.egearinge.ToString("000000.00")); // float 6.2
			_xaQuery.SetFieldData(block.GetBlockName(), "chkgearing", 0, block.chkgearing.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "gearings", 0, block.gearings.ToString("000000.00")); // float 6.2
			_xaQuery.SetFieldData(block.GetBlockName(), "gearinge", 0, block.gearinge.ToString("000000.00")); // float 6.2
			_xaQuery.SetFieldData(block.GetBlockName(), "chkdelta", 0, block.chkdelta.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "deltas", 0, block.deltas.ToString("0000000000.000000")); // float 10.6
			_xaQuery.SetFieldData(block.GetBlockName(), "deltae", 0, block.deltae.ToString("0000000000.000000")); // float 10.6
			_xaQuery.SetFieldData(block.GetBlockName(), "chktheta", 0, block.chktheta.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "thetas", 0, block.thetas.ToString("0000000000.000000")); // float 10.6
			_xaQuery.SetFieldData(block.GetBlockName(), "thetae", 0, block.thetae.ToString("0000000000.000000")); // float 10.6
			_xaQuery.SetFieldData(block.GetBlockName(), "chkduedate", 0, block.chkduedate.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "duedates", 0, block.duedates); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "duedatee", 0, block.duedatee); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "chkkoba", 0, block.chkkoba.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "cbkoba", 0, block.cbkoba.ToString()); // char 1

			return true;
		}

		public XQt1955OutBlock GetBlock()
		{
			XQt1955OutBlock instance = XQt1955OutBlock.FromQuery(this);
			return instance;

		}

		public XQt1955OutBlock1[] GetBlock1s()
		{
			XQt1955OutBlock1[] instance = XQt1955OutBlock1.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt1955OutBlock),
			typeof(XQt1955OutBlock1),

		};

	}

}
