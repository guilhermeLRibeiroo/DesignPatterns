// See https://aka.ms/new-console-template for more information
using FactoryMethod.Creators;

void ClientCode(AbstractCreator creator)
{
    // Some code..

    Console.WriteLine("Client: The client don't know the creator class but still works.. \n"
        + creator.Execute());

    // More code..
}

Console.WriteLine("App: First Product Factory:");
ClientCode(new FirstProductConcreteCreator());

Console.WriteLine("\nApp: Second Product Factory:");
ClientCode(new SecondProductConcreteCreator());