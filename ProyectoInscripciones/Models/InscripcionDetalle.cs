using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoInscripciones.Models
{
    public class InscripcionDetalle
    {
        [Key]
        public int InscripcionDetalleId { get; set; }
        public int InscripcionesId { get; set; }
        public int AsignaturaId { get; set; }
        public string Descripcion { get; set; }
        public int Creditos { get; set; }
        public int Subtotal { get; set; }

        public InscripcionDetalle()
        {
            InscripcionDetalleId = 0;
            InscripcionesId = 0;
            AsignaturaId = 0;
            Descripcion = string.Empty;
            Subtotal = 0;
            Creditos = 0;
        }
    }
}
