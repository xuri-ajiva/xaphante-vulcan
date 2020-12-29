using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Rules;
using SharpVk.Generator.Specification.Elements;
using System.Xml.Linq;

namespace SharpVk.Generator.Specification.Rules
{
    public interface ITypeExtensionRule
        : IRule<XElement, TypeElement, IServiceCollection>
    {
    }
}
