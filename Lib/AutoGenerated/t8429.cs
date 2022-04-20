﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt8429InBlock : XingBlock
	{
		/// <summary>
		/// t8429InBlock
		/// </summary>
		public const string _blockName = "t8429InBlock";
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
		/// t8429InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t8429InBlock
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
		[XAQueryFieldAttribute("focode", "단축코드", "char", "8")]
		public string focode;
		/// <summary>
		/// 챠트구분
		/// </summary>
		[XAQueryFieldAttribute("cgubun", "챠트구분", "char", "1")]
		public char cgubun;
		/// <summary>
		/// 분구분
		/// </summary>
		[XAQueryFieldAttribute("bgubun", "분구분", "int", "3")]
		public int bgubun;
		/// <summary>
		/// 조회건수
		/// </summary>
		[XAQueryFieldAttribute("cnt", "조회건수", "int", "3")]
		public int cnt;

		public static class F
		{
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string focode = "focode";
			/// <summary>
			/// 챠트구분
			/// </summary>
			public const string cgubun = "cgubun";
			/// <summary>
			/// 분구분
			/// </summary>
			public const string bgubun = "bgubun";
			/// <summary>
			/// 조회건수
			/// </summary>
			public const string cnt = "cnt";
		}

		public static string[] AllFields = new string[]
		{
			F.focode,
			F.cgubun,
			F.bgubun,
			F.cnt,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["focode"] = new XAQueryFieldInfo("char", focode, focode, "단축코드", (decimal)8);
			dict["cgubun"] = new XAQueryFieldInfo("char", cgubun, cgubun.ToString(), "챠트구분", (decimal)1);
			dict["bgubun"] = new XAQueryFieldInfo("int", bgubun, bgubun.ToString("d3"), "분구분", (decimal)3);
			dict["cnt"] = new XAQueryFieldInfo("int", cnt, cnt.ToString("d3"), "조회건수", (decimal)3);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "focode":
					this.focode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cgubun":
					this.cgubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "bgubun":
					this.bgubun = fieldInfo.FieldValue.ParseInt("bgubun");
				break;

				case "cnt":
					this.cnt = fieldInfo.FieldValue.ParseInt("cnt");
				break;


			}
		}

		public bool VerifyData()
		{
			if (focode?.Length > 8) return false; // char 8
			// cgubun char 1
			// bgubun int 3
			// cnt int 3

			return true;
		}

		public void CopyTo(XQt8429InBlock block)
		{
			block.focode = this.focode;
			block.cgubun = this.cgubun;
			block.bgubun = this.bgubun;
			block.cnt = this.cnt;

		}
	}

	public partial class XQt8429OutBlock1 : XingBlock
	{
		/// <summary>
		/// t8429OutBlock1
		/// </summary>
		public const string _blockName = "t8429OutBlock1";
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
		/// t8429OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t8429OutBlock1
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
		[XAQueryFieldAttribute("chetime", "시간", "char", "10")]
		public string chetime;
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
		/// 시가
		/// </summary>
		[XAQueryFieldAttribute("open", "시가", "float", "6.2")]
		public float open;
		/// <summary>
		/// 고가
		/// </summary>
		[XAQueryFieldAttribute("high", "고가", "float", "6.2")]
		public float high;
		/// <summary>
		/// 저가
		/// </summary>
		[XAQueryFieldAttribute("low", "저가", "float", "6.2")]
		public float low;
		/// <summary>
		/// 거래량
		/// </summary>
		[XAQueryFieldAttribute("volume", "거래량", "double", "12.0")]
		public double volume;
		/// <summary>
		/// 체결수량
		/// </summary>
		[XAQueryFieldAttribute("cvolume", "체결수량", "long", "8")]
		public long cvolume;
		/// <summary>
		/// 매수순간체결건수
		/// </summary>
		[XAQueryFieldAttribute("s_mschecnt", "매수순간체결건수", "long", "8")]
		public long s_mschecnt;
		/// <summary>
		/// 매도순간체결건수
		/// </summary>
		[XAQueryFieldAttribute("s_mdchecnt", "매도순간체결건수", "long", "8")]
		public long s_mdchecnt;
		/// <summary>
		/// 순매수순간체결건수
		/// </summary>
		[XAQueryFieldAttribute("ss_mschecnt", "순매수순간체결건수", "long", "8")]
		public long ss_mschecnt;
		/// <summary>
		/// 매수순간체결량
		/// </summary>
		[XAQueryFieldAttribute("s_mschevol", "매수순간체결량", "double", "12.0")]
		public double s_mschevol;
		/// <summary>
		/// 매도순간체결량
		/// </summary>
		[XAQueryFieldAttribute("s_mdchevol", "매도순간체결량", "double", "12.0")]
		public double s_mdchevol;
		/// <summary>
		/// 순매수순간체결량
		/// </summary>
		[XAQueryFieldAttribute("ss_mschevol", "순매수순간체결량", "double", "12.0")]
		public double ss_mschevol;
		/// <summary>
		/// 체결강도(거래량)
		/// </summary>
		[XAQueryFieldAttribute("chdegvol", "체결강도(거래량)", "float", "8.2")]
		public float chdegvol;
		/// <summary>
		/// 체결강도(건수)
		/// </summary>
		[XAQueryFieldAttribute("chdegcnt", "체결강도(건수)", "float", "8.2")]
		public float chdegcnt;

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
			/// <summary>
			/// 거래량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// 체결수량
			/// </summary>
			public const string cvolume = "cvolume";
			/// <summary>
			/// 매수순간체결건수
			/// </summary>
			public const string s_mschecnt = "s_mschecnt";
			/// <summary>
			/// 매도순간체결건수
			/// </summary>
			public const string s_mdchecnt = "s_mdchecnt";
			/// <summary>
			/// 순매수순간체결건수
			/// </summary>
			public const string ss_mschecnt = "ss_mschecnt";
			/// <summary>
			/// 매수순간체결량
			/// </summary>
			public const string s_mschevol = "s_mschevol";
			/// <summary>
			/// 매도순간체결량
			/// </summary>
			public const string s_mdchevol = "s_mdchevol";
			/// <summary>
			/// 순매수순간체결량
			/// </summary>
			public const string ss_mschevol = "ss_mschevol";
			/// <summary>
			/// 체결강도(거래량)
			/// </summary>
			public const string chdegvol = "chdegvol";
			/// <summary>
			/// 체결강도(건수)
			/// </summary>
			public const string chdegcnt = "chdegcnt";
		}

		public static string[] AllFields = new string[]
		{
			F.chetime,
			F.price,
			F.sign,
			F.change,
			F.open,
			F.high,
			F.low,
			F.volume,
			F.cvolume,
			F.s_mschecnt,
			F.s_mdchecnt,
			F.ss_mschecnt,
			F.s_mschevol,
			F.s_mdchevol,
			F.ss_mschevol,
			F.chdegvol,
			F.chdegcnt,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["chetime"] = new XAQueryFieldInfo("char", chetime, chetime, "시간", (decimal)10);
			dict["price"] = new XAQueryFieldInfo("float", price, price.ToString("000000.00"), "현재가", (decimal)6.2);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("float", change, change.ToString("000000.00"), "전일대비", (decimal)6.2);
			dict["open"] = new XAQueryFieldInfo("float", open, open.ToString("000000.00"), "시가", (decimal)6.2);
			dict["high"] = new XAQueryFieldInfo("float", high, high.ToString("000000.00"), "고가", (decimal)6.2);
			dict["low"] = new XAQueryFieldInfo("float", low, low.ToString("000000.00"), "저가", (decimal)6.2);
			dict["volume"] = new XAQueryFieldInfo("double", volume, volume.ToString("000000000000."), "거래량", (decimal)12.0);
			dict["cvolume"] = new XAQueryFieldInfo("long", cvolume, cvolume.ToString("d8"), "체결수량", (decimal)8);
			dict["s_mschecnt"] = new XAQueryFieldInfo("long", s_mschecnt, s_mschecnt.ToString("d8"), "매수순간체결건수", (decimal)8);
			dict["s_mdchecnt"] = new XAQueryFieldInfo("long", s_mdchecnt, s_mdchecnt.ToString("d8"), "매도순간체결건수", (decimal)8);
			dict["ss_mschecnt"] = new XAQueryFieldInfo("long", ss_mschecnt, ss_mschecnt.ToString("d8"), "순매수순간체결건수", (decimal)8);
			dict["s_mschevol"] = new XAQueryFieldInfo("double", s_mschevol, s_mschevol.ToString("000000000000."), "매수순간체결량", (decimal)12.0);
			dict["s_mdchevol"] = new XAQueryFieldInfo("double", s_mdchevol, s_mdchevol.ToString("000000000000."), "매도순간체결량", (decimal)12.0);
			dict["ss_mschevol"] = new XAQueryFieldInfo("double", ss_mschevol, ss_mschevol.ToString("000000000000."), "순매수순간체결량", (decimal)12.0);
			dict["chdegvol"] = new XAQueryFieldInfo("float", chdegvol, chdegvol.ToString("00000000.00"), "체결강도(거래량)", (decimal)8.2);
			dict["chdegcnt"] = new XAQueryFieldInfo("float", chdegcnt, chdegcnt.ToString("00000000.00"), "체결강도(건수)", (decimal)8.2);

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
					this.price = fieldInfo.FieldValue.ParseFloat("price");
				break;

				case "sign":
					this.sign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "change":
					this.change = fieldInfo.FieldValue.ParseFloat("change");
				break;

				case "open":
					this.open = fieldInfo.FieldValue.ParseFloat("open");
				break;

				case "high":
					this.high = fieldInfo.FieldValue.ParseFloat("high");
				break;

				case "low":
					this.low = fieldInfo.FieldValue.ParseFloat("low");
				break;

				case "volume":
					this.volume = fieldInfo.FieldValue.ParseDouble("volume");
				break;

				case "cvolume":
					this.cvolume = fieldInfo.FieldValue.ParseLong("cvolume");
				break;

				case "s_mschecnt":
					this.s_mschecnt = fieldInfo.FieldValue.ParseLong("s_mschecnt");
				break;

				case "s_mdchecnt":
					this.s_mdchecnt = fieldInfo.FieldValue.ParseLong("s_mdchecnt");
				break;

				case "ss_mschecnt":
					this.ss_mschecnt = fieldInfo.FieldValue.ParseLong("ss_mschecnt");
				break;

				case "s_mschevol":
					this.s_mschevol = fieldInfo.FieldValue.ParseDouble("s_mschevol");
				break;

				case "s_mdchevol":
					this.s_mdchevol = fieldInfo.FieldValue.ParseDouble("s_mdchevol");
				break;

				case "ss_mschevol":
					this.ss_mschevol = fieldInfo.FieldValue.ParseDouble("ss_mschevol");
				break;

				case "chdegvol":
					this.chdegvol = fieldInfo.FieldValue.ParseFloat("chdegvol");
				break;

				case "chdegcnt":
					this.chdegcnt = fieldInfo.FieldValue.ParseFloat("chdegcnt");
				break;


			}
		}

		public static XQt8429OutBlock1[] ListFromQuery(XQt8429 query)
		{
			int count = query.GetBlockCount(XQt8429OutBlock1.BlockName);
			List<XQt8429OutBlock1> list = new List<XQt8429OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt8429OutBlock1 block = new XQt8429OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.chetime = query.GetFieldData(block.GetBlockName(), "chetime", i).TrimEnd('?'); // char 10
					block.price = query.GetFieldData(block.GetBlockName(), "price", i).ParseFloat("price"); // float 6.2
					block.sign = query.GetFieldData(block.GetBlockName(), "sign", i).FirstOrDefault(); // char 1
					block.change = query.GetFieldData(block.GetBlockName(), "change", i).ParseFloat("change"); // float 6.2
					block.open = query.GetFieldData(block.GetBlockName(), "open", i).ParseFloat("open"); // float 6.2
					block.high = query.GetFieldData(block.GetBlockName(), "high", i).ParseFloat("high"); // float 6.2
					block.low = query.GetFieldData(block.GetBlockName(), "low", i).ParseFloat("low"); // float 6.2
					block.volume = query.GetFieldData(block.GetBlockName(), "volume", i).ParseDouble("volume"); // double 12.0
					block.cvolume = query.GetFieldData(block.GetBlockName(), "cvolume", i).ParseLong("cvolume"); // long 8
					block.s_mschecnt = query.GetFieldData(block.GetBlockName(), "s_mschecnt", i).ParseLong("s_mschecnt"); // long 8
					block.s_mdchecnt = query.GetFieldData(block.GetBlockName(), "s_mdchecnt", i).ParseLong("s_mdchecnt"); // long 8
					block.ss_mschecnt = query.GetFieldData(block.GetBlockName(), "ss_mschecnt", i).ParseLong("ss_mschecnt"); // long 8
					block.s_mschevol = query.GetFieldData(block.GetBlockName(), "s_mschevol", i).ParseDouble("s_mschevol"); // double 12.0
					block.s_mdchevol = query.GetFieldData(block.GetBlockName(), "s_mdchevol", i).ParseDouble("s_mdchevol"); // double 12.0
					block.ss_mschevol = query.GetFieldData(block.GetBlockName(), "ss_mschevol", i).ParseDouble("ss_mschevol"); // double 12.0
					block.chdegvol = query.GetFieldData(block.GetBlockName(), "chdegvol", i).ParseFloat("chdegvol"); // float 8.2
					block.chdegcnt = query.GetFieldData(block.GetBlockName(), "chdegcnt", i).ParseFloat("chdegcnt"); // float 8.2

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
			if (chetime?.Length > 10) return false; // char 10
			// price float 6.2
			// sign char 1
			// change float 6.2
			// open float 6.2
			// high float 6.2
			// low float 6.2
			// volume double 12.0
			if (cvolume.ToString().Length > 8) return false; // long 8
			if (s_mschecnt.ToString().Length > 8) return false; // long 8
			if (s_mdchecnt.ToString().Length > 8) return false; // long 8
			if (ss_mschecnt.ToString().Length > 8) return false; // long 8
			// s_mschevol double 12.0
			// s_mdchevol double 12.0
			// ss_mschevol double 12.0
			// chdegvol float 8.2
			// chdegcnt float 8.2

			return true;
		}

		public void CopyTo(XQt8429OutBlock1 block)
		{
			block.chetime = this.chetime;
			block.price = this.price;
			block.sign = this.sign;
			block.change = this.change;
			block.open = this.open;
			block.high = this.high;
			block.low = this.low;
			block.volume = this.volume;
			block.cvolume = this.cvolume;
			block.s_mschecnt = this.s_mschecnt;
			block.s_mdchecnt = this.s_mdchecnt;
			block.ss_mschecnt = this.ss_mschecnt;
			block.s_mschevol = this.s_mschevol;
			block.s_mdchevol = this.s_mdchevol;
			block.ss_mschevol = this.ss_mschevol;
			block.chdegvol = this.chdegvol;
			block.chdegcnt = this.chdegcnt;

		}
	}

	/// <summary>
	/// EUREX야간옵션선물틱분별체결조회챠트(t8429)
	/// </summary>
	public partial class XQt8429 : XingQuery
	{
		/// <summary>
		/// t8429
		/// </summary>
		public const string _typeName = "t8429";
		/// <summary>
		/// EUREX야간옵션선물틱분별체결조회챠트(t8429)
		/// </summary>
		public const string _typeDesc = "EUREX야간옵션선물틱분별체결조회챠트(t8429)";
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
		/// t8429
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// EUREX야간옵션선물틱분별체결조회챠트(t8429)
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
		/// EUREX야간옵션선물틱분별체결조회챠트(t8429)
		/// </summary>
		public XQt8429() : base("t8429") { }


		public static XQt8429OutBlock1[] Get(string focode = default,char cgubun = default,int bgubun = default,int cnt = default)
		{
			using (XQt8429 instance = new XQt8429())
			{
				instance.SetFieldData(XQt8429InBlock.BlockName, XQt8429InBlock.F.focode, 0, focode); // char 8
				instance.SetFieldData(XQt8429InBlock.BlockName, XQt8429InBlock.F.cgubun, 0, cgubun.ToString()); // char 1
				instance.SetFieldData(XQt8429InBlock.BlockName, XQt8429InBlock.F.bgubun, 0, bgubun.ToString("d3")); // int 3
				instance.SetFieldData(XQt8429InBlock.BlockName, XQt8429InBlock.F.cnt, 0, cnt.ToString("d3")); // int 3

				if (instance.Request() < 0)
				{
					return null;
				}

				var outBlock = instance.GetBlock1s();
				return outBlock;
			}
		}

		public static XQt8429OutBlock1[] ReadFromDB(string tableNamePostfix = null /*, string focode = default,char cgubun = default,int bgubun = default,int cnt = default */)
		{
			using (XQt8429 instance = new XQt8429())
			{

				string tableName = (tableNamePostfix == null) ? "XQt8429OutBlock1" : $"XQt8429OutBlock1_{tableNamePostfix}";
				QueryOption qo = new QueryOption(tableName);
				// if (focode != default) qo.Add("focode", focode);
				// if (cgubun != default) qo.Add("cgubun", cgubun);
				// if (bgubun != default) qo.Add("bgubun", bgubun);
				// if (cnt != default) qo.Add("cnt", cnt);


				var outBlock = instance.SelectMany<XQt8429OutBlock1>(qo);
				return outBlock;
			}
		}

		public bool SetBlock(XQt8429InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "focode", 0, block.focode); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "cgubun", 0, block.cgubun.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "bgubun", 0, block.bgubun.ToString("d3")); // int 3
			_xaQuery.SetFieldData(block.GetBlockName(), "cnt", 0, block.cnt.ToString("d3")); // int 3

			return true;
		}

		public XQt8429OutBlock1[] GetBlock1s()
		{
			XQt8429OutBlock1[] instance = XQt8429OutBlock1.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt8429OutBlock1),

		};

	}

}
