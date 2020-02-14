using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using unoM.Controllers;
using unoM.Models;

namespace unoM
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

            // Creation of View, Model and Controller
            Model1 myModel = new Model1();
            View1 myView = new View1();
            Controller1 myController = new Controller1(myModel, myView);

            Application.Run(myView);
        }
    }
}
