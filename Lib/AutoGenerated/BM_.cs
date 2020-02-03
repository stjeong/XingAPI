using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XRBM_InBlock : XingBlock
	{
		/// <summary>
		/// InBlock
		/// </summary>
		static readonly string _blockName = "InBlock";
		/// <summary>
		/// 입력
		/// </summary>
		static readonly string _blockDesc = "입력";
		/// <summary>
		/// input
		/// </summary>
		static readonly string _blockType = "input";
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _hasOccurs = false;
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
		/// 업종코드
		/// </summary>
		[XAQueryFieldAttribute("업종코드")]
		public string upcode;

		public static class F
		{
			/// <summary>
			/// 업종코드
			/// </summary>
			public const string upcode = "upcode";
		}

		public static string[] AllFields = new string[]
		{
			F.upcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["upcode"] = new XAQueryFieldInfo("char", upcode, upcode, "업종코드", (decimal)3);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "upcode":
					this.upcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (upcode.Length > 3) return false; // char 3

			return true;
		}
	}

	public partial class XRBM_OutBlock : XingBlock
	{
		/// <summary>
		/// OutBlock
		/// </summary>
		static readonly string _blockName = "OutBlock";
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
		/// 투자자코드
		/// </summary>
		[XAQueryFieldAttribute("투자자코드")]
		public string tjjcode;
		/// <summary>
		/// 수신시간
		/// </summary>
		[XAQueryFieldAttribute("수신시간")]
		public string tjjtime;
		/// <summary>
		/// 매수 거래량
		/// </summary>
		[XAQueryFieldAttribute("매수 거래량")]
		public long msvolume;
		/// <summary>
		/// 매도 거래량
		/// </summary>
		[XAQueryFieldAttribute("매도 거래량")]
		public long mdvolume;
		/// <summary>
		/// 거래량 순매수
		/// </summary>
		[XAQueryFieldAttribute("거래량 순매수")]
		public long msvol;
		/// <summary>
		/// 거래량 순매수 직전대비
		/// </summary>
		[XAQueryFieldAttribute("거래량 순매수 직전대비")]
		public long p_msvol;
		/// <summary>
		/// 매수 거래대금
		/// </summary>
		[XAQueryFieldAttribute("매수 거래대금")]
		public long msvalue;
		/// <summary>
		/// 매도 거래대금
		/// </summary>
		[XAQueryFieldAttribute("매도 거래대금")]
		public long mdvalue;
		/// <summary>
		/// 거래대금 순매수
		/// </summary>
		[XAQueryFieldAttribute("거래대금 순매수")]
		public long msval;
		/// <summary>
		/// 거래대금 순매수 직전대비
		/// </summary>
		[XAQueryFieldAttribute("거래대금 순매수 직전대비")]
		public long p_msval;
		/// <summary>
		/// 업종코드
		/// </summary>
		[XAQueryFieldAttribute("업종코드")]
		public string upcode;

		public static class F
		{
			/// <summary>
			/// 투자자코드
			/// </summary>
			public const string tjjcode = "tjjcode";
			/// <summary>
			/// 수신시간
			/// </summary>
			public const string tjjtime = "tjjtime";
			/// <summary>
			/// 매수 거래량
			/// </summary>
			public const string msvolume = "msvolume";
			/// <summary>
			/// 매도 거래량
			/// </summary>
			public const string mdvolume = "mdvolume";
			/// <summary>
			/// 거래량 순매수
			/// </summary>
			public const string msvol = "msvol";
			/// <summary>
			/// 거래량 순매수 직전대비
			/// </summary>
			public const string p_msvol = "p_msvol";
			/// <summary>
			/// 매수 거래대금
			/// </summary>
			public const string msvalue = "msvalue";
			/// <summary>
			/// 매도 거래대금
			/// </summary>
			public const string mdvalue = "mdvalue";
			/// <summary>
			/// 거래대금 순매수
			/// </summary>
			public const string msval = "msval";
			/// <summary>
			/// 거래대금 순매수 직전대비
			/// </summary>
			public const string p_msval = "p_msval";
			/// <summary>
			/// 업종코드
			/// </summary>
			public const string upcode = "upcode";
		}

		public static string[] AllFields = new string[]
		{
			F.tjjcode,
			F.tjjtime,
			F.msvolume,
			F.mdvolume,
			F.msvol,
			F.p_msvol,
			F.msvalue,
			F.mdvalue,
			F.msval,
			F.p_msval,
			F.upcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["tjjcode"] = new XAQueryFieldInfo("char", tjjcode, tjjcode, "투자자코드", (decimal)4);
			dict["tjjtime"] = new XAQueryFieldInfo("char", tjjtime, tjjtime, "수신시간", (decimal)8);
			dict["msvolume"] = new XAQueryFieldInfo("long", msvolume, msvolume.ToString("d8"), "매수 거래량", (decimal)8);
			dict["mdvolume"] = new XAQueryFieldInfo("long", mdvolume, mdvolume.ToString("d8"), "매도 거래량", (decimal)8);
			dict["msvol"] = new XAQueryFieldInfo("long", msvol, msvol.ToString("d8"), "거래량 순매수", (decimal)8);
			dict["p_msvol"] = new XAQueryFieldInfo("long", p_msvol, p_msvol.ToString("d8"), "거래량 순매수 직전대비", (decimal)8);
			dict["msvalue"] = new XAQueryFieldInfo("long", msvalue, msvalue.ToString("d6"), "매수 거래대금", (decimal)6);
			dict["mdvalue"] = new XAQueryFieldInfo("long", mdvalue, mdvalue.ToString("d6"), "매도 거래대금", (decimal)6);
			dict["msval"] = new XAQueryFieldInfo("long", msval, msval.ToString("d6"), "거래대금 순매수", (decimal)6);
			dict["p_msval"] = new XAQueryFieldInfo("long", p_msval, p_msval.ToString("d6"), "거래대금 순매수 직전대비", (decimal)6);
			dict["upcode"] = new XAQueryFieldInfo("char", upcode, upcode, "업종코드", (decimal)3);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "tjjcode":
					this.tjjcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "tjjtime":
					this.tjjtime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "msvolume":
					this.msvolume = fieldInfo.FieldValue.ParseLong("msvolume");
				break;

				case "mdvolume":
					this.mdvolume = fieldInfo.FieldValue.ParseLong("mdvolume");
				break;

				case "msvol":
					this.msvol = fieldInfo.FieldValue.ParseLong("msvol");
				break;

				case "p_msvol":
					this.p_msvol = fieldInfo.FieldValue.ParseLong("p_msvol");
				break;

				case "msvalue":
					this.msvalue = fieldInfo.FieldValue.ParseLong("msvalue");
				break;

				case "mdvalue":
					this.mdvalue = fieldInfo.FieldValue.ParseLong("mdvalue");
				break;

				case "msval":
					this.msval = fieldInfo.FieldValue.ParseLong("msval");
				break;

				case "p_msval":
					this.p_msval = fieldInfo.FieldValue.ParseLong("p_msval");
				break;

				case "upcode":
					this.upcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XRBM_OutBlock FromQuery(XRBM_ query)
		{
			XRBM_OutBlock block = new XRBM_OutBlock();
			block.IsValidData = true;
			block.InvalidReason = "";
			try
			{
				block.tjjcode = query.GetFieldData(block.GetBlockName(), "tjjcode").TrimEnd('?'); // char 4
				block.tjjtime = query.GetFieldData(block.GetBlockName(), "tjjtime").TrimEnd('?'); // char 8
				block.msvolume = query.GetFieldData(block.GetBlockName(), "msvolume").ParseLong("msvolume"); // long 8
				block.mdvolume = query.GetFieldData(block.GetBlockName(), "mdvolume").ParseLong("mdvolume"); // long 8
				block.msvol = query.GetFieldData(block.GetBlockName(), "msvol").ParseLong("msvol"); // long 8
				block.p_msvol = query.GetFieldData(block.GetBlockName(), "p_msvol").ParseLong("p_msvol"); // long 8
				block.msvalue = query.GetFieldData(block.GetBlockName(), "msvalue").ParseLong("msvalue"); // long 6
				block.mdvalue = query.GetFieldData(block.GetBlockName(), "mdvalue").ParseLong("mdvalue"); // long 6
				block.msval = query.GetFieldData(block.GetBlockName(), "msval").ParseLong("msval"); // long 6
				block.p_msval = query.GetFieldData(block.GetBlockName(), "p_msval").ParseLong("p_msval"); // long 6
				block.upcode = query.GetFieldData(block.GetBlockName(), "upcode").TrimEnd('?'); // char 3

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (tjjcode.Length > 4) return false; // char 4
			if (tjjtime.Length > 8) return false; // char 8
			if (msvolume.ToString().Length > 8) return false; // long 8
			if (mdvolume.ToString().Length > 8) return false; // long 8
			if (msvol.ToString().Length > 8) return false; // long 8
			if (p_msvol.ToString().Length > 8) return false; // long 8
			if (msvalue.ToString().Length > 6) return false; // long 6
			if (mdvalue.ToString().Length > 6) return false; // long 6
			if (msval.ToString().Length > 6) return false; // long 6
			if (p_msval.ToString().Length > 6) return false; // long 6
			if (upcode.Length > 3) return false; // char 3

			return true;
		}
	}

	public partial class XRBM_ : XingReal
	{
		/// <summary>
		/// BM_
		/// </summary>
		static readonly string _typeName = "BM_";
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _attr = false;
		/// <summary>
		/// 0
		/// </summary>
		static readonly int _key = 0;
		/// <summary>
		/// 0
		/// </summary>
		static readonly int _group = 0;

		/// <summary>
		/// BM_
		/// </summary>
		public string TypeName => _typeName;
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

		public XRBM_() : base("BM_") { }


		public bool SetFields(XRBM_InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaReal.SetFieldData(block.GetBlockName(), "upcode", block.upcode); // char 3

			return true;
		}

		public XRBM_OutBlock GetBlock()
		{
			XRBM_OutBlock instance = XRBM_OutBlock.FromQuery(this);
			return instance;

		}


	}

}
