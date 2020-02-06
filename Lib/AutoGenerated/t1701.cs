using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1701InBlock : XingBlock
	{
		/// <summary>
		/// t1701InBlock
		/// </summary>
		public const string _blockName = "t1701InBlock";
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
		/// t1701InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1701InBlock
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
		[XAQueryFieldAttribute("종목코드")]
		public string shcode;
		/// <summary>
		/// 구분
		/// </summary>
		[XAQueryFieldAttribute("구분")]
		public char gubun;
		/// <summary>
		/// 시작일자
		/// </summary>
		[XAQueryFieldAttribute("시작일자")]
		public string fromdt;
		/// <summary>
		/// 종료일자
		/// </summary>
		[XAQueryFieldAttribute("종료일자")]
		public string todt;
		/// <summary>
		/// PR적용
		/// </summary>
		[XAQueryFieldAttribute("PR적용")]
		public long prapp;
		/// <summary>
		/// PR적용구분
		/// </summary>
		[XAQueryFieldAttribute("PR적용구분")]
		public char prgubun;
		/// <summary>
		/// 기관적용
		/// </summary>
		[XAQueryFieldAttribute("기관적용")]
		public char orggubun;
		/// <summary>
		/// 외인적용
		/// </summary>
		[XAQueryFieldAttribute("외인적용")]
		public char frggubun;

		public static class F
		{
			/// <summary>
			/// 종목코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 구분
			/// </summary>
			public const string gubun = "gubun";
			/// <summary>
			/// 시작일자
			/// </summary>
			public const string fromdt = "fromdt";
			/// <summary>
			/// 종료일자
			/// </summary>
			public const string todt = "todt";
			/// <summary>
			/// PR적용
			/// </summary>
			public const string prapp = "prapp";
			/// <summary>
			/// PR적용구분
			/// </summary>
			public const string prgubun = "prgubun";
			/// <summary>
			/// 기관적용
			/// </summary>
			public const string orggubun = "orggubun";
			/// <summary>
			/// 외인적용
			/// </summary>
			public const string frggubun = "frggubun";
		}

		public static string[] AllFields = new string[]
		{
			F.shcode,
			F.gubun,
			F.fromdt,
			F.todt,
			F.prapp,
			F.prgubun,
			F.orggubun,
			F.frggubun,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "종목코드", (decimal)6);
			dict["gubun"] = new XAQueryFieldInfo("char", gubun, gubun.ToString(), "구분", (decimal)1);
			dict["fromdt"] = new XAQueryFieldInfo("char", fromdt, fromdt, "시작일자", (decimal)8);
			dict["todt"] = new XAQueryFieldInfo("char", todt, todt, "종료일자", (decimal)8);
			dict["prapp"] = new XAQueryFieldInfo("long", prapp, prapp.ToString("d3"), "PR적용", (decimal)3);
			dict["prgubun"] = new XAQueryFieldInfo("char", prgubun, prgubun.ToString(), "PR적용구분", (decimal)1);
			dict["orggubun"] = new XAQueryFieldInfo("char", orggubun, orggubun.ToString(), "기관적용", (decimal)1);
			dict["frggubun"] = new XAQueryFieldInfo("char", frggubun, frggubun.ToString(), "외인적용", (decimal)1);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "gubun":
					this.gubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "fromdt":
					this.fromdt = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "todt":
					this.todt = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "prapp":
					this.prapp = fieldInfo.FieldValue.ParseLong("prapp");
				break;

				case "prgubun":
					this.prgubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "orggubun":
					this.orggubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "frggubun":
					this.frggubun = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public bool VerifyData()
		{
			if (shcode?.Length > 6) return false; // char 6
			// gubun char 1
			if (fromdt?.Length > 8) return false; // char 8
			if (todt?.Length > 8) return false; // char 8
			if (prapp.ToString().Length > 3) return false; // long 3
			// prgubun char 1
			// orggubun char 1
			// frggubun char 1

			return true;
		}
	}

	public partial class XQt1701OutBlock : XingBlock
	{
		/// <summary>
		/// t1701OutBlock
		/// </summary>
		public const string _blockName = "t1701OutBlock";
		/// <summary>
		/// 출력
		/// </summary>
		public const string _blockDesc = "출력";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// true
		/// </summary>
		public const bool _hasOccurs = true;
		/// <summary>
		/// t1701OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1701OutBlock
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
		/// true
		/// </summary>
		public bool HasOccurs => _hasOccurs;

		/// <summary>
		/// 일자
		/// </summary>
		[XAQueryFieldAttribute("일자")]
		public string date;
		/// <summary>
		/// 종가
		/// </summary>
		[XAQueryFieldAttribute("종가")]
		public long close;
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
		/// 개인
		/// </summary>
		[XAQueryFieldAttribute("개인")]
		public long psnvolume;
		/// <summary>
		/// 기관
		/// </summary>
		[XAQueryFieldAttribute("기관")]
		public long orgvolume;
		/// <summary>
		/// 외국인
		/// </summary>
		[XAQueryFieldAttribute("외국인")]
		public long frgvolume;
		/// <summary>
		/// 외국계
		/// </summary>
		[XAQueryFieldAttribute("외국계")]
		public long frgvolumesum;
		/// <summary>
		/// 프로그램
		/// </summary>
		[XAQueryFieldAttribute("프로그램")]
		public long pgmvolume;
		/// <summary>
		/// 보유주식수
		/// </summary>
		[XAQueryFieldAttribute("보유주식수")]
		public long listing;
		/// <summary>
		/// 발행증감
		/// </summary>
		[XAQueryFieldAttribute("발행증감")]
		public long listupdn;
		/// <summary>
		/// 소진율
		/// </summary>
		[XAQueryFieldAttribute("소진율")]
		public float sjrate;

		public static class F
		{
			/// <summary>
			/// 일자
			/// </summary>
			public const string date = "date";
			/// <summary>
			/// 종가
			/// </summary>
			public const string close = "close";
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
			/// 개인
			/// </summary>
			public const string psnvolume = "psnvolume";
			/// <summary>
			/// 기관
			/// </summary>
			public const string orgvolume = "orgvolume";
			/// <summary>
			/// 외국인
			/// </summary>
			public const string frgvolume = "frgvolume";
			/// <summary>
			/// 외국계
			/// </summary>
			public const string frgvolumesum = "frgvolumesum";
			/// <summary>
			/// 프로그램
			/// </summary>
			public const string pgmvolume = "pgmvolume";
			/// <summary>
			/// 보유주식수
			/// </summary>
			public const string listing = "listing";
			/// <summary>
			/// 발행증감
			/// </summary>
			public const string listupdn = "listupdn";
			/// <summary>
			/// 소진율
			/// </summary>
			public const string sjrate = "sjrate";
		}

		public static string[] AllFields = new string[]
		{
			F.date,
			F.close,
			F.sign,
			F.change,
			F.diff,
			F.volume,
			F.psnvolume,
			F.orgvolume,
			F.frgvolume,
			F.frgvolumesum,
			F.pgmvolume,
			F.listing,
			F.listupdn,
			F.sjrate,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["date"] = new XAQueryFieldInfo("char", date, date, "일자", (decimal)8);
			dict["close"] = new XAQueryFieldInfo("long", close, close.ToString("d8"), "종가", (decimal)8);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("long", change, change.ToString("d8"), "전일대비", (decimal)8);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "누적거래량", (decimal)12);
			dict["psnvolume"] = new XAQueryFieldInfo("long", psnvolume, psnvolume.ToString("d12"), "개인", (decimal)12);
			dict["orgvolume"] = new XAQueryFieldInfo("long", orgvolume, orgvolume.ToString("d12"), "기관", (decimal)12);
			dict["frgvolume"] = new XAQueryFieldInfo("long", frgvolume, frgvolume.ToString("d12"), "외국인", (decimal)12);
			dict["frgvolumesum"] = new XAQueryFieldInfo("long", frgvolumesum, frgvolumesum.ToString("d12"), "외국계", (decimal)12);
			dict["pgmvolume"] = new XAQueryFieldInfo("long", pgmvolume, pgmvolume.ToString("d12"), "프로그램", (decimal)12);
			dict["listing"] = new XAQueryFieldInfo("long", listing, listing.ToString("d12"), "보유주식수", (decimal)12);
			dict["listupdn"] = new XAQueryFieldInfo("long", listupdn, listupdn.ToString("d12"), "발행증감", (decimal)12);
			dict["sjrate"] = new XAQueryFieldInfo("float", sjrate, sjrate.ToString("000000.00"), "소진율", (decimal)6.2);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "date":
					this.date = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "close":
					this.close = fieldInfo.FieldValue.ParseLong("close");
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

				case "psnvolume":
					this.psnvolume = fieldInfo.FieldValue.ParseLong("psnvolume");
				break;

				case "orgvolume":
					this.orgvolume = fieldInfo.FieldValue.ParseLong("orgvolume");
				break;

				case "frgvolume":
					this.frgvolume = fieldInfo.FieldValue.ParseLong("frgvolume");
				break;

				case "frgvolumesum":
					this.frgvolumesum = fieldInfo.FieldValue.ParseLong("frgvolumesum");
				break;

				case "pgmvolume":
					this.pgmvolume = fieldInfo.FieldValue.ParseLong("pgmvolume");
				break;

				case "listing":
					this.listing = fieldInfo.FieldValue.ParseLong("listing");
				break;

				case "listupdn":
					this.listupdn = fieldInfo.FieldValue.ParseLong("listupdn");
				break;

				case "sjrate":
					this.sjrate = fieldInfo.FieldValue.ParseFloat("sjrate");
				break;


			}
		}

		public static XQt1701OutBlock[] ListFromQuery(XQt1701 query)
		{
			int count = query.GetBlockCount(XQt1701OutBlock.BlockName);
			List<XQt1701OutBlock> list = new List<XQt1701OutBlock>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1701OutBlock block = new XQt1701OutBlock();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.date = query.GetFieldData(block.GetBlockName(), "date", i).TrimEnd('?'); // char 8
					block.close = query.GetFieldData(block.GetBlockName(), "close", i).ParseLong("close"); // long 8
					block.sign = query.GetFieldData(block.GetBlockName(), "sign", i).FirstOrDefault(); // char 1
					block.change = query.GetFieldData(block.GetBlockName(), "change", i).ParseLong("change"); // long 8
					block.diff = query.GetFieldData(block.GetBlockName(), "diff", i).ParseFloat("diff"); // float 6.2
					block.volume = query.GetFieldData(block.GetBlockName(), "volume", i).ParseLong("volume"); // long 12
					block.psnvolume = query.GetFieldData(block.GetBlockName(), "psnvolume", i).ParseLong("psnvolume"); // long 12
					block.orgvolume = query.GetFieldData(block.GetBlockName(), "orgvolume", i).ParseLong("orgvolume"); // long 12
					block.frgvolume = query.GetFieldData(block.GetBlockName(), "frgvolume", i).ParseLong("frgvolume"); // long 12
					block.frgvolumesum = query.GetFieldData(block.GetBlockName(), "frgvolumesum", i).ParseLong("frgvolumesum"); // long 12
					block.pgmvolume = query.GetFieldData(block.GetBlockName(), "pgmvolume", i).ParseLong("pgmvolume"); // long 12
					block.listing = query.GetFieldData(block.GetBlockName(), "listing", i).ParseLong("listing"); // long 12
					block.listupdn = query.GetFieldData(block.GetBlockName(), "listupdn", i).ParseLong("listupdn"); // long 12
					block.sjrate = query.GetFieldData(block.GetBlockName(), "sjrate", i).ParseFloat("sjrate"); // float 6.2

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
			if (close.ToString().Length > 8) return false; // long 8
			// sign char 1
			if (change.ToString().Length > 8) return false; // long 8
			// diff float 6.2
			if (volume.ToString().Length > 12) return false; // long 12
			if (psnvolume.ToString().Length > 12) return false; // long 12
			if (orgvolume.ToString().Length > 12) return false; // long 12
			if (frgvolume.ToString().Length > 12) return false; // long 12
			if (frgvolumesum.ToString().Length > 12) return false; // long 12
			if (pgmvolume.ToString().Length > 12) return false; // long 12
			if (listing.ToString().Length > 12) return false; // long 12
			if (listupdn.ToString().Length > 12) return false; // long 12
			// sjrate float 6.2

			return true;
		}
	}

	/// <summary>
	/// 외인기관종목별동향(t1701)
	/// </summary>
	public partial class XQt1701 : XingQuery
	{
		/// <summary>
		/// t1701
		/// </summary>
		public const string _typeName = "t1701";
		/// <summary>
		/// 외인기관종목별동향(t1701)
		/// </summary>
		public const string _typeDesc = "외인기관종목별동향(t1701)";
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
		/// t1701
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 외인기관종목별동향(t1701)
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

		public XQt1701() : base("t1701") { }


		public static XQt1701OutBlock[] Get(string shcode = default,char gubun = default,string fromdt = default,string todt = default,long prapp = default,char prgubun = default,char orggubun = default,char frggubun = default)
		{
			using (XQt1701 instance = new XQt1701())
			{
				instance.SetFieldData(XQt1701InBlock.BlockName, XQt1701InBlock.F.shcode, 0, shcode); // char 6
				instance.SetFieldData(XQt1701InBlock.BlockName, XQt1701InBlock.F.gubun, 0, gubun.ToString()); // char 1
				instance.SetFieldData(XQt1701InBlock.BlockName, XQt1701InBlock.F.fromdt, 0, fromdt); // char 8
				instance.SetFieldData(XQt1701InBlock.BlockName, XQt1701InBlock.F.todt, 0, todt); // char 8
				instance.SetFieldData(XQt1701InBlock.BlockName, XQt1701InBlock.F.prapp, 0, prapp.ToString("d3")); // long 3
				instance.SetFieldData(XQt1701InBlock.BlockName, XQt1701InBlock.F.prgubun, 0, prgubun.ToString()); // char 1
				instance.SetFieldData(XQt1701InBlock.BlockName, XQt1701InBlock.F.orggubun, 0, orggubun.ToString()); // char 1
				instance.SetFieldData(XQt1701InBlock.BlockName, XQt1701InBlock.F.frggubun, 0, frggubun.ToString()); // char 1

				if (instance.Request() < 0)
				{
					return null;
				}

				var outBlock = instance.GetBlocks();
				return outBlock;
			}
		}

		public bool SetBlock(XQt1701InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "shcode", 0, block.shcode); // char 6
			_xaQuery.SetFieldData(block.GetBlockName(), "gubun", 0, block.gubun.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "fromdt", 0, block.fromdt); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "todt", 0, block.todt); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "prapp", 0, block.prapp.ToString("d3")); // long 3
			_xaQuery.SetFieldData(block.GetBlockName(), "prgubun", 0, block.prgubun.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "orggubun", 0, block.orggubun.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "frggubun", 0, block.frggubun.ToString()); // char 1

			return true;
		}

		public XQt1701OutBlock[] GetBlocks()
		{
			XQt1701OutBlock[] instance = XQt1701OutBlock.ListFromQuery(this);
			return instance;

		}


	}

}
