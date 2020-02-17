using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt0424InBlock : XingBlock
	{
		/// <summary>
		/// t0424InBlock
		/// </summary>
		public const string _blockName = "t0424InBlock";
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
		/// t0424InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t0424InBlock
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
		[XAQueryFieldAttribute("accno", "계좌번호", "char", "11")]
		public string accno;
		/// <summary>
		/// 비밀번호
		/// </summary>
		[XAQueryFieldAttribute("passwd", "비밀번호", "char", "8")]
		public string passwd;
		/// <summary>
		/// 단가구분
		/// </summary>
		[XAQueryFieldAttribute("prcgb", "단가구분", "char", "1")]
		public char prcgb;
		/// <summary>
		/// 체결구분
		/// </summary>
		[XAQueryFieldAttribute("chegb", "체결구분", "char", "1")]
		public char chegb;
		/// <summary>
		/// 단일가구분
		/// </summary>
		[XAQueryFieldAttribute("dangb", "단일가구분", "char", "1")]
		public char dangb;
		/// <summary>
		/// 제비용포함여부
		/// </summary>
		[XAQueryFieldAttribute("charge", "제비용포함여부", "char", "1")]
		public char charge;
		/// <summary>
		/// CTS_종목번호
		/// </summary>
		[XAQueryFieldAttribute("cts_expcode", "CTS_종목번호", "char", "22")]
		public string cts_expcode;

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
			/// 단가구분
			/// </summary>
			public const string prcgb = "prcgb";
			/// <summary>
			/// 체결구분
			/// </summary>
			public const string chegb = "chegb";
			/// <summary>
			/// 단일가구분
			/// </summary>
			public const string dangb = "dangb";
			/// <summary>
			/// 제비용포함여부
			/// </summary>
			public const string charge = "charge";
			/// <summary>
			/// CTS_종목번호
			/// </summary>
			public const string cts_expcode = "cts_expcode";
		}

		public static string[] AllFields = new string[]
		{
			F.accno,
			F.passwd,
			F.prcgb,
			F.chegb,
			F.dangb,
			F.charge,
			F.cts_expcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["accno"] = new XAQueryFieldInfo("char", accno, accno, "계좌번호", (decimal)11);
			dict["passwd"] = new XAQueryFieldInfo("char", passwd, passwd, "비밀번호", (decimal)8);
			dict["prcgb"] = new XAQueryFieldInfo("char", prcgb, prcgb.ToString(), "단가구분", (decimal)1);
			dict["chegb"] = new XAQueryFieldInfo("char", chegb, chegb.ToString(), "체결구분", (decimal)1);
			dict["dangb"] = new XAQueryFieldInfo("char", dangb, dangb.ToString(), "단일가구분", (decimal)1);
			dict["charge"] = new XAQueryFieldInfo("char", charge, charge.ToString(), "제비용포함여부", (decimal)1);
			dict["cts_expcode"] = new XAQueryFieldInfo("char", cts_expcode, cts_expcode, "CTS_종목번호", (decimal)22);

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

				case "prcgb":
					this.prcgb = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "chegb":
					this.chegb = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "dangb":
					this.dangb = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "charge":
					this.charge = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "cts_expcode":
					this.cts_expcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (accno?.Length > 11) return false; // char 11
			if (passwd?.Length > 8) return false; // char 8
			// prcgb char 1
			// chegb char 1
			// dangb char 1
			// charge char 1
			if (cts_expcode?.Length > 22) return false; // char 22

			return true;
		}
	}

	public partial class XQt0424OutBlock : XingBlock
	{
		/// <summary>
		/// t0424OutBlock
		/// </summary>
		public const string _blockName = "t0424OutBlock";
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
		/// t0424OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t0424OutBlock
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
		/// 추정순자산
		/// </summary>
		[XAQueryFieldAttribute("sunamt", "추정순자산", "long", "18")]
		public long sunamt;
		/// <summary>
		/// 실현손익
		/// </summary>
		[XAQueryFieldAttribute("dtsunik", "실현손익", "long", "18")]
		public long dtsunik;
		/// <summary>
		/// 매입금액
		/// </summary>
		[XAQueryFieldAttribute("mamt", "매입금액", "long", "18")]
		public long mamt;
		/// <summary>
		/// 추정D2예수금
		/// </summary>
		[XAQueryFieldAttribute("sunamt1", "추정D2예수금", "long", "18")]
		public long sunamt1;
		/// <summary>
		/// CTS_종목번호
		/// </summary>
		[XAQueryFieldAttribute("cts_expcode", "CTS_종목번호", "char", "22")]
		public string cts_expcode;
		/// <summary>
		/// 평가금액
		/// </summary>
		[XAQueryFieldAttribute("tappamt", "평가금액", "long", "18")]
		public long tappamt;
		/// <summary>
		/// 평가손익
		/// </summary>
		[XAQueryFieldAttribute("tdtsunik", "평가손익", "long", "18")]
		public long tdtsunik;

		public static class F
		{
			/// <summary>
			/// 추정순자산
			/// </summary>
			public const string sunamt = "sunamt";
			/// <summary>
			/// 실현손익
			/// </summary>
			public const string dtsunik = "dtsunik";
			/// <summary>
			/// 매입금액
			/// </summary>
			public const string mamt = "mamt";
			/// <summary>
			/// 추정D2예수금
			/// </summary>
			public const string sunamt1 = "sunamt1";
			/// <summary>
			/// CTS_종목번호
			/// </summary>
			public const string cts_expcode = "cts_expcode";
			/// <summary>
			/// 평가금액
			/// </summary>
			public const string tappamt = "tappamt";
			/// <summary>
			/// 평가손익
			/// </summary>
			public const string tdtsunik = "tdtsunik";
		}

		public static string[] AllFields = new string[]
		{
			F.sunamt,
			F.dtsunik,
			F.mamt,
			F.sunamt1,
			F.cts_expcode,
			F.tappamt,
			F.tdtsunik,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["sunamt"] = new XAQueryFieldInfo("long", sunamt, sunamt.ToString("d18"), "추정순자산", (decimal)18);
			dict["dtsunik"] = new XAQueryFieldInfo("long", dtsunik, dtsunik.ToString("d18"), "실현손익", (decimal)18);
			dict["mamt"] = new XAQueryFieldInfo("long", mamt, mamt.ToString("d18"), "매입금액", (decimal)18);
			dict["sunamt1"] = new XAQueryFieldInfo("long", sunamt1, sunamt1.ToString("d18"), "추정D2예수금", (decimal)18);
			dict["cts_expcode"] = new XAQueryFieldInfo("char", cts_expcode, cts_expcode, "CTS_종목번호", (decimal)22);
			dict["tappamt"] = new XAQueryFieldInfo("long", tappamt, tappamt.ToString("d18"), "평가금액", (decimal)18);
			dict["tdtsunik"] = new XAQueryFieldInfo("long", tdtsunik, tdtsunik.ToString("d18"), "평가손익", (decimal)18);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "sunamt":
					this.sunamt = fieldInfo.FieldValue.ParseLong("sunamt");
				break;

				case "dtsunik":
					this.dtsunik = fieldInfo.FieldValue.ParseLong("dtsunik");
				break;

				case "mamt":
					this.mamt = fieldInfo.FieldValue.ParseLong("mamt");
				break;

				case "sunamt1":
					this.sunamt1 = fieldInfo.FieldValue.ParseLong("sunamt1");
				break;

				case "cts_expcode":
					this.cts_expcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "tappamt":
					this.tappamt = fieldInfo.FieldValue.ParseLong("tappamt");
				break;

				case "tdtsunik":
					this.tdtsunik = fieldInfo.FieldValue.ParseLong("tdtsunik");
				break;


			}
		}

		public static XQt0424OutBlock FromQuery(XQt0424 query)
		{
			XQt0424OutBlock block = new XQt0424OutBlock();
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
				block.sunamt = query.GetFieldData(block.GetBlockName(), "sunamt", 0).ParseLong("sunamt"); // long 18
				block.dtsunik = query.GetFieldData(block.GetBlockName(), "dtsunik", 0).ParseLong("dtsunik"); // long 18
				block.mamt = query.GetFieldData(block.GetBlockName(), "mamt", 0).ParseLong("mamt"); // long 18
				block.sunamt1 = query.GetFieldData(block.GetBlockName(), "sunamt1", 0).ParseLong("sunamt1"); // long 18
				block.cts_expcode = query.GetFieldData(block.GetBlockName(), "cts_expcode", 0).TrimEnd('?'); // char 22
				block.tappamt = query.GetFieldData(block.GetBlockName(), "tappamt", 0).ParseLong("tappamt"); // long 18
				block.tdtsunik = query.GetFieldData(block.GetBlockName(), "tdtsunik", 0).ParseLong("tdtsunik"); // long 18

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (sunamt.ToString().Length > 18) return false; // long 18
			if (dtsunik.ToString().Length > 18) return false; // long 18
			if (mamt.ToString().Length > 18) return false; // long 18
			if (sunamt1.ToString().Length > 18) return false; // long 18
			if (cts_expcode?.Length > 22) return false; // char 22
			if (tappamt.ToString().Length > 18) return false; // long 18
			if (tdtsunik.ToString().Length > 18) return false; // long 18

			return true;
		}
	}

	public partial class XQt0424OutBlock1 : XingBlock
	{
		/// <summary>
		/// t0424OutBlock1
		/// </summary>
		public const string _blockName = "t0424OutBlock1";
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
		/// t0424OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t0424OutBlock1
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
		[XAQueryFieldAttribute("expcode", "종목번호", "char", "12")]
		public string expcode;
		/// <summary>
		/// 잔고구분
		/// </summary>
		[XAQueryFieldAttribute("jangb", "잔고구분", "char", "10")]
		public string jangb;
		/// <summary>
		/// 잔고수량
		/// </summary>
		[XAQueryFieldAttribute("janqty", "잔고수량", "long", "18")]
		public long janqty;
		/// <summary>
		/// 매도가능수량
		/// </summary>
		[XAQueryFieldAttribute("mdposqt", "매도가능수량", "long", "18")]
		public long mdposqt;
		/// <summary>
		/// 평균단가
		/// </summary>
		[XAQueryFieldAttribute("pamt", "평균단가", "long", "18")]
		public long pamt;
		/// <summary>
		/// 매입금액
		/// </summary>
		[XAQueryFieldAttribute("mamt", "매입금액", "long", "18")]
		public long mamt;
		/// <summary>
		/// 대출금액
		/// </summary>
		[XAQueryFieldAttribute("sinamt", "대출금액", "long", "18")]
		public long sinamt;
		/// <summary>
		/// 만기일자
		/// </summary>
		[XAQueryFieldAttribute("lastdt", "만기일자", "char", "8")]
		public string lastdt;
		/// <summary>
		/// 당일매수금액
		/// </summary>
		[XAQueryFieldAttribute("msat", "당일매수금액", "long", "18")]
		public long msat;
		/// <summary>
		/// 당일매수단가
		/// </summary>
		[XAQueryFieldAttribute("mpms", "당일매수단가", "long", "18")]
		public long mpms;
		/// <summary>
		/// 당일매도금액
		/// </summary>
		[XAQueryFieldAttribute("mdat", "당일매도금액", "long", "18")]
		public long mdat;
		/// <summary>
		/// 당일매도단가
		/// </summary>
		[XAQueryFieldAttribute("mpmd", "당일매도단가", "long", "18")]
		public long mpmd;
		/// <summary>
		/// 전일매수금액
		/// </summary>
		[XAQueryFieldAttribute("jsat", "전일매수금액", "long", "18")]
		public long jsat;
		/// <summary>
		/// 전일매수단가
		/// </summary>
		[XAQueryFieldAttribute("jpms", "전일매수단가", "long", "18")]
		public long jpms;
		/// <summary>
		/// 전일매도금액
		/// </summary>
		[XAQueryFieldAttribute("jdat", "전일매도금액", "long", "18")]
		public long jdat;
		/// <summary>
		/// 전일매도단가
		/// </summary>
		[XAQueryFieldAttribute("jpmd", "전일매도단가", "long", "18")]
		public long jpmd;
		/// <summary>
		/// 처리순번
		/// </summary>
		[XAQueryFieldAttribute("sysprocseq", "처리순번", "long", "10")]
		public long sysprocseq;
		/// <summary>
		/// 대출일자
		/// </summary>
		[XAQueryFieldAttribute("loandt", "대출일자", "char", "8")]
		public string loandt;
		/// <summary>
		/// 종목명
		/// </summary>
		[XAQueryFieldAttribute("hname", "종목명", "char", "20")]
		public string hname;
		/// <summary>
		/// 시장구분
		/// </summary>
		[XAQueryFieldAttribute("marketgb", "시장구분", "char", "1")]
		public char marketgb;
		/// <summary>
		/// 종목구분
		/// </summary>
		[XAQueryFieldAttribute("jonggb", "종목구분", "char", "1")]
		public char jonggb;
		/// <summary>
		/// 보유비중
		/// </summary>
		[XAQueryFieldAttribute("janrt", "보유비중", "float", "10.2")]
		public float janrt;
		/// <summary>
		/// 현재가
		/// </summary>
		[XAQueryFieldAttribute("price", "현재가", "long", "8")]
		public long price;
		/// <summary>
		/// 평가금액
		/// </summary>
		[XAQueryFieldAttribute("appamt", "평가금액", "long", "18")]
		public long appamt;
		/// <summary>
		/// 평가손익
		/// </summary>
		[XAQueryFieldAttribute("dtsunik", "평가손익", "long", "18")]
		public long dtsunik;
		/// <summary>
		/// 수익율
		/// </summary>
		[XAQueryFieldAttribute("sunikrt", "수익율", "float", "10.2")]
		public float sunikrt;
		/// <summary>
		/// 수수료
		/// </summary>
		[XAQueryFieldAttribute("fee", "수수료", "long", "10")]
		public long fee;
		/// <summary>
		/// 제세금
		/// </summary>
		[XAQueryFieldAttribute("tax", "제세금", "long", "10")]
		public long tax;
		/// <summary>
		/// 신용이자
		/// </summary>
		[XAQueryFieldAttribute("sininter", "신용이자", "long", "10")]
		public long sininter;

		public static class F
		{
			/// <summary>
			/// 종목번호
			/// </summary>
			public const string expcode = "expcode";
			/// <summary>
			/// 잔고구분
			/// </summary>
			public const string jangb = "jangb";
			/// <summary>
			/// 잔고수량
			/// </summary>
			public const string janqty = "janqty";
			/// <summary>
			/// 매도가능수량
			/// </summary>
			public const string mdposqt = "mdposqt";
			/// <summary>
			/// 평균단가
			/// </summary>
			public const string pamt = "pamt";
			/// <summary>
			/// 매입금액
			/// </summary>
			public const string mamt = "mamt";
			/// <summary>
			/// 대출금액
			/// </summary>
			public const string sinamt = "sinamt";
			/// <summary>
			/// 만기일자
			/// </summary>
			public const string lastdt = "lastdt";
			/// <summary>
			/// 당일매수금액
			/// </summary>
			public const string msat = "msat";
			/// <summary>
			/// 당일매수단가
			/// </summary>
			public const string mpms = "mpms";
			/// <summary>
			/// 당일매도금액
			/// </summary>
			public const string mdat = "mdat";
			/// <summary>
			/// 당일매도단가
			/// </summary>
			public const string mpmd = "mpmd";
			/// <summary>
			/// 전일매수금액
			/// </summary>
			public const string jsat = "jsat";
			/// <summary>
			/// 전일매수단가
			/// </summary>
			public const string jpms = "jpms";
			/// <summary>
			/// 전일매도금액
			/// </summary>
			public const string jdat = "jdat";
			/// <summary>
			/// 전일매도단가
			/// </summary>
			public const string jpmd = "jpmd";
			/// <summary>
			/// 처리순번
			/// </summary>
			public const string sysprocseq = "sysprocseq";
			/// <summary>
			/// 대출일자
			/// </summary>
			public const string loandt = "loandt";
			/// <summary>
			/// 종목명
			/// </summary>
			public const string hname = "hname";
			/// <summary>
			/// 시장구분
			/// </summary>
			public const string marketgb = "marketgb";
			/// <summary>
			/// 종목구분
			/// </summary>
			public const string jonggb = "jonggb";
			/// <summary>
			/// 보유비중
			/// </summary>
			public const string janrt = "janrt";
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
			public const string dtsunik = "dtsunik";
			/// <summary>
			/// 수익율
			/// </summary>
			public const string sunikrt = "sunikrt";
			/// <summary>
			/// 수수료
			/// </summary>
			public const string fee = "fee";
			/// <summary>
			/// 제세금
			/// </summary>
			public const string tax = "tax";
			/// <summary>
			/// 신용이자
			/// </summary>
			public const string sininter = "sininter";
		}

		public static string[] AllFields = new string[]
		{
			F.expcode,
			F.jangb,
			F.janqty,
			F.mdposqt,
			F.pamt,
			F.mamt,
			F.sinamt,
			F.lastdt,
			F.msat,
			F.mpms,
			F.mdat,
			F.mpmd,
			F.jsat,
			F.jpms,
			F.jdat,
			F.jpmd,
			F.sysprocseq,
			F.loandt,
			F.hname,
			F.marketgb,
			F.jonggb,
			F.janrt,
			F.price,
			F.appamt,
			F.dtsunik,
			F.sunikrt,
			F.fee,
			F.tax,
			F.sininter,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["expcode"] = new XAQueryFieldInfo("char", expcode, expcode, "종목번호", (decimal)12);
			dict["jangb"] = new XAQueryFieldInfo("char", jangb, jangb, "잔고구분", (decimal)10);
			dict["janqty"] = new XAQueryFieldInfo("long", janqty, janqty.ToString("d18"), "잔고수량", (decimal)18);
			dict["mdposqt"] = new XAQueryFieldInfo("long", mdposqt, mdposqt.ToString("d18"), "매도가능수량", (decimal)18);
			dict["pamt"] = new XAQueryFieldInfo("long", pamt, pamt.ToString("d18"), "평균단가", (decimal)18);
			dict["mamt"] = new XAQueryFieldInfo("long", mamt, mamt.ToString("d18"), "매입금액", (decimal)18);
			dict["sinamt"] = new XAQueryFieldInfo("long", sinamt, sinamt.ToString("d18"), "대출금액", (decimal)18);
			dict["lastdt"] = new XAQueryFieldInfo("char", lastdt, lastdt, "만기일자", (decimal)8);
			dict["msat"] = new XAQueryFieldInfo("long", msat, msat.ToString("d18"), "당일매수금액", (decimal)18);
			dict["mpms"] = new XAQueryFieldInfo("long", mpms, mpms.ToString("d18"), "당일매수단가", (decimal)18);
			dict["mdat"] = new XAQueryFieldInfo("long", mdat, mdat.ToString("d18"), "당일매도금액", (decimal)18);
			dict["mpmd"] = new XAQueryFieldInfo("long", mpmd, mpmd.ToString("d18"), "당일매도단가", (decimal)18);
			dict["jsat"] = new XAQueryFieldInfo("long", jsat, jsat.ToString("d18"), "전일매수금액", (decimal)18);
			dict["jpms"] = new XAQueryFieldInfo("long", jpms, jpms.ToString("d18"), "전일매수단가", (decimal)18);
			dict["jdat"] = new XAQueryFieldInfo("long", jdat, jdat.ToString("d18"), "전일매도금액", (decimal)18);
			dict["jpmd"] = new XAQueryFieldInfo("long", jpmd, jpmd.ToString("d18"), "전일매도단가", (decimal)18);
			dict["sysprocseq"] = new XAQueryFieldInfo("long", sysprocseq, sysprocseq.ToString("d10"), "처리순번", (decimal)10);
			dict["loandt"] = new XAQueryFieldInfo("char", loandt, loandt, "대출일자", (decimal)8);
			dict["hname"] = new XAQueryFieldInfo("char", hname, hname, "종목명", (decimal)20);
			dict["marketgb"] = new XAQueryFieldInfo("char", marketgb, marketgb.ToString(), "시장구분", (decimal)1);
			dict["jonggb"] = new XAQueryFieldInfo("char", jonggb, jonggb.ToString(), "종목구분", (decimal)1);
			dict["janrt"] = new XAQueryFieldInfo("float", janrt, janrt.ToString("0000000000.00"), "보유비중", (decimal)10.2);
			dict["price"] = new XAQueryFieldInfo("long", price, price.ToString("d8"), "현재가", (decimal)8);
			dict["appamt"] = new XAQueryFieldInfo("long", appamt, appamt.ToString("d18"), "평가금액", (decimal)18);
			dict["dtsunik"] = new XAQueryFieldInfo("long", dtsunik, dtsunik.ToString("d18"), "평가손익", (decimal)18);
			dict["sunikrt"] = new XAQueryFieldInfo("float", sunikrt, sunikrt.ToString("0000000000.00"), "수익율", (decimal)10.2);
			dict["fee"] = new XAQueryFieldInfo("long", fee, fee.ToString("d10"), "수수료", (decimal)10);
			dict["tax"] = new XAQueryFieldInfo("long", tax, tax.ToString("d10"), "제세금", (decimal)10);
			dict["sininter"] = new XAQueryFieldInfo("long", sininter, sininter.ToString("d10"), "신용이자", (decimal)10);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "expcode":
					this.expcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "jangb":
					this.jangb = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "janqty":
					this.janqty = fieldInfo.FieldValue.ParseLong("janqty");
				break;

				case "mdposqt":
					this.mdposqt = fieldInfo.FieldValue.ParseLong("mdposqt");
				break;

				case "pamt":
					this.pamt = fieldInfo.FieldValue.ParseLong("pamt");
				break;

				case "mamt":
					this.mamt = fieldInfo.FieldValue.ParseLong("mamt");
				break;

				case "sinamt":
					this.sinamt = fieldInfo.FieldValue.ParseLong("sinamt");
				break;

				case "lastdt":
					this.lastdt = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "msat":
					this.msat = fieldInfo.FieldValue.ParseLong("msat");
				break;

				case "mpms":
					this.mpms = fieldInfo.FieldValue.ParseLong("mpms");
				break;

				case "mdat":
					this.mdat = fieldInfo.FieldValue.ParseLong("mdat");
				break;

				case "mpmd":
					this.mpmd = fieldInfo.FieldValue.ParseLong("mpmd");
				break;

				case "jsat":
					this.jsat = fieldInfo.FieldValue.ParseLong("jsat");
				break;

				case "jpms":
					this.jpms = fieldInfo.FieldValue.ParseLong("jpms");
				break;

				case "jdat":
					this.jdat = fieldInfo.FieldValue.ParseLong("jdat");
				break;

				case "jpmd":
					this.jpmd = fieldInfo.FieldValue.ParseLong("jpmd");
				break;

				case "sysprocseq":
					this.sysprocseq = fieldInfo.FieldValue.ParseLong("sysprocseq");
				break;

				case "loandt":
					this.loandt = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "hname":
					this.hname = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "marketgb":
					this.marketgb = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "jonggb":
					this.jonggb = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "janrt":
					this.janrt = fieldInfo.FieldValue.ParseFloat("janrt");
				break;

				case "price":
					this.price = fieldInfo.FieldValue.ParseLong("price");
				break;

				case "appamt":
					this.appamt = fieldInfo.FieldValue.ParseLong("appamt");
				break;

				case "dtsunik":
					this.dtsunik = fieldInfo.FieldValue.ParseLong("dtsunik");
				break;

				case "sunikrt":
					this.sunikrt = fieldInfo.FieldValue.ParseFloat("sunikrt");
				break;

				case "fee":
					this.fee = fieldInfo.FieldValue.ParseLong("fee");
				break;

				case "tax":
					this.tax = fieldInfo.FieldValue.ParseLong("tax");
				break;

				case "sininter":
					this.sininter = fieldInfo.FieldValue.ParseLong("sininter");
				break;


			}
		}

		public static XQt0424OutBlock1[] ListFromQuery(XQt0424 query)
		{
			int count = query.GetBlockCount(XQt0424OutBlock1.BlockName);
			List<XQt0424OutBlock1> list = new List<XQt0424OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt0424OutBlock1 block = new XQt0424OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.expcode = query.GetFieldData(block.GetBlockName(), "expcode", i).TrimEnd('?'); // char 12
					block.jangb = query.GetFieldData(block.GetBlockName(), "jangb", i).TrimEnd('?'); // char 10
					block.janqty = query.GetFieldData(block.GetBlockName(), "janqty", i).ParseLong("janqty"); // long 18
					block.mdposqt = query.GetFieldData(block.GetBlockName(), "mdposqt", i).ParseLong("mdposqt"); // long 18
					block.pamt = query.GetFieldData(block.GetBlockName(), "pamt", i).ParseLong("pamt"); // long 18
					block.mamt = query.GetFieldData(block.GetBlockName(), "mamt", i).ParseLong("mamt"); // long 18
					block.sinamt = query.GetFieldData(block.GetBlockName(), "sinamt", i).ParseLong("sinamt"); // long 18
					block.lastdt = query.GetFieldData(block.GetBlockName(), "lastdt", i).TrimEnd('?'); // char 8
					block.msat = query.GetFieldData(block.GetBlockName(), "msat", i).ParseLong("msat"); // long 18
					block.mpms = query.GetFieldData(block.GetBlockName(), "mpms", i).ParseLong("mpms"); // long 18
					block.mdat = query.GetFieldData(block.GetBlockName(), "mdat", i).ParseLong("mdat"); // long 18
					block.mpmd = query.GetFieldData(block.GetBlockName(), "mpmd", i).ParseLong("mpmd"); // long 18
					block.jsat = query.GetFieldData(block.GetBlockName(), "jsat", i).ParseLong("jsat"); // long 18
					block.jpms = query.GetFieldData(block.GetBlockName(), "jpms", i).ParseLong("jpms"); // long 18
					block.jdat = query.GetFieldData(block.GetBlockName(), "jdat", i).ParseLong("jdat"); // long 18
					block.jpmd = query.GetFieldData(block.GetBlockName(), "jpmd", i).ParseLong("jpmd"); // long 18
					block.sysprocseq = query.GetFieldData(block.GetBlockName(), "sysprocseq", i).ParseLong("sysprocseq"); // long 10
					block.loandt = query.GetFieldData(block.GetBlockName(), "loandt", i).TrimEnd('?'); // char 8
					block.hname = query.GetFieldData(block.GetBlockName(), "hname", i).TrimEnd('?'); // char 20
					block.marketgb = query.GetFieldData(block.GetBlockName(), "marketgb", i).FirstOrDefault(); // char 1
					block.jonggb = query.GetFieldData(block.GetBlockName(), "jonggb", i).FirstOrDefault(); // char 1
					block.janrt = query.GetFieldData(block.GetBlockName(), "janrt", i).ParseFloat("janrt"); // float 10.2
					block.price = query.GetFieldData(block.GetBlockName(), "price", i).ParseLong("price"); // long 8
					block.appamt = query.GetFieldData(block.GetBlockName(), "appamt", i).ParseLong("appamt"); // long 18
					block.dtsunik = query.GetFieldData(block.GetBlockName(), "dtsunik", i).ParseLong("dtsunik"); // long 18
					block.sunikrt = query.GetFieldData(block.GetBlockName(), "sunikrt", i).ParseFloat("sunikrt"); // float 10.2
					block.fee = query.GetFieldData(block.GetBlockName(), "fee", i).ParseLong("fee"); // long 10
					block.tax = query.GetFieldData(block.GetBlockName(), "tax", i).ParseLong("tax"); // long 10
					block.sininter = query.GetFieldData(block.GetBlockName(), "sininter", i).ParseLong("sininter"); // long 10

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
			if (expcode?.Length > 12) return false; // char 12
			if (jangb?.Length > 10) return false; // char 10
			if (janqty.ToString().Length > 18) return false; // long 18
			if (mdposqt.ToString().Length > 18) return false; // long 18
			if (pamt.ToString().Length > 18) return false; // long 18
			if (mamt.ToString().Length > 18) return false; // long 18
			if (sinamt.ToString().Length > 18) return false; // long 18
			if (lastdt?.Length > 8) return false; // char 8
			if (msat.ToString().Length > 18) return false; // long 18
			if (mpms.ToString().Length > 18) return false; // long 18
			if (mdat.ToString().Length > 18) return false; // long 18
			if (mpmd.ToString().Length > 18) return false; // long 18
			if (jsat.ToString().Length > 18) return false; // long 18
			if (jpms.ToString().Length > 18) return false; // long 18
			if (jdat.ToString().Length > 18) return false; // long 18
			if (jpmd.ToString().Length > 18) return false; // long 18
			if (sysprocseq.ToString().Length > 10) return false; // long 10
			if (loandt?.Length > 8) return false; // char 8
			if (hname?.Length > 20) return false; // char 20
			// marketgb char 1
			// jonggb char 1
			// janrt float 10.2
			if (price.ToString().Length > 8) return false; // long 8
			if (appamt.ToString().Length > 18) return false; // long 18
			if (dtsunik.ToString().Length > 18) return false; // long 18
			// sunikrt float 10.2
			if (fee.ToString().Length > 10) return false; // long 10
			if (tax.ToString().Length > 10) return false; // long 10
			if (sininter.ToString().Length > 10) return false; // long 10

			return true;
		}
	}

	/// <summary>
	/// 주식잔고2(t0424)
	/// </summary>
	public partial class XQt0424 : XingQuery
	{
		/// <summary>
		/// t0424
		/// </summary>
		public const string _typeName = "t0424";
		/// <summary>
		/// 주식잔고2(t0424)
		/// </summary>
		public const string _typeDesc = "주식잔고2(t0424)";
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
		/// t0424
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 주식잔고2(t0424)
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

		/// <summary>
		/// 주식잔고2(t0424)
		/// </summary>
		public XQt0424() : base("t0424") { }


		public class XQAllOutBlocks
		{
			public XQt0424OutBlock OutBlock { get; internal set; }
			public XQt0424OutBlock1[] OutBlock1 { get; internal set; }
		}

		public static XQAllOutBlocks Get(string accno = default,string passwd = default,char prcgb = default,char chegb = default,char dangb = default,char charge = default,string cts_expcode = default)
		{
			using (XQt0424 instance = new XQt0424())
			{
				instance.SetFieldData(XQt0424InBlock.BlockName, XQt0424InBlock.F.accno, 0, accno); // char 11
				instance.SetFieldData(XQt0424InBlock.BlockName, XQt0424InBlock.F.passwd, 0, passwd); // char 8
				instance.SetFieldData(XQt0424InBlock.BlockName, XQt0424InBlock.F.prcgb, 0, prcgb.ToString()); // char 1
				instance.SetFieldData(XQt0424InBlock.BlockName, XQt0424InBlock.F.chegb, 0, chegb.ToString()); // char 1
				instance.SetFieldData(XQt0424InBlock.BlockName, XQt0424InBlock.F.dangb, 0, dangb.ToString()); // char 1
				instance.SetFieldData(XQt0424InBlock.BlockName, XQt0424InBlock.F.charge, 0, charge.ToString()); // char 1
				instance.SetFieldData(XQt0424InBlock.BlockName, XQt0424InBlock.F.cts_expcode, 0, cts_expcode); // char 22

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

		public static XQAllOutBlocks ReadFromDB(/* string accno = default,string passwd = default,char prcgb = default,char chegb = default,char dangb = default,char charge = default,string cts_expcode = default */)
		{
			using (XQt0424 instance = new XQt0424())
			{

				XQAllOutBlocks results = new XQAllOutBlocks();

				QueryOption qo = new QueryOption("XQt0424OutBlock");
				results.OutBlock = instance.Select<XQt0424OutBlock>(qo);

				qo = new QueryOption("XQt0424OutBlock1");
				results.OutBlock1 = instance.SelectMany<XQt0424OutBlock1>(qo);
				return results;
			}
		}

		public bool SetBlock(XQt0424InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "accno", 0, block.accno); // char 11
			_xaQuery.SetFieldData(block.GetBlockName(), "passwd", 0, block.passwd); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "prcgb", 0, block.prcgb.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "chegb", 0, block.chegb.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "dangb", 0, block.dangb.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "charge", 0, block.charge.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "cts_expcode", 0, block.cts_expcode); // char 22

			return true;
		}

		public XQt0424OutBlock GetBlock()
		{
			XQt0424OutBlock instance = XQt0424OutBlock.FromQuery(this);
			return instance;

		}

		public XQt0424OutBlock1[] GetBlock1s()
		{
			XQt0424OutBlock1[] instance = XQt0424OutBlock1.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt0424OutBlock),
			typeof(XQt0424OutBlock1),

		};

	}

}
