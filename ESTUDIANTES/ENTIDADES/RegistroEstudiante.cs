using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ESTUDIANTES.ENTIDADES
{
    public class RegistroEstudiantes
    {
        [Key]

        public int EstudianteId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Matricula { get; set; }
        public string Direccion { get; set; }
        public double Balance { get; set; }
        public string Cedula { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string FechaNacimiento { get; set; }
        public string Sexo { get; set; }
        public RegistroEstudiantes()
    {
            this.EstudianteId = 0;
            this.Nombres = String.Empty;
            this.Apellidos = String.Empty;
            this.Matricula = String.Empty;
            this.Direccion = String.Empty;
            this.Balance = 0;
            this.Cedula = string.Empty;
            this.Celular = string.Empty;
            this.Email = string.Empty;
            this.Telefono = string.Empty;
            this.FechaNacimiento = DateTime.Today.ToString();
            this.Sexo = string.Empty;



        }public RegistroEstudiantes(int EstudianteId, string Nombres, string Apellidos,  string Matricula,  string Direccion, double Balance,string Cedula,string Celular,string Email,string Telefono,string FechaNacimiento,string Sexo)
    {
            this.EstudianteId = EstudianteId;
            this.Nombres = Nombres;
            this.Apellidos = Apellidos;
            this.Matricula = Matricula;
            this.Cedula = Cedula;
            this.Celular = Celular;
            this.Direccion = Direccion;
            this.Balance = Balance;
            this.Email = Email;
            this.Sexo = Sexo;
            this.FechaNacimiento = FechaNacimiento;
            this.Telefono = Telefono;



    }
    }
    

    
}