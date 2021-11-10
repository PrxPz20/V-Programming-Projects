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
    public partial class MainForm : Form {

        private int freeIngredients = 0;    // this variable, will get it value down at the < sizeRadioButton_CheckedChanged > fuction
        private double totalPizzaPrice = 0;
        private string saveUsersIngredients = null; // This variable will save and display all the ingredients that the user selected
        private DateTime UserDeliveryTime;

        private PizzaSize PizzaSize = new PizzaSize();

        public MainForm()
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






        private void deliveryTimeMaskedTextBox_TypeValidationCompleted(object sender, TypeValidationEventArgs e) {

            var tempUserDeliveryTime = (sender as MaskedTextBox);
            DateTime timeNow = DateTime.Now;    // Get the Exact time when the user enters the delivery time
            UserDeliveryTime = DateTime.Parse(tempUserDeliveryTime.Text);  // convert time users time to DateTime

            if (UserDeliveryTime <= timeNow)
            {
                MessageBox.Show($"Time is not valid, it maybe in the past or not real time {UserDeliveryTime.ToShortTimeString()}", "Time Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // TEST testLabel.Text = " Under the\ntime: " + UserDeliveryTime.ToShortTimeString() + "\n" + timeNow.ToShortTimeString(); 
            }
            else
                testLabel.Text = "The Time is valid" + UserDeliveryTime + "\n" + timeNow;

        }


        public void createPizzaSizeRadioButton(string name, string text) {

            //pizzaSizeFlowLayoutPanel.Controls.Clear();
            RadioButton radioButton = new RadioButton();
            radioButton.Text = text;
            radioButton.Name = name;
            radioButton.CheckedChanged += sizeRadioButton_CheckedChanged;
            radioButton.Click += sizeClicked;
            radioButton.AutoSize = true;

            pizzaSizeFlowLayoutPanel.Controls.Add(radioButton);
        }



    }
}
