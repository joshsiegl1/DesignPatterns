using System;
using System.Collections.Generic;
using System.Text;

namespace designpatterns.Decorator
{
    public abstract class Beverage
    {
        public string description = "Unkown Beverage";

        public int NumCondiments = 0; 
        public virtual string getDescription()
        {
            if (NumCondiments > 0)
                return description + " With";
            else return description; 
        }
        public abstract double cost(); 
    }
}
