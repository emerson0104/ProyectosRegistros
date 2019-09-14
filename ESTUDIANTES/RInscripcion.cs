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
using ESTUDIANTES.DAL;
using ESTUDIANTES.ENTIDADES;
using ESTUDIANTES.DAL.scripts;


namespace ESTUDIANTES.UI.Registros
{
    public partial class RInscripcion : Form
    {
        public RInscripcion()
        {
            InitializeComponent();
        }
        public void LimpiarTextBox()
        {

            IdEstudiantetextBox.Clear();
            MontotextBox.Clear();
            BalancetextBox.Clear();
        }
        private void RInscripcion_Load(object sender, EventArgs e)
        {

        }

        private void NombrestextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void MatriculamaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Nombres_Click(object sender, EventArgs e)
        {

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            InscripcionesDb db = new InscripcionesDb();
            Inscripciones inscripciones = new Inscripciones();

            double Monto = 0, Balance = 0;
            int Id = 0;
            double.TryParse(MontotextBox.Text, out Monto);
            double.TryParse(BalancetextBox.Text, out Balance);
            int.TryParse(IDnumericUpDown.Text, out Id);
            inscripciones.EstudianteId = Id;
            inscripciones.Fecha = FechadateTimePicker.Value;
            inscripciones.Monto = Monto;
            inscripciones.Balance = Balance;

            db.Inscripciones.Add(inscripciones);
            db.SaveChanges();
            LimpiarTextBox();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            LimpiarTextBox();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int InscripcionId = 0;
            InscripcionesDb db = new InscripcionesDb();

            int.TryParse(IdEstudiantetextBox.Text, out InscripcionId);

            var inscripcion = db.Inscripciones.Find(InscripcionId);

            db.Inscripciones.Remove(inscripcion);
            db.SaveChanges();
            LimpiarTextBox();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            InscripcionesDb db = new InscripcionesDb();

            //ponerlo en una funcion
            int InscripcionId = 0;
            int.TryParse(IdEstudiantetextBox.Text, out InscripcionId);//convertir de string a entero

            Inscripciones inscripciones = new Inscripciones();

            inscripciones = db.Inscripciones.Find(InscripcionId);
            if (inscripciones == null)
            {
                MessageBox.Show("Estudiantes No encontada");
            }
            else
            {
                //Llenar Campos
                FechadateTimePicker.Text = inscripciones.Fecha.ToString();
                IdEstudiantetextBox.Text = inscripciones.EstudianteId.ToString();
                MontotextBox.Text = inscripciones.Monto.ToString();
                BalancetextBox.Text = inscripciones.Balance.ToString();
            }
        }
    }
}
