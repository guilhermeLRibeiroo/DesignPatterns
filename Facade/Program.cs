using Facade;
using Facade.Entities;

Subsystem1 subsystem1 = new Subsystem1();
Subsystem2 subsystem2 = new Subsystem2();

FacadeExample facade = new FacadeExample(subsystem1, subsystem2);

Console.WriteLine("Facade provides a simple interface to a complex logic of one or several subsystems");

ClientCode(facade);

void ClientCode(FacadeExample facade)
{
    Console.WriteLine(facade.Operation());
}