using SharpVk.Generator.Collation;
using SharpVk.Generator.Emission;
using SharpVk.Generator.Generation;
using SharpVk.Generator.Pipeline;
using SharpVk.Generator.Specification;

namespace SharpVk.Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            var pipeline = PipelineBuilder.Create<LoadXmlStage>()
                                            .Extend<SpecParserStage>()
                                            .Extend<CollationStage>()
                                            .Extend<GenerationStage>()
                                            .Extend<EmissionStage>()
                                            .Build();

            pipeline.Run();
        }
    }
}