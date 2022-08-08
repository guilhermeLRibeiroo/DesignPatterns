using Builder.Entities;

namespace Builder.Builders
{
    class CarManualBuilder
        : IBuilder
    {
        private Manual _manual;

        public CarManualBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _manual = new Manual();
        }

        public void SetEngine(string engine)
        {
            _manual.EngineInstructions = String.Format("The Car has an engine called {0}.", engine);
        }

        public void SetGPS(bool hasGPS)
        {
            if (hasGPS)
                _manual.GPSInstructions = "To turn on the GPS...";
            else
                _manual.GPSInstructions = "This car hasn't GPS.";
        }

        public void SetSeats(int numberOfSeats)
        {
            _manual.SeatsDescription = String.Format("This Car has {0} seats and they are made of...", numberOfSeats);
        }

        public void SetTripComputer(bool hasTripComputer)
        {
            if (hasTripComputer)
                _manual.TripComputerInstructions = "This Car has Trip Computer and this is how to use.";
            else
                _manual.TripComputerInstructions = "This Car hasn't Trip Computer.";
        }

        public Manual Build()
        {
            var result = _manual;
            Reset();
            return result;
        }
    }
}
