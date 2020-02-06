using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt3341InBlock : XingBlock
	{
		/// <summary>
		/// t3341InBlock
		/// </summary>
		public const string _blockName = "t3341InBlock";
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
		/// t3341InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t3341InBlock
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
		public char gubun;
		/// <summary>
		/// 순위구분(1:매출액증가율2:영업이익증가율3:세전계속이익증가율4:부채비율5:유보율6:EPS7:BPS8:ROE9:PERa:PBRb:PEG)
		/// </summary>
		[XAQueryFieldAttribute("순위구분(1:매출액증가율2:영업이익증가율3:세전계속이익증가율4:부채비율5:유보율6:EPS7:BPS8:ROE9:PERa:PBRb:PEG)")]
		public char gubun1;
		/// <summary>
		/// 대비구분
		/// </summary>
		[XAQueryFieldAttribute("대비구분")]
		public char gubun2;
		/// <summary>
		/// IDX
		/// </summary>
		[XAQueryFieldAttribute("IDX")]
		public long idx;

		public static class F
		{
			/// <summary>
			/// 시장구분
			/// </summary>
			public const string gubun = "gubun";
			/// <summary>
			/// 순위구분(1:매출액증가율2:영업이익증가율3:세전계속이익증가율4:부채비율5:유보율6:EPS7:BPS8:ROE9:PERa:PBRb:PEG)
			/// </summary>
			public const string gubun1 = "gubun1";
			/// <summary>
			/// 대비구분
			/// </summary>
			public const string gubun2 = "gubun2";
			/// <summary>
			/// IDX
			/// </summary>
			public const string idx = "idx";
		}

		public static string[] AllFields = new string[]
		{
			F.gubun,
			F.gubun1,
			F.gubun2,
			F.idx,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["gubun"] = new XAQueryFieldInfo("char", gubun, gubun.ToString(), "시장구분", (decimal)1);
			dict["gubun1"] = new XAQueryFieldInfo("char", gubun1, gubun1.ToString(), "순위구분(1:매출액증가율2:영업이익증가율3:세전계속이익증가율4:부채비율5:유보율6:EPS7:BPS8:ROE9:PERa:PBRb:PEG)", (decimal)1);
			dict["gubun2"] = new XAQueryFieldInfo("char", gubun2, gubun2.ToString(), "대비구분", (decimal)1);
			dict["idx"] = new XAQueryFieldInfo("long", idx, idx.ToString("d4"), "IDX", (decimal)4);

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

				case "idx":
					this.idx = fieldInfo.FieldValue.ParseLong("idx");
				break;


			}
		}

		public bool VerifyData()
		{
			// gubun char 1
			// gubun1 char 1
			// gubun2 char 1
			if (idx.ToString().Length > 4) return false; // long 4

			return true;
		}
	}

	public partial class XQt3341OutBlock : XingBlock
	{
		/// <summary>
		/// t3341OutBlock
		/// </summary>
		public const string _blockName = "t3341OutBlock";
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
		/// t3341OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t3341OutBlock
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
		/// CNT
		/// </summary>
		[XAQueryFieldAttribute("CNT")]
		public long cnt;
		/// <summary>
		/// IDX
		/// </summary>
		[XAQueryFieldAttribute("IDX")]
		public long idx;

		public static class F
		{
			/// <summary>
			/// CNT
			/// </summary>
			public const string cnt = "cnt";
			/// <summary>
			/// IDX
			/// </summary>
			public const string idx = "idx";
		}

		public static string[] AllFields = new string[]
		{
			F.cnt,
			F.idx,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["cnt"] = new XAQueryFieldInfo("long", cnt, cnt.ToString("d4"), "CNT", (decimal)4);
			dict["idx"] = new XAQueryFieldInfo("long", idx, idx.ToString("d4"), "IDX", (decimal)4);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "cnt":
					this.cnt = fieldInfo.FieldValue.ParseLong("cnt");
				break;

				case "idx":
					this.idx = fieldInfo.FieldValue.ParseLong("idx");
				break;


			}
		}

		public static XQt3341OutBlock FromQuery(XQt3341 query)
		{
			XQt3341OutBlock block = new XQt3341OutBlock();
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
				block.cnt = query.GetFieldData(block.GetBlockName(), "cnt", 0).ParseLong("cnt"); // long 4
				block.idx = query.GetFieldData(block.GetBlockName(), "idx", 0).ParseLong("idx"); // long 4

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (cnt.ToString().Length > 4) return false; // long 4
			if (idx.ToString().Length > 4) return false; // long 4

			return true;
		}
	}

	public partial class XQt3341OutBlock1 : XingBlock
	{
		/// <summary>
		/// t3341OutBlock1
		/// </summary>
		public const string _blockName = "t3341OutBlock1";
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
		/// t3341OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t3341OutBlock1
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
		/// 기업명
		/// </summary>
		[XAQueryFieldAttribute("기업명")]
		public string hname;
		/// <summary>
		/// 매출액증가율
		/// </summary>
		[XAQueryFieldAttribute("매출액증가율")]
		public long salesgrowth;
		/// <summary>
		/// 영업이익증가율
		/// </summary>
		[XAQueryFieldAttribute("영업이익증가율")]
		public long operatingincomegrowt;
		/// <summary>
		/// 경상이익증가율
		/// </summary>
		[XAQueryFieldAttribute("경상이익증가율")]
		public long ordinaryincomegrowth;
		/// <summary>
		/// 부채비율
		/// </summary>
		[XAQueryFieldAttribute("부채비율")]
		public long liabilitytoequity;
		/// <summary>
		/// 유보율
		/// </summary>
		[XAQueryFieldAttribute("유보율")]
		public long enterpriseratio;
		/// <summary>
		/// EPS
		/// </summary>
		[XAQueryFieldAttribute("EPS")]
		public long eps;
		/// <summary>
		/// BPS
		/// </summary>
		[XAQueryFieldAttribute("BPS")]
		public long bps;
		/// <summary>
		/// ROE
		/// </summary>
		[XAQueryFieldAttribute("ROE")]
		public long roe;
		/// <summary>
		/// 종목코드
		/// </summary>
		[XAQueryFieldAttribute("종목코드")]
		public string shcode;
		/// <summary>
		/// PER
		/// </summary>
		[XAQueryFieldAttribute("PER")]
		public float per;
		/// <summary>
		/// PBR
		/// </summary>
		[XAQueryFieldAttribute("PBR")]
		public float pbr;
		/// <summary>
		/// PEG
		/// </summary>
		[XAQueryFieldAttribute("PEG")]
		public float peg;

		public static class F
		{
			/// <summary>
			/// 순위
			/// </summary>
			public const string rank = "rank";
			/// <summary>
			/// 기업명
			/// </summary>
			public const string hname = "hname";
			/// <summary>
			/// 매출액증가율
			/// </summary>
			public const string salesgrowth = "salesgrowth";
			/// <summary>
			/// 영업이익증가율
			/// </summary>
			public const string operatingincomegrowt = "operatingincomegrowt";
			/// <summary>
			/// 경상이익증가율
			/// </summary>
			public const string ordinaryincomegrowth = "ordinaryincomegrowth";
			/// <summary>
			/// 부채비율
			/// </summary>
			public const string liabilitytoequity = "liabilitytoequity";
			/// <summary>
			/// 유보율
			/// </summary>
			public const string enterpriseratio = "enterpriseratio";
			/// <summary>
			/// EPS
			/// </summary>
			public const string eps = "eps";
			/// <summary>
			/// BPS
			/// </summary>
			public const string bps = "bps";
			/// <summary>
			/// ROE
			/// </summary>
			public const string roe = "roe";
			/// <summary>
			/// 종목코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// PER
			/// </summary>
			public const string per = "per";
			/// <summary>
			/// PBR
			/// </summary>
			public const string pbr = "pbr";
			/// <summary>
			/// PEG
			/// </summary>
			public const string peg = "peg";
		}

		public static string[] AllFields = new string[]
		{
			F.rank,
			F.hname,
			F.salesgrowth,
			F.operatingincomegrowt,
			F.ordinaryincomegrowth,
			F.liabilitytoequity,
			F.enterpriseratio,
			F.eps,
			F.bps,
			F.roe,
			F.shcode,
			F.per,
			F.pbr,
			F.peg,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["rank"] = new XAQueryFieldInfo("long", rank, rank.ToString("d4"), "순위", (decimal)4);
			dict["hname"] = new XAQueryFieldInfo("char", hname, hname, "기업명", (decimal)20);
			dict["salesgrowth"] = new XAQueryFieldInfo("long", salesgrowth, salesgrowth.ToString("d12"), "매출액증가율", (decimal)12);
			dict["operatingincomegrowt"] = new XAQueryFieldInfo("long", operatingincomegrowt, operatingincomegrowt.ToString("d12"), "영업이익증가율", (decimal)12);
			dict["ordinaryincomegrowth"] = new XAQueryFieldInfo("long", ordinaryincomegrowth, ordinaryincomegrowth.ToString("d12"), "경상이익증가율", (decimal)12);
			dict["liabilitytoequity"] = new XAQueryFieldInfo("long", liabilitytoequity, liabilitytoequity.ToString("d12"), "부채비율", (decimal)12);
			dict["enterpriseratio"] = new XAQueryFieldInfo("long", enterpriseratio, enterpriseratio.ToString("d12"), "유보율", (decimal)12);
			dict["eps"] = new XAQueryFieldInfo("long", eps, eps.ToString("d12"), "EPS", (decimal)12);
			dict["bps"] = new XAQueryFieldInfo("long", bps, bps.ToString("d12"), "BPS", (decimal)12);
			dict["roe"] = new XAQueryFieldInfo("long", roe, roe.ToString("d12"), "ROE", (decimal)12);
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "종목코드", (decimal)6);
			dict["per"] = new XAQueryFieldInfo("float", per, per.ToString("0000000000000.00"), "PER", (decimal)13.2);
			dict["pbr"] = new XAQueryFieldInfo("float", pbr, pbr.ToString("0000000000000.00"), "PBR", (decimal)13.2);
			dict["peg"] = new XAQueryFieldInfo("float", peg, peg.ToString("0000000000000.00"), "PEG", (decimal)13.2);

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

				case "salesgrowth":
					this.salesgrowth = fieldInfo.FieldValue.ParseLong("salesgrowth");
				break;

				case "operatingincomegrowt":
					this.operatingincomegrowt = fieldInfo.FieldValue.ParseLong("operatingincomegrowt");
				break;

				case "ordinaryincomegrowth":
					this.ordinaryincomegrowth = fieldInfo.FieldValue.ParseLong("ordinaryincomegrowth");
				break;

				case "liabilitytoequity":
					this.liabilitytoequity = fieldInfo.FieldValue.ParseLong("liabilitytoequity");
				break;

				case "enterpriseratio":
					this.enterpriseratio = fieldInfo.FieldValue.ParseLong("enterpriseratio");
				break;

				case "eps":
					this.eps = fieldInfo.FieldValue.ParseLong("eps");
				break;

				case "bps":
					this.bps = fieldInfo.FieldValue.ParseLong("bps");
				break;

				case "roe":
					this.roe = fieldInfo.FieldValue.ParseLong("roe");
				break;

				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "per":
					this.per = fieldInfo.FieldValue.ParseFloat("per");
				break;

				case "pbr":
					this.pbr = fieldInfo.FieldValue.ParseFloat("pbr");
				break;

				case "peg":
					this.peg = fieldInfo.FieldValue.ParseFloat("peg");
				break;


			}
		}

		public static XQt3341OutBlock1[] ListFromQuery(XQt3341 query)
		{
			int count = query.GetBlockCount(XQt3341OutBlock1.BlockName);
			List<XQt3341OutBlock1> list = new List<XQt3341OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt3341OutBlock1 block = new XQt3341OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.rank = query.GetFieldData(block.GetBlockName(), "rank", i).ParseLong("rank"); // long 4
					block.hname = query.GetFieldData(block.GetBlockName(), "hname", i).TrimEnd('?'); // char 20
					block.salesgrowth = query.GetFieldData(block.GetBlockName(), "salesgrowth", i).ParseLong("salesgrowth"); // long 12
					block.operatingincomegrowt = query.GetFieldData(block.GetBlockName(), "operatingincomegrowt", i).ParseLong("operatingincomegrowt"); // long 12
					block.ordinaryincomegrowth = query.GetFieldData(block.GetBlockName(), "ordinaryincomegrowth", i).ParseLong("ordinaryincomegrowth"); // long 12
					block.liabilitytoequity = query.GetFieldData(block.GetBlockName(), "liabilitytoequity", i).ParseLong("liabilitytoequity"); // long 12
					block.enterpriseratio = query.GetFieldData(block.GetBlockName(), "enterpriseratio", i).ParseLong("enterpriseratio"); // long 12
					block.eps = query.GetFieldData(block.GetBlockName(), "eps", i).ParseLong("eps"); // long 12
					block.bps = query.GetFieldData(block.GetBlockName(), "bps", i).ParseLong("bps"); // long 12
					block.roe = query.GetFieldData(block.GetBlockName(), "roe", i).ParseLong("roe"); // long 12
					block.shcode = query.GetFieldData(block.GetBlockName(), "shcode", i).TrimEnd('?'); // char 6
					block.per = query.GetFieldData(block.GetBlockName(), "per", i).ParseFloat("per"); // float 13.2
					block.pbr = query.GetFieldData(block.GetBlockName(), "pbr", i).ParseFloat("pbr"); // float 13.2
					block.peg = query.GetFieldData(block.GetBlockName(), "peg", i).ParseFloat("peg"); // float 13.2

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
			if (rank.ToString().Length > 4) return false; // long 4
			if (hname?.Length > 20) return false; // char 20
			if (salesgrowth.ToString().Length > 12) return false; // long 12
			if (operatingincomegrowt.ToString().Length > 12) return false; // long 12
			if (ordinaryincomegrowth.ToString().Length > 12) return false; // long 12
			if (liabilitytoequity.ToString().Length > 12) return false; // long 12
			if (enterpriseratio.ToString().Length > 12) return false; // long 12
			if (eps.ToString().Length > 12) return false; // long 12
			if (bps.ToString().Length > 12) return false; // long 12
			if (roe.ToString().Length > 12) return false; // long 12
			if (shcode?.Length > 6) return false; // char 6
			// per float 13.2
			// pbr float 13.2
			// peg float 13.2

			return true;
		}
	}

	/// <summary>
	/// 재무순위종합(t3341)
	/// </summary>
	public partial class XQt3341 : XingQuery
	{
		/// <summary>
		/// t3341
		/// </summary>
		public const string _typeName = "t3341";
		/// <summary>
		/// 재무순위종합(t3341)
		/// </summary>
		public const string _typeDesc = "재무순위종합(t3341)";
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
		/// t3341
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 재무순위종합(t3341)
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

		public XQt3341() : base("t3341") { }


		public static XQt3341OutBlock1[] Get(char gubun = default,char gubun1 = default,char gubun2 = default,long idx = default)
		{
			using (XQt3341 instance = new XQt3341())
			{
				instance.SetFieldData(XQt3341InBlock.BlockName, XQt3341InBlock.F.gubun, 0, gubun.ToString()); // char 1
				instance.SetFieldData(XQt3341InBlock.BlockName, XQt3341InBlock.F.gubun1, 0, gubun1.ToString()); // char 1
				instance.SetFieldData(XQt3341InBlock.BlockName, XQt3341InBlock.F.gubun2, 0, gubun2.ToString()); // char 1
				instance.SetFieldData(XQt3341InBlock.BlockName, XQt3341InBlock.F.idx, 0, idx.ToString("d4")); // long 4

				if (instance.Request() < 0)
				{
					return null;
				}

				var outBlock = instance.GetBlock1s();
				return outBlock;
			}
		}

		public bool SetBlock(XQt3341InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "gubun", 0, block.gubun.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "gubun1", 0, block.gubun1.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "gubun2", 0, block.gubun2.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "idx", 0, block.idx.ToString("d4")); // long 4

			return true;
		}

		public XQt3341OutBlock GetBlock()
		{
			XQt3341OutBlock instance = XQt3341OutBlock.FromQuery(this);
			return instance;

		}

		public XQt3341OutBlock1[] GetBlock1s()
		{
			XQt3341OutBlock1[] instance = XQt3341OutBlock1.ListFromQuery(this);
			return instance;

		}


	}

}
