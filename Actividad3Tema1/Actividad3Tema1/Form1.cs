using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad3Tema1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int saldo=50;
        private void Button1_Click(object sender, EventArgs e)
        {
            saldo = saldo - 2;
            label2.Text = "Tienes" + saldo + "€";
            Random aleatorio = new Random();
            textBox1.Text =Convert.ToString(aleatorio.Next(1, 8));
            textBox2.Text = Convert.ToString(aleatorio.Next(1,8));
            textBox3.Text = Convert.ToString(aleatorio.Next(1, 8));

            if (textBox1.Text==textBox2.Text&&textBox2.Text==textBox3.Text)
            {
                saldo = saldo + 20;
                label1.Text = "Has ganado 20€";
            }
            else
            {
                if (textBox1.Text==textBox2.Text||textBox1.Text==textBox3.Text||textBox2.Text==textBox3.Text)
                {
                    saldo = saldo + 5;
                    label1.Text = "Has ganado 5€";
                }
                else
                {
                    label1.Text = "HAS PERDIDO";
                }
            }
            
            
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            saldo = saldo + 10;
             label2.Text = "Tienes" + saldo + "€";
        }
    }
}
