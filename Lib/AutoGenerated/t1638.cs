using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1638InBlock : XingBlock
	{
		/// <summary>
		/// t1638InBlock
		/// </summary>
		public const string _blockName = "t1638InBlock";
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
		/// t1638InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1638InBlock
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
		/// 구분
		/// </summary>
		[XAQueryFieldAttribute("구분", "1")]
		public char gubun1;
		/// <summary>
		/// 종목코드
		/// </summary>
		[XAQueryFieldAttribute("종목코드", "6")]
		public string shcode;
		/// <summary>
		/// 정렬
		/// </summary>
		[XAQueryFieldAttribute("정렬", "1")]
		public char gubun2;

		public static class F
		{
			/// <summary>
			/// 구분
			/// </summary>
			public const string gubun1 = "gubun1";
			/// <summary>
			/// 종목코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 정렬
			/// </summary>
			public const string gubun2 = "gubun2";
		}

		public static string[] AllFields = new string[]
		{
			F.gubun1,
			F.shcode,
			F.gubun2,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["gubun1"] = new XAQueryFieldInfo("char", gubun1, gubun1.ToString(), "구분", (decimal)1);
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "종목코드", (decimal)6);
			dict["gubun2"] = new XAQueryFieldInfo("char", gubun2, gubun2.ToString(), "정렬", (decimal)1);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "gubun1":
					this.gubun1 = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "gubun2":
					this.gubun2 = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public bool VerifyData()
		{
			// gubun1 char 1
			if (shcode?.Length > 6) return false; // char 6
			// gubun2 char 1

			return true;
		}
	}

	public partial class XQt1638OutBlock : XingBlock
	{
		/// <summary>
		/// t1638OutBlock
		/// </summary>
		public const string _blockName = "t1638OutBlock";
		/// <summary>
		/// 출력
		/// </summary>
		public const string _blockDesc = "출력";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// true
		/// </summary>
		public const bool _hasOccurs = true;
		/// <summary>
		/// t1638OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1638OutBlock
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
		/// true
		/// </summary>
		public bool HasOccurs => _hasOccurs;

		/// <summary>
		/// 순위
		/// </summary>
		[XAQueryFieldAttribute("순위", "4")]
		public long rank;
		/// <summary>
		/// 한글명
		/// </summary>
		[XAQueryFieldAttribute("한글명", "20")]
		public string hname;
		/// <summary>
		/// 현재가
		/// </summary>
		[XAQueryFieldAttribute("현재가", "8")]
		public long price;
		/// <summary>
		/// 전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("전일대비구분", "1")]
		public char sign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[XAQueryFieldAttribute("전일대비", "8")]
		public long change;
		/// <summary>
		/// 등락율
		/// </summary>
		[XAQueryFieldAttribute("등락율", "6.2")]
		public float diff;
		/// <summary>
		/// 시총비중
		/// </summary>
		[XAQueryFieldAttribute("시총비중", "6.2")]
		public float sigatotrt;
		/// <summary>
		/// 순매수잔량
		/// </summary>
		[XAQueryFieldAttribute("순매수잔량", "12")]
		public long obuyvol;
		/// <summary>
		/// 매수잔량
		/// </summary>
		[XAQueryFieldAttribute("매수잔량", "12")]
		public long buyrem;
		/// <summary>
		/// 매수공시수량
		/// </summary>
		[XAQueryFieldAttribute("매수공시수량", "12")]
		public long psgvolume;
		/// <summary>
		/// 매도잔량
		/// </summary>
		[XAQueryFieldAttribute("매도잔량", "12")]
		public long sellrem;
		/// <summary>
		/// 매도공시수량
		/// </summary>
		[XAQueryFieldAttribute("매도공시수량", "12")]
		public long pdgvolume;
		/// <summary>
		/// 시가총액
		/// </summary>
		[XAQueryFieldAttribute("시가총액", "20")]
		public long sigatot;
		/// <summary>
		/// 종목코드
		/// </summary>
		[XAQueryFieldAttribute("종목코드", "6")]
		public string shcode;

		public static class F
		{
			/// <summary>
			/// 순위
			/// </summary>
			public const string rank = "rank";
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
			/// 시총비중
			/// </summary>
			public const string sigatotrt = "sigatotrt";
			/// <summary>
			/// 순매수잔량
			/// </summary>
			public const string obuyvol = "obuyvol";
			/// <summary>
			/// 매수잔량
			/// </summary>
			public const string buyrem = "buyrem";
			/// <summary>
			/// 매수공시수량
			/// </summary>
			public const string psgvolume = "psgvolume";
			/// <summary>
			/// 매도잔량
			/// </summary>
			public const string sellrem = "sellrem";
			/// <summary>
			/// 매도공시수량
			/// </summary>
			public const string pdgvolume = "pdgvolume";
			/// <summary>
			/// 시가총액
			/// </summary>
			public const string sigatot = "sigatot";
			/// <summary>
			/// 종목코드
			/// </summary>
			public const string shcode = "shcode";
		}

		public static string[] AllFields = new string[]
		{
			F.rank,
			F.hname,
			F.price,
			F.sign,
			F.change,
			F.diff,
			F.sigatotrt,
			F.obuyvol,
			F.buyrem,
			F.psgvolume,
			F.sellrem,
			F.pdgvolume,
			F.sigatot,
			F.shcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["rank"] = new XAQueryFieldInfo("long", rank, rank.ToString("d4"), "순위", (decimal)4);
			dict["hname"] = new XAQueryFieldInfo("char", hname, hname, "한글명", (decimal)20);
			dict["price"] = new XAQueryFieldInfo("long", price, price.ToString("d8"), "현재가", (decimal)8);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("long", change, change.ToString("d8"), "전일대비", (decimal)8);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["sigatotrt"] = new XAQueryFieldInfo("float", sigatotrt, sigatotrt.ToString("000000.00"), "시총비중", (decimal)6.2);
			dict["obuyvol"] = new XAQueryFieldInfo("long", obuyvol, obuyvol.ToString("d12"), "순매수잔량", (decimal)12);
			dict["buyrem"] = new XAQueryFieldInfo("long", buyrem, buyrem.ToString("d12"), "매수잔량", (decimal)12);
			dict["psgvolume"] = new XAQueryFieldInfo("long", psgvolume, psgvolume.ToString("d12"), "매수공시수량", (decimal)12);
			dict["sellrem"] = new XAQueryFieldInfo("long", sellrem, sellrem.ToString("d12"), "매도잔량", (decimal)12);
			dict["pdgvolume"] = new XAQueryFieldInfo("long", pdgvolume, pdgvolume.ToString("d12"), "매도공시수량", (decimal)12);
			dict["sigatot"] = new XAQueryFieldInfo("long", sigatot, sigatot.ToString("d20"), "시가총액", (decimal)20);
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "종목코드", (decimal)6);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "rank":
					this.rank = fieldInfo.FieldValue.ParseLong("rank");
				break;

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

				case "sigatotrt":
					this.sigatotrt = fieldInfo.FieldValue.ParseFloat("sigatotrt");
				break;

				case "obuyvol":
					this.obuyvol = fieldInfo.FieldValue.ParseLong("obuyvol");
				break;

				case "buyrem":
					this.buyrem = fieldInfo.FieldValue.ParseLong("buyrem");
				break;

				case "psgvolume":
					this.psgvolume = fieldInfo.FieldValue.ParseLong("psgvolume");
				break;

				case "sellrem":
					this.sellrem = fieldInfo.FieldValue.ParseLong("sellrem");
				break;

				case "pdgvolume":
					this.pdgvolume = fieldInfo.FieldValue.ParseLong("pdgvolume");
				break;

				case "sigatot":
					this.sigatot = fieldInfo.FieldValue.ParseLong("sigatot");
				break;

				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt1638OutBlock[] ListFromQuery(XQt1638 query)
		{
			int count = query.GetBlockCount(XQt1638OutBlock.BlockName);
			List<XQt1638OutBlock> list = new List<XQt1638OutBlock>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1638OutBlock block = new XQt1638OutBlock();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.rank = query.GetFieldData(block.GetBlockName(), "rank", i).ParseLong("rank"); // long 4
					block.hname = query.GetFieldData(block.GetBlockName(), "hname", i).TrimEnd('?'); // char 20
					block.price = query.GetFieldData(block.GetBlockName(), "price", i).ParseLong("price"); // long 8
					block.sign = query.GetFieldData(block.GetBlockName(), "sign", i).FirstOrDefault(); // char 1
					block.change = query.GetFieldData(block.GetBlockName(), "change", i).ParseLong("change"); // long 8
					block.diff = query.GetFieldData(block.GetBlockName(), "diff", i).ParseFloat("diff"); // float 6.2
					block.sigatotrt = query.GetFieldData(block.GetBlockName(), "sigatotrt", i).ParseFloat("sigatotrt"); // float 6.2
					block.obuyvol = query.GetFieldData(block.GetBlockName(), "obuyvol", i).ParseLong("obuyvol"); // long 12
					block.buyrem = query.GetFieldData(block.GetBlockName(), "buyrem", i).ParseLong("buyrem"); // long 12
					block.psgvolume = query.GetFieldData(block.GetBlockName(), "psgvolume", i).ParseLong("psgvolume"); // long 12
					block.sellrem = query.GetFieldData(block.GetBlockName(), "sellrem", i).ParseLong("sellrem"); // long 12
					block.pdgvolume = query.GetFieldData(block.GetBlockName(), "pdgvolume", i).ParseLong("pdgvolume"); // long 12
					block.sigatot = query.GetFieldData(block.GetBlockName(), "sigatot", i).ParseLong("sigatot"); // long 20
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
			if (rank.ToString().Length > 4) return false; // long 4
			if (hname?.Length > 20) return false; // char 20
			if (price.ToString().Length > 8) return false; // long 8
			// sign char 1
			if (change.ToString().Length > 8) return false; // long 8
			// diff float 6.2
			// sigatotrt float 6.2
			if (obuyvol.ToString().Length > 12) return false; // long 12
			if (buyrem.ToString().Length > 12) return false; // long 12
			if (psgvolume.ToString().Length > 12) return false; // long 12
			if (sellrem.ToString().Length > 12) return false; // long 12
			if (pdgvolume.ToString().Length > 12) return false; // long 12
			if (sigatot.ToString().Length > 20) return false; // long 20
			if (shcode?.Length > 6) return false; // char 6

			return true;
		}
	}

	/// <summary>
	/// 종목별잔량/사전공시(t1638)
	/// </summary>
	public partial class XQt1638 : XingQuery
	{
		/// <summary>
		/// t1638
		/// </summary>
		public const string _typeName = "t1638";
		/// <summary>
		/// 종목별잔량/사전공시(t1638)
		/// </summary>
		public const string _typeDesc = "종목별잔량/사전공시(t1638)";
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
		/// t1638
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 종목별잔량/사전공시(t1638)
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
		/// 종목별잔량/사전공시(t1638)
		/// </summary>
		public XQt1638() : base("t1638") { }


		public static XQt1638OutBlock[] Get(char gubun1 = default,string shcode = default,char gubun2 = default)
		{
			using (XQt1638 instance = new XQt1638())
			{
				instance.SetFieldData(XQt1638InBlock.BlockName, XQt1638InBlock.F.gubun1, 0, gubun1.ToString()); // char 1
				instance.SetFieldData(XQt1638InBlock.BlockName, XQt1638InBlock.F.shcode, 0, shcode); // char 6
				instance.SetFieldData(XQt1638InBlock.BlockName, XQt1638InBlock.F.gubun2, 0, gubun2.ToString()); // char 1

				if (instance.Request() < 0)
				{
					return null;
				}

				var outBlock = instance.GetBlocks();
				return outBlock;
			}
		}

		public bool SetBlock(XQt1638InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "gubun1", 0, block.gubun1.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "shcode", 0, block.shcode); // char 6
			_xaQuery.SetFieldData(block.GetBlockName(), "gubun2", 0, block.gubun2.ToString()); // char 1

			return true;
		}

		public XQt1638OutBlock[] GetBlocks()
		{
			XQt1638OutBlock[] instance = XQt1638OutBlock.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt1638OutBlock),

		};

	}

}
