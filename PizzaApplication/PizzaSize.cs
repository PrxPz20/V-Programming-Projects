using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApplication {
    public class PizzaSize {

        public string pizzaName { get; set; }
        public string pizzaPrice { get; set; }
        public string FreeIngredient { get; set; }

        public string propertieNamePizzaSize = "RadioButton";

        public PizzaSize() { }

        public PizzaSize(string name, string price, string freeIngredientCount) {
            pizzaName = name;
            pizzaPrice = price;
            FreeIngredient = freeIngredientCount;
        }








    }
}
