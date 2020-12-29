using SharpVk.Generator.Specification.Elements;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpVk.Generator.Collation
{
    public class NameFormatter
    {
        private static readonly Dictionary<string, string> primitiveTypes = new Dictionary<string, string>()
        {
            {"void", "void"},
            {"char", "byte"},
            {"float", "float"},
            {"uint8_t", "byte"},
            {"uint16_t", "ushort"},
            {"uint32_t", "uint"},
            {"uint64_t", "ulong"},
            {"VkDeviceSize", "ulong"},
            {"VkDeviceAddress", "ulong"},
            {"int", "int"},
            {"DWORD", "uint"},
            {"int32_t", "int"},
            {"size_t", "HostSize"},
            {"HINSTANCE", "IntPtr" },
            {"HMONITOR", "IntPtr" },
            {"HWND", "IntPtr" },
            {"HANDLE", "IntPtr" },
            {"SECURITY_ATTRIBUTES", "SecurityAttributes" },
            {"ANativeWindow", "IntPtr" },
            {"AHardwareBuffer", "IntPtr" },
            {"CAMetalLayer", "IntPtr" },
            {"Display", "IntPtr" },
            {"VisualID", "IntPtr" },
            {"Window", "IntPtr" },
            {"MirConnection", "IntPtr" },
            {"MirSurface", "IntPtr" },
            {"wl_display", "IntPtr" },
            {"wl_surface", "IntPtr" },
            {"xcb_connection_t", "IntPtr" },
            {"xcb_visualid_t", "IntPtr" },
            {"xcb_window_t", "IntPtr" },
            {"RROutput", "IntPtr" },
            {"LPCWSTR", "IntPtr" },
            {"zx_handle_t", "uint" },
            {"GgpStreamDescriptor", "uint" },
            {"GgpFrameToken", "uint" }
        };

        private static readonly string[] digitsSuffix = new[] { "flags", "flag", "type", "bits", "bit" };

        public string FormatName(EnumElement enumeration)
        {
            return JoinNameParts(enumeration.NameParts);
        }

        public string FormatName(TypeElement type)
        {
            if (primitiveTypes.ContainsKey(type.VkName))
            {
                return primitiveTypes[type.VkName];
            }

            string result = JoinNameParts(type.NameParts);

            if (type.Category == TypeCategory.funcpointer)
            {
                result += "Delegate";
            }

            return result;
        }

        public string FormatName(EnumField field)
        {
            return JoinNameParts(field.NameParts);
        }

        public string FormatName(ChildElement member, string typeName, bool isCamelCase)
        {
            var nameParts = member.NameParts.AsEnumerable();

            if (nameParts.First() == "pfn")
            {
                nameParts = nameParts.Skip(1);
            }

            var result = JoinNameParts(nameParts);

            if (isCamelCase)
            {
                return Normalise(result.FirstToLower());
            }

            if (result == typeName)
            {
                return nameParts.Last().FirstToUpper() + "Value";
            }
            else
            {
                return result;
            }
        }

        public string FormatName(CommandElement command, TypeElement handleType)
        {
            var methodNameParts = command.NameParts;

            int verbPrefixLength = 1;

            if (methodNameParts.First() != command.Verb)
            {
                verbPrefixLength = 0;
            }

            if (handleType.NameParts
                        .Zip(methodNameParts.Skip(verbPrefixLength), (x, y) => x == y)
                        .All(x => x))
            {
                methodNameParts = methodNameParts.Take(verbPrefixLength).Concat(methodNameParts.Skip(handleType.NameParts.Count() + verbPrefixLength)).ToArray();
            }
            else if (handleType.VkName == "VkDeviceMemory" && methodNameParts.Skip(verbPrefixLength).First() == "memory")
            {
                methodNameParts = methodNameParts.Take(verbPrefixLength).Concat(methodNameParts.Skip(verbPrefixLength + 1)).ToArray();
            }
            else if (handleType.VkName == "VkCommandBuffer" && methodNameParts.First() == "cmd")
            {
                methodNameParts = methodNameParts.Skip(1).ToArray();
            }

            return JoinNameParts(methodNameParts);
        }

        public string FormatName(EnumElement enumeration, EnumField value, bool isBitmask)
        {
            string digitsPrefix = JoinNameParts(enumeration.NameParts.TakeWhile(x => !digitsSuffix.Contains(x)));

            int skipAtEnd = isBitmask && digitsSuffix.Contains(value.NameParts.Last())
                                ? 1
                                : 0;

            string result = JoinNameParts(value.NameParts.Take(value.NameParts.Length - skipAtEnd));

            if (!char.IsLetter(result[0]))
            {
                result = digitsPrefix + result;
            }

            return result;
        }

        private static string JoinNameParts(IEnumerable<string> nameParts)
        {
            return nameParts
                        .Select(ExpandAbbreviations)
                        .Select(x => x.FirstToUpper())
                        .Aggregate(new StringBuilder(), (builder, value) => builder.Append(value))
                        .ToString();
        }

        private static string ExpandAbbreviations(string value)
        {
            switch (value)
            {
                case "src":
                    return "source";
                case "dst":
                    return "destination";
                case "cmd":
                    return "command";
                case "proc":
                    return "procedure";
                case "addr":
                    return "address";
                case "fd":
                    return "fileDescriptor";
                default:
                    return value;
            }
        }

        private static string Normalise(string name)
        {
            if (name == "event" || name == "object")
            {
                return $"@{name}";
            }
            else
            {
                return name;
            }
        }
    }
}
