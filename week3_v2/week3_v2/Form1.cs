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
        public Form1() { InitializeComponent(); }


        private const double smallPizzaPrice = 5.50;
        private const double mediumPizzaPrice = 11.75;
        private const double largePizzaPrice = 15.00;
        private const double extraIngredient = 0.75;
        private int freeIngredients = 0;
        private double totalPizzaPrice = 0;

        private void smallRadioButton_MouseHover(object sender, EventArgs e) {toolTip1.Show("up to 2 ingredients for free",smallRadioButton); }
        private void mediumRadioButton_MouseHover(object sender, EventArgs e) {toolTip1.Show("up to 3 ingredients for free", mediumRadioButton); }
        private void LargeRadioButton_MouseHover(object sender, EventArgs e) { toolTip1.Show("up to 4 ingredients for free", smallRadioButton); }

        private void orderButton_Click(object sender, EventArgs e) {
            MessageBox.Show("---", "Order Summary", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }


        // This Fuction prints the total pizza price
        private void updatePizzaPrice() { priceLabel.Text = $"€ {totalPizzaPrice}"; }

        private void sizeRadioButton_CheckedChanged(object sender, EventArgs e) {
            priceLabel.Visible = true;
            var size = (sender as RadioButton);
            
            // Small: up to 2 ingredients for free
            if (smallRadioButton.Checked) {
                freeIngredients = 2;
                totalPizzaPrice = smallPizzaPrice;
            }
            // Medium: up to 3 ingredients for free
            else if (mediumRadioButton.Checked == true) {
                freeIngredients = 3;
                totalPizzaPrice = mediumPizzaPrice;
            }
            // Large: up to 4 ingredients for free
            else {
                freeIngredients = 4;
                totalPizzaPrice = largePizzaPrice;
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
                    totalPizzaPrice -= extraIngredient; 
            }
            // If user checked a Box
            else {
                ingredientsSelected += 1;
                freeIngredients -= 1;

                // if the user uses all freeIngredients, 0,75 cent will be added to the price
                if (freeIngredients < 0)
                    totalPizzaPrice += extraIngredient;
            }

            // if the freeIngredients is not under 0 it will show 0, otherwise it will display normally
            if (freeIngredients > 0)
                free_top_upLabel.Text = $"Free Ingredients: { freeIngredients}";
            else
                free_top_upLabel.Text = "Free Ingredients: 0";


            updatePizzaPrice();
            //testLabel.Text = "CHECKED " + ingredientsSelected;    // test IT WILL BE DELETED

        }

        private void deliveryMaskedTextBox_TypeValidationCompleted(object sender, TypeValidationEventArgs e) {

            var deliveryTime = (sender as MaskedTextBox);
            //var time = 
            //if(deliveryTime < DateTime.Now)
        }
    } // 
} // END of  week3_v2

/*
 * NOTES:
 *  first param = Message to the user, second param = Window Name, 
 * MessageBox.Show Method (String, String, MessageBoxButtons, MessageBoxIcon)
 * 


 */
