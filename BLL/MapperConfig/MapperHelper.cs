using AutoMapper;
using DAL.Models;
//using Services.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.MapperConfig
{ 
    /// <summary>
    /// Clase que contiene las configraciones del AutoMapper para poder mapear los objetos locales con los necesarios para la base
    /// </summary>
    public static class MapperHelper
    {
        readonly private static IMapper _mapper;
         static  MapperHelper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<DAL.Models.Paciente, Domain.Paciente>();
                cfg.CreateMap<Domain.Paciente,DAL.Models.Paciente > ();
                cfg.CreateMap<Medico, Domain.Medico>();
                cfg.CreateMap<Domain.Medico, Medico>();
                cfg.CreateMap<Domain.Estudio, Estudio>();
                cfg.CreateMap<Estudio, Domain.Estudio>();
                cfg.CreateMap<Sintoma, Domain.Sintoma>();
                cfg.CreateMap<Domain.Sintoma, Sintoma>();
                //cfg.CreateMap<Especialidad, EspecialidadDto>();
                //cfg.CreateMap<EspecialidadDto, Especialidad>();
                //cfg.CreateMap<ObraSocial, ObraSocialDto>();
                //cfg.CreateMap<ObraSocialDto, ObraSocial>();
                //cfg.CreateMap<Diagnostico,DiagnosticoDto>();
                //cfg.CreateMap<DiagnosticoDto, Diagnostico>();
                //cfg.CreateMap<ObraSocialPaciente, ObraSocialPacienteDto>();
                //cfg.CreateMap<ObraSocialPacienteDto, ObraSocialPaciente>();
                //cfg.CreateMap<MedicoPorEspecialidad, MedicoPorEspecialidadDto>();
                //cfg.CreateMap<MedicoPorEspecialidadDto, MedicoPorEspecialidad>();
                //cfg.CreateMap<EstudioPaciente, Domain.EstudioPaciente>();
                //cfg.CreateMap<Domain.EstudioPaciente, EstudioPaciente>();
                //cfg.CreateMap<SintomaPaciente, SintomaPacienteDto>();
                //cfg.CreateMap<SintomaPacienteDto, SintomaPaciente>();
            });

            _mapper = config.CreateMapper();
  
        }

        /// <summary>
        /// Devuelve el mapper solicitado
        /// </summary>
        /// <returns></returns>
        public static IMapper GetMapper()
        {
            return _mapper;
        }

    }
}
