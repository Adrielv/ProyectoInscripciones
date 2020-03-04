using Microsoft.EntityFrameworkCore;
using ProyectoInscripciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoInscripciones.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Estudiante> Estudiante { get; set; }
        public DbSet<Asignaturas> Asignaturas { get; set; }
        public DbSet<Inscripcion> Inscripcions { get; set; }
        public DbSet<Pagos> Pagos { get; set; }
        public DbSet<InscripcionDetalle> InscripcionDetalles { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite(@"Data source = Database\InscripcionesData.db");
        }
    }
}
