using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Paciente
{
    public int IdPaciente { get; set; }

    public int Dni { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public DateTime? FechaNacimiento { get; set; }

    public string? Domicilio { get; set; }

    public int? Contacto { get; set; }

    public string? Sexo { get; set; }

    public virtual ICollection<Diagnostico> Diagnosticos { get; set; } = new List<Diagnostico>();

    public virtual ICollection<EstudioPaciente> EstudioPacientes { get; set; } = new List<EstudioPaciente>();

    public virtual ICollection<Guardium> Guardia { get; set; } = new List<Guardium>();

    public virtual ICollection<HistorialPaciente> HistorialPacientes { get; set; } = new List<HistorialPaciente>();

    public virtual ICollection<Turno> Turnos { get; set; } = new List<Turno>();

    public virtual ICollection<ObraSocial> IdObraSocials { get; set; } = new List<ObraSocial>();

    public virtual ICollection<Sintoma> IdSintomas { get; set; } = new List<Sintoma>();
}
