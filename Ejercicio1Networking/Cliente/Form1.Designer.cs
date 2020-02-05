namespace Cliente
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
            this.HORA = new System.Windows.Forms.Button();
            this.FECHA = new System.Windows.Forms.Button();
            this.TODO = new System.Windows.Forms.Button();
            this.APAGAR = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.IPlbl = new System.Windows.Forms.Label();
            this.Portlbl = new System.Windows.Forms.Label();
            this.ConfigurationIP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HORA
            // 
            this.HORA.Location = new System.Drawing.Point(13, 154);
            this.HORA.Name = "HORA";
            this.HORA.Size = new System.Drawing.Size(75, 23);
            this.HORA.TabIndex = 0;
            this.HORA.Text = "HORA";
            this.HORA.UseVisualStyleBackColor = true;
            this.HORA.Click += new System.EventHandler(this.HORA_Click);
            // 
            // FECHA
            // 
            this.FECHA.Location = new System.Drawing.Point(94, 154);
            this.FECHA.Name = "FECHA";
            this.FECHA.Size = new System.Drawing.Size(75, 23);
            this.FECHA.TabIndex = 1;
            this.FECHA.Text = "FECHA";
            this.FECHA.UseVisualStyleBackColor = true;
            this.FECHA.Click += new System.EventHandler(this.FECHA_Click);
            // 
            // TODO
            // 
            this.TODO.Location = new System.Drawing.Point(175, 154);
            this.TODO.Name = "TODO";
            this.TODO.Size = new System.Drawing.Size(75, 23);
            this.TODO.TabIndex = 2;
            this.TODO.Text = "TODO";
            this.TODO.UseVisualStyleBackColor = true;
            this.TODO.Click += new System.EventHandler(this.TODO_Click);
            // 
            // APAGAR
            // 
            this.APAGAR.Location = new System.Drawing.Point(256, 154);
            this.APAGAR.Name = "APAGAR";
            this.APAGAR.Size = new System.Drawing.Size(75, 23);
            this.APAGAR.TabIndex = 3;
            this.APAGAR.Text = "APAGAR";
            this.APAGAR.UseVisualStyleBackColor = true;
            this.APAGAR.Click += new System.EventHandler(this.APAGAR_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(337, 159);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(0, 13);
            this.lbl.TabIndex = 4;
            // 
            // IPlbl
            // 
            this.IPlbl.AutoSize = true;
            this.IPlbl.Location = new System.Drawing.Point(12, 9);
            this.IPlbl.Name = "IPlbl";
            this.IPlbl.Size = new System.Drawing.Size(0, 13);
            this.IPlbl.TabIndex = 5;
            // 
            // Portlbl
            // 
            this.Portlbl.AutoSize = true;
            this.Portlbl.Location = new System.Drawing.Point(12, 36);
            this.Portlbl.Name = "Portlbl";
            this.Portlbl.Size = new System.Drawing.Size(0, 13);
            this.Portlbl.TabIndex = 6;
            // 
            // ConfigurationIP
            // 
            this.ConfigurationIP.Location = new System.Drawing.Point(12, 207);
            this.ConfigurationIP.Name = "ConfigurationIP";
            this.ConfigurationIP.Size = new System.Drawing.Size(319, 23);
            this.ConfigurationIP.TabIndex = 7;
            this.ConfigurationIP.Text = "Configuration IP and Port";
            this.ConfigurationIP.UseVisualStyleBackColor = true;
            this.ConfigurationIP.Click += new System.EventHandler(this.ConfigurationIP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ConfigurationIP);
            this.Controls.Add(this.Portlbl);
            this.Controls.Add(this.IPlbl);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.APAGAR);
            this.Controls.Add(this.TODO);
            this.Controls.Add(this.FECHA);
            this.Controls.Add(this.HORA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HORA;
        private System.Windows.Forms.Button FECHA;
        private System.Windows.Forms.Button TODO;
        private System.Windows.Forms.Button APAGAR;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label IPlbl;
        private System.Windows.Forms.Label Portlbl;
        private System.Windows.Forms.Button ConfigurationIP;
    }
}

