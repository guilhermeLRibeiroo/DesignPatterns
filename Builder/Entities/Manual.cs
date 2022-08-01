namespace Builder.Entities
{
    class Manual
    {
        public string SeatsDescription;
        public string EngineInstructions;
        public string TripComputerInstructions;
        public string GPSInstructions;

        public void PrintInformation()
        {
            Console.WriteLine("Seats Description: {0}", SeatsDescription);
            Console.WriteLine("Engine Instructions: {0}", EngineInstructions);
            Console.WriteLine("Trip Computer Instruction: {0}", TripComputerInstructions);
            Console.WriteLine("GPS Instruction: {0}", GPSInstructions);
        }
    }
}
