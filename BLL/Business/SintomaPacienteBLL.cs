using BLL.Dto;
using BLL.Interfaces;
using BLL.MapperConfig;
using DAL.Factory;
using DAL.Interfaces;
using DAL.Models;
using Services.BLL.Exepciones;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Business
{
    /// <summary>
    /// Clase de negocio, a traves del UnitOfWork tiene los metodos necesarios para poder comunciarse con la capa de Datos
    /// </summary>
    public class SintomaPacienteBLL : IGenericBusiness<SintomaPacienteDto>
    {

        private readonly SysCExpertContext _context;

        #region Singleton
        private readonly static SintomaPacienteBLL _instance = new SintomaPacienteBLL();

        public static SintomaPacienteBLL Current
        {
            get
            {
                return _instance;
            }
        }


        #endregion

        IGenericRepository<SintomaPaciente> genericRepository = FactoryDAL._sintomaPacienteRepository;

        public SintomaPacienteBLL()
        {
            _context = new SysCExpertContext(ConfigurationManager.ConnectionStrings["MainConString"].ConnectionString);
        }

        /// <summary>
        /// Inserta un registro en la tabla SintomaPaciente
        /// </summary>
        /// <param name="obj"></param>
        public void Insert(SintomaPacienteDto obj)
        {
            try
            {
                var dtoToentity = new SintomaPaciente()
                {
                    IdSintoma = obj.IdSintoma,
                    IdPaciente = obj.IdPaciente,
                    IdMedico = obj.IdMedico,
                    Fecha = obj.Fecha,


                };
                genericRepository.Insert(dtoToentity);
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);

                 
            }
        }
        /// <summary>
        /// Actualiza un registro en la tabla SintomaPaciente
        /// </summary>
        /// <param name="obj"></param>
        public void Update(SintomaPacienteDto obj)
        {
            try
            {
                var dtoToentity = new SintomaPaciente()
                {
                    IdSintoma = obj.IdSintoma,
                    IdPaciente = obj.IdPaciente,
                    IdMedico = obj.IdMedico,
                    Fecha=obj.Fecha,


                };
                genericRepository.Update(dtoToentity);
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);

                 
            }
        }

        /// <summary>
        /// Obtiene todos los registros de la tabla SintomaPaciente
        /// </summary>
        /// <returns></returns>
        public IEnumerable<SintomaPacienteDto> GetAll()
        {
            try
            {
                var entity = MapperHelper.GetMapper().
            Map<List<SintomaPacienteDto>>(genericRepository.GetAll());

                return entity;
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);

                 
            }
            return null;

        }

        /// <summary>
        /// Obtiene un registro de la tabla SintomaPaciente
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public SintomaPacienteDto GetOne(int? guid)
        {
            try
            {
                var op = MapperHelper.GetMapper().Map<SintomaPacienteDto>(genericRepository.GetOne(guid));

                return op;
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);

                 
            }
            return null;

        }

        /// <summary>
        /// Elimina un registro en la tabla SintomaPaciente
        /// </summary>
        /// <param name="guid"></param>
        public void Delete(int? guid)
        {
            try
            {
                var op = genericRepository.GetOne(guid);
                if (op != null)
                {
                    genericRepository.Delete(op);
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);

                 
            }
        }

    }
}
