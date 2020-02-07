using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1636InBlock : XingBlock
	{
		/// <summary>
		/// t1636InBlock
		/// </summary>
		public const string _blockName = "t1636InBlock";
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
		/// t1636InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1636InBlock
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
		/// 금액수량구분
		/// </summary>
		[XAQueryFieldAttribute("금액수량구분")]
		public char gubun1;
		/// <summary>
		/// 정렬기준
		/// </summary>
		[XAQueryFieldAttribute("정렬기준")]
		public char gubun2;
		/// <summary>
		/// 종목코드
		/// </summary>
		[XAQueryFieldAttribute("종목코드")]
		public string shcode;
		/// <summary>
		/// IDXCTS
		/// </summary>
		[XAQueryFieldAttribute("IDXCTS")]
		public long cts_idx;

		public static class F
		{
			/// <summary>
			/// 구분
			/// </summary>
			public const string gubun = "gubun";
			/// <summary>
			/// 금액수량구분
			/// </summary>
			public const string gubun1 = "gubun1";
			/// <summary>
			/// 정렬기준
			/// </summary>
			public const string gubun2 = "gubun2";
			/// <summary>
			/// 종목코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// IDXCTS
			/// </summary>
			public const string cts_idx = "cts_idx";
		}

		public static string[] AllFields = new string[]
		{
			F.gubun,
			F.gubun1,
			F.gubun2,
			F.shcode,
			F.cts_idx,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["gubun"] = new XAQueryFieldInfo("char", gubun, gubun.ToString(), "구분", (decimal)1);
			dict["gubun1"] = new XAQueryFieldInfo("char", gubun1, gubun1.ToString(), "금액수량구분", (decimal)1);
			dict["gubun2"] = new XAQueryFieldInfo("char", gubun2, gubun2.ToString(), "정렬기준", (decimal)1);
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "종목코드", (decimal)6);
			dict["cts_idx"] = new XAQueryFieldInfo("long", cts_idx, cts_idx.ToString("d4"), "IDXCTS", (decimal)4);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "gubun":
					this.gubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "gubun1":
					this.gubun1 = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "gubun2":
					this.gubun2 = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cts_idx":
					this.cts_idx = fieldInfo.FieldValue.ParseLong("cts_idx");
				break;


			}
		}

		public bool VerifyData()
		{
			// gubun char 1
			// gubun1 char 1
			// gubun2 char 1
			if (shcode?.Length > 6) return false; // char 6
			if (cts_idx.ToString().Length > 4) return false; // long 4

			return true;
		}
	}

	public partial class XQt1636OutBlock : XingBlock
	{
		/// <summary>
		/// t1636OutBlock
		/// </summary>
		public const string _blockName = "t1636OutBlock";
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
		/// t1636OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1636OutBlock
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
		/// IDXCTS
		/// </summary>
		[XAQueryFieldAttribute("IDXCTS")]
		public long cts_idx;

		public static class F
		{
			/// <summary>
			/// IDXCTS
			/// </summary>
			public const string cts_idx = "cts_idx";
		}

		public static string[] AllFields = new string[]
		{
			F.cts_idx,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["cts_idx"] = new XAQueryFieldInfo("long", cts_idx, cts_idx.ToString("d4"), "IDXCTS", (decimal)4);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "cts_idx":
					this.cts_idx = fieldInfo.FieldValue.ParseLong("cts_idx");
				break;


			}
		}

		public static XQt1636OutBlock FromQuery(XQt1636 query)
		{
			XQt1636OutBlock block = new XQt1636OutBlock();
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
				block.cts_idx = query.GetFieldData(block.GetBlockName(), "cts_idx", 0).ParseLong("cts_idx"); // long 4

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (cts_idx.ToString().Length > 4) return false; // long 4

			return true;
		}
	}

	public partial class XQt1636OutBlock1 : XingBlock
	{
		/// <summary>
		/// t1636OutBlock1
		/// </summary>
		public const string _blockName = "t1636OutBlock1";
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
		/// t1636OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1636OutBlock1
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
		/// 순위
		/// </summary>
		[XAQueryFieldAttribute("순위")]
		public long rank;
		/// <summary>
		/// 종목명
		/// </summary>
		[XAQueryFieldAttribute("종목명")]
		public string hname;
		/// <summary>
		/// 현재가
		/// </summary>
		[XAQueryFieldAttribute("현재가")]
		public long price;
		/// <summary>
		/// 대비구분
		/// </summary>
		[XAQueryFieldAttribute("대비구분")]
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
		/// 순매수금액
		/// </summary>
		[XAQueryFieldAttribute("순매수금액")]
		public long svalue;
		/// <summary>
		/// 매도금액
		/// </summary>
		[XAQueryFieldAttribute("매도금액")]
		public long offervalue;
		/// <summary>
		/// 매수금액
		/// </summary>
		[XAQueryFieldAttribute("매수금액")]
		public long stksvalue;
		/// <summary>
		/// 순매수수량
		/// </summary>
		[XAQueryFieldAttribute("순매수수량")]
		public long svolume;
		/// <summary>
		/// 매도수량
		/// </summary>
		[XAQueryFieldAttribute("매도수량")]
		public long offervolume;
		/// <summary>
		/// 매수수량
		/// </summary>
		[XAQueryFieldAttribute("매수수량")]
		public long stksvolume;
		/// <summary>
		/// 시가총액
		/// </summary>
		[XAQueryFieldAttribute("시가총액")]
		public long sgta;
		/// <summary>
		/// 비중
		/// </summary>
		[XAQueryFieldAttribute("비중")]
		public float rate;
		/// <summary>
		/// 종목코드
		/// </summary>
		[XAQueryFieldAttribute("종목코드")]
		public string shcode;

		public static class F
		{
			/// <summary>
			/// 순위
			/// </summary>
			public const string rank = "rank";
			/// <summary>
			/// 종목명
			/// </summary>
			public const string hname = "hname";
			/// <summary>
			/// 현재가
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
			/// 순매수금액
			/// </summary>
			public const string svalue = "svalue";
			/// <summary>
			/// 매도금액
			/// </summary>
			public const string offervalue = "offervalue";
			/// <summary>
			/// 매수금액
			/// </summary>
			public const string stksvalue = "stksvalue";
			/// <summary>
			/// 순매수수량
			/// </summary>
			public const string svolume = "svolume";
			/// <summary>
			/// 매도수량
			/// </summary>
			public const string offervolume = "offervolume";
			/// <summary>
			/// 매수수량
			/// </summary>
			public const string stksvolume = "stksvolume";
			/// <summary>
			/// 시가총액
			/// </summary>
			public const string sgta = "sgta";
			/// <summary>
			/// 비중
			/// </summary>
			public const string rate = "rate";
			/// <summary>
			/// 종목코드
			/// </summary>
			public const string shcode = "shcode";
		}

		public static string[] AllFields = new string[]
		{
			F.rank,
			F.hname,
			F.price,
			F.sign,
			F.change,
			F.diff,
			F.volume,
			F.svalue,
			F.offervalue,
			F.stksvalue,
			F.svolume,
			F.offervolume,
			F.stksvolume,
			F.sgta,
			F.rate,
			F.shcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["rank"] = new XAQueryFieldInfo("long", rank, rank.ToString("d8"), "순위", (decimal)8);
			dict["hname"] = new XAQueryFieldInfo("char", hname, hname, "종목명", (decimal)20);
			dict["price"] = new XAQueryFieldInfo("long", price, price.ToString("d8"), "현재가", (decimal)8);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("long", change, change.ToString("d8"), "대비", (decimal)8);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "거래량", (decimal)12);
			dict["svalue"] = new XAQueryFieldInfo("long", svalue, svalue.ToString("d12"), "순매수금액", (decimal)12);
			dict["offervalue"] = new XAQueryFieldInfo("long", offervalue, offervalue.ToString("d12"), "매도금액", (decimal)12);
			dict["stksvalue"] = new XAQueryFieldInfo("long", stksvalue, stksvalue.ToString("d12"), "매수금액", (decimal)12);
			dict["svolume"] = new XAQueryFieldInfo("long", svolume, svolume.ToString("d12"), "순매수수량", (decimal)12);
			dict["offervolume"] = new XAQueryFieldInfo("long", offervolume, offervolume.ToString("d12"), "매도수량", (decimal)12);
			dict["stksvolume"] = new XAQueryFieldInfo("long", stksvolume, stksvolume.ToString("d12"), "매수수량", (decimal)12);
			dict["sgta"] = new XAQueryFieldInfo("long", sgta, sgta.ToString("d15"), "시가총액", (decimal)15);
			dict["rate"] = new XAQueryFieldInfo("float", rate, rate.ToString("000000.00"), "비중", (decimal)6.2);
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "종목코드", (decimal)6);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "rank":
					this.rank = fieldInfo.FieldValue.ParseLong("rank");
				break;

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

				case "svalue":
					this.svalue = fieldInfo.FieldValue.ParseLong("svalue");
				break;

				case "offervalue":
					this.offervalue = fieldInfo.FieldValue.ParseLong("offervalue");
				break;

				case "stksvalue":
					this.stksvalue = fieldInfo.FieldValue.ParseLong("stksvalue");
				break;

				case "svolume":
					this.svolume = fieldInfo.FieldValue.ParseLong("svolume");
				break;

				case "offervolume":
					this.offervolume = fieldInfo.FieldValue.ParseLong("offervolume");
				break;

				case "stksvolume":
					this.stksvolume = fieldInfo.FieldValue.ParseLong("stksvolume");
				break;

				case "sgta":
					this.sgta = fieldInfo.FieldValue.ParseLong("sgta");
				break;

				case "rate":
					this.rate = fieldInfo.FieldValue.ParseFloat("rate");
				break;

				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt1636OutBlock1[] ListFromQuery(XQt1636 query)
		{
			int count = query.GetBlockCount(XQt1636OutBlock1.BlockName);
			List<XQt1636OutBlock1> list = new List<XQt1636OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1636OutBlock1 block = new XQt1636OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.rank = query.GetFieldData(block.GetBlockName(), "rank", i).ParseLong("rank"); // long 8
					block.hname = query.GetFieldData(block.GetBlockName(), "hname", i).TrimEnd('?'); // char 20
					block.price = query.GetFieldData(block.GetBlockName(), "price", i).ParseLong("price"); // long 8
					block.sign = query.GetFieldData(block.GetBlockName(), "sign", i).FirstOrDefault(); // char 1
					block.change = query.GetFieldData(block.GetBlockName(), "change", i).ParseLong("change"); // long 8
					block.diff = query.GetFieldData(block.GetBlockName(), "diff", i).ParseFloat("diff"); // float 6.2
					block.volume = query.GetFieldData(block.GetBlockName(), "volume", i).ParseLong("volume"); // long 12
					block.svalue = query.GetFieldData(block.GetBlockName(), "svalue", i).ParseLong("svalue"); // long 12
					block.offervalue = query.GetFieldData(block.GetBlockName(), "offervalue", i).ParseLong("offervalue"); // long 12
					block.stksvalue = query.GetFieldData(block.GetBlockName(), "stksvalue", i).ParseLong("stksvalue"); // long 12
					block.svolume = query.GetFieldData(block.GetBlockName(), "svolume", i).ParseLong("svolume"); // long 12
					block.offervolume = query.GetFieldData(block.GetBlockName(), "offervolume", i).ParseLong("offervolume"); // long 12
					block.stksvolume = query.GetFieldData(block.GetBlockName(), "stksvolume", i).ParseLong("stksvolume"); // long 12
					block.sgta = query.GetFieldData(block.GetBlockName(), "sgta", i).ParseLong("sgta"); // long 15
					block.rate = query.GetFieldData(block.GetBlockName(), "rate", i).ParseFloat("rate"); // float 6.2
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
			if (rank.ToString().Length > 8) return false; // long 8
			if (hname?.Length > 20) return false; // char 20
			if (price.ToString().Length > 8) return false; // long 8
			// sign char 1
			if (change.ToString().Length > 8) return false; // long 8
			// diff float 6.2
			if (volume.ToString().Length > 12) return false; // long 12
			if (svalue.ToString().Length > 12) return false; // long 12
			if (offervalue.ToString().Length > 12) return false; // long 12
			if (stksvalue.ToString().Length > 12) return false; // long 12
			if (svolume.ToString().Length > 12) return false; // long 12
			if (offervolume.ToString().Length > 12) return false; // long 12
			if (stksvolume.ToString().Length > 12) return false; // long 12
			if (sgta.ToString().Length > 15) return false; // long 15
			// rate float 6.2
			if (shcode?.Length > 6) return false; // char 6

			return true;
		}
	}

	/// <summary>
	/// 종목별프로그램매매동향(t1636)
	/// </summary>
	public partial class XQt1636 : XingQuery
	{
		/// <summary>
		/// t1636
		/// </summary>
		public const string _typeName = "t1636";
		/// <summary>
		/// 종목별프로그램매매동향(t1636)
		/// </summary>
		public const string _typeDesc = "종목별프로그램매매동향(t1636)";
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
		/// t1636
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 종목별프로그램매매동향(t1636)
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
		/// 종목별프로그램매매동향(t1636)
		/// </summary>
		public XQt1636() : base("t1636") { }


		public class XQAllOutBlocks
		{
			public XQt1636OutBlock OutBlock { get; internal set; }
			public XQt1636OutBlock1[] OutBlock1 { get; internal set; }
		}

		public static XQAllOutBlocks Get(char gubun = default,char gubun1 = default,char gubun2 = default,string shcode = default,long cts_idx = default)
		{
			using (XQt1636 instance = new XQt1636())
			{
				instance.SetFieldData(XQt1636InBlock.BlockName, XQt1636InBlock.F.gubun, 0, gubun.ToString()); // char 1
				instance.SetFieldData(XQt1636InBlock.BlockName, XQt1636InBlock.F.gubun1, 0, gubun1.ToString()); // char 1
				instance.SetFieldData(XQt1636InBlock.BlockName, XQt1636InBlock.F.gubun2, 0, gubun2.ToString()); // char 1
				instance.SetFieldData(XQt1636InBlock.BlockName, XQt1636InBlock.F.shcode, 0, shcode); // char 6
				instance.SetFieldData(XQt1636InBlock.BlockName, XQt1636InBlock.F.cts_idx, 0, cts_idx.ToString("d4")); // long 4

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

		public bool SetBlock(XQt1636InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "gubun", 0, block.gubun.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "gubun1", 0, block.gubun1.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "gubun2", 0, block.gubun2.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "shcode", 0, block.shcode); // char 6
			_xaQuery.SetFieldData(block.GetBlockName(), "cts_idx", 0, block.cts_idx.ToString("d4")); // long 4

			return true;
		}

		public XQt1636OutBlock GetBlock()
		{
			XQt1636OutBlock instance = XQt1636OutBlock.FromQuery(this);
			return instance;

		}

		public XQt1636OutBlock1[] GetBlock1s()
		{
			XQt1636OutBlock1[] instance = XQt1636OutBlock1.ListFromQuery(this);
			return instance;

		}


	}

}
