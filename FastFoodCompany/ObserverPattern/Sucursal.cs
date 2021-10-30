using FastFoodCompany.BuilderPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace FastFoodCompany.ObserverPattern
{
    class Sucursal : MenuSubscriber
    {
        string Name { get; set; }
        List<Hamburger> Menu = new List<Hamburger>();

        public Sucursal(string Name)
        {
            this.Name = Name;
        }
        public void UpdateMenu(Hamburger Burger)
        {
            Menu.Add(Burger);
        }

        public void ShowInformation()
        {
            Console.WriteLine($">>>>>>>>>>>> Sucursal: {Name} <<<<<<<<<<<<<<");
            Console.WriteLine($"Menu: ");
            foreach (Hamburger Burger in Menu)
            {
                Burger.ShowHamburguer();
            }
            Console.WriteLine($"\n");
        }
    }
}
