using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormEjercicio1
{
    public partial class Form1 : Form
    {
        Color f;
        public Form1()
        {
            InitializeComponent();
            f = Salir.BackColor;
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Cerrar Aplicacion!", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void ChangeColor_Click(object sender, EventArgs e)
        {
            Error.Text = "";
            try
            {
                int r = Convert.ToInt32(textBox1.Text);
                int g = Convert.ToInt32(textBox2.Text);
                int b = Convert.ToInt32(textBox3.Text);
                if ((r >= 0 && r <= 255) && (g >= 0 && g <= 255) && (b >= 0 && b <= 255))
                {
                    this.BackColor = Color.FromArgb(r, g, b);
                }
                else
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                Error.Text = "Error";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }

        private void LoadImage_Click(object sender, EventArgs e)
        {
            String path = txtImage.Text;//IMAGELABEL?
            label1.Image = Image.FromFile(path);
            
        }

        private void Salir_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Red;
        }

        private void Salir_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = f;
        }

        private void TextBox1_Enter(object sender, EventArgs e)
        {
            AcceptButton = ChangeColor;
        }

        private void TxtImage_Enter(object sender, EventArgs e)
        {
            AcceptButton = LoadImage;
        }
    }
}
