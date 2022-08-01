using AbstractFactory.Interfaces;

namespace AbstractFactory.Entities.Mac
{
    class MacCheckbox
        : ICheckbox
    {
        public void Paint()
        {
            Console.WriteLine("Painting Mac Checkbox.");
        }
    }
}
