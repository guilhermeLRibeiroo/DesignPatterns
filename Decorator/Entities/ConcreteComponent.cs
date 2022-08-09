using Decorator.Interfaces;

namespace Decorator.Entities
{
    class ConcreteComponent
        : IComponent
    {
        public void Execute()
        {
            Console.WriteLine("Execute: Concrete Component");
        }
    }
}
