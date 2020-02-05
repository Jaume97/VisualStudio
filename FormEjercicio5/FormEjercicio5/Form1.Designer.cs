namespace FormEjercicio5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Multiselect = new System.Windows.Forms.ListBox();
            this.Uniselect = new System.Windows.Forms.ListBox();
            this.Añadir = new System.Windows.Forms.Button();
            this.Quitar = new System.Windows.Forms.Button();
            this.Izquierda = new System.Windows.Forms.Button();
            this.Derecha = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Error = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // Multiselect
            // 
            this.Multiselect.FormattingEnabled = true;
            this.Multiselect.Location = new System.Drawing.Point(12, 38);
            this.Multiselect.Name = "Multiselect";
            this.Multiselect.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.Multiselect.Size = new System.Drawing.Size(120, 108);
            this.Multiselect.TabIndex = 0;
            this.toolTip1.SetToolTip(this.Multiselect, "multiselect");
            this.Multiselect.SelectedIndexChanged += new System.EventHandler(this.Multiselect_SelectedIndexChanged);
            // 
            // Uniselect
            // 
            this.Uniselect.FormattingEnabled = true;
            this.Uniselect.Location = new System.Drawing.Point(243, 38);
            this.Uniselect.Name = "Uniselect";
            this.Uniselect.Size = new System.Drawing.Size(120, 108);
            this.Uniselect.TabIndex = 1;
            // 
            // Añadir
            // 
            this.Añadir.Location = new System.Drawing.Point(150, 97);
            this.Añadir.Name = "Añadir";
            this.Añadir.Size = new System.Drawing.Size(75, 23);
            this.Añadir.TabIndex = 2;
            this.Añadir.Text = "Añadir";
            this.toolTip1.SetToolTip(this.Añadir, "Añadir");
            this.Añadir.UseVisualStyleBackColor = true;
            this.Añadir.Click += new System.EventHandler(this.Añadir_Click);
            // 
            // Quitar
            // 
            this.Quitar.Location = new System.Drawing.Point(150, 126);
            this.Quitar.Name = "Quitar";
            this.Quitar.Size = new System.Drawing.Size(75, 23);
            this.Quitar.TabIndex = 3;
            this.Quitar.Text = "Quitar";
            this.toolTip1.SetToolTip(this.Quitar, "Quitar");
            this.Quitar.UseVisualStyleBackColor = true;
            this.Quitar.Click += new System.EventHandler(this.Quitar_Click);
            // 
            // Izquierda
            // 
            this.Izquierda.Location = new System.Drawing.Point(150, 38);
            this.Izquierda.Name = "Izquierda";
            this.Izquierda.Size = new System.Drawing.Size(75, 23);
            this.Izquierda.TabIndex = 4;
            this.Izquierda.Text = "Izquierda";
            this.toolTip1.SetToolTip(this.Izquierda, "Izquierda");
            this.Izquierda.UseVisualStyleBackColor = true;
            this.Izquierda.Click += new System.EventHandler(this.Izquierda_Click);
            // 
            // Derecha
            // 
            this.Derecha.Location = new System.Drawing.Point(150, 67);
            this.Derecha.Name = "Derecha";
            this.Derecha.Size = new System.Drawing.Size(75, 23);
            this.Derecha.TabIndex = 5;
            this.Derecha.Text = "Derecha";
            this.toolTip1.SetToolTip(this.Derecha, "Derecha");
            this.Derecha.UseVisualStyleBackColor = true;
            this.Derecha.Click += new System.EventHandler(this.Derecha_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(397, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            this.toolTip1.SetToolTip(this.textBox1, "Escribeme...");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.Location = new System.Drawing.Point(12, 161);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(0, 13);
            this.Error.TabIndex = 9;
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.ToolTip1_Popup);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Derecha);
            this.Controls.Add(this.Izquierda);
            this.Controls.Add(this.Quitar);
            this.Controls.Add(this.Añadir);
            this.Controls.Add(this.Uniselect);
            this.Controls.Add(this.Multiselect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Listbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Multiselect;
        private System.Windows.Forms.ListBox Uniselect;
        private System.Windows.Forms.Button Añadir;
        private System.Windows.Forms.Button Quitar;
        private System.Windows.Forms.Button Izquierda;
        private System.Windows.Forms.Button Derecha;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Error;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

