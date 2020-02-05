using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt3320InBlock : XingBlock
	{
		/// <summary>
		/// t3320InBlock
		/// </summary>
		public const string _blockName = "t3320InBlock";
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
		/// t3320InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t3320InBlock
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
		/// 종목코드
		/// </summary>
		[XAQueryFieldAttribute("종목코드")]
		public string gicode;

		public static class F
		{
			/// <summary>
			/// 종목코드
			/// </summary>
			public const string gicode = "gicode";
		}

		public static string[] AllFields = new string[]
		{
			F.gicode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["gicode"] = new XAQueryFieldInfo("char", gicode, gicode, "종목코드", (decimal)7);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "gicode":
					this.gicode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (gicode?.Length > 7) return false; // char 7

			return true;
		}
	}

	public partial class XQt3320OutBlock : XingBlock
	{
		/// <summary>
		/// t3320OutBlock
		/// </summary>
		public const string _blockName = "t3320OutBlock";
		/// <summary>
		/// 기업기본정보
		/// </summary>
		public const string _blockDesc = "기업기본정보";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// false
		/// </summary>
		public const bool _hasOccurs = false;
		/// <summary>
		/// t3320OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t3320OutBlock
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// 기업기본정보
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
		/// 업종구분명
		/// </summary>
		[XAQueryFieldAttribute("업종구분명")]
		public string upgubunnm;
		/// <summary>
		/// 시장구분
		/// </summary>
		[XAQueryFieldAttribute("시장구분")]
		public char sijangcd;
		/// <summary>
		/// 시장구분명
		/// </summary>
		[XAQueryFieldAttribute("시장구분명")]
		public string marketnm;
		/// <summary>
		/// 한글기업명
		/// </summary>
		[XAQueryFieldAttribute("한글기업명")]
		public string company;
		/// <summary>
		/// 본사주소
		/// </summary>
		[XAQueryFieldAttribute("본사주소")]
		public string baddress;
		/// <summary>
		/// 본사전화번호
		/// </summary>
		[XAQueryFieldAttribute("본사전화번호")]
		public string btelno;
		/// <summary>
		/// 최근결산년도
		/// </summary>
		[XAQueryFieldAttribute("최근결산년도")]
		public string gsyyyy;
		/// <summary>
		/// 결산월
		/// </summary>
		[XAQueryFieldAttribute("결산월")]
		public string gsmm;
		/// <summary>
		/// 최근결산년월
		/// </summary>
		[XAQueryFieldAttribute("최근결산년월")]
		public string gsym;
		/// <summary>
		/// 주당액면가
		/// </summary>
		[XAQueryFieldAttribute("주당액면가")]
		public long lstprice;
		/// <summary>
		/// 주식수
		/// </summary>
		[XAQueryFieldAttribute("주식수")]
		public long gstock;
		/// <summary>
		/// Homepage
		/// </summary>
		[XAQueryFieldAttribute("Homepage")]
		public string homeurl;
		/// <summary>
		/// 그룹명
		/// </summary>
		[XAQueryFieldAttribute("그룹명")]
		public string grdnm;
		/// <summary>
		/// 외국인
		/// </summary>
		[XAQueryFieldAttribute("외국인")]
		public float foreignratio;
		/// <summary>
		/// 주담전화
		/// </summary>
		[XAQueryFieldAttribute("주담전화")]
		public string irtel;
		/// <summary>
		/// 자본금
		/// </summary>
		[XAQueryFieldAttribute("자본금")]
		public float capital;
		/// <summary>
		/// 시가총액
		/// </summary>
		[XAQueryFieldAttribute("시가총액")]
		public float sigavalue;
		/// <summary>
		/// 배당금
		/// </summary>
		[XAQueryFieldAttribute("배당금")]
		public float cashsis;
		/// <summary>
		/// 배당수익율
		/// </summary>
		[XAQueryFieldAttribute("배당수익율")]
		public float cashrate;
		/// <summary>
		/// 현재가
		/// </summary>
		[XAQueryFieldAttribute("현재가")]
		public long price;
		/// <summary>
		/// 전일종가
		/// </summary>
		[XAQueryFieldAttribute("전일종가")]
		public long jnilclose;

		public static class F
		{
			/// <summary>
			/// 업종구분명
			/// </summary>
			public const string upgubunnm = "upgubunnm";
			/// <summary>
			/// 시장구분
			/// </summary>
			public const string sijangcd = "sijangcd";
			/// <summary>
			/// 시장구분명
			/// </summary>
			public const string marketnm = "marketnm";
			/// <summary>
			/// 한글기업명
			/// </summary>
			public const string company = "company";
			/// <summary>
			/// 본사주소
			/// </summary>
			public const string baddress = "baddress";
			/// <summary>
			/// 본사전화번호
			/// </summary>
			public const string btelno = "btelno";
			/// <summary>
			/// 최근결산년도
			/// </summary>
			public const string gsyyyy = "gsyyyy";
			/// <summary>
			/// 결산월
			/// </summary>
			public const string gsmm = "gsmm";
			/// <summary>
			/// 최근결산년월
			/// </summary>
			public const string gsym = "gsym";
			/// <summary>
			/// 주당액면가
			/// </summary>
			public const string lstprice = "lstprice";
			/// <summary>
			/// 주식수
			/// </summary>
			public const string gstock = "gstock";
			/// <summary>
			/// Homepage
			/// </summary>
			public const string homeurl = "homeurl";
			/// <summary>
			/// 그룹명
			/// </summary>
			public const string grdnm = "grdnm";
			/// <summary>
			/// 외국인
			/// </summary>
			public const string foreignratio = "foreignratio";
			/// <summary>
			/// 주담전화
			/// </summary>
			public const string irtel = "irtel";
			/// <summary>
			/// 자본금
			/// </summary>
			public const string capital = "capital";
			/// <summary>
			/// 시가총액
			/// </summary>
			public const string sigavalue = "sigavalue";
			/// <summary>
			/// 배당금
			/// </summary>
			public const string cashsis = "cashsis";
			/// <summary>
			/// 배당수익율
			/// </summary>
			public const string cashrate = "cashrate";
			/// <summary>
			/// 현재가
			/// </summary>
			public const string price = "price";
			/// <summary>
			/// 전일종가
			/// </summary>
			public const string jnilclose = "jnilclose";
		}

		public static string[] AllFields = new string[]
		{
			F.upgubunnm,
			F.sijangcd,
			F.marketnm,
			F.company,
			F.baddress,
			F.btelno,
			F.gsyyyy,
			F.gsmm,
			F.gsym,
			F.lstprice,
			F.gstock,
			F.homeurl,
			F.grdnm,
			F.foreignratio,
			F.irtel,
			F.capital,
			F.sigavalue,
			F.cashsis,
			F.cashrate,
			F.price,
			F.jnilclose,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["upgubunnm"] = new XAQueryFieldInfo("char", upgubunnm, upgubunnm, "업종구분명", (decimal)20);
			dict["sijangcd"] = new XAQueryFieldInfo("char", sijangcd, sijangcd.ToString(), "시장구분", (decimal)1);
			dict["marketnm"] = new XAQueryFieldInfo("char", marketnm, marketnm, "시장구분명", (decimal)10);
			dict["company"] = new XAQueryFieldInfo("char", company, company, "한글기업명", (decimal)100);
			dict["baddress"] = new XAQueryFieldInfo("char", baddress, baddress, "본사주소", (decimal)100);
			dict["btelno"] = new XAQueryFieldInfo("char", btelno, btelno, "본사전화번호", (decimal)20);
			dict["gsyyyy"] = new XAQueryFieldInfo("char", gsyyyy, gsyyyy, "최근결산년도", (decimal)4);
			dict["gsmm"] = new XAQueryFieldInfo("char", gsmm, gsmm, "결산월", (decimal)2);
			dict["gsym"] = new XAQueryFieldInfo("char", gsym, gsym, "최근결산년월", (decimal)6);
			dict["lstprice"] = new XAQueryFieldInfo("long", lstprice, lstprice.ToString("d12"), "주당액면가", (decimal)12);
			dict["gstock"] = new XAQueryFieldInfo("long", gstock, gstock.ToString("d12"), "주식수", (decimal)12);
			dict["homeurl"] = new XAQueryFieldInfo("char", homeurl, homeurl, "Homepage", (decimal)50);
			dict["grdnm"] = new XAQueryFieldInfo("char", grdnm, grdnm, "그룹명", (decimal)30);
			dict["foreignratio"] = new XAQueryFieldInfo("float", foreignratio, foreignratio.ToString("000000.00"), "외국인", (decimal)6.2);
			dict["irtel"] = new XAQueryFieldInfo("char", irtel, irtel, "주담전화", (decimal)30);
			dict["capital"] = new XAQueryFieldInfo("float", capital, capital.ToString("000000000000."), "자본금", (decimal)12.0);
			dict["sigavalue"] = new XAQueryFieldInfo("float", sigavalue, sigavalue.ToString("000000000000."), "시가총액", (decimal)12.0);
			dict["cashsis"] = new XAQueryFieldInfo("float", cashsis, cashsis.ToString("000000000000."), "배당금", (decimal)12.0);
			dict["cashrate"] = new XAQueryFieldInfo("float", cashrate, cashrate.ToString("0000000000000.00"), "배당수익율", (decimal)13.2);
			dict["price"] = new XAQueryFieldInfo("long", price, price.ToString("d8"), "현재가", (decimal)8);
			dict["jnilclose"] = new XAQueryFieldInfo("long", jnilclose, jnilclose.ToString("d8"), "전일종가", (decimal)8);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "upgubunnm":
					this.upgubunnm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "sijangcd":
					this.sijangcd = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "marketnm":
					this.marketnm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "company":
					this.company = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "baddress":
					this.baddress = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "btelno":
					this.btelno = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "gsyyyy":
					this.gsyyyy = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "gsmm":
					this.gsmm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "gsym":
					this.gsym = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "lstprice":
					this.lstprice = fieldInfo.FieldValue.ParseLong("lstprice");
				break;

				case "gstock":
					this.gstock = fieldInfo.FieldValue.ParseLong("gstock");
				break;

				case "homeurl":
					this.homeurl = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "grdnm":
					this.grdnm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "foreignratio":
					this.foreignratio = fieldInfo.FieldValue.ParseFloat("foreignratio");
				break;

				case "irtel":
					this.irtel = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "capital":
					this.capital = fieldInfo.FieldValue.ParseFloat("capital");
				break;

				case "sigavalue":
					this.sigavalue = fieldInfo.FieldValue.ParseFloat("sigavalue");
				break;

				case "cashsis":
					this.cashsis = fieldInfo.FieldValue.ParseFloat("cashsis");
				break;

				case "cashrate":
					this.cashrate = fieldInfo.FieldValue.ParseFloat("cashrate");
				break;

				case "price":
					this.price = fieldInfo.FieldValue.ParseLong("price");
				break;

				case "jnilclose":
					this.jnilclose = fieldInfo.FieldValue.ParseLong("jnilclose");
				break;


			}
		}

		public static XQt3320OutBlock FromQuery(XQt3320 query)
		{
			XQt3320OutBlock block = new XQt3320OutBlock();
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
				block.upgubunnm = query.GetFieldData(block.GetBlockName(), "upgubunnm", 0).TrimEnd('?'); // char 20
				block.sijangcd = query.GetFieldData(block.GetBlockName(), "sijangcd", 0).FirstOrDefault(); // char 1
				block.marketnm = query.GetFieldData(block.GetBlockName(), "marketnm", 0).TrimEnd('?'); // char 10
				block.company = query.GetFieldData(block.GetBlockName(), "company", 0).TrimEnd('?'); // char 100
				block.baddress = query.GetFieldData(block.GetBlockName(), "baddress", 0).TrimEnd('?'); // char 100
				block.btelno = query.GetFieldData(block.GetBlockName(), "btelno", 0).TrimEnd('?'); // char 20
				block.gsyyyy = query.GetFieldData(block.GetBlockName(), "gsyyyy", 0).TrimEnd('?'); // char 4
				block.gsmm = query.GetFieldData(block.GetBlockName(), "gsmm", 0).TrimEnd('?'); // char 2
				block.gsym = query.GetFieldData(block.GetBlockName(), "gsym", 0).TrimEnd('?'); // char 6
				block.lstprice = query.GetFieldData(block.GetBlockName(), "lstprice", 0).ParseLong("lstprice"); // long 12
				block.gstock = query.GetFieldData(block.GetBlockName(), "gstock", 0).ParseLong("gstock"); // long 12
				block.homeurl = query.GetFieldData(block.GetBlockName(), "homeurl", 0).TrimEnd('?'); // char 50
				block.grdnm = query.GetFieldData(block.GetBlockName(), "grdnm", 0).TrimEnd('?'); // char 30
				block.foreignratio = query.GetFieldData(block.GetBlockName(), "foreignratio", 0).ParseFloat("foreignratio"); // float 6.2
				block.irtel = query.GetFieldData(block.GetBlockName(), "irtel", 0).TrimEnd('?'); // char 30
				block.capital = query.GetFieldData(block.GetBlockName(), "capital", 0).ParseFloat("capital"); // float 12.0
				block.sigavalue = query.GetFieldData(block.GetBlockName(), "sigavalue", 0).ParseFloat("sigavalue"); // float 12.0
				block.cashsis = query.GetFieldData(block.GetBlockName(), "cashsis", 0).ParseFloat("cashsis"); // float 12.0
				block.cashrate = query.GetFieldData(block.GetBlockName(), "cashrate", 0).ParseFloat("cashrate"); // float 13.2
				block.price = query.GetFieldData(block.GetBlockName(), "price", 0).ParseLong("price"); // long 8
				block.jnilclose = query.GetFieldData(block.GetBlockName(), "jnilclose", 0).ParseLong("jnilclose"); // long 8

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (upgubunnm?.Length > 20) return false; // char 20
			// sijangcd char 1
			if (marketnm?.Length > 10) return false; // char 10
			if (company?.Length > 100) return false; // char 100
			if (baddress?.Length > 100) return false; // char 100
			if (btelno?.Length > 20) return false; // char 20
			if (gsyyyy?.Length > 4) return false; // char 4
			if (gsmm?.Length > 2) return false; // char 2
			if (gsym?.Length > 6) return false; // char 6
			if (lstprice.ToString().Length > 12) return false; // long 12
			if (gstock.ToString().Length > 12) return false; // long 12
			if (homeurl?.Length > 50) return false; // char 50
			if (grdnm?.Length > 30) return false; // char 30
			// foreignratio float 6.2
			if (irtel?.Length > 30) return false; // char 30
			// capital float 12.0
			// sigavalue float 12.0
			// cashsis float 12.0
			// cashrate float 13.2
			if (price.ToString().Length > 8) return false; // long 8
			if (jnilclose.ToString().Length > 8) return false; // long 8

			return true;
		}
	}

	public partial class XQt3320OutBlock1 : XingBlock
	{
		/// <summary>
		/// t3320OutBlock1
		/// </summary>
		public const string _blockName = "t3320OutBlock1";
		/// <summary>
		/// 기업재무정보
		/// </summary>
		public const string _blockDesc = "기업재무정보";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// false
		/// </summary>
		public const bool _hasOccurs = false;
		/// <summary>
		/// t3320OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t3320OutBlock1
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// 기업재무정보
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
		/// 기업코드
		/// </summary>
		[XAQueryFieldAttribute("기업코드")]
		public string gicode;
		/// <summary>
		/// 결산년월
		/// </summary>
		[XAQueryFieldAttribute("결산년월")]
		public string gsym;
		/// <summary>
		/// 결산구분
		/// </summary>
		[XAQueryFieldAttribute("결산구분")]
		public char gsgb;
		/// <summary>
		/// PER
		/// </summary>
		[XAQueryFieldAttribute("PER")]
		public float per;
		/// <summary>
		/// EPS
		/// </summary>
		[XAQueryFieldAttribute("EPS")]
		public float eps;
		/// <summary>
		/// PBR
		/// </summary>
		[XAQueryFieldAttribute("PBR")]
		public float pbr;
		/// <summary>
		/// ROA
		/// </summary>
		[XAQueryFieldAttribute("ROA")]
		public float roa;
		/// <summary>
		/// ROE
		/// </summary>
		[XAQueryFieldAttribute("ROE")]
		public float roe;
		/// <summary>
		/// EBITDA
		/// </summary>
		[XAQueryFieldAttribute("EBITDA")]
		public float ebitda;
		/// <summary>
		/// EVEBITDA
		/// </summary>
		[XAQueryFieldAttribute("EVEBITDA")]
		public float evebitda;
		/// <summary>
		/// 액면가
		/// </summary>
		[XAQueryFieldAttribute("액면가")]
		public float par;
		/// <summary>
		/// SPS
		/// </summary>
		[XAQueryFieldAttribute("SPS")]
		public float sps;
		/// <summary>
		/// CPS
		/// </summary>
		[XAQueryFieldAttribute("CPS")]
		public float cps;
		/// <summary>
		/// BPS
		/// </summary>
		[XAQueryFieldAttribute("BPS")]
		public float bps;
		/// <summary>
		/// T.PER
		/// </summary>
		[XAQueryFieldAttribute("T.PER")]
		public float t_per;
		/// <summary>
		/// T.EPS
		/// </summary>
		[XAQueryFieldAttribute("T.EPS")]
		public float t_eps;
		/// <summary>
		/// PEG
		/// </summary>
		[XAQueryFieldAttribute("PEG")]
		public float peg;
		/// <summary>
		/// T.PEG
		/// </summary>
		[XAQueryFieldAttribute("T.PEG")]
		public float t_peg;
		/// <summary>
		/// 최근분기년도
		/// </summary>
		[XAQueryFieldAttribute("최근분기년도")]
		public string t_gsym;

		public static class F
		{
			/// <summary>
			/// 기업코드
			/// </summary>
			public const string gicode = "gicode";
			/// <summary>
			/// 결산년월
			/// </summary>
			public const string gsym = "gsym";
			/// <summary>
			/// 결산구분
			/// </summary>
			public const string gsgb = "gsgb";
			/// <summary>
			/// PER
			/// </summary>
			public const string per = "per";
			/// <summary>
			/// EPS
			/// </summary>
			public const string eps = "eps";
			/// <summary>
			/// PBR
			/// </summary>
			public const string pbr = "pbr";
			/// <summary>
			/// ROA
			/// </summary>
			public const string roa = "roa";
			/// <summary>
			/// ROE
			/// </summary>
			public const string roe = "roe";
			/// <summary>
			/// EBITDA
			/// </summary>
			public const string ebitda = "ebitda";
			/// <summary>
			/// EVEBITDA
			/// </summary>
			public const string evebitda = "evebitda";
			/// <summary>
			/// 액면가
			/// </summary>
			public const string par = "par";
			/// <summary>
			/// SPS
			/// </summary>
			public const string sps = "sps";
			/// <summary>
			/// CPS
			/// </summary>
			public const string cps = "cps";
			/// <summary>
			/// BPS
			/// </summary>
			public const string bps = "bps";
			/// <summary>
			/// T.PER
			/// </summary>
			public const string t_per = "t_per";
			/// <summary>
			/// T.EPS
			/// </summary>
			public const string t_eps = "t_eps";
			/// <summary>
			/// PEG
			/// </summary>
			public const string peg = "peg";
			/// <summary>
			/// T.PEG
			/// </summary>
			public const string t_peg = "t_peg";
			/// <summary>
			/// 최근분기년도
			/// </summary>
			public const string t_gsym = "t_gsym";
		}

		public static string[] AllFields = new string[]
		{
			F.gicode,
			F.gsym,
			F.gsgb,
			F.per,
			F.eps,
			F.pbr,
			F.roa,
			F.roe,
			F.ebitda,
			F.evebitda,
			F.par,
			F.sps,
			F.cps,
			F.bps,
			F.t_per,
			F.t_eps,
			F.peg,
			F.t_peg,
			F.t_gsym,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["gicode"] = new XAQueryFieldInfo("char", gicode, gicode, "기업코드", (decimal)7);
			dict["gsym"] = new XAQueryFieldInfo("char", gsym, gsym, "결산년월", (decimal)6);
			dict["gsgb"] = new XAQueryFieldInfo("char", gsgb, gsgb.ToString(), "결산구분", (decimal)1);
			dict["per"] = new XAQueryFieldInfo("float", per, per.ToString("0000000000000.00"), "PER", (decimal)13.2);
			dict["eps"] = new XAQueryFieldInfo("float", eps, eps.ToString("0000000000000."), "EPS", (decimal)13.0);
			dict["pbr"] = new XAQueryFieldInfo("float", pbr, pbr.ToString("0000000000000.00"), "PBR", (decimal)13.2);
			dict["roa"] = new XAQueryFieldInfo("float", roa, roa.ToString("0000000000000.00"), "ROA", (decimal)13.2);
			dict["roe"] = new XAQueryFieldInfo("float", roe, roe.ToString("0000000000000.00"), "ROE", (decimal)13.2);
			dict["ebitda"] = new XAQueryFieldInfo("float", ebitda, ebitda.ToString("0000000000000.00"), "EBITDA", (decimal)13.2);
			dict["evebitda"] = new XAQueryFieldInfo("float", evebitda, evebitda.ToString("0000000000000.00"), "EVEBITDA", (decimal)13.2);
			dict["par"] = new XAQueryFieldInfo("float", par, par.ToString("0000000000000.00"), "액면가", (decimal)13.2);
			dict["sps"] = new XAQueryFieldInfo("float", sps, sps.ToString("0000000000000.00"), "SPS", (decimal)13.2);
			dict["cps"] = new XAQueryFieldInfo("float", cps, cps.ToString("0000000000000.00"), "CPS", (decimal)13.2);
			dict["bps"] = new XAQueryFieldInfo("float", bps, bps.ToString("0000000000000."), "BPS", (decimal)13.0);
			dict["t_per"] = new XAQueryFieldInfo("float", t_per, t_per.ToString("0000000000000.00"), "T.PER", (decimal)13.2);
			dict["t_eps"] = new XAQueryFieldInfo("float", t_eps, t_eps.ToString("0000000000000."), "T.EPS", (decimal)13.0);
			dict["peg"] = new XAQueryFieldInfo("float", peg, peg.ToString("0000000000000.00"), "PEG", (decimal)13.2);
			dict["t_peg"] = new XAQueryFieldInfo("float", t_peg, t_peg.ToString("0000000000000.00"), "T.PEG", (decimal)13.2);
			dict["t_gsym"] = new XAQueryFieldInfo("char", t_gsym, t_gsym, "최근분기년도", (decimal)6);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "gicode":
					this.gicode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "gsym":
					this.gsym = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "gsgb":
					this.gsgb = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "per":
					this.per = fieldInfo.FieldValue.ParseFloat("per");
				break;

				case "eps":
					this.eps = fieldInfo.FieldValue.ParseFloat("eps");
				break;

				case "pbr":
					this.pbr = fieldInfo.FieldValue.ParseFloat("pbr");
				break;

				case "roa":
					this.roa = fieldInfo.FieldValue.ParseFloat("roa");
				break;

				case "roe":
					this.roe = fieldInfo.FieldValue.ParseFloat("roe");
				break;

				case "ebitda":
					this.ebitda = fieldInfo.FieldValue.ParseFloat("ebitda");
				break;

				case "evebitda":
					this.evebitda = fieldInfo.FieldValue.ParseFloat("evebitda");
				break;

				case "par":
					this.par = fieldInfo.FieldValue.ParseFloat("par");
				break;

				case "sps":
					this.sps = fieldInfo.FieldValue.ParseFloat("sps");
				break;

				case "cps":
					this.cps = fieldInfo.FieldValue.ParseFloat("cps");
				break;

				case "bps":
					this.bps = fieldInfo.FieldValue.ParseFloat("bps");
				break;

				case "t_per":
					this.t_per = fieldInfo.FieldValue.ParseFloat("t_per");
				break;

				case "t_eps":
					this.t_eps = fieldInfo.FieldValue.ParseFloat("t_eps");
				break;

				case "peg":
					this.peg = fieldInfo.FieldValue.ParseFloat("peg");
				break;

				case "t_peg":
					this.t_peg = fieldInfo.FieldValue.ParseFloat("t_peg");
				break;

				case "t_gsym":
					this.t_gsym = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt3320OutBlock1 FromQuery(XQt3320 query)
		{
			XQt3320OutBlock1 block = new XQt3320OutBlock1();
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
				block.gicode = query.GetFieldData(block.GetBlockName(), "gicode", 0).TrimEnd('?'); // char 7
				block.gsym = query.GetFieldData(block.GetBlockName(), "gsym", 0).TrimEnd('?'); // char 6
				block.gsgb = query.GetFieldData(block.GetBlockName(), "gsgb", 0).FirstOrDefault(); // char 1
				block.per = query.GetFieldData(block.GetBlockName(), "per", 0).ParseFloat("per"); // float 13.2
				block.eps = query.GetFieldData(block.GetBlockName(), "eps", 0).ParseFloat("eps"); // float 13.0
				block.pbr = query.GetFieldData(block.GetBlockName(), "pbr", 0).ParseFloat("pbr"); // float 13.2
				block.roa = query.GetFieldData(block.GetBlockName(), "roa", 0).ParseFloat("roa"); // float 13.2
				block.roe = query.GetFieldData(block.GetBlockName(), "roe", 0).ParseFloat("roe"); // float 13.2
				block.ebitda = query.GetFieldData(block.GetBlockName(), "ebitda", 0).ParseFloat("ebitda"); // float 13.2
				block.evebitda = query.GetFieldData(block.GetBlockName(), "evebitda", 0).ParseFloat("evebitda"); // float 13.2
				block.par = query.GetFieldData(block.GetBlockName(), "par", 0).ParseFloat("par"); // float 13.2
				block.sps = query.GetFieldData(block.GetBlockName(), "sps", 0).ParseFloat("sps"); // float 13.2
				block.cps = query.GetFieldData(block.GetBlockName(), "cps", 0).ParseFloat("cps"); // float 13.2
				block.bps = query.GetFieldData(block.GetBlockName(), "bps", 0).ParseFloat("bps"); // float 13.0
				block.t_per = query.GetFieldData(block.GetBlockName(), "t_per", 0).ParseFloat("t_per"); // float 13.2
				block.t_eps = query.GetFieldData(block.GetBlockName(), "t_eps", 0).ParseFloat("t_eps"); // float 13.0
				block.peg = query.GetFieldData(block.GetBlockName(), "peg", 0).ParseFloat("peg"); // float 13.2
				block.t_peg = query.GetFieldData(block.GetBlockName(), "t_peg", 0).ParseFloat("t_peg"); // float 13.2
				block.t_gsym = query.GetFieldData(block.GetBlockName(), "t_gsym", 0).TrimEnd('?'); // char 6

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (gicode?.Length > 7) return false; // char 7
			if (gsym?.Length > 6) return false; // char 6
			// gsgb char 1
			// per float 13.2
			// eps float 13.0
			// pbr float 13.2
			// roa float 13.2
			// roe float 13.2
			// ebitda float 13.2
			// evebitda float 13.2
			// par float 13.2
			// sps float 13.2
			// cps float 13.2
			// bps float 13.0
			// t_per float 13.2
			// t_eps float 13.0
			// peg float 13.2
			// t_peg float 13.2
			if (t_gsym?.Length > 6) return false; // char 6

			return true;
		}
	}

	public partial class XQt3320 : XingQuery
	{
		/// <summary>
		/// t3320
		/// </summary>
		public const string _typeName = "t3320";
		/// <summary>
		/// FNG_요약(t3320)
		/// </summary>
		public const string _typeDesc = "FNG_요약(t3320)";
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
		/// t3320
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// FNG_요약(t3320)
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

		public XQt3320() : base("t3320") { }



		public bool SetBlock(XQt3320InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "gicode", 0, block.gicode); // char 7

			return true;
		}

		public XQt3320OutBlock GetBlock()
		{
			XQt3320OutBlock instance = XQt3320OutBlock.FromQuery(this);
			return instance;

		}

		public XQt3320OutBlock1 GetBlock1()
		{
			XQt3320OutBlock1 instance = XQt3320OutBlock1.FromQuery(this);
			return instance;

		}


	}

}
