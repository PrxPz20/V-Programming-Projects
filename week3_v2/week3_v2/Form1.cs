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


        private const double Small_pizza_price = 5.50;
        private const double Medium_pizza_price = 11.75;
        private const double Large_pizza_price = 15.00;
        private const double extra_ingredient = 0.75;
        private int free_ingredients = 0;
        private double pizza_price = 0;
        private int ingredientsSelected = 0;
        

        private void smallRadioButton_MouseHover(object sender, EventArgs e) {toolTip1.Show("up to 2 ingredients for free",smallRadioButton); }

        private void mediumRadioButton_MouseHover(object sender, EventArgs e) {toolTip1.Show("up to 3 ingredients for free", mediumRadioButton); }

        private void LargeRadioButton_MouseHover(object sender, EventArgs e) { toolTip1.Show("up to 4 ingredients for free", smallRadioButton); }

        private void button1_Click(object sender, EventArgs e) {
            MessageBox.Show($"Pizza size: {Small_pizza_price}\n" + "Ingredients: -----","Order Summary", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void sizeRadioButton_CheckedChanged(object sender, EventArgs e)
        {

            // Small: up to 2 ingredients for free
            if (smallRadioButton.Checked) {
                free_ingredients = 2;
                pizza_price = Small_pizza_price;
            }
            // Medium: up to 3 ingredients for free
            else if (mediumRadioButton.Checked == true) {
                free_ingredients = 3;
                pizza_price = Medium_pizza_price;
            }
            // Large: up to 4 ingredients for free
            else {
                free_ingredients = 4;
                pizza_price = Large_pizza_price;
            }
        }
        private void sizeClicked(object sender, EventArgs e) {
            ingredientGroupBox.Enabled = true;
            orderButton.Enabled = true;
            free_top_upLabel.Visible = true;

            if (free_ingredients < 0)
                free_top_upLabel.Text = "Free Ingredients: " + free_ingredients;
            else
                free_top_upLabel.Text = "Free Ingredients: 0";

            priceLabel.Text = "€ " + pizza_price;
        }

        private void Uncheck_state(object sender, EventArgs e)
        {
            var checkbox = (sender as CheckBox);

            //MessageBox.Show(checkbox.Text + " : " + checkbox.Checked);

            if (checkbox.Checked == false) {
                ingredientsSelected -= 1;
                 
                // if sta
            }
            else {
                ingredientsSelected += 1;
                free_ingredients -= 1;
            }
            testLabel.Text = "CHECKED " + ingredientsSelected;    // test IT WILL BE DELETED

        }



    } // 
} // END of  week3_v2

/*
 * NOTES:
 *  first param = Message to the user, second param = Window Name, 
 * MessageBox.Show Method (String, String, MessageBoxButtons, MessageBoxIcon)
 * 
 *         private void smallRadioButton_CheckedChanged(object sender, EventArgs e) {
            if (smallRadioButton.Checked == true)
                ingredientGroupBox.Enabled = true;
        }

            if (PepperoniCheckBox.CheckState == CheckState.Unchecked)
                count -= 1;
            else if (onionCheckBox.Checked)
                count -= 1;
            else if (black_olivesCheckBox.Checked)
                count -= 1;
            else if (mushroomCheckBox.Checked)
                count -= 1;
            else if (pineappleCheckBox.Checked)
                count -= 1;
            else if (extra_cheeseCheckBox.Checked)
                count -= 1;

            // if (deliveryTextBox.Enabled == true) { count++; testLabel.Text = "CHECKED" + count; }
            // if ... == false count--
 */
