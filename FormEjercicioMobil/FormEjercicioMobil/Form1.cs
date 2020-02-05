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

namespace FormEjercicioMobil
{
    public partial class Form1 : Form
    {
        int cont = 0;
        String contraseña = "Jaume";
        String[] valores = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "*", "0", "#" };
        public Button btn;
        int x = 10;
        int y = 30;
        String dato;
        Color color = Color.Aqua;
        bool flag = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            while (cont < 3)
            {
                Form2 f = new Form2();
                DialogResult dr;
                dr = f.ShowDialog();

                switch (dr)
                {
                    case DialogResult.OK:
                        if (f.textBox1.Text == contraseña)
                        {
                            MessageBox.Show("Contraseña Valida", "Buena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cont = 3;
                            flag = true;
                        }
                        else
                        {

                            MessageBox.Show("Contraseña Invalida", "Mal", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


            for (int i = 0; i < valores.GetLength(0); i++)
            {
                btn = new Button();
                btn.Text = valores[i];
                btn.Location = new Point(x, y);
                btn.Size = new Size(100, 20);
                btn.Enabled = true;
                btn.BackColor = default;
                this.btn.Click += new System.EventHandler(ClickBtn);//No memorizar esto, añadir un boton hacer un evento y mirar el designer;
                this.btn.MouseEnter += new System.EventHandler(this.MouseMoveBtn);
                this.btn.MouseLeave += new System.EventHandler(this.MouseLeaveBtn);
                this.Controls.Add(btn);

                x += btn.Size.Width + 10;
                if ((i + 1) % 3 == 0) //cada tres botones cambio el eje y para poner otros tres botones.
                {
                    y += btn.Size.Height + 10;
                    x = 10;
                }
            }



        }
        private void ClickBtn(object sender, EventArgs e)
        {
            dato = ((Button)sender).Text;
            textBox1.Text += dato;

            ((Button)sender).BackColor = color;
        }
        private void MouseMoveBtn(Object sender, EventArgs e)
        {
            if (((Button)sender).BackColor != color)
            {
                ((Button)sender).BackColor = Color.Red;
            }
        }
        private void MouseLeaveBtn(Object sender, EventArgs e)
        {
            if (((Button)sender).BackColor != color)
            {
                ((Button)sender).BackColor = default;//color por defecto de los componentes;
            }

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls) //Cojo todos los elementos de controls, los recorro con foreach y compruebo si es un boton.
            {
                if (c is Button)
                {
                    c.BackColor = default;
                }
            }
            textBox1.Text = "";
        }

        private void GrabarNumeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
           DialogResult r= SaveDialog.ShowDialog();
            String path = SaveDialog.FileName;
            StreamWriter sw;
            try
            {
                using (sw = new StreamWriter(path))
                {
                    sw.WriteLine(textBox1.Text);
                }
            }
            catch (ArgumentException)
            {

            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Cerrar??", "cerrar archivo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
