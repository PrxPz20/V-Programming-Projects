using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;


namespace Sandwich_Shop
{
    public partial class mainShopForm : Form {

        private double totalPrice;
        private int remainingMaxIngredients = 0;

        SandwichBread Bread = new SandwichBread();
        SandwichIngredients Ingredients = new SandwichIngredients();
        Settings Settings = new Settings();
        About About = new About();
        LoginPage LoginPage = new LoginPage();


        public mainShopForm() {

            LoginPage.Show();
            InitializeComponent();

            InitializeBreadType();  // Displays the Bread Type Values. When the Forms runs for the first time
            InitializeIngredients();    // Displays the Ingredients Values. When the Forms runs for the first time
        }


        private void updateTotalPrice(double price) {


            totalPrice += price;
            totalPriceLabel.Text = "$ " + totalPrice.ToString(); 
        }


        private void checkBreadRadioButton_CheckedChanged(object sender, EventArgs e) {

            RadioButton radioButton = ( sender as RadioButton );
            SandwichBread Bread = radioButton.Tag as SandwichBread;

            if (radioButton.Checked) {
                MessageBox.Show($"Bread CHECK: { Bread.breadName }\nBread Price: {Bread.breadPrice} ");


                updateTotalPrice(Convert.ToDouble(Bread.breadPrice));

                remainingMaxIngredients =  Convert.ToInt32(Bread.maxIngredients);
                maxIngredientLabel.Visible = true;
                maxIngredientLabel.Text = $"You can choose Up to: {remainingMaxIngredients}";
            }
        }

        private void checkIngredientCheckBox_CheckedChanged(object sender, EventArgs e) {

            CheckBox CheckBox = ( sender as CheckBox );
            SandwichIngredients userIngredients = CheckBox.Tag as SandwichIngredients;
            SandwichBread Bread = new SandwichBread();

            if (CheckBox.Checked == false) {
                MessageBox.Show("Ingredients UNCHECKED: " + userIngredients.ingredientsName);

                totalPrice -= Convert.ToDouble(userIngredients.ingredientPrice);
                remainingMaxIngredients += 1;
                updateTotalPrice(Convert.ToDouble(userIngredients.ingredientPrice));
            }

            else {

                if (remainingMaxIngredients != Convert.ToInt32(Bread.maxIngredients)) {

                    MessageBox.Show("Ingredients CHECKED: " + userIngredients.ingredientsName);
                    totalPrice += Convert.ToDouble(userIngredients.ingredientPrice);
                    remainingMaxIngredients -= 1;
                    updateTotalPrice(Convert.ToDouble(userIngredients.ingredientPrice));
                }

                else {
                    MessageBox.Show("You have reached the Maximum amount of Ingredients.");
                }

            }

           
        }


        // This Functions, CREATES the Bread Type RadioButton. Put it gets the values from the Settings file, which contains the things that the user enters
        private void InitializeBreadType()
        {
            breadFlowLayoutPanel.Controls.Clear();  // Clears the FlowLayout, to display the newest values. It's like "refreshing the Layout" 

            foreach (var entry in Settings.Bread)
            {
                var breadRadioButton = new RadioButton();

                breadRadioButton.Text = $"{entry.breadName}   € {entry.breadPrice}   Up to:  {entry.maxIngredients}";
                breadRadioButton.Tag = entry;
                breadRadioButton.Checked = false;
                breadRadioButton.AutoSize = true;
                breadRadioButton.CheckedChanged += checkBreadRadioButton_CheckedChanged;

                breadFlowLayoutPanel.Controls.Add(breadRadioButton);    // Adding the new RadioButton on the Layout
            }
        }


        // This Functions, CREATES the Ingredient checkbox. Put it gets the values from the Settings file, which contains the things that the user enters
        private void InitializeIngredients() {

            ingredientsFlowLayoutPanel.Controls.Clear();    // Clears the FlowLayout, to display the newest values. It's like "refreshing the Layout" 

            foreach (var entry in Settings.ingredients) {
                var ingredientCheckBox = new CheckBox();
                
                ingredientCheckBox.Name = $"{entry.ingredientsName}";
                ingredientCheckBox.Text = $"{entry.ingredientsName}  €  {entry.ingredientPrice}";
                ingredientCheckBox.Tag = entry;
                ingredientCheckBox.Checked = false;
                ingredientCheckBox.AutoSize = true;
                ingredientCheckBox.CheckedChanged += checkIngredientCheckBox_CheckedChanged;

                ingredientsFlowLayoutPanel.Controls.Add(ingredientCheckBox);    // Adding the new CheckBox on the Layout
            }

        }


        private void settingsStripMenuItem_Click(object sender, EventArgs e) {
            
            Settings.ShowDialog();
            InitializeBreadType();      // When settingsForms closes. It Updates the Bread Type FlowLayout, with newest Bread Types
            InitializeIngredients();    // When settingsForms closes. It Updates the Ingredients FlowLayout, with newest Ingredients
        }

        private void aboutStripMenuItem_Click(object sender, EventArgs e) { About.ShowDialog(); }

    }
}
