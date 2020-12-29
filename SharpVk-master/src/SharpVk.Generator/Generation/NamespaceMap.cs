using System.Collections.Generic;

namespace SharpVk.Generator.Generation
{
    public class NamespaceMap
    {
        public IEnumerable<string> Map(string extension)
        {
            if (extension == null)
            {
                yield break;
            }

            switch (extension.ToLower())
            {
                case "khr":
                    yield return "Khronos";
                    break;
                case "ext":
                    yield return "Multivendor";
                    break;
                case "khx":
                    yield return "Khronos";
                    yield return "Experimental";
                    break;
                case "mvk":
                    yield return "MoltenVk";
                    break;
                case "nv":
                    yield return "NVidia";
                    break;
                case "nvx":
                    yield return "NVidia";
                    yield return "Experimental";
                    break;
                case "nn":
                    yield return "Nintendo";
                    break;
                default:
                    yield return extension.FirstToUpper();
                    break;
            }
        }
    }
}
