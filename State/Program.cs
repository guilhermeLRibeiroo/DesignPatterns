using State;

var context = new Context(new ConcreteStateA());

// The context behavior is changed by the current state.

context.Something();
context.Something();

context.SomethingElse();
context.SomethingElse();