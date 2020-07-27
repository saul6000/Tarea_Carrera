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
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtcarrera = new System.Windows.Forms.TextBox();
            this.txtotorga = new System.Windows.Forms.TextBox();
            this.txtduracion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.djcarrera = new System.Windows.Forms.DataGridView();
            this.btbGuardar = new System.Windows.Forms.Button();
            this.cmbFacultad = new System.Windows.Forms.ComboBox();
            this.linkModificar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.linkEliminar = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.djcarrera)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(202, 30);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(257, 22);
            this.txtcodigo.TabIndex = 0;
            // 
            // txtcarrera
            // 
            this.txtcarrera.Location = new System.Drawing.Point(202, 84);
            this.txtcarrera.Name = "txtcarrera";
            this.txtcarrera.Size = new System.Drawing.Size(257, 22);
            this.txtcarrera.TabIndex = 1;
            // 
            // txtotorga
            // 
            this.txtotorga.Location = new System.Drawing.Point(202, 130);
            this.txtotorga.Name = "txtotorga";
            this.txtotorga.Size = new System.Drawing.Size(257, 22);
            this.txtotorga.TabIndex = 2;
            // 
            // txtduracion
            // 
            this.txtduracion.Location = new System.Drawing.Point(202, 185);
            this.txtduracion.Name = "txtduracion";
            this.txtduracion.Size = new System.Drawing.Size(257, 22);
            this.txtduracion.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Codigo de carrera ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre de Carrera ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Titulo que Otorga ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Duración";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Facultad";
            // 
            // djcarrera
            // 
            this.djcarrera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.djcarrera.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.linkModificar,
            this.linkEliminar});
            this.djcarrera.Location = new System.Drawing.Point(15, 323);
            this.djcarrera.Name = "djcarrera";
            this.djcarrera.RowHeadersWidth = 51;
            this.djcarrera.RowTemplate.Height = 24;
            this.djcarrera.Size = new System.Drawing.Size(1029, 160);
            this.djcarrera.TabIndex = 10;
            this.djcarrera.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.djcarrera_CellContentClick);
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
            // cmbFacultad
            // 
            this.cmbFacultad.FormattingEnabled = true;
            this.cmbFacultad.Items.AddRange(new object[] {
            "Administración",
            "CC Salud ",
            "Educacion ",
            "Enfermeria "});
            this.cmbFacultad.Location = new System.Drawing.Point(202, 240);
            this.cmbFacultad.Name = "cmbFacultad";
            this.cmbFacultad.Size = new System.Drawing.Size(257, 24);
            this.cmbFacultad.TabIndex = 12;
            // 
            // linkModificar
            // 
            this.linkModificar.HeaderText = "Acción";
            this.linkModificar.MinimumWidth = 6;
            this.linkModificar.Name = "linkModificar";
            this.linkModificar.Text = "Modificar";
            this.linkModificar.UseColumnTextForLinkValue = true;
            this.linkModificar.Width = 125;
            // 
            // linkEliminar
            // 
            this.linkEliminar.HeaderText = "Acción";
            this.linkEliminar.MinimumWidth = 6;
            this.linkEliminar.Name = "linkEliminar";
            this.linkEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.linkEliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.linkEliminar.Text = "Eliminar";
            this.linkEliminar.UseColumnTextForLinkValue = true;
            this.linkEliminar.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 509);
            this.Controls.Add(this.cmbFacultad);
            this.Controls.Add(this.btbGuardar);
            this.Controls.Add(this.djcarrera);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtduracion);
            this.Controls.Add(this.txtotorga);
            this.Controls.Add(this.txtcarrera);
            this.Controls.Add(this.txtcodigo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.djcarrera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtcarrera;
        private System.Windows.Forms.TextBox txtotorga;
        private System.Windows.Forms.TextBox txtduracion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView djcarrera;
        private System.Windows.Forms.Button btbGuardar;
        private System.Windows.Forms.ComboBox cmbFacultad;
        private System.Windows.Forms.DataGridViewLinkColumn linkModificar;
        private System.Windows.Forms.DataGridViewLinkColumn linkEliminar;
    }
}

