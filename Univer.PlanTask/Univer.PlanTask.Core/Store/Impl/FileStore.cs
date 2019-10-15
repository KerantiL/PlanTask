using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Univer.PlanTask.ConsoleApp;

namespace Univer.PlanTask.Core.Store.Impl
{
    public class FileStore : IBaseStore
    {
        public void Create(IEntity model)
        {
            StreamWriter sw = new StreamWriter("D:\\PlanTask\\Univer.PlanTask\\Univer.PlanTask.ConsoleApp\\FileStore.txt", true);
            sw.WriteLine(Convert.ToString(model.Id));
            sw.Close();
        }

        public bool Delete(long Id)
        {
            StreamReader sr = new StreamReader("D:\\PlanTask\\Univer.PlanTask\\Univer.PlanTask.ConsoleApp\\FileStore.txt");

            bool del = false;

            string fileStoreStr = "";
            string str;

            while ((str = sr.ReadLine()) != null)
                if (str != Convert.ToString(Id))
                    fileStoreStr += str + "\n";
                else
                    del = true;
            sr.Close();
            StreamWriter sw = new StreamWriter("D:\\PlanTask\\Univer.PlanTask\\Univer.PlanTask.ConsoleApp\\FileStore.txt");
            sw.Write(fileStoreStr, false);
            sw.Close();
            return del;
        }

        public IEnumerable<IEntity> Find(string[] args)
        {
            StreamReader sr = new StreamReader("D:\\PlanTask\\Univer.PlanTask\\Univer.PlanTask.ConsoleApp\\FileStore.txt");

            long id = -1;

            string str;

            if (args.Count() != 0 && args[0].Count() != 0)
                id = Convert.ToInt64(args[0]);

            List<IEntity> FindEntities = new List<IEntity>();

            if (id != -1)
                while ((str = sr.ReadLine()) != null)
                    if (str == Convert.ToString(id))
                        FindEntities.Add(new Task(id));
            sr.Close();
            if (FindEntities.Count == 0)
                return null;
            return FindEntities;
        }

        public IEntity Get(long Id)
        {
            StreamReader sr = new StreamReader("D:\\PlanTask\\Univer.PlanTask\\Univer.PlanTask.ConsoleApp\\FileStore.txt");
            string str;
            while ((str = sr.ReadLine()) != null)
                if (str == Convert.ToString(Id))
                {
                    sr.Close();
                    return new Task(Id);
                }
            sr.Close();
            return null;
        }

        public IEnumerable<IEntity> GetAll()
        {
            StreamReader sr = new StreamReader("D:\\PlanTask\\Univer.PlanTask\\Univer.PlanTask.ConsoleApp\\FileStore.txt");
            string str;
            List<IEntity> entities = new List<IEntity>();
            while ((str = sr.ReadLine()) != null)
                entities.Add(new Task(Convert.ToInt64(str)));
            sr.Close();
            if (entities.Count != 0)
                return entities;
            return null;
        }

        public void Update(IEntity model)
        {
            StreamReader sr = new StreamReader("D:\\PlanTask\\Univer.PlanTask\\Univer.PlanTask.ConsoleApp\\FileStore.txt");
            string str;
            string fileStoreStr = "";
            while ((str = sr.ReadLine()) != null)
            {
                if (Convert.ToInt64(str) != model.Id)
                    fileStoreStr += str + "\n";
                else
                    fileStoreStr += Convert.ToString(model.Id) + "\n";
            }
            sr.Close();
            StreamWriter sw = new StreamWriter("D:\\PlanTask\\Univer.PlanTask\\Univer.PlanTask.ConsoleApp\\FileStore.txt");
            sw.Write(fileStoreStr);
            sw.Close();
        }
    }
}
