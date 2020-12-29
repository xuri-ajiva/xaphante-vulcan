using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Pipeline;

namespace SharpVk.Generator
{
    public class NullStage
        : IStage
    {
        public void Configure(IServiceCollection services)
        {
        }
    }
}
