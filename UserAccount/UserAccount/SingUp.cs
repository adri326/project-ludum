using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserAccount
{
    public partial class SingUp : UserControl
    {
        private View1 aView1;

        public View1 AView1 { get => aView1; set => aView1 = value; }

        public SingUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Model.MatchPseudo(textBox1.Text))
                textBox1.BackColor = Color.Red;
            else
                textBox1.BackColor = Color.Green;
            if (!Model.MatchEmail(textBox2.Text))
                textBox2.BackColor = Color.Red;
            else
                textBox2.BackColor = Color.Green;
            if (!Model.MatchPassword(textBox3.Text))
                textBox3.BackColor = Color.Red;
            else
                textBox3.BackColor = Color.Green;
            if (Model.MatchPseudo(textBox1.Text) && Model.MatchEmail(textBox2.Text) && Model.MatchPassword(textBox3.Text))
            {
                aView1.CreateUser(textBox1.Text, textBox2.Text, textBox3.Text);
                this.Parent.Controls.Remove(this);
                aView1.StartLogIn();
            }
        }

        private void SingUp_Load(object sender, EventArgs e)
        {

        }
    }
}
