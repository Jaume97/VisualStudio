using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio3Networking
{
    class Program
    {
        public static int cont = 10;
        public static int CountClients=0;
        public static List<StreamWriter> lista= new List<StreamWriter>();
        public static List<int> nums = new List<int>();
        public static Random random= new Random();
        private static readonly object l = new object();
        private static readonly object j = new object();//no se si hace falta crear otro teestigo distinto
        public static bool flag = true,game=true;
        public static StreamWriter sw;

        public static void Timer()
        {

        }
        public static void FunctionClient(Object client)
        {
            //int num = random.Next(1,21);
            //int max=0;
            CountClients++;
            Socket host = (Socket)client;
            IPEndPoint ieClient = (IPEndPoint)host.RemoteEndPoint;
            Console.WriteLine("User conected IP: {0} port: {1}", ieClient.Address, ieClient.Port);
            using (NetworkStream ns = new NetworkStream(host))
            using (StreamReader sr = new StreamReader(ns))
            using (sw = new StreamWriter(ns))
            {
                lista.Add(sw);
                while (true)
                {

                }
                //    while (flag)
                //    {
                //        lock (l)
                //        {
                //            lista.Add(sw);
                //            sw.WriteLine("Tu numero es el: " + num);
                //            sw.Flush();
                //            nums.Add(num);
                //            if (CountClients >= 2)
                //            {
                //                Monitor.PulseAll(l);

                //                Thread time = new Thread(() =>
                //                {
                //                    while (timer)
                //                    {
                //                        lock (l)
                //                        {
                //                            if (cont != 0)
                //                            {

                //                                for (int i = 0; i < lista.Count; i++)
                //                                {
                //                                    lista[i].WriteLine("Time to start: " + cont);
                //                                    lista[i].Flush();
                //                                }
                //                                cont--;    

                //                            }
                //                            else
                //                            {
                //                                timer = false;
                //                            }
                //                        }
                //                        Thread.Sleep(1000);
                //                    }
                //                });
                //                time.Start();
                //                for (int i = 0; i < nums.Count; i++)
                //                {
                //                    if (max < nums.ElementAt(i))
                //                    {
                //                        max = nums.ElementAt(i);
                //                    }
                //                }
                //                if (num == max)
                //                {
                //                    sw.WriteLine("You won whit your numbre: " + num);
                //                    for (int i = 0; i < lista.Count; i++)
                //                    {
                //                        if (sw != lista.ElementAt(i))
                //                        {
                //                            lista.ElementAt(i).WriteLine("El numero ganador fue el: " + num);
                //                        }
                //                    }
                //                }
                //                flag = false;
                //            }
                //            else
                //            {
                //                sw.WriteLine("Esperando a uno o varios rivales...");
                //                sw.Flush();
                //                Monitor.Wait(l);
                //            }


            }
        }

        static void Main(string[] args)
        {
            IPAddress Ipserver=IPAddress.Any;
            int port = 31416;

            IPEndPoint iP = new IPEndPoint(Ipserver,port);
            Socket socket = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);

            socket.Bind(iP);
            socket.Listen(10);

            while (true)
            {
                Socket client = socket.Accept();
                Thread hilo=new Thread(FunctionClient);
                hilo.Start(client);//hilo clientes y juego

            }
            socket.Close();
        }
    }
}
