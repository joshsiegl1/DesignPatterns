using System;
using System.Collections.Generic;
using System.Text;

namespace designpatterns.Decorator
{
    public class DarkRoast : Beverage
    { 
        public DarkRoast()
        {
            description = "Dark Roast"; 
        }
        public override double cost()
        {
            return 2.99; 
        }
    }
}
