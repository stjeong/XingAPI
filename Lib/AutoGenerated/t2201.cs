using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt2201InBlock : XingBlock
	{
		/// <summary>
		/// t2201InBlock
		/// </summary>
		public const string _blockName = "t2201InBlock";
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
		/// t2201InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t2201InBlock
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
		/// 특이거래량
		/// </summary>
		[XAQueryFieldAttribute("cvolume", "특이거래량", "long", "12")]
		public long cvolume;
		/// <summary>
		/// 시작시간
		/// </summary>
		[XAQueryFieldAttribute("stime", "시작시간", "char", "4")]
		public string stime;
		/// <summary>
		/// 종료시간
		/// </summary>
		[XAQueryFieldAttribute("etime", "종료시간", "char", "4")]
		public string etime;
		/// <summary>
		/// 시간CTS
		/// </summary>
		[XAQueryFieldAttribute("cts_time", "시간CTS", "char", "10")]
		public string cts_time;

		public static class F
		{
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string focode = "focode";
			/// <summary>
			/// 특이거래량
			/// </summary>
			public const string cvolume = "cvolume";
			/// <summary>
			/// 시작시간
			/// </summary>
			public const string stime = "stime";
			/// <summary>
			/// 종료시간
			/// </summary>
			public const string etime = "etime";
			/// <summary>
			/// 시간CTS
			/// </summary>
			public const string cts_time = "cts_time";
		}

		public static string[] AllFields = new string[]
		{
			F.focode,
			F.cvolume,
			F.stime,
			F.etime,
			F.cts_time,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["focode"] = new XAQueryFieldInfo("char", focode, focode, "단축코드", (decimal)8);
			dict["cvolume"] = new XAQueryFieldInfo("long", cvolume, cvolume.ToString("d12"), "특이거래량", (decimal)12);
			dict["stime"] = new XAQueryFieldInfo("char", stime, stime, "시작시간", (decimal)4);
			dict["etime"] = new XAQueryFieldInfo("char", etime, etime, "종료시간", (decimal)4);
			dict["cts_time"] = new XAQueryFieldInfo("char", cts_time, cts_time, "시간CTS", (decimal)10);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "focode":
					this.focode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cvolume":
					this.cvolume = fieldInfo.FieldValue.ParseLong("cvolume");
				break;

				case "stime":
					this.stime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "etime":
					this.etime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cts_time":
					this.cts_time = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (focode?.Length > 8) return false; // char 8
			if (cvolume.ToString().Length > 12) return false; // long 12
			if (stime?.Length > 4) return false; // char 4
			if (etime?.Length > 4) return false; // char 4
			if (cts_time?.Length > 10) return false; // char 10

			return true;
		}
	}

	public partial class XQt2201OutBlock : XingBlock
	{
		/// <summary>
		/// t2201OutBlock
		/// </summary>
		public const string _blockName = "t2201OutBlock";
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
		/// t2201OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t2201OutBlock
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
		/// 시간CTS
		/// </summary>
		[XAQueryFieldAttribute("cts_time", "시간CTS", "char", "10")]
		public string cts_time;

		public static class F
		{
			/// <summary>
			/// 시간CTS
			/// </summary>
			public const string cts_time = "cts_time";
		}

		public static string[] AllFields = new string[]
		{
			F.cts_time,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["cts_time"] = new XAQueryFieldInfo("char", cts_time, cts_time, "시간CTS", (decimal)10);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "cts_time":
					this.cts_time = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt2201OutBlock FromQuery(XQt2201 query)
		{
			XQt2201OutBlock block = new XQt2201OutBlock();
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
				block.cts_time = query.GetFieldData(block.GetBlockName(), "cts_time", 0).TrimEnd('?'); // char 10

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (cts_time?.Length > 10) return false; // char 10

			return true;
		}
	}

	public partial class XQt2201OutBlock1 : XingBlock
	{
		/// <summary>
		/// t2201OutBlock1
		/// </summary>
		public const string _blockName = "t2201OutBlock1";
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
		/// t2201OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t2201OutBlock1
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
		[XAQueryFieldAttribute("chetime", "시간", "char", "10")]
		public string chetime;
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
		/// 체결수량
		/// </summary>
		[XAQueryFieldAttribute("cvolume", "체결수량", "long", "8")]
		public long cvolume;
		/// <summary>
		/// 체결강도
		/// </summary>
		[XAQueryFieldAttribute("chdegree", "체결강도", "float", "8.2")]
		public float chdegree;
		/// <summary>
		/// 매도호가
		/// </summary>
		[XAQueryFieldAttribute("offerho", "매도호가", "float", "6.2")]
		public float offerho;
		/// <summary>
		/// 매수호가
		/// </summary>
		[XAQueryFieldAttribute("bidho", "매수호가", "float", "6.2")]
		public float bidho;
		/// <summary>
		/// 거래량
		/// </summary>
		[XAQueryFieldAttribute("volume", "거래량", "double", "12.0")]
		public double volume;
		/// <summary>
		/// 미결수량
		/// </summary>
		[XAQueryFieldAttribute("openyak", "미결수량", "long", "8")]
		public long openyak;
		/// <summary>
		/// 미결전일증감
		/// </summary>
		[XAQueryFieldAttribute("jnilopenupdn", "미결전일증감", "long", "8")]
		public long jnilopenupdn;
		/// <summary>
		/// 이론BASIS
		/// </summary>
		[XAQueryFieldAttribute("ibasis", "이론BASIS", "float", "6.2")]
		public float ibasis;
		/// <summary>
		/// 시장BASIS
		/// </summary>
		[XAQueryFieldAttribute("sbasis", "시장BASIS", "float", "6.2")]
		public float sbasis;
		/// <summary>
		/// 괴리율
		/// </summary>
		[XAQueryFieldAttribute("kasis", "괴리율", "float", "6.2")]
		public float kasis;
		/// <summary>
		/// 거래대금
		/// </summary>
		[XAQueryFieldAttribute("value", "거래대금", "double", "12.0")]
		public double value;
		/// <summary>
		/// 미결직전증감
		/// </summary>
		[XAQueryFieldAttribute("j_openupdn", "미결직전증감", "long", "8")]
		public long j_openupdn;
		/// <summary>
		/// 누적매수체결량
		/// </summary>
		[XAQueryFieldAttribute("n_msvolume", "누적매수체결량", "double", "12.0")]
		public double n_msvolume;
		/// <summary>
		/// 누적매도체결량
		/// </summary>
		[XAQueryFieldAttribute("n_mdvolume", "누적매도체결량", "double", "12.0")]
		public double n_mdvolume;
		/// <summary>
		/// 누적순매수체결량
		/// </summary>
		[XAQueryFieldAttribute("s_msvolume", "누적순매수체결량", "double", "12.0")]
		public double s_msvolume;
		/// <summary>
		/// 누적매수체결건수
		/// </summary>
		[XAQueryFieldAttribute("n_mschecnt", "누적매수체결건수", "long", "8")]
		public long n_mschecnt;
		/// <summary>
		/// 누적매도체결건수
		/// </summary>
		[XAQueryFieldAttribute("n_mdchecnt", "누적매도체결건수", "long", "8")]
		public long n_mdchecnt;
		/// <summary>
		/// 누적순매수체결건수
		/// </summary>
		[XAQueryFieldAttribute("s_mschecnt", "누적순매수체결건수", "long", "8")]
		public long s_mschecnt;

		public static class F
		{
			/// <summary>
			/// 시간
			/// </summary>
			public const string chetime = "chetime";
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
			/// 체결수량
			/// </summary>
			public const string cvolume = "cvolume";
			/// <summary>
			/// 체결강도
			/// </summary>
			public const string chdegree = "chdegree";
			/// <summary>
			/// 매도호가
			/// </summary>
			public const string offerho = "offerho";
			/// <summary>
			/// 매수호가
			/// </summary>
			public const string bidho = "bidho";
			/// <summary>
			/// 거래량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// 미결수량
			/// </summary>
			public const string openyak = "openyak";
			/// <summary>
			/// 미결전일증감
			/// </summary>
			public const string jnilopenupdn = "jnilopenupdn";
			/// <summary>
			/// 이론BASIS
			/// </summary>
			public const string ibasis = "ibasis";
			/// <summary>
			/// 시장BASIS
			/// </summary>
			public const string sbasis = "sbasis";
			/// <summary>
			/// 괴리율
			/// </summary>
			public const string kasis = "kasis";
			/// <summary>
			/// 거래대금
			/// </summary>
			public const string value = "value";
			/// <summary>
			/// 미결직전증감
			/// </summary>
			public const string j_openupdn = "j_openupdn";
			/// <summary>
			/// 누적매수체결량
			/// </summary>
			public const string n_msvolume = "n_msvolume";
			/// <summary>
			/// 누적매도체결량
			/// </summary>
			public const string n_mdvolume = "n_mdvolume";
			/// <summary>
			/// 누적순매수체결량
			/// </summary>
			public const string s_msvolume = "s_msvolume";
			/// <summary>
			/// 누적매수체결건수
			/// </summary>
			public const string n_mschecnt = "n_mschecnt";
			/// <summary>
			/// 누적매도체결건수
			/// </summary>
			public const string n_mdchecnt = "n_mdchecnt";
			/// <summary>
			/// 누적순매수체결건수
			/// </summary>
			public const string s_mschecnt = "s_mschecnt";
		}

		public static string[] AllFields = new string[]
		{
			F.chetime,
			F.price,
			F.sign,
			F.change,
			F.cvolume,
			F.chdegree,
			F.offerho,
			F.bidho,
			F.volume,
			F.openyak,
			F.jnilopenupdn,
			F.ibasis,
			F.sbasis,
			F.kasis,
			F.value,
			F.j_openupdn,
			F.n_msvolume,
			F.n_mdvolume,
			F.s_msvolume,
			F.n_mschecnt,
			F.n_mdchecnt,
			F.s_mschecnt,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["chetime"] = new XAQueryFieldInfo("char", chetime, chetime, "시간", (decimal)10);
			dict["price"] = new XAQueryFieldInfo("float", price, price.ToString("000000.00"), "현재가", (decimal)6.2);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("float", change, change.ToString("000000.00"), "전일대비", (decimal)6.2);
			dict["cvolume"] = new XAQueryFieldInfo("long", cvolume, cvolume.ToString("d8"), "체결수량", (decimal)8);
			dict["chdegree"] = new XAQueryFieldInfo("float", chdegree, chdegree.ToString("00000000.00"), "체결강도", (decimal)8.2);
			dict["offerho"] = new XAQueryFieldInfo("float", offerho, offerho.ToString("000000.00"), "매도호가", (decimal)6.2);
			dict["bidho"] = new XAQueryFieldInfo("float", bidho, bidho.ToString("000000.00"), "매수호가", (decimal)6.2);
			dict["volume"] = new XAQueryFieldInfo("double", volume, volume.ToString("000000000000."), "거래량", (decimal)12.0);
			dict["openyak"] = new XAQueryFieldInfo("long", openyak, openyak.ToString("d8"), "미결수량", (decimal)8);
			dict["jnilopenupdn"] = new XAQueryFieldInfo("long", jnilopenupdn, jnilopenupdn.ToString("d8"), "미결전일증감", (decimal)8);
			dict["ibasis"] = new XAQueryFieldInfo("float", ibasis, ibasis.ToString("000000.00"), "이론BASIS", (decimal)6.2);
			dict["sbasis"] = new XAQueryFieldInfo("float", sbasis, sbasis.ToString("000000.00"), "시장BASIS", (decimal)6.2);
			dict["kasis"] = new XAQueryFieldInfo("float", kasis, kasis.ToString("000000.00"), "괴리율", (decimal)6.2);
			dict["value"] = new XAQueryFieldInfo("double", value, value.ToString("000000000000."), "거래대금", (decimal)12.0);
			dict["j_openupdn"] = new XAQueryFieldInfo("long", j_openupdn, j_openupdn.ToString("d8"), "미결직전증감", (decimal)8);
			dict["n_msvolume"] = new XAQueryFieldInfo("double", n_msvolume, n_msvolume.ToString("000000000000."), "누적매수체결량", (decimal)12.0);
			dict["n_mdvolume"] = new XAQueryFieldInfo("double", n_mdvolume, n_mdvolume.ToString("000000000000."), "누적매도체결량", (decimal)12.0);
			dict["s_msvolume"] = new XAQueryFieldInfo("double", s_msvolume, s_msvolume.ToString("000000000000."), "누적순매수체결량", (decimal)12.0);
			dict["n_mschecnt"] = new XAQueryFieldInfo("long", n_mschecnt, n_mschecnt.ToString("d8"), "누적매수체결건수", (decimal)8);
			dict["n_mdchecnt"] = new XAQueryFieldInfo("long", n_mdchecnt, n_mdchecnt.ToString("d8"), "누적매도체결건수", (decimal)8);
			dict["s_mschecnt"] = new XAQueryFieldInfo("long", s_mschecnt, s_mschecnt.ToString("d8"), "누적순매수체결건수", (decimal)8);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "chetime":
					this.chetime = fieldInfo.FieldValue.TrimEnd('?');
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

				case "cvolume":
					this.cvolume = fieldInfo.FieldValue.ParseLong("cvolume");
				break;

				case "chdegree":
					this.chdegree = fieldInfo.FieldValue.ParseFloat("chdegree");
				break;

				case "offerho":
					this.offerho = fieldInfo.FieldValue.ParseFloat("offerho");
				break;

				case "bidho":
					this.bidho = fieldInfo.FieldValue.ParseFloat("bidho");
				break;

				case "volume":
					this.volume = fieldInfo.FieldValue.ParseDouble("volume");
				break;

				case "openyak":
					this.openyak = fieldInfo.FieldValue.ParseLong("openyak");
				break;

				case "jnilopenupdn":
					this.jnilopenupdn = fieldInfo.FieldValue.ParseLong("jnilopenupdn");
				break;

				case "ibasis":
					this.ibasis = fieldInfo.FieldValue.ParseFloat("ibasis");
				break;

				case "sbasis":
					this.sbasis = fieldInfo.FieldValue.ParseFloat("sbasis");
				break;

				case "kasis":
					this.kasis = fieldInfo.FieldValue.ParseFloat("kasis");
				break;

				case "value":
					this.value = fieldInfo.FieldValue.ParseDouble("value");
				break;

				case "j_openupdn":
					this.j_openupdn = fieldInfo.FieldValue.ParseLong("j_openupdn");
				break;

				case "n_msvolume":
					this.n_msvolume = fieldInfo.FieldValue.ParseDouble("n_msvolume");
				break;

				case "n_mdvolume":
					this.n_mdvolume = fieldInfo.FieldValue.ParseDouble("n_mdvolume");
				break;

				case "s_msvolume":
					this.s_msvolume = fieldInfo.FieldValue.ParseDouble("s_msvolume");
				break;

				case "n_mschecnt":
					this.n_mschecnt = fieldInfo.FieldValue.ParseLong("n_mschecnt");
				break;

				case "n_mdchecnt":
					this.n_mdchecnt = fieldInfo.FieldValue.ParseLong("n_mdchecnt");
				break;

				case "s_mschecnt":
					this.s_mschecnt = fieldInfo.FieldValue.ParseLong("s_mschecnt");
				break;


			}
		}

		public static XQt2201OutBlock1[] ListFromQuery(XQt2201 query)
		{
			int count = query.GetBlockCount(XQt2201OutBlock1.BlockName);
			List<XQt2201OutBlock1> list = new List<XQt2201OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt2201OutBlock1 block = new XQt2201OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.chetime = query.GetFieldData(block.GetBlockName(), "chetime", i).TrimEnd('?'); // char 10
					block.price = query.GetFieldData(block.GetBlockName(), "price", i).ParseFloat("price"); // float 6.2
					block.sign = query.GetFieldData(block.GetBlockName(), "sign", i).FirstOrDefault(); // char 1
					block.change = query.GetFieldData(block.GetBlockName(), "change", i).ParseFloat("change"); // float 6.2
					block.cvolume = query.GetFieldData(block.GetBlockName(), "cvolume", i).ParseLong("cvolume"); // long 8
					block.chdegree = query.GetFieldData(block.GetBlockName(), "chdegree", i).ParseFloat("chdegree"); // float 8.2
					block.offerho = query.GetFieldData(block.GetBlockName(), "offerho", i).ParseFloat("offerho"); // float 6.2
					block.bidho = query.GetFieldData(block.GetBlockName(), "bidho", i).ParseFloat("bidho"); // float 6.2
					block.volume = query.GetFieldData(block.GetBlockName(), "volume", i).ParseDouble("volume"); // double 12.0
					block.openyak = query.GetFieldData(block.GetBlockName(), "openyak", i).ParseLong("openyak"); // long 8
					block.jnilopenupdn = query.GetFieldData(block.GetBlockName(), "jnilopenupdn", i).ParseLong("jnilopenupdn"); // long 8
					block.ibasis = query.GetFieldData(block.GetBlockName(), "ibasis", i).ParseFloat("ibasis"); // float 6.2
					block.sbasis = query.GetFieldData(block.GetBlockName(), "sbasis", i).ParseFloat("sbasis"); // float 6.2
					block.kasis = query.GetFieldData(block.GetBlockName(), "kasis", i).ParseFloat("kasis"); // float 6.2
					block.value = query.GetFieldData(block.GetBlockName(), "value", i).ParseDouble("value"); // double 12.0
					block.j_openupdn = query.GetFieldData(block.GetBlockName(), "j_openupdn", i).ParseLong("j_openupdn"); // long 8
					block.n_msvolume = query.GetFieldData(block.GetBlockName(), "n_msvolume", i).ParseDouble("n_msvolume"); // double 12.0
					block.n_mdvolume = query.GetFieldData(block.GetBlockName(), "n_mdvolume", i).ParseDouble("n_mdvolume"); // double 12.0
					block.s_msvolume = query.GetFieldData(block.GetBlockName(), "s_msvolume", i).ParseDouble("s_msvolume"); // double 12.0
					block.n_mschecnt = query.GetFieldData(block.GetBlockName(), "n_mschecnt", i).ParseLong("n_mschecnt"); // long 8
					block.n_mdchecnt = query.GetFieldData(block.GetBlockName(), "n_mdchecnt", i).ParseLong("n_mdchecnt"); // long 8
					block.s_mschecnt = query.GetFieldData(block.GetBlockName(), "s_mschecnt", i).ParseLong("s_mschecnt"); // long 8

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
			if (chetime?.Length > 10) return false; // char 10
			// price float 6.2
			// sign char 1
			// change float 6.2
			if (cvolume.ToString().Length > 8) return false; // long 8
			// chdegree float 8.2
			// offerho float 6.2
			// bidho float 6.2
			// volume double 12.0
			if (openyak.ToString().Length > 8) return false; // long 8
			if (jnilopenupdn.ToString().Length > 8) return false; // long 8
			// ibasis float 6.2
			// sbasis float 6.2
			// kasis float 6.2
			// value double 12.0
			if (j_openupdn.ToString().Length > 8) return false; // long 8
			// n_msvolume double 12.0
			// n_mdvolume double 12.0
			// s_msvolume double 12.0
			if (n_mschecnt.ToString().Length > 8) return false; // long 8
			if (n_mdchecnt.ToString().Length > 8) return false; // long 8
			if (s_mschecnt.ToString().Length > 8) return false; // long 8

			return true;
		}
	}

	/// <summary>
	/// 선물옵션시간대별체결조회(t2201)
	/// </summary>
	public partial class XQt2201 : XingQuery
	{
		/// <summary>
		/// t2201
		/// </summary>
		public const string _typeName = "t2201";
		/// <summary>
		/// 선물옵션시간대별체결조회(t2201)
		/// </summary>
		public const string _typeDesc = "선물옵션시간대별체결조회(t2201)";
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
		/// t2201
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 선물옵션시간대별체결조회(t2201)
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
		/// 선물옵션시간대별체결조회(t2201)
		/// </summary>
		public XQt2201() : base("t2201") { }


		public class XQAllOutBlocks
		{
			public XQt2201OutBlock OutBlock { get; internal set; }
			public XQt2201OutBlock1[] OutBlock1 { get; internal set; }
		}

		public static XQAllOutBlocks Get(string focode = default,long cvolume = default,string stime = default,string etime = default,string cts_time = default)
		{
			using (XQt2201 instance = new XQt2201())
			{
				instance.SetFieldData(XQt2201InBlock.BlockName, XQt2201InBlock.F.focode, 0, focode); // char 8
				instance.SetFieldData(XQt2201InBlock.BlockName, XQt2201InBlock.F.cvolume, 0, cvolume.ToString("d12")); // long 12
				instance.SetFieldData(XQt2201InBlock.BlockName, XQt2201InBlock.F.stime, 0, stime); // char 4
				instance.SetFieldData(XQt2201InBlock.BlockName, XQt2201InBlock.F.etime, 0, etime); // char 4
				instance.SetFieldData(XQt2201InBlock.BlockName, XQt2201InBlock.F.cts_time, 0, cts_time); // char 10

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

		public bool SetBlock(XQt2201InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "focode", 0, block.focode); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "cvolume", 0, block.cvolume.ToString("d12")); // long 12
			_xaQuery.SetFieldData(block.GetBlockName(), "stime", 0, block.stime); // char 4
			_xaQuery.SetFieldData(block.GetBlockName(), "etime", 0, block.etime); // char 4
			_xaQuery.SetFieldData(block.GetBlockName(), "cts_time", 0, block.cts_time); // char 10

			return true;
		}

		public XQt2201OutBlock GetBlock()
		{
			XQt2201OutBlock instance = XQt2201OutBlock.FromQuery(this);
			return instance;

		}

		public XQt2201OutBlock1[] GetBlock1s()
		{
			XQt2201OutBlock1[] instance = XQt2201OutBlock1.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt2201OutBlock),
			typeof(XQt2201OutBlock1),

		};

	}

}
