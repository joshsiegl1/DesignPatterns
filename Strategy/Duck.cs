using System;
using System.Collections.Generic;
using System.Text;

namespace designpatterns.Strategy
{
    class Duck
    {
        public IFlyBehavior flyBehavior; 
        public virtual void Swim()
        {

        }

        public virtual void Display()
        {

        }

        public void PerformFly()
        {
            flyBehavior.fly(); 
        }
    }
}
