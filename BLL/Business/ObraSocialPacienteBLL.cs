using BLL.Dto;
using BLL.Interfaces;
using BLL.MapperConfig;
using DAL;
using DAL.Factory;
using DAL.Interfaces;
using DAL.Models;
using Services.BLL.Exepciones;
//using DAL.Models;
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
    public class ObraSocialPacienteBLL : IGenericBusiness<ObraSocialPacienteDto>
    {

        private readonly static ObraSocialPacienteBLL _instance = new ObraSocialPacienteBLL();


        public static ObraSocialPacienteBLL Current
        {
            get
            {
                return _instance;
            }
        }

        IGenericRepository<ObraSocialPaciente> genericRepository = FactoryDAL._obrasocialPacienteRepository;


        /// <summary>
        /// Inserta un registro en la tabla ObraSocialPaciente
        /// </summary>
        /// <param name="obj"></param>
        public void Insert(ObraSocialPacienteDto obj)
        {
            try
            {
                var dtoToentity = new ObraSocialPaciente()
                {
                    Id = obj.Id,
                    IdPaciente = obj.IdPaciente,
                    IdObraSocial=obj.IdObraSocial

                };
                genericRepository.Insert(dtoToentity);
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);

                 
            }

        }

        /// <summary>
        /// Acualiza un registro en la tabla ObraSocialPaciente
        /// </summary>
        /// <param name="obj"></param>
        public void Update(ObraSocialPacienteDto obj)
        {
            try
            {
                var dtoToentity = new ObraSocialPaciente()
                {
                    Id = obj.Id,
                    IdPaciente = obj.IdPaciente,
                    IdObraSocial = obj.IdObraSocial

                };
                genericRepository.Update(dtoToentity);
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);

                 
            }

        }

        /// <summary>
        /// Obtiene todos los registros en la tabla ObraSocialPaciente
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ObraSocialPacienteDto> GetAll()
        {
            try
            {
                var entity = MapperHelper.GetMapper().
            Map<List<ObraSocialPacienteDto>>(genericRepository.GetAll());

                return entity;
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);

                 
            }
            return null;

        }

        /// <summary>
        /// Obtiene un registro de la tabla ObraSocialPaciente
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public ObraSocialPacienteDto GetOne(int? guid)
        {
            try
            {
                var op = MapperHelper.GetMapper().Map<ObraSocialPaciente,ObraSocialPacienteDto>(genericRepository.GetOne(guid));

                return op;
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);

                 
            }
            return null;

        }

        /// <summary>
        /// Elimina un registro de la tabla ObraSocialPaciente
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
