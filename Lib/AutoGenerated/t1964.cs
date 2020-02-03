using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1964InBlock : XingBlock
	{
		/// <summary>
		/// t1964InBlock
		/// </summary>
		static readonly string _blockName = "t1964InBlock";
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
		/// t1964InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1964InBlock
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
		/// 기초자산코드
		/// </summary>
		[XAQueryFieldAttribute("기초자산코드")]
		public string item;
		/// <summary>
		/// 발행사
		/// </summary>
		[XAQueryFieldAttribute("발행사")]
		public string issuercd;
		/// <summary>
		/// 만기월물
		/// </summary>
		[XAQueryFieldAttribute("만기월물")]
		public string lastmonth;
		/// <summary>
		/// 콜풋구분
		/// </summary>
		[XAQueryFieldAttribute("콜풋구분")]
		public char elwopt;
		/// <summary>
		/// 머니구분
		/// </summary>
		[XAQueryFieldAttribute("머니구분")]
		public char atmgubun;
		/// <summary>
		/// 권리행사방식
		/// </summary>
		[XAQueryFieldAttribute("권리행사방식")]
		public string elwtype;
		/// <summary>
		/// 결제방법
		/// </summary>
		[XAQueryFieldAttribute("결제방법")]
		public string settletype;
		/// <summary>
		/// 행사기초자산구분
		/// </summary>
		[XAQueryFieldAttribute("행사기초자산구분")]
		public char elwexecgubun;
		/// <summary>
		/// 시작비율
		/// </summary>
		[XAQueryFieldAttribute("시작비율")]
		public string fromrat;
		/// <summary>
		/// 종료비율
		/// </summary>
		[XAQueryFieldAttribute("종료비율")]
		public string torat;
		/// <summary>
		/// 거래량
		/// </summary>
		[XAQueryFieldAttribute("거래량")]
		public string volume;

		public static class F
		{
			/// <summary>
			/// 기초자산코드
			/// </summary>
			public const string item = "item";
			/// <summary>
			/// 발행사
			/// </summary>
			public const string issuercd = "issuercd";
			/// <summary>
			/// 만기월물
			/// </summary>
			public const string lastmonth = "lastmonth";
			/// <summary>
			/// 콜풋구분
			/// </summary>
			public const string elwopt = "elwopt";
			/// <summary>
			/// 머니구분
			/// </summary>
			public const string atmgubun = "atmgubun";
			/// <summary>
			/// 권리행사방식
			/// </summary>
			public const string elwtype = "elwtype";
			/// <summary>
			/// 결제방법
			/// </summary>
			public const string settletype = "settletype";
			/// <summary>
			/// 행사기초자산구분
			/// </summary>
			public const string elwexecgubun = "elwexecgubun";
			/// <summary>
			/// 시작비율
			/// </summary>
			public const string fromrat = "fromrat";
			/// <summary>
			/// 종료비율
			/// </summary>
			public const string torat = "torat";
			/// <summary>
			/// 거래량
			/// </summary>
			public const string volume = "volume";
		}

		public static string[] AllFields = new string[]
		{
			F.item,
			F.issuercd,
			F.lastmonth,
			F.elwopt,
			F.atmgubun,
			F.elwtype,
			F.settletype,
			F.elwexecgubun,
			F.fromrat,
			F.torat,
			F.volume,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["item"] = new XAQueryFieldInfo("char", item, item, "기초자산코드", (decimal)12);
			dict["issuercd"] = new XAQueryFieldInfo("char", issuercd, issuercd, "발행사", (decimal)12);
			dict["lastmonth"] = new XAQueryFieldInfo("char", lastmonth, lastmonth, "만기월물", (decimal)6);
			dict["elwopt"] = new XAQueryFieldInfo("char", elwopt, elwopt.ToString(), "콜풋구분", (decimal)1);
			dict["atmgubun"] = new XAQueryFieldInfo("char", atmgubun, atmgubun.ToString(), "머니구분", (decimal)1);
			dict["elwtype"] = new XAQueryFieldInfo("char", elwtype, elwtype, "권리행사방식", (decimal)2);
			dict["settletype"] = new XAQueryFieldInfo("char", settletype, settletype, "결제방법", (decimal)2);
			dict["elwexecgubun"] = new XAQueryFieldInfo("char", elwexecgubun, elwexecgubun.ToString(), "행사기초자산구분", (decimal)1);
			dict["fromrat"] = new XAQueryFieldInfo("char", fromrat, fromrat, "시작비율", (decimal)5);
			dict["torat"] = new XAQueryFieldInfo("char", torat, torat, "종료비율", (decimal)5);
			dict["volume"] = new XAQueryFieldInfo("char", volume, volume, "거래량", (decimal)12);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "item":
					this.item = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "issuercd":
					this.issuercd = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "lastmonth":
					this.lastmonth = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "elwopt":
					this.elwopt = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "atmgubun":
					this.atmgubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "elwtype":
					this.elwtype = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "settletype":
					this.settletype = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "elwexecgubun":
					this.elwexecgubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "fromrat":
					this.fromrat = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "torat":
					this.torat = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "volume":
					this.volume = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (item.Length > 12) return false; // char 12
			if (issuercd.Length > 12) return false; // char 12
			if (lastmonth.Length > 6) return false; // char 6
			// elwopt char 1
			// atmgubun char 1
			if (elwtype.Length > 2) return false; // char 2
			if (settletype.Length > 2) return false; // char 2
			// elwexecgubun char 1
			if (fromrat.Length > 5) return false; // char 5
			if (torat.Length > 5) return false; // char 5
			if (volume.Length > 12) return false; // char 12

			return true;
		}
	}

	public partial class XQt1964OutBlock1 : XingBlock
	{
		/// <summary>
		/// t1964OutBlock1
		/// </summary>
		static readonly string _blockName = "t1964OutBlock1";
		/// <summary>
		/// 출력1
		/// </summary>
		static readonly string _blockDesc = "출력1";
		/// <summary>
		/// output
		/// </summary>
		static readonly string _blockType = "output";
		/// <summary>
		/// true
		/// </summary>
		static readonly bool _hasOccurs = true;
		/// <summary>
		/// t1964OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1964OutBlock1
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
		/// ELW코드
		/// </summary>
		[XAQueryFieldAttribute("ELW코드")]
		public string shcode;
		/// <summary>
		/// 종목명
		/// </summary>
		[XAQueryFieldAttribute("종목명")]
		public string hname;
		/// <summary>
		/// 기초자산코드
		/// </summary>
		[XAQueryFieldAttribute("기초자산코드")]
		public string item1;
		/// <summary>
		/// 기초자산명
		/// </summary>
		[XAQueryFieldAttribute("기초자산명")]
		public string itemnm;
		/// <summary>
		/// 발행사
		/// </summary>
		[XAQueryFieldAttribute("발행사")]
		public string issuernmk;
		/// <summary>
		/// 콜풋구분
		/// </summary>
		[XAQueryFieldAttribute("콜풋구분")]
		public string elwopt;
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
		/// 거래량
		/// </summary>
		[XAQueryFieldAttribute("거래량")]
		public long volume;
		/// <summary>
		/// 행사가
		/// </summary>
		[XAQueryFieldAttribute("행사가")]
		public float elwexec;
		/// <summary>
		/// 잔존일수
		/// </summary>
		[XAQueryFieldAttribute("잔존일수")]
		public long jandatecnt;
		/// <summary>
		/// 전환비율
		/// </summary>
		[XAQueryFieldAttribute("전환비율")]
		public float convrate;
		/// <summary>
		/// 최종거래일
		/// </summary>
		[XAQueryFieldAttribute("최종거래일")]
		public string lastdate;
		/// <summary>
		/// 행사개시일
		/// </summary>
		[XAQueryFieldAttribute("행사개시일")]
		public string mmsdate;
		/// <summary>
		/// 지급일
		/// </summary>
		[XAQueryFieldAttribute("지급일")]
		public string payday;
		/// <summary>
		/// 발행수량
		/// </summary>
		[XAQueryFieldAttribute("발행수량")]
		public long listing;
		/// <summary>
		/// 머니구분
		/// </summary>
		[XAQueryFieldAttribute("머니구분")]
		public string atmgbnm;
		/// <summary>
		/// 패리티
		/// </summary>
		[XAQueryFieldAttribute("패리티")]
		public float parity;
		/// <summary>
		/// 프리미엄
		/// </summary>
		[XAQueryFieldAttribute("프리미엄")]
		public float preminum;
		/// <summary>
		/// 스프래드
		/// </summary>
		[XAQueryFieldAttribute("스프래드")]
		public float spread;
		/// <summary>
		/// 손익분기율
		/// </summary>
		[XAQueryFieldAttribute("손익분기율")]
		public float berate;
		/// <summary>
		/// 자본지지율
		/// </summary>
		[XAQueryFieldAttribute("자본지지율")]
		public float capt;
		/// <summary>
		/// 기어링
		/// </summary>
		[XAQueryFieldAttribute("기어링")]
		public float gearing;
		/// <summary>
		/// e기어링
		/// </summary>
		[XAQueryFieldAttribute("e기어링")]
		public float egearing;
		/// <summary>
		/// 기초자산현재가
		/// </summary>
		[XAQueryFieldAttribute("기초자산현재가")]
		public long itemprice;
		/// <summary>
		/// 기초자산전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("기초자산전일대비구분")]
		public char itemsign;
		/// <summary>
		/// 기초자산전일대비
		/// </summary>
		[XAQueryFieldAttribute("기초자산전일대비")]
		public long itemchange;
		/// <summary>
		/// 기초자산등락율
		/// </summary>
		[XAQueryFieldAttribute("기초자산등락율")]
		public float itemdiff;
		/// <summary>
		/// 기초자산거래량
		/// </summary>
		[XAQueryFieldAttribute("기초자산거래량")]
		public long itemvolume;
		/// <summary>
		/// 전일거래량
		/// </summary>
		[XAQueryFieldAttribute("전일거래량")]
		public long jnilvolume;
		/// <summary>
		/// 이론가
		/// </summary>
		[XAQueryFieldAttribute("이론가")]
		public float theoryprice;
		/// <summary>
		/// LP보유비율
		/// </summary>
		[XAQueryFieldAttribute("LP보유비율")]
		public float lp_rate;
		/// <summary>
		/// 내재변동성
		/// </summary>
		[XAQueryFieldAttribute("내재변동성")]
		public float impv;
		/// <summary>
		/// 델타
		/// </summary>
		[XAQueryFieldAttribute("델타")]
		public float delta;
		/// <summary>
		/// 쎄타
		/// </summary>
		[XAQueryFieldAttribute("쎄타")]
		public float theta;

		public static class F
		{
			/// <summary>
			/// ELW코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 종목명
			/// </summary>
			public const string hname = "hname";
			/// <summary>
			/// 기초자산코드
			/// </summary>
			public const string item1 = "item1";
			/// <summary>
			/// 기초자산명
			/// </summary>
			public const string itemnm = "itemnm";
			/// <summary>
			/// 발행사
			/// </summary>
			public const string issuernmk = "issuernmk";
			/// <summary>
			/// 콜풋구분
			/// </summary>
			public const string elwopt = "elwopt";
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
			/// 행사가
			/// </summary>
			public const string elwexec = "elwexec";
			/// <summary>
			/// 잔존일수
			/// </summary>
			public const string jandatecnt = "jandatecnt";
			/// <summary>
			/// 전환비율
			/// </summary>
			public const string convrate = "convrate";
			/// <summary>
			/// 최종거래일
			/// </summary>
			public const string lastdate = "lastdate";
			/// <summary>
			/// 행사개시일
			/// </summary>
			public const string mmsdate = "mmsdate";
			/// <summary>
			/// 지급일
			/// </summary>
			public const string payday = "payday";
			/// <summary>
			/// 발행수량
			/// </summary>
			public const string listing = "listing";
			/// <summary>
			/// 머니구분
			/// </summary>
			public const string atmgbnm = "atmgbnm";
			/// <summary>
			/// 패리티
			/// </summary>
			public const string parity = "parity";
			/// <summary>
			/// 프리미엄
			/// </summary>
			public const string preminum = "preminum";
			/// <summary>
			/// 스프래드
			/// </summary>
			public const string spread = "spread";
			/// <summary>
			/// 손익분기율
			/// </summary>
			public const string berate = "berate";
			/// <summary>
			/// 자본지지율
			/// </summary>
			public const string capt = "capt";
			/// <summary>
			/// 기어링
			/// </summary>
			public const string gearing = "gearing";
			/// <summary>
			/// e기어링
			/// </summary>
			public const string egearing = "egearing";
			/// <summary>
			/// 기초자산현재가
			/// </summary>
			public const string itemprice = "itemprice";
			/// <summary>
			/// 기초자산전일대비구분
			/// </summary>
			public const string itemsign = "itemsign";
			/// <summary>
			/// 기초자산전일대비
			/// </summary>
			public const string itemchange = "itemchange";
			/// <summary>
			/// 기초자산등락율
			/// </summary>
			public const string itemdiff = "itemdiff";
			/// <summary>
			/// 기초자산거래량
			/// </summary>
			public const string itemvolume = "itemvolume";
			/// <summary>
			/// 전일거래량
			/// </summary>
			public const string jnilvolume = "jnilvolume";
			/// <summary>
			/// 이론가
			/// </summary>
			public const string theoryprice = "theoryprice";
			/// <summary>
			/// LP보유비율
			/// </summary>
			public const string lp_rate = "lp_rate";
			/// <summary>
			/// 내재변동성
			/// </summary>
			public const string impv = "impv";
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
			F.shcode,
			F.hname,
			F.item1,
			F.itemnm,
			F.issuernmk,
			F.elwopt,
			F.price,
			F.sign,
			F.change,
			F.diff,
			F.volume,
			F.elwexec,
			F.jandatecnt,
			F.convrate,
			F.lastdate,
			F.mmsdate,
			F.payday,
			F.listing,
			F.atmgbnm,
			F.parity,
			F.preminum,
			F.spread,
			F.berate,
			F.capt,
			F.gearing,
			F.egearing,
			F.itemprice,
			F.itemsign,
			F.itemchange,
			F.itemdiff,
			F.itemvolume,
			F.jnilvolume,
			F.theoryprice,
			F.lp_rate,
			F.impv,
			F.delta,
			F.theta,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "ELW코드", (decimal)6);
			dict["hname"] = new XAQueryFieldInfo("char", hname, hname, "종목명", (decimal)40);
			dict["item1"] = new XAQueryFieldInfo("char", item1, item1, "기초자산코드", (decimal)6);
			dict["itemnm"] = new XAQueryFieldInfo("char", itemnm, itemnm, "기초자산명", (decimal)20);
			dict["issuernmk"] = new XAQueryFieldInfo("char", issuernmk, issuernmk, "발행사", (decimal)40);
			dict["elwopt"] = new XAQueryFieldInfo("char", elwopt, elwopt, "콜풋구분", (decimal)4);
			dict["price"] = new XAQueryFieldInfo("long", price, price.ToString("d8"), "현재가", (decimal)8);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("long", change, change.ToString("d8"), "전일대비", (decimal)8);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "거래량", (decimal)12);
			dict["elwexec"] = new XAQueryFieldInfo("float", elwexec, elwexec.ToString("0000000000.00"), "행사가", (decimal)10.2);
			dict["jandatecnt"] = new XAQueryFieldInfo("long", jandatecnt, jandatecnt.ToString("d8"), "잔존일수", (decimal)8);
			dict["convrate"] = new XAQueryFieldInfo("float", convrate, convrate.ToString("00000000.0000"), "전환비율", (decimal)8.4);
			dict["lastdate"] = new XAQueryFieldInfo("char", lastdate, lastdate, "최종거래일", (decimal)8);
			dict["mmsdate"] = new XAQueryFieldInfo("char", mmsdate, mmsdate, "행사개시일", (decimal)8);
			dict["payday"] = new XAQueryFieldInfo("char", payday, payday, "지급일", (decimal)8);
			dict["listing"] = new XAQueryFieldInfo("long", listing, listing.ToString("d8"), "발행수량", (decimal)8);
			dict["atmgbnm"] = new XAQueryFieldInfo("char", atmgbnm, atmgbnm, "머니구분", (decimal)10);
			dict["parity"] = new XAQueryFieldInfo("float", parity, parity.ToString("000000.00"), "패리티", (decimal)6.2);
			dict["preminum"] = new XAQueryFieldInfo("float", preminum, preminum.ToString("0000000000.00"), "프리미엄", (decimal)10.2);
			dict["spread"] = new XAQueryFieldInfo("float", spread, spread.ToString("000.00"), "스프래드", (decimal)3.2);
			dict["berate"] = new XAQueryFieldInfo("float", berate, berate.ToString("000000.00"), "손익분기율", (decimal)6.2);
			dict["capt"] = new XAQueryFieldInfo("float", capt, capt.ToString("000000.00"), "자본지지율", (decimal)6.2);
			dict["gearing"] = new XAQueryFieldInfo("float", gearing, gearing.ToString("000000.00"), "기어링", (decimal)6.2);
			dict["egearing"] = new XAQueryFieldInfo("float", egearing, egearing.ToString("000000.00"), "e기어링", (decimal)6.2);
			dict["itemprice"] = new XAQueryFieldInfo("long", itemprice, itemprice.ToString("d8"), "기초자산현재가", (decimal)8);
			dict["itemsign"] = new XAQueryFieldInfo("char", itemsign, itemsign.ToString(), "기초자산전일대비구분", (decimal)1);
			dict["itemchange"] = new XAQueryFieldInfo("long", itemchange, itemchange.ToString("d8"), "기초자산전일대비", (decimal)8);
			dict["itemdiff"] = new XAQueryFieldInfo("float", itemdiff, itemdiff.ToString("000000.00"), "기초자산등락율", (decimal)6.2);
			dict["itemvolume"] = new XAQueryFieldInfo("long", itemvolume, itemvolume.ToString("d12"), "기초자산거래량", (decimal)12);
			dict["jnilvolume"] = new XAQueryFieldInfo("long", jnilvolume, jnilvolume.ToString("d12"), "전일거래량", (decimal)12);
			dict["theoryprice"] = new XAQueryFieldInfo("float", theoryprice, theoryprice.ToString("0000000000.00"), "이론가", (decimal)10.2);
			dict["lp_rate"] = new XAQueryFieldInfo("float", lp_rate, lp_rate.ToString("00000.00"), "LP보유비율", (decimal)5.2);
			dict["impv"] = new XAQueryFieldInfo("float", impv, impv.ToString("000000.00"), "내재변동성", (decimal)6.2);
			dict["delta"] = new XAQueryFieldInfo("float", delta, delta.ToString("0000000000.000000"), "델타", (decimal)10.6);
			dict["theta"] = new XAQueryFieldInfo("float", theta, theta.ToString("0000000000.000000"), "쎄타", (decimal)10.6);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "hname":
					this.hname = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "item1":
					this.item1 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "itemnm":
					this.itemnm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "issuernmk":
					this.issuernmk = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "elwopt":
					this.elwopt = fieldInfo.FieldValue.TrimEnd('?');
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

				case "elwexec":
					this.elwexec = fieldInfo.FieldValue.ParseFloat("elwexec");
				break;

				case "jandatecnt":
					this.jandatecnt = fieldInfo.FieldValue.ParseLong("jandatecnt");
				break;

				case "convrate":
					this.convrate = fieldInfo.FieldValue.ParseFloat("convrate");
				break;

				case "lastdate":
					this.lastdate = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "mmsdate":
					this.mmsdate = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "payday":
					this.payday = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "listing":
					this.listing = fieldInfo.FieldValue.ParseLong("listing");
				break;

				case "atmgbnm":
					this.atmgbnm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "parity":
					this.parity = fieldInfo.FieldValue.ParseFloat("parity");
				break;

				case "preminum":
					this.preminum = fieldInfo.FieldValue.ParseFloat("preminum");
				break;

				case "spread":
					this.spread = fieldInfo.FieldValue.ParseFloat("spread");
				break;

				case "berate":
					this.berate = fieldInfo.FieldValue.ParseFloat("berate");
				break;

				case "capt":
					this.capt = fieldInfo.FieldValue.ParseFloat("capt");
				break;

				case "gearing":
					this.gearing = fieldInfo.FieldValue.ParseFloat("gearing");
				break;

				case "egearing":
					this.egearing = fieldInfo.FieldValue.ParseFloat("egearing");
				break;

				case "itemprice":
					this.itemprice = fieldInfo.FieldValue.ParseLong("itemprice");
				break;

				case "itemsign":
					this.itemsign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "itemchange":
					this.itemchange = fieldInfo.FieldValue.ParseLong("itemchange");
				break;

				case "itemdiff":
					this.itemdiff = fieldInfo.FieldValue.ParseFloat("itemdiff");
				break;

				case "itemvolume":
					this.itemvolume = fieldInfo.FieldValue.ParseLong("itemvolume");
				break;

				case "jnilvolume":
					this.jnilvolume = fieldInfo.FieldValue.ParseLong("jnilvolume");
				break;

				case "theoryprice":
					this.theoryprice = fieldInfo.FieldValue.ParseFloat("theoryprice");
				break;

				case "lp_rate":
					this.lp_rate = fieldInfo.FieldValue.ParseFloat("lp_rate");
				break;

				case "impv":
					this.impv = fieldInfo.FieldValue.ParseFloat("impv");
				break;

				case "delta":
					this.delta = fieldInfo.FieldValue.ParseFloat("delta");
				break;

				case "theta":
					this.theta = fieldInfo.FieldValue.ParseFloat("theta");
				break;


			}
		}

		public static XQt1964OutBlock1[] ListFromQuery(XQt1964 query)
		{
			int count = query.GetBlockCount(XQt1964OutBlock1.BlockName);
			List<XQt1964OutBlock1> list = new List<XQt1964OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1964OutBlock1 block = new XQt1964OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.shcode = query.GetFieldData(block.GetBlockName(), "shcode", i).TrimEnd('?'); // char 6
					block.hname = query.GetFieldData(block.GetBlockName(), "hname", i).TrimEnd('?'); // char 40
					block.item1 = query.GetFieldData(block.GetBlockName(), "item1", i).TrimEnd('?'); // char 6
					block.itemnm = query.GetFieldData(block.GetBlockName(), "itemnm", i).TrimEnd('?'); // char 20
					block.issuernmk = query.GetFieldData(block.GetBlockName(), "issuernmk", i).TrimEnd('?'); // char 40
					block.elwopt = query.GetFieldData(block.GetBlockName(), "elwopt", i).TrimEnd('?'); // char 4
					block.price = query.GetFieldData(block.GetBlockName(), "price", i).ParseLong("price"); // long 8
					block.sign = query.GetFieldData(block.GetBlockName(), "sign", i).FirstOrDefault(); // char 1
					block.change = query.GetFieldData(block.GetBlockName(), "change", i).ParseLong("change"); // long 8
					block.diff = query.GetFieldData(block.GetBlockName(), "diff", i).ParseFloat("diff"); // float 6.2
					block.volume = query.GetFieldData(block.GetBlockName(), "volume", i).ParseLong("volume"); // long 12
					block.elwexec = query.GetFieldData(block.GetBlockName(), "elwexec", i).ParseFloat("elwexec"); // float 10.2
					block.jandatecnt = query.GetFieldData(block.GetBlockName(), "jandatecnt", i).ParseLong("jandatecnt"); // long 8
					block.convrate = query.GetFieldData(block.GetBlockName(), "convrate", i).ParseFloat("convrate"); // float 8.4
					block.lastdate = query.GetFieldData(block.GetBlockName(), "lastdate", i).TrimEnd('?'); // char 8
					block.mmsdate = query.GetFieldData(block.GetBlockName(), "mmsdate", i).TrimEnd('?'); // char 8
					block.payday = query.GetFieldData(block.GetBlockName(), "payday", i).TrimEnd('?'); // char 8
					block.listing = query.GetFieldData(block.GetBlockName(), "listing", i).ParseLong("listing"); // long 8
					block.atmgbnm = query.GetFieldData(block.GetBlockName(), "atmgbnm", i).TrimEnd('?'); // char 10
					block.parity = query.GetFieldData(block.GetBlockName(), "parity", i).ParseFloat("parity"); // float 6.2
					block.preminum = query.GetFieldData(block.GetBlockName(), "preminum", i).ParseFloat("preminum"); // float 10.2
					block.spread = query.GetFieldData(block.GetBlockName(), "spread", i).ParseFloat("spread"); // float 3.2
					block.berate = query.GetFieldData(block.GetBlockName(), "berate", i).ParseFloat("berate"); // float 6.2
					block.capt = query.GetFieldData(block.GetBlockName(), "capt", i).ParseFloat("capt"); // float 6.2
					block.gearing = query.GetFieldData(block.GetBlockName(), "gearing", i).ParseFloat("gearing"); // float 6.2
					block.egearing = query.GetFieldData(block.GetBlockName(), "egearing", i).ParseFloat("egearing"); // float 6.2
					block.itemprice = query.GetFieldData(block.GetBlockName(), "itemprice", i).ParseLong("itemprice"); // long 8
					block.itemsign = query.GetFieldData(block.GetBlockName(), "itemsign", i).FirstOrDefault(); // char 1
					block.itemchange = query.GetFieldData(block.GetBlockName(), "itemchange", i).ParseLong("itemchange"); // long 8
					block.itemdiff = query.GetFieldData(block.GetBlockName(), "itemdiff", i).ParseFloat("itemdiff"); // float 6.2
					block.itemvolume = query.GetFieldData(block.GetBlockName(), "itemvolume", i).ParseLong("itemvolume"); // long 12
					block.jnilvolume = query.GetFieldData(block.GetBlockName(), "jnilvolume", i).ParseLong("jnilvolume"); // long 12
					block.theoryprice = query.GetFieldData(block.GetBlockName(), "theoryprice", i).ParseFloat("theoryprice"); // float 10.2
					block.lp_rate = query.GetFieldData(block.GetBlockName(), "lp_rate", i).ParseFloat("lp_rate"); // float 5.2
					block.impv = query.GetFieldData(block.GetBlockName(), "impv", i).ParseFloat("impv"); // float 6.2
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
			if (shcode.Length > 6) return false; // char 6
			if (hname.Length > 40) return false; // char 40
			if (item1.Length > 6) return false; // char 6
			if (itemnm.Length > 20) return false; // char 20
			if (issuernmk.Length > 40) return false; // char 40
			if (elwopt.Length > 4) return false; // char 4
			if (price.ToString().Length > 8) return false; // long 8
			// sign char 1
			if (change.ToString().Length > 8) return false; // long 8
			// diff float 6.2
			if (volume.ToString().Length > 12) return false; // long 12
			// elwexec float 10.2
			if (jandatecnt.ToString().Length > 8) return false; // long 8
			// convrate float 8.4
			if (lastdate.Length > 8) return false; // char 8
			if (mmsdate.Length > 8) return false; // char 8
			if (payday.Length > 8) return false; // char 8
			if (listing.ToString().Length > 8) return false; // long 8
			if (atmgbnm.Length > 10) return false; // char 10
			// parity float 6.2
			// preminum float 10.2
			// spread float 3.2
			// berate float 6.2
			// capt float 6.2
			// gearing float 6.2
			// egearing float 6.2
			if (itemprice.ToString().Length > 8) return false; // long 8
			// itemsign char 1
			if (itemchange.ToString().Length > 8) return false; // long 8
			// itemdiff float 6.2
			if (itemvolume.ToString().Length > 12) return false; // long 12
			if (jnilvolume.ToString().Length > 12) return false; // long 12
			// theoryprice float 10.2
			// lp_rate float 5.2
			// impv float 6.2
			// delta float 10.6
			// theta float 10.6

			return true;
		}
	}

	public partial class XQt1964 : XingQuery
	{
		/// <summary>
		/// t1964
		/// </summary>
		static readonly string _typeName = "t1964";
		/// <summary>
		/// ELW전광판(t1964)
		/// </summary>
		static readonly string _typeDesc = "ELW전광판(t1964)";
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
		/// t1964
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// ELW전광판(t1964)
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

		public XQt1964() : base("t1964") { }


		public bool SetFields(XQt1964InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "item", 0, block.item); // char 12
			_xaQuery.SetFieldData(block.GetBlockName(), "issuercd", 0, block.issuercd); // char 12
			_xaQuery.SetFieldData(block.GetBlockName(), "lastmonth", 0, block.lastmonth); // char 6
			_xaQuery.SetFieldData(block.GetBlockName(), "elwopt", 0, block.elwopt.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "atmgubun", 0, block.atmgubun.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "elwtype", 0, block.elwtype); // char 2
			_xaQuery.SetFieldData(block.GetBlockName(), "settletype", 0, block.settletype); // char 2
			_xaQuery.SetFieldData(block.GetBlockName(), "elwexecgubun", 0, block.elwexecgubun.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "fromrat", 0, block.fromrat); // char 5
			_xaQuery.SetFieldData(block.GetBlockName(), "torat", 0, block.torat); // char 5
			_xaQuery.SetFieldData(block.GetBlockName(), "volume", 0, block.volume); // char 12

			return true;
		}

		public XQt1964OutBlock1[] GetBlock1s()
		{
			XQt1964OutBlock1[] instance = XQt1964OutBlock1.ListFromQuery(this);
			return instance;

		}


	}

}
