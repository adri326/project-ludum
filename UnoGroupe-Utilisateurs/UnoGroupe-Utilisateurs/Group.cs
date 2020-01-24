using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnoGroupe_Utilisateurs
{
    public class Group
    {
        List<Friend> groupFriends = new List<Friend>();
        List<DateTime> groupDate = new List<DateTime>();



        const int MIN_PLAYER = 2;
        const int MAX_PLAYER = 7;

        private string name;
        public string Name
        {
            get { return name; }
        }

        public Group(string _name, params Friend[] friends)
        {
            name = _name;
            foreach (Friend friend in friends)
            {
                if (groupFriends.Count < MAX_PLAYER) {
                    groupFriends.Add(friend);
                    groupDate.Add(DateTime.Now);
                }
            }
        }

        public bool AddPlayer(Friend newPlayer)
        {
            if (groupFriends.Count < MAX_PLAYER) {
                groupFriends.Add(newPlayer);
                groupDate.Add(DateTime.Now);
                return true;
            }
            return false;
        }

        public bool DeletePlayer(int indexDeletePlayer)
        {
            if (groupFriends.Count > MIN_PLAYER)
            {
                groupFriends.RemoveAt(indexDeletePlayer);
                groupDate.RemoveAt(indexDeletePlayer);
                return true;
            }
            return false;
        }

        public List<Friend> SeeFriends()
        {
            return groupFriends;
        }
    }
}
