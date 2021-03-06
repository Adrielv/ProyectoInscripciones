﻿using Microsoft.EntityFrameworkCore;
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
            ControllersEstudiante controllersEstudiante = new ControllersEstudiante();

            try
            {
                var estudiante = controllersEstudiante.Buscar(inscripciones.EstudianteId);
                estudiante.Balance += inscripciones.Monto;

                controllersEstudiante.Modificar(estudiante);
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
            ControllersEstudiante controllersEstudiante = new ControllersEstudiante();
            ControllersInscripciones controllersInscripciones = new ControllersInscripciones();

            try
            {
                var estudiante = controllersEstudiante.Buscar(inscripciones.EstudianteId);
                var anterior = Buscar(inscripciones.InscripcionesId);

                estudiante.Balance -= anterior.Monto;
                contexto.Inscripcions.Add(inscripciones);

                foreach (var item in anterior.Detalles)
                {
                    if (!inscripciones.Detalles.Any(p => p.InscripcionDetalleId == item.InscripcionDetalleId))
                    {
                        contexto.Entry(item).State = EntityState.Deleted;
                    }
                }

                foreach (var item in inscripciones.Detalles)
                {
                    if (item.InscripcionDetalleId == 0)
                    {
                        contexto.Entry(item).State = EntityState.Added;
                    }
                    else
                    {
                        contexto.Entry(item).State = EntityState.Modified;
                    }
                }

                estudiante.Balance += inscripciones.Monto;
                controllersEstudiante.Modificar(estudiante);

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
            ControllerInscripcionDetalle controller = new ControllerInscripcionDetalle();

            try
            {
                inscripciones = contexto.Inscripcions.Find(id);
                if (inscripciones != null)
                {
                    inscripciones.Detalles = controller.GetInscripcions(A => true);
                }
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
                var eliminar = contexto.Inscripcions.Find(id);
                contexto.Estudiante.Find(eliminar.EstudianteId).Balance -= eliminar.Monto;

                
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

