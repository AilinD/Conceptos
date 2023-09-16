using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class EstudioPacienteExtendido
    {
        public string? Estudio { get; set; }
        public string? Comentarios { get; set; }
        public DateTime? Fecha { get; set; }
       
        public string FullnameMedico { get; set; }
        public string FullnamePaciente { get; set; }

    }
}
