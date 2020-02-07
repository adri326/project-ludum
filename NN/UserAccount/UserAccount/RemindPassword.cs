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

namespace UserAccount
{
    public partial class RemindPassword : UserControl
    {
        private View1 aView1;

        public View1 AView1 { get => aView1; set => aView1 = value; }

        public RemindPassword()
        {
            InitializeComponent();
        }

        private void RemindPassword_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Model.MatchEmail(textBox1.Text))
            {
                MessageBox.Show("Wrong email format");
                textBox1.BackColor = Color.Yellow;
            }
            else
            {
                if (!aView1.CheckEmail(textBox1.Text))
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
                        mail.Body = $"Your password is {aView1.SendPassword()}";

                        client.Port = 587;
                        client.UseDefaultCredentials = false;
                        client.Credentials = new System.Net.NetworkCredential("unoetml1920@outlook.com", ".Etml-1920");
                        client.EnableSsl = true;

                        client.Send(mail);
                        MessageBox.Show("mail Send");
                        this.Parent.Controls.Remove(this);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }


        }
    }
}
