using Interfaces;
using Entities;

namespace Adapters
{
    class Adapter
        : ITarget
    {
        Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public string GetRequest()
        {
            return _adaptee.GetSpecificRequest();
        }
    }
}
