namespace Tarea_Carrera
{
    partial class Modificar
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
            this.cmbFacultad = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtduracion = new System.Windows.Forms.TextBox();
            this.txtotorga = new System.Windows.Forms.TextBox();
            this.txtcarrera = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.btbaplicar = new System.Windows.Forms.Button();
            this.btbcerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbFacultad
            // 
            this.cmbFacultad.FormattingEnabled = true;
            this.cmbFacultad.Items.AddRange(new object[] {
            "Administración",
            "CC Salud ",
            "Educacion ",
            "Enfermeria "});
            this.cmbFacultad.Location = new System.Drawing.Point(213, 251);
            this.cmbFacultad.Name = "cmbFacultad";
            this.cmbFacultad.Size = new System.Drawing.Size(257, 24);
            this.cmbFacultad.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Facultad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Duración";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Titulo que Otorga ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nombre de Carrera ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Codigo de carrera ";
            // 
            // txtduracion
            // 
            this.txtduracion.Location = new System.Drawing.Point(213, 196);
            this.txtduracion.Name = "txtduracion";
            this.txtduracion.Size = new System.Drawing.Size(257, 22);
            this.txtduracion.TabIndex = 16;
            // 
            // txtotorga
            // 
            this.txtotorga.Location = new System.Drawing.Point(213, 141);
            this.txtotorga.Name = "txtotorga";
            this.txtotorga.Size = new System.Drawing.Size(257, 22);
            this.txtotorga.TabIndex = 15;
            // 
            // txtcarrera
            // 
            this.txtcarrera.Location = new System.Drawing.Point(213, 95);
            this.txtcarrera.Name = "txtcarrera";
            this.txtcarrera.Size = new System.Drawing.Size(257, 22);
            this.txtcarrera.TabIndex = 14;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Location = new System.Drawing.Point(213, 41);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(257, 22);
            this.txtcodigo.TabIndex = 13;
            // 
            // btbaplicar
            // 
            this.btbaplicar.Location = new System.Drawing.Point(496, 46);
            this.btbaplicar.Name = "btbaplicar";
            this.btbaplicar.Size = new System.Drawing.Size(124, 56);
            this.btbaplicar.TabIndex = 23;
            this.btbaplicar.Text = "Aplicar Cambios";
            this.btbaplicar.UseVisualStyleBackColor = true;
            this.btbaplicar.Click += new System.EventHandler(this.btbaplicar_Click);
            // 
            // btbcerrar
            // 
            this.btbcerrar.Location = new System.Drawing.Point(496, 162);
            this.btbcerrar.Name = "btbcerrar";
            this.btbcerrar.Size = new System.Drawing.Size(124, 45);
            this.btbcerrar.TabIndex = 24;
            this.btbcerrar.Text = "Cerrar";
            this.btbcerrar.UseVisualStyleBackColor = true;
            // 
            // Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 326);
            this.Controls.Add(this.btbcerrar);
            this.Controls.Add(this.btbaplicar);
            this.Controls.Add(this.cmbFacultad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtduracion);
            this.Controls.Add(this.txtotorga);
            this.Controls.Add(this.txtcarrera);
            this.Controls.Add(this.txtcodigo);
            this.Name = "Modificar";
            this.Text = "Modificar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFacultad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtduracion;
        private System.Windows.Forms.TextBox txtotorga;
        private System.Windows.Forms.TextBox txtcarrera;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Button btbaplicar;
        private System.Windows.Forms.Button btbcerrar;
    }
}