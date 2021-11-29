using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PizzaApplication
{
    public partial class AddressForm : Form
    {
        public AddressForm() { InitializeComponent(); }

        public string userLocationAddress = null;

        private void setaddressButton_Click(object sender, EventArgs e) {

            if (locationadressTextBox.Text.Equals(""))
                MessageBox.Show($"Location is not valid", "Location Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else{
                userLocationAddress = locationadressTextBox.Text;
                this.Close();
            }
        }

    }
}
