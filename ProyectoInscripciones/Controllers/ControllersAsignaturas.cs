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
    public class ControllersAsignaturas
    {
        public bool Guardar(Asignaturas asignaturas)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Asignaturas.Add(asignaturas);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return paso;

        }
        public bool Modificar(Asignaturas asignaturas)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(asignaturas).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return paso;

        }
        public Asignaturas Buscar(int id)
        {
            Asignaturas asignaturas = new Asignaturas();
            Contexto contexto = new Contexto();

            try
            {
                asignaturas = contexto.Asignaturas.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            return asignaturas;

        }

        public bool Eliminar(int id)
        {
            Asignaturas asignaturas = new Asignaturas();
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

        public List<Asignaturas> GetList(Expression<Func<Asignaturas, bool>> expression)
        {
            List<Asignaturas> lista = new List<Asignaturas>();
            Contexto contexto = new Contexto();


            try
            {
                lista = contexto.Asignaturas.Where(expression).ToList();
            }
            catch (Exception)
            {

                throw;
            }

            return lista;

        }
    }
    
}
