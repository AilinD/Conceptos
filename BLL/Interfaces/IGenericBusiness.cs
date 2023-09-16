using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    /// <summary>
    /// Clase generica para aplicar UnitOfWork para que los repos genericos tengan los metodos necesarios para interactuar con la base
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IGenericBusiness<T> where T : class, new()
    {
        /// <summary>
        /// Inserta un objeto en el repositorio.
        /// </summary>
        /// <param name="obj"></param>
        void Insert(T obj);

        /// <summary>
        /// Actualiza un registro en el repositorio.
        /// </summary>
        /// <param name="obj"></param>
        void Update(T obj);

        /// <summary>
        /// Obtiene todos los registros del repositorio.
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetAll();

        /// <summary>
        /// Obtiene un registro del repositorio.
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        T GetOne(int? guid);

        /// <summary>
        /// Elimina un registro del repositorio.
        /// </summary>
        /// <param name="guid"></param>
        void Delete(int? guid);
    }
}
