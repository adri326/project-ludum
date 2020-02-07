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
            //affichage des textes selons la langue choisie
            ChangeLanguage("FR");

           
           
            
        }
       private void ChangeLanguage(string langue)
        {
            //change la langue //
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
            button1.Text = rm.GetString("Multiplayer");
            button2.Text = rm.GetString("SinglePlayer");
            button3.Text = rm.GetString("GameHistory");
            button4.Text = rm.GetString("Friends");
            button6.Text = rm.GetString("Help");
            button7.Text = rm.GetString("Exit");
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
