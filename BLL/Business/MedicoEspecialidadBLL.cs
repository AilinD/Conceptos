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
    public class MedicoEspecialidadBLL : IGenericBusiness<MedicoPorEspecialidadDto>
    {
        private readonly SysCExpertContext _context;

        #region Singleton
        private readonly static MedicoEspecialidadBLL _instance = new MedicoEspecialidadBLL();

        public static MedicoEspecialidadBLL Current
        {
            get
            {
                return _instance;
            }
        }


        #endregion

        IGenericRepository<MedicoPorEspecialidad> genericRepository = FactoryDAL._medicoPorEspecialidadRepository;
        public MedicoEspecialidadBLL()
        {
            _context = new SysCExpertContext(ConfigurationManager.ConnectionStrings["MainConString"].ConnectionString);
        }

        /// <summary>
        /// Inserta un registro en la tabla MedicoPorEspecialidad
        /// </summary>
        /// <param name="obj"></param>
        public void Insert(MedicoPorEspecialidadDto obj)
        {
            try
            {
                var dtoToentity = new MedicoPorEspecialidad()
                {
                    Id = obj.Id,
                    IdEspecialidad = obj.IdEspecialidad,
                    IdMedico=obj.IdMedico
                   

                };
                genericRepository.Insert(dtoToentity);
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);

                 
            }
        }

        /// <summary>
        /// Actualiza un registro en la tabla MedicoPorEspecialidad
        /// </summary>
        /// <param name="obj"></param>
        public void Update(MedicoPorEspecialidadDto obj)
        {
            try
            {
                var dtoToentity = new MedicoPorEspecialidad()
                {
                    Id = obj.Id,
                    IdEspecialidad = obj.IdEspecialidad,
                    IdMedico = obj.IdMedico


                };
                genericRepository.Update(dtoToentity);
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);

                 
            }
        }

        /// <summary>
        /// Obtiene todos los registros de la tabla MedicoPorEspecialidad
        /// </summary>
        /// <returns></returns>
        public IEnumerable<MedicoPorEspecialidadDto> GetAll()
        {
            try
            {
                var entity = MapperHelper.GetMapper().
            Map<List<MedicoPorEspecialidadDto>>(genericRepository.GetAll());

                return entity;
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);
            }
            return null;
        }

        /// <summary>
        /// Obtiene un registro de la tabla MedicoPorEspecialidad
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public MedicoPorEspecialidadDto GetOne(int? guid)
        {
            try
            {
                var op = MapperHelper.GetMapper().Map<MedicoPorEspecialidad,MedicoPorEspecialidadDto>(genericRepository.GetOne(guid));

                return op;
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);

                 
            }
            return null;

        }

        /// <summary>
        /// Elimina un registro en la tabla MedicoPorEspecialidad
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
