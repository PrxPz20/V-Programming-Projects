using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;


namespace PizzaApplication
{
    public partial class Settings : Form {

        public List<PizzaSize> pizzaSizes = new List<PizzaSize>();
        public List<Ingredients> ingredients = new List<Ingredients>();

        private string ingredientJsonFile = "savedIngredientFile.json";
        private string pizzaSizeJsonFile = "savedPizzaSizeFile.json";


        public Settings() {

            InitializeComponent();

            LoadPizzaSize();
            LoadIngredients();

            pizzaSizeDataGridView.DataSource = new BindingList<PizzaSize>(pizzaSizes);
            ingredientsDataGridView.DataSource = new BindingList<Ingredients>(ingredients);

        }

        private void saveSizeBuitton_Click(object sender, EventArgs e) {

            savePizzaSize();
            MessageBox.Show("Successfully saved the Data.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void saveIngredientsButton_Click(object sender, EventArgs e) {

            saveIngredients();
            MessageBox.Show("Successfully saved the Ingredients.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
        private void savePizzaSize() {  // CHANGE NAME

            var sirializedPizzaSize = JsonConvert.SerializeObject(pizzaSizes);
            File.WriteAllText(pizzaSizeJsonFile, sirializedPizzaSize, Encoding.UTF8);
            //The file <name> , what we want to save
        }


        // Saves the Ingredients that the user Entered
        private void saveIngredients()  { // CHANGE NAME

            var sirializedIngredients = JsonConvert.SerializeObject(ingredients);
            File.WriteAllText(ingredientJsonFile, sirializedIngredients, Encoding.UTF8);
            // The file <name>   ,  what we want to save
        }

        private void LoadPizzaSize()  {// CHANGE NAME

            if (File.Exists(pizzaSizeJsonFile)) {

                var pizzaSizeContent = File.ReadAllText(pizzaSizeJsonFile, Encoding.UTF8);
                pizzaSizes = JsonConvert.DeserializeObject<List<PizzaSize>>(pizzaSizeContent);
            }
            else
                pizzaSizes.Clear();
            pizzaSizeDataGridView.DataSource = new BindingList<PizzaSize>(pizzaSizes);
        }

        private void LoadIngredients() {

            if (File.Exists(ingredientJsonFile)) {

                var ingredientContent = File.ReadAllText(ingredientJsonFile, Encoding.UTF8);
                ingredients = JsonConvert.DeserializeObject<List<Ingredients>>(ingredientContent);
            }
            else
                ingredients.Clear();

            ingredientsDataGridView.DataSource = new BindingList<Ingredients>(ingredients);
        }


        private void resetSizebutton_Click(object sender, EventArgs e) {

            LoadPizzaSize();
            pizzaSizeDataGridView.DataSource = new BindingList<PizzaSize>(pizzaSizes);
        }

        private void resetIngredientsButton_Click(object sender, EventArgs e) {

            LoadIngredients();
            ingredientsDataGridView.DataSource = new BindingList<Ingredients>(ingredients);
        }


        private void Settings_Leave(object sender, EventArgs e) {

            LoadPizzaSize();
            LoadIngredients();

            pizzaSizeDataGridView.DataSource = new BindingList<PizzaSize>(pizzaSizes);
            ingredientsDataGridView.DataSource = new BindingList<Ingredients>(ingredients);
        }
    
    }
}
