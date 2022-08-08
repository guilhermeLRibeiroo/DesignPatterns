using Builder.Builders;

namespace Builder
{
    class Director
    {
        public void ConstructSportsCar(IBuilder builder)
        {
            builder.Reset();
            builder.SetSeats(2);
            builder.SetEngine("Sports Car Engine");
            builder.SetTripComputer(true);
            builder.SetGPS(true);
        }

        public void ConstructSUV(IBuilder builder)
        {
            builder.Reset();
            builder.SetSeats(4);
            builder.SetEngine("SUV Car Engine");
            builder.SetTripComputer(false);
            builder.SetGPS(true);
        }
    }
}
