using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserAccount
{
    public class Model
    {
        private List<User> users;
        private int currentUserIndex;

        private const string pseudoPattern = @"^[A-Za-zÀ-ÖØ-öø-ÿ0-9][A-Za-z\sÀ-ÖØ-öø-ÿ0-9]{1,29}$";
        private const string passwordPattern = @"^.{4,20}$";
        private const string emailPattern = @"[A-Za-z\.]{2,20}@[A-Za-z0-9]{2,50}.[A-Za-z]{2,10}$";

        public Model()
        {
            users = new List<User>();
        }

        static public bool MatchPseudo(string _pseudo)
        {
            return Regex.IsMatch(_pseudo, pseudoPattern);
        }

        static public bool MatchPassword(string _password)
        {
            return Regex.IsMatch(_password, passwordPattern);
        }

        static public bool MatchEmail(string _email)
        {
            return Regex.IsMatch(_email, emailPattern);
        }

        public void CreateUser(string _pseudo, string _email, string _password)
        {
            users.Add(new User(_pseudo, _password, _email));
        }

        public bool CheckUser(string _pseudo, string _password)
        {
            bool result = false;
            for (int i = 0; i < users.Count; ++i)
            {
                if (users[i].UserPseudo == _pseudo && users[i].UserPassword == _password)
                {
                    currentUserIndex = i;
                    return true;
                }
                else
                    result = false;
            }
            return result;
        }

        public bool CheckEmail(string _email)
        {
            bool result = false;
            for (int i = 0; i < users.Count; ++i)
            {
                if (users[i].UserEmail == _email)
                {
                    currentUserIndex = i;
                    return true;
                }
                else
                    result = false;
            }
            return result;
        }

        internal User GetCurrentUser()
        {
            return users[currentUserIndex];
        }

        public void UpdateUser(string _userName, string _userEmail, string _userPassword)
        {
            users[currentUserIndex].UserPseudo = _userName;
            users[currentUserIndex].UserEmail = _userEmail;
            users[currentUserIndex].UserPassword = _userPassword;
        }
    }
}
