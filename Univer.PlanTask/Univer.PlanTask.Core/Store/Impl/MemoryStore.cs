using System;
using System.Collections.Generic;
using System.Linq;

namespace Univer.PlanTask.Core.Store.Impl
{
    public class MemoryStore : IBaseStore
    {
        private readonly List<IEntity> entities = new List<IEntity>();

        public void Create(IEntity model)
        {
            entities.Add(model);
        }

        public bool Delete(long Id)
        {
            string[] args = new string[] { Id.ToString()};
            if (this.Find(args) != null)
            {
                entities.Remove(Find(args).First());
                return true;
            }
            else
                return false;
        }

        public IEnumerable<IEntity> Find(string[] args)
        {
            long id = -1;
            if (args.Count() != 0 && args[0].Count() != 0)
                id = Convert.ToInt64(args[0]);
            List<IEntity> FindEntities = new List<IEntity>(); 
            if (id != -1)
                foreach (var entity in entities)
                    if (entity.Id == id)
                        FindEntities.Add(entity);
            if (FindEntities.Count == 0)
                return null;
            return FindEntities;
        }

        public IEntity Get(long Id)
        {
            string[] args = new string[] { Id.ToString() };
            if (Find(args) != null)
                return Find(args).First();
            return null;
        }

        public IEnumerable<IEntity> GetAll()
        {
            return entities;
        }

        public void Update(IEntity model)
        {
            Delete(model.Id);
            Create(model);
        }
    }
}
