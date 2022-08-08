using AbstractFactory;
using AbstractFactory.Factories;

Console.WriteLine("Application With Windows Config");
new Application(new WinFactory())
    .Paint();

Console.WriteLine("\nApplication With Mac Config");
new Application(new MacFactory())
    .Paint();
