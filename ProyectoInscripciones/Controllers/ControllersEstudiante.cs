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
    public class ControllersEstudiante
    {
        public bool Guardar(Estudiante estudiantes)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Estudiante.Add(estudiantes);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return paso;

        }
        public bool Modificar(Estudiante estudiantes)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(estudiantes).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return paso;

        }
        public  Estudiante Buscar(int id)
        {
            Estudiante estudiantes = new Estudiante();
            Contexto contexto = new Contexto();

            try
            {
                estudiantes = contexto.Estudiante.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            return estudiantes;

        }

        public bool Eliminar(int id)
        {
            Estudiante estudiantes = new Estudiante();
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

        public List<Estudiante> GetList(Expression<Func<Estudiante, bool>> expression)
        {
            List<Estudiante> listaInscripciones = new List<Estudiante>();
            Contexto contexto = new Contexto();


            try
            {
                listaInscripciones = contexto.Estudiante.Where(expression).ToList();
            }
            catch (Exception)
            {

                throw;
            }

            return listaInscripciones;

        }

    }
}
