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

        public DateTime StartDate { get; set; }

        public Task()
        {
            Id = 0;
            Name = "";
            StartDate = new DateTime();
            Deadline = new DateTime();
            Status = 0;
        }

        public Task(long id, string name, DateTime startDate, DateTime deadline)
        {
            Id = id;
            Name = name;
            StartDate = startDate;
            Deadline = deadline;
            Status = 0;
        }
    }
}
