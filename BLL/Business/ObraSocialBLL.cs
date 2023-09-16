//using Domain;
using Services;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interfaces;
using BLL.MapperConfig;
using DAL.Factory;
using DAL.Models;
using BLL.Dto;
using Services.BLL.Exepciones;
//using DAL.Models;

namespace BLL.Business
{
    /// <summary>
    /// Clase de negocio, a traves del UnitOfWork tiene los metodos necesarios para poder comunciarse con la capa de Datos
    /// </summary>
    public class ObraSocialBLL : IGenericBusiness<ObraSocialDto>
    {
        private readonly static ObraSocialBLL _instance = new ObraSocialBLL();


        public static ObraSocialBLL Current
        {
            get
            {
                return _instance;
            }
        }


        IGenericRepository<ObraSocial> genericRepository = FactoryDAL._obraSocialRepository;

        /// <summary>
        /// Inserta un registro en la tabla ObraSocial
        /// </summary>
        /// <param name="obj"></param>
        public void Insert(ObraSocialDto obj)
        {
            try
            {
                var dtoToentity = new ObraSocial()
                {
                    Id = obj.Id,
                    Nombre = obj.Nombre,


                };
                genericRepository.Insert(dtoToentity);
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);

                 
            }
            
        }

        /// <summary>
        /// Acutaliza un registro en la tabla ObraSocial
        /// </summary>
        /// <param name="obj"></param>
        public void Update(ObraSocialDto obj)
        {
            try
            {
                var dtoToentity = new ObraSocial()
                {
                    Id = obj.Id,
                    Nombre = obj.Nombre,


                };
                genericRepository.Update(dtoToentity);
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);

                 
            }
            
        }

        /// <summary>
        /// Obtiene todos los registros de la tabla ObraSocial
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ObraSocialDto> GetAll()
        {
            try
            {
                var entity = MapperHelper.GetMapper().
            Map<List<ObraSocialDto>>(genericRepository.GetAll());

                return entity;
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);

                 
            }
            return null;

        }

        /// <summary>
        /// Obtiene un registro de la tabla ObraSocial
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public ObraSocialDto GetOne(int? guid)
        {
            try
            {
                var op = MapperHelper.GetMapper().Map<ObraSocialDto>(genericRepository.GetOne(guid));

                return op;
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);

                 
            }
            return null;

        }

        /// <summary>
        /// Elimina un registro en la tabla ObraSocial
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
