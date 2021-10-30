using FastFoodCompany.BuilderPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace FastFoodCompany.ObserverPattern
{
    public interface MenuSubscriber
    {
        void UpdateMenu(Hamburger Burger);
    }
}
