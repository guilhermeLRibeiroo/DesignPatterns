using Decorator.Entities;
using Decorator.Interfaces;

IComponent component = new ConcreteComponent();

component = new ConcreteDecoratorA(component);
component = new ConcreteDecoratorB(component);

component.Execute();