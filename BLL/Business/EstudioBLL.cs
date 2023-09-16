
using Domain;
using DAL.Interfaces;
using BLL.Interfaces;
using Services;
using BLL.MapperConfig;
using DAL.Factory;
using DAL.Models;
using Services.BLL.Exepciones;
//using DAL.Models;

namespace BLL.Business {
    /// <summary>
    /// Clase de negocio, a traves del UnitOfWork tiene los metodos necesarios para poder comunciarse con la capa de Datos
    /// </summary>
    public class EstudioBLL : IGenericBusiness<Domain.Estudio>
    {



        private readonly static EstudioBLL _instance = new EstudioBLL();


        public static EstudioBLL Current
        {
            get
            {
                return _instance;
            }
        }

        IGenericRepository<DAL.Models.Estudio> genericRepository = FactoryDAL._estudioRepository;

        /// <summary>
        /// Inserta un registro en la tabla Estudio
        /// </summary>
        /// <param name="obj"></param>
        public void Insert(Domain.Estudio obj)
        {
            try
            {
                var dtoToentity = new DAL.Models.Estudio()
                {
                    Id = obj.Id,
                    Estudio1 = obj.Nombre

                };
                genericRepository.Insert(dtoToentity);
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);

                 
            }
           
        }

        /// <summary>
        /// Actualiza un registro de la tabla Estudio
        /// </summary>
        /// <param name="obj"></param>
        public void Update(Domain.Estudio obj)
        {
            try
            {
                var dtoToentity = new DAL.Models.Estudio()
                {
                    Id = obj.Id,
                    Estudio1 = obj.Nombre

                };
                genericRepository.Update(dtoToentity);
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);

            }
           
        }

        /// <summary>
        /// Obtiene todos los registros de la tabla Estudio
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Domain.Estudio> GetAll()
        {
            try
            {
                var entity = MapperHelper.GetMapper().
          Map<List<Domain.Estudio>>(genericRepository.GetAll());

                return entity;
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);               
            }
            return null;

        }

        /// <summary>
        /// Retorna un registro de la tabla Estudio
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public Domain.Estudio GetOne(int? guid)
        {
            try
            {
                var op = MapperHelper.GetMapper().Map<Domain.Estudio>(genericRepository.GetOne(guid));

                return op;
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);
            }
            return null;

        }

        /// <summary>
        /// Elimina un registro de la tabla Estudio
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