using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weapon8V23
{
    public partial class ChooseWin : Form
    {
        public string result;

        public ChooseWin()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void onCreateGun(object sender, EventArgs e)
        {
            result = "Gun";
            Close();
        }

        private void onCreateMachinegun(object sender, EventArgs e)
        {
            result = "Machinegun";
            Close();
        }

        private void onCreateBlade(object sender, EventArgs e)
        {
            result = "Blade";
            Close();
        }

        private void ChooseWin_Load(object sender, EventArgs e)
        {

        }
    }
}
