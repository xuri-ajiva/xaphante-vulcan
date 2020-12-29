using System;
using System.Collections.Generic;

namespace SharpVk.Generator.Pipeline
{
    public class PipelineBuilder
    {
        private List<Type> stages = new List<Type>();

        private PipelineBuilder(Type initialStage)
        {
            this.AddStage(initialStage);
        }

        public static PipelineBuilder Create<T>()
            where T : IStage
        {
            return new PipelineBuilder(typeof(T));
        }

        public PipelineBuilder Extend<T>()
            where T : IStage
        {
            this.AddStage(typeof(T));

            return this;
        }

        private void AddStage(Type stage)
        {
            this.stages.Add(stage);
        }

        public Pipeline Build()
        {
            return new Pipeline(this.stages);
        }
    }
}
