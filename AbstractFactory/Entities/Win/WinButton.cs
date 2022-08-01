using AbstractFactory.Interfaces;

namespace AbstractFactory.Entities.Win
{
    class WinButton
        : IButton
    {
        public void Paint()
        {
            Console.WriteLine("Painting Windows Button.");
        }
    }
}
