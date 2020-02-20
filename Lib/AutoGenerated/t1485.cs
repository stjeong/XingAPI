using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1485InBlock : XingBlock
	{
		/// <summary>
		/// t1485InBlock
		/// </summary>
		public const string _blockName = "t1485InBlock";
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
		/// t1485InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1485InBlock
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
		/// 업종코드
		/// </summary>
		[XAQueryFieldAttribute("upcode", "업종코드", "char", "3")]
		public string upcode;
		/// <summary>
		/// 조회구분
		/// </summary>
		[XAQueryFieldAttribute("gubun", "조회구분", "char", "1")]
		public char gubun;

		public static class F
		{
			/// <summary>
			/// 업종코드
			/// </summary>
			public const string upcode = "upcode";
			/// <summary>
			/// 조회구분
			/// </summary>
			public const string gubun = "gubun";
		}

		public static string[] AllFields = new string[]
		{
			F.upcode,
			F.gubun,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["upcode"] = new XAQueryFieldInfo("char", upcode, upcode, "업종코드", (decimal)3);
			dict["gubun"] = new XAQueryFieldInfo("char", gubun, gubun.ToString(), "조회구분", (decimal)1);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "upcode":
					this.upcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "gubun":
					this.gubun = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public bool VerifyData()
		{
			if (upcode?.Length > 3) return false; // char 3
			// gubun char 1

			return true;
		}
	}

	public partial class XQt1485OutBlock : XingBlock
	{
		/// <summary>
		/// t1485OutBlock
		/// </summary>
		public const string _blockName = "t1485OutBlock";
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
		/// t1485OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1485OutBlock
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
		/// 현재지수
		/// </summary>
		[XAQueryFieldAttribute("pricejisu", "현재지수", "float", "10.2")]
		public float pricejisu;
		/// <summary>
		/// 지수전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("sign", "지수전일대비구분", "char", "1")]
		public char sign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[XAQueryFieldAttribute("change", "전일대비", "float", "10.2")]
		public float change;
		/// <summary>
		/// 거래량
		/// </summary>
		[XAQueryFieldAttribute("volume", "거래량", "long", "12")]
		public long volume;
		/// <summary>
		/// 상승종목수
		/// </summary>
		[XAQueryFieldAttribute("yhighjo", "상승종목수", "long", "4")]
		public long yhighjo;
		/// <summary>
		/// 상한종목수
		/// </summary>
		[XAQueryFieldAttribute("yupjo", "상한종목수", "long", "4")]
		public long yupjo;
		/// <summary>
		/// 보합종목수
		/// </summary>
		[XAQueryFieldAttribute("yunchgjo", "보합종목수", "long", "4")]
		public long yunchgjo;
		/// <summary>
		/// 하락종목수
		/// </summary>
		[XAQueryFieldAttribute("ylowjo", "하락종목수", "long", "4")]
		public long ylowjo;
		/// <summary>
		/// 하한종목수
		/// </summary>
		[XAQueryFieldAttribute("ydownjo", "하한종목수", "long", "4")]
		public long ydownjo;
		/// <summary>
		/// 거래형성수
		/// </summary>
		[XAQueryFieldAttribute("ytrajo", "거래형성수", "long", "4")]
		public long ytrajo;

		public static class F
		{
			/// <summary>
			/// 현재지수
			/// </summary>
			public const string pricejisu = "pricejisu";
			/// <summary>
			/// 지수전일대비구분
			/// </summary>
			public const string sign = "sign";
			/// <summary>
			/// 전일대비
			/// </summary>
			public const string change = "change";
			/// <summary>
			/// 거래량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// 상승종목수
			/// </summary>
			public const string yhighjo = "yhighjo";
			/// <summary>
			/// 상한종목수
			/// </summary>
			public const string yupjo = "yupjo";
			/// <summary>
			/// 보합종목수
			/// </summary>
			public const string yunchgjo = "yunchgjo";
			/// <summary>
			/// 하락종목수
			/// </summary>
			public const string ylowjo = "ylowjo";
			/// <summary>
			/// 하한종목수
			/// </summary>
			public const string ydownjo = "ydownjo";
			/// <summary>
			/// 거래형성수
			/// </summary>
			public const string ytrajo = "ytrajo";
		}

		public static string[] AllFields = new string[]
		{
			F.pricejisu,
			F.sign,
			F.change,
			F.volume,
			F.yhighjo,
			F.yupjo,
			F.yunchgjo,
			F.ylowjo,
			F.ydownjo,
			F.ytrajo,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["pricejisu"] = new XAQueryFieldInfo("float", pricejisu, pricejisu.ToString("0000000000.00"), "현재지수", (decimal)10.2);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "지수전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("float", change, change.ToString("0000000000.00"), "전일대비", (decimal)10.2);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "거래량", (decimal)12);
			dict["yhighjo"] = new XAQueryFieldInfo("long", yhighjo, yhighjo.ToString("d4"), "상승종목수", (decimal)4);
			dict["yupjo"] = new XAQueryFieldInfo("long", yupjo, yupjo.ToString("d4"), "상한종목수", (decimal)4);
			dict["yunchgjo"] = new XAQueryFieldInfo("long", yunchgjo, yunchgjo.ToString("d4"), "보합종목수", (decimal)4);
			dict["ylowjo"] = new XAQueryFieldInfo("long", ylowjo, ylowjo.ToString("d4"), "하락종목수", (decimal)4);
			dict["ydownjo"] = new XAQueryFieldInfo("long", ydownjo, ydownjo.ToString("d4"), "하한종목수", (decimal)4);
			dict["ytrajo"] = new XAQueryFieldInfo("long", ytrajo, ytrajo.ToString("d4"), "거래형성수", (decimal)4);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "pricejisu":
					this.pricejisu = fieldInfo.FieldValue.ParseFloat("pricejisu");
				break;

				case "sign":
					this.sign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "change":
					this.change = fieldInfo.FieldValue.ParseFloat("change");
				break;

				case "volume":
					this.volume = fieldInfo.FieldValue.ParseLong("volume");
				break;

				case "yhighjo":
					this.yhighjo = fieldInfo.FieldValue.ParseLong("yhighjo");
				break;

				case "yupjo":
					this.yupjo = fieldInfo.FieldValue.ParseLong("yupjo");
				break;

				case "yunchgjo":
					this.yunchgjo = fieldInfo.FieldValue.ParseLong("yunchgjo");
				break;

				case "ylowjo":
					this.ylowjo = fieldInfo.FieldValue.ParseLong("ylowjo");
				break;

				case "ydownjo":
					this.ydownjo = fieldInfo.FieldValue.ParseLong("ydownjo");
				break;

				case "ytrajo":
					this.ytrajo = fieldInfo.FieldValue.ParseLong("ytrajo");
				break;


			}
		}

		public static XQt1485OutBlock FromQuery(XQt1485 query)
		{
			XQt1485OutBlock block = new XQt1485OutBlock();
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
				block.pricejisu = query.GetFieldData(block.GetBlockName(), "pricejisu", 0).ParseFloat("pricejisu"); // float 10.2
				block.sign = query.GetFieldData(block.GetBlockName(), "sign", 0).FirstOrDefault(); // char 1
				block.change = query.GetFieldData(block.GetBlockName(), "change", 0).ParseFloat("change"); // float 10.2
				block.volume = query.GetFieldData(block.GetBlockName(), "volume", 0).ParseLong("volume"); // long 12
				block.yhighjo = query.GetFieldData(block.GetBlockName(), "yhighjo", 0).ParseLong("yhighjo"); // long 4
				block.yupjo = query.GetFieldData(block.GetBlockName(), "yupjo", 0).ParseLong("yupjo"); // long 4
				block.yunchgjo = query.GetFieldData(block.GetBlockName(), "yunchgjo", 0).ParseLong("yunchgjo"); // long 4
				block.ylowjo = query.GetFieldData(block.GetBlockName(), "ylowjo", 0).ParseLong("ylowjo"); // long 4
				block.ydownjo = query.GetFieldData(block.GetBlockName(), "ydownjo", 0).ParseLong("ydownjo"); // long 4
				block.ytrajo = query.GetFieldData(block.GetBlockName(), "ytrajo", 0).ParseLong("ytrajo"); // long 4

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			// pricejisu float 10.2
			// sign char 1
			// change float 10.2
			if (volume.ToString().Length > 12) return false; // long 12
			if (yhighjo.ToString().Length > 4) return false; // long 4
			if (yupjo.ToString().Length > 4) return false; // long 4
			if (yunchgjo.ToString().Length > 4) return false; // long 4
			if (ylowjo.ToString().Length > 4) return false; // long 4
			if (ydownjo.ToString().Length > 4) return false; // long 4
			if (ytrajo.ToString().Length > 4) return false; // long 4

			return true;
		}
	}

	public partial class XQt1485OutBlock1 : XingBlock
	{
		/// <summary>
		/// t1485OutBlock1
		/// </summary>
		public const string _blockName = "t1485OutBlock1";
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
		/// t1485OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1485OutBlock1
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
		[XAQueryFieldAttribute("chetime", "시간", "char", "6")]
		public string chetime;
		/// <summary>
		/// 예상지수
		/// </summary>
		[XAQueryFieldAttribute("jisu", "예상지수", "float", "10.2")]
		public float jisu;
		/// <summary>
		/// 전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("sign", "전일대비구분", "char", "1")]
		public char sign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[XAQueryFieldAttribute("change", "전일대비", "float", "10.2")]
		public float change;
		/// <summary>
		/// 예상체결량
		/// </summary>
		[XAQueryFieldAttribute("volume", "예상체결량", "long", "12")]
		public long volume;
		/// <summary>
		/// 예상체결량직전대비
		/// </summary>
		[XAQueryFieldAttribute("volcha", "예상체결량직전대비", "long", "12")]
		public long volcha;

		public static class F
		{
			/// <summary>
			/// 시간
			/// </summary>
			public const string chetime = "chetime";
			/// <summary>
			/// 예상지수
			/// </summary>
			public const string jisu = "jisu";
			/// <summary>
			/// 전일대비구분
			/// </summary>
			public const string sign = "sign";
			/// <summary>
			/// 전일대비
			/// </summary>
			public const string change = "change";
			/// <summary>
			/// 예상체결량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// 예상체결량직전대비
			/// </summary>
			public const string volcha = "volcha";
		}

		public static string[] AllFields = new string[]
		{
			F.chetime,
			F.jisu,
			F.sign,
			F.change,
			F.volume,
			F.volcha,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["chetime"] = new XAQueryFieldInfo("char", chetime, chetime, "시간", (decimal)6);
			dict["jisu"] = new XAQueryFieldInfo("float", jisu, jisu.ToString("0000000000.00"), "예상지수", (decimal)10.2);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("float", change, change.ToString("0000000000.00"), "전일대비", (decimal)10.2);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "예상체결량", (decimal)12);
			dict["volcha"] = new XAQueryFieldInfo("long", volcha, volcha.ToString("d12"), "예상체결량직전대비", (decimal)12);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "chetime":
					this.chetime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "jisu":
					this.jisu = fieldInfo.FieldValue.ParseFloat("jisu");
				break;

				case "sign":
					this.sign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "change":
					this.change = fieldInfo.FieldValue.ParseFloat("change");
				break;

				case "volume":
					this.volume = fieldInfo.FieldValue.ParseLong("volume");
				break;

				case "volcha":
					this.volcha = fieldInfo.FieldValue.ParseLong("volcha");
				break;


			}
		}

		public static XQt1485OutBlock1[] ListFromQuery(XQt1485 query)
		{
			int count = query.GetBlockCount(XQt1485OutBlock1.BlockName);
			List<XQt1485OutBlock1> list = new List<XQt1485OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1485OutBlock1 block = new XQt1485OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.chetime = query.GetFieldData(block.GetBlockName(), "chetime", i).TrimEnd('?'); // char 6
					block.jisu = query.GetFieldData(block.GetBlockName(), "jisu", i).ParseFloat("jisu"); // float 10.2
					block.sign = query.GetFieldData(block.GetBlockName(), "sign", i).FirstOrDefault(); // char 1
					block.change = query.GetFieldData(block.GetBlockName(), "change", i).ParseFloat("change"); // float 10.2
					block.volume = query.GetFieldData(block.GetBlockName(), "volume", i).ParseLong("volume"); // long 12
					block.volcha = query.GetFieldData(block.GetBlockName(), "volcha", i).ParseLong("volcha"); // long 12

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
			if (chetime?.Length > 6) return false; // char 6
			// jisu float 10.2
			// sign char 1
			// change float 10.2
			if (volume.ToString().Length > 12) return false; // long 12
			if (volcha.ToString().Length > 12) return false; // long 12

			return true;
		}
	}

	/// <summary>
	/// 예상지수(t1485)
	/// </summary>
	public partial class XQt1485 : XingQuery
	{
		/// <summary>
		/// t1485
		/// </summary>
		public const string _typeName = "t1485";
		/// <summary>
		/// 예상지수(t1485)
		/// </summary>
		public const string _typeDesc = "예상지수(t1485)";
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
		/// t1485
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 예상지수(t1485)
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
		/// 예상지수(t1485)
		/// </summary>
		public XQt1485() : base("t1485") { }


		public class XQAllOutBlocks
		{
			public XQt1485OutBlock OutBlock { get; internal set; }
			public XQt1485OutBlock1[] OutBlock1 { get; internal set; }
		}

		public static XQAllOutBlocks Get(string upcode = default,char gubun = default)
		{
			using (XQt1485 instance = new XQt1485())
			{
				instance.SetFieldData(XQt1485InBlock.BlockName, XQt1485InBlock.F.upcode, 0, upcode); // char 3
				instance.SetFieldData(XQt1485InBlock.BlockName, XQt1485InBlock.F.gubun, 0, gubun.ToString()); // char 1

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

		public static XQAllOutBlocks ReadFromDB(string tableNamePostfix = null /*, string upcode = default,char gubun = default */)
		{
			using (XQt1485 instance = new XQt1485())
			{

				XQAllOutBlocks results = new XQAllOutBlocks();

				string tableName = (tableNamePostfix == null) ? "XQt1485OutBlock" : $"XQt1485OutBlock_{tableNamePostfix}";
				QueryOption qo = new QueryOption(tableName);
				results.OutBlock = instance.Select<XQt1485OutBlock>(qo);

				tableName = (tableNamePostfix == null) ? "XQt1485OutBlock1" : $"XQt1485OutBlock1_{tableNamePostfix}";
				qo = new QueryOption(tableName);
				results.OutBlock1 = instance.SelectMany<XQt1485OutBlock1>(qo);
				return results;
			}
		}

		public bool SetBlock(XQt1485InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "upcode", 0, block.upcode); // char 3
			_xaQuery.SetFieldData(block.GetBlockName(), "gubun", 0, block.gubun.ToString()); // char 1

			return true;
		}

		public XQt1485OutBlock GetBlock()
		{
			XQt1485OutBlock instance = XQt1485OutBlock.FromQuery(this);
			return instance;

		}

		public XQt1485OutBlock1[] GetBlock1s()
		{
			XQt1485OutBlock1[] instance = XQt1485OutBlock1.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt1485OutBlock),
			typeof(XQt1485OutBlock1),

		};

	}

}
