using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XRPM_InBlock : XingBlock
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
		/// 구분값
		/// </summary>
		[XAQueryFieldAttribute("구분값")]
		public char gubun;

		public static class F
		{
			/// <summary>
			/// 구분값
			/// </summary>
			public const string gubun = "gubun";
		}

		public static string[] AllFields = new string[]
		{
			F.gubun,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["gubun"] = new XAQueryFieldInfo("char", gubun, gubun.ToString(), "구분값", (decimal)1);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "gubun":
					this.gubun = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public bool VerifyData()
		{
			// gubun char 1

			return true;
		}
	}

	public partial class XRPM_OutBlock : XingBlock
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
		/// 수신시간
		/// </summary>
		[XAQueryFieldAttribute("수신시간")]
		public string time;
		/// <summary>
		/// 차익매도호가 잔량
		/// </summary>
		[XAQueryFieldAttribute("차익매도호가 잔량")]
		public long cdhrem;
		/// <summary>
		/// 차익매수호가 잔량
		/// </summary>
		[XAQueryFieldAttribute("차익매수호가 잔량")]
		public long cshrem;
		/// <summary>
		/// 비차익매도호가 잔량
		/// </summary>
		[XAQueryFieldAttribute("비차익매도호가 잔량")]
		public long bdhrem;
		/// <summary>
		/// 비차익매수호가 잔량
		/// </summary>
		[XAQueryFieldAttribute("비차익매수호가 잔량")]
		public long bshrem;
		/// <summary>
		/// 차익매도호가 수량
		/// </summary>
		[XAQueryFieldAttribute("차익매도호가 수량")]
		public long cdhvolume;
		/// <summary>
		/// 차익매수호가 수량
		/// </summary>
		[XAQueryFieldAttribute("차익매수호가 수량")]
		public long cshvolume;
		/// <summary>
		/// 비차익매도호가 수량
		/// </summary>
		[XAQueryFieldAttribute("비차익매도호가 수량")]
		public long bdhvolume;
		/// <summary>
		/// 비차익매수호가 수량
		/// </summary>
		[XAQueryFieldAttribute("비차익매수호가 수량")]
		public long bshvolume;
		/// <summary>
		/// 차익매도위탁체결수량
		/// </summary>
		[XAQueryFieldAttribute("차익매도위탁체결수량")]
		public long cdwvolume;
		/// <summary>
		/// 차익매도자기체결수량
		/// </summary>
		[XAQueryFieldAttribute("차익매도자기체결수량")]
		public long cdjvolume;
		/// <summary>
		/// 차익매수위탁체결수량
		/// </summary>
		[XAQueryFieldAttribute("차익매수위탁체결수량")]
		public long cswvolume;
		/// <summary>
		/// 차익매수자기체결수량
		/// </summary>
		[XAQueryFieldAttribute("차익매수자기체결수량")]
		public long csjvolume;
		/// <summary>
		/// 차익위탁순매수 수량
		/// </summary>
		[XAQueryFieldAttribute("차익위탁순매수 수량")]
		public long cwvol;
		/// <summary>
		/// 차익자기순매수 수량
		/// </summary>
		[XAQueryFieldAttribute("차익자기순매수 수량")]
		public long cjvol;
		/// <summary>
		/// 비차익매도위탁체결수량
		/// </summary>
		[XAQueryFieldAttribute("비차익매도위탁체결수량")]
		public long bdwvolume;
		/// <summary>
		/// 비차익매도자기체결수량
		/// </summary>
		[XAQueryFieldAttribute("비차익매도자기체결수량")]
		public long bdjvolume;
		/// <summary>
		/// 비차익매수위탁체결수량
		/// </summary>
		[XAQueryFieldAttribute("비차익매수위탁체결수량")]
		public long bswvolume;
		/// <summary>
		/// 비차익매수자기체결수량
		/// </summary>
		[XAQueryFieldAttribute("비차익매수자기체결수량")]
		public long bsjvolume;
		/// <summary>
		/// 비차익위탁순매수 수량
		/// </summary>
		[XAQueryFieldAttribute("비차익위탁순매수 수량")]
		public long bwvol;
		/// <summary>
		/// 비차익자기순매수 수량
		/// </summary>
		[XAQueryFieldAttribute("비차익자기순매수 수량")]
		public long bjvol;
		/// <summary>
		/// 전체매도위탁체결수량
		/// </summary>
		[XAQueryFieldAttribute("전체매도위탁체결수량")]
		public long dwvolume;
		/// <summary>
		/// 전체매수위탁체결수량
		/// </summary>
		[XAQueryFieldAttribute("전체매수위탁체결수량")]
		public long swvolume;
		/// <summary>
		/// 전체위탁순매수 수량
		/// </summary>
		[XAQueryFieldAttribute("전체위탁순매수 수량")]
		public long wvol;
		/// <summary>
		/// 전체매도자기체결수량
		/// </summary>
		[XAQueryFieldAttribute("전체매도자기체결수량")]
		public long djvolume;
		/// <summary>
		/// 전체매수자기체결수량
		/// </summary>
		[XAQueryFieldAttribute("전체매수자기체결수량")]
		public long sjvolume;
		/// <summary>
		/// 전체자기순매수 수량
		/// </summary>
		[XAQueryFieldAttribute("전체자기순매수 수량")]
		public long jvol;
		/// <summary>
		/// 차익매도위탁체결금액
		/// </summary>
		[XAQueryFieldAttribute("차익매도위탁체결금액")]
		public long cdwvalue;
		/// <summary>
		/// 차익매도자기체결금액
		/// </summary>
		[XAQueryFieldAttribute("차익매도자기체결금액")]
		public long cdjvalue;
		/// <summary>
		/// 차익매수위탁체결금액
		/// </summary>
		[XAQueryFieldAttribute("차익매수위탁체결금액")]
		public long cswvalue;
		/// <summary>
		/// 차익매수자기체결금액
		/// </summary>
		[XAQueryFieldAttribute("차익매수자기체결금액")]
		public long csjvalue;
		/// <summary>
		/// 차익위탁순매수 금액
		/// </summary>
		[XAQueryFieldAttribute("차익위탁순매수 금액")]
		public long cwval;
		/// <summary>
		/// 차익자기순매수 금액
		/// </summary>
		[XAQueryFieldAttribute("차익자기순매수 금액")]
		public long cjval;
		/// <summary>
		/// 비차익매도위탁체결금액
		/// </summary>
		[XAQueryFieldAttribute("비차익매도위탁체결금액")]
		public long bdwvalue;
		/// <summary>
		/// 비차익매도자기체결금액
		/// </summary>
		[XAQueryFieldAttribute("비차익매도자기체결금액")]
		public long bdjvalue;
		/// <summary>
		/// 비차익매수위탁체결금액
		/// </summary>
		[XAQueryFieldAttribute("비차익매수위탁체결금액")]
		public long bswvalue;
		/// <summary>
		/// 비차익매수자기체결금액
		/// </summary>
		[XAQueryFieldAttribute("비차익매수자기체결금액")]
		public long bsjvalue;
		/// <summary>
		/// 비차익위탁순매수 금액
		/// </summary>
		[XAQueryFieldAttribute("비차익위탁순매수 금액")]
		public long bwval;
		/// <summary>
		/// 비차익자기순매수 금액
		/// </summary>
		[XAQueryFieldAttribute("비차익자기순매수 금액")]
		public long bjval;
		/// <summary>
		/// 전체매도위탁체결금액
		/// </summary>
		[XAQueryFieldAttribute("전체매도위탁체결금액")]
		public long dwvalue;
		/// <summary>
		/// 전체매수위탁체결금액
		/// </summary>
		[XAQueryFieldAttribute("전체매수위탁체결금액")]
		public long swvalue;
		/// <summary>
		/// 전체위탁순매수 금액
		/// </summary>
		[XAQueryFieldAttribute("전체위탁순매수 금액")]
		public long wval;
		/// <summary>
		/// 전체매도자기체결금액
		/// </summary>
		[XAQueryFieldAttribute("전체매도자기체결금액")]
		public long djvalue;
		/// <summary>
		/// 전체매수자기체결금액
		/// </summary>
		[XAQueryFieldAttribute("전체매수자기체결금액")]
		public long sjvalue;
		/// <summary>
		/// 전체자기순매수 금액
		/// </summary>
		[XAQueryFieldAttribute("전체자기순매수 금액")]
		public long jval;
		/// <summary>
		/// KOSPI200 지수
		/// </summary>
		[XAQueryFieldAttribute("KOSPI200 지수")]
		public float k200jisu;
		/// <summary>
		/// KOSPI200 전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("KOSPI200 전일대비구분")]
		public char k200sign;
		/// <summary>
		/// KOSPI200 전일대비
		/// </summary>
		[XAQueryFieldAttribute("KOSPI200 전일대비")]
		public float change;
		/// <summary>
		/// KOSPI200 베이시스
		/// </summary>
		[XAQueryFieldAttribute("KOSPI200 베이시스")]
		public float k200basis;
		/// <summary>
		/// 차익매도체결수량합계
		/// </summary>
		[XAQueryFieldAttribute("차익매도체결수량합계")]
		public long cdvolume;
		/// <summary>
		/// 차익매수체결수량합계
		/// </summary>
		[XAQueryFieldAttribute("차익매수체결수량합계")]
		public long csvolume;
		/// <summary>
		/// 차익순매수 수량합계
		/// </summary>
		[XAQueryFieldAttribute("차익순매수 수량합계")]
		public long cvol;
		/// <summary>
		/// 비차익매도체결수량합계
		/// </summary>
		[XAQueryFieldAttribute("비차익매도체결수량합계")]
		public long bdvolume;
		/// <summary>
		/// 비차익매수체결수량합계
		/// </summary>
		[XAQueryFieldAttribute("비차익매수체결수량합계")]
		public long bsvolume;
		/// <summary>
		/// 비차익순매수 수량합계
		/// </summary>
		[XAQueryFieldAttribute("비차익순매수 수량합계")]
		public long bvol;
		/// <summary>
		/// 전체매도체결수량합계
		/// </summary>
		[XAQueryFieldAttribute("전체매도체결수량합계")]
		public long tdvolume;
		/// <summary>
		/// 전체매수체결수량합계
		/// </summary>
		[XAQueryFieldAttribute("전체매수체결수량합계")]
		public long tsvolume;
		/// <summary>
		/// 전체순매수 수량합계
		/// </summary>
		[XAQueryFieldAttribute("전체순매수 수량합계")]
		public long tvol;
		/// <summary>
		/// 차익매도체결금액합계
		/// </summary>
		[XAQueryFieldAttribute("차익매도체결금액합계")]
		public long cdvalue;
		/// <summary>
		/// 차익매수체결금액합계
		/// </summary>
		[XAQueryFieldAttribute("차익매수체결금액합계")]
		public long csvalue;
		/// <summary>
		/// 차익순매수 금액합계
		/// </summary>
		[XAQueryFieldAttribute("차익순매수 금액합계")]
		public long cval;
		/// <summary>
		/// 비차익매도체결금액합계
		/// </summary>
		[XAQueryFieldAttribute("비차익매도체결금액합계")]
		public long bdvalue;
		/// <summary>
		/// 비차익매수체결금액합계
		/// </summary>
		[XAQueryFieldAttribute("비차익매수체결금액합계")]
		public long bsvalue;
		/// <summary>
		/// 비차익순매수 금액합계
		/// </summary>
		[XAQueryFieldAttribute("비차익순매수 금액합계")]
		public long bval;
		/// <summary>
		/// 전체매도체결금액합계
		/// </summary>
		[XAQueryFieldAttribute("전체매도체결금액합계")]
		public long tdvalue;
		/// <summary>
		/// 전체매수체결금액합계
		/// </summary>
		[XAQueryFieldAttribute("전체매수체결금액합계")]
		public long tsvalue;
		/// <summary>
		/// 전체순매수 금액합계
		/// </summary>
		[XAQueryFieldAttribute("전체순매수 금액합계")]
		public long tval;
		/// <summary>
		/// 차익매도체결수량직전대비
		/// </summary>
		[XAQueryFieldAttribute("차익매도체결수량직전대비")]
		public long p_cdvolcha;
		/// <summary>
		/// 차익매수체결수량직전대비
		/// </summary>
		[XAQueryFieldAttribute("차익매수체결수량직전대비")]
		public long p_csvolcha;
		/// <summary>
		/// 차익순매수 수량직전대비
		/// </summary>
		[XAQueryFieldAttribute("차익순매수 수량직전대비")]
		public long p_cvolcha;
		/// <summary>
		/// 비차익매도체결수량직전대비
		/// </summary>
		[XAQueryFieldAttribute("비차익매도체결수량직전대비")]
		public long p_bdvolcha;
		/// <summary>
		/// 비차익매수체결수량직전대비
		/// </summary>
		[XAQueryFieldAttribute("비차익매수체결수량직전대비")]
		public long p_bsvolcha;
		/// <summary>
		/// 비차익순매수 수량직전대비
		/// </summary>
		[XAQueryFieldAttribute("비차익순매수 수량직전대비")]
		public long p_bvolcha;
		/// <summary>
		/// 전체매도체결수량직전대비
		/// </summary>
		[XAQueryFieldAttribute("전체매도체결수량직전대비")]
		public long p_tdvolcha;
		/// <summary>
		/// 전체매수체결수량직전대비
		/// </summary>
		[XAQueryFieldAttribute("전체매수체결수량직전대비")]
		public long p_tsvolcha;
		/// <summary>
		/// 전체순매수 수량직전대비
		/// </summary>
		[XAQueryFieldAttribute("전체순매수 수량직전대비")]
		public long p_tvolcha;
		/// <summary>
		/// 차익매도체결금액직전대비
		/// </summary>
		[XAQueryFieldAttribute("차익매도체결금액직전대비")]
		public long p_cdvalcha;
		/// <summary>
		/// 차익매수체결금액직전대비
		/// </summary>
		[XAQueryFieldAttribute("차익매수체결금액직전대비")]
		public long p_csvalcha;
		/// <summary>
		/// 차익순매수 금액직전대비
		/// </summary>
		[XAQueryFieldAttribute("차익순매수 금액직전대비")]
		public long p_cvalcha;
		/// <summary>
		/// 비차익매도체결금액직전대비
		/// </summary>
		[XAQueryFieldAttribute("비차익매도체결금액직전대비")]
		public long p_bdvalcha;
		/// <summary>
		/// 비차익매수체결금액직전대비
		/// </summary>
		[XAQueryFieldAttribute("비차익매수체결금액직전대비")]
		public long p_bsvalcha;
		/// <summary>
		/// 비차익순매수 금액직전대비
		/// </summary>
		[XAQueryFieldAttribute("비차익순매수 금액직전대비")]
		public long p_bvalcha;
		/// <summary>
		/// 전체매도체결금액직전대비
		/// </summary>
		[XAQueryFieldAttribute("전체매도체결금액직전대비")]
		public long p_tdvalcha;
		/// <summary>
		/// 전체매수체결금액직전대비
		/// </summary>
		[XAQueryFieldAttribute("전체매수체결금액직전대비")]
		public long p_tsvalcha;
		/// <summary>
		/// 전체순매수 금액직전대비
		/// </summary>
		[XAQueryFieldAttribute("전체순매수 금액직전대비")]
		public long p_tvalcha;
		/// <summary>
		/// 구분값
		/// </summary>
		[XAQueryFieldAttribute("구분값")]
		public char gubun;

		public static class F
		{
			/// <summary>
			/// 수신시간
			/// </summary>
			public const string time = "time";
			/// <summary>
			/// 차익매도호가 잔량
			/// </summary>
			public const string cdhrem = "cdhrem";
			/// <summary>
			/// 차익매수호가 잔량
			/// </summary>
			public const string cshrem = "cshrem";
			/// <summary>
			/// 비차익매도호가 잔량
			/// </summary>
			public const string bdhrem = "bdhrem";
			/// <summary>
			/// 비차익매수호가 잔량
			/// </summary>
			public const string bshrem = "bshrem";
			/// <summary>
			/// 차익매도호가 수량
			/// </summary>
			public const string cdhvolume = "cdhvolume";
			/// <summary>
			/// 차익매수호가 수량
			/// </summary>
			public const string cshvolume = "cshvolume";
			/// <summary>
			/// 비차익매도호가 수량
			/// </summary>
			public const string bdhvolume = "bdhvolume";
			/// <summary>
			/// 비차익매수호가 수량
			/// </summary>
			public const string bshvolume = "bshvolume";
			/// <summary>
			/// 차익매도위탁체결수량
			/// </summary>
			public const string cdwvolume = "cdwvolume";
			/// <summary>
			/// 차익매도자기체결수량
			/// </summary>
			public const string cdjvolume = "cdjvolume";
			/// <summary>
			/// 차익매수위탁체결수량
			/// </summary>
			public const string cswvolume = "cswvolume";
			/// <summary>
			/// 차익매수자기체결수량
			/// </summary>
			public const string csjvolume = "csjvolume";
			/// <summary>
			/// 차익위탁순매수 수량
			/// </summary>
			public const string cwvol = "cwvol";
			/// <summary>
			/// 차익자기순매수 수량
			/// </summary>
			public const string cjvol = "cjvol";
			/// <summary>
			/// 비차익매도위탁체결수량
			/// </summary>
			public const string bdwvolume = "bdwvolume";
			/// <summary>
			/// 비차익매도자기체결수량
			/// </summary>
			public const string bdjvolume = "bdjvolume";
			/// <summary>
			/// 비차익매수위탁체결수량
			/// </summary>
			public const string bswvolume = "bswvolume";
			/// <summary>
			/// 비차익매수자기체결수량
			/// </summary>
			public const string bsjvolume = "bsjvolume";
			/// <summary>
			/// 비차익위탁순매수 수량
			/// </summary>
			public const string bwvol = "bwvol";
			/// <summary>
			/// 비차익자기순매수 수량
			/// </summary>
			public const string bjvol = "bjvol";
			/// <summary>
			/// 전체매도위탁체결수량
			/// </summary>
			public const string dwvolume = "dwvolume";
			/// <summary>
			/// 전체매수위탁체결수량
			/// </summary>
			public const string swvolume = "swvolume";
			/// <summary>
			/// 전체위탁순매수 수량
			/// </summary>
			public const string wvol = "wvol";
			/// <summary>
			/// 전체매도자기체결수량
			/// </summary>
			public const string djvolume = "djvolume";
			/// <summary>
			/// 전체매수자기체결수량
			/// </summary>
			public const string sjvolume = "sjvolume";
			/// <summary>
			/// 전체자기순매수 수량
			/// </summary>
			public const string jvol = "jvol";
			/// <summary>
			/// 차익매도위탁체결금액
			/// </summary>
			public const string cdwvalue = "cdwvalue";
			/// <summary>
			/// 차익매도자기체결금액
			/// </summary>
			public const string cdjvalue = "cdjvalue";
			/// <summary>
			/// 차익매수위탁체결금액
			/// </summary>
			public const string cswvalue = "cswvalue";
			/// <summary>
			/// 차익매수자기체결금액
			/// </summary>
			public const string csjvalue = "csjvalue";
			/// <summary>
			/// 차익위탁순매수 금액
			/// </summary>
			public const string cwval = "cwval";
			/// <summary>
			/// 차익자기순매수 금액
			/// </summary>
			public const string cjval = "cjval";
			/// <summary>
			/// 비차익매도위탁체결금액
			/// </summary>
			public const string bdwvalue = "bdwvalue";
			/// <summary>
			/// 비차익매도자기체결금액
			/// </summary>
			public const string bdjvalue = "bdjvalue";
			/// <summary>
			/// 비차익매수위탁체결금액
			/// </summary>
			public const string bswvalue = "bswvalue";
			/// <summary>
			/// 비차익매수자기체결금액
			/// </summary>
			public const string bsjvalue = "bsjvalue";
			/// <summary>
			/// 비차익위탁순매수 금액
			/// </summary>
			public const string bwval = "bwval";
			/// <summary>
			/// 비차익자기순매수 금액
			/// </summary>
			public const string bjval = "bjval";
			/// <summary>
			/// 전체매도위탁체결금액
			/// </summary>
			public const string dwvalue = "dwvalue";
			/// <summary>
			/// 전체매수위탁체결금액
			/// </summary>
			public const string swvalue = "swvalue";
			/// <summary>
			/// 전체위탁순매수 금액
			/// </summary>
			public const string wval = "wval";
			/// <summary>
			/// 전체매도자기체결금액
			/// </summary>
			public const string djvalue = "djvalue";
			/// <summary>
			/// 전체매수자기체결금액
			/// </summary>
			public const string sjvalue = "sjvalue";
			/// <summary>
			/// 전체자기순매수 금액
			/// </summary>
			public const string jval = "jval";
			/// <summary>
			/// KOSPI200 지수
			/// </summary>
			public const string k200jisu = "k200jisu";
			/// <summary>
			/// KOSPI200 전일대비구분
			/// </summary>
			public const string k200sign = "k200sign";
			/// <summary>
			/// KOSPI200 전일대비
			/// </summary>
			public const string change = "change";
			/// <summary>
			/// KOSPI200 베이시스
			/// </summary>
			public const string k200basis = "k200basis";
			/// <summary>
			/// 차익매도체결수량합계
			/// </summary>
			public const string cdvolume = "cdvolume";
			/// <summary>
			/// 차익매수체결수량합계
			/// </summary>
			public const string csvolume = "csvolume";
			/// <summary>
			/// 차익순매수 수량합계
			/// </summary>
			public const string cvol = "cvol";
			/// <summary>
			/// 비차익매도체결수량합계
			/// </summary>
			public const string bdvolume = "bdvolume";
			/// <summary>
			/// 비차익매수체결수량합계
			/// </summary>
			public const string bsvolume = "bsvolume";
			/// <summary>
			/// 비차익순매수 수량합계
			/// </summary>
			public const string bvol = "bvol";
			/// <summary>
			/// 전체매도체결수량합계
			/// </summary>
			public const string tdvolume = "tdvolume";
			/// <summary>
			/// 전체매수체결수량합계
			/// </summary>
			public const string tsvolume = "tsvolume";
			/// <summary>
			/// 전체순매수 수량합계
			/// </summary>
			public const string tvol = "tvol";
			/// <summary>
			/// 차익매도체결금액합계
			/// </summary>
			public const string cdvalue = "cdvalue";
			/// <summary>
			/// 차익매수체결금액합계
			/// </summary>
			public const string csvalue = "csvalue";
			/// <summary>
			/// 차익순매수 금액합계
			/// </summary>
			public const string cval = "cval";
			/// <summary>
			/// 비차익매도체결금액합계
			/// </summary>
			public const string bdvalue = "bdvalue";
			/// <summary>
			/// 비차익매수체결금액합계
			/// </summary>
			public const string bsvalue = "bsvalue";
			/// <summary>
			/// 비차익순매수 금액합계
			/// </summary>
			public const string bval = "bval";
			/// <summary>
			/// 전체매도체결금액합계
			/// </summary>
			public const string tdvalue = "tdvalue";
			/// <summary>
			/// 전체매수체결금액합계
			/// </summary>
			public const string tsvalue = "tsvalue";
			/// <summary>
			/// 전체순매수 금액합계
			/// </summary>
			public const string tval = "tval";
			/// <summary>
			/// 차익매도체결수량직전대비
			/// </summary>
			public const string p_cdvolcha = "p_cdvolcha";
			/// <summary>
			/// 차익매수체결수량직전대비
			/// </summary>
			public const string p_csvolcha = "p_csvolcha";
			/// <summary>
			/// 차익순매수 수량직전대비
			/// </summary>
			public const string p_cvolcha = "p_cvolcha";
			/// <summary>
			/// 비차익매도체결수량직전대비
			/// </summary>
			public const string p_bdvolcha = "p_bdvolcha";
			/// <summary>
			/// 비차익매수체결수량직전대비
			/// </summary>
			public const string p_bsvolcha = "p_bsvolcha";
			/// <summary>
			/// 비차익순매수 수량직전대비
			/// </summary>
			public const string p_bvolcha = "p_bvolcha";
			/// <summary>
			/// 전체매도체결수량직전대비
			/// </summary>
			public const string p_tdvolcha = "p_tdvolcha";
			/// <summary>
			/// 전체매수체결수량직전대비
			/// </summary>
			public const string p_tsvolcha = "p_tsvolcha";
			/// <summary>
			/// 전체순매수 수량직전대비
			/// </summary>
			public const string p_tvolcha = "p_tvolcha";
			/// <summary>
			/// 차익매도체결금액직전대비
			/// </summary>
			public const string p_cdvalcha = "p_cdvalcha";
			/// <summary>
			/// 차익매수체결금액직전대비
			/// </summary>
			public const string p_csvalcha = "p_csvalcha";
			/// <summary>
			/// 차익순매수 금액직전대비
			/// </summary>
			public const string p_cvalcha = "p_cvalcha";
			/// <summary>
			/// 비차익매도체결금액직전대비
			/// </summary>
			public const string p_bdvalcha = "p_bdvalcha";
			/// <summary>
			/// 비차익매수체결금액직전대비
			/// </summary>
			public const string p_bsvalcha = "p_bsvalcha";
			/// <summary>
			/// 비차익순매수 금액직전대비
			/// </summary>
			public const string p_bvalcha = "p_bvalcha";
			/// <summary>
			/// 전체매도체결금액직전대비
			/// </summary>
			public const string p_tdvalcha = "p_tdvalcha";
			/// <summary>
			/// 전체매수체결금액직전대비
			/// </summary>
			public const string p_tsvalcha = "p_tsvalcha";
			/// <summary>
			/// 전체순매수 금액직전대비
			/// </summary>
			public const string p_tvalcha = "p_tvalcha";
			/// <summary>
			/// 구분값
			/// </summary>
			public const string gubun = "gubun";
		}

		public static string[] AllFields = new string[]
		{
			F.time,
			F.cdhrem,
			F.cshrem,
			F.bdhrem,
			F.bshrem,
			F.cdhvolume,
			F.cshvolume,
			F.bdhvolume,
			F.bshvolume,
			F.cdwvolume,
			F.cdjvolume,
			F.cswvolume,
			F.csjvolume,
			F.cwvol,
			F.cjvol,
			F.bdwvolume,
			F.bdjvolume,
			F.bswvolume,
			F.bsjvolume,
			F.bwvol,
			F.bjvol,
			F.dwvolume,
			F.swvolume,
			F.wvol,
			F.djvolume,
			F.sjvolume,
			F.jvol,
			F.cdwvalue,
			F.cdjvalue,
			F.cswvalue,
			F.csjvalue,
			F.cwval,
			F.cjval,
			F.bdwvalue,
			F.bdjvalue,
			F.bswvalue,
			F.bsjvalue,
			F.bwval,
			F.bjval,
			F.dwvalue,
			F.swvalue,
			F.wval,
			F.djvalue,
			F.sjvalue,
			F.jval,
			F.k200jisu,
			F.k200sign,
			F.change,
			F.k200basis,
			F.cdvolume,
			F.csvolume,
			F.cvol,
			F.bdvolume,
			F.bsvolume,
			F.bvol,
			F.tdvolume,
			F.tsvolume,
			F.tvol,
			F.cdvalue,
			F.csvalue,
			F.cval,
			F.bdvalue,
			F.bsvalue,
			F.bval,
			F.tdvalue,
			F.tsvalue,
			F.tval,
			F.p_cdvolcha,
			F.p_csvolcha,
			F.p_cvolcha,
			F.p_bdvolcha,
			F.p_bsvolcha,
			F.p_bvolcha,
			F.p_tdvolcha,
			F.p_tsvolcha,
			F.p_tvolcha,
			F.p_cdvalcha,
			F.p_csvalcha,
			F.p_cvalcha,
			F.p_bdvalcha,
			F.p_bsvalcha,
			F.p_bvalcha,
			F.p_tdvalcha,
			F.p_tsvalcha,
			F.p_tvalcha,
			F.gubun,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["time"] = new XAQueryFieldInfo("char", time, time, "수신시간", (decimal)6);
			dict["cdhrem"] = new XAQueryFieldInfo("long", cdhrem, cdhrem.ToString("d6"), "차익매도호가 잔량", (decimal)6);
			dict["cshrem"] = new XAQueryFieldInfo("long", cshrem, cshrem.ToString("d6"), "차익매수호가 잔량", (decimal)6);
			dict["bdhrem"] = new XAQueryFieldInfo("long", bdhrem, bdhrem.ToString("d6"), "비차익매도호가 잔량", (decimal)6);
			dict["bshrem"] = new XAQueryFieldInfo("long", bshrem, bshrem.ToString("d6"), "비차익매수호가 잔량", (decimal)6);
			dict["cdhvolume"] = new XAQueryFieldInfo("long", cdhvolume, cdhvolume.ToString("d6"), "차익매도호가 수량", (decimal)6);
			dict["cshvolume"] = new XAQueryFieldInfo("long", cshvolume, cshvolume.ToString("d6"), "차익매수호가 수량", (decimal)6);
			dict["bdhvolume"] = new XAQueryFieldInfo("long", bdhvolume, bdhvolume.ToString("d6"), "비차익매도호가 수량", (decimal)6);
			dict["bshvolume"] = new XAQueryFieldInfo("long", bshvolume, bshvolume.ToString("d6"), "비차익매수호가 수량", (decimal)6);
			dict["cdwvolume"] = new XAQueryFieldInfo("long", cdwvolume, cdwvolume.ToString("d6"), "차익매도위탁체결수량", (decimal)6);
			dict["cdjvolume"] = new XAQueryFieldInfo("long", cdjvolume, cdjvolume.ToString("d6"), "차익매도자기체결수량", (decimal)6);
			dict["cswvolume"] = new XAQueryFieldInfo("long", cswvolume, cswvolume.ToString("d6"), "차익매수위탁체결수량", (decimal)6);
			dict["csjvolume"] = new XAQueryFieldInfo("long", csjvolume, csjvolume.ToString("d6"), "차익매수자기체결수량", (decimal)6);
			dict["cwvol"] = new XAQueryFieldInfo("long", cwvol, cwvol.ToString("d6"), "차익위탁순매수 수량", (decimal)6);
			dict["cjvol"] = new XAQueryFieldInfo("long", cjvol, cjvol.ToString("d6"), "차익자기순매수 수량", (decimal)6);
			dict["bdwvolume"] = new XAQueryFieldInfo("long", bdwvolume, bdwvolume.ToString("d6"), "비차익매도위탁체결수량", (decimal)6);
			dict["bdjvolume"] = new XAQueryFieldInfo("long", bdjvolume, bdjvolume.ToString("d6"), "비차익매도자기체결수량", (decimal)6);
			dict["bswvolume"] = new XAQueryFieldInfo("long", bswvolume, bswvolume.ToString("d6"), "비차익매수위탁체결수량", (decimal)6);
			dict["bsjvolume"] = new XAQueryFieldInfo("long", bsjvolume, bsjvolume.ToString("d6"), "비차익매수자기체결수량", (decimal)6);
			dict["bwvol"] = new XAQueryFieldInfo("long", bwvol, bwvol.ToString("d6"), "비차익위탁순매수 수량", (decimal)6);
			dict["bjvol"] = new XAQueryFieldInfo("long", bjvol, bjvol.ToString("d6"), "비차익자기순매수 수량", (decimal)6);
			dict["dwvolume"] = new XAQueryFieldInfo("long", dwvolume, dwvolume.ToString("d6"), "전체매도위탁체결수량", (decimal)6);
			dict["swvolume"] = new XAQueryFieldInfo("long", swvolume, swvolume.ToString("d6"), "전체매수위탁체결수량", (decimal)6);
			dict["wvol"] = new XAQueryFieldInfo("long", wvol, wvol.ToString("d6"), "전체위탁순매수 수량", (decimal)6);
			dict["djvolume"] = new XAQueryFieldInfo("long", djvolume, djvolume.ToString("d6"), "전체매도자기체결수량", (decimal)6);
			dict["sjvolume"] = new XAQueryFieldInfo("long", sjvolume, sjvolume.ToString("d6"), "전체매수자기체결수량", (decimal)6);
			dict["jvol"] = new XAQueryFieldInfo("long", jvol, jvol.ToString("d6"), "전체자기순매수 수량", (decimal)6);
			dict["cdwvalue"] = new XAQueryFieldInfo("long", cdwvalue, cdwvalue.ToString("d8"), "차익매도위탁체결금액", (decimal)8);
			dict["cdjvalue"] = new XAQueryFieldInfo("long", cdjvalue, cdjvalue.ToString("d8"), "차익매도자기체결금액", (decimal)8);
			dict["cswvalue"] = new XAQueryFieldInfo("long", cswvalue, cswvalue.ToString("d8"), "차익매수위탁체결금액", (decimal)8);
			dict["csjvalue"] = new XAQueryFieldInfo("long", csjvalue, csjvalue.ToString("d8"), "차익매수자기체결금액", (decimal)8);
			dict["cwval"] = new XAQueryFieldInfo("long", cwval, cwval.ToString("d8"), "차익위탁순매수 금액", (decimal)8);
			dict["cjval"] = new XAQueryFieldInfo("long", cjval, cjval.ToString("d8"), "차익자기순매수 금액", (decimal)8);
			dict["bdwvalue"] = new XAQueryFieldInfo("long", bdwvalue, bdwvalue.ToString("d8"), "비차익매도위탁체결금액", (decimal)8);
			dict["bdjvalue"] = new XAQueryFieldInfo("long", bdjvalue, bdjvalue.ToString("d8"), "비차익매도자기체결금액", (decimal)8);
			dict["bswvalue"] = new XAQueryFieldInfo("long", bswvalue, bswvalue.ToString("d8"), "비차익매수위탁체결금액", (decimal)8);
			dict["bsjvalue"] = new XAQueryFieldInfo("long", bsjvalue, bsjvalue.ToString("d8"), "비차익매수자기체결금액", (decimal)8);
			dict["bwval"] = new XAQueryFieldInfo("long", bwval, bwval.ToString("d8"), "비차익위탁순매수 금액", (decimal)8);
			dict["bjval"] = new XAQueryFieldInfo("long", bjval, bjval.ToString("d8"), "비차익자기순매수 금액", (decimal)8);
			dict["dwvalue"] = new XAQueryFieldInfo("long", dwvalue, dwvalue.ToString("d8"), "전체매도위탁체결금액", (decimal)8);
			dict["swvalue"] = new XAQueryFieldInfo("long", swvalue, swvalue.ToString("d8"), "전체매수위탁체결금액", (decimal)8);
			dict["wval"] = new XAQueryFieldInfo("long", wval, wval.ToString("d8"), "전체위탁순매수 금액", (decimal)8);
			dict["djvalue"] = new XAQueryFieldInfo("long", djvalue, djvalue.ToString("d8"), "전체매도자기체결금액", (decimal)8);
			dict["sjvalue"] = new XAQueryFieldInfo("long", sjvalue, sjvalue.ToString("d8"), "전체매수자기체결금액", (decimal)8);
			dict["jval"] = new XAQueryFieldInfo("long", jval, jval.ToString("d8"), "전체자기순매수 금액", (decimal)8);
			dict["k200jisu"] = new XAQueryFieldInfo("float", k200jisu, k200jisu.ToString("000000.00"), "KOSPI200 지수", (decimal)6.2);
			dict["k200sign"] = new XAQueryFieldInfo("char", k200sign, k200sign.ToString(), "KOSPI200 전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("float", change, change.ToString("000000.00"), "KOSPI200 전일대비", (decimal)6.2);
			dict["k200basis"] = new XAQueryFieldInfo("float", k200basis, k200basis.ToString("0000.00"), "KOSPI200 베이시스", (decimal)4.2);
			dict["cdvolume"] = new XAQueryFieldInfo("long", cdvolume, cdvolume.ToString("d6"), "차익매도체결수량합계", (decimal)6);
			dict["csvolume"] = new XAQueryFieldInfo("long", csvolume, csvolume.ToString("d6"), "차익매수체결수량합계", (decimal)6);
			dict["cvol"] = new XAQueryFieldInfo("long", cvol, cvol.ToString("d6"), "차익순매수 수량합계", (decimal)6);
			dict["bdvolume"] = new XAQueryFieldInfo("long", bdvolume, bdvolume.ToString("d6"), "비차익매도체결수량합계", (decimal)6);
			dict["bsvolume"] = new XAQueryFieldInfo("long", bsvolume, bsvolume.ToString("d6"), "비차익매수체결수량합계", (decimal)6);
			dict["bvol"] = new XAQueryFieldInfo("long", bvol, bvol.ToString("d6"), "비차익순매수 수량합계", (decimal)6);
			dict["tdvolume"] = new XAQueryFieldInfo("long", tdvolume, tdvolume.ToString("d6"), "전체매도체결수량합계", (decimal)6);
			dict["tsvolume"] = new XAQueryFieldInfo("long", tsvolume, tsvolume.ToString("d6"), "전체매수체결수량합계", (decimal)6);
			dict["tvol"] = new XAQueryFieldInfo("long", tvol, tvol.ToString("d6"), "전체순매수 수량합계", (decimal)6);
			dict["cdvalue"] = new XAQueryFieldInfo("long", cdvalue, cdvalue.ToString("d8"), "차익매도체결금액합계", (decimal)8);
			dict["csvalue"] = new XAQueryFieldInfo("long", csvalue, csvalue.ToString("d8"), "차익매수체결금액합계", (decimal)8);
			dict["cval"] = new XAQueryFieldInfo("long", cval, cval.ToString("d8"), "차익순매수 금액합계", (decimal)8);
			dict["bdvalue"] = new XAQueryFieldInfo("long", bdvalue, bdvalue.ToString("d8"), "비차익매도체결금액합계", (decimal)8);
			dict["bsvalue"] = new XAQueryFieldInfo("long", bsvalue, bsvalue.ToString("d8"), "비차익매수체결금액합계", (decimal)8);
			dict["bval"] = new XAQueryFieldInfo("long", bval, bval.ToString("d8"), "비차익순매수 금액합계", (decimal)8);
			dict["tdvalue"] = new XAQueryFieldInfo("long", tdvalue, tdvalue.ToString("d8"), "전체매도체결금액합계", (decimal)8);
			dict["tsvalue"] = new XAQueryFieldInfo("long", tsvalue, tsvalue.ToString("d8"), "전체매수체결금액합계", (decimal)8);
			dict["tval"] = new XAQueryFieldInfo("long", tval, tval.ToString("d8"), "전체순매수 금액합계", (decimal)8);
			dict["p_cdvolcha"] = new XAQueryFieldInfo("long", p_cdvolcha, p_cdvolcha.ToString("d6"), "차익매도체결수량직전대비", (decimal)6);
			dict["p_csvolcha"] = new XAQueryFieldInfo("long", p_csvolcha, p_csvolcha.ToString("d6"), "차익매수체결수량직전대비", (decimal)6);
			dict["p_cvolcha"] = new XAQueryFieldInfo("long", p_cvolcha, p_cvolcha.ToString("d6"), "차익순매수 수량직전대비", (decimal)6);
			dict["p_bdvolcha"] = new XAQueryFieldInfo("long", p_bdvolcha, p_bdvolcha.ToString("d6"), "비차익매도체결수량직전대비", (decimal)6);
			dict["p_bsvolcha"] = new XAQueryFieldInfo("long", p_bsvolcha, p_bsvolcha.ToString("d6"), "비차익매수체결수량직전대비", (decimal)6);
			dict["p_bvolcha"] = new XAQueryFieldInfo("long", p_bvolcha, p_bvolcha.ToString("d6"), "비차익순매수 수량직전대비", (decimal)6);
			dict["p_tdvolcha"] = new XAQueryFieldInfo("long", p_tdvolcha, p_tdvolcha.ToString("d6"), "전체매도체결수량직전대비", (decimal)6);
			dict["p_tsvolcha"] = new XAQueryFieldInfo("long", p_tsvolcha, p_tsvolcha.ToString("d6"), "전체매수체결수량직전대비", (decimal)6);
			dict["p_tvolcha"] = new XAQueryFieldInfo("long", p_tvolcha, p_tvolcha.ToString("d6"), "전체순매수 수량직전대비", (decimal)6);
			dict["p_cdvalcha"] = new XAQueryFieldInfo("long", p_cdvalcha, p_cdvalcha.ToString("d8"), "차익매도체결금액직전대비", (decimal)8);
			dict["p_csvalcha"] = new XAQueryFieldInfo("long", p_csvalcha, p_csvalcha.ToString("d8"), "차익매수체결금액직전대비", (decimal)8);
			dict["p_cvalcha"] = new XAQueryFieldInfo("long", p_cvalcha, p_cvalcha.ToString("d8"), "차익순매수 금액직전대비", (decimal)8);
			dict["p_bdvalcha"] = new XAQueryFieldInfo("long", p_bdvalcha, p_bdvalcha.ToString("d8"), "비차익매도체결금액직전대비", (decimal)8);
			dict["p_bsvalcha"] = new XAQueryFieldInfo("long", p_bsvalcha, p_bsvalcha.ToString("d8"), "비차익매수체결금액직전대비", (decimal)8);
			dict["p_bvalcha"] = new XAQueryFieldInfo("long", p_bvalcha, p_bvalcha.ToString("d8"), "비차익순매수 금액직전대비", (decimal)8);
			dict["p_tdvalcha"] = new XAQueryFieldInfo("long", p_tdvalcha, p_tdvalcha.ToString("d8"), "전체매도체결금액직전대비", (decimal)8);
			dict["p_tsvalcha"] = new XAQueryFieldInfo("long", p_tsvalcha, p_tsvalcha.ToString("d8"), "전체매수체결금액직전대비", (decimal)8);
			dict["p_tvalcha"] = new XAQueryFieldInfo("long", p_tvalcha, p_tvalcha.ToString("d8"), "전체순매수 금액직전대비", (decimal)8);
			dict["gubun"] = new XAQueryFieldInfo("char", gubun, gubun.ToString(), "구분값", (decimal)1);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "time":
					this.time = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cdhrem":
					this.cdhrem = fieldInfo.FieldValue.ParseLong("cdhrem");
				break;

				case "cshrem":
					this.cshrem = fieldInfo.FieldValue.ParseLong("cshrem");
				break;

				case "bdhrem":
					this.bdhrem = fieldInfo.FieldValue.ParseLong("bdhrem");
				break;

				case "bshrem":
					this.bshrem = fieldInfo.FieldValue.ParseLong("bshrem");
				break;

				case "cdhvolume":
					this.cdhvolume = fieldInfo.FieldValue.ParseLong("cdhvolume");
				break;

				case "cshvolume":
					this.cshvolume = fieldInfo.FieldValue.ParseLong("cshvolume");
				break;

				case "bdhvolume":
					this.bdhvolume = fieldInfo.FieldValue.ParseLong("bdhvolume");
				break;

				case "bshvolume":
					this.bshvolume = fieldInfo.FieldValue.ParseLong("bshvolume");
				break;

				case "cdwvolume":
					this.cdwvolume = fieldInfo.FieldValue.ParseLong("cdwvolume");
				break;

				case "cdjvolume":
					this.cdjvolume = fieldInfo.FieldValue.ParseLong("cdjvolume");
				break;

				case "cswvolume":
					this.cswvolume = fieldInfo.FieldValue.ParseLong("cswvolume");
				break;

				case "csjvolume":
					this.csjvolume = fieldInfo.FieldValue.ParseLong("csjvolume");
				break;

				case "cwvol":
					this.cwvol = fieldInfo.FieldValue.ParseLong("cwvol");
				break;

				case "cjvol":
					this.cjvol = fieldInfo.FieldValue.ParseLong("cjvol");
				break;

				case "bdwvolume":
					this.bdwvolume = fieldInfo.FieldValue.ParseLong("bdwvolume");
				break;

				case "bdjvolume":
					this.bdjvolume = fieldInfo.FieldValue.ParseLong("bdjvolume");
				break;

				case "bswvolume":
					this.bswvolume = fieldInfo.FieldValue.ParseLong("bswvolume");
				break;

				case "bsjvolume":
					this.bsjvolume = fieldInfo.FieldValue.ParseLong("bsjvolume");
				break;

				case "bwvol":
					this.bwvol = fieldInfo.FieldValue.ParseLong("bwvol");
				break;

				case "bjvol":
					this.bjvol = fieldInfo.FieldValue.ParseLong("bjvol");
				break;

				case "dwvolume":
					this.dwvolume = fieldInfo.FieldValue.ParseLong("dwvolume");
				break;

				case "swvolume":
					this.swvolume = fieldInfo.FieldValue.ParseLong("swvolume");
				break;

				case "wvol":
					this.wvol = fieldInfo.FieldValue.ParseLong("wvol");
				break;

				case "djvolume":
					this.djvolume = fieldInfo.FieldValue.ParseLong("djvolume");
				break;

				case "sjvolume":
					this.sjvolume = fieldInfo.FieldValue.ParseLong("sjvolume");
				break;

				case "jvol":
					this.jvol = fieldInfo.FieldValue.ParseLong("jvol");
				break;

				case "cdwvalue":
					this.cdwvalue = fieldInfo.FieldValue.ParseLong("cdwvalue");
				break;

				case "cdjvalue":
					this.cdjvalue = fieldInfo.FieldValue.ParseLong("cdjvalue");
				break;

				case "cswvalue":
					this.cswvalue = fieldInfo.FieldValue.ParseLong("cswvalue");
				break;

				case "csjvalue":
					this.csjvalue = fieldInfo.FieldValue.ParseLong("csjvalue");
				break;

				case "cwval":
					this.cwval = fieldInfo.FieldValue.ParseLong("cwval");
				break;

				case "cjval":
					this.cjval = fieldInfo.FieldValue.ParseLong("cjval");
				break;

				case "bdwvalue":
					this.bdwvalue = fieldInfo.FieldValue.ParseLong("bdwvalue");
				break;

				case "bdjvalue":
					this.bdjvalue = fieldInfo.FieldValue.ParseLong("bdjvalue");
				break;

				case "bswvalue":
					this.bswvalue = fieldInfo.FieldValue.ParseLong("bswvalue");
				break;

				case "bsjvalue":
					this.bsjvalue = fieldInfo.FieldValue.ParseLong("bsjvalue");
				break;

				case "bwval":
					this.bwval = fieldInfo.FieldValue.ParseLong("bwval");
				break;

				case "bjval":
					this.bjval = fieldInfo.FieldValue.ParseLong("bjval");
				break;

				case "dwvalue":
					this.dwvalue = fieldInfo.FieldValue.ParseLong("dwvalue");
				break;

				case "swvalue":
					this.swvalue = fieldInfo.FieldValue.ParseLong("swvalue");
				break;

				case "wval":
					this.wval = fieldInfo.FieldValue.ParseLong("wval");
				break;

				case "djvalue":
					this.djvalue = fieldInfo.FieldValue.ParseLong("djvalue");
				break;

				case "sjvalue":
					this.sjvalue = fieldInfo.FieldValue.ParseLong("sjvalue");
				break;

				case "jval":
					this.jval = fieldInfo.FieldValue.ParseLong("jval");
				break;

				case "k200jisu":
					this.k200jisu = fieldInfo.FieldValue.ParseFloat("k200jisu");
				break;

				case "k200sign":
					this.k200sign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "change":
					this.change = fieldInfo.FieldValue.ParseFloat("change");
				break;

				case "k200basis":
					this.k200basis = fieldInfo.FieldValue.ParseFloat("k200basis");
				break;

				case "cdvolume":
					this.cdvolume = fieldInfo.FieldValue.ParseLong("cdvolume");
				break;

				case "csvolume":
					this.csvolume = fieldInfo.FieldValue.ParseLong("csvolume");
				break;

				case "cvol":
					this.cvol = fieldInfo.FieldValue.ParseLong("cvol");
				break;

				case "bdvolume":
					this.bdvolume = fieldInfo.FieldValue.ParseLong("bdvolume");
				break;

				case "bsvolume":
					this.bsvolume = fieldInfo.FieldValue.ParseLong("bsvolume");
				break;

				case "bvol":
					this.bvol = fieldInfo.FieldValue.ParseLong("bvol");
				break;

				case "tdvolume":
					this.tdvolume = fieldInfo.FieldValue.ParseLong("tdvolume");
				break;

				case "tsvolume":
					this.tsvolume = fieldInfo.FieldValue.ParseLong("tsvolume");
				break;

				case "tvol":
					this.tvol = fieldInfo.FieldValue.ParseLong("tvol");
				break;

				case "cdvalue":
					this.cdvalue = fieldInfo.FieldValue.ParseLong("cdvalue");
				break;

				case "csvalue":
					this.csvalue = fieldInfo.FieldValue.ParseLong("csvalue");
				break;

				case "cval":
					this.cval = fieldInfo.FieldValue.ParseLong("cval");
				break;

				case "bdvalue":
					this.bdvalue = fieldInfo.FieldValue.ParseLong("bdvalue");
				break;

				case "bsvalue":
					this.bsvalue = fieldInfo.FieldValue.ParseLong("bsvalue");
				break;

				case "bval":
					this.bval = fieldInfo.FieldValue.ParseLong("bval");
				break;

				case "tdvalue":
					this.tdvalue = fieldInfo.FieldValue.ParseLong("tdvalue");
				break;

				case "tsvalue":
					this.tsvalue = fieldInfo.FieldValue.ParseLong("tsvalue");
				break;

				case "tval":
					this.tval = fieldInfo.FieldValue.ParseLong("tval");
				break;

				case "p_cdvolcha":
					this.p_cdvolcha = fieldInfo.FieldValue.ParseLong("p_cdvolcha");
				break;

				case "p_csvolcha":
					this.p_csvolcha = fieldInfo.FieldValue.ParseLong("p_csvolcha");
				break;

				case "p_cvolcha":
					this.p_cvolcha = fieldInfo.FieldValue.ParseLong("p_cvolcha");
				break;

				case "p_bdvolcha":
					this.p_bdvolcha = fieldInfo.FieldValue.ParseLong("p_bdvolcha");
				break;

				case "p_bsvolcha":
					this.p_bsvolcha = fieldInfo.FieldValue.ParseLong("p_bsvolcha");
				break;

				case "p_bvolcha":
					this.p_bvolcha = fieldInfo.FieldValue.ParseLong("p_bvolcha");
				break;

				case "p_tdvolcha":
					this.p_tdvolcha = fieldInfo.FieldValue.ParseLong("p_tdvolcha");
				break;

				case "p_tsvolcha":
					this.p_tsvolcha = fieldInfo.FieldValue.ParseLong("p_tsvolcha");
				break;

				case "p_tvolcha":
					this.p_tvolcha = fieldInfo.FieldValue.ParseLong("p_tvolcha");
				break;

				case "p_cdvalcha":
					this.p_cdvalcha = fieldInfo.FieldValue.ParseLong("p_cdvalcha");
				break;

				case "p_csvalcha":
					this.p_csvalcha = fieldInfo.FieldValue.ParseLong("p_csvalcha");
				break;

				case "p_cvalcha":
					this.p_cvalcha = fieldInfo.FieldValue.ParseLong("p_cvalcha");
				break;

				case "p_bdvalcha":
					this.p_bdvalcha = fieldInfo.FieldValue.ParseLong("p_bdvalcha");
				break;

				case "p_bsvalcha":
					this.p_bsvalcha = fieldInfo.FieldValue.ParseLong("p_bsvalcha");
				break;

				case "p_bvalcha":
					this.p_bvalcha = fieldInfo.FieldValue.ParseLong("p_bvalcha");
				break;

				case "p_tdvalcha":
					this.p_tdvalcha = fieldInfo.FieldValue.ParseLong("p_tdvalcha");
				break;

				case "p_tsvalcha":
					this.p_tsvalcha = fieldInfo.FieldValue.ParseLong("p_tsvalcha");
				break;

				case "p_tvalcha":
					this.p_tvalcha = fieldInfo.FieldValue.ParseLong("p_tvalcha");
				break;

				case "gubun":
					this.gubun = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public static XRPM_OutBlock FromQuery(XRPM_ query)
		{
			XRPM_OutBlock block = new XRPM_OutBlock();
			block.IsValidData = true;
			block.InvalidReason = "";
			try
			{
				block.time = query.GetFieldData(block.GetBlockName(), "time").TrimEnd('?'); // char 6
				block.cdhrem = query.GetFieldData(block.GetBlockName(), "cdhrem").ParseLong("cdhrem"); // long 6
				block.cshrem = query.GetFieldData(block.GetBlockName(), "cshrem").ParseLong("cshrem"); // long 6
				block.bdhrem = query.GetFieldData(block.GetBlockName(), "bdhrem").ParseLong("bdhrem"); // long 6
				block.bshrem = query.GetFieldData(block.GetBlockName(), "bshrem").ParseLong("bshrem"); // long 6
				block.cdhvolume = query.GetFieldData(block.GetBlockName(), "cdhvolume").ParseLong("cdhvolume"); // long 6
				block.cshvolume = query.GetFieldData(block.GetBlockName(), "cshvolume").ParseLong("cshvolume"); // long 6
				block.bdhvolume = query.GetFieldData(block.GetBlockName(), "bdhvolume").ParseLong("bdhvolume"); // long 6
				block.bshvolume = query.GetFieldData(block.GetBlockName(), "bshvolume").ParseLong("bshvolume"); // long 6
				block.cdwvolume = query.GetFieldData(block.GetBlockName(), "cdwvolume").ParseLong("cdwvolume"); // long 6
				block.cdjvolume = query.GetFieldData(block.GetBlockName(), "cdjvolume").ParseLong("cdjvolume"); // long 6
				block.cswvolume = query.GetFieldData(block.GetBlockName(), "cswvolume").ParseLong("cswvolume"); // long 6
				block.csjvolume = query.GetFieldData(block.GetBlockName(), "csjvolume").ParseLong("csjvolume"); // long 6
				block.cwvol = query.GetFieldData(block.GetBlockName(), "cwvol").ParseLong("cwvol"); // long 6
				block.cjvol = query.GetFieldData(block.GetBlockName(), "cjvol").ParseLong("cjvol"); // long 6
				block.bdwvolume = query.GetFieldData(block.GetBlockName(), "bdwvolume").ParseLong("bdwvolume"); // long 6
				block.bdjvolume = query.GetFieldData(block.GetBlockName(), "bdjvolume").ParseLong("bdjvolume"); // long 6
				block.bswvolume = query.GetFieldData(block.GetBlockName(), "bswvolume").ParseLong("bswvolume"); // long 6
				block.bsjvolume = query.GetFieldData(block.GetBlockName(), "bsjvolume").ParseLong("bsjvolume"); // long 6
				block.bwvol = query.GetFieldData(block.GetBlockName(), "bwvol").ParseLong("bwvol"); // long 6
				block.bjvol = query.GetFieldData(block.GetBlockName(), "bjvol").ParseLong("bjvol"); // long 6
				block.dwvolume = query.GetFieldData(block.GetBlockName(), "dwvolume").ParseLong("dwvolume"); // long 6
				block.swvolume = query.GetFieldData(block.GetBlockName(), "swvolume").ParseLong("swvolume"); // long 6
				block.wvol = query.GetFieldData(block.GetBlockName(), "wvol").ParseLong("wvol"); // long 6
				block.djvolume = query.GetFieldData(block.GetBlockName(), "djvolume").ParseLong("djvolume"); // long 6
				block.sjvolume = query.GetFieldData(block.GetBlockName(), "sjvolume").ParseLong("sjvolume"); // long 6
				block.jvol = query.GetFieldData(block.GetBlockName(), "jvol").ParseLong("jvol"); // long 6
				block.cdwvalue = query.GetFieldData(block.GetBlockName(), "cdwvalue").ParseLong("cdwvalue"); // long 8
				block.cdjvalue = query.GetFieldData(block.GetBlockName(), "cdjvalue").ParseLong("cdjvalue"); // long 8
				block.cswvalue = query.GetFieldData(block.GetBlockName(), "cswvalue").ParseLong("cswvalue"); // long 8
				block.csjvalue = query.GetFieldData(block.GetBlockName(), "csjvalue").ParseLong("csjvalue"); // long 8
				block.cwval = query.GetFieldData(block.GetBlockName(), "cwval").ParseLong("cwval"); // long 8
				block.cjval = query.GetFieldData(block.GetBlockName(), "cjval").ParseLong("cjval"); // long 8
				block.bdwvalue = query.GetFieldData(block.GetBlockName(), "bdwvalue").ParseLong("bdwvalue"); // long 8
				block.bdjvalue = query.GetFieldData(block.GetBlockName(), "bdjvalue").ParseLong("bdjvalue"); // long 8
				block.bswvalue = query.GetFieldData(block.GetBlockName(), "bswvalue").ParseLong("bswvalue"); // long 8
				block.bsjvalue = query.GetFieldData(block.GetBlockName(), "bsjvalue").ParseLong("bsjvalue"); // long 8
				block.bwval = query.GetFieldData(block.GetBlockName(), "bwval").ParseLong("bwval"); // long 8
				block.bjval = query.GetFieldData(block.GetBlockName(), "bjval").ParseLong("bjval"); // long 8
				block.dwvalue = query.GetFieldData(block.GetBlockName(), "dwvalue").ParseLong("dwvalue"); // long 8
				block.swvalue = query.GetFieldData(block.GetBlockName(), "swvalue").ParseLong("swvalue"); // long 8
				block.wval = query.GetFieldData(block.GetBlockName(), "wval").ParseLong("wval"); // long 8
				block.djvalue = query.GetFieldData(block.GetBlockName(), "djvalue").ParseLong("djvalue"); // long 8
				block.sjvalue = query.GetFieldData(block.GetBlockName(), "sjvalue").ParseLong("sjvalue"); // long 8
				block.jval = query.GetFieldData(block.GetBlockName(), "jval").ParseLong("jval"); // long 8
				block.k200jisu = query.GetFieldData(block.GetBlockName(), "k200jisu").ParseFloat("k200jisu"); // float 6.2
				block.k200sign = query.GetFieldData(block.GetBlockName(), "k200sign").FirstOrDefault(); // char 1
				block.change = query.GetFieldData(block.GetBlockName(), "change").ParseFloat("change"); // float 6.2
				block.k200basis = query.GetFieldData(block.GetBlockName(), "k200basis").ParseFloat("k200basis"); // float 4.2
				block.cdvolume = query.GetFieldData(block.GetBlockName(), "cdvolume").ParseLong("cdvolume"); // long 6
				block.csvolume = query.GetFieldData(block.GetBlockName(), "csvolume").ParseLong("csvolume"); // long 6
				block.cvol = query.GetFieldData(block.GetBlockName(), "cvol").ParseLong("cvol"); // long 6
				block.bdvolume = query.GetFieldData(block.GetBlockName(), "bdvolume").ParseLong("bdvolume"); // long 6
				block.bsvolume = query.GetFieldData(block.GetBlockName(), "bsvolume").ParseLong("bsvolume"); // long 6
				block.bvol = query.GetFieldData(block.GetBlockName(), "bvol").ParseLong("bvol"); // long 6
				block.tdvolume = query.GetFieldData(block.GetBlockName(), "tdvolume").ParseLong("tdvolume"); // long 6
				block.tsvolume = query.GetFieldData(block.GetBlockName(), "tsvolume").ParseLong("tsvolume"); // long 6
				block.tvol = query.GetFieldData(block.GetBlockName(), "tvol").ParseLong("tvol"); // long 6
				block.cdvalue = query.GetFieldData(block.GetBlockName(), "cdvalue").ParseLong("cdvalue"); // long 8
				block.csvalue = query.GetFieldData(block.GetBlockName(), "csvalue").ParseLong("csvalue"); // long 8
				block.cval = query.GetFieldData(block.GetBlockName(), "cval").ParseLong("cval"); // long 8
				block.bdvalue = query.GetFieldData(block.GetBlockName(), "bdvalue").ParseLong("bdvalue"); // long 8
				block.bsvalue = query.GetFieldData(block.GetBlockName(), "bsvalue").ParseLong("bsvalue"); // long 8
				block.bval = query.GetFieldData(block.GetBlockName(), "bval").ParseLong("bval"); // long 8
				block.tdvalue = query.GetFieldData(block.GetBlockName(), "tdvalue").ParseLong("tdvalue"); // long 8
				block.tsvalue = query.GetFieldData(block.GetBlockName(), "tsvalue").ParseLong("tsvalue"); // long 8
				block.tval = query.GetFieldData(block.GetBlockName(), "tval").ParseLong("tval"); // long 8
				block.p_cdvolcha = query.GetFieldData(block.GetBlockName(), "p_cdvolcha").ParseLong("p_cdvolcha"); // long 6
				block.p_csvolcha = query.GetFieldData(block.GetBlockName(), "p_csvolcha").ParseLong("p_csvolcha"); // long 6
				block.p_cvolcha = query.GetFieldData(block.GetBlockName(), "p_cvolcha").ParseLong("p_cvolcha"); // long 6
				block.p_bdvolcha = query.GetFieldData(block.GetBlockName(), "p_bdvolcha").ParseLong("p_bdvolcha"); // long 6
				block.p_bsvolcha = query.GetFieldData(block.GetBlockName(), "p_bsvolcha").ParseLong("p_bsvolcha"); // long 6
				block.p_bvolcha = query.GetFieldData(block.GetBlockName(), "p_bvolcha").ParseLong("p_bvolcha"); // long 6
				block.p_tdvolcha = query.GetFieldData(block.GetBlockName(), "p_tdvolcha").ParseLong("p_tdvolcha"); // long 6
				block.p_tsvolcha = query.GetFieldData(block.GetBlockName(), "p_tsvolcha").ParseLong("p_tsvolcha"); // long 6
				block.p_tvolcha = query.GetFieldData(block.GetBlockName(), "p_tvolcha").ParseLong("p_tvolcha"); // long 6
				block.p_cdvalcha = query.GetFieldData(block.GetBlockName(), "p_cdvalcha").ParseLong("p_cdvalcha"); // long 8
				block.p_csvalcha = query.GetFieldData(block.GetBlockName(), "p_csvalcha").ParseLong("p_csvalcha"); // long 8
				block.p_cvalcha = query.GetFieldData(block.GetBlockName(), "p_cvalcha").ParseLong("p_cvalcha"); // long 8
				block.p_bdvalcha = query.GetFieldData(block.GetBlockName(), "p_bdvalcha").ParseLong("p_bdvalcha"); // long 8
				block.p_bsvalcha = query.GetFieldData(block.GetBlockName(), "p_bsvalcha").ParseLong("p_bsvalcha"); // long 8
				block.p_bvalcha = query.GetFieldData(block.GetBlockName(), "p_bvalcha").ParseLong("p_bvalcha"); // long 8
				block.p_tdvalcha = query.GetFieldData(block.GetBlockName(), "p_tdvalcha").ParseLong("p_tdvalcha"); // long 8
				block.p_tsvalcha = query.GetFieldData(block.GetBlockName(), "p_tsvalcha").ParseLong("p_tsvalcha"); // long 8
				block.p_tvalcha = query.GetFieldData(block.GetBlockName(), "p_tvalcha").ParseLong("p_tvalcha"); // long 8
				block.gubun = query.GetFieldData(block.GetBlockName(), "gubun").FirstOrDefault(); // char 1

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (time?.Length > 6) return false; // char 6
			if (cdhrem.ToString().Length > 6) return false; // long 6
			if (cshrem.ToString().Length > 6) return false; // long 6
			if (bdhrem.ToString().Length > 6) return false; // long 6
			if (bshrem.ToString().Length > 6) return false; // long 6
			if (cdhvolume.ToString().Length > 6) return false; // long 6
			if (cshvolume.ToString().Length > 6) return false; // long 6
			if (bdhvolume.ToString().Length > 6) return false; // long 6
			if (bshvolume.ToString().Length > 6) return false; // long 6
			if (cdwvolume.ToString().Length > 6) return false; // long 6
			if (cdjvolume.ToString().Length > 6) return false; // long 6
			if (cswvolume.ToString().Length > 6) return false; // long 6
			if (csjvolume.ToString().Length > 6) return false; // long 6
			if (cwvol.ToString().Length > 6) return false; // long 6
			if (cjvol.ToString().Length > 6) return false; // long 6
			if (bdwvolume.ToString().Length > 6) return false; // long 6
			if (bdjvolume.ToString().Length > 6) return false; // long 6
			if (bswvolume.ToString().Length > 6) return false; // long 6
			if (bsjvolume.ToString().Length > 6) return false; // long 6
			if (bwvol.ToString().Length > 6) return false; // long 6
			if (bjvol.ToString().Length > 6) return false; // long 6
			if (dwvolume.ToString().Length > 6) return false; // long 6
			if (swvolume.ToString().Length > 6) return false; // long 6
			if (wvol.ToString().Length > 6) return false; // long 6
			if (djvolume.ToString().Length > 6) return false; // long 6
			if (sjvolume.ToString().Length > 6) return false; // long 6
			if (jvol.ToString().Length > 6) return false; // long 6
			if (cdwvalue.ToString().Length > 8) return false; // long 8
			if (cdjvalue.ToString().Length > 8) return false; // long 8
			if (cswvalue.ToString().Length > 8) return false; // long 8
			if (csjvalue.ToString().Length > 8) return false; // long 8
			if (cwval.ToString().Length > 8) return false; // long 8
			if (cjval.ToString().Length > 8) return false; // long 8
			if (bdwvalue.ToString().Length > 8) return false; // long 8
			if (bdjvalue.ToString().Length > 8) return false; // long 8
			if (bswvalue.ToString().Length > 8) return false; // long 8
			if (bsjvalue.ToString().Length > 8) return false; // long 8
			if (bwval.ToString().Length > 8) return false; // long 8
			if (bjval.ToString().Length > 8) return false; // long 8
			if (dwvalue.ToString().Length > 8) return false; // long 8
			if (swvalue.ToString().Length > 8) return false; // long 8
			if (wval.ToString().Length > 8) return false; // long 8
			if (djvalue.ToString().Length > 8) return false; // long 8
			if (sjvalue.ToString().Length > 8) return false; // long 8
			if (jval.ToString().Length > 8) return false; // long 8
			// k200jisu float 6.2
			// k200sign char 1
			// change float 6.2
			// k200basis float 4.2
			if (cdvolume.ToString().Length > 6) return false; // long 6
			if (csvolume.ToString().Length > 6) return false; // long 6
			if (cvol.ToString().Length > 6) return false; // long 6
			if (bdvolume.ToString().Length > 6) return false; // long 6
			if (bsvolume.ToString().Length > 6) return false; // long 6
			if (bvol.ToString().Length > 6) return false; // long 6
			if (tdvolume.ToString().Length > 6) return false; // long 6
			if (tsvolume.ToString().Length > 6) return false; // long 6
			if (tvol.ToString().Length > 6) return false; // long 6
			if (cdvalue.ToString().Length > 8) return false; // long 8
			if (csvalue.ToString().Length > 8) return false; // long 8
			if (cval.ToString().Length > 8) return false; // long 8
			if (bdvalue.ToString().Length > 8) return false; // long 8
			if (bsvalue.ToString().Length > 8) return false; // long 8
			if (bval.ToString().Length > 8) return false; // long 8
			if (tdvalue.ToString().Length > 8) return false; // long 8
			if (tsvalue.ToString().Length > 8) return false; // long 8
			if (tval.ToString().Length > 8) return false; // long 8
			if (p_cdvolcha.ToString().Length > 6) return false; // long 6
			if (p_csvolcha.ToString().Length > 6) return false; // long 6
			if (p_cvolcha.ToString().Length > 6) return false; // long 6
			if (p_bdvolcha.ToString().Length > 6) return false; // long 6
			if (p_bsvolcha.ToString().Length > 6) return false; // long 6
			if (p_bvolcha.ToString().Length > 6) return false; // long 6
			if (p_tdvolcha.ToString().Length > 6) return false; // long 6
			if (p_tsvolcha.ToString().Length > 6) return false; // long 6
			if (p_tvolcha.ToString().Length > 6) return false; // long 6
			if (p_cdvalcha.ToString().Length > 8) return false; // long 8
			if (p_csvalcha.ToString().Length > 8) return false; // long 8
			if (p_cvalcha.ToString().Length > 8) return false; // long 8
			if (p_bdvalcha.ToString().Length > 8) return false; // long 8
			if (p_bsvalcha.ToString().Length > 8) return false; // long 8
			if (p_bvalcha.ToString().Length > 8) return false; // long 8
			if (p_tdvalcha.ToString().Length > 8) return false; // long 8
			if (p_tsvalcha.ToString().Length > 8) return false; // long 8
			if (p_tvalcha.ToString().Length > 8) return false; // long 8
			// gubun char 1

			return true;
		}
	}

	public partial class XRPM_ : XingReal
	{
		/// <summary>
		/// PM_
		/// </summary>
		public const string _typeName = "PM_";
		/// <summary>
		/// KOSPI프로그램매매전체집계(PM)
		/// </summary>
		public const string _typeDesc = "KOSPI프로그램매매전체집계(PM)";
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
		/// PM_
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// KOSPI프로그램매매전체집계(PM)
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

		public XRPM_() : base("PM_") { }


		public bool SetFields(XRPM_InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaReal.SetFieldData(block.GetBlockName(), "gubun", block.gubun.ToString()); // char 1

			return true;
		}

		public XRPM_OutBlock GetBlock()
		{
			XRPM_OutBlock instance = XRPM_OutBlock.FromQuery(this);
			return instance;

		}


	}

}
