using System;
using Univer.PlanTask.Core.Store;
using Univer.PlanTask.Core.Store.Impl;
using System.IO;
using System.Collections.Generic;

namespace Univer.PlanTask.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            IBaseStore store = new FileStore();

            var task1 = new Task() { Id = 1, Name = "1" };
            var task2 = new Task() { Id = 2, Name = "2" };
            var task3 = new Task() { Id = 3, Name = "3" };

            //store.Create(task1);
            //store.Create(task2);
            //store.Create(task3);
            var task4 = store.Get(5);
            Console.WriteLine(task4.Id);
            /*string[] a = new string[1];
            a[0] = "2";
            List<IEntity> b = new List<IEntity>(store.GetAll());
            foreach (var i in b)
                Console.WriteLine(i.Id);*/

            /*
            var objs = store.GetAll();

            foreach (var item in objs)
            {
                Console.WriteLine(item.Id);
            }*/
        }
    }
}
