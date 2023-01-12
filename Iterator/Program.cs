using Iterator.Aggregates;
using Iterator.Iterators;
using IteratorPattern;

var collection = new TreeCollection();

collection.AddItem(new Tree(description: "Tall Pine Tree"));
collection.AddItem(new Tree(description: "Red Leaf Tree"));
collection.AddItem(new Tree(description: "Palm Tree"));
collection.AddItem(new Tree(description: "Yellow Flower Tree"));


// I can implement different ways to iterate over this collection
ForestIterator forest = collection.GetEnumerator();

while (forest.HasNext())
{
    var currentTree = forest.Current();

    Console.WriteLine(currentTree.Description);

    forest.MoveNext();
}