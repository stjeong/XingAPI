using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1422InBlock : XingBlock
	{
		/// <summary>
		/// t1422InBlock
		/// </summary>
		public const string _blockName = "t1422InBlock";
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
		/// t1422InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1422InBlock
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
		/// 조회구분
		/// </summary>
		[XAQueryFieldAttribute("조회구분")]
		public char qrygb;
		/// <summary>
		/// 구분
		/// </summary>
		[XAQueryFieldAttribute("구분")]
		public char gubun;
		/// <summary>
		/// 전일구분
		/// </summary>
		[XAQueryFieldAttribute("전일구분")]
		public char jnilgubun;
		/// <summary>
		/// 상하한구분
		/// </summary>
		[XAQueryFieldAttribute("상하한구분")]
		public char sign;
		/// <summary>
		/// 대상제외
		/// </summary>
		[XAQueryFieldAttribute("대상제외")]
		public long jc_num;
		/// <summary>
		/// 시작가격
		/// </summary>
		[XAQueryFieldAttribute("시작가격")]
		public long sprice;
		/// <summary>
		/// 종료가격
		/// </summary>
		[XAQueryFieldAttribute("종료가격")]
		public long eprice;
		/// <summary>
		/// 거래량
		/// </summary>
		[XAQueryFieldAttribute("거래량")]
		public long volume;
		/// <summary>
		/// IDX
		/// </summary>
		[XAQueryFieldAttribute("IDX")]
		public long idx;

		public static class F
		{
			/// <summary>
			/// 조회구분
			/// </summary>
			public const string qrygb = "qrygb";
			/// <summary>
			/// 구분
			/// </summary>
			public const string gubun = "gubun";
			/// <summary>
			/// 전일구분
			/// </summary>
			public const string jnilgubun = "jnilgubun";
			/// <summary>
			/// 상하한구분
			/// </summary>
			public const string sign = "sign";
			/// <summary>
			/// 대상제외
			/// </summary>
			public const string jc_num = "jc_num";
			/// <summary>
			/// 시작가격
			/// </summary>
			public const string sprice = "sprice";
			/// <summary>
			/// 종료가격
			/// </summary>
			public const string eprice = "eprice";
			/// <summary>
			/// 거래량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// IDX
			/// </summary>
			public const string idx = "idx";
		}

		public static string[] AllFields = new string[]
		{
			F.qrygb,
			F.gubun,
			F.jnilgubun,
			F.sign,
			F.jc_num,
			F.sprice,
			F.eprice,
			F.volume,
			F.idx,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["qrygb"] = new XAQueryFieldInfo("char", qrygb, qrygb.ToString(), "조회구분", (decimal)1);
			dict["gubun"] = new XAQueryFieldInfo("char", gubun, gubun.ToString(), "구분", (decimal)1);
			dict["jnilgubun"] = new XAQueryFieldInfo("char", jnilgubun, jnilgubun.ToString(), "전일구분", (decimal)1);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "상하한구분", (decimal)1);
			dict["jc_num"] = new XAQueryFieldInfo("long", jc_num, jc_num.ToString("d12"), "대상제외", (decimal)12);
			dict["sprice"] = new XAQueryFieldInfo("long", sprice, sprice.ToString("d8"), "시작가격", (decimal)8);
			dict["eprice"] = new XAQueryFieldInfo("long", eprice, eprice.ToString("d8"), "종료가격", (decimal)8);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "거래량", (decimal)12);
			dict["idx"] = new XAQueryFieldInfo("long", idx, idx.ToString("d4"), "IDX", (decimal)4);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "qrygb":
					this.qrygb = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "gubun":
					this.gubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "jnilgubun":
					this.jnilgubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "sign":
					this.sign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "jc_num":
					this.jc_num = fieldInfo.FieldValue.ParseLong("jc_num");
				break;

				case "sprice":
					this.sprice = fieldInfo.FieldValue.ParseLong("sprice");
				break;

				case "eprice":
					this.eprice = fieldInfo.FieldValue.ParseLong("eprice");
				break;

				case "volume":
					this.volume = fieldInfo.FieldValue.ParseLong("volume");
				break;

				case "idx":
					this.idx = fieldInfo.FieldValue.ParseLong("idx");
				break;


			}
		}

		public bool VerifyData()
		{
			// qrygb char 1
			// gubun char 1
			// jnilgubun char 1
			// sign char 1
			if (jc_num.ToString().Length > 12) return false; // long 12
			if (sprice.ToString().Length > 8) return false; // long 8
			if (eprice.ToString().Length > 8) return false; // long 8
			if (volume.ToString().Length > 12) return false; // long 12
			if (idx.ToString().Length > 4) return false; // long 4

			return true;
		}
	}

	public partial class XQt1422OutBlock : XingBlock
	{
		/// <summary>
		/// t1422OutBlock
		/// </summary>
		public const string _blockName = "t1422OutBlock";
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
		/// t1422OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1422OutBlock
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
		/// CNT
		/// </summary>
		[XAQueryFieldAttribute("CNT")]
		public long cnt;
		/// <summary>
		/// IDX
		/// </summary>
		[XAQueryFieldAttribute("IDX")]
		public long idx;

		public static class F
		{
			/// <summary>
			/// CNT
			/// </summary>
			public const string cnt = "cnt";
			/// <summary>
			/// IDX
			/// </summary>
			public const string idx = "idx";
		}

		public static string[] AllFields = new string[]
		{
			F.cnt,
			F.idx,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["cnt"] = new XAQueryFieldInfo("long", cnt, cnt.ToString("d4"), "CNT", (decimal)4);
			dict["idx"] = new XAQueryFieldInfo("long", idx, idx.ToString("d4"), "IDX", (decimal)4);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "cnt":
					this.cnt = fieldInfo.FieldValue.ParseLong("cnt");
				break;

				case "idx":
					this.idx = fieldInfo.FieldValue.ParseLong("idx");
				break;


			}
		}

		public static XQt1422OutBlock FromQuery(XQt1422 query)
		{
			XQt1422OutBlock block = new XQt1422OutBlock();
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
				block.cnt = query.GetFieldData(block.GetBlockName(), "cnt", 0).ParseLong("cnt"); // long 4
				block.idx = query.GetFieldData(block.GetBlockName(), "idx", 0).ParseLong("idx"); // long 4

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (cnt.ToString().Length > 4) return false; // long 4
			if (idx.ToString().Length > 4) return false; // long 4

			return true;
		}
	}

	public partial class XQt1422OutBlock1 : XingBlock
	{
		/// <summary>
		/// t1422OutBlock1
		/// </summary>
		public const string _blockName = "t1422OutBlock1";
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
		/// t1422OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1422OutBlock1
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
		/// 거래증가율
		/// </summary>
		[XAQueryFieldAttribute("거래증가율")]
		public float diff_vol;
		/// <summary>
		/// 매도잔량
		/// </summary>
		[XAQueryFieldAttribute("매도잔량")]
		public long offerrem1;
		/// <summary>
		/// 매수잔량
		/// </summary>
		[XAQueryFieldAttribute("매수잔량")]
		public long bidrem1;
		/// <summary>
		/// 최종진입
		/// </summary>
		[XAQueryFieldAttribute("최종진입")]
		public string last;
		/// <summary>
		/// 연속
		/// </summary>
		[XAQueryFieldAttribute("연속")]
		public long lmtdaycnt;
		/// <summary>
		/// 전일거래량
		/// </summary>
		[XAQueryFieldAttribute("전일거래량")]
		public long jnilvolume;
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
			/// 거래증가율
			/// </summary>
			public const string diff_vol = "diff_vol";
			/// <summary>
			/// 매도잔량
			/// </summary>
			public const string offerrem1 = "offerrem1";
			/// <summary>
			/// 매수잔량
			/// </summary>
			public const string bidrem1 = "bidrem1";
			/// <summary>
			/// 최종진입
			/// </summary>
			public const string last = "last";
			/// <summary>
			/// 연속
			/// </summary>
			public const string lmtdaycnt = "lmtdaycnt";
			/// <summary>
			/// 전일거래량
			/// </summary>
			public const string jnilvolume = "jnilvolume";
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
			F.diff_vol,
			F.offerrem1,
			F.bidrem1,
			F.last,
			F.lmtdaycnt,
			F.jnilvolume,
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
			dict["diff_vol"] = new XAQueryFieldInfo("float", diff_vol, diff_vol.ToString("0000000000.00"), "거래증가율", (decimal)10.2);
			dict["offerrem1"] = new XAQueryFieldInfo("long", offerrem1, offerrem1.ToString("d12"), "매도잔량", (decimal)12);
			dict["bidrem1"] = new XAQueryFieldInfo("long", bidrem1, bidrem1.ToString("d12"), "매수잔량", (decimal)12);
			dict["last"] = new XAQueryFieldInfo("char", last, last, "최종진입", (decimal)6);
			dict["lmtdaycnt"] = new XAQueryFieldInfo("long", lmtdaycnt, lmtdaycnt.ToString("d8"), "연속", (decimal)8);
			dict["jnilvolume"] = new XAQueryFieldInfo("long", jnilvolume, jnilvolume.ToString("d12"), "전일거래량", (decimal)12);
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

				case "diff_vol":
					this.diff_vol = fieldInfo.FieldValue.ParseFloat("diff_vol");
				break;

				case "offerrem1":
					this.offerrem1 = fieldInfo.FieldValue.ParseLong("offerrem1");
				break;

				case "bidrem1":
					this.bidrem1 = fieldInfo.FieldValue.ParseLong("bidrem1");
				break;

				case "last":
					this.last = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "lmtdaycnt":
					this.lmtdaycnt = fieldInfo.FieldValue.ParseLong("lmtdaycnt");
				break;

				case "jnilvolume":
					this.jnilvolume = fieldInfo.FieldValue.ParseLong("jnilvolume");
				break;

				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt1422OutBlock1[] ListFromQuery(XQt1422 query)
		{
			int count = query.GetBlockCount(XQt1422OutBlock1.BlockName);
			List<XQt1422OutBlock1> list = new List<XQt1422OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1422OutBlock1 block = new XQt1422OutBlock1();
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
					block.diff_vol = query.GetFieldData(block.GetBlockName(), "diff_vol", i).ParseFloat("diff_vol"); // float 10.2
					block.offerrem1 = query.GetFieldData(block.GetBlockName(), "offerrem1", i).ParseLong("offerrem1"); // long 12
					block.bidrem1 = query.GetFieldData(block.GetBlockName(), "bidrem1", i).ParseLong("bidrem1"); // long 12
					block.last = query.GetFieldData(block.GetBlockName(), "last", i).TrimEnd('?'); // char 6
					block.lmtdaycnt = query.GetFieldData(block.GetBlockName(), "lmtdaycnt", i).ParseLong("lmtdaycnt"); // long 8
					block.jnilvolume = query.GetFieldData(block.GetBlockName(), "jnilvolume", i).ParseLong("jnilvolume"); // long 12
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
			// diff_vol float 10.2
			if (offerrem1.ToString().Length > 12) return false; // long 12
			if (bidrem1.ToString().Length > 12) return false; // long 12
			if (last?.Length > 6) return false; // char 6
			if (lmtdaycnt.ToString().Length > 8) return false; // long 8
			if (jnilvolume.ToString().Length > 12) return false; // long 12
			if (shcode?.Length > 6) return false; // char 6

			return true;
		}
	}

	public partial class XQt1422 : XingQuery
	{
		/// <summary>
		/// t1422
		/// </summary>
		public const string _typeName = "t1422";
		/// <summary>
		/// 상/하한(t1422)
		/// </summary>
		public const string _typeDesc = "상/하한(t1422)";
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
		/// t1422
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 상/하한(t1422)
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

		public XQt1422() : base("t1422") { }


		public static XQt1422OutBlock1[] Get(char qrygb = default,char gubun = default,char jnilgubun = default,char sign = default,long jc_num = default,long sprice = default,long eprice = default,long volume = default,long idx = default)
		{
			using (XQt1422 instance = new XQt1422())
			{
				instance.SetFieldData(XQt1422InBlock.BlockName, XQt1422InBlock.F.qrygb, 0, qrygb.ToString()); // char 1
				instance.SetFieldData(XQt1422InBlock.BlockName, XQt1422InBlock.F.gubun, 0, gubun.ToString()); // char 1
				instance.SetFieldData(XQt1422InBlock.BlockName, XQt1422InBlock.F.jnilgubun, 0, jnilgubun.ToString()); // char 1
				instance.SetFieldData(XQt1422InBlock.BlockName, XQt1422InBlock.F.sign, 0, sign.ToString()); // char 1
				instance.SetFieldData(XQt1422InBlock.BlockName, XQt1422InBlock.F.jc_num, 0, jc_num.ToString("d12")); // long 12
				instance.SetFieldData(XQt1422InBlock.BlockName, XQt1422InBlock.F.sprice, 0, sprice.ToString("d8")); // long 8
				instance.SetFieldData(XQt1422InBlock.BlockName, XQt1422InBlock.F.eprice, 0, eprice.ToString("d8")); // long 8
				instance.SetFieldData(XQt1422InBlock.BlockName, XQt1422InBlock.F.volume, 0, volume.ToString("d12")); // long 12
				instance.SetFieldData(XQt1422InBlock.BlockName, XQt1422InBlock.F.idx, 0, idx.ToString("d4")); // long 4

				if (instance.Request() < 0)
				{
					return null;
				}

				var outBlock = instance.GetBlock1s();
				return outBlock;
			}
		}

		public bool SetBlock(XQt1422InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "qrygb", 0, block.qrygb.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "gubun", 0, block.gubun.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "jnilgubun", 0, block.jnilgubun.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "sign", 0, block.sign.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "jc_num", 0, block.jc_num.ToString("d12")); // long 12
			_xaQuery.SetFieldData(block.GetBlockName(), "sprice", 0, block.sprice.ToString("d8")); // long 8
			_xaQuery.SetFieldData(block.GetBlockName(), "eprice", 0, block.eprice.ToString("d8")); // long 8
			_xaQuery.SetFieldData(block.GetBlockName(), "volume", 0, block.volume.ToString("d12")); // long 12
			_xaQuery.SetFieldData(block.GetBlockName(), "idx", 0, block.idx.ToString("d4")); // long 4

			return true;
		}

		public XQt1422OutBlock GetBlock()
		{
			XQt1422OutBlock instance = XQt1422OutBlock.FromQuery(this);
			return instance;

		}

		public XQt1422OutBlock1[] GetBlock1s()
		{
			XQt1422OutBlock1[] instance = XQt1422OutBlock1.ListFromQuery(this);
			return instance;

		}


	}

}
