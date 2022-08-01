using AbstractFactory.Interfaces;

namespace AbstractFactory.Entities.Win
{
    class WinCheckbox
        : ICheckbox
    {
        public void Paint()
        {
            Console.WriteLine("Painting Windows Checkbox.");
        }
    }
}
