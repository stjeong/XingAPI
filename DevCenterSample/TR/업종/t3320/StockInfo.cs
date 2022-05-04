using XingAPINet;

namespace t3320
{
    public class StockInfo : XQt3320OutBlock1
    {
        readonly string _name;
        public string Name => _name;

        public string SHCode => this.gicode;

        public StockInfo(string name, XQt3320OutBlock1 block)
        {
            _name = name;
            block.CopyTo(this);
        }
    }
}
