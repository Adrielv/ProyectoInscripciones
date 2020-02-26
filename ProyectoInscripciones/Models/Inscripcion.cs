using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoInscripciones.Models
{
    public class Inscripcion
    {
        [Key]

        public int InscripcionesId { get; set; }
        public int EstudianteId { get; set; }

        public DateTime Fecha { get; set; }
        [Required(ErrorMessage = "No puede estar vacio")]
        [Range(minimum: 1, maximum: 10000, ErrorMessage = "No puede pasar el limite")]
        public decimal Monto { get; set; }
        [Required(ErrorMessage = "No puede estar vacio")]
        [Range(minimum: 1, maximum: 10000, ErrorMessage = "No puede pasar el limite")]
        public decimal Balance { get; set; }

        public Inscripcion()
        {
            InscripcionesId = 0;
            EstudianteId = 0;
            Fecha = DateTime.Now;
            Monto = 0;
            Balance = 0;
        }

    }
}
