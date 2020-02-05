using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1449InBlock : XingBlock
	{
		/// <summary>
		/// t1449InBlock
		/// </summary>
		public const string _blockName = "t1449InBlock";
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
		/// t1449InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1449InBlock
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
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("단축코드")]
		public string shcode;
		/// <summary>
		/// 일자구분
		/// </summary>
		[XAQueryFieldAttribute("일자구분")]
		public char dategb;

		public static class F
		{
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 일자구분
			/// </summary>
			public const string dategb = "dategb";
		}

		public static string[] AllFields = new string[]
		{
			F.shcode,
			F.dategb,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)6);
			dict["dategb"] = new XAQueryFieldInfo("char", dategb, dategb.ToString(), "일자구분", (decimal)1);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "dategb":
					this.dategb = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public bool VerifyData()
		{
			if (shcode?.Length > 6) return false; // char 6
			// dategb char 1

			return true;
		}
	}

	public partial class XQt1449OutBlock : XingBlock
	{
		/// <summary>
		/// t1449OutBlock
		/// </summary>
		public const string _blockName = "t1449OutBlock";
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
		/// t1449OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1449OutBlock
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
		/// 거래량
		/// </summary>
		[XAQueryFieldAttribute("거래량")]
		public long volume;
		/// <summary>
		/// 매수체결량
		/// </summary>
		[XAQueryFieldAttribute("매수체결량")]
		public long msvolume;
		/// <summary>
		/// 매도체결량
		/// </summary>
		[XAQueryFieldAttribute("매도체결량")]
		public long mdvolume;

		public static class F
		{
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
			/// 매수체결량
			/// </summary>
			public const string msvolume = "msvolume";
			/// <summary>
			/// 매도체결량
			/// </summary>
			public const string mdvolume = "mdvolume";
		}

		public static string[] AllFields = new string[]
		{
			F.price,
			F.sign,
			F.change,
			F.diff,
			F.volume,
			F.msvolume,
			F.mdvolume,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["price"] = new XAQueryFieldInfo("long", price, price.ToString("d8"), "현재가", (decimal)8);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("long", change, change.ToString("d8"), "전일대비", (decimal)8);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "거래량", (decimal)12);
			dict["msvolume"] = new XAQueryFieldInfo("long", msvolume, msvolume.ToString("d12"), "매수체결량", (decimal)12);
			dict["mdvolume"] = new XAQueryFieldInfo("long", mdvolume, mdvolume.ToString("d12"), "매도체결량", (decimal)12);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
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

				case "msvolume":
					this.msvolume = fieldInfo.FieldValue.ParseLong("msvolume");
				break;

				case "mdvolume":
					this.mdvolume = fieldInfo.FieldValue.ParseLong("mdvolume");
				break;


			}
		}

		public static XQt1449OutBlock FromQuery(XQt1449 query)
		{
			XQt1449OutBlock block = new XQt1449OutBlock();
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
				block.price = query.GetFieldData(block.GetBlockName(), "price", 0).ParseLong("price"); // long 8
				block.sign = query.GetFieldData(block.GetBlockName(), "sign", 0).FirstOrDefault(); // char 1
				block.change = query.GetFieldData(block.GetBlockName(), "change", 0).ParseLong("change"); // long 8
				block.diff = query.GetFieldData(block.GetBlockName(), "diff", 0).ParseFloat("diff"); // float 6.2
				block.volume = query.GetFieldData(block.GetBlockName(), "volume", 0).ParseLong("volume"); // long 12
				block.msvolume = query.GetFieldData(block.GetBlockName(), "msvolume", 0).ParseLong("msvolume"); // long 12
				block.mdvolume = query.GetFieldData(block.GetBlockName(), "mdvolume", 0).ParseLong("mdvolume"); // long 12

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (price.ToString().Length > 8) return false; // long 8
			// sign char 1
			if (change.ToString().Length > 8) return false; // long 8
			// diff float 6.2
			if (volume.ToString().Length > 12) return false; // long 12
			if (msvolume.ToString().Length > 12) return false; // long 12
			if (mdvolume.ToString().Length > 12) return false; // long 12

			return true;
		}
	}

	public partial class XQt1449OutBlock1 : XingBlock
	{
		/// <summary>
		/// t1449OutBlock1
		/// </summary>
		public const string _blockName = "t1449OutBlock1";
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
		/// t1449OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1449OutBlock1
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
		/// 체결가
		/// </summary>
		[XAQueryFieldAttribute("체결가")]
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
		public float tickdiff;
		/// <summary>
		/// 체결수량
		/// </summary>
		[XAQueryFieldAttribute("체결수량")]
		public long cvolume;
		/// <summary>
		/// 비중
		/// </summary>
		[XAQueryFieldAttribute("비중")]
		public float diff;
		/// <summary>
		/// 매도체결량
		/// </summary>
		[XAQueryFieldAttribute("매도체결량")]
		public long mdvolume;
		/// <summary>
		/// 매수체결량
		/// </summary>
		[XAQueryFieldAttribute("매수체결량")]
		public long msvolume;
		/// <summary>
		/// 매수비율
		/// </summary>
		[XAQueryFieldAttribute("매수비율")]
		public float msdiff;

		public static class F
		{
			/// <summary>
			/// 체결가
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
			public const string tickdiff = "tickdiff";
			/// <summary>
			/// 체결수량
			/// </summary>
			public const string cvolume = "cvolume";
			/// <summary>
			/// 비중
			/// </summary>
			public const string diff = "diff";
			/// <summary>
			/// 매도체결량
			/// </summary>
			public const string mdvolume = "mdvolume";
			/// <summary>
			/// 매수체결량
			/// </summary>
			public const string msvolume = "msvolume";
			/// <summary>
			/// 매수비율
			/// </summary>
			public const string msdiff = "msdiff";
		}

		public static string[] AllFields = new string[]
		{
			F.price,
			F.sign,
			F.change,
			F.tickdiff,
			F.cvolume,
			F.diff,
			F.mdvolume,
			F.msvolume,
			F.msdiff,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["price"] = new XAQueryFieldInfo("long", price, price.ToString("d8"), "체결가", (decimal)8);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("long", change, change.ToString("d8"), "전일대비", (decimal)8);
			dict["tickdiff"] = new XAQueryFieldInfo("float", tickdiff, tickdiff.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["cvolume"] = new XAQueryFieldInfo("long", cvolume, cvolume.ToString("d12"), "체결수량", (decimal)12);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "비중", (decimal)6.2);
			dict["mdvolume"] = new XAQueryFieldInfo("long", mdvolume, mdvolume.ToString("d12"), "매도체결량", (decimal)12);
			dict["msvolume"] = new XAQueryFieldInfo("long", msvolume, msvolume.ToString("d12"), "매수체결량", (decimal)12);
			dict["msdiff"] = new XAQueryFieldInfo("float", msdiff, msdiff.ToString("000000.00"), "매수비율", (decimal)6.2);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "price":
					this.price = fieldInfo.FieldValue.ParseLong("price");
				break;

				case "sign":
					this.sign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "change":
					this.change = fieldInfo.FieldValue.ParseLong("change");
				break;

				case "tickdiff":
					this.tickdiff = fieldInfo.FieldValue.ParseFloat("tickdiff");
				break;

				case "cvolume":
					this.cvolume = fieldInfo.FieldValue.ParseLong("cvolume");
				break;

				case "diff":
					this.diff = fieldInfo.FieldValue.ParseFloat("diff");
				break;

				case "mdvolume":
					this.mdvolume = fieldInfo.FieldValue.ParseLong("mdvolume");
				break;

				case "msvolume":
					this.msvolume = fieldInfo.FieldValue.ParseLong("msvolume");
				break;

				case "msdiff":
					this.msdiff = fieldInfo.FieldValue.ParseFloat("msdiff");
				break;


			}
		}

		public static XQt1449OutBlock1[] ListFromQuery(XQt1449 query)
		{
			int count = query.GetBlockCount(XQt1449OutBlock1.BlockName);
			List<XQt1449OutBlock1> list = new List<XQt1449OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1449OutBlock1 block = new XQt1449OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.price = query.GetFieldData(block.GetBlockName(), "price", i).ParseLong("price"); // long 8
					block.sign = query.GetFieldData(block.GetBlockName(), "sign", i).FirstOrDefault(); // char 1
					block.change = query.GetFieldData(block.GetBlockName(), "change", i).ParseLong("change"); // long 8
					block.tickdiff = query.GetFieldData(block.GetBlockName(), "tickdiff", i).ParseFloat("tickdiff"); // float 6.2
					block.cvolume = query.GetFieldData(block.GetBlockName(), "cvolume", i).ParseLong("cvolume"); // long 12
					block.diff = query.GetFieldData(block.GetBlockName(), "diff", i).ParseFloat("diff"); // float 6.2
					block.mdvolume = query.GetFieldData(block.GetBlockName(), "mdvolume", i).ParseLong("mdvolume"); // long 12
					block.msvolume = query.GetFieldData(block.GetBlockName(), "msvolume", i).ParseLong("msvolume"); // long 12
					block.msdiff = query.GetFieldData(block.GetBlockName(), "msdiff", i).ParseFloat("msdiff"); // float 6.2

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
			if (price.ToString().Length > 8) return false; // long 8
			// sign char 1
			if (change.ToString().Length > 8) return false; // long 8
			// tickdiff float 6.2
			if (cvolume.ToString().Length > 12) return false; // long 12
			// diff float 6.2
			if (mdvolume.ToString().Length > 12) return false; // long 12
			if (msvolume.ToString().Length > 12) return false; // long 12
			// msdiff float 6.2

			return true;
		}
	}

	public partial class XQt1449 : XingQuery
	{
		/// <summary>
		/// t1449
		/// </summary>
		public const string _typeName = "t1449";
		/// <summary>
		/// 가격대별매매비중조회(t1449)
		/// </summary>
		public const string _typeDesc = "가격대별매매비중조회(t1449)";
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
		/// t1449
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 가격대별매매비중조회(t1449)
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

		public XQt1449() : base("t1449") { }


		public static XQt1449OutBlock1[] Get(string shcode = default,char dategb = default)
		{
			using (XQt1449 instance = new XQt1449())
			{
				instance.SetFieldData(XQt1449InBlock.BlockName, XQt1449InBlock.F.shcode, 0, shcode); // char 6
				instance.SetFieldData(XQt1449InBlock.BlockName, XQt1449InBlock.F.dategb, 0, dategb.ToString()); // char 1

				if (instance.Request() < 0)
				{
					return null;
				}

				var outBlock = instance.GetBlock1s();
				return outBlock;
			}
		}

		public bool SetBlock(XQt1449InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "shcode", 0, block.shcode); // char 6
			_xaQuery.SetFieldData(block.GetBlockName(), "dategb", 0, block.dategb.ToString()); // char 1

			return true;
		}

		public XQt1449OutBlock GetBlock()
		{
			XQt1449OutBlock instance = XQt1449OutBlock.FromQuery(this);
			return instance;

		}

		public XQt1449OutBlock1[] GetBlock1s()
		{
			XQt1449OutBlock1[] instance = XQt1449OutBlock1.ListFromQuery(this);
			return instance;

		}


	}

}
