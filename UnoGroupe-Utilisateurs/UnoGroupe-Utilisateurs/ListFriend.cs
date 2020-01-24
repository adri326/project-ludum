using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnoGroupe_Utilisateurs
{
    public class ListFriend
    {
        

        List<Friend> friends = new List<Friend>();

        public void AddFriend(Friend newFriend)
        {
            friends.Add(newFriend);
        }

        public void DeleteFriend(int indexDeleteFriend)
        {
            friends.RemoveAt(indexDeleteFriend);
        }

        public List<Friend> SeeFriend()
        {
            return friends;
        }

        public Friend SeeFriend(string pseudo)
        {
            foreach (Friend friend in friends)
            {
                if (friend.Pseudo == pseudo)
                {
                    return friend;
                }
            }

            return null;
        }

    }
}
