using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandwich_Shop
{
    class Bread {

        //public string[] defaultBreadTypes = { "Baguette", "Breadstick", "Brioche", "Ciabatta" };
        public string propertieType = "RadioButton";


        public List<string> defaultBreadTypes = new List<string>()
        {
            "Baguette", "Breadstick", "Brioche", "Ciabatta"
        };

        public List<double> breadPrice = new List<double>()
        { 
            3.00, 2.80, 3.00, 2.50
        
        };


        
    }
}
