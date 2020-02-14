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
    public partial class VStartMenu : UserControl
    {
        private View1 myView;
        private Button option1;
        private Button option2;

        private int x;
        private int y;
        private int tempX;
        private int tempY;

        public View1 MyView { get => myView; set => myView = value; }

        public VStartMenu()
        {
            InitializeComponent();
        }

        private void StartMenu_Load(object sender, EventArgs e)
        {
            this.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Size = this.Parent.Size;
            this.Location = new Point(0, 0);
            this.BackColor = Palette1.transparent;

            StartElements();
        }

        private void StartElements()
        {
            x = 200;
            y = 80;
            tempX = (Int32)((this.Width - x) / 2);
            tempY = (Int32)((this.Height - y * 2) / 3);
            SetUPLogIn();
            tempY = (Int32)(tempY * 2 + y);
            SetUPSignIn();
        }

        private void SetUPLogIn()
        {
            option1 = new Button();
            this.Controls.Add(option1);

            option1.BackColor = Color.FromArgb(56, 109, 215);
            option1.Cursor = System.Windows.Forms.Cursors.Default;
            option1.FlatAppearance.BorderSize = 0;
            option1.FlatStyle = FlatStyle.Flat;
            option1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            option1.ForeColor = System.Drawing.Color.White;
            option1.Location = new Point(tempX, tempY);
            option1.Name = "option1";
            option1.Size = new Size(x, y);
            option1.TabIndex = 0;
            option1.Text = "Login";
            option1.UseVisualStyleBackColor = false;
            option1.Click += Option1_Click;
        }

        private void SetUPSignIn()
        {
            option2 = new Button();
            this.Controls.Add(option2);

            option2.BackColor = Color.FromArgb(56, 109, 215);
            option2.Cursor = System.Windows.Forms.Cursors.Default;
            option2.FlatAppearance.BorderSize = 0;
            option2.FlatStyle = FlatStyle.Flat;
            option2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            option2.ForeColor = System.Drawing.Color.White;
            option2.Location = new Point(tempX, tempY);
            option2.Name = "option2";
            option2.Size = new Size(x, y);
            option2.TabIndex = 0;
            option2.Text = "Sign in";
            option2.UseVisualStyleBackColor = false;
            option2.Click += Option2_Click;
        }

        private void Option1_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            myView.StartLogin();
        }

        private void Option2_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            myView.StartSignIn(); ;
        }
    }
}
