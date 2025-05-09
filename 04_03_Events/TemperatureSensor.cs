namespace Events
{
    public class TemperatureEventArgs
    {
        public TemperatureEventArgs(int temperature)
        {
            this.Temperature = temperature;
        }
        public int Temperature { get; private set; }
    }

    public delegate void TemperatureEventHandler(TemperatureEventArgs args);

    public class TemperatureSensor
    {
        private int _temperature;

        public event TemperatureEventHandler TemperatureTooHigh;

        public int Temperature
        {
            get { return _temperature; }
            set
            {
                _temperature = value;
                Console.WriteLine($"Aktuelle Temperatur: {_temperature}°C");

                if (_temperature > 30)
                {
                    // Event auslösen, falls ein Handler registriert ist
                    TemperatureTooHigh(new TemperatureEventArgs(_temperature));
                }
            }
        }
    }
}
