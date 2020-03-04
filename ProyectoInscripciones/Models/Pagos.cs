using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoInscripciones.Models
{
    public class Pagos
    {
        [Key]

        public int PagosId { get; set; }

        public DateTime Fecha { get; set; }

        public int EstudianteId { get; set; }

        [Required(ErrorMessage = "No puede estar vacio")]
        [Range(minimum: 1, maximum: 10000, ErrorMessage = "No puede pasar el limite")]
        public decimal Monto { get; set; }

        public Pagos()
        {
            PagosId = 0;
            Fecha = DateTime.Now;
            EstudianteId = 0;
            Monto = 0;
        }
    }
}
