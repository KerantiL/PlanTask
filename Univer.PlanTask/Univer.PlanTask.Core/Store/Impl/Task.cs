using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univer.PlanTask.Core.Store;

namespace Univer.PlanTask.ConsoleApp
{
    public class Task : IEntity
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public Task()
        {
            Id = 0;
            Name = "";
        }

        public Task(long _id)
        {
            Id = _id;
            Name = "";
        }
    }
}
