using System;
using System.Collections.Generic;
using System.Text;

namespace FastFoodCompany.BuilderPattern
{
    class HamburgerDirector
    {
        public void MakeNormalHamburger(HamburgerBuilder Builder)
        {
            Builder.Reset();
            Builder.SetName("Normal Hamburger");
            Builder.SetBread();
            Builder.SetBeef();
            Builder.SetMayo();
            Builder.SetKetchup();
            Builder.SetTomatoes();
            Builder.SetOnions();
        }

        public void MakeCheeseHamburguer(HamburgerBuilder Builder)
        {
            Builder.Reset();
            Builder.SetName("Cheese Hamburger");
            Builder.SetBread();
            Builder.SetBeef();
            Builder.SetCheese();
            Builder.SetMayo();
            Builder.SetKetchup();
        }

        public void MakeCompleteHamburger(HamburgerBuilder Builder)
        {
            Builder.Reset();
            Builder.SetName("Complete Hamburger");
            Builder.SetBread();
            Builder.SetBeef();
            Builder.SetCheese();
            Builder.SetMayo();
            Builder.SetKetchup();
            Builder.SetTomatoes();
            Builder.SetOnions();
            Builder.SetPickles();
            Builder.SetLettuce();
        }

    }
}
