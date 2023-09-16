using DAL.Interfaces;
using DAL.Models;
//using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.GenericRepos
{
    public class EstudioRepository : IGenericRepository<Estudio>
    {
        private readonly SysCexpertContext _context;

        public EstudioRepository(SysCexpertContext context)
        {
            _context = context;
        }
        /// <summary>
        ///Elimina un registro en la tabla de Estudio
        /// </summary>
        /// <param name="guid"></param>
        public void Delete(Estudio guid)
        {
            var r = _context.Estudios.FirstOrDefault(x => x.Id == guid.Id);
            if (r != null)
            {
                _context.Estudios.Remove(r);
                _context.SaveChanges();
            }
        }
        /// <summary>
        /// Obtiene todos los registros en la tabla de Estudio
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public IEnumerable<Estudio> GetAll(Estudio parameters = null)
        {
            return _context.Estudios.ToList();
        }

        /// <summary>
        /// Obtiene un registro en la tabla de Estudio
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public Estudio GetOne(int? guid)
        {
            var r = _context.Estudios.FirstOrDefault(x => x.Id == guid);

            return r;
        }
        /// <summary>
        /// Inserta un registro en la tabla de Estudio
        /// </summary>
        /// <param name="obj"></param>
        public void Insert(Estudio obj)
        {
            _context.Estudios.Add(obj);
            _context.SaveChanges();
        }

        /// <summary>
        /// Actualiza un registro en la tabla de Estudio
        /// </summary>
        /// <param name="obj"></param>
        public void Update(Estudio obj)
        {
            var estudio = _context.Estudios.FirstOrDefault(x => x.Id == obj.Id);
            if (estudio != null)
            {
                estudio.Id = obj.Id;
                estudio.Estudio1 = obj.Estudio1;

                _context.Update(estudio);
                _context.SaveChanges();

            }
        }
    }
}
