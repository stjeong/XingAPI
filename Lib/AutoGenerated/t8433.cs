using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt8433InBlock : XingBlock
	{
		/// <summary>
		/// t8433InBlock
		/// </summary>
		public const string _blockName = "t8433InBlock";
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
		/// t8433InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t8433InBlock
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
		/// Dummy
		/// </summary>
		[XAQueryFieldAttribute("Dummy")]
		public char dummy;

		public static class F
		{
			/// <summary>
			/// Dummy
			/// </summary>
			public const string dummy = "dummy";
		}

		public static string[] AllFields = new string[]
		{
			F.dummy,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["dummy"] = new XAQueryFieldInfo("char", dummy, dummy.ToString(), "Dummy", (decimal)1);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "dummy":
					this.dummy = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public bool VerifyData()
		{
			// dummy char 1

			return true;
		}
	}

	public partial class XQt8433OutBlock : XingBlock
	{
		/// <summary>
		/// t8433OutBlock
		/// </summary>
		public const string _blockName = "t8433OutBlock";
		/// <summary>
		/// 주식종목마스터
		/// </summary>
		public const string _blockDesc = "주식종목마스터";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// true
		/// </summary>
		public const bool _hasOccurs = true;
		/// <summary>
		/// t8433OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t8433OutBlock
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// 주식종목마스터
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
		/// 종목명
		/// </summary>
		[XAQueryFieldAttribute("종목명")]
		public string hname;
		/// <summary>
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("단축코드")]
		public string shcode;
		/// <summary>
		/// 확장코드
		/// </summary>
		[XAQueryFieldAttribute("확장코드")]
		public string expcode;
		/// <summary>
		/// 상한가
		/// </summary>
		[XAQueryFieldAttribute("상한가")]
		public float hprice;
		/// <summary>
		/// 하한가
		/// </summary>
		[XAQueryFieldAttribute("하한가")]
		public float lprice;
		/// <summary>
		/// 전일종가
		/// </summary>
		[XAQueryFieldAttribute("전일종가")]
		public float jnilclose;
		/// <summary>
		/// 전일고가
		/// </summary>
		[XAQueryFieldAttribute("전일고가")]
		public float jnilhigh;
		/// <summary>
		/// 전일저가
		/// </summary>
		[XAQueryFieldAttribute("전일저가")]
		public float jnillow;
		/// <summary>
		/// 기준가
		/// </summary>
		[XAQueryFieldAttribute("기준가")]
		public float recprice;

		public static class F
		{
			/// <summary>
			/// 종목명
			/// </summary>
			public const string hname = "hname";
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 확장코드
			/// </summary>
			public const string expcode = "expcode";
			/// <summary>
			/// 상한가
			/// </summary>
			public const string hprice = "hprice";
			/// <summary>
			/// 하한가
			/// </summary>
			public const string lprice = "lprice";
			/// <summary>
			/// 전일종가
			/// </summary>
			public const string jnilclose = "jnilclose";
			/// <summary>
			/// 전일고가
			/// </summary>
			public const string jnilhigh = "jnilhigh";
			/// <summary>
			/// 전일저가
			/// </summary>
			public const string jnillow = "jnillow";
			/// <summary>
			/// 기준가
			/// </summary>
			public const string recprice = "recprice";
		}

		public static string[] AllFields = new string[]
		{
			F.hname,
			F.shcode,
			F.expcode,
			F.hprice,
			F.lprice,
			F.jnilclose,
			F.jnilhigh,
			F.jnillow,
			F.recprice,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["hname"] = new XAQueryFieldInfo("char", hname, hname, "종목명", (decimal)20);
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)8);
			dict["expcode"] = new XAQueryFieldInfo("char", expcode, expcode, "확장코드", (decimal)12);
			dict["hprice"] = new XAQueryFieldInfo("float", hprice, hprice.ToString("000000.00"), "상한가", (decimal)6.2);
			dict["lprice"] = new XAQueryFieldInfo("float", lprice, lprice.ToString("000000.00"), "하한가", (decimal)6.2);
			dict["jnilclose"] = new XAQueryFieldInfo("float", jnilclose, jnilclose.ToString("000000.00"), "전일종가", (decimal)6.2);
			dict["jnilhigh"] = new XAQueryFieldInfo("float", jnilhigh, jnilhigh.ToString("000000.00"), "전일고가", (decimal)6.2);
			dict["jnillow"] = new XAQueryFieldInfo("float", jnillow, jnillow.ToString("000000.00"), "전일저가", (decimal)6.2);
			dict["recprice"] = new XAQueryFieldInfo("float", recprice, recprice.ToString("000000.00"), "기준가", (decimal)6.2);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "hname":
					this.hname = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "expcode":
					this.expcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "hprice":
					this.hprice = fieldInfo.FieldValue.ParseFloat("hprice");
				break;

				case "lprice":
					this.lprice = fieldInfo.FieldValue.ParseFloat("lprice");
				break;

				case "jnilclose":
					this.jnilclose = fieldInfo.FieldValue.ParseFloat("jnilclose");
				break;

				case "jnilhigh":
					this.jnilhigh = fieldInfo.FieldValue.ParseFloat("jnilhigh");
				break;

				case "jnillow":
					this.jnillow = fieldInfo.FieldValue.ParseFloat("jnillow");
				break;

				case "recprice":
					this.recprice = fieldInfo.FieldValue.ParseFloat("recprice");
				break;


			}
		}

		public static XQt8433OutBlock[] ListFromQuery(XQt8433 query)
		{
			int count = query.GetBlockCount(XQt8433OutBlock.BlockName);
			List<XQt8433OutBlock> list = new List<XQt8433OutBlock>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt8433OutBlock block = new XQt8433OutBlock();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.hname = query.GetFieldData(block.GetBlockName(), "hname", i).TrimEnd('?'); // char 20
					block.shcode = query.GetFieldData(block.GetBlockName(), "shcode", i).TrimEnd('?'); // char 8
					block.expcode = query.GetFieldData(block.GetBlockName(), "expcode", i).TrimEnd('?'); // char 12
					block.hprice = query.GetFieldData(block.GetBlockName(), "hprice", i).ParseFloat("hprice"); // float 6.2
					block.lprice = query.GetFieldData(block.GetBlockName(), "lprice", i).ParseFloat("lprice"); // float 6.2
					block.jnilclose = query.GetFieldData(block.GetBlockName(), "jnilclose", i).ParseFloat("jnilclose"); // float 6.2
					block.jnilhigh = query.GetFieldData(block.GetBlockName(), "jnilhigh", i).ParseFloat("jnilhigh"); // float 6.2
					block.jnillow = query.GetFieldData(block.GetBlockName(), "jnillow", i).ParseFloat("jnillow"); // float 6.2
					block.recprice = query.GetFieldData(block.GetBlockName(), "recprice", i).ParseFloat("recprice"); // float 6.2

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
			if (shcode?.Length > 8) return false; // char 8
			if (expcode?.Length > 12) return false; // char 12
			// hprice float 6.2
			// lprice float 6.2
			// jnilclose float 6.2
			// jnilhigh float 6.2
			// jnillow float 6.2
			// recprice float 6.2

			return true;
		}
	}

	/// <summary>
	/// 지수옵션마스터조회API용(t8433)
	/// </summary>
	public partial class XQt8433 : XingQuery
	{
		/// <summary>
		/// t8433
		/// </summary>
		public const string _typeName = "t8433";
		/// <summary>
		/// 지수옵션마스터조회API용(t8433)
		/// </summary>
		public const string _typeDesc = "지수옵션마스터조회API용(t8433)";
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
		/// false
		/// </summary>
		public const bool _attr = false;
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
		/// t8433
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 지수옵션마스터조회API용(t8433)
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
		/// false
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

		public XQt8433() : base("t8433") { }


		public static XQt8433OutBlock[] Get(char dummy = default)
		{
			using (XQt8433 instance = new XQt8433())
			{
				instance.SetFieldData(XQt8433InBlock.BlockName, XQt8433InBlock.F.dummy, 0, dummy.ToString()); // char 1

				if (instance.Request() < 0)
				{
					return null;
				}

				var outBlock = instance.GetBlocks();
				return outBlock;
			}
		}

		public bool SetBlock(XQt8433InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "dummy", 0, block.dummy.ToString()); // char 1

			return true;
		}

		public XQt8433OutBlock[] GetBlocks()
		{
			XQt8433OutBlock[] instance = XQt8433OutBlock.ListFromQuery(this);
			return instance;

		}


	}

}
