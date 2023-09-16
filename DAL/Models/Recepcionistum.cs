using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Recepcionistum
{
    public int Id { get; set; }

    public int? Dni { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public virtual ICollection<Turno> Turnos { get; set; } = new List<Turno>();
}
