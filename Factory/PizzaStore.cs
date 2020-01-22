using System;
using System.Collections.Generic;
using System.Text;

namespace designpatterns.Factory
{
    public abstract class PizzaStore
    {
        private SimplePizzaFactory Factory; 
        public PizzaStore(SimplePizzaFactory factory)
        {
            this.Factory = factory; 
        }
        public Pizza orderPizza(string type)
        {
            Pizza pizza;

            pizza = Factory.createPizza("Cheese");

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box(); 

            return pizza; 
        }
    }
}
