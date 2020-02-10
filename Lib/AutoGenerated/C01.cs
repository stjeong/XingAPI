using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XRC01InBlock : XingBlock
	{
		/// <summary>
		/// InBlock
		/// </summary>
		public const string _blockName = "InBlock";
		/// <summary>
		/// 입력
		/// </summary>
		public const string _blockDesc = "입력";
		/// <summary>
		/// input
		/// </summary>
		public const string _blockType = "input";
		/// <summary>
		/// false
		/// </summary>
		public const bool _hasOccurs = false;
		/// <summary>
		/// InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// InBlock
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// 입력
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


		public static class F
		{
		}

		public static string[] AllFields = new string[]
		{
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
		}

		public bool VerifyData()
		{

			return true;
		}
	}

	public partial class XRC01OutBlock : XingBlock
	{
		/// <summary>
		/// OutBlock
		/// </summary>
		public const string _blockName = "OutBlock";
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
		/// OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// OutBlock
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
		/// 라인일련번호
		/// </summary>
		[XAQueryFieldAttribute("라인일련번호", "10")]
		public long lineseq;
		/// <summary>
		/// 계좌번호
		/// </summary>
		[XAQueryFieldAttribute("계좌번호", "11")]
		public string accno;
		/// <summary>
		/// 조작자ID
		/// </summary>
		[XAQueryFieldAttribute("조작자ID", "8")]
		public string user;
		/// <summary>
		/// 일련번호
		/// </summary>
		[XAQueryFieldAttribute("일련번호", "11")]
		public long seq;
		/// <summary>
		/// trcode
		/// </summary>
		[XAQueryFieldAttribute("trcode", "11")]
		public string trcode;
		/// <summary>
		/// 매칭그룹번호
		/// </summary>
		[XAQueryFieldAttribute("매칭그룹번호", "2")]
		public string megrpno;
		/// <summary>
		/// 보드ID
		/// </summary>
		[XAQueryFieldAttribute("보드ID", "2")]
		public string boardid;
		/// <summary>
		/// 회원번호
		/// </summary>
		[XAQueryFieldAttribute("회원번호", "5")]
		public string memberno;
		/// <summary>
		/// 지점번호
		/// </summary>
		[XAQueryFieldAttribute("지점번호", "5")]
		public string bpno;
		/// <summary>
		/// 주문번호
		/// </summary>
		[XAQueryFieldAttribute("주문번호", "10")]
		public string ordno;
		/// <summary>
		/// 원주문번호
		/// </summary>
		[XAQueryFieldAttribute("원주문번호", "10")]
		public string orgordno;
		/// <summary>
		/// 종목코드
		/// </summary>
		[XAQueryFieldAttribute("종목코드", "12")]
		public string expcode;
		/// <summary>
		/// 약정번호
		/// </summary>
		[XAQueryFieldAttribute("약정번호", "11")]
		public string yakseq;
		/// <summary>
		/// 체결가격
		/// </summary>
		[XAQueryFieldAttribute("체결가격", "11.2")]
		public float cheprice;
		/// <summary>
		/// 체결수량
		/// </summary>
		[XAQueryFieldAttribute("체결수량", "10")]
		public long chevol;
		/// <summary>
		/// 세션ID
		/// </summary>
		[XAQueryFieldAttribute("세션ID", "2")]
		public string sessionid;
		/// <summary>
		/// 체결일자
		/// </summary>
		[XAQueryFieldAttribute("체결일자", "8")]
		public string chedate;
		/// <summary>
		/// 체결시각
		/// </summary>
		[XAQueryFieldAttribute("체결시각", "9")]
		public string chetime;
		/// <summary>
		/// 최근월체결가격
		/// </summary>
		[XAQueryFieldAttribute("최근월체결가격", "11.2")]
		public float spdprc1;
		/// <summary>
		/// 차근월체결가격
		/// </summary>
		[XAQueryFieldAttribute("차근월체결가격", "11.2")]
		public float spdprc2;
		/// <summary>
		/// 매도수구분
		/// </summary>
		[XAQueryFieldAttribute("매도수구분", "1")]
		public char dosugb;
		/// <summary>
		/// 계좌번호1
		/// </summary>
		[XAQueryFieldAttribute("계좌번호1", "12")]
		public string accno1;
		/// <summary>
		/// 시장조성호가구분
		/// </summary>
		[XAQueryFieldAttribute("시장조성호가구분", "11")]
		public string sihogagb;
		/// <summary>
		/// 위탁사번호
		/// </summary>
		[XAQueryFieldAttribute("위탁사번호", "5")]
		public string jakino;
		/// <summary>
		/// 대용주권계좌번호
		/// </summary>
		[XAQueryFieldAttribute("대용주권계좌번호", "12")]
		public string daeyong;
		/// <summary>
		/// mem_filler
		/// </summary>
		[XAQueryFieldAttribute("mem_filler", "7")]
		public string mem_filler;
		/// <summary>
		/// mem_accno
		/// </summary>
		[XAQueryFieldAttribute("mem_accno", "11")]
		public string mem_accno;
		/// <summary>
		/// mem_filler1
		/// </summary>
		[XAQueryFieldAttribute("mem_filler1", "42")]
		public string mem_filler1;

		public static class F
		{
			/// <summary>
			/// 라인일련번호
			/// </summary>
			public const string lineseq = "lineseq";
			/// <summary>
			/// 계좌번호
			/// </summary>
			public const string accno = "accno";
			/// <summary>
			/// 조작자ID
			/// </summary>
			public const string user = "user";
			/// <summary>
			/// 일련번호
			/// </summary>
			public const string seq = "seq";
			/// <summary>
			/// trcode
			/// </summary>
			public const string trcode = "trcode";
			/// <summary>
			/// 매칭그룹번호
			/// </summary>
			public const string megrpno = "megrpno";
			/// <summary>
			/// 보드ID
			/// </summary>
			public const string boardid = "boardid";
			/// <summary>
			/// 회원번호
			/// </summary>
			public const string memberno = "memberno";
			/// <summary>
			/// 지점번호
			/// </summary>
			public const string bpno = "bpno";
			/// <summary>
			/// 주문번호
			/// </summary>
			public const string ordno = "ordno";
			/// <summary>
			/// 원주문번호
			/// </summary>
			public const string orgordno = "orgordno";
			/// <summary>
			/// 종목코드
			/// </summary>
			public const string expcode = "expcode";
			/// <summary>
			/// 약정번호
			/// </summary>
			public const string yakseq = "yakseq";
			/// <summary>
			/// 체결가격
			/// </summary>
			public const string cheprice = "cheprice";
			/// <summary>
			/// 체결수량
			/// </summary>
			public const string chevol = "chevol";
			/// <summary>
			/// 세션ID
			/// </summary>
			public const string sessionid = "sessionid";
			/// <summary>
			/// 체결일자
			/// </summary>
			public const string chedate = "chedate";
			/// <summary>
			/// 체결시각
			/// </summary>
			public const string chetime = "chetime";
			/// <summary>
			/// 최근월체결가격
			/// </summary>
			public const string spdprc1 = "spdprc1";
			/// <summary>
			/// 차근월체결가격
			/// </summary>
			public const string spdprc2 = "spdprc2";
			/// <summary>
			/// 매도수구분
			/// </summary>
			public const string dosugb = "dosugb";
			/// <summary>
			/// 계좌번호1
			/// </summary>
			public const string accno1 = "accno1";
			/// <summary>
			/// 시장조성호가구분
			/// </summary>
			public const string sihogagb = "sihogagb";
			/// <summary>
			/// 위탁사번호
			/// </summary>
			public const string jakino = "jakino";
			/// <summary>
			/// 대용주권계좌번호
			/// </summary>
			public const string daeyong = "daeyong";
			/// <summary>
			/// mem_filler
			/// </summary>
			public const string mem_filler = "mem_filler";
			/// <summary>
			/// mem_accno
			/// </summary>
			public const string mem_accno = "mem_accno";
			/// <summary>
			/// mem_filler1
			/// </summary>
			public const string mem_filler1 = "mem_filler1";
		}

		public static string[] AllFields = new string[]
		{
			F.lineseq,
			F.accno,
			F.user,
			F.seq,
			F.trcode,
			F.megrpno,
			F.boardid,
			F.memberno,
			F.bpno,
			F.ordno,
			F.orgordno,
			F.expcode,
			F.yakseq,
			F.cheprice,
			F.chevol,
			F.sessionid,
			F.chedate,
			F.chetime,
			F.spdprc1,
			F.spdprc2,
			F.dosugb,
			F.accno1,
			F.sihogagb,
			F.jakino,
			F.daeyong,
			F.mem_filler,
			F.mem_accno,
			F.mem_filler1,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["lineseq"] = new XAQueryFieldInfo("long", lineseq, lineseq.ToString("d10"), "라인일련번호", (decimal)10);
			dict["accno"] = new XAQueryFieldInfo("char", accno, accno, "계좌번호", (decimal)11);
			dict["user"] = new XAQueryFieldInfo("char", user, user, "조작자ID", (decimal)8);
			dict["seq"] = new XAQueryFieldInfo("long", seq, seq.ToString("d11"), "일련번호", (decimal)11);
			dict["trcode"] = new XAQueryFieldInfo("char", trcode, trcode, "trcode", (decimal)11);
			dict["megrpno"] = new XAQueryFieldInfo("char", megrpno, megrpno, "매칭그룹번호", (decimal)2);
			dict["boardid"] = new XAQueryFieldInfo("char", boardid, boardid, "보드ID", (decimal)2);
			dict["memberno"] = new XAQueryFieldInfo("char", memberno, memberno, "회원번호", (decimal)5);
			dict["bpno"] = new XAQueryFieldInfo("char", bpno, bpno, "지점번호", (decimal)5);
			dict["ordno"] = new XAQueryFieldInfo("char", ordno, ordno, "주문번호", (decimal)10);
			dict["orgordno"] = new XAQueryFieldInfo("char", orgordno, orgordno, "원주문번호", (decimal)10);
			dict["expcode"] = new XAQueryFieldInfo("char", expcode, expcode, "종목코드", (decimal)12);
			dict["yakseq"] = new XAQueryFieldInfo("char", yakseq, yakseq, "약정번호", (decimal)11);
			dict["cheprice"] = new XAQueryFieldInfo("float", cheprice, cheprice.ToString("00000000000.00"), "체결가격", (decimal)11.2);
			dict["chevol"] = new XAQueryFieldInfo("long", chevol, chevol.ToString("d10"), "체결수량", (decimal)10);
			dict["sessionid"] = new XAQueryFieldInfo("char", sessionid, sessionid, "세션ID", (decimal)2);
			dict["chedate"] = new XAQueryFieldInfo("char", chedate, chedate, "체결일자", (decimal)8);
			dict["chetime"] = new XAQueryFieldInfo("char", chetime, chetime, "체결시각", (decimal)9);
			dict["spdprc1"] = new XAQueryFieldInfo("float", spdprc1, spdprc1.ToString("00000000000.00"), "최근월체결가격", (decimal)11.2);
			dict["spdprc2"] = new XAQueryFieldInfo("float", spdprc2, spdprc2.ToString("00000000000.00"), "차근월체결가격", (decimal)11.2);
			dict["dosugb"] = new XAQueryFieldInfo("char", dosugb, dosugb.ToString(), "매도수구분", (decimal)1);
			dict["accno1"] = new XAQueryFieldInfo("char", accno1, accno1, "계좌번호1", (decimal)12);
			dict["sihogagb"] = new XAQueryFieldInfo("char", sihogagb, sihogagb, "시장조성호가구분", (decimal)11);
			dict["jakino"] = new XAQueryFieldInfo("char", jakino, jakino, "위탁사번호", (decimal)5);
			dict["daeyong"] = new XAQueryFieldInfo("char", daeyong, daeyong, "대용주권계좌번호", (decimal)12);
			dict["mem_filler"] = new XAQueryFieldInfo("char", mem_filler, mem_filler, "mem_filler", (decimal)7);
			dict["mem_accno"] = new XAQueryFieldInfo("char", mem_accno, mem_accno, "mem_accno", (decimal)11);
			dict["mem_filler1"] = new XAQueryFieldInfo("char", mem_filler1, mem_filler1, "mem_filler1", (decimal)42);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "lineseq":
					this.lineseq = fieldInfo.FieldValue.ParseLong("lineseq");
				break;

				case "accno":
					this.accno = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "user":
					this.user = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "seq":
					this.seq = fieldInfo.FieldValue.ParseLong("seq");
				break;

				case "trcode":
					this.trcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "megrpno":
					this.megrpno = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "boardid":
					this.boardid = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "memberno":
					this.memberno = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "bpno":
					this.bpno = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ordno":
					this.ordno = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "orgordno":
					this.orgordno = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "expcode":
					this.expcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "yakseq":
					this.yakseq = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cheprice":
					this.cheprice = fieldInfo.FieldValue.ParseFloat("cheprice");
				break;

				case "chevol":
					this.chevol = fieldInfo.FieldValue.ParseLong("chevol");
				break;

				case "sessionid":
					this.sessionid = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "chedate":
					this.chedate = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "chetime":
					this.chetime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "spdprc1":
					this.spdprc1 = fieldInfo.FieldValue.ParseFloat("spdprc1");
				break;

				case "spdprc2":
					this.spdprc2 = fieldInfo.FieldValue.ParseFloat("spdprc2");
				break;

				case "dosugb":
					this.dosugb = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "accno1":
					this.accno1 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "sihogagb":
					this.sihogagb = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "jakino":
					this.jakino = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "daeyong":
					this.daeyong = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "mem_filler":
					this.mem_filler = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "mem_accno":
					this.mem_accno = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "mem_filler1":
					this.mem_filler1 = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XRC01OutBlock FromQuery(XRC01 query)
		{
			XRC01OutBlock block = new XRC01OutBlock();
			block.IsValidData = true;
			block.InvalidReason = "";
			try
			{
				block.lineseq = query.GetFieldData(block.GetBlockName(), "lineseq").ParseLong("lineseq"); // long 10
				block.accno = query.GetFieldData(block.GetBlockName(), "accno").TrimEnd('?'); // char 11
				block.user = query.GetFieldData(block.GetBlockName(), "user").TrimEnd('?'); // char 8
				block.seq = query.GetFieldData(block.GetBlockName(), "seq").ParseLong("seq"); // long 11
				block.trcode = query.GetFieldData(block.GetBlockName(), "trcode").TrimEnd('?'); // char 11
				block.megrpno = query.GetFieldData(block.GetBlockName(), "megrpno").TrimEnd('?'); // char 2
				block.boardid = query.GetFieldData(block.GetBlockName(), "boardid").TrimEnd('?'); // char 2
				block.memberno = query.GetFieldData(block.GetBlockName(), "memberno").TrimEnd('?'); // char 5
				block.bpno = query.GetFieldData(block.GetBlockName(), "bpno").TrimEnd('?'); // char 5
				block.ordno = query.GetFieldData(block.GetBlockName(), "ordno").TrimEnd('?'); // char 10
				block.orgordno = query.GetFieldData(block.GetBlockName(), "orgordno").TrimEnd('?'); // char 10
				block.expcode = query.GetFieldData(block.GetBlockName(), "expcode").TrimEnd('?'); // char 12
				block.yakseq = query.GetFieldData(block.GetBlockName(), "yakseq").TrimEnd('?'); // char 11
				block.cheprice = query.GetFieldData(block.GetBlockName(), "cheprice").ParseFloat("cheprice"); // float 11.2
				block.chevol = query.GetFieldData(block.GetBlockName(), "chevol").ParseLong("chevol"); // long 10
				block.sessionid = query.GetFieldData(block.GetBlockName(), "sessionid").TrimEnd('?'); // char 2
				block.chedate = query.GetFieldData(block.GetBlockName(), "chedate").TrimEnd('?'); // char 8
				block.chetime = query.GetFieldData(block.GetBlockName(), "chetime").TrimEnd('?'); // char 9
				block.spdprc1 = query.GetFieldData(block.GetBlockName(), "spdprc1").ParseFloat("spdprc1"); // float 11.2
				block.spdprc2 = query.GetFieldData(block.GetBlockName(), "spdprc2").ParseFloat("spdprc2"); // float 11.2
				block.dosugb = query.GetFieldData(block.GetBlockName(), "dosugb").FirstOrDefault(); // char 1
				block.accno1 = query.GetFieldData(block.GetBlockName(), "accno1").TrimEnd('?'); // char 12
				block.sihogagb = query.GetFieldData(block.GetBlockName(), "sihogagb").TrimEnd('?'); // char 11
				block.jakino = query.GetFieldData(block.GetBlockName(), "jakino").TrimEnd('?'); // char 5
				block.daeyong = query.GetFieldData(block.GetBlockName(), "daeyong").TrimEnd('?'); // char 12
				block.mem_filler = query.GetFieldData(block.GetBlockName(), "mem_filler").TrimEnd('?'); // char 7
				block.mem_accno = query.GetFieldData(block.GetBlockName(), "mem_accno").TrimEnd('?'); // char 11
				block.mem_filler1 = query.GetFieldData(block.GetBlockName(), "mem_filler1").TrimEnd('?'); // char 42

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (lineseq.ToString().Length > 10) return false; // long 10
			if (accno?.Length > 11) return false; // char 11
			if (user?.Length > 8) return false; // char 8
			if (seq.ToString().Length > 11) return false; // long 11
			if (trcode?.Length > 11) return false; // char 11
			if (megrpno?.Length > 2) return false; // char 2
			if (boardid?.Length > 2) return false; // char 2
			if (memberno?.Length > 5) return false; // char 5
			if (bpno?.Length > 5) return false; // char 5
			if (ordno?.Length > 10) return false; // char 10
			if (orgordno?.Length > 10) return false; // char 10
			if (expcode?.Length > 12) return false; // char 12
			if (yakseq?.Length > 11) return false; // char 11
			// cheprice float 11.2
			if (chevol.ToString().Length > 10) return false; // long 10
			if (sessionid?.Length > 2) return false; // char 2
			if (chedate?.Length > 8) return false; // char 8
			if (chetime?.Length > 9) return false; // char 9
			// spdprc1 float 11.2
			// spdprc2 float 11.2
			// dosugb char 1
			if (accno1?.Length > 12) return false; // char 12
			if (sihogagb?.Length > 11) return false; // char 11
			if (jakino?.Length > 5) return false; // char 5
			if (daeyong?.Length > 12) return false; // char 12
			if (mem_filler?.Length > 7) return false; // char 7
			if (mem_accno?.Length > 11) return false; // char 11
			if (mem_filler1?.Length > 42) return false; // char 42

			return true;
		}
	}

	/// <summary>
	/// 선물주문체결
	/// </summary>
	public partial class XRC01 : XingReal
	{
		/// <summary>
		/// C01
		/// </summary>
		public const string _typeName = "C01";
		/// <summary>
		/// 선물주문체결
		/// </summary>
		public const string _typeDesc = "선물주문체결";
		/// <summary>
		/// false
		/// </summary>
		public const bool _attr = false;
		/// <summary>
		/// 0
		/// </summary>
		public const int _key = 0;
		/// <summary>
		/// 0
		/// </summary>
		public const int _group = 0;

		/// <summary>
		/// C01
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 선물주문체결
		/// </summary>
		public string TypeDesc => _typeDesc;
		/// <summary>
		/// false
		/// </summary>
		public bool Attr => _attr;
		/// <summary>
		/// 0
		/// </summary>
		public int Key => _key;
		/// <summary>
		/// 0
		/// </summary>
		public int Group => _group;

		/// <summary>
		/// 선물주문체결
		/// </summary>
		public XRC01() : base("C01") { }


		public bool SetBlock(XRC01InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}


			return true;
		}

		public XRC01OutBlock GetBlock()
		{
			XRC01OutBlock instance = XRC01OutBlock.FromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XRC01OutBlock),

		};

	}

}
