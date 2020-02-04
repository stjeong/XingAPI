using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1662InBlock : XingBlock
	{
		/// <summary>
		/// t1662InBlock
		/// </summary>
		public const string _blockName = "t1662InBlock";
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
		/// t1662InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1662InBlock
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
		/// 금액수량구분
		/// </summary>
		[XAQueryFieldAttribute("금액수량구분")]
		public char gubun1;
		/// <summary>
		/// 전일구분
		/// </summary>
		[XAQueryFieldAttribute("전일구분")]
		public char gubun3;

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
			/// 전일구분
			/// </summary>
			public const string gubun3 = "gubun3";
		}

		public static string[] AllFields = new string[]
		{
			F.gubun,
			F.gubun1,
			F.gubun3,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["gubun"] = new XAQueryFieldInfo("char", gubun, gubun.ToString(), "구분", (decimal)1);
			dict["gubun1"] = new XAQueryFieldInfo("char", gubun1, gubun1.ToString(), "금액수량구분", (decimal)1);
			dict["gubun3"] = new XAQueryFieldInfo("char", gubun3, gubun3.ToString(), "전일구분", (decimal)1);

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

				case "gubun3":
					this.gubun3 = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public bool VerifyData()
		{
			// gubun char 1
			// gubun1 char 1
			// gubun3 char 1

			return true;
		}
	}

	public partial class XQt1662OutBlock : XingBlock
	{
		/// <summary>
		/// t1662OutBlock
		/// </summary>
		public const string _blockName = "t1662OutBlock";
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
		/// t1662OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1662OutBlock
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
		/// 시간
		/// </summary>
		[XAQueryFieldAttribute("시간")]
		public string time;
		/// <summary>
		/// KP200
		/// </summary>
		[XAQueryFieldAttribute("KP200")]
		public float k200jisu;
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
		/// BASIS
		/// </summary>
		[XAQueryFieldAttribute("BASIS")]
		public float k200basis;
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
			/// <summary>
			/// 거래량
			/// </summary>
			public const string volume = "volume";
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
			F.volume,
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
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "거래량", (decimal)12);

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

				case "volume":
					this.volume = fieldInfo.FieldValue.ParseLong("volume");
				break;


			}
		}

		public static XQt1662OutBlock[] ListFromQuery(XQt1662 query)
		{
			int count = query.GetBlockCount(XQt1662OutBlock.BlockName);
			List<XQt1662OutBlock> list = new List<XQt1662OutBlock>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1662OutBlock block = new XQt1662OutBlock();
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
			if (volume.ToString().Length > 12) return false; // long 12

			return true;
		}
	}

	public partial class XQt1662 : XingQuery
	{
		/// <summary>
		/// t1662
		/// </summary>
		public const string _typeName = "t1662";
		/// <summary>
		/// 시간대별프로그램매매추이(차트)(t1662)
		/// </summary>
		public const string _typeDesc = "시간대별프로그램매매추이(차트)(t1662)";
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
		/// t1662
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 시간대별프로그램매매추이(차트)(t1662)
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

		public XQt1662() : base("t1662") { }


		public bool SetFields(XQt1662InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "gubun", 0, block.gubun.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "gubun1", 0, block.gubun1.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "gubun3", 0, block.gubun3.ToString()); // char 1

			return true;
		}

		public XQt1662OutBlock[] GetBlocks()
		{
			XQt1662OutBlock[] instance = XQt1662OutBlock.ListFromQuery(this);
			return instance;

		}


	}

}
