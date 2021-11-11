using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApplication {
    class Ingredients {

        public int freeIngredients = 0;    // this variable, will get it value down at the < sizeRadioButton_CheckedChanged > fuction
        public string saveUsersIngredients = null; // This variable will save and display all the ingredients that the user selected
        public const double extraIngredient = 0.75;

        public string propertieNameIngredients = "CheckBox";

        public string[] defaultIngredients = { "pepperoni", "pineapple", "mushroom", "black Olives", "tomato", "sausage", "feta", "onion", "chopped Basil", "extra Cheese" };







    }
}
