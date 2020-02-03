using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1973InBlock : XingBlock
	{
		/// <summary>
		/// t1973InBlock
		/// </summary>
		static readonly string _blockName = "t1973InBlock";
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
		/// t1973InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1973InBlock
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
		[XAQueryFieldAttribute("단축코드")]
		public string shcode;
		/// <summary>
		/// 시간CTS
		/// </summary>
		[XAQueryFieldAttribute("시간CTS")]
		public string cts_time;

		public static class F
		{
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 시간CTS
			/// </summary>
			public const string cts_time = "cts_time";
		}

		public static string[] AllFields = new string[]
		{
			F.shcode,
			F.cts_time,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)6);
			dict["cts_time"] = new XAQueryFieldInfo("char", cts_time, cts_time, "시간CTS", (decimal)8);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cts_time":
					this.cts_time = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (shcode.Length > 6) return false; // char 6
			if (cts_time.Length > 8) return false; // char 8

			return true;
		}
	}

	public partial class XQt1973OutBlock : XingBlock
	{
		/// <summary>
		/// t1973OutBlock
		/// </summary>
		static readonly string _blockName = "t1973OutBlock";
		/// <summary>
		/// 출력
		/// </summary>
		static readonly string _blockDesc = "출력";
		/// <summary>
		/// output
		/// </summary>
		static readonly string _blockType = "output";
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _hasOccurs = false;
		/// <summary>
		/// t1973OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1973OutBlock
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
		/// 시간CTS
		/// </summary>
		[XAQueryFieldAttribute("시간CTS")]
		public string cts_time;

		public static class F
		{
			/// <summary>
			/// 시간CTS
			/// </summary>
			public const string cts_time = "cts_time";
		}

		public static string[] AllFields = new string[]
		{
			F.cts_time,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["cts_time"] = new XAQueryFieldInfo("char", cts_time, cts_time, "시간CTS", (decimal)8);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "cts_time":
					this.cts_time = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt1973OutBlock FromQuery(XQt1973 query)
		{
			XQt1973OutBlock block = new XQt1973OutBlock();
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
				block.cts_time = query.GetFieldData(block.GetBlockName(), "cts_time", 0).TrimEnd('?'); // char 8

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (cts_time.Length > 8) return false; // char 8

			return true;
		}
	}

	public partial class XQt1973OutBlock1 : XingBlock
	{
		/// <summary>
		/// t1973OutBlock1
		/// </summary>
		static readonly string _blockName = "t1973OutBlock1";
		/// <summary>
		/// 출력1
		/// </summary>
		static readonly string _blockDesc = "출력1";
		/// <summary>
		/// output
		/// </summary>
		static readonly string _blockType = "output";
		/// <summary>
		/// true
		/// </summary>
		static readonly bool _hasOccurs = true;
		/// <summary>
		/// t1973OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1973OutBlock1
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
		public string chetime;
		/// <summary>
		/// 예상체결가격
		/// </summary>
		[XAQueryFieldAttribute("예상체결가격")]
		public long yeprice;
		/// <summary>
		/// 예상체결구분
		/// </summary>
		[XAQueryFieldAttribute("예상체결구분")]
		public char yegubun;
		/// <summary>
		/// 전일종가대비구분
		/// </summary>
		[XAQueryFieldAttribute("전일종가대비구분")]
		public char jnilysign;
		/// <summary>
		/// 전일종가대비
		/// </summary>
		[XAQueryFieldAttribute("전일종가대비")]
		public long jnilychange;
		/// <summary>
		/// 예상체결등락율
		/// </summary>
		[XAQueryFieldAttribute("예상체결등락율")]
		public float yediff;
		/// <summary>
		/// 예상체결량
		/// </summary>
		[XAQueryFieldAttribute("예상체결량")]
		public long yevolume;
		/// <summary>
		/// 예상매도체결량
		/// </summary>
		[XAQueryFieldAttribute("예상매도체결량")]
		public long ymdvolume;
		/// <summary>
		/// 예상매수체결량
		/// </summary>
		[XAQueryFieldAttribute("예상매수체결량")]
		public long ymsvolume;

		public static class F
		{
			/// <summary>
			/// 시간
			/// </summary>
			public const string chetime = "chetime";
			/// <summary>
			/// 예상체결가격
			/// </summary>
			public const string yeprice = "yeprice";
			/// <summary>
			/// 예상체결구분
			/// </summary>
			public const string yegubun = "yegubun";
			/// <summary>
			/// 전일종가대비구분
			/// </summary>
			public const string jnilysign = "jnilysign";
			/// <summary>
			/// 전일종가대비
			/// </summary>
			public const string jnilychange = "jnilychange";
			/// <summary>
			/// 예상체결등락율
			/// </summary>
			public const string yediff = "yediff";
			/// <summary>
			/// 예상체결량
			/// </summary>
			public const string yevolume = "yevolume";
			/// <summary>
			/// 예상매도체결량
			/// </summary>
			public const string ymdvolume = "ymdvolume";
			/// <summary>
			/// 예상매수체결량
			/// </summary>
			public const string ymsvolume = "ymsvolume";
		}

		public static string[] AllFields = new string[]
		{
			F.chetime,
			F.yeprice,
			F.yegubun,
			F.jnilysign,
			F.jnilychange,
			F.yediff,
			F.yevolume,
			F.ymdvolume,
			F.ymsvolume,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["chetime"] = new XAQueryFieldInfo("char", chetime, chetime, "시간", (decimal)8);
			dict["yeprice"] = new XAQueryFieldInfo("long", yeprice, yeprice.ToString("d8"), "예상체결가격", (decimal)8);
			dict["yegubun"] = new XAQueryFieldInfo("char", yegubun, yegubun.ToString(), "예상체결구분", (decimal)1);
			dict["jnilysign"] = new XAQueryFieldInfo("char", jnilysign, jnilysign.ToString(), "전일종가대비구분", (decimal)1);
			dict["jnilychange"] = new XAQueryFieldInfo("long", jnilychange, jnilychange.ToString("d8"), "전일종가대비", (decimal)8);
			dict["yediff"] = new XAQueryFieldInfo("float", yediff, yediff.ToString("000000.00"), "예상체결등락율", (decimal)6.2);
			dict["yevolume"] = new XAQueryFieldInfo("long", yevolume, yevolume.ToString("d12"), "예상체결량", (decimal)12);
			dict["ymdvolume"] = new XAQueryFieldInfo("long", ymdvolume, ymdvolume.ToString("d12"), "예상매도체결량", (decimal)12);
			dict["ymsvolume"] = new XAQueryFieldInfo("long", ymsvolume, ymsvolume.ToString("d12"), "예상매수체결량", (decimal)12);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "chetime":
					this.chetime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "yeprice":
					this.yeprice = fieldInfo.FieldValue.ParseLong("yeprice");
				break;

				case "yegubun":
					this.yegubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "jnilysign":
					this.jnilysign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "jnilychange":
					this.jnilychange = fieldInfo.FieldValue.ParseLong("jnilychange");
				break;

				case "yediff":
					this.yediff = fieldInfo.FieldValue.ParseFloat("yediff");
				break;

				case "yevolume":
					this.yevolume = fieldInfo.FieldValue.ParseLong("yevolume");
				break;

				case "ymdvolume":
					this.ymdvolume = fieldInfo.FieldValue.ParseLong("ymdvolume");
				break;

				case "ymsvolume":
					this.ymsvolume = fieldInfo.FieldValue.ParseLong("ymsvolume");
				break;


			}
		}

		public static XQt1973OutBlock1[] ListFromQuery(XQt1973 query)
		{
			int count = query.GetBlockCount(XQt1973OutBlock1.BlockName);
			List<XQt1973OutBlock1> list = new List<XQt1973OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1973OutBlock1 block = new XQt1973OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.chetime = query.GetFieldData(block.GetBlockName(), "chetime", i).TrimEnd('?'); // char 8
					block.yeprice = query.GetFieldData(block.GetBlockName(), "yeprice", i).ParseLong("yeprice"); // long 8
					block.yegubun = query.GetFieldData(block.GetBlockName(), "yegubun", i).FirstOrDefault(); // char 1
					block.jnilysign = query.GetFieldData(block.GetBlockName(), "jnilysign", i).FirstOrDefault(); // char 1
					block.jnilychange = query.GetFieldData(block.GetBlockName(), "jnilychange", i).ParseLong("jnilychange"); // long 8
					block.yediff = query.GetFieldData(block.GetBlockName(), "yediff", i).ParseFloat("yediff"); // float 6.2
					block.yevolume = query.GetFieldData(block.GetBlockName(), "yevolume", i).ParseLong("yevolume"); // long 12
					block.ymdvolume = query.GetFieldData(block.GetBlockName(), "ymdvolume", i).ParseLong("ymdvolume"); // long 12
					block.ymsvolume = query.GetFieldData(block.GetBlockName(), "ymsvolume", i).ParseLong("ymsvolume"); // long 12

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
			if (chetime.Length > 8) return false; // char 8
			if (yeprice.ToString().Length > 8) return false; // long 8
			// yegubun char 1
			// jnilysign char 1
			if (jnilychange.ToString().Length > 8) return false; // long 8
			// yediff float 6.2
			if (yevolume.ToString().Length > 12) return false; // long 12
			if (ymdvolume.ToString().Length > 12) return false; // long 12
			if (ymsvolume.ToString().Length > 12) return false; // long 12

			return true;
		}
	}

	public partial class XQt1973 : XingQuery
	{
		/// <summary>
		/// t1973
		/// </summary>
		static readonly string _typeName = "t1973";
		/// <summary>
		/// ELW시간대별예상체결조회(t1973)
		/// </summary>
		static readonly string _typeDesc = "ELW시간대별예상체결조회(t1973)";
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
		/// t1973
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// ELW시간대별예상체결조회(t1973)
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

		public XQt1973() : base("t1973") { }


		public bool SetFields(XQt1973InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "shcode", 0, block.shcode); // char 6
			_xaQuery.SetFieldData(block.GetBlockName(), "cts_time", 0, block.cts_time); // char 8

			return true;
		}

		public XQt1973OutBlock GetBlock()
		{
			XQt1973OutBlock instance = XQt1973OutBlock.FromQuery(this);
			return instance;

		}

		public XQt1973OutBlock1[] GetBlock1s()
		{
			XQt1973OutBlock1[] instance = XQt1973OutBlock1.ListFromQuery(this);
			return instance;

		}


	}

}
