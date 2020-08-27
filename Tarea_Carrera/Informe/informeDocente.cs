using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_Carrera.Informe
{
    public partial class informeDocente : Form
    {
        public informeDocente()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Mendoza_Docentes' Puede moverla o quitarla según sea necesario.
            this.mendoza_DocentesTableAdapter.Fill(this.dataSet1.Mendoza_Docentes);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
