using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4Networking
{

    class Program
    {
        static void Main(string[] args)
        {
            String Ip = "127.0.0.1";
            int port = 31416;

            IPEndPoint ipServer=new IPEndPoint(IPAddress.Parse(Ip),port);
            Socket Server = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);

            Server.Bind(ipServer);
            Server.Listen(10);


        }
    }
}
