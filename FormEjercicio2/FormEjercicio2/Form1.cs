#define definird
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormEjercicio2
{
    public partial class Form1 : Form
    {
        public Color init;
        public Form1()
        {
            InitializeComponent();
            init = button1.BackColor;
        }
        

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (sender is Button)
            {
                this.Text = String.Format("Ejercicio2: X: {0} Y: {1}", e.X+((Button) sender).Location.X, e.Y+((Button) sender).Location.Y);
            }
            else
            {
                this.Text = String.Format("Ejercicio2: X: {0} Y: {1}", e.X, e.Y);
            }
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            this.Text = "Ejercicio2";
            
            
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
           
            if (e.Button == MouseButtons.Left)
            {
                button1.BackColor = Color.Gray;
            }
            else
            {
                if (e.Button==MouseButtons.Right)
                {
                    button2.BackColor = Color.Gray;
                }
                else
                {
                    button1.BackColor = Color.Gray;
                    button2.BackColor = Color.Gray;
                }
            }
           
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)//Hay que activar la propiedad del formulario keyPreview para que funcionen las teclas;
        {
            
            if (e.KeyCode == Keys.Escape)
            {
                Text = "Ejercicio2";
            }
            else
            {
                Text =e.KeyCode.ToString();
                #if definir
                Text =""+Convert.ToInt32(e.KeyCode); 
                #endif
            }
           
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result= MessageBox.Show("Cerrar", "Cierrate", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result==DialogResult.No)
            {
                e.Cancel=true;
            }
            

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
                button1.BackColor = init;
            }
            else
            {
                if (e.Button == MouseButtons.Right)
                {
                    button2.BackColor = init;
                }
                else
                {
                    button1.BackColor = init;
                    button2.BackColor = init;
                }
               
            }
            
            
        }
    }
}
