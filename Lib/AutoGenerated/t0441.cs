using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt0441InBlock : XingBlock
	{
		/// <summary>
		/// t0441InBlock
		/// </summary>
		public const string _blockName = "t0441InBlock";
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
		/// t0441InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t0441InBlock
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
		/// 계좌번호
		/// </summary>
		[XAQueryFieldAttribute("계좌번호")]
		public string accno;
		/// <summary>
		/// 비밀번호
		/// </summary>
		[XAQueryFieldAttribute("비밀번호")]
		public string passwd;
		/// <summary>
		/// CTS_종목번호
		/// </summary>
		[XAQueryFieldAttribute("CTS_종목번호")]
		public string cts_expcode;
		/// <summary>
		/// CTS_매매구분
		/// </summary>
		[XAQueryFieldAttribute("CTS_매매구분")]
		public char cts_medocd;

		public static class F
		{
			/// <summary>
			/// 계좌번호
			/// </summary>
			public const string accno = "accno";
			/// <summary>
			/// 비밀번호
			/// </summary>
			public const string passwd = "passwd";
			/// <summary>
			/// CTS_종목번호
			/// </summary>
			public const string cts_expcode = "cts_expcode";
			/// <summary>
			/// CTS_매매구분
			/// </summary>
			public const string cts_medocd = "cts_medocd";
		}

		public static string[] AllFields = new string[]
		{
			F.accno,
			F.passwd,
			F.cts_expcode,
			F.cts_medocd,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["accno"] = new XAQueryFieldInfo("char", accno, accno, "계좌번호", (decimal)11);
			dict["passwd"] = new XAQueryFieldInfo("char", passwd, passwd, "비밀번호", (decimal)8);
			dict["cts_expcode"] = new XAQueryFieldInfo("char", cts_expcode, cts_expcode, "CTS_종목번호", (decimal)8);
			dict["cts_medocd"] = new XAQueryFieldInfo("char", cts_medocd, cts_medocd.ToString(), "CTS_매매구분", (decimal)1);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "accno":
					this.accno = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "passwd":
					this.passwd = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cts_expcode":
					this.cts_expcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cts_medocd":
					this.cts_medocd = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public bool VerifyData()
		{
			if (accno?.Length > 11) return false; // char 11
			if (passwd?.Length > 8) return false; // char 8
			if (cts_expcode?.Length > 8) return false; // char 8
			// cts_medocd char 1

			return true;
		}
	}

	public partial class XQt0441OutBlock : XingBlock
	{
		/// <summary>
		/// t0441OutBlock
		/// </summary>
		public const string _blockName = "t0441OutBlock";
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
		/// t0441OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t0441OutBlock
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
		/// 매매손익합계
		/// </summary>
		[XAQueryFieldAttribute("매매손익합계")]
		public long tdtsunik;
		/// <summary>
		/// CTS_종목번호
		/// </summary>
		[XAQueryFieldAttribute("CTS_종목번호")]
		public string cts_expcode;
		/// <summary>
		/// CTS_매매구분
		/// </summary>
		[XAQueryFieldAttribute("CTS_매매구분")]
		public char cts_medocd;
		/// <summary>
		/// 평가금액
		/// </summary>
		[XAQueryFieldAttribute("평가금액")]
		public long tappamt;
		/// <summary>
		/// 평가손익
		/// </summary>
		[XAQueryFieldAttribute("평가손익")]
		public long tsunik;

		public static class F
		{
			/// <summary>
			/// 매매손익합계
			/// </summary>
			public const string tdtsunik = "tdtsunik";
			/// <summary>
			/// CTS_종목번호
			/// </summary>
			public const string cts_expcode = "cts_expcode";
			/// <summary>
			/// CTS_매매구분
			/// </summary>
			public const string cts_medocd = "cts_medocd";
			/// <summary>
			/// 평가금액
			/// </summary>
			public const string tappamt = "tappamt";
			/// <summary>
			/// 평가손익
			/// </summary>
			public const string tsunik = "tsunik";
		}

		public static string[] AllFields = new string[]
		{
			F.tdtsunik,
			F.cts_expcode,
			F.cts_medocd,
			F.tappamt,
			F.tsunik,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["tdtsunik"] = new XAQueryFieldInfo("long", tdtsunik, tdtsunik.ToString("d18"), "매매손익합계", (decimal)18);
			dict["cts_expcode"] = new XAQueryFieldInfo("char", cts_expcode, cts_expcode, "CTS_종목번호", (decimal)8);
			dict["cts_medocd"] = new XAQueryFieldInfo("char", cts_medocd, cts_medocd.ToString(), "CTS_매매구분", (decimal)1);
			dict["tappamt"] = new XAQueryFieldInfo("long", tappamt, tappamt.ToString("d18"), "평가금액", (decimal)18);
			dict["tsunik"] = new XAQueryFieldInfo("long", tsunik, tsunik.ToString("d18"), "평가손익", (decimal)18);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "tdtsunik":
					this.tdtsunik = fieldInfo.FieldValue.ParseLong("tdtsunik");
				break;

				case "cts_expcode":
					this.cts_expcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cts_medocd":
					this.cts_medocd = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "tappamt":
					this.tappamt = fieldInfo.FieldValue.ParseLong("tappamt");
				break;

				case "tsunik":
					this.tsunik = fieldInfo.FieldValue.ParseLong("tsunik");
				break;


			}
		}

		public static XQt0441OutBlock FromQuery(XQt0441 query)
		{
			XQt0441OutBlock block = new XQt0441OutBlock();
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
				block.tdtsunik = query.GetFieldData(block.GetBlockName(), "tdtsunik", 0).ParseLong("tdtsunik"); // long 18
				block.cts_expcode = query.GetFieldData(block.GetBlockName(), "cts_expcode", 0).TrimEnd('?'); // char 8
				block.cts_medocd = query.GetFieldData(block.GetBlockName(), "cts_medocd", 0).FirstOrDefault(); // char 1
				block.tappamt = query.GetFieldData(block.GetBlockName(), "tappamt", 0).ParseLong("tappamt"); // long 18
				block.tsunik = query.GetFieldData(block.GetBlockName(), "tsunik", 0).ParseLong("tsunik"); // long 18

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (tdtsunik.ToString().Length > 18) return false; // long 18
			if (cts_expcode?.Length > 8) return false; // char 8
			// cts_medocd char 1
			if (tappamt.ToString().Length > 18) return false; // long 18
			if (tsunik.ToString().Length > 18) return false; // long 18

			return true;
		}
	}

	public partial class XQt0441OutBlock1 : XingBlock
	{
		/// <summary>
		/// t0441OutBlock1
		/// </summary>
		public const string _blockName = "t0441OutBlock1";
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
		/// t0441OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t0441OutBlock1
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
		/// 종목번호
		/// </summary>
		[XAQueryFieldAttribute("종목번호")]
		public string expcode;
		/// <summary>
		/// 구분
		/// </summary>
		[XAQueryFieldAttribute("구분")]
		public string medosu;
		/// <summary>
		/// 잔고수량
		/// </summary>
		[XAQueryFieldAttribute("잔고수량")]
		public long jqty;
		/// <summary>
		/// 청산가능수량
		/// </summary>
		[XAQueryFieldAttribute("청산가능수량")]
		public long cqty;
		/// <summary>
		/// 평균단가
		/// </summary>
		[XAQueryFieldAttribute("평균단가")]
		public float pamt;
		/// <summary>
		/// 총매입금액
		/// </summary>
		[XAQueryFieldAttribute("총매입금액")]
		public long mamt;
		/// <summary>
		/// 매매구분
		/// </summary>
		[XAQueryFieldAttribute("매매구분")]
		public char medocd;
		/// <summary>
		/// 매매손익
		/// </summary>
		[XAQueryFieldAttribute("매매손익")]
		public long dtsunik;
		/// <summary>
		/// 처리순번
		/// </summary>
		[XAQueryFieldAttribute("처리순번")]
		public long sysprocseq;
		/// <summary>
		/// 현재가
		/// </summary>
		[XAQueryFieldAttribute("현재가")]
		public float price;
		/// <summary>
		/// 평가금액
		/// </summary>
		[XAQueryFieldAttribute("평가금액")]
		public long appamt;
		/// <summary>
		/// 평가손익
		/// </summary>
		[XAQueryFieldAttribute("평가손익")]
		public long dtsunik1;
		/// <summary>
		/// 수익율
		/// </summary>
		[XAQueryFieldAttribute("수익율")]
		public float sunikrt;

		public static class F
		{
			/// <summary>
			/// 종목번호
			/// </summary>
			public const string expcode = "expcode";
			/// <summary>
			/// 구분
			/// </summary>
			public const string medosu = "medosu";
			/// <summary>
			/// 잔고수량
			/// </summary>
			public const string jqty = "jqty";
			/// <summary>
			/// 청산가능수량
			/// </summary>
			public const string cqty = "cqty";
			/// <summary>
			/// 평균단가
			/// </summary>
			public const string pamt = "pamt";
			/// <summary>
			/// 총매입금액
			/// </summary>
			public const string mamt = "mamt";
			/// <summary>
			/// 매매구분
			/// </summary>
			public const string medocd = "medocd";
			/// <summary>
			/// 매매손익
			/// </summary>
			public const string dtsunik = "dtsunik";
			/// <summary>
			/// 처리순번
			/// </summary>
			public const string sysprocseq = "sysprocseq";
			/// <summary>
			/// 현재가
			/// </summary>
			public const string price = "price";
			/// <summary>
			/// 평가금액
			/// </summary>
			public const string appamt = "appamt";
			/// <summary>
			/// 평가손익
			/// </summary>
			public const string dtsunik1 = "dtsunik1";
			/// <summary>
			/// 수익율
			/// </summary>
			public const string sunikrt = "sunikrt";
		}

		public static string[] AllFields = new string[]
		{
			F.expcode,
			F.medosu,
			F.jqty,
			F.cqty,
			F.pamt,
			F.mamt,
			F.medocd,
			F.dtsunik,
			F.sysprocseq,
			F.price,
			F.appamt,
			F.dtsunik1,
			F.sunikrt,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["expcode"] = new XAQueryFieldInfo("char", expcode, expcode, "종목번호", (decimal)8);
			dict["medosu"] = new XAQueryFieldInfo("char", medosu, medosu, "구분", (decimal)4);
			dict["jqty"] = new XAQueryFieldInfo("long", jqty, jqty.ToString("d10"), "잔고수량", (decimal)10);
			dict["cqty"] = new XAQueryFieldInfo("long", cqty, cqty.ToString("d10"), "청산가능수량", (decimal)10);
			dict["pamt"] = new XAQueryFieldInfo("float", pamt, pamt.ToString("0000000000.00"), "평균단가", (decimal)10.2);
			dict["mamt"] = new XAQueryFieldInfo("long", mamt, mamt.ToString("d18"), "총매입금액", (decimal)18);
			dict["medocd"] = new XAQueryFieldInfo("char", medocd, medocd.ToString(), "매매구분", (decimal)1);
			dict["dtsunik"] = new XAQueryFieldInfo("long", dtsunik, dtsunik.ToString("d18"), "매매손익", (decimal)18);
			dict["sysprocseq"] = new XAQueryFieldInfo("long", sysprocseq, sysprocseq.ToString("d10"), "처리순번", (decimal)10);
			dict["price"] = new XAQueryFieldInfo("float", price, price.ToString("000000000.00"), "현재가", (decimal)9.2);
			dict["appamt"] = new XAQueryFieldInfo("long", appamt, appamt.ToString("d18"), "평가금액", (decimal)18);
			dict["dtsunik1"] = new XAQueryFieldInfo("long", dtsunik1, dtsunik1.ToString("d18"), "평가손익", (decimal)18);
			dict["sunikrt"] = new XAQueryFieldInfo("float", sunikrt, sunikrt.ToString("0000000000.00"), "수익율", (decimal)10.2);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "expcode":
					this.expcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "medosu":
					this.medosu = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "jqty":
					this.jqty = fieldInfo.FieldValue.ParseLong("jqty");
				break;

				case "cqty":
					this.cqty = fieldInfo.FieldValue.ParseLong("cqty");
				break;

				case "pamt":
					this.pamt = fieldInfo.FieldValue.ParseFloat("pamt");
				break;

				case "mamt":
					this.mamt = fieldInfo.FieldValue.ParseLong("mamt");
				break;

				case "medocd":
					this.medocd = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "dtsunik":
					this.dtsunik = fieldInfo.FieldValue.ParseLong("dtsunik");
				break;

				case "sysprocseq":
					this.sysprocseq = fieldInfo.FieldValue.ParseLong("sysprocseq");
				break;

				case "price":
					this.price = fieldInfo.FieldValue.ParseFloat("price");
				break;

				case "appamt":
					this.appamt = fieldInfo.FieldValue.ParseLong("appamt");
				break;

				case "dtsunik1":
					this.dtsunik1 = fieldInfo.FieldValue.ParseLong("dtsunik1");
				break;

				case "sunikrt":
					this.sunikrt = fieldInfo.FieldValue.ParseFloat("sunikrt");
				break;


			}
		}

		public static XQt0441OutBlock1[] ListFromQuery(XQt0441 query)
		{
			int count = query.GetBlockCount(XQt0441OutBlock1.BlockName);
			List<XQt0441OutBlock1> list = new List<XQt0441OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt0441OutBlock1 block = new XQt0441OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.expcode = query.GetFieldData(block.GetBlockName(), "expcode", i).TrimEnd('?'); // char 8
					block.medosu = query.GetFieldData(block.GetBlockName(), "medosu", i).TrimEnd('?'); // char 4
					block.jqty = query.GetFieldData(block.GetBlockName(), "jqty", i).ParseLong("jqty"); // long 10
					block.cqty = query.GetFieldData(block.GetBlockName(), "cqty", i).ParseLong("cqty"); // long 10
					block.pamt = query.GetFieldData(block.GetBlockName(), "pamt", i).ParseFloat("pamt"); // float 10.2
					block.mamt = query.GetFieldData(block.GetBlockName(), "mamt", i).ParseLong("mamt"); // long 18
					block.medocd = query.GetFieldData(block.GetBlockName(), "medocd", i).FirstOrDefault(); // char 1
					block.dtsunik = query.GetFieldData(block.GetBlockName(), "dtsunik", i).ParseLong("dtsunik"); // long 18
					block.sysprocseq = query.GetFieldData(block.GetBlockName(), "sysprocseq", i).ParseLong("sysprocseq"); // long 10
					block.price = query.GetFieldData(block.GetBlockName(), "price", i).ParseFloat("price"); // float 9.2
					block.appamt = query.GetFieldData(block.GetBlockName(), "appamt", i).ParseLong("appamt"); // long 18
					block.dtsunik1 = query.GetFieldData(block.GetBlockName(), "dtsunik1", i).ParseLong("dtsunik1"); // long 18
					block.sunikrt = query.GetFieldData(block.GetBlockName(), "sunikrt", i).ParseFloat("sunikrt"); // float 10.2

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
			if (expcode?.Length > 8) return false; // char 8
			if (medosu?.Length > 4) return false; // char 4
			if (jqty.ToString().Length > 10) return false; // long 10
			if (cqty.ToString().Length > 10) return false; // long 10
			// pamt float 10.2
			if (mamt.ToString().Length > 18) return false; // long 18
			// medocd char 1
			if (dtsunik.ToString().Length > 18) return false; // long 18
			if (sysprocseq.ToString().Length > 10) return false; // long 10
			// price float 9.2
			if (appamt.ToString().Length > 18) return false; // long 18
			if (dtsunik1.ToString().Length > 18) return false; // long 18
			// sunikrt float 10.2

			return true;
		}
	}

	/// <summary>
	/// 선물/옵션잔고평가(이동평균)(t0441)
	/// </summary>
	public partial class XQt0441 : XingQuery
	{
		/// <summary>
		/// t0441
		/// </summary>
		public const string _typeName = "t0441";
		/// <summary>
		/// 선물/옵션잔고평가(이동평균)(t0441)
		/// </summary>
		public const string _typeDesc = "선물/옵션잔고평가(이동평균)(t0441)";
		/// <summary>
		/// 
		/// </summary>
		public const string _service = "";
		/// <summary>
		/// D
		/// </summary>
		public const string _headType = "D";
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
		/// false
		/// </summary>
		public const bool _block = false;
		/// <summary>
		/// false
		/// </summary>
		public const bool _encrypt = false;
		/// <summary>
		/// false
		/// </summary>
		public const bool _signature = false;

		/// <summary>
		/// t0441
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 선물/옵션잔고평가(이동평균)(t0441)
		/// </summary>
		public string TypeDesc => _typeDesc;
		/// <summary>
		/// 
		/// </summary>
		public string Service => _service;
		/// <summary>
		/// D
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
		/// false
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

		public XQt0441() : base("t0441") { }


		public static XQt0441OutBlock1[] Get(string accno = default,string passwd = default,string cts_expcode = default,char cts_medocd = default)
		{
			using (XQt0441 instance = new XQt0441())
			{
				instance.SetFieldData(XQt0441InBlock.BlockName, XQt0441InBlock.F.accno, 0, accno); // char 11
				instance.SetFieldData(XQt0441InBlock.BlockName, XQt0441InBlock.F.passwd, 0, passwd); // char 8
				instance.SetFieldData(XQt0441InBlock.BlockName, XQt0441InBlock.F.cts_expcode, 0, cts_expcode); // char 8
				instance.SetFieldData(XQt0441InBlock.BlockName, XQt0441InBlock.F.cts_medocd, 0, cts_medocd.ToString()); // char 1

				if (instance.Request() < 0)
				{
					return null;
				}

				var outBlock = instance.GetBlock1s();
				return outBlock;
			}
		}

		public bool SetBlock(XQt0441InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "accno", 0, block.accno); // char 11
			_xaQuery.SetFieldData(block.GetBlockName(), "passwd", 0, block.passwd); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "cts_expcode", 0, block.cts_expcode); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "cts_medocd", 0, block.cts_medocd.ToString()); // char 1

			return true;
		}

		public XQt0441OutBlock GetBlock()
		{
			XQt0441OutBlock instance = XQt0441OutBlock.FromQuery(this);
			return instance;

		}

		public XQt0441OutBlock1[] GetBlock1s()
		{
			XQt0441OutBlock1[] instance = XQt0441OutBlock1.ListFromQuery(this);
			return instance;

		}


	}

}
