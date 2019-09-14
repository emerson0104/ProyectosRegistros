using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ESTUDIANTES.DAL.scripts;
using ESTUDIANTES.ENTIDADES;


namespace ESTUDIANTES.DAL
{
    class InscripcionesDb : DbContext
    {
        public DbSet<Inscripciones> Inscripciones { get; set; }

        public InscripcionesDb() : base("ConStr")
        {

        }
    }
}
