using TemplateMethod;

Console.WriteLine("The client code can work with ConcreteClassA implementation.");

new ConcreteClassA().TemplateMethod();

Console.WriteLine("\n");

Console.WriteLine("And can work with ConcreteClassB implementation.");

new ConcreteClassB().TemplateMethod();