using Decorator.Interfaces;

namespace Decorator.Entities
{
    abstract class BaseDecorator
        : IComponent
    {
        IComponent _wrapee;

        public BaseDecorator(IComponent wrapee)
        {
            _wrapee = wrapee;
        }

        public virtual void Execute()
        {
            _wrapee.Execute();
        }
    }
}
