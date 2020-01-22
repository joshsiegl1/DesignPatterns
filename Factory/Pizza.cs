using System;
using System.Collections.Generic;
using System.Text;

namespace designpatterns.Factory
{
    public abstract class Pizza
    {
        public abstract void Prepare();
        public abstract void Bake();
        public abstract void Cut();
        public abstract void Box(); 
    }
}
