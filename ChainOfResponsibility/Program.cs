using ChainOfResponsibility.Handlers;

// Basically this pattern resends the data to another object if he can't handle.

// If the evenHandler can't print the number, he will pass the data to the next handler..
// if the nextHandler can't print the number, he will do the same and so on..

var evenHandler = new EvenHandler();
var oddHandler = new OddHandler().SetNext(evenHandler);

int[] integers = { 1, 2, 3, 4, 5, 6, 7 };

foreach(int i in integers)
{
    var result = oddHandler.Execute(i);
    Console.WriteLine(result);
}