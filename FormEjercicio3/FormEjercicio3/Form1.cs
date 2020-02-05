using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormEjercicio3
{
    public partial class Form1 : Form
    {
        String url;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "JPG files (*.jpg)|*.jpg|PNG files (*.png)|*.png|Todos los archivos (*.*)|*.*";
            file.FilterIndex = 0;
            file.ShowDialog();
            url = file.FileName;
            Form2 f2 = new Form2(url);

            f2.Text = Path.GetFileName(url);
           
            if (!Modal.Checked)
            {
                f2.Show();
            }
            else
            {
                f2.ShowDialog();
            }


            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result=MessageBox.Show("Cerrar?","Desea cerrar?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result==DialogResult.No)
            {
                e.Cancel=true;
            }

        }
    }
}
