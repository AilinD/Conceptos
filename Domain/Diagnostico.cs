using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    /// <summary>
    /// Clase que sirve para insertar en la base del negocio
    /// </summary>
    public class Diagnostico
    {
        [Key]
        public int Id { get; set; }
        public DateTime? Fecha { get; set; }
        public int? IdMedico { get; set; }
        public string? diagnostico { get; set; }
        public int? IdPaciente { get; set; }
    }
}
