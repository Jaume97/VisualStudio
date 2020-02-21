namespace PruebaTema5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.labelTexto1 = new LabelTextbox.LabelTexto();
            this.customControl13 = new Etiquetaviso.CustomControl1();
            this.customControl12 = new Etiquetaviso.CustomControl1();
            this.customControl11 = new Etiquetaviso.CustomControl1();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "ChangePosition";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(129, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "ChangeSeparation";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(634, 383);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // labelTexto1
            // 
            this.labelTexto1.Location = new System.Drawing.Point(12, 12);
            this.labelTexto1.Name = "labelTexto1";
            this.labelTexto1.Posicion = LabelTextbox.ePosicion.IZQUIERDA;
            this.labelTexto1.Pswchar = '$';
            this.labelTexto1.Separacion = 0;
            this.labelTexto1.Size = new System.Drawing.Size(357, 20);
            this.labelTexto1.TabIndex = 0;
            this.labelTexto1.TextLbl = "Nombree";
            this.labelTexto1.TextTxt = "";
            this.labelTexto1.CambiaPosicion += new System.EventHandler(this.LabelTexto1_CambiaPosicion);
            this.labelTexto1.CambiarSeparacion += new System.EventHandler(this.LabelTexto1_CambiarSeparacion);
            this.labelTexto1.TxtChanged += new System.EventHandler(this.LabelTexto1_TxtChanged);
            this.labelTexto1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LabelTexto1_KeyUp);
            // 
            // customControl13
            // 
            this.customControl13.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customControl13.Gradient = false;
            this.customControl13.ImagenMarca = global::PruebaTema5.Properties.Resources.hola;
            this.customControl13.Location = new System.Drawing.Point(178, 125);
            this.customControl13.Marca = Etiquetaviso.eMarca.Nada;
            this.customControl13.Name = "customControl13";
            this.customControl13.Size = new System.Drawing.Size(541, 83);
            this.customControl13.TabIndex = 7;
            this.customControl13.Text = "customControl13";
            this.customControl13.ClickEnMarca += new System.EventHandler(this.CustomControl13_ClickEnMarca);
            // 
            // customControl12
            // 
            this.customControl12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customControl12.Gradient = false;
            this.customControl12.ImagenMarca = ((System.Drawing.Image)(resources.GetObject("customControl12.ImagenMarca")));
            this.customControl12.Location = new System.Drawing.Point(101, 258);
            this.customControl12.Marca = Etiquetaviso.eMarca.Imagen;
            this.customControl12.Name = "customControl12";
            this.customControl12.Size = new System.Drawing.Size(50, 20);
            this.customControl12.TabIndex = 6;
            this.customControl12.Text = "das";
            this.customControl12.ClickEnMarca += new System.EventHandler(this.CustomControl12_ClickEnMarca);
            // 
            // customControl11
            // 
            this.customControl11.Gradient = false;
            this.customControl11.ImagenMarca = ((System.Drawing.Image)(resources.GetObject("customControl11.ImagenMarca")));
            this.customControl11.Location = new System.Drawing.Point(-415, 274);
            this.customControl11.Marca = Etiquetaviso.eMarca.Imagen;
            this.customControl11.Name = "customControl11";
            this.customControl11.Size = new System.Drawing.Size(107, 13);
            this.customControl11.TabIndex = 5;
            this.customControl11.Text = "asdasdadwqdqwd";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 450);
            this.Controls.Add(this.customControl13);
            this.Controls.Add(this.customControl12);
            this.Controls.Add(this.customControl11);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelTexto1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LabelTextbox.LabelTexto labelTexto1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private Etiquetaviso.CustomControl1 customControl11;
        private Etiquetaviso.CustomControl1 customControl12;
        private Etiquetaviso.CustomControl1 customControl13;
    }
}

