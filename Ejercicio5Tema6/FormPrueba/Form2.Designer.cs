namespace FormPrueba
{
    partial class Form2
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblAficion = new System.Windows.Forms.Label();
            this.groupSexo = new System.Windows.Forms.GroupBox();
            this.groupSexoOpuesto = new System.Windows.Forms.GroupBox();
            this.btnSexoHombre = new System.Windows.Forms.RadioButton();
            this.BtnSexoMujer = new System.Windows.Forms.RadioButton();
            this.BtnSexoOpuestoHombre = new System.Windows.Forms.RadioButton();
            this.BtnSexoOpuestoMujer = new System.Windows.Forms.RadioButton();
            this.BtnImage = new System.Windows.Forms.Button();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.BtnAcept = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblImageAviso = new System.Windows.Forms.Label();
            this.VtxtEdad = new Ejercicio5Tema6.ValidateTextbox();
            this.VtxtNombre = new Ejercicio5Tema6.ValidateTextbox();
            this.groupSexo.SuspendLayout();
            this.groupSexoOpuesto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 27);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(12, 89);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 3;
            this.lblEdad.Text = "Edad";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(57, 149);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // lblAficion
            // 
            this.lblAficion.AutoSize = true;
            this.lblAficion.Location = new System.Drawing.Point(12, 152);
            this.lblAficion.Name = "lblAficion";
            this.lblAficion.Size = new System.Drawing.Size(39, 13);
            this.lblAficion.TabIndex = 5;
            this.lblAficion.Text = "Aficion";
            // 
            // groupSexo
            // 
            this.groupSexo.Controls.Add(this.BtnSexoMujer);
            this.groupSexo.Controls.Add(this.btnSexoHombre);
            this.groupSexo.Location = new System.Drawing.Point(15, 193);
            this.groupSexo.Name = "groupSexo";
            this.groupSexo.Size = new System.Drawing.Size(200, 100);
            this.groupSexo.TabIndex = 6;
            this.groupSexo.TabStop = false;
            this.groupSexo.Text = "Sexo";
            // 
            // groupSexoOpuesto
            // 
            this.groupSexoOpuesto.Controls.Add(this.BtnSexoOpuestoMujer);
            this.groupSexoOpuesto.Controls.Add(this.BtnSexoOpuestoHombre);
            this.groupSexoOpuesto.Location = new System.Drawing.Point(264, 193);
            this.groupSexoOpuesto.Name = "groupSexoOpuesto";
            this.groupSexoOpuesto.Size = new System.Drawing.Size(200, 100);
            this.groupSexoOpuesto.TabIndex = 7;
            this.groupSexoOpuesto.TabStop = false;
            this.groupSexoOpuesto.Text = "SexoOpuesto";
            // 
            // btnSexoHombre
            // 
            this.btnSexoHombre.AutoSize = true;
            this.btnSexoHombre.Checked = true;
            this.btnSexoHombre.Location = new System.Drawing.Point(6, 19);
            this.btnSexoHombre.Name = "btnSexoHombre";
            this.btnSexoHombre.Size = new System.Drawing.Size(62, 17);
            this.btnSexoHombre.TabIndex = 0;
            this.btnSexoHombre.TabStop = true;
            this.btnSexoHombre.Text = "Hombre";
            this.btnSexoHombre.UseVisualStyleBackColor = true;
            // 
            // BtnSexoMujer
            // 
            this.BtnSexoMujer.AutoSize = true;
            this.BtnSexoMujer.Location = new System.Drawing.Point(6, 59);
            this.BtnSexoMujer.Name = "BtnSexoMujer";
            this.BtnSexoMujer.Size = new System.Drawing.Size(51, 17);
            this.BtnSexoMujer.TabIndex = 1;
            this.BtnSexoMujer.Text = "Mujer";
            this.BtnSexoMujer.UseVisualStyleBackColor = true;
            // 
            // BtnSexoOpuestoHombre
            // 
            this.BtnSexoOpuestoHombre.AutoSize = true;
            this.BtnSexoOpuestoHombre.Location = new System.Drawing.Point(6, 19);
            this.BtnSexoOpuestoHombre.Name = "BtnSexoOpuestoHombre";
            this.BtnSexoOpuestoHombre.Size = new System.Drawing.Size(62, 17);
            this.BtnSexoOpuestoHombre.TabIndex = 1;
            this.BtnSexoOpuestoHombre.Text = "Hombre";
            this.BtnSexoOpuestoHombre.UseVisualStyleBackColor = true;
            // 
            // BtnSexoOpuestoMujer
            // 
            this.BtnSexoOpuestoMujer.AutoSize = true;
            this.BtnSexoOpuestoMujer.Checked = true;
            this.BtnSexoOpuestoMujer.Location = new System.Drawing.Point(6, 59);
            this.BtnSexoOpuestoMujer.Name = "BtnSexoOpuestoMujer";
            this.BtnSexoOpuestoMujer.Size = new System.Drawing.Size(51, 17);
            this.BtnSexoOpuestoMujer.TabIndex = 2;
            this.BtnSexoOpuestoMujer.TabStop = true;
            this.BtnSexoOpuestoMujer.Text = "Mujer";
            this.BtnSexoOpuestoMujer.UseVisualStyleBackColor = true;
            // 
            // BtnImage
            // 
            this.BtnImage.Location = new System.Drawing.Point(455, 21);
            this.BtnImage.Name = "BtnImage";
            this.BtnImage.Size = new System.Drawing.Size(75, 23);
            this.BtnImage.TabIndex = 8;
            this.BtnImage.Text = "Imagen";
            this.BtnImage.UseVisualStyleBackColor = true;
            this.BtnImage.Click += new System.EventHandler(this.BtnImage_Click);
            // 
            // txtImage
            // 
            this.txtImage.Location = new System.Drawing.Point(349, 23);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(100, 20);
            this.txtImage.TabIndex = 9;
            // 
            // BtnAcept
            // 
            this.BtnAcept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnAcept.Location = new System.Drawing.Point(21, 329);
            this.BtnAcept.Name = "BtnAcept";
            this.BtnAcept.Size = new System.Drawing.Size(75, 23);
            this.BtnAcept.TabIndex = 10;
            this.BtnAcept.Text = "Aceptar";
            this.BtnAcept.UseVisualStyleBackColor = true;
            this.BtnAcept.Click += new System.EventHandler(this.BtnAcept_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Location = new System.Drawing.Point(117, 329);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 11;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Archivos JPG|*.jpg|Todos los archivos|*.*";
            // 
            // lblImageAviso
            // 
            this.lblImageAviso.AutoSize = true;
            this.lblImageAviso.Location = new System.Drawing.Point(536, 27);
            this.lblImageAviso.Name = "lblImageAviso";
            this.lblImageAviso.Size = new System.Drawing.Size(0, 13);
            this.lblImageAviso.TabIndex = 12;
            // 
            // VtxtEdad
            // 
            this.VtxtEdad.Location = new System.Drawing.Point(53, 77);
            this.VtxtEdad.MultiLine = false;
            this.VtxtEdad.Name = "VtxtEdad";
            this.VtxtEdad.Size = new System.Drawing.Size(197, 40);
            this.VtxtEdad.TabIndex = 1;
            this.VtxtEdad.Texto = "";
            this.VtxtEdad.Tipo = Ejercicio5Tema6.ValidateTextbox.eTipo.Numerico;
            // 
            // VtxtNombre
            // 
            this.VtxtNombre.Location = new System.Drawing.Point(53, 12);
            this.VtxtNombre.MultiLine = false;
            this.VtxtNombre.Name = "VtxtNombre";
            this.VtxtNombre.Size = new System.Drawing.Size(197, 40);
            this.VtxtNombre.TabIndex = 0;
            this.VtxtNombre.Texto = "";
            this.VtxtNombre.Tipo = Ejercicio5Tema6.ValidateTextbox.eTipo.Textual;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblImageAviso);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAcept);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.BtnImage);
            this.Controls.Add(this.groupSexoOpuesto);
            this.Controls.Add(this.groupSexo);
            this.Controls.Add(this.lblAficion);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.VtxtEdad);
            this.Controls.Add(this.VtxtNombre);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupSexo.ResumeLayout(false);
            this.groupSexo.PerformLayout();
            this.groupSexoOpuesto.ResumeLayout(false);
            this.groupSexoOpuesto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEdad;
        public Ejercicio5Tema6.ValidateTextbox VtxtNombre;
        public Ejercicio5Tema6.ValidateTextbox VtxtEdad;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblAficion;
        private System.Windows.Forms.GroupBox groupSexo;
        public System.Windows.Forms.RadioButton BtnSexoMujer;
        public System.Windows.Forms.RadioButton btnSexoHombre;
        private System.Windows.Forms.GroupBox groupSexoOpuesto;
        public System.Windows.Forms.RadioButton BtnSexoOpuestoMujer;
        public System.Windows.Forms.RadioButton BtnSexoOpuestoHombre;
        public System.Windows.Forms.Button BtnImage;
        public System.Windows.Forms.TextBox txtImage;
        public System.Windows.Forms.Button BtnAcept;
        public System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblImageAviso;
    }
}