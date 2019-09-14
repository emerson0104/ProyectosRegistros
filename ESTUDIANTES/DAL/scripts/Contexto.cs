using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ESTUDIANTES.ENTIDADES;


namespace ESTUDIANTES.DAL.scripts
{
   public class Contexto : DbContext
    {
        public DbSet<RegistroEstudiantes> RegistroEstudiantes { get; set; }
        public DbSet<Inscripciones> inscripciones { get; set; }
        public Contexto() : base("ConStr")
        {

        }
        
        

        }
    }

