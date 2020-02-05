using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt3401InBlock : XingBlock
	{
		/// <summary>
		/// t3401InBlock
		/// </summary>
		public const string _blockName = "t3401InBlock";
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
		/// t3401InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t3401InBlock
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
		/// 구분
		/// </summary>
		[XAQueryFieldAttribute("구분")]
		public char gubun1;
		/// <summary>
		/// 회원사코드
		/// </summary>
		[XAQueryFieldAttribute("회원사코드")]
		public string tradno;
		/// <summary>
		/// IDXDATE
		/// </summary>
		[XAQueryFieldAttribute("IDXDATE")]
		public string cts_date;

		public static class F
		{
			/// <summary>
			/// 종목코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 구분
			/// </summary>
			public const string gubun1 = "gubun1";
			/// <summary>
			/// 회원사코드
			/// </summary>
			public const string tradno = "tradno";
			/// <summary>
			/// IDXDATE
			/// </summary>
			public const string cts_date = "cts_date";
		}

		public static string[] AllFields = new string[]
		{
			F.shcode,
			F.gubun1,
			F.tradno,
			F.cts_date,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "종목코드", (decimal)9);
			dict["gubun1"] = new XAQueryFieldInfo("char", gubun1, gubun1.ToString(), "구분", (decimal)1);
			dict["tradno"] = new XAQueryFieldInfo("char", tradno, tradno, "회원사코드", (decimal)3);
			dict["cts_date"] = new XAQueryFieldInfo("char", cts_date, cts_date, "IDXDATE", (decimal)8);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "gubun1":
					this.gubun1 = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "tradno":
					this.tradno = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cts_date":
					this.cts_date = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (shcode?.Length > 9) return false; // char 9
			// gubun1 char 1
			if (tradno?.Length > 3) return false; // char 3
			if (cts_date?.Length > 8) return false; // char 8

			return true;
		}
	}

	public partial class XQt3401OutBlock : XingBlock
	{
		/// <summary>
		/// t3401OutBlock
		/// </summary>
		public const string _blockName = "t3401OutBlock";
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
		/// t3401OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t3401OutBlock
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
		/// IDXDATE
		/// </summary>
		[XAQueryFieldAttribute("IDXDATE")]
		public string cts_date;
		/// <summary>
		/// 현재가
		/// </summary>
		[XAQueryFieldAttribute("현재가")]
		public long price;
		/// <summary>
		/// 대비속성
		/// </summary>
		[XAQueryFieldAttribute("대비속성")]
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
		/// 거래대금
		/// </summary>
		[XAQueryFieldAttribute("거래대금")]
		public long value;

		public static class F
		{
			/// <summary>
			/// IDXDATE
			/// </summary>
			public const string cts_date = "cts_date";
			/// <summary>
			/// 현재가
			/// </summary>
			public const string price = "price";
			/// <summary>
			/// 대비속성
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
			/// 거래대금
			/// </summary>
			public const string value = "value";
		}

		public static string[] AllFields = new string[]
		{
			F.cts_date,
			F.price,
			F.sign,
			F.change,
			F.diff,
			F.volume,
			F.value,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["cts_date"] = new XAQueryFieldInfo("char", cts_date, cts_date, "IDXDATE", (decimal)8);
			dict["price"] = new XAQueryFieldInfo("long", price, price.ToString("d8"), "현재가", (decimal)8);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "대비속성", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("long", change, change.ToString("d8"), "대비", (decimal)8);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "거래량", (decimal)12);
			dict["value"] = new XAQueryFieldInfo("long", value, value.ToString("d12"), "거래대금", (decimal)12);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "cts_date":
					this.cts_date = fieldInfo.FieldValue.TrimEnd('?');
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

				case "value":
					this.value = fieldInfo.FieldValue.ParseLong("value");
				break;


			}
		}

		public static XQt3401OutBlock FromQuery(XQt3401 query)
		{
			XQt3401OutBlock block = new XQt3401OutBlock();
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
				block.cts_date = query.GetFieldData(block.GetBlockName(), "cts_date", 0).TrimEnd('?'); // char 8
				block.price = query.GetFieldData(block.GetBlockName(), "price", 0).ParseLong("price"); // long 8
				block.sign = query.GetFieldData(block.GetBlockName(), "sign", 0).FirstOrDefault(); // char 1
				block.change = query.GetFieldData(block.GetBlockName(), "change", 0).ParseLong("change"); // long 8
				block.diff = query.GetFieldData(block.GetBlockName(), "diff", 0).ParseFloat("diff"); // float 6.2
				block.volume = query.GetFieldData(block.GetBlockName(), "volume", 0).ParseLong("volume"); // long 12
				block.value = query.GetFieldData(block.GetBlockName(), "value", 0).ParseLong("value"); // long 12

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (cts_date?.Length > 8) return false; // char 8
			if (price.ToString().Length > 8) return false; // long 8
			// sign char 1
			if (change.ToString().Length > 8) return false; // long 8
			// diff float 6.2
			if (volume.ToString().Length > 12) return false; // long 12
			if (value.ToString().Length > 12) return false; // long 12

			return true;
		}
	}

	public partial class XQt3401OutBlock1 : XingBlock
	{
		/// <summary>
		/// t3401OutBlock1
		/// </summary>
		public const string _blockName = "t3401OutBlock1";
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
		/// t3401OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t3401OutBlock1
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
		/// 종목코드
		/// </summary>
		[XAQueryFieldAttribute("종목코드")]
		public string shcode;
		/// <summary>
		/// 회원사코드
		/// </summary>
		[XAQueryFieldAttribute("회원사코드")]
		public string tradno;
		/// <summary>
		/// 의견일자
		/// </summary>
		[XAQueryFieldAttribute("의견일자")]
		public string date;
		/// <summary>
		/// 회원사명
		/// </summary>
		[XAQueryFieldAttribute("회원사명")]
		public string tradname;
		/// <summary>
		/// 투자의견변경후
		/// </summary>
		[XAQueryFieldAttribute("투자의견변경후")]
		public string bopn;
		/// <summary>
		/// 투자의견변경전
		/// </summary>
		[XAQueryFieldAttribute("투자의견변경전")]
		public string nopn;
		/// <summary>
		/// 목표가변경전
		/// </summary>
		[XAQueryFieldAttribute("목표가변경전")]
		public long boga;
		/// <summary>
		/// 목표가변경후
		/// </summary>
		[XAQueryFieldAttribute("목표가변경후")]
		public long noga;
		/// <summary>
		/// 의견일종가
		/// </summary>
		[XAQueryFieldAttribute("의견일종가")]
		public long close;

		public static class F
		{
			/// <summary>
			/// 종목코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 회원사코드
			/// </summary>
			public const string tradno = "tradno";
			/// <summary>
			/// 의견일자
			/// </summary>
			public const string date = "date";
			/// <summary>
			/// 회원사명
			/// </summary>
			public const string tradname = "tradname";
			/// <summary>
			/// 투자의견변경후
			/// </summary>
			public const string bopn = "bopn";
			/// <summary>
			/// 투자의견변경전
			/// </summary>
			public const string nopn = "nopn";
			/// <summary>
			/// 목표가변경전
			/// </summary>
			public const string boga = "boga";
			/// <summary>
			/// 목표가변경후
			/// </summary>
			public const string noga = "noga";
			/// <summary>
			/// 의견일종가
			/// </summary>
			public const string close = "close";
		}

		public static string[] AllFields = new string[]
		{
			F.shcode,
			F.tradno,
			F.date,
			F.tradname,
			F.bopn,
			F.nopn,
			F.boga,
			F.noga,
			F.close,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "종목코드", (decimal)9);
			dict["tradno"] = new XAQueryFieldInfo("char", tradno, tradno, "회원사코드", (decimal)3);
			dict["date"] = new XAQueryFieldInfo("char", date, date, "의견일자", (decimal)8);
			dict["tradname"] = new XAQueryFieldInfo("char", tradname, tradname, "회원사명", (decimal)30);
			dict["bopn"] = new XAQueryFieldInfo("char", bopn, bopn, "투자의견변경후", (decimal)30);
			dict["nopn"] = new XAQueryFieldInfo("char", nopn, nopn, "투자의견변경전", (decimal)30);
			dict["boga"] = new XAQueryFieldInfo("long", boga, boga.ToString("d12"), "목표가변경전", (decimal)12);
			dict["noga"] = new XAQueryFieldInfo("long", noga, noga.ToString("d12"), "목표가변경후", (decimal)12);
			dict["close"] = new XAQueryFieldInfo("long", close, close.ToString("d8"), "의견일종가", (decimal)8);

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

				case "date":
					this.date = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "tradname":
					this.tradname = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "bopn":
					this.bopn = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "nopn":
					this.nopn = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "boga":
					this.boga = fieldInfo.FieldValue.ParseLong("boga");
				break;

				case "noga":
					this.noga = fieldInfo.FieldValue.ParseLong("noga");
				break;

				case "close":
					this.close = fieldInfo.FieldValue.ParseLong("close");
				break;


			}
		}

		public static XQt3401OutBlock1[] ListFromQuery(XQt3401 query)
		{
			int count = query.GetBlockCount(XQt3401OutBlock1.BlockName);
			List<XQt3401OutBlock1> list = new List<XQt3401OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt3401OutBlock1 block = new XQt3401OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.shcode = query.GetFieldData(block.GetBlockName(), "shcode", i).TrimEnd('?'); // char 9
					block.tradno = query.GetFieldData(block.GetBlockName(), "tradno", i).TrimEnd('?'); // char 3
					block.date = query.GetFieldData(block.GetBlockName(), "date", i).TrimEnd('?'); // char 8
					block.tradname = query.GetFieldData(block.GetBlockName(), "tradname", i).TrimEnd('?'); // char 30
					block.bopn = query.GetFieldData(block.GetBlockName(), "bopn", i).TrimEnd('?'); // char 30
					block.nopn = query.GetFieldData(block.GetBlockName(), "nopn", i).TrimEnd('?'); // char 30
					block.boga = query.GetFieldData(block.GetBlockName(), "boga", i).ParseLong("boga"); // long 12
					block.noga = query.GetFieldData(block.GetBlockName(), "noga", i).ParseLong("noga"); // long 12
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
			if (shcode?.Length > 9) return false; // char 9
			if (tradno?.Length > 3) return false; // char 3
			if (date?.Length > 8) return false; // char 8
			if (tradname?.Length > 30) return false; // char 30
			if (bopn?.Length > 30) return false; // char 30
			if (nopn?.Length > 30) return false; // char 30
			if (boga.ToString().Length > 12) return false; // long 12
			if (noga.ToString().Length > 12) return false; // long 12
			if (close.ToString().Length > 8) return false; // long 8

			return true;
		}
	}

	/// <summary>
	/// 투자의견(t3401)
	/// </summary>
	public partial class XQt3401 : XingQuery
	{
		/// <summary>
		/// t3401
		/// </summary>
		public const string _typeName = "t3401";
		/// <summary>
		/// 투자의견(t3401)
		/// </summary>
		public const string _typeDesc = "투자의견(t3401)";
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
		/// t3401
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 투자의견(t3401)
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
		/// 투자의견(t3401)
		/// </summary>
		public XQt3401() : base("t3401") { }


		public static XQt3401OutBlock1[] Get(string shcode = default,char gubun1 = default,string tradno = default,string cts_date = default)
		{
			using (XQt3401 instance = new XQt3401())
			{
				instance.SetFieldData(XQt3401InBlock.BlockName, XQt3401InBlock.F.shcode, 0, shcode); // char 9
				instance.SetFieldData(XQt3401InBlock.BlockName, XQt3401InBlock.F.gubun1, 0, gubun1.ToString()); // char 1
				instance.SetFieldData(XQt3401InBlock.BlockName, XQt3401InBlock.F.tradno, 0, tradno); // char 3
				instance.SetFieldData(XQt3401InBlock.BlockName, XQt3401InBlock.F.cts_date, 0, cts_date); // char 8

				if (instance.Request() < 0)
				{
					return null;
				}

				var outBlock = instance.GetBlock1s();
				return outBlock;
			}
		}

		public bool SetBlock(XQt3401InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "shcode", 0, block.shcode); // char 9
			_xaQuery.SetFieldData(block.GetBlockName(), "gubun1", 0, block.gubun1.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "tradno", 0, block.tradno); // char 3
			_xaQuery.SetFieldData(block.GetBlockName(), "cts_date", 0, block.cts_date); // char 8

			return true;
		}

		public XQt3401OutBlock GetBlock()
		{
			XQt3401OutBlock instance = XQt3401OutBlock.FromQuery(this);
			return instance;

		}

		public XQt3401OutBlock1[] GetBlock1s()
		{
			XQt3401OutBlock1[] instance = XQt3401OutBlock1.ListFromQuery(this);
			return instance;

		}


	}

}
