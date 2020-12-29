using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Collation;
using SharpVk.Generator.Pipeline;
using System.Collections.Generic;
using System.Linq;

namespace SharpVk.Generator.Generation
{
    public class PrimitiveGenerator
        : IWorker
    {
        private readonly Dictionary<string, TypeDeclaration> typeData;

        public PrimitiveGenerator(Dictionary<string, TypeDeclaration> typeData)
        {
            this.typeData = typeData;
        }

        public void Execute(IServiceCollection services)
        {
            foreach (var type in this.typeData.Values.Where(x => x.Pattern == TypePattern.Primitive))
            {
            }
        }
    }
}
