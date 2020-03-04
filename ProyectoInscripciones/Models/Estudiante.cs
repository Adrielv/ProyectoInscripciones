using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoInscripciones.Models
{
    public class Estudiante
    {
        [Key]

        public int EstudianteId { get; set; }

        
      
        [Required(ErrorMessage = "No puede estar vacio")]
        [Range(minimum: 1, maximum: 10000, ErrorMessage = "No puede pasar el limite")]
        public decimal Matricula { get; set; }
        [Required(ErrorMessage = "No puede estar vacio")]
        public string Nombre { get; set; }
       

        public decimal Balance { get; set; }

        public Estudiante()
        {
            EstudianteId = 0;
            Matricula = 0;
            Nombre = string.Empty;
            Balance = 0;
        }
    }
}
