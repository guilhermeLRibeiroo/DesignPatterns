using Decorator.Interfaces;

namespace Decorator.Entities
{
    class ConcreteDecoratorA
        : BaseDecorator
    {
        public ConcreteDecoratorA(IComponent wrapee) : base(wrapee) { }

        public override void Execute()
        {
            base.Execute();
            Console.WriteLine("Extra: Concrete Decorator A");
        }
    }
}
