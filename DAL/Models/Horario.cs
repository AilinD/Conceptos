using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Horario
{
    public int Id { get; set; }

    public string? Horario1 { get; set; }

    public virtual ICollection<HorarioProfesional> HorarioProfesionals { get; set; } = new List<HorarioProfesional>();
}
