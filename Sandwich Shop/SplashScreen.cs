using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sandwich_Shop
{
    public partial class SplashScreen : Form
    {
        public SplashScreen() { InitializeComponent(); }

        private void screenTimer_Tick(object sender, EventArgs e) { this.Close(); }


    }
}
