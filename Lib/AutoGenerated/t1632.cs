using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1632InBlock : XingBlock
	{
		/// <summary>
		/// t1632InBlock
		/// </summary>
		public const string _blockName = "t1632InBlock";
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
		/// t1632InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1632InBlock
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
		/// 금액수량구분
		/// </summary>
		[XAQueryFieldAttribute("gubun1", "금액수량구분", "char", "1")]
		public char gubun1;
		/// <summary>
		/// 직전대비증감
		/// </summary>
		[XAQueryFieldAttribute("gubun2", "직전대비증감", "char", "1")]
		public char gubun2;
		/// <summary>
		/// 전일구분
		/// </summary>
		[XAQueryFieldAttribute("gubun3", "전일구분", "char", "1")]
		public char gubun3;
		/// <summary>
		/// 일자
		/// </summary>
		[XAQueryFieldAttribute("date", "일자", "char", "8")]
		public string date;
		/// <summary>
		/// 시간
		/// </summary>
		[XAQueryFieldAttribute("time", "시간", "char", "6")]
		public string time;

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
			/// 직전대비증감
			/// </summary>
			public const string gubun2 = "gubun2";
			/// <summary>
			/// 전일구분
			/// </summary>
			public const string gubun3 = "gubun3";
			/// <summary>
			/// 일자
			/// </summary>
			public const string date = "date";
			/// <summary>
			/// 시간
			/// </summary>
			public const string time = "time";
		}

		public static string[] AllFields = new string[]
		{
			F.gubun,
			F.gubun1,
			F.gubun2,
			F.gubun3,
			F.date,
			F.time,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["gubun"] = new XAQueryFieldInfo("char", gubun, gubun.ToString(), "구분", (decimal)1);
			dict["gubun1"] = new XAQueryFieldInfo("char", gubun1, gubun1.ToString(), "금액수량구분", (decimal)1);
			dict["gubun2"] = new XAQueryFieldInfo("char", gubun2, gubun2.ToString(), "직전대비증감", (decimal)1);
			dict["gubun3"] = new XAQueryFieldInfo("char", gubun3, gubun3.ToString(), "전일구분", (decimal)1);
			dict["date"] = new XAQueryFieldInfo("char", date, date, "일자", (decimal)8);
			dict["time"] = new XAQueryFieldInfo("char", time, time, "시간", (decimal)6);

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

				case "gubun3":
					this.gubun3 = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "date":
					this.date = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "time":
					this.time = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			// gubun char 1
			// gubun1 char 1
			// gubun2 char 1
			// gubun3 char 1
			if (date?.Length > 8) return false; // char 8
			if (time?.Length > 6) return false; // char 6

			return true;
		}
	}

	public partial class XQt1632OutBlock : XingBlock
	{
		/// <summary>
		/// t1632OutBlock
		/// </summary>
		public const string _blockName = "t1632OutBlock";
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
		/// t1632OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1632OutBlock
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
		/// 날짜CTS
		/// </summary>
		[XAQueryFieldAttribute("date", "날짜CTS", "char", "8")]
		public string date;
		/// <summary>
		/// 시간CTS
		/// </summary>
		[XAQueryFieldAttribute("time", "시간CTS", "char", "6")]
		public string time;
		/// <summary>
		/// IDX
		/// </summary>
		[XAQueryFieldAttribute("idx", "IDX", "long", "4")]
		public long idx;

		public static class F
		{
			/// <summary>
			/// 날짜CTS
			/// </summary>
			public const string date = "date";
			/// <summary>
			/// 시간CTS
			/// </summary>
			public const string time = "time";
			/// <summary>
			/// IDX
			/// </summary>
			public const string idx = "idx";
		}

		public static string[] AllFields = new string[]
		{
			F.date,
			F.time,
			F.idx,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["date"] = new XAQueryFieldInfo("char", date, date, "날짜CTS", (decimal)8);
			dict["time"] = new XAQueryFieldInfo("char", time, time, "시간CTS", (decimal)6);
			dict["idx"] = new XAQueryFieldInfo("long", idx, idx.ToString("d4"), "IDX", (decimal)4);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "date":
					this.date = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "time":
					this.time = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "idx":
					this.idx = fieldInfo.FieldValue.ParseLong("idx");
				break;


			}
		}

		public static XQt1632OutBlock FromQuery(XQt1632 query)
		{
			XQt1632OutBlock block = new XQt1632OutBlock();
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
				block.date = query.GetFieldData(block.GetBlockName(), "date", 0).TrimEnd('?'); // char 8
				block.time = query.GetFieldData(block.GetBlockName(), "time", 0).TrimEnd('?'); // char 6
				block.idx = query.GetFieldData(block.GetBlockName(), "idx", 0).ParseLong("idx"); // long 4

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (date?.Length > 8) return false; // char 8
			if (time?.Length > 6) return false; // char 6
			if (idx.ToString().Length > 4) return false; // long 4

			return true;
		}
	}

	public partial class XQt1632OutBlock1 : XingBlock
	{
		/// <summary>
		/// t1632OutBlock1
		/// </summary>
		public const string _blockName = "t1632OutBlock1";
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
		/// t1632OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1632OutBlock1
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
		[XAQueryFieldAttribute("time", "시간", "char", "6")]
		public string time;
		/// <summary>
		/// KP200
		/// </summary>
		[XAQueryFieldAttribute("k200jisu", "KP200", "float", "6.2")]
		public float k200jisu;
		/// <summary>
		/// 대비구분
		/// </summary>
		[XAQueryFieldAttribute("sign", "대비구분", "char", "1")]
		public char sign;
		/// <summary>
		/// 대비
		/// </summary>
		[XAQueryFieldAttribute("change", "대비", "float", "6.2")]
		public float change;
		/// <summary>
		/// BASIS
		/// </summary>
		[XAQueryFieldAttribute("k200basis", "BASIS", "float", "6.2")]
		public float k200basis;
		/// <summary>
		/// 전체순매수
		/// </summary>
		[XAQueryFieldAttribute("tot3", "전체순매수", "long", "12")]
		public long tot3;
		/// <summary>
		/// 전체매수
		/// </summary>
		[XAQueryFieldAttribute("tot1", "전체매수", "long", "12")]
		public long tot1;
		/// <summary>
		/// 전체매도
		/// </summary>
		[XAQueryFieldAttribute("tot2", "전체매도", "long", "12")]
		public long tot2;
		/// <summary>
		/// 차익순매수
		/// </summary>
		[XAQueryFieldAttribute("cha3", "차익순매수", "long", "12")]
		public long cha3;
		/// <summary>
		/// 차익매수
		/// </summary>
		[XAQueryFieldAttribute("cha1", "차익매수", "long", "12")]
		public long cha1;
		/// <summary>
		/// 차익매도
		/// </summary>
		[XAQueryFieldAttribute("cha2", "차익매도", "long", "12")]
		public long cha2;
		/// <summary>
		/// 비차익순매수
		/// </summary>
		[XAQueryFieldAttribute("bcha3", "비차익순매수", "long", "12")]
		public long bcha3;
		/// <summary>
		/// 비차익매수
		/// </summary>
		[XAQueryFieldAttribute("bcha1", "비차익매수", "long", "12")]
		public long bcha1;
		/// <summary>
		/// 비차익매도
		/// </summary>
		[XAQueryFieldAttribute("bcha2", "비차익매도", "long", "12")]
		public long bcha2;

		public static class F
		{
			/// <summary>
			/// 시간
			/// </summary>
			public const string time = "time";
			/// <summary>
			/// KP200
			/// </summary>
			public const string k200jisu = "k200jisu";
			/// <summary>
			/// 대비구분
			/// </summary>
			public const string sign = "sign";
			/// <summary>
			/// 대비
			/// </summary>
			public const string change = "change";
			/// <summary>
			/// BASIS
			/// </summary>
			public const string k200basis = "k200basis";
			/// <summary>
			/// 전체순매수
			/// </summary>
			public const string tot3 = "tot3";
			/// <summary>
			/// 전체매수
			/// </summary>
			public const string tot1 = "tot1";
			/// <summary>
			/// 전체매도
			/// </summary>
			public const string tot2 = "tot2";
			/// <summary>
			/// 차익순매수
			/// </summary>
			public const string cha3 = "cha3";
			/// <summary>
			/// 차익매수
			/// </summary>
			public const string cha1 = "cha1";
			/// <summary>
			/// 차익매도
			/// </summary>
			public const string cha2 = "cha2";
			/// <summary>
			/// 비차익순매수
			/// </summary>
			public const string bcha3 = "bcha3";
			/// <summary>
			/// 비차익매수
			/// </summary>
			public const string bcha1 = "bcha1";
			/// <summary>
			/// 비차익매도
			/// </summary>
			public const string bcha2 = "bcha2";
		}

		public static string[] AllFields = new string[]
		{
			F.time,
			F.k200jisu,
			F.sign,
			F.change,
			F.k200basis,
			F.tot3,
			F.tot1,
			F.tot2,
			F.cha3,
			F.cha1,
			F.cha2,
			F.bcha3,
			F.bcha1,
			F.bcha2,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["time"] = new XAQueryFieldInfo("char", time, time, "시간", (decimal)6);
			dict["k200jisu"] = new XAQueryFieldInfo("float", k200jisu, k200jisu.ToString("000000.00"), "KP200", (decimal)6.2);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("float", change, change.ToString("000000.00"), "대비", (decimal)6.2);
			dict["k200basis"] = new XAQueryFieldInfo("float", k200basis, k200basis.ToString("000000.00"), "BASIS", (decimal)6.2);
			dict["tot3"] = new XAQueryFieldInfo("long", tot3, tot3.ToString("d12"), "전체순매수", (decimal)12);
			dict["tot1"] = new XAQueryFieldInfo("long", tot1, tot1.ToString("d12"), "전체매수", (decimal)12);
			dict["tot2"] = new XAQueryFieldInfo("long", tot2, tot2.ToString("d12"), "전체매도", (decimal)12);
			dict["cha3"] = new XAQueryFieldInfo("long", cha3, cha3.ToString("d12"), "차익순매수", (decimal)12);
			dict["cha1"] = new XAQueryFieldInfo("long", cha1, cha1.ToString("d12"), "차익매수", (decimal)12);
			dict["cha2"] = new XAQueryFieldInfo("long", cha2, cha2.ToString("d12"), "차익매도", (decimal)12);
			dict["bcha3"] = new XAQueryFieldInfo("long", bcha3, bcha3.ToString("d12"), "비차익순매수", (decimal)12);
			dict["bcha1"] = new XAQueryFieldInfo("long", bcha1, bcha1.ToString("d12"), "비차익매수", (decimal)12);
			dict["bcha2"] = new XAQueryFieldInfo("long", bcha2, bcha2.ToString("d12"), "비차익매도", (decimal)12);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "time":
					this.time = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "k200jisu":
					this.k200jisu = fieldInfo.FieldValue.ParseFloat("k200jisu");
				break;

				case "sign":
					this.sign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "change":
					this.change = fieldInfo.FieldValue.ParseFloat("change");
				break;

				case "k200basis":
					this.k200basis = fieldInfo.FieldValue.ParseFloat("k200basis");
				break;

				case "tot3":
					this.tot3 = fieldInfo.FieldValue.ParseLong("tot3");
				break;

				case "tot1":
					this.tot1 = fieldInfo.FieldValue.ParseLong("tot1");
				break;

				case "tot2":
					this.tot2 = fieldInfo.FieldValue.ParseLong("tot2");
				break;

				case "cha3":
					this.cha3 = fieldInfo.FieldValue.ParseLong("cha3");
				break;

				case "cha1":
					this.cha1 = fieldInfo.FieldValue.ParseLong("cha1");
				break;

				case "cha2":
					this.cha2 = fieldInfo.FieldValue.ParseLong("cha2");
				break;

				case "bcha3":
					this.bcha3 = fieldInfo.FieldValue.ParseLong("bcha3");
				break;

				case "bcha1":
					this.bcha1 = fieldInfo.FieldValue.ParseLong("bcha1");
				break;

				case "bcha2":
					this.bcha2 = fieldInfo.FieldValue.ParseLong("bcha2");
				break;


			}
		}

		public static XQt1632OutBlock1[] ListFromQuery(XQt1632 query)
		{
			int count = query.GetBlockCount(XQt1632OutBlock1.BlockName);
			List<XQt1632OutBlock1> list = new List<XQt1632OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1632OutBlock1 block = new XQt1632OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.time = query.GetFieldData(block.GetBlockName(), "time", i).TrimEnd('?'); // char 6
					block.k200jisu = query.GetFieldData(block.GetBlockName(), "k200jisu", i).ParseFloat("k200jisu"); // float 6.2
					block.sign = query.GetFieldData(block.GetBlockName(), "sign", i).FirstOrDefault(); // char 1
					block.change = query.GetFieldData(block.GetBlockName(), "change", i).ParseFloat("change"); // float 6.2
					block.k200basis = query.GetFieldData(block.GetBlockName(), "k200basis", i).ParseFloat("k200basis"); // float 6.2
					block.tot3 = query.GetFieldData(block.GetBlockName(), "tot3", i).ParseLong("tot3"); // long 12
					block.tot1 = query.GetFieldData(block.GetBlockName(), "tot1", i).ParseLong("tot1"); // long 12
					block.tot2 = query.GetFieldData(block.GetBlockName(), "tot2", i).ParseLong("tot2"); // long 12
					block.cha3 = query.GetFieldData(block.GetBlockName(), "cha3", i).ParseLong("cha3"); // long 12
					block.cha1 = query.GetFieldData(block.GetBlockName(), "cha1", i).ParseLong("cha1"); // long 12
					block.cha2 = query.GetFieldData(block.GetBlockName(), "cha2", i).ParseLong("cha2"); // long 12
					block.bcha3 = query.GetFieldData(block.GetBlockName(), "bcha3", i).ParseLong("bcha3"); // long 12
					block.bcha1 = query.GetFieldData(block.GetBlockName(), "bcha1", i).ParseLong("bcha1"); // long 12
					block.bcha2 = query.GetFieldData(block.GetBlockName(), "bcha2", i).ParseLong("bcha2"); // long 12

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
			if (time?.Length > 6) return false; // char 6
			// k200jisu float 6.2
			// sign char 1
			// change float 6.2
			// k200basis float 6.2
			if (tot3.ToString().Length > 12) return false; // long 12
			if (tot1.ToString().Length > 12) return false; // long 12
			if (tot2.ToString().Length > 12) return false; // long 12
			if (cha3.ToString().Length > 12) return false; // long 12
			if (cha1.ToString().Length > 12) return false; // long 12
			if (cha2.ToString().Length > 12) return false; // long 12
			if (bcha3.ToString().Length > 12) return false; // long 12
			if (bcha1.ToString().Length > 12) return false; // long 12
			if (bcha2.ToString().Length > 12) return false; // long 12

			return true;
		}
	}

	/// <summary>
	/// 시간대별프로그램매매추이(t1632)
	/// </summary>
	public partial class XQt1632 : XingQuery
	{
		/// <summary>
		/// t1632
		/// </summary>
		public const string _typeName = "t1632";
		/// <summary>
		/// 시간대별프로그램매매추이(t1632)
		/// </summary>
		public const string _typeDesc = "시간대별프로그램매매추이(t1632)";
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
		/// t1632
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 시간대별프로그램매매추이(t1632)
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
		/// 시간대별프로그램매매추이(t1632)
		/// </summary>
		public XQt1632() : base("t1632") { }


		public class XQAllOutBlocks
		{
			public XQt1632OutBlock OutBlock { get; internal set; }
			public XQt1632OutBlock1[] OutBlock1 { get; internal set; }
		}

		public static XQAllOutBlocks Get(char gubun = default,char gubun1 = default,char gubun2 = default,char gubun3 = default,string date = default,string time = default)
		{
			using (XQt1632 instance = new XQt1632())
			{
				instance.SetFieldData(XQt1632InBlock.BlockName, XQt1632InBlock.F.gubun, 0, gubun.ToString()); // char 1
				instance.SetFieldData(XQt1632InBlock.BlockName, XQt1632InBlock.F.gubun1, 0, gubun1.ToString()); // char 1
				instance.SetFieldData(XQt1632InBlock.BlockName, XQt1632InBlock.F.gubun2, 0, gubun2.ToString()); // char 1
				instance.SetFieldData(XQt1632InBlock.BlockName, XQt1632InBlock.F.gubun3, 0, gubun3.ToString()); // char 1
				instance.SetFieldData(XQt1632InBlock.BlockName, XQt1632InBlock.F.date, 0, date); // char 8
				instance.SetFieldData(XQt1632InBlock.BlockName, XQt1632InBlock.F.time, 0, time); // char 6

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

		public bool SetBlock(XQt1632InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "gubun", 0, block.gubun.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "gubun1", 0, block.gubun1.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "gubun2", 0, block.gubun2.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "gubun3", 0, block.gubun3.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "date", 0, block.date); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "time", 0, block.time); // char 6

			return true;
		}

		public XQt1632OutBlock GetBlock()
		{
			XQt1632OutBlock instance = XQt1632OutBlock.FromQuery(this);
			return instance;

		}

		public XQt1632OutBlock1[] GetBlock1s()
		{
			XQt1632OutBlock1[] instance = XQt1632OutBlock1.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt1632OutBlock),
			typeof(XQt1632OutBlock1),

		};

	}

}
