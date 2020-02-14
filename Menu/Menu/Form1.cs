using Menu.Resources;
using System;
using System.Resources;
using System.Windows.Forms;
namespace Menu
{
    public partial class Form1 : Form
    {
        //definis que la valeurs de base dur rm seront en FR//
        ResourceManager rm = new ResourceManager(typeof(FR));
        public Form1()
        {
            InitializeComponent();
            //affichage des textes selon la langue choisie
            ChangeLanguage("FR");
        }
        /// <summary> 
        /// change le texte des boutons selon la langue choisie 
        /// </summary>
        /// <param name="langue">langue choisie (soit FR ou EN)</param>
        private void ChangeLanguage(string langue)
        {

            switch (langue)
            {
                case "FR":
                    rm = new ResourceManager(typeof(FR));
                    break;
                case "EN":
                    rm = new ResourceManager(typeof(EN));
                    break;
                default:
                    break;
            }
            

            //boutons concernés par le changement de langue//
            btnMutiplayer.Text = rm.GetString("Multiplayer");
            btnSingleplayer.Text = rm.GetString("SinglePlayer");
            btnGameHistory.Text = rm.GetString("GameHistory");
            btnFriends.Text = rm.GetString("Friends");
            btnHelp.Text = rm.GetString("Help");
            btnExit.Text = rm.GetString("Exit");
        }


        private void option_Click(object sender, EventArgs e)
        {
            Panel option = new Panel();
        }

        private void btnFrench_Click(object sender, EventArgs e)
        {
            ChangeLanguage("FR");
        }

        private void btnEnglish_Click(object sender, EventArgs e)
        {
            ChangeLanguage("EN");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
