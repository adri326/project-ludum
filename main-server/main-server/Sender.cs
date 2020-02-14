using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace main_server
{
    class Sender
    {
        private const int SRVLOCALPORT = 7878;
        /// <summary>
        /// envoye un message sur le broadcast.
        /// </summary>
        public void Send(byte[] bytes)
        {
            UdpClient client = new UdpClient();
            IPEndPoint ip = new IPEndPoint(IPAddress.Parse("10.228.157.255"), SRVLOCALPORT);

            //Message à envoyer.
            client.Send(bytes, bytes.Length, ip);
            Console.WriteLine("\nMessage sent -> UP !");
            client.Close();
        }
    }
}
