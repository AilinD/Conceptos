using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.GenericRepos
{
    public class ObraSocialRepository : IGenericRepository<ObraSocial>
    {
        private readonly SysCexpertContext _context;

        public ObraSocialRepository(SysCexpertContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Elimina un registro en la tabla de ObraSocial
        /// </summary>
        /// <param name="guid"></param>
        public void Delete(ObraSocial guid)
        {
            var r = _context.ObraSocials.FirstOrDefault(x => x.Id == guid.Id);
            if (r != null)
            {
                _context.ObraSocials.Remove(r);
                _context.SaveChanges();
            }
        }

        /// <summary>
        /// Obtiene todos los registros de la tabla de ObraSocial
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public IEnumerable<ObraSocial> GetAll(ObraSocial parameters = null)
        {
            return _context.ObraSocials.ToList();
            
        }

        /// <summary>
        /// Obtiene un registro en la tabla de ObraSocial
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public ObraSocial GetOne(int? guid)
        {
            var r = _context.ObraSocials.FirstOrDefault(x => x.Id == guid);

            return r;

        }

        /// <summary>
        /// Inserta un registro en la tabla de ObraSocial
        /// </summary>
        /// <param name="obj"></param>
        public void Insert(ObraSocial obj)
        {
            _context.ObraSocials.Add(obj);
            _context.SaveChanges();

        }

        /// <summary>
        /// Actualiza un registro en la tabla de ObraSocial
        /// </summary>
        /// <param name="obj"></param>
        public void Update(ObraSocial obj)
        {
            var obrasocial = _context.ObraSocials.FirstOrDefault(x => x.Id == obj.Id);
            if (obrasocial != null)
            {
                obrasocial.Id = obj.Id;
                //obrasocial.Nombre = obj.Nombre;
                _context.Update(obrasocial);
                _context.SaveChanges();

            }
        }
    }
}
