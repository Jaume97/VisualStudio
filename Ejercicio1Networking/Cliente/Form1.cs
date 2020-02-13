using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Form1 : Form
    {
        String IPserver="127.0.0.1";
        int port = 136;
        String msg;
        NetworkStream ns;
        StreamReader sr;
        StreamWriter sw;
        Socket server;
        IPEndPoint ie;
        bool flag = true;
        public Form1()
        {
            InitializeComponent();
        }
        private void CerrarConexiones()
        {
            try
            {
                sw?.Close();
                sr?.Close();
                ns?.Close();
                server?.Close();
            }
            catch (Exception)
            {
                //dasda
            }
            
        }
        private void comando(String text)
        {
            
                try
                {
                    
                    server = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);//cada vez que se desconecta del servidor hay que volver a crear el socket.
                    server.Connect(ie);
                    ns = new NetworkStream(server);
                    sr = new StreamReader(ns);
                    sw = new StreamWriter(ns);
                    this.Text = sr.ReadLine();
                    sw.WriteLine(text);
                    sw.Flush();
                    lbl.Text = sr.ReadLine();
                    
                }
                catch (SocketException e)
                {
                    lbl.Text = "socket error";
                }

          
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Portlbl.Text =""+port;
            IPlbl.Text = IPserver;
            ie =new IPEndPoint(IPAddress.Parse(IPserver),port);

            //try
            //{
            //    server.Connect(ie);
            //}
            //catch (SocketException)
            //{
            //    System.Diagnostics.Debug.WriteLine("Error de conexion");
            //}

            
        }

        private void HORA_Click(object sender, EventArgs e)
        {
            comando(HORA.Text);
            CerrarConexiones();
        }

        private void FECHA_Click(object sender, EventArgs e)
        {

            comando(FECHA.Text);
            CerrarConexiones();
        }

        private void TODO_Click(object sender, EventArgs e)
        {
            comando(TODO.Text);
            CerrarConexiones();
        }

        private void APAGAR_Click(object sender, EventArgs e)
        {
            comando(APAGAR.Text);
            CerrarConexiones();
        }

        private void ConfigurationIP_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.txtIP.Text = IPserver;
            f2.txtPort.Text = ""+port;
            while (flag)
            {
                if (f2.ShowDialog()==DialogResult.OK) {
                    try
                    {

                        IPserver = f2.txtIP.Text;
                        port = Convert.ToInt32(f2.txtPort.Text);
                        IPlbl.Text = IPserver;
                        Portlbl.Text =""+port;
                        try
                        {
                            ie = new IPEndPoint(IPAddress.Parse(IPserver), port);
                            flag = false;
                        }
                        catch (SocketException)
                        {
                            System.Diagnostics.Debug.WriteLine("Conection error");
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            lbl.Text = "Out of range";
                        }
                    }
                    catch (FormatException)
                    {
                        lbl.Text = "Invalid arguments";
                    }
                    catch (OverflowException)
                    {
                        lbl.Text = "Overflow range port";
                    }
                }
            }
            lbl.Text = "";
            flag = true;
        }
    }
}
