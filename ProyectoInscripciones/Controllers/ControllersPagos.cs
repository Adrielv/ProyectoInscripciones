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
    public class ControllersPagos
    {
        public bool Guardar(Pagos pagos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Estudiante.Find(pagos.EstudianteId).Balance -= pagos.Monto;

                contexto.Pagos.Add(pagos);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return paso;

        }
        public bool Modificar(Pagos pagos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(pagos).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return paso;

        }
        public Pagos Buscar(int id)
        {
            Pagos pagoses = new Pagos();
            Contexto contexto = new Contexto();

            try
            {
                pagoses = contexto.Pagos.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            return pagoses;

        }

        public bool Eliminar(int id)
        {
            Pagos pagos = new Pagos();
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

        public List<Pagos> GetList(Expression<Func<Pagos, bool>> expression)
        {
            List<Pagos> lista = new List<Pagos>();
            Contexto contexto = new Contexto();


            try
            {
                lista = contexto.Pagos.Where(expression).ToList();
            }
            catch (Exception)
            {

                throw;
            }

            return lista;

        }
    }
}

