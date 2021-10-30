using System;
using System.Collections.Generic;
using System.Text;

namespace FastFoodCompany.BuilderPattern
{
    class HamburgerBuilder
    {
        Hamburger Burger = new Hamburger();
       public void Reset()
        {
            this.Burger = new Hamburger();
        }

        public void SetName(string Name)
        {
            Burger.Name = Name;
        }
        public void SetBread()
        {
            Burger.Bread = true;
        }

        public void SetTomatoes()
        {
            Burger.Tomatoes = true;
        }

        public void SetBeef()
        {
            Burger.Beef = true;
        }

        public void SetLettuce()
        {
            Burger.Lettuce = true;
        }

        public void SetMayo()
        {
            Burger.Mayo = true;
        }

        public void SetKetchup()
        {
            Burger.Ketchup = true;
        }
        public void SetPickles()
        {
            Burger.Pickles = true;
        }
        public void SetOnions()
        {
            Burger.Onions = true;
        }
        public void SetCheese()
        {
            Burger.Cheese = true;
        }

       public Hamburger GetHamburger()
        {
            return Burger;
        }

    }
}
