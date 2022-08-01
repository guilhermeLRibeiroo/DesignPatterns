namespace Builder.Builders
{
    interface IBuilder
    {
        void Reset();
        void SetSeats(int numberOfSeats);
        void SetEngine(string engine);
        void SetTripComputer(bool hasTripComputer);
        void SetGPS(bool hasGPS);
    }
}
