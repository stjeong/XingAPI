using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XRFH0InBlock : XingBlock
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
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("futcode", "단축코드", "char", "8")]
		public string futcode;

		public static class F
		{
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string futcode = "futcode";
		}

		public static string[] AllFields = new string[]
		{
			F.futcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["futcode"] = new XAQueryFieldInfo("char", futcode, futcode, "단축코드", (decimal)8);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "futcode":
					this.futcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (futcode?.Length > 8) return false; // char 8

			return true;
		}
	}

	public partial class XRFH0OutBlock : XingBlock
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
		/// 호가시간
		/// </summary>
		[XAQueryFieldAttribute("hotime", "호가시간", "char", "6")]
		public string hotime;
		/// <summary>
		/// 매도호가1
		/// </summary>
		[XAQueryFieldAttribute("offerho1", "매도호가1", "double", "6.2")]
		public double offerho1;
		/// <summary>
		/// 매수호가1
		/// </summary>
		[XAQueryFieldAttribute("bidho1", "매수호가1", "double", "6.2")]
		public double bidho1;
		/// <summary>
		/// 매도호가수량1
		/// </summary>
		[XAQueryFieldAttribute("offerrem1", "매도호가수량1", "long", "6")]
		public long offerrem1;
		/// <summary>
		/// 매수호가수량1
		/// </summary>
		[XAQueryFieldAttribute("bidrem1", "매수호가수량1", "long", "6")]
		public long bidrem1;
		/// <summary>
		/// 매도호가건수1
		/// </summary>
		[XAQueryFieldAttribute("offercnt1", "매도호가건수1", "long", "5")]
		public long offercnt1;
		/// <summary>
		/// 매수호가건수1
		/// </summary>
		[XAQueryFieldAttribute("bidcnt1", "매수호가건수1", "long", "5")]
		public long bidcnt1;
		/// <summary>
		/// 매도호가2
		/// </summary>
		[XAQueryFieldAttribute("offerho2", "매도호가2", "double", "6.2")]
		public double offerho2;
		/// <summary>
		/// 매수호가2
		/// </summary>
		[XAQueryFieldAttribute("bidho2", "매수호가2", "double", "6.2")]
		public double bidho2;
		/// <summary>
		/// 매도호가수량2
		/// </summary>
		[XAQueryFieldAttribute("offerrem2", "매도호가수량2", "long", "6")]
		public long offerrem2;
		/// <summary>
		/// 매수호가수량2
		/// </summary>
		[XAQueryFieldAttribute("bidrem2", "매수호가수량2", "long", "6")]
		public long bidrem2;
		/// <summary>
		/// 매도호가건수2
		/// </summary>
		[XAQueryFieldAttribute("offercnt2", "매도호가건수2", "long", "5")]
		public long offercnt2;
		/// <summary>
		/// 매수호가건수2
		/// </summary>
		[XAQueryFieldAttribute("bidcnt2", "매수호가건수2", "long", "5")]
		public long bidcnt2;
		/// <summary>
		/// 매도호가3
		/// </summary>
		[XAQueryFieldAttribute("offerho3", "매도호가3", "double", "6.2")]
		public double offerho3;
		/// <summary>
		/// 매수호가3
		/// </summary>
		[XAQueryFieldAttribute("bidho3", "매수호가3", "double", "6.2")]
		public double bidho3;
		/// <summary>
		/// 매도호가수량3
		/// </summary>
		[XAQueryFieldAttribute("offerrem3", "매도호가수량3", "long", "6")]
		public long offerrem3;
		/// <summary>
		/// 매수호가수량3
		/// </summary>
		[XAQueryFieldAttribute("bidrem3", "매수호가수량3", "long", "6")]
		public long bidrem3;
		/// <summary>
		/// 매도호가건수3
		/// </summary>
		[XAQueryFieldAttribute("offercnt3", "매도호가건수3", "long", "5")]
		public long offercnt3;
		/// <summary>
		/// 매수호가건수3
		/// </summary>
		[XAQueryFieldAttribute("bidcnt3", "매수호가건수3", "long", "5")]
		public long bidcnt3;
		/// <summary>
		/// 매도호가4
		/// </summary>
		[XAQueryFieldAttribute("offerho4", "매도호가4", "double", "6.2")]
		public double offerho4;
		/// <summary>
		/// 매수호가4
		/// </summary>
		[XAQueryFieldAttribute("bidho4", "매수호가4", "double", "6.2")]
		public double bidho4;
		/// <summary>
		/// 매도호가수량4
		/// </summary>
		[XAQueryFieldAttribute("offerrem4", "매도호가수량4", "long", "6")]
		public long offerrem4;
		/// <summary>
		/// 매수호가수량4
		/// </summary>
		[XAQueryFieldAttribute("bidrem4", "매수호가수량4", "long", "6")]
		public long bidrem4;
		/// <summary>
		/// 매도호가건수4
		/// </summary>
		[XAQueryFieldAttribute("offercnt4", "매도호가건수4", "long", "5")]
		public long offercnt4;
		/// <summary>
		/// 매수호가건수4
		/// </summary>
		[XAQueryFieldAttribute("bidcnt4", "매수호가건수4", "long", "5")]
		public long bidcnt4;
		/// <summary>
		/// 매도호가5
		/// </summary>
		[XAQueryFieldAttribute("offerho5", "매도호가5", "double", "6.2")]
		public double offerho5;
		/// <summary>
		/// 매수호가5
		/// </summary>
		[XAQueryFieldAttribute("bidho5", "매수호가5", "double", "6.2")]
		public double bidho5;
		/// <summary>
		/// 매도호가수량5
		/// </summary>
		[XAQueryFieldAttribute("offerrem5", "매도호가수량5", "long", "6")]
		public long offerrem5;
		/// <summary>
		/// 매수호가수량5
		/// </summary>
		[XAQueryFieldAttribute("bidrem5", "매수호가수량5", "long", "6")]
		public long bidrem5;
		/// <summary>
		/// 매도호가건수5
		/// </summary>
		[XAQueryFieldAttribute("offercnt5", "매도호가건수5", "long", "5")]
		public long offercnt5;
		/// <summary>
		/// 매수호가건수5
		/// </summary>
		[XAQueryFieldAttribute("bidcnt5", "매수호가건수5", "long", "5")]
		public long bidcnt5;
		/// <summary>
		/// 매도호가총수량
		/// </summary>
		[XAQueryFieldAttribute("totofferrem", "매도호가총수량", "long", "6")]
		public long totofferrem;
		/// <summary>
		/// 매수호가총수량
		/// </summary>
		[XAQueryFieldAttribute("totbidrem", "매수호가총수량", "long", "6")]
		public long totbidrem;
		/// <summary>
		/// 매도호가총건수
		/// </summary>
		[XAQueryFieldAttribute("totoffercnt", "매도호가총건수", "long", "5")]
		public long totoffercnt;
		/// <summary>
		/// 매수호가총건수
		/// </summary>
		[XAQueryFieldAttribute("totbidcnt", "매수호가총건수", "long", "5")]
		public long totbidcnt;
		/// <summary>
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("futcode", "단축코드", "char", "8")]
		public string futcode;
		/// <summary>
		/// 단일가호가여부
		/// </summary>
		[XAQueryFieldAttribute("danhochk", "단일가호가여부", "char", "1")]
		public char danhochk;
		/// <summary>
		/// 배분적용구분
		/// </summary>
		[XAQueryFieldAttribute("alloc_gubun", "배분적용구분", "char", "1")]
		public char alloc_gubun;

		public static class F
		{
			/// <summary>
			/// 호가시간
			/// </summary>
			public const string hotime = "hotime";
			/// <summary>
			/// 매도호가1
			/// </summary>
			public const string offerho1 = "offerho1";
			/// <summary>
			/// 매수호가1
			/// </summary>
			public const string bidho1 = "bidho1";
			/// <summary>
			/// 매도호가수량1
			/// </summary>
			public const string offerrem1 = "offerrem1";
			/// <summary>
			/// 매수호가수량1
			/// </summary>
			public const string bidrem1 = "bidrem1";
			/// <summary>
			/// 매도호가건수1
			/// </summary>
			public const string offercnt1 = "offercnt1";
			/// <summary>
			/// 매수호가건수1
			/// </summary>
			public const string bidcnt1 = "bidcnt1";
			/// <summary>
			/// 매도호가2
			/// </summary>
			public const string offerho2 = "offerho2";
			/// <summary>
			/// 매수호가2
			/// </summary>
			public const string bidho2 = "bidho2";
			/// <summary>
			/// 매도호가수량2
			/// </summary>
			public const string offerrem2 = "offerrem2";
			/// <summary>
			/// 매수호가수량2
			/// </summary>
			public const string bidrem2 = "bidrem2";
			/// <summary>
			/// 매도호가건수2
			/// </summary>
			public const string offercnt2 = "offercnt2";
			/// <summary>
			/// 매수호가건수2
			/// </summary>
			public const string bidcnt2 = "bidcnt2";
			/// <summary>
			/// 매도호가3
			/// </summary>
			public const string offerho3 = "offerho3";
			/// <summary>
			/// 매수호가3
			/// </summary>
			public const string bidho3 = "bidho3";
			/// <summary>
			/// 매도호가수량3
			/// </summary>
			public const string offerrem3 = "offerrem3";
			/// <summary>
			/// 매수호가수량3
			/// </summary>
			public const string bidrem3 = "bidrem3";
			/// <summary>
			/// 매도호가건수3
			/// </summary>
			public const string offercnt3 = "offercnt3";
			/// <summary>
			/// 매수호가건수3
			/// </summary>
			public const string bidcnt3 = "bidcnt3";
			/// <summary>
			/// 매도호가4
			/// </summary>
			public const string offerho4 = "offerho4";
			/// <summary>
			/// 매수호가4
			/// </summary>
			public const string bidho4 = "bidho4";
			/// <summary>
			/// 매도호가수량4
			/// </summary>
			public const string offerrem4 = "offerrem4";
			/// <summary>
			/// 매수호가수량4
			/// </summary>
			public const string bidrem4 = "bidrem4";
			/// <summary>
			/// 매도호가건수4
			/// </summary>
			public const string offercnt4 = "offercnt4";
			/// <summary>
			/// 매수호가건수4
			/// </summary>
			public const string bidcnt4 = "bidcnt4";
			/// <summary>
			/// 매도호가5
			/// </summary>
			public const string offerho5 = "offerho5";
			/// <summary>
			/// 매수호가5
			/// </summary>
			public const string bidho5 = "bidho5";
			/// <summary>
			/// 매도호가수량5
			/// </summary>
			public const string offerrem5 = "offerrem5";
			/// <summary>
			/// 매수호가수량5
			/// </summary>
			public const string bidrem5 = "bidrem5";
			/// <summary>
			/// 매도호가건수5
			/// </summary>
			public const string offercnt5 = "offercnt5";
			/// <summary>
			/// 매수호가건수5
			/// </summary>
			public const string bidcnt5 = "bidcnt5";
			/// <summary>
			/// 매도호가총수량
			/// </summary>
			public const string totofferrem = "totofferrem";
			/// <summary>
			/// 매수호가총수량
			/// </summary>
			public const string totbidrem = "totbidrem";
			/// <summary>
			/// 매도호가총건수
			/// </summary>
			public const string totoffercnt = "totoffercnt";
			/// <summary>
			/// 매수호가총건수
			/// </summary>
			public const string totbidcnt = "totbidcnt";
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string futcode = "futcode";
			/// <summary>
			/// 단일가호가여부
			/// </summary>
			public const string danhochk = "danhochk";
			/// <summary>
			/// 배분적용구분
			/// </summary>
			public const string alloc_gubun = "alloc_gubun";
		}

		public static string[] AllFields = new string[]
		{
			F.hotime,
			F.offerho1,
			F.bidho1,
			F.offerrem1,
			F.bidrem1,
			F.offercnt1,
			F.bidcnt1,
			F.offerho2,
			F.bidho2,
			F.offerrem2,
			F.bidrem2,
			F.offercnt2,
			F.bidcnt2,
			F.offerho3,
			F.bidho3,
			F.offerrem3,
			F.bidrem3,
			F.offercnt3,
			F.bidcnt3,
			F.offerho4,
			F.bidho4,
			F.offerrem4,
			F.bidrem4,
			F.offercnt4,
			F.bidcnt4,
			F.offerho5,
			F.bidho5,
			F.offerrem5,
			F.bidrem5,
			F.offercnt5,
			F.bidcnt5,
			F.totofferrem,
			F.totbidrem,
			F.totoffercnt,
			F.totbidcnt,
			F.futcode,
			F.danhochk,
			F.alloc_gubun,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["hotime"] = new XAQueryFieldInfo("char", hotime, hotime, "호가시간", (decimal)6);
			dict["offerho1"] = new XAQueryFieldInfo("double", offerho1, offerho1.ToString("000000.00"), "매도호가1", (decimal)6.2);
			dict["bidho1"] = new XAQueryFieldInfo("double", bidho1, bidho1.ToString("000000.00"), "매수호가1", (decimal)6.2);
			dict["offerrem1"] = new XAQueryFieldInfo("long", offerrem1, offerrem1.ToString("d6"), "매도호가수량1", (decimal)6);
			dict["bidrem1"] = new XAQueryFieldInfo("long", bidrem1, bidrem1.ToString("d6"), "매수호가수량1", (decimal)6);
			dict["offercnt1"] = new XAQueryFieldInfo("long", offercnt1, offercnt1.ToString("d5"), "매도호가건수1", (decimal)5);
			dict["bidcnt1"] = new XAQueryFieldInfo("long", bidcnt1, bidcnt1.ToString("d5"), "매수호가건수1", (decimal)5);
			dict["offerho2"] = new XAQueryFieldInfo("double", offerho2, offerho2.ToString("000000.00"), "매도호가2", (decimal)6.2);
			dict["bidho2"] = new XAQueryFieldInfo("double", bidho2, bidho2.ToString("000000.00"), "매수호가2", (decimal)6.2);
			dict["offerrem2"] = new XAQueryFieldInfo("long", offerrem2, offerrem2.ToString("d6"), "매도호가수량2", (decimal)6);
			dict["bidrem2"] = new XAQueryFieldInfo("long", bidrem2, bidrem2.ToString("d6"), "매수호가수량2", (decimal)6);
			dict["offercnt2"] = new XAQueryFieldInfo("long", offercnt2, offercnt2.ToString("d5"), "매도호가건수2", (decimal)5);
			dict["bidcnt2"] = new XAQueryFieldInfo("long", bidcnt2, bidcnt2.ToString("d5"), "매수호가건수2", (decimal)5);
			dict["offerho3"] = new XAQueryFieldInfo("double", offerho3, offerho3.ToString("000000.00"), "매도호가3", (decimal)6.2);
			dict["bidho3"] = new XAQueryFieldInfo("double", bidho3, bidho3.ToString("000000.00"), "매수호가3", (decimal)6.2);
			dict["offerrem3"] = new XAQueryFieldInfo("long", offerrem3, offerrem3.ToString("d6"), "매도호가수량3", (decimal)6);
			dict["bidrem3"] = new XAQueryFieldInfo("long", bidrem3, bidrem3.ToString("d6"), "매수호가수량3", (decimal)6);
			dict["offercnt3"] = new XAQueryFieldInfo("long", offercnt3, offercnt3.ToString("d5"), "매도호가건수3", (decimal)5);
			dict["bidcnt3"] = new XAQueryFieldInfo("long", bidcnt3, bidcnt3.ToString("d5"), "매수호가건수3", (decimal)5);
			dict["offerho4"] = new XAQueryFieldInfo("double", offerho4, offerho4.ToString("000000.00"), "매도호가4", (decimal)6.2);
			dict["bidho4"] = new XAQueryFieldInfo("double", bidho4, bidho4.ToString("000000.00"), "매수호가4", (decimal)6.2);
			dict["offerrem4"] = new XAQueryFieldInfo("long", offerrem4, offerrem4.ToString("d6"), "매도호가수량4", (decimal)6);
			dict["bidrem4"] = new XAQueryFieldInfo("long", bidrem4, bidrem4.ToString("d6"), "매수호가수량4", (decimal)6);
			dict["offercnt4"] = new XAQueryFieldInfo("long", offercnt4, offercnt4.ToString("d5"), "매도호가건수4", (decimal)5);
			dict["bidcnt4"] = new XAQueryFieldInfo("long", bidcnt4, bidcnt4.ToString("d5"), "매수호가건수4", (decimal)5);
			dict["offerho5"] = new XAQueryFieldInfo("double", offerho5, offerho5.ToString("000000.00"), "매도호가5", (decimal)6.2);
			dict["bidho5"] = new XAQueryFieldInfo("double", bidho5, bidho5.ToString("000000.00"), "매수호가5", (decimal)6.2);
			dict["offerrem5"] = new XAQueryFieldInfo("long", offerrem5, offerrem5.ToString("d6"), "매도호가수량5", (decimal)6);
			dict["bidrem5"] = new XAQueryFieldInfo("long", bidrem5, bidrem5.ToString("d6"), "매수호가수량5", (decimal)6);
			dict["offercnt5"] = new XAQueryFieldInfo("long", offercnt5, offercnt5.ToString("d5"), "매도호가건수5", (decimal)5);
			dict["bidcnt5"] = new XAQueryFieldInfo("long", bidcnt5, bidcnt5.ToString("d5"), "매수호가건수5", (decimal)5);
			dict["totofferrem"] = new XAQueryFieldInfo("long", totofferrem, totofferrem.ToString("d6"), "매도호가총수량", (decimal)6);
			dict["totbidrem"] = new XAQueryFieldInfo("long", totbidrem, totbidrem.ToString("d6"), "매수호가총수량", (decimal)6);
			dict["totoffercnt"] = new XAQueryFieldInfo("long", totoffercnt, totoffercnt.ToString("d5"), "매도호가총건수", (decimal)5);
			dict["totbidcnt"] = new XAQueryFieldInfo("long", totbidcnt, totbidcnt.ToString("d5"), "매수호가총건수", (decimal)5);
			dict["futcode"] = new XAQueryFieldInfo("char", futcode, futcode, "단축코드", (decimal)8);
			dict["danhochk"] = new XAQueryFieldInfo("char", danhochk, danhochk.ToString(), "단일가호가여부", (decimal)1);
			dict["alloc_gubun"] = new XAQueryFieldInfo("char", alloc_gubun, alloc_gubun.ToString(), "배분적용구분", (decimal)1);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "hotime":
					this.hotime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "offerho1":
					this.offerho1 = fieldInfo.FieldValue.ParseDouble("offerho1");
				break;

				case "bidho1":
					this.bidho1 = fieldInfo.FieldValue.ParseDouble("bidho1");
				break;

				case "offerrem1":
					this.offerrem1 = fieldInfo.FieldValue.ParseLong("offerrem1");
				break;

				case "bidrem1":
					this.bidrem1 = fieldInfo.FieldValue.ParseLong("bidrem1");
				break;

				case "offercnt1":
					this.offercnt1 = fieldInfo.FieldValue.ParseLong("offercnt1");
				break;

				case "bidcnt1":
					this.bidcnt1 = fieldInfo.FieldValue.ParseLong("bidcnt1");
				break;

				case "offerho2":
					this.offerho2 = fieldInfo.FieldValue.ParseDouble("offerho2");
				break;

				case "bidho2":
					this.bidho2 = fieldInfo.FieldValue.ParseDouble("bidho2");
				break;

				case "offerrem2":
					this.offerrem2 = fieldInfo.FieldValue.ParseLong("offerrem2");
				break;

				case "bidrem2":
					this.bidrem2 = fieldInfo.FieldValue.ParseLong("bidrem2");
				break;

				case "offercnt2":
					this.offercnt2 = fieldInfo.FieldValue.ParseLong("offercnt2");
				break;

				case "bidcnt2":
					this.bidcnt2 = fieldInfo.FieldValue.ParseLong("bidcnt2");
				break;

				case "offerho3":
					this.offerho3 = fieldInfo.FieldValue.ParseDouble("offerho3");
				break;

				case "bidho3":
					this.bidho3 = fieldInfo.FieldValue.ParseDouble("bidho3");
				break;

				case "offerrem3":
					this.offerrem3 = fieldInfo.FieldValue.ParseLong("offerrem3");
				break;

				case "bidrem3":
					this.bidrem3 = fieldInfo.FieldValue.ParseLong("bidrem3");
				break;

				case "offercnt3":
					this.offercnt3 = fieldInfo.FieldValue.ParseLong("offercnt3");
				break;

				case "bidcnt3":
					this.bidcnt3 = fieldInfo.FieldValue.ParseLong("bidcnt3");
				break;

				case "offerho4":
					this.offerho4 = fieldInfo.FieldValue.ParseDouble("offerho4");
				break;

				case "bidho4":
					this.bidho4 = fieldInfo.FieldValue.ParseDouble("bidho4");
				break;

				case "offerrem4":
					this.offerrem4 = fieldInfo.FieldValue.ParseLong("offerrem4");
				break;

				case "bidrem4":
					this.bidrem4 = fieldInfo.FieldValue.ParseLong("bidrem4");
				break;

				case "offercnt4":
					this.offercnt4 = fieldInfo.FieldValue.ParseLong("offercnt4");
				break;

				case "bidcnt4":
					this.bidcnt4 = fieldInfo.FieldValue.ParseLong("bidcnt4");
				break;

				case "offerho5":
					this.offerho5 = fieldInfo.FieldValue.ParseDouble("offerho5");
				break;

				case "bidho5":
					this.bidho5 = fieldInfo.FieldValue.ParseDouble("bidho5");
				break;

				case "offerrem5":
					this.offerrem5 = fieldInfo.FieldValue.ParseLong("offerrem5");
				break;

				case "bidrem5":
					this.bidrem5 = fieldInfo.FieldValue.ParseLong("bidrem5");
				break;

				case "offercnt5":
					this.offercnt5 = fieldInfo.FieldValue.ParseLong("offercnt5");
				break;

				case "bidcnt5":
					this.bidcnt5 = fieldInfo.FieldValue.ParseLong("bidcnt5");
				break;

				case "totofferrem":
					this.totofferrem = fieldInfo.FieldValue.ParseLong("totofferrem");
				break;

				case "totbidrem":
					this.totbidrem = fieldInfo.FieldValue.ParseLong("totbidrem");
				break;

				case "totoffercnt":
					this.totoffercnt = fieldInfo.FieldValue.ParseLong("totoffercnt");
				break;

				case "totbidcnt":
					this.totbidcnt = fieldInfo.FieldValue.ParseLong("totbidcnt");
				break;

				case "futcode":
					this.futcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "danhochk":
					this.danhochk = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "alloc_gubun":
					this.alloc_gubun = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public static XRFH0OutBlock FromQuery(XRFH0 query)
		{
			XRFH0OutBlock block = new XRFH0OutBlock();
			block.IsValidData = true;
			block.InvalidReason = "";
			try
			{
				block.hotime = query.GetFieldData(block.GetBlockName(), "hotime").TrimEnd('?'); // char 6
				block.offerho1 = query.GetFieldData(block.GetBlockName(), "offerho1").ParseDouble("offerho1"); // double 6.2
				block.bidho1 = query.GetFieldData(block.GetBlockName(), "bidho1").ParseDouble("bidho1"); // double 6.2
				block.offerrem1 = query.GetFieldData(block.GetBlockName(), "offerrem1").ParseLong("offerrem1"); // long 6
				block.bidrem1 = query.GetFieldData(block.GetBlockName(), "bidrem1").ParseLong("bidrem1"); // long 6
				block.offercnt1 = query.GetFieldData(block.GetBlockName(), "offercnt1").ParseLong("offercnt1"); // long 5
				block.bidcnt1 = query.GetFieldData(block.GetBlockName(), "bidcnt1").ParseLong("bidcnt1"); // long 5
				block.offerho2 = query.GetFieldData(block.GetBlockName(), "offerho2").ParseDouble("offerho2"); // double 6.2
				block.bidho2 = query.GetFieldData(block.GetBlockName(), "bidho2").ParseDouble("bidho2"); // double 6.2
				block.offerrem2 = query.GetFieldData(block.GetBlockName(), "offerrem2").ParseLong("offerrem2"); // long 6
				block.bidrem2 = query.GetFieldData(block.GetBlockName(), "bidrem2").ParseLong("bidrem2"); // long 6
				block.offercnt2 = query.GetFieldData(block.GetBlockName(), "offercnt2").ParseLong("offercnt2"); // long 5
				block.bidcnt2 = query.GetFieldData(block.GetBlockName(), "bidcnt2").ParseLong("bidcnt2"); // long 5
				block.offerho3 = query.GetFieldData(block.GetBlockName(), "offerho3").ParseDouble("offerho3"); // double 6.2
				block.bidho3 = query.GetFieldData(block.GetBlockName(), "bidho3").ParseDouble("bidho3"); // double 6.2
				block.offerrem3 = query.GetFieldData(block.GetBlockName(), "offerrem3").ParseLong("offerrem3"); // long 6
				block.bidrem3 = query.GetFieldData(block.GetBlockName(), "bidrem3").ParseLong("bidrem3"); // long 6
				block.offercnt3 = query.GetFieldData(block.GetBlockName(), "offercnt3").ParseLong("offercnt3"); // long 5
				block.bidcnt3 = query.GetFieldData(block.GetBlockName(), "bidcnt3").ParseLong("bidcnt3"); // long 5
				block.offerho4 = query.GetFieldData(block.GetBlockName(), "offerho4").ParseDouble("offerho4"); // double 6.2
				block.bidho4 = query.GetFieldData(block.GetBlockName(), "bidho4").ParseDouble("bidho4"); // double 6.2
				block.offerrem4 = query.GetFieldData(block.GetBlockName(), "offerrem4").ParseLong("offerrem4"); // long 6
				block.bidrem4 = query.GetFieldData(block.GetBlockName(), "bidrem4").ParseLong("bidrem4"); // long 6
				block.offercnt4 = query.GetFieldData(block.GetBlockName(), "offercnt4").ParseLong("offercnt4"); // long 5
				block.bidcnt4 = query.GetFieldData(block.GetBlockName(), "bidcnt4").ParseLong("bidcnt4"); // long 5
				block.offerho5 = query.GetFieldData(block.GetBlockName(), "offerho5").ParseDouble("offerho5"); // double 6.2
				block.bidho5 = query.GetFieldData(block.GetBlockName(), "bidho5").ParseDouble("bidho5"); // double 6.2
				block.offerrem5 = query.GetFieldData(block.GetBlockName(), "offerrem5").ParseLong("offerrem5"); // long 6
				block.bidrem5 = query.GetFieldData(block.GetBlockName(), "bidrem5").ParseLong("bidrem5"); // long 6
				block.offercnt5 = query.GetFieldData(block.GetBlockName(), "offercnt5").ParseLong("offercnt5"); // long 5
				block.bidcnt5 = query.GetFieldData(block.GetBlockName(), "bidcnt5").ParseLong("bidcnt5"); // long 5
				block.totofferrem = query.GetFieldData(block.GetBlockName(), "totofferrem").ParseLong("totofferrem"); // long 6
				block.totbidrem = query.GetFieldData(block.GetBlockName(), "totbidrem").ParseLong("totbidrem"); // long 6
				block.totoffercnt = query.GetFieldData(block.GetBlockName(), "totoffercnt").ParseLong("totoffercnt"); // long 5
				block.totbidcnt = query.GetFieldData(block.GetBlockName(), "totbidcnt").ParseLong("totbidcnt"); // long 5
				block.futcode = query.GetFieldData(block.GetBlockName(), "futcode").TrimEnd('?'); // char 8
				block.danhochk = query.GetFieldData(block.GetBlockName(), "danhochk").FirstOrDefault(); // char 1
				block.alloc_gubun = query.GetFieldData(block.GetBlockName(), "alloc_gubun").FirstOrDefault(); // char 1

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (hotime?.Length > 6) return false; // char 6
			// offerho1 double 6.2
			// bidho1 double 6.2
			if (offerrem1.ToString().Length > 6) return false; // long 6
			if (bidrem1.ToString().Length > 6) return false; // long 6
			if (offercnt1.ToString().Length > 5) return false; // long 5
			if (bidcnt1.ToString().Length > 5) return false; // long 5
			// offerho2 double 6.2
			// bidho2 double 6.2
			if (offerrem2.ToString().Length > 6) return false; // long 6
			if (bidrem2.ToString().Length > 6) return false; // long 6
			if (offercnt2.ToString().Length > 5) return false; // long 5
			if (bidcnt2.ToString().Length > 5) return false; // long 5
			// offerho3 double 6.2
			// bidho3 double 6.2
			if (offerrem3.ToString().Length > 6) return false; // long 6
			if (bidrem3.ToString().Length > 6) return false; // long 6
			if (offercnt3.ToString().Length > 5) return false; // long 5
			if (bidcnt3.ToString().Length > 5) return false; // long 5
			// offerho4 double 6.2
			// bidho4 double 6.2
			if (offerrem4.ToString().Length > 6) return false; // long 6
			if (bidrem4.ToString().Length > 6) return false; // long 6
			if (offercnt4.ToString().Length > 5) return false; // long 5
			if (bidcnt4.ToString().Length > 5) return false; // long 5
			// offerho5 double 6.2
			// bidho5 double 6.2
			if (offerrem5.ToString().Length > 6) return false; // long 6
			if (bidrem5.ToString().Length > 6) return false; // long 6
			if (offercnt5.ToString().Length > 5) return false; // long 5
			if (bidcnt5.ToString().Length > 5) return false; // long 5
			if (totofferrem.ToString().Length > 6) return false; // long 6
			if (totbidrem.ToString().Length > 6) return false; // long 6
			if (totoffercnt.ToString().Length > 5) return false; // long 5
			if (totbidcnt.ToString().Length > 5) return false; // long 5
			if (futcode?.Length > 8) return false; // char 8
			// danhochk char 1
			// alloc_gubun char 1

			return true;
		}
	}

	/// <summary>
	/// KOSPI200선물호가(H0)
	/// </summary>
	public partial class XRFH0 : XingReal
	{
		/// <summary>
		/// FH0
		/// </summary>
		public const string _typeName = "FH0";
		/// <summary>
		/// KOSPI200선물호가(H0)
		/// </summary>
		public const string _typeDesc = "KOSPI200선물호가(H0)";
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
		/// FH0
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// KOSPI200선물호가(H0)
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
		/// KOSPI200선물호가(H0)
		/// </summary>
		public XRFH0() : base("FH0") { }


		public bool SetBlock(XRFH0InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaReal.SetFieldData(block.GetBlockName(), "futcode", block.futcode); // char 8

			return true;
		}

		public XRFH0OutBlock GetBlock()
		{
			XRFH0OutBlock instance = XRFH0OutBlock.FromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XRFH0OutBlock),

		};

	}

}
