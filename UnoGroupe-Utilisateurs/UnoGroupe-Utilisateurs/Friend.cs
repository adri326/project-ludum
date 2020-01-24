using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnoGroupe_Utilisateurs
{
    public class Friend
    {
        private string pseudo;
        public string Pseudo   // property
        {
            get { return pseudo; }   // get method
            set { pseudo = value; }  // set method
        }

        private DateTime date;
        public DateTime Date
        {
            get { return date; }
        }

        public Friend(string _pseudo)
        {
            pseudo = _pseudo;
            date = DateTime.Now;
        }

    }
}
