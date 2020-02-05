using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad5Tema1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        DialogResult a;
        private void Button1_Click(object sender, EventArgs e)
        {

            a = MessageBox.Show("¿Cambiar titulo?","¿Desea cambiar el titulo?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (a.Equals(DialogResult.Yes))
            {
                Text = textBox1.Text;
            }
            textBox1.Text = "";

        }
    }
}
