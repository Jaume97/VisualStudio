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
        String IP = "127.0.0.1",msg;
        int Port = 31416;
        Socket client;
        IPEndPoint ie;
        NetworkStream ns;
        StreamReader sr;
        StreamWriter sw;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
            ie = new IPEndPoint(IPAddress.Parse(IP),Port);
            //client.Connect(ie);
            //lblIP.Text = "IP: " + ie.Address.ToString();
            //lblPort.Text = "Port: " + ie.Port;
            //ns = new NetworkStream(client);
            //sr = new StreamReader(ns);
            //sw = new StreamWriter(ns);
            //msg = sr.ReadToEnd();
            System.Diagnostics.Debug.WriteLine(msg);
        }
    }
}
