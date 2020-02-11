using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1488InBlock : XingBlock
	{
		/// <summary>
		/// t1488InBlock
		/// </summary>
		public const string _blockName = "t1488InBlock";
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
		/// t1488InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1488InBlock
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
		/// 거래소구분
		/// </summary>
		[XAQueryFieldAttribute("gubun", "거래소구분", "char", "1")]
		public char gubun;
		/// <summary>
		/// 상하락구분
		/// </summary>
		[XAQueryFieldAttribute("sign", "상하락구분", "char", "1")]
		public char sign;
		/// <summary>
		/// 장구분
		/// </summary>
		[XAQueryFieldAttribute("jgubun", "장구분", "char", "1")]
		public char jgubun;
		/// <summary>
		/// 종목체크
		/// </summary>
		[XAQueryFieldAttribute("jongchk", "종목체크", "char", "12")]
		public string jongchk;
		/// <summary>
		/// IDX
		/// </summary>
		[XAQueryFieldAttribute("idx", "IDX", "long", "4")]
		public long idx;
		/// <summary>
		/// 거래량
		/// </summary>
		[XAQueryFieldAttribute("volume", "거래량", "char", "1")]
		public char volume;
		/// <summary>
		/// 예상체결시작가격
		/// </summary>
		[XAQueryFieldAttribute("yesprice", "예상체결시작가격", "long", "8")]
		public long yesprice;
		/// <summary>
		/// 예상체결종료가격
		/// </summary>
		[XAQueryFieldAttribute("yeeprice", "예상체결종료가격", "long", "8")]
		public long yeeprice;
		/// <summary>
		/// 예상체결량
		/// </summary>
		[XAQueryFieldAttribute("yevolume", "예상체결량", "long", "12")]
		public long yevolume;

		public static class F
		{
			/// <summary>
			/// 거래소구분
			/// </summary>
			public const string gubun = "gubun";
			/// <summary>
			/// 상하락구분
			/// </summary>
			public const string sign = "sign";
			/// <summary>
			/// 장구분
			/// </summary>
			public const string jgubun = "jgubun";
			/// <summary>
			/// 종목체크
			/// </summary>
			public const string jongchk = "jongchk";
			/// <summary>
			/// IDX
			/// </summary>
			public const string idx = "idx";
			/// <summary>
			/// 거래량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// 예상체결시작가격
			/// </summary>
			public const string yesprice = "yesprice";
			/// <summary>
			/// 예상체결종료가격
			/// </summary>
			public const string yeeprice = "yeeprice";
			/// <summary>
			/// 예상체결량
			/// </summary>
			public const string yevolume = "yevolume";
		}

		public static string[] AllFields = new string[]
		{
			F.gubun,
			F.sign,
			F.jgubun,
			F.jongchk,
			F.idx,
			F.volume,
			F.yesprice,
			F.yeeprice,
			F.yevolume,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["gubun"] = new XAQueryFieldInfo("char", gubun, gubun.ToString(), "거래소구분", (decimal)1);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "상하락구분", (decimal)1);
			dict["jgubun"] = new XAQueryFieldInfo("char", jgubun, jgubun.ToString(), "장구분", (decimal)1);
			dict["jongchk"] = new XAQueryFieldInfo("char", jongchk, jongchk, "종목체크", (decimal)12);
			dict["idx"] = new XAQueryFieldInfo("long", idx, idx.ToString("d4"), "IDX", (decimal)4);
			dict["volume"] = new XAQueryFieldInfo("char", volume, volume.ToString(), "거래량", (decimal)1);
			dict["yesprice"] = new XAQueryFieldInfo("long", yesprice, yesprice.ToString("d8"), "예상체결시작가격", (decimal)8);
			dict["yeeprice"] = new XAQueryFieldInfo("long", yeeprice, yeeprice.ToString("d8"), "예상체결종료가격", (decimal)8);
			dict["yevolume"] = new XAQueryFieldInfo("long", yevolume, yevolume.ToString("d12"), "예상체결량", (decimal)12);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "gubun":
					this.gubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "sign":
					this.sign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "jgubun":
					this.jgubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "jongchk":
					this.jongchk = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "idx":
					this.idx = fieldInfo.FieldValue.ParseLong("idx");
				break;

				case "volume":
					this.volume = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "yesprice":
					this.yesprice = fieldInfo.FieldValue.ParseLong("yesprice");
				break;

				case "yeeprice":
					this.yeeprice = fieldInfo.FieldValue.ParseLong("yeeprice");
				break;

				case "yevolume":
					this.yevolume = fieldInfo.FieldValue.ParseLong("yevolume");
				break;


			}
		}

		public bool VerifyData()
		{
			// gubun char 1
			// sign char 1
			// jgubun char 1
			if (jongchk?.Length > 12) return false; // char 12
			if (idx.ToString().Length > 4) return false; // long 4
			// volume char 1
			if (yesprice.ToString().Length > 8) return false; // long 8
			if (yeeprice.ToString().Length > 8) return false; // long 8
			if (yevolume.ToString().Length > 12) return false; // long 12

			return true;
		}
	}

	public partial class XQt1488OutBlock : XingBlock
	{
		/// <summary>
		/// t1488OutBlock
		/// </summary>
		public const string _blockName = "t1488OutBlock";
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
		/// t1488OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1488OutBlock
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
		[XAQueryFieldAttribute("idx", "IDX", "long", "4")]
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

		public static XQt1488OutBlock FromQuery(XQt1488 query)
		{
			XQt1488OutBlock block = new XQt1488OutBlock();
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

	public partial class XQt1488OutBlock1 : XingBlock
	{
		/// <summary>
		/// t1488OutBlock1
		/// </summary>
		public const string _blockName = "t1488OutBlock1";
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
		/// t1488OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1488OutBlock1
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
		[XAQueryFieldAttribute("hname", "한글명", "char", "20")]
		public string hname;
		/// <summary>
		/// 현재가
		/// </summary>
		[XAQueryFieldAttribute("price", "현재가", "long", "8")]
		public long price;
		/// <summary>
		/// 전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("sign", "전일대비구분", "char", "1")]
		public char sign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[XAQueryFieldAttribute("change", "전일대비", "long", "8")]
		public long change;
		/// <summary>
		/// 등락율
		/// </summary>
		[XAQueryFieldAttribute("diff", "등락율", "float", "6.2")]
		public float diff;
		/// <summary>
		/// 누적거래량
		/// </summary>
		[XAQueryFieldAttribute("volume", "누적거래량", "long", "12")]
		public long volume;
		/// <summary>
		/// 매도잔량
		/// </summary>
		[XAQueryFieldAttribute("offerrem", "매도잔량", "long", "8")]
		public long offerrem;
		/// <summary>
		/// 매도호가
		/// </summary>
		[XAQueryFieldAttribute("offerho", "매도호가", "long", "8")]
		public long offerho;
		/// <summary>
		/// 매수호가
		/// </summary>
		[XAQueryFieldAttribute("bidho", "매수호가", "long", "8")]
		public long bidho;
		/// <summary>
		/// 매수잔량
		/// </summary>
		[XAQueryFieldAttribute("bidrem", "매수잔량", "long", "8")]
		public long bidrem;
		/// <summary>
		/// 연속일수
		/// </summary>
		[XAQueryFieldAttribute("cnt", "연속일수", "long", "4")]
		public long cnt;
		/// <summary>
		/// 종목코드
		/// </summary>
		[XAQueryFieldAttribute("shcode", "종목코드", "char", "6")]
		public string shcode;
		/// <summary>
		/// 증거금율
		/// </summary>
		[XAQueryFieldAttribute("jkrate", "증거금율", "char", "3")]
		public string jkrate;
		/// <summary>
		/// 전일거래량
		/// </summary>
		[XAQueryFieldAttribute("jnilvolume", "전일거래량", "long", "12")]
		public long jnilvolume;

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
			/// 매도잔량
			/// </summary>
			public const string offerrem = "offerrem";
			/// <summary>
			/// 매도호가
			/// </summary>
			public const string offerho = "offerho";
			/// <summary>
			/// 매수호가
			/// </summary>
			public const string bidho = "bidho";
			/// <summary>
			/// 매수잔량
			/// </summary>
			public const string bidrem = "bidrem";
			/// <summary>
			/// 연속일수
			/// </summary>
			public const string cnt = "cnt";
			/// <summary>
			/// 종목코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 증거금율
			/// </summary>
			public const string jkrate = "jkrate";
			/// <summary>
			/// 전일거래량
			/// </summary>
			public const string jnilvolume = "jnilvolume";
		}

		public static string[] AllFields = new string[]
		{
			F.hname,
			F.price,
			F.sign,
			F.change,
			F.diff,
			F.volume,
			F.offerrem,
			F.offerho,
			F.bidho,
			F.bidrem,
			F.cnt,
			F.shcode,
			F.jkrate,
			F.jnilvolume,
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
			dict["offerrem"] = new XAQueryFieldInfo("long", offerrem, offerrem.ToString("d8"), "매도잔량", (decimal)8);
			dict["offerho"] = new XAQueryFieldInfo("long", offerho, offerho.ToString("d8"), "매도호가", (decimal)8);
			dict["bidho"] = new XAQueryFieldInfo("long", bidho, bidho.ToString("d8"), "매수호가", (decimal)8);
			dict["bidrem"] = new XAQueryFieldInfo("long", bidrem, bidrem.ToString("d8"), "매수잔량", (decimal)8);
			dict["cnt"] = new XAQueryFieldInfo("long", cnt, cnt.ToString("d4"), "연속일수", (decimal)4);
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "종목코드", (decimal)6);
			dict["jkrate"] = new XAQueryFieldInfo("char", jkrate, jkrate, "증거금율", (decimal)3);
			dict["jnilvolume"] = new XAQueryFieldInfo("long", jnilvolume, jnilvolume.ToString("d12"), "전일거래량", (decimal)12);

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

				case "offerrem":
					this.offerrem = fieldInfo.FieldValue.ParseLong("offerrem");
				break;

				case "offerho":
					this.offerho = fieldInfo.FieldValue.ParseLong("offerho");
				break;

				case "bidho":
					this.bidho = fieldInfo.FieldValue.ParseLong("bidho");
				break;

				case "bidrem":
					this.bidrem = fieldInfo.FieldValue.ParseLong("bidrem");
				break;

				case "cnt":
					this.cnt = fieldInfo.FieldValue.ParseLong("cnt");
				break;

				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "jkrate":
					this.jkrate = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "jnilvolume":
					this.jnilvolume = fieldInfo.FieldValue.ParseLong("jnilvolume");
				break;


			}
		}

		public static XQt1488OutBlock1[] ListFromQuery(XQt1488 query)
		{
			int count = query.GetBlockCount(XQt1488OutBlock1.BlockName);
			List<XQt1488OutBlock1> list = new List<XQt1488OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1488OutBlock1 block = new XQt1488OutBlock1();
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
					block.offerrem = query.GetFieldData(block.GetBlockName(), "offerrem", i).ParseLong("offerrem"); // long 8
					block.offerho = query.GetFieldData(block.GetBlockName(), "offerho", i).ParseLong("offerho"); // long 8
					block.bidho = query.GetFieldData(block.GetBlockName(), "bidho", i).ParseLong("bidho"); // long 8
					block.bidrem = query.GetFieldData(block.GetBlockName(), "bidrem", i).ParseLong("bidrem"); // long 8
					block.cnt = query.GetFieldData(block.GetBlockName(), "cnt", i).ParseLong("cnt"); // long 4
					block.shcode = query.GetFieldData(block.GetBlockName(), "shcode", i).TrimEnd('?'); // char 6
					block.jkrate = query.GetFieldData(block.GetBlockName(), "jkrate", i).TrimEnd('?'); // char 3
					block.jnilvolume = query.GetFieldData(block.GetBlockName(), "jnilvolume", i).ParseLong("jnilvolume"); // long 12

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
			if (offerrem.ToString().Length > 8) return false; // long 8
			if (offerho.ToString().Length > 8) return false; // long 8
			if (bidho.ToString().Length > 8) return false; // long 8
			if (bidrem.ToString().Length > 8) return false; // long 8
			if (cnt.ToString().Length > 4) return false; // long 4
			if (shcode?.Length > 6) return false; // char 6
			if (jkrate?.Length > 3) return false; // char 3
			if (jnilvolume.ToString().Length > 12) return false; // long 12

			return true;
		}
	}

	/// <summary>
	/// 예상체결가등락율상위조회(t1488)
	/// </summary>
	public partial class XQt1488 : XingQuery
	{
		/// <summary>
		/// t1488
		/// </summary>
		public const string _typeName = "t1488";
		/// <summary>
		/// 예상체결가등락율상위조회(t1488)
		/// </summary>
		public const string _typeDesc = "예상체결가등락율상위조회(t1488)";
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
		/// t1488
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 예상체결가등락율상위조회(t1488)
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
		/// 예상체결가등락율상위조회(t1488)
		/// </summary>
		public XQt1488() : base("t1488") { }


		public class XQAllOutBlocks
		{
			public XQt1488OutBlock OutBlock { get; internal set; }
			public XQt1488OutBlock1[] OutBlock1 { get; internal set; }
		}

		public static XQAllOutBlocks Get(char gubun = default,char sign = default,char jgubun = default,string jongchk = default,long idx = default,char volume = default,long yesprice = default,long yeeprice = default,long yevolume = default)
		{
			using (XQt1488 instance = new XQt1488())
			{
				instance.SetFieldData(XQt1488InBlock.BlockName, XQt1488InBlock.F.gubun, 0, gubun.ToString()); // char 1
				instance.SetFieldData(XQt1488InBlock.BlockName, XQt1488InBlock.F.sign, 0, sign.ToString()); // char 1
				instance.SetFieldData(XQt1488InBlock.BlockName, XQt1488InBlock.F.jgubun, 0, jgubun.ToString()); // char 1
				instance.SetFieldData(XQt1488InBlock.BlockName, XQt1488InBlock.F.jongchk, 0, jongchk); // char 12
				instance.SetFieldData(XQt1488InBlock.BlockName, XQt1488InBlock.F.idx, 0, idx.ToString("d4")); // long 4
				instance.SetFieldData(XQt1488InBlock.BlockName, XQt1488InBlock.F.volume, 0, volume.ToString()); // char 1
				instance.SetFieldData(XQt1488InBlock.BlockName, XQt1488InBlock.F.yesprice, 0, yesprice.ToString("d8")); // long 8
				instance.SetFieldData(XQt1488InBlock.BlockName, XQt1488InBlock.F.yeeprice, 0, yeeprice.ToString("d8")); // long 8
				instance.SetFieldData(XQt1488InBlock.BlockName, XQt1488InBlock.F.yevolume, 0, yevolume.ToString("d12")); // long 12

				if (instance.Request() < 0)
				{
					return null;
				}

				XQAllOutBlocks results = new XQAllOutBlocks();
				results.OutBlock = instance.GetBlock();
				if (results.OutBlock.IsValidData == false)
				{
					return null;
				}

				results.OutBlock1 = instance.GetBlock1s();
				return results;
			}
		}

		public bool SetBlock(XQt1488InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "gubun", 0, block.gubun.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "sign", 0, block.sign.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "jgubun", 0, block.jgubun.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "jongchk", 0, block.jongchk); // char 12
			_xaQuery.SetFieldData(block.GetBlockName(), "idx", 0, block.idx.ToString("d4")); // long 4
			_xaQuery.SetFieldData(block.GetBlockName(), "volume", 0, block.volume.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "yesprice", 0, block.yesprice.ToString("d8")); // long 8
			_xaQuery.SetFieldData(block.GetBlockName(), "yeeprice", 0, block.yeeprice.ToString("d8")); // long 8
			_xaQuery.SetFieldData(block.GetBlockName(), "yevolume", 0, block.yevolume.ToString("d12")); // long 12

			return true;
		}

		public XQt1488OutBlock GetBlock()
		{
			XQt1488OutBlock instance = XQt1488OutBlock.FromQuery(this);
			return instance;

		}

		public XQt1488OutBlock1[] GetBlock1s()
		{
			XQt1488OutBlock1[] instance = XQt1488OutBlock1.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt1488OutBlock),
			typeof(XQt1488OutBlock1),

		};

	}

}
