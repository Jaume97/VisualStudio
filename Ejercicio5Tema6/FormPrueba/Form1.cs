using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPrueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ValidateTextbox1_Click(object sender, EventArgs e)
        {

        }

        private void ValidateTextbox1_TextChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("sdafasfs");
        }
    }
}
