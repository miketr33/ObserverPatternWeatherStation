using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class WeatherStation : ISubject
    {
        public List<ISubscriber> Subscribers { get; set; } = new List<ISubscriber>();  

        public decimal CurrentTemp { get; set; } = new decimal(0.0);

        public WeatherStation() { }

        public void Notify()
        {
            foreach(var subscriber in Subscribers)
            {
                subscriber.Update();            
            }
        }

        public void RegisterSubscriber(ISubscriber subscriber)
        {
            Subscribers.Add(subscriber);
        }

        public void UnregisterSubscriber(ISubscriber subscriber)
        {
            Subscribers.Remove(subscriber);
        }

        public decimal GetTemp()
        {
            return CurrentTemp;
        }

        public void SetTemp(decimal newTemp)
        {
            CurrentTemp = newTemp;
            Console.WriteLine("WeatherStation: Change in temp detected.");
        }
    }
}
