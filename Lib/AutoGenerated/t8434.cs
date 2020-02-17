using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt8434InBlock : XingBlock
	{
		/// <summary>
		/// t8434InBlock
		/// </summary>
		public const string _blockName = "t8434InBlock";
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
		/// t8434InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t8434InBlock
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
		/// 건수
		/// </summary>
		[XAQueryFieldAttribute("qrycnt", "건수", "long", "3")]
		public long qrycnt;
		/// <summary>
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("focode", "단축코드", "char", "400")]
		public string focode;

		public static class F
		{
			/// <summary>
			/// 건수
			/// </summary>
			public const string qrycnt = "qrycnt";
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string focode = "focode";
		}

		public static string[] AllFields = new string[]
		{
			F.qrycnt,
			F.focode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["qrycnt"] = new XAQueryFieldInfo("long", qrycnt, qrycnt.ToString("d3"), "건수", (decimal)3);
			dict["focode"] = new XAQueryFieldInfo("char", focode, focode, "단축코드", (decimal)400);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "qrycnt":
					this.qrycnt = fieldInfo.FieldValue.ParseLong("qrycnt");
				break;

				case "focode":
					this.focode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (qrycnt.ToString().Length > 3) return false; // long 3
			if (focode?.Length > 400) return false; // char 400

			return true;
		}
	}

	public partial class XQt8434OutBlock1 : XingBlock
	{
		/// <summary>
		/// t8434OutBlock1
		/// </summary>
		public const string _blockName = "t8434OutBlock1";
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
		/// t8434OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t8434OutBlock1
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
		[XAQueryFieldAttribute("hname", "한글명", "char", "20")]
		public string hname;
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
		/// 등락율
		/// </summary>
		[XAQueryFieldAttribute("diff", "등락율", "float", "6.2")]
		public float diff;
		/// <summary>
		/// 누적거래량
		/// </summary>
		[XAQueryFieldAttribute("volume", "누적거래량", "long", "12")]
		public long volume;
		/// <summary>
		/// 체결건수
		/// </summary>
		[XAQueryFieldAttribute("checnt", "체결건수", "long", "8")]
		public long checnt;
		/// <summary>
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("focode", "단축코드", "char", "8")]
		public string focode;

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
			/// 체결건수
			/// </summary>
			public const string checnt = "checnt";
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string focode = "focode";
		}

		public static string[] AllFields = new string[]
		{
			F.hname,
			F.price,
			F.sign,
			F.change,
			F.diff,
			F.volume,
			F.checnt,
			F.focode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["hname"] = new XAQueryFieldInfo("char", hname, hname, "한글명", (decimal)20);
			dict["price"] = new XAQueryFieldInfo("float", price, price.ToString("000000.00"), "현재가", (decimal)6.2);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("float", change, change.ToString("000000.00"), "전일대비", (decimal)6.2);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "누적거래량", (decimal)12);
			dict["checnt"] = new XAQueryFieldInfo("long", checnt, checnt.ToString("d8"), "체결건수", (decimal)8);
			dict["focode"] = new XAQueryFieldInfo("char", focode, focode, "단축코드", (decimal)8);

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
					this.price = fieldInfo.FieldValue.ParseFloat("price");
				break;

				case "sign":
					this.sign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "change":
					this.change = fieldInfo.FieldValue.ParseFloat("change");
				break;

				case "diff":
					this.diff = fieldInfo.FieldValue.ParseFloat("diff");
				break;

				case "volume":
					this.volume = fieldInfo.FieldValue.ParseLong("volume");
				break;

				case "checnt":
					this.checnt = fieldInfo.FieldValue.ParseLong("checnt");
				break;

				case "focode":
					this.focode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt8434OutBlock1[] ListFromQuery(XQt8434 query)
		{
			int count = query.GetBlockCount(XQt8434OutBlock1.BlockName);
			List<XQt8434OutBlock1> list = new List<XQt8434OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt8434OutBlock1 block = new XQt8434OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.hname = query.GetFieldData(block.GetBlockName(), "hname", i).TrimEnd('?'); // char 20
					block.price = query.GetFieldData(block.GetBlockName(), "price", i).ParseFloat("price"); // float 6.2
					block.sign = query.GetFieldData(block.GetBlockName(), "sign", i).FirstOrDefault(); // char 1
					block.change = query.GetFieldData(block.GetBlockName(), "change", i).ParseFloat("change"); // float 6.2
					block.diff = query.GetFieldData(block.GetBlockName(), "diff", i).ParseFloat("diff"); // float 6.2
					block.volume = query.GetFieldData(block.GetBlockName(), "volume", i).ParseLong("volume"); // long 12
					block.checnt = query.GetFieldData(block.GetBlockName(), "checnt", i).ParseLong("checnt"); // long 8
					block.focode = query.GetFieldData(block.GetBlockName(), "focode", i).TrimEnd('?'); // char 8

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
			if (hname?.Length > 20) return false; // char 20
			// price float 6.2
			// sign char 1
			// change float 6.2
			// diff float 6.2
			if (volume.ToString().Length > 12) return false; // long 12
			if (checnt.ToString().Length > 8) return false; // long 8
			if (focode?.Length > 8) return false; // char 8

			return true;
		}
	}

	/// <summary>
	/// 선물/옵션멀티현재가조회(t8434)
	/// </summary>
	public partial class XQt8434 : XingQuery
	{
		/// <summary>
		/// t8434
		/// </summary>
		public const string _typeName = "t8434";
		/// <summary>
		/// 선물/옵션멀티현재가조회(t8434)
		/// </summary>
		public const string _typeDesc = "선물/옵션멀티현재가조회(t8434)";
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
		/// t8434
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 선물/옵션멀티현재가조회(t8434)
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
		/// 선물/옵션멀티현재가조회(t8434)
		/// </summary>
		public XQt8434() : base("t8434") { }


		public static XQt8434OutBlock1[] Get(long qrycnt = default,string focode = default)
		{
			using (XQt8434 instance = new XQt8434())
			{
				instance.SetFieldData(XQt8434InBlock.BlockName, XQt8434InBlock.F.qrycnt, 0, qrycnt.ToString("d3")); // long 3
				instance.SetFieldData(XQt8434InBlock.BlockName, XQt8434InBlock.F.focode, 0, focode); // char 400

				if (instance.Request() < 0)
				{
					return null;
				}

				var outBlock = instance.GetBlock1s();
				return outBlock;
			}
		}

		public static XQt8434OutBlock1[] ReadFromDB(/* long qrycnt = default,string focode = default */)
		{
			using (XQt8434 instance = new XQt8434())
			{

				QueryOption qo = new QueryOption("XQt8434OutBlock1");
				// if (qrycnt != default) qo.Add("qrycnt", qrycnt);
				// if (focode != default) qo.Add("focode", focode);


				var outBlock = instance.SelectMany<XQt8434OutBlock1>(qo);
				return outBlock;
			}
		}

		public bool SetBlock(XQt8434InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "qrycnt", 0, block.qrycnt.ToString("d3")); // long 3
			_xaQuery.SetFieldData(block.GetBlockName(), "focode", 0, block.focode); // char 400

			return true;
		}

		public XQt8434OutBlock1[] GetBlock1s()
		{
			XQt8434OutBlock1[] instance = XQt8434OutBlock1.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt8434OutBlock1),

		};

	}

}
