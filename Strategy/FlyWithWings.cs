using System;
using System.Collections.Generic;
using System.Text;

namespace designpatterns.Strategy
{ 
    class FlyWithWings : IFlyBehavior
    { 
        public void fly() 
        {
            Console.WriteLine("I can fly"); 
        }
    }
}