﻿using System.Collections.Generic;

namespace LinkerWithIterator
{
    public class Waitress
    {
        MenuComponent allMenus;
        public Waitress(MenuComponent allMenus)
        {
            this.allMenus = allMenus;
        }
        public void PrintMenu()
        {
            allMenus.Print();
        }
    }
}
