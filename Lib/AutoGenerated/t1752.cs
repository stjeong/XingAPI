using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1752InBlock : XingBlock
	{
		/// <summary>
		/// t1752InBlock
		/// </summary>
		public const string _blockName = "t1752InBlock";
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
		/// t1752InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1752InBlock
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
		/// 조회날짜1
		/// </summary>
		[XAQueryFieldAttribute("traddate1", "조회날짜1", "char", "8")]
		public string traddate1;
		/// <summary>
		/// 조회날짜2
		/// </summary>
		[XAQueryFieldAttribute("traddate2", "조회날짜2", "char", "8")]
		public string traddate2;
		/// <summary>
		/// 외국계구분
		/// </summary>
		[XAQueryFieldAttribute("fwgubun1", "외국계구분", "char", "1")]
		public char fwgubun1;
		/// <summary>
		/// CTSIDX
		/// </summary>
		[XAQueryFieldAttribute("cts_idx", "CTSIDX", "long", "4")]
		public long cts_idx;

		public static class F
		{
			/// <summary>
			/// 종목코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 조회날짜1
			/// </summary>
			public const string traddate1 = "traddate1";
			/// <summary>
			/// 조회날짜2
			/// </summary>
			public const string traddate2 = "traddate2";
			/// <summary>
			/// 외국계구분
			/// </summary>
			public const string fwgubun1 = "fwgubun1";
			/// <summary>
			/// CTSIDX
			/// </summary>
			public const string cts_idx = "cts_idx";
		}

		public static string[] AllFields = new string[]
		{
			F.shcode,
			F.traddate1,
			F.traddate2,
			F.fwgubun1,
			F.cts_idx,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "종목코드", (decimal)6);
			dict["traddate1"] = new XAQueryFieldInfo("char", traddate1, traddate1, "조회날짜1", (decimal)8);
			dict["traddate2"] = new XAQueryFieldInfo("char", traddate2, traddate2, "조회날짜2", (decimal)8);
			dict["fwgubun1"] = new XAQueryFieldInfo("char", fwgubun1, fwgubun1.ToString(), "외국계구분", (decimal)1);
			dict["cts_idx"] = new XAQueryFieldInfo("long", cts_idx, cts_idx.ToString("d4"), "CTSIDX", (decimal)4);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "traddate1":
					this.traddate1 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "traddate2":
					this.traddate2 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "fwgubun1":
					this.fwgubun1 = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "cts_idx":
					this.cts_idx = fieldInfo.FieldValue.ParseLong("cts_idx");
				break;


			}
		}

		public bool VerifyData()
		{
			if (shcode?.Length > 6) return false; // char 6
			if (traddate1?.Length > 8) return false; // char 8
			if (traddate2?.Length > 8) return false; // char 8
			// fwgubun1 char 1
			if (cts_idx.ToString().Length > 4) return false; // long 4

			return true;
		}
	}

	public partial class XQt1752OutBlock : XingBlock
	{
		/// <summary>
		/// t1752OutBlock
		/// </summary>
		public const string _blockName = "t1752OutBlock";
		/// <summary>
		/// 기본출력
		/// </summary>
		public const string _blockDesc = "기본출력";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// false
		/// </summary>
		public const bool _hasOccurs = false;
		/// <summary>
		/// t1752OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1752OutBlock
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// 기본출력
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
		/// 외국계매도
		/// </summary>
		[XAQueryFieldAttribute("fwdvl", "외국계매도", "long", "12")]
		public long fwdvl;
		/// <summary>
		/// 외국계매수
		/// </summary>
		[XAQueryFieldAttribute("fwsvl", "외국계매수", "long", "12")]
		public long fwsvl;
		/// <summary>
		/// CTSIDX
		/// </summary>
		[XAQueryFieldAttribute("cts_idx", "CTSIDX", "long", "4")]
		public long cts_idx;

		public static class F
		{
			/// <summary>
			/// 외국계매도
			/// </summary>
			public const string fwdvl = "fwdvl";
			/// <summary>
			/// 외국계매수
			/// </summary>
			public const string fwsvl = "fwsvl";
			/// <summary>
			/// CTSIDX
			/// </summary>
			public const string cts_idx = "cts_idx";
		}

		public static string[] AllFields = new string[]
		{
			F.fwdvl,
			F.fwsvl,
			F.cts_idx,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["fwdvl"] = new XAQueryFieldInfo("long", fwdvl, fwdvl.ToString("d12"), "외국계매도", (decimal)12);
			dict["fwsvl"] = new XAQueryFieldInfo("long", fwsvl, fwsvl.ToString("d12"), "외국계매수", (decimal)12);
			dict["cts_idx"] = new XAQueryFieldInfo("long", cts_idx, cts_idx.ToString("d4"), "CTSIDX", (decimal)4);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "fwdvl":
					this.fwdvl = fieldInfo.FieldValue.ParseLong("fwdvl");
				break;

				case "fwsvl":
					this.fwsvl = fieldInfo.FieldValue.ParseLong("fwsvl");
				break;

				case "cts_idx":
					this.cts_idx = fieldInfo.FieldValue.ParseLong("cts_idx");
				break;


			}
		}

		public static XQt1752OutBlock FromQuery(XQt1752 query)
		{
			XQt1752OutBlock block = new XQt1752OutBlock();
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
				block.fwdvl = query.GetFieldData(block.GetBlockName(), "fwdvl", 0).ParseLong("fwdvl"); // long 12
				block.fwsvl = query.GetFieldData(block.GetBlockName(), "fwsvl", 0).ParseLong("fwsvl"); // long 12
				block.cts_idx = query.GetFieldData(block.GetBlockName(), "cts_idx", 0).ParseLong("cts_idx"); // long 4

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (fwdvl.ToString().Length > 12) return false; // long 12
			if (fwsvl.ToString().Length > 12) return false; // long 12
			if (cts_idx.ToString().Length > 4) return false; // long 4

			return true;
		}
	}

	public partial class XQt1752OutBlock1 : XingBlock
	{
		/// <summary>
		/// t1752OutBlock1
		/// </summary>
		public const string _blockName = "t1752OutBlock1";
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
		/// t1752OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1752OutBlock1
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
		/// 회원사
		/// </summary>
		[XAQueryFieldAttribute("tradname", "회원사", "char", "20")]
		public string tradname;
		/// <summary>
		/// 매도수량
		/// </summary>
		[XAQueryFieldAttribute("tradmdvol", "매도수량", "long", "12")]
		public long tradmdvol;
		/// <summary>
		/// 매수수량
		/// </summary>
		[XAQueryFieldAttribute("tradmsvol", "매수수량", "long", "12")]
		public long tradmsvol;
		/// <summary>
		/// 순매수
		/// </summary>
		[XAQueryFieldAttribute("tradmssvol", "순매수", "long", "12")]
		public long tradmssvol;
		/// <summary>
		/// 창구거래
		/// </summary>
		[XAQueryFieldAttribute("wintrd", "창구거래", "long", "12")]
		public long wintrd;
		/// <summary>
		/// 비중
		/// </summary>
		[XAQueryFieldAttribute("winrat", "비중", "float", "6.1")]
		public float winrat;
		/// <summary>
		/// 회원사코드
		/// </summary>
		[XAQueryFieldAttribute("tradno", "회원사코드", "char", "3")]
		public string tradno;
		/// <summary>
		/// 외국계여부
		/// </summary>
		[XAQueryFieldAttribute("wgubun", "외국계여부", "char", "1")]
		public char wgubun;
		/// <summary>
		/// 순비중
		/// </summary>
		[XAQueryFieldAttribute("swinrat", "순비중", "float", "6.1")]
		public float swinrat;

		public static class F
		{
			/// <summary>
			/// 회원사
			/// </summary>
			public const string tradname = "tradname";
			/// <summary>
			/// 매도수량
			/// </summary>
			public const string tradmdvol = "tradmdvol";
			/// <summary>
			/// 매수수량
			/// </summary>
			public const string tradmsvol = "tradmsvol";
			/// <summary>
			/// 순매수
			/// </summary>
			public const string tradmssvol = "tradmssvol";
			/// <summary>
			/// 창구거래
			/// </summary>
			public const string wintrd = "wintrd";
			/// <summary>
			/// 비중
			/// </summary>
			public const string winrat = "winrat";
			/// <summary>
			/// 회원사코드
			/// </summary>
			public const string tradno = "tradno";
			/// <summary>
			/// 외국계여부
			/// </summary>
			public const string wgubun = "wgubun";
			/// <summary>
			/// 순비중
			/// </summary>
			public const string swinrat = "swinrat";
		}

		public static string[] AllFields = new string[]
		{
			F.tradname,
			F.tradmdvol,
			F.tradmsvol,
			F.tradmssvol,
			F.wintrd,
			F.winrat,
			F.tradno,
			F.wgubun,
			F.swinrat,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["tradname"] = new XAQueryFieldInfo("char", tradname, tradname, "회원사", (decimal)20);
			dict["tradmdvol"] = new XAQueryFieldInfo("long", tradmdvol, tradmdvol.ToString("d12"), "매도수량", (decimal)12);
			dict["tradmsvol"] = new XAQueryFieldInfo("long", tradmsvol, tradmsvol.ToString("d12"), "매수수량", (decimal)12);
			dict["tradmssvol"] = new XAQueryFieldInfo("long", tradmssvol, tradmssvol.ToString("d12"), "순매수", (decimal)12);
			dict["wintrd"] = new XAQueryFieldInfo("long", wintrd, wintrd.ToString("d12"), "창구거래", (decimal)12);
			dict["winrat"] = new XAQueryFieldInfo("float", winrat, winrat.ToString("000000.0"), "비중", (decimal)6.1);
			dict["tradno"] = new XAQueryFieldInfo("char", tradno, tradno, "회원사코드", (decimal)3);
			dict["wgubun"] = new XAQueryFieldInfo("char", wgubun, wgubun.ToString(), "외국계여부", (decimal)1);
			dict["swinrat"] = new XAQueryFieldInfo("float", swinrat, swinrat.ToString("000000.0"), "순비중", (decimal)6.1);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "tradname":
					this.tradname = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "tradmdvol":
					this.tradmdvol = fieldInfo.FieldValue.ParseLong("tradmdvol");
				break;

				case "tradmsvol":
					this.tradmsvol = fieldInfo.FieldValue.ParseLong("tradmsvol");
				break;

				case "tradmssvol":
					this.tradmssvol = fieldInfo.FieldValue.ParseLong("tradmssvol");
				break;

				case "wintrd":
					this.wintrd = fieldInfo.FieldValue.ParseLong("wintrd");
				break;

				case "winrat":
					this.winrat = fieldInfo.FieldValue.ParseFloat("winrat");
				break;

				case "tradno":
					this.tradno = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "wgubun":
					this.wgubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "swinrat":
					this.swinrat = fieldInfo.FieldValue.ParseFloat("swinrat");
				break;


			}
		}

		public static XQt1752OutBlock1[] ListFromQuery(XQt1752 query)
		{
			int count = query.GetBlockCount(XQt1752OutBlock1.BlockName);
			List<XQt1752OutBlock1> list = new List<XQt1752OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1752OutBlock1 block = new XQt1752OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.tradname = query.GetFieldData(block.GetBlockName(), "tradname", i).TrimEnd('?'); // char 20
					block.tradmdvol = query.GetFieldData(block.GetBlockName(), "tradmdvol", i).ParseLong("tradmdvol"); // long 12
					block.tradmsvol = query.GetFieldData(block.GetBlockName(), "tradmsvol", i).ParseLong("tradmsvol"); // long 12
					block.tradmssvol = query.GetFieldData(block.GetBlockName(), "tradmssvol", i).ParseLong("tradmssvol"); // long 12
					block.wintrd = query.GetFieldData(block.GetBlockName(), "wintrd", i).ParseLong("wintrd"); // long 12
					block.winrat = query.GetFieldData(block.GetBlockName(), "winrat", i).ParseFloat("winrat"); // float 6.1
					block.tradno = query.GetFieldData(block.GetBlockName(), "tradno", i).TrimEnd('?'); // char 3
					block.wgubun = query.GetFieldData(block.GetBlockName(), "wgubun", i).FirstOrDefault(); // char 1
					block.swinrat = query.GetFieldData(block.GetBlockName(), "swinrat", i).ParseFloat("swinrat"); // float 6.1

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
			if (tradname?.Length > 20) return false; // char 20
			if (tradmdvol.ToString().Length > 12) return false; // long 12
			if (tradmsvol.ToString().Length > 12) return false; // long 12
			if (tradmssvol.ToString().Length > 12) return false; // long 12
			if (wintrd.ToString().Length > 12) return false; // long 12
			// winrat float 6.1
			if (tradno?.Length > 3) return false; // char 3
			// wgubun char 1
			// swinrat float 6.1

			return true;
		}
	}

	/// <summary>
	/// 종목별상위회원사(t1752)
	/// </summary>
	public partial class XQt1752 : XingQuery
	{
		/// <summary>
		/// t1752
		/// </summary>
		public const string _typeName = "t1752";
		/// <summary>
		/// 종목별상위회원사(t1752)
		/// </summary>
		public const string _typeDesc = "종목별상위회원사(t1752)";
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
		/// t1752
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 종목별상위회원사(t1752)
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
		/// 종목별상위회원사(t1752)
		/// </summary>
		public XQt1752() : base("t1752") { }


		public class XQAllOutBlocks
		{
			public XQt1752OutBlock OutBlock { get; internal set; }
			public XQt1752OutBlock1[] OutBlock1 { get; internal set; }
		}

		public static XQAllOutBlocks Get(string shcode = default,string traddate1 = default,string traddate2 = default,char fwgubun1 = default,long cts_idx = default)
		{
			using (XQt1752 instance = new XQt1752())
			{
				instance.SetFieldData(XQt1752InBlock.BlockName, XQt1752InBlock.F.shcode, 0, shcode); // char 6
				instance.SetFieldData(XQt1752InBlock.BlockName, XQt1752InBlock.F.traddate1, 0, traddate1); // char 8
				instance.SetFieldData(XQt1752InBlock.BlockName, XQt1752InBlock.F.traddate2, 0, traddate2); // char 8
				instance.SetFieldData(XQt1752InBlock.BlockName, XQt1752InBlock.F.fwgubun1, 0, fwgubun1.ToString()); // char 1
				instance.SetFieldData(XQt1752InBlock.BlockName, XQt1752InBlock.F.cts_idx, 0, cts_idx.ToString("d4")); // long 4

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

		public bool SetBlock(XQt1752InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "shcode", 0, block.shcode); // char 6
			_xaQuery.SetFieldData(block.GetBlockName(), "traddate1", 0, block.traddate1); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "traddate2", 0, block.traddate2); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "fwgubun1", 0, block.fwgubun1.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "cts_idx", 0, block.cts_idx.ToString("d4")); // long 4

			return true;
		}

		public XQt1752OutBlock GetBlock()
		{
			XQt1752OutBlock instance = XQt1752OutBlock.FromQuery(this);
			return instance;

		}

		public XQt1752OutBlock1[] GetBlock1s()
		{
			XQt1752OutBlock1[] instance = XQt1752OutBlock1.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt1752OutBlock),
			typeof(XQt1752OutBlock1),

		};

	}

}
