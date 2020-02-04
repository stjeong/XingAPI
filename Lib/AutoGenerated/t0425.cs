using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt0425InBlock : XingBlock
	{
		/// <summary>
		/// t0425InBlock
		/// </summary>
		public const string _blockName = "t0425InBlock";
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
		/// t0425InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t0425InBlock
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
		/// 종목번호
		/// </summary>
		[XAQueryFieldAttribute("종목번호")]
		public string expcode;
		/// <summary>
		/// 체결구분
		/// </summary>
		[XAQueryFieldAttribute("체결구분")]
		public char chegb;
		/// <summary>
		/// 매매구분
		/// </summary>
		[XAQueryFieldAttribute("매매구분")]
		public char medosu;
		/// <summary>
		/// 정렬순서
		/// </summary>
		[XAQueryFieldAttribute("정렬순서")]
		public char sortgb;
		/// <summary>
		/// 주문번호
		/// </summary>
		[XAQueryFieldAttribute("주문번호")]
		public string cts_ordno;

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
			/// 종목번호
			/// </summary>
			public const string expcode = "expcode";
			/// <summary>
			/// 체결구분
			/// </summary>
			public const string chegb = "chegb";
			/// <summary>
			/// 매매구분
			/// </summary>
			public const string medosu = "medosu";
			/// <summary>
			/// 정렬순서
			/// </summary>
			public const string sortgb = "sortgb";
			/// <summary>
			/// 주문번호
			/// </summary>
			public const string cts_ordno = "cts_ordno";
		}

		public static string[] AllFields = new string[]
		{
			F.accno,
			F.passwd,
			F.expcode,
			F.chegb,
			F.medosu,
			F.sortgb,
			F.cts_ordno,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["accno"] = new XAQueryFieldInfo("char", accno, accno, "계좌번호", (decimal)11);
			dict["passwd"] = new XAQueryFieldInfo("char", passwd, passwd, "비밀번호", (decimal)8);
			dict["expcode"] = new XAQueryFieldInfo("char", expcode, expcode, "종목번호", (decimal)12);
			dict["chegb"] = new XAQueryFieldInfo("char", chegb, chegb.ToString(), "체결구분", (decimal)1);
			dict["medosu"] = new XAQueryFieldInfo("char", medosu, medosu.ToString(), "매매구분", (decimal)1);
			dict["sortgb"] = new XAQueryFieldInfo("char", sortgb, sortgb.ToString(), "정렬순서", (decimal)1);
			dict["cts_ordno"] = new XAQueryFieldInfo("char", cts_ordno, cts_ordno, "주문번호", (decimal)10);

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

				case "expcode":
					this.expcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "chegb":
					this.chegb = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "medosu":
					this.medosu = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "sortgb":
					this.sortgb = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "cts_ordno":
					this.cts_ordno = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (accno?.Length > 11) return false; // char 11
			if (passwd?.Length > 8) return false; // char 8
			if (expcode?.Length > 12) return false; // char 12
			// chegb char 1
			// medosu char 1
			// sortgb char 1
			if (cts_ordno?.Length > 10) return false; // char 10

			return true;
		}
	}

	public partial class XQt0425OutBlock : XingBlock
	{
		/// <summary>
		/// t0425OutBlock
		/// </summary>
		public const string _blockName = "t0425OutBlock";
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
		/// t0425OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t0425OutBlock
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
		/// 총주문수량
		/// </summary>
		[XAQueryFieldAttribute("총주문수량")]
		public long tqty;
		/// <summary>
		/// 총체결수량
		/// </summary>
		[XAQueryFieldAttribute("총체결수량")]
		public long tcheqty;
		/// <summary>
		/// 총미체결수량
		/// </summary>
		[XAQueryFieldAttribute("총미체결수량")]
		public long tordrem;
		/// <summary>
		/// 추정수수료
		/// </summary>
		[XAQueryFieldAttribute("추정수수료")]
		public long cmss;
		/// <summary>
		/// 총주문금액
		/// </summary>
		[XAQueryFieldAttribute("총주문금액")]
		public long tamt;
		/// <summary>
		/// 총매도체결금액
		/// </summary>
		[XAQueryFieldAttribute("총매도체결금액")]
		public long tmdamt;
		/// <summary>
		/// 총매수체결금액
		/// </summary>
		[XAQueryFieldAttribute("총매수체결금액")]
		public long tmsamt;
		/// <summary>
		/// 추정제세금
		/// </summary>
		[XAQueryFieldAttribute("추정제세금")]
		public long tax;
		/// <summary>
		/// 주문번호
		/// </summary>
		[XAQueryFieldAttribute("주문번호")]
		public string cts_ordno;

		public static class F
		{
			/// <summary>
			/// 총주문수량
			/// </summary>
			public const string tqty = "tqty";
			/// <summary>
			/// 총체결수량
			/// </summary>
			public const string tcheqty = "tcheqty";
			/// <summary>
			/// 총미체결수량
			/// </summary>
			public const string tordrem = "tordrem";
			/// <summary>
			/// 추정수수료
			/// </summary>
			public const string cmss = "cmss";
			/// <summary>
			/// 총주문금액
			/// </summary>
			public const string tamt = "tamt";
			/// <summary>
			/// 총매도체결금액
			/// </summary>
			public const string tmdamt = "tmdamt";
			/// <summary>
			/// 총매수체결금액
			/// </summary>
			public const string tmsamt = "tmsamt";
			/// <summary>
			/// 추정제세금
			/// </summary>
			public const string tax = "tax";
			/// <summary>
			/// 주문번호
			/// </summary>
			public const string cts_ordno = "cts_ordno";
		}

		public static string[] AllFields = new string[]
		{
			F.tqty,
			F.tcheqty,
			F.tordrem,
			F.cmss,
			F.tamt,
			F.tmdamt,
			F.tmsamt,
			F.tax,
			F.cts_ordno,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["tqty"] = new XAQueryFieldInfo("long", tqty, tqty.ToString("d18"), "총주문수량", (decimal)18);
			dict["tcheqty"] = new XAQueryFieldInfo("long", tcheqty, tcheqty.ToString("d18"), "총체결수량", (decimal)18);
			dict["tordrem"] = new XAQueryFieldInfo("long", tordrem, tordrem.ToString("d18"), "총미체결수량", (decimal)18);
			dict["cmss"] = new XAQueryFieldInfo("long", cmss, cmss.ToString("d18"), "추정수수료", (decimal)18);
			dict["tamt"] = new XAQueryFieldInfo("long", tamt, tamt.ToString("d18"), "총주문금액", (decimal)18);
			dict["tmdamt"] = new XAQueryFieldInfo("long", tmdamt, tmdamt.ToString("d18"), "총매도체결금액", (decimal)18);
			dict["tmsamt"] = new XAQueryFieldInfo("long", tmsamt, tmsamt.ToString("d18"), "총매수체결금액", (decimal)18);
			dict["tax"] = new XAQueryFieldInfo("long", tax, tax.ToString("d18"), "추정제세금", (decimal)18);
			dict["cts_ordno"] = new XAQueryFieldInfo("char", cts_ordno, cts_ordno, "주문번호", (decimal)10);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "tqty":
					this.tqty = fieldInfo.FieldValue.ParseLong("tqty");
				break;

				case "tcheqty":
					this.tcheqty = fieldInfo.FieldValue.ParseLong("tcheqty");
				break;

				case "tordrem":
					this.tordrem = fieldInfo.FieldValue.ParseLong("tordrem");
				break;

				case "cmss":
					this.cmss = fieldInfo.FieldValue.ParseLong("cmss");
				break;

				case "tamt":
					this.tamt = fieldInfo.FieldValue.ParseLong("tamt");
				break;

				case "tmdamt":
					this.tmdamt = fieldInfo.FieldValue.ParseLong("tmdamt");
				break;

				case "tmsamt":
					this.tmsamt = fieldInfo.FieldValue.ParseLong("tmsamt");
				break;

				case "tax":
					this.tax = fieldInfo.FieldValue.ParseLong("tax");
				break;

				case "cts_ordno":
					this.cts_ordno = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt0425OutBlock FromQuery(XQt0425 query)
		{
			XQt0425OutBlock block = new XQt0425OutBlock();
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
				block.tqty = query.GetFieldData(block.GetBlockName(), "tqty", 0).ParseLong("tqty"); // long 18
				block.tcheqty = query.GetFieldData(block.GetBlockName(), "tcheqty", 0).ParseLong("tcheqty"); // long 18
				block.tordrem = query.GetFieldData(block.GetBlockName(), "tordrem", 0).ParseLong("tordrem"); // long 18
				block.cmss = query.GetFieldData(block.GetBlockName(), "cmss", 0).ParseLong("cmss"); // long 18
				block.tamt = query.GetFieldData(block.GetBlockName(), "tamt", 0).ParseLong("tamt"); // long 18
				block.tmdamt = query.GetFieldData(block.GetBlockName(), "tmdamt", 0).ParseLong("tmdamt"); // long 18
				block.tmsamt = query.GetFieldData(block.GetBlockName(), "tmsamt", 0).ParseLong("tmsamt"); // long 18
				block.tax = query.GetFieldData(block.GetBlockName(), "tax", 0).ParseLong("tax"); // long 18
				block.cts_ordno = query.GetFieldData(block.GetBlockName(), "cts_ordno", 0).TrimEnd('?'); // char 10

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (tqty.ToString().Length > 18) return false; // long 18
			if (tcheqty.ToString().Length > 18) return false; // long 18
			if (tordrem.ToString().Length > 18) return false; // long 18
			if (cmss.ToString().Length > 18) return false; // long 18
			if (tamt.ToString().Length > 18) return false; // long 18
			if (tmdamt.ToString().Length > 18) return false; // long 18
			if (tmsamt.ToString().Length > 18) return false; // long 18
			if (tax.ToString().Length > 18) return false; // long 18
			if (cts_ordno?.Length > 10) return false; // char 10

			return true;
		}
	}

	public partial class XQt0425OutBlock1 : XingBlock
	{
		/// <summary>
		/// t0425OutBlock1
		/// </summary>
		public const string _blockName = "t0425OutBlock1";
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
		/// t0425OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t0425OutBlock1
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
		/// 주문번호
		/// </summary>
		[XAQueryFieldAttribute("주문번호")]
		public long ordno;
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
		/// 주문수량
		/// </summary>
		[XAQueryFieldAttribute("주문수량")]
		public long qty;
		/// <summary>
		/// 주문가격
		/// </summary>
		[XAQueryFieldAttribute("주문가격")]
		public long price;
		/// <summary>
		/// 체결수량
		/// </summary>
		[XAQueryFieldAttribute("체결수량")]
		public long cheqty;
		/// <summary>
		/// 체결가격
		/// </summary>
		[XAQueryFieldAttribute("체결가격")]
		public long cheprice;
		/// <summary>
		/// 미체결잔량
		/// </summary>
		[XAQueryFieldAttribute("미체결잔량")]
		public long ordrem;
		/// <summary>
		/// 확인수량
		/// </summary>
		[XAQueryFieldAttribute("확인수량")]
		public long cfmqty;
		/// <summary>
		/// 상태
		/// </summary>
		[XAQueryFieldAttribute("상태")]
		public string status;
		/// <summary>
		/// 원주문번호
		/// </summary>
		[XAQueryFieldAttribute("원주문번호")]
		public long orgordno;
		/// <summary>
		/// 유형
		/// </summary>
		[XAQueryFieldAttribute("유형")]
		public string ordgb;
		/// <summary>
		/// 주문시간
		/// </summary>
		[XAQueryFieldAttribute("주문시간")]
		public string ordtime;
		/// <summary>
		/// 주문매체
		/// </summary>
		[XAQueryFieldAttribute("주문매체")]
		public string ordermtd;
		/// <summary>
		/// 처리순번
		/// </summary>
		[XAQueryFieldAttribute("처리순번")]
		public long sysprocseq;
		/// <summary>
		/// 호가유형
		/// </summary>
		[XAQueryFieldAttribute("호가유형")]
		public string hogagb;
		/// <summary>
		/// 현재가
		/// </summary>
		[XAQueryFieldAttribute("현재가")]
		public long price1;
		/// <summary>
		/// 주문구분
		/// </summary>
		[XAQueryFieldAttribute("주문구분")]
		public string orggb;
		/// <summary>
		/// 신용구분
		/// </summary>
		[XAQueryFieldAttribute("신용구분")]
		public string singb;
		/// <summary>
		/// 대출일자
		/// </summary>
		[XAQueryFieldAttribute("대출일자")]
		public string loandt;

		public static class F
		{
			/// <summary>
			/// 주문번호
			/// </summary>
			public const string ordno = "ordno";
			/// <summary>
			/// 종목번호
			/// </summary>
			public const string expcode = "expcode";
			/// <summary>
			/// 구분
			/// </summary>
			public const string medosu = "medosu";
			/// <summary>
			/// 주문수량
			/// </summary>
			public const string qty = "qty";
			/// <summary>
			/// 주문가격
			/// </summary>
			public const string price = "price";
			/// <summary>
			/// 체결수량
			/// </summary>
			public const string cheqty = "cheqty";
			/// <summary>
			/// 체결가격
			/// </summary>
			public const string cheprice = "cheprice";
			/// <summary>
			/// 미체결잔량
			/// </summary>
			public const string ordrem = "ordrem";
			/// <summary>
			/// 확인수량
			/// </summary>
			public const string cfmqty = "cfmqty";
			/// <summary>
			/// 상태
			/// </summary>
			public const string status = "status";
			/// <summary>
			/// 원주문번호
			/// </summary>
			public const string orgordno = "orgordno";
			/// <summary>
			/// 유형
			/// </summary>
			public const string ordgb = "ordgb";
			/// <summary>
			/// 주문시간
			/// </summary>
			public const string ordtime = "ordtime";
			/// <summary>
			/// 주문매체
			/// </summary>
			public const string ordermtd = "ordermtd";
			/// <summary>
			/// 처리순번
			/// </summary>
			public const string sysprocseq = "sysprocseq";
			/// <summary>
			/// 호가유형
			/// </summary>
			public const string hogagb = "hogagb";
			/// <summary>
			/// 현재가
			/// </summary>
			public const string price1 = "price1";
			/// <summary>
			/// 주문구분
			/// </summary>
			public const string orggb = "orggb";
			/// <summary>
			/// 신용구분
			/// </summary>
			public const string singb = "singb";
			/// <summary>
			/// 대출일자
			/// </summary>
			public const string loandt = "loandt";
		}

		public static string[] AllFields = new string[]
		{
			F.ordno,
			F.expcode,
			F.medosu,
			F.qty,
			F.price,
			F.cheqty,
			F.cheprice,
			F.ordrem,
			F.cfmqty,
			F.status,
			F.orgordno,
			F.ordgb,
			F.ordtime,
			F.ordermtd,
			F.sysprocseq,
			F.hogagb,
			F.price1,
			F.orggb,
			F.singb,
			F.loandt,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["ordno"] = new XAQueryFieldInfo("long", ordno, ordno.ToString("d10"), "주문번호", (decimal)10);
			dict["expcode"] = new XAQueryFieldInfo("char", expcode, expcode, "종목번호", (decimal)12);
			dict["medosu"] = new XAQueryFieldInfo("char", medosu, medosu, "구분", (decimal)10);
			dict["qty"] = new XAQueryFieldInfo("long", qty, qty.ToString("d9"), "주문수량", (decimal)9);
			dict["price"] = new XAQueryFieldInfo("long", price, price.ToString("d9"), "주문가격", (decimal)9);
			dict["cheqty"] = new XAQueryFieldInfo("long", cheqty, cheqty.ToString("d9"), "체결수량", (decimal)9);
			dict["cheprice"] = new XAQueryFieldInfo("long", cheprice, cheprice.ToString("d9"), "체결가격", (decimal)9);
			dict["ordrem"] = new XAQueryFieldInfo("long", ordrem, ordrem.ToString("d9"), "미체결잔량", (decimal)9);
			dict["cfmqty"] = new XAQueryFieldInfo("long", cfmqty, cfmqty.ToString("d9"), "확인수량", (decimal)9);
			dict["status"] = new XAQueryFieldInfo("char", status, status, "상태", (decimal)10);
			dict["orgordno"] = new XAQueryFieldInfo("long", orgordno, orgordno.ToString("d10"), "원주문번호", (decimal)10);
			dict["ordgb"] = new XAQueryFieldInfo("char", ordgb, ordgb, "유형", (decimal)20);
			dict["ordtime"] = new XAQueryFieldInfo("char", ordtime, ordtime, "주문시간", (decimal)8);
			dict["ordermtd"] = new XAQueryFieldInfo("char", ordermtd, ordermtd, "주문매체", (decimal)10);
			dict["sysprocseq"] = new XAQueryFieldInfo("long", sysprocseq, sysprocseq.ToString("d10"), "처리순번", (decimal)10);
			dict["hogagb"] = new XAQueryFieldInfo("char", hogagb, hogagb, "호가유형", (decimal)2);
			dict["price1"] = new XAQueryFieldInfo("long", price1, price1.ToString("d8"), "현재가", (decimal)8);
			dict["orggb"] = new XAQueryFieldInfo("char", orggb, orggb, "주문구분", (decimal)2);
			dict["singb"] = new XAQueryFieldInfo("char", singb, singb, "신용구분", (decimal)2);
			dict["loandt"] = new XAQueryFieldInfo("char", loandt, loandt, "대출일자", (decimal)8);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "ordno":
					this.ordno = fieldInfo.FieldValue.ParseLong("ordno");
				break;

				case "expcode":
					this.expcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "medosu":
					this.medosu = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "qty":
					this.qty = fieldInfo.FieldValue.ParseLong("qty");
				break;

				case "price":
					this.price = fieldInfo.FieldValue.ParseLong("price");
				break;

				case "cheqty":
					this.cheqty = fieldInfo.FieldValue.ParseLong("cheqty");
				break;

				case "cheprice":
					this.cheprice = fieldInfo.FieldValue.ParseLong("cheprice");
				break;

				case "ordrem":
					this.ordrem = fieldInfo.FieldValue.ParseLong("ordrem");
				break;

				case "cfmqty":
					this.cfmqty = fieldInfo.FieldValue.ParseLong("cfmqty");
				break;

				case "status":
					this.status = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "orgordno":
					this.orgordno = fieldInfo.FieldValue.ParseLong("orgordno");
				break;

				case "ordgb":
					this.ordgb = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ordtime":
					this.ordtime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ordermtd":
					this.ordermtd = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "sysprocseq":
					this.sysprocseq = fieldInfo.FieldValue.ParseLong("sysprocseq");
				break;

				case "hogagb":
					this.hogagb = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "price1":
					this.price1 = fieldInfo.FieldValue.ParseLong("price1");
				break;

				case "orggb":
					this.orggb = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "singb":
					this.singb = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "loandt":
					this.loandt = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt0425OutBlock1[] ListFromQuery(XQt0425 query)
		{
			int count = query.GetBlockCount(XQt0425OutBlock1.BlockName);
			List<XQt0425OutBlock1> list = new List<XQt0425OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt0425OutBlock1 block = new XQt0425OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.ordno = query.GetFieldData(block.GetBlockName(), "ordno", i).ParseLong("ordno"); // long 10
					block.expcode = query.GetFieldData(block.GetBlockName(), "expcode", i).TrimEnd('?'); // char 12
					block.medosu = query.GetFieldData(block.GetBlockName(), "medosu", i).TrimEnd('?'); // char 10
					block.qty = query.GetFieldData(block.GetBlockName(), "qty", i).ParseLong("qty"); // long 9
					block.price = query.GetFieldData(block.GetBlockName(), "price", i).ParseLong("price"); // long 9
					block.cheqty = query.GetFieldData(block.GetBlockName(), "cheqty", i).ParseLong("cheqty"); // long 9
					block.cheprice = query.GetFieldData(block.GetBlockName(), "cheprice", i).ParseLong("cheprice"); // long 9
					block.ordrem = query.GetFieldData(block.GetBlockName(), "ordrem", i).ParseLong("ordrem"); // long 9
					block.cfmqty = query.GetFieldData(block.GetBlockName(), "cfmqty", i).ParseLong("cfmqty"); // long 9
					block.status = query.GetFieldData(block.GetBlockName(), "status", i).TrimEnd('?'); // char 10
					block.orgordno = query.GetFieldData(block.GetBlockName(), "orgordno", i).ParseLong("orgordno"); // long 10
					block.ordgb = query.GetFieldData(block.GetBlockName(), "ordgb", i).TrimEnd('?'); // char 20
					block.ordtime = query.GetFieldData(block.GetBlockName(), "ordtime", i).TrimEnd('?'); // char 8
					block.ordermtd = query.GetFieldData(block.GetBlockName(), "ordermtd", i).TrimEnd('?'); // char 10
					block.sysprocseq = query.GetFieldData(block.GetBlockName(), "sysprocseq", i).ParseLong("sysprocseq"); // long 10
					block.hogagb = query.GetFieldData(block.GetBlockName(), "hogagb", i).TrimEnd('?'); // char 2
					block.price1 = query.GetFieldData(block.GetBlockName(), "price1", i).ParseLong("price1"); // long 8
					block.orggb = query.GetFieldData(block.GetBlockName(), "orggb", i).TrimEnd('?'); // char 2
					block.singb = query.GetFieldData(block.GetBlockName(), "singb", i).TrimEnd('?'); // char 2
					block.loandt = query.GetFieldData(block.GetBlockName(), "loandt", i).TrimEnd('?'); // char 8

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
			if (ordno.ToString().Length > 10) return false; // long 10
			if (expcode?.Length > 12) return false; // char 12
			if (medosu?.Length > 10) return false; // char 10
			if (qty.ToString().Length > 9) return false; // long 9
			if (price.ToString().Length > 9) return false; // long 9
			if (cheqty.ToString().Length > 9) return false; // long 9
			if (cheprice.ToString().Length > 9) return false; // long 9
			if (ordrem.ToString().Length > 9) return false; // long 9
			if (cfmqty.ToString().Length > 9) return false; // long 9
			if (status?.Length > 10) return false; // char 10
			if (orgordno.ToString().Length > 10) return false; // long 10
			if (ordgb?.Length > 20) return false; // char 20
			if (ordtime?.Length > 8) return false; // char 8
			if (ordermtd?.Length > 10) return false; // char 10
			if (sysprocseq.ToString().Length > 10) return false; // long 10
			if (hogagb?.Length > 2) return false; // char 2
			if (price1.ToString().Length > 8) return false; // long 8
			if (orggb?.Length > 2) return false; // char 2
			if (singb?.Length > 2) return false; // char 2
			if (loandt?.Length > 8) return false; // char 8

			return true;
		}
	}

	public partial class XQt0425 : XingQuery
	{
		/// <summary>
		/// t0425
		/// </summary>
		public const string _typeName = "t0425";
		/// <summary>
		/// 주식체결/미체결(t0425)
		/// </summary>
		public const string _typeDesc = "주식체결/미체결(t0425)";
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
		/// t0425
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 주식체결/미체결(t0425)
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

		public XQt0425() : base("t0425") { }


		public bool SetFields(XQt0425InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "accno", 0, block.accno); // char 11
			_xaQuery.SetFieldData(block.GetBlockName(), "passwd", 0, block.passwd); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "expcode", 0, block.expcode); // char 12
			_xaQuery.SetFieldData(block.GetBlockName(), "chegb", 0, block.chegb.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "medosu", 0, block.medosu.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "sortgb", 0, block.sortgb.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "cts_ordno", 0, block.cts_ordno); // char 10

			return true;
		}

		public XQt0425OutBlock GetBlock()
		{
			XQt0425OutBlock instance = XQt0425OutBlock.FromQuery(this);
			return instance;

		}

		public XQt0425OutBlock1[] GetBlock1s()
		{
			XQt0425OutBlock1[] instance = XQt0425OutBlock1.ListFromQuery(this);
			return instance;

		}


	}

}
