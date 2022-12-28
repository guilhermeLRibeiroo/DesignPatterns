using Proxy.Entities;
using Proxy.Interfaces;

// "Provides a surrogate or placeholder for another object to control access to it"..

RealSubject realSubject = new RealSubject();
ClientCode(realSubject);

Console.WriteLine();

// Instead of calling RealSubject directly, you call the proxy that calls the RealSubject.
SubjectProxy subjectProxy = new SubjectProxy();
ClientCode(subjectProxy);

void ClientCode(ISubject subject)
{
    subject.Request();
}