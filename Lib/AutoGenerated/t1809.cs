using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1809InBlock : XingBlock
	{
		/// <summary>
		/// t1809InBlock
		/// </summary>
		public const string _blockName = "t1809InBlock";
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
		/// t1809InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1809InBlock
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
		/// 신호구분
		/// </summary>
		[XAQueryFieldAttribute("신호구분")]
		public char gubun;
		/// <summary>
		/// 종목구분
		/// </summary>
		[XAQueryFieldAttribute("종목구분")]
		public char jmGb;
		/// <summary>
		/// 종목코드
		/// </summary>
		[XAQueryFieldAttribute("종목코드")]
		public string jmcode;
		/// <summary>
		/// NEXTKEY
		/// </summary>
		[XAQueryFieldAttribute("NEXTKEY")]
		public string cts;

		public static class F
		{
			/// <summary>
			/// 신호구분
			/// </summary>
			public const string gubun = "gubun";
			/// <summary>
			/// 종목구분
			/// </summary>
			public const string jmGb = "jmGb";
			/// <summary>
			/// 종목코드
			/// </summary>
			public const string jmcode = "jmcode";
			/// <summary>
			/// NEXTKEY
			/// </summary>
			public const string cts = "cts";
		}

		public static string[] AllFields = new string[]
		{
			F.gubun,
			F.jmGb,
			F.jmcode,
			F.cts,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["gubun"] = new XAQueryFieldInfo("char", gubun, gubun.ToString(), "신호구분", (decimal)1);
			dict["jmGb"] = new XAQueryFieldInfo("char", jmGb, jmGb.ToString(), "종목구분", (decimal)1);
			dict["jmcode"] = new XAQueryFieldInfo("char", jmcode, jmcode, "종목코드", (decimal)6);
			dict["cts"] = new XAQueryFieldInfo("char", cts, cts, "NEXTKEY", (decimal)30);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "gubun":
					this.gubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "jmGb":
					this.jmGb = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "jmcode":
					this.jmcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cts":
					this.cts = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			// gubun char 1
			// jmGb char 1
			if (jmcode?.Length > 6) return false; // char 6
			if (cts?.Length > 30) return false; // char 30

			return true;
		}
	}

	public partial class XQt1809OutBlock : XingBlock
	{
		/// <summary>
		/// t1809OutBlock
		/// </summary>
		public const string _blockName = "t1809OutBlock";
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
		/// t1809OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1809OutBlock
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
		/// NEXTKEY
		/// </summary>
		[XAQueryFieldAttribute("NEXTKEY")]
		public string cts;

		public static class F
		{
			/// <summary>
			/// NEXTKEY
			/// </summary>
			public const string cts = "cts";
		}

		public static string[] AllFields = new string[]
		{
			F.cts,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["cts"] = new XAQueryFieldInfo("char", cts, cts, "NEXTKEY", (decimal)30);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "cts":
					this.cts = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt1809OutBlock FromQuery(XQt1809 query)
		{
			XQt1809OutBlock block = new XQt1809OutBlock();
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
				block.cts = query.GetFieldData(block.GetBlockName(), "cts", 0).TrimEnd('?'); // char 30

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (cts?.Length > 30) return false; // char 30

			return true;
		}
	}

	public partial class XQt1809OutBlock1 : XingBlock
	{
		/// <summary>
		/// t1809OutBlock1
		/// </summary>
		public const string _blockName = "t1809OutBlock1";
		/// <summary>
		/// 기본출력1
		/// </summary>
		public const string _blockDesc = "기본출력1";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// true
		/// </summary>
		public const bool _hasOccurs = true;
		/// <summary>
		/// t1809OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1809OutBlock1
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// 기본출력1
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
		[XAQueryFieldAttribute("일자")]
		public string date;
		/// <summary>
		/// 시간
		/// </summary>
		[XAQueryFieldAttribute("시간")]
		public string time;
		/// <summary>
		/// 신호ID
		/// </summary>
		[XAQueryFieldAttribute("신호ID")]
		public string signal_id;
		/// <summary>
		/// 신호명
		/// </summary>
		[XAQueryFieldAttribute("신호명")]
		public string signal_desc;
		/// <summary>
		/// 신호강도
		/// </summary>
		[XAQueryFieldAttribute("신호강도")]
		public string point;
		/// <summary>
		/// 뉴스신호키워드
		/// </summary>
		[XAQueryFieldAttribute("뉴스신호키워드")]
		public string keyword;
		/// <summary>
		/// 신호별구분
		/// </summary>
		[XAQueryFieldAttribute("신호별구분")]
		public string seq;
		/// <summary>
		/// 신호구분
		/// </summary>
		[XAQueryFieldAttribute("신호구분")]
		public string gubun;
		/// <summary>
		/// 신호종목
		/// </summary>
		[XAQueryFieldAttribute("신호종목")]
		public string jmcode;
		/// <summary>
		/// 종목가격
		/// </summary>
		[XAQueryFieldAttribute("종목가격")]
		public long price;
		/// <summary>
		/// 종목등락부호
		/// </summary>
		[XAQueryFieldAttribute("종목등락부호")]
		public char sign;
		/// <summary>
		/// 대비등락율
		/// </summary>
		[XAQueryFieldAttribute("대비등락율")]
		public float chgrate;
		/// <summary>
		/// 거래량
		/// </summary>
		[XAQueryFieldAttribute("거래량")]
		public long volume;
		/// <summary>
		/// 신호일시
		/// </summary>
		[XAQueryFieldAttribute("신호일시")]
		public string datetime;

		public static class F
		{
			/// <summary>
			/// 일자
			/// </summary>
			public const string date = "date";
			/// <summary>
			/// 시간
			/// </summary>
			public const string time = "time";
			/// <summary>
			/// 신호ID
			/// </summary>
			public const string signal_id = "signal_id";
			/// <summary>
			/// 신호명
			/// </summary>
			public const string signal_desc = "signal_desc";
			/// <summary>
			/// 신호강도
			/// </summary>
			public const string point = "point";
			/// <summary>
			/// 뉴스신호키워드
			/// </summary>
			public const string keyword = "keyword";
			/// <summary>
			/// 신호별구분
			/// </summary>
			public const string seq = "seq";
			/// <summary>
			/// 신호구분
			/// </summary>
			public const string gubun = "gubun";
			/// <summary>
			/// 신호종목
			/// </summary>
			public const string jmcode = "jmcode";
			/// <summary>
			/// 종목가격
			/// </summary>
			public const string price = "price";
			/// <summary>
			/// 종목등락부호
			/// </summary>
			public const string sign = "sign";
			/// <summary>
			/// 대비등락율
			/// </summary>
			public const string chgrate = "chgrate";
			/// <summary>
			/// 거래량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// 신호일시
			/// </summary>
			public const string datetime = "datetime";
		}

		public static string[] AllFields = new string[]
		{
			F.date,
			F.time,
			F.signal_id,
			F.signal_desc,
			F.point,
			F.keyword,
			F.seq,
			F.gubun,
			F.jmcode,
			F.price,
			F.sign,
			F.chgrate,
			F.volume,
			F.datetime,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["date"] = new XAQueryFieldInfo("char", date, date, "일자", (decimal)8);
			dict["time"] = new XAQueryFieldInfo("char", time, time, "시간", (decimal)6);
			dict["signal_id"] = new XAQueryFieldInfo("char", signal_id, signal_id, "신호ID", (decimal)4);
			dict["signal_desc"] = new XAQueryFieldInfo("char", signal_desc, signal_desc, "신호명", (decimal)300);
			dict["point"] = new XAQueryFieldInfo("char", point, point, "신호강도", (decimal)3);
			dict["keyword"] = new XAQueryFieldInfo("char", keyword, keyword, "뉴스신호키워드", (decimal)40);
			dict["seq"] = new XAQueryFieldInfo("char", seq, seq, "신호별구분", (decimal)24);
			dict["gubun"] = new XAQueryFieldInfo("char", gubun, gubun, "신호구분", (decimal)2);
			dict["jmcode"] = new XAQueryFieldInfo("char", jmcode, jmcode, "신호종목", (decimal)6);
			dict["price"] = new XAQueryFieldInfo("long", price, price.ToString("d7"), "종목가격", (decimal)7);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "종목등락부호", (decimal)1);
			dict["chgrate"] = new XAQueryFieldInfo("float", chgrate, chgrate.ToString("000000.00"), "대비등락율", (decimal)6.2);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d9"), "거래량", (decimal)9);
			dict["datetime"] = new XAQueryFieldInfo("char", datetime, datetime, "신호일시", (decimal)16);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "date":
					this.date = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "time":
					this.time = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "signal_id":
					this.signal_id = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "signal_desc":
					this.signal_desc = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "point":
					this.point = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "keyword":
					this.keyword = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "seq":
					this.seq = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "gubun":
					this.gubun = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "jmcode":
					this.jmcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "price":
					this.price = fieldInfo.FieldValue.ParseLong("price");
				break;

				case "sign":
					this.sign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "chgrate":
					this.chgrate = fieldInfo.FieldValue.ParseFloat("chgrate");
				break;

				case "volume":
					this.volume = fieldInfo.FieldValue.ParseLong("volume");
				break;

				case "datetime":
					this.datetime = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt1809OutBlock1[] ListFromQuery(XQt1809 query)
		{
			int count = query.GetBlockCount(XQt1809OutBlock1.BlockName);
			List<XQt1809OutBlock1> list = new List<XQt1809OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1809OutBlock1 block = new XQt1809OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.date = query.GetFieldData(block.GetBlockName(), "date", i).TrimEnd('?'); // char 8
					block.time = query.GetFieldData(block.GetBlockName(), "time", i).TrimEnd('?'); // char 6
					block.signal_id = query.GetFieldData(block.GetBlockName(), "signal_id", i).TrimEnd('?'); // char 4
					block.signal_desc = query.GetFieldData(block.GetBlockName(), "signal_desc", i).TrimEnd('?'); // char 300
					block.point = query.GetFieldData(block.GetBlockName(), "point", i).TrimEnd('?'); // char 3
					block.keyword = query.GetFieldData(block.GetBlockName(), "keyword", i).TrimEnd('?'); // char 40
					block.seq = query.GetFieldData(block.GetBlockName(), "seq", i).TrimEnd('?'); // char 24
					block.gubun = query.GetFieldData(block.GetBlockName(), "gubun", i).TrimEnd('?'); // char 2
					block.jmcode = query.GetFieldData(block.GetBlockName(), "jmcode", i).TrimEnd('?'); // char 6
					block.price = query.GetFieldData(block.GetBlockName(), "price", i).ParseLong("price"); // long 7
					block.sign = query.GetFieldData(block.GetBlockName(), "sign", i).FirstOrDefault(); // char 1
					block.chgrate = query.GetFieldData(block.GetBlockName(), "chgrate", i).ParseFloat("chgrate"); // float 6.2
					block.volume = query.GetFieldData(block.GetBlockName(), "volume", i).ParseLong("volume"); // long 9
					block.datetime = query.GetFieldData(block.GetBlockName(), "datetime", i).TrimEnd('?'); // char 16

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
			if (date?.Length > 8) return false; // char 8
			if (time?.Length > 6) return false; // char 6
			if (signal_id?.Length > 4) return false; // char 4
			if (signal_desc?.Length > 300) return false; // char 300
			if (point?.Length > 3) return false; // char 3
			if (keyword?.Length > 40) return false; // char 40
			if (seq?.Length > 24) return false; // char 24
			if (gubun?.Length > 2) return false; // char 2
			if (jmcode?.Length > 6) return false; // char 6
			if (price.ToString().Length > 7) return false; // long 7
			// sign char 1
			// chgrate float 6.2
			if (volume.ToString().Length > 9) return false; // long 9
			if (datetime?.Length > 16) return false; // char 16

			return true;
		}
	}

	/// <summary>
	/// 신호조회(t1809)
	/// </summary>
	public partial class XQt1809 : XingQuery
	{
		/// <summary>
		/// t1809
		/// </summary>
		public const string _typeName = "t1809";
		/// <summary>
		/// 신호조회(t1809)
		/// </summary>
		public const string _typeDesc = "신호조회(t1809)";
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
		/// false
		/// </summary>
		public const bool _attr = false;
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
		/// t1809
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 신호조회(t1809)
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
		/// false
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
		/// 신호조회(t1809)
		/// </summary>
		public XQt1809() : base("t1809") { }


		public class XQAllOutBlocks
		{
			public XQt1809OutBlock OutBlock { get; internal set; }
			public XQt1809OutBlock1[] OutBlock1 { get; internal set; }
		}

		public static XQAllOutBlocks Get(char gubun = default,char jmGb = default,string jmcode = default,string cts = default)
		{
			using (XQt1809 instance = new XQt1809())
			{
				instance.SetFieldData(XQt1809InBlock.BlockName, XQt1809InBlock.F.gubun, 0, gubun.ToString()); // char 1
				instance.SetFieldData(XQt1809InBlock.BlockName, XQt1809InBlock.F.jmGb, 0, jmGb.ToString()); // char 1
				instance.SetFieldData(XQt1809InBlock.BlockName, XQt1809InBlock.F.jmcode, 0, jmcode); // char 6
				instance.SetFieldData(XQt1809InBlock.BlockName, XQt1809InBlock.F.cts, 0, cts); // char 30

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

		public bool SetBlock(XQt1809InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "gubun", 0, block.gubun.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "jmGb", 0, block.jmGb.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "jmcode", 0, block.jmcode); // char 6
			_xaQuery.SetFieldData(block.GetBlockName(), "cts", 0, block.cts); // char 30

			return true;
		}

		public XQt1809OutBlock GetBlock()
		{
			XQt1809OutBlock instance = XQt1809OutBlock.FromQuery(this);
			return instance;

		}

		public XQt1809OutBlock1[] GetBlock1s()
		{
			XQt1809OutBlock1[] instance = XQt1809OutBlock1.ListFromQuery(this);
			return instance;

		}


	}

}
