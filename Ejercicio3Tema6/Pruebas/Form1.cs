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

namespace Pruebas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Reproductor1_DesbordaTiempo(object sender, EventArgs e)
        {
            reproductor1.Minutos = reproductor1.Minutos+1;
            reproductor1.Segundos = 0;
        }

        private void Reproductor1_Reproducir(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            reproductor1.Segundos = reproductor1.Segundos +1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DialogResult result = Directorio.ShowDialog();
            if (result == DialogResult.OK)
            {
                //TODO
            }
        }
    }
}
