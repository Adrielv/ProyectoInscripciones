using Microsoft.EntityFrameworkCore;
using ProyectoInscripciones.Data;
using ProyectoInscripciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ProyectoInscripciones.Controllers
{
    public class ControllersInscripciones
    {
        public bool Guardar(Inscripcion inscripciones)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Inscripcions.Add(inscripciones);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return paso;

        }
        public bool Modificar(Inscripcion inscripciones)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(inscripciones).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return paso;

        }
        public Inscripcion Buscar(int id)
        {
            Inscripcion inscripciones = new Inscripcion();
            Contexto contexto = new Contexto();

            try
            {
                inscripciones = contexto.Inscripcions.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            return inscripciones;

        }

        public bool Eliminar(int id)
        {
            Inscripcion inscripciones = new Inscripcion();
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                var eliminar = contexto.Estudiante.Find(id);
                contexto.Entry(eliminar).State = EntityState.Deleted;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }

            return paso;

        }

        public List<Inscripcion> GetList(Expression<Func<Inscripcion, bool>> expression)
        {
            List<Inscripcion> lista = new List<Inscripcion>();
            Contexto contexto = new Contexto();


            try
            {
                lista = contexto.Inscripcions.Where(expression).ToList();
            }
            catch (Exception)
            {

                throw;
            }

            return lista;

        }
    }
}

