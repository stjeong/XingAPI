using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1405InBlock : XingBlock
	{
		/// <summary>
		/// t1405InBlock
		/// </summary>
		public const string _blockName = "t1405InBlock";
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
		/// t1405InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1405InBlock
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
		[XAQueryFieldAttribute("구분")]
		public char gubun;
		/// <summary>
		/// 종목체크
		/// </summary>
		[XAQueryFieldAttribute("종목체크")]
		public char jongchk;
		/// <summary>
		/// 종목코드_CTS
		/// </summary>
		[XAQueryFieldAttribute("종목코드_CTS")]
		public string cts_shcode;

		public static class F
		{
			/// <summary>
			/// 구분
			/// </summary>
			public const string gubun = "gubun";
			/// <summary>
			/// 종목체크
			/// </summary>
			public const string jongchk = "jongchk";
			/// <summary>
			/// 종목코드_CTS
			/// </summary>
			public const string cts_shcode = "cts_shcode";
		}

		public static string[] AllFields = new string[]
		{
			F.gubun,
			F.jongchk,
			F.cts_shcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["gubun"] = new XAQueryFieldInfo("char", gubun, gubun.ToString(), "구분", (decimal)1);
			dict["jongchk"] = new XAQueryFieldInfo("char", jongchk, jongchk.ToString(), "종목체크", (decimal)1);
			dict["cts_shcode"] = new XAQueryFieldInfo("char", cts_shcode, cts_shcode, "종목코드_CTS", (decimal)6);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "gubun":
					this.gubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "jongchk":
					this.jongchk = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "cts_shcode":
					this.cts_shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			// gubun char 1
			// jongchk char 1
			if (cts_shcode?.Length > 6) return false; // char 6

			return true;
		}
	}

	public partial class XQt1405OutBlock : XingBlock
	{
		/// <summary>
		/// t1405OutBlock
		/// </summary>
		public const string _blockName = "t1405OutBlock";
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
		/// t1405OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1405OutBlock
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
		/// 종목코드_CTS
		/// </summary>
		[XAQueryFieldAttribute("종목코드_CTS")]
		public string cts_shcode;

		public static class F
		{
			/// <summary>
			/// 종목코드_CTS
			/// </summary>
			public const string cts_shcode = "cts_shcode";
		}

		public static string[] AllFields = new string[]
		{
			F.cts_shcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["cts_shcode"] = new XAQueryFieldInfo("char", cts_shcode, cts_shcode, "종목코드_CTS", (decimal)6);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "cts_shcode":
					this.cts_shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt1405OutBlock FromQuery(XQt1405 query)
		{
			XQt1405OutBlock block = new XQt1405OutBlock();
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
				block.cts_shcode = query.GetFieldData(block.GetBlockName(), "cts_shcode", 0).TrimEnd('?'); // char 6

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (cts_shcode?.Length > 6) return false; // char 6

			return true;
		}
	}

	public partial class XQt1405OutBlock1 : XingBlock
	{
		/// <summary>
		/// t1405OutBlock1
		/// </summary>
		public const string _blockName = "t1405OutBlock1";
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
		/// t1405OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1405OutBlock1
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
		[XAQueryFieldAttribute("한글명")]
		public string hname;
		/// <summary>
		/// 현재가
		/// </summary>
		[XAQueryFieldAttribute("현재가")]
		public long price;
		/// <summary>
		/// 전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("전일대비구분")]
		public char sign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[XAQueryFieldAttribute("전일대비")]
		public long change;
		/// <summary>
		/// 등락율
		/// </summary>
		[XAQueryFieldAttribute("등락율")]
		public float diff;
		/// <summary>
		/// 누적거래량
		/// </summary>
		[XAQueryFieldAttribute("누적거래량")]
		public long volume;
		/// <summary>
		/// 지정일
		/// </summary>
		[XAQueryFieldAttribute("지정일")]
		public string date;
		/// <summary>
		/// 해제일
		/// </summary>
		[XAQueryFieldAttribute("해제일")]
		public string edate;
		/// <summary>
		/// 종목코드
		/// </summary>
		[XAQueryFieldAttribute("종목코드")]
		public string shcode;

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
			/// 지정일
			/// </summary>
			public const string date = "date";
			/// <summary>
			/// 해제일
			/// </summary>
			public const string edate = "edate";
			/// <summary>
			/// 종목코드
			/// </summary>
			public const string shcode = "shcode";
		}

		public static string[] AllFields = new string[]
		{
			F.hname,
			F.price,
			F.sign,
			F.change,
			F.diff,
			F.volume,
			F.date,
			F.edate,
			F.shcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["hname"] = new XAQueryFieldInfo("char", hname, hname, "한글명", (decimal)20);
			dict["price"] = new XAQueryFieldInfo("long", price, price.ToString("d8"), "현재가", (decimal)8);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("long", change, change.ToString("d8"), "전일대비", (decimal)8);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "누적거래량", (decimal)12);
			dict["date"] = new XAQueryFieldInfo("char", date, date, "지정일", (decimal)8);
			dict["edate"] = new XAQueryFieldInfo("char", edate, edate, "해제일", (decimal)8);
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "종목코드", (decimal)6);

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

				case "date":
					this.date = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "edate":
					this.edate = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt1405OutBlock1[] ListFromQuery(XQt1405 query)
		{
			int count = query.GetBlockCount(XQt1405OutBlock1.BlockName);
			List<XQt1405OutBlock1> list = new List<XQt1405OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1405OutBlock1 block = new XQt1405OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.hname = query.GetFieldData(block.GetBlockName(), "hname", i).TrimEnd('?'); // char 20
					block.price = query.GetFieldData(block.GetBlockName(), "price", i).ParseLong("price"); // long 8
					block.sign = query.GetFieldData(block.GetBlockName(), "sign", i).FirstOrDefault(); // char 1
					block.change = query.GetFieldData(block.GetBlockName(), "change", i).ParseLong("change"); // long 8
					block.diff = query.GetFieldData(block.GetBlockName(), "diff", i).ParseFloat("diff"); // float 6.2
					block.volume = query.GetFieldData(block.GetBlockName(), "volume", i).ParseLong("volume"); // long 12
					block.date = query.GetFieldData(block.GetBlockName(), "date", i).TrimEnd('?'); // char 8
					block.edate = query.GetFieldData(block.GetBlockName(), "edate", i).TrimEnd('?'); // char 8
					block.shcode = query.GetFieldData(block.GetBlockName(), "shcode", i).TrimEnd('?'); // char 6

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
			if (price.ToString().Length > 8) return false; // long 8
			// sign char 1
			if (change.ToString().Length > 8) return false; // long 8
			// diff float 6.2
			if (volume.ToString().Length > 12) return false; // long 12
			if (date?.Length > 8) return false; // char 8
			if (edate?.Length > 8) return false; // char 8
			if (shcode?.Length > 6) return false; // char 6

			return true;
		}
	}

	public partial class XQt1405 : XingQuery
	{
		/// <summary>
		/// t1405
		/// </summary>
		public const string _typeName = "t1405";
		/// <summary>
		/// 투자경고/매매정지/정리매매조회(t1405)
		/// </summary>
		public const string _typeDesc = "투자경고/매매정지/정리매매조회(t1405)";
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
		/// t1405
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 투자경고/매매정지/정리매매조회(t1405)
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

		public XQt1405() : base("t1405") { }


		public bool SetFields(XQt1405InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "gubun", 0, block.gubun.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "jongchk", 0, block.jongchk.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "cts_shcode", 0, block.cts_shcode); // char 6

			return true;
		}

		public XQt1405OutBlock GetBlock()
		{
			XQt1405OutBlock instance = XQt1405OutBlock.FromQuery(this);
			return instance;

		}

		public XQt1405OutBlock1[] GetBlock1s()
		{
			XQt1405OutBlock1[] instance = XQt1405OutBlock1.ListFromQuery(this);
			return instance;

		}


	}

}
