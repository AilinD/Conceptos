using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Diagnostico
{
    public string Id { get; set; } = null!;

    public DateTime? Fecha { get; set; }

    public int? MatriculaMedico { get; set; }

    public string? Diagnostico1 { get; set; }

    public int? Dnipaciente { get; set; }

    public virtual Paciente? DnipacienteNavigation { get; set; }

    public virtual Medico? MatriculaMedicoNavigation { get; set; }
}
