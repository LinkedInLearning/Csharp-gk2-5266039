using System;

namespace Events
{
    public class Program
    {
        public static void Main()
        {
            TemperatureSensor sensor = new TemperatureSensor();

            sensor.TemperatureTooHigh += e => Console.WriteLine($"Temperatur zu hoch: {e.Temperature}"); ;

            for  (int i = 0; i < 10; i++)
            {
                sensor.Temperature = i * 5;
            }
        }

    }

}
