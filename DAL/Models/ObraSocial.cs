using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class ObraSocial
{
    public int Id { get; set; }

    public string? ObraSocial1 { get; set; }

    public virtual ICollection<Paciente> Dnipacientes { get; set; } = new List<Paciente>();
}
