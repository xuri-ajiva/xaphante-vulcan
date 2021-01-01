using System.Runtime.InteropServices;
using GlmSharp;
using SharpVk;
using SharpVk.Shanq;

namespace vulcan_01
{
    internal struct Vertex
    {
        public Vertex(vec2 position, vec3 colour)
        {
            Position = position;
            Colour = colour;
        }

        [Location(0)] public vec2 Position;

        [Location(1)] public vec3 Colour;

        public static VertexInputBindingDescription GetBindingDescription()
        {
            return new()
            {
                Binding = 0,
                Stride = (uint)Marshal.SizeOf<Vertex>(),
                InputRate = VertexInputRate.Vertex
            };
        }

        public static VertexInputAttributeDescription[] GetAttributeDescriptions()
        {
            return new[]
            {
                new VertexInputAttributeDescription
                {
                    Binding = 0,
                    Location = 0,
                    Format = Format.R32G32SFloat,
                    Offset = (uint)Marshal.OffsetOf<Vertex>("Position")
                },
                new VertexInputAttributeDescription
                {
                    Binding = 0,
                    Location = 1,
                    Format = Format.R32G32B32SFloat,
                    Offset = (uint)Marshal.OffsetOf<Vertex>("Colour")
                }
            };
        }
    }
}