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

namespace Ejercicio8Forms
{
    public partial class Form2 : Form
    {
        FileInfo file;
        Image img;
        public Form2(FileInfo f)
        {
            InitializeComponent();
            file = f;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                img = Image.FromFile(file.FullName);
                pictureBox1.Image = Image.FromFile(file.FullName);
                this.Width = img.Width;
                this.Height = img.Height;
            }
            catch (NullReferenceException)
            {

                Console.WriteLine("error");
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("out");
            }
        }

        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Right)
            {
                
            }
        }
    }
}
