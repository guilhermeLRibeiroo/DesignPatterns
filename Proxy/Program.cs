using Proxy.Entities;
using Proxy.Interfaces;

RealSubject realSubject = new RealSubject();
ClientCode(realSubject);

Console.WriteLine();

SubjectProxy subjectProxy = new SubjectProxy();
ClientCode(subjectProxy);


void ClientCode(ISubject subject)
{
    subject.Request();
}