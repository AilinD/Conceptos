using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Especialidad
{
    public int Id { get; set; }

    public string? Especialidad1 { get; set; }

    public virtual ICollection<MedicoPorEspecialidum> MedicoPorEspecialida { get; set; } = new List<MedicoPorEspecialidum>();
}
