using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cardClass
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Deck dck = new Deck();

            foreach(Card c in dck.Cards)
            {
                Console.WriteLine(string.Join(", ", c));
            }







            Application.Run(new CardDisplay());
        }
    }
}
