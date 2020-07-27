using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea_Carrera.Modelo;

namespace Tarea_Carrera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btbGuardar_Click(object sender, EventArgs e)
        {
             Tarea_Carrera.Modelo.datosCarrera carrera = new Tarea_Carrera.Modelo.datosCarrera();
            int x = 0;
          
            try
            {
                carrera.Codigo = txtcodigo.Text;
                carrera.Carrera = txtcarrera.Text;
                carrera.otorga = txtotorga.Text;
                
                if (int.Parse(txtduracion.Text) >=1 && int.Parse(txtduracion.Text) <= 5)
                {
                    carrera.duracion = int.Parse(txtduracion.Text);
                }
                else
                {
                    MessageBox.Show("Formato no Aceptado");
                    return;
                }
                carrera.facultad=cmbFacultad.Text;
                if (Tarea_Carrera.Modelo.datosCarrerasDAO.existecodigo(this.txtcodigo.Text))
                {
                    MessageBox.Show("Este Codigo ya existe");
                    return; //abandonar;
                }
                x = Tarea_Carrera.Modelo.datosCarrerasDAO.creacion(carrera);
                if (x > 0)
                {
                    MessageBox.Show("Datos Guardados");
                }
                else
                {
                    MessageBox.Show("Datos no Guardados");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
               this.cargargridcarrera();
            }
        }
        private void cargargridcarrera()
        {
            DataTable dt = Tarea_Carrera.Modelo.datosCarrerasDAO.getAll();
            this.djcarrera.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cargargridcarrera();
        }

        private void djcarrera_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView grid = (DataGridView)sender;
            int fila = e.RowIndex;
            string carrera = djcarrera[3, fila].Value.ToString();

            if (grid.Columns[e.ColumnIndex].Name == "linkEliminar")
            {
                // MessageBox.Show("Fila: " + fila.ToString() + ", col: " + col.ToString());
                string codgio = djcarrera[2, fila].Value.ToString();
                string confirmMessage = string.Format("¿Está seguro de que desea eliminar la carrera  de " + " " + carrera + "?"
                    , grid.Rows[fila].Cells[2].Value);
                if (MessageBox.Show(confirmMessage, "Eliminar Materia", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show("Materia Eliminada Exitosamente");
                    grid.Rows.RemoveAt(fila);
                    int x = Tarea_Carrera.Modelo.datosCarrerasDAO.btbdelete(codgio);
                }


            }
            if (grid.Columns[e.ColumnIndex].Name == "linkModificar")
            {

                // MessageBox.Show("Fila: " + fila.ToString() + ", col: " + col.ToString());
                string codgio = djcarrera[2, fila].Value.ToString();

                string confirmMessage = string.Format("¿Está seguro de que desea Modificar  la carrera de " + " " + carrera + "?"
                    , grid.Rows[fila].Cells[2].Value);
                if (MessageBox.Show(confirmMessage, "Modficar Materia", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    datosCarrera H = Tarea_Carrera.Modelo.datosCarrerasDAO.getcarrera(codgio);
                    Modificar modificar = new Modificar(H);
                    modificar.ShowDialog();
                    cargargridcarrera();



                }
            }
        }

        private void btbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
