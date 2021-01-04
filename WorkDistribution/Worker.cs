using System;
using System.Collections.Concurrent;
using System.Globalization;
using System.Threading;

namespace WorkDistribution
{
    public class Worker
    {
        internal string WorkName { get; private protected set; }

        internal readonly int WorkerId;
        public WorkerPool WorkerPool { get; private set; }
        private readonly Thread workingThread;

        public Worker(WorkerPool workerPool, in int workerId)
        {
            this.WorkerId = workerId;
            WorkerPool = workerPool;
            workingThread = new(Work)
            {
                Name = $"WorkerThread {workerId} from {WorkerPool.Name}",
                CurrentCulture = CultureInfo.InvariantCulture
            };
        }

        private void Work(object state)
        {
            while (!exit)
            {
                if (!WorkerPool.Enabled)
                {
                    States.Enqueue(WorkResult.Disabeld);
                    while (!WorkerPool.Enabled)
                    {
                        Thread.Sleep(10);
                    }
                }
                WorkInfo work;
                States.Enqueue(WorkResult.Waiting);
                lock (WorkerPool.AvailableLock)
                {
                    while (WorkerPool._available <= 0)
                    {
                        States.Enqueue(WorkResult.Locking);
                        Thread.Sleep(10);
                    }
                    if (!WorkerPool.TryGetWork(out work)) continue;

                    Interlocked.Decrement(ref WorkerPool._available);
                }
                WorkName = work.Name;
                work.ActiveWorker = this;
                States.Enqueue(WorkResult.Working);
                try
                {
                    var result = work.Work.Invoke(this, work, work.UserParam);
                    States.Enqueue(result);
                }
                catch (Exception e)
                {
                    States.Enqueue(WorkResult.Failed);
                    Exceptions.Enqueue(e);
                }
            }
        }

        public ConcurrentQueue<WorkResult> States { get; } = new();
        public ConcurrentQueue<Exception> Exceptions { get; } = new();

        public void Start()
        {
            workingThread.Start();
        }

        private bool exit = false;

        ~Worker()
        {
            exit = true;
        }
    }
}
