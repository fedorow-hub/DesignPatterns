﻿using System;

namespace LinkerWithIterator
{
    public abstract class MenuComponent
    {
                
        public virtual void Add(MenuComponent menuComponent)
        {
            throw new NotImplementedException();
        }
        public virtual void Remove(MenuComponent menuComponent)
        {
            throw new NotImplementedException();
        }
        public virtual MenuComponent? GetChild(string name)
        {
            throw new NotImplementedException();
        }

        public virtual string GetName()
        {
            throw new NotImplementedException();
        }
        public virtual string GetDescription()
        {
            throw new NotImplementedException();
        }
        public virtual double GetPrice()
        {
            throw new NotImplementedException();
        }
        public virtual bool IsVegetarian()
        {
            throw new NotImplementedException();
        }

        public virtual void Print()
        {
            throw new NotImplementedException();
        }
        
    }
}