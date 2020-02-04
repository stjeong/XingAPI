using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XRH01InBlock : XingBlock
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

	public partial class XRH01OutBlock : XingBlock
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
		[XAQueryFieldAttribute("라인일련번호")]
		public long lineseq;
		/// <summary>
		/// 계좌번호
		/// </summary>
		[XAQueryFieldAttribute("계좌번호")]
		public string accno;
		/// <summary>
		/// 조작자ID
		/// </summary>
		[XAQueryFieldAttribute("조작자ID")]
		public string user;
		/// <summary>
		/// 일련번호
		/// </summary>
		[XAQueryFieldAttribute("일련번호")]
		public long seq;
		/// <summary>
		/// trcode
		/// </summary>
		[XAQueryFieldAttribute("trcode")]
		public string trcode;
		/// <summary>
		/// 매칭그룹번호
		/// </summary>
		[XAQueryFieldAttribute("매칭그룹번호")]
		public string megrpno;
		/// <summary>
		/// 보드ID
		/// </summary>
		[XAQueryFieldAttribute("보드ID")]
		public string boardid;
		/// <summary>
		/// 회원번호
		/// </summary>
		[XAQueryFieldAttribute("회원번호")]
		public string memberno;
		/// <summary>
		/// 지점번호
		/// </summary>
		[XAQueryFieldAttribute("지점번호")]
		public string bpno;
		/// <summary>
		/// 주문번호
		/// </summary>
		[XAQueryFieldAttribute("주문번호")]
		public string ordno;
		/// <summary>
		/// 원주문번호
		/// </summary>
		[XAQueryFieldAttribute("원주문번호")]
		public string orgordno;
		/// <summary>
		/// 종목코드
		/// </summary>
		[XAQueryFieldAttribute("종목코드")]
		public string expcode;
		/// <summary>
		/// 매도수구분
		/// </summary>
		[XAQueryFieldAttribute("매도수구분")]
		public char dosugb;
		/// <summary>
		/// 정정취소구분
		/// </summary>
		[XAQueryFieldAttribute("정정취소구분")]
		public char mocagb;
		/// <summary>
		/// 계좌번호1
		/// </summary>
		[XAQueryFieldAttribute("계좌번호1")]
		public string accno1;
		/// <summary>
		/// 호가수량
		/// </summary>
		[XAQueryFieldAttribute("호가수량")]
		public long qty2;
		/// <summary>
		/// 호가가격
		/// </summary>
		[XAQueryFieldAttribute("호가가격")]
		public float price;
		/// <summary>
		/// 주문유형
		/// </summary>
		[XAQueryFieldAttribute("주문유형")]
		public char ordgb;
		/// <summary>
		/// 호가구분
		/// </summary>
		[XAQueryFieldAttribute("호가구분")]
		public char hogagb;
		/// <summary>
		/// 시장조성호가구분
		/// </summary>
		[XAQueryFieldAttribute("시장조성호가구분")]
		public string sihogagb;
		/// <summary>
		/// 자사주신고서ID
		/// </summary>
		[XAQueryFieldAttribute("자사주신고서ID")]
		public string tradid;
		/// <summary>
		/// 자사주매매방법
		/// </summary>
		[XAQueryFieldAttribute("자사주매매방법")]
		public char treacode;
		/// <summary>
		/// 매도유형코드
		/// </summary>
		[XAQueryFieldAttribute("매도유형코드")]
		public string askcode;
		/// <summary>
		/// 신용구분코드
		/// </summary>
		[XAQueryFieldAttribute("신용구분코드")]
		public string creditcode;
		/// <summary>
		/// 위탁자기구분
		/// </summary>
		[XAQueryFieldAttribute("위탁자기구분")]
		public string jakigb;
		/// <summary>
		/// 위탁사번호
		/// </summary>
		[XAQueryFieldAttribute("위탁사번호")]
		public string trustnum;
		/// <summary>
		/// 프로그램구분
		/// </summary>
		[XAQueryFieldAttribute("프로그램구분")]
		public string ptgb;
		/// <summary>
		/// 대용주권계좌번호
		/// </summary>
		[XAQueryFieldAttribute("대용주권계좌번호")]
		public string substonum;
		/// <summary>
		/// 계좌구분코드
		/// </summary>
		[XAQueryFieldAttribute("계좌구분코드")]
		public string accgb;
		/// <summary>
		/// 계좌증거금코드
		/// </summary>
		[XAQueryFieldAttribute("계좌증거금코드")]
		public string accmarggb;
		/// <summary>
		/// 국가코드
		/// </summary>
		[XAQueryFieldAttribute("국가코드")]
		public string nationcode;
		/// <summary>
		/// 투자자구분
		/// </summary>
		[XAQueryFieldAttribute("투자자구분")]
		public string investgb;
		/// <summary>
		/// 외국인코드
		/// </summary>
		[XAQueryFieldAttribute("외국인코드")]
		public string forecode;
		/// <summary>
		/// 주문매체구분
		/// </summary>
		[XAQueryFieldAttribute("주문매체구분")]
		public char medcode;
		/// <summary>
		/// 주문식별자번호
		/// </summary>
		[XAQueryFieldAttribute("주문식별자번호")]
		public string ordid;
		/// <summary>
		/// MAC주소
		/// </summary>
		[XAQueryFieldAttribute("MAC주소")]
		public string macid;
		/// <summary>
		/// 호가일자
		/// </summary>
		[XAQueryFieldAttribute("호가일자")]
		public string orddate;
		/// <summary>
		/// 회원사주문시각
		/// </summary>
		[XAQueryFieldAttribute("회원사주문시각")]
		public string rcvtime;
		/// <summary>
		/// mem_filler
		/// </summary>
		[XAQueryFieldAttribute("mem_filler")]
		public string mem_filler;
		/// <summary>
		/// mem_accno
		/// </summary>
		[XAQueryFieldAttribute("mem_accno")]
		public string mem_accno;
		/// <summary>
		/// mem_filler1
		/// </summary>
		[XAQueryFieldAttribute("mem_filler1")]
		public string mem_filler1;
		/// <summary>
		/// 매칭접수시간
		/// </summary>
		[XAQueryFieldAttribute("매칭접수시간")]
		public string ordacpttm;
		/// <summary>
		/// 실정정취소수량
		/// </summary>
		[XAQueryFieldAttribute("실정정취소수량")]
		public long qty;
		/// <summary>
		/// 자동취소구분
		/// </summary>
		[XAQueryFieldAttribute("자동취소구분")]
		public char autogb;
		/// <summary>
		/// 거부사유
		/// </summary>
		[XAQueryFieldAttribute("거부사유")]
		public string rejcode;
		/// <summary>
		/// 프로그램호가신고
		/// </summary>
		[XAQueryFieldAttribute("프로그램호가신고")]
		public char prgordde;

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
			/// 매도수구분
			/// </summary>
			public const string dosugb = "dosugb";
			/// <summary>
			/// 정정취소구분
			/// </summary>
			public const string mocagb = "mocagb";
			/// <summary>
			/// 계좌번호1
			/// </summary>
			public const string accno1 = "accno1";
			/// <summary>
			/// 호가수량
			/// </summary>
			public const string qty2 = "qty2";
			/// <summary>
			/// 호가가격
			/// </summary>
			public const string price = "price";
			/// <summary>
			/// 주문유형
			/// </summary>
			public const string ordgb = "ordgb";
			/// <summary>
			/// 호가구분
			/// </summary>
			public const string hogagb = "hogagb";
			/// <summary>
			/// 시장조성호가구분
			/// </summary>
			public const string sihogagb = "sihogagb";
			/// <summary>
			/// 자사주신고서ID
			/// </summary>
			public const string tradid = "tradid";
			/// <summary>
			/// 자사주매매방법
			/// </summary>
			public const string treacode = "treacode";
			/// <summary>
			/// 매도유형코드
			/// </summary>
			public const string askcode = "askcode";
			/// <summary>
			/// 신용구분코드
			/// </summary>
			public const string creditcode = "creditcode";
			/// <summary>
			/// 위탁자기구분
			/// </summary>
			public const string jakigb = "jakigb";
			/// <summary>
			/// 위탁사번호
			/// </summary>
			public const string trustnum = "trustnum";
			/// <summary>
			/// 프로그램구분
			/// </summary>
			public const string ptgb = "ptgb";
			/// <summary>
			/// 대용주권계좌번호
			/// </summary>
			public const string substonum = "substonum";
			/// <summary>
			/// 계좌구분코드
			/// </summary>
			public const string accgb = "accgb";
			/// <summary>
			/// 계좌증거금코드
			/// </summary>
			public const string accmarggb = "accmarggb";
			/// <summary>
			/// 국가코드
			/// </summary>
			public const string nationcode = "nationcode";
			/// <summary>
			/// 투자자구분
			/// </summary>
			public const string investgb = "investgb";
			/// <summary>
			/// 외국인코드
			/// </summary>
			public const string forecode = "forecode";
			/// <summary>
			/// 주문매체구분
			/// </summary>
			public const string medcode = "medcode";
			/// <summary>
			/// 주문식별자번호
			/// </summary>
			public const string ordid = "ordid";
			/// <summary>
			/// MAC주소
			/// </summary>
			public const string macid = "macid";
			/// <summary>
			/// 호가일자
			/// </summary>
			public const string orddate = "orddate";
			/// <summary>
			/// 회원사주문시각
			/// </summary>
			public const string rcvtime = "rcvtime";
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
			/// <summary>
			/// 매칭접수시간
			/// </summary>
			public const string ordacpttm = "ordacpttm";
			/// <summary>
			/// 실정정취소수량
			/// </summary>
			public const string qty = "qty";
			/// <summary>
			/// 자동취소구분
			/// </summary>
			public const string autogb = "autogb";
			/// <summary>
			/// 거부사유
			/// </summary>
			public const string rejcode = "rejcode";
			/// <summary>
			/// 프로그램호가신고
			/// </summary>
			public const string prgordde = "prgordde";
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
			F.dosugb,
			F.mocagb,
			F.accno1,
			F.qty2,
			F.price,
			F.ordgb,
			F.hogagb,
			F.sihogagb,
			F.tradid,
			F.treacode,
			F.askcode,
			F.creditcode,
			F.jakigb,
			F.trustnum,
			F.ptgb,
			F.substonum,
			F.accgb,
			F.accmarggb,
			F.nationcode,
			F.investgb,
			F.forecode,
			F.medcode,
			F.ordid,
			F.macid,
			F.orddate,
			F.rcvtime,
			F.mem_filler,
			F.mem_accno,
			F.mem_filler1,
			F.ordacpttm,
			F.qty,
			F.autogb,
			F.rejcode,
			F.prgordde,
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
			dict["dosugb"] = new XAQueryFieldInfo("char", dosugb, dosugb.ToString(), "매도수구분", (decimal)1);
			dict["mocagb"] = new XAQueryFieldInfo("char", mocagb, mocagb.ToString(), "정정취소구분", (decimal)1);
			dict["accno1"] = new XAQueryFieldInfo("char", accno1, accno1, "계좌번호1", (decimal)12);
			dict["qty2"] = new XAQueryFieldInfo("long", qty2, qty2.ToString("d10"), "호가수량", (decimal)10);
			dict["price"] = new XAQueryFieldInfo("float", price, price.ToString("00000000000.00"), "호가가격", (decimal)11.2);
			dict["ordgb"] = new XAQueryFieldInfo("char", ordgb, ordgb.ToString(), "주문유형", (decimal)1);
			dict["hogagb"] = new XAQueryFieldInfo("char", hogagb, hogagb.ToString(), "호가구분", (decimal)1);
			dict["sihogagb"] = new XAQueryFieldInfo("char", sihogagb, sihogagb, "시장조성호가구분", (decimal)11);
			dict["tradid"] = new XAQueryFieldInfo("char", tradid, tradid, "자사주신고서ID", (decimal)5);
			dict["treacode"] = new XAQueryFieldInfo("char", treacode, treacode.ToString(), "자사주매매방법", (decimal)1);
			dict["askcode"] = new XAQueryFieldInfo("char", askcode, askcode, "매도유형코드", (decimal)2);
			dict["creditcode"] = new XAQueryFieldInfo("char", creditcode, creditcode, "신용구분코드", (decimal)2);
			dict["jakigb"] = new XAQueryFieldInfo("char", jakigb, jakigb, "위탁자기구분", (decimal)2);
			dict["trustnum"] = new XAQueryFieldInfo("char", trustnum, trustnum, "위탁사번호", (decimal)5);
			dict["ptgb"] = new XAQueryFieldInfo("char", ptgb, ptgb, "프로그램구분", (decimal)2);
			dict["substonum"] = new XAQueryFieldInfo("char", substonum, substonum, "대용주권계좌번호", (decimal)12);
			dict["accgb"] = new XAQueryFieldInfo("char", accgb, accgb, "계좌구분코드", (decimal)2);
			dict["accmarggb"] = new XAQueryFieldInfo("char", accmarggb, accmarggb, "계좌증거금코드", (decimal)2);
			dict["nationcode"] = new XAQueryFieldInfo("char", nationcode, nationcode, "국가코드", (decimal)3);
			dict["investgb"] = new XAQueryFieldInfo("char", investgb, investgb, "투자자구분", (decimal)4);
			dict["forecode"] = new XAQueryFieldInfo("char", forecode, forecode, "외국인코드", (decimal)2);
			dict["medcode"] = new XAQueryFieldInfo("char", medcode, medcode.ToString(), "주문매체구분", (decimal)1);
			dict["ordid"] = new XAQueryFieldInfo("char", ordid, ordid, "주문식별자번호", (decimal)12);
			dict["macid"] = new XAQueryFieldInfo("char", macid, macid, "MAC주소", (decimal)12);
			dict["orddate"] = new XAQueryFieldInfo("char", orddate, orddate, "호가일자", (decimal)8);
			dict["rcvtime"] = new XAQueryFieldInfo("char", rcvtime, rcvtime, "회원사주문시각", (decimal)9);
			dict["mem_filler"] = new XAQueryFieldInfo("char", mem_filler, mem_filler, "mem_filler", (decimal)7);
			dict["mem_accno"] = new XAQueryFieldInfo("char", mem_accno, mem_accno, "mem_accno", (decimal)11);
			dict["mem_filler1"] = new XAQueryFieldInfo("char", mem_filler1, mem_filler1, "mem_filler1", (decimal)42);
			dict["ordacpttm"] = new XAQueryFieldInfo("char", ordacpttm, ordacpttm, "매칭접수시간", (decimal)9);
			dict["qty"] = new XAQueryFieldInfo("long", qty, qty.ToString("d10"), "실정정취소수량", (decimal)10);
			dict["autogb"] = new XAQueryFieldInfo("char", autogb, autogb.ToString(), "자동취소구분", (decimal)1);
			dict["rejcode"] = new XAQueryFieldInfo("char", rejcode, rejcode, "거부사유", (decimal)4);
			dict["prgordde"] = new XAQueryFieldInfo("char", prgordde, prgordde.ToString(), "프로그램호가신고", (decimal)1);

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

				case "dosugb":
					this.dosugb = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "mocagb":
					this.mocagb = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "accno1":
					this.accno1 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "qty2":
					this.qty2 = fieldInfo.FieldValue.ParseLong("qty2");
				break;

				case "price":
					this.price = fieldInfo.FieldValue.ParseFloat("price");
				break;

				case "ordgb":
					this.ordgb = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "hogagb":
					this.hogagb = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "sihogagb":
					this.sihogagb = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "tradid":
					this.tradid = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "treacode":
					this.treacode = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "askcode":
					this.askcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "creditcode":
					this.creditcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "jakigb":
					this.jakigb = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "trustnum":
					this.trustnum = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ptgb":
					this.ptgb = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "substonum":
					this.substonum = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "accgb":
					this.accgb = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "accmarggb":
					this.accmarggb = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "nationcode":
					this.nationcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "investgb":
					this.investgb = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "forecode":
					this.forecode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "medcode":
					this.medcode = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "ordid":
					this.ordid = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "macid":
					this.macid = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "orddate":
					this.orddate = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "rcvtime":
					this.rcvtime = fieldInfo.FieldValue.TrimEnd('?');
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

				case "ordacpttm":
					this.ordacpttm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "qty":
					this.qty = fieldInfo.FieldValue.ParseLong("qty");
				break;

				case "autogb":
					this.autogb = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "rejcode":
					this.rejcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "prgordde":
					this.prgordde = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public static XRH01OutBlock FromQuery(XRH01 query)
		{
			XRH01OutBlock block = new XRH01OutBlock();
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
				block.dosugb = query.GetFieldData(block.GetBlockName(), "dosugb").FirstOrDefault(); // char 1
				block.mocagb = query.GetFieldData(block.GetBlockName(), "mocagb").FirstOrDefault(); // char 1
				block.accno1 = query.GetFieldData(block.GetBlockName(), "accno1").TrimEnd('?'); // char 12
				block.qty2 = query.GetFieldData(block.GetBlockName(), "qty2").ParseLong("qty2"); // long 10
				block.price = query.GetFieldData(block.GetBlockName(), "price").ParseFloat("price"); // float 11.2
				block.ordgb = query.GetFieldData(block.GetBlockName(), "ordgb").FirstOrDefault(); // char 1
				block.hogagb = query.GetFieldData(block.GetBlockName(), "hogagb").FirstOrDefault(); // char 1
				block.sihogagb = query.GetFieldData(block.GetBlockName(), "sihogagb").TrimEnd('?'); // char 11
				block.tradid = query.GetFieldData(block.GetBlockName(), "tradid").TrimEnd('?'); // char 5
				block.treacode = query.GetFieldData(block.GetBlockName(), "treacode").FirstOrDefault(); // char 1
				block.askcode = query.GetFieldData(block.GetBlockName(), "askcode").TrimEnd('?'); // char 2
				block.creditcode = query.GetFieldData(block.GetBlockName(), "creditcode").TrimEnd('?'); // char 2
				block.jakigb = query.GetFieldData(block.GetBlockName(), "jakigb").TrimEnd('?'); // char 2
				block.trustnum = query.GetFieldData(block.GetBlockName(), "trustnum").TrimEnd('?'); // char 5
				block.ptgb = query.GetFieldData(block.GetBlockName(), "ptgb").TrimEnd('?'); // char 2
				block.substonum = query.GetFieldData(block.GetBlockName(), "substonum").TrimEnd('?'); // char 12
				block.accgb = query.GetFieldData(block.GetBlockName(), "accgb").TrimEnd('?'); // char 2
				block.accmarggb = query.GetFieldData(block.GetBlockName(), "accmarggb").TrimEnd('?'); // char 2
				block.nationcode = query.GetFieldData(block.GetBlockName(), "nationcode").TrimEnd('?'); // char 3
				block.investgb = query.GetFieldData(block.GetBlockName(), "investgb").TrimEnd('?'); // char 4
				block.forecode = query.GetFieldData(block.GetBlockName(), "forecode").TrimEnd('?'); // char 2
				block.medcode = query.GetFieldData(block.GetBlockName(), "medcode").FirstOrDefault(); // char 1
				block.ordid = query.GetFieldData(block.GetBlockName(), "ordid").TrimEnd('?'); // char 12
				block.macid = query.GetFieldData(block.GetBlockName(), "macid").TrimEnd('?'); // char 12
				block.orddate = query.GetFieldData(block.GetBlockName(), "orddate").TrimEnd('?'); // char 8
				block.rcvtime = query.GetFieldData(block.GetBlockName(), "rcvtime").TrimEnd('?'); // char 9
				block.mem_filler = query.GetFieldData(block.GetBlockName(), "mem_filler").TrimEnd('?'); // char 7
				block.mem_accno = query.GetFieldData(block.GetBlockName(), "mem_accno").TrimEnd('?'); // char 11
				block.mem_filler1 = query.GetFieldData(block.GetBlockName(), "mem_filler1").TrimEnd('?'); // char 42
				block.ordacpttm = query.GetFieldData(block.GetBlockName(), "ordacpttm").TrimEnd('?'); // char 9
				block.qty = query.GetFieldData(block.GetBlockName(), "qty").ParseLong("qty"); // long 10
				block.autogb = query.GetFieldData(block.GetBlockName(), "autogb").FirstOrDefault(); // char 1
				block.rejcode = query.GetFieldData(block.GetBlockName(), "rejcode").TrimEnd('?'); // char 4
				block.prgordde = query.GetFieldData(block.GetBlockName(), "prgordde").FirstOrDefault(); // char 1

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
			// dosugb char 1
			// mocagb char 1
			if (accno1?.Length > 12) return false; // char 12
			if (qty2.ToString().Length > 10) return false; // long 10
			// price float 11.2
			// ordgb char 1
			// hogagb char 1
			if (sihogagb?.Length > 11) return false; // char 11
			if (tradid?.Length > 5) return false; // char 5
			// treacode char 1
			if (askcode?.Length > 2) return false; // char 2
			if (creditcode?.Length > 2) return false; // char 2
			if (jakigb?.Length > 2) return false; // char 2
			if (trustnum?.Length > 5) return false; // char 5
			if (ptgb?.Length > 2) return false; // char 2
			if (substonum?.Length > 12) return false; // char 12
			if (accgb?.Length > 2) return false; // char 2
			if (accmarggb?.Length > 2) return false; // char 2
			if (nationcode?.Length > 3) return false; // char 3
			if (investgb?.Length > 4) return false; // char 4
			if (forecode?.Length > 2) return false; // char 2
			// medcode char 1
			if (ordid?.Length > 12) return false; // char 12
			if (macid?.Length > 12) return false; // char 12
			if (orddate?.Length > 8) return false; // char 8
			if (rcvtime?.Length > 9) return false; // char 9
			if (mem_filler?.Length > 7) return false; // char 7
			if (mem_accno?.Length > 11) return false; // char 11
			if (mem_filler1?.Length > 42) return false; // char 42
			if (ordacpttm?.Length > 9) return false; // char 9
			if (qty.ToString().Length > 10) return false; // long 10
			// autogb char 1
			if (rejcode?.Length > 4) return false; // char 4
			// prgordde char 1

			return true;
		}
	}

	public partial class XRH01 : XingReal
	{
		/// <summary>
		/// H01
		/// </summary>
		public const string _typeName = "H01";
		/// <summary>
		/// 선물주문정정취소
		/// </summary>
		public const string _typeDesc = "선물주문정정취소";
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
		/// H01
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 선물주문정정취소
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

		public XRH01() : base("H01") { }


		public bool SetFields(XRH01InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}


			return true;
		}

		public XRH01OutBlock GetBlock()
		{
			XRH01OutBlock instance = XRH01OutBlock.FromQuery(this);
			return instance;

		}


	}

}
