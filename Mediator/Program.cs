using Mediator.Components;
using Mediator.Mediators;

var checkbox = new Checkbox();
var input = new Input();   

// You can introduce new ways for checkbox and input to work together just by creating a new mediator.
// Allows reusability of components.
new ConcreteMediator(checkbox, input);

// Checkbox can hide or show the input component without coupling.
checkbox.Check();
Console.WriteLine("--------------------------");
checkbox.Uncheck();
