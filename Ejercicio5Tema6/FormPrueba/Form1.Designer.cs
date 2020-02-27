namespace FormPrueba
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
            this.validateTextbox1 = new Ejercicio5Tema6.ValidateTextbox();
            this.SuspendLayout();
            // 
            // validateTextbox1
            // 
            this.validateTextbox1.Location = new System.Drawing.Point(12, 12);
            this.validateTextbox1.MultiLine = true;
            this.validateTextbox1.Name = "validateTextbox1";
            this.validateTextbox1.Size = new System.Drawing.Size(317, 40);
            this.validateTextbox1.TabIndex = 0;
            this.validateTextbox1.Text = "validateTextbox1";
            this.validateTextbox1.Texto = "34";
            this.validateTextbox1.Tipo = Ejercicio5Tema6.ValidateTextbox.eTipo.Numerico;
            this.validateTextbox1.TextChanged += new System.EventHandler(this.ValidateTextbox1_TextChanged);
            this.validateTextbox1.Click += new System.EventHandler(this.ValidateTextbox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.validateTextbox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Ejercicio5Tema6.ValidateTextbox validateTextbox1;
    }
}

