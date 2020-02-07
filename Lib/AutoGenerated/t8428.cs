using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt8428InBlock : XingBlock
	{
		/// <summary>
		/// t8428InBlock
		/// </summary>
		public const string _blockName = "t8428InBlock";
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
		/// t8428InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t8428InBlock
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
		/// from일자
		/// </summary>
		[XAQueryFieldAttribute("from일자")]
		public string fdate;
		/// <summary>
		/// to일자
		/// </summary>
		[XAQueryFieldAttribute("to일자")]
		public string tdate;
		/// <summary>
		/// 구분
		/// </summary>
		[XAQueryFieldAttribute("구분")]
		public char gubun;
		/// <summary>
		/// 날짜
		/// </summary>
		[XAQueryFieldAttribute("날짜")]
		public string key_date;
		/// <summary>
		/// 업종코드
		/// </summary>
		[XAQueryFieldAttribute("업종코드")]
		public string upcode;
		/// <summary>
		/// 조회건수
		/// </summary>
		[XAQueryFieldAttribute("조회건수")]
		public int cnt;

		public static class F
		{
			/// <summary>
			/// from일자
			/// </summary>
			public const string fdate = "fdate";
			/// <summary>
			/// to일자
			/// </summary>
			public const string tdate = "tdate";
			/// <summary>
			/// 구분
			/// </summary>
			public const string gubun = "gubun";
			/// <summary>
			/// 날짜
			/// </summary>
			public const string key_date = "key_date";
			/// <summary>
			/// 업종코드
			/// </summary>
			public const string upcode = "upcode";
			/// <summary>
			/// 조회건수
			/// </summary>
			public const string cnt = "cnt";
		}

		public static string[] AllFields = new string[]
		{
			F.fdate,
			F.tdate,
			F.gubun,
			F.key_date,
			F.upcode,
			F.cnt,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["fdate"] = new XAQueryFieldInfo("char", fdate, fdate, "from일자", (decimal)8);
			dict["tdate"] = new XAQueryFieldInfo("char", tdate, tdate, "to일자", (decimal)8);
			dict["gubun"] = new XAQueryFieldInfo("char", gubun, gubun.ToString(), "구분", (decimal)1);
			dict["key_date"] = new XAQueryFieldInfo("char", key_date, key_date, "날짜", (decimal)8);
			dict["upcode"] = new XAQueryFieldInfo("char", upcode, upcode, "업종코드", (decimal)3);
			dict["cnt"] = new XAQueryFieldInfo("int", cnt, cnt.ToString("d3"), "조회건수", (decimal)3);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "fdate":
					this.fdate = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "tdate":
					this.tdate = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "gubun":
					this.gubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "key_date":
					this.key_date = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "upcode":
					this.upcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cnt":
					this.cnt = fieldInfo.FieldValue.ParseInt("cnt");
				break;


			}
		}

		public bool VerifyData()
		{
			if (fdate?.Length > 8) return false; // char 8
			if (tdate?.Length > 8) return false; // char 8
			// gubun char 1
			if (key_date?.Length > 8) return false; // char 8
			if (upcode?.Length > 3) return false; // char 3
			// cnt int 3

			return true;
		}
	}

	public partial class XQt8428OutBlock : XingBlock
	{
		/// <summary>
		/// t8428OutBlock
		/// </summary>
		public const string _blockName = "t8428OutBlock";
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
		/// t8428OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t8428OutBlock
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
		/// 날짜CTS
		/// </summary>
		[XAQueryFieldAttribute("날짜CTS")]
		public string date;
		/// <summary>
		/// IDX
		/// </summary>
		[XAQueryFieldAttribute("IDX")]
		public long idx;

		public static class F
		{
			/// <summary>
			/// 날짜CTS
			/// </summary>
			public const string date = "date";
			/// <summary>
			/// IDX
			/// </summary>
			public const string idx = "idx";
		}

		public static string[] AllFields = new string[]
		{
			F.date,
			F.idx,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["date"] = new XAQueryFieldInfo("char", date, date, "날짜CTS", (decimal)8);
			dict["idx"] = new XAQueryFieldInfo("long", idx, idx.ToString("d4"), "IDX", (decimal)4);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "date":
					this.date = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "idx":
					this.idx = fieldInfo.FieldValue.ParseLong("idx");
				break;


			}
		}

		public static XQt8428OutBlock FromQuery(XQt8428 query)
		{
			XQt8428OutBlock block = new XQt8428OutBlock();
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
				block.date = query.GetFieldData(block.GetBlockName(), "date", 0).TrimEnd('?'); // char 8
				block.idx = query.GetFieldData(block.GetBlockName(), "idx", 0).ParseLong("idx"); // long 4

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (date?.Length > 8) return false; // char 8
			if (idx.ToString().Length > 4) return false; // long 4

			return true;
		}
	}

	public partial class XQt8428OutBlock1 : XingBlock
	{
		/// <summary>
		/// t8428OutBlock1
		/// </summary>
		public const string _blockName = "t8428OutBlock1";
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
		/// t8428OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t8428OutBlock1
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
		/// 일자
		/// </summary>
		[XAQueryFieldAttribute("일자")]
		public string date;
		/// <summary>
		/// 지수
		/// </summary>
		[XAQueryFieldAttribute("지수")]
		public float jisu;
		/// <summary>
		/// 대비구분
		/// </summary>
		[XAQueryFieldAttribute("대비구분")]
		public char sign;
		/// <summary>
		/// 대비
		/// </summary>
		[XAQueryFieldAttribute("대비")]
		public float change;
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
		/// 고객예탁금_억원
		/// </summary>
		[XAQueryFieldAttribute("고객예탁금_억원")]
		public long custmoney;
		/// <summary>
		/// 예탁증감_억원
		/// </summary>
		[XAQueryFieldAttribute("예탁증감_억원")]
		public long yecha;
		/// <summary>
		/// 회전율
		/// </summary>
		[XAQueryFieldAttribute("회전율")]
		public float vol;
		/// <summary>
		/// 미수금_억원
		/// </summary>
		[XAQueryFieldAttribute("미수금_억원")]
		public long outmoney;
		/// <summary>
		/// 신용잔고_억원
		/// </summary>
		[XAQueryFieldAttribute("신용잔고_억원")]
		public long trjango;
		/// <summary>
		/// 선물예수금_억원
		/// </summary>
		[XAQueryFieldAttribute("선물예수금_억원")]
		public long futymoney;
		/// <summary>
		/// 주식형_억원
		/// </summary>
		[XAQueryFieldAttribute("주식형_억원")]
		public long stkmoney;
		/// <summary>
		/// 혼합형_억원(주식)
		/// </summary>
		[XAQueryFieldAttribute("혼합형_억원(주식)")]
		public long mstkmoney;
		/// <summary>
		/// 혼합형_억원(채권)
		/// </summary>
		[XAQueryFieldAttribute("혼합형_억원(채권)")]
		public long mbndmoney;
		/// <summary>
		/// 채권형_억원
		/// </summary>
		[XAQueryFieldAttribute("채권형_억원")]
		public long bndmoney;
		/// <summary>
		/// 필러(구.단기채권)
		/// </summary>
		[XAQueryFieldAttribute("필러(구.단기채권)")]
		public long bndsmoney;
		/// <summary>
		/// MMF_억원(주식)
		/// </summary>
		[XAQueryFieldAttribute("MMF_억원(주식)")]
		public long mmfmoney;

		public static class F
		{
			/// <summary>
			/// 일자
			/// </summary>
			public const string date = "date";
			/// <summary>
			/// 지수
			/// </summary>
			public const string jisu = "jisu";
			/// <summary>
			/// 대비구분
			/// </summary>
			public const string sign = "sign";
			/// <summary>
			/// 대비
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
			/// 고객예탁금_억원
			/// </summary>
			public const string custmoney = "custmoney";
			/// <summary>
			/// 예탁증감_억원
			/// </summary>
			public const string yecha = "yecha";
			/// <summary>
			/// 회전율
			/// </summary>
			public const string vol = "vol";
			/// <summary>
			/// 미수금_억원
			/// </summary>
			public const string outmoney = "outmoney";
			/// <summary>
			/// 신용잔고_억원
			/// </summary>
			public const string trjango = "trjango";
			/// <summary>
			/// 선물예수금_억원
			/// </summary>
			public const string futymoney = "futymoney";
			/// <summary>
			/// 주식형_억원
			/// </summary>
			public const string stkmoney = "stkmoney";
			/// <summary>
			/// 혼합형_억원(주식)
			/// </summary>
			public const string mstkmoney = "mstkmoney";
			/// <summary>
			/// 혼합형_억원(채권)
			/// </summary>
			public const string mbndmoney = "mbndmoney";
			/// <summary>
			/// 채권형_억원
			/// </summary>
			public const string bndmoney = "bndmoney";
			/// <summary>
			/// 필러(구.단기채권)
			/// </summary>
			public const string bndsmoney = "bndsmoney";
			/// <summary>
			/// MMF_억원(주식)
			/// </summary>
			public const string mmfmoney = "mmfmoney";
		}

		public static string[] AllFields = new string[]
		{
			F.date,
			F.jisu,
			F.sign,
			F.change,
			F.diff,
			F.volume,
			F.custmoney,
			F.yecha,
			F.vol,
			F.outmoney,
			F.trjango,
			F.futymoney,
			F.stkmoney,
			F.mstkmoney,
			F.mbndmoney,
			F.bndmoney,
			F.bndsmoney,
			F.mmfmoney,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["date"] = new XAQueryFieldInfo("char", date, date, "일자", (decimal)8);
			dict["jisu"] = new XAQueryFieldInfo("float", jisu, jisu.ToString("0000000.00"), "지수", (decimal)7.2);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("float", change, change.ToString("000000.00"), "대비", (decimal)6.2);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "거래량", (decimal)12);
			dict["custmoney"] = new XAQueryFieldInfo("long", custmoney, custmoney.ToString("d12"), "고객예탁금_억원", (decimal)12);
			dict["yecha"] = new XAQueryFieldInfo("long", yecha, yecha.ToString("d12"), "예탁증감_억원", (decimal)12);
			dict["vol"] = new XAQueryFieldInfo("float", vol, vol.ToString("000000.00"), "회전율", (decimal)6.2);
			dict["outmoney"] = new XAQueryFieldInfo("long", outmoney, outmoney.ToString("d12"), "미수금_억원", (decimal)12);
			dict["trjango"] = new XAQueryFieldInfo("long", trjango, trjango.ToString("d12"), "신용잔고_억원", (decimal)12);
			dict["futymoney"] = new XAQueryFieldInfo("long", futymoney, futymoney.ToString("d12"), "선물예수금_억원", (decimal)12);
			dict["stkmoney"] = new XAQueryFieldInfo("long", stkmoney, stkmoney.ToString("d8"), "주식형_억원", (decimal)8);
			dict["mstkmoney"] = new XAQueryFieldInfo("long", mstkmoney, mstkmoney.ToString("d8"), "혼합형_억원(주식)", (decimal)8);
			dict["mbndmoney"] = new XAQueryFieldInfo("long", mbndmoney, mbndmoney.ToString("d8"), "혼합형_억원(채권)", (decimal)8);
			dict["bndmoney"] = new XAQueryFieldInfo("long", bndmoney, bndmoney.ToString("d8"), "채권형_억원", (decimal)8);
			dict["bndsmoney"] = new XAQueryFieldInfo("long", bndsmoney, bndsmoney.ToString("d8"), "필러(구.단기채권)", (decimal)8);
			dict["mmfmoney"] = new XAQueryFieldInfo("long", mmfmoney, mmfmoney.ToString("d8"), "MMF_억원(주식)", (decimal)8);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "date":
					this.date = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "jisu":
					this.jisu = fieldInfo.FieldValue.ParseFloat("jisu");
				break;

				case "sign":
					this.sign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "change":
					this.change = fieldInfo.FieldValue.ParseFloat("change");
				break;

				case "diff":
					this.diff = fieldInfo.FieldValue.ParseFloat("diff");
				break;

				case "volume":
					this.volume = fieldInfo.FieldValue.ParseLong("volume");
				break;

				case "custmoney":
					this.custmoney = fieldInfo.FieldValue.ParseLong("custmoney");
				break;

				case "yecha":
					this.yecha = fieldInfo.FieldValue.ParseLong("yecha");
				break;

				case "vol":
					this.vol = fieldInfo.FieldValue.ParseFloat("vol");
				break;

				case "outmoney":
					this.outmoney = fieldInfo.FieldValue.ParseLong("outmoney");
				break;

				case "trjango":
					this.trjango = fieldInfo.FieldValue.ParseLong("trjango");
				break;

				case "futymoney":
					this.futymoney = fieldInfo.FieldValue.ParseLong("futymoney");
				break;

				case "stkmoney":
					this.stkmoney = fieldInfo.FieldValue.ParseLong("stkmoney");
				break;

				case "mstkmoney":
					this.mstkmoney = fieldInfo.FieldValue.ParseLong("mstkmoney");
				break;

				case "mbndmoney":
					this.mbndmoney = fieldInfo.FieldValue.ParseLong("mbndmoney");
				break;

				case "bndmoney":
					this.bndmoney = fieldInfo.FieldValue.ParseLong("bndmoney");
				break;

				case "bndsmoney":
					this.bndsmoney = fieldInfo.FieldValue.ParseLong("bndsmoney");
				break;

				case "mmfmoney":
					this.mmfmoney = fieldInfo.FieldValue.ParseLong("mmfmoney");
				break;


			}
		}

		public static XQt8428OutBlock1[] ListFromQuery(XQt8428 query)
		{
			int count = query.GetBlockCount(XQt8428OutBlock1.BlockName);
			List<XQt8428OutBlock1> list = new List<XQt8428OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt8428OutBlock1 block = new XQt8428OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.date = query.GetFieldData(block.GetBlockName(), "date", i).TrimEnd('?'); // char 8
					block.jisu = query.GetFieldData(block.GetBlockName(), "jisu", i).ParseFloat("jisu"); // float 7.2
					block.sign = query.GetFieldData(block.GetBlockName(), "sign", i).FirstOrDefault(); // char 1
					block.change = query.GetFieldData(block.GetBlockName(), "change", i).ParseFloat("change"); // float 6.2
					block.diff = query.GetFieldData(block.GetBlockName(), "diff", i).ParseFloat("diff"); // float 6.2
					block.volume = query.GetFieldData(block.GetBlockName(), "volume", i).ParseLong("volume"); // long 12
					block.custmoney = query.GetFieldData(block.GetBlockName(), "custmoney", i).ParseLong("custmoney"); // long 12
					block.yecha = query.GetFieldData(block.GetBlockName(), "yecha", i).ParseLong("yecha"); // long 12
					block.vol = query.GetFieldData(block.GetBlockName(), "vol", i).ParseFloat("vol"); // float 6.2
					block.outmoney = query.GetFieldData(block.GetBlockName(), "outmoney", i).ParseLong("outmoney"); // long 12
					block.trjango = query.GetFieldData(block.GetBlockName(), "trjango", i).ParseLong("trjango"); // long 12
					block.futymoney = query.GetFieldData(block.GetBlockName(), "futymoney", i).ParseLong("futymoney"); // long 12
					block.stkmoney = query.GetFieldData(block.GetBlockName(), "stkmoney", i).ParseLong("stkmoney"); // long 8
					block.mstkmoney = query.GetFieldData(block.GetBlockName(), "mstkmoney", i).ParseLong("mstkmoney"); // long 8
					block.mbndmoney = query.GetFieldData(block.GetBlockName(), "mbndmoney", i).ParseLong("mbndmoney"); // long 8
					block.bndmoney = query.GetFieldData(block.GetBlockName(), "bndmoney", i).ParseLong("bndmoney"); // long 8
					block.bndsmoney = query.GetFieldData(block.GetBlockName(), "bndsmoney", i).ParseLong("bndsmoney"); // long 8
					block.mmfmoney = query.GetFieldData(block.GetBlockName(), "mmfmoney", i).ParseLong("mmfmoney"); // long 8

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
			if (date?.Length > 8) return false; // char 8
			// jisu float 7.2
			// sign char 1
			// change float 6.2
			// diff float 6.2
			if (volume.ToString().Length > 12) return false; // long 12
			if (custmoney.ToString().Length > 12) return false; // long 12
			if (yecha.ToString().Length > 12) return false; // long 12
			// vol float 6.2
			if (outmoney.ToString().Length > 12) return false; // long 12
			if (trjango.ToString().Length > 12) return false; // long 12
			if (futymoney.ToString().Length > 12) return false; // long 12
			if (stkmoney.ToString().Length > 8) return false; // long 8
			if (mstkmoney.ToString().Length > 8) return false; // long 8
			if (mbndmoney.ToString().Length > 8) return false; // long 8
			if (bndmoney.ToString().Length > 8) return false; // long 8
			if (bndsmoney.ToString().Length > 8) return false; // long 8
			if (mmfmoney.ToString().Length > 8) return false; // long 8

			return true;
		}
	}

	/// <summary>
	/// 증시주변자금추이(t8428)
	/// </summary>
	public partial class XQt8428 : XingQuery
	{
		/// <summary>
		/// t8428
		/// </summary>
		public const string _typeName = "t8428";
		/// <summary>
		/// 증시주변자금추이(t8428)
		/// </summary>
		public const string _typeDesc = "증시주변자금추이(t8428)";
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
		/// t8428
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 증시주변자금추이(t8428)
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
		/// 증시주변자금추이(t8428)
		/// </summary>
		public XQt8428() : base("t8428") { }


		public class XQAllOutBlocks
		{
			public XQt8428OutBlock OutBlock { get; internal set; }
			public XQt8428OutBlock1[] OutBlock1 { get; internal set; }
		}

		public static XQAllOutBlocks Get(string fdate = default,string tdate = default,char gubun = default,string key_date = default,string upcode = default,int cnt = default)
		{
			using (XQt8428 instance = new XQt8428())
			{
				instance.SetFieldData(XQt8428InBlock.BlockName, XQt8428InBlock.F.fdate, 0, fdate); // char 8
				instance.SetFieldData(XQt8428InBlock.BlockName, XQt8428InBlock.F.tdate, 0, tdate); // char 8
				instance.SetFieldData(XQt8428InBlock.BlockName, XQt8428InBlock.F.gubun, 0, gubun.ToString()); // char 1
				instance.SetFieldData(XQt8428InBlock.BlockName, XQt8428InBlock.F.key_date, 0, key_date); // char 8
				instance.SetFieldData(XQt8428InBlock.BlockName, XQt8428InBlock.F.upcode, 0, upcode); // char 3
				instance.SetFieldData(XQt8428InBlock.BlockName, XQt8428InBlock.F.cnt, 0, cnt.ToString("d3")); // int 3

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

		public bool SetBlock(XQt8428InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "fdate", 0, block.fdate); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "tdate", 0, block.tdate); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "gubun", 0, block.gubun.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "key_date", 0, block.key_date); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "upcode", 0, block.upcode); // char 3
			_xaQuery.SetFieldData(block.GetBlockName(), "cnt", 0, block.cnt.ToString("d3")); // int 3

			return true;
		}

		public XQt8428OutBlock GetBlock()
		{
			XQt8428OutBlock instance = XQt8428OutBlock.FromQuery(this);
			return instance;

		}

		public XQt8428OutBlock1[] GetBlock1s()
		{
			XQt8428OutBlock1[] instance = XQt8428OutBlock1.ListFromQuery(this);
			return instance;

		}


	}

}
