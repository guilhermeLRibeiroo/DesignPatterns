using ChainOfResponsibility.Interfaces;

namespace ChainOfResponsibility.Handlers
{
    abstract class AbstractHandler
        : IHandler
    {
        private IHandler _nextHandler;

        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;
            return this;
        }

        public virtual string Execute(int request)
        {
            if(_nextHandler != null)
                return _nextHandler.Execute(request);

            return "AbstractHandler: Base Execute";
        }
    }
}
