using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1Tema1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                float n1 = Convert.ToSingle(textBox1.Text);
                float n2 = Convert.ToSingle(textBox2.Text);

                label3.Text = Convert.ToString(n1 + n2);
            }
            catch (Exception)
            {
                label3.Text = "Error";
                
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
