using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using unoM.Controllers;
using unoM.Models;
using unoM.Views;

namespace unoM
{
    public partial class View1 : Form
    {
        private Controller1 aController;
        private VStartMenu aVStartMenu;
        private VLogin aVLogin;
        private VSignIn aVSignIn;
        private VRemindPassword aVRemindPassword;
        private VMenu aVMenu;
        internal User currentUser;

        internal Controller1 AController { get => aController; set => aController = value; }

        public View1()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        internal bool MatchPseudo(string text)
        {
            return aController.MatchPseudo(text);
        }

        internal bool MatchPassword(string text)
        {
            return aController.MatchPassword(text);
        }

        internal void CreateUser(string _pseudo, string _password, string _email)
        {
            aController.CreateUser(_pseudo, _password, _email);
        }

        private void View1_Load(object sender, EventArgs e)
        {
            this.Icon = aController.GetIcon("uno");
            this.BackgroundImage = aController.GetImage("uno1");

            StartStartMenu();
        }        

        public void StartStartMenu()
        {
            aVRemindPassword = null;
            aVStartMenu = new VStartMenu();
            aVStartMenu.MyView = this;
            this.Controls.Add(aVStartMenu);
        }        

        public void StartLogin()
        {
            aVStartMenu = null;
            aVLogin = new VLogin();
            aVLogin.MyView = this;
            this.Controls.Add(aVLogin);
        }

        public void StartSignIn()
        {
            aVStartMenu = null;
            aVSignIn = new VSignIn();
            aVSignIn.MyView = this;
            this.Controls.Add(aVSignIn);
        }

        internal void StartRemindPassword()
        {
            aVLogin = null;
            aVRemindPassword = new VRemindPassword();
            aVRemindPassword.MyView = this;
            this.Controls.Add(aVRemindPassword);
        }

        internal void LogInOK()
        {
            currentUser = aController.GetCurrentUser();
            aVMenu = new VMenu();
            aVMenu.MyView = this;
            this.Controls.Add(aVMenu);
        }

        public Image GetImage(string _id)
        {
            return aController.GetImage(_id);
        }

        public Image ResizeImage(string _id, Size _size)
        {
            return aController.ResizeImage(_id, _size);
        }

        public string GetText(string _id)
        {
            return aController.GetText(_id);
        }

        public bool CheckUser(string _pseudo, string _password)
        {
            return aController.CheckUser(_pseudo, _password);
        }

        internal bool MatchEmail(string text)
        {
            return aController.MatchEmail(text);
        }

        internal bool CheckEmail(string text)
        {
            return aController.CheckEmail(text);
        }

        internal string SendPassword(string text)
        {
            return aController.SendPassword(text);
        }
    }
}
