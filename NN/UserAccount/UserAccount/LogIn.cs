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
    public partial class LogIn : UserControl
    {
        View1 aView1;
        public View1 AView1 { get => aView1; set => aView1 = value; }

        private string mb1Error = "Pseudo and/or password incorret";

        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (aView1.CheckUser(textBox1.Text, textBox2.Text))
            {
                this.Parent.Controls.Remove(this);
                aView1.LogInOK();
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                MessageBox.Show(mb1Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            aView1.RecoverPassword();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            aView1.NewSignUp();
        }
    }
}
