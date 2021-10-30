using FastFoodCompany.BuilderPattern;
using FastFoodCompany.ObserverPattern;
using System;

namespace FastFoodCompany
{
    class Program
    {

        static void Main(string[] args)
        {
            //UNA CADENA DE COMIDA RAPIDA DE HABMURGUESAS ABRE SU NEGOCIO
            //CREA DOS SUCURSALES Y SU PAGINA WEB
            Sucursal SucursalOne = new Sucursal("Norte");
            Sucursal SucursalTwo = new Sucursal("Centro");
            WebPage Page = new WebPage("GhostHamburger");

            //ESTOS DEBEN MANTENER UN MENU ACTUALIZADO, POR LO QUE SE SUSCRIBEN AL PUBLISHER DEL MENU
            MenuPublisher Publisher = new MenuPublisher();
            Publisher.AddSubscriber(SucursalOne);
            Publisher.AddSubscriber(SucursalTwo);
            Publisher.AddSubscriber(Page);

            //SI CONSULTAMOS EL MENU, ESTE ESTA VACIO!!
            Console.WriteLine($"MOSTRAMOS EL MENU DE LAS DISTINTAS ENTIDADES, ESTAN VACIOS\n");
            SucursalOne.ShowInformation();
            SucursalTwo.ShowInformation();
            Page.ShowInformation();

            //CREAMOS UNA NUEVA HAMBURGUESA
            HamburgerBuilder Builder = new HamburgerBuilder();
            HamburgerDirector Director = new HamburgerDirector();
            Director.MakeNormalHamburger(Builder);
            Hamburger BurgerOne = Builder.GetHamburger();

            //NOTIFICAMOS A LOS SUSCRIPTORES PARA QUE ACTUALICEN SU MENU
            Publisher.Notify(BurgerOne);

            //CONSULTAMOS EL MENU, DEBERIA AGREGARSE LA NUEVA HAMBURGUESA
            Console.WriteLine($"\n\n\nMOSTRAMOS EL MENU DE LAS DISTINTAS ENTIDADES, SE AGREGO UN ELEMENTO\n");
            SucursalOne.ShowInformation();
            SucursalTwo.ShowInformation();
            Page.ShowInformation();

            //CREAMOS DOS NUEVAS HAMBURGUESAS
            Director.MakeCheeseHamburguer(Builder);
            Hamburger BurgerTwo = Builder.GetHamburger();
            Director.MakeCompleteHamburger(Builder);
            Hamburger BurgerTree = Builder.GetHamburger();

            //LAS NOTIFICAMOS A TODOS LOS SUSCRIPTORES
            Publisher.Notify(BurgerTwo);
            Publisher.Notify(BurgerTree);


            //CONSULTAMOS EL MENU, DEBERIA AGREGARSE LAS NUEVAS HAMBURGUESAS
            Console.WriteLine($"\n\n\nMOSTRAMOS EL MENU DE LAS DISTINTAS ENTIDADES, SE AGREGO DOS ELEMENTOS\n");
            SucursalOne.ShowInformation();
            SucursalTwo.ShowInformation();
            Page.ShowInformation();

        }
    }
}
