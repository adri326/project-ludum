using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unoM.Views
{
    public partial class VLogin : UserControl
    {
        //Variables
        private View1 myView;
        private string mb1Error = "Pseudo and/or password incorret";

        // Properties
        public View1 MyView { get => myView; set => myView = value; }

        public VLogin()
        {
            InitializeComponent();
        }

        private void VLogin_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.BackColor = Palette1.transparent;

            label3.MouseEnter += Label3_MouseEnter;
            label3.MouseHover += Label3_MouseEnter;
            label3.MouseLeave += Label3_MouseLeave;
            label3.Click += Label3_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (myView.CheckUser(textBox1.Text, textBox2.Text))
            {
                this.Parent.Controls.Remove(this);
                myView.LogInOK();
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                MessageBox.Show(mb1Error);
            }
        }

        private void Label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
        }

        private void Label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.White;
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            myView.StartRemindPassword();
        }
    }
}
