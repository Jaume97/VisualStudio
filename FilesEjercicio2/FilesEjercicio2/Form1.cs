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

namespace FilesEjercicio2
{
    public partial class Form1 : Form
    {
        String Contenido;
        String path;
        String open;
        Color color;
        byte Blue, Red, Green;
        String saveBin = Environment.GetEnvironmentVariable("HOMEPATH") + "\\save.bin";
        public Form1()
        {
            InitializeComponent();
            Contenido = txt.Text;
            
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            if (txt.Text != Contenido)
            {
                DialogResult dr = MessageBox.Show("Desea guardar los cambios realizados?", "Guardar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                if (dr == DialogResult.Yes)
                {
                    saveFileDialog1.ShowDialog();
                    path = saveFileDialog1.FileName;
                    StreamWriter sw;
                    try
                    {
                        using (sw = new StreamWriter(path))
                        {
                            sw.WriteLine(txt.Text);
                        }
                        txt.Text = "";
                    }
                    catch (ArgumentException)
                    {

                    }

                }
                else if (dr == DialogResult.No)
                {
                    txt.Text = "";
                }
                else
                {

                }

            }
            else
            {
                txt.Text = "";
            }
        }
        public void openFile(OpenFileDialog op)
        {
            try
            {
                openFileDialog1.ShowDialog();
                open = openFileDialog1.FileName;
                StreamReader sr;
                using (sr = new StreamReader(open))
                {
                    txt.Text = sr.ReadToEnd();
                   
                }
                Contenido = txt.Text;
            }
            catch (FileNotFoundException)
            {

            }
        }
        private void Abrir_Click(object sender, EventArgs e)
        {
            if (txt.Text != Contenido)
            {
                DialogResult dr = MessageBox.Show("Desea guardar los cambios realizados?", "Guardar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                if (dr == DialogResult.Yes)
                {
                    saveFileDialog1.ShowDialog();
                    path = saveFileDialog1.FileName;
                    StreamWriter sw;
                    try
                    {
                        using (sw = new StreamWriter(path))
                        {
                            sw.WriteLine(txt.Text);
                        }
                        openFile(openFileDialog1);
                    }
                    catch (ArgumentException)
                    {

                    }


                }
                else if (dr == DialogResult.No)
                {
                    openFile(openFileDialog1);
                }
                else
                {

                }

            }
            else
            {
                openFile(openFileDialog1);
            }
        }
        public void SaveFile(SaveFileDialog save)
        {
            try
            {
                save.ShowDialog();
                path = save.FileName;
                StreamWriter sw;
                using (sw = new StreamWriter(path))
                {
                    sw.WriteLine(txt.Text);
                }
                Contenido = txt.Text;
            }
            catch (ArgumentException)
            {

            }
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (txt.Text != Contenido)
            {
                SaveFile(saveFileDialog1);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Color aux;//TODO
            
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R && e.Control)
            {
                DialogResult dr = colorDialog1.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    color = colorDialog1.Color;
                    txt.ForeColor = color;
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            Red = color.R;
            Green = color.G;
            Blue = color.B;

            using (FileStream fs = new FileStream(saveBin, FileMode.Create))
            {
                fs.WriteByte(Red);
                fs.WriteByte(Green);
                fs.WriteByte(Blue);
            }
        }
    }
}
