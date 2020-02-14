using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace main_server
{
    class Program
    {
        private static Thread listen = new Thread(Listen);
        static void Main(string[] args)
        {
            listen.Start();
            Console.ReadKey();
        }
        private static void Listen()
        {
            Console.WriteLine("Listening to broadcast...");
            Receiver receiver = new Receiver();
            receiver.StartListening();
        }
    }
}
