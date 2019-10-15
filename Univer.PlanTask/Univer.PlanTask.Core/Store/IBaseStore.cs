using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univer.PlanTask.Core.Store
{
    /// <summary>
    /// Интерфейс базового хранилища
    /// </summary>
    public interface IBaseStore
    {
        /// <summary>
        /// Получить объект по идентификатору
        /// </summary>
        /// <param name="Id">Идентификатор</param>
        /// <returns>Объект</returns>
        IEntity Get(long Id);
        /// <summary>
        /// Создать объект, передав объект
        /// </summary>
        /// <param name="model">Объект</param>
        void Create(IEntity model);
        /// <summary>
        /// Удалить объект по идентификатору
        /// </summary>
        /// <param name="Id">Идентификатор</param>
        /// <returns></returns>
        bool Delete(long Id);
        /// <summary>
        /// Обновить объект,передав объект
        /// </summary>
        /// <param name="model">Объект</param>
        void Update(IEntity model);
        /// <summary>
        /// Возвратить все объекты хранилища
        /// </summary>
        /// <returns>Объекты хранилища</returns>
        IEnumerable<IEntity> GetAll();
        /// <summary>
        /// Поиск объектов хранилища
        /// </summary>
        /// <param name="args">Параметр поиска</param>
        /// <returns>Объекты хранилища</returns>
        IEnumerable<IEntity> Find(string[] args);
    }
}
