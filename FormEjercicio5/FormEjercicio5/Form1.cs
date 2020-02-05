using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormEjercicio5
{

    //Tooltip secundario
    
    public partial class Form1 : Form
    {
        private Icon icon1 = new Icon("C:\\Users\\Jaume\\Desktop\\ico.ico");  // rutas absolutas NO
        private Icon icon2 = new Icon("C:\\Users\\Jaume\\Desktop\\mario.ico");
        int cont=0;
        bool flag=false;
        String titulo;
        
        public Form1()
        {
            InitializeComponent();
            Actualizar_Valores();
           
            timer1.Start();
            titulo = this.Text;
            this.Text = "";

        }
        
        private void Añadir_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Multiselect.Items.Add(textBox1.Text);
                textBox1.Clear();
                
            }
            Actualizar_Valores();
        }

        private void Quitar_Click(object sender, EventArgs e)
        {
            if (Multiselect.Items.Count==0)
            {
                Error.Text = "No hay ningun elemento en la lista de multiseleccion";
            }
            else
            {
                Error.Text = "";
                ListBox.SelectedIndexCollection selects = Multiselect.SelectedIndices;
                for (int i = selects.Count-1; i >=0; i--)
                {
                    Multiselect.Items.RemoveAt(selects[i]);
                }
                
            }
            Actualizar_Valores();
            
        }

        private void Actualizar_Valores()
        {
            label1.Text = "Tamaño de la lista Principal: " + Multiselect.Items.Count;
        }

        private void Multiselect_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = "Indices: ";
            ListBox.SelectedIndexCollection indices = Multiselect.SelectedIndices;
            for (int i = 0; i < indices.Count; i++)
            {
                label2.Text = label2.Text + indices[i] + ",";
            }
        }

        private void Derecha_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection indices = Multiselect.SelectedItems;  
            
            for (int i = indices.Count-1; i>=0; i--)
            {
                Uniselect.Items.Insert(0, indices[i]);
                Multiselect.Items.Remove(indices[i]);
            }
            Actualizar_Valores();
        }

        private void Izquierda_Click(object sender, EventArgs e)
        {
            
            ListBox.SelectedObjectCollection indices = Uniselect.SelectedItems;
           
            for (int i=indices.Count-1; i>=0; i--) //No hace falta el bucle
            {
                Multiselect.Items.Insert(0, indices[i]);
                Uniselect.Items.Remove(indices[i]);
            }
            Actualizar_Valores();

        }

        private void Timer1_Tick(object sender, EventArgs e)
        { 
            cont++;
            if (this.Text.Length == titulo.Length)
            {
                this.Text = "";
            }
            this.Text=this.Text.Insert(0, Convert.ToString(titulo[(titulo.Length-1)-this.Text.Length]));
            //Icono
            if (cont % 2 == 0)
            {
                if (flag)
                {
                    this.Icon = icon1;
                }
                else
                {
                    this.Icon = icon2;
                }
                flag = !flag;
            }
            
         
        }

        private void ToolTip1_Popup(object sender, PopupEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(sender.GetType());
            //toolTip1.SetToolTip(Uniselect,"Cantidad de elementos: " +Uniselect.Items.Count);
            
        }
    }
}
