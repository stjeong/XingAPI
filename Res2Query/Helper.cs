using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Res2Query
{
    public struct BlockInfo
    {
        readonly string _blockType;
        public BlockType BlockType
        {
            get
            {
                return (BlockType)Enum.Parse(typeof(BlockType), _blockType);
            }
        }

        public readonly string SetFieldData;

        public BlockInfo(string typeCode, string fieldData)
        {
            _blockType = typeCode;
            SetFieldData = fieldData;
        }
    }

    public enum BlockType
    {
        input,
        output,
    }
}
