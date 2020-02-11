using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1533InBlock : XingBlock
	{
		/// <summary>
		/// t1533InBlock
		/// </summary>
		public const string _blockName = "t1533InBlock";
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
		/// t1533InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1533InBlock
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
		[XAQueryFieldAttribute("gubun", "구분", "char", "1")]
		public char gubun;
		/// <summary>
		/// 대비일자
		/// </summary>
		[XAQueryFieldAttribute("chgdate", "대비일자", "long", "2")]
		public long chgdate;

		public static class F
		{
			/// <summary>
			/// 구분
			/// </summary>
			public const string gubun = "gubun";
			/// <summary>
			/// 대비일자
			/// </summary>
			public const string chgdate = "chgdate";
		}

		public static string[] AllFields = new string[]
		{
			F.gubun,
			F.chgdate,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["gubun"] = new XAQueryFieldInfo("char", gubun, gubun.ToString(), "구분", (decimal)1);
			dict["chgdate"] = new XAQueryFieldInfo("long", chgdate, chgdate.ToString("d2"), "대비일자", (decimal)2);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "gubun":
					this.gubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "chgdate":
					this.chgdate = fieldInfo.FieldValue.ParseLong("chgdate");
				break;


			}
		}

		public bool VerifyData()
		{
			// gubun char 1
			if (chgdate.ToString().Length > 2) return false; // long 2

			return true;
		}
	}

	public partial class XQt1533OutBlock : XingBlock
	{
		/// <summary>
		/// t1533OutBlock
		/// </summary>
		public const string _blockName = "t1533OutBlock";
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
		/// t1533OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1533OutBlock
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
		/// 테마명
		/// </summary>
		[XAQueryFieldAttribute("tmname", "테마명", "char", "36")]
		public string tmname;
		/// <summary>
		/// 전체
		/// </summary>
		[XAQueryFieldAttribute("totcnt", "전체", "long", "4")]
		public long totcnt;
		/// <summary>
		/// 상승
		/// </summary>
		[XAQueryFieldAttribute("upcnt", "상승", "long", "4")]
		public long upcnt;
		/// <summary>
		/// 하락
		/// </summary>
		[XAQueryFieldAttribute("dncnt", "하락", "long", "4")]
		public long dncnt;
		/// <summary>
		/// 상승비율
		/// </summary>
		[XAQueryFieldAttribute("uprate", "상승비율", "float", "6.2")]
		public float uprate;
		/// <summary>
		/// 거래증가율
		/// </summary>
		[XAQueryFieldAttribute("diff_vol", "거래증가율", "float", "10.2")]
		public float diff_vol;
		/// <summary>
		/// 평균등락율
		/// </summary>
		[XAQueryFieldAttribute("avgdiff", "평균등락율", "float", "6.2")]
		public float avgdiff;
		/// <summary>
		/// 대비등락율
		/// </summary>
		[XAQueryFieldAttribute("chgdiff", "대비등락율", "float", "6.2")]
		public float chgdiff;
		/// <summary>
		/// 테마코드
		/// </summary>
		[XAQueryFieldAttribute("tmcode", "테마코드", "char", "4")]
		public string tmcode;

		public static class F
		{
			/// <summary>
			/// 테마명
			/// </summary>
			public const string tmname = "tmname";
			/// <summary>
			/// 전체
			/// </summary>
			public const string totcnt = "totcnt";
			/// <summary>
			/// 상승
			/// </summary>
			public const string upcnt = "upcnt";
			/// <summary>
			/// 하락
			/// </summary>
			public const string dncnt = "dncnt";
			/// <summary>
			/// 상승비율
			/// </summary>
			public const string uprate = "uprate";
			/// <summary>
			/// 거래증가율
			/// </summary>
			public const string diff_vol = "diff_vol";
			/// <summary>
			/// 평균등락율
			/// </summary>
			public const string avgdiff = "avgdiff";
			/// <summary>
			/// 대비등락율
			/// </summary>
			public const string chgdiff = "chgdiff";
			/// <summary>
			/// 테마코드
			/// </summary>
			public const string tmcode = "tmcode";
		}

		public static string[] AllFields = new string[]
		{
			F.tmname,
			F.totcnt,
			F.upcnt,
			F.dncnt,
			F.uprate,
			F.diff_vol,
			F.avgdiff,
			F.chgdiff,
			F.tmcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["tmname"] = new XAQueryFieldInfo("char", tmname, tmname, "테마명", (decimal)36);
			dict["totcnt"] = new XAQueryFieldInfo("long", totcnt, totcnt.ToString("d4"), "전체", (decimal)4);
			dict["upcnt"] = new XAQueryFieldInfo("long", upcnt, upcnt.ToString("d4"), "상승", (decimal)4);
			dict["dncnt"] = new XAQueryFieldInfo("long", dncnt, dncnt.ToString("d4"), "하락", (decimal)4);
			dict["uprate"] = new XAQueryFieldInfo("float", uprate, uprate.ToString("000000.00"), "상승비율", (decimal)6.2);
			dict["diff_vol"] = new XAQueryFieldInfo("float", diff_vol, diff_vol.ToString("0000000000.00"), "거래증가율", (decimal)10.2);
			dict["avgdiff"] = new XAQueryFieldInfo("float", avgdiff, avgdiff.ToString("000000.00"), "평균등락율", (decimal)6.2);
			dict["chgdiff"] = new XAQueryFieldInfo("float", chgdiff, chgdiff.ToString("000000.00"), "대비등락율", (decimal)6.2);
			dict["tmcode"] = new XAQueryFieldInfo("char", tmcode, tmcode, "테마코드", (decimal)4);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "tmname":
					this.tmname = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "totcnt":
					this.totcnt = fieldInfo.FieldValue.ParseLong("totcnt");
				break;

				case "upcnt":
					this.upcnt = fieldInfo.FieldValue.ParseLong("upcnt");
				break;

				case "dncnt":
					this.dncnt = fieldInfo.FieldValue.ParseLong("dncnt");
				break;

				case "uprate":
					this.uprate = fieldInfo.FieldValue.ParseFloat("uprate");
				break;

				case "diff_vol":
					this.diff_vol = fieldInfo.FieldValue.ParseFloat("diff_vol");
				break;

				case "avgdiff":
					this.avgdiff = fieldInfo.FieldValue.ParseFloat("avgdiff");
				break;

				case "chgdiff":
					this.chgdiff = fieldInfo.FieldValue.ParseFloat("chgdiff");
				break;

				case "tmcode":
					this.tmcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt1533OutBlock[] ListFromQuery(XQt1533 query)
		{
			int count = query.GetBlockCount(XQt1533OutBlock.BlockName);
			List<XQt1533OutBlock> list = new List<XQt1533OutBlock>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1533OutBlock block = new XQt1533OutBlock();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.tmname = query.GetFieldData(block.GetBlockName(), "tmname", i).TrimEnd('?'); // char 36
					block.totcnt = query.GetFieldData(block.GetBlockName(), "totcnt", i).ParseLong("totcnt"); // long 4
					block.upcnt = query.GetFieldData(block.GetBlockName(), "upcnt", i).ParseLong("upcnt"); // long 4
					block.dncnt = query.GetFieldData(block.GetBlockName(), "dncnt", i).ParseLong("dncnt"); // long 4
					block.uprate = query.GetFieldData(block.GetBlockName(), "uprate", i).ParseFloat("uprate"); // float 6.2
					block.diff_vol = query.GetFieldData(block.GetBlockName(), "diff_vol", i).ParseFloat("diff_vol"); // float 10.2
					block.avgdiff = query.GetFieldData(block.GetBlockName(), "avgdiff", i).ParseFloat("avgdiff"); // float 6.2
					block.chgdiff = query.GetFieldData(block.GetBlockName(), "chgdiff", i).ParseFloat("chgdiff"); // float 6.2
					block.tmcode = query.GetFieldData(block.GetBlockName(), "tmcode", i).TrimEnd('?'); // char 4

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
			if (tmname?.Length > 36) return false; // char 36
			if (totcnt.ToString().Length > 4) return false; // long 4
			if (upcnt.ToString().Length > 4) return false; // long 4
			if (dncnt.ToString().Length > 4) return false; // long 4
			// uprate float 6.2
			// diff_vol float 10.2
			// avgdiff float 6.2
			// chgdiff float 6.2
			if (tmcode?.Length > 4) return false; // char 4

			return true;
		}
	}

	/// <summary>
	/// 특이테마(t1533)
	/// </summary>
	public partial class XQt1533 : XingQuery
	{
		/// <summary>
		/// t1533
		/// </summary>
		public const string _typeName = "t1533";
		/// <summary>
		/// 특이테마(t1533)
		/// </summary>
		public const string _typeDesc = "특이테마(t1533)";
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
		/// t1533
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 특이테마(t1533)
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
		/// 특이테마(t1533)
		/// </summary>
		public XQt1533() : base("t1533") { }


		public static XQt1533OutBlock[] Get(char gubun = default,long chgdate = default)
		{
			using (XQt1533 instance = new XQt1533())
			{
				instance.SetFieldData(XQt1533InBlock.BlockName, XQt1533InBlock.F.gubun, 0, gubun.ToString()); // char 1
				instance.SetFieldData(XQt1533InBlock.BlockName, XQt1533InBlock.F.chgdate, 0, chgdate.ToString("d2")); // long 2

				if (instance.Request() < 0)
				{
					return null;
				}

				var outBlock = instance.GetBlocks();
				return outBlock;
			}
		}

		public bool SetBlock(XQt1533InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "gubun", 0, block.gubun.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "chgdate", 0, block.chgdate.ToString("d2")); // long 2

			return true;
		}

		public XQt1533OutBlock[] GetBlocks()
		{
			XQt1533OutBlock[] instance = XQt1533OutBlock.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt1533OutBlock),

		};

	}

}
