using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week3_v2
{
    public partial class Form1 : Form {
        public Form1() { InitializeComponent(); }

        private const double Small_pizza_price = 5.50;
        private const double Medium_pizza_price = 11.75;
        private const double Large_pizza_price = 15.00;
        private const double extra_ingredient = 0.75;

        private void smallRadioButton_MouseHover(object sender, EventArgs e) {toolTip1.Show("up to 2 ingredients for free",smallRadioButton); }

        private void mediumRadioButton_MouseHover(object sender, EventArgs e) {toolTip1.Show("up to 3 ingredients for free", mediumRadioButton); }

        private void LargeRadioButton_MouseHover(object sender, EventArgs e) { toolTip1.Show("up to 4 ingredients for free", smallRadioButton); }

        private void button1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show($"Pizza size: {Small_pizza_price}\n" + "Ingredients: -----","Order Summary", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        }
    } // 

} // END of  week3_v2

/*
 * NOTES:
 *  first param = Message to the user, second param = Window Name, 
 * MessageBox.Show Method (String, String, MessageBoxButtons, MessageBoxIcon)
 */
