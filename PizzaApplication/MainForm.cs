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


        private double totalPizzaPrice;
        private int remainingFreeIngredients;
        public string saveUsersIngredients; // This variable will save and display all the ingredients that the user selected
        public string pizzaSizeSelected;

        private DateTime UserDeliveryTime;

        public PizzaSize pizzaSize = new PizzaSize();
        public Ingredients Ingredients = new Ingredients();
        public Settings Settings = new Settings();
        public AddressForm AddressForm = new AddressForm();
        public About about = new About();

        public MainForm() {
            InitializeComponent();

            createPizzaSizeRadioButton();
            createIngredientCheckBox();
        }

        // This Function checks, what Access level does the user has
        public void userAccessLevel(string access) {
            if (access == "Manager")
                settingsStripMenuItem.Visible = true;
            else if (access == "User")
                settingsStripMenuItem.Visible = false;
        }

        private string OrderSummary() { return $"Pizza Size: {pizzaSizeSelected}\nIngredients: {saveUsersIngredients}\nLocation: {AddressForm.userLocationAddress}\nTotal Price: € {totalPizzaPrice}";  }


        private void orderButton_Click(object sender, EventArgs e) {

            AddressForm.ShowDialog();

            MessageBox.Show($"YOUR ORDER:\n{OrderSummary()}", "Order Summary", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }
        

        // This Fuction prints the total pizza price
        private void updatePizzaPrice() { totalPriceLabel.Text = $"€ { totalPizzaPrice.ToString() }"; }


        private void sizeRadioButton_CheckedChanged(object sender, EventArgs e) {

            RadioButton radioButton = (sender as RadioButton);
            PizzaSize pizzaSize = radioButton.Tag as PizzaSize;

            if (radioButton.Checked) {

                freeIngredientsLabel.Visible = true;
                ingredientsGroupBox.Enabled = true;
                totalPriceLabel.Visible = true;
                

                totalPizzaPrice = Convert.ToDouble(pizzaSize.pizzaPrice);
                remainingFreeIngredients = Convert.ToInt32(pizzaSize.FreeIngredient);
                
                // Display how many free Ingredients the user has
                freeIngredientsLabel.Text = $"Free Ingredients: {remainingFreeIngredients}";

                pizzaSizeSelected = pizzaSize.pizzaName;    // SET the size of the pizza, so we can display it after
            }

            updatePizzaPrice();

        }

        private void ingredientsCheckBox_CheckedChanged(object sender, EventArgs e) {

            CheckBox CheckBox = (sender as CheckBox);
            Ingredients ingredients = CheckBox.Tag as Ingredients;
            PizzaSize pizzaSize = new PizzaSize();

            if (CheckBox.Checked == false) {

                remainingFreeIngredients += 1;

                // if Ingredient Unchecked, remove 0,75 cent from the price
                if (remainingFreeIngredients > 0)
                    totalPizzaPrice -= 0;
                else
                    totalPizzaPrice -= Ingredients.EXTRAINGREDIENT;


                freeIngredientsLabel.Text = $"Free Ingredients: {remainingFreeIngredients}";
                
            }
            else {

                deliveryTimeMaskedTextBox.Enabled = true;
                orderButton.Enabled = true;
                saveUsersIngredients += CheckBox.Text + ", ";    // Saves users ingredients in string
                remainingFreeIngredients -= 1;

                // if the user uses all freeIngredients, 0,75 cent will be added to the price
                if (remainingFreeIngredients < 0)
                    totalPizzaPrice += Ingredients.EXTRAINGREDIENT;

                
            }

            updatePizzaPrice();
            if (remainingFreeIngredients < 0)
                freeIngredientsLabel.Text = $"Free Ingredients: 0";
            else
                freeIngredientsLabel.Text = $"Free Ingredients: {remainingFreeIngredients}";

        }


        // Creating RadioButtons for the Pizza Size 
        public void createPizzaSizeRadioButton() {
            
            pizzaSizeFlowLayoutPanel.Controls.Clear();

            foreach (var entry in Settings.pizzaSizes) {

                var radioButton = new RadioButton();

                radioButton.Text = $"{entry.pizzaName}   € {entry.pizzaPrice}   Up to:  {entry.FreeIngredient}"; //string.Concat(text[0].ToString().ToUpper()) + text.Substring(1);
                radioButton.Tag = entry;
                radioButton.Checked = false;
                //radioButton.Name = entry.pizzaName;
                radioButton.CheckedChanged += sizeRadioButton_CheckedChanged;
                radioButton.AutoSize = true;

                pizzaSizeFlowLayoutPanel.Controls.Add(radioButton);
            }

        }
        public void createIngredientCheckBox() {

            ingredientsFlowLayoutPanel.Controls.Clear();

            foreach (var entry in Settings.ingredients) {

                var checkBox = new CheckBox();

                checkBox.Text = $"{entry.ingredientsName}"; //string.Concat(text[0].ToString().ToUpper()) + text.Substring(1);
                checkBox.Tag = entry;
                checkBox.Checked = false;
                checkBox.CheckedChanged += ingredientsCheckBox_CheckedChanged;
                checkBox.AutoSize = true;

                ingredientsFlowLayoutPanel.Controls.Add(checkBox);
            }
            /*
            name = name.Replace(" ", "");
            */
            
        }


        private void deliveryTimeMaskedTextBox_TypeValidationCompleted(object sender, TypeValidationEventArgs e) {

            var tempUserDeliveryTime = (sender as MaskedTextBox);
            DateTime timeNow = DateTime.Now;    // Get the Exact time when the user enters the delivery time
            UserDeliveryTime = DateTime.Parse(tempUserDeliveryTime.Text);  // convert time users time to DateTime

            if (UserDeliveryTime <= timeNow) {
                MessageBox.Show($"Time is not valid, it maybe in the past or not real time {UserDeliveryTime.ToShortTimeString()}", "Time Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

        }
        private void settingsStripMenuItem_Click(object sender, EventArgs e) { 
            Settings.ShowDialog();
            createPizzaSizeRadioButton();   // When settingsForms closes. It Updates the Size Type FlowLayout, with newest Pizza Size Types
            createIngredientCheckBox();
        }
        private void aboutStripMenuItem_Click(object sender, EventArgs e) { about.ShowDialog(); }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {  e.Cancel = false; }

    } // MainForm end
} // Namespace end
