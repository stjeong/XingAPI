using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1927InBlock : XingBlock
	{
		/// <summary>
		/// t1927InBlock
		/// </summary>
		public const string _blockName = "t1927InBlock";
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
		/// t1927InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1927InBlock
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
		/// 일자
		/// </summary>
		[XAQueryFieldAttribute("date", "일자", "char", "8")]
		public string date;
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
			/// 일자
			/// </summary>
			public const string date = "date";
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
			F.date,
			F.sdate,
			F.edate,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "종목코드", (decimal)6);
			dict["date"] = new XAQueryFieldInfo("char", date, date, "일자", (decimal)8);
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

				case "date":
					this.date = fieldInfo.FieldValue.TrimEnd('?');
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
			if (date?.Length > 8) return false; // char 8
			if (sdate?.Length > 8) return false; // char 8
			if (edate?.Length > 8) return false; // char 8

			return true;
		}
	}

	public partial class XQt1927OutBlock : XingBlock
	{
		/// <summary>
		/// t1927OutBlock
		/// </summary>
		public const string _blockName = "t1927OutBlock";
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
		/// t1927OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1927OutBlock
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
		/// 일자CTS
		/// </summary>
		[XAQueryFieldAttribute("date", "일자CTS", "char", "8")]
		public string date;

		public static class F
		{
			/// <summary>
			/// 일자CTS
			/// </summary>
			public const string date = "date";
		}

		public static string[] AllFields = new string[]
		{
			F.date,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["date"] = new XAQueryFieldInfo("char", date, date, "일자CTS", (decimal)8);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "date":
					this.date = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt1927OutBlock FromQuery(XQt1927 query)
		{
			XQt1927OutBlock block = new XQt1927OutBlock();
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
				block.date = query.GetFieldData(block.GetBlockName(), "date", 0).TrimEnd('?'); // char 8

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (date?.Length > 8) return false; // char 8

			return true;
		}
	}

	public partial class XQt1927OutBlock1 : XingBlock
	{
		/// <summary>
		/// t1927OutBlock1
		/// </summary>
		public const string _blockName = "t1927OutBlock1";
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
		/// t1927OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1927OutBlock1
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
		/// 거래량
		/// </summary>
		[XAQueryFieldAttribute("volume", "거래량", "long", "12")]
		public long volume;
		/// <summary>
		/// 거래대금
		/// </summary>
		[XAQueryFieldAttribute("value", "거래대금", "long", "12")]
		public long value;
		/// <summary>
		/// 공매도수량
		/// </summary>
		[XAQueryFieldAttribute("gm_vo", "공매도수량", "long", "12")]
		public long gm_vo;
		/// <summary>
		/// 공매도대금
		/// </summary>
		[XAQueryFieldAttribute("gm_va", "공매도대금", "long", "12")]
		public long gm_va;
		/// <summary>
		/// 공매도거래비중
		/// </summary>
		[XAQueryFieldAttribute("gm_per", "공매도거래비중", "float", "6.2")]
		public float gm_per;
		/// <summary>
		/// 평균공매도단가
		/// </summary>
		[XAQueryFieldAttribute("gm_avg", "평균공매도단가", "long", "12")]
		public long gm_avg;
		/// <summary>
		/// 누적공매도수량
		/// </summary>
		[XAQueryFieldAttribute("gm_vo_sum", "누적공매도수량", "long", "12")]
		public long gm_vo_sum;

		public static class F
		{
			/// <summary>
			/// 일자
			/// </summary>
			public const string date = "date";
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
			/// 거래대금
			/// </summary>
			public const string value = "value";
			/// <summary>
			/// 공매도수량
			/// </summary>
			public const string gm_vo = "gm_vo";
			/// <summary>
			/// 공매도대금
			/// </summary>
			public const string gm_va = "gm_va";
			/// <summary>
			/// 공매도거래비중
			/// </summary>
			public const string gm_per = "gm_per";
			/// <summary>
			/// 평균공매도단가
			/// </summary>
			public const string gm_avg = "gm_avg";
			/// <summary>
			/// 누적공매도수량
			/// </summary>
			public const string gm_vo_sum = "gm_vo_sum";
		}

		public static string[] AllFields = new string[]
		{
			F.date,
			F.price,
			F.sign,
			F.change,
			F.diff,
			F.volume,
			F.value,
			F.gm_vo,
			F.gm_va,
			F.gm_per,
			F.gm_avg,
			F.gm_vo_sum,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["date"] = new XAQueryFieldInfo("char", date, date, "일자", (decimal)8);
			dict["price"] = new XAQueryFieldInfo("long", price, price.ToString("d8"), "현재가", (decimal)8);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("long", change, change.ToString("d8"), "전일대비", (decimal)8);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "거래량", (decimal)12);
			dict["value"] = new XAQueryFieldInfo("long", value, value.ToString("d12"), "거래대금", (decimal)12);
			dict["gm_vo"] = new XAQueryFieldInfo("long", gm_vo, gm_vo.ToString("d12"), "공매도수량", (decimal)12);
			dict["gm_va"] = new XAQueryFieldInfo("long", gm_va, gm_va.ToString("d12"), "공매도대금", (decimal)12);
			dict["gm_per"] = new XAQueryFieldInfo("float", gm_per, gm_per.ToString("000000.00"), "공매도거래비중", (decimal)6.2);
			dict["gm_avg"] = new XAQueryFieldInfo("long", gm_avg, gm_avg.ToString("d12"), "평균공매도단가", (decimal)12);
			dict["gm_vo_sum"] = new XAQueryFieldInfo("long", gm_vo_sum, gm_vo_sum.ToString("d12"), "누적공매도수량", (decimal)12);

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

				case "value":
					this.value = fieldInfo.FieldValue.ParseLong("value");
				break;

				case "gm_vo":
					this.gm_vo = fieldInfo.FieldValue.ParseLong("gm_vo");
				break;

				case "gm_va":
					this.gm_va = fieldInfo.FieldValue.ParseLong("gm_va");
				break;

				case "gm_per":
					this.gm_per = fieldInfo.FieldValue.ParseFloat("gm_per");
				break;

				case "gm_avg":
					this.gm_avg = fieldInfo.FieldValue.ParseLong("gm_avg");
				break;

				case "gm_vo_sum":
					this.gm_vo_sum = fieldInfo.FieldValue.ParseLong("gm_vo_sum");
				break;


			}
		}

		public static XQt1927OutBlock1[] ListFromQuery(XQt1927 query)
		{
			int count = query.GetBlockCount(XQt1927OutBlock1.BlockName);
			List<XQt1927OutBlock1> list = new List<XQt1927OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1927OutBlock1 block = new XQt1927OutBlock1();
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
					block.value = query.GetFieldData(block.GetBlockName(), "value", i).ParseLong("value"); // long 12
					block.gm_vo = query.GetFieldData(block.GetBlockName(), "gm_vo", i).ParseLong("gm_vo"); // long 12
					block.gm_va = query.GetFieldData(block.GetBlockName(), "gm_va", i).ParseLong("gm_va"); // long 12
					block.gm_per = query.GetFieldData(block.GetBlockName(), "gm_per", i).ParseFloat("gm_per"); // float 6.2
					block.gm_avg = query.GetFieldData(block.GetBlockName(), "gm_avg", i).ParseLong("gm_avg"); // long 12
					block.gm_vo_sum = query.GetFieldData(block.GetBlockName(), "gm_vo_sum", i).ParseLong("gm_vo_sum"); // long 12

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
			if (value.ToString().Length > 12) return false; // long 12
			if (gm_vo.ToString().Length > 12) return false; // long 12
			if (gm_va.ToString().Length > 12) return false; // long 12
			// gm_per float 6.2
			if (gm_avg.ToString().Length > 12) return false; // long 12
			if (gm_vo_sum.ToString().Length > 12) return false; // long 12

			return true;
		}
	}

	/// <summary>
	/// 공매도일별추이(t1927)
	/// </summary>
	public partial class XQt1927 : XingQuery
	{
		/// <summary>
		/// t1927
		/// </summary>
		public const string _typeName = "t1927";
		/// <summary>
		/// 공매도일별추이(t1927)
		/// </summary>
		public const string _typeDesc = "공매도일별추이(t1927)";
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
		/// t1927
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 공매도일별추이(t1927)
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
		/// 공매도일별추이(t1927)
		/// </summary>
		public XQt1927() : base("t1927") { }


		public class XQAllOutBlocks
		{
			public XQt1927OutBlock OutBlock { get; internal set; }
			public XQt1927OutBlock1[] OutBlock1 { get; internal set; }
		}

		public static XQAllOutBlocks Get(string shcode = default,string date = default,string sdate = default,string edate = default)
		{
			using (XQt1927 instance = new XQt1927())
			{
				instance.SetFieldData(XQt1927InBlock.BlockName, XQt1927InBlock.F.shcode, 0, shcode); // char 6
				instance.SetFieldData(XQt1927InBlock.BlockName, XQt1927InBlock.F.date, 0, date); // char 8
				instance.SetFieldData(XQt1927InBlock.BlockName, XQt1927InBlock.F.sdate, 0, sdate); // char 8
				instance.SetFieldData(XQt1927InBlock.BlockName, XQt1927InBlock.F.edate, 0, edate); // char 8

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

		public bool SetBlock(XQt1927InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "shcode", 0, block.shcode); // char 6
			_xaQuery.SetFieldData(block.GetBlockName(), "date", 0, block.date); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "sdate", 0, block.sdate); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "edate", 0, block.edate); // char 8

			return true;
		}

		public XQt1927OutBlock GetBlock()
		{
			XQt1927OutBlock instance = XQt1927OutBlock.FromQuery(this);
			return instance;

		}

		public XQt1927OutBlock1[] GetBlock1s()
		{
			XQt1927OutBlock1[] instance = XQt1927OutBlock1.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt1927OutBlock),
			typeof(XQt1927OutBlock1),

		};

	}

}
