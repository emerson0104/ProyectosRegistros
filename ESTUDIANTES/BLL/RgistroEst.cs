using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ESTUDIANTES.ENTIDADES;
using ESTUDIANTES.DAL.scripts;
using System.Data.Entity;

namespace ESTUDIANTES.BLL
{
    public class RgistroEst
    {
        public static bool ActualizarMonto(int Id, double nuevoMonto)
        {
            RegistroEstudiantes estudiantes;

            bool estado = false;
            try
            {
                Contexto context = new Contexto() ;
                estudiantes = context.RegistroEstudiantes.Find(Id);
                estudiantes.Balance += nuevoMonto;
                context.Entry(estudiantes).State = EntityState.Modified;
                context.SaveChanges();
                estado = true;
            }
            catch (Exception)
            {
                estado = false;
            }
            return estado;
        }

        public static bool Guardar(RegistroEstudiantes estudiantes)
        {
            bool estado = false;
            try
            {
                Contexto context = new Contexto();
                context.RegistroEstudiantes.Add(estudiantes);
                context.SaveChanges();
                estado = true;

            }
            catch (Exception)
            {

                throw;
            }
            return estado;
        }

        public static RegistroEstudiantes Buscar(int Id)
        {
           RegistroEstudiantes registro= new RegistroEstudiantes();
            Contexto context = new Contexto();
            try
            {
                
                registro = context.RegistroEstudiantes.Find(Id);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                context.Dispose();
            }

            return registro;

        }
        public static bool Editar(RegistroEstudiantes estudiantes)
        {
            bool estado = false;

            try
            {
                Contexto context = new Contexto();
                context.Entry(estudiantes).State = EntityState.Modified;
                context.SaveChanges();
                estado = true;

            }
            catch (Exception)
            {
                throw;
            }

            return estado;

        }

        public static bool eliminar(int Id)
        {
            RegistroEstudiantes estudiantes = null;
            bool estado = false;
            try
            {
                Contexto context = new Contexto();
                estudiantes = context.RegistroEstudiantes.Find(Id);
                context.RegistroEstudiantes.Remove(estudiantes);
                context.SaveChanges();

                estado = true;

            }
            catch (Exception)
            {
                throw;

            }
            return estado;
        }
    }
}
