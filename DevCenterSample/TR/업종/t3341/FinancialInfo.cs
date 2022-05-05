using XingAPINet;

namespace t3341
{
    public class FinancialInfo : XQt3341OutBlock1
    {
        public FinancialInfo(XQt3341OutBlock1 block)
        {
            block.CopyTo(this);
        }
    }
}
