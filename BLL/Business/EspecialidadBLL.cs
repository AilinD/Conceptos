
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using BLL.Interfaces;
using Domain;
using BLL.MapperConfig;
using Services;
using DAL.Interfaces;
using DAL.Factory;
using DAL.Models;
using Services.BLL;
using System.Diagnostics.Tracing;
using System.Reflection.Metadata;
using Services.BLL.Exepciones;
//using DAL.Models;

namespace BLL.Business {
    /// <summary>
    /// Clase de negocio, a traves del UnitOfWork tiene los metodos necesarios para poder comunciarse con la capa de Datos
    /// </summary>
    public class EspecialidadBLL : IGenericBusiness<Domain.Especialidad>
    {

        private readonly static EspecialidadBLL _instance = new EspecialidadBLL();


        public static EspecialidadBLL Current
        {
            get
            {
                return _instance;
            }
        }

        IGenericRepository<DAL.Models.Especialidad> genericRepository = FactoryDAL._especialidadRepository;


        /// <summary>
        /// Inserta un registro en la tabla de Especialidad
        /// </summary>
        /// <param name="obj"></param>
        public void Insert(Domain.Especialidad obj)
        {
            try
            {
                var dtoToentity = new DAL.Models.Especialidad()
                {
                    Id = obj.Id,
                    Especialidad1 = obj.Nombre,

                };
                genericRepository.Insert(dtoToentity);
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);

                 
            }
           
        }

        /// <summary>
        /// Actualiza un registro de la tabla Especialidad
        /// </summary>
        /// <param name="obj"></param>
        public void Update(Domain.Especialidad obj)
        {
            try
            {
                var dtoToentity = new DAL.Models.Especialidad()
                {
                    Id = obj.Id,
                    Especialidad1 = obj.Nombre,

                };
                genericRepository.Update(dtoToentity);
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);

                 
            }
           
        }

        /// <summary>
        /// Obtiene todos los registros de la tabla Especialidad
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Domain.Especialidad> GetAll()
        {
            try
            {
                List<DAL.Models.Especialidad> listado = genericRepository.GetAll().ToList();

                var entity = MapperHelper.GetMapper().
            Map<List<DAL.Models.Especialidad>, List<Domain.Especialidad>>(genericRepository.GetAll().ToList());
                return entity;
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);

                 
            }
            return null;

        }

        /// <summary>
        /// Retorna un objeto de la tabla Especialidad
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public Domain.Especialidad GetOne(int? guid)
        {
            try
            {
                var op = MapperHelper.GetMapper().Map<Domain.Especialidad>(genericRepository.GetOne(guid));

                return op;
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);

                 
            }
            return null;

        }

        /// <summary>
        /// Elimina un registro de la tabla Especialidad
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