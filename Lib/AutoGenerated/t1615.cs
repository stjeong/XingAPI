using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1615InBlock : XingBlock
	{
		/// <summary>
		/// t1615InBlock
		/// </summary>
		public const string _blockName = "t1615InBlock";
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
		/// t1615InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1615InBlock
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
		/// 주식구분
		/// </summary>
		[XAQueryFieldAttribute("주식구분")]
		public char gubun1;
		/// <summary>
		/// 옵션구분
		/// </summary>
		[XAQueryFieldAttribute("옵션구분")]
		public char gubun2;

		public static class F
		{
			/// <summary>
			/// 주식구분
			/// </summary>
			public const string gubun1 = "gubun1";
			/// <summary>
			/// 옵션구분
			/// </summary>
			public const string gubun2 = "gubun2";
		}

		public static string[] AllFields = new string[]
		{
			F.gubun1,
			F.gubun2,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["gubun1"] = new XAQueryFieldInfo("char", gubun1, gubun1.ToString(), "주식구분", (decimal)1);
			dict["gubun2"] = new XAQueryFieldInfo("char", gubun2, gubun2.ToString(), "옵션구분", (decimal)1);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "gubun1":
					this.gubun1 = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "gubun2":
					this.gubun2 = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public bool VerifyData()
		{
			// gubun1 char 1
			// gubun2 char 1

			return true;
		}
	}

	public partial class XQt1615OutBlock : XingBlock
	{
		/// <summary>
		/// t1615OutBlock
		/// </summary>
		public const string _blockName = "t1615OutBlock";
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
		/// t1615OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1615OutBlock
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
		/// 위탁매도수량
		/// </summary>
		[XAQueryFieldAttribute("위탁매도수량")]
		public long dwvolume;
		/// <summary>
		/// 위탁매도금액
		/// </summary>
		[XAQueryFieldAttribute("위탁매도금액")]
		public long dwvalue;
		/// <summary>
		/// 자기매도수량
		/// </summary>
		[XAQueryFieldAttribute("자기매도수량")]
		public long djvolume;
		/// <summary>
		/// 자기매도금액
		/// </summary>
		[XAQueryFieldAttribute("자기매도금액")]
		public long djvalue;
		/// <summary>
		/// 합계수량
		/// </summary>
		[XAQueryFieldAttribute("합계수량")]
		public long sum_volume;
		/// <summary>
		/// 합계금액
		/// </summary>
		[XAQueryFieldAttribute("합계금액")]
		public long sum_value;

		public static class F
		{
			/// <summary>
			/// 위탁매도수량
			/// </summary>
			public const string dwvolume = "dwvolume";
			/// <summary>
			/// 위탁매도금액
			/// </summary>
			public const string dwvalue = "dwvalue";
			/// <summary>
			/// 자기매도수량
			/// </summary>
			public const string djvolume = "djvolume";
			/// <summary>
			/// 자기매도금액
			/// </summary>
			public const string djvalue = "djvalue";
			/// <summary>
			/// 합계수량
			/// </summary>
			public const string sum_volume = "sum_volume";
			/// <summary>
			/// 합계금액
			/// </summary>
			public const string sum_value = "sum_value";
		}

		public static string[] AllFields = new string[]
		{
			F.dwvolume,
			F.dwvalue,
			F.djvolume,
			F.djvalue,
			F.sum_volume,
			F.sum_value,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["dwvolume"] = new XAQueryFieldInfo("long", dwvolume, dwvolume.ToString("d12"), "위탁매도수량", (decimal)12);
			dict["dwvalue"] = new XAQueryFieldInfo("long", dwvalue, dwvalue.ToString("d12"), "위탁매도금액", (decimal)12);
			dict["djvolume"] = new XAQueryFieldInfo("long", djvolume, djvolume.ToString("d12"), "자기매도수량", (decimal)12);
			dict["djvalue"] = new XAQueryFieldInfo("long", djvalue, djvalue.ToString("d12"), "자기매도금액", (decimal)12);
			dict["sum_volume"] = new XAQueryFieldInfo("long", sum_volume, sum_volume.ToString("d12"), "합계수량", (decimal)12);
			dict["sum_value"] = new XAQueryFieldInfo("long", sum_value, sum_value.ToString("d12"), "합계금액", (decimal)12);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "dwvolume":
					this.dwvolume = fieldInfo.FieldValue.ParseLong("dwvolume");
				break;

				case "dwvalue":
					this.dwvalue = fieldInfo.FieldValue.ParseLong("dwvalue");
				break;

				case "djvolume":
					this.djvolume = fieldInfo.FieldValue.ParseLong("djvolume");
				break;

				case "djvalue":
					this.djvalue = fieldInfo.FieldValue.ParseLong("djvalue");
				break;

				case "sum_volume":
					this.sum_volume = fieldInfo.FieldValue.ParseLong("sum_volume");
				break;

				case "sum_value":
					this.sum_value = fieldInfo.FieldValue.ParseLong("sum_value");
				break;


			}
		}

		public static XQt1615OutBlock FromQuery(XQt1615 query)
		{
			XQt1615OutBlock block = new XQt1615OutBlock();
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
				block.dwvolume = query.GetFieldData(block.GetBlockName(), "dwvolume", 0).ParseLong("dwvolume"); // long 12
				block.dwvalue = query.GetFieldData(block.GetBlockName(), "dwvalue", 0).ParseLong("dwvalue"); // long 12
				block.djvolume = query.GetFieldData(block.GetBlockName(), "djvolume", 0).ParseLong("djvolume"); // long 12
				block.djvalue = query.GetFieldData(block.GetBlockName(), "djvalue", 0).ParseLong("djvalue"); // long 12
				block.sum_volume = query.GetFieldData(block.GetBlockName(), "sum_volume", 0).ParseLong("sum_volume"); // long 12
				block.sum_value = query.GetFieldData(block.GetBlockName(), "sum_value", 0).ParseLong("sum_value"); // long 12

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (dwvolume.ToString().Length > 12) return false; // long 12
			if (dwvalue.ToString().Length > 12) return false; // long 12
			if (djvolume.ToString().Length > 12) return false; // long 12
			if (djvalue.ToString().Length > 12) return false; // long 12
			if (sum_volume.ToString().Length > 12) return false; // long 12
			if (sum_value.ToString().Length > 12) return false; // long 12

			return true;
		}
	}

	public partial class XQt1615OutBlock1 : XingBlock
	{
		/// <summary>
		/// t1615OutBlock1
		/// </summary>
		public const string _blockName = "t1615OutBlock1";
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
		/// t1615OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1615OutBlock1
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
		/// 시장명
		/// </summary>
		[XAQueryFieldAttribute("시장명")]
		public string hname;
		/// <summary>
		/// 개인
		/// </summary>
		[XAQueryFieldAttribute("개인")]
		public long sv_08;
		/// <summary>
		/// 외국인
		/// </summary>
		[XAQueryFieldAttribute("외국인")]
		public long sv_17;
		/// <summary>
		/// 기관계
		/// </summary>
		[XAQueryFieldAttribute("기관계")]
		public long sv_18;
		/// <summary>
		/// 증권
		/// </summary>
		[XAQueryFieldAttribute("증권")]
		public long sv_07;

		public static class F
		{
			/// <summary>
			/// 시장명
			/// </summary>
			public const string hname = "hname";
			/// <summary>
			/// 개인
			/// </summary>
			public const string sv_08 = "sv_08";
			/// <summary>
			/// 외국인
			/// </summary>
			public const string sv_17 = "sv_17";
			/// <summary>
			/// 기관계
			/// </summary>
			public const string sv_18 = "sv_18";
			/// <summary>
			/// 증권
			/// </summary>
			public const string sv_07 = "sv_07";
		}

		public static string[] AllFields = new string[]
		{
			F.hname,
			F.sv_08,
			F.sv_17,
			F.sv_18,
			F.sv_07,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["hname"] = new XAQueryFieldInfo("char", hname, hname, "시장명", (decimal)20);
			dict["sv_08"] = new XAQueryFieldInfo("long", sv_08, sv_08.ToString("d12"), "개인", (decimal)12);
			dict["sv_17"] = new XAQueryFieldInfo("long", sv_17, sv_17.ToString("d12"), "외국인", (decimal)12);
			dict["sv_18"] = new XAQueryFieldInfo("long", sv_18, sv_18.ToString("d12"), "기관계", (decimal)12);
			dict["sv_07"] = new XAQueryFieldInfo("long", sv_07, sv_07.ToString("d12"), "증권", (decimal)12);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "hname":
					this.hname = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "sv_08":
					this.sv_08 = fieldInfo.FieldValue.ParseLong("sv_08");
				break;

				case "sv_17":
					this.sv_17 = fieldInfo.FieldValue.ParseLong("sv_17");
				break;

				case "sv_18":
					this.sv_18 = fieldInfo.FieldValue.ParseLong("sv_18");
				break;

				case "sv_07":
					this.sv_07 = fieldInfo.FieldValue.ParseLong("sv_07");
				break;


			}
		}

		public static XQt1615OutBlock1[] ListFromQuery(XQt1615 query)
		{
			int count = query.GetBlockCount(XQt1615OutBlock1.BlockName);
			List<XQt1615OutBlock1> list = new List<XQt1615OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1615OutBlock1 block = new XQt1615OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.hname = query.GetFieldData(block.GetBlockName(), "hname", i).TrimEnd('?'); // char 20
					block.sv_08 = query.GetFieldData(block.GetBlockName(), "sv_08", i).ParseLong("sv_08"); // long 12
					block.sv_17 = query.GetFieldData(block.GetBlockName(), "sv_17", i).ParseLong("sv_17"); // long 12
					block.sv_18 = query.GetFieldData(block.GetBlockName(), "sv_18", i).ParseLong("sv_18"); // long 12
					block.sv_07 = query.GetFieldData(block.GetBlockName(), "sv_07", i).ParseLong("sv_07"); // long 12

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
			if (hname?.Length > 20) return false; // char 20
			if (sv_08.ToString().Length > 12) return false; // long 12
			if (sv_17.ToString().Length > 12) return false; // long 12
			if (sv_18.ToString().Length > 12) return false; // long 12
			if (sv_07.ToString().Length > 12) return false; // long 12

			return true;
		}
	}

	/// <summary>
	/// 투자자매매종합1(t1615)
	/// </summary>
	public partial class XQt1615 : XingQuery
	{
		/// <summary>
		/// t1615
		/// </summary>
		public const string _typeName = "t1615";
		/// <summary>
		/// 투자자매매종합1(t1615)
		/// </summary>
		public const string _typeDesc = "투자자매매종합1(t1615)";
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
		/// t1615
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 투자자매매종합1(t1615)
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
		/// 투자자매매종합1(t1615)
		/// </summary>
		public XQt1615() : base("t1615") { }


		public class XQAllOutBlocks
		{
			public XQt1615OutBlock OutBlock { get; internal set; }
			public XQt1615OutBlock1[] OutBlock1 { get; internal set; }
		}

		public static XQAllOutBlocks Get(char gubun1 = default,char gubun2 = default)
		{
			using (XQt1615 instance = new XQt1615())
			{
				instance.SetFieldData(XQt1615InBlock.BlockName, XQt1615InBlock.F.gubun1, 0, gubun1.ToString()); // char 1
				instance.SetFieldData(XQt1615InBlock.BlockName, XQt1615InBlock.F.gubun2, 0, gubun2.ToString()); // char 1

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

		public bool SetBlock(XQt1615InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "gubun1", 0, block.gubun1.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "gubun2", 0, block.gubun2.ToString()); // char 1

			return true;
		}

		public XQt1615OutBlock GetBlock()
		{
			XQt1615OutBlock instance = XQt1615OutBlock.FromQuery(this);
			return instance;

		}

		public XQt1615OutBlock1[] GetBlock1s()
		{
			XQt1615OutBlock1[] instance = XQt1615OutBlock1.ListFromQuery(this);
			return instance;

		}


	}

}
