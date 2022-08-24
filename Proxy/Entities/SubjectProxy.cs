using Proxy.Interfaces;

namespace Proxy.Entities
{
    class SubjectProxy
        : ISubject
    {
        private RealSubject _realSubject { get; set; }

        public void Request()
        {
            if (_realSubject == null)
                _realSubject = new RealSubject();

            if (CheckAccess())
            {
                _realSubject.Request();

                LogAccess();
            }
        }

        private bool CheckAccess()
        {
            Console.WriteLine("Proxy Check Access");

            return true;
        }

        private void LogAccess()
        {
            Console.WriteLine("Proxy Logging Access");
        }
    }
}
