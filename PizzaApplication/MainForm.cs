using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaApplication {
    public partial class MainForm : Form {


        private double totalPizzaPrice = 0;
        private DateTime UserDeliveryTime;

        private PizzaSize PizzaSize = new PizzaSize();
        private Ingredients Ingredients = new Ingredients();
        private Settings Settings = new Settings();
        private About about = new About();
        private LoginPage loginPage = new LoginPage();

        public MainForm() {
            InitializeComponent();

            LoginPage_Check();
               
            // This Loop Creates the default Pizza Sizes
            for (int count = 0; count < 3; count++)         // Sets the Propertie Name of the RadioButton          Sets the Text of the RadioButton
                createPizzaSizeRadioButton(PizzaSize.defaultPizzaSizes[count] + PizzaSize.propertieNamePizzaSize, PizzaSize.defaultPizzaSizes[count]  + "    € " + PizzaSize.prices[count]);
                
            for (int count = 0; count < 10; count++)
                createIngredientCheckBox(Ingredients.defaultIngredients[count] + Ingredients.propertieNameIngredients, Ingredients.defaultIngredients[count]);
        }

        private void orderButton_Click(object sender, EventArgs e) {

            AddressForm addressForm = new AddressForm();
            addressForm.ShowDialog();

            DialogResult dialogResult = MessageBox.Show($"Pizza Size: {PizzaSize.smallPizzaPrice}" +
                Environment.NewLine + Environment.NewLine + $"Ingredients: {Ingredients.saveUsersIngredients}" +
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
            testSizeLabel.Text = sizeSelected;

            // Small: up to 2 ingredients for free
            if (sizeSelected == "smallRadioButton")
            {
                Ingredients.freeIngredients = 2;
                totalPizzaPrice = PizzaSize.smallPizzaPrice;
            }
            // Medium: up to 3 ingredients for free
            else if (sizeSelected == "mediumRadioButton")
            {
                Ingredients.freeIngredients = 3;
                totalPizzaPrice = PizzaSize.mediumPizzaPrice;
            }
            // Large: up to 4 ingredients for free
            else
            {
                Ingredients.freeIngredients = 4;
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
            freeIngredientsLabel.Text = $"Free Ingredients: { Ingredients.freeIngredients}";

        }

        private void ingredientsCheckBox_CheckedChanged(object sender, EventArgs e) {

            deliveryTimeMaskedTextBox.Enabled = true;
            var checkbox = (sender as CheckBox);
            int ingredientsSelected = 0;

            // if the user UnChecked a Box
            if (checkbox.Checked == false) {
                ingredientsSelected -= 1;
                Ingredients.freeIngredients += 1;

                // if Ingredient Unchecked, remove 0,75 cent from the price
                if (Ingredients.freeIngredients > 0)
                    totalPizzaPrice -= 0;
                else
                    totalPizzaPrice -= Ingredients.extraIngredient;
            }

            // If user checked a Box
            else {
                ingredientsSelected += 1;
                Ingredients.freeIngredients -= 1;
                Ingredients.saveUsersIngredients += checkbox.Text + ", ";    // Saves users ingredients in string

                // if the user uses all freeIngredients, 0,75 cent will be added to the price
                if (Ingredients.freeIngredients < 0)
                    totalPizzaPrice += Ingredients.extraIngredient;
            }

            // if the freeIngredients is not under 0 it will show 0, otherwise it will display normally
            if (Ingredients.freeIngredients > 0)
                freeIngredientsLabel.Text = $"Free Ingredients: { Ingredients.freeIngredients}";
            else
                freeIngredientsLabel.Text = "Free Ingredients: 0"; // if the freeIngredientsLabel under 0 like -1, it will prevent it by showing 0.

            updatePizzaPrice();

            testIngredientLabel.Text = checkbox.Name;   // TEST DELETE AFTER

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
                testSizeLabel.Text = "The Time is valid" + UserDeliveryTime + "\n" + timeNow;

        }

        public void createPizzaSizeRadioButton(string name, string text) {
            //pizzaSizeFlowLayoutPanel.Controls.Clear();
            name = name.Replace(" ", "_");

            RadioButton radioButton = new RadioButton();
            radioButton.Text = string.Concat(text[0].ToString().ToUpper()) + text.Substring(1);
            radioButton.Name = name;
            radioButton.CheckedChanged += sizeRadioButton_CheckedChanged;
            radioButton.Click += sizeClicked;
            radioButton.AutoSize = true;

            pizzaSizeFlowLayoutPanel.Controls.Add(radioButton);
        }

        public void createIngredientCheckBox(string name, string text) {

            name = name.Replace(" ", "");

            CheckBox checkBox = new CheckBox();
            checkBox.Text = string.Concat(text[0].ToString().ToUpper()) + text.Substring(1);
            checkBox.Name = name;
            checkBox.CheckedChanged += ingredientsCheckBox_CheckedChanged;
            checkBox.AutoSize = true;

            ingredientsFlowLayoutPanel.Controls.Add(checkBox);
        }

        private void settingsStripMenuItem_Click(object sender, EventArgs e) { Settings.ShowDialog(); }

        private void aboutStripMenuItem_Click(object sender, EventArgs e) { about.ShowDialog(); }

        private void LoginPage_Check() {

            loginPage.ShowDialog();

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = false;
        }

    } // MainForm end
} // Namespace end
