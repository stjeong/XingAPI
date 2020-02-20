using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1664InBlock : XingBlock
	{
		/// <summary>
		/// t1664InBlock
		/// </summary>
		public const string _blockName = "t1664InBlock";
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
		/// t1664InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1664InBlock
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
		[XAQueryFieldAttribute("mgubun", "시장구분", "char", "1")]
		public char mgubun;
		/// <summary>
		/// 금액수량구분
		/// </summary>
		[XAQueryFieldAttribute("vagubun", "금액수량구분", "char", "1")]
		public char vagubun;
		/// <summary>
		/// 시간일별구분
		/// </summary>
		[XAQueryFieldAttribute("bdgubun", "시간일별구분", "char", "1")]
		public char bdgubun;
		/// <summary>
		/// 조회건수
		/// </summary>
		[XAQueryFieldAttribute("cnt", "조회건수", "int", "3")]
		public int cnt;

		public static class F
		{
			/// <summary>
			/// 시장구분
			/// </summary>
			public const string mgubun = "mgubun";
			/// <summary>
			/// 금액수량구분
			/// </summary>
			public const string vagubun = "vagubun";
			/// <summary>
			/// 시간일별구분
			/// </summary>
			public const string bdgubun = "bdgubun";
			/// <summary>
			/// 조회건수
			/// </summary>
			public const string cnt = "cnt";
		}

		public static string[] AllFields = new string[]
		{
			F.mgubun,
			F.vagubun,
			F.bdgubun,
			F.cnt,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["mgubun"] = new XAQueryFieldInfo("char", mgubun, mgubun.ToString(), "시장구분", (decimal)1);
			dict["vagubun"] = new XAQueryFieldInfo("char", vagubun, vagubun.ToString(), "금액수량구분", (decimal)1);
			dict["bdgubun"] = new XAQueryFieldInfo("char", bdgubun, bdgubun.ToString(), "시간일별구분", (decimal)1);
			dict["cnt"] = new XAQueryFieldInfo("int", cnt, cnt.ToString("d3"), "조회건수", (decimal)3);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "mgubun":
					this.mgubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "vagubun":
					this.vagubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "bdgubun":
					this.bdgubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "cnt":
					this.cnt = fieldInfo.FieldValue.ParseInt("cnt");
				break;


			}
		}

		public bool VerifyData()
		{
			// mgubun char 1
			// vagubun char 1
			// bdgubun char 1
			// cnt int 3

			return true;
		}
	}

	public partial class XQt1664OutBlock1 : XingBlock
	{
		/// <summary>
		/// t1664OutBlock1
		/// </summary>
		public const string _blockName = "t1664OutBlock1";
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
		/// t1664OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1664OutBlock1
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
		/// 일자시간
		/// </summary>
		[XAQueryFieldAttribute("dt", "일자시간", "char", "8")]
		public string dt;
		/// <summary>
		/// 증권순매수
		/// </summary>
		[XAQueryFieldAttribute("tjj01", "증권순매수", "double", "12.0")]
		public double tjj01;
		/// <summary>
		/// 보험순매수
		/// </summary>
		[XAQueryFieldAttribute("tjj02", "보험순매수", "double", "12.0")]
		public double tjj02;
		/// <summary>
		/// 투신순매수
		/// </summary>
		[XAQueryFieldAttribute("tjj03", "투신순매수", "double", "12.0")]
		public double tjj03;
		/// <summary>
		/// 은행순매수
		/// </summary>
		[XAQueryFieldAttribute("tjj04", "은행순매수", "double", "12.0")]
		public double tjj04;
		/// <summary>
		/// 종금순매수
		/// </summary>
		[XAQueryFieldAttribute("tjj05", "종금순매수", "double", "12.0")]
		public double tjj05;
		/// <summary>
		/// 기금순매수
		/// </summary>
		[XAQueryFieldAttribute("tjj06", "기금순매수", "double", "12.0")]
		public double tjj06;
		/// <summary>
		/// 기타순매수
		/// </summary>
		[XAQueryFieldAttribute("tjj07", "기타순매수", "double", "12.0")]
		public double tjj07;
		/// <summary>
		/// 개인순매수
		/// </summary>
		[XAQueryFieldAttribute("tjj08", "개인순매수", "double", "12.0")]
		public double tjj08;
		/// <summary>
		/// 외국인순매수
		/// </summary>
		[XAQueryFieldAttribute("tjj17", "외국인순매수", "double", "12.0")]
		public double tjj17;
		/// <summary>
		/// 기관순매수
		/// </summary>
		[XAQueryFieldAttribute("tjj18", "기관순매수", "double", "12.0")]
		public double tjj18;
		/// <summary>
		/// 차익순매수
		/// </summary>
		[XAQueryFieldAttribute("cha", "차익순매수", "double", "12.0")]
		public double cha;
		/// <summary>
		/// 비차익순매수
		/// </summary>
		[XAQueryFieldAttribute("bicha", "비차익순매수", "double", "12.0")]
		public double bicha;
		/// <summary>
		/// 종합순매수
		/// </summary>
		[XAQueryFieldAttribute("totcha", "종합순매수", "double", "12.0")]
		public double totcha;
		/// <summary>
		/// 베이시스
		/// </summary>
		[XAQueryFieldAttribute("basis", "베이시스", "float", "6.2")]
		public float basis;

		public static class F
		{
			/// <summary>
			/// 일자시간
			/// </summary>
			public const string dt = "dt";
			/// <summary>
			/// 증권순매수
			/// </summary>
			public const string tjj01 = "tjj01";
			/// <summary>
			/// 보험순매수
			/// </summary>
			public const string tjj02 = "tjj02";
			/// <summary>
			/// 투신순매수
			/// </summary>
			public const string tjj03 = "tjj03";
			/// <summary>
			/// 은행순매수
			/// </summary>
			public const string tjj04 = "tjj04";
			/// <summary>
			/// 종금순매수
			/// </summary>
			public const string tjj05 = "tjj05";
			/// <summary>
			/// 기금순매수
			/// </summary>
			public const string tjj06 = "tjj06";
			/// <summary>
			/// 기타순매수
			/// </summary>
			public const string tjj07 = "tjj07";
			/// <summary>
			/// 개인순매수
			/// </summary>
			public const string tjj08 = "tjj08";
			/// <summary>
			/// 외국인순매수
			/// </summary>
			public const string tjj17 = "tjj17";
			/// <summary>
			/// 기관순매수
			/// </summary>
			public const string tjj18 = "tjj18";
			/// <summary>
			/// 차익순매수
			/// </summary>
			public const string cha = "cha";
			/// <summary>
			/// 비차익순매수
			/// </summary>
			public const string bicha = "bicha";
			/// <summary>
			/// 종합순매수
			/// </summary>
			public const string totcha = "totcha";
			/// <summary>
			/// 베이시스
			/// </summary>
			public const string basis = "basis";
		}

		public static string[] AllFields = new string[]
		{
			F.dt,
			F.tjj01,
			F.tjj02,
			F.tjj03,
			F.tjj04,
			F.tjj05,
			F.tjj06,
			F.tjj07,
			F.tjj08,
			F.tjj17,
			F.tjj18,
			F.cha,
			F.bicha,
			F.totcha,
			F.basis,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["dt"] = new XAQueryFieldInfo("char", dt, dt, "일자시간", (decimal)8);
			dict["tjj01"] = new XAQueryFieldInfo("double", tjj01, tjj01.ToString("000000000000."), "증권순매수", (decimal)12.0);
			dict["tjj02"] = new XAQueryFieldInfo("double", tjj02, tjj02.ToString("000000000000."), "보험순매수", (decimal)12.0);
			dict["tjj03"] = new XAQueryFieldInfo("double", tjj03, tjj03.ToString("000000000000."), "투신순매수", (decimal)12.0);
			dict["tjj04"] = new XAQueryFieldInfo("double", tjj04, tjj04.ToString("000000000000."), "은행순매수", (decimal)12.0);
			dict["tjj05"] = new XAQueryFieldInfo("double", tjj05, tjj05.ToString("000000000000."), "종금순매수", (decimal)12.0);
			dict["tjj06"] = new XAQueryFieldInfo("double", tjj06, tjj06.ToString("000000000000."), "기금순매수", (decimal)12.0);
			dict["tjj07"] = new XAQueryFieldInfo("double", tjj07, tjj07.ToString("000000000000."), "기타순매수", (decimal)12.0);
			dict["tjj08"] = new XAQueryFieldInfo("double", tjj08, tjj08.ToString("000000000000."), "개인순매수", (decimal)12.0);
			dict["tjj17"] = new XAQueryFieldInfo("double", tjj17, tjj17.ToString("000000000000."), "외국인순매수", (decimal)12.0);
			dict["tjj18"] = new XAQueryFieldInfo("double", tjj18, tjj18.ToString("000000000000."), "기관순매수", (decimal)12.0);
			dict["cha"] = new XAQueryFieldInfo("double", cha, cha.ToString("000000000000."), "차익순매수", (decimal)12.0);
			dict["bicha"] = new XAQueryFieldInfo("double", bicha, bicha.ToString("000000000000."), "비차익순매수", (decimal)12.0);
			dict["totcha"] = new XAQueryFieldInfo("double", totcha, totcha.ToString("000000000000."), "종합순매수", (decimal)12.0);
			dict["basis"] = new XAQueryFieldInfo("float", basis, basis.ToString("000000.00"), "베이시스", (decimal)6.2);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "dt":
					this.dt = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "tjj01":
					this.tjj01 = fieldInfo.FieldValue.ParseDouble("tjj01");
				break;

				case "tjj02":
					this.tjj02 = fieldInfo.FieldValue.ParseDouble("tjj02");
				break;

				case "tjj03":
					this.tjj03 = fieldInfo.FieldValue.ParseDouble("tjj03");
				break;

				case "tjj04":
					this.tjj04 = fieldInfo.FieldValue.ParseDouble("tjj04");
				break;

				case "tjj05":
					this.tjj05 = fieldInfo.FieldValue.ParseDouble("tjj05");
				break;

				case "tjj06":
					this.tjj06 = fieldInfo.FieldValue.ParseDouble("tjj06");
				break;

				case "tjj07":
					this.tjj07 = fieldInfo.FieldValue.ParseDouble("tjj07");
				break;

				case "tjj08":
					this.tjj08 = fieldInfo.FieldValue.ParseDouble("tjj08");
				break;

				case "tjj17":
					this.tjj17 = fieldInfo.FieldValue.ParseDouble("tjj17");
				break;

				case "tjj18":
					this.tjj18 = fieldInfo.FieldValue.ParseDouble("tjj18");
				break;

				case "cha":
					this.cha = fieldInfo.FieldValue.ParseDouble("cha");
				break;

				case "bicha":
					this.bicha = fieldInfo.FieldValue.ParseDouble("bicha");
				break;

				case "totcha":
					this.totcha = fieldInfo.FieldValue.ParseDouble("totcha");
				break;

				case "basis":
					this.basis = fieldInfo.FieldValue.ParseFloat("basis");
				break;


			}
		}

		public static XQt1664OutBlock1[] ListFromQuery(XQt1664 query)
		{
			int count = query.GetBlockCount(XQt1664OutBlock1.BlockName);
			List<XQt1664OutBlock1> list = new List<XQt1664OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1664OutBlock1 block = new XQt1664OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.dt = query.GetFieldData(block.GetBlockName(), "dt", i).TrimEnd('?'); // char 8
					block.tjj01 = query.GetFieldData(block.GetBlockName(), "tjj01", i).ParseDouble("tjj01"); // double 12.0
					block.tjj02 = query.GetFieldData(block.GetBlockName(), "tjj02", i).ParseDouble("tjj02"); // double 12.0
					block.tjj03 = query.GetFieldData(block.GetBlockName(), "tjj03", i).ParseDouble("tjj03"); // double 12.0
					block.tjj04 = query.GetFieldData(block.GetBlockName(), "tjj04", i).ParseDouble("tjj04"); // double 12.0
					block.tjj05 = query.GetFieldData(block.GetBlockName(), "tjj05", i).ParseDouble("tjj05"); // double 12.0
					block.tjj06 = query.GetFieldData(block.GetBlockName(), "tjj06", i).ParseDouble("tjj06"); // double 12.0
					block.tjj07 = query.GetFieldData(block.GetBlockName(), "tjj07", i).ParseDouble("tjj07"); // double 12.0
					block.tjj08 = query.GetFieldData(block.GetBlockName(), "tjj08", i).ParseDouble("tjj08"); // double 12.0
					block.tjj17 = query.GetFieldData(block.GetBlockName(), "tjj17", i).ParseDouble("tjj17"); // double 12.0
					block.tjj18 = query.GetFieldData(block.GetBlockName(), "tjj18", i).ParseDouble("tjj18"); // double 12.0
					block.cha = query.GetFieldData(block.GetBlockName(), "cha", i).ParseDouble("cha"); // double 12.0
					block.bicha = query.GetFieldData(block.GetBlockName(), "bicha", i).ParseDouble("bicha"); // double 12.0
					block.totcha = query.GetFieldData(block.GetBlockName(), "totcha", i).ParseDouble("totcha"); // double 12.0
					block.basis = query.GetFieldData(block.GetBlockName(), "basis", i).ParseFloat("basis"); // float 6.2

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
			if (dt?.Length > 8) return false; // char 8
			// tjj01 double 12.0
			// tjj02 double 12.0
			// tjj03 double 12.0
			// tjj04 double 12.0
			// tjj05 double 12.0
			// tjj06 double 12.0
			// tjj07 double 12.0
			// tjj08 double 12.0
			// tjj17 double 12.0
			// tjj18 double 12.0
			// cha double 12.0
			// bicha double 12.0
			// totcha double 12.0
			// basis float 6.2

			return true;
		}
	}

	/// <summary>
	/// 투자자매매종합(챠트)
	/// </summary>
	public partial class XQt1664 : XingQuery
	{
		/// <summary>
		/// t1664
		/// </summary>
		public const string _typeName = "t1664";
		/// <summary>
		/// 투자자매매종합(챠트)
		/// </summary>
		public const string _typeDesc = "투자자매매종합(챠트)";
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
		/// t1664
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 투자자매매종합(챠트)
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
		/// 투자자매매종합(챠트)
		/// </summary>
		public XQt1664() : base("t1664") { }


		public static XQt1664OutBlock1[] Get(char mgubun = default,char vagubun = default,char bdgubun = default,int cnt = default)
		{
			using (XQt1664 instance = new XQt1664())
			{
				instance.SetFieldData(XQt1664InBlock.BlockName, XQt1664InBlock.F.mgubun, 0, mgubun.ToString()); // char 1
				instance.SetFieldData(XQt1664InBlock.BlockName, XQt1664InBlock.F.vagubun, 0, vagubun.ToString()); // char 1
				instance.SetFieldData(XQt1664InBlock.BlockName, XQt1664InBlock.F.bdgubun, 0, bdgubun.ToString()); // char 1
				instance.SetFieldData(XQt1664InBlock.BlockName, XQt1664InBlock.F.cnt, 0, cnt.ToString("d3")); // int 3

				if (instance.Request() < 0)
				{
					return null;
				}

				var outBlock = instance.GetBlock1s();
				return outBlock;
			}
		}

		public static XQt1664OutBlock1[] ReadFromDB(string tableNamePostfix = null /*, char mgubun = default,char vagubun = default,char bdgubun = default,int cnt = default */)
		{
			using (XQt1664 instance = new XQt1664())
			{

				string tableName = (tableNamePostfix == null) ? "XQt1664OutBlock1" : $"XQt1664OutBlock1_{tableNamePostfix}";
				QueryOption qo = new QueryOption(tableName);
				// if (mgubun != default) qo.Add("mgubun", mgubun);
				// if (vagubun != default) qo.Add("vagubun", vagubun);
				// if (bdgubun != default) qo.Add("bdgubun", bdgubun);
				// if (cnt != default) qo.Add("cnt", cnt);


				var outBlock = instance.SelectMany<XQt1664OutBlock1>(qo);
				return outBlock;
			}
		}

		public bool SetBlock(XQt1664InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "mgubun", 0, block.mgubun.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "vagubun", 0, block.vagubun.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "bdgubun", 0, block.bdgubun.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "cnt", 0, block.cnt.ToString("d3")); // int 3

			return true;
		}

		public XQt1664OutBlock1[] GetBlock1s()
		{
			XQt1664OutBlock1[] instance = XQt1664OutBlock1.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt1664OutBlock1),

		};

	}

}
