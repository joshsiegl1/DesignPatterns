using System;
using System.Collections.Generic;
using System.Text;

namespace designpatterns.Strategy
{
    class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            Console.WriteLine("I'm a Decoy Duck"); 
            flyBehavior = new FlyNoWay(); 
        }
    }
}
