using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt0150InBlock : XingBlock
	{
		/// <summary>
		/// t0150InBlock
		/// </summary>
		public const string _blockName = "t0150InBlock";
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
		/// t0150InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t0150InBlock
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
		/// CTS_매매구분
		/// </summary>
		[XAQueryFieldAttribute("CTS_매매구분")]
		public char cts_medosu;
		/// <summary>
		/// CTS_종목번호
		/// </summary>
		[XAQueryFieldAttribute("CTS_종목번호")]
		public string cts_expcode;
		/// <summary>
		/// CTS_단가
		/// </summary>
		[XAQueryFieldAttribute("CTS_단가")]
		public string cts_price;
		/// <summary>
		/// CTS_매체
		/// </summary>
		[XAQueryFieldAttribute("CTS_매체")]
		public string cts_middiv;

		public static class F
		{
			/// <summary>
			/// 계좌번호
			/// </summary>
			public const string accno = "accno";
			/// <summary>
			/// CTS_매매구분
			/// </summary>
			public const string cts_medosu = "cts_medosu";
			/// <summary>
			/// CTS_종목번호
			/// </summary>
			public const string cts_expcode = "cts_expcode";
			/// <summary>
			/// CTS_단가
			/// </summary>
			public const string cts_price = "cts_price";
			/// <summary>
			/// CTS_매체
			/// </summary>
			public const string cts_middiv = "cts_middiv";
		}

		public static string[] AllFields = new string[]
		{
			F.accno,
			F.cts_medosu,
			F.cts_expcode,
			F.cts_price,
			F.cts_middiv,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["accno"] = new XAQueryFieldInfo("char", accno, accno, "계좌번호", (decimal)11);
			dict["cts_medosu"] = new XAQueryFieldInfo("char", cts_medosu, cts_medosu.ToString(), "CTS_매매구분", (decimal)1);
			dict["cts_expcode"] = new XAQueryFieldInfo("char", cts_expcode, cts_expcode, "CTS_종목번호", (decimal)12);
			dict["cts_price"] = new XAQueryFieldInfo("char", cts_price, cts_price, "CTS_단가", (decimal)9);
			dict["cts_middiv"] = new XAQueryFieldInfo("char", cts_middiv, cts_middiv, "CTS_매체", (decimal)2);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "accno":
					this.accno = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cts_medosu":
					this.cts_medosu = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "cts_expcode":
					this.cts_expcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cts_price":
					this.cts_price = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cts_middiv":
					this.cts_middiv = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (accno?.Length > 11) return false; // char 11
			// cts_medosu char 1
			if (cts_expcode?.Length > 12) return false; // char 12
			if (cts_price?.Length > 9) return false; // char 9
			if (cts_middiv?.Length > 2) return false; // char 2

			return true;
		}
	}

	public partial class XQt0150OutBlock : XingBlock
	{
		/// <summary>
		/// t0150OutBlock
		/// </summary>
		public const string _blockName = "t0150OutBlock";
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
		/// t0150OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t0150OutBlock
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
		/// 매도수량
		/// </summary>
		[XAQueryFieldAttribute("매도수량")]
		public long mdqty;
		/// <summary>
		/// 매도약정금액
		/// </summary>
		[XAQueryFieldAttribute("매도약정금액")]
		public long mdamt;
		/// <summary>
		/// 매도수수료
		/// </summary>
		[XAQueryFieldAttribute("매도수수료")]
		public long mdfee;
		/// <summary>
		/// 매도거래세
		/// </summary>
		[XAQueryFieldAttribute("매도거래세")]
		public long mdtax;
		/// <summary>
		/// 매도농특세
		/// </summary>
		[XAQueryFieldAttribute("매도농특세")]
		public long mdargtax;
		/// <summary>
		/// 매도제비용합
		/// </summary>
		[XAQueryFieldAttribute("매도제비용합")]
		public long tmdtax;
		/// <summary>
		/// 매도정산금액
		/// </summary>
		[XAQueryFieldAttribute("매도정산금액")]
		public long mdadjamt;
		/// <summary>
		/// 매수수량
		/// </summary>
		[XAQueryFieldAttribute("매수수량")]
		public long msqty;
		/// <summary>
		/// 매수약정금액
		/// </summary>
		[XAQueryFieldAttribute("매수약정금액")]
		public long msamt;
		/// <summary>
		/// 매수수수료
		/// </summary>
		[XAQueryFieldAttribute("매수수수료")]
		public long msfee;
		/// <summary>
		/// 매수제비용합
		/// </summary>
		[XAQueryFieldAttribute("매수제비용합")]
		public long tmstax;
		/// <summary>
		/// 매수정산금액
		/// </summary>
		[XAQueryFieldAttribute("매수정산금액")]
		public long msadjamt;
		/// <summary>
		/// 합계수량
		/// </summary>
		[XAQueryFieldAttribute("합계수량")]
		public long tqty;
		/// <summary>
		/// 합계약정금액
		/// </summary>
		[XAQueryFieldAttribute("합계약정금액")]
		public long tamt;
		/// <summary>
		/// 합계수수료
		/// </summary>
		[XAQueryFieldAttribute("합계수수료")]
		public long tfee;
		/// <summary>
		/// 합계거래세
		/// </summary>
		[XAQueryFieldAttribute("합계거래세")]
		public long tottax;
		/// <summary>
		/// 합계농특세
		/// </summary>
		[XAQueryFieldAttribute("합계농특세")]
		public long targtax;
		/// <summary>
		/// 합계제비용합
		/// </summary>
		[XAQueryFieldAttribute("합계제비용합")]
		public long ttax;
		/// <summary>
		/// 합계정산금액
		/// </summary>
		[XAQueryFieldAttribute("합계정산금액")]
		public long tadjamt;
		/// <summary>
		/// CTS_매매구분
		/// </summary>
		[XAQueryFieldAttribute("CTS_매매구분")]
		public char cts_medosu;
		/// <summary>
		/// CTS_종목번호
		/// </summary>
		[XAQueryFieldAttribute("CTS_종목번호")]
		public string cts_expcode;
		/// <summary>
		/// CTS_단가
		/// </summary>
		[XAQueryFieldAttribute("CTS_단가")]
		public string cts_price;
		/// <summary>
		/// CTS_매체
		/// </summary>
		[XAQueryFieldAttribute("CTS_매체")]
		public string cts_middiv;

		public static class F
		{
			/// <summary>
			/// 매도수량
			/// </summary>
			public const string mdqty = "mdqty";
			/// <summary>
			/// 매도약정금액
			/// </summary>
			public const string mdamt = "mdamt";
			/// <summary>
			/// 매도수수료
			/// </summary>
			public const string mdfee = "mdfee";
			/// <summary>
			/// 매도거래세
			/// </summary>
			public const string mdtax = "mdtax";
			/// <summary>
			/// 매도농특세
			/// </summary>
			public const string mdargtax = "mdargtax";
			/// <summary>
			/// 매도제비용합
			/// </summary>
			public const string tmdtax = "tmdtax";
			/// <summary>
			/// 매도정산금액
			/// </summary>
			public const string mdadjamt = "mdadjamt";
			/// <summary>
			/// 매수수량
			/// </summary>
			public const string msqty = "msqty";
			/// <summary>
			/// 매수약정금액
			/// </summary>
			public const string msamt = "msamt";
			/// <summary>
			/// 매수수수료
			/// </summary>
			public const string msfee = "msfee";
			/// <summary>
			/// 매수제비용합
			/// </summary>
			public const string tmstax = "tmstax";
			/// <summary>
			/// 매수정산금액
			/// </summary>
			public const string msadjamt = "msadjamt";
			/// <summary>
			/// 합계수량
			/// </summary>
			public const string tqty = "tqty";
			/// <summary>
			/// 합계약정금액
			/// </summary>
			public const string tamt = "tamt";
			/// <summary>
			/// 합계수수료
			/// </summary>
			public const string tfee = "tfee";
			/// <summary>
			/// 합계거래세
			/// </summary>
			public const string tottax = "tottax";
			/// <summary>
			/// 합계농특세
			/// </summary>
			public const string targtax = "targtax";
			/// <summary>
			/// 합계제비용합
			/// </summary>
			public const string ttax = "ttax";
			/// <summary>
			/// 합계정산금액
			/// </summary>
			public const string tadjamt = "tadjamt";
			/// <summary>
			/// CTS_매매구분
			/// </summary>
			public const string cts_medosu = "cts_medosu";
			/// <summary>
			/// CTS_종목번호
			/// </summary>
			public const string cts_expcode = "cts_expcode";
			/// <summary>
			/// CTS_단가
			/// </summary>
			public const string cts_price = "cts_price";
			/// <summary>
			/// CTS_매체
			/// </summary>
			public const string cts_middiv = "cts_middiv";
		}

		public static string[] AllFields = new string[]
		{
			F.mdqty,
			F.mdamt,
			F.mdfee,
			F.mdtax,
			F.mdargtax,
			F.tmdtax,
			F.mdadjamt,
			F.msqty,
			F.msamt,
			F.msfee,
			F.tmstax,
			F.msadjamt,
			F.tqty,
			F.tamt,
			F.tfee,
			F.tottax,
			F.targtax,
			F.ttax,
			F.tadjamt,
			F.cts_medosu,
			F.cts_expcode,
			F.cts_price,
			F.cts_middiv,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["mdqty"] = new XAQueryFieldInfo("long", mdqty, mdqty.ToString("d9"), "매도수량", (decimal)9);
			dict["mdamt"] = new XAQueryFieldInfo("long", mdamt, mdamt.ToString("d18"), "매도약정금액", (decimal)18);
			dict["mdfee"] = new XAQueryFieldInfo("long", mdfee, mdfee.ToString("d18"), "매도수수료", (decimal)18);
			dict["mdtax"] = new XAQueryFieldInfo("long", mdtax, mdtax.ToString("d18"), "매도거래세", (decimal)18);
			dict["mdargtax"] = new XAQueryFieldInfo("long", mdargtax, mdargtax.ToString("d18"), "매도농특세", (decimal)18);
			dict["tmdtax"] = new XAQueryFieldInfo("long", tmdtax, tmdtax.ToString("d18"), "매도제비용합", (decimal)18);
			dict["mdadjamt"] = new XAQueryFieldInfo("long", mdadjamt, mdadjamt.ToString("d18"), "매도정산금액", (decimal)18);
			dict["msqty"] = new XAQueryFieldInfo("long", msqty, msqty.ToString("d9"), "매수수량", (decimal)9);
			dict["msamt"] = new XAQueryFieldInfo("long", msamt, msamt.ToString("d18"), "매수약정금액", (decimal)18);
			dict["msfee"] = new XAQueryFieldInfo("long", msfee, msfee.ToString("d18"), "매수수수료", (decimal)18);
			dict["tmstax"] = new XAQueryFieldInfo("long", tmstax, tmstax.ToString("d18"), "매수제비용합", (decimal)18);
			dict["msadjamt"] = new XAQueryFieldInfo("long", msadjamt, msadjamt.ToString("d18"), "매수정산금액", (decimal)18);
			dict["tqty"] = new XAQueryFieldInfo("long", tqty, tqty.ToString("d9"), "합계수량", (decimal)9);
			dict["tamt"] = new XAQueryFieldInfo("long", tamt, tamt.ToString("d18"), "합계약정금액", (decimal)18);
			dict["tfee"] = new XAQueryFieldInfo("long", tfee, tfee.ToString("d18"), "합계수수료", (decimal)18);
			dict["tottax"] = new XAQueryFieldInfo("long", tottax, tottax.ToString("d18"), "합계거래세", (decimal)18);
			dict["targtax"] = new XAQueryFieldInfo("long", targtax, targtax.ToString("d18"), "합계농특세", (decimal)18);
			dict["ttax"] = new XAQueryFieldInfo("long", ttax, ttax.ToString("d18"), "합계제비용합", (decimal)18);
			dict["tadjamt"] = new XAQueryFieldInfo("long", tadjamt, tadjamt.ToString("d18"), "합계정산금액", (decimal)18);
			dict["cts_medosu"] = new XAQueryFieldInfo("char", cts_medosu, cts_medosu.ToString(), "CTS_매매구분", (decimal)1);
			dict["cts_expcode"] = new XAQueryFieldInfo("char", cts_expcode, cts_expcode, "CTS_종목번호", (decimal)12);
			dict["cts_price"] = new XAQueryFieldInfo("char", cts_price, cts_price, "CTS_단가", (decimal)9);
			dict["cts_middiv"] = new XAQueryFieldInfo("char", cts_middiv, cts_middiv, "CTS_매체", (decimal)2);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "mdqty":
					this.mdqty = fieldInfo.FieldValue.ParseLong("mdqty");
				break;

				case "mdamt":
					this.mdamt = fieldInfo.FieldValue.ParseLong("mdamt");
				break;

				case "mdfee":
					this.mdfee = fieldInfo.FieldValue.ParseLong("mdfee");
				break;

				case "mdtax":
					this.mdtax = fieldInfo.FieldValue.ParseLong("mdtax");
				break;

				case "mdargtax":
					this.mdargtax = fieldInfo.FieldValue.ParseLong("mdargtax");
				break;

				case "tmdtax":
					this.tmdtax = fieldInfo.FieldValue.ParseLong("tmdtax");
				break;

				case "mdadjamt":
					this.mdadjamt = fieldInfo.FieldValue.ParseLong("mdadjamt");
				break;

				case "msqty":
					this.msqty = fieldInfo.FieldValue.ParseLong("msqty");
				break;

				case "msamt":
					this.msamt = fieldInfo.FieldValue.ParseLong("msamt");
				break;

				case "msfee":
					this.msfee = fieldInfo.FieldValue.ParseLong("msfee");
				break;

				case "tmstax":
					this.tmstax = fieldInfo.FieldValue.ParseLong("tmstax");
				break;

				case "msadjamt":
					this.msadjamt = fieldInfo.FieldValue.ParseLong("msadjamt");
				break;

				case "tqty":
					this.tqty = fieldInfo.FieldValue.ParseLong("tqty");
				break;

				case "tamt":
					this.tamt = fieldInfo.FieldValue.ParseLong("tamt");
				break;

				case "tfee":
					this.tfee = fieldInfo.FieldValue.ParseLong("tfee");
				break;

				case "tottax":
					this.tottax = fieldInfo.FieldValue.ParseLong("tottax");
				break;

				case "targtax":
					this.targtax = fieldInfo.FieldValue.ParseLong("targtax");
				break;

				case "ttax":
					this.ttax = fieldInfo.FieldValue.ParseLong("ttax");
				break;

				case "tadjamt":
					this.tadjamt = fieldInfo.FieldValue.ParseLong("tadjamt");
				break;

				case "cts_medosu":
					this.cts_medosu = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "cts_expcode":
					this.cts_expcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cts_price":
					this.cts_price = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cts_middiv":
					this.cts_middiv = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt0150OutBlock FromQuery(XQt0150 query)
		{
			XQt0150OutBlock block = new XQt0150OutBlock();
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
				block.mdqty = query.GetFieldData(block.GetBlockName(), "mdqty", 0).ParseLong("mdqty"); // long 9
				block.mdamt = query.GetFieldData(block.GetBlockName(), "mdamt", 0).ParseLong("mdamt"); // long 18
				block.mdfee = query.GetFieldData(block.GetBlockName(), "mdfee", 0).ParseLong("mdfee"); // long 18
				block.mdtax = query.GetFieldData(block.GetBlockName(), "mdtax", 0).ParseLong("mdtax"); // long 18
				block.mdargtax = query.GetFieldData(block.GetBlockName(), "mdargtax", 0).ParseLong("mdargtax"); // long 18
				block.tmdtax = query.GetFieldData(block.GetBlockName(), "tmdtax", 0).ParseLong("tmdtax"); // long 18
				block.mdadjamt = query.GetFieldData(block.GetBlockName(), "mdadjamt", 0).ParseLong("mdadjamt"); // long 18
				block.msqty = query.GetFieldData(block.GetBlockName(), "msqty", 0).ParseLong("msqty"); // long 9
				block.msamt = query.GetFieldData(block.GetBlockName(), "msamt", 0).ParseLong("msamt"); // long 18
				block.msfee = query.GetFieldData(block.GetBlockName(), "msfee", 0).ParseLong("msfee"); // long 18
				block.tmstax = query.GetFieldData(block.GetBlockName(), "tmstax", 0).ParseLong("tmstax"); // long 18
				block.msadjamt = query.GetFieldData(block.GetBlockName(), "msadjamt", 0).ParseLong("msadjamt"); // long 18
				block.tqty = query.GetFieldData(block.GetBlockName(), "tqty", 0).ParseLong("tqty"); // long 9
				block.tamt = query.GetFieldData(block.GetBlockName(), "tamt", 0).ParseLong("tamt"); // long 18
				block.tfee = query.GetFieldData(block.GetBlockName(), "tfee", 0).ParseLong("tfee"); // long 18
				block.tottax = query.GetFieldData(block.GetBlockName(), "tottax", 0).ParseLong("tottax"); // long 18
				block.targtax = query.GetFieldData(block.GetBlockName(), "targtax", 0).ParseLong("targtax"); // long 18
				block.ttax = query.GetFieldData(block.GetBlockName(), "ttax", 0).ParseLong("ttax"); // long 18
				block.tadjamt = query.GetFieldData(block.GetBlockName(), "tadjamt", 0).ParseLong("tadjamt"); // long 18
				block.cts_medosu = query.GetFieldData(block.GetBlockName(), "cts_medosu", 0).FirstOrDefault(); // char 1
				block.cts_expcode = query.GetFieldData(block.GetBlockName(), "cts_expcode", 0).TrimEnd('?'); // char 12
				block.cts_price = query.GetFieldData(block.GetBlockName(), "cts_price", 0).TrimEnd('?'); // char 9
				block.cts_middiv = query.GetFieldData(block.GetBlockName(), "cts_middiv", 0).TrimEnd('?'); // char 2

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (mdqty.ToString().Length > 9) return false; // long 9
			if (mdamt.ToString().Length > 18) return false; // long 18
			if (mdfee.ToString().Length > 18) return false; // long 18
			if (mdtax.ToString().Length > 18) return false; // long 18
			if (mdargtax.ToString().Length > 18) return false; // long 18
			if (tmdtax.ToString().Length > 18) return false; // long 18
			if (mdadjamt.ToString().Length > 18) return false; // long 18
			if (msqty.ToString().Length > 9) return false; // long 9
			if (msamt.ToString().Length > 18) return false; // long 18
			if (msfee.ToString().Length > 18) return false; // long 18
			if (tmstax.ToString().Length > 18) return false; // long 18
			if (msadjamt.ToString().Length > 18) return false; // long 18
			if (tqty.ToString().Length > 9) return false; // long 9
			if (tamt.ToString().Length > 18) return false; // long 18
			if (tfee.ToString().Length > 18) return false; // long 18
			if (tottax.ToString().Length > 18) return false; // long 18
			if (targtax.ToString().Length > 18) return false; // long 18
			if (ttax.ToString().Length > 18) return false; // long 18
			if (tadjamt.ToString().Length > 18) return false; // long 18
			// cts_medosu char 1
			if (cts_expcode?.Length > 12) return false; // char 12
			if (cts_price?.Length > 9) return false; // char 9
			if (cts_middiv?.Length > 2) return false; // char 2

			return true;
		}
	}

	public partial class XQt0150OutBlock1 : XingBlock
	{
		/// <summary>
		/// t0150OutBlock1
		/// </summary>
		public const string _blockName = "t0150OutBlock1";
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
		/// t0150OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t0150OutBlock1
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
		/// 매매구분
		/// </summary>
		[XAQueryFieldAttribute("매매구분")]
		public string medosu;
		/// <summary>
		/// 종목번호
		/// </summary>
		[XAQueryFieldAttribute("종목번호")]
		public string expcode;
		/// <summary>
		/// 수량
		/// </summary>
		[XAQueryFieldAttribute("수량")]
		public long qty;
		/// <summary>
		/// 단가
		/// </summary>
		[XAQueryFieldAttribute("단가")]
		public long price;
		/// <summary>
		/// 약정금액
		/// </summary>
		[XAQueryFieldAttribute("약정금액")]
		public long amt;
		/// <summary>
		/// 수수료
		/// </summary>
		[XAQueryFieldAttribute("수수료")]
		public long fee;
		/// <summary>
		/// 거래세
		/// </summary>
		[XAQueryFieldAttribute("거래세")]
		public long tax;
		/// <summary>
		/// 농특세
		/// </summary>
		[XAQueryFieldAttribute("농특세")]
		public long argtax;
		/// <summary>
		/// 정산금액
		/// </summary>
		[XAQueryFieldAttribute("정산금액")]
		public long adjamt;
		/// <summary>
		/// 매체
		/// </summary>
		[XAQueryFieldAttribute("매체")]
		public string middiv;

		public static class F
		{
			/// <summary>
			/// 매매구분
			/// </summary>
			public const string medosu = "medosu";
			/// <summary>
			/// 종목번호
			/// </summary>
			public const string expcode = "expcode";
			/// <summary>
			/// 수량
			/// </summary>
			public const string qty = "qty";
			/// <summary>
			/// 단가
			/// </summary>
			public const string price = "price";
			/// <summary>
			/// 약정금액
			/// </summary>
			public const string amt = "amt";
			/// <summary>
			/// 수수료
			/// </summary>
			public const string fee = "fee";
			/// <summary>
			/// 거래세
			/// </summary>
			public const string tax = "tax";
			/// <summary>
			/// 농특세
			/// </summary>
			public const string argtax = "argtax";
			/// <summary>
			/// 정산금액
			/// </summary>
			public const string adjamt = "adjamt";
			/// <summary>
			/// 매체
			/// </summary>
			public const string middiv = "middiv";
		}

		public static string[] AllFields = new string[]
		{
			F.medosu,
			F.expcode,
			F.qty,
			F.price,
			F.amt,
			F.fee,
			F.tax,
			F.argtax,
			F.adjamt,
			F.middiv,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["medosu"] = new XAQueryFieldInfo("char", medosu, medosu, "매매구분", (decimal)10);
			dict["expcode"] = new XAQueryFieldInfo("char", expcode, expcode, "종목번호", (decimal)12);
			dict["qty"] = new XAQueryFieldInfo("long", qty, qty.ToString("d9"), "수량", (decimal)9);
			dict["price"] = new XAQueryFieldInfo("long", price, price.ToString("d9"), "단가", (decimal)9);
			dict["amt"] = new XAQueryFieldInfo("long", amt, amt.ToString("d18"), "약정금액", (decimal)18);
			dict["fee"] = new XAQueryFieldInfo("long", fee, fee.ToString("d18"), "수수료", (decimal)18);
			dict["tax"] = new XAQueryFieldInfo("long", tax, tax.ToString("d18"), "거래세", (decimal)18);
			dict["argtax"] = new XAQueryFieldInfo("long", argtax, argtax.ToString("d18"), "농특세", (decimal)18);
			dict["adjamt"] = new XAQueryFieldInfo("long", adjamt, adjamt.ToString("d18"), "정산금액", (decimal)18);
			dict["middiv"] = new XAQueryFieldInfo("char", middiv, middiv, "매체", (decimal)20);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "medosu":
					this.medosu = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "expcode":
					this.expcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "qty":
					this.qty = fieldInfo.FieldValue.ParseLong("qty");
				break;

				case "price":
					this.price = fieldInfo.FieldValue.ParseLong("price");
				break;

				case "amt":
					this.amt = fieldInfo.FieldValue.ParseLong("amt");
				break;

				case "fee":
					this.fee = fieldInfo.FieldValue.ParseLong("fee");
				break;

				case "tax":
					this.tax = fieldInfo.FieldValue.ParseLong("tax");
				break;

				case "argtax":
					this.argtax = fieldInfo.FieldValue.ParseLong("argtax");
				break;

				case "adjamt":
					this.adjamt = fieldInfo.FieldValue.ParseLong("adjamt");
				break;

				case "middiv":
					this.middiv = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt0150OutBlock1[] ListFromQuery(XQt0150 query)
		{
			int count = query.GetBlockCount(XQt0150OutBlock1.BlockName);
			List<XQt0150OutBlock1> list = new List<XQt0150OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt0150OutBlock1 block = new XQt0150OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.medosu = query.GetFieldData(block.GetBlockName(), "medosu", i).TrimEnd('?'); // char 10
					block.expcode = query.GetFieldData(block.GetBlockName(), "expcode", i).TrimEnd('?'); // char 12
					block.qty = query.GetFieldData(block.GetBlockName(), "qty", i).ParseLong("qty"); // long 9
					block.price = query.GetFieldData(block.GetBlockName(), "price", i).ParseLong("price"); // long 9
					block.amt = query.GetFieldData(block.GetBlockName(), "amt", i).ParseLong("amt"); // long 18
					block.fee = query.GetFieldData(block.GetBlockName(), "fee", i).ParseLong("fee"); // long 18
					block.tax = query.GetFieldData(block.GetBlockName(), "tax", i).ParseLong("tax"); // long 18
					block.argtax = query.GetFieldData(block.GetBlockName(), "argtax", i).ParseLong("argtax"); // long 18
					block.adjamt = query.GetFieldData(block.GetBlockName(), "adjamt", i).ParseLong("adjamt"); // long 18
					block.middiv = query.GetFieldData(block.GetBlockName(), "middiv", i).TrimEnd('?'); // char 20

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
			if (medosu?.Length > 10) return false; // char 10
			if (expcode?.Length > 12) return false; // char 12
			if (qty.ToString().Length > 9) return false; // long 9
			if (price.ToString().Length > 9) return false; // long 9
			if (amt.ToString().Length > 18) return false; // long 18
			if (fee.ToString().Length > 18) return false; // long 18
			if (tax.ToString().Length > 18) return false; // long 18
			if (argtax.ToString().Length > 18) return false; // long 18
			if (adjamt.ToString().Length > 18) return false; // long 18
			if (middiv?.Length > 20) return false; // char 20

			return true;
		}
	}

	/// <summary>
	/// 주식당일매매일지/수수료(t0150)
	/// </summary>
	public partial class XQt0150 : XingQuery
	{
		/// <summary>
		/// t0150
		/// </summary>
		public const string _typeName = "t0150";
		/// <summary>
		/// 주식당일매매일지/수수료(t0150)
		/// </summary>
		public const string _typeDesc = "주식당일매매일지/수수료(t0150)";
		/// <summary>
		/// 
		/// </summary>
		public const string _service = "";
		/// <summary>
		/// 
		/// </summary>
		public const string _headType = "";
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
		/// t0150
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 주식당일매매일지/수수료(t0150)
		/// </summary>
		public string TypeDesc => _typeDesc;
		/// <summary>
		/// 
		/// </summary>
		public string Service => _service;
		/// <summary>
		/// 
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
		/// 주식당일매매일지/수수료(t0150)
		/// </summary>
		public XQt0150() : base("t0150") { }


		public static XQt0150OutBlock1[] Get(string accno = default,char cts_medosu = default,string cts_expcode = default,string cts_price = default,string cts_middiv = default)
		{
			using (XQt0150 instance = new XQt0150())
			{
				instance.SetFieldData(XQt0150InBlock.BlockName, XQt0150InBlock.F.accno, 0, accno); // char 11
				instance.SetFieldData(XQt0150InBlock.BlockName, XQt0150InBlock.F.cts_medosu, 0, cts_medosu.ToString()); // char 1
				instance.SetFieldData(XQt0150InBlock.BlockName, XQt0150InBlock.F.cts_expcode, 0, cts_expcode); // char 12
				instance.SetFieldData(XQt0150InBlock.BlockName, XQt0150InBlock.F.cts_price, 0, cts_price); // char 9
				instance.SetFieldData(XQt0150InBlock.BlockName, XQt0150InBlock.F.cts_middiv, 0, cts_middiv); // char 2

				if (instance.Request() < 0)
				{
					return null;
				}

				var outBlock = instance.GetBlock1s();
				return outBlock;
			}
		}

		public bool SetBlock(XQt0150InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "accno", 0, block.accno); // char 11
			_xaQuery.SetFieldData(block.GetBlockName(), "cts_medosu", 0, block.cts_medosu.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "cts_expcode", 0, block.cts_expcode); // char 12
			_xaQuery.SetFieldData(block.GetBlockName(), "cts_price", 0, block.cts_price); // char 9
			_xaQuery.SetFieldData(block.GetBlockName(), "cts_middiv", 0, block.cts_middiv); // char 2

			return true;
		}

		public XQt0150OutBlock GetBlock()
		{
			XQt0150OutBlock instance = XQt0150OutBlock.FromQuery(this);
			return instance;

		}

		public XQt0150OutBlock1[] GetBlock1s()
		{
			XQt0150OutBlock1[] instance = XQt0150OutBlock1.ListFromQuery(this);
			return instance;

		}


	}

}
