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

namespace FileEjercicio1
{
    public partial class Form1 : Form
    {
        String system;
        DirectoryInfo f;
        String[] arr;
        bool error = false;
        bool excepts = false;
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            error = false;
            excepts = false;
            listBox1.Items.Clear();
            listBox2.Items.Clear();


            //SwitchDirectory
            if (textBox1.Text.StartsWith("%") && textBox1.Text.EndsWith("%"))//PROPIEDAD ACCEPTBUTTON EN EL FORMULARIO PARA QUE DARLE A ENTER FUNCIONE EL BOTON DE SWITCH CON EL CONTENIDO DE LISTBOX;
            {
                system = Environment.GetEnvironmentVariable((textBox1.Text.Replace("%", " ")).Trim());

            }
            else
            {
                if (Directory.Exists(textBox1.Text))
                {
                    system = textBox1.Text;
                }
                else
                {
                    if (textBox1.Text == "")
                    {

                    }
                    else
                    {
                        excepts = true;
                    }

                }

            }
            try
            {
                f = new DirectoryInfo(system);
                Directory.SetCurrentDirectory(system);
                this.Text = Directory.GetCurrentDirectory();
            }
            catch (ArgumentNullException)
            {
                lblError.Text = "No existe el directorio o la variable de entorno";
                error = true;
            }
            catch (DirectoryNotFoundException)
            {
                lblError.Text = "No existe el directorio o la variable de entorno";
                error = true;
            }
            catch (UnauthorizedAccessException)
            {
                lblError.Text = "Acesso no autorizado";
                listBox1.Items.Add("..");
                error = true;

            }


            if (!error && !excepts)
            {
                //WatchSubDirectorys
                if (listBox1.Items.Count == 0)
                {
                    listBox1.Items.Add("..");
                    try
                    {
                        foreach (DirectoryInfo subD in f.GetDirectories())//solo nombres directorios
                        {
                            listBox1.Items.Add(subD.FullName);
                        }
                    }
                    catch (UnauthorizedAccessException)
                    {
                        lblError.Text = "acesso no autorizado";
                    }
                }
                if (listBox2.Items.Count == 0)
                {
                    try
                    {
                        foreach (FileInfo files in f.GetFiles())
                        {
                            listBox2.Items.Add(files);
                        }
                    }
                    catch (UnauthorizedAccessException)
                    {
                        lblError.Text = "acesso no autorizado";
                    }
                }
            }

            textBox1.Clear();
        }

        private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Path.GetExtension(listBox2.SelectedItem.ToString()) == ".txt")
            {
                Form2 F2 = new Form2(Path.GetFullPath(listBox2.SelectedItem.ToString()));
                F2.ShowDialog();

            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                system = system + "\\..";
                button1_Click(sender, e);
            }
            else
            {
                if (listBox1.SelectedIndex != -1)
                {
                    system = listBox1.SelectedItem.ToString();
                    button1_Click(sender, e);
                }
            }
        }
    }
}
