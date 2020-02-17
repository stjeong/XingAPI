using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1960InBlock : XingBlock
	{
		/// <summary>
		/// t1960InBlock
		/// </summary>
		public const string _blockName = "t1960InBlock";
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
		/// t1960InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1960InBlock
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
		/// 상승하락(0:상승1:하락)
		/// </summary>
		[XAQueryFieldAttribute("gubun", "상승하락(0:상승1:하락)", "char", "1")]
		public char gubun;
		/// <summary>
		/// 권리유형구분(00:EX01:콜02:풋'':전체)
		/// </summary>
		[XAQueryFieldAttribute("ggubun", "권리유형구분(00:EX01:콜02:풋'':전체)", "char", "2")]
		public string ggubun;
		/// <summary>
		/// 기초자산종목
		/// </summary>
		[XAQueryFieldAttribute("itemcode", "기초자산종목", "char", "12")]
		public string itemcode;
		/// <summary>
		/// 조회만기일
		/// </summary>
		[XAQueryFieldAttribute("lastdate", "조회만기일", "char", "8")]
		public string lastdate;
		/// <summary>
		/// 대상제외
		/// </summary>
		[XAQueryFieldAttribute("exgubun", "대상제외", "char", "6")]
		public string exgubun;
		/// <summary>
		/// 시작가격
		/// </summary>
		[XAQueryFieldAttribute("sprice", "시작가격", "long", "8")]
		public long sprice;
		/// <summary>
		/// 종료가격
		/// </summary>
		[XAQueryFieldAttribute("eprice", "종료가격", "long", "8")]
		public long eprice;
		/// <summary>
		/// 거래량
		/// </summary>
		[XAQueryFieldAttribute("volume", "거래량", "long", "12")]
		public long volume;
		/// <summary>
		/// 잔존시작일수
		/// </summary>
		[XAQueryFieldAttribute("sjanday", "잔존시작일수", "long", "8")]
		public long sjanday;
		/// <summary>
		/// 잔존종료일수
		/// </summary>
		[XAQueryFieldAttribute("ejanday", "잔존종료일수", "long", "8")]
		public long ejanday;
		/// <summary>
		/// IDX
		/// </summary>
		[XAQueryFieldAttribute("idx", "IDX", "long", "4")]
		public long idx;

		public static class F
		{
			/// <summary>
			/// 상승하락(0:상승1:하락)
			/// </summary>
			public const string gubun = "gubun";
			/// <summary>
			/// 권리유형구분(00:EX01:콜02:풋'':전체)
			/// </summary>
			public const string ggubun = "ggubun";
			/// <summary>
			/// 기초자산종목
			/// </summary>
			public const string itemcode = "itemcode";
			/// <summary>
			/// 조회만기일
			/// </summary>
			public const string lastdate = "lastdate";
			/// <summary>
			/// 대상제외
			/// </summary>
			public const string exgubun = "exgubun";
			/// <summary>
			/// 시작가격
			/// </summary>
			public const string sprice = "sprice";
			/// <summary>
			/// 종료가격
			/// </summary>
			public const string eprice = "eprice";
			/// <summary>
			/// 거래량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// 잔존시작일수
			/// </summary>
			public const string sjanday = "sjanday";
			/// <summary>
			/// 잔존종료일수
			/// </summary>
			public const string ejanday = "ejanday";
			/// <summary>
			/// IDX
			/// </summary>
			public const string idx = "idx";
		}

		public static string[] AllFields = new string[]
		{
			F.gubun,
			F.ggubun,
			F.itemcode,
			F.lastdate,
			F.exgubun,
			F.sprice,
			F.eprice,
			F.volume,
			F.sjanday,
			F.ejanday,
			F.idx,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["gubun"] = new XAQueryFieldInfo("char", gubun, gubun.ToString(), "상승하락(0:상승1:하락)", (decimal)1);
			dict["ggubun"] = new XAQueryFieldInfo("char", ggubun, ggubun, "권리유형구분(00:EX01:콜02:풋'':전체)", (decimal)2);
			dict["itemcode"] = new XAQueryFieldInfo("char", itemcode, itemcode, "기초자산종목", (decimal)12);
			dict["lastdate"] = new XAQueryFieldInfo("char", lastdate, lastdate, "조회만기일", (decimal)8);
			dict["exgubun"] = new XAQueryFieldInfo("char", exgubun, exgubun, "대상제외", (decimal)6);
			dict["sprice"] = new XAQueryFieldInfo("long", sprice, sprice.ToString("d8"), "시작가격", (decimal)8);
			dict["eprice"] = new XAQueryFieldInfo("long", eprice, eprice.ToString("d8"), "종료가격", (decimal)8);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "거래량", (decimal)12);
			dict["sjanday"] = new XAQueryFieldInfo("long", sjanday, sjanday.ToString("d8"), "잔존시작일수", (decimal)8);
			dict["ejanday"] = new XAQueryFieldInfo("long", ejanday, ejanday.ToString("d8"), "잔존종료일수", (decimal)8);
			dict["idx"] = new XAQueryFieldInfo("long", idx, idx.ToString("d4"), "IDX", (decimal)4);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "gubun":
					this.gubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "ggubun":
					this.ggubun = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "itemcode":
					this.itemcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "lastdate":
					this.lastdate = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "exgubun":
					this.exgubun = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "sprice":
					this.sprice = fieldInfo.FieldValue.ParseLong("sprice");
				break;

				case "eprice":
					this.eprice = fieldInfo.FieldValue.ParseLong("eprice");
				break;

				case "volume":
					this.volume = fieldInfo.FieldValue.ParseLong("volume");
				break;

				case "sjanday":
					this.sjanday = fieldInfo.FieldValue.ParseLong("sjanday");
				break;

				case "ejanday":
					this.ejanday = fieldInfo.FieldValue.ParseLong("ejanday");
				break;

				case "idx":
					this.idx = fieldInfo.FieldValue.ParseLong("idx");
				break;


			}
		}

		public bool VerifyData()
		{
			// gubun char 1
			if (ggubun?.Length > 2) return false; // char 2
			if (itemcode?.Length > 12) return false; // char 12
			if (lastdate?.Length > 8) return false; // char 8
			if (exgubun?.Length > 6) return false; // char 6
			if (sprice.ToString().Length > 8) return false; // long 8
			if (eprice.ToString().Length > 8) return false; // long 8
			if (volume.ToString().Length > 12) return false; // long 12
			if (sjanday.ToString().Length > 8) return false; // long 8
			if (ejanday.ToString().Length > 8) return false; // long 8
			if (idx.ToString().Length > 4) return false; // long 4

			return true;
		}
	}

	public partial class XQt1960OutBlock : XingBlock
	{
		/// <summary>
		/// t1960OutBlock
		/// </summary>
		public const string _blockName = "t1960OutBlock";
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
		/// t1960OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1960OutBlock
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
		/// IDX
		/// </summary>
		[XAQueryFieldAttribute("idx", "IDX", "long", "4")]
		public long idx;

		public static class F
		{
			/// <summary>
			/// IDX
			/// </summary>
			public const string idx = "idx";
		}

		public static string[] AllFields = new string[]
		{
			F.idx,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["idx"] = new XAQueryFieldInfo("long", idx, idx.ToString("d4"), "IDX", (decimal)4);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "idx":
					this.idx = fieldInfo.FieldValue.ParseLong("idx");
				break;


			}
		}

		public static XQt1960OutBlock FromQuery(XQt1960 query)
		{
			XQt1960OutBlock block = new XQt1960OutBlock();
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
				block.idx = query.GetFieldData(block.GetBlockName(), "idx", 0).ParseLong("idx"); // long 4

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (idx.ToString().Length > 4) return false; // long 4

			return true;
		}
	}

	public partial class XQt1960OutBlock1 : XingBlock
	{
		/// <summary>
		/// t1960OutBlock1
		/// </summary>
		public const string _blockName = "t1960OutBlock1";
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
		/// t1960OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1960OutBlock1
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
		/// 한글명
		/// </summary>
		[XAQueryFieldAttribute("hname", "한글명", "char", "40")]
		public string hname;
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
		/// 누적거래량
		/// </summary>
		[XAQueryFieldAttribute("volume", "누적거래량", "double", "12.0")]
		public double volume;
		/// <summary>
		/// 행사가
		/// </summary>
		[XAQueryFieldAttribute("elwexec", "행사가", "double", "10.2")]
		public double elwexec;
		/// <summary>
		/// 전환비율
		/// </summary>
		[XAQueryFieldAttribute("convrate", "전환비율", "double", "12.4")]
		public double convrate;
		/// <summary>
		/// 만기일
		/// </summary>
		[XAQueryFieldAttribute("lastdate", "만기일", "char", "8")]
		public string lastdate;
		/// <summary>
		/// 기초자산종목코드
		/// </summary>
		[XAQueryFieldAttribute("itemcode", "기초자산종목코드", "char", "12")]
		public string itemcode;
		/// <summary>
		/// 기초자산단축코드
		/// </summary>
		[XAQueryFieldAttribute("itemshcode", "기초자산단축코드", "char", "9")]
		public string itemshcode;
		/// <summary>
		/// 기초자산종목명
		/// </summary>
		[XAQueryFieldAttribute("itemname", "기초자산종목명", "char", "20")]
		public string itemname;
		/// <summary>
		/// 기초자산현재가
		/// </summary>
		[XAQueryFieldAttribute("itemprice", "기초자산현재가", "char", "10")]
		public string itemprice;
		/// <summary>
		/// 기초자산대비구분
		/// </summary>
		[XAQueryFieldAttribute("itemsign", "기초자산대비구분", "char", "1")]
		public char itemsign;
		/// <summary>
		/// 기초자산전일대비
		/// </summary>
		[XAQueryFieldAttribute("itemchange", "기초자산전일대비", "char", "10")]
		public string itemchange;
		/// <summary>
		/// 기초자산등락율
		/// </summary>
		[XAQueryFieldAttribute("itemdiff", "기초자산등락율", "double", "6.2")]
		public double itemdiff;
		/// <summary>
		/// ELW종목코드
		/// </summary>
		[XAQueryFieldAttribute("elwshcode", "ELW종목코드", "char", "6")]
		public string elwshcode;
		/// <summary>
		/// 손익분기점
		/// </summary>
		[XAQueryFieldAttribute("bepoint", "손익분기점", "double", "12.2")]
		public double bepoint;

		public static class F
		{
			/// <summary>
			/// 한글명
			/// </summary>
			public const string hname = "hname";
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
			/// 누적거래량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// 행사가
			/// </summary>
			public const string elwexec = "elwexec";
			/// <summary>
			/// 전환비율
			/// </summary>
			public const string convrate = "convrate";
			/// <summary>
			/// 만기일
			/// </summary>
			public const string lastdate = "lastdate";
			/// <summary>
			/// 기초자산종목코드
			/// </summary>
			public const string itemcode = "itemcode";
			/// <summary>
			/// 기초자산단축코드
			/// </summary>
			public const string itemshcode = "itemshcode";
			/// <summary>
			/// 기초자산종목명
			/// </summary>
			public const string itemname = "itemname";
			/// <summary>
			/// 기초자산현재가
			/// </summary>
			public const string itemprice = "itemprice";
			/// <summary>
			/// 기초자산대비구분
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
			/// ELW종목코드
			/// </summary>
			public const string elwshcode = "elwshcode";
			/// <summary>
			/// 손익분기점
			/// </summary>
			public const string bepoint = "bepoint";
		}

		public static string[] AllFields = new string[]
		{
			F.hname,
			F.price,
			F.sign,
			F.change,
			F.diff,
			F.volume,
			F.elwexec,
			F.convrate,
			F.lastdate,
			F.itemcode,
			F.itemshcode,
			F.itemname,
			F.itemprice,
			F.itemsign,
			F.itemchange,
			F.itemdiff,
			F.elwshcode,
			F.bepoint,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["hname"] = new XAQueryFieldInfo("char", hname, hname, "한글명", (decimal)40);
			dict["price"] = new XAQueryFieldInfo("long", price, price.ToString("d8"), "현재가", (decimal)8);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("long", change, change.ToString("d8"), "전일대비", (decimal)8);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["volume"] = new XAQueryFieldInfo("double", volume, volume.ToString("000000000000."), "누적거래량", (decimal)12.0);
			dict["elwexec"] = new XAQueryFieldInfo("double", elwexec, elwexec.ToString("0000000000.00"), "행사가", (decimal)10.2);
			dict["convrate"] = new XAQueryFieldInfo("double", convrate, convrate.ToString("000000000000.0000"), "전환비율", (decimal)12.4);
			dict["lastdate"] = new XAQueryFieldInfo("char", lastdate, lastdate, "만기일", (decimal)8);
			dict["itemcode"] = new XAQueryFieldInfo("char", itemcode, itemcode, "기초자산종목코드", (decimal)12);
			dict["itemshcode"] = new XAQueryFieldInfo("char", itemshcode, itemshcode, "기초자산단축코드", (decimal)9);
			dict["itemname"] = new XAQueryFieldInfo("char", itemname, itemname, "기초자산종목명", (decimal)20);
			dict["itemprice"] = new XAQueryFieldInfo("char", itemprice, itemprice, "기초자산현재가", (decimal)10);
			dict["itemsign"] = new XAQueryFieldInfo("char", itemsign, itemsign.ToString(), "기초자산대비구분", (decimal)1);
			dict["itemchange"] = new XAQueryFieldInfo("char", itemchange, itemchange, "기초자산전일대비", (decimal)10);
			dict["itemdiff"] = new XAQueryFieldInfo("double", itemdiff, itemdiff.ToString("000000.00"), "기초자산등락율", (decimal)6.2);
			dict["elwshcode"] = new XAQueryFieldInfo("char", elwshcode, elwshcode, "ELW종목코드", (decimal)6);
			dict["bepoint"] = new XAQueryFieldInfo("double", bepoint, bepoint.ToString("000000000000.00"), "손익분기점", (decimal)12.2);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "hname":
					this.hname = fieldInfo.FieldValue.TrimEnd('?');
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
					this.volume = fieldInfo.FieldValue.ParseDouble("volume");
				break;

				case "elwexec":
					this.elwexec = fieldInfo.FieldValue.ParseDouble("elwexec");
				break;

				case "convrate":
					this.convrate = fieldInfo.FieldValue.ParseDouble("convrate");
				break;

				case "lastdate":
					this.lastdate = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "itemcode":
					this.itemcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "itemshcode":
					this.itemshcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "itemname":
					this.itemname = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "itemprice":
					this.itemprice = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "itemsign":
					this.itemsign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "itemchange":
					this.itemchange = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "itemdiff":
					this.itemdiff = fieldInfo.FieldValue.ParseDouble("itemdiff");
				break;

				case "elwshcode":
					this.elwshcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "bepoint":
					this.bepoint = fieldInfo.FieldValue.ParseDouble("bepoint");
				break;


			}
		}

		public static XQt1960OutBlock1[] ListFromQuery(XQt1960 query)
		{
			int count = query.GetBlockCount(XQt1960OutBlock1.BlockName);
			List<XQt1960OutBlock1> list = new List<XQt1960OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1960OutBlock1 block = new XQt1960OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.hname = query.GetFieldData(block.GetBlockName(), "hname", i).TrimEnd('?'); // char 40
					block.price = query.GetFieldData(block.GetBlockName(), "price", i).ParseLong("price"); // long 8
					block.sign = query.GetFieldData(block.GetBlockName(), "sign", i).FirstOrDefault(); // char 1
					block.change = query.GetFieldData(block.GetBlockName(), "change", i).ParseLong("change"); // long 8
					block.diff = query.GetFieldData(block.GetBlockName(), "diff", i).ParseFloat("diff"); // float 6.2
					block.volume = query.GetFieldData(block.GetBlockName(), "volume", i).ParseDouble("volume"); // double 12.0
					block.elwexec = query.GetFieldData(block.GetBlockName(), "elwexec", i).ParseDouble("elwexec"); // double 10.2
					block.convrate = query.GetFieldData(block.GetBlockName(), "convrate", i).ParseDouble("convrate"); // double 12.4
					block.lastdate = query.GetFieldData(block.GetBlockName(), "lastdate", i).TrimEnd('?'); // char 8
					block.itemcode = query.GetFieldData(block.GetBlockName(), "itemcode", i).TrimEnd('?'); // char 12
					block.itemshcode = query.GetFieldData(block.GetBlockName(), "itemshcode", i).TrimEnd('?'); // char 9
					block.itemname = query.GetFieldData(block.GetBlockName(), "itemname", i).TrimEnd('?'); // char 20
					block.itemprice = query.GetFieldData(block.GetBlockName(), "itemprice", i).TrimEnd('?'); // char 10
					block.itemsign = query.GetFieldData(block.GetBlockName(), "itemsign", i).FirstOrDefault(); // char 1
					block.itemchange = query.GetFieldData(block.GetBlockName(), "itemchange", i).TrimEnd('?'); // char 10
					block.itemdiff = query.GetFieldData(block.GetBlockName(), "itemdiff", i).ParseDouble("itemdiff"); // double 6.2
					block.elwshcode = query.GetFieldData(block.GetBlockName(), "elwshcode", i).TrimEnd('?'); // char 6
					block.bepoint = query.GetFieldData(block.GetBlockName(), "bepoint", i).ParseDouble("bepoint"); // double 12.2

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
			if (price.ToString().Length > 8) return false; // long 8
			// sign char 1
			if (change.ToString().Length > 8) return false; // long 8
			// diff float 6.2
			// volume double 12.0
			// elwexec double 10.2
			// convrate double 12.4
			if (lastdate?.Length > 8) return false; // char 8
			if (itemcode?.Length > 12) return false; // char 12
			if (itemshcode?.Length > 9) return false; // char 9
			if (itemname?.Length > 20) return false; // char 20
			if (itemprice?.Length > 10) return false; // char 10
			// itemsign char 1
			if (itemchange?.Length > 10) return false; // char 10
			// itemdiff double 6.2
			if (elwshcode?.Length > 6) return false; // char 6
			// bepoint double 12.2

			return true;
		}
	}

	/// <summary>
	/// ELW등락율상위(t1960)
	/// </summary>
	public partial class XQt1960 : XingQuery
	{
		/// <summary>
		/// t1960
		/// </summary>
		public const string _typeName = "t1960";
		/// <summary>
		/// ELW등락율상위(t1960)
		/// </summary>
		public const string _typeDesc = "ELW등락율상위(t1960)";
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
		/// t1960
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// ELW등락율상위(t1960)
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
		/// ELW등락율상위(t1960)
		/// </summary>
		public XQt1960() : base("t1960") { }


		public class XQAllOutBlocks
		{
			public XQt1960OutBlock OutBlock { get; internal set; }
			public XQt1960OutBlock1[] OutBlock1 { get; internal set; }
		}

		public static XQAllOutBlocks Get(char gubun = default,string ggubun = default,string itemcode = default,string lastdate = default,string exgubun = default,long sprice = default,long eprice = default,long volume = default,long sjanday = default,long ejanday = default,long idx = default)
		{
			using (XQt1960 instance = new XQt1960())
			{
				instance.SetFieldData(XQt1960InBlock.BlockName, XQt1960InBlock.F.gubun, 0, gubun.ToString()); // char 1
				instance.SetFieldData(XQt1960InBlock.BlockName, XQt1960InBlock.F.ggubun, 0, ggubun); // char 2
				instance.SetFieldData(XQt1960InBlock.BlockName, XQt1960InBlock.F.itemcode, 0, itemcode); // char 12
				instance.SetFieldData(XQt1960InBlock.BlockName, XQt1960InBlock.F.lastdate, 0, lastdate); // char 8
				instance.SetFieldData(XQt1960InBlock.BlockName, XQt1960InBlock.F.exgubun, 0, exgubun); // char 6
				instance.SetFieldData(XQt1960InBlock.BlockName, XQt1960InBlock.F.sprice, 0, sprice.ToString("d8")); // long 8
				instance.SetFieldData(XQt1960InBlock.BlockName, XQt1960InBlock.F.eprice, 0, eprice.ToString("d8")); // long 8
				instance.SetFieldData(XQt1960InBlock.BlockName, XQt1960InBlock.F.volume, 0, volume.ToString("d12")); // long 12
				instance.SetFieldData(XQt1960InBlock.BlockName, XQt1960InBlock.F.sjanday, 0, sjanday.ToString("d8")); // long 8
				instance.SetFieldData(XQt1960InBlock.BlockName, XQt1960InBlock.F.ejanday, 0, ejanday.ToString("d8")); // long 8
				instance.SetFieldData(XQt1960InBlock.BlockName, XQt1960InBlock.F.idx, 0, idx.ToString("d4")); // long 4

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

		public static XQAllOutBlocks ReadFromDB(/* char gubun = default,string ggubun = default,string itemcode = default,string lastdate = default,string exgubun = default,long sprice = default,long eprice = default,long volume = default,long sjanday = default,long ejanday = default,long idx = default */)
		{
			using (XQt1960 instance = new XQt1960())
			{

				XQAllOutBlocks results = new XQAllOutBlocks();

				QueryOption qo = new QueryOption("XQt1960OutBlock");
				results.OutBlock = instance.Select<XQt1960OutBlock>(qo);

				qo = new QueryOption("XQt1960OutBlock1");
				results.OutBlock1 = instance.SelectMany<XQt1960OutBlock1>(qo);
				return results;
			}
		}

		public bool SetBlock(XQt1960InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "gubun", 0, block.gubun.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "ggubun", 0, block.ggubun); // char 2
			_xaQuery.SetFieldData(block.GetBlockName(), "itemcode", 0, block.itemcode); // char 12
			_xaQuery.SetFieldData(block.GetBlockName(), "lastdate", 0, block.lastdate); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "exgubun", 0, block.exgubun); // char 6
			_xaQuery.SetFieldData(block.GetBlockName(), "sprice", 0, block.sprice.ToString("d8")); // long 8
			_xaQuery.SetFieldData(block.GetBlockName(), "eprice", 0, block.eprice.ToString("d8")); // long 8
			_xaQuery.SetFieldData(block.GetBlockName(), "volume", 0, block.volume.ToString("d12")); // long 12
			_xaQuery.SetFieldData(block.GetBlockName(), "sjanday", 0, block.sjanday.ToString("d8")); // long 8
			_xaQuery.SetFieldData(block.GetBlockName(), "ejanday", 0, block.ejanday.ToString("d8")); // long 8
			_xaQuery.SetFieldData(block.GetBlockName(), "idx", 0, block.idx.ToString("d4")); // long 4

			return true;
		}

		public XQt1960OutBlock GetBlock()
		{
			XQt1960OutBlock instance = XQt1960OutBlock.FromQuery(this);
			return instance;

		}

		public XQt1960OutBlock1[] GetBlock1s()
		{
			XQt1960OutBlock1[] instance = XQt1960OutBlock1.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt1960OutBlock),
			typeof(XQt1960OutBlock1),

		};

	}

}
