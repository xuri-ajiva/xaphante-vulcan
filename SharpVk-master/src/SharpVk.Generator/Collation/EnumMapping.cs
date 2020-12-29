namespace SharpVk.Generator.Collation
{
    public struct EnumMapping
    {
        public EnumMapping(string typeVkName, string fieldName)
        {
            this.TypeVkName = typeVkName;
            this.FieldName = fieldName;
        }

        public string TypeVkName;
        public string FieldName;
    }
}
