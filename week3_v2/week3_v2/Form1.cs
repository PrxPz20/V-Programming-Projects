using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week3_v2
{
    public partial class Form1 : Form {

        private int freeIngredients = 0;    // this variable, will get it value down at the < sizeRadioButton_CheckedChanged > fuction
        private double totalPizzaPrice = 0;
        private string saveUsersIngredients = null; // This variable will save and display all the ingredients that the user selected
        private DateTime UserDeliveryTime;

        private Settings settings = new Settings();
        private About about = new About();
        private PizzaSize PizzaSize = new PizzaSize();


        public Form1() { InitializeComponent();

            //createPizzaSizeRadioButton("smallRadioButton", "Small       € 5.50");
            //createPizzaSizeRadioButton("mediumRadioButton", "Medium     €11.75");
            //createPizzaSizeRadioButton("largeRadioButton", "Large       € 15.00");

            
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
        private void updatePizzaPrice() { priceLabel.Text = $"€ {totalPizzaPrice}"; }

        private void sizeRadioButton_CheckedChanged(object sender, EventArgs e) {

            priceLabel.Visible = true;
            var sizeSelected = (sender as RadioButton).Name;
            testLabel.Text = sizeSelected;

            // Small: up to 2 ingredients for free
            if (sizeSelected ==  "smallRadioButton") { 
                freeIngredients = 2;
                totalPizzaPrice = PizzaSize.smallPizzaPrice;
            }
            // Medium: up to 3 ingredients for free
            else if (sizeSelected == "mediumRadioButton") { 
                freeIngredients = 3;
                totalPizzaPrice = PizzaSize.mediumPizzaPrice;
            }
            // Large: up to 4 ingredients for free
            else {
                freeIngredients = 4;
                totalPizzaPrice = PizzaSize.largePizzaPrice;
            }

            updatePizzaPrice();
        }

        private void sizeClicked(object sender, EventArgs e) {
            ingredientGroupBox.Enabled = true;
            orderButton.Enabled = true;
            free_top_upLabel.Visible = true;

            // Display how many free Ingredients the user has
            free_top_upLabel.Text = $"Free Ingredients: { freeIngredients}";
        }

        private void Uncheck_state(object sender, EventArgs e) {
            
            deliveryMaskedTextBox.Enabled = true;
            var checkbox = (sender as CheckBox);
            int ingredientsSelected = 0;

            // if the user UnChecked a Box
            if (checkbox.Checked == false) {
                ingredientsSelected -= 1;
                freeIngredients += 1;

                // if Ingredient Unchecked, remove 0,75 cent from the price
                if (freeIngredients > 0)
                    totalPizzaPrice -= 0;
                else 
                    totalPizzaPrice -= PizzaSize.extraIngredient; 
            }
            // If user checked a Box
            else {
                ingredientsSelected += 1;
                freeIngredients -= 1;
                saveUsersIngredients += checkbox.Text + ", ";    // Saves users ingredients in string

                // if the user uses all freeIngredients, 0,75 cent will be added to the price
                if (freeIngredients < 0)
                    totalPizzaPrice += PizzaSize.extraIngredient;
            }

            // if the freeIngredients is not under 0 it will show 0, otherwise it will display normally
            if (freeIngredients > 0)
                free_top_upLabel.Text = $"Free Ingredients: { freeIngredients}";
            else
                free_top_upLabel.Text = "Free Ingredients: 0"; // if the free_top_upLabel under 0 like -1, it will prevent it by showing 0.

            updatePizzaPrice();

        }

        private void deliveryMaskedTextBox_TypeValidationCompleted(object sender, TypeValidationEventArgs e) {

            var tempUserDeliveryTime = (sender as MaskedTextBox);
            DateTime timeNow = DateTime.Now;    // Get the Exact time when the user enters the delivery time
            UserDeliveryTime = DateTime.Parse(tempUserDeliveryTime.Text);  // convert time users time to DateTime

            if (UserDeliveryTime <= timeNow) {
                MessageBox.Show($"Time is not valid, it maybe in the past or not real time {UserDeliveryTime.ToShortTimeString()}","Time Error", MessageBoxButtons.OK ,MessageBoxIcon.Error);
                // TEST testLabel.Text = " Under the\ntime: " + UserDeliveryTime.ToShortTimeString() + "\n" + timeNow.ToShortTimeString(); 
            }
            else
                testLabel.Text = "The Time is valid" + UserDeliveryTime + "\n" + timeNow;

        }

        private void settingsStripMenuItem_Click(object sender, EventArgs e) {
            settings.ShowDialog();
        }
                                                                                
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) { 
            
            about.ShowDialog();
        }

        public void createPizzaSizeRadioButton(string name, string text)
        {

            //pizzaSizeFlowLayoutPanel.Controls.Clear();
            RadioButton radioButton = new RadioButton();
            radioButton.Text = text;
            radioButton.Name = name;
            radioButton.CheckedChanged += sizeRadioButton_CheckedChanged;
            radioButton.Click += sizeClicked;
            radioButton.AutoSize = true;

            pizzaSizeFlowLayoutPanel.Controls.Add(radioButton);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    } // 
} // END of  week3_v2

/*
 * NOTES:
 *  first param = Message to the user, second param = Window Name, 
 * MessageBox.Show Method (String, String, MessageBoxButtons, MessageBoxIcon)
 * 
 */
