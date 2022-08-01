using AbstractFactory.Interfaces;

namespace AbstractFactory.Entities.Mac
{
    class MacButton
        : IButton
    {
        public void Paint()
        {
            Console.WriteLine("Painting Mac Button.");
        }
    }
}
