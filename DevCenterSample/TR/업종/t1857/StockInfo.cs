using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XingAPINet;

namespace t1857
{
    public class StockInfo : XQt1857OutBlock1
    {
        public float CPS { get; set; }
        public float SPS { get; set; }
        public float PBR { get; set; }
        public float PER { get; set; }
        public float PCR { get { return this.price / this.CPS; } }
        public float PSR { get { return this.price / this.SPS; } }

        public StockInfo(XQt1857OutBlock1 block)
        {
            block.CopyTo(this);
        }

        public override string ToString()
        {
            return $"{hname:F2}({shcode}): PCR={PCR:F2}, PBR={PBR:F2}, PER={PER:F2}, PSR={PSR:F2}, CPS={CPS:F2}, SPS={SPS:F2}, Price={price}";
        }
    }
}
