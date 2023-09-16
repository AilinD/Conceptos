using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.GenericRepos
{
    //public class SintomaPacienteRepository : IGenericRepository<SintomaPaciente>
    //{
    //    private readonly SysCexpertContext _context;
    //    public SintomaPacienteRepository(SysCexpertContext context)
    //    {
    //        _context = context;
    //    }

    //    /// <summary>
    //    /// Elimina un registro en la tabla de SintomaPaciente
    //    /// </summary>
    //    /// <param name="guid"></param>
    //    public void Delete(SintomaPaciente guid)
    //    {
    //        var r = _context.SintomaPacientes.FirstOrDefault(x => x.IdPaciente == guid.IdPaciente);
    //        if (r != null)
    //        {
    //            _context.SintomaPacientes.Remove(r);
    //            _context.SaveChanges();
    //        }
    //    }

    //    /// <summary>
    //    /// Obtiene todos los registros de la tabla de SintomaPaciente
    //    /// </summary>
    //    /// <param name="parameters"></param>
    //    /// <returns></returns>
    //    public IEnumerable<SintomaPaciente> GetAll(SintomaPaciente parameters = null)
    //    {
    //        return _context.SintomaPacientes.ToList();
    //    }

    //    /// <summary>
    //    /// Obtiene un registro en la tabla de SintomaPaciente
    //    /// </summary>
    //    /// <param name="guid"></param>
    //    /// <returns></returns>
    //    public SintomaPaciente GetOne(int? guid)
    //    {
    //        var r = _context.SintomaPacientes.FirstOrDefault(x => x.IdPaciente == guid);

    //        return r;
    //    }

    //    /// <summary>
    //    /// Inserta un registro en la tabla de SintomaPaciente
    //    /// </summary>
    //    /// <param name="obj"></param>
    //    public void Insert(SintomaPaciente obj)
    //    {
    //        _context.SintomaPacientes.Add(obj);
    //        _context.SaveChanges();
    //    }

    //    /// <summary>
    //    /// Actualiza un registro en la tabla de SintomaPaciente
    //    /// </summary>
    //    /// <param name="obj"></param>
    //    public void Update(SintomaPaciente obj)
    //    {
    //        var sintomapaciente = _context.SintomaPacientes.FirstOrDefault(x => x.IdPaciente == obj.IdPaciente);
    //        if (sintomapaciente != null)
    //        {
    //            sintomapaciente.IdSintoma = obj.IdSintoma;
    //            sintomapaciente.IdPaciente = obj.IdPaciente;
    //            sintomapaciente.IdMedico = obj.IdMedico;
    //            sintomapaciente.Fecha = obj.Fecha;
    //            _context.Update(sintomapaciente);
    //            _context.SaveChanges();

    //        }
    //    }
    //}
}
