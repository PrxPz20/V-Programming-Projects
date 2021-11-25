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

        private DateTime UserDeliveryTime;


        PizzaSize pizzaSize = new PizzaSize();
        private Ingredients Ingredients = new Ingredients();
        private Settings Settings = new Settings();
        private About about = new About();

        public MainForm() {
            InitializeComponent();

            createPizzaSizeRadioButton();
            createIngredientCheckBox();
        }


        private void orderButton_Click(object sender, EventArgs e) {
            /*
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

            */
        }
        

        // This Fuction prints the total pizza price
        private void updatePizzaPrice() { totalPriceLabel.Text = $"€ { totalPizzaPrice.ToString() }"; }


        private void sizeRadioButton_CheckedChanged(object sender, EventArgs e) {

            RadioButton radioButton = (sender as RadioButton);
            PizzaSize pizzaSize = radioButton.Tag as PizzaSize;

            if (radioButton.Checked == false)
            {
                MessageBox.Show($"Bread UNCHECK: { pizzaSize.pizzaName }\nBread Price: {pizzaSize.pizzaPrice} "); 
                totalPizzaPrice -= Convert.ToDouble(pizzaSize.pizzaPrice);
            }

            if (radioButton.Checked) {

                //MessageBox.Show($"Bread CHECK: { pizzaSize.pizzaName }\nBread Price: {pizzaSize.pizzaPrice} ");
                freeIngredientsLabel.Visible = true;
                ingredientsGroupBox.Enabled = true;
                totalPriceLabel.Visible = true;
                
                totalPizzaPrice += Convert.ToDouble(pizzaSize.pizzaPrice);
                remainingFreeIngredients = Convert.ToInt32(pizzaSize.FreeIngredient);
                
                // Display how many free Ingredients the user has
                freeIngredientsLabel.Text = $"Free Ingredients: {remainingFreeIngredients}";

            }

            updatePizzaPrice();

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


            /*
            name = name.Replace(" ", "_");

            RadioButton radioButton = new RadioButton();
            radioButton.Text = string.Concat(text[0].ToString().ToUpper()) + text.Substring(1);
            radioButton.Name = name;
            radioButton.CheckedChanged += sizeRadioButton_CheckedChanged;
            radioButton.Click += sizeClicked;
            radioButton.AutoSize = true;
            */

        }


        private void ingredientsCheckBox_CheckedChanged(object sender, EventArgs e) {

            CheckBox CheckBox = (sender as CheckBox);
            Ingredients ingredients = CheckBox.Tag as Ingredients;
            PizzaSize pizzaSize = new PizzaSize();

            if (CheckBox.Checked == false) {
                MessageBox.Show("Ingredients UNCHECKED: " + ingredients.ingredientsName);
                remainingFreeIngredients += 1;
                totalPizzaPrice -= Ingredients.EXTRAINGREDIENT;

                // If the remainingFreeIngredients goes above the corresponding value, it will display the corresponding value 
                if (remainingFreeIngredients > Convert.ToInt32(pizzaSize.FreeIngredient))
                    freeIngredientsLabel.Text = $"Free Ingredients: {Convert.ToInt32(pizzaSize.FreeIngredient)}";

                freeIngredientsLabel.Text = $"Free Ingredients: {remainingFreeIngredients}";
            }

            else {

                orderButton.Enabled = true;

                 //MessageBox.Show("Ingredients CHECKED: " + userIngredients.ingredientsName);
                    
                remainingFreeIngredients -= 1;
                // if the user uses all freeIngredients, 0,75 cent will be added to the price
                if (remainingFreeIngredients < 0)
                    totalPizzaPrice += Ingredients.EXTRAINGREDIENT;

                if (remainingFreeIngredients < 0) {
                    freeIngredientsLabel.Text = $"Free Ingredients: 0";
                }
                else
                    freeIngredientsLabel.Text = $"Free Ingredients: {remainingFreeIngredients}";

                updatePizzaPrice();
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

            if (UserDeliveryTime <= timeNow)
            {
                MessageBox.Show($"Time is not valid, it maybe in the past or not real time {UserDeliveryTime.ToShortTimeString()}", "Time Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // TEST testLabel.Text = " Under the\ntime: " + UserDeliveryTime.ToShortTimeString() + "\n" + timeNow.ToShortTimeString(); 
            }
            else
                testSizeLabel.Text = "The Time is valid" + UserDeliveryTime + "\n" + timeNow;

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
