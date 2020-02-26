using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoInscripciones.Models
{
    public class Asignaturas
    {
        [Key]

        public int AsignaturaId { get; set; }
        [Required(ErrorMessage = "No puede estar vacio")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "No puede estar vacio")]
        [Range(minimum: 1, maximum: 10000, ErrorMessage = "No puede pasar el limite")]
        public decimal Codigo { get; set; }
        [Required(ErrorMessage = "No puede estar vacio")]
        [Range(minimum: 1, maximum: 10000, ErrorMessage = "No puede pasar el limite")]
        public decimal PreRequisito { get; set; }
        [Required(ErrorMessage = "No puede estar vacio")]
        [Range(minimum: 1, maximum: 10000, ErrorMessage = "No puede pasar el limite")]
        public decimal Creditos { get; set; }

        public Asignaturas()
        {
            AsignaturaId = 0;
            Descripcion = string.Empty;
            Codigo = 0;
            PreRequisito = 0;
            Creditos = 0;
        }
    }
}
