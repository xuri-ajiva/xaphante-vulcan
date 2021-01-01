using System.Numerics;
using System.Runtime.InteropServices;
using GlmSharp;
using SharpVk.Shanq;
using SharpVk.Spirv;

namespace vulcan_01
{
    internal struct UniformBufferObject
    {
        public mat4 Model;
        public mat4 View;
        public mat4 Proj;
    };
}
