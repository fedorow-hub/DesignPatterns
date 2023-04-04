using LinkerWithIterator;

MenuComponent pancakeHouseMenu = new Menu("PANCAKE HOUSE MENU", "Breakfast");
MenuComponent dinerMenu = new Menu("DINER MENU", "Lunch");
MenuComponent cafeMenu = new Menu("CAFE MENU", "Dinner");
MenuComponent dessertMenu = new Menu("DESSERT MENU", "Dessert of course!");

MenuComponent allMenus = new Menu("ALL MENUS", "All menus combined");

allMenus.Add(pancakeHouseMenu);
allMenus.Add(dinerMenu);
allMenus.Add(cafeMenu);

dinerMenu.Add(new MenuItem(
 "Pasta",
 "Spaghetti with Marinara Sauce, and a slice of sourdough bread",
 true,
 3.89));

dinerMenu.Add(dessertMenu);

MenuComponent desert = new MenuItem(
"Apple Pie",
"Apple pie with a flakey crust, topped with vanilla icecream",
true,
1.59);
dessertMenu.Add(desert);

// добавление других элементов

Waitress waitress = new Waitress(allMenus);

waitress.PrintMenu();

Console.ReadLine();

