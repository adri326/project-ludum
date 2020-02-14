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
using unoM.Views;

namespace unoM
{
    public partial class View1 : Form
    {
        private Controller1 aController;
        private StartMenu aStartMenu;

        internal Controller1 AController { get => aController; set => aController = value; }

        public View1()
        {
            StartElements();
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void View1_Load(object sender, EventArgs e)
        {
            this.BackColor = PaletteUno.white;
            this.Icon = aController.GetIcon("uno");

            this.Controls.Add(aStartMenu);
        }

        private void StartElements()
        {
            //myHeader = new Header();
            //myHeader.MyView1 = this;

            aStartMenu = new StartMenu();
            aStartMenu.MyView = this;
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
    }
}
