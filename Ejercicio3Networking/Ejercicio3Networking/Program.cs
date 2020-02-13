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
        public static int cont = 10, max = 0, winner;
        public static int CountClients = 0;
        public static List<StreamWriter> lista = new List<StreamWriter>();
        public static List<int> nums = new List<int>();
        public static Random random = new Random();
        private static readonly object l = new object();
        public static bool flag = true, game = false;


        public static void Game()
        {
            game = true;
            while (flag)
            {
                Console.WriteLine($"Clientes en Game: {CountClients}");
                if (CountClients >= 2)
                {
                    if (CountClients == 2)//este if lo pongo porque si no haria un pulse al wait del timer. 
                    {
                        lock (l)
                        {
                            Monitor.PulseAll(l);
                        }
                    }
                    Thread temp = new Thread(Timer);
                    temp.Start();
                    lock (l)
                    {
                        Monitor.Wait(l);
                    }
                    for (int i = 0; i < nums.Count; i++)
                    {
                        if (max < nums[i])
                        {
                            max = nums[i];
                            winner = i;//Posicion donde esta guardado el numero mas alto y equivalente a la posicion de la lista de sw
                        }
                    }
                    lock (l)
                    {
                        for (int i = 0; i < lista.Count; i++)
                        {
                            if (i == winner)
                            {
                                lista[i].WriteLine("You win whit your number " + nums[i]);
                            }
                            else
                            {
                                lista[i].WriteLine("The oponent win whit the number " + nums[winner]);

                            }
                            System.Diagnostics.Debug.WriteLine("CountSr: "+lista.Count);
                            System.Diagnostics.Debug.WriteLine("Countnums: " + nums.Count);    
                            lista[i].Flush();
                        }
                    }

                    Console.WriteLine("Aquí");
                    flag = false;

                }

            }
        }
        public static void Timer()
        {
            Console.WriteLine("En timer");
            while (cont != 0)
            {
                Console.WriteLine("En bucle del timer");
                lock (l)
                {
                    Console.WriteLine(cont + " " + flag);
                    if (cont != 0 && flag)
                    {

                        for (int i = 0; i < lista.Count; i++)
                        {
                            try
                            {
                                lista[i].WriteLine("Game started in " + cont);
                                lista[i].Flush();
                            }
                            catch (IOException)
                            {
                                lista.RemoveAt(i);
                                nums.RemoveAt(i);
                            }
                        }

                        cont--;
                    }
                }
                Thread.Sleep(1000);
            }
            lock (l)
            {
                Monitor.PulseAll(l);
            }
        }
        public static void FunctionClient(Object client)
        {
            int num = random.Next(1, 21);
            nums.Add(num);

            Socket host = (Socket)client;
            IPEndPoint ieClient = (IPEndPoint)host.RemoteEndPoint;
            Console.WriteLine("User conected IP: {0} port: {1}", ieClient.Address, ieClient.Port);
            using (NetworkStream ns = new NetworkStream(host))
            using (StreamReader sr = new StreamReader(ns))
            using (StreamWriter sw = new StreamWriter(ns))
            {
                lock (l)
                {
                    lista.Add(sw);
                }
                sw.WriteLine("Your number is: " + num);
                sw.Flush();
                if (CountClients < 2)
                {
                    sw.WriteLine("Waiting for oponents");
                    sw.Flush();
                    lock (l)
                    {
                        Monitor.Wait(l);
                    }

                }
                while (flag)
                {

                }
            }
        }

        static void Main(string[] args)
        {
            IPAddress Ipserver = IPAddress.Any;
            int port = 31416;

            IPEndPoint iP = new IPEndPoint(Ipserver, port);
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            socket.Bind(iP);
            socket.Listen(10);

            while (flag)
            {
                Socket client = socket.Accept();
                Thread hilo = new Thread(FunctionClient);
                hilo.Start(client);//hilo clientes y juego
                CountClients++;
                if (CountClients >= 2 && !game) //RECORDAR VER SI LANZO DOS HILOS AL MISMO TIEMPO
                {
                    Console.WriteLine("efdsefs");
                    Thread game = new Thread(Game);
                    game.Start();
                }
            }
            socket.Close();
            lista.Clear();
            nums.Clear();
            Console.WriteLine("Cerrao");
        }
    }
}
