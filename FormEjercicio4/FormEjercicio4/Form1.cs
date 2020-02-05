using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormEjercicio4 //chequear un rb y acceptbutton
{   
    
    public partial class Form1 : Form
    {
        public delegate double Operation(double a, double b);
        Hashtable tabla = new Hashtable();
        int cont = 0;
        int min = 0;
        String radioName;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();

            tabla.Add("Sumar", new Operation((a, b) => { return a + b; }));
            tabla.Add("Restar", new Operation((a, b) => { return a - b; }));
            tabla.Add("Multiplicar", new Operation((a, b) => { return a * b; }));
            tabla.Add("Dividir", new Operation((a, b) => { return a / b; }));

            radioName = "Sumar";
            label1.Text = Convert.ToString(Sumar.Tag);

        }
        private void Timer1_Tick(object sender, EventArgs e) //Formato
        {
            cont++;
            if (cont ==60)
            {
                cont = 0;
                min++;
            }
            this.Text = String.Format("{0,2:D2}:{1,2:D2}",min,cont);
            

        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            radioName = ((RadioButton)sender).Name;
            label1.Text =Convert.ToString(((RadioButton)sender).Tag);
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
           
            try
            {

                result.Text = "Resultado= " + ((Operation)tabla[radioName])(Convert.ToDouble(txt1.Text), Convert.ToDouble(txt2.Text));
            }
            catch (FormatException)
            {
                result.Text="Datos invalidos";
            }
            catch (ArithmeticException)
            {
                result.Text = "Aritmetic exception";
            }
            catch (ArgumentNullException)
            {
                result.Text = "Introduce datos";
            }
           
        }
    }
}
