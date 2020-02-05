using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaTema5
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LabelTexto1_CambiaPosicion(object sender, EventArgs e)
        {
            this.Text =""+ Convert.ToInt32(labelTexto1.Posicion);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (labelTexto1.Posicion==LabelTextbox.ePosicion.IZQUIERDA)
            {
                labelTexto1.Posicion = LabelTextbox.ePosicion.DERECHA;   
            }
            else
            {
                labelTexto1.Posicion = LabelTextbox.ePosicion.IZQUIERDA;
            }
           
        }

        private void LabelTexto1_CambiarSeparacion(object sender, EventArgs e)
        {
            this.Text = ""+labelTexto1.Separacion;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            labelTexto1.Separacion+=1;
        }

        private void LabelTexto1_KeyUp(object sender, KeyEventArgs e)
        {
            this.Text = "Letra: " + e.KeyCode;
        }

        private void LabelTexto1_TxtChanged(object sender, EventArgs e)
        {
            label1.Text = labelTexto1.TextTxt;
        }
        bool bandera = true;
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (bandera)
            {
                e.Graphics.DrawString("Prueba de escritura de texto",
                    this.Font, Brushes.BlueViolet, 10, 100);
            }
           
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            bandera = !bandera;
            this.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void CustomControl12_ClickEnMarca(object sender, EventArgs e)
        {
            
        }

        private void CustomControl13_ClickEnMarca(object sender, EventArgs e)
        {

        }
    }
}
