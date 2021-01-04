using System;
using System.Threading;
using System.Threading.Tasks;
using WorkDistribution;

namespace WorkTest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            const int workerCount = 32;
            Console.WindowHeight = workerCount+4;

            const int min = 100;
            const int max = 500;
            var pool = new WorkerPool(workerCount, "Test Pool");

            static WorkResult RngFailTask(object sender, WorkInfo info, object param)
            {
                var r = new Random();
                Thread.Sleep(r.Next(min, max));

                if (r.NextDouble() > .95) throw new("Failed in rng test");

                return WorkResult.Succeeded;
            }

            static WorkResult LoadTask(object sender, WorkInfo info, object param)
            {
                var r = new Random();
                var stop = DateTime.Now.AddMilliseconds(r.Next(min*4, max*4));
                while ((stop - DateTime.Now).TotalMilliseconds > 0)
                {
                    if (r.NextDouble() > .99)
                    {
                        throw new ArgumentException("throw due to rng");
                    }
                    continue;
                }

                return WorkResult.Succeeded;
            }

            var rng = new Random();
            for (var i = 0; i < 50000; i++)
            {
                var load = rng.NextDouble() > .95;
                pool.EnqueueWork(load ? LoadTask : RngFailTask, (WorkPriority)rng.Next((int)WorkPriority.Min, (int)WorkPriority.Max), load ? nameof(LoadTask) : nameof(RngFailTask));
            }

            pool.Enabled = true;

            await pool.StartMonitoring(DateTime.Now.AddMinutes(10), 5, 1000);
            await Task.Delay(-1);
        }
    }
}
