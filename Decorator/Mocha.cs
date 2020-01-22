using System;
using System.Collections.Generic;
using System.Text;

namespace designpatterns.Decorator
{
    public class Mocha : CondimentDecorator
    {
        Beverage beverage; 

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
            this.beverage.NumCondiments++; 
        }
        public override double cost()
        {
            return beverage.cost() + 0.50; 
        }

        public override string getDescription()
        {
            return beverage.getDescription() + " Mocha,"; 
        }
    }
}
