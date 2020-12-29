using Microsoft.Extensions.DependencyInjection;

namespace SharpVk.Generator.Pipeline
{
    public interface IStage
    {
        void Configure(IServiceCollection services);
    }
}
