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
    public partial class Form1 : Form
    {
        FileInfo f;
        DirectoryInfo Dinfo;
        List<Image> imagenes = new List<Image>();
        List<FileInfo> FilesInfos = new List<FileInfo>();
        int Imagenenctual;
        int cont=0;
        Form2 f2;
        public Form1()
        {
            InitializeComponent();


        }

        private void BtnAbrir_Click(object sender, EventArgs e)
        {

            if (f2!=null)
            {
                f2.Close();
                imagenes.Clear();
                FilesInfos.Clear();
                cont = 0;
            }
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    f = new FileInfo(openFileDialog1.FileName);
                    Dinfo = f.Directory;
                    foreach (FileInfo f in Dinfo.GetFiles())
                    {
                        try
                        {
                            if (f.Extension == ".jpg" || f.Extension == ".png" || f.Extension == ".jpeg" || f.Extension==".ico")
                            {
                                imagenes.Add(Image.FromFile(f.FullName));
                                FilesInfos.Add(f);
                            }
                            cont++;
                        }
                        catch (OutOfMemoryException)
                        {
                            Console.WriteLine("error2");
                        }
                    }
                    f2 = new Form2(f);
                    f2.Show();
                    BtnAtras.Enabled = true;
                    BtnSiguiente.Enabled = true;
                    f2.pictureBox1.Tag = f;
                    f2.Width = Image.FromFile(((FileInfo)f2.pictureBox1.Tag).FullName).Width;
                    f2.Height = Image.FromFile(((FileInfo)f2.pictureBox1.Tag).FullName).Height;
                    lbl.Text = String.Format("Directorio: {0}\nNombreImg: {1}\nTamaño: {2}\nResolucion: {3}", ((FileInfo)f2.pictureBox1.Tag).Directory,
                       ((FileInfo)f2.pictureBox1.Tag).Name, ((FileInfo)f2.pictureBox1.Tag).Length.ToString(), Image.FromFile(((FileInfo)f2.pictureBox1.Tag).FullName).HorizontalResolution);
                    this.Text = ("Visor de Imagenes - " + f.Name);


                    f2.pictureBox1.ContextMenuStrip = contextMenuStrip1;
                }
            }
            catch (OutOfMemoryException)
            {
                f2.Close();
                imagenes.Clear();
                FilesInfos.Clear();
                cont = 0;
                Console.WriteLine("out");
            }
        }
        public void BuscarIndice()
        {
            for (int i = 0; i < FilesInfos.Count; i++)
            {
                if (((FileInfo)f2.pictureBox1.Tag).Name == FilesInfos[i].Name)
                {
                    Imagenenctual = i;
                    System.Diagnostics.Debug.WriteLine(i);
                }
            }
        }


        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            if (f2.pictureBox1.Image != null)
            {
                BuscarIndice();
                try
                {
                    if (Imagenenctual == FilesInfos.Count - 1)
                    {
                        f2.pictureBox1.Image = imagenes[0];
                        f2.pictureBox1.Tag = FilesInfos[0];
                    }
                    else
                    {
                        f2.pictureBox1.Image = imagenes[Imagenenctual + 1];
                        f2.pictureBox1.Tag = FilesInfos[Imagenenctual + 1];
                    }
                }
                catch (ArgumentOutOfRangeException)
                {

                    Console.WriteLine("fuera de rango");
                }

                this.Text = ("Visor de Imagenes - " + ((FileInfo)f2.pictureBox1.Tag).Name);
                lbl.Text = String.Format("Directorio: {0}\nNombreImg: {1}\nTamaño: {2}\nResolucion: {3}", ((FileInfo)f2.pictureBox1.Tag).Directory,
                       ((FileInfo)f2.pictureBox1.Tag).Name, ((FileInfo)f2.pictureBox1.Tag).Length.ToString(), Image.FromFile(((FileInfo)f2.pictureBox1.Tag).FullName).HorizontalResolution);
                f2.Width = Image.FromFile(((FileInfo)f2.pictureBox1.Tag).FullName).Width;
                f2.Height = Image.FromFile(((FileInfo)f2.pictureBox1.Tag).FullName).Height;
            }


        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            if (f2.pictureBox1.Image != null)
            {
                BuscarIndice();
                try
                {
                    if (Imagenenctual == 0)
                    {
                        f2.pictureBox1.Image = imagenes[FilesInfos.Count - 1];
                        f2.pictureBox1.Tag = FilesInfos[FilesInfos.Count - 1];
                    }
                    else
                    {
                        f2.pictureBox1.Image = imagenes[Imagenenctual - 1];
                        f2.pictureBox1.Tag = FilesInfos[Imagenenctual - 1];
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("feura de rango");
                }
                this.Text = ("Visor de Imagenes - " + ((FileInfo)f2.pictureBox1.Tag).Name);
                lbl.Text = String.Format("Directorio: {0}\nNombreImg: {1}\nTamaño: {2}\nResolucion: {3}", ((FileInfo)f2.pictureBox1.Tag).Directory,
                       ((FileInfo)f2.pictureBox1.Tag).Name, ((FileInfo)f2.pictureBox1.Tag).Length.ToString(), Image.FromFile(((FileInfo)f2.pictureBox1.Tag).FullName).HorizontalResolution);
                f2.Width = Image.FromFile(((FileInfo)f2.pictureBox1.Tag).FullName).Width;
                f2.Height = Image.FromFile(((FileInfo)f2.pictureBox1.Tag).FullName).Height;
            }

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (f2 != null)
            {
                if (e.Button == MouseButtons.Left)
                {
                    BtnAtras_Click(this, new EventArgs());
                }
                else if (e.Button == MouseButtons.Right)
                {
                    BtnSiguiente_Click(this, new EventArgs());
                }
            }
        }

        private void CerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2.pictureBox1.Image = null;
            this.Text = "";
            lbl.Text = "";
            f2.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Mi Aplicación",MessageBoxButtons.OKCancel, MessageBoxIcon.Question)== DialogResult.Cancel)
            {
                e.Cancel = true;

            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("entra evento up");
            if (e.KeyCode==Keys.A)
            {
                BtnAtras_Click(this, new EventArgs());
            }else if (e.KeyCode==Keys.D)
            {
                BtnSiguiente_Click(this, new EventArgs());
            }
        }

        
    }
}
