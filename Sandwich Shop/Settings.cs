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
    public partial class Settings : Form {

        public List<SandwichBread> Bread = new List<SandwichBread>();
        public List<SandwichIngredients> ingredients = new List<SandwichIngredients>();
        private string ingredientJsonFile = "savedIngredientFile.json";
        private string breadJsonFile = "savedBreadFile.json";

        //bool setColumsName = false;
        
        public Settings() {
            InitializeComponent();

            LoadBread();
            LoadIngredients();

            breadDataGridView.DataSource = new BindingList<SandwichBread>(Bread);
            ingredientDataGridView.DataSource = new BindingList<SandwichIngredients>(ingredients);
        }


        private void saveBreadButton_Click(object sender, EventArgs e) {

            saveBread();
            MessageBox.Show("Successfully saved the Bread and the price.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void saveIngredientButton_Click(object sender, EventArgs e) {

            saveIngredients();
            MessageBox.Show("Successfully saved the Ingredients.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Saves the Bread type that the user Entered
        private void saveBread() {

            var sirializedBread = JsonConvert.SerializeObject(Bread);
            File.WriteAllText(breadJsonFile, sirializedBread, Encoding.UTF8);
                          //The file <name> , what we want to save
        }

        // Saves the Ingredients that the user Entered
        private void saveIngredients() {

            var sirializedIngredients = JsonConvert.SerializeObject(ingredients);
            File.WriteAllText(ingredientJsonFile, sirializedIngredients, Encoding.UTF8);
                           // The file <name>   ,  what we want to save
        }


        private void LoadBread()
        {
            if (File.Exists(breadJsonFile))
            {

                var breadContent = File.ReadAllText(breadJsonFile, Encoding.UTF8);
                Bread = JsonConvert.DeserializeObject<List<SandwichBread>>(breadContent);
            }
            else
                Bread.Clear();


            breadDataGridView.DataSource = new BindingList<SandwichBread>(Bread);
        }

        private void LoadIngredients() {

            if (File.Exists(ingredientJsonFile))
            {

                var ingredientContent = File.ReadAllText(ingredientJsonFile, Encoding.UTF8);
                ingredients = JsonConvert.DeserializeObject<List<SandwichIngredients>>(ingredientContent);
            }
            else
                Bread.Clear();

            ingredientDataGridView.DataSource = new BindingList<SandwichIngredients>(ingredients);

        }


        private void resetBreadButton_Click(object sender, EventArgs e) {

            LoadBread();
            breadDataGridView.DataSource = new BindingList<SandwichBread>(Bread);

        }

        private void resetIngredientButton_Click(object sender, EventArgs e) {

            LoadIngredients();
            ingredientDataGridView.DataSource = new BindingList<SandwichIngredients>(ingredients);

        }


        private void Settings_Leave(object sender, EventArgs e) {

            LoadBread();
            LoadIngredients();

            breadDataGridView.DataSource = new BindingList<SandwichBread>(Bread);
            ingredientDataGridView.DataSource = new BindingList<SandwichIngredients>(ingredients);
        }



    }
}
