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
    public partial class VMenu : UserControl
    {
        private View1 myView;
        public View1 MyView { get => myView; set => myView = value; }

        public VMenu()
        {
            InitializeComponent();
        }

        private void VMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
