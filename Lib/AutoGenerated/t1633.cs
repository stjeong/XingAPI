using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1633InBlock : XingBlock
	{
		/// <summary>
		/// t1633InBlock
		/// </summary>
		public const string _blockName = "t1633InBlock";
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
		/// t1633InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1633InBlock
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
		/// 금액수량구분
		/// </summary>
		[XAQueryFieldAttribute("금액수량구분")]
		public char gubun1;
		/// <summary>
		/// 수치누적구분
		/// </summary>
		[XAQueryFieldAttribute("수치누적구분")]
		public char gubun2;
		/// <summary>
		/// 일주월구분
		/// </summary>
		[XAQueryFieldAttribute("일주월구분")]
		public char gubun3;
		/// <summary>
		/// from일자
		/// </summary>
		[XAQueryFieldAttribute("from일자")]
		public string fdate;
		/// <summary>
		/// to일자
		/// </summary>
		[XAQueryFieldAttribute("to일자")]
		public string tdate;
		/// <summary>
		/// 직전대비증감구분
		/// </summary>
		[XAQueryFieldAttribute("직전대비증감구분")]
		public char gubun4;
		/// <summary>
		/// 날짜
		/// </summary>
		[XAQueryFieldAttribute("날짜")]
		public string date;

		public static class F
		{
			/// <summary>
			/// 시장구분
			/// </summary>
			public const string gubun = "gubun";
			/// <summary>
			/// 금액수량구분
			/// </summary>
			public const string gubun1 = "gubun1";
			/// <summary>
			/// 수치누적구분
			/// </summary>
			public const string gubun2 = "gubun2";
			/// <summary>
			/// 일주월구분
			/// </summary>
			public const string gubun3 = "gubun3";
			/// <summary>
			/// from일자
			/// </summary>
			public const string fdate = "fdate";
			/// <summary>
			/// to일자
			/// </summary>
			public const string tdate = "tdate";
			/// <summary>
			/// 직전대비증감구분
			/// </summary>
			public const string gubun4 = "gubun4";
			/// <summary>
			/// 날짜
			/// </summary>
			public const string date = "date";
		}

		public static string[] AllFields = new string[]
		{
			F.gubun,
			F.gubun1,
			F.gubun2,
			F.gubun3,
			F.fdate,
			F.tdate,
			F.gubun4,
			F.date,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["gubun"] = new XAQueryFieldInfo("char", gubun, gubun.ToString(), "시장구분", (decimal)1);
			dict["gubun1"] = new XAQueryFieldInfo("char", gubun1, gubun1.ToString(), "금액수량구분", (decimal)1);
			dict["gubun2"] = new XAQueryFieldInfo("char", gubun2, gubun2.ToString(), "수치누적구분", (decimal)1);
			dict["gubun3"] = new XAQueryFieldInfo("char", gubun3, gubun3.ToString(), "일주월구분", (decimal)1);
			dict["fdate"] = new XAQueryFieldInfo("char", fdate, fdate, "from일자", (decimal)8);
			dict["tdate"] = new XAQueryFieldInfo("char", tdate, tdate, "to일자", (decimal)8);
			dict["gubun4"] = new XAQueryFieldInfo("char", gubun4, gubun4.ToString(), "직전대비증감구분", (decimal)1);
			dict["date"] = new XAQueryFieldInfo("char", date, date, "날짜", (decimal)8);

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

				case "fdate":
					this.fdate = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "tdate":
					this.tdate = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "gubun4":
					this.gubun4 = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "date":
					this.date = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			// gubun char 1
			// gubun1 char 1
			// gubun2 char 1
			// gubun3 char 1
			if (fdate?.Length > 8) return false; // char 8
			if (tdate?.Length > 8) return false; // char 8
			// gubun4 char 1
			if (date?.Length > 8) return false; // char 8

			return true;
		}
	}

	public partial class XQt1633OutBlock : XingBlock
	{
		/// <summary>
		/// t1633OutBlock
		/// </summary>
		public const string _blockName = "t1633OutBlock";
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
		/// t1633OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1633OutBlock
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
		/// 날짜
		/// </summary>
		[XAQueryFieldAttribute("날짜")]
		public string date;
		/// <summary>
		/// IDX
		/// </summary>
		[XAQueryFieldAttribute("IDX")]
		public long idx;

		public static class F
		{
			/// <summary>
			/// 날짜
			/// </summary>
			public const string date = "date";
			/// <summary>
			/// IDX
			/// </summary>
			public const string idx = "idx";
		}

		public static string[] AllFields = new string[]
		{
			F.date,
			F.idx,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["date"] = new XAQueryFieldInfo("char", date, date, "날짜", (decimal)8);
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

				case "idx":
					this.idx = fieldInfo.FieldValue.ParseLong("idx");
				break;


			}
		}

		public static XQt1633OutBlock FromQuery(XQt1633 query)
		{
			XQt1633OutBlock block = new XQt1633OutBlock();
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
			if (idx.ToString().Length > 4) return false; // long 4

			return true;
		}
	}

	public partial class XQt1633OutBlock1 : XingBlock
	{
		/// <summary>
		/// t1633OutBlock1
		/// </summary>
		public const string _blockName = "t1633OutBlock1";
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
		/// t1633OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1633OutBlock1
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
		/// 일자
		/// </summary>
		[XAQueryFieldAttribute("일자")]
		public string date;
		/// <summary>
		/// KP200
		/// </summary>
		[XAQueryFieldAttribute("KP200")]
		public float jisu;
		/// <summary>
		/// 대비구분
		/// </summary>
		[XAQueryFieldAttribute("대비구분")]
		public char sign;
		/// <summary>
		/// 대비
		/// </summary>
		[XAQueryFieldAttribute("대비")]
		public float change;
		/// <summary>
		/// 전체순매수
		/// </summary>
		[XAQueryFieldAttribute("전체순매수")]
		public long tot3;
		/// <summary>
		/// 전체매수
		/// </summary>
		[XAQueryFieldAttribute("전체매수")]
		public long tot1;
		/// <summary>
		/// 전체매도
		/// </summary>
		[XAQueryFieldAttribute("전체매도")]
		public long tot2;
		/// <summary>
		/// 차익순매수
		/// </summary>
		[XAQueryFieldAttribute("차익순매수")]
		public long cha3;
		/// <summary>
		/// 차익매수
		/// </summary>
		[XAQueryFieldAttribute("차익매수")]
		public long cha1;
		/// <summary>
		/// 차익매도
		/// </summary>
		[XAQueryFieldAttribute("차익매도")]
		public long cha2;
		/// <summary>
		/// 비차익순매수
		/// </summary>
		[XAQueryFieldAttribute("비차익순매수")]
		public long bcha3;
		/// <summary>
		/// 비차익매수
		/// </summary>
		[XAQueryFieldAttribute("비차익매수")]
		public long bcha1;
		/// <summary>
		/// 비차익매도
		/// </summary>
		[XAQueryFieldAttribute("비차익매도")]
		public long bcha2;
		/// <summary>
		/// 거래량
		/// </summary>
		[XAQueryFieldAttribute("거래량")]
		public long volume;

		public static class F
		{
			/// <summary>
			/// 일자
			/// </summary>
			public const string date = "date";
			/// <summary>
			/// KP200
			/// </summary>
			public const string jisu = "jisu";
			/// <summary>
			/// 대비구분
			/// </summary>
			public const string sign = "sign";
			/// <summary>
			/// 대비
			/// </summary>
			public const string change = "change";
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
			/// <summary>
			/// 거래량
			/// </summary>
			public const string volume = "volume";
		}

		public static string[] AllFields = new string[]
		{
			F.date,
			F.jisu,
			F.sign,
			F.change,
			F.tot3,
			F.tot1,
			F.tot2,
			F.cha3,
			F.cha1,
			F.cha2,
			F.bcha3,
			F.bcha1,
			F.bcha2,
			F.volume,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["date"] = new XAQueryFieldInfo("char", date, date, "일자", (decimal)8);
			dict["jisu"] = new XAQueryFieldInfo("float", jisu, jisu.ToString("000000.00"), "KP200", (decimal)6.2);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("float", change, change.ToString("000000.00"), "대비", (decimal)6.2);
			dict["tot3"] = new XAQueryFieldInfo("long", tot3, tot3.ToString("d12"), "전체순매수", (decimal)12);
			dict["tot1"] = new XAQueryFieldInfo("long", tot1, tot1.ToString("d12"), "전체매수", (decimal)12);
			dict["tot2"] = new XAQueryFieldInfo("long", tot2, tot2.ToString("d12"), "전체매도", (decimal)12);
			dict["cha3"] = new XAQueryFieldInfo("long", cha3, cha3.ToString("d12"), "차익순매수", (decimal)12);
			dict["cha1"] = new XAQueryFieldInfo("long", cha1, cha1.ToString("d12"), "차익매수", (decimal)12);
			dict["cha2"] = new XAQueryFieldInfo("long", cha2, cha2.ToString("d12"), "차익매도", (decimal)12);
			dict["bcha3"] = new XAQueryFieldInfo("long", bcha3, bcha3.ToString("d12"), "비차익순매수", (decimal)12);
			dict["bcha1"] = new XAQueryFieldInfo("long", bcha1, bcha1.ToString("d12"), "비차익매수", (decimal)12);
			dict["bcha2"] = new XAQueryFieldInfo("long", bcha2, bcha2.ToString("d12"), "비차익매도", (decimal)12);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "거래량", (decimal)12);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "date":
					this.date = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "jisu":
					this.jisu = fieldInfo.FieldValue.ParseFloat("jisu");
				break;

				case "sign":
					this.sign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "change":
					this.change = fieldInfo.FieldValue.ParseFloat("change");
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

				case "volume":
					this.volume = fieldInfo.FieldValue.ParseLong("volume");
				break;


			}
		}

		public static XQt1633OutBlock1[] ListFromQuery(XQt1633 query)
		{
			int count = query.GetBlockCount(XQt1633OutBlock1.BlockName);
			List<XQt1633OutBlock1> list = new List<XQt1633OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1633OutBlock1 block = new XQt1633OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.date = query.GetFieldData(block.GetBlockName(), "date", i).TrimEnd('?'); // char 8
					block.jisu = query.GetFieldData(block.GetBlockName(), "jisu", i).ParseFloat("jisu"); // float 6.2
					block.sign = query.GetFieldData(block.GetBlockName(), "sign", i).FirstOrDefault(); // char 1
					block.change = query.GetFieldData(block.GetBlockName(), "change", i).ParseFloat("change"); // float 6.2
					block.tot3 = query.GetFieldData(block.GetBlockName(), "tot3", i).ParseLong("tot3"); // long 12
					block.tot1 = query.GetFieldData(block.GetBlockName(), "tot1", i).ParseLong("tot1"); // long 12
					block.tot2 = query.GetFieldData(block.GetBlockName(), "tot2", i).ParseLong("tot2"); // long 12
					block.cha3 = query.GetFieldData(block.GetBlockName(), "cha3", i).ParseLong("cha3"); // long 12
					block.cha1 = query.GetFieldData(block.GetBlockName(), "cha1", i).ParseLong("cha1"); // long 12
					block.cha2 = query.GetFieldData(block.GetBlockName(), "cha2", i).ParseLong("cha2"); // long 12
					block.bcha3 = query.GetFieldData(block.GetBlockName(), "bcha3", i).ParseLong("bcha3"); // long 12
					block.bcha1 = query.GetFieldData(block.GetBlockName(), "bcha1", i).ParseLong("bcha1"); // long 12
					block.bcha2 = query.GetFieldData(block.GetBlockName(), "bcha2", i).ParseLong("bcha2"); // long 12
					block.volume = query.GetFieldData(block.GetBlockName(), "volume", i).ParseLong("volume"); // long 12

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
			// jisu float 6.2
			// sign char 1
			// change float 6.2
			if (tot3.ToString().Length > 12) return false; // long 12
			if (tot1.ToString().Length > 12) return false; // long 12
			if (tot2.ToString().Length > 12) return false; // long 12
			if (cha3.ToString().Length > 12) return false; // long 12
			if (cha1.ToString().Length > 12) return false; // long 12
			if (cha2.ToString().Length > 12) return false; // long 12
			if (bcha3.ToString().Length > 12) return false; // long 12
			if (bcha1.ToString().Length > 12) return false; // long 12
			if (bcha2.ToString().Length > 12) return false; // long 12
			if (volume.ToString().Length > 12) return false; // long 12

			return true;
		}
	}

	/// <summary>
	/// 기간별프로그램매매추이(t1633)
	/// </summary>
	public partial class XQt1633 : XingQuery
	{
		/// <summary>
		/// t1633
		/// </summary>
		public const string _typeName = "t1633";
		/// <summary>
		/// 기간별프로그램매매추이(t1633)
		/// </summary>
		public const string _typeDesc = "기간별프로그램매매추이(t1633)";
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
		/// t1633
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 기간별프로그램매매추이(t1633)
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

		public XQt1633() : base("t1633") { }


		public static XQt1633OutBlock1[] Get(char gubun = default,char gubun1 = default,char gubun2 = default,char gubun3 = default,string fdate = default,string tdate = default,char gubun4 = default,string date = default)
		{
			using (XQt1633 instance = new XQt1633())
			{
				instance.SetFieldData(XQt1633InBlock.BlockName, XQt1633InBlock.F.gubun, 0, gubun.ToString()); // char 1
				instance.SetFieldData(XQt1633InBlock.BlockName, XQt1633InBlock.F.gubun1, 0, gubun1.ToString()); // char 1
				instance.SetFieldData(XQt1633InBlock.BlockName, XQt1633InBlock.F.gubun2, 0, gubun2.ToString()); // char 1
				instance.SetFieldData(XQt1633InBlock.BlockName, XQt1633InBlock.F.gubun3, 0, gubun3.ToString()); // char 1
				instance.SetFieldData(XQt1633InBlock.BlockName, XQt1633InBlock.F.fdate, 0, fdate); // char 8
				instance.SetFieldData(XQt1633InBlock.BlockName, XQt1633InBlock.F.tdate, 0, tdate); // char 8
				instance.SetFieldData(XQt1633InBlock.BlockName, XQt1633InBlock.F.gubun4, 0, gubun4.ToString()); // char 1
				instance.SetFieldData(XQt1633InBlock.BlockName, XQt1633InBlock.F.date, 0, date); // char 8

				if (instance.Request() < 0)
				{
					return null;
				}

				var outBlock = instance.GetBlock1s();
				return outBlock;
			}
		}

		public bool SetBlock(XQt1633InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "gubun", 0, block.gubun.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "gubun1", 0, block.gubun1.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "gubun2", 0, block.gubun2.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "gubun3", 0, block.gubun3.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "fdate", 0, block.fdate); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "tdate", 0, block.tdate); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "gubun4", 0, block.gubun4.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "date", 0, block.date); // char 8

			return true;
		}

		public XQt1633OutBlock GetBlock()
		{
			XQt1633OutBlock instance = XQt1633OutBlock.FromQuery(this);
			return instance;

		}

		public XQt1633OutBlock1[] GetBlock1s()
		{
			XQt1633OutBlock1[] instance = XQt1633OutBlock1.ListFromQuery(this);
			return instance;

		}


	}

}
