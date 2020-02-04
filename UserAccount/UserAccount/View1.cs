using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserAccount
{
    public partial class View1 : Form
    {
        private Model aModel;
        private LogIn aLogIn;
        private SesionSettings aSesionSettings;
        private RemindPassword aRemindPassword;
        private SingUp aSingUp;
        internal User currentUser;

        public View1(Model _aModel)
        {
            aModel = _aModel;
            aModel.CreateUser("test", "samy.ibriz@eduvaud.ch", "1234");

            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            aLogIn = new LogIn();
            aLogIn.AView1 = this;
            this.Controls.Add(aLogIn);
        }

        internal void UpdateUser(string text1, string text2, string text3)
        {
            aModel.UpdateUser(text1, text2, text3);
        }

        internal void RecoverPassword()
        {
            aRemindPassword = new RemindPassword();
            aRemindPassword.AView1 = this;
            this.Controls.Add(aRemindPassword);
        }

        public bool CheckUser(string _pseudo, string _password)
        {
            return aModel.CheckUser(_pseudo, _password);
        }

        internal void StartLogIn()
        {
            this.Controls.Add(aLogIn);
        }

        public bool CheckEmail(string _email)
        {
            return aModel.CheckEmail(_email);
        }

        public void LogInOK()
        {
            currentUser = aModel.GetCurrentUser();
            aSesionSettings = new SesionSettings();
            aSesionSettings.AView1 = this;
            this.Controls.Add(aSesionSettings);
        }

        internal string SendPassword()
        {
            currentUser = aModel.GetCurrentUser();
            return currentUser.UserPassword;
        }

        internal void NewSignUp()
        {
            aSingUp = new SingUp();
            aSingUp.AView1 = this;
            this.Controls.Add(aSingUp);
        }

        internal void CreateUser(string _pseudo, string _email, string _password)
        {
            aModel.CreateUser(_pseudo, _email, _password);
        }
    }
}
