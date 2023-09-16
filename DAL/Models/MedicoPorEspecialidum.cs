using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class MedicoPorEspecialidum
{
    public int? Id { get; set; }

    public int MatriculaMedico { get; set; }

    public int IdEspecialidad { get; set; }

    public virtual Especialidad IdEspecialidadNavigation { get; set; } = null!;

    public virtual Medico MatriculaMedicoNavigation { get; set; } = null!;
}
