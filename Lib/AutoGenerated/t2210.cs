using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt2210InBlock : XingBlock
	{
		/// <summary>
		/// t2210InBlock
		/// </summary>
		public const string _blockName = "t2210InBlock";
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
		/// t2210InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t2210InBlock
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
		public string focode;
		/// <summary>
		/// 특이거래량
		/// </summary>
		[XAQueryFieldAttribute("특이거래량")]
		public long cvolume;
		/// <summary>
		/// 시작시간
		/// </summary>
		[XAQueryFieldAttribute("시작시간")]
		public string stime;
		/// <summary>
		/// 종료시간
		/// </summary>
		[XAQueryFieldAttribute("종료시간")]
		public string etime;

		public static class F
		{
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string focode = "focode";
			/// <summary>
			/// 특이거래량
			/// </summary>
			public const string cvolume = "cvolume";
			/// <summary>
			/// 시작시간
			/// </summary>
			public const string stime = "stime";
			/// <summary>
			/// 종료시간
			/// </summary>
			public const string etime = "etime";
		}

		public static string[] AllFields = new string[]
		{
			F.focode,
			F.cvolume,
			F.stime,
			F.etime,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["focode"] = new XAQueryFieldInfo("char", focode, focode, "단축코드", (decimal)8);
			dict["cvolume"] = new XAQueryFieldInfo("long", cvolume, cvolume.ToString("d12"), "특이거래량", (decimal)12);
			dict["stime"] = new XAQueryFieldInfo("char", stime, stime, "시작시간", (decimal)4);
			dict["etime"] = new XAQueryFieldInfo("char", etime, etime, "종료시간", (decimal)4);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "focode":
					this.focode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cvolume":
					this.cvolume = fieldInfo.FieldValue.ParseLong("cvolume");
				break;

				case "stime":
					this.stime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "etime":
					this.etime = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (focode?.Length > 8) return false; // char 8
			if (cvolume.ToString().Length > 12) return false; // long 12
			if (stime?.Length > 4) return false; // char 4
			if (etime?.Length > 4) return false; // char 4

			return true;
		}
	}

	public partial class XQt2210OutBlock : XingBlock
	{
		/// <summary>
		/// t2210OutBlock
		/// </summary>
		public const string _blockName = "t2210OutBlock";
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
		/// t2210OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t2210OutBlock
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
		/// 매도체결수량
		/// </summary>
		[XAQueryFieldAttribute("매도체결수량")]
		public long mdvolume;
		/// <summary>
		/// 매도체결건수
		/// </summary>
		[XAQueryFieldAttribute("매도체결건수")]
		public long mdchecnt;
		/// <summary>
		/// 매수체결수량
		/// </summary>
		[XAQueryFieldAttribute("매수체결수량")]
		public long msvolume;
		/// <summary>
		/// 매수체결건수
		/// </summary>
		[XAQueryFieldAttribute("매수체결건수")]
		public long mschecnt;

		public static class F
		{
			/// <summary>
			/// 매도체결수량
			/// </summary>
			public const string mdvolume = "mdvolume";
			/// <summary>
			/// 매도체결건수
			/// </summary>
			public const string mdchecnt = "mdchecnt";
			/// <summary>
			/// 매수체결수량
			/// </summary>
			public const string msvolume = "msvolume";
			/// <summary>
			/// 매수체결건수
			/// </summary>
			public const string mschecnt = "mschecnt";
		}

		public static string[] AllFields = new string[]
		{
			F.mdvolume,
			F.mdchecnt,
			F.msvolume,
			F.mschecnt,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["mdvolume"] = new XAQueryFieldInfo("long", mdvolume, mdvolume.ToString("d8"), "매도체결수량", (decimal)8);
			dict["mdchecnt"] = new XAQueryFieldInfo("long", mdchecnt, mdchecnt.ToString("d8"), "매도체결건수", (decimal)8);
			dict["msvolume"] = new XAQueryFieldInfo("long", msvolume, msvolume.ToString("d8"), "매수체결수량", (decimal)8);
			dict["mschecnt"] = new XAQueryFieldInfo("long", mschecnt, mschecnt.ToString("d8"), "매수체결건수", (decimal)8);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "mdvolume":
					this.mdvolume = fieldInfo.FieldValue.ParseLong("mdvolume");
				break;

				case "mdchecnt":
					this.mdchecnt = fieldInfo.FieldValue.ParseLong("mdchecnt");
				break;

				case "msvolume":
					this.msvolume = fieldInfo.FieldValue.ParseLong("msvolume");
				break;

				case "mschecnt":
					this.mschecnt = fieldInfo.FieldValue.ParseLong("mschecnt");
				break;


			}
		}

		public static XQt2210OutBlock FromQuery(XQt2210 query)
		{
			XQt2210OutBlock block = new XQt2210OutBlock();
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
				block.mdvolume = query.GetFieldData(block.GetBlockName(), "mdvolume", 0).ParseLong("mdvolume"); // long 8
				block.mdchecnt = query.GetFieldData(block.GetBlockName(), "mdchecnt", 0).ParseLong("mdchecnt"); // long 8
				block.msvolume = query.GetFieldData(block.GetBlockName(), "msvolume", 0).ParseLong("msvolume"); // long 8
				block.mschecnt = query.GetFieldData(block.GetBlockName(), "mschecnt", 0).ParseLong("mschecnt"); // long 8

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (mdvolume.ToString().Length > 8) return false; // long 8
			if (mdchecnt.ToString().Length > 8) return false; // long 8
			if (msvolume.ToString().Length > 8) return false; // long 8
			if (mschecnt.ToString().Length > 8) return false; // long 8

			return true;
		}
	}

	public partial class XQt2210 : XingQuery
	{
		/// <summary>
		/// t2210
		/// </summary>
		public const string _typeName = "t2210";
		/// <summary>
		/// 선물옵션시간대별체결조회(단일출력용)
		/// </summary>
		public const string _typeDesc = "선물옵션시간대별체결조회(단일출력용)";
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
		/// t2210
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 선물옵션시간대별체결조회(단일출력용)
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

		public XQt2210() : base("t2210") { }


		public static XQt2210OutBlock Get(string focode = default,long cvolume = default,string stime = default,string etime = default)
		{
			using (XQt2210 instance = new XQt2210())
			{
				instance.SetFieldData(XQt2210InBlock.BlockName, XQt2210InBlock.F.focode, 0, focode); // char 8
				instance.SetFieldData(XQt2210InBlock.BlockName, XQt2210InBlock.F.cvolume, 0, cvolume.ToString("d12")); // long 12
				instance.SetFieldData(XQt2210InBlock.BlockName, XQt2210InBlock.F.stime, 0, stime); // char 4
				instance.SetFieldData(XQt2210InBlock.BlockName, XQt2210InBlock.F.etime, 0, etime); // char 4

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

		public bool SetBlock(XQt2210InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "focode", 0, block.focode); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "cvolume", 0, block.cvolume.ToString("d12")); // long 12
			_xaQuery.SetFieldData(block.GetBlockName(), "stime", 0, block.stime); // char 4
			_xaQuery.SetFieldData(block.GetBlockName(), "etime", 0, block.etime); // char 4

			return true;
		}

		public XQt2210OutBlock GetBlock()
		{
			XQt2210OutBlock instance = XQt2210OutBlock.FromQuery(this);
			return instance;

		}


	}

}
