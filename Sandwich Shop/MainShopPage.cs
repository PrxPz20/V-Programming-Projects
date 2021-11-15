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
    public partial class mainShopForm : Form
    {

        private double totalPrice;

        public mainShopForm() {  InitializeComponent(); }


        private void updateTotalPrice() {

            totalPriceLabel.Text = "$ " + totalPrice.ToString();
        }

        private void createBreadTypesCheckBox() {


            CheckBox checkBox = new CheckBox();


        }




    }
}
