using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApplication {
    public class Ingredients {

        public int freeIngredients = 0;    // this variable, will get it value down at the < sizeRadioButton_CheckedChanged > fuction
        public string saveUsersIngredients = null; // This variable will save and display all the ingredients that the user selected
        public const double EXTRAINGREDIENT = 0.75;
        
        public string ingredientsName { get; set; }
        
        public Ingredients() { }
   
    
    }
}
