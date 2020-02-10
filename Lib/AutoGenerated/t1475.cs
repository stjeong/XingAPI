using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1475InBlock : XingBlock
	{
		/// <summary>
		/// t1475InBlock
		/// </summary>
		public const string _blockName = "t1475InBlock";
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
		/// t1475InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1475InBlock
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
		[XAQueryFieldAttribute("종목코드", "6")]
		public string shcode;
		/// <summary>
		/// 상승하락
		/// </summary>
		[XAQueryFieldAttribute("상승하락", "1")]
		public char vptype;
		/// <summary>
		/// 데이터개수
		/// </summary>
		[XAQueryFieldAttribute("데이터개수", "4")]
		public long datacnt;
		/// <summary>
		/// 기준일자
		/// </summary>
		[XAQueryFieldAttribute("기준일자", "8")]
		public long date;
		/// <summary>
		/// 기준시간
		/// </summary>
		[XAQueryFieldAttribute("기준시간", "6")]
		public long time;
		/// <summary>
		/// 랭크카운터
		/// </summary>
		[XAQueryFieldAttribute("랭크카운터", "3")]
		public long rankcnt;
		/// <summary>
		/// 조회구분
		/// </summary>
		[XAQueryFieldAttribute("조회구분", "1")]
		public char gubun;

		public static class F
		{
			/// <summary>
			/// 종목코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 상승하락
			/// </summary>
			public const string vptype = "vptype";
			/// <summary>
			/// 데이터개수
			/// </summary>
			public const string datacnt = "datacnt";
			/// <summary>
			/// 기준일자
			/// </summary>
			public const string date = "date";
			/// <summary>
			/// 기준시간
			/// </summary>
			public const string time = "time";
			/// <summary>
			/// 랭크카운터
			/// </summary>
			public const string rankcnt = "rankcnt";
			/// <summary>
			/// 조회구분
			/// </summary>
			public const string gubun = "gubun";
		}

		public static string[] AllFields = new string[]
		{
			F.shcode,
			F.vptype,
			F.datacnt,
			F.date,
			F.time,
			F.rankcnt,
			F.gubun,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "종목코드", (decimal)6);
			dict["vptype"] = new XAQueryFieldInfo("char", vptype, vptype.ToString(), "상승하락", (decimal)1);
			dict["datacnt"] = new XAQueryFieldInfo("long", datacnt, datacnt.ToString("d4"), "데이터개수", (decimal)4);
			dict["date"] = new XAQueryFieldInfo("long", date, date.ToString("d8"), "기준일자", (decimal)8);
			dict["time"] = new XAQueryFieldInfo("long", time, time.ToString("d6"), "기준시간", (decimal)6);
			dict["rankcnt"] = new XAQueryFieldInfo("long", rankcnt, rankcnt.ToString("d3"), "랭크카운터", (decimal)3);
			dict["gubun"] = new XAQueryFieldInfo("char", gubun, gubun.ToString(), "조회구분", (decimal)1);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "vptype":
					this.vptype = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "datacnt":
					this.datacnt = fieldInfo.FieldValue.ParseLong("datacnt");
				break;

				case "date":
					this.date = fieldInfo.FieldValue.ParseLong("date");
				break;

				case "time":
					this.time = fieldInfo.FieldValue.ParseLong("time");
				break;

				case "rankcnt":
					this.rankcnt = fieldInfo.FieldValue.ParseLong("rankcnt");
				break;

				case "gubun":
					this.gubun = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public bool VerifyData()
		{
			if (shcode?.Length > 6) return false; // char 6
			// vptype char 1
			if (datacnt.ToString().Length > 4) return false; // long 4
			if (date.ToString().Length > 8) return false; // long 8
			if (time.ToString().Length > 6) return false; // long 6
			if (rankcnt.ToString().Length > 3) return false; // long 3
			// gubun char 1

			return true;
		}
	}

	public partial class XQt1475OutBlock : XingBlock
	{
		/// <summary>
		/// t1475OutBlock
		/// </summary>
		public const string _blockName = "t1475OutBlock";
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
		/// t1475OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1475OutBlock
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
		/// 기준일자
		/// </summary>
		[XAQueryFieldAttribute("기준일자", "8")]
		public long date;
		/// <summary>
		/// 기준시간
		/// </summary>
		[XAQueryFieldAttribute("기준시간", "6")]
		public long time;
		/// <summary>
		/// 랭크카운터
		/// </summary>
		[XAQueryFieldAttribute("랭크카운터", "3")]
		public long rankcnt;

		public static class F
		{
			/// <summary>
			/// 기준일자
			/// </summary>
			public const string date = "date";
			/// <summary>
			/// 기준시간
			/// </summary>
			public const string time = "time";
			/// <summary>
			/// 랭크카운터
			/// </summary>
			public const string rankcnt = "rankcnt";
		}

		public static string[] AllFields = new string[]
		{
			F.date,
			F.time,
			F.rankcnt,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["date"] = new XAQueryFieldInfo("long", date, date.ToString("d8"), "기준일자", (decimal)8);
			dict["time"] = new XAQueryFieldInfo("long", time, time.ToString("d6"), "기준시간", (decimal)6);
			dict["rankcnt"] = new XAQueryFieldInfo("long", rankcnt, rankcnt.ToString("d3"), "랭크카운터", (decimal)3);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "date":
					this.date = fieldInfo.FieldValue.ParseLong("date");
				break;

				case "time":
					this.time = fieldInfo.FieldValue.ParseLong("time");
				break;

				case "rankcnt":
					this.rankcnt = fieldInfo.FieldValue.ParseLong("rankcnt");
				break;


			}
		}

		public static XQt1475OutBlock FromQuery(XQt1475 query)
		{
			XQt1475OutBlock block = new XQt1475OutBlock();
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
				block.date = query.GetFieldData(block.GetBlockName(), "date", 0).ParseLong("date"); // long 8
				block.time = query.GetFieldData(block.GetBlockName(), "time", 0).ParseLong("time"); // long 6
				block.rankcnt = query.GetFieldData(block.GetBlockName(), "rankcnt", 0).ParseLong("rankcnt"); // long 3

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (date.ToString().Length > 8) return false; // long 8
			if (time.ToString().Length > 6) return false; // long 6
			if (rankcnt.ToString().Length > 3) return false; // long 3

			return true;
		}
	}

	public partial class XQt1475OutBlock1 : XingBlock
	{
		/// <summary>
		/// t1475OutBlock1
		/// </summary>
		public const string _blockName = "t1475OutBlock1";
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
		/// t1475OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1475OutBlock1
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
		/// 일자
		/// </summary>
		[XAQueryFieldAttribute("일자", "10")]
		public string datetime;
		/// <summary>
		/// 현재가
		/// </summary>
		[XAQueryFieldAttribute("현재가", "8")]
		public long price;
		/// <summary>
		/// 전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("전일대비구분", "1")]
		public char sign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[XAQueryFieldAttribute("전일대비", "8")]
		public long change;
		/// <summary>
		/// 등락율
		/// </summary>
		[XAQueryFieldAttribute("등락율", "6.2")]
		public float diff;
		/// <summary>
		/// 거래량
		/// </summary>
		[XAQueryFieldAttribute("거래량", "12")]
		public long volume;
		/// <summary>
		/// 당일VP
		/// </summary>
		[XAQueryFieldAttribute("당일VP", "8.2")]
		public float todayvp;
		/// <summary>
		/// 5일MAVP
		/// </summary>
		[XAQueryFieldAttribute("5일MAVP", "8.2")]
		public float ma5vp;
		/// <summary>
		/// 20일MAVP
		/// </summary>
		[XAQueryFieldAttribute("20일MAVP", "8.2")]
		public float ma20vp;
		/// <summary>
		/// 60일MAVP
		/// </summary>
		[XAQueryFieldAttribute("60일MAVP", "8.2")]
		public float ma60vp;

		public static class F
		{
			/// <summary>
			/// 일자
			/// </summary>
			public const string datetime = "datetime";
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
			/// 당일VP
			/// </summary>
			public const string todayvp = "todayvp";
			/// <summary>
			/// 5일MAVP
			/// </summary>
			public const string ma5vp = "ma5vp";
			/// <summary>
			/// 20일MAVP
			/// </summary>
			public const string ma20vp = "ma20vp";
			/// <summary>
			/// 60일MAVP
			/// </summary>
			public const string ma60vp = "ma60vp";
		}

		public static string[] AllFields = new string[]
		{
			F.datetime,
			F.price,
			F.sign,
			F.change,
			F.diff,
			F.volume,
			F.todayvp,
			F.ma5vp,
			F.ma20vp,
			F.ma60vp,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["datetime"] = new XAQueryFieldInfo("char", datetime, datetime, "일자", (decimal)10);
			dict["price"] = new XAQueryFieldInfo("long", price, price.ToString("d8"), "현재가", (decimal)8);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("long", change, change.ToString("d8"), "전일대비", (decimal)8);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "거래량", (decimal)12);
			dict["todayvp"] = new XAQueryFieldInfo("float", todayvp, todayvp.ToString("00000000.00"), "당일VP", (decimal)8.2);
			dict["ma5vp"] = new XAQueryFieldInfo("float", ma5vp, ma5vp.ToString("00000000.00"), "5일MAVP", (decimal)8.2);
			dict["ma20vp"] = new XAQueryFieldInfo("float", ma20vp, ma20vp.ToString("00000000.00"), "20일MAVP", (decimal)8.2);
			dict["ma60vp"] = new XAQueryFieldInfo("float", ma60vp, ma60vp.ToString("00000000.00"), "60일MAVP", (decimal)8.2);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "datetime":
					this.datetime = fieldInfo.FieldValue.TrimEnd('?');
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

				case "todayvp":
					this.todayvp = fieldInfo.FieldValue.ParseFloat("todayvp");
				break;

				case "ma5vp":
					this.ma5vp = fieldInfo.FieldValue.ParseFloat("ma5vp");
				break;

				case "ma20vp":
					this.ma20vp = fieldInfo.FieldValue.ParseFloat("ma20vp");
				break;

				case "ma60vp":
					this.ma60vp = fieldInfo.FieldValue.ParseFloat("ma60vp");
				break;


			}
		}

		public static XQt1475OutBlock1[] ListFromQuery(XQt1475 query)
		{
			int count = query.GetBlockCount(XQt1475OutBlock1.BlockName);
			List<XQt1475OutBlock1> list = new List<XQt1475OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1475OutBlock1 block = new XQt1475OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.datetime = query.GetFieldData(block.GetBlockName(), "datetime", i).TrimEnd('?'); // char 10
					block.price = query.GetFieldData(block.GetBlockName(), "price", i).ParseLong("price"); // long 8
					block.sign = query.GetFieldData(block.GetBlockName(), "sign", i).FirstOrDefault(); // char 1
					block.change = query.GetFieldData(block.GetBlockName(), "change", i).ParseLong("change"); // long 8
					block.diff = query.GetFieldData(block.GetBlockName(), "diff", i).ParseFloat("diff"); // float 6.2
					block.volume = query.GetFieldData(block.GetBlockName(), "volume", i).ParseLong("volume"); // long 12
					block.todayvp = query.GetFieldData(block.GetBlockName(), "todayvp", i).ParseFloat("todayvp"); // float 8.2
					block.ma5vp = query.GetFieldData(block.GetBlockName(), "ma5vp", i).ParseFloat("ma5vp"); // float 8.2
					block.ma20vp = query.GetFieldData(block.GetBlockName(), "ma20vp", i).ParseFloat("ma20vp"); // float 8.2
					block.ma60vp = query.GetFieldData(block.GetBlockName(), "ma60vp", i).ParseFloat("ma60vp"); // float 8.2

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
			if (datetime?.Length > 10) return false; // char 10
			if (price.ToString().Length > 8) return false; // long 8
			// sign char 1
			if (change.ToString().Length > 8) return false; // long 8
			// diff float 6.2
			if (volume.ToString().Length > 12) return false; // long 12
			// todayvp float 8.2
			// ma5vp float 8.2
			// ma20vp float 8.2
			// ma60vp float 8.2

			return true;
		}
	}

	/// <summary>
	/// 체결강도추이(t1475)
	/// </summary>
	public partial class XQt1475 : XingQuery
	{
		/// <summary>
		/// t1475
		/// </summary>
		public const string _typeName = "t1475";
		/// <summary>
		/// 체결강도추이(t1475)
		/// </summary>
		public const string _typeDesc = "체결강도추이(t1475)";
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
		/// t1475
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 체결강도추이(t1475)
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
		/// 체결강도추이(t1475)
		/// </summary>
		public XQt1475() : base("t1475") { }


		public class XQAllOutBlocks
		{
			public XQt1475OutBlock OutBlock { get; internal set; }
			public XQt1475OutBlock1[] OutBlock1 { get; internal set; }
		}

		public static XQAllOutBlocks Get(string shcode = default,char vptype = default,long datacnt = default,long date = default,long time = default,long rankcnt = default,char gubun = default)
		{
			using (XQt1475 instance = new XQt1475())
			{
				instance.SetFieldData(XQt1475InBlock.BlockName, XQt1475InBlock.F.shcode, 0, shcode); // char 6
				instance.SetFieldData(XQt1475InBlock.BlockName, XQt1475InBlock.F.vptype, 0, vptype.ToString()); // char 1
				instance.SetFieldData(XQt1475InBlock.BlockName, XQt1475InBlock.F.datacnt, 0, datacnt.ToString("d4")); // long 4
				instance.SetFieldData(XQt1475InBlock.BlockName, XQt1475InBlock.F.date, 0, date.ToString("d8")); // long 8
				instance.SetFieldData(XQt1475InBlock.BlockName, XQt1475InBlock.F.time, 0, time.ToString("d6")); // long 6
				instance.SetFieldData(XQt1475InBlock.BlockName, XQt1475InBlock.F.rankcnt, 0, rankcnt.ToString("d3")); // long 3
				instance.SetFieldData(XQt1475InBlock.BlockName, XQt1475InBlock.F.gubun, 0, gubun.ToString()); // char 1

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

		public bool SetBlock(XQt1475InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "shcode", 0, block.shcode); // char 6
			_xaQuery.SetFieldData(block.GetBlockName(), "vptype", 0, block.vptype.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "datacnt", 0, block.datacnt.ToString("d4")); // long 4
			_xaQuery.SetFieldData(block.GetBlockName(), "date", 0, block.date.ToString("d8")); // long 8
			_xaQuery.SetFieldData(block.GetBlockName(), "time", 0, block.time.ToString("d6")); // long 6
			_xaQuery.SetFieldData(block.GetBlockName(), "rankcnt", 0, block.rankcnt.ToString("d3")); // long 3
			_xaQuery.SetFieldData(block.GetBlockName(), "gubun", 0, block.gubun.ToString()); // char 1

			return true;
		}

		public XQt1475OutBlock GetBlock()
		{
			XQt1475OutBlock instance = XQt1475OutBlock.FromQuery(this);
			return instance;

		}

		public XQt1475OutBlock1[] GetBlock1s()
		{
			XQt1475OutBlock1[] instance = XQt1475OutBlock1.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt1475OutBlock),
			typeof(XQt1475OutBlock1),

		};

	}

}
