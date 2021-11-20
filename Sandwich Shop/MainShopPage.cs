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

        SandwichBread Bread = new SandwichBread();
        SandwichIngredients Ingredients = new SandwichIngredients();
        Settings Settings = new Settings();


        public mainShopForm() {  InitializeComponent(); }


        private void updateTotalPrice() {

            totalPriceLabel.Text = "$ " + totalPrice.ToString();
        }

        private void createBreadTypesCheckBox(string name, string text) {

            CheckBox checkBox = new CheckBox();
            RadioButton radioButton = new RadioButton();

            checkBox.Name = name;
            checkBox.AutoSize = true;

        }

        private void createIngredientTypesCheckBox(string name, string text) {

        }

        private void settingsStripMenuItem_Click(object sender, EventArgs e) {

            
            Settings.ShowDialog();
        }
    }
}
