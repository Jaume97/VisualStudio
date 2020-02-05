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
    
    public partial class Form2 : Form
    {
        String file;
        public Form2(String path)
        {
            InitializeComponent();
            file = path;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            StreamReader sr;
            if (File.Exists(file))
            {
                try
                {
                    using (sr = new StreamReader(file))
                    {
                        textBox1.Text = sr.ReadToEnd();
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    this.Close();
                    
                }
            }
        }
    }
}
