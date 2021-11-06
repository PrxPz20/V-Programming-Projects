using System;
using System.Collections.Generic;
using System.Text;

namespace week3_v2
{
    public class PizzaSize {

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




    }
}
