using Observer.Observers;
using Observer.Subjects;

var subject = new Subject();

// Subscribing the observer to the subject
var observerA = new ConcreteObserverA();
subject.Attach(observerA);

var observerB = new ConcreteObserverB();
subject.Attach(observerB);

var observerC = new ConcreteObserverC();
subject.Attach(observerC);

subject.Something();
subject.Something();

subject.Detach(observerC);

subject.Something();