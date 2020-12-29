using System.Linq;
using GlmSharp;

namespace SharpVk.Shanq.GlmSharp
{
    public static class SamplerExtensions
    {
        public static IQueryable<Sampler2d<T, vec2>> GetSampler2d<T>(this IShanqFactory factory, int binding, int descriptorSet)
        {
            return factory.GetSampler2d<T, vec2>(binding, descriptorSet);
        }
    }
}