using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1403InBlock : XingBlock
	{
		/// <summary>
		/// t1403InBlock
		/// </summary>
		public const string _blockName = "t1403InBlock";
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
		/// t1403InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1403InBlock
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
		public char gubun;
		/// <summary>
		/// 시작상장월
		/// </summary>
		[XAQueryFieldAttribute("시작상장월")]
		public string styymm;
		/// <summary>
		/// 종료상장월
		/// </summary>
		[XAQueryFieldAttribute("종료상장월")]
		public string enyymm;
		/// <summary>
		/// IDX
		/// </summary>
		[XAQueryFieldAttribute("IDX")]
		public long idx;

		public static class F
		{
			/// <summary>
			/// 구분
			/// </summary>
			public const string gubun = "gubun";
			/// <summary>
			/// 시작상장월
			/// </summary>
			public const string styymm = "styymm";
			/// <summary>
			/// 종료상장월
			/// </summary>
			public const string enyymm = "enyymm";
			/// <summary>
			/// IDX
			/// </summary>
			public const string idx = "idx";
		}

		public static string[] AllFields = new string[]
		{
			F.gubun,
			F.styymm,
			F.enyymm,
			F.idx,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["gubun"] = new XAQueryFieldInfo("char", gubun, gubun.ToString(), "구분", (decimal)1);
			dict["styymm"] = new XAQueryFieldInfo("char", styymm, styymm, "시작상장월", (decimal)6);
			dict["enyymm"] = new XAQueryFieldInfo("char", enyymm, enyymm, "종료상장월", (decimal)6);
			dict["idx"] = new XAQueryFieldInfo("long", idx, idx.ToString("d4"), "IDX", (decimal)4);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "gubun":
					this.gubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "styymm":
					this.styymm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "enyymm":
					this.enyymm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "idx":
					this.idx = fieldInfo.FieldValue.ParseLong("idx");
				break;


			}
		}

		public bool VerifyData()
		{
			// gubun char 1
			if (styymm?.Length > 6) return false; // char 6
			if (enyymm?.Length > 6) return false; // char 6
			if (idx.ToString().Length > 4) return false; // long 4

			return true;
		}
	}

	public partial class XQt1403OutBlock : XingBlock
	{
		/// <summary>
		/// t1403OutBlock
		/// </summary>
		public const string _blockName = "t1403OutBlock";
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
		/// t1403OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1403OutBlock
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
		/// IDX
		/// </summary>
		[XAQueryFieldAttribute("IDX")]
		public long idx;

		public static class F
		{
			/// <summary>
			/// IDX
			/// </summary>
			public const string idx = "idx";
		}

		public static string[] AllFields = new string[]
		{
			F.idx,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["idx"] = new XAQueryFieldInfo("long", idx, idx.ToString("d4"), "IDX", (decimal)4);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "idx":
					this.idx = fieldInfo.FieldValue.ParseLong("idx");
				break;


			}
		}

		public static XQt1403OutBlock FromQuery(XQt1403 query)
		{
			XQt1403OutBlock block = new XQt1403OutBlock();
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
				block.idx = query.GetFieldData(block.GetBlockName(), "idx", 0).ParseLong("idx"); // long 4

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (idx.ToString().Length > 4) return false; // long 4

			return true;
		}
	}

	public partial class XQt1403OutBlock1 : XingBlock
	{
		/// <summary>
		/// t1403OutBlock1
		/// </summary>
		public const string _blockName = "t1403OutBlock1";
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
		/// t1403OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1403OutBlock1
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
		/// 한글명
		/// </summary>
		[XAQueryFieldAttribute("한글명")]
		public string hname;
		/// <summary>
		/// 현재가
		/// </summary>
		[XAQueryFieldAttribute("현재가")]
		public long price;
		/// <summary>
		/// 전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("전일대비구분")]
		public char sign;
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
		/// 누적거래량
		/// </summary>
		[XAQueryFieldAttribute("누적거래량")]
		public long volume;
		/// <summary>
		/// 공모가
		/// </summary>
		[XAQueryFieldAttribute("공모가")]
		public long kmprice;
		/// <summary>
		/// 등록일
		/// </summary>
		[XAQueryFieldAttribute("등록일")]
		public string date;
		/// <summary>
		/// 등록일기준가
		/// </summary>
		[XAQueryFieldAttribute("등록일기준가")]
		public long recprice;
		/// <summary>
		/// 기준가등락율
		/// </summary>
		[XAQueryFieldAttribute("기준가등락율")]
		public float kmdiff;
		/// <summary>
		/// 등록일종가
		/// </summary>
		[XAQueryFieldAttribute("등록일종가")]
		public long close;
		/// <summary>
		/// 등록일등락율
		/// </summary>
		[XAQueryFieldAttribute("등록일등락율")]
		public float recdiff;
		/// <summary>
		/// 종목코드
		/// </summary>
		[XAQueryFieldAttribute("종목코드")]
		public string shcode;

		public static class F
		{
			/// <summary>
			/// 한글명
			/// </summary>
			public const string hname = "hname";
			/// <summary>
			/// 현재가
			/// </summary>
			public const string price = "price";
			/// <summary>
			/// 전일대비구분
			/// </summary>
			public const string sign = "sign";
			/// <summary>
			/// 전일대비
			/// </summary>
			public const string change = "change";
			/// <summary>
			/// 등락율
			/// </summary>
			public const string diff = "diff";
			/// <summary>
			/// 누적거래량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// 공모가
			/// </summary>
			public const string kmprice = "kmprice";
			/// <summary>
			/// 등록일
			/// </summary>
			public const string date = "date";
			/// <summary>
			/// 등록일기준가
			/// </summary>
			public const string recprice = "recprice";
			/// <summary>
			/// 기준가등락율
			/// </summary>
			public const string kmdiff = "kmdiff";
			/// <summary>
			/// 등록일종가
			/// </summary>
			public const string close = "close";
			/// <summary>
			/// 등록일등락율
			/// </summary>
			public const string recdiff = "recdiff";
			/// <summary>
			/// 종목코드
			/// </summary>
			public const string shcode = "shcode";
		}

		public static string[] AllFields = new string[]
		{
			F.hname,
			F.price,
			F.sign,
			F.change,
			F.diff,
			F.volume,
			F.kmprice,
			F.date,
			F.recprice,
			F.kmdiff,
			F.close,
			F.recdiff,
			F.shcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["hname"] = new XAQueryFieldInfo("char", hname, hname, "한글명", (decimal)20);
			dict["price"] = new XAQueryFieldInfo("long", price, price.ToString("d8"), "현재가", (decimal)8);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("long", change, change.ToString("d8"), "전일대비", (decimal)8);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "누적거래량", (decimal)12);
			dict["kmprice"] = new XAQueryFieldInfo("long", kmprice, kmprice.ToString("d8"), "공모가", (decimal)8);
			dict["date"] = new XAQueryFieldInfo("char", date, date, "등록일", (decimal)8);
			dict["recprice"] = new XAQueryFieldInfo("long", recprice, recprice.ToString("d8"), "등록일기준가", (decimal)8);
			dict["kmdiff"] = new XAQueryFieldInfo("float", kmdiff, kmdiff.ToString("000000.00"), "기준가등락율", (decimal)6.2);
			dict["close"] = new XAQueryFieldInfo("long", close, close.ToString("d8"), "등록일종가", (decimal)8);
			dict["recdiff"] = new XAQueryFieldInfo("float", recdiff, recdiff.ToString("000000.00"), "등록일등락율", (decimal)6.2);
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "종목코드", (decimal)6);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "hname":
					this.hname = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "price":
					this.price = fieldInfo.FieldValue.ParseLong("price");
				break;

				case "sign":
					this.sign = fieldInfo.FieldValue.FirstOrDefault();
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

				case "kmprice":
					this.kmprice = fieldInfo.FieldValue.ParseLong("kmprice");
				break;

				case "date":
					this.date = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "recprice":
					this.recprice = fieldInfo.FieldValue.ParseLong("recprice");
				break;

				case "kmdiff":
					this.kmdiff = fieldInfo.FieldValue.ParseFloat("kmdiff");
				break;

				case "close":
					this.close = fieldInfo.FieldValue.ParseLong("close");
				break;

				case "recdiff":
					this.recdiff = fieldInfo.FieldValue.ParseFloat("recdiff");
				break;

				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt1403OutBlock1[] ListFromQuery(XQt1403 query)
		{
			int count = query.GetBlockCount(XQt1403OutBlock1.BlockName);
			List<XQt1403OutBlock1> list = new List<XQt1403OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1403OutBlock1 block = new XQt1403OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.hname = query.GetFieldData(block.GetBlockName(), "hname", i).TrimEnd('?'); // char 20
					block.price = query.GetFieldData(block.GetBlockName(), "price", i).ParseLong("price"); // long 8
					block.sign = query.GetFieldData(block.GetBlockName(), "sign", i).FirstOrDefault(); // char 1
					block.change = query.GetFieldData(block.GetBlockName(), "change", i).ParseLong("change"); // long 8
					block.diff = query.GetFieldData(block.GetBlockName(), "diff", i).ParseFloat("diff"); // float 6.2
					block.volume = query.GetFieldData(block.GetBlockName(), "volume", i).ParseLong("volume"); // long 12
					block.kmprice = query.GetFieldData(block.GetBlockName(), "kmprice", i).ParseLong("kmprice"); // long 8
					block.date = query.GetFieldData(block.GetBlockName(), "date", i).TrimEnd('?'); // char 8
					block.recprice = query.GetFieldData(block.GetBlockName(), "recprice", i).ParseLong("recprice"); // long 8
					block.kmdiff = query.GetFieldData(block.GetBlockName(), "kmdiff", i).ParseFloat("kmdiff"); // float 6.2
					block.close = query.GetFieldData(block.GetBlockName(), "close", i).ParseLong("close"); // long 8
					block.recdiff = query.GetFieldData(block.GetBlockName(), "recdiff", i).ParseFloat("recdiff"); // float 6.2
					block.shcode = query.GetFieldData(block.GetBlockName(), "shcode", i).TrimEnd('?'); // char 6

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
			if (hname?.Length > 20) return false; // char 20
			if (price.ToString().Length > 8) return false; // long 8
			// sign char 1
			if (change.ToString().Length > 8) return false; // long 8
			// diff float 6.2
			if (volume.ToString().Length > 12) return false; // long 12
			if (kmprice.ToString().Length > 8) return false; // long 8
			if (date?.Length > 8) return false; // char 8
			if (recprice.ToString().Length > 8) return false; // long 8
			// kmdiff float 6.2
			if (close.ToString().Length > 8) return false; // long 8
			// recdiff float 6.2
			if (shcode?.Length > 6) return false; // char 6

			return true;
		}
	}

	/// <summary>
	/// 신규상장종목조회(t1403)
	/// </summary>
	public partial class XQt1403 : XingQuery
	{
		/// <summary>
		/// t1403
		/// </summary>
		public const string _typeName = "t1403";
		/// <summary>
		/// 신규상장종목조회(t1403)
		/// </summary>
		public const string _typeDesc = "신규상장종목조회(t1403)";
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
		/// t1403
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 신규상장종목조회(t1403)
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
		/// 신규상장종목조회(t1403)
		/// </summary>
		public XQt1403() : base("t1403") { }


		public static XQt1403OutBlock1[] Get(char gubun = default,string styymm = default,string enyymm = default,long idx = default)
		{
			using (XQt1403 instance = new XQt1403())
			{
				instance.SetFieldData(XQt1403InBlock.BlockName, XQt1403InBlock.F.gubun, 0, gubun.ToString()); // char 1
				instance.SetFieldData(XQt1403InBlock.BlockName, XQt1403InBlock.F.styymm, 0, styymm); // char 6
				instance.SetFieldData(XQt1403InBlock.BlockName, XQt1403InBlock.F.enyymm, 0, enyymm); // char 6
				instance.SetFieldData(XQt1403InBlock.BlockName, XQt1403InBlock.F.idx, 0, idx.ToString("d4")); // long 4

				if (instance.Request() < 0)
				{
					return null;
				}

				var outBlock = instance.GetBlock1s();
				return outBlock;
			}
		}

		public bool SetBlock(XQt1403InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "gubun", 0, block.gubun.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "styymm", 0, block.styymm); // char 6
			_xaQuery.SetFieldData(block.GetBlockName(), "enyymm", 0, block.enyymm); // char 6
			_xaQuery.SetFieldData(block.GetBlockName(), "idx", 0, block.idx.ToString("d4")); // long 4

			return true;
		}

		public XQt1403OutBlock GetBlock()
		{
			XQt1403OutBlock instance = XQt1403OutBlock.FromQuery(this);
			return instance;

		}

		public XQt1403OutBlock1[] GetBlock1s()
		{
			XQt1403OutBlock1[] instance = XQt1403OutBlock1.ListFromQuery(this);
			return instance;

		}


	}

}
