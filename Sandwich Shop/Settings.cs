using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sandwich_Shop
{
    public partial class Settings : Form {

        public List<SandwichBread> Bread = new List<SandwichBread>();
        public List<SandwichIngredients> ingredients = new List<SandwichIngredients>();

        bool setColumsName = false;
        
        public Settings() {
            InitializeComponent();
        }


        private void Settings_Load(object sender, EventArgs e) {

            //Bread.Add(new SandwichBread("Brioche Bread", 2.50));

            //sizeDataGridView.DataSource = new BindingList<SandwichBread>(Bread);
        }

        private void saveSizeButton_Click(object sender, EventArgs e) {

            Bread.Add(new SandwichBread(pizzaSizeTextBox.Text, pizzaPriceTextBox.Text));

            sizeDataGridView.DataSource = new BindingList<SandwichBread>(Bread);
        }

        private void saveIngredientButton_Click(object sender, EventArgs e) {

            ingredients.Add(new SandwichIngredients(ingredientNameTextBox.Text));

            ingredientDataGridView.DataSource = new BindingList<SandwichIngredients>(ingredients);

        }



    }
}
