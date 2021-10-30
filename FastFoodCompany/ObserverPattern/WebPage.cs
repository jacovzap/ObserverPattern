using FastFoodCompany.BuilderPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace FastFoodCompany.ObserverPattern
{
    class WebPage : MenuSubscriber
    {
        string Name { get; set; }
        //MORE COMPONENTS
        List<Hamburger> Menu = new List<Hamburger>();

        public WebPage(string Name)
        {
            this.Name = Name;
        }
        public void UpdateMenu(Hamburger Burger)
        {
            Menu.Add(Burger);
        }

        public void ShowInformation()
        {
            Console.WriteLine($">>>>>>>>> WEBPAGE: {Name} <<<<<<<<<<");
            Console.WriteLine($"Menu: ");
            foreach (Hamburger Burger in Menu)
            {
                Burger.ShowHamburguer();
            }
            Console.WriteLine($"\n");
        }
    }
}
