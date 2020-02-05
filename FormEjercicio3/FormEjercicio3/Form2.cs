using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormEjercicio3
{
    public partial class Form2 : Form
    {
        public Form2(String imagen)
        {
            InitializeComponent();
            Bitmap bt = new Bitmap(imagen);//Para imagenes usar la clase bitmap;
            pictureBox1.Image = bt;
            this.ClientSize = bt.Size;
        }
    }
}
