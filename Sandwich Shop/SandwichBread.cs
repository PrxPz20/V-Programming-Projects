﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandwich_Shop
{
    public class SandwichBread {

        public string propertieType = "RadioButton";

        public string breadName { get; set; }
        public string breadPrice { get; set; }  // i will use the Convert.ToDouble to convert the string to double, so i can make the calcu.




        public SandwichBread() { }

        public SandwichBread(string bread_Name, string bread_Price) {

            breadName = bread_Name;
            breadPrice = bread_Price;
        }






        /*
        public List<string> defaultBreadTypes = new List<string>()
        {
            "Baguette", "Breadstick", "Brioche", "Ciabatta"
        };

        public List<double> breadPrice = new List<double>()
        { 
            3.00, 2.80, 3.00, 2.50
        
        };
        */

        
    }
}