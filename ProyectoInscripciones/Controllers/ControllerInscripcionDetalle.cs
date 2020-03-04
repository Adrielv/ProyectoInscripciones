using ProyectoInscripciones.Data;
using ProyectoInscripciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ProyectoInscripciones.Controllers
{
    public class ControllerInscripcionDetalle
    {
        public List<InscripcionDetalle> GetInscripcions(Expression<Func<InscripcionDetalle, bool>> expression)
        {
            Contexto contexto = new Contexto();
            List<InscripcionDetalle> lista = new List<InscripcionDetalle>();

            try
            {
                lista = contexto.InscripcionDetalles.Where(expression).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return lista;
        }
    }
}
