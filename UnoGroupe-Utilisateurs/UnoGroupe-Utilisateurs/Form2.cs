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
            firstForm.Hide();
            this.Show();

            foreach (Friend friend in firstForm.friends.SeeFriend())
            {
                lstFriend.Text = friend.Pseudo;
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

        }
    }
}
