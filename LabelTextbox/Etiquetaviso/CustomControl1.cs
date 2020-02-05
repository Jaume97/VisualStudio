using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etiquetaviso
{

    public enum eMarca
    {
        Nada,
        Cruz,
        Circulo,
        Imagen
    }
    [
        DefaultEvent("ClickEnMarca"),
        DefaultProperty("Gradient")
    ]
    public partial class CustomControl1 : Control
    {
        private eMarca marca = eMarca.Circulo;
        private bool gradient;
        int offsetX = 0;
        int offsetY = 0;
        int grosor = 0;
        [Category("FOO")]
        [Description("True si quieres gradiente False sino quieres gradiente")]
        public bool Gradient
        {
            set
            {
                gradient = value;
                this.Refresh();
            }
            get
            {
                return gradient;
            }
        }
        [Category("FOO")]
        [Description("Marca de la etiqueta")]
        public eMarca Marca
        {
            set
            {
                marca = value;
                this.Refresh();
            }
            get { return marca; }
        }        private Image imagenMarca;
        [Category("FOO")]
        [Description("Imagen de la etiqueta")]        public Image ImagenMarca
        {
            set
            {
                imagenMarca = value;
            }
            get
            {
                return imagenMarca;
            }
        }        [Category("MisEventos")]
        [Description("Cuando haces click en la marca")]        public event System.EventHandler ClickEnMarca;
        public CustomControl1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            

            ////Traslación
            //g.TranslateTransform(100, 100);
            //g.DrawLine(Pens.Red, 0, 0, 100, 0);
            //g.ResetTransform();
            ////Rotación de 30º en sentido horario
            //g.RotateTransform(30);
            //g.DrawLine(Pens.Blue, 0, 0, 100, 0);
            //g.ResetTransform();
            ////Traslación + rotación
            //g.TranslateTransform(100, 100);
            //g.RotateTransform(30);
            //g.DrawLine(Pens.Green, 0, 0, 100, 0);
            //g.ResetTransform();


            
                             //Esta propiedad provoca mejoras en la apariencia o en la eficiencia
                             // a la hora de dibujar
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //Dependiendo del valor de la propiedad marca dibujamos una
            //Cruz o un Círculo
            
            switch (Marca)
            {
                case eMarca.Circulo:
                    grosor = 20;
                    g.DrawEllipse(new Pen(Color.Green, grosor), grosor, grosor,
                   this.Font.Height, this.Font.Height);
                    offsetX = this.Font.Height + grosor;
                    offsetY = grosor;
                    break;
                case eMarca.Cruz:
                    grosor = 5;
                    Pen lapiz = new Pen(Color.Red, grosor);
                    g.DrawLine(lapiz, grosor, grosor, this.Font.Height,
                   this.Font.Height);
                    g.DrawLine(lapiz, this.Font.Height, grosor, grosor,
                   this.Font.Height);
                    offsetX = this.Font.Height + grosor;
                    offsetY = grosor / 2;
                    //Es recomendable liberar recursos de dibujo pues se
                    //pueden realizar muchos y cogen memoria
                    lapiz.Dispose();
                    break;
                case eMarca.Imagen:
                    if (imagenMarca!=null)
                    {
                        g.DrawImage(ImagenMarca,0,0,this.Font.Height,this.Font.Height);
                        offsetX = this.Font.Height + grosor;
                    }
                    
                    break;
            }
            //Finalmente pintamos el Texto; desplazado si fuera necesario
            if (gradient)
            {
                LinearGradientBrush lgb = new LinearGradientBrush(new Point(0,0),new Point(this.Size.Width,this.Size.Width),Color.Red,Color.White);
                g.FillRectangle(lgb,new Rectangle(0,0,this.Size.Width,this.Size.Height));
                
            }
            SolidBrush b = new SolidBrush(this.ForeColor);
            g.DrawString(this.Text, this.Font, b, offsetX + grosor, offsetY);
            Size tam = g.MeasureString(this.Text, this.Font).ToSize();
            this.Size = new Size(tam.Width + offsetX + grosor, tam.Height + offsetY * 2);
            b.Dispose();
        }
        protected override void OnMouseClick(MouseEventArgs e)
        {
            if (marca!=eMarca.Nada)
            {
                base.OnMouseClick(e);
                int x = e.X;
                int y = e.Y;
                if (marca==eMarca.Circulo)
                {
                    if ((x >= 0 && x <= this.Font.Height+grosor*2) && (y >= 0 && y <= this.Font.Height+grosor*2))
                    {
                        System.Diagnostics.Debug.WriteLine("X:" + x + "y:" + y);
                    }
                }
                else
                {
                    if (marca==eMarca.Imagen)
                    {
                        if ((x>=0 && x<=this.Font.Height) && (y>=0 && y<=this.Font.Height))
                        {
                            System.Diagnostics.Debug.WriteLine("X:"+x+"y:"+y);
                        }
                    }
                    else
                    {
                        if ((x >= 0 && x <= this.Font.Height + grosor) && (y >= 0 && y <= this.Font.Height))
                        {
                            System.Diagnostics.Debug.WriteLine("X:" + x + "y:" + y);
                        }
                    }
                   
                }
                
               
            }
        }
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            this.Refresh();
        }
        
    }
}
