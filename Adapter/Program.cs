using Adapters;
using Entities;
using Interfaces;

// Adapter makes Adaptee class compatible with the Target's interface.

Adaptee adaptee = new Adaptee();
ITarget adapter = new Adapter(adaptee);

Console.WriteLine(adapter.GetRequest());