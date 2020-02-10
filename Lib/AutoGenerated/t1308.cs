using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1308InBlock : XingBlock
	{
		/// <summary>
		/// t1308InBlock
		/// </summary>
		public const string _blockName = "t1308InBlock";
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
		/// t1308InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1308InBlock
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
		[XAQueryFieldAttribute("단축코드", "6")]
		public string shcode;
		/// <summary>
		/// 시작시간
		/// </summary>
		[XAQueryFieldAttribute("시작시간", "4")]
		public string starttime;
		/// <summary>
		/// 종료시간
		/// </summary>
		[XAQueryFieldAttribute("종료시간", "4")]
		public string endtime;
		/// <summary>
		/// 분간격
		/// </summary>
		[XAQueryFieldAttribute("분간격", "2")]
		public string bun_term;

		public static class F
		{
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 시작시간
			/// </summary>
			public const string starttime = "starttime";
			/// <summary>
			/// 종료시간
			/// </summary>
			public const string endtime = "endtime";
			/// <summary>
			/// 분간격
			/// </summary>
			public const string bun_term = "bun_term";
		}

		public static string[] AllFields = new string[]
		{
			F.shcode,
			F.starttime,
			F.endtime,
			F.bun_term,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)6);
			dict["starttime"] = new XAQueryFieldInfo("char", starttime, starttime, "시작시간", (decimal)4);
			dict["endtime"] = new XAQueryFieldInfo("char", endtime, endtime, "종료시간", (decimal)4);
			dict["bun_term"] = new XAQueryFieldInfo("char", bun_term, bun_term, "분간격", (decimal)2);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "starttime":
					this.starttime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "endtime":
					this.endtime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "bun_term":
					this.bun_term = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (shcode?.Length > 6) return false; // char 6
			if (starttime?.Length > 4) return false; // char 4
			if (endtime?.Length > 4) return false; // char 4
			if (bun_term?.Length > 2) return false; // char 2

			return true;
		}
	}

	public partial class XQt1308OutBlock1 : XingBlock
	{
		/// <summary>
		/// t1308OutBlock1
		/// </summary>
		public const string _blockName = "t1308OutBlock1";
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
		/// t1308OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1308OutBlock1
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
		[XAQueryFieldAttribute("시간", "8")]
		public string chetime;
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
		/// 체결수량
		/// </summary>
		[XAQueryFieldAttribute("체결수량", "8")]
		public long cvolume;
		/// <summary>
		/// 체결강도(거래량)
		/// </summary>
		[XAQueryFieldAttribute("체결강도(거래량)", "8.2")]
		public float chdegvol;
		/// <summary>
		/// 체결강도(건수)
		/// </summary>
		[XAQueryFieldAttribute("체결강도(건수)", "8.2")]
		public float chdegcnt;
		/// <summary>
		/// 거래량
		/// </summary>
		[XAQueryFieldAttribute("거래량", "12")]
		public long volume;
		/// <summary>
		/// 매도체결수량
		/// </summary>
		[XAQueryFieldAttribute("매도체결수량", "12")]
		public long mdvolume;
		/// <summary>
		/// 매도체결건수
		/// </summary>
		[XAQueryFieldAttribute("매도체결건수", "8")]
		public long mdchecnt;
		/// <summary>
		/// 매수체결수량
		/// </summary>
		[XAQueryFieldAttribute("매수체결수량", "12")]
		public long msvolume;
		/// <summary>
		/// 매수체결건수
		/// </summary>
		[XAQueryFieldAttribute("매수체결건수", "8")]
		public long mschecnt;
		/// <summary>
		/// 시가
		/// </summary>
		[XAQueryFieldAttribute("시가", "8")]
		public long open;
		/// <summary>
		/// 고가
		/// </summary>
		[XAQueryFieldAttribute("고가", "8")]
		public long high;
		/// <summary>
		/// 저가
		/// </summary>
		[XAQueryFieldAttribute("저가", "8")]
		public long low;

		public static class F
		{
			/// <summary>
			/// 시간
			/// </summary>
			public const string chetime = "chetime";
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
			/// 체결수량
			/// </summary>
			public const string cvolume = "cvolume";
			/// <summary>
			/// 체결강도(거래량)
			/// </summary>
			public const string chdegvol = "chdegvol";
			/// <summary>
			/// 체결강도(건수)
			/// </summary>
			public const string chdegcnt = "chdegcnt";
			/// <summary>
			/// 거래량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// 매도체결수량
			/// </summary>
			public const string mdvolume = "mdvolume";
			/// <summary>
			/// 매도체결건수
			/// </summary>
			public const string mdchecnt = "mdchecnt";
			/// <summary>
			/// 매수체결수량
			/// </summary>
			public const string msvolume = "msvolume";
			/// <summary>
			/// 매수체결건수
			/// </summary>
			public const string mschecnt = "mschecnt";
			/// <summary>
			/// 시가
			/// </summary>
			public const string open = "open";
			/// <summary>
			/// 고가
			/// </summary>
			public const string high = "high";
			/// <summary>
			/// 저가
			/// </summary>
			public const string low = "low";
		}

		public static string[] AllFields = new string[]
		{
			F.chetime,
			F.price,
			F.sign,
			F.change,
			F.diff,
			F.cvolume,
			F.chdegvol,
			F.chdegcnt,
			F.volume,
			F.mdvolume,
			F.mdchecnt,
			F.msvolume,
			F.mschecnt,
			F.open,
			F.high,
			F.low,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["chetime"] = new XAQueryFieldInfo("char", chetime, chetime, "시간", (decimal)8);
			dict["price"] = new XAQueryFieldInfo("long", price, price.ToString("d8"), "현재가", (decimal)8);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("long", change, change.ToString("d8"), "전일대비", (decimal)8);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["cvolume"] = new XAQueryFieldInfo("long", cvolume, cvolume.ToString("d8"), "체결수량", (decimal)8);
			dict["chdegvol"] = new XAQueryFieldInfo("float", chdegvol, chdegvol.ToString("00000000.00"), "체결강도(거래량)", (decimal)8.2);
			dict["chdegcnt"] = new XAQueryFieldInfo("float", chdegcnt, chdegcnt.ToString("00000000.00"), "체결강도(건수)", (decimal)8.2);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "거래량", (decimal)12);
			dict["mdvolume"] = new XAQueryFieldInfo("long", mdvolume, mdvolume.ToString("d12"), "매도체결수량", (decimal)12);
			dict["mdchecnt"] = new XAQueryFieldInfo("long", mdchecnt, mdchecnt.ToString("d8"), "매도체결건수", (decimal)8);
			dict["msvolume"] = new XAQueryFieldInfo("long", msvolume, msvolume.ToString("d12"), "매수체결수량", (decimal)12);
			dict["mschecnt"] = new XAQueryFieldInfo("long", mschecnt, mschecnt.ToString("d8"), "매수체결건수", (decimal)8);
			dict["open"] = new XAQueryFieldInfo("long", open, open.ToString("d8"), "시가", (decimal)8);
			dict["high"] = new XAQueryFieldInfo("long", high, high.ToString("d8"), "고가", (decimal)8);
			dict["low"] = new XAQueryFieldInfo("long", low, low.ToString("d8"), "저가", (decimal)8);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "chetime":
					this.chetime = fieldInfo.FieldValue.TrimEnd('?');
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

				case "cvolume":
					this.cvolume = fieldInfo.FieldValue.ParseLong("cvolume");
				break;

				case "chdegvol":
					this.chdegvol = fieldInfo.FieldValue.ParseFloat("chdegvol");
				break;

				case "chdegcnt":
					this.chdegcnt = fieldInfo.FieldValue.ParseFloat("chdegcnt");
				break;

				case "volume":
					this.volume = fieldInfo.FieldValue.ParseLong("volume");
				break;

				case "mdvolume":
					this.mdvolume = fieldInfo.FieldValue.ParseLong("mdvolume");
				break;

				case "mdchecnt":
					this.mdchecnt = fieldInfo.FieldValue.ParseLong("mdchecnt");
				break;

				case "msvolume":
					this.msvolume = fieldInfo.FieldValue.ParseLong("msvolume");
				break;

				case "mschecnt":
					this.mschecnt = fieldInfo.FieldValue.ParseLong("mschecnt");
				break;

				case "open":
					this.open = fieldInfo.FieldValue.ParseLong("open");
				break;

				case "high":
					this.high = fieldInfo.FieldValue.ParseLong("high");
				break;

				case "low":
					this.low = fieldInfo.FieldValue.ParseLong("low");
				break;


			}
		}

		public static XQt1308OutBlock1[] ListFromQuery(XQt1308 query)
		{
			int count = query.GetBlockCount(XQt1308OutBlock1.BlockName);
			List<XQt1308OutBlock1> list = new List<XQt1308OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1308OutBlock1 block = new XQt1308OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.chetime = query.GetFieldData(block.GetBlockName(), "chetime", i).TrimEnd('?'); // char 8
					block.price = query.GetFieldData(block.GetBlockName(), "price", i).ParseLong("price"); // long 8
					block.sign = query.GetFieldData(block.GetBlockName(), "sign", i).FirstOrDefault(); // char 1
					block.change = query.GetFieldData(block.GetBlockName(), "change", i).ParseLong("change"); // long 8
					block.diff = query.GetFieldData(block.GetBlockName(), "diff", i).ParseFloat("diff"); // float 6.2
					block.cvolume = query.GetFieldData(block.GetBlockName(), "cvolume", i).ParseLong("cvolume"); // long 8
					block.chdegvol = query.GetFieldData(block.GetBlockName(), "chdegvol", i).ParseFloat("chdegvol"); // float 8.2
					block.chdegcnt = query.GetFieldData(block.GetBlockName(), "chdegcnt", i).ParseFloat("chdegcnt"); // float 8.2
					block.volume = query.GetFieldData(block.GetBlockName(), "volume", i).ParseLong("volume"); // long 12
					block.mdvolume = query.GetFieldData(block.GetBlockName(), "mdvolume", i).ParseLong("mdvolume"); // long 12
					block.mdchecnt = query.GetFieldData(block.GetBlockName(), "mdchecnt", i).ParseLong("mdchecnt"); // long 8
					block.msvolume = query.GetFieldData(block.GetBlockName(), "msvolume", i).ParseLong("msvolume"); // long 12
					block.mschecnt = query.GetFieldData(block.GetBlockName(), "mschecnt", i).ParseLong("mschecnt"); // long 8
					block.open = query.GetFieldData(block.GetBlockName(), "open", i).ParseLong("open"); // long 8
					block.high = query.GetFieldData(block.GetBlockName(), "high", i).ParseLong("high"); // long 8
					block.low = query.GetFieldData(block.GetBlockName(), "low", i).ParseLong("low"); // long 8

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
			if (chetime?.Length > 8) return false; // char 8
			if (price.ToString().Length > 8) return false; // long 8
			// sign char 1
			if (change.ToString().Length > 8) return false; // long 8
			// diff float 6.2
			if (cvolume.ToString().Length > 8) return false; // long 8
			// chdegvol float 8.2
			// chdegcnt float 8.2
			if (volume.ToString().Length > 12) return false; // long 12
			if (mdvolume.ToString().Length > 12) return false; // long 12
			if (mdchecnt.ToString().Length > 8) return false; // long 8
			if (msvolume.ToString().Length > 12) return false; // long 12
			if (mschecnt.ToString().Length > 8) return false; // long 8
			if (open.ToString().Length > 8) return false; // long 8
			if (high.ToString().Length > 8) return false; // long 8
			if (low.ToString().Length > 8) return false; // long 8

			return true;
		}
	}

	/// <summary>
	/// 주식시간대별체결조회챠트(t1308)
	/// </summary>
	public partial class XQt1308 : XingQuery
	{
		/// <summary>
		/// t1308
		/// </summary>
		public const string _typeName = "t1308";
		/// <summary>
		/// 주식시간대별체결조회챠트(t1308)
		/// </summary>
		public const string _typeDesc = "주식시간대별체결조회챠트(t1308)";
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
		/// t1308
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 주식시간대별체결조회챠트(t1308)
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
		/// 주식시간대별체결조회챠트(t1308)
		/// </summary>
		public XQt1308() : base("t1308") { }


		public static XQt1308OutBlock1[] Get(string shcode = default,string starttime = default,string endtime = default,string bun_term = default)
		{
			using (XQt1308 instance = new XQt1308())
			{
				instance.SetFieldData(XQt1308InBlock.BlockName, XQt1308InBlock.F.shcode, 0, shcode); // char 6
				instance.SetFieldData(XQt1308InBlock.BlockName, XQt1308InBlock.F.starttime, 0, starttime); // char 4
				instance.SetFieldData(XQt1308InBlock.BlockName, XQt1308InBlock.F.endtime, 0, endtime); // char 4
				instance.SetFieldData(XQt1308InBlock.BlockName, XQt1308InBlock.F.bun_term, 0, bun_term); // char 2

				if (instance.Request() < 0)
				{
					return null;
				}

				var outBlock = instance.GetBlock1s();
				return outBlock;
			}
		}

		public bool SetBlock(XQt1308InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "shcode", 0, block.shcode); // char 6
			_xaQuery.SetFieldData(block.GetBlockName(), "starttime", 0, block.starttime); // char 4
			_xaQuery.SetFieldData(block.GetBlockName(), "endtime", 0, block.endtime); // char 4
			_xaQuery.SetFieldData(block.GetBlockName(), "bun_term", 0, block.bun_term); // char 2

			return true;
		}

		public XQt1308OutBlock1[] GetBlock1s()
		{
			XQt1308OutBlock1[] instance = XQt1308OutBlock1.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt1308OutBlock1),

		};

	}

}
