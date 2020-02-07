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
    public partial class StartMenu : UserControl
    {
        private View1 myView;
        private Panel LPanel;
        private Label logIn;
        private Panel SPanel;
        private Label sigIn;
        private int x;
        private int y;
        private int tempX;
        private int tempY;

        public View1 MyView { get => myView; set => myView = value; }

        public StartMenu()
        {
            InitializeComponent();
        }

        private void StartMenu_Load(object sender, EventArgs e)
        {
            this.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Size = this.Parent.Size;
            this.Location = new Point(0, 0);
            //this.BackColor = Palette1.brown;

            StartElements();
        }

        private void StartElements()
        {
            x = 600;
            y = 125;
            tempX = (Int32)((this.Width - x) / 2);
            tempY = (this.Height - 2 * y) / 3;
            SetUPLPanel();
            SetUPSPanel();

            tempX = (Int32)(x * 0.2);
            tempY = 0;
            x = (Int32)(x * 0.8);
            y = (Int32)(y * 0.9);
            SetUPLogIn();
            SetUPSignIn();

            x = (Int32)(x / 4);
            tempX = tempY = (Int32)(x * 0.8);
            SetUPLogo(LPanel, "logInLogo");
            SetUPLogo(SPanel, "signInLogo");
        }

        private void SetUPLPanel()
        {
            LPanel = new Panel();
            this.Controls.Add(LPanel);

            LPanel.BackColor = PaletteUno.black;
            LPanel.Size = new Size(x, y);
            LPanel.Location = new Point(tempX, tempY);
        }

        private void SetUPSPanel()
        {
            SPanel = new Panel();
            this.Controls.Add(SPanel);

            SPanel.BackColor = PaletteUno.black;
            SPanel.Size = new Size(x, y);
            SPanel.Location = new Point(tempX, tempY * 2 + y / 2);
        }

        private void SetUPLogIn()
        {
            logIn = new Label();
            LPanel.Controls.Add(logIn);

            logIn.BackColor = PaletteUno.blue;
            logIn.Name = "logIn";
            logIn.Size = new Size(x, y);
            logIn.Location = new Point(tempX, tempY);
            logIn.Text = myView.GetText(logIn.Name);
            logIn.Padding = new Padding((Int32)(x * 0.1), 0, 0, 0);
            logIn.TextAlign = ContentAlignment.MiddleLeft;
        }

        private void SetUPSignIn()
        {
            sigIn = new Label();
            SPanel.Controls.Add(sigIn);
            sigIn.Name = "signIn";
            sigIn.BackColor = PaletteUno.red;
            sigIn.Size = new Size(x, y);
            sigIn.Location = new Point(tempX, tempY);
            sigIn.Text = myView.GetText(sigIn.Name);
            sigIn.Padding = new Padding((Int32)(x * 0.1), 0, 0, 0);
            sigIn.TextAlign = ContentAlignment.MiddleLeft;
        }

        private void SetUPLogo(Panel _element, string name)
        {
            PictureBox logo = new PictureBox();
            _element.Controls.Add(logo);

            logo.BackColor = PaletteUno.green;
            logo.Name = name;
            logo.Size = new Size(x, y);
            logo.Location = new Point(0, 0);
            logo.BackgroundImage = myView.ResizeImage(logo.Name, new Size(tempX, tempY));
            logo.BackgroundImageLayout = ImageLayout.Center;
        }

    }
}
