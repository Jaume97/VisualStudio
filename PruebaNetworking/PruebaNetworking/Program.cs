using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PruebaNetworking
{
    class Program
    {
        static void ShowNetInformation(string name)
        {
            IPHostEntry hostInfo;
            //Tratamos de resolver el DNS
            hostInfo = Dns.GetHostEntry(name);
            // Mostramos el nombre del equipo
            Console.WriteLine("Name: {0}", hostInfo.HostName);
            //Lista de IPs del equipo
            Console.WriteLine("IP list: ");
            foreach (IPAddress ip in hostInfo.AddressList)
            {
                //Para ver sólo las direcciones IPv4
                //Para IPv6 se usa AddressFamily.InterNetworkV6
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    Console.WriteLine("\t{0,16}", ip);
                }
            }
            Console.WriteLine("\n");
        }
        static void ShowNetInformation(IPAddress ipAddress)
        {
            IPHostEntry hostInfo = Dns.GetHostEntry(ipAddress);
            ShowNetInformation(hostInfo.HostName);
        }

        static void Main(string[] args)
        {
            //IPAddress ip = IPAddress.Loopback;
            //IPEndPoint ie = new IPEndPoint(ip, 1200);
            //Console.WriteLine("IPEndPoint: {0}", ie.ToString());
            //Console.WriteLine("AddressFamily: {0}", ie.AddressFamily);
            //Console.WriteLine("Address: {0}, Puerto: {1}", ie.Address, ie.Port);
            //Console.WriteLine("Ports range: {0}-{1}",
            //IPEndPoint.MinPort, IPEndPoint.MaxPort);
            //ie.Port = 80;
            //ie.Address = IPAddress.Parse("80.1.12.128");
            //Console.WriteLine("New End Point: {0}", ie.ToString());

            IPEndPoint ie = new IPEndPoint(IPAddress.Any, 31416);
            //Creacion del Socket
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //Enlace de socket al puerto (y en cualquier interfaz de red)
            //Salta excepción si el puerto está ocupado
            s.Bind(ie);
            //Esperando una conexión y estableciendo cola de clientes pendientes
            s.Listen(10);
            //Esperamos y aceptamos la conexion del cliente (socket bloqueante)
            Socket sClient = s.Accept();
            //Obtenemos la info del cliente
            //El casting es necesario ya que RemoteEndPoint es del tipo EndPoint
            //mas genérico
            IPEndPoint ieClient = (IPEndPoint)sClient.RemoteEndPoint;
            Console.WriteLine("Client connected:{0} at port {1}", ieClient.Address, ieClient.Port);


            //Preparando End Point del servidor
            //Creación del Stream de Red. Nuevamente puede hacerse con using.
            NetworkStream ns = new NetworkStream(sClient);
            //StreamReader y StreamWriter aceptan un Stream
            //como parámetro en el constructor
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            string welcome = "Welcome to The Echo-Logic, Odd, Desiderable, " +
            "Incredible, and Javaless Echo Server (T.E.L.O.D.I.J.E Server)";
            //El envío por red se convierte en un WriteLine
            sw.WriteLine(welcome);
            //Con flush se fuerza el envío de los datos sin esperar al cierre
            sw.Flush();

            string msg="";
            while (msg!="#bro")
            {
                try
                {
                    //Leemos el mensaje del cliente
                    msg = sr.ReadLine();
                    
                    // Si se cierra el cierra el cliente mientras se espera
                    // en el ReadLine, este devuelve null.
                    Console.WriteLine(msg != null ? msg : "Client disconnected");
                    //Mandamos nuevamente el mensaje al cliente
                    sw.WriteLine(msg);
                    sw.Flush();
                }
                // Si se cierra el cliente, salta excepción
                // Al siguiente readline
                catch (IOException e)
                {
                    break;
                }
            }
            Console.WriteLine("Connection closed");

            //El código del protocolo debe ir antes de esta línea
            //Siempre cerramos los Streams y sockets si no lo hemos hecho con using.
            sw.Close();
            sr.Close();
            ns.Close();
            sClient.Close();
            s.Close();
            Console.ReadKey();
        }
    }
}
