using Builder.Entities;

namespace Builder.Builders
{
    class CarBuilder
        : IBuilder
    {
        private Car _car;

        public CarBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _car = new Car();
        }

        public void SetEngine(string engine)
        {
            _car.Engine = engine;
        }

        public void SetGPS(bool hasGPS)
        {
            _car.GPS = hasGPS;
        }

        public void SetSeats(int numberOfSeats)
        {
            _car.Seats = numberOfSeats;
        }

        public void SetTripComputer(bool hasTripComputer)
        {
            _car.TripComputer = hasTripComputer;
        }

        public Car Build()
        {
            var result = _car;
            Reset();
            return result;
        }
    }
}
