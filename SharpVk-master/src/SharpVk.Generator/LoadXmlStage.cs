using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Pipeline;
using System.IO;

namespace SharpVk.Generator
{
    public class LoadXmlStage
        : IStage
    {
        public void Configure(IServiceCollection services)
        {
            services.AddSingleton<IVkXmlCache>(new VkXmlCache("../../../"));
        }
    }
}
