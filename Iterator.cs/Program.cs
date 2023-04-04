using Iterator.cs;
using System.Collections.Generic;

IMenu pancakeHouseMenu = new PancakeHouseMenu();
IMenu dinerMenu = new DinerMenu();
IMenu cafeMenu = new CafeMenu();
List<IMenu> menuList = new List<IMenu>{pancakeHouseMenu, dinerMenu, cafeMenu };
Waitress waitress = new Waitress(menuList);
waitress.PrintMenu();

Console.ReadLine();

