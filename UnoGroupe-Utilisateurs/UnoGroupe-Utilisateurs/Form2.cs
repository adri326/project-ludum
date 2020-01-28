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
    public partial class Form2 : Form
    {
        public Form1 firstForm;

        List<Friend> listFriend = new List<Friend>();
        List<Friend> listFriendInGroup = new List<Friend>();

        public Form2()
        {
            InitializeComponent();
        }

        public void Start()
        {
            txtName.Text = "";
            listFriend.Clear();
            listFriendInGroup.Clear();

            lstFriend.Items.Clear();
            lstAddFriend.Items.Clear();

            firstForm.Hide();
            this.Show();

            foreach (Friend friend in firstForm.friends.SeeFriend())
            {
                lstFriend.Items.Add(friend.Pseudo);
                listFriend.Add(friend);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            firstForm.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Friend[] arrayTransition = new Friend[listFriendInGroup.Count];

            for (int i = 0; i < arrayTransition.Length; i++)
            {
                arrayTransition[i] = listFriendInGroup[i];
            }

            if (txtName.Text != "" && listFriendInGroup.Count >= 2)
            {
                firstForm.groups.AddGroup(txtName.Text,arrayTransition);
                firstForm.Show();
                this.Hide();
            }

            
        }

        private void lstFriend_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFriend.SelectedIndex != -1) {
                listFriendInGroup.Add(listFriend[lstFriend.SelectedIndex]);
                lstAddFriend.Items.Add(lstFriend.SelectedItem);
                listFriend.RemoveAt(lstFriend.SelectedIndex);
                lstFriend.Items.RemoveAt(lstFriend.SelectedIndex);
            }
        }

        private void lstAddFriend_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAddFriend.SelectedIndex != -1)
            {
                listFriend.Add(listFriendInGroup[lstAddFriend.SelectedIndex]);
                lstFriend.Items.Add(lstAddFriend.SelectedItem);
                listFriendInGroup.RemoveAt(lstFriend.SelectedIndex);
                lstAddFriend.Items.RemoveAt(lstAddFriend.SelectedIndex);
            }
        }
    }
}
