using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Networking
{
    class Program
    {
        //PRUEBA PARA HIT
        static void Main(string[] args)
        {
            IPAddress ipServer;
            int port;
            Socket socket;
            Socket sClient;
            DateTime Hora=DateTime.Now;
            bool condition=true;

            IPEndPoint iPEndPoint=new IPEndPoint(IPAddress.Any,135);
            //Paso 1:Creamos el socket
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //Enlace del socket al puerto
            try
            {
                socket.Bind(iPEndPoint);
                socket.Listen(10);
            }
            catch (SocketException)
            {
                System.Diagnostics.Debug.WriteLine("Error de socket");
            }
            //Cola de clientes pendientes
            
            

            

            //AQUI DEBE ESTAR TODA LA CONVERSACION CON EL CLIENTE.
            string msg;
            while (condition)
            {
                //Aceptamos la conexion al cliente
                sClient = socket.Accept();
                //Info cliente
                IPEndPoint ieClient = (IPEndPoint)sClient.RemoteEndPoint;
                Console.WriteLine("Client connected:{0} at port {1}", ieClient.Address, ieClient.Port);
                //Creación del Stream de Red
                NetworkStream ns = new NetworkStream(sClient);
                //StreamReader y StreamWriter aceptan un Stream.
                StreamReader sr = new StreamReader(ns);
                StreamWriter sw = new StreamWriter(ns);
                string welcome = "Welcome to the Exercise 1";
                //Enviar un mensaje se hace con un writeLine
                sw.WriteLine(welcome);
                //Forzar el envio de los datos, RECOMENDABLE.
                sw.Flush();

                try
                {
                    msg = sr.ReadLine();

                    if (msg != null)
                    {
                        switch (msg)
                        {
                            case "HORA":
                                sw.WriteLine("Hora: {0} Minutos: {1} Segundos {2}",Hora.Hour,Hora.Minute,Hora.Second);
                                break;
                            case "FECHA":
                                sw.WriteLine("Dia: {0} Mes: {1} Año: {2}",Hora.Day,Hora.Month,Hora.Year);
                                break;
                            case "TODO":
                                sw.WriteLine("Dia: {0} Mes: {1} Año: {2} Hora: {3} Minutos: {4} Segundos {5} "
                                    , Hora.Day, Hora.Month, Hora.Year,Hora.Hour,Hora.Minute,Hora.Second);
                                break;
                            case "APAGAR": condition = false;
                                break;
                            default:
                                sw.WriteLine("Not command value");
                                break;
                                
                        }
                    }
                    else
                    {
                        Console.WriteLine("Connection closed");
                        
                    }
                    sw.Flush();
                }
                catch (IOException)
                {
                    
                }
                
            sw.Close();
            sr.Close();
            ns.Close();
            sClient.Close();
            Console.WriteLine("Client disconnected");
           
            }
            condition = true;
            socket.Close();
            Console.WriteLine("Server OFF");
            Console.ReadLine();
        }
    }
}
