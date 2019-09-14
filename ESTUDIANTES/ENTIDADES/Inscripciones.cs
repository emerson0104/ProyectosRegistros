using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ESTUDIANTES.ENTIDADES
{
    public class Inscripciones
    {

        [Key]
        public int InscripcionId { get; set; }
        public DateTime Fecha { get; set; }
        public int EstudianteId { get; set; }
        public string Comentarios { get;set; }
        public double Monto { get; set; }
        public double Deposito{ get; set; }
        public double Balance { get; set; }

        public Inscripciones()
        {
            this.InscripcionId = 0;
            this.Fecha = DateTime.Now;
            this.Comentarios = string.Empty;
            this.Deposito = 0;
            this.EstudianteId = 0;
            this.Monto = 0;
            this.Balance = 0;
        }

        public Inscripciones(int InscripcionId, DateTime Fecha, int EstudianteId, double Monto, double Balance,string Comentarios,double Deposito)
        {
            this.InscripcionId = InscripcionId;
            this.Deposito = Deposito;
            this.Comentarios = Comentarios;
            this.Fecha = Fecha;
            this.EstudianteId = EstudianteId;
            this.Monto = Monto;
            this.Balance = Balance;
        }
    }
}

