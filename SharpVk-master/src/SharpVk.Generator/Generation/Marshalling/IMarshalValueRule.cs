using SharpVk.Generator.Rules;

namespace SharpVk.Generator.Generation.Marshalling
{
    public interface IMarshalValueRule
        : IFuncRule<TypeReference, MarshalInfo>
    {
    }
}
