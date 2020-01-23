using System;
using System.Collections.Generic;
using System.Text;

namespace designpatterns.Singleton
{
    public class Singleton
    {
        private static Singleton UniqueInstance;

        private static readonly object syncLock = new object(); 
        private Singleton() { }

        public static Singleton getInstance()
        {
            lock (syncLock)
            {
                if (UniqueInstance == null)
                {
                    UniqueInstance = new Singleton();
                }
                return UniqueInstance;
            }
        }
    }
}
