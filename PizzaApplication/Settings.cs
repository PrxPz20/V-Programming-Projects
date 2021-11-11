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

        RadioButton newPizzaSize = new RadioButton();
        public List<PizzaSize> pizzaSizes = new List<PizzaSize>();

        public Settings() {

            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e) {

            pizzaSizes.Add(new PizzaSize("Small", 5, 2));
            pizzaSizes.Add(new PizzaSize("Medium", 7.5, 3));
            pizzaSizes.Add(new PizzaSize("Large", 12, 4));

            pizzasizeDataGridView.DataSource = new BindingList<PizzaSize>(pizzaSizes);
        }

        private void saveSizeBuitton_Click(object sender, EventArgs e) {
            
            string pizzaSizesString = JsonConvert.SerializeObject(pizzaSizes);

            File.WriteAllText("PizzaSize.json", pizzaSizesString);
            
        }
    }
}
