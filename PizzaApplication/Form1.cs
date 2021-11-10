using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaApplication
{
    public partial class Form1 : Form {

        private int freeIngredients = 0;    // this variable, will get it value down at the < sizeRadioButton_CheckedChanged > fuction
        private double totalPizzaPrice = 0;
        private string saveUsersIngredients = null; // This variable will save and display all the ingredients that the user selected
        private DateTime UserDeliveryTime;

        private PizzaSize PizzaSize = new PizzaSize();

        public Form1()
       {
            InitializeComponent();
        }

        private void orderButton_Click(object sender, EventArgs e) {

            AddressForm addressForm = new AddressForm();
            addressForm.ShowDialog();

            DialogResult dialogResult = MessageBox.Show($"Pizza Size: {PizzaSize.smallPizzaPrice}" +
                Environment.NewLine + Environment.NewLine + $"Ingredients: {saveUsersIngredients}" +
                Environment.NewLine + Environment.NewLine + $"Location Address: {addressForm.userLocationAddress}" +
                Environment.NewLine + Environment.NewLine + $"Delivery Time:  {UserDeliveryTime.ToShortTimeString() }" +
                Environment.NewLine + Environment.NewLine + $"Total Amount: {totalPizzaPrice} ",
                "Order Summary", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
                this.Close();
        }

        // This Fuction prints the total pizza price
        private void updatePizzaPrice() { totalPriceLabel.Text = $"€ {totalPizzaPrice}"; }

        private void sizeRadioButton_CheckedChanged(object sender, EventArgs e) {

            totalPriceLabel.Visible = true;
            var sizeSelected = (sender as RadioButton).Name;
            testLabel.Text = sizeSelected;

            // Small: up to 2 ingredients for free
            if (sizeSelected == "smallRadioButton")
            {
                freeIngredients = 2;
                totalPizzaPrice = PizzaSize.smallPizzaPrice;
            }
            // Medium: up to 3 ingredients for free
            else if (sizeSelected == "mediumRadioButton")
            {
                freeIngredients = 3;
                totalPizzaPrice = PizzaSize.mediumPizzaPrice;
            }
            // Large: up to 4 ingredients for free
            else
            {
                freeIngredients = 4;
                totalPizzaPrice = PizzaSize.largePizzaPrice;
            }

            updatePizzaPrice();
        }

        private void sizeClicked(object sender, EventArgs e)
        {
            ingredientsGroupBox.Enabled = true;
            orderButton.Enabled = true;
            freeIngredientsLabel.Visible = true;

            // Display how many free Ingredients the user has
            freeIngredientsLabel.Text = $"Free Ingredients: { freeIngredients}";
        }




    }
}
