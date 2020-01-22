using System;
using designpatterns.Strategy;
using designpatterns.Decorator; 

namespace designpatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Console.WriteLine("Strategy Demo");

            //DecoyDuck duck = new DecoyDuck();
            //duck.PerformFly();

            Beverage beverage = new DarkRoast();
            beverage = new Mocha(beverage);
            beverage = new Mocha(beverage); 

            Console.WriteLine(beverage.getDescription());
            Console.WriteLine("Cost " + beverage.cost()); 

            Console.ReadKey(); 
        }
    }
}
