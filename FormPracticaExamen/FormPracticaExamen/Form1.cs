using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPracticaExamen
{
    enum urgenciaEnum
    {
        Ya, Hoy, Mañana
    }
    enum Tipo
    {
        Publica, Empresa, Personal
    }
    struct almacen
    {
        public String Nombre;
        public String Destinatario;
        public String Nota;
        public urgenciaEnum urg;
        public Tipo type;
    }
    public partial class Form1 : Form
    {
        public int[] pass = { 1111, 2222, 3333, 4444, 5555 };
        int cont = 0;
        bool flag = false;
        int dato;
        List<almacen> coleccion = new List<almacen>();
        almacen alm;
        urgenciaEnum active = urgenciaEnum.Mañana;
        Tipo act = Tipo.Publica;
        int indice;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNombre.Tag = Color.LightPink;
            txtDestinatario.Tag = Color.LightPink;
            txtNota.Tag = Color.Aquamarine;
            Form2 f = new Form2();
            while (cont < 3)
            {
                DialogResult dr = f.ShowDialog();
                try
                {
                    dato = Convert.ToInt32(f.txtPin.Text);
                }
                catch (FormatException)
                {
                    f.lblError.Text = "Error";
                }

                switch (dr)
                {
                    case DialogResult.OK:
                        if (pass.Contains(dato))
                        {
                            cont = 3;
                            flag = true;
                        }
                        else
                        {
                            f.lblError.Text = "Error";
                            cont++;
                        }
                        break;
                    case DialogResult.Cancel:
                        cont = 3;
                        break;
                }
                if (cont == 3 && !flag)
                {
                    Environment.Exit(0);
                }
            }
            if (!f.chkCompleta.Checked)
            {
                Urgencia.Visible = false;
                TipoNota.Visible = false;
            }
            Ya.Tag = urgenciaEnum.Ya;
            Hoy.Tag = urgenciaEnum.Hoy;
            Mañana.Tag = urgenciaEnum.Mañana;

            Publica.Tag = Tipo.Publica;
            Empresa.Tag = Tipo.Empresa;
            Personal.Tag = Tipo.Personal;
        }

        private void TxtNombre_MouseEnter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = (Color)((TextBox)sender).Tag;
        }

        private void TxtNota_MouseLeave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Cerrar aplicacion?", "closee", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAlmacenar_Click(object sender, EventArgs e)
        {
            alm = new almacen();
            alm.Nombre = txtNombre.Text;
            alm.Destinatario = txtDestinatario.Text;
            alm.Nota = txtNota.Text;
            alm.urg = active;
            alm.type = act;
            coleccion.Add(alm);
            txtNombre.Text = "";
            txtDestinatario.Text = "";
            txtNota.Text = "";

        }

        private void Ya_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                active = (urgenciaEnum)((RadioButton)sender).Tag;
            }
        }

        private void Publica_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                act = (Tipo)((RadioButton)sender).Tag;
            }
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            if (coleccion.Count != 0)
            {
                Form3 f3 = new Form3();
                DialogResult dr3 = f3.ShowDialog();
                if (dr3 == DialogResult.OK)
                {
                    indice = Convert.ToInt32(f3.textBox1.Text);
                    if (indice >= 0 && indice < coleccion.Count)
                    {
                        for (int i = 0; i < coleccion.Count; i++)
                        {
                            coleccion.RemoveAt(indice);
                            MessageBox.Show("Borrado", "Remove", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido borrar la nota", "NOPE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay nada en la coleccion", "empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void BtnVisualizar_Click(object sender, EventArgs e)
        {
            txtNota.Text = "";
            foreach (almacen alm in coleccion)
            {
                txtNota.Text += String.Format("Nombre: {0}"+Environment.NewLine+"Destinatario: {1}" + Environment.NewLine + "Nota: {2}" + Environment.NewLine + "Urgencia: {3}" + Environment.NewLine + "TipoNota: {4}" + Environment.NewLine + " *******************************" + Environment.NewLine, alm.Nombre,alm.Destinatario,alm.Nota,alm.urg,alm.type);
            }
            
        }

        private void BtnAlmacenar_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void BtnAlmacenar_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
        }
    }
}
