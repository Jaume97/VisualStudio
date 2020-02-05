using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3Tema6
{
    public partial class Reproductor : UserControl
    {
       
        public Image Play = Resource1.play;//new Bitmap(Environment.GetEnvironmentVariable("USERPROFILE")+"\\Desktop\\play.png");
        public Image Pause = Resource1.pause;//new Bitmap(Environment.GetEnvironmentVariable("USERPROFILE") + "\\Desktop\\pause.png");
        private int minutos=0,segundos=0;
        public Reproductor()
        {
            InitializeComponent();
            Play = Resource1.play;
            ImagenBtn = Play;
            System.Diagnostics.Debug.WriteLine($" { btn.Image.Equals(Play)} ");

        }

        [Category("Mis propiedades")]
        [Description("Propiedad que establece la imagen del Boton")]
        public Image ImagenBtn
        {
            set
            {
                btn.Image = value;
            }
            get
            {
                return btn.Image;
            }
        }
        [Category("Mis propiedades")]
        [Description("Minutos que el reproductor lleva en funcionamiento")]
        public int Minutos
        {
            set
            {
                if (value>99)
                {
                    minutos = 0;
                }
                else
                {
                    minutos = value;
                }
                lbl.Text=String.Format("{0,2:D2} : {1,2:D2}",minutos,segundos);
            }
            get
            {
                return minutos;
            }
        }
        [Category("Mis propiedades")]
        [Description("Segundos que el reproductor lleva en funcionamiento")]
        public int Segundos
        {
            set
            {
                if (value>59)
                {
                    segundos = value % 60;
                    if (DesbordaTiempo!=null)
                    {
                        DesbordaTiempo(this,new EventArgs());
                    }
                }
                else
                {
                    segundos = value;
                }
                lbl.Text= String.Format("{0,2:D2} : {1,2:D2}", minutos, segundos); 
            }
            get
            {
                return segundos;
            }
        }
        [Category("Mis Eventos")]
        [Description("Evento que reproduce la lista de imagenes")]
        public event System.EventHandler Reproducir;

        [Category("Mis Eventos")]
        [Description("Evento que actualiza los minutos")]
        public event System.EventHandler DesbordaTiempo;

        private void Btn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($" {ImagenBtn.Equals(Play)}  Generado evento del button");
            if (ImagenBtn.Equals(Play))
            {
                ImagenBtn = Pause;
            }
            else
            {
                ImagenBtn = Play;
            }
            if (Reproducir != null)
            {
                Reproducir(this, new EventArgs());
            }

        }

        private void Reproductor_Load(object sender, EventArgs e)
        {
            ImagenBtn = Play;
            System.Diagnostics.Debug.WriteLine($"Load {btn.Image.Equals(Play)} ");
        }
    }
}
