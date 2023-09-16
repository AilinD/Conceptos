using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Turno
{
    public int Id { get; set; }

    public int DniPaciente { get; set; }

    public string? Fecha { get; set; }

    public int? MatriculaMedico { get; set; }

    public int? IdRecepcionista { get; set; }

    public virtual Paciente DniPacienteNavigation { get; set; } = null!;

    public virtual Recepcionistum? IdRecepcionistaNavigation { get; set; }

    public virtual Medico? MatriculaMedicoNavigation { get; set; }
}
