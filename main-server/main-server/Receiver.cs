using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace main_server
{
    public class Receiver
    {
        private const int MYPORT = 7877;
        private const int SRVLOCALPORT = 7878;
        private  byte[] SRVLOCALUP = {5}; 
        //variable udp sur le port 8080
        private UdpClient udp = new UdpClient(SRVLOCALPORT);

        /// <summary>
        /// démarre l'écoute.
        /// </summary>
        public void StartListening()
        {
            udp.BeginReceive(Receive, new object());
        }
        private void Receive(IAsyncResult ar)
        {
            IPEndPoint ip = new IPEndPoint(IPAddress.Any, MYPORT);
            byte[] bytes = udp.EndReceive(ar, ref ip);
            Console.Write("\nTrame : ");
            foreach(Byte b in bytes)
            {
                Console.Write(b);
            }
            string message = Encoding.ASCII.GetString(bytes);
            if(message == Encoding.ASCII.GetString(SRVLOCALUP))
            {
                Sender sender = new Sender();
                sender.Send(new byte[] {6});
            }
            StartListening();
        }
    }
}
