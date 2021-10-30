using FastFoodCompany.BuilderPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace FastFoodCompany.ObserverPattern
{
    class MenuPublisher
    {
        List<MenuSubscriber> Subscribers = new List<MenuSubscriber>();

        public void Notify(Hamburger Burger)
        {
            foreach(MenuSubscriber Subscriber in Subscribers)
            {
                Subscriber.UpdateMenu(Burger);
            }
        }

        public void AddSubscriber(MenuSubscriber Subscriber)
        {
            Subscribers.Add(Subscriber);
        }
    }
}
