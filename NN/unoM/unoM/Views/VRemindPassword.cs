using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace unoM.Views
{
    public partial class VRemindPassword : UserControl
    {
        private View1 myView;

        public View1 MyView { get => myView; set => myView = value; }

        public VRemindPassword()
        {
            InitializeComponent();
        }

        private void VRemindPassword_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.BackColor = Palette1.transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!myView.MatchEmail(textBox1.Text))
            {
                MessageBox.Show("Wrong email format");
                textBox1.BackColor = Color.Yellow;
            }
            else
            {
                if (!myView.CheckEmail(textBox1.Text))
                {
                    MessageBox.Show("Not users with this email");
                    textBox1.BackColor = Color.Red;
                }
                else
                {
                    textBox1.BackColor = Color.Green;
                    try
                    {
                        MailMessage mail = new MailMessage();
                        SmtpClient client = new SmtpClient("smtp.office365.com");

                        mail.From = new MailAddress("unoetml1920@outlook.com");
                        mail.To.Add(textBox1.Text);
                        mail.Subject = "Password reminder - UNO";
                        mail.Body = $"Your password is {myView.SendPassword(textBox1.Text)}";

                        client.Port = 587;
                        client.UseDefaultCredentials = false;
                        client.Credentials = new System.Net.NetworkCredential("unoetml1920@outlook.com", ".Etml-1920");
                        client.EnableSsl = true;

                        client.Send(mail);
                        MessageBox.Show("mail Send");
                        this.Parent.Controls.Remove(this);
                        myView.StartStartMenu();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error");
                    }
                }
            }
        }
    }
}
