using GlmSharp;
using SharpVk.Shanq;

namespace vulcan_01
{
    internal struct FragmentInput
    {
        [Location(0)] public vec3 Colour;
        [Location(1)] public vec4 Position;
    }
    internal struct FragmentOutput
    {
        [Location(0)] public vec4 Colour;
    }
}
