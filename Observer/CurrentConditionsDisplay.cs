using System;
using System.Collections.Generic;
using System.Text;

namespace designpatterns.Observer
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private ISubject weatherData; 

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this); 
        }
        public void Display()
        {
            Console.WriteLine("temp: " + temperature); 
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            Display(); 
        }
    }
}
