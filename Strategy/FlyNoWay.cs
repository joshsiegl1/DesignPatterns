using System;
using System.Collections.Generic;
using System.Text;

namespace designpatterns.Strategy
{
    class FlyNoWay : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I can't fly"); 
        }
    }
}
