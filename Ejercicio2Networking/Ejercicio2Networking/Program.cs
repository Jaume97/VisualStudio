using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio2Networking
{
    class Program
    {
        public static List<StreamWriter> writers = new List<StreamWriter>();
        public static List<String> users = new List<String>();
        public static readonly object l = new object();
        public static bool PortValid = false;
        public static void FuncionCliente(Object socket)
        {
            String message;
            bool flag = true;
            String user;
            Socket client = (Socket)socket;
            IPEndPoint ieClient = (IPEndPoint)client.RemoteEndPoint;
            Console.WriteLine("Connected whit client {0} at port {1}", ieClient.Address, ieClient.Port);

            using (NetworkStream ns = new NetworkStream(client))
            using (StreamReader sr = new StreamReader(ns))
            using (StreamWriter sw = new StreamWriter(ns))
            {
                sw.WriteLine("Welcome to this chat,Give your user");
                sw.Flush();
                user = sr.ReadLine();
                sw.WriteLine("You can start to chat " + user);
                sw.Flush();

                lock (l)
                {
                    writers.Add(sw);
                    users.Add(user);
                    if (writers.Count != 1)
                    {
                        for (int i = 0; i < writers.Count; i++)
                        {
                            if (writers.ElementAt(i) != sw)
                            {
                                writers.ElementAt(i).WriteLine("{0}@{1}: {2}", user, ieClient.Address, "POWER ON");
                                writers.ElementAt(i).Flush();
                            }

                        }
                    }
                }

                //!=1 porque no tiene sentido enviar en mensaje de conexion al propio conectado.


                while (flag)
                {
                    try
                    {
                        message = sr.ReadLine();
                        lock (l)
                        {
                            if (message != null && message != "salir" && message != "lista")
                            {
                                for (int i = 0; i < writers.Count; i++)
                                {
                                    if (writers.ElementAt(i) != sw)
                                    {
                                        writers.ElementAt(i).WriteLine("{0}@{1}: {2}", user, ieClient.Address, message);
                                        writers.ElementAt(i).Flush();
                                    }

                                }
                            }
                            else
                            {
                                if (message == "salir")
                                {
                                    flag = false;
                                }
                                else
                                {
                                    sw.WriteLine("users connected");
                                    for (int i = 0; i < users.Count; i++)
                                    {

                                        sw.WriteLine("{0}:{1}", i, users.ElementAt(i));
                                        sw.Flush();
                                    }
                                }
                            }
                        }

                    }
                    catch (IOException)
                    {
                        break;
                    }
                }
                lock (l)
                {
                    writers.Remove(sw);
                    users.Remove(user);
                    for (int i = 0; i < writers.Count; i++)
                    {
                        if (writers.ElementAt(i) != sw)
                        {
                            writers.ElementAt(i).WriteLine("{0}@{1}: {2}", user, ieClient.Address, "POWER OFF");
                            writers.ElementAt(i).Flush();
                        }

                    }
                }

            }
            client.Close();

        }

        static void Main(string[] args)
        {
            String Ip = "127.0.0.1";
            int port = 31416;
            Socket socket;

            IPEndPoint point = new IPEndPoint(IPAddress.Any, port);
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            while (!PortValid)//RECORDAR SIEMPRE LA COMPROBACION DE PUERTO OCUPADO
            {
                try
                {
                    socket.Bind(point);
                    socket.Listen(10);
                    PortValid = true;
                }
                catch (SocketException)
                {
                    port++;
                }
            }

            while (true)
            {
                Socket cliente = socket.Accept();
                Thread hilo = new Thread(FuncionCliente);
                hilo.Start(cliente);
            }
        }
    }
}
