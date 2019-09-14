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
using ESTUDIANTES.BLL;
using System.Linq.Expressions;

namespace ESTUDIANTES.UI.Consultas
{
    public partial class ConsultaInscripcion : Form
    {
        public ConsultaInscripcion()
        {
            InitializeComponent();
        }

        private void ConsultaButton_Click(object sender, EventArgs e)
        {
            if (FiltrarComboBox.SelectedIndex == 0)
            {
                //ponerlo en una funcion
                int id = 0;
                int.TryParse(CriterioTextBox.Text, out id);

                ConsultaDataGridView.DataSource = Inscripcion.GetList(p => p.InscripcionId == id);
            }
            else if (FiltrarComboBox.SelectedIndex == 2)
            {
                //ponerlo en una funcion
                int id = 0;
                int.TryParse(CriterioTextBox.Text, out id);

                ConsultaDataGridView.DataSource = Inscripcion.GetList(p => p.EstudianteId == id);
            }
            else if (FiltrarComboBox.SelectedIndex == 3)
            {
                //ponerlo en una funcion
                double Monto = 0;
                double.TryParse(CriterioTextBox.Text, out Monto);

               ConsultaDataGridView.DataSource = Inscripcion.GetList(p => p.Monto == Monto);
            }
            else if (FiltrarComboBox.SelectedIndex == 4)
            {
                //ponerlo en una funcion
                double Balance = 0;
                double.TryParse(CriterioTextBox.Text, out Balance);

                ConsultaDataGridView.DataSource = Inscripcion.GetList(p => p.Balance == Balance);
            }
        }

    }
    }
