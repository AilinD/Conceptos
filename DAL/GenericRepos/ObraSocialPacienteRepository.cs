using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.GenericRepos
{
    //public class ObraSocialPacienteRepository : IGenericRepository<ObraSocialPaciente>
    //{
    //    private readonly SysCexpertContext _context;
    //    public ObraSocialPacienteRepository(SysCexpertContext context)
    //    {
    //        _context = context;
    //    }


    //    /// <summary>
    //    /// Elimina un registro en la tabla de ObraSocialPaciente
    //    /// </summary>
    //    /// <param name="guid"></param>
    //    public void Delete(obra guid)
    //    {
    //        var r = _context.ObraSocialPacientes.FirstOrDefault(x => x.IdPaciente == guid.IdPaciente);
    //        if (r != null)
    //        {
    //            _context.ObraSocialPacientes.Remove(r);
    //            _context.SaveChanges();
    //        }
    //    }

    //    /// <summary>
    //    /// Obtiene todos los registros en la tabla de ObraSocialPaciente
    //    /// </summary>
    //    /// <param name="parameters"></param>
    //    /// <returns></returns>
    //    public IEnumerable<ObraSocialPaciente> GetAll(ObraSocialPaciente parameters = null)
    //    {
    //        return _context.ObraSocialPacientes.ToList();

    //    }

    //    /// <summary>
    //    /// Obtiene un registro en la tabla de ObraSocialPaciente
    //    /// </summary>
    //    /// <param name="guid"></param>
    //    /// <returns></returns>
    //    public ObraSocialPaciente GetOne(int? guid)
    //    {
    //        var r = _context.ObraSocialPacientes.FirstOrDefault(x => x.IdPaciente == guid);

    //        return r;

    //    }

    //    /// <summary>
    //    /// Inserta un registro en la tabla de ObraSocialPaciente
    //    /// </summary>
    //    /// <param name="obj"></param>
    //    public void Insert(ObraSocialPaciente obj)
    //    {
    //        _context.ObraSocialPacientes.Add(obj);
    //        _context.SaveChanges();

    //    }

    //    /// <summary>
    //    /// Actualiza un registro en la tabla de ObraSocialPaciente
    //    /// </summary>
    //    /// <param name="obj"></param>
    //    public void Update(ObraSocialPaciente obj)
    //    {
    //        var obrasocial = _context.ObraSocialPacientes.FirstOrDefault(x => x.IdPaciente == obj.IdPaciente);
    //        if (obrasocial != null)
    //        {
    //            obrasocial.Id = obj.Id;
    //            obrasocial.IdPaciente = obj.IdPaciente;
    //            _context.Update(obrasocial);
    //            _context.SaveChanges();

    //        }
    //    }
    //}
}
