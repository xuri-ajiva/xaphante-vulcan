using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Pipeline;
using System.Collections.Generic;

namespace SharpVk.Generator
{
    public class PassthroughWorker<T>
        : IWorker
        where T: class
    {
        private readonly IEnumerable<T> items;

        public PassthroughWorker(IEnumerable<T> items)
        {
            this.items = items;
        }

        public void Execute(IServiceCollection services)
        {
            foreach(var item in items)
            {
                services.AddSingleton(item);
            }
        }
    }
}
