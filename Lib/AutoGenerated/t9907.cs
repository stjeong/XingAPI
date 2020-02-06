using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt9907InBlock : XingBlock
	{
		/// <summary>
		/// t9907InBlock
		/// </summary>
		public const string _blockName = "t9907InBlock";
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
		/// t9907InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t9907InBlock
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
		/// DUMMY
		/// </summary>
		[XAQueryFieldAttribute("DUMMY")]
		public char dummy;

		public static class F
		{
			/// <summary>
			/// DUMMY
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
			dict["dummy"] = new XAQueryFieldInfo("char", dummy, dummy.ToString(), "DUMMY", (decimal)1);

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

	public partial class XQt9907OutBlock1 : XingBlock
	{
		/// <summary>
		/// t9907OutBlock1
		/// </summary>
		public const string _blockName = "t9907OutBlock1";
		/// <summary>
		/// 출력1
		/// </summary>
		public const string _blockDesc = "출력1";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// true
		/// </summary>
		public const bool _hasOccurs = true;
		/// <summary>
		/// t9907OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t9907OutBlock1
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// 출력1
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
		/// 만기월
		/// </summary>
		[XAQueryFieldAttribute("만기월")]
		public string lastym;
		/// <summary>
		/// 만기월명
		/// </summary>
		[XAQueryFieldAttribute("만기월명")]
		public string lastnm;

		public static class F
		{
			/// <summary>
			/// 만기월
			/// </summary>
			public const string lastym = "lastym";
			/// <summary>
			/// 만기월명
			/// </summary>
			public const string lastnm = "lastnm";
		}

		public static string[] AllFields = new string[]
		{
			F.lastym,
			F.lastnm,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["lastym"] = new XAQueryFieldInfo("char", lastym, lastym, "만기월", (decimal)6);
			dict["lastnm"] = new XAQueryFieldInfo("char", lastnm, lastnm, "만기월명", (decimal)10);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "lastym":
					this.lastym = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "lastnm":
					this.lastnm = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt9907OutBlock1[] ListFromQuery(XQt9907 query)
		{
			int count = query.GetBlockCount(XQt9907OutBlock1.BlockName);
			List<XQt9907OutBlock1> list = new List<XQt9907OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt9907OutBlock1 block = new XQt9907OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.lastym = query.GetFieldData(block.GetBlockName(), "lastym", i).TrimEnd('?'); // char 6
					block.lastnm = query.GetFieldData(block.GetBlockName(), "lastnm", i).TrimEnd('?'); // char 10

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
			if (lastym?.Length > 6) return false; // char 6
			if (lastnm?.Length > 10) return false; // char 10

			return true;
		}
	}

	/// <summary>
	/// 만기월조회(t9907)
	/// </summary>
	public partial class XQt9907 : XingQuery
	{
		/// <summary>
		/// t9907
		/// </summary>
		public const string _typeName = "t9907";
		/// <summary>
		/// 만기월조회(t9907)
		/// </summary>
		public const string _typeDesc = "만기월조회(t9907)";
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
		/// t9907
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 만기월조회(t9907)
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

		public XQt9907() : base("t9907") { }


		public static XQt9907OutBlock1[] Get(char dummy = default)
		{
			using (XQt9907 instance = new XQt9907())
			{
				instance.SetFieldData(XQt9907InBlock.BlockName, XQt9907InBlock.F.dummy, 0, dummy.ToString()); // char 1

				if (instance.Request() < 0)
				{
					return null;
				}

				var outBlock = instance.GetBlock1s();
				return outBlock;
			}
		}

		public bool SetBlock(XQt9907InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "dummy", 0, block.dummy.ToString()); // char 1

			return true;
		}

		public XQt9907OutBlock1[] GetBlock1s()
		{
			XQt9907OutBlock1[] instance = XQt9907OutBlock1.ListFromQuery(this);
			return instance;

		}


	}

}
