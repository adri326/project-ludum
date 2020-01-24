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

            friends.AddFriend(new Friend("Jeremy"));
            friends.AddFriend(new Friend("Ethonoz"));
            friends.AddFriend(new Friend("Boris"));
            friends.AddFriend(new Friend("Arthur"));
            friends.AddFriend(new Friend("Théo"));
            friends.AddFriend(new Friend("Dieudone"));

            groups.AddGroup("mesAmisAMoi",friends.SeeFriend("Arthur"),friends.SeeFriend("Boris") );
            groups.AddGroup("PasMesAmis",friends.SeeFriend("Théo"),friends.SeeFriend("Jeremy"),friends.SeeFriend("Ethonoz"));



        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstFriends.Items.Clear();
            lstGroups.Items.Clear();
            foreach (Friend friend in friends.SeeFriend())
            {
                lstFriends.Items.Add(friend.Pseudo);
            }

            foreach (Group group in groups.SeeGroup())
            {
                lstGroups.Items.Add(group.Name);
            }
        }

        private void lstGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstFriendsOfGroup.Items.Clear();

            foreach (Friend friend in groups.SeeGroup()[lstGroups.SelectedIndex].SeeFriends())
            {
                lstFriendsOfGroup.Items.Add(friend.Pseudo);
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
    }
}
