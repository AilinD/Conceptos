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
    public class Sintoma
    {
        [Key]
        public int IdSintoma { get; set; }
        public string Nombre { get; set; }
    }
}
