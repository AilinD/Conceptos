using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Sintoma
{
    public int IdSintoma { get; set; }

    public string? Sintoma1 { get; set; }

    public virtual ICollection<Paciente> Dnipacientes { get; set; } = new List<Paciente>();
}
