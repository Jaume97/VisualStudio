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
        private List<Friki> frikis = new List<Friki>();
        public Image Image;
        String title = "FrikiLove Inc.";
        int cont=0;
        String acu = "";
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            lbl.Text = "";
            ListBox.SelectedIndexCollection col = listBox1.SelectedIndices;
            if (listBox1.Items.Count != 0 && frikis.Count != 0)
            {
                if (col.Count != 0)
                {
                    System.Diagnostics.Debug.WriteLine("Count col:" + col.Count);
                    for (int i = col.Count - 1; i >= 0; i--)
                    {
                        System.Diagnostics.Debug.WriteLine("col i:" + col[i]);
                        listBox1.Items.RemoveAt(col[i]);
                        frikis.RemoveAt(col[i]);
                    }

                }
                else
                {
                    lbl.Text = "No se puede borrar porque no has selecionado nada";
                }
            }
            else
            {
                lbl.Text = "Listas Vacias";
            }


        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            bool flag = true;
            lbl.Text = "";
            Form2 f2 = new Form2();
            DialogResult result = f2.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (!f2.VtxtNombre.flagLetter)
                {
                    flag = false;
                }
                else
                {
                    if (!f2.VtxtEdad.flagNumber)
                    {
                        flag = false;
                    }
                    else
                    {
                        if (f2.txtImage.Text == "" || !f2.FileExist)
                        {
                            flag = false;
                        }
                    }
                }

                if (flag)
                {
                    Friki friki = new Friki();
                    friki.Edad = Convert.ToInt32(f2.VtxtEdad.Texto);
                    friki.Nombre = f2.VtxtNombre.Texto;

                    //sexo
                    if (f2.btnSexoHombre.Checked)
                    {
                        friki.Sexo = eSexo.Hombre;
                    }
                    else
                    {
                        friki.Sexo = eSexo.Mujer;
                    }

                    //sexoOpuesto
                    if (f2.BtnSexoOpuestoHombre.Checked)
                    {
                        friki.SexoOpuesto = eSexo.Hombre;
                    }
                    else
                    {
                        friki.SexoOpuesto = eSexo.Mujer;
                    }
                    //Aficion
                    switch ((String)f2.comboBox1.SelectedItem)//esto funciona?
                    {
                        case "Manga":
                            friki.AficionPrincipal = eAficion.Manga;
                            break;
                        case "SciFi":
                            friki.AficionPrincipal = eAficion.SciFi;
                            break;
                        case "RPG":
                            friki.AficionPrincipal = eAficion.RPG;
                            break;
                        case "Fantasia":
                            friki.AficionPrincipal = eAficion.Fantasia;
                            break;
                        case "Terror":
                            friki.AficionPrincipal = eAficion.Terror;
                            break;
                        case "Tecnologia":
                            friki.AficionPrincipal = eAficion.Tecnologia;
                            break;
                    }
                    friki.Foto = f2.txtImage.Text;
                    frikis.Add(friki);
                    listBox1.Items.Add(friki.Nombre);
                }
                else
                {
                    lbl.Text = "No se ha podido guardar en la coleccion ya que los datos son invalidos";
                }
            }

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            List<Friki> parejas = new List<Friki>();
            lblCoincidencias.Text = "";
            if (index != -1)
            {
                pictureBox1.Image = Image.FromFile(frikis[index].Foto);
                for (int i = 0; i < frikis.Count; i++)
                {
                    if (frikis[index].SexoOpuesto == frikis[i].Sexo && frikis[index].AficionPrincipal == frikis[i].AficionPrincipal)
                    {
                        parejas.Add(frikis[i]);
                    }
                }

                for (int i = 0; i < parejas.Count; i++)
                {
                    lblCoincidencias.Text += parejas[i].Nombre + ",";
                }
                toolTip1.SetToolTip(pictureBox1,String.Format("Nombre: {0}\nEdad: {1}\nAficionPrincipal: {2}\nSexo: {3}\nSexoOpuesto: {4}",
                    frikis[index].Nombre, frikis[index].Edad, frikis[index].AficionPrincipal, frikis[index].Sexo, frikis[index].SexoOpuesto));
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

        private void NuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nuevo_Click(sender,e);
        }

        private void BorrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Borrar_Click(sender,e);
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AcercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("jaume","tinder",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (cont<title.Length)
            {
                acu += title[cont];
                this.Text = acu;
                cont++;
            }
            else
            {
                cont = 0;
                acu = "";
            }
           
        }
    }

    public enum eAficion
    {
        Manga, SciFi, RPG, Fantasia, Terror, Tecnologia
    }
    public enum eSexo
    {
        Hombre, Mujer
    }
    class Friki
    {
        public String Nombre;
        public int Edad;
        public eAficion AficionPrincipal;
        public eSexo Sexo;
        public eSexo SexoOpuesto;
        public String Foto;

        public Friki()
        {

        }
    }
}
