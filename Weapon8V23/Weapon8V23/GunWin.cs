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
    public partial class GunWin : Form
    {
        public bool create = false;
        public string name;
        public int weight;
        public int capacity;
        public double calibre;

        public GunWin(string name = "AK-47", int weight = 4300, int capacity = 30, double calibre = 5.45d)
        {
            InitializeComponent();
            gunName.Text = gunName.Text;
            gunWeight.Text = weight.ToString();
            gunCapacity.Value = (decimal)capacity;
            gunCalibre.Text = calibre.ToString();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void onBtnSet(object sender, EventArgs e)
        {
            create = true;
            name = gunName.Text;
            weight = Math.Abs(int.Parse(gunWeight.Text));
            capacity = Math.Abs((int)gunCapacity.Value);
            calibre = Math.Abs(double.Parse(gunCalibre.Text));
            Close();
        }

        private void GunWin_Load(object sender, EventArgs e)
        {

        }
    }
}
