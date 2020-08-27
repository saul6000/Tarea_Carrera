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
                carrera.Docente = int.Parse(txtcodigo.Text);
                carrera.apellidos = txtcarrera.Text;
                carrera.nombres= txtotorga.Text;
                carrera.codDependencia = txtduracion.Text;         
                carrera.fechaIngreso=time.Value;
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
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cargargridcarrera();
        }

        private void djcarrera_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

           
        }

        private void btbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
