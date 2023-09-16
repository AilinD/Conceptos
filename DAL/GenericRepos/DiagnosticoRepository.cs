using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.GenericRepos
{
    internal class DiagnosticoRepository : IGenericRepository<Diagnostico>
    {
        private readonly SysCexpertContext _context;
        public DiagnosticoRepository(SysCexpertContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Elimina un registro en la tabla de Diagnostico
        /// </summary>
        /// <param name="guid"></param>
        public void Delete(Diagnostico guid)
        {
            var r = _context.Diagnosticos.FirstOrDefault(x => x.Id == guid.Id);
            if (r != null)
            {
                _context.Diagnosticos.Remove(r);
                _context.SaveChanges();
            }
        }

        /// <summary>
        /// Obtiene todos los registros de la tabla Diagnostico 
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public IEnumerable<Diagnostico> GetAll(Diagnostico parameters = null)
        {
            return _context.Diagnosticos.ToList();
        }

            public Diagnostico GetOne(int? guid)
        {
            //var r = _context.Diagnosticos.FirstOrDefault(x => x.Id == guid);

            //return r;

            return null;
        }

        /// <summary>
        /// Inserta un registro en la tabla de Diagnostico
        /// </summary>
        /// <param name="obj"></param>
        public void Insert(Diagnostico obj)
        {
            _context.Diagnosticos.Add(obj);
            _context.SaveChanges();
        }

        /// <summary>
        /// Modifica un registro en la tabla de Diagnostico
        /// </summary>
        /// <param name="obj"></param>
        public void Update(Diagnostico obj)
        {
            var diagnostico = _context.Diagnosticos.FirstOrDefault(x => x.Id == obj.Id);
            if (diagnostico != null)
            {
                diagnostico.Id = obj.Id;
                diagnostico.Fecha = obj.Fecha;
                diagnostico.MatriculaMedico = obj.MatriculaMedico;
                diagnostico.Diagnostico1 = obj.Diagnostico1;
                diagnostico.Dnipaciente=obj.Dnipaciente;
                _context.Update(diagnostico);
                _context.SaveChanges();

            }
        }
    }
}
