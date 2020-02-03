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
		static readonly string _blockName = "t1533InBlock";
		/// <summary>
		/// 기본입력
		/// </summary>
		static readonly string _blockDesc = "기본입력";
		/// <summary>
		/// input
		/// </summary>
		static readonly string _blockType = "input";
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _hasOccurs = false;
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
		[XAQueryFieldAttribute("구분")]
		public char gubun;
		/// <summary>
		/// 대비일자
		/// </summary>
		[XAQueryFieldAttribute("대비일자")]
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
		static readonly string _blockName = "t1533OutBlock";
		/// <summary>
		/// 출력
		/// </summary>
		static readonly string _blockDesc = "출력";
		/// <summary>
		/// output
		/// </summary>
		static readonly string _blockType = "output";
		/// <summary>
		/// true
		/// </summary>
		static readonly bool _hasOccurs = true;
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
		[XAQueryFieldAttribute("테마명")]
		public string tmname;
		/// <summary>
		/// 전체
		/// </summary>
		[XAQueryFieldAttribute("전체")]
		public long totcnt;
		/// <summary>
		/// 상승
		/// </summary>
		[XAQueryFieldAttribute("상승")]
		public long upcnt;
		/// <summary>
		/// 하락
		/// </summary>
		[XAQueryFieldAttribute("하락")]
		public long dncnt;
		/// <summary>
		/// 상승비율
		/// </summary>
		[XAQueryFieldAttribute("상승비율")]
		public float uprate;
		/// <summary>
		/// 거래증가율
		/// </summary>
		[XAQueryFieldAttribute("거래증가율")]
		public float diff_vol;
		/// <summary>
		/// 평균등락율
		/// </summary>
		[XAQueryFieldAttribute("평균등락율")]
		public float avgdiff;
		/// <summary>
		/// 대비등락율
		/// </summary>
		[XAQueryFieldAttribute("대비등락율")]
		public float chgdiff;
		/// <summary>
		/// 테마코드
		/// </summary>
		[XAQueryFieldAttribute("테마코드")]
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
			if (tmname.Length > 36) return false; // char 36
			if (totcnt.ToString().Length > 4) return false; // long 4
			if (upcnt.ToString().Length > 4) return false; // long 4
			if (dncnt.ToString().Length > 4) return false; // long 4
			// uprate float 6.2
			// diff_vol float 10.2
			// avgdiff float 6.2
			// chgdiff float 6.2
			if (tmcode.Length > 4) return false; // char 4

			return true;
		}
	}

	public partial class XQt1533 : XingQuery
	{
		/// <summary>
		/// t1533
		/// </summary>
		static readonly string _typeName = "t1533";
		/// <summary>
		/// 특이테마(t1533)
		/// </summary>
		static readonly string _typeDesc = "특이테마(t1533)";
		/// <summary>
		/// 
		/// </summary>
		static readonly string _service = "";
		/// <summary>
		/// A
		/// </summary>
		static readonly string _headType = "A";
		/// <summary>
		/// 
		/// </summary>
		static readonly string _creator = "";
		/// <summary>
		/// 
		/// </summary>
		static readonly string _createdDate = "";
		/// <summary>
		/// true
		/// </summary>
		static readonly bool _attr = true;
		/// <summary>
		/// true
		/// </summary>
		static readonly bool _block = true;
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _encrypt = false;
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _signature = false;

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

		public XQt1533() : base("t1533") { }


		public bool SetFields(XQt1533InBlock block)
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


	}

}
