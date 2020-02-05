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

    public class TypeInfo
    {
        readonly string _typeFullName;
        public string TypeFullName => _typeFullName;

        readonly string _typeDesc;
        public string TypeDesc => _typeDesc;

        readonly string _typeName;
        public string TypeName => _typeName;

        readonly bool _isReal;
        public bool IsReal => _isReal;

        public TypeInfo(string typeName, string typeFullName, string typeDesc, bool isReal)
        {
            _typeName = typeName;
            _typeFullName = typeFullName;
            _typeDesc = typeDesc;
            _isReal = isReal;
        }
    }

    public enum BlockType
    {
        input,
        output,
    }
}
