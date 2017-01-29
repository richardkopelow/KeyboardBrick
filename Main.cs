using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyboardBrick
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            birdTimer.Interval = 5000;
            birdTimer.Enabled = true;

        }

        private void birdTimer_Tick(object sender, EventArgs e)
        {
            SendKeys.Send("k");
            birdTimer.Enabled = false;
        }
    }
}
