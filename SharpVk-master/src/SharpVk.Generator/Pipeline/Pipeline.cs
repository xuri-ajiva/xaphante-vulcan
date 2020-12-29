using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SharpVk.Generator.Pipeline
{
    public class Pipeline
    {
        private readonly IEnumerable<Type> stages;

        internal Pipeline(IEnumerable<Type> stages)
        {
            this.stages = stages;
        }

        public void Run()
        {
            var services = new ServiceCollection();

            var initial = this.stages.First();

            var stage = (IStage)Activator.CreateInstance(initial);

            Console.WriteLine($"Initial Stage: {stage.GetType().Name}");

            stage.Configure(services);

            foreach (var stageType in this.stages.Skip(1).Take(this.stages.Count() - 2))
            {
                var setup = (IStage)Activator.CreateInstance(stageType);

                Console.WriteLine($"Stage: {setup.GetType().Name}");

                setup.Configure(services);

                var stageProvider = services.BuildServiceProvider();

                services = new ServiceCollection();

                foreach(var worker in stageProvider.GetServices<IWorker>())
                {
                    Console.WriteLine($"Running: {worker.GetType().Name}");

                    worker.Execute(services);
                }
            }

            var outputStage = (IStage)Activator.CreateInstance(this.stages.Last());

            Console.WriteLine($"Output Stage: {outputStage.GetType().Name}");

            outputStage.Configure(services);

            var outputProvider = services.BuildServiceProvider();
            
            foreach (var output in outputProvider.GetServices<IOutputWorker>())
            {
                Console.WriteLine($"Running: {output.GetType().Name}");

                output.Execute();
            }
            
            foreach (var cleanup in outputProvider.GetServices<ICleanupWorker>())
            {
                Console.WriteLine($"Running: {cleanup.GetType().Name}");

                cleanup.Execute();
            }
        }
    }
}
