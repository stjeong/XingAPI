using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Res2Query
{
    public struct BlockInfo
    {
        readonly string _blockType;
        public BlockType BlockType => (BlockType)Enum.Parse(typeof(BlockType), _blockType);

        readonly bool _hasOccurs;
        public bool HasOccurs => _hasOccurs;

        public readonly string SetFieldData;

        public BlockInfo(string typeCode, string setFieldData, bool hasOccurs)
        {
            _blockType = typeCode;
            SetFieldData = setFieldData;
            _hasOccurs = hasOccurs;
        }
    }

    public enum BlockType
    {
        input,
        output,
    }
}
