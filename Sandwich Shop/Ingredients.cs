using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandwich_Shop
{
    public class Ingredients {

        public double extraIngredient = 0.50;
        public string ingredientsSelected = null;   // Store the Ingredients that the user selected
        public string propertieType = "CheckBox";

        public List<string> defaultIngredients = new List<string>() 
        { 
            "Turkey", "Bacon", "Ham", "Cheese", "Lettuce", "Tomato", "Mayo", "Cucumber", "Egg", "Bacon"
        };





    }
}
