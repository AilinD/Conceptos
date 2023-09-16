using DAL.Interfaces;
using DAL.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Especialidad = DAL.Models.Especialidad;

namespace DAL.GenericRepos
{
    public class EspecialidadRepository : IGenericRepository<Especialidad>
    {
  
        private readonly SysCexpertContext _context;
        public EspecialidadRepository(SysCexpertContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Elimina un registro en la tabla de Especialidad
        /// </summary>
        /// <param name="guid"></param>
        public void Delete(Especialidad guid)
        {
            var r = _context.Especialidads.FirstOrDefault(x => x.Id == guid.Id);
            if (r != null)
            {
                _context.Especialidads.Remove(r);
                _context.SaveChanges();
            }
        }

        /// <summary>
        /// Obtiene todos los registros de la tabla de Especialidad
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public IEnumerable<Especialidad> GetAll(Especialidad parameters = null)
        {
            return _context.Especialidads.ToList();
        }

        /// <summary>
        /// Obtiene un registro en la tabla de Especialidad
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public Especialidad GetOne(int? guid)
        {
            var r = _context.Especialidads.FirstOrDefault(x => x.Id == guid);

            return r;
        }

        /// <summary>
        /// Inserta un registro en la tabla de Especialidad
        /// </summary>
        /// <param name="obj"></param>
        public void Insert(Especialidad obj)
        {
            _context.Especialidads.Add(obj);
            _context.SaveChanges();
        }

        /// <summary>
        /// Actualiza un registro en la tabla de Especialidad
        /// </summary>
        /// <param name="obj"></param>
        public void Update(Especialidad obj)
        {
            var especialidad = _context.Especialidads.FirstOrDefault(x => x.Id == obj.Id);
            if (especialidad != null)
            {
                especialidad.Id = obj.Id;
                especialidad.Especialidad1 = obj.Especialidad1;
                _context.Update(especialidad);
                _context.SaveChanges();

            }
        }
    }
}
