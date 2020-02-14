using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnoGroupe_Utilisateurs
{
    public partial class Form1 : Form
    {

        public ListGroup groups = new ListGroup();
        public ListFriend friends = new ListFriend();
        Form2 secondForm;

        public Form1(Form2 _secondForm)
        {
            InitializeComponent();

            secondForm = _secondForm;
            secondForm.firstForm = this;

            friends.AddFriend(new Friend("ami1"));
            friends.AddFriend(new Friend("ami2"));
            friends.AddFriend(new Friend("ami3"));
            friends.AddFriend(new Friend("ami4"));
            friends.AddFriend(new Friend("ami5"));
            friends.AddFriend(new Friend("ami6"));

            groups.AddGroup("group1",friends.SeeFriend("ami1"),friends.SeeFriend("ami2") );
            groups.AddGroup("group2",friends.SeeFriend("ami3"),friends.SeeFriend("ami4"),friends.SeeFriend("ami1"));
            

        }

        

        private void lstGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstFriendsOfGroup.Items.Clear();
            if (lstGroups.SelectedIndex != -1) {
                foreach (Friend friend in groups.SeeGroup()[lstGroups.SelectedIndex].SeeFriends())
                {
                    lstFriendsOfGroup.Items.Add(friend.Pseudo);
                }
            }
        }

        private void btnAddFriend_Click(object sender, EventArgs e)
        {
            
            if (txtFriend.Text != "") {
                friends.AddFriend(new Friend(txtFriend.Text));
            }
            lstFriends.Items.Clear();
            foreach (Friend friend in friends.SeeFriend())
            {
                lstFriends.Items.Add(friend.Pseudo);
            }
            txtFriend.Text = "";
        }

        private void btnDelFriend_Click(object sender, EventArgs e)
        {
            if (lstFriends.SelectedIndex != -1) {
                friends.DeleteFriend(lstFriends.SelectedIndex);
            }
            lstFriends.Items.Clear();
            foreach (Friend friend in friends.SeeFriend())
            {
                lstFriends.Items.Add(friend.Pseudo);
            }
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            secondForm.Start();
        }

        private void btnDelGroup_Click(object sender, EventArgs e)
        {
            if (lstGroups.SelectedIndex != -1)
            {
                groups.DeleteGroup(lstGroups.SelectedIndex);
            }
            lstFriendsOfGroup.Items.Clear();
            lstGroups.Items.Clear();
            foreach (Group group in groups.SeeGroup())
            {
                lstGroups.Items.Add(group.Name);
            }
        }
        private void btnAddFriendInGroup_Click(object sender, EventArgs e)
        {
            if (lstFriends.SelectedIndex != -1 && lstGroups.SelectedIndex != -1) {
                groups.SeeGroup()[lstGroups.SelectedIndex].AddPlayer(friends.SeeFriend()[lstFriends.SelectedIndex]);
            }
            lstFriendsOfGroup.Items.Clear();
            foreach (Friend friend in groups.SeeGroup()[lstGroups.SelectedIndex].SeeFriends())
            {
                lstFriendsOfGroup.Items.Add(friend.Pseudo);
            }
        }

        private void btnDelFriendInGroup_Click(object sender, EventArgs e)
        {
            if (lstFriendsOfGroup.SelectedIndex != -1 && lstGroups.SelectedIndex != -1)
            {
                groups.SeeGroup()[lstGroups.SelectedIndex].DeletePlayer(lstFriendsOfGroup.SelectedIndex);
            }
            lstFriendsOfGroup.Items.Clear();
            foreach (Friend friend in groups.SeeGroup()[lstGroups.SelectedIndex].SeeFriends())
            {
                lstFriendsOfGroup.Items.Add(friend.Pseudo);
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            lstFriends.Items.Clear();
            lstGroups.Items.Clear();
            lstFriendsOfGroup.Items.Clear();
            foreach (Friend friend in friends.SeeFriend())
            {
                lstFriends.Items.Add(friend.Pseudo);
            }

            foreach (Group group in groups.SeeGroup())
            {
                lstGroups.Items.Add(group.Name);
            }
        }
    }
}
