using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1771InBlock : XingBlock
	{
		/// <summary>
		/// t1771InBlock
		/// </summary>
		public const string _blockName = "t1771InBlock";
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
		/// t1771InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1771InBlock
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
		/// <summary>
		/// 거래원코드
		/// </summary>
		[XAQueryFieldAttribute("거래원코드")]
		public string tradno;
		/// <summary>
		/// 구분1
		/// </summary>
		[XAQueryFieldAttribute("구분1")]
		public char gubun1;
		/// <summary>
		/// 거래원날짜1
		/// </summary>
		[XAQueryFieldAttribute("거래원날짜1")]
		public string traddate1;
		/// <summary>
		/// 거래원날짜2
		/// </summary>
		[XAQueryFieldAttribute("거래원날짜2")]
		public string traddate2;
		/// <summary>
		/// CTSIDX
		/// </summary>
		[XAQueryFieldAttribute("CTSIDX")]
		public long cts_idx;
		/// <summary>
		/// 요청건수
		/// </summary>
		[XAQueryFieldAttribute("요청건수")]
		public int cnt;

		public static class F
		{
			/// <summary>
			/// 종목코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 거래원코드
			/// </summary>
			public const string tradno = "tradno";
			/// <summary>
			/// 구분1
			/// </summary>
			public const string gubun1 = "gubun1";
			/// <summary>
			/// 거래원날짜1
			/// </summary>
			public const string traddate1 = "traddate1";
			/// <summary>
			/// 거래원날짜2
			/// </summary>
			public const string traddate2 = "traddate2";
			/// <summary>
			/// CTSIDX
			/// </summary>
			public const string cts_idx = "cts_idx";
			/// <summary>
			/// 요청건수
			/// </summary>
			public const string cnt = "cnt";
		}

		public static string[] AllFields = new string[]
		{
			F.shcode,
			F.tradno,
			F.gubun1,
			F.traddate1,
			F.traddate2,
			F.cts_idx,
			F.cnt,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "종목코드", (decimal)6);
			dict["tradno"] = new XAQueryFieldInfo("char", tradno, tradno, "거래원코드", (decimal)3);
			dict["gubun1"] = new XAQueryFieldInfo("char", gubun1, gubun1.ToString(), "구분1", (decimal)1);
			dict["traddate1"] = new XAQueryFieldInfo("char", traddate1, traddate1, "거래원날짜1", (decimal)8);
			dict["traddate2"] = new XAQueryFieldInfo("char", traddate2, traddate2, "거래원날짜2", (decimal)8);
			dict["cts_idx"] = new XAQueryFieldInfo("long", cts_idx, cts_idx.ToString("d4"), "CTSIDX", (decimal)4);
			dict["cnt"] = new XAQueryFieldInfo("int", cnt, cnt.ToString("d3"), "요청건수", (decimal)3);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "tradno":
					this.tradno = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "gubun1":
					this.gubun1 = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "traddate1":
					this.traddate1 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "traddate2":
					this.traddate2 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cts_idx":
					this.cts_idx = fieldInfo.FieldValue.ParseLong("cts_idx");
				break;

				case "cnt":
					this.cnt = fieldInfo.FieldValue.ParseInt("cnt");
				break;


			}
		}

		public bool VerifyData()
		{
			if (shcode?.Length > 6) return false; // char 6
			if (tradno?.Length > 3) return false; // char 3
			// gubun1 char 1
			if (traddate1?.Length > 8) return false; // char 8
			if (traddate2?.Length > 8) return false; // char 8
			if (cts_idx.ToString().Length > 4) return false; // long 4
			// cnt int 3

			return true;
		}
	}

	public partial class XQt1771OutBlock : XingBlock
	{
		/// <summary>
		/// t1771OutBlock
		/// </summary>
		public const string _blockName = "t1771OutBlock";
		/// <summary>
		/// 기본출력
		/// </summary>
		public const string _blockDesc = "기본출력";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// false
		/// </summary>
		public const bool _hasOccurs = false;
		/// <summary>
		/// t1771OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1771OutBlock
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
		/// CTSIDX
		/// </summary>
		[XAQueryFieldAttribute("CTSIDX")]
		public long cts_idx;

		public static class F
		{
			/// <summary>
			/// CTSIDX
			/// </summary>
			public const string cts_idx = "cts_idx";
		}

		public static string[] AllFields = new string[]
		{
			F.cts_idx,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["cts_idx"] = new XAQueryFieldInfo("long", cts_idx, cts_idx.ToString("d4"), "CTSIDX", (decimal)4);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "cts_idx":
					this.cts_idx = fieldInfo.FieldValue.ParseLong("cts_idx");
				break;


			}
		}

		public static XQt1771OutBlock FromQuery(XQt1771 query)
		{
			XQt1771OutBlock block = new XQt1771OutBlock();
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
				block.cts_idx = query.GetFieldData(block.GetBlockName(), "cts_idx", 0).ParseLong("cts_idx"); // long 4

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (cts_idx.ToString().Length > 4) return false; // long 4

			return true;
		}
	}

	public partial class XQt1771OutBlock2 : XingBlock
	{
		/// <summary>
		/// t1771OutBlock2
		/// </summary>
		public const string _blockName = "t1771OutBlock2";
		/// <summary>
		/// 출력2
		/// </summary>
		public const string _blockDesc = "출력2";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// true
		/// </summary>
		public const bool _hasOccurs = true;
		/// <summary>
		/// t1771OutBlock2
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1771OutBlock2
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
		/// true
		/// </summary>
		public bool HasOccurs => _hasOccurs;

		/// <summary>
		/// 날짜
		/// </summary>
		[XAQueryFieldAttribute("날짜")]
		public string traddate;
		/// <summary>
		/// 시간
		/// </summary>
		[XAQueryFieldAttribute("시간")]
		public string tradtime;
		/// <summary>
		/// 현재가
		/// </summary>
		[XAQueryFieldAttribute("현재가")]
		public long price;
		/// <summary>
		/// 대비구분
		/// </summary>
		[XAQueryFieldAttribute("대비구분")]
		public char sign;
		/// <summary>
		/// 대비
		/// </summary>
		[XAQueryFieldAttribute("대비")]
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
		/// 매도
		/// </summary>
		[XAQueryFieldAttribute("매도")]
		public long tradmdcha;
		/// <summary>
		/// 매수
		/// </summary>
		[XAQueryFieldAttribute("매수")]
		public long tradmscha;
		/// <summary>
		/// 매도대금
		/// </summary>
		[XAQueryFieldAttribute("매도대금")]
		public long tradmdval;
		/// <summary>
		/// 매수대금
		/// </summary>
		[XAQueryFieldAttribute("매수대금")]
		public long tradmsval;
		/// <summary>
		/// 순매수
		/// </summary>
		[XAQueryFieldAttribute("순매수")]
		public long tradmsscha;
		/// <summary>
		/// 누적순매수
		/// </summary>
		[XAQueryFieldAttribute("누적순매수")]
		public long tradmttvolume;
		/// <summary>
		/// 평균단가
		/// </summary>
		[XAQueryFieldAttribute("평균단가")]
		public long tradavg;
		/// <summary>
		/// 누적평균단가
		/// </summary>
		[XAQueryFieldAttribute("누적평균단가")]
		public long tradmttavg;

		public static class F
		{
			/// <summary>
			/// 날짜
			/// </summary>
			public const string traddate = "traddate";
			/// <summary>
			/// 시간
			/// </summary>
			public const string tradtime = "tradtime";
			/// <summary>
			/// 현재가
			/// </summary>
			public const string price = "price";
			/// <summary>
			/// 대비구분
			/// </summary>
			public const string sign = "sign";
			/// <summary>
			/// 대비
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
			/// 매도
			/// </summary>
			public const string tradmdcha = "tradmdcha";
			/// <summary>
			/// 매수
			/// </summary>
			public const string tradmscha = "tradmscha";
			/// <summary>
			/// 매도대금
			/// </summary>
			public const string tradmdval = "tradmdval";
			/// <summary>
			/// 매수대금
			/// </summary>
			public const string tradmsval = "tradmsval";
			/// <summary>
			/// 순매수
			/// </summary>
			public const string tradmsscha = "tradmsscha";
			/// <summary>
			/// 누적순매수
			/// </summary>
			public const string tradmttvolume = "tradmttvolume";
			/// <summary>
			/// 평균단가
			/// </summary>
			public const string tradavg = "tradavg";
			/// <summary>
			/// 누적평균단가
			/// </summary>
			public const string tradmttavg = "tradmttavg";
		}

		public static string[] AllFields = new string[]
		{
			F.traddate,
			F.tradtime,
			F.price,
			F.sign,
			F.change,
			F.diff,
			F.volume,
			F.tradmdcha,
			F.tradmscha,
			F.tradmdval,
			F.tradmsval,
			F.tradmsscha,
			F.tradmttvolume,
			F.tradavg,
			F.tradmttavg,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["traddate"] = new XAQueryFieldInfo("char", traddate, traddate, "날짜", (decimal)8);
			dict["tradtime"] = new XAQueryFieldInfo("char", tradtime, tradtime, "시간", (decimal)8);
			dict["price"] = new XAQueryFieldInfo("long", price, price.ToString("d8"), "현재가", (decimal)8);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("long", change, change.ToString("d8"), "대비", (decimal)8);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "거래량", (decimal)12);
			dict["tradmdcha"] = new XAQueryFieldInfo("long", tradmdcha, tradmdcha.ToString("d12"), "매도", (decimal)12);
			dict["tradmscha"] = new XAQueryFieldInfo("long", tradmscha, tradmscha.ToString("d12"), "매수", (decimal)12);
			dict["tradmdval"] = new XAQueryFieldInfo("long", tradmdval, tradmdval.ToString("d18"), "매도대금", (decimal)18);
			dict["tradmsval"] = new XAQueryFieldInfo("long", tradmsval, tradmsval.ToString("d18"), "매수대금", (decimal)18);
			dict["tradmsscha"] = new XAQueryFieldInfo("long", tradmsscha, tradmsscha.ToString("d12"), "순매수", (decimal)12);
			dict["tradmttvolume"] = new XAQueryFieldInfo("long", tradmttvolume, tradmttvolume.ToString("d12"), "누적순매수", (decimal)12);
			dict["tradavg"] = new XAQueryFieldInfo("long", tradavg, tradavg.ToString("d8"), "평균단가", (decimal)8);
			dict["tradmttavg"] = new XAQueryFieldInfo("long", tradmttavg, tradmttavg.ToString("d8"), "누적평균단가", (decimal)8);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "traddate":
					this.traddate = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "tradtime":
					this.tradtime = fieldInfo.FieldValue.TrimEnd('?');
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

				case "tradmdcha":
					this.tradmdcha = fieldInfo.FieldValue.ParseLong("tradmdcha");
				break;

				case "tradmscha":
					this.tradmscha = fieldInfo.FieldValue.ParseLong("tradmscha");
				break;

				case "tradmdval":
					this.tradmdval = fieldInfo.FieldValue.ParseLong("tradmdval");
				break;

				case "tradmsval":
					this.tradmsval = fieldInfo.FieldValue.ParseLong("tradmsval");
				break;

				case "tradmsscha":
					this.tradmsscha = fieldInfo.FieldValue.ParseLong("tradmsscha");
				break;

				case "tradmttvolume":
					this.tradmttvolume = fieldInfo.FieldValue.ParseLong("tradmttvolume");
				break;

				case "tradavg":
					this.tradavg = fieldInfo.FieldValue.ParseLong("tradavg");
				break;

				case "tradmttavg":
					this.tradmttavg = fieldInfo.FieldValue.ParseLong("tradmttavg");
				break;


			}
		}

		public static XQt1771OutBlock2[] ListFromQuery(XQt1771 query)
		{
			int count = query.GetBlockCount(XQt1771OutBlock2.BlockName);
			List<XQt1771OutBlock2> list = new List<XQt1771OutBlock2>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1771OutBlock2 block = new XQt1771OutBlock2();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.traddate = query.GetFieldData(block.GetBlockName(), "traddate", i).TrimEnd('?'); // char 8
					block.tradtime = query.GetFieldData(block.GetBlockName(), "tradtime", i).TrimEnd('?'); // char 8
					block.price = query.GetFieldData(block.GetBlockName(), "price", i).ParseLong("price"); // long 8
					block.sign = query.GetFieldData(block.GetBlockName(), "sign", i).FirstOrDefault(); // char 1
					block.change = query.GetFieldData(block.GetBlockName(), "change", i).ParseLong("change"); // long 8
					block.diff = query.GetFieldData(block.GetBlockName(), "diff", i).ParseFloat("diff"); // float 6.2
					block.volume = query.GetFieldData(block.GetBlockName(), "volume", i).ParseLong("volume"); // long 12
					block.tradmdcha = query.GetFieldData(block.GetBlockName(), "tradmdcha", i).ParseLong("tradmdcha"); // long 12
					block.tradmscha = query.GetFieldData(block.GetBlockName(), "tradmscha", i).ParseLong("tradmscha"); // long 12
					block.tradmdval = query.GetFieldData(block.GetBlockName(), "tradmdval", i).ParseLong("tradmdval"); // long 18
					block.tradmsval = query.GetFieldData(block.GetBlockName(), "tradmsval", i).ParseLong("tradmsval"); // long 18
					block.tradmsscha = query.GetFieldData(block.GetBlockName(), "tradmsscha", i).ParseLong("tradmsscha"); // long 12
					block.tradmttvolume = query.GetFieldData(block.GetBlockName(), "tradmttvolume", i).ParseLong("tradmttvolume"); // long 12
					block.tradavg = query.GetFieldData(block.GetBlockName(), "tradavg", i).ParseLong("tradavg"); // long 8
					block.tradmttavg = query.GetFieldData(block.GetBlockName(), "tradmttavg", i).ParseLong("tradmttavg"); // long 8

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
			if (traddate?.Length > 8) return false; // char 8
			if (tradtime?.Length > 8) return false; // char 8
			if (price.ToString().Length > 8) return false; // long 8
			// sign char 1
			if (change.ToString().Length > 8) return false; // long 8
			// diff float 6.2
			if (volume.ToString().Length > 12) return false; // long 12
			if (tradmdcha.ToString().Length > 12) return false; // long 12
			if (tradmscha.ToString().Length > 12) return false; // long 12
			if (tradmdval.ToString().Length > 18) return false; // long 18
			if (tradmsval.ToString().Length > 18) return false; // long 18
			if (tradmsscha.ToString().Length > 12) return false; // long 12
			if (tradmttvolume.ToString().Length > 12) return false; // long 12
			if (tradavg.ToString().Length > 8) return false; // long 8
			if (tradmttavg.ToString().Length > 8) return false; // long 8

			return true;
		}
	}

	public partial class XQt1771 : XingQuery
	{
		/// <summary>
		/// t1771
		/// </summary>
		public const string _typeName = "t1771";
		/// <summary>
		/// 종목별회원사추이(t1771)
		/// </summary>
		public const string _typeDesc = "종목별회원사추이(t1771)";
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
		/// t1771
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 종목별회원사추이(t1771)
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

		public XQt1771() : base("t1771") { }


		public bool SetFields(XQt1771InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "shcode", 0, block.shcode); // char 6
			_xaQuery.SetFieldData(block.GetBlockName(), "tradno", 0, block.tradno); // char 3
			_xaQuery.SetFieldData(block.GetBlockName(), "gubun1", 0, block.gubun1.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "traddate1", 0, block.traddate1); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "traddate2", 0, block.traddate2); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "cts_idx", 0, block.cts_idx.ToString("d4")); // long 4
			_xaQuery.SetFieldData(block.GetBlockName(), "cnt", 0, block.cnt.ToString("d3")); // int 3

			return true;
		}

		public XQt1771OutBlock GetBlock()
		{
			XQt1771OutBlock instance = XQt1771OutBlock.FromQuery(this);
			return instance;

		}

		public XQt1771OutBlock2[] GetBlock2s()
		{
			XQt1771OutBlock2[] instance = XQt1771OutBlock2.ListFromQuery(this);
			return instance;

		}


	}

}
