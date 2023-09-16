///////////////////////////////////////////////////////////
//  MedicoBLL.cs
//  Implementation of the Class MedicoBLL
//  Generated by Enterprise Architect
//  Created on:      18-ago.-2022 20:48:15
//  Original author: Ailin
///////////////////////////////////////////////////////////


//using Domain;
using BLL.Interfaces;
using Services;
using BLL.Dto;
using DAL.Interfaces;
using BLL.MapperConfig;
using DAL.Factory;
using DAL.Models;
using Services.BLL.Exepciones;
//using DAL.Models;

namespace BLL.Business {

    /// <summary>
    /// Clase de negocio, a traves del UnitOfWork tiene los metodos necesarios para poder comunciarse con la capa de Datos
    /// </summary>
    public class MedicoBLL : IGenericBusiness<MedicoDto>
    {

        private readonly static MedicoBLL _instance = new MedicoBLL();

        #region old
        //      /// 
        //      /// <param name="medico"></param>
        //      public void AltaMedico(Medico medico){

        //}

        ///// 
        ///// <param name="int"></param>
        //public void BajaMedico(int id){

        //}

        ///// 
        ///// <param name="matricula"></param>
        //public List<DateTime> GetDisponibilidad(int matricula){

        //	return null;
        //}

        //public List<Medico> ListarMedico<Medico>(){

        //	return null;
        //}

        ///// 
        ///// <param name="medico"></param>
        //public void ModificarMedico(Medico medico){

        //}

        //public Medico SeleccionarMedico(){

        //	return null;
        //}
        #endregion

        public static MedicoBLL Current
        {
            get
            {
                return _instance;
            }
        }


        IGenericRepository<Medico> genericRepository = FactoryDAL._medicoRepository;

        /// <summary>
        /// Inserta un registro en la tabla Medico
        /// </summary>
        /// <param name="obj"></param>
        public void Insert(MedicoDto obj)
        {
            try
            {
                var dtoToentity = new Medico()
                {
                    Matricula = obj.Matricula,
                    Nombre = obj.Nombre,
                    Apellido = obj.Apellido,
                    Direccion = obj.Direccion,
                    Contacto = obj.Contacto

                };
                genericRepository.Insert(dtoToentity);
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);

                 
            }
           
        }

        /// <summary>
        /// Actualiza un registro en la tabla Medico
        /// </summary>
        /// <param name="obj"></param>
        public void Update(MedicoDto obj)
        {
            try
            {
                var dtoToentity = new Medico()
                {
                    IdMedico = obj.IdMedico,
                    Matricula = obj.Matricula,
                    Nombre = obj.Nombre,
                    Apellido = obj.Apellido,
                    Direccion = obj.Direccion,
                    Contacto = obj.Contacto

                };
                genericRepository.Update(dtoToentity);
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);

                 
            }
            
        }

        /// <summary>
        /// Obtiene todos los registros en la tabla Medico
        /// </summary>
        /// <returns></returns>
        public IEnumerable<MedicoDto> GetAll()
        {
            try
            {
                var entity = MapperHelper.GetMapper().
           Map<List<MedicoDto>>(genericRepository.GetAll());

                return entity;
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);

                 
            }
            return null;

        }

        /// <summary>
        /// Obtiene un registro en la tabla Medico
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public MedicoDto GetOne(int? guid)
        {
            try
            {
                var op = MapperHelper.GetMapper().Map<MedicoDto>(genericRepository.GetOne(guid));

                return op;
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);

                 
            }
            return null;

        }

        /// <summary>
        /// Elimina un registro en la tabla Medico
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

}//end namespace BLL