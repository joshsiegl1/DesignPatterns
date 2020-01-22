using System;
using System.Collections.Generic;
using System.Text;

namespace designpatterns.Observer
{
    public class WeatherData : ISubject
    {
        private List<IObserver> observers;
        private float temperature;
        private float humidity;
        private float pressure; 

        public WeatherData()
        {
            observers = new List<IObserver>(); 
        }
        public void notifyObserver()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(temperature, humidity, pressure); 
            }
        }

        public void registerObserver(IObserver o)
        {
            observers.Add(o); 
        }

        public void removeObserver(IObserver o)
        {
            observers.Remove(o); 
        }


    }
}
