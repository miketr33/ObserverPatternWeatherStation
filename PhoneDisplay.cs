namespace ObserverPattern
{
    /// <summary>
    /// Concrete class that implements both the ISubscriber and IDisplay interface.
    /// This is used as a subscriber (aka Observer) to the Subject (aka Observable)
    /// </summary>
    /// <remarks>
    /// We intentionally pass in the concrete WeatherStation class so that we have access to methods 
    /// not in the interface and so we do not need to be passed the concrete class every update() call. 
    /// Also this is as prescribed by the book. You could pass the concrete class in each update() call if you like. 
    /// There would be pros and cons to both.
    /// </remarks>
    /// <param name="weatherStation"></param>
    internal class PhoneDisplay(WeatherStation weatherStation) : ISubscriber, IDisplay
    {
        /// <summary>
        /// The Subject (aka Observable)
        /// </summary>
        private WeatherStation Subject { get; set; } = weatherStation;

        /// <summary>
        /// The temperature value stored in this subscriber.
        /// </summary>
        public decimal Temp { get; set; }

        /// <summary>
        /// Implementation of the Display() from the IDisplay interface.
        /// </summary>
        public void Display()
        {
            Console.WriteLine($"PhoneDisplay: Current Temp is {Temp} centigrade");
        }

        /// <summary>
        /// Implementation of the Update() method from the ISubscriber interface.
        /// </summary>
        public void Update()
        {
            Temp = Subject.GetTemp();
        }
    }
}
