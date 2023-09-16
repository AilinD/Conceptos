using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Medico = DAL.Models.Medico;

namespace DAL.GenericRepos
{
    public class MedicoRepository : IGenericRepository<Medico>
    {
        private readonly SysCexpertContext _context;

        public MedicoRepository(SysCexpertContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Elimina un registro en la tabla de Medico
        /// </summary>
        /// <param name="obj"></param>
        public void Delete(Medico obj)
        {
            var r = _context.Medicos.FirstOrDefault(x => x.Id == obj.Id);
            if (r != null)
            {
                _context.Medicos.Remove(r);
                _context.SaveChanges();
            }
        }

        /// <summary>
        /// Obtiene todos los registros de la tabla de Medico
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public IEnumerable<Medico> GetAll(Medico parameters = null)
        {
            return _context.Medicos.ToList();
        }

        /// <summary>
        /// Obtiene un registro en la tabla de Medico
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public Medico GetOne(int? guid)
        {
            //var r = _context.Medicos.FirstOrDefault(x => x.Id == guid);

            //return r;

            return null;
        }

        /// <summary>
        ///Inserta un registro en la tabla de Medico
        /// </summary>
        /// <param name="obj"></param>
        public void Insert(Medico obj)
        {
            _context.Medicos.Add(obj);
            _context.SaveChanges();
        }

        /// <summary>
        /// Actualiza un registro en la tabla de Medico
        /// </summary>
        /// <param name="obj"></param>
        public void Update(Medico obj)
        {
            var medico = _context.Medicos.FirstOrDefault(x => x.Id == obj.Id);
            if (medico != null)
            {
                medico.Matricula = obj.Matricula;
                medico.Nombre = obj.Nombre;
                medico.Apellido = obj.Apellido;
                //medico. = obj.Contacto;
                medico.Direccion = obj.Direccion;
                _context.Update(medico);
                _context.SaveChanges();

            }
        }
    }
}
