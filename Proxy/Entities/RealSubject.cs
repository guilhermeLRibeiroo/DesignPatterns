using Proxy.Interfaces;

namespace Proxy.Entities
{
    class RealSubject
        : ISubject
    {
        public void Request()
        {
            Console.WriteLine("Real Subject Request.");
        }
    }
}
