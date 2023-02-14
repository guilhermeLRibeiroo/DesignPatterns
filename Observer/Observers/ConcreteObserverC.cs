using Observer.Subjects;

namespace Observer.Observers
{
    public class ConcreteObserverC
        : IObserver
    {
        public void Update(ISubject subject)
        {
            Console.WriteLine("ConcreteObserverC is reacting to the event.");
        }
    }
}
