using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XRNWSInBlock : XingBlock
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
		/// 뉴스코드
		/// </summary>
		[XAQueryFieldAttribute("뉴스코드")]
		public string nwcode;

		public static class F
		{
			/// <summary>
			/// 뉴스코드
			/// </summary>
			public const string nwcode = "nwcode";
		}

		public static string[] AllFields = new string[]
		{
			F.nwcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["nwcode"] = new XAQueryFieldInfo("char", nwcode, nwcode, "뉴스코드", (decimal)6);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "nwcode":
					this.nwcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (nwcode?.Length > 6) return false; // char 6

			return true;
		}
	}

	public partial class XRNWSOutBlock : XingBlock
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
		/// 날짜
		/// </summary>
		[XAQueryFieldAttribute("날짜")]
		public string date;
		/// <summary>
		/// 시간
		/// </summary>
		[XAQueryFieldAttribute("시간")]
		public string time;
		/// <summary>
		/// 뉴스구분자
		/// </summary>
		[XAQueryFieldAttribute("뉴스구분자")]
		public string id;
		/// <summary>
		/// 키값
		/// </summary>
		[XAQueryFieldAttribute("키값")]
		public string realkey;
		/// <summary>
		/// 제목
		/// </summary>
		[XAQueryFieldAttribute("제목")]
		public string title;
		/// <summary>
		/// 단축종목코드
		/// </summary>
		[XAQueryFieldAttribute("단축종목코드")]
		public string code;
		/// <summary>
		/// BODY길이
		/// </summary>
		[XAQueryFieldAttribute("BODY길이")]
		public long bodysize;

		public static class F
		{
			/// <summary>
			/// 날짜
			/// </summary>
			public const string date = "date";
			/// <summary>
			/// 시간
			/// </summary>
			public const string time = "time";
			/// <summary>
			/// 뉴스구분자
			/// </summary>
			public const string id = "id";
			/// <summary>
			/// 키값
			/// </summary>
			public const string realkey = "realkey";
			/// <summary>
			/// 제목
			/// </summary>
			public const string title = "title";
			/// <summary>
			/// 단축종목코드
			/// </summary>
			public const string code = "code";
			/// <summary>
			/// BODY길이
			/// </summary>
			public const string bodysize = "bodysize";
		}

		public static string[] AllFields = new string[]
		{
			F.date,
			F.time,
			F.id,
			F.realkey,
			F.title,
			F.code,
			F.bodysize,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["date"] = new XAQueryFieldInfo("char", date, date, "날짜", (decimal)8);
			dict["time"] = new XAQueryFieldInfo("char", time, time, "시간", (decimal)6);
			dict["id"] = new XAQueryFieldInfo("char", id, id, "뉴스구분자", (decimal)2);
			dict["realkey"] = new XAQueryFieldInfo("char", realkey, realkey, "키값", (decimal)24);
			dict["title"] = new XAQueryFieldInfo("char", title, title, "제목", (decimal)300);
			dict["code"] = new XAQueryFieldInfo("char", code, code, "단축종목코드", (decimal)240);
			dict["bodysize"] = new XAQueryFieldInfo("long", bodysize, bodysize.ToString("d8"), "BODY길이", (decimal)8);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "date":
					this.date = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "time":
					this.time = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "id":
					this.id = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "realkey":
					this.realkey = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "title":
					this.title = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "code":
					this.code = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "bodysize":
					this.bodysize = fieldInfo.FieldValue.ParseLong("bodysize");
				break;


			}
		}

		public static XRNWSOutBlock FromQuery(XRNWS query)
		{
			XRNWSOutBlock block = new XRNWSOutBlock();
			block.IsValidData = true;
			block.InvalidReason = "";
			try
			{
				block.date = query.GetFieldData(block.GetBlockName(), "date").TrimEnd('?'); // char 8
				block.time = query.GetFieldData(block.GetBlockName(), "time").TrimEnd('?'); // char 6
				block.id = query.GetFieldData(block.GetBlockName(), "id").TrimEnd('?'); // char 2
				block.realkey = query.GetFieldData(block.GetBlockName(), "realkey").TrimEnd('?'); // char 24
				block.title = query.GetFieldData(block.GetBlockName(), "title").TrimEnd('?'); // char 300
				block.code = query.GetFieldData(block.GetBlockName(), "code").TrimEnd('?'); // char 240
				block.bodysize = query.GetFieldData(block.GetBlockName(), "bodysize").ParseLong("bodysize"); // long 8

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (date?.Length > 8) return false; // char 8
			if (time?.Length > 6) return false; // char 6
			if (id?.Length > 2) return false; // char 2
			if (realkey?.Length > 24) return false; // char 24
			if (title?.Length > 300) return false; // char 300
			if (code?.Length > 240) return false; // char 240
			if (bodysize.ToString().Length > 8) return false; // long 8

			return true;
		}
	}

	/// <summary>
	/// 실시간 뉴스 제목 패킷(NWS)
	/// </summary>
	public partial class XRNWS : XingReal
	{
		/// <summary>
		/// NWS
		/// </summary>
		public const string _typeName = "NWS";
		/// <summary>
		/// 실시간 뉴스 제목 패킷(NWS)
		/// </summary>
		public const string _typeDesc = "실시간 뉴스 제목 패킷(NWS)";
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
		/// NWS
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 실시간 뉴스 제목 패킷(NWS)
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
		/// 실시간 뉴스 제목 패킷(NWS)
		/// </summary>
		public XRNWS() : base("NWS") { }


		public bool SetBlock(XRNWSInBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaReal.SetFieldData(block.GetBlockName(), "nwcode", block.nwcode); // char 6

			return true;
		}

		public XRNWSOutBlock GetBlock()
		{
			XRNWSOutBlock instance = XRNWSOutBlock.FromQuery(this);
			return instance;

		}


	}

}
