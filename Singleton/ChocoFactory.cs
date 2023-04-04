using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class ChocoFactory
    {
        private bool empty;
        private bool boiled;

        private static ChocoFactory uniqueChocoFactory;

        private ChocoFactory()
        {
            empty = true;
            boiled = false;
        }

        public static ChocoFactory GetChocoFactory()
        {
            if(uniqueChocoFactory == null)
            {
                object locker = new();
                lock (locker)
                {
                    uniqueChocoFactory = new ChocoFactory();
                }                    
            }
            return uniqueChocoFactory;
        }

        public void fill()
        {
            if (isEmpty())
            {
                empty = false;
                boiled = false;
                // Заполнение нагревателя молочно-шоколадной смесью
            }
        }
        public void drain()
        {
            if (!isEmpty() && isBoiled())
            {
                // Слить нагретое молоко и шоколад
                empty = true;
            }
        }
        public void boil()
        {
            if (!isEmpty() && !isBoiled())
            {
                // Довести содержимое до кипения
                boiled = true;
            }
        }

        public bool isEmpty()
        {
            return empty;
        }
        public bool isBoiled()
        {
            return boiled;
        }
    }    
}
