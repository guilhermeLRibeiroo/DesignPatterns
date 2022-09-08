using ChainOfResponsibility.Handlers;

var evenHandler = new EvenHandler();
var oddHandler = new OddHandler().SetNext(evenHandler);

int[] integers = { 1, 2, 3, 4, 5, 6, 7 };

foreach(int i in integers)
{
    var result = oddHandler.Execute(i);
    Console.WriteLine(result);
}