using System;
using System.Collections.Generic;
using System.Text;

namespace FastFoodCompany.BuilderPattern
{
    public class Hamburger
    {

        public bool Bread = false;
        public bool Beef = false;
        public bool Tomatoes = false;
        public bool Lettuce = false;
        public bool Mayo = false;
        public bool Ketchup = false;
        public bool Pickles = false;
        public bool Onions = false;
        public bool Cheese = false;
        public string Name { get; set; }


        public void ShowHamburguer()
        {
            Console.WriteLine($"------ {Name} -----");
            if(Bread != false) Console.WriteLine($"Bread");
            if (Beef != false) Console.WriteLine($"Beef");
            if (Cheese != false) Console.WriteLine($"Cheese");
            if (Tomatoes != false) Console.WriteLine($"Tomatoes");
            if (Lettuce != false) Console.WriteLine($"Lettuce");
            if (Mayo != false) Console.WriteLine($"Mayo");
            if (Ketchup != false) Console.WriteLine($"Ketchup");
            if (Pickles != false) Console.WriteLine($"Pickles");
            if (Onions != false) Console.WriteLine($"Onions");
  
        }
    }
}
