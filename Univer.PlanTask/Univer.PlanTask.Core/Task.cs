using System;
using Univer.PlanTask.Core.Store;

namespace Univer.PlanTask.Core
{
    public class Task : IEntity
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public DateTime Deadline { get; set; }

        public TaskStatus Status { get; set; }

        public Task()
        {
            Id = 0;
            Name = "";
            Deadline = new DateTime();
            Status = 0;
        }

        public Task(long id, string name, DateTime deadline)
        {
            Id = id;
            Name = name;
            Deadline = deadline;
            Status = 0;
        }
    }
}
