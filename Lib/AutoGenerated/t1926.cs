using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1926InBlock : XingBlock
	{
		/// <summary>
		/// t1926InBlock
		/// </summary>
		public const string _blockName = "t1926InBlock";
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
		/// t1926InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1926InBlock
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
		/// 종목코드
		/// </summary>
		[XAQueryFieldAttribute("종목코드")]
		public string shcode;

		public static class F
		{
			/// <summary>
			/// 종목코드
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
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "종목코드", (decimal)6);

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

	public partial class XQt1926OutBlock : XingBlock
	{
		/// <summary>
		/// t1926OutBlock
		/// </summary>
		public const string _blockName = "t1926OutBlock";
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
		/// t1926OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1926OutBlock
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
		/// 융자신규수량
		/// </summary>
		[XAQueryFieldAttribute("융자신규수량")]
		public long ynvolume;
		/// <summary>
		/// 융자상환수량
		/// </summary>
		[XAQueryFieldAttribute("융자상환수량")]
		public long ysvolume;
		/// <summary>
		/// 융자잔고수량
		/// </summary>
		[XAQueryFieldAttribute("융자잔고수량")]
		public long yjvolume;
		/// <summary>
		/// 융자수량대비
		/// </summary>
		[XAQueryFieldAttribute("융자수량대비")]
		public long yvchange;
		/// <summary>
		/// 융자공여율
		/// </summary>
		[XAQueryFieldAttribute("융자공여율")]
		public float ygrate;
		/// <summary>
		/// 융자잔고율
		/// </summary>
		[XAQueryFieldAttribute("융자잔고율")]
		public float yjrate;
		/// <summary>
		/// 융자신규금액
		/// </summary>
		[XAQueryFieldAttribute("융자신규금액")]
		public long ynprice;
		/// <summary>
		/// 융자상환금액
		/// </summary>
		[XAQueryFieldAttribute("융자상환금액")]
		public long ysprice;
		/// <summary>
		/// 융자잔고금액
		/// </summary>
		[XAQueryFieldAttribute("융자잔고금액")]
		public long yjprice;
		/// <summary>
		/// 융자금액대비
		/// </summary>
		[XAQueryFieldAttribute("융자금액대비")]
		public long yachange;
		/// <summary>
		/// 대주신규수량
		/// </summary>
		[XAQueryFieldAttribute("대주신규수량")]
		public long dnvolume;
		/// <summary>
		/// 대주상환수량
		/// </summary>
		[XAQueryFieldAttribute("대주상환수량")]
		public long dsvolume;
		/// <summary>
		/// 대주잔고수량
		/// </summary>
		[XAQueryFieldAttribute("대주잔고수량")]
		public long djvolume;
		/// <summary>
		/// 대주수량대비
		/// </summary>
		[XAQueryFieldAttribute("대주수량대비")]
		public long dvchange;
		/// <summary>
		/// 대주공여율
		/// </summary>
		[XAQueryFieldAttribute("대주공여율")]
		public float dgrate;
		/// <summary>
		/// 대주잔고율
		/// </summary>
		[XAQueryFieldAttribute("대주잔고율")]
		public float djrate;
		/// <summary>
		/// 대주신규금액
		/// </summary>
		[XAQueryFieldAttribute("대주신규금액")]
		public long dnprice;
		/// <summary>
		/// 대주상환금액
		/// </summary>
		[XAQueryFieldAttribute("대주상환금액")]
		public long dsprice;
		/// <summary>
		/// 대주잔고금액
		/// </summary>
		[XAQueryFieldAttribute("대주잔고금액")]
		public long djprice;
		/// <summary>
		/// 대주금액대비
		/// </summary>
		[XAQueryFieldAttribute("대주금액대비")]
		public long dachange;
		/// <summary>
		/// 결제일
		/// </summary>
		[XAQueryFieldAttribute("결제일")]
		public string mmdate;
		/// <summary>
		/// 결제일종가
		/// </summary>
		[XAQueryFieldAttribute("결제일종가")]
		public long close;
		/// <summary>
		/// 결제일거래량
		/// </summary>
		[XAQueryFieldAttribute("결제일거래량")]
		public long volume;
		/// <summary>
		/// 결제일거래대금
		/// </summary>
		[XAQueryFieldAttribute("결제일거래대금")]
		public long value;
		/// <summary>
		/// 주가5일증가율
		/// </summary>
		[XAQueryFieldAttribute("주가5일증가율")]
		public float pr5days;
		/// <summary>
		/// 주가20일증가율
		/// </summary>
		[XAQueryFieldAttribute("주가20일증가율")]
		public float pr20days;
		/// <summary>
		/// 융자5일증가율
		/// </summary>
		[XAQueryFieldAttribute("융자5일증가율")]
		public float yj5days;
		/// <summary>
		/// 융자20일증가율
		/// </summary>
		[XAQueryFieldAttribute("융자20일증가율")]
		public float yj20days;
		/// <summary>
		/// 대주5일증가율
		/// </summary>
		[XAQueryFieldAttribute("대주5일증가율")]
		public float dj5days;
		/// <summary>
		/// 대주20일증가율
		/// </summary>
		[XAQueryFieldAttribute("대주20일증가율")]
		public float dj20days;

		public static class F
		{
			/// <summary>
			/// 융자신규수량
			/// </summary>
			public const string ynvolume = "ynvolume";
			/// <summary>
			/// 융자상환수량
			/// </summary>
			public const string ysvolume = "ysvolume";
			/// <summary>
			/// 융자잔고수량
			/// </summary>
			public const string yjvolume = "yjvolume";
			/// <summary>
			/// 융자수량대비
			/// </summary>
			public const string yvchange = "yvchange";
			/// <summary>
			/// 융자공여율
			/// </summary>
			public const string ygrate = "ygrate";
			/// <summary>
			/// 융자잔고율
			/// </summary>
			public const string yjrate = "yjrate";
			/// <summary>
			/// 융자신규금액
			/// </summary>
			public const string ynprice = "ynprice";
			/// <summary>
			/// 융자상환금액
			/// </summary>
			public const string ysprice = "ysprice";
			/// <summary>
			/// 융자잔고금액
			/// </summary>
			public const string yjprice = "yjprice";
			/// <summary>
			/// 융자금액대비
			/// </summary>
			public const string yachange = "yachange";
			/// <summary>
			/// 대주신규수량
			/// </summary>
			public const string dnvolume = "dnvolume";
			/// <summary>
			/// 대주상환수량
			/// </summary>
			public const string dsvolume = "dsvolume";
			/// <summary>
			/// 대주잔고수량
			/// </summary>
			public const string djvolume = "djvolume";
			/// <summary>
			/// 대주수량대비
			/// </summary>
			public const string dvchange = "dvchange";
			/// <summary>
			/// 대주공여율
			/// </summary>
			public const string dgrate = "dgrate";
			/// <summary>
			/// 대주잔고율
			/// </summary>
			public const string djrate = "djrate";
			/// <summary>
			/// 대주신규금액
			/// </summary>
			public const string dnprice = "dnprice";
			/// <summary>
			/// 대주상환금액
			/// </summary>
			public const string dsprice = "dsprice";
			/// <summary>
			/// 대주잔고금액
			/// </summary>
			public const string djprice = "djprice";
			/// <summary>
			/// 대주금액대비
			/// </summary>
			public const string dachange = "dachange";
			/// <summary>
			/// 결제일
			/// </summary>
			public const string mmdate = "mmdate";
			/// <summary>
			/// 결제일종가
			/// </summary>
			public const string close = "close";
			/// <summary>
			/// 결제일거래량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// 결제일거래대금
			/// </summary>
			public const string value = "value";
			/// <summary>
			/// 주가5일증가율
			/// </summary>
			public const string pr5days = "pr5days";
			/// <summary>
			/// 주가20일증가율
			/// </summary>
			public const string pr20days = "pr20days";
			/// <summary>
			/// 융자5일증가율
			/// </summary>
			public const string yj5days = "yj5days";
			/// <summary>
			/// 융자20일증가율
			/// </summary>
			public const string yj20days = "yj20days";
			/// <summary>
			/// 대주5일증가율
			/// </summary>
			public const string dj5days = "dj5days";
			/// <summary>
			/// 대주20일증가율
			/// </summary>
			public const string dj20days = "dj20days";
		}

		public static string[] AllFields = new string[]
		{
			F.ynvolume,
			F.ysvolume,
			F.yjvolume,
			F.yvchange,
			F.ygrate,
			F.yjrate,
			F.ynprice,
			F.ysprice,
			F.yjprice,
			F.yachange,
			F.dnvolume,
			F.dsvolume,
			F.djvolume,
			F.dvchange,
			F.dgrate,
			F.djrate,
			F.dnprice,
			F.dsprice,
			F.djprice,
			F.dachange,
			F.mmdate,
			F.close,
			F.volume,
			F.value,
			F.pr5days,
			F.pr20days,
			F.yj5days,
			F.yj20days,
			F.dj5days,
			F.dj20days,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["ynvolume"] = new XAQueryFieldInfo("long", ynvolume, ynvolume.ToString("d8"), "융자신규수량", (decimal)8);
			dict["ysvolume"] = new XAQueryFieldInfo("long", ysvolume, ysvolume.ToString("d8"), "융자상환수량", (decimal)8);
			dict["yjvolume"] = new XAQueryFieldInfo("long", yjvolume, yjvolume.ToString("d8"), "융자잔고수량", (decimal)8);
			dict["yvchange"] = new XAQueryFieldInfo("long", yvchange, yvchange.ToString("d8"), "융자수량대비", (decimal)8);
			dict["ygrate"] = new XAQueryFieldInfo("float", ygrate, ygrate.ToString("000000000.00"), "융자공여율", (decimal)9.2);
			dict["yjrate"] = new XAQueryFieldInfo("float", yjrate, yjrate.ToString("000000000.00"), "융자잔고율", (decimal)9.2);
			dict["ynprice"] = new XAQueryFieldInfo("long", ynprice, ynprice.ToString("d8"), "융자신규금액", (decimal)8);
			dict["ysprice"] = new XAQueryFieldInfo("long", ysprice, ysprice.ToString("d8"), "융자상환금액", (decimal)8);
			dict["yjprice"] = new XAQueryFieldInfo("long", yjprice, yjprice.ToString("d8"), "융자잔고금액", (decimal)8);
			dict["yachange"] = new XAQueryFieldInfo("long", yachange, yachange.ToString("d8"), "융자금액대비", (decimal)8);
			dict["dnvolume"] = new XAQueryFieldInfo("long", dnvolume, dnvolume.ToString("d8"), "대주신규수량", (decimal)8);
			dict["dsvolume"] = new XAQueryFieldInfo("long", dsvolume, dsvolume.ToString("d8"), "대주상환수량", (decimal)8);
			dict["djvolume"] = new XAQueryFieldInfo("long", djvolume, djvolume.ToString("d8"), "대주잔고수량", (decimal)8);
			dict["dvchange"] = new XAQueryFieldInfo("long", dvchange, dvchange.ToString("d8"), "대주수량대비", (decimal)8);
			dict["dgrate"] = new XAQueryFieldInfo("float", dgrate, dgrate.ToString("000000000.00"), "대주공여율", (decimal)9.2);
			dict["djrate"] = new XAQueryFieldInfo("float", djrate, djrate.ToString("000000000.00"), "대주잔고율", (decimal)9.2);
			dict["dnprice"] = new XAQueryFieldInfo("long", dnprice, dnprice.ToString("d8"), "대주신규금액", (decimal)8);
			dict["dsprice"] = new XAQueryFieldInfo("long", dsprice, dsprice.ToString("d8"), "대주상환금액", (decimal)8);
			dict["djprice"] = new XAQueryFieldInfo("long", djprice, djprice.ToString("d8"), "대주잔고금액", (decimal)8);
			dict["dachange"] = new XAQueryFieldInfo("long", dachange, dachange.ToString("d8"), "대주금액대비", (decimal)8);
			dict["mmdate"] = new XAQueryFieldInfo("char", mmdate, mmdate, "결제일", (decimal)8);
			dict["close"] = new XAQueryFieldInfo("long", close, close.ToString("d8"), "결제일종가", (decimal)8);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d10"), "결제일거래량", (decimal)10);
			dict["value"] = new XAQueryFieldInfo("long", value, value.ToString("d12"), "결제일거래대금", (decimal)12);
			dict["pr5days"] = new XAQueryFieldInfo("float", pr5days, pr5days.ToString("000000000.00"), "주가5일증가율", (decimal)9.2);
			dict["pr20days"] = new XAQueryFieldInfo("float", pr20days, pr20days.ToString("000000000.00"), "주가20일증가율", (decimal)9.2);
			dict["yj5days"] = new XAQueryFieldInfo("float", yj5days, yj5days.ToString("000000000.00"), "융자5일증가율", (decimal)9.2);
			dict["yj20days"] = new XAQueryFieldInfo("float", yj20days, yj20days.ToString("000000000.00"), "융자20일증가율", (decimal)9.2);
			dict["dj5days"] = new XAQueryFieldInfo("float", dj5days, dj5days.ToString("000000000.00"), "대주5일증가율", (decimal)9.2);
			dict["dj20days"] = new XAQueryFieldInfo("float", dj20days, dj20days.ToString("000000000.00"), "대주20일증가율", (decimal)9.2);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "ynvolume":
					this.ynvolume = fieldInfo.FieldValue.ParseLong("ynvolume");
				break;

				case "ysvolume":
					this.ysvolume = fieldInfo.FieldValue.ParseLong("ysvolume");
				break;

				case "yjvolume":
					this.yjvolume = fieldInfo.FieldValue.ParseLong("yjvolume");
				break;

				case "yvchange":
					this.yvchange = fieldInfo.FieldValue.ParseLong("yvchange");
				break;

				case "ygrate":
					this.ygrate = fieldInfo.FieldValue.ParseFloat("ygrate");
				break;

				case "yjrate":
					this.yjrate = fieldInfo.FieldValue.ParseFloat("yjrate");
				break;

				case "ynprice":
					this.ynprice = fieldInfo.FieldValue.ParseLong("ynprice");
				break;

				case "ysprice":
					this.ysprice = fieldInfo.FieldValue.ParseLong("ysprice");
				break;

				case "yjprice":
					this.yjprice = fieldInfo.FieldValue.ParseLong("yjprice");
				break;

				case "yachange":
					this.yachange = fieldInfo.FieldValue.ParseLong("yachange");
				break;

				case "dnvolume":
					this.dnvolume = fieldInfo.FieldValue.ParseLong("dnvolume");
				break;

				case "dsvolume":
					this.dsvolume = fieldInfo.FieldValue.ParseLong("dsvolume");
				break;

				case "djvolume":
					this.djvolume = fieldInfo.FieldValue.ParseLong("djvolume");
				break;

				case "dvchange":
					this.dvchange = fieldInfo.FieldValue.ParseLong("dvchange");
				break;

				case "dgrate":
					this.dgrate = fieldInfo.FieldValue.ParseFloat("dgrate");
				break;

				case "djrate":
					this.djrate = fieldInfo.FieldValue.ParseFloat("djrate");
				break;

				case "dnprice":
					this.dnprice = fieldInfo.FieldValue.ParseLong("dnprice");
				break;

				case "dsprice":
					this.dsprice = fieldInfo.FieldValue.ParseLong("dsprice");
				break;

				case "djprice":
					this.djprice = fieldInfo.FieldValue.ParseLong("djprice");
				break;

				case "dachange":
					this.dachange = fieldInfo.FieldValue.ParseLong("dachange");
				break;

				case "mmdate":
					this.mmdate = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "close":
					this.close = fieldInfo.FieldValue.ParseLong("close");
				break;

				case "volume":
					this.volume = fieldInfo.FieldValue.ParseLong("volume");
				break;

				case "value":
					this.value = fieldInfo.FieldValue.ParseLong("value");
				break;

				case "pr5days":
					this.pr5days = fieldInfo.FieldValue.ParseFloat("pr5days");
				break;

				case "pr20days":
					this.pr20days = fieldInfo.FieldValue.ParseFloat("pr20days");
				break;

				case "yj5days":
					this.yj5days = fieldInfo.FieldValue.ParseFloat("yj5days");
				break;

				case "yj20days":
					this.yj20days = fieldInfo.FieldValue.ParseFloat("yj20days");
				break;

				case "dj5days":
					this.dj5days = fieldInfo.FieldValue.ParseFloat("dj5days");
				break;

				case "dj20days":
					this.dj20days = fieldInfo.FieldValue.ParseFloat("dj20days");
				break;


			}
		}

		public static XQt1926OutBlock FromQuery(XQt1926 query)
		{
			XQt1926OutBlock block = new XQt1926OutBlock();
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
				block.ynvolume = query.GetFieldData(block.GetBlockName(), "ynvolume", 0).ParseLong("ynvolume"); // long 8
				block.ysvolume = query.GetFieldData(block.GetBlockName(), "ysvolume", 0).ParseLong("ysvolume"); // long 8
				block.yjvolume = query.GetFieldData(block.GetBlockName(), "yjvolume", 0).ParseLong("yjvolume"); // long 8
				block.yvchange = query.GetFieldData(block.GetBlockName(), "yvchange", 0).ParseLong("yvchange"); // long 8
				block.ygrate = query.GetFieldData(block.GetBlockName(), "ygrate", 0).ParseFloat("ygrate"); // float 9.2
				block.yjrate = query.GetFieldData(block.GetBlockName(), "yjrate", 0).ParseFloat("yjrate"); // float 9.2
				block.ynprice = query.GetFieldData(block.GetBlockName(), "ynprice", 0).ParseLong("ynprice"); // long 8
				block.ysprice = query.GetFieldData(block.GetBlockName(), "ysprice", 0).ParseLong("ysprice"); // long 8
				block.yjprice = query.GetFieldData(block.GetBlockName(), "yjprice", 0).ParseLong("yjprice"); // long 8
				block.yachange = query.GetFieldData(block.GetBlockName(), "yachange", 0).ParseLong("yachange"); // long 8
				block.dnvolume = query.GetFieldData(block.GetBlockName(), "dnvolume", 0).ParseLong("dnvolume"); // long 8
				block.dsvolume = query.GetFieldData(block.GetBlockName(), "dsvolume", 0).ParseLong("dsvolume"); // long 8
				block.djvolume = query.GetFieldData(block.GetBlockName(), "djvolume", 0).ParseLong("djvolume"); // long 8
				block.dvchange = query.GetFieldData(block.GetBlockName(), "dvchange", 0).ParseLong("dvchange"); // long 8
				block.dgrate = query.GetFieldData(block.GetBlockName(), "dgrate", 0).ParseFloat("dgrate"); // float 9.2
				block.djrate = query.GetFieldData(block.GetBlockName(), "djrate", 0).ParseFloat("djrate"); // float 9.2
				block.dnprice = query.GetFieldData(block.GetBlockName(), "dnprice", 0).ParseLong("dnprice"); // long 8
				block.dsprice = query.GetFieldData(block.GetBlockName(), "dsprice", 0).ParseLong("dsprice"); // long 8
				block.djprice = query.GetFieldData(block.GetBlockName(), "djprice", 0).ParseLong("djprice"); // long 8
				block.dachange = query.GetFieldData(block.GetBlockName(), "dachange", 0).ParseLong("dachange"); // long 8
				block.mmdate = query.GetFieldData(block.GetBlockName(), "mmdate", 0).TrimEnd('?'); // char 8
				block.close = query.GetFieldData(block.GetBlockName(), "close", 0).ParseLong("close"); // long 8
				block.volume = query.GetFieldData(block.GetBlockName(), "volume", 0).ParseLong("volume"); // long 10
				block.value = query.GetFieldData(block.GetBlockName(), "value", 0).ParseLong("value"); // long 12
				block.pr5days = query.GetFieldData(block.GetBlockName(), "pr5days", 0).ParseFloat("pr5days"); // float 9.2
				block.pr20days = query.GetFieldData(block.GetBlockName(), "pr20days", 0).ParseFloat("pr20days"); // float 9.2
				block.yj5days = query.GetFieldData(block.GetBlockName(), "yj5days", 0).ParseFloat("yj5days"); // float 9.2
				block.yj20days = query.GetFieldData(block.GetBlockName(), "yj20days", 0).ParseFloat("yj20days"); // float 9.2
				block.dj5days = query.GetFieldData(block.GetBlockName(), "dj5days", 0).ParseFloat("dj5days"); // float 9.2
				block.dj20days = query.GetFieldData(block.GetBlockName(), "dj20days", 0).ParseFloat("dj20days"); // float 9.2

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (ynvolume.ToString().Length > 8) return false; // long 8
			if (ysvolume.ToString().Length > 8) return false; // long 8
			if (yjvolume.ToString().Length > 8) return false; // long 8
			if (yvchange.ToString().Length > 8) return false; // long 8
			// ygrate float 9.2
			// yjrate float 9.2
			if (ynprice.ToString().Length > 8) return false; // long 8
			if (ysprice.ToString().Length > 8) return false; // long 8
			if (yjprice.ToString().Length > 8) return false; // long 8
			if (yachange.ToString().Length > 8) return false; // long 8
			if (dnvolume.ToString().Length > 8) return false; // long 8
			if (dsvolume.ToString().Length > 8) return false; // long 8
			if (djvolume.ToString().Length > 8) return false; // long 8
			if (dvchange.ToString().Length > 8) return false; // long 8
			// dgrate float 9.2
			// djrate float 9.2
			if (dnprice.ToString().Length > 8) return false; // long 8
			if (dsprice.ToString().Length > 8) return false; // long 8
			if (djprice.ToString().Length > 8) return false; // long 8
			if (dachange.ToString().Length > 8) return false; // long 8
			if (mmdate?.Length > 8) return false; // char 8
			if (close.ToString().Length > 8) return false; // long 8
			if (volume.ToString().Length > 10) return false; // long 10
			if (value.ToString().Length > 12) return false; // long 12
			// pr5days float 9.2
			// pr20days float 9.2
			// yj5days float 9.2
			// yj20days float 9.2
			// dj5days float 9.2
			// dj20days float 9.2

			return true;
		}
	}

	public partial class XQt1926 : XingQuery
	{
		/// <summary>
		/// t1926
		/// </summary>
		public const string _typeName = "t1926";
		/// <summary>
		/// 종목별신용정보(t1926)
		/// </summary>
		public const string _typeDesc = "종목별신용정보(t1926)";
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
		/// t1926
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 종목별신용정보(t1926)
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

		public XQt1926() : base("t1926") { }


		public bool SetFields(XQt1926InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "shcode", 0, block.shcode); // char 6

			return true;
		}

		public XQt1926OutBlock GetBlock()
		{
			XQt1926OutBlock instance = XQt1926OutBlock.FromQuery(this);
			return instance;

		}


	}

}
