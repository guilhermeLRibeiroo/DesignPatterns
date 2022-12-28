using Decorator.Entities;
using Decorator.Interfaces;

// Attaches additional responsabilities to an object dynamically

// The decorator is a IComponent and wraps a IComponent that could potentialy wrap another IComponent and so on..
// and with this you could change the behavior of an object at runtime without changing the class.

IComponent component = new ConcreteComponent();

component = new ConcreteDecoratorA(component);
component = new ConcreteDecoratorB(component);

component.Execute();