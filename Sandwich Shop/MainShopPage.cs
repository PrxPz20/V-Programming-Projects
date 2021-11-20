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

        SandwichBread Bread = new SandwichBread();
        SandwichIngredients Ingredients = new SandwichIngredients();
        Settings Settings = new Settings();
        About About = new About();


        public mainShopForm() {
            
            InitializeComponent();

            InitializeBreadType();  // Displays the Bread Type Values. When the Forms runs for the first time
            InitializeIngredients();    // Displays the Ingredients Values. When the Forms runs for the first time
        }


        private void updateTotalPrice() {

            totalPriceLabel.Text = "$ " + totalPrice.ToString();
        }


        private void settingsStripMenuItem_Click(object sender, EventArgs e) {

            
            Settings.ShowDialog();
            InitializeBreadType();      // When settingsForms closes. It Updates the Bread Type FlowLayout, with newest Bread Types
            InitializeIngredients();    // When settingsForms closes. It Updates the Ingredients FlowLayout, with newest Ingredients
        }


        // This Functions, CREATES the Bread Type RadioButton. Put it gets the values from the Settings file, which contains the things that the user enters
        private void InitializeBreadType()
        {
            breadFlowLayoutPanel.Controls.Clear();  // Clears the FlowLayout, to display the newest values. It's like "refreshing the Layout" 

            foreach (var entry in Settings.Bread)
            {
                var breadRadioButton = new RadioButton();

                breadRadioButton.Text = $"{entry.breadName} € {entry.breadPrice}";
                breadRadioButton.Tag = entry;
                breadRadioButton.Checked = false;
                breadRadioButton.AutoSize = true;

                breadFlowLayoutPanel.Controls.Add(breadRadioButton);    // Adding the new RadioButton on the Layout
            }
        }

        // This Functions, CREATES the Ingredient checkbox. Put it gets the values from the Settings file, which contains the things that the user enters
        private void InitializeIngredients() {

            ingredientsFlowLayoutPanel.Controls.Clear();    // Clears the FlowLayout, to display the newest values. It's like "refreshing the Layout" 

            foreach (var entry in Settings.ingredients) {
                var ingredientCheckBox = new CheckBox();
                
                ingredientCheckBox.Name = $"{entry.ingredientsName}";
                ingredientCheckBox.Text = $"{entry.ingredientsName}";
                ingredientCheckBox.Tag = entry;
                ingredientCheckBox.Checked = false;
                ingredientCheckBox.AutoSize = true;
                
                ingredientsFlowLayoutPanel.Controls.Add(ingredientCheckBox);    // Adding the new CheckBox on the Layout
            }

        }

        private void aboutStripMenuItem_Click(object sender, EventArgs e) {

            About.ShowDialog();
        }

    }
}
