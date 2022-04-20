using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XRCURInBlock : XingBlock
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

		/// <summary>
		/// 기초자산ID
		/// </summary>
		[XAQueryFieldAttribute("base_id", "기초자산ID", "char", "6")]
		public string base_id;

		public static class F
		{
			/// <summary>
			/// 기초자산ID
			/// </summary>
			public const string base_id = "base_id";
		}

		public static string[] AllFields = new string[]
		{
			F.base_id,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["base_id"] = new XAQueryFieldInfo("char", base_id, base_id, "기초자산ID", (decimal)6);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "base_id":
					this.base_id = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (base_id?.Length > 6) return false; // char 6

			return true;
		}

		public void CopyTo(XRCURInBlock block)
		{
			block.base_id = this.base_id;

		}
	}

	public partial class XRCUROutBlock : XingBlock
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
		/// 전송시간
		/// </summary>
		[XAQueryFieldAttribute("time", "전송시간", "char", "6")]
		public string time;
		/// <summary>
		/// 매도호가
		/// </summary>
		[XAQueryFieldAttribute("offer", "매도호가", "float", "7.2")]
		public float offer;
		/// <summary>
		/// 매수호가
		/// </summary>
		[XAQueryFieldAttribute("bid", "매수호가", "float", "7.2")]
		public float bid;
		/// <summary>
		/// 시가
		/// </summary>
		[XAQueryFieldAttribute("open", "시가", "float", "7.2")]
		public float open;
		/// <summary>
		/// 고가
		/// </summary>
		[XAQueryFieldAttribute("high", "고가", "float", "7.2")]
		public float high;
		/// <summary>
		/// 저가
		/// </summary>
		[XAQueryFieldAttribute("low", "저가", "float", "7.2")]
		public float low;
		/// <summary>
		/// 체결가
		/// </summary>
		[XAQueryFieldAttribute("price", "체결가", "float", "7.2")]
		public float price;
		/// <summary>
		/// 전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("sign", "전일대비구분", "char", "1")]
		public char sign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[XAQueryFieldAttribute("change", "전일대비", "float", "7.2")]
		public float change;
		/// <summary>
		/// 등락율
		/// </summary>
		[XAQueryFieldAttribute("drate", "등락율", "float", "7.2")]
		public float drate;
		/// <summary>
		/// 데이타 발생시간
		/// </summary>
		[XAQueryFieldAttribute("ctime", "데이타 발생시간", "char", "6")]
		public string ctime;
		/// <summary>
		/// 기초자산ID
		/// </summary>
		[XAQueryFieldAttribute("base_id", "기초자산ID", "char", "6")]
		public string base_id;

		public static class F
		{
			/// <summary>
			/// 전송시간
			/// </summary>
			public const string time = "time";
			/// <summary>
			/// 매도호가
			/// </summary>
			public const string offer = "offer";
			/// <summary>
			/// 매수호가
			/// </summary>
			public const string bid = "bid";
			/// <summary>
			/// 시가
			/// </summary>
			public const string open = "open";
			/// <summary>
			/// 고가
			/// </summary>
			public const string high = "high";
			/// <summary>
			/// 저가
			/// </summary>
			public const string low = "low";
			/// <summary>
			/// 체결가
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
			public const string drate = "drate";
			/// <summary>
			/// 데이타 발생시간
			/// </summary>
			public const string ctime = "ctime";
			/// <summary>
			/// 기초자산ID
			/// </summary>
			public const string base_id = "base_id";
		}

		public static string[] AllFields = new string[]
		{
			F.time,
			F.offer,
			F.bid,
			F.open,
			F.high,
			F.low,
			F.price,
			F.sign,
			F.change,
			F.drate,
			F.ctime,
			F.base_id,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["time"] = new XAQueryFieldInfo("char", time, time, "전송시간", (decimal)6);
			dict["offer"] = new XAQueryFieldInfo("float", offer, offer.ToString("0000000.00"), "매도호가", (decimal)7.2);
			dict["bid"] = new XAQueryFieldInfo("float", bid, bid.ToString("0000000.00"), "매수호가", (decimal)7.2);
			dict["open"] = new XAQueryFieldInfo("float", open, open.ToString("0000000.00"), "시가", (decimal)7.2);
			dict["high"] = new XAQueryFieldInfo("float", high, high.ToString("0000000.00"), "고가", (decimal)7.2);
			dict["low"] = new XAQueryFieldInfo("float", low, low.ToString("0000000.00"), "저가", (decimal)7.2);
			dict["price"] = new XAQueryFieldInfo("float", price, price.ToString("0000000.00"), "체결가", (decimal)7.2);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("float", change, change.ToString("0000000.00"), "전일대비", (decimal)7.2);
			dict["drate"] = new XAQueryFieldInfo("float", drate, drate.ToString("0000000.00"), "등락율", (decimal)7.2);
			dict["ctime"] = new XAQueryFieldInfo("char", ctime, ctime, "데이타 발생시간", (decimal)6);
			dict["base_id"] = new XAQueryFieldInfo("char", base_id, base_id, "기초자산ID", (decimal)6);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "time":
					this.time = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "offer":
					this.offer = fieldInfo.FieldValue.ParseFloat("offer");
				break;

				case "bid":
					this.bid = fieldInfo.FieldValue.ParseFloat("bid");
				break;

				case "open":
					this.open = fieldInfo.FieldValue.ParseFloat("open");
				break;

				case "high":
					this.high = fieldInfo.FieldValue.ParseFloat("high");
				break;

				case "low":
					this.low = fieldInfo.FieldValue.ParseFloat("low");
				break;

				case "price":
					this.price = fieldInfo.FieldValue.ParseFloat("price");
				break;

				case "sign":
					this.sign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "change":
					this.change = fieldInfo.FieldValue.ParseFloat("change");
				break;

				case "drate":
					this.drate = fieldInfo.FieldValue.ParseFloat("drate");
				break;

				case "ctime":
					this.ctime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "base_id":
					this.base_id = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XRCUROutBlock FromQuery(XRCUR query)
		{
			XRCUROutBlock block = new XRCUROutBlock();
			block.IsValidData = true;
			block.InvalidReason = "";
			try
			{
				block.time = query.GetFieldData(block.GetBlockName(), "time").TrimEnd('?'); // char 6
				block.offer = query.GetFieldData(block.GetBlockName(), "offer").ParseFloat("offer"); // float 7.2
				block.bid = query.GetFieldData(block.GetBlockName(), "bid").ParseFloat("bid"); // float 7.2
				block.open = query.GetFieldData(block.GetBlockName(), "open").ParseFloat("open"); // float 7.2
				block.high = query.GetFieldData(block.GetBlockName(), "high").ParseFloat("high"); // float 7.2
				block.low = query.GetFieldData(block.GetBlockName(), "low").ParseFloat("low"); // float 7.2
				block.price = query.GetFieldData(block.GetBlockName(), "price").ParseFloat("price"); // float 7.2
				block.sign = query.GetFieldData(block.GetBlockName(), "sign").FirstOrDefault(); // char 1
				block.change = query.GetFieldData(block.GetBlockName(), "change").ParseFloat("change"); // float 7.2
				block.drate = query.GetFieldData(block.GetBlockName(), "drate").ParseFloat("drate"); // float 7.2
				block.ctime = query.GetFieldData(block.GetBlockName(), "ctime").TrimEnd('?'); // char 6
				block.base_id = query.GetFieldData(block.GetBlockName(), "base_id").TrimEnd('?'); // char 6

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (time?.Length > 6) return false; // char 6
			// offer float 7.2
			// bid float 7.2
			// open float 7.2
			// high float 7.2
			// low float 7.2
			// price float 7.2
			// sign char 1
			// change float 7.2
			// drate float 7.2
			if (ctime?.Length > 6) return false; // char 6
			if (base_id?.Length > 6) return false; // char 6

			return true;
		}

		public void CopyTo(XRCUROutBlock block)
		{
			block.time = this.time;
			block.offer = this.offer;
			block.bid = this.bid;
			block.open = this.open;
			block.high = this.high;
			block.low = this.low;
			block.price = this.price;
			block.sign = this.sign;
			block.change = this.change;
			block.drate = this.drate;
			block.ctime = this.ctime;
			block.base_id = this.base_id;

		}
	}

	/// <summary>
	/// 현물정보 USD 실시간(CUR)
	/// </summary>
	public partial class XRCUR : XingReal
	{
		/// <summary>
		/// CUR
		/// </summary>
		public const string _typeName = "CUR";
		/// <summary>
		/// 현물정보 USD 실시간(CUR)
		/// </summary>
		public const string _typeDesc = "현물정보 USD 실시간(CUR)";
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
		/// CUR
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 현물정보 USD 실시간(CUR)
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
		/// 현물정보 USD 실시간(CUR)
		/// </summary>
		public XRCUR() : base("CUR") { }


		public bool SetBlock(XRCURInBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaReal.SetFieldData(block.GetBlockName(), "base_id", block.base_id); // char 6

			return true;
		}

		public XRCUROutBlock GetBlock()
		{
			XRCUROutBlock instance = XRCUROutBlock.FromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XRCUROutBlock),

		};

	}

}
