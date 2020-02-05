using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1825InBlock : XingBlock
	{
		/// <summary>
		/// t1825InBlock
		/// </summary>
		public const string _blockName = "t1825InBlock";
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
		/// t1825InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1825InBlock
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
		/// 검색코드
		/// </summary>
		[XAQueryFieldAttribute("검색코드")]
		public string search_cd;
		/// <summary>
		/// 구분(0:전체1:코스피2:코스닥)
		/// </summary>
		[XAQueryFieldAttribute("구분(0:전체1:코스피2:코스닥)")]
		public char gubun;

		public static class F
		{
			/// <summary>
			/// 검색코드
			/// </summary>
			public const string search_cd = "search_cd";
			/// <summary>
			/// 구분(0:전체1:코스피2:코스닥)
			/// </summary>
			public const string gubun = "gubun";
		}

		public static string[] AllFields = new string[]
		{
			F.search_cd,
			F.gubun,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["search_cd"] = new XAQueryFieldInfo("char", search_cd, search_cd, "검색코드", (decimal)4);
			dict["gubun"] = new XAQueryFieldInfo("char", gubun, gubun.ToString(), "구분(0:전체1:코스피2:코스닥)", (decimal)1);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "search_cd":
					this.search_cd = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "gubun":
					this.gubun = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public bool VerifyData()
		{
			if (search_cd?.Length > 4) return false; // char 4
			// gubun char 1

			return true;
		}
	}

	public partial class XQt1825OutBlock : XingBlock
	{
		/// <summary>
		/// t1825OutBlock
		/// </summary>
		public const string _blockName = "t1825OutBlock";
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
		/// t1825OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1825OutBlock
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
		/// 검색종목수
		/// </summary>
		[XAQueryFieldAttribute("검색종목수")]
		public long JongCnt;

		public static class F
		{
			/// <summary>
			/// 검색종목수
			/// </summary>
			public const string JongCnt = "JongCnt";
		}

		public static string[] AllFields = new string[]
		{
			F.JongCnt,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["JongCnt"] = new XAQueryFieldInfo("long", JongCnt, JongCnt.ToString("d4"), "검색종목수", (decimal)4);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "JongCnt":
					this.JongCnt = fieldInfo.FieldValue.ParseLong("JongCnt");
				break;


			}
		}

		public static XQt1825OutBlock FromQuery(XQt1825 query)
		{
			XQt1825OutBlock block = new XQt1825OutBlock();
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
				block.JongCnt = query.GetFieldData(block.GetBlockName(), "JongCnt", 0).ParseLong("JongCnt"); // long 4

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (JongCnt.ToString().Length > 4) return false; // long 4

			return true;
		}
	}

	public partial class XQt1825OutBlock1 : XingBlock
	{
		/// <summary>
		/// t1825OutBlock1
		/// </summary>
		public const string _blockName = "t1825OutBlock1";
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
		/// t1825OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1825OutBlock1
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
		/// 종목코드
		/// </summary>
		[XAQueryFieldAttribute("종목코드")]
		public string shcode;
		/// <summary>
		/// 종목명
		/// </summary>
		[XAQueryFieldAttribute("종목명")]
		public string hname;
		/// <summary>
		/// 전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("전일대비구분")]
		public char sign;
		/// <summary>
		/// 연속봉수
		/// </summary>
		[XAQueryFieldAttribute("연속봉수")]
		public long signcnt;
		/// <summary>
		/// 현재가
		/// </summary>
		[XAQueryFieldAttribute("현재가")]
		public long close;
		/// <summary>
		/// 전일대비
		/// </summary>
		[XAQueryFieldAttribute("전일대비")]
		public long change;
		/// <summary>
		/// 등락율
		/// </summary>
		[XAQueryFieldAttribute("등락율")]
		public float diff;
		/// <summary>
		/// 거래량
		/// </summary>
		[XAQueryFieldAttribute("거래량")]
		public long volume;
		/// <summary>
		/// 거래량전일대비율
		/// </summary>
		[XAQueryFieldAttribute("거래량전일대비율")]
		public float volumerate;

		public static class F
		{
			/// <summary>
			/// 종목코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 종목명
			/// </summary>
			public const string hname = "hname";
			/// <summary>
			/// 전일대비구분
			/// </summary>
			public const string sign = "sign";
			/// <summary>
			/// 연속봉수
			/// </summary>
			public const string signcnt = "signcnt";
			/// <summary>
			/// 현재가
			/// </summary>
			public const string close = "close";
			/// <summary>
			/// 전일대비
			/// </summary>
			public const string change = "change";
			/// <summary>
			/// 등락율
			/// </summary>
			public const string diff = "diff";
			/// <summary>
			/// 거래량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// 거래량전일대비율
			/// </summary>
			public const string volumerate = "volumerate";
		}

		public static string[] AllFields = new string[]
		{
			F.shcode,
			F.hname,
			F.sign,
			F.signcnt,
			F.close,
			F.change,
			F.diff,
			F.volume,
			F.volumerate,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "종목코드", (decimal)6);
			dict["hname"] = new XAQueryFieldInfo("char", hname, hname, "종목명", (decimal)20);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["signcnt"] = new XAQueryFieldInfo("long", signcnt, signcnt.ToString("d3"), "연속봉수", (decimal)3);
			dict["close"] = new XAQueryFieldInfo("long", close, close.ToString("d9"), "현재가", (decimal)9);
			dict["change"] = new XAQueryFieldInfo("long", change, change.ToString("d9"), "전일대비", (decimal)9);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d10"), "거래량", (decimal)10);
			dict["volumerate"] = new XAQueryFieldInfo("float", volumerate, volumerate.ToString("000000.00"), "거래량전일대비율", (decimal)6.2);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "hname":
					this.hname = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "sign":
					this.sign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "signcnt":
					this.signcnt = fieldInfo.FieldValue.ParseLong("signcnt");
				break;

				case "close":
					this.close = fieldInfo.FieldValue.ParseLong("close");
				break;

				case "change":
					this.change = fieldInfo.FieldValue.ParseLong("change");
				break;

				case "diff":
					this.diff = fieldInfo.FieldValue.ParseFloat("diff");
				break;

				case "volume":
					this.volume = fieldInfo.FieldValue.ParseLong("volume");
				break;

				case "volumerate":
					this.volumerate = fieldInfo.FieldValue.ParseFloat("volumerate");
				break;


			}
		}

		public static XQt1825OutBlock1[] ListFromQuery(XQt1825 query)
		{
			int count = query.GetBlockCount(XQt1825OutBlock1.BlockName);
			List<XQt1825OutBlock1> list = new List<XQt1825OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1825OutBlock1 block = new XQt1825OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.shcode = query.GetFieldData(block.GetBlockName(), "shcode", i).TrimEnd('?'); // char 6
					block.hname = query.GetFieldData(block.GetBlockName(), "hname", i).TrimEnd('?'); // char 20
					block.sign = query.GetFieldData(block.GetBlockName(), "sign", i).FirstOrDefault(); // char 1
					block.signcnt = query.GetFieldData(block.GetBlockName(), "signcnt", i).ParseLong("signcnt"); // long 3
					block.close = query.GetFieldData(block.GetBlockName(), "close", i).ParseLong("close"); // long 9
					block.change = query.GetFieldData(block.GetBlockName(), "change", i).ParseLong("change"); // long 9
					block.diff = query.GetFieldData(block.GetBlockName(), "diff", i).ParseFloat("diff"); // float 6.2
					block.volume = query.GetFieldData(block.GetBlockName(), "volume", i).ParseLong("volume"); // long 10
					block.volumerate = query.GetFieldData(block.GetBlockName(), "volumerate", i).ParseFloat("volumerate"); // float 6.2

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
			if (shcode?.Length > 6) return false; // char 6
			if (hname?.Length > 20) return false; // char 20
			// sign char 1
			if (signcnt.ToString().Length > 3) return false; // long 3
			if (close.ToString().Length > 9) return false; // long 9
			if (change.ToString().Length > 9) return false; // long 9
			// diff float 6.2
			if (volume.ToString().Length > 10) return false; // long 10
			// volumerate float 6.2

			return true;
		}
	}

	/// <summary>
	/// 종목Q클릭검색(씽큐스마트)(t1825)
	/// </summary>
	public partial class XQt1825 : XingQuery
	{
		/// <summary>
		/// t1825
		/// </summary>
		public const string _typeName = "t1825";
		/// <summary>
		/// 종목Q클릭검색(씽큐스마트)(t1825)
		/// </summary>
		public const string _typeDesc = "종목Q클릭검색(씽큐스마트)(t1825)";
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
		/// t1825
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 종목Q클릭검색(씽큐스마트)(t1825)
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

		public XQt1825() : base("t1825") { }


		public static XQt1825OutBlock1[] Get(string search_cd = default,char gubun = default)
		{
			using (XQt1825 instance = new XQt1825())
			{
				instance.SetFieldData(XQt1825InBlock.BlockName, XQt1825InBlock.F.search_cd, 0, search_cd); // char 4
				instance.SetFieldData(XQt1825InBlock.BlockName, XQt1825InBlock.F.gubun, 0, gubun.ToString()); // char 1

				if (instance.Request() < 0)
				{
					return null;
				}

				var outBlock = instance.GetBlock1s();
				return outBlock;
			}
		}

		public bool SetBlock(XQt1825InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "search_cd", 0, block.search_cd); // char 4
			_xaQuery.SetFieldData(block.GetBlockName(), "gubun", 0, block.gubun.ToString()); // char 1

			return true;
		}

		public XQt1825OutBlock GetBlock()
		{
			XQt1825OutBlock instance = XQt1825OutBlock.FromQuery(this);
			return instance;

		}

		public XQt1825OutBlock1[] GetBlock1s()
		{
			XQt1825OutBlock1[] instance = XQt1825OutBlock1.ListFromQuery(this);
			return instance;

		}


	}

}
