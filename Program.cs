// See https://aka.ms/new-console-template for more information
using ObserverPattern;

WeatherStation station = new();
PhoneDisplay display1 = new(station);
station.RegisterSubscriber(display1);
DesktopDisplay display2 = new(station);
station.RegisterSubscriber(display2);

// Show initial subscriber temps.
display1.Display();
display2.Display();

// Manually update temp (simulating change in temp)
station.SetTemp(new decimal(27.3));
station.Notify();

// Show that display temps have changed for both subscribers.
display1.Display();
display2.Display();