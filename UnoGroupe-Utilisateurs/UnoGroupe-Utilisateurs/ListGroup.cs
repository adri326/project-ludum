using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnoGroupe_Utilisateurs
{
    public class ListGroup
    {

        List<Group> groups = new List<Group>();

        public void AddGroup(string name, params Friend[] listFriend)
        {
            bool error = false;
            foreach (Group group in groups)
            {
                if (name == group.Name)
                {
                    error = true;
                }
            }
            if (!error) {
                groups.Add(new Group(name, listFriend));
            }
        }
        public void DeleteGroup(int groupRemoved)
        {
            groups.RemoveAt(groupRemoved);
        }

        public List<Group> SeeGroup()
        {
            return groups;
        }
    }
}
