using Visitor.Components;
using Visitor.Visitors;

var components = new List<IComponent>
{
    new ConcreteComponentA(),
    new ConcreteComponentB()
};

Console.WriteLine("The client code works with ConcreteVisitorA");
var concreteVisitorA = new ConcreteVisitorA();

foreach(var component in components)
{
    component.Accept(concreteVisitorA);
}

Console.WriteLine("\nAnd works with different types of visitors");
var concreteVisitorB = new ConcreteVisitorB();

foreach(var component in components)
{
    component.Accept(concreteVisitorB);
}