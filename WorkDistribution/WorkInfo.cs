namespace WorkDistribution
{
    public class WorkInfo
    {
        internal WorkInfo(WorkPriority priority, Work work, string name, object userParam = default)
        {
            Priority = priority;
            Work = work;
            Name = name;
            UserParam = userParam;
        }

        public Worker ActiveWorker { get; internal set; }
        public WorkPriority Priority { get; }
        public Work Work { get; }
        public string Name { get; }
        internal object UserParam { get; }
    }
}