using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3Networking
{
    class Program
    {
        public static int CountClients=0;
        static void Main(string[] args)
        {
            IPAddress Ipserver=IPAddress.Any;
            int port = 31416;

            IPEndPoint iP = new IPEndPoint(Ipserver,port);
            Socket socket = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);

            socket.Bind(iP);
            socket.Listen(10);
        }
    }
}
