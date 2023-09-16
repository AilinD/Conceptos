using BLL.Interfaces;
using BLL.MapperConfig;
using DAL.Factory;
using DAL.Interfaces;
using DAL.Models;
using Services.BLL.Exepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Business
{
    public class DiagnosticoBLL : IGenericBusiness<Domain.Diagnostico>
    {

        private readonly static DiagnosticoBLL _instance = new DiagnosticoBLL();


        public static DiagnosticoBLL Current
        {
            get
            {
                return _instance;
            }
        }

        IGenericRepository<DAL.Models.Diagnostico> genericRepository = FactoryDAL._diagnosticoRepository;


        /// <summary>
        /// Borra un registro de la base Diagnostico
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

        /// <summary>
        /// Obtiene todos los registros de la tabla Diagnostico
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Domain.Diagnostico> GetAll()
        {
            try
            {
                List<DAL.Models.Diagnostico> listado = genericRepository.GetAll().ToList();

                var entity = MapperHelper.GetMapper().
            Map<List<Diagnostico>, List<Domain.Diagnostico>>(genericRepository.GetAll().ToList());
                return entity;
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);


            }
            return null;
        }

        /// <summary>
        /// Obtiene un solo registro de la base Diagnostico
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public Domain.Diagnostico GetOne(int? guid)
        {
            try
            {
                var op = MapperHelper.GetMapper().Map<Domain.Diagnostico>(genericRepository.GetOne(guid));

                return op;
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);


            }
            return null;
        }

        /// <summary>
        /// Inserta un registto en la base Diagnostico
        /// </summary>
        /// <param name="obj"></param>
        public void Insert(Domain.Diagnostico obj)
        {
            try
            {
                var dtoToentity = new DAL.Models.Diagnostico()
                {
                    Id = obj.Id.ToString(),
                    Fecha = obj.Fecha,
                    MatriculaMedico = obj.IdMedico,
                    Diagnostico1 = obj.diagnostico,
                    Dnipaciente = obj.IdPaciente

                };
                genericRepository.Insert(dtoToentity);
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);


            }
        }

        /// <summary>
        /// Actuializa un registro de la tabla Diagnostico
        /// </summary>
        /// <param name="obj"></param>
        public void Update(Domain.Diagnostico obj)
        {
            try
            {
                var dtoToentity = new DAL.Models.Diagnostico()
                {
                    Id = obj.Id.ToString(),
                    Fecha = obj.Fecha,
                    MatriculaMedico = obj.IdMedico,
                    Diagnostico1 = obj.diagnostico,
                    Dnipaciente = obj.IdPaciente

                };
                genericRepository.Update(dtoToentity);
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);


            }
        }
    }
}
