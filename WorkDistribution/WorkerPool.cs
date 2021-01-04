using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace WorkDistribution
{
    public class WorkerPool
    {
        private const int DefaultWorkerCount = 16;
        public static WorkerPool Default = new(DefaultWorkerCount, nameof(Default));

        internal readonly Worker[] workers;
        internal int _available;
        internal int Available { get; set; }
        internal object AvailableLock = new();

        public string Name { get; set; }

        private ConcurrentDictionary<WorkPriority, ConcurrentQueue<WorkInfo>> concurrentPriorityQueue = new();

        public WorkerPool(int workerCount, string name)
        {
            Name = name;
            Available = 0;
            workers = new Worker[workerCount];
            for (var i = 0; i < workerCount; i++)
            {
                workers[i] = new(this, i);
                workers[i].Start();
            }
        }

        public void EnqueueWork(Work work, WorkPriority priority, string name, object userParam = default)
        {
            var wi = new WorkInfo(priority, work, name, userParam);
            concurrentPriorityQueue.AddOrUpdate(priority, p =>
            {
                var q = new ConcurrentQueue<WorkInfo>(new WorkInfo[]
                {
                    wi
                });
                return q;
            }, (p, queue) =>
            {
                queue.Enqueue(wi);
                return queue;
            });

            Interlocked.Increment(ref _available);
        }

        public bool HasWork
        {
            [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.AggressiveOptimization)]
            get => concurrentPriorityQueue.Any(x => !x.Value.IsEmpty);
        }
        public bool Enabled { get; set; }

        [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.AggressiveOptimization)]
        public bool TryGetWork(out WorkInfo workInfo)
        {
            var query = concurrentPriorityQueue.OrderBy(x => x.Key).Select(x => x.Value).FirstOrDefault(x => !x.IsEmpty);
            if (query != null)
            {
                return query.TryDequeue(out workInfo);
            }
            workInfo = default;
            return false;
        }

        public async Task StartMonitoring(DateTime until, int periodMs, int exceptionMs)
        {
            var posStart = Console.CursorTop;

            int header = 2;
            Console.SetCursorPosition(0, posStart + 0);
            Console.WriteLine("Monitoring Started...");
            var format = "X" + workers.Length.ToString("X").Length;

            var lastStates = new WorkResult[workers.Length];
            var lastException = new Exception[workers.Length];

            static string FormatException(Exception e) => e is null ? "" : $"  -- Last Exception: {e.GetType()}: {e.Message}";

            void PrintWorkerStateBlockStateGet(int index)
            {
                Console.SetCursorPosition(0, posStart + index + header);

                Exception exception;
                WorkResult state;
                bool hasException;
                bool hasState;
                if (workers[index].Exceptions.Count > 1)
                {
                    hasException = true;
                    exception = workers[index].Exceptions.ToArray().Last();
                    workers[index].Exceptions.Clear();
                }
                else
                    hasException = workers[index].Exceptions.TryDequeue(out exception);

                if (hasException)
                {
                    lastException[index] = exception;
                    Task.Run(async () =>
                    {
                        await Task.Delay(exceptionMs);

                        if (lastException[index] == exception)
                        {
                            lastException[index] = null;
                        }
                    });
                }
                if (workers[index].States.Count > 1)
                {
                    hasState = true;
                    state = workers[index].States.ToArray().Last();
                    workers[index].States.Clear();
                }
                else
                    hasState = workers[index].States.TryDequeue(out state);

                if (hasState)
                {
                    lastStates[index] = state;
                }
                var print = string.Format("{0} {1} {2} {3}",
                    nameof(Worker),
                    workers[index].WorkerId.ToString(format),
                    $" [{(hasState ? state : lastStates[index])}] ~> {workers[index].WorkName}",
                    hasException ? FormatException(exception) : lastException[index] != null ? FormatException(lastException[index]) : "");

                Console.Write(print.FillUp(Console.BufferWidth - 1));
            }

            void PrintWorkerState(int index)
            {
                Console.SetCursorPosition(0, posStart + index + header);

                var hasException = workers[index].Exceptions.TryDequeue(out var exception);

                if (hasException)
                {
                    lastException[index] = exception;
                    Task.Run(async () =>
                    {
                        await Task.Delay(exceptionMs);

                        if (lastException[index] == exception)
                        {
                            lastException[index] = null;
                        }
                    });
                }

                var hasState = workers[index].States.TryDequeue(out var state);
                if (hasState)
                {
                    lastStates[index] = state;
                }
                var print = string.Format("{0} {1} {2} {3}",
                    nameof(Worker),
                    workers[index].WorkerId.ToString(format),
                    $" [{(hasState ? state : lastStates[index])}] ~> {workers[index].WorkName}",
                    hasException ? FormatException(exception) : lastException[index] != null ? FormatException(lastException[index]) : "");

                Console.Write(print.FillUp(Console.BufferWidth - 1));
            }

            for (int i = 0; i < workers.Length; i++)
                PrintWorkerState(i);

            while ((until - DateTime.Now).TotalMilliseconds > 0)
            {
                Console.SetCursorPosition(0, posStart + 1);
                Console.WriteLine($"Open Workers: {workers.Length} Work: {_available}".FillUp(Console.BufferWidth - 1));

                for (int i = 0; i < workers.Length; i++)
                {
                    if (!workers[i].States.Any() && !workers[i].Exceptions.Any()) continue;

                    PrintWorkerState(i);
                }

                await Task.Delay(periodMs);
            }
        }
    }
}
