using System.Xml.Linq;

namespace SharpVk.Generator
{
    public interface IVkXmlCache
    {
        XDocument GetVkXml();
    }
}