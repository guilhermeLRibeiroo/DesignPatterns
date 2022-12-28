using Command;
using Command.Commands;

// Commands can be useful, for example, if you have buttons and a lot of "Commands" for them..
// Buttons act like invokers and you assign a command to them, so you don't need to create a variant of button every new feature you need.

Invoker invoker = new Invoker();
invoker.SetOnStart(new SimpleCommand("Hello World"));

Receiver receiver = new Receiver();
invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Save report"));

invoker.DoSomethingImportant();