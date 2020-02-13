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
        static String Ip = "127.0.0.1", msg,comand;
        static Random r = new Random();
        static Socket Server = null, client;
        static IPEndPoint ipServer, IpClient;
        static int port = 31416;
        static bool PortValid = false, condition = true;
        static FileInfo f = new FileInfo(Environment.GetEnvironmentVariable("USERPROFILE") + "/Palabras.txt"),
            records= new FileInfo(Environment.GetEnvironmentVariable("USERPROFILE") + "/Records.txt");
        static StreamWriter swPalabras = new StreamWriter(f.FullName),swRecords= new StreamWriter(records.FullName);
        static StreamReader srPalabras = new StreamReader(f.FullName),srRecords= new StreamReader(records.FullName);//CERRAR ESTE SR
        static String[] palabras = srPalabras.ReadToEnd().Split(','),ComandSplit;
        public static void FunctionThread(Object client)
        {
            System.Diagnostics.Debug.WriteLine("Estoi dentro de functclient");
            Socket SocketClient = (Socket)client;
            IpClient = (IPEndPoint)SocketClient.RemoteEndPoint;

            using (NetworkStream ns = new NetworkStream(SocketClient))
            using (StreamReader sr = new StreamReader(ns))
            using (StreamWriter sw = new StreamWriter(ns))
            {
                while (condition)
                {
                    comand = sr.ReadLine();
                    ComandSplit = comand.Split(' ');
                    if (ComandSplit[0]=="getword")
                    {
                        msg = palabras[r.Next(0, palabras.Length)];
                        sw.WriteLine(msg);
                        sw.Flush();
                    }
                    else if (ComandSplit[0] == "sendword")
                    {
                        swPalabras.Write(","+ComandSplit[1]);
                    }
                    else if (ComandSplit[0] == "getrecords")
                    {
                        sw.WriteLine(srRecords.ReadToEnd());
                    }
                    else if (ComandSplit[0]=="closeserver")
                    {

                    }
                }
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
