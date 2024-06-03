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
    public partial class MachinegunWin : Form
    {
        public bool create = false;
        public string name;
        public int weight;
        public int capacity;
        public double calibre;
        public int rapidity;

        public MachinegunWin(string name = "AK-74", int weight = 6400, int capacity = 200, double calibre = 7.62, int rapidity = 600)
        {
            InitializeComponent();
            gunName.Text = name;
            gunWeight.Text = weight.ToString();
            gunCapacity.Value = (decimal)capacity;
            gunCalibre.Text = calibre.ToString();
            gunRapidity.Value = (decimal)rapidity;
        }

        private void onSetClick(object sender, EventArgs e)
        {
            create = true;
            name = gunName.Text;
            weight = int.Parse(gunWeight.Text);
            capacity = Math.Abs((int)gunCapacity.Value);
            calibre = Math.Abs(double.Parse(gunCalibre.Text));
            rapidity = Math.Abs((int)gunRapidity.Value);
            Close();
        }

        private void MachinegunWin_Load(object sender, EventArgs e)
        {

        }
    }
}
