﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class GarageDoor
    {        
        public void Up()
        {
            Console.WriteLine("Garage Door is Opened");
        }

        public void Down()
        {
            Console.WriteLine("Garage Door is Closed");
        }

        public void Stop()
        {
            Console.WriteLine("Garage Door is Stoped");
        }

        public void LightOn()
        {
            Console.WriteLine("Light is On");
        }

        public void LightOff()
        {
            Console.WriteLine("Light is Off");
        }
    }
}
