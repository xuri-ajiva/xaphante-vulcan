using SharpVk.Generator.Specification.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace SharpVk.Generator.Specification
{
    internal static class PointerTypeUtil
    {
        internal static PointerType Map(string typeString)
        {
            switch (typeString)
            {
                case "@":
                    return PointerType.Value;
                case "const @":
                    return PointerType.ConstValue;
                case "@*":
                    return PointerType.Pointer;
                case "@**":
                    return PointerType.DoublePointer;
                case "const @*":
                case "struct @*":
                // struct {type}* is a syntactic quirk of C structs with no
                // typedef; treat them like regular const pointers.
                case "const struct @*":
                case "struct @**":
                    return PointerType.ConstPointer;
                case "const @* const*":
                    return PointerType.DoubleConstPointer;
                default:
                    throw new NotSupportedException(string.Format("Unknown pointer type string '{0}'.", typeString));
            }
        }

        internal static PointerType GetFrom(IEnumerable<XNode> typeNodes)
        {
            string typeString = typeNodes.Select(x =>
            {
                if (x.NodeType == XmlNodeType.Element)
                {
                    var element = (XElement)x;

                    if (element.Name == "type")
                    {
                        return "@";
                    }
                    else
                    {
                        return ((XElement)x).Value;
                    }
                }
                else
                {
                    return x.ToString();
                }
            }).Aggregate(string.Concat).Trim();

            return Map(typeString);
        }
    }
}
