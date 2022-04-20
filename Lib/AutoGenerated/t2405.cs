using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt2405InBlock : XingBlock
	{
		/// <summary>
		/// t2405InBlock
		/// </summary>
		public const string _blockName = "t2405InBlock";
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
		/// t2405InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t2405InBlock
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
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("focode", "단축코드", "char", "8")]
		public string focode;
		/// <summary>
		/// 분구분
		/// </summary>
		[XAQueryFieldAttribute("bgubun", "분구분", "char", "1")]
		public char bgubun;
		/// <summary>
		/// N분
		/// </summary>
		[XAQueryFieldAttribute("nmin", "N분", "int", "2")]
		public int nmin;
		/// <summary>
		/// 종료시간
		/// </summary>
		[XAQueryFieldAttribute("etime", "종료시간", "char", "4")]
		public string etime;
		/// <summary>
		/// 호가구분
		/// </summary>
		[XAQueryFieldAttribute("hgubun", "호가구분", "char", "1")]
		public char hgubun;
		/// <summary>
		/// 조회건수
		/// </summary>
		[XAQueryFieldAttribute("cnt", "조회건수", "int", "3")]
		public int cnt;
		/// <summary>
		/// 시간CTS
		/// </summary>
		[XAQueryFieldAttribute("cts_time", "시간CTS", "char", "6")]
		public string cts_time;

		public static class F
		{
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string focode = "focode";
			/// <summary>
			/// 분구분
			/// </summary>
			public const string bgubun = "bgubun";
			/// <summary>
			/// N분
			/// </summary>
			public const string nmin = "nmin";
			/// <summary>
			/// 종료시간
			/// </summary>
			public const string etime = "etime";
			/// <summary>
			/// 호가구분
			/// </summary>
			public const string hgubun = "hgubun";
			/// <summary>
			/// 조회건수
			/// </summary>
			public const string cnt = "cnt";
			/// <summary>
			/// 시간CTS
			/// </summary>
			public const string cts_time = "cts_time";
		}

		public static string[] AllFields = new string[]
		{
			F.focode,
			F.bgubun,
			F.nmin,
			F.etime,
			F.hgubun,
			F.cnt,
			F.cts_time,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["focode"] = new XAQueryFieldInfo("char", focode, focode, "단축코드", (decimal)8);
			dict["bgubun"] = new XAQueryFieldInfo("char", bgubun, bgubun.ToString(), "분구분", (decimal)1);
			dict["nmin"] = new XAQueryFieldInfo("int", nmin, nmin.ToString("d2"), "N분", (decimal)2);
			dict["etime"] = new XAQueryFieldInfo("char", etime, etime, "종료시간", (decimal)4);
			dict["hgubun"] = new XAQueryFieldInfo("char", hgubun, hgubun.ToString(), "호가구분", (decimal)1);
			dict["cnt"] = new XAQueryFieldInfo("int", cnt, cnt.ToString("d3"), "조회건수", (decimal)3);
			dict["cts_time"] = new XAQueryFieldInfo("char", cts_time, cts_time, "시간CTS", (decimal)6);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "focode":
					this.focode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "bgubun":
					this.bgubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "nmin":
					this.nmin = fieldInfo.FieldValue.ParseInt("nmin");
				break;

				case "etime":
					this.etime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "hgubun":
					this.hgubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "cnt":
					this.cnt = fieldInfo.FieldValue.ParseInt("cnt");
				break;

				case "cts_time":
					this.cts_time = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (focode?.Length > 8) return false; // char 8
			// bgubun char 1
			// nmin int 2
			if (etime?.Length > 4) return false; // char 4
			// hgubun char 1
			// cnt int 3
			if (cts_time?.Length > 6) return false; // char 6

			return true;
		}

		public void CopyTo(XQt2405InBlock block)
		{
			block.focode = this.focode;
			block.bgubun = this.bgubun;
			block.nmin = this.nmin;
			block.etime = this.etime;
			block.hgubun = this.hgubun;
			block.cnt = this.cnt;
			block.cts_time = this.cts_time;

		}
	}

	public partial class XQt2405OutBlock : XingBlock
	{
		/// <summary>
		/// t2405OutBlock
		/// </summary>
		public const string _blockName = "t2405OutBlock";
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
		/// t2405OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t2405OutBlock
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
		/// 매도체결수량
		/// </summary>
		[XAQueryFieldAttribute("mdvolume", "매도체결수량", "double", "12.0")]
		public double mdvolume;
		/// <summary>
		/// 매도체결건수
		/// </summary>
		[XAQueryFieldAttribute("mdchecnt", "매도체결건수", "long", "8")]
		public long mdchecnt;
		/// <summary>
		/// 매수체결수량
		/// </summary>
		[XAQueryFieldAttribute("msvolume", "매수체결수량", "double", "12.0")]
		public double msvolume;
		/// <summary>
		/// 매수체결건수
		/// </summary>
		[XAQueryFieldAttribute("mschecnt", "매수체결건수", "long", "8")]
		public long mschecnt;
		/// <summary>
		/// 시간CTS
		/// </summary>
		[XAQueryFieldAttribute("cts_time", "시간CTS", "char", "6")]
		public string cts_time;

		public static class F
		{
			/// <summary>
			/// 매도체결수량
			/// </summary>
			public const string mdvolume = "mdvolume";
			/// <summary>
			/// 매도체결건수
			/// </summary>
			public const string mdchecnt = "mdchecnt";
			/// <summary>
			/// 매수체결수량
			/// </summary>
			public const string msvolume = "msvolume";
			/// <summary>
			/// 매수체결건수
			/// </summary>
			public const string mschecnt = "mschecnt";
			/// <summary>
			/// 시간CTS
			/// </summary>
			public const string cts_time = "cts_time";
		}

		public static string[] AllFields = new string[]
		{
			F.mdvolume,
			F.mdchecnt,
			F.msvolume,
			F.mschecnt,
			F.cts_time,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["mdvolume"] = new XAQueryFieldInfo("double", mdvolume, mdvolume.ToString("000000000000."), "매도체결수량", (decimal)12.0);
			dict["mdchecnt"] = new XAQueryFieldInfo("long", mdchecnt, mdchecnt.ToString("d8"), "매도체결건수", (decimal)8);
			dict["msvolume"] = new XAQueryFieldInfo("double", msvolume, msvolume.ToString("000000000000."), "매수체결수량", (decimal)12.0);
			dict["mschecnt"] = new XAQueryFieldInfo("long", mschecnt, mschecnt.ToString("d8"), "매수체결건수", (decimal)8);
			dict["cts_time"] = new XAQueryFieldInfo("char", cts_time, cts_time, "시간CTS", (decimal)6);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "mdvolume":
					this.mdvolume = fieldInfo.FieldValue.ParseDouble("mdvolume");
				break;

				case "mdchecnt":
					this.mdchecnt = fieldInfo.FieldValue.ParseLong("mdchecnt");
				break;

				case "msvolume":
					this.msvolume = fieldInfo.FieldValue.ParseDouble("msvolume");
				break;

				case "mschecnt":
					this.mschecnt = fieldInfo.FieldValue.ParseLong("mschecnt");
				break;

				case "cts_time":
					this.cts_time = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt2405OutBlock FromQuery(XQt2405 query)
		{
			XQt2405OutBlock block = new XQt2405OutBlock();
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
				block.mdvolume = query.GetFieldData(block.GetBlockName(), "mdvolume", 0).ParseDouble("mdvolume"); // double 12.0
				block.mdchecnt = query.GetFieldData(block.GetBlockName(), "mdchecnt", 0).ParseLong("mdchecnt"); // long 8
				block.msvolume = query.GetFieldData(block.GetBlockName(), "msvolume", 0).ParseDouble("msvolume"); // double 12.0
				block.mschecnt = query.GetFieldData(block.GetBlockName(), "mschecnt", 0).ParseLong("mschecnt"); // long 8
				block.cts_time = query.GetFieldData(block.GetBlockName(), "cts_time", 0).TrimEnd('?'); // char 6

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			// mdvolume double 12.0
			if (mdchecnt.ToString().Length > 8) return false; // long 8
			// msvolume double 12.0
			if (mschecnt.ToString().Length > 8) return false; // long 8
			if (cts_time?.Length > 6) return false; // char 6

			return true;
		}

		public void CopyTo(XQt2405OutBlock block)
		{
			block.mdvolume = this.mdvolume;
			block.mdchecnt = this.mdchecnt;
			block.msvolume = this.msvolume;
			block.mschecnt = this.mschecnt;
			block.cts_time = this.cts_time;

		}
	}

	public partial class XQt2405OutBlock1 : XingBlock
	{
		/// <summary>
		/// t2405OutBlock1
		/// </summary>
		public const string _blockName = "t2405OutBlock1";
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
		/// t2405OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t2405OutBlock1
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
		/// 시간
		/// </summary>
		[XAQueryFieldAttribute("time", "시간", "char", "6")]
		public string time;
		/// <summary>
		/// 현재가
		/// </summary>
		[XAQueryFieldAttribute("price", "현재가", "float", "6.2")]
		public float price;
		/// <summary>
		/// 전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("sign", "전일대비구분", "char", "1")]
		public char sign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[XAQueryFieldAttribute("change", "전일대비", "float", "6.2")]
		public float change;
		/// <summary>
		/// 누적거래량
		/// </summary>
		[XAQueryFieldAttribute("volume", "누적거래량", "double", "12.0")]
		public double volume;
		/// <summary>
		/// 체결수량
		/// </summary>
		[XAQueryFieldAttribute("cvolume", "체결수량", "long", "8")]
		public long cvolume;
		/// <summary>
		/// 매도1호가
		/// </summary>
		[XAQueryFieldAttribute("offerho1", "매도1호가", "float", "6.2")]
		public float offerho1;
		/// <summary>
		/// 매수1호가
		/// </summary>
		[XAQueryFieldAttribute("bidho1", "매수1호가", "float", "6.2")]
		public float bidho1;
		/// <summary>
		/// 매도수량
		/// </summary>
		[XAQueryFieldAttribute("offerrem", "매도수량", "long", "8")]
		public long offerrem;
		/// <summary>
		/// 매수수량
		/// </summary>
		[XAQueryFieldAttribute("bidrem", "매수수량", "long", "8")]
		public long bidrem;
		/// <summary>
		/// 매도건수
		/// </summary>
		[XAQueryFieldAttribute("offercnt", "매도건수", "long", "8")]
		public long offercnt;
		/// <summary>
		/// 매수건수
		/// </summary>
		[XAQueryFieldAttribute("bidcnt", "매수건수", "long", "8")]
		public long bidcnt;
		/// <summary>
		/// 매도증감수량
		/// </summary>
		[XAQueryFieldAttribute("c_offerrem", "매도증감수량", "long", "8")]
		public long c_offerrem;
		/// <summary>
		/// 매수증감수량
		/// </summary>
		[XAQueryFieldAttribute("c_bidrem", "매수증감수량", "long", "8")]
		public long c_bidrem;
		/// <summary>
		/// 매도증감건수
		/// </summary>
		[XAQueryFieldAttribute("c_offercnt", "매도증감건수", "long", "8")]
		public long c_offercnt;
		/// <summary>
		/// 매수증감건수
		/// </summary>
		[XAQueryFieldAttribute("c_bidcnt", "매수증감건수", "long", "8")]
		public long c_bidcnt;
		/// <summary>
		/// 매수수량비율
		/// </summary>
		[XAQueryFieldAttribute("r_bidrem", "매수수량비율", "float", "6.2")]
		public float r_bidrem;
		/// <summary>
		/// 매수건수비율
		/// </summary>
		[XAQueryFieldAttribute("r_bidcnt", "매수건수비율", "float", "6.2")]
		public float r_bidcnt;
		/// <summary>
		/// 매수비율구분
		/// </summary>
		[XAQueryFieldAttribute("r_sign", "매수비율구분", "char", "1")]
		public char r_sign;
		/// <summary>
		/// 일자
		/// </summary>
		[XAQueryFieldAttribute("date", "일자", "date", "8")]
		public string date;

		public static class F
		{
			/// <summary>
			/// 시간
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
			/// 체결수량
			/// </summary>
			public const string cvolume = "cvolume";
			/// <summary>
			/// 매도1호가
			/// </summary>
			public const string offerho1 = "offerho1";
			/// <summary>
			/// 매수1호가
			/// </summary>
			public const string bidho1 = "bidho1";
			/// <summary>
			/// 매도수량
			/// </summary>
			public const string offerrem = "offerrem";
			/// <summary>
			/// 매수수량
			/// </summary>
			public const string bidrem = "bidrem";
			/// <summary>
			/// 매도건수
			/// </summary>
			public const string offercnt = "offercnt";
			/// <summary>
			/// 매수건수
			/// </summary>
			public const string bidcnt = "bidcnt";
			/// <summary>
			/// 매도증감수량
			/// </summary>
			public const string c_offerrem = "c_offerrem";
			/// <summary>
			/// 매수증감수량
			/// </summary>
			public const string c_bidrem = "c_bidrem";
			/// <summary>
			/// 매도증감건수
			/// </summary>
			public const string c_offercnt = "c_offercnt";
			/// <summary>
			/// 매수증감건수
			/// </summary>
			public const string c_bidcnt = "c_bidcnt";
			/// <summary>
			/// 매수수량비율
			/// </summary>
			public const string r_bidrem = "r_bidrem";
			/// <summary>
			/// 매수건수비율
			/// </summary>
			public const string r_bidcnt = "r_bidcnt";
			/// <summary>
			/// 매수비율구분
			/// </summary>
			public const string r_sign = "r_sign";
			/// <summary>
			/// 일자
			/// </summary>
			public const string date = "date";
		}

		public static string[] AllFields = new string[]
		{
			F.time,
			F.price,
			F.sign,
			F.change,
			F.volume,
			F.cvolume,
			F.offerho1,
			F.bidho1,
			F.offerrem,
			F.bidrem,
			F.offercnt,
			F.bidcnt,
			F.c_offerrem,
			F.c_bidrem,
			F.c_offercnt,
			F.c_bidcnt,
			F.r_bidrem,
			F.r_bidcnt,
			F.r_sign,
			F.date,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["time"] = new XAQueryFieldInfo("char", time, time, "시간", (decimal)6);
			dict["price"] = new XAQueryFieldInfo("float", price, price.ToString("000000.00"), "현재가", (decimal)6.2);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("float", change, change.ToString("000000.00"), "전일대비", (decimal)6.2);
			dict["volume"] = new XAQueryFieldInfo("double", volume, volume.ToString("000000000000."), "누적거래량", (decimal)12.0);
			dict["cvolume"] = new XAQueryFieldInfo("long", cvolume, cvolume.ToString("d8"), "체결수량", (decimal)8);
			dict["offerho1"] = new XAQueryFieldInfo("float", offerho1, offerho1.ToString("000000.00"), "매도1호가", (decimal)6.2);
			dict["bidho1"] = new XAQueryFieldInfo("float", bidho1, bidho1.ToString("000000.00"), "매수1호가", (decimal)6.2);
			dict["offerrem"] = new XAQueryFieldInfo("long", offerrem, offerrem.ToString("d8"), "매도수량", (decimal)8);
			dict["bidrem"] = new XAQueryFieldInfo("long", bidrem, bidrem.ToString("d8"), "매수수량", (decimal)8);
			dict["offercnt"] = new XAQueryFieldInfo("long", offercnt, offercnt.ToString("d8"), "매도건수", (decimal)8);
			dict["bidcnt"] = new XAQueryFieldInfo("long", bidcnt, bidcnt.ToString("d8"), "매수건수", (decimal)8);
			dict["c_offerrem"] = new XAQueryFieldInfo("long", c_offerrem, c_offerrem.ToString("d8"), "매도증감수량", (decimal)8);
			dict["c_bidrem"] = new XAQueryFieldInfo("long", c_bidrem, c_bidrem.ToString("d8"), "매수증감수량", (decimal)8);
			dict["c_offercnt"] = new XAQueryFieldInfo("long", c_offercnt, c_offercnt.ToString("d8"), "매도증감건수", (decimal)8);
			dict["c_bidcnt"] = new XAQueryFieldInfo("long", c_bidcnt, c_bidcnt.ToString("d8"), "매수증감건수", (decimal)8);
			dict["r_bidrem"] = new XAQueryFieldInfo("float", r_bidrem, r_bidrem.ToString("000000.00"), "매수수량비율", (decimal)6.2);
			dict["r_bidcnt"] = new XAQueryFieldInfo("float", r_bidcnt, r_bidcnt.ToString("000000.00"), "매수건수비율", (decimal)6.2);
			dict["r_sign"] = new XAQueryFieldInfo("char", r_sign, r_sign.ToString(), "매수비율구분", (decimal)1);
			dict["date"] = new XAQueryFieldInfo("date", date, date, "일자", (decimal)8);

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
					this.price = fieldInfo.FieldValue.ParseFloat("price");
				break;

				case "sign":
					this.sign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "change":
					this.change = fieldInfo.FieldValue.ParseFloat("change");
				break;

				case "volume":
					this.volume = fieldInfo.FieldValue.ParseDouble("volume");
				break;

				case "cvolume":
					this.cvolume = fieldInfo.FieldValue.ParseLong("cvolume");
				break;

				case "offerho1":
					this.offerho1 = fieldInfo.FieldValue.ParseFloat("offerho1");
				break;

				case "bidho1":
					this.bidho1 = fieldInfo.FieldValue.ParseFloat("bidho1");
				break;

				case "offerrem":
					this.offerrem = fieldInfo.FieldValue.ParseLong("offerrem");
				break;

				case "bidrem":
					this.bidrem = fieldInfo.FieldValue.ParseLong("bidrem");
				break;

				case "offercnt":
					this.offercnt = fieldInfo.FieldValue.ParseLong("offercnt");
				break;

				case "bidcnt":
					this.bidcnt = fieldInfo.FieldValue.ParseLong("bidcnt");
				break;

				case "c_offerrem":
					this.c_offerrem = fieldInfo.FieldValue.ParseLong("c_offerrem");
				break;

				case "c_bidrem":
					this.c_bidrem = fieldInfo.FieldValue.ParseLong("c_bidrem");
				break;

				case "c_offercnt":
					this.c_offercnt = fieldInfo.FieldValue.ParseLong("c_offercnt");
				break;

				case "c_bidcnt":
					this.c_bidcnt = fieldInfo.FieldValue.ParseLong("c_bidcnt");
				break;

				case "r_bidrem":
					this.r_bidrem = fieldInfo.FieldValue.ParseFloat("r_bidrem");
				break;

				case "r_bidcnt":
					this.r_bidcnt = fieldInfo.FieldValue.ParseFloat("r_bidcnt");
				break;

				case "r_sign":
					this.r_sign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "date":
					this.date = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt2405OutBlock1[] ListFromQuery(XQt2405 query)
		{
			int count = query.GetBlockCount(XQt2405OutBlock1.BlockName);
			List<XQt2405OutBlock1> list = new List<XQt2405OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt2405OutBlock1 block = new XQt2405OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.time = query.GetFieldData(block.GetBlockName(), "time", i).TrimEnd('?'); // char 6
					block.price = query.GetFieldData(block.GetBlockName(), "price", i).ParseFloat("price"); // float 6.2
					block.sign = query.GetFieldData(block.GetBlockName(), "sign", i).FirstOrDefault(); // char 1
					block.change = query.GetFieldData(block.GetBlockName(), "change", i).ParseFloat("change"); // float 6.2
					block.volume = query.GetFieldData(block.GetBlockName(), "volume", i).ParseDouble("volume"); // double 12.0
					block.cvolume = query.GetFieldData(block.GetBlockName(), "cvolume", i).ParseLong("cvolume"); // long 8
					block.offerho1 = query.GetFieldData(block.GetBlockName(), "offerho1", i).ParseFloat("offerho1"); // float 6.2
					block.bidho1 = query.GetFieldData(block.GetBlockName(), "bidho1", i).ParseFloat("bidho1"); // float 6.2
					block.offerrem = query.GetFieldData(block.GetBlockName(), "offerrem", i).ParseLong("offerrem"); // long 8
					block.bidrem = query.GetFieldData(block.GetBlockName(), "bidrem", i).ParseLong("bidrem"); // long 8
					block.offercnt = query.GetFieldData(block.GetBlockName(), "offercnt", i).ParseLong("offercnt"); // long 8
					block.bidcnt = query.GetFieldData(block.GetBlockName(), "bidcnt", i).ParseLong("bidcnt"); // long 8
					block.c_offerrem = query.GetFieldData(block.GetBlockName(), "c_offerrem", i).ParseLong("c_offerrem"); // long 8
					block.c_bidrem = query.GetFieldData(block.GetBlockName(), "c_bidrem", i).ParseLong("c_bidrem"); // long 8
					block.c_offercnt = query.GetFieldData(block.GetBlockName(), "c_offercnt", i).ParseLong("c_offercnt"); // long 8
					block.c_bidcnt = query.GetFieldData(block.GetBlockName(), "c_bidcnt", i).ParseLong("c_bidcnt"); // long 8
					block.r_bidrem = query.GetFieldData(block.GetBlockName(), "r_bidrem", i).ParseFloat("r_bidrem"); // float 6.2
					block.r_bidcnt = query.GetFieldData(block.GetBlockName(), "r_bidcnt", i).ParseFloat("r_bidcnt"); // float 6.2
					block.r_sign = query.GetFieldData(block.GetBlockName(), "r_sign", i).FirstOrDefault(); // char 1
					block.date = query.GetFieldData(block.GetBlockName(), "date", i).TrimEnd('?'); // date 8

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
			if (time?.Length > 6) return false; // char 6
			// price float 6.2
			// sign char 1
			// change float 6.2
			// volume double 12.0
			if (cvolume.ToString().Length > 8) return false; // long 8
			// offerho1 float 6.2
			// bidho1 float 6.2
			if (offerrem.ToString().Length > 8) return false; // long 8
			if (bidrem.ToString().Length > 8) return false; // long 8
			if (offercnt.ToString().Length > 8) return false; // long 8
			if (bidcnt.ToString().Length > 8) return false; // long 8
			if (c_offerrem.ToString().Length > 8) return false; // long 8
			if (c_bidrem.ToString().Length > 8) return false; // long 8
			if (c_offercnt.ToString().Length > 8) return false; // long 8
			if (c_bidcnt.ToString().Length > 8) return false; // long 8
			// r_bidrem float 6.2
			// r_bidcnt float 6.2
			// r_sign char 1
			if (date?.Length > 8) return false; // date 8

			return true;
		}

		public void CopyTo(XQt2405OutBlock1 block)
		{
			block.time = this.time;
			block.price = this.price;
			block.sign = this.sign;
			block.change = this.change;
			block.volume = this.volume;
			block.cvolume = this.cvolume;
			block.offerho1 = this.offerho1;
			block.bidho1 = this.bidho1;
			block.offerrem = this.offerrem;
			block.bidrem = this.bidrem;
			block.offercnt = this.offercnt;
			block.bidcnt = this.bidcnt;
			block.c_offerrem = this.c_offerrem;
			block.c_bidrem = this.c_bidrem;
			block.c_offercnt = this.c_offercnt;
			block.c_bidcnt = this.c_bidcnt;
			block.r_bidrem = this.r_bidrem;
			block.r_bidcnt = this.r_bidcnt;
			block.r_sign = this.r_sign;
			block.date = this.date;

		}
	}

	/// <summary>
	/// 선물옵션호가잔량비율챠트(t2405)
	/// </summary>
	public partial class XQt2405 : XingQuery
	{
		/// <summary>
		/// t2405
		/// </summary>
		public const string _typeName = "t2405";
		/// <summary>
		/// 선물옵션호가잔량비율챠트(t2405)
		/// </summary>
		public const string _typeDesc = "선물옵션호가잔량비율챠트(t2405)";
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
		/// t2405
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 선물옵션호가잔량비율챠트(t2405)
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
		/// 선물옵션호가잔량비율챠트(t2405)
		/// </summary>
		public XQt2405() : base("t2405") { }


		public class XQAllOutBlocks
		{
			public XQt2405OutBlock OutBlock { get; internal set; }
			public XQt2405OutBlock1[] OutBlock1 { get; internal set; }
		}

		public static XQAllOutBlocks Get(string focode = default,char bgubun = default,int nmin = default,string etime = default,char hgubun = default,int cnt = default,string cts_time = default)
		{
			using (XQt2405 instance = new XQt2405())
			{
				instance.SetFieldData(XQt2405InBlock.BlockName, XQt2405InBlock.F.focode, 0, focode); // char 8
				instance.SetFieldData(XQt2405InBlock.BlockName, XQt2405InBlock.F.bgubun, 0, bgubun.ToString()); // char 1
				instance.SetFieldData(XQt2405InBlock.BlockName, XQt2405InBlock.F.nmin, 0, nmin.ToString("d2")); // int 2
				instance.SetFieldData(XQt2405InBlock.BlockName, XQt2405InBlock.F.etime, 0, etime); // char 4
				instance.SetFieldData(XQt2405InBlock.BlockName, XQt2405InBlock.F.hgubun, 0, hgubun.ToString()); // char 1
				instance.SetFieldData(XQt2405InBlock.BlockName, XQt2405InBlock.F.cnt, 0, cnt.ToString("d3")); // int 3
				instance.SetFieldData(XQt2405InBlock.BlockName, XQt2405InBlock.F.cts_time, 0, cts_time); // char 6

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

		public static XQAllOutBlocks ReadFromDB(string tableNamePostfix = null /*, string focode = default,char bgubun = default,int nmin = default,string etime = default,char hgubun = default,int cnt = default,string cts_time = default */)
		{
			using (XQt2405 instance = new XQt2405())
			{

				XQAllOutBlocks results = new XQAllOutBlocks();

				string tableName = (tableNamePostfix == null) ? "XQt2405OutBlock" : $"XQt2405OutBlock_{tableNamePostfix}";
				QueryOption qo = new QueryOption(tableName);
				results.OutBlock = instance.Select<XQt2405OutBlock>(qo);

				tableName = (tableNamePostfix == null) ? "XQt2405OutBlock1" : $"XQt2405OutBlock1_{tableNamePostfix}";
				qo = new QueryOption(tableName);
				results.OutBlock1 = instance.SelectMany<XQt2405OutBlock1>(qo);
				return results;
			}
		}

		public bool SetBlock(XQt2405InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "focode", 0, block.focode); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "bgubun", 0, block.bgubun.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "nmin", 0, block.nmin.ToString("d2")); // int 2
			_xaQuery.SetFieldData(block.GetBlockName(), "etime", 0, block.etime); // char 4
			_xaQuery.SetFieldData(block.GetBlockName(), "hgubun", 0, block.hgubun.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "cnt", 0, block.cnt.ToString("d3")); // int 3
			_xaQuery.SetFieldData(block.GetBlockName(), "cts_time", 0, block.cts_time); // char 6

			return true;
		}

		public XQt2405OutBlock GetBlock()
		{
			XQt2405OutBlock instance = XQt2405OutBlock.FromQuery(this);
			return instance;

		}

		public XQt2405OutBlock1[] GetBlock1s()
		{
			XQt2405OutBlock1[] instance = XQt2405OutBlock1.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt2405OutBlock),
			typeof(XQt2405OutBlock1),

		};

	}

}
