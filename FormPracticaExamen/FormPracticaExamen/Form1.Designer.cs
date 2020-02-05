namespace FormPracticaExamen
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDestinatario = new System.Windows.Forms.TextBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDestinatario = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.Urgencia = new System.Windows.Forms.GroupBox();
            this.Mañana = new System.Windows.Forms.RadioButton();
            this.Hoy = new System.Windows.Forms.RadioButton();
            this.Ya = new System.Windows.Forms.RadioButton();
            this.TipoNota = new System.Windows.Forms.GroupBox();
            this.Personal = new System.Windows.Forms.RadioButton();
            this.Empresa = new System.Windows.Forms.RadioButton();
            this.Publica = new System.Windows.Forms.RadioButton();
            this.btnAlmacenar = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.Urgencia.SuspendLayout();
            this.TipoNota.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(86, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.MouseEnter += new System.EventHandler(this.TxtNombre_MouseEnter);
            this.txtNombre.MouseLeave += new System.EventHandler(this.TxtNota_MouseLeave);
            // 
            // txtDestinatario
            // 
            this.txtDestinatario.Location = new System.Drawing.Point(282, 12);
            this.txtDestinatario.Name = "txtDestinatario";
            this.txtDestinatario.Size = new System.Drawing.Size(100, 20);
            this.txtDestinatario.TabIndex = 1;
            this.txtDestinatario.MouseEnter += new System.EventHandler(this.TxtNombre_MouseEnter);
            this.txtDestinatario.MouseLeave += new System.EventHandler(this.TxtNota_MouseLeave);
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(540, 12);
            this.txtNota.Multiline = true;
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(219, 187);
            this.txtNota.TabIndex = 2;
            this.txtNota.MouseEnter += new System.EventHandler(this.TxtNombre_MouseEnter);
            this.txtNota.MouseLeave += new System.EventHandler(this.TxtNota_MouseLeave);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(36, 15);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 4545;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDestinatario
            // 
            this.lblDestinatario.AutoSize = true;
            this.lblDestinatario.Location = new System.Drawing.Point(213, 15);
            this.lblDestinatario.Name = "lblDestinatario";
            this.lblDestinatario.Size = new System.Drawing.Size(63, 13);
            this.lblDestinatario.TabIndex = 445646;
            this.lblDestinatario.Text = "Destinatario";
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(487, 15);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(30, 13);
            this.lblNota.TabIndex = 454545;
            this.lblNota.Text = "Nota";
            // 
            // Urgencia
            // 
            this.Urgencia.Controls.Add(this.Mañana);
            this.Urgencia.Controls.Add(this.Hoy);
            this.Urgencia.Controls.Add(this.Ya);
            this.Urgencia.Location = new System.Drawing.Point(39, 71);
            this.Urgencia.Name = "Urgencia";
            this.Urgencia.Size = new System.Drawing.Size(132, 93);
            this.Urgencia.TabIndex = 514984;
            this.Urgencia.TabStop = false;
            this.Urgencia.Text = "Urgencia";
            // 
            // Mañana
            // 
            this.Mañana.AutoSize = true;
            this.Mañana.Checked = true;
            this.Mañana.Location = new System.Drawing.Point(6, 67);
            this.Mañana.Name = "Mañana";
            this.Mañana.Size = new System.Drawing.Size(64, 17);
            this.Mañana.TabIndex = 7;
            this.Mañana.TabStop = true;
            this.Mañana.Text = "Mañana";
            this.Mañana.UseVisualStyleBackColor = true;
            this.Mañana.CheckedChanged += new System.EventHandler(this.Ya_CheckedChanged);
            // 
            // Hoy
            // 
            this.Hoy.AutoSize = true;
            this.Hoy.Location = new System.Drawing.Point(7, 44);
            this.Hoy.Name = "Hoy";
            this.Hoy.Size = new System.Drawing.Size(44, 17);
            this.Hoy.TabIndex = 6;
            this.Hoy.TabStop = true;
            this.Hoy.Text = "Hoy";
            this.Hoy.UseVisualStyleBackColor = true;
            this.Hoy.CheckedChanged += new System.EventHandler(this.Ya_CheckedChanged);
            // 
            // Ya
            // 
            this.Ya.AutoSize = true;
            this.Ya.Location = new System.Drawing.Point(7, 20);
            this.Ya.Name = "Ya";
            this.Ya.Size = new System.Drawing.Size(38, 17);
            this.Ya.TabIndex = 5;
            this.Ya.TabStop = true;
            this.Ya.Text = "Ya";
            this.Ya.UseVisualStyleBackColor = true;
            this.Ya.CheckedChanged += new System.EventHandler(this.Ya_CheckedChanged);
            // 
            // TipoNota
            // 
            this.TipoNota.Controls.Add(this.Personal);
            this.TipoNota.Controls.Add(this.Empresa);
            this.TipoNota.Controls.Add(this.Publica);
            this.TipoNota.Location = new System.Drawing.Point(216, 71);
            this.TipoNota.Name = "TipoNota";
            this.TipoNota.Size = new System.Drawing.Size(132, 93);
            this.TipoNota.TabIndex = 9494;
            this.TipoNota.TabStop = false;
            this.TipoNota.Text = "TipoNota";
            // 
            // Personal
            // 
            this.Personal.AutoSize = true;
            this.Personal.Location = new System.Drawing.Point(6, 67);
            this.Personal.Name = "Personal";
            this.Personal.Size = new System.Drawing.Size(66, 17);
            this.Personal.TabIndex = 10;
            this.Personal.TabStop = true;
            this.Personal.Text = "Personal";
            this.Personal.UseVisualStyleBackColor = true;
            this.Personal.CheckedChanged += new System.EventHandler(this.Publica_CheckedChanged);
            // 
            // Empresa
            // 
            this.Empresa.AutoSize = true;
            this.Empresa.Location = new System.Drawing.Point(7, 44);
            this.Empresa.Name = "Empresa";
            this.Empresa.Size = new System.Drawing.Size(66, 17);
            this.Empresa.TabIndex = 9;
            this.Empresa.TabStop = true;
            this.Empresa.Text = "Empresa";
            this.Empresa.UseVisualStyleBackColor = true;
            this.Empresa.CheckedChanged += new System.EventHandler(this.Publica_CheckedChanged);
            // 
            // Publica
            // 
            this.Publica.AutoSize = true;
            this.Publica.Checked = true;
            this.Publica.Location = new System.Drawing.Point(7, 20);
            this.Publica.Name = "Publica";
            this.Publica.Size = new System.Drawing.Size(60, 17);
            this.Publica.TabIndex = 8;
            this.Publica.TabStop = true;
            this.Publica.Text = "Publica";
            this.Publica.UseVisualStyleBackColor = true;
            this.Publica.CheckedChanged += new System.EventHandler(this.Publica_CheckedChanged);
            // 
            // btnAlmacenar
            // 
            this.btnAlmacenar.Location = new System.Drawing.Point(39, 227);
            this.btnAlmacenar.Name = "btnAlmacenar";
            this.btnAlmacenar.Size = new System.Drawing.Size(75, 23);
            this.btnAlmacenar.TabIndex = 3;
            this.btnAlmacenar.Text = "&Almacenar";
            this.btnAlmacenar.UseVisualStyleBackColor = true;
            this.btnAlmacenar.Click += new System.EventHandler(this.BtnAlmacenar_Click);
            this.btnAlmacenar.MouseEnter += new System.EventHandler(this.BtnAlmacenar_MouseEnter);
            this.btnAlmacenar.MouseLeave += new System.EventHandler(this.BtnAlmacenar_MouseLeave);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(137, 227);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(75, 23);
            this.btnVisualizar.TabIndex = 4;
            this.btnVisualizar.Text = "&Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.BtnVisualizar_Click);
            this.btnVisualizar.MouseEnter += new System.EventHandler(this.BtnAlmacenar_MouseEnter);
            this.btnVisualizar.MouseLeave += new System.EventHandler(this.BtnAlmacenar_MouseLeave);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(229, 227);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 0;
            this.btnBorrar.TabStop = false;
            this.btnBorrar.Text = "&Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            this.btnBorrar.MouseEnter += new System.EventHandler(this.BtnAlmacenar_MouseEnter);
            this.btnBorrar.MouseLeave += new System.EventHandler(this.BtnAlmacenar_MouseEnter);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(320, 227);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.TabStop = false;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            this.btnSalir.MouseEnter += new System.EventHandler(this.BtnAlmacenar_MouseEnter);
            this.btnSalir.MouseLeave += new System.EventHandler(this.BtnAlmacenar_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(767, 316);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.btnAlmacenar);
            this.Controls.Add(this.TipoNota);
            this.Controls.Add(this.Urgencia);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.lblDestinatario);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.txtDestinatario);
            this.Controls.Add(this.txtNombre);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Urgencia.ResumeLayout(false);
            this.Urgencia.PerformLayout();
            this.TipoNota.ResumeLayout(false);
            this.TipoNota.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDestinatario;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDestinatario;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.GroupBox Urgencia;
        private System.Windows.Forms.RadioButton Mañana;
        private System.Windows.Forms.RadioButton Hoy;
        private System.Windows.Forms.RadioButton Ya;
        private System.Windows.Forms.GroupBox TipoNota;
        private System.Windows.Forms.RadioButton Personal;
        private System.Windows.Forms.RadioButton Empresa;
        private System.Windows.Forms.RadioButton Publica;
        private System.Windows.Forms.Button btnAlmacenar;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnSalir;
    }
}

