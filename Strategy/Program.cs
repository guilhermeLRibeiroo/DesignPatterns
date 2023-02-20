using Strategy;


// Strategy is set to ConcreteStrategyA (only sort)
Console.WriteLine("Sort Strategy");
var context = new Context(new ConcreteStrategyA());

context.DoSomeBusinessLogic();

Console.WriteLine();

// Strategy is set to ConcreteStrategyB (sort then reverse)
Console.WriteLine("Sort then Reverse Strategy");
context.SetStrategy(new ConcreteStrategyB());

context.DoSomeBusinessLogic();