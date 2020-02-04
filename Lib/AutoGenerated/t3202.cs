using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt3202InBlock : XingBlock
	{
		/// <summary>
		/// t3202InBlock
		/// </summary>
		public const string _blockName = "t3202InBlock";
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
		/// t3202InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t3202InBlock
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
		/// 종목코드
		/// </summary>
		[XAQueryFieldAttribute("종목코드")]
		public string shcode;
		/// <summary>
		/// 조회일자
		/// </summary>
		[XAQueryFieldAttribute("조회일자")]
		public string date;

		public static class F
		{
			/// <summary>
			/// 종목코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 조회일자
			/// </summary>
			public const string date = "date";
		}

		public static string[] AllFields = new string[]
		{
			F.shcode,
			F.date,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "종목코드", (decimal)6);
			dict["date"] = new XAQueryFieldInfo("char", date, date, "조회일자", (decimal)8);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "date":
					this.date = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (shcode?.Length > 6) return false; // char 6
			if (date?.Length > 8) return false; // char 8

			return true;
		}
	}

	public partial class XQt3202OutBlock : XingBlock
	{
		/// <summary>
		/// t3202OutBlock
		/// </summary>
		public const string _blockName = "t3202OutBlock";
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
		/// t3202OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t3202OutBlock
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
		/// 기준일
		/// </summary>
		[XAQueryFieldAttribute("기준일")]
		public string recdt;
		/// <summary>
		/// 테이블아이디
		/// </summary>
		[XAQueryFieldAttribute("테이블아이디")]
		public string tableid;
		/// <summary>
		/// 업무구분
		/// </summary>
		[XAQueryFieldAttribute("업무구분")]
		public string upgu;
		/// <summary>
		/// 발행체번호
		/// </summary>
		[XAQueryFieldAttribute("발행체번호")]
		public string custno;
		/// <summary>
		/// 발행회사명
		/// </summary>
		[XAQueryFieldAttribute("발행회사명")]
		public string custnm;
		/// <summary>
		/// 종목코드
		/// </summary>
		[XAQueryFieldAttribute("종목코드")]
		public string shcode;
		/// <summary>
		/// 업무명
		/// </summary>
		[XAQueryFieldAttribute("업무명")]
		public string upnm;

		public static class F
		{
			/// <summary>
			/// 기준일
			/// </summary>
			public const string recdt = "recdt";
			/// <summary>
			/// 테이블아이디
			/// </summary>
			public const string tableid = "tableid";
			/// <summary>
			/// 업무구분
			/// </summary>
			public const string upgu = "upgu";
			/// <summary>
			/// 발행체번호
			/// </summary>
			public const string custno = "custno";
			/// <summary>
			/// 발행회사명
			/// </summary>
			public const string custnm = "custnm";
			/// <summary>
			/// 종목코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 업무명
			/// </summary>
			public const string upnm = "upnm";
		}

		public static string[] AllFields = new string[]
		{
			F.recdt,
			F.tableid,
			F.upgu,
			F.custno,
			F.custnm,
			F.shcode,
			F.upnm,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["recdt"] = new XAQueryFieldInfo("char", recdt, recdt, "기준일", (decimal)8);
			dict["tableid"] = new XAQueryFieldInfo("char", tableid, tableid, "테이블아이디", (decimal)6);
			dict["upgu"] = new XAQueryFieldInfo("char", upgu, upgu, "업무구분", (decimal)2);
			dict["custno"] = new XAQueryFieldInfo("char", custno, custno, "발행체번호", (decimal)5);
			dict["custnm"] = new XAQueryFieldInfo("char", custnm, custnm, "발행회사명", (decimal)80);
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "종목코드", (decimal)6);
			dict["upnm"] = new XAQueryFieldInfo("char", upnm, upnm, "업무명", (decimal)20);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "recdt":
					this.recdt = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "tableid":
					this.tableid = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "upgu":
					this.upgu = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "custno":
					this.custno = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "custnm":
					this.custnm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "upnm":
					this.upnm = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt3202OutBlock[] ListFromQuery(XQt3202 query)
		{
			int count = query.GetBlockCount(XQt3202OutBlock.BlockName);
			List<XQt3202OutBlock> list = new List<XQt3202OutBlock>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt3202OutBlock block = new XQt3202OutBlock();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.recdt = query.GetFieldData(block.GetBlockName(), "recdt", i).TrimEnd('?'); // char 8
					block.tableid = query.GetFieldData(block.GetBlockName(), "tableid", i).TrimEnd('?'); // char 6
					block.upgu = query.GetFieldData(block.GetBlockName(), "upgu", i).TrimEnd('?'); // char 2
					block.custno = query.GetFieldData(block.GetBlockName(), "custno", i).TrimEnd('?'); // char 5
					block.custnm = query.GetFieldData(block.GetBlockName(), "custnm", i).TrimEnd('?'); // char 80
					block.shcode = query.GetFieldData(block.GetBlockName(), "shcode", i).TrimEnd('?'); // char 6
					block.upnm = query.GetFieldData(block.GetBlockName(), "upnm", i).TrimEnd('?'); // char 20

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
			if (recdt?.Length > 8) return false; // char 8
			if (tableid?.Length > 6) return false; // char 6
			if (upgu?.Length > 2) return false; // char 2
			if (custno?.Length > 5) return false; // char 5
			if (custnm?.Length > 80) return false; // char 80
			if (shcode?.Length > 6) return false; // char 6
			if (upnm?.Length > 20) return false; // char 20

			return true;
		}
	}

	public partial class XQt3202 : XingQuery
	{
		/// <summary>
		/// t3202
		/// </summary>
		public const string _typeName = "t3202";
		/// <summary>
		/// 종목별증시일정(t3202)
		/// </summary>
		public const string _typeDesc = "종목별증시일정(t3202)";
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
		/// t3202
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 종목별증시일정(t3202)
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

		public XQt3202() : base("t3202") { }


		public static XQt3202OutBlock[] Get(string shcode = default,string date = default)
		{
			using (XQt3202 instance = new XQt3202())
			{
				instance.SetFieldData(XQt3202InBlock.BlockName, XQt3202InBlock.F.shcode, 0, shcode); // char 6
				instance.SetFieldData(XQt3202InBlock.BlockName, XQt3202InBlock.F.date, 0, date); // char 8

				if (instance.Request() < 0)
				{
					return null;
				}

				var outBlock = instance.GetBlocks();
				return outBlock;
			}
		}

		public bool SetBlock(XQt3202InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "shcode", 0, block.shcode); // char 6
			_xaQuery.SetFieldData(block.GetBlockName(), "date", 0, block.date); // char 8

			return true;
		}

		public XQt3202OutBlock[] GetBlocks()
		{
			XQt3202OutBlock[] instance = XQt3202OutBlock.ListFromQuery(this);
			return instance;

		}


	}

}
