using System;
using System.Collections.Generic;
using System.Text;

namespace designpatterns.Factory
{
    public class CheesePizza : Pizza
    {
        public override void Bake()
        {
            Console.WriteLine("Baking..."); 
        }

        public override void Box()
        {
            Console.WriteLine("Boxing...");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting...");
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing...");
        }
    }
}
