using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Pipeline;

namespace SharpVk.Generator.Collation
{
    public class CollationStage
        : IStage
    {
        public void Configure(IServiceCollection services)
        {
            services.AddSingleton<NameFormatter>();
            services.AddSingleton<IWorker, TypeCollator>();
            services.AddSingleton<IWorker, CommandCollator>();
            services.AddSingleton<IWorker, EnumCollator>();
            services.AddSingleton<IWorker, DelegateCollator>();
            services.AddSingleton<IWorker, ConstantCollator>();
            services.AddSingleton<IWorker, PassthroughWorker<ExtensionInfo>>();
            services.AddSingleton<IWorker, ExtensionCollator>();
        }
    }
}
