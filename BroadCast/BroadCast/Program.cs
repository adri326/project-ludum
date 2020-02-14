//ETML
//Auteur : Noah barberini
//Date : 14.02.20
//Description : permet de recevoir ou d'envoyer un messasge par le broadcast.
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace BroadCast
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//écoute
            Receiver receiver = new Receiver();
            receiver.StartListening();*/

            //envoye un message.
            Sender sender = new Sender();
            sender.Send();
            Console.ReadKey();
        }
    }
    /// <summary>
    /// Permet de recevoir les broadcast.
    /// </summary>
    public class Receiver
    {
        //variable udp sur le port 8080
        private UdpClient udp = new UdpClient(8080);

        /// <summary>
        /// démarre l'écoute.
        /// </summary>
        public void StartListening()
        {
            udp.BeginReceive(Receive, new object());
        }
        private void Receive(IAsyncResult ar)
        {
            IPEndPoint ip = new IPEndPoint(IPAddress.Any, 8080);
            byte[] bytes = udp.EndReceive(ar, ref ip);
            string message = Encoding.ASCII.GetString(bytes);
            Console.WriteLine(message);
            StartListening();
        }
    }
    /// <summary>
    /// Permet d'envoyer un message sur le broadcast.
    /// </summary>
    public class Sender
    {
        /// <summary>
        /// envoye un message sur le broadcast.
        /// </summary>
        public void Send()
        {
            UdpClient client = new UdpClient();
            IPEndPoint ip = new IPEndPoint(IPAddress.Parse("10.228.157.255"), 8080);

            //Message à envoyer.
            byte[] bytes = Encoding.ASCII.GetBytes("Broadcast test.");
            client.Send(bytes, bytes.Length, ip);
            Console.WriteLine("Message sent");
            client.Close();
        }
    }
}
