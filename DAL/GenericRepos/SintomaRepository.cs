using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.GenericRepos
{
    public class SintomaRepository: IGenericRepository<Sintoma>
    {
        private readonly SysCexpertContext _context;
        public SintomaRepository(SysCexpertContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Elimina un registro en la tabla de Sintoma
        /// </summary>
        /// <param name="guid"></param>
        public void Delete(Sintoma guid)
        {
            var r = _context.Sintomas.FirstOrDefault(x => x.IdSintoma == guid.IdSintoma);
            if (r != null)
            {
                _context.Sintomas.Remove(r);
                _context.SaveChanges();
            }
        }

        /// <summary>
        /// Obtiene todos los registros de la tabla Sintoma
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public IEnumerable<Sintoma> GetAll(Sintoma parameters = null)
        {
            return _context.Sintomas.ToList();
        }

        /// <summary>
        /// Obtiene un registro de la tabla de Sintoma
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public Sintoma GetOne(int? guid)
        {
            var r = _context.Sintomas.FirstOrDefault(x => x.IdSintoma == guid);

            return r;
        }

        /// <summary>
        /// Inserta un registro en la tabla de Sintoma
        /// </summary>
        /// <param name="obj"></param>
        public void Insert(Sintoma obj)
        {
            _context.Sintomas.Add(obj);
            _context.SaveChanges();
        }

        /// <summary>
        /// Actualiza un registro en la tabla de Sintoma
        /// </summary>
        /// <param name="obj"></param>
        public void Update(Sintoma obj)
        {
            var sintoma = _context.Sintomas.FirstOrDefault(x => x.IdSintoma == obj.IdSintoma);
            if (sintoma != null)
            {
                sintoma.IdSintoma = obj.IdSintoma;
                //sintoma.Nombre = obj.Nombre;
                _context.Update(sintoma);
                _context.SaveChanges();

            }
        }
    }
}
