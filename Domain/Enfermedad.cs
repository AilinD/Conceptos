//using Domain;
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
    public class Enfermedad
    {
        [Key]
        public int ID { get; set; }
        public string Descripcion { get; set; }

        
    }
}
