using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1631InBlock : XingBlock
	{
		/// <summary>
		/// t1631InBlock
		/// </summary>
		public const string _blockName = "t1631InBlock";
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
		/// t1631InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1631InBlock
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
		/// 구분
		/// </summary>
		[XAQueryFieldAttribute("gubun", "구분", "char", "1")]
		public char gubun;
		/// <summary>
		/// 일자구분
		/// </summary>
		[XAQueryFieldAttribute("dgubun", "일자구분", "char", "1")]
		public char dgubun;
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
			/// 구분
			/// </summary>
			public const string gubun = "gubun";
			/// <summary>
			/// 일자구분
			/// </summary>
			public const string dgubun = "dgubun";
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
			F.gubun,
			F.dgubun,
			F.sdate,
			F.edate,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["gubun"] = new XAQueryFieldInfo("char", gubun, gubun.ToString(), "구분", (decimal)1);
			dict["dgubun"] = new XAQueryFieldInfo("char", dgubun, dgubun.ToString(), "일자구분", (decimal)1);
			dict["sdate"] = new XAQueryFieldInfo("char", sdate, sdate, "시작일자", (decimal)8);
			dict["edate"] = new XAQueryFieldInfo("char", edate, edate, "종료일자", (decimal)8);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "gubun":
					this.gubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "dgubun":
					this.dgubun = fieldInfo.FieldValue.FirstOrDefault();
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
			// gubun char 1
			// dgubun char 1
			if (sdate?.Length > 8) return false; // char 8
			if (edate?.Length > 8) return false; // char 8

			return true;
		}

		public void CopyTo(XQt1631InBlock block)
		{
			block.gubun = this.gubun;
			block.dgubun = this.dgubun;
			block.sdate = this.sdate;
			block.edate = this.edate;

		}
	}

	public partial class XQt1631OutBlock : XingBlock
	{
		/// <summary>
		/// t1631OutBlock
		/// </summary>
		public const string _blockName = "t1631OutBlock";
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
		/// t1631OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1631OutBlock
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
		/// 매도차익미체결잔량
		/// </summary>
		[XAQueryFieldAttribute("cdhrem", "매도차익미체결잔량", "long", "8")]
		public long cdhrem;
		/// <summary>
		/// 매도비차익미체결잔량
		/// </summary>
		[XAQueryFieldAttribute("bdhrem", "매도비차익미체결잔량", "long", "8")]
		public long bdhrem;
		/// <summary>
		/// 매도차익주문수량
		/// </summary>
		[XAQueryFieldAttribute("tcdrem", "매도차익주문수량", "long", "8")]
		public long tcdrem;
		/// <summary>
		/// 매도비차익주문수량
		/// </summary>
		[XAQueryFieldAttribute("tbdrem", "매도비차익주문수량", "long", "8")]
		public long tbdrem;
		/// <summary>
		/// 매수차익미체결잔량
		/// </summary>
		[XAQueryFieldAttribute("cshrem", "매수차익미체결잔량", "long", "8")]
		public long cshrem;
		/// <summary>
		/// 매수비차익미체결잔량
		/// </summary>
		[XAQueryFieldAttribute("bshrem", "매수비차익미체결잔량", "long", "8")]
		public long bshrem;
		/// <summary>
		/// 매수차익주문수량
		/// </summary>
		[XAQueryFieldAttribute("tcsrem", "매수차익주문수량", "long", "8")]
		public long tcsrem;
		/// <summary>
		/// 매수비차익주문수량
		/// </summary>
		[XAQueryFieldAttribute("tbsrem", "매수비차익주문수량", "long", "8")]
		public long tbsrem;

		public static class F
		{
			/// <summary>
			/// 매도차익미체결잔량
			/// </summary>
			public const string cdhrem = "cdhrem";
			/// <summary>
			/// 매도비차익미체결잔량
			/// </summary>
			public const string bdhrem = "bdhrem";
			/// <summary>
			/// 매도차익주문수량
			/// </summary>
			public const string tcdrem = "tcdrem";
			/// <summary>
			/// 매도비차익주문수량
			/// </summary>
			public const string tbdrem = "tbdrem";
			/// <summary>
			/// 매수차익미체결잔량
			/// </summary>
			public const string cshrem = "cshrem";
			/// <summary>
			/// 매수비차익미체결잔량
			/// </summary>
			public const string bshrem = "bshrem";
			/// <summary>
			/// 매수차익주문수량
			/// </summary>
			public const string tcsrem = "tcsrem";
			/// <summary>
			/// 매수비차익주문수량
			/// </summary>
			public const string tbsrem = "tbsrem";
		}

		public static string[] AllFields = new string[]
		{
			F.cdhrem,
			F.bdhrem,
			F.tcdrem,
			F.tbdrem,
			F.cshrem,
			F.bshrem,
			F.tcsrem,
			F.tbsrem,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["cdhrem"] = new XAQueryFieldInfo("long", cdhrem, cdhrem.ToString("d8"), "매도차익미체결잔량", (decimal)8);
			dict["bdhrem"] = new XAQueryFieldInfo("long", bdhrem, bdhrem.ToString("d8"), "매도비차익미체결잔량", (decimal)8);
			dict["tcdrem"] = new XAQueryFieldInfo("long", tcdrem, tcdrem.ToString("d8"), "매도차익주문수량", (decimal)8);
			dict["tbdrem"] = new XAQueryFieldInfo("long", tbdrem, tbdrem.ToString("d8"), "매도비차익주문수량", (decimal)8);
			dict["cshrem"] = new XAQueryFieldInfo("long", cshrem, cshrem.ToString("d8"), "매수차익미체결잔량", (decimal)8);
			dict["bshrem"] = new XAQueryFieldInfo("long", bshrem, bshrem.ToString("d8"), "매수비차익미체결잔량", (decimal)8);
			dict["tcsrem"] = new XAQueryFieldInfo("long", tcsrem, tcsrem.ToString("d8"), "매수차익주문수량", (decimal)8);
			dict["tbsrem"] = new XAQueryFieldInfo("long", tbsrem, tbsrem.ToString("d8"), "매수비차익주문수량", (decimal)8);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "cdhrem":
					this.cdhrem = fieldInfo.FieldValue.ParseLong("cdhrem");
				break;

				case "bdhrem":
					this.bdhrem = fieldInfo.FieldValue.ParseLong("bdhrem");
				break;

				case "tcdrem":
					this.tcdrem = fieldInfo.FieldValue.ParseLong("tcdrem");
				break;

				case "tbdrem":
					this.tbdrem = fieldInfo.FieldValue.ParseLong("tbdrem");
				break;

				case "cshrem":
					this.cshrem = fieldInfo.FieldValue.ParseLong("cshrem");
				break;

				case "bshrem":
					this.bshrem = fieldInfo.FieldValue.ParseLong("bshrem");
				break;

				case "tcsrem":
					this.tcsrem = fieldInfo.FieldValue.ParseLong("tcsrem");
				break;

				case "tbsrem":
					this.tbsrem = fieldInfo.FieldValue.ParseLong("tbsrem");
				break;


			}
		}

		public static XQt1631OutBlock FromQuery(XQt1631 query)
		{
			XQt1631OutBlock block = new XQt1631OutBlock();
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
				block.cdhrem = query.GetFieldData(block.GetBlockName(), "cdhrem", 0).ParseLong("cdhrem"); // long 8
				block.bdhrem = query.GetFieldData(block.GetBlockName(), "bdhrem", 0).ParseLong("bdhrem"); // long 8
				block.tcdrem = query.GetFieldData(block.GetBlockName(), "tcdrem", 0).ParseLong("tcdrem"); // long 8
				block.tbdrem = query.GetFieldData(block.GetBlockName(), "tbdrem", 0).ParseLong("tbdrem"); // long 8
				block.cshrem = query.GetFieldData(block.GetBlockName(), "cshrem", 0).ParseLong("cshrem"); // long 8
				block.bshrem = query.GetFieldData(block.GetBlockName(), "bshrem", 0).ParseLong("bshrem"); // long 8
				block.tcsrem = query.GetFieldData(block.GetBlockName(), "tcsrem", 0).ParseLong("tcsrem"); // long 8
				block.tbsrem = query.GetFieldData(block.GetBlockName(), "tbsrem", 0).ParseLong("tbsrem"); // long 8

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (cdhrem.ToString().Length > 8) return false; // long 8
			if (bdhrem.ToString().Length > 8) return false; // long 8
			if (tcdrem.ToString().Length > 8) return false; // long 8
			if (tbdrem.ToString().Length > 8) return false; // long 8
			if (cshrem.ToString().Length > 8) return false; // long 8
			if (bshrem.ToString().Length > 8) return false; // long 8
			if (tcsrem.ToString().Length > 8) return false; // long 8
			if (tbsrem.ToString().Length > 8) return false; // long 8

			return true;
		}

		public void CopyTo(XQt1631OutBlock block)
		{
			block.cdhrem = this.cdhrem;
			block.bdhrem = this.bdhrem;
			block.tcdrem = this.tcdrem;
			block.tbdrem = this.tbdrem;
			block.cshrem = this.cshrem;
			block.bshrem = this.bshrem;
			block.tcsrem = this.tcsrem;
			block.tbsrem = this.tbsrem;

		}
	}

	public partial class XQt1631OutBlock1 : XingBlock
	{
		/// <summary>
		/// t1631OutBlock1
		/// </summary>
		public const string _blockName = "t1631OutBlock1";
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
		/// t1631OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1631OutBlock1
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
		/// 매도수량
		/// </summary>
		[XAQueryFieldAttribute("offervolume", "매도수량", "long", "8")]
		public long offervolume;
		/// <summary>
		/// 매도금액
		/// </summary>
		[XAQueryFieldAttribute("offervalue", "매도금액", "long", "12")]
		public long offervalue;
		/// <summary>
		/// 매수수량
		/// </summary>
		[XAQueryFieldAttribute("bidvolume", "매수수량", "long", "8")]
		public long bidvolume;
		/// <summary>
		/// 매수금액
		/// </summary>
		[XAQueryFieldAttribute("bidvalue", "매수금액", "long", "12")]
		public long bidvalue;
		/// <summary>
		/// 순매수수량
		/// </summary>
		[XAQueryFieldAttribute("volume", "순매수수량", "long", "8")]
		public long volume;
		/// <summary>
		/// 순매수금액
		/// </summary>
		[XAQueryFieldAttribute("value", "순매수금액", "long", "12")]
		public long value;

		public static class F
		{
			/// <summary>
			/// 매도수량
			/// </summary>
			public const string offervolume = "offervolume";
			/// <summary>
			/// 매도금액
			/// </summary>
			public const string offervalue = "offervalue";
			/// <summary>
			/// 매수수량
			/// </summary>
			public const string bidvolume = "bidvolume";
			/// <summary>
			/// 매수금액
			/// </summary>
			public const string bidvalue = "bidvalue";
			/// <summary>
			/// 순매수수량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// 순매수금액
			/// </summary>
			public const string value = "value";
		}

		public static string[] AllFields = new string[]
		{
			F.offervolume,
			F.offervalue,
			F.bidvolume,
			F.bidvalue,
			F.volume,
			F.value,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["offervolume"] = new XAQueryFieldInfo("long", offervolume, offervolume.ToString("d8"), "매도수량", (decimal)8);
			dict["offervalue"] = new XAQueryFieldInfo("long", offervalue, offervalue.ToString("d12"), "매도금액", (decimal)12);
			dict["bidvolume"] = new XAQueryFieldInfo("long", bidvolume, bidvolume.ToString("d8"), "매수수량", (decimal)8);
			dict["bidvalue"] = new XAQueryFieldInfo("long", bidvalue, bidvalue.ToString("d12"), "매수금액", (decimal)12);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d8"), "순매수수량", (decimal)8);
			dict["value"] = new XAQueryFieldInfo("long", value, value.ToString("d12"), "순매수금액", (decimal)12);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "offervolume":
					this.offervolume = fieldInfo.FieldValue.ParseLong("offervolume");
				break;

				case "offervalue":
					this.offervalue = fieldInfo.FieldValue.ParseLong("offervalue");
				break;

				case "bidvolume":
					this.bidvolume = fieldInfo.FieldValue.ParseLong("bidvolume");
				break;

				case "bidvalue":
					this.bidvalue = fieldInfo.FieldValue.ParseLong("bidvalue");
				break;

				case "volume":
					this.volume = fieldInfo.FieldValue.ParseLong("volume");
				break;

				case "value":
					this.value = fieldInfo.FieldValue.ParseLong("value");
				break;


			}
		}

		public static XQt1631OutBlock1[] ListFromQuery(XQt1631 query)
		{
			int count = query.GetBlockCount(XQt1631OutBlock1.BlockName);
			List<XQt1631OutBlock1> list = new List<XQt1631OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1631OutBlock1 block = new XQt1631OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.offervolume = query.GetFieldData(block.GetBlockName(), "offervolume", i).ParseLong("offervolume"); // long 8
					block.offervalue = query.GetFieldData(block.GetBlockName(), "offervalue", i).ParseLong("offervalue"); // long 12
					block.bidvolume = query.GetFieldData(block.GetBlockName(), "bidvolume", i).ParseLong("bidvolume"); // long 8
					block.bidvalue = query.GetFieldData(block.GetBlockName(), "bidvalue", i).ParseLong("bidvalue"); // long 12
					block.volume = query.GetFieldData(block.GetBlockName(), "volume", i).ParseLong("volume"); // long 8
					block.value = query.GetFieldData(block.GetBlockName(), "value", i).ParseLong("value"); // long 12

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
			if (offervolume.ToString().Length > 8) return false; // long 8
			if (offervalue.ToString().Length > 12) return false; // long 12
			if (bidvolume.ToString().Length > 8) return false; // long 8
			if (bidvalue.ToString().Length > 12) return false; // long 12
			if (volume.ToString().Length > 8) return false; // long 8
			if (value.ToString().Length > 12) return false; // long 12

			return true;
		}

		public void CopyTo(XQt1631OutBlock1 block)
		{
			block.offervolume = this.offervolume;
			block.offervalue = this.offervalue;
			block.bidvolume = this.bidvolume;
			block.bidvalue = this.bidvalue;
			block.volume = this.volume;
			block.value = this.value;

		}
	}

	/// <summary>
	/// 프로그램매매종합조회(t1631)
	/// </summary>
	public partial class XQt1631 : XingQuery
	{
		/// <summary>
		/// t1631
		/// </summary>
		public const string _typeName = "t1631";
		/// <summary>
		/// 프로그램매매종합조회(t1631)
		/// </summary>
		public const string _typeDesc = "프로그램매매종합조회(t1631)";
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
		/// t1631
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 프로그램매매종합조회(t1631)
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
		/// 프로그램매매종합조회(t1631)
		/// </summary>
		public XQt1631() : base("t1631") { }


		public class XQAllOutBlocks
		{
			public XQt1631OutBlock OutBlock { get; internal set; }
			public XQt1631OutBlock1[] OutBlock1 { get; internal set; }
		}

		public static XQAllOutBlocks Get(char gubun = default,char dgubun = default,string sdate = default,string edate = default)
		{
			using (XQt1631 instance = new XQt1631())
			{
				instance.SetFieldData(XQt1631InBlock.BlockName, XQt1631InBlock.F.gubun, 0, gubun.ToString()); // char 1
				instance.SetFieldData(XQt1631InBlock.BlockName, XQt1631InBlock.F.dgubun, 0, dgubun.ToString()); // char 1
				instance.SetFieldData(XQt1631InBlock.BlockName, XQt1631InBlock.F.sdate, 0, sdate); // char 8
				instance.SetFieldData(XQt1631InBlock.BlockName, XQt1631InBlock.F.edate, 0, edate); // char 8

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

		public static XQAllOutBlocks ReadFromDB(string tableNamePostfix = null /*, char gubun = default,char dgubun = default,string sdate = default,string edate = default */)
		{
			using (XQt1631 instance = new XQt1631())
			{

				XQAllOutBlocks results = new XQAllOutBlocks();

				string tableName = (tableNamePostfix == null) ? "XQt1631OutBlock" : $"XQt1631OutBlock_{tableNamePostfix}";
				QueryOption qo = new QueryOption(tableName);
				results.OutBlock = instance.Select<XQt1631OutBlock>(qo);

				tableName = (tableNamePostfix == null) ? "XQt1631OutBlock1" : $"XQt1631OutBlock1_{tableNamePostfix}";
				qo = new QueryOption(tableName);
				results.OutBlock1 = instance.SelectMany<XQt1631OutBlock1>(qo);
				return results;
			}
		}

		public bool SetBlock(XQt1631InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "gubun", 0, block.gubun.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "dgubun", 0, block.dgubun.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "sdate", 0, block.sdate); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "edate", 0, block.edate); // char 8

			return true;
		}

		public XQt1631OutBlock GetBlock()
		{
			XQt1631OutBlock instance = XQt1631OutBlock.FromQuery(this);
			return instance;

		}

		public XQt1631OutBlock1[] GetBlock1s()
		{
			XQt1631OutBlock1[] instance = XQt1631OutBlock1.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt1631OutBlock),
			typeof(XQt1631OutBlock1),

		};

	}

}
