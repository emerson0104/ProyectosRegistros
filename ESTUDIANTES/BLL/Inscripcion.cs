using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ESTUDIANTES.DAL;
using ESTUDIANTES.ENTIDADES;

namespace ESTUDIANTES.BLL
{
   public class Inscripcion
    {
        public static bool Guardar(Inscripciones inscripcion)
        {
            bool paso = false;

            try
            {
                InscripcionesDb contex = new InscripcionesDb();

                contex.Inscripciones.Add(inscripcion);
                contex.SaveChanges();

                paso = true;
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public static bool Modificar(Inscripciones inscripcion)
        {
            bool paso = false;

            try
            {
                InscripcionesDb contex = new InscripcionesDb();

                contex.Entry(inscripcion).State = EntityState.Modified;
                contex.SaveChanges();

                paso = true;
            }
            catch (Exception)
            {
                throw;
            }

            return paso;

        }

        public static bool Eliminar(int inscripcionId)
        {
            bool paso = false;

            try
            {
                InscripcionesDb contex = new InscripcionesDb();

                var inscripcion = contex.Inscripciones.Find(inscripcionId);

                contex.Inscripciones.Remove(inscripcion);
                contex.SaveChanges();

                paso = true;
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public static Inscripciones Buscar(int inscripcionId)
        {
            Inscripciones inscripcion = new Inscripciones();

            try
            {
                InscripcionesDb contex = new InscripcionesDb();
                inscripcion = contex.Inscripciones.Find(inscripcionId);
            }
            catch (Exception)
            {
                throw;
            }

            return inscripcion;
        }

        public static List<Inscripciones> GetList(Expression<Func<Inscripciones, bool>> criterioBusqueda)
        {
            List<Inscripciones> inscripciones = new List<Inscripciones>();
            try
            {
                InscripcionesDb contex = new InscripcionesDb();
                inscripciones = contex.Inscripciones.Where(criterioBusqueda).ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return inscripciones;
        }
        

    }
}

