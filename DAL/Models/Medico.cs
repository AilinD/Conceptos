using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Medico
{
    public string? Id { get; set; }

    public int Matricula { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public int? Dni { get; set; }

    public string? Direccion { get; set; }

    public virtual ICollection<Diagnostico> Diagnosticos { get; set; } = new List<Diagnostico>();

    public virtual ICollection<EstudioPaciente> EstudioPacientes { get; set; } = new List<EstudioPaciente>();

    public virtual ICollection<Guardium> Guardia { get; set; } = new List<Guardium>();

    public virtual ICollection<HistorialPaciente> HistorialPacientes { get; set; } = new List<HistorialPaciente>();

    public virtual ICollection<HorarioProfesional> HorarioProfesionals { get; set; } = new List<HorarioProfesional>();

    public virtual ICollection<MedicoPorEspecialidum> MedicoPorEspecialida { get; set; } = new List<MedicoPorEspecialidum>();

    public virtual ICollection<Turno> Turnos { get; set; } = new List<Turno>();
}
