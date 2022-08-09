using Decorator.Interfaces;

namespace Decorator.Entities
{
    class ConcreteDecoratorB
        : BaseDecorator
    {
        public ConcreteDecoratorB(IComponent wrapee) : base(wrapee) { }

        public override void Execute()
        {
            base.Execute();
            Console.WriteLine("Extra: Concrete Decorator B");
        }
    }
}
