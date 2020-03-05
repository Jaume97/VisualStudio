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

namespace FormPrueba
{
    public partial class Form2 : Form
    {
        public bool FileExist;
        public Form2()
        {
            InitializeComponent();
            FileExist = false;
        }

        private void BtnImage_Click(object sender, EventArgs e)
        {
            lblImageAviso.Text = "";
            txtImage.Text = "";
            if (openFileDialog1.ShowDialog()==DialogResult.OK) {
                FileInfo f = new FileInfo(openFileDialog1.FileName);
                if (f.Exists && f.Extension==".jpg")
                {
                    txtImage.Text = f.FullName;

                }
                else
                {
                    lblImageAviso.Text = "No has escogido una foto jpg";
                }
            }
            
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            String[] vs = {"Manga","SciFi","RPG","Fantasia","Terror","Tecnologia"};
            comboBox1.Items.AddRange(vs);
            comboBox1.SelectedIndex = 0;
        }

        private void BtnAcept_Click(object sender, EventArgs e)
        {
            FileInfo fileInfo = new FileInfo(txtImage.Text);
            if (fileInfo.Exists && fileInfo.Extension==".jpg")
            {
                FileExist = true;
            }
        }
    }
}
