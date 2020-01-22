using System;
using System.Collections.Generic;
using System.Text;

namespace designpatterns.Factory
{
    public class SimplePizzaFactory
    {
        public Pizza createPizza(string type)
        {
            if (type == "Cheese")
                return new CheesePizza();

            return new CheesePizza(); 
        }
    }
}
