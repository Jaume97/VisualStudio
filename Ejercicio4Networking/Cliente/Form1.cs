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
        String IP = "127.0.0.1", msg;
        int Port = 31416, minutos = 0, segundos = 0;
        Socket client;
        IPEndPoint ie;
        NetworkStream ns;
        StreamReader sr;
        StreamWriter sw;
        bool connected = false;//RECORDAR HABILITAR EL BTN CUANDO PIERDA O GANE
        public Form1()
        {
            InitializeComponent();
            lblTimer.Text =String.Format("{0:D2}:{1:D2}",minutos,segundos);
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            connected = !connected;
            if (connected)
            {
                client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                client.Connect(ie);
                ns = new NetworkStream(client);
                sr = new StreamReader(ns);
                sw = new StreamWriter(ns);
                btnConnect.Text = "Disconnect";
                btnConnect.Enabled = false;
                msg = sr.ReadLine();
                //System.Diagnostics.Debug.WriteLine("msg: "+msg);
                timer1.Start();
            }
            else
            {
                sw?.Close();
                sr?.Close();
                ns?.Close();
                client?.Close();
                btnConnect.Text = "Connect";
            }
            System.Diagnostics.Debug.WriteLine("Conectado?: "+client.Connected);
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            segundos++;
            if (segundos==59)
            {
                minutos++;
                segundos = 0;
            }
            lblTimer.Text = String.Format("{0:D2}:{1:D2}", minutos, segundos);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ie = new IPEndPoint(IPAddress.Parse(IP), Port);
            lblIP.Text = "IP: " + ie.Address.ToString();
            lblPort.Text = "Port: " + ie.Port;
        }
    }
}
