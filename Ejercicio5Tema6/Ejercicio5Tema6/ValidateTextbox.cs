using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5Tema6
{
    public partial class ValidateTextbox : Control
    {
        public enum eTipo
        {
            Numerico,
            Textual
        }

        private Color color;
        private eTipo tipo;
        public bool flagNumber = true;
        public bool flagLetter = true;
       
        public ValidateTextbox()
        {
            InitializeComponent();
            color = Color.Red;
            //Comprobacion();
        }

        [Category("MisPropiedades")]
        [Description("Propiedad que cambia el texto del textbox del ValidateTextbox")]
        public String Texto
        {
            set
            {
                textBox1.Text = value;
                this.Refresh();
            }
            get
            {
                return textBox1.Text;
            }
        }

        [Category("MisPropiedades")]
        [Description("Propiedad que pasa el textbox a multilinea")]
        public bool MultiLine
        {
            set
            {
                textBox1.Multiline = value;
            }
            get
            {
                return textBox1.Multiline;
            }
        }
        
        [Category("MisPropiedades")]
        [Description("Propiedad que cambia al contiendo del textBox a numerico o a textual")]
        public eTipo Tipo
        {
            set
            {
                tipo = value;
                this.Refresh();
            }
            get
            {
                return tipo;
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            Comprobacion();
            SolidBrush b = new SolidBrush(color);
            g.DrawRectangle(new Pen(b), 5, 5, this.Width - 10, this.Height - 10);
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            textBox1.Location = new Point(10, 10);
            this.Height = textBox1.Height + 20;
            textBox1.Width = this.Width - 20;
            this.Refresh();
        }
        public void Comprobacion()
        {
            
            flagLetter = true;
            flagNumber = true;
            if (tipo == eTipo.Numerico)
            {
                textBox1.Text = textBox1.Text.Trim();
                foreach (char letra in textBox1.Text)
                {
                    if (!Char.IsDigit(letra))
                    {
                        flagNumber = false;
                    }
                }
                if (flagNumber)
                {
                    color = Color.Green;
                }
                else
                {
                    color = Color.Red;
                }
            }
            else
            {
                foreach (char letra in textBox1.Text)
                {
                    if (!Char.IsLetter(letra) && !Char.IsWhiteSpace(letra))
                    {
                        flagLetter = false;
                    }
                }
                if (flagLetter)
                {
                    color = Color.Green;
                }
                else
                {
                    color = Color.Red;
                }
            }
        //    this.Refresh();
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Comprobacion();
            this.OnTextChanged(e);
        }
    }
}
