using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ESTUDIANTES.DAL.scripts;
using ESTUDIANTES.ENTIDADES;


namespace ESTUDIANTES
{
    public partial class REstudiante : Form
    {
        public REstudiante()
        {
            InitializeComponent();
        }
        public void LimpiarTextBox()
        {
           
            NombrestextBox.Clear();
            ApellidostextBox.Clear();
            CedulamaskedTextBox.Clear();
            TelefonomaskedTextBox.Clear();
            celularmaskedTextBox.Clear();
            EmailtextBox.Clear();
           FechadateTimePicker.Text="";
            SexocomboBox.Text = "";
            BalancetextBox.Clear();
            MatriculamaskedTextBox.Clear();


        }


        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            LimpiarTextBox();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Contexto db = new Contexto();

            RegistroEstudiantes estudiantes = new RegistroEstudiantes();

            //Funcion LlenarClase
            estudiantes.EstudianteId = 5;
            estudiantes.Nombres = NombrestextBox.Text;
            estudiantes.Apellidos = ApellidostextBox.Text;
            estudiantes.Matricula = MatriculamaskedTextBox.Mask;
            estudiantes.Telefono = TelefonomaskedTextBox.Mask;
            estudiantes.Celular = celularmaskedTextBox.Mask;
            estudiantes.Cedula = CedulamaskedTextBox.Mask;
            estudiantes.FechaNacimiento = FechadateTimePicker.Value;
            estudiantes.Email = EmailtextBox.Text;
            estudiantes.Sexo = SexocomboBox.Text;
              BalancetextBox.Text=estudiantes.Balance.ToString();
            db.RegistroEstudiantes.Add(estudiantes);
            db.SaveChanges();
            LimpiarTextBox();

            
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int EstudiantesId = 0;
            Contexto db = new Contexto();

            int.TryParse(IDnumericUpDown.Text, out EstudiantesId);
            var estudiante = db.RegistroEstudiantes.Find(EstudiantesId);

            db.RegistroEstudiantes.Remove(estudiante);
            db.SaveChanges();
            LimpiarTextBox();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Contexto db = new Contexto();

            //ponerlo en una funcion
            int estudianteId = 0;
            int.TryParse(IDnumericUpDown.Text, out estudianteId);//convertir de string a entero

            RegistroEstudiantes estudiantes = new RegistroEstudiantes();

            estudiantes = db.RegistroEstudiantes.Find(estudianteId);
            if (estudiantes == null)
            {
                MessageBox.Show("Estudiantes No encontada");
            }
            else
            {
                //Llenar Campos
                NombrestextBox.Text = estudiantes.Nombres;
                ApellidostextBox.Text = estudiantes.Apellidos;
                MatriculamaskedTextBox.Text = estudiantes.Matricula;
                CedulamaskedTextBox.Text = estudiantes.Cedula;
                TelefonomaskedTextBox.Text = estudiantes.Telefono;
                celularmaskedTextBox.Text = estudiantes.Celular;
                EmailtextBox.Text = estudiantes.Email;
                FechadateTimePicker.Value = estudiantes.FechaNacimiento;
                SexocomboBox.Text = estudiantes.Sexo;
              

            }
        }

        private void REstudiante_Load(object sender, EventArgs e)
        {

        }
    }
}
