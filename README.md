# EJEMPLO UTILIZANDO EL PATRON DE COMPORTAMIENTO OBSERVER

### ENUNCIADO DEL PROBLEMA
Se funda una empresa de comida rapida que vende hamburguesas, al principio cuenta con unas pocas sucursales y una pagina web. La empresa requiere que al momento de lanzar un nuevo tipo de hamburguesa esta aparezca en el menu de todas sus sucursales asi como de su pagina web. Este proceso debe ser automatizado, ya que requeriria un gran esfuerzo modificar cada uno de los menus en las sucursales de manera manual.
### SOLUCION AL PROBLEMA
Se utilizaron dos tipos de patrones para solucionar este problema, no por absoluta necesidad, si no con fines de aprendizaje.
### PATRON BUILDER
Primeramente se utilizo el patron creacional BUILDER para la creacion de hamburguesas, cuyos ingredientes pueden llegar a ser demasiados, provocando confusiones.
### DIAGRAMA UML PATRON BUILDER
![UML](https://github.com/jacovzap/ObserverPattern/blob/main/Images/UMLBuilderPattern.png)

### PATRON OBSERVER
Se aplico el patron de comportamiento OBSERVER, el cual nos servira para notificar a las distintas entidades suscritas acerca del cambio en el menu.
### DIAGRAMA UML PATRON OBSERVER
![UML](https://github.com/jacovzap/ObserverPattern/blob/main/Images/UMLObserverPattern.png)

### DIAGRAMA UML COMPLETO
![UML](https://github.com/jacovzap/ObserverPattern/blob/main/Images/UMLComplete.png)

### MAIN
```
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
```
### RESULTADOS
Como resultado el programa imprime:
```
MOSTRAMOS EL MENU DE LAS DISTINTAS ENTIDADES, ESTAN VACIOS

>>>>>>>>>>>> Sucursal: Norte <<<<<<<<<<<<<<
Menu:


>>>>>>>>>>>> Sucursal: Centro <<<<<<<<<<<<<<
Menu:


>>>>>>>>> WEBPAGE: GhostHamburger <<<<<<<<<<
Menu:





MOSTRAMOS EL MENU DE LAS DISTINTAS ENTIDADES, SE AGREGO UN ELEMENTO

>>>>>>>>>>>> Sucursal: Norte <<<<<<<<<<<<<<
Menu:
------ Normal Hamburger -----
Bread
Beef
Tomatoes
Mayo
Ketchup
Onions


>>>>>>>>>>>> Sucursal: Centro <<<<<<<<<<<<<<
Menu:
------ Normal Hamburger -----
Bread
Beef
Tomatoes
Mayo
Ketchup
Onions


>>>>>>>>> WEBPAGE: GhostHamburger <<<<<<<<<<
Menu:
------ Normal Hamburger -----
Bread
Beef
Tomatoes
Mayo
Ketchup
Onions





MOSTRAMOS EL MENU DE LAS DISTINTAS ENTIDADES, SE AGREGO DOS ELEMENTOS

>>>>>>>>>>>> Sucursal: Norte <<<<<<<<<<<<<<
Menu:
------ Normal Hamburger -----
Bread
Beef
Tomatoes
Mayo
Ketchup
Onions
------ Cheese Hamburger -----
Bread
Beef
Cheese
Mayo
Ketchup
------ Complete Hamburger -----
Bread
Beef
Cheese
Tomatoes
Lettuce
Mayo
Ketchup
Pickles
Onions


>>>>>>>>>>>> Sucursal: Centro <<<<<<<<<<<<<<
Menu:
------ Normal Hamburger -----
Bread
Beef
Tomatoes
Mayo
Ketchup
Onions
------ Cheese Hamburger -----
Bread
Beef
Cheese
Mayo
Ketchup
------ Complete Hamburger -----
Bread
Beef
Cheese
Tomatoes
Lettuce
Mayo
Ketchup
Pickles
Onions


>>>>>>>>> WEBPAGE: GhostHamburger <<<<<<<<<<
Menu:
------ Normal Hamburger -----
Bread
Beef
Tomatoes
Mayo
Ketchup
Onions
------ Cheese Hamburger -----
Bread
Beef
Cheese
Mayo
Ketchup
------ Complete Hamburger -----
Bread
Beef
Cheese
Tomatoes
Lettuce
Mayo
Ketchup
Pickles
Onions
```
