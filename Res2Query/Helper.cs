using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Res2Query
{
    public class BlockInfo
    {
        readonly string _blockType;
        public BlockType BlockType => (BlockType)Enum.Parse(typeof(BlockType), _blockType);

        readonly bool _hasOccurs;
        public bool HasOccurs => _hasOccurs;

        public readonly string SetFieldData;
        public readonly string GetParams;
        public readonly string GetParamsSetFieldData;

        public BlockInfo(string typeCode, string setFieldData, string getParams, string getParamsSetFieldData, bool hasOccurs)
        {
            _blockType = typeCode;
            SetFieldData = setFieldData;
            _hasOccurs = hasOccurs;
            GetParams = getParams;
            GetParamsSetFieldData = getParamsSetFieldData;
        }
    }

    public enum BlockType
    {
        input,
        output,
    }
}
