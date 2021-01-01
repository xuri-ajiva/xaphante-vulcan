using GlmSharp;
using SharpVk.Shanq;

namespace vulcan_01
{
    internal struct FragmentInput
    {
        [Location(0)] public vec3 Colour;
    }
    internal struct FragmentOutput
    {
        [Location(0)] public vec4 Colour;
    }
}
