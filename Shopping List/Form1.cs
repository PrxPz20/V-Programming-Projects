using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_List
{
    public partial class Form1 : Form
    {
        public Form1() { InitializeComponent(); }

        private void addButton_Click(object sender, EventArgs e) {

            string item = null;

            if ((String.IsNullOrEmpty(nameTextBox.Text)) || (String.IsNullOrEmpty(quantityTextBox.Text)))
                MessageBox.Show("Name or Quantity is empty " + nameTextBox.Text);
            else {
                //if( Convert.ToInt32(quantityTextBox.Text) < 1)


                MessageBox.Show($"Item name: {nameTextBox.Text}\nQuantity: {quantityTextBox.Text}");
                item += "" + nameTextBox.Text +"        "+ quantityTextBox.Text;
                todoListBox.Items.Add(item);
            }




        }


    }
}
