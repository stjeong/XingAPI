using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XRDVIInBlock : XingBlock
	{
		/// <summary>
		/// InBlock
		/// </summary>
		public const string _blockName = "InBlock";
		/// <summary>
		/// 입력
		/// </summary>
		public const string _blockDesc = "입력";
		/// <summary>
		/// input
		/// </summary>
		public const string _blockType = "input";
		/// <summary>
		/// false
		/// </summary>
		public const bool _hasOccurs = false;
		/// <summary>
		/// InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// InBlock
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// 입력
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
		/// 단축코드(KEY)
		/// </summary>
		[XAQueryFieldAttribute("shcode", "단축코드(KEY)", "char", "6")]
		public string shcode;

		public static class F
		{
			/// <summary>
			/// 단축코드(KEY)
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
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드(KEY)", (decimal)6);

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

		public void CopyTo(XRDVIInBlock block)
		{
			block.shcode = this.shcode;

		}
	}

	public partial class XRDVIOutBlock : XingBlock
	{
		/// <summary>
		/// OutBlock
		/// </summary>
		public const string _blockName = "OutBlock";
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
		/// OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// OutBlock
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
		/// 구분(0:해제 1:정적발동 2:동적발동 3:정적&amp;동적)
		/// </summary>
		[XAQueryFieldAttribute("vi_gubun", "구분(0:해제 1:정적발동 2:동적발동 3:정적&동적)", "char", "1")]
		public char vi_gubun;
		/// <summary>
		/// 정적VI발동기준가격
		/// </summary>
		[XAQueryFieldAttribute("svi_recprice", "정적VI발동기준가격", "long", "8")]
		public long svi_recprice;
		/// <summary>
		/// 동적VI발동기준가격
		/// </summary>
		[XAQueryFieldAttribute("dvi_recprice", "동적VI발동기준가격", "long", "8")]
		public long dvi_recprice;
		/// <summary>
		/// VI발동가격
		/// </summary>
		[XAQueryFieldAttribute("vi_trgprice", "VI발동가격", "long", "8")]
		public long vi_trgprice;
		/// <summary>
		/// 단축코드(KEY)
		/// </summary>
		[XAQueryFieldAttribute("shcode", "단축코드(KEY)", "char", "6")]
		public string shcode;
		/// <summary>
		/// 참조코드(미사용)
		/// </summary>
		[XAQueryFieldAttribute("ref_shcode", "참조코드(미사용)", "char", "6")]
		public string ref_shcode;
		/// <summary>
		/// 시간
		/// </summary>
		[XAQueryFieldAttribute("time", "시간", "char", "6")]
		public string time;

		public static class F
		{
			/// <summary>
			/// 구분(0:해제 1:정적발동 2:동적발동 3:정적&amp;동적)
			/// </summary>
			public const string vi_gubun = "vi_gubun";
			/// <summary>
			/// 정적VI발동기준가격
			/// </summary>
			public const string svi_recprice = "svi_recprice";
			/// <summary>
			/// 동적VI발동기준가격
			/// </summary>
			public const string dvi_recprice = "dvi_recprice";
			/// <summary>
			/// VI발동가격
			/// </summary>
			public const string vi_trgprice = "vi_trgprice";
			/// <summary>
			/// 단축코드(KEY)
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 참조코드(미사용)
			/// </summary>
			public const string ref_shcode = "ref_shcode";
			/// <summary>
			/// 시간
			/// </summary>
			public const string time = "time";
		}

		public static string[] AllFields = new string[]
		{
			F.vi_gubun,
			F.svi_recprice,
			F.dvi_recprice,
			F.vi_trgprice,
			F.shcode,
			F.ref_shcode,
			F.time,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["vi_gubun"] = new XAQueryFieldInfo("char", vi_gubun, vi_gubun.ToString(), "구분(0:해제 1:정적발동 2:동적발동 3:정적&동적)", (decimal)1);
			dict["svi_recprice"] = new XAQueryFieldInfo("long", svi_recprice, svi_recprice.ToString("d8"), "정적VI발동기준가격", (decimal)8);
			dict["dvi_recprice"] = new XAQueryFieldInfo("long", dvi_recprice, dvi_recprice.ToString("d8"), "동적VI발동기준가격", (decimal)8);
			dict["vi_trgprice"] = new XAQueryFieldInfo("long", vi_trgprice, vi_trgprice.ToString("d8"), "VI발동가격", (decimal)8);
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드(KEY)", (decimal)6);
			dict["ref_shcode"] = new XAQueryFieldInfo("char", ref_shcode, ref_shcode, "참조코드(미사용)", (decimal)6);
			dict["time"] = new XAQueryFieldInfo("char", time, time, "시간", (decimal)6);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "vi_gubun":
					this.vi_gubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "svi_recprice":
					this.svi_recprice = fieldInfo.FieldValue.ParseLong("svi_recprice");
				break;

				case "dvi_recprice":
					this.dvi_recprice = fieldInfo.FieldValue.ParseLong("dvi_recprice");
				break;

				case "vi_trgprice":
					this.vi_trgprice = fieldInfo.FieldValue.ParseLong("vi_trgprice");
				break;

				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ref_shcode":
					this.ref_shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "time":
					this.time = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XRDVIOutBlock FromQuery(XRDVI query)
		{
			XRDVIOutBlock block = new XRDVIOutBlock();
			block.IsValidData = true;
			block.InvalidReason = "";
			try
			{
				block.vi_gubun = query.GetFieldData(block.GetBlockName(), "vi_gubun").FirstOrDefault(); // char 1
				block.svi_recprice = query.GetFieldData(block.GetBlockName(), "svi_recprice").ParseLong("svi_recprice"); // long 8
				block.dvi_recprice = query.GetFieldData(block.GetBlockName(), "dvi_recprice").ParseLong("dvi_recprice"); // long 8
				block.vi_trgprice = query.GetFieldData(block.GetBlockName(), "vi_trgprice").ParseLong("vi_trgprice"); // long 8
				block.shcode = query.GetFieldData(block.GetBlockName(), "shcode").TrimEnd('?'); // char 6
				block.ref_shcode = query.GetFieldData(block.GetBlockName(), "ref_shcode").TrimEnd('?'); // char 6
				block.time = query.GetFieldData(block.GetBlockName(), "time").TrimEnd('?'); // char 6

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			// vi_gubun char 1
			if (svi_recprice.ToString().Length > 8) return false; // long 8
			if (dvi_recprice.ToString().Length > 8) return false; // long 8
			if (vi_trgprice.ToString().Length > 8) return false; // long 8
			if (shcode?.Length > 6) return false; // char 6
			if (ref_shcode?.Length > 6) return false; // char 6
			if (time?.Length > 6) return false; // char 6

			return true;
		}

		public void CopyTo(XRDVIOutBlock block)
		{
			block.vi_gubun = this.vi_gubun;
			block.svi_recprice = this.svi_recprice;
			block.dvi_recprice = this.dvi_recprice;
			block.vi_trgprice = this.vi_trgprice;
			block.shcode = this.shcode;
			block.ref_shcode = this.ref_shcode;
			block.time = this.time;

		}
	}

	/// <summary>
	/// 시간외단일가VI발동해제(DVI)
	/// </summary>
	public partial class XRDVI : XingReal
	{
		/// <summary>
		/// DVI
		/// </summary>
		public const string _typeName = "DVI";
		/// <summary>
		/// 시간외단일가VI발동해제(DVI)
		/// </summary>
		public const string _typeDesc = "시간외단일가VI발동해제(DVI)";
		/// <summary>
		/// false
		/// </summary>
		public const bool _attr = false;
		/// <summary>
		/// 0
		/// </summary>
		public const int _key = 0;
		/// <summary>
		/// 0
		/// </summary>
		public const int _group = 0;

		/// <summary>
		/// DVI
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 시간외단일가VI발동해제(DVI)
		/// </summary>
		public string TypeDesc => _typeDesc;
		/// <summary>
		/// false
		/// </summary>
		public bool Attr => _attr;
		/// <summary>
		/// 0
		/// </summary>
		public int Key => _key;
		/// <summary>
		/// 0
		/// </summary>
		public int Group => _group;

		/// <summary>
		/// 시간외단일가VI발동해제(DVI)
		/// </summary>
		public XRDVI() : base("DVI") { }


		public bool SetBlock(XRDVIInBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaReal.SetFieldData(block.GetBlockName(), "shcode", block.shcode); // char 6

			return true;
		}

		public XRDVIOutBlock GetBlock()
		{
			XRDVIOutBlock instance = XRDVIOutBlock.FromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XRDVIOutBlock),

		};

	}

}
