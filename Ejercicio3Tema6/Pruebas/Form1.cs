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
        //DirectoryInfo f = new DirectoryInfo(Environment.GetEnvironmentVariable("USERPROFILE")+"imagenes");
        DirectoryInfo f;
        FileInfo[] Finfo;
        Image imagen;
        List<Image> lista = new List<Image>();
        int cont, i;
        bool flag = true;
        public Form1()
        {
            InitializeComponent();

        }

        private void Reproductor1_DesbordaTiempo(object sender, EventArgs e)
        {
            reproductor1.Minutos = reproductor1.Minutos + 1;
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
            //if (Finfo[cont].Extension == ".jpg" || Finfo[cont].Extension == ".png" || Finfo[cont].Extension == ".jpeg")
            //{
            //    imagen = new Bitmap(Finfo[cont].FullName);
            //    pictureBox1.Image = imagen;
            //}
            //cont--;
            if (f != null && !(lista.Count <= 0))
            {
                pictureBox1.Image = lista[cont];
                cont--;
                if (cont < 0)
                {
                    cont = lista.Count() - 1;
                }
                reproductor1.Segundos = reproductor1.Segundos + 1;
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnSelectFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = Directorio.ShowDialog();
            if (result == DialogResult.OK)
            {
                f = new DirectoryInfo(Directorio.SelectedPath);
                FileInfo[] files = f.GetFiles();
                try
                {
                    for (i = 0; i < files.GetLength(0); i++)
                    {
                        try
                        {
                            if (files[i].Extension == ".jpg" || files[i].Extension == ".jpeg" || files[i].Extension == ".png")
                            {
                                lista.Add(new Bitmap(files[i].FullName));
                            }
                        }
                        catch (ArgumentException)
                        {
                            System.Diagnostics.Debug.WriteLine("coja una carpeta");
                            i++;
                        }

                    }

                }
                catch (UnauthorizedAccessException)
                {
                    System.Diagnostics.Debug.WriteLine("No autorizado");
                }


                cont = lista.Count() - 1;
                //System.Diagnostics.Debug.WriteLine(Finfo[cont].Extension);
            }
        }
    }
}
