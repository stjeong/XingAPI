using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1511InBlock : XingBlock
	{
		/// <summary>
		/// t1511InBlock
		/// </summary>
		static readonly string _blockName = "t1511InBlock";
		/// <summary>
		/// 기본입력
		/// </summary>
		static readonly string _blockDesc = "기본입력";
		/// <summary>
		/// input
		/// </summary>
		static readonly string _blockType = "input";
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _hasOccurs = false;
		/// <summary>
		/// t1511InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1511InBlock
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
		/// 업종코드
		/// </summary>
		[XAQueryFieldAttribute("업종코드")]
		public string upcode;

		public static class F
		{
			/// <summary>
			/// 업종코드
			/// </summary>
			public const string upcode = "upcode";
		}

		public static string[] AllFields = new string[]
		{
			F.upcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["upcode"] = new XAQueryFieldInfo("char", upcode, upcode, "업종코드", (decimal)3);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "upcode":
					this.upcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (upcode.Length > 3) return false; // char 3

			return true;
		}
	}

	public partial class XQt1511OutBlock : XingBlock
	{
		/// <summary>
		/// t1511OutBlock
		/// </summary>
		static readonly string _blockName = "t1511OutBlock";
		/// <summary>
		/// 기본출력
		/// </summary>
		static readonly string _blockDesc = "기본출력";
		/// <summary>
		/// output
		/// </summary>
		static readonly string _blockType = "output";
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _hasOccurs = false;
		/// <summary>
		/// t1511OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1511OutBlock
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// 기본출력
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
		/// 업종구분
		/// </summary>
		[XAQueryFieldAttribute("업종구분")]
		public char gubun;
		/// <summary>
		/// 업종명
		/// </summary>
		[XAQueryFieldAttribute("업종명")]
		public string hname;
		/// <summary>
		/// 현재지수
		/// </summary>
		[XAQueryFieldAttribute("현재지수")]
		public float pricejisu;
		/// <summary>
		/// 전일지수
		/// </summary>
		[XAQueryFieldAttribute("전일지수")]
		public float jniljisu;
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
		/// 지수등락율
		/// </summary>
		[XAQueryFieldAttribute("지수등락율")]
		public float diffjisu;
		/// <summary>
		/// 전일거래량
		/// </summary>
		[XAQueryFieldAttribute("전일거래량")]
		public long jnilvolume;
		/// <summary>
		/// 당일거래량
		/// </summary>
		[XAQueryFieldAttribute("당일거래량")]
		public long volume;
		/// <summary>
		/// 거래량전일대비
		/// </summary>
		[XAQueryFieldAttribute("거래량전일대비")]
		public long volumechange;
		/// <summary>
		/// 거래량비율
		/// </summary>
		[XAQueryFieldAttribute("거래량비율")]
		public float volumerate;
		/// <summary>
		/// 전일거래대금
		/// </summary>
		[XAQueryFieldAttribute("전일거래대금")]
		public long jnilvalue;
		/// <summary>
		/// 당일거래대금
		/// </summary>
		[XAQueryFieldAttribute("당일거래대금")]
		public long value;
		/// <summary>
		/// 거래대금전일대비
		/// </summary>
		[XAQueryFieldAttribute("거래대금전일대비")]
		public long valuechange;
		/// <summary>
		/// 거래대금비율
		/// </summary>
		[XAQueryFieldAttribute("거래대금비율")]
		public float valuerate;
		/// <summary>
		/// 시가지수
		/// </summary>
		[XAQueryFieldAttribute("시가지수")]
		public float openjisu;
		/// <summary>
		/// 시가등락율
		/// </summary>
		[XAQueryFieldAttribute("시가등락율")]
		public float opendiff;
		/// <summary>
		/// 시가시간
		/// </summary>
		[XAQueryFieldAttribute("시가시간")]
		public string opentime;
		/// <summary>
		/// 고가지수
		/// </summary>
		[XAQueryFieldAttribute("고가지수")]
		public float highjisu;
		/// <summary>
		/// 고가등락율
		/// </summary>
		[XAQueryFieldAttribute("고가등락율")]
		public float highdiff;
		/// <summary>
		/// 고가시간
		/// </summary>
		[XAQueryFieldAttribute("고가시간")]
		public string hightime;
		/// <summary>
		/// 저가지수
		/// </summary>
		[XAQueryFieldAttribute("저가지수")]
		public float lowjisu;
		/// <summary>
		/// 저가등락율
		/// </summary>
		[XAQueryFieldAttribute("저가등락율")]
		public float lowdiff;
		/// <summary>
		/// 저가시간
		/// </summary>
		[XAQueryFieldAttribute("저가시간")]
		public string lowtime;
		/// <summary>
		/// 52주최고지수
		/// </summary>
		[XAQueryFieldAttribute("52주최고지수")]
		public float whjisu;
		/// <summary>
		/// 52주최고현재가대비
		/// </summary>
		[XAQueryFieldAttribute("52주최고현재가대비")]
		public float whchange;
		/// <summary>
		/// 52주최고지수일자
		/// </summary>
		[XAQueryFieldAttribute("52주최고지수일자")]
		public string whjday;
		/// <summary>
		/// 52주최저지수
		/// </summary>
		[XAQueryFieldAttribute("52주최저지수")]
		public float wljisu;
		/// <summary>
		/// 52주최저현재가대비
		/// </summary>
		[XAQueryFieldAttribute("52주최저현재가대비")]
		public float wlchange;
		/// <summary>
		/// 52주최저지수일자
		/// </summary>
		[XAQueryFieldAttribute("52주최저지수일자")]
		public string wljday;
		/// <summary>
		/// 연중최고지수
		/// </summary>
		[XAQueryFieldAttribute("연중최고지수")]
		public float yhjisu;
		/// <summary>
		/// 연중최고현재가대비
		/// </summary>
		[XAQueryFieldAttribute("연중최고현재가대비")]
		public float yhchange;
		/// <summary>
		/// 연중최고지수일자
		/// </summary>
		[XAQueryFieldAttribute("연중최고지수일자")]
		public string yhjday;
		/// <summary>
		/// 연중최저지수
		/// </summary>
		[XAQueryFieldAttribute("연중최저지수")]
		public float yljisu;
		/// <summary>
		/// 연중최저현재가대비
		/// </summary>
		[XAQueryFieldAttribute("연중최저현재가대비")]
		public float ylchange;
		/// <summary>
		/// 연중최저지수일자
		/// </summary>
		[XAQueryFieldAttribute("연중최저지수일자")]
		public string yljday;
		/// <summary>
		/// 첫번째지수코드
		/// </summary>
		[XAQueryFieldAttribute("첫번째지수코드")]
		public string firstjcode;
		/// <summary>
		/// 첫번째지수명
		/// </summary>
		[XAQueryFieldAttribute("첫번째지수명")]
		public string firstjname;
		/// <summary>
		/// 첫번째지수
		/// </summary>
		[XAQueryFieldAttribute("첫번째지수")]
		public float firstjisu;
		/// <summary>
		/// 첫번째대비구분
		/// </summary>
		[XAQueryFieldAttribute("첫번째대비구분")]
		public char firsign;
		/// <summary>
		/// 첫번째전일대비
		/// </summary>
		[XAQueryFieldAttribute("첫번째전일대비")]
		public float firchange;
		/// <summary>
		/// 첫번째등락율
		/// </summary>
		[XAQueryFieldAttribute("첫번째등락율")]
		public float firdiff;
		/// <summary>
		/// 두번째지수코드
		/// </summary>
		[XAQueryFieldAttribute("두번째지수코드")]
		public string secondjcode;
		/// <summary>
		/// 두번째지수명
		/// </summary>
		[XAQueryFieldAttribute("두번째지수명")]
		public string secondjname;
		/// <summary>
		/// 두번째지수
		/// </summary>
		[XAQueryFieldAttribute("두번째지수")]
		public float secondjisu;
		/// <summary>
		/// 두번째대비구분
		/// </summary>
		[XAQueryFieldAttribute("두번째대비구분")]
		public char secsign;
		/// <summary>
		/// 두번째전일대비
		/// </summary>
		[XAQueryFieldAttribute("두번째전일대비")]
		public float secchange;
		/// <summary>
		/// 두번째등락율
		/// </summary>
		[XAQueryFieldAttribute("두번째등락율")]
		public float secdiff;
		/// <summary>
		/// 세번째지수코드
		/// </summary>
		[XAQueryFieldAttribute("세번째지수코드")]
		public string thirdjcode;
		/// <summary>
		/// 세번째지수명
		/// </summary>
		[XAQueryFieldAttribute("세번째지수명")]
		public string thirdjname;
		/// <summary>
		/// 세번째지수
		/// </summary>
		[XAQueryFieldAttribute("세번째지수")]
		public float thirdjisu;
		/// <summary>
		/// 세번째대비구분
		/// </summary>
		[XAQueryFieldAttribute("세번째대비구분")]
		public char thrsign;
		/// <summary>
		/// 세번째전일대비
		/// </summary>
		[XAQueryFieldAttribute("세번째전일대비")]
		public float thrchange;
		/// <summary>
		/// 세번째등락율
		/// </summary>
		[XAQueryFieldAttribute("세번째등락율")]
		public float thrdiff;
		/// <summary>
		/// 네번째지수코드
		/// </summary>
		[XAQueryFieldAttribute("네번째지수코드")]
		public string fourthjcode;
		/// <summary>
		/// 네번째지수명
		/// </summary>
		[XAQueryFieldAttribute("네번째지수명")]
		public string fourthjname;
		/// <summary>
		/// 네번째지수
		/// </summary>
		[XAQueryFieldAttribute("네번째지수")]
		public float fourthjisu;
		/// <summary>
		/// 네번째대비구분
		/// </summary>
		[XAQueryFieldAttribute("네번째대비구분")]
		public char forsign;
		/// <summary>
		/// 네번째전일대비
		/// </summary>
		[XAQueryFieldAttribute("네번째전일대비")]
		public float forchange;
		/// <summary>
		/// 네번째등락율
		/// </summary>
		[XAQueryFieldAttribute("네번째등락율")]
		public float fordiff;
		/// <summary>
		/// 상승종목수
		/// </summary>
		[XAQueryFieldAttribute("상승종목수")]
		public long highjo;
		/// <summary>
		/// 상한종목수
		/// </summary>
		[XAQueryFieldAttribute("상한종목수")]
		public long upjo;
		/// <summary>
		/// 보합종목수
		/// </summary>
		[XAQueryFieldAttribute("보합종목수")]
		public long unchgjo;
		/// <summary>
		/// 하락종목수
		/// </summary>
		[XAQueryFieldAttribute("하락종목수")]
		public long lowjo;
		/// <summary>
		/// 하한종목수
		/// </summary>
		[XAQueryFieldAttribute("하한종목수")]
		public long downjo;

		public static class F
		{
			/// <summary>
			/// 업종구분
			/// </summary>
			public const string gubun = "gubun";
			/// <summary>
			/// 업종명
			/// </summary>
			public const string hname = "hname";
			/// <summary>
			/// 현재지수
			/// </summary>
			public const string pricejisu = "pricejisu";
			/// <summary>
			/// 전일지수
			/// </summary>
			public const string jniljisu = "jniljisu";
			/// <summary>
			/// 전일대비구분
			/// </summary>
			public const string sign = "sign";
			/// <summary>
			/// 전일대비
			/// </summary>
			public const string change = "change";
			/// <summary>
			/// 지수등락율
			/// </summary>
			public const string diffjisu = "diffjisu";
			/// <summary>
			/// 전일거래량
			/// </summary>
			public const string jnilvolume = "jnilvolume";
			/// <summary>
			/// 당일거래량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// 거래량전일대비
			/// </summary>
			public const string volumechange = "volumechange";
			/// <summary>
			/// 거래량비율
			/// </summary>
			public const string volumerate = "volumerate";
			/// <summary>
			/// 전일거래대금
			/// </summary>
			public const string jnilvalue = "jnilvalue";
			/// <summary>
			/// 당일거래대금
			/// </summary>
			public const string value = "value";
			/// <summary>
			/// 거래대금전일대비
			/// </summary>
			public const string valuechange = "valuechange";
			/// <summary>
			/// 거래대금비율
			/// </summary>
			public const string valuerate = "valuerate";
			/// <summary>
			/// 시가지수
			/// </summary>
			public const string openjisu = "openjisu";
			/// <summary>
			/// 시가등락율
			/// </summary>
			public const string opendiff = "opendiff";
			/// <summary>
			/// 시가시간
			/// </summary>
			public const string opentime = "opentime";
			/// <summary>
			/// 고가지수
			/// </summary>
			public const string highjisu = "highjisu";
			/// <summary>
			/// 고가등락율
			/// </summary>
			public const string highdiff = "highdiff";
			/// <summary>
			/// 고가시간
			/// </summary>
			public const string hightime = "hightime";
			/// <summary>
			/// 저가지수
			/// </summary>
			public const string lowjisu = "lowjisu";
			/// <summary>
			/// 저가등락율
			/// </summary>
			public const string lowdiff = "lowdiff";
			/// <summary>
			/// 저가시간
			/// </summary>
			public const string lowtime = "lowtime";
			/// <summary>
			/// 52주최고지수
			/// </summary>
			public const string whjisu = "whjisu";
			/// <summary>
			/// 52주최고현재가대비
			/// </summary>
			public const string whchange = "whchange";
			/// <summary>
			/// 52주최고지수일자
			/// </summary>
			public const string whjday = "whjday";
			/// <summary>
			/// 52주최저지수
			/// </summary>
			public const string wljisu = "wljisu";
			/// <summary>
			/// 52주최저현재가대비
			/// </summary>
			public const string wlchange = "wlchange";
			/// <summary>
			/// 52주최저지수일자
			/// </summary>
			public const string wljday = "wljday";
			/// <summary>
			/// 연중최고지수
			/// </summary>
			public const string yhjisu = "yhjisu";
			/// <summary>
			/// 연중최고현재가대비
			/// </summary>
			public const string yhchange = "yhchange";
			/// <summary>
			/// 연중최고지수일자
			/// </summary>
			public const string yhjday = "yhjday";
			/// <summary>
			/// 연중최저지수
			/// </summary>
			public const string yljisu = "yljisu";
			/// <summary>
			/// 연중최저현재가대비
			/// </summary>
			public const string ylchange = "ylchange";
			/// <summary>
			/// 연중최저지수일자
			/// </summary>
			public const string yljday = "yljday";
			/// <summary>
			/// 첫번째지수코드
			/// </summary>
			public const string firstjcode = "firstjcode";
			/// <summary>
			/// 첫번째지수명
			/// </summary>
			public const string firstjname = "firstjname";
			/// <summary>
			/// 첫번째지수
			/// </summary>
			public const string firstjisu = "firstjisu";
			/// <summary>
			/// 첫번째대비구분
			/// </summary>
			public const string firsign = "firsign";
			/// <summary>
			/// 첫번째전일대비
			/// </summary>
			public const string firchange = "firchange";
			/// <summary>
			/// 첫번째등락율
			/// </summary>
			public const string firdiff = "firdiff";
			/// <summary>
			/// 두번째지수코드
			/// </summary>
			public const string secondjcode = "secondjcode";
			/// <summary>
			/// 두번째지수명
			/// </summary>
			public const string secondjname = "secondjname";
			/// <summary>
			/// 두번째지수
			/// </summary>
			public const string secondjisu = "secondjisu";
			/// <summary>
			/// 두번째대비구분
			/// </summary>
			public const string secsign = "secsign";
			/// <summary>
			/// 두번째전일대비
			/// </summary>
			public const string secchange = "secchange";
			/// <summary>
			/// 두번째등락율
			/// </summary>
			public const string secdiff = "secdiff";
			/// <summary>
			/// 세번째지수코드
			/// </summary>
			public const string thirdjcode = "thirdjcode";
			/// <summary>
			/// 세번째지수명
			/// </summary>
			public const string thirdjname = "thirdjname";
			/// <summary>
			/// 세번째지수
			/// </summary>
			public const string thirdjisu = "thirdjisu";
			/// <summary>
			/// 세번째대비구분
			/// </summary>
			public const string thrsign = "thrsign";
			/// <summary>
			/// 세번째전일대비
			/// </summary>
			public const string thrchange = "thrchange";
			/// <summary>
			/// 세번째등락율
			/// </summary>
			public const string thrdiff = "thrdiff";
			/// <summary>
			/// 네번째지수코드
			/// </summary>
			public const string fourthjcode = "fourthjcode";
			/// <summary>
			/// 네번째지수명
			/// </summary>
			public const string fourthjname = "fourthjname";
			/// <summary>
			/// 네번째지수
			/// </summary>
			public const string fourthjisu = "fourthjisu";
			/// <summary>
			/// 네번째대비구분
			/// </summary>
			public const string forsign = "forsign";
			/// <summary>
			/// 네번째전일대비
			/// </summary>
			public const string forchange = "forchange";
			/// <summary>
			/// 네번째등락율
			/// </summary>
			public const string fordiff = "fordiff";
			/// <summary>
			/// 상승종목수
			/// </summary>
			public const string highjo = "highjo";
			/// <summary>
			/// 상한종목수
			/// </summary>
			public const string upjo = "upjo";
			/// <summary>
			/// 보합종목수
			/// </summary>
			public const string unchgjo = "unchgjo";
			/// <summary>
			/// 하락종목수
			/// </summary>
			public const string lowjo = "lowjo";
			/// <summary>
			/// 하한종목수
			/// </summary>
			public const string downjo = "downjo";
		}

		public static string[] AllFields = new string[]
		{
			F.gubun,
			F.hname,
			F.pricejisu,
			F.jniljisu,
			F.sign,
			F.change,
			F.diffjisu,
			F.jnilvolume,
			F.volume,
			F.volumechange,
			F.volumerate,
			F.jnilvalue,
			F.value,
			F.valuechange,
			F.valuerate,
			F.openjisu,
			F.opendiff,
			F.opentime,
			F.highjisu,
			F.highdiff,
			F.hightime,
			F.lowjisu,
			F.lowdiff,
			F.lowtime,
			F.whjisu,
			F.whchange,
			F.whjday,
			F.wljisu,
			F.wlchange,
			F.wljday,
			F.yhjisu,
			F.yhchange,
			F.yhjday,
			F.yljisu,
			F.ylchange,
			F.yljday,
			F.firstjcode,
			F.firstjname,
			F.firstjisu,
			F.firsign,
			F.firchange,
			F.firdiff,
			F.secondjcode,
			F.secondjname,
			F.secondjisu,
			F.secsign,
			F.secchange,
			F.secdiff,
			F.thirdjcode,
			F.thirdjname,
			F.thirdjisu,
			F.thrsign,
			F.thrchange,
			F.thrdiff,
			F.fourthjcode,
			F.fourthjname,
			F.fourthjisu,
			F.forsign,
			F.forchange,
			F.fordiff,
			F.highjo,
			F.upjo,
			F.unchgjo,
			F.lowjo,
			F.downjo,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["gubun"] = new XAQueryFieldInfo("char", gubun, gubun.ToString(), "업종구분", (decimal)1);
			dict["hname"] = new XAQueryFieldInfo("char", hname, hname, "업종명", (decimal)20);
			dict["pricejisu"] = new XAQueryFieldInfo("float", pricejisu, pricejisu.ToString("0000000.00"), "현재지수", (decimal)7.2);
			dict["jniljisu"] = new XAQueryFieldInfo("float", jniljisu, jniljisu.ToString("0000000.00"), "전일지수", (decimal)7.2);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("float", change, change.ToString("0000000.00"), "전일대비", (decimal)7.2);
			dict["diffjisu"] = new XAQueryFieldInfo("float", diffjisu, diffjisu.ToString("000000.00"), "지수등락율", (decimal)6.2);
			dict["jnilvolume"] = new XAQueryFieldInfo("long", jnilvolume, jnilvolume.ToString("d12"), "전일거래량", (decimal)12);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "당일거래량", (decimal)12);
			dict["volumechange"] = new XAQueryFieldInfo("long", volumechange, volumechange.ToString("d12"), "거래량전일대비", (decimal)12);
			dict["volumerate"] = new XAQueryFieldInfo("float", volumerate, volumerate.ToString("000000.00"), "거래량비율", (decimal)6.2);
			dict["jnilvalue"] = new XAQueryFieldInfo("long", jnilvalue, jnilvalue.ToString("d12"), "전일거래대금", (decimal)12);
			dict["value"] = new XAQueryFieldInfo("long", value, value.ToString("d12"), "당일거래대금", (decimal)12);
			dict["valuechange"] = new XAQueryFieldInfo("long", valuechange, valuechange.ToString("d12"), "거래대금전일대비", (decimal)12);
			dict["valuerate"] = new XAQueryFieldInfo("float", valuerate, valuerate.ToString("000000.00"), "거래대금비율", (decimal)6.2);
			dict["openjisu"] = new XAQueryFieldInfo("float", openjisu, openjisu.ToString("0000000.00"), "시가지수", (decimal)7.2);
			dict["opendiff"] = new XAQueryFieldInfo("float", opendiff, opendiff.ToString("000000.00"), "시가등락율", (decimal)6.2);
			dict["opentime"] = new XAQueryFieldInfo("char", opentime, opentime, "시가시간", (decimal)6);
			dict["highjisu"] = new XAQueryFieldInfo("float", highjisu, highjisu.ToString("0000000.00"), "고가지수", (decimal)7.2);
			dict["highdiff"] = new XAQueryFieldInfo("float", highdiff, highdiff.ToString("000000.00"), "고가등락율", (decimal)6.2);
			dict["hightime"] = new XAQueryFieldInfo("char", hightime, hightime, "고가시간", (decimal)6);
			dict["lowjisu"] = new XAQueryFieldInfo("float", lowjisu, lowjisu.ToString("0000000.00"), "저가지수", (decimal)7.2);
			dict["lowdiff"] = new XAQueryFieldInfo("float", lowdiff, lowdiff.ToString("000000.00"), "저가등락율", (decimal)6.2);
			dict["lowtime"] = new XAQueryFieldInfo("char", lowtime, lowtime, "저가시간", (decimal)6);
			dict["whjisu"] = new XAQueryFieldInfo("float", whjisu, whjisu.ToString("0000000.00"), "52주최고지수", (decimal)7.2);
			dict["whchange"] = new XAQueryFieldInfo("float", whchange, whchange.ToString("0000000.00"), "52주최고현재가대비", (decimal)7.2);
			dict["whjday"] = new XAQueryFieldInfo("char", whjday, whjday, "52주최고지수일자", (decimal)8);
			dict["wljisu"] = new XAQueryFieldInfo("float", wljisu, wljisu.ToString("0000000.00"), "52주최저지수", (decimal)7.2);
			dict["wlchange"] = new XAQueryFieldInfo("float", wlchange, wlchange.ToString("0000000.00"), "52주최저현재가대비", (decimal)7.2);
			dict["wljday"] = new XAQueryFieldInfo("char", wljday, wljday, "52주최저지수일자", (decimal)8);
			dict["yhjisu"] = new XAQueryFieldInfo("float", yhjisu, yhjisu.ToString("0000000.00"), "연중최고지수", (decimal)7.2);
			dict["yhchange"] = new XAQueryFieldInfo("float", yhchange, yhchange.ToString("0000000.00"), "연중최고현재가대비", (decimal)7.2);
			dict["yhjday"] = new XAQueryFieldInfo("char", yhjday, yhjday, "연중최고지수일자", (decimal)8);
			dict["yljisu"] = new XAQueryFieldInfo("float", yljisu, yljisu.ToString("0000000.00"), "연중최저지수", (decimal)7.2);
			dict["ylchange"] = new XAQueryFieldInfo("float", ylchange, ylchange.ToString("0000000.00"), "연중최저현재가대비", (decimal)7.2);
			dict["yljday"] = new XAQueryFieldInfo("char", yljday, yljday, "연중최저지수일자", (decimal)8);
			dict["firstjcode"] = new XAQueryFieldInfo("char", firstjcode, firstjcode, "첫번째지수코드", (decimal)3);
			dict["firstjname"] = new XAQueryFieldInfo("char", firstjname, firstjname, "첫번째지수명", (decimal)20);
			dict["firstjisu"] = new XAQueryFieldInfo("float", firstjisu, firstjisu.ToString("0000000.00"), "첫번째지수", (decimal)7.2);
			dict["firsign"] = new XAQueryFieldInfo("char", firsign, firsign.ToString(), "첫번째대비구분", (decimal)1);
			dict["firchange"] = new XAQueryFieldInfo("float", firchange, firchange.ToString("0000000.00"), "첫번째전일대비", (decimal)7.2);
			dict["firdiff"] = new XAQueryFieldInfo("float", firdiff, firdiff.ToString("000000.00"), "첫번째등락율", (decimal)6.2);
			dict["secondjcode"] = new XAQueryFieldInfo("char", secondjcode, secondjcode, "두번째지수코드", (decimal)3);
			dict["secondjname"] = new XAQueryFieldInfo("char", secondjname, secondjname, "두번째지수명", (decimal)20);
			dict["secondjisu"] = new XAQueryFieldInfo("float", secondjisu, secondjisu.ToString("0000000.00"), "두번째지수", (decimal)7.2);
			dict["secsign"] = new XAQueryFieldInfo("char", secsign, secsign.ToString(), "두번째대비구분", (decimal)1);
			dict["secchange"] = new XAQueryFieldInfo("float", secchange, secchange.ToString("0000000.00"), "두번째전일대비", (decimal)7.2);
			dict["secdiff"] = new XAQueryFieldInfo("float", secdiff, secdiff.ToString("000000.00"), "두번째등락율", (decimal)6.2);
			dict["thirdjcode"] = new XAQueryFieldInfo("char", thirdjcode, thirdjcode, "세번째지수코드", (decimal)3);
			dict["thirdjname"] = new XAQueryFieldInfo("char", thirdjname, thirdjname, "세번째지수명", (decimal)20);
			dict["thirdjisu"] = new XAQueryFieldInfo("float", thirdjisu, thirdjisu.ToString("0000000.00"), "세번째지수", (decimal)7.2);
			dict["thrsign"] = new XAQueryFieldInfo("char", thrsign, thrsign.ToString(), "세번째대비구분", (decimal)1);
			dict["thrchange"] = new XAQueryFieldInfo("float", thrchange, thrchange.ToString("0000000.00"), "세번째전일대비", (decimal)7.2);
			dict["thrdiff"] = new XAQueryFieldInfo("float", thrdiff, thrdiff.ToString("000000.00"), "세번째등락율", (decimal)6.2);
			dict["fourthjcode"] = new XAQueryFieldInfo("char", fourthjcode, fourthjcode, "네번째지수코드", (decimal)3);
			dict["fourthjname"] = new XAQueryFieldInfo("char", fourthjname, fourthjname, "네번째지수명", (decimal)20);
			dict["fourthjisu"] = new XAQueryFieldInfo("float", fourthjisu, fourthjisu.ToString("0000000.00"), "네번째지수", (decimal)7.2);
			dict["forsign"] = new XAQueryFieldInfo("char", forsign, forsign.ToString(), "네번째대비구분", (decimal)1);
			dict["forchange"] = new XAQueryFieldInfo("float", forchange, forchange.ToString("0000000.00"), "네번째전일대비", (decimal)7.2);
			dict["fordiff"] = new XAQueryFieldInfo("float", fordiff, fordiff.ToString("000000.00"), "네번째등락율", (decimal)6.2);
			dict["highjo"] = new XAQueryFieldInfo("long", highjo, highjo.ToString("d4"), "상승종목수", (decimal)4);
			dict["upjo"] = new XAQueryFieldInfo("long", upjo, upjo.ToString("d4"), "상한종목수", (decimal)4);
			dict["unchgjo"] = new XAQueryFieldInfo("long", unchgjo, unchgjo.ToString("d4"), "보합종목수", (decimal)4);
			dict["lowjo"] = new XAQueryFieldInfo("long", lowjo, lowjo.ToString("d4"), "하락종목수", (decimal)4);
			dict["downjo"] = new XAQueryFieldInfo("long", downjo, downjo.ToString("d4"), "하한종목수", (decimal)4);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "gubun":
					this.gubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "hname":
					this.hname = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "pricejisu":
					this.pricejisu = fieldInfo.FieldValue.ParseFloat("pricejisu");
				break;

				case "jniljisu":
					this.jniljisu = fieldInfo.FieldValue.ParseFloat("jniljisu");
				break;

				case "sign":
					this.sign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "change":
					this.change = fieldInfo.FieldValue.ParseFloat("change");
				break;

				case "diffjisu":
					this.diffjisu = fieldInfo.FieldValue.ParseFloat("diffjisu");
				break;

				case "jnilvolume":
					this.jnilvolume = fieldInfo.FieldValue.ParseLong("jnilvolume");
				break;

				case "volume":
					this.volume = fieldInfo.FieldValue.ParseLong("volume");
				break;

				case "volumechange":
					this.volumechange = fieldInfo.FieldValue.ParseLong("volumechange");
				break;

				case "volumerate":
					this.volumerate = fieldInfo.FieldValue.ParseFloat("volumerate");
				break;

				case "jnilvalue":
					this.jnilvalue = fieldInfo.FieldValue.ParseLong("jnilvalue");
				break;

				case "value":
					this.value = fieldInfo.FieldValue.ParseLong("value");
				break;

				case "valuechange":
					this.valuechange = fieldInfo.FieldValue.ParseLong("valuechange");
				break;

				case "valuerate":
					this.valuerate = fieldInfo.FieldValue.ParseFloat("valuerate");
				break;

				case "openjisu":
					this.openjisu = fieldInfo.FieldValue.ParseFloat("openjisu");
				break;

				case "opendiff":
					this.opendiff = fieldInfo.FieldValue.ParseFloat("opendiff");
				break;

				case "opentime":
					this.opentime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "highjisu":
					this.highjisu = fieldInfo.FieldValue.ParseFloat("highjisu");
				break;

				case "highdiff":
					this.highdiff = fieldInfo.FieldValue.ParseFloat("highdiff");
				break;

				case "hightime":
					this.hightime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "lowjisu":
					this.lowjisu = fieldInfo.FieldValue.ParseFloat("lowjisu");
				break;

				case "lowdiff":
					this.lowdiff = fieldInfo.FieldValue.ParseFloat("lowdiff");
				break;

				case "lowtime":
					this.lowtime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "whjisu":
					this.whjisu = fieldInfo.FieldValue.ParseFloat("whjisu");
				break;

				case "whchange":
					this.whchange = fieldInfo.FieldValue.ParseFloat("whchange");
				break;

				case "whjday":
					this.whjday = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "wljisu":
					this.wljisu = fieldInfo.FieldValue.ParseFloat("wljisu");
				break;

				case "wlchange":
					this.wlchange = fieldInfo.FieldValue.ParseFloat("wlchange");
				break;

				case "wljday":
					this.wljday = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "yhjisu":
					this.yhjisu = fieldInfo.FieldValue.ParseFloat("yhjisu");
				break;

				case "yhchange":
					this.yhchange = fieldInfo.FieldValue.ParseFloat("yhchange");
				break;

				case "yhjday":
					this.yhjday = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "yljisu":
					this.yljisu = fieldInfo.FieldValue.ParseFloat("yljisu");
				break;

				case "ylchange":
					this.ylchange = fieldInfo.FieldValue.ParseFloat("ylchange");
				break;

				case "yljday":
					this.yljday = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "firstjcode":
					this.firstjcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "firstjname":
					this.firstjname = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "firstjisu":
					this.firstjisu = fieldInfo.FieldValue.ParseFloat("firstjisu");
				break;

				case "firsign":
					this.firsign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "firchange":
					this.firchange = fieldInfo.FieldValue.ParseFloat("firchange");
				break;

				case "firdiff":
					this.firdiff = fieldInfo.FieldValue.ParseFloat("firdiff");
				break;

				case "secondjcode":
					this.secondjcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "secondjname":
					this.secondjname = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "secondjisu":
					this.secondjisu = fieldInfo.FieldValue.ParseFloat("secondjisu");
				break;

				case "secsign":
					this.secsign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "secchange":
					this.secchange = fieldInfo.FieldValue.ParseFloat("secchange");
				break;

				case "secdiff":
					this.secdiff = fieldInfo.FieldValue.ParseFloat("secdiff");
				break;

				case "thirdjcode":
					this.thirdjcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "thirdjname":
					this.thirdjname = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "thirdjisu":
					this.thirdjisu = fieldInfo.FieldValue.ParseFloat("thirdjisu");
				break;

				case "thrsign":
					this.thrsign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "thrchange":
					this.thrchange = fieldInfo.FieldValue.ParseFloat("thrchange");
				break;

				case "thrdiff":
					this.thrdiff = fieldInfo.FieldValue.ParseFloat("thrdiff");
				break;

				case "fourthjcode":
					this.fourthjcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "fourthjname":
					this.fourthjname = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "fourthjisu":
					this.fourthjisu = fieldInfo.FieldValue.ParseFloat("fourthjisu");
				break;

				case "forsign":
					this.forsign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "forchange":
					this.forchange = fieldInfo.FieldValue.ParseFloat("forchange");
				break;

				case "fordiff":
					this.fordiff = fieldInfo.FieldValue.ParseFloat("fordiff");
				break;

				case "highjo":
					this.highjo = fieldInfo.FieldValue.ParseLong("highjo");
				break;

				case "upjo":
					this.upjo = fieldInfo.FieldValue.ParseLong("upjo");
				break;

				case "unchgjo":
					this.unchgjo = fieldInfo.FieldValue.ParseLong("unchgjo");
				break;

				case "lowjo":
					this.lowjo = fieldInfo.FieldValue.ParseLong("lowjo");
				break;

				case "downjo":
					this.downjo = fieldInfo.FieldValue.ParseLong("downjo");
				break;


			}
		}

		public static XQt1511OutBlock FromQuery(XQt1511 query)
		{
			XQt1511OutBlock block = new XQt1511OutBlock();
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
				block.gubun = query.GetFieldData(block.GetBlockName(), "gubun", 0).FirstOrDefault(); // char 1
				block.hname = query.GetFieldData(block.GetBlockName(), "hname", 0).TrimEnd('?'); // char 20
				block.pricejisu = query.GetFieldData(block.GetBlockName(), "pricejisu", 0).ParseFloat("pricejisu"); // float 7.2
				block.jniljisu = query.GetFieldData(block.GetBlockName(), "jniljisu", 0).ParseFloat("jniljisu"); // float 7.2
				block.sign = query.GetFieldData(block.GetBlockName(), "sign", 0).FirstOrDefault(); // char 1
				block.change = query.GetFieldData(block.GetBlockName(), "change", 0).ParseFloat("change"); // float 7.2
				block.diffjisu = query.GetFieldData(block.GetBlockName(), "diffjisu", 0).ParseFloat("diffjisu"); // float 6.2
				block.jnilvolume = query.GetFieldData(block.GetBlockName(), "jnilvolume", 0).ParseLong("jnilvolume"); // long 12
				block.volume = query.GetFieldData(block.GetBlockName(), "volume", 0).ParseLong("volume"); // long 12
				block.volumechange = query.GetFieldData(block.GetBlockName(), "volumechange", 0).ParseLong("volumechange"); // long 12
				block.volumerate = query.GetFieldData(block.GetBlockName(), "volumerate", 0).ParseFloat("volumerate"); // float 6.2
				block.jnilvalue = query.GetFieldData(block.GetBlockName(), "jnilvalue", 0).ParseLong("jnilvalue"); // long 12
				block.value = query.GetFieldData(block.GetBlockName(), "value", 0).ParseLong("value"); // long 12
				block.valuechange = query.GetFieldData(block.GetBlockName(), "valuechange", 0).ParseLong("valuechange"); // long 12
				block.valuerate = query.GetFieldData(block.GetBlockName(), "valuerate", 0).ParseFloat("valuerate"); // float 6.2
				block.openjisu = query.GetFieldData(block.GetBlockName(), "openjisu", 0).ParseFloat("openjisu"); // float 7.2
				block.opendiff = query.GetFieldData(block.GetBlockName(), "opendiff", 0).ParseFloat("opendiff"); // float 6.2
				block.opentime = query.GetFieldData(block.GetBlockName(), "opentime", 0).TrimEnd('?'); // char 6
				block.highjisu = query.GetFieldData(block.GetBlockName(), "highjisu", 0).ParseFloat("highjisu"); // float 7.2
				block.highdiff = query.GetFieldData(block.GetBlockName(), "highdiff", 0).ParseFloat("highdiff"); // float 6.2
				block.hightime = query.GetFieldData(block.GetBlockName(), "hightime", 0).TrimEnd('?'); // char 6
				block.lowjisu = query.GetFieldData(block.GetBlockName(), "lowjisu", 0).ParseFloat("lowjisu"); // float 7.2
				block.lowdiff = query.GetFieldData(block.GetBlockName(), "lowdiff", 0).ParseFloat("lowdiff"); // float 6.2
				block.lowtime = query.GetFieldData(block.GetBlockName(), "lowtime", 0).TrimEnd('?'); // char 6
				block.whjisu = query.GetFieldData(block.GetBlockName(), "whjisu", 0).ParseFloat("whjisu"); // float 7.2
				block.whchange = query.GetFieldData(block.GetBlockName(), "whchange", 0).ParseFloat("whchange"); // float 7.2
				block.whjday = query.GetFieldData(block.GetBlockName(), "whjday", 0).TrimEnd('?'); // char 8
				block.wljisu = query.GetFieldData(block.GetBlockName(), "wljisu", 0).ParseFloat("wljisu"); // float 7.2
				block.wlchange = query.GetFieldData(block.GetBlockName(), "wlchange", 0).ParseFloat("wlchange"); // float 7.2
				block.wljday = query.GetFieldData(block.GetBlockName(), "wljday", 0).TrimEnd('?'); // char 8
				block.yhjisu = query.GetFieldData(block.GetBlockName(), "yhjisu", 0).ParseFloat("yhjisu"); // float 7.2
				block.yhchange = query.GetFieldData(block.GetBlockName(), "yhchange", 0).ParseFloat("yhchange"); // float 7.2
				block.yhjday = query.GetFieldData(block.GetBlockName(), "yhjday", 0).TrimEnd('?'); // char 8
				block.yljisu = query.GetFieldData(block.GetBlockName(), "yljisu", 0).ParseFloat("yljisu"); // float 7.2
				block.ylchange = query.GetFieldData(block.GetBlockName(), "ylchange", 0).ParseFloat("ylchange"); // float 7.2
				block.yljday = query.GetFieldData(block.GetBlockName(), "yljday", 0).TrimEnd('?'); // char 8
				block.firstjcode = query.GetFieldData(block.GetBlockName(), "firstjcode", 0).TrimEnd('?'); // char 3
				block.firstjname = query.GetFieldData(block.GetBlockName(), "firstjname", 0).TrimEnd('?'); // char 20
				block.firstjisu = query.GetFieldData(block.GetBlockName(), "firstjisu", 0).ParseFloat("firstjisu"); // float 7.2
				block.firsign = query.GetFieldData(block.GetBlockName(), "firsign", 0).FirstOrDefault(); // char 1
				block.firchange = query.GetFieldData(block.GetBlockName(), "firchange", 0).ParseFloat("firchange"); // float 7.2
				block.firdiff = query.GetFieldData(block.GetBlockName(), "firdiff", 0).ParseFloat("firdiff"); // float 6.2
				block.secondjcode = query.GetFieldData(block.GetBlockName(), "secondjcode", 0).TrimEnd('?'); // char 3
				block.secondjname = query.GetFieldData(block.GetBlockName(), "secondjname", 0).TrimEnd('?'); // char 20
				block.secondjisu = query.GetFieldData(block.GetBlockName(), "secondjisu", 0).ParseFloat("secondjisu"); // float 7.2
				block.secsign = query.GetFieldData(block.GetBlockName(), "secsign", 0).FirstOrDefault(); // char 1
				block.secchange = query.GetFieldData(block.GetBlockName(), "secchange", 0).ParseFloat("secchange"); // float 7.2
				block.secdiff = query.GetFieldData(block.GetBlockName(), "secdiff", 0).ParseFloat("secdiff"); // float 6.2
				block.thirdjcode = query.GetFieldData(block.GetBlockName(), "thirdjcode", 0).TrimEnd('?'); // char 3
				block.thirdjname = query.GetFieldData(block.GetBlockName(), "thirdjname", 0).TrimEnd('?'); // char 20
				block.thirdjisu = query.GetFieldData(block.GetBlockName(), "thirdjisu", 0).ParseFloat("thirdjisu"); // float 7.2
				block.thrsign = query.GetFieldData(block.GetBlockName(), "thrsign", 0).FirstOrDefault(); // char 1
				block.thrchange = query.GetFieldData(block.GetBlockName(), "thrchange", 0).ParseFloat("thrchange"); // float 7.2
				block.thrdiff = query.GetFieldData(block.GetBlockName(), "thrdiff", 0).ParseFloat("thrdiff"); // float 6.2
				block.fourthjcode = query.GetFieldData(block.GetBlockName(), "fourthjcode", 0).TrimEnd('?'); // char 3
				block.fourthjname = query.GetFieldData(block.GetBlockName(), "fourthjname", 0).TrimEnd('?'); // char 20
				block.fourthjisu = query.GetFieldData(block.GetBlockName(), "fourthjisu", 0).ParseFloat("fourthjisu"); // float 7.2
				block.forsign = query.GetFieldData(block.GetBlockName(), "forsign", 0).FirstOrDefault(); // char 1
				block.forchange = query.GetFieldData(block.GetBlockName(), "forchange", 0).ParseFloat("forchange"); // float 7.2
				block.fordiff = query.GetFieldData(block.GetBlockName(), "fordiff", 0).ParseFloat("fordiff"); // float 6.2
				block.highjo = query.GetFieldData(block.GetBlockName(), "highjo", 0).ParseLong("highjo"); // long 4
				block.upjo = query.GetFieldData(block.GetBlockName(), "upjo", 0).ParseLong("upjo"); // long 4
				block.unchgjo = query.GetFieldData(block.GetBlockName(), "unchgjo", 0).ParseLong("unchgjo"); // long 4
				block.lowjo = query.GetFieldData(block.GetBlockName(), "lowjo", 0).ParseLong("lowjo"); // long 4
				block.downjo = query.GetFieldData(block.GetBlockName(), "downjo", 0).ParseLong("downjo"); // long 4

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			// gubun char 1
			if (hname.Length > 20) return false; // char 20
			// pricejisu float 7.2
			// jniljisu float 7.2
			// sign char 1
			// change float 7.2
			// diffjisu float 6.2
			if (jnilvolume.ToString().Length > 12) return false; // long 12
			if (volume.ToString().Length > 12) return false; // long 12
			if (volumechange.ToString().Length > 12) return false; // long 12
			// volumerate float 6.2
			if (jnilvalue.ToString().Length > 12) return false; // long 12
			if (value.ToString().Length > 12) return false; // long 12
			if (valuechange.ToString().Length > 12) return false; // long 12
			// valuerate float 6.2
			// openjisu float 7.2
			// opendiff float 6.2
			if (opentime.Length > 6) return false; // char 6
			// highjisu float 7.2
			// highdiff float 6.2
			if (hightime.Length > 6) return false; // char 6
			// lowjisu float 7.2
			// lowdiff float 6.2
			if (lowtime.Length > 6) return false; // char 6
			// whjisu float 7.2
			// whchange float 7.2
			if (whjday.Length > 8) return false; // char 8
			// wljisu float 7.2
			// wlchange float 7.2
			if (wljday.Length > 8) return false; // char 8
			// yhjisu float 7.2
			// yhchange float 7.2
			if (yhjday.Length > 8) return false; // char 8
			// yljisu float 7.2
			// ylchange float 7.2
			if (yljday.Length > 8) return false; // char 8
			if (firstjcode.Length > 3) return false; // char 3
			if (firstjname.Length > 20) return false; // char 20
			// firstjisu float 7.2
			// firsign char 1
			// firchange float 7.2
			// firdiff float 6.2
			if (secondjcode.Length > 3) return false; // char 3
			if (secondjname.Length > 20) return false; // char 20
			// secondjisu float 7.2
			// secsign char 1
			// secchange float 7.2
			// secdiff float 6.2
			if (thirdjcode.Length > 3) return false; // char 3
			if (thirdjname.Length > 20) return false; // char 20
			// thirdjisu float 7.2
			// thrsign char 1
			// thrchange float 7.2
			// thrdiff float 6.2
			if (fourthjcode.Length > 3) return false; // char 3
			if (fourthjname.Length > 20) return false; // char 20
			// fourthjisu float 7.2
			// forsign char 1
			// forchange float 7.2
			// fordiff float 6.2
			if (highjo.ToString().Length > 4) return false; // long 4
			if (upjo.ToString().Length > 4) return false; // long 4
			if (unchgjo.ToString().Length > 4) return false; // long 4
			if (lowjo.ToString().Length > 4) return false; // long 4
			if (downjo.ToString().Length > 4) return false; // long 4

			return true;
		}
	}

	public partial class XQt1511 : XingQuery
	{
		/// <summary>
		/// t1511
		/// </summary>
		static readonly string _typeName = "t1511";
		/// <summary>
		/// 업종현재가(t1511)
		/// </summary>
		static readonly string _typeDesc = "업종현재가(t1511)";
		/// <summary>
		/// 
		/// </summary>
		static readonly string _service = "";
		/// <summary>
		/// A
		/// </summary>
		static readonly string _headType = "A";
		/// <summary>
		/// 
		/// </summary>
		static readonly string _creator = "";
		/// <summary>
		/// 
		/// </summary>
		static readonly string _createdDate = "";
		/// <summary>
		/// true
		/// </summary>
		static readonly bool _attr = true;
		/// <summary>
		/// true
		/// </summary>
		static readonly bool _block = true;
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _encrypt = false;
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _signature = false;

		/// <summary>
		/// t1511
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 업종현재가(t1511)
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

		public XQt1511() : base("t1511") { }


		public bool SetFields(XQt1511InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "upcode", 0, block.upcode); // char 3

			return true;
		}

		public XQt1511OutBlock GetBlock()
		{
			XQt1511OutBlock instance = XQt1511OutBlock.FromQuery(this);
			return instance;

		}


	}

}
