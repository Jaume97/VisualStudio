using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelTextbox
{
    public enum ePosicion
    {
        IZQUIERDA, DERECHA
    }
    [
        DefaultProperty("Posicion"),
        DefaultEvent("CambiaPosicion")
    ]
    public partial class LabelTexto : UserControl
    {

        public LabelTexto()
        {
            InitializeComponent();
            TextLbl = Name;
            TextTxt = "";
            //recolocar();
        }
        

        [Category("La propiedad cambió")]
        [Description("Se lanza cuando la propiedad Posición cambia")]
        public event System.EventHandler CambiaPosicion;

        //Posicion
        private ePosicion posicion = ePosicion.IZQUIERDA;
        [Category("FOO")]
        [Description("Indica si la Label se sitúa a la IZQUIERDA o DERECHA del Textbox")]
        public ePosicion Posicion
        {
            set
            {
                if (Enum.IsDefined(typeof(ePosicion), value))
                {
                    posicion = value;
                    //recolocar();
                    this.Refresh();
                    if (CambiaPosicion != null)
                        CambiaPosicion(this, new EventArgs());


                }
                else
                {
                    throw new InvalidEnumArgumentException();
                }
            }
            get
            {
                return posicion;
            }
        }
        //Separacion
        [Category("La propiedad cambió")]
        [Description("Se lanza cuando la propiedad Separacion cambia")]
        public event System.EventHandler CambiarSeparacion;
        private int separacion = 0;
        [Category("FOO")]
        [Description("Píxels de separación entre Label y Textbox")]
        public int Separacion
        {
            set
            {
                if (value >= 0)
                {
                    separacion = value;
                    //recolocar();
                    this.Refresh();
                    if (CambiarSeparacion!=null)
                    {
                        CambiarSeparacion(this,new EventArgs());
                    }
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            get
            {
                return separacion;
            }
        }

        [Category("FOO")]
        [Description("Texto asociado a la Label del control")]
        public string TextLbl
        {
            set
            {
                lbl.Text = value;
                //recolocar();
            }
            get
            {
                return lbl.Text;
            }
        }

        [Category("FOO")]
        [Description("Texto asociado al TextBox del control")]
        public string TextTxt
        {
            set
            {
                txt.Text = value;
            }
            get
            {
                return txt.Text;
            }
        }
        [Category("La propiedad cambió")]
        [Description("Cuando se escribe algo dentro del textbox")]
        public event System.EventHandler TxtChanged;
        private void recolocar()
        {
            switch (posicion)
            {
                case ePosicion.DERECHA:
                    //Establecemos posición del componente txt
                    txt.Location = new Point(0, 0);
                    //Establecemos ancho del Textbox (la label tiene ancho fijo)
                    txt.Width = this.Width - lbl.Width - Separacion;
                    //Establecemos posición del componente lbl
                    lbl.Location = new Point(txt.Width + Separacion, 0);
                    //Establecemos altura del componente
                    this.Height = Math.Max(txt.Height, lbl.Height);
                    break;
                case ePosicion.IZQUIERDA:
                    lbl.Location = new Point(0, 0);
                    txt.Location = new Point(lbl.Width + Separacion, 0);
                    txt.Width = this.Width - lbl.Width - Separacion;
                    this.Height = Math.Max(txt.Height, lbl.Height);
                    break;
            }
        }
       
        [Category("FOO")]
        [Description("Char para el password")]
        public char Pswchar
        {
            set
            {
                txt.PasswordChar = value;
            }
            get
            {
                return txt.PasswordChar;
            }
        }
        private void Txt_KeyUp(object sender, KeyEventArgs e)
        {
            this.OnKeyUp(e);
        }

        private void Txt_TextChanged(object sender, EventArgs e)
        {
            TxtChanged?.Invoke(sender,e);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            recolocar();
            e.Graphics.DrawLine(new Pen(Color.Violet),
             lbl.Left, this.Height - 1,
             lbl.Left + lbl.Width, this.Height - 1);
        }
    }
}
