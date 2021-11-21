using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;


namespace Sandwich_Shop
{
    public class SandwichIngredients {

        
        public string ingredientsSelected;   // Store the Ingredients that the user selected
        
        public string ingredientsName { get; set; }
        public string ingredientPrice { get; set; }       // Store the Ingredients price

        public SandwichIngredients() { }

        public SandwichIngredients(string ingredient_Name, string ingredient_Price) { 
            ingredientsName = ingredient_Name;
            ingredientPrice = ingredient_Price;
        }



    }
}
