using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio4Networking
{

    class Program
    {
        static String Ip = "127.0.0.1", msg;
        static Random r = new Random();
        static Socket Server = null, client;
        static IPEndPoint ipServer, IpClient;
        static int port = 31416;
        static bool PortValid = false, condition = true;
        static FileInfo f = new FileInfo(Environment.GetEnvironmentVariable("USERPROFILE") + "/Palabras.txt");
        static StreamReader srPalabras = new StreamReader(f.FullName);//CERRAR ESTE SR
        static String[] palabras = srPalabras.ReadToEnd().Split(',');
        public static void FunctionThread(Object client)
        {
            Socket SocketClient = (Socket)client;
            msg = palabras[r.Next(0, palabras.Length)];
            IpClient = (IPEndPoint)SocketClient.RemoteEndPoint;

            using (NetworkStream ns = new NetworkStream(SocketClient))
            using (StreamReader sr = new StreamReader(ns))
            using (StreamWriter sw = new StreamWriter(ns))
            {
                sw.WriteLine(msg);
                sw.Flush();
            }
        }
        static void Main(string[] args)
        {
            while (!PortValid)
            {
                ipServer = new IPEndPoint(IPAddress.Parse(Ip), port);
                Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    Server.Bind(ipServer);
                    Server.Listen(10);
                    PortValid = true;
                }
                catch (SocketException)
                {
                    port++;
                }
            }

            while (condition)
            {
                client = Server.Accept();
                Thread hilo = new Thread(FunctionThread);
                hilo.Start(client);
            }

            srPalabras.Close();
            Console.ReadKey();
        }
    }
}
