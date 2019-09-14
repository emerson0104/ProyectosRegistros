using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ESTUDIANTES.DAL.scripts;
using ESTUDIANTES.ENTIDADES;
using ESTUDIANTES.BLL;
using System.Linq.Expressions;

namespace ESTUDIANTES
{
    public partial class ConsultaFormulario1 : Form
    {
        public ConsultaFormulario1()
        {
            InitializeComponent();
        }

        private void ConsultaButton_Click(object sender, EventArgs e)
        {
            var listado = new List<RegistroEstudiantes>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltrarComboBox.SelectedIndex)
                {
                    case 0://Todo
                        listado = RgistroEstBll.GetList(R => true);
                        break;

                    case 1://ID
                        int id = Convert.ToInt32(CriterioTextBox.Text);
                        listado = RgistroEstBll.GetList(R => R.EstudianteId == id);
                        break;

                    case 2://Nombre
                        listado = RgistroEstBll.GetList(R => R.Nombres.Contains(CriterioTextBox.Text));
                        break;

                    case 3://Cedula
                        listado = RgistroEstBll.GetList(R=> R.Cedula.Contains(CriterioTextBox.Text));
                        break;

                    case 4://Direccion
                        listado = RgistroEstBll.GetList(p => p.Direccion.Contains(CriterioTextBox.Text));
                        break;
                }

                listado = listado.Where(c => c.FechaNacimiento.Date >= DesdeDateTimePicker.Value.Date && c.FechaNacimiento.Date <= HastaDateTimePicker.Value.Date).ToList();
            }
            else
            {
                listado = RgistroEstBll.GetList(p => true);
            }

            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = listado;
        }
    }
    }

