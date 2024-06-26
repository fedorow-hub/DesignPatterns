﻿using System;

namespace LinkerWithIterator
{
    public class MenuItem : MenuComponent
    {
        string name;
        string description;
        bool vegetarian;
        double price;

        public MenuItem(string name,
            string description,
            bool vegetarian,
            double price)
        {
            this.name = name;
            this.description = description;
            this.vegetarian = vegetarian;
            this.price = price;
        }

        public override string GetName()
        {
            return name;
        }

        public override string GetDescription()
        {
            return description;
        }

        public override double GetPrice()
        {
            return price;
        }

        public override bool IsVegetarian()
        {
            return vegetarian;
        }

        public override void Print()
        {
            Console.WriteLine(" " + GetName());
            if (IsVegetarian())
            {
                Console.WriteLine("(v)");
            }
            Console.WriteLine(", " + GetPrice());
            Console.WriteLine(" -- " + GetDescription());
        }
    }
}
