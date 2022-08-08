namespace Builder.Entities
{
    class Car
    {
        public int Seats;
        public string Engine;
        public bool TripComputer;
        public bool GPS;

        public void PrintInformation()
        {
            Console.WriteLine("Seats: {0}", Seats);
            Console.WriteLine("Engine: {0}", Engine);
            Console.WriteLine("Has Trip Computer: {0}", TripComputer);
            Console.WriteLine("Has GPS: {0}", GPS);
        }
    }
}
