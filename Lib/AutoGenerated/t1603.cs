using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1603InBlock : XingBlock
	{
		/// <summary>
		/// t1603InBlock
		/// </summary>
		public const string _blockName = "t1603InBlock";
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
		/// t1603InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1603InBlock
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
		/// 시장구분
		/// </summary>
		[XAQueryFieldAttribute("시장구분")]
		public char market;
		/// <summary>
		/// 투자자구분
		/// </summary>
		[XAQueryFieldAttribute("투자자구분")]
		public char gubun1;
		/// <summary>
		/// 전일분구분
		/// </summary>
		[XAQueryFieldAttribute("전일분구분")]
		public char gubun2;
		/// <summary>
		/// CTSTIME
		/// </summary>
		[XAQueryFieldAttribute("CTSTIME")]
		public string cts_time;
		/// <summary>
		/// CTSIDX
		/// </summary>
		[XAQueryFieldAttribute("CTSIDX")]
		public long cts_idx;
		/// <summary>
		/// 조회건수
		/// </summary>
		[XAQueryFieldAttribute("조회건수")]
		public int cnt;
		/// <summary>
		/// 업종코드
		/// </summary>
		[XAQueryFieldAttribute("업종코드")]
		public string upcode;

		public static class F
		{
			/// <summary>
			/// 시장구분
			/// </summary>
			public const string market = "market";
			/// <summary>
			/// 투자자구분
			/// </summary>
			public const string gubun1 = "gubun1";
			/// <summary>
			/// 전일분구분
			/// </summary>
			public const string gubun2 = "gubun2";
			/// <summary>
			/// CTSTIME
			/// </summary>
			public const string cts_time = "cts_time";
			/// <summary>
			/// CTSIDX
			/// </summary>
			public const string cts_idx = "cts_idx";
			/// <summary>
			/// 조회건수
			/// </summary>
			public const string cnt = "cnt";
			/// <summary>
			/// 업종코드
			/// </summary>
			public const string upcode = "upcode";
		}

		public static string[] AllFields = new string[]
		{
			F.market,
			F.gubun1,
			F.gubun2,
			F.cts_time,
			F.cts_idx,
			F.cnt,
			F.upcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["market"] = new XAQueryFieldInfo("char", market, market.ToString(), "시장구분", (decimal)1);
			dict["gubun1"] = new XAQueryFieldInfo("char", gubun1, gubun1.ToString(), "투자자구분", (decimal)1);
			dict["gubun2"] = new XAQueryFieldInfo("char", gubun2, gubun2.ToString(), "전일분구분", (decimal)1);
			dict["cts_time"] = new XAQueryFieldInfo("char", cts_time, cts_time, "CTSTIME", (decimal)8);
			dict["cts_idx"] = new XAQueryFieldInfo("long", cts_idx, cts_idx.ToString("d4"), "CTSIDX", (decimal)4);
			dict["cnt"] = new XAQueryFieldInfo("int", cnt, cnt.ToString("d3"), "조회건수", (decimal)3);
			dict["upcode"] = new XAQueryFieldInfo("char", upcode, upcode, "업종코드", (decimal)3);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "market":
					this.market = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "gubun1":
					this.gubun1 = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "gubun2":
					this.gubun2 = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "cts_time":
					this.cts_time = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cts_idx":
					this.cts_idx = fieldInfo.FieldValue.ParseLong("cts_idx");
				break;

				case "cnt":
					this.cnt = fieldInfo.FieldValue.ParseInt("cnt");
				break;

				case "upcode":
					this.upcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			// market char 1
			// gubun1 char 1
			// gubun2 char 1
			if (cts_time?.Length > 8) return false; // char 8
			if (cts_idx.ToString().Length > 4) return false; // long 4
			// cnt int 3
			if (upcode?.Length > 3) return false; // char 3

			return true;
		}
	}

	public partial class XQt1603OutBlock : XingBlock
	{
		/// <summary>
		/// t1603OutBlock
		/// </summary>
		public const string _blockName = "t1603OutBlock";
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
		/// t1603OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1603OutBlock
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
		/// CTSIDX
		/// </summary>
		[XAQueryFieldAttribute("CTSIDX")]
		public long cts_idx;
		/// <summary>
		/// CTSTIME
		/// </summary>
		[XAQueryFieldAttribute("CTSTIME")]
		public string cts_time;

		public static class F
		{
			/// <summary>
			/// CTSIDX
			/// </summary>
			public const string cts_idx = "cts_idx";
			/// <summary>
			/// CTSTIME
			/// </summary>
			public const string cts_time = "cts_time";
		}

		public static string[] AllFields = new string[]
		{
			F.cts_idx,
			F.cts_time,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["cts_idx"] = new XAQueryFieldInfo("long", cts_idx, cts_idx.ToString("d4"), "CTSIDX", (decimal)4);
			dict["cts_time"] = new XAQueryFieldInfo("char", cts_time, cts_time, "CTSTIME", (decimal)8);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "cts_idx":
					this.cts_idx = fieldInfo.FieldValue.ParseLong("cts_idx");
				break;

				case "cts_time":
					this.cts_time = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt1603OutBlock FromQuery(XQt1603 query)
		{
			XQt1603OutBlock block = new XQt1603OutBlock();
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
				block.cts_time = query.GetFieldData(block.GetBlockName(), "cts_time", 0).TrimEnd('?'); // char 8

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (cts_idx.ToString().Length > 4) return false; // long 4
			if (cts_time?.Length > 8) return false; // char 8

			return true;
		}
	}

	public partial class XQt1603OutBlock1 : XingBlock
	{
		/// <summary>
		/// t1603OutBlock1
		/// </summary>
		public const string _blockName = "t1603OutBlock1";
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
		/// t1603OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1603OutBlock1
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
		[XAQueryFieldAttribute("시간")]
		public string time;
		/// <summary>
		/// 투자자구분
		/// </summary>
		[XAQueryFieldAttribute("투자자구분")]
		public string tjjcode;
		/// <summary>
		/// 매수수량
		/// </summary>
		[XAQueryFieldAttribute("매수수량")]
		public long msvolume;
		/// <summary>
		/// 매도수량
		/// </summary>
		[XAQueryFieldAttribute("매도수량")]
		public long mdvolume;
		/// <summary>
		/// 매수금액
		/// </summary>
		[XAQueryFieldAttribute("매수금액")]
		public long msvalue;
		/// <summary>
		/// 매도금액
		/// </summary>
		[XAQueryFieldAttribute("매도금액")]
		public long mdvalue;
		/// <summary>
		/// 순매수수량
		/// </summary>
		[XAQueryFieldAttribute("순매수수량")]
		public long svolume;
		/// <summary>
		/// 순매수금액
		/// </summary>
		[XAQueryFieldAttribute("순매수금액")]
		public long svalue;

		public static class F
		{
			/// <summary>
			/// 시간
			/// </summary>
			public const string time = "time";
			/// <summary>
			/// 투자자구분
			/// </summary>
			public const string tjjcode = "tjjcode";
			/// <summary>
			/// 매수수량
			/// </summary>
			public const string msvolume = "msvolume";
			/// <summary>
			/// 매도수량
			/// </summary>
			public const string mdvolume = "mdvolume";
			/// <summary>
			/// 매수금액
			/// </summary>
			public const string msvalue = "msvalue";
			/// <summary>
			/// 매도금액
			/// </summary>
			public const string mdvalue = "mdvalue";
			/// <summary>
			/// 순매수수량
			/// </summary>
			public const string svolume = "svolume";
			/// <summary>
			/// 순매수금액
			/// </summary>
			public const string svalue = "svalue";
		}

		public static string[] AllFields = new string[]
		{
			F.time,
			F.tjjcode,
			F.msvolume,
			F.mdvolume,
			F.msvalue,
			F.mdvalue,
			F.svolume,
			F.svalue,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["time"] = new XAQueryFieldInfo("char", time, time, "시간", (decimal)8);
			dict["tjjcode"] = new XAQueryFieldInfo("char", tjjcode, tjjcode, "투자자구분", (decimal)4);
			dict["msvolume"] = new XAQueryFieldInfo("long", msvolume, msvolume.ToString("d8"), "매수수량", (decimal)8);
			dict["mdvolume"] = new XAQueryFieldInfo("long", mdvolume, mdvolume.ToString("d8"), "매도수량", (decimal)8);
			dict["msvalue"] = new XAQueryFieldInfo("long", msvalue, msvalue.ToString("d12"), "매수금액", (decimal)12);
			dict["mdvalue"] = new XAQueryFieldInfo("long", mdvalue, mdvalue.ToString("d12"), "매도금액", (decimal)12);
			dict["svolume"] = new XAQueryFieldInfo("long", svolume, svolume.ToString("d8"), "순매수수량", (decimal)8);
			dict["svalue"] = new XAQueryFieldInfo("long", svalue, svalue.ToString("d12"), "순매수금액", (decimal)12);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "time":
					this.time = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "tjjcode":
					this.tjjcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "msvolume":
					this.msvolume = fieldInfo.FieldValue.ParseLong("msvolume");
				break;

				case "mdvolume":
					this.mdvolume = fieldInfo.FieldValue.ParseLong("mdvolume");
				break;

				case "msvalue":
					this.msvalue = fieldInfo.FieldValue.ParseLong("msvalue");
				break;

				case "mdvalue":
					this.mdvalue = fieldInfo.FieldValue.ParseLong("mdvalue");
				break;

				case "svolume":
					this.svolume = fieldInfo.FieldValue.ParseLong("svolume");
				break;

				case "svalue":
					this.svalue = fieldInfo.FieldValue.ParseLong("svalue");
				break;


			}
		}

		public static XQt1603OutBlock1[] ListFromQuery(XQt1603 query)
		{
			int count = query.GetBlockCount(XQt1603OutBlock1.BlockName);
			List<XQt1603OutBlock1> list = new List<XQt1603OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1603OutBlock1 block = new XQt1603OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.time = query.GetFieldData(block.GetBlockName(), "time", i).TrimEnd('?'); // char 8
					block.tjjcode = query.GetFieldData(block.GetBlockName(), "tjjcode", i).TrimEnd('?'); // char 4
					block.msvolume = query.GetFieldData(block.GetBlockName(), "msvolume", i).ParseLong("msvolume"); // long 8
					block.mdvolume = query.GetFieldData(block.GetBlockName(), "mdvolume", i).ParseLong("mdvolume"); // long 8
					block.msvalue = query.GetFieldData(block.GetBlockName(), "msvalue", i).ParseLong("msvalue"); // long 12
					block.mdvalue = query.GetFieldData(block.GetBlockName(), "mdvalue", i).ParseLong("mdvalue"); // long 12
					block.svolume = query.GetFieldData(block.GetBlockName(), "svolume", i).ParseLong("svolume"); // long 8
					block.svalue = query.GetFieldData(block.GetBlockName(), "svalue", i).ParseLong("svalue"); // long 12

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
			if (time?.Length > 8) return false; // char 8
			if (tjjcode?.Length > 4) return false; // char 4
			if (msvolume.ToString().Length > 8) return false; // long 8
			if (mdvolume.ToString().Length > 8) return false; // long 8
			if (msvalue.ToString().Length > 12) return false; // long 12
			if (mdvalue.ToString().Length > 12) return false; // long 12
			if (svolume.ToString().Length > 8) return false; // long 8
			if (svalue.ToString().Length > 12) return false; // long 12

			return true;
		}
	}

	/// <summary>
	/// 시간대별투자자매매추이상세(t1603)
	/// </summary>
	public partial class XQt1603 : XingQuery
	{
		/// <summary>
		/// t1603
		/// </summary>
		public const string _typeName = "t1603";
		/// <summary>
		/// 시간대별투자자매매추이상세(t1603)
		/// </summary>
		public const string _typeDesc = "시간대별투자자매매추이상세(t1603)";
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
		/// t1603
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 시간대별투자자매매추이상세(t1603)
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

		public XQt1603() : base("t1603") { }


		public static XQt1603OutBlock1[] Get(char market = default,char gubun1 = default,char gubun2 = default,string cts_time = default,long cts_idx = default,int cnt = default,string upcode = default)
		{
			using (XQt1603 instance = new XQt1603())
			{
				instance.SetFieldData(XQt1603InBlock.BlockName, XQt1603InBlock.F.market, 0, market.ToString()); // char 1
				instance.SetFieldData(XQt1603InBlock.BlockName, XQt1603InBlock.F.gubun1, 0, gubun1.ToString()); // char 1
				instance.SetFieldData(XQt1603InBlock.BlockName, XQt1603InBlock.F.gubun2, 0, gubun2.ToString()); // char 1
				instance.SetFieldData(XQt1603InBlock.BlockName, XQt1603InBlock.F.cts_time, 0, cts_time); // char 8
				instance.SetFieldData(XQt1603InBlock.BlockName, XQt1603InBlock.F.cts_idx, 0, cts_idx.ToString("d4")); // long 4
				instance.SetFieldData(XQt1603InBlock.BlockName, XQt1603InBlock.F.cnt, 0, cnt.ToString("d3")); // int 3
				instance.SetFieldData(XQt1603InBlock.BlockName, XQt1603InBlock.F.upcode, 0, upcode); // char 3

				if (instance.Request() < 0)
				{
					return null;
				}

				var outBlock = instance.GetBlock1s();
				return outBlock;
			}
		}

		public bool SetBlock(XQt1603InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "market", 0, block.market.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "gubun1", 0, block.gubun1.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "gubun2", 0, block.gubun2.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "cts_time", 0, block.cts_time); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "cts_idx", 0, block.cts_idx.ToString("d4")); // long 4
			_xaQuery.SetFieldData(block.GetBlockName(), "cnt", 0, block.cnt.ToString("d3")); // int 3
			_xaQuery.SetFieldData(block.GetBlockName(), "upcode", 0, block.upcode); // char 3

			return true;
		}

		public XQt1603OutBlock GetBlock()
		{
			XQt1603OutBlock instance = XQt1603OutBlock.FromQuery(this);
			return instance;

		}

		public XQt1603OutBlock1[] GetBlock1s()
		{
			XQt1603OutBlock1[] instance = XQt1603OutBlock1.ListFromQuery(this);
			return instance;

		}


	}

}
