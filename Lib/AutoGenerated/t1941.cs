using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1941InBlock : XingBlock
	{
		/// <summary>
		/// t1941InBlock
		/// </summary>
		public const string _blockName = "t1941InBlock";
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
		/// t1941InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1941InBlock
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
		/// 시작일자
		/// </summary>
		[XAQueryFieldAttribute("sdate", "시작일자", "char", "8")]
		public string sdate;
		/// <summary>
		/// 종료일자
		/// </summary>
		[XAQueryFieldAttribute("edate", "종료일자", "char", "8")]
		public string edate;

		public static class F
		{
			/// <summary>
			/// 종목코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 시작일자
			/// </summary>
			public const string sdate = "sdate";
			/// <summary>
			/// 종료일자
			/// </summary>
			public const string edate = "edate";
		}

		public static string[] AllFields = new string[]
		{
			F.shcode,
			F.sdate,
			F.edate,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "종목코드", (decimal)6);
			dict["sdate"] = new XAQueryFieldInfo("char", sdate, sdate, "시작일자", (decimal)8);
			dict["edate"] = new XAQueryFieldInfo("char", edate, edate, "종료일자", (decimal)8);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "sdate":
					this.sdate = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "edate":
					this.edate = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (shcode?.Length > 6) return false; // char 6
			if (sdate?.Length > 8) return false; // char 8
			if (edate?.Length > 8) return false; // char 8

			return true;
		}
	}

	public partial class XQt1941OutBlock1 : XingBlock
	{
		/// <summary>
		/// t1941OutBlock1
		/// </summary>
		public const string _blockName = "t1941OutBlock1";
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
		/// t1941OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1941OutBlock1
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
		[XAQueryFieldAttribute("date", "일자", "char", "8")]
		public string date;
		/// <summary>
		/// 종가
		/// </summary>
		[XAQueryFieldAttribute("price", "종가", "long", "8")]
		public long price;
		/// <summary>
		/// 대비구분
		/// </summary>
		[XAQueryFieldAttribute("sign", "대비구분", "char", "1")]
		public char sign;
		/// <summary>
		/// 대비
		/// </summary>
		[XAQueryFieldAttribute("change", "대비", "long", "8")]
		public long change;
		/// <summary>
		/// 등락율
		/// </summary>
		[XAQueryFieldAttribute("diff", "등락율", "float", "6.2")]
		public float diff;
		/// <summary>
		/// 거래량
		/// </summary>
		[XAQueryFieldAttribute("volume", "거래량", "long", "12")]
		public long volume;
		/// <summary>
		/// 당일체결
		/// </summary>
		[XAQueryFieldAttribute("upvolume", "당일체결", "long", "12")]
		public long upvolume;
		/// <summary>
		/// 당일상환
		/// </summary>
		[XAQueryFieldAttribute("dnvolume", "당일상환", "long", "12")]
		public long dnvolume;
		/// <summary>
		/// 당일잔고
		/// </summary>
		[XAQueryFieldAttribute("tovolume", "당일잔고", "long", "12")]
		public long tovolume;
		/// <summary>
		/// 잔고금액
		/// </summary>
		[XAQueryFieldAttribute("tovalue", "잔고금액", "long", "12")]
		public long tovalue;
		/// <summary>
		/// 종목코드
		/// </summary>
		[XAQueryFieldAttribute("shcode", "종목코드", "char", "6")]
		public string shcode;
		/// <summary>
		/// 대차증감
		/// </summary>
		[XAQueryFieldAttribute("tovoldif", "대차증감", "long", "12")]
		public long tovoldif;

		public static class F
		{
			/// <summary>
			/// 일자
			/// </summary>
			public const string date = "date";
			/// <summary>
			/// 종가
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
			/// 당일체결
			/// </summary>
			public const string upvolume = "upvolume";
			/// <summary>
			/// 당일상환
			/// </summary>
			public const string dnvolume = "dnvolume";
			/// <summary>
			/// 당일잔고
			/// </summary>
			public const string tovolume = "tovolume";
			/// <summary>
			/// 잔고금액
			/// </summary>
			public const string tovalue = "tovalue";
			/// <summary>
			/// 종목코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 대차증감
			/// </summary>
			public const string tovoldif = "tovoldif";
		}

		public static string[] AllFields = new string[]
		{
			F.date,
			F.price,
			F.sign,
			F.change,
			F.diff,
			F.volume,
			F.upvolume,
			F.dnvolume,
			F.tovolume,
			F.tovalue,
			F.shcode,
			F.tovoldif,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["date"] = new XAQueryFieldInfo("char", date, date, "일자", (decimal)8);
			dict["price"] = new XAQueryFieldInfo("long", price, price.ToString("d8"), "종가", (decimal)8);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("long", change, change.ToString("d8"), "대비", (decimal)8);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "거래량", (decimal)12);
			dict["upvolume"] = new XAQueryFieldInfo("long", upvolume, upvolume.ToString("d12"), "당일체결", (decimal)12);
			dict["dnvolume"] = new XAQueryFieldInfo("long", dnvolume, dnvolume.ToString("d12"), "당일상환", (decimal)12);
			dict["tovolume"] = new XAQueryFieldInfo("long", tovolume, tovolume.ToString("d12"), "당일잔고", (decimal)12);
			dict["tovalue"] = new XAQueryFieldInfo("long", tovalue, tovalue.ToString("d12"), "잔고금액", (decimal)12);
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "종목코드", (decimal)6);
			dict["tovoldif"] = new XAQueryFieldInfo("long", tovoldif, tovoldif.ToString("d12"), "대차증감", (decimal)12);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "date":
					this.date = fieldInfo.FieldValue.TrimEnd('?');
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

				case "upvolume":
					this.upvolume = fieldInfo.FieldValue.ParseLong("upvolume");
				break;

				case "dnvolume":
					this.dnvolume = fieldInfo.FieldValue.ParseLong("dnvolume");
				break;

				case "tovolume":
					this.tovolume = fieldInfo.FieldValue.ParseLong("tovolume");
				break;

				case "tovalue":
					this.tovalue = fieldInfo.FieldValue.ParseLong("tovalue");
				break;

				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "tovoldif":
					this.tovoldif = fieldInfo.FieldValue.ParseLong("tovoldif");
				break;


			}
		}

		public static XQt1941OutBlock1[] ListFromQuery(XQt1941 query)
		{
			int count = query.GetBlockCount(XQt1941OutBlock1.BlockName);
			List<XQt1941OutBlock1> list = new List<XQt1941OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1941OutBlock1 block = new XQt1941OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.date = query.GetFieldData(block.GetBlockName(), "date", i).TrimEnd('?'); // char 8
					block.price = query.GetFieldData(block.GetBlockName(), "price", i).ParseLong("price"); // long 8
					block.sign = query.GetFieldData(block.GetBlockName(), "sign", i).FirstOrDefault(); // char 1
					block.change = query.GetFieldData(block.GetBlockName(), "change", i).ParseLong("change"); // long 8
					block.diff = query.GetFieldData(block.GetBlockName(), "diff", i).ParseFloat("diff"); // float 6.2
					block.volume = query.GetFieldData(block.GetBlockName(), "volume", i).ParseLong("volume"); // long 12
					block.upvolume = query.GetFieldData(block.GetBlockName(), "upvolume", i).ParseLong("upvolume"); // long 12
					block.dnvolume = query.GetFieldData(block.GetBlockName(), "dnvolume", i).ParseLong("dnvolume"); // long 12
					block.tovolume = query.GetFieldData(block.GetBlockName(), "tovolume", i).ParseLong("tovolume"); // long 12
					block.tovalue = query.GetFieldData(block.GetBlockName(), "tovalue", i).ParseLong("tovalue"); // long 12
					block.shcode = query.GetFieldData(block.GetBlockName(), "shcode", i).TrimEnd('?'); // char 6
					block.tovoldif = query.GetFieldData(block.GetBlockName(), "tovoldif", i).ParseLong("tovoldif"); // long 12

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
			if (price.ToString().Length > 8) return false; // long 8
			// sign char 1
			if (change.ToString().Length > 8) return false; // long 8
			// diff float 6.2
			if (volume.ToString().Length > 12) return false; // long 12
			if (upvolume.ToString().Length > 12) return false; // long 12
			if (dnvolume.ToString().Length > 12) return false; // long 12
			if (tovolume.ToString().Length > 12) return false; // long 12
			if (tovalue.ToString().Length > 12) return false; // long 12
			if (shcode?.Length > 6) return false; // char 6
			if (tovoldif.ToString().Length > 12) return false; // long 12

			return true;
		}
	}

	/// <summary>
	/// 종목별대차거래일간추이(t1941)
	/// </summary>
	public partial class XQt1941 : XingQuery
	{
		/// <summary>
		/// t1941
		/// </summary>
		public const string _typeName = "t1941";
		/// <summary>
		/// 종목별대차거래일간추이(t1941)
		/// </summary>
		public const string _typeDesc = "종목별대차거래일간추이(t1941)";
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
		/// t1941
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 종목별대차거래일간추이(t1941)
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
		/// 종목별대차거래일간추이(t1941)
		/// </summary>
		public XQt1941() : base("t1941") { }


		public static XQt1941OutBlock1[] Get(string shcode = default,string sdate = default,string edate = default)
		{
			using (XQt1941 instance = new XQt1941())
			{
				instance.SetFieldData(XQt1941InBlock.BlockName, XQt1941InBlock.F.shcode, 0, shcode); // char 6
				instance.SetFieldData(XQt1941InBlock.BlockName, XQt1941InBlock.F.sdate, 0, sdate); // char 8
				instance.SetFieldData(XQt1941InBlock.BlockName, XQt1941InBlock.F.edate, 0, edate); // char 8

				if (instance.Request() < 0)
				{
					return null;
				}

				var outBlock = instance.GetBlock1s();
				return outBlock;
			}
		}

		public bool SetBlock(XQt1941InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "shcode", 0, block.shcode); // char 6
			_xaQuery.SetFieldData(block.GetBlockName(), "sdate", 0, block.sdate); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "edate", 0, block.edate); // char 8

			return true;
		}

		public XQt1941OutBlock1[] GetBlock1s()
		{
			XQt1941OutBlock1[] instance = XQt1941OutBlock1.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt1941OutBlock1),

		};

	}

}
