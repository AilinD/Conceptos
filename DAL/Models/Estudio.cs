using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Estudio
{
    public int Id { get; set; }

    public string? Estudio1 { get; set; }

    public virtual ICollection<EstudioPaciente> EstudioPacientes { get; set; } = new List<EstudioPaciente>();
}
