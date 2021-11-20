using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApplication {
    public class PizzaSize {

        public const double smallPizzaPrice = 5.50;
        public const double mediumPizzaPrice = 11.75;
        public const double largePizzaPrice = 15.00;
        public string propertieNamePizzaSize = "RadioButton";

        public string[] defaultPizzaSizes = { "small", "medium", "large" };
        public double[] prices = { 5.50, 11.75, 15.00 };

        public PizzaSize()
        {
        }

        public PizzaSize(string name, double price, int freeIngredientCount)
        {
            Name = name;
            Price = price;
            FreeIngredientCount = freeIngredientCount;
        }



        public string Name { get; set; }
        public double Price { get; set; }
        public int FreeIngredientCount { get; set; }






    }
}
