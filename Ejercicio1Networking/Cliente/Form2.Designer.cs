namespace Cliente
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
            this.btnSwitch = new System.Windows.Forms.Button();
            this.lblIPf2 = new System.Windows.Forms.Label();
            this.lblPortf2 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSwitch
            // 
            this.btnSwitch.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSwitch.Location = new System.Drawing.Point(15, 82);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(132, 23);
            this.btnSwitch.TabIndex = 0;
            this.btnSwitch.Text = "Switch";
            this.btnSwitch.UseVisualStyleBackColor = true;
            // 
            // lblIPf2
            // 
            this.lblIPf2.AutoSize = true;
            this.lblIPf2.Location = new System.Drawing.Point(12, 9);
            this.lblIPf2.Name = "lblIPf2";
            this.lblIPf2.Size = new System.Drawing.Size(20, 13);
            this.lblIPf2.TabIndex = 1;
            this.lblIPf2.Text = "IP:";
            // 
            // lblPortf2
            // 
            this.lblPortf2.AutoSize = true;
            this.lblPortf2.Location = new System.Drawing.Point(12, 43);
            this.lblPortf2.Name = "lblPortf2";
            this.lblPortf2.Size = new System.Drawing.Size(29, 13);
            this.lblPortf2.TabIndex = 2;
            this.lblPortf2.Text = "Port:";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(47, 6);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 20);
            this.txtIP.TabIndex = 3;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(47, 40);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 20);
            this.txtPort.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 151);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.lblPortf2);
            this.Controls.Add(this.lblIPf2);
            this.Controls.Add(this.btnSwitch);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblIPf2;
        private System.Windows.Forms.Label lblPortf2;
        public System.Windows.Forms.Button btnSwitch;
        public System.Windows.Forms.TextBox txtIP;
        public System.Windows.Forms.TextBox txtPort;
    }
}