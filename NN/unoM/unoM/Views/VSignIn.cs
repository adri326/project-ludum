using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using unoM.Controllers;

namespace unoM.Views
{
    public partial class VSignIn : UserControl
    {
        //Variables
        private View1 myView;

        // Properties
        public View1 MyView { get => myView; set => myView = value; }

        public VSignIn()
        {
            InitializeComponent();
        }

        private void VSignIn_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.BackColor = Palette1.transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!myView.MatchPseudo(textBox1.Text))
                textBox1.BackColor = Color.Red;
            else
                textBox1.BackColor = Color.Green;
            if (!myView.MatchPassword(textBox2.Text))
                textBox2.BackColor = Color.Red;
            else
                textBox2.BackColor = Color.Green;
            if (!myView.MatchEmail(textBox3.Text))
                textBox3.BackColor = Color.Red;
            else
                textBox3.BackColor = Color.Green;
            if (myView.MatchPseudo(textBox1.Text) && myView.MatchPassword(textBox2.Text) && myView.MatchEmail(textBox3.Text))
            {
                myView.CreateUser(textBox1.Text, textBox2.Text, textBox3.Text);
                this.Parent.Controls.Remove(this);
                myView.StartStartMenu();
            }
        }

        private void btnFrench_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEnglish_Click(object sender, EventArgs e)
        {

        }
    }
}
