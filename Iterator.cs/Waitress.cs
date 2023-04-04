using System.Collections.Generic;

namespace Iterator.cs
{
    public class Waitress
    {
        //IMenu pancakeHouseMenu;
        //IMenu dinerMenu;
        //IMenu cafeMenu;
        List<IMenu> menus;
        public Waitress(List<IMenu> menus)
        {
            //this.pancakeHouseMenu = pancakeHouseMenu;
            //this.dinerMenu = dinerMenu;
            //this.cafeMenu = cafeMenu;
            this.menus = menus;
        }
        public void PrintMenu()
        {
            IEnumerator<IMenu> menuIterator = menus.GetEnumerator();
            while (menuIterator.MoveNext())
            {
                IMenu menu = menuIterator.Current;
                PrintMenu(menu.createIterator());
            }
            //IEnumerator<MenuItem> pancakeIterator = pancakeHouseMenu.createIterator();
            //IEnumerator<MenuItem> dinerIterator = dinerMenu.createIterator();
            //IEnumerator<MenuItem> cafeIterator = cafeMenu.createIterator();
            //Console.WriteLine("MENU\n----\nBREAKFAST");
            //PrintMenu(pancakeIterator);
            //Console.WriteLine("\nLUNCH");
            //PrintMenu(dinerIterator);
            //Console.WriteLine("\nCAFE");
            //PrintMenu(cafeIterator);
        }

        private void PrintMenu(IEnumerator<MenuItem> iterator)
        {
            while (iterator.MoveNext())
            {
                MenuItem menuItem = iterator.Current;
                Console.Write(menuItem.Name + ", ");
                Console.Write(menuItem.Price + " -- ");
                Console.WriteLine(menuItem.Description);                
            }
            Console.WriteLine();
        }


    }
}
