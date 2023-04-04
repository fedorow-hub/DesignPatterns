﻿namespace TemplateMethod
{
    public class Tea : CaffeineBeverage
    {
        public override void AddCondiments()
        {
            Console.WriteLine("Adding Lemon");
        }

        public override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }
    }
}
