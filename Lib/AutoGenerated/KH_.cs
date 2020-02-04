using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XRKH_InBlock : XingBlock
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

	public partial class XRKH_OutBlock : XingBlock
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
		/// 현재가
		/// </summary>
		[XAQueryFieldAttribute("현재가")]
		public long price;
		/// <summary>
		/// 전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("전일대비구분")]
		public long sign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[XAQueryFieldAttribute("전일대비")]
		public long change;
		/// <summary>
		/// 누적거래량
		/// </summary>
		[XAQueryFieldAttribute("누적거래량")]
		public long volume;
		/// <summary>
		/// 등락율
		/// </summary>
		[XAQueryFieldAttribute("등락율")]
		public float drate;
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
		/// 전체매도위탁체결수량
		/// </summary>
		[XAQueryFieldAttribute("전체매도위탁체결수량")]
		public long dwcvolume;
		/// <summary>
		/// 전체매수위탁체결수량
		/// </summary>
		[XAQueryFieldAttribute("전체매수위탁체결수량")]
		public long swcvolume;
		/// <summary>
		/// 전체매도자기체결수량
		/// </summary>
		[XAQueryFieldAttribute("전체매도자기체결수량")]
		public long djcvolume;
		/// <summary>
		/// 전체매수자기체결수량
		/// </summary>
		[XAQueryFieldAttribute("전체매수자기체결수량")]
		public long sjcvolume;
		/// <summary>
		/// 전체매도체결수량
		/// </summary>
		[XAQueryFieldAttribute("전체매도체결수량")]
		public long tdvolume;
		/// <summary>
		/// 전체매수체결수량
		/// </summary>
		[XAQueryFieldAttribute("전체매수체결수량")]
		public long tsvolume;
		/// <summary>
		/// 전체순매수 수량
		/// </summary>
		[XAQueryFieldAttribute("전체순매수 수량")]
		public long tvol;
		/// <summary>
		/// 전체매도위탁체결금액
		/// </summary>
		[XAQueryFieldAttribute("전체매도위탁체결금액")]
		public long dwcvalue;
		/// <summary>
		/// 전체매수위탁체결금액
		/// </summary>
		[XAQueryFieldAttribute("전체매수위탁체결금액")]
		public long swcvalue;
		/// <summary>
		/// 전체매도자기체결금액
		/// </summary>
		[XAQueryFieldAttribute("전체매도자기체결금액")]
		public long djcvalue;
		/// <summary>
		/// 전체매수자기체결금액
		/// </summary>
		[XAQueryFieldAttribute("전체매수자기체결금액")]
		public long sjcvalue;
		/// <summary>
		/// 전체매도체결금액
		/// </summary>
		[XAQueryFieldAttribute("전체매도체결금액")]
		public long tdvalue;
		/// <summary>
		/// 전체매수체결금액
		/// </summary>
		[XAQueryFieldAttribute("전체매수체결금액")]
		public long tsvalue;
		/// <summary>
		/// 전체순매수 금액
		/// </summary>
		[XAQueryFieldAttribute("전체순매수 금액")]
		public long tval;
		/// <summary>
		/// 매도 사전공시수량
		/// </summary>
		[XAQueryFieldAttribute("매도 사전공시수량")]
		public long pdgvolume;
		/// <summary>
		/// 매수 사전공시수량
		/// </summary>
		[XAQueryFieldAttribute("매수 사전공시수량")]
		public long psgvolume;
		/// <summary>
		/// 종목코드
		/// </summary>
		[XAQueryFieldAttribute("종목코드")]
		public string shcode;

		public static class F
		{
			/// <summary>
			/// 수신시간
			/// </summary>
			public const string time = "time";
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
			/// 누적거래량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// 등락율
			/// </summary>
			public const string drate = "drate";
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
			/// 전체매도위탁체결수량
			/// </summary>
			public const string dwcvolume = "dwcvolume";
			/// <summary>
			/// 전체매수위탁체결수량
			/// </summary>
			public const string swcvolume = "swcvolume";
			/// <summary>
			/// 전체매도자기체결수량
			/// </summary>
			public const string djcvolume = "djcvolume";
			/// <summary>
			/// 전체매수자기체결수량
			/// </summary>
			public const string sjcvolume = "sjcvolume";
			/// <summary>
			/// 전체매도체결수량
			/// </summary>
			public const string tdvolume = "tdvolume";
			/// <summary>
			/// 전체매수체결수량
			/// </summary>
			public const string tsvolume = "tsvolume";
			/// <summary>
			/// 전체순매수 수량
			/// </summary>
			public const string tvol = "tvol";
			/// <summary>
			/// 전체매도위탁체결금액
			/// </summary>
			public const string dwcvalue = "dwcvalue";
			/// <summary>
			/// 전체매수위탁체결금액
			/// </summary>
			public const string swcvalue = "swcvalue";
			/// <summary>
			/// 전체매도자기체결금액
			/// </summary>
			public const string djcvalue = "djcvalue";
			/// <summary>
			/// 전체매수자기체결금액
			/// </summary>
			public const string sjcvalue = "sjcvalue";
			/// <summary>
			/// 전체매도체결금액
			/// </summary>
			public const string tdvalue = "tdvalue";
			/// <summary>
			/// 전체매수체결금액
			/// </summary>
			public const string tsvalue = "tsvalue";
			/// <summary>
			/// 전체순매수 금액
			/// </summary>
			public const string tval = "tval";
			/// <summary>
			/// 매도 사전공시수량
			/// </summary>
			public const string pdgvolume = "pdgvolume";
			/// <summary>
			/// 매수 사전공시수량
			/// </summary>
			public const string psgvolume = "psgvolume";
			/// <summary>
			/// 종목코드
			/// </summary>
			public const string shcode = "shcode";
		}

		public static string[] AllFields = new string[]
		{
			F.time,
			F.price,
			F.sign,
			F.change,
			F.volume,
			F.drate,
			F.cdhrem,
			F.cshrem,
			F.bdhrem,
			F.bshrem,
			F.cdhvolume,
			F.cshvolume,
			F.bdhvolume,
			F.bshvolume,
			F.dwcvolume,
			F.swcvolume,
			F.djcvolume,
			F.sjcvolume,
			F.tdvolume,
			F.tsvolume,
			F.tvol,
			F.dwcvalue,
			F.swcvalue,
			F.djcvalue,
			F.sjcvalue,
			F.tdvalue,
			F.tsvalue,
			F.tval,
			F.pdgvolume,
			F.psgvolume,
			F.shcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["time"] = new XAQueryFieldInfo("char", time, time, "수신시간", (decimal)6);
			dict["price"] = new XAQueryFieldInfo("long", price, price.ToString("d8"), "현재가", (decimal)8);
			dict["sign"] = new XAQueryFieldInfo("long", sign, sign.ToString("d1"), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("long", change, change.ToString("d8"), "전일대비", (decimal)8);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d10"), "누적거래량", (decimal)10);
			dict["drate"] = new XAQueryFieldInfo("float", drate, drate.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["cdhrem"] = new XAQueryFieldInfo("long", cdhrem, cdhrem.ToString("d9"), "차익매도호가 잔량", (decimal)9);
			dict["cshrem"] = new XAQueryFieldInfo("long", cshrem, cshrem.ToString("d9"), "차익매수호가 잔량", (decimal)9);
			dict["bdhrem"] = new XAQueryFieldInfo("long", bdhrem, bdhrem.ToString("d9"), "비차익매도호가 잔량", (decimal)9);
			dict["bshrem"] = new XAQueryFieldInfo("long", bshrem, bshrem.ToString("d9"), "비차익매수호가 잔량", (decimal)9);
			dict["cdhvolume"] = new XAQueryFieldInfo("long", cdhvolume, cdhvolume.ToString("d9"), "차익매도호가 수량", (decimal)9);
			dict["cshvolume"] = new XAQueryFieldInfo("long", cshvolume, cshvolume.ToString("d9"), "차익매수호가 수량", (decimal)9);
			dict["bdhvolume"] = new XAQueryFieldInfo("long", bdhvolume, bdhvolume.ToString("d9"), "비차익매도호가 수량", (decimal)9);
			dict["bshvolume"] = new XAQueryFieldInfo("long", bshvolume, bshvolume.ToString("d9"), "비차익매수호가 수량", (decimal)9);
			dict["dwcvolume"] = new XAQueryFieldInfo("long", dwcvolume, dwcvolume.ToString("d9"), "전체매도위탁체결수량", (decimal)9);
			dict["swcvolume"] = new XAQueryFieldInfo("long", swcvolume, swcvolume.ToString("d9"), "전체매수위탁체결수량", (decimal)9);
			dict["djcvolume"] = new XAQueryFieldInfo("long", djcvolume, djcvolume.ToString("d9"), "전체매도자기체결수량", (decimal)9);
			dict["sjcvolume"] = new XAQueryFieldInfo("long", sjcvolume, sjcvolume.ToString("d9"), "전체매수자기체결수량", (decimal)9);
			dict["tdvolume"] = new XAQueryFieldInfo("long", tdvolume, tdvolume.ToString("d9"), "전체매도체결수량", (decimal)9);
			dict["tsvolume"] = new XAQueryFieldInfo("long", tsvolume, tsvolume.ToString("d9"), "전체매수체결수량", (decimal)9);
			dict["tvol"] = new XAQueryFieldInfo("long", tvol, tvol.ToString("d9"), "전체순매수 수량", (decimal)9);
			dict["dwcvalue"] = new XAQueryFieldInfo("long", dwcvalue, dwcvalue.ToString("d12"), "전체매도위탁체결금액", (decimal)12);
			dict["swcvalue"] = new XAQueryFieldInfo("long", swcvalue, swcvalue.ToString("d12"), "전체매수위탁체결금액", (decimal)12);
			dict["djcvalue"] = new XAQueryFieldInfo("long", djcvalue, djcvalue.ToString("d12"), "전체매도자기체결금액", (decimal)12);
			dict["sjcvalue"] = new XAQueryFieldInfo("long", sjcvalue, sjcvalue.ToString("d12"), "전체매수자기체결금액", (decimal)12);
			dict["tdvalue"] = new XAQueryFieldInfo("long", tdvalue, tdvalue.ToString("d12"), "전체매도체결금액", (decimal)12);
			dict["tsvalue"] = new XAQueryFieldInfo("long", tsvalue, tsvalue.ToString("d12"), "전체매수체결금액", (decimal)12);
			dict["tval"] = new XAQueryFieldInfo("long", tval, tval.ToString("d12"), "전체순매수 금액", (decimal)12);
			dict["pdgvolume"] = new XAQueryFieldInfo("long", pdgvolume, pdgvolume.ToString("d9"), "매도 사전공시수량", (decimal)9);
			dict["psgvolume"] = new XAQueryFieldInfo("long", psgvolume, psgvolume.ToString("d9"), "매수 사전공시수량", (decimal)9);
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "종목코드", (decimal)6);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "time":
					this.time = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "price":
					this.price = fieldInfo.FieldValue.ParseLong("price");
				break;

				case "sign":
					this.sign = fieldInfo.FieldValue.ParseLong("sign");
				break;

				case "change":
					this.change = fieldInfo.FieldValue.ParseLong("change");
				break;

				case "volume":
					this.volume = fieldInfo.FieldValue.ParseLong("volume");
				break;

				case "drate":
					this.drate = fieldInfo.FieldValue.ParseFloat("drate");
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

				case "dwcvolume":
					this.dwcvolume = fieldInfo.FieldValue.ParseLong("dwcvolume");
				break;

				case "swcvolume":
					this.swcvolume = fieldInfo.FieldValue.ParseLong("swcvolume");
				break;

				case "djcvolume":
					this.djcvolume = fieldInfo.FieldValue.ParseLong("djcvolume");
				break;

				case "sjcvolume":
					this.sjcvolume = fieldInfo.FieldValue.ParseLong("sjcvolume");
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

				case "dwcvalue":
					this.dwcvalue = fieldInfo.FieldValue.ParseLong("dwcvalue");
				break;

				case "swcvalue":
					this.swcvalue = fieldInfo.FieldValue.ParseLong("swcvalue");
				break;

				case "djcvalue":
					this.djcvalue = fieldInfo.FieldValue.ParseLong("djcvalue");
				break;

				case "sjcvalue":
					this.sjcvalue = fieldInfo.FieldValue.ParseLong("sjcvalue");
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

				case "pdgvolume":
					this.pdgvolume = fieldInfo.FieldValue.ParseLong("pdgvolume");
				break;

				case "psgvolume":
					this.psgvolume = fieldInfo.FieldValue.ParseLong("psgvolume");
				break;

				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XRKH_OutBlock FromQuery(XRKH_ query)
		{
			XRKH_OutBlock block = new XRKH_OutBlock();
			block.IsValidData = true;
			block.InvalidReason = "";
			try
			{
				block.time = query.GetFieldData(block.GetBlockName(), "time").TrimEnd('?'); // char 6
				block.price = query.GetFieldData(block.GetBlockName(), "price").ParseLong("price"); // long 8
				block.sign = query.GetFieldData(block.GetBlockName(), "sign").ParseLong("sign"); // long 1
				block.change = query.GetFieldData(block.GetBlockName(), "change").ParseLong("change"); // long 8
				block.volume = query.GetFieldData(block.GetBlockName(), "volume").ParseLong("volume"); // long 10
				block.drate = query.GetFieldData(block.GetBlockName(), "drate").ParseFloat("drate"); // float 6.2
				block.cdhrem = query.GetFieldData(block.GetBlockName(), "cdhrem").ParseLong("cdhrem"); // long 9
				block.cshrem = query.GetFieldData(block.GetBlockName(), "cshrem").ParseLong("cshrem"); // long 9
				block.bdhrem = query.GetFieldData(block.GetBlockName(), "bdhrem").ParseLong("bdhrem"); // long 9
				block.bshrem = query.GetFieldData(block.GetBlockName(), "bshrem").ParseLong("bshrem"); // long 9
				block.cdhvolume = query.GetFieldData(block.GetBlockName(), "cdhvolume").ParseLong("cdhvolume"); // long 9
				block.cshvolume = query.GetFieldData(block.GetBlockName(), "cshvolume").ParseLong("cshvolume"); // long 9
				block.bdhvolume = query.GetFieldData(block.GetBlockName(), "bdhvolume").ParseLong("bdhvolume"); // long 9
				block.bshvolume = query.GetFieldData(block.GetBlockName(), "bshvolume").ParseLong("bshvolume"); // long 9
				block.dwcvolume = query.GetFieldData(block.GetBlockName(), "dwcvolume").ParseLong("dwcvolume"); // long 9
				block.swcvolume = query.GetFieldData(block.GetBlockName(), "swcvolume").ParseLong("swcvolume"); // long 9
				block.djcvolume = query.GetFieldData(block.GetBlockName(), "djcvolume").ParseLong("djcvolume"); // long 9
				block.sjcvolume = query.GetFieldData(block.GetBlockName(), "sjcvolume").ParseLong("sjcvolume"); // long 9
				block.tdvolume = query.GetFieldData(block.GetBlockName(), "tdvolume").ParseLong("tdvolume"); // long 9
				block.tsvolume = query.GetFieldData(block.GetBlockName(), "tsvolume").ParseLong("tsvolume"); // long 9
				block.tvol = query.GetFieldData(block.GetBlockName(), "tvol").ParseLong("tvol"); // long 9
				block.dwcvalue = query.GetFieldData(block.GetBlockName(), "dwcvalue").ParseLong("dwcvalue"); // long 12
				block.swcvalue = query.GetFieldData(block.GetBlockName(), "swcvalue").ParseLong("swcvalue"); // long 12
				block.djcvalue = query.GetFieldData(block.GetBlockName(), "djcvalue").ParseLong("djcvalue"); // long 12
				block.sjcvalue = query.GetFieldData(block.GetBlockName(), "sjcvalue").ParseLong("sjcvalue"); // long 12
				block.tdvalue = query.GetFieldData(block.GetBlockName(), "tdvalue").ParseLong("tdvalue"); // long 12
				block.tsvalue = query.GetFieldData(block.GetBlockName(), "tsvalue").ParseLong("tsvalue"); // long 12
				block.tval = query.GetFieldData(block.GetBlockName(), "tval").ParseLong("tval"); // long 12
				block.pdgvolume = query.GetFieldData(block.GetBlockName(), "pdgvolume").ParseLong("pdgvolume"); // long 9
				block.psgvolume = query.GetFieldData(block.GetBlockName(), "psgvolume").ParseLong("psgvolume"); // long 9
				block.shcode = query.GetFieldData(block.GetBlockName(), "shcode").TrimEnd('?'); // char 6

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (time?.Length > 6) return false; // char 6
			if (price.ToString().Length > 8) return false; // long 8
			if (sign.ToString().Length > 1) return false; // long 1
			if (change.ToString().Length > 8) return false; // long 8
			if (volume.ToString().Length > 10) return false; // long 10
			// drate float 6.2
			if (cdhrem.ToString().Length > 9) return false; // long 9
			if (cshrem.ToString().Length > 9) return false; // long 9
			if (bdhrem.ToString().Length > 9) return false; // long 9
			if (bshrem.ToString().Length > 9) return false; // long 9
			if (cdhvolume.ToString().Length > 9) return false; // long 9
			if (cshvolume.ToString().Length > 9) return false; // long 9
			if (bdhvolume.ToString().Length > 9) return false; // long 9
			if (bshvolume.ToString().Length > 9) return false; // long 9
			if (dwcvolume.ToString().Length > 9) return false; // long 9
			if (swcvolume.ToString().Length > 9) return false; // long 9
			if (djcvolume.ToString().Length > 9) return false; // long 9
			if (sjcvolume.ToString().Length > 9) return false; // long 9
			if (tdvolume.ToString().Length > 9) return false; // long 9
			if (tsvolume.ToString().Length > 9) return false; // long 9
			if (tvol.ToString().Length > 9) return false; // long 9
			if (dwcvalue.ToString().Length > 12) return false; // long 12
			if (swcvalue.ToString().Length > 12) return false; // long 12
			if (djcvalue.ToString().Length > 12) return false; // long 12
			if (sjcvalue.ToString().Length > 12) return false; // long 12
			if (tdvalue.ToString().Length > 12) return false; // long 12
			if (tsvalue.ToString().Length > 12) return false; // long 12
			if (tval.ToString().Length > 12) return false; // long 12
			if (pdgvolume.ToString().Length > 9) return false; // long 9
			if (psgvolume.ToString().Length > 9) return false; // long 9
			if (shcode?.Length > 6) return false; // char 6

			return true;
		}
	}

	public partial class XRKH_ : XingReal
	{
		/// <summary>
		/// KH_
		/// </summary>
		public const string _typeName = "KH_";
		/// <summary>
		/// KOSDAQ프로그램매매종목별(KH)
		/// </summary>
		public const string _typeDesc = "KOSDAQ프로그램매매종목별(KH)";
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
		/// KH_
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// KOSDAQ프로그램매매종목별(KH)
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

		public XRKH_() : base("KH_") { }


		public bool SetFields(XRKH_InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaReal.SetFieldData(block.GetBlockName(), "shcode", block.shcode); // char 6

			return true;
		}

		public XRKH_OutBlock GetBlock()
		{
			XRKH_OutBlock instance = XRKH_OutBlock.FromQuery(this);
			return instance;

		}


	}

}
