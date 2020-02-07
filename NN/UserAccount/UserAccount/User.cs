using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAccount
{
    class User
    {
        private string userName;
        private string userPassword;
        private string userEmail;

        public string UserPseudo { get => userName; set => userName = value; }
        public string UserPassword { get => userPassword; set => userPassword = value; }
        public string UserEmail { get => userEmail; set => userEmail = value; }

        public User()
        {

        }

        public User(string _userName, string _userPassword, string _userEmail)
        {
            userName = _userName;
            userPassword = _userPassword;
            UserEmail = _userEmail;
        }
    }
}
