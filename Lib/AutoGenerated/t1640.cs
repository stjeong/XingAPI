using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1640InBlock : XingBlock
	{
		/// <summary>
		/// t1640InBlock
		/// </summary>
		public const string _blockName = "t1640InBlock";
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
		/// t1640InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1640InBlock
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
		public string gubun;

		public static class F
		{
			/// <summary>
			/// 구분
			/// </summary>
			public const string gubun = "gubun";
		}

		public static string[] AllFields = new string[]
		{
			F.gubun,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["gubun"] = new XAQueryFieldInfo("char", gubun, gubun, "구분", (decimal)2);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "gubun":
					this.gubun = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (gubun?.Length > 2) return false; // char 2

			return true;
		}
	}

	public partial class XQt1640OutBlock : XingBlock
	{
		/// <summary>
		/// t1640OutBlock
		/// </summary>
		public const string _blockName = "t1640OutBlock";
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
		/// t1640OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1640OutBlock
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
		/// 매도수량
		/// </summary>
		[XAQueryFieldAttribute("매도수량")]
		public long offervolume;
		/// <summary>
		/// 매수수량
		/// </summary>
		[XAQueryFieldAttribute("매수수량")]
		public long bidvolume;
		/// <summary>
		/// 순매수수량
		/// </summary>
		[XAQueryFieldAttribute("순매수수량")]
		public long volume;
		/// <summary>
		/// 매도증감
		/// </summary>
		[XAQueryFieldAttribute("매도증감")]
		public long offerdiff;
		/// <summary>
		/// 매수증감
		/// </summary>
		[XAQueryFieldAttribute("매수증감")]
		public long biddiff;
		/// <summary>
		/// 순매수증감
		/// </summary>
		[XAQueryFieldAttribute("순매수증감")]
		public long sundiff;
		/// <summary>
		/// 베이시스
		/// </summary>
		[XAQueryFieldAttribute("베이시스")]
		public float basis;
		/// <summary>
		/// 매도금액
		/// </summary>
		[XAQueryFieldAttribute("매도금액")]
		public double offervalue;
		/// <summary>
		/// 매수금액
		/// </summary>
		[XAQueryFieldAttribute("매수금액")]
		public double bidvalue;
		/// <summary>
		/// 순매수금액
		/// </summary>
		[XAQueryFieldAttribute("순매수금액")]
		public double value;
		/// <summary>
		/// 매도금액증감
		/// </summary>
		[XAQueryFieldAttribute("매도금액증감")]
		public double offervaldiff;
		/// <summary>
		/// 매수금액증감
		/// </summary>
		[XAQueryFieldAttribute("매수금액증감")]
		public double bidvaldiff;
		/// <summary>
		/// 순매수증감
		/// </summary>
		[XAQueryFieldAttribute("순매수증감")]
		public double sunvaldiff;

		public static class F
		{
			/// <summary>
			/// 매도수량
			/// </summary>
			public const string offervolume = "offervolume";
			/// <summary>
			/// 매수수량
			/// </summary>
			public const string bidvolume = "bidvolume";
			/// <summary>
			/// 순매수수량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// 매도증감
			/// </summary>
			public const string offerdiff = "offerdiff";
			/// <summary>
			/// 매수증감
			/// </summary>
			public const string biddiff = "biddiff";
			/// <summary>
			/// 순매수증감
			/// </summary>
			public const string sundiff = "sundiff";
			/// <summary>
			/// 베이시스
			/// </summary>
			public const string basis = "basis";
			/// <summary>
			/// 매도금액
			/// </summary>
			public const string offervalue = "offervalue";
			/// <summary>
			/// 매수금액
			/// </summary>
			public const string bidvalue = "bidvalue";
			/// <summary>
			/// 순매수금액
			/// </summary>
			public const string value = "value";
			/// <summary>
			/// 매도금액증감
			/// </summary>
			public const string offervaldiff = "offervaldiff";
			/// <summary>
			/// 매수금액증감
			/// </summary>
			public const string bidvaldiff = "bidvaldiff";
			/// <summary>
			/// 순매수증감
			/// </summary>
			public const string sunvaldiff = "sunvaldiff";
		}

		public static string[] AllFields = new string[]
		{
			F.offervolume,
			F.bidvolume,
			F.volume,
			F.offerdiff,
			F.biddiff,
			F.sundiff,
			F.basis,
			F.offervalue,
			F.bidvalue,
			F.value,
			F.offervaldiff,
			F.bidvaldiff,
			F.sunvaldiff,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["offervolume"] = new XAQueryFieldInfo("long", offervolume, offervolume.ToString("d8"), "매도수량", (decimal)8);
			dict["bidvolume"] = new XAQueryFieldInfo("long", bidvolume, bidvolume.ToString("d8"), "매수수량", (decimal)8);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d8"), "순매수수량", (decimal)8);
			dict["offerdiff"] = new XAQueryFieldInfo("long", offerdiff, offerdiff.ToString("d8"), "매도증감", (decimal)8);
			dict["biddiff"] = new XAQueryFieldInfo("long", biddiff, biddiff.ToString("d8"), "매수증감", (decimal)8);
			dict["sundiff"] = new XAQueryFieldInfo("long", sundiff, sundiff.ToString("d8"), "순매수증감", (decimal)8);
			dict["basis"] = new XAQueryFieldInfo("float", basis, basis.ToString("000000.00"), "베이시스", (decimal)6.2);
			dict["offervalue"] = new XAQueryFieldInfo("double", offervalue, offervalue.ToString("000000000000."), "매도금액", (decimal)12.0);
			dict["bidvalue"] = new XAQueryFieldInfo("double", bidvalue, bidvalue.ToString("000000000000."), "매수금액", (decimal)12.0);
			dict["value"] = new XAQueryFieldInfo("double", value, value.ToString("000000000000."), "순매수금액", (decimal)12.0);
			dict["offervaldiff"] = new XAQueryFieldInfo("double", offervaldiff, offervaldiff.ToString("000000000000."), "매도금액증감", (decimal)12.0);
			dict["bidvaldiff"] = new XAQueryFieldInfo("double", bidvaldiff, bidvaldiff.ToString("000000000000."), "매수금액증감", (decimal)12.0);
			dict["sunvaldiff"] = new XAQueryFieldInfo("double", sunvaldiff, sunvaldiff.ToString("000000000000."), "순매수증감", (decimal)12.0);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "offervolume":
					this.offervolume = fieldInfo.FieldValue.ParseLong("offervolume");
				break;

				case "bidvolume":
					this.bidvolume = fieldInfo.FieldValue.ParseLong("bidvolume");
				break;

				case "volume":
					this.volume = fieldInfo.FieldValue.ParseLong("volume");
				break;

				case "offerdiff":
					this.offerdiff = fieldInfo.FieldValue.ParseLong("offerdiff");
				break;

				case "biddiff":
					this.biddiff = fieldInfo.FieldValue.ParseLong("biddiff");
				break;

				case "sundiff":
					this.sundiff = fieldInfo.FieldValue.ParseLong("sundiff");
				break;

				case "basis":
					this.basis = fieldInfo.FieldValue.ParseFloat("basis");
				break;

				case "offervalue":
					this.offervalue = fieldInfo.FieldValue.ParseDouble("offervalue");
				break;

				case "bidvalue":
					this.bidvalue = fieldInfo.FieldValue.ParseDouble("bidvalue");
				break;

				case "value":
					this.value = fieldInfo.FieldValue.ParseDouble("value");
				break;

				case "offervaldiff":
					this.offervaldiff = fieldInfo.FieldValue.ParseDouble("offervaldiff");
				break;

				case "bidvaldiff":
					this.bidvaldiff = fieldInfo.FieldValue.ParseDouble("bidvaldiff");
				break;

				case "sunvaldiff":
					this.sunvaldiff = fieldInfo.FieldValue.ParseDouble("sunvaldiff");
				break;


			}
		}

		public static XQt1640OutBlock FromQuery(XQt1640 query)
		{
			XQt1640OutBlock block = new XQt1640OutBlock();
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
				block.offervolume = query.GetFieldData(block.GetBlockName(), "offervolume", 0).ParseLong("offervolume"); // long 8
				block.bidvolume = query.GetFieldData(block.GetBlockName(), "bidvolume", 0).ParseLong("bidvolume"); // long 8
				block.volume = query.GetFieldData(block.GetBlockName(), "volume", 0).ParseLong("volume"); // long 8
				block.offerdiff = query.GetFieldData(block.GetBlockName(), "offerdiff", 0).ParseLong("offerdiff"); // long 8
				block.biddiff = query.GetFieldData(block.GetBlockName(), "biddiff", 0).ParseLong("biddiff"); // long 8
				block.sundiff = query.GetFieldData(block.GetBlockName(), "sundiff", 0).ParseLong("sundiff"); // long 8
				block.basis = query.GetFieldData(block.GetBlockName(), "basis", 0).ParseFloat("basis"); // float 6.2
				block.offervalue = query.GetFieldData(block.GetBlockName(), "offervalue", 0).ParseDouble("offervalue"); // double 12.0
				block.bidvalue = query.GetFieldData(block.GetBlockName(), "bidvalue", 0).ParseDouble("bidvalue"); // double 12.0
				block.value = query.GetFieldData(block.GetBlockName(), "value", 0).ParseDouble("value"); // double 12.0
				block.offervaldiff = query.GetFieldData(block.GetBlockName(), "offervaldiff", 0).ParseDouble("offervaldiff"); // double 12.0
				block.bidvaldiff = query.GetFieldData(block.GetBlockName(), "bidvaldiff", 0).ParseDouble("bidvaldiff"); // double 12.0
				block.sunvaldiff = query.GetFieldData(block.GetBlockName(), "sunvaldiff", 0).ParseDouble("sunvaldiff"); // double 12.0

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (offervolume.ToString().Length > 8) return false; // long 8
			if (bidvolume.ToString().Length > 8) return false; // long 8
			if (volume.ToString().Length > 8) return false; // long 8
			if (offerdiff.ToString().Length > 8) return false; // long 8
			if (biddiff.ToString().Length > 8) return false; // long 8
			if (sundiff.ToString().Length > 8) return false; // long 8
			// basis float 6.2
			// offervalue double 12.0
			// bidvalue double 12.0
			// value double 12.0
			// offervaldiff double 12.0
			// bidvaldiff double 12.0
			// sunvaldiff double 12.0

			return true;
		}
	}

	/// <summary>
	/// 프로그램매매종합조회(미니)(t1640)
	/// </summary>
	public partial class XQt1640 : XingQuery
	{
		/// <summary>
		/// t1640
		/// </summary>
		public const string _typeName = "t1640";
		/// <summary>
		/// 프로그램매매종합조회(미니)(t1640)
		/// </summary>
		public const string _typeDesc = "프로그램매매종합조회(미니)(t1640)";
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
		/// t1640
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 프로그램매매종합조회(미니)(t1640)
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
		/// 프로그램매매종합조회(미니)(t1640)
		/// </summary>
		public XQt1640() : base("t1640") { }


		public static XQt1640OutBlock Get(string gubun = default)
		{
			using (XQt1640 instance = new XQt1640())
			{
				instance.SetFieldData(XQt1640InBlock.BlockName, XQt1640InBlock.F.gubun, 0, gubun); // char 2

				if (instance.Request() < 0)
				{
					return null;
				}

				var outBlock = instance.GetBlock();
				if (outBlock.IsValidData == false)
				{
					return null;
				}
				return outBlock;
			}
		}

		public bool SetBlock(XQt1640InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "gubun", 0, block.gubun); // char 2

			return true;
		}

		public XQt1640OutBlock GetBlock()
		{
			XQt1640OutBlock instance = XQt1640OutBlock.FromQuery(this);
			return instance;

		}


	}

}
