using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace XingAPINet
{
    public abstract partial class XingBlock
    {
        public bool IsValidData = true;
        public string InvalidReason;

        public abstract string GetBlockName();

        public abstract Dictionary<string, XAQueryFieldInfo> GetFieldsInfo();

        public void Dump(TextWriter writer, DumpOutputType outputType = DumpOutputType.FormattedKeyValue)
        {
            Dictionary<string, XAQueryFieldInfo> dict = GetFieldsInfo();
            writer.Dump(this.GetBlockName(), dict, outputType);
        }
    }
}
