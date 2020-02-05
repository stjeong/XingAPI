using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1958InBlock : XingBlock
	{
		/// <summary>
		/// t1958InBlock
		/// </summary>
		public const string _blockName = "t1958InBlock";
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
		/// t1958InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1958InBlock
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
		/// 종목코드1
		/// </summary>
		[XAQueryFieldAttribute("종목코드1")]
		public string shcode1;
		/// <summary>
		/// 종목코드2
		/// </summary>
		[XAQueryFieldAttribute("종목코드2")]
		public string shcode2;

		public static class F
		{
			/// <summary>
			/// 종목코드1
			/// </summary>
			public const string shcode1 = "shcode1";
			/// <summary>
			/// 종목코드2
			/// </summary>
			public const string shcode2 = "shcode2";
		}

		public static string[] AllFields = new string[]
		{
			F.shcode1,
			F.shcode2,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["shcode1"] = new XAQueryFieldInfo("char", shcode1, shcode1, "종목코드1", (decimal)6);
			dict["shcode2"] = new XAQueryFieldInfo("char", shcode2, shcode2, "종목코드2", (decimal)6);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "shcode1":
					this.shcode1 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "shcode2":
					this.shcode2 = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (shcode1?.Length > 6) return false; // char 6
			if (shcode2?.Length > 6) return false; // char 6

			return true;
		}
	}

	public partial class XQt1958OutBlock : XingBlock
	{
		/// <summary>
		/// t1958OutBlock
		/// </summary>
		public const string _blockName = "t1958OutBlock";
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
		/// t1958OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1958OutBlock
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
		/// 종목명
		/// </summary>
		[XAQueryFieldAttribute("종목명")]
		public string hname;
		/// <summary>
		/// 기초자산
		/// </summary>
		[XAQueryFieldAttribute("기초자산")]
		public string item1;
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
		/// 행사방식
		/// </summary>
		[XAQueryFieldAttribute("행사방식")]
		public string elwtype;
		/// <summary>
		/// 결제방법
		/// </summary>
		[XAQueryFieldAttribute("결제방법")]
		public string settletype;
		/// <summary>
		/// 행사가
		/// </summary>
		[XAQueryFieldAttribute("행사가")]
		public float elwexec;
		/// <summary>
		/// 전환비율
		/// </summary>
		[XAQueryFieldAttribute("전환비율")]
		public float convrate;
		/// <summary>
		/// 발행수량
		/// </summary>
		[XAQueryFieldAttribute("발행수량")]
		public float listing;
		/// <summary>
		/// 행사개시일
		/// </summary>
		[XAQueryFieldAttribute("행사개시일")]
		public string mmsdate;
		/// <summary>
		/// 최종거래일
		/// </summary>
		[XAQueryFieldAttribute("최종거래일")]
		public string lastdate;
		/// <summary>
		/// 거래잔존일수
		/// </summary>
		[XAQueryFieldAttribute("거래잔존일수")]
		public long nofdays;
		/// <summary>
		/// 지급일
		/// </summary>
		[XAQueryFieldAttribute("지급일")]
		public string payday;
		/// <summary>
		/// 패리티
		/// </summary>
		[XAQueryFieldAttribute("패리티")]
		public float parity;
		/// <summary>
		/// 프리미엄
		/// </summary>
		[XAQueryFieldAttribute("프리미엄")]
		public float premium;
		/// <summary>
		/// 손익분기
		/// </summary>
		[XAQueryFieldAttribute("손익분기")]
		public float berate;
		/// <summary>
		/// 자본지지
		/// </summary>
		[XAQueryFieldAttribute("자본지지")]
		public float capt;
		/// <summary>
		/// 기어링
		/// </summary>
		[XAQueryFieldAttribute("기어링")]
		public float gearing;
		/// <summary>
		/// e.기어링
		/// </summary>
		[XAQueryFieldAttribute("e.기어링")]
		public float egearing;
		/// <summary>
		/// 가격
		/// </summary>
		[XAQueryFieldAttribute("가격")]
		public long price;
		/// <summary>
		/// 거래량
		/// </summary>
		[XAQueryFieldAttribute("거래량")]
		public float volume;
		/// <summary>
		/// 등락율
		/// </summary>
		[XAQueryFieldAttribute("등락율")]
		public float diff;

		public static class F
		{
			/// <summary>
			/// 종목명
			/// </summary>
			public const string hname = "hname";
			/// <summary>
			/// 기초자산
			/// </summary>
			public const string item1 = "item1";
			/// <summary>
			/// 발행사
			/// </summary>
			public const string issuernmk = "issuernmk";
			/// <summary>
			/// 콜풋구분
			/// </summary>
			public const string elwopt = "elwopt";
			/// <summary>
			/// 행사방식
			/// </summary>
			public const string elwtype = "elwtype";
			/// <summary>
			/// 결제방법
			/// </summary>
			public const string settletype = "settletype";
			/// <summary>
			/// 행사가
			/// </summary>
			public const string elwexec = "elwexec";
			/// <summary>
			/// 전환비율
			/// </summary>
			public const string convrate = "convrate";
			/// <summary>
			/// 발행수량
			/// </summary>
			public const string listing = "listing";
			/// <summary>
			/// 행사개시일
			/// </summary>
			public const string mmsdate = "mmsdate";
			/// <summary>
			/// 최종거래일
			/// </summary>
			public const string lastdate = "lastdate";
			/// <summary>
			/// 거래잔존일수
			/// </summary>
			public const string nofdays = "nofdays";
			/// <summary>
			/// 지급일
			/// </summary>
			public const string payday = "payday";
			/// <summary>
			/// 패리티
			/// </summary>
			public const string parity = "parity";
			/// <summary>
			/// 프리미엄
			/// </summary>
			public const string premium = "premium";
			/// <summary>
			/// 손익분기
			/// </summary>
			public const string berate = "berate";
			/// <summary>
			/// 자본지지
			/// </summary>
			public const string capt = "capt";
			/// <summary>
			/// 기어링
			/// </summary>
			public const string gearing = "gearing";
			/// <summary>
			/// e.기어링
			/// </summary>
			public const string egearing = "egearing";
			/// <summary>
			/// 가격
			/// </summary>
			public const string price = "price";
			/// <summary>
			/// 거래량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// 등락율
			/// </summary>
			public const string diff = "diff";
		}

		public static string[] AllFields = new string[]
		{
			F.hname,
			F.item1,
			F.issuernmk,
			F.elwopt,
			F.elwtype,
			F.settletype,
			F.elwexec,
			F.convrate,
			F.listing,
			F.mmsdate,
			F.lastdate,
			F.nofdays,
			F.payday,
			F.parity,
			F.premium,
			F.berate,
			F.capt,
			F.gearing,
			F.egearing,
			F.price,
			F.volume,
			F.diff,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["hname"] = new XAQueryFieldInfo("char", hname, hname, "종목명", (decimal)40);
			dict["item1"] = new XAQueryFieldInfo("char", item1, item1, "기초자산", (decimal)12);
			dict["issuernmk"] = new XAQueryFieldInfo("char", issuernmk, issuernmk, "발행사", (decimal)40);
			dict["elwopt"] = new XAQueryFieldInfo("char", elwopt, elwopt, "콜풋구분", (decimal)2);
			dict["elwtype"] = new XAQueryFieldInfo("char", elwtype, elwtype, "행사방식", (decimal)2);
			dict["settletype"] = new XAQueryFieldInfo("char", settletype, settletype, "결제방법", (decimal)2);
			dict["elwexec"] = new XAQueryFieldInfo("float", elwexec, elwexec.ToString("00000000.00"), "행사가", (decimal)8.2);
			dict["convrate"] = new XAQueryFieldInfo("float", convrate, convrate.ToString("000000000000.0000"), "전환비율", (decimal)12.4);
			dict["listing"] = new XAQueryFieldInfo("float", listing, listing.ToString("000000000000"), "발행수량", (decimal)12);
			dict["mmsdate"] = new XAQueryFieldInfo("char", mmsdate, mmsdate, "행사개시일", (decimal)8);
			dict["lastdate"] = new XAQueryFieldInfo("char", lastdate, lastdate, "최종거래일", (decimal)8);
			dict["nofdays"] = new XAQueryFieldInfo("long", nofdays, nofdays.ToString("d4"), "거래잔존일수", (decimal)4);
			dict["payday"] = new XAQueryFieldInfo("char", payday, payday, "지급일", (decimal)8);
			dict["parity"] = new XAQueryFieldInfo("float", parity, parity.ToString("000000.00"), "패리티", (decimal)6.2);
			dict["premium"] = new XAQueryFieldInfo("float", premium, premium.ToString("000000.00"), "프리미엄", (decimal)6.2);
			dict["berate"] = new XAQueryFieldInfo("float", berate, berate.ToString("000000.00"), "손익분기", (decimal)6.2);
			dict["capt"] = new XAQueryFieldInfo("float", capt, capt.ToString("000000.00"), "자본지지", (decimal)6.2);
			dict["gearing"] = new XAQueryFieldInfo("float", gearing, gearing.ToString("000000.00"), "기어링", (decimal)6.2);
			dict["egearing"] = new XAQueryFieldInfo("float", egearing, egearing.ToString("000000.00"), "e.기어링", (decimal)6.2);
			dict["price"] = new XAQueryFieldInfo("long", price, price.ToString("d8"), "가격", (decimal)8);
			dict["volume"] = new XAQueryFieldInfo("float", volume, volume.ToString("000000000000"), "거래량", (decimal)12);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "등락율", (decimal)6.2);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "hname":
					this.hname = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "item1":
					this.item1 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "issuernmk":
					this.issuernmk = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "elwopt":
					this.elwopt = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "elwtype":
					this.elwtype = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "settletype":
					this.settletype = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "elwexec":
					this.elwexec = fieldInfo.FieldValue.ParseFloat("elwexec");
				break;

				case "convrate":
					this.convrate = fieldInfo.FieldValue.ParseFloat("convrate");
				break;

				case "listing":
					this.listing = fieldInfo.FieldValue.ParseFloat("listing");
				break;

				case "mmsdate":
					this.mmsdate = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "lastdate":
					this.lastdate = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "nofdays":
					this.nofdays = fieldInfo.FieldValue.ParseLong("nofdays");
				break;

				case "payday":
					this.payday = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "parity":
					this.parity = fieldInfo.FieldValue.ParseFloat("parity");
				break;

				case "premium":
					this.premium = fieldInfo.FieldValue.ParseFloat("premium");
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

				case "price":
					this.price = fieldInfo.FieldValue.ParseLong("price");
				break;

				case "volume":
					this.volume = fieldInfo.FieldValue.ParseFloat("volume");
				break;

				case "diff":
					this.diff = fieldInfo.FieldValue.ParseFloat("diff");
				break;


			}
		}

		public static XQt1958OutBlock FromQuery(XQt1958 query)
		{
			XQt1958OutBlock block = new XQt1958OutBlock();
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
				block.item1 = query.GetFieldData(block.GetBlockName(), "item1", 0).TrimEnd('?'); // char 12
				block.issuernmk = query.GetFieldData(block.GetBlockName(), "issuernmk", 0).TrimEnd('?'); // char 40
				block.elwopt = query.GetFieldData(block.GetBlockName(), "elwopt", 0).TrimEnd('?'); // char 2
				block.elwtype = query.GetFieldData(block.GetBlockName(), "elwtype", 0).TrimEnd('?'); // char 2
				block.settletype = query.GetFieldData(block.GetBlockName(), "settletype", 0).TrimEnd('?'); // char 2
				block.elwexec = query.GetFieldData(block.GetBlockName(), "elwexec", 0).ParseFloat("elwexec"); // float 8.2
				block.convrate = query.GetFieldData(block.GetBlockName(), "convrate", 0).ParseFloat("convrate"); // float 12.4
				block.listing = query.GetFieldData(block.GetBlockName(), "listing", 0).ParseFloat("listing"); // float 12
				block.mmsdate = query.GetFieldData(block.GetBlockName(), "mmsdate", 0).TrimEnd('?'); // char 8
				block.lastdate = query.GetFieldData(block.GetBlockName(), "lastdate", 0).TrimEnd('?'); // char 8
				block.nofdays = query.GetFieldData(block.GetBlockName(), "nofdays", 0).ParseLong("nofdays"); // long 4
				block.payday = query.GetFieldData(block.GetBlockName(), "payday", 0).TrimEnd('?'); // char 8
				block.parity = query.GetFieldData(block.GetBlockName(), "parity", 0).ParseFloat("parity"); // float 6.2
				block.premium = query.GetFieldData(block.GetBlockName(), "premium", 0).ParseFloat("premium"); // float 6.2
				block.berate = query.GetFieldData(block.GetBlockName(), "berate", 0).ParseFloat("berate"); // float 6.2
				block.capt = query.GetFieldData(block.GetBlockName(), "capt", 0).ParseFloat("capt"); // float 6.2
				block.gearing = query.GetFieldData(block.GetBlockName(), "gearing", 0).ParseFloat("gearing"); // float 6.2
				block.egearing = query.GetFieldData(block.GetBlockName(), "egearing", 0).ParseFloat("egearing"); // float 6.2
				block.price = query.GetFieldData(block.GetBlockName(), "price", 0).ParseLong("price"); // long 8
				block.volume = query.GetFieldData(block.GetBlockName(), "volume", 0).ParseFloat("volume"); // float 12
				block.diff = query.GetFieldData(block.GetBlockName(), "diff", 0).ParseFloat("diff"); // float 6.2

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (hname?.Length > 40) return false; // char 40
			if (item1?.Length > 12) return false; // char 12
			if (issuernmk?.Length > 40) return false; // char 40
			if (elwopt?.Length > 2) return false; // char 2
			if (elwtype?.Length > 2) return false; // char 2
			if (settletype?.Length > 2) return false; // char 2
			// elwexec float 8.2
			// convrate float 12.4
			// listing float 12
			if (mmsdate?.Length > 8) return false; // char 8
			if (lastdate?.Length > 8) return false; // char 8
			if (nofdays.ToString().Length > 4) return false; // long 4
			if (payday?.Length > 8) return false; // char 8
			// parity float 6.2
			// premium float 6.2
			// berate float 6.2
			// capt float 6.2
			// gearing float 6.2
			// egearing float 6.2
			if (price.ToString().Length > 8) return false; // long 8
			// volume float 12
			// diff float 6.2

			return true;
		}
	}

	public partial class XQt1958OutBlock1 : XingBlock
	{
		/// <summary>
		/// t1958OutBlock1
		/// </summary>
		public const string _blockName = "t1958OutBlock1";
		/// <summary>
		/// 출력1
		/// </summary>
		public const string _blockDesc = "출력1";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// false
		/// </summary>
		public const bool _hasOccurs = false;
		/// <summary>
		/// t1958OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1958OutBlock1
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
		/// false
		/// </summary>
		public bool HasOccurs => _hasOccurs;

		/// <summary>
		/// 종목명
		/// </summary>
		[XAQueryFieldAttribute("종목명")]
		public string hname;
		/// <summary>
		/// 기초자산
		/// </summary>
		[XAQueryFieldAttribute("기초자산")]
		public string item1;
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
		/// 행사방식
		/// </summary>
		[XAQueryFieldAttribute("행사방식")]
		public string elwtype;
		/// <summary>
		/// 결제방법
		/// </summary>
		[XAQueryFieldAttribute("결제방법")]
		public string settletype;
		/// <summary>
		/// 행사가
		/// </summary>
		[XAQueryFieldAttribute("행사가")]
		public float elwexec;
		/// <summary>
		/// 전환비율
		/// </summary>
		[XAQueryFieldAttribute("전환비율")]
		public float convrate;
		/// <summary>
		/// 발행수량
		/// </summary>
		[XAQueryFieldAttribute("발행수량")]
		public float listing;
		/// <summary>
		/// 행사개시일
		/// </summary>
		[XAQueryFieldAttribute("행사개시일")]
		public string mmsdate;
		/// <summary>
		/// 최종거래일
		/// </summary>
		[XAQueryFieldAttribute("최종거래일")]
		public string lastdate;
		/// <summary>
		/// 거래잔존일수
		/// </summary>
		[XAQueryFieldAttribute("거래잔존일수")]
		public long nofdays;
		/// <summary>
		/// 지급일
		/// </summary>
		[XAQueryFieldAttribute("지급일")]
		public string payday;
		/// <summary>
		/// 패리티
		/// </summary>
		[XAQueryFieldAttribute("패리티")]
		public float parity;
		/// <summary>
		/// 프리미엄
		/// </summary>
		[XAQueryFieldAttribute("프리미엄")]
		public float premium;
		/// <summary>
		/// 손익분기
		/// </summary>
		[XAQueryFieldAttribute("손익분기")]
		public float berate;
		/// <summary>
		/// 자본지지
		/// </summary>
		[XAQueryFieldAttribute("자본지지")]
		public float capt;
		/// <summary>
		/// 기어링
		/// </summary>
		[XAQueryFieldAttribute("기어링")]
		public float gearing;
		/// <summary>
		/// e.기어링
		/// </summary>
		[XAQueryFieldAttribute("e.기어링")]
		public float egearing;
		/// <summary>
		/// 가격
		/// </summary>
		[XAQueryFieldAttribute("가격")]
		public long price;
		/// <summary>
		/// 거래량
		/// </summary>
		[XAQueryFieldAttribute("거래량")]
		public float volume;
		/// <summary>
		/// 등락율
		/// </summary>
		[XAQueryFieldAttribute("등락율")]
		public float diff;

		public static class F
		{
			/// <summary>
			/// 종목명
			/// </summary>
			public const string hname = "hname";
			/// <summary>
			/// 기초자산
			/// </summary>
			public const string item1 = "item1";
			/// <summary>
			/// 발행사
			/// </summary>
			public const string issuernmk = "issuernmk";
			/// <summary>
			/// 콜풋구분
			/// </summary>
			public const string elwopt = "elwopt";
			/// <summary>
			/// 행사방식
			/// </summary>
			public const string elwtype = "elwtype";
			/// <summary>
			/// 결제방법
			/// </summary>
			public const string settletype = "settletype";
			/// <summary>
			/// 행사가
			/// </summary>
			public const string elwexec = "elwexec";
			/// <summary>
			/// 전환비율
			/// </summary>
			public const string convrate = "convrate";
			/// <summary>
			/// 발행수량
			/// </summary>
			public const string listing = "listing";
			/// <summary>
			/// 행사개시일
			/// </summary>
			public const string mmsdate = "mmsdate";
			/// <summary>
			/// 최종거래일
			/// </summary>
			public const string lastdate = "lastdate";
			/// <summary>
			/// 거래잔존일수
			/// </summary>
			public const string nofdays = "nofdays";
			/// <summary>
			/// 지급일
			/// </summary>
			public const string payday = "payday";
			/// <summary>
			/// 패리티
			/// </summary>
			public const string parity = "parity";
			/// <summary>
			/// 프리미엄
			/// </summary>
			public const string premium = "premium";
			/// <summary>
			/// 손익분기
			/// </summary>
			public const string berate = "berate";
			/// <summary>
			/// 자본지지
			/// </summary>
			public const string capt = "capt";
			/// <summary>
			/// 기어링
			/// </summary>
			public const string gearing = "gearing";
			/// <summary>
			/// e.기어링
			/// </summary>
			public const string egearing = "egearing";
			/// <summary>
			/// 가격
			/// </summary>
			public const string price = "price";
			/// <summary>
			/// 거래량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// 등락율
			/// </summary>
			public const string diff = "diff";
		}

		public static string[] AllFields = new string[]
		{
			F.hname,
			F.item1,
			F.issuernmk,
			F.elwopt,
			F.elwtype,
			F.settletype,
			F.elwexec,
			F.convrate,
			F.listing,
			F.mmsdate,
			F.lastdate,
			F.nofdays,
			F.payday,
			F.parity,
			F.premium,
			F.berate,
			F.capt,
			F.gearing,
			F.egearing,
			F.price,
			F.volume,
			F.diff,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["hname"] = new XAQueryFieldInfo("char", hname, hname, "종목명", (decimal)40);
			dict["item1"] = new XAQueryFieldInfo("char", item1, item1, "기초자산", (decimal)12);
			dict["issuernmk"] = new XAQueryFieldInfo("char", issuernmk, issuernmk, "발행사", (decimal)40);
			dict["elwopt"] = new XAQueryFieldInfo("char", elwopt, elwopt, "콜풋구분", (decimal)2);
			dict["elwtype"] = new XAQueryFieldInfo("char", elwtype, elwtype, "행사방식", (decimal)2);
			dict["settletype"] = new XAQueryFieldInfo("char", settletype, settletype, "결제방법", (decimal)2);
			dict["elwexec"] = new XAQueryFieldInfo("float", elwexec, elwexec.ToString("00000000.00"), "행사가", (decimal)8.2);
			dict["convrate"] = new XAQueryFieldInfo("float", convrate, convrate.ToString("000000000000.0000"), "전환비율", (decimal)12.4);
			dict["listing"] = new XAQueryFieldInfo("float", listing, listing.ToString("000000000000"), "발행수량", (decimal)12);
			dict["mmsdate"] = new XAQueryFieldInfo("char", mmsdate, mmsdate, "행사개시일", (decimal)8);
			dict["lastdate"] = new XAQueryFieldInfo("char", lastdate, lastdate, "최종거래일", (decimal)8);
			dict["nofdays"] = new XAQueryFieldInfo("long", nofdays, nofdays.ToString("d4"), "거래잔존일수", (decimal)4);
			dict["payday"] = new XAQueryFieldInfo("char", payday, payday, "지급일", (decimal)8);
			dict["parity"] = new XAQueryFieldInfo("float", parity, parity.ToString("000000.00"), "패리티", (decimal)6.2);
			dict["premium"] = new XAQueryFieldInfo("float", premium, premium.ToString("000000.00"), "프리미엄", (decimal)6.2);
			dict["berate"] = new XAQueryFieldInfo("float", berate, berate.ToString("000000.00"), "손익분기", (decimal)6.2);
			dict["capt"] = new XAQueryFieldInfo("float", capt, capt.ToString("000000.00"), "자본지지", (decimal)6.2);
			dict["gearing"] = new XAQueryFieldInfo("float", gearing, gearing.ToString("000000.00"), "기어링", (decimal)6.2);
			dict["egearing"] = new XAQueryFieldInfo("float", egearing, egearing.ToString("000000.00"), "e.기어링", (decimal)6.2);
			dict["price"] = new XAQueryFieldInfo("long", price, price.ToString("d8"), "가격", (decimal)8);
			dict["volume"] = new XAQueryFieldInfo("float", volume, volume.ToString("000000000000"), "거래량", (decimal)12);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "등락율", (decimal)6.2);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "hname":
					this.hname = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "item1":
					this.item1 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "issuernmk":
					this.issuernmk = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "elwopt":
					this.elwopt = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "elwtype":
					this.elwtype = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "settletype":
					this.settletype = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "elwexec":
					this.elwexec = fieldInfo.FieldValue.ParseFloat("elwexec");
				break;

				case "convrate":
					this.convrate = fieldInfo.FieldValue.ParseFloat("convrate");
				break;

				case "listing":
					this.listing = fieldInfo.FieldValue.ParseFloat("listing");
				break;

				case "mmsdate":
					this.mmsdate = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "lastdate":
					this.lastdate = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "nofdays":
					this.nofdays = fieldInfo.FieldValue.ParseLong("nofdays");
				break;

				case "payday":
					this.payday = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "parity":
					this.parity = fieldInfo.FieldValue.ParseFloat("parity");
				break;

				case "premium":
					this.premium = fieldInfo.FieldValue.ParseFloat("premium");
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

				case "price":
					this.price = fieldInfo.FieldValue.ParseLong("price");
				break;

				case "volume":
					this.volume = fieldInfo.FieldValue.ParseFloat("volume");
				break;

				case "diff":
					this.diff = fieldInfo.FieldValue.ParseFloat("diff");
				break;


			}
		}

		public static XQt1958OutBlock1 FromQuery(XQt1958 query)
		{
			XQt1958OutBlock1 block = new XQt1958OutBlock1();
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
				block.item1 = query.GetFieldData(block.GetBlockName(), "item1", 0).TrimEnd('?'); // char 12
				block.issuernmk = query.GetFieldData(block.GetBlockName(), "issuernmk", 0).TrimEnd('?'); // char 40
				block.elwopt = query.GetFieldData(block.GetBlockName(), "elwopt", 0).TrimEnd('?'); // char 2
				block.elwtype = query.GetFieldData(block.GetBlockName(), "elwtype", 0).TrimEnd('?'); // char 2
				block.settletype = query.GetFieldData(block.GetBlockName(), "settletype", 0).TrimEnd('?'); // char 2
				block.elwexec = query.GetFieldData(block.GetBlockName(), "elwexec", 0).ParseFloat("elwexec"); // float 8.2
				block.convrate = query.GetFieldData(block.GetBlockName(), "convrate", 0).ParseFloat("convrate"); // float 12.4
				block.listing = query.GetFieldData(block.GetBlockName(), "listing", 0).ParseFloat("listing"); // float 12
				block.mmsdate = query.GetFieldData(block.GetBlockName(), "mmsdate", 0).TrimEnd('?'); // char 8
				block.lastdate = query.GetFieldData(block.GetBlockName(), "lastdate", 0).TrimEnd('?'); // char 8
				block.nofdays = query.GetFieldData(block.GetBlockName(), "nofdays", 0).ParseLong("nofdays"); // long 4
				block.payday = query.GetFieldData(block.GetBlockName(), "payday", 0).TrimEnd('?'); // char 8
				block.parity = query.GetFieldData(block.GetBlockName(), "parity", 0).ParseFloat("parity"); // float 6.2
				block.premium = query.GetFieldData(block.GetBlockName(), "premium", 0).ParseFloat("premium"); // float 6.2
				block.berate = query.GetFieldData(block.GetBlockName(), "berate", 0).ParseFloat("berate"); // float 6.2
				block.capt = query.GetFieldData(block.GetBlockName(), "capt", 0).ParseFloat("capt"); // float 6.2
				block.gearing = query.GetFieldData(block.GetBlockName(), "gearing", 0).ParseFloat("gearing"); // float 6.2
				block.egearing = query.GetFieldData(block.GetBlockName(), "egearing", 0).ParseFloat("egearing"); // float 6.2
				block.price = query.GetFieldData(block.GetBlockName(), "price", 0).ParseLong("price"); // long 8
				block.volume = query.GetFieldData(block.GetBlockName(), "volume", 0).ParseFloat("volume"); // float 12
				block.diff = query.GetFieldData(block.GetBlockName(), "diff", 0).ParseFloat("diff"); // float 6.2

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (hname?.Length > 40) return false; // char 40
			if (item1?.Length > 12) return false; // char 12
			if (issuernmk?.Length > 40) return false; // char 40
			if (elwopt?.Length > 2) return false; // char 2
			if (elwtype?.Length > 2) return false; // char 2
			if (settletype?.Length > 2) return false; // char 2
			// elwexec float 8.2
			// convrate float 12.4
			// listing float 12
			if (mmsdate?.Length > 8) return false; // char 8
			if (lastdate?.Length > 8) return false; // char 8
			if (nofdays.ToString().Length > 4) return false; // long 4
			if (payday?.Length > 8) return false; // char 8
			// parity float 6.2
			// premium float 6.2
			// berate float 6.2
			// capt float 6.2
			// gearing float 6.2
			// egearing float 6.2
			if (price.ToString().Length > 8) return false; // long 8
			// volume float 12
			// diff float 6.2

			return true;
		}
	}

	public partial class XQt1958OutBlock2 : XingBlock
	{
		/// <summary>
		/// t1958OutBlock2
		/// </summary>
		public const string _blockName = "t1958OutBlock2";
		/// <summary>
		/// 출력2
		/// </summary>
		public const string _blockDesc = "출력2";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// false
		/// </summary>
		public const bool _hasOccurs = false;
		/// <summary>
		/// t1958OutBlock2
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1958OutBlock2
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// 출력2
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
		/// 종목명비교
		/// </summary>
		[XAQueryFieldAttribute("종목명비교")]
		public string hnamecmp;
		/// <summary>
		/// 기초자산비교
		/// </summary>
		[XAQueryFieldAttribute("기초자산비교")]
		public string item1cmp;
		/// <summary>
		/// 발행사비교
		/// </summary>
		[XAQueryFieldAttribute("발행사비교")]
		public string issuernmkcmp;
		/// <summary>
		/// 콜풋구분비교
		/// </summary>
		[XAQueryFieldAttribute("콜풋구분비교")]
		public string elwoptcmp;
		/// <summary>
		/// 행사방식비교
		/// </summary>
		[XAQueryFieldAttribute("행사방식비교")]
		public string elwtypecmp;
		/// <summary>
		/// 결제방법비교
		/// </summary>
		[XAQueryFieldAttribute("결제방법비교")]
		public string settlecmp;
		/// <summary>
		/// 행사가비교
		/// </summary>
		[XAQueryFieldAttribute("행사가비교")]
		public float elwexeccmp;
		/// <summary>
		/// 전환비율비교
		/// </summary>
		[XAQueryFieldAttribute("전환비율비교")]
		public float convcmp;
		/// <summary>
		/// 발행수량비교
		/// </summary>
		[XAQueryFieldAttribute("발행수량비교")]
		public float listingcmp;
		/// <summary>
		/// 행사개시일비교
		/// </summary>
		[XAQueryFieldAttribute("행사개시일비교")]
		public string mmsdatecmp;
		/// <summary>
		/// 최종거래일비교
		/// </summary>
		[XAQueryFieldAttribute("최종거래일비교")]
		public string lastdatecmp;
		/// <summary>
		/// 거래잔존일수비교
		/// </summary>
		[XAQueryFieldAttribute("거래잔존일수비교")]
		public string nofdayscmp;
		/// <summary>
		/// 지급일비교
		/// </summary>
		[XAQueryFieldAttribute("지급일비교")]
		public string paydaycmp;
		/// <summary>
		/// 패리티비교
		/// </summary>
		[XAQueryFieldAttribute("패리티비교")]
		public float paritycmp;
		/// <summary>
		/// 프리미엄비교
		/// </summary>
		[XAQueryFieldAttribute("프리미엄비교")]
		public float premiumcmp;
		/// <summary>
		/// 손익분기비교
		/// </summary>
		[XAQueryFieldAttribute("손익분기비교")]
		public float beratecmp;
		/// <summary>
		/// 자본지지비교
		/// </summary>
		[XAQueryFieldAttribute("자본지지비교")]
		public float captcmp;
		/// <summary>
		/// 기어링비교
		/// </summary>
		[XAQueryFieldAttribute("기어링비교")]
		public float gearingcmp;
		/// <summary>
		/// e.기어링비교
		/// </summary>
		[XAQueryFieldAttribute("e.기어링비교")]
		public float egearingcmp;
		/// <summary>
		/// 가격비교
		/// </summary>
		[XAQueryFieldAttribute("가격비교")]
		public long pricecmp;
		/// <summary>
		/// 거래량비교
		/// </summary>
		[XAQueryFieldAttribute("거래량비교")]
		public float volumecmp;
		/// <summary>
		/// 등락율비교
		/// </summary>
		[XAQueryFieldAttribute("등락율비교")]
		public float diffcmp;

		public static class F
		{
			/// <summary>
			/// 종목명비교
			/// </summary>
			public const string hnamecmp = "hnamecmp";
			/// <summary>
			/// 기초자산비교
			/// </summary>
			public const string item1cmp = "item1cmp";
			/// <summary>
			/// 발행사비교
			/// </summary>
			public const string issuernmkcmp = "issuernmkcmp";
			/// <summary>
			/// 콜풋구분비교
			/// </summary>
			public const string elwoptcmp = "elwoptcmp";
			/// <summary>
			/// 행사방식비교
			/// </summary>
			public const string elwtypecmp = "elwtypecmp";
			/// <summary>
			/// 결제방법비교
			/// </summary>
			public const string settlecmp = "settlecmp";
			/// <summary>
			/// 행사가비교
			/// </summary>
			public const string elwexeccmp = "elwexeccmp";
			/// <summary>
			/// 전환비율비교
			/// </summary>
			public const string convcmp = "convcmp";
			/// <summary>
			/// 발행수량비교
			/// </summary>
			public const string listingcmp = "listingcmp";
			/// <summary>
			/// 행사개시일비교
			/// </summary>
			public const string mmsdatecmp = "mmsdatecmp";
			/// <summary>
			/// 최종거래일비교
			/// </summary>
			public const string lastdatecmp = "lastdatecmp";
			/// <summary>
			/// 거래잔존일수비교
			/// </summary>
			public const string nofdayscmp = "nofdayscmp";
			/// <summary>
			/// 지급일비교
			/// </summary>
			public const string paydaycmp = "paydaycmp";
			/// <summary>
			/// 패리티비교
			/// </summary>
			public const string paritycmp = "paritycmp";
			/// <summary>
			/// 프리미엄비교
			/// </summary>
			public const string premiumcmp = "premiumcmp";
			/// <summary>
			/// 손익분기비교
			/// </summary>
			public const string beratecmp = "beratecmp";
			/// <summary>
			/// 자본지지비교
			/// </summary>
			public const string captcmp = "captcmp";
			/// <summary>
			/// 기어링비교
			/// </summary>
			public const string gearingcmp = "gearingcmp";
			/// <summary>
			/// e.기어링비교
			/// </summary>
			public const string egearingcmp = "egearingcmp";
			/// <summary>
			/// 가격비교
			/// </summary>
			public const string pricecmp = "pricecmp";
			/// <summary>
			/// 거래량비교
			/// </summary>
			public const string volumecmp = "volumecmp";
			/// <summary>
			/// 등락율비교
			/// </summary>
			public const string diffcmp = "diffcmp";
		}

		public static string[] AllFields = new string[]
		{
			F.hnamecmp,
			F.item1cmp,
			F.issuernmkcmp,
			F.elwoptcmp,
			F.elwtypecmp,
			F.settlecmp,
			F.elwexeccmp,
			F.convcmp,
			F.listingcmp,
			F.mmsdatecmp,
			F.lastdatecmp,
			F.nofdayscmp,
			F.paydaycmp,
			F.paritycmp,
			F.premiumcmp,
			F.beratecmp,
			F.captcmp,
			F.gearingcmp,
			F.egearingcmp,
			F.pricecmp,
			F.volumecmp,
			F.diffcmp,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["hnamecmp"] = new XAQueryFieldInfo("char", hnamecmp, hnamecmp, "종목명비교", (decimal)6);
			dict["item1cmp"] = new XAQueryFieldInfo("char", item1cmp, item1cmp, "기초자산비교", (decimal)6);
			dict["issuernmkcmp"] = new XAQueryFieldInfo("char", issuernmkcmp, issuernmkcmp, "발행사비교", (decimal)6);
			dict["elwoptcmp"] = new XAQueryFieldInfo("char", elwoptcmp, elwoptcmp, "콜풋구분비교", (decimal)6);
			dict["elwtypecmp"] = new XAQueryFieldInfo("char", elwtypecmp, elwtypecmp, "행사방식비교", (decimal)6);
			dict["settlecmp"] = new XAQueryFieldInfo("char", settlecmp, settlecmp, "결제방법비교", (decimal)6);
			dict["elwexeccmp"] = new XAQueryFieldInfo("float", elwexeccmp, elwexeccmp.ToString("00000000.00"), "행사가비교", (decimal)8.2);
			dict["convcmp"] = new XAQueryFieldInfo("float", convcmp, convcmp.ToString("000000000000.0000"), "전환비율비교", (decimal)12.4);
			dict["listingcmp"] = new XAQueryFieldInfo("float", listingcmp, listingcmp.ToString("000000000000"), "발행수량비교", (decimal)12);
			dict["mmsdatecmp"] = new XAQueryFieldInfo("char", mmsdatecmp, mmsdatecmp, "행사개시일비교", (decimal)6);
			dict["lastdatecmp"] = new XAQueryFieldInfo("char", lastdatecmp, lastdatecmp, "최종거래일비교", (decimal)6);
			dict["nofdayscmp"] = new XAQueryFieldInfo("char", nofdayscmp, nofdayscmp, "거래잔존일수비교", (decimal)6);
			dict["paydaycmp"] = new XAQueryFieldInfo("char", paydaycmp, paydaycmp, "지급일비교", (decimal)6);
			dict["paritycmp"] = new XAQueryFieldInfo("float", paritycmp, paritycmp.ToString("000000.00"), "패리티비교", (decimal)6.2);
			dict["premiumcmp"] = new XAQueryFieldInfo("float", premiumcmp, premiumcmp.ToString("000000.00"), "프리미엄비교", (decimal)6.2);
			dict["beratecmp"] = new XAQueryFieldInfo("float", beratecmp, beratecmp.ToString("000000.00"), "손익분기비교", (decimal)6.2);
			dict["captcmp"] = new XAQueryFieldInfo("float", captcmp, captcmp.ToString("000000.00"), "자본지지비교", (decimal)6.2);
			dict["gearingcmp"] = new XAQueryFieldInfo("float", gearingcmp, gearingcmp.ToString("000000.00"), "기어링비교", (decimal)6.2);
			dict["egearingcmp"] = new XAQueryFieldInfo("float", egearingcmp, egearingcmp.ToString("000000.00"), "e.기어링비교", (decimal)6.2);
			dict["pricecmp"] = new XAQueryFieldInfo("long", pricecmp, pricecmp.ToString("d8"), "가격비교", (decimal)8);
			dict["volumecmp"] = new XAQueryFieldInfo("float", volumecmp, volumecmp.ToString("000000000000"), "거래량비교", (decimal)12);
			dict["diffcmp"] = new XAQueryFieldInfo("float", diffcmp, diffcmp.ToString("000000.00"), "등락율비교", (decimal)6.2);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "hnamecmp":
					this.hnamecmp = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "item1cmp":
					this.item1cmp = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "issuernmkcmp":
					this.issuernmkcmp = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "elwoptcmp":
					this.elwoptcmp = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "elwtypecmp":
					this.elwtypecmp = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "settlecmp":
					this.settlecmp = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "elwexeccmp":
					this.elwexeccmp = fieldInfo.FieldValue.ParseFloat("elwexeccmp");
				break;

				case "convcmp":
					this.convcmp = fieldInfo.FieldValue.ParseFloat("convcmp");
				break;

				case "listingcmp":
					this.listingcmp = fieldInfo.FieldValue.ParseFloat("listingcmp");
				break;

				case "mmsdatecmp":
					this.mmsdatecmp = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "lastdatecmp":
					this.lastdatecmp = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "nofdayscmp":
					this.nofdayscmp = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "paydaycmp":
					this.paydaycmp = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "paritycmp":
					this.paritycmp = fieldInfo.FieldValue.ParseFloat("paritycmp");
				break;

				case "premiumcmp":
					this.premiumcmp = fieldInfo.FieldValue.ParseFloat("premiumcmp");
				break;

				case "beratecmp":
					this.beratecmp = fieldInfo.FieldValue.ParseFloat("beratecmp");
				break;

				case "captcmp":
					this.captcmp = fieldInfo.FieldValue.ParseFloat("captcmp");
				break;

				case "gearingcmp":
					this.gearingcmp = fieldInfo.FieldValue.ParseFloat("gearingcmp");
				break;

				case "egearingcmp":
					this.egearingcmp = fieldInfo.FieldValue.ParseFloat("egearingcmp");
				break;

				case "pricecmp":
					this.pricecmp = fieldInfo.FieldValue.ParseLong("pricecmp");
				break;

				case "volumecmp":
					this.volumecmp = fieldInfo.FieldValue.ParseFloat("volumecmp");
				break;

				case "diffcmp":
					this.diffcmp = fieldInfo.FieldValue.ParseFloat("diffcmp");
				break;


			}
		}

		public static XQt1958OutBlock2 FromQuery(XQt1958 query)
		{
			XQt1958OutBlock2 block = new XQt1958OutBlock2();
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
				block.hnamecmp = query.GetFieldData(block.GetBlockName(), "hnamecmp", 0).TrimEnd('?'); // char 6
				block.item1cmp = query.GetFieldData(block.GetBlockName(), "item1cmp", 0).TrimEnd('?'); // char 6
				block.issuernmkcmp = query.GetFieldData(block.GetBlockName(), "issuernmkcmp", 0).TrimEnd('?'); // char 6
				block.elwoptcmp = query.GetFieldData(block.GetBlockName(), "elwoptcmp", 0).TrimEnd('?'); // char 6
				block.elwtypecmp = query.GetFieldData(block.GetBlockName(), "elwtypecmp", 0).TrimEnd('?'); // char 6
				block.settlecmp = query.GetFieldData(block.GetBlockName(), "settlecmp", 0).TrimEnd('?'); // char 6
				block.elwexeccmp = query.GetFieldData(block.GetBlockName(), "elwexeccmp", 0).ParseFloat("elwexeccmp"); // float 8.2
				block.convcmp = query.GetFieldData(block.GetBlockName(), "convcmp", 0).ParseFloat("convcmp"); // float 12.4
				block.listingcmp = query.GetFieldData(block.GetBlockName(), "listingcmp", 0).ParseFloat("listingcmp"); // float 12
				block.mmsdatecmp = query.GetFieldData(block.GetBlockName(), "mmsdatecmp", 0).TrimEnd('?'); // char 6
				block.lastdatecmp = query.GetFieldData(block.GetBlockName(), "lastdatecmp", 0).TrimEnd('?'); // char 6
				block.nofdayscmp = query.GetFieldData(block.GetBlockName(), "nofdayscmp", 0).TrimEnd('?'); // char 6
				block.paydaycmp = query.GetFieldData(block.GetBlockName(), "paydaycmp", 0).TrimEnd('?'); // char 6
				block.paritycmp = query.GetFieldData(block.GetBlockName(), "paritycmp", 0).ParseFloat("paritycmp"); // float 6.2
				block.premiumcmp = query.GetFieldData(block.GetBlockName(), "premiumcmp", 0).ParseFloat("premiumcmp"); // float 6.2
				block.beratecmp = query.GetFieldData(block.GetBlockName(), "beratecmp", 0).ParseFloat("beratecmp"); // float 6.2
				block.captcmp = query.GetFieldData(block.GetBlockName(), "captcmp", 0).ParseFloat("captcmp"); // float 6.2
				block.gearingcmp = query.GetFieldData(block.GetBlockName(), "gearingcmp", 0).ParseFloat("gearingcmp"); // float 6.2
				block.egearingcmp = query.GetFieldData(block.GetBlockName(), "egearingcmp", 0).ParseFloat("egearingcmp"); // float 6.2
				block.pricecmp = query.GetFieldData(block.GetBlockName(), "pricecmp", 0).ParseLong("pricecmp"); // long 8
				block.volumecmp = query.GetFieldData(block.GetBlockName(), "volumecmp", 0).ParseFloat("volumecmp"); // float 12
				block.diffcmp = query.GetFieldData(block.GetBlockName(), "diffcmp", 0).ParseFloat("diffcmp"); // float 6.2

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (hnamecmp?.Length > 6) return false; // char 6
			if (item1cmp?.Length > 6) return false; // char 6
			if (issuernmkcmp?.Length > 6) return false; // char 6
			if (elwoptcmp?.Length > 6) return false; // char 6
			if (elwtypecmp?.Length > 6) return false; // char 6
			if (settlecmp?.Length > 6) return false; // char 6
			// elwexeccmp float 8.2
			// convcmp float 12.4
			// listingcmp float 12
			if (mmsdatecmp?.Length > 6) return false; // char 6
			if (lastdatecmp?.Length > 6) return false; // char 6
			if (nofdayscmp?.Length > 6) return false; // char 6
			if (paydaycmp?.Length > 6) return false; // char 6
			// paritycmp float 6.2
			// premiumcmp float 6.2
			// beratecmp float 6.2
			// captcmp float 6.2
			// gearingcmp float 6.2
			// egearingcmp float 6.2
			if (pricecmp.ToString().Length > 8) return false; // long 8
			// volumecmp float 12
			// diffcmp float 6.2

			return true;
		}
	}

	/// <summary>
	/// ELW종목비교(t1958)
	/// </summary>
	public partial class XQt1958 : XingQuery
	{
		/// <summary>
		/// t1958
		/// </summary>
		public const string _typeName = "t1958";
		/// <summary>
		/// ELW종목비교(t1958)
		/// </summary>
		public const string _typeDesc = "ELW종목비교(t1958)";
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
		/// t1958
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// ELW종목비교(t1958)
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
		/// ELW종목비교(t1958)
		/// </summary>
		public XQt1958() : base("t1958") { }



		public bool SetBlock(XQt1958InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "shcode1", 0, block.shcode1); // char 6
			_xaQuery.SetFieldData(block.GetBlockName(), "shcode2", 0, block.shcode2); // char 6

			return true;
		}

		public XQt1958OutBlock GetBlock()
		{
			XQt1958OutBlock instance = XQt1958OutBlock.FromQuery(this);
			return instance;

		}

		public XQt1958OutBlock1 GetBlock1()
		{
			XQt1958OutBlock1 instance = XQt1958OutBlock1.FromQuery(this);
			return instance;

		}

		public XQt1958OutBlock2 GetBlock2()
		{
			XQt1958OutBlock2 instance = XQt1958OutBlock2.FromQuery(this);
			return instance;

		}


	}

}
