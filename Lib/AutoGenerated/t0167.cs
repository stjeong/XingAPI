using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt0167InBlock : XingBlock
	{
		/// <summary>
		/// t0167InBlock
		/// </summary>
		public const string _blockName = "t0167InBlock";
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
		/// t0167InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t0167InBlock
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
		/// id
		/// </summary>
		[XAQueryFieldAttribute("id")]
		public string id;

		public static class F
		{
			/// <summary>
			/// id
			/// </summary>
			public const string id = "id";
		}

		public static string[] AllFields = new string[]
		{
			F.id,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["id"] = new XAQueryFieldInfo("char", id, id, "id", (decimal)8);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "id":
					this.id = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (id?.Length > 8) return false; // char 8

			return true;
		}
	}

	public partial class XQt0167OutBlock : XingBlock
	{
		/// <summary>
		/// t0167OutBlock
		/// </summary>
		public const string _blockName = "t0167OutBlock";
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
		/// t0167OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t0167OutBlock
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
		/// 일자(YYYYMMDD)
		/// </summary>
		[XAQueryFieldAttribute("일자(YYYYMMDD)")]
		public string dt;
		/// <summary>
		/// 시간(HHMMSSssssss)
		/// </summary>
		[XAQueryFieldAttribute("시간(HHMMSSssssss)")]
		public string time;

		public static class F
		{
			/// <summary>
			/// 일자(YYYYMMDD)
			/// </summary>
			public const string dt = "dt";
			/// <summary>
			/// 시간(HHMMSSssssss)
			/// </summary>
			public const string time = "time";
		}

		public static string[] AllFields = new string[]
		{
			F.dt,
			F.time,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["dt"] = new XAQueryFieldInfo("char", dt, dt, "일자(YYYYMMDD)", (decimal)8);
			dict["time"] = new XAQueryFieldInfo("char", time, time, "시간(HHMMSSssssss)", (decimal)12);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "dt":
					this.dt = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "time":
					this.time = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt0167OutBlock FromQuery(XQt0167 query)
		{
			XQt0167OutBlock block = new XQt0167OutBlock();
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
				block.dt = query.GetFieldData(block.GetBlockName(), "dt", 0).TrimEnd('?'); // char 8
				block.time = query.GetFieldData(block.GetBlockName(), "time", 0).TrimEnd('?'); // char 12

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (dt?.Length > 8) return false; // char 8
			if (time?.Length > 12) return false; // char 12

			return true;
		}
	}

	/// <summary>
	/// 서버시간조회(t0167)
	/// </summary>
	public partial class XQt0167 : XingQuery
	{
		/// <summary>
		/// t0167
		/// </summary>
		public const string _typeName = "t0167";
		/// <summary>
		/// 서버시간조회(t0167)
		/// </summary>
		public const string _typeDesc = "서버시간조회(t0167)";
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
		/// t0167
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 서버시간조회(t0167)
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

		public XQt0167() : base("t0167") { }


		public static XQt0167OutBlock Get(string id = default)
		{
			using (XQt0167 instance = new XQt0167())
			{
				instance.SetFieldData(XQt0167InBlock.BlockName, XQt0167InBlock.F.id, 0, id); // char 8

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

		public bool SetBlock(XQt0167InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "id", 0, block.id); // char 8

			return true;
		}

		public XQt0167OutBlock GetBlock()
		{
			XQt0167OutBlock instance = XQt0167OutBlock.FromQuery(this);
			return instance;

		}


	}

}
