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
    public class PatientRepository : IGenericRepository<Paciente>
    {
        private readonly SysCexpertContext _context;

        public PatientRepository(SysCexpertContext context)
        {
            _context = context;
        }


        /// <summary>
        /// Elimina un registro en la tabla de Paciente
        /// </summary>
        /// <param name="obj"></param>
        public void Delete(Paciente obj)
        {
            var r = _context.Pacientes.FirstOrDefault(x => x.IdPaciente == obj.IdPaciente);
            if (r != null)
            {
                _context.Pacientes.Remove(r);
                _context.SaveChanges();
            }

        }

        /// <summary>
        /// Obtiene todos los registros de la tabla Paciente
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public IEnumerable<Paciente> GetAll(Paciente parameters = null)
        {
            return _context.Pacientes.ToList();
        }

        /// <summary>
        /// Obtiene un registro en la tabla de Paciente
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public Paciente GetOne(int? guid)
        {
            var r = _context.Pacientes.FirstOrDefault(x => x.IdPaciente == guid);

            return r;
        }

        /// <summary>
        /// Inserta un registro en la tabla de Paciente
        /// </summary>
        /// <param name="obj"></param>
        public void Insert(Paciente obj)
        {
            _context.Pacientes.Add(obj);
            _context.SaveChanges();

        }

        /// <summary>
        /// Elimina un registro en la tabla de Paciente
        /// </summary>
        /// <param name="obj"></param>
        public void Update(Paciente obj)
        {
            var patient = _context.Pacientes.FirstOrDefault(x => x.IdPaciente == obj.IdPaciente);
            if (patient != null)
            {
                patient.Dni = obj.Dni;
                patient.Nombre = obj.Nombre;
                patient.Apellido = obj.Apellido;
                patient.Contacto = obj.Contacto;
                //patient.Dirección = obj.Dirección;
                patient.Sexo = obj.Sexo;
                patient.FechaNacimiento = obj.FechaNacimiento;
                _context.Update(patient);
                _context.SaveChanges();

            }
        }

        /// <summary>
        /// Obtiene un registro en la tabla de Paciente
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ObraSocial> GetObraSocial()
        {
            return _context.ObraSocials.ToList();

        }
    }
}
