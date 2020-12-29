using Microsoft.Extensions.DependencyInjection;

namespace SharpVk.Generator.Pipeline
{
    public interface IWorker
    {
        void Execute(IServiceCollection services);
    }
}
