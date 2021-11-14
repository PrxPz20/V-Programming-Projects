using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Concentration_Game
{
    public partial class MainPage : Form
    {

        About About = new About();


        public MainPage() { InitializeComponent(); }

        private void aboutStripMenuItem_Click(object sender, EventArgs e) { About.ShowDialog(); }




    } // END OF MainPage Class
}
