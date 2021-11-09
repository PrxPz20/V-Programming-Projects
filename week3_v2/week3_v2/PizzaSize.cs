using System;
using System.Collections.Generic;
using System.Text;

namespace week3_v2
{
    public class PizzaSize {

        public const double smallPizzaPrice = 5.50;
        public const double mediumPizzaPrice = 11.75;
        public const double largePizzaPrice = 15.00;
        public const double extraIngredient = 0.75;
        
        string[] sizes = { "small", "medium", "large" };
        double[] prices = { 5.50, 11.75, 15.00 };

        Form1 pizzaApp = new Form1();

        public  PizzaSize() {
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

    }   // Class End
}
