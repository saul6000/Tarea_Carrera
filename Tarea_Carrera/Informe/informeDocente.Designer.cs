namespace Tarea_Carrera.Informe
{
    partial class informeDocente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.mendozaDocentesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Tarea_Carrera.DataSet1();
            this.mendozaDocentesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mendoza_DocentesTableAdapter = new Tarea_Carrera.DataSet1TableAdapters.Mendoza_DocentesTableAdapter();
            this.mendozaDocentesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mendozaDocentesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mendozaDocentesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mendozaDocentesBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.mendozaDocentesBindingSource2;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Tarea_Carrera.Informe.ReportDocente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // mendozaDocentesBindingSource1
            // 
            this.mendozaDocentesBindingSource1.DataMember = "Mendoza_Docentes";
            this.mendozaDocentesBindingSource1.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mendozaDocentesBindingSource
            // 
            this.mendozaDocentesBindingSource.DataMember = "Mendoza_Docentes";
            this.mendozaDocentesBindingSource.DataSource = this.dataSet1;
            // 
            // mendoza_DocentesTableAdapter
            // 
            this.mendoza_DocentesTableAdapter.ClearBeforeFill = true;
            // 
            // mendozaDocentesBindingSource2
            // 
            this.mendozaDocentesBindingSource2.DataMember = "Mendoza_Docentes";
            this.mendozaDocentesBindingSource2.DataSource = this.dataSet1;
            // 
            // informeDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "informeDocente";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mendozaDocentesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mendozaDocentesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mendozaDocentesBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource mendozaDocentesBindingSource;
        private DataSet1TableAdapters.Mendoza_DocentesTableAdapter mendoza_DocentesTableAdapter;
        private System.Windows.Forms.BindingSource mendozaDocentesBindingSource1;
        private System.Windows.Forms.BindingSource mendozaDocentesBindingSource2;
    }
}