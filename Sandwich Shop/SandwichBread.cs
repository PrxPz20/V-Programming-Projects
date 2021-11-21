using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;


namespace Sandwich_Shop
{
    public class SandwichBread {

        public string breadName { get; set; }
        public string breadPrice { get; set; }  // i will use the Convert.ToDouble to convert the string to double, so i can make the calcu.
        public string maxIngredients { get; set; }  // Up to how many ingredients can the user add to his/her Samndwich

        public SandwichBread() { }

        public SandwichBread(string bread_Name, string bread_Price, string max_Ingredients) {

            breadName = bread_Name;
            breadPrice = bread_Price;
            maxIngredients = max_Ingredients;
        }


        
    }
}
