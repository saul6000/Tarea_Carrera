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
    public partial class Modificar : Form
    {
        public Modificar(datosCarrera carrera)
        {
            InitializeComponent();
            txtcodigo.Text = carrera.Codigo;
            txtcarrera.Text = carrera.Carrera;           
            txtduracion.Text = carrera.duracion.ToString();
            txtotorga.Text = carrera.otorga;
            cmbFacultad.Text = carrera.facultad.ToString();
        }

        private void btbaplicar_Click(object sender, EventArgs e)
        {
            int x = 0;
            try
            {
                Tarea_Carrera.Modelo.datosCarrera carrera=new Tarea_Carrera.Modelo.datosCarrera();
                carrera.Codigo = txtcodigo.Text;
                carrera.Carrera = txtcarrera.Text;
                if (int.Parse(txtduracion.Text) <= 5)
                {
                    carrera.duracion = int.Parse(txtduracion.Text);
                }
                else
                {
                    MessageBox.Show("Formato no Aceptado");
                    return;
                }
                carrera.facultad = cmbFacultad.Text;
                carrera.otorga = txtotorga.Text;



                x = Tarea_Carrera.Modelo.datosCarrerasDAO.update(carrera);
                if (x > 0)

                    MessageBox.Show("Actualizacion completa");


                else
                    MessageBox.Show("No se pudo actualizar los cambios ");
            }
            catch
            {
                MessageBox.Show("Formato no aceptado");
            }
            finally
            {

                this.Close();
            }
        }

        private void btbcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
