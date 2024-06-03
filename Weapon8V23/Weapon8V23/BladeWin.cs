using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Weapon8V23
{
    public partial class BladeWin : Form
    {
        public bool create = false;
        public string name;
        public int weight;
        public int length;
        public int handCount;

        public BladeWin(string name = "Knife", int weight = 490, int length = 250, int handCount = 1)
        {
            InitializeComponent();
            bladeName.Text = name;
            bladeWeight.Text = weight.ToString();
            bladeLength.Text = length.ToString();
            bladeHandCount.Text = handCount.ToString();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void onSetClick(object sender, EventArgs e)
        {
            create = true;
            name = bladeName.Text;
            weight = Math.Abs(int.Parse(bladeWeight.Text));
            length = Math.Abs((int)bladeLength.Value);
            handCount = Math.Abs((int)bladeHandCount.Value);
            Close();
        }

        private void BladeWin_Load(object sender, EventArgs e)
        {

        }
    }
}
