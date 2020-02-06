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
        public static int CountClients=0;
        public static List<StreamWriter> lista= new List<StreamWriter>();
        public static List<int> nums = new List<int>();
        public static Random random= new Random();
        public static void FunctionClient(Object client)
        {
            int num = random.Next(1,21);
            int max=0;
            CountClients++;
            Socket host = (Socket)client;
            IPEndPoint ieClient=(IPEndPoint)host.RemoteEndPoint;
            Console.WriteLine("User conected IP: {0} port: {1}",ieClient.Address,ieClient.Port);
            using (NetworkStream ns = new NetworkStream(host))
            using (StreamReader sr = new StreamReader(ns))
            using (StreamWriter sw = new StreamWriter(ns))
            {
                if (CountClients >= 2)//El jugador uno sigue en espera mientras que el segundo ya ganó.
                {
                    lista.Add(sw);
                    sw.WriteLine("Tu numero es el: "+num);
                    sw.Flush();
                    nums.Add(num);

                    for (int i = 0; i < nums.Count; i++)
                    {
                        if (max<nums.ElementAt(i))
                        {
                            max = nums.ElementAt(i);
                        }
                    }
                    if (num==max)
                    {
                        sw.WriteLine("You won whit your numbre: "+num);
                        for (int i = 0; i < lista.Count; i++)
                        {
                            if (sw!=lista.ElementAt(i))
                            {
                                lista.ElementAt(i).WriteLine("El numero ganador fue el: "+num);
                            }
                        }
                    }

                }
                else
                {
                    sw.WriteLine("Esperando a uno o varios rivales...");
                    sw.Flush();
                }
            }
               
        }
        public static void Timer()
        {

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
                hilo.Start(client);
            }
        }
    }
}
