using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1105InBlock : XingBlock
	{
		/// <summary>
		/// t1105InBlock
		/// </summary>
		public const string _blockName = "t1105InBlock";
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
		/// t1105InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1105InBlock
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
		[XAQueryFieldAttribute("shcode", "단축코드", "char", "6")]
		public string shcode;

		public static class F
		{
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string shcode = "shcode";
		}

		public static string[] AllFields = new string[]
		{
			F.shcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)6);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (shcode?.Length > 6) return false; // char 6

			return true;
		}
	}

	public partial class XQt1105OutBlock : XingBlock
	{
		/// <summary>
		/// t1105OutBlock
		/// </summary>
		public const string _blockName = "t1105OutBlock";
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
		/// t1105OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1105OutBlock
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
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("shcode", "단축코드", "char", "6")]
		public string shcode;
		/// <summary>
		/// 피봇
		/// </summary>
		[XAQueryFieldAttribute("pbot", "피봇", "long", "8")]
		public long pbot;
		/// <summary>
		/// 1차저항
		/// </summary>
		[XAQueryFieldAttribute("offer1", "1차저항", "long", "8")]
		public long offer1;
		/// <summary>
		/// 1차지지
		/// </summary>
		[XAQueryFieldAttribute("supp1", "1차지지", "long", "8")]
		public long supp1;
		/// <summary>
		/// 2차저항
		/// </summary>
		[XAQueryFieldAttribute("offer2", "2차저항", "long", "8")]
		public long offer2;
		/// <summary>
		/// 2차지지
		/// </summary>
		[XAQueryFieldAttribute("supp2", "2차지지", "long", "8")]
		public long supp2;
		/// <summary>
		/// 기준가격
		/// </summary>
		[XAQueryFieldAttribute("stdprc", "기준가격", "long", "8")]
		public long stdprc;
		/// <summary>
		/// D저항
		/// </summary>
		[XAQueryFieldAttribute("offerd", "D저항", "long", "8")]
		public long offerd;
		/// <summary>
		/// D지지
		/// </summary>
		[XAQueryFieldAttribute("suppd", "D지지", "long", "8")]
		public long suppd;

		public static class F
		{
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 피봇
			/// </summary>
			public const string pbot = "pbot";
			/// <summary>
			/// 1차저항
			/// </summary>
			public const string offer1 = "offer1";
			/// <summary>
			/// 1차지지
			/// </summary>
			public const string supp1 = "supp1";
			/// <summary>
			/// 2차저항
			/// </summary>
			public const string offer2 = "offer2";
			/// <summary>
			/// 2차지지
			/// </summary>
			public const string supp2 = "supp2";
			/// <summary>
			/// 기준가격
			/// </summary>
			public const string stdprc = "stdprc";
			/// <summary>
			/// D저항
			/// </summary>
			public const string offerd = "offerd";
			/// <summary>
			/// D지지
			/// </summary>
			public const string suppd = "suppd";
		}

		public static string[] AllFields = new string[]
		{
			F.shcode,
			F.pbot,
			F.offer1,
			F.supp1,
			F.offer2,
			F.supp2,
			F.stdprc,
			F.offerd,
			F.suppd,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)6);
			dict["pbot"] = new XAQueryFieldInfo("long", pbot, pbot.ToString("d8"), "피봇", (decimal)8);
			dict["offer1"] = new XAQueryFieldInfo("long", offer1, offer1.ToString("d8"), "1차저항", (decimal)8);
			dict["supp1"] = new XAQueryFieldInfo("long", supp1, supp1.ToString("d8"), "1차지지", (decimal)8);
			dict["offer2"] = new XAQueryFieldInfo("long", offer2, offer2.ToString("d8"), "2차저항", (decimal)8);
			dict["supp2"] = new XAQueryFieldInfo("long", supp2, supp2.ToString("d8"), "2차지지", (decimal)8);
			dict["stdprc"] = new XAQueryFieldInfo("long", stdprc, stdprc.ToString("d8"), "기준가격", (decimal)8);
			dict["offerd"] = new XAQueryFieldInfo("long", offerd, offerd.ToString("d8"), "D저항", (decimal)8);
			dict["suppd"] = new XAQueryFieldInfo("long", suppd, suppd.ToString("d8"), "D지지", (decimal)8);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "pbot":
					this.pbot = fieldInfo.FieldValue.ParseLong("pbot");
				break;

				case "offer1":
					this.offer1 = fieldInfo.FieldValue.ParseLong("offer1");
				break;

				case "supp1":
					this.supp1 = fieldInfo.FieldValue.ParseLong("supp1");
				break;

				case "offer2":
					this.offer2 = fieldInfo.FieldValue.ParseLong("offer2");
				break;

				case "supp2":
					this.supp2 = fieldInfo.FieldValue.ParseLong("supp2");
				break;

				case "stdprc":
					this.stdprc = fieldInfo.FieldValue.ParseLong("stdprc");
				break;

				case "offerd":
					this.offerd = fieldInfo.FieldValue.ParseLong("offerd");
				break;

				case "suppd":
					this.suppd = fieldInfo.FieldValue.ParseLong("suppd");
				break;


			}
		}

		public static XQt1105OutBlock FromQuery(XQt1105 query)
		{
			XQt1105OutBlock block = new XQt1105OutBlock();
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
				block.shcode = query.GetFieldData(block.GetBlockName(), "shcode", 0).TrimEnd('?'); // char 6
				block.pbot = query.GetFieldData(block.GetBlockName(), "pbot", 0).ParseLong("pbot"); // long 8
				block.offer1 = query.GetFieldData(block.GetBlockName(), "offer1", 0).ParseLong("offer1"); // long 8
				block.supp1 = query.GetFieldData(block.GetBlockName(), "supp1", 0).ParseLong("supp1"); // long 8
				block.offer2 = query.GetFieldData(block.GetBlockName(), "offer2", 0).ParseLong("offer2"); // long 8
				block.supp2 = query.GetFieldData(block.GetBlockName(), "supp2", 0).ParseLong("supp2"); // long 8
				block.stdprc = query.GetFieldData(block.GetBlockName(), "stdprc", 0).ParseLong("stdprc"); // long 8
				block.offerd = query.GetFieldData(block.GetBlockName(), "offerd", 0).ParseLong("offerd"); // long 8
				block.suppd = query.GetFieldData(block.GetBlockName(), "suppd", 0).ParseLong("suppd"); // long 8

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (shcode?.Length > 6) return false; // char 6
			if (pbot.ToString().Length > 8) return false; // long 8
			if (offer1.ToString().Length > 8) return false; // long 8
			if (supp1.ToString().Length > 8) return false; // long 8
			if (offer2.ToString().Length > 8) return false; // long 8
			if (supp2.ToString().Length > 8) return false; // long 8
			if (stdprc.ToString().Length > 8) return false; // long 8
			if (offerd.ToString().Length > 8) return false; // long 8
			if (suppd.ToString().Length > 8) return false; // long 8

			return true;
		}
	}

	/// <summary>
	/// 주식피못/디마크조회(t1105)
	/// </summary>
	public partial class XQt1105 : XingQuery
	{
		/// <summary>
		/// t1105
		/// </summary>
		public const string _typeName = "t1105";
		/// <summary>
		/// 주식피못/디마크조회(t1105)
		/// </summary>
		public const string _typeDesc = "주식피못/디마크조회(t1105)";
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
		/// t1105
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 주식피못/디마크조회(t1105)
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
		/// 주식피못/디마크조회(t1105)
		/// </summary>
		public XQt1105() : base("t1105") { }


		public static XQt1105OutBlock Get(string shcode = default)
		{
			using (XQt1105 instance = new XQt1105())
			{
				instance.SetFieldData(XQt1105InBlock.BlockName, XQt1105InBlock.F.shcode, 0, shcode); // char 6

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

		public static XQt1105OutBlock ReadFromDB(/* string shcode = default */)
		{
			using (XQt1105 instance = new XQt1105())
			{

				QueryOption qo = new QueryOption("XQt1105OutBlock");
				// if (shcode != default) qo.Add("shcode", shcode);


				var outBlock = instance.Select<XQt1105OutBlock>(qo);
				return outBlock;
			}
		}

		public bool SetBlock(XQt1105InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "shcode", 0, block.shcode); // char 6

			return true;
		}

		public XQt1105OutBlock GetBlock()
		{
			XQt1105OutBlock instance = XQt1105OutBlock.FromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt1105OutBlock),

		};

	}

}
