namespace Tarea_Carrera
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtcarrera = new System.Windows.Forms.TextBox();
            this.txtotorga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btbGuardar = new System.Windows.Forms.Button();
            this.btbCerrar = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.DateTimePicker();
            this.dependencia = new System.Windows.Forms.ComboBox();
            this.mendozaDependenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Tarea_Carrera.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mendoza_DependenciaTableAdapter = new Tarea_Carrera.DataSet1TableAdapters.Mendoza_DependenciaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mendozaDependenciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(202, 30);
            this.txtcodigo.MaxLength = 50;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(257, 22);
            this.txtcodigo.TabIndex = 0;
            // 
            // txtcarrera
            // 
            this.txtcarrera.Location = new System.Drawing.Point(202, 84);
            this.txtcarrera.MaxLength = 30;
            this.txtcarrera.Name = "txtcarrera";
            this.txtcarrera.Size = new System.Drawing.Size(257, 22);
            this.txtcarrera.TabIndex = 1;
            // 
            // txtotorga
            // 
            this.txtotorga.Location = new System.Drawing.Point(202, 130);
            this.txtotorga.MaxLength = 30;
            this.txtotorga.Name = "txtotorga";
            this.txtotorga.Size = new System.Drawing.Size(257, 22);
            this.txtotorga.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Codigo de Docente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dependencia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ingreso";
            // 
            // btbGuardar
            // 
            this.btbGuardar.Location = new System.Drawing.Point(500, 46);
            this.btbGuardar.Name = "btbGuardar";
            this.btbGuardar.Size = new System.Drawing.Size(129, 60);
            this.btbGuardar.TabIndex = 11;
            this.btbGuardar.Text = "Guardar ";
            this.btbGuardar.UseVisualStyleBackColor = true;
            this.btbGuardar.Click += new System.EventHandler(this.btbGuardar_Click);
            // 
            // btbCerrar
            // 
            this.btbCerrar.Location = new System.Drawing.Point(500, 157);
            this.btbCerrar.Name = "btbCerrar";
            this.btbCerrar.Size = new System.Drawing.Size(129, 60);
            this.btbCerrar.TabIndex = 13;
            this.btbCerrar.Text = "Cerrar";
            this.btbCerrar.UseVisualStyleBackColor = true;
            this.btbCerrar.Click += new System.EventHandler(this.btbCerrar_Click);
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(202, 240);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(200, 22);
            this.time.TabIndex = 14;
            // 
            // dependencia
            // 
            this.dependencia.DataSource = this.mendozaDependenciaBindingSource;
            this.dependencia.DisplayMember = "dependencia";
            this.dependencia.FormattingEnabled = true;
            this.dependencia.Location = new System.Drawing.Point(202, 193);
            this.dependencia.Name = "dependencia";
            this.dependencia.Size = new System.Drawing.Size(257, 24);
            this.dependencia.TabIndex = 15;
            this.dependencia.ValueMember = "codDependencia";
            this.dependencia.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // mendozaDependenciaBindingSource
            // 
            this.mendozaDependenciaBindingSource.DataMember = "Mendoza_Dependencia";
            this.mendozaDependenciaBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // mendoza_DependenciaTableAdapter
            // 
            this.mendoza_DependenciaTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 359);
            this.Controls.Add(this.dependencia);
            this.Controls.Add(this.time);
            this.Controls.Add(this.btbCerrar);
            this.Controls.Add(this.btbGuardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtotorga);
            this.Controls.Add(this.txtcarrera);
            this.Controls.Add(this.txtcodigo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mendozaDependenciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtcarrera;
        private System.Windows.Forms.TextBox txtotorga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btbGuardar;
        private System.Windows.Forms.Button btbCerrar;
        private System.Windows.Forms.DateTimePicker time;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.ComboBox dependencia;
        private System.Windows.Forms.BindingSource mendozaDependenciaBindingSource;
        private DataSet1TableAdapters.Mendoza_DependenciaTableAdapter mendoza_DependenciaTableAdapter;
    }
}

