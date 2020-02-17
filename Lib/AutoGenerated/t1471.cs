using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1471InBlock : XingBlock
	{
		/// <summary>
		/// t1471InBlock
		/// </summary>
		public const string _blockName = "t1471InBlock";
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
		/// t1471InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1471InBlock
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
		[XAQueryFieldAttribute("shcode", "종목코드", "char", "6")]
		public string shcode;
		/// <summary>
		/// 분구분
		/// </summary>
		[XAQueryFieldAttribute("gubun", "분구분", "char", "2")]
		public string gubun;
		/// <summary>
		/// 시간
		/// </summary>
		[XAQueryFieldAttribute("time", "시간", "char", "6")]
		public string time;
		/// <summary>
		/// 자료개수
		/// </summary>
		[XAQueryFieldAttribute("cnt", "자료개수", "char", "3")]
		public string cnt;

		public static class F
		{
			/// <summary>
			/// 종목코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 분구분
			/// </summary>
			public const string gubun = "gubun";
			/// <summary>
			/// 시간
			/// </summary>
			public const string time = "time";
			/// <summary>
			/// 자료개수
			/// </summary>
			public const string cnt = "cnt";
		}

		public static string[] AllFields = new string[]
		{
			F.shcode,
			F.gubun,
			F.time,
			F.cnt,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "종목코드", (decimal)6);
			dict["gubun"] = new XAQueryFieldInfo("char", gubun, gubun, "분구분", (decimal)2);
			dict["time"] = new XAQueryFieldInfo("char", time, time, "시간", (decimal)6);
			dict["cnt"] = new XAQueryFieldInfo("char", cnt, cnt, "자료개수", (decimal)3);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "gubun":
					this.gubun = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "time":
					this.time = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cnt":
					this.cnt = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (shcode?.Length > 6) return false; // char 6
			if (gubun?.Length > 2) return false; // char 2
			if (time?.Length > 6) return false; // char 6
			if (cnt?.Length > 3) return false; // char 3

			return true;
		}
	}

	public partial class XQt1471OutBlock : XingBlock
	{
		/// <summary>
		/// t1471OutBlock
		/// </summary>
		public const string _blockName = "t1471OutBlock";
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
		/// t1471OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1471OutBlock
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
		[XAQueryFieldAttribute("time", "시간CTS", "char", "6")]
		public string time;
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
		[XAQueryFieldAttribute("volume", "누적거래량", "long", "12")]
		public long volume;

		public static class F
		{
			/// <summary>
			/// 시간CTS
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
			/// 등락율
			/// </summary>
			public const string diff = "diff";
			/// <summary>
			/// 누적거래량
			/// </summary>
			public const string volume = "volume";
		}

		public static string[] AllFields = new string[]
		{
			F.time,
			F.price,
			F.sign,
			F.change,
			F.diff,
			F.volume,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["time"] = new XAQueryFieldInfo("char", time, time, "시간CTS", (decimal)6);
			dict["price"] = new XAQueryFieldInfo("long", price, price.ToString("d8"), "현재가", (decimal)8);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("long", change, change.ToString("d8"), "전일대비", (decimal)8);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "누적거래량", (decimal)12);

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


			}
		}

		public static XQt1471OutBlock FromQuery(XQt1471 query)
		{
			XQt1471OutBlock block = new XQt1471OutBlock();
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
				block.time = query.GetFieldData(block.GetBlockName(), "time", 0).TrimEnd('?'); // char 6
				block.price = query.GetFieldData(block.GetBlockName(), "price", 0).ParseLong("price"); // long 8
				block.sign = query.GetFieldData(block.GetBlockName(), "sign", 0).FirstOrDefault(); // char 1
				block.change = query.GetFieldData(block.GetBlockName(), "change", 0).ParseLong("change"); // long 8
				block.diff = query.GetFieldData(block.GetBlockName(), "diff", 0).ParseFloat("diff"); // float 6.2
				block.volume = query.GetFieldData(block.GetBlockName(), "volume", 0).ParseLong("volume"); // long 12

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
			// sign char 1
			if (change.ToString().Length > 8) return false; // long 8
			// diff float 6.2
			if (volume.ToString().Length > 12) return false; // long 12

			return true;
		}
	}

	public partial class XQt1471OutBlock1 : XingBlock
	{
		/// <summary>
		/// t1471OutBlock1
		/// </summary>
		public const string _blockName = "t1471OutBlock1";
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
		/// t1471OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1471OutBlock1
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
		/// 체결시간
		/// </summary>
		[XAQueryFieldAttribute("time", "체결시간", "char", "6")]
		public string time;
		/// <summary>
		/// 메도증감
		/// </summary>
		[XAQueryFieldAttribute("preoffercha1", "메도증감", "long", "12")]
		public long preoffercha1;
		/// <summary>
		/// 매도우선잔량
		/// </summary>
		[XAQueryFieldAttribute("offerrem1", "매도우선잔량", "long", "12")]
		public long offerrem1;
		/// <summary>
		/// 매도우선호가
		/// </summary>
		[XAQueryFieldAttribute("offerho1", "매도우선호가", "long", "8")]
		public long offerho1;
		/// <summary>
		/// 매수우선호가
		/// </summary>
		[XAQueryFieldAttribute("bidho1", "매수우선호가", "long", "8")]
		public long bidho1;
		/// <summary>
		/// 매수우선잔량
		/// </summary>
		[XAQueryFieldAttribute("bidrem1", "매수우선잔량", "long", "12")]
		public long bidrem1;
		/// <summary>
		/// 매수증감
		/// </summary>
		[XAQueryFieldAttribute("prebidcha1", "매수증감", "long", "12")]
		public long prebidcha1;
		/// <summary>
		/// 총매도
		/// </summary>
		[XAQueryFieldAttribute("totofferrem", "총매도", "long", "12")]
		public long totofferrem;
		/// <summary>
		/// 총매수
		/// </summary>
		[XAQueryFieldAttribute("totbidrem", "총매수", "long", "12")]
		public long totbidrem;
		/// <summary>
		/// 순매수
		/// </summary>
		[XAQueryFieldAttribute("totsun", "순매수", "long", "12")]
		public long totsun;
		/// <summary>
		/// 매수비율
		/// </summary>
		[XAQueryFieldAttribute("msrate", "매수비율", "float", "6.2")]
		public float msrate;
		/// <summary>
		/// 종가
		/// </summary>
		[XAQueryFieldAttribute("close", "종가", "long", "8")]
		public long close;

		public static class F
		{
			/// <summary>
			/// 체결시간
			/// </summary>
			public const string time = "time";
			/// <summary>
			/// 메도증감
			/// </summary>
			public const string preoffercha1 = "preoffercha1";
			/// <summary>
			/// 매도우선잔량
			/// </summary>
			public const string offerrem1 = "offerrem1";
			/// <summary>
			/// 매도우선호가
			/// </summary>
			public const string offerho1 = "offerho1";
			/// <summary>
			/// 매수우선호가
			/// </summary>
			public const string bidho1 = "bidho1";
			/// <summary>
			/// 매수우선잔량
			/// </summary>
			public const string bidrem1 = "bidrem1";
			/// <summary>
			/// 매수증감
			/// </summary>
			public const string prebidcha1 = "prebidcha1";
			/// <summary>
			/// 총매도
			/// </summary>
			public const string totofferrem = "totofferrem";
			/// <summary>
			/// 총매수
			/// </summary>
			public const string totbidrem = "totbidrem";
			/// <summary>
			/// 순매수
			/// </summary>
			public const string totsun = "totsun";
			/// <summary>
			/// 매수비율
			/// </summary>
			public const string msrate = "msrate";
			/// <summary>
			/// 종가
			/// </summary>
			public const string close = "close";
		}

		public static string[] AllFields = new string[]
		{
			F.time,
			F.preoffercha1,
			F.offerrem1,
			F.offerho1,
			F.bidho1,
			F.bidrem1,
			F.prebidcha1,
			F.totofferrem,
			F.totbidrem,
			F.totsun,
			F.msrate,
			F.close,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["time"] = new XAQueryFieldInfo("char", time, time, "체결시간", (decimal)6);
			dict["preoffercha1"] = new XAQueryFieldInfo("long", preoffercha1, preoffercha1.ToString("d12"), "메도증감", (decimal)12);
			dict["offerrem1"] = new XAQueryFieldInfo("long", offerrem1, offerrem1.ToString("d12"), "매도우선잔량", (decimal)12);
			dict["offerho1"] = new XAQueryFieldInfo("long", offerho1, offerho1.ToString("d8"), "매도우선호가", (decimal)8);
			dict["bidho1"] = new XAQueryFieldInfo("long", bidho1, bidho1.ToString("d8"), "매수우선호가", (decimal)8);
			dict["bidrem1"] = new XAQueryFieldInfo("long", bidrem1, bidrem1.ToString("d12"), "매수우선잔량", (decimal)12);
			dict["prebidcha1"] = new XAQueryFieldInfo("long", prebidcha1, prebidcha1.ToString("d12"), "매수증감", (decimal)12);
			dict["totofferrem"] = new XAQueryFieldInfo("long", totofferrem, totofferrem.ToString("d12"), "총매도", (decimal)12);
			dict["totbidrem"] = new XAQueryFieldInfo("long", totbidrem, totbidrem.ToString("d12"), "총매수", (decimal)12);
			dict["totsun"] = new XAQueryFieldInfo("long", totsun, totsun.ToString("d12"), "순매수", (decimal)12);
			dict["msrate"] = new XAQueryFieldInfo("float", msrate, msrate.ToString("000000.00"), "매수비율", (decimal)6.2);
			dict["close"] = new XAQueryFieldInfo("long", close, close.ToString("d8"), "종가", (decimal)8);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "time":
					this.time = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "preoffercha1":
					this.preoffercha1 = fieldInfo.FieldValue.ParseLong("preoffercha1");
				break;

				case "offerrem1":
					this.offerrem1 = fieldInfo.FieldValue.ParseLong("offerrem1");
				break;

				case "offerho1":
					this.offerho1 = fieldInfo.FieldValue.ParseLong("offerho1");
				break;

				case "bidho1":
					this.bidho1 = fieldInfo.FieldValue.ParseLong("bidho1");
				break;

				case "bidrem1":
					this.bidrem1 = fieldInfo.FieldValue.ParseLong("bidrem1");
				break;

				case "prebidcha1":
					this.prebidcha1 = fieldInfo.FieldValue.ParseLong("prebidcha1");
				break;

				case "totofferrem":
					this.totofferrem = fieldInfo.FieldValue.ParseLong("totofferrem");
				break;

				case "totbidrem":
					this.totbidrem = fieldInfo.FieldValue.ParseLong("totbidrem");
				break;

				case "totsun":
					this.totsun = fieldInfo.FieldValue.ParseLong("totsun");
				break;

				case "msrate":
					this.msrate = fieldInfo.FieldValue.ParseFloat("msrate");
				break;

				case "close":
					this.close = fieldInfo.FieldValue.ParseLong("close");
				break;


			}
		}

		public static XQt1471OutBlock1[] ListFromQuery(XQt1471 query)
		{
			int count = query.GetBlockCount(XQt1471OutBlock1.BlockName);
			List<XQt1471OutBlock1> list = new List<XQt1471OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1471OutBlock1 block = new XQt1471OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.time = query.GetFieldData(block.GetBlockName(), "time", i).TrimEnd('?'); // char 6
					block.preoffercha1 = query.GetFieldData(block.GetBlockName(), "preoffercha1", i).ParseLong("preoffercha1"); // long 12
					block.offerrem1 = query.GetFieldData(block.GetBlockName(), "offerrem1", i).ParseLong("offerrem1"); // long 12
					block.offerho1 = query.GetFieldData(block.GetBlockName(), "offerho1", i).ParseLong("offerho1"); // long 8
					block.bidho1 = query.GetFieldData(block.GetBlockName(), "bidho1", i).ParseLong("bidho1"); // long 8
					block.bidrem1 = query.GetFieldData(block.GetBlockName(), "bidrem1", i).ParseLong("bidrem1"); // long 12
					block.prebidcha1 = query.GetFieldData(block.GetBlockName(), "prebidcha1", i).ParseLong("prebidcha1"); // long 12
					block.totofferrem = query.GetFieldData(block.GetBlockName(), "totofferrem", i).ParseLong("totofferrem"); // long 12
					block.totbidrem = query.GetFieldData(block.GetBlockName(), "totbidrem", i).ParseLong("totbidrem"); // long 12
					block.totsun = query.GetFieldData(block.GetBlockName(), "totsun", i).ParseLong("totsun"); // long 12
					block.msrate = query.GetFieldData(block.GetBlockName(), "msrate", i).ParseFloat("msrate"); // float 6.2
					block.close = query.GetFieldData(block.GetBlockName(), "close", i).ParseLong("close"); // long 8

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
			if (preoffercha1.ToString().Length > 12) return false; // long 12
			if (offerrem1.ToString().Length > 12) return false; // long 12
			if (offerho1.ToString().Length > 8) return false; // long 8
			if (bidho1.ToString().Length > 8) return false; // long 8
			if (bidrem1.ToString().Length > 12) return false; // long 12
			if (prebidcha1.ToString().Length > 12) return false; // long 12
			if (totofferrem.ToString().Length > 12) return false; // long 12
			if (totbidrem.ToString().Length > 12) return false; // long 12
			if (totsun.ToString().Length > 12) return false; // long 12
			// msrate float 6.2
			if (close.ToString().Length > 8) return false; // long 8

			return true;
		}
	}

	/// <summary>
	/// 시간대별호가잔량추이(t1471)
	/// </summary>
	public partial class XQt1471 : XingQuery
	{
		/// <summary>
		/// t1471
		/// </summary>
		public const string _typeName = "t1471";
		/// <summary>
		/// 시간대별호가잔량추이(t1471)
		/// </summary>
		public const string _typeDesc = "시간대별호가잔량추이(t1471)";
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
		/// t1471
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 시간대별호가잔량추이(t1471)
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
		/// 시간대별호가잔량추이(t1471)
		/// </summary>
		public XQt1471() : base("t1471") { }


		public class XQAllOutBlocks
		{
			public XQt1471OutBlock OutBlock { get; internal set; }
			public XQt1471OutBlock1[] OutBlock1 { get; internal set; }
		}

		public static XQAllOutBlocks Get(string shcode = default,string gubun = default,string time = default,string cnt = default)
		{
			using (XQt1471 instance = new XQt1471())
			{
				instance.SetFieldData(XQt1471InBlock.BlockName, XQt1471InBlock.F.shcode, 0, shcode); // char 6
				instance.SetFieldData(XQt1471InBlock.BlockName, XQt1471InBlock.F.gubun, 0, gubun); // char 2
				instance.SetFieldData(XQt1471InBlock.BlockName, XQt1471InBlock.F.time, 0, time); // char 6
				instance.SetFieldData(XQt1471InBlock.BlockName, XQt1471InBlock.F.cnt, 0, cnt); // char 3

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

		public static XQAllOutBlocks ReadFromDB(/* string shcode = default,string gubun = default,string time = default,string cnt = default */)
		{
			using (XQt1471 instance = new XQt1471())
			{

				XQAllOutBlocks results = new XQAllOutBlocks();

				QueryOption qo = new QueryOption("XQt1471OutBlock");
				results.OutBlock = instance.Select<XQt1471OutBlock>(qo);

				qo = new QueryOption("XQt1471OutBlock1");
				results.OutBlock1 = instance.SelectMany<XQt1471OutBlock1>(qo);
				return results;
			}
		}

		public bool SetBlock(XQt1471InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "shcode", 0, block.shcode); // char 6
			_xaQuery.SetFieldData(block.GetBlockName(), "gubun", 0, block.gubun); // char 2
			_xaQuery.SetFieldData(block.GetBlockName(), "time", 0, block.time); // char 6
			_xaQuery.SetFieldData(block.GetBlockName(), "cnt", 0, block.cnt); // char 3

			return true;
		}

		public XQt1471OutBlock GetBlock()
		{
			XQt1471OutBlock instance = XQt1471OutBlock.FromQuery(this);
			return instance;

		}

		public XQt1471OutBlock1[] GetBlock1s()
		{
			XQt1471OutBlock1[] instance = XQt1471OutBlock1.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt1471OutBlock),
			typeof(XQt1471OutBlock1),

		};

	}

}
