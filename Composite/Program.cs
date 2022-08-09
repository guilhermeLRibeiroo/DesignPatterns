using Entities;

// Simple Component
Leaf leaf = new Leaf();
ClientCode(leaf);

// Complex composites
Composite tree = new Composite();
Composite branch1 = new Composite();

branch1.Add(new Leaf());
branch1.Add(new Leaf());

Composite branch2 = new Composite();

branch2.Add(new Leaf());

tree.Add(branch1);
tree.Add(branch2);
Console.WriteLine("Composite Tree: ");
ClientCode(tree);

void ClientCode(Component leaf)
{
    Console.WriteLine($"Operation: {leaf.Operation()}\n");
}