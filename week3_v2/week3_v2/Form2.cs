using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace week3_v2
{
    public partial class Form2 : Form
    {
        public Form2() { InitializeComponent(); }

        public string userLocationAddress = null;

        private void setaddressButton_Click(object sender, EventArgs e) {

            userLocationAddress = locationadressTextBox.Text;
            this.Close();
        }

    }
}
