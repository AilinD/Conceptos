using DAL.GenericRepos;
using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Factory
{
    /// <summary>
    /// Clase tipo Factory con las interfaces de los repos genericos
    /// </summary>
    public static class FactoryDAL
    {
        public static IGenericRepository<Paciente> _pacienteRepository { get; private set; }
        public static IGenericRepository<Medico> _medicoRepository { get; private set; }
        public static IGenericRepository<Estudio> _estudioRepository { get; private set; }
        public static IGenericRepository<Sintoma> _sintomaRepository { get; private set; }
        public static IGenericRepository<Especialidad> _especialidadRepository { get; private set; }
        public static IGenericRepository<ObraSocial> _obraSocialRepository { get; private set; }
        public static IGenericRepository<Diagnostico> _diagnosticoRepository { get; private set; }
        //public static IGenericRepository<ObraSocialPaciente> _obrasocialPacienteRepository { get; private set; }
        //public static IGenericRepository<MedicoPorEspecialidad> _medicoPorEspecialidadRepository { get; private set; }
        //public static IGenericRepository<SintomaPaciente> _sintomaPacienteRepository { get; private set; }
        //public static IGenericRepository<EstudioPaciente> _estudioPacienteRepository { get; private set; }



        private static SysCexpertContext _SysEntitiesContext;
        private static string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MainConString"].ConnectionString;




        /// <summary>
        /// 
        /// </summary>
        static FactoryDAL()
        {
            _SysEntitiesContext = new SysCexpertContext();
            _pacienteRepository = PatientRepository();
            _medicoRepository = MedicoRepository();
            _estudioRepository = EstudioRepository();
            //_sintomaRepository = SintomaRepository();
            //_especialidadRepository = EspecialidadRepository();
            _obraSocialRepository = ObraSocialRepository();
            _diagnosticoRepository = DiagnosticoRepository();
            //_obrasocialPacienteRepository = ObraSocialPacienteRepository();
            //_medicoPorEspecialidadRepository = MedicoPorEspecialidadRepository();
            //_sintomaPacienteRepository = SintomaPacienteRepository();
            //_estudioPacienteRepository = EstudioPacientedRepository();
        }
        private static PatientRepository PatientRepository()
        {
            return new PatientRepository(_SysEntitiesContext);
        }

        private static MedicoRepository MedicoRepository()
        {
            return new MedicoRepository(_SysEntitiesContext);
        }

        private static EstudioRepository EstudioRepository()
        {
            return new EstudioRepository(_SysEntitiesContext);
        }


        //private static SintomaRepository SintomaRepository()
        //{
        //    return new SintomaRepository(_SysEntitiesContext);
        //}

        //private static EspecialidadRepository EspecialidadRepository()
        //{
        //    return new EspecialidadRepository(_SysEntitiesContext);
        //}

        private static ObraSocialRepository ObraSocialRepository()
        {
            return new ObraSocialRepository(_SysEntitiesContext);
        }

        private static DiagnosticoRepository DiagnosticoRepository()
        {
            return new DiagnosticoRepository(_SysEntitiesContext);
        }

        //private static ObraSocialPacienteRepository ObraSocialPacienteRepository()
        //{
        //    return new ObraSocialPacienteRepository(_SysEntitiesContext);
        //}
        //private static MedicoPorEspecialidadRepository MedicoPorEspecialidadRepository()
        //{
        //    return new MedicoPorEspecialidadRepository(_SysEntitiesContext);
        //}

        //private static SintomaPacienteRepository SintomaPacienteRepository()
        //{
        //    return new SintomaPacienteRepository(_SysEntitiesContext);
        //}
        //private static EstudioPacienteRepository EstudioPacientedRepository()
        //{
        //    return new EstudioPacienteRepository(_SysEntitiesContext);
        //}
    }
}
