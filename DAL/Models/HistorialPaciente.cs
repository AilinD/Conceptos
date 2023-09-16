using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class HistorialPaciente
{
    public int Id { get; set; }

    public DateTime? Fecha { get; set; }

    public int? Dnipaciente { get; set; }

    public string? Comentario { get; set; }

    public int? MatriculaMedico { get; set; }

    public virtual Paciente? DnipacienteNavigation { get; set; }

    public virtual Medico? MatriculaMedicoNavigation { get; set; }
}
